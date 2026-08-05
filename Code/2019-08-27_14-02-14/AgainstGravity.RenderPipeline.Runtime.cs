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
				[Cpp2IlInjected.Address(RVA = "0x1215B0", Offset = "0x1209B0", VA = "0x1801215B0")]
				[CompilerGenerated]
				get
				{
					return default(DepthTextureRenderMode);
				}
				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0x1215C0", Offset = "0x1209C0", VA = "0x1801215C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public bool supportsCameraOpaqueTexture
			{
				[Cpp2IlInjected.Token(Token = "0x60001CC")]
				[Cpp2IlInjected.Address(RVA = "0x17A660", Offset = "0x179A60", VA = "0x18017A660")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001CD")]
				[Cpp2IlInjected.Address(RVA = "0x1B3920", Offset = "0x1B2D20", VA = "0x1801B3920")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public Downsampling opaqueDownsampling
			{
				[Cpp2IlInjected.Token(Token = "0x60001CE")]
				[Cpp2IlInjected.Address(RVA = "0x107010", Offset = "0x106410", VA = "0x180107010")]
				[CompilerGenerated]
				get
				{
					return default(Downsampling);
				}
				[Cpp2IlInjected.Token(Token = "0x60001CF")]
				[Cpp2IlInjected.Address(RVA = "0x19A900", Offset = "0x199D00", VA = "0x18019A900")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public bool supportsHDR
			{
				[Cpp2IlInjected.Token(Token = "0x60001D0")]
				[Cpp2IlInjected.Address(RVA = "0x1B37E0", Offset = "0x1B2BE0", VA = "0x1801B37E0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001D1")]
				[Cpp2IlInjected.Address(RVA = "0x1B3940", Offset = "0x1B2D40", VA = "0x1801B3940")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public int msaaSampleCount
			{
				[Cpp2IlInjected.Token(Token = "0x60001D2")]
				[Cpp2IlInjected.Address(RVA = "0x106860", Offset = "0x105C60", VA = "0x180106860")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60001D3")]
				[Cpp2IlInjected.Address(RVA = "0x19A8E0", Offset = "0x199CE0", VA = "0x18019A8E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000084")]
			public float renderScale
			{
				[Cpp2IlInjected.Token(Token = "0x60001D4")]
				[Cpp2IlInjected.Address(RVA = "0x1114E0", Offset = "0x1108E0", VA = "0x1801114E0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001D5")]
				[Cpp2IlInjected.Address(RVA = "0x111510", Offset = "0x110910", VA = "0x180111510")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000085")]
			public LightRenderingMode mainLightRenderingMode
			{
				[Cpp2IlInjected.Token(Token = "0x60001D6")]
				[Cpp2IlInjected.Address(RVA = "0x1799F0", Offset = "0x178DF0", VA = "0x1801799F0")]
				[CompilerGenerated]
				get
				{
					return default(LightRenderingMode);
				}
				[Cpp2IlInjected.Token(Token = "0x60001D7")]
				[Cpp2IlInjected.Address(RVA = "0x1B3890", Offset = "0x1B2C90", VA = "0x1801B3890")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000086")]
			public bool supportsMainLightShadows
			{
				[Cpp2IlInjected.Token(Token = "0x60001D8")]
				[Cpp2IlInjected.Address(RVA = "0x1B37F0", Offset = "0x1B2BF0", VA = "0x1801B37F0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001D9")]
				[Cpp2IlInjected.Address(RVA = "0x1B3950", Offset = "0x1B2D50", VA = "0x1801B3950")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public int mainLightShadowmapResolution
			{
				[Cpp2IlInjected.Token(Token = "0x60001DA")]
				[Cpp2IlInjected.Address(RVA = "0x11CD70", Offset = "0x11C170", VA = "0x18011CD70")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60001DB")]
				[Cpp2IlInjected.Address(RVA = "0x19A910", Offset = "0x199D10", VA = "0x18019A910")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			public LightRenderingMode additionalLightsRenderingMode
			{
				[Cpp2IlInjected.Token(Token = "0x60001DC")]
				[Cpp2IlInjected.Address(RVA = "0x12E700", Offset = "0x12DB00", VA = "0x18012E700")]
				[CompilerGenerated]
				get
				{
					return default(LightRenderingMode);
				}
				[Cpp2IlInjected.Token(Token = "0x60001DD")]
				[Cpp2IlInjected.Address(RVA = "0x19A8F0", Offset = "0x199CF0", VA = "0x18019A8F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000089")]
			public int maxAdditionalLights
			{
				[Cpp2IlInjected.Token(Token = "0x60001DE")]
				[Cpp2IlInjected.Address(RVA = "0x18A190", Offset = "0x189590", VA = "0x18018A190")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60001DF")]
				[Cpp2IlInjected.Address(RVA = "0x18A1E0", Offset = "0x1895E0", VA = "0x18018A1E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			public bool supportsAdditionalLightShadows
			{
				[Cpp2IlInjected.Token(Token = "0x60001E0")]
				[Cpp2IlInjected.Address(RVA = "0x1B37C0", Offset = "0x1B2BC0", VA = "0x1801B37C0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001E1")]
				[Cpp2IlInjected.Address(RVA = "0x1B3910", Offset = "0x1B2D10", VA = "0x1801B3910")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			public int additionalLightsShadowmapResolution
			{
				[Cpp2IlInjected.Token(Token = "0x60001E2")]
				[Cpp2IlInjected.Address(RVA = "0x1AAAE0", Offset = "0x1A9EE0", VA = "0x1801AAAE0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60001E3")]
				[Cpp2IlInjected.Address(RVA = "0x1B3850", Offset = "0x1B2C50", VA = "0x1801B3850")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			public float shadowDistance
			{
				[Cpp2IlInjected.Token(Token = "0x60001E4")]
				[Cpp2IlInjected.Address(RVA = "0x1B37B0", Offset = "0x1B2BB0", VA = "0x1801B37B0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001E5")]
				[Cpp2IlInjected.Address(RVA = "0x1B3900", Offset = "0x1B2D00", VA = "0x1801B3900")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public int cascadeCount
			{
				[Cpp2IlInjected.Token(Token = "0x60001E6")]
				[Cpp2IlInjected.Address(RVA = "0x1B3740", Offset = "0x1B2B40", VA = "0x1801B3740")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60001E7")]
				[Cpp2IlInjected.Address(RVA = "0x1B3880", Offset = "0x1B2C80", VA = "0x1801B3880")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public float cascade2Split
			{
				[Cpp2IlInjected.Token(Token = "0x60001E8")]
				[Cpp2IlInjected.Address(RVA = "0x1B3710", Offset = "0x1B2B10", VA = "0x1801B3710")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001E9")]
				[Cpp2IlInjected.Address(RVA = "0x1B3860", Offset = "0x1B2C60", VA = "0x1801B3860")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public Vector3 cascade4Split
			{
				[Cpp2IlInjected.Token(Token = "0x60001EA")]
				[Cpp2IlInjected.Address(RVA = "0x1B3720", Offset = "0x1B2B20", VA = "0x1801B3720")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x60001EB")]
				[Cpp2IlInjected.Address(RVA = "0x1B3870", Offset = "0x1B2C70", VA = "0x1801B3870")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public float mainLightShadowDepthBias
			{
				[Cpp2IlInjected.Token(Token = "0x60001EC")]
				[Cpp2IlInjected.Address(RVA = "0x1B3750", Offset = "0x1B2B50", VA = "0x1801B3750")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001ED")]
				[Cpp2IlInjected.Address(RVA = "0x1B38A0", Offset = "0x1B2CA0", VA = "0x1801B38A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public float mainLightShadowNormalBias
			{
				[Cpp2IlInjected.Token(Token = "0x60001EE")]
				[Cpp2IlInjected.Address(RVA = "0x1B3760", Offset = "0x1B2B60", VA = "0x1801B3760")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001EF")]
				[Cpp2IlInjected.Address(RVA = "0x1B38B0", Offset = "0x1B2CB0", VA = "0x1801B38B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public float mainLightShadowSampleBias
			{
				[Cpp2IlInjected.Token(Token = "0x60001F0")]
				[Cpp2IlInjected.Address(RVA = "0x1B3770", Offset = "0x1B2B70", VA = "0x1801B3770")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001F1")]
				[Cpp2IlInjected.Address(RVA = "0x1B38C0", Offset = "0x1B2CC0", VA = "0x1801B38C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public float additionalLightShadowDepthBias
			{
				[Cpp2IlInjected.Token(Token = "0x60001F2")]
				[Cpp2IlInjected.Address(RVA = "0x1B36E0", Offset = "0x1B2AE0", VA = "0x1801B36E0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001F3")]
				[Cpp2IlInjected.Address(RVA = "0x1B3820", Offset = "0x1B2C20", VA = "0x1801B3820")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public float additionalLightShadowNormalBias
			{
				[Cpp2IlInjected.Token(Token = "0x60001F4")]
				[Cpp2IlInjected.Address(RVA = "0x1B36F0", Offset = "0x1B2AF0", VA = "0x1801B36F0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001F5")]
				[Cpp2IlInjected.Address(RVA = "0x1B3830", Offset = "0x1B2C30", VA = "0x1801B3830")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public float additionalLightShadowSampleBias
			{
				[Cpp2IlInjected.Token(Token = "0x60001F6")]
				[Cpp2IlInjected.Address(RVA = "0x1B3700", Offset = "0x1B2B00", VA = "0x1801B3700")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001F7")]
				[Cpp2IlInjected.Address(RVA = "0x1B3840", Offset = "0x1B2C40", VA = "0x1801B3840")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public bool supportsSoftShadows
			{
				[Cpp2IlInjected.Token(Token = "0x60001F8")]
				[Cpp2IlInjected.Address(RVA = "0x1B3800", Offset = "0x1B2C00", VA = "0x1801B3800")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001F9")]
				[Cpp2IlInjected.Address(RVA = "0x1B3960", Offset = "0x1B2D60", VA = "0x1801B3960")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public bool supportsDynamicBatching
			{
				[Cpp2IlInjected.Token(Token = "0x60001FA")]
				[Cpp2IlInjected.Address(RVA = "0x1B37D0", Offset = "0x1B2BD0", VA = "0x1801B37D0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001FB")]
				[Cpp2IlInjected.Address(RVA = "0x1B3930", Offset = "0x1B2D30", VA = "0x1801B3930")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public bool mixedLightingSupported
			{
				[Cpp2IlInjected.Token(Token = "0x60001FC")]
				[Cpp2IlInjected.Address(RVA = "0x1B3780", Offset = "0x1B2B80", VA = "0x1801B3780")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001FD")]
				[Cpp2IlInjected.Address(RVA = "0x1B38D0", Offset = "0x1B2CD0", VA = "0x1801B38D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public bool supportsUGCMeshLODs
			{
				[Cpp2IlInjected.Token(Token = "0x60001FE")]
				[Cpp2IlInjected.Address(RVA = "0x1B3810", Offset = "0x1B2C10", VA = "0x1801B3810")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001FF")]
				[Cpp2IlInjected.Address(RVA = "0x1B3970", Offset = "0x1B2D70", VA = "0x1801B3970")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public RenderFeaturesetOption renderFeatureset
			{
				[Cpp2IlInjected.Token(Token = "0x6000200")]
				[Cpp2IlInjected.Address(RVA = "0x1B37A0", Offset = "0x1B2BA0", VA = "0x1801B37A0")]
				[CompilerGenerated]
				get
				{
					return default(RenderFeaturesetOption);
				}
				[Cpp2IlInjected.Token(Token = "0x6000201")]
				[Cpp2IlInjected.Address(RVA = "0x1B38F0", Offset = "0x1B2CF0", VA = "0x1801B38F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			public PostProcessingOption postProcessing
			{
				[Cpp2IlInjected.Token(Token = "0x6000202")]
				[Cpp2IlInjected.Address(RVA = "0x1B3790", Offset = "0x1B2B90", VA = "0x1801B3790")]
				[CompilerGenerated]
				get
				{
					return default(PostProcessingOption);
				}
				[Cpp2IlInjected.Token(Token = "0x6000203")]
				[Cpp2IlInjected.Address(RVA = "0x1B38E0", Offset = "0x1B2CE0", VA = "0x1801B38E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x127DFE0", Offset = "0x127C9E0", VA = "0x18127DFE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1B3620", Offset = "0x1B2A20", VA = "0x1801B3620")]
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
			[Cpp2IlInjected.Address(RVA = "0x1273CF0", Offset = "0x12726F0", VA = "0x181273CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public ScriptableRenderer renderer
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x362F80", Offset = "0x361980", VA = "0x180362F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x364D00", Offset = "0x363700", VA = "0x180364D00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private PipelineSettings settings
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1273DE0", Offset = "0x12727E0", VA = "0x181273DE0")]
			[CompilerGenerated]
			get
			{
				return default(PipelineSettings);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x1274030", Offset = "0x1272A30", VA = "0x181274030")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public static event RenderCallback BeforeCameraRenderEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x1273BF0", Offset = "0x12725F0", VA = "0x181273BF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x1273F30", Offset = "0x1272930", VA = "0x181273F30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public static event RenderCallback AfterCameraRenderEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x1273AF0", Offset = "0x12724F0", VA = "0x181273AF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x1273E30", Offset = "0x1272830", VA = "0x181273E30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x12737B0", Offset = "0x12721B0", VA = "0x1812737B0")]
		public AgainstGravityRenderPipeline(AgainstGravityRenderPipelineAsset asset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x12707E0", Offset = "0x126F1E0", VA = "0x1812707E0", Slot = "8")]
		public sealed override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1272570", Offset = "0x1270F70", VA = "0x181272570", Slot = "7")]
		public override void Render(ScriptableRenderContext renderContext, Camera[] cameras)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1271C60", Offset = "0x1270660", VA = "0x181271C60")]
		public static void RenderSingleCamera(AgainstGravityRenderPipeline pipelineInstance, ScriptableRenderContext context, Camera camera, ref CullResults cullResults, AGRPAdditionalCameraData additionalCameraData, [Optional] IRendererSetup setup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x306320", Offset = "0x304D20", VA = "0x180306320")]
		private static void SetSupportedRenderingFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1270960", Offset = "0x126F360", VA = "0x181270960")]
		private static void InitializeCameraData(PipelineSettings settings, Camera camera, AGRPAdditionalCameraData additionalCameraData, out CameraData cameraData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x12710D0", Offset = "0x126FAD0", VA = "0x1812710D0")]
		private static void InitializeRenderingData(PipelineSettings settings, ref CameraData cameraData, ref CullResults cullResults, int maxVisibleAdditionalLights, int maxPerObjectAdditionalLights, ILightDataInterpreter lightInterpreter, out RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1271670", Offset = "0x1270070", VA = "0x181271670")]
		private static void InitializeShadowData(PipelineSettings settings, ref LightData lightData, bool mainLightCastShadows, bool additionalLightsCastShadows, out ShadowData shadowData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1270F90", Offset = "0x126F990", VA = "0x181270F90")]
		private static void InitializeLightData(PipelineSettings settings, int lightCount, int mainLightIndex, int maxAdditionalLights, int maxPerObjectAdditionalLights, ref LightData lightData, ref CameraData cameraData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1270890", Offset = "0x126F290", VA = "0x181270890")]
		private static int GetMainLight(LightRenderingMode mode, ref LightData lightData)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x12733D0", Offset = "0x1271DD0", VA = "0x1812733D0")]
		private static void SetupPerFrameShaderConstants()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1273070", Offset = "0x1271A70", VA = "0x181273070")]
		private static void SetupPerCameraShaderConstants(CameraData cameraData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1271B80", Offset = "0x1270580", VA = "0x181271B80")]
		public static bool IsStereoEnabled(Camera camera)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x12735F0", Offset = "0x1271FF0", VA = "0x1812735F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x399970", Offset = "0x398370", VA = "0x180399970")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool renderShadows
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x3355F0", Offset = "0x333FF0", VA = "0x1803355F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x3356B0", Offset = "0x3340B0", VA = "0x1803356B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool disableAdditionalLights
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x361350", Offset = "0x35FD50", VA = "0x180361350")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x361360", Offset = "0x35FD60", VA = "0x180361360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool isMainCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x712280", Offset = "0x710C80", VA = "0x180712280")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x425A20", Offset = "0x424420", VA = "0x180425A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool forceRenderMirrors
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6BF730", Offset = "0x6BE130", VA = "0x1806BF730")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x914A00", Offset = "0x913400", VA = "0x180914A00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public CameraOverrideOption requiresColorOption
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x393770", Offset = "0x392170", VA = "0x180393770")]
			get
			{
				return default(CameraOverrideOption);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x393790", Offset = "0x392190", VA = "0x180393790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool IsSimpleUIViewCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x399960", Offset = "0x398360", VA = "0x180399960")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6044B0", Offset = "0x602EB0", VA = "0x1806044B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool requiresColorTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x126DE70", Offset = "0x126C870", VA = "0x18126DE70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x126DF50", Offset = "0x126C950", VA = "0x18126DF50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x306320", Offset = "0x304D20", VA = "0x180306320", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x126DE30", Offset = "0x126C830", VA = "0x18126DE30", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x126DE50", Offset = "0x126C850", VA = "0x18126DE50")]
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
			[Cpp2IlInjected.Address(RVA = "0x3355F0", Offset = "0x333FF0", VA = "0x1803355F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x3356B0", Offset = "0x3340B0", VA = "0x1803356B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public float shadowSampleBias
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x399950", Offset = "0x398350", VA = "0x180399950")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8749E0", Offset = "0x8733E0", VA = "0x1808749E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x485D60", Offset = "0x484760", VA = "0x180485D60")]
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
		[Cpp2IlInjected.Address(RVA = "0x126DF70", Offset = "0x126C970", VA = "0x18126DF70")]
		public static int GetFixedVoxelSize(RenderFeaturesetOption renderFeatureSet)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x126DF80", Offset = "0x126C980", VA = "0x18126DF80")]
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
			[Cpp2IlInjected.Address(RVA = "0x315A10", Offset = "0x314410", VA = "0x180315A10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x33A080", Offset = "0x338A80", VA = "0x18033A080")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x126E4D0", Offset = "0x126CED0", VA = "0x18126E4D0")]
		public static void UpdateBinnableLights()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x126DFF0", Offset = "0x126C9F0", VA = "0x18126DFF0")]
		public static List<BinnableLight> GetCurrentBinnableLights()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x126DF90", Offset = "0x126C990", VA = "0x18126DF90")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x126E210", Offset = "0x126CC10", VA = "0x18126E210")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x126E050", Offset = "0x126CA50", VA = "0x18126E050")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x126E450", Offset = "0x126CE50", VA = "0x18126E450")]
		private static void TrackLight(AGRPLight light)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x126E2D0", Offset = "0x126CCD0", VA = "0x18126E2D0")]
		private static void StopTrackingLight(AGRPLight light)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x126EA20", Offset = "0x126D420", VA = "0x18126EA20")]
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
			[Cpp2IlInjected.Address(RVA = "0x34E580", Offset = "0x34CF80", VA = "0x18034E580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public DepthTextureRenderMode depthTextureMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x349840", Offset = "0x348240", VA = "0x180349840")]
			get
			{
				return default(DepthTextureRenderMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public PostProcessingOption postProcessing
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x491E30", Offset = "0x490830", VA = "0x180491E30")]
			get
			{
				return default(PostProcessingOption);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool supportsCameraOpaqueTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x3D3FE0", Offset = "0x3D29E0", VA = "0x1803D3FE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public RenderFeaturesetOption renderFeatureset
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x4CBE00", Offset = "0x4CA800", VA = "0x1804CBE00")]
			get
			{
				return default(RenderFeaturesetOption);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Downsampling opaqueDownsampling
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x68C580", Offset = "0x68AF80", VA = "0x18068C580")]
			get
			{
				return default(Downsampling);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool supportsHDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6760B0", Offset = "0x674AB0", VA = "0x1806760B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int msaaSampleCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3959E0", Offset = "0x3943E0", VA = "0x1803959E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float renderScale
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x527760", Offset = "0x526160", VA = "0x180527760")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool supportsUGCMeshLODs
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x3CEC70", Offset = "0x3CD670", VA = "0x1803CEC70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public LightRenderingMode mainLightRenderingMode
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x48B190", Offset = "0x489B90", VA = "0x18048B190")]
			get
			{
				return default(LightRenderingMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool supportsMainLightShadows
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5DE6C0", Offset = "0x5DD0C0", VA = "0x1805DE6C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ShadowResolution mainLightShadowmapResolution
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x52C970", Offset = "0x52B370", VA = "0x18052C970")]
			get
			{
				return default(ShadowResolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public LightRenderingMode additionalLightsRenderingMode
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x57FC10", Offset = "0x57E610", VA = "0x18057FC10")]
			get
			{
				return default(LightRenderingMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int maxAdditionalLightsCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x4563C0", Offset = "0x454DC0", VA = "0x1804563C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool supportsAdditionalLightShadows
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x3F5530", Offset = "0x3F3F30", VA = "0x1803F5530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public ShadowResolution additionalLightsShadowmapResolution
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x34E7D0", Offset = "0x34D1D0", VA = "0x18034E7D0")]
			get
			{
				return default(ShadowResolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float shadowDistance
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xDCE9F0", Offset = "0xDCD3F0", VA = "0x180DCE9F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public ShadowCascadesOption cascadeCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x58D3E0", Offset = "0x58BDE0", VA = "0x18058D3E0")]
			get
			{
				return default(ShadowCascadesOption);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float cascade2Split
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7E3CA0", Offset = "0x7E26A0", VA = "0x1807E3CA0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 cascade4Split
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x575690", Offset = "0x574090", VA = "0x180575690")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float mainLightShadowDepthBias
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x61F090", Offset = "0x61DA90", VA = "0x18061F090")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float mainLightShadowNormalBias
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x786F20", Offset = "0x785920", VA = "0x180786F20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float mainLightShadowSampleBias
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9D07B0", Offset = "0x9CF1B0", VA = "0x1809D07B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float additionalLightShadowDepthBias
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9D0610", Offset = "0x9CF010", VA = "0x1809D0610")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float additionalLightShadowNormalBias
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x10B5160", Offset = "0x10B3B60", VA = "0x1810B5160")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public float additionalLightShadowSampleBias
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x1270460", Offset = "0x126EE60", VA = "0x181270460")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool supportsSoftShadows
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x9D0910", Offset = "0x9CF310", VA = "0x1809D0910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool supportsDynamicBatching
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9D0900", Offset = "0x9CF300", VA = "0x1809D0900")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool supportsMixedLighting
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x12707D0", Offset = "0x126F1D0", VA = "0x1812707D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public ShaderVariantLogLevel shaderVariantLogLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x1220AA0", Offset = "0x121F4A0", VA = "0x181220AA0")]
			get
			{
				return default(ShaderVariantLogLevel);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Shader blitShader
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x1270470", Offset = "0x126EE70", VA = "0x181270470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Shader copyDepthShader
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x1270500", Offset = "0x126EF00", VA = "0x181270500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Shader screenSpaceShadowShader
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x1270740", Offset = "0x126F140", VA = "0x181270740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public Shader samplingShader
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x12706B0", Offset = "0x126F0B0", VA = "0x1812706B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Shader mobileFadeEffectShader
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x1270590", Offset = "0x126EF90", VA = "0x181270590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public Shader mobileVignetteEffectShader
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x1270620", Offset = "0x126F020", VA = "0x181270620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1270280", Offset = "0x126EC80", VA = "0x181270280", Slot = "19")]
		protected override IRenderPipeline InternalCreatePipeline()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x410710", Offset = "0x40F110", VA = "0x180410710")]
		private Material GetMaterial(DefaultMaterialType materialType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x410710", Offset = "0x40F110", VA = "0x180410710", Slot = "7")]
		public override Material GetDefaultMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x410710", Offset = "0x40F110", VA = "0x180410710", Slot = "11")]
		public override Material GetDefaultParticleMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x410710", Offset = "0x40F110", VA = "0x180410710", Slot = "12")]
		public override Material GetDefaultLineMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x410710", Offset = "0x40F110", VA = "0x180410710", Slot = "13")]
		public override Material GetDefaultTerrainMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x410710", Offset = "0x40F110", VA = "0x180410710", Slot = "14")]
		public override Material GetDefaultUIMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x410710", Offset = "0x40F110", VA = "0x180410710", Slot = "15")]
		public override Material GetDefaultUIOverdrawMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x410710", Offset = "0x40F110", VA = "0x180410710", Slot = "16")]
		public override Material GetDefaultUIETC1SupportedMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x410710", Offset = "0x40F110", VA = "0x180410710", Slot = "17")]
		public override Material GetDefault2DMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x12701E0", Offset = "0x126EBE0", VA = "0x1812701E0", Slot = "18")]
		public override Shader GetDefaultShader()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x306320", Offset = "0x304D20", VA = "0x180306320", Slot = "22")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x12702E0", Offset = "0x126ECE0", VA = "0x1812702E0", Slot = "23")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1270350", Offset = "0x126ED50", VA = "0x181270350")]
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
			[Cpp2IlInjected.Address(RVA = "0x3058F0", Offset = "0x3042F0", VA = "0x1803058F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Material particleLitMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x3170C0", Offset = "0x315AC0", VA = "0x1803170C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Material terrainLitMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x315A10", Offset = "0x314410", VA = "0x180315A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x37CAA0", Offset = "0x37B4A0", VA = "0x18037CAA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3058F0", Offset = "0x3042F0", VA = "0x1803058F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public Shader copyDepthShader
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x3170C0", Offset = "0x315AC0", VA = "0x1803170C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public Shader screenSpaceShadowShader
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x315A10", Offset = "0x314410", VA = "0x180315A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public Shader samplingShader
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x339EB0", Offset = "0x3388B0", VA = "0x180339EB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public Shader mobileFadeEffectShader
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x34A4F0", Offset = "0x348EF0", VA = "0x18034A4F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Shader mobileVignetteEffectShader
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x362F80", Offset = "0x361980", VA = "0x180362F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x37CAA0", Offset = "0x37B4A0", VA = "0x18037CAA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3170C0", Offset = "0x315AC0", VA = "0x1803170C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1278A80", Offset = "0x1277480", VA = "0x181278A80")]
		private IRendererSetup GetOrAssignRendererSetup(ScriptableRenderer renderer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1278BF0", Offset = "0x12775F0", VA = "0x181278BF0", Slot = "4")]
		public void PreCullSetup(ScriptableRenderer renderer, ScriptableRenderContext context, Camera camera, CameraData cameraData, ref LightData lightData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1278DF0", Offset = "0x12777F0", VA = "0x181278DF0", Slot = "5")]
		public void Setup(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1278A10", Offset = "0x1277410", VA = "0x181278A10")]
		public Light GetLight(ref LightData lightData, int lightIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1278840", Offset = "0x1277240", VA = "0x181278840")]
		public AGRPLight GetAGRPLight(ref LightData lightData, int lightIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1278910", Offset = "0x1277310", VA = "0x181278910")]
		public int GetLightCount(ref LightData lightData)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1278970", Offset = "0x1277370", VA = "0x181278970")]
		public bool GetLightInfo(ref LightData lightData, int lightIdx, out Vector4 pos, out Vector4 dir, out Color finalColor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x12787C0", Offset = "0x12771C0", VA = "0x1812787C0")]
		public int CopyToBinnableLights(ref LightData lightData, BinnableLight[] binnableLightBuffer, int maxLightCount)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3057E0", Offset = "0x3041E0", VA = "0x1803057E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1B3510", Offset = "0x1B2910", VA = "0x1801B3510")]
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
		[Cpp2IlInjected.Address(RVA = "0x1B3520", Offset = "0x1B2920", VA = "0x1801B3520", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x1B32C0", Offset = "0x1B26C0", VA = "0x1801B32C0", Slot = "4")]
		public void Execute(int lightIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1B3000", Offset = "0x1B2400", VA = "0x1801B3000")]
		private void AddPointLightImportances(uint3 minVoxelIdx, uint3 maxVoxelIdx, ushort lightIdx, float3 lightPos, float lightIntensity, float lightRange)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1B3090", Offset = "0x1B2490", VA = "0x1801B3090")]
		private void AddSpotLightImportances(uint3 minVoxelIdx, uint3 maxVoxelIdx, ushort lightIdx, float3 lightPos, float3 expandedLightPos, float3 lightForward, float lightIntensity, float lightBaseRadius, float lightRange, float expandedLightRange)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x1B3360", Offset = "0x1B2760", VA = "0x1801B3360")]
		private float PointLightIntensity(float approxIntensity)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1B32D0", Offset = "0x1B26D0", VA = "0x1801B32D0")]
		private float LinearAttenuation(float3 voxelCenter, float3 lightPos, float lightRange)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1B3190", Offset = "0x1B2590", VA = "0x1801B3190")]
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
		[Cpp2IlInjected.Address(RVA = "0x1B33B0", Offset = "0x1B27B0", VA = "0x1801B33B0", Slot = "4")]
		public void Execute(int voxelStartIdx, int voxelCapacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1B33A0", Offset = "0x1B27A0", VA = "0x1801B33A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x13A4A0", Offset = "0x1398A0", VA = "0x18013A4A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1215B0", Offset = "0x1209B0", VA = "0x1801215B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x1215C0", Offset = "0x1209C0", VA = "0x1801215C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1B3C20", Offset = "0x1B3020", VA = "0x1801B3C20")]
		public void Init(string shaderProperty)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x1B3BA0", Offset = "0x1B2FA0", VA = "0x1801B3BA0")]
		public RenderTargetIdentifier Identifier()
		{
			return default(RenderTargetIdentifier);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x13A4F0", Offset = "0x1398F0", VA = "0x18013A4F0")]
		public bool Equals(RenderTargetHandle other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x1B3B20", Offset = "0x1B2F20", VA = "0x1801B3B20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x1215B0", Offset = "0x1209B0", VA = "0x1801215B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xDC43A0", Offset = "0xDC2DA0", VA = "0x180DC43A0")]
		public static bool operator ==(RenderTargetHandle c1, RenderTargetHandle c2)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xDC43B0", Offset = "0xDC2DB0", VA = "0x180DC43B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x24391C0", Offset = "0x2437BC0", VA = "0x1824391C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int maxVisibleAdditionalLights
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x24391C0", Offset = "0x2437BC0", VA = "0x1824391C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public PostProcessRenderContext postProcessingContext
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x3058E0", Offset = "0x3042E0", VA = "0x1803058E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x3059D0", Offset = "0x3043D0", VA = "0x1803059D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public RenderFeaturesetOption RendererFeatureset
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x393780", Offset = "0x392180", VA = "0x180393780")]
			[CompilerGenerated]
			get
			{
				return default(RenderFeaturesetOption);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x3937A0", Offset = "0x3921A0", VA = "0x1803937A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public ComputeBuffer perObjectLightIndices
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x3170C0", Offset = "0x315AC0", VA = "0x1803170C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x338A20", Offset = "0x337420", VA = "0x180338A20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		private static Mesh fullscreenMesh
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x2438D40", Offset = "0x2437740", VA = "0x182438D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public Shader mobileFadeEffectShader
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x362F80", Offset = "0x361980", VA = "0x180362F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x364D00", Offset = "0x363700", VA = "0x180364D00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public Shader mobileVignetteEffectShader
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x34A4E0", Offset = "0x348EE0", VA = "0x18034A4E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x3688E0", Offset = "0x3672E0", VA = "0x1803688E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x24388A0", Offset = "0x24372A0", VA = "0x1824388A0")]
		public ScriptableRenderer(AgainstGravityRenderPipelineAsset pipelineAsset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2437900", Offset = "0x2436300", VA = "0x182437900")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2437A30", Offset = "0x2436430", VA = "0x182437A30")]
		public void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2437FF0", Offset = "0x24369F0", VA = "0x182437FF0")]
		public Material GetMaterial(MaterialHandle handle)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x24374E0", Offset = "0x2435EE0", VA = "0x1824374E0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x24379D0", Offset = "0x24363D0", VA = "0x1824379D0")]
		public void EnqueuePass(ScriptableRenderPass pass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2438560", Offset = "0x2436F60", VA = "0x182438560")]
		public void RenderPostProcess(CommandBuffer cmd, ref CameraData cameraData, RenderTextureFormat colorFormat, RenderTargetIdentifier source, RenderTargetIdentifier dest, bool opaqueOnly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2438280", Offset = "0x2436C80", VA = "0x182438280")]
		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void RenderObjectsWithError(ScriptableRenderContext context, ref CullResults cullResults, Camera camera, FilterRenderersSettings filterSettings, SortFlags sortFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2437620", Offset = "0x2436020", VA = "0x182437620")]
		public static RenderTextureDescriptor CreateRenderTextureDescriptor(ref CameraData cameraData, float scaler = 1f)
		{
			return default(RenderTextureDescriptor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2438740", Offset = "0x2437140", VA = "0x182438740")]
		public static bool RequiresIntermediateColorTexture(ref CameraData cameraData, RenderTextureDescriptor baseDescriptor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2437EF0", Offset = "0x24368F0", VA = "0x182437EF0")]
		public static ClearFlag GetCameraClearFlag(Camera camera)
		{
			return default(ClearFlag);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2438130", Offset = "0x2436B30", VA = "0x182438130")]
		public static void RenderFullscreenQuad(CommandBuffer cmd, Material material, [Optional] MaterialPropertyBlock properties, int shaderPassId = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2437530", Offset = "0x2435F30", VA = "0x182437530")]
		public static void CopyTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier dest, Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x24377D0", Offset = "0x24361D0", VA = "0x1824377D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2439340", Offset = "0x2437D40", VA = "0x182439340")]
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
		[Cpp2IlInjected.Address(RVA = "0x250750", Offset = "0x24FB50", VA = "0x180250750")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public static class ShadowUtils
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x24399B0", Offset = "0x24383B0", VA = "0x1824399B0")]
		public static bool ExtractDirectionalLightMatrix(ref CullResults cullResults, ref ShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowResolution, float shadowNearPlane, out Vector4 cascadeSplitDistance, out ShadowSliceData shadowSliceData, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2439D80", Offset = "0x2438780", VA = "0x182439D80")]
		public static bool ExtractSpotLightMatrix(ref CullResults cullResults, ref ShadowData shadowData, int shadowLightIndex, out Matrix4x4 shadowMatrix, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x243A4F0", Offset = "0x2438EF0", VA = "0x18243A4F0")]
		public static void RenderShadowSlice(CommandBuffer cmd, ref ScriptableRenderContext context, ref ShadowSliceData shadowSliceData, ref DrawShadowsSettings settings, Matrix4x4 proj, Matrix4x4 view)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2439EB0", Offset = "0x24388B0", VA = "0x182439EB0")]
		public static int GetMaxTileResolutionInAtlas(int atlasWidth, int atlasHeight, int tileCount)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x24397C0", Offset = "0x24381C0", VA = "0x1824397C0")]
		public static void ApplySliceTransform(ref ShadowSliceData shadowSliceData, int atlasWidth, int atlasHeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2439F50", Offset = "0x2438950", VA = "0x182439F50")]
		public static Vector4 GetShadowBias(Light shadowLight, int shadowLightIndex, ref ShadowData shadowData, Matrix4x4 lightProjectionMatrix, float shadowResolution)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x243A6E0", Offset = "0x24390E0", VA = "0x18243A6E0")]
		public static void SetupShadowCasterConstantBuffer(CommandBuffer cmd, Light shadowLight, Vector4 shadowBias)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x243A8B0", Offset = "0x24392B0", VA = "0x18243A8B0")]
		[Obsolete]
		public static void SetupShadowCasterConstants(CommandBuffer cmd, ref VisibleLight visibleLight, Matrix4x4 proj, float cascadeResolution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x243A260", Offset = "0x2438C60", VA = "0x18243A260")]
		private static Matrix4x4 GetShadowTransform(Matrix4x4 proj, Matrix4x4 view)
		{
			return default(Matrix4x4);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class VisualizeFroxelBounds : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x243ABD0", Offset = "0x24395D0", VA = "0x18243ABD0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x306310", Offset = "0x304D10", VA = "0x180306310")]
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
		[Cpp2IlInjected.Address(RVA = "0x243B4A0", Offset = "0x2439EA0", VA = "0x18243B4A0")]
		public static uint PackIdx(uint x, uint y, uint z)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x243BA30", Offset = "0x243A430", VA = "0x18243BA30")]
		public static uint3 UnpackIdx(uint voxelIdx)
		{
			return default(uint3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x243BCE0", Offset = "0x243A6E0", VA = "0x18243BCE0")]
		public static float3 VoxelPackedIdxToCenterPosition(uint packedIdx, float3 worldVolumeMinCorner, float3 worldVolumeMaxCorner)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x243BAA0", Offset = "0x243A4A0", VA = "0x18243BAA0")]
		public static Vector3 VoxelPackedIdxToCenterPositionVector3(uint packedIdx, Vector3 worldVolumeMinCorner, Vector3 worldVolumeMaxCorner)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x243B630", Offset = "0x243A030", VA = "0x18243B630")]
		public static uint3 PositionToVoxelIdxUnpacked(float3 position, float3 worldVolumeMinCorner, float3 worldVolumeMaxCorner)
		{
			return default(uint3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x243B4B0", Offset = "0x2439EB0", VA = "0x18243B4B0")]
		public static Vector3 PositionToVoxelIdxUnpackedVector3(Vector3 position, Vector3 worldVolumeMin, Vector3 worldVolumeMax)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x243B800", Offset = "0x243A200", VA = "0x18243B800")]
		public static void SphereOverlap(float3 worldVolumeMin, float3 worldVolumeMax, float3 spherePosition, float radius, out uint3 minVoxelIndex, out uint3 maxVoxelIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x243AE20", Offset = "0x2439820", VA = "0x18243AE20")]
		public static void ConeBoundingSphere(float3 coneOrigin, float3 coneDir, float range, float coneAngle, out float3 center, out float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x243B2F0", Offset = "0x2439CF0", VA = "0x18243B2F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x48C410", Offset = "0x48AE10", VA = "0x18048C410", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x127FE60", Offset = "0x127E860", VA = "0x18127FE60")]
		private void Init()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x1280520", Offset = "0x127EF20", VA = "0x181280520", Slot = "4")]
		public void PreCullSetup(ScriptableRenderer renderer, ScriptableRenderContext context, Camera camera, CameraData cameraData, ref LightData lightData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x1280530", Offset = "0x127EF30", VA = "0x181280530", Slot = "5")]
		public void Setup(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x127F4B0", Offset = "0x127DEB0", VA = "0x18127F4B0")]
		private bool CanCopyDepth(ref CameraData cameraData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x127FD90", Offset = "0x127E790", VA = "0x18127FD90", Slot = "7")]
		public Light GetLight(ref LightData lightData, int lightIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x127FA40", Offset = "0x127E440", VA = "0x18127FA40", Slot = "8")]
		public AGRPLight GetAGRPLight(ref LightData lightData, int lightIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x127FB70", Offset = "0x127E570", VA = "0x18127FB70", Slot = "9")]
		public int GetLightCount(ref LightData lightData)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x127FBC0", Offset = "0x127E5C0", VA = "0x18127FBC0", Slot = "10")]
		public bool GetLightInfo(ref LightData lightData, int lightIdx, out Vector4 pos, out Vector4 dir, out Color finalColor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x127F4F0", Offset = "0x127DEF0", VA = "0x18127F4F0", Slot = "11")]
		public int CopyToBinnableLights(ref LightData lightData, BinnableLight[] binnableLightBuffer, int maxLightCount)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3057E0", Offset = "0x3041E0", VA = "0x1803057E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x48C410", Offset = "0x48AE10", VA = "0x18048C410", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1281500", Offset = "0x127FF00", VA = "0x181281500")]
		private void Init()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x1281880", Offset = "0x1280280", VA = "0x181281880", Slot = "4")]
		public void PreCullSetup(ScriptableRenderer renderer, ScriptableRenderContext context, Camera camera, CameraData cameraData, ref LightData lightData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x1281A90", Offset = "0x1280490", VA = "0x181281A90", Slot = "5")]
		public void Setup(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x1281420", Offset = "0x127FE20", VA = "0x181281420", Slot = "7")]
		public Light GetLight(ref LightData lightData, int lightIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1281130", Offset = "0x127FB30", VA = "0x181281130", Slot = "8")]
		public AGRPLight GetAGRPLight(ref LightData lightData, int lightIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x1281240", Offset = "0x127FC40", VA = "0x181281240", Slot = "9")]
		public int GetLightCount(ref LightData lightData)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1281290", Offset = "0x127FC90", VA = "0x181281290", Slot = "10")]
		public bool GetLightInfo(ref LightData lightData, int lightIdx, out Vector4 pos, out Vector4 dir, out Color finalColor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1281070", Offset = "0x127FA70", VA = "0x181281070", Slot = "11")]
		public int CopyToBinnableLights(ref LightData lightData, BinnableLight[] binnableLightBuffer, int maxLightCount)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3057E0", Offset = "0x3041E0", VA = "0x1803057E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x410710", Offset = "0x40F110", VA = "0x180410710", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2436FC0", Offset = "0x24359C0", VA = "0x182436FC0")]
		private void Init()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2436FC0", Offset = "0x24359C0", VA = "0x182436FC0", Slot = "4")]
		public void PreCullSetup(ScriptableRenderer renderer, ScriptableRenderContext context, Camera camera, CameraData cameraData, ref LightData lightData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2437060", Offset = "0x2435A60", VA = "0x182437060", Slot = "5")]
		public void Setup(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3057E0", Offset = "0x3041E0", VA = "0x1803057E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x52C970", Offset = "0x52B370", VA = "0x18052C970")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x67C2C0", Offset = "0x67ACC0", VA = "0x18067C2C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x1270010", Offset = "0x126EA10", VA = "0x181270010")]
		public AdditionalLightsShadowCasterPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x126F9D0", Offset = "0x126E3D0", VA = "0x18126F9D0")]
		public bool Setup(RenderTargetHandle destination, ref RenderingData renderingData, int maxVisibleAdditionalLights)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x126EC40", Offset = "0x126D640", VA = "0x18126EC40", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x126ED00", Offset = "0x126D700", VA = "0x18126ED00", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x126EA40", Offset = "0x126D440", VA = "0x18126EA40")]
		private void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x126EDC0", Offset = "0x126D7C0", VA = "0x18126EDC0")]
		private void RenderAdditionalShadowmapAtlas(ref ScriptableRenderContext context, ref CullResults cullResults, ref LightData lightData, ref ShadowData shadowData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x126F530", Offset = "0x126DF30", VA = "0x18126F530")]
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
			[Cpp2IlInjected.Address(RVA = "0x1274160", Offset = "0x1272B60", VA = "0x181274160")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x1274250", Offset = "0x1272C50", VA = "0x181274250")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x1274080", Offset = "0x1272A80", VA = "0x181274080", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x1274150", Offset = "0x1272B50", VA = "0x181274150")]
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
			[Cpp2IlInjected.Address(RVA = "0xB2BD30", Offset = "0xB2A730", VA = "0x180B2BD30")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xB2BF80", Offset = "0xB2A980", VA = "0x180B2BF80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x1276160", Offset = "0x1274B60", VA = "0x181276160")]
		public static void SetDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x12761C0", Offset = "0x1274BC0", VA = "0x1812761C0")]
		public static void SetShadowCasterLayerMask(int layerMask)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x1276970", Offset = "0x1275370", VA = "0x181276970")]
		public CachedMainLightShadowCasterPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x1275590", Offset = "0x1273F90", VA = "0x181275590")]
		public void PreCullSetup(ref ScriptableRenderContext context, ref CameraData cameraData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x1276580", Offset = "0x1274F80", VA = "0x181276580")]
		public bool Setup(RenderTargetHandle destination, ref RenderingData renderingData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x1275400", Offset = "0x1273E00", VA = "0x181275400", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x12754A0", Offset = "0x1273EA0", VA = "0x1812754A0", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x12752E0", Offset = "0x1273CE0", VA = "0x1812752E0")]
		private void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x1275510", Offset = "0x1273F10", VA = "0x181275510")]
		private Vector4 GetShadowBias(Vector4 biasSettings, Matrix4x4 lightProjectionMatrix, int shadowResolution)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x1275C80", Offset = "0x1274680", VA = "0x181275C80")]
		private void RenderMainLightCascadeShadowmap(ref ScriptableRenderContext context, ref ShadowData shadowData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x1276220", Offset = "0x1274C20", VA = "0x181276220")]
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
			[Cpp2IlInjected.Address(RVA = "0x4CBE00", Offset = "0x4CA800", VA = "0x1804CBE00")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x4CBE10", Offset = "0x4CA810", VA = "0x1804CBE10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		private RenderTargetHandle destination
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x349840", Offset = "0x348240", VA = "0x180349840")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x39D3A0", Offset = "0x39BDA0", VA = "0x18039D3A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x12770C0", Offset = "0x1275AC0", VA = "0x1812770C0")]
		public CopyColorPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x12770B0", Offset = "0x1275AB0", VA = "0x1812770B0")]
		public void Setup(RenderTargetHandle source, RenderTargetHandle destination)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1276B70", Offset = "0x1275570", VA = "0x181276B70", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x1276FB0", Offset = "0x12759B0", VA = "0x181276FB0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x35B460", Offset = "0x359E60", VA = "0x18035B460")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x60AC30", Offset = "0x609630", VA = "0x18060AC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		private RenderTargetHandle destination
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x5E04A0", Offset = "0x5DEEA0", VA = "0x1805E04A0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x39D390", Offset = "0x39BD90", VA = "0x18039D390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x1277820", Offset = "0x1276220", VA = "0x181277820")]
		public void Setup(RenderTargetHandle source, RenderTargetHandle destination)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x1277140", Offset = "0x1275B40", VA = "0x181277140", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x1277720", Offset = "0x1276120", VA = "0x181277720", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x1274150", Offset = "0x1272B50", VA = "0x181274150")]
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
			[Cpp2IlInjected.Address(RVA = "0x35B460", Offset = "0x359E60", VA = "0x18035B460")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x60AC30", Offset = "0x609630", VA = "0x18060AC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		private RenderTargetHandle depthAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x5E04A0", Offset = "0x5DEEA0", VA = "0x1805E04A0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x39D390", Offset = "0x39BD90", VA = "0x18039D390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x1277CD0", Offset = "0x12766D0", VA = "0x181277CD0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x1277D00", Offset = "0x1276700", VA = "0x181277D00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		private SampleCount samples
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x55FEF0", Offset = "0x55E8F0", VA = "0x18055FEF0")]
			[CompilerGenerated]
			get
			{
				return default(SampleCount);
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x67C2D0", Offset = "0x67ACD0", VA = "0x18067C2D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x1277CA0", Offset = "0x12766A0", VA = "0x181277CA0")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorAttachmentHandle, RenderTargetHandle depthAttachmentHandle, SampleCount samples)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x1277830", Offset = "0x1276230", VA = "0x181277830", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x1277B30", Offset = "0x1276530", VA = "0x181277B30", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x1274150", Offset = "0x1272B50", VA = "0x181274150")]
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
			[Cpp2IlInjected.Address(RVA = "0x30EA60", Offset = "0x30D460", VA = "0x18030EA60", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x306320", Offset = "0x304D20", VA = "0x180306320", Slot = "5")]
		public virtual void RenderPass(CommandBuffer commandBuffer, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x306310", Offset = "0x304D10", VA = "0x180306310")]
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
			[Cpp2IlInjected.Address(RVA = "0x5180B0", Offset = "0x516AB0", VA = "0x1805180B0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x521B10", Offset = "0x520510", VA = "0x180521B10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private RenderTargetHandle depthAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x4CBE00", Offset = "0x4CA800", VA = "0x1804CBE00")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x4CBE10", Offset = "0x4CA810", VA = "0x1804CBE10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x1278770", Offset = "0x1277170", VA = "0x181278770")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x12787A0", Offset = "0x12771A0", VA = "0x1812787A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool RequiresOpaqueTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x1278600", Offset = "0x1277000", VA = "0x181278600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x1277D20", Offset = "0x1276720", VA = "0x181277D20")]
		public static void EnqueueEffectForNextRender(CustomRenderEffect effect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x1278400", Offset = "0x1276E00", VA = "0x181278400")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorHandle, RenderTargetHandle depthHandle, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1278080", Offset = "0x1276A80", VA = "0x181278080", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x1277DA0", Offset = "0x12767A0", VA = "0x181277DA0")]
		private void ExecuteEffect(CustomRenderEffect renderEffect, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x12785A0", Offset = "0x1276FA0", VA = "0x1812785A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E04A0", Offset = "0x5DEEA0", VA = "0x1805E04A0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x39D390", Offset = "0x39BD90", VA = "0x18039D390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		internal RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x1277CD0", Offset = "0x12766D0", VA = "0x181277CD0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x1277D00", Offset = "0x1276700", VA = "0x181277D00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		private FilterRenderersSettings opaqueFilterSettings
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x1279620", Offset = "0x1278020", VA = "0x181279620")]
			[CompilerGenerated]
			get
			{
				return default(FilterRenderersSettings);
			}
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x1279640", Offset = "0x1278040", VA = "0x181279640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x1279580", Offset = "0x1277F80", VA = "0x181279580")]
		public DepthOnlyPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x12794F0", Offset = "0x1277EF0", VA = "0x1812794F0")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle depthAttachmentHandle, SampleCount samples)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x1278F10", Offset = "0x1277910", VA = "0x181278F10", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x12793F0", Offset = "0x1277DF0", VA = "0x1812793F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x35B460", Offset = "0x359E60", VA = "0x18035B460")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x60AC30", Offset = "0x609630", VA = "0x18060AC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		private RenderTargetHandle depthAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x5E04A0", Offset = "0x5DEEA0", VA = "0x1805E04A0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x39D390", Offset = "0x39BD90", VA = "0x18039D390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x1277820", Offset = "0x1276220", VA = "0x181277820")]
		public void Setup(RenderTargetHandle colorHandle, RenderTargetHandle depthHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x1279650", Offset = "0x1278050", VA = "0x181279650", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x1274150", Offset = "0x1272B50", VA = "0x181274150")]
		public DrawSkyboxPass()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class EndXRRenderingPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x12799E0", Offset = "0x12783E0", VA = "0x1812799E0", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x1274150", Offset = "0x1272B50", VA = "0x181274150")]
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
			[Cpp2IlInjected.Address(RVA = "0x35B460", Offset = "0x359E60", VA = "0x18035B460")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x60AC30", Offset = "0x609630", VA = "0x18060AC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x1279F20", Offset = "0x1278920", VA = "0x181279F20")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x1279F50", Offset = "0x1278950", VA = "0x181279F50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x1279EF0", Offset = "0x12788F0", VA = "0x181279EF0")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorAttachmentHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x1279A80", Offset = "0x1278480", VA = "0x181279A80", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x1274150", Offset = "0x1272B50", VA = "0x181274150")]
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
			[Cpp2IlInjected.Address(RVA = "0x127AF30", Offset = "0x1279930", VA = "0x18127AF30")]
			get
			{
				return default(NativeMultiHashMap<ushort, LightInBin>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		private NativeMultiHashMap<ushort, LightInBin> BackBuffer
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x127AF00", Offset = "0x1279900", VA = "0x18127AF00")]
			get
			{
				return default(NativeMultiHashMap<ushort, LightInBin>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x127A4D0", Offset = "0x1278ED0", VA = "0x18127A4D0")]
		private void SetupPersistentBuffers(RenderFeaturesetOption featureset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x127A430", Offset = "0x1278E30", VA = "0x18127A430")]
		private static void RunAtQuit(Action quitFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xED5B60", Offset = "0xED4560", VA = "0x180ED5B60")]
		private void ResizePersistentArray<T>(ref NativeArray<T> array, int size) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x127A620", Offset = "0x1279020", VA = "0x18127A620")]
		public JobHandle StartLightBin(CameraData cameraData, RenderFeaturesetOption featureset, ref LightData lightData)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x1279FF0", Offset = "0x12789F0", VA = "0x181279FF0")]
		private void CompleteFrameJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x1279F70", Offset = "0x1278970", VA = "0x181279F70")]
		private void CleanupFrameData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x127A020", Offset = "0x1278A20", VA = "0x18127A020", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x1274150", Offset = "0x1272B50", VA = "0x181274150")]
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
			[Cpp2IlInjected.Address(RVA = "0x48B190", Offset = "0x489B90", VA = "0x18048B190")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x5DE6E0", Offset = "0x5DD0E0", VA = "0x1805DE6E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x127C430", Offset = "0x127AE30", VA = "0x18127C430")]
		public MainLightShadowCasterPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x127C190", Offset = "0x127AB90", VA = "0x18127C190")]
		public bool Setup(RenderTargetHandle destination, ref RenderingData renderingData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x127B180", Offset = "0x1279B80", VA = "0x18127B180", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x127B230", Offset = "0x1279C30", VA = "0x18127B230", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x127AF60", Offset = "0x1279960", VA = "0x18127AF60")]
		private void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x127B2F0", Offset = "0x1279CF0", VA = "0x18127B2F0")]
		private void RenderMainLightCascadeShadowmap(ref ScriptableRenderContext context, ref CullResults cullResults, ref LightData lightData, ref ShadowData shadowData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x127B9D0", Offset = "0x127A3D0", VA = "0x18127B9D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x127D000", Offset = "0x127BA00", VA = "0x18127D000")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected static Mesh WorldSpaceQuadMesh
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x127D090", Offset = "0x127BA90", VA = "0x18127D090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected Material EffectMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x127CEC0", Offset = "0x127B8C0", VA = "0x18127CEC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x127CBF0", Offset = "0x127B5F0", VA = "0x18127CBF0")]
		protected static Matrix4x4 GetWorldSpaceQuadTRSMatrix(Camera camera, bool scaleUniformly = false)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x127C650", Offset = "0x127B050", VA = "0x18127C650")]
		private static Mesh CreateWorldSpaceQuadMesh()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x1274150", Offset = "0x1272B50", VA = "0x181274150")]
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
			[Cpp2IlInjected.Address(RVA = "0x127D5C0", Offset = "0x127BFC0", VA = "0x18127D5C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x127D480", Offset = "0x127BE80", VA = "0x18127D480")]
		public bool Setup(Shader effectShader)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x127D180", Offset = "0x127BB80", VA = "0x18127D180", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x127D560", Offset = "0x127BF60", VA = "0x18127D560")]
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
			[Cpp2IlInjected.Address(RVA = "0x349840", Offset = "0x348240", VA = "0x180349840")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x39D3A0", Offset = "0x39BDA0", VA = "0x18039D3A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		private RenderTargetHandle depthAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x491E30", Offset = "0x490830", VA = "0x180491E30")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x39D3C0", Offset = "0x39BDC0", VA = "0x18039D3C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x127DD30", Offset = "0x127C730", VA = "0x18127DD30")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x127DD70", Offset = "0x127C770", VA = "0x18127DD70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		private ClearFlag clearFlag
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x343AC0", Offset = "0x3424C0", VA = "0x180343AC0")]
			[CompilerGenerated]
			get
			{
				return default(ClearFlag);
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xEC19E0", Offset = "0xEC03E0", VA = "0x180EC19E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		private Color clearColor
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x127DD20", Offset = "0x127C720", VA = "0x18127DD20")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x127DD60", Offset = "0x127C760", VA = "0x18127DD60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x127DAB0", Offset = "0x127C4B0", VA = "0x18127DAB0")]
		public bool Setup(Shader effectShader, RenderTextureDescriptor descriptor, RenderTargetHandle colorAttachmentHandle, RenderTargetHandle depthAttachmentHandle, ClearFlag clearFlag, Color clearColor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x127D670", Offset = "0x127C070", VA = "0x18127D670", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x127DCC0", Offset = "0x127C6C0", VA = "0x18127DCC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x35B460", Offset = "0x359E60", VA = "0x18035B460")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x60AC30", Offset = "0x609630", VA = "0x18060AC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x1279F20", Offset = "0x1278920", VA = "0x181279F20")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x1279F50", Offset = "0x1278950", VA = "0x181279F50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x1279EF0", Offset = "0x12788F0", VA = "0x181279EF0")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorAttachmentHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x127DD90", Offset = "0x127C790", VA = "0x18127DD90", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x1274150", Offset = "0x1272B50", VA = "0x181274150")]
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
			[Cpp2IlInjected.Address(RVA = "0x491E30", Offset = "0x490830", VA = "0x180491E30")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x39D3C0", Offset = "0x39BDC0", VA = "0x18039D3C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		private RenderTargetHandle depthAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x3F7770", Offset = "0x3F6170", VA = "0x1803F7770")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x39D340", Offset = "0x39BD40", VA = "0x18039D340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x127EE30", Offset = "0x127D830", VA = "0x18127EE30")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x127EE70", Offset = "0x127D870", VA = "0x18127EE70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		private ClearFlag clearFlag
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x34E7D0", Offset = "0x34D1D0", VA = "0x18034E7D0")]
			[CompilerGenerated]
			get
			{
				return default(ClearFlag);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x630810", Offset = "0x62F210", VA = "0x180630810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		private Color clearColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x127EE20", Offset = "0x127D820", VA = "0x18127EE20")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x127EE60", Offset = "0x127D860", VA = "0x18127EE60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x127ED80", Offset = "0x127D780", VA = "0x18127ED80")]
		public RenderOpaqueForwardPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x127ECB0", Offset = "0x127D6B0", VA = "0x18127ECB0")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorAttachmentHandle, RenderTargetHandle depthAttachmentHandle, ClearFlag clearFlag, Color clearColor, RendererConfiguration configuration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x127E790", Offset = "0x127D190", VA = "0x18127E790", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x491E30", Offset = "0x490830", VA = "0x180491E30")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x39D3C0", Offset = "0x39BDC0", VA = "0x18039D3C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		private RenderTargetHandle depthAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x3F7770", Offset = "0x3F6170", VA = "0x1803F7770")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x39D340", Offset = "0x39BD40", VA = "0x18039D340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x127EE30", Offset = "0x127D830", VA = "0x18127EE30")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x127EE70", Offset = "0x127D870", VA = "0x18127EE70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x127F400", Offset = "0x127DE00", VA = "0x18127F400")]
		public RenderTransparentForwardPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x127F3D0", Offset = "0x127DDD0", VA = "0x18127F3D0")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorAttachmentHandle, RenderTargetHandle depthAttachmentHandle, RendererConfiguration configuration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x127EED0", Offset = "0x127D8D0", VA = "0x18127EED0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x35B460", Offset = "0x359E60", VA = "0x18035B460")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x60AC30", Offset = "0x609630", VA = "0x18060AC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x60AC30", Offset = "0x609630", VA = "0x18060AC30")]
		public void Setup(RenderTargetHandle source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x1282060", Offset = "0x1280A60", VA = "0x181282060", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x1274150", Offset = "0x1272B50", VA = "0x181274150")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E04A0", Offset = "0x5DEEA0", VA = "0x1805E04A0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x39D390", Offset = "0x39BD90", VA = "0x18039D390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x1277CD0", Offset = "0x12766D0", VA = "0x181277CD0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x1277D00", Offset = "0x1276700", VA = "0x181277D00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x1282830", Offset = "0x1281230", VA = "0x181282830")]
		public ScreenSpaceShadowResolvePass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x12827D0", Offset = "0x12811D0", VA = "0x1812827D0")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorAttachmentHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x12823B0", Offset = "0x1280DB0", VA = "0x1812823B0", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x12826D0", Offset = "0x12810D0", VA = "0x1812826D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x1282E10", Offset = "0x1281810", VA = "0x181282E10")]
		public ScriptableRenderPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x306320", Offset = "0x304D20", VA = "0x180306320", Slot = "4")]
		public virtual void FrameCleanup(CommandBuffer cmd)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData);

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x1282A40", Offset = "0x1281440", VA = "0x181282A40")]
		protected void RegisterShaderPassName(string passName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x1282870", Offset = "0x1281270", VA = "0x181282870")]
		protected DrawRendererSettings CreateDrawRendererSettings(Camera camera, SortFlags sortFlags, RendererConfiguration rendererConfiguration, bool supportsDynamicBatching)
		{
			return default(DrawRendererSettings);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x1282AC0", Offset = "0x12814C0", VA = "0x181282AC0")]
		protected static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorAttachment, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, ClearFlag clearFlags, Color clearColor, TextureDimension dimension)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x1282C20", Offset = "0x1281620", VA = "0x181282C20")]
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
		[Cpp2IlInjected.Address(RVA = "0x1283230", Offset = "0x1281C30", VA = "0x181283230")]
		private void InitializeLightConstants(ref LightData lightData, int lightIndex, out Vector4 lightPos, out Vector4 lightColor, out Vector4 lightAttenuation, out Vector4 lightSpotDir)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x1283D50", Offset = "0x1282750", VA = "0x181283D50")]
		private void SetupShaderLightConstants(CommandBuffer cmd, ScriptableRenderer renderer, ref LightData lightData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x1283C20", Offset = "0x1282620", VA = "0x181283C20")]
		private void SetupMainLightConstants(CommandBuffer cmd, ref LightData lightData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x1283760", Offset = "0x1282160", VA = "0x181283760")]
		private void SetupAdditionalLightConstants(CommandBuffer cmd, int maxLightCount, ref LightData lightData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x1282EA0", Offset = "0x12818A0", VA = "0x181282EA0", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x1283EB0", Offset = "0x12828B0", VA = "0x181283EB0")]
		public SetupAGRPConstantsPass()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class SetupForwardRenderingPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1283FD0", Offset = "0x12829D0", VA = "0x181283FD0", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x1274150", Offset = "0x1272B50", VA = "0x181274150")]
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
			[Cpp2IlInjected.Address(RVA = "0x35B460", Offset = "0x359E60", VA = "0x18035B460")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x60AC30", Offset = "0x609630", VA = "0x18060AC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x1279F20", Offset = "0x1278920", VA = "0x181279F20")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x1279F50", Offset = "0x1278950", VA = "0x181279F50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		private RenderTargetIdentifier destination
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x1284410", Offset = "0x1282E10", VA = "0x181284410")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetIdentifier);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x1284430", Offset = "0x1282E30", VA = "0x181284430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x12843D0", Offset = "0x1282DD0", VA = "0x1812843D0")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorAttachmentHandle, RenderTargetIdentifier destination)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x12841E0", Offset = "0x1282BE0", VA = "0x1812841E0", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x1274150", Offset = "0x1272B50", VA = "0x181274150")]
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
