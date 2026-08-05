using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AGRP.Passes;
using AGRP.RendererSetups;
using Cpp2IlInjected;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace AGRP
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public interface IBeforeCameraRender
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ExecuteBeforeCameraRender(AgainstGravityRenderPipeline pipelineInstance, ScriptableRenderContext context, Camera camera);
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface IAfterCameraRender
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ExecuteAfterCameraRender(AgainstGravityRenderPipeline pipelineInstance, ScriptableRenderContext context, Camera camera);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public sealed class AgainstGravityRenderPipeline : RenderPipeline
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private static class PerFrameBuffer
		{
			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			public static int _GlossyEnvironmentColor;

			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			public static int _SubtractiveShadowColor;
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private static class PerCameraBuffer
		{
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			public static int _InvCameraViewProj;

			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			public static int _ScaledScreenParams;
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public delegate void RenderCallback(AgainstGravityRenderPipeline pipelineInstance, ScriptableRenderContext context, Camera camera, AGRPAdditionalCameraData additionalCameraData);

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		internal struct PipelineSettings
		{
			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public DepthTextureRenderMode cameraDepthTextureMode
			{
				[Cpp2IlInjected.Token(Token = "0x60001CA")]
				[Cpp2IlInjected.Address(RVA = "0x118FC0", Offset = "0x1183C0", VA = "0x180118FC0")]
				[CompilerGenerated]
				get
				{
					return default(DepthTextureRenderMode);
				}
				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0x118FD0", Offset = "0x1183D0", VA = "0x180118FD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public bool supportsCameraOpaqueTexture
			{
				[Cpp2IlInjected.Token(Token = "0x60001CC")]
				[Cpp2IlInjected.Address(RVA = "0x193FF0", Offset = "0x1933F0", VA = "0x180193FF0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001CD")]
				[Cpp2IlInjected.Address(RVA = "0x1CACE0", Offset = "0x1CA0E0", VA = "0x1801CACE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public Downsampling opaqueDownsampling
			{
				[Cpp2IlInjected.Token(Token = "0x60001CE")]
				[Cpp2IlInjected.Address(RVA = "0x1258D0", Offset = "0x124CD0", VA = "0x1801258D0")]
				[CompilerGenerated]
				get
				{
					return default(Downsampling);
				}
				[Cpp2IlInjected.Token(Token = "0x60001CF")]
				[Cpp2IlInjected.Address(RVA = "0x1B44D0", Offset = "0x1B38D0", VA = "0x1801B44D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public bool supportsHDR
			{
				[Cpp2IlInjected.Token(Token = "0x60001D0")]
				[Cpp2IlInjected.Address(RVA = "0x1CABA0", Offset = "0x1C9FA0", VA = "0x1801CABA0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001D1")]
				[Cpp2IlInjected.Address(RVA = "0x1CAD00", Offset = "0x1CA100", VA = "0x1801CAD00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public int msaaSampleCount
			{
				[Cpp2IlInjected.Token(Token = "0x60001D2")]
				[Cpp2IlInjected.Address(RVA = "0x10B650", Offset = "0x10AA50", VA = "0x18010B650")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60001D3")]
				[Cpp2IlInjected.Address(RVA = "0x1B44B0", Offset = "0x1B38B0", VA = "0x1801B44B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000084")]
			public float renderScale
			{
				[Cpp2IlInjected.Token(Token = "0x60001D4")]
				[Cpp2IlInjected.Address(RVA = "0x1257C0", Offset = "0x124BC0", VA = "0x1801257C0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001D5")]
				[Cpp2IlInjected.Address(RVA = "0x1257F0", Offset = "0x124BF0", VA = "0x1801257F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000085")]
			public LightRenderingMode mainLightRenderingMode
			{
				[Cpp2IlInjected.Token(Token = "0x60001D6")]
				[Cpp2IlInjected.Address(RVA = "0x193380", Offset = "0x192780", VA = "0x180193380")]
				[CompilerGenerated]
				get
				{
					return default(LightRenderingMode);
				}
				[Cpp2IlInjected.Token(Token = "0x60001D7")]
				[Cpp2IlInjected.Address(RVA = "0x1CAC50", Offset = "0x1CA050", VA = "0x1801CAC50")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000086")]
			public bool supportsMainLightShadows
			{
				[Cpp2IlInjected.Token(Token = "0x60001D8")]
				[Cpp2IlInjected.Address(RVA = "0x1CABB0", Offset = "0x1C9FB0", VA = "0x1801CABB0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001D9")]
				[Cpp2IlInjected.Address(RVA = "0x1CAD10", Offset = "0x1CA110", VA = "0x1801CAD10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public int mainLightShadowmapResolution
			{
				[Cpp2IlInjected.Token(Token = "0x60001DA")]
				[Cpp2IlInjected.Address(RVA = "0x124590", Offset = "0x123990", VA = "0x180124590")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60001DB")]
				[Cpp2IlInjected.Address(RVA = "0x1B44E0", Offset = "0x1B38E0", VA = "0x1801B44E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			public LightRenderingMode additionalLightsRenderingMode
			{
				[Cpp2IlInjected.Token(Token = "0x60001DC")]
				[Cpp2IlInjected.Address(RVA = "0x1292C0", Offset = "0x1286C0", VA = "0x1801292C0")]
				[CompilerGenerated]
				get
				{
					return default(LightRenderingMode);
				}
				[Cpp2IlInjected.Token(Token = "0x60001DD")]
				[Cpp2IlInjected.Address(RVA = "0x1B44C0", Offset = "0x1B38C0", VA = "0x1801B44C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000089")]
			public int maxAdditionalLights
			{
				[Cpp2IlInjected.Token(Token = "0x60001DE")]
				[Cpp2IlInjected.Address(RVA = "0x1944A0", Offset = "0x1938A0", VA = "0x1801944A0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60001DF")]
				[Cpp2IlInjected.Address(RVA = "0x1944F0", Offset = "0x1938F0", VA = "0x1801944F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			public bool supportsAdditionalLightShadows
			{
				[Cpp2IlInjected.Token(Token = "0x60001E0")]
				[Cpp2IlInjected.Address(RVA = "0x1CAB80", Offset = "0x1C9F80", VA = "0x1801CAB80")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001E1")]
				[Cpp2IlInjected.Address(RVA = "0x1CACD0", Offset = "0x1CA0D0", VA = "0x1801CACD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			public int additionalLightsShadowmapResolution
			{
				[Cpp2IlInjected.Token(Token = "0x60001E2")]
				[Cpp2IlInjected.Address(RVA = "0x1B4BE0", Offset = "0x1B3FE0", VA = "0x1801B4BE0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60001E3")]
				[Cpp2IlInjected.Address(RVA = "0x1CAC10", Offset = "0x1CA010", VA = "0x1801CAC10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			public float shadowDistance
			{
				[Cpp2IlInjected.Token(Token = "0x60001E4")]
				[Cpp2IlInjected.Address(RVA = "0x1CAB70", Offset = "0x1C9F70", VA = "0x1801CAB70")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001E5")]
				[Cpp2IlInjected.Address(RVA = "0x1CACC0", Offset = "0x1CA0C0", VA = "0x1801CACC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public int cascadeCount
			{
				[Cpp2IlInjected.Token(Token = "0x60001E6")]
				[Cpp2IlInjected.Address(RVA = "0x1CAB00", Offset = "0x1C9F00", VA = "0x1801CAB00")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60001E7")]
				[Cpp2IlInjected.Address(RVA = "0x1CAC40", Offset = "0x1CA040", VA = "0x1801CAC40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public float cascade2Split
			{
				[Cpp2IlInjected.Token(Token = "0x60001E8")]
				[Cpp2IlInjected.Address(RVA = "0x1CAAD0", Offset = "0x1C9ED0", VA = "0x1801CAAD0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001E9")]
				[Cpp2IlInjected.Address(RVA = "0x1CAC20", Offset = "0x1CA020", VA = "0x1801CAC20")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public Vector3 cascade4Split
			{
				[Cpp2IlInjected.Token(Token = "0x60001EA")]
				[Cpp2IlInjected.Address(RVA = "0x1CAAE0", Offset = "0x1C9EE0", VA = "0x1801CAAE0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x60001EB")]
				[Cpp2IlInjected.Address(RVA = "0x1CAC30", Offset = "0x1CA030", VA = "0x1801CAC30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public float mainLightShadowDepthBias
			{
				[Cpp2IlInjected.Token(Token = "0x60001EC")]
				[Cpp2IlInjected.Address(RVA = "0x1CAB10", Offset = "0x1C9F10", VA = "0x1801CAB10")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001ED")]
				[Cpp2IlInjected.Address(RVA = "0x1CAC60", Offset = "0x1CA060", VA = "0x1801CAC60")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public float mainLightShadowNormalBias
			{
				[Cpp2IlInjected.Token(Token = "0x60001EE")]
				[Cpp2IlInjected.Address(RVA = "0x1CAB20", Offset = "0x1C9F20", VA = "0x1801CAB20")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001EF")]
				[Cpp2IlInjected.Address(RVA = "0x1CAC70", Offset = "0x1CA070", VA = "0x1801CAC70")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public float mainLightShadowSampleBias
			{
				[Cpp2IlInjected.Token(Token = "0x60001F0")]
				[Cpp2IlInjected.Address(RVA = "0x1CAB30", Offset = "0x1C9F30", VA = "0x1801CAB30")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001F1")]
				[Cpp2IlInjected.Address(RVA = "0x1CAC80", Offset = "0x1CA080", VA = "0x1801CAC80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public float additionalLightShadowDepthBias
			{
				[Cpp2IlInjected.Token(Token = "0x60001F2")]
				[Cpp2IlInjected.Address(RVA = "0x1CAAA0", Offset = "0x1C9EA0", VA = "0x1801CAAA0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001F3")]
				[Cpp2IlInjected.Address(RVA = "0x1CABE0", Offset = "0x1C9FE0", VA = "0x1801CABE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public float additionalLightShadowNormalBias
			{
				[Cpp2IlInjected.Token(Token = "0x60001F4")]
				[Cpp2IlInjected.Address(RVA = "0x1CAAB0", Offset = "0x1C9EB0", VA = "0x1801CAAB0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001F5")]
				[Cpp2IlInjected.Address(RVA = "0x1CABF0", Offset = "0x1C9FF0", VA = "0x1801CABF0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public float additionalLightShadowSampleBias
			{
				[Cpp2IlInjected.Token(Token = "0x60001F6")]
				[Cpp2IlInjected.Address(RVA = "0x1CAAC0", Offset = "0x1C9EC0", VA = "0x1801CAAC0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001F7")]
				[Cpp2IlInjected.Address(RVA = "0x1CAC00", Offset = "0x1CA000", VA = "0x1801CAC00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public bool supportsSoftShadows
			{
				[Cpp2IlInjected.Token(Token = "0x60001F8")]
				[Cpp2IlInjected.Address(RVA = "0x1CABC0", Offset = "0x1C9FC0", VA = "0x1801CABC0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001F9")]
				[Cpp2IlInjected.Address(RVA = "0x1CAD20", Offset = "0x1CA120", VA = "0x1801CAD20")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public bool supportsDynamicBatching
			{
				[Cpp2IlInjected.Token(Token = "0x60001FA")]
				[Cpp2IlInjected.Address(RVA = "0x1CAB90", Offset = "0x1C9F90", VA = "0x1801CAB90")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001FB")]
				[Cpp2IlInjected.Address(RVA = "0x1CACF0", Offset = "0x1CA0F0", VA = "0x1801CACF0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public bool mixedLightingSupported
			{
				[Cpp2IlInjected.Token(Token = "0x60001FC")]
				[Cpp2IlInjected.Address(RVA = "0x1CAB40", Offset = "0x1C9F40", VA = "0x1801CAB40")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001FD")]
				[Cpp2IlInjected.Address(RVA = "0x1CAC90", Offset = "0x1CA090", VA = "0x1801CAC90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public bool supportsUGCMeshLODs
			{
				[Cpp2IlInjected.Token(Token = "0x60001FE")]
				[Cpp2IlInjected.Address(RVA = "0x1CABD0", Offset = "0x1C9FD0", VA = "0x1801CABD0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001FF")]
				[Cpp2IlInjected.Address(RVA = "0x1CAD30", Offset = "0x1CA130", VA = "0x1801CAD30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public RenderFeaturesetOption renderFeatureset
			{
				[Cpp2IlInjected.Token(Token = "0x6000200")]
				[Cpp2IlInjected.Address(RVA = "0x1CAB60", Offset = "0x1C9F60", VA = "0x1801CAB60")]
				[CompilerGenerated]
				get
				{
					return default(RenderFeaturesetOption);
				}
				[Cpp2IlInjected.Token(Token = "0x6000201")]
				[Cpp2IlInjected.Address(RVA = "0x1CACB0", Offset = "0x1CA0B0", VA = "0x1801CACB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			public PostProcessingOption postProcessing
			{
				[Cpp2IlInjected.Token(Token = "0x6000202")]
				[Cpp2IlInjected.Address(RVA = "0x1CAB50", Offset = "0x1C9F50", VA = "0x1801CAB50")]
				[CompilerGenerated]
				get
				{
					return default(PostProcessingOption);
				}
				[Cpp2IlInjected.Token(Token = "0x6000203")]
				[Cpp2IlInjected.Address(RVA = "0x1CACA0", Offset = "0x1CA0A0", VA = "0x1801CACA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x12F47B0", Offset = "0x12F3BB0", VA = "0x1812F47B0")]
			public static PipelineSettings Create(AgainstGravityRenderPipelineAsset asset)
			{
				return default(PipelineSettings);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private struct CameraCallbacks
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public List<IBeforeCameraRender> beforeRenderBuffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public List<IAfterCameraRender> afterRenderBuffer;

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x1CA9E0", Offset = "0x1C9DE0", VA = "0x1801CA9E0")]
			public void Clear()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public const string k_ShaderTagName = "AGRP";

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public static RenderFeaturesetOption ActiveRenderFeatureset;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public static PostProcessingOption ActivePostProcessingOption;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public static bool SupportsUGCMeshLODs;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static IRendererSetup s_DefaultRendererSetup;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const string k_RenderCameraTag = "Render Camera";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private CullResults m_CullResults;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly List<CameraCallbacks> currentlyRenderingCameras;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static int currentCameraIdx;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static List<Vector4> m_ShadowBiasData;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static IRendererSetup defaultRendererSetup
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x12EA4C0", Offset = "0x12E98C0", VA = "0x1812EA4C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public ScriptableRenderer renderer
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x33EB40", Offset = "0x33DF40", VA = "0x18033EB40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x34FD50", Offset = "0x34F150", VA = "0x18034FD50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private PipelineSettings settings
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x12EA5B0", Offset = "0x12E99B0", VA = "0x1812EA5B0")]
			[CompilerGenerated]
			get
			{
				return default(PipelineSettings);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x12EA800", Offset = "0x12E9C00", VA = "0x1812EA800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public static event RenderCallback BeforeCameraRenderEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x12EA3C0", Offset = "0x12E97C0", VA = "0x1812EA3C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x12EA700", Offset = "0x12E9B00", VA = "0x1812EA700")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public static event RenderCallback AfterCameraRenderEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x12EA2C0", Offset = "0x12E96C0", VA = "0x1812EA2C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x12EA600", Offset = "0x12E9A00", VA = "0x1812EA600")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x12E9F80", Offset = "0x12E9380", VA = "0x1812E9F80")]
		public AgainstGravityRenderPipeline(AgainstGravityRenderPipelineAsset asset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x12E6FB0", Offset = "0x12E63B0", VA = "0x1812E6FB0", Slot = "8")]
		public sealed override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x12E8D40", Offset = "0x12E8140", VA = "0x1812E8D40", Slot = "7")]
		public override void Render(ScriptableRenderContext renderContext, Camera[] cameras)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x12E8430", Offset = "0x12E7830", VA = "0x1812E8430")]
		public static void RenderSingleCamera(AgainstGravityRenderPipeline pipelineInstance, ScriptableRenderContext context, Camera camera, ref CullResults cullResults, AGRPAdditionalCameraData additionalCameraData, [Optional] IRendererSetup setup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x311320", Offset = "0x310720", VA = "0x180311320")]
		private static void SetSupportedRenderingFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x12E7130", Offset = "0x12E6530", VA = "0x1812E7130")]
		private static void InitializeCameraData(PipelineSettings settings, Camera camera, AGRPAdditionalCameraData additionalCameraData, out CameraData cameraData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x12E78A0", Offset = "0x12E6CA0", VA = "0x1812E78A0")]
		private static void InitializeRenderingData(PipelineSettings settings, ref CameraData cameraData, ref CullResults cullResults, int maxVisibleAdditionalLights, int maxPerObjectAdditionalLights, ILightDataInterpreter lightInterpreter, out RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x12E7E40", Offset = "0x12E7240", VA = "0x1812E7E40")]
		private static void InitializeShadowData(PipelineSettings settings, ref LightData lightData, bool mainLightCastShadows, bool additionalLightsCastShadows, out ShadowData shadowData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x12E7760", Offset = "0x12E6B60", VA = "0x1812E7760")]
		private static void InitializeLightData(PipelineSettings settings, int lightCount, int mainLightIndex, int maxAdditionalLights, int maxPerObjectAdditionalLights, ref LightData lightData, ref CameraData cameraData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x12E7060", Offset = "0x12E6460", VA = "0x1812E7060")]
		private static int GetMainLight(LightRenderingMode mode, ref LightData lightData)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x12E9BA0", Offset = "0x12E8FA0", VA = "0x1812E9BA0")]
		private static void SetupPerFrameShaderConstants()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x12E9840", Offset = "0x12E8C40", VA = "0x1812E9840")]
		private static void SetupPerCameraShaderConstants(CameraData cameraData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x12E8350", Offset = "0x12E7750", VA = "0x1812E8350")]
		public static bool IsStereoEnabled(Camera camera)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x12E9DC0", Offset = "0x12E91C0", VA = "0x1812E9DC0")]
		private void SortCameras(Camera[] cameras)
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum MixedLightingSetup
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		ShadowMask,
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		Subtractive
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct RenderingData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public CullResults cullResults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public CameraData cameraData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public LightData lightData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public ShadowData shadowData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public bool supportsDynamicBatching;
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct LightData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int mainLightIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int additionalLightsCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int maxPerObjectAdditionalLightsCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public bool shadeAdditionalLightsPerVertex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public bool supportsMixedLighting;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public bool supportsAdditionalLights;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public List<BinnableLight> allBinnableLights;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public List<VisibleLight> visibleLights;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public ILightDataInterpreter lightInterpreter;
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct CameraData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public Camera camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AGRPAdditionalCameraData additionalCameraData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public float renderScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public int msaaSamples;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public bool isSceneViewCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public bool isDefaultViewport;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public bool isOffscreenRender;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public bool isHdrEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public DepthTextureRenderMode depthTextureMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public bool requiresOpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public Downsampling opaqueTextureDownsampling;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public SortFlags defaultOpaqueSortFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public bool isStereoEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public float maxShadowDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public PostProcessingOption postProcessing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public PostProcessLayer postProcessLayer;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct ShadowData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public bool supportsMainLightShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public bool requiresScreenSpaceShadowResolve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public int mainLightShadowmapWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int mainLightShadowmapHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int mainLightShadowCascadesCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public Vector3 mainLightShadowCascadesSplit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float mainLightShadowsSampleBias;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public bool supportsAdditionalLightShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int additionalLightsShadowmapWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int additionalLightsShadowmapHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public bool supportsSoftShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int shadowmapDepthBufferBits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public Vector4 defaultBias;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public List<Vector4> bias;
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class ShaderKeywordStrings
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly string MainLightShadows;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly string MainLightShadowCascades;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly string AdditionalLightsVertex;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly string AdditionalLightsPixel;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly string AdditionalLightShadows;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public static readonly string SoftShadows;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly string MixedLightingSubtractive;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public static readonly string RenderFeaturesetMobile;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly string RenderFeaturesetFull;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public static readonly string DepthTexture;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly string DepthNoMsaa;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public static readonly string DepthMsaa2;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public static readonly string DepthMsaa4;
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum CameraOverrideOption
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		On,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		UsePipelineSettings
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[DisallowMultipleComponent]
	[ImageEffectAllowedInSceneView]
	[RequireComponent(typeof(Camera))]
	public class AGRPAdditionalCameraData : MonoBehaviour, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		[Tooltip("If enabled shadows will render for this camera.")]
		[FormerlySerializedAs("renderShadows")]
		private bool m_RenderShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[SerializeField]
		[Tooltip("If enabled this camera will be used for rendering operations that only happen once per frame such as light binning.")]
		private bool m_IsMainCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		[Tooltip("If enabled opaque color texture will render for this camera and bound as _CameraOpaqueTexture.")]
		private CameraOverrideOption m_RequiresOpaqueTextureOption;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[SerializeField]
		private bool m_DisableAdditionalLights;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[SerializeField]
		[Tooltip("If enabled, mirrors should always render for this camera")]
		private bool m_forceRenderMirrors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		[FormerlySerializedAs("requiresDepthTexture")]
		private bool m_RequiresDepthTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		[FormerlySerializedAs("requiresColorTexture")]
		private bool m_RequiresColorTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[HideInInspector]
		[SerializeField]
		private float m_Version;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float version
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5180C0", Offset = "0x5174C0", VA = "0x1805180C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool renderShadows
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x340EF0", Offset = "0x3402F0", VA = "0x180340EF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x340FB0", Offset = "0x3403B0", VA = "0x180340FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool disableAdditionalLights
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x34D710", Offset = "0x34CB10", VA = "0x18034D710")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x36CEC0", Offset = "0x36C2C0", VA = "0x18036CEC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool isMainCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x5E6710", Offset = "0x5E5B10", VA = "0x1805E6710")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x430160", Offset = "0x42F560", VA = "0x180430160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool forceRenderMirrors
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x9E22D0", Offset = "0x9E16D0", VA = "0x1809E22D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x9E2720", Offset = "0x9E1B20", VA = "0x1809E2720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public CameraOverrideOption requiresColorOption
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x69F8B0", Offset = "0x69ECB0", VA = "0x18069F8B0")]
			get
			{
				return default(CameraOverrideOption);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x69F8C0", Offset = "0x69ECC0", VA = "0x18069F8C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool IsSimpleUIViewCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x676F80", Offset = "0x676380", VA = "0x180676F80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6AB080", Offset = "0x6AA480", VA = "0x1806AB080")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool requiresColorTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x12E4640", Offset = "0x12E3A40", VA = "0x1812E4640")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x12E4720", Offset = "0x12E3B20", VA = "0x1812E4720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x311320", Offset = "0x310720", VA = "0x180311320", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x12E4600", Offset = "0x12E3A00", VA = "0x1812E4600", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x12E4620", Offset = "0x12E3A20", VA = "0x1812E4620")]
		public AGRPAdditionalCameraData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Light))]
	public class AGRPAdditionalLightData : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[Tooltip("Controls the usage of pipeline settings.")]
		private bool m_UsePipelineSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		private float m_shadowSampleBias;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool usePipelineSettings
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x340EF0", Offset = "0x3402F0", VA = "0x180340EF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x340FB0", Offset = "0x3403B0", VA = "0x180340FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public float shadowSampleBias
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x354670", Offset = "0x353A70", VA = "0x180354670")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7566E0", Offset = "0x755AE0", VA = "0x1807566E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x45CDB0", Offset = "0x45C1B0", VA = "0x18045CDB0")]
		public AGRPAdditionalLightData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class AGRPConsts
	{
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public const int VOXEL_COUNT_WIDTH = 24;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public const int VOXEL_COUNT_HEIGHT = 12;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public const int VOXEL_COUNT_DEPTH = 24;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public const float VOXEL_SIZE_METERS = 5f;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public const float VOXEL_BOUNDING_SPHERE_RADIUS = 3.535534f;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public const int MAX_LIGHTS_IN_SCENE = 160;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public const float MAX_CACHED_SHADOW_RENDER_DISTANCE = 30f;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public const float MAX_CACHED_SHADOW_RENDER_DISTANCE_SQR = 900f;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private const float SQRT_TWO_OVER_TWO = 0.70710677f;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public const int FIXED_VOXEL_LIGHT_COUNT = 8;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private const int VOXEL_HEADER_SIZE_MOBILE = 0;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private const int VOXEL_HEADER_SIZE_FULLY_FEATURED = 1;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public const int VOXEL_COUNT_PER_DEPTH_LAYER = 288;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public const int VOXEL_COUNT = 6912;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x12E4740", Offset = "0x12E3B40", VA = "0x1812E4740")]
		public static int GetFixedVoxelSize(RenderFeaturesetOption renderFeatureSet)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x12E4750", Offset = "0x12E3B50", VA = "0x1812E4750")]
		public static int GetLightBinHeaderSize(RenderFeaturesetOption renderFeatureSet)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Light))]
	public class AGRPLight : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public static readonly List<AGRPLight> AllLights;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly List<BinnableLight> AllBinnableLights;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[Range(0f, 1f)]
		public float specularContribution;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Header("Hemisphere Lights")]
		public bool isHemisphereLight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Range(0f, 180f)]
		public float hemisphereLightInnerAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Range(0f, 180f)]
		public float hemisphereLightOuterAngle;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Light UnityLight
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x320A10", Offset = "0x31FE10", VA = "0x180320A10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x345980", Offset = "0x344D80", VA = "0x180345980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x12E4CA0", Offset = "0x12E40A0", VA = "0x1812E4CA0")]
		public static void UpdateBinnableLights()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x12E47C0", Offset = "0x12E3BC0", VA = "0x1812E47C0")]
		public static List<BinnableLight> GetCurrentBinnableLights()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x12E4760", Offset = "0x12E3B60", VA = "0x1812E4760")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x12E49E0", Offset = "0x12E3DE0", VA = "0x1812E49E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x12E4820", Offset = "0x12E3C20", VA = "0x1812E4820")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x12E4C20", Offset = "0x12E4020", VA = "0x1812E4C20")]
		private static void TrackLight(AGRPLight light)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x12E4AA0", Offset = "0x12E3EA0", VA = "0x1812E4AA0")]
		private static void StopTrackingLight(AGRPLight light)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x12E51F0", Offset = "0x12E45F0", VA = "0x1812E51F0")]
		public AGRPLight()
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum RenderFeaturesetOption
	{
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		Mobile,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		FullyFeatured
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum DepthTextureRenderMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		Required,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		Automatic,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		Disabled
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum ShadowCascadesOption
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		NoCascades,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		TwoCascades,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		FourCascades
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum ShadowQuality
	{
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		Disabled,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		HardShadows,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		SoftShadows
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum ShadowResolution
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		_256 = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		_512 = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		_1024 = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		_2048 = 0x800,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		_4096 = 0x1000
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum MsaaQuality
	{
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		Disabled = 1,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		_2x = 2,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		_4x = 4,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		_8x = 8
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum Downsampling
	{
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		_2xBilinear,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		_4xBox,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		_4xBilinear
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal enum DefaultMaterialType
	{
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		Standard,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		Particle,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		Terrain,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		UnityBuiltinDefault
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum LightRenderingMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		Disabled = 0,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		PerVertex = 2,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		PerPixel = 1
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public enum PostProcessingOption
	{
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		Mobile,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		Full
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public enum ShaderVariantLogLevel
	{
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		Disabled,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		OnlyAGRPShaders,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		AllShaders
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class AgainstGravityRenderPipelineAsset : RenderPipelineAsset, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private Shader m_DefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		private int k_AssetVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		private RenderFeaturesetOption m_RenderFeatureset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		private DepthTextureRenderMode m_DepthTextureMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		private PostProcessingOption m_PostProcessing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		private bool m_RequireOpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		private Downsampling m_OpaqueDownsampling;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[SerializeField]
		private bool m_SupportsHDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[SerializeField]
		private MsaaQuality m_MSAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[SerializeField]
		private float m_RenderScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[SerializeField]
		private bool m_SupportsUGCMeshLODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[SerializeField]
		private LightRenderingMode m_MainLightRenderingMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[SerializeField]
		private bool m_MainLightShadowsSupported;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[SerializeField]
		private ShadowResolution m_MainLightShadowmapResolution;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[SerializeField]
		private LightRenderingMode m_AdditionalLightsRenderingMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[SerializeField]
		private int m_AdditionalLightsPerObjectLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[SerializeField]
		private bool m_AdditionalLightShadowsSupported;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[SerializeField]
		private ShadowResolution m_AdditionalLightsShadowmapResolution;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[SerializeField]
		private float m_ShadowDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[SerializeField]
		private ShadowCascadesOption m_ShadowCascades;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[SerializeField]
		private float m_Cascade2Split;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[SerializeField]
		private Vector3 m_Cascade4Split;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[SerializeField]
		private float m_mainLightShadowDepthBias;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[SerializeField]
		private float m_mainLightShadowNormalBias;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[SerializeField]
		private float m_mainLightShadowSampleBias;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[SerializeField]
		private float m_additionalLightShadowDepthBias;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[SerializeField]
		private float m_additionalLightShadowNormalBias;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[SerializeField]
		private float m_additionalLightShadowSampleBias;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[SerializeField]
		private bool m_SoftShadowsSupported;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[SerializeField]
		private bool m_SupportsDynamicBatching;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		[SerializeField]
		private bool m_MixedLightingSupported;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		[SerializeField]
		private ShadowQuality m_ShadowType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		[SerializeField]
		private bool m_LocalShadowsSupported;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		[SerializeField]
		private ShadowResolution m_LocalShadowsAtlasResolution;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		[SerializeField]
		private int m_MaxPixelLights;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		[SerializeField]
		private ShadowResolution m_ShadowAtlasResolution;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		[SerializeField]
		private AgainstGravityRenderPipelineResources m_ResourcesAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[SerializeField]
		private ShaderVariantLogLevel m_ShaderVariantLogLevel;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private AgainstGravityRenderPipelineResources resources
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x472180", Offset = "0x471580", VA = "0x180472180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public DepthTextureRenderMode depthTextureMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x3C3D00", Offset = "0x3C3100", VA = "0x1803C3D00")]
			get
			{
				return default(DepthTextureRenderMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public PostProcessingOption postProcessing
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x485740", Offset = "0x484B40", VA = "0x180485740")]
			get
			{
				return default(PostProcessingOption);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool supportsCameraOpaqueTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x34D6F0", Offset = "0x34CAF0", VA = "0x18034D6F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public RenderFeaturesetOption renderFeatureset
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x49A670", Offset = "0x499A70", VA = "0x18049A670")]
			get
			{
				return default(RenderFeaturesetOption);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Downsampling opaqueDownsampling
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x642120", Offset = "0x641520", VA = "0x180642120")]
			get
			{
				return default(Downsampling);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool supportsHDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5E6910", Offset = "0x5E5D10", VA = "0x1805E6910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int msaaSampleCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x758F10", Offset = "0x758310", VA = "0x180758F10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float renderScale
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x4A9D30", Offset = "0x4A9130", VA = "0x1804A9D30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool supportsUGCMeshLODs
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x34D730", Offset = "0x34CB30", VA = "0x18034D730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public LightRenderingMode mainLightRenderingMode
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x34D720", Offset = "0x34CB20", VA = "0x18034D720")]
			get
			{
				return default(LightRenderingMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool supportsMainLightShadows
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x34D6E0", Offset = "0x34CAE0", VA = "0x18034D6E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ShadowResolution mainLightShadowmapResolution
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x4AF070", Offset = "0x4AE470", VA = "0x1804AF070")]
			get
			{
				return default(ShadowResolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public LightRenderingMode additionalLightsRenderingMode
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5A5370", Offset = "0x5A4770", VA = "0x1805A5370")]
			get
			{
				return default(LightRenderingMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int maxAdditionalLightsCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x557A00", Offset = "0x556E00", VA = "0x180557A00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool supportsAdditionalLightShadows
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x3FFB90", Offset = "0x3FEF90", VA = "0x1803FFB90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public ShadowResolution additionalLightsShadowmapResolution
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x4723D0", Offset = "0x4717D0", VA = "0x1804723D0")]
			get
			{
				return default(ShadowResolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float shadowDistance
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xDF4CF0", Offset = "0xDF40F0", VA = "0x180DF4CF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public ShadowCascadesOption cascadeCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5B2C70", Offset = "0x5B2070", VA = "0x1805B2C70")]
			get
			{
				return default(ShadowCascadesOption);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float cascade2Split
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x875580", Offset = "0x874980", VA = "0x180875580")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 cascade4Split
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x34B6C0", Offset = "0x34AAC0", VA = "0x18034B6C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float mainLightShadowDepthBias
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x580490", Offset = "0x57F890", VA = "0x180580490")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float mainLightShadowNormalBias
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7C8E30", Offset = "0x7C8230", VA = "0x1807C8E30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float mainLightShadowSampleBias
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8423E0", Offset = "0x8417E0", VA = "0x1808423E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float additionalLightShadowDepthBias
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x780A60", Offset = "0x77FE60", VA = "0x180780A60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float additionalLightShadowNormalBias
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x10D3C80", Offset = "0x10D3080", VA = "0x1810D3C80")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public float additionalLightShadowSampleBias
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x12E6C30", Offset = "0x12E6030", VA = "0x1812E6C30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool supportsSoftShadows
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x842530", Offset = "0x841930", VA = "0x180842530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool supportsDynamicBatching
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x842520", Offset = "0x841920", VA = "0x180842520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool supportsMixedLighting
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x12E6FA0", Offset = "0x12E63A0", VA = "0x1812E6FA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public ShaderVariantLogLevel shaderVariantLogLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x1289740", Offset = "0x1288B40", VA = "0x181289740")]
			get
			{
				return default(ShaderVariantLogLevel);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Shader blitShader
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x12E6C40", Offset = "0x12E6040", VA = "0x1812E6C40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Shader copyDepthShader
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x12E6CD0", Offset = "0x12E60D0", VA = "0x1812E6CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Shader screenSpaceShadowShader
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x12E6F10", Offset = "0x12E6310", VA = "0x1812E6F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public Shader samplingShader
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x12E6E80", Offset = "0x12E6280", VA = "0x1812E6E80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Shader mobileFadeEffectShader
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x12E6D60", Offset = "0x12E6160", VA = "0x1812E6D60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public Shader mobileVignetteEffectShader
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x12E6DF0", Offset = "0x12E61F0", VA = "0x1812E6DF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x12E6A50", Offset = "0x12E5E50", VA = "0x1812E6A50", Slot = "19")]
		protected override IRenderPipeline InternalCreatePipeline()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x38E920", Offset = "0x38DD20", VA = "0x18038E920")]
		private Material GetMaterial(DefaultMaterialType materialType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x38E920", Offset = "0x38DD20", VA = "0x18038E920", Slot = "7")]
		public override Material GetDefaultMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x38E920", Offset = "0x38DD20", VA = "0x18038E920", Slot = "11")]
		public override Material GetDefaultParticleMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x38E920", Offset = "0x38DD20", VA = "0x18038E920", Slot = "12")]
		public override Material GetDefaultLineMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x38E920", Offset = "0x38DD20", VA = "0x18038E920", Slot = "13")]
		public override Material GetDefaultTerrainMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x38E920", Offset = "0x38DD20", VA = "0x18038E920", Slot = "14")]
		public override Material GetDefaultUIMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x38E920", Offset = "0x38DD20", VA = "0x18038E920", Slot = "15")]
		public override Material GetDefaultUIOverdrawMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x38E920", Offset = "0x38DD20", VA = "0x18038E920", Slot = "16")]
		public override Material GetDefaultUIETC1SupportedMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x38E920", Offset = "0x38DD20", VA = "0x18038E920", Slot = "17")]
		public override Material GetDefault2DMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x12E69B0", Offset = "0x12E5DB0", VA = "0x1812E69B0", Slot = "18")]
		public override Shader GetDefaultShader()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x311320", Offset = "0x310720", VA = "0x180311320", Slot = "22")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x12E6AB0", Offset = "0x12E5EB0", VA = "0x1812E6AB0", Slot = "23")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x12E6B20", Offset = "0x12E5F20", VA = "0x1812E6B20")]
		public AgainstGravityRenderPipelineAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class AgainstGravityRenderPipelineEditorResources : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[SerializeField]
		[FormerlySerializedAs("DefaultMaterial")]
		private Material m_LitMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[SerializeField]
		[FormerlySerializedAs("DefaultParticleMaterial")]
		private Material m_ParticleLitMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		[SerializeField]
		[FormerlySerializedAs("DefaultTerrainMaterial")]
		private Material m_TerrainLitMaterial;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Material litMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x3108F0", Offset = "0x30FCF0", VA = "0x1803108F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Material particleLitMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x3220C0", Offset = "0x3214C0", VA = "0x1803220C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Material terrainLitMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x320A10", Offset = "0x31FE10", VA = "0x180320A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x38C340", Offset = "0x38B740", VA = "0x18038C340")]
		public AgainstGravityRenderPipelineEditorResources()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class AgainstGravityRenderPipelineResources : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[SerializeField]
		[FormerlySerializedAs("BlitShader")]
		private Shader m_BlitShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		[SerializeField]
		[FormerlySerializedAs("CopyDepthShader")]
		private Shader m_CopyDepthShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[SerializeField]
		[FormerlySerializedAs("ScreenSpaceShadowShader")]
		private Shader m_ScreenSpaceShadowShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		[SerializeField]
		[FormerlySerializedAs("SamplingShader")]
		private Shader m_SamplingShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[SerializeField]
		private Shader m_MobileFadeEffectShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		[SerializeField]
		private Shader m_MobileVignetteEffectShader;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Shader blitShader
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x3108F0", Offset = "0x30FCF0", VA = "0x1803108F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public Shader copyDepthShader
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x3220C0", Offset = "0x3214C0", VA = "0x1803220C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public Shader screenSpaceShadowShader
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x320A10", Offset = "0x31FE10", VA = "0x180320A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public Shader samplingShader
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x3457B0", Offset = "0x344BB0", VA = "0x1803457B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public Shader mobileFadeEffectShader
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x354C90", Offset = "0x354090", VA = "0x180354C90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Shader mobileVignetteEffectShader
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x33EB40", Offset = "0x33DF40", VA = "0x18033EB40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x38C340", Offset = "0x38B740", VA = "0x18038C340")]
		public AgainstGravityRenderPipelineResources()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal sealed class DefaultRendererSetup : IRendererSetup
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private RendererSetupSimpleUIView simpleUIViewRenderSetup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private IRendererSetup rendererSetup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private ILightDataInterpreter lightInterpreter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private RenderFeaturesetOption currentOption;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public ILightDataInterpreter LightInterpreter
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x3220C0", Offset = "0x3214C0", VA = "0x1803220C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x12EF250", Offset = "0x12EE650", VA = "0x1812EF250")]
		private IRendererSetup GetOrAssignRendererSetup(ScriptableRenderer renderer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x12EF3C0", Offset = "0x12EE7C0", VA = "0x1812EF3C0", Slot = "4")]
		public void PreCullSetup(ScriptableRenderer renderer, ScriptableRenderContext context, Camera camera, CameraData cameraData, ref LightData lightData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x12EF5C0", Offset = "0x12EE9C0", VA = "0x1812EF5C0", Slot = "5")]
		public void Setup(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x12EF1E0", Offset = "0x12EE5E0", VA = "0x1812EF1E0")]
		public Light GetLight(ref LightData lightData, int lightIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x12EF010", Offset = "0x12EE410", VA = "0x1812EF010")]
		public AGRPLight GetAGRPLight(ref LightData lightData, int lightIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x12EF0E0", Offset = "0x12EE4E0", VA = "0x1812EF0E0")]
		public int GetLightCount(ref LightData lightData)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x12EF140", Offset = "0x12EE540", VA = "0x1812EF140")]
		public bool GetLightInfo(ref LightData lightData, int lightIdx, out Vector4 pos, out Vector4 dir, out Color finalColor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x12EEF90", Offset = "0x12EE390", VA = "0x1812EEF90")]
		public int CopyToBinnableLights(ref LightData lightData, BinnableLight[] binnableLightBuffer, int maxLightCount)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3107E0", Offset = "0x30FBE0", VA = "0x1803107E0")]
		public DefaultRendererSetup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface ILightDataInterpreter
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Light GetLight(ref LightData lightData, int lightIdx);

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		AGRPLight GetAGRPLight(ref LightData lightData, int lightIdx);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int GetLightCount(ref LightData lightData);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool GetLightInfo(ref LightData lightData, int lightIdx, out Vector4 pos, out Vector4 dir, out Color finalColor);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		int CopyToBinnableLights(ref LightData lightData, BinnableLight[] binnableLightBuffer, int maxLightCount);
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public interface IRendererSetup
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		ILightDataInterpreter LightInterpreter
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PreCullSetup(ScriptableRenderer renderer, ScriptableRenderContext context, Camera camera, CameraData cameraData, ref LightData lightData);

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Setup(ScriptableRenderer renderer, ref RenderingData renderingData);
	}
	[StructLayout((LayoutKind)0, Size = 100)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct BinnableLight
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int globalIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public LightType lightType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public float4x4 localToWorld;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public float approxIntensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public float range;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public float spotAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public Color finalColor;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public AGRPLight AGRPLight
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x1CA8D0", Offset = "0x1C9CD0", VA = "0x1801CA8D0")]
			get
			{
				return null;
			}
		}
	}
	[StructLayout((LayoutKind)0, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public struct LightInBin
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public ushort lightIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public float clusterImportance;
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[BurstCompile]
	public struct CalculateVoxelPoints : IJobParallelFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[WriteOnly]
		public NativeArray<float3> voxelPoints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[ReadOnly]
		public float3 worldVolumeMinCorner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[ReadOnly]
		public float3 worldVolumeMaxCorner;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1CA8E0", Offset = "0x1C9CE0", VA = "0x1801CA8E0", Slot = "4")]
		public void Execute(int index)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[BurstCompile]
	public struct BinPerLightJob : IJobParallelFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[ReadOnly]
		public NativeArray<BinnableLight> lights;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[ReadOnly]
		public NativeArray<float3> voxelPoints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[ReadOnly]
		public float3 worldVolumeMinCorner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		[ReadOnly]
		public float3 worldVolumeMaxCorner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		[WriteOnly]
		public NativeMultiHashMap<ushort, LightInBin>.Concurrent clusteredLightIndices;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1CA680", Offset = "0x1C9A80", VA = "0x1801CA680", Slot = "4")]
		public void Execute(int lightIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1CA3C0", Offset = "0x1C97C0", VA = "0x1801CA3C0")]
		private void AddPointLightImportances(uint3 minVoxelIdx, uint3 maxVoxelIdx, ushort lightIdx, float3 lightPos, float lightIntensity, float lightRange)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1CA450", Offset = "0x1C9850", VA = "0x1801CA450")]
		private void AddSpotLightImportances(uint3 minVoxelIdx, uint3 maxVoxelIdx, ushort lightIdx, float3 lightPos, float3 expandedLightPos, float3 lightForward, float lightIntensity, float lightBaseRadius, float lightRange, float expandedLightRange)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x1CA720", Offset = "0x1C9B20", VA = "0x1801CA720")]
		private float PointLightIntensity(float approxIntensity)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1CA690", Offset = "0x1C9A90", VA = "0x1801CA690")]
		private float LinearAttenuation(float3 voxelCenter, float3 lightPos, float lightRange)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1CA550", Offset = "0x1C9950", VA = "0x1801CA550")]
		private float AngularAttenuation(float3 voxelCenter, float3 lightPos, float3 lightForward, float lightBaseRadius, float lightRange)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[BurstCompile]
	public struct BinPerVoxelJob : IJobParallelForBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		[ReadOnly]
		public NativeMultiHashMap<ushort, LightInBin> clusteredLightIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		[ReadOnly]
		public uint lightCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		[ReadOnly]
		public int headerSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public NativeArray<uint> voxels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public NativeArray<float> importances;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1CA770", Offset = "0x1C9B70", VA = "0x1801CA770", Slot = "4")]
		public void Execute(int voxelStartIdx, int voxelCapacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1CA760", Offset = "0x1C9B60", VA = "0x1801CA760")]
		private void AddLight(int lightingStartIdx, ushort lightsInCurrentVoxel, int lightCapacity, LightInBin lightInVoxelData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[BurstCompile]
	public struct ClearBufferJob<T, U> : IJob where T : struct, IEquatable<T> where U : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public NativeMultiHashMap<T, U> bufferToClear;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x146640", Offset = "0x145A40", VA = "0x180146640", Slot = "4")]
		public void Execute()
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public enum MaterialHandle
	{
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		CopyDepth,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		Sampling,
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		Blit,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		ScreenSpaceShadow,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		Count
	}
	[StructLayout((LayoutKind)0, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct RenderTargetHandle
	{
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public static readonly RenderTargetHandle CameraTarget;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public int id
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x118FC0", Offset = "0x1183C0", VA = "0x180118FC0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x118FD0", Offset = "0x1183D0", VA = "0x180118FD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1CAFE0", Offset = "0x1CA3E0", VA = "0x1801CAFE0")]
		public void Init(string shaderProperty)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x1CAF60", Offset = "0x1CA360", VA = "0x1801CAF60")]
		public RenderTargetIdentifier Identifier()
		{
			return default(RenderTargetIdentifier);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x133EB0", Offset = "0x1332B0", VA = "0x180133EB0")]
		public bool Equals(RenderTargetHandle other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x1CAEE0", Offset = "0x1CA2E0", VA = "0x1801CAEE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x118FC0", Offset = "0x1183C0", VA = "0x180118FC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xCE9F20", Offset = "0xCE9320", VA = "0x180CE9F20")]
		public static bool operator ==(RenderTargetHandle c1, RenderTargetHandle c2)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xCE9F40", Offset = "0xCE9340", VA = "0x180CE9F40")]
		public static bool operator !=(RenderTargetHandle c1, RenderTargetHandle c2)
		{
			return default(bool);
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public enum SampleCount
	{
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		One = 1,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		Two = 2,
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		Four = 4
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class ScriptableRenderer
	{
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public static readonly RendererConfiguration RendererConfiguration;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static Mesh s_FullscreenMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private List<ScriptableRenderPass> m_ActiveRenderPassQueue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private List<ShaderPassName> m_LegacyShaderPassNames;

		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private const string k_ReleaseResourcesTag = "Release Resources";

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private readonly Material[] m_Materials;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int maxPerObjectAdditionalLights
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x24E1E60", Offset = "0x24E1260", VA = "0x1824E1E60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int maxVisibleAdditionalLights
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x24E1E60", Offset = "0x24E1260", VA = "0x1824E1E60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public PostProcessRenderContext postProcessingContext
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x3108E0", Offset = "0x30FCE0", VA = "0x1803108E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x3109D0", Offset = "0x30FDD0", VA = "0x1803109D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public RenderFeaturesetOption RendererFeatureset
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x50B950", Offset = "0x50AD50", VA = "0x18050B950")]
			[CompilerGenerated]
			get
			{
				return default(RenderFeaturesetOption);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x50B960", Offset = "0x50AD60", VA = "0x18050B960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public ComputeBuffer perObjectLightIndices
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x3220C0", Offset = "0x3214C0", VA = "0x1803220C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x344320", Offset = "0x343720", VA = "0x180344320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		private static Mesh fullscreenMesh
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x24E19E0", Offset = "0x24E0DE0", VA = "0x1824E19E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public Shader mobileFadeEffectShader
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x33EB40", Offset = "0x33DF40", VA = "0x18033EB40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x34FD50", Offset = "0x34F150", VA = "0x18034FD50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public Shader mobileVignetteEffectShader
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x374030", Offset = "0x373430", VA = "0x180374030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x374440", Offset = "0x373840", VA = "0x180374440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x24E1540", Offset = "0x24E0940", VA = "0x1824E1540")]
		public ScriptableRenderer(AgainstGravityRenderPipelineAsset pipelineAsset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x24E05A0", Offset = "0x24DF9A0", VA = "0x1824E05A0")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x24E06D0", Offset = "0x24DFAD0", VA = "0x1824E06D0")]
		public void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x24E0C90", Offset = "0x24E0090", VA = "0x1824E0C90")]
		public Material GetMaterial(MaterialHandle handle)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x24E0180", Offset = "0x24DF580", VA = "0x1824E0180")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x24E0670", Offset = "0x24DFA70", VA = "0x1824E0670")]
		public void EnqueuePass(ScriptableRenderPass pass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x24E1200", Offset = "0x24E0600", VA = "0x1824E1200")]
		public void RenderPostProcess(CommandBuffer cmd, ref CameraData cameraData, RenderTextureFormat colorFormat, RenderTargetIdentifier source, RenderTargetIdentifier dest, bool opaqueOnly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x24E0F20", Offset = "0x24E0320", VA = "0x1824E0F20")]
		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void RenderObjectsWithError(ScriptableRenderContext context, ref CullResults cullResults, Camera camera, FilterRenderersSettings filterSettings, SortFlags sortFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x24E02C0", Offset = "0x24DF6C0", VA = "0x1824E02C0")]
		public static RenderTextureDescriptor CreateRenderTextureDescriptor(ref CameraData cameraData, float scaler = 1f)
		{
			return default(RenderTextureDescriptor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x24E13E0", Offset = "0x24E07E0", VA = "0x1824E13E0")]
		public static bool RequiresIntermediateColorTexture(ref CameraData cameraData, RenderTextureDescriptor baseDescriptor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x24E0B90", Offset = "0x24DFF90", VA = "0x1824E0B90")]
		public static ClearFlag GetCameraClearFlag(Camera camera)
		{
			return default(ClearFlag);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x24E0DD0", Offset = "0x24E01D0", VA = "0x1824E0DD0")]
		public static void RenderFullscreenQuad(CommandBuffer cmd, Material material, [Optional] MaterialPropertyBlock properties, int shaderPassId = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x24E01D0", Offset = "0x24DF5D0", VA = "0x1824E01D0")]
		public static void CopyTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier dest, Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x24E0470", Offset = "0x24DF870", VA = "0x1824E0470")]
		private void DisposePasses(ref ScriptableRenderContext context)
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public enum ShaderPathID
	{
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		PhysicallyBased,
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		SimpleLit,
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		Unlit,
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		TerrainPhysicallyBased,
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		ParticlesPhysicallyBased,
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		ParticlesSimpleLit,
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		ParticlesUnlit,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		Count
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class ShaderUtils
	{
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly string[] s_ShaderPaths;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x24E1FE0", Offset = "0x24E13E0", VA = "0x1824E1FE0")]
		public static string GetShaderPath(ShaderPathID id)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 204)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct ShadowSliceData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public Matrix4x4 viewMatrix;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public Matrix4x4 projectionMatrix;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public Matrix4x4 shadowTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public int offsetX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public int offsetY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public int resolution;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x25C090", Offset = "0x25B490", VA = "0x18025C090")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public static class ShadowUtils
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x24E2650", Offset = "0x24E1A50", VA = "0x1824E2650")]
		public static bool ExtractDirectionalLightMatrix(ref CullResults cullResults, ref ShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowResolution, float shadowNearPlane, out Vector4 cascadeSplitDistance, out ShadowSliceData shadowSliceData, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x24E2A20", Offset = "0x24E1E20", VA = "0x1824E2A20")]
		public static bool ExtractSpotLightMatrix(ref CullResults cullResults, ref ShadowData shadowData, int shadowLightIndex, out Matrix4x4 shadowMatrix, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x24E3190", Offset = "0x24E2590", VA = "0x1824E3190")]
		public static void RenderShadowSlice(CommandBuffer cmd, ref ScriptableRenderContext context, ref ShadowSliceData shadowSliceData, ref DrawShadowsSettings settings, Matrix4x4 proj, Matrix4x4 view)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x24E2B50", Offset = "0x24E1F50", VA = "0x1824E2B50")]
		public static int GetMaxTileResolutionInAtlas(int atlasWidth, int atlasHeight, int tileCount)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x24E2460", Offset = "0x24E1860", VA = "0x1824E2460")]
		public static void ApplySliceTransform(ref ShadowSliceData shadowSliceData, int atlasWidth, int atlasHeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x24E2BF0", Offset = "0x24E1FF0", VA = "0x1824E2BF0")]
		public static Vector4 GetShadowBias(Light shadowLight, int shadowLightIndex, ref ShadowData shadowData, Matrix4x4 lightProjectionMatrix, float shadowResolution)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x24E3380", Offset = "0x24E2780", VA = "0x1824E3380")]
		public static void SetupShadowCasterConstantBuffer(CommandBuffer cmd, Light shadowLight, Vector4 shadowBias)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x24E3550", Offset = "0x24E2950", VA = "0x1824E3550")]
		[Obsolete]
		public static void SetupShadowCasterConstants(CommandBuffer cmd, ref VisibleLight visibleLight, Matrix4x4 proj, float cascadeResolution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x24E2F00", Offset = "0x24E2300", VA = "0x1824E2F00")]
		private static Matrix4x4 GetShadowTransform(Matrix4x4 proj, Matrix4x4 view)
		{
			return default(Matrix4x4);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class VisualizeFroxelBounds : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x24E3870", Offset = "0x24E2C70", VA = "0x1824E3870")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x311310", Offset = "0x310710", VA = "0x180311310")]
		public VisualizeFroxelBounds()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class VoxelMath
	{
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public const float VOXEL_VOLUME_WIDTH = 120f;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public const float VOXEL_VOLUME_HEIGHT = 60f;

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public const float VOXEL_VOLUME_DEPTH = 120f;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public const float WIDTH_COUNT_F = 24f;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public const float HEIGHT_COUNT_F = 12f;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public const float DEPTH_COUNT_F = 24f;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public const float WIDTH_COUNT_RECIP = 1f / 24f;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public const float HEIGHT_COUNT_RECIP = 1f / 12f;

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public const float DEPTH_COUNT_RECIP = 1f / 24f;

		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private const int MAX_WIDTH_IDX = 23;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private const int MAX_HEIGHT_IDX = 11;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private const int MAX_DEPTH_IDX = 23;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public static readonly float3 VOXEL_RESOLUTION_F;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public static readonly uint3 VOXEL_RESOLUTION;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private static readonly uint3 LAST_IDX;

		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static readonly float3 VOXEL_VOLUME_SIZE_F;

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly float3 VOXEL_VOLUME_HALF_SIZE_F;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x24E4140", Offset = "0x24E3540", VA = "0x1824E4140")]
		public static uint PackIdx(uint x, uint y, uint z)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x24E46D0", Offset = "0x24E3AD0", VA = "0x1824E46D0")]
		public static uint3 UnpackIdx(uint voxelIdx)
		{
			return default(uint3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x24E4980", Offset = "0x24E3D80", VA = "0x1824E4980")]
		public static float3 VoxelPackedIdxToCenterPosition(uint packedIdx, float3 worldVolumeMinCorner, float3 worldVolumeMaxCorner)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x24E4740", Offset = "0x24E3B40", VA = "0x1824E4740")]
		public static Vector3 VoxelPackedIdxToCenterPositionVector3(uint packedIdx, Vector3 worldVolumeMinCorner, Vector3 worldVolumeMaxCorner)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x24E42D0", Offset = "0x24E36D0", VA = "0x1824E42D0")]
		public static uint3 PositionToVoxelIdxUnpacked(float3 position, float3 worldVolumeMinCorner, float3 worldVolumeMaxCorner)
		{
			return default(uint3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x24E4150", Offset = "0x24E3550", VA = "0x1824E4150")]
		public static Vector3 PositionToVoxelIdxUnpackedVector3(Vector3 position, Vector3 worldVolumeMin, Vector3 worldVolumeMax)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x24E44A0", Offset = "0x24E38A0", VA = "0x1824E44A0")]
		public static void SphereOverlap(float3 worldVolumeMin, float3 worldVolumeMax, float3 spherePosition, float radius, out uint3 minVoxelIndex, out uint3 maxVoxelIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x24E3AC0", Offset = "0x24E2EC0", VA = "0x1824E3AC0")]
		public static void ConeBoundingSphere(float3 coneOrigin, float3 coneDir, float range, float coneAngle, out float3 center, out float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x24E3F90", Offset = "0x24E3390", VA = "0x1824E3F90")]
		private static float3 FastRayIntersection(float3 pnt1, float3 norm1, float3 pnt2, float3 norm2)
		{
			return default(float3);
		}
	}
}
namespace AGRP.RendererSetups
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal class RendererSetupFullyFeatured : IRendererSetup, ILightDataInterpreter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private LightBinningPass m_LightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private DepthOnlyPass m_DepthOnlyPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private MainLightShadowCasterPass m_MainLightShadowCasterPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private AdditionalLightsShadowCasterPass m_AdditionalLightsShadowCasterPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private SetupForwardRenderingPass m_SetupForwardRenderingPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private ScreenSpaceShadowResolvePass m_ScreenSpaceShadowResolvePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private CreateAgainstGravityRenderTexturesPass m_CreateAGRPRenderTexturesPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private BeginXRRenderingPass m_BeginXrRenderingPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private SetupAGRPConstantsPass m_SetupAGRPConstants;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private MobileVignetteEffectPass m_mobileVignetteEffectPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private RenderOpaqueForwardPass m_RenderOpaqueForwardPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private CustomRenderEffectsPass m_customRenderEffectsPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private OpaquePostProcessPass m_OpaquePostProcessPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private DrawSkyboxPass m_DrawSkyboxPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private CopyDepthPass m_CopyDepthPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private CopyColorPass m_CopyColorPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private RenderTransparentForwardPass m_RenderTransparentForwardPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private MobileFadeEffectPass m_mobileFadeEffectPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private TransparentPostProcessPass m_TransparentPostProcessPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private FinalBlitPass m_FinalBlitPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private EndXRRenderingPass m_EndXrRenderingPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private RenderTargetHandle ColorAttachment;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private RenderTargetHandle DepthAttachment;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private RenderTargetHandle DepthTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private RenderTargetHandle OpaqueColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private RenderTargetHandle MainLightShadowmap;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private RenderTargetHandle AdditionalLightsShadowmap;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private RenderTargetHandle ScreenSpaceShadowmap;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private bool SupportsDepthTarget;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xD5")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private bool m_Initialized;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public ILightDataInterpreter LightInterpreter
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x413D00", Offset = "0x413100", VA = "0x180413D00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x12F6630", Offset = "0x12F5A30", VA = "0x1812F6630")]
		private void Init()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x12F6CF0", Offset = "0x12F60F0", VA = "0x1812F6CF0", Slot = "4")]
		public void PreCullSetup(ScriptableRenderer renderer, ScriptableRenderContext context, Camera camera, CameraData cameraData, ref LightData lightData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x12F6D00", Offset = "0x12F6100", VA = "0x1812F6D00", Slot = "5")]
		public void Setup(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x12F5C80", Offset = "0x12F5080", VA = "0x1812F5C80")]
		private bool CanCopyDepth(ref CameraData cameraData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x12F6560", Offset = "0x12F5960", VA = "0x1812F6560", Slot = "7")]
		public Light GetLight(ref LightData lightData, int lightIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x12F6210", Offset = "0x12F5610", VA = "0x1812F6210", Slot = "8")]
		public AGRPLight GetAGRPLight(ref LightData lightData, int lightIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x12F6340", Offset = "0x12F5740", VA = "0x1812F6340", Slot = "9")]
		public int GetLightCount(ref LightData lightData)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x12F6390", Offset = "0x12F5790", VA = "0x1812F6390", Slot = "10")]
		public bool GetLightInfo(ref LightData lightData, int lightIdx, out Vector4 pos, out Vector4 dir, out Color finalColor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x12F5CC0", Offset = "0x12F50C0", VA = "0x1812F5CC0", Slot = "11")]
		public int CopyToBinnableLights(ref LightData lightData, BinnableLight[] binnableLightBuffer, int maxLightCount)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3107E0", Offset = "0x30FBE0", VA = "0x1803107E0")]
		public RendererSetupFullyFeatured()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class RendererSetupMobile : IRendererSetup, ILightDataInterpreter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private LightBinningPass lightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private SetupForwardRenderingPass setupForwardRenderingPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private CachedMainLightShadowCasterPass mainLightShadowCasterPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private CreateAgainstGravityRenderTexturesPass createAGRPRenderTexturesPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private BeginXRRenderingPass beginXrRenderingPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private SetupAGRPConstantsPass setupAGRPConstants;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private MobileVignetteEffectPass mobileVignetteEffectPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private RenderOpaqueForwardPass renderOpaqueForwardPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private CustomRenderEffectsPass customRenderEffectsPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private DrawSkyboxPass drawSkyboxPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private RenderTransparentForwardPass renderTransparentForwardPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private MobileFadeEffectPass mobileFadeEffectPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private EndXRRenderingPass endXrRenderingPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private RenderTargetHandle mainLightShadowmap;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private bool initialized;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public ILightDataInterpreter LightInterpreter
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x413D00", Offset = "0x413100", VA = "0x180413D00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x12F7CD0", Offset = "0x12F70D0", VA = "0x1812F7CD0")]
		private void Init()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x12F8050", Offset = "0x12F7450", VA = "0x1812F8050", Slot = "4")]
		public void PreCullSetup(ScriptableRenderer renderer, ScriptableRenderContext context, Camera camera, CameraData cameraData, ref LightData lightData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x12F8260", Offset = "0x12F7660", VA = "0x1812F8260", Slot = "5")]
		public void Setup(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x12F7BF0", Offset = "0x12F6FF0", VA = "0x1812F7BF0", Slot = "7")]
		public Light GetLight(ref LightData lightData, int lightIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x12F7900", Offset = "0x12F6D00", VA = "0x1812F7900", Slot = "8")]
		public AGRPLight GetAGRPLight(ref LightData lightData, int lightIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x12F7A10", Offset = "0x12F6E10", VA = "0x1812F7A10", Slot = "9")]
		public int GetLightCount(ref LightData lightData)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x12F7A60", Offset = "0x12F6E60", VA = "0x1812F7A60", Slot = "10")]
		public bool GetLightInfo(ref LightData lightData, int lightIdx, out Vector4 pos, out Vector4 dir, out Color finalColor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x12F7840", Offset = "0x12F6C40", VA = "0x1812F7840", Slot = "11")]
		public int CopyToBinnableLights(ref LightData lightData, BinnableLight[] binnableLightBuffer, int maxLightCount)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3107E0", Offset = "0x30FBE0", VA = "0x1803107E0")]
		public RendererSetupMobile()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal sealed class RendererSetupSimpleUIView : IRendererSetup
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private SetupForwardRenderingPass setupForwardRenderingPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private RenderOpaqueForwardPass renderOpaqueForwardPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private RenderTransparentForwardPass renderTransparentForwardPass;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool initialized;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public ILightDataInterpreter LightInterpreter
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x38E920", Offset = "0x38DD20", VA = "0x18038E920", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x24DFC60", Offset = "0x24DF060", VA = "0x1824DFC60")]
		private void Init()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x24DFC60", Offset = "0x24DF060", VA = "0x1824DFC60", Slot = "4")]
		public void PreCullSetup(ScriptableRenderer renderer, ScriptableRenderContext context, Camera camera, CameraData cameraData, ref LightData lightData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x24DFD00", Offset = "0x24DF100", VA = "0x1824DFD00", Slot = "5")]
		public void Setup(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3107E0", Offset = "0x30FBE0", VA = "0x1803107E0")]
		public RendererSetupSimpleUIView()
		{
		}
	}
}
namespace AGRP.Passes
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class AdditionalLightsShadowCasterPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private static class AdditionalShadowsConstantBuffer
		{
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			public static int _AdditionalLightsWorldToShadow;

			[Cpp2IlInjected.Token(Token = "0x4000211")]
			public static int _AdditionalShadowStrength;

			[Cpp2IlInjected.Token(Token = "0x4000212")]
			public static int _AdditionalShadowBias;

			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public static int _AdditionalShadowOffset0;

			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public static int _AdditionalShadowOffset1;

			[Cpp2IlInjected.Token(Token = "0x4000215")]
			public static int _AdditionalShadowOffset2;

			[Cpp2IlInjected.Token(Token = "0x4000216")]
			public static int _AdditionalShadowOffset3;

			[Cpp2IlInjected.Token(Token = "0x4000217")]
			public static int _AdditionalShadowmapSize;
		}

		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private const int k_ShadowmapBufferBits = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private RenderTexture m_AdditionalLightsShadowmapTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private RenderTextureFormat m_AdditionalShadowmapFormat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private Matrix4x4[] m_AdditionalLightShadowMatrices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private ShadowSliceData[] m_AdditionalLightSlices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private float[] m_AdditionalLightsShadowStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private float[] m_AdditionalLightsShadowSampleBias;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private List<int> m_AdditionalShadowCastingLightIndices;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private const string k_RenderAdditionalLightShadows = "Render Additional Shadows";

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		private RenderTargetHandle destination
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x4AF070", Offset = "0x4AE470", VA = "0x1804AF070")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x6AB6C0", Offset = "0x6AAAC0", VA = "0x1806AB6C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x12E67E0", Offset = "0x12E5BE0", VA = "0x1812E67E0")]
		public AdditionalLightsShadowCasterPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x12E61A0", Offset = "0x12E55A0", VA = "0x1812E61A0")]
		public bool Setup(RenderTargetHandle destination, ref RenderingData renderingData, int maxVisibleAdditionalLights)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x12E5410", Offset = "0x12E4810", VA = "0x1812E5410", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x12E54D0", Offset = "0x12E48D0", VA = "0x1812E54D0", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x12E5210", Offset = "0x12E4610", VA = "0x1812E5210")]
		private void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x12E5590", Offset = "0x12E4990", VA = "0x1812E5590")]
		private void RenderAdditionalShadowmapAtlas(ref ScriptableRenderContext context, ref CullResults cullResults, ref LightData lightData, ref ShadowData shadowData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x12E5D00", Offset = "0x12E5100", VA = "0x1812E5D00")]
		private void SetupAdditionalLightsShadowReceiverConstants(CommandBuffer cmd, ref ShadowData shadowData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class BeginXRRenderingPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public static event Action StaticBeginXRRenderingEvent
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x12EA930", Offset = "0x12E9D30", VA = "0x1812EA930")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x12EAA20", Offset = "0x12E9E20", VA = "0x1812EAA20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x12EA850", Offset = "0x12E9C50", VA = "0x1812EA850", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x12EA920", Offset = "0x12E9D20", VA = "0x1812EA920")]
		public BeginXRRenderingPass()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class CachedMainLightShadowCasterPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		private static class CachedMainLightShadowConstantBuffer
		{
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			public static int _WorldToShadow;

			[Cpp2IlInjected.Token(Token = "0x4000219")]
			public static int _ShadowData;

			[Cpp2IlInjected.Token(Token = "0x400021A")]
			public static int _ShadowmapSize;
		}

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private static bool isDirty;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private static int shadowCasterLayerMask;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private const string PASS_TAG_NAME = "Render Cached Main Shadowmap";

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private const int SHADOW_MAP_BUFFER_BITS = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private RenderTexture shadowmapTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private RenderTextureFormat shadowmapFormat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private Matrix4x4[] shadowMatrices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private ShadowSliceData singleCascadeSlice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private Vector4 singleCascadeDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private Vector3 lastRenderCameraPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private bool isReusingCachedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private CullResults cullResults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private int mainLightIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private Light mainLight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private Vector4 shadowBias;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		private RenderTargetHandle destination
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x9587C0", Offset = "0x957BC0", VA = "0x1809587C0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x958A00", Offset = "0x957E00", VA = "0x180958A00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x12EC930", Offset = "0x12EBD30", VA = "0x1812EC930")]
		public static void SetDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x12EC990", Offset = "0x12EBD90", VA = "0x1812EC990")]
		public static void SetShadowCasterLayerMask(int layerMask)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x12ED140", Offset = "0x12EC540", VA = "0x1812ED140")]
		public CachedMainLightShadowCasterPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x12EBD60", Offset = "0x12EB160", VA = "0x1812EBD60")]
		public void PreCullSetup(ref ScriptableRenderContext context, ref CameraData cameraData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x12ECD50", Offset = "0x12EC150", VA = "0x1812ECD50")]
		public bool Setup(RenderTargetHandle destination, ref RenderingData renderingData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x12EBBD0", Offset = "0x12EAFD0", VA = "0x1812EBBD0", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x12EBC70", Offset = "0x12EB070", VA = "0x1812EBC70", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x12EBAB0", Offset = "0x12EAEB0", VA = "0x1812EBAB0")]
		private void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x12EBCE0", Offset = "0x12EB0E0", VA = "0x1812EBCE0")]
		private Vector4 GetShadowBias(Vector4 biasSettings, Matrix4x4 lightProjectionMatrix, int shadowResolution)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x12EC450", Offset = "0x12EB850", VA = "0x1812EC450")]
		private void RenderMainLightCascadeShadowmap(ref ScriptableRenderContext context, ref ShadowData shadowData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x12EC9F0", Offset = "0x12EBDF0", VA = "0x1812EC9F0")]
		private void SetupMainLightShadowReceiverConstants(CommandBuffer cmd, ref ShadowData shadowData, Light shadowLight, float sampleBias)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class CopyColorPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private const string k_CopyColorTag = "Copy Color";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private float[] m_OpaqueScalerValues;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private int m_SampleOffsetShaderHandle;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		private RenderTargetHandle source
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x49A670", Offset = "0x499A70", VA = "0x18049A670")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x4CB270", Offset = "0x4CA670", VA = "0x1804CB270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		private RenderTargetHandle destination
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x3C3D00", Offset = "0x3C3100", VA = "0x1803C3D00")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x6AB090", Offset = "0x6AA490", VA = "0x1806AB090")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x12ED890", Offset = "0x12ECC90", VA = "0x1812ED890")]
		public CopyColorPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x12ED880", Offset = "0x12ECC80", VA = "0x1812ED880")]
		public void Setup(RenderTargetHandle source, RenderTargetHandle destination)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x12ED340", Offset = "0x12EC740", VA = "0x1812ED340", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x12ED780", Offset = "0x12ECB80", VA = "0x1812ED780", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class CopyDepthPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private const string k_DepthCopyTag = "Copy Depth";

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		private RenderTargetHandle source
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x47EFD0", Offset = "0x47E3D0", VA = "0x18047EFD0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x594EA0", Offset = "0x5942A0", VA = "0x180594EA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		private RenderTargetHandle destination
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x34F5A0", Offset = "0x34E9A0", VA = "0x18034F5A0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x67B2C0", Offset = "0x67A6C0", VA = "0x18067B2C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x12EDFF0", Offset = "0x12ED3F0", VA = "0x1812EDFF0")]
		public void Setup(RenderTargetHandle source, RenderTargetHandle destination)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x12ED910", Offset = "0x12ECD10", VA = "0x1812ED910", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x12EDEF0", Offset = "0x12ED2F0", VA = "0x1812EDEF0", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x12EA920", Offset = "0x12E9D20", VA = "0x1812EA920")]
		public CopyDepthPass()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class CreateAgainstGravityRenderTexturesPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private const string k_CreateRenderTexturesTag = "Create Render Textures";

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private const int k_DepthStencilBufferBits = 32;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		private RenderTargetHandle colorAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x47EFD0", Offset = "0x47E3D0", VA = "0x18047EFD0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x594EA0", Offset = "0x5942A0", VA = "0x180594EA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		private RenderTargetHandle depthAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x34F5A0", Offset = "0x34E9A0", VA = "0x18034F5A0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x67B2C0", Offset = "0x67A6C0", VA = "0x18067B2C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x12EE4A0", Offset = "0x12ED8A0", VA = "0x1812EE4A0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x12EE4D0", Offset = "0x12ED8D0", VA = "0x1812EE4D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		private SampleCount samples
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x52F100", Offset = "0x52E500", VA = "0x18052F100")]
			[CompilerGenerated]
			get
			{
				return default(SampleCount);
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x6AB6E0", Offset = "0x6AAAE0", VA = "0x1806AB6E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x12EE470", Offset = "0x12ED870", VA = "0x1812EE470")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorAttachmentHandle, RenderTargetHandle depthAttachmentHandle, SampleCount samples)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x12EE000", Offset = "0x12ED400", VA = "0x1812EE000", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x12EE300", Offset = "0x12ED700", VA = "0x1812EE300", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x12EA920", Offset = "0x12E9D20", VA = "0x1812EA920")]
		public CreateAgainstGravityRenderTexturesPass()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public abstract class CustomRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public abstract string BufferName
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual bool RequiresOpaqueTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x319A60", Offset = "0x318E60", VA = "0x180319A60", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x311320", Offset = "0x310720", VA = "0x180311320", Slot = "5")]
		public virtual void RenderPass(CommandBuffer commandBuffer, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x311310", Offset = "0x310710", VA = "0x180311310")]
		protected CustomRenderEffect()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class CustomRenderEffectsPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private static readonly List<CustomRenderEffect> executeOnNextRenderEffects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly List<CustomRenderEffect> renderEffectsBuffer;

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		private RenderTargetHandle colorAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x34F650", Offset = "0x34EA50", VA = "0x18034F650")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x4A40E0", Offset = "0x4A34E0", VA = "0x1804A40E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private RenderTargetHandle depthAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x49A670", Offset = "0x499A70", VA = "0x18049A670")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x4CB270", Offset = "0x4CA670", VA = "0x1804CB270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x12EEF40", Offset = "0x12EE340", VA = "0x1812EEF40")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x12EEF70", Offset = "0x12EE370", VA = "0x1812EEF70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool RequiresOpaqueTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x12EEDD0", Offset = "0x12EE1D0", VA = "0x1812EEDD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x12EE4F0", Offset = "0x12ED8F0", VA = "0x1812EE4F0")]
		public static void EnqueueEffectForNextRender(CustomRenderEffect effect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x12EEBD0", Offset = "0x12EDFD0", VA = "0x1812EEBD0")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorHandle, RenderTargetHandle depthHandle, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x12EE850", Offset = "0x12EDC50", VA = "0x1812EE850", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x12EE570", Offset = "0x12ED970", VA = "0x1812EE570")]
		private void ExecuteEffect(CustomRenderEffect renderEffect, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x12EED70", Offset = "0x12EE170", VA = "0x1812EED70")]
		public CustomRenderEffectsPass()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class DepthOnlyPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private const string k_DepthPrepassTag = "Depth Prepass";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private int kDepthBufferBits;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private RenderTargetHandle depthAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x34F5A0", Offset = "0x34E9A0", VA = "0x18034F5A0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x67B2C0", Offset = "0x67A6C0", VA = "0x18067B2C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		internal RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x12EE4A0", Offset = "0x12ED8A0", VA = "0x1812EE4A0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x12EE4D0", Offset = "0x12ED8D0", VA = "0x1812EE4D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		private FilterRenderersSettings opaqueFilterSettings
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x12EFDF0", Offset = "0x12EF1F0", VA = "0x1812EFDF0")]
			[CompilerGenerated]
			get
			{
				return default(FilterRenderersSettings);
			}
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x12EFE10", Offset = "0x12EF210", VA = "0x1812EFE10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x12EFD50", Offset = "0x12EF150", VA = "0x1812EFD50")]
		public DepthOnlyPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x12EFCC0", Offset = "0x12EF0C0", VA = "0x1812EFCC0")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle depthAttachmentHandle, SampleCount samples)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x12EF6E0", Offset = "0x12EEAE0", VA = "0x1812EF6E0", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x12EFBC0", Offset = "0x12EEFC0", VA = "0x1812EFBC0", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class DrawSkyboxPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		private RenderTargetHandle colorAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x47EFD0", Offset = "0x47E3D0", VA = "0x18047EFD0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x594EA0", Offset = "0x5942A0", VA = "0x180594EA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		private RenderTargetHandle depthAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x34F5A0", Offset = "0x34E9A0", VA = "0x18034F5A0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x67B2C0", Offset = "0x67A6C0", VA = "0x18067B2C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x12EDFF0", Offset = "0x12ED3F0", VA = "0x1812EDFF0")]
		public void Setup(RenderTargetHandle colorHandle, RenderTargetHandle depthHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x12EFE20", Offset = "0x12EF220", VA = "0x1812EFE20", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x12EA920", Offset = "0x12E9D20", VA = "0x1812EA920")]
		public DrawSkyboxPass()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class EndXRRenderingPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x12F01B0", Offset = "0x12EF5B0", VA = "0x1812F01B0", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x12EA920", Offset = "0x12E9D20", VA = "0x1812EA920")]
		public EndXRRenderingPass()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class FinalBlitPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private const string k_FinalBlitTag = "Final Blit Pass";

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		private RenderTargetHandle colorAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x47EFD0", Offset = "0x47E3D0", VA = "0x18047EFD0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x594EA0", Offset = "0x5942A0", VA = "0x180594EA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x12F06F0", Offset = "0x12EFAF0", VA = "0x1812F06F0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x12F0720", Offset = "0x12EFB20", VA = "0x1812F0720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x12F06C0", Offset = "0x12EFAC0", VA = "0x1812F06C0")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorAttachmentHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x12F0250", Offset = "0x12EF650", VA = "0x1812F0250", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x12EA920", Offset = "0x12E9D20", VA = "0x1812EA920")]
		public FinalBlitPass()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class LightBinningPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private static class ShaderKeywords
		{
			[Cpp2IlInjected.Token(Token = "0x400021B")]
			public static readonly int VoxelBuffer;

			[Cpp2IlInjected.Token(Token = "0x400021C")]
			public static readonly int VoxelVolumeWorldOriginPreMultiplied;

			[Cpp2IlInjected.Token(Token = "0x400021D")]
			public static readonly int WorldSpaceToVoxelCoefficients;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private ComputeBuffer _VoxelBufferGPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private CalculateVoxelPoints _calculateVoxelPointsJob;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private BinPerLightJob _binPerLightJob;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private BinPerVoxelJob _binPerVoxelJob;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private NativeMultiHashMap<ushort, LightInBin> _lightBinBuffer0;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private NativeMultiHashMap<ushort, LightInBin> _lightBinBuffer1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private bool _frontBackSwitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private float3 voxelVolumeMinCorner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private float3 voxelVolumeMaxCorner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private NativeArray<uint> _voxelBufferCPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private NativeArray<float> _lightImportancesPerVoxel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private NativeArray<float3> _voxelPoints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private NativeArray<BinnableLight> _binnableLights;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private BinnableLight[] _binnableLightsBuffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private JobHandle _jobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private JobHandle _backBufferClearHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private ClearBufferJob<ushort, LightInBin> _clearBackBufferJob;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private bool _isCompleted;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		private NativeMultiHashMap<ushort, LightInBin> FrontBuffer
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x12F1700", Offset = "0x12F0B00", VA = "0x1812F1700")]
			get
			{
				return default(NativeMultiHashMap<ushort, LightInBin>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		private NativeMultiHashMap<ushort, LightInBin> BackBuffer
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x12F16D0", Offset = "0x12F0AD0", VA = "0x1812F16D0")]
			get
			{
				return default(NativeMultiHashMap<ushort, LightInBin>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x12F0CA0", Offset = "0x12F00A0", VA = "0x1812F0CA0")]
		private void SetupPersistentBuffers(RenderFeaturesetOption featureset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x12F0C00", Offset = "0x12F0000", VA = "0x1812F0C00")]
		private static void RunAtQuit(Action quitFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xEB4350", Offset = "0xEB3750", VA = "0x180EB4350")]
		private void ResizePersistentArray<T>(ref NativeArray<T> array, int size) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x12F0DF0", Offset = "0x12F01F0", VA = "0x1812F0DF0")]
		public JobHandle StartLightBin(CameraData cameraData, RenderFeaturesetOption featureset, ref LightData lightData)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x12F07C0", Offset = "0x12EFBC0", VA = "0x1812F07C0")]
		private void CompleteFrameJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x12F0740", Offset = "0x12EFB40", VA = "0x1812F0740")]
		private void CleanupFrameData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x12F07F0", Offset = "0x12EFBF0", VA = "0x1812F07F0", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x12EA920", Offset = "0x12E9D20", VA = "0x1812EA920")]
		public LightBinningPass()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class MainLightShadowCasterPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x2000059")]
		private static class MainLightShadowConstantBuffer
		{
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			public static int _WorldToShadow;

			[Cpp2IlInjected.Token(Token = "0x4000221")]
			public static int _ShadowData;

			[Cpp2IlInjected.Token(Token = "0x4000222")]
			public static int _CascadeShadowSplitSpheres0;

			[Cpp2IlInjected.Token(Token = "0x4000223")]
			public static int _CascadeShadowSplitSpheres1;

			[Cpp2IlInjected.Token(Token = "0x4000224")]
			public static int _CascadeShadowSplitSpheres2;

			[Cpp2IlInjected.Token(Token = "0x4000225")]
			public static int _CascadeShadowSplitSpheres3;

			[Cpp2IlInjected.Token(Token = "0x4000226")]
			public static int _CascadeShadowSplitSphereRadii;

			[Cpp2IlInjected.Token(Token = "0x4000227")]
			public static int _ShadowOffset0;

			[Cpp2IlInjected.Token(Token = "0x4000228")]
			public static int _ShadowOffset1;

			[Cpp2IlInjected.Token(Token = "0x4000229")]
			public static int _ShadowOffset2;

			[Cpp2IlInjected.Token(Token = "0x400022A")]
			public static int _ShadowOffset3;

			[Cpp2IlInjected.Token(Token = "0x400022B")]
			public static int _ShadowmapSize;
		}

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private const int k_MaxCascades = 4;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private const int k_ShadowmapBufferBits = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private int m_ShadowCasterCascadesCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private RenderTexture m_MainLightShadowmapTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private RenderTextureFormat m_ShadowmapFormat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private Matrix4x4[] m_MainLightShadowMatrices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private ShadowSliceData[] m_CascadeSlices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private Vector4[] m_CascadeSplitDistances;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private const string k_RenderMainLightShadowmapTag = "Render Main Shadowmap";

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		private RenderTargetHandle destination
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x34D720", Offset = "0x34CB20", VA = "0x18034D720")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x34D750", Offset = "0x34CB50", VA = "0x18034D750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x12F2C00", Offset = "0x12F2000", VA = "0x1812F2C00")]
		public MainLightShadowCasterPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x12F2960", Offset = "0x12F1D60", VA = "0x1812F2960")]
		public bool Setup(RenderTargetHandle destination, ref RenderingData renderingData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x12F1950", Offset = "0x12F0D50", VA = "0x1812F1950", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x12F1A00", Offset = "0x12F0E00", VA = "0x1812F1A00", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x12F1730", Offset = "0x12F0B30", VA = "0x1812F1730")]
		private void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x12F1AC0", Offset = "0x12F0EC0", VA = "0x1812F1AC0")]
		private void RenderMainLightCascadeShadowmap(ref ScriptableRenderContext context, ref CullResults cullResults, ref LightData lightData, ref ShadowData shadowData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x12F21A0", Offset = "0x12F15A0", VA = "0x1812F21A0")]
		private void SetupMainLightShadowReceiverConstants(CommandBuffer cmd, ref ShadowData shadowData, Light shadowLight, float sampleBias)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public abstract class MobileComfortEffectPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		protected const float QUAD_SCALE_FUDGE_FACTOR = 1.1f;

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		protected const float QUAD_LEFT_X_OUTER = -0.5f;

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		protected const float QUAD_RIGHT_X_OUTER = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		protected const float QUAD_BOTTOM_Y_OUTER = -0.5f;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		protected const float QUAD_TOP_Y_OUTER = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		protected const float QUAD_LEFT_U_OUTER = 0f;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		protected const float QUAD_RIGHT_U_OUTER = 1f;

		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		protected const float QUAD_BOTTOM_V_OUTER = 0f;

		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		protected const float QUAD_TOP_V_OUTER = 1f;

		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private static Mesh _worldSpaceQuadMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private Material _effectMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		protected Shader effectShader;

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public static bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x12F37D0", Offset = "0x12F2BD0", VA = "0x1812F37D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected static Mesh WorldSpaceQuadMesh
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x12F3860", Offset = "0x12F2C60", VA = "0x1812F3860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected Material EffectMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x12F3690", Offset = "0x12F2A90", VA = "0x1812F3690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x12F33C0", Offset = "0x12F27C0", VA = "0x1812F33C0")]
		protected static Matrix4x4 GetWorldSpaceQuadTRSMatrix(Camera camera, bool scaleUniformly = false)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x12F2E20", Offset = "0x12F2220", VA = "0x1812F2E20")]
		private static Mesh CreateWorldSpaceQuadMesh()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x12EA920", Offset = "0x12E9D20", VA = "0x1812EA920")]
		protected MobileComfortEffectPass()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public sealed class MobileFadeEffectPass : MobileComfortEffectPass
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public struct Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022C")]
			public float fadeEffect;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400022D")]
			public float monochromeReplacementEffect;
		}

		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private static readonly int FADE_ID;

		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public static Settings CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private const string k_PostProcessingTag = "Render Mobile Fade Effect";

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x12F3D90", Offset = "0x12F3190", VA = "0x1812F3D90")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x12F3C50", Offset = "0x12F3050", VA = "0x1812F3C50")]
		public bool Setup(Shader effectShader)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x12F3950", Offset = "0x12F2D50", VA = "0x1812F3950", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x12F3D30", Offset = "0x12F3130", VA = "0x1812F3D30")]
		public MobileFadeEffectPass()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class MobileVignetteEffectPass : MobileComfortEffectPass
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public struct Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022E")]
			public float vignettePowerNormalized;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400022F")]
			public Color vignetteColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000230")]
			public Mesh vignetteMesh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000231")]
			public AnimationCurve vignetteIntensityCurve;
		}

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private static readonly int POWER_ID;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private static readonly int COLOR_ID;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public static Settings CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private const string k_PostProcessingTag = "Render Mobile Vignette Effect";

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		private RenderTargetHandle colorAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x3C3D00", Offset = "0x3C3100", VA = "0x1803C3D00")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x6AB090", Offset = "0x6AA490", VA = "0x1806AB090")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		private RenderTargetHandle depthAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x485740", Offset = "0x484B40", VA = "0x180485740")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xA8A250", Offset = "0xA89650", VA = "0x180A8A250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x12F4500", Offset = "0x12F3900", VA = "0x1812F4500")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x12F4540", Offset = "0x12F3940", VA = "0x1812F4540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		private ClearFlag clearFlag
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x468DB0", Offset = "0x4681B0", VA = "0x180468DB0")]
			[CompilerGenerated]
			get
			{
				return default(ClearFlag);
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xF59DD0", Offset = "0xF591D0", VA = "0x180F59DD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		private Color clearColor
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x12F44F0", Offset = "0x12F38F0", VA = "0x1812F44F0")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x12F4530", Offset = "0x12F3930", VA = "0x1812F4530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x12F4280", Offset = "0x12F3680", VA = "0x1812F4280")]
		public bool Setup(Shader effectShader, RenderTextureDescriptor descriptor, RenderTargetHandle colorAttachmentHandle, RenderTargetHandle depthAttachmentHandle, ClearFlag clearFlag, Color clearColor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x12F3E40", Offset = "0x12F3240", VA = "0x1812F3E40", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x12F4490", Offset = "0x12F3890", VA = "0x1812F4490")]
		public MobileVignetteEffectPass()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class OpaquePostProcessPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private const string k_OpaquePostProcessTag = "Render Opaque PostProcess Effects";

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		private RenderTargetHandle colorAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x47EFD0", Offset = "0x47E3D0", VA = "0x18047EFD0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x594EA0", Offset = "0x5942A0", VA = "0x180594EA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x12F06F0", Offset = "0x12EFAF0", VA = "0x1812F06F0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x12F0720", Offset = "0x12EFB20", VA = "0x1812F0720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x12F06C0", Offset = "0x12EFAC0", VA = "0x1812F06C0")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorAttachmentHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x12F4560", Offset = "0x12F3960", VA = "0x1812F4560", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x12EA920", Offset = "0x12E9D20", VA = "0x1812EA920")]
		public OpaquePostProcessPass()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class RenderOpaqueForwardPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private const string k_RenderOpaquesTag = "Render Opaques";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private FilterRenderersSettings m_OpaqueFilterSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private RendererConfiguration rendererConfiguration;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		private RenderTargetHandle colorAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x485740", Offset = "0x484B40", VA = "0x180485740")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xA8A250", Offset = "0xA89650", VA = "0x180A8A250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		private RenderTargetHandle depthAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x401DD0", Offset = "0x4011D0", VA = "0x180401DD0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x6211B0", Offset = "0x6205B0", VA = "0x1806211B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x12F5600", Offset = "0x12F4A00", VA = "0x1812F5600")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x12F5640", Offset = "0x12F4A40", VA = "0x1812F5640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		private ClearFlag clearFlag
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x4723D0", Offset = "0x4717D0", VA = "0x1804723D0")]
			[CompilerGenerated]
			get
			{
				return default(ClearFlag);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x72C9A0", Offset = "0x72BDA0", VA = "0x18072C9A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		private Color clearColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x12F55F0", Offset = "0x12F49F0", VA = "0x1812F55F0")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x12F5630", Offset = "0x12F4A30", VA = "0x1812F5630")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x12F5550", Offset = "0x12F4950", VA = "0x1812F5550")]
		public RenderOpaqueForwardPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x12F5480", Offset = "0x12F4880", VA = "0x1812F5480")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorAttachmentHandle, RenderTargetHandle depthAttachmentHandle, ClearFlag clearFlag, Color clearColor, RendererConfiguration configuration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x12F4F60", Offset = "0x12F4360", VA = "0x1812F4F60", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class RenderTransparentForwardPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private const string k_RenderTransparentsTag = "Render Transparents";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private FilterRenderersSettings m_TransparentFilterSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private RendererConfiguration rendererConfiguration;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		private RenderTargetHandle colorAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x485740", Offset = "0x484B40", VA = "0x180485740")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xA8A250", Offset = "0xA89650", VA = "0x180A8A250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		private RenderTargetHandle depthAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x401DD0", Offset = "0x4011D0", VA = "0x180401DD0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x6211B0", Offset = "0x6205B0", VA = "0x1806211B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x12F5600", Offset = "0x12F4A00", VA = "0x1812F5600")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x12F5640", Offset = "0x12F4A40", VA = "0x1812F5640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x12F5BD0", Offset = "0x12F4FD0", VA = "0x1812F5BD0")]
		public RenderTransparentForwardPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x12F5BA0", Offset = "0x12F4FA0", VA = "0x1812F5BA0")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorAttachmentHandle, RenderTargetHandle depthAttachmentHandle, RendererConfiguration configuration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x12F56A0", Offset = "0x12F4AA0", VA = "0x1812F56A0", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class SceneViewDepthCopyPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private const string k_CopyDepthToCameraTag = "Copy Depth to Camera";

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		private RenderTargetHandle source
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x47EFD0", Offset = "0x47E3D0", VA = "0x18047EFD0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x594EA0", Offset = "0x5942A0", VA = "0x180594EA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x594EA0", Offset = "0x5942A0", VA = "0x180594EA0")]
		public void Setup(RenderTargetHandle source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x12F8830", Offset = "0x12F7C30", VA = "0x1812F8830", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x12EA920", Offset = "0x12E9D20", VA = "0x1812EA920")]
		public SceneViewDepthCopyPass()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class ScreenSpaceShadowResolvePass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private const string k_CollectShadowsTag = "Collect Shadows";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private RenderTextureFormat m_ColorFormat;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		private RenderTargetHandle colorAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x34F5A0", Offset = "0x34E9A0", VA = "0x18034F5A0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x67B2C0", Offset = "0x67A6C0", VA = "0x18067B2C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x12EE4A0", Offset = "0x12ED8A0", VA = "0x1812EE4A0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x12EE4D0", Offset = "0x12ED8D0", VA = "0x1812EE4D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x12F9000", Offset = "0x12F8400", VA = "0x1812F9000")]
		public ScreenSpaceShadowResolvePass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x12F8FA0", Offset = "0x12F83A0", VA = "0x1812F8FA0")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorAttachmentHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x12F8B80", Offset = "0x12F7F80", VA = "0x1812F8B80", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x12F8EA0", Offset = "0x12F82A0", VA = "0x1812F8EA0", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public abstract class ScriptableRenderPass
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private List<ShaderPassName> m_ShaderPassNames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public readonly string PassName;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x12F95E0", Offset = "0x12F89E0", VA = "0x1812F95E0")]
		public ScriptableRenderPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x311320", Offset = "0x310720", VA = "0x180311320", Slot = "4")]
		public virtual void FrameCleanup(CommandBuffer cmd)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData);

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x12F9210", Offset = "0x12F8610", VA = "0x1812F9210")]
		protected void RegisterShaderPassName(string passName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x12F9040", Offset = "0x12F8440", VA = "0x1812F9040")]
		protected DrawRendererSettings CreateDrawRendererSettings(Camera camera, SortFlags sortFlags, RendererConfiguration rendererConfiguration, bool supportsDynamicBatching)
		{
			return default(DrawRendererSettings);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x12F9290", Offset = "0x12F8690", VA = "0x1812F9290")]
		protected static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorAttachment, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, ClearFlag clearFlags, Color clearColor, TextureDimension dimension)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x12F93F0", Offset = "0x12F87F0", VA = "0x1812F93F0")]
		protected static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorAttachment, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthAttachment, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag, Color clearColor, TextureDimension dimension)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class SetupAGRPConstantsPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x200005C")]
		private static class ShaderKeywords
		{
			[Cpp2IlInjected.Token(Token = "0x4000232")]
			public static readonly int MainLightPosition;

			[Cpp2IlInjected.Token(Token = "0x4000233")]
			public static readonly int MainLightColor;

			[Cpp2IlInjected.Token(Token = "0x4000234")]
			public static readonly int AdditionalLightsCount;

			[Cpp2IlInjected.Token(Token = "0x4000235")]
			public static readonly int AdditionalLightsPosition;

			[Cpp2IlInjected.Token(Token = "0x4000236")]
			public static readonly int AdditionalLightsColor;

			[Cpp2IlInjected.Token(Token = "0x4000237")]
			public static readonly int AdditionalLightsAttenuation;

			[Cpp2IlInjected.Token(Token = "0x4000238")]
			public static readonly int AdditionalLightsSpotDir;
		}

		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private const string k_SetupLightConstants = "Setup Light Constants";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private MixedLightingSetup m_MixedLightingSetup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private Vector4 k_DefaultLightPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private Vector4 k_DefaultLightColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private Vector4 k_DefaultLightAttenuation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private Vector4 k_DefaultLightSpotDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private Vector4[] m_AdditionalLightPositions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private Vector4[] m_AdditionalLightColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private Vector4[] m_AdditionalLightAttenuations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private Vector4[] m_AdditionalLightSpotDirections;

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x12F9A00", Offset = "0x12F8E00", VA = "0x1812F9A00")]
		private void InitializeLightConstants(ref LightData lightData, int lightIndex, out Vector4 lightPos, out Vector4 lightColor, out Vector4 lightAttenuation, out Vector4 lightSpotDir)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x12FA520", Offset = "0x12F9920", VA = "0x1812FA520")]
		private void SetupShaderLightConstants(CommandBuffer cmd, ScriptableRenderer renderer, ref LightData lightData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x12FA3F0", Offset = "0x12F97F0", VA = "0x1812FA3F0")]
		private void SetupMainLightConstants(CommandBuffer cmd, ref LightData lightData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x12F9F30", Offset = "0x12F9330", VA = "0x1812F9F30")]
		private void SetupAdditionalLightConstants(CommandBuffer cmd, int maxLightCount, ref LightData lightData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x12F9670", Offset = "0x12F8A70", VA = "0x1812F9670", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x12FA680", Offset = "0x12F9A80", VA = "0x1812FA680")]
		public SetupAGRPConstantsPass()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class SetupForwardRenderingPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x12FA7A0", Offset = "0x12F9BA0", VA = "0x1812FA7A0", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x12EA920", Offset = "0x12E9D20", VA = "0x1812EA920")]
		public SetupForwardRenderingPass()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class TransparentPostProcessPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private const string k_PostProcessingTag = "Render PostProcess Effects";

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		private RenderTargetHandle colorAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x47EFD0", Offset = "0x47E3D0", VA = "0x18047EFD0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x594EA0", Offset = "0x5942A0", VA = "0x180594EA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x12F06F0", Offset = "0x12EFAF0", VA = "0x1812F06F0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x12F0720", Offset = "0x12EFB20", VA = "0x1812F0720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		private RenderTargetIdentifier destination
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x12FABE0", Offset = "0x12F9FE0", VA = "0x1812FABE0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetIdentifier);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x12FAC00", Offset = "0x12FA000", VA = "0x1812FAC00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x12FABA0", Offset = "0x12F9FA0", VA = "0x1812FABA0")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorAttachmentHandle, RenderTargetIdentifier destination)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x12FA9B0", Offset = "0x12F9DB0", VA = "0x1812FA9B0", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x12EA920", Offset = "0x12E9D20", VA = "0x1812EA920")]
		public TransparentPostProcessPass()
		{
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
