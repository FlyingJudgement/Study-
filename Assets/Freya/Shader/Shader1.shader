Shader "Unlit/Shader1"
{
    Properties
    {
        //_MainTex ("Texture", 2D) = "white" {}
        _Color( "_Color", Color ) = (1,1,1,1)
    }
    SubShader 
    {
    Tags { "RenderType"="Opaque" }
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            float4 _Color;

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

            fixed4 frag ( Interpolateors i ) : SV_Target
            {
                return float4 ( i.uv,0,1 );
            }
            ENDCG
        }
    }
}
