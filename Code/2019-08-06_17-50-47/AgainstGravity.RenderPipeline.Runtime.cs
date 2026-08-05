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
			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			public static int _GlossyEnvironmentColor;

			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public static int _SubtractiveShadowColor;
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private static class PerCameraBuffer
		{
			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			public static int _InvCameraViewProj;

			[Cpp2IlInjected.Token(Token = "0x40001EC")]
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
				[Cpp2IlInjected.Address(RVA = "0xBFC0", Offset = "0xB3C0", VA = "0x18000BFC0")]
				[CompilerGenerated]
				get
				{
					return default(DepthTextureRenderMode);
				}
				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0x6D30", Offset = "0x6130", VA = "0x180006D30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public bool supportsCameraOpaqueTexture
			{
				[Cpp2IlInjected.Token(Token = "0x60001CC")]
				[Cpp2IlInjected.Address(RVA = "0x213D80", Offset = "0x213180", VA = "0x180213D80")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001CD")]
				[Cpp2IlInjected.Address(RVA = "0x23D920", Offset = "0x23CD20", VA = "0x18023D920")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public Downsampling opaqueDownsampling
			{
				[Cpp2IlInjected.Token(Token = "0x60001CE")]
				[Cpp2IlInjected.Address(RVA = "0xBF60", Offset = "0xB360", VA = "0x18000BF60")]
				[CompilerGenerated]
				get
				{
					return default(Downsampling);
				}
				[Cpp2IlInjected.Token(Token = "0x60001CF")]
				[Cpp2IlInjected.Address(RVA = "0xE120", Offset = "0xD520", VA = "0x18000E120")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public bool supportsHDR
			{
				[Cpp2IlInjected.Token(Token = "0x60001D0")]
				[Cpp2IlInjected.Address(RVA = "0x23D7F0", Offset = "0x23CBF0", VA = "0x18023D7F0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001D1")]
				[Cpp2IlInjected.Address(RVA = "0x23D940", Offset = "0x23CD40", VA = "0x18023D940")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public int msaaSampleCount
			{
				[Cpp2IlInjected.Token(Token = "0x60001D2")]
				[Cpp2IlInjected.Address(RVA = "0xBF80", Offset = "0xB380", VA = "0x18000BF80")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60001D3")]
				[Cpp2IlInjected.Address(RVA = "0x224640", Offset = "0x223A40", VA = "0x180224640")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000084")]
			public float renderScale
			{
				[Cpp2IlInjected.Token(Token = "0x60001D4")]
				[Cpp2IlInjected.Address(RVA = "0x19E8C0", Offset = "0x19DCC0", VA = "0x18019E8C0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001D5")]
				[Cpp2IlInjected.Address(RVA = "0x19E8D0", Offset = "0x19DCD0", VA = "0x18019E8D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000085")]
			public LightRenderingMode mainLightRenderingMode
			{
				[Cpp2IlInjected.Token(Token = "0x60001D6")]
				[Cpp2IlInjected.Address(RVA = "0x2DF0", Offset = "0x21F0", VA = "0x180002DF0")]
				[CompilerGenerated]
				get
				{
					return default(LightRenderingMode);
				}
				[Cpp2IlInjected.Token(Token = "0x60001D7")]
				[Cpp2IlInjected.Address(RVA = "0x23D890", Offset = "0x23CC90", VA = "0x18023D890")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000086")]
			public bool supportsMainLightShadows
			{
				[Cpp2IlInjected.Token(Token = "0x60001D8")]
				[Cpp2IlInjected.Address(RVA = "0x23D800", Offset = "0x23CC00", VA = "0x18023D800")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001D9")]
				[Cpp2IlInjected.Address(RVA = "0x23D950", Offset = "0x23CD50", VA = "0x18023D950")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public int mainLightShadowmapResolution
			{
				[Cpp2IlInjected.Token(Token = "0x60001DA")]
				[Cpp2IlInjected.Address(RVA = "0x926F0", Offset = "0x91AF0", VA = "0x1800926F0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60001DB")]
				[Cpp2IlInjected.Address(RVA = "0x224660", Offset = "0x223A60", VA = "0x180224660")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			public LightRenderingMode additionalLightsRenderingMode
			{
				[Cpp2IlInjected.Token(Token = "0x60001DC")]
				[Cpp2IlInjected.Address(RVA = "0x1B4060", Offset = "0x1B3460", VA = "0x1801B4060")]
				[CompilerGenerated]
				get
				{
					return default(LightRenderingMode);
				}
				[Cpp2IlInjected.Token(Token = "0x60001DD")]
				[Cpp2IlInjected.Address(RVA = "0x224650", Offset = "0x223A50", VA = "0x180224650")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000089")]
			public int maxAdditionalLights
			{
				[Cpp2IlInjected.Token(Token = "0x60001DE")]
				[Cpp2IlInjected.Address(RVA = "0x213FE0", Offset = "0x2133E0", VA = "0x180213FE0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60001DF")]
				[Cpp2IlInjected.Address(RVA = "0x2BE0", Offset = "0x1FE0", VA = "0x180002BE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			public bool supportsAdditionalLightShadows
			{
				[Cpp2IlInjected.Token(Token = "0x60001E0")]
				[Cpp2IlInjected.Address(RVA = "0x23D7D0", Offset = "0x23CBD0", VA = "0x18023D7D0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001E1")]
				[Cpp2IlInjected.Address(RVA = "0x23D910", Offset = "0x23CD10", VA = "0x18023D910")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			public int additionalLightsShadowmapResolution
			{
				[Cpp2IlInjected.Token(Token = "0x60001E2")]
				[Cpp2IlInjected.Address(RVA = "0x7AE0", Offset = "0x6EE0", VA = "0x180007AE0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60001E3")]
				[Cpp2IlInjected.Address(RVA = "0xE0F0", Offset = "0xD4F0", VA = "0x18000E0F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			public float shadowDistance
			{
				[Cpp2IlInjected.Token(Token = "0x60001E4")]
				[Cpp2IlInjected.Address(RVA = "0x23D7C0", Offset = "0x23CBC0", VA = "0x18023D7C0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001E5")]
				[Cpp2IlInjected.Address(RVA = "0x23D900", Offset = "0x23CD00", VA = "0x18023D900")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public int cascadeCount
			{
				[Cpp2IlInjected.Token(Token = "0x60001E6")]
				[Cpp2IlInjected.Address(RVA = "0x2E00", Offset = "0x2200", VA = "0x180002E00")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60001E7")]
				[Cpp2IlInjected.Address(RVA = "0x23D880", Offset = "0x23CC80", VA = "0x18023D880")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public float cascade2Split
			{
				[Cpp2IlInjected.Token(Token = "0x60001E8")]
				[Cpp2IlInjected.Address(RVA = "0x23D730", Offset = "0x23CB30", VA = "0x18023D730")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001E9")]
				[Cpp2IlInjected.Address(RVA = "0x23D860", Offset = "0x23CC60", VA = "0x18023D860")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public Vector3 cascade4Split
			{
				[Cpp2IlInjected.Token(Token = "0x60001EA")]
				[Cpp2IlInjected.Address(RVA = "0x23D740", Offset = "0x23CB40", VA = "0x18023D740")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x60001EB")]
				[Cpp2IlInjected.Address(RVA = "0x23D870", Offset = "0x23CC70", VA = "0x18023D870")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public float mainLightShadowDepthBias
			{
				[Cpp2IlInjected.Token(Token = "0x60001EC")]
				[Cpp2IlInjected.Address(RVA = "0x23D760", Offset = "0x23CB60", VA = "0x18023D760")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001ED")]
				[Cpp2IlInjected.Address(RVA = "0x23D8A0", Offset = "0x23CCA0", VA = "0x18023D8A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public float mainLightShadowNormalBias
			{
				[Cpp2IlInjected.Token(Token = "0x60001EE")]
				[Cpp2IlInjected.Address(RVA = "0x23D770", Offset = "0x23CB70", VA = "0x18023D770")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001EF")]
				[Cpp2IlInjected.Address(RVA = "0x23D8B0", Offset = "0x23CCB0", VA = "0x18023D8B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public float mainLightShadowSampleBias
			{
				[Cpp2IlInjected.Token(Token = "0x60001F0")]
				[Cpp2IlInjected.Address(RVA = "0x23D780", Offset = "0x23CB80", VA = "0x18023D780")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001F1")]
				[Cpp2IlInjected.Address(RVA = "0x23D8C0", Offset = "0x23CCC0", VA = "0x18023D8C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public float additionalLightShadowDepthBias
			{
				[Cpp2IlInjected.Token(Token = "0x60001F2")]
				[Cpp2IlInjected.Address(RVA = "0x23D700", Offset = "0x23CB00", VA = "0x18023D700")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001F3")]
				[Cpp2IlInjected.Address(RVA = "0x23D830", Offset = "0x23CC30", VA = "0x18023D830")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public float additionalLightShadowNormalBias
			{
				[Cpp2IlInjected.Token(Token = "0x60001F4")]
				[Cpp2IlInjected.Address(RVA = "0x23D710", Offset = "0x23CB10", VA = "0x18023D710")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001F5")]
				[Cpp2IlInjected.Address(RVA = "0x23D840", Offset = "0x23CC40", VA = "0x18023D840")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public float additionalLightShadowSampleBias
			{
				[Cpp2IlInjected.Token(Token = "0x60001F6")]
				[Cpp2IlInjected.Address(RVA = "0x23D720", Offset = "0x23CB20", VA = "0x18023D720")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001F7")]
				[Cpp2IlInjected.Address(RVA = "0x23D850", Offset = "0x23CC50", VA = "0x18023D850")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public bool supportsSoftShadows
			{
				[Cpp2IlInjected.Token(Token = "0x60001F8")]
				[Cpp2IlInjected.Address(RVA = "0x23D810", Offset = "0x23CC10", VA = "0x18023D810")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001F9")]
				[Cpp2IlInjected.Address(RVA = "0x23D960", Offset = "0x23CD60", VA = "0x18023D960")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public bool supportsDynamicBatching
			{
				[Cpp2IlInjected.Token(Token = "0x60001FA")]
				[Cpp2IlInjected.Address(RVA = "0x23D7E0", Offset = "0x23CBE0", VA = "0x18023D7E0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001FB")]
				[Cpp2IlInjected.Address(RVA = "0x23D930", Offset = "0x23CD30", VA = "0x18023D930")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public bool mixedLightingSupported
			{
				[Cpp2IlInjected.Token(Token = "0x60001FC")]
				[Cpp2IlInjected.Address(RVA = "0x23D790", Offset = "0x23CB90", VA = "0x18023D790")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001FD")]
				[Cpp2IlInjected.Address(RVA = "0x23D8D0", Offset = "0x23CCD0", VA = "0x18023D8D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public bool supportsUGCMeshLODs
			{
				[Cpp2IlInjected.Token(Token = "0x60001FE")]
				[Cpp2IlInjected.Address(RVA = "0x23D820", Offset = "0x23CC20", VA = "0x18023D820")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001FF")]
				[Cpp2IlInjected.Address(RVA = "0x23D970", Offset = "0x23CD70", VA = "0x18023D970")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public RenderFeaturesetOption renderFeatureset
			{
				[Cpp2IlInjected.Token(Token = "0x6000200")]
				[Cpp2IlInjected.Address(RVA = "0x23D7B0", Offset = "0x23CBB0", VA = "0x18023D7B0")]
				[CompilerGenerated]
				get
				{
					return default(RenderFeaturesetOption);
				}
				[Cpp2IlInjected.Token(Token = "0x6000201")]
				[Cpp2IlInjected.Address(RVA = "0x23D8F0", Offset = "0x23CCF0", VA = "0x18023D8F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			public PostProcessingOption postProcessing
			{
				[Cpp2IlInjected.Token(Token = "0x6000202")]
				[Cpp2IlInjected.Address(RVA = "0x23D7A0", Offset = "0x23CBA0", VA = "0x18023D7A0")]
				[CompilerGenerated]
				get
				{
					return default(PostProcessingOption);
				}
				[Cpp2IlInjected.Token(Token = "0x6000203")]
				[Cpp2IlInjected.Address(RVA = "0x23D8E0", Offset = "0x23CCE0", VA = "0x18023D8E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x12F8A90", Offset = "0x12F7890", VA = "0x1812F8A90")]
			public static PipelineSettings Create(AgainstGravityRenderPipelineAsset asset)
			{
				return default(PipelineSettings);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private struct CameraCallbacks
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			public List<IBeforeCameraRender> beforeRenderBuffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			public List<IAfterCameraRender> afterRenderBuffer;

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x23D640", Offset = "0x23CA40", VA = "0x18023D640")]
			public void Clear()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public const string k_ShaderTagName = "AGRP";

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public static RenderFeaturesetOption ActiveRenderFeatureset;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public static bool SupportsUGCMeshLODs;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static IRendererSetup s_DefaultRendererSetup;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const string k_RenderCameraTag = "Render Camera";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private CullResults m_CullResults;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static readonly List<CameraCallbacks> currentlyRenderingCameras;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static int currentCameraIdx;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static List<Vector4> m_ShadowBiasData;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static IRendererSetup defaultRendererSetup
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x12EE7D0", Offset = "0x12ED5D0", VA = "0x1812EE7D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public ScriptableRenderer renderer
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x314F10", Offset = "0x313D10", VA = "0x180314F10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x314F20", Offset = "0x313D20", VA = "0x180314F20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private PipelineSettings settings
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x12EE8C0", Offset = "0x12ED6C0", VA = "0x1812EE8C0")]
			[CompilerGenerated]
			get
			{
				return default(PipelineSettings);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x12EEB10", Offset = "0x12ED910", VA = "0x1812EEB10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public static event RenderCallback BeforeCameraRenderEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x12EE6D0", Offset = "0x12ED4D0", VA = "0x1812EE6D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x12EEA10", Offset = "0x12ED810", VA = "0x1812EEA10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public static event RenderCallback AfterCameraRenderEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x12EE5D0", Offset = "0x12ED3D0", VA = "0x1812EE5D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x12EE910", Offset = "0x12ED710", VA = "0x1812EE910")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x12EE2B0", Offset = "0x12ED0B0", VA = "0x1812EE2B0")]
		public AgainstGravityRenderPipeline(AgainstGravityRenderPipelineAsset asset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x12EB2E0", Offset = "0x12EA0E0", VA = "0x1812EB2E0", Slot = "8")]
		public sealed override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x12ED070", Offset = "0x12EBE70", VA = "0x1812ED070", Slot = "7")]
		public override void Render(ScriptableRenderContext renderContext, Camera[] cameras)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x12EC760", Offset = "0x12EB560", VA = "0x1812EC760")]
		public static void RenderSingleCamera(AgainstGravityRenderPipeline pipelineInstance, ScriptableRenderContext context, Camera camera, ref CullResults cullResults, AGRPAdditionalCameraData additionalCameraData, [Optional] IRendererSetup setup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3030D0", Offset = "0x301ED0", VA = "0x1803030D0")]
		private static void SetSupportedRenderingFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x12EB460", Offset = "0x12EA260", VA = "0x1812EB460")]
		private static void InitializeCameraData(PipelineSettings settings, Camera camera, AGRPAdditionalCameraData additionalCameraData, out CameraData cameraData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x12EBBD0", Offset = "0x12EA9D0", VA = "0x1812EBBD0")]
		private static void InitializeRenderingData(PipelineSettings settings, ref CameraData cameraData, ref CullResults cullResults, int maxVisibleAdditionalLights, int maxPerObjectAdditionalLights, ILightDataInterpreter lightInterpreter, out RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x12EC170", Offset = "0x12EAF70", VA = "0x1812EC170")]
		private static void InitializeShadowData(PipelineSettings settings, ref LightData lightData, bool mainLightCastShadows, bool additionalLightsCastShadows, out ShadowData shadowData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x12EBA90", Offset = "0x12EA890", VA = "0x1812EBA90")]
		private static void InitializeLightData(PipelineSettings settings, int lightCount, int mainLightIndex, int maxAdditionalLights, int maxPerObjectAdditionalLights, ref LightData lightData, ref CameraData cameraData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x12EB390", Offset = "0x12EA190", VA = "0x1812EB390")]
		private static int GetMainLight(LightRenderingMode mode, ref LightData lightData)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x12EDED0", Offset = "0x12ECCD0", VA = "0x1812EDED0")]
		private static void SetupPerFrameShaderConstants()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x12EDB70", Offset = "0x12EC970", VA = "0x1812EDB70")]
		private static void SetupPerCameraShaderConstants(CameraData cameraData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x12EC680", Offset = "0x12EB480", VA = "0x1812EC680")]
		public static bool IsStereoEnabled(Camera camera)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x12EE0F0", Offset = "0x12ECEF0", VA = "0x1812EE0F0")]
		private void SortCameras(Camera[] cameras)
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum MixedLightingSetup
	{
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		ShadowMask,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		Subtractive
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct RenderingData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public CullResults cullResults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public CameraData cameraData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public LightData lightData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public ShadowData shadowData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public bool supportsDynamicBatching;
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct LightData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int mainLightIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int additionalLightsCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int maxPerObjectAdditionalLightsCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public bool shadeAdditionalLightsPerVertex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public bool supportsMixedLighting;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public bool supportsAdditionalLights;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public List<BinnableLight> allBinnableLights;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public List<VisibleLight> visibleLights;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public ILightDataInterpreter lightInterpreter;
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct CameraData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public Camera camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AGRPAdditionalCameraData additionalCameraData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public float renderScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int msaaSamples;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public bool isSceneViewCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public bool isDefaultViewport;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public bool isOffscreenRender;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public bool isHdrEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public DepthTextureRenderMode depthTextureMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public bool requiresOpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public Downsampling opaqueTextureDownsampling;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public SortFlags defaultOpaqueSortFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public bool isStereoEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public float maxShadowDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public PostProcessingOption postProcessing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public PostProcessLayer postProcessLayer;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct ShadowData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool supportsMainLightShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public bool requiresScreenSpaceShadowResolve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int mainLightShadowmapWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public int mainLightShadowmapHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int mainLightShadowCascadesCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Vector3 mainLightShadowCascadesSplit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public float mainLightShadowsSampleBias;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public bool supportsAdditionalLightShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int additionalLightsShadowmapWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int additionalLightsShadowmapHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool supportsSoftShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public int shadowmapDepthBufferBits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public Vector4 defaultBias;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public List<Vector4> bias;
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class ShaderKeywordStrings
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly string MainLightShadows;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly string MainLightShadowCascades;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly string AdditionalLightsVertex;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly string AdditionalLightsPixel;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly string AdditionalLightShadows;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly string SoftShadows;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public static readonly string MixedLightingSubtractive;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly string RenderFeaturesetMobile;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public static readonly string RenderFeaturesetFull;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly string DepthTexture;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public static readonly string DepthNoMsaa;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly string DepthMsaa2;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public static readonly string DepthMsaa4;
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum CameraOverrideOption
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		On,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		UsePipelineSettings
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[DisallowMultipleComponent]
	[ImageEffectAllowedInSceneView]
	[RequireComponent(typeof(Camera))]
	public class AGRPAdditionalCameraData : MonoBehaviour, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		[Tooltip("If enabled shadows will render for this camera.")]
		[FormerlySerializedAs("renderShadows")]
		private bool m_RenderShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		[Tooltip("If enabled this camera will be used for rendering operations that only happen once per frame such as light binning.")]
		private bool m_IsMainCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[SerializeField]
		[Tooltip("If enabled opaque color texture will render for this camera and bound as _CameraOpaqueTexture.")]
		private CameraOverrideOption m_RequiresOpaqueTextureOption;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private bool m_DisableAdditionalLights;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[SerializeField]
		[Tooltip("If enabled, mirrors should always render for this camera")]
		private bool m_forceRenderMirrors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[SerializeField]
		[FormerlySerializedAs("requiresDepthTexture")]
		private bool m_RequiresDepthTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		[FormerlySerializedAs("requiresColorTexture")]
		private bool m_RequiresColorTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[HideInInspector]
		[SerializeField]
		private float m_Version;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float version
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x553BF0", Offset = "0x5529F0", VA = "0x180553BF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool renderShadows
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x3086B0", Offset = "0x3074B0", VA = "0x1803086B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x3157D0", Offset = "0x3145D0", VA = "0x1803157D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool disableAdditionalLights
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x32A4C0", Offset = "0x3292C0", VA = "0x18032A4C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x32A610", Offset = "0x329410", VA = "0x18032A610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool isMainCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x86C730", Offset = "0x86B530", VA = "0x18086C730")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x513890", Offset = "0x512690", VA = "0x180513890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool forceRenderMirrors
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x32A4D0", Offset = "0x3292D0", VA = "0x18032A4D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x32A620", Offset = "0x329420", VA = "0x18032A620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public CameraOverrideOption requiresColorOption
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x312C60", Offset = "0x311A60", VA = "0x180312C60")]
			get
			{
				return default(CameraOverrideOption);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x348590", Offset = "0x347390", VA = "0x180348590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool IsSimpleUIViewCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x315B80", Offset = "0x314980", VA = "0x180315B80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x315B90", Offset = "0x314990", VA = "0x180315B90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool requiresColorTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x12E8970", Offset = "0x12E7770", VA = "0x1812E8970")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x12E8A50", Offset = "0x12E7850", VA = "0x1812E8A50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3030D0", Offset = "0x301ED0", VA = "0x1803030D0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x12E8930", Offset = "0x12E7730", VA = "0x1812E8930", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x12E8950", Offset = "0x12E7750", VA = "0x1812E8950")]
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
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		[Tooltip("Controls the usage of pipeline settings.")]
		private bool m_UsePipelineSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		private float m_shadowSampleBias;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool usePipelineSettings
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x3086B0", Offset = "0x3074B0", VA = "0x1803086B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x3157D0", Offset = "0x3145D0", VA = "0x1803157D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public float shadowSampleBias
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5CD9D0", Offset = "0x5CC7D0", VA = "0x1805CD9D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x35A360", Offset = "0x359160", VA = "0x18035A360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x749160", Offset = "0x747F60", VA = "0x180749160")]
		public AGRPAdditionalLightData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class AGRPConsts
	{
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public const int VOXEL_COUNT_WIDTH = 24;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public const int VOXEL_COUNT_HEIGHT = 12;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public const int VOXEL_COUNT_DEPTH = 24;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public const float VOXEL_SIZE_METERS = 5f;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public const float VOXEL_BOUNDING_SPHERE_RADIUS = 3.535534f;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public const int MAX_LIGHTS_IN_SCENE = 160;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public const float MAX_CACHED_SHADOW_RENDER_DISTANCE = 30f;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public const float MAX_CACHED_SHADOW_RENDER_DISTANCE_SQR = 900f;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private const float SQRT_TWO_OVER_TWO = 0.70710677f;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public const int FIXED_VOXEL_LIGHT_COUNT = 8;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private const int VOXEL_HEADER_SIZE_MOBILE = 0;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private const int VOXEL_HEADER_SIZE_FULLY_FEATURED = 1;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public const int VOXEL_COUNT_PER_DEPTH_LAYER = 288;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public const int VOXEL_COUNT = 6912;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x12E8A70", Offset = "0x12E7870", VA = "0x1812E8A70")]
		public static int GetFixedVoxelSize(RenderFeaturesetOption renderFeatureSet)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x12E8A80", Offset = "0x12E7880", VA = "0x1812E8A80")]
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
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public static readonly List<AGRPLight> AllLights;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly List<BinnableLight> AllBinnableLights;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Range(0f, 1f)]
		public float specularContribution;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[Header("Hemisphere Lights")]
		public bool isHemisphereLight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Range(0f, 180f)]
		public float hemisphereLightInnerAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Range(0f, 180f)]
		public float hemisphereLightOuterAngle;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Light UnityLight
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x3085A0", Offset = "0x3073A0", VA = "0x1803085A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x309AA0", Offset = "0x3088A0", VA = "0x180309AA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x12E8FD0", Offset = "0x12E7DD0", VA = "0x1812E8FD0")]
		public static void UpdateBinnableLights()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x12E8AF0", Offset = "0x12E78F0", VA = "0x1812E8AF0")]
		public static List<BinnableLight> GetCurrentBinnableLights()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x12E8A90", Offset = "0x12E7890", VA = "0x1812E8A90")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x12E8D10", Offset = "0x12E7B10", VA = "0x1812E8D10")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x12E8B50", Offset = "0x12E7950", VA = "0x1812E8B50")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x12E8F50", Offset = "0x12E7D50", VA = "0x1812E8F50")]
		private static void TrackLight(AGRPLight light)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x12E8DD0", Offset = "0x12E7BD0", VA = "0x1812E8DD0")]
		private static void StopTrackingLight(AGRPLight light)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x12E9520", Offset = "0x12E8320", VA = "0x1812E9520")]
		public AGRPLight()
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum RenderFeaturesetOption
	{
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		Mobile,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		FullyFeatured
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum DepthTextureRenderMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		Required,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		Automatic,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		Disabled
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum ShadowCascadesOption
	{
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		NoCascades,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		TwoCascades,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		FourCascades
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum ShadowQuality
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		Disabled,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		HardShadows,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		SoftShadows
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum ShadowResolution
	{
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		_256 = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		_512 = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		_1024 = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		_2048 = 0x800,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		_4096 = 0x1000
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum MsaaQuality
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		Disabled = 1,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		_2x = 2,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		_4x = 4,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		_8x = 8
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum Downsampling
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		_2xBilinear,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		_4xBox,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		_4xBilinear
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal enum DefaultMaterialType
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		Standard,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		Particle,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		Terrain,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		UnityBuiltinDefault
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum LightRenderingMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		Disabled = 0,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		PerVertex = 2,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		PerPixel = 1
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public enum PostProcessingOption
	{
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		Mobile,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		Full
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public enum ShaderVariantLogLevel
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		Disabled,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		OnlyAGRPShaders,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		AllShaders
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class AgainstGravityRenderPipelineAsset : RenderPipelineAsset, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private Shader m_DefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		private int k_AssetVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		private RenderFeaturesetOption m_RenderFeatureset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		private DepthTextureRenderMode m_DepthTextureMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		private PostProcessingOption m_PostProcessing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		private bool m_RequireOpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		private Downsampling m_OpaqueDownsampling;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		private bool m_SupportsHDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[SerializeField]
		private MsaaQuality m_MSAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[SerializeField]
		private float m_RenderScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[SerializeField]
		private bool m_SupportsUGCMeshLODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[SerializeField]
		private LightRenderingMode m_MainLightRenderingMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[SerializeField]
		private bool m_MainLightShadowsSupported;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[SerializeField]
		private ShadowResolution m_MainLightShadowmapResolution;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[SerializeField]
		private LightRenderingMode m_AdditionalLightsRenderingMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[SerializeField]
		private int m_AdditionalLightsPerObjectLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[SerializeField]
		private bool m_AdditionalLightShadowsSupported;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[SerializeField]
		private ShadowResolution m_AdditionalLightsShadowmapResolution;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[SerializeField]
		private float m_ShadowDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[SerializeField]
		private ShadowCascadesOption m_ShadowCascades;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[SerializeField]
		private float m_Cascade2Split;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[SerializeField]
		private Vector3 m_Cascade4Split;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[SerializeField]
		private float m_mainLightShadowDepthBias;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[SerializeField]
		private float m_mainLightShadowNormalBias;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[SerializeField]
		private float m_mainLightShadowSampleBias;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[SerializeField]
		private float m_additionalLightShadowDepthBias;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[SerializeField]
		private float m_additionalLightShadowNormalBias;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[SerializeField]
		private float m_additionalLightShadowSampleBias;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[SerializeField]
		private bool m_SoftShadowsSupported;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[SerializeField]
		private bool m_SupportsDynamicBatching;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[SerializeField]
		private bool m_MixedLightingSupported;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		[SerializeField]
		private ShadowQuality m_ShadowType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		[SerializeField]
		private bool m_LocalShadowsSupported;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		[SerializeField]
		private ShadowResolution m_LocalShadowsAtlasResolution;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		[SerializeField]
		private int m_MaxPixelLights;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		[SerializeField]
		private ShadowResolution m_ShadowAtlasResolution;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		[SerializeField]
		private AgainstGravityRenderPipelineResources m_ResourcesAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		[SerializeField]
		private ShaderVariantLogLevel m_ShaderVariantLogLevel;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private AgainstGravityRenderPipelineResources resources
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x582B80", Offset = "0x581980", VA = "0x180582B80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public DepthTextureRenderMode depthTextureMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x40AA80", Offset = "0x409880", VA = "0x18040AA80")]
			get
			{
				return default(DepthTextureRenderMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public PostProcessingOption postProcessing
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x326D10", Offset = "0x325B10", VA = "0x180326D10")]
			get
			{
				return default(PostProcessingOption);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool supportsCameraOpaqueTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x32B1D0", Offset = "0x329FD0", VA = "0x18032B1D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public RenderFeaturesetOption renderFeatureset
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x31F860", Offset = "0x31E660", VA = "0x18031F860")]
			get
			{
				return default(RenderFeaturesetOption);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Downsampling opaqueDownsampling
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x4199F0", Offset = "0x4187F0", VA = "0x1804199F0")]
			get
			{
				return default(Downsampling);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool supportsHDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x326C50", Offset = "0x325A50", VA = "0x180326C50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int msaaSampleCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x4B1300", Offset = "0x4B0100", VA = "0x1804B1300")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float renderScale
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x696660", Offset = "0x695460", VA = "0x180696660")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool supportsUGCMeshLODs
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x4B7820", Offset = "0x4B6620", VA = "0x1804B7820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public LightRenderingMode mainLightRenderingMode
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x318790", Offset = "0x317590", VA = "0x180318790")]
			get
			{
				return default(LightRenderingMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool supportsMainLightShadows
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7CE5A0", Offset = "0x7CD3A0", VA = "0x1807CE5A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ShadowResolution mainLightShadowmapResolution
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x4B12F0", Offset = "0x4B00F0", VA = "0x1804B12F0")]
			get
			{
				return default(ShadowResolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public LightRenderingMode additionalLightsRenderingMode
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x715EB0", Offset = "0x714CB0", VA = "0x180715EB0")]
			get
			{
				return default(LightRenderingMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int maxAdditionalLightsCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5FF640", Offset = "0x5FE440", VA = "0x1805FF640")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool supportsAdditionalLightShadows
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6D1F50", Offset = "0x6D0D50", VA = "0x1806D1F50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public ShadowResolution additionalLightsShadowmapResolution
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x582DD0", Offset = "0x581BD0", VA = "0x180582DD0")]
			get
			{
				return default(ShadowResolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float shadowDistance
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x110F6A0", Offset = "0x110E4A0", VA = "0x18110F6A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public ShadowCascadesOption cascadeCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x723670", Offset = "0x722470", VA = "0x180723670")]
			get
			{
				return default(ShadowCascadesOption);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float cascade2Split
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x903970", Offset = "0x902770", VA = "0x180903970")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 cascade4Split
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x766300", Offset = "0x765100", VA = "0x180766300")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float mainLightShadowDepthBias
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7A21B0", Offset = "0x7A0FB0", VA = "0x1807A21B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float mainLightShadowNormalBias
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x9FC780", Offset = "0x9FB580", VA = "0x1809FC780")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float mainLightShadowSampleBias
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xEBFA50", Offset = "0xEBE850", VA = "0x180EBFA50")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float additionalLightShadowDepthBias
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xEBF8D0", Offset = "0xEBE6D0", VA = "0x180EBF8D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float additionalLightShadowNormalBias
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x11ABC30", Offset = "0x11AAA30", VA = "0x1811ABC30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public float additionalLightShadowSampleBias
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x12EAF60", Offset = "0x12E9D60", VA = "0x1812EAF60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool supportsSoftShadows
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xEBFB80", Offset = "0xEBE980", VA = "0x180EBFB80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool supportsDynamicBatching
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xEBFB70", Offset = "0xEBE970", VA = "0x180EBFB70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool supportsMixedLighting
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x12EB2D0", Offset = "0x12EA0D0", VA = "0x1812EB2D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public ShaderVariantLogLevel shaderVariantLogLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x129AD80", Offset = "0x1299B80", VA = "0x18129AD80")]
			get
			{
				return default(ShaderVariantLogLevel);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Shader blitShader
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x12EAF70", Offset = "0x12E9D70", VA = "0x1812EAF70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Shader copyDepthShader
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x12EB000", Offset = "0x12E9E00", VA = "0x1812EB000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Shader screenSpaceShadowShader
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x12EB240", Offset = "0x12EA040", VA = "0x1812EB240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public Shader samplingShader
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x12EB1B0", Offset = "0x12E9FB0", VA = "0x1812EB1B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Shader mobileFadeEffectShader
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x12EB090", Offset = "0x12E9E90", VA = "0x1812EB090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public Shader mobileVignetteEffectShader
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x12EB120", Offset = "0x12E9F20", VA = "0x1812EB120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x12EAD80", Offset = "0x12E9B80", VA = "0x1812EAD80", Slot = "19")]
		protected override IRenderPipeline InternalCreatePipeline()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x32ED30", Offset = "0x32DB30", VA = "0x18032ED30")]
		private Material GetMaterial(DefaultMaterialType materialType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x32ED30", Offset = "0x32DB30", VA = "0x18032ED30", Slot = "7")]
		public override Material GetDefaultMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x32ED30", Offset = "0x32DB30", VA = "0x18032ED30", Slot = "11")]
		public override Material GetDefaultParticleMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x32ED30", Offset = "0x32DB30", VA = "0x18032ED30", Slot = "12")]
		public override Material GetDefaultLineMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x32ED30", Offset = "0x32DB30", VA = "0x18032ED30", Slot = "13")]
		public override Material GetDefaultTerrainMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x32ED30", Offset = "0x32DB30", VA = "0x18032ED30", Slot = "14")]
		public override Material GetDefaultUIMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x32ED30", Offset = "0x32DB30", VA = "0x18032ED30", Slot = "15")]
		public override Material GetDefaultUIOverdrawMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x32ED30", Offset = "0x32DB30", VA = "0x18032ED30", Slot = "16")]
		public override Material GetDefaultUIETC1SupportedMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x32ED30", Offset = "0x32DB30", VA = "0x18032ED30", Slot = "17")]
		public override Material GetDefault2DMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x12EACE0", Offset = "0x12E9AE0", VA = "0x1812EACE0", Slot = "18")]
		public override Shader GetDefaultShader()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3030D0", Offset = "0x301ED0", VA = "0x1803030D0", Slot = "22")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x12EADE0", Offset = "0x12E9BE0", VA = "0x1812EADE0", Slot = "23")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x12EAE50", Offset = "0x12E9C50", VA = "0x1812EAE50")]
		public AgainstGravityRenderPipelineAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class AgainstGravityRenderPipelineEditorResources : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[SerializeField]
		[FormerlySerializedAs("DefaultMaterial")]
		private Material m_LitMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[SerializeField]
		[FormerlySerializedAs("DefaultParticleMaterial")]
		private Material m_ParticleLitMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[SerializeField]
		[FormerlySerializedAs("DefaultTerrainMaterial")]
		private Material m_TerrainLitMaterial;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Material litMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x320310", Offset = "0x31F110", VA = "0x180320310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Material particleLitMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x31F8D0", Offset = "0x31E6D0", VA = "0x18031F8D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Material terrainLitMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x3085A0", Offset = "0x3073A0", VA = "0x1803085A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4D9CA0", Offset = "0x4D8AA0", VA = "0x1804D9CA0")]
		public AgainstGravityRenderPipelineEditorResources()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class AgainstGravityRenderPipelineResources : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		[SerializeField]
		[FormerlySerializedAs("BlitShader")]
		private Shader m_BlitShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[SerializeField]
		[FormerlySerializedAs("CopyDepthShader")]
		private Shader m_CopyDepthShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		[SerializeField]
		[FormerlySerializedAs("ScreenSpaceShadowShader")]
		private Shader m_ScreenSpaceShadowShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[SerializeField]
		[FormerlySerializedAs("SamplingShader")]
		private Shader m_SamplingShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		[SerializeField]
		private Shader m_MobileFadeEffectShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[SerializeField]
		private Shader m_MobileVignetteEffectShader;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Shader blitShader
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x320310", Offset = "0x31F110", VA = "0x180320310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public Shader copyDepthShader
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x31F8D0", Offset = "0x31E6D0", VA = "0x18031F8D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public Shader screenSpaceShadowShader
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x3085A0", Offset = "0x3073A0", VA = "0x1803085A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public Shader samplingShader
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x319A40", Offset = "0x318840", VA = "0x180319A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public Shader mobileFadeEffectShader
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x3078B0", Offset = "0x3066B0", VA = "0x1803078B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Shader mobileVignetteEffectShader
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x314F10", Offset = "0x313D10", VA = "0x180314F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4D9CA0", Offset = "0x4D8AA0", VA = "0x1804D9CA0")]
		public AgainstGravityRenderPipelineResources()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal sealed class DefaultRendererSetup : IRendererSetup
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private RendererSetupSimpleUIView simpleUIViewRenderSetup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private IRendererSetup rendererSetup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private ILightDataInterpreter lightInterpreter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private RenderFeaturesetOption currentOption;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public ILightDataInterpreter LightInterpreter
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x31F8D0", Offset = "0x31E6D0", VA = "0x18031F8D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x12F3560", Offset = "0x12F2360", VA = "0x1812F3560")]
		private IRendererSetup GetOrAssignRendererSetup(ScriptableRenderer renderer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x12F36D0", Offset = "0x12F24D0", VA = "0x1812F36D0", Slot = "4")]
		public void PreCullSetup(ScriptableRenderer renderer, ScriptableRenderContext context, Camera camera, CameraData cameraData, ref LightData lightData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x12F38D0", Offset = "0x12F26D0", VA = "0x1812F38D0", Slot = "5")]
		public void Setup(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x12F34F0", Offset = "0x12F22F0", VA = "0x1812F34F0")]
		public Light GetLight(ref LightData lightData, int lightIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x12F3320", Offset = "0x12F2120", VA = "0x1812F3320")]
		public AGRPLight GetAGRPLight(ref LightData lightData, int lightIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x12F33F0", Offset = "0x12F21F0", VA = "0x1812F33F0")]
		public int GetLightCount(ref LightData lightData)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x12F3450", Offset = "0x12F2250", VA = "0x1812F3450")]
		public bool GetLightInfo(ref LightData lightData, int lightIdx, out Vector4 pos, out Vector4 dir, out Color finalColor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x12F32A0", Offset = "0x12F20A0", VA = "0x1812F32A0")]
		public int CopyToBinnableLights(ref LightData lightData, BinnableLight[] binnableLightBuffer, int maxLightCount)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x317C70", Offset = "0x316A70", VA = "0x180317C70")]
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
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int globalIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public LightType lightType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public float4x4 localToWorld;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public float approxIntensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public float range;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public float spotAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public Color finalColor;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public AGRPLight AGRPLight
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x23D530", Offset = "0x23C930", VA = "0x18023D530")]
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
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public ushort lightIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public float clusterImportance;
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[BurstCompile]
	public struct CalculateVoxelPoints : IJobParallelFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[WriteOnly]
		public NativeArray<float3> voxelPoints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[ReadOnly]
		public float3 worldVolumeMinCorner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[ReadOnly]
		public float3 worldVolumeMaxCorner;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x23D540", Offset = "0x23C940", VA = "0x18023D540", Slot = "4")]
		public void Execute(int index)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[BurstCompile]
	public struct BinPerLightJob : IJobParallelFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[ReadOnly]
		public NativeArray<BinnableLight> lights;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[ReadOnly]
		public NativeArray<float3> voxelPoints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[ReadOnly]
		public float3 worldVolumeMinCorner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[ReadOnly]
		public float3 worldVolumeMaxCorner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		[WriteOnly]
		public NativeMultiHashMap<ushort, LightInBin>.Concurrent clusteredLightIndices;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x23D2E0", Offset = "0x23C6E0", VA = "0x18023D2E0", Slot = "4")]
		public void Execute(int lightIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x23D020", Offset = "0x23C420", VA = "0x18023D020")]
		private void AddPointLightImportances(uint3 minVoxelIdx, uint3 maxVoxelIdx, ushort lightIdx, float3 lightPos, float lightIntensity, float lightRange)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x23D0B0", Offset = "0x23C4B0", VA = "0x18023D0B0")]
		private void AddSpotLightImportances(uint3 minVoxelIdx, uint3 maxVoxelIdx, ushort lightIdx, float3 lightPos, float3 expandedLightPos, float3 lightForward, float lightIntensity, float lightBaseRadius, float lightRange, float expandedLightRange)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x23D380", Offset = "0x23C780", VA = "0x18023D380")]
		private float PointLightIntensity(float approxIntensity)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x23D2F0", Offset = "0x23C6F0", VA = "0x18023D2F0")]
		private float LinearAttenuation(float3 voxelCenter, float3 lightPos, float lightRange)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x23D1B0", Offset = "0x23C5B0", VA = "0x18023D1B0")]
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
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		[ReadOnly]
		public NativeMultiHashMap<ushort, LightInBin> clusteredLightIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		[ReadOnly]
		public uint lightCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		[ReadOnly]
		public int headerSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public NativeArray<uint> voxels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public NativeArray<float> importances;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x23D3D0", Offset = "0x23C7D0", VA = "0x18023D3D0", Slot = "4")]
		public void Execute(int voxelStartIdx, int voxelCapacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x23D3C0", Offset = "0x23C7C0", VA = "0x18023D3C0")]
		private void AddLight(int lightingStartIdx, ushort lightsInCurrentVoxel, int lightCapacity, LightInBin lightInVoxelData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[BurstCompile]
	public struct ClearBufferJob<T, U> : IJob where T : struct, IEquatable<T> where U : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public NativeMultiHashMap<T, U> bufferToClear;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1F3820", Offset = "0x1F2C20", VA = "0x1801F3820", Slot = "4")]
		public void Execute()
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public enum MaterialHandle
	{
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		CopyDepth,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		Sampling,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		Blit,
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		ScreenSpaceShadow,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		Count
	}
	[StructLayout((LayoutKind)0, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct RenderTargetHandle
	{
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public static readonly RenderTargetHandle CameraTarget;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public int id
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xBFC0", Offset = "0xB3C0", VA = "0x18000BFC0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x6D30", Offset = "0x6130", VA = "0x180006D30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x23DC20", Offset = "0x23D020", VA = "0x18023DC20")]
		public void Init(string shaderProperty)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x23DBA0", Offset = "0x23CFA0", VA = "0x18023DBA0")]
		public RenderTargetIdentifier Identifier()
		{
			return default(RenderTargetIdentifier);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1C5C80", Offset = "0x1C5080", VA = "0x1801C5C80")]
		public bool Equals(RenderTargetHandle other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x23DB20", Offset = "0x23CF20", VA = "0x18023DB20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xBFC0", Offset = "0xB3C0", VA = "0x18000BFC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xFC8A10", Offset = "0xFC7810", VA = "0x180FC8A10")]
		public static bool operator ==(RenderTargetHandle c1, RenderTargetHandle c2)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xFC9560", Offset = "0xFC8360", VA = "0x180FC9560")]
		public static bool operator !=(RenderTargetHandle c1, RenderTargetHandle c2)
		{
			return default(bool);
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public enum SampleCount
	{
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		One = 1,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		Two = 2,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		Four = 4
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class ScriptableRenderer
	{
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public static readonly RendererConfiguration RendererConfiguration;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private static Mesh s_FullscreenMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private List<ScriptableRenderPass> m_ActiveRenderPassQueue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private List<ShaderPassName> m_LegacyShaderPassNames;

		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private const string k_ReleaseResourcesTag = "Release Resources";

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private readonly Material[] m_Materials;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int maxPerObjectAdditionalLights
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x20B6910", Offset = "0x20B5710", VA = "0x1820B6910")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int maxVisibleAdditionalLights
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x20B6910", Offset = "0x20B5710", VA = "0x1820B6910")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public PostProcessRenderContext postProcessingContext
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x3072D0", Offset = "0x3060D0", VA = "0x1803072D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x314450", Offset = "0x313250", VA = "0x180314450")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public RenderFeaturesetOption RendererFeatureset
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x3072E0", Offset = "0x3060E0", VA = "0x1803072E0")]
			[CompilerGenerated]
			get
			{
				return default(RenderFeaturesetOption);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x3485A0", Offset = "0x3473A0", VA = "0x1803485A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public ComputeBuffer perObjectLightIndices
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x31F8D0", Offset = "0x31E6D0", VA = "0x18031F8D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x3574A0", Offset = "0x3562A0", VA = "0x1803574A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		private static Mesh fullscreenMesh
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x20B6490", Offset = "0x20B5290", VA = "0x1820B6490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public Shader mobileFadeEffectShader
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x314F10", Offset = "0x313D10", VA = "0x180314F10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x314F20", Offset = "0x313D20", VA = "0x180314F20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public Shader mobileVignetteEffectShader
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x323D40", Offset = "0x322B40", VA = "0x180323D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x3CD6B0", Offset = "0x3CC4B0", VA = "0x1803CD6B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x20B5FF0", Offset = "0x20B4DF0", VA = "0x1820B5FF0")]
		public ScriptableRenderer(AgainstGravityRenderPipelineAsset pipelineAsset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x20B5050", Offset = "0x20B3E50", VA = "0x1820B5050")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x20B5180", Offset = "0x20B3F80", VA = "0x1820B5180")]
		public void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x20B5740", Offset = "0x20B4540", VA = "0x1820B5740")]
		public Material GetMaterial(MaterialHandle handle)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x20B4C30", Offset = "0x20B3A30", VA = "0x1820B4C30")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x20B5120", Offset = "0x20B3F20", VA = "0x1820B5120")]
		public void EnqueuePass(ScriptableRenderPass pass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x20B5CB0", Offset = "0x20B4AB0", VA = "0x1820B5CB0")]
		public void RenderPostProcess(CommandBuffer cmd, ref CameraData cameraData, RenderTextureFormat colorFormat, RenderTargetIdentifier source, RenderTargetIdentifier dest, bool opaqueOnly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x20B59D0", Offset = "0x20B47D0", VA = "0x1820B59D0")]
		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void RenderObjectsWithError(ScriptableRenderContext context, ref CullResults cullResults, Camera camera, FilterRenderersSettings filterSettings, SortFlags sortFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x20B4D70", Offset = "0x20B3B70", VA = "0x1820B4D70")]
		public static RenderTextureDescriptor CreateRenderTextureDescriptor(ref CameraData cameraData, float scaler = 1f)
		{
			return default(RenderTextureDescriptor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x20B5E90", Offset = "0x20B4C90", VA = "0x1820B5E90")]
		public static bool RequiresIntermediateColorTexture(ref CameraData cameraData, RenderTextureDescriptor baseDescriptor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x20B5640", Offset = "0x20B4440", VA = "0x1820B5640")]
		public static ClearFlag GetCameraClearFlag(Camera camera)
		{
			return default(ClearFlag);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x20B5880", Offset = "0x20B4680", VA = "0x1820B5880")]
		public static void RenderFullscreenQuad(CommandBuffer cmd, Material material, [Optional] MaterialPropertyBlock properties, int shaderPassId = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x20B4C80", Offset = "0x20B3A80", VA = "0x1820B4C80")]
		public static void CopyTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier dest, Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x20B4F20", Offset = "0x20B3D20", VA = "0x1820B4F20")]
		private void DisposePasses(ref ScriptableRenderContext context)
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public enum ShaderPathID
	{
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		PhysicallyBased,
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		SimpleLit,
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		Unlit,
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		TerrainPhysicallyBased,
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		ParticlesPhysicallyBased,
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		ParticlesSimpleLit,
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		ParticlesUnlit,
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		Count
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class ShaderUtils
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private static readonly string[] s_ShaderPaths;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x20B6A90", Offset = "0x20B5890", VA = "0x1820B6A90")]
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
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public Matrix4x4 viewMatrix;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public Matrix4x4 projectionMatrix;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public Matrix4x4 shadowTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public int offsetX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public int offsetY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public int resolution;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2CED30", Offset = "0x2CE130", VA = "0x1802CED30")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public static class ShadowUtils
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x20B7100", Offset = "0x20B5F00", VA = "0x1820B7100")]
		public static bool ExtractDirectionalLightMatrix(ref CullResults cullResults, ref ShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowResolution, float shadowNearPlane, out Vector4 cascadeSplitDistance, out ShadowSliceData shadowSliceData, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x20B74D0", Offset = "0x20B62D0", VA = "0x1820B74D0")]
		public static bool ExtractSpotLightMatrix(ref CullResults cullResults, ref ShadowData shadowData, int shadowLightIndex, out Matrix4x4 shadowMatrix, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x20B7C40", Offset = "0x20B6A40", VA = "0x1820B7C40")]
		public static void RenderShadowSlice(CommandBuffer cmd, ref ScriptableRenderContext context, ref ShadowSliceData shadowSliceData, ref DrawShadowsSettings settings, Matrix4x4 proj, Matrix4x4 view)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x20B7600", Offset = "0x20B6400", VA = "0x1820B7600")]
		public static int GetMaxTileResolutionInAtlas(int atlasWidth, int atlasHeight, int tileCount)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x20B6F10", Offset = "0x20B5D10", VA = "0x1820B6F10")]
		public static void ApplySliceTransform(ref ShadowSliceData shadowSliceData, int atlasWidth, int atlasHeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x20B76A0", Offset = "0x20B64A0", VA = "0x1820B76A0")]
		public static Vector4 GetShadowBias(Light shadowLight, int shadowLightIndex, ref ShadowData shadowData, Matrix4x4 lightProjectionMatrix, float shadowResolution)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x20B7E30", Offset = "0x20B6C30", VA = "0x1820B7E30")]
		public static void SetupShadowCasterConstantBuffer(CommandBuffer cmd, Light shadowLight, Vector4 shadowBias)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x20B8000", Offset = "0x20B6E00", VA = "0x1820B8000")]
		[Obsolete]
		public static void SetupShadowCasterConstants(CommandBuffer cmd, ref VisibleLight visibleLight, Matrix4x4 proj, float cascadeResolution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x20B79B0", Offset = "0x20B67B0", VA = "0x1820B79B0")]
		private static Matrix4x4 GetShadowTransform(Matrix4x4 proj, Matrix4x4 view)
		{
			return default(Matrix4x4);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class VisualizeFroxelBounds : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x20B8320", Offset = "0x20B7120", VA = "0x1820B8320")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x358D70", Offset = "0x357B70", VA = "0x180358D70")]
		public VisualizeFroxelBounds()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class VoxelMath
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public const float VOXEL_VOLUME_WIDTH = 120f;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public const float VOXEL_VOLUME_HEIGHT = 60f;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public const float VOXEL_VOLUME_DEPTH = 120f;

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public const float WIDTH_COUNT_F = 24f;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public const float HEIGHT_COUNT_F = 12f;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public const float DEPTH_COUNT_F = 24f;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public const float WIDTH_COUNT_RECIP = 1f / 24f;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public const float HEIGHT_COUNT_RECIP = 1f / 12f;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public const float DEPTH_COUNT_RECIP = 1f / 24f;

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private const int MAX_WIDTH_IDX = 23;

		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private const int MAX_HEIGHT_IDX = 11;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private const int MAX_DEPTH_IDX = 23;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly float3 VOXEL_RESOLUTION_F;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public static readonly uint3 VOXEL_RESOLUTION;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private static readonly uint3 LAST_IDX;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public static readonly float3 VOXEL_VOLUME_SIZE_F;

		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static readonly float3 VOXEL_VOLUME_HALF_SIZE_F;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x20B8BF0", Offset = "0x20B79F0", VA = "0x1820B8BF0")]
		public static uint PackIdx(uint x, uint y, uint z)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x20B9180", Offset = "0x20B7F80", VA = "0x1820B9180")]
		public static uint3 UnpackIdx(uint voxelIdx)
		{
			return default(uint3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x20B9430", Offset = "0x20B8230", VA = "0x1820B9430")]
		public static float3 VoxelPackedIdxToCenterPosition(uint packedIdx, float3 worldVolumeMinCorner, float3 worldVolumeMaxCorner)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x20B91F0", Offset = "0x20B7FF0", VA = "0x1820B91F0")]
		public static Vector3 VoxelPackedIdxToCenterPositionVector3(uint packedIdx, Vector3 worldVolumeMinCorner, Vector3 worldVolumeMaxCorner)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x20B8D80", Offset = "0x20B7B80", VA = "0x1820B8D80")]
		public static uint3 PositionToVoxelIdxUnpacked(float3 position, float3 worldVolumeMinCorner, float3 worldVolumeMaxCorner)
		{
			return default(uint3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x20B8C00", Offset = "0x20B7A00", VA = "0x1820B8C00")]
		public static Vector3 PositionToVoxelIdxUnpackedVector3(Vector3 position, Vector3 worldVolumeMin, Vector3 worldVolumeMax)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x20B8F50", Offset = "0x20B7D50", VA = "0x1820B8F50")]
		public static void SphereOverlap(float3 worldVolumeMin, float3 worldVolumeMax, float3 spherePosition, float radius, out uint3 minVoxelIndex, out uint3 maxVoxelIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x20B8570", Offset = "0x20B7370", VA = "0x1820B8570")]
		public static void ConeBoundingSphere(float3 coneOrigin, float3 coneDir, float range, float coneAngle, out float3 center, out float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x20B8A40", Offset = "0x20B7840", VA = "0x1820B8A40")]
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
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private LightBinningPass m_LightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private DepthOnlyPass m_DepthOnlyPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private MainLightShadowCasterPass m_MainLightShadowCasterPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private AdditionalLightsShadowCasterPass m_AdditionalLightsShadowCasterPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private SetupForwardRenderingPass m_SetupForwardRenderingPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private ScreenSpaceShadowResolvePass m_ScreenSpaceShadowResolvePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private CreateAgainstGravityRenderTexturesPass m_CreateAGRPRenderTexturesPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private BeginXRRenderingPass m_BeginXrRenderingPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private SetupAGRPConstantsPass m_SetupAGRPConstants;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private RenderOpaqueForwardPass m_RenderOpaqueForwardPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private CustomRenderEffectsPass m_customRenderEffectsPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private OpaquePostProcessPass m_OpaquePostProcessPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private DrawSkyboxPass m_DrawSkyboxPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private CopyDepthPass m_CopyDepthPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private CopyColorPass m_CopyColorPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private RenderTransparentForwardPass m_RenderTransparentForwardPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private MobileFadeEffectPass m_mobileFadeEffectPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private TransparentPostProcessPass m_TransparentPostProcessPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private FinalBlitPass m_FinalBlitPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private EndXRRenderingPass m_EndXrRenderingPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private RenderTargetHandle ColorAttachment;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private RenderTargetHandle DepthAttachment;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private RenderTargetHandle DepthTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private RenderTargetHandle OpaqueColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private RenderTargetHandle MainLightShadowmap;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private RenderTargetHandle AdditionalLightsShadowmap;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private RenderTargetHandle ScreenSpaceShadowmap;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private bool SupportsDepthTarget;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xCD")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private bool m_Initialized;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public ILightDataInterpreter LightInterpreter
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x325360", Offset = "0x324160", VA = "0x180325360", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x12FA910", Offset = "0x12F9710", VA = "0x1812FA910")]
		private void Init()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x12FAF70", Offset = "0x12F9D70", VA = "0x1812FAF70", Slot = "4")]
		public void PreCullSetup(ScriptableRenderer renderer, ScriptableRenderContext context, Camera camera, CameraData cameraData, ref LightData lightData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x12FAF80", Offset = "0x12F9D80", VA = "0x1812FAF80", Slot = "5")]
		public void Setup(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x12F9F60", Offset = "0x12F8D60", VA = "0x1812F9F60")]
		private bool CanCopyDepth(ref CameraData cameraData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x12FA840", Offset = "0x12F9640", VA = "0x1812FA840", Slot = "7")]
		public Light GetLight(ref LightData lightData, int lightIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x12FA4F0", Offset = "0x12F92F0", VA = "0x1812FA4F0", Slot = "8")]
		public AGRPLight GetAGRPLight(ref LightData lightData, int lightIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x12FA620", Offset = "0x12F9420", VA = "0x1812FA620", Slot = "9")]
		public int GetLightCount(ref LightData lightData)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x12FA670", Offset = "0x12F9470", VA = "0x1812FA670", Slot = "10")]
		public bool GetLightInfo(ref LightData lightData, int lightIdx, out Vector4 pos, out Vector4 dir, out Color finalColor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x12F9FA0", Offset = "0x12F8DA0", VA = "0x1812F9FA0", Slot = "11")]
		public int CopyToBinnableLights(ref LightData lightData, BinnableLight[] binnableLightBuffer, int maxLightCount)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x317C70", Offset = "0x316A70", VA = "0x180317C70")]
		public RendererSetupFullyFeatured()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class RendererSetupMobile : IRendererSetup, ILightDataInterpreter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private LightBinningPass lightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private SetupForwardRenderingPass setupForwardRenderingPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private CachedMainLightShadowCasterPass mainLightShadowCasterPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private CreateAgainstGravityRenderTexturesPass createAGRPRenderTexturesPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private BeginXRRenderingPass beginXrRenderingPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private SetupAGRPConstantsPass setupAGRPConstants;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private MobileVignetteEffectPass mobileVignetteEffectPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private RenderOpaqueForwardPass renderOpaqueForwardPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private CustomRenderEffectsPass customRenderEffectsPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private DrawSkyboxPass drawSkyboxPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private RenderTransparentForwardPass renderTransparentForwardPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private MobileFadeEffectPass mobileFadeEffectPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private EndXRRenderingPass endXrRenderingPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private RenderTargetHandle mainLightShadowmap;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private bool initialized;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public ILightDataInterpreter LightInterpreter
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x325360", Offset = "0x324160", VA = "0x180325360", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x12FBE70", Offset = "0x12FAC70", VA = "0x1812FBE70")]
		private void Init()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x12FC1F0", Offset = "0x12FAFF0", VA = "0x1812FC1F0", Slot = "4")]
		public void PreCullSetup(ScriptableRenderer renderer, ScriptableRenderContext context, Camera camera, CameraData cameraData, ref LightData lightData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x12FC400", Offset = "0x12FB200", VA = "0x1812FC400", Slot = "5")]
		public void Setup(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x12FBD90", Offset = "0x12FAB90", VA = "0x1812FBD90", Slot = "7")]
		public Light GetLight(ref LightData lightData, int lightIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x12FBAA0", Offset = "0x12FA8A0", VA = "0x1812FBAA0", Slot = "8")]
		public AGRPLight GetAGRPLight(ref LightData lightData, int lightIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x12FBBB0", Offset = "0x12FA9B0", VA = "0x1812FBBB0", Slot = "9")]
		public int GetLightCount(ref LightData lightData)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x12FBC00", Offset = "0x12FAA00", VA = "0x1812FBC00", Slot = "10")]
		public bool GetLightInfo(ref LightData lightData, int lightIdx, out Vector4 pos, out Vector4 dir, out Color finalColor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x12FB9E0", Offset = "0x12FA7E0", VA = "0x1812FB9E0", Slot = "11")]
		public int CopyToBinnableLights(ref LightData lightData, BinnableLight[] binnableLightBuffer, int maxLightCount)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x317C70", Offset = "0x316A70", VA = "0x180317C70")]
		public RendererSetupMobile()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal sealed class RendererSetupSimpleUIView : IRendererSetup
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private SetupForwardRenderingPass setupForwardRenderingPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private RenderOpaqueForwardPass renderOpaqueForwardPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private RenderTransparentForwardPass renderTransparentForwardPass;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private bool initialized;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public ILightDataInterpreter LightInterpreter
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x32ED30", Offset = "0x32DB30", VA = "0x18032ED30", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x20B4710", Offset = "0x20B3510", VA = "0x1820B4710")]
		private void Init()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x20B4710", Offset = "0x20B3510", VA = "0x1820B4710", Slot = "4")]
		public void PreCullSetup(ScriptableRenderer renderer, ScriptableRenderContext context, Camera camera, CameraData cameraData, ref LightData lightData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x20B47B0", Offset = "0x20B35B0", VA = "0x1820B47B0", Slot = "5")]
		public void Setup(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x317C70", Offset = "0x316A70", VA = "0x180317C70")]
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
			[Cpp2IlInjected.Token(Token = "0x400020E")]
			public static int _AdditionalLightsWorldToShadow;

			[Cpp2IlInjected.Token(Token = "0x400020F")]
			public static int _AdditionalShadowStrength;

			[Cpp2IlInjected.Token(Token = "0x4000210")]
			public static int _AdditionalShadowBias;

			[Cpp2IlInjected.Token(Token = "0x4000211")]
			public static int _AdditionalShadowOffset0;

			[Cpp2IlInjected.Token(Token = "0x4000212")]
			public static int _AdditionalShadowOffset1;

			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public static int _AdditionalShadowOffset2;

			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public static int _AdditionalShadowOffset3;

			[Cpp2IlInjected.Token(Token = "0x4000215")]
			public static int _AdditionalShadowmapSize;
		}

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private const int k_ShadowmapBufferBits = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private RenderTexture m_AdditionalLightsShadowmapTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private RenderTextureFormat m_AdditionalShadowmapFormat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private Matrix4x4[] m_AdditionalLightShadowMatrices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private ShadowSliceData[] m_AdditionalLightSlices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private float[] m_AdditionalLightsShadowStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private float[] m_AdditionalLightsShadowSampleBias;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private List<int> m_AdditionalShadowCastingLightIndices;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private const string k_RenderAdditionalLightShadows = "Render Additional Shadows";

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		private RenderTargetHandle destination
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x4B12F0", Offset = "0x4B00F0", VA = "0x1804B12F0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x4B1310", Offset = "0x4B0110", VA = "0x1804B1310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x12EAB10", Offset = "0x12E9910", VA = "0x1812EAB10")]
		public AdditionalLightsShadowCasterPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x12EA4D0", Offset = "0x12E92D0", VA = "0x1812EA4D0")]
		public bool Setup(RenderTargetHandle destination, ref RenderingData renderingData, int maxVisibleAdditionalLights)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x12E9740", Offset = "0x12E8540", VA = "0x1812E9740", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x12E9800", Offset = "0x12E8600", VA = "0x1812E9800", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x12E9540", Offset = "0x12E8340", VA = "0x1812E9540")]
		private void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x12E98C0", Offset = "0x12E86C0", VA = "0x1812E98C0")]
		private void RenderAdditionalShadowmapAtlas(ref ScriptableRenderContext context, ref CullResults cullResults, ref LightData lightData, ref ShadowData shadowData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x12EA030", Offset = "0x12E8E30", VA = "0x1812EA030")]
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
			[Cpp2IlInjected.Address(RVA = "0x12EEC40", Offset = "0x12EDA40", VA = "0x1812EEC40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x12EED30", Offset = "0x12EDB30", VA = "0x1812EED30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x12EEB60", Offset = "0x12ED960", VA = "0x1812EEB60", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x12EEC30", Offset = "0x12EDA30", VA = "0x1812EEC30")]
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
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			public static int _WorldToShadow;

			[Cpp2IlInjected.Token(Token = "0x4000217")]
			public static int _ShadowData;

			[Cpp2IlInjected.Token(Token = "0x4000218")]
			public static int _ShadowmapSize;
		}

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private static bool isDirty;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private static int shadowCasterLayerMask;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private const string PASS_TAG_NAME = "Render Cached Main Shadowmap";

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private const int SHADOW_MAP_BUFFER_BITS = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private RenderTexture shadowmapTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private RenderTextureFormat shadowmapFormat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private Matrix4x4[] shadowMatrices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private ShadowSliceData singleCascadeSlice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private Vector4 singleCascadeDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private Vector3 lastRenderCameraPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private bool isReusingCachedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private CullResults cullResults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private int mainLightIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private Light mainLight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private Vector4 shadowBias;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		private RenderTargetHandle destination
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xE3D800", Offset = "0xE3C600", VA = "0x180E3D800")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xE3DA40", Offset = "0xE3C840", VA = "0x180E3DA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x12F0C40", Offset = "0x12EFA40", VA = "0x1812F0C40")]
		public static void SetDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x12F0CA0", Offset = "0x12EFAA0", VA = "0x1812F0CA0")]
		public static void SetShadowCasterLayerMask(int layerMask)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x12F1450", Offset = "0x12F0250", VA = "0x1812F1450")]
		public CachedMainLightShadowCasterPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x12F0070", Offset = "0x12EEE70", VA = "0x1812F0070")]
		public void PreCullSetup(ref ScriptableRenderContext context, ref CameraData cameraData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x12F1060", Offset = "0x12EFE60", VA = "0x1812F1060")]
		public bool Setup(RenderTargetHandle destination, ref RenderingData renderingData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x12EFEE0", Offset = "0x12EECE0", VA = "0x1812EFEE0", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x12EFF80", Offset = "0x12EED80", VA = "0x1812EFF80", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x12EFDC0", Offset = "0x12EEBC0", VA = "0x1812EFDC0")]
		private void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x12EFFF0", Offset = "0x12EEDF0", VA = "0x1812EFFF0")]
		private Vector4 GetShadowBias(Vector4 biasSettings, Matrix4x4 lightProjectionMatrix, int shadowResolution)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x12F0760", Offset = "0x12EF560", VA = "0x1812F0760")]
		private void RenderMainLightCascadeShadowmap(ref ScriptableRenderContext context, ref ShadowData shadowData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x12F0D00", Offset = "0x12EFB00", VA = "0x1812F0D00")]
		private void SetupMainLightShadowReceiverConstants(CommandBuffer cmd, ref ShadowData shadowData, Light shadowLight, float sampleBias)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class CopyColorPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private const string k_CopyColorTag = "Copy Color";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private float[] m_OpaqueScalerValues;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int m_SampleOffsetShaderHandle;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		private RenderTargetHandle source
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x31F860", Offset = "0x31E660", VA = "0x18031F860")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x31F9A0", Offset = "0x31E7A0", VA = "0x18031F9A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		private RenderTargetHandle destination
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x40AA80", Offset = "0x409880", VA = "0x18040AA80")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x309AB0", Offset = "0x3088B0", VA = "0x180309AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x12F1BA0", Offset = "0x12F09A0", VA = "0x1812F1BA0")]
		public CopyColorPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x12F1B90", Offset = "0x12F0990", VA = "0x1812F1B90")]
		public void Setup(RenderTargetHandle source, RenderTargetHandle destination)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x12F1650", Offset = "0x12F0450", VA = "0x1812F1650", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x12F1A90", Offset = "0x12F0890", VA = "0x1812F1A90", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class CopyDepthPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private const string k_DepthCopyTag = "Copy Depth";

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		private RenderTargetHandle source
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x312B50", Offset = "0x311950", VA = "0x180312B50")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x321810", Offset = "0x320610", VA = "0x180321810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		private RenderTargetHandle destination
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x3215A0", Offset = "0x3203A0", VA = "0x1803215A0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x367820", Offset = "0x366620", VA = "0x180367820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x12F2300", Offset = "0x12F1100", VA = "0x1812F2300")]
		public void Setup(RenderTargetHandle source, RenderTargetHandle destination)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x12F1C20", Offset = "0x12F0A20", VA = "0x1812F1C20", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x12F2200", Offset = "0x12F1000", VA = "0x1812F2200", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x12EEC30", Offset = "0x12EDA30", VA = "0x1812EEC30")]
		public CopyDepthPass()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class CreateAgainstGravityRenderTexturesPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private const string k_CreateRenderTexturesTag = "Create Render Textures";

		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private const int k_DepthStencilBufferBits = 32;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		private RenderTargetHandle colorAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x312B50", Offset = "0x311950", VA = "0x180312B50")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x321810", Offset = "0x320610", VA = "0x180321810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		private RenderTargetHandle depthAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x3215A0", Offset = "0x3203A0", VA = "0x1803215A0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x367820", Offset = "0x366620", VA = "0x180367820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x12F27B0", Offset = "0x12F15B0", VA = "0x1812F27B0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x12F27E0", Offset = "0x12F15E0", VA = "0x1812F27E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		private SampleCount samples
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x4A9DA0", Offset = "0x4A8BA0", VA = "0x1804A9DA0")]
			[CompilerGenerated]
			get
			{
				return default(SampleCount);
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x4A9DF0", Offset = "0x4A8BF0", VA = "0x1804A9DF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x12F2780", Offset = "0x12F1580", VA = "0x1812F2780")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorAttachmentHandle, RenderTargetHandle depthAttachmentHandle, SampleCount samples)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x12F2310", Offset = "0x12F1110", VA = "0x1812F2310", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x12F2610", Offset = "0x12F1410", VA = "0x1812F2610", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x12EEC30", Offset = "0x12EDA30", VA = "0x1812EEC30")]
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
			[Cpp2IlInjected.Address(RVA = "0x3041E0", Offset = "0x302FE0", VA = "0x1803041E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x3030D0", Offset = "0x301ED0", VA = "0x1803030D0", Slot = "5")]
		public virtual void RenderPass(CommandBuffer commandBuffer, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x358D70", Offset = "0x357B70", VA = "0x180358D70")]
		protected CustomRenderEffect()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class CustomRenderEffectsPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private static readonly List<CustomRenderEffect> executeOnNextRenderEffects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private readonly List<CustomRenderEffect> renderEffectsBuffer;

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		private RenderTargetHandle colorAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x31F7E0", Offset = "0x31E5E0", VA = "0x18031F7E0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x31F990", Offset = "0x31E790", VA = "0x18031F990")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private RenderTargetHandle depthAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x31F860", Offset = "0x31E660", VA = "0x18031F860")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x31F9A0", Offset = "0x31E7A0", VA = "0x18031F9A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x12F3250", Offset = "0x12F2050", VA = "0x1812F3250")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x12F3280", Offset = "0x12F2080", VA = "0x1812F3280")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool RequiresOpaqueTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x12F30E0", Offset = "0x12F1EE0", VA = "0x1812F30E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x12F2800", Offset = "0x12F1600", VA = "0x1812F2800")]
		public static void EnqueueEffectForNextRender(CustomRenderEffect effect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x12F2EE0", Offset = "0x12F1CE0", VA = "0x1812F2EE0")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorHandle, RenderTargetHandle depthHandle, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x12F2B60", Offset = "0x12F1960", VA = "0x1812F2B60", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x12F2880", Offset = "0x12F1680", VA = "0x1812F2880")]
		private void ExecuteEffect(CustomRenderEffect renderEffect, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x12F3080", Offset = "0x12F1E80", VA = "0x1812F3080")]
		public CustomRenderEffectsPass()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class DepthOnlyPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private const string k_DepthPrepassTag = "Depth Prepass";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private int kDepthBufferBits;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private RenderTargetHandle depthAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x3215A0", Offset = "0x3203A0", VA = "0x1803215A0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x367820", Offset = "0x366620", VA = "0x180367820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		internal RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x12F27B0", Offset = "0x12F15B0", VA = "0x1812F27B0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x12F27E0", Offset = "0x12F15E0", VA = "0x1812F27E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		private FilterRenderersSettings opaqueFilterSettings
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x12F4100", Offset = "0x12F2F00", VA = "0x1812F4100")]
			[CompilerGenerated]
			get
			{
				return default(FilterRenderersSettings);
			}
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x12F4120", Offset = "0x12F2F20", VA = "0x1812F4120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x12F4060", Offset = "0x12F2E60", VA = "0x1812F4060")]
		public DepthOnlyPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x12F3FD0", Offset = "0x12F2DD0", VA = "0x1812F3FD0")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle depthAttachmentHandle, SampleCount samples)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x12F39F0", Offset = "0x12F27F0", VA = "0x1812F39F0", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x12F3ED0", Offset = "0x12F2CD0", VA = "0x1812F3ED0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x312B50", Offset = "0x311950", VA = "0x180312B50")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x321810", Offset = "0x320610", VA = "0x180321810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		private RenderTargetHandle depthAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x3215A0", Offset = "0x3203A0", VA = "0x1803215A0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x367820", Offset = "0x366620", VA = "0x180367820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x12F2300", Offset = "0x12F1100", VA = "0x1812F2300")]
		public void Setup(RenderTargetHandle colorHandle, RenderTargetHandle depthHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x12F4130", Offset = "0x12F2F30", VA = "0x1812F4130", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x12EEC30", Offset = "0x12EDA30", VA = "0x1812EEC30")]
		public DrawSkyboxPass()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class EndXRRenderingPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x12F44C0", Offset = "0x12F32C0", VA = "0x1812F44C0", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x12EEC30", Offset = "0x12EDA30", VA = "0x1812EEC30")]
		public EndXRRenderingPass()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class FinalBlitPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private const string k_FinalBlitTag = "Final Blit Pass";

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		private RenderTargetHandle colorAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x312B50", Offset = "0x311950", VA = "0x180312B50")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x321810", Offset = "0x320610", VA = "0x180321810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x12F4A00", Offset = "0x12F3800", VA = "0x1812F4A00")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x12F4A30", Offset = "0x12F3830", VA = "0x1812F4A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x12F49D0", Offset = "0x12F37D0", VA = "0x1812F49D0")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorAttachmentHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x12F4560", Offset = "0x12F3360", VA = "0x1812F4560", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x12EEC30", Offset = "0x12EDA30", VA = "0x1812EEC30")]
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
			[Cpp2IlInjected.Token(Token = "0x4000219")]
			public static readonly int VoxelBuffer;

			[Cpp2IlInjected.Token(Token = "0x400021A")]
			public static readonly int VoxelVolumeWorldOriginPreMultiplied;

			[Cpp2IlInjected.Token(Token = "0x400021B")]
			public static readonly int WorldSpaceToVoxelCoefficients;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private ComputeBuffer _VoxelBufferGPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private CalculateVoxelPoints _calculateVoxelPointsJob;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private BinPerLightJob _binPerLightJob;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private BinPerVoxelJob _binPerVoxelJob;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private NativeMultiHashMap<ushort, LightInBin> _lightBinBuffer0;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private NativeMultiHashMap<ushort, LightInBin> _lightBinBuffer1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private bool _frontBackSwitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private float3 voxelVolumeMinCorner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private float3 voxelVolumeMaxCorner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private NativeArray<uint> _voxelBufferCPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private NativeArray<float> _lightImportancesPerVoxel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private NativeArray<float3> _voxelPoints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private NativeArray<BinnableLight> _binnableLights;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private BinnableLight[] _binnableLightsBuffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private JobHandle _jobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private JobHandle _backBufferClearHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private ClearBufferJob<ushort, LightInBin> _clearBackBufferJob;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private bool _isCompleted;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		private NativeMultiHashMap<ushort, LightInBin> FrontBuffer
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x12F5A10", Offset = "0x12F4810", VA = "0x1812F5A10")]
			get
			{
				return default(NativeMultiHashMap<ushort, LightInBin>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		private NativeMultiHashMap<ushort, LightInBin> BackBuffer
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x12F59E0", Offset = "0x12F47E0", VA = "0x1812F59E0")]
			get
			{
				return default(NativeMultiHashMap<ushort, LightInBin>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x12F4FB0", Offset = "0x12F3DB0", VA = "0x1812F4FB0")]
		private void SetupPersistentBuffers(RenderFeaturesetOption featureset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x12F4F10", Offset = "0x12F3D10", VA = "0x1812F4F10")]
		private static void RunAtQuit(Action quitFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x1033B00", Offset = "0x1032900", VA = "0x181033B00")]
		private void ResizePersistentArray<T>(ref NativeArray<T> array, int size) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x12F5100", Offset = "0x12F3F00", VA = "0x1812F5100")]
		public JobHandle StartLightBin(CameraData cameraData, RenderFeaturesetOption featureset, ref LightData lightData)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x12F4AD0", Offset = "0x12F38D0", VA = "0x1812F4AD0")]
		private void CompleteFrameJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x12F4A50", Offset = "0x12F3850", VA = "0x1812F4A50")]
		private void CleanupFrameData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x12F4B00", Offset = "0x12F3900", VA = "0x1812F4B00", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x12EEC30", Offset = "0x12EDA30", VA = "0x1812EEC30")]
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
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			public static int _WorldToShadow;

			[Cpp2IlInjected.Token(Token = "0x400021F")]
			public static int _ShadowData;

			[Cpp2IlInjected.Token(Token = "0x4000220")]
			public static int _CascadeShadowSplitSpheres0;

			[Cpp2IlInjected.Token(Token = "0x4000221")]
			public static int _CascadeShadowSplitSpheres1;

			[Cpp2IlInjected.Token(Token = "0x4000222")]
			public static int _CascadeShadowSplitSpheres2;

			[Cpp2IlInjected.Token(Token = "0x4000223")]
			public static int _CascadeShadowSplitSpheres3;

			[Cpp2IlInjected.Token(Token = "0x4000224")]
			public static int _CascadeShadowSplitSphereRadii;

			[Cpp2IlInjected.Token(Token = "0x4000225")]
			public static int _ShadowOffset0;

			[Cpp2IlInjected.Token(Token = "0x4000226")]
			public static int _ShadowOffset1;

			[Cpp2IlInjected.Token(Token = "0x4000227")]
			public static int _ShadowOffset2;

			[Cpp2IlInjected.Token(Token = "0x4000228")]
			public static int _ShadowOffset3;

			[Cpp2IlInjected.Token(Token = "0x4000229")]
			public static int _ShadowmapSize;
		}

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private const int k_MaxCascades = 4;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private const int k_ShadowmapBufferBits = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private int m_ShadowCasterCascadesCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private RenderTexture m_MainLightShadowmapTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private RenderTextureFormat m_ShadowmapFormat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private Matrix4x4[] m_MainLightShadowMatrices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private ShadowSliceData[] m_CascadeSlices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private Vector4[] m_CascadeSplitDistances;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private const string k_RenderMainLightShadowmapTag = "Render Main Shadowmap";

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		private RenderTargetHandle destination
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x318790", Offset = "0x317590", VA = "0x180318790")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x3187E0", Offset = "0x3175E0", VA = "0x1803187E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x12F6F10", Offset = "0x12F5D10", VA = "0x1812F6F10")]
		public MainLightShadowCasterPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x12F6C70", Offset = "0x12F5A70", VA = "0x1812F6C70")]
		public bool Setup(RenderTargetHandle destination, ref RenderingData renderingData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x12F5C60", Offset = "0x12F4A60", VA = "0x1812F5C60", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x12F5D10", Offset = "0x12F4B10", VA = "0x1812F5D10", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x12F5A40", Offset = "0x12F4840", VA = "0x1812F5A40")]
		private void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x12F5DD0", Offset = "0x12F4BD0", VA = "0x1812F5DD0")]
		private void RenderMainLightCascadeShadowmap(ref ScriptableRenderContext context, ref CullResults cullResults, ref LightData lightData, ref ShadowData shadowData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x12F64B0", Offset = "0x12F52B0", VA = "0x1812F64B0")]
		private void SetupMainLightShadowReceiverConstants(CommandBuffer cmd, ref ShadowData shadowData, Light shadowLight, float sampleBias)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public abstract class MobileComfortEffectPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		protected const float QUAD_SCALE_FUDGE_FACTOR = 1.1f;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		protected const float QUAD_LEFT_X_OUTER = -0.5f;

		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		protected const float QUAD_RIGHT_X_OUTER = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		protected const float QUAD_BOTTOM_Y_OUTER = -0.5f;

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		protected const float QUAD_TOP_Y_OUTER = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		protected const float QUAD_LEFT_U_OUTER = 0f;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		protected const float QUAD_RIGHT_U_OUTER = 1f;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		protected const float QUAD_BOTTOM_V_OUTER = 0f;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		protected const float QUAD_TOP_V_OUTER = 1f;

		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private static Mesh _worldSpaceQuadMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private Material _effectMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		protected Shader effectShader;

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public static bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x12F7AE0", Offset = "0x12F68E0", VA = "0x1812F7AE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected static Mesh WorldSpaceQuadMesh
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x12F7B40", Offset = "0x12F6940", VA = "0x1812F7B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected Material EffectMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x12F79A0", Offset = "0x12F67A0", VA = "0x1812F79A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x12F76D0", Offset = "0x12F64D0", VA = "0x1812F76D0")]
		protected static Matrix4x4 GetWorldSpaceQuadTRSMatrix(Camera camera, bool scaleUniformly = false)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x12F7130", Offset = "0x12F5F30", VA = "0x1812F7130")]
		private static Mesh CreateWorldSpaceQuadMesh()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x12EEC30", Offset = "0x12EDA30", VA = "0x1812EEC30")]
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
			[Cpp2IlInjected.Token(Token = "0x400022A")]
			public float fadeEffect;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400022B")]
			public float monochromeReplacementEffect;
		}

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private static readonly int FADE_ID;

		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public static Settings CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private const string k_PostProcessingTag = "Render Mobile Fade Effect";

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x12F8070", Offset = "0x12F6E70", VA = "0x1812F8070")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x12F7F30", Offset = "0x12F6D30", VA = "0x1812F7F30")]
		public bool Setup(Shader effectShader)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x12F7C30", Offset = "0x12F6A30", VA = "0x1812F7C30", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x12F8010", Offset = "0x12F6E10", VA = "0x1812F8010")]
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
			[Cpp2IlInjected.Token(Token = "0x400022C")]
			public float vignettePowerNormalized;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400022D")]
			public Color vignetteColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400022E")]
			public Mesh vignetteMesh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400022F")]
			public AnimationCurve vignetteIntensityCurve;
		}

		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private static readonly int POWER_ID;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static readonly int COLOR_ID;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public static Settings CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private const string k_PostProcessingTag = "Render Mobile Vignette Effect";

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		private RenderTargetHandle colorAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x40AA80", Offset = "0x409880", VA = "0x18040AA80")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x309AB0", Offset = "0x3088B0", VA = "0x180309AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		private RenderTargetHandle depthAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x326D10", Offset = "0x325B10", VA = "0x180326D10")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x309AC0", Offset = "0x3088C0", VA = "0x180309AC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x12F87E0", Offset = "0x12F75E0", VA = "0x1812F87E0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x12F8820", Offset = "0x12F7620", VA = "0x1812F8820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		private ClearFlag clearFlag
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x578160", Offset = "0x576F60", VA = "0x180578160")]
			[CompilerGenerated]
			get
			{
				return default(ClearFlag);
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x1061390", Offset = "0x1060190", VA = "0x181061390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		private Color clearColor
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x12F87D0", Offset = "0x12F75D0", VA = "0x1812F87D0")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x12F8810", Offset = "0x12F7610", VA = "0x1812F8810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x12F8560", Offset = "0x12F7360", VA = "0x1812F8560")]
		public bool Setup(Shader effectShader, RenderTextureDescriptor descriptor, RenderTargetHandle colorAttachmentHandle, RenderTargetHandle depthAttachmentHandle, ClearFlag clearFlag, Color clearColor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x12F8120", Offset = "0x12F6F20", VA = "0x1812F8120", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x12F8770", Offset = "0x12F7570", VA = "0x1812F8770")]
		public MobileVignetteEffectPass()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class OpaquePostProcessPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private const string k_OpaquePostProcessTag = "Render Opaque PostProcess Effects";

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		private RenderTargetHandle colorAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x312B50", Offset = "0x311950", VA = "0x180312B50")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x321810", Offset = "0x320610", VA = "0x180321810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x12F4A00", Offset = "0x12F3800", VA = "0x1812F4A00")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x12F4A30", Offset = "0x12F3830", VA = "0x1812F4A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x12F49D0", Offset = "0x12F37D0", VA = "0x1812F49D0")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorAttachmentHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x12F8840", Offset = "0x12F7640", VA = "0x1812F8840", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x12EEC30", Offset = "0x12EDA30", VA = "0x1812EEC30")]
		public OpaquePostProcessPass()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class RenderOpaqueForwardPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private const string k_RenderOpaquesTag = "Render Opaques";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private FilterRenderersSettings m_OpaqueFilterSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private RendererConfiguration rendererConfiguration;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		private RenderTargetHandle colorAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x326D10", Offset = "0x325B10", VA = "0x180326D10")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x309AC0", Offset = "0x3088C0", VA = "0x180309AC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		private RenderTargetHandle depthAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x339320", Offset = "0x338120", VA = "0x180339320")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x39D160", Offset = "0x39BF60", VA = "0x18039D160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x12F98E0", Offset = "0x12F86E0", VA = "0x1812F98E0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x12F9920", Offset = "0x12F8720", VA = "0x1812F9920")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		private ClearFlag clearFlag
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x582DD0", Offset = "0x581BD0", VA = "0x180582DD0")]
			[CompilerGenerated]
			get
			{
				return default(ClearFlag);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x7B3930", Offset = "0x7B2730", VA = "0x1807B3930")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		private Color clearColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x12F98D0", Offset = "0x12F86D0", VA = "0x1812F98D0")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x12F9910", Offset = "0x12F8710", VA = "0x1812F9910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x12F9830", Offset = "0x12F8630", VA = "0x1812F9830")]
		public RenderOpaqueForwardPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x12F9760", Offset = "0x12F8560", VA = "0x1812F9760")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorAttachmentHandle, RenderTargetHandle depthAttachmentHandle, ClearFlag clearFlag, Color clearColor, RendererConfiguration configuration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x12F9240", Offset = "0x12F8040", VA = "0x1812F9240", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class RenderTransparentForwardPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private const string k_RenderTransparentsTag = "Render Transparents";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private FilterRenderersSettings m_TransparentFilterSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private RendererConfiguration rendererConfiguration;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		private RenderTargetHandle colorAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x326D10", Offset = "0x325B10", VA = "0x180326D10")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x309AC0", Offset = "0x3088C0", VA = "0x180309AC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		private RenderTargetHandle depthAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x339320", Offset = "0x338120", VA = "0x180339320")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x39D160", Offset = "0x39BF60", VA = "0x18039D160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x12F98E0", Offset = "0x12F86E0", VA = "0x1812F98E0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x12F9920", Offset = "0x12F8720", VA = "0x1812F9920")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x12F9EB0", Offset = "0x12F8CB0", VA = "0x1812F9EB0")]
		public RenderTransparentForwardPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x12F9E80", Offset = "0x12F8C80", VA = "0x1812F9E80")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorAttachmentHandle, RenderTargetHandle depthAttachmentHandle, RendererConfiguration configuration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x12F9980", Offset = "0x12F8780", VA = "0x1812F9980", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class SceneViewDepthCopyPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private const string k_CopyDepthToCameraTag = "Copy Depth to Camera";

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		private RenderTargetHandle source
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x312B50", Offset = "0x311950", VA = "0x180312B50")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x321810", Offset = "0x320610", VA = "0x180321810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x321810", Offset = "0x320610", VA = "0x180321810")]
		public void Setup(RenderTargetHandle source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x12FCAC0", Offset = "0x12FB8C0", VA = "0x1812FCAC0", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x12EEC30", Offset = "0x12EDA30", VA = "0x1812EEC30")]
		public SceneViewDepthCopyPass()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class ScreenSpaceShadowResolvePass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private const string k_CollectShadowsTag = "Collect Shadows";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private RenderTextureFormat m_ColorFormat;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		private RenderTargetHandle colorAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x3215A0", Offset = "0x3203A0", VA = "0x1803215A0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x367820", Offset = "0x366620", VA = "0x180367820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x12F27B0", Offset = "0x12F15B0", VA = "0x1812F27B0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x12F27E0", Offset = "0x12F15E0", VA = "0x1812F27E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x12FD290", Offset = "0x12FC090", VA = "0x1812FD290")]
		public ScreenSpaceShadowResolvePass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x12FD230", Offset = "0x12FC030", VA = "0x1812FD230")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorAttachmentHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x12FCE10", Offset = "0x12FBC10", VA = "0x1812FCE10", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x12FD130", Offset = "0x12FBF30", VA = "0x1812FD130", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public abstract class ScriptableRenderPass
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private List<ShaderPassName> m_ShaderPassNames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public readonly string PassName;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x12FD870", Offset = "0x12FC670", VA = "0x1812FD870")]
		public ScriptableRenderPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3030D0", Offset = "0x301ED0", VA = "0x1803030D0", Slot = "4")]
		public virtual void FrameCleanup(CommandBuffer cmd)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData);

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x12FD4A0", Offset = "0x12FC2A0", VA = "0x1812FD4A0")]
		protected void RegisterShaderPassName(string passName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x12FD2D0", Offset = "0x12FC0D0", VA = "0x1812FD2D0")]
		protected DrawRendererSettings CreateDrawRendererSettings(Camera camera, SortFlags sortFlags, RendererConfiguration rendererConfiguration, bool supportsDynamicBatching)
		{
			return default(DrawRendererSettings);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x12FD520", Offset = "0x12FC320", VA = "0x1812FD520")]
		protected static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorAttachment, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, ClearFlag clearFlags, Color clearColor, TextureDimension dimension)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x12FD680", Offset = "0x12FC480", VA = "0x1812FD680")]
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
			[Cpp2IlInjected.Token(Token = "0x4000230")]
			public static readonly int MainLightPosition;

			[Cpp2IlInjected.Token(Token = "0x4000231")]
			public static readonly int MainLightColor;

			[Cpp2IlInjected.Token(Token = "0x4000232")]
			public static readonly int AdditionalLightsCount;

			[Cpp2IlInjected.Token(Token = "0x4000233")]
			public static readonly int AdditionalLightsPosition;

			[Cpp2IlInjected.Token(Token = "0x4000234")]
			public static readonly int AdditionalLightsColor;

			[Cpp2IlInjected.Token(Token = "0x4000235")]
			public static readonly int AdditionalLightsAttenuation;

			[Cpp2IlInjected.Token(Token = "0x4000236")]
			public static readonly int AdditionalLightsSpotDir;
		}

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private const string k_SetupLightConstants = "Setup Light Constants";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private MixedLightingSetup m_MixedLightingSetup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private Vector4 k_DefaultLightPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private Vector4 k_DefaultLightColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private Vector4 k_DefaultLightAttenuation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private Vector4 k_DefaultLightSpotDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private Vector4[] m_AdditionalLightPositions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private Vector4[] m_AdditionalLightColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private Vector4[] m_AdditionalLightAttenuations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private Vector4[] m_AdditionalLightSpotDirections;

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x12FDC90", Offset = "0x12FCA90", VA = "0x1812FDC90")]
		private void InitializeLightConstants(ref LightData lightData, int lightIndex, out Vector4 lightPos, out Vector4 lightColor, out Vector4 lightAttenuation, out Vector4 lightSpotDir)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x12FE7B0", Offset = "0x12FD5B0", VA = "0x1812FE7B0")]
		private void SetupShaderLightConstants(CommandBuffer cmd, ScriptableRenderer renderer, ref LightData lightData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x12FE680", Offset = "0x12FD480", VA = "0x1812FE680")]
		private void SetupMainLightConstants(CommandBuffer cmd, ref LightData lightData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x12FE1C0", Offset = "0x12FCFC0", VA = "0x1812FE1C0")]
		private void SetupAdditionalLightConstants(CommandBuffer cmd, int maxLightCount, ref LightData lightData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x12FD900", Offset = "0x12FC700", VA = "0x1812FD900", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x12FE910", Offset = "0x12FD710", VA = "0x1812FE910")]
		public SetupAGRPConstantsPass()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class SetupForwardRenderingPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x12FEA30", Offset = "0x12FD830", VA = "0x1812FEA30", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x12EEC30", Offset = "0x12EDA30", VA = "0x1812EEC30")]
		public SetupForwardRenderingPass()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class TransparentPostProcessPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private const string k_PostProcessingTag = "Render PostProcess Effects";

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		private RenderTargetHandle colorAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x312B50", Offset = "0x311950", VA = "0x180312B50")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x321810", Offset = "0x320610", VA = "0x180321810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x12F4A00", Offset = "0x12F3800", VA = "0x1812F4A00")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x12F4A30", Offset = "0x12F3830", VA = "0x1812F4A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		private RenderTargetIdentifier destination
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x12FEE70", Offset = "0x12FDC70", VA = "0x1812FEE70")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetIdentifier);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x12FEE90", Offset = "0x12FDC90", VA = "0x1812FEE90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x12FEE30", Offset = "0x12FDC30", VA = "0x1812FEE30")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorAttachmentHandle, RenderTargetIdentifier destination)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x12FEC40", Offset = "0x12FDA40", VA = "0x1812FEC40", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x12EEC30", Offset = "0x12EDA30", VA = "0x1812EEC30")]
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
