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
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public static int _GlossyEnvironmentColor;

			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			public static int _SubtractiveShadowColor;
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private static class PerCameraBuffer
		{
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			public static int _InvCameraViewProj;

			[Cpp2IlInjected.Token(Token = "0x40001ED")]
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
				[Cpp2IlInjected.Address(RVA = "0x99780", Offset = "0x98B80", VA = "0x180099780")]
				[CompilerGenerated]
				get
				{
					return default(DepthTextureRenderMode);
				}
				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0x99790", Offset = "0x98B90", VA = "0x180099790")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public bool supportsCameraOpaqueTexture
			{
				[Cpp2IlInjected.Token(Token = "0x60001CC")]
				[Cpp2IlInjected.Address(RVA = "0xA69E0", Offset = "0xA5DE0", VA = "0x1800A69E0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001CD")]
				[Cpp2IlInjected.Address(RVA = "0x135C90", Offset = "0x135090", VA = "0x180135C90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public Downsampling opaqueDownsampling
			{
				[Cpp2IlInjected.Token(Token = "0x60001CE")]
				[Cpp2IlInjected.Address(RVA = "0x993F0", Offset = "0x987F0", VA = "0x1800993F0")]
				[CompilerGenerated]
				get
				{
					return default(Downsampling);
				}
				[Cpp2IlInjected.Token(Token = "0x60001CF")]
				[Cpp2IlInjected.Address(RVA = "0xE12F0", Offset = "0xE06F0", VA = "0x1800E12F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public bool supportsHDR
			{
				[Cpp2IlInjected.Token(Token = "0x60001D0")]
				[Cpp2IlInjected.Address(RVA = "0x135B50", Offset = "0x134F50", VA = "0x180135B50")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001D1")]
				[Cpp2IlInjected.Address(RVA = "0x135CB0", Offset = "0x1350B0", VA = "0x180135CB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public int msaaSampleCount
			{
				[Cpp2IlInjected.Token(Token = "0x60001D2")]
				[Cpp2IlInjected.Address(RVA = "0x9D980", Offset = "0x9CD80", VA = "0x18009D980")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60001D3")]
				[Cpp2IlInjected.Address(RVA = "0xE12D0", Offset = "0xE06D0", VA = "0x1800E12D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000084")]
			public float renderScale
			{
				[Cpp2IlInjected.Token(Token = "0x60001D4")]
				[Cpp2IlInjected.Address(RVA = "0x9D540", Offset = "0x9C940", VA = "0x18009D540")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001D5")]
				[Cpp2IlInjected.Address(RVA = "0x9D570", Offset = "0x9C970", VA = "0x18009D570")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000085")]
			public LightRenderingMode mainLightRenderingMode
			{
				[Cpp2IlInjected.Token(Token = "0x60001D6")]
				[Cpp2IlInjected.Address(RVA = "0xA5D30", Offset = "0xA5130", VA = "0x1800A5D30")]
				[CompilerGenerated]
				get
				{
					return default(LightRenderingMode);
				}
				[Cpp2IlInjected.Token(Token = "0x60001D7")]
				[Cpp2IlInjected.Address(RVA = "0x135C00", Offset = "0x135000", VA = "0x180135C00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000086")]
			public bool supportsMainLightShadows
			{
				[Cpp2IlInjected.Token(Token = "0x60001D8")]
				[Cpp2IlInjected.Address(RVA = "0x135B60", Offset = "0x134F60", VA = "0x180135B60")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001D9")]
				[Cpp2IlInjected.Address(RVA = "0x135CC0", Offset = "0x1350C0", VA = "0x180135CC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public int mainLightShadowmapResolution
			{
				[Cpp2IlInjected.Token(Token = "0x60001DA")]
				[Cpp2IlInjected.Address(RVA = "0x88BB0", Offset = "0x87FB0", VA = "0x180088BB0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60001DB")]
				[Cpp2IlInjected.Address(RVA = "0xE1300", Offset = "0xE0700", VA = "0x1800E1300")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			public LightRenderingMode additionalLightsRenderingMode
			{
				[Cpp2IlInjected.Token(Token = "0x60001DC")]
				[Cpp2IlInjected.Address(RVA = "0xE12A0", Offset = "0xE06A0", VA = "0x1800E12A0")]
				[CompilerGenerated]
				get
				{
					return default(LightRenderingMode);
				}
				[Cpp2IlInjected.Token(Token = "0x60001DD")]
				[Cpp2IlInjected.Address(RVA = "0xE12E0", Offset = "0xE06E0", VA = "0x1800E12E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000089")]
			public int maxAdditionalLights
			{
				[Cpp2IlInjected.Token(Token = "0x60001DE")]
				[Cpp2IlInjected.Address(RVA = "0x1024A0", Offset = "0x1018A0", VA = "0x1801024A0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60001DF")]
				[Cpp2IlInjected.Address(RVA = "0x1024E0", Offset = "0x1018E0", VA = "0x1801024E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			public bool supportsAdditionalLightShadows
			{
				[Cpp2IlInjected.Token(Token = "0x60001E0")]
				[Cpp2IlInjected.Address(RVA = "0x135B30", Offset = "0x134F30", VA = "0x180135B30")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001E1")]
				[Cpp2IlInjected.Address(RVA = "0x135C80", Offset = "0x135080", VA = "0x180135C80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			public int additionalLightsShadowmapResolution
			{
				[Cpp2IlInjected.Token(Token = "0x60001E2")]
				[Cpp2IlInjected.Address(RVA = "0x134E00", Offset = "0x134200", VA = "0x180134E00")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60001E3")]
				[Cpp2IlInjected.Address(RVA = "0x135BC0", Offset = "0x134FC0", VA = "0x180135BC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			public float shadowDistance
			{
				[Cpp2IlInjected.Token(Token = "0x60001E4")]
				[Cpp2IlInjected.Address(RVA = "0x135B20", Offset = "0x134F20", VA = "0x180135B20")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001E5")]
				[Cpp2IlInjected.Address(RVA = "0x135C70", Offset = "0x135070", VA = "0x180135C70")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public int cascadeCount
			{
				[Cpp2IlInjected.Token(Token = "0x60001E6")]
				[Cpp2IlInjected.Address(RVA = "0x135AB0", Offset = "0x134EB0", VA = "0x180135AB0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60001E7")]
				[Cpp2IlInjected.Address(RVA = "0x135BF0", Offset = "0x134FF0", VA = "0x180135BF0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public float cascade2Split
			{
				[Cpp2IlInjected.Token(Token = "0x60001E8")]
				[Cpp2IlInjected.Address(RVA = "0x135A80", Offset = "0x134E80", VA = "0x180135A80")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001E9")]
				[Cpp2IlInjected.Address(RVA = "0x135BD0", Offset = "0x134FD0", VA = "0x180135BD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public Vector3 cascade4Split
			{
				[Cpp2IlInjected.Token(Token = "0x60001EA")]
				[Cpp2IlInjected.Address(RVA = "0x135A90", Offset = "0x134E90", VA = "0x180135A90")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x60001EB")]
				[Cpp2IlInjected.Address(RVA = "0x135BE0", Offset = "0x134FE0", VA = "0x180135BE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public float mainLightShadowDepthBias
			{
				[Cpp2IlInjected.Token(Token = "0x60001EC")]
				[Cpp2IlInjected.Address(RVA = "0x135AC0", Offset = "0x134EC0", VA = "0x180135AC0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001ED")]
				[Cpp2IlInjected.Address(RVA = "0x135C10", Offset = "0x135010", VA = "0x180135C10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public float mainLightShadowNormalBias
			{
				[Cpp2IlInjected.Token(Token = "0x60001EE")]
				[Cpp2IlInjected.Address(RVA = "0x135AD0", Offset = "0x134ED0", VA = "0x180135AD0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001EF")]
				[Cpp2IlInjected.Address(RVA = "0x135C20", Offset = "0x135020", VA = "0x180135C20")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public float mainLightShadowSampleBias
			{
				[Cpp2IlInjected.Token(Token = "0x60001F0")]
				[Cpp2IlInjected.Address(RVA = "0x135AE0", Offset = "0x134EE0", VA = "0x180135AE0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001F1")]
				[Cpp2IlInjected.Address(RVA = "0x135C30", Offset = "0x135030", VA = "0x180135C30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public float additionalLightShadowDepthBias
			{
				[Cpp2IlInjected.Token(Token = "0x60001F2")]
				[Cpp2IlInjected.Address(RVA = "0x135A50", Offset = "0x134E50", VA = "0x180135A50")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001F3")]
				[Cpp2IlInjected.Address(RVA = "0x135B90", Offset = "0x134F90", VA = "0x180135B90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public float additionalLightShadowNormalBias
			{
				[Cpp2IlInjected.Token(Token = "0x60001F4")]
				[Cpp2IlInjected.Address(RVA = "0x135A60", Offset = "0x134E60", VA = "0x180135A60")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001F5")]
				[Cpp2IlInjected.Address(RVA = "0x135BA0", Offset = "0x134FA0", VA = "0x180135BA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public float additionalLightShadowSampleBias
			{
				[Cpp2IlInjected.Token(Token = "0x60001F6")]
				[Cpp2IlInjected.Address(RVA = "0x135A70", Offset = "0x134E70", VA = "0x180135A70")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001F7")]
				[Cpp2IlInjected.Address(RVA = "0x135BB0", Offset = "0x134FB0", VA = "0x180135BB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public bool supportsSoftShadows
			{
				[Cpp2IlInjected.Token(Token = "0x60001F8")]
				[Cpp2IlInjected.Address(RVA = "0x135B70", Offset = "0x134F70", VA = "0x180135B70")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001F9")]
				[Cpp2IlInjected.Address(RVA = "0x135CD0", Offset = "0x1350D0", VA = "0x180135CD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public bool supportsDynamicBatching
			{
				[Cpp2IlInjected.Token(Token = "0x60001FA")]
				[Cpp2IlInjected.Address(RVA = "0x135B40", Offset = "0x134F40", VA = "0x180135B40")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001FB")]
				[Cpp2IlInjected.Address(RVA = "0x135CA0", Offset = "0x1350A0", VA = "0x180135CA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public bool mixedLightingSupported
			{
				[Cpp2IlInjected.Token(Token = "0x60001FC")]
				[Cpp2IlInjected.Address(RVA = "0x135AF0", Offset = "0x134EF0", VA = "0x180135AF0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001FD")]
				[Cpp2IlInjected.Address(RVA = "0x135C40", Offset = "0x135040", VA = "0x180135C40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public bool supportsUGCMeshLODs
			{
				[Cpp2IlInjected.Token(Token = "0x60001FE")]
				[Cpp2IlInjected.Address(RVA = "0x135B80", Offset = "0x134F80", VA = "0x180135B80")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001FF")]
				[Cpp2IlInjected.Address(RVA = "0x135CE0", Offset = "0x1350E0", VA = "0x180135CE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public RenderFeaturesetOption renderFeatureset
			{
				[Cpp2IlInjected.Token(Token = "0x6000200")]
				[Cpp2IlInjected.Address(RVA = "0x135B10", Offset = "0x134F10", VA = "0x180135B10")]
				[CompilerGenerated]
				get
				{
					return default(RenderFeaturesetOption);
				}
				[Cpp2IlInjected.Token(Token = "0x6000201")]
				[Cpp2IlInjected.Address(RVA = "0x135C60", Offset = "0x135060", VA = "0x180135C60")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			public PostProcessingOption postProcessing
			{
				[Cpp2IlInjected.Token(Token = "0x6000202")]
				[Cpp2IlInjected.Address(RVA = "0x135B00", Offset = "0x134F00", VA = "0x180135B00")]
				[CompilerGenerated]
				get
				{
					return default(PostProcessingOption);
				}
				[Cpp2IlInjected.Token(Token = "0x6000203")]
				[Cpp2IlInjected.Address(RVA = "0x135C50", Offset = "0x135050", VA = "0x180135C50")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x12E4BF0", Offset = "0x12E3DF0", VA = "0x1812E4BF0")]
			public static PipelineSettings Create(AgainstGravityRenderPipelineAsset asset)
			{
				return default(PipelineSettings);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private struct CameraCallbacks
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			public List<IBeforeCameraRender> beforeRenderBuffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public List<IAfterCameraRender> afterRenderBuffer;

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x135990", Offset = "0x134D90", VA = "0x180135990")]
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
			[Cpp2IlInjected.Address(RVA = "0x12DA8E0", Offset = "0x12D9AE0", VA = "0x1812DA8E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public ScriptableRenderer renderer
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x341140", Offset = "0x340340", VA = "0x180341140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x343A20", Offset = "0x342C20", VA = "0x180343A20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private PipelineSettings settings
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x12DA9D0", Offset = "0x12D9BD0", VA = "0x1812DA9D0")]
			[CompilerGenerated]
			get
			{
				return default(PipelineSettings);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x12DAC20", Offset = "0x12D9E20", VA = "0x1812DAC20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public static event RenderCallback BeforeCameraRenderEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x12DA7E0", Offset = "0x12D99E0", VA = "0x1812DA7E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x12DAB20", Offset = "0x12D9D20", VA = "0x1812DAB20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public static event RenderCallback AfterCameraRenderEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x12DA6E0", Offset = "0x12D98E0", VA = "0x1812DA6E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x12DAA20", Offset = "0x12D9C20", VA = "0x1812DAA20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x12DA3A0", Offset = "0x12D95A0", VA = "0x1812DA3A0")]
		public AgainstGravityRenderPipeline(AgainstGravityRenderPipelineAsset asset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x12D73D0", Offset = "0x12D65D0", VA = "0x1812D73D0", Slot = "8")]
		public sealed override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x12D9160", Offset = "0x12D8360", VA = "0x1812D9160", Slot = "7")]
		public override void Render(ScriptableRenderContext renderContext, Camera[] cameras)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x12D8850", Offset = "0x12D7A50", VA = "0x1812D8850")]
		public static void RenderSingleCamera(AgainstGravityRenderPipeline pipelineInstance, ScriptableRenderContext context, Camera camera, ref CullResults cullResults, AGRPAdditionalCameraData additionalCameraData, [Optional] IRendererSetup setup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x31D8C0", Offset = "0x31CAC0", VA = "0x18031D8C0")]
		private static void SetSupportedRenderingFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x12D7550", Offset = "0x12D6750", VA = "0x1812D7550")]
		private static void InitializeCameraData(PipelineSettings settings, Camera camera, AGRPAdditionalCameraData additionalCameraData, out CameraData cameraData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x12D7CC0", Offset = "0x12D6EC0", VA = "0x1812D7CC0")]
		private static void InitializeRenderingData(PipelineSettings settings, ref CameraData cameraData, ref CullResults cullResults, int maxVisibleAdditionalLights, int maxPerObjectAdditionalLights, ILightDataInterpreter lightInterpreter, out RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x12D8260", Offset = "0x12D7460", VA = "0x1812D8260")]
		private static void InitializeShadowData(PipelineSettings settings, ref LightData lightData, bool mainLightCastShadows, bool additionalLightsCastShadows, out ShadowData shadowData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x12D7B80", Offset = "0x12D6D80", VA = "0x1812D7B80")]
		private static void InitializeLightData(PipelineSettings settings, int lightCount, int mainLightIndex, int maxAdditionalLights, int maxPerObjectAdditionalLights, ref LightData lightData, ref CameraData cameraData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x12D7480", Offset = "0x12D6680", VA = "0x1812D7480")]
		private static int GetMainLight(LightRenderingMode mode, ref LightData lightData)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x12D9FC0", Offset = "0x12D91C0", VA = "0x1812D9FC0")]
		private static void SetupPerFrameShaderConstants()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x12D9C60", Offset = "0x12D8E60", VA = "0x1812D9C60")]
		private static void SetupPerCameraShaderConstants(CameraData cameraData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x12D8770", Offset = "0x12D7970", VA = "0x1812D8770")]
		public static bool IsStereoEnabled(Camera camera)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x12DA1E0", Offset = "0x12D93E0", VA = "0x1812DA1E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x324490", Offset = "0x323690", VA = "0x180324490")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool renderShadows
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x3163A0", Offset = "0x3155A0", VA = "0x1803163A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x3163E0", Offset = "0x3155E0", VA = "0x1803163E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool disableAdditionalLights
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x341130", Offset = "0x340330", VA = "0x180341130")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x3F7330", Offset = "0x3F6530", VA = "0x1803F7330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool isMainCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x4A8D20", Offset = "0x4A7F20", VA = "0x1804A8D20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x4DDFA0", Offset = "0x4DD1A0", VA = "0x1804DDFA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool forceRenderMirrors
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x9F58E0", Offset = "0x9F4AE0", VA = "0x1809F58E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x9F5D30", Offset = "0x9F4F30", VA = "0x1809F5D30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public CameraOverrideOption requiresColorOption
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x3C0CD0", Offset = "0x3BFED0", VA = "0x1803C0CD0")]
			get
			{
				return default(CameraOverrideOption);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x718970", Offset = "0x717B70", VA = "0x180718970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool IsSimpleUIViewCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x3D7BB0", Offset = "0x3D6DB0", VA = "0x1803D7BB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x511930", Offset = "0x510B30", VA = "0x180511930")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool requiresColorTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x12D4A60", Offset = "0x12D3C60", VA = "0x1812D4A60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x12D4B40", Offset = "0x12D3D40", VA = "0x1812D4B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x31D8C0", Offset = "0x31CAC0", VA = "0x18031D8C0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x12D4A20", Offset = "0x12D3C20", VA = "0x1812D4A20", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x12D4A40", Offset = "0x12D3C40", VA = "0x1812D4A40")]
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
			[Cpp2IlInjected.Address(RVA = "0x3163A0", Offset = "0x3155A0", VA = "0x1803163A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x3163E0", Offset = "0x3155E0", VA = "0x1803163E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public float shadowSampleBias
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x3485E0", Offset = "0x3477E0", VA = "0x1803485E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xA97BF0", Offset = "0xA96DF0", VA = "0x180A97BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x44AB70", Offset = "0x449D70", VA = "0x18044AB70")]
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
		[Cpp2IlInjected.Address(RVA = "0x12D4B60", Offset = "0x12D3D60", VA = "0x1812D4B60")]
		public static int GetFixedVoxelSize(RenderFeaturesetOption renderFeatureSet)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x12D4B70", Offset = "0x12D3D70", VA = "0x1812D4B70")]
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
			[Cpp2IlInjected.Address(RVA = "0x316390", Offset = "0x315590", VA = "0x180316390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x3163D0", Offset = "0x3155D0", VA = "0x1803163D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x12D50C0", Offset = "0x12D42C0", VA = "0x1812D50C0")]
		public static void UpdateBinnableLights()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x12D4BE0", Offset = "0x12D3DE0", VA = "0x1812D4BE0")]
		public static List<BinnableLight> GetCurrentBinnableLights()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x12D4B80", Offset = "0x12D3D80", VA = "0x1812D4B80")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x12D4E00", Offset = "0x12D4000", VA = "0x1812D4E00")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x12D4C40", Offset = "0x12D3E40", VA = "0x1812D4C40")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x12D5040", Offset = "0x12D4240", VA = "0x1812D5040")]
		private static void TrackLight(AGRPLight light)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x12D4EC0", Offset = "0x12D40C0", VA = "0x1812D4EC0")]
		private static void StopTrackingLight(AGRPLight light)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x12D5610", Offset = "0x12D4810", VA = "0x1812D5610")]
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
			[Cpp2IlInjected.Address(RVA = "0x3CFA60", Offset = "0x3CEC60", VA = "0x1803CFA60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public DepthTextureRenderMode depthTextureMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x371000", Offset = "0x370200", VA = "0x180371000")]
			get
			{
				return default(DepthTextureRenderMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public PostProcessingOption postProcessing
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x532680", Offset = "0x531880", VA = "0x180532680")]
			get
			{
				return default(PostProcessingOption);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool supportsCameraOpaqueTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x341110", Offset = "0x340310", VA = "0x180341110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public RenderFeaturesetOption renderFeatureset
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x541DF0", Offset = "0x540FF0", VA = "0x180541DF0")]
			get
			{
				return default(RenderFeaturesetOption);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Downsampling opaqueDownsampling
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x865CC0", Offset = "0x864EC0", VA = "0x180865CC0")]
			get
			{
				return default(Downsampling);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool supportsHDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x3FB6F0", Offset = "0x3FA8F0", VA = "0x1803FB6F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int msaaSampleCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x84EF00", Offset = "0x84E100", VA = "0x18084EF00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float renderScale
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x551430", Offset = "0x550630", VA = "0x180551430")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool supportsUGCMeshLODs
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x341170", Offset = "0x340370", VA = "0x180341170")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public LightRenderingMode mainLightRenderingMode
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x341150", Offset = "0x340350", VA = "0x180341150")]
			get
			{
				return default(LightRenderingMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool supportsMainLightShadows
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x341100", Offset = "0x340300", VA = "0x180341100")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ShadowResolution mainLightShadowmapResolution
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x64F920", Offset = "0x64EB20", VA = "0x18064F920")]
			get
			{
				return default(ShadowResolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public LightRenderingMode additionalLightsRenderingMode
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x64F910", Offset = "0x64EB10", VA = "0x18064F910")]
			get
			{
				return default(LightRenderingMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int maxAdditionalLightsCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8384C0", Offset = "0x8376C0", VA = "0x1808384C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool supportsAdditionalLightShadows
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x408620", Offset = "0x407820", VA = "0x180408620")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public ShadowResolution additionalLightsShadowmapResolution
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3CFC30", Offset = "0x3CEE30", VA = "0x1803CFC30")]
			get
			{
				return default(ShadowResolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float shadowDistance
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xDA6660", Offset = "0xDA5860", VA = "0x180DA6660")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public ShadowCascadesOption cascadeCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x36FB80", Offset = "0x36ED80", VA = "0x18036FB80")]
			get
			{
				return default(ShadowCascadesOption);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float cascade2Split
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x84FD90", Offset = "0x84EF90", VA = "0x18084FD90")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 cascade4Split
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x33DE80", Offset = "0x33D080", VA = "0x18033DE80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float mainLightShadowDepthBias
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x88F500", Offset = "0x88E700", VA = "0x18088F500")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float mainLightShadowNormalBias
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7F92B0", Offset = "0x7F84B0", VA = "0x1807F92B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float mainLightShadowSampleBias
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x949580", Offset = "0x948780", VA = "0x180949580")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float additionalLightShadowDepthBias
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7E9D00", Offset = "0x7E8F00", VA = "0x1807E9D00")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float additionalLightShadowNormalBias
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x35A810", Offset = "0x359A10", VA = "0x18035A810")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public float additionalLightShadowSampleBias
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x12D7050", Offset = "0x12D6250", VA = "0x1812D7050")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool supportsSoftShadows
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x3E5CE0", Offset = "0x3E4EE0", VA = "0x1803E5CE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool supportsDynamicBatching
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9497C0", Offset = "0x9489C0", VA = "0x1809497C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool supportsMixedLighting
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x12D73C0", Offset = "0x12D65C0", VA = "0x1812D73C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public ShaderVariantLogLevel shaderVariantLogLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x100B0D0", Offset = "0x100A2D0", VA = "0x18100B0D0")]
			get
			{
				return default(ShaderVariantLogLevel);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Shader blitShader
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x12D7060", Offset = "0x12D6260", VA = "0x1812D7060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Shader copyDepthShader
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x12D70F0", Offset = "0x12D62F0", VA = "0x1812D70F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Shader screenSpaceShadowShader
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x12D7330", Offset = "0x12D6530", VA = "0x1812D7330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public Shader samplingShader
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x12D72A0", Offset = "0x12D64A0", VA = "0x1812D72A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Shader mobileFadeEffectShader
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x12D7180", Offset = "0x12D6380", VA = "0x1812D7180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public Shader mobileVignetteEffectShader
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x12D7210", Offset = "0x12D6410", VA = "0x1812D7210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x12D6E70", Offset = "0x12D6070", VA = "0x1812D6E70", Slot = "19")]
		protected override IRenderPipeline InternalCreatePipeline()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x371B90", Offset = "0x370D90", VA = "0x180371B90")]
		private Material GetMaterial(DefaultMaterialType materialType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x371B90", Offset = "0x370D90", VA = "0x180371B90", Slot = "7")]
		public override Material GetDefaultMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x371B90", Offset = "0x370D90", VA = "0x180371B90", Slot = "11")]
		public override Material GetDefaultParticleMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x371B90", Offset = "0x370D90", VA = "0x180371B90", Slot = "12")]
		public override Material GetDefaultLineMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x371B90", Offset = "0x370D90", VA = "0x180371B90", Slot = "13")]
		public override Material GetDefaultTerrainMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x371B90", Offset = "0x370D90", VA = "0x180371B90", Slot = "14")]
		public override Material GetDefaultUIMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x371B90", Offset = "0x370D90", VA = "0x180371B90", Slot = "15")]
		public override Material GetDefaultUIOverdrawMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x371B90", Offset = "0x370D90", VA = "0x180371B90", Slot = "16")]
		public override Material GetDefaultUIETC1SupportedMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x371B90", Offset = "0x370D90", VA = "0x180371B90", Slot = "17")]
		public override Material GetDefault2DMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x12D6DD0", Offset = "0x12D5FD0", VA = "0x1812D6DD0", Slot = "18")]
		public override Shader GetDefaultShader()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x31D8C0", Offset = "0x31CAC0", VA = "0x18031D8C0", Slot = "22")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x12D6ED0", Offset = "0x12D60D0", VA = "0x1812D6ED0", Slot = "23")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x12D6F40", Offset = "0x12D6140", VA = "0x1812D6F40")]
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
			[Cpp2IlInjected.Address(RVA = "0x339B60", Offset = "0x338D60", VA = "0x180339B60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Material particleLitMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x3163C0", Offset = "0x3155C0", VA = "0x1803163C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Material terrainLitMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x316390", Offset = "0x315590", VA = "0x180316390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x36CF30", Offset = "0x36C130", VA = "0x18036CF30")]
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
			[Cpp2IlInjected.Address(RVA = "0x339B60", Offset = "0x338D60", VA = "0x180339B60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public Shader copyDepthShader
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x3163C0", Offset = "0x3155C0", VA = "0x1803163C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public Shader screenSpaceShadowShader
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x316390", Offset = "0x315590", VA = "0x180316390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public Shader samplingShader
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x3163B0", Offset = "0x3155B0", VA = "0x1803163B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public Shader mobileFadeEffectShader
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x344210", Offset = "0x343410", VA = "0x180344210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Shader mobileVignetteEffectShader
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x341140", Offset = "0x340340", VA = "0x180341140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x36CF30", Offset = "0x36C130", VA = "0x18036CF30")]
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
			[Cpp2IlInjected.Address(RVA = "0x3163C0", Offset = "0x3155C0", VA = "0x1803163C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x12DF670", Offset = "0x12DE870", VA = "0x1812DF670")]
		private IRendererSetup GetOrAssignRendererSetup(ScriptableRenderer renderer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x12DF7E0", Offset = "0x12DE9E0", VA = "0x1812DF7E0", Slot = "4")]
		public void PreCullSetup(ScriptableRenderer renderer, ScriptableRenderContext context, Camera camera, CameraData cameraData, ref LightData lightData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x12DF9E0", Offset = "0x12DEBE0", VA = "0x1812DF9E0", Slot = "5")]
		public void Setup(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x12DF600", Offset = "0x12DE800", VA = "0x1812DF600")]
		public Light GetLight(ref LightData lightData, int lightIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x12DF430", Offset = "0x12DE630", VA = "0x1812DF430")]
		public AGRPLight GetAGRPLight(ref LightData lightData, int lightIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x12DF500", Offset = "0x12DE700", VA = "0x1812DF500")]
		public int GetLightCount(ref LightData lightData)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x12DF560", Offset = "0x12DE760", VA = "0x1812DF560")]
		public bool GetLightInfo(ref LightData lightData, int lightIdx, out Vector4 pos, out Vector4 dir, out Color finalColor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x12DF3B0", Offset = "0x12DE5B0", VA = "0x1812DF3B0")]
		public int CopyToBinnableLights(ref LightData lightData, BinnableLight[] binnableLightBuffer, int maxLightCount)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x31EE50", Offset = "0x31E050", VA = "0x18031EE50")]
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
			[Cpp2IlInjected.Address(RVA = "0x135880", Offset = "0x134C80", VA = "0x180135880")]
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
		[Cpp2IlInjected.Address(RVA = "0x135890", Offset = "0x134C90", VA = "0x180135890", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x135630", Offset = "0x134A30", VA = "0x180135630", Slot = "4")]
		public void Execute(int lightIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x135370", Offset = "0x134770", VA = "0x180135370")]
		private void AddPointLightImportances(uint3 minVoxelIdx, uint3 maxVoxelIdx, ushort lightIdx, float3 lightPos, float lightIntensity, float lightRange)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x135400", Offset = "0x134800", VA = "0x180135400")]
		private void AddSpotLightImportances(uint3 minVoxelIdx, uint3 maxVoxelIdx, ushort lightIdx, float3 lightPos, float3 expandedLightPos, float3 lightForward, float lightIntensity, float lightBaseRadius, float lightRange, float expandedLightRange)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x1356D0", Offset = "0x134AD0", VA = "0x1801356D0")]
		private float PointLightIntensity(float approxIntensity)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x135640", Offset = "0x134A40", VA = "0x180135640")]
		private float LinearAttenuation(float3 voxelCenter, float3 lightPos, float lightRange)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x135500", Offset = "0x134900", VA = "0x180135500")]
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
		[Cpp2IlInjected.Address(RVA = "0x135720", Offset = "0x134B20", VA = "0x180135720", Slot = "4")]
		public void Execute(int voxelStartIdx, int voxelCapacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x135710", Offset = "0x134B10", VA = "0x180135710")]
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
		[Cpp2IlInjected.Address(RVA = "0xC0A40", Offset = "0xBFE40", VA = "0x1800C0A40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x99780", Offset = "0x98B80", VA = "0x180099780")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x99790", Offset = "0x98B90", VA = "0x180099790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x135F90", Offset = "0x135390", VA = "0x180135F90")]
		public void Init(string shaderProperty)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x135F10", Offset = "0x135310", VA = "0x180135F10")]
		public RenderTargetIdentifier Identifier()
		{
			return default(RenderTargetIdentifier);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xBDF70", Offset = "0xBD370", VA = "0x1800BDF70")]
		public bool Equals(RenderTargetHandle other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x135E90", Offset = "0x135290", VA = "0x180135E90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x99780", Offset = "0x98B80", VA = "0x180099780", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xDB6FB0", Offset = "0xDB61B0", VA = "0x180DB6FB0")]
		public static bool operator ==(RenderTargetHandle c1, RenderTargetHandle c2)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xDB6FC0", Offset = "0xDB61C0", VA = "0x180DB6FC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x23CFC80", Offset = "0x23CEE80", VA = "0x1823CFC80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int maxVisibleAdditionalLights
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x23CFC80", Offset = "0x23CEE80", VA = "0x1823CFC80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public PostProcessRenderContext postProcessingContext
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x38C020", Offset = "0x38B220", VA = "0x18038C020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x38C030", Offset = "0x38B230", VA = "0x18038C030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public RenderFeaturesetOption RendererFeatureset
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x3845D0", Offset = "0x3837D0", VA = "0x1803845D0")]
			[CompilerGenerated]
			get
			{
				return default(RenderFeaturesetOption);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x316D90", Offset = "0x315F90", VA = "0x180316D90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public ComputeBuffer perObjectLightIndices
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x3163C0", Offset = "0x3155C0", VA = "0x1803163C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x3163F0", Offset = "0x3155F0", VA = "0x1803163F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		private static Mesh fullscreenMesh
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x23CF800", Offset = "0x23CEA00", VA = "0x1823CF800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public Shader mobileFadeEffectShader
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x341140", Offset = "0x340340", VA = "0x180341140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x343A20", Offset = "0x342C20", VA = "0x180343A20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public Shader mobileVignetteEffectShader
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x337490", Offset = "0x336690", VA = "0x180337490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x360120", Offset = "0x35F320", VA = "0x180360120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x23CF360", Offset = "0x23CE560", VA = "0x1823CF360")]
		public ScriptableRenderer(AgainstGravityRenderPipelineAsset pipelineAsset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x23CE3C0", Offset = "0x23CD5C0", VA = "0x1823CE3C0")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x23CE4F0", Offset = "0x23CD6F0", VA = "0x1823CE4F0")]
		public void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x23CEAB0", Offset = "0x23CDCB0", VA = "0x1823CEAB0")]
		public Material GetMaterial(MaterialHandle handle)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x23CDFA0", Offset = "0x23CD1A0", VA = "0x1823CDFA0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x23CE490", Offset = "0x23CD690", VA = "0x1823CE490")]
		public void EnqueuePass(ScriptableRenderPass pass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x23CF020", Offset = "0x23CE220", VA = "0x1823CF020")]
		public void RenderPostProcess(CommandBuffer cmd, ref CameraData cameraData, RenderTextureFormat colorFormat, RenderTargetIdentifier source, RenderTargetIdentifier dest, bool opaqueOnly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x23CED40", Offset = "0x23CDF40", VA = "0x1823CED40")]
		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void RenderObjectsWithError(ScriptableRenderContext context, ref CullResults cullResults, Camera camera, FilterRenderersSettings filterSettings, SortFlags sortFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x23CE0E0", Offset = "0x23CD2E0", VA = "0x1823CE0E0")]
		public static RenderTextureDescriptor CreateRenderTextureDescriptor(ref CameraData cameraData, float scaler = 1f)
		{
			return default(RenderTextureDescriptor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x23CF200", Offset = "0x23CE400", VA = "0x1823CF200")]
		public static bool RequiresIntermediateColorTexture(ref CameraData cameraData, RenderTextureDescriptor baseDescriptor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x23CE9B0", Offset = "0x23CDBB0", VA = "0x1823CE9B0")]
		public static ClearFlag GetCameraClearFlag(Camera camera)
		{
			return default(ClearFlag);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x23CEBF0", Offset = "0x23CDDF0", VA = "0x1823CEBF0")]
		public static void RenderFullscreenQuad(CommandBuffer cmd, Material material, [Optional] MaterialPropertyBlock properties, int shaderPassId = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x23CDFF0", Offset = "0x23CD1F0", VA = "0x1823CDFF0")]
		public static void CopyTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier dest, Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x23CE290", Offset = "0x23CD490", VA = "0x1823CE290")]
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
		[Cpp2IlInjected.Address(RVA = "0x23CFE00", Offset = "0x23CF000", VA = "0x1823CFE00")]
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
		[Cpp2IlInjected.Address(RVA = "0x1DA3A0", Offset = "0x1D97A0", VA = "0x1801DA3A0")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public static class ShadowUtils
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x23D0470", Offset = "0x23CF670", VA = "0x1823D0470")]
		public static bool ExtractDirectionalLightMatrix(ref CullResults cullResults, ref ShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowResolution, float shadowNearPlane, out Vector4 cascadeSplitDistance, out ShadowSliceData shadowSliceData, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x23D0840", Offset = "0x23CFA40", VA = "0x1823D0840")]
		public static bool ExtractSpotLightMatrix(ref CullResults cullResults, ref ShadowData shadowData, int shadowLightIndex, out Matrix4x4 shadowMatrix, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x23D0FB0", Offset = "0x23D01B0", VA = "0x1823D0FB0")]
		public static void RenderShadowSlice(CommandBuffer cmd, ref ScriptableRenderContext context, ref ShadowSliceData shadowSliceData, ref DrawShadowsSettings settings, Matrix4x4 proj, Matrix4x4 view)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x23D0970", Offset = "0x23CFB70", VA = "0x1823D0970")]
		public static int GetMaxTileResolutionInAtlas(int atlasWidth, int atlasHeight, int tileCount)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x23D0280", Offset = "0x23CF480", VA = "0x1823D0280")]
		public static void ApplySliceTransform(ref ShadowSliceData shadowSliceData, int atlasWidth, int atlasHeight)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x23D0A10", Offset = "0x23CFC10", VA = "0x1823D0A10")]
		public static Vector4 GetShadowBias(Light shadowLight, int shadowLightIndex, ref ShadowData shadowData, Matrix4x4 lightProjectionMatrix, float shadowResolution)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x23D11A0", Offset = "0x23D03A0", VA = "0x1823D11A0")]
		public static void SetupShadowCasterConstantBuffer(CommandBuffer cmd, Light shadowLight, Vector4 shadowBias)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x23D1370", Offset = "0x23D0570", VA = "0x1823D1370")]
		[Obsolete]
		public static void SetupShadowCasterConstants(CommandBuffer cmd, ref VisibleLight visibleLight, Matrix4x4 proj, float cascadeResolution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x23D0D20", Offset = "0x23CFF20", VA = "0x1823D0D20")]
		private static Matrix4x4 GetShadowTransform(Matrix4x4 proj, Matrix4x4 view)
		{
			return default(Matrix4x4);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class VisualizeFroxelBounds : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x23D1690", Offset = "0x23D0890", VA = "0x1823D1690")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x313000", Offset = "0x312200", VA = "0x180313000")]
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
		[Cpp2IlInjected.Address(RVA = "0x23D1F60", Offset = "0x23D1160", VA = "0x1823D1F60")]
		public static uint PackIdx(uint x, uint y, uint z)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x23D24F0", Offset = "0x23D16F0", VA = "0x1823D24F0")]
		public static uint3 UnpackIdx(uint voxelIdx)
		{
			return default(uint3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x23D27A0", Offset = "0x23D19A0", VA = "0x1823D27A0")]
		public static float3 VoxelPackedIdxToCenterPosition(uint packedIdx, float3 worldVolumeMinCorner, float3 worldVolumeMaxCorner)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x23D2560", Offset = "0x23D1760", VA = "0x1823D2560")]
		public static Vector3 VoxelPackedIdxToCenterPositionVector3(uint packedIdx, Vector3 worldVolumeMinCorner, Vector3 worldVolumeMaxCorner)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x23D20F0", Offset = "0x23D12F0", VA = "0x1823D20F0")]
		public static uint3 PositionToVoxelIdxUnpacked(float3 position, float3 worldVolumeMinCorner, float3 worldVolumeMaxCorner)
		{
			return default(uint3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x23D1F70", Offset = "0x23D1170", VA = "0x1823D1F70")]
		public static Vector3 PositionToVoxelIdxUnpackedVector3(Vector3 position, Vector3 worldVolumeMin, Vector3 worldVolumeMax)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x23D22C0", Offset = "0x23D14C0", VA = "0x1823D22C0")]
		public static void SphereOverlap(float3 worldVolumeMin, float3 worldVolumeMax, float3 spherePosition, float radius, out uint3 minVoxelIndex, out uint3 maxVoxelIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x23D18E0", Offset = "0x23D0AE0", VA = "0x1823D18E0")]
		public static void ConeBoundingSphere(float3 coneOrigin, float3 coneDir, float range, float coneAngle, out float3 center, out float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x23D1DB0", Offset = "0x23D0FB0", VA = "0x1823D1DB0")]
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
		private MobileVignetteEffectPass m_mobileVignetteEffectPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private RenderOpaqueForwardPass m_RenderOpaqueForwardPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private CustomRenderEffectsPass m_customRenderEffectsPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private OpaquePostProcessPass m_OpaquePostProcessPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private DrawSkyboxPass m_DrawSkyboxPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private CopyDepthPass m_CopyDepthPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private CopyColorPass m_CopyColorPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private RenderTransparentForwardPass m_RenderTransparentForwardPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private MobileFadeEffectPass m_mobileFadeEffectPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private TransparentPostProcessPass m_TransparentPostProcessPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private FinalBlitPass m_FinalBlitPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private EndXRRenderingPass m_EndXrRenderingPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private RenderTargetHandle ColorAttachment;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private RenderTargetHandle DepthAttachment;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private RenderTargetHandle DepthTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private RenderTargetHandle OpaqueColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private RenderTargetHandle MainLightShadowmap;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private RenderTargetHandle AdditionalLightsShadowmap;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private RenderTargetHandle ScreenSpaceShadowmap;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private bool SupportsDepthTarget;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xD5")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private bool m_Initialized;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public ILightDataInterpreter LightInterpreter
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x32F4C0", Offset = "0x32E6C0", VA = "0x18032F4C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x12E6A70", Offset = "0x12E5C70", VA = "0x1812E6A70")]
		private void Init()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x12E7130", Offset = "0x12E6330", VA = "0x1812E7130", Slot = "4")]
		public void PreCullSetup(ScriptableRenderer renderer, ScriptableRenderContext context, Camera camera, CameraData cameraData, ref LightData lightData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x12E7140", Offset = "0x12E6340", VA = "0x1812E7140", Slot = "5")]
		public void Setup(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x12E60C0", Offset = "0x12E52C0", VA = "0x1812E60C0")]
		private bool CanCopyDepth(ref CameraData cameraData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x12E69A0", Offset = "0x12E5BA0", VA = "0x1812E69A0", Slot = "7")]
		public Light GetLight(ref LightData lightData, int lightIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x12E6650", Offset = "0x12E5850", VA = "0x1812E6650", Slot = "8")]
		public AGRPLight GetAGRPLight(ref LightData lightData, int lightIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x12E6780", Offset = "0x12E5980", VA = "0x1812E6780", Slot = "9")]
		public int GetLightCount(ref LightData lightData)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x12E67D0", Offset = "0x12E59D0", VA = "0x1812E67D0", Slot = "10")]
		public bool GetLightInfo(ref LightData lightData, int lightIdx, out Vector4 pos, out Vector4 dir, out Color finalColor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x12E6100", Offset = "0x12E5300", VA = "0x1812E6100", Slot = "11")]
		public int CopyToBinnableLights(ref LightData lightData, BinnableLight[] binnableLightBuffer, int maxLightCount)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x31EE50", Offset = "0x31E050", VA = "0x18031EE50")]
		public RendererSetupFullyFeatured()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class RendererSetupMobile : IRendererSetup, ILightDataInterpreter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private LightBinningPass lightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private SetupForwardRenderingPass setupForwardRenderingPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private CachedMainLightShadowCasterPass mainLightShadowCasterPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private CreateAgainstGravityRenderTexturesPass createAGRPRenderTexturesPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private BeginXRRenderingPass beginXrRenderingPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private SetupAGRPConstantsPass setupAGRPConstants;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private MobileVignetteEffectPass mobileVignetteEffectPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private RenderOpaqueForwardPass renderOpaqueForwardPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private CustomRenderEffectsPass customRenderEffectsPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private DrawSkyboxPass drawSkyboxPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private RenderTransparentForwardPass renderTransparentForwardPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private MobileFadeEffectPass mobileFadeEffectPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private EndXRRenderingPass endXrRenderingPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private RenderTargetHandle mainLightShadowmap;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private bool initialized;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public ILightDataInterpreter LightInterpreter
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x32F4C0", Offset = "0x32E6C0", VA = "0x18032F4C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x12E8110", Offset = "0x12E7310", VA = "0x1812E8110")]
		private void Init()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x12E8490", Offset = "0x12E7690", VA = "0x1812E8490", Slot = "4")]
		public void PreCullSetup(ScriptableRenderer renderer, ScriptableRenderContext context, Camera camera, CameraData cameraData, ref LightData lightData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x12E86A0", Offset = "0x12E78A0", VA = "0x1812E86A0", Slot = "5")]
		public void Setup(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x12E8030", Offset = "0x12E7230", VA = "0x1812E8030", Slot = "7")]
		public Light GetLight(ref LightData lightData, int lightIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x12E7D40", Offset = "0x12E6F40", VA = "0x1812E7D40", Slot = "8")]
		public AGRPLight GetAGRPLight(ref LightData lightData, int lightIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x12E7E50", Offset = "0x12E7050", VA = "0x1812E7E50", Slot = "9")]
		public int GetLightCount(ref LightData lightData)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x12E7EA0", Offset = "0x12E70A0", VA = "0x1812E7EA0", Slot = "10")]
		public bool GetLightInfo(ref LightData lightData, int lightIdx, out Vector4 pos, out Vector4 dir, out Color finalColor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x12E7C80", Offset = "0x12E6E80", VA = "0x1812E7C80", Slot = "11")]
		public int CopyToBinnableLights(ref LightData lightData, BinnableLight[] binnableLightBuffer, int maxLightCount)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x31EE50", Offset = "0x31E050", VA = "0x18031EE50")]
		public RendererSetupMobile()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal sealed class RendererSetupSimpleUIView : IRendererSetup
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private SetupForwardRenderingPass setupForwardRenderingPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private RenderOpaqueForwardPass renderOpaqueForwardPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private RenderTransparentForwardPass renderTransparentForwardPass;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private bool initialized;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public ILightDataInterpreter LightInterpreter
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x371B90", Offset = "0x370D90", VA = "0x180371B90", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x23CDA80", Offset = "0x23CCC80", VA = "0x1823CDA80")]
		private void Init()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x23CDA80", Offset = "0x23CCC80", VA = "0x1823CDA80", Slot = "4")]
		public void PreCullSetup(ScriptableRenderer renderer, ScriptableRenderContext context, Camera camera, CameraData cameraData, ref LightData lightData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x23CDB20", Offset = "0x23CCD20", VA = "0x1823CDB20", Slot = "5")]
		public void Setup(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x31EE50", Offset = "0x31E050", VA = "0x18031EE50")]
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
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			public static int _AdditionalLightsWorldToShadow;

			[Cpp2IlInjected.Token(Token = "0x4000210")]
			public static int _AdditionalShadowStrength;

			[Cpp2IlInjected.Token(Token = "0x4000211")]
			public static int _AdditionalShadowBias;

			[Cpp2IlInjected.Token(Token = "0x4000212")]
			public static int _AdditionalShadowOffset0;

			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public static int _AdditionalShadowOffset1;

			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public static int _AdditionalShadowOffset2;

			[Cpp2IlInjected.Token(Token = "0x4000215")]
			public static int _AdditionalShadowOffset3;

			[Cpp2IlInjected.Token(Token = "0x4000216")]
			public static int _AdditionalShadowmapSize;
		}

		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private const int k_ShadowmapBufferBits = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private RenderTexture m_AdditionalLightsShadowmapTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private RenderTextureFormat m_AdditionalShadowmapFormat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private Matrix4x4[] m_AdditionalLightShadowMatrices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private ShadowSliceData[] m_AdditionalLightSlices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private float[] m_AdditionalLightsShadowStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private float[] m_AdditionalLightsShadowSampleBias;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private List<int> m_AdditionalShadowCastingLightIndices;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private const string k_RenderAdditionalLightShadows = "Render Additional Shadows";

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		private RenderTargetHandle destination
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x64F920", Offset = "0x64EB20", VA = "0x18064F920")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x7D98E0", Offset = "0x7D8AE0", VA = "0x1807D98E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x12D6C00", Offset = "0x12D5E00", VA = "0x1812D6C00")]
		public AdditionalLightsShadowCasterPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x12D65C0", Offset = "0x12D57C0", VA = "0x1812D65C0")]
		public bool Setup(RenderTargetHandle destination, ref RenderingData renderingData, int maxVisibleAdditionalLights)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x12D5830", Offset = "0x12D4A30", VA = "0x1812D5830", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x12D58F0", Offset = "0x12D4AF0", VA = "0x1812D58F0", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x12D5630", Offset = "0x12D4830", VA = "0x1812D5630")]
		private void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x12D59B0", Offset = "0x12D4BB0", VA = "0x1812D59B0")]
		private void RenderAdditionalShadowmapAtlas(ref ScriptableRenderContext context, ref CullResults cullResults, ref LightData lightData, ref ShadowData shadowData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x12D6120", Offset = "0x12D5320", VA = "0x1812D6120")]
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
			[Cpp2IlInjected.Address(RVA = "0x12DAD50", Offset = "0x12D9F50", VA = "0x1812DAD50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x12DAE40", Offset = "0x12DA040", VA = "0x1812DAE40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x12DAC70", Offset = "0x12D9E70", VA = "0x1812DAC70", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x12DAD40", Offset = "0x12D9F40", VA = "0x1812DAD40")]
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
			[Cpp2IlInjected.Token(Token = "0x4000217")]
			public static int _WorldToShadow;

			[Cpp2IlInjected.Token(Token = "0x4000218")]
			public static int _ShadowData;

			[Cpp2IlInjected.Token(Token = "0x4000219")]
			public static int _ShadowmapSize;
		}

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private static bool isDirty;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private static int shadowCasterLayerMask;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private const string PASS_TAG_NAME = "Render Cached Main Shadowmap";

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private const int SHADOW_MAP_BUFFER_BITS = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private RenderTexture shadowmapTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private RenderTextureFormat shadowmapFormat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private Matrix4x4[] shadowMatrices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private ShadowSliceData singleCascadeSlice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private Vector4 singleCascadeDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private Vector3 lastRenderCameraPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private bool isReusingCachedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private CullResults cullResults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int mainLightIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private Light mainLight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private Vector4 shadowBias;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		private RenderTargetHandle destination
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x476D20", Offset = "0x475F20", VA = "0x180476D20")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x476FC0", Offset = "0x4761C0", VA = "0x180476FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x12DCD50", Offset = "0x12DBF50", VA = "0x1812DCD50")]
		public static void SetDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x12DCDB0", Offset = "0x12DBFB0", VA = "0x1812DCDB0")]
		public static void SetShadowCasterLayerMask(int layerMask)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x12DD560", Offset = "0x12DC760", VA = "0x1812DD560")]
		public CachedMainLightShadowCasterPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x12DC180", Offset = "0x12DB380", VA = "0x1812DC180")]
		public void PreCullSetup(ref ScriptableRenderContext context, ref CameraData cameraData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x12DD170", Offset = "0x12DC370", VA = "0x1812DD170")]
		public bool Setup(RenderTargetHandle destination, ref RenderingData renderingData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x12DBFF0", Offset = "0x12DB1F0", VA = "0x1812DBFF0", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x12DC090", Offset = "0x12DB290", VA = "0x1812DC090", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x12DBED0", Offset = "0x12DB0D0", VA = "0x1812DBED0")]
		private void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x12DC100", Offset = "0x12DB300", VA = "0x1812DC100")]
		private Vector4 GetShadowBias(Vector4 biasSettings, Matrix4x4 lightProjectionMatrix, int shadowResolution)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x12DC870", Offset = "0x12DBA70", VA = "0x1812DC870")]
		private void RenderMainLightCascadeShadowmap(ref ScriptableRenderContext context, ref ShadowData shadowData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x12DCE10", Offset = "0x12DC010", VA = "0x1812DCE10")]
		private void SetupMainLightShadowReceiverConstants(CommandBuffer cmd, ref ShadowData shadowData, Light shadowLight, float sampleBias)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class CopyColorPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private const string k_CopyColorTag = "Copy Color";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private float[] m_OpaqueScalerValues;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private int m_SampleOffsetShaderHandle;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		private RenderTargetHandle source
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x541DF0", Offset = "0x540FF0", VA = "0x180541DF0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x90BC40", Offset = "0x90AE40", VA = "0x18090BC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		private RenderTargetHandle destination
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x371000", Offset = "0x370200", VA = "0x180371000")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x4079E0", Offset = "0x406BE0", VA = "0x1804079E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x12DDCB0", Offset = "0x12DCEB0", VA = "0x1812DDCB0")]
		public CopyColorPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x12DDCA0", Offset = "0x12DCEA0", VA = "0x1812DDCA0")]
		public void Setup(RenderTargetHandle source, RenderTargetHandle destination)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x12DD760", Offset = "0x12DC960", VA = "0x1812DD760", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x12DDBA0", Offset = "0x12DCDA0", VA = "0x1812DDBA0", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class CopyDepthPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private const string k_DepthCopyTag = "Copy Depth";

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		private RenderTargetHandle source
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x4A8BF0", Offset = "0x4A7DF0", VA = "0x1804A8BF0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x575820", Offset = "0x574A20", VA = "0x180575820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		private RenderTargetHandle destination
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x343270", Offset = "0x342470", VA = "0x180343270")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x381A40", Offset = "0x380C40", VA = "0x180381A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x12DE410", Offset = "0x12DD610", VA = "0x1812DE410")]
		public void Setup(RenderTargetHandle source, RenderTargetHandle destination)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x12DDD30", Offset = "0x12DCF30", VA = "0x1812DDD30", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x12DE310", Offset = "0x12DD510", VA = "0x1812DE310", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x12DAD40", Offset = "0x12D9F40", VA = "0x1812DAD40")]
		public CopyDepthPass()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class CreateAgainstGravityRenderTexturesPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private const string k_CreateRenderTexturesTag = "Create Render Textures";

		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private const int k_DepthStencilBufferBits = 32;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		private RenderTargetHandle colorAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x4A8BF0", Offset = "0x4A7DF0", VA = "0x1804A8BF0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x575820", Offset = "0x574A20", VA = "0x180575820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		private RenderTargetHandle depthAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x343270", Offset = "0x342470", VA = "0x180343270")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x381A40", Offset = "0x380C40", VA = "0x180381A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x12DE8C0", Offset = "0x12DDAC0", VA = "0x1812DE8C0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x12DE8F0", Offset = "0x12DDAF0", VA = "0x1812DE8F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		private SampleCount samples
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x59D0D0", Offset = "0x59C2D0", VA = "0x18059D0D0")]
			[CompilerGenerated]
			get
			{
				return default(SampleCount);
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x7F7930", Offset = "0x7F6B30", VA = "0x1807F7930")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x12DE890", Offset = "0x12DDA90", VA = "0x1812DE890")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorAttachmentHandle, RenderTargetHandle depthAttachmentHandle, SampleCount samples)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x12DE420", Offset = "0x12DD620", VA = "0x1812DE420", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x12DE720", Offset = "0x12DD920", VA = "0x1812DE720", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x12DAD40", Offset = "0x12D9F40", VA = "0x1812DAD40")]
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
			[Cpp2IlInjected.Address(RVA = "0x336D40", Offset = "0x335F40", VA = "0x180336D40", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x31D8C0", Offset = "0x31CAC0", VA = "0x18031D8C0", Slot = "5")]
		public virtual void RenderPass(CommandBuffer commandBuffer, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x313000", Offset = "0x312200", VA = "0x180313000")]
		protected CustomRenderEffect()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class CustomRenderEffectsPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private static readonly List<CustomRenderEffect> executeOnNextRenderEffects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private readonly List<CustomRenderEffect> renderEffectsBuffer;

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		private RenderTargetHandle colorAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x343320", Offset = "0x342520", VA = "0x180343320")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x54B820", Offset = "0x54AA20", VA = "0x18054B820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private RenderTargetHandle depthAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x541DF0", Offset = "0x540FF0", VA = "0x180541DF0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x90BC40", Offset = "0x90AE40", VA = "0x18090BC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x12DF360", Offset = "0x12DE560", VA = "0x1812DF360")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x12DF390", Offset = "0x12DE590", VA = "0x1812DF390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool RequiresOpaqueTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x12DF1F0", Offset = "0x12DE3F0", VA = "0x1812DF1F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x12DE910", Offset = "0x12DDB10", VA = "0x1812DE910")]
		public static void EnqueueEffectForNextRender(CustomRenderEffect effect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x12DEFF0", Offset = "0x12DE1F0", VA = "0x1812DEFF0")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorHandle, RenderTargetHandle depthHandle, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x12DEC70", Offset = "0x12DDE70", VA = "0x1812DEC70", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x12DE990", Offset = "0x12DDB90", VA = "0x1812DE990")]
		private void ExecuteEffect(CustomRenderEffect renderEffect, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x12DF190", Offset = "0x12DE390", VA = "0x1812DF190")]
		public CustomRenderEffectsPass()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class DepthOnlyPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private const string k_DepthPrepassTag = "Depth Prepass";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private int kDepthBufferBits;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private RenderTargetHandle depthAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x343270", Offset = "0x342470", VA = "0x180343270")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x381A40", Offset = "0x380C40", VA = "0x180381A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		internal RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x12DE8C0", Offset = "0x12DDAC0", VA = "0x1812DE8C0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x12DE8F0", Offset = "0x12DDAF0", VA = "0x1812DE8F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		private FilterRenderersSettings opaqueFilterSettings
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x12E0210", Offset = "0x12DF410", VA = "0x1812E0210")]
			[CompilerGenerated]
			get
			{
				return default(FilterRenderersSettings);
			}
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x12E0230", Offset = "0x12DF430", VA = "0x1812E0230")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x12E0170", Offset = "0x12DF370", VA = "0x1812E0170")]
		public DepthOnlyPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x12E00E0", Offset = "0x12DF2E0", VA = "0x1812E00E0")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle depthAttachmentHandle, SampleCount samples)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x12DFB00", Offset = "0x12DED00", VA = "0x1812DFB00", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x12DFFE0", Offset = "0x12DF1E0", VA = "0x1812DFFE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4A8BF0", Offset = "0x4A7DF0", VA = "0x1804A8BF0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x575820", Offset = "0x574A20", VA = "0x180575820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		private RenderTargetHandle depthAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x343270", Offset = "0x342470", VA = "0x180343270")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x381A40", Offset = "0x380C40", VA = "0x180381A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x12DE410", Offset = "0x12DD610", VA = "0x1812DE410")]
		public void Setup(RenderTargetHandle colorHandle, RenderTargetHandle depthHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x12E0240", Offset = "0x12DF440", VA = "0x1812E0240", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x12DAD40", Offset = "0x12D9F40", VA = "0x1812DAD40")]
		public DrawSkyboxPass()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class EndXRRenderingPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x12E05D0", Offset = "0x12DF7D0", VA = "0x1812E05D0", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x12DAD40", Offset = "0x12D9F40", VA = "0x1812DAD40")]
		public EndXRRenderingPass()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class FinalBlitPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private const string k_FinalBlitTag = "Final Blit Pass";

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		private RenderTargetHandle colorAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x4A8BF0", Offset = "0x4A7DF0", VA = "0x1804A8BF0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x575820", Offset = "0x574A20", VA = "0x180575820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x12E0B10", Offset = "0x12DFD10", VA = "0x1812E0B10")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x12E0B40", Offset = "0x12DFD40", VA = "0x1812E0B40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x12E0AE0", Offset = "0x12DFCE0", VA = "0x1812E0AE0")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorAttachmentHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x12E0670", Offset = "0x12DF870", VA = "0x1812E0670", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x12DAD40", Offset = "0x12D9F40", VA = "0x1812DAD40")]
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
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			public static readonly int VoxelBuffer;

			[Cpp2IlInjected.Token(Token = "0x400021B")]
			public static readonly int VoxelVolumeWorldOriginPreMultiplied;

			[Cpp2IlInjected.Token(Token = "0x400021C")]
			public static readonly int WorldSpaceToVoxelCoefficients;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private ComputeBuffer _VoxelBufferGPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private CalculateVoxelPoints _calculateVoxelPointsJob;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private BinPerLightJob _binPerLightJob;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private BinPerVoxelJob _binPerVoxelJob;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private NativeMultiHashMap<ushort, LightInBin> _lightBinBuffer0;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private NativeMultiHashMap<ushort, LightInBin> _lightBinBuffer1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private bool _frontBackSwitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private float3 voxelVolumeMinCorner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private float3 voxelVolumeMaxCorner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private NativeArray<uint> _voxelBufferCPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private NativeArray<float> _lightImportancesPerVoxel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private NativeArray<float3> _voxelPoints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private NativeArray<BinnableLight> _binnableLights;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private BinnableLight[] _binnableLightsBuffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private JobHandle _jobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private JobHandle _backBufferClearHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private ClearBufferJob<ushort, LightInBin> _clearBackBufferJob;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private bool _isCompleted;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		private NativeMultiHashMap<ushort, LightInBin> FrontBuffer
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x12E1B40", Offset = "0x12E0D40", VA = "0x1812E1B40")]
			get
			{
				return default(NativeMultiHashMap<ushort, LightInBin>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		private NativeMultiHashMap<ushort, LightInBin> BackBuffer
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x12E1B10", Offset = "0x12E0D10", VA = "0x1812E1B10")]
			get
			{
				return default(NativeMultiHashMap<ushort, LightInBin>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x12E10C0", Offset = "0x12E02C0", VA = "0x1812E10C0")]
		private void SetupPersistentBuffers(RenderFeaturesetOption featureset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x12E1020", Offset = "0x12E0220", VA = "0x1812E1020")]
		private static void RunAtQuit(Action quitFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xE52680", Offset = "0xE51880", VA = "0x180E52680")]
		private void ResizePersistentArray<T>(ref NativeArray<T> array, int size) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x12E1210", Offset = "0x12E0410", VA = "0x1812E1210")]
		public JobHandle StartLightBin(CameraData cameraData, RenderFeaturesetOption featureset, ref LightData lightData)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x12E0BE0", Offset = "0x12DFDE0", VA = "0x1812E0BE0")]
		private void CompleteFrameJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x12E0B60", Offset = "0x12DFD60", VA = "0x1812E0B60")]
		private void CleanupFrameData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x12E0C10", Offset = "0x12DFE10", VA = "0x1812E0C10", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x12DAD40", Offset = "0x12D9F40", VA = "0x1812DAD40")]
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
			[Cpp2IlInjected.Token(Token = "0x400021F")]
			public static int _WorldToShadow;

			[Cpp2IlInjected.Token(Token = "0x4000220")]
			public static int _ShadowData;

			[Cpp2IlInjected.Token(Token = "0x4000221")]
			public static int _CascadeShadowSplitSpheres0;

			[Cpp2IlInjected.Token(Token = "0x4000222")]
			public static int _CascadeShadowSplitSpheres1;

			[Cpp2IlInjected.Token(Token = "0x4000223")]
			public static int _CascadeShadowSplitSpheres2;

			[Cpp2IlInjected.Token(Token = "0x4000224")]
			public static int _CascadeShadowSplitSpheres3;

			[Cpp2IlInjected.Token(Token = "0x4000225")]
			public static int _CascadeShadowSplitSphereRadii;

			[Cpp2IlInjected.Token(Token = "0x4000226")]
			public static int _ShadowOffset0;

			[Cpp2IlInjected.Token(Token = "0x4000227")]
			public static int _ShadowOffset1;

			[Cpp2IlInjected.Token(Token = "0x4000228")]
			public static int _ShadowOffset2;

			[Cpp2IlInjected.Token(Token = "0x4000229")]
			public static int _ShadowOffset3;

			[Cpp2IlInjected.Token(Token = "0x400022A")]
			public static int _ShadowmapSize;
		}

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private const int k_MaxCascades = 4;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private const int k_ShadowmapBufferBits = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private int m_ShadowCasterCascadesCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private RenderTexture m_MainLightShadowmapTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private RenderTextureFormat m_ShadowmapFormat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private Matrix4x4[] m_MainLightShadowMatrices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private ShadowSliceData[] m_CascadeSlices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private Vector4[] m_CascadeSplitDistances;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private const string k_RenderMainLightShadowmapTag = "Render Main Shadowmap";

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		private RenderTargetHandle destination
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x341150", Offset = "0x340350", VA = "0x180341150")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x341190", Offset = "0x340390", VA = "0x180341190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x12E3040", Offset = "0x12E2240", VA = "0x1812E3040")]
		public MainLightShadowCasterPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x12E2DA0", Offset = "0x12E1FA0", VA = "0x1812E2DA0")]
		public bool Setup(RenderTargetHandle destination, ref RenderingData renderingData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x12E1D90", Offset = "0x12E0F90", VA = "0x1812E1D90", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x12E1E40", Offset = "0x12E1040", VA = "0x1812E1E40", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x12E1B70", Offset = "0x12E0D70", VA = "0x1812E1B70")]
		private void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x12E1F00", Offset = "0x12E1100", VA = "0x1812E1F00")]
		private void RenderMainLightCascadeShadowmap(ref ScriptableRenderContext context, ref CullResults cullResults, ref LightData lightData, ref ShadowData shadowData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x12E25E0", Offset = "0x12E17E0", VA = "0x1812E25E0")]
		private void SetupMainLightShadowReceiverConstants(CommandBuffer cmd, ref ShadowData shadowData, Light shadowLight, float sampleBias)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public abstract class MobileComfortEffectPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		protected const float QUAD_SCALE_FUDGE_FACTOR = 1.1f;

		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		protected const float QUAD_LEFT_X_OUTER = -0.5f;

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		protected const float QUAD_RIGHT_X_OUTER = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		protected const float QUAD_BOTTOM_Y_OUTER = -0.5f;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		protected const float QUAD_TOP_Y_OUTER = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		protected const float QUAD_LEFT_U_OUTER = 0f;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		protected const float QUAD_RIGHT_U_OUTER = 1f;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		protected const float QUAD_BOTTOM_V_OUTER = 0f;

		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		protected const float QUAD_TOP_V_OUTER = 1f;

		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private static Mesh _worldSpaceQuadMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private Material _effectMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		protected Shader effectShader;

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public static bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x12E3C10", Offset = "0x12E2E10", VA = "0x1812E3C10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected static Mesh WorldSpaceQuadMesh
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x12E3CA0", Offset = "0x12E2EA0", VA = "0x1812E3CA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected Material EffectMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x12E3AD0", Offset = "0x12E2CD0", VA = "0x1812E3AD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x12E3800", Offset = "0x12E2A00", VA = "0x1812E3800")]
		protected static Matrix4x4 GetWorldSpaceQuadTRSMatrix(Camera camera, bool scaleUniformly = false)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x12E3260", Offset = "0x12E2460", VA = "0x1812E3260")]
		private static Mesh CreateWorldSpaceQuadMesh()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x12DAD40", Offset = "0x12D9F40", VA = "0x1812DAD40")]
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
			[Cpp2IlInjected.Token(Token = "0x400022B")]
			public float fadeEffect;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400022C")]
			public float monochromeReplacementEffect;
		}

		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private static readonly int FADE_ID;

		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public static Settings CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private const string k_PostProcessingTag = "Render Mobile Fade Effect";

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x12E41D0", Offset = "0x12E33D0", VA = "0x1812E41D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x12E4090", Offset = "0x12E3290", VA = "0x1812E4090")]
		public bool Setup(Shader effectShader)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x12E3D90", Offset = "0x12E2F90", VA = "0x1812E3D90", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x12E4170", Offset = "0x12E3370", VA = "0x1812E4170")]
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
			[Cpp2IlInjected.Token(Token = "0x400022D")]
			public float vignettePowerNormalized;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400022E")]
			public Color vignetteColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400022F")]
			public Mesh vignetteMesh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000230")]
			public AnimationCurve vignetteIntensityCurve;
		}

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static readonly int POWER_ID;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private static readonly int COLOR_ID;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public static Settings CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private const string k_PostProcessingTag = "Render Mobile Vignette Effect";

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		private RenderTargetHandle colorAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x371000", Offset = "0x370200", VA = "0x180371000")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x4079E0", Offset = "0x406BE0", VA = "0x1804079E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		private RenderTargetHandle depthAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x532680", Offset = "0x531880", VA = "0x180532680")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x532750", Offset = "0x531950", VA = "0x180532750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x12E4940", Offset = "0x12E3B40", VA = "0x1812E4940")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x12E4980", Offset = "0x12E3B80", VA = "0x1812E4980")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		private ClearFlag clearFlag
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x3C7A00", Offset = "0x3C6C00", VA = "0x1803C7A00")]
			[CompilerGenerated]
			get
			{
				return default(ClearFlag);
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x11C8000", Offset = "0x11C7200", VA = "0x1811C8000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		private Color clearColor
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x12E4930", Offset = "0x12E3B30", VA = "0x1812E4930")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x12E4970", Offset = "0x12E3B70", VA = "0x1812E4970")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x12E46C0", Offset = "0x12E38C0", VA = "0x1812E46C0")]
		public bool Setup(Shader effectShader, RenderTextureDescriptor descriptor, RenderTargetHandle colorAttachmentHandle, RenderTargetHandle depthAttachmentHandle, ClearFlag clearFlag, Color clearColor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x12E4280", Offset = "0x12E3480", VA = "0x1812E4280", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x12E48D0", Offset = "0x12E3AD0", VA = "0x1812E48D0")]
		public MobileVignetteEffectPass()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class OpaquePostProcessPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private const string k_OpaquePostProcessTag = "Render Opaque PostProcess Effects";

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		private RenderTargetHandle colorAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x4A8BF0", Offset = "0x4A7DF0", VA = "0x1804A8BF0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x575820", Offset = "0x574A20", VA = "0x180575820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x12E0B10", Offset = "0x12DFD10", VA = "0x1812E0B10")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x12E0B40", Offset = "0x12DFD40", VA = "0x1812E0B40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x12E0AE0", Offset = "0x12DFCE0", VA = "0x1812E0AE0")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorAttachmentHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x12E49A0", Offset = "0x12E3BA0", VA = "0x1812E49A0", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x12DAD40", Offset = "0x12D9F40", VA = "0x1812DAD40")]
		public OpaquePostProcessPass()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class RenderOpaqueForwardPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private const string k_RenderOpaquesTag = "Render Opaques";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private FilterRenderersSettings m_OpaqueFilterSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private RendererConfiguration rendererConfiguration;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		private RenderTargetHandle colorAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x532680", Offset = "0x531880", VA = "0x180532680")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x532750", Offset = "0x531950", VA = "0x180532750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		private RenderTargetHandle depthAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x40A860", Offset = "0x409A60", VA = "0x18040A860")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x6321F0", Offset = "0x6313F0", VA = "0x1806321F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x12E5A40", Offset = "0x12E4C40", VA = "0x1812E5A40")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x12E5A80", Offset = "0x12E4C80", VA = "0x1812E5A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		private ClearFlag clearFlag
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x3CFC30", Offset = "0x3CEE30", VA = "0x1803CFC30")]
			[CompilerGenerated]
			get
			{
				return default(ClearFlag);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x71EAE0", Offset = "0x71DCE0", VA = "0x18071EAE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		private Color clearColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x12E5A30", Offset = "0x12E4C30", VA = "0x1812E5A30")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x12E5A70", Offset = "0x12E4C70", VA = "0x1812E5A70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x12E5990", Offset = "0x12E4B90", VA = "0x1812E5990")]
		public RenderOpaqueForwardPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x12E58C0", Offset = "0x12E4AC0", VA = "0x1812E58C0")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorAttachmentHandle, RenderTargetHandle depthAttachmentHandle, ClearFlag clearFlag, Color clearColor, RendererConfiguration configuration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x12E53A0", Offset = "0x12E45A0", VA = "0x1812E53A0", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class RenderTransparentForwardPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private const string k_RenderTransparentsTag = "Render Transparents";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private FilterRenderersSettings m_TransparentFilterSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private RendererConfiguration rendererConfiguration;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		private RenderTargetHandle colorAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x532680", Offset = "0x531880", VA = "0x180532680")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x532750", Offset = "0x531950", VA = "0x180532750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		private RenderTargetHandle depthAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x40A860", Offset = "0x409A60", VA = "0x18040A860")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x6321F0", Offset = "0x6313F0", VA = "0x1806321F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x12E5A40", Offset = "0x12E4C40", VA = "0x1812E5A40")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x12E5A80", Offset = "0x12E4C80", VA = "0x1812E5A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x12E6010", Offset = "0x12E5210", VA = "0x1812E6010")]
		public RenderTransparentForwardPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x12E5FE0", Offset = "0x12E51E0", VA = "0x1812E5FE0")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorAttachmentHandle, RenderTargetHandle depthAttachmentHandle, RendererConfiguration configuration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x12E5AE0", Offset = "0x12E4CE0", VA = "0x1812E5AE0", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class SceneViewDepthCopyPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private const string k_CopyDepthToCameraTag = "Copy Depth to Camera";

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		private RenderTargetHandle source
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x4A8BF0", Offset = "0x4A7DF0", VA = "0x1804A8BF0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x575820", Offset = "0x574A20", VA = "0x180575820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x575820", Offset = "0x574A20", VA = "0x180575820")]
		public void Setup(RenderTargetHandle source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x12E8C70", Offset = "0x12E7E70", VA = "0x1812E8C70", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x12DAD40", Offset = "0x12D9F40", VA = "0x1812DAD40")]
		public SceneViewDepthCopyPass()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class ScreenSpaceShadowResolvePass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private const string k_CollectShadowsTag = "Collect Shadows";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private RenderTextureFormat m_ColorFormat;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		private RenderTargetHandle colorAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x343270", Offset = "0x342470", VA = "0x180343270")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x381A40", Offset = "0x380C40", VA = "0x180381A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x12DE8C0", Offset = "0x12DDAC0", VA = "0x1812DE8C0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x12DE8F0", Offset = "0x12DDAF0", VA = "0x1812DE8F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x12E9440", Offset = "0x12E8640", VA = "0x1812E9440")]
		public ScreenSpaceShadowResolvePass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x12E93E0", Offset = "0x12E85E0", VA = "0x1812E93E0")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorAttachmentHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x12E8FC0", Offset = "0x12E81C0", VA = "0x1812E8FC0", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x12E92E0", Offset = "0x12E84E0", VA = "0x1812E92E0", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public abstract class ScriptableRenderPass
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private List<ShaderPassName> m_ShaderPassNames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public readonly string PassName;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x12E9A20", Offset = "0x12E8C20", VA = "0x1812E9A20")]
		public ScriptableRenderPass()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x31D8C0", Offset = "0x31CAC0", VA = "0x18031D8C0", Slot = "4")]
		public virtual void FrameCleanup(CommandBuffer cmd)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData);

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x12E9650", Offset = "0x12E8850", VA = "0x1812E9650")]
		protected void RegisterShaderPassName(string passName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x12E9480", Offset = "0x12E8680", VA = "0x1812E9480")]
		protected DrawRendererSettings CreateDrawRendererSettings(Camera camera, SortFlags sortFlags, RendererConfiguration rendererConfiguration, bool supportsDynamicBatching)
		{
			return default(DrawRendererSettings);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x12E96D0", Offset = "0x12E88D0", VA = "0x1812E96D0")]
		protected static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorAttachment, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, ClearFlag clearFlags, Color clearColor, TextureDimension dimension)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x12E9830", Offset = "0x12E8A30", VA = "0x1812E9830")]
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
			[Cpp2IlInjected.Token(Token = "0x4000231")]
			public static readonly int MainLightPosition;

			[Cpp2IlInjected.Token(Token = "0x4000232")]
			public static readonly int MainLightColor;

			[Cpp2IlInjected.Token(Token = "0x4000233")]
			public static readonly int AdditionalLightsCount;

			[Cpp2IlInjected.Token(Token = "0x4000234")]
			public static readonly int AdditionalLightsPosition;

			[Cpp2IlInjected.Token(Token = "0x4000235")]
			public static readonly int AdditionalLightsColor;

			[Cpp2IlInjected.Token(Token = "0x4000236")]
			public static readonly int AdditionalLightsAttenuation;

			[Cpp2IlInjected.Token(Token = "0x4000237")]
			public static readonly int AdditionalLightsSpotDir;
		}

		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private const string k_SetupLightConstants = "Setup Light Constants";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private MixedLightingSetup m_MixedLightingSetup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private Vector4 k_DefaultLightPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private Vector4 k_DefaultLightColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private Vector4 k_DefaultLightAttenuation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private Vector4 k_DefaultLightSpotDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private Vector4[] m_AdditionalLightPositions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private Vector4[] m_AdditionalLightColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private Vector4[] m_AdditionalLightAttenuations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private Vector4[] m_AdditionalLightSpotDirections;

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x12E9E40", Offset = "0x12E9040", VA = "0x1812E9E40")]
		private void InitializeLightConstants(ref LightData lightData, int lightIndex, out Vector4 lightPos, out Vector4 lightColor, out Vector4 lightAttenuation, out Vector4 lightSpotDir)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x12EA960", Offset = "0x12E9B60", VA = "0x1812EA960")]
		private void SetupShaderLightConstants(CommandBuffer cmd, ScriptableRenderer renderer, ref LightData lightData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x12EA830", Offset = "0x12E9A30", VA = "0x1812EA830")]
		private void SetupMainLightConstants(CommandBuffer cmd, ref LightData lightData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x12EA370", Offset = "0x12E9570", VA = "0x1812EA370")]
		private void SetupAdditionalLightConstants(CommandBuffer cmd, int maxLightCount, ref LightData lightData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x12E9AB0", Offset = "0x12E8CB0", VA = "0x1812E9AB0", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x12EAAC0", Offset = "0x12E9CC0", VA = "0x1812EAAC0")]
		public SetupAGRPConstantsPass()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class SetupForwardRenderingPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x12EABE0", Offset = "0x12E9DE0", VA = "0x1812EABE0", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x12DAD40", Offset = "0x12D9F40", VA = "0x1812DAD40")]
		public SetupForwardRenderingPass()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class TransparentPostProcessPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private const string k_PostProcessingTag = "Render PostProcess Effects";

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		private RenderTargetHandle colorAttachmentHandle
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x4A8BF0", Offset = "0x4A7DF0", VA = "0x1804A8BF0")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x575820", Offset = "0x574A20", VA = "0x180575820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private RenderTextureDescriptor descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x12E0B10", Offset = "0x12DFD10", VA = "0x1812E0B10")]
			[CompilerGenerated]
			get
			{
				return default(RenderTextureDescriptor);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x12E0B40", Offset = "0x12DFD40", VA = "0x1812E0B40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		private RenderTargetIdentifier destination
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x12EB020", Offset = "0x12EA220", VA = "0x1812EB020")]
			[CompilerGenerated]
			get
			{
				return default(RenderTargetIdentifier);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x12EB040", Offset = "0x12EA240", VA = "0x1812EB040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x12EAFE0", Offset = "0x12EA1E0", VA = "0x1812EAFE0")]
		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorAttachmentHandle, RenderTargetIdentifier destination)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x12EADF0", Offset = "0x12E9FF0", VA = "0x1812EADF0", Slot = "5")]
		public override void Execute(ScriptableRenderer renderer, ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x12DAD40", Offset = "0x12D9F40", VA = "0x1812DAD40")]
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
