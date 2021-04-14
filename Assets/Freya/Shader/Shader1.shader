Shader "Unlit/Shader1"
{
    Properties
    {
        //_MainTex ("Texture", 2D) = "white" {}
        _ColorA( "ColorA", Color ) = (0.8,1,0.5,1)
        _ColorB("ColorB", Color) = (1,0.5,0.8,1)
        _ColorStart("ColorStart",Range(0,1)) = 0
        _ColorEnd("ColorEnd",Range(0,1)) = 1
    }
    SubShader 
    {
    Tags { "RenderType"="Opaque" }
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            float _ColorStart;
            float _ColorEnd;

            float4 _ColorA;
            float4 _ColorB;

            #define TAU 6.28318530718
            #include "UnityCG.cginc"
            
  //          sampler2D _MainTex;
  //          float4 _MainTex_ST;

            struct MeshData // Replaced from appdata.
            {
                float4 vertex : POSITION;
                float3 normalSS : NORMAL;
                float4 uv0 : TEXCOORD0;

            };

            struct Interpolateors
            {
                
  //              
 //               UNITY_FOG_COORDS(1)
                float4 vertex : SV_POSITION;
                float3 normal : TEXCOORD0;
                float2 uv : TEXCOORD1;
            };


            Interpolateors vert ( MeshData v )
            {
                Interpolateors o;
                o.vertex = UnityObjectToClipPos( v.vertex );
                o.normal = UnityObjectToWorldNormal( v.normalSS );
                o.uv = v.uv0;
  //              o.uv = TRANSFORM_TEX(v.uv, _MainTex);
 //               UNITY_TRANSFER_FOG(o,o.vertex);
                return o;
            }

            float InversLerp( float a , float b, float v )
            {
                return ( v-a )/( b-a );
            }

            fixed4 frag ( Interpolateors i ) : SV_Target
            {
               // return i.uv.y;
               // float t = saturate ( InversLerp (_ColorStart, _ColorEnd, i.uv.x));
 //               t = frac(t);
                float yOffset = ( 1 - i.uv.y ) + ( cos ( i.uv.y * TAU * 8 ) * 0.02 ); 
                float t = cos (( ( cos( i.uv.x * TAU * 8 + _Time.y*0.01  ) * 0.005 )
                 + yOffset + _Time.y * 0.05 ) * TAU * 8 ) * 0.5 +  0.5 ;

                return  t ;
              //  float4 ColorGradient = lerp ( _ColorA, _ColorB, t );
              // return ColorGradient;
            }
            ENDCG
        }
    }
}