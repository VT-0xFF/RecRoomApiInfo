using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using GLTF;
using GLTF.Schema;
using Newtonsoft.Json.Linq;
using Unity.Collections;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.Networking;
using UnityEngine.Playables;
using UnityEngine.Rendering;
using UnityEngine.Serialization;
using UnityEngine.Timeline;
using UnityGLTF.Cache;
using UnityGLTF.Extensions;
using UnityGLTF.JsonPointer;
using UnityGLTF.Loader;
using UnityGLTF.Plugins;
using UnityGLTF.Timeline;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityGLTF
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class AsyncCoroutineHelper : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[CompilerGenerated]
		private sealed class ADASEVBWMLK : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private object BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public AsyncCoroutineHelper IRZLODQIRHI;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			private object BIQZSYBZPAT
			{
				[Cpp2IlInjected.Token(Token = "0x6000008")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
			[DebuggerHidden]
			public ADASEVBWMLK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xB72E7C0", Offset = "0xB72D1C0", VA = "0x18B72E7C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xB72E840", Offset = "0xB72D240", VA = "0x18B72E840", Slot = "8")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private struct <YieldOnTimeout>d__3 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public AsyncCoroutineHelper <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xB743470", Offset = "0xB741E70", VA = "0x18B743470", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xB743660", Offset = "0xB742060", VA = "0x18B743660", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public float BudgetPerFrameInSeconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private WaitForEndOfFrame WJOYZVWSDEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private float CNDDUHYNUMG;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xB72EB00", Offset = "0xB72D500", VA = "0x18B72EB00")]
		[AsyncStateMachine(typeof(<YieldOnTimeout>d__3))]
		public Task YieldOnTimeout()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xB72EA70", Offset = "0xB72D470", VA = "0x18B72EA70")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB72EA00", Offset = "0xB72D400", VA = "0x18B72EA00")]
		[IteratorStateMachine(typeof(ADASEVBWMLK))]
		private IEnumerator SHYGKIDANUR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xB72EBD0", Offset = "0xB72D5D0", VA = "0x18B72EBD0")]
		public AsyncCoroutineHelper()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class GLTFComponent : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private struct <Load>d__34 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public GLTFComponent <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private OLYORYCKIUH <importOptions>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private GLTFSceneImporter <sceneImporter>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xB73E580", Offset = "0xB73CF80", VA = "0x18B73E580", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xB73F270", Offset = "0xB73DC70", VA = "0x18B73F270", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private struct <Start>d__33 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public GLTFComponent <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private object <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xB73F2D0", Offset = "0xB73DCD0", VA = "0x18B73F2D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xD39FE0", Offset = "0xD389E0", VA = "0x180D39FE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public string GLTFUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public bool Multithreaded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[FormerlySerializedAs("AppendStreamingAssets")]
		public bool LoadFromStreamingAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public bool PlayAnimationOnLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[Tooltip("Hide the scene object during load, then activate it when complete")]
		public bool HideSceneObjDuringLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public ImporterFactory Factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public UnityAction onLoadComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public bool loadOnStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private int RetryCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private float RetryTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int FVLPLMSBJVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int MaximumLod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int Timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public GLTFSceneImporter.ColliderType Collider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private Shader shaderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[Header("Import Settings")]
		public RuntimeTextureCompression TextureCompression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public GLTFImporterNormals ImportNormals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public GLTFImporterNormals ImportTangents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public bool SwapUVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[Tooltip("Blend shape frame weight import multiplier. Default is 1. For compatibility with some FBX animations you may need to use 100.")]
		public BlendShapeFrameWeightSetting blendShapeFrameWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[Tooltip("When enabled, the CPU copy of the mesh will be kept in memory after the mesh has been uploaded to the GPU. This is useful if you want to modify the mesh at runtime.")]
		public bool KeepCPUCopyOfMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x91")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Tooltip("When enabled, the CPU copy of the texture will be kept in memory after the texture has been uploaded to the GPU. This is useful if you want to modify the texture at runtime.")]
		public bool KeepCPUCopyOfTexture;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IEnumerable<Animation> AYHJFYOZINL
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DA0", Offset = "0xCD57A0", VA = "0x180CD6DA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DD0", Offset = "0xCD57D0", VA = "0x180CD6DD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public GameObject DOIOCQWBQDL
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DC0", Offset = "0xCD57C0", VA = "0x180CD6DC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C80", Offset = "0xCD5680", VA = "0x180CD6C80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Shader UXADULXDBVB
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xCD7530", Offset = "0xCD5F30", VA = "0x180CD7530")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xB72F720", Offset = "0xB72E120", VA = "0x18B72F720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xB72F600", Offset = "0xB72E000", VA = "0x18B72F600")]
		[AsyncStateMachine(typeof(<Start>d__33))]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xB72F530", Offset = "0xB72DF30", VA = "0x18B72F530")]
		[AsyncStateMachine(typeof(<Load>d__34))]
		public Task Load()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xB72F440", Offset = "0xB72DE40", VA = "0x18B72F440")]
		public void ApplyOverrideShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x10819B0", Offset = "0x10803B0", VA = "0x1810819B0")]
		private void ZYCMOEEMLQL(GameObject a, ExceptionDispatchInfo b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xB72F6B0", Offset = "0xB72E0B0", VA = "0x18B72F6B0")]
		public GLTFComponent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class GLTFRecorderComponent : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class SAIPKPLTIUD : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private object BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public GLTFRecorderComponent IRZLODQIRHI;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object BIQZSYBZPAT
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
			[DebuggerHidden]
			public SAIPKPLTIUD(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xB73DC20", Offset = "0xB73C620", VA = "0x18B73DC20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xB73DCE0", Offset = "0xB73C6E0", VA = "0x18B73DCE0", Slot = "8")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public string outputFile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Transform exportRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public bool recordBlendShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public bool recordRootInWorldSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public bool recordAnimationPointer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public InputAction recordingKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		protected EJIVIUDZLDX OKOGUOOWKDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public UnityEvent recordingStarted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public UnityEvent<string> recordingEnded;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool QZKUUHHTEOF
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xB72FF40", Offset = "0xB72E940", VA = "0x18B72FF40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private double YZRTASDATIS
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xB72F7A0", Offset = "0xB72E1A0", VA = "0x18B72F7A0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xB72F9F0", Offset = "0xB72E3F0", VA = "0x18B72F9F0", Slot = "4")]
		[ContextMenu("Start Recording")]
		public virtual void StartRecording()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xB72FD80", Offset = "0xB72E780", VA = "0x18B72FD80", Slot = "5")]
		[ContextMenu("Stop Recording")]
		public virtual void StopRecording()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xB72F7B0", Offset = "0xB72E1B0", VA = "0x18B72F7B0")]
		private void LMGUPMUVJRH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xB72FCF0", Offset = "0xB72E6F0", VA = "0x18B72FCF0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xB72F960", Offset = "0xB72E360", VA = "0x18B72F960")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xB72F910", Offset = "0xB72E310", VA = "0x18B72F910", Slot = "6")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xB72F750", Offset = "0xB72E150", VA = "0x18B72F750", Slot = "7")]
		protected virtual void BFWOPMJWGMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xB72F980", Offset = "0xB72E380", VA = "0x18B72F980")]
		[IteratorStateMachine(typeof(SAIPKPLTIUD))]
		private IEnumerator QRMMMPIFBAN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xB72FE80", Offset = "0xB72E880", VA = "0x18B72FE80")]
		public GLTFRecorderComponent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xB72F7B0", Offset = "0xB72E1B0", VA = "0x18B72F7B0")]
		[CompilerGenerated]
		private void WQZPNHVFFBW(InputAction.CallbackContext a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class SKRDRZRTZVR
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		internal class KVTKOQZCZCJ : HMEEPODDUBT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private readonly SKRDRZRTZVR TNHZNRTQGYQ;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xD007A0", Offset = "0xCFF1A0", VA = "0x180D007A0")]
			internal KVTKOQZCZCJ(SKRDRZRTZVR a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xB73D1D0", Offset = "0xB73BBD0", VA = "0x18B73D1D0", Slot = "4")]
			public override void CGPEUEFSVGN(GLTFSceneExporter a, GZYGZQSIZFV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xB73D340", Offset = "0xB73BD40", VA = "0x18B73D340", Slot = "5")]
			public override void MFIEYBWZCZI(GLTFSceneExporter a, GZYGZQSIZFV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xB73D490", Offset = "0xB73BE90", VA = "0x18B73D490", Slot = "8")]
			public override void VIKYSQFVIMO(GLTFSceneExporter a, GZYGZQSIZFV b, Transform c, SIDFNDXEBQO d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xB73D380", Offset = "0xB73BD80", VA = "0x18B73D380", Slot = "9")]
			public override bool VAJRWJGVQKO(GLTFSceneExporter a, GZYGZQSIZFV b, Material c, RLXWJRYFKUW d)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xB73D280", Offset = "0xB73BC80", VA = "0x18B73D280", Slot = "10")]
			public override void DXNJIUKEWRR(GLTFSceneExporter a, GZYGZQSIZFV b, Material c, RLXWJRYFKUW d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xB73D4D0", Offset = "0xB73BED0", VA = "0x18B73D4D0", Slot = "11")]
			public override void VMLQTAFCKMW(GLTFSceneExporter a, GLTFSceneExporter.UniqueTexture b, string c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xB73D210", Offset = "0xB73BC10", VA = "0x18B73D210", Slot = "12")]
			public override void CYQORIYGWPX(GLTFSceneExporter a, GLTFSceneExporter.UniqueTexture b, int c, QSDNGVTLXBY d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xB73D300", Offset = "0xB73BD00", VA = "0x18B73D300", Slot = "13")]
			public override void LJFHLHPDUTN(GLTFSceneExporter a, Mesh b, OKMUISONBMQ c, int d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xB73D2C0", Offset = "0xB73BCC0", VA = "0x18B73D2C0", Slot = "14")]
			public override void IXBWDPSMTJB(GLTFSceneExporter a, Mesh b, MRVNGWGPAZI c, int d)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public bool PQHJFTJEQMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public LayerMask REKBIIKPRMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public ILogger GSAFKGYCGWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		internal readonly GLTFSettings MDYCRUXTCID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public GLTFSceneExporter.RetrieveTexturePathDelegate KECRJEOMZSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public GLTFSceneExporter.AfterSceneExportDelegate MFIEYBWZCZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public GLTFSceneExporter.BeforeSceneExportDelegate CGPEUEFSVGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public GLTFSceneExporter.AfterNodeExportDelegate VIKYSQFVIMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public GLTFSceneExporter.BeforeMaterialExportDelegate VAJRWJGVQKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public GLTFSceneExporter.AfterMaterialExportDelegate DXNJIUKEWRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public GLTFSceneExporter.BeforeTextureExportDelegate VMLQTAFCKMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public GLTFSceneExporter.AfterTextureExportDelegate CYQORIYGWPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public GLTFSceneExporter.AfterPrimitiveExportDelegate LJFHLHPDUTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public GLTFSceneExporter.AfterMeshExportDelegate IXBWDPSMTJB;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xB73DD80", Offset = "0xB73C780", VA = "0x18B73DD80")]
		public SKRDRZRTZVR(GLTFSettings a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xB73DD20", Offset = "0xB73C720", VA = "0x18B73DD20")]
		internal HMEEPODDUBT AYZMCVTPVWF()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class GLTFSceneExporter
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public delegate string RetrieveTexturePathDelegate(Texture texture);

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public delegate void BeforeSceneExportDelegate(GLTFSceneExporter exporter, GZYGZQSIZFV gltfRoot);

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public delegate void AfterSceneExportDelegate(GLTFSceneExporter exporter, GZYGZQSIZFV gltfRoot);

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void AfterNodeExportDelegate(GLTFSceneExporter exporter, GZYGZQSIZFV gltfRoot, Transform transform, SIDFNDXEBQO node);

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate bool BeforeMaterialExportDelegate(GLTFSceneExporter exporter, GZYGZQSIZFV gltfRoot, Material material, RLXWJRYFKUW materialNode);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void AfterMaterialExportDelegate(GLTFSceneExporter exporter, GZYGZQSIZFV gltfRoot, Material material, RLXWJRYFKUW materialNode);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void BeforeTextureExportDelegate(GLTFSceneExporter exporter, UniqueTexture texture, string textureSlot);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public delegate void AfterTextureExportDelegate(GLTFSceneExporter exporter, UniqueTexture texture, int index, QSDNGVTLXBY tex);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public delegate void AfterPrimitiveExportDelegate(GLTFSceneExporter exporter, Mesh mesh, OKMUISONBMQ primitive, int index);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public delegate void AfterMeshExportDelegate(GLTFSceneExporter exporter, Mesh mesh, MRVNGWGPAZI gltfMesh, int index);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class BVMYEZPMZKM : HMEEPODDUBT
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xB72ED60", Offset = "0xB72D760", VA = "0x18B72ED60", Slot = "5")]
			public override void MFIEYBWZCZI(GLTFSceneExporter a, GZYGZQSIZFV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xB72EC40", Offset = "0xB72D640", VA = "0x18B72EC40", Slot = "4")]
			public override void CGPEUEFSVGN(GLTFSceneExporter a, GZYGZQSIZFV b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xB72EF40", Offset = "0xB72D940", VA = "0x18B72EF40", Slot = "8")]
			public override void VIKYSQFVIMO(GLTFSceneExporter a, GZYGZQSIZFV b, Transform c, SIDFNDXEBQO d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xB72EDE0", Offset = "0xB72D7E0", VA = "0x18B72EDE0", Slot = "9")]
			public override bool VAJRWJGVQKO(GLTFSceneExporter a, GZYGZQSIZFV b, Material c, RLXWJRYFKUW d)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xB72ECC0", Offset = "0xB72D6C0", VA = "0x18B72ECC0", Slot = "10")]
			public override void DXNJIUKEWRR(GLTFSceneExporter a, GZYGZQSIZFV b, Material c, RLXWJRYFKUW d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
			public BVMYEZPMZKM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public struct TextureExportSettings
		{
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public enum Conversion
			{
				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				None,
				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				MetalGlossChannelSwap,
				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				MetalGlossOcclusionChannelSwap,
				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				NormalChannel
			}

			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public enum AlphaMode
			{
				[Cpp2IlInjected.Token(Token = "0x40000B5")]
				Never,
				[Cpp2IlInjected.Token(Token = "0x40000B6")]
				Always,
				[Cpp2IlInjected.Token(Token = "0x40000B7")]
				Heuristic
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public bool isValid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public Conversion conversion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public AlphaMode alphaMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public bool linear;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public float smoothnessRangeMin;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public float smoothnessRangeMax;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public float metallicRangeMin;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public float metallicRangeMax;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public float occlusionRangeMin;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public float occlusionRangeMax;

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xB73E540", Offset = "0xB73CF40", VA = "0x18B73E540")]
			public TextureExportSettings(TextureExportSettings source)
			{
			}

			[SpecialName]
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xB73E500", Offset = "0xB73CF00", VA = "0x18B73E500")]
			public static bool VPGVCSNEDTU(TextureExportSettings a, TextureExportSettings b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xB73E320", Offset = "0xB73CD20", VA = "0x18B73E320")]
			public bool Equals(TextureExportSettings other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xB73E270", Offset = "0xB73CC70", VA = "0x18B73E270", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xB73E400", Offset = "0xB73CE00", VA = "0x18B73E400", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		private struct ImageInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public Texture2D texture;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public TextureExportSettings textureMapType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public string outputPath;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public bool canBeExportedFromDisk;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		private struct FileInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public Stream stream;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public string uniqueFileName;
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public struct UniqueTexture : IEquatable<UniqueTexture>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public Texture Texture;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public int MaxSize;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public TextureExportSettings ExportSettings;

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xB743D50", Offset = "0xB742750", VA = "0x18B743D50")]
			public int WZMMQYSCYWC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xB743D10", Offset = "0xB742710", VA = "0x18B743D10")]
			public int VVNVBSLYDOZ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xB743E20", Offset = "0xB742820", VA = "0x18B743E20")]
			public UniqueTexture(Texture tex, string textureSlot, GLTFSceneExporter exporter)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xB743D90", Offset = "0xB742790", VA = "0x18B743D90")]
			public UniqueTexture(Texture tex, TextureExportSettings exportSettings)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xB743AB0", Offset = "0xB7424B0", VA = "0x18B743AB0", Slot = "4")]
			public bool Equals(UniqueTexture other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xB743A00", Offset = "0xB742400", VA = "0x18B743A00", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xB743C70", Offset = "0xB742670", VA = "0x18B743C70", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public struct UniquePrimitive
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public Mesh Mesh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public Material[] Materials;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public SkinnedMeshRenderer SkinnedMeshRenderer;

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xB7436C0", Offset = "0xB7420C0", VA = "0x18B7436C0")]
			public bool Equals(UniquePrimitive other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xB743810", Offset = "0xB742210", VA = "0x18B743810", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xB7438B0", Offset = "0xB7422B0", VA = "0x18B7438B0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		private struct MeshAccessors
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public MYCFVKCOBHO aPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public MYCFVKCOBHO aNormal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public MYCFVKCOBHO aTangent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public MYCFVKCOBHO aTexcoord0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public MYCFVKCOBHO aTexcoord1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public MYCFVKCOBHO aTexcoord2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public MYCFVKCOBHO aColor0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public MYCFVKCOBHO aJoints0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public MYCFVKCOBHO aWeights0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public Dictionary<int, OKMUISONBMQ> subMeshPrimitives;
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private struct BlendShapeAccessors
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public List<Dictionary<string, MYCFVKCOBHO>> targets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public List<double> weights;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public List<string> targetNames;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			internal SkinnedMeshRenderer firstSkinnedMeshRenderer;
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		private struct SamplerRelevantTextureData : IEquatable<SamplerRelevantTextureData>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			private readonly TextureWrapMode wrapMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private readonly FilterMode filterMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			private readonly bool hasMipmaps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			private readonly bool hasAniso;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool JGAEHLEWZID
			{
				[Cpp2IlInjected.Token(Token = "0x60000C7")]
				[Cpp2IlInjected.Address(RVA = "0xEC0C20", Offset = "0xEBF620", VA = "0x180EC0C20")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public bool PCWTBRGPTTI
			{
				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x88CE9A0", Offset = "0x88CD3A0", VA = "0x1888CE9A0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xB73E1E0", Offset = "0xB73CBE0", VA = "0x18B73E1E0")]
			public SamplerRelevantTextureData(Texture texture)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xB73E130", Offset = "0xB73CB30", VA = "0x18B73E130", Slot = "4")]
			public bool Equals(SamplerRelevantTextureData other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xB73E070", Offset = "0xB73CA70", VA = "0x18B73E070", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xB73E160", Offset = "0xB73CB60", VA = "0x18B73E160", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class MFCQTQBHMXC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public bool XOUOAIOROUA;

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public MFCQTQBHMXC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xB73D510", Offset = "0xB73BF10", VA = "0x18B73D510")]
			internal Color JVHSQJCOBWN(object a)
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class MFHXQWVEWIL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public float DEWWJOGVJIN;

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public MFHXQWVEWIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xB73D600", Offset = "0xB73C000", VA = "0x18B73D600")]
			internal float JVCLTCIQSLE(object a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class QFCBQFBFUGL : IEnumerable<(int, OKMUISONBMQ)>, IEnumerable, IEnumerator<(int, OKMUISONBMQ)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private (int subMeshIndex, OKMUISONBMQ prim) BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private int YTKXRPSSEMX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public GLTFSceneExporter IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private Mesh ADZETTUZVRJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public Mesh LARXPNCYPRE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private Dictionary<int, OKMUISONBMQ>.Enumerator MXGZQBRVDOG;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private (int, OKMUISONBMQ) INMMIVZBGQU
			{
				[Cpp2IlInjected.Token(Token = "0x60000E5")]
				[Cpp2IlInjected.Address(RVA = "0xD6AE80", Offset = "0xD69880", VA = "0x180D6AE80", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((int, OKMUISONBMQ));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0xB73DA50", Offset = "0xB73C450", VA = "0x18B73DA50", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1D12190", Offset = "0x1D10B90", VA = "0x181D12190")]
			[DebuggerHidden]
			public QFCBQFBFUGL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xB73DB50", Offset = "0xB73C550", VA = "0x18B73DB50", Slot = "7")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xB73D780", Offset = "0xB73C180", VA = "0x18B73D780", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xB73D730", Offset = "0xB73C130", VA = "0x18B73D730")]
			private void ALJGYZPBIVB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xB73DBE0", Offset = "0xB73C5E0", VA = "0x18B73DBE0", Slot = "10")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xB73DAA0", Offset = "0xB73C4A0", VA = "0x18B73DAA0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(int, OKMUISONBMQ)> ZPXTNCCLSGP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xB73DAA0", Offset = "0xB73C4A0", VA = "0x18B73DAA0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator SJAOULXGYMP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static ILogger NJTUYZKPNIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private List<HMEEPODDUBT> CBFPLUTIPGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private Transform[] TTTWNRIDMQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private GZYGZQSIZFV SOWSTSWRDPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private NXEAZIBWYCJ JPGBVNUKUVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private WCYSICVUSPP JDMBOOKTKEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private List<ImageInfo> WFJDIXYNADX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private HashSet<string> KXKBMMAYQRQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private List<FileInfo> ZQDKAJMWCAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private HashSet<string> WLKGZNINOPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private List<UniqueTexture> FOLRMUORSYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private Dictionary<int, int> CUSSMZQTUXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private bool EHGWLKGLYSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private Dictionary<int, int> EKVNVPRNIWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private List<Transform> JSDRVGHDRTJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private int STINUHMKPOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private SKRDRZRTZVR TNHZNRTQGYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private Material PIUWZJICEZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private Material YRLETNLOVHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private Material SGWENFVAYHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private bool YKBENTZYHWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly Dictionary<UniquePrimitive, FAPFUECQVDQ> JWQOKSIVJGK;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static ProfilerMarker SFTFBGXKNHV;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static ProfilerMarker UOXOCISZXMX;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static ProfilerMarker KJWRNPRXFGL;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static ProfilerMarker GXJRFHVLQKL;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static ProfilerMarker XQTXVFDEHRM;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static ProfilerMarker RCLTHBGACTB;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static ProfilerMarker QLHJUQRDDRD;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static ProfilerMarker QHKKTZVHRVP;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static ProfilerMarker DZAOKQUZKSO;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static ProfilerMarker IDCEHXFBAKI;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static ProfilerMarker JXASLBZILOY;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static ProfilerMarker QELMHWOACGJ;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static ProfilerMarker IYCFWWMOBIL;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static ProfilerMarker UINLTHALWWS;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static ProfilerMarker YBBXVNPDUHC;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static ProfilerMarker VMIMJSGWYKT;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static ProfilerMarker FJQEAXVMSRP;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static ProfilerMarker CFFRGCVLOIY;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static ProfilerMarker MLIGDZXCMRO;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static ProfilerMarker BVKQGJPWIGN;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static ProfilerMarker GBXBFFSFEAZ;

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static ProfilerMarker IAAPEYBXGET;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private static ProfilerMarker KZEDFILRXZU;

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private static ProfilerMarker AATYEYGRBOR;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private static ProfilerMarker VUFBZZPHMII;

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private static ProfilerMarker HPKKCZQWDPD;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static ProfilerMarker FLSRPTXRVWU;

		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private static ProfilerMarker QGUQWQYSIGP;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static ProfilerMarker CPRJOQLWTMC;

		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private static ProfilerMarker QYIFUEJZUVO;

		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private static ProfilerMarker BZODVFRLYYL;

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private static ProfilerMarker IWADXOIVFGK;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private static ProfilerMarker JZVAPVJXBSJ;

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private static ProfilerMarker ELNKBTTUKEU;

		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private static ProfilerMarker GHFBQUIYCCK;

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private static ProfilerMarker GXEIPHPKURH;

		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private static ProfilerMarker WBKZOCSPQHB;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private static ProfilerMarker UCSBADEKVPQ;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static ProfilerMarker OKEUOSKAVGN;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private static ProfilerMarker JPYWWPCQLRA;

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private static ProfilerMarker INGMZLJIZZJ;

		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private static ProfilerMarker IPGMSNVAXBP;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private static ProfilerMarker IPRGRRAFVBN;

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static ProfilerMarker CRUWEFEODBY;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static ProfilerMarker TUAEQBHDVSH;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static ProfilerMarker FNACYPGDIJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private UnityGLTF.BinaryWriterWithLessAllocations CEMOKJATKDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private bool? IFYOBFWHUIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		internal readonly List<PJROBXQNNIO> XLGXDFANNRQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly EGLUDZKVBOV CDZDGUCBVDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private Dictionary<int, int> PFSJJSNASOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private Dictionary<int, int> KJLXNZBNVDT;

		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[CompilerGenerated]
		private static BeforeSceneExportDelegate CGPEUEFSVGN;

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[CompilerGenerated]
		private static AfterSceneExportDelegate MFIEYBWZCZI;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[CompilerGenerated]
		private static AfterNodeExportDelegate VIKYSQFVIMO;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[CompilerGenerated]
		private static BeforeMaterialExportDelegate VAJRWJGVQKO;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[CompilerGenerated]
		private static AfterMaterialExportDelegate DXNJIUKEWRR;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static Material SHGJGNCWPEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private HashSet<Material> CQJAFBJMYEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly Dictionary<Mesh, MeshAccessors> FNNSUPZHCFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly Dictionary<Mesh, BlendShapeAccessors> XLXIYAFHJBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly Dictionary<SkinnedMeshRenderer, List<double>> NJZPOSPAPSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private List<Transform> TXIYXRYDASG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private Dictionary<SkinnedMeshRenderer, Mesh> VWXRXGMQWCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private Dictionary<SamplerRelevantTextureData, int> VQAKWYAFEID;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public IReadOnlyList<Transform> IVFXHHBPUQD
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private GLTFSettings MDYCRUXTCID
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xB7129A0", Offset = "0xB7113A0", VA = "0x18B7129A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private bool GSEGWNHVLXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xB71A550", Offset = "0xB718F50", VA = "0x18B71A550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private bool ZNEIVFICDRV
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xB7133A0", Offset = "0xB711DA0", VA = "0x18B7133A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private bool ECOTFNSQJLU
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xB7154C0", Offset = "0xB713EC0", VA = "0x18B7154C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static Material TBEMYQMWOVY
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xB71CFB0", Offset = "0xB71B9B0", VA = "0x18B71CFB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xB715650", Offset = "0xB714050", VA = "0x18B715650")]
		public TextureExportSettings GQHMAXIMXMA(string a)
		{
			return default(TextureExportSettings);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xB72BBD0", Offset = "0xB72A5D0", VA = "0x18B72BBD0")]
		private Material YOXVWXTLGOL(TextureExportSettings a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xB71F050", Offset = "0xB71DA50", VA = "0x18B71F050")]
		private static Material SGDWKSRAPJY(Material a, TextureExportSettings b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xB72D0A0", Offset = "0xB72BAA0", VA = "0x18B72D0A0")]
		public GLTFSceneExporter(Transform[] rootTransforms, SKRDRZRTZVR context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xB722EB0", Offset = "0xB7218B0", VA = "0x18B722EB0")]
		public void UAUXAEHPXDR(Stream a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xB719FF0", Offset = "0xB7189F0", VA = "0x18B719FF0")]
		public void KKWKGZJGHXO(string a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xB71EDC0", Offset = "0xB71D7C0", VA = "0x18B71EDC0")]
		private bool RKPWJLEBQSF(Transform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xB7177F0", Offset = "0xB7161F0", VA = "0x18B7177F0")]
		private LYHUNAQFDFV IZUENHXWYNC(string a, Transform[] b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xB716570", Offset = "0xB714F70", VA = "0x18B716570")]
		private FOKAMTZKDHN HXZYVKJAEPS(Transform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xB7295D0", Offset = "0xB727FD0", VA = "0x18B7295D0")]
		private static bool WUENQGRCRWQ(GameObject a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xB722390", Offset = "0xB720D90", VA = "0x18B722390")]
		private void TOKHORGRDJI(Transform a, [Out] GameObject[] b, [Out] GameObject[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xB729840", Offset = "0xB728240", VA = "0x18B729840")]
		private void XPNOHSHBRPY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xB718CD0", Offset = "0xB7176D0", VA = "0x18B718CD0")]
		public FMTAGVZYQQW JBMALTVJIZI(GZYGZQSIZFV a, Material b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xB729AF0", Offset = "0xB7284F0", VA = "0x18B729AF0")]
		public AXTSRHKTJDS XVVMNVTMRKI(GZYGZQSIZFV a, UniqueTexture b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xB713B90", Offset = "0xB712590", VA = "0x18B713B90")]
		public GNIRBFJHUPY CJEBCSGCWTE(GZYGZQSIZFV a, Texture b, TextureExportSettings c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xB7221D0", Offset = "0xB720BD0", VA = "0x18B7221D0")]
		private static void TALGHQDBOPN(Stream a, BinaryWriter b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xB7162E0", Offset = "0xB714CE0", VA = "0x18B7162E0")]
		private static void HRYNBDUOJKQ(Stream a, byte b = 32, uint c = 4u)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xB711B80", Offset = "0xB710580", VA = "0x18B711B80")]
		public static uint AENFTLIKTJN(uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xB7120A0", Offset = "0xB710AA0", VA = "0x18B7120A0")]
		private MYCFVKCOBHO AMMHHIUMNFN(Vector4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xB72B1A0", Offset = "0xB729BA0", VA = "0x18B72B1A0")]
		private MYCFVKCOBHO YNRQLRLXMJC(Quaternion[] a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xB7271A0", Offset = "0xB725BA0", VA = "0x18B7271A0")]
		private MYCFVKCOBHO VAUSEUCVOXV(Matrix4x4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xB726C70", Offset = "0xB725670", VA = "0x18B726C70")]
		private MYCFVKCOBHO VAUSEUCVOXV(float[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xB7249E0", Offset = "0xB7233E0", VA = "0x18B7249E0")]
		private MYCFVKCOBHO VAUSEUCVOXV(int[] a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xB7265E0", Offset = "0xB724FE0", VA = "0x18B7265E0")]
		private MYCFVKCOBHO VAUSEUCVOXV(Vector2[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xB727640", Offset = "0xB726040", VA = "0x18B727640")]
		private MYCFVKCOBHO VAUSEUCVOXV(Vector3[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xB717C80", Offset = "0xB716680", VA = "0x18B717C80")]
		private MYCFVKCOBHO JAQDDRUXJTJ(MYCFVKCOBHO a, Vector3[] b, Vector3[] c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xB725130", Offset = "0xB723B30", VA = "0x18B725130")]
		private MYCFVKCOBHO VAUSEUCVOXV(Vector4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xB725A30", Offset = "0xB724430", VA = "0x18B725A30")]
		private MYCFVKCOBHO VAUSEUCVOXV(Color[] a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xB719E60", Offset = "0xB718860", VA = "0x18B719E60")]
		private OWILLSWHPZG KKKEDMMQLTN(uint a, uint b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190")]
		public void LDGTVMAEFOK(Transform a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xB71A200", Offset = "0xB718C00", VA = "0x18B71A200")]
		internal int KOEAQDOKXHE(object a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xB718E20", Offset = "0xB717820", VA = "0x18B718E20")]
		public int JLARPLIVOQO(Transform a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xB729C80", Offset = "0xB728680", VA = "0x18B729C80")]
		public int YFSBLBQBBZX(Material a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xB71CEF0", Offset = "0xB71B8F0", VA = "0x18B71CEF0")]
		public int NBUDCLQPTEO(Light a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xB713AD0", Offset = "0xB7124D0", VA = "0x18B713AD0")]
		public int CCONQBBPVUD(Camera a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xB71D1F0", Offset = "0xB71BBF0", VA = "0x18B71D1F0")]
		[IteratorStateMachine(typeof(QFCBQFBFUGL))]
		public IEnumerable<(int, OKMUISONBMQ)> OADCXVNUSFU(Mesh a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xB72BCB0", Offset = "0xB72A6B0", VA = "0x18B72BCB0")]
		private static void YPKMRAOTHML(Color a, [Out] Color b, [Out] float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xB71D280", Offset = "0xB71BC80", VA = "0x18B71D280")]
		private static void OAODSPJSSBC(Vector4 a, [Out] Vector2 b, [Out] Vector2 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xB7129C0", Offset = "0xB7113C0", VA = "0x18B7129C0")]
		private bool AVGXJHGHNZX(object[] a, int b, int c, int d, int e, int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xB712B50", Offset = "0xB711550", VA = "0x18B712B50")]
		public void AWMNXSJXNAJ(float[] a, object[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xB71A580", Offset = "0xB718F80", VA = "0x18B71A580")]
		public void LRWIYRPVXLL(UnityEngine.Object a, string b, ABAJRTCMWQH c, float[] d, object[] e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xB722D60", Offset = "0xB721760", VA = "0x18B722D60")]
		private void TTZEHIXLRCD(object a, string b, ZPCBEZLKRXQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xB711BA0", Offset = "0xB7105A0", VA = "0x18B711BA0")]
		private AHXSXSGLOUY AGIOQKHPXGL(Camera a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xB714CC0", Offset = "0xB7136C0", VA = "0x18B714CC0")]
		private FTEGDPPXEYP FISLAJNLDLO(Light a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xB71F2F0", Offset = "0xB71DCF0", VA = "0x18B71F2F0")]
		public FMTAGVZYQQW SSEDLCTHDMJ(Material a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xB727F00", Offset = "0xB726900", VA = "0x18B727F00")]
		private FMTAGVZYQQW VRNNAJFGUEO(Material a, RLXWJRYFKUW b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xB7163B0", Offset = "0xB714DB0", VA = "0x18B7163B0")]
		private bool HUCUXQDADFJ(Material a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xB724920", Offset = "0xB723320", VA = "0x18B724920")]
		private bool UZJCDUIPSHM(Material a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xB715450", Offset = "0xB713E50", VA = "0x18B715450")]
		private bool FPOTDOBKHOB(Material a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xB71EF20", Offset = "0xB71D920", VA = "0x18B71EF20")]
		private bool RZPUDKOGLVJ(Material a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xB7175E0", Offset = "0xB715FE0", VA = "0x18B7175E0")]
		private static bool IHAMYVHMIIK(Shader a, string b, ShaderPropertyType c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xB7289A0", Offset = "0xB7273A0", VA = "0x18B7289A0")]
		private void WOJLMHJOCTD(ZWTHYTPYMLD a, Material b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xB71D2B0", Offset = "0xB71BCB0", VA = "0x18B71D2B0")]
		public FAZCGRNDBGA OGODDRFBISS(Texture a, string b, Material c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xB727D80", Offset = "0xB726780", VA = "0x18B727D80")]
		private OTLVMGECVFM VJSRHQNLIFO(Texture a, string b, Material c, [Optional] AXTSRHKTJDS d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xB71D4A0", Offset = "0xB71BEA0", VA = "0x18B71D4A0")]
		public TXRBWBBJWFB OQIINESZZCV(Material a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xB718EE0", Offset = "0xB7178E0", VA = "0x18B718EE0")]
		public void JOTQPUNKTRW(RLXWJRYFKUW a, Material b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xB722610", Offset = "0xB721010", VA = "0x18B722610")]
		private void TSXMUDAQDLV(RLXWJRYFKUW a, Material b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xB71E870", Offset = "0xB71D270", VA = "0x18B71E870")]
		private QPAPJZNDHHQ RHKDOMAYJAJ(Material a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xB724890", Offset = "0xB723290", VA = "0x18B724890")]
		internal static void UHRYIEBGAUN(Color a, [Out] Color b, [Out] float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xB717680", Offset = "0xB716080", VA = "0x18B717680")]
		public void IXICUBWPDJD(SIDFNDXEBQO a, List<UniquePrimitive> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xB728220", Offset = "0xB726C20", VA = "0x18B728220")]
		private static List<UniquePrimitive> VUKVFJSDKFN(IEnumerable<GameObject> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xB7175A0", Offset = "0xB715FA0", VA = "0x18B7175A0")]
		public FOKAMTZKDHN HXZYVKJAEPS(GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xB7133D0", Offset = "0xB711DD0", VA = "0x18B7133D0")]
		public FAPFUECQVDQ CBWXZMCVATL(string a, List<UniquePrimitive> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xB729D40", Offset = "0xB728740", VA = "0x18B729D40")]
		private OKMUISONBMQ[] YLYPJQDCIKB(UniquePrimitive a, MRVNGWGPAZI b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xB72BE80", Offset = "0xB72A880", VA = "0x18B72BE80")]
		private List<double> ZXSRXXNILTZ(SkinnedMeshRenderer a, Mesh b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xB719410", Offset = "0xB717E10", VA = "0x18B719410")]
		private void KADQWYPJAXD(SkinnedMeshRenderer a, Mesh b, int c, OKMUISONBMQ d, MRVNGWGPAZI e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xB727EE0", Offset = "0xB7268E0", VA = "0x18B727EE0")]
		private static bool VNVNJZPVOXS(OKMUISONBMQ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xB71E410", Offset = "0xB71CE10", VA = "0x18B71E410")]
		private static DrawMode OQKJXOWEYEX(MeshTopology a)
		{
			return default(DrawMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xB714920", Offset = "0xB713320", VA = "0x18B714920")]
		private static bool DQETMGBFXSL(Mesh a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xB7237C0", Offset = "0xB7221C0", VA = "0x18B7237C0")]
		private void UFDEDOUEDZP(Transform a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xB7293A0", Offset = "0xB727DA0", VA = "0x18B7293A0")]
		private Mesh WTTXLSWUMOW(GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xB71E620", Offset = "0xB71D020", VA = "0x18B71E620")]
		private Material[] QSAOROTGZEB(GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xB71EC30", Offset = "0xB71D630", VA = "0x18B71EC30")]
		private Vector4[] RKJBGFTUWDL(BoneWeight[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xB71E720", Offset = "0xB71D120", VA = "0x18B71E720")]
		private Vector4[] QYIZDOFTDQH(BoneWeight[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xB7298D0", Offset = "0xB7282D0", VA = "0x18B7298D0")]
		private string XSHYPAQYGSS(HashSet<string> a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xB71E510", Offset = "0xB71CF10", VA = "0x18B71E510")]
		public ZWTHYTPYMLD OTCWUHPWVRF(Texture a, string b, [Optional] TextureExportSettings c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xB7222A0", Offset = "0xB720CA0", VA = "0x18B7222A0")]
		public ZWTHYTPYMLD TLNFAWVTGAS(Material a, Texture b, string c, [Optional] TextureExportSettings d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xB715950", Offset = "0xB714350", VA = "0x18B715950")]
		public AXTSRHKTJDS HJIDPGXTGAX(Texture a, string b, [Optional] TextureExportSettings c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xB714940", Offset = "0xB713340", VA = "0x18B714940")]
		private string EXDVYUJKBBL(Texture a, TextureExportSettings b, string c, [Out] bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xB721870", Offset = "0xB720270", VA = "0x18B721870")]
		private GNIRBFJHUPY SZBIXRDVNSZ(UniqueTexture a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5B08380", Offset = "0x5B06D80", VA = "0x185B08380")]
		private bool DDFOZJIFHYS(TextureExportSettings a, Texture b, [Out] string c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0")]
		private byte[] QWZVCBZTXAQ(Texture a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xB71EFC0", Offset = "0xB71D9C0", VA = "0x18B71EFC0")]
		private bool SETWQKYVYRW(Texture a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xB71CE70", Offset = "0xB71B870", VA = "0x18B71CE70")]
		private bool MSZQXVIGFJH(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xB714BF0", Offset = "0xB7135F0", VA = "0x18B714BF0")]
		private bool EYWBVFVZMEY(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xB713D60", Offset = "0xB712760", VA = "0x18B713D60")]
		private GNIRBFJHUPY DLFYZZMNRQK(UniqueTexture a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xB72C020", Offset = "0xB72AA20", VA = "0x18B72C020")]
		private NVEXEGYPDWP ZZLGZZGJBQQ(Texture a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[Flags]
	public enum DeduplicateOptions
	{
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		Meshes = 1,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		Textures = 2
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public enum RuntimeTextureCompression
	{
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		LowQuality,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		HighQuality
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class OLYORYCKIUH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public DCQQDVPXHSS MDUQQIINGQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public LLMQZYTPCVY RJXMBLFPJQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public AsyncCoroutineHelper PUJWMOJHVZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public bool KEVCZFKHJCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public AnimationMethod QNPPNJTDGKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public bool AFQKEVEUNAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public DeduplicateOptions RVMKXWGBHXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public bool POUNSWANUTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public GLTFImporterNormals FFRIPIHZEHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public GLTFImporterNormals RCRCGWLPQJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public bool EEDFCYGLQWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public CameraImportOption BENGUDQKTGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public RuntimeTextureCompression ITURHNOWLQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public BlendShapeFrameWeightSetting TUUAIEIEFKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public XNPFEZFVAYZ ELGWSVFWBEW;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public ILogger GSAFKGYCGWW;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xB73D650", Offset = "0xB73C050", VA = "0x18B73D650")]
		public OLYORYCKIUH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public enum CameraImportOption
	{
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		ImportAndActive,
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		ImportAndCameraDisabled
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public enum AnimationMethod
	{
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		Legacy,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		Mecanim,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		MecanimHumanoid
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct ImportProgress
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public bool IsDownloaded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public int NodeTotal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public int NodeLoaded;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public int TextureTotal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public int TextureLoaded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public int BuffersTotal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public int BuffersLoaded;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float DPFLIFGOMMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xB73CE40", Offset = "0xB73B840", VA = "0x18B73CE40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xB73CE70", Offset = "0xB73B870", VA = "0x18B73CE70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public struct ImportStatistics
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public long TriangleCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public long VertexCount;
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public delegate float[] ValuesConvertion(NumericArray data, int frame);
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class GLTFSceneImporter : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public enum ColliderType
		{
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			Box,
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			Mesh,
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			MeshConvex
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		protected struct GLBStream
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public Stream Stream;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public long StartPosition;
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class EIWEOCFGPGR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Texture BZMNHFOXWWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public int WPMEZSEFMAQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public double BUFYYAFNAIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Vector2 GVPRWZNHLDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public double LXYOOPRPYCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Vector2 XOJMVANENPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public int? LVIUCNYGSFU;

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0xB72F350", Offset = "0xB72DD50", VA = "0x18B72F350")]
			public EIWEOCFGPGR()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private struct <<GetInstancesTRS>g__GetAttrAccessorAndAccessorContent|96_0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public AsyncTaskMethodBuilder<MSHGOIDHWYJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public MYCFVKCOBHO accessorId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public bool isPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			private UDJEVNZXQWJ <accessor>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			private TaskAwaiter<VVVKILVSBKC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xB7414A0", Offset = "0xB73FEA0", VA = "0x18B7414A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0xB7419B0", Offset = "0xB7403B0", VA = "0x18B7419B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private struct <>c__DisplayClass114_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			public ABAJRTCMWQH animation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			public VFEMJBHISXA animationCache;
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class XNEVCCGFBEZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public GDYMUWMMRMB VOTLRCTYXDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			public ValuesConvertion FXGZANQDWJT;

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public XNEVCCGFBEZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0xB7444A0", Offset = "0xB742EA0", VA = "0x18B7444A0")]
			internal float[] BSTWTBFFYIP(NumericArray a, int b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class XMPAKHYMYWY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public bool DWMIKUXVMMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			public int RRZTYDTJRZY;

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public XMPAKHYMYWY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xB744130", Offset = "0xB742B30", VA = "0x18B744130")]
			internal float[] BQTFULOGHZD(NumericArray a, int b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class XMUHHOSKIIH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			public float[] TZOCGUHXZDW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			public BlendShapeFrameWeightSetting LLDZNUNMFSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			public XMPAKHYMYWY IYWFXXOWUJJ;

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public XMUHHOSKIIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0xB7443D0", Offset = "0xB742DD0", VA = "0x18B7443D0")]
			internal float[] DBKCKIYTYDE(NumericArray a, int b)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private struct <>c__DisplayClass119_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			public YWWCRAQFFBF mapper;
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class BYGMEPPLASR
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200003C")]
			private struct <<LoadMaterialAsync>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000167")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000168")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000169")]
				public BYGMEPPLASR <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400016A")]
				private RLXWJRYFKUW <def>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400016B")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000177")]
				[Cpp2IlInjected.Address(RVA = "0xB741A20", Offset = "0xB740420", VA = "0x18B741A20", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000178")]
				[Cpp2IlInjected.Address(RVA = "0xB741E40", Offset = "0xB740840", VA = "0x18B741E40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public int HPRNVHRLBQV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public GLTFSceneImporter IRZLODQIRHI;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public BYGMEPPLASR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0xB72EFE0", Offset = "0xB72D9E0", VA = "0x18B72EFE0")]
			[AsyncStateMachine(typeof(<<LoadMaterialAsync>b__0>d))]
			internal Task OGWTPCCCVUZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private sealed class XEUPYKXWUUA
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200003E")]
			private struct <<LoadMeshAsync>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400016F")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000170")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000171")]
				public XEUPYKXWUUA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000172")]
				private MRVNGWGPAZI <def>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000173")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600017B")]
				[Cpp2IlInjected.Address(RVA = "0xB741EA0", Offset = "0xB7408A0", VA = "0x18B741EA0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600017C")]
				[Cpp2IlInjected.Address(RVA = "0xB742450", Offset = "0xB740E50", VA = "0x18B742450", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public int WCILSINTNCV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public GLTFSceneImporter IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public CancellationToken PWKBEQSRYAS;

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public XEUPYKXWUUA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xB744060", Offset = "0xB742A60", VA = "0x18B744060")]
			[AsyncStateMachine(typeof(<<LoadMeshAsync>b__0>d))]
			internal Task GNVGQIMRNHH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class CVGGVCYZJZN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public GLTFSceneImporter IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public GGRQSLPCQYY ALCEECDKYQJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public string WCVHFRMUYEF;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public CVGGVCYZJZN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xB72F1D0", Offset = "0xB72DBD0", VA = "0x18B72F1D0")]
			internal Stream TCPXKAZEDIG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xB72F2C0", Offset = "0xB72DCC0", VA = "0x18B72F2C0")]
			internal void TCVEHHTBMTP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class VENJVEEPTDF
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			private struct <<ConstructNode>g__CreateNodeComponentsAndChilds|0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400017C")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				public VENJVEEPTDF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				public bool onlyMesh;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x4000180")]
				public bool ignoreMesh;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000181")]
				private List<FOKAMTZKDHN>.Enumerator <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000182")]
				private TaskAwaiter<GameObject> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000183")]
				private MRVNGWGPAZI <mesh>5__3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4000184")]
				private Mesh <unityMesh>5__4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
				[Cpp2IlInjected.Token(Token = "0x4000185")]
				private List<double> <weights>5__5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				private TaskAwaiter <>u__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				private SkinnedMeshRenderer <renderer>5__6;

				[Cpp2IlInjected.Token(Token = "0x6000183")]
				[Cpp2IlInjected.Address(RVA = "0xB73F7C0", Offset = "0xB73E1C0", VA = "0x18B73F7C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000184")]
				[Cpp2IlInjected.Address(RVA = "0xB741440", Offset = "0xB73FE40", VA = "0x18B741440", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public GameObject XIOUEPXDPIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public SIDFNDXEBQO CANSHDFJKQC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public GLTFSceneImporter IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public CancellationToken PWKBEQSRYAS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public int VPVEIUYLOPA;

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public VENJVEEPTDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xB743F40", Offset = "0xB742940", VA = "0x18B743F40")]
			[AsyncStateMachine(typeof(<<ConstructNode>g__CreateNodeComponentsAndChilds|0>d))]
			internal Task IWIDJTFIWEA(bool a = false, bool b = false)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0xB743ED0", Offset = "0xB7428D0", VA = "0x18B743ED0")]
			internal Material IFNOGAMLDGI(OKMUISONBMQ a)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private struct <BuildAnimationSamplers>d__110 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public ABAJRTCMWQH animation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public int animationId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			private Dictionary<int, string> <typeMap>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			private AnimationSamplerCacheData[] <samplers>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			private Dictionary<string, List<MSHGOIDHWYJ>> <samplersByType>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			private int <i>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			private HEQRHAMLLIQ <samplerDef>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			private TaskAwaiter<VVVKILVSBKC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xB7444E0", Offset = "0xB742EE0", VA = "0x18B7444E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xB745190", Offset = "0xB743B90", VA = "0x18B745190", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private struct <CheckMimeTypeAndLoadImage>d__166 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public bool markGpuOnly;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public LIJTJBKAUDO image;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public NativeArray<byte> data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public Texture2D texture;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xB7451F0", Offset = "0xB743BF0", VA = "0x18B7451F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xB7459C0", Offset = "0xB7443C0", VA = "0x18B7459C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private struct <ConstructBuffer>d__100 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public int bufferIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public WCYSICVUSPP buffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			private TaskAwaiter<Stream> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xB746040", Offset = "0xB744A40", VA = "0x18B746040", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xB746830", Offset = "0xB745230", VA = "0x18B746830", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct <ConstructBufferData>d__99 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public SIDFNDXEBQO node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			private List<FOKAMTZKDHN>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xB745A30", Offset = "0xB744430", VA = "0x18B745A30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xB745FE0", Offset = "0xB7449E0", VA = "0x18B745FE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct <ConstructClip>d__114 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public AsyncTaskMethodBuilder<AnimationClip> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			public int animationId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			private <>c__DisplayClass114_0 <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public Transform root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			private XNEVCCGFBEZ <>8__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			private AnimationClip <clip>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			private int[] <nodeIds>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			private XTSONFNBMEP <pointerImportContext>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			private List<KKMAFFKJDUL>.Enumerator <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			private KKMAFFKJDUL <channel>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			private bool <usesPointer>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			private AnimationSamplerCacheData <samplerCache>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			private GLTFAnimationChannelPath <path>5__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			private int[] <>7__wrap9;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private int <>7__wrap10;

			[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			private int <nodeId>5__12;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			private TaskAwaiter<GameObject> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xB746890", Offset = "0xB745290", VA = "0x18B746890", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xB749E90", Offset = "0xB748890", VA = "0x18B749E90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[CompilerGenerated]
		private struct <ConstructImage>d__164 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public int imageCacheIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public LIJTJBKAUDO image;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public bool markGpuOnly;

			[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public bool isLinear;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public bool isNormal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			private Stream <stream>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xB74A600", Offset = "0xB749000", VA = "0x18B74A600", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xB74A9B0", Offset = "0xB7493B0", VA = "0x18B74A9B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct <ConstructImageBuffer>d__165 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public QSDNGVTLXBY texture;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			public int textureIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			private Stream[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			private TaskAwaiter<Stream> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xB749F00", Offset = "0xB748900", VA = "0x18B749F00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xB74A5A0", Offset = "0xB748FA0", VA = "0x18B74A5A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private struct <ConstructLods>d__117 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public SIDFNDXEBQO node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public GameObject nodeObj;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public int nodeIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			private ROOCTVXZTNL <lodsExtension>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			private LOD[] <lods>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			private List<double> <lodCoverage>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			private GameObject <lodGroupNodeObj>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			private List<Renderer> <firstLodChildRenderers>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			private LODGroup <lodGroup>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			private int <i>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xB74AA10", Offset = "0xB749410", VA = "0x18B74AA10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xB74B5C0", Offset = "0xB749FC0", VA = "0x18B74B5C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private struct <ConstructMaterial>d__119 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public RLXWJRYFKUW def;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			private <>c__DisplayClass119_0 <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			public int materialIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			private DOHCDIFDITJ <mrMapper>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			private bool <KHR_materials_ior>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			private bool <KHR_materials_transmission>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x52")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			private bool <KHR_materials_volume>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x53")]
			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			private bool <KHR_materials_iridescence>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			private bool <KHR_materials_specular>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x55")]
			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			private bool <KHR_materials_clearcoat>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x56")]
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			private bool <KHR_materials_emissive_strength>5__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0x57")]
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			private bool <KHR_materials_sheen>5__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			private bool <KHR_materials_anisotropy>5__11;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			private QDMSLCDGDZM <sgMapper>5__12;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			private QSTZXZAGEDP <unlitMapper>5__13;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			private ORMTTIUKHHW <sheenMapper>5__14;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			private PZMDOBDGEQR <anisotropyMapper>5__15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			private UWRZGZRZGGN <transmissionMapper>5__16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			private HTEAGGCTQKL <volumeMapper>5__17;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			private KEEJJWJQDOD <iridescenceMapper>5__18;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			private TUDJSCYNFPM <specularMapper>5__19;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			private EIANFJEMDQJ <clearcoatMapper>5__20;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			private SDZYUGEIYBO <uniformMapper>5__21;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			private TXRBWBBJWFB <pbr>5__22;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			private AXTSRHKTJDS <textureId>5__23;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			private HDYNHITMCGR <specGloss>5__24;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			private KHR_materials_sheen <sheen>5__25;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			private TaskAwaiter<EIWEOCFGPGR> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			private KHR_materials_anisotropy <anisotropy>5__26;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x4000200")]
			private KHR_materials_transmission <transmission>5__27;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x4000201")]
			private KHR_materials_volume <volume>5__28;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x4000202")]
			private KHR_materials_iridescence <iridescence>5__29;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000203")]
			private KHR_materials_specular <specular>5__30;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x4000204")]
			private KHR_materials_clearcoat <clearcoat>5__31;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x4000205")]
			private PSRCEZISYGU <clearcoatNormalMapper>5__32;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xB74B620", Offset = "0xB74A020", VA = "0x18B74B620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xB753400", Offset = "0xB751E00", VA = "0x18B753400", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct <ConstructMesh>d__133 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			public int meshIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			public MRVNGWGPAZI mesh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			private XONXWXBCMMT <meshCache>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			private BUQDIJQVFTU <unityData>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400020E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			private int <i>5__4;

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xB754BB0", Offset = "0xB7535B0", VA = "0x18B754BB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xB7555E0", Offset = "0xB753FE0", VA = "0x18B7555E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct <ConstructMeshAttributes>d__145 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000211")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000212")]
			public FAPFUECQVDQ meshId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public MRVNGWGPAZI mesh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000215")]
			private int <meshIndex>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			private int <i>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000217")]
			private OKMUISONBMQ <primitive>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xB753460", Offset = "0xB751E60", VA = "0x18B753460", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xB753AA0", Offset = "0xB7524A0", VA = "0x18B753AA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct <ConstructMeshTargetsPrepareBuffers>d__141 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000219")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400021B")]
			public OKMUISONBMQ primitive;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			public int meshIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			public int primitiveIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400021F")]
			private List<Dictionary<string, MSHGOIDHWYJ>> <newTargets>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			private int <i>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			private Dictionary<string, MYCFVKCOBHO>.Enumerator <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000222")]
			private KeyValuePair<string, MYCFVKCOBHO> <targetAttribute>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000223")]
			private int <bufferID>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000224")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			private TaskAwaiter<VVVKILVSBKC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xB753B00", Offset = "0xB752500", VA = "0x18B753B00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xB754B50", Offset = "0xB753550", VA = "0x18B754B50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct <ConstructNode>d__98 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000226")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000227")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000228")]
			public SIDFNDXEBQO node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000229")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400022A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400022B")]
			public int nodeIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400022C")]
			private VENJVEEPTDF <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400022D")]
			private (Vector3, Quaternion, Vector3)[] <instancesTRS>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400022E")]
			private TaskAwaiter<(Vector3, Quaternion, Vector3)[]> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400022F")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000230")]
			private bool <shouldBeVisible>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000231")]
			private GameObject <instanceParentNode>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000232")]
			private int <i>5__5;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xB755640", Offset = "0xB754040", VA = "0x18B755640", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xB7567E0", Offset = "0xB7551E0", VA = "0x18B7567E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private struct <ConstructPrimitiveAttributes>d__146 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000233")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000234")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000235")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000236")]
			public int meshIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000237")]
			public int primitiveIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000238")]
			public OKMUISONBMQ primitive;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000239")]
			private XONXWXBCMMT.BSBRXYHIMIX <primData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400023A")]
			private Dictionary<string, MYCFVKCOBHO>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400023B")]
			private KeyValuePair<string, MYCFVKCOBHO> <attributePair>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400023C")]
			private FRJLFWBSTDT <sparse>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400023D")]
			private TaskAwaiter<VVVKILVSBKC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400023E")]
			private MSHGOIDHWYJ <sparseValues>5__6;

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xB75A7A0", Offset = "0xB7591A0", VA = "0x18B75A7A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xB75B8E0", Offset = "0xB75A2E0", VA = "0x18B75B8E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct <ConstructScene>d__101 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400023F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000240")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000241")]
			public TJCMXEZHJBP scene;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000242")]
			public bool showSceneObj;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000243")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000244")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000245")]
			private GameObject <sceneObj>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000246")]
			private object <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000247")]
			private int <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000248")]
			private Transform[] <nodeTransforms>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000249")]
			private int <i>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400024A")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400024B")]
			private List<AnimationClip> <constructedClips>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400024C")]
			private TaskAwaiter<AnimationClip> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400024D")]
			private Awaitable.Awaiter <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xB75B940", Offset = "0xB75A340", VA = "0x18B75B940", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xB75C660", Offset = "0xB75B060", VA = "0x18B75C660", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private struct <ConstructTexture>d__173 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400024F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000250")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000251")]
			public int textureIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000252")]
			public QSDNGVTLXBY texture;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000253")]
			public bool markGpuOnly;

			[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
			[Cpp2IlInjected.Token(Token = "0x4000254")]
			public bool isLinear;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
			[Cpp2IlInjected.Token(Token = "0x4000255")]
			public bool isNormal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000256")]
			private int <sourceId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000257")]
			private LIJTJBKAUDO <image>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000258")]
			private bool <isFirstInstance>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000259")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xB75C6C0", Offset = "0xB75B0C0", VA = "0x18B75C6C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xB75D940", Offset = "0xB75C340", VA = "0x18B75D940", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		[CompilerGenerated]
		private struct <ConstructUnityMesh>d__139 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400025B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400025C")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400025D")]
			public int meshIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400025E")]
			public string meshName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400025F")]
			public BUQDIJQVFTU unityMeshData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000260")]
			private Mesh <mesh>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000261")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xB75D9A0", Offset = "0xB75C3A0", VA = "0x18B75D9A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xB75EAC0", Offset = "0xB75D4C0", VA = "0x18B75EAC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private struct <ConstructUnityTexture>d__167 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000262")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000263")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000264")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000265")]
			public bool isLinear;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000266")]
			public LIJTJBKAUDO image;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000267")]
			public int imageCacheIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000268")]
			public Stream stream;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000269")]
			public bool markGpuOnly;

			[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
			[Cpp2IlInjected.Token(Token = "0x400026A")]
			private bool <convertToDxt5nmFormat>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400026B")]
			private Texture2D <texture>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400026C")]
			private Texture2D <newTextureObject>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400026D")]
			private VVVKILVSBKC <bufferView>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400026E")]
			private TaskAwaiter<VVVKILVSBKC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400026F")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000270")]
			private TaskAwaiter<Texture2D> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000271")]
			private MemoryStream <memoryStream>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000272")]
			private NativeArray<byte> <memoryStreamData>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000273")]
			private byte[] <buffer>5__8;

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xB75EB20", Offset = "0xB75D520", VA = "0x18B75EB20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xB760610", Offset = "0xB75F010", VA = "0x18B760610", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[CompilerGenerated]
		private struct <CreateMaterials>d__132 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000274")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000275")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000276")]
			public OKMUISONBMQ primitive;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000277")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000278")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xB760D00", Offset = "0xB75F700", VA = "0x18B760D00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xB760FA0", Offset = "0xB75F9A0", VA = "0x18B760FA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		[CompilerGenerated]
		private struct <CreateMeshMaterials>d__134 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000279")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400027A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400027B")]
			public MRVNGWGPAZI mesh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400027C")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400027D")]
			private int <i>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400027E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0xB761000", Offset = "0xB75FA00", VA = "0x18B761000", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0xB761200", Offset = "0xB75FC00", VA = "0x18B761200", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[CompilerGenerated]
		private struct <CreateNotReferencedTexture>d__158 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400027F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000280")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000281")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000282")]
			public int index;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000283")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xB761260", Offset = "0xB75FC60", VA = "0x18B761260", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xB7616E0", Offset = "0xB7600E0", VA = "0x18B7616E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private struct <FromTextureInfo>d__159 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000284")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000285")]
			public AsyncTaskMethodBuilder<EIWEOCFGPGR> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000286")]
			public ZWTHYTPYMLD textureInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000287")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000288")]
			public bool isNormal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000289")]
			private EIWEOCFGPGR <result>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400028A")]
			private AXTSRHKTJDS <textureId>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400028B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xB761740", Offset = "0xB760140", VA = "0x18B761740", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0xB761D00", Offset = "0xB760700", VA = "0x18B761D00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000058")]
		[CompilerGenerated]
		private struct <GetBufferData>d__93 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400028C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400028D")]
			public AsyncTaskMethodBuilder<VVVKILVSBKC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400028E")]
			public NXEAZIBWYCJ bufferId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400028F")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000290")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0xB761D70", Offset = "0xB760770", VA = "0x18B761D70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xB762000", Offset = "0xB760A00", VA = "0x18B762000", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000059")]
		[CompilerGenerated]
		private struct <GetInstancesTRS>d__96 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000291")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000292")]
			public AsyncTaskMethodBuilder<(Vector3, Quaternion, Vector3)[]> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000293")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000294")]
			public SIDFNDXEBQO node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000295")]
			private MSHGOIDHWYJ <positionsAttr>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000296")]
			private MSHGOIDHWYJ <rotationAttr>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000297")]
			private MSHGOIDHWYJ <scaleAttr>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000298")]
			private EXT_mesh_gpu_instancing <extMeshGPUInstancing>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000299")]
			private int <instancesCount>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400029A")]
			private TaskAwaiter<MSHGOIDHWYJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xB762070", Offset = "0xB760A70", VA = "0x18B762070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0xB762CC0", Offset = "0xB7616C0", VA = "0x18B762CC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private struct <GetNode>d__95 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400029B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400029C")]
			public AsyncTaskMethodBuilder<GameObject> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400029D")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400029E")]
			public int nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400029F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002A0")]
			private object <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002A1")]
			private SIDFNDXEBQO <node>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002A2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002A3")]
			private ROOCTVXZTNL <lodsExtension>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002A4")]
			private int <i>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40002A5")]
			private TaskAwaiter<GameObject> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40002A6")]
			private Awaitable.Awaiter <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0xB762D30", Offset = "0xB761730", VA = "0x18B762D30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0xB763BC0", Offset = "0xB7625C0", VA = "0x18B763BC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private struct <LoadJson>d__87 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002A7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002A8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002A9")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002AA")]
			public string jsonFilePath;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002AB")]
			private CVGGVCYZJZN <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002AC")]
			private TaskAwaiter<Stream> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002AD")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0xB763C30", Offset = "0xB762630", VA = "0x18B763C30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0xB764370", Offset = "0xB762D70", VA = "0x18B764370", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private struct <LoadMaterialAsync>d__85 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002AE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002AF")]
			public AsyncTaskMethodBuilder<Material> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002B0")]
			public int materialIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002B1")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002B2")]
			private BYGMEPPLASR <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002B3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xB7643D0", Offset = "0xB762DD0", VA = "0x18B7643D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0xB7646D0", Offset = "0xB7630D0", VA = "0x18B7646D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		[CompilerGenerated]
		private struct <LoadMeshAsync>d__86 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002B5")]
			public AsyncTaskMethodBuilder<Mesh> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002B6")]
			public int meshIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002B7")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002B8")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002B9")]
			private XEUPYKXWUUA <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002BA")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0xB764740", Offset = "0xB763140", VA = "0x18B764740", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0xB764A60", Offset = "0xB763460", VA = "0x18B764A60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		[CompilerGenerated]
		private struct <LoadSceneAsync>d__81 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002BB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002BC")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002BD")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002BE")]
			public IProgress<ImportProgress> progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002BF")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002C0")]
			public int sceneIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40002C1")]
			public bool showSceneObj;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002C2")]
			public Action<GameObject, ExceptionDispatchInfo> onLoadComplete;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002C3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002C4")]
			private YieldAwaitable.YieldAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xB764AD0", Offset = "0xB7634D0", VA = "0x18B764AD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0xB765B40", Offset = "0xB764540", VA = "0x18B765B40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private struct <LoadUnreferencedAssetsAsync>d__82 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002C6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002C7")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002C8")]
			private int <i>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002C9")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002CA")]
			private RLXWJRYFKUW <def>5__3;

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xB765BA0", Offset = "0xB7645A0", VA = "0x18B765BA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xB766010", Offset = "0xB764A10", VA = "0x18B766010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000060")]
		[CompilerGenerated]
		private struct <PreparePrimitiveAttributes>d__144 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002CB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002CC")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002CD")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002CE")]
			private int <meshIndex>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002CF")]
			private MRVNGWGPAZI <gltfMesh>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002D0")]
			private int <i>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002D1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0xB766070", Offset = "0xB764A70", VA = "0x18B766070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0xB766710", Offset = "0xB765110", VA = "0x18B766710", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private struct <SetupBones>d__153 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002D2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002D3")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002D4")]
			public VOBIMAAHYOP skin;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002D5")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002D6")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002D7")]
			public SkinnedMeshRenderer renderer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002D8")]
			private int <boneCount>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002D9")]
			private Transform[] <bones>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002DA")]
			private float4x4[] <gltfBindPoses>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002DB")]
			private Matrix4x4[] <bindPoses>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			private TaskAwaiter<VVVKILVSBKC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			private int <i>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40002DE")]
			private TaskAwaiter<GameObject> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0xB766770", Offset = "0xB765170", VA = "0x18B766770", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xB767250", Offset = "0xB765C50", VA = "0x18B767250", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		[CompilerGenerated]
		private struct <SetupLoad>d__107 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002DF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002E0")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002E1")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002E2")]
			public Func<Task> callback;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002E3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0xB7672B0", Offset = "0xB765CB0", VA = "0x18B7672B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xB7678B0", Offset = "0xB7662B0", VA = "0x18B7678B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		[CompilerGenerated]
		private struct <YieldOnTimeoutAndThrowOnLowMemory>d__108 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002E4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002E5")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002E6")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002E7")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xB767B20", Offset = "0xB766520", VA = "0x18B767B20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xB767D40", Offset = "0xB766740", VA = "0x18B767D40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private struct <_LoadScene>d__90 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002E8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002E9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002EA")]
			public int sceneIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002EB")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002EC")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002ED")]
			public bool showSceneObj;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			private TJCMXEZHJBP <scene>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xB767DA0", Offset = "0xB7667A0", VA = "0x18B767DA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xB768A60", Offset = "0xB767460", VA = "0x18B768A60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public int REGLWCVFOBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public int TOARGLCBZKR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private bool XADXQTTLUAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private bool FSTQHQALCAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private Dictionary<Stream, NativeArray<byte>> MWMXLKVEBBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public bool WBUHSWOMFLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public bool AWANMWKBEMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public bool JNOUPIEERMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x63")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public bool FVBHIYLNLSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public bool DUQXZECPOSF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public ImportStatistics GFEHRHNOMKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		protected OLYORYCKIUH IHVERHHVLZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		protected MZTQPBYWDFS SZVZLGWTPIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		protected GameObject XKJCCJZTOFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		protected readonly RLXWJRYFKUW TBEMYQMWOVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		internal ZLGIXFBPRYL QVAZGKYYNXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		protected string FHOHBQDUESP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		protected GLBStream VCMKCQNIRLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		protected GZYGZQSIZFV MYVDUEQNHVM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		protected MTYCYMHVAQI UMWONTTITPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		protected bool JHDSLCNBTJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		protected ImportProgress CQBDMSXGYOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		protected IProgress<ImportProgress> WMXBZLUQPJT;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static ILogger NJTUYZKPNIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		protected ColorSpace ELBUEUPMYXY;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		internal static List<Texture> IYLLCZYAXNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private Dictionary<int, int> GLCIFXUVOAS;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool VENVGJTODWK
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xB733F50", Offset = "0xB732950", VA = "0x18B733F50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xCD8BE0", Offset = "0xCD75E0", VA = "0x180CD8BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public GZYGZQSIZFV XJMGIEKJBLY
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xEE8200", Offset = "0xEE6C00", VA = "0x180EE8200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Transform DMOCLNBQWAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xCD8610", Offset = "0xCD7010", VA = "0x180CD8610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public GameObject BDWGKHGWQSV
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CE0", Offset = "0xCD56E0", VA = "0x180CD6CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0xCD8620", Offset = "0xCD7020", VA = "0x180CD8620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private AnimationClip[] MGOSJIFZPVJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xCDF4B0", Offset = "0xCDDEB0", VA = "0x180CDF4B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ColliderType PNAUMWTNEQO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xD05F80", Offset = "0xD04980", VA = "0x180D05F80")]
			[CompilerGenerated]
			get
			{
				return default(ColliderType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xDECAD0", Offset = "0xDEB4D0", VA = "0x180DECAD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public string BJSEBXZLGJZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DA0", Offset = "0xCD57A0", VA = "0x180CD6DA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DD0", Offset = "0xCD57D0", VA = "0x180CD6DD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public GameObject DOIOCQWBQDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xCDA180", Offset = "0xCD8B80", VA = "0x180CDA180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public ZUJCWCYEBVT[] UANDQKVDKDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xB738490", Offset = "0xB736E90", VA = "0x18B738490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Texture2D[] EQMFYSXGKLC
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xB73B0B0", Offset = "0xB739AB0", VA = "0x18B73B0B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public ZLGIXFBPRYL[] GEIVRSGGRNZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xB738A30", Offset = "0xB737430", VA = "0x18B738A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public VFEMJBHISXA[] TXRAJNVCXAS
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xB734110", Offset = "0xB732B10", VA = "0x18B734110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public XONXWXBCMMT[] FTLCKNTYVMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0xB73BD20", Offset = "0xB73A720", VA = "0x18B73BD20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public List<UnityEngine.Object> AKKLFNVWBTM
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DE0", Offset = "0xCD57E0", VA = "0x180CD6DE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected XNPFEZFVAYZ ODQQNFONYER
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xB73C190", Offset = "0xB73AB90", VA = "0x18B73C190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xB73CCF0", Offset = "0xB73B6F0", VA = "0x18B73CCF0")]
		public GLTFSceneImporter(string gltfFileName, OLYORYCKIUH options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xB73CD40", Offset = "0xB73B740", VA = "0x18B73CD40")]
		public GLTFSceneImporter(Stream gltfStream, OLYORYCKIUH options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xB73CA30", Offset = "0xB73B430", VA = "0x18B73CA30")]
		private GLTFSceneImporter(OLYORYCKIUH options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xB73B0D0", Offset = "0xB739AD0", VA = "0x18B73B0D0")]
		private NativeArray<byte> UUYJXLBRCOS(Stream a)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xB73C2E0", Offset = "0xB73ACE0", VA = "0x18B73C2E0")]
		private void YYKOMKSNEPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xB732790", Offset = "0xB731190", VA = "0x18B732790", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xB73BA40", Offset = "0xB73A440", VA = "0x18B73BA40")]
		[AsyncStateMachine(typeof(<LoadSceneAsync>d__81))]
		public Task WEQBXWETJKK(int a = -1, bool b = true, [Optional] Action<GameObject, ExceptionDispatchInfo> c, [Optional] CancellationToken d, [Optional] IProgress<ImportProgress> e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xB734970", Offset = "0xB733370", VA = "0x18B734970")]
		[AsyncStateMachine(typeof(<LoadUnreferencedAssetsAsync>d__82))]
		private Task JCYOJKIGOJH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xB73B930", Offset = "0xB73A330", VA = "0x18B73B930", Slot = "5")]
		[AsyncStateMachine(typeof(<LoadMaterialAsync>d__85))]
		public virtual Task<Material> VRVVFILVWEF(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xB734550", Offset = "0xB732F50", VA = "0x18B734550", Slot = "6")]
		[AsyncStateMachine(typeof(<LoadMeshAsync>d__86))]
		public virtual Task<Mesh> JADGSNKDESV(int a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xB7384B0", Offset = "0xB736EB0", VA = "0x18B7384B0")]
		[AsyncStateMachine(typeof(<LoadJson>d__87))]
		private Task QZTGIWEJCMI(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xB7369C0", Offset = "0xB7353C0", VA = "0x18B7369C0")]
		private void PQIIIARSDNT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xB738830", Offset = "0xB737230", VA = "0x18B738830")]
		[AsyncStateMachine(typeof(<_LoadScene>d__90))]
		protected Task RKVTAVZVJFL(int a = -1, bool b = true, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xB734200", Offset = "0xB732C00", VA = "0x18B734200")]
		private void INEMOMLSQFN(TJCMXEZHJBP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xB733E70", Offset = "0xB732870", VA = "0x18B733E70")]
		public NativeArray<byte> HORNHDJSXLL(OUKRSZNVFOZ a)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xB734680", Offset = "0xB733080", VA = "0x18B734680")]
		[AsyncStateMachine(typeof(<GetBufferData>d__93))]
		private Task<VVVKILVSBKC> JBYMXUJCBOU(NXEAZIBWYCJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xB73ACC0", Offset = "0xB7396C0", VA = "0x18B73ACC0")]
		private float SDOWIGDCXWX(List<double> a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xB732650", Offset = "0xB731050", VA = "0x18B732650")]
		[AsyncStateMachine(typeof(<GetNode>d__95))]
		private Task<GameObject> DZDLTAFHLTM(int a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xB73AE90", Offset = "0xB739890", VA = "0x18B73AE90")]
		[AsyncStateMachine(typeof(<GetInstancesTRS>d__96))]
		private Task<(Vector3, Quaternion, Vector3)[]> TFTLNQXXOAB(SIDFNDXEBQO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xB730800", Offset = "0xB72F200", VA = "0x18B730800")]
		private bool BUJIJETFPKG(SIDFNDXEBQO a, GameObject b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xB731B20", Offset = "0xB730520", VA = "0x18B731B20", Slot = "7")]
		[AsyncStateMachine(typeof(<ConstructNode>d__98))]
		protected virtual Task CTWNVTGTFSP(SIDFNDXEBQO a, int b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xB736760", Offset = "0xB735160", VA = "0x18B736760")]
		[AsyncStateMachine(typeof(<ConstructBufferData>d__99))]
		private Task PLJQSXDXYCJ(SIDFNDXEBQO a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xB737160", Offset = "0xB735B60", VA = "0x18B737160")]
		[AsyncStateMachine(typeof(<ConstructBuffer>d__100))]
		protected Task PRRAJGBFFCF(WCYSICVUSPP a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xB736540", Offset = "0xB734F40", VA = "0x18B736540", Slot = "8")]
		[AsyncStateMachine(typeof(<ConstructScene>d__101))]
		protected virtual Task PCSKBCANBMJ(TJCMXEZHJBP a, bool b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xB733C20", Offset = "0xB732620", VA = "0x18B733C20", Slot = "9")]
		protected virtual VVVKILVSBKC GNKXXVHHVMQ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xB731C60", Offset = "0xB730660", VA = "0x18B731C60")]
		private void Cleanup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xB734A40", Offset = "0xB733440", VA = "0x18B734A40")]
		private void JDCCDMHCTWX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xB73AFC0", Offset = "0xB7399C0", VA = "0x18B73AFC0")]
		[AsyncStateMachine(typeof(<SetupLoad>d__107))]
		private Task TOIMAGXJDEX(Func<Task> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xB734130", Offset = "0xB732B30", VA = "0x18B734130")]
		[AsyncStateMachine(typeof(<YieldOnTimeoutAndThrowOnLowMemory>d__108))]
		protected Task IIFIDXHFFRO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xB732FA0", Offset = "0xB7319A0", VA = "0x18B732FA0")]
		private static string FFWQINIMSLP(Transform a, Transform b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xB73C570", Offset = "0xB73AF70", VA = "0x18B73C570", Slot = "10")]
		[AsyncStateMachine(typeof(<BuildAnimationSamplers>d__110))]
		protected virtual Task ZPINEZGXRAB(ABAJRTCMWQH a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xB733150", Offset = "0xB731B50", VA = "0x18B733150")]
		protected void FPFRNMCMSQP(AnimationClip a, string b, string[] c, NumericArray d, NumericArray e, InterpolationType f, Type g, ValuesConvertion h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xB72FF50", Offset = "0xB72E950", VA = "0x18B72FF50")]
		private void ALINVBCICMA(Keyframe[] a, int b, InterpolationType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xB736360", Offset = "0xB734D60", VA = "0x18B736360")]
		private static float OSQOFZSRADC(Keyframe[] a, int b, bool c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xB737270", Offset = "0xB735C70", VA = "0x18B737270")]
		[AsyncStateMachine(typeof(<ConstructClip>d__114))]
		protected Task<AnimationClip> PVCQAYVOFTH(Transform a, int b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xB730280", Offset = "0xB72EC80", VA = "0x18B730280")]
		private bool BJPSLXITIFG(GameObject a, SIDFNDXEBQO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xB731F30", Offset = "0xB730930", VA = "0x18B731F30")]
		private bool DVURARKILLE(GameObject a, SIDFNDXEBQO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xB7385B0", Offset = "0xB736FB0", VA = "0x18B7385B0")]
		[AsyncStateMachine(typeof(<ConstructLods>d__117))]
		private Task RKCWYXWBDJV(GZYGZQSIZFV a, GameObject b, SIDFNDXEBQO c, int d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xB73BD40", Offset = "0xB73A740", VA = "0x18B73BD40", Slot = "11")]
		[AsyncStateMachine(typeof(<ConstructMaterial>d__119))]
		protected virtual Task YBFEWUBFLVQ(RLXWJRYFKUW a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xB737500", Offset = "0xB735F00", VA = "0x18B737500", Slot = "12")]
		protected virtual Task QOSOTIBMSOC(RLXWJRYFKUW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xB7386F0", Offset = "0xB7370F0", VA = "0x18B7386F0", Slot = "13")]
		protected virtual GEAORXGMOBL RKGPBHGGACX(ZWTHYTPYMLD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xB733FD0", Offset = "0xB7329D0", VA = "0x18B733FD0", Slot = "14")]
		protected virtual KHR_materials_emissive_strength HUEEYCBAPWI(RLXWJRYFKUW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xB734D10", Offset = "0xB733710", VA = "0x18B734D10", Slot = "15")]
		protected virtual KHR_materials_transmission LMSDKQUZNBE(RLXWJRYFKUW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xB73B360", Offset = "0xB739D60", VA = "0x18B73B360", Slot = "16")]
		protected virtual KHR_materials_sheen VLMDVHBNXSX(RLXWJRYFKUW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xB730140", Offset = "0xB72EB40", VA = "0x18B730140", Slot = "17")]
		protected virtual KHR_materials_anisotropy BFQRRQMZEVU(RLXWJRYFKUW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xB73AD50", Offset = "0xB739750", VA = "0x18B73AD50", Slot = "18")]
		protected virtual KHR_materials_dispersion SSGOOVATJDC(RLXWJRYFKUW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xB733AE0", Offset = "0xB7324E0", VA = "0x18B733AE0", Slot = "19")]
		protected virtual KHR_materials_volume GCAJVJULOCQ(RLXWJRYFKUW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xB732BD0", Offset = "0xB7315D0", VA = "0x18B732BD0", Slot = "20")]
		protected virtual KHR_materials_ior EOGLRKHKWLS(RLXWJRYFKUW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xB7356C0", Offset = "0xB7340C0", VA = "0x18B7356C0", Slot = "21")]
		protected virtual KHR_materials_iridescence MWRVRVIFBDE(RLXWJRYFKUW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xB735F30", Offset = "0xB734930", VA = "0x18B735F30", Slot = "22")]
		protected virtual KHR_materials_specular ONMVQZBHEIP(RLXWJRYFKUW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xB736880", Offset = "0xB735280", VA = "0x18B736880", Slot = "23")]
		protected virtual KHR_materials_clearcoat PPKKGDPIFIU(RLXWJRYFKUW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xB736670", Offset = "0xB735070", VA = "0x18B736670")]
		[AsyncStateMachine(typeof(<CreateMaterials>d__132))]
		private Task PFEDOPWTZDS(OKMUISONBMQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xB7373D0", Offset = "0xB735DD0", VA = "0x18B7373D0", Slot = "24")]
		[AsyncStateMachine(typeof(<ConstructMesh>d__133))]
		protected virtual Task QGEIOFTOQTU(MRVNGWGPAZI a, int b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xB73ABC0", Offset = "0xB7395C0", VA = "0x18B73ABC0")]
		[AsyncStateMachine(typeof(<CreateMeshMaterials>d__134))]
		private Task SCUQCFEAKPV(MRVNGWGPAZI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xB736070", Offset = "0xB734A70", VA = "0x18B736070")]
		private static uint[] OOCLWDNTGZG(MRVNGWGPAZI a, [Out] uint b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xB731CB0", Offset = "0xB7306B0", VA = "0x18B731CB0")]
		protected void DNIEEQQMHMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xB735800", Offset = "0xB734200", VA = "0x18B735800")]
		protected void MWVUFEFACDV(Mesh a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xB739950", Offset = "0xB738350", VA = "0x18B739950")]
		private BUQDIJQVFTU RYNVOHMUOSO(MRVNGWGPAZI a, int b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xB73C1B0", Offset = "0xB73ABB0", VA = "0x18B73C1B0")]
		[AsyncStateMachine(typeof(<ConstructUnityMesh>d__139))]
		protected Task YPPRQGWQNUF(BUQDIJQVFTU a, int b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xB73C690", Offset = "0xB73B090", VA = "0x18B73C690")]
		private void ZWFOCBSVWPM(BUQDIJQVFTU a, int b, Mesh c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xB732E70", Offset = "0xB731870", VA = "0x18B732E70", Slot = "25")]
		[AsyncStateMachine(typeof(<ConstructMeshTargetsPrepareBuffers>d__141))]
		protected virtual Task EZPWVKSFRYC(OKMUISONBMQ a, int b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xB7308F0", Offset = "0xB72F2F0", VA = "0x18B7308F0", Slot = "26")]
		protected virtual void CAGESOLCGOM(OKMUISONBMQ a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xB736B00", Offset = "0xB735500", VA = "0x18B736B00")]
		private void PQMQOPNFHUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xB73C490", Offset = "0xB73AE90", VA = "0x18B73C490")]
		[AsyncStateMachine(typeof(<PreparePrimitiveAttributes>d__144))]
		private Task ZMHWOUHYGXV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xB73B6D0", Offset = "0xB73A0D0", VA = "0x18B73B6D0")]
		[AsyncStateMachine(typeof(<ConstructMeshAttributes>d__145))]
		private Task VOSDLQRWFID(MRVNGWGPAZI a, FAPFUECQVDQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xB73BE40", Offset = "0xB73A840", VA = "0x18B73BE40", Slot = "27")]
		[AsyncStateMachine(typeof(<ConstructPrimitiveAttributes>d__146))]
		protected virtual Task YBHDHENJCEN(OKMUISONBMQ a, int b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xB738A50", Offset = "0xB737450", VA = "0x18B738A50")]
		protected void RYIYALFARHU(XONXWXBCMMT.BSBRXYHIMIX a, BUQDIJQVFTU b, uint c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xB73B4A0", Offset = "0xB739EA0", VA = "0x18B73B4A0")]
		private void VMAEPRREVZW(Dictionary<string, MSHGOIDHWYJ> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xB732490", Offset = "0xB730E90", VA = "0x18B732490")]
		protected MeshTopology DZDLRDORUUH(DrawMode a)
		{
			return default(MeshTopology);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xB735A70", Offset = "0xB734470", VA = "0x18B735A70")]
		private void NGCMZADQRBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xB738350", Offset = "0xB736D50", VA = "0x18B738350", Slot = "28")]
		[AsyncStateMachine(typeof(<SetupBones>d__153))]
		protected virtual Task QTDLIEEUBVA(VOBIMAAHYOP a, SkinnedMeshRenderer b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xB734E50", Offset = "0xB733850", VA = "0x18B734E50")]
		private void LQBWUVLUOBX(Vector4[] a, Vector4[] b, BoneWeight[] c, uint d = 0u)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xB738950", Offset = "0xB737350", VA = "0x18B738950")]
		[AsyncStateMachine(typeof(<CreateNotReferencedTexture>d__158))]
		private Task RSUOFSXBRWL(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xB734BD0", Offset = "0xB7335D0", VA = "0x18B734BD0")]
		[AsyncStateMachine(typeof(<FromTextureInfo>d__159))]
		private Task<EIWEOCFGPGR> KIHFYUZLIPX(ZWTHYTPYMLD a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0xB73BB80", Offset = "0xB73A580", VA = "0x18B73BB80")]
		private static int WQDGRSHPWWP(byte[] a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xB73A880", Offset = "0xB739280", VA = "0x18B73A880")]
		private Dictionary<int, int> SAAJGJIJWWR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xB731850", Offset = "0xB730250", VA = "0x18B731850")]
		private void CBNZMZXFIDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xB734790", Offset = "0xB733190", VA = "0x18B734790")]
		private Stream JCOKESWISDR(LIJTJBKAUDO a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xB7306C0", Offset = "0xB72F0C0", VA = "0x18B7306C0")]
		[AsyncStateMachine(typeof(<ConstructImage>d__164))]
		protected Task BLMXEQVHOAU(LIJTJBKAUDO a, int b, bool c, bool d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xB7355A0", Offset = "0xB733FA0", VA = "0x18B7355A0")]
		[AsyncStateMachine(typeof(<ConstructImageBuffer>d__165))]
		protected Task LYJXIJADYEO(QSDNGVTLXBY a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xB732D10", Offset = "0xB731710", VA = "0x18B732D10")]
		[AsyncStateMachine(typeof(<CheckMimeTypeAndLoadImage>d__166))]
		private Task<Texture2D> ESXIVTKPNXC(LIJTJBKAUDO a, Texture2D b, NativeArray<byte> c, bool d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xB73B7F0", Offset = "0xB73A1F0", VA = "0x18B73B7F0", Slot = "29")]
		[AsyncStateMachine(typeof(<ConstructUnityTexture>d__167))]
		protected virtual Task VRHDZGCFWQX(Stream a, bool b, bool c, bool d, LIJTJBKAUDO e, int f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xB735440", Offset = "0xB733E40", VA = "0x18B735440", Slot = "30")]
		protected virtual int LWHXCILTGXP(QSDNGVTLXBY a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xB733A70", Offset = "0xB732470", VA = "0x18B733A70", Slot = "31")]
		protected virtual bool FXOROJEBQJZ(QSDNGVTLXBY a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xB733D30", Offset = "0xB732730", VA = "0x18B733D30", Slot = "32")]
		[AsyncStateMachine(typeof(<ConstructTexture>d__173))]
		protected virtual Task GRTTYVSVOZE(QSDNGVTLXBY a, int b, bool c, bool d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xB73BBE0", Offset = "0xB73A5E0", VA = "0x18B73BBE0")]
		[AsyncStateMachine(typeof(<<GetInstancesTRS>g__GetAttrAccessorAndAccessorContent|96_0>d))]
		[CompilerGenerated]
		private Task<MSHGOIDHWYJ> XEAXRZXSXPL(MYCFVKCOBHO a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xB7327E0", Offset = "0xB7311E0", VA = "0x18B7327E0")]
		[CompilerGenerated]
		internal static MSHGOIDHWYJ EICUSPGLEUT(string a, <>c__DisplayClass114_0 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xB732A70", Offset = "0xB731470", VA = "0x18B732A70")]
		[CompilerGenerated]
		private void ENMPKXLSIYA(AXTSRHKTJDS a, GEAORXGMOBL b, [Out] Vector2 c, [Out] Vector2 d, <>c__DisplayClass119_0 e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xB735E60", Offset = "0xB734860", VA = "0x18B735E60")]
		[CompilerGenerated]
		private void OKKPGVKDVFB(<>c__DisplayClass119_0 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xB735250", Offset = "0xB733C50", VA = "0x18B735250")]
		[CompilerGenerated]
		private void LUEZLSSMSFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xB73BF80", Offset = "0xB73A980", VA = "0x18B73BF80")]
		[CompilerGenerated]
		private TextureWrapMode YESKLODMSRL(GLTF.Schema.WrapMode a)
		{
			return default(TextureWrapMode);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class GLTFSettings : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[Flags]
		public enum BlendShapeExportPropertyFlags
		{
			[Cpp2IlInjected.Token(Token = "0x4000308")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000309")]
			PositionOnly = 1,
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			Normal = 2,
			[Cpp2IlInjected.Token(Token = "0x400030B")]
			Tangent = 4,
			[Cpp2IlInjected.Token(Token = "0x400030C")]
			All = -1
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class MYNJLPBNSZW<a> where a : GLTFPlugin
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			public Type IZEPGSINGYJ;

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public MYNJLPBNSZW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x7040CE0", Offset = "0x703F6E0", VA = "0x187040CE0")]
			internal bool SYNOBVIAGJM(a a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private const string k_PreferencesPrefix = "UnityGLTF_Preferences_";

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private const string k_SettingsFileName = "UnityGLTFSettings.asset";

		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public const string k_RuntimeAndEditorSettingsPath = "Assets/Resources/UnityGLTFSettings.asset";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		[SerializeField]
		[HideInInspector]
		internal string packageVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		[SerializeField]
		[HideInInspector]
		public List<GLTFImportPlugin> ImportPlugins;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		[SerializeField]
		[HideInInspector]
		public List<GLTFExportPlugin> ExportPlugins;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		[Header("Export Settings")]
		[SerializeField]
		private bool exportNames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		[SerializeField]
		[Tooltip("If on, the entire texture path will be preserved. If off (default), textures are exported at root level.")]
		private bool exportFullPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		[Header("Export Visibility")]
		[SerializeField]
		[Tooltip("Uses Camera.main layer settings to filter which objects are exported")]
		private bool useMainCameraVisibility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x33")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		[SerializeField]
		[Tooltip("glTF does not support visibility state. If this setting is true, disabled GameObjects will still be exported and be visible in the glTF file.")]
		private bool exportDisabledGameObjects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		[Header("Export Textures")]
		[SerializeField]
		[Tooltip("(Experimental) Exports PNG/JPEG directly from disk instead of re-encoding from Unity's import result. No channel repacking will happen for these textures. Textures in other formats (PSD, TGA etc) not supported by glTF and in-memory textures (e.g. RenderTextures) are always re-encoded.")]
		private bool tryExportTexturesFromDisk;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		[SerializeField]
		[Tooltip("Determines texture export type (PNG or JPEG) based on alpha channel. When false, always exports lossless PNG files.")]
		private bool useTextureFileTypeHeuristic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		[SerializeField]
		[Tooltip("Quality setting for exported JPEG files.")]
		private int defaultJpegQuality;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		[Header("Export Animation")]
		[SerializeField]
		private bool exportAnimations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		[SerializeField]
		[Tooltip("When enabled the Animator State speed parameter is baked into the exported glTF animation")]
		private bool bakeAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		[SerializeField]
		[Tooltip("Some viewers can't distinguish between animation clips that have the same name. This option ensures all exported animation names are unique.")]
		private bool uniqueAnimationNames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		[SerializeField]
		private bool bakeSkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		[Header("Export Mesh Data")]
		[SerializeField]
		private BlendShapeExportPropertyFlags blendShapeExportProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		[SerializeField]
		[Tooltip("(Experimental) Use Sparse Accessors for blend shape export. Not supported on some viewers.")]
		private bool blendShapeExportSparseAccessors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		[SerializeField]
		[Tooltip("If off, vertex colors are not exported. Vertex Colors aren't supported in some viewers (e.g. Google's SceneViewer).")]
		private bool exportVertexColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		[Header("Export Cache")]
		[Tooltip("When enabled textures will be cached to disc for faster export times.\n(The cache size is reduced to stay below 1024 MB when the Editor quits)")]
		public bool UseCaching;

		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private static GLTFSettings cachedSettings;

		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private static List<GLTFSettings> settingsWherePluginsAreRegistered;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string AOEMRHCPYID
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xB759A40", Offset = "0xB758440", VA = "0x18B759A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool GSEGWNHVLXS
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xD2F810", Offset = "0xD2E210", VA = "0x180D2F810")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0xD300E0", Offset = "0xD2EAE0", VA = "0x180D300E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool QWFGBABXFWC
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xF517A0", Offset = "0xF501A0", VA = "0x180F517A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xF898F0", Offset = "0xF882F0", VA = "0x180F898F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool HMEKRWNATNZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x1ACEEF0", Offset = "0x1ACD8F0", VA = "0x181ACEEF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x1B0AAD0", Offset = "0x1B094D0", VA = "0x181B0AAD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool IXXEFYKAIFK
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xF06420", Offset = "0xF04E20", VA = "0x180F06420")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xF062F0", Offset = "0xF04CF0", VA = "0x180F062F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool MHPXGYEKSUW
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xF06430", Offset = "0xF04E30", VA = "0x180F06430")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xF06300", Offset = "0xF04D00", VA = "0x180F06300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool JEYBHOGXYMK
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x2768F90", Offset = "0x2767990", VA = "0x182768F90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x2769110", Offset = "0x2767B10", VA = "0x182769110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public int JWETZNFWVQW
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xD05F80", Offset = "0xD04980", VA = "0x180D05F80")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xDECAD0", Offset = "0xDEB4D0", VA = "0x180DECAD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool ZZXZQCZZCTM
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x211F990", Offset = "0x211E390", VA = "0x18211F990")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x9A7B320", Offset = "0x9A79D20", VA = "0x189A7B320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool ZNEIVFICDRV
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xEF86F0", Offset = "0xEF70F0", VA = "0x180EF86F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xFB1BD0", Offset = "0xFB05D0", VA = "0x180FB1BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool VWLSJSBLRKG
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xFB1CB0", Offset = "0xFB06B0", VA = "0x180FB1CB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xFB1BE0", Offset = "0xFB05E0", VA = "0x180FB1BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		[Obsolete("Add/remove \"AnimationPointerPlugin\" from ExportPlugins instead.")]
		public bool ECOTFNSQJLU
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xB759A50", Offset = "0xB758450", VA = "0x18B759A50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xB759B80", Offset = "0xB758580", VA = "0x18B759B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool EVYLPPQHFKT
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xFB1F00", Offset = "0xFB0900", VA = "0x180FB1F00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xFB1CC0", Offset = "0xFB06C0", VA = "0x180FB1CC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool PPKNJMUEIDS
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x19C4A60", Offset = "0x19C3460", VA = "0x1819C4A60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x19C4A70", Offset = "0x19C3470", VA = "0x1819C4A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public BlendShapeExportPropertyFlags ZTVRLQUKJEF
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xCF3DF0", Offset = "0xCF27F0", VA = "0x180CF3DF0")]
			get
			{
				return default(BlendShapeExportPropertyFlags);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0xD4CE50", Offset = "0xD4B850", VA = "0x180D4CE50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool XRCZAJIQQQY
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xB3AF940", Offset = "0xB3AE340", VA = "0x18B3AF940")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0xB3C8390", Offset = "0xB3C6D90", VA = "0x18B3C8390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xB759130", Offset = "0xB757B30", VA = "0x18B759130")]
		internal string HNTWORCCUBV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xB758F60", Offset = "0xB757960", VA = "0x18B758F60")]
		public static GLTFSettings GetOrCreateSettings()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xB758EF0", Offset = "0xB7578F0", VA = "0x18B758EF0")]
		public static GLTFSettings GetDefaultSettings()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xB759790", Offset = "0xB758190", VA = "0x18B759790")]
		public static bool TryGetSettings([Out] GLTFSettings settings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0xB758E30", Offset = "0xB757830", VA = "0x18B758E30")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ClearStatics()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xB7593A0", Offset = "0xB757DA0", VA = "0x18B7593A0")]
		private static void JJIHNMMDWQF(GLTFSettings a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xB759950", Offset = "0xB758350", VA = "0x18B759950")]
		public GLTFSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3AC9800", Offset = "0x3AC8200", VA = "0x183AC9800")]
		[CompilerGenerated]
		internal static List<Type> BWKHATXKVVG<a>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3AC9A40", Offset = "0x3AC8440", VA = "0x183AC9A40")]
		[CompilerGenerated]
		internal static void URGTLSGVGKW<b>(List<b> a) where b : GLTFPlugin
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class ShaderNotFoundException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xB75A750", Offset = "0xB759150", VA = "0x18B75A750")]
		public ShaderNotFoundException()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xB75A6A0", Offset = "0xB7590A0", VA = "0x18B75A6A0")]
		public ShaderNotFoundException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xB75A700", Offset = "0xB759100", VA = "0x18B75A700")]
		protected ShaderNotFoundException(SerializationInfo info, StreamingContext context)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class GLTFLoadException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xB758DD0", Offset = "0xB7577D0", VA = "0x18B758DD0")]
		public GLTFLoadException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class QPEXSEEKEQD : ILogHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private readonly StringBuilder GLMRXGODOXB;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xB75A5B0", Offset = "0xB758FB0", VA = "0x18B75A5B0")]
		private string YOOKRXRPMWF(LogType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xB75A4F0", Offset = "0xB758EF0", VA = "0x18B75A4F0", Slot = "4")]
		public void LogFormat(LogType logType, UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0xB75A450", Offset = "0xB758E50", VA = "0x18B75A450", Slot = "5")]
		public void LogException(Exception exception, UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xB75A2E0", Offset = "0xB758CE0", VA = "0x18B75A2E0")]
		public void DTBYOPHBCIK(string a = "{0}")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xB75A630", Offset = "0xB759030", VA = "0x18B75A630")]
		public QPEXSEEKEQD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class WQELZIXLLRK
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xB769020", Offset = "0xB767A20", VA = "0x18B769020")]
		public static string XRGNXMYRNYK(Uri a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xB768FB0", Offset = "0xB7679B0", VA = "0x18B768FB0")]
		public static string TJUOOPGQHBU(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xB768EA0", Offset = "0xB7678A0", VA = "0x18B768EA0")]
		public static void EWZYPHYNHHT(string a, [Out] byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xB768E10", Offset = "0xB767810", VA = "0x18B768E10")]
		public static bool EHGNBXWVUXP(string a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class InstantiatedGLTFObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private NHNKKAKRJCL LFYJKGZIORW;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public NHNKKAKRJCL PXVUCUYDARG
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0xB75A280", Offset = "0xB758C80", VA = "0x18B75A280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xB75A150", Offset = "0xB758B50", VA = "0x18B75A150")]
		public InstantiatedGLTFObject Duplicate()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xB75A230", Offset = "0xB758C30", VA = "0x18B75A230")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xCD6180", Offset = "0xCD4B80", VA = "0x180CD6180")]
		public InstantiatedGLTFObject()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public struct BlendShapeFrameWeightSetting
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public enum MultiplierOption
		{
			[Cpp2IlInjected.Token(Token = "0x4000318")]
			Multiplier1,
			[Cpp2IlInjected.Token(Token = "0x4000319")]
			Multiplier100,
			[Cpp2IlInjected.Token(Token = "0x400031A")]
			Custom
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		[SerializeField]
		internal MultiplierOption _option;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		[SerializeField]
		internal float _multiplier;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float ZZHGNSMJDSB
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0xB756F50", Offset = "0xB755950", VA = "0x18B756F50")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xB756FD0", Offset = "0xB7559D0", VA = "0x18B756FD0")]
		public BlendShapeFrameWeightSetting(MultiplierOption option)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xB756FE0", Offset = "0xB7559E0", VA = "0x18B756FE0")]
		public static implicit operator float(BlendShapeFrameWeightSetting weightSetting)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public enum GLTFImporterNormals
	{
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		Import,
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		Calculate,
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		None
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public abstract class ImporterFactory : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract GLTFSceneImporter CreateSceneImporter(string gltfFileName, OLYORYCKIUH options);

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xD6AE70", Offset = "0xD69870", VA = "0x180D6AE70")]
		protected ImporterFactory()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class DefaultImporterFactory : ImporterFactory
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xB758900", Offset = "0xB757300", VA = "0x18B758900", Slot = "4")]
		public override GLTFSceneImporter CreateSceneImporter(string gltfFileName, OLYORYCKIUH options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xD6AE70", Offset = "0xD69870", VA = "0x180D6AE70")]
		public DefaultImporterFactory()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	internal static class FGANBPCKBHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xB758970", Offset = "0xB757370", VA = "0x18B758970")]
		internal static void WKUBHFONJMJ(this Material a, string b, bool c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class MaterialLibrary : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xD6AE70", Offset = "0xD69870", VA = "0x180D6AE70")]
		public MaterialLibrary()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	internal static class YUOOYWKFOCE
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class VXVANLUKZAY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400031F")]
			public Texture2D CIVAUKXBJBY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			public Texture2D CJYRBJQEHHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			public Color[] XRACGARFLZV;

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public VXVANLUKZAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0xB768B60", Offset = "0xB767560", VA = "0x18B768B60")]
			internal void DYMHHPILHDR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0xB768DC0", Offset = "0xB7677C0", VA = "0x18B768DC0")]
			internal void FBQPDJDKJLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0xB768AC0", Offset = "0xB7674C0", VA = "0x18B768AC0")]
			internal void COWQXXBTYMP()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private struct <ConvertToDxt5nmAndCheckTextureFormatAsync>d__0 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000322")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public Texture2D source;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			private VXVANLUKZAY <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0xB760670", Offset = "0xB75F070", VA = "0x18B760670", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0xB760C90", Offset = "0xB75F690", VA = "0x18B760C90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xB769080", Offset = "0xB767A80", VA = "0x18B769080")]
		[AsyncStateMachine(typeof(<ConvertToDxt5nmAndCheckTextureFormatAsync>d__0))]
		public static Task<Texture2D> YKGOSVHKSSB(Texture2D a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class BUQDIJQVFTU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public bool[] GJXJBOHZYQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public Vector3[] VUVIKIFHLUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public Vector3[] AFUMAEGDQUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public Vector4[] BGSIMJOGGPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public Vector2[] SVFNUPHVWAU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public Vector2[] SVVIMJPNYIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public Vector2[] SVQBPCVQOXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public Vector2[] SUPTCVADTST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public Color[] RSJDYVFOZKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public BoneWeight[] EBCJEGWPYZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public Vector3[][] EJTVYMFZVYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public Vector3[][] BUBPZUPPAVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public Vector3[][] KFWLSKXMANV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public MeshTopology[] LFOYSVXNMGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public DrawMode[] QOCZZQJUTCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public int[][] INOEKSBIJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public HashSet<int> VRFQFXSVNCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public uint[] JXILEZSMTYM;

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xB756B70", Offset = "0xB755570", VA = "0x18B756B70")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xB756C80", Offset = "0xB755680", VA = "0x18B756C80")]
		public bool UYXBLBFGVYK(BUQDIJQVFTU a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xB756ED0", Offset = "0xB7558D0", VA = "0x18B756ED0")]
		public BUQDIJQVFTU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3725340", Offset = "0x3723D40", VA = "0x183725340")]
		[CompilerGenerated]
		internal static bool MWOAVJRDKDC<a>(a[] a, a[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3724E50", Offset = "0x3723850", VA = "0x183724E50")]
		[CompilerGenerated]
		internal static bool FUXNCLPZXTB<b>(b[][] a, b[][] b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public abstract class CJIFCZSVCND : YWWCRAQFFBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		internal Material RRPXFXHCOSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private AlphaMode HBNSFXQKQPU;

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public static readonly int HFJFONGOCNR;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private static readonly int KUFWRGBJFDI;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private static readonly int YJTODJZULYZ;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private static readonly int EJCYLRVLXXG;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private static readonly int MMRLZUHDDLY;

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private static readonly int HYXEUMSJUIF;

		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private static readonly int ECEKQRZCJTR;

		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private static readonly int SNVRUSWQMGO;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private static readonly int FYWHUHLXYWW;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private static readonly int MXSUWXKEWNX;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private static readonly int TZUUFUZRIQX;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private static readonly int HUEDOCWOERW;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private static readonly int VKZZAQNNLOT;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private static readonly int DFPKUSVRCST;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Material EEQKTWQVTXB
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public virtual AlphaMode ECZONMPFJTL
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0xB757A50", Offset = "0xB756450", VA = "0x18B757A50", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public double HTHGBPGSNEH
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0xB7577C0", Offset = "0xB7561C0", VA = "0x18B7577C0", Slot = "12")]
			get
			{
				return default(double);
			}
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0xB757760", Offset = "0xB756160", VA = "0x18B757760", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public virtual bool PRVRWBFISPO
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0xB757550", Offset = "0xB755F50", VA = "0x18B757550", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public virtual bool BRTYJNOHIBH
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0xB757320", Offset = "0xB755D20", VA = "0x18B757320", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public Texture RBTHENXJSJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0xB7579F0", Offset = "0xB7563F0", VA = "0x18B7579F0", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int VOOBMRFMTPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0xB7576F0", Offset = "0xB7560F0", VA = "0x18B7576F0", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Vector2 EKQDFYTKUVP
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0xB757410", Offset = "0xB755E10", VA = "0x18B757410", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public double LUAJSRHCTJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0xB757690", Offset = "0xB756090", VA = "0x18B757690", Slot = "18")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Vector2 KBECHXMXTEY
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0xB757630", Offset = "0xB756030", VA = "0x18B757630", Slot = "19")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public int QSTFSPWGODC
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0xB7584F0", Offset = "0xB756EF0", VA = "0x18B7584F0", Slot = "20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public Color INASAUYMYZD
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xB7573A0", Offset = "0xB755DA0", VA = "0x18B7573A0", Slot = "21")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract YWWCRAQFFBF Clone();

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xCE33E0", Offset = "0xCE1DE0", VA = "0x180CE33E0")]
		protected CJIFCZSVCND(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xB7587F0", Offset = "0xB7571F0", VA = "0x18B7587F0")]
		protected CJIFCZSVCND(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xB757470", Offset = "0xB755E70", VA = "0x18B757470")]
		protected void HEAEUGIKVQA(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xB757810", Offset = "0xB756210", VA = "0x18B757810")]
		protected void RMZZASAUXGJ(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xB757060", Offset = "0xB755A60", VA = "0x18B757060")]
		protected void ARFOXGXPZWT(Material a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class FRFHWZMAAFT : YTIWWJBRZXF, DOHCDIFDITJ, SDZYUGEIYBO, YWWCRAQFFBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private Vector2 YHULZUUDONL;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public virtual Texture RBTHENXJSJD
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xB758CB0", Offset = "0xB7576B0", VA = "0x18B758CB0", Slot = "77")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public virtual int VOOBMRFMTPC
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "78")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public virtual Vector2 EKQDFYTKUVP
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0xB758B50", Offset = "0xB757550", VA = "0x18B758B50", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public virtual double LUAJSRHCTJW
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public virtual Vector2 KBECHXMXTEY
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xB758BC0", Offset = "0xB7575C0", VA = "0x18B758BC0", Slot = "81")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public virtual int QSTFSPWGODC
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "82")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public virtual Color INASAUYMYZD
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0xB758A30", Offset = "0xB757430", VA = "0x18B758A30", Slot = "83")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public virtual Texture FJNBOUVGEHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0xB758D60", Offset = "0xB757760", VA = "0x18B758D60", Slot = "84")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public virtual int ARABHYOGCEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public virtual Vector2 LVVIDBRESKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "86")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public virtual double IUYIRPVSCXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual Vector2 YKBBTZDPDRH
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "88")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public virtual int TBDRCIZCFTF
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public virtual double VZWVRCEXTAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0xB758D10", Offset = "0xB757710", VA = "0x18B758D10", Slot = "90")]
			get
			{
				return default(double);
			}
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0xB758C50", Offset = "0xB757650", VA = "0x18B758C50", Slot = "91")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public virtual double HTWHTPKKOHR
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "92")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xB758DC0", Offset = "0xB7577C0", VA = "0x18B758DC0")]
		protected FRFHWZMAAFT(string a, string b, int c = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0xB758DB0", Offset = "0xB7577B0", VA = "0x18B758DB0")]
		protected FRFHWZMAAFT(Material a, int b = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xB758AA0", Offset = "0xB7574A0", VA = "0x18B758AA0", Slot = "60")]
		public override YWWCRAQFFBF Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class IRMECXUWRAU : FRFHWZMAAFT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private Vector2 QTPALMRUBAF;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public override int QGPEOUQIGVZ
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "35")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public override int DUJEHYVDMIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public override int HAANELYIJSX
		{
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "49")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public override int VOOBMRFMTPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "78")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public override Texture FJNBOUVGEHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0xB75A040", Offset = "0xB758A40", VA = "0x18B75A040", Slot = "84")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public override int ARABHYOGCEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public override Vector2 LVVIDBRESKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0xB759FD0", Offset = "0xB7589D0", VA = "0x18B759FD0", Slot = "86")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public override double IUYIRPVSCXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public override Vector2 YKBBTZDPDRH
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0xB759E90", Offset = "0xB758890", VA = "0x18B759E90", Slot = "88")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public override int TBDRCIZCFTF
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public override double HTWHTPKKOHR
		{
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0xB759E30", Offset = "0xB758830", VA = "0x18B759E30", Slot = "92")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xB75A0C0", Offset = "0xB758AC0", VA = "0x18B75A0C0")]
		public IRMECXUWRAU(string a, int b = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xB75A130", Offset = "0xB758B30", VA = "0x18B75A130")]
		protected IRMECXUWRAU(Material a, int b = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xB759F20", Offset = "0xB758920", VA = "0x18B759F20", Slot = "60")]
		public override YWWCRAQFFBF Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class YZLVPRSJOWM : CJIFCZSVCND, DOHCDIFDITJ, SDZYUGEIYBO, YWWCRAQFFBF, HTEAGGCTQKL, UWRZGZRZGGN, KGFUKJOONMR, KEEJJWJQDOD, TUDJSCYNFPM, EIANFJEMDQJ, BHPXFYXACUD, ORMTTIUKHHW, PZMDOBDGEQR
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public Texture SIZLCRXBFEA
		{
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0xB769360", Offset = "0xB767D60", VA = "0x18B769360", Slot = "37")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0xB7699B0", Offset = "0xB7683B0", VA = "0x18B7699B0", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public int QGPEOUQIGVZ
		{
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0xB769870", Offset = "0xB768270", VA = "0x18B769870", Slot = "39")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public double GBDWDDNIIXW
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0xB76B990", Offset = "0xB76A390", VA = "0x18B76B990", Slot = "40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public Vector2 KQPQMYOPCCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0xB76A1A0", Offset = "0xB768BA0", VA = "0x18B76A1A0", Slot = "41")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public double QPXVZGQSSPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0xB7694D0", Offset = "0xB767ED0", VA = "0x18B7694D0", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public Vector2 KQLTKEIHNBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0xB769750", Offset = "0xB768150", VA = "0x18B769750", Slot = "43")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int GCKRBLJXBYZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0xB76A380", Offset = "0xB768D80", VA = "0x18B76A380", Slot = "44")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public Texture LUKEHCGNAIS
		{
			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0xB76A140", Offset = "0xB768B40", VA = "0x18B76A140", Slot = "45")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int DUJEHYVDMIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0xB76B620", Offset = "0xB76A020", VA = "0x18B76B620", Slot = "46")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public double JKVVHYYSLDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0xB76B250", Offset = "0xB769C50", VA = "0x18B76B250", Slot = "47")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public Vector2 VJKHKLECMKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0xB76AA10", Offset = "0xB769410", VA = "0x18B76AA10", Slot = "48")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public double TNICJIHBJTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0xB76B560", Offset = "0xB769F60", VA = "0x18B76B560", Slot = "49")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public Vector2 GFFNJDFMBER
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0xB769C50", Offset = "0xB768650", VA = "0x18B769C50", Slot = "50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public int LBNDDQUIXJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0xB7698E0", Offset = "0xB7682E0", VA = "0x18B7698E0", Slot = "51")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Texture DEKTFGYZSQY
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0xB76B7B0", Offset = "0xB76A1B0", VA = "0x18B76B7B0", Slot = "52")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public int HAANELYIJSX
		{
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0xB76AD10", Offset = "0xB769710", VA = "0x18B76AD10", Slot = "53")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Color MOARTVLPTDA
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0xB76A880", Offset = "0xB769280", VA = "0x18B76A880", Slot = "54")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0xB76B4F0", Offset = "0xB769EF0", VA = "0x18B76B4F0", Slot = "55")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector2 FGHYOWKAGIY
		{
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0xB76B190", Offset = "0xB769B90", VA = "0x18B76B190", Slot = "56")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public double YEBLVEDSTGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0xB769AD0", Offset = "0xB7684D0", VA = "0x18B769AD0", Slot = "57")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector2 JZIIBAOXTMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0xB76A8F0", Offset = "0xB7692F0", VA = "0x18B76A8F0", Slot = "58")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public int REODSMKFVUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0xB76AEF0", Offset = "0xB7698F0", VA = "0x18B76AEF0", Slot = "59")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public Texture FJNBOUVGEHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0xB76B8D0", Offset = "0xB76A2D0", VA = "0x18B76B8D0", Slot = "29")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public int ARABHYOGCEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0xB76A700", Offset = "0xB769100", VA = "0x18B76A700", Slot = "30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Vector2 LVVIDBRESKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0xB769F50", Offset = "0xB768950", VA = "0x18B769F50", Slot = "31")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public double IUYIRPVSCXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0xB769A10", Offset = "0xB768410", VA = "0x18B769A10", Slot = "32")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Vector2 YKBBTZDPDRH
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0xB769530", Offset = "0xB767F30", VA = "0x18B769530", Slot = "33")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public int TBDRCIZCFTF
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0xB76B370", Offset = "0xB769D70", VA = "0x18B76B370", Slot = "34")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public double VZWVRCEXTAM
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0xB76AE90", Offset = "0xB769890", VA = "0x18B76AE90", Slot = "35")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public double HTWHTPKKOHR
		{
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0xB769410", Offset = "0xB767E10", VA = "0x18B769410", Slot = "36")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public double BNIFPFREXQX
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0xB76A640", Offset = "0xB769040", VA = "0x18B76A640", Slot = "60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public Texture DBMSGEHBOQL
		{
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0xB76A820", Offset = "0xB769220", VA = "0x18B76A820", Slot = "61")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public double JHHLJBVOPJP
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0xB769170", Offset = "0xB767B70", VA = "0x18B769170", Slot = "63")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public Vector2 EDJOMPAIJTG
		{
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0xB76B930", Offset = "0xB76A330", VA = "0x18B76B930", Slot = "62")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public Vector2 FKXTMAKPAZR
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0xB76B130", Offset = "0xB769B30", VA = "0x18B76B130", Slot = "64")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public int LERQGTNPGBX
		{
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0xB769E90", Offset = "0xB768890", VA = "0x18B769E90", Slot = "65")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public double NVLNEFZUMTP
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0xB76ADD0", Offset = "0xB7697D0", VA = "0x18B76ADD0", Slot = "66")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Color PAGRXKPLWSF
		{
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0xB7692F0", Offset = "0xB767CF0", VA = "0x18B7692F0", Slot = "67")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public double SKHAXIALEJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0xB769B30", Offset = "0xB768530", VA = "0x18B769B30", Slot = "68")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public Texture VXWBZAGUADL
		{
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0xB769D10", Offset = "0xB768710", VA = "0x18B769D10", Slot = "69")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public double AEQBICLULLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0xB769950", Offset = "0xB768350", VA = "0x18B769950", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Vector2 DECWBJINCPQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0xB76B3D0", Offset = "0xB769DD0", VA = "0x18B76B3D0", Slot = "70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Vector2 YYXXVJWBAQF
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0xB769EF0", Offset = "0xB7688F0", VA = "0x18B769EF0", Slot = "72")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public int NWWCTPDXHNZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0xB769290", Offset = "0xB767C90", VA = "0x18B769290", Slot = "73")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public double VOZJLEZTCGQ
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0xB76AB90", Offset = "0xB769590", VA = "0x18B76AB90", Slot = "74")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public double GHKKMODFFZP
		{
			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0xB76B310", Offset = "0xB769D10", VA = "0x18B76B310", Slot = "75")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public double SXANPSZRMIA
		{
			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0xB76AB30", Offset = "0xB769530", VA = "0x18B76AB30", Slot = "76")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public double JSSDLVFLNRS
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0xB76A200", Offset = "0xB768C00", VA = "0x18B76A200", Slot = "77")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public double NSILENNCUTE
		{
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0xB76B750", Offset = "0xB76A150", VA = "0x18B76B750", Slot = "78")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public Texture LXRPESEWEKR
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xB7691D0", Offset = "0xB767BD0", VA = "0x18B7691D0", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public double SOQNKAPTLIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0xB7696F0", Offset = "0xB7680F0", VA = "0x18B7696F0", Slot = "81")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public Vector2 LIAKECVXOCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0xB769690", Offset = "0xB768090", VA = "0x18B769690", Slot = "80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public Vector2 EDKCPOQAXVD
		{
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0xB769B90", Offset = "0xB768590", VA = "0x18B769B90", Slot = "82")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public int BXWZLICRRQX
		{
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0xB76B070", Offset = "0xB769A70", VA = "0x18B76B070", Slot = "83")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Texture DFFZCUQPJXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0xB76AE30", Offset = "0xB769830", VA = "0x18B76AE30", Slot = "84")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public double IPOSMOMPPDX
		{
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0xB76B010", Offset = "0xB769A10", VA = "0x18B76B010", Slot = "86")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public Vector2 GWBQMHHCDCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0xB76B6F0", Offset = "0xB76A0F0", VA = "0x18B76B6F0", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public Vector2 DMCLPFFJOWL
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0xB76A760", Offset = "0xB769160", VA = "0x18B76A760", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public int JOWHIZXGVQR
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0xB76A080", Offset = "0xB768A80", VA = "0x18B76A080", Slot = "88")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public double NFGVLHZTFQA
		{
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0xB76B490", Offset = "0xB769E90", VA = "0x18B76B490", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public Texture YYMHSPJWQLE
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0xB76AD70", Offset = "0xB769770", VA = "0x18B76AD70", Slot = "90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public double DKPOLTLZVTW
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0xB76A520", Offset = "0xB768F20", VA = "0x18B76A520", Slot = "92")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public Vector2 TDNATVBIITH
		{
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0xB76ACB0", Offset = "0xB7696B0", VA = "0x18B76ACB0", Slot = "91")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public Vector2 KWDCCKIQXHG
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xB769E30", Offset = "0xB768830", VA = "0x18B769E30", Slot = "93")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public int DWHAMETIBGM
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xB76A2C0", Offset = "0xB768CC0", VA = "0x18B76A2C0", Slot = "94")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Color ALBOTGVBQOR
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0xB76A450", Offset = "0xB768E50", VA = "0x18B76A450", Slot = "95")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Texture IWLZKVQQGAN
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0xB769810", Offset = "0xB768210", VA = "0x18B769810", Slot = "96")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public double XHZSTWDGZOP
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0xB769D70", Offset = "0xB768770", VA = "0x18B769D70", Slot = "98")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public Vector2 KULSSGTSEOO
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0xB769DD0", Offset = "0xB7687D0", VA = "0x18B769DD0", Slot = "97")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public Vector2 JAPSMGUQFNL
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0xB76A9B0", Offset = "0xB7693B0", VA = "0x18B76A9B0", Slot = "99")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public int LXAGNLHZMKH
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0xB769A70", Offset = "0xB768470", VA = "0x18B769A70", Slot = "100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public double FAEVCJTOQIP
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0xB769BF0", Offset = "0xB7685F0", VA = "0x18B769BF0", Slot = "101")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public Texture MXCNAUVHYTZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0xB76A320", Offset = "0xB768D20", VA = "0x18B76A320", Slot = "102")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public double GWFWEODHSCN
		{
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0xB76B430", Offset = "0xB769E30", VA = "0x18B76B430", Slot = "104")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public Vector2 VUIABDMNZXS
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0xB76A7C0", Offset = "0xB7691C0", VA = "0x18B76A7C0", Slot = "103")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Vector2 GGKJYFAEFHF
		{
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0xB76B870", Offset = "0xB76A270", VA = "0x18B76B870", Slot = "105")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public int TPBNXWNMSFT
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0xB76AF50", Offset = "0xB769950", VA = "0x18B76AF50", Slot = "106")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public double LZILDBWEMRH
		{
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0xB76A5E0", Offset = "0xB768FE0", VA = "0x18B76A5E0", Slot = "107")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public Texture TNCFYZYUJBL
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0xB769230", Offset = "0xB767C30", VA = "0x18B769230", Slot = "108")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public double BNLGUQVGTCL
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0xB76A580", Offset = "0xB768F80", VA = "0x18B76A580", Slot = "110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public Vector2 CSIAATUORNQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0xB76ABF0", Offset = "0xB7695F0", VA = "0x18B76ABF0", Slot = "109")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public Vector2 AYVFFHRKIJT
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0xB76B810", Offset = "0xB76A210", VA = "0x18B76B810", Slot = "111")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public int HXBVVQUNBFR
		{
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0xB76AAD0", Offset = "0xB7694D0", VA = "0x18B76AAD0", Slot = "112")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public float ZQHUVRXPMDK
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0xB76AC50", Offset = "0xB769650", VA = "0x18B76AC50", Slot = "113")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public float ZXPFKWQOMRO
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0xB7697B0", Offset = "0xB7681B0", VA = "0x18B7697B0", Slot = "114")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public Color FCLPZFSRDDT
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0xB769FB0", Offset = "0xB7689B0", VA = "0x18B769FB0", Slot = "115")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public Texture PEKBKLXBUTP
		{
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0xB76A020", Offset = "0xB768A20", VA = "0x18B76A020", Slot = "116")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public double CDEEQTTHLGP
		{
			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0xB76A0E0", Offset = "0xB768AE0", VA = "0x18B76A0E0", Slot = "117")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public Vector2 QFIRRDQMPXY
		{
			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0xB769470", Offset = "0xB767E70", VA = "0x18B769470", Slot = "118")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public Vector2 QLBZLXFKQPL
		{
			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0xB76A950", Offset = "0xB769350", VA = "0x18B76A950", Slot = "119")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public int UGAVBXMQIYD
		{
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0xB76A4C0", Offset = "0xB768EC0", VA = "0x18B76A4C0", Slot = "120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public Texture SJTIRUZZFNI
		{
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0xB76B2B0", Offset = "0xB769CB0", VA = "0x18B76B2B0", Slot = "121")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public double WVPRNRZNDKE
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0xB76B5C0", Offset = "0xB769FC0", VA = "0x18B76B5C0", Slot = "122")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public Vector2 OTPIULDHKDD
		{
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0xB76B1F0", Offset = "0xB769BF0", VA = "0x18B76B1F0", Slot = "123")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public Vector2 TJWHZAMPJIY
		{
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0xB76AA70", Offset = "0xB769470", VA = "0x18B76AA70", Slot = "124")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public int APLGYFBRILC
		{
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0xB769CB0", Offset = "0xB7686B0", VA = "0x18B769CB0", Slot = "125")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public double WTNOMFJIARZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0xB76A6A0", Offset = "0xB7690A0", VA = "0x18B76A6A0", Slot = "131")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public double RHNDVRBRRVS
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xB7693B0", Offset = "0xB767DB0", VA = "0x18B7693B0", Slot = "132")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Texture LKGVQZKHFLL
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0xB76A3F0", Offset = "0xB768DF0", VA = "0x18B76A3F0", Slot = "126")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public double ISALBIGKCQX
		{
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0xB76B690", Offset = "0xB76A090", VA = "0x18B76B690", Slot = "128")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public Vector2 QJDJPNVTBOC
		{
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0xB76A260", Offset = "0xB768C60", VA = "0x18B76A260", Slot = "127")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public Vector2 BRZYKCRGOFH
		{
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0xB76AFB0", Offset = "0xB7699B0", VA = "0x18B76AFB0", Slot = "129")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public int GXQIGMCRDFN
		{
			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0xB76B0D0", Offset = "0xB769AD0", VA = "0x18B76B0D0", Slot = "130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xB76BA60", Offset = "0xB76A460", VA = "0x18B76BA60")]
		public YZLVPRSJOWM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xB76BBD0", Offset = "0xB76A5D0", VA = "0x18B76BBD0")]
		protected YZLVPRSJOWM(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xB76B9F0", Offset = "0xB76A3F0", VA = "0x18B76B9F0")]
		public YZLVPRSJOWM(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xB769590", Offset = "0xB767F90", VA = "0x18B769590", Slot = "10")]
		public override YWWCRAQFFBF Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class ZZGPLJMXWZE : YTIWWJBRZXF, QDMSLCDGDZM, SDZYUGEIYBO, YWWCRAQFFBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private Vector2 GQMASRXLJOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private Vector2 FMMWNVTHQQS;

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public virtual Texture IYBDHAYEGBN
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0xB76BD20", Offset = "0xB76A720", VA = "0x18B76BD20", Slot = "77")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public virtual int BFWVEPYWMSK
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "78")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public virtual Vector2 LBEWQUOCOMP
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0xB76BF70", Offset = "0xB76A970", VA = "0x18B76BF70", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public virtual double GHRBYEFZEQK
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public virtual Vector2 NZQGXOYRFFQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0xB76C170", Offset = "0xB76AB70", VA = "0x18B76C170", Slot = "81")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public virtual int FSVYOMDMLJI
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "82")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public virtual Color CIPUSQFNILZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0xB76C100", Offset = "0xB76AB00", VA = "0x18B76C100", Slot = "83")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public virtual Texture KZUKJDKGDLS
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0xB76BE30", Offset = "0xB76A830", VA = "0x18B76BE30", Slot = "84")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public virtual int WQKHBCIAZAX
		{
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public virtual Vector2 QOGAKLYEHPC
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xB76C200", Offset = "0xB76AC00", VA = "0x18B76C200", Slot = "86")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public virtual double IGNESMOEOBP
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public virtual Vector2 UOZZTXBHRYD
		{
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0xB76BFE0", Offset = "0xB76A9E0", VA = "0x18B76BFE0", Slot = "88")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public virtual int VXLCCGCAKWZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public virtual Vector3 NFGVLHZTFQA
		{
			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0xB76C070", Offset = "0xB76AA70", VA = "0x18B76C070", Slot = "90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public virtual double KHKKUDKUKEL
		{
			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0xB76BEE0", Offset = "0xB76A8E0", VA = "0x18B76BEE0", Slot = "91")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0xB76C270", Offset = "0xB76AC70", VA = "0x18B76C270")]
		protected ZZGPLJMXWZE(string a, string b, int c = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0xB76C290", Offset = "0xB76AC90", VA = "0x18B76C290")]
		protected ZZGPLJMXWZE(Material a, int b = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xB76BD80", Offset = "0xB76A780", VA = "0x18B76BD80", Slot = "60")]
		public override YWWCRAQFFBF Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class YPOEMRVVISV : ZZGPLJMXWZE
	{
		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public override int QGPEOUQIGVZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "35")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public override int DUJEHYVDMIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public override int HAANELYIJSX
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "49")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public override int BFWVEPYWMSK
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "78")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public override int WQKHBCIAZAX
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xB77D220", Offset = "0xB77BC20", VA = "0x18B77D220")]
		public YPOEMRVVISV(string a, int b = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xB77D290", Offset = "0xB77BC90", VA = "0x18B77D290")]
		protected YPOEMRVVISV(Material a, int b = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xB77D110", Offset = "0xB77BB10", VA = "0x18B77D110", Slot = "60")]
		public override YWWCRAQFFBF Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class YTIWWJBRZXF : SDZYUGEIYBO, YWWCRAQFFBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		protected Material RRPXFXHCOSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private AlphaMode HBNSFXQKQPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private double FGEQPOPLZRC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private Vector2 UJBSMOSLCXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private Vector2 VEYLOQZOIPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private Vector2 ANMRELTZNFY;

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public Material EEQKTWQVTXB
		{
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public virtual Texture SIZLCRXBFEA
		{
			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0xB77D2A0", Offset = "0xB77BCA0", VA = "0x18B77D2A0", Slot = "33")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0xB77D650", Offset = "0xB77C050", VA = "0x18B77D650", Slot = "34")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public virtual int QGPEOUQIGVZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "35")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public virtual Vector2 KQPQMYOPCCI
		{
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0xB77D8F0", Offset = "0xB77C2F0", VA = "0x18B77D8F0", Slot = "36")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public virtual double QPXVZGQSSPL
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "37")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public virtual Vector2 KQLTKEIHNBB
		{
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0xB77D5C0", Offset = "0xB77BFC0", VA = "0x18B77D5C0", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public virtual int GCKRBLJXBYZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "39")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public virtual double GBDWDDNIIXW
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xB77E2E0", Offset = "0xB77CCE0", VA = "0x18B77E2E0", Slot = "40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public virtual Texture LUKEHCGNAIS
		{
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0xB77D830", Offset = "0xB77C230", VA = "0x18B77D830", Slot = "41")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public virtual int DUJEHYVDMIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public virtual Vector2 VJKHKLECMKC
		{
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0xB77DA90", Offset = "0xB77C490", VA = "0x18B77DA90", Slot = "43")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public virtual double TNICJIHBJTR
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "44")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public virtual Vector2 GFFNJDFMBER
		{
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0xB77D730", Offset = "0xB77C130", VA = "0x18B77D730", Slot = "45")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public virtual int LBNDDQUIXJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "46")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		public virtual double JKVVHYYSLDH
		{
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0xB77E090", Offset = "0xB77CA90", VA = "0x18B77E090", Slot = "47")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public virtual Texture DEKTFGYZSQY
		{
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0xB77E200", Offset = "0xB77CC00", VA = "0x18B77E200", Slot = "48")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public virtual int HAANELYIJSX
		{
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "49")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public virtual Vector2 FGHYOWKAGIY
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xB77E020", Offset = "0xB77CA20", VA = "0x18B77E020", Slot = "50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public virtual double YEBLVEDSTGF
		{
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "51")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public virtual Vector2 JZIIBAOXTMP
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xB77DA00", Offset = "0xB77C400", VA = "0x18B77DA00", Slot = "52")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public virtual int REODSMKFVUV
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "53")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public virtual Color MOARTVLPTDA
		{
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0xB77D960", Offset = "0xB77C360", VA = "0x18B77D960", Slot = "54")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0xB77E150", Offset = "0xB77CB50", VA = "0x18B77E150", Slot = "55")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public virtual AlphaMode ECZONMPFJTL
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0xB77DB90", Offset = "0xB77C590", VA = "0x18B77DB90", Slot = "56")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		public virtual double HTHGBPGSNEH
		{
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0xB77DB00", Offset = "0xB77C500", VA = "0x18B77DB00", Slot = "57")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public virtual bool PRVRWBFISPO
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0xB77D7C0", Offset = "0xB77C1C0", VA = "0x18B77D7C0", Slot = "58")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		public virtual bool BRTYJNOHIBH
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0xB77D310", Offset = "0xB77BD10", VA = "0x18B77D310", Slot = "59")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xB77E3A0", Offset = "0xB77CDA0", VA = "0x18B77E3A0")]
		protected YTIWWJBRZXF(string a, string b, int c = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xB77E500", Offset = "0xB77CF00", VA = "0x18B77E500")]
		protected YTIWWJBRZXF(Material a, int b = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xB77D390", Offset = "0xB77BD90", VA = "0x18B77D390", Slot = "60")]
		public virtual YWWCRAQFFBF Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xB77D520", Offset = "0xB77BF20", VA = "0x18B77D520", Slot = "61")]
		protected virtual void Copy(SDZYUGEIYBO o)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public interface YWWCRAQFFBF
	{
		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		Material EEQKTWQVTXB
		{
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		AlphaMode ECZONMPFJTL
		{
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		double HTHGBPGSNEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		bool PRVRWBFISPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		bool BRTYJNOHIBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(Slot = "5")]
		YWWCRAQFFBF Clone();
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public interface SDZYUGEIYBO : YWWCRAQFFBF
	{
		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		Texture SIZLCRXBFEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		int QGPEOUQIGVZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		double GBDWDDNIIXW
		{
			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		Vector2 KQPQMYOPCCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		double QPXVZGQSSPL
		{
			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		Vector2 KQLTKEIHNBB
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		int GCKRBLJXBYZ
		{
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		Texture LUKEHCGNAIS
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		int DUJEHYVDMIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FE")]
		double JKVVHYYSLDH
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FF")]
		Vector2 VJKHKLECMKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000100")]
		double TNICJIHBJTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000101")]
		Vector2 GFFNJDFMBER
		{
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000102")]
		int LBNDDQUIXJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		Texture DEKTFGYZSQY
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(Slot = "15")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		int HAANELYIJSX
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(Slot = "16")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		Color MOARTVLPTDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(Slot = "18")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		Vector2 FGHYOWKAGIY
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(Slot = "19")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000107")]
		double YEBLVEDSTGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(Slot = "20")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		Vector2 JZIIBAOXTMP
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(Slot = "21")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		int REODSMKFVUV
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(Slot = "22")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public interface DOHCDIFDITJ : SDZYUGEIYBO, YWWCRAQFFBF
	{
		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		Texture RBTHENXJSJD
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		int VOOBMRFMTPC
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		Vector2 EKQDFYTKUVP
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		double LUAJSRHCTJW
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010E")]
		Vector2 KBECHXMXTEY
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010F")]
		int QSTFSPWGODC
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000110")]
		Color INASAUYMYZD
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		Texture FJNBOUVGEHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		int ARABHYOGCEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		Vector2 LVVIDBRESKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		double IUYIRPVSCXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000115")]
		Vector2 YKBBTZDPDRH
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		int TBDRCIZCFTF
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		double VZWVRCEXTAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000118")]
		double HTWHTPKKOHR
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public interface HTEAGGCTQKL : DOHCDIFDITJ, SDZYUGEIYBO, YWWCRAQFFBF
	{
		[Cpp2IlInjected.Token(Token = "0x17000119")]
		double BNIFPFREXQX
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		Texture DBMSGEHBOQL
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		Vector2 EDJOMPAIJTG
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		double JHHLJBVOPJP
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		Vector2 FKXTMAKPAZR
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		int LERQGTNPGBX
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		double NVLNEFZUMTP
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		Color PAGRXKPLWSF
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public interface UWRZGZRZGGN : DOHCDIFDITJ, SDZYUGEIYBO, YWWCRAQFFBF
	{
		[Cpp2IlInjected.Token(Token = "0x17000121")]
		double SKHAXIALEJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		Texture VXWBZAGUADL
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		Vector2 DECWBJINCPQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		double AEQBICLULLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		Vector2 YYXXVJWBAQF
		{
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		int NWWCTPDXHNZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public interface ORMTTIUKHHW : DOHCDIFDITJ, SDZYUGEIYBO, YWWCRAQFFBF
	{
		[Cpp2IlInjected.Token(Token = "0x17000127")]
		float ZXPFKWQOMRO
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		Color FCLPZFSRDDT
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		Texture PEKBKLXBUTP
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		double CDEEQTTHLGP
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012B")]
		Vector2 QFIRRDQMPXY
		{
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012C")]
		Vector2 QLBZLXFKQPL
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		int UGAVBXMQIYD
		{
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012E")]
		Texture SJTIRUZZFNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012F")]
		double WVPRNRZNDKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000130")]
		Vector2 OTPIULDHKDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		Vector2 TJWHZAMPJIY
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		int APLGYFBRILC
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public interface BHPXFYXACUD : UWRZGZRZGGN, DOHCDIFDITJ, SDZYUGEIYBO, YWWCRAQFFBF
	{
		[Cpp2IlInjected.Token(Token = "0x17000133")]
		float ZQHUVRXPMDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public interface KGFUKJOONMR : DOHCDIFDITJ, SDZYUGEIYBO, YWWCRAQFFBF
	{
		[Cpp2IlInjected.Token(Token = "0x17000134")]
		double VOZJLEZTCGQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public interface TUDJSCYNFPM : DOHCDIFDITJ, SDZYUGEIYBO, YWWCRAQFFBF
	{
		[Cpp2IlInjected.Token(Token = "0x17000135")]
		double NFGVLHZTFQA
		{
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		Texture YYMHSPJWQLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		Vector2 TDNATVBIITH
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		double DKPOLTLZVTW
		{
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		Vector2 KWDCCKIQXHG
		{
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013A")]
		int DWHAMETIBGM
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013B")]
		Color ALBOTGVBQOR
		{
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013C")]
		Texture IWLZKVQQGAN
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013D")]
		Vector2 KULSSGTSEOO
		{
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013E")]
		double XHZSTWDGZOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013F")]
		Vector2 JAPSMGUQFNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000140")]
		int LXAGNLHZMKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public interface KEEJJWJQDOD : DOHCDIFDITJ, SDZYUGEIYBO, YWWCRAQFFBF
	{
		[Cpp2IlInjected.Token(Token = "0x17000141")]
		double GHKKMODFFZP
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000142")]
		double SXANPSZRMIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		double JSSDLVFLNRS
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		double NSILENNCUTE
		{
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		Texture LXRPESEWEKR
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000146")]
		Vector2 LIAKECVXOCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		double SOQNKAPTLIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		Vector2 EDKCPOQAXVD
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		int BXWZLICRRQX
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		Texture DFFZCUQPJXF
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		Vector2 GWBQMHHCDCM
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		double IPOSMOMPPDX
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		Vector2 DMCLPFFJOWL
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		int JOWHIZXGVQR
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public interface QDMSLCDGDZM : SDZYUGEIYBO, YWWCRAQFFBF
	{
		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		Texture IYBDHAYEGBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		int BFWVEPYWMSK
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		Vector2 LBEWQUOCOMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		double GHRBYEFZEQK
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		Vector2 NZQGXOYRFFQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000154")]
		int FSVYOMDMLJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000155")]
		Color CIPUSQFNILZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		Texture KZUKJDKGDLS
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		int WQKHBCIAZAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000158")]
		Vector2 QOGAKLYEHPC
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		double IGNESMOEOBP
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		Vector2 UOZZTXBHRYD
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		int VXLCCGCAKWZ
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		Vector3 NFGVLHZTFQA
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		double KHKKUDKUKEL
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public interface EIANFJEMDQJ : DOHCDIFDITJ, SDZYUGEIYBO, YWWCRAQFFBF
	{
		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		double FAEVCJTOQIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		Texture MXCNAUVHYTZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000160")]
		Vector2 VUIABDMNZXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		double GWFWEODHSCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		Vector2 GGKJYFAEFHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		int TPBNXWNMSFT
		{
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		double LZILDBWEMRH
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		Texture TNCFYZYUJBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		Vector2 CSIAATUORNQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		double BNLGUQVGTCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000168")]
		Vector2 AYVFFHRKIJT
		{
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		int HXBVVQUNBFR
		{
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public interface PSRCEZISYGU
	{
		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		Texture AWUFWNBCOOS
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700016B")]
		Vector2 GPISJTGVTXH
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		double WFDBVOMYWQE
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700016D")]
		Vector2 SJXFZNBXMHG
		{
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700016E")]
		int SKKKYUASAFW
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public interface PZMDOBDGEQR
	{
		[Cpp2IlInjected.Token(Token = "0x1700016F")]
		Texture LKGVQZKHFLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000170")]
		Vector2 QJDJPNVTBOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000171")]
		double ISALBIGKCQX
		{
			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000172")]
		Vector2 BRZYKCRGOFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000173")]
		int GXQIGMCRDFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000174")]
		double WTNOMFJIARZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000175")]
		double RHNDVRBRRVS
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public interface QSTZXZAGEDP : YWWCRAQFFBF
	{
		[Cpp2IlInjected.Token(Token = "0x17000176")]
		Texture RBTHENXJSJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000177")]
		int VOOBMRFMTPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000178")]
		Vector2 EKQDFYTKUVP
		{
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000179")]
		double LUAJSRHCTJW
		{
			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700017A")]
		Vector2 KBECHXMXTEY
		{
			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700017B")]
		int QSTFSPWGODC
		{
			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700017C")]
		Color INASAUYMYZD
		{
			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class NVOBYVWIZHO : CJIFCZSVCND, QSTZXZAGEDP, YWWCRAQFFBF
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xB776220", Offset = "0xB774C20", VA = "0x18B776220")]
		public NVOBYVWIZHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xB7762B0", Offset = "0xB774CB0", VA = "0x18B7762B0")]
		protected NVOBYVWIZHO(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0xB7761C0", Offset = "0xB774BC0", VA = "0x18B7761C0")]
		public NVOBYVWIZHO(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xB7760D0", Offset = "0xB774AD0", VA = "0x18B7760D0", Slot = "10")]
		public override YWWCRAQFFBF Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class OZECNROFPSI : YTIWWJBRZXF, QSTZXZAGEDP, YWWCRAQFFBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private Vector2 YHULZUUDONL;

		[Cpp2IlInjected.Token(Token = "0x1700017D")]
		public Texture RBTHENXJSJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0xB7773C0", Offset = "0xB775DC0", VA = "0x18B7773C0", Slot = "62")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017E")]
		public virtual int VOOBMRFMTPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "69")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017F")]
		public virtual Vector2 EKQDFYTKUVP
		{
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0xB7772C0", Offset = "0xB775CC0", VA = "0x18B7772C0", Slot = "70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000180")]
		public virtual double LUAJSRHCTJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000181")]
		public virtual Vector2 KBECHXMXTEY
		{
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0xB777330", Offset = "0xB775D30", VA = "0x18B777330", Slot = "72")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000182")]
		public virtual int QSTFSPWGODC
		{
			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "73")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000183")]
		public virtual Color INASAUYMYZD
		{
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0xB777250", Offset = "0xB775C50", VA = "0x18B777250", Slot = "74")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xB777420", Offset = "0xB775E20", VA = "0x18B777420")]
		public OZECNROFPSI(string a, string b, int c = 1000)
		{
		}
	}
}
namespace UnityGLTF.Timeline
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class EJIVIUDZLDX
	{
		[Cpp2IlInjected.Token(Token = "0x2000092")]
		public delegate void OnBeforeAddAnimationDataDelegate(WYBXASTAZCO animationData);

		[Cpp2IlInjected.Token(Token = "0x2000093")]
		public delegate void OnPostExportDelegate(MJEJVQJAIRN animationData);

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		public class MJEJVQJAIRN
		{
			[Cpp2IlInjected.Token(Token = "0x17000186")]
			private Bounds EYNXOVWIPPY
			{
				[Cpp2IlInjected.Token(Token = "0x60003AA")]
				[Cpp2IlInjected.Address(RVA = "0xA8C2DF0", Offset = "0xA8C17F0", VA = "0x18A8C2DF0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000187")]
			private GLTFSceneExporter UARXKBKJXTZ
			{
				[Cpp2IlInjected.Token(Token = "0x60003AB")]
				[Cpp2IlInjected.Address(RVA = "0xCD8620", Offset = "0xCD7020", VA = "0x180CD8620")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000188")]
			private GZYGZQSIZFV ELFRITOITBV
			{
				[Cpp2IlInjected.Token(Token = "0x60003AC")]
				[Cpp2IlInjected.Address(RVA = "0xCDF4B0", Offset = "0xCDDEB0", VA = "0x180CDF4B0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0xB775190", Offset = "0xB773B90", VA = "0x18B775190")]
			internal MJEJVQJAIRN(Bounds a, GLTFSceneExporter b, GZYGZQSIZFV c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		public class WYBXASTAZCO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			internal AnimationData.BCHGRMHKZNP HJDNMDKDUML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			public float[] UPMWFXZFEPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public object[] ETEBIJCPKXW;

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0xDC7880", Offset = "0xDC6280", VA = "0x180DC7880")]
			internal WYBXASTAZCO(AnimationData.BCHGRMHKZNP a, float[] b, object[] c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000096")]
		internal class AnimationData
		{
			[Cpp2IlInjected.Token(Token = "0x2000097")]
			internal class HOLIBBMPJWX
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000372")]
				public string KCJDFXLSJGI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000373")]
				public Type VTSCKTTPVZA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000374")]
				public Func<Transform, UnityEngine.Object> TUQKTQNWMSP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000375")]
				public Func<Transform, UnityEngine.Object, AnimationData, object> LUOCUZHBCTU;

				[Cpp2IlInjected.Token(Token = "0x60003B2")]
				[Cpp2IlInjected.Address(RVA = "0x10FC420", Offset = "0x10FAE20", VA = "0x1810FC420")]
				public HOLIBBMPJWX(string a, Type b, Func<Transform, UnityEngine.Object> c, Func<Transform, UnityEngine.Object, AnimationData, object> d)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003B3")]
				[Cpp2IlInjected.Address(RVA = "0xB774CA0", Offset = "0xB7736A0", VA = "0x18B774CA0")]
				public object IEYBSZJKJSM(AnimationData a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000098")]
			internal class BCHGRMHKZNP
			{
				[Cpp2IlInjected.Token(Token = "0x2000099")]
				private class KEEWLYDPUOZ
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400037B")]
					public double KXTDOTJQYTR;

					[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
					[Cpp2IlInjected.Token(Token = "0x400037C")]
					public object PBBCXWXIUEP;

					[Cpp2IlInjected.Token(Token = "0x60003BA")]
					[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
					public KEEWLYDPUOZ()
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000376")]
				private AnimationData MGEVGHIMKQU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000377")]
				private HOLIBBMPJWX RNDTYXQOZAJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000378")]
				private Dictionary<double, object> IHIMXMHGUKB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000379")]
				private KEEWLYDPUOZ JYDRELJSRHW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400037A")]
				private KEEWLYDPUOZ SZFEVVCADSV;

				[Cpp2IlInjected.Token(Token = "0x17000189")]
				public UnityEngine.Object FEOBYYQDIXS
				{
					[Cpp2IlInjected.Token(Token = "0x60003B4")]
					[Cpp2IlInjected.Address(RVA = "0xB76D9A0", Offset = "0xB76C3A0", VA = "0x18B76D9A0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018A")]
				public string KCJDFXLSJGI
				{
					[Cpp2IlInjected.Token(Token = "0x60003B5")]
					[Cpp2IlInjected.Address(RVA = "0x2AB46A0", Offset = "0x2AB30A0", VA = "0x182AB46A0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018B")]
				public float[] HQJUIJUPLVO
				{
					[Cpp2IlInjected.Token(Token = "0x60003B6")]
					[Cpp2IlInjected.Address(RVA = "0xB76D590", Offset = "0xB76BF90", VA = "0x18B76D590")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018C")]
				public object[] CNEXRUBOKSQ
				{
					[Cpp2IlInjected.Token(Token = "0x60003B7")]
					[Cpp2IlInjected.Address(RVA = "0xB76D6F0", Offset = "0xB76C0F0", VA = "0x18B76D6F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60003B8")]
				[Cpp2IlInjected.Address(RVA = "0xB76D9E0", Offset = "0xB76C3E0", VA = "0x18B76D9E0")]
				public BCHGRMHKZNP(AnimationData a, HOLIBBMPJWX b, double c)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003B9")]
				[Cpp2IlInjected.Address(RVA = "0xB76D750", Offset = "0xB76C150", VA = "0x18B76D750")]
				public void QNZWLSMXZUV(double a)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			internal Transform MGEVGHIMKQU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			private SkinnedMeshRenderer OUUHOFZQQNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			private bool HYIFQMASIUM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			private bool ZEUNUAVLWVJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			private bool YFPKZBAMWXC;

			[Cpp2IlInjected.Token(Token = "0x400036F")]
			private static List<HOLIBBMPJWX> ZCWOEHUFPIA;

			[Cpp2IlInjected.Token(Token = "0x4000370")]
			private static MaterialPropertyBlock RJFMIXGVYPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			internal List<BCHGRMHKZNP> OULHBTIQTVU;

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0xB76C450", Offset = "0xB76AE50", VA = "0x18B76C450")]
			public AnimationData(Transform tr, double time, bool zeroScale = false, bool recordBlendShapes = true, bool inWorldSpace = false, bool recordAnimationPointer = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0xB76C2B0", Offset = "0xB76ACB0", VA = "0x18B76C2B0")]
			public void Update(double time)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		internal ICollection<Transform> LMQUMJDEKAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private Transform JBSQCTQPIEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private Dictionary<Transform, AnimationData> ZTAAYLQAUCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private double AVMMDAELAZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private double ZILIGVFUYOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		private bool WREOJRGEINT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		private bool PRZUOZIXXEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private readonly bool HYIFQMASIUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private readonly bool EQZADYAHZAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private readonly bool YFPKZBAMWXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public string CQYUOANLBWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public OnBeforeAddAnimationDataDelegate UIVGNWILWGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public OnPostExportDelegate DSQEOZCREUX;

		[Cpp2IlInjected.Token(Token = "0x4000361")]
		private static ProfilerMarker PJNDWJISCDL;

		[Cpp2IlInjected.Token(Token = "0x4000362")]
		private static ProfilerMarker BAIXGBJWXMM;

		[Cpp2IlInjected.Token(Token = "0x4000363")]
		private static ProfilerMarker NGEYKJIKYTL;

		[Cpp2IlInjected.Token(Token = "0x17000184")]
		public bool QZKUUHHTEOF
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x1B64EF0", Offset = "0x1B638F0", VA = "0x181B64EF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000185")]
		public double TWDWDYCHXID
		{
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0xE18440", Offset = "0xE16E40", VA = "0x180E18440")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0xB7739F0", Offset = "0xB7723F0", VA = "0x18B7739F0")]
		public EJIVIUDZLDX(Transform a, bool b = true, bool c = false, bool d = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xB7732E0", Offset = "0xB771CE0", VA = "0x18B7732E0")]
		private bool UUTZACJUVZQ(Transform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0xB772640", Offset = "0xB771040", VA = "0x18B772640")]
		public void CUPHAKKVTYB(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xB772370", Offset = "0xB770D70", VA = "0x18B772370")]
		public void BFWOPMJWGMK(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xB772880", Offset = "0xB771280", VA = "0x18B772880")]
		public void PYQUKSMKFSG(string a, string b = "scene", [Optional] GLTFSettings c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xB7729F0", Offset = "0xB7713F0", VA = "0x18B7729F0")]
		public void PYQUKSMKFSG(Stream a, string b = "scene", [Optional] GLTFSettings c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xB7730E0", Offset = "0xB771AE0", VA = "0x18B7730E0")]
		private void TTKSKUHNNOG(GLTFSceneExporter a, GZYGZQSIZFV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xB7733A0", Offset = "0xB771DA0", VA = "0x18B7733A0")]
		private void YGQOMBNJUKQ(GLTFSceneExporter a, ABAJRTCMWQH b, bool c, [Out] Bounds d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public class GLTFRecorderBehaviour : PlayableBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class NCLLTQFRZHV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			public GLTFRecorderBehaviour IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			public double KXTDOTJQYTR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			public Playable DRELUMEUZDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			public FrameData WATVMPWMMZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			public object JJAVSBLGMCD;

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public NCLLTQFRZHV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0xB775860", Offset = "0xB774260", VA = "0x18B775860")]
			internal void ESARBRXXWBI()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private EJIVIUDZLDX OKOGUOOWKDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public GLTFRecorderClip Clip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private bool ENSXNQDWZUY;

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xB773FA0", Offset = "0xB7729A0", VA = "0x18B773FA0")]
		private void PVTHUPQKSGC(double a, Transform b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0xB7741B0", Offset = "0xB772BB0", VA = "0x18B7741B0")]
		private void QBYKRTFPQWJ(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xB774210", Offset = "0xB772C10", VA = "0x18B774210")]
		private void UMDXTJGIOEW(double a, Transform b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20")]
		private static bool UUFQBGHITMA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xB773F00", Offset = "0xB772900", VA = "0x18B773F00", Slot = "16")]
		public override void OnPlayableDestroy(Playable playable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0xB773CD0", Offset = "0xB7726D0", VA = "0x18B773CD0", Slot = "13")]
		public override void OnGraphStart(Playable playable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xB773E60", Offset = "0xB772860", VA = "0x18B773E60", Slot = "14")]
		public override void OnGraphStop(Playable playable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xB774070", Offset = "0xB772A70", VA = "0x18B774070", Slot = "20")]
		public override void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x1A9FB30", Offset = "0x1A9E530", VA = "0x181A9FB30", Slot = "17")]
		public override void OnBehaviourPlay(Playable playable, FrameData info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x1862580", Offset = "0x1860F80", VA = "0x181862580", Slot = "18")]
		public override void OnBehaviourPause(Playable playable, FrameData info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xB773B90", Offset = "0xB772590", VA = "0x18B773B90")]
		public void IEWURVFTAQB(double a, Playable b, FrameData c, object d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
		public GLTFRecorderBehaviour()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[DisplayName("glTF Recorder Clip")]
	public class GLTFRecorderClip : PlayableAsset, ITimelineClipAsset
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public ExposedReference<Transform> m_exportRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public string m_File;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public string m_AnimationName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public int m_CaptureFrameRate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public bool m_RecordBlendShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		[Tooltip("Enable the KHR_animation_pointer extension. This allows recording material and script properties, but is not supported in all viewers.")]
		public bool m_RecordAnimationPointer;

		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		public ClipCaps clipCaps
		{
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0xCF3DF0", Offset = "0xCF27F0", VA = "0x180CF3DF0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(ClipCaps);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0xB774450", Offset = "0xB772E50", VA = "0x18B774450", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xB774560", Offset = "0xB772F60", VA = "0x18B774560")]
		public Transform GetExportRoot(PlayableGraph graph)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xB7745C0", Offset = "0xB772FC0", VA = "0x18B7745C0")]
		public GLTFRecorderClip()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[ExecuteInEditMode]
	internal class GLTFRecorderHelper : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private sealed class DNXOKTWEPDD : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			private object BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public GLTFRecorderHelper IRZLODQIRHI;

			[Cpp2IlInjected.Token(Token = "0x1700018E")]
			private object BIQZSYBZPAT
			{
				[Cpp2IlInjected.Token(Token = "0x60003EA")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700018F")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x60003EC")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
			[DebuggerHidden]
			public DNXOKTWEPDD(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0xB771440", Offset = "0xB76FE40", VA = "0x18B771440", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0xB771670", Offset = "0xB770070", VA = "0x18B771670", Slot = "8")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private List<Action> LUYWWYFROGG;

		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private static GLTFRecorderHelper GMMEYIOKMTD;

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xB774650", Offset = "0xB773050", VA = "0x18B774650")]
		public static void Add(Action callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0xB774980", Offset = "0xB773380", VA = "0x18B774980")]
		private static GLTFRecorderHelper SPYBQYPOTQB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0xB774890", Offset = "0xB773290", VA = "0x18B774890")]
		[IteratorStateMachine(typeof(DNXOKTWEPDD))]
		private IEnumerator KLLBESYWTTV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0xB774900", Offset = "0xB773300", VA = "0x18B774900")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0xB774B20", Offset = "0xB773520", VA = "0x18B774B20")]
		public GLTFRecorderHelper()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[TrackClipType(typeof(GLTFRecorderClip))]
	[TrackColor(0.7f, 0f, 0f)]
	public class GLTFRecorderTrack : TrackAsset
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0xB774BA0", Offset = "0xB7735A0", VA = "0x18B774BA0")]
		public GLTFRecorderTrack()
		{
		}
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	internal static class OUEDEJWSIBY
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		[CompilerGenerated]
		private sealed class VUGRTXXDLRI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			public int XTSDDDXIAPY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			public DFKZRGCXMVL LFKDJMEZNQX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			public GDYMUWMMRMB LFBNVDMHMZE;

			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public VUGRTXXDLRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0xB77CAE0", Offset = "0xB77B4E0", VA = "0x18B77CAE0")]
			internal float[] ULSLBINIQBX(GDYMUWMMRMB a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0xB77CA50", Offset = "0xB77B450", VA = "0x18B77CA50")]
			internal float[] ULNEEBTLGQO(GDYMUWMMRMB a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0xB77C9C0", Offset = "0xB77B3C0", VA = "0x18B77C9C0")]
			internal float[] ULHXGUZNXFF(GDYMUWMMRMB a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0xB77C930", Offset = "0xB77B330", VA = "0x18B77C930")]
			internal float[] ULCQJOFQNTW(GDYMUWMMRMB a, int b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private static readonly string[] LTZVQVNHNKC;

		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private static readonly string[] AUMFGNDHVGS;

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xB776AC0", Offset = "0xB7754C0", VA = "0x18B776AC0")]
		internal static bool WQCYDZXVTBL(string a, QOAMIPDEEWC b, Material c, string d, MSHGOIDHWYJ e, [Out] GDYMUWMMRMB f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xB776320", Offset = "0xB774D20", VA = "0x18B776320")]
		internal static string[] UZKGRINYEYS(string a, int b, int c = 0, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0xB7764D0", Offset = "0xB774ED0", VA = "0x18B7764D0")]
		internal static float[] VTNIBGWJEKU(int a, int b, DFKZRGCXMVL c, GDYMUWMMRMB d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class DFKZRGCXMVL
	{
		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		public enum PropertyTypeOption
		{
			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			LinearColor,
			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			SRGBColor,
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			Texture,
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			LinearTexture,
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			TextureTransform,
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			Float
		}

		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		public enum CombineResultType
		{
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			SameAsPrimary,
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			Override
		}

		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		public delegate float[] CombinePrimaryAndSecondaryData(float[] primary, float[] secondary, int expectedResultLength);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public PropertyTypeOption VJEXQKKNIZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public string ZBHIENVLXMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public string DCGONCTRBDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public bool HNHTDMHVEGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public CombineResultType PARHAYLVFJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public GLTFAccessorAttributeType FJOFNCYPIEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public bool ZNSMHUCDEUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public bool AIOHQPQTLFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x36")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public bool XJOHCPUEZCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public float FJOIZFFZPGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public string GXBJMQFTAWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public CombinePrimaryAndSecondaryData HPMOVIEZEHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private string[] TPHOBGKVGYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		internal int[] YGGXDENUEST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		internal int[] MVOCZUVMGKY;

		[Cpp2IlInjected.Token(Token = "0x17000190")]
		public string[] EWWPHSPZBNT
		{
			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DE0", Offset = "0xCD57E0", VA = "0x180CD6DE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0xB770ED0", Offset = "0xB76F8D0", VA = "0x18B770ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000191")]
		public bool MMTGWDJGRYZ
		{
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0xB770D90", Offset = "0xB76F790", VA = "0x18B770D90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0xB7711F0", Offset = "0xB76FBF0", VA = "0x18B7711F0")]
		public DFKZRGCXMVL(PropertyTypeOption a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xB770F00", Offset = "0xB76F900", VA = "0x18B770F00")]
		private void WAWILJBEIKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xB7710A0", Offset = "0xB76FAA0", VA = "0x18B7710A0")]
		private static float[] ZMOCXHLVVKK(float[] a, float[] b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xB770DB0", Offset = "0xB76F7B0", VA = "0x18B770DB0")]
		private void QJMFKHIWXES()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class QOAMIPDEEWC
	{
		[Cpp2IlInjected.Token(Token = "0x20000AA")]
		public enum ImportExportUsageOption
		{
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			ImportOnly,
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			ExportOnly,
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			ImportAndExport
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private Dictionary<string, DFKZRGCXMVL> LXGHWVQIIVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private Dictionary<string, DFKZRGCXMVL> MUZOAUTUULF;

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xB777D90", Offset = "0xB776790", VA = "0x18B777D90")]
		public void UVJCSPRXXDU(string a, string[] b, [Optional] string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xB7777A0", Offset = "0xB7761A0", VA = "0x18B7777A0")]
		public void PODWLZEFTYN(DFKZRGCXMVL a, ImportExportUsageOption b = ImportExportUsageOption.ImportAndExport)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0xB777580", Offset = "0xB775F80", VA = "0x18B777580")]
		public bool CKHHHCPJOJK(Material a, string b, [Out] DFKZRGCXMVL c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0xB7779C0", Offset = "0xB7763C0", VA = "0x18B7779C0")]
		public bool USKBILEDWLX(Material a, string b, [Out] string c, [Out] DFKZRGCXMVL d, [Out] bool e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0xB778290", Offset = "0xB776C90", VA = "0x18B778290")]
		public QOAMIPDEEWC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public class BOWDBIASQTJ : QOAMIPDEEWC
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0xB76DAB0", Offset = "0xB76C4B0", VA = "0x18B76DAB0")]
		public BOWDBIASQTJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public class AnimationPointerExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000192")]
		public override string WZGBLGIJCOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0xB76D460", Offset = "0xB76BE60", VA = "0x18B76D460", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000193")]
		public override string GSJQWDIOTQM
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0xB76D430", Offset = "0xB76BE30", VA = "0x18B76D430", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		public override bool MOVJBQXITYX
		{
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0xB76D390", Offset = "0xB76BD90", VA = "0x18B76D390", Slot = "14")]
		public override HMEEPODDUBT CreateInstance(SKRDRZRTZVR context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x160ED40", Offset = "0x160D740", VA = "0x18160ED40")]
		public AnimationPointerExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public class QZIXNIQIMAC : HMEEPODDUBT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public QOAMIPDEEWC EUCFUVKBAJM;

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0xB778340", Offset = "0xB776D40", VA = "0x18B778340")]
		public QZIXNIQIMAC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public class AnimationPointerImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000195")]
		public override string WZGBLGIJCOD
		{
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0xB76D560", Offset = "0xB76BF60", VA = "0x18B76D560", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000196")]
		public override string GSJQWDIOTQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0xB76D530", Offset = "0xB76BF30", VA = "0x18B76D530", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0xB76D490", Offset = "0xB76BE90", VA = "0x18B76D490", Slot = "13")]
		public override JVDZVLIBKQI CreateInstance(XNPFEZFVAYZ context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x160ED40", Offset = "0x160D740", VA = "0x18160ED40")]
		public AnimationPointerImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	public class XTSONFNBMEP : JVDZVLIBKQI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public QOAMIPDEEWC EUCFUVKBAJM;

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0xB77D0A0", Offset = "0xB77BAA0", VA = "0x18B77D0A0")]
		public XTSONFNBMEP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[AttributeUsage(AttributeTargets.Class)]
	public class NonRatifiedPluginAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public string tooltip;

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0xD007A0", Offset = "0xCFF1A0", VA = "0x180D007A0")]
		public NonRatifiedPluginAttribute([Optional] string tooltip)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[AttributeUsage(AttributeTargets.Class)]
	public class ExperimentalPluginAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public string tooltip;

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0xD007A0", Offset = "0xCFF1A0", VA = "0x180D007A0")]
		public ExperimentalPluginAttribute([Optional] string tooltip)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public abstract class GLTFExportPlugin : GLTFPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000197")]
		public virtual JToken FFYIFJGVZXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(Slot = "14")]
		public abstract HMEEPODDUBT CreateInstance(SKRDRZRTZVR context);

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x160ED40", Offset = "0x160D740", VA = "0x18160ED40")]
		protected GLTFExportPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public abstract class HMEEPODDUBT
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "4")]
		public virtual void CGPEUEFSVGN(GLTFSceneExporter a, GZYGZQSIZFV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
		public virtual void MFIEYBWZCZI(GLTFSceneExporter a, GZYGZQSIZFV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "6")]
		public virtual bool ZNUJWBMMAMP(GLTFSceneExporter a, GZYGZQSIZFV b, Transform c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "7")]
		public virtual void LSOYBVJZGZF(GLTFSceneExporter a, GZYGZQSIZFV b, Transform c, SIDFNDXEBQO d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "8")]
		public virtual void VIKYSQFVIMO(GLTFSceneExporter a, GZYGZQSIZFV b, Transform c, SIDFNDXEBQO d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "9")]
		public virtual bool VAJRWJGVQKO(GLTFSceneExporter a, GZYGZQSIZFV b, Material c, RLXWJRYFKUW d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "10")]
		public virtual void DXNJIUKEWRR(GLTFSceneExporter a, GZYGZQSIZFV b, Material c, RLXWJRYFKUW d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "11")]
		public virtual void VMLQTAFCKMW(GLTFSceneExporter a, GLTFSceneExporter.UniqueTexture b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "12")]
		public virtual void CYQORIYGWPX(GLTFSceneExporter a, GLTFSceneExporter.UniqueTexture b, int c, QSDNGVTLXBY d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "13")]
		public virtual void LJFHLHPDUTN(GLTFSceneExporter a, Mesh b, OKMUISONBMQ c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "14")]
		public virtual void IXBWDPSMTJB(GLTFSceneExporter a, Mesh b, MRVNGWGPAZI c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		protected HMEEPODDUBT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public abstract class GLTFImportPlugin : GLTFPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(Slot = "13")]
		public abstract JVDZVLIBKQI CreateInstance(XNPFEZFVAYZ context);

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x160ED40", Offset = "0x160D740", VA = "0x18160ED40")]
		protected GLTFImportPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public abstract class JVDZVLIBKQI
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "4")]
		public virtual void NDSOCEQFBHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
		public virtual void NOVQAMYCGTP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "6")]
		public virtual void ARHMLESVZVE(GZYGZQSIZFV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "7")]
		public virtual void DGPYBEBHSGH(TJCMXEZHJBP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "8")]
		public virtual void IGXYKHBALJM(SIDFNDXEBQO a, int b, GameObject c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "9")]
		public virtual void BJITLIHLWOP(RLXWJRYFKUW a, int b, Material c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "10")]
		public virtual void UNGPWFCEFFT(QSDNGVTLXBY a, int b, Texture c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "11")]
		public virtual void UVGSFZXUPMC(TJCMXEZHJBP a, int b, GameObject c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		protected JVDZVLIBKQI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public abstract class GLTFPlugin : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		[SerializeField]
		[HideInInspector]
		private bool enabled;

		[Cpp2IlInjected.Token(Token = "0x17000198")]
		public abstract string WZGBLGIJCOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		public virtual string GSJQWDIOTQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		public virtual string EDDINBIVGPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		public virtual bool BYWDFIHJUYL
		{
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0xB773B70", Offset = "0xB772570", VA = "0x18B773B70", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0xCD8BE0", Offset = "0xCD75E0", VA = "0x180CD8BE0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		public virtual bool MOVJBQXITYX
		{
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019D")]
		public virtual bool VYYIXRKPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		public virtual string SWOAQZYXRWS
		{
			[Cpp2IlInjected.Token(Token = "0x6000437")]
			[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		public virtual bool DIPZIQWEBMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x160ED40", Offset = "0x160D740", VA = "0x18160ED40")]
		protected GLTFPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[Obsolete("Use UnityGLTF.Plugins.GLTFPlugin instead. (UnityUpgradable) -> UnityGLTF.Plugins.GLTFPlugin")]
	public abstract class GltfPlugin : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0xD6AE70", Offset = "0xD69870", VA = "0x180D6AE70")]
		protected GltfPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[Obsolete("Use UnityGLTF.Plugins.GLTFImportPlugin instead. (UnityUpgradable) -> UnityGLTF.Plugins.GLTFImportPlugin")]
	public abstract class GltfImportPlugin : GltfPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0xD6AE70", Offset = "0xD69870", VA = "0x180D6AE70")]
		protected GltfImportPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[Obsolete("Use UnityGLTF.Plugins.GLTFExportPlugin instead. (UnityUpgradable) -> UnityGLTF.Plugins.GLTFExportPlugin")]
	public abstract class GltfExportPlugin : GltfPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0xD6AE70", Offset = "0xD69870", VA = "0x180D6AE70")]
		protected GltfExportPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public class XNPFEZFVAYZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public readonly List<JVDZVLIBKQI> XHNVQQJMGNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public GLTFSceneImporter MNCUKWQFMEY;

		[Cpp2IlInjected.Token(Token = "0x170001A0")]
		public GZYGZQSIZFV XJMGIEKJBLY
		{
			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0xB77CD10", Offset = "0xB77B710", VA = "0x18B77CD10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0xB77CD30", Offset = "0xB77B730", VA = "0x18B77CD30")]
		private List<JVDZVLIBKQI> QVIQXHKPWAE(GLTFSettings a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0xB77CF40", Offset = "0xB77B940", VA = "0x18B77CF40")]
		internal XNPFEZFVAYZ(GLTFSettings a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x411ABE0", Offset = "0x41195E0", VA = "0x18411ABE0")]
		public bool AQLBNXTCZCW<a>([Out] a a) where a : JVDZVLIBKQI
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public class DracoImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001A1")]
		public override string WZGBLGIJCOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0xB771840", Offset = "0xB770240", VA = "0x18B771840", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A2")]
		public override string GSJQWDIOTQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0xB771810", Offset = "0xB770210", VA = "0x18B771810", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A3")]
		public override bool DIPZIQWEBMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0xB7717C0", Offset = "0xB7701C0", VA = "0x18B7717C0", Slot = "13")]
		public override JVDZVLIBKQI CreateInstance(XNPFEZFVAYZ context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x160ED40", Offset = "0x160D740", VA = "0x18160ED40")]
		public DracoImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public class ATXHXVVDCRZ : JVDZVLIBKQI
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public ATXHXVVDCRZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public class GPUInstancingImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001A4")]
		public override string WZGBLGIJCOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0xB774C70", Offset = "0xB773670", VA = "0x18B774C70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A5")]
		public override string GSJQWDIOTQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(RVA = "0xB774C40", Offset = "0xB773640", VA = "0x18B774C40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0xB774BF0", Offset = "0xB7735F0", VA = "0x18B774BF0", Slot = "13")]
		public override JVDZVLIBKQI CreateInstance(XNPFEZFVAYZ context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x160ED40", Offset = "0x160D740", VA = "0x18160ED40")]
		public GPUInstancingImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public class CWJRWHQFBKM : JVDZVLIBKQI
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public CWJRWHQFBKM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public class Ktx2Import : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001A6")]
		public override string WZGBLGIJCOD
		{
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0xB774EA0", Offset = "0xB7738A0", VA = "0x18B774EA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A7")]
		public override string GSJQWDIOTQM
		{
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0xB774E70", Offset = "0xB773870", VA = "0x18B774E70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A8")]
		public override bool DIPZIQWEBMO
		{
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0xB774E20", Offset = "0xB773820", VA = "0x18B774E20", Slot = "13")]
		public override JVDZVLIBKQI CreateInstance(XNPFEZFVAYZ context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x160ED40", Offset = "0x160D740", VA = "0x18160ED40")]
		public Ktx2Import()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public class OAFDIATFJEB : JVDZVLIBKQI
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public OAFDIATFJEB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public class LightsPunctualExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001A9")]
		public override string WZGBLGIJCOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0xB774F50", Offset = "0xB773950", VA = "0x18B774F50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		public override string GSJQWDIOTQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0xB774F20", Offset = "0xB773920", VA = "0x18B774F20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0xB774ED0", Offset = "0xB7738D0", VA = "0x18B774ED0", Slot = "14")]
		public override HMEEPODDUBT CreateInstance(SKRDRZRTZVR context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x160ED40", Offset = "0x160D740", VA = "0x18160ED40")]
		public LightsPunctualExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public class BAXVOTXCFFY : HMEEPODDUBT
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "8")]
		public override void VIKYSQFVIMO(GLTFSceneExporter a, GZYGZQSIZFV b, Transform c, SIDFNDXEBQO d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public BAXVOTXCFFY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public class LightsPunctualImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		public override string WZGBLGIJCOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xB775000", Offset = "0xB773A00", VA = "0x18B775000", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public override string GSJQWDIOTQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xB774FD0", Offset = "0xB7739D0", VA = "0x18B774FD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0xB774F80", Offset = "0xB773980", VA = "0x18B774F80", Slot = "13")]
		public override JVDZVLIBKQI CreateInstance(XNPFEZFVAYZ context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x160ED40", Offset = "0x160D740", VA = "0x18160ED40")]
		public LightsPunctualImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public class HRFGMLINGIL : JVDZVLIBKQI
	{
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public HRFGMLINGIL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[NonRatifiedPlugin(null)]
	public class LodsExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		public override string WZGBLGIJCOD
		{
			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0xB7750B0", Offset = "0xB773AB0", VA = "0x18B7750B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		public override string GSJQWDIOTQM
		{
			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0xB775080", Offset = "0xB773A80", VA = "0x18B775080", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0xB775030", Offset = "0xB773A30", VA = "0x18B775030", Slot = "14")]
		public override HMEEPODDUBT CreateInstance(SKRDRZRTZVR context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x160ED40", Offset = "0x160D740", VA = "0x18160ED40")]
		public LodsExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public class TZGATCHSNOP : HMEEPODDUBT
	{
		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0xB7783B0", Offset = "0xB776DB0", VA = "0x18B7783B0", Slot = "8")]
		public override void VIKYSQFVIMO(GLTFSceneExporter a, GZYGZQSIZFV b, Transform c, SIDFNDXEBQO d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public TZGATCHSNOP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[NonRatifiedPlugin(null)]
	public class LodsImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		public override string WZGBLGIJCOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0xB775160", Offset = "0xB773B60", VA = "0x18B775160", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		public override string GSJQWDIOTQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0xB775130", Offset = "0xB773B30", VA = "0x18B775130", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0xB7750E0", Offset = "0xB773AE0", VA = "0x18B7750E0", Slot = "13")]
		public override JVDZVLIBKQI CreateInstance(XNPFEZFVAYZ context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x160ED40", Offset = "0x160D740", VA = "0x18160ED40")]
		public LodsImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public class OCVZDWLDYMW : JVDZVLIBKQI
	{
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public OCVZDWLDYMW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	public class MaterialExtensionsExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public bool KHR_materials_ior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public bool KHR_materials_transmission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public bool KHR_materials_volume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public bool KHR_materials_iridescence;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public bool KHR_materials_specular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public bool KHR_materials_clearcoat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public bool KHR_materials_emissive_strength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public bool KHR_materials_sheen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public bool KHR_materials_anisotropy;

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		public override string WZGBLGIJCOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0xB7756A0", Offset = "0xB7740A0", VA = "0x18B7756A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		public override string GSJQWDIOTQM
		{
			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0xB775670", Offset = "0xB774070", VA = "0x18B775670", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0xB7755F0", Offset = "0xB773FF0", VA = "0x18B7755F0", Slot = "14")]
		public override HMEEPODDUBT CreateInstance(SKRDRZRTZVR context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0xB775650", Offset = "0xB774050", VA = "0x18B775650")]
		public MaterialExtensionsExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public class UVGDPRVPIZQ : HMEEPODDUBT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		internal readonly MaterialExtensionsExport MDYCRUXTCID;

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private static readonly int WAJNZACUDOD;

		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private static readonly int YPPQYXBVRFF;

		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private static readonly int XGZRDVKYFQJ;

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private static readonly int RAJZLHOXKHD;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private static readonly int CKNBGQGLYGI;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private static readonly int STDHMODRJWJ;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private static readonly int SOYQIZXKUHT;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private static readonly int DOUAZHPRNAE;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private static readonly int HPVOFIGRVEB;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private static readonly int TIHJCLGHBXG;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private static readonly int BKALDNSSHUU;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private static readonly int VRKCBNVXPJU;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private static readonly int XJTNCENGZTD;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private static readonly int NOWRHFIJPTF;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private static readonly int FOCAZLSKWLW;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private static readonly int LFTZBSOOYGJ;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private static readonly int FVHSBCZMJVM;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private static readonly int FOYAUIDOCMF;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private static readonly int QCFKGKUCNFZ;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private static readonly int PMOCVZELYLZ;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private static readonly int KTCOTZTXFIF;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private static readonly int GXAHNYDDTOJ;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private static readonly int BDVFVRAXLRY;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private static readonly int FEVZSRFIPUB;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private static readonly int BRIBNNEQKCM;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private static readonly int HVVTNHEUQSR;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private static readonly int FXLULMQCCRU;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private static readonly int WTNOMFJIARZ;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private static readonly int RHNDVRBRRVS;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private static readonly int LKGVQZKHFLL;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0xCE33E0", Offset = "0xCE1DE0", VA = "0x180CE33E0")]
		public UVGDPRVPIZQ(MaterialExtensionsExport a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0xB779D80", Offset = "0xB778780", VA = "0x18B779D80", Slot = "10")]
		public override void DXNJIUKEWRR(GLTFSceneExporter a, GZYGZQSIZFV b, Material c, RLXWJRYFKUW d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public class MaterialExtensionsImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public bool KHR_materials_ior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public bool KHR_materials_transmission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public bool KHR_materials_volume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public bool KHR_materials_iridescence;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public bool KHR_materials_specular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public bool KHR_materials_clearcoat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public bool KHR_materials_sheen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		[HideInInspector]
		public bool KHR_materials_pbrSpecularGlossiness;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public bool KHR_materials_emissive_strength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public bool KHR_materials_anisotropy;

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		public override string WZGBLGIJCOD
		{
			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0xB775780", Offset = "0xB774180", VA = "0x18B775780", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		public override string GSJQWDIOTQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0xB775750", Offset = "0xB774150", VA = "0x18B775750", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0xB7756D0", Offset = "0xB7740D0", VA = "0x18B7756D0", Slot = "13")]
		public override JVDZVLIBKQI CreateInstance(XNPFEZFVAYZ context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0xB775730", Offset = "0xB774130", VA = "0x18B775730")]
		public MaterialExtensionsImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public class JCYHYIRJRFR : JVDZVLIBKQI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		internal readonly MaterialExtensionsImport MDYCRUXTCID;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0xCE33E0", Offset = "0xCE1DE0", VA = "0x180CE33E0")]
		public JCYHYIRJRFR(MaterialExtensionsImport a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public class MeshoptImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		public override string WZGBLGIJCOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0xB775830", Offset = "0xB774230", VA = "0x18B775830", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public override string GSJQWDIOTQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0xB775800", Offset = "0xB774200", VA = "0x18B775800", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		public override bool DIPZIQWEBMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0xB7757B0", Offset = "0xB7741B0", VA = "0x18B7757B0", Slot = "13")]
		public override JVDZVLIBKQI CreateInstance(XNPFEZFVAYZ context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x160ED40", Offset = "0x160D740", VA = "0x18160ED40")]
		public MeshoptImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public class EHIGLETEKMI : JVDZVLIBKQI
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public EHIGLETEKMI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public class TextureTransformExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001B8")]
		public override string WZGBLGIJCOD
		{
			[Cpp2IlInjected.Token(Token = "0x600047A")]
			[Cpp2IlInjected.Address(RVA = "0xB7787E0", Offset = "0xB7771E0", VA = "0x18B7787E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B9")]
		public override string GSJQWDIOTQM
		{
			[Cpp2IlInjected.Token(Token = "0x600047B")]
			[Cpp2IlInjected.Address(RVA = "0xB7787B0", Offset = "0xB7771B0", VA = "0x18B7787B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		public override bool VYYIXRKPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "14")]
		public override HMEEPODDUBT CreateInstance(SKRDRZRTZVR context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x160ED40", Offset = "0x160D740", VA = "0x18160ED40")]
		public TextureTransformExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public class TextureTransformImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001BB")]
		public override string WZGBLGIJCOD
		{
			[Cpp2IlInjected.Token(Token = "0x600047F")]
			[Cpp2IlInjected.Address(RVA = "0xB778840", Offset = "0xB777240", VA = "0x18B778840", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		public override string GSJQWDIOTQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000480")]
			[Cpp2IlInjected.Address(RVA = "0xB778810", Offset = "0xB777210", VA = "0x18B778810", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		public override bool VYYIXRKPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000481")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "13")]
		public override JVDZVLIBKQI CreateInstance(XNPFEZFVAYZ context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x160ED40", Offset = "0x160D740", VA = "0x18160ED40")]
		public TextureTransformImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public class UnlitMaterialsExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001BE")]
		public override string WZGBLGIJCOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000484")]
			[Cpp2IlInjected.Address(RVA = "0xB77C840", Offset = "0xB77B240", VA = "0x18B77C840", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		public override string GSJQWDIOTQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000485")]
			[Cpp2IlInjected.Address(RVA = "0xB77C810", Offset = "0xB77B210", VA = "0x18B77C810", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		public override bool VYYIXRKPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000486")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "14")]
		public override HMEEPODDUBT CreateInstance(SKRDRZRTZVR context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x160ED40", Offset = "0x160D740", VA = "0x18160ED40")]
		public UnlitMaterialsExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public class UnlitMaterialsImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001C1")]
		public override string WZGBLGIJCOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000489")]
			[Cpp2IlInjected.Address(RVA = "0xB77C8A0", Offset = "0xB77B2A0", VA = "0x18B77C8A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C2")]
		public override string GSJQWDIOTQM
		{
			[Cpp2IlInjected.Token(Token = "0x600048A")]
			[Cpp2IlInjected.Address(RVA = "0xB77C870", Offset = "0xB77B270", VA = "0x18B77C870", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C3")]
		public override bool VYYIXRKPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x600048B")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "13")]
		public override JVDZVLIBKQI CreateInstance(XNPFEZFVAYZ context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x160ED40", Offset = "0x160D740", VA = "0x18160ED40")]
		public UnlitMaterialsImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public class VisibilityExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		public override string WZGBLGIJCOD
		{
			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0xB77CBA0", Offset = "0xB77B5A0", VA = "0x18B77CBA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		public override string GSJQWDIOTQM
		{
			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0xB77CB70", Offset = "0xB77B570", VA = "0x18B77CB70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		public override bool VYYIXRKPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000490")]
			[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		public override bool MOVJBQXITYX
		{
			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "14")]
		public override HMEEPODDUBT CreateInstance(SKRDRZRTZVR context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x160ED40", Offset = "0x160D740", VA = "0x18160ED40")]
		public VisibilityExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public class VisibilityImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		public override string WZGBLGIJCOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000494")]
			[Cpp2IlInjected.Address(RVA = "0xB77CC00", Offset = "0xB77B600", VA = "0x18B77CC00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		public override string GSJQWDIOTQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000495")]
			[Cpp2IlInjected.Address(RVA = "0xB77CBD0", Offset = "0xB77B5D0", VA = "0x18B77CBD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CA")]
		public override bool VYYIXRKPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000496")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "13")]
		public override JVDZVLIBKQI CreateInstance(XNPFEZFVAYZ context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x160ED40", Offset = "0x160D740", VA = "0x18160ED40")]
		public VisibilityImport()
		{
		}
	}
}
namespace UnityGLTF.Loader
{
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public class WCYZDCVZTSD
	{
		[Cpp2IlInjected.Token(Token = "0x20000D7")]
		internal class InvalidStream : MemoryStream
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000403")]
			public readonly string RelativeFilePath;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000404")]
			public readonly string AbsoluteFilePath;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	public interface LLMQZYTPCVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Stream> MUXLSXZRHSS(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public interface GGRQSLPCQYY : LLMQZYTPCVY
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Stream DSTDNAEYQRM(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[Obsolete("Please switch to IDataLoader.  This interface is deprecated and will be removed in a future release.")]
	public interface DCQQDVPXHSS
	{
		[Cpp2IlInjected.Token(Token = "0x170001CB")]
		Stream LEUROTAOQZN
		{
			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		bool VYPDPRXHWEE
		{
			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task DSTDNAEYQRM(string a);

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GNVZNEUQZGF(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	public static class JUPHRCUDUZT
	{
		[Cpp2IlInjected.Token(Token = "0x20000DC")]
		private class DZXUXTSIBPI : LLMQZYTPCVY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000405")]
			protected readonly DCQQDVPXHSS VEXGBVNZOUQ;

			[Cpp2IlInjected.Token(Token = "0x60004A0")]
			[Cpp2IlInjected.Address(RVA = "0xCE33E0", Offset = "0xCE1DE0", VA = "0x180CE33E0")]
			public DZXUXTSIBPI(DCQQDVPXHSS a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A1")]
			[Cpp2IlInjected.Address(RVA = "0xB7716B0", Offset = "0xB7700B0", VA = "0x18B7716B0", Slot = "4")]
			public Task<Stream> MUXLSXZRHSS(string a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000DD")]
		private class WAZCWKJCYTS : DZXUXTSIBPI, GGRQSLPCQYY, LLMQZYTPCVY
		{
			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0xCE33E0", Offset = "0xCE1DE0", VA = "0x180CE33E0")]
			public WAZCWKJCYTS(DCQQDVPXHSS a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0xB77CC30", Offset = "0xB77B630", VA = "0x18B77CC30", Slot = "5")]
			public Stream DSTDNAEYQRM(string a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0xB774D10", Offset = "0xB773710", VA = "0x18B774D10")]
		public static LLMQZYTPCVY GLOTKAQKDIG(DCQQDVPXHSS a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public class CGEBZEQAXFZ : LLMQZYTPCVY
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000DF")]
		[CompilerGenerated]
		private struct <LoadStreamAsync>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000407")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000408")]
			public AsyncTaskMethodBuilder<Stream> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000409")]
			public CGEBZEQAXFZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400040A")]
			public string relativeFilePath;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400040B")]
			private string <path>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400040C")]
			private UnityWebRequest <request>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			private UnityWebRequestAsyncOperation <asyncOperation>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400040E")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0xB778870", Offset = "0xB777270", VA = "0x18B778870", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0xB778E50", Offset = "0xB777850", VA = "0x18B778E50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		private string KNHUXKOEMCJ;

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0xCE33E0", Offset = "0xCE1DE0", VA = "0x180CE33E0")]
		public CGEBZEQAXFZ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0xB770BA0", Offset = "0xB76F5A0", VA = "0x18B770BA0", Slot = "4")]
		[AsyncStateMachine(typeof(<LoadStreamAsync>d__2))]
		public Task<Stream> MUXLSXZRHSS(string a)
		{
			return null;
		}
	}
}
namespace UnityGLTF.Extensions
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public class EGLUDZKVBOV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private readonly List<KHR_animation_pointer> UGSRTKZTCPI;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private static readonly ProfilerMarker IJFOCCIJOZP;

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0xB771870", Offset = "0xB770270", VA = "0x18B771870")]
		public void Add(KHR_animation_pointer anim)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0xB771920", Offset = "0xB770320", VA = "0x18B771920")]
		public void MWPZFNJRHVQ(GLTFSceneExporter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0xB7722F0", Offset = "0xB770CF0", VA = "0x18B7722F0")]
		public EGLUDZKVBOV()
		{
		}
	}
}
namespace UnityGLTF.JsonPointer
{
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public interface PJROBXQNNIO
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool PYTYAQBQDPX(object a, string b);
	}
}
namespace UnityGLTF.Cache
{
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	public struct AnimationSamplerCacheData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public MSHGOIDHWYJ Input;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public MSHGOIDHWYJ Output;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public InterpolationType Interpolation;
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public class VFEMJBHISXA
	{
		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		public AnimationClip FBTVSGWQHXH
		{
			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0xCD6E00", Offset = "0xCD5800", VA = "0x180CD6E00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		public AnimationSamplerCacheData[] UYQYOANEFRF
		{
			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C00", Offset = "0xCD5600", VA = "0x180CD6C00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0xB77C8D0", Offset = "0xB77B2D0", VA = "0x18B77C8D0")]
		public VFEMJBHISXA(int a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public class MTYCYMHVAQI : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		public Stream[] TXHOYCLXTEL
		{
			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0xCD6E00", Offset = "0xCD5800", VA = "0x180CD6E00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		public Texture2D[] TJGXEMJGNRB
		{
			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C00", Offset = "0xCD5600", VA = "0x180CD6C00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D1")]
		public Texture2D[] EQMFYSXGKLC
		{
			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0xCD8610", Offset = "0xCD7010", VA = "0x180CD8610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		public ZUJCWCYEBVT[] UANDQKVDKDL
		{
			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CE0", Offset = "0xCD56E0", VA = "0x180CD6CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0xCD8620", Offset = "0xCD7020", VA = "0x180CD8620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		public ZLGIXFBPRYL[] GEIVRSGGRNZ
		{
			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C50", Offset = "0xCD5650", VA = "0x180CD6C50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0xCDF4B0", Offset = "0xCDDEB0", VA = "0x180CDF4B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		public VVVKILVSBKC[] KEHWDQNUGQS
		{
			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C20", Offset = "0xCD5620", VA = "0x180CD6C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0xCD6E40", Offset = "0xCD5840", VA = "0x180CD6E40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		public XONXWXBCMMT[] FTLCKNTYVMX
		{
			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DA0", Offset = "0xCD57A0", VA = "0x180CD6DA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DD0", Offset = "0xCD57D0", VA = "0x180CD6DD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		public BUQDIJQVFTU[] MHFOEFRWINK
		{
			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0xCD74F0", Offset = "0xCD5EF0", VA = "0x180CD74F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0xCD6E10", Offset = "0xCD5810", VA = "0x180CD6E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public VFEMJBHISXA[] TXRAJNVCXAS
		{
			[Cpp2IlInjected.Token(Token = "0x60004C2")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DE0", Offset = "0xCD57E0", VA = "0x180CD6DE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C3")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DF0", Offset = "0xCD57F0", VA = "0x180CD6DF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		public GameObject[] FKRIAHXQZUE
		{
			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C10", Offset = "0xCD5610", VA = "0x180CD6C10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C5")]
			[Cpp2IlInjected.Address(RVA = "0xCD7510", Offset = "0xCD5F10", VA = "0x180CD7510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0xB775310", Offset = "0xB773D10", VA = "0x18B775310")]
		public MTYCYMHVAQI(GZYGZQSIZFV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0xB775200", Offset = "0xB773C00", VA = "0x18B775200", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public class VVVKILVSBKC : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		public uint CDZCYUSUFPW
		{
			[Cpp2IlInjected.Token(Token = "0x60004C8")]
			[Cpp2IlInjected.Address(RVA = "0xCD5110", Offset = "0xCD3B10", VA = "0x180CD5110")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0xCDD360", Offset = "0xCDBD60", VA = "0x180CDD360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		public Stream LBBEJUXVCIW
		{
			[Cpp2IlInjected.Token(Token = "0x60004CA")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004CB")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C00", Offset = "0xCD5600", VA = "0x180CD6C00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		public NativeArray<byte> TKDVLCVYXME
		{
			[Cpp2IlInjected.Token(Token = "0x60004CC")]
			[Cpp2IlInjected.Address(RVA = "0xECCF90", Offset = "0xECB990", VA = "0x180ECCF90")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x60004CD")]
			[Cpp2IlInjected.Address(RVA = "0xF9DBB0", Offset = "0xF9C5B0", VA = "0x180F9DBB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x875C440", Offset = "0x875AE40", VA = "0x18875C440", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public VVVKILVSBKC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	internal static class XZWRZKWFYVM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0xF66910", Offset = "0xF65310", VA = "0x180F66910")]
		public static bool HDRXZFZQEUI(UnityEngine.Object a, string b, [Out] byte[] c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190")]
		public static void BXLWCBPVIJC(UnityEngine.Object a, string b, byte[] c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	public class ZLGIXFBPRYL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		public Material WISPRIZDAVY
		{
			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0xCD6E00", Offset = "0xCD5800", VA = "0x180CD6E00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		public Material TLMMXTYMWSH
		{
			[Cpp2IlInjected.Token(Token = "0x60004D4")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C00", Offset = "0xCD5600", VA = "0x180CD6C00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		public RLXWJRYFKUW RLXWJRYFKUW
		{
			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0xCD8610", Offset = "0xCD7010", VA = "0x180CD8610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0xB77E620", Offset = "0xB77D020", VA = "0x18B77E620", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public ZLGIXFBPRYL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public class XONXWXBCMMT : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		public class BSBRXYHIMIX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			public bool TXHAKXOPSVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000429")]
			public Dictionary<string, MSHGOIDHWYJ> CTMEUSHPFQH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042A")]
			public List<Dictionary<string, MSHGOIDHWYJ>> GDKAYGPCBNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			public Dictionary<string, (MSHGOIDHWYJ sparseIndices, MSHGOIDHWYJ sparseValues)> UNKVNIWSMUW;

			[Cpp2IlInjected.Token(Token = "0x60004DD")]
			[Cpp2IlInjected.Address(RVA = "0xB770A80", Offset = "0xB76F480", VA = "0x18B770A80")]
			public BSBRXYHIMIX()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public List<BSBRXYHIMIX> XOAVCJMDQTC;

		[Cpp2IlInjected.Token(Token = "0x170001DF")]
		public Mesh DYMFAIDQCTE
		{
			[Cpp2IlInjected.Token(Token = "0x60004D9")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004DA")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C00", Offset = "0xCD5600", VA = "0x180CD6C00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0xB77CF80", Offset = "0xB77B980", VA = "0x18B77CF80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0xB77D020", Offset = "0xB77BA20", VA = "0x18B77D020")]
		public XONXWXBCMMT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	public class NHNKKAKRJCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private bool ZEHEZKXRPYY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private int JDXIAXGIVKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private readonly object NFTBVYAVCCA;

		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		public XONXWXBCMMT[] FTLCKNTYVMX
		{
			[Cpp2IlInjected.Token(Token = "0x60004DE")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004DF")]
			[Cpp2IlInjected.Address(RVA = "0xCD8610", Offset = "0xCD7010", VA = "0x180CD8610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		public UnityEngine.Object[] DNEVHHXQSKC
		{
			[Cpp2IlInjected.Token(Token = "0x60004E0")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CE0", Offset = "0xCD56E0", VA = "0x180CD6CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E1")]
			[Cpp2IlInjected.Address(RVA = "0xCD8620", Offset = "0xCD7020", VA = "0x180CD8620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		public ZLGIXFBPRYL[] GEIVRSGGRNZ
		{
			[Cpp2IlInjected.Token(Token = "0x60004E2")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C50", Offset = "0xCD5650", VA = "0x180CD6C50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E3")]
			[Cpp2IlInjected.Address(RVA = "0xCDF4B0", Offset = "0xCDDEB0", VA = "0x180CDF4B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		public ZUJCWCYEBVT[] UANDQKVDKDL
		{
			[Cpp2IlInjected.Token(Token = "0x60004E4")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C20", Offset = "0xCD5620", VA = "0x180CD6C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E5")]
			[Cpp2IlInjected.Address(RVA = "0xCD6E40", Offset = "0xCD5840", VA = "0x180CD6E40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		public VFEMJBHISXA[] TXRAJNVCXAS
		{
			[Cpp2IlInjected.Token(Token = "0x60004E6")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DA0", Offset = "0xCD57A0", VA = "0x180CD6DA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E7")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DD0", Offset = "0xCD57D0", VA = "0x180CD6DD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		public Texture2D[] TJGXEMJGNRB
		{
			[Cpp2IlInjected.Token(Token = "0x60004E8")]
			[Cpp2IlInjected.Address(RVA = "0xCD74F0", Offset = "0xCD5EF0", VA = "0x180CD74F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E9")]
			[Cpp2IlInjected.Address(RVA = "0xCD6E10", Offset = "0xCD5810", VA = "0x180CD6E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0xB775FD0", Offset = "0xB7749D0", VA = "0x18B775FD0")]
		public NHNKKAKRJCL(ZLGIXFBPRYL[] a, XONXWXBCMMT[] b, ZUJCWCYEBVT[] c, Texture2D[] d, VFEMJBHISXA[] e, UnityEngine.Object[] f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0xB7759B0", Offset = "0xB7743B0", VA = "0x18B7759B0")]
		public void DFASOUOACKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0xB775E80", Offset = "0xB774880", VA = "0x18B775E80")]
		public void NLAQHRRIDFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0xB775A90", Offset = "0xB774490", VA = "0x18B775A90")]
		private void LSPPZVZOIYS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public class ZUJCWCYEBVT : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public QSDNGVTLXBY GJBKULZHOWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public Texture2D BZMNHFOXWWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public bool WGJDBLDFMHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public bool UTNASGHVADD;

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0xB77E720", Offset = "0xB77D120", VA = "0x18B77E720", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public ZUJCWCYEBVT()
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
