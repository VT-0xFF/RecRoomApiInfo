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
		private sealed class OKXTZWCBIVE : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private object PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public AsyncCoroutineHelper DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			private object LDTKDHZVICR
			{
				[Cpp2IlInjected.Token(Token = "0x6000008")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public OKXTZWCBIVE(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xB735AE0", Offset = "0xB7346E0", VA = "0x18B735AE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xB735AA0", Offset = "0xB7346A0", VA = "0x18B735AA0", Slot = "8")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
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
			[Cpp2IlInjected.Address(RVA = "0xB73B140", Offset = "0xB739D40", VA = "0x18B73B140", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xB73B330", Offset = "0xB739F30", VA = "0x18B73B330", Slot = "5")]
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
		private WaitForEndOfFrame UXWFWAPMEDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private float CGRIERDMGLK;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xB726D40", Offset = "0xB725940", VA = "0x18B726D40")]
		[AsyncStateMachine(typeof(<YieldOnTimeout>d__3))]
		public Task YieldOnTimeout()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xB726C40", Offset = "0xB725840", VA = "0x18B726C40")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB726CD0", Offset = "0xB7258D0", VA = "0x18B726CD0")]
		[IteratorStateMachine(typeof(OKXTZWCBIVE))]
		private IEnumerator XHOUQHWOYPJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xB726E10", Offset = "0xB725A10", VA = "0x18B726E10")]
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
			private JWRGHOMMCDX <importOptions>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private GLTFSceneImporter <sceneImporter>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xB736210", Offset = "0xB734E10", VA = "0x18B736210", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xB736F00", Offset = "0xB735B00", VA = "0x18B736F00", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xB736F60", Offset = "0xB735B60", VA = "0x18B736F60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
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
		private int BMSIFCVLJWK;

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
		public IEnumerable<Animation> DROKCMLLGAH
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xCF43A0", Offset = "0xCF2FA0", VA = "0x180CF43A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xCF4370", Offset = "0xCF2F70", VA = "0x180CF4370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public GameObject WJXYOLEPIZJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xCEE740", Offset = "0xCED340", VA = "0x180CEE740")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xCEE750", Offset = "0xCED350", VA = "0x180CEE750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Shader VMKNKVKLYKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xCEE720", Offset = "0xCED320", VA = "0x180CEE720")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xB727980", Offset = "0xB726580", VA = "0x18B727980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xB727860", Offset = "0xB726460", VA = "0x18B727860")]
		[AsyncStateMachine(typeof(<Start>d__33))]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xB727790", Offset = "0xB726390", VA = "0x18B727790")]
		[AsyncStateMachine(typeof(<Load>d__34))]
		public Task Load()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xB7276A0", Offset = "0xB7262A0", VA = "0x18B7276A0")]
		public void ApplyOverrideShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x109E2D0", Offset = "0x109CED0", VA = "0x18109E2D0")]
		private void RABFGYYMFGR(GameObject a, ExceptionDispatchInfo b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xB727910", Offset = "0xB726510", VA = "0x18B727910")]
		public GLTFComponent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class GLTFRecorderComponent : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class MELNSEACZXL : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private object PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public GLTFRecorderComponent DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object LDTKDHZVICR
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public MELNSEACZXL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xB735850", Offset = "0xB734450", VA = "0x18B735850", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xB735810", Offset = "0xB734410", VA = "0x18B735810", Slot = "8")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
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
		protected JXVLVTGIXHV XNRRSTRDOKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public UnityEvent recordingStarted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public UnityEvent<string> recordingEnded;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UIZBGUNRISX
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xB7281A0", Offset = "0xB726DA0", VA = "0x18B7281A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private double QYSRDIAABWE
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xB727B10", Offset = "0xB726710", VA = "0x18B727B10")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xB727B90", Offset = "0xB726790", VA = "0x18B727B90", Slot = "4")]
		[ContextMenu("Start Recording")]
		public virtual void StartRecording()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xB727F20", Offset = "0xB726B20", VA = "0x18B727F20", Slot = "5")]
		[ContextMenu("Stop Recording")]
		public virtual void StopRecording()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xB7279B0", Offset = "0xB7265B0", VA = "0x18B7279B0")]
		private void PGKSELWTYBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xB727E90", Offset = "0xB726A90", VA = "0x18B727E90")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xB727B70", Offset = "0xB726770", VA = "0x18B727B70")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xB727B20", Offset = "0xB726720", VA = "0x18B727B20", Slot = "6")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xB728090", Offset = "0xB726C90", VA = "0x18B728090", Slot = "7")]
		protected virtual void XYFUTYRXMOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xB728020", Offset = "0xB726C20", VA = "0x18B728020")]
		[IteratorStateMachine(typeof(MELNSEACZXL))]
		private IEnumerator XFSEKUXFTQD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xB7280E0", Offset = "0xB726CE0", VA = "0x18B7280E0")]
		public GLTFRecorderComponent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xB7279B0", Offset = "0xB7265B0", VA = "0x18B7279B0")]
		[CompilerGenerated]
		private void EOBHHXIBHZY(InputAction.CallbackContext a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class CEQPJQFTIIZ
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		internal class UIJCSCIICQL : JSPTBLBUDYT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private readonly CEQPJQFTIIZ ARTTYLSWGOO;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xD19810", Offset = "0xD18410", VA = "0x180D19810")]
			internal UIJCSCIICQL(CEQPJQFTIIZ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xB73B390", Offset = "0xB739F90", VA = "0x18B73B390", Slot = "4")]
			public override void ALDBYSRVLNZ(GLTFSceneExporter a, TBEADDWHLOJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xB73B690", Offset = "0xB73A290", VA = "0x18B73B690", Slot = "5")]
			public override void YSYXPGTUUFG(GLTFSceneExporter a, TBEADDWHLOJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xB73B3D0", Offset = "0xB739FD0", VA = "0x18B73B3D0", Slot = "8")]
			public override void KOAVTZEWSSQ(GLTFSceneExporter a, TBEADDWHLOJ b, Transform c, KTFAJFRQMLO d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xB73B490", Offset = "0xB73A090", VA = "0x18B73B490", Slot = "9")]
			public override bool NJGGHFTNWOE(GLTFSceneExporter a, TBEADDWHLOJ b, Material c, AHICOKAOCWI d)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xB73B5A0", Offset = "0xB73A1A0", VA = "0x18B73B5A0", Slot = "10")]
			public override void TRKJQUYUFPT(GLTFSceneExporter a, TBEADDWHLOJ b, Material c, AHICOKAOCWI d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xB73B450", Offset = "0xB73A050", VA = "0x18B73B450", Slot = "11")]
			public override void MAQEKIUTROA(GLTFSceneExporter a, GLTFSceneExporter.UniqueTexture b, string c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xB73B5E0", Offset = "0xB73A1E0", VA = "0x18B73B5E0", Slot = "12")]
			public override void XEBGBXMXZMH(GLTFSceneExporter a, GLTFSceneExporter.UniqueTexture b, int c, JQEEIHSQRHG d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xB73B650", Offset = "0xB73A250", VA = "0x18B73B650", Slot = "13")]
			public override void XOIZBTYWGCZ(GLTFSceneExporter a, Mesh b, ORTIZQKCQUO c, int d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xB73B410", Offset = "0xB73A010", VA = "0x18B73B410", Slot = "14")]
			public override void KQKZDNDZZNL(GLTFSceneExporter a, Mesh b, KHWXUNVOHHW c, int d)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public bool VTLFMEJFZWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public LayerMask IPZJVKAZSCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public ILogger QFGHHPYQYWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		internal readonly GLTFSettings QGQCMGPEQRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public GLTFSceneExporter.RetrieveTexturePathDelegate QTSWJYKELXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public GLTFSceneExporter.AfterSceneExportDelegate YSYXPGTUUFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public GLTFSceneExporter.BeforeSceneExportDelegate ALDBYSRVLNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public GLTFSceneExporter.AfterNodeExportDelegate KOAVTZEWSSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public GLTFSceneExporter.BeforeMaterialExportDelegate NJGGHFTNWOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public GLTFSceneExporter.AfterMaterialExportDelegate TRKJQUYUFPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public GLTFSceneExporter.BeforeTextureExportDelegate MAQEKIUTROA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public GLTFSceneExporter.AfterTextureExportDelegate XEBGBXMXZMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public GLTFSceneExporter.AfterPrimitiveExportDelegate XOIZBTYWGCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public GLTFSceneExporter.AfterMeshExportDelegate KQKZDNDZZNL;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xB727000", Offset = "0xB725C00", VA = "0x18B727000")]
		public CEQPJQFTIIZ(GLTFSettings a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xB726FA0", Offset = "0xB725BA0", VA = "0x18B726FA0")]
		internal JSPTBLBUDYT GSPOBQQJNNR()
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
		public delegate void BeforeSceneExportDelegate(GLTFSceneExporter exporter, TBEADDWHLOJ gltfRoot);

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public delegate void AfterSceneExportDelegate(GLTFSceneExporter exporter, TBEADDWHLOJ gltfRoot);

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void AfterNodeExportDelegate(GLTFSceneExporter exporter, TBEADDWHLOJ gltfRoot, Transform transform, KTFAJFRQMLO node);

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate bool BeforeMaterialExportDelegate(GLTFSceneExporter exporter, TBEADDWHLOJ gltfRoot, Material material, AHICOKAOCWI materialNode);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void AfterMaterialExportDelegate(GLTFSceneExporter exporter, TBEADDWHLOJ gltfRoot, Material material, AHICOKAOCWI materialNode);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void BeforeTextureExportDelegate(GLTFSceneExporter exporter, UniqueTexture texture, string textureSlot);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public delegate void AfterTextureExportDelegate(GLTFSceneExporter exporter, UniqueTexture texture, int index, JQEEIHSQRHG tex);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public delegate void AfterPrimitiveExportDelegate(GLTFSceneExporter exporter, Mesh mesh, ORTIZQKCQUO primitive, int index);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public delegate void AfterMeshExportDelegate(GLTFSceneExporter exporter, Mesh mesh, KHWXUNVOHHW gltfMesh, int index);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class VPQHQUSEBZI : JSPTBLBUDYT
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xB73C220", Offset = "0xB73AE20", VA = "0x18B73C220", Slot = "5")]
			public override void YSYXPGTUUFG(GLTFSceneExporter a, TBEADDWHLOJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xB73BF00", Offset = "0xB73AB00", VA = "0x18B73BF00", Slot = "4")]
			public override void ALDBYSRVLNZ(GLTFSceneExporter a, TBEADDWHLOJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xB73BF80", Offset = "0xB73AB80", VA = "0x18B73BF80", Slot = "8")]
			public override void KOAVTZEWSSQ(GLTFSceneExporter a, TBEADDWHLOJ b, Transform c, KTFAJFRQMLO d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xB73C020", Offset = "0xB73AC20", VA = "0x18B73C020", Slot = "9")]
			public override bool NJGGHFTNWOE(GLTFSceneExporter a, TBEADDWHLOJ b, Material c, AHICOKAOCWI d)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xB73C180", Offset = "0xB73AD80", VA = "0x18B73C180", Slot = "10")]
			public override void TRKJQUYUFPT(GLTFSceneExporter a, TBEADDWHLOJ b, Material c, AHICOKAOCWI d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
			public VPQHQUSEBZI()
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
			[Cpp2IlInjected.Address(RVA = "0xB7361D0", Offset = "0xB734DD0", VA = "0x18B7361D0")]
			public TextureExportSettings(TextureExportSettings source)
			{
			}

			[SpecialName]
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xB736190", Offset = "0xB734D90", VA = "0x18B736190")]
			public static bool IQJYWSDTJLC(TextureExportSettings a, TextureExportSettings b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xB735FB0", Offset = "0xB734BB0", VA = "0x18B735FB0")]
			public bool Equals(TextureExportSettings other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xB735F00", Offset = "0xB734B00", VA = "0x18B735F00", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xB736090", Offset = "0xB734C90", VA = "0x18B736090", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0xB73BD40", Offset = "0xB73A940", VA = "0x18B73BD40")]
			public int HKGKFVZRAVO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xB73BD80", Offset = "0xB73A980", VA = "0x18B73BD80")]
			public int MDDNERDZBBJ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xB73BE50", Offset = "0xB73AA50", VA = "0x18B73BE50")]
			public UniqueTexture(Texture tex, string textureSlot, GLTFSceneExporter exporter)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xB73BDC0", Offset = "0xB73A9C0", VA = "0x18B73BDC0")]
			public UniqueTexture(Texture tex, TextureExportSettings exportSettings)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xB73BAE0", Offset = "0xB73A6E0", VA = "0x18B73BAE0", Slot = "4")]
			public bool Equals(UniqueTexture other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xB73BA20", Offset = "0xB73A620", VA = "0x18B73BA20", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xB73BCA0", Offset = "0xB73A8A0", VA = "0x18B73BCA0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0xB73B6D0", Offset = "0xB73A2D0", VA = "0x18B73B6D0")]
			public bool Equals(UniquePrimitive other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xB73B820", Offset = "0xB73A420", VA = "0x18B73B820", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xB73B8D0", Offset = "0xB73A4D0", VA = "0x18B73B8D0", Slot = "2")]
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
			public ZIYZUENAFOS aPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public ZIYZUENAFOS aNormal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public ZIYZUENAFOS aTangent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public ZIYZUENAFOS aTexcoord0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public ZIYZUENAFOS aTexcoord1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public ZIYZUENAFOS aTexcoord2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public ZIYZUENAFOS aColor0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public ZIYZUENAFOS aJoints0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public ZIYZUENAFOS aWeights0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public Dictionary<int, ORTIZQKCQUO> subMeshPrimitives;
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private struct BlendShapeAccessors
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public List<Dictionary<string, ZIYZUENAFOS>> targets;

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
			public bool HSQBSPNKALL
			{
				[Cpp2IlInjected.Token(Token = "0x60000C7")]
				[Cpp2IlInjected.Address(RVA = "0xEC80A0", Offset = "0xEC6CA0", VA = "0x180EC80A0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public bool RMSLVEJUWWQ
			{
				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x88C6D90", Offset = "0x88C5990", VA = "0x1888C6D90")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xB735DA0", Offset = "0xB7349A0", VA = "0x18B735DA0")]
			public SamplerRelevantTextureData(Texture texture)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xB735CF0", Offset = "0xB7348F0", VA = "0x18B735CF0", Slot = "4")]
			public bool Equals(SamplerRelevantTextureData other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xB735C30", Offset = "0xB734830", VA = "0x18B735C30", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xB735D20", Offset = "0xB734920", VA = "0x18B735D20", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class KXOLFQMNNVI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public bool BIVVPPWMYOO;

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public KXOLFQMNNVI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xB7356B0", Offset = "0xB7342B0", VA = "0x18B7356B0")]
			internal Color RTCMOSYVJBV(object a)
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class KXTSCXGKXGR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public float BYNPLPXHRFJ;

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public KXTSCXGKXGR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xB7357B0", Offset = "0xB7343B0", VA = "0x18B7357B0")]
			internal float RSXFRMEXZQM(object a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class XHFDMLKRNUB : IEnumerable<(int, ORTIZQKCQUO)>, IEnumerable, IEnumerator<(int, ORTIZQKCQUO)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private (int subMeshIndex, ORTIZQKCQUO prim) PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private int DQGTEBFWJSV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public GLTFSceneExporter DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private Mesh DYAVLLMSCBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public Mesh ULRVQUFWMVK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private Dictionary<int, ORTIZQKCQUO>.Enumerator MOIGOWZIHVC;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private (int, ORTIZQKCQUO) CEJIFANJPTY
			{
				[Cpp2IlInjected.Token(Token = "0x60000E5")]
				[Cpp2IlInjected.Address(RVA = "0xD88830", Offset = "0xD87430", VA = "0x180D88830", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((int, ORTIZQKCQUO));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0xB73C350", Offset = "0xB73AF50", VA = "0x18B73C350", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1D02EC0", Offset = "0x1D01AC0", VA = "0x181D02EC0")]
			[DebuggerHidden]
			public XHFDMLKRNUB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xB73C6B0", Offset = "0xB73B2B0", VA = "0x18B73C6B0", Slot = "7")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xB73C3E0", Offset = "0xB73AFE0", VA = "0x18B73C3E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xB73C740", Offset = "0xB73B340", VA = "0x18B73C740")]
			private void SYBUDUAVPHD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xB73C3A0", Offset = "0xB73AFA0", VA = "0x18B73C3A0", Slot = "10")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xB73C2A0", Offset = "0xB73AEA0", VA = "0x18B73C2A0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(int, ORTIZQKCQUO)> AAUYTVFLGJX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xB73C2A0", Offset = "0xB73AEA0", VA = "0x18B73C2A0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator IEVKUCCAWWZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static ILogger PFAJKELISZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private List<JSPTBLBUDYT> XRTWVWUAABZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private Transform[] YGXJBSJRHZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private TBEADDWHLOJ YPZTFWZJQOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private CCIZODPLJBR VNEDKOJEBDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private XLUTOTUKWDR RNLJGBXEMLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private List<ImageInfo> IDBNYMMKKQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private HashSet<string> CNGJUFGVRYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private List<FileInfo> UGNCCPYNDMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private HashSet<string> OKJIJPLOFXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private List<UniqueTexture> APKTMFWIXNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private Dictionary<int, int> MTELFJKAVYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private bool PTHYUJCWLBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private Dictionary<int, int> GKSPUNYDMKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private List<Transform> HCIYDNKUOAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private int KOZZICPLQCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private CEQPJQFTIIZ ARTTYLSWGOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private Material LHNBKRLSRPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private Material KAFMKEPTKII;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private Material MRJFYQSOETK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private bool FYZMTPGYKMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly Dictionary<UniquePrimitive, IUZCCLJFKFO> CJLBLTBDORS;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static ProfilerMarker AZORYHXMGGB;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static ProfilerMarker XTSPVXVAYXD;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static ProfilerMarker QLYOCASGUEF;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static ProfilerMarker EPFYUDYYQDL;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static ProfilerMarker XPANKNEQRWM;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static ProfilerMarker XQKSNNEKMRD;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static ProfilerMarker BNGRBJJANDZ;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static ProfilerMarker VQDZZDYMEPN;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static ProfilerMarker DGWVPOGAPUE;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static ProfilerMarker DTHXRYVLVRQ;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static ProfilerMarker WUPJEPJIREG;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static ProfilerMarker EIRVHAWPKUL;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static ProfilerMarker FJSIKBYCSCB;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static ProfilerMarker MZKDOREANHC;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static ProfilerMarker DWARWPEDSUS;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static ProfilerMarker QZDUUFNPXCB;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static ProfilerMarker PVWUMQBIMDR;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static ProfilerMarker JSYZXQKYEVU;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static ProfilerMarker INSXLEGPOYC;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static ProfilerMarker LVYRMEARHLN;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static ProfilerMarker TZTPZAMMWGX;

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static ProfilerMarker OCUAPTGBJKJ;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private static ProfilerMarker WQTMHTHUFWY;

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private static ProfilerMarker MEAQSUROUWT;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private static ProfilerMarker DPABWTIDUNQ;

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private static ProfilerMarker PPIDJOPDZNZ;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static ProfilerMarker XPZEWONVHCO;

		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private static ProfilerMarker YBSLRTYFPCV;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static ProfilerMarker TQSZTXBIIKA;

		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private static ProfilerMarker REOVFAZQKVU;

		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private static ProfilerMarker DWYOMNKHTCN;

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private static ProfilerMarker ATUBSAUYVII;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private static ProfilerMarker FBTJRVFRERR;

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private static ProfilerMarker RUWFDWWJAZU;

		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private static ProfilerMarker LRMXUCFGTGQ;

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private static ProfilerMarker RBIOZXLZYOL;

		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private static ProfilerMarker BSDJZGXGJGB;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private static ProfilerMarker KIMBERHQHLG;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static ProfilerMarker RTZUVUKMDUX;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private static ProfilerMarker KVANVFQJZHW;

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private static ProfilerMarker OKHRTRBQGMV;

		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private static ProfilerMarker IGQXPXSSENB;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private static ProfilerMarker FLFTGDJTZSN;

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static ProfilerMarker AQZICJQBCPC;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static ProfilerMarker IQQZIJQQAFT;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static ProfilerMarker LUYJSVASVIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private UnityGLTF.BinaryWriterWithLessAllocations HQPASEJAVCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private bool? WRCAPYHYNIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		internal readonly List<VTPBJIBSSFS> PHTXTFBHIGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly NYYAONCBFDF FSEZIGNDCON;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private Dictionary<int, int> GBKZGZOHBPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private Dictionary<int, int> XYWEVTEKTMD;

		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[CompilerGenerated]
		private static BeforeSceneExportDelegate ALDBYSRVLNZ;

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[CompilerGenerated]
		private static AfterSceneExportDelegate YSYXPGTUUFG;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[CompilerGenerated]
		private static AfterNodeExportDelegate KOAVTZEWSSQ;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[CompilerGenerated]
		private static BeforeMaterialExportDelegate NJGGHFTNWOE;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[CompilerGenerated]
		private static AfterMaterialExportDelegate TRKJQUYUFPT;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static Material PUDHWKCBMNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private HashSet<Material> OUEBHDNEZIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly Dictionary<Mesh, MeshAccessors> MZYGFFAZPLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly Dictionary<Mesh, BlendShapeAccessors> HIOKNWLJSKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly Dictionary<SkinnedMeshRenderer, List<double>> PAUXHKBMZQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private List<Transform> ODTMQXWJXFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private Dictionary<SkinnedMeshRenderer, Mesh> LKFVFFSVEKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private Dictionary<SamplerRelevantTextureData, int> TLXOTJQFOXH;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public IReadOnlyList<Transform> HFGNFGTENWV
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private GLTFSettings QGQCMGPEQRD
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xB71E0D0", Offset = "0xB71CCD0", VA = "0x18B71E0D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private bool MJHTFKNNCBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xB70F8B0", Offset = "0xB70E4B0", VA = "0x18B70F8B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private bool AKDYMGMPJNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xB720AD0", Offset = "0xB71F6D0", VA = "0x18B720AD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private bool RPTGHEPHGNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xB7207B0", Offset = "0xB71F3B0", VA = "0x18B7207B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static Material IUVAXHLAZJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xB722410", Offset = "0xB721010", VA = "0x18B722410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xB718C30", Offset = "0xB717830", VA = "0x18B718C30")]
		public TextureExportSettings MGBLKSPBXUC(string a)
		{
			return default(TextureExportSettings);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xB71DD10", Offset = "0xB71C910", VA = "0x18B71DD10")]
		private Material OHPHVLFAKYF(TextureExportSettings a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xB70BD70", Offset = "0xB70A970", VA = "0x18B70BD70")]
		private static Material CJFJJTSVMKA(Material a, TextureExportSettings b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xB7253A0", Offset = "0xB723FA0", VA = "0x18B7253A0")]
		public GLTFSceneExporter(Transform[] rootTransforms, CEQPJQFTIIZ context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xB718210", Offset = "0xB716E10", VA = "0x18B718210")]
		public void MCSAPUWUNIB(Stream a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xB70C110", Offset = "0xB70AD10", VA = "0x18B70C110")]
		public void DDKYCGNPYTQ(string a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xB70B840", Offset = "0xB70A440", VA = "0x18B70B840")]
		private bool AGXIGOJEUCT(Transform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xB71E450", Offset = "0xB71D050", VA = "0x18B71E450")]
		private DQIYXKVQHYZ QFCHJCYXZNY(string a, Transform[] b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xB715310", Offset = "0xB713F10", VA = "0x18B715310")]
		private POILAGDGQRH KUFFCTDPJAG(Transform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xB716EA0", Offset = "0xB715AA0", VA = "0x18B716EA0")]
		private static bool LHWGKGIUNCG(GameObject a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xB70A570", Offset = "0xB709170", VA = "0x18B70A570")]
		private void AEJKIMXHYVK(Transform a, [Out] GameObject[] b, [Out] GameObject[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xB713820", Offset = "0xB712420", VA = "0x18B713820")]
		private void HDGKCYHTMVK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xB7222C0", Offset = "0xB720EC0", VA = "0x18B7222C0")]
		public NXKPCLUJUNS UNGQJLFHFAU(TBEADDWHLOJ a, Material b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xB7227D0", Offset = "0xB7213D0", VA = "0x18B7227D0")]
		public OWKTOJURGXA WIASSWVJDLY(TBEADDWHLOJ a, UniqueTexture b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xB71E280", Offset = "0xB71CE80", VA = "0x18B71E280")]
		public NGZVCNLAQPS QAXFBURGODW(TBEADDWHLOJ a, Texture b, TextureExportSettings c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xB7138B0", Offset = "0xB7124B0", VA = "0x18B7138B0")]
		private static void HHHPOVAJHCV(Stream a, BinaryWriter b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xB71C2D0", Offset = "0xB71AED0", VA = "0x18B71C2D0")]
		private static void MPFZFSJLKZY(Stream a, byte b = 32, uint c = 4u)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xB722B20", Offset = "0xB721720", VA = "0x18B722B20")]
		public static uint WOUJNYEXOAJ(uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xB71E8E0", Offset = "0xB71D4E0", VA = "0x18B71E8E0")]
		private ZIYZUENAFOS QKFPTHXYPBT(Vector4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xB71F1E0", Offset = "0xB71DDE0", VA = "0x18B71F1E0")]
		private ZIYZUENAFOS QKRVZWQXHCS(Quaternion[] a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xB71BE30", Offset = "0xB71AA30", VA = "0x18B71BE30")]
		private ZIYZUENAFOS MJBEBJEDXRP(Matrix4x4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xB719680", Offset = "0xB718280", VA = "0x18B719680")]
		private ZIYZUENAFOS MJBEBJEDXRP(float[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xB718F30", Offset = "0xB717B30", VA = "0x18B718F30")]
		private ZIYZUENAFOS MJBEBJEDXRP(int[] a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xB71AEA0", Offset = "0xB719AA0", VA = "0x18B71AEA0")]
		private ZIYZUENAFOS MJBEBJEDXRP(Vector2[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xB71A760", Offset = "0xB719360", VA = "0x18B71A760")]
		private ZIYZUENAFOS MJBEBJEDXRP(Vector3[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xB70A7F0", Offset = "0xB7093F0", VA = "0x18B70A7F0")]
		private ZIYZUENAFOS AFALIXAPMDT(ZIYZUENAFOS a, Vector3[] b, Vector3[] c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xB71B530", Offset = "0xB71A130", VA = "0x18B71B530")]
		private ZIYZUENAFOS MJBEBJEDXRP(Vector4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xB719BB0", Offset = "0xB7187B0", VA = "0x18B719BB0")]
		private ZIYZUENAFOS MJBEBJEDXRP(Color[] a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xB720940", Offset = "0xB71F540", VA = "0x18B720940")]
		private QJGNWPOVIOK SHBLCNVOHHP(uint a, uint b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		public void HYTZBTDDHYU(Transform a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xB70B9A0", Offset = "0xB70A5A0", VA = "0x18B70B9A0")]
		internal int AQODNMLKEKE(object a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xB714D40", Offset = "0xB713940", VA = "0x18B714D40")]
		public int JHEOCLPLGWI(Transform a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xB722710", Offset = "0xB721310", VA = "0x18B722710")]
		public int VYFWOMMSQUD(Material a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xB71DC50", Offset = "0xB71C850", VA = "0x18B71DC50")]
		public int NSXXZNNNFTC(Light a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xB722650", Offset = "0xB721250", VA = "0x18B722650")]
		public int VXKIWRISCXT(Camera a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xB722190", Offset = "0xB720D90", VA = "0x18B722190")]
		[IteratorStateMachine(typeof(XHFDMLKRNUB))]
		public IEnumerable<(int, ORTIZQKCQUO)> TRTLOXRZIRW(Mesh a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xB7205E0", Offset = "0xB71F1E0", VA = "0x18B7205E0")]
		private static void SCWBFWLAAHL(Color a, [Out] Color b, [Out] float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xB712BD0", Offset = "0xB7117D0", VA = "0x18B712BD0")]
		private static void FKQSFDYEWSC(Vector4 a, [Out] Vector2 b, [Out] Vector2 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xB71E0F0", Offset = "0xB71CCF0", VA = "0x18B71E0F0")]
		private bool PKWRJZDXJFJ(object[] a, int b, int c, int d, int e, int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xB722B40", Offset = "0xB721740", VA = "0x18B722B40")]
		public void WXFYIBVDLSX(float[] a, object[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xB7102E0", Offset = "0xB70EEE0", VA = "0x18B7102E0")]
		public void EXOELWJXRYH(UnityEngine.Object a, string b, KTVCVTRZYQB c, float[] d, object[] e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xB7245A0", Offset = "0xB7231A0", VA = "0x18B7245A0")]
		private void ZGVXBCDOWQR(object a, string b, ZMLWMRNUPSM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xB720B00", Offset = "0xB71F700", VA = "0x18B720B00")]
		private ZGJGJNHLPBE TKLHINJLTOF(Camera a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xB723D20", Offset = "0xB722920", VA = "0x18B723D20")]
		private WFKNWWFNLGZ XFILDCVWOPM(Light a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xB70D310", Offset = "0xB70BF10", VA = "0x18B70D310")]
		public NXKPCLUJUNS DPQITYSDONZ(Material a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xB717EF0", Offset = "0xB716AF0", VA = "0x18B717EF0")]
		private NXKPCLUJUNS LZLTPQOIIPC(Material a, AHICOKAOCWI b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xB722960", Offset = "0xB721560", VA = "0x18B722960")]
		private bool WLMOBMOKFYN(Material a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xB721000", Offset = "0xB71FC00", VA = "0x18B721000")]
		private bool TMCACTLEWGM(Material a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xB71C3C0", Offset = "0xB71AFC0", VA = "0x18B71C3C0")]
		private bool NAVJWETAVEH(Material a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xB722220", Offset = "0xB720E20", VA = "0x18B722220")]
		private bool TSWOKGGLCWN(Material a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xB716CA0", Offset = "0xB7158A0", VA = "0x18B716CA0")]
		private static bool KZTSOMOBJWU(Shader a, string b, ShaderPropertyType c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xB70F8E0", Offset = "0xB70E4E0", VA = "0x18B70F8E0")]
		private void DZHYYHUKVED(LIQIFNODJDV a, Material b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xB714B50", Offset = "0xB713750", VA = "0x18B714B50")]
		public DLLPPIABIIS IUUPWNOUMNW(Texture a, string b, Material c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xB716D40", Offset = "0xB715940", VA = "0x18B716D40")]
		private QCXDUOOYVAQ LGBWJFHJBHQ(Texture a, string b, Material c, [Optional] OWKTOJURGXA d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xB70C320", Offset = "0xB70AF20", VA = "0x18B70C320")]
		public HNMBPMXVUOV DHVMANRNWEL(Material a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xB7200B0", Offset = "0xB71ECB0", VA = "0x18B7200B0")]
		public void RNNKOFLOZUK(AHICOKAOCWI a, Material b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xB712C00", Offset = "0xB711800", VA = "0x18B712C00")]
		private void GLKTCCKXRUZ(AHICOKAOCWI a, Material b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xB71C430", Offset = "0xB71B030", VA = "0x18B71C430")]
		private IUASTIQFQVK NFDLZHXFLRV(Material a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xB715240", Offset = "0xB713E40", VA = "0x18B715240")]
		internal static void KOHMZZKJMQP(Color a, [Out] Color b, [Out] float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xB71DE10", Offset = "0xB71CA10", VA = "0x18B71DE10")]
		public void OSXGSCPLZDR(KTFAJFRQMLO a, List<UniquePrimitive> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xB7143D0", Offset = "0xB712FD0", VA = "0x18B7143D0")]
		private static List<UniquePrimitive> IFVYQLYMJVT(IEnumerable<GameObject> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xB7152D0", Offset = "0xB713ED0", VA = "0x18B7152D0")]
		public POILAGDGQRH KUFFCTDPJAG(GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xB709E70", Offset = "0xB708A70", VA = "0x18B709E70")]
		public IUZCCLJFKFO ABWDHHMECIX(string a, List<UniquePrimitive> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xB71C7F0", Offset = "0xB71B3F0", VA = "0x18B71C7F0")]
		private ORTIZQKCQUO[] NNCZVNWJWYL(UniquePrimitive a, KHWXUNVOHHW b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xB71FCE0", Offset = "0xB71E8E0", VA = "0x18B71FCE0")]
		private List<double> RKICXOTAZEV(SkinnedMeshRenderer a, Mesh b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xB713980", Offset = "0xB712580", VA = "0x18B713980")]
		private void HMYFATYKKPR(SkinnedMeshRenderer a, Mesh b, int c, ORTIZQKCQUO d, KHWXUNVOHHW e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xB71DDF0", Offset = "0xB71C9F0", VA = "0x18B71DDF0")]
		private static bool OSLHUOWYJSS(ORTIZQKCQUO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xB70C010", Offset = "0xB70AC10", VA = "0x18B70C010")]
		private static DrawMode DCJQJMTHGHP(MeshTopology a)
		{
			return default(DrawMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xB71C3A0", Offset = "0xB71AFA0", VA = "0x18B71C3A0")]
		private static bool MXOLCLZOHVX(Mesh a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xB7210C0", Offset = "0xB71FCC0", VA = "0x18B7210C0")]
		private void TNUJKUKRWLB(Transform a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xB71FE80", Offset = "0xB71EA80", VA = "0x18B71FE80")]
		private Mesh RNBUYKKCOZW(GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xB7246F0", Offset = "0xB7232F0", VA = "0x18B7246F0")]
		private Material[] ZSCDSWOVGFJ(GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xB714E00", Offset = "0xB713A00", VA = "0x18B714E00")]
		private Vector4[] JZHWRZSTZNR(BoneWeight[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xB71DF80", Offset = "0xB71CB80", VA = "0x18B71DF80")]
		private Vector4[] PFONKLWMLIZ(BoneWeight[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xB717CD0", Offset = "0xB7168D0", VA = "0x18B717CD0")]
		private string LPFKITGOKEI(HashSet<string> a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xB718B20", Offset = "0xB717720", VA = "0x18B718B20")]
		public LIQIFNODJDV MDFFRAEHRFT(Texture a, string b, [Optional] TextureExportSettings c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xB7244B0", Offset = "0xB7230B0", VA = "0x18B7244B0")]
		public LIQIFNODJDV YCZERQRIGXC(Material a, Texture b, string c, [Optional] TextureExportSettings d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xB723390", Offset = "0xB721F90", VA = "0x18B723390")]
		public OWKTOJURGXA XBHWGWGDAIB(Texture a, string b, [Optional] TextureExportSettings c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xB714F90", Offset = "0xB713B90", VA = "0x18B714F90")]
		private string KJOESBBSXYL(Texture a, TextureExportSettings b, string c, [Out] bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xB716340", Offset = "0xB714F40", VA = "0x18B716340")]
		private NGZVCNLAQPS KUTTBMNEMHV(UniqueTexture a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5B31010", Offset = "0x5B2FC10", VA = "0x185B31010")]
		private bool TGJAKTQEBKY(TextureExportSettings a, Texture b, [Out] string c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40")]
		private byte[] JEWETTKYSZY(Texture a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xB70BCE0", Offset = "0xB70A8E0", VA = "0x18B70BCE0")]
		private bool CCMPXOIBFFI(Texture a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xB70D290", Offset = "0xB70BE90", VA = "0x18B70D290")]
		private bool DHVWAPTEGMP(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xB71FC10", Offset = "0xB71E810", VA = "0x18B71FC10")]
		private bool RKESLODFUZU(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xB717110", Offset = "0xB715D10", VA = "0x18B717110")]
		private NGZVCNLAQPS LNXCKDUBQKY(UniqueTexture a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xB713350", Offset = "0xB711F50", VA = "0x18B713350")]
		private NXJSAPWDUNT GTYWOROPOWG(Texture a)
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
	public class JWRGHOMMCDX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public URCYQYUQHXW VCFMMLLZWLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public WICTABXLPMU ZSUZHBCYPHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public AsyncCoroutineHelper TRRFBIMTAHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public bool EYDXAODZVPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public AnimationMethod TWUWGDNAUIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public bool LRHPKMUXFSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public DeduplicateOptions MMFMSWMZJCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public bool UFCSZYBXCMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public GLTFImporterNormals IPCYZKQYPGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public GLTFImporterNormals AIKBEIWIGGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public bool CAYFFAECWQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public CameraImportOption GOLZKGAIPAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public RuntimeTextureCompression EJRHRWXMOFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public BlendShapeFrameWeightSetting VINCUHJLEGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public VUSAZGCWQUD QDUWEEMDQSI;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public ILogger QFGHHPYQYWY;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xB7355D0", Offset = "0xB7341D0", VA = "0x18B7355D0")]
		public JWRGHOMMCDX()
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
		public float DPAWOMDCAZZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xB7350B0", Offset = "0xB733CB0", VA = "0x18B7350B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xB7350E0", Offset = "0xB733CE0", VA = "0x18B7350E0", Slot = "3")]
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
		private class HBGXJJDPUGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Texture DPNAWKZJIJZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public int TYHZYUEJSLU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public double ZTAOSGFFLWP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Vector2 RFBIZEQGAWX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public double KGAYDLOYNUK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Vector2 JBTKORXHGDU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public int? WVHZTMBYGHC;

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0xB734FC0", Offset = "0xB733BC0", VA = "0x18B734FC0")]
			public HBGXJJDPUGP()
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
			public AsyncTaskMethodBuilder<LOWENHEWMHZ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public ZIYZUENAFOS accessorId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public bool isPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			private UCTZRFDQUFN <accessor>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			private TaskAwaiter<TJELPNODSRG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xB739130", Offset = "0xB737D30", VA = "0x18B739130", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0xB739640", Offset = "0xB738240", VA = "0x18B739640", Slot = "5")]
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
			public KTVCVTRZYQB animation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			public YHGZCDIUCBS animationCache;
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class FYOVJUMCYVB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public AITVUNWJGXJ MEFHLEDOGNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			public ValuesConvertion QKRWUSDOABV;

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public FYOVJUMCYVB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0xB7272F0", Offset = "0xB725EF0", VA = "0x18B7272F0")]
			internal float[] RNCUTTZMDNP(NumericArray a, int b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class FYUCHBGAIGK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public bool CRPQSSNYIXP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			public int HTCWVTPAJEU;

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public FYUCHBGAIGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xB727330", Offset = "0xB725F30", VA = "0x18B727330")]
			internal float[] RKHCGDGXBKT(NumericArray a, int b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class FYZJEHZXRRT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			public float[] FEPURMBCVQW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			public BlendShapeFrameWeightSetting OYCQEJMLVVH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			public FYUCHBGAIGK FWYXBYDFGWV;

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public FYZJEHZXRRT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0xB7275D0", Offset = "0xB7261D0", VA = "0x18B7275D0")]
			internal float[] VIDNJLIIQQY(NumericArray a, int b)
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
			public FPFJFXFEQVP mapper;
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class TEOAQSXTFHF
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
				public TEOAQSXTFHF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400016A")]
				private AHICOKAOCWI <def>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400016B")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000177")]
				[Cpp2IlInjected.Address(RVA = "0xB7396B0", Offset = "0xB7382B0", VA = "0x18B7396B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000178")]
				[Cpp2IlInjected.Address(RVA = "0xB739AD0", Offset = "0xB7386D0", VA = "0x18B739AD0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public int JHTHHALIJFZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public GLTFSceneImporter DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public TEOAQSXTFHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0xB735E30", Offset = "0xB734A30", VA = "0x18B735E30")]
			[AsyncStateMachine(typeof(<<LoadMaterialAsync>b__0>d))]
			internal Task XCSFYLTHKRV()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private sealed class PESUUACAAXA
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
				public PESUUACAAXA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000172")]
				private KHWXUNVOHHW <def>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000173")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600017B")]
				[Cpp2IlInjected.Address(RVA = "0xB739B30", Offset = "0xB738730", VA = "0x18B739B30", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600017C")]
				[Cpp2IlInjected.Address(RVA = "0xB73A0E0", Offset = "0xB738CE0", VA = "0x18B73A0E0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public int ZXZJIUFONCT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public GLTFSceneImporter DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public CancellationToken XKCAMCSUPQU;

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public PESUUACAAXA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xB735B60", Offset = "0xB734760", VA = "0x18B735B60")]
			[AsyncStateMachine(typeof(<<LoadMeshAsync>b__0>d))]
			internal Task RPXRYSBJZCL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class JRVMQVYEZBD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public GLTFSceneImporter DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public JTOGRUATFES QUKZGAWMUIT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public string PCANFUHRGDF;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public JRVMQVYEZBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xB735450", Offset = "0xB734050", VA = "0x18B735450")]
			internal Stream VEOCTHEFSBW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xB735540", Offset = "0xB734140", VA = "0x18B735540")]
			internal void VETJQNYDBNF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class MRFWKEPGTMV
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
				public MRFWKEPGTMV <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				public bool onlyMesh;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x4000180")]
				public bool ignoreMesh;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000181")]
				private List<POILAGDGQRH>.Enumerator <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000182")]
				private TaskAwaiter<GameObject> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000183")]
				private KHWXUNVOHHW <mesh>5__3;

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
				[Cpp2IlInjected.Address(RVA = "0xB737450", Offset = "0xB736050", VA = "0x18B737450", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000184")]
				[Cpp2IlInjected.Address(RVA = "0xB7390D0", Offset = "0xB737CD0", VA = "0x18B7390D0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public GameObject NKUYIWUNFTH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public KTFAJFRQMLO EOEQGJOKNAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public GLTFSceneImporter DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public CancellationToken XKCAMCSUPQU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public int RESBZGOIUNG;

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public MRFWKEPGTMV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xB735980", Offset = "0xB734580", VA = "0x18B735980")]
			[AsyncStateMachine(typeof(<<ConstructNode>g__CreateNodeComponentsAndChilds|0>d))]
			internal Task SOUIDRHWVUO(bool a = false, bool b = false)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0xB735910", Offset = "0xB734510", VA = "0x18B735910")]
			internal Material LQGJEHYLEKS(ORTIZQKCQUO a)
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
			public KTVCVTRZYQB animation;

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
			private Dictionary<string, List<LOWENHEWMHZ>> <samplersByType>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			private int <i>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			private GBOWZUSEZBM <samplerDef>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			private TaskAwaiter<TJELPNODSRG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xB73C790", Offset = "0xB73B390", VA = "0x18B73C790", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xB73D440", Offset = "0xB73C040", VA = "0x18B73D440", Slot = "5")]
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
			public UETACDQNYLA image;

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
			[Cpp2IlInjected.Address(RVA = "0xB73D4A0", Offset = "0xB73C0A0", VA = "0x18B73D4A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xB73DC70", Offset = "0xB73C870", VA = "0x18B73DC70", Slot = "5")]
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
			public XLUTOTUKWDR buffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			private TaskAwaiter<Stream> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xB73E2F0", Offset = "0xB73CEF0", VA = "0x18B73E2F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xB73EAF0", Offset = "0xB73D6F0", VA = "0x18B73EAF0", Slot = "5")]
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
			public KTFAJFRQMLO node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			private List<POILAGDGQRH>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xB73DCE0", Offset = "0xB73C8E0", VA = "0x18B73DCE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xB73E290", Offset = "0xB73CE90", VA = "0x18B73E290", Slot = "5")]
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
			private FYOVJUMCYVB <>8__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			private AnimationClip <clip>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			private int[] <nodeIds>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			private VWXLJRXFFFT <pointerImportContext>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			private List<ZQGCQEKBQWV>.Enumerator <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			private ZQGCQEKBQWV <channel>5__6;

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
			[Cpp2IlInjected.Address(RVA = "0xB73EB50", Offset = "0xB73D750", VA = "0x18B73EB50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xB742150", Offset = "0xB740D50", VA = "0x18B742150", Slot = "5")]
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
			public UETACDQNYLA image;

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
			[Cpp2IlInjected.Address(RVA = "0xB7428C0", Offset = "0xB7414C0", VA = "0x18B7428C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xB742C70", Offset = "0xB741870", VA = "0x18B742C70", Slot = "5")]
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
			public JQEEIHSQRHG texture;

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
			[Cpp2IlInjected.Address(RVA = "0xB7421C0", Offset = "0xB740DC0", VA = "0x18B7421C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xB742860", Offset = "0xB741460", VA = "0x18B742860", Slot = "5")]
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
			public KTFAJFRQMLO node;

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
			private CXOYWSYFLTN <lodsExtension>5__2;

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
			[Cpp2IlInjected.Address(RVA = "0xB742CD0", Offset = "0xB7418D0", VA = "0x18B742CD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xB743870", Offset = "0xB742470", VA = "0x18B743870", Slot = "5")]
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
			public AHICOKAOCWI def;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			private <>c__DisplayClass119_0 <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			public int materialIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			private LQTCXAEZXIN <mrMapper>5__2;

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
			private KSLKROZDGJS <sgMapper>5__12;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			private VJVZDKOPGFZ <unlitMapper>5__13;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			private QBZRUHHHEXI <sheenMapper>5__14;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			private SNCPNPSAUXJ <anisotropyMapper>5__15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			private PDPNWSKZUMH <transmissionMapper>5__16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			private UKDVSIJIEYR <volumeMapper>5__17;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			private PHHDCKGAEEV <iridescenceMapper>5__18;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			private DTHECBUOYJK <specularMapper>5__19;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			private RBVEWGXPMBJ <clearcoatMapper>5__20;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			private CNRQIUIJDTE <uniformMapper>5__21;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			private HNMBPMXVUOV <pbr>5__22;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			private OWKTOJURGXA <textureId>5__23;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			private NHRKSMMCFZZ <specGloss>5__24;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			private KHR_materials_sheen <sheen>5__25;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			private TaskAwaiter<HBGXJJDPUGP> <>u__2;

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
			private QGTUXMGLSKW <clearcoatNormalMapper>5__32;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xB7438D0", Offset = "0xB7424D0", VA = "0x18B7438D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xB74B6A0", Offset = "0xB74A2A0", VA = "0x18B74B6A0", Slot = "5")]
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
			public KHWXUNVOHHW mesh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			private FUDUXAGLBER <meshCache>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			private BPRBDHLKYOI <unityData>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400020E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			private int <i>5__4;

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xB74CE60", Offset = "0xB74BA60", VA = "0x18B74CE60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xB74D890", Offset = "0xB74C490", VA = "0x18B74D890", Slot = "5")]
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
			public IUZCCLJFKFO meshId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public KHWXUNVOHHW mesh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000215")]
			private int <meshIndex>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			private int <i>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000217")]
			private ORTIZQKCQUO <primitive>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xB74B700", Offset = "0xB74A300", VA = "0x18B74B700", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xB74BD50", Offset = "0xB74A950", VA = "0x18B74BD50", Slot = "5")]
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
			public ORTIZQKCQUO primitive;

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
			private List<Dictionary<string, LOWENHEWMHZ>> <newTargets>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			private int <i>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			private Dictionary<string, ZIYZUENAFOS>.Enumerator <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000222")]
			private KeyValuePair<string, ZIYZUENAFOS> <targetAttribute>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000223")]
			private int <bufferID>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000224")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			private TaskAwaiter<TJELPNODSRG> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xB74BDB0", Offset = "0xB74A9B0", VA = "0x18B74BDB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xB74CE00", Offset = "0xB74BA00", VA = "0x18B74CE00", Slot = "5")]
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
			public KTFAJFRQMLO node;

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
			private MRFWKEPGTMV <>8__1;

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
			[Cpp2IlInjected.Address(RVA = "0xB74D8F0", Offset = "0xB74C4F0", VA = "0x18B74D8F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xB74EA90", Offset = "0xB74D690", VA = "0x18B74EA90", Slot = "5")]
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
			public ORTIZQKCQUO primitive;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000239")]
			private FUDUXAGLBER.SXMFKSMEIGF <primData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400023A")]
			private Dictionary<string, ZIYZUENAFOS>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400023B")]
			private KeyValuePair<string, ZIYZUENAFOS> <attributePair>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400023C")]
			private VZTDRRWUQUL <sparse>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400023D")]
			private TaskAwaiter<TJELPNODSRG> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400023E")]
			private LOWENHEWMHZ <sparseValues>5__6;

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xB755790", Offset = "0xB754390", VA = "0x18B755790", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xB7568D0", Offset = "0xB7554D0", VA = "0x18B7568D0", Slot = "5")]
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
			public ZZHEPEFHRAT scene;

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
			[Cpp2IlInjected.Address(RVA = "0xB756930", Offset = "0xB755530", VA = "0x18B756930", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xB757640", Offset = "0xB756240", VA = "0x18B757640", Slot = "5")]
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
			public JQEEIHSQRHG texture;

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
			private UETACDQNYLA <image>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000258")]
			private bool <isFirstInstance>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000259")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xB7576A0", Offset = "0xB7562A0", VA = "0x18B7576A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xB758930", Offset = "0xB757530", VA = "0x18B758930", Slot = "5")]
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
			public BPRBDHLKYOI unityMeshData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000260")]
			private Mesh <mesh>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000261")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xB758990", Offset = "0xB757590", VA = "0x18B758990", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xB759AB0", Offset = "0xB7586B0", VA = "0x18B759AB0", Slot = "5")]
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
			public UETACDQNYLA image;

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
			private TJELPNODSRG <bufferView>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400026E")]
			private TaskAwaiter<TJELPNODSRG> <>u__1;

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
			[Cpp2IlInjected.Address(RVA = "0xB759B10", Offset = "0xB758710", VA = "0x18B759B10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xB75B600", Offset = "0xB75A200", VA = "0x18B75B600", Slot = "5")]
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
			public ORTIZQKCQUO primitive;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000277")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000278")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xB75BCF0", Offset = "0xB75A8F0", VA = "0x18B75BCF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xB75BF90", Offset = "0xB75AB90", VA = "0x18B75BF90", Slot = "5")]
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
			public KHWXUNVOHHW mesh;

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
			[Cpp2IlInjected.Address(RVA = "0xB75BFF0", Offset = "0xB75ABF0", VA = "0x18B75BFF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0xB75C1F0", Offset = "0xB75ADF0", VA = "0x18B75C1F0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xB75C250", Offset = "0xB75AE50", VA = "0x18B75C250", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xB75C6D0", Offset = "0xB75B2D0", VA = "0x18B75C6D0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<HBGXJJDPUGP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000286")]
			public LIQIFNODJDV textureInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000287")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000288")]
			public bool isNormal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000289")]
			private HBGXJJDPUGP <result>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400028A")]
			private OWKTOJURGXA <textureId>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400028B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xB75C730", Offset = "0xB75B330", VA = "0x18B75C730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0xB75CCF0", Offset = "0xB75B8F0", VA = "0x18B75CCF0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<TJELPNODSRG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400028E")]
			public CCIZODPLJBR bufferId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400028F")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000290")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0xB75CD60", Offset = "0xB75B960", VA = "0x18B75CD60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xB75CFF0", Offset = "0xB75BBF0", VA = "0x18B75CFF0", Slot = "5")]
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
			public KTFAJFRQMLO node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000295")]
			private LOWENHEWMHZ <positionsAttr>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000296")]
			private LOWENHEWMHZ <rotationAttr>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000297")]
			private LOWENHEWMHZ <scaleAttr>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000298")]
			private EXT_mesh_gpu_instancing <extMeshGPUInstancing>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000299")]
			private int <instancesCount>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400029A")]
			private TaskAwaiter<LOWENHEWMHZ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xB75D060", Offset = "0xB75BC60", VA = "0x18B75D060", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0xB75DCB0", Offset = "0xB75C8B0", VA = "0x18B75DCB0", Slot = "5")]
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
			private KTFAJFRQMLO <node>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002A2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002A3")]
			private CXOYWSYFLTN <lodsExtension>5__4;

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
			[Cpp2IlInjected.Address(RVA = "0xB75DD20", Offset = "0xB75C920", VA = "0x18B75DD20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0xB75EBA0", Offset = "0xB75D7A0", VA = "0x18B75EBA0", Slot = "5")]
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
			private JRVMQVYEZBD <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002AC")]
			private TaskAwaiter<Stream> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002AD")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0xB75EC10", Offset = "0xB75D810", VA = "0x18B75EC10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0xB75F350", Offset = "0xB75DF50", VA = "0x18B75F350", Slot = "5")]
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
			private TEOAQSXTFHF <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002B3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xB75F3B0", Offset = "0xB75DFB0", VA = "0x18B75F3B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0xB75F6B0", Offset = "0xB75E2B0", VA = "0x18B75F6B0", Slot = "5")]
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
			private PESUUACAAXA <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002BA")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0xB75F720", Offset = "0xB75E320", VA = "0x18B75F720", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0xB75FA40", Offset = "0xB75E640", VA = "0x18B75FA40", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xB75FAB0", Offset = "0xB75E6B0", VA = "0x18B75FAB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0xB760B20", Offset = "0xB75F720", VA = "0x18B760B20", Slot = "5")]
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
			private AHICOKAOCWI <def>5__3;

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xB760B80", Offset = "0xB75F780", VA = "0x18B760B80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xB760FF0", Offset = "0xB75FBF0", VA = "0x18B760FF0", Slot = "5")]
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
			private KHWXUNVOHHW <gltfMesh>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002D0")]
			private int <i>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002D1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0xB761050", Offset = "0xB75FC50", VA = "0x18B761050", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0xB761700", Offset = "0xB760300", VA = "0x18B761700", Slot = "5")]
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
			public WVIQGMXWUFX skin;

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
			private TaskAwaiter<TJELPNODSRG> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			private int <i>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40002DE")]
			private TaskAwaiter<GameObject> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0xB761760", Offset = "0xB760360", VA = "0x18B761760", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xB762240", Offset = "0xB760E40", VA = "0x18B762240", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xB7622A0", Offset = "0xB760EA0", VA = "0x18B7622A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xB7628A0", Offset = "0xB7614A0", VA = "0x18B7628A0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xB762B10", Offset = "0xB761710", VA = "0x18B762B10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xB762D30", Offset = "0xB761930", VA = "0x18B762D30", Slot = "5")]
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
			private ZZHEPEFHRAT <scene>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xB762D90", Offset = "0xB761990", VA = "0x18B762D90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xB763A50", Offset = "0xB762650", VA = "0x18B763A50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public int AKQDMPHUNON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public int PGDCYPIXPWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private bool HYKHUDDXWSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private bool GLLUYZIPFYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private Dictionary<Stream, NativeArray<byte>> LWUFROJQSHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public bool LQSREFHPJGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public bool VKWTPVFYFTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public bool VITURDRSPDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x63")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public bool JBDXDOKTOKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public bool OQLVGVDCCDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public ImportStatistics YZYDWFFJVTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		protected JWRGHOMMCDX MKUMYBQHJQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		protected SVEZDNZFCTI LYWCBRXFMXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		protected GameObject YHABZVVOUOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		protected readonly AHICOKAOCWI IUVAXHLAZJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		internal TKAHDGDOFHP BZVPQXPFOUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		protected string FASMEMPIULX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		protected GLBStream KNAUETMSSUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		protected TBEADDWHLOJ TMJQTZIWDWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		protected PLNMMITZMLE MYYJARKPVTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		protected bool SVNEENGCJEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		protected ImportProgress RVGITPTWUDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		protected IProgress<ImportProgress> XKURRETLWYT;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static ILogger PFAJKELISZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		protected ColorSpace RRTJZCLOIDC;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		internal static List<Texture> QPUBTEHNPSE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private Dictionary<int, int> RLBYAUOLXCE;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool TDGBXQKOEAQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xB728490", Offset = "0xB727090", VA = "0x18B728490")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xCFD470", Offset = "0xCFC070", VA = "0x180CFD470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public TBEADDWHLOJ OFIFJQDFJXG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xEE82E0", Offset = "0xEE6EE0", VA = "0x180EE82E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Transform SBUMHKUUJGY
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xCF1770", Offset = "0xCF0370", VA = "0x180CF1770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public GameObject FOLUFDMEOGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2F50", VA = "0x180CF4350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0xCF1780", Offset = "0xCF0380", VA = "0x180CF1780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private AnimationClip[] AEWJCXZVXKZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xCF64C0", Offset = "0xCF50C0", VA = "0x180CF64C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ColliderType BZXEOJSIXJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xD1EF90", Offset = "0xD1DB90", VA = "0x180D1EF90")]
			[CompilerGenerated]
			get
			{
				return default(ColliderType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xDE9880", Offset = "0xDE8480", VA = "0x180DE9880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public string LOOQWLWZCWJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xCF43A0", Offset = "0xCF2FA0", VA = "0x180CF43A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xCF4370", Offset = "0xCF2F70", VA = "0x180CF4370")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public GameObject WJXYOLEPIZJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xCF7770", Offset = "0xCF6370", VA = "0x180CF7770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public UWJACFAPKUP[] BOIWNVRZTWP
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xB729760", Offset = "0xB728360", VA = "0x18B729760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Texture2D[] TUKRZCZAREO
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xB72E160", Offset = "0xB72CD60", VA = "0x18B72E160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public TKAHDGDOFHP[] EXZSKAKSIPT
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xB72D870", Offset = "0xB72C470", VA = "0x18B72D870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public YHGZCDIUCBS[] QOSKELMEXUI
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xB72C280", Offset = "0xB72AE80", VA = "0x18B72C280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public FUDUXAGLBER[] VIYRFTOMUDX
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0xB72E020", Offset = "0xB72CC20", VA = "0x18B72E020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public List<UnityEngine.Object> LBYAUKLCIHW
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xCEE120", Offset = "0xCECD20", VA = "0x180CEE120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected VUSAZGCWQUD AEOZTIYAYYD
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xB72D4C0", Offset = "0xB72C0C0", VA = "0x18B72D4C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xB734BB0", Offset = "0xB7337B0", VA = "0x18B734BB0")]
		public GLTFSceneImporter(string gltfFileName, JWRGHOMMCDX options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xB734C00", Offset = "0xB733800", VA = "0x18B734C00")]
		public GLTFSceneImporter(Stream gltfStream, JWRGHOMMCDX options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xB734D00", Offset = "0xB733900", VA = "0x18B734D00")]
		private GLTFSceneImporter(JWRGHOMMCDX options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xB72A740", Offset = "0xB729340", VA = "0x18B72A740")]
		private NativeArray<byte> DIHONKDHKOE(Stream a)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xB7281B0", Offset = "0xB726DB0", VA = "0x18B7281B0")]
		private void AFTOHNGMBPQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xB72AE00", Offset = "0xB729A00", VA = "0x18B72AE00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xB72CBC0", Offset = "0xB72B7C0", VA = "0x18B72CBC0")]
		[AsyncStateMachine(typeof(<LoadSceneAsync>d__81))]
		public Task FQANDRDLEUI(int a = -1, bool b = true, [Optional] Action<GameObject, ExceptionDispatchInfo> c, [Optional] CancellationToken d, [Optional] IProgress<ImportProgress> e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xB7311E0", Offset = "0xB72FDE0", VA = "0x18B7311E0")]
		[AsyncStateMachine(typeof(<LoadUnreferencedAssetsAsync>d__82))]
		private Task QIUOIHTAEVJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xB733D00", Offset = "0xB732900", VA = "0x18B733D00", Slot = "5")]
		[AsyncStateMachine(typeof(<LoadMaterialAsync>d__85))]
		public virtual Task<Material> XFSLZLUMNVJ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xB72A010", Offset = "0xB728C10", VA = "0x18B72A010", Slot = "6")]
		[AsyncStateMachine(typeof(<LoadMeshAsync>d__86))]
		public virtual Task<Mesh> CBNEGSYRSXV(int a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xB72D610", Offset = "0xB72C210", VA = "0x18B72D610")]
		[AsyncStateMachine(typeof(<LoadJson>d__87))]
		private Task IAWGQUCZAQW(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xB72A490", Offset = "0xB729090", VA = "0x18B72A490")]
		private void CWPOOCSBSYD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xB72C020", Offset = "0xB72AC20", VA = "0x18B72C020")]
		[AsyncStateMachine(typeof(<_LoadScene>d__90))]
		protected Task EREYUTHUMRF(int a = -1, bool b = true, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xB72A140", Offset = "0xB728D40", VA = "0x18B72A140")]
		private void CCWIRHBSWIN(ZZHEPEFHRAT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xB731100", Offset = "0xB72FD00", VA = "0x18B731100")]
		public NativeArray<byte> QIUGTFMOFNZ(UMJJFNXSQAT a)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xB7312B0", Offset = "0xB72FEB0", VA = "0x18B7312B0")]
		[AsyncStateMachine(typeof(<GetBufferData>d__93))]
		private Task<TJELPNODSRG> RHVTJORBDJI(CCIZODPLJBR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xB72ED20", Offset = "0xB72D920", VA = "0x18B72ED20")]
		private float MBMZLHNOXYR(List<double> a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xB72FBC0", Offset = "0xB72E7C0", VA = "0x18B72FBC0")]
		[AsyncStateMachine(typeof(<GetNode>d__95))]
		private Task<GameObject> OBPWZMAPYQA(int a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xB7303D0", Offset = "0xB72EFD0", VA = "0x18B7303D0")]
		[AsyncStateMachine(typeof(<GetInstancesTRS>d__96))]
		private Task<(Vector3, Quaternion, Vector3)[]> PLNOBLLDCTZ(KTFAJFRQMLO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xB72DA40", Offset = "0xB72C640", VA = "0x18B72DA40")]
		private bool IPCMYSYJKBC(KTFAJFRQMLO a, GameObject b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xB72DEE0", Offset = "0xB72CAE0", VA = "0x18B72DEE0", Slot = "7")]
		[AsyncStateMachine(typeof(<ConstructNode>d__98))]
		protected virtual Task KHMTVBEONMB(KTFAJFRQMLO a, int b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xB72DB30", Offset = "0xB72C730", VA = "0x18B72DB30")]
		[AsyncStateMachine(typeof(<ConstructBufferData>d__99))]
		private Task JFYTSOLVCWX(KTFAJFRQMLO a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xB734150", Offset = "0xB732D50", VA = "0x18B734150")]
		[AsyncStateMachine(typeof(<ConstructBuffer>d__100))]
		protected Task XNBITMVIEUD(XLUTOTUKWDR a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xB72AEC0", Offset = "0xB729AC0", VA = "0x18B72AEC0", Slot = "8")]
		[AsyncStateMachine(typeof(<ConstructScene>d__101))]
		protected virtual Task EEZQBNMFIFZ(ZZHEPEFHRAT a, bool b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xB72D250", Offset = "0xB72BE50", VA = "0x18B72D250", Slot = "9")]
		protected virtual TJELPNODSRG GTEVAVYTAES(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xB72A5D0", Offset = "0xB7291D0", VA = "0x18B72A5D0")]
		private void Cleanup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xB72FF90", Offset = "0xB72EB90", VA = "0x18B72FF90")]
		private void OFVKKVGGYER()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xB72FAD0", Offset = "0xB72E6D0", VA = "0x18B72FAD0")]
		[AsyncStateMachine(typeof(<SetupLoad>d__107))]
		private Task OAXBFUFVFEN(Func<Task> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xB729690", Offset = "0xB728290", VA = "0x18B729690")]
		[AsyncStateMachine(typeof(<YieldOnTimeoutAndThrowOnLowMemory>d__108))]
		protected Task BCOSDNURLIC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xB72D890", Offset = "0xB72C490", VA = "0x18B72D890")]
		private static string IJFAZRZQJWD(Transform a, Transform b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xB72A620", Offset = "0xB729220", VA = "0x18B72A620", Slot = "10")]
		[AsyncStateMachine(typeof(<BuildAnimationSamplers>d__110))]
		protected virtual Task DBPJTNBLCRR(KTVCVTRZYQB a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xB72C2A0", Offset = "0xB72AEA0", VA = "0x18B72C2A0")]
		protected void FJAQMUERTUV(AnimationClip a, string b, string[] c, NumericArray d, NumericArray e, InterpolationType f, Type g, ValuesConvertion h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xB72EDB0", Offset = "0xB72D9B0", VA = "0x18B72EDB0")]
		private void MKTRRKAHNZA(Keyframe[] a, int b, InterpolationType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xB733710", Offset = "0xB732310", VA = "0x18B733710")]
		private static float VXGOTCQQRNI(Keyframe[] a, int b, bool c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xB72D710", Offset = "0xB72C310", VA = "0x18B72D710")]
		[AsyncStateMachine(typeof(<ConstructClip>d__114))]
		protected Task<AnimationClip> ICOAXZIIEVZ(Transform a, int b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xB72F560", Offset = "0xB72E160", VA = "0x18B72F560")]
		private bool NGUVQYZTXXE(GameObject a, KTFAJFRQMLO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xB72E670", Offset = "0xB72D270", VA = "0x18B72E670")]
		private bool LXQGQEEESOQ(GameObject a, KTFAJFRQMLO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xB72E180", Offset = "0xB72CD80", VA = "0x18B72E180")]
		[AsyncStateMachine(typeof(<ConstructLods>d__117))]
		private Task LNLAHQMPVZL(TBEADDWHLOJ a, GameObject b, KTFAJFRQMLO c, int d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xB731500", Offset = "0xB730100", VA = "0x18B731500", Slot = "11")]
		[AsyncStateMachine(typeof(<ConstructMaterial>d__119))]
		protected virtual Task RSCWFZVJNGI(AHICOKAOCWI a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xB732670", Offset = "0xB731270", VA = "0x18B732670", Slot = "12")]
		protected virtual Task TTGTIEVZNLG(AHICOKAOCWI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xB730980", Offset = "0xB72F580", VA = "0x18B730980", Slot = "13")]
		protected virtual IJFKHYGUQHV PQRBTKOGAQJ(LIQIFNODJDV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xB730730", Offset = "0xB72F330", VA = "0x18B730730", Slot = "14")]
		protected virtual KHR_materials_emissive_strength PNQSFSFTHUC(AHICOKAOCWI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xB729780", Offset = "0xB728380", VA = "0x18B729780", Slot = "15")]
		protected virtual KHR_materials_transmission BVSJELIBHOA(AHICOKAOCWI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xB72DDB0", Offset = "0xB72C9B0", VA = "0x18B72DDB0", Slot = "16")]
		protected virtual KHR_materials_sheen KGJLIMPYNXD(AHICOKAOCWI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xB72BEF0", Offset = "0xB72AAF0", VA = "0x18B72BEF0", Slot = "17")]
		protected virtual KHR_materials_anisotropy ELGBBWRZEXO(AHICOKAOCWI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xB730AB0", Offset = "0xB72F6B0", VA = "0x18B730AB0", Slot = "18")]
		protected virtual KHR_materials_dispersion PVNMQUCDIBY(AHICOKAOCWI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xB730BE0", Offset = "0xB72F7E0", VA = "0x18B730BE0", Slot = "19")]
		protected virtual KHR_materials_volume PXCIZNZZNIC(AHICOKAOCWI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xB72D4E0", Offset = "0xB72C0E0", VA = "0x18B72D4E0", Slot = "20")]
		protected virtual KHR_materials_ior HOWQYJRXEJU(AHICOKAOCWI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xB734260", Offset = "0xB732E60", VA = "0x18B734260", Slot = "21")]
		protected virtual KHR_materials_iridescence XQFMUZSDMIQ(AHICOKAOCWI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xB728600", Offset = "0xB727200", VA = "0x18B728600", Slot = "22")]
		protected virtual KHR_materials_specular AVLCFCJUQFD(AHICOKAOCWI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xB72EFA0", Offset = "0xB72DBA0", VA = "0x18B72EFA0", Slot = "23")]
		protected virtual KHR_materials_clearcoat MSAVCVITHYK(AHICOKAOCWI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xB728510", Offset = "0xB727110", VA = "0x18B728510")]
		[AsyncStateMachine(typeof(<CreateMaterials>d__132))]
		private Task AQZHIQKPVZE(ORTIZQKCQUO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xB7335E0", Offset = "0xB7321E0", VA = "0x18B7335E0", Slot = "24")]
		[AsyncStateMachine(typeof(<ConstructMesh>d__133))]
		protected virtual Task VVQHIGXOVJO(KHWXUNVOHHW a, int b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xB729F10", Offset = "0xB728B10", VA = "0x18B729F10")]
		[AsyncStateMachine(typeof(<CreateMeshMaterials>d__134))]
		private Task BWZQDOTTRCV(KHWXUNVOHHW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xB72AB10", Offset = "0xB729710", VA = "0x18B72AB10")]
		private static uint[] DPMLFJEZIYW(KHWXUNVOHHW a, [Out] uint b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xB72CFD0", Offset = "0xB72BBD0", VA = "0x18B72CFD0")]
		protected void GOFAAYEFDWV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xB72E400", Offset = "0xB72D000", VA = "0x18B72E400")]
		protected void LQUQYLWJDWB(Mesh a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xB731740", Offset = "0xB730340", VA = "0x18B731740")]
		private BPRBDHLKYOI TMTEMOPVLLG(KHWXUNVOHHW a, int b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xB728360", Offset = "0xB726F60", VA = "0x18B728360")]
		[AsyncStateMachine(typeof(<ConstructUnityMesh>d__139))]
		protected Task AHSZPLPIPNV(BPRBDHLKYOI a, int b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xB72F0D0", Offset = "0xB72DCD0", VA = "0x18B72F0D0")]
		private void MSRNKMPGJKM(BPRBDHLKYOI a, int b, Mesh c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xB72F9A0", Offset = "0xB72E5A0", VA = "0x18B72F9A0", Slot = "25")]
		[AsyncStateMachine(typeof(<ConstructMeshTargetsPrepareBuffers>d__141))]
		protected virtual Task NIVVJEEVLDS(ORTIZQKCQUO a, int b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xB728730", Offset = "0xB727330", VA = "0x18B728730", Slot = "26")]
		protected virtual void BBGOOOSHWBI(ORTIZQKCQUO a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xB7298B0", Offset = "0xB7284B0", VA = "0x18B7298B0")]
		private void BWAMANSADIW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xB72CD00", Offset = "0xB72B900", VA = "0x18B72CD00")]
		[AsyncStateMachine(typeof(<PreparePrimitiveAttributes>d__144))]
		private Task FSSLSYTEEQJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xB72E040", Offset = "0xB72CC40", VA = "0x18B72E040")]
		[AsyncStateMachine(typeof(<ConstructMeshAttributes>d__145))]
		private Task KWZCBQFXCIN(KHWXUNVOHHW a, IUZCCLJFKFO b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xB7313C0", Offset = "0xB72FFC0", VA = "0x18B7313C0", Slot = "27")]
		[AsyncStateMachine(typeof(<ConstructPrimitiveAttributes>d__146))]
		protected virtual Task RKAXPPBHKLF(ORTIZQKCQUO a, int b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xB72AFF0", Offset = "0xB729BF0", VA = "0x18B72AFF0")]
		protected void EGAHAZQATEM(FUDUXAGLBER.SXMFKSMEIGF a, BPRBDHLKYOI b, uint c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xB730500", Offset = "0xB72F100", VA = "0x18B730500")]
		private void PMFMNYXXNPQ(Dictionary<string, LOWENHEWMHZ> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xB7344D0", Offset = "0xB7330D0", VA = "0x18B7344D0")]
		protected MeshTopology ZJPAHAKUGDL(DrawMode a)
		{
			return default(MeshTopology);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xB730D10", Offset = "0xB72F910", VA = "0x18B730D10")]
		private void PYKAMKTSBNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xB72C140", Offset = "0xB72AD40", VA = "0x18B72C140", Slot = "28")]
		[AsyncStateMachine(typeof(<SetupBones>d__153))]
		protected virtual Task FGFHTRKDKTO(WVIQGMXWUFX a, SkinnedMeshRenderer b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xB734690", Offset = "0xB733290", VA = "0x18B734690")]
		private void ZSGUAJMGTTJ(Vector4[] a, Vector4[] b, BoneWeight[] c, uint d = 0u)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xB733500", Offset = "0xB732100", VA = "0x18B733500")]
		[AsyncStateMachine(typeof(<CreateNotReferencedTexture>d__158))]
		private Task VGMPALIIOSR(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xB72E2C0", Offset = "0xB72CEC0", VA = "0x18B72E2C0")]
		[AsyncStateMachine(typeof(<FromTextureInfo>d__159))]
		private Task<HBGXJJDPUGP> LPKTJVYMSDZ(LIQIFNODJDV a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0xB7334A0", Offset = "0xB7320A0", VA = "0x18B7334A0")]
		private static int VEPDVRENTGF(byte[] a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xB733E10", Offset = "0xB732A10", VA = "0x18B733E10")]
		private Dictionary<int, int> XKUFOZZCVHV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xB733A30", Offset = "0xB732630", VA = "0x18B733A30")]
		private void WGPQSWFWTLY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xB7301F0", Offset = "0xB72EDF0", VA = "0x18B7301F0")]
		private Stream OVRTSDADUTL(UETACDQNYLA a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xB7338F0", Offset = "0xB7324F0", VA = "0x18B7338F0")]
		[AsyncStateMachine(typeof(<ConstructImage>d__164))]
		protected Task VYBRYBXHDPQ(UETACDQNYLA a, int b, bool c, bool d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xB730860", Offset = "0xB72F460", VA = "0x18B730860")]
		[AsyncStateMachine(typeof(<ConstructImageBuffer>d__165))]
		protected Task POJBYMHGJKM(JQEEIHSQRHG a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xB72DC50", Offset = "0xB72C850", VA = "0x18B72DC50")]
		[AsyncStateMachine(typeof(<CheckMimeTypeAndLoadImage>d__166))]
		private Task<Texture2D> KGBBHCPOWMK(UETACDQNYLA a, Texture2D b, NativeArray<byte> c, bool d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xB731600", Offset = "0xB730200", VA = "0x18B731600", Slot = "29")]
		[AsyncStateMachine(typeof(<ConstructUnityTexture>d__167))]
		protected virtual Task TLMBAEHTYGZ(Stream a, bool b, bool c, bool d, UETACDQNYLA e, int f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xB72EBC0", Offset = "0xB72D7C0", VA = "0x18B72EBC0", Slot = "30")]
		protected virtual int LYPAMWCMABV(JQEEIHSQRHG a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xB72AE50", Offset = "0xB729A50", VA = "0x18B72AE50", Slot = "31")]
		protected virtual bool EECGSNWKMLD(JQEEIHSQRHG a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xB72A9D0", Offset = "0xB7295D0", VA = "0x18B72A9D0", Slot = "32")]
		[AsyncStateMachine(typeof(<ConstructTexture>d__173))]
		protected virtual Task DIHSOBJVRCU(JQEEIHSQRHG a, int b, bool c, bool d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xB734390", Offset = "0xB732F90", VA = "0x18B734390")]
		[AsyncStateMachine(typeof(<<GetInstancesTRS>g__GetAttrAccessorAndAccessorContent|96_0>d))]
		[CompilerGenerated]
		private Task<LOWENHEWMHZ> XTHDIZFEIHV(ZIYZUENAFOS a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xB72FD00", Offset = "0xB72E900", VA = "0x18B72FD00")]
		[CompilerGenerated]
		internal static LOWENHEWMHZ OCVSDHPHKVL(string a, <>c__DisplayClass114_0 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xB72D360", Offset = "0xB72BF60", VA = "0x18B72D360")]
		[CompilerGenerated]
		private void HGIFRXGHDWO(OWKTOJURGXA a, IJFKHYGUQHV b, [Out] Vector2 c, [Out] Vector2 d, <>c__DisplayClass119_0 e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xB730120", Offset = "0xB72ED20", VA = "0x18B730120")]
		[CompilerGenerated]
		private void ONHPTRZLDZD(<>c__DisplayClass119_0 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xB72CDE0", Offset = "0xB72B9E0", VA = "0x18B72CDE0")]
		[CompilerGenerated]
		private void FSZOSXKLPIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xB72F350", Offset = "0xB72DF50", VA = "0x18B72F350")]
		[CompilerGenerated]
		private TextureWrapMode NEEKYREKWOT(GLTF.Schema.WrapMode a)
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
		private sealed class QKINYTOIDIW<a> where a : GLTFPlugin
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			public Type KBUKZPNLRCL;

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public QKINYTOIDIW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x76394B0", Offset = "0x76380B0", VA = "0x1876394B0")]
			internal bool PGROKEZGJMM(a a)
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
		public string HVNORLYCMWB
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xB7547A0", Offset = "0xB7533A0", VA = "0x18B7547A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool MJHTFKNNCBI
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xD4DD70", Offset = "0xD4C970", VA = "0x180D4DD70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0xD4F0D0", Offset = "0xD4DCD0", VA = "0x180D4F0D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool CZMVPDUZUFO
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xF45580", Offset = "0xF44180", VA = "0x180F45580")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xF8C5D0", Offset = "0xF8B1D0", VA = "0x180F8C5D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool AWLLVVJRQMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x1ABDA00", Offset = "0x1ABC600", VA = "0x181ABDA00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x1B0C280", Offset = "0x1B0AE80", VA = "0x181B0C280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool XZVKRWMZEUC
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xF21100", Offset = "0xF1FD00", VA = "0x180F21100")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xF21690", Offset = "0xF20290", VA = "0x180F21690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool ZRWTKJXGHBO
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xF214A0", Offset = "0xF200A0", VA = "0x180F214A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xF213E0", Offset = "0xF1FFE0", VA = "0x180F213E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool IJBVGIHIQGM
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x2766340", Offset = "0x2764F40", VA = "0x182766340")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x27664C0", Offset = "0x27650C0", VA = "0x1827664C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public int IUTLTFJRKEY
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xD1EF90", Offset = "0xD1DB90", VA = "0x180D1EF90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xDE9880", Offset = "0xDE8480", VA = "0x180DE9880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool QPUURSYCTGY
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x2127440", Offset = "0x2126040", VA = "0x182127440")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x9A6E8C0", Offset = "0x9A6D4C0", VA = "0x189A6E8C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool AKDYMGMPJNH
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xF13570", Offset = "0xF12170", VA = "0x180F13570")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xFC6C30", Offset = "0xFC5830", VA = "0x180FC6C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool YCTRZJTKLOI
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xFC7080", Offset = "0xFC5C80", VA = "0x180FC7080")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xFC6FE0", Offset = "0xFC5BE0", VA = "0x180FC6FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		[Obsolete("Add/remove \"AnimationPointerPlugin\" from ExportPlugins instead.")]
		public bool RPTGHEPHGNO
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xB7547B0", Offset = "0xB7533B0", VA = "0x18B7547B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xB7548E0", Offset = "0xB7534E0", VA = "0x18B7548E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool PQBMAUWRBKN
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xFC7070", Offset = "0xFC5C70", VA = "0x180FC7070")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xFC6FF0", Offset = "0xFC5BF0", VA = "0x180FC6FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool AMEBWZRSIXU
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x19BC230", Offset = "0x19BAE30", VA = "0x1819BC230")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x19BC1B0", Offset = "0x19BADB0", VA = "0x1819BC1B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public BlendShapeExportPropertyFlags OPURHIYRINF
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xD0CD60", Offset = "0xD0B960", VA = "0x180D0CD60")]
			get
			{
				return default(BlendShapeExportPropertyFlags);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0xD6E2C0", Offset = "0xD6CEC0", VA = "0x180D6E2C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool KNYKPPMPHAC
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xB3A7DD0", Offset = "0xB3A69D0", VA = "0x18B3A7DD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0xB3C0840", Offset = "0xB3BF440", VA = "0x18B3C0840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xB7543B0", Offset = "0xB752FB0", VA = "0x18B7543B0")]
		internal string XLXTKFMJSAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xB753CC0", Offset = "0xB7528C0", VA = "0x18B753CC0")]
		public static GLTFSettings GetOrCreateSettings()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xB753C50", Offset = "0xB752850", VA = "0x18B753C50")]
		public static GLTFSettings GetDefaultSettings()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xB754280", Offset = "0xB752E80", VA = "0x18B754280")]
		public static bool TryGetSettings([Out] GLTFSettings settings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0xB753B90", Offset = "0xB752790", VA = "0x18B753B90")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ClearStatics()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xB753E90", Offset = "0xB752A90", VA = "0x18B753E90")]
		private static void QAVFIXPKWRF(GLTFSettings a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xB7546B0", Offset = "0xB7532B0", VA = "0x18B7546B0")]
		public GLTFSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3AD8280", Offset = "0x3AD6E80", VA = "0x183AD8280")]
		[CompilerGenerated]
		internal static List<Type> EXDUZQHTHCC<a>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3AD7F00", Offset = "0x3AD6B00", VA = "0x183AD7F00")]
		[CompilerGenerated]
		internal static void BRCAKUPMHUY<b>(List<b> a) where b : GLTFPlugin
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class ShaderNotFoundException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xB755740", Offset = "0xB754340", VA = "0x18B755740")]
		public ShaderNotFoundException()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xB755690", Offset = "0xB754290", VA = "0x18B755690")]
		public ShaderNotFoundException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xB7556F0", Offset = "0xB7542F0", VA = "0x18B7556F0")]
		protected ShaderNotFoundException(SerializationInfo info, StreamingContext context)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class GLTFLoadException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xB753B30", Offset = "0xB752730", VA = "0x18B753B30")]
		public GLTFLoadException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class YULPJPLZKSF : ILogHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private readonly StringBuilder SAPQCRLZTOB;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xB764300", Offset = "0xB762F00", VA = "0x18B764300")]
		private string NMLYPAAVLZJ(LogType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xB764240", Offset = "0xB762E40", VA = "0x18B764240", Slot = "4")]
		public void LogFormat(LogType logType, UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0xB7641A0", Offset = "0xB762DA0", VA = "0x18B7641A0", Slot = "5")]
		public void LogException(Exception exception, UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xB764380", Offset = "0xB762F80", VA = "0x18B764380")]
		public void UFQHUZDFMLG(string a = "{0}")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xB7644F0", Offset = "0xB7630F0", VA = "0x18B7644F0")]
		public YULPJPLZKSF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class BJFEUMZQJXU
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xB74EEB0", Offset = "0xB74DAB0", VA = "0x18B74EEB0")]
		public static string OVFBYHRUDLG(Uri a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xB74EF10", Offset = "0xB74DB10", VA = "0x18B74EF10")]
		public static string USEKYBJWAHO(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xB74EF80", Offset = "0xB74DB80", VA = "0x18B74EF80")]
		public static void ZIQDXLQXILR(string a, [Out] byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xB74EE20", Offset = "0xB74DA20", VA = "0x18B74EE20")]
		public static bool KLXWFJWTJWP(string a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class InstantiatedGLTFObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private BYPLHFQGXQB GORXXOJREBI;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public BYPLHFQGXQB FAYKCALAYTM
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0xB754D80", Offset = "0xB753980", VA = "0x18B754D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xB754C50", Offset = "0xB753850", VA = "0x18B754C50")]
		public InstantiatedGLTFObject Duplicate()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xB754D30", Offset = "0xB753930", VA = "0x18B754D30")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF20", Offset = "0xCEEB20", VA = "0x180CEFF20")]
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
		public float XVGVFGLDZHV
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0xB752020", Offset = "0xB750C20", VA = "0x18B752020")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xB7520A0", Offset = "0xB750CA0", VA = "0x18B7520A0")]
		public BlendShapeFrameWeightSetting(MultiplierOption option)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xB7520B0", Offset = "0xB750CB0", VA = "0x18B7520B0")]
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
		public abstract GLTFSceneImporter CreateSceneImporter(string gltfFileName, JWRGHOMMCDX options);

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xD88820", Offset = "0xD87420", VA = "0x180D88820")]
		protected ImporterFactory()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class DefaultImporterFactory : ImporterFactory
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xB7539D0", Offset = "0xB7525D0", VA = "0x18B7539D0", Slot = "4")]
		public override GLTFSceneImporter CreateSceneImporter(string gltfFileName, JWRGHOMMCDX options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xD88820", Offset = "0xD87420", VA = "0x180D88820")]
		public DefaultImporterFactory()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	internal static class GOANMPZEHXU
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xB754B90", Offset = "0xB753790", VA = "0x18B754B90")]
		internal static void WZVLNIDDGDV(this Material a, string b, bool c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class MaterialLibrary : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xD88820", Offset = "0xD87420", VA = "0x180D88820")]
		public MaterialLibrary()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	internal static class GGYBSDTOVSC
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class UBYOUQYNJZM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400031F")]
			public Texture2D GTBLKFLEXRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			public Texture2D VMKRFHXLXDT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			public Color[] UKVSSFAEEQR;

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public UBYOUQYNJZM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0xB763B50", Offset = "0xB762750", VA = "0x18B763B50")]
			internal void QNMCBYOAXMF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0xB763DB0", Offset = "0xB7629B0", VA = "0x18B763DB0")]
			internal void QVAIGEZLGST()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0xB763AB0", Offset = "0xB7626B0", VA = "0x18B763AB0")]
			internal void BHHZPIIMRJL()
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
			private UBYOUQYNJZM <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0xB75B660", Offset = "0xB75A260", VA = "0x18B75B660", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0xB75BC80", Offset = "0xB75A880", VA = "0x18B75BC80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xB753A40", Offset = "0xB752640", VA = "0x18B753A40")]
		[AsyncStateMachine(typeof(<ConvertToDxt5nmAndCheckTextureFormatAsync>d__0))]
		public static Task<Texture2D> QHLFAZWVGBB(Texture2D a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class BPRBDHLKYOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public bool[] MTWLTNIJHDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public Vector3[] PNBEGWYOAAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public Vector3[] DOGEWGHCIYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public Vector4[] CVGRAJETSQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public Vector2[] ZJMLLSKPWUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public Vector2[] ZJHEOLQSNIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public Vector2[] ZJBXREWVDXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public Vector2[] ZKMTYAGCRYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public Color[] EEGQTBPFDUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public BoneWeight[] XGAAWMVEQHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public Vector3[][] QYNFGRXQEWE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public Vector3[][] CTVGIPWJCRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public Vector3[][] PTXAZBIWMNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public MeshTopology[] MZOEGJFBFPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public DrawMode[] FTVRAWTCFVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public int[][] KRMFVPSOCEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public HashSet<int> PUYDZONQUUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public uint[] CMUJKTSFMRQ;

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xB74F090", Offset = "0xB74DC90", VA = "0x18B74F090")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xB74F1A0", Offset = "0xB74DDA0", VA = "0x18B74F1A0")]
		public bool ITKEDFSJJZK(BPRBDHLKYOI a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xB74F3F0", Offset = "0xB74DFF0", VA = "0x18B74F3F0")]
		public BPRBDHLKYOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3727170", Offset = "0x3725D70", VA = "0x183727170")]
		[CompilerGenerated]
		internal static bool JCPRMYZVPFE<a>(a[] a, a[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x37282E0", Offset = "0x3726EE0", VA = "0x1837282E0")]
		[CompilerGenerated]
		internal static bool ZWNRMVKIOBL<b>(b[][] a, b[][] b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public abstract class CMAQFEIKVJZ : FPFJFXFEQVP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		internal Material FGFNKTYVVHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private AlphaMode TAZWKMSNINS;

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public static readonly int PWKQPNHEVMZ;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private static readonly int ARBTADXCSHC;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private static readonly int XQUAFLCEXAD;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private static readonly int OIBOZWJNDHE;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private static readonly int HPUSGJDMPJO;

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private static readonly int TEBZUTJJVGT;

		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private static readonly int KXCSPSWZTEN;

		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private static readonly int TFXPASVKXKM;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private static readonly int UWROXYQKHRW;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private static readonly int GCFYALLTYVV;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private static readonly int XOKMBJFYJUJ;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private static readonly int LSMYFYEAGHQ;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private static readonly int BEXFZIYEUBP;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private static readonly int EUKWSKLJIYZ;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Material KSFJLDIUTJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public virtual AlphaMode ZGWPXVNVLLV
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0xB752300", Offset = "0xB750F00", VA = "0x18B752300", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public double YTQVMVFDNFD
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0xB752190", Offset = "0xB750D90", VA = "0x18B752190", Slot = "12")]
			get
			{
				return default(double);
			}
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0xB752240", Offset = "0xB750E40", VA = "0x18B752240", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public virtual bool WLBMYEQTVAK
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0xB753300", Offset = "0xB751F00", VA = "0x18B753300", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public virtual bool NXVVOQFMGXV
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0xB753210", Offset = "0xB751E10", VA = "0x18B753210", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public Texture HLJGRKJBRVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0xB7521E0", Offset = "0xB750DE0", VA = "0x18B7521E0", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int YLLRPEPDANQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0xB752DA0", Offset = "0xB7519A0", VA = "0x18B752DA0", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Vector2 DCZUAGVCRHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0xB752130", Offset = "0xB750D30", VA = "0x18B752130", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public double MPCSEVPICUG
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0xB7531B0", Offset = "0xB751DB0", VA = "0x18B7531B0", Slot = "18")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Vector2 KUTKWCUPWOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0xB7522A0", Offset = "0xB750EA0", VA = "0x18B7522A0", Slot = "19")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public int ZEKHCLFYUVA
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0xB753290", Offset = "0xB751E90", VA = "0x18B753290", Slot = "20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public Color SLLIUAGFTLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xB7533E0", Offset = "0xB751FE0", VA = "0x18B7533E0", Slot = "21")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract FPFJFXFEQVP Clone();

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
		protected CMAQFEIKVJZ(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xB7538C0", Offset = "0xB7524C0", VA = "0x18B7538C0")]
		protected CMAQFEIKVJZ(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xB752E10", Offset = "0xB751A10", VA = "0x18B752E10")]
		protected void LBUMNBGKTGO(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xB753450", Offset = "0xB752050", VA = "0x18B753450")]
		protected void ZOGPPZBRPLR(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xB752EF0", Offset = "0xB751AF0", VA = "0x18B752EF0")]
		protected void LQGRDKCRBGV(Material a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class VJWUBLJKJIP : ZKCLBJEKISN, LQTCXAEZXIN, CNRQIUIJDTE, FPFJFXFEQVP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private Vector2 SWAJJQBJHQX;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public virtual Texture HLJGRKJBRVV
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xB763F70", Offset = "0xB762B70", VA = "0x18B763F70", Slot = "77")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public virtual int YLLRPEPDANQ
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "78")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public virtual Vector2 DCZUAGVCRHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0xB763E00", Offset = "0xB762A00", VA = "0x18B763E00", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public virtual double MPCSEVPICUG
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public virtual Vector2 KUTKWCUPWOG
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xB763FD0", Offset = "0xB762BD0", VA = "0x18B763FD0", Slot = "81")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public virtual int ZEKHCLFYUVA
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "82")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public virtual Color SLLIUAGFTLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0xB764110", Offset = "0xB762D10", VA = "0x18B764110", Slot = "83")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public virtual Texture XNSWUSFUUVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0xB763E70", Offset = "0xB762A70", VA = "0x18B763E70", Slot = "84")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public virtual int IRRTPVOQRUX
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public virtual Vector2 OTEMWTICTLS
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "86")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public virtual double AIOIIEETKJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual Vector2 CTIKHJUMSUH
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "88")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public virtual int WTXDBQJDNCV
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public virtual double PJDJHUVPVLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0xB7640C0", Offset = "0xB762CC0", VA = "0x18B7640C0", Slot = "90")]
			get
			{
				return default(double);
			}
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0xB764060", Offset = "0xB762C60", VA = "0x18B764060", Slot = "91")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public virtual double WYCFOLMCBBX
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "92")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xB764190", Offset = "0xB762D90", VA = "0x18B764190")]
		protected VJWUBLJKJIP(string a, string b, int c = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0xB764180", Offset = "0xB762D80", VA = "0x18B764180")]
		protected VJWUBLJKJIP(Material a, int b = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xB763EC0", Offset = "0xB762AC0", VA = "0x18B763EC0", Slot = "60")]
		public override FPFJFXFEQVP Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class OUSHGBXSYHU : VJWUBLJKJIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private Vector2 PJRDMMMPALJ;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public override int WDGIYJVOTDP
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "35")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public override int NNXHQORFOVN
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public override int ZHCSYLZWOTH
		{
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "49")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public override int YLLRPEPDANQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "78")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public override Texture XNSWUSFUUVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0xB755370", Offset = "0xB753F70", VA = "0x18B755370", Slot = "84")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public override int IRRTPVOQRUX
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public override Vector2 OTEMWTICTLS
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0xB755590", Offset = "0xB754190", VA = "0x18B755590", Slot = "86")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public override double AIOIIEETKJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public override Vector2 CTIKHJUMSUH
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0xB755500", Offset = "0xB754100", VA = "0x18B755500", Slot = "88")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public override int WTXDBQJDNCV
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public override double WYCFOLMCBBX
		{
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0xB7554A0", Offset = "0xB7540A0", VA = "0x18B7554A0", Slot = "92")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xB755620", Offset = "0xB754220", VA = "0x18B755620")]
		public OUSHGBXSYHU(string a, int b = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xB755600", Offset = "0xB754200", VA = "0x18B755600")]
		protected OUSHGBXSYHU(Material a, int b = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xB7553F0", Offset = "0xB753FF0", VA = "0x18B7553F0", Slot = "60")]
		public override FPFJFXFEQVP Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class BTJWYFMOIDY : CMAQFEIKVJZ, LQTCXAEZXIN, CNRQIUIJDTE, FPFJFXFEQVP, UKDVSIJIEYR, PDPNWSKZUMH, FWPUCYFINST, PHHDCKGAEEV, DTHECBUOYJK, RBVEWGXPMBJ, UGDXQITHRTH, QBZRUHHHEXI, SNCPNPSAUXJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public Texture HLATYILRRYG
		{
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0xB74FE20", Offset = "0xB74EA20", VA = "0x18B74FE20", Slot = "37")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0xB7502A0", Offset = "0xB74EEA0", VA = "0x18B7502A0", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public int WDGIYJVOTDP
		{
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0xB750170", Offset = "0xB74ED70", VA = "0x18B750170", Slot = "39")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public double RNBQFZTJTVU
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0xB74F650", Offset = "0xB74E250", VA = "0x18B74F650", Slot = "40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public Vector2 VBPDWSJFHXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0xB74FC40", Offset = "0xB74E840", VA = "0x18B74FC40", Slot = "41")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public double ODBDVGYIDFV
		{
			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0xB751C90", Offset = "0xB750890", VA = "0x18B751C90", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public Vector2 YVPJFYPSVOV
		{
			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0xB74F7D0", Offset = "0xB74E3D0", VA = "0x18B74F7D0", Slot = "43")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int UHGNNADGECD
		{
			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0xB750420", Offset = "0xB74F020", VA = "0x18B750420", Slot = "44")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public Texture GVBXAFWULRS
		{
			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0xB750920", Offset = "0xB74F520", VA = "0x18B750920", Slot = "45")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int NNXHQORFOVN
		{
			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0xB74FB70", Offset = "0xB74E770", VA = "0x18B74FB70", Slot = "46")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public double MZTCHTMPQLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0xB7504F0", Offset = "0xB74F0F0", VA = "0x18B7504F0", Slot = "47")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public Vector2 YAOGALGCSDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0xB74F4D0", Offset = "0xB74E0D0", VA = "0x18B74F4D0", Slot = "48")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public double AUFLZDCNXMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0xB750360", Offset = "0xB74EF60", VA = "0x18B750360", Slot = "49")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public Vector2 ZJAGVJILBWD
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0xB751A50", Offset = "0xB750650", VA = "0x18B751A50", Slot = "50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public int SSGWYOAJWBP
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0xB750DC0", Offset = "0xB74F9C0", VA = "0x18B750DC0", Slot = "51")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Texture QRHEPUODWBE
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0xB7507A0", Offset = "0xB74F3A0", VA = "0x18B7507A0", Slot = "52")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public int ZHCSYLZWOTH
		{
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0xB7517A0", Offset = "0xB7503A0", VA = "0x18B7517A0", Slot = "53")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Color CCPZUHVQOVW
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0xB750D50", Offset = "0xB74F950", VA = "0x18B750D50", Slot = "54")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0xB750980", Offset = "0xB74F580", VA = "0x18B750980", Slot = "55")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector2 FZSEEOXHGCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0xB750B70", Offset = "0xB74F770", VA = "0x18B750B70", Slot = "56")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public double LVCTYSUJLNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0xB74FCA0", Offset = "0xB74E8A0", VA = "0x18B74FCA0", Slot = "57")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector2 QHJAFRPSUTD
		{
			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0xB751430", Offset = "0xB750030", VA = "0x18B751430", Slot = "58")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public int VEJGAAHHRVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0xB74FF30", Offset = "0xB74EB30", VA = "0x18B74FF30", Slot = "59")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public Texture XNSWUSFUUVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0xB74F950", Offset = "0xB74E550", VA = "0x18B74F950", Slot = "29")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public int IRRTPVOQRUX
		{
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0xB750300", Offset = "0xB74EF00", VA = "0x18B750300", Slot = "30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Vector2 OTEMWTICTLS
		{
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0xB750240", Offset = "0xB74EE40", VA = "0x18B750240", Slot = "31")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public double AIOIIEETKJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0xB74F6B0", Offset = "0xB74E2B0", VA = "0x18B74F6B0", Slot = "32")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Vector2 CTIKHJUMSUH
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0xB750110", Offset = "0xB74ED10", VA = "0x18B750110", Slot = "33")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public int WTXDBQJDNCV
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0xB74F470", Offset = "0xB74E070", VA = "0x18B74F470", Slot = "34")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public double PJDJHUVPVLM
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0xB750740", Offset = "0xB74F340", VA = "0x18B750740", Slot = "35")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public double WYCFOLMCBBX
		{
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0xB74FFF0", Offset = "0xB74EBF0", VA = "0x18B74FFF0", Slot = "36")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public double DICXKOSZEBD
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0xB751370", Offset = "0xB74FF70", VA = "0x18B751370", Slot = "60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public Texture PFKPUBOZRJP
		{
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0xB74FF90", Offset = "0xB74EB90", VA = "0x18B74FF90", Slot = "61")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public double SKKKPUWRVGH
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0xB74FD00", Offset = "0xB74E900", VA = "0x18B74FD00", Slot = "63")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public Vector2 VXNHMZJLDVU
		{
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0xB750490", Offset = "0xB74F090", VA = "0x18B750490", Slot = "62")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public Vector2 OBQNSNQWGNX
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0xB74F530", Offset = "0xB74E130", VA = "0x18B74F530", Slot = "64")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public int KNHBAYQASXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0xB751620", Offset = "0xB750220", VA = "0x18B751620", Slot = "65")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public double FXVDZJFVDBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0xB750EF0", Offset = "0xB74FAF0", VA = "0x18B750EF0", Slot = "66")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Color QOFZRBQNMYX
		{
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0xB751550", Offset = "0xB750150", VA = "0x18B751550", Slot = "67")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public double VFXYNVMGCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0xB750860", Offset = "0xB74F460", VA = "0x18B750860", Slot = "68")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public Texture EFVYVWQKDET
		{
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0xB750E90", Offset = "0xB74FA90", VA = "0x18B750E90", Slot = "69")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public double EKDAOASZDSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0xB751BD0", Offset = "0xB7507D0", VA = "0x18B751BD0", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Vector2 FLEOLSAEEGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0xB751800", Offset = "0xB750400", VA = "0x18B751800", Slot = "70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Vector2 JHYEXRYIBFR
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0xB74F590", Offset = "0xB74E190", VA = "0x18B74F590", Slot = "72")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public int FJKPKMDQKFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0xB74F5F0", Offset = "0xB74E1F0", VA = "0x18B74F5F0", Slot = "73")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public double OHIWRPRGEJA
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0xB74F830", Offset = "0xB74E430", VA = "0x18B74F830", Slot = "74")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public double XFIMIZGTDTF
		{
			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0xB750FB0", Offset = "0xB74FBB0", VA = "0x18B750FB0", Slot = "75")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public double ILVLELDIGOC
		{
			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0xB74F8F0", Offset = "0xB74E4F0", VA = "0x18B74F8F0", Slot = "76")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public double XSXIEHUPSTE
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0xB751250", Offset = "0xB74FE50", VA = "0x18B751250", Slot = "77")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public double YGHVHLUCAAI
		{
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0xB7509F0", Offset = "0xB74F5F0", VA = "0x18B7509F0", Slot = "78")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public Texture GMESTKDJSFV
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xB7514F0", Offset = "0xB7500F0", VA = "0x18B7514F0", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public double ASSZZTXQTDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0xB74F890", Offset = "0xB74E490", VA = "0x18B74F890", Slot = "81")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public Vector2 LMIVUNRQLRW
		{
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0xB74FED0", Offset = "0xB74EAD0", VA = "0x18B74FED0", Slot = "80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public Vector2 UXGKWIARDJZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0xB7518C0", Offset = "0xB7504C0", VA = "0x18B7518C0", Slot = "82")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public int UHBHQZAVINL
		{
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0xB74F9B0", Offset = "0xB74E5B0", VA = "0x18B74F9B0", Slot = "83")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Texture ADFVPGMUNQN
		{
			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0xB7513D0", Offset = "0xB74FFD0", VA = "0x18B7513D0", Slot = "84")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public double DCYCQUFRFFV
		{
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0xB751010", Offset = "0xB74FC10", VA = "0x18B751010", Slot = "86")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public Vector2 EKSXCOPCYZU
		{
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0xB750620", Offset = "0xB74F220", VA = "0x18B750620", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public Vector2 NYUZAFYLNRP
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0xB751190", Offset = "0xB74FD90", VA = "0x18B751190", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public int GKCZGGJJSST
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0xB750A50", Offset = "0xB74F650", VA = "0x18B750A50", Slot = "88")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public double AAHJTPHXREG
		{
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0xB751070", Offset = "0xB74FC70", VA = "0x18B751070", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public Texture NXFQZXQQYTC
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0xB751980", Offset = "0xB750580", VA = "0x18B751980", Slot = "90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public double OFOEZWLPKIW
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0xB751920", Offset = "0xB750520", VA = "0x18B751920", Slot = "92")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public Vector2 NJKKNUIMMWH
		{
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0xB74FBE0", Offset = "0xB74E7E0", VA = "0x18B74FBE0", Slot = "91")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public Vector2 QIVEEXEDTQO
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xB751680", Offset = "0xB750280", VA = "0x18B751680", Slot = "93")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public int LDNXCWXRKRY
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xB750CF0", Offset = "0xB74F8F0", VA = "0x18B750CF0", Slot = "94")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Color ECIFJEIKGPB
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0xB7519E0", Offset = "0xB7505E0", VA = "0x18B7519E0", Slot = "95")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Texture VDBZGELHHBB
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0xB7501E0", Offset = "0xB74EDE0", VA = "0x18B7501E0", Slot = "96")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public double JKCIDVIGBAN
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0xB74FB10", Offset = "0xB74E710", VA = "0x18B74FB10", Slot = "98")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public Vector2 OISWPVGGEBK
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0xB7505C0", Offset = "0xB74F1C0", VA = "0x18B7505C0", Slot = "97")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public Vector2 LNAJZBBSZCH
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0xB751B10", Offset = "0xB750710", VA = "0x18B751B10", Slot = "99")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public int AWGZCWBRJTT
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0xB7511F0", Offset = "0xB74FDF0", VA = "0x18B7511F0", Slot = "100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public double XELXRWQRTFH
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0xB751860", Offset = "0xB750460", VA = "0x18B751860", Slot = "101")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public Texture MQNVEZWWOZL
		{
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0xB751740", Offset = "0xB750340", VA = "0x18B751740", Slot = "102")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public double GKPFVJDYKXJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0xB7500B0", Offset = "0xB74ECB0", VA = "0x18B7500B0", Slot = "104")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public Vector2 YWXBOECBYUC
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0xB751C30", Offset = "0xB750830", VA = "0x18B751C30", Slot = "103")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Vector2 OBNDSVFVTLH
		{
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0xB750E30", Offset = "0xB74FA30", VA = "0x18B750E30", Slot = "105")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public int YIXYVIHLWYL
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0xB74F770", Offset = "0xB74E370", VA = "0x18B74F770", Slot = "106")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public double IRIKPSGULGD
		{
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0xB751490", Offset = "0xB750090", VA = "0x18B751490", Slot = "107")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public Texture ZGNZXXVDBST
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0xB750680", Offset = "0xB74F280", VA = "0x18B750680", Slot = "108")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public double TBWHZFVLJSN
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0xB74FE70", Offset = "0xB74EA70", VA = "0x18B74FE70", Slot = "110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public Vector2 BYFPWNUBKLS
		{
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0xB750BD0", Offset = "0xB74F7D0", VA = "0x18B750BD0", Slot = "109")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public Vector2 FUADVNWEBBN
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0xB7506E0", Offset = "0xB74F2E0", VA = "0x18B7506E0", Slot = "111")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public int OZJMYVDDZQN
		{
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0xB7515C0", Offset = "0xB7501C0", VA = "0x18B7515C0", Slot = "112")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public float YOGINFEHCDA
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0xB7512B0", Offset = "0xB74FEB0", VA = "0x18B7512B0", Slot = "113")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public float DCVEXLLNGHE
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0xB751AB0", Offset = "0xB7506B0", VA = "0x18B751AB0", Slot = "114")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public Color MVVXMWGKZZB
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0xB750550", Offset = "0xB74F150", VA = "0x18B750550", Slot = "115")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public Texture VFPLXUZYVJB
		{
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0xB750050", Offset = "0xB74EC50", VA = "0x18B750050", Slot = "116")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public double XEOGEPIEDRL
		{
			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0xB74F710", Offset = "0xB74E310", VA = "0x18B74F710", Slot = "117")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public Vector2 JYQOKGHMBYQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0xB751B70", Offset = "0xB750770", VA = "0x18B751B70", Slot = "118")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public Vector2 SNQDXEZIHYT
		{
			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0xB7508C0", Offset = "0xB74F4C0", VA = "0x18B7508C0", Slot = "119")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public int XLPOBLRZUTX
		{
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0xB750800", Offset = "0xB74F400", VA = "0x18B750800", Slot = "120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public Texture WAUZJLWASPS
		{
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0xB750C90", Offset = "0xB74F890", VA = "0x18B750C90", Slot = "121")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public double STADLJAWIVU
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0xB7510D0", Offset = "0xB74FCD0", VA = "0x18B7510D0", Slot = "122")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public Vector2 PDSIRKRRDDR
		{
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0xB750F50", Offset = "0xB74FB50", VA = "0x18B750F50", Slot = "123")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public Vector2 EFWKMJWIABI
		{
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0xB751130", Offset = "0xB74FD30", VA = "0x18B751130", Slot = "124")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public int FIHSIYRNAWO
		{
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0xB7503C0", Offset = "0xB74EFC0", VA = "0x18B7503C0", Slot = "125")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public double QTBOODRTJAF
		{
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0xB750AB0", Offset = "0xB74F6B0", VA = "0x18B750AB0", Slot = "131")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public double DHTRRLGBFYK
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xB7516E0", Offset = "0xB7502E0", VA = "0x18B7516E0", Slot = "132")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Texture XIVVFGDCZLJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0xB74FD60", Offset = "0xB74E960", VA = "0x18B74FD60", Slot = "126")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public double ECHSZMMTSTX
		{
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0xB750C30", Offset = "0xB74F830", VA = "0x18B750C30", Slot = "128")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public Vector2 ULMSJVHQIZO
		{
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0xB751310", Offset = "0xB74FF10", VA = "0x18B751310", Slot = "127")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public Vector2 ULZUNVLJQHV
		{
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0xB74FDC0", Offset = "0xB74E9C0", VA = "0x18B74FDC0", Slot = "129")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public int TMWNYZJTSLT
		{
			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0xB750B10", Offset = "0xB74F710", VA = "0x18B750B10", Slot = "130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xB751CF0", Offset = "0xB7508F0", VA = "0x18B751CF0")]
		public BTJWYFMOIDY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xB751E60", Offset = "0xB750A60", VA = "0x18B751E60")]
		protected BTJWYFMOIDY(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xB751FB0", Offset = "0xB750BB0", VA = "0x18B751FB0")]
		public BTJWYFMOIDY(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xB74FA10", Offset = "0xB74E610", VA = "0x18B74FA10", Slot = "10")]
		public override FPFJFXFEQVP Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class KMYRPNWETKM : ZKCLBJEKISN, KSLKROZDGJS, CNRQIUIJDTE, FPFJFXFEQVP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private Vector2 ZAEELCVBFHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private Vector2 NJABAAXTEII;

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public virtual Texture NYJSSJUFKAB
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0xB755020", Offset = "0xB753C20", VA = "0x18B755020", Slot = "77")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public virtual int XKWJDJEDWTS
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "78")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public virtual Vector2 VXBIFBVZQVL
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0xB754FB0", Offset = "0xB753BB0", VA = "0x18B754FB0", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public virtual double MCVCSILSENO
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public virtual Vector2 LPHVMZSPSXC
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0xB754E90", Offset = "0xB753A90", VA = "0x18B754E90", Slot = "81")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public virtual int GJUHGQEWLMI
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "82")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public virtual Color OJDFPVAAEKV
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0xB7552C0", Offset = "0xB753EC0", VA = "0x18B7552C0", Slot = "83")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public virtual Texture WCZSFNEJXPU
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0xB755210", Offset = "0xB753E10", VA = "0x18B755210", Slot = "84")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public virtual int PUPMBLSHQNT
		{
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public virtual Vector2 PXIJRPEEPPI
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xB7551A0", Offset = "0xB753DA0", VA = "0x18B7551A0", Slot = "86")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public virtual double CSQMWRGMSAX
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public virtual Vector2 ULTETAMYYIB
		{
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0xB755080", Offset = "0xB753C80", VA = "0x18B755080", Slot = "88")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public virtual int BZQBJAOBZPB
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public virtual Vector3 AAHJTPHXREG
		{
			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0xB755110", Offset = "0xB753D10", VA = "0x18B755110", Slot = "90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public virtual double SEPWMNRSEON
		{
			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0xB754F20", Offset = "0xB753B20", VA = "0x18B754F20", Slot = "91")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0xB755330", Offset = "0xB753F30", VA = "0x18B755330")]
		protected KMYRPNWETKM(string a, string b, int c = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0xB755350", Offset = "0xB753F50", VA = "0x18B755350")]
		protected KMYRPNWETKM(Material a, int b = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xB754DE0", Offset = "0xB7539E0", VA = "0x18B754DE0", Slot = "60")]
		public override FPFJFXFEQVP Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class SDJDGMICPXR : KMYRPNWETKM
	{
		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public override int WDGIYJVOTDP
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "35")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public override int NNXHQORFOVN
		{
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public override int ZHCSYLZWOTH
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "49")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public override int XKWJDJEDWTS
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "78")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public override int PUPMBLSHQNT
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xB76CA70", Offset = "0xB76B670", VA = "0x18B76CA70")]
		public SDJDGMICPXR(string a, int b = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xB76CA60", Offset = "0xB76B660", VA = "0x18B76CA60")]
		protected SDJDGMICPXR(Material a, int b = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xB76C950", Offset = "0xB76B550", VA = "0x18B76C950", Slot = "60")]
		public override FPFJFXFEQVP Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class ZKCLBJEKISN : CNRQIUIJDTE, FPFJFXFEQVP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		protected Material FGFNKTYVVHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private AlphaMode TAZWKMSNINS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private double OGZASXPFAPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private Vector2 YAANGJLFDZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private Vector2 URUZOKPOHPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private Vector2 LFWEMAXHIFK;

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public Material KSFJLDIUTJD
		{
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public virtual Texture HLATYILRRYG
		{
			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0xB775BC0", Offset = "0xB7747C0", VA = "0x18B775BC0", Slot = "33")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0xB7760C0", Offset = "0xB774CC0", VA = "0x18B7760C0", Slot = "34")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public virtual int WDGIYJVOTDP
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "35")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public virtual Vector2 VBPDWSJFHXU
		{
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0xB775B50", Offset = "0xB774750", VA = "0x18B775B50", Slot = "36")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public virtual double ODBDVGYIDFV
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "37")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public virtual Vector2 YVPJFYPSVOV
		{
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0xB775800", Offset = "0xB774400", VA = "0x18B775800", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public virtual int UHGNNADGECD
		{
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "39")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public virtual double RNBQFZTJTVU
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xB775740", Offset = "0xB774340", VA = "0x18B775740", Slot = "40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public virtual Texture GVBXAFWULRS
		{
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0xB776340", Offset = "0xB774F40", VA = "0x18B776340", Slot = "41")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public virtual int NNXHQORFOVN
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public virtual Vector2 YAOGALGCSDK
		{
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0xB7756D0", Offset = "0xB7742D0", VA = "0x18B7756D0", Slot = "43")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public virtual double AUFLZDCNXMB
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "44")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public virtual Vector2 ZJAGVJILBWD
		{
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0xB776740", Offset = "0xB775340", VA = "0x18B776740", Slot = "45")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public virtual int SSGWYOAJWBP
		{
			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "46")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		public virtual double MZTCHTMPQLF
		{
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0xB7761A0", Offset = "0xB774DA0", VA = "0x18B7761A0", Slot = "47")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public virtual Texture QRHEPUODWBE
		{
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0xB776260", Offset = "0xB774E60", VA = "0x18B776260", Slot = "48")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public virtual int ZHCSYLZWOTH
		{
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "49")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public virtual Vector2 FZSEEOXHGCG
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xB7764B0", Offset = "0xB7750B0", VA = "0x18B7764B0", Slot = "50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public virtual double LVCTYSUJLNJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "51")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public virtual Vector2 QHJAFRPSUTD
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xB776640", Offset = "0xB775240", VA = "0x18B776640", Slot = "52")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public virtual int VEJGAAHHRVV
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "53")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public virtual Color CCPZUHVQOVW
		{
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0xB776520", Offset = "0xB775120", VA = "0x18B776520", Slot = "54")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0xB776400", Offset = "0xB775000", VA = "0x18B776400", Slot = "55")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public virtual AlphaMode ZGWPXVNVLLV
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0xB775C30", Offset = "0xB774830", VA = "0x18B775C30", Slot = "56")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		public virtual double YTQVMVFDNFD
		{
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0xB775AC0", Offset = "0xB7746C0", VA = "0x18B775AC0", Slot = "57")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public virtual bool WLBMYEQTVAK
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0xB7766D0", Offset = "0xB7752D0", VA = "0x18B7766D0", Slot = "58")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		public virtual bool NXVVOQFMGXV
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0xB7765C0", Offset = "0xB7751C0", VA = "0x18B7765C0", Slot = "59")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xB7768F0", Offset = "0xB7754F0", VA = "0x18B7768F0")]
		protected ZKCLBJEKISN(string a, string b, int c = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xB7767D0", Offset = "0xB7753D0", VA = "0x18B7767D0")]
		protected ZKCLBJEKISN(Material a, int b = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xB775890", Offset = "0xB774490", VA = "0x18B775890", Slot = "60")]
		public virtual FPFJFXFEQVP Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xB775A20", Offset = "0xB774620", VA = "0x18B775A20", Slot = "61")]
		protected virtual void Copy(CNRQIUIJDTE o)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public interface FPFJFXFEQVP
	{
		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		Material KSFJLDIUTJD
		{
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		AlphaMode ZGWPXVNVLLV
		{
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		double YTQVMVFDNFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		bool WLBMYEQTVAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		bool NXVVOQFMGXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(Slot = "5")]
		FPFJFXFEQVP Clone();
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public interface CNRQIUIJDTE : FPFJFXFEQVP
	{
		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		Texture HLATYILRRYG
		{
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		int WDGIYJVOTDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		double RNBQFZTJTVU
		{
			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		Vector2 VBPDWSJFHXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		double ODBDVGYIDFV
		{
			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		Vector2 YVPJFYPSVOV
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		int UHGNNADGECD
		{
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		Texture GVBXAFWULRS
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		int NNXHQORFOVN
		{
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FE")]
		double MZTCHTMPQLF
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FF")]
		Vector2 YAOGALGCSDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000100")]
		double AUFLZDCNXMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000101")]
		Vector2 ZJAGVJILBWD
		{
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000102")]
		int SSGWYOAJWBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		Texture QRHEPUODWBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(Slot = "15")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		int ZHCSYLZWOTH
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(Slot = "16")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		Color CCPZUHVQOVW
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(Slot = "18")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		Vector2 FZSEEOXHGCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(Slot = "19")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000107")]
		double LVCTYSUJLNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(Slot = "20")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		Vector2 QHJAFRPSUTD
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(Slot = "21")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		int VEJGAAHHRVV
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(Slot = "22")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public interface LQTCXAEZXIN : CNRQIUIJDTE, FPFJFXFEQVP
	{
		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		Texture HLJGRKJBRVV
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		int YLLRPEPDANQ
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		Vector2 DCZUAGVCRHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		double MPCSEVPICUG
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010E")]
		Vector2 KUTKWCUPWOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010F")]
		int ZEKHCLFYUVA
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000110")]
		Color SLLIUAGFTLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		Texture XNSWUSFUUVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		int IRRTPVOQRUX
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		Vector2 OTEMWTICTLS
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		double AIOIIEETKJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000115")]
		Vector2 CTIKHJUMSUH
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		int WTXDBQJDNCV
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		double PJDJHUVPVLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000118")]
		double WYCFOLMCBBX
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public interface UKDVSIJIEYR : LQTCXAEZXIN, CNRQIUIJDTE, FPFJFXFEQVP
	{
		[Cpp2IlInjected.Token(Token = "0x17000119")]
		double DICXKOSZEBD
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		Texture PFKPUBOZRJP
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		Vector2 VXNHMZJLDVU
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		double SKKKPUWRVGH
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		Vector2 OBQNSNQWGNX
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		int KNHBAYQASXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		double FXVDZJFVDBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		Color QOFZRBQNMYX
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public interface PDPNWSKZUMH : LQTCXAEZXIN, CNRQIUIJDTE, FPFJFXFEQVP
	{
		[Cpp2IlInjected.Token(Token = "0x17000121")]
		double VFXYNVMGCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		Texture EFVYVWQKDET
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		Vector2 FLEOLSAEEGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		double EKDAOASZDSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		Vector2 JHYEXRYIBFR
		{
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		int FJKPKMDQKFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public interface QBZRUHHHEXI : LQTCXAEZXIN, CNRQIUIJDTE, FPFJFXFEQVP
	{
		[Cpp2IlInjected.Token(Token = "0x17000127")]
		float DCVEXLLNGHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		Color MVVXMWGKZZB
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		Texture VFPLXUZYVJB
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		double XEOGEPIEDRL
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012B")]
		Vector2 JYQOKGHMBYQ
		{
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012C")]
		Vector2 SNQDXEZIHYT
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		int XLPOBLRZUTX
		{
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012E")]
		Texture WAUZJLWASPS
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012F")]
		double STADLJAWIVU
		{
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000130")]
		Vector2 PDSIRKRRDDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		Vector2 EFWKMJWIABI
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		int FIHSIYRNAWO
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public interface UGDXQITHRTH : PDPNWSKZUMH, LQTCXAEZXIN, CNRQIUIJDTE, FPFJFXFEQVP
	{
		[Cpp2IlInjected.Token(Token = "0x17000133")]
		float YOGINFEHCDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public interface FWPUCYFINST : LQTCXAEZXIN, CNRQIUIJDTE, FPFJFXFEQVP
	{
		[Cpp2IlInjected.Token(Token = "0x17000134")]
		double OHIWRPRGEJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public interface DTHECBUOYJK : LQTCXAEZXIN, CNRQIUIJDTE, FPFJFXFEQVP
	{
		[Cpp2IlInjected.Token(Token = "0x17000135")]
		double AAHJTPHXREG
		{
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		Texture NXFQZXQQYTC
		{
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		Vector2 NJKKNUIMMWH
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		double OFOEZWLPKIW
		{
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		Vector2 QIVEEXEDTQO
		{
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013A")]
		int LDNXCWXRKRY
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013B")]
		Color ECIFJEIKGPB
		{
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013C")]
		Texture VDBZGELHHBB
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013D")]
		Vector2 OISWPVGGEBK
		{
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013E")]
		double JKCIDVIGBAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013F")]
		Vector2 LNAJZBBSZCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000140")]
		int AWGZCWBRJTT
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public interface PHHDCKGAEEV : LQTCXAEZXIN, CNRQIUIJDTE, FPFJFXFEQVP
	{
		[Cpp2IlInjected.Token(Token = "0x17000141")]
		double XFIMIZGTDTF
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000142")]
		double ILVLELDIGOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		double XSXIEHUPSTE
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		double YGHVHLUCAAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		Texture GMESTKDJSFV
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000146")]
		Vector2 LMIVUNRQLRW
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		double ASSZZTXQTDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		Vector2 UXGKWIARDJZ
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		int UHBHQZAVINL
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		Texture ADFVPGMUNQN
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		Vector2 EKSXCOPCYZU
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		double DCYCQUFRFFV
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		Vector2 NYUZAFYLNRP
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		int GKCZGGJJSST
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public interface KSLKROZDGJS : CNRQIUIJDTE, FPFJFXFEQVP
	{
		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		Texture NYJSSJUFKAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		int XKWJDJEDWTS
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		Vector2 VXBIFBVZQVL
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		double MCVCSILSENO
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		Vector2 LPHVMZSPSXC
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000154")]
		int GJUHGQEWLMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000155")]
		Color OJDFPVAAEKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		Texture WCZSFNEJXPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		int PUPMBLSHQNT
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000158")]
		Vector2 PXIJRPEEPPI
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		double CSQMWRGMSAX
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		Vector2 ULTETAMYYIB
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		int BZQBJAOBZPB
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		Vector3 AAHJTPHXREG
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		double SEPWMNRSEON
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public interface RBVEWGXPMBJ : LQTCXAEZXIN, CNRQIUIJDTE, FPFJFXFEQVP
	{
		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		double XELXRWQRTFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		Texture MQNVEZWWOZL
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000160")]
		Vector2 YWXBOECBYUC
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		double GKPFVJDYKXJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		Vector2 OBNDSVFVTLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		int YIXYVIHLWYL
		{
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		double IRIKPSGULGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		Texture ZGNZXXVDBST
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		Vector2 BYFPWNUBKLS
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		double TBWHZFVLJSN
		{
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000168")]
		Vector2 FUADVNWEBBN
		{
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		int OZJMYVDDZQN
		{
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public interface QGTUXMGLSKW
	{
		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		Texture AROJOHIGAFW
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700016B")]
		Vector2 BYODTQCYBHB
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		double OTYHCMFZQLY
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700016D")]
		Vector2 SCKUIUKZIIS
		{
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700016E")]
		int ENKOCJHJMTE
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public interface SNCPNPSAUXJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700016F")]
		Texture XIVVFGDCZLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000170")]
		Vector2 ULMSJVHQIZO
		{
			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000171")]
		double ECHSZMMTSTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000172")]
		Vector2 ULZUNVLJQHV
		{
			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000173")]
		int TMWNYZJTSLT
		{
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000174")]
		double QTBOODRTJAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000175")]
		double DHTRRLGBFYK
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public interface VJVZDKOPGFZ : FPFJFXFEQVP
	{
		[Cpp2IlInjected.Token(Token = "0x17000176")]
		Texture HLJGRKJBRVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000177")]
		int YLLRPEPDANQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000178")]
		Vector2 DCZUAGVCRHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000179")]
		double MPCSEVPICUG
		{
			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700017A")]
		Vector2 KUTKWCUPWOG
		{
			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700017B")]
		int ZEKHCLFYUVA
		{
			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700017C")]
		Color SLLIUAGFTLZ
		{
			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class KFFQUIHWXLY : CMAQFEIKVJZ, VJVZDKOPGFZ, FPFJFXFEQVP
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xB76A320", Offset = "0xB768F20", VA = "0x18B76A320")]
		public KFFQUIHWXLY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xB76A2B0", Offset = "0xB768EB0", VA = "0x18B76A2B0")]
		protected KFFQUIHWXLY(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0xB76A250", Offset = "0xB768E50", VA = "0x18B76A250")]
		public KFFQUIHWXLY(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xB76A160", Offset = "0xB768D60", VA = "0x18B76A160", Slot = "10")]
		public override FPFJFXFEQVP Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class OBDUDJMYGTY : ZKCLBJEKISN, VJVZDKOPGFZ, FPFJFXFEQVP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private Vector2 SWAJJQBJHQX;

		[Cpp2IlInjected.Token(Token = "0x1700017D")]
		public Texture HLJGRKJBRVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0xB76BD80", Offset = "0xB76A980", VA = "0x18B76BD80", Slot = "62")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017E")]
		public virtual int YLLRPEPDANQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "69")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017F")]
		public virtual Vector2 DCZUAGVCRHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0xB76BD10", Offset = "0xB76A910", VA = "0x18B76BD10", Slot = "70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000180")]
		public virtual double MPCSEVPICUG
		{
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000181")]
		public virtual Vector2 KUTKWCUPWOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0xB76BDE0", Offset = "0xB76A9E0", VA = "0x18B76BDE0", Slot = "72")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000182")]
		public virtual int ZEKHCLFYUVA
		{
			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "73")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000183")]
		public virtual Color SLLIUAGFTLZ
		{
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0xB76BE70", Offset = "0xB76AA70", VA = "0x18B76BE70", Slot = "74")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xB76BEE0", Offset = "0xB76AAE0", VA = "0x18B76BEE0")]
		public OBDUDJMYGTY(string a, string b, int c = 1000)
		{
		}
	}
}
namespace UnityGLTF.Timeline
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class JXVLVTGIXHV
	{
		[Cpp2IlInjected.Token(Token = "0x2000092")]
		public delegate void OnBeforeAddAnimationDataDelegate(GDGQINNWUOU animationData);

		[Cpp2IlInjected.Token(Token = "0x2000093")]
		public delegate void OnPostExportDelegate(UTCLZWLVYLP animationData);

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		public class UTCLZWLVYLP
		{
			[Cpp2IlInjected.Token(Token = "0x17000186")]
			private Bounds SBHFNNJLRRO
			{
				[Cpp2IlInjected.Token(Token = "0x60003AA")]
				[Cpp2IlInjected.Address(RVA = "0xA8B8290", Offset = "0xA8B6E90", VA = "0x18A8B8290")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000187")]
			private GLTFSceneExporter FBQZVILHUZP
			{
				[Cpp2IlInjected.Token(Token = "0x60003AB")]
				[Cpp2IlInjected.Address(RVA = "0xCF1780", Offset = "0xCF0380", VA = "0x180CF1780")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000188")]
			private TBEADDWHLOJ MZXTWRNRXXP
			{
				[Cpp2IlInjected.Token(Token = "0x60003AC")]
				[Cpp2IlInjected.Address(RVA = "0xCF64C0", Offset = "0xCF50C0", VA = "0x180CF64C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0xB7714E0", Offset = "0xB7700E0", VA = "0x18B7714E0")]
			internal UTCLZWLVYLP(Bounds a, GLTFSceneExporter b, TBEADDWHLOJ c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		public class GDGQINNWUOU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			internal AnimationData.QARACVJFRCX VTJTMMXAOTH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			public float[] TPVZOLFKNJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public object[] BDAPNDJPKEO;

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0xDD8300", Offset = "0xDD6F00", VA = "0x180DD8300")]
			internal GDGQINNWUOU(AnimationData.QARACVJFRCX a, float[] b, object[] c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000096")]
		internal class AnimationData
		{
			[Cpp2IlInjected.Token(Token = "0x2000097")]
			internal class DUGAPAJQFUB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000372")]
				public string URJHJWWOCPE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000373")]
				public Type CACEJKPUWQY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000374")]
				public Func<Transform, UnityEngine.Object> TRSYZUVAZLT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000375")]
				public Func<Transform, UnityEngine.Object, AnimationData, object> KKYGGPOTCKA;

				[Cpp2IlInjected.Token(Token = "0x60003B2")]
				[Cpp2IlInjected.Address(RVA = "0x1120590", Offset = "0x111F190", VA = "0x181120590")]
				public DUGAPAJQFUB(string a, Type b, Func<Transform, UnityEngine.Object> c, Func<Transform, UnityEngine.Object, AnimationData, object> d)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003B3")]
				[Cpp2IlInjected.Address(RVA = "0xB766020", Offset = "0xB764C20", VA = "0x18B766020")]
				public object TDKWYOPWDCC(AnimationData a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000098")]
			internal class QARACVJFRCX
			{
				[Cpp2IlInjected.Token(Token = "0x2000099")]
				private class CXPNIYIFRIH
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400037B")]
					public double TRNMKYXETSJ;

					[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
					[Cpp2IlInjected.Token(Token = "0x400037C")]
					public object BGRSASFVZVT;

					[Cpp2IlInjected.Token(Token = "0x60003BA")]
					[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
					public CXPNIYIFRIH()
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000376")]
				private AnimationData YEPCWGBLSJQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000377")]
				private DUGAPAJQFUB OUFACAYROYD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000378")]
				private Dictionary<double, object> KHTRAPERTXZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000379")]
				private CXPNIYIFRIH GLGRKQFFSOG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400037A")]
				private CXPNIYIFRIH SHSRXVPYHTZ;

				[Cpp2IlInjected.Token(Token = "0x17000189")]
				public UnityEngine.Object MBUJEIRXPZY
				{
					[Cpp2IlInjected.Token(Token = "0x60003B4")]
					[Cpp2IlInjected.Address(RVA = "0xB76C590", Offset = "0xB76B190", VA = "0x18B76C590")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018A")]
				public string URJHJWWOCPE
				{
					[Cpp2IlInjected.Token(Token = "0x60003B5")]
					[Cpp2IlInjected.Address(RVA = "0x2AB1EB0", Offset = "0x2AB0AB0", VA = "0x182AB1EB0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018B")]
				public float[] IOUYMPIBDVI
				{
					[Cpp2IlInjected.Token(Token = "0x60003B6")]
					[Cpp2IlInjected.Address(RVA = "0xB76C430", Offset = "0xB76B030", VA = "0x18B76C430")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018C")]
				public object[] OQIWLEHREZU
				{
					[Cpp2IlInjected.Token(Token = "0x60003B7")]
					[Cpp2IlInjected.Address(RVA = "0xB76C5D0", Offset = "0xB76B1D0", VA = "0x18B76C5D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60003B8")]
				[Cpp2IlInjected.Address(RVA = "0xB76C880", Offset = "0xB76B480", VA = "0x18B76C880")]
				public QARACVJFRCX(AnimationData a, DUGAPAJQFUB b, double c)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003B9")]
				[Cpp2IlInjected.Address(RVA = "0xB76C630", Offset = "0xB76B230", VA = "0x18B76C630")]
				public void NTGIHRGBXRN(double a)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			internal Transform YEPCWGBLSJQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			private SkinnedMeshRenderer JRSDHNBCSBY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			private bool ZSBIKIFZKBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			private bool DZEMQXTZPCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			private bool WDRITHZEOES;

			[Cpp2IlInjected.Token(Token = "0x400036F")]
			private static List<DUGAPAJQFUB> GJQPUMTYPJE;

			[Cpp2IlInjected.Token(Token = "0x4000370")]
			private static MaterialPropertyBlock VABVFSDEYEV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			internal List<QARACVJFRCX> MOBRBVXPVHK;

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0xB764700", Offset = "0xB763300", VA = "0x18B764700")]
			public AnimationData(Transform tr, double time, bool zeroScale = false, bool recordBlendShapes = true, bool inWorldSpace = false, bool recordAnimationPointer = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0xB764560", Offset = "0xB763160", VA = "0x18B764560")]
			public void Update(double time)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		internal ICollection<Transform> PTAMCXUFLRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private Transform CNBVPAWZDFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private Dictionary<Transform, AnimationData> GEHCEZHJWAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private double ZVDLVNZVWGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private double BSCLDMEEVGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		private bool WTXYOBSACZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		private bool GNUUZITZLJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private readonly bool ZSBIKIFZKBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private readonly bool WZYXGSAFPOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private readonly bool WDRITHZEOES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public string UETZNEOEPFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public OnBeforeAddAnimationDataDelegate SZJGWOKJXPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public OnPostExportDelegate QSISRHRRQCV;

		[Cpp2IlInjected.Token(Token = "0x4000361")]
		private static ProfilerMarker CKISQNOIKUH;

		[Cpp2IlInjected.Token(Token = "0x4000362")]
		private static ProfilerMarker FXTARXUEOXM;

		[Cpp2IlInjected.Token(Token = "0x4000363")]
		private static ProfilerMarker VUTDSUPUILZ;

		[Cpp2IlInjected.Token(Token = "0x17000184")]
		public bool UIZBGUNRISX
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x1B6BE00", Offset = "0x1B6AA00", VA = "0x181B6BE00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000185")]
		public double WGHONXXFDXD
		{
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0xE1D9C0", Offset = "0xE1C5C0", VA = "0x180E1D9C0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0xB769FE0", Offset = "0xB768BE0", VA = "0x18B769FE0")]
		public JXVLVTGIXHV(Transform a, bool b = true, bool c = false, bool d = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xB769930", Offset = "0xB768530", VA = "0x18B769930")]
		private bool NLTSVTFRBOE(Transform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0xB7699F0", Offset = "0xB7685F0", VA = "0x18B7699F0")]
		public void QMMJIJRGNNB(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xB769C30", Offset = "0xB768830", VA = "0x18B769C30")]
		public void XYFUTYRXMOE(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xB769250", Offset = "0xB767E50", VA = "0x18B769250")]
		public void FCATJKJLYIU(string a, string b = "scene", [Optional] GLTFSettings c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xB768B50", Offset = "0xB767750", VA = "0x18B768B50")]
		public void FCATJKJLYIU(Stream a, string b = "scene", [Optional] GLTFSettings c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xB768950", Offset = "0xB767550", VA = "0x18B768950")]
		private void DILMJNJPHSQ(GLTFSceneExporter a, TBEADDWHLOJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xB7693C0", Offset = "0xB767FC0", VA = "0x18B7693C0")]
		private void MPCWQKIVGHA(GLTFSceneExporter a, KTVCVTRZYQB b, bool c, [Out] Bounds d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public class GLTFRecorderBehaviour : PlayableBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class WLUGBDBSDJT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			public GLTFRecorderBehaviour DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			public double TRNMKYXETSJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			public Playable IJHVXWEEIVU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			public FrameData KLEFPGODQAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			public object EXFGKPKGCDP;

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public WLUGBDBSDJT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0xB7744C0", Offset = "0xB7730C0", VA = "0x18B7744C0")]
			internal void OXEPULGVKLS()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private JXVLVTGIXHV XNRRSTRDOKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public GLTFRecorderClip Clip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private bool ZDFNXSGFQBQ;

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xB767740", Offset = "0xB766340", VA = "0x18B767740")]
		private void TNOCABAOPBG(double a, Transform b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0xB767190", Offset = "0xB765D90", VA = "0x18B767190")]
		private void EEPKPVNZJZN(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xB767810", Offset = "0xB766410", VA = "0x18B767810")]
		private void WYAIAPRDVCU(double a, Transform b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0")]
		private static bool NDJOXMKLKKS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xB767560", Offset = "0xB766160", VA = "0x18B767560", Slot = "16")]
		public override void OnPlayableDestroy(Playable playable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0xB767330", Offset = "0xB765F30", VA = "0x18B767330", Slot = "13")]
		public override void OnGraphStart(Playable playable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xB7674C0", Offset = "0xB7660C0", VA = "0x18B7674C0", Slot = "14")]
		public override void OnGraphStop(Playable playable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xB767600", Offset = "0xB766200", VA = "0x18B767600", Slot = "20")]
		public override void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x1AA40B0", Offset = "0x1AA2CB0", VA = "0x181AA40B0", Slot = "17")]
		public override void OnBehaviourPlay(Playable playable, FrameData info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x1869CC0", Offset = "0x18688C0", VA = "0x181869CC0", Slot = "18")]
		public override void OnBehaviourPause(Playable playable, FrameData info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xB7671F0", Offset = "0xB765DF0", VA = "0x18B7671F0")]
		public void OKZECLUDFRB(double a, Playable b, FrameData c, object d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0CD60", Offset = "0xD0B960", VA = "0x180D0CD60", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(ClipCaps);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0xB767A50", Offset = "0xB766650", VA = "0x18B767A50", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xB767B60", Offset = "0xB766760", VA = "0x18B767B60")]
		public Transform GetExportRoot(PlayableGraph graph)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xB767BC0", Offset = "0xB7667C0", VA = "0x18B767BC0")]
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
		private sealed class KKVBVNFXXUP : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			private object PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public GLTFRecorderHelper DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x1700018E")]
			private object LDTKDHZVICR
			{
				[Cpp2IlInjected.Token(Token = "0x60003EA")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700018F")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x60003EC")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public KKVBVNFXXUP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0xB76A3F0", Offset = "0xB768FF0", VA = "0x18B76A3F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0xB76A3B0", Offset = "0xB768FB0", VA = "0x18B76A3B0", Slot = "8")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private List<Action> MCPROBYHKIA;

		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private static GLTFRecorderHelper CYXBXYXEPKL;

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xB767C50", Offset = "0xB766850", VA = "0x18B767C50")]
		public static void Add(Action callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0xB767E90", Offset = "0xB766A90", VA = "0x18B767E90")]
		private static GLTFRecorderHelper HJMPLKRNCTZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0xB768030", Offset = "0xB766C30", VA = "0x18B768030")]
		[IteratorStateMachine(typeof(KKVBVNFXXUP))]
		private IEnumerator LOAVWIWVVVL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0xB7680A0", Offset = "0xB766CA0", VA = "0x18B7680A0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0xB768120", Offset = "0xB766D20", VA = "0x18B768120")]
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
		[Cpp2IlInjected.Address(RVA = "0xB7681A0", Offset = "0xB766DA0", VA = "0x18B7681A0")]
		public GLTFRecorderTrack()
		{
		}
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	internal static class YRINSHDYRWQ
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		[CompilerGenerated]
		private sealed class UFMXOEVUXJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			public int FHUUALWBLFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			public HOGBSPSFOTV EEQHWLXGPEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			public AITVUNWJGXJ GWVNYBXOSBW;

			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public UFMXOEVUXJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0xB771330", Offset = "0xB76FF30", VA = "0x18B771330")]
			internal float[] MOYYOQMCHNB(AITVUNWJGXJ a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0xB7712A0", Offset = "0xB76FEA0", VA = "0x18B7712A0")]
			internal float[] MOTRRJSEYBS(AITVUNWJGXJ a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0xB771450", Offset = "0xB770050", VA = "0x18B771450")]
			internal float[] MPJMJDZXAJT(AITVUNWJGXJ a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0xB7713C0", Offset = "0xB76FFC0", VA = "0x18B7713C0")]
			internal float[] MPEFLXFZQYK(AITVUNWJGXJ a, int b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private static readonly string[] BLRAHWRPYVC;

		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private static readonly string[] FJKSIBNGGOE;

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xB774E10", Offset = "0xB773A10", VA = "0x18B774E10")]
		internal static bool LYJDDDLSCKL(string a, FPYDPRWZMXW b, Material c, string d, LOWENHEWMHZ e, [Out] AITVUNWJGXJ f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xB774670", Offset = "0xB773270", VA = "0x18B774670")]
		internal static string[] EVBDYMGGDMQ(string a, int b, int c = 0, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0xB774820", Offset = "0xB773420", VA = "0x18B774820")]
		internal static float[] JQOITSXBSNU(int a, int b, HOGBSPSFOTV c, AITVUNWJGXJ d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class HOGBSPSFOTV
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
		public PropertyTypeOption SIHAFIFIULD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public string WGGFYYFYCDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public string SISZMYKAOXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public bool SUZRDEKLAAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public CombineResultType RWOQGAHSTJX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public GLTFAccessorAttributeType OVHYAQCRGDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public bool RXDMYPJWEYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public bool BAMGQSDALIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x36")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public bool IPILZTJUJNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public float PRERUSGTJNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public string JYCBMNEBGBU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public CombinePrimaryAndSecondaryData MWLDAHFNMVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private string[] RYLCZNKHCGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		internal int[] GRUSVTCBNIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		internal int[] OVMCJNGDEVY;

		[Cpp2IlInjected.Token(Token = "0x17000190")]
		public string[] RRJGEHSTQRR
		{
			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0xCEE120", Offset = "0xCECD20", VA = "0x180CEE120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0xB768530", Offset = "0xB767130", VA = "0x18B768530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000191")]
		public bool TVHXTZIYJJR
		{
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0xB7682A0", Offset = "0xB766EA0", VA = "0x18B7682A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0xB768700", Offset = "0xB767300", VA = "0x18B768700")]
		public HOGBSPSFOTV(PropertyTypeOption a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xB768560", Offset = "0xB767160", VA = "0x18B768560")]
		private void TFDONSICQWN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xB7682C0", Offset = "0xB766EC0", VA = "0x18B7682C0")]
		private static float[] EHVKTBCRUUU(float[] a, float[] b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xB768410", Offset = "0xB767010", VA = "0x18B768410")]
		private void MZPZVQOSBQM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class FPYDPRWZMXW
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
		private Dictionary<string, HOGBSPSFOTV> LPADBSHCOHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private Dictionary<string, HOGBSPSFOTV> CLCVHKNWEHD;

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xB766880", Offset = "0xB765480", VA = "0x18B766880")]
		public void LTDTDJMANZG(string a, string[] b, [Optional] string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xB766D80", Offset = "0xB765980", VA = "0x18B766D80")]
		public void RMRXWKZIHVF(HOGBSPSFOTV a, ImportExportUsageOption b = ImportExportUsageOption.ImportAndExport)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0xB766290", Offset = "0xB764E90", VA = "0x18B766290")]
		public bool FKYRRLEYJWS(Material a, string b, [Out] HOGBSPSFOTV c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0xB7664B0", Offset = "0xB7650B0", VA = "0x18B7664B0")]
		public bool IEWIIJLJHXN(Material a, string b, [Out] string c, [Out] HOGBSPSFOTV d, [Out] bool e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0xB766FA0", Offset = "0xB765BA0", VA = "0x18B766FA0")]
		public FPYDPRWZMXW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public class SLPHXXMSSUN : FPYDPRWZMXW
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0xB76CAE0", Offset = "0xB76B6E0", VA = "0x18B76CAE0")]
		public SLPHXXMSSUN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public class AnimationPointerExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000192")]
		public override string MZXYTBCYJEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0xB765710", Offset = "0xB764310", VA = "0x18B765710", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000193")]
		public override string ILAJSRGUDLA
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0xB7656E0", Offset = "0xB7642E0", VA = "0x18B7656E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		public override bool WPSJDRLSWSR
		{
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0xB765640", Offset = "0xB764240", VA = "0x18B765640", Slot = "14")]
		public override JSPTBLBUDYT CreateInstance(CEQPJQFTIIZ context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x161A800", Offset = "0x1619400", VA = "0x18161A800")]
		public AnimationPointerExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public class FELSSASWWNC : JSPTBLBUDYT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public FPYDPRWZMXW KEAPDKMLIMU;

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0xB766220", Offset = "0xB764E20", VA = "0x18B766220")]
		public FELSSASWWNC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public class AnimationPointerImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000195")]
		public override string MZXYTBCYJEB
		{
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0xB765810", Offset = "0xB764410", VA = "0x18B765810", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000196")]
		public override string ILAJSRGUDLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0xB7657E0", Offset = "0xB7643E0", VA = "0x18B7657E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0xB765740", Offset = "0xB764340", VA = "0x18B765740", Slot = "13")]
		public override QAYXRHOUCJA CreateInstance(VUSAZGCWQUD context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x161A800", Offset = "0x1619400", VA = "0x18161A800")]
		public AnimationPointerImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	public class VWXLJRXFFFT : QAYXRHOUCJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public FPYDPRWZMXW KEAPDKMLIMU;

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0xB774390", Offset = "0xB772F90", VA = "0x18B774390")]
		public VWXLJRXFFFT()
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
		[Cpp2IlInjected.Address(RVA = "0xD19810", Offset = "0xD18410", VA = "0x180D19810")]
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
		[Cpp2IlInjected.Address(RVA = "0xD19810", Offset = "0xD18410", VA = "0x180D19810")]
		public ExperimentalPluginAttribute([Optional] string tooltip)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public abstract class GLTFExportPlugin : GLTFPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000197")]
		public virtual JToken ZARVQQPWVED
		{
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(Slot = "14")]
		public abstract JSPTBLBUDYT CreateInstance(CEQPJQFTIIZ context);

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x161A800", Offset = "0x1619400", VA = "0x18161A800")]
		protected GLTFExportPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public abstract class JSPTBLBUDYT
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "4")]
		public virtual void ALDBYSRVLNZ(GLTFSceneExporter a, TBEADDWHLOJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
		public virtual void YSYXPGTUUFG(GLTFSceneExporter a, TBEADDWHLOJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "6")]
		public virtual bool SBOODNYDRUN(GLTFSceneExporter a, TBEADDWHLOJ b, Transform c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "7")]
		public virtual void DDKRHGDJPEF(GLTFSceneExporter a, TBEADDWHLOJ b, Transform c, KTFAJFRQMLO d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "8")]
		public virtual void KOAVTZEWSSQ(GLTFSceneExporter a, TBEADDWHLOJ b, Transform c, KTFAJFRQMLO d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "9")]
		public virtual bool NJGGHFTNWOE(GLTFSceneExporter a, TBEADDWHLOJ b, Material c, AHICOKAOCWI d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "10")]
		public virtual void TRKJQUYUFPT(GLTFSceneExporter a, TBEADDWHLOJ b, Material c, AHICOKAOCWI d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "11")]
		public virtual void MAQEKIUTROA(GLTFSceneExporter a, GLTFSceneExporter.UniqueTexture b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "12")]
		public virtual void XEBGBXMXZMH(GLTFSceneExporter a, GLTFSceneExporter.UniqueTexture b, int c, JQEEIHSQRHG d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "13")]
		public virtual void XOIZBTYWGCZ(GLTFSceneExporter a, Mesh b, ORTIZQKCQUO c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "14")]
		public virtual void KQKZDNDZZNL(GLTFSceneExporter a, Mesh b, KHWXUNVOHHW c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		protected JSPTBLBUDYT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public abstract class GLTFImportPlugin : GLTFPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(Slot = "13")]
		public abstract QAYXRHOUCJA CreateInstance(VUSAZGCWQUD context);

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x161A800", Offset = "0x1619400", VA = "0x18161A800")]
		protected GLTFImportPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public abstract class QAYXRHOUCJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "4")]
		public virtual void SQHTSZUKIZF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
		public virtual void HSUGXEIAPMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "6")]
		public virtual void DTDXLFRPVWU(TBEADDWHLOJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "7")]
		public virtual void LPXPVFCXOBT(ZZHEPEFHRAT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "8")]
		public virtual void YNMRJDFSNAE(KTFAJFRQMLO a, int b, GameObject c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "9")]
		public virtual void SRSCUNUIELH(AHICOKAOCWI a, int b, Material c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "10")]
		public virtual void RICXYTEJSBN(JQEEIHSQRHG a, int b, Texture c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "11")]
		public virtual void QZQAIBXMYCQ(ZZHEPEFHRAT a, int b, GameObject c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		protected QAYXRHOUCJA()
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
		public abstract string MZXYTBCYJEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		public virtual string ILAJSRGUDLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		public virtual string JLDCTSZZHZG
		{
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		public virtual bool CXRGWAGXVPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0xB767170", Offset = "0xB765D70", VA = "0x18B767170", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0xCFD470", Offset = "0xCFC070", VA = "0x180CFD470", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		public virtual bool WPSJDRLSWSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019D")]
		public virtual bool FCLPTWVAQIW
		{
			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		public virtual string AEPROIKQQOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000437")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		public virtual bool UKHSXFHVNRK
		{
			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x161A800", Offset = "0x1619400", VA = "0x18161A800")]
		protected GLTFPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[Obsolete("Use UnityGLTF.Plugins.GLTFPlugin instead. (UnityUpgradable) -> UnityGLTF.Plugins.GLTFPlugin")]
	public abstract class GltfPlugin : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0xD88820", Offset = "0xD87420", VA = "0x180D88820")]
		protected GltfPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[Obsolete("Use UnityGLTF.Plugins.GLTFImportPlugin instead. (UnityUpgradable) -> UnityGLTF.Plugins.GLTFImportPlugin")]
	public abstract class GltfImportPlugin : GltfPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0xD88820", Offset = "0xD87420", VA = "0x180D88820")]
		protected GltfImportPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[Obsolete("Use UnityGLTF.Plugins.GLTFExportPlugin instead. (UnityUpgradable) -> UnityGLTF.Plugins.GLTFExportPlugin")]
	public abstract class GltfExportPlugin : GltfPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0xD88820", Offset = "0xD87420", VA = "0x180D88820")]
		protected GltfExportPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public class VUSAZGCWQUD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public readonly List<QAYXRHOUCJA> SERMUKPLFBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public GLTFSceneImporter POEQMMYQSEW;

		[Cpp2IlInjected.Token(Token = "0x170001A0")]
		public TBEADDWHLOJ OFIFJQDFJXG
		{
			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0xB774120", Offset = "0xB772D20", VA = "0x18B774120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0xB774140", Offset = "0xB772D40", VA = "0x18B774140")]
		private List<QAYXRHOUCJA> KJBSDEFFUGS(GLTFSettings a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0xB774350", Offset = "0xB772F50", VA = "0x18B774350")]
		internal VUSAZGCWQUD(GLTFSettings a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x40C2120", Offset = "0x40C0D20", VA = "0x1840C2120")]
		public bool CAYOOUWLIKE<a>([Out] a a) where a : QAYXRHOUCJA
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public class DracoImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001A1")]
		public override string MZXYTBCYJEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0xB766110", Offset = "0xB764D10", VA = "0x18B766110", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A2")]
		public override string ILAJSRGUDLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0xB7660E0", Offset = "0xB764CE0", VA = "0x18B7660E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A3")]
		public override bool UKHSXFHVNRK
		{
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0xB766090", Offset = "0xB764C90", VA = "0x18B766090", Slot = "13")]
		public override QAYXRHOUCJA CreateInstance(VUSAZGCWQUD context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x161A800", Offset = "0x1619400", VA = "0x18161A800")]
		public DracoImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public class BOXJINPAFON : QAYXRHOUCJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public BOXJINPAFON()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public class GPUInstancingImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001A4")]
		public override string MZXYTBCYJEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0xB768270", Offset = "0xB766E70", VA = "0x18B768270", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A5")]
		public override string ILAJSRGUDLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(RVA = "0xB768240", Offset = "0xB766E40", VA = "0x18B768240", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0xB7681F0", Offset = "0xB766DF0", VA = "0x18B7681F0", Slot = "13")]
		public override QAYXRHOUCJA CreateInstance(VUSAZGCWQUD context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x161A800", Offset = "0x1619400", VA = "0x18161A800")]
		public GPUInstancingImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public class UDPGIVFDEYW : QAYXRHOUCJA
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public UDPGIVFDEYW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public class Ktx2Import : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001A6")]
		public override string MZXYTBCYJEB
		{
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0xB76A7B0", Offset = "0xB7693B0", VA = "0x18B76A7B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A7")]
		public override string ILAJSRGUDLA
		{
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0xB76A780", Offset = "0xB769380", VA = "0x18B76A780", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A8")]
		public override bool UKHSXFHVNRK
		{
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0xB76A730", Offset = "0xB769330", VA = "0x18B76A730", Slot = "13")]
		public override QAYXRHOUCJA CreateInstance(VUSAZGCWQUD context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x161A800", Offset = "0x1619400", VA = "0x18161A800")]
		public Ktx2Import()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public class DCVEMSMSPET : QAYXRHOUCJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public DCVEMSMSPET()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public class LightsPunctualExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001A9")]
		public override string MZXYTBCYJEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0xB76AC60", Offset = "0xB769860", VA = "0x18B76AC60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		public override string ILAJSRGUDLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0xB76AC30", Offset = "0xB769830", VA = "0x18B76AC30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0xB76ABE0", Offset = "0xB7697E0", VA = "0x18B76ABE0", Slot = "14")]
		public override JSPTBLBUDYT CreateInstance(CEQPJQFTIIZ context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x161A800", Offset = "0x1619400", VA = "0x18161A800")]
		public LightsPunctualExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public class VHIFCHYKGHK : JSPTBLBUDYT
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "8")]
		public override void KOAVTZEWSSQ(GLTFSceneExporter a, TBEADDWHLOJ b, Transform c, KTFAJFRQMLO d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public VHIFCHYKGHK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public class LightsPunctualImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		public override string MZXYTBCYJEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xB76AD10", Offset = "0xB769910", VA = "0x18B76AD10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public override string ILAJSRGUDLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xB76ACE0", Offset = "0xB7698E0", VA = "0x18B76ACE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0xB76AC90", Offset = "0xB769890", VA = "0x18B76AC90", Slot = "13")]
		public override QAYXRHOUCJA CreateInstance(VUSAZGCWQUD context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x161A800", Offset = "0x1619400", VA = "0x18161A800")]
		public LightsPunctualImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public class BDZTCKWMNQJ : QAYXRHOUCJA
	{
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public BDZTCKWMNQJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[NonRatifiedPlugin(null)]
	public class LodsExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		public override string MZXYTBCYJEB
		{
			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0xB76ADC0", Offset = "0xB7699C0", VA = "0x18B76ADC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		public override string ILAJSRGUDLA
		{
			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0xB76AD90", Offset = "0xB769990", VA = "0x18B76AD90", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0xB76AD40", Offset = "0xB769940", VA = "0x18B76AD40", Slot = "14")]
		public override JSPTBLBUDYT CreateInstance(CEQPJQFTIIZ context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x161A800", Offset = "0x1619400", VA = "0x18161A800")]
		public LodsExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public class LLPCCQVMDZX : JSPTBLBUDYT
	{
		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0xB76A7E0", Offset = "0xB7693E0", VA = "0x18B76A7E0", Slot = "8")]
		public override void KOAVTZEWSSQ(GLTFSceneExporter a, TBEADDWHLOJ b, Transform c, KTFAJFRQMLO d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public LLPCCQVMDZX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[NonRatifiedPlugin(null)]
	public class LodsImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		public override string MZXYTBCYJEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0xB76AE70", Offset = "0xB769A70", VA = "0x18B76AE70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		public override string ILAJSRGUDLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0xB76AE40", Offset = "0xB769A40", VA = "0x18B76AE40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0xB76ADF0", Offset = "0xB7699F0", VA = "0x18B76ADF0", Slot = "13")]
		public override QAYXRHOUCJA CreateInstance(VUSAZGCWQUD context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x161A800", Offset = "0x1619400", VA = "0x18161A800")]
		public LodsImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public class TVPIFHTHDCY : QAYXRHOUCJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public TVPIFHTHDCY()
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
		public override string MZXYTBCYJEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0xB76B060", Offset = "0xB769C60", VA = "0x18B76B060", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		public override string ILAJSRGUDLA
		{
			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0xB76B030", Offset = "0xB769C30", VA = "0x18B76B030", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0xB76AFB0", Offset = "0xB769BB0", VA = "0x18B76AFB0", Slot = "14")]
		public override JSPTBLBUDYT CreateInstance(CEQPJQFTIIZ context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0xB76B010", Offset = "0xB769C10", VA = "0x18B76B010")]
		public MaterialExtensionsExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public class VQMGAEOEEDW : JSPTBLBUDYT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		internal readonly MaterialExtensionsExport QGQCMGPEQRD;

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private static readonly int DBBGQIUDKFD;

		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private static readonly int CXDUCAKNXTD;

		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private static readonly int XVLJBUIYFLR;

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private static readonly int PLBREUQCFOP;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private static readonly int EPQBDDARLLI;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private static readonly int KGEIYIDMTMD;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private static readonly int WJAQHIWXPTV;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private static readonly int NTMHUHIEXBY;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private static readonly int OJUGIKSSCHJ;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private static readonly int ASVJCALHSGK;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private static readonly int CFAGKDEULCS;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private static readonly int NBYURAYPGEA;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private static readonly int UOVEOQQOVEL;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private static readonly int ZHNBIJZNPLP;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private static readonly int LLAXFPTZBYO;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private static readonly int MOIEPHOLAZN;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private static readonly int HJMHIREUIGU;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private static readonly int DXNHWLJSUTB;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private static readonly int YLSDZUFQVQZ;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private static readonly int CDUPCOTQAOB;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private static readonly int BGJYYWWSTVN;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private static readonly int UWGWWPUIXJN;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private static readonly int GBGTGWARRRC;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private static readonly int WGYOAAOGWEP;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private static readonly int TSOCRHQQSSO;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private static readonly int MYGWQEVHBYT;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private static readonly int RDYIFXTRHMU;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private static readonly int QTBOODRTJAF;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private static readonly int DHTRRLGBFYK;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private static readonly int XIVVFGDCZLJ;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
		public VQMGAEOEEDW(MaterialExtensionsExport a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0xB7716B0", Offset = "0xB7702B0", VA = "0x18B7716B0", Slot = "10")]
		public override void TRKJQUYUFPT(GLTFSceneExporter a, TBEADDWHLOJ b, Material c, AHICOKAOCWI d)
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
		public override string MZXYTBCYJEB
		{
			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0xB76B140", Offset = "0xB769D40", VA = "0x18B76B140", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		public override string ILAJSRGUDLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0xB76B110", Offset = "0xB769D10", VA = "0x18B76B110", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0xB76B090", Offset = "0xB769C90", VA = "0x18B76B090", Slot = "13")]
		public override QAYXRHOUCJA CreateInstance(VUSAZGCWQUD context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0xB76B0F0", Offset = "0xB769CF0", VA = "0x18B76B0F0")]
		public MaterialExtensionsImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public class LLVCXDSORWZ : QAYXRHOUCJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		internal readonly MaterialExtensionsImport QGQCMGPEQRD;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
		public LLVCXDSORWZ(MaterialExtensionsImport a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public class MeshoptImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		public override string MZXYTBCYJEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0xB76B1F0", Offset = "0xB769DF0", VA = "0x18B76B1F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public override string ILAJSRGUDLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0xB76B1C0", Offset = "0xB769DC0", VA = "0x18B76B1C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		public override bool UKHSXFHVNRK
		{
			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0xB76B170", Offset = "0xB769D70", VA = "0x18B76B170", Slot = "13")]
		public override QAYXRHOUCJA CreateInstance(VUSAZGCWQUD context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x161A800", Offset = "0x1619400", VA = "0x18161A800")]
		public MeshoptImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public class EFPQAEHCOSS : QAYXRHOUCJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public EFPQAEHCOSS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public class TextureTransformExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001B8")]
		public override string MZXYTBCYJEB
		{
			[Cpp2IlInjected.Token(Token = "0x600047A")]
			[Cpp2IlInjected.Address(RVA = "0xB76FD00", Offset = "0xB76E900", VA = "0x18B76FD00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B9")]
		public override string ILAJSRGUDLA
		{
			[Cpp2IlInjected.Token(Token = "0x600047B")]
			[Cpp2IlInjected.Address(RVA = "0xB76FCD0", Offset = "0xB76E8D0", VA = "0x18B76FCD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		public override bool FCLPTWVAQIW
		{
			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "14")]
		public override JSPTBLBUDYT CreateInstance(CEQPJQFTIIZ context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x161A800", Offset = "0x1619400", VA = "0x18161A800")]
		public TextureTransformExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public class TextureTransformImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001BB")]
		public override string MZXYTBCYJEB
		{
			[Cpp2IlInjected.Token(Token = "0x600047F")]
			[Cpp2IlInjected.Address(RVA = "0xB76FD60", Offset = "0xB76E960", VA = "0x18B76FD60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		public override string ILAJSRGUDLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000480")]
			[Cpp2IlInjected.Address(RVA = "0xB76FD30", Offset = "0xB76E930", VA = "0x18B76FD30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		public override bool FCLPTWVAQIW
		{
			[Cpp2IlInjected.Token(Token = "0x6000481")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "13")]
		public override QAYXRHOUCJA CreateInstance(VUSAZGCWQUD context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x161A800", Offset = "0x1619400", VA = "0x18161A800")]
		public TextureTransformImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public class UnlitMaterialsExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001BE")]
		public override string MZXYTBCYJEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000484")]
			[Cpp2IlInjected.Address(RVA = "0xB771620", Offset = "0xB770220", VA = "0x18B771620", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		public override string ILAJSRGUDLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000485")]
			[Cpp2IlInjected.Address(RVA = "0xB7715F0", Offset = "0xB7701F0", VA = "0x18B7715F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		public override bool FCLPTWVAQIW
		{
			[Cpp2IlInjected.Token(Token = "0x6000486")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "14")]
		public override JSPTBLBUDYT CreateInstance(CEQPJQFTIIZ context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x161A800", Offset = "0x1619400", VA = "0x18161A800")]
		public UnlitMaterialsExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public class UnlitMaterialsImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001C1")]
		public override string MZXYTBCYJEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000489")]
			[Cpp2IlInjected.Address(RVA = "0xB771680", Offset = "0xB770280", VA = "0x18B771680", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C2")]
		public override string ILAJSRGUDLA
		{
			[Cpp2IlInjected.Token(Token = "0x600048A")]
			[Cpp2IlInjected.Address(RVA = "0xB771650", Offset = "0xB770250", VA = "0x18B771650", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C3")]
		public override bool FCLPTWVAQIW
		{
			[Cpp2IlInjected.Token(Token = "0x600048B")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "13")]
		public override QAYXRHOUCJA CreateInstance(VUSAZGCWQUD context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x161A800", Offset = "0x1619400", VA = "0x18161A800")]
		public UnlitMaterialsImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public class VisibilityExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		public override string MZXYTBCYJEB
		{
			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0xB774430", Offset = "0xB773030", VA = "0x18B774430", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		public override string ILAJSRGUDLA
		{
			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0xB774400", Offset = "0xB773000", VA = "0x18B774400", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		public override bool FCLPTWVAQIW
		{
			[Cpp2IlInjected.Token(Token = "0x6000490")]
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		public override bool WPSJDRLSWSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "14")]
		public override JSPTBLBUDYT CreateInstance(CEQPJQFTIIZ context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x161A800", Offset = "0x1619400", VA = "0x18161A800")]
		public VisibilityExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public class VisibilityImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		public override string MZXYTBCYJEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000494")]
			[Cpp2IlInjected.Address(RVA = "0xB774490", Offset = "0xB773090", VA = "0x18B774490", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		public override string ILAJSRGUDLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000495")]
			[Cpp2IlInjected.Address(RVA = "0xB774460", Offset = "0xB773060", VA = "0x18B774460", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CA")]
		public override bool FCLPTWVAQIW
		{
			[Cpp2IlInjected.Token(Token = "0x6000496")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "13")]
		public override QAYXRHOUCJA CreateInstance(VUSAZGCWQUD context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x161A800", Offset = "0x1619400", VA = "0x18161A800")]
		public VisibilityImport()
		{
		}
	}
}
namespace UnityGLTF.Loader
{
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public class QMPRMMVSABH
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
	public interface WICTABXLPMU
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Stream> SJCGTQXSXXG(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public interface JTOGRUATFES : WICTABXLPMU
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Stream ZFCXOWYWBLS(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[Obsolete("Please switch to IDataLoader.  This interface is deprecated and will be removed in a future release.")]
	public interface URCYQYUQHXW
	{
		[Cpp2IlInjected.Token(Token = "0x170001CB")]
		Stream MOIVSLXRDTL
		{
			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		bool RGSKXCYBHMG
		{
			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task ZFCXOWYWBLS(string a);

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DFNMRJMLAWT(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	public static class KOJTLPHNAMP
	{
		[Cpp2IlInjected.Token(Token = "0x20000DC")]
		private class MBTZGKLVRTS : WICTABXLPMU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000405")]
			protected readonly URCYQYUQHXW ARBKQVWTPJM;

			[Cpp2IlInjected.Token(Token = "0x60004A0")]
			[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
			public MBTZGKLVRTS(URCYQYUQHXW a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A1")]
			[Cpp2IlInjected.Address(RVA = "0xB76AEA0", Offset = "0xB769AA0", VA = "0x18B76AEA0", Slot = "4")]
			public Task<Stream> SJCGTQXSXXG(string a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000DD")]
		private class FDEGLEWFELU : MBTZGKLVRTS, JTOGRUATFES, WICTABXLPMU
		{
			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
			public FDEGLEWFELU(URCYQYUQHXW a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0xB766140", Offset = "0xB764D40", VA = "0x18B766140", Slot = "5")]
			public Stream ZFCXOWYWBLS(string a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0xB76A620", Offset = "0xB769220", VA = "0x18B76A620")]
		public static WICTABXLPMU JUAPLQCUDCU(URCYQYUQHXW a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public class YXMLBHSVAER : WICTABXLPMU
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
			public YXMLBHSVAER <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xB76FD90", Offset = "0xB76E990", VA = "0x18B76FD90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0xB770370", Offset = "0xB76EF70", VA = "0x18B770370", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		private string YMWIMATPEPZ;

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
		public YXMLBHSVAER(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0xB7755A0", Offset = "0xB7741A0", VA = "0x18B7755A0", Slot = "4")]
		[AsyncStateMachine(typeof(<LoadStreamAsync>d__2))]
		public Task<Stream> SJCGTQXSXXG(string a)
		{
			return null;
		}
	}
}
namespace UnityGLTF.Extensions
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public class NYYAONCBFDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private readonly List<KHR_animation_pointer> KYEMTXOLHEE;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private static readonly ProfilerMarker TWJWDSDNXXB;

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0xB76B220", Offset = "0xB769E20", VA = "0x18B76B220")]
		public void Add(KHR_animation_pointer anim)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0xB76B2D0", Offset = "0xB769ED0", VA = "0x18B76B2D0")]
		public void FQHBBPBIFYY(GLTFSceneExporter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0xB76BC90", Offset = "0xB76A890", VA = "0x18B76BC90")]
		public NYYAONCBFDF()
		{
		}
	}
}
namespace UnityGLTF.JsonPointer
{
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public interface VTPBJIBSSFS
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool KFMVZJRJVRB(object a, string b);
	}
}
namespace UnityGLTF.Cache
{
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	public struct AnimationSamplerCacheData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public LOWENHEWMHZ Input;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public LOWENHEWMHZ Output;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public InterpolationType Interpolation;
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public class YHGZCDIUCBS
	{
		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		public AnimationClip BIPHGDNUQNJ
		{
			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2FC0", VA = "0x180CF43C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		public AnimationSamplerCacheData[] XUWGDFZEZQF
		{
			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A10", Offset = "0xCF0610", VA = "0x180CF1A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0xB774610", Offset = "0xB773210", VA = "0x18B774610")]
		public YHGZCDIUCBS(int a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public class PLNMMITZMLE : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		public Stream[] LEMTMEUFOUF
		{
			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2FC0", VA = "0x180CF43C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		public Texture2D[] DHHPJCTCIZT
		{
			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A10", Offset = "0xCF0610", VA = "0x180CF1A10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D1")]
		public Texture2D[] TUKRZCZAREO
		{
			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0xCF1770", Offset = "0xCF0370", VA = "0x180CF1770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		public UWJACFAPKUP[] BOIWNVRZTWP
		{
			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2F50", VA = "0x180CF4350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0xCF1780", Offset = "0xCF0380", VA = "0x180CF1780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		public TKAHDGDOFHP[] EXZSKAKSIPT
		{
			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3820", VA = "0x180CF4C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0xCF64C0", Offset = "0xCF50C0", VA = "0x180CF64C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		public TJELPNODSRG[] EQBKEXYEAVW
		{
			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0xCF4300", Offset = "0xCF2F00", VA = "0x180CF4300")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0xCF4530", Offset = "0xCF3130", VA = "0x180CF4530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		public FUDUXAGLBER[] VIYRFTOMUDX
		{
			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0xCF43A0", Offset = "0xCF2FA0", VA = "0x180CF43A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0xCF4370", Offset = "0xCF2F70", VA = "0x180CF4370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		public BPRBDHLKYOI[] VKBECPCXGMG
		{
			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0xCF42E0", Offset = "0xCF2EE0", VA = "0x180CF42E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0xCF4510", Offset = "0xCF3110", VA = "0x180CF4510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public YHGZCDIUCBS[] QOSKELMEXUI
		{
			[Cpp2IlInjected.Token(Token = "0x60004C2")]
			[Cpp2IlInjected.Address(RVA = "0xCEE120", Offset = "0xCECD20", VA = "0x180CEE120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C3")]
			[Cpp2IlInjected.Address(RVA = "0xCEE170", Offset = "0xCECD70", VA = "0x180CEE170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		public GameObject[] FPIQCJTDBPU
		{
			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0xCEE150", Offset = "0xCECD50", VA = "0x180CEE150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C5")]
			[Cpp2IlInjected.Address(RVA = "0xCEE160", Offset = "0xCECD60", VA = "0x180CEE160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0xB76C150", Offset = "0xB76AD50", VA = "0x18B76C150")]
		public PLNMMITZMLE(TBEADDWHLOJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0xB76C040", Offset = "0xB76AC40", VA = "0x18B76C040", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public class TJELPNODSRG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		public uint PQIGCOGSZOS
		{
			[Cpp2IlInjected.Token(Token = "0x60004C8")]
			[Cpp2IlInjected.Address(RVA = "0xCEE110", Offset = "0xCECD10", VA = "0x180CEE110")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A40", Offset = "0xCF0640", VA = "0x180CF1A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		public Stream JGSABVZJAAI
		{
			[Cpp2IlInjected.Token(Token = "0x60004CA")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004CB")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A10", Offset = "0xCF0610", VA = "0x180CF1A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		public NativeArray<byte> OMOFQZYQJPA
		{
			[Cpp2IlInjected.Token(Token = "0x60004CC")]
			[Cpp2IlInjected.Address(RVA = "0xED3CD0", Offset = "0xED28D0", VA = "0x180ED3CD0")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x60004CD")]
			[Cpp2IlInjected.Address(RVA = "0xFBA790", Offset = "0xFB9390", VA = "0x180FBA790")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x8754910", Offset = "0x8753510", VA = "0x188754910", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public TJELPNODSRG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	internal static class BEZTXAAOZFO
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0xF86770", Offset = "0xF85370", VA = "0x180F86770")]
		public static bool IFUIASENDHU(UnityEngine.Object a, string b, [Out] byte[] c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		public static void PUOLYDZHFTM(UnityEngine.Object a, string b, byte[] c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	public class TKAHDGDOFHP : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		public Material ULRKAFHJYHC
		{
			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2FC0", VA = "0x180CF43C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		public Material TWNEPFRPJJT
		{
			[Cpp2IlInjected.Token(Token = "0x60004D4")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A10", Offset = "0xCF0610", VA = "0x180CF1A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		public AHICOKAOCWI AHICOKAOCWI
		{
			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0xCF1770", Offset = "0xCF0370", VA = "0x180CF1770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0xB76FBD0", Offset = "0xB76E7D0", VA = "0x18B76FBD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public TKAHDGDOFHP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public class FUDUXAGLBER : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		public class SXMFKSMEIGF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			public bool VZLYHGUXCCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000429")]
			public Dictionary<string, LOWENHEWMHZ> RCXURBHMGLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042A")]
			public List<Dictionary<string, LOWENHEWMHZ>> FRROUIGHYTI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			public Dictionary<string, (LOWENHEWMHZ sparseIndices, LOWENHEWMHZ sparseValues)> JFBDBNPMKWA;

			[Cpp2IlInjected.Token(Token = "0x60004DD")]
			[Cpp2IlInjected.Address(RVA = "0xB76FAB0", Offset = "0xB76E6B0", VA = "0x18B76FAB0")]
			public SXMFKSMEIGF()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public List<SXMFKSMEIGF> WVMDHJGPZBA;

		[Cpp2IlInjected.Token(Token = "0x170001DF")]
		public Mesh RXEFAFCQRIQ
		{
			[Cpp2IlInjected.Token(Token = "0x60004D9")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004DA")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A10", Offset = "0xCF0610", VA = "0x180CF1A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0xB767050", Offset = "0xB765C50", VA = "0x18B767050", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0xB7670F0", Offset = "0xB765CF0", VA = "0x18B7670F0")]
		public FUDUXAGLBER()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	public class BYPLHFQGXQB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private bool BWOGMKROTFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private int NVRGLZMATDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private readonly object PXCXJSKOUOS;

		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		public FUDUXAGLBER[] VIYRFTOMUDX
		{
			[Cpp2IlInjected.Token(Token = "0x60004DE")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004DF")]
			[Cpp2IlInjected.Address(RVA = "0xCF1770", Offset = "0xCF0370", VA = "0x180CF1770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		public UnityEngine.Object[] MTPGQVWXALK
		{
			[Cpp2IlInjected.Token(Token = "0x60004E0")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2F50", VA = "0x180CF4350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E1")]
			[Cpp2IlInjected.Address(RVA = "0xCF1780", Offset = "0xCF0380", VA = "0x180CF1780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		public TKAHDGDOFHP[] EXZSKAKSIPT
		{
			[Cpp2IlInjected.Token(Token = "0x60004E2")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3820", VA = "0x180CF4C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E3")]
			[Cpp2IlInjected.Address(RVA = "0xCF64C0", Offset = "0xCF50C0", VA = "0x180CF64C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		public UWJACFAPKUP[] BOIWNVRZTWP
		{
			[Cpp2IlInjected.Token(Token = "0x60004E4")]
			[Cpp2IlInjected.Address(RVA = "0xCF4300", Offset = "0xCF2F00", VA = "0x180CF4300")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E5")]
			[Cpp2IlInjected.Address(RVA = "0xCF4530", Offset = "0xCF3130", VA = "0x180CF4530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		public YHGZCDIUCBS[] QOSKELMEXUI
		{
			[Cpp2IlInjected.Token(Token = "0x60004E6")]
			[Cpp2IlInjected.Address(RVA = "0xCF43A0", Offset = "0xCF2FA0", VA = "0x180CF43A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E7")]
			[Cpp2IlInjected.Address(RVA = "0xCF4370", Offset = "0xCF2F70", VA = "0x180CF4370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		public Texture2D[] DHHPJCTCIZT
		{
			[Cpp2IlInjected.Token(Token = "0x60004E8")]
			[Cpp2IlInjected.Address(RVA = "0xCF42E0", Offset = "0xCF2EE0", VA = "0x180CF42E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E9")]
			[Cpp2IlInjected.Address(RVA = "0xCF4510", Offset = "0xCF3110", VA = "0x180CF4510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0xB765E60", Offset = "0xB764A60", VA = "0x18B765E60")]
		public BYPLHFQGXQB(TKAHDGDOFHP[] a, FUDUXAGLBER[] b, UWJACFAPKUP[] c, Texture2D[] d, YHGZCDIUCBS[] e, UnityEngine.Object[] f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0xB765840", Offset = "0xB764440", VA = "0x18B765840")]
		public void AVASRZOUKKY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0xB765920", Offset = "0xB764520", VA = "0x18B765920")]
		public void PLTXDIVRCMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0xB765A70", Offset = "0xB764670", VA = "0x18B765A70")]
		private void QMRBKLOYOAE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public class UWJACFAPKUP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public JQEEIHSQRHG SBEABRIFQVM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public Texture2D DPNAWKZJIJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public bool YJGGVMYJFYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public bool XTDOUWLKYHV;

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0xB771550", Offset = "0xB770150", VA = "0x18B771550", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public UWJACFAPKUP()
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
