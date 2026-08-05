using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityStandardAssets.CinematicEffects
{
	[ImageEffectAllowedInSceneView]
	[AddComponentMenu("Image Effects/Anti-aliasing")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class AntiAliasing : MonoBehaviour
	{
		public enum Method
		{
			Smaa,
			Fxaa
		}

		[SerializeField]
		private SMAA m_SMAA = new SMAA();

		[SerializeField]
		private FXAA m_FXAA = new FXAA();

		[SerializeField]
		[HideInInspector]
		private int m_Method;

		private Camera m_Camera;

		public int method
		{
			get
			{
				return m_Method;
			}
			set
			{
				if (m_Method != value)
				{
					m_Method = value;
				}
			}
		}

		public IAntiAliasing current
		{
			get
			{
				if (method == 0)
				{
					return m_SMAA;
				}
				return m_FXAA;
			}
		}

		public Camera cameraComponent
		{
			get
			{
				if (m_Camera == null)
				{
					m_Camera = GetComponent<Camera>();
				}
				return m_Camera;
			}
		}

		private void OnEnable()
		{
			m_SMAA.OnEnable(this);
			m_FXAA.OnEnable(this);
		}

		private void OnDisable()
		{
			m_SMAA.OnDisable();
			m_FXAA.OnDisable();
		}

		private void OnPreCull()
		{
			current.OnPreCull(cameraComponent);
		}

		private void OnPostRender()
		{
			current.OnPostRender(cameraComponent);
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			current.OnRenderImage(cameraComponent, source, destination);
		}
	}
	[Serializable]
	public class FXAA : IAntiAliasing
	{
		[Serializable]
		public struct QualitySettings
		{
			[Tooltip("The amount of desired sub-pixel aliasing removal. Effects the sharpeness of the output.")]
			[Range(0f, 1f)]
			public float subpixelAliasingRemovalAmount;

			[Range(0.063f, 0.333f)]
			[Tooltip("The minimum amount of local contrast required to qualify a region as containing an edge.")]
			public float edgeDetectionThreshold;

			[Tooltip("Local contrast adaptation value to disallow the algorithm from executing on the darker regions.")]
			[Range(0f, 0.0833f)]
			public float minimumRequiredLuminance;
		}

		[Serializable]
		public struct ConsoleSettings
		{
			[Range(0.33f, 0.5f)]
			[Tooltip("The amount of spread applied to the sampling coordinates while sampling for subpixel information.")]
			public float subpixelSpreadAmount;

			[Tooltip("This value dictates how sharp the edges in the image are kept; a higher value implies sharper edges.")]
			[Range(2f, 8f)]
			public float edgeSharpnessAmount;

			[Tooltip("The minimum amount of local contrast required to qualify a region as containing an edge.")]
			[Range(0.125f, 0.25f)]
			public float edgeDetectionThreshold;

			[Range(0.04f, 0.06f)]
			[Tooltip("Local contrast adaptation value to disallow the algorithm from executing on the darker regions.")]
			public float minimumRequiredLuminance;
		}

		[Serializable]
		public struct Preset
		{
			[AttributeUsage(AttributeTargets.Field)]
			public class LayoutAttribute : PropertyAttribute
			{
			}

			[Layout]
			public QualitySettings qualitySettings;

			[Layout]
			public ConsoleSettings consoleSettings;

			private static readonly Preset s_ExtremePerformance = new Preset
			{
				qualitySettings = new QualitySettings
				{
					subpixelAliasingRemovalAmount = 0f,
					edgeDetectionThreshold = 0.333f,
					minimumRequiredLuminance = 0.0833f
				},
				consoleSettings = new ConsoleSettings
				{
					subpixelSpreadAmount = 0.33f,
					edgeSharpnessAmount = 8f,
					edgeDetectionThreshold = 0.25f,
					minimumRequiredLuminance = 0.06f
				}
			};

			private static readonly Preset s_Performance = new Preset
			{
				qualitySettings = new QualitySettings
				{
					subpixelAliasingRemovalAmount = 0.25f,
					edgeDetectionThreshold = 0.25f,
					minimumRequiredLuminance = 0.0833f
				},
				consoleSettings = new ConsoleSettings
				{
					subpixelSpreadAmount = 0.33f,
					edgeSharpnessAmount = 8f,
					edgeDetectionThreshold = 0.125f,
					minimumRequiredLuminance = 0.06f
				}
			};

			private static readonly Preset s_Default = new Preset
			{
				qualitySettings = new QualitySettings
				{
					subpixelAliasingRemovalAmount = 0.75f,
					edgeDetectionThreshold = 0.166f,
					minimumRequiredLuminance = 0.0833f
				},
				consoleSettings = new ConsoleSettings
				{
					subpixelSpreadAmount = 0.5f,
					edgeSharpnessAmount = 8f,
					edgeDetectionThreshold = 0.125f,
					minimumRequiredLuminance = 0.05f
				}
			};

			private static readonly Preset s_Quality = new Preset
			{
				qualitySettings = new QualitySettings
				{
					subpixelAliasingRemovalAmount = 1f,
					edgeDetectionThreshold = 0.125f,
					minimumRequiredLuminance = 0.0625f
				},
				consoleSettings = new ConsoleSettings
				{
					subpixelSpreadAmount = 0.5f,
					edgeSharpnessAmount = 4f,
					edgeDetectionThreshold = 0.125f,
					minimumRequiredLuminance = 0.04f
				}
			};

			private static readonly Preset s_ExtremeQuality = new Preset
			{
				qualitySettings = new QualitySettings
				{
					subpixelAliasingRemovalAmount = 1f,
					edgeDetectionThreshold = 0.063f,
					minimumRequiredLuminance = 0.0312f
				},
				consoleSettings = new ConsoleSettings
				{
					subpixelSpreadAmount = 0.5f,
					edgeSharpnessAmount = 2f,
					edgeDetectionThreshold = 0.125f,
					minimumRequiredLuminance = 0.04f
				}
			};

			public static Preset extremePerformancePreset => s_ExtremePerformance;

			public static Preset performancePreset => s_Performance;

			public static Preset defaultPreset => s_Default;

			public static Preset qualityPreset => s_Quality;

			public static Preset extremeQualityPreset => s_ExtremeQuality;
		}

		private Shader m_Shader;

		private Material m_Material;

		[HideInInspector]
		[SerializeField]
		public Preset preset = Preset.defaultPreset;

		public static Preset[] availablePresets = new Preset[5]
		{
			Preset.extremePerformancePreset,
			Preset.performancePreset,
			Preset.defaultPreset,
			Preset.qualityPreset,
			Preset.extremeQualityPreset
		};

		private Shader shader
		{
			get
			{
				if (m_Shader == null)
				{
					m_Shader = Shader.Find("Hidden/Fast Approximate Anti-aliasing");
				}
				return m_Shader;
			}
		}

		public Material material
		{
			get
			{
				if (m_Material == null)
				{
					m_Material = ImageEffectHelper.CheckShaderAndCreateMaterial(shader);
				}
				return m_Material;
			}
		}

		public bool validSourceFormat { get; private set; }

		public void OnEnable(AntiAliasing owner)
		{
			if (!ImageEffectHelper.IsSupported(shader, needDepth: true, needHdr: false, owner))
			{
				owner.enabled = false;
			}
		}

		public void OnDisable()
		{
			if (m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(m_Material);
			}
		}

		public void OnPreCull(Camera camera)
		{
		}

		public void OnPostRender(Camera camera)
		{
		}

		public void OnRenderImage(Camera camera, RenderTexture source, RenderTexture destination)
		{
			material.SetVector("_QualitySettings", new Vector3(preset.qualitySettings.subpixelAliasingRemovalAmount, preset.qualitySettings.edgeDetectionThreshold, preset.qualitySettings.minimumRequiredLuminance));
			material.SetVector("_ConsoleSettings", new Vector4(preset.consoleSettings.subpixelSpreadAmount, preset.consoleSettings.edgeSharpnessAmount, preset.consoleSettings.edgeDetectionThreshold, preset.consoleSettings.minimumRequiredLuminance));
			Graphics.Blit(source, destination, material, 0);
		}
	}
	public interface IAntiAliasing
	{
		void OnEnable(AntiAliasing owner);

		void OnDisable();

		void OnPreCull(Camera camera);

		void OnPostRender(Camera camera);

		void OnRenderImage(Camera camera, RenderTexture source, RenderTexture destination);
	}
	[Serializable]
	public class SMAA : IAntiAliasing
	{
		[AttributeUsage(AttributeTargets.Field)]
		public class SettingsGroup : Attribute
		{
		}

		[AttributeUsage(AttributeTargets.Field)]
		public class TopLevelSettings : Attribute
		{
		}

		[AttributeUsage(AttributeTargets.Field)]
		public class ExperimentalGroup : Attribute
		{
		}

		public enum DebugPass
		{
			Off,
			Edges,
			Weights,
			Accumulation
		}

		public enum QualityPreset
		{
			Low,
			Medium,
			High,
			Ultra,
			Custom
		}

		public enum EdgeDetectionMethod
		{
			Luma = 1,
			Color,
			Depth
		}

		[Serializable]
		public struct GlobalSettings
		{
			[Tooltip("Use this to fine tune your settings when working in Custom quality mode. \"Accumulation\" only works when \"Temporal Filtering\" is enabled.")]
			public DebugPass debugPass;

			[Tooltip("Low: 60% of the quality.\nMedium: 80% of the quality.\nHigh: 95% of the quality.\nUltra: 99% of the quality (overkill).")]
			public QualityPreset quality;

			[Tooltip("You've three edge detection methods to choose from: luma, color or depth.\nThey represent different quality/performance and anti-aliasing/sharpness tradeoffs, so our recommendation is for you to choose the one that best suits your particular scenario:\n\n- Depth edge detection is usually the fastest but it may miss some edges.\n- Luma edge detection is usually more expensive than depth edge detection, but catches visible edges that depth edge detection can miss.\n- Color edge detection is usually the most expensive one but catches chroma-only edges.")]
			public EdgeDetectionMethod edgeDetectionMethod;

			public static GlobalSettings defaultSettings => new GlobalSettings
			{
				debugPass = DebugPass.Off,
				quality = QualityPreset.High,
				edgeDetectionMethod = EdgeDetectionMethod.Color
			};
		}

		[Serializable]
		public struct QualitySettings
		{
			[Tooltip("Enables/Disables diagonal processing.")]
			public bool diagonalDetection;

			[Tooltip("Enables/Disables corner detection. Leave this on to avoid blurry corners.")]
			public bool cornerDetection;

			[Tooltip("Specifies the threshold or sensitivity to edges. Lowering this value you will be able to detect more edges at the expense of performance.\n0.1 is a reasonable value, and allows to catch most visible edges. 0.05 is a rather overkill value, that allows to catch 'em all.")]
			[Range(0f, 0.5f)]
			public float threshold;

			[Min(0.0001f)]
			[Tooltip("Specifies the threshold for depth edge detection. Lowering this value you will be able to detect more edges at the expense of performance.")]
			public float depthThreshold;

			[Range(0f, 112f)]
			[Tooltip("Specifies the maximum steps performed in the horizontal/vertical pattern searches, at each side of the pixel.\nIn number of pixels, it's actually the double. So the maximum line length perfectly handled by, for example 16, is 64 (by perfectly, we meant that longer lines won't look as good, but still antialiased).")]
			public int maxSearchSteps;

			[Tooltip("Specifies the maximum steps performed in the diagonal pattern searches, at each side of the pixel. In this case we jump one pixel at time, instead of two.\nOn high-end machines it is cheap (between a 0.8x and 0.9x slower for 16 steps), but it can have a significant impact on older machines.")]
			[Range(0f, 20f)]
			public int maxDiagonalSearchSteps;

			[Tooltip("Specifies how much sharp corners will be rounded.")]
			[Range(0f, 100f)]
			public int cornerRounding;

			[Tooltip("If there is an neighbor edge that has a local contrast factor times bigger contrast than current edge, current edge will be discarded.\nThis allows to eliminate spurious crossing edges, and is based on the fact that, if there is too much contrast in a direction, that will hide perceptually contrast in the other neighbors.")]
			[Min(0f)]
			public float localContrastAdaptationFactor;

			public static QualitySettings[] presetQualitySettings = new QualitySettings[4]
			{
				new QualitySettings
				{
					diagonalDetection = false,
					cornerDetection = false,
					threshold = 0.15f,
					depthThreshold = 0.01f,
					maxSearchSteps = 4,
					maxDiagonalSearchSteps = 8,
					cornerRounding = 25,
					localContrastAdaptationFactor = 2f
				},
				new QualitySettings
				{
					diagonalDetection = false,
					cornerDetection = false,
					threshold = 0.1f,
					depthThreshold = 0.01f,
					maxSearchSteps = 8,
					maxDiagonalSearchSteps = 8,
					cornerRounding = 25,
					localContrastAdaptationFactor = 2f
				},
				new QualitySettings
				{
					diagonalDetection = true,
					cornerDetection = true,
					threshold = 0.1f,
					depthThreshold = 0.01f,
					maxSearchSteps = 16,
					maxDiagonalSearchSteps = 8,
					cornerRounding = 25,
					localContrastAdaptationFactor = 2f
				},
				new QualitySettings
				{
					diagonalDetection = true,
					cornerDetection = true,
					threshold = 0.05f,
					depthThreshold = 0.01f,
					maxSearchSteps = 32,
					maxDiagonalSearchSteps = 16,
					cornerRounding = 25,
					localContrastAdaptationFactor = 2f
				}
			};
		}

		[Serializable]
		public struct TemporalSettings
		{
			[Tooltip("Temporal filtering makes it possible for the SMAA algorithm to benefit from minute subpixel information available that has been accumulated over many frames.")]
			public bool enabled;

			[Tooltip("The size of the fuzz-displacement (jitter) in pixels applied to the camera's perspective projection matrix.\nUsed for 2x temporal anti-aliasing.")]
			[Range(0.5f, 10f)]
			public float fuzzSize;

			public static TemporalSettings defaultSettings => new TemporalSettings
			{
				enabled = false,
				fuzzSize = 2f
			};

			public bool UseTemporal()
			{
				return enabled;
			}
		}

		[Serializable]
		public struct PredicationSettings
		{
			[Tooltip("Predicated thresholding allows to better preserve texture details and to improve performance, by decreasing the number of detected edges using an additional buffer (the detph buffer).\nIt locally decreases the luma or color threshold if an edge is found in an additional buffer (so the global threshold can be higher).")]
			public bool enabled;

			[Tooltip("Threshold to be used in the additional predication buffer.")]
			[Min(0.0001f)]
			public float threshold;

			[Tooltip("How much to scale the global threshold used for luma or color edge detection when using predication.")]
			[Range(1f, 5f)]
			public float scale;

			[Range(0f, 1f)]
			[Tooltip("How much to locally decrease the threshold.")]
			public float strength;

			public static PredicationSettings defaultSettings => new PredicationSettings
			{
				enabled = false,
				threshold = 0.01f,
				scale = 2f,
				strength = 0.4f
			};
		}

		[TopLevelSettings]
		public GlobalSettings settings = GlobalSettings.defaultSettings;

		[SettingsGroup]
		public QualitySettings quality = QualitySettings.presetQualitySettings[2];

		[SettingsGroup]
		public PredicationSettings predication = PredicationSettings.defaultSettings;

		[ExperimentalGroup]
		[SettingsGroup]
		public TemporalSettings temporal = TemporalSettings.defaultSettings;

		private Matrix4x4 m_ProjectionMatrix;

		private Matrix4x4 m_PreviousViewProjectionMatrix;

		private float m_FlipFlop = 1f;

		private RenderTexture m_Accumulation;

		private Shader m_Shader;

		private Texture2D m_AreaTexture;

		private Texture2D m_SearchTexture;

		private Material m_Material;

		public Shader shader
		{
			get
			{
				if (m_Shader == null)
				{
					m_Shader = Shader.Find("Hidden/Subpixel Morphological Anti-aliasing");
				}
				return m_Shader;
			}
		}

		private Texture2D areaTexture
		{
			get
			{
				if (m_AreaTexture == null)
				{
					m_AreaTexture = Resources.Load<Texture2D>("AreaTex");
				}
				return m_AreaTexture;
			}
		}

		private Texture2D searchTexture
		{
			get
			{
				if (m_SearchTexture == null)
				{
					m_SearchTexture = Resources.Load<Texture2D>("SearchTex");
				}
				return m_SearchTexture;
			}
		}

		private Material material
		{
			get
			{
				if (m_Material == null)
				{
					m_Material = ImageEffectHelper.CheckShaderAndCreateMaterial(shader);
				}
				return m_Material;
			}
		}

		public void OnEnable(AntiAliasing owner)
		{
			if (!ImageEffectHelper.IsSupported(shader, needDepth: true, needHdr: false, owner))
			{
				owner.enabled = false;
			}
		}

		public void OnDisable()
		{
			if (m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(m_Material);
			}
			if (m_Accumulation != null)
			{
				UnityEngine.Object.DestroyImmediate(m_Accumulation);
			}
			m_Material = null;
			m_Accumulation = null;
		}

		public void OnPreCull(Camera camera)
		{
			if (temporal.UseTemporal())
			{
				m_ProjectionMatrix = camera.projectionMatrix;
				m_FlipFlop -= 2f * m_FlipFlop;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.m03 = 0.25f * m_FlipFlop * temporal.fuzzSize / (float)camera.pixelWidth;
				identity.m13 = -0.25f * m_FlipFlop * temporal.fuzzSize / (float)camera.pixelHeight;
				camera.projectionMatrix = identity * camera.projectionMatrix;
			}
		}

		public void OnPostRender(Camera camera)
		{
			if (temporal.UseTemporal())
			{
				camera.ResetProjectionMatrix();
			}
		}

		public void OnRenderImage(Camera camera, RenderTexture source, RenderTexture destination)
		{
			int pixelWidth = camera.pixelWidth;
			int pixelHeight = camera.pixelHeight;
			bool flag = false;
			QualitySettings qualitySettings = quality;
			if (settings.quality != QualityPreset.Custom)
			{
				qualitySettings = QualitySettings.presetQualitySettings[(int)settings.quality];
			}
			int edgeDetectionMethod = (int)settings.edgeDetectionMethod;
			int pass = 4;
			int pass2 = 5;
			int pass3 = 6;
			Matrix4x4 matrix4x = GL.GetGPUProjectionMatrix(m_ProjectionMatrix, renderIntoTexture: true) * camera.worldToCameraMatrix;
			material.SetTexture("_AreaTex", areaTexture);
			material.SetTexture("_SearchTex", searchTexture);
			material.SetVector("_Metrics", new Vector4(1f / (float)pixelWidth, 1f / (float)pixelHeight, pixelWidth, pixelHeight));
			material.SetVector("_Params1", new Vector4(qualitySettings.threshold, qualitySettings.depthThreshold, qualitySettings.maxSearchSteps, qualitySettings.maxDiagonalSearchSteps));
			material.SetVector("_Params2", new Vector2(qualitySettings.cornerRounding, qualitySettings.localContrastAdaptationFactor));
			material.SetMatrix("_ReprojectionMatrix", m_PreviousViewProjectionMatrix * Matrix4x4.Inverse(matrix4x));
			float num = ((!(m_FlipFlop < 0f)) ? 1f : 2f);
			material.SetVector("_SubsampleIndices", new Vector4(num, num, num, 0f));
			Shader.DisableKeyword("USE_PREDICATION");
			if (settings.edgeDetectionMethod == EdgeDetectionMethod.Depth)
			{
				camera.depthTextureMode |= DepthTextureMode.Depth;
			}
			else if (predication.enabled)
			{
				camera.depthTextureMode |= DepthTextureMode.Depth;
				Shader.EnableKeyword("USE_PREDICATION");
				material.SetVector("_Params3", new Vector3(predication.threshold, predication.scale, predication.strength));
			}
			Shader.DisableKeyword("USE_DIAG_SEARCH");
			Shader.DisableKeyword("USE_CORNER_DETECTION");
			if (qualitySettings.diagonalDetection)
			{
				Shader.EnableKeyword("USE_DIAG_SEARCH");
			}
			if (qualitySettings.cornerDetection)
			{
				Shader.EnableKeyword("USE_CORNER_DETECTION");
			}
			Shader.DisableKeyword("USE_UV_BASED_REPROJECTION");
			if (temporal.UseTemporal())
			{
				Shader.EnableKeyword("USE_UV_BASED_REPROJECTION");
			}
			if (m_Accumulation == null || m_Accumulation.width != pixelWidth || m_Accumulation.height != pixelHeight)
			{
				if ((bool)m_Accumulation)
				{
					RenderTexture.ReleaseTemporary(m_Accumulation);
				}
				m_Accumulation = RenderTexture.GetTemporary(pixelWidth, pixelHeight, 0, source.format, RenderTextureReadWrite.Linear);
				m_Accumulation.hideFlags = HideFlags.HideAndDontSave;
				flag = true;
			}
			RenderTexture renderTexture = TempRT(pixelWidth, pixelHeight, source.format);
			Graphics.Blit(null, renderTexture, material, 0);
			Graphics.Blit(source, renderTexture, material, edgeDetectionMethod);
			if (settings.debugPass == DebugPass.Edges)
			{
				Graphics.Blit(renderTexture, destination);
			}
			else
			{
				RenderTexture renderTexture2 = TempRT(pixelWidth, pixelHeight, source.format);
				Graphics.Blit(null, renderTexture2, material, 0);
				Graphics.Blit(renderTexture, renderTexture2, material, pass);
				if (settings.debugPass == DebugPass.Weights)
				{
					Graphics.Blit(renderTexture2, destination);
				}
				else
				{
					material.SetTexture("_BlendTex", renderTexture2);
					if (temporal.UseTemporal())
					{
						Graphics.Blit(source, renderTexture, material, pass2);
						if (settings.debugPass == DebugPass.Accumulation)
						{
							Graphics.Blit(m_Accumulation, destination);
						}
						else if (!flag)
						{
							material.SetTexture("_AccumulationTex", m_Accumulation);
							Graphics.Blit(renderTexture, destination, material, pass3);
						}
						else
						{
							Graphics.Blit(renderTexture, destination);
						}
						Graphics.Blit(destination, m_Accumulation);
						RenderTexture.active = null;
					}
					else
					{
						Graphics.Blit(source, destination, material, pass2);
					}
				}
				RenderTexture.ReleaseTemporary(renderTexture2);
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			m_PreviousViewProjectionMatrix = matrix4x;
		}

		private RenderTexture TempRT(int width, int height, RenderTextureFormat format)
		{
			int depthBuffer = 0;
			return RenderTexture.GetTemporary(width, height, depthBuffer, format, RenderTextureReadWrite.Linear);
		}
	}
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Cinematic/Ambient Occlusion")]
	[ImageEffectAllowedInSceneView]
	[ExecuteInEditMode]
	public class AmbientOcclusion : MonoBehaviour
	{
		private struct PropertyObserver
		{
			private bool _downsampling;

			private OcclusionSource _occlusionSource;

			private bool _ambientOnly;

			private int _pixelWidth;

			private int _pixelHeight;

			public bool CheckNeedsReset(Settings setting, Camera camera)
			{
				return _downsampling != setting.downsampling || _occlusionSource != setting.occlusionSource || _ambientOnly != setting.ambientOnly || _pixelWidth != camera.pixelWidth || _pixelHeight != camera.pixelHeight;
			}

			public void Update(Settings setting, Camera camera)
			{
				_downsampling = setting.downsampling;
				_occlusionSource = setting.occlusionSource;
				_ambientOnly = setting.ambientOnly;
				_pixelWidth = camera.pixelWidth;
				_pixelHeight = camera.pixelHeight;
			}
		}

		public enum SampleCount
		{
			Lowest,
			Low,
			Medium,
			High,
			Variable
		}

		public enum OcclusionSource
		{
			DepthTexture,
			DepthNormalsTexture,
			GBuffer
		}

		[Serializable]
		public class Settings
		{
			[Range(0f, 4f)]
			[SerializeField]
			[Tooltip("Degree of darkness produced by the effect.")]
			public float intensity;

			[SerializeField]
			[Tooltip("Radius of sample points, which affects extent of darkened areas.")]
			public float radius;

			[SerializeField]
			[Tooltip("Number of sample points, which affects quality and performance.")]
			public SampleCount sampleCount;

			[Tooltip("Determines the sample count when SampleCount.Variable is used.")]
			[SerializeField]
			public int sampleCountValue;

			[Tooltip("Halves the resolution of the effect to increase performance.")]
			[SerializeField]
			public bool downsampling;

			[Tooltip("If checked, the effect only affects ambient lighting.")]
			[SerializeField]
			public bool ambientOnly;

			[SerializeField]
			[Tooltip("Source buffer on which the occlusion estimator is based.")]
			public OcclusionSource occlusionSource;

			[SerializeField]
			public bool debug;

			public static Settings defaultSettings
			{
				get
				{
					Settings settings = new Settings();
					settings.intensity = 1f;
					settings.radius = 0.3f;
					settings.sampleCount = SampleCount.Medium;
					settings.sampleCountValue = 24;
					settings.downsampling = false;
					settings.ambientOnly = false;
					settings.occlusionSource = OcclusionSource.DepthNormalsTexture;
					return settings;
				}
			}
		}

		[SerializeField]
		public Settings settings = Settings.defaultSettings;

		[SerializeField]
		private Shader _aoShader;

		private Material _aoMaterial;

		private CommandBuffer _aoCommands;

		[SerializeField]
		private Mesh _quadMesh;

		public bool isAmbientOnlySupported => targetCamera.hdr && occlusionSource == OcclusionSource.GBuffer;

		public bool isGBufferAvailable => targetCamera.actualRenderingPath == RenderingPath.DeferredShading;

		private float intensity => settings.intensity;

		private float radius => Mathf.Max(settings.radius, 0.0001f);

		private SampleCount sampleCount => settings.sampleCount;

		private int sampleCountValue => settings.sampleCount switch
		{
			SampleCount.Lowest => 3, 
			SampleCount.Low => 6, 
			SampleCount.Medium => 12, 
			SampleCount.High => 20, 
			_ => Mathf.Clamp(settings.sampleCountValue, 1, 256), 
		};

		private OcclusionSource occlusionSource
		{
			get
			{
				if (settings.occlusionSource == OcclusionSource.GBuffer && !isGBufferAvailable)
				{
					return OcclusionSource.DepthNormalsTexture;
				}
				return settings.occlusionSource;
			}
		}

		private bool downsampling => settings.downsampling;

		private bool ambientOnly => settings.ambientOnly && isAmbientOnlySupported;

		private Shader aoShader
		{
			get
			{
				if (_aoShader == null)
				{
					_aoShader = Shader.Find("Hidden/Image Effects/Cinematic/AmbientOcclusion");
				}
				return _aoShader;
			}
		}

		private Material aoMaterial
		{
			get
			{
				if (_aoMaterial == null)
				{
					_aoMaterial = ImageEffectHelper.CheckShaderAndCreateMaterial(aoShader);
				}
				return _aoMaterial;
			}
		}

		private CommandBuffer aoCommands
		{
			get
			{
				if (_aoCommands == null)
				{
					_aoCommands = new CommandBuffer();
					_aoCommands.name = "AmbientOcclusion";
				}
				return _aoCommands;
			}
		}

		private Camera targetCamera => GetComponent<Camera>();

		private PropertyObserver propertyObserver { get; set; }

		private Mesh quadMesh => _quadMesh;

		private void BuildAOCommands()
		{
			CommandBuffer commandBuffer = aoCommands;
			int pixelWidth = targetCamera.pixelWidth;
			int pixelHeight = targetCamera.pixelHeight;
			int num = ((!downsampling) ? 1 : 2);
			RenderTextureFormat format = RenderTextureFormat.R8;
			RenderTextureReadWrite readWrite = RenderTextureReadWrite.Linear;
			FilterMode filter = FilterMode.Bilinear;
			Material material = aoMaterial;
			int num2 = Shader.PropertyToID("_OcclusionTexture");
			commandBuffer.GetTemporaryRT(num2, pixelWidth / num, pixelHeight / num, 0, filter, format, readWrite);
			commandBuffer.Blit((Texture)null, (RenderTargetIdentifier)num2, material, 0);
			int num3 = Shader.PropertyToID("_OcclusionBlurTexture");
			commandBuffer.GetTemporaryRT(num3, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("_BlurVector", Vector2.right * 2f);
			commandBuffer.Blit(num2, num3, material, 1);
			commandBuffer.ReleaseTemporaryRT(num2);
			commandBuffer.GetTemporaryRT(num2, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("_BlurVector", Vector2.up * 2f * num);
			commandBuffer.Blit(num3, num2, material, 1);
			commandBuffer.ReleaseTemporaryRT(num3);
			commandBuffer.GetTemporaryRT(num3, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("_BlurVector", Vector2.right * num);
			commandBuffer.Blit(num2, num3, material, 2);
			commandBuffer.ReleaseTemporaryRT(num2);
			commandBuffer.GetTemporaryRT(num2, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("_BlurVector", Vector2.up * num);
			commandBuffer.Blit(num3, num2, material, 2);
			commandBuffer.ReleaseTemporaryRT(num3);
			RenderTargetIdentifier[] colors = new RenderTargetIdentifier[2]
			{
				BuiltinRenderTextureType.GBuffer0,
				BuiltinRenderTextureType.CameraTarget
			};
			commandBuffer.SetRenderTarget(colors, BuiltinRenderTextureType.CameraTarget);
			commandBuffer.SetGlobalTexture("_OcclusionTexture", num2);
			commandBuffer.DrawMesh(quadMesh, Matrix4x4.identity, material, 0, 4);
			commandBuffer.ReleaseTemporaryRT(num2);
		}

		private void ExecuteAOPass(RenderTexture source, RenderTexture destination)
		{
			int width = source.width;
			int height = source.height;
			int num = ((!downsampling) ? 1 : 2);
			RenderTextureFormat format = RenderTextureFormat.R8;
			RenderTextureReadWrite readWrite = RenderTextureReadWrite.Linear;
			Material material = aoMaterial;
			RenderTexture temporary = RenderTexture.GetTemporary(width / num, height / num, 0, format, readWrite);
			Graphics.Blit(null, temporary, material, 0);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0, format, readWrite);
			material.SetVector("_BlurVector", Vector2.right * 2f);
			Graphics.Blit(temporary, temporary2, material, 1);
			RenderTexture.ReleaseTemporary(temporary);
			temporary = RenderTexture.GetTemporary(width, height, 0, format, readWrite);
			material.SetVector("_BlurVector", Vector2.up * 2f * num);
			Graphics.Blit(temporary2, temporary, material, 1);
			RenderTexture.ReleaseTemporary(temporary2);
			temporary2 = RenderTexture.GetTemporary(width, height, 0, format, readWrite);
			material.SetVector("_BlurVector", Vector2.right * num);
			Graphics.Blit(temporary, temporary2, material, 2);
			RenderTexture.ReleaseTemporary(temporary);
			temporary = RenderTexture.GetTemporary(width, height, 0, format, readWrite);
			material.SetVector("_BlurVector", Vector2.up * num);
			Graphics.Blit(temporary2, temporary, material, 2);
			RenderTexture.ReleaseTemporary(temporary2);
			material.SetTexture("_OcclusionTexture", temporary);
			if (!settings.debug)
			{
				Graphics.Blit(source, destination, material, 3);
			}
			else
			{
				Graphics.Blit(source, destination, material, 5);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		private void UpdateMaterialProperties()
		{
			Material material = aoMaterial;
			material.shaderKeywords = null;
			material.SetFloat("_Intensity", intensity);
			material.SetFloat("_Radius", radius);
			material.SetFloat("_TargetScale", (!downsampling) ? 1f : 0.5f);
			if (occlusionSource == OcclusionSource.GBuffer)
			{
				material.EnableKeyword("_SOURCE_GBUFFER");
			}
			else if (occlusionSource == OcclusionSource.DepthTexture)
			{
				material.EnableKeyword("_SOURCE_DEPTH");
			}
			else
			{
				material.EnableKeyword("_SOURCE_DEPTHNORMALS");
			}
			if (sampleCount == SampleCount.Lowest)
			{
				material.EnableKeyword("_SAMPLECOUNT_LOWEST");
			}
			else
			{
				material.SetInt("_SampleCount", sampleCountValue);
			}
		}

		private void OnEnable()
		{
			if (!ImageEffectHelper.IsSupported(aoShader, needDepth: true, needHdr: false, this))
			{
				base.enabled = false;
				return;
			}
			if (ambientOnly)
			{
				targetCamera.AddCommandBuffer(CameraEvent.BeforeReflections, aoCommands);
			}
			if (occlusionSource == OcclusionSource.DepthTexture)
			{
				targetCamera.depthTextureMode |= DepthTextureMode.Depth;
			}
			if (occlusionSource != OcclusionSource.GBuffer)
			{
				targetCamera.depthTextureMode |= DepthTextureMode.DepthNormals;
			}
		}

		private void OnDisable()
		{
			if (_aoMaterial != null)
			{
				UnityEngine.Object.DestroyImmediate(_aoMaterial);
			}
			_aoMaterial = null;
			if (_aoCommands != null)
			{
				targetCamera.RemoveCommandBuffer(CameraEvent.BeforeReflections, _aoCommands);
			}
			_aoCommands = null;
		}

		private void Update()
		{
			if (propertyObserver.CheckNeedsReset(settings, targetCamera))
			{
				OnDisable();
				OnEnable();
				if (ambientOnly)
				{
					aoCommands.Clear();
					BuildAOCommands();
				}
				propertyObserver.Update(settings, targetCamera);
			}
			if (ambientOnly)
			{
				UpdateMaterialProperties();
			}
		}

		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (ambientOnly)
			{
				Graphics.Blit(source, destination);
				return;
			}
			UpdateMaterialProperties();
			ExecuteAOPass(source, destination);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Cinematic/Bloom")]
	[ImageEffectAllowedInSceneView]
	public class Bloom : MonoBehaviour
	{
		[Serializable]
		public struct Settings
		{
			[SerializeField]
			[Tooltip("Filters out pixels under this level of brightness.")]
			public float threshold;

			[Range(1f, 7f)]
			[SerializeField]
			[Tooltip("Changes extent of veiling effects in a screen resolution-independent fashion.")]
			public float radius;

			[Tooltip("Blend factor of the result image.")]
			[SerializeField]
			public float intensity;

			[Tooltip("Controls filter quality and buffer resolution.")]
			[SerializeField]
			public bool highQuality;

			[SerializeField]
			[Tooltip("Reduces flashing noise with an additional filter.")]
			public bool antiFlicker;

			public float thresholdGamma
			{
				get
				{
					return Mathf.Max(0f, threshold);
				}
				set
				{
					threshold = value;
				}
			}

			public float thresholdLinear
			{
				get
				{
					return Mathf.GammaToLinearSpace(thresholdGamma);
				}
				set
				{
					threshold = Mathf.LinearToGammaSpace(value);
				}
			}

			public static Settings defaultSettings => new Settings
			{
				threshold = 0.9f,
				radius = 2f,
				intensity = 0.7f,
				highQuality = true,
				antiFlicker = false
			};
		}

		private const int kMaxIterations = 16;

		[SerializeField]
		public Settings settings = Settings.defaultSettings;

		[SerializeField]
		[HideInInspector]
		private Shader m_Shader;

		private Material m_Material;

		private RenderTexture[] m_blurBuffer1 = new RenderTexture[16];

		private RenderTexture[] m_blurBuffer2 = new RenderTexture[16];

		public Shader shader
		{
			get
			{
				if (m_Shader == null)
				{
					m_Shader = Shader.Find("Hidden/Image Effects/Cinematic/Bloom");
				}
				return m_Shader;
			}
		}

		public Material material
		{
			get
			{
				if (m_Material == null)
				{
					m_Material = ImageEffectHelper.CheckShaderAndCreateMaterial(shader);
				}
				return m_Material;
			}
		}

		private void OnEnable()
		{
			if (!ImageEffectHelper.IsSupported(shader, needDepth: true, needHdr: false, this))
			{
				base.enabled = false;
			}
		}

		private void OnDisable()
		{
			if (m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(m_Material);
			}
			m_Material = null;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = source.width;
			int num2 = source.height;
			if (!settings.highQuality)
			{
				num /= 2;
				num2 /= 2;
			}
			RenderTextureFormat format = ((!isMobilePlatform) ? RenderTextureFormat.DefaultHDR : RenderTextureFormat.Default);
			float num3 = Mathf.Log(num2, 2f) + settings.radius - 8f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 1, 16);
			float thresholdLinear = settings.thresholdLinear;
			material.SetFloat("_Threshold", thresholdLinear);
			float num6 = thresholdLinear * 0.5f + 1E-05f;
			Vector3 vector = new Vector3(thresholdLinear - num6, num6 * 2f, 0.25f / num6);
			material.SetVector("_Curve", vector);
			bool flag = !settings.highQuality && settings.antiFlicker;
			material.SetFloat("_PrefilterOffs", (!flag) ? 0f : (-0.5f));
			material.SetFloat("_SampleScale", 0.5f + num3 - (float)num4);
			material.SetFloat("_Intensity", Mathf.Max(0f, settings.intensity));
			if (settings.highQuality)
			{
				material.EnableKeyword("HIGH_QUALITY");
			}
			else
			{
				material.DisableKeyword("HIGH_QUALITY");
			}
			if (settings.antiFlicker)
			{
				material.EnableKeyword("ANTI_FLICKER");
			}
			else
			{
				material.DisableKeyword("ANTI_FLICKER");
			}
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, format);
			Graphics.Blit(source, temporary, material, 0);
			RenderTexture renderTexture = temporary;
			for (int i = 0; i < num5; i++)
			{
				m_blurBuffer1[i] = RenderTexture.GetTemporary(renderTexture.width / 2, renderTexture.height / 2, 0, format);
				Graphics.Blit(renderTexture, m_blurBuffer1[i], material, (i == 0) ? 1 : 2);
				renderTexture = m_blurBuffer1[i];
			}
			for (int num7 = num5 - 2; num7 >= 0; num7--)
			{
				RenderTexture renderTexture2 = m_blurBuffer1[num7];
				material.SetTexture("_BaseTex", renderTexture2);
				m_blurBuffer2[num7] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 0, format);
				Graphics.Blit(renderTexture, m_blurBuffer2[num7], material, 3);
				renderTexture = m_blurBuffer2[num7];
			}
			material.SetTexture("_BaseTex", source);
			Graphics.Blit(renderTexture, destination, material, 4);
			for (int j = 0; j < 16; j++)
			{
				if (m_blurBuffer1[j] != null)
				{
					RenderTexture.ReleaseTemporary(m_blurBuffer1[j]);
				}
				if (m_blurBuffer2[j] != null)
				{
					RenderTexture.ReleaseTemporary(m_blurBuffer2[j]);
				}
				m_blurBuffer1[j] = null;
				m_blurBuffer2[j] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}
	}
	public static class ImageEffectHelper
	{
		public static bool supportsDX11 => SystemInfo.graphicsShaderLevel >= 50 && SystemInfo.supportsComputeShaders;

		public static bool IsSupported(Shader s, bool needDepth, bool needHdr, MonoBehaviour effect)
		{
			if (s == null || !s.isSupported)
			{
				Debug.LogWarningFormat("Missing shader for image effect {0}", effect);
				return false;
			}
			if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures)
			{
				Debug.LogWarningFormat("Image effects aren't supported on this device ({0})", effect);
				return false;
			}
			if (needDepth && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				Debug.LogWarningFormat("Depth textures aren't supported on this device ({0})", effect);
				return false;
			}
			if (needHdr && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf))
			{
				Debug.LogWarningFormat("Floating point textures aren't supported on this device ({0})", effect);
				return false;
			}
			return true;
		}

		public static Material CheckShaderAndCreateMaterial(Shader s)
		{
			if (s == null || !s.isSupported)
			{
				return null;
			}
			Material material = new Material(s);
			material.hideFlags = HideFlags.DontSave;
			return material;
		}
	}
	public sealed class MinAttribute : PropertyAttribute
	{
		public readonly float min;

		public MinAttribute(float min)
		{
			this.min = min;
		}
	}
	public class RenderTextureUtility
	{
		private List<RenderTexture> m_TemporaryRTs = new List<RenderTexture>();

		public RenderTexture GetTemporaryRenderTexture(int width, int height, int depthBuffer = 0, RenderTextureFormat format = RenderTextureFormat.ARGBHalf, FilterMode filterMode = FilterMode.Bilinear)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, depthBuffer, format);
			temporary.filterMode = filterMode;
			temporary.wrapMode = TextureWrapMode.Clamp;
			temporary.name = "RenderTextureUtilityTempTexture";
			m_TemporaryRTs.Add(temporary);
			return temporary;
		}

		public void ReleaseTemporaryRenderTexture(RenderTexture rt)
		{
			if (!(rt == null))
			{
				if (!m_TemporaryRTs.Contains(rt))
				{
					Debug.LogErrorFormat("Attempting to remove texture that was not allocated: {0}", rt);
				}
				else
				{
					m_TemporaryRTs.Remove(rt);
					RenderTexture.ReleaseTemporary(rt);
				}
			}
		}

		public void ReleaseAllTemporaryRenderTextures()
		{
			for (int i = 0; i < m_TemporaryRTs.Count; i++)
			{
				RenderTexture.ReleaseTemporary(m_TemporaryRTs[i]);
			}
			m_TemporaryRTs.Clear();
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Cinematic/Depth Of Field")]
	[RequireComponent(typeof(Camera))]
	public class DepthOfField : MonoBehaviour
	{
		private enum Passes
		{
			BlurAlphaWeighted,
			BoxBlur,
			DilateFgCocFromColor,
			DilateFgCoc,
			CaptureCoc,
			CaptureCocExplicit,
			VisualizeCoc,
			VisualizeCocExplicit,
			CocPrefilter,
			CircleBlur,
			CircleBlurWithDilatedFg,
			CircleBlurLowQuality,
			CircleBlowLowQualityWithDilatedFg,
			Merge,
			MergeExplicit,
			MergeBicubic,
			MergeExplicitBicubic,
			ShapeLowQuality,
			ShapeLowQualityDilateFg,
			ShapeLowQualityMerge,
			ShapeLowQualityMergeDilateFg,
			ShapeMediumQuality,
			ShapeMediumQualityDilateFg,
			ShapeMediumQualityMerge,
			ShapeMediumQualityMergeDilateFg,
			ShapeHighQuality,
			ShapeHighQualityDilateFg,
			ShapeHighQualityMerge,
			ShapeHighQualityMergeDilateFg
		}

		private enum MedianPasses
		{
			Median3,
			Median3X3
		}

		private enum BokehTexturesPasses
		{
			Apply,
			Collect
		}

		public enum TweakMode
		{
			Basic,
			Advanced,
			Explicit
		}

		public enum ApertureShape
		{
			Circular,
			Hexagonal,
			Octogonal
		}

		public enum QualityPreset
		{
			Simple,
			Low,
			Medium,
			High,
			VeryHigh,
			Ultra,
			Custom
		}

		public enum FilterQuality
		{
			None,
			Normal,
			High
		}

		[AttributeUsage(AttributeTargets.Field)]
		public class TopLevelSettings : Attribute
		{
		}

		[AttributeUsage(AttributeTargets.Field)]
		public class SettingsGroup : Attribute
		{
		}

		[AttributeUsage(AttributeTargets.Field)]
		public class AllTweakModes : Attribute
		{
		}

		[AttributeUsage(AttributeTargets.Field)]
		public class Basic : Attribute
		{
		}

		[AttributeUsage(AttributeTargets.Field)]
		public class Advanced : Attribute
		{
		}

		[AttributeUsage(AttributeTargets.Field)]
		public class Explicit : Attribute
		{
		}

		[Serializable]
		public struct GlobalSettings
		{
			[Tooltip("Allows to view where the blur will be applied. Yellow for near blur, blue for far blur.")]
			public bool visualizeBluriness;

			[Tooltip("Setup mode. Use \"Advanced\" if you need more control on blur settings and/or want to use a bokeh texture. \"Explicit\" is the same as \"Advanced\" but makes use of \"Near Plane\" and \"Far Plane\" values instead of \"F-Stop\".")]
			public TweakMode tweakMode;

			[Tooltip("Quality presets. Use \"Custom\" for more advanced settings.")]
			public QualityPreset quality;

			[Tooltip("\"Circular\" is the fastest, followed by \"Hexagonal\" and \"Octogonal\".")]
			[Space]
			public ApertureShape apertureShape;

			[Tooltip("Rotates the aperture when working with \"Hexagonal\" and \"Ortogonal\".")]
			[Range(0f, 179f)]
			public float apertureOrientation;

			public static GlobalSettings defaultSettings => new GlobalSettings
			{
				visualizeBluriness = false,
				tweakMode = TweakMode.Basic,
				quality = QualityPreset.High,
				apertureShape = ApertureShape.Circular,
				apertureOrientation = 0f
			};
		}

		[Serializable]
		public struct QualitySettings
		{
			[Tooltip("Enable this to get smooth bokeh.")]
			public bool prefilterBlur;

			[Tooltip("Applies a median filter for even smoother bokeh.")]
			public FilterQuality medianFilter;

			[Tooltip("Dilates near blur over in focus area.")]
			public bool dilateNearBlur;

			[Tooltip("Uses high quality upsampling.")]
			public bool highQualityUpsampling;

			[Tooltip("Prevent haloing from bright in focus region over dark out of focus region.")]
			public bool preventHaloing;

			public static QualitySettings[] presetQualitySettings = new QualitySettings[6]
			{
				new QualitySettings
				{
					prefilterBlur = false,
					medianFilter = FilterQuality.None,
					dilateNearBlur = false,
					highQualityUpsampling = false,
					preventHaloing = false
				},
				new QualitySettings
				{
					prefilterBlur = true,
					medianFilter = FilterQuality.None,
					dilateNearBlur = false,
					highQualityUpsampling = false,
					preventHaloing = false
				},
				new QualitySettings
				{
					prefilterBlur = true,
					medianFilter = FilterQuality.Normal,
					dilateNearBlur = false,
					highQualityUpsampling = false,
					preventHaloing = false
				},
				new QualitySettings
				{
					prefilterBlur = true,
					medianFilter = FilterQuality.Normal,
					dilateNearBlur = true,
					highQualityUpsampling = false,
					preventHaloing = false
				},
				new QualitySettings
				{
					prefilterBlur = true,
					medianFilter = FilterQuality.High,
					dilateNearBlur = true,
					highQualityUpsampling = false,
					preventHaloing = true
				},
				new QualitySettings
				{
					prefilterBlur = true,
					medianFilter = FilterQuality.High,
					dilateNearBlur = true,
					highQualityUpsampling = true,
					preventHaloing = true
				}
			};
		}

		[Serializable]
		public struct FocusSettings
		{
			[Advanced]
			[Explicit]
			[Tooltip("Auto-focus on a selected transform.")]
			[Basic]
			public Transform transform;

			[Basic]
			[Range(0f, 1f)]
			[Explicit]
			[Advanced]
			[Tooltip("Focus distance.")]
			public float plane;

			[Explicit]
			[Tooltip("Near focus distance.")]
			[Range(0f, 1f)]
			public float nearPlane;

			[Explicit]
			[Tooltip("Far focus distance.")]
			[Range(0f, 1f)]
			public float farPlane;

			[Range(0f, 32f)]
			[Advanced]
			[Basic]
			[Tooltip("Simulates focal ratio. Lower values will result in a narrow depth of field.")]
			public float fStops;

			[Range(0f, 1f)]
			[Explicit]
			[Advanced]
			[Basic]
			[Tooltip("Focus range/spread. Use this to fine-tune the F-Stop range.")]
			public float rangeAdjustment;

			public static FocusSettings defaultSettings => new FocusSettings
			{
				transform = null,
				plane = 0.225f,
				nearPlane = 0f,
				farPlane = 1f,
				fStops = 5f,
				rangeAdjustment = 0.9f
			};
		}

		[Serializable]
		public struct BokehTextureSettings
		{
			[Advanced]
			[Explicit]
			[Tooltip("Adding a texture to this field will enable the use of \"Bokeh Textures\". Use with care. This feature is only available on Shader Model 5 compatible-hardware and performance scale with the amount of bokeh.")]
			public Texture2D texture;

			[Advanced]
			[Tooltip("Maximum size of bokeh textures on screen.")]
			[Range(0.01f, 5f)]
			[Explicit]
			public float scale;

			[Range(0.01f, 100f)]
			[Tooltip("Bokeh brightness.")]
			[Explicit]
			[Advanced]
			public float intensity;

			[Explicit]
			[Range(0.01f, 50f)]
			[Tooltip("Controls the amount of bokeh textures. Lower values mean more bokeh splats.")]
			[Advanced]
			public float threshold;

			[Advanced]
			[Explicit]
			[Tooltip("Controls the spawn conditions. Lower values mean more visible bokeh.")]
			[Range(0.01f, 1f)]
			public float spawnHeuristic;

			public static BokehTextureSettings defaultSettings => new BokehTextureSettings
			{
				texture = null,
				scale = 1f,
				intensity = 50f,
				threshold = 2f,
				spawnHeuristic = 0.15f
			};
		}

		[Serializable]
		public struct BlurSettings
		{
			[Advanced]
			[Explicit]
			[Tooltip("Maximum blur radius for the near plane.")]
			[Basic]
			[Range(0f, 35f)]
			public float nearRadius;

			[Range(0f, 35f)]
			[Basic]
			[Explicit]
			[Tooltip("Maximum blur radius for the far plane.")]
			[Advanced]
			public float farRadius;

			[Advanced]
			[Explicit]
			[Range(0.5f, 4f)]
			[Tooltip("Blur luminosity booster threshold for the near and far boost amounts.")]
			public float boostPoint;

			[Range(0f, 1f)]
			[Explicit]
			[Tooltip("Boosts luminosity in the near blur.")]
			[Advanced]
			public float nearBoostAmount;

			[Tooltip("Boosts luminosity in the far blur.")]
			[Explicit]
			[Advanced]
			[Range(0f, 1f)]
			public float farBoostAmount;

			public static BlurSettings defaultSettings => new BlurSettings
			{
				nearRadius = 20f,
				farRadius = 20f,
				boostPoint = 0.75f,
				nearBoostAmount = 0f,
				farBoostAmount = 0f
			};
		}

		private const float kMaxBlur = 35f;

		[TopLevelSettings]
		public GlobalSettings settings = GlobalSettings.defaultSettings;

		[AllTweakModes]
		[SettingsGroup]
		public QualitySettings quality = QualitySettings.presetQualitySettings[3];

		[SettingsGroup]
		public FocusSettings focus = FocusSettings.defaultSettings;

		[SettingsGroup]
		public BokehTextureSettings bokehTexture = BokehTextureSettings.defaultSettings;

		[SettingsGroup]
		public BlurSettings blur = BlurSettings.defaultSettings;

		[SerializeField]
		private Shader m_FilmicDepthOfFieldShader;

		[SerializeField]
		private Shader m_MedianFilterShader;

		[SerializeField]
		private Shader m_TextureBokehShader;

		private RenderTextureUtility m_RTU = new RenderTextureUtility();

		private Material m_FilmicDepthOfFieldMaterial;

		private Material m_MedianFilterMaterial;

		private Material m_TextureBokehMaterial;

		private ComputeBuffer m_ComputeBufferDrawArgs;

		private ComputeBuffer m_ComputeBufferPoints;

		private QualitySettings m_CurrentQualitySettings;

		private float m_LastApertureOrientation;

		private Vector4 m_OctogonalBokehDirection1;

		private Vector4 m_OctogonalBokehDirection2;

		private Vector4 m_OctogonalBokehDirection3;

		private Vector4 m_OctogonalBokehDirection4;

		private Vector4 m_HexagonalBokehDirection1;

		private Vector4 m_HexagonalBokehDirection2;

		private Vector4 m_HexagonalBokehDirection3;

		public Shader filmicDepthOfFieldShader
		{
			get
			{
				if (m_FilmicDepthOfFieldShader == null)
				{
					m_FilmicDepthOfFieldShader = Shader.Find("Hidden/DepthOfField/DepthOfField");
				}
				return m_FilmicDepthOfFieldShader;
			}
		}

		public Shader medianFilterShader
		{
			get
			{
				if (m_MedianFilterShader == null)
				{
					m_MedianFilterShader = Shader.Find("Hidden/DepthOfField/MedianFilter");
				}
				return m_MedianFilterShader;
			}
		}

		public Shader textureBokehShader
		{
			get
			{
				if (m_TextureBokehShader == null)
				{
					m_TextureBokehShader = Shader.Find("Hidden/DepthOfField/BokehSplatting");
				}
				return m_TextureBokehShader;
			}
		}

		public Material filmicDepthOfFieldMaterial
		{
			get
			{
				if (m_FilmicDepthOfFieldMaterial == null)
				{
					m_FilmicDepthOfFieldMaterial = ImageEffectHelper.CheckShaderAndCreateMaterial(filmicDepthOfFieldShader);
				}
				return m_FilmicDepthOfFieldMaterial;
			}
		}

		public Material medianFilterMaterial
		{
			get
			{
				if (m_MedianFilterMaterial == null)
				{
					m_MedianFilterMaterial = ImageEffectHelper.CheckShaderAndCreateMaterial(medianFilterShader);
				}
				return m_MedianFilterMaterial;
			}
		}

		public Material textureBokehMaterial
		{
			get
			{
				if (m_TextureBokehMaterial == null)
				{
					m_TextureBokehMaterial = ImageEffectHelper.CheckShaderAndCreateMaterial(textureBokehShader);
				}
				return m_TextureBokehMaterial;
			}
		}

		public ComputeBuffer computeBufferDrawArgs
		{
			get
			{
				if (m_ComputeBufferDrawArgs == null)
				{
					m_ComputeBufferDrawArgs = new ComputeBuffer(1, 16, ComputeBufferType.DrawIndirect);
					m_ComputeBufferDrawArgs.SetData(new int[4] { 0, 1, 0, 0 });
				}
				return m_ComputeBufferDrawArgs;
			}
		}

		public ComputeBuffer computeBufferPoints
		{
			get
			{
				if (m_ComputeBufferPoints == null)
				{
					m_ComputeBufferPoints = new ComputeBuffer(90000, 28, ComputeBufferType.Append);
				}
				return m_ComputeBufferPoints;
			}
		}

		private bool shouldPerformBokeh => ImageEffectHelper.supportsDX11 && bokehTexture.texture != null && (bool)textureBokehMaterial && settings.tweakMode != TweakMode.Basic;

		private void OnEnable()
		{
			if (!ImageEffectHelper.IsSupported(filmicDepthOfFieldShader, needDepth: true, needHdr: true, this) || !ImageEffectHelper.IsSupported(medianFilterShader, needDepth: true, needHdr: true, this))
			{
				base.enabled = false;
				return;
			}
			if (ImageEffectHelper.supportsDX11 && !ImageEffectHelper.IsSupported(textureBokehShader, needDepth: true, needHdr: true, this))
			{
				base.enabled = false;
				return;
			}
			ComputeBlurDirections(force: true);
			GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
		}

		private void OnDisable()
		{
			ReleaseComputeResources();
			if (m_FilmicDepthOfFieldMaterial != null)
			{
				UnityEngine.Object.DestroyImmediate(m_FilmicDepthOfFieldMaterial);
			}
			if (m_TextureBokehMaterial != null)
			{
				UnityEngine.Object.DestroyImmediate(m_TextureBokehMaterial);
			}
			if (m_MedianFilterMaterial != null)
			{
				UnityEngine.Object.DestroyImmediate(m_MedianFilterMaterial);
			}
			m_FilmicDepthOfFieldMaterial = null;
			m_TextureBokehMaterial = null;
			m_MedianFilterMaterial = null;
			m_RTU.ReleaseAllTemporaryRenderTextures();
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (medianFilterMaterial == null || filmicDepthOfFieldMaterial == null)
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (settings.visualizeBluriness)
			{
				ComputeCocParameters(out var blurParams, out var blurCoe);
				filmicDepthOfFieldMaterial.SetVector("_BlurParams", blurParams);
				filmicDepthOfFieldMaterial.SetVector("_BlurCoe", blurCoe);
				Graphics.Blit(null, destination, filmicDepthOfFieldMaterial, (settings.tweakMode != TweakMode.Explicit) ? 6 : 7);
			}
			else
			{
				DoDepthOfField(source, destination);
			}
			m_RTU.ReleaseAllTemporaryRenderTextures();
		}

		private void DoDepthOfField(RenderTexture source, RenderTexture destination)
		{
			m_CurrentQualitySettings = quality;
			if (settings.quality != QualityPreset.Custom)
			{
				m_CurrentQualitySettings = QualitySettings.presetQualitySettings[(int)settings.quality];
			}
			float num = (float)source.height / 720f;
			float num2 = num;
			float num3 = Mathf.Max(blur.nearRadius, blur.farRadius) * num2 * 0.75f;
			float num4 = blur.nearRadius * num;
			float num5 = blur.farRadius * num;
			float num6 = Mathf.Max(num4, num5);
			switch (settings.apertureShape)
			{
			case ApertureShape.Hexagonal:
				num6 *= 1.2f;
				break;
			case ApertureShape.Octogonal:
				num6 *= 1.15f;
				break;
			}
			if (num6 < 0.5f)
			{
				Graphics.Blit(source, destination);
				return;
			}
			int width = source.width / 2;
			int height = source.height / 2;
			Vector4 vector = new Vector4(num4 * 0.5f, num5 * 0.5f, 0f, 0f);
			RenderTexture temporaryRenderTexture = m_RTU.GetTemporaryRenderTexture(width, height);
			RenderTexture temporaryRenderTexture2 = m_RTU.GetTemporaryRenderTexture(width, height);
			if (m_CurrentQualitySettings.preventHaloing)
			{
				filmicDepthOfFieldMaterial.EnableKeyword("USE_SPECIAL_FETCH_FOR_COC");
			}
			else
			{
				filmicDepthOfFieldMaterial.DisableKeyword("USE_SPECIAL_FETCH_FOR_COC");
			}
			ComputeCocParameters(out var blurParams, out var blurCoe);
			filmicDepthOfFieldMaterial.SetVector("_BlurParams", blurParams);
			filmicDepthOfFieldMaterial.SetVector("_BlurCoe", blurCoe);
			filmicDepthOfFieldMaterial.SetVector("_BoostParams", new Vector4(num4 * blur.nearBoostAmount * -0.5f, num5 * blur.farBoostAmount * 0.5f, blur.boostPoint, 0f));
			Graphics.Blit(source, temporaryRenderTexture2, filmicDepthOfFieldMaterial, (settings.tweakMode != TweakMode.Explicit) ? 4 : 5);
			RenderTexture src = temporaryRenderTexture2;
			RenderTexture dst = temporaryRenderTexture;
			if (shouldPerformBokeh)
			{
				RenderTexture temporaryRenderTexture3 = m_RTU.GetTemporaryRenderTexture(width, height);
				Graphics.Blit(src, temporaryRenderTexture3, filmicDepthOfFieldMaterial, 1);
				filmicDepthOfFieldMaterial.SetVector("_Offsets", new Vector4(0f, 1.5f, 0f, 1.5f));
				Graphics.Blit(temporaryRenderTexture3, dst, filmicDepthOfFieldMaterial, 0);
				filmicDepthOfFieldMaterial.SetVector("_Offsets", new Vector4(1.5f, 0f, 0f, 1.5f));
				Graphics.Blit(dst, temporaryRenderTexture3, filmicDepthOfFieldMaterial, 0);
				textureBokehMaterial.SetTexture("_BlurredColor", temporaryRenderTexture3);
				textureBokehMaterial.SetFloat("_SpawnHeuristic", bokehTexture.spawnHeuristic);
				textureBokehMaterial.SetVector("_BokehParams", new Vector4(bokehTexture.scale * num2, bokehTexture.intensity, bokehTexture.threshold, num3));
				Graphics.SetRandomWriteTarget(1, computeBufferPoints);
				Graphics.Blit(src, dst, textureBokehMaterial, 1);
				Graphics.ClearRandomWriteTargets();
				SwapRenderTexture(ref src, ref dst);
				m_RTU.ReleaseTemporaryRenderTexture(temporaryRenderTexture3);
			}
			filmicDepthOfFieldMaterial.SetVector("_BlurParams", blurParams);
			filmicDepthOfFieldMaterial.SetVector("_BlurCoe", vector);
			filmicDepthOfFieldMaterial.SetVector("_BoostParams", new Vector4(num4 * blur.nearBoostAmount * -0.5f, num5 * blur.farBoostAmount * 0.5f, blur.boostPoint, 0f));
			RenderTexture renderTexture = null;
			if (m_CurrentQualitySettings.dilateNearBlur)
			{
				RenderTexture temporaryRenderTexture4 = m_RTU.GetTemporaryRenderTexture(width, height, 0, RenderTextureFormat.RGHalf);
				renderTexture = m_RTU.GetTemporaryRenderTexture(width, height, 0, RenderTextureFormat.RGHalf);
				filmicDepthOfFieldMaterial.SetVector("_Offsets", new Vector4(0f, num4 * 0.75f, 0f, 0f));
				Graphics.Blit(src, temporaryRenderTexture4, filmicDepthOfFieldMaterial, 2);
				filmicDepthOfFieldMaterial.SetVector("_Offsets", new Vector4(num4 * 0.75f, 0f, 0f, 0f));
				Graphics.Blit(temporaryRenderTexture4, renderTexture, filmicDepthOfFieldMaterial, 3);
				m_RTU.ReleaseTemporaryRenderTexture(temporaryRenderTexture4);
				renderTexture.filterMode = FilterMode.Point;
			}
			if (m_CurrentQualitySettings.prefilterBlur)
			{
				Graphics.Blit(src, dst, filmicDepthOfFieldMaterial, 8);
				SwapRenderTexture(ref src, ref dst);
			}
			switch (settings.apertureShape)
			{
			case ApertureShape.Circular:
				DoCircularBlur(renderTexture, ref src, ref dst, num6);
				break;
			case ApertureShape.Hexagonal:
				DoHexagonalBlur(renderTexture, ref src, ref dst, num6);
				break;
			case ApertureShape.Octogonal:
				DoOctogonalBlur(renderTexture, ref src, ref dst, num6);
				break;
			}
			switch (m_CurrentQualitySettings.medianFilter)
			{
			case FilterQuality.Normal:
				medianFilterMaterial.SetVector("_Offsets", new Vector4(1f, 0f, 0f, 0f));
				Graphics.Blit(src, dst, medianFilterMaterial, 0);
				SwapRenderTexture(ref src, ref dst);
				medianFilterMaterial.SetVector("_Offsets", new Vector4(0f, 1f, 0f, 0f));
				Graphics.Blit(src, dst, medianFilterMaterial, 0);
				SwapRenderTexture(ref src, ref dst);
				break;
			case FilterQuality.High:
				Graphics.Blit(src, dst, medianFilterMaterial, 1);
				SwapRenderTexture(ref src, ref dst);
				break;
			}
			filmicDepthOfFieldMaterial.SetVector("_BlurCoe", vector);
			filmicDepthOfFieldMaterial.SetVector("_Convolved_TexelSize", new Vector4(src.width, src.height, 1f / (float)src.width, 1f / (float)src.height));
			filmicDepthOfFieldMaterial.SetTexture("_SecondTex", src);
			int pass = ((settings.tweakMode != TweakMode.Explicit) ? 13 : 14);
			if (m_CurrentQualitySettings.highQualityUpsampling)
			{
				pass = ((settings.tweakMode != TweakMode.Explicit) ? 15 : 16);
			}
			if (shouldPerformBokeh)
			{
				RenderTexture temporaryRenderTexture5 = m_RTU.GetTemporaryRenderTexture(source.height, source.width, 0, source.format);
				Graphics.Blit(source, temporaryRenderTexture5, filmicDepthOfFieldMaterial, pass);
				Graphics.SetRenderTarget(temporaryRenderTexture5);
				ComputeBuffer.CopyCount(computeBufferPoints, computeBufferDrawArgs, 0);
				textureBokehMaterial.SetBuffer("pointBuffer", computeBufferPoints);
				textureBokehMaterial.SetTexture("_MainTex", bokehTexture.texture);
				textureBokehMaterial.SetVector("_Screen", new Vector3(1f / (1f * (float)source.width), 1f / (1f * (float)source.height), num3));
				textureBokehMaterial.SetPass(0);
				Graphics.DrawProceduralIndirect(MeshTopology.Points, computeBufferDrawArgs, 0);
				Graphics.Blit(temporaryRenderTexture5, destination);
			}
			else
			{
				Graphics.Blit(source, destination, filmicDepthOfFieldMaterial, pass);
			}
		}

		private void DoHexagonalBlur(RenderTexture blurredFgCoc, ref RenderTexture src, ref RenderTexture dst, float maxRadius)
		{
			ComputeBlurDirections(force: false);
			GetDirectionalBlurPassesFromRadius(blurredFgCoc, maxRadius, out var blurPass, out var blurAndMergePass);
			filmicDepthOfFieldMaterial.SetTexture("_SecondTex", blurredFgCoc);
			RenderTexture temporaryRenderTexture = m_RTU.GetTemporaryRenderTexture(src.width, src.height, 0, src.format);
			filmicDepthOfFieldMaterial.SetVector("_Offsets", m_HexagonalBokehDirection1);
			Graphics.Blit(src, temporaryRenderTexture, filmicDepthOfFieldMaterial, blurPass);
			filmicDepthOfFieldMaterial.SetVector("_Offsets", m_HexagonalBokehDirection2);
			Graphics.Blit(temporaryRenderTexture, src, filmicDepthOfFieldMaterial, blurPass);
			filmicDepthOfFieldMaterial.SetVector("_Offsets", m_HexagonalBokehDirection3);
			filmicDepthOfFieldMaterial.SetTexture("_ThirdTex", src);
			Graphics.Blit(temporaryRenderTexture, dst, filmicDepthOfFieldMaterial, blurAndMergePass);
			m_RTU.ReleaseTemporaryRenderTexture(temporaryRenderTexture);
			SwapRenderTexture(ref src, ref dst);
		}

		private void DoOctogonalBlur(RenderTexture blurredFgCoc, ref RenderTexture src, ref RenderTexture dst, float maxRadius)
		{
			ComputeBlurDirections(force: false);
			GetDirectionalBlurPassesFromRadius(blurredFgCoc, maxRadius, out var blurPass, out var blurAndMergePass);
			filmicDepthOfFieldMaterial.SetTexture("_SecondTex", blurredFgCoc);
			RenderTexture temporaryRenderTexture = m_RTU.GetTemporaryRenderTexture(src.width, src.height, 0, src.format);
			filmicDepthOfFieldMaterial.SetVector("_Offsets", m_OctogonalBokehDirection1);
			Graphics.Blit(src, temporaryRenderTexture, filmicDepthOfFieldMaterial, blurPass);
			filmicDepthOfFieldMaterial.SetVector("_Offsets", m_OctogonalBokehDirection2);
			Graphics.Blit(temporaryRenderTexture, dst, filmicDepthOfFieldMaterial, blurPass);
			filmicDepthOfFieldMaterial.SetVector("_Offsets", m_OctogonalBokehDirection3);
			Graphics.Blit(src, temporaryRenderTexture, filmicDepthOfFieldMaterial, blurPass);
			filmicDepthOfFieldMaterial.SetVector("_Offsets", m_OctogonalBokehDirection4);
			filmicDepthOfFieldMaterial.SetTexture("_ThirdTex", dst);
			Graphics.Blit(temporaryRenderTexture, src, filmicDepthOfFieldMaterial, blurAndMergePass);
			m_RTU.ReleaseTemporaryRenderTexture(temporaryRenderTexture);
		}

		private void DoCircularBlur(RenderTexture blurredFgCoc, ref RenderTexture src, ref RenderTexture dst, float maxRadius)
		{
			int pass;
			if (blurredFgCoc != null)
			{
				filmicDepthOfFieldMaterial.SetTexture("_SecondTex", blurredFgCoc);
				pass = ((!(maxRadius > 10f)) ? 12 : 10);
			}
			else
			{
				pass = ((!(maxRadius > 10f)) ? 11 : 9);
			}
			Graphics.Blit(src, dst, filmicDepthOfFieldMaterial, pass);
			SwapRenderTexture(ref src, ref dst);
		}

		private void ComputeCocParameters(out Vector4 blurParams, out Vector4 blurCoe)
		{
			Camera component = GetComponent<Camera>();
			float num = ((!focus.transform) ? (focus.plane * focus.plane * focus.plane * focus.plane) : (component.WorldToViewportPoint(focus.transform.position).z / component.farClipPlane));
			if (settings.tweakMode == TweakMode.Basic || settings.tweakMode == TweakMode.Advanced)
			{
				float w = focus.rangeAdjustment * focus.rangeAdjustment * focus.rangeAdjustment * focus.rangeAdjustment;
				float num2 = 4f / Mathf.Tan(0.5f * component.fieldOfView * ((float)Math.PI / 180f));
				float x = num2 / focus.fStops;
				blurCoe = new Vector4(0f, 0f, 1f, 1f);
				blurParams = new Vector4(x, num2, num, w);
				return;
			}
			float num3 = focus.nearPlane * focus.nearPlane * focus.nearPlane * focus.nearPlane;
			float num4 = focus.farPlane * focus.farPlane * focus.farPlane * focus.farPlane;
			float num5 = focus.rangeAdjustment * focus.rangeAdjustment * focus.rangeAdjustment * focus.rangeAdjustment;
			float num6 = num5;
			if (num <= num3)
			{
				num = num3 + 1E-07f;
			}
			if (num >= num4)
			{
				num = num4 - 1E-07f;
			}
			if (num - num5 <= num3)
			{
				num5 = num - num3 - 1E-07f;
			}
			if (num + num6 >= num4)
			{
				num6 = num4 - num - 1E-07f;
			}
			float num7 = 1f / (num3 - num + num5);
			float num8 = 1f / (num4 - num - num6);
			float num9 = 1f - num7 * num3;
			float num10 = 1f - num8 * num4;
			blurParams = new Vector4(-1f * num7, -1f * num9, 1f * num8, 1f * num10);
			blurCoe = new Vector4(0f, 0f, (num10 - num9) / (num7 - num8), 0f);
		}

		private void ReleaseComputeResources()
		{
			if (m_ComputeBufferDrawArgs != null)
			{
				m_ComputeBufferDrawArgs.Release();
			}
			if (m_ComputeBufferPoints != null)
			{
				m_ComputeBufferPoints.Release();
			}
			m_ComputeBufferDrawArgs = null;
			m_ComputeBufferPoints = null;
		}

		private void ComputeBlurDirections(bool force)
		{
			if (force || !(Math.Abs(m_LastApertureOrientation - settings.apertureOrientation) < float.Epsilon))
			{
				m_LastApertureOrientation = settings.apertureOrientation;
				float num = settings.apertureOrientation * ((float)Math.PI / 180f);
				float cosinus = Mathf.Cos(num);
				float sinus = Mathf.Sin(num);
				m_OctogonalBokehDirection1 = new Vector4(0.5f, 0f, 0f, 0f);
				m_OctogonalBokehDirection2 = new Vector4(0f, 0.5f, 1f, 0f);
				m_OctogonalBokehDirection3 = new Vector4(-0.353553f, 0.353553f, 1f, 0f);
				m_OctogonalBokehDirection4 = new Vector4(0.353553f, 0.353553f, 1f, 0f);
				m_HexagonalBokehDirection1 = new Vector4(0.5f, 0f, 0f, 0f);
				m_HexagonalBokehDirection2 = new Vector4(0.25f, 0.433013f, 1f, 0f);
				m_HexagonalBokehDirection3 = new Vector4(0.25f, -0.433013f, 1f, 0f);
				if (num > float.Epsilon)
				{
					Rotate2D(ref m_OctogonalBokehDirection1, cosinus, sinus);
					Rotate2D(ref m_OctogonalBokehDirection2, cosinus, sinus);
					Rotate2D(ref m_OctogonalBokehDirection3, cosinus, sinus);
					Rotate2D(ref m_OctogonalBokehDirection4, cosinus, sinus);
					Rotate2D(ref m_HexagonalBokehDirection1, cosinus, sinus);
					Rotate2D(ref m_HexagonalBokehDirection2, cosinus, sinus);
					Rotate2D(ref m_HexagonalBokehDirection3, cosinus, sinus);
				}
			}
		}

		private static void Rotate2D(ref Vector4 direction, float cosinus, float sinus)
		{
			Vector4 vector = direction;
			direction.x = vector.x * cosinus - vector.y * sinus;
			direction.y = vector.x * sinus + vector.y * cosinus;
		}

		private static void SwapRenderTexture(ref RenderTexture src, ref RenderTexture dst)
		{
			RenderTexture renderTexture = dst;
			dst = src;
			src = renderTexture;
		}

		private static void GetDirectionalBlurPassesFromRadius(RenderTexture blurredFgCoc, float maxRadius, out int blurPass, out int blurAndMergePass)
		{
			if (blurredFgCoc == null)
			{
				if (maxRadius > 10f)
				{
					blurPass = 25;
					blurAndMergePass = 27;
				}
				else if (maxRadius > 5f)
				{
					blurPass = 21;
					blurAndMergePass = 23;
				}
				else
				{
					blurPass = 17;
					blurAndMergePass = 19;
				}
			}
			else if (maxRadius > 10f)
			{
				blurPass = 26;
				blurAndMergePass = 28;
			}
			else if (maxRadius > 5f)
			{
				blurPass = 22;
				blurAndMergePass = 24;
			}
			else
			{
				blurPass = 18;
				blurAndMergePass = 20;
			}
		}
	}
	[AddComponentMenu("Image Effects/Cinematic/Lens Aberrations")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class LensAberrations : MonoBehaviour
	{
		[AttributeUsage(AttributeTargets.Field)]
		public class SettingsGroup : Attribute
		{
		}

		[AttributeUsage(AttributeTargets.Field)]
		public class AdvancedSetting : Attribute
		{
		}

		[Serializable]
		public struct DistortionSettings
		{
			public bool enabled;

			[Tooltip("Distortion amount.")]
			[Range(-100f, 100f)]
			public float amount;

			[Tooltip("Distortion center point (X axis).")]
			[Range(-1f, 1f)]
			public float centerX;

			[Tooltip("Distortion center point (Y axis).")]
			[Range(-1f, 1f)]
			public float centerY;

			[Tooltip("Amount multiplier on X axis. Set it to 0 to disable distortion on this axis.")]
			[Range(0f, 1f)]
			public float amountX;

			[Tooltip("Amount multiplier on Y axis. Set it to 0 to disable distortion on this axis.")]
			[Range(0f, 1f)]
			public float amountY;

			[Tooltip("Global screen scaling.")]
			[Range(0.01f, 5f)]
			public float scale;

			public static DistortionSettings defaultSettings => new DistortionSettings
			{
				enabled = false,
				amount = 0f,
				centerX = 0f,
				centerY = 0f,
				amountX = 1f,
				amountY = 1f,
				scale = 1f
			};
		}

		[Serializable]
		public struct VignetteSettings
		{
			public bool enabled;

			[Tooltip("Vignette color. Use the alpha channel for transparency.")]
			[ColorUsage(false)]
			public Color color;

			[Tooltip("Sets the vignette center point (screen center is [0.5,0.5]).")]
			public Vector2 center;

			[Range(0f, 3f)]
			[Tooltip("Amount of vignetting on screen.")]
			public float intensity;

			[Range(0.01f, 3f)]
			[Tooltip("Smoothness of the vignette borders.")]
			public float smoothness;

			[AdvancedSetting]
			[Range(0f, 1f)]
			[Tooltip("Lower values will make a square-ish vignette.")]
			public float roundness;

			[Tooltip("Blurs the corners of the screen. Leave this at 0 to disable it.")]
			[Range(0f, 1f)]
			public float blur;

			[Range(0f, 1f)]
			[Tooltip("Desaturate the corners of the screen. Leave this to 0 to disable it.")]
			public float desaturate;

			public static VignetteSettings defaultSettings => new VignetteSettings
			{
				enabled = false,
				color = new Color(0f, 0f, 0f, 1f),
				center = new Vector2(0.5f, 0.5f),
				intensity = 1.4f,
				smoothness = 0.8f,
				roundness = 1f,
				blur = 0f,
				desaturate = 0f
			};
		}

		[Serializable]
		public struct ChromaticAberrationSettings
		{
			public bool enabled;

			[Tooltip("Channels to apply chromatic aberration to.")]
			[ColorUsage(false)]
			public Color color;

			[Tooltip("Amount of tangential distortion.")]
			[Range(-50f, 50f)]
			public float amount;

			public static ChromaticAberrationSettings defaultSettings => new ChromaticAberrationSettings
			{
				enabled = false,
				color = Color.green,
				amount = 0f
			};
		}

		private enum Pass
		{
			BlurPrePass,
			Chroma,
			Distort,
			Vignette,
			ChromaDistort,
			ChromaVignette,
			DistortVignette,
			ChromaDistortVignette
		}

		[SettingsGroup]
		public DistortionSettings distortion = DistortionSettings.defaultSettings;

		[SettingsGroup]
		public VignetteSettings vignette = VignetteSettings.defaultSettings;

		[SettingsGroup]
		public ChromaticAberrationSettings chromaticAberration = ChromaticAberrationSettings.defaultSettings;

		[SerializeField]
		private Shader m_Shader;

		private Material m_Material;

		private RenderTextureUtility m_RTU;

		public Shader shader
		{
			get
			{
				if (m_Shader == null)
				{
					m_Shader = Shader.Find("Hidden/LensAberrations");
				}
				return m_Shader;
			}
		}

		public Material material
		{
			get
			{
				if (m_Material == null)
				{
					m_Material = ImageEffectHelper.CheckShaderAndCreateMaterial(shader);
				}
				return m_Material;
			}
		}

		private void OnEnable()
		{
			if (!ImageEffectHelper.IsSupported(shader, needDepth: false, needHdr: false, this))
			{
				base.enabled = false;
			}
			m_RTU = new RenderTextureUtility();
		}

		private void OnDisable()
		{
			if (m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(m_Material);
			}
			m_Material = null;
			m_RTU.ReleaseAllTemporaryRenderTextures();
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!vignette.enabled && !chromaticAberration.enabled && !distortion.enabled)
			{
				Graphics.Blit(source, destination);
				return;
			}
			material.shaderKeywords = null;
			if (distortion.enabled)
			{
				float val = 1.6f * Math.Max(Mathf.Abs(distortion.amount), 1f);
				float num = (float)Math.PI / 180f * Math.Min(160f, val);
				float y = 2f * Mathf.Tan(num * 0.5f);
				Vector4 vector = new Vector4(distortion.centerX, distortion.centerY, Mathf.Max(distortion.amountX, 0.0001f), Mathf.Max(distortion.amountY, 0.0001f));
				Vector3 vector2 = new Vector3((!(distortion.amount >= 0f)) ? (1f / num) : num, y, 1f / distortion.scale);
				material.EnableKeyword((!(distortion.amount >= 0f)) ? "UNDISTORT" : "DISTORT");
				material.SetVector("_DistCenterScale", vector);
				material.SetVector("_DistAmount", vector2);
			}
			if (chromaticAberration.enabled)
			{
				material.EnableKeyword("CHROMATIC_ABERRATION");
				Vector4 vector3 = new Vector4(chromaticAberration.color.r, chromaticAberration.color.g, chromaticAberration.color.b, chromaticAberration.amount * 0.001f);
				material.SetVector("_ChromaticAberration", vector3);
			}
			if (vignette.enabled)
			{
				material.SetColor("_VignetteColor", vignette.color);
				if (vignette.blur > 0f)
				{
					int num2 = source.width / 2;
					int num3 = source.height / 2;
					RenderTexture temporaryRenderTexture = m_RTU.GetTemporaryRenderTexture(num2, num3, 0, source.format);
					RenderTexture temporaryRenderTexture2 = m_RTU.GetTemporaryRenderTexture(num2, num3, 0, source.format);
					material.SetVector("_BlurPass", new Vector2(1f / (float)num2, 0f));
					Graphics.Blit(source, temporaryRenderTexture, material, 0);
					if (distortion.enabled)
					{
						material.DisableKeyword("DISTORT");
						material.DisableKeyword("UNDISTORT");
					}
					material.SetVector("_BlurPass", new Vector2(0f, 1f / (float)num3));
					Graphics.Blit(temporaryRenderTexture, temporaryRenderTexture2, material, 0);
					material.SetVector("_BlurPass", new Vector2(1f / (float)num2, 0f));
					Graphics.Blit(temporaryRenderTexture2, temporaryRenderTexture, material, 0);
					material.SetVector("_BlurPass", new Vector2(0f, 1f / (float)num3));
					Graphics.Blit(temporaryRenderTexture, temporaryRenderTexture2, material, 0);
					material.SetTexture("_BlurTex", temporaryRenderTexture2);
					material.SetFloat("_VignetteBlur", vignette.blur * 3f);
					material.EnableKeyword("VIGNETTE_BLUR");
					if (distortion.enabled)
					{
						material.EnableKeyword((!(distortion.amount >= 0f)) ? "UNDISTORT" : "DISTORT");
					}
				}
				if (vignette.desaturate > 0f)
				{
					material.EnableKeyword("VIGNETTE_DESAT");
					material.SetFloat("_VignetteDesat", 1f - vignette.desaturate);
				}
				material.SetVector("_VignetteCenter", vignette.center);
				if (Mathf.Approximately(vignette.roundness, 1f))
				{
					material.EnableKeyword("VIGNETTE_CLASSIC");
					material.SetVector("_VignetteSettings", new Vector2(vignette.intensity, vignette.smoothness));
				}
				else
				{
					material.EnableKeyword("VIGNETTE_FILMIC");
					float z = (1f - vignette.roundness) * 6f + vignette.roundness;
					material.SetVector("_VignetteSettings", new Vector3(vignette.intensity, vignette.smoothness, z));
				}
			}
			int pass = 0;
			if (vignette.enabled && chromaticAberration.enabled && distortion.enabled)
			{
				pass = 7;
			}
			else if (vignette.enabled && chromaticAberration.enabled)
			{
				pass = 5;
			}
			else if (vignette.enabled && distortion.enabled)
			{
				pass = 6;
			}
			else if (chromaticAberration.enabled && distortion.enabled)
			{
				pass = 4;
			}
			else if (vignette.enabled)
			{
				pass = 3;
			}
			else if (chromaticAberration.enabled)
			{
				pass = 1;
			}
			else if (distortion.enabled)
			{
				pass = 2;
			}
			Graphics.Blit(source, destination, material, pass);
			m_RTU.ReleaseAllTemporaryRenderTextures();
		}
	}
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Cinematic/Tonemapping and Color Grading")]
	[ImageEffectAllowedInSceneView]
	[ExecuteInEditMode]
	public class TonemappingColorGrading : MonoBehaviour
	{
		[AttributeUsage(AttributeTargets.Field)]
		public class SettingsGroup : Attribute
		{
		}

		public class IndentedGroup : PropertyAttribute
		{
		}

		public class ChannelMixer : PropertyAttribute
		{
		}

		public class ColorWheelGroup : PropertyAttribute
		{
			public int minSizePerWheel = 60;

			public int maxSizePerWheel = 150;

			public ColorWheelGroup()
			{
			}

			public ColorWheelGroup(int minSizePerWheel, int maxSizePerWheel)
			{
				this.minSizePerWheel = minSizePerWheel;
				this.maxSizePerWheel = maxSizePerWheel;
			}
		}

		public class Curve : PropertyAttribute
		{
			public Color color = Color.white;

			public Curve()
			{
			}

			public Curve(float r, float g, float b, float a)
			{
				color = new Color(r, g, b, a);
			}
		}

		[Serializable]
		public struct EyeAdaptationSettings
		{
			public bool enabled;

			[Tooltip("Midpoint Adjustment.")]
			[Min(0f)]
			public float middleGrey;

			[Tooltip("The lowest possible exposure value; adjust this value to modify the brightest areas of your level.")]
			public float min;

			[Tooltip("The highest possible exposure value; adjust this value to modify the darkest areas of your level.")]
			public float max;

			[Tooltip("Speed of linear adaptation. Higher is faster.")]
			[Min(0f)]
			public float speed;

			[Tooltip("Displays a luminosity helper in the GameView.")]
			public bool showDebug;

			public static EyeAdaptationSettings defaultSettings => new EyeAdaptationSettings
			{
				enabled = false,
				showDebug = false,
				middleGrey = 0.5f,
				min = -3f,
				max = 3f,
				speed = 1.5f
			};
		}

		public enum Tonemapper
		{
			ACES,
			Curve,
			Hable,
			HejlDawson,
			Photographic,
			Reinhard,
			Neutral
		}

		[Serializable]
		public struct TonemappingSettings
		{
			public bool enabled;

			[Tooltip("Tonemapping technique to use. ACES is the recommended one.")]
			public Tonemapper tonemapper;

			[Min(0f)]
			[Tooltip("Adjusts the overall exposure of the scene.")]
			public float exposure;

			[Tooltip("Custom tonemapping curve.")]
			public AnimationCurve curve;

			[Range(-0.1f, 0.1f)]
			public float neutralBlackIn;

			[Range(1f, 20f)]
			public float neutralWhiteIn;

			[Range(-0.09f, 0.1f)]
			public float neutralBlackOut;

			[Range(1f, 19f)]
			public float neutralWhiteOut;

			[Range(0.1f, 20f)]
			public float neutralWhiteLevel;

			[Range(1f, 10f)]
			public float neutralWhiteClip;

			public static TonemappingSettings defaultSettings => new TonemappingSettings
			{
				enabled = false,
				tonemapper = Tonemapper.Neutral,
				exposure = 1f,
				curve = CurvesSettings.defaultCurve,
				neutralBlackIn = 0.02f,
				neutralWhiteIn = 10f,
				neutralBlackOut = 0f,
				neutralWhiteOut = 10f,
				neutralWhiteLevel = 5.3f,
				neutralWhiteClip = 10f
			};
		}

		[Serializable]
		public struct LUTSettings
		{
			public bool enabled;

			[Tooltip("Custom lookup texture (strip format, e.g. 256x16).")]
			public Texture texture;

			[Tooltip("Blending factor.")]
			[Range(0f, 1f)]
			public float contribution;

			public static LUTSettings defaultSettings => new LUTSettings
			{
				enabled = false,
				texture = null,
				contribution = 1f
			};
		}

		[Serializable]
		public struct ColorWheelsSettings
		{
			[ColorUsage(false)]
			public Color shadows;

			[ColorUsage(false)]
			public Color midtones;

			[ColorUsage(false)]
			public Color highlights;

			public static ColorWheelsSettings defaultSettings => new ColorWheelsSettings
			{
				shadows = Color.white,
				midtones = Color.white,
				highlights = Color.white
			};
		}

		[Serializable]
		public struct BasicsSettings
		{
			[Tooltip("Sets the white balance to a custom color temperature.")]
			[Range(-2f, 2f)]
			public float temperatureShift;

			[Tooltip("Sets the white balance to compensate for a green or magenta tint.")]
			[Range(-2f, 2f)]
			public float tint;

			[Range(-0.5f, 0.5f)]
			[Space]
			[Tooltip("Shift the hue of all colors.")]
			public float hue;

			[Range(0f, 2f)]
			[Tooltip("Pushes the intensity of all colors.")]
			public float saturation;

			[Range(-1f, 1f)]
			[Tooltip("Adjusts the saturation so that clipping is minimized as colors approach full saturation.")]
			public float vibrance;

			[Range(0f, 10f)]
			[Tooltip("Brightens or darkens all colors.")]
			public float value;

			[Tooltip("Expands or shrinks the overall range of tonal values.")]
			[Space]
			[Range(0f, 2f)]
			public float contrast;

			[Tooltip("Contrast gain curve. Controls the steepness of the curve.")]
			[Range(0.01f, 5f)]
			public float gain;

			[Range(0.01f, 5f)]
			[Tooltip("Applies a pow function to the source.")]
			public float gamma;

			public static BasicsSettings defaultSettings => new BasicsSettings
			{
				temperatureShift = 0f,
				tint = 0f,
				contrast = 1f,
				hue = 0f,
				saturation = 1f,
				value = 1f,
				vibrance = 0f,
				gain = 1f,
				gamma = 1f
			};
		}

		[Serializable]
		public struct ChannelMixerSettings
		{
			public int currentChannel;

			public Vector3[] channels;

			public static ChannelMixerSettings defaultSettings => new ChannelMixerSettings
			{
				currentChannel = 0,
				channels = new Vector3[3]
				{
					new Vector3(1f, 0f, 0f),
					new Vector3(0f, 1f, 0f),
					new Vector3(0f, 0f, 1f)
				}
			};
		}

		[Serializable]
		public struct CurvesSettings
		{
			[Curve]
			public AnimationCurve master;

			[Curve(1f, 0f, 0f, 1f)]
			public AnimationCurve red;

			[Curve(0f, 1f, 0f, 1f)]
			public AnimationCurve green;

			[Curve(0f, 1f, 1f, 1f)]
			public AnimationCurve blue;

			public static CurvesSettings defaultSettings => new CurvesSettings
			{
				master = defaultCurve,
				red = defaultCurve,
				green = defaultCurve,
				blue = defaultCurve
			};

			public static AnimationCurve defaultCurve => new AnimationCurve(new Keyframe(0f, 0f, 1f, 1f), new Keyframe(1f, 1f, 1f, 1f));
		}

		public enum ColorGradingPrecision
		{
			Normal = 0x10,
			High = 0x20
		}

		[Serializable]
		public struct ColorGradingSettings
		{
			public bool enabled;

			[Tooltip("Internal LUT precision. \"Normal\" is 256x16, \"High\" is 1024x32. Prefer \"Normal\" on mobile devices.")]
			public ColorGradingPrecision precision;

			[ColorWheelGroup]
			[Space]
			public ColorWheelsSettings colorWheels;

			[IndentedGroup]
			[Space]
			public BasicsSettings basics;

			[Space]
			[ChannelMixer]
			public ChannelMixerSettings channelMixer;

			[Space]
			[IndentedGroup]
			public CurvesSettings curves;

			[Tooltip("Use dithering to try and minimize color banding in dark areas.")]
			[Space]
			public bool useDithering;

			[Tooltip("Displays the generated LUT in the top left corner of the GameView.")]
			public bool showDebug;

			public static ColorGradingSettings defaultSettings => new ColorGradingSettings
			{
				enabled = false,
				useDithering = false,
				showDebug = false,
				precision = ColorGradingPrecision.Normal,
				colorWheels = ColorWheelsSettings.defaultSettings,
				basics = BasicsSettings.defaultSettings,
				channelMixer = ChannelMixerSettings.defaultSettings,
				curves = CurvesSettings.defaultSettings
			};

			internal void Reset()
			{
				curves = CurvesSettings.defaultSettings;
			}
		}

		private enum Pass
		{
			LutGen,
			AdaptationLog,
			AdaptationExpBlend,
			AdaptationExp,
			TonemappingOff,
			TonemappingACES,
			TonemappingCurve,
			TonemappingHable,
			TonemappingHejlDawson,
			TonemappingPhotographic,
			TonemappingReinhard,
			TonemappingNeutral,
			AdaptationDebug
		}

		[SerializeField]
		[SettingsGroup]
		private EyeAdaptationSettings m_EyeAdaptation = EyeAdaptationSettings.defaultSettings;

		[SettingsGroup]
		[SerializeField]
		private TonemappingSettings m_Tonemapping = TonemappingSettings.defaultSettings;

		[SerializeField]
		[SettingsGroup]
		private LUTSettings m_Lut = LUTSettings.defaultSettings;

		[SettingsGroup]
		[SerializeField]
		private ColorGradingSettings m_ColorGrading = ColorGradingSettings.defaultSettings;

		private Texture2D m_IdentityLut;

		private RenderTexture m_InternalLut;

		private Texture2D m_CurveTexture;

		private Texture2D m_TonemapperCurve;

		private float m_TonemapperCurveRange;

		[SerializeField]
		private Shader m_Shader;

		private Material m_Material;

		private bool m_Dirty = true;

		private bool m_TonemapperDirty = true;

		private RenderTexture m_SmallAdaptiveRt;

		private RenderTextureFormat m_AdaptiveRtFormat;

		public EyeAdaptationSettings eyeAdaptation
		{
			get
			{
				return m_EyeAdaptation;
			}
			set
			{
				m_EyeAdaptation = value;
			}
		}

		public TonemappingSettings tonemapping
		{
			get
			{
				return m_Tonemapping;
			}
			set
			{
				m_Tonemapping = value;
				SetTonemapperDirty();
			}
		}

		public LUTSettings lut
		{
			get
			{
				return m_Lut;
			}
			set
			{
				m_Lut = value;
				SetDirty();
			}
		}

		public ColorGradingSettings colorGrading
		{
			get
			{
				return m_ColorGrading;
			}
			set
			{
				m_ColorGrading = value;
				SetDirty();
			}
		}

		private Texture2D identityLut
		{
			get
			{
				if (m_IdentityLut == null || m_IdentityLut.height != lutSize)
				{
					UnityEngine.Object.DestroyImmediate(m_IdentityLut);
					m_IdentityLut = GenerateIdentityLut(lutSize);
				}
				return m_IdentityLut;
			}
		}

		private RenderTexture internalLutRt
		{
			get
			{
				if (m_InternalLut == null || !m_InternalLut.IsCreated() || m_InternalLut.height != lutSize)
				{
					UnityEngine.Object.DestroyImmediate(m_InternalLut);
					m_InternalLut = new RenderTexture(lutSize * lutSize, lutSize, 0, RenderTextureFormat.ARGB32)
					{
						name = "Internal LUT",
						filterMode = FilterMode.Bilinear,
						anisoLevel = 0,
						hideFlags = HideFlags.DontSave
					};
				}
				return m_InternalLut;
			}
		}

		private Texture2D curveTexture
		{
			get
			{
				if (m_CurveTexture == null)
				{
					m_CurveTexture = new Texture2D(256, 1, TextureFormat.ARGB32, mipmap: false, linear: true)
					{
						name = "Curve texture",
						wrapMode = TextureWrapMode.Clamp,
						filterMode = FilterMode.Bilinear,
						anisoLevel = 0,
						hideFlags = HideFlags.DontSave
					};
				}
				return m_CurveTexture;
			}
		}

		private Texture2D tonemapperCurve
		{
			get
			{
				if (m_TonemapperCurve == null)
				{
					TextureFormat format = TextureFormat.RGB24;
					if (SystemInfo.SupportsTextureFormat(TextureFormat.RFloat))
					{
						format = TextureFormat.RFloat;
					}
					else if (SystemInfo.SupportsTextureFormat(TextureFormat.RHalf))
					{
						format = TextureFormat.RHalf;
					}
					m_TonemapperCurve = new Texture2D(256, 1, format, mipmap: false, linear: true)
					{
						name = "Tonemapper curve texture",
						wrapMode = TextureWrapMode.Clamp,
						filterMode = FilterMode.Bilinear,
						anisoLevel = 0,
						hideFlags = HideFlags.DontSave
					};
				}
				return m_TonemapperCurve;
			}
		}

		public Shader shader
		{
			get
			{
				if (m_Shader == null)
				{
					m_Shader = Shader.Find("Hidden/TonemappingColorGrading");
				}
				return m_Shader;
			}
		}

		public Material material
		{
			get
			{
				if (m_Material == null)
				{
					m_Material = ImageEffectHelper.CheckShaderAndCreateMaterial(shader);
				}
				return m_Material;
			}
		}

		public bool isGammaColorSpace => QualitySettings.activeColorSpace == ColorSpace.Gamma;

		public int lutSize => (int)colorGrading.precision;

		public bool validRenderTextureFormat { get; private set; }

		public bool validUserLutSize { get; private set; }

		public void SetDirty()
		{
			m_Dirty = true;
		}

		public void SetTonemapperDirty()
		{
			m_TonemapperDirty = true;
		}

		private void OnEnable()
		{
			if (!ImageEffectHelper.IsSupported(shader, needDepth: false, needHdr: true, this))
			{
				base.enabled = false;
				return;
			}
			SetDirty();
			SetTonemapperDirty();
		}

		private void OnDisable()
		{
			if (m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(m_Material);
			}
			if (m_IdentityLut != null)
			{
				UnityEngine.Object.DestroyImmediate(m_IdentityLut);
			}
			if (m_InternalLut != null)
			{
				UnityEngine.Object.DestroyImmediate(internalLutRt);
			}
			if (m_SmallAdaptiveRt != null)
			{
				UnityEngine.Object.DestroyImmediate(m_SmallAdaptiveRt);
			}
			if (m_CurveTexture != null)
			{
				UnityEngine.Object.DestroyImmediate(m_CurveTexture);
			}
			if (m_TonemapperCurve != null)
			{
				UnityEngine.Object.DestroyImmediate(m_TonemapperCurve);
			}
			m_Material = null;
			m_IdentityLut = null;
			m_InternalLut = null;
			m_SmallAdaptiveRt = null;
			m_CurveTexture = null;
			m_TonemapperCurve = null;
		}

		private void OnValidate()
		{
			SetDirty();
			SetTonemapperDirty();
		}

		private static Texture2D GenerateIdentityLut(int dim)
		{
			Color[] array = new Color[dim * dim * dim];
			float num = 1f / ((float)dim - 1f);
			for (int i = 0; i < dim; i++)
			{
				for (int j = 0; j < dim; j++)
				{
					for (int k = 0; k < dim; k++)
					{
						ref Color reference = ref array[i + j * dim + k * dim * dim];
						reference = new Color((float)i * num, Mathf.Abs((float)k * num), (float)j * num, 1f);
					}
				}
			}
			Texture2D texture2D = new Texture2D(dim * dim, dim, TextureFormat.RGB24, mipmap: false, linear: true);
			texture2D.name = "Identity LUT";
			texture2D.filterMode = FilterMode.Bilinear;
			texture2D.anisoLevel = 0;
			texture2D.hideFlags = HideFlags.DontSave;
			Texture2D texture2D2 = texture2D;
			texture2D2.SetPixels(array);
			texture2D2.Apply();
			return texture2D2;
		}

		private float StandardIlluminantY(float x)
		{
			return 2.87f * x - 3f * x * x - 0.27509508f;
		}

		private Vector3 CIExyToLMS(float x, float y)
		{
			float num = 1f;
			float num2 = num * x / y;
			float num3 = num * (1f - x - y) / y;
			float x2 = 0.7328f * num2 + 0.4296f * num - 0.1624f * num3;
			float y2 = -0.7036f * num2 + 1.6975f * num + 0.0061f * num3;
			float z = 0.003f * num2 + 0.0136f * num + 0.9834f * num3;
			return new Vector3(x2, y2, z);
		}

		private Vector3 GetWhiteBalance()
		{
			float temperatureShift = colorGrading.basics.temperatureShift;
			float tint = colorGrading.basics.tint;
			float x = 0.31271f - temperatureShift * ((!(temperatureShift < 0f)) ? 0.05f : 0.1f);
			float y = StandardIlluminantY(x) + tint * 0.05f;
			Vector3 vector = new Vector3(0.949237f, 1.03542f, 1.08728f);
			Vector3 vector2 = CIExyToLMS(x, y);
			return new Vector3(vector.x / vector2.x, vector.y / vector2.y, vector.z / vector2.z);
		}

		private static Color NormalizeColor(Color c)
		{
			float num = (c.r + c.g + c.b) / 3f;
			if (Mathf.Approximately(num, 0f))
			{
				return new Color(1f, 1f, 1f, 1f);
			}
			return new Color
			{
				r = c.r / num,
				g = c.g / num,
				b = c.b / num,
				a = 1f
			};
		}

		private void GenerateLiftGammaGain(out Color lift, out Color gamma, out Color gain)
		{
			Color color = NormalizeColor(colorGrading.colorWheels.shadows);
			Color color2 = NormalizeColor(colorGrading.colorWheels.midtones);
			Color color3 = NormalizeColor(colorGrading.colorWheels.highlights);
			float num = (color.r + color.g + color.b) / 3f;
			float num2 = (color2.r + color2.g + color2.b) / 3f;
			float num3 = (color3.r + color3.g + color3.b) / 3f;
			float r = (color.r - num) * 0.1f;
			float g = (color.g - num) * 0.1f;
			float b = (color.b - num) * 0.1f;
			float b2 = Mathf.Pow(2f, (color2.r - num2) * 0.5f);
			float b3 = Mathf.Pow(2f, (color2.g - num2) * 0.5f);
			float b4 = Mathf.Pow(2f, (color2.b - num2) * 0.5f);
			float r2 = Mathf.Pow(2f, (color3.r - num3) * 0.5f);
			float g2 = Mathf.Pow(2f, (color3.g - num3) * 0.5f);
			float b5 = Mathf.Pow(2f, (color3.b - num3) * 0.5f);
			float r3 = 1f / Mathf.Max(0.01f, b2);
			float g3 = 1f / Mathf.Max(0.01f, b3);
			float b6 = 1f / Mathf.Max(0.01f, b4);
			lift = new Color(r, g, b);
			gamma = new Color(r3, g3, b6);
			gain = new Color(r2, g2, b5);
		}

		private void GenCurveTexture()
		{
			AnimationCurve master = colorGrading.curves.master;
			AnimationCurve red = colorGrading.curves.red;
			AnimationCurve green = colorGrading.curves.green;
			AnimationCurve blue = colorGrading.curves.blue;
			Color[] array = new Color[256];
			for (float num = 0f; num <= 1f; num += 0.003921569f)
			{
				float a = Mathf.Clamp(master.Evaluate(num), 0f, 1f);
				float r = Mathf.Clamp(red.Evaluate(num), 0f, 1f);
				float g = Mathf.Clamp(green.Evaluate(num), 0f, 1f);
				float b = Mathf.Clamp(blue.Evaluate(num), 0f, 1f);
				ref Color reference = ref array[(int)Mathf.Floor(num * 255f)];
				reference = new Color(r, g, b, a);
			}
			curveTexture.SetPixels(array);
			curveTexture.Apply();
		}

		private bool CheckUserLut()
		{
			validUserLutSize = lut.texture.height == (int)Mathf.Sqrt(lut.texture.width);
			return validUserLutSize;
		}

		private bool CheckSmallAdaptiveRt()
		{
			if (m_SmallAdaptiveRt != null)
			{
				return false;
			}
			m_AdaptiveRtFormat = RenderTextureFormat.ARGBHalf;
			if (SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGHalf))
			{
				m_AdaptiveRtFormat = RenderTextureFormat.RGHalf;
			}
			m_SmallAdaptiveRt = new RenderTexture(1, 1, 0, m_AdaptiveRtFormat);
			m_SmallAdaptiveRt.hideFlags = HideFlags.DontSave;
			return true;
		}

		private void OnGUI()
		{
			if (Event.current.type == EventType.Repaint)
			{
				int num = 0;
				if (m_InternalLut != null && colorGrading.enabled && colorGrading.showDebug)
				{
					Graphics.DrawTexture(new Rect(0f, num, lutSize * lutSize, lutSize), internalLutRt);
					num += lutSize;
				}
				if (m_SmallAdaptiveRt != null && eyeAdaptation.enabled && eyeAdaptation.showDebug)
				{
					m_Material.SetPass(12);
					Graphics.DrawTexture(new Rect(0f, num, 256f, 16f), m_SmallAdaptiveRt, m_Material);
				}
			}
		}

		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			material.shaderKeywords = null;
			Texture texture = null;
			float w = 1f;
			RenderTexture renderTexture = null;
			RenderTexture[] array = null;
			if (eyeAdaptation.enabled)
			{
				bool flag = CheckSmallAdaptiveRt();
				int num = ((source.width >= source.height) ? source.height : source.width);
				int num2 = num;
				num2 |= num2 >> 1;
				num2 |= num2 >> 2;
				num2 |= num2 >> 4;
				num2 |= num2 >> 8;
				num2 |= num2 >> 16;
				num2 -= num2 >> 1;
				renderTexture = RenderTexture.GetTemporary(num2, num2, 0, m_AdaptiveRtFormat);
				Graphics.Blit(source, renderTexture);
				int num3 = (int)Mathf.Log(renderTexture.width, 2f);
				int num4 = 2;
				array = new RenderTexture[num3];
				for (int i = 0; i < num3; i++)
				{
					array[i] = RenderTexture.GetTemporary(renderTexture.width / num4, renderTexture.width / num4, 0, m_AdaptiveRtFormat);
					num4 <<= 1;
				}
				RenderTexture source2 = array[num3 - 1];
				Graphics.Blit(renderTexture, array[0], material, 1);
				for (int j = 0; j < num3 - 1; j++)
				{
					Graphics.Blit(array[j], array[j + 1]);
					source2 = array[j + 1];
				}
				m_SmallAdaptiveRt.MarkRestoreExpected();
				material.SetFloat("_AdaptationSpeed", Mathf.Max(eyeAdaptation.speed, 0.001f));
				Graphics.Blit(source2, m_SmallAdaptiveRt, material, (!flag) ? 2 : 3);
				material.SetFloat("_MiddleGrey", eyeAdaptation.middleGrey);
				material.SetFloat("_AdaptationMin", Mathf.Pow(2f, eyeAdaptation.min));
				material.SetFloat("_AdaptationMax", Mathf.Pow(2f, eyeAdaptation.max));
				material.SetTexture("_LumTex", m_SmallAdaptiveRt);
				material.EnableKeyword("ENABLE_EYE_ADAPTATION");
			}
			int num5 = 4;
			if (tonemapping.enabled)
			{
				if (tonemapping.tonemapper == Tonemapper.Curve)
				{
					if (m_TonemapperDirty)
					{
						float num6 = 1f;
						if (tonemapping.curve.length > 0)
						{
							num6 = tonemapping.curve[tonemapping.curve.length - 1].time;
							for (float num7 = 0f; num7 <= 1f; num7 += 0.003921569f)
							{
								float num8 = tonemapping.curve.Evaluate(num7 * num6);
								tonemapperCurve.SetPixel(Mathf.FloorToInt(num7 * 255f), 0, new Color(num8, num8, num8));
							}
							tonemapperCurve.Apply();
						}
						m_TonemapperCurveRange = 1f / num6;
						m_TonemapperDirty = false;
					}
					material.SetFloat("_ToneCurveRange", m_TonemapperCurveRange);
					material.SetTexture("_ToneCurve", tonemapperCurve);
				}
				else if (tonemapping.tonemapper == Tonemapper.Neutral)
				{
					float num9 = tonemapping.neutralBlackIn * 20f + 1f;
					float num10 = tonemapping.neutralBlackOut * 10f + 1f;
					float num11 = tonemapping.neutralWhiteIn / 20f;
					float num12 = 1f - tonemapping.neutralWhiteOut / 20f;
					float t = num9 / num10;
					float t2 = num11 / num12;
					float y = Mathf.Max(0f, Mathf.LerpUnclamped(0.57f, 0.37f, t));
					float z = Mathf.LerpUnclamped(0.01f, 0.24f, t2);
					float w2 = Mathf.Max(0f, Mathf.LerpUnclamped(0.02f, 0.2f, t));
					material.SetVector("_NeutralTonemapperParams1", new Vector4(0.2f, y, z, w2));
					material.SetVector("_NeutralTonemapperParams2", new Vector4(0.02f, 0.3f, tonemapping.neutralWhiteLevel, tonemapping.neutralWhiteClip / 10f));
				}
				material.SetFloat("_Exposure", tonemapping.exposure);
				num5 = (int)(num5 + (tonemapping.tonemapper + 1));
			}
			if (lut.enabled)
			{
				Texture texture2 = lut.texture;
				if (lut.texture == null || !CheckUserLut())
				{
					texture2 = identityLut;
				}
				texture = texture2;
				w = lut.contribution;
				material.EnableKeyword("ENABLE_COLOR_GRADING");
			}
			if (colorGrading.enabled)
			{
				if (m_Dirty || !m_InternalLut.IsCreated())
				{
					if (texture == null)
					{
						material.SetVector("_UserLutParams", new Vector4(1f / (float)identityLut.width, 1f / (float)identityLut.height, (float)identityLut.height - 1f, 1f));
						material.SetTexture("_UserLutTex", identityLut);
					}
					else
					{
						material.SetVector("_UserLutParams", new Vector4(1f / (float)texture.width, 1f / (float)texture.height, (float)texture.height - 1f, lut.contribution));
						material.SetTexture("_UserLutTex", texture);
					}
					GenerateLiftGammaGain(out var lift, out var gamma, out var gain);
					GenCurveTexture();
					material.SetVector("_WhiteBalance", GetWhiteBalance());
					material.SetVector("_Lift", lift);
					material.SetVector("_Gamma", gamma);
					material.SetVector("_Gain", gain);
					material.SetVector("_ContrastGainGamma", new Vector3(colorGrading.basics.contrast, colorGrading.basics.gain, 1f / colorGrading.basics.gamma));
					material.SetFloat("_Vibrance", colorGrading.basics.vibrance);
					material.SetVector("_HSV", new Vector4(colorGrading.basics.hue, colorGrading.basics.saturation, colorGrading.basics.value));
					material.SetVector("_ChannelMixerRed", colorGrading.channelMixer.channels[0]);
					material.SetVector("_ChannelMixerGreen", colorGrading.channelMixer.channels[1]);
					material.SetVector("_ChannelMixerBlue", colorGrading.channelMixer.channels[2]);
					material.SetTexture("_CurveTex", curveTexture);
					internalLutRt.MarkRestoreExpected();
					Graphics.Blit(identityLut, internalLutRt, material, 0);
					m_Dirty = false;
				}
				texture = internalLutRt;
				w = 1f;
				material.EnableKeyword("ENABLE_COLOR_GRADING");
				if (colorGrading.useDithering)
				{
					material.EnableKeyword("ENABLE_DITHERING");
				}
			}
			if (texture != null)
			{
				material.SetTexture("_LutTex", texture);
				material.SetVector("_LutParams", new Vector4(1f / (float)texture.width, 1f / (float)texture.height, (float)texture.height - 1f, w));
			}
			Graphics.Blit(source, destination, material, num5);
			if (eyeAdaptation.enabled)
			{
				for (int k = 0; k < array.Length; k++)
				{
					RenderTexture.ReleaseTemporary(array[k]);
				}
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		public Texture2D BakeLUT()
		{
			Texture2D texture2D = new Texture2D(internalLutRt.width, internalLutRt.height, TextureFormat.RGB24, mipmap: false, linear: true);
			RenderTexture.active = internalLutRt;
			texture2D.ReadPixels(new Rect(0f, 0f, texture2D.width, texture2D.height), 0, 0);
			RenderTexture.active = null;
			return texture2D;
		}
	}
}
namespace UnityStandardAssets.ImageEffects
{
	public enum AAMode
	{
		FXAA2,
		FXAA3Console,
		FXAA1PresetA,
		FXAA1PresetB,
		NFAA,
		SSAA,
		DLAA
	}
	[AddComponentMenu("Image Effects/Other/Antialiasing")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class Antialiasing : PostEffectsBase
	{
		public AAMode mode = AAMode.FXAA3Console;

		public bool showGeneratedNormals;

		public float offsetScale = 0.2f;

		public float blurRadius = 18f;

		public float edgeThresholdMin = 0.05f;

		public float edgeThreshold = 0.2f;

		public float edgeSharpness = 4f;

		public bool dlaaSharp;

		public Shader ssaaShader;

		private Material ssaa;

		public Shader dlaaShader;

		private Material dlaa;

		public Shader nfaaShader;

		private Material nfaa;

		public Shader shaderFXAAPreset2;

		private Material materialFXAAPreset2;

		public Shader shaderFXAAPreset3;

		private Material materialFXAAPreset3;

		public Shader shaderFXAAII;

		private Material materialFXAAII;

		public Shader shaderFXAAIII;

		private Material materialFXAAIII;

		public Material CurrentAAMaterial()
		{
			Material material = null;
			return mode switch
			{
				AAMode.FXAA3Console => materialFXAAIII, 
				AAMode.FXAA2 => materialFXAAII, 
				AAMode.FXAA1PresetA => materialFXAAPreset2, 
				AAMode.FXAA1PresetB => materialFXAAPreset3, 
				AAMode.NFAA => nfaa, 
				AAMode.SSAA => ssaa, 
				AAMode.DLAA => dlaa, 
				_ => null, 
			};
		}

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			materialFXAAPreset2 = CreateMaterial(shaderFXAAPreset2, materialFXAAPreset2);
			materialFXAAPreset3 = CreateMaterial(shaderFXAAPreset3, materialFXAAPreset3);
			materialFXAAII = CreateMaterial(shaderFXAAII, materialFXAAII);
			materialFXAAIII = CreateMaterial(shaderFXAAIII, materialFXAAIII);
			nfaa = CreateMaterial(nfaaShader, nfaa);
			ssaa = CreateMaterial(ssaaShader, ssaa);
			dlaa = CreateMaterial(dlaaShader, dlaa);
			if (!ssaaShader.isSupported)
			{
				NotSupported();
				ReportAutoDisable();
			}
			return isSupported;
		}

		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
			}
			else if (mode == AAMode.FXAA3Console && materialFXAAIII != null)
			{
				materialFXAAIII.SetFloat("_EdgeThresholdMin", edgeThresholdMin);
				materialFXAAIII.SetFloat("_EdgeThreshold", edgeThreshold);
				materialFXAAIII.SetFloat("_EdgeSharpness", edgeSharpness);
				Graphics.Blit(source, destination, materialFXAAIII);
			}
			else if (mode == AAMode.FXAA1PresetB && materialFXAAPreset3 != null)
			{
				Graphics.Blit(source, destination, materialFXAAPreset3);
			}
			else if (mode == AAMode.FXAA1PresetA && materialFXAAPreset2 != null)
			{
				source.anisoLevel = 4;
				Graphics.Blit(source, destination, materialFXAAPreset2);
				source.anisoLevel = 0;
			}
			else if (mode == AAMode.FXAA2 && materialFXAAII != null)
			{
				Graphics.Blit(source, destination, materialFXAAII);
			}
			else if (mode == AAMode.SSAA && ssaa != null)
			{
				Graphics.Blit(source, destination, ssaa);
			}
			else if (mode == AAMode.DLAA && dlaa != null)
			{
				source.anisoLevel = 0;
				RenderTexture temporary = RenderTexture.GetTemporary(source.width, source.height);
				Graphics.Blit(source, temporary, dlaa, 0);
				Graphics.Blit(temporary, destination, dlaa, (!dlaaSharp) ? 1 : 2);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (mode == AAMode.NFAA && nfaa != null)
			{
				source.anisoLevel = 0;
				nfaa.SetFloat("_OffsetScale", offsetScale);
				nfaa.SetFloat("_BlurRadius", blurRadius);
				Graphics.Blit(source, destination, nfaa, showGeneratedNormals ? 1 : 0);
			}
			else
			{
				Graphics.Blit(source, destination);
			}
		}
	}
	[AddComponentMenu("Image Effects/Bloom and Glow/Bloom")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class Bloom : PostEffectsBase
	{
		public enum LensFlareStyle
		{
			Ghosting,
			Anamorphic,
			Combined
		}

		public enum TweakMode
		{
			Basic,
			Complex
		}

		public enum HDRBloomMode
		{
			Auto,
			On,
			Off
		}

		public enum BloomScreenBlendMode
		{
			Screen,
			Add
		}

		public enum BloomQuality
		{
			Cheap,
			High
		}

		public TweakMode tweakMode;

		public BloomScreenBlendMode screenBlendMode = BloomScreenBlendMode.Add;

		public HDRBloomMode hdr;

		private bool doHdr;

		public float sepBlurSpread = 2.5f;

		public BloomQuality quality = BloomQuality.High;

		public float bloomIntensity = 0.5f;

		public float bloomThreshold = 0.5f;

		public Color bloomThresholdColor = Color.white;

		public int bloomBlurIterations = 2;

		public int hollywoodFlareBlurIterations = 2;

		public float flareRotation;

		public LensFlareStyle lensflareMode = LensFlareStyle.Anamorphic;

		public float hollyStretchWidth = 2.5f;

		public float lensflareIntensity;

		public float lensflareThreshold = 0.3f;

		public float lensFlareSaturation = 0.75f;

		public Color flareColorA = new Color(0.4f, 0.4f, 0.8f, 0.75f);

		public Color flareColorB = new Color(0.4f, 0.8f, 0.8f, 0.75f);

		public Color flareColorC = new Color(0.8f, 0.4f, 0.8f, 0.75f);

		public Color flareColorD = new Color(0.8f, 0.4f, 0f, 0.75f);

		public Texture2D lensFlareVignetteMask;

		public Shader lensFlareShader;

		private Material lensFlareMaterial;

		public Shader screenBlendShader;

		private Material screenBlend;

		public Shader blurAndFlaresShader;

		private Material blurAndFlaresMaterial;

		public Shader brightPassFilterShader;

		private Material brightPassFilterMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			screenBlend = CheckShaderAndCreateMaterial(screenBlendShader, screenBlend);
			lensFlareMaterial = CheckShaderAndCreateMaterial(lensFlareShader, lensFlareMaterial);
			blurAndFlaresMaterial = CheckShaderAndCreateMaterial(blurAndFlaresShader, blurAndFlaresMaterial);
			brightPassFilterMaterial = CheckShaderAndCreateMaterial(brightPassFilterShader, brightPassFilterMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			doHdr = false;
			if (hdr == HDRBloomMode.Auto)
			{
				doHdr = source.format == RenderTextureFormat.ARGBHalf && GetComponent<Camera>().hdr;
			}
			else
			{
				doHdr = hdr == HDRBloomMode.On;
			}
			doHdr = doHdr && supportHDRTextures;
			BloomScreenBlendMode bloomScreenBlendMode = screenBlendMode;
			if (doHdr)
			{
				bloomScreenBlendMode = BloomScreenBlendMode.Add;
			}
			RenderTextureFormat format = ((!doHdr) ? RenderTextureFormat.Default : RenderTextureFormat.ARGBHalf);
			int width = source.width / 2;
			int height = source.height / 2;
			int width2 = source.width / 4;
			int height2 = source.height / 4;
			float num = 1f * (float)source.width / (1f * (float)source.height);
			float num2 = 0.001953125f;
			RenderTexture temporary = RenderTexture.GetTemporary(width2, height2, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0, format);
			if (quality > BloomQuality.Cheap)
			{
				Graphics.Blit(source, temporary2, screenBlend, 2);
				RenderTexture temporary3 = RenderTexture.GetTemporary(width2, height2, 0, format);
				Graphics.Blit(temporary2, temporary3, screenBlend, 2);
				Graphics.Blit(temporary3, temporary, screenBlend, 6);
				RenderTexture.ReleaseTemporary(temporary3);
			}
			else
			{
				Graphics.Blit(source, temporary2);
				Graphics.Blit(temporary2, temporary, screenBlend, 6);
			}
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width2, height2, 0, format);
			BrightFilter(bloomThreshold * bloomThresholdColor, temporary, renderTexture);
			if (bloomBlurIterations < 1)
			{
				bloomBlurIterations = 1;
			}
			else if (bloomBlurIterations > 10)
			{
				bloomBlurIterations = 10;
			}
			for (int i = 0; i < bloomBlurIterations; i++)
			{
				float num3 = (1f + (float)i * 0.25f) * sepBlurSpread;
				RenderTexture temporary4 = RenderTexture.GetTemporary(width2, height2, 0, format);
				blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(0f, num3 * num2, 0f, 0f));
				Graphics.Blit(renderTexture, temporary4, blurAndFlaresMaterial, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				temporary4 = RenderTexture.GetTemporary(width2, height2, 0, format);
				blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num3 / num * num2, 0f, 0f, 0f));
				Graphics.Blit(renderTexture, temporary4, blurAndFlaresMaterial, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				if (quality > BloomQuality.Cheap)
				{
					if (i == 0)
					{
						Graphics.SetRenderTarget(temporary);
						GL.Clear(clearDepth: false, clearColor: true, Color.black);
						Graphics.Blit(renderTexture, temporary);
					}
					else
					{
						temporary.MarkRestoreExpected();
						Graphics.Blit(renderTexture, temporary, screenBlend, 10);
					}
				}
			}
			if (quality > BloomQuality.Cheap)
			{
				Graphics.SetRenderTarget(renderTexture);
				GL.Clear(clearDepth: false, clearColor: true, Color.black);
				Graphics.Blit(temporary, renderTexture, screenBlend, 6);
			}
			if (lensflareIntensity > Mathf.Epsilon)
			{
				RenderTexture temporary5 = RenderTexture.GetTemporary(width2, height2, 0, format);
				if (lensflareMode == LensFlareStyle.Ghosting)
				{
					BrightFilter(lensflareThreshold, renderTexture, temporary5);
					if (quality > BloomQuality.Cheap)
					{
						blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(0f, 1.5f / (1f * (float)temporary.height), 0f, 0f));
						Graphics.SetRenderTarget(temporary);
						GL.Clear(clearDepth: false, clearColor: true, Color.black);
						Graphics.Blit(temporary5, temporary, blurAndFlaresMaterial, 4);
						blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(1.5f / (1f * (float)temporary.width), 0f, 0f, 0f));
						Graphics.SetRenderTarget(temporary5);
						GL.Clear(clearDepth: false, clearColor: true, Color.black);
						Graphics.Blit(temporary, temporary5, blurAndFlaresMaterial, 4);
					}
					Vignette(0.975f, temporary5, temporary5);
					BlendFlares(temporary5, renderTexture);
				}
				else
				{
					float num4 = 1f * Mathf.Cos(flareRotation);
					float num5 = 1f * Mathf.Sin(flareRotation);
					float num6 = hollyStretchWidth * 1f / num * num2;
					blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num4, num5, 0f, 0f));
					blurAndFlaresMaterial.SetVector("_Threshhold", new Vector4(lensflareThreshold, 1f, 0f, 0f));
					blurAndFlaresMaterial.SetVector("_TintColor", new Vector4(flareColorA.r, flareColorA.g, flareColorA.b, flareColorA.a) * flareColorA.a * lensflareIntensity);
					blurAndFlaresMaterial.SetFloat("_Saturation", lensFlareSaturation);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, blurAndFlaresMaterial, 2);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, blurAndFlaresMaterial, 3);
					blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num4 * num6, num5 * num6, 0f, 0f));
					blurAndFlaresMaterial.SetFloat("_StretchWidth", hollyStretchWidth);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, blurAndFlaresMaterial, 1);
					blurAndFlaresMaterial.SetFloat("_StretchWidth", hollyStretchWidth * 2f);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, blurAndFlaresMaterial, 1);
					blurAndFlaresMaterial.SetFloat("_StretchWidth", hollyStretchWidth * 4f);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, blurAndFlaresMaterial, 1);
					for (int j = 0; j < hollywoodFlareBlurIterations; j++)
					{
						num6 = hollyStretchWidth * 2f / num * num2;
						blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num6 * num4, num6 * num5, 0f, 0f));
						temporary5.DiscardContents();
						Graphics.Blit(temporary, temporary5, blurAndFlaresMaterial, 4);
						blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num6 * num4, num6 * num5, 0f, 0f));
						temporary.DiscardContents();
						Graphics.Blit(temporary5, temporary, blurAndFlaresMaterial, 4);
					}
					if (lensflareMode == LensFlareStyle.Anamorphic)
					{
						AddTo(1f, temporary, renderTexture);
					}
					else
					{
						Vignette(1f, temporary, temporary5);
						BlendFlares(temporary5, temporary);
						AddTo(1f, temporary, renderTexture);
					}
				}
				RenderTexture.ReleaseTemporary(temporary5);
			}
			int pass = (int)bloomScreenBlendMode;
			screenBlend.SetFloat("_Intensity", bloomIntensity);
			screenBlend.SetTexture("_ColorBuffer", source);
			if (quality > BloomQuality.Cheap)
			{
				RenderTexture temporary6 = RenderTexture.GetTemporary(width, height, 0, format);
				Graphics.Blit(renderTexture, temporary6);
				Graphics.Blit(temporary6, destination, screenBlend, pass);
				RenderTexture.ReleaseTemporary(temporary6);
			}
			else
			{
				Graphics.Blit(renderTexture, destination, screenBlend, pass);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
			screenBlend.SetFloat("_Intensity", intensity_);
			to.MarkRestoreExpected();
			Graphics.Blit(from, to, screenBlend, 9);
		}

		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
			lensFlareMaterial.SetVector("colorA", new Vector4(flareColorA.r, flareColorA.g, flareColorA.b, flareColorA.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorB", new Vector4(flareColorB.r, flareColorB.g, flareColorB.b, flareColorB.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorC", new Vector4(flareColorC.r, flareColorC.g, flareColorC.b, flareColorC.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorD", new Vector4(flareColorD.r, flareColorD.g, flareColorD.b, flareColorD.a) * lensflareIntensity);
			to.MarkRestoreExpected();
			Graphics.Blit(from, to, lensFlareMaterial);
		}

		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
			brightPassFilterMaterial.SetVector("_Threshhold", new Vector4(thresh, thresh, thresh, thresh));
			Graphics.Blit(from, to, brightPassFilterMaterial, 0);
		}

		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
			brightPassFilterMaterial.SetVector("_Threshhold", threshColor);
			Graphics.Blit(from, to, brightPassFilterMaterial, 1);
		}

		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
			if ((bool)lensFlareVignetteMask)
			{
				screenBlend.SetTexture("_ColorBuffer", lensFlareVignetteMask);
				to.MarkRestoreExpected();
				Graphics.Blit((!(from == to)) ? from : null, to, screenBlend, (!(from == to)) ? 3 : 7);
			}
			else if (from != to)
			{
				Graphics.SetRenderTarget(to);
				GL.Clear(clearDepth: false, clearColor: true, Color.black);
				Graphics.Blit(from, to);
			}
		}
	}
	public enum LensflareStyle34
	{
		Ghosting,
		Anamorphic,
		Combined
	}
	public enum TweakMode34
	{
		Basic,
		Complex
	}
	public enum HDRBloomMode
	{
		Auto,
		On,
		Off
	}
	public enum BloomScreenBlendMode
	{
		Screen,
		Add
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Bloom and Glow/BloomAndFlares (3.5, Deprecated)")]
	[RequireComponent(typeof(Camera))]
	public class BloomAndFlares : PostEffectsBase
	{
		public TweakMode34 tweakMode;

		public BloomScreenBlendMode screenBlendMode = BloomScreenBlendMode.Add;

		public HDRBloomMode hdr;

		private bool doHdr;

		public float sepBlurSpread = 1.5f;

		public float useSrcAlphaAsMask = 0.5f;

		public float bloomIntensity = 1f;

		public float bloomThreshold = 0.5f;

		public int bloomBlurIterations = 2;

		public bool lensflares;

		public int hollywoodFlareBlurIterations = 2;

		public LensflareStyle34 lensflareMode = LensflareStyle34.Anamorphic;

		public float hollyStretchWidth = 3.5f;

		public float lensflareIntensity = 1f;

		public float lensflareThreshold = 0.3f;

		public Color flareColorA = new Color(0.4f, 0.4f, 0.8f, 0.75f);

		public Color flareColorB = new Color(0.4f, 0.8f, 0.8f, 0.75f);

		public Color flareColorC = new Color(0.8f, 0.4f, 0.8f, 0.75f);

		public Color flareColorD = new Color(0.8f, 0.4f, 0f, 0.75f);

		public Texture2D lensFlareVignetteMask;

		public Shader lensFlareShader;

		private Material lensFlareMaterial;

		public Shader vignetteShader;

		private Material vignetteMaterial;

		public Shader separableBlurShader;

		private Material separableBlurMaterial;

		public Shader addBrightStuffOneOneShader;

		private Material addBrightStuffBlendOneOneMaterial;

		public Shader screenBlendShader;

		private Material screenBlend;

		public Shader hollywoodFlaresShader;

		private Material hollywoodFlaresMaterial;

		public Shader brightPassFilterShader;

		private Material brightPassFilterMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			screenBlend = CheckShaderAndCreateMaterial(screenBlendShader, screenBlend);
			lensFlareMaterial = CheckShaderAndCreateMaterial(lensFlareShader, lensFlareMaterial);
			vignetteMaterial = CheckShaderAndCreateMaterial(vignetteShader, vignetteMaterial);
			separableBlurMaterial = CheckShaderAndCreateMaterial(separableBlurShader, separableBlurMaterial);
			addBrightStuffBlendOneOneMaterial = CheckShaderAndCreateMaterial(addBrightStuffOneOneShader, addBrightStuffBlendOneOneMaterial);
			hollywoodFlaresMaterial = CheckShaderAndCreateMaterial(hollywoodFlaresShader, hollywoodFlaresMaterial);
			brightPassFilterMaterial = CheckShaderAndCreateMaterial(brightPassFilterShader, brightPassFilterMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			doHdr = false;
			if (hdr == HDRBloomMode.Auto)
			{
				doHdr = source.format == RenderTextureFormat.ARGBHalf && GetComponent<Camera>().hdr;
			}
			else
			{
				doHdr = hdr == HDRBloomMode.On;
			}
			doHdr = doHdr && supportHDRTextures;
			BloomScreenBlendMode pass = screenBlendMode;
			if (doHdr)
			{
				pass = BloomScreenBlendMode.Add;
			}
			RenderTextureFormat format = ((!doHdr) ? RenderTextureFormat.Default : RenderTextureFormat.ARGBHalf);
			RenderTexture temporary = RenderTexture.GetTemporary(source.width / 2, source.height / 2, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0, format);
			float num = 1f * (float)source.width / (1f * (float)source.height);
			float num2 = 0.001953125f;
			Graphics.Blit(source, temporary, screenBlend, 2);
			Graphics.Blit(temporary, temporary2, screenBlend, 2);
			RenderTexture.ReleaseTemporary(temporary);
			BrightFilter(bloomThreshold, useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (bloomBlurIterations < 1)
			{
				bloomBlurIterations = 1;
			}
			for (int i = 0; i < bloomBlurIterations; i++)
			{
				float num3 = (1f + (float)i * 0.5f) * sepBlurSpread;
				separableBlurMaterial.SetVector("offsets", new Vector4(0f, num3 * num2, 0f, 0f));
				RenderTexture renderTexture = ((i != 0) ? temporary2 : temporary3);
				Graphics.Blit(renderTexture, temporary4, separableBlurMaterial);
				renderTexture.DiscardContents();
				separableBlurMaterial.SetVector("offsets", new Vector4(num3 / num * num2, 0f, 0f, 0f));
				Graphics.Blit(temporary4, temporary2, separableBlurMaterial);
				temporary4.DiscardContents();
			}
			if (lensflares)
			{
				if (lensflareMode == LensflareStyle34.Ghosting)
				{
					BrightFilter(lensflareThreshold, 0f, temporary2, temporary4);
					temporary2.DiscardContents();
					Vignette(0.975f, temporary4, temporary3);
					temporary4.DiscardContents();
					BlendFlares(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					hollywoodFlaresMaterial.SetVector("_threshold", new Vector4(lensflareThreshold, 1f / (1f - lensflareThreshold), 0f, 0f));
					hollywoodFlaresMaterial.SetVector("tintColor", new Vector4(flareColorA.r, flareColorA.g, flareColorA.b, flareColorA.a) * flareColorA.a * lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, hollywoodFlaresMaterial, 2);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, hollywoodFlaresMaterial, 3);
					temporary3.DiscardContents();
					hollywoodFlaresMaterial.SetVector("offsets", new Vector4(sepBlurSpread * 1f / num * num2, 0f, 0f, 0f));
					hollywoodFlaresMaterial.SetFloat("stretchWidth", hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, hollywoodFlaresMaterial, 1);
					temporary4.DiscardContents();
					hollywoodFlaresMaterial.SetFloat("stretchWidth", hollyStretchWidth * 2f);
					Graphics.Blit(temporary3, temporary4, hollywoodFlaresMaterial, 1);
					temporary3.DiscardContents();
					hollywoodFlaresMaterial.SetFloat("stretchWidth", hollyStretchWidth * 4f);
					Graphics.Blit(temporary4, temporary3, hollywoodFlaresMaterial, 1);
					temporary4.DiscardContents();
					if (lensflareMode == LensflareStyle34.Anamorphic)
					{
						for (int j = 0; j < hollywoodFlareBlurIterations; j++)
						{
							separableBlurMaterial.SetVector("offsets", new Vector4(hollyStretchWidth * 2f / num * num2, 0f, 0f, 0f));
							Graphics.Blit(temporary3, temporary4, separableBlurMaterial);
							temporary3.DiscardContents();
							separableBlurMaterial.SetVector("offsets", new Vector4(hollyStretchWidth * 2f / num * num2, 0f, 0f, 0f));
							Graphics.Blit(temporary4, temporary3, separableBlurMaterial);
							temporary4.DiscardContents();
						}
						AddTo(1f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 0; k < hollywoodFlareBlurIterations; k++)
						{
							separableBlurMaterial.SetVector("offsets", new Vector4(hollyStretchWidth * 2f / num * num2, 0f, 0f, 0f));
							Graphics.Blit(temporary3, temporary4, separableBlurMaterial);
							temporary3.DiscardContents();
							separableBlurMaterial.SetVector("offsets", new Vector4(hollyStretchWidth * 2f / num * num2, 0f, 0f, 0f));
							Graphics.Blit(temporary4, temporary3, separableBlurMaterial);
							temporary4.DiscardContents();
						}
						Vignette(1f, temporary3, temporary4);
						temporary3.DiscardContents();
						BlendFlares(temporary4, temporary3);
						temporary4.DiscardContents();
						AddTo(1f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			screenBlend.SetFloat("_Intensity", bloomIntensity);
			screenBlend.SetTexture("_ColorBuffer", source);
			Graphics.Blit(temporary2, destination, screenBlend, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
			addBrightStuffBlendOneOneMaterial.SetFloat("_Intensity", intensity_);
			Graphics.Blit(from, to, addBrightStuffBlendOneOneMaterial);
		}

		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
			lensFlareMaterial.SetVector("colorA", new Vector4(flareColorA.r, flareColorA.g, flareColorA.b, flareColorA.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorB", new Vector4(flareColorB.r, flareColorB.g, flareColorB.b, flareColorB.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorC", new Vector4(flareColorC.r, flareColorC.g, flareColorC.b, flareColorC.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorD", new Vector4(flareColorD.r, flareColorD.g, flareColorD.b, flareColorD.a) * lensflareIntensity);
			Graphics.Blit(from, to, lensFlareMaterial);
		}

		private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
		{
			if (doHdr)
			{
				brightPassFilterMaterial.SetVector("threshold", new Vector4(thresh, 1f, 0f, 0f));
			}
			else
			{
				brightPassFilterMaterial.SetVector("threshold", new Vector4(thresh, 1f / (1f - thresh), 0f, 0f));
			}
			brightPassFilterMaterial.SetFloat("useSrcAlphaAsMask", useAlphaAsMask);
			Graphics.Blit(from, to, brightPassFilterMaterial);
		}

		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
			if ((bool)lensFlareVignetteMask)
			{
				screenBlend.SetTexture("_ColorBuffer", lensFlareVignetteMask);
				Graphics.Blit(from, to, screenBlend, 3);
			}
			else
			{
				vignetteMaterial.SetFloat("vignetteIntensity", amount);
				Graphics.Blit(from, to, vignetteMaterial);
			}
		}
	}
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Bloom and Glow/Bloom (Optimized)")]
	[ExecuteInEditMode]
	public class BloomOptimized : PostEffectsBase
	{
		public enum Resolution
		{
			Low,
			High
		}

		public enum BlurType
		{
			Standard,
			Sgx
		}

		[Range(0f, 1.5f)]
		public float threshold = 0.25f;

		[Range(0f, 2.5f)]
		public float intensity = 0.75f;

		[Range(0.25f, 5.5f)]
		public float blurSize = 1f;

		private Resolution resolution;

		[Range(1f, 4f)]
		public int blurIterations = 1;

		public BlurType blurType;

		public Shader fastBloomShader;

		private Material fastBloomMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			fastBloomMaterial = CheckShaderAndCreateMaterial(fastBloomShader, fastBloomMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnDisable()
		{
			if ((bool)fastBloomMaterial)
			{
				UnityEngine.Object.DestroyImmediate(fastBloomMaterial);
			}
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			int num = ((resolution != Resolution.Low) ? 2 : 4);
			float num2 = ((resolution != Resolution.Low) ? 1f : 0.5f);
			fastBloomMaterial.SetVector("_Parameter", new Vector4(blurSize * num2, 0f, threshold, intensity));
			source.filterMode = FilterMode.Bilinear;
			int width = source.width / num;
			int height = source.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, source.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, fastBloomMaterial, 1);
			int num3 = ((blurType != BlurType.Standard) ? 2 : 0);
			for (int i = 0; i < blurIterations; i++)
			{
				fastBloomMaterial.SetVector("_Parameter", new Vector4(blurSize * num2 + (float)i * 1f, 0f, threshold, intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, source.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, fastBloomMaterial, 2 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, source.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, fastBloomMaterial, 3 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			fastBloomMaterial.SetTexture("_Bloom", renderTexture);
			Graphics.Blit(source, destination, fastBloomMaterial, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
	}
	[AddComponentMenu("Image Effects/Blur/Blur")]
	[ExecuteInEditMode]
	public class Blur : MonoBehaviour
	{
		[Range(0f, 10f)]
		public int iterations = 3;

		[Range(0f, 1f)]
		public float blurSpread = 0.6f;

		public Shader blurShader;

		private static Material m_Material;

		protected Material material
		{
			get
			{
				if (m_Material == null)
				{
					m_Material = new Material(blurShader);
					m_Material.hideFlags = HideFlags.DontSave;
				}
				return m_Material;
			}
		}

		protected void OnDisable()
		{
			if ((bool)m_Material)
			{
				UnityEngine.Object.DestroyImmediate(m_Material);
			}
		}

		protected void Start()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
			}
			else if (!blurShader || !material.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
		{
			float num = 0.5f + (float)iteration * blurSpread;
			Graphics.BlitMultiTap(source, dest, material, new Vector2(0f - num, 0f - num), new Vector2(0f - num, num), new Vector2(num, num), new Vector2(num, 0f - num));
		}

		private void DownSample4x(RenderTexture source, RenderTexture dest)
		{
			float num = 1f;
			Graphics.BlitMultiTap(source, dest, material, new Vector2(0f - num, 0f - num), new Vector2(0f - num, num), new Vector2(num, num), new Vector2(num, 0f - num));
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			int width = source.width / 4;
			int height = source.height / 4;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0);
			DownSample4x(source, renderTexture);
			for (int i = 0; i < iterations; i++)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				FourTapCone(renderTexture, temporary, i);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, destination);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
	}
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Blur/Blur (Optimized)")]
	[ExecuteInEditMode]
	public class BlurOptimized : PostEffectsBase
	{
		public enum BlurType
		{
			StandardGauss,
			SgxGauss
		}

		[Range(0f, 2f)]
		public int downsample = 1;

		[Range(0f, 10f)]
		public float blurSize = 3f;

		[Range(1f, 4f)]
		public int blurIterations = 2;

		public BlurType blurType;

		public Shader blurShader;

		private Material blurMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			blurMaterial = CheckShaderAndCreateMaterial(blurShader, blurMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		public void OnDisable()
		{
			if ((bool)blurMaterial)
			{
				UnityEngine.Object.DestroyImmediate(blurMaterial);
			}
		}

		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			float num = 1f / (1f * (float)(1 << downsample));
			blurMaterial.SetVector("_Parameter", new Vector4(blurSize * num, (0f - blurSize) * num, 0f, 0f));
			source.filterMode = FilterMode.Bilinear;
			int width = source.width >> downsample;
			int height = source.height >> downsample;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, source.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, blurMaterial, 0);
			int num2 = ((blurType != BlurType.StandardGauss) ? 2 : 0);
			for (int i = 0; i < blurIterations; i++)
			{
				float num3 = (float)i * 1f;
				blurMaterial.SetVector("_Parameter", new Vector4(blurSize * num + num3, (0f - blurSize) * num - num3, 0f, 0f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, source.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, blurMaterial, 1 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, source.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, blurMaterial, 2 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, destination);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
	}
	[AddComponentMenu("Image Effects/Camera/Camera Motion Blur")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class CameraMotionBlur : PostEffectsBase
	{
		public enum MotionBlurFilter
		{
			CameraMotion,
			LocalBlur,
			Reconstruction,
			ReconstructionDX11,
			ReconstructionDisc
		}

		private static float MAX_RADIUS = 10f;

		public MotionBlurFilter filterType = MotionBlurFilter.Reconstruction;

		public bool preview;

		public Vector3 previewScale = Vector3.one;

		public float movementScale;

		public float rotationScale = 1f;

		public float maxVelocity = 8f;

		public float minVelocity = 0.1f;

		public float velocityScale = 0.375f;

		public float softZDistance = 0.005f;

		public int velocityDownsample = 1;

		public LayerMask excludeLayers = 0;

		private GameObject tmpCam;

		public Shader shader;

		public Shader dx11MotionBlurShader;

		public Shader replacementClear;

		private Material motionBlurMaterial;

		private Material dx11MotionBlurMaterial;

		public Texture2D noiseTexture;

		public float jitter = 0.05f;

		public bool showVelocity;

		public float showVelocityScale = 1f;

		private Matrix4x4 currentViewProjMat;

		private Matrix4x4[] currentStereoViewProjMat;

		private Matrix4x4 prevViewProjMat;

		private Matrix4x4[] prevStereoViewProjMat;

		private int prevFrameCount;

		private bool wasActive;

		private Vector3 prevFrameForward = Vector3.forward;

		private Vector3 prevFrameUp = Vector3.up;

		private Vector3 prevFramePos = Vector3.zero;

		private Camera _camera;

		private void CalculateViewProjection()
		{
			Matrix4x4 worldToCameraMatrix = _camera.worldToCameraMatrix;
			Matrix4x4 gPUProjectionMatrix = GL.GetGPUProjectionMatrix(_camera.projectionMatrix, renderIntoTexture: true);
			currentViewProjMat = gPUProjectionMatrix * worldToCameraMatrix;
			if (_camera.stereoEnabled)
			{
				for (int i = 0; i < 2; i++)
				{
					Matrix4x4 stereoViewMatrix = _camera.GetStereoViewMatrix((i != 0) ? Camera.StereoscopicEye.Right : Camera.StereoscopicEye.Left);
					Matrix4x4 stereoProjectionMatrix = _camera.GetStereoProjectionMatrix((i != 0) ? Camera.StereoscopicEye.Right : Camera.StereoscopicEye.Left);
					stereoProjectionMatrix = GL.GetGPUProjectionMatrix(stereoProjectionMatrix, renderIntoTexture: true);
					ref Matrix4x4 reference = ref currentStereoViewProjMat[i];
					reference = stereoProjectionMatrix * stereoViewMatrix;
				}
			}
		}

		private new void Start()
		{
			CheckResources();
			if (_camera == null)
			{
				_camera = GetComponent<Camera>();
			}
			wasActive = base.gameObject.activeInHierarchy;
			currentStereoViewProjMat = new Matrix4x4[2];
			prevStereoViewProjMat = new Matrix4x4[2];
			CalculateViewProjection();
			Remember();
			wasActive = false;
		}

		private void OnEnable()
		{
			if (_camera == null)
			{
				_camera = GetComponent<Camera>();
			}
			_camera.depthTextureMode |= DepthTextureMode.Depth;
		}

		private void OnDisable()
		{
			if (null != motionBlurMaterial)
			{
				UnityEngine.Object.DestroyImmediate(motionBlurMaterial);
				motionBlurMaterial = null;
			}
			if (null != dx11MotionBlurMaterial)
			{
				UnityEngine.Object.DestroyImmediate(dx11MotionBlurMaterial);
				dx11MotionBlurMaterial = null;
			}
			if (null != tmpCam)
			{
				UnityEngine.Object.DestroyImmediate(tmpCam);
				tmpCam = null;
			}
		}

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true, needHdr: true);
			motionBlurMaterial = CheckShaderAndCreateMaterial(shader, motionBlurMaterial);
			if (supportDX11 && filterType == MotionBlurFilter.ReconstructionDX11)
			{
				dx11MotionBlurMaterial = CheckShaderAndCreateMaterial(dx11MotionBlurShader, dx11MotionBlurMaterial);
			}
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (filterType == MotionBlurFilter.CameraMotion)
			{
				StartFrame();
			}
			RenderTextureFormat format = ((!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGHalf)) ? RenderTextureFormat.ARGBHalf : RenderTextureFormat.RGHalf);
			RenderTexture temporary = RenderTexture.GetTemporary(divRoundUp(source.width, velocityDownsample), divRoundUp(source.height, velocityDownsample), 0, format);
			int num = 1;
			int num2 = 1;
			maxVelocity = Mathf.Max(2f, maxVelocity);
			float num3 = maxVelocity;
			bool flag = filterType == MotionBlurFilter.ReconstructionDX11 && dx11MotionBlurMaterial == null;
			if (filterType == MotionBlurFilter.Reconstruction || flag || filterType == MotionBlurFilter.ReconstructionDisc)
			{
				maxVelocity = Mathf.Min(maxVelocity, MAX_RADIUS);
				num = divRoundUp(temporary.width, (int)maxVelocity);
				num2 = divRoundUp(temporary.height, (int)maxVelocity);
				num3 = temporary.width / num;
			}
			else
			{
				num = divRoundUp(temporary.width, (int)maxVelocity);
				num2 = divRoundUp(temporary.height, (int)maxVelocity);
				num3 = temporary.width / num;
			}
			RenderTexture temporary2 = RenderTexture.GetTemporary(num, num2, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(num, num2, 0, format);
			temporary.filterMode = FilterMode.Point;
			temporary2.filterMode = FilterMode.Point;
			temporary3.filterMode = FilterMode.Point;
			if ((bool)noiseTexture)
			{
				noiseTexture.filterMode = FilterMode.Point;
			}
			source.wrapMode = TextureWrapMode.Clamp;
			temporary.wrapMode = TextureWrapMode.Clamp;
			temporary3.wrapMode = TextureWrapMode.Clamp;
			temporary2.wrapMode = TextureWrapMode.Clamp;
			CalculateViewProjection();
			if (base.gameObject.activeInHierarchy && !wasActive)
			{
				Remember();
			}
			wasActive = base.gameObject.activeInHierarchy;
			Matrix4x4 matrix4x = Matrix4x4.Inverse(currentViewProjMat);
			motionBlurMaterial.SetMatrix("_InvViewProj", matrix4x);
			motionBlurMaterial.SetMatrix("_PrevViewProj", prevViewProjMat);
			motionBlurMaterial.SetMatrix("_ToPrevViewProjCombined", prevViewProjMat * matrix4x);
			if (_camera.stereoEnabled)
			{
				Matrix4x4[] array = new Matrix4x4[2]
				{
					Matrix4x4.Inverse(currentStereoViewProjMat[0]),
					Matrix4x4.Inverse(currentStereoViewProjMat[1])
				};
				Matrix4x4 matrix = prevStereoViewProjMat[0] * array[0];
				motionBlurMaterial.SetMatrix("_StereoToPrevViewProjCombined0", matrix);
				motionBlurMaterial.SetMatrix("_StereoToPrevViewProjCombined1", prevStereoViewProjMat[1] * array[1]);
			}
			motionBlurMaterial.SetFloat("_MaxVelocity", num3);
			motionBlurMaterial.SetFloat("_MaxRadiusOrKInPaper", num3);
			motionBlurMaterial.SetFloat("_MinVelocity", minVelocity);
			motionBlurMaterial.SetFloat("_VelocityScale", velocityScale);
			motionBlurMaterial.SetFloat("_Jitter", jitter);
			motionBlurMaterial.SetTexture("_NoiseTex", noiseTexture);
			motionBlurMaterial.SetTexture("_VelTex", temporary);
			motionBlurMaterial.SetTexture("_NeighbourMaxTex", temporary3);
			motionBlurMaterial.SetTexture("_TileTexDebug", temporary2);
			if (preview)
			{
				Matrix4x4 worldToCameraMatrix = _camera.worldToCameraMatrix;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.SetTRS(previewScale * 0.3333f, Quaternion.identity, Vector3.one);
				Matrix4x4 gPUProjectionMatrix = GL.GetGPUProjectionMatrix(_camera.projectionMatrix, renderIntoTexture: true);
				prevViewProjMat = gPUProjectionMatrix * identity * worldToCameraMatrix;
				motionBlurMaterial.SetMatrix("_PrevViewProj", prevViewProjMat);
				motionBlurMaterial.SetMatrix("_ToPrevViewProjCombined", prevViewProjMat * matrix4x);
			}
			if (filterType == MotionBlurFilter.CameraMotion)
			{
				Vector4 zero = Vector4.zero;
				float num4 = Vector3.Dot(base.transform.up, Vector3.up);
				Vector3 rhs = prevFramePos - base.transform.position;
				float magnitude = rhs.magnitude;
				float num5 = 1f;
				num5 = Vector3.Angle(base.transform.up, prevFrameUp) / _camera.fieldOfView * ((float)source.width * 0.75f);
				zero.x = rotationScale * num5;
				num5 = Vector3.Angle(base.transform.forward, prevFrameForward) / _camera.fieldOfView * ((float)source.width * 0.75f);
				zero.y = rotationScale * num4 * num5;
				num5 = Vector3.Angle(base.transform.forward, prevFrameForward) / _camera.fieldOfView * ((float)source.width * 0.75f);
				zero.z = rotationScale * (1f - num4) * num5;
				if (magnitude > Mathf.Epsilon && movementScale > Mathf.Epsilon)
				{
					zero.w = movementScale * Vector3.Dot(base.transform.forward, rhs) * ((float)source.width * 0.5f);
					zero.x += movementScale * Vector3.Dot(base.transform.up, rhs) * ((float)source.width * 0.5f);
					zero.y += movementScale * Vector3.Dot(base.transform.right, rhs) * ((float)source.width * 0.5f);
				}
				if (preview)
				{
					motionBlurMaterial.SetVector("_BlurDirectionPacked", new Vector4(previewScale.y, previewScale.x, 0f, previewScale.z) * 0.5f * _camera.fieldOfView);
				}
				else
				{
					motionBlurMaterial.SetVector("_BlurDirectionPacked", zero);
				}
			}
			else
			{
				Graphics.Blit(source, temporary, motionBlurMaterial, 0);
				Camera camera = null;
				if (excludeLayers.value != 0)
				{
					camera = GetTmpCam();
				}
				if ((bool)camera && excludeLayers.value != 0 && (bool)replacementClear && replacementClear.isSupported)
				{
					camera.targetTexture = temporary;
					camera.cullingMask = excludeLayers;
					camera.RenderWithShader(replacementClear, string.Empty);
				}
			}
			if (!preview && Time.frameCount != prevFrameCount)
			{
				prevFrameCount = Time.frameCount;
				Remember();
			}
			source.filterMode = FilterMode.Bilinear;
			if (showVelocity)
			{
				motionBlurMaterial.SetFloat("_DisplayVelocityScale", showVelocityScale);
				Graphics.Blit(temporary, destination, motionBlurMaterial, 1);
			}
			else if (filterType == MotionBlurFilter.ReconstructionDX11 && !flag)
			{
				dx11MotionBlurMaterial.SetFloat("_MinVelocity", minVelocity);
				dx11MotionBlurMaterial.SetFloat("_VelocityScale", velocityScale);
				dx11MotionBlurMaterial.SetFloat("_Jitter", jitter);
				dx11MotionBlurMaterial.SetTexture("_NoiseTex", noiseTexture);
				dx11MotionBlurMaterial.SetTexture("_VelTex", temporary);
				dx11MotionBlurMaterial.SetTexture("_NeighbourMaxTex", temporary3);
				dx11MotionBlurMaterial.SetFloat("_SoftZDistance", Mathf.Max(0.00025f, softZDistance));
				dx11MotionBlurMaterial.SetFloat("_MaxRadiusOrKInPaper", num3);
				Graphics.Blit(temporary, temporary2, dx11MotionBlurMaterial, 0);
				Graphics.Blit(temporary2, temporary3, dx11MotionBlurMaterial, 1);
				Graphics.Blit(source, destination, dx11MotionBlurMaterial, 2);
			}
			else if (filterType == MotionBlurFilter.Reconstruction || flag)
			{
				motionBlurMaterial.SetFloat("_SoftZDistance", Mathf.Max(0.00025f, softZDistance));
				Graphics.Blit(temporary, temporary2, motionBlurMaterial, 2);
				Graphics.Blit(temporary2, temporary3, motionBlurMaterial, 3);
				Graphics.Blit(source, destination, motionBlurMaterial, 4);
			}
			else if (filterType == MotionBlurFilter.CameraMotion)
			{
				Graphics.Blit(source, destination, motionBlurMaterial, 6);
			}
			else if (filterType == MotionBlurFilter.ReconstructionDisc)
			{
				motionBlurMaterial.SetFloat("_SoftZDistance", Mathf.Max(0.00025f, softZDistance));
				Graphics.Blit(temporary, temporary2, motionBlurMaterial, 2);
				Graphics.Blit(temporary2, temporary3, motionBlurMaterial, 3);
				Graphics.Blit(source, destination, motionBlurMaterial, 7);
			}
			else
			{
				Graphics.Blit(source, destination, motionBlurMaterial, 5);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
		}

		private void Remember()
		{
			prevViewProjMat = currentViewProjMat;
			prevFrameForward = base.transform.forward;
			prevFrameUp = base.transform.up;
			prevFramePos = base.transform.position;
			ref Matrix4x4 reference = ref prevStereoViewProjMat[0];
			reference = currentStereoViewProjMat[0];
			ref Matrix4x4 reference2 = ref prevStereoViewProjMat[1];
			reference2 = currentStereoViewProjMat[1];
		}

		private Camera GetTmpCam()
		{
			if (tmpCam == null)
			{
				string text = "_" + _camera.name + "_MotionBlurTmpCam";
				GameObject gameObject = GameObject.Find(text);
				if (null == gameObject)
				{
					tmpCam = new GameObject(text, typeof(Camera));
				}
				else
				{
					tmpCam = gameObject;
				}
			}
			tmpCam.hideFlags = HideFlags.DontSave;
			tmpCam.transform.position = _camera.transform.position;
			tmpCam.transform.rotation = _camera.transform.rotation;
			tmpCam.transform.localScale = _camera.transform.localScale;
			tmpCam.GetComponent<Camera>().CopyFrom(_camera);
			tmpCam.GetComponent<Camera>().enabled = false;
			tmpCam.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			tmpCam.GetComponent<Camera>().clearFlags = CameraClearFlags.Nothing;
			return tmpCam.GetComponent<Camera>();
		}

		private void StartFrame()
		{
			prevFramePos = Vector3.Slerp(prevFramePos, base.transform.position, 0.75f);
		}

		private static int divRoundUp(int x, int d)
		{
			return (x + d - 1) / d;
		}
	}
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Curves, Saturation)")]
	[ExecuteInEditMode]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		public enum ColorCorrectionMode
		{
			Simple,
			Advanced
		}

		public AnimationCurve redChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public AnimationCurve greenChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public AnimationCurve blueChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public bool useDepthCorrection;

		public AnimationCurve zCurve = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public AnimationCurve depthRedChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public AnimationCurve depthGreenChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public AnimationCurve depthBlueChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		private Material ccMaterial;

		private Material ccDepthMaterial;

		private Material selectiveCcMaterial;

		private Texture2D rgbChannelTex;

		private Texture2D rgbDepthChannelTex;

		private Texture2D zCurveTex;

		public float saturation = 1f;

		public bool selectiveCc;

		public Color selectiveFromColor = Color.white;

		public Color selectiveToColor = Color.white;

		public ColorCorrectionMode mode;

		public bool updateTextures = true;

		public Shader colorCorrectionCurvesShader;

		public Shader simpleColorCorrectionCurvesShader;

		public Shader colorCorrectionSelectiveShader;

		private bool updateTexturesOnStartup = true;

		private new void Start()
		{
			base.Start();
			updateTexturesOnStartup = true;
		}

		private void Awake()
		{
		}

		public override bool CheckResources()
		{
			CheckSupport(mode == ColorCorrectionMode.Advanced);
			ccMaterial = CheckShaderAndCreateMaterial(simpleColorCorrectionCurvesShader, ccMaterial);
			ccDepthMaterial = CheckShaderAndCreateMaterial(colorCorrectionCurvesShader, ccDepthMaterial);
			selectiveCcMaterial = CheckShaderAndCreateMaterial(colorCorrectionSelectiveShader, selectiveCcMaterial);
			if (!rgbChannelTex)
			{
				rgbChannelTex = new Texture2D(256, 4, TextureFormat.ARGB32, mipmap: false, linear: true);
			}
			if (!rgbDepthChannelTex)
			{
				rgbDepthChannelTex = new Texture2D(256, 4, TextureFormat.ARGB32, mipmap: false, linear: true);
			}
			if (!zCurveTex)
			{
				zCurveTex = new Texture2D(256, 1, TextureFormat.ARGB32, mipmap: false, linear: true);
			}
			rgbChannelTex.hideFlags = HideFlags.DontSave;
			rgbDepthChannelTex.hideFlags = HideFlags.DontSave;
			zCurveTex.hideFlags = HideFlags.DontSave;
			rgbChannelTex.wrapMode = TextureWrapMode.Clamp;
			rgbDepthChannelTex.wrapMode = TextureWrapMode.Clamp;
			zCurveTex.wrapMode = TextureWrapMode.Clamp;
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		public void UpdateParameters()
		{
			CheckResources();
			if (redChannel != null && greenChannel != null && blueChannel != null)
			{
				for (float num = 0f; num <= 1f; num += 0.003921569f)
				{
					float num2 = Mathf.Clamp(redChannel.Evaluate(num), 0f, 1f);
					float num3 = Mathf.Clamp(greenChannel.Evaluate(num), 0f, 1f);
					float num4 = Mathf.Clamp(blueChannel.Evaluate(num), 0f, 1f);
					rgbChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 0, new Color(num2, num2, num2));
					rgbChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 1, new Color(num3, num3, num3));
					rgbChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 2, new Color(num4, num4, num4));
					float num5 = Mathf.Clamp(zCurve.Evaluate(num), 0f, 1f);
					zCurveTex.SetPixel((int)Mathf.Floor(num * 255f), 0, new Color(num5, num5, num5));
					num2 = Mathf.Clamp(depthRedChannel.Evaluate(num), 0f, 1f);
					num3 = Mathf.Clamp(depthGreenChannel.Evaluate(num), 0f, 1f);
					num4 = Mathf.Clamp(depthBlueChannel.Evaluate(num), 0f, 1f);
					rgbDepthChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 0, new Color(num2, num2, num2));
					rgbDepthChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 1, new Color(num3, num3, num3));
					rgbDepthChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 2, new Color(num4, num4, num4));
				}
				rgbChannelTex.Apply();
				rgbDepthChannelTex.Apply();
				zCurveTex.Apply();
			}
		}

		private void UpdateTextures()
		{
			UpdateParameters();
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (updateTexturesOnStartup)
			{
				UpdateParameters();
				updateTexturesOnStartup = false;
			}
			if (useDepthCorrection)
			{
				GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			RenderTexture renderTexture = destination;
			if (selectiveCc)
			{
				renderTexture = RenderTexture.GetTemporary(source.width, source.height);
			}
			if (useDepthCorrection)
			{
				ccDepthMaterial.SetTexture("_RgbTex", rgbChannelTex);
				ccDepthMaterial.SetTexture("_ZCurve", zCurveTex);
				ccDepthMaterial.SetTexture("_RgbDepthTex", rgbDepthChannelTex);
				ccDepthMaterial.SetFloat("_Saturation", saturation);
				Graphics.Blit(source, renderTexture, ccDepthMaterial);
			}
			else
			{
				ccMaterial.SetTexture("_RgbTex", rgbChannelTex);
				ccMaterial.SetFloat("_Saturation", saturation);
				Graphics.Blit(source, renderTexture, ccMaterial);
			}
			if (selectiveCc)
			{
				selectiveCcMaterial.SetColor("selColor", selectiveFromColor);
				selectiveCcMaterial.SetColor("targetColor", selectiveToColor);
				Graphics.Blit(renderTexture, destination, selectiveCcMaterial);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}
	}
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (3D Lookup Texture)")]
	[ExecuteInEditMode]
	public class ColorCorrectionLookup : PostEffectsBase
	{
		public Shader shader;

		private Material material;

		public Texture3D converted3DLut;

		public string basedOnTempTex = string.Empty;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			material = CheckShaderAndCreateMaterial(shader, material);
			if (!isSupported || !SystemInfo.supports3DTextures)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnDisable()
		{
			if ((bool)material)
			{
				UnityEngine.Object.DestroyImmediate(material);
				material = null;
			}
		}

		private void OnDestroy()
		{
			if ((bool)converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(converted3DLut);
			}
			converted3DLut = null;
		}

		public void SetIdentityLut()
		{
			int num = 16;
			Color[] array = new Color[num * num * num];
			float num2 = 1f / (1f * (float)num - 1f);
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 0; k < num; k++)
					{
						ref Color reference = ref array[i + j * num + k * num * num];
						reference = new Color((float)i * 1f * num2, (float)j * 1f * num2, (float)k * 1f * num2, 1f);
					}
				}
			}
			if ((bool)converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(converted3DLut);
			}
			converted3DLut = new Texture3D(num, num, num, TextureFormat.ARGB32, mipmap: false);
			converted3DLut.SetPixels(array);
			converted3DLut.Apply();
			basedOnTempTex = string.Empty;
		}

		public bool ValidDimensions(Texture2D tex2d)
		{
			if (!tex2d)
			{
				return false;
			}
			int height = tex2d.height;
			if (height != Mathf.FloorToInt(Mathf.Sqrt(tex2d.width)))
			{
				return false;
			}
			return true;
		}

		public void Convert(Texture2D temp2DTex, string path)
		{
			if ((bool)temp2DTex)
			{
				int num = temp2DTex.width * temp2DTex.height;
				num = temp2DTex.height;
				if (!ValidDimensions(temp2DTex))
				{
					Debug.LogWarning("The given 2D texture " + temp2DTex.name + " cannot be used as a 3D LUT.");
					basedOnTempTex = string.Empty;
					return;
				}
				Color[] pixels = temp2DTex.GetPixels();
				Color[] array = new Color[pixels.Length];
				for (int i = 0; i < num; i++)
				{
					for (int j = 0; j < num; j++)
					{
						for (int k = 0; k < num; k++)
						{
							int num2 = num - j - 1;
							ref Color reference = ref array[i + j * num + k * num * num];
							reference = pixels[k * num + i + num2 * num * num];
						}
					}
				}
				if ((bool)converted3DLut)
				{
					UnityEngine.Object.DestroyImmediate(converted3DLut);
				}
				converted3DLut = new Texture3D(num, num, num, TextureFormat.ARGB32, mipmap: false);
				converted3DLut.SetPixels(array);
				converted3DLut.Apply();
				basedOnTempTex = path;
			}
			else
			{
				Debug.LogError("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.");
			}
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources() || !SystemInfo.supports3DTextures)
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (converted3DLut == null)
			{
				SetIdentityLut();
			}
			int width = converted3DLut.width;
			converted3DLut.wrapMode = TextureWrapMode.Clamp;
			material.SetFloat("_Scale", (float)(width - 1) / (1f * (float)width));
			material.SetFloat("_Offset", 1f / (2f * (float)width));
			material.SetTexture("_ClutTex", converted3DLut);
			Graphics.Blit(source, destination, material, (QualitySettings.activeColorSpace == ColorSpace.Linear) ? 1 : 0);
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Ramp)")]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		public Texture textureRamp;

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			base.material.SetTexture("_RampTex", textureRamp);
			Graphics.Blit(source, destination, base.material);
		}
	}
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Color Adjustments/Contrast Enhance (Unsharp Mask)")]
	[ExecuteInEditMode]
	public class ContrastEnhance : PostEffectsBase
	{
		[Range(0f, 1f)]
		public float intensity = 0.5f;

		[Range(0f, 0.999f)]
		public float threshold;

		private Material separableBlurMaterial;

		private Material contrastCompositeMaterial;

		[Range(0f, 1f)]
		public float blurSpread = 1f;

		public Shader separableBlurShader;

		public Shader contrastCompositeShader;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			contrastCompositeMaterial = CheckShaderAndCreateMaterial(contrastCompositeShader, contrastCompositeMaterial);
			separableBlurMaterial = CheckShaderAndCreateMaterial(separableBlurShader, separableBlurMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			int width = source.width;
			int height = source.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 2, height / 2, 0);
			Graphics.Blit(source, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 4, height / 4, 0);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			separableBlurMaterial.SetVector("offsets", new Vector4(0f, blurSpread * 1f / (float)temporary2.height, 0f, 0f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 4, height / 4, 0);
			Graphics.Blit(temporary2, temporary3, separableBlurMaterial);
			RenderTexture.ReleaseTemporary(temporary2);
			separableBlurMaterial.SetVector("offsets", new Vector4(blurSpread * 1f / (float)temporary2.width, 0f, 0f, 0f));
			temporary2 = RenderTexture.GetTemporary(width / 4, height / 4, 0);
			Graphics.Blit(temporary3, temporary2, separableBlurMaterial);
			RenderTexture.ReleaseTemporary(temporary3);
			contrastCompositeMaterial.SetTexture("_MainTexBlurred", temporary2);
			contrastCompositeMaterial.SetFloat("intensity", intensity);
			contrastCompositeMaterial.SetFloat("threshold", threshold);
			Graphics.Blit(source, destination, contrastCompositeMaterial);
			RenderTexture.ReleaseTemporary(temporary2);
		}
	}
	[AddComponentMenu("Image Effects/Color Adjustments/Contrast Stretch")]
	[ExecuteInEditMode]
	public class ContrastStretch : MonoBehaviour
	{
		[Range(0.0001f, 1f)]
		public float adaptationSpeed = 0.02f;

		[Range(0f, 1f)]
		public float limitMinimum = 0.2f;

		[Range(0f, 1f)]
		public float limitMaximum = 0.6f;

		private RenderTexture[] adaptRenderTex = new RenderTexture[2];

		private int curAdaptIndex;

		public Shader shaderLum;

		private Material m_materialLum;

		public Shader shaderReduce;

		private Material m_materialReduce;

		public Shader shaderAdapt;

		private Material m_materialAdapt;

		public Shader shaderApply;

		private Material m_materialApply;

		protected Material materialLum
		{
			get
			{
				if (m_materialLum == null)
				{
					m_materialLum = new Material(shaderLum);
					m_materialLum.hideFlags = HideFlags.HideAndDontSave;
				}
				return m_materialLum;
			}
		}

		protected Material materialReduce
		{
			get
			{
				if (m_materialReduce == null)
				{
					m_materialReduce = new Material(shaderReduce);
					m_materialReduce.hideFlags = HideFlags.HideAndDontSave;
				}
				return m_materialReduce;
			}
		}

		protected Material materialAdapt
		{
			get
			{
				if (m_materialAdapt == null)
				{
					m_materialAdapt = new Material(shaderAdapt);
					m_materialAdapt.hideFlags = HideFlags.HideAndDontSave;
				}
				return m_materialAdapt;
			}
		}

		protected Material materialApply
		{
			get
			{
				if (m_materialApply == null)
				{
					m_materialApply = new Material(shaderApply);
					m_materialApply.hideFlags = HideFlags.HideAndDontSave;
				}
				return m_materialApply;
			}
		}

		private void Start()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
			}
			else if (!shaderAdapt.isSupported || !shaderApply.isSupported || !shaderLum.isSupported || !shaderReduce.isSupported)
			{
				base.enabled = false;
			}
		}

		private void OnEnable()
		{
			for (int i = 0; i < 2; i++)
			{
				if (!adaptRenderTex[i])
				{
					adaptRenderTex[i] = new RenderTexture(1, 1, 0);
					adaptRenderTex[i].hideFlags = HideFlags.HideAndDontSave;
				}
			}
		}

		private void OnDisable()
		{
			for (int i = 0; i < 2; i++)
			{
				UnityEngine.Object.DestroyImmediate(adaptRenderTex[i]);
				adaptRenderTex[i] = null;
			}
			if ((bool)m_materialLum)
			{
				UnityEngine.Object.DestroyImmediate(m_materialLum);
			}
			if ((bool)m_materialReduce)
			{
				UnityEngine.Object.DestroyImmediate(m_materialReduce);
			}
			if ((bool)m_materialAdapt)
			{
				UnityEngine.Object.DestroyImmediate(m_materialAdapt);
			}
			if ((bool)m_materialApply)
			{
				UnityEngine.Object.DestroyImmediate(m_materialApply);
			}
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(source.width / 1, source.height / 1);
			Graphics.Blit(source, renderTexture, materialLum);
			while (renderTexture.width > 1 || renderTexture.height > 1)
			{
				int num = renderTexture.width / 2;
				if (num < 1)
				{
					num = 1;
				}
				int num2 = renderTexture.height / 2;
				if (num2 < 1)
				{
					num2 = 1;
				}
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2);
				Graphics.Blit(renderTexture, temporary, materialReduce);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			CalculateAdaptation(renderTexture);
			materialApply.SetTexture("_AdaptTex", adaptRenderTex[curAdaptIndex]);
			Graphics.Blit(source, destination, materialApply);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		private void CalculateAdaptation(Texture curTexture)
		{
			int num = curAdaptIndex;
			curAdaptIndex = (curAdaptIndex + 1) % 2;
			float value = 1f - Mathf.Pow(1f - adaptationSpeed, 30f * Time.deltaTime);
			value = Mathf.Clamp(value, 0.01f, 1f);
			materialAdapt.SetTexture("_CurTex", curTexture);
			materialAdapt.SetVector("_AdaptParams", new Vector4(value, limitMinimum, limitMaximum, 0f));
			Graphics.SetRenderTarget(adaptRenderTex[curAdaptIndex]);
			GL.Clear(clearDepth: false, clearColor: true, Color.black);
			Graphics.Blit(adaptRenderTex[num], adaptRenderTex[curAdaptIndex], materialAdapt);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Edge Detection/Crease Shading")]
	public class CreaseShading : PostEffectsBase
	{
		public float intensity = 0.5f;

		public int softness = 1;

		public float spread = 1f;

		public Shader blurShader;

		private Material blurMaterial;

		public Shader depthFetchShader;

		private Material depthFetchMaterial;

		public Shader creaseApplyShader;

		private Material creaseApplyMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			blurMaterial = CheckShaderAndCreateMaterial(blurShader, blurMaterial);
			depthFetchMaterial = CheckShaderAndCreateMaterial(depthFetchShader, depthFetchMaterial);
			creaseApplyMaterial = CheckShaderAndCreateMaterial(creaseApplyShader, creaseApplyMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			int width = source.width;
			int height = source.height;
			float num = 1f * (float)width / (1f * (float)height);
			float num2 = 0.001953125f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 2, height / 2, 0);
			Graphics.Blit(source, temporary, depthFetchMaterial);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < softness; i++)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 2, height / 2, 0);
				blurMaterial.SetVector("offsets", new Vector4(0f, spread * num2, 0f, 0f));
				Graphics.Blit(renderTexture, temporary2, blurMaterial);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 2, height / 2, 0);
				blurMaterial.SetVector("offsets", new Vector4(spread * num2 / num, 0f, 0f, 0f));
				Graphics.Blit(renderTexture, temporary2, blurMaterial);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			creaseApplyMaterial.SetTexture("_HrDepthTex", temporary);
			creaseApplyMaterial.SetTexture("_LrDepthTex", renderTexture);
			creaseApplyMaterial.SetFloat("intensity", intensity);
			Graphics.Blit(source, destination, creaseApplyMaterial);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
	}
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Depth of Field (Lens Blur, Scatter, DX11)")]
	[ExecuteInEditMode]
	public class DepthOfField : PostEffectsBase
	{
		public enum BlurType
		{
			DiscBlur,
			DX11
		}

		public enum BlurSampleCount
		{
			Low,
			Medium,
			High
		}

		public bool visualizeFocus;

		public float focalLength = 10f;

		public float focalSize = 0.05f;

		public float aperture = 0.5f;

		public Transform focalTransform;

		public float maxBlurSize = 2f;

		public bool highResolution;

		public BlurType blurType;

		public BlurSampleCount blurSampleCount = BlurSampleCount.High;

		public bool nearBlur;

		public float foregroundOverlap = 1f;

		public Shader dofHdrShader;

		private Material dofHdrMaterial;

		public Shader dx11BokehShader;

		private Material dx11bokehMaterial;

		public float dx11BokehThreshold = 0.5f;

		public float dx11SpawnHeuristic = 0.0875f;

		public Texture2D dx11BokehTexture;

		public float dx11BokehScale = 1.2f;

		public float dx11BokehIntensity = 2.5f;

		private float focalDistance01 = 10f;

		private ComputeBuffer cbDrawArgs;

		private ComputeBuffer cbPoints;

		private float internalBlurWidth = 1f;

		private Camera cachedCamera;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			dofHdrMaterial = CheckShaderAndCreateMaterial(dofHdrShader, dofHdrMaterial);
			if (supportDX11 && blurType == BlurType.DX11)
			{
				dx11bokehMaterial = CheckShaderAndCreateMaterial(dx11BokehShader, dx11bokehMaterial);
				CreateComputeResources();
			}
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnEnable()
		{
			cachedCamera = GetComponent<Camera>();
			cachedCamera.depthTextureMode |= DepthTextureMode.Depth;
		}

		private void OnDisable()
		{
			ReleaseComputeResources();
			if ((bool)dofHdrMaterial)
			{
				UnityEngine.Object.DestroyImmediate(dofHdrMaterial);
			}
			dofHdrMaterial = null;
			if ((bool)dx11bokehMaterial)
			{
				UnityEngine.Object.DestroyImmediate(dx11bokehMaterial);
			}
			dx11bokehMaterial = null;
		}

		private void ReleaseComputeResources()
		{
			if (cbDrawArgs != null)
			{
				cbDrawArgs.Release();
			}
			cbDrawArgs = null;
			if (cbPoints != null)
			{
				cbPoints.Release();
			}
			cbPoints = null;
		}

		private void CreateComputeResources()
		{
			if (cbDrawArgs == null)
			{
				cbDrawArgs = new ComputeBuffer(1, 16, ComputeBufferType.DrawIndirect);
				int[] data = new int[4] { 0, 1, 0, 0 };
				cbDrawArgs.SetData(data);
			}
			if (cbPoints == null)
			{
				cbPoints = new ComputeBuffer(90000, 28, ComputeBufferType.Append);
			}
		}

		private float FocalDistance01(float worldDist)
		{
			return cachedCamera.WorldToViewportPoint((worldDist - cachedCamera.nearClipPlane) * cachedCamera.transform.forward + cachedCamera.transform.position).z / (cachedCamera.farClipPlane - cachedCamera.nearClipPlane);
		}

		private void WriteCoc(RenderTexture fromTo, bool fgDilate)
		{
			dofHdrMaterial.SetTexture("_FgOverlap", null);
			if (nearBlur && fgDilate)
			{
				int width = fromTo.width / 2;
				int height = fromTo.height / 2;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, fromTo.format);
				Graphics.Blit(fromTo, temporary, dofHdrMaterial, 4);
				float num = internalBlurWidth * foregroundOverlap;
				dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, num, 0f, num));
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0, fromTo.format);
				Graphics.Blit(temporary, temporary2, dofHdrMaterial, 2);
				RenderTexture.ReleaseTemporary(temporary);
				dofHdrMaterial.SetVector("_Offsets", new Vector4(num, 0f, 0f, num));
				temporary = RenderTexture.GetTemporary(width, height, 0, fromTo.format);
				Graphics.Blit(temporary2, temporary, dofHdrMaterial, 2);
				RenderTexture.ReleaseTemporary(temporary2);
				dofHdrMaterial.SetTexture("_FgOverlap", temporary);
				fromTo.MarkRestoreExpected();
				Graphics.Blit(fromTo, fromTo, dofHdrMaterial, 13);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				fromTo.MarkRestoreExpected();
				Graphics.Blit(fromTo, fromTo, dofHdrMaterial, 0);
			}
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (aperture < 0f)
			{
				aperture = 0f;
			}
			if (maxBlurSize < 0.1f)
			{
				maxBlurSize = 0.1f;
			}
			focalSize = Mathf.Clamp(focalSize, 0f, 2f);
			internalBlurWidth = Mathf.Max(maxBlurSize, 0f);
			focalDistance01 = ((!focalTransform) ? FocalDistance01(focalLength) : (cachedCamera.WorldToViewportPoint(focalTransform.position).z / cachedCamera.farClipPlane));
			dofHdrMaterial.SetVector("_CurveParams", new Vector4(1f, focalSize, 1f / (1f - aperture) - 1f, focalDistance01));
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			RenderTexture renderTexture3 = null;
			RenderTexture renderTexture4 = null;
			float num = internalBlurWidth * foregroundOverlap;
			if (visualizeFocus)
			{
				WriteCoc(source, fgDilate: true);
				Graphics.Blit(source, destination, dofHdrMaterial, 16);
			}
			else if (blurType == BlurType.DX11 && (bool)dx11bokehMaterial)
			{
				if (highResolution)
				{
					internalBlurWidth = ((!(internalBlurWidth < 0.1f)) ? internalBlurWidth : 0.1f);
					num = internalBlurWidth * foregroundOverlap;
					renderTexture = RenderTexture.GetTemporary(source.width, source.height, 0, source.format);
					RenderTexture temporary = RenderTexture.GetTemporary(source.width, source.height, 0, source.format);
					WriteCoc(source, fgDilate: false);
					renderTexture3 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
					renderTexture4 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
					Graphics.Blit(source, renderTexture3, dofHdrMaterial, 15);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, 1.5f, 0f, 1.5f));
					Graphics.Blit(renderTexture3, renderTexture4, dofHdrMaterial, 19);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(1.5f, 0f, 0f, 1.5f));
					Graphics.Blit(renderTexture4, renderTexture3, dofHdrMaterial, 19);
					if (nearBlur)
					{
						Graphics.Blit(source, renderTexture4, dofHdrMaterial, 4);
					}
					dx11bokehMaterial.SetTexture("_BlurredColor", renderTexture3);
					dx11bokehMaterial.SetFloat("_SpawnHeuristic", dx11SpawnHeuristic);
					dx11bokehMaterial.SetVector("_BokehParams", new Vector4(dx11BokehScale, dx11BokehIntensity, Mathf.Clamp(dx11BokehThreshold, 0.005f, 4f), internalBlurWidth));
					dx11bokehMaterial.SetTexture("_FgCocMask", (!nearBlur) ? null : renderTexture4);
					Graphics.SetRandomWriteTarget(1, cbPoints);
					Graphics.Blit(source, renderTexture, dx11bokehMaterial, 0);
					Graphics.ClearRandomWriteTargets();
					if (nearBlur)
					{
						dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, num, 0f, num));
						Graphics.Blit(renderTexture4, renderTexture3, dofHdrMaterial, 2);
						dofHdrMaterial.SetVector("_Offsets", new Vector4(num, 0f, 0f, num));
						Graphics.Blit(renderTexture3, renderTexture4, dofHdrMaterial, 2);
						Graphics.Blit(renderTexture4, renderTexture, dofHdrMaterial, 3);
					}
					Graphics.Blit(renderTexture, temporary, dofHdrMaterial, 20);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(internalBlurWidth, 0f, 0f, internalBlurWidth));
					Graphics.Blit(renderTexture, source, dofHdrMaterial, 5);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, internalBlurWidth, 0f, internalBlurWidth));
					Graphics.Blit(source, temporary, dofHdrMaterial, 21);
					Graphics.SetRenderTarget(temporary);
					ComputeBuffer.CopyCount(cbPoints, cbDrawArgs, 0);
					dx11bokehMaterial.SetBuffer("pointBuffer", cbPoints);
					dx11bokehMaterial.SetTexture("_MainTex", dx11BokehTexture);
					dx11bokehMaterial.SetVector("_Screen", new Vector3(1f / (1f * (float)source.width), 1f / (1f * (float)source.height), internalBlurWidth));
					dx11bokehMaterial.SetPass(2);
					Graphics.DrawProceduralIndirect(MeshTopology.Points, cbDrawArgs, 0);
					Graphics.Blit(temporary, destination);
					RenderTexture.ReleaseTemporary(temporary);
					RenderTexture.ReleaseTemporary(renderTexture3);
					RenderTexture.ReleaseTemporary(renderTexture4);
				}
				else
				{
					renderTexture = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
					renderTexture2 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
					num = internalBlurWidth * foregroundOverlap;
					WriteCoc(source, fgDilate: false);
					source.filterMode = FilterMode.Bilinear;
					Graphics.Blit(source, renderTexture, dofHdrMaterial, 6);
					renderTexture3 = RenderTexture.GetTemporary(renderTexture.width >> 1, renderTexture.height >> 1, 0, renderTexture.format);
					renderTexture4 = RenderTexture.GetTemporary(renderTexture.width >> 1, renderTexture.height >> 1, 0, renderTexture.format);
					Graphics.Blit(renderTexture, renderTexture3, dofHdrMaterial, 15);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, 1.5f, 0f, 1.5f));
					Graphics.Blit(renderTexture3, renderTexture4, dofHdrMaterial, 19);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(1.5f, 0f, 0f, 1.5f));
					Graphics.Blit(renderTexture4, renderTexture3, dofHdrMaterial, 19);
					RenderTexture renderTexture5 = null;
					if (nearBlur)
					{
						renderTexture5 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
						Graphics.Blit(source, renderTexture5, dofHdrMaterial, 4);
					}
					dx11bokehMaterial.SetTexture("_BlurredColor", renderTexture3);
					dx11bokehMaterial.SetFloat("_SpawnHeuristic", dx11SpawnHeuristic);
					dx11bokehMaterial.SetVector("_BokehParams", new Vector4(dx11BokehScale, dx11BokehIntensity, Mathf.Clamp(dx11BokehThreshold, 0.005f, 4f), internalBlurWidth));
					dx11bokehMaterial.SetTexture("_FgCocMask", renderTexture5);
					Graphics.SetRandomWriteTarget(1, cbPoints);
					Graphics.Blit(renderTexture, renderTexture2, dx11bokehMaterial, 0);
					Graphics.ClearRandomWriteTargets();
					RenderTexture.ReleaseTemporary(renderTexture3);
					RenderTexture.ReleaseTemporary(renderTexture4);
					if (nearBlur)
					{
						dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, num, 0f, num));
						Graphics.Blit(renderTexture5, renderTexture, dofHdrMaterial, 2);
						dofHdrMaterial.SetVector("_Offsets", new Vector4(num, 0f, 0f, num));
						Graphics.Blit(renderTexture, renderTexture5, dofHdrMaterial, 2);
						Graphics.Blit(renderTexture5, renderTexture2, dofHdrMaterial, 3);
					}
					dofHdrMaterial.SetVector("_Offsets", new Vector4(internalBlurWidth, 0f, 0f, internalBlurWidth));
					Graphics.Blit(renderTexture2, renderTexture, dofHdrMaterial, 5);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, internalBlurWidth, 0f, internalBlurWidth));
					Graphics.Blit(renderTexture, renderTexture2, dofHdrMaterial, 5);
					Graphics.SetRenderTarget(renderTexture2);
					ComputeBuffer.CopyCount(cbPoints, cbDrawArgs, 0);
					dx11bokehMaterial.SetBuffer("pointBuffer", cbPoints);
					dx11bokehMaterial.SetTexture("_MainTex", dx11BokehTexture);
					dx11bokehMaterial.SetVector("_Screen", new Vector3(1f / (1f * (float)renderTexture2.width), 1f / (1f * (float)renderTexture2.height), internalBlurWidth));
					dx11bokehMaterial.SetPass(1);
					Graphics.DrawProceduralIndirect(MeshTopology.Points, cbDrawArgs, 0);
					dofHdrMaterial.SetTexture("_LowRez", renderTexture2);
					dofHdrMaterial.SetTexture("_FgOverlap", renderTexture5);
					dofHdrMaterial.SetVector("_Offsets", 1f * (float)source.width / (1f * (float)renderTexture2.width) * internalBlurWidth * Vector4.one);
					Graphics.Blit(source, destination, dofHdrMaterial, 9);
					if ((bool)renderTexture5)
					{
						RenderTexture.ReleaseTemporary(renderTexture5);
					}
				}
			}
			else
			{
				source.filterMode = FilterMode.Bilinear;
				if (highResolution)
				{
					internalBlurWidth *= 2f;
				}
				WriteCoc(source, fgDilate: true);
				renderTexture = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
				renderTexture2 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
				int pass = ((blurSampleCount != BlurSampleCount.High && blurSampleCount != BlurSampleCount.Medium) ? 11 : 17);
				if (highResolution)
				{
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, internalBlurWidth, 0.025f, internalBlurWidth));
					Graphics.Blit(source, destination, dofHdrMaterial, pass);
				}
				else
				{
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, internalBlurWidth, 0.1f, internalBlurWidth));
					Graphics.Blit(source, renderTexture, dofHdrMaterial, 6);
					Graphics.Blit(renderTexture, renderTexture2, dofHdrMaterial, pass);
					dofHdrMaterial.SetTexture("_LowRez", renderTexture2);
					dofHdrMaterial.SetTexture("_FgOverlap", null);
					dofHdrMaterial.SetVector("_Offsets", Vector4.one * (1f * (float)source.width / (1f * (float)renderTexture2.width)) * internalBlurWidth);
					Graphics.Blit(source, destination, dofHdrMaterial, (blurSampleCount != BlurSampleCount.High) ? 12 : 18);
				}
			}
			if ((bool)renderTexture)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
			if ((bool)renderTexture2)
			{
				RenderTexture.ReleaseTemporary(renderTexture2);
			}
		}
	}
	[AddComponentMenu("Image Effects/Camera/Depth of Field (deprecated)")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class DepthOfFieldDeprecated : PostEffectsBase
	{
		public enum Dof34QualitySetting
		{
			OnlyBackground = 1,
			BackgroundAndForeground
		}

		public enum DofResolution
		{
			High = 2,
			Medium,
			Low
		}

		public enum DofBlurriness
		{
			Low = 1,
			High = 2,
			VeryHigh = 4
		}

		public enum BokehDestination
		{
			Background = 1,
			Foreground,
			BackgroundAndForeground
		}

		private static int SMOOTH_DOWNSAMPLE_PASS = 6;

		private static float BOKEH_EXTRA_BLUR = 2f;

		public Dof34QualitySetting quality = Dof34QualitySetting.OnlyBackground;

		public DofResolution resolution = DofResolution.Low;

		public bool simpleTweakMode = true;

		public float focalPoint = 1f;

		public float smoothness = 0.5f;

		public float focalZDistance;

		public float focalZStartCurve = 1f;

		public float focalZEndCurve = 1f;

		private float focalStartCurve = 2f;

		private float focalEndCurve = 2f;

		private float focalDistance01 = 0.1f;

		public Transform objectFocus;

		public float focalSize;

		public DofBlurriness bluriness = DofBlurriness.High;

		public float maxBlurSpread = 1.75f;

		public float foregroundBlurExtrude = 1.15f;

		public Shader dofBlurShader;

		private Material dofBlurMaterial;

		public Shader dofShader;

		private Material dofMaterial;

		public bool visualize;

		public BokehDestination bokehDestination = BokehDestination.Background;

		private float widthOverHeight = 1.25f;

		private float oneOverBaseSize = 0.001953125f;

		public bool bokeh;

		public bool bokehSupport = true;

		public Shader bokehShader;

		public Texture2D bokehTexture;

		public float bokehScale = 2.4f;

		public float bokehIntensity = 0.15f;

		public float bokehThresholdContrast = 0.1f;

		public float bokehThresholdLuminance = 0.55f;

		public int bokehDownsample = 1;

		private Material bokehMaterial;

		private Camera _camera;

		private RenderTexture foregroundTexture;

		private RenderTexture mediumRezWorkTexture;

		private RenderTexture finalDefocus;

		private RenderTexture lowRezWorkTexture;

		private RenderTexture bokehSource;

		private RenderTexture bokehSource2;

		private void CreateMaterials()
		{
			dofBlurMaterial = CheckShaderAndCreateMaterial(dofBlurShader, dofBlurMaterial);
			dofMaterial = CheckShaderAndCreateMaterial(dofShader, dofMaterial);
			bokehSupport = bokehShader.isSupported;
			if (bokeh && bokehSupport && (bool)bokehShader)
			{
				bokehMaterial = CheckShaderAndCreateMaterial(bokehShader, bokehMaterial);
			}
		}

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			dofBlurMaterial = CheckShaderAndCreateMaterial(dofBlurShader, dofBlurMaterial);
			dofMaterial = CheckShaderAndCreateMaterial(dofShader, dofMaterial);
			bokehSupport = bokehShader.isSupported;
			if (bokeh && bokehSupport && (bool)bokehShader)
			{
				bokehMaterial = CheckShaderAndCreateMaterial(bokehShader, bokehMaterial);
			}
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnDisable()
		{
			Quads.Cleanup();
		}

		private void OnEnable()
		{
			_camera = GetComponent<Camera>();
			_camera.depthTextureMode |= DepthTextureMode.Depth;
		}

		private float FocalDistance01(float worldDist)
		{
			return _camera.WorldToViewportPoint((worldDist - _camera.nearClipPlane) * _camera.transform.forward + _camera.transform.position).z / (_camera.farClipPlane - _camera.nearClipPlane);
		}

		private int GetDividerBasedOnQuality()
		{
			int result = 1;
			if (resolution == DofResolution.Medium)
			{
				result = 2;
			}
			else if (resolution == DofResolution.Low)
			{
				result = 2;
			}
			return result;
		}

		private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
		{
			int num = baseDivider;
			if (resolution == DofResolution.High)
			{
				num *= 2;
			}
			if (resolution == DofResolution.Low)
			{
				num *= 2;
			}
			return num;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (smoothness < 0.1f)
			{
				smoothness = 0.1f;
			}
			bokeh = bokeh && bokehSupport;
			float num = ((!bokeh) ? 1f : BOKEH_EXTRA_BLUR);
			bool flag = quality > Dof34QualitySetting.OnlyBackground;
			float num2 = focalSize / (_camera.farClipPlane - _camera.nearClipPlane);
			if (simpleTweakMode)
			{
				focalDistance01 = ((!objectFocus) ? FocalDistance01(focalPoint) : (_camera.WorldToViewportPoint(objectFocus.position).z / _camera.farClipPlane));
				focalStartCurve = focalDistance01 * smoothness;
				focalEndCurve = focalStartCurve;
				flag = flag && focalPoint > _camera.nearClipPlane + Mathf.Epsilon;
			}
			else
			{
				if ((bool)objectFocus)
				{
					Vector3 vector = _camera.WorldToViewportPoint(objectFocus.position);
					vector.z /= _camera.farClipPlane;
					focalDistance01 = vector.z;
				}
				else
				{
					focalDistance01 = FocalDistance01(focalZDistance);
				}
				focalStartCurve = focalZStartCurve;
				focalEndCurve = focalZEndCurve;
				flag = flag && focalPoint > _camera.nearClipPlane + Mathf.Epsilon;
			}
			widthOverHeight = 1f * (float)source.width / (1f * (float)source.height);
			oneOverBaseSize = 0.001953125f;
			dofMaterial.SetFloat("_ForegroundBlurExtrude", foregroundBlurExtrude);
			dofMaterial.SetVector("_CurveParams", new Vector4((!simpleTweakMode) ? focalStartCurve : (1f / focalStartCurve), (!simpleTweakMode) ? focalEndCurve : (1f / focalEndCurve), num2 * 0.5f, focalDistance01));
			dofMaterial.SetVector("_InvRenderTargetSize", new Vector4(1f / (1f * (float)source.width), 1f / (1f * (float)source.height), 0f, 0f));
			int dividerBasedOnQuality = GetDividerBasedOnQuality();
			int lowResolutionDividerBasedOnQuality = GetLowResolutionDividerBasedOnQuality(dividerBasedOnQuality);
			AllocateTextures(flag, source, dividerBasedOnQuality, lowResolutionDividerBasedOnQuality);
			Graphics.Blit(source, source, dofMaterial, 3);
			Downsample(source, mediumRezWorkTexture);
			Blur(mediumRezWorkTexture, mediumRezWorkTexture, DofBlurriness.Low, 4, maxBlurSpread);
			if (bokeh && (BokehDestination.Foreground & bokehDestination) != 0)
			{
				dofMaterial.SetVector("_Threshhold", new Vector4(bokehThresholdContrast, bokehThresholdLuminance, 0.95f, 0f));
				Graphics.Blit(mediumRezWorkTexture, bokehSource2, dofMaterial, 11);
				Graphics.Blit(mediumRezWorkTexture, lowRezWorkTexture);
				Blur(lowRezWorkTexture, lowRezWorkTexture, bluriness, 0, maxBlurSpread * num);
			}
			else
			{
				Downsample(mediumRezWorkTexture, lowRezWorkTexture);
				Blur(lowRezWorkTexture, lowRezWorkTexture, bluriness, 0, maxBlurSpread);
			}
			dofBlurMaterial.SetTexture("_TapLow", lowRezWorkTexture);
			dofBlurMaterial.SetTexture("_TapMedium", mediumRezWorkTexture);
			Graphics.Blit(null, finalDefocus, dofBlurMaterial, 3);
			if (bokeh && (BokehDestination.Foreground & bokehDestination) != 0)
			{
				AddBokeh(bokehSource2, bokehSource, finalDefocus);
			}
			dofMaterial.SetTexture("_TapLowBackground", finalDefocus);
			dofMaterial.SetTexture("_TapMedium", mediumRezWorkTexture);
			Graphics.Blit(source, (!flag) ? destination : foregroundTexture, dofMaterial, visualize ? 2 : 0);
			if (flag)
			{
				Graphics.Blit(foregroundTexture, source, dofMaterial, 5);
				Downsample(source, mediumRezWorkTexture);
				BlurFg(mediumRezWorkTexture, mediumRezWorkTexture, DofBlurriness.Low, 2, maxBlurSpread);
				if (bokeh && (BokehDestination.Foreground & bokehDestination) != 0)
				{
					dofMaterial.SetVector("_Threshhold", new Vector4(bokehThresholdContrast * 0.5f, bokehThresholdLuminance, 0f, 0f));
					Graphics.Blit(mediumRezWorkTexture, bokehSource2, dofMaterial, 11);
					Graphics.Blit(mediumRezWorkTexture, lowRezWorkTexture);
					BlurFg(lowRezWorkTexture, lowRezWorkTexture, bluriness, 1, maxBlurSpread * num);
				}
				else
				{
					BlurFg(mediumRezWorkTexture, lowRezWorkTexture, bluriness, 1, maxBlurSpread);
				}
				Graphics.Blit(lowRezWorkTexture, finalDefocus);
				dofMaterial.SetTexture("_TapLowForeground", finalDefocus);
				Graphics.Blit(source, destination, dofMaterial, visualize ? 1 : 4);
				if (bokeh && (BokehDestination.Foreground & bokehDestination) != 0)
				{
					AddBokeh(bokehSource2, bokehSource, destination);
				}
			}
			ReleaseTextures();
		}

		private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(to.width, to.height);
			if (iterations > DofBlurriness.Low)
			{
				BlurHex(from, to, blurPass, spread, temporary);
				if (iterations > DofBlurriness.High)
				{
					dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
					Graphics.Blit(to, temporary, dofBlurMaterial, blurPass);
					dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
					Graphics.Blit(temporary, to, dofBlurMaterial, blurPass);
				}
			}
			else
			{
				dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
				Graphics.Blit(from, temporary, dofBlurMaterial, blurPass);
				dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
				Graphics.Blit(temporary, to, dofBlurMaterial, blurPass);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
			dofBlurMaterial.SetTexture("_TapHigh", from);
			RenderTexture temporary = RenderTexture.GetTemporary(to.width, to.height);
			if (iterations > DofBlurriness.Low)
			{
				BlurHex(from, to, blurPass, spread, temporary);
				if (iterations > DofBlurriness.High)
				{
					dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
					Graphics.Blit(to, temporary, dofBlurMaterial, blurPass);
					dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
					Graphics.Blit(temporary, to, dofBlurMaterial, blurPass);
				}
			}
			else
			{
				dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
				Graphics.Blit(from, temporary, dofBlurMaterial, blurPass);
				dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
				Graphics.Blit(temporary, to, dofBlurMaterial, blurPass);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
		{
			dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
			Graphics.Blit(from, tmp, dofBlurMaterial, blurPass);
			dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
			Graphics.Blit(tmp, to, dofBlurMaterial, blurPass);
			dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, spread * oneOverBaseSize, 0f, 0f));
			Graphics.Blit(to, tmp, dofBlurMaterial, blurPass);
			dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, (0f - spread) * oneOverBaseSize, 0f, 0f));
			Graphics.Blit(tmp, to, dofBlurMaterial, blurPass);
		}

		private void Downsample(RenderTexture from, RenderTexture to)
		{
			dofMaterial.SetVector("_InvRenderTargetSize", new Vector4(1f / (1f * (float)to.width), 1f / (1f * (float)to.height), 0f, 0f));
			Graphics.Blit(from, to, dofMaterial, SMOOTH_DOWNSAMPLE_PASS);
		}

		private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
		{
			if (!bokehMaterial)
			{
				return;
			}
			Mesh[] meshes = Quads.GetMeshes(tempTex.width, tempTex.height);
			RenderTexture.active = tempTex;
			GL.Clear(clearDepth: false, clearColor: true, new Color(0f, 0f, 0f, 0f));
			GL.PushMatrix();
			GL.LoadIdentity();
			bokehInfo.filterMode = FilterMode.Point;
			float num = (float)bokehInfo.width * 1f / ((float)bokehInfo.height * 1f);
			float num2 = 2f / (1f * (float)bokehInfo.width);
			num2 += bokehScale * maxBlurSpread * BOKEH_EXTRA_BLUR * oneOverBaseSize;
			bokehMaterial.SetTexture("_Source", bokehInfo);
			bokehMaterial.SetTexture("_MainTex", bokehTexture);
			bokehMaterial.SetVector("_ArScale", new Vector4(num2, num2 * num, 0.5f, 0.5f * num));
			bokehMaterial.SetFloat("_Intensity", bokehIntensity);
			bokehMaterial.SetPass(0);
			Mesh[] array = meshes;
			foreach (Mesh mesh in array)
			{
				if ((bool)mesh)
				{
					Graphics.DrawMeshNow(mesh, Matrix4x4.identity);
				}
			}
			GL.PopMatrix();
			Graphics.Blit(tempTex, finalTarget, dofMaterial, 8);
			bokehInfo.filterMode = FilterMode.Bilinear;
		}

		private void ReleaseTextures()
		{
			if ((bool)foregroundTexture)
			{
				RenderTexture.ReleaseTemporary(foregroundTexture);
			}
			if ((bool)finalDefocus)
			{
				RenderTexture.ReleaseTemporary(finalDefocus);
			}
			if ((bool)mediumRezWorkTexture)
			{
				RenderTexture.ReleaseTemporary(mediumRezWorkTexture);
			}
			if ((bool)lowRezWorkTexture)
			{
				RenderTexture.ReleaseTemporary(lowRezWorkTexture);
			}
			if ((bool)bokehSource)
			{
				RenderTexture.ReleaseTemporary(bokehSource);
			}
			if ((bool)bokehSource2)
			{
				RenderTexture.ReleaseTemporary(bokehSource2);
			}
		}

		private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
		{
			foregroundTexture = null;
			if (blurForeground)
			{
				foregroundTexture = RenderTexture.GetTemporary(source.width, source.height, 0);
			}
			mediumRezWorkTexture = RenderTexture.GetTemporary(source.width / divider, source.height / divider, 0);
			finalDefocus = RenderTexture.GetTemporary(source.width / divider, source.height / divider, 0);
			lowRezWorkTexture = RenderTexture.GetTemporary(source.width / lowTexDivider, source.height / lowTexDivider, 0);
			bokehSource = null;
			bokehSource2 = null;
			if (bokeh)
			{
				bokehSource = RenderTexture.GetTemporary(source.width / (lowTexDivider * bokehDownsample), source.height / (lowTexDivider * bokehDownsample), 0, RenderTextureFormat.ARGBHalf);
				bokehSource2 = RenderTexture.GetTemporary(source.width / (lowTexDivider * bokehDownsample), source.height / (lowTexDivider * bokehDownsample), 0, RenderTextureFormat.ARGBHalf);
				bokehSource.filterMode = FilterMode.Bilinear;
				bokehSource2.filterMode = FilterMode.Bilinear;
				RenderTexture.active = bokehSource2;
				GL.Clear(clearDepth: false, clearColor: true, new Color(0f, 0f, 0f, 0f));
			}
			source.filterMode = FilterMode.Bilinear;
			finalDefocus.filterMode = FilterMode.Bilinear;
			mediumRezWorkTexture.filterMode = FilterMode.Bilinear;
			lowRezWorkTexture.filterMode = FilterMode.Bilinear;
			if ((bool)foregroundTexture)
			{
				foregroundTexture.filterMode = FilterMode.Bilinear;
			}
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Edge Detection/Edge Detection")]
	[RequireComponent(typeof(Camera))]
	public class EdgeDetection : PostEffectsBase
	{
		public enum EdgeDetectMode
		{
			TriangleDepthNormals,
			RobertsCrossDepthNormals,
			SobelDepth,
			SobelDepthThin,
			TriangleLuminance
		}

		public EdgeDetectMode mode = EdgeDetectMode.SobelDepthThin;

		public float sensitivityDepth = 1f;

		public float sensitivityNormals = 1f;

		public float lumThreshold = 0.2f;

		public float edgeExp = 1f;

		public float sampleDist = 1f;

		public float edgesOnly;

		public Color edgesOnlyBgColor = Color.white;

		public Shader edgeDetectShader;

		private Material edgeDetectMaterial;

		private EdgeDetectMode oldMode = EdgeDetectMode.SobelDepthThin;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			edgeDetectMaterial = CheckShaderAndCreateMaterial(edgeDetectShader, edgeDetectMaterial);
			if (mode != oldMode)
			{
				SetCameraFlag();
			}
			oldMode = mode;
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private new void Start()
		{
			oldMode = mode;
		}

		private void SetCameraFlag()
		{
			if (mode == EdgeDetectMode.SobelDepth || mode == EdgeDetectMode.SobelDepthThin)
			{
				GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			else if (mode == EdgeDetectMode.TriangleDepthNormals || mode == EdgeDetectMode.RobertsCrossDepthNormals)
			{
				GetComponent<Camera>().depthTextureMode |= DepthTextureMode.DepthNormals;
			}
		}

		private void OnEnable()
		{
			SetCameraFlag();
		}

		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			Vector2 vector = new Vector2(sensitivityDepth, sensitivityNormals);
			edgeDetectMaterial.SetVector("_Sensitivity", new Vector4(vector.x, vector.y, 1f, vector.y));
			edgeDetectMaterial.SetFloat("_BgFade", edgesOnly);
			edgeDetectMaterial.SetFloat("_SampleDistance", sampleDist);
			edgeDetectMaterial.SetVector("_BgColor", edgesOnlyBgColor);
			edgeDetectMaterial.SetFloat("_Exponent", edgeExp);
			edgeDetectMaterial.SetFloat("_Threshold", lumThreshold);
			Graphics.Blit(source, destination, edgeDetectMaterial, (int)mode);
		}
	}
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Displacement/Fisheye")]
	[ExecuteInEditMode]
	public class Fisheye : PostEffectsBase
	{
		[Range(0f, 1.5f)]
		public float strengthX = 0.05f;

		[Range(0f, 1.5f)]
		public float strengthY = 0.05f;

		public Shader fishEyeShader;

		private Material fisheyeMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			fisheyeMaterial = CheckShaderAndCreateMaterial(fishEyeShader, fisheyeMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			float num = 5f / 32f;
			float num2 = (float)source.width * 1f / ((float)source.height * 1f);
			fisheyeMaterial.SetVector("intensity", new Vector4(strengthX * num2 * num, strengthY * num, strengthX * num2 * num, strengthY * num));
			Graphics.Blit(source, destination, fisheyeMaterial);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Global Fog")]
	internal class GlobalFog : PostEffectsBase
	{
		[Tooltip("Apply distance-based fog?")]
		public bool distanceFog = true;

		[Tooltip("Exclude far plane pixels from distance-based fog? (Skybox or clear color)")]
		public bool excludeFarPixels = true;

		[Tooltip("Distance fog is based on radial distance from camera when checked")]
		public bool useRadialDistance;

		[Tooltip("Apply height-based fog?")]
		public bool heightFog = true;

		[Tooltip("Fog top Y coordinate")]
		public float height = 1f;

		[Range(0.001f, 10f)]
		public float heightDensity = 2f;

		[Tooltip("Push fog away from the camera by this amount")]
		public float startDistance;

		public Shader fogShader;

		private Material fogMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			fogMaterial = CheckShaderAndCreateMaterial(fogShader, fogMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources() || (!distanceFog && !heightFog))
			{
				Graphics.Blit(source, destination);
				return;
			}
			Camera component = GetComponent<Camera>();
			Transform transform = component.transform;
			float nearClipPlane = component.nearClipPlane;
			float farClipPlane = component.farClipPlane;
			float fieldOfView = component.fieldOfView;
			float aspect = component.aspect;
			Matrix4x4 identity = Matrix4x4.identity;
			float num = fieldOfView * 0.5f;
			Vector3 vector = transform.right * nearClipPlane * Mathf.Tan(num * ((float)Math.PI / 180f)) * aspect;
			Vector3 vector2 = transform.up * nearClipPlane * Mathf.Tan(num * ((float)Math.PI / 180f));
			Vector3 vector3 = transform.forward * nearClipPlane - vector + vector2;
			float num2 = vector3.magnitude * farClipPlane / nearClipPlane;
			vector3.Normalize();
			vector3 *= num2;
			Vector3 vector4 = transform.forward * nearClipPlane + vector + vector2;
			vector4.Normalize();
			vector4 *= num2;
			Vector3 vector5 = transform.forward * nearClipPlane + vector - vector2;
			vector5.Normalize();
			vector5 *= num2;
			Vector3 vector6 = transform.forward * nearClipPlane - vector - vector2;
			vector6.Normalize();
			vector6 *= num2;
			identity.SetRow(0, vector3);
			identity.SetRow(1, vector4);
			identity.SetRow(2, vector5);
			identity.SetRow(3, vector6);
			Vector3 position = transform.position;
			float num3 = position.y - height;
			float z = ((!(num3 <= 0f)) ? 0f : 1f);
			float y = ((!excludeFarPixels) ? 2f : 1f);
			fogMaterial.SetMatrix("_FrustumCornersWS", identity);
			fogMaterial.SetVector("_CameraWS", position);
			fogMaterial.SetVector("_HeightParams", new Vector4(height, num3, z, heightDensity * 0.5f));
			fogMaterial.SetVector("_DistanceParams", new Vector4(0f - Mathf.Max(startDistance, 0f), y, 0f, 0f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == FogMode.Linear;
			float num4 = ((!flag) ? 0f : (fogEndDistance - fogStartDistance));
			float num5 = ((!(Mathf.Abs(num4) > 0.0001f)) ? 0f : (1f / num4));
			Vector4 vector7 = default(Vector4);
			vector7.x = fogDensity * 1.2011224f;
			vector7.y = fogDensity * 1.442695f;
			vector7.z = ((!flag) ? 0f : (0f - num5));
			vector7.w = ((!flag) ? 0f : (fogEndDistance * num5));
			fogMaterial.SetVector("_SceneFogParams", vector7);
			fogMaterial.SetVector("_SceneFogMode", new Vector4((float)fogMode, useRadialDistance ? 1 : 0, 0f, 0f));
			int num6 = 0;
			CustomGraphicsBlit(passNr: (!distanceFog || !heightFog) ? (distanceFog ? 1 : 2) : 0, source: source, dest: destination, fxMaterial: fogMaterial);
		}

		private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr)
		{
			RenderTexture.active = dest;
			fxMaterial.SetTexture("_MainTex", source);
			GL.PushMatrix();
			GL.LoadOrtho();
			fxMaterial.SetPass(passNr);
			GL.Begin(7);
			GL.MultiTexCoord2(0, 0f, 0f);
			GL.Vertex3(0f, 0f, 3f);
			GL.MultiTexCoord2(0, 1f, 0f);
			GL.Vertex3(1f, 0f, 2f);
			GL.MultiTexCoord2(0, 1f, 1f);
			GL.Vertex3(1f, 1f, 1f);
			GL.MultiTexCoord2(0, 0f, 1f);
			GL.Vertex3(0f, 1f, 0f);
			GL.End();
			GL.PopMatrix();
		}
	}
	[AddComponentMenu("Image Effects/Color Adjustments/Grayscale")]
	[ExecuteInEditMode]
	public class Grayscale : ImageEffectBase
	{
		public Texture textureRamp;

		[Range(-1f, 1f)]
		public float rampOffset;

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			base.material.SetTexture("_RampTex", textureRamp);
			base.material.SetFloat("_RampOffset", rampOffset);
			Graphics.Blit(source, destination, base.material);
		}
	}
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("")]
	public class ImageEffectBase : MonoBehaviour
	{
		public Shader shader;

		private Material m_Material;

		protected Material material
		{
			get
			{
				if (m_Material == null)
				{
					m_Material = new Material(shader);
					m_Material.hideFlags = HideFlags.HideAndDontSave;
				}
				return m_Material;
			}
		}

		protected virtual void Start()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
			}
			else if (!shader || !shader.isSupported)
			{
				base.enabled = false;
			}
		}

		protected virtual void OnDisable()
		{
			if ((bool)m_Material)
			{
				UnityEngine.Object.DestroyImmediate(m_Material);
			}
		}
	}
	[AddComponentMenu("")]
	public class ImageEffects
	{
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
			if (source.texelSize.y < 0f)
			{
				center.y = 1f - center.y;
				angle = 0f - angle;
			}
			Matrix4x4 matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(0f, 0f, angle), Vector3.one);
			material.SetMatrix("_RotationMatrix", matrix);
			material.SetVector("_CenterRadius", new Vector4(center.x, center.y, radius.x, radius.y));
			material.SetFloat("_Angle", angle * ((float)Math.PI / 180f));
			Graphics.Blit(source, destination, material);
		}

		[Obsolete("Use Graphics.Blit(source,dest) instead")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
			Graphics.Blit(source, dest);
		}

		[Obsolete("Use Graphics.Blit(source, destination, material) instead")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
			Graphics.Blit(source, dest, material);
		}
	}
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Blur/Motion Blur (Color Accumulation)")]
	[ExecuteInEditMode]
	public class MotionBlur : ImageEffectBase
	{
		[Range(0f, 0.92f)]
		public float blurAmount = 0.8f;

		public bool extraBlur;

		private RenderTexture accumTexture;

		protected override void Start()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = false;
			}
			else
			{
				base.Start();
			}
		}

		protected override void OnDisable()
		{
			base.OnDisable();
			UnityEngine.Object.DestroyImmediate(accumTexture);
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (accumTexture == null || accumTexture.width != source.width || accumTexture.height != source.height)
			{
				UnityEngine.Object.DestroyImmediate(accumTexture);
				accumTexture = new RenderTexture(source.width, source.height, 0);
				accumTexture.hideFlags = HideFlags.HideAndDontSave;
				Graphics.Blit(source, accumTexture);
			}
			if (extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0);
				accumTexture.MarkRestoreExpected();
				Graphics.Blit(accumTexture, temporary);
				Graphics.Blit(temporary, accumTexture);
				RenderTexture.ReleaseTemporary(temporary);
			}
			blurAmount = Mathf.Clamp(blurAmount, 0f, 0.92f);
			base.material.SetTexture("_MainTex", accumTexture);
			base.material.SetFloat("_AccumOrig", 1f - blurAmount);
			accumTexture.MarkRestoreExpected();
			Graphics.Blit(source, accumTexture, base.material);
			Graphics.Blit(accumTexture, destination);
		}
	}
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Noise/Noise And Grain (Filmic)")]
	public class NoiseAndGrain : PostEffectsBase
	{
		public float intensityMultiplier = 0.25f;

		public float generalIntensity = 0.5f;

		public float blackIntensity = 1f;

		public float whiteIntensity = 1f;

		public float midGrey = 0.2f;

		public bool dx11Grain;

		public float softness;

		public bool monochrome;

		public Vector3 intensities = new Vector3(1f, 1f, 1f);

		public Vector3 tiling = new Vector3(64f, 64f, 64f);

		public float monochromeTiling = 64f;

		public FilterMode filterMode = FilterMode.Bilinear;

		public Texture2D noiseTexture;

		public Shader noiseShader;

		private Material noiseMaterial;

		public Shader dx11NoiseShader;

		private Material dx11NoiseMaterial;

		private static float TILE_AMOUNT = 64f;

		private Mesh mesh;

		private void Awake()
		{
			mesh = new Mesh();
		}

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			noiseMaterial = CheckShaderAndCreateMaterial(noiseShader, noiseMaterial);
			if (dx11Grain && supportDX11)
			{
				dx11NoiseMaterial = CheckShaderAndCreateMaterial(dx11NoiseShader, dx11NoiseMaterial);
			}
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources() || null == noiseTexture)
			{
				Graphics.Blit(source, destination);
				if (null == noiseTexture)
				{
					Debug.LogWarning("Noise & Grain effect failing as noise texture is not assigned. please assign.", base.transform);
				}
				return;
			}
			softness = Mathf.Clamp(softness, 0f, 0.99f);
			if (dx11Grain && supportDX11)
			{
				dx11NoiseMaterial.SetFloat("_DX11NoiseTime", Time.frameCount);
				dx11NoiseMaterial.SetTexture("_NoiseTex", noiseTexture);
				dx11NoiseMaterial.SetVector("_NoisePerChannel", (!monochrome) ? intensities : Vector3.one);
				dx11NoiseMaterial.SetVector("_MidGrey", new Vector3(midGrey, 1f / (1f - midGrey), -1f / midGrey));
				dx11NoiseMaterial.SetVector("_NoiseAmount", new Vector3(generalIntensity, blackIntensity, whiteIntensity) * intensityMultiplier);
				if (softness > Mathf.Epsilon)
				{
					RenderTexture temporary = RenderTexture.GetTemporary((int)((float)source.width * (1f - softness)), (int)((float)source.height * (1f - softness)));
					DrawNoiseQuadGrid(source, temporary, dx11NoiseMaterial, noiseTexture, mesh, (!monochrome) ? 2 : 3);
					dx11NoiseMaterial.SetTexture("_NoiseTex", temporary);
					Graphics.Blit(source, destination, dx11NoiseMaterial, 4);
					RenderTexture.ReleaseTemporary(temporary);
				}
				else
				{
					DrawNoiseQuadGrid(source, destination, dx11NoiseMaterial, noiseTexture, mesh, monochrome ? 1 : 0);
				}
				return;
			}
			if ((bool)noiseTexture)
			{
				noiseTexture.wrapMode = TextureWrapMode.Repeat;
				noiseTexture.filterMode = filterMode;
			}
			noiseMaterial.SetTexture("_NoiseTex", noiseTexture);
			noiseMaterial.SetVector("_NoisePerChannel", (!monochrome) ? intensities : Vector3.one);
			noiseMaterial.SetVector("_NoiseTilingPerChannel", (!monochrome) ? tiling : (Vector3.one * monochromeTiling));
			noiseMaterial.SetVector("_MidGrey", new Vector3(midGrey, 1f / (1f - midGrey), -1f / midGrey));
			noiseMaterial.SetVector("_NoiseAmount", new Vector3(generalIntensity, blackIntensity, whiteIntensity) * intensityMultiplier);
			if (softness > Mathf.Epsilon)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary((int)((float)source.width * (1f - softness)), (int)((float)source.height * (1f - softness)));
				DrawNoiseQuadGrid(source, temporary2, noiseMaterial, noiseTexture, mesh, 2);
				noiseMaterial.SetTexture("_NoiseTex", temporary2);
				Graphics.Blit(source, destination, noiseMaterial, 1);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				DrawNoiseQuadGrid(source, destination, noiseMaterial, noiseTexture, mesh, 0);
			}
		}

		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, Mesh mesh, int passNr)
		{
			RenderTexture.active = dest;
			fxMaterial.SetTexture("_MainTex", source);
			GL.PushMatrix();
			GL.LoadOrtho();
			fxMaterial.SetPass(passNr);
			BuildMesh(mesh, source, noise);
			Transform transform = Camera.main.transform;
			Vector3 position = transform.position;
			Quaternion rotation = transform.rotation;
			transform.position = Vector3.zero;
			transform.rotation = Quaternion.identity;
			Graphics.DrawMeshNow(mesh, Matrix4x4.identity);
			transform.position = position;
			transform.rotation = rotation;
			GL.PopMatrix();
		}

		private static void BuildMesh(Mesh mesh, RenderTexture source, Texture2D noise)
		{
			float noiseSize = (float)noise.width * 1f;
			float num = 1f * (float)source.width / TILE_AMOUNT;
			float num2 = 1f * (float)source.width / (1f * (float)source.height);
			float num3 = 1f / num;
			float num4 = num3 * num2;
			int num5 = (int)Mathf.Ceil(num);
			int num6 = (int)Mathf.Ceil(1f / num4);
			if (mesh.vertices.Length != num5 * num6 * 4)
			{
				Vector3[] array = new Vector3[num5 * num6 * 4];
				Vector2[] array2 = new Vector2[num5 * num6 * 4];
				int[] array3 = new int[num5 * num6 * 6];
				int num7 = 0;
				int num8 = 0;
				for (float num9 = 0f; num9 < 1f; num9 += num3)
				{
					for (float num10 = 0f; num10 < 1f; num10 += num4)
					{
						ref Vector3 reference = ref array[num7];
						reference = new Vector3(num9, num10, 0.1f);
						ref Vector3 reference2 = ref array[num7 + 1];
						reference2 = new Vector3(num9 + num3, num10, 0.1f);
						ref Vector3 reference3 = ref array[num7 + 2];
						reference3 = new Vector3(num9 + num3, num10 + num4, 0.1f);
						ref Vector3 reference4 = ref array[num7 + 3];
						reference4 = new Vector3(num9, num10 + num4, 0.1f);
						ref Vector2 reference5 = ref array2[num7];
						reference5 = new Vector2(0f, 0f);
						ref Vector2 reference6 = ref array2[num7 + 1];
						reference6 = new Vector2(1f, 0f);
						ref Vector2 reference7 = ref array2[num7 + 2];
						reference7 = new Vector2(1f, 1f);
						ref Vector2 reference8 = ref array2[num7 + 3];
						reference8 = new Vector2(0f, 1f);
						array3[num8] = num7;
						array3[num8 + 1] = num7 + 1;
						array3[num8 + 2] = num7 + 2;
						array3[num8 + 3] = num7;
						array3[num8 + 4] = num7 + 2;
						array3[num8 + 5] = num7 + 3;
						num7 += 4;
						num8 += 6;
					}
				}
				mesh.vertices = array;
				mesh.uv2 = array2;
				mesh.triangles = array3;
			}
			BuildMeshUV0(mesh, num5, num6, noiseSize, noise.width);
		}

		private static void BuildMeshUV0(Mesh mesh, int width, int height, float noiseSize, int noiseWidth)
		{
			float num = noiseSize / ((float)noiseWidth * 1f);
			float num2 = 1f / noiseSize;
			Vector2[] array = new Vector2[width * height * 4];
			int num3 = 0;
			for (int i = 0; i < width * height; i++)
			{
				float f = UnityEngine.Random.Range(0f, noiseSize);
				float f2 = UnityEngine.Random.Range(0f, noiseSize);
				f = Mathf.Floor(f) * num2;
				f2 = Mathf.Floor(f2) * num2;
				ref Vector2 reference = ref array[num3];
				reference = new Vector2(f, f2);
				ref Vector2 reference2 = ref array[num3 + 1];
				reference2 = new Vector2(f + num * num2, f2);
				ref Vector2 reference3 = ref array[num3 + 2];
				reference3 = new Vector2(f + num * num2, f2 + num * num2);
				ref Vector2 reference4 = ref array[num3 + 3];
				reference4 = new Vector2(f, f2 + num * num2);
				num3 += 4;
			}
			mesh.uv = array;
		}
	}
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Noise/Noise and Scratches")]
	[ExecuteInEditMode]
	public class NoiseAndScratches : MonoBehaviour
	{
		public bool monochrome = true;

		private bool rgbFallback;

		[Range(0f, 5f)]
		public float grainIntensityMin = 0.1f;

		[Range(0f, 5f)]
		public float grainIntensityMax = 0.2f;

		[Range(0.1f, 50f)]
		public float grainSize = 2f;

		[Range(0f, 5f)]
		public float scratchIntensityMin = 0.05f;

		[Range(0f, 5f)]
		public float scratchIntensityMax = 0.25f;

		[Range(1f, 30f)]
		public float scratchFPS = 10f;

		[Range(0f, 1f)]
		public float scratchJitter = 0.01f;

		public Texture grainTexture;

		public Texture scratchTexture;

		public Shader shaderRGB;

		public Shader shaderYUV;

		private Material m_MaterialRGB;

		private Material m_MaterialYUV;

		private float scratchTimeLeft;

		private float scratchX;

		private float scratchY;

		protected Material material
		{
			get
			{
				if (m_MaterialRGB == null)
				{
					m_MaterialRGB = new Material(shaderRGB);
					m_MaterialRGB.hideFlags = HideFlags.HideAndDontSave;
				}
				if (m_MaterialYUV == null && !rgbFallback)
				{
					m_MaterialYUV = new Material(shaderYUV);
					m_MaterialYUV.hideFlags = HideFlags.HideAndDontSave;
				}
				return (rgbFallback || monochrome) ? m_MaterialRGB : m_MaterialYUV;
			}
		}

		protected void Start()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
			}
			else if (shaderRGB == null || shaderYUV == null)
			{
				Debug.Log("Noise shaders are not set up! Disabling noise effect.");
				base.enabled = false;
			}
			else if (!shaderRGB.isSupported)
			{
				base.enabled = false;
			}
			else if (!shaderYUV.isSupported)
			{
				rgbFallback = true;
			}
		}

		protected void OnDisable()
		{
			if ((bool)m_MaterialRGB)
			{
				UnityEngine.Object.DestroyImmediate(m_MaterialRGB);
			}
			if ((bool)m_MaterialYUV)
			{
				UnityEngine.Object.DestroyImmediate(m_MaterialYUV);
			}
		}

		private void SanitizeParameters()
		{
			grainIntensityMin = Mathf.Clamp(grainIntensityMin, 0f, 5f);
			grainIntensityMax = Mathf.Clamp(grainIntensityMax, 0f, 5f);
			scratchIntensityMin = Mathf.Clamp(scratchIntensityMin, 0f, 5f);
			scratchIntensityMax = Mathf.Clamp(scratchIntensityMax, 0f, 5f);
			scratchFPS = Mathf.Clamp(scratchFPS, 1f, 30f);
			scratchJitter = Mathf.Clamp(scratchJitter, 0f, 1f);
			grainSize = Mathf.Clamp(grainSize, 0.1f, 50f);
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			SanitizeParameters();
			if (scratchTimeLeft <= 0f)
			{
				scratchTimeLeft = UnityEngine.Random.value * 2f / scratchFPS;
				scratchX = UnityEngine.Random.value;
				scratchY = UnityEngine.Random.value;
			}
			scratchTimeLeft -= Time.deltaTime;
			Material material = this.material;
			material.SetTexture("_GrainTex", grainTexture);
			material.SetTexture("_ScratchTex", scratchTexture);
			float num = 1f / grainSize;
			material.SetVector("_GrainOffsetScale", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)grainTexture.width * num, (float)Screen.height / (float)grainTexture.height * num));
			material.SetVector("_ScratchOffsetScale", new Vector4(scratchX + UnityEngine.Random.value * scratchJitter, scratchY + UnityEngine.Random.value * scratchJitter, (float)Screen.width / (float)scratchTexture.width, (float)Screen.height / (float)scratchTexture.height));
			material.SetVector("_Intensity", new Vector4(UnityEngine.Random.Range(grainIntensityMin, grainIntensityMax), UnityEngine.Random.Range(scratchIntensityMin, scratchIntensityMax), 0f, 0f));
			Graphics.Blit(source, destination, material);
		}
	}
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class PostEffectsBase : MonoBehaviour
	{
		protected bool supportHDRTextures = true;

		protected bool supportDX11;

		protected bool isSupported = true;

		private List<Material> createdMaterials = new List<Material>();

		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			if (!s)
			{
				Debug.Log("Missing shader in " + ToString());
				base.enabled = false;
				return null;
			}
			if (s.isSupported && (bool)m2Create && m2Create.shader == s)
			{
				return m2Create;
			}
			if (!s.isSupported)
			{
				NotSupported();
				Debug.Log("The shader " + s.ToString() + " on effect " + ToString() + " is not supported on this platform!");
				return null;
			}
			m2Create = new Material(s);
			createdMaterials.Add(m2Create);
			m2Create.hideFlags = HideFlags.DontSave;
			return m2Create;
		}

		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			if (!s)
			{
				Debug.Log("Missing shader in " + ToString());
				return null;
			}
			if ((bool)m2Create && m2Create.shader == s && s.isSupported)
			{
				return m2Create;
			}
			if (!s.isSupported)
			{
				return null;
			}
			m2Create = new Material(s);
			createdMaterials.Add(m2Create);
			m2Create.hideFlags = HideFlags.DontSave;
			return m2Create;
		}

		private void OnEnable()
		{
			isSupported = true;
		}

		private void OnDestroy()
		{
			RemoveCreatedMaterials();
		}

		private void RemoveCreatedMaterials()
		{
			while (createdMaterials.Count > 0)
			{
				Material obj = createdMaterials[0];
				createdMaterials.RemoveAt(0);
				UnityEngine.Object.Destroy(obj);
			}
		}

		protected bool CheckSupport()
		{
			return CheckSupport(needDepth: false);
		}

		public virtual bool CheckResources()
		{
			Debug.LogWarning("CheckResources () for " + ToString() + " should be overwritten.");
			return isSupported;
		}

		protected void Start()
		{
			CheckResources();
		}

		protected bool CheckSupport(bool needDepth)
		{
			isSupported = true;
			supportHDRTextures = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf);
			supportDX11 = SystemInfo.graphicsShaderLevel >= 50 && SystemInfo.supportsComputeShaders;
			if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures)
			{
				NotSupported();
				return false;
			}
			if (needDepth && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				NotSupported();
				return false;
			}
			if (needDepth)
			{
				GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			return true;
		}

		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			if (!CheckSupport(needDepth))
			{
				return false;
			}
			if (needHdr && !supportHDRTextures)
			{
				NotSupported();
				return false;
			}
			return true;
		}

		public bool Dx11Support()
		{
			return supportDX11;
		}

		protected void ReportAutoDisable()
		{
			Debug.LogWarning("The image effect " + ToString() + " has been disabled as it's not supported on the current platform.");
		}

		private bool CheckShader(Shader s)
		{
			Debug.Log("The shader " + s.ToString() + " on effect " + ToString() + " is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package.");
			if (!s.isSupported)
			{
				NotSupported();
				return false;
			}
			return false;
		}

		protected void NotSupported()
		{
			base.enabled = false;
			isSupported = false;
		}

		protected void DrawBorder(RenderTexture dest, Material material)
		{
			RenderTexture.active = dest;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < material.passCount; i++)
			{
				material.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1f;
					y2 = 0f;
				}
				else
				{
					y = 0f;
					y2 = 1f;
				}
				float x = 0f;
				float x2 = 0f + 1f / ((float)dest.width * 1f);
				float y3 = 0f;
				float y4 = 1f;
				GL.Begin(7);
				GL.TexCoord2(0f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x, y4, 0.1f);
				x = 1f - 1f / ((float)dest.width * 1f);
				x2 = 1f;
				y3 = 0f;
				y4 = 1f;
				GL.TexCoord2(0f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x, y4, 0.1f);
				x = 0f;
				x2 = 1f;
				y3 = 0f;
				y4 = 0f + 1f / ((float)dest.height * 1f);
				GL.TexCoord2(0f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x, y4, 0.1f);
				x = 0f;
				x2 = 1f;
				y3 = 1f - 1f / ((float)dest.height * 1f);
				y4 = 1f;
				GL.TexCoord2(0f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x, y4, 0.1f);
				GL.End();
			}
			GL.PopMatrix();
		}
	}
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	internal class PostEffectsHelper : MonoBehaviour
	{
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			Debug.Log("OnRenderImage in Helper called ...");
		}

		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
			RenderTexture.active = dest;
			material.SetTexture("_MainTex", source);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(cameraForProjectionMatrix.projectionMatrix);
			float f = cameraForProjectionMatrix.fieldOfView * 0.5f * ((float)Math.PI / 180f);
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = cameraForProjectionMatrix.aspect;
			float num2 = aspect / (0f - num);
			float num3 = aspect / num;
			float num4 = 1f / (0f - num);
			float num5 = 1f / num;
			float num6 = 1f;
			num2 *= dist * num6;
			num3 *= dist * num6;
			num4 *= dist * num6;
			num5 *= dist * num6;
			float z = 0f - dist;
			for (int i = 0; i < material.passCount; i++)
			{
				material.SetPass(i);
				GL.Begin(7);
				float y;
				float y2;
				if (flag)
				{
					y = 1f;
					y2 = 0f;
				}
				else
				{
					y = 0f;
					y2 = 1f;
				}
				GL.TexCoord2(0f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(1f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		private static void DrawBorder(RenderTexture dest, Material material)
		{
			RenderTexture.active = dest;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < material.passCount; i++)
			{
				material.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1f;
					y2 = 0f;
				}
				else
				{
					y = 0f;
					y2 = 1f;
				}
				float x = 0f;
				float x2 = 0f + 1f / ((float)dest.width * 1f);
				float y3 = 0f;
				float y4 = 1f;
				GL.Begin(7);
				GL.TexCoord2(0f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x, y4, 0.1f);
				x = 1f - 1f / ((float)dest.width * 1f);
				x2 = 1f;
				y3 = 0f;
				y4 = 1f;
				GL.TexCoord2(0f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x, y4, 0.1f);
				x = 0f;
				x2 = 1f;
				y3 = 0f;
				y4 = 0f + 1f / ((float)dest.height * 1f);
				GL.TexCoord2(0f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x, y4, 0.1f);
				x = 0f;
				x2 = 1f;
				y3 = 1f - 1f / ((float)dest.height * 1f);
				y4 = 1f;
				GL.TexCoord2(0f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x, y4, 0.1f);
				GL.End();
			}
			GL.PopMatrix();
		}

		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
			RenderTexture.active = dest;
			material.SetTexture("_MainTex", source);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < material.passCount; i++)
			{
				material.SetPass(i);
				GL.Begin(7);
				float y3;
				float y4;
				if (flag)
				{
					y3 = 1f;
					y4 = 0f;
				}
				else
				{
					y3 = 0f;
					y4 = 1f;
				}
				GL.TexCoord2(0f, y3);
				GL.Vertex3(x1, y1, 0.1f);
				GL.TexCoord2(1f, y3);
				GL.Vertex3(x2, y1, 0.1f);
				GL.TexCoord2(1f, y4);
				GL.Vertex3(x2, y2, 0.1f);
				GL.TexCoord2(0f, y4);
				GL.Vertex3(x1, y2, 0.1f);
				GL.End();
			}
			GL.PopMatrix();
		}
	}
	internal class Quads
	{
		private static Mesh[] meshes;

		private static int currentQuads;

		private static bool HasMeshes()
		{
			if (meshes == null)
			{
				return false;
			}
			Mesh[] array = meshes;
			foreach (Mesh mesh in array)
			{
				if (null == mesh)
				{
					return false;
				}
			}
			return true;
		}

		public static void Cleanup()
		{
			if (meshes == null)
			{
				return;
			}
			for (int i = 0; i < meshes.Length; i++)
			{
				if (null != meshes[i])
				{
					UnityEngine.Object.DestroyImmediate(meshes[i]);
					meshes[i] = null;
				}
			}
			meshes = null;
		}

		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			if (HasMeshes() && currentQuads == totalWidth * totalHeight)
			{
				return meshes;
			}
			int num = 10833;
			int num2 = (currentQuads = totalWidth * totalHeight);
			int num3 = Mathf.CeilToInt(1f * (float)num2 / (1f * (float)num));
			meshes = new Mesh[num3];
			int num4 = 0;
			int num5 = 0;
			for (num4 = 0; num4 < num2; num4 += num)
			{
				int triCount = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
				meshes[num5] = GetMesh(triCount, num4, totalWidth, totalHeight);
				num5++;
			}
			return meshes;
		}

		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			Mesh mesh = new Mesh();
			mesh.hideFlags = HideFlags.DontSave;
			Vector3[] array = new Vector3[triCount * 4];
			Vector2[] array2 = new Vector2[triCount * 4];
			Vector2[] array3 = new Vector2[triCount * 4];
			int[] array4 = new int[triCount * 6];
			for (int i = 0; i < triCount; i++)
			{
				int num = i * 4;
				int num2 = i * 6;
				int num3 = triOffset + i;
				float num4 = Mathf.Floor(num3 % totalWidth) / (float)totalWidth;
				float num5 = Mathf.Floor(num3 / totalWidth) / (float)totalHeight;
				Vector3 vector = new Vector3(num4 * 2f - 1f, num5 * 2f - 1f, 1f);
				array[num] = vector;
				array[num + 1] = vector;
				array[num + 2] = vector;
				array[num + 3] = vector;
				ref Vector2 reference = ref array2[num];
				reference = new Vector2(0f, 0f);
				ref Vector2 reference2 = ref array2[num + 1];
				reference2 = new Vector2(1f, 0f);
				ref Vector2 reference3 = ref array2[num + 2];
				reference3 = new Vector2(0f, 1f);
				ref Vector2 reference4 = ref array2[num + 3];
				reference4 = new Vector2(1f, 1f);
				ref Vector2 reference5 = ref array3[num];
				reference5 = new Vector2(num4, num5);
				ref Vector2 reference6 = ref array3[num + 1];
				reference6 = new Vector2(num4, num5);
				ref Vector2 reference7 = ref array3[num + 2];
				reference7 = new Vector2(num4, num5);
				ref Vector2 reference8 = ref array3[num + 3];
				reference8 = new Vector2(num4, num5);
				array4[num2] = num;
				array4[num2 + 1] = num + 1;
				array4[num2 + 2] = num + 2;
				array4[num2 + 3] = num + 1;
				array4[num2 + 4] = num + 2;
				array4[num2 + 5] = num + 3;
			}
			mesh.vertices = array;
			mesh.triangles = array4;
			mesh.uv = array2;
			mesh.uv2 = array3;
			return mesh;
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Other/Screen Overlay")]
	[RequireComponent(typeof(Camera))]
	public class ScreenOverlay : PostEffectsBase
	{
		public enum OverlayBlendMode
		{
			Additive,
			ScreenBlend,
			Multiply,
			Overlay,
			AlphaBlend
		}

		public OverlayBlendMode blendMode = OverlayBlendMode.Overlay;

		public float intensity = 1f;

		public Texture2D texture;

		public Shader overlayShader;

		private Material overlayMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			overlayMaterial = CheckShaderAndCreateMaterial(overlayShader, overlayMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			Vector4 vector = new Vector4(1f, 0f, 0f, 1f);
			overlayMaterial.SetVector("_UV_Transform", vector);
			overlayMaterial.SetFloat("_Intensity", intensity);
			overlayMaterial.SetTexture("_Overlay", texture);
			Graphics.Blit(source, destination, overlayMaterial, (int)blendMode);
		}
	}
	[AddComponentMenu("Image Effects/Rendering/Screen Space Ambient Obscurance")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		[Range(0f, 3f)]
		public float intensity = 0.5f;

		[Range(0.1f, 3f)]
		public float radius = 0.2f;

		[Range(0f, 3f)]
		public int blurIterations = 1;

		[Range(0f, 5f)]
		public float blurFilterDistance = 1.25f;

		[Range(0f, 1f)]
		public int downsample;

		public Texture2D rand;

		public Shader aoShader;

		private Material aoMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			aoMaterial = CheckShaderAndCreateMaterial(aoShader, aoMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnDisable()
		{
			if ((bool)aoMaterial)
			{
				UnityEngine.Object.DestroyImmediate(aoMaterial);
			}
			aoMaterial = null;
		}

		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			Camera component = GetComponent<Camera>();
			Matrix4x4 projectionMatrix = component.projectionMatrix;
			Matrix4x4 inverse = projectionMatrix.inverse;
			Vector4 vector = new Vector4(-2f / projectionMatrix[0, 0], -2f / projectionMatrix[1, 1], (1f - projectionMatrix[0, 2]) / projectionMatrix[0, 0], (1f + projectionMatrix[1, 2]) / projectionMatrix[1, 1]);
			if (component.stereoEnabled)
			{
				Matrix4x4 stereoProjectionMatrix = component.GetStereoProjectionMatrix(Camera.StereoscopicEye.Left);
				Matrix4x4 stereoProjectionMatrix2 = component.GetStereoProjectionMatrix(Camera.StereoscopicEye.Right);
				Vector4 vector2 = new Vector4(-2f / stereoProjectionMatrix[0, 0], -2f / stereoProjectionMatrix[1, 1], (1f - stereoProjectionMatrix[0, 2]) / stereoProjectionMatrix[0, 0], (1f + stereoProjectionMatrix[1, 2]) / stereoProjectionMatrix[1, 1]);
				Vector4 vector3 = new Vector4(-2f / stereoProjectionMatrix2[0, 0], -2f / stereoProjectionMatrix2[1, 1], (1f - stereoProjectionMatrix2[0, 2]) / stereoProjectionMatrix2[0, 0], (1f + stereoProjectionMatrix2[1, 2]) / stereoProjectionMatrix2[1, 1]);
				aoMaterial.SetVector("_ProjInfoLeft", vector2);
				aoMaterial.SetVector("_ProjInfoRight", vector3);
			}
			aoMaterial.SetVector("_ProjInfo", vector);
			aoMaterial.SetMatrix("_ProjectionInv", inverse);
			aoMaterial.SetTexture("_Rand", rand);
			aoMaterial.SetFloat("_Radius", radius);
			aoMaterial.SetFloat("_Radius2", radius * radius);
			aoMaterial.SetFloat("_Intensity", intensity);
			aoMaterial.SetFloat("_BlurFilterDistance", blurFilterDistance);
			int width = source.width;
			int height = source.height;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width >> downsample, height >> downsample);
			Graphics.Blit(source, renderTexture, aoMaterial, 0);
			if (downsample > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, aoMaterial, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			for (int i = 0; i < blurIterations; i++)
			{
				aoMaterial.SetVector("_Axis", new Vector2(1f, 0f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, aoMaterial, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				aoMaterial.SetVector("_Axis", new Vector2(0f, 1f));
				renderTexture = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(temporary, renderTexture, aoMaterial, 1);
				RenderTexture.ReleaseTemporary(temporary);
			}
			aoMaterial.SetTexture("_AOTex", renderTexture);
			Graphics.Blit(source, destination, aoMaterial, 2);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
	}
	[AddComponentMenu("Image Effects/Rendering/Screen Space Ambient Occlusion")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class ScreenSpaceAmbientOcclusion : MonoBehaviour
	{
		public enum SSAOSamples
		{
			Low,
			Medium,
			High
		}

		[Range(0.05f, 1f)]
		public float m_Radius = 0.4f;

		public SSAOSamples m_SampleCount = SSAOSamples.Medium;

		[Range(0.5f, 4f)]
		public float m_OcclusionIntensity = 1.5f;

		[Range(0f, 4f)]
		public int m_Blur = 2;

		[Range(1f, 6f)]
		public int m_Downsampling = 2;

		[Range(0.2f, 2f)]
		public float m_OcclusionAttenuation = 1f;

		[Range(1E-05f, 0.5f)]
		public float m_MinZ = 0.01f;

		public Shader m_SSAOShader;

		private Material m_SSAOMaterial;

		public Texture2D m_RandomTexture;

		private bool m_Supported;

		private static Material CreateMaterial(Shader shader)
		{
			if (!shader)
			{
				return null;
			}
			Material material = new Material(shader);
			material.hideFlags = HideFlags.HideAndDontSave;
			return material;
		}

		private static void DestroyMaterial(Material mat)
		{
			if ((bool)mat)
			{
				UnityEngine.Object.DestroyImmediate(mat);
				mat = null;
			}
		}

		private void OnDisable()
		{
			DestroyMaterial(m_SSAOMaterial);
		}

		private void Start()
		{
			if (!SystemInfo.supportsImageEffects || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				m_Supported = false;
				base.enabled = false;
				return;
			}
			CreateMaterials();
			if (!m_SSAOMaterial || m_SSAOMaterial.passCount != 5)
			{
				m_Supported = false;
				base.enabled = false;
			}
			else
			{
				m_Supported = true;
			}
		}

		private void OnEnable()
		{
			GetComponent<Camera>().depthTextureMode |= DepthTextureMode.DepthNormals;
		}

		private void CreateMaterials()
		{
			if (!m_SSAOMaterial && m_SSAOShader.isSupported)
			{
				m_SSAOMaterial = CreateMaterial(m_SSAOShader);
				m_SSAOMaterial.SetTexture("_RandomTexture", m_RandomTexture);
			}
		}

		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!m_Supported || !m_SSAOShader.isSupported)
			{
				base.enabled = false;
				return;
			}
			CreateMaterials();
			m_Downsampling = Mathf.Clamp(m_Downsampling, 1, 6);
			m_Radius = Mathf.Clamp(m_Radius, 0.05f, 1f);
			m_MinZ = Mathf.Clamp(m_MinZ, 1E-05f, 0.5f);
			m_OcclusionIntensity = Mathf.Clamp(m_OcclusionIntensity, 0.5f, 4f);
			m_OcclusionAttenuation = Mathf.Clamp(m_OcclusionAttenuation, 0.2f, 2f);
			m_Blur = Mathf.Clamp(m_Blur, 0, 4);
			RenderTexture renderTexture = RenderTexture.GetTemporary(source.width / m_Downsampling, source.height / m_Downsampling, 0);
			float fieldOfView = GetComponent<Camera>().fieldOfView;
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			float num = Mathf.Tan(fieldOfView * ((float)Math.PI / 180f) * 0.5f) * farClipPlane;
			float x = num * GetComponent<Camera>().aspect;
			m_SSAOMaterial.SetVector("_FarCorner", new Vector3(x, num, farClipPlane));
			int num2;
			int num3;
			if ((bool)m_RandomTexture)
			{
				num2 = m_RandomTexture.width;
				num3 = m_RandomTexture.height;
			}
			else
			{
				num2 = 1;
				num3 = 1;
			}
			m_SSAOMaterial.SetVector("_NoiseScale", new Vector3((float)renderTexture.width / (float)num2, (float)renderTexture.height / (float)num3, 0f));
			m_SSAOMaterial.SetVector("_Params", new Vector4(m_Radius, m_MinZ, 1f / m_OcclusionAttenuation, m_OcclusionIntensity));
			bool flag = m_Blur > 0;
			Graphics.Blit((!flag) ? source : null, renderTexture, m_SSAOMaterial, (int)m_SampleCount);
			if (flag)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(source.width, source.height, 0);
				m_SSAOMaterial.SetVector("_TexelOffsetScale", new Vector4((float)m_Blur / (float)source.width, 0f, 0f, 0f));
				m_SSAOMaterial.SetTexture("_SSAO", renderTexture);
				Graphics.Blit(null, temporary, m_SSAOMaterial, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				RenderTexture temporary2 = RenderTexture.GetTemporary(source.width, source.height, 0);
				m_SSAOMaterial.SetVector("_TexelOffsetScale", new Vector4(0f, (float)m_Blur / (float)source.height, 0f, 0f));
				m_SSAOMaterial.SetTexture("_SSAO", temporary);
				Graphics.Blit(source, temporary2, m_SSAOMaterial, 3);
				RenderTexture.ReleaseTemporary(temporary);
				renderTexture = temporary2;
			}
			m_SSAOMaterial.SetTexture("_SSAO", renderTexture);
			Graphics.Blit(source, destination, m_SSAOMaterial, 4);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
	}
}
namespace UnityStandardAssets.CinematicEffects
{
	[AddComponentMenu("Image Effects/Rendering/Screen Space Reflection")]
	[ImageEffectAllowedInSceneView]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class ScreenSpaceReflection : MonoBehaviour
	{
		public enum SSRDebugMode
		{
			None,
			IncomingRadiance,
			SSRResult,
			FinalGlossyTerm,
			SSRMask,
			Roughness,
			BaseColor,
			SpecColor,
			Reflectivity,
			ReflectionProbeOnly,
			ReflectionProbeMinusSSR,
			SSRMinusReflectionProbe,
			NoGlossy,
			NegativeNoGlossy,
			MipLevel
		}

		public enum SSRResolution
		{
			FullResolution,
			HalfTraceFullResolve,
			HalfResolution
		}

		[Serializable]
		public struct SSRSettings
		{
			[AttributeUsage(AttributeTargets.Field)]
			public class LayoutAttribute : PropertyAttribute
			{
			}

			[Layout]
			public BasicSettings basicSettings;

			[Layout]
			public ReflectionSettings reflectionSettings;

			[Layout]
			public AdvancedSettings advancedSettings;

			[Layout]
			public DebugSettings debugSettings;

			private static readonly SSRSettings s_Performance = new SSRSettings
			{
				basicSettings = new BasicSettings
				{
					screenEdgeFading = 0f,
					maxDistance = 10f,
					fadeDistance = 10f,
					reflectionMultiplier = 1f,
					enableHDR = false,
					additiveReflection = false
				},
				reflectionSettings = new ReflectionSettings
				{
					maxSteps = 64,
					rayStepSize = 4,
					widthModifier = 0.5f,
					smoothFallbackThreshold = 0.4f,
					distanceBlur = 1f,
					fresnelFade = 0.2f,
					fresnelFadePower = 2f,
					smoothFallbackDistance = 0.05f
				},
				advancedSettings = new AdvancedSettings
				{
					useTemporalConfidence = false,
					temporalFilterStrength = 0f,
					treatBackfaceHitAsMiss = false,
					allowBackwardsRays = false,
					traceBehindObjects = true,
					highQualitySharpReflections = false,
					traceEverywhere = false,
					resolution = SSRResolution.HalfResolution,
					bilateralUpsample = false,
					improveCorners = false,
					reduceBanding = false,
					highlightSuppression = false
				},
				debugSettings = new DebugSettings
				{
					debugMode = SSRDebugMode.None
				}
			};

			private static readonly SSRSettings s_Default = new SSRSettings
			{
				basicSettings = new BasicSettings
				{
					screenEdgeFading = 0.03f,
					maxDistance = 100f,
					fadeDistance = 100f,
					reflectionMultiplier = 1f,
					enableHDR = true,
					additiveReflection = false
				},
				reflectionSettings = new ReflectionSettings
				{
					maxSteps = 128,
					rayStepSize = 3,
					widthModifier = 0.5f,
					smoothFallbackThreshold = 0.2f,
					distanceBlur = 1f,
					fresnelFade = 0.2f,
					fresnelFadePower = 2f,
					smoothFallbackDistance = 0.05f
				},
				advancedSettings = new AdvancedSettings
				{
					useTemporalConfidence = true,
					temporalFilterStrength = 0.7f,
					treatBackfaceHitAsMiss = false,
					allowBackwardsRays = false,
					traceBehindObjects = true,
					highQualitySharpReflections = true,
					traceEverywhere = true,
					resolution = SSRResolution.HalfTraceFullResolve,
					bilateralUpsample = true,
					improveCorners = true,
					reduceBanding = true,
					highlightSuppression = false
				},
				debugSettings = new DebugSettings
				{
					debugMode = SSRDebugMode.None
				}
			};

			private static readonly SSRSettings s_HighQuality = new SSRSettings
			{
				basicSettings = new BasicSettings
				{
					screenEdgeFading = 0.03f,
					maxDistance = 100f,
					fadeDistance = 100f,
					reflectionMultiplier = 1f,
					enableHDR = true,
					additiveReflection = false
				},
				reflectionSettings = new ReflectionSettings
				{
					maxSteps = 512,
					rayStepSize = 1,
					widthModifier = 0.5f,
					smoothFallbackThreshold = 0.2f,
					distanceBlur = 1f,
					fresnelFade = 0.2f,
					fresnelFadePower = 2f,
					smoothFallbackDistance = 0.05f
				},
				advancedSettings = new AdvancedSettings
				{
					useTemporalConfidence = true,
					temporalFilterStrength = 0.7f,
					treatBackfaceHitAsMiss = false,
					allowBackwardsRays = false,
					traceBehindObjects = true,
					highQualitySharpReflections = true,
					traceEverywhere = true,
					resolution = SSRResolution.HalfTraceFullResolve,
					bilateralUpsample = true,
					improveCorners = true,
					reduceBanding = true,
					highlightSuppression = false
				},
				debugSettings = new DebugSettings
				{
					debugMode = SSRDebugMode.None
				}
			};

			public static SSRSettings performanceSettings => s_Performance;

			public static SSRSettings defaultSettings => s_Default;

			public static SSRSettings highQualitySettings => s_HighQuality;
		}

		[Serializable]
		public struct BasicSettings
		{
			[Tooltip("Nonphysical multiplier for the SSR reflections. 1.0 is physically based.")]
			[Range(0f, 2f)]
			public float reflectionMultiplier;

			[Tooltip("Maximum reflection distance in world units.")]
			[Range(0.5f, 1000f)]
			public float maxDistance;

			[Tooltip("How far away from the maxDistance to begin fading SSR.")]
			[Range(0f, 1000f)]
			public float fadeDistance;

			[Range(0f, 1f)]
			[Tooltip("Higher = fade out SSRR near the edge of the screen so that reflections don't pop under camera motion.")]
			public float screenEdgeFading;

			[Tooltip("Enable for better reflections of very bright objects at a performance cost")]
			public bool enableHDR;

			[Tooltip("Add reflections on top of existing ones. Not physically correct.")]
			public bool additiveReflection;
		}

		[Serializable]
		public struct ReflectionSettings
		{
			[Tooltip("Max raytracing length.")]
			[Range(16f, 2048f)]
			public int maxSteps;

			[Range(0f, 4f)]
			[Tooltip("Log base 2 of ray tracing coarse step size. Higher traces farther, lower gives better quality silhouettes.")]
			public int rayStepSize;

			[Range(0.01f, 10f)]
			[Tooltip("Typical thickness of columns, walls, furniture, and other objects that reflection rays might pass behind.")]
			public float widthModifier;

			[Tooltip("Increase if reflections flicker on very rough surfaces.")]
			[Range(0f, 1f)]
			public float smoothFallbackThreshold;

			[Range(0f, 0.2f)]
			[Tooltip("Start falling back to non-SSR value solution at smoothFallbackThreshold - smoothFallbackDistance, with full fallback occuring at smoothFallbackThreshold.")]
			public float smoothFallbackDistance;

			[Tooltip("Amplify Fresnel fade out. Increase if floor reflections look good close to the surface and bad farther 'under' the floor.")]
			[Range(0f, 1f)]
			public float fresnelFade;

			[Tooltip("Higher values correspond to a faster Fresnel fade as the reflection changes from the grazing angle.")]
			[Range(0.1f, 10f)]
			public float fresnelFadePower;

			[Tooltip("Controls how blurry reflections get as objects are further from the camera. 0 is constant blur no matter trace distance or distance from camera. 1 fully takes into account both factors.")]
			[Range(0f, 1f)]
			public float distanceBlur;
		}

		[Serializable]
		public struct AdvancedSettings
		{
			[Range(0f, 0.99f)]
			[Tooltip("Increase to decrease flicker in scenes; decrease to prevent ghosting (especially in dynamic scenes). 0 gives maximum performance.")]
			public float temporalFilterStrength;

			[Tooltip("Enable to limit ghosting from applying the temporal filter.")]
			public bool useTemporalConfidence;

			[Tooltip("Enable to allow rays to pass behind objects. This can lead to more screen-space reflections, but the reflections are more likely to be wrong.")]
			public bool traceBehindObjects;

			[Tooltip("Enable to increase quality of the sharpest reflections (through filtering), at a performance cost.")]
			public bool highQualitySharpReflections;

			[Tooltip("Improves quality in scenes with varying smoothness, at a potential performance cost.")]
			public bool traceEverywhere;

			[Tooltip("Enable to force more surfaces to use reflection probes if you see streaks on the sides of objects or bad reflections of their backs.")]
			public bool treatBackfaceHitAsMiss;

			[Tooltip("Enable for a performance gain in scenes where most glossy objects are horizontal, like floors, water, and tables. Leave on for scenes with glossy vertical objects.")]
			public bool allowBackwardsRays;

			[Tooltip("Improve visual fidelity of reflections on rough surfaces near corners in the scene, at the cost of a small amount of performance.")]
			public bool improveCorners;

			[Tooltip("Half resolution SSRR is much faster, but less accurate. Quality can be reclaimed for some performance by doing the resolve at full resolution.")]
			public SSRResolution resolution;

			[Tooltip("Drastically improves reflection reconstruction quality at the expense of some performance.")]
			public bool bilateralUpsample;

			[Tooltip("Improve visual fidelity of mirror reflections at the cost of a small amount of performance.")]
			public bool reduceBanding;

			[Tooltip("Enable to limit the effect a few bright pixels can have on rougher surfaces")]
			public bool highlightSuppression;
		}

		[Serializable]
		public struct DebugSettings
		{
			[Tooltip("Various Debug Visualizations")]
			public SSRDebugMode debugMode;
		}

		private enum PassIndex
		{
			RayTraceStep1,
			RayTraceStep2,
			RayTraceStep4,
			RayTraceStep8,
			RayTraceStep16,
			CompositeFinal,
			Blur,
			CompositeSSR,
			Blit,
			EdgeGeneration,
			MinMipGeneration,
			HitPointToReflections,
			BilateralKeyPack,
			BlitDepthAsCSZ,
			TemporalFilter,
			AverageRayDistanceGeneration,
			PoissonBlur
		}

		[SerializeField]
		public SSRSettings settings = SSRSettings.defaultSettings;

		[Tooltip("Enable to try and bypass expensive bilateral upsampling away from edges. There is a slight performance hit for generating the edge buffers, but a potentially high performance savings from bypassing bilateral upsampling where it is unneeded. Test on your target platforms to see if performance improves.")]
		private bool useEdgeDetector;

		[Range(-4f, 4f)]
		private float mipBias;

		private bool useOcclusion = true;

		private bool fullResolutionFiltering;

		private bool fallbackToSky;

		private bool computeAverageRayDistance;

		private bool m_HasInformationFromPreviousFrame;

		private Matrix4x4 m_PreviousWorldToCameraMatrix;

		private RenderTexture m_PreviousDepthBuffer;

		private RenderTexture m_PreviousHitBuffer;

		private RenderTexture m_PreviousReflectionBuffer;

		[NonSerialized]
		private RenderTextureUtility m_RTU = new RenderTextureUtility();

		[SerializeField]
		private Shader m_Shader;

		private Material m_Material;

		public Shader shader
		{
			get
			{
				if (m_Shader == null)
				{
					m_Shader = Shader.Find("Hidden/ScreenSpaceReflection");
				}
				return m_Shader;
			}
		}

		public Material material
		{
			get
			{
				if (m_Material == null)
				{
					m_Material = ImageEffectHelper.CheckShaderAndCreateMaterial(shader);
				}
				return m_Material;
			}
		}

		private void OnEnable()
		{
			if (!ImageEffectHelper.IsSupported(shader, needDepth: false, needHdr: true, this))
			{
				base.enabled = false;
			}
			else
			{
				GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
		}

		private void OnDisable()
		{
			if ((bool)m_Material)
			{
				UnityEngine.Object.DestroyImmediate(m_Material);
			}
			if ((bool)m_PreviousDepthBuffer)
			{
				UnityEngine.Object.DestroyImmediate(m_PreviousDepthBuffer);
			}
			if ((bool)m_PreviousHitBuffer)
			{
				UnityEngine.Object.DestroyImmediate(m_PreviousHitBuffer);
			}
			if ((bool)m_PreviousReflectionBuffer)
			{
				UnityEngine.Object.DestroyImmediate(m_PreviousReflectionBuffer);
			}
			m_Material = null;
			m_PreviousDepthBuffer = null;
			m_PreviousHitBuffer = null;
			m_PreviousReflectionBuffer = null;
		}

		private void PreparePreviousBuffers(int w, int h)
		{
			if (m_PreviousDepthBuffer != null && (m_PreviousDepthBuffer.width != w || m_PreviousDepthBuffer.height != h))
			{
				UnityEngine.Object.DestroyImmediate(m_PreviousDepthBuffer);
				UnityEngine.Object.DestroyImmediate(m_PreviousHitBuffer);
				UnityEngine.Object.DestroyImmediate(m_PreviousReflectionBuffer);
				m_PreviousDepthBuffer = null;
				m_PreviousHitBuffer = null;
				m_PreviousReflectionBuffer = null;
			}
			if (m_PreviousDepthBuffer == null)
			{
				m_PreviousDepthBuffer = new RenderTexture(w, h, 0, RenderTextureFormat.RFloat);
				m_PreviousHitBuffer = new RenderTexture(w, h, 0, RenderTextureFormat.ARGBHalf);
				m_PreviousReflectionBuffer = new RenderTexture(w, h, 0, RenderTextureFormat.ARGBHalf);
			}
		}

		[ImageEffectOpaque]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (material == null)
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (m_HasInformationFromPreviousFrame)
			{
				m_HasInformationFromPreviousFrame = m_PreviousDepthBuffer != null && source.width == m_PreviousDepthBuffer.width && source.height == m_PreviousDepthBuffer.height;
			}
			bool flag = m_HasInformationFromPreviousFrame && (double)settings.advancedSettings.temporalFilterStrength > 0.0;
			m_HasInformationFromPreviousFrame = false;
			if (Camera.current.actualRenderingPath != RenderingPath.DeferredShading)
			{
				Graphics.Blit(source, destination);
				return;
			}
			int width = source.width;
			int height = source.height;
			RenderTexture temporaryRenderTexture = m_RTU.GetTemporaryRenderTexture(width, height, 0, RenderTextureFormat.ARGB32);
			temporaryRenderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, temporaryRenderTexture, material, 12);
			material.SetTexture("_NormalAndRoughnessTexture", temporaryRenderTexture);
			float num = source.width;
			float num2 = source.height;
			Vector2 vector = new Vector2(num / (float)width, num2 / (float)height);
			int num3 = ((settings.advancedSettings.resolution == SSRResolution.FullResolution) ? 1 : 2);
			width /= num3;
			height /= num3;
			material.SetVector("_SourceToTempUV", new Vector4(vector.x, vector.y, 1f / vector.x, 1f / vector.y));
			Matrix4x4 projectionMatrix = GetComponent<Camera>().projectionMatrix;
			Vector4 vector2 = new Vector4(-2f / (num * projectionMatrix[0]), -2f / (num2 * projectionMatrix[5]), (1f - projectionMatrix[2]) / projectionMatrix[0], (1f + projectionMatrix[6]) / projectionMatrix[5]);
			float value = num / (-2f * (float)Math.Tan((double)GetComponent<Camera>().fieldOfView / 180.0 * Math.PI * 0.5));
			material.SetFloat("_PixelsPerMeterAtOneMeter", value);
			float num4 = num / 2f;
			float num5 = num2 / 2f;
			Matrix4x4 matrix4x = default(Matrix4x4);
			matrix4x.SetRow(0, new Vector4(num4, 0f, 0f, num4));
			matrix4x.SetRow(1, new Vector4(0f, num5, 0f, num5));
			matrix4x.SetRow(2, new Vector4(0f, 0f, 1f, 0f));
			matrix4x.SetRow(3, new Vector4(0f, 0f, 0f, 1f));
			Matrix4x4 matrix = matrix4x * projectionMatrix;
			material.SetVector("_ScreenSize", new Vector2(num, num2));
			material.SetVector("_ReflectionBufferSize", new Vector2(width, height));
			Vector2 vector3 = new Vector2((float)(1.0 / (double)num), (float)(1.0 / (double)num2));
			Matrix4x4 worldToCameraMatrix = GetComponent<Camera>().worldToCameraMatrix;
			Matrix4x4 inverse = GetComponent<Camera>().worldToCameraMatrix.inverse;
			material.SetVector("_InvScreenSize", vector3);
			material.SetVector("_ProjInfo", vector2);
			material.SetMatrix("_ProjectToPixelMatrix", matrix);
			material.SetMatrix("_WorldToCameraMatrix", worldToCameraMatrix);
			material.SetMatrix("_CameraToWorldMatrix", inverse);
			material.SetInt("_EnableRefine", settings.advancedSettings.reduceBanding ? 1 : 0);
			material.SetInt("_AdditiveReflection", settings.basicSettings.additiveReflection ? 1 : 0);
			material.SetInt("_ImproveCorners", settings.advancedSettings.improveCorners ? 1 : 0);
			material.SetFloat("_ScreenEdgeFading", settings.basicSettings.screenEdgeFading);
			material.SetFloat("_MipBias", mipBias);
			material.SetInt("_UseOcclusion", useOcclusion ? 1 : 0);
			material.SetInt("_BilateralUpsampling", settings.advancedSettings.bilateralUpsample ? 1 : 0);
			material.SetInt("_FallbackToSky", fallbackToSky ? 1 : 0);
			material.SetInt("_TreatBackfaceHitAsMiss", settings.advancedSettings.treatBackfaceHitAsMiss ? 1 : 0);
			material.SetInt("_AllowBackwardsRays", settings.advancedSettings.allowBackwardsRays ? 1 : 0);
			material.SetInt("_TraceEverywhere", settings.advancedSettings.traceEverywhere ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			float nearClipPlane = GetComponent<Camera>().nearClipPlane;
			Vector3 vector4 = ((!float.IsPositiveInfinity(farClipPlane)) ? new Vector3(nearClipPlane * farClipPlane, nearClipPlane - farClipPlane, farClipPlane) : new Vector3(nearClipPlane, -1f, 1f));
			material.SetVector("_CameraClipInfo", vector4);
			material.SetFloat("_MaxRayTraceDistance", settings.basicSettings.maxDistance);
			material.SetFloat("_FadeDistance", settings.basicSettings.fadeDistance);
			material.SetFloat("_LayerThickness", settings.reflectionSettings.widthModifier);
			RenderTextureFormat format = (settings.basicSettings.enableHDR ? RenderTextureFormat.ARGBHalf : RenderTextureFormat.ARGB32);
			RenderTexture[] array = new RenderTexture[5];
			for (int i = 0; i < 5; i++)
			{
				if (fullResolutionFiltering)
				{
					array[i] = m_RTU.GetTemporaryRenderTexture(width, height, 0, format);
				}
				else
				{
					array[i] = m_RTU.GetTemporaryRenderTexture(width >> i, height >> i, 0, format);
				}
				array[i].filterMode = ((!settings.advancedSettings.bilateralUpsample) ? FilterMode.Bilinear : FilterMode.Point);
			}
			material.SetInt("_EnableSSR", 1);
			material.SetInt("_DebugMode", (int)settings.debugSettings.debugMode);
			material.SetInt("_TraceBehindObjects", settings.advancedSettings.traceBehindObjects ? 1 : 0);
			material.SetInt("_MaxSteps", settings.reflectionSettings.maxSteps);
			RenderTexture temporaryRenderTexture2 = m_RTU.GetTemporaryRenderTexture(width, height);
			int pass = Mathf.Clamp(settings.reflectionSettings.rayStepSize, 0, 4);
			Graphics.Blit(source, temporaryRenderTexture2, material, pass);
			material.SetTexture("_HitPointTexture", temporaryRenderTexture2);
			Graphics.Blit(source, array[0], material, 11);
			material.SetTexture("_ReflectionTexture0", array[0]);
			material.SetInt("_FullResolutionFiltering", fullResolutionFiltering ? 1 : 0);
			material.SetFloat("_MaxRoughness", 1f - settings.reflectionSettings.smoothFallbackThreshold);
			material.SetFloat("_RoughnessFalloffRange", settings.reflectionSettings.smoothFallbackDistance);
			material.SetFloat("_SSRMultiplier", settings.basicSettings.reflectionMultiplier);
			RenderTexture[] array2 = new RenderTexture[5];
			if (settings.advancedSettings.bilateralUpsample && useEdgeDetector)
			{
				array2[0] = m_RTU.GetTemporaryRenderTexture(width, height);
				Graphics.Blit(source, array2[0], material, 9);
				for (int j = 1; j < 5; j++)
				{
					array2[j] = m_RTU.GetTemporaryRenderTexture(width >> j, height >> j);
					material.SetInt("_LastMip", j - 1);
					Graphics.Blit(array2[j - 1], array2[j], material, 10);
				}
			}
			if (settings.advancedSettings.highQualitySharpReflections)
			{
				RenderTexture temporaryRenderTexture3 = m_RTU.GetTemporaryRenderTexture(array[0].width, array[0].height, 0, array[0].format);
				temporaryRenderTexture3.filterMode = array[0].filterMode;
				array[0].filterMode = FilterMode.Bilinear;
				Graphics.Blit(array[0], temporaryRenderTexture3, material, 16);
				m_RTU.ReleaseTemporaryRenderTexture(array[0]);
				array[0] = temporaryRenderTexture3;
				material.SetTexture("_ReflectionTexture0", array[0]);
			}
			for (int k = 1; k < 5; k++)
			{
				RenderTexture renderTexture = array[k - 1];
				RenderTexture temporaryRenderTexture4;
				if (fullResolutionFiltering)
				{
					temporaryRenderTexture4 = m_RTU.GetTemporaryRenderTexture(width, height, 0, format);
				}
				else
				{
					int num6 = k;
					temporaryRenderTexture4 = m_RTU.GetTemporaryRenderTexture(width >> num6, height >> k - 1, 0, format);
				}
				for (int l = 0; l < ((!fullResolutionFiltering) ? 1 : (k * k)); l++)
				{
					material.SetVector("_Axis", new Vector4(1f, 0f, 0f, 0f));
					material.SetFloat("_CurrentMipLevel", (float)k - 1f);
					Graphics.Blit(renderTexture, temporaryRenderTexture4, material, 6);
					material.SetVector("_Axis", new Vector4(0f, 1f, 0f, 0f));
					renderTexture = array[k];
					Graphics.Blit(temporaryRenderTexture4, renderTexture, material, 6);
				}
				material.SetTexture("_ReflectionTexture" + k, array[k]);
				m_RTU.ReleaseTemporaryRenderTexture(temporaryRenderTexture4);
			}
			if (settings.advancedSettings.bilateralUpsample && useEdgeDetector)
			{
				for (int m = 0; m < 5; m++)
				{
					material.SetTexture("_EdgeTexture" + m, array2[m]);
				}
			}
			material.SetInt("_UseEdgeDetector", useEdgeDetector ? 1 : 0);
			RenderTexture temporaryRenderTexture5 = m_RTU.GetTemporaryRenderTexture(source.width, source.height, 0, RenderTextureFormat.RHalf);
			if (computeAverageRayDistance)
			{
				Graphics.Blit(source, temporaryRenderTexture5, material, 15);
			}
			material.SetInt("_UseAverageRayDistance", computeAverageRayDistance ? 1 : 0);
			material.SetTexture("_AverageRayDistanceBuffer", temporaryRenderTexture5);
			bool flag2 = settings.advancedSettings.resolution == SSRResolution.HalfTraceFullResolve;
			RenderTexture temporaryRenderTexture6 = m_RTU.GetTemporaryRenderTexture((!flag2) ? width : source.width, (!flag2) ? height : source.height, 0, format);
			material.SetFloat("_FresnelFade", settings.reflectionSettings.fresnelFade);
			material.SetFloat("_FresnelFadePower", settings.reflectionSettings.fresnelFadePower);
			material.SetFloat("_DistanceBlur", settings.reflectionSettings.distanceBlur);
			material.SetInt("_HalfResolution", (settings.advancedSettings.resolution != SSRResolution.FullResolution) ? 1 : 0);
			material.SetInt("_HighlightSuppression", settings.advancedSettings.highlightSuppression ? 1 : 0);
			Graphics.Blit(array[0], temporaryRenderTexture6, material, 7);
			material.SetTexture("_FinalReflectionTexture", temporaryRenderTexture6);
			RenderTexture temporaryRenderTexture7 = m_RTU.GetTemporaryRenderTexture((!flag2) ? width : source.width, (!flag2) ? height : source.height, 0, format);
			if (flag)
			{
				material.SetInt("_UseTemporalConfidence", settings.advancedSettings.useTemporalConfidence ? 1 : 0);
				material.SetFloat("_TemporalAlpha", settings.advancedSettings.temporalFilterStrength);
				material.SetMatrix("_CurrentCameraToPreviousCamera", m_PreviousWorldToCameraMatrix * inverse);
				material.SetTexture("_PreviousReflectionTexture", m_PreviousReflectionBuffer);
				material.SetTexture("_PreviousCSZBuffer", m_PreviousDepthBuffer);
				Graphics.Blit(source, temporaryRenderTexture7, material, 14);
				material.SetTexture("_FinalReflectionTexture", temporaryRenderTexture7);
			}
			if ((double)settings.advancedSettings.temporalFilterStrength > 0.0)
			{
				m_PreviousWorldToCameraMatrix = worldToCameraMatrix;
				PreparePreviousBuffers(source.width, source.height);
				Graphics.Blit(source, m_PreviousDepthBuffer, material, 13);
				Graphics.Blit(temporaryRenderTexture2, m_PreviousHitBuffer);
				Graphics.Blit((!flag) ? temporaryRenderTexture6 : temporaryRenderTexture7, m_PreviousReflectionBuffer);
				m_HasInformationFromPreviousFrame = true;
			}
			Graphics.Blit(source, destination, material, 5);
			m_RTU.ReleaseAllTemporaryRenderTextures();
		}
	}
}
namespace UnityStandardAssets.ImageEffects
{
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Sepia Tone")]
	public class SepiaTone : ImageEffectBase
	{
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			Graphics.Blit(source, destination, base.material);
		}
	}
	[AddComponentMenu("Image Effects/Rendering/Sun Shafts")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class SunShafts : PostEffectsBase
	{
		public enum SunShaftsResolution
		{
			Low,
			Normal,
			High
		}

		public enum ShaftsScreenBlendMode
		{
			Screen,
			Add
		}

		public SunShaftsResolution resolution = SunShaftsResolution.Normal;

		public ShaftsScreenBlendMode screenBlendMode;

		public Transform sunTransform;

		public int radialBlurIterations = 2;

		public Color sunColor = Color.white;

		public Color sunThreshold = new Color(0.87f, 0.74f, 0.65f);

		public float sunShaftBlurRadius = 2.5f;

		public float sunShaftIntensity = 1.15f;

		public float maxRadius = 0.75f;

		public bool useDepthTexture = true;

		public Shader sunShaftsShader;

		private Material sunShaftsMaterial;

		public Shader simpleClearShader;

		private Material simpleClearMaterial;

		public override bool CheckResources()
		{
			CheckSupport(useDepthTexture);
			sunShaftsMaterial = CheckShaderAndCreateMaterial(sunShaftsShader, sunShaftsMaterial);
			simpleClearMaterial = CheckShaderAndCreateMaterial(simpleClearShader, simpleClearMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (useDepthTexture)
			{
				GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 4;
			if (resolution == SunShaftsResolution.Normal)
			{
				num = 2;
			}
			else if (resolution == SunShaftsResolution.High)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 0.5f;
			vector = ((!sunTransform) ? new Vector3(0.5f, 0.5f, 0f) : GetComponent<Camera>().WorldToViewportPoint(sunTransform.position));
			int width = source.width / num;
			int height = source.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			sunShaftsMaterial.SetVector("_BlurRadius4", new Vector4(1f, 1f, 0f, 0f) * sunShaftBlurRadius);
			sunShaftsMaterial.SetVector("_SunPosition", new Vector4(vector.x, vector.y, vector.z, maxRadius));
			sunShaftsMaterial.SetVector("_SunThreshold", sunThreshold);
			if (!useDepthTexture)
			{
				RenderTextureFormat format = ((!GetComponent<Camera>().hdr) ? RenderTextureFormat.Default : RenderTextureFormat.DefaultHDR);
				RenderTexture renderTexture = (RenderTexture.active = RenderTexture.GetTemporary(source.width, source.height, 0, format));
				GL.ClearWithSkybox(clearDepth: false, GetComponent<Camera>());
				sunShaftsMaterial.SetTexture("_Skybox", renderTexture);
				Graphics.Blit(source, temporary, sunShaftsMaterial, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
			else
			{
				Graphics.Blit(source, temporary, sunShaftsMaterial, 2);
			}
			DrawBorder(temporary, simpleClearMaterial);
			radialBlurIterations = Mathf.Clamp(radialBlurIterations, 1, 4);
			float num2 = sunShaftBlurRadius * 0.0013020834f;
			sunShaftsMaterial.SetVector("_BlurRadius4", new Vector4(num2, num2, 0f, 0f));
			sunShaftsMaterial.SetVector("_SunPosition", new Vector4(vector.x, vector.y, vector.z, maxRadius));
			for (int i = 0; i < radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, sunShaftsMaterial, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = sunShaftBlurRadius * (((float)i * 2f + 1f) * 6f) / 768f;
				sunShaftsMaterial.SetVector("_BlurRadius4", new Vector4(num2, num2, 0f, 0f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, sunShaftsMaterial, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = sunShaftBlurRadius * (((float)i * 2f + 2f) * 6f) / 768f;
				sunShaftsMaterial.SetVector("_BlurRadius4", new Vector4(num2, num2, 0f, 0f));
			}
			if (vector.z >= 0f)
			{
				sunShaftsMaterial.SetVector("_SunColor", new Vector4(sunColor.r, sunColor.g, sunColor.b, sunColor.a) * sunShaftIntensity);
			}
			else
			{
				sunShaftsMaterial.SetVector("_SunColor", Vector4.zero);
			}
			sunShaftsMaterial.SetTexture("_ColorBuffer", temporary);
			Graphics.Blit(source, destination, sunShaftsMaterial, (screenBlendMode != ShaftsScreenBlendMode.Screen) ? 4 : 0);
			RenderTexture.ReleaseTemporary(temporary);
		}
	}
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Tilt Shift (Lens Blur)")]
	internal class TiltShift : PostEffectsBase
	{
		public enum TiltShiftMode
		{
			TiltShiftMode,
			IrisMode
		}

		public enum TiltShiftQuality
		{
			Preview,
			Normal,
			High
		}

		public TiltShiftMode mode;

		public TiltShiftQuality quality = TiltShiftQuality.Normal;

		[Range(0f, 15f)]
		public float blurArea = 1f;

		[Range(0f, 25f)]
		public float maxBlurSize = 5f;

		[Range(0f, 1f)]
		public int downsample;

		public Shader tiltShiftShader;

		private Material tiltShiftMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			tiltShiftMaterial = CheckShaderAndCreateMaterial(tiltShiftShader, tiltShiftMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			tiltShiftMaterial.SetFloat("_BlurSize", (!(maxBlurSize < 0f)) ? maxBlurSize : 0f);
			tiltShiftMaterial.SetFloat("_BlurArea", blurArea);
			source.filterMode = FilterMode.Bilinear;
			RenderTexture renderTexture = destination;
			if ((float)downsample > 0f)
			{
				renderTexture = RenderTexture.GetTemporary(source.width >> downsample, source.height >> downsample, 0, source.format);
				renderTexture.filterMode = FilterMode.Bilinear;
			}
			int num = (int)quality;
			num *= 2;
			Graphics.Blit(source, renderTexture, tiltShiftMaterial, (mode != TiltShiftMode.TiltShiftMode) ? (num + 1) : num);
			if (downsample > 0)
			{
				tiltShiftMaterial.SetTexture("_Blurred", renderTexture);
				Graphics.Blit(source, destination, tiltShiftMaterial, 6);
			}
			if (renderTexture != destination)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}
	}
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	[ImageEffectAllowedInSceneView]
	[AddComponentMenu("Image Effects/Color Adjustments/Tonemapping")]
	public class Tonemapping : PostEffectsBase
	{
		public enum TonemapperType
		{
			SimpleReinhard,
			UserCurve,
			Hable,
			Photographic,
			OptimizedHejiDawson,
			AdaptiveReinhard,
			AdaptiveReinhardAutoWhite
		}

		public enum AdaptiveTexSize
		{
			Square16 = 0x10,
			Square32 = 0x20,
			Square64 = 0x40,
			Square128 = 0x80,
			Square256 = 0x100,
			Square512 = 0x200,
			Square1024 = 0x400
		}

		public TonemapperType type = TonemapperType.Photographic;

		public AdaptiveTexSize adaptiveTextureSize = AdaptiveTexSize.Square256;

		public AnimationCurve remapCurve;

		private Texture2D curveTex;

		public float exposureAdjustment = 1.5f;

		public float middleGrey = 0.4f;

		public float white = 2f;

		public float adaptionSpeed = 1.5f;

		public Shader tonemapper;

		public bool validRenderTextureFormat = true;

		private Material tonemapMaterial;

		private RenderTexture rt;

		private RenderTextureFormat rtFormat = RenderTextureFormat.ARGBHalf;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false, needHdr: true);
			tonemapMaterial = CheckShaderAndCreateMaterial(tonemapper, tonemapMaterial);
			if (!curveTex && type == TonemapperType.UserCurve)
			{
				curveTex = new Texture2D(256, 1, TextureFormat.ARGB32, mipmap: false, linear: true);
				curveTex.filterMode = FilterMode.Bilinear;
				curveTex.wrapMode = TextureWrapMode.Clamp;
				curveTex.hideFlags = HideFlags.DontSave;
			}
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		public float UpdateCurve()
		{
			float num = 1f;
			if (remapCurve.keys.Length < 1)
			{
				remapCurve = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(2f, 1f));
			}
			if (remapCurve != null)
			{
				if (remapCurve.length > 0)
				{
					num = remapCurve[remapCurve.length - 1].time;
				}
				for (float num2 = 0f; num2 <= 1f; num2 += 0.003921569f)
				{
					float num3 = remapCurve.Evaluate(num2 * 1f * num);
					curveTex.SetPixel((int)Mathf.Floor(num2 * 255f), 0, new Color(num3, num3, num3));
				}
				curveTex.Apply();
			}
			return 1f / num;
		}

		private void OnDisable()
		{
			if ((bool)rt)
			{
				UnityEngine.Object.DestroyImmediate(rt);
				rt = null;
			}
			if ((bool)tonemapMaterial)
			{
				UnityEngine.Object.DestroyImmediate(tonemapMaterial);
				tonemapMaterial = null;
			}
			if ((bool)curveTex)
			{
				UnityEngine.Object.DestroyImmediate(curveTex);
				curveTex = null;
			}
		}

		private bool CreateInternalRenderTexture()
		{
			if ((bool)rt)
			{
				return false;
			}
			rtFormat = ((!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGHalf)) ? RenderTextureFormat.ARGBHalf : RenderTextureFormat.RGHalf);
			rt = new RenderTexture(1, 1, 0, rtFormat);
			rt.hideFlags = HideFlags.DontSave;
			return true;
		}

		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			exposureAdjustment = ((!(exposureAdjustment < 0.001f)) ? exposureAdjustment : 0.001f);
			if (type == TonemapperType.UserCurve)
			{
				float value = UpdateCurve();
				tonemapMaterial.SetFloat("_RangeScale", value);
				tonemapMaterial.SetTexture("_Curve", curveTex);
				Graphics.Blit(source, destination, tonemapMaterial, 4);
				return;
			}
			if (type == TonemapperType.SimpleReinhard)
			{
				tonemapMaterial.SetFloat("_ExposureAdjustment", exposureAdjustment);
				Graphics.Blit(source, destination, tonemapMaterial, 6);
				return;
			}
			if (type == TonemapperType.Hable)
			{
				tonemapMaterial.SetFloat("_ExposureAdjustment", exposureAdjustment);
				Graphics.Blit(source, destination, tonemapMaterial, 5);
				return;
			}
			if (type == TonemapperType.Photographic)
			{
				tonemapMaterial.SetFloat("_ExposureAdjustment", exposureAdjustment);
				Graphics.Blit(source, destination, tonemapMaterial, 8);
				return;
			}
			if (type == TonemapperType.OptimizedHejiDawson)
			{
				tonemapMaterial.SetFloat("_ExposureAdjustment", 0.5f * exposureAdjustment);
				Graphics.Blit(source, destination, tonemapMaterial, 7);
				return;
			}
			bool flag = CreateInternalRenderTexture();
			RenderTexture temporary = RenderTexture.GetTemporary((int)adaptiveTextureSize, (int)adaptiveTextureSize, 0, rtFormat);
			Graphics.Blit(source, temporary);
			int num = (int)Mathf.Log((float)temporary.width * 1f, 2f);
			int num2 = 2;
			RenderTexture[] array = new RenderTexture[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = RenderTexture.GetTemporary(temporary.width / num2, temporary.width / num2, 0, rtFormat);
				num2 *= 2;
			}
			RenderTexture source2 = array[num - 1];
			Graphics.Blit(temporary, array[0], tonemapMaterial, 1);
			if (type == TonemapperType.AdaptiveReinhardAutoWhite)
			{
				for (int j = 0; j < num - 1; j++)
				{
					Graphics.Blit(array[j], array[j + 1], tonemapMaterial, 9);
					source2 = array[j + 1];
				}
			}
			else if (type == TonemapperType.AdaptiveReinhard)
			{
				for (int k = 0; k < num - 1; k++)
				{
					Graphics.Blit(array[k], array[k + 1]);
					source2 = array[k + 1];
				}
			}
			adaptionSpeed = ((!(adaptionSpeed < 0.001f)) ? adaptionSpeed : 0.001f);
			tonemapMaterial.SetFloat("_AdaptionSpeed", adaptionSpeed);
			rt.MarkRestoreExpected();
			Graphics.Blit(source2, rt, tonemapMaterial, (!flag) ? 2 : 3);
			middleGrey = ((!(middleGrey < 0.001f)) ? middleGrey : 0.001f);
			tonemapMaterial.SetVector("_HdrParams", new Vector4(middleGrey, middleGrey, middleGrey, white * white));
			tonemapMaterial.SetTexture("_SmallTex", rt);
			if (type == TonemapperType.AdaptiveReinhard)
			{
				Graphics.Blit(source, destination, tonemapMaterial, 0);
			}
			else if (type == TonemapperType.AdaptiveReinhardAutoWhite)
			{
				Graphics.Blit(source, destination, tonemapMaterial, 10);
			}
			else
			{
				Debug.LogError("No valid adaptive tonemapper type found!");
				Graphics.Blit(source, destination);
			}
			for (int l = 0; l < num; l++)
			{
				RenderTexture.ReleaseTemporary(array[l]);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}
	}
	internal class Triangles
	{
		private static Mesh[] meshes;

		private static int currentTris;

		private static bool HasMeshes()
		{
			if (meshes == null)
			{
				return false;
			}
			for (int i = 0; i < meshes.Length; i++)
			{
				if (null == meshes[i])
				{
					return false;
				}
			}
			return true;
		}

		private static void Cleanup()
		{
			if (meshes == null)
			{
				return;
			}
			for (int i = 0; i < meshes.Length; i++)
			{
				if (null != meshes[i])
				{
					UnityEngine.Object.DestroyImmediate(meshes[i]);
					meshes[i] = null;
				}
			}
			meshes = null;
		}

		private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			if (HasMeshes() && currentTris == totalWidth * totalHeight)
			{
				return meshes;
			}
			int num = 21666;
			int num2 = (currentTris = totalWidth * totalHeight);
			int num3 = Mathf.CeilToInt(1f * (float)num2 / (1f * (float)num));
			meshes = new Mesh[num3];
			int num4 = 0;
			int num5 = 0;
			for (num4 = 0; num4 < num2; num4 += num)
			{
				int triCount = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
				meshes[num5] = GetMesh(triCount, num4, totalWidth, totalHeight);
				num5++;
			}
			return meshes;
		}

		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			Mesh mesh = new Mesh();
			mesh.hideFlags = HideFlags.DontSave;
			Vector3[] array = new Vector3[triCount * 3];
			Vector2[] array2 = new Vector2[triCount * 3];
			Vector2[] array3 = new Vector2[triCount * 3];
			int[] array4 = new int[triCount * 3];
			for (int i = 0; i < triCount; i++)
			{
				int num = i * 3;
				int num2 = triOffset + i;
				float num3 = Mathf.Floor(num2 % totalWidth) / (float)totalWidth;
				float num4 = Mathf.Floor(num2 / totalWidth) / (float)totalHeight;
				Vector3 vector = new Vector3(num3 * 2f - 1f, num4 * 2f - 1f, 1f);
				array[num] = vector;
				array[num + 1] = vector;
				array[num + 2] = vector;
				ref Vector2 reference = ref array2[num];
				reference = new Vector2(0f, 0f);
				ref Vector2 reference2 = ref array2[num + 1];
				reference2 = new Vector2(1f, 0f);
				ref Vector2 reference3 = ref array2[num + 2];
				reference3 = new Vector2(0f, 1f);
				ref Vector2 reference4 = ref array3[num];
				reference4 = new Vector2(num3, num4);
				ref Vector2 reference5 = ref array3[num + 1];
				reference5 = new Vector2(num3, num4);
				ref Vector2 reference6 = ref array3[num + 2];
				reference6 = new Vector2(num3, num4);
				array4[num] = num;
				array4[num + 1] = num + 1;
				array4[num + 2] = num + 2;
			}
			mesh.vertices = array;
			mesh.triangles = array4;
			mesh.uv = array2;
			mesh.uv2 = array3;
			return mesh;
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Displacement/Twirl")]
	public class Twirl : ImageEffectBase
	{
		public Vector2 radius = new Vector2(0.3f, 0.3f);

		[Range(0f, 360f)]
		public float angle = 50f;

		public Vector2 center = new Vector2(0.5f, 0.5f);

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			ImageEffects.RenderDistortion(base.material, source, destination, angle, center, radius);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Vignette and Chromatic Aberration")]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		public enum AberrationMode
		{
			Simple,
			Advanced
		}

		public AberrationMode mode;

		public float intensity = 0.036f;

		public float chromaticAberration = 0.2f;

		public float axialAberration = 0.5f;

		public float blur;

		public float blurSpread = 0.75f;

		public float luminanceDependency = 0.25f;

		public float blurDistance = 2.5f;

		public Shader vignetteShader;

		public Shader separableBlurShader;

		public Shader chromAberrationShader;

		private Material m_VignetteMaterial;

		private Material m_SeparableBlurMaterial;

		private Material m_ChromAberrationMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			m_VignetteMaterial = CheckShaderAndCreateMaterial(vignetteShader, m_VignetteMaterial);
			m_SeparableBlurMaterial = CheckShaderAndCreateMaterial(separableBlurShader, m_SeparableBlurMaterial);
			m_ChromAberrationMaterial = CheckShaderAndCreateMaterial(chromAberrationShader, m_ChromAberrationMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			int width = source.width;
			int height = source.height;
			bool flag = Mathf.Abs(blur) > 0f || Mathf.Abs(intensity) > 0f;
			float num = 1f * (float)width / (1f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 0, source.format);
				if (Mathf.Abs(blur) > 0f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 2, height / 2, 0, source.format);
					Graphics.Blit(source, renderTexture2, m_ChromAberrationMaterial, 0);
					for (int i = 0; i < 2; i++)
					{
						m_SeparableBlurMaterial.SetVector("offsets", new Vector4(0f, blurSpread * 0.001953125f, 0f, 0f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 2, height / 2, 0, source.format);
						Graphics.Blit(renderTexture2, temporary, m_SeparableBlurMaterial);
						RenderTexture.ReleaseTemporary(renderTexture2);
						m_SeparableBlurMaterial.SetVector("offsets", new Vector4(blurSpread * 0.001953125f / num, 0f, 0f, 0f));
						renderTexture2 = RenderTexture.GetTemporary(width / 2, height / 2, 0, source.format);
						Graphics.Blit(temporary, renderTexture2, m_SeparableBlurMaterial);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				m_VignetteMaterial.SetFloat("_Intensity", 1f / (1f - intensity) - 1f);
				m_VignetteMaterial.SetFloat("_Blur", 1f / (1f - blur) - 1f);
				m_VignetteMaterial.SetTexture("_VignetteTex", renderTexture2);
				Graphics.Blit(source, renderTexture, m_VignetteMaterial, 0);
			}
			m_ChromAberrationMaterial.SetFloat("_ChromaticAberration", chromaticAberration);
			m_ChromAberrationMaterial.SetFloat("_AxialAberration", axialAberration);
			m_ChromAberrationMaterial.SetVector("_BlurDistance", new Vector2(0f - blurDistance, blurDistance));
			m_ChromAberrationMaterial.SetFloat("_Luminance", 1f / Mathf.Max(Mathf.Epsilon, luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Clamp;
			}
			else
			{
				source.wrapMode = TextureWrapMode.Clamp;
			}
			Graphics.Blit((!flag) ? source : renderTexture, destination, m_ChromAberrationMaterial, (mode != AberrationMode.Advanced) ? 1 : 2);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}
	}
	[AddComponentMenu("Image Effects/Displacement/Vortex")]
	[ExecuteInEditMode]
	public class Vortex : ImageEffectBase
	{
		public Vector2 radius = new Vector2(0.4f, 0.4f);

		public float angle = 50f;

		public Vector2 center = new Vector2(0.5f, 0.5f);

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			ImageEffects.RenderDistortion(base.material, source, destination, angle, center, radius);
		}
	}
}
