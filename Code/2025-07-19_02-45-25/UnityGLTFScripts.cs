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
using UnityGLTF;
using UnityGLTF.Plugins;
using UnityGLTF.Timeline;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityGLTF
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class AsyncCoroutineHelper : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[CompilerGenerated]
		private struct GHGFLCCDPFL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public AsyncCoroutineHelper <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9C51340", Offset = "0x9C50340", VA = "0x189C51340", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9C51530", Offset = "0x9C50530", VA = "0x189C51530", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class OCDEDJFIFCM : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public AsyncCoroutineHelper <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA5F480", Offset = "0xA5E480", VA = "0x180A5F480")]
			[DebuggerHidden]
			public OCDEDJFIFCM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9C626B0", Offset = "0x9C616B0", VA = "0x189C626B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9C62730", Offset = "0x9C61730", VA = "0x189C62730", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public float BudgetPerFrameInSeconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private WaitForEndOfFrame AHMANINNIFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private float JHPKBGFGOLJ;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9C4F610", Offset = "0x9C4E610", VA = "0x189C4F610")]
		[AsyncStateMachine(typeof(GHGFLCCDPFL))]
		public Task YieldOnTimeout()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9C4F580", Offset = "0x9C4E580", VA = "0x189C4F580")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9C4F500", Offset = "0x9C4E500", VA = "0x189C4F500")]
		[IteratorStateMachine(typeof(OCDEDJFIFCM))]
		private IEnumerator KMKAIFGFGKG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9C4F6E0", Offset = "0x9C4E6E0", VA = "0x189C4F6E0")]
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
		private struct GGGBBJOHMNK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public GLTFComponent <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private object <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x9C50E50", Offset = "0x9C4FE50", VA = "0x189C50E50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xAB7210", Offset = "0xAB6210", VA = "0x180AB7210", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private struct AOLFJMDINKD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public GLTFComponent <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private OAFJGCDIIED <importOptions>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private OBGDAHNJGCJ <sceneImporter>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9C4E7A0", Offset = "0x9C4D7A0", VA = "0x189C4E7A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x9C4F4A0", Offset = "0x9C4E4A0", VA = "0x189C4F4A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public string GLTFUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public bool Multithreaded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[FormerlySerializedAs("AppendStreamingAssets")]
		public bool LoadFromStreamingAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public bool PlayAnimationOnLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[Tooltip("Hide the scene object during load, then activate it when complete")]
		public bool HideSceneObjDuringLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public ImporterFactory Factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public UnityAction onLoadComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public bool loadOnStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private int RetryCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private float RetryTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int MIHMEJECKOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int MaximumLod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int Timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public OBGDAHNJGCJ.HNALOHEOPDK Collider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private Shader shaderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[Header("Import Settings")]
		public LOKFCOCJLEC TextureCompression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CLABBLDHKNF ImportNormals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CLABBLDHKNF ImportTangents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public bool SwapUVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[Tooltip("Blend shape frame weight import multiplier. Default is 1. For compatibility with some FBX animations you may need to use 100.")]
		public BlendShapeFrameWeightSetting blendShapeFrameWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[Tooltip("When enabled, the CPU copy of the mesh will be kept in memory after the mesh has been uploaded to the GPU. This is useful if you want to modify the mesh at runtime.")]
		public bool KeepCPUCopyOfMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Tooltip("When enabled, the CPU copy of the texture will be kept in memory after the texture has been uploaded to the GPU. This is useful if you want to modify the texture at runtime.")]
		public bool KeepCPUCopyOfTexture;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IEnumerable<Animation> GGONAPFHINC
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA68420", Offset = "0xA67420", VA = "0x180A68420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public GameObject MLDKLOEIPFM
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA63190", Offset = "0xA62190", VA = "0x180A63190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA631F0", Offset = "0xA621F0", VA = "0x180A631F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Shader NBIGDBIPKNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xA63200", Offset = "0xA62200", VA = "0x180A63200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x9C51870", Offset = "0x9C50870", VA = "0x189C51870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9C51750", Offset = "0x9C50750", VA = "0x189C51750")]
		[AsyncStateMachine(typeof(GGGBBJOHMNK))]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9C51680", Offset = "0x9C50680", VA = "0x189C51680")]
		[AsyncStateMachine(typeof(AOLFJMDINKD))]
		public Task Load()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9C51590", Offset = "0x9C50590", VA = "0x189C51590")]
		public void ApplyOverrideShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xFF5110", Offset = "0xFF4110", VA = "0x180FF5110")]
		private void DCOIOLANDPM(GameObject PGIOEBKALDP, ExceptionDispatchInfo EBAPKKNMLPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9C51800", Offset = "0x9C50800", VA = "0x189C51800")]
		public GLTFComponent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class GLTFRecorderComponent : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class ELAJBFIPAKE : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public GLTFRecorderComponent <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xA5F480", Offset = "0xA5E480", VA = "0x180A5F480")]
			[DebuggerHidden]
			public ELAJBFIPAKE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9C50B60", Offset = "0x9C4FB60", VA = "0x189C50B60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x9C50C30", Offset = "0x9C4FC30", VA = "0x189C50C30", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public string outputFile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Transform exportRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public bool recordBlendShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public bool recordRootInWorldSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public bool recordAnimationPointer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public InputAction recordingKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		protected GILOKJEMKCP BOKMFDOBLBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public UnityEvent recordingStarted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public UnityEvent<string> recordingEnded;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool DKCNHLEJKCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9C520C0", Offset = "0x9C510C0", VA = "0x189C520C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private double BBJENMOHHHG
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x9C51A50", Offset = "0x9C50A50", VA = "0x189C51A50")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9C51B50", Offset = "0x9C50B50", VA = "0x189C51B50", Slot = "4")]
		[ContextMenu("Start Recording")]
		public virtual void StartRecording()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9C51EF0", Offset = "0x9C50EF0", VA = "0x189C51EF0", Slot = "5")]
		[ContextMenu("Stop Recording")]
		public virtual void StopRecording()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9C518A0", Offset = "0x9C508A0", VA = "0x189C518A0")]
		private void AKIHCHFKOLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9C51E60", Offset = "0x9C50E60", VA = "0x189C51E60")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9C51B30", Offset = "0x9C50B30", VA = "0x189C51B30")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9C51AE0", Offset = "0x9C50AE0", VA = "0x189C51AE0", Slot = "6")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9C51A00", Offset = "0x9C50A00", VA = "0x189C51A00", Slot = "7")]
		protected virtual void DHHFGPJNEHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9C51A60", Offset = "0x9C50A60", VA = "0x189C51A60")]
		[IteratorStateMachine(typeof(ELAJBFIPAKE))]
		private IEnumerator NCHLGPKDNKD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9C51FF0", Offset = "0x9C50FF0", VA = "0x189C51FF0")]
		public GLTFRecorderComponent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9C518A0", Offset = "0x9C508A0", VA = "0x189C518A0")]
		[CompilerGenerated]
		private void NKFEBCEMDMM(InputAction.CallbackContext CIABMLDDFBB)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class DBPHECMOGDF
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal class MJPBHONOALD : GMHJHFOKIMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly DBPHECMOGDF ENOMPJBJNPL;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA8B7C0", Offset = "0xA8A7C0", VA = "0x180A8B7C0")]
		internal MJPBHONOALD(DBPHECMOGDF IEGLIFIOOBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9C55280", Offset = "0x9C54280", VA = "0x189C55280", Slot = "4")]
		public override void AMJBAOFMAAI(EEJGCGOJGCD LNCGGHOFHBA, CNIIHPEFGGP HPAACAMAKIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9C55510", Offset = "0x9C54510", VA = "0x189C55510", Slot = "5")]
		public override void OOPHHNDAEGJ(EEJGCGOJGCD LNCGGHOFHBA, CNIIHPEFGGP HPAACAMAKIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9C55450", Offset = "0x9C54450", VA = "0x189C55450", Slot = "8")]
		public override void GLFMIBKLNCM(EEJGCGOJGCD LNCGGHOFHBA, CNIIHPEFGGP HPAACAMAKIF, Transform PLPGMCABFBF, EOEJDHNLIOH ABOLKPCCJOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9C55300", Offset = "0x9C54300", VA = "0x189C55300", Slot = "9")]
		public override bool GCMNDLLJCDH(EEJGCGOJGCD LNCGGHOFHBA, CNIIHPEFGGP HPAACAMAKIF, Material JNBIMACAHOC, HLAGMJEKLKG MPDMBPBHNNK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9C55490", Offset = "0x9C54490", VA = "0x189C55490", Slot = "10")]
		public override void MBFLKCEGKKK(EEJGCGOJGCD LNCGGHOFHBA, CNIIHPEFGGP HPAACAMAKIF, Material JNBIMACAHOC, HLAGMJEKLKG MPDMBPBHNNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9C554D0", Offset = "0x9C544D0", VA = "0x189C554D0", Slot = "11")]
		public override void NHNPHGCBMID(EEJGCGOJGCD LNCGGHOFHBA, EEJGCGOJGCD.HGNPPBKLOMB GHHJBAFAEIA, string CFHCCHPAJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9C55550", Offset = "0x9C54550", VA = "0x189C55550", Slot = "12")]
		public override void PEMGEGHHNJB(EEJGCGOJGCD LNCGGHOFHBA, EEJGCGOJGCD.HGNPPBKLOMB GHHJBAFAEIA, int HLGKMAPOEBE, JPFBMCKMIAL BNBNLOFPBLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9C55410", Offset = "0x9C54410", VA = "0x189C55410", Slot = "13")]
		public override void GDEFIHGNEGE(EEJGCGOJGCD LNCGGHOFHBA, Mesh BFBFJIKLAEJ, OHJGEJHMLLK CIMBBBAALLD, int HLGKMAPOEBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9C552C0", Offset = "0x9C542C0", VA = "0x189C552C0", Slot = "14")]
		public override void DCHKIEJFDBF(EEJGCGOJGCD LNCGGHOFHBA, Mesh BFBFJIKLAEJ, IHBCEMMPKLA EPJKFKKONHF, int HLGKMAPOEBE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public bool LEHAGPEOIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public LayerMask MDIAIPLGNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public ILogger NDOPOKDOPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal readonly GLTFSettings KGDNAKPKMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public EEJGCGOJGCD.BPBJIEGCHLP NFFHKAJFHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public EEJGCGOJGCD.LDDPGKEDIGL OOPHHNDAEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public EEJGCGOJGCD.OLFEDAIJJDI AMJBAOFMAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public EEJGCGOJGCD.GBAMPEGKOIP GLFMIBKLNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public EEJGCGOJGCD.JABECLCEEOD GCMNDLLJCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public EEJGCGOJGCD.FKCDGNHHFEN MBFLKCEGKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public EEJGCGOJGCD.JIOHNEDOMOL NHNPHGCBMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public EEJGCGOJGCD.KHCEMLJGMMK PEMGEGHHNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public EEJGCGOJGCD.MGHNLHBPBIL GDEFIHGNEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public EEJGCGOJGCD.FPKPLBFHDIA DCHKIEJFDBF;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x9C4FBF0", Offset = "0x9C4EBF0", VA = "0x189C4FBF0")]
	public DBPHECMOGDF(GLTFSettings KGDNAKPKMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x9C4FB80", Offset = "0x9C4EB80", VA = "0x189C4FB80")]
	internal GMHJHFOKIMI DJEJJBDMABJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class EEJGCGOJGCD
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate string BPBJIEGCHLP(Texture GHHJBAFAEIA);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public delegate void OLFEDAIJJDI(EEJGCGOJGCD LNCGGHOFHBA, CNIIHPEFGGP HPAACAMAKIF);

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate void LDDPGKEDIGL(EEJGCGOJGCD LNCGGHOFHBA, CNIIHPEFGGP HPAACAMAKIF);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate void GBAMPEGKOIP(EEJGCGOJGCD LNCGGHOFHBA, CNIIHPEFGGP HPAACAMAKIF, Transform PLPGMCABFBF, EOEJDHNLIOH ABOLKPCCJOL);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate bool JABECLCEEOD(EEJGCGOJGCD LNCGGHOFHBA, CNIIHPEFGGP HPAACAMAKIF, Material JNBIMACAHOC, HLAGMJEKLKG MPDMBPBHNNK);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void FKCDGNHHFEN(EEJGCGOJGCD LNCGGHOFHBA, CNIIHPEFGGP HPAACAMAKIF, Material JNBIMACAHOC, HLAGMJEKLKG MPDMBPBHNNK);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void JIOHNEDOMOL(EEJGCGOJGCD LNCGGHOFHBA, HGNPPBKLOMB GHHJBAFAEIA, string CFHCCHPAJIL);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public delegate void KHCEMLJGMMK(EEJGCGOJGCD LNCGGHOFHBA, HGNPPBKLOMB GHHJBAFAEIA, int HLGKMAPOEBE, JPFBMCKMIAL BNBNLOFPBLB);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public delegate void MGHNLHBPBIL(EEJGCGOJGCD LNCGGHOFHBA, Mesh BFBFJIKLAEJ, OHJGEJHMLLK CIMBBBAALLD, int HLGKMAPOEBE);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate void FPKPLBFHDIA(EEJGCGOJGCD LNCGGHOFHBA, Mesh BFBFJIKLAEJ, IHBCEMMPKLA EPJKFKKONHF, int HLGKMAPOEBE);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class LNOOHCJHHFE : GMHJHFOKIMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9C55200", Offset = "0x9C54200", VA = "0x189C55200", Slot = "5")]
		public override void OOPHHNDAEGJ(EEJGCGOJGCD LNCGGHOFHBA, CNIIHPEFGGP HPAACAMAKIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9C54EE0", Offset = "0x9C53EE0", VA = "0x189C54EE0", Slot = "4")]
		public override void AMJBAOFMAAI(EEJGCGOJGCD LNCGGHOFHBA, CNIIHPEFGGP HPAACAMAKIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9C550C0", Offset = "0x9C540C0", VA = "0x189C550C0", Slot = "8")]
		public override void GLFMIBKLNCM(EEJGCGOJGCD LNCGGHOFHBA, CNIIHPEFGGP HPAACAMAKIF, Transform PLPGMCABFBF, EOEJDHNLIOH ABOLKPCCJOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9C54F60", Offset = "0x9C53F60", VA = "0x189C54F60", Slot = "9")]
		public override bool GCMNDLLJCDH(EEJGCGOJGCD LNCGGHOFHBA, CNIIHPEFGGP HPAACAMAKIF, Material JNBIMACAHOC, HLAGMJEKLKG MPDMBPBHNNK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9C55160", Offset = "0x9C54160", VA = "0x189C55160", Slot = "10")]
		public override void MBFLKCEGKKK(EEJGCGOJGCD LNCGGHOFHBA, CNIIHPEFGGP HPAACAMAKIF, Material JNBIMACAHOC, HLAGMJEKLKG MPDMBPBHNNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
		public LNOOHCJHHFE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct BKMDGBHGAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public enum BPEKJBMPDDC
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
		public enum OOJDINCBILB
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
		public bool LNMKMKKFLEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public BPEKJBMPDDC OOLGGDPJIKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public OOJDINCBILB JKKEIMJHLDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool ABGBDBJNNKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public float IMKBCEHLEKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public float NMBODLFNIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public float IPGIIJCNMOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public float PAKGPNGJOPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public float POPGFBHGCBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public float PKPGCJJOCFP;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x9C4FA50", Offset = "0x9C4EA50", VA = "0x189C4FA50")]
		public BKMDGBHGAAJ(BKMDGBHGAAJ MKOOPFGGHLN)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9C4FA10", Offset = "0x9C4EA10", VA = "0x189C4FA10")]
		public static bool PHGIAKEDBEK(BKMDGBHGAAJ MLCJFBKFHOP, BKMDGBHGAAJ FPNPAOBAPAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9C4F760", Offset = "0x9C4E760", VA = "0x189C4F760")]
		public bool AENKCNBBPNI(BKMDGBHGAAJ EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9C4F840", Offset = "0x9C4E840", VA = "0x189C4F840", Slot = "0")]
		public override bool Equals(object PGIOEBKALDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9C4F8F0", Offset = "0x9C4E8F0", VA = "0x189C4F8F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private struct KPGCEDEPMBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Texture2D GHHJBAFAEIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public BKMDGBHGAAJ ONPHHPJBBIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public string JAJGDKKKOJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public bool FBLCPLNOPNH;
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private struct AGHBBONMHNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Stream PMBDKJADIJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public string OPLHHODACDF;
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct HGNPPBKLOMB : IEquatable<HGNPPBKLOMB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Texture AHAKDEILDPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public int BGHGFIHAEMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public BKMDGBHGAAJ HJGIJMKJBDK;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x9C52580", Offset = "0x9C51580", VA = "0x189C52580")]
		public int ADKLKJGNOCJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9C52840", Offset = "0x9C51840", VA = "0x189C52840")]
		public int GPOPEONJOJA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x9C52920", Offset = "0x9C51920", VA = "0x189C52920")]
		public HGNPPBKLOMB(Texture BNBNLOFPBLB, string CFHCCHPAJIL, EEJGCGOJGCD LNCGGHOFHBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9C529D0", Offset = "0x9C519D0", VA = "0x189C529D0")]
		public HGNPPBKLOMB(Texture BNBNLOFPBLB, BKMDGBHGAAJ KJNCMJAKFGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9C52680", Offset = "0x9C51680", VA = "0x189C52680", Slot = "4")]
		public bool Equals(HGNPPBKLOMB EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9C525C0", Offset = "0x9C515C0", VA = "0x189C525C0", Slot = "0")]
		public override bool Equals(object PGIOEBKALDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9C52880", Offset = "0x9C51880", VA = "0x189C52880", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct HNEHCIOKMAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Mesh FKGCABGKIOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Material[] LJBMPCFDMJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public SkinnedMeshRenderer FJCHPMEKLGO;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x9C52A60", Offset = "0x9C51A60", VA = "0x189C52A60")]
		public bool AENKCNBBPNI(HNEHCIOKMAO EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9C52BD0", Offset = "0x9C51BD0", VA = "0x189C52BD0", Slot = "0")]
		public override bool Equals(object PGIOEBKALDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x9C52C80", Offset = "0x9C51C80", VA = "0x189C52C80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private struct NKMLGDPJDDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public NEDBAGNCLCG PDLAMHPMOEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public NEDBAGNCLCG MOILJLBMLOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public NEDBAGNCLCG DHIDBJDDFIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public NEDBAGNCLCG NCLLCPAKGNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public NEDBAGNCLCG GJEFAAOEPJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public NEDBAGNCLCG OOKMOEKHKJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public NEDBAGNCLCG CMNOOAMGNMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public NEDBAGNCLCG GHKEFEEIHNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public NEDBAGNCLCG HPCIKBGBGJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public Dictionary<int, OHJGEJHMLLK> NLPKMHDAJEC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct LIGKEAPNNNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public List<Dictionary<string, NEDBAGNCLCG>> FCIMPODEJPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public List<double> CDEGIMENJBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public List<string> PFDGHOBFJBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		internal SkinnedMeshRenderer OEPBLLFHGLG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct AHEJPHPEHLB : IEquatable<AHEJPHPEHLB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly TextureWrapMode MJFHKDAAJIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly FilterMode JKDIBBKJAHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly bool DKLLBJIDHLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly bool HKOPKLCFJLJ;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool IOEOGDIIEND
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xE50950", Offset = "0xE4F950", VA = "0x180E50950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool BDDFAGEGKNA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x71B0740", Offset = "0x71AF740", VA = "0x1871B0740")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9C4E710", Offset = "0x9C4D710", VA = "0x189C4E710")]
		public AHEJPHPEHLB(Texture GHHJBAFAEIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9C4E630", Offset = "0x9C4D630", VA = "0x189C4E630", Slot = "4")]
		public bool Equals(AHEJPHPEHLB EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9C4E570", Offset = "0x9C4D570", VA = "0x189C4E570", Slot = "0")]
		public override bool Equals(object PGIOEBKALDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9C4E660", Offset = "0x9C4D660", VA = "0x189C4E660", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class LGLGMLFOCND : IEnumerable<(int, OHJGEJHMLLK)>, IEnumerable, IEnumerator<(int, OHJGEJHMLLK)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private (int subMeshIndex, OHJGEJHMLLK prim) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public EEJGCGOJGCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private Mesh mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Mesh <>3__mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private Dictionary<int, OHJGEJHMLLK>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private (int, OHJGEJHMLLK) System.Collections.Generic.IEnumerator<(System.Int32subMeshIndex,GLTF.Schema.MeshPrimitiveprim)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xD36D60", Offset = "0xD35D60", VA = "0x180D36D60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((int, OHJGEJHMLLK));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x9C54E00", Offset = "0x9C53E00", VA = "0x189C54E00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x28D7E10", Offset = "0x28D6E10", VA = "0x1828D7E10")]
		[DebuggerHidden]
		public LGLGMLFOCND(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9C54E50", Offset = "0x9C53E50", VA = "0x189C54E50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9C54A20", Offset = "0x9C53A20", VA = "0x189C54A20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9C549D0", Offset = "0x9C539D0", VA = "0x189C549D0")]
		private void FEADENMJGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9C54DB0", Offset = "0x9C53DB0", VA = "0x189C54DB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9C54CF0", Offset = "0x9C53CF0", VA = "0x189C54CF0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(int, OHJGEJHMLLK)> System.Collections.Generic.IEnumerable<(System.Int32subMeshIndex,GLTF.Schema.MeshPrimitiveprim)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9C54CF0", Offset = "0x9C53CF0", VA = "0x189C54CF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class EMJILJFEOCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public bool convertToLinearColor;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public EMJILJFEOCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x9C50C80", Offset = "0x9C4FC80", VA = "0x189C50C80")]
		internal Color HKBMEODNLII(object e)
		{
			return default(Color);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class ECGMFLBDBFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public float multiplier;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public ECGMFLBDBFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9C50720", Offset = "0x9C4F720", VA = "0x189C50720")]
		internal float JFKNNHBCJPC(object e)
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static ILogger DECKNFGLCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private List<GMHJHFOKIMI> DNHMANJCOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private Transform[] MFKCNCGHLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private CNIIHPEFGGP EAGMJMHJCOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private GCKEGEHONDD LGAMGDPMNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private MBLBIABCNPD DCMIENOBOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private List<KPGCEDEPMBO> FFCFDIILNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private HashSet<string> GJOBDNPMNJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private List<AGHBBONMHNF> GDJHGBJDKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private HashSet<string> LEIPADNIPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<HGNPPBKLOMB> NJIBDAPMCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private Dictionary<int, int> OFOCEMBHCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private bool KMPHHGDKGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private Dictionary<int, int> IHICDPNGGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private List<Transform> KPJJOCEIBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private int PJJBGBLAIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private DBPHECMOGDF ENOMPJBJNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private Material BPNGPKAIINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private Material IDFFPCNNMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private Material LHJMBFMEMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private bool ACKCLCJKPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<HNEHCIOKMAO, LBGAIEAAEEI> CKDPFNKLLNO;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static ProfilerMarker KKNODOCMGLJ;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static ProfilerMarker MHFCOLCBGAM;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static ProfilerMarker IIIJMDNEBPJ;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static ProfilerMarker KFFKCBGBEMG;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static ProfilerMarker FMFHCHNHIFK;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static ProfilerMarker HKDCBEBNFNF;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static ProfilerMarker LGIIDLPMDHG;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static ProfilerMarker NCBHOAPKLPM;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static ProfilerMarker PNNFGPALAAM;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static ProfilerMarker LKGCPIOJPKI;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static ProfilerMarker AEFLLDDNMEJ;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static ProfilerMarker KJOMDCGIINN;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static ProfilerMarker CJDDDKOCMCN;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static ProfilerMarker DJHHGBDEDMB;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static ProfilerMarker BGGOAMMLHNL;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static ProfilerMarker LDMPOAHDDMA;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static ProfilerMarker ALJFOEOOKLJ;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static ProfilerMarker GDAICHLMAPC;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static ProfilerMarker LALOKMGGKNK;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static ProfilerMarker DFKJCIKNEBJ;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static ProfilerMarker JPBHDJPFGHC;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static ProfilerMarker NMLOBFGMOAC;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static ProfilerMarker ONFJBLEJPGG;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static ProfilerMarker GMEEHGEJFMF;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static ProfilerMarker BHNEPGPKNLI;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static ProfilerMarker LOKBDNENCJJ;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static ProfilerMarker LMFPBFDHGCO;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static ProfilerMarker PLOJEODEJOK;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private static ProfilerMarker LMHNFEHOLAA;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static ProfilerMarker HLOCILAFKEB;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static ProfilerMarker IBBKDNEGJAC;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static ProfilerMarker DEKPHFACEIL;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static ProfilerMarker OHFMOPDGLAJ;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static ProfilerMarker EAMCEAGAFEI;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private static ProfilerMarker KGBCKHHNEMP;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static ProfilerMarker HBJPLKBFHCO;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static ProfilerMarker BOJBENNNIDG;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static ProfilerMarker PGKAGLOOLOE;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static ProfilerMarker FIJFPCPEFAF;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private static ProfilerMarker KJBINFMKOIO;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static ProfilerMarker BGOKOEMOBEB;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static ProfilerMarker KLDDPCNGMOE;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static ProfilerMarker EMLBNIMEAHN;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static ProfilerMarker OCHNJOCMELG;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private static ProfilerMarker CEFCNPCLKEF;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static ProfilerMarker KAKCDKPPANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private global::NIKDAOMMPMO JCEJNOLCCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool? HCGJBBJCMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	internal readonly List<IGOJLJPNMOC> CEFDLABKMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly LDDEJGGJEJE DLHLLKLPMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Dictionary<int, int> OBIGKDCOMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Dictionary<int, int> NCHFOEMANLJ;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	[CompilerGenerated]
	private static OLFEDAIJJDI AMJBAOFMAAI;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[CompilerGenerated]
	private static LDDPGKEDIGL OOPHHNDAEGJ;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	[CompilerGenerated]
	private static GBAMPEGKOIP GLFMIBKLNCM;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[CompilerGenerated]
	private static JABECLCEEOD GCMNDLLJCDH;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[CompilerGenerated]
	private static FKCDGNHHFEN MBFLKCEGKKK;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static Material DNDFEEDFKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private HashSet<Material> MNLPLMOBAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly Dictionary<Mesh, NKMLGDPJDDF> HBPPAFOMPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly Dictionary<Mesh, LIGKEAPNNNG> DJIOJKOBAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly Dictionary<SkinnedMeshRenderer, List<double>> CJKKFPGNGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private List<Transform> HEBDFFAACJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Dictionary<SkinnedMeshRenderer, Mesh> FIJHKDPJMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Dictionary<AHEJPHPEHLB, int> GJPOPNCKLCB;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyList<Transform> PNKMEOMDNHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private GLTFSettings KGDNAKPKMMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9C458B0", Offset = "0x9C448B0", VA = "0x189C458B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private bool DMMNGEFLGFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9C46AE0", Offset = "0x9C45AE0", VA = "0x189C46AE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private bool HKENNLNGNLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9C3D410", Offset = "0x9C3C410", VA = "0x189C3D410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private bool BFNNMJOKJJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9C45710", Offset = "0x9C44710", VA = "0x189C45710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static Material PNHGLHMEJIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9C41AD0", Offset = "0x9C40AD0", VA = "0x189C41AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x9C31510", Offset = "0x9C30510", VA = "0x189C31510")]
	public BKMDGBHGAAJ AACJAGOJFBE(string CFHCCHPAJIL)
	{
		return default(BKMDGBHGAAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x9C487B0", Offset = "0x9C477B0", VA = "0x189C487B0")]
	private Material NPBAHAGKOPK(BKMDGBHGAAJ ONPHHPJBBIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x9C319D0", Offset = "0x9C309D0", VA = "0x189C319D0")]
	private static Material AECNNIKBBEI(Material JNBIMACAHOC, BKMDGBHGAAJ ONPHHPJBBIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x9C4CBC0", Offset = "0x9C4BBC0", VA = "0x189C4CBC0")]
	public EEJGCGOJGCD(Transform[] CMDDKINNEKH, DBPHECMOGDF IEGLIFIOOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x9C41060", Offset = "0x9C40060", VA = "0x189C41060")]
	public void KODCOKKKKIF(Stream PMBDKJADIJM, string CINCJCFMCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x9C39720", Offset = "0x9C38720", VA = "0x189C39720")]
	public void EFPCLLINDBD(string HLMOOHDFPCJ, bool DJJGGAPFNPI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x9C379D0", Offset = "0x9C369D0", VA = "0x189C379D0")]
	private bool DFMCPLAOEKI(Transform PLPGMCABFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x9C31FE0", Offset = "0x9C30FE0", VA = "0x189C31FE0")]
	private IIFDJPDOBGP AKCLJJNCILA(string HJLBILHBIIC, Transform[] NLJBKDBGAHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x9C37B70", Offset = "0x9C36B70", VA = "0x189C37B70")]
	private MBEFNBJNJKI DGJNBKMCNIB(Transform BEODPJANMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x9C36F60", Offset = "0x9C35F60", VA = "0x189C36F60")]
	private static bool CNEFPEAHOBI(GameObject GLGAAAMILBJ, bool PLCHFEHPDEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x9C36770", Offset = "0x9C35770", VA = "0x189C36770")]
	private void BOMHNLECHBB(Transform PLPGMCABFBF, [Out] GameObject[] CLNDMHNANGK, [Out] GameObject[] MDEHNELDPNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x9C398F0", Offset = "0x9C388F0", VA = "0x189C398F0")]
	private void EFPDFAOBCII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x9C34F50", Offset = "0x9C33F50", VA = "0x189C34F50")]
	public AKDMDGIIFHC BEFBCOHGKKL(CNIIHPEFGGP NKBKNNLLHKF, Material DMIFIIENBKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x9C36D10", Offset = "0x9C35D10", VA = "0x189C36D10")]
	public MOJEDEPNCBH CEEHFAOHAAJ(CNIIHPEFGGP NKBKNNLLHKF, HGNPPBKLOMB ONLOABMGLDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x9C4BE40", Offset = "0x9C4AE40", VA = "0x189C4BE40")]
	public PPNAHINGCNP PPCKNNJBEPE(CNIIHPEFGGP NKBKNNLLHKF, Texture AAGEBMKJBCE, BKMDGBHGAAJ ONPHHPJBBIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x9C454E0", Offset = "0x9C444E0", VA = "0x189C454E0")]
	private static void MAFFAINGPJL(Stream JMJJABEKOFI, BinaryWriter LLJAAOFGKGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x9C31F10", Offset = "0x9C30F10", VA = "0x189C31F10")]
	private static void AHPAMAEENNG(Stream PMBDKJADIJM, byte FPKKCMGKANK = 32, uint FJCBCIJMEEN = 4u)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x9C399F0", Offset = "0x9C389F0", VA = "0x189C399F0")]
	public static uint EHEJEJAHPPH(uint NCKJPNOIOIH, uint FKHOALAMODL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x9C3E740", Offset = "0x9C3D740", VA = "0x189C3E740")]
	private NEDBAGNCLCG IEGDEEAJFLP(Vector4[] CAJHHKCJGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x9C48890", Offset = "0x9C47890", VA = "0x189C48890")]
	private NEDBAGNCLCG OEBBHAIKFJC(Quaternion[] CAJHHKCJGAH, bool HNPADDPPLBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x9C42260", Offset = "0x9C41260", VA = "0x189C42260")]
	private NEDBAGNCLCG LFHBKHLEEKC(Matrix4x4[] CAJHHKCJGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x9C41D20", Offset = "0x9C40D20", VA = "0x189C41D20")]
	private NEDBAGNCLCG LFHBKHLEEKC(float[] CAJHHKCJGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x9C442A0", Offset = "0x9C432A0", VA = "0x189C442A0")]
	private NEDBAGNCLCG LFHBKHLEEKC(int[] CAJHHKCJGAH, bool GDPDNMGBDCL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x9C432D0", Offset = "0x9C422D0", VA = "0x189C432D0")]
	private NEDBAGNCLCG LFHBKHLEEKC(Vector2[] CAJHHKCJGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x9C449F0", Offset = "0x9C439F0", VA = "0x189C449F0")]
	private NEDBAGNCLCG LFHBKHLEEKC(Vector3[] CAJHHKCJGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x9C476E0", Offset = "0x9C466E0", VA = "0x189C476E0")]
	private NEDBAGNCLCG NJBGABMJPGF(NEDBAGNCLCG BGOPABAJIGA, Vector3[] PHFGKLDJGKP, Vector3[] CAJHHKCJGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x9C43960", Offset = "0x9C42960", VA = "0x189C43960")]
	private NEDBAGNCLCG LFHBKHLEEKC(Vector4[] CAJHHKCJGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x9C42700", Offset = "0x9C41700", VA = "0x189C42700")]
	private NEDBAGNCLCG LFHBKHLEEKC(Color[] CAJHHKCJGAH, bool EHNNEILANEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x9C40810", Offset = "0x9C3F810", VA = "0x189C40810")]
	private KHBMIMAHLLC JNBANFICJMI(uint EFOBAIMDCNL, uint PCJJMLKJJOD, uint OHMCLKEFCCB = 0u)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520")]
	public void DGDHBAOLPDL(Transform PLPGMCABFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x9C369D0", Offset = "0x9C359D0", VA = "0x189C369D0")]
	internal int CAEJPFLLFOP(object PGIOEBKALDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x9C32470", Offset = "0x9C31470", VA = "0x189C32470")]
	public int AKJHHMICFJP(Transform PLPGMCABFBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x9C36610", Offset = "0x9C35610", VA = "0x189C36610")]
	public int BNGKHDAEBEA(Material LAJKOJDAIOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x9C3DDF0", Offset = "0x9C3CDF0", VA = "0x189C3DDF0")]
	public int HFDKLIFLMHB(Light FFPAOHDOIJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x9C36EA0", Offset = "0x9C35EA0", VA = "0x189C36EA0")]
	public int CHLEJOONECL(Camera EAOFGOLNEIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x9C39690", Offset = "0x9C38690", VA = "0x189C39690")]
	[IteratorStateMachine(typeof(LGLGMLFOCND))]
	public IEnumerable<(int, OHJGEJHMLLK)> EFELIGFMNHN(Mesh BFBFJIKLAEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x9C36440", Offset = "0x9C35440", VA = "0x189C36440")]
	private static void BJGIFHJDIPM(Color JMJJABEKOFI, [Out] Color LLJAAOFGKGM, [Out] float KLMOGMOAEPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x9C3DEB0", Offset = "0x9C3CEB0", VA = "0x189C3DEB0")]
	private static void HFEAKPNCHJK(Vector4 JMJJABEKOFI, [Out] Vector2 AJNABLFIHCD, [Out] Vector2 MOAJDMPNBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x9C31D80", Offset = "0x9C30D80", VA = "0x189C31D80")]
	private bool AHNIMOPKNFA(object[] MFIJBPNIELL, int MLJMFELLMKK, int GGNMENNJDBK, int GLDKKKIJHKF, int JOFJIIAPAPI, int HHCMAIKEFIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x9C38E60", Offset = "0x9C37E60", VA = "0x189C38E60")]
	public void EDGJNEGJKDD(float[] JOBOINPBNOA, object[] NCIPNLHDHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x9C32530", Offset = "0x9C31530", VA = "0x189C32530")]
	public void ANJGGJGIPJL(UnityEngine.Object KPIKKFCLPGF, string JFNKBOFNMLM, PJMIPDFECKP BLIMBEMADDN, float[] JOBOINPBNOA, object[] NCIPNLHDHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x9C41980", Offset = "0x9C40980", VA = "0x189C41980")]
	private void LAKIAADBBIK(object KPIKKFCLPGF, string JFNKBOFNMLM, KJMJABOBJAC AOJAHPGAGPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x9C465D0", Offset = "0x9C455D0", VA = "0x189C465D0")]
	private FOFCLCKKLCM MMMBCJPCJLP(Camera DOFHIDGLHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x9C3F1C0", Offset = "0x9C3E1C0", VA = "0x189C3F1C0")]
	private GOBECCIKFHA JCCBKDJGOJM(Light ACIKPKBAMNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x9C492D0", Offset = "0x9C482D0", VA = "0x189C492D0")]
	public AKDMDGIIFHC OMCBAFKHDEA(Material DMIFIIENBKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x9C39AA0", Offset = "0x9C38AA0", VA = "0x189C39AA0")]
	private AKDMDGIIFHC EMLJCMAFCPC(Material DMIFIIENBKA, HLAGMJEKLKG JNBIMACAHOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x9C31810", Offset = "0x9C30810", VA = "0x189C31810")]
	private bool ACBMAPMMFOB(Material JNBIMACAHOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x9C46C00", Offset = "0x9C45C00", VA = "0x189C46C00")]
	private bool NDECHHEKLJG(Material JNBIMACAHOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x9C39980", Offset = "0x9C38980", VA = "0x189C39980")]
	private bool EGIMPKINGJJ(Material JNBIMACAHOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x9C4B9B0", Offset = "0x9C4A9B0", VA = "0x189C4B9B0")]
	private bool PBCPFOBPAMA(Material JNBIMACAHOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x9C366D0", Offset = "0x9C356D0", VA = "0x189C366D0")]
	private static bool BOMCEDIJGJN(Shader FIFMLGDAANB, string HJLBILHBIIC, ShaderPropertyType BJLNCBFOGNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x9C359F0", Offset = "0x9C349F0", VA = "0x189C359F0")]
	private void BICPPPAOBIB(NLGJBEIKJBH AEIDNFBDINH, Material LAJKOJDAIOK, string NIGLDFJNILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x9C452E0", Offset = "0x9C442E0", VA = "0x189C452E0")]
	public EMBMIABAJMP LODKCCKPIBK(Texture GHHJBAFAEIA, string CFHCCHPAJIL, Material JNBIMACAHOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9C455B0", Offset = "0x9C445B0", VA = "0x189C455B0")]
	private JPLNPENNDOH MEEDPJHEPCF(Texture GHHJBAFAEIA, string CFHCCHPAJIL, Material JNBIMACAHOC, [Optional] MOJEDEPNCBH DMPFBBIEFNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x9C39F60", Offset = "0x9C38F60", VA = "0x189C39F60")]
	public MNPGNDGBGFC GAPMPJONALC(Material JNBIMACAHOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x9C3F920", Offset = "0x9C3E920", VA = "0x189C3F920")]
	public void JICKOIAFJNC(HLAGMJEKLKG AEIDNFBDINH, Material JNBIMACAHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x9C40070", Offset = "0x9C3F070", VA = "0x189C40070")]
	private void JLMKNILNNOG(HLAGMJEKLKG JNBIMACAHOC, Material DMIFIIENBKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x9C4BA50", Offset = "0x9C4AA50", VA = "0x189C4BA50")]
	private AIHLDGEADEG PLCLMIAGACO(Material DMIFIIENBKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x9C34EC0", Offset = "0x9C33EC0", VA = "0x189C34EC0")]
	internal static void BDCOMCFLLED(Color COMANNNCING, [Out] Color EOLNLHCLMIL, [Out] float KLMOGMOAEPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x9C39DF0", Offset = "0x9C38DF0", VA = "0x189C39DF0")]
	public void GAKIFOIIODJ(EOEJDHNLIOH ABOLKPCCJOL, List<HNEHCIOKMAO> EKDKPEDFJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x9C3DFB0", Offset = "0x9C3CFB0", VA = "0x189C3DFB0")]
	private static List<HNEHCIOKMAO> IBCGJDMLALN(IEnumerable<GameObject> CLNDMHNANGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x9C37B30", Offset = "0x9C36B30", VA = "0x189C37B30")]
	public MBEFNBJNJKI DGJNBKMCNIB(GameObject GLGAAAMILBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x9C409A0", Offset = "0x9C3F9A0", VA = "0x189C409A0")]
	public LBGAIEAAEEI KJOAEGDDHGA(string HJLBILHBIIC, List<HNEHCIOKMAO> EKDKPEDFJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x9C3BF90", Offset = "0x9C3AF90", VA = "0x189C3BF90")]
	private OHJGEJHMLLK[] GFCPNEMKFBL(HNEHCIOKMAO PMABECGJGEE, IHBCEMMPKLA BFBFJIKLAEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x9C45140", Offset = "0x9C44140", VA = "0x189C45140")]
	private List<double> LOANCNGKDMI(SkinnedMeshRenderer CFNGLDDBAGO, Mesh EFGEPCOPEEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x9C46CC0", Offset = "0x9C45CC0", VA = "0x189C46CC0")]
	private void NIEMKPEDAJF(SkinnedMeshRenderer CFNGLDDBAGO, Mesh EFGEPCOPEEO, int FGDOIEAKPDM, OHJGEJHMLLK CIMBBBAALLD, IHBCEMMPKLA BFBFJIKLAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x9C3E720", Offset = "0x9C3D720", VA = "0x189C3E720")]
	private static bool IDLPONEIAML(OHJGEJHMLLK LDPCOANOBID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x9C31C70", Offset = "0x9C30C70", VA = "0x189C31C70")]
	private static CADDALLEFMK AFADKGBAFPC(MeshTopology BOILKKLPAKG)
	{
		return default(CADDALLEFMK);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x9C39DD0", Offset = "0x9C38DD0", VA = "0x189C39DD0")]
	private static bool FIANDCAALGP(Mesh BFBFJIKLAEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x9C3AED0", Offset = "0x9C39ED0", VA = "0x189C3AED0")]
	private void GCCGICFPCFG(Transform PLPGMCABFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x9C372E0", Offset = "0x9C362E0", VA = "0x189C372E0")]
	private Mesh DBKHGOHFIAG(GameObject GLGAAAMILBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x9C3F0C0", Offset = "0x9C3E0C0", VA = "0x189C3F0C0")]
	private Material[] IMHLODCFJHE(GameObject GLGAAAMILBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x9C4B820", Offset = "0x9C4A820", VA = "0x189C4B820")]
	private Vector4[] ONNOEDEJFLO(BoneWeight[] BBCCKJMLHFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x9C458D0", Offset = "0x9C448D0", VA = "0x189C458D0")]
	private Vector4[] MJPFKFOMMOP(BoneWeight[] BBCCKJMLHFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x9C3FE40", Offset = "0x9C3EE40", VA = "0x189C3FE40")]
	private string JIGPJNAJEAM(HashSet<string> KNGAGLHPBDN, string HJLBILHBIIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x9C371D0", Offset = "0x9C361D0", VA = "0x189C371D0")]
	public NLGJBEIKJBH DBFDFNEOHGI(Texture GHHJBAFAEIA, string CFHCCHPAJIL, [Optional] BKMDGBHGAAJ KJNCMJAKFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x9C46B10", Offset = "0x9C45B10", VA = "0x189C46B10")]
	public NLGJBEIKJBH NCLMKHLKONE(Material LAJKOJDAIOK, Texture GHHJBAFAEIA, string CFHCCHPAJIL, [Optional] BKMDGBHGAAJ KJNCMJAKFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x9C3D440", Offset = "0x9C3C440", VA = "0x189C3D440")]
	public MOJEDEPNCBH HCLBHNHMHCH(Texture ONLOABMGLDA, string CFHCCHPAJIL, [Optional] BKMDGBHGAAJ KJNCMJAKFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x9C38BB0", Offset = "0x9C37BB0", VA = "0x189C38BB0")]
	private string DGKPMHJACNO(Texture GHHJBAFAEIA, BKMDGBHGAAJ ONPHHPJBBIM, string CFHCCHPAJIL, [Out] bool FBKDAJEFHAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x9C350A0", Offset = "0x9C340A0", VA = "0x189C350A0")]
	private PPNAHINGCNP BFJPKHEHIOL(HGNPPBKLOMB AALHININOPP, string CFHCCHPAJIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x48E2060", Offset = "0x48E1060", VA = "0x1848E2060")]
	private bool EJMKAHNHAAB(BKMDGBHGAAJ ONPHHPJBBIM, Texture GHHJBAFAEIA, [Out] string AIPDNDCFPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530")]
	private byte[] CPANOEJDDHP(Texture GHHJBAFAEIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x9C39A10", Offset = "0x9C38A10", VA = "0x189C39A10")]
	private bool EMLBDADEPBP(Texture GDOPADGNKIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x9C3F040", Offset = "0x9C3E040", VA = "0x189C3F040")]
	private bool IIJILLKCHGD(string HDCLHHGFDJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x9C3DEE0", Offset = "0x9C3CEE0", VA = "0x189C3DEE0")]
	private bool HGMDHGELPPD(string HDCLHHGFDJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x9C45A20", Offset = "0x9C44A20", VA = "0x189C45A20")]
	private PPNAHINGCNP MLMGLECNHBL(HGNPPBKLOMB AALHININOPP, string CFHCCHPAJIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x9C37520", Offset = "0x9C36520", VA = "0x189C37520")]
	private HKGLOLALPMB DFALNKOMDNK(Texture GHHJBAFAEIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Flags]
public enum DOCEEAKBFKN
{
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	Meshes = 1,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	Textures = 2
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum LOKFCOCJLEC
{
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	LowQuality,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	HighQuality
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class OAFJGCDIIED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public EKHNEEONEEL BADBMKBONFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public AGCDJCAHHLN PKKGPKOOPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public AsyncCoroutineHelper CHAKDIDGBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public bool MGFOGPAMGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public BGIFNAEMGAK BBCBBDMMEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public bool CLFONEHPDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public DOCEEAKBFKN EAHKPLGHEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public bool KABDKDOAHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public CLABBLDHKNF BDPPOCOCOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public CLABBLDHKNF OFHLEHEANJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public bool KPNIPBEPONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public DELGEKGNICC MIGOOIICDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public LOKFCOCJLEC KHAOJCBCHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public BlendShapeFrameWeightSetting INMHLGCLMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public JNADKFAPCEK PCPHKBGOKLG;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public ILogger NDOPOKDOPNE;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x9C555C0", Offset = "0x9C545C0", VA = "0x189C555C0")]
	public OAFJGCDIIED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum DELGEKGNICC
{
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	ImportAndActive,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	ImportAndCameraDisabled
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public enum BGIFNAEMGAK
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
public struct EGEDFJOLKIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public bool LKCAKOMICIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public int OGFNPMHJKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public int APDHJKFGCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public int FENMGPJLNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public int DMIIHHCILFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public int KBCHCEIDHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public int LGDCNAINMGC;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public float DCMODBLEEAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9C507A0", Offset = "0x9C4F7A0", VA = "0x189C507A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x9C507D0", Offset = "0x9C4F7D0", VA = "0x189C507D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct DBDHNGGIFEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public long BMAMKHLHHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public long NFFNGCGABBH;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public delegate float[] MEAFILEPJKO(LFIOAIOJIBE INCJDDLACNP, int ONAKCINBIHN);
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class OBGDAHNJGCJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public enum HNALOHEOPDK
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
	protected struct HFNOPCCFANL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public Stream EMLKKGDGGAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public long JFGPAAJNNDL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class CLHBECKJBAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public Texture AHAKDEILDPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public int LBLHFCEEAAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public double EOJGFBJHKJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public Vector2 CNDJAMFAIMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public double FOJJHGMABOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public Vector2 FOANFLBGIHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public int? MNJBKNBFDBG;

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x9C4FA90", Offset = "0x9C4EA90", VA = "0x189C4FA90")]
		public CLHBECKJBAH()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct KNBHGPBLIHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public IProgress<EGEDFJOLKIF> progress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public int sceneIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public bool showSceneObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public Action<GameObject, ExceptionDispatchInfo> onLoadComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9C531A0", Offset = "0x9C521A0", VA = "0x189C531A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x9C545F0", Offset = "0x9C535F0", VA = "0x189C545F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct HGAMHGNEAGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private HLAGMJEKLKG <def>5__3;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x9C520D0", Offset = "0x9C510D0", VA = "0x189C520D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x9C52520", Offset = "0x9C51520", VA = "0x189C52520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class GEJCKFFJPLB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private struct <<LoadMaterialAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			public GEJCKFFJPLB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			private HLAGMJEKLKG <def>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x9C63B10", Offset = "0x9C62B10", VA = "0x189C63B10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x9C63F40", Offset = "0x9C62F40", VA = "0x189C63F40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public int materialIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public GEJCKFFJPLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9C50D80", Offset = "0x9C4FD80", VA = "0x189C50D80")]
		[AsyncStateMachine(typeof(<<LoadMaterialAsync>b__0>d))]
		internal Task BEEHHMNADKC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct KOBCPCKJLIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public AsyncTaskMethodBuilder<Material> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public int materialIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private GEJCKFFJPLB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9C54650", Offset = "0x9C53650", VA = "0x189C54650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9C54960", Offset = "0x9C53960", VA = "0x189C54960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class KMNJJMMMDDD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct <<LoadMeshAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public KMNJJMMMDDD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			private IHBCEMMPKLA <def>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x9C63FA0", Offset = "0x9C62FA0", VA = "0x189C63FA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x9C64560", Offset = "0x9C63560", VA = "0x189C64560", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public int meshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public KMNJJMMMDDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x9C530D0", Offset = "0x9C520D0", VA = "0x189C530D0")]
		[AsyncStateMachine(typeof(<<LoadMeshAsync>b__0>d))]
		internal Task BFMIEDIGCBK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct PBGMLBFHOLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public AsyncTaskMethodBuilder<Mesh> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public int meshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private KMNJJMMMDDD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x9C63760", Offset = "0x9C62760", VA = "0x189C63760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9C63AA0", Offset = "0x9C62AA0", VA = "0x189C63AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class OKHECKEJAED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public EAOPNGNAJJC dataLoader2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public string jsonFilePath;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public OKHECKEJAED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9C62780", Offset = "0x9C61780", VA = "0x189C62780")]
		internal Stream ENFPNDPIBCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x9C62870", Offset = "0x9C61870", VA = "0x189C62870")]
		internal void LMIKECPLHHB()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct DEEODGIPHMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public string jsonFilePath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private OKHECKEJAED <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private TaskAwaiter<Stream> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x9C4FF10", Offset = "0x9C4EF10", VA = "0x189C4FF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x9C506C0", Offset = "0x9C4F6C0", VA = "0x189C506C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct OMPNPOOEBMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public int sceneIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public bool showSceneObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private EJGANAMIGAK <scene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9C62900", Offset = "0x9C61900", VA = "0x189C62900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9C63700", Offset = "0x9C62700", VA = "0x189C63700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct DFJBPIEJILA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public AsyncTaskMethodBuilder<DJGAAPLKBNG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public GCKEGEHONDD bufferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9C67650", Offset = "0x9C66650", VA = "0x189C67650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9C678E0", Offset = "0x9C668E0", VA = "0x189C678E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct DKFFBDDGKIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public int nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private EOEJDHNLIOH <node>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private ALOJNMHIBBG <lodsExtension>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9C68600", Offset = "0x9C67600", VA = "0x189C68600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9C69210", Offset = "0x9C68210", VA = "0x189C69210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct DJIDMCLIFNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public AsyncTaskMethodBuilder<(Vector3, Quaternion, Vector3)[]> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public EOEJDHNLIOH node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private KKFEHMEFPIL <positionsAttr>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private KKFEHMEFPIL <rotationAttr>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private KKFEHMEFPIL <scaleAttr>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private EXT_mesh_gpu_instancing <extMeshGPUInstancing>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private int <instancesCount>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private TaskAwaiter<KKFEHMEFPIL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9C67950", Offset = "0x9C66950", VA = "0x189C67950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9C68590", Offset = "0x9C67590", VA = "0x189C68590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class HIECLDIINIF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		private struct <<ConstructNode>g__CreateNodeComponentsAndChilds|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public HIECLDIINIF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public bool onlyMesh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public bool ignoreMesh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			private List<MBEFNBJNJKI>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			private IHBCEMMPKLA <mesh>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			private Mesh <unityMesh>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			private List<double> <weights>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			private SkinnedMeshRenderer <renderer>5__6;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x9C77CF0", Offset = "0x9C76CF0", VA = "0x189C77CF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x9C79770", Offset = "0x9C78770", VA = "0x189C79770", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public GameObject nodeObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public EOEJDHNLIOH node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public int nodeIndex;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public HIECLDIINIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x9C6DDC0", Offset = "0x9C6CDC0", VA = "0x189C6DDC0")]
		[AsyncStateMachine(typeof(<<ConstructNode>g__CreateNodeComponentsAndChilds|0>d))]
		internal Task PCLJMJFKKGN(bool ignoreMesh, bool onlyMesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9C6DD50", Offset = "0x9C6CD50", VA = "0x189C6DD50")]
		internal Material IKBIEFCBLBE(OHJGEJHMLLK p)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct BBONHGCBDJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public EOEJDHNLIOH node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public int nodeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private HIECLDIINIF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private (Vector3, Quaternion, Vector3)[] <instancesTRS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private TaskAwaiter<(Vector3, Quaternion, Vector3)[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private bool <shouldBeVisible>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private GameObject <instanceParentNode>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private int <i>5__5;

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x9C64FE0", Offset = "0x9C63FE0", VA = "0x189C64FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x9C66200", Offset = "0x9C65200", VA = "0x189C66200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct PJFAPJNGAPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public EOEJDHNLIOH node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private List<MBEFNBJNJKI>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x9C776E0", Offset = "0x9C766E0", VA = "0x189C776E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x9C77C90", Offset = "0x9C76C90", VA = "0x189C77C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct MLGCJEDHHIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public int bufferIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public MBLBIABCNPD buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private TaskAwaiter<Stream> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x9C6DEE0", Offset = "0x9C6CEE0", VA = "0x189C6DEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x9C6E770", Offset = "0x9C6D770", VA = "0x189C6E770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct GJDDGGAOJCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public EJGANAMIGAK scene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public bool showSceneObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private GameObject <sceneObj>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private Transform[] <nodeTransforms>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private List<AnimationClip> <constructedClips>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private TaskAwaiter<AnimationClip> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x9C6D1A0", Offset = "0x9C6C1A0", VA = "0x189C6D1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x9C6DCF0", Offset = "0x9C6CCF0", VA = "0x189C6DCF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct BLODPJALCGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public Func<Task> callback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x9C66260", Offset = "0x9C65260", VA = "0x189C66260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x9C66890", Offset = "0x9C65890", VA = "0x189C66890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct ENOOFJNGDPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x9C69280", Offset = "0x9C68280", VA = "0x189C69280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x9C694A0", Offset = "0x9C684A0", VA = "0x189C694A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct CBLCOGBPJGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public PJMIPDFECKP animation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public int animationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private Dictionary<int, string> <typeMap>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private EIELBNJIGNO[] <samplers>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private Dictionary<string, List<KKFEHMEFPIL>> <samplersByType>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private MMAJGOJPGJI <samplerDef>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private TaskAwaiter<DJGAAPLKBNG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x9C668F0", Offset = "0x9C658F0", VA = "0x189C668F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x9C675F0", Offset = "0x9C665F0", VA = "0x189C675F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct AJFMAIJADGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public PJMIPDFECKP animation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public KMBOGHLAKHA animationCache;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class NHEFNIBAOPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public NECCFLHHOBN pointerData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public MEAFILEPJKO <>9__6;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public NHEFNIBAOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x9C6E7D0", Offset = "0x9C6D7D0", VA = "0x189C6E7D0")]
		internal float[] GKIGANCFMCN(LFIOAIOJIBE data, int frame)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class OHNMGECPBAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public bool flipRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public int targetCount;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public OHNMGECPBAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x9C767F0", Offset = "0x9C757F0", VA = "0x189C767F0")]
		internal float[] MBIHEGILDGG(LFIOAIOJIBE data, int frame)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class OACFEICDACP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public float[] frameFloats;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public BlendShapeFrameWeightSetting blendShapeFrameWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public OHNMGECPBAG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public OACFEICDACP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x9C6E810", Offset = "0x9C6D810", VA = "0x189C6E810")]
		internal float[] GFOCJFHGJGB(LFIOAIOJIBE data, int frame)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct EOBGCNNBBJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public AsyncTaskMethodBuilder<AnimationClip> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public int animationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private AJFMAIJADGB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public Transform root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private NHEFNIBAOPG <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private AnimationClip <clip>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private int[] <nodeIds>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private KGLBLEENMAC <pointerImportContext>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private List<CKNLEGDMFDN>.Enumerator <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private CKNLEGDMFDN <channel>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private bool <usesPointer>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private EIELBNJIGNO <samplerCache>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private IIMAOJLEHJL <path>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private int[] <>7__wrap9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private int <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private int <nodeId>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x9C69500", Offset = "0x9C68500", VA = "0x189C69500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x9C6D130", Offset = "0x9C6C130", VA = "0x189C6D130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct OPGJIKCPOLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public EOEJDHNLIOH node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public GameObject nodeObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public int nodeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private ALOJNMHIBBG <lodsExtension>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private LOD[] <lods>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private List<double> <lodCoverage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private GameObject <lodGroupNodeObj>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private List<Renderer> <firstLodChildRenderers>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private LODGroup <lodGroup>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private int <i>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x9C76A90", Offset = "0x9C75A90", VA = "0x189C76A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x9C77680", Offset = "0x9C76680", VA = "0x189C77680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct FCILEEKBJIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public BPEOEFBMGHM mapper;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct OHJOPBIMPGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public HLAGMJEKLKG def;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private FCILEEKBJIK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public int materialIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private MIPCKGCEMKO <mrMapper>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private bool <KHR_materials_ior>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private bool <KHR_materials_transmission>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x52")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private bool <KHR_materials_volume>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x53")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private bool <KHR_materials_iridescence>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private bool <KHR_materials_specular>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x55")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private bool <KHR_materials_clearcoat>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x56")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private bool <KHR_materials_emissive_strength>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x57")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private bool <KHR_materials_sheen>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private bool <KHR_materials_anisotropy>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private PIAOFMBOKEP <sgMapper>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private KHNMANOJLAJ <unlitMapper>5__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private POOALCDPIDE <sheenMapper>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private OMONKLPLMJF <anisotropyMapper>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private ACHCPLPOMDK <transmissionMapper>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private PACFKJOADHB <volumeMapper>5__17;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private BOEEGNEIKDK <iridescenceMapper>5__18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private NBDNEPCEENA <specularMapper>5__19;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private MGKOEEEOANB <clearcoatMapper>5__20;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private JPPPBCFBFOB <uniformMapper>5__21;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private MNPGNDGBGFC <pbr>5__22;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private MOJEDEPNCBH <textureId>5__23;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private GPHNIMBDOAM <specGloss>5__24;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private KHR_materials_sheen <sheen>5__25;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private TaskAwaiter<CLHBECKJBAH> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private KHR_materials_anisotropy <anisotropy>5__26;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private KHR_materials_transmission <transmission>5__27;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private KHR_materials_volume <volume>5__28;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private KHR_materials_iridescence <iridescence>5__29;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		private KHR_materials_specular <specular>5__30;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		private KHR_materials_clearcoat <clearcoat>5__31;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private FPNMDPGGGEN <clearcoatNormalMapper>5__32;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x9C6E8E0", Offset = "0x9C6D8E0", VA = "0x189C6E8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x9C76790", Offset = "0x9C75790", VA = "0x189C76790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct GBEPDKNOFNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public OHJGEJHMLLK primitive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x9C7F7B0", Offset = "0x9C7E7B0", VA = "0x189C7F7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x9C7FA50", Offset = "0x9C7EA50", VA = "0x189C7FA50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct GJADPJCOLLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public int meshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public IHBCEMMPKLA mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private PDBDAJFPPBL <meshCache>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private AGDPDPGJEPB <unityData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x9C81620", Offset = "0x9C80620", VA = "0x189C81620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x9C82070", Offset = "0x9C81070", VA = "0x189C82070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct NHLMCBEFFJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public IHBCEMMPKLA mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x9C8EAB0", Offset = "0x9C8DAB0", VA = "0x189C8EAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x9C8ECB0", Offset = "0x9C8DCB0", VA = "0x189C8ECB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct LOKANPIHEDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int meshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public AGDPDPGJEPB unityMeshData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private Mesh <mesh>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x9C8A2B0", Offset = "0x9C892B0", VA = "0x189C8A2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x9C8B3D0", Offset = "0x9C8A3D0", VA = "0x189C8B3D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct NCOLGDLALJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public OHJGEJHMLLK primitive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public int meshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public int primitiveIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private List<Dictionary<string, KKFEHMEFPIL>> <newTargets>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private Dictionary<string, NEDBAGNCLCG>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private KeyValuePair<string, NEDBAGNCLCG> <targetAttribute>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private int <bufferID>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private TaskAwaiter<DJGAAPLKBNG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x9C8BB60", Offset = "0x9C8AB60", VA = "0x189C8BB60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x9C8CBD0", Offset = "0x9C8BBD0", VA = "0x189C8CBD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct KCAMPAHCHHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private int <meshIndex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private IHBCEMMPKLA <gltfMesh>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x9C893A0", Offset = "0x9C883A0", VA = "0x189C893A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x9C89A60", Offset = "0x9C88A60", VA = "0x189C89A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct CAGOGLGKHPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public LBGAIEAAEEI meshId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public IHBCEMMPKLA mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private int <meshIndex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private OHJGEJHMLLK <primitive>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x9C7CDA0", Offset = "0x9C7BDA0", VA = "0x189C7CDA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x9C7D3F0", Offset = "0x9C7C3F0", VA = "0x189C7D3F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct HEIHHANHBGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public int meshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public int primitiveIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public OHJGEJHMLLK primitive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private PDBDAJFPPBL.EPHDHJOPOIJ <primData>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private Dictionary<string, NEDBAGNCLCG>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private KeyValuePair<string, NEDBAGNCLCG> <attributePair>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private OFKBHOPFONF <sparse>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private TaskAwaiter<DJGAAPLKBNG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private KKFEHMEFPIL <sparseValues>5__6;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x9C87490", Offset = "0x9C86490", VA = "0x189C87490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x9C885F0", Offset = "0x9C875F0", VA = "0x189C885F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct AIOJLNAEGCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public BMMMPCGPACA skin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public SkinnedMeshRenderer renderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private int <boneCount>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private Transform[] <bones>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private float4x4[] <gltfBindPoses>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private Matrix4x4[] <bindPoses>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private TaskAwaiter<DJGAAPLKBNG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private int <i>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x9C7A860", Offset = "0x9C79860", VA = "0x189C7A860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x9C7B350", Offset = "0x9C7A350", VA = "0x189C7B350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private struct AABMBEBOCNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x9C79F90", Offset = "0x9C78F90", VA = "0x189C79F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x9C7A410", Offset = "0x9C79410", VA = "0x189C7A410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private struct PCAHGJICLGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public AsyncTaskMethodBuilder<CLHBECKJBAH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public NLGJBEIKJBH textureInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public bool isNormal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private CLHBECKJBAH <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private MOJEDEPNCBH <textureId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x9C8F830", Offset = "0x9C8E830", VA = "0x189C8F830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x9C8FE00", Offset = "0x9C8EE00", VA = "0x189C8FE00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct FFJDONDFDMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public int imageCacheIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public FGIHPDLPKFP image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public bool markGpuOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public bool isLinear;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public bool isNormal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private Stream <stream>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x9C7EE20", Offset = "0x9C7DE20", VA = "0x189C7EE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x9C7F1D0", Offset = "0x9C7E1D0", VA = "0x189C7F1D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct KOLAOLBKOML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public JPFBMCKMIAL texture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public int textureIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private Stream[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private TaskAwaiter<Stream> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x9C89AC0", Offset = "0x9C88AC0", VA = "0x189C89AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x9C8A250", Offset = "0x9C89250", VA = "0x189C8A250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct OMFOBHHDELM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public bool markGpuOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public FGIHPDLPKFP image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public NativeArray<byte> data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public Texture2D texture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x9C8EEE0", Offset = "0x9C8DEE0", VA = "0x189C8EEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x9C8F7C0", Offset = "0x9C8E7C0", VA = "0x189C8F7C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct NDFNCNBCAKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public bool isLinear;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public FGIHPDLPKFP image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public int imageCacheIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public Stream stream;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public bool markGpuOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private bool <convertToDxt5nmFormat>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private Texture2D <texture>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private Texture2D <newTextureObject>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private DJGAAPLKBNG <bufferView>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private TaskAwaiter<DJGAAPLKBNG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private TaskAwaiter<Texture2D> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private MemoryStream <memoryStream>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private NativeArray<byte> <memoryStreamData>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private byte[] <buffer>5__8;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x9C8CC30", Offset = "0x9C8BC30", VA = "0x189C8CC30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x9C8EA50", Offset = "0x9C8DA50", VA = "0x189C8EA50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct CHKFECJDMNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public int textureIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public JPFBMCKMIAL texture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public bool markGpuOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public bool isLinear;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public bool isNormal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private int <sourceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private FGIHPDLPKFP <image>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private bool <isFirstInstance>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x9C7D450", Offset = "0x9C7C450", VA = "0x189C7D450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x9C7E800", Offset = "0x9C7D800", VA = "0x189C7E800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct FJPOBPPCPCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public AsyncTaskMethodBuilder<KKFEHMEFPIL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public OBGDAHNJGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public NEDBAGNCLCG accessorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public bool isPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private GLDAKJJGPNP <accessor>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private TaskAwaiter<DJGAAPLKBNG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x9C7F230", Offset = "0x9C7E230", VA = "0x189C7F230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x9C7F740", Offset = "0x9C7E740", VA = "0x189C7F740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public int FJNNMEECCFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public int HINIPGFMNNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private bool BAOBLHBPKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private bool HPLEHEKMACH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private Dictionary<Stream, NativeArray<byte>> AFONKDOINFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public bool HKLDFOFCHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public bool HCENKBGDAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public bool GCIFFINFNFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x63")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public bool ILBIAFKKBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public bool MPIIEEBEMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public DBDHNGGIFEJ ICECPBGDEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	protected OAFJGCDIIED EKLOAJCBABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	protected PONAAEMPPDG KKOKOCOGOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	protected GameObject CEDGGOJNHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	protected readonly HLAGMJEKLKG PNHGLHMEJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	internal LKGJKIJHMAM BGDPFDAHCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	protected string KHOAPMKBBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	protected HFNOPCCFANL HPBIPDCKHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	protected CNIIHPEFGGP EICBFDLKEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	protected JEPENAPKLKO GOPGJOEKKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	protected bool OPPJPKLDFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	protected EGEDFJOLKIF ADLCEPOLFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	protected IProgress<EGEDFJOLKIF> KEFKOKKEEEI;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static ILogger DECKNFGLCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	protected ColorSpace LAOEFGOOICE;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	internal static List<Texture> AFEBIMCNHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private Dictionary<int, int> NAHGIBBLBAM;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool AOFEMHCEFMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x9C5C3A0", Offset = "0x9C5B3A0", VA = "0x189C5C3A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA69F60", Offset = "0xA68F60", VA = "0x180A69F60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public CNIIHPEFGGP AOHAMHAHFAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xE6C9A0", Offset = "0xE6B9A0", VA = "0x180E6C9A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Transform BFNCEHNBGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public GameObject JOJNONDGIIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private AnimationClip[] GOGGOABIIOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public HNALOHEOPDK GIIPIEMCBJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA7E570", Offset = "0xA7D570", VA = "0x180A7E570")]
		[CompilerGenerated]
		get
		{
			return default(HNALOHEOPDK);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xE85250", Offset = "0xE84250", VA = "0x180E85250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public string LIGGCGEEGPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA66F70", Offset = "0xA65F70", VA = "0x180A66F70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA674F0", Offset = "0xA664F0", VA = "0x180A674F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public GameObject MLDKLOEIPFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA6F020", Offset = "0xA6E020", VA = "0x180A6F020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public FMDMNBABBNB[] ADHEKIBEMPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x9C5DC80", Offset = "0x9C5CC80", VA = "0x189C5DC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public LKGJKIJHMAM[] JIOFABHPBLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x9C5C510", Offset = "0x9C5B510", VA = "0x189C5C510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public List<UnityEngine.Object> MNAAFDLGNCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA631E0", Offset = "0xA621E0", VA = "0x180A631E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	protected JNADKFAPCEK MPMOIJDOBLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x9C61D90", Offset = "0x9C60D90", VA = "0x189C61D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x9C62290", Offset = "0x9C61290", VA = "0x189C62290")]
	public OBGDAHNJGCJ(string AMPHFHGGPBB, OAFJGCDIIED EGBMNBJEHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x9C625B0", Offset = "0x9C615B0", VA = "0x189C625B0")]
	public OBGDAHNJGCJ(Stream INEOCHLMHAP, OAFJGCDIIED EGBMNBJEHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x9C622E0", Offset = "0x9C612E0", VA = "0x189C622E0")]
	private OBGDAHNJGCJ(OAFJGCDIIED EGBMNBJEHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x9C56840", Offset = "0x9C55840", VA = "0x189C56840")]
	private NativeArray<byte> CHEFEJEIHLP(Stream PMBDKJADIJM)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x9C5AC10", Offset = "0x9C59C10", VA = "0x189C5AC10")]
	private void FMLGCGDHHAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x9C58640", Offset = "0x9C57640", VA = "0x189C58640", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x9C5C530", Offset = "0x9C5B530", VA = "0x189C5C530")]
	[AsyncStateMachine(typeof(KNBHGPBLIHO))]
	public Task IBPOPKCDFMK(int MAENJMKCDDI = -1, bool AFOPNJCPNEP = true, [Optional] Action<GameObject, ExceptionDispatchInfo> CCKCDFCIPEA, [Optional] CancellationToken KGALDHLEDNC, [Optional] IProgress<EGEDFJOLKIF> KEFKOKKEEEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x9C5ADD0", Offset = "0x9C59DD0", VA = "0x189C5ADD0")]
	[AsyncStateMachine(typeof(HGAMHGNEAGP))]
	private Task GBLFHBOHCED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x9C5A880", Offset = "0x9C59880", VA = "0x189C5A880", Slot = "5")]
	[AsyncStateMachine(typeof(KOBCPCKJLIH))]
	public virtual Task<Material> FIMFMMMMBPD(int IFGMJLPFAMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x9C55980", Offset = "0x9C54980", VA = "0x189C55980", Slot = "6")]
	[AsyncStateMachine(typeof(PBGMLBFHOLD))]
	public virtual Task<Mesh> AODDBMMIHJP(int MMMGAJOGKPP, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x9C61670", Offset = "0x9C60670", VA = "0x189C61670")]
	[AsyncStateMachine(typeof(DEEODGIPHMK))]
	private Task NMIPFHODMDP(string EANHPKMBIHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x9C5FBD0", Offset = "0x9C5EBD0", VA = "0x189C5FBD0")]
	private void MKFCDGNFGDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x9C61550", Offset = "0x9C60550", VA = "0x189C61550")]
	[AsyncStateMachine(typeof(OMPNPOOEBMG))]
	protected Task NMEBOKHOLMD(int MAENJMKCDDI = -1, bool AFOPNJCPNEP = true, [Optional] CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x9C56370", Offset = "0x9C55370", VA = "0x189C56370")]
	private void BNMJAEDMKGA(EJGANAMIGAK KJIOEGBKNOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x9C5F2F0", Offset = "0x9C5E2F0", VA = "0x189C5F2F0")]
	public NativeArray<byte> MGBFMLNLMEP(FOMCCDKKDGJ ILLONLGCKFI)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x9C61440", Offset = "0x9C60440", VA = "0x189C61440")]
	[AsyncStateMachine(typeof(DFJBPIEJILA))]
	private Task<DJGAAPLKBNG> NFIGGHKICDK(GCKEGEHONDD CFGKNCDHBHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x9C5BC80", Offset = "0x9C5AC80", VA = "0x189C5BC80")]
	private float HECDMIOAFNB(List<double> FDJEBIBHNPK, int PCMGNGEMICF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x9C5C1F0", Offset = "0x9C5B1F0", VA = "0x189C5C1F0")]
	[AsyncStateMachine(typeof(DKFFBDDGKIL))]
	private Task<GameObject> HLNJDDPIBFK(int OMEKNOMEFGA, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x9C56240", Offset = "0x9C55240", VA = "0x189C56240")]
	[AsyncStateMachine(typeof(DJIDMCLIFNP))]
	private Task<(Vector3, Quaternion, Vector3)[]> BNFFMFOCKKB(EOEJDHNLIOH ABOLKPCCJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x9C56150", Offset = "0x9C55150", VA = "0x189C56150")]
	private bool BNDGAAEGBLC(EOEJDHNLIOH ABOLKPCCJOL, GameObject CMBLOMMLEPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x9C5FA90", Offset = "0x9C5EA90", VA = "0x189C5FA90", Slot = "7")]
	[AsyncStateMachine(typeof(BBONHGCBDJD))]
	protected virtual Task MKEDKPNOLLD(EOEJDHNLIOH ABOLKPCCJOL, int KJEACKDADJM, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x9C618A0", Offset = "0x9C608A0", VA = "0x189C618A0")]
	[AsyncStateMachine(typeof(PJFAPJNGAPA))]
	private Task OGAMFDOKBGK(EOEJDHNLIOH ABOLKPCCJOL, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x9C619C0", Offset = "0x9C609C0", VA = "0x189C619C0")]
	[AsyncStateMachine(typeof(MLGCJEDHHIE))]
	protected Task OGMMOGAHOFD(MBLBIABCNPD MPPMMFHHGAK, int AEOBEOIDBKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x9C55D20", Offset = "0x9C54D20", VA = "0x189C55D20", Slot = "8")]
	[AsyncStateMachine(typeof(GJDDGGAOJCO))]
	protected virtual Task BFDKEGMGBJH(EJGANAMIGAK KJIOEGBKNOL, bool AFOPNJCPNEP, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x9C5A770", Offset = "0x9C59770", VA = "0x189C5A770", Slot = "9")]
	protected virtual DJGAAPLKBNG FELDLKBGCKO(int AEOBEOIDBKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x9C60170", Offset = "0x9C5F170", VA = "0x189C60170")]
	private void NBMGOOMFHHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x9C57C60", Offset = "0x9C56C60", VA = "0x189C57C60")]
	private void CPEMIOAOHED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x9C5A2D0", Offset = "0x9C592D0", VA = "0x189C5A2D0")]
	[AsyncStateMachine(typeof(BLODPJALCGK))]
	private Task EJFKGPLFBKF(Func<Task> HCEFPMMOBCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x9C61CC0", Offset = "0x9C60CC0", VA = "0x189C61CC0")]
	[AsyncStateMachine(typeof(ENOOFJNGDPN))]
	protected Task PBNHAHLIANK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x9C57AB0", Offset = "0x9C56AB0", VA = "0x189C57AB0")]
	private static string CJFKAMMLKDB(Transform OLHDOIOOPGE, Transform NKBKNNLLHKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x9C5F970", Offset = "0x9C5E970", VA = "0x189C5F970", Slot = "10")]
	[AsyncStateMachine(typeof(CBLCOGBPJGN))]
	protected virtual Task MJAMDFCECMP(PJMIPDFECKP BLIMBEMADDN, int OMNGOIJNNGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x9C5AFC0", Offset = "0x9C59FC0", VA = "0x189C5AFC0")]
	protected void GDDBDMJBLOM(AnimationClip EKODMKFOHGP, string DLBIMAMCEHH, string[] EFJKPDLHAGH, LFIOAIOJIBE JMJJABEKOFI, LFIOAIOJIBE LLJAAOFGKGM, CLMIMDMFHPB PBBNDGKGPAB, Type KDIMJFFFCNF, MEAFILEPJKO LDKKBJDBBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x9C5BA90", Offset = "0x9C5AA90", VA = "0x189C5BA90")]
	private void HBBNIDBHKDM(Keyframe[] DMLIGBJMLKL, int FGNOALNNIMD, CLMIMDMFHPB ENFDBKFLKKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x9C58460", Offset = "0x9C57460", VA = "0x189C58460")]
	private static float DJFMEFBJFBH(Keyframe[] DMLIGBJMLKL, int FGNOALNNIMD, bool JOCEHEOBKPD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x9C5A3C0", Offset = "0x9C593C0", VA = "0x189C5A3C0")]
	[AsyncStateMachine(typeof(EOBGCNNBBJD))]
	protected Task<AnimationClip> FAMEFJNBHCH(Transform NKBKNNLLHKF, int OMNGOIJNNGD, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x9C5D840", Offset = "0x9C5C840", VA = "0x189C5D840")]
	private bool JCJGPJGLDNG(GameObject CMBLOMMLEPF, EOEJDHNLIOH ABOLKPCCJOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x9C5DCA0", Offset = "0x9C5CCA0", VA = "0x189C5DCA0")]
	private bool JNGMEAOPHDN(GameObject CMBLOMMLEPF, EOEJDHNLIOH ABOLKPCCJOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x9C5AAD0", Offset = "0x9C59AD0", VA = "0x189C5AAD0")]
	[AsyncStateMachine(typeof(OPGJIKCPOLE))]
	private Task FLDPBLJAEJO(CNIIHPEFGGP HPAACAMAKIF, GameObject CMBLOMMLEPF, EOEJDHNLIOH ABOLKPCCJOL, int KJEACKDADJM, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x9C5FD10", Offset = "0x9C5ED10", VA = "0x189C5FD10", Slot = "11")]
	[AsyncStateMachine(typeof(OHJOPBIMPGH))]
	protected virtual Task MMICILCLHEK(HLAGMJEKLKG AEIDNFBDINH, int IFGMJLPFAMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x9C5C7A0", Offset = "0x9C5B7A0", VA = "0x189C5C7A0", Slot = "12")]
	protected virtual Task IIPPEIPCHPH(HLAGMJEKLKG AEIDNFBDINH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x9C5C670", Offset = "0x9C5B670", VA = "0x189C5C670", Slot = "13")]
	protected virtual AJNGIHKMGDM IDOOPCEOGOF(NLGJBEIKJBH AEIDNFBDINH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x9C5EB90", Offset = "0x9C5DB90", VA = "0x189C5EB90", Slot = "14")]
	protected virtual IDNPMKGMIHB LMMJEBIBFJI(HLAGMJEKLKG AEIDNFBDINH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x9C61310", Offset = "0x9C60310", VA = "0x189C61310", Slot = "15")]
	protected virtual KHR_materials_transmission NEHKHDJFDAJ(HLAGMJEKLKG AEIDNFBDINH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x9C5C3E0", Offset = "0x9C5B3E0", VA = "0x189C5C3E0", Slot = "16")]
	protected virtual KHR_materials_sheen IABMLBFCDKI(HLAGMJEKLKG AEIDNFBDINH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x9C58200", Offset = "0x9C57200", VA = "0x189C58200", Slot = "17")]
	protected virtual KHR_materials_anisotropy DDIEFFEOIOD(HLAGMJEKLKG AEIDNFBDINH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x9C58330", Offset = "0x9C57330", VA = "0x189C58330", Slot = "18")]
	protected virtual KHR_materials_dispersion DFNHOPFIFCF(HLAGMJEKLKG AEIDNFBDINH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x9C5D710", Offset = "0x9C5C710", VA = "0x189C5D710", Slot = "19")]
	protected virtual KHR_materials_volume IOEJJFLNNIC(HLAGMJEKLKG AEIDNFBDINH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x9C566B0", Offset = "0x9C556B0", VA = "0x189C566B0", Slot = "20")]
	protected virtual KHR_materials_ior CCJNMEFOJIO(HLAGMJEKLKG AEIDNFBDINH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x9C5EE20", Offset = "0x9C5DE20", VA = "0x189C5EE20", Slot = "21")]
	protected virtual KHR_materials_iridescence MDIHFBGMKJK(HLAGMJEKLKG AEIDNFBDINH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x9C61770", Offset = "0x9C60770", VA = "0x189C61770", Slot = "22")]
	protected virtual KHR_materials_specular NOMFOGJMPNJ(HLAGMJEKLKG AEIDNFBDINH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x9C55BF0", Offset = "0x9C54BF0", VA = "0x189C55BF0", Slot = "23")]
	protected virtual KHR_materials_clearcoat BCENGJJPFHF(HLAGMJEKLKG AEIDNFBDINH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x9C61BD0", Offset = "0x9C60BD0", VA = "0x189C61BD0")]
	[AsyncStateMachine(typeof(GBEPDKNOFNH))]
	private Task OIDGPJNKDJB(OHJGEJHMLLK CIMBBBAALLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x9C5E730", Offset = "0x9C5D730", VA = "0x189C5E730", Slot = "24")]
	[AsyncStateMachine(typeof(GJADPJCOLLP))]
	protected virtual Task LHCBJLKCCHK(IHBCEMMPKLA BFBFJIKLAEJ, int MMMGAJOGKPP, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x9C61AD0", Offset = "0x9C60AD0", VA = "0x189C61AD0")]
	[AsyncStateMachine(typeof(NHLMCBEFFJC))]
	private Task OHHDGABAIPG(IHBCEMMPKLA BFBFJIKLAEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x9C55E60", Offset = "0x9C54E60", VA = "0x189C55E60")]
	private static uint[] BHONFLKFLCD(IHBCEMMPKLA BFBFJIKLAEJ, [Out] uint NGDANDOHOOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x9C595F0", Offset = "0x9C585F0", VA = "0x189C595F0")]
	protected void ECPFEAACAKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x9C5A520", Offset = "0x9C59520", VA = "0x189C5A520")]
	protected void FBKAJHDPGBM(Mesh BFBFJIKLAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x9C56AE0", Offset = "0x9C55AE0", VA = "0x189C56AE0")]
	private AGDPDPGJEPB CILPENLBALI(IHBCEMMPKLA EPJKFKKONHF, int MMMGAJOGKPP, bool JMHCODBEKIA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x9C5E330", Offset = "0x9C5D330", VA = "0x189C5E330")]
	[AsyncStateMachine(typeof(LOKANPIHEDP))]
	protected Task LAIOGCOPGOL(AGDPDPGJEPB HGDBBOHCLPL, int MMMGAJOGKPP, string ANFPEDPKMDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x9C5F070", Offset = "0x9C5E070", VA = "0x189C5F070")]
	private void MEMOBDBIBIC(AGDPDPGJEPB HGDBBOHCLPL, int MMMGAJOGKPP, Mesh BFBFJIKLAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x9C5FE10", Offset = "0x9C5EE10", VA = "0x189C5FE10", Slot = "25")]
	[AsyncStateMachine(typeof(NCOLGDLALJC))]
	protected virtual Task MNACJDDIOKJ(OHJGEJHMLLK CIMBBBAALLD, int MMMGAJOGKPP, int CCODBJHKBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x9C58690", Offset = "0x9C57690", VA = "0x189C58690", Slot = "26")]
	protected virtual void ECBIBGOMEFI(OHJGEJHMLLK CIMBBBAALLD, int MMMGAJOGKPP, int CCODBJHKBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x9C59870", Offset = "0x9C58870", VA = "0x189C59870")]
	private void EDJNGBHGJNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x9C558A0", Offset = "0x9C548A0", VA = "0x189C558A0")]
	[AsyncStateMachine(typeof(KCAMPAHCHHK))]
	private Task AMJAEEMOBOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x9C5AEA0", Offset = "0x9C59EA0", VA = "0x189C5AEA0")]
	[AsyncStateMachine(typeof(CAGOGLGKHPJ))]
	private Task GCJNJKJHBHH(IHBCEMMPKLA BFBFJIKLAEJ, LBGAIEAAEEI KGIKHKAFHPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x9C5A990", Offset = "0x9C59990", VA = "0x189C5A990", Slot = "27")]
	[AsyncStateMachine(typeof(HEIHHANHBGF))]
	protected virtual Task FJOBBEPLDIB(OHJGEJHMLLK CIMBBBAALLD, int MMMGAJOGKPP, int CCODBJHKBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x9C603E0", Offset = "0x9C5F3E0", VA = "0x189C603E0")]
	protected void NCKBIFCBOFM(PDBDAJFPPBL.EPHDHJOPOIJ JMOGENPCNHL, AGDPDPGJEPB EHMFLGPJDEC, uint GLPDFAPNJNB, int GBOCEJCCKDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x9C5FF40", Offset = "0x9C5EF40", VA = "0x189C5FF40")]
	private void MPHDPMDENFN(Dictionary<string, KKFEHMEFPIL> NMOLIOEJBKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x9C601C0", Offset = "0x9C5F1C0", VA = "0x189C601C0")]
	protected MeshTopology NCFLHJEPJKF(CADDALLEFMK PBBNDGKGPAB)
	{
		return default(MeshTopology);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x9C59ED0", Offset = "0x9C58ED0", VA = "0x189C59ED0")]
	private void EIJOPFCPHPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x9C62030", Offset = "0x9C61030", VA = "0x189C62030", Slot = "28")]
	[AsyncStateMachine(typeof(AIOJLNAEGCO))]
	protected virtual Task POLMIOHCICA(BMMMPCGPACA KAHAMOKCEDO, SkinnedMeshRenderer LBNDIMGOFLA, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x9C5BD10", Offset = "0x9C5AD10", VA = "0x189C5BD10")]
	private void HGEBLPAMGGB(Vector4[] DABEDEOPIIA, Vector4[] CDEGIMENJBO, BoneWeight[] BFIDMAODJHI, uint MOAJDMPNBPN = 0u)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x9C5C110", Offset = "0x9C5B110", VA = "0x189C5C110")]
	[AsyncStateMachine(typeof(AABMBEBOCNA))]
	private Task HGFALMIAPMC(int HLGKMAPOEBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x9C5E1F0", Offset = "0x9C5D1F0", VA = "0x189C5E1F0")]
	[AsyncStateMachine(typeof(PCAHGJICLGG))]
	private Task<CLHBECKJBAH> JNJBOFDIFGC(NLGJBEIKJBH CFABPCEPIKB, bool MFCGLGIGCJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x9C567E0", Offset = "0x9C557E0", VA = "0x189C567E0")]
	private static int CEDOODPCFDH(byte[] INCJDDLACNP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x9C5E860", Offset = "0x9C5D860", VA = "0x189C5E860")]
	private Dictionary<int, int> LJCABMALGDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x9C5E460", Offset = "0x9C5D460", VA = "0x189C5E460")]
	private void LBHMIGEOFJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x9C57F50", Offset = "0x9C56F50", VA = "0x189C57F50")]
	private Stream DAMAANALJBE(FGIHPDLPKFP PDPOFBJMGAH, int JPADFICDDAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x9C55AB0", Offset = "0x9C54AB0", VA = "0x189C55AB0")]
	[AsyncStateMachine(typeof(FFJDONDFDMF))]
	protected Task BABFKPJBDHM(FGIHPDLPKFP PDPOFBJMGAH, int JPADFICDDAB, bool NKPLMFPAEDA, bool IHONAEGANBJ, bool MFCGLGIGCJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x9C5EF50", Offset = "0x9C5DF50", VA = "0x189C5EF50")]
	[AsyncStateMachine(typeof(KOLAOLBKOML))]
	protected Task MEFDENCOJAB(JPFBMCKMIAL GHHJBAFAEIA, int AGBFMKONNGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x9C5F4E0", Offset = "0x9C5E4E0", VA = "0x189C5F4E0")]
	[AsyncStateMachine(typeof(OMFOBHHDELM))]
	private Task<Texture2D> MGGPPJBBDLP(FGIHPDLPKFP PDPOFBJMGAH, Texture2D GHHJBAFAEIA, NativeArray<byte> INCJDDLACNP, bool NKPLMFPAEDA, bool IHONAEGANBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x9C61DB0", Offset = "0x9C60DB0", VA = "0x189C61DB0", Slot = "29")]
	[AsyncStateMachine(typeof(NDFNCNBCAKO))]
	protected virtual Task PJHDEMBEJPO(Stream PMBDKJADIJM, bool NKPLMFPAEDA, bool IHONAEGANBJ, bool MFCGLGIGCJE, FGIHPDLPKFP PDPOFBJMGAH, int JPADFICDDAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x9C5ECC0", Offset = "0x9C5DCC0", VA = "0x189C5ECC0", Slot = "30")]
	protected virtual int LNCLEMKCJBL(JPFBMCKMIAL GHHJBAFAEIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x9C5C330", Offset = "0x9C5B330", VA = "0x189C5C330", Slot = "31")]
	protected virtual bool HNNFIMDGJCO(JPFBMCKMIAL GHHJBAFAEIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x9C5B950", Offset = "0x9C5A950", VA = "0x189C5B950", Slot = "32")]
	[AsyncStateMachine(typeof(CHKFECJDMNP))]
	protected virtual Task GDMBFPMKCFH(JPFBMCKMIAL GHHJBAFAEIA, int AGBFMKONNGG, bool NKPLMFPAEDA, bool IHONAEGANBJ, bool MFCGLGIGCJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x9C61EF0", Offset = "0x9C60EF0", VA = "0x189C61EF0")]
	[AsyncStateMachine(typeof(FJPOBPPCPCN))]
	[CompilerGenerated]
	private Task<KKFEHMEFPIL> PLJCPHDIPLG(NEDBAGNCLCG ILHEDCJFGCC, bool NBKKGMFNMGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x9C5D480", Offset = "0x9C5C480", VA = "0x189C5D480")]
	[CompilerGenerated]
	internal static KKFEHMEFPIL IMBOLMKCKEE(string DMBMPGKJHDB, AJFMAIJADGB P_1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x9C57DF0", Offset = "0x9C56DF0", VA = "0x189C57DF0")]
	[CompilerGenerated]
	private void DAJPGBNLOHD(MOJEDEPNCBH OCBFOGBAGMO, AJNGIHKMGDM AJNDPFIHAJC, [Out] Vector2 AJNABLFIHCD, [Out] Vector2 MOAJDMPNBPN, FCILEEKBJIK P_4)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x9C58130", Offset = "0x9C57130", VA = "0x189C58130")]
	[CompilerGenerated]
	private void DBKKGCIMEPN(FCILEEKBJIK P_0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x9C556B0", Offset = "0x9C546B0", VA = "0x189C556B0")]
	[CompilerGenerated]
	private void ABAGBBOMBGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x9C5F640", Offset = "0x9C5E640", VA = "0x189C5F640")]
	[CompilerGenerated]
	private TextureWrapMode MGHFJBNFCOD(KKCANKBDGNE CFIAJNLIJEN)
	{
		return default(TextureWrapMode);
	}
}
namespace UnityGLTF
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class GLTFSettings : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[Flags]
		public enum JPKCINCLBLP
		{
			[Cpp2IlInjected.Token(Token = "0x4000303")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000304")]
			PositionOnly = 1,
			[Cpp2IlInjected.Token(Token = "0x4000305")]
			Normal = 2,
			[Cpp2IlInjected.Token(Token = "0x4000306")]
			Tangent = 4,
			[Cpp2IlInjected.Token(Token = "0x4000307")]
			All = -1
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class NFHNAAIPBLE<T> where T : GLTFPlugin
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			public Type pluginType;

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
			public NFHNAAIPBLE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x5782820", Offset = "0x5781820", VA = "0x185782820")]
			internal bool JIEEFELJAHG(T p)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private const string k_PreferencesPrefix = "UnityGLTF_Preferences_";

		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private const string k_SettingsFileName = "UnityGLTFSettings.asset";

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public const string k_RuntimeAndEditorSettingsPath = "Assets/Resources/UnityGLTFSettings.asset";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		[SerializeField]
		[HideInInspector]
		internal string packageVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		[SerializeField]
		[HideInInspector]
		public List<GLTFImportPlugin> ImportPlugins;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		[HideInInspector]
		[SerializeField]
		public List<GLTFExportPlugin> ExportPlugins;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		[Header("Export Settings")]
		[SerializeField]
		private bool exportNames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		[Tooltip("If on, the entire texture path will be preserved. If off (default), textures are exported at root level.")]
		[SerializeField]
		private bool exportFullPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		[Header("Export Visibility")]
		[SerializeField]
		[Tooltip("Uses Camera.main layer settings to filter which objects are exported")]
		private bool useMainCameraVisibility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x33")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		[SerializeField]
		[Tooltip("glTF does not support visibility state. If this setting is true, disabled GameObjects will still be exported and be visible in the glTF file.")]
		private bool exportDisabledGameObjects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		[Tooltip("(Experimental) Exports PNG/JPEG directly from disk instead of re-encoding from Unity's import result. No channel repacking will happen for these textures. Textures in other formats (PSD, TGA etc) not supported by glTF and in-memory textures (e.g. RenderTextures) are always re-encoded.")]
		[SerializeField]
		[Header("Export Textures")]
		private bool tryExportTexturesFromDisk;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		[SerializeField]
		[Tooltip("Determines texture export type (PNG or JPEG) based on alpha channel. When false, always exports lossless PNG files.")]
		private bool useTextureFileTypeHeuristic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		[Tooltip("Quality setting for exported JPEG files.")]
		[SerializeField]
		private int defaultJpegQuality;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		[SerializeField]
		[Header("Export Animation")]
		private bool exportAnimations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		[SerializeField]
		[Tooltip("When enabled the Animator State speed parameter is baked into the exported glTF animation")]
		private bool bakeAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		[SerializeField]
		[Tooltip("Some viewers can't distinguish between animation clips that have the same name. This option ensures all exported animation names are unique.")]
		private bool uniqueAnimationNames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		[SerializeField]
		private bool bakeSkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		[SerializeField]
		[Header("Export Mesh Data")]
		private JPKCINCLBLP blendShapeExportProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		[SerializeField]
		[Tooltip("(Experimental) Use Sparse Accessors for blend shape export. Not supported on some viewers.")]
		private bool blendShapeExportSparseAccessors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		[SerializeField]
		[Tooltip("If off, vertex colors are not exported. Vertex Colors aren't supported in some viewers (e.g. Google's SceneViewer).")]
		private bool exportVertexColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		[Tooltip("When enabled textures will be cached to disc for faster export times.\n(The cache size is reduced to stay below 1024 MB when the Editor quits)")]
		[Header("Export Cache")]
		public bool UseCaching;

		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private static GLTFSettings cachedSettings;

		[Cpp2IlInjected.Token(Token = "0x4000301")]
		private static List<GLTFSettings> settingsWherePluginsAreRegistered;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public string Generator
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x9C82E40", Offset = "0x9C81E40", VA = "0x189C82E40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool ExportNames
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xA8E4F0", Offset = "0xA8D4F0", VA = "0x180A8E4F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xA8E310", Offset = "0xA8D310", VA = "0x180A8E310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool ExportFullPath
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0xF00130", Offset = "0xEFF130", VA = "0x180F00130")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x1544370", Offset = "0x1543370", VA = "0x181544370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool UseMainCameraVisibility
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x1C511F0", Offset = "0x1C501F0", VA = "0x181C511F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x29DA8E0", Offset = "0x29D98E0", VA = "0x1829DA8E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool TryExportTexturesFromDisk
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xE98470", Offset = "0xE97470", VA = "0x180E98470")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xEB3790", Offset = "0xEB2790", VA = "0x180EB3790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool UseTextureFileTypeHeuristic
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xEB3860", Offset = "0xEB2860", VA = "0x180EB3860")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xEB3A80", Offset = "0xEB2A80", VA = "0x180EB3A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool ExportVertexColors
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x74C2CE0", Offset = "0x74C1CE0", VA = "0x1874C2CE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x7582460", Offset = "0x7581460", VA = "0x187582460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public int DefaultJpegQuality
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xA7E570", Offset = "0xA7D570", VA = "0x180A7E570")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xE85250", Offset = "0xE84250", VA = "0x180E85250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool ExportDisabledGameObjects
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x29B1790", Offset = "0x29B0790", VA = "0x1829B1790")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x8390B30", Offset = "0x838FB30", VA = "0x188390B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool ExportAnimations
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xF67FD0", Offset = "0xF66FD0", VA = "0x180F67FD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xF68040", Offset = "0xF67040", VA = "0x180F68040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool BakeAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xF68390", Offset = "0xF67390", VA = "0x180F68390")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xF67CC0", Offset = "0xF66CC0", VA = "0x180F67CC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		[Obsolete("Add/remove \"AnimationPointerPlugin\" from ExportPlugins instead.")]
		public bool UseAnimationPointer
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x9C82E50", Offset = "0x9C81E50", VA = "0x189C82E50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x9C82F90", Offset = "0x9C81F90", VA = "0x189C82F90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool UniqueAnimationNames
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xF67CE0", Offset = "0xF66CE0", VA = "0x180F67CE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xF67FC0", Offset = "0xF66FC0", VA = "0x180F67FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool BlendShapeExportSparseAccessors
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x18C67D0", Offset = "0x18C57D0", VA = "0x1818C67D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x190F880", Offset = "0x190E880", VA = "0x18190F880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public JPKCINCLBLP BlendShapeExportProperties
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xD16000", Offset = "0xD15000", VA = "0x180D16000")]
			get
			{
				return default(JPKCINCLBLP);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xF6BDC0", Offset = "0xF6ADC0", VA = "0x180F6BDC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool BakeSkinnedMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x9C82E30", Offset = "0x9C81E30", VA = "0x189C82E30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x9C82F80", Offset = "0x9C81F80", VA = "0x189C82F80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x9C82910", Offset = "0x9C81910", VA = "0x189C82910")]
		internal string PBBPOIFMDAI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x9C82740", Offset = "0x9C81740", VA = "0x189C82740")]
		public static GLTFSettings KKMGMFCDMHG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x9C82200", Offset = "0x9C81200", VA = "0x189C82200")]
		public static GLTFSettings APIPBFGLJEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x9C820D0", Offset = "0x9C810D0", VA = "0x189C820D0")]
		public static bool AANNEAIMEHG([Out] GLTFSettings KGDNAKPKMMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x9C82270", Offset = "0x9C81270", VA = "0x189C82270")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ClearStatics()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x9C82330", Offset = "0x9C81330", VA = "0x189C82330")]
		private static void GFPHEGCNGCG(GLTFSettings KGDNAKPKMMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x9C82D30", Offset = "0x9C81D30", VA = "0x189C82D30")]
		public GLTFSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3C64290", Offset = "0x3C63290", VA = "0x183C64290")]
		[CompilerGenerated]
		internal static List<Type> IHHFEHOFOFF<T>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x3C63E90", Offset = "0x3C62E90", VA = "0x183C63E90")]
		[CompilerGenerated]
		internal static void GKGCCLOGBCO<T>(List<T> JBJMPICDIGB) where T : GLTFPlugin
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class ShaderNotFoundException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x9C90540", Offset = "0x9C8F540", VA = "0x189C90540")]
		public ShaderNotFoundException()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x9C90490", Offset = "0x9C8F490", VA = "0x189C90490")]
		public ShaderNotFoundException(string OBCNAJEENCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x9C904F0", Offset = "0x9C8F4F0", VA = "0x189C904F0")]
		protected ShaderNotFoundException(SerializationInfo OGECODCBMEN, StreamingContext IEGLIFIOOBM)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class CMAFAKLGCEA : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x9C7E860", Offset = "0x9C7D860", VA = "0x189C7E860")]
	public CMAFAKLGCEA(string OBCNAJEENCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class MNCBMDGELDD : ILogHandler
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private readonly StringBuilder CLDLIPEGJJL;

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x9C8B790", Offset = "0x9C8A790", VA = "0x189C8B790")]
	private string EGKPCDMKLIB(LogType FAPMBPGLKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x9C8BA20", Offset = "0x9C8AA20", VA = "0x189C8BA20", Slot = "4")]
	public void LogFormat(LogType FAPMBPGLKBO, UnityEngine.Object IEGLIFIOOBM, string IEAPGIAMHDB, params object[] DELLHDJPKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x9C8B980", Offset = "0x9C8A980", VA = "0x189C8B980", Slot = "5")]
	public void LogException(Exception JNADAKHBCKJ, UnityEngine.Object IEGLIFIOOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x9C8B810", Offset = "0x9C8A810", VA = "0x189C8B810")]
	public void FNEDHICCPNI(string IEAPGIAMHDB = "{0}")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x9C8BAE0", Offset = "0x9C8AAE0", VA = "0x189C8BAE0")]
	public MNCBMDGELDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class EBJBAJKFDHM
{
	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x9C7E9C0", Offset = "0x9C7D9C0", VA = "0x189C7E9C0")]
	public static string IHOELLLJOJH(Uri CIOCKLLADAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x9C7EA20", Offset = "0x9C7DA20", VA = "0x189C7EA20")]
	public static string MBJJDHIFHBK(string EJPBANPOCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x9C7EA90", Offset = "0x9C7DA90", VA = "0x189C7EA90")]
	public static void NOPHHGLCMNI(string CIOCKLLADAN, [Out] byte[] BLFJFNJCFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x9C7E930", Offset = "0x9C7D930", VA = "0x189C7E930")]
	public static bool EMANMJLDMJN(string CIOCKLLADAN)
	{
		return default(bool);
	}
}
namespace UnityGLTF
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class InstantiatedGLTFObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private OFHCNPCLCIF PHEKBFAAAAA;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public OFHCNPCLCIF JMFJFLOPAPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x9C89250", Offset = "0x9C88250", VA = "0x189C89250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x9C89120", Offset = "0x9C88120", VA = "0x189C89120")]
		public InstantiatedGLTFObject Duplicate()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x9C89200", Offset = "0x9C88200", VA = "0x189C89200")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xA60510", Offset = "0xA5F510", VA = "0x180A60510")]
		public InstantiatedGLTFObject()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public struct BlendShapeFrameWeightSetting
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public enum LKLGFHNJEMN
		{
			[Cpp2IlInjected.Token(Token = "0x4000313")]
			Multiplier1,
			[Cpp2IlInjected.Token(Token = "0x4000314")]
			Multiplier100,
			[Cpp2IlInjected.Token(Token = "0x4000315")]
			Custom
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		[SerializeField]
		internal LKLGFHNJEMN _option;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		[SerializeField]
		internal float _multiplier;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float Multiplier
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x9C7CD10", Offset = "0x9C7BD10", VA = "0x189C7CD10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x9C7CD00", Offset = "0x9C7BD00", VA = "0x189C7CD00")]
		public BlendShapeFrameWeightSetting(LKLGFHNJEMN CAFCJPPBAFE)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x9C7CC70", Offset = "0x9C7BC70", VA = "0x189C7CC70")]
		public static float MJOOONLKLLN(BlendShapeFrameWeightSetting MIAGDCGBGLC)
		{
			return default(float);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public enum CLABBLDHKNF
{
	[Cpp2IlInjected.Token(Token = "0x4000317")]
	Import,
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	Calculate,
	[Cpp2IlInjected.Token(Token = "0x4000319")]
	None
}
namespace UnityGLTF
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public abstract class ImporterFactory : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract OBGDAHNJGCJ OHCONHKDCEJ(string AMPHFHGGPBB, OAFJGCDIIED EGBMNBJEHHO);

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xCF9400", Offset = "0xCF8400", VA = "0x180CF9400")]
		protected ImporterFactory()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class DefaultImporterFactory : ImporterFactory
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x9C7E8C0", Offset = "0x9C7D8C0", VA = "0x189C7E8C0", Slot = "4")]
		public override OBGDAHNJGCJ OHCONHKDCEJ(string AMPHFHGGPBB, OAFJGCDIIED EGBMNBJEHHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xCF9400", Offset = "0xCF8400", VA = "0x180CF9400")]
		public DefaultImporterFactory()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal static class EJADICDKJBB
{
	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x9C7EBA0", Offset = "0x9C7DBA0", VA = "0x189C7EBA0")]
	internal static void CNHBJLHJLMC(this Material JNBIMACAHOC, string LDNOGLJICGK, bool GICMHPOANOB)
	{
	}
}
namespace UnityGLTF
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class MaterialLibrary : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xCF9400", Offset = "0xCF8400", VA = "0x180CF9400")]
		public MaterialLibrary()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal static class JEOIKPBGCOD
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class MDNOJCOFAPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public Texture2D dest;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public Texture2D source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public Color[] pixels;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public MDNOJCOFAPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x9C8B520", Offset = "0x9C8A520", VA = "0x189C8B520")]
		internal void OHCFOKFMKKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x9C8B430", Offset = "0x9C8A430", VA = "0x189C8B430")]
		internal void BFKFDCAPNOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x9C8B480", Offset = "0x9C8A480", VA = "0x189C8B480")]
		internal void GPKGIEIAPGC()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct IEMMFNPIAIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public Texture2D source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private MDNOJCOFAPL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x9C88650", Offset = "0x9C87650", VA = "0x189C88650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x9C88CA0", Offset = "0x9C87CA0", VA = "0x189C88CA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x9C892B0", Offset = "0x9C882B0", VA = "0x189C892B0")]
	[AsyncStateMachine(typeof(IEMMFNPIAIE))]
	public static Task<Texture2D> PHAHBEGGPFL(Texture2D MKOOPFGGHLN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class AGDPDPGJEPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public bool[] KPAKCHGKOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public Vector3[] NHFCNLIPOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public Vector3[] KNIDFIKFGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public Vector4[] BIMKLIAPIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public Vector2[] BIPNNJPCMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public Vector2[] NPADFGBPLMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public Vector2[] JDCDMKAJHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public Vector2[] CILMHNKOLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public Color[] OHFDCPPOMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public BoneWeight[] KLHBNGJLHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public Vector3[][] PMPKFEHJNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public Vector3[][] JEPPIPGKNMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public Vector3[][] JLDLCAHEPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public MeshTopology[] NFMCHGJBAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public CADDALLEFMK[] PPHEPPJKELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public int[][] IFPKAHGOFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public HashSet<int> GJOPIOCKBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public uint[] PJNBIOBHMJN;

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x9C7A470", Offset = "0x9C79470", VA = "0x189C7A470")]
	public void JPJFAMEFLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x9C7A580", Offset = "0x9C79580", VA = "0x189C7A580")]
	public bool NFHBOALCDHO(AGDPDPGJEPB EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x9C7A7D0", Offset = "0x9C797D0", VA = "0x189C7A7D0")]
	public AGDPDPGJEPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x319B050", Offset = "0x319A050", VA = "0x18319B050")]
	[CompilerGenerated]
	internal static bool LHJOBJCDAJO<T>(T[] PCLPBGIFGFO, T[] JKEBDFBGJFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x319A900", Offset = "0x3199900", VA = "0x18319A900")]
	[CompilerGenerated]
	internal static bool JJAFLCKIOIH<T>(T[][] PCLPBGIFGFO, T[][] JKEBDFBGJFN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public abstract class BODLAMAKHOO : BPEOEFBMGHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	internal Material GEOHPNLOPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private LEGNKCJJFDB MJPANPHCPFK;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly int NDFGNHFCKPI;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private static readonly int NIKIJFIPBGP;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private static readonly int CILDCPIGFIH;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private static readonly int IIODLAIIFPF;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private static readonly int ACBLPFAHNBD;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private static readonly int ANJOHALLDIM;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	private static readonly int OPAAFAGCKCL;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	private static readonly int EKPHFKIMDIE;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	private static readonly int AJCOINDCGCA;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	private static readonly int LKBBKIFECNB;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	private static readonly int JHJKDGPHKJF;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	private static readonly int JKNNLOLGHBD;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	private static readonly int GFMPFECJMNJ;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	private static readonly int FHFNEGOHIBO;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Material AGLIMLFKBOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public virtual LEGNKCJJFDB KOBLGAJOLBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x9C7BC60", Offset = "0x9C7AC60", VA = "0x189C7BC60", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public double NKKAKIJCMFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x9C7B730", Offset = "0x9C7A730", VA = "0x189C7B730", Slot = "12")]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x9C7BA40", Offset = "0x9C7AA40", VA = "0x189C7BA40", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public virtual bool BOGFNIHNNOL
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x9C7C700", Offset = "0x9C7B700", VA = "0x189C7C700", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public virtual bool ANLDGLEAENM
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x9C7BB00", Offset = "0x9C7AB00", VA = "0x189C7BB00", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Texture EMDKFOLOPOB
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x9C7BAA0", Offset = "0x9C7AAA0", VA = "0x189C7BAA0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int PEEHBLEOPED
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x9C7C840", Offset = "0x9C7B840", VA = "0x189C7C840", Slot = "16")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Vector2 FMCEANENMHN
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x9C7B490", Offset = "0x9C7A490", VA = "0x189C7B490", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public double MLJEOKODGED
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x9C7B6D0", Offset = "0x9C7A6D0", VA = "0x189C7B6D0", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public Vector2 PBBDKHCKHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x9C7C7E0", Offset = "0x9C7B7E0", VA = "0x189C7C7E0", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int KAPFNNKBHPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x9C7BBF0", Offset = "0x9C7ABF0", VA = "0x189C7BBF0", Slot = "20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Color ONHFMPOLHBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x9C7BB80", Offset = "0x9C7AB80", VA = "0x189C7BB80", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract BPEOEFBMGHM AABAGJPEDHJ();

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0xA6BBE0", Offset = "0xA6ABE0", VA = "0x180A6BBE0")]
	protected BODLAMAKHOO(Material LAJKOJDAIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x9C7CB40", Offset = "0x9C7BB40", VA = "0x189C7CB40")]
	protected BODLAMAKHOO(string IHECHONANLE, string BIIPIONLMEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x9C7B3B0", Offset = "0x9C7A3B0", VA = "0x189C7B3B0")]
	protected void BFNDPOAHFII(Material JNBIMACAHOC, bool NMLHKHNIJMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x9C7B4F0", Offset = "0x9C7A4F0", VA = "0x189C7B4F0")]
	protected void CFFHMJLMLMH(Material JNBIMACAHOC, bool NFONNEMOAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x9C7B780", Offset = "0x9C7A780", VA = "0x189C7B780")]
	protected void GCOIPADLBBL(Material JNBIMACAHOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class IICHHFIODCO : HBGPKIMECPP, MIPCKGCEMKO, JPPPBCFBFOB, BPEOEFBMGHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	private Vector2 GENDDPJKLEP;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public virtual Texture EMDKFOLOPOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x9C88EF0", Offset = "0x9C87EF0", VA = "0x189C88EF0", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public virtual int PEEHBLEOPED
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public virtual Vector2 FMCEANENMHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x9C88E80", Offset = "0x9C87E80", VA = "0x189C88E80", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public virtual double MLJEOKODGED
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public virtual Vector2 PBBDKHCKHML
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x9C89070", Offset = "0x9C88070", VA = "0x189C89070", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public virtual int KAPFNNKBHPH
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "82")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public virtual Color ONHFMPOLHBG
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x9C88FB0", Offset = "0x9C87FB0", VA = "0x189C88FB0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public virtual Texture CLGEDKKLPIA
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x9C88E30", Offset = "0x9C87E30", VA = "0x189C88E30", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public virtual int FBCNLGCPKJN
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public virtual Vector2 GAIFBNHNFLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "86")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public virtual double KDGLLKHFGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public virtual Vector2 APJMBELLJFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "88")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public virtual int CGPLGLCOKJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public virtual double POJLMIGDAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x9C89020", Offset = "0x9C88020", VA = "0x189C89020", Slot = "90")]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x9C88F50", Offset = "0x9C87F50", VA = "0x189C88F50", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual double IBCMAIBEGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "92")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x9C89110", Offset = "0x9C88110", VA = "0x189C89110")]
	protected IICHHFIODCO(string IHECHONANLE, string IDODBPEDLHJ, int PIEFANJNOAH = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x9C89100", Offset = "0x9C88100", VA = "0x189C89100")]
	protected IICHHFIODCO(Material DIPAFMFHPBG, int PIEFANJNOAH = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x9C88D10", Offset = "0x9C87D10", VA = "0x189C88D10", Slot = "60")]
	public override BPEOEFBMGHM AABAGJPEDHJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class PCMLOGCNECK : IICHHFIODCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	private Vector2 FMAJPDIHFNB;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public override int HAGCIIGLKDL
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public override int KIDGEPMEDGF
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public override int BILJODGCECA
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override int PEEHBLEOPED
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override Texture CLGEDKKLPIA
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x9C8FFA0", Offset = "0x9C8EFA0", VA = "0x189C8FFA0", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public override int FBCNLGCPKJN
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public override Vector2 GAIFBNHNFLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x9C90020", Offset = "0x9C8F020", VA = "0x189C90020", Slot = "86")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public override double KDGLLKHFGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public override Vector2 APJMBELLJFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x9C900F0", Offset = "0x9C8F0F0", VA = "0x189C900F0", Slot = "88")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public override int CGPLGLCOKJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public override double IBCMAIBEGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x9C90090", Offset = "0x9C8F090", VA = "0x189C90090", Slot = "92")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x9C901A0", Offset = "0x9C8F1A0", VA = "0x189C901A0")]
	public PCMLOGCNECK(string IHECHONANLE, int PIEFANJNOAH = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x9C90180", Offset = "0x9C8F180", VA = "0x189C90180")]
	protected PCMLOGCNECK(Material DIPAFMFHPBG, int PIEFANJNOAH = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x9C8FE70", Offset = "0x9C8EE70", VA = "0x189C8FE70", Slot = "60")]
	public override BPEOEFBMGHM AABAGJPEDHJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class GPKCDOFOEHE : BODLAMAKHOO, MIPCKGCEMKO, JPPPBCFBFOB, BPEOEFBMGHM, PACFKJOADHB, ACHCPLPOMDK, JIMLAFKCFLM, BOEEGNEIKDK, NBDNEPCEENA, MGKOEEEOANB, JHJOBMJMHLL, POOALCDPIDE, OMONKLPLMJF
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Texture EKPBOMCCLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x9C850A0", Offset = "0x9C840A0", VA = "0x189C850A0", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x9C855D0", Offset = "0x9C845D0", VA = "0x189C855D0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public int HAGCIIGLKDL
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x9C84D20", Offset = "0x9C83D20", VA = "0x189C84D20", Slot = "39")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public double DLMNNOPPJJH
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x9C84040", Offset = "0x9C83040", VA = "0x189C84040", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public Vector2 DNGEBMADHED
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x9C85510", Offset = "0x9C84510", VA = "0x189C85510", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public double HOOEJPMDEOE
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x9C856F0", Offset = "0x9C846F0", VA = "0x189C856F0", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Vector2 HAADIFBIPHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x9C85B80", Offset = "0x9C84B80", VA = "0x189C85B80", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int IPDNEIJCKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x9C85F40", Offset = "0x9C84F40", VA = "0x189C85F40", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Texture DOJKBBHGADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x9C84DF0", Offset = "0x9C83DF0", VA = "0x189C84DF0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public int KIDGEPMEDGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x9C847D0", Offset = "0x9C837D0", VA = "0x189C847D0", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public double ENBGOMIAMEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x9C849C0", Offset = "0x9C839C0", VA = "0x189C849C0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public Vector2 AGOCEIBDHDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x9C85CA0", Offset = "0x9C84CA0", VA = "0x189C85CA0", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public double OOMAIAJJPEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x9C83D90", Offset = "0x9C82D90", VA = "0x189C83D90", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Vector2 CKHLJLGHMND
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x9C84A80", Offset = "0x9C83A80", VA = "0x189C84A80", Slot = "50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int NMPIIAJCNDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x9C83C50", Offset = "0x9C82C50", VA = "0x189C83C50", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public Texture HBIDKCMJIHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x9C840A0", Offset = "0x9C830A0", VA = "0x189C840A0", Slot = "52")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public int BILJODGCECA
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x9C85D00", Offset = "0x9C84D00", VA = "0x189C85D00", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Color BBDLEIKMOEN
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x9C85B10", Offset = "0x9C84B10", VA = "0x189C85B10", Slot = "54")]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x9C84760", Offset = "0x9C83760", VA = "0x189C84760", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector2 NJLMIBNIIFH
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x9C84840", Offset = "0x9C83840", VA = "0x189C84840", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public double LBDJGPFHFBO
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x9C84400", Offset = "0x9C83400", VA = "0x189C84400", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector2 FBIOLGLCKOA
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x9C84160", Offset = "0x9C83160", VA = "0x189C84160", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public int KGAOPNHEMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x9C84640", Offset = "0x9C83640", VA = "0x189C84640", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public Texture CLGEDKKLPIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x9C83AD0", Offset = "0x9C82AD0", VA = "0x189C83AD0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public int FBCNLGCPKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x9C857B0", Offset = "0x9C847B0", VA = "0x189C857B0", Slot = "30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Vector2 GAIFBNHNFLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x9C842E0", Offset = "0x9C832E0", VA = "0x189C842E0", Slot = "31")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public double KDGLLKHFGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x9C85690", Offset = "0x9C84690", VA = "0x189C85690", Slot = "32")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector2 APJMBELLJFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x9C85330", Offset = "0x9C84330", VA = "0x189C85330", Slot = "33")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public int CGPLGLCOKJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x9C851B0", Offset = "0x9C841B0", VA = "0x189C851B0", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public double POJLMIGDAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x9C854B0", Offset = "0x9C844B0", VA = "0x189C854B0", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public double IBCMAIBEGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x9C84FE0", Offset = "0x9C83FE0", VA = "0x189C84FE0", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public double DMFNFCEDAHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x9C848A0", Offset = "0x9C838A0", VA = "0x189C848A0", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Texture PFCAGONEKON
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x9C844C0", Offset = "0x9C834C0", VA = "0x189C844C0", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public double IPEKCIDDCJP
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x9C85A50", Offset = "0x9C84A50", VA = "0x189C85A50", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Vector2 BMEKAJECKIG
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x9C83EB0", Offset = "0x9C82EB0", VA = "0x189C83EB0", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public Vector2 OCGNGBLIIPB
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x9C85570", Offset = "0x9C84570", VA = "0x189C85570", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public int AOCOFAJBFME
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x9C83A10", Offset = "0x9C82A10", VA = "0x189C83A10", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public double CHKKOOKIOMF
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x9C84280", Offset = "0x9C83280", VA = "0x189C84280", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Color GDCPNIGNGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x9C84F70", Offset = "0x9C83F70", VA = "0x189C84F70", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public double HCHFEMGCAIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x9C838F0", Offset = "0x9C828F0", VA = "0x189C838F0", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Texture CCPPKNBGEJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x9C84700", Offset = "0x9C83700", VA = "0x189C84700", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public double NFPFMFLODKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x9C83BF0", Offset = "0x9C82BF0", VA = "0x189C83BF0", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Vector2 LLAPPGIPJLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x9C85210", Offset = "0x9C84210", VA = "0x189C85210", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector2 EMEOFIGGLDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x9C845E0", Offset = "0x9C835E0", VA = "0x189C845E0", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public int LIIGCMOPGBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x9C853F0", Offset = "0x9C843F0", VA = "0x189C853F0", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public double BJFMMFJOGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x9C85E20", Offset = "0x9C84E20", VA = "0x189C85E20", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public double OGMBDKBBFIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x9C85FB0", Offset = "0x9C84FB0", VA = "0x189C85FB0", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public double CAINAEIOLCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x9C85390", Offset = "0x9C84390", VA = "0x189C85390", Slot = "76")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public double NJLEHHMPPDD
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x9C84100", Offset = "0x9C83100", VA = "0x189C84100", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public double MLHJPIJCMLB
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x9C850F0", Offset = "0x9C840F0", VA = "0x189C850F0", Slot = "78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public Texture HBJEDMMPPLO
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x9C85DC0", Offset = "0x9C84DC0", VA = "0x189C85DC0", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public double FNOGKKKEMEG
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x9C85810", Offset = "0x9C84810", VA = "0x189C85810", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public Vector2 KGJEOEOAJBA
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x9C84C00", Offset = "0x9C83C00", VA = "0x189C84C00", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public Vector2 LPAJOCNMNEA
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x9C83E50", Offset = "0x9C82E50", VA = "0x189C83E50", Slot = "82")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public int DDIMGDBNFOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x9C841C0", Offset = "0x9C831C0", VA = "0x189C841C0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public Texture GHCEIONGNFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x9C86010", Offset = "0x9C85010", VA = "0x189C86010", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public double JHIOOHKMOEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x9C84D90", Offset = "0x9C83D90", VA = "0x189C84D90", Slot = "86")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public Vector2 ELIFELKIHLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x9C84AE0", Offset = "0x9C83AE0", VA = "0x189C84AE0", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public Vector2 FKLCCKNNFII
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x9C84E50", Offset = "0x9C83E50", VA = "0x189C84E50", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public int EHKDPPGGLJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x9C84960", Offset = "0x9C83960", VA = "0x189C84960", Slot = "88")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public double BOHEOINOLBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x9C84460", Offset = "0x9C83460", VA = "0x189C84460", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public Texture NFJHMGAANAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x9C85C40", Offset = "0x9C84C40", VA = "0x189C85C40", Slot = "90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public double HIKLBLHCKBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x9C852D0", Offset = "0x9C842D0", VA = "0x189C852D0", Slot = "92")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public Vector2 LJADDAEPBNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x9C84520", Offset = "0x9C83520", VA = "0x189C84520", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public Vector2 HCPMCHPCDPH
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x9C84F10", Offset = "0x9C83F10", VA = "0x189C84F10", Slot = "93")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public int FAJCEFFMJLI
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x9C84CC0", Offset = "0x9C83CC0", VA = "0x189C84CC0", Slot = "94")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public Color OIHHOKLBIOA
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x9C83D20", Offset = "0x9C82D20", VA = "0x189C83D20", Slot = "95")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public Texture AEFEOAEEEMD
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x9C85270", Offset = "0x9C84270", VA = "0x189C85270", Slot = "96")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public double MEFEAFFDOIM
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x9C84C60", Offset = "0x9C83C60", VA = "0x189C84C60", Slot = "98")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector2 AKKEEHPIIKO
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x9C83DF0", Offset = "0x9C82DF0", VA = "0x189C83DF0", Slot = "97")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector2 HGIEOHPFAEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x9C84580", Offset = "0x9C83580", VA = "0x189C84580", Slot = "99")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public int LMOONPGGDCA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x9C85150", Offset = "0x9C84150", VA = "0x189C85150", Slot = "100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public double MBDCJLNGMHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x9C83B30", Offset = "0x9C82B30", VA = "0x189C83B30", Slot = "101")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Texture KBIDIDILEGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x9C83950", Offset = "0x9C82950", VA = "0x189C83950", Slot = "102")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public double CFANPELDHFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x9C85750", Offset = "0x9C84750", VA = "0x189C85750", Slot = "104")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector2 ANJIKODMPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x9C843A0", Offset = "0x9C833A0", VA = "0x189C843A0", Slot = "103")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector2 DLDFJNICEDP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x9C83CC0", Offset = "0x9C82CC0", VA = "0x189C83CC0", Slot = "105")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int CACKEPFANLC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x9C83F80", Offset = "0x9C82F80", VA = "0x189C83F80", Slot = "106")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public double PLONFAHMOGP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x9C83FE0", Offset = "0x9C82FE0", VA = "0x189C83FE0", Slot = "107")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Texture KKCKBJELBOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x9C83B90", Offset = "0x9C82B90", VA = "0x189C83B90", Slot = "108")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public double DJKGPHELECN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x9C85AB0", Offset = "0x9C84AB0", VA = "0x189C85AB0", Slot = "110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public Vector2 DCIPPKPDIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x9C858D0", Offset = "0x9C848D0", VA = "0x189C858D0", Slot = "109")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public Vector2 MJADKPAFOPA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x9C84BA0", Offset = "0x9C83BA0", VA = "0x189C84BA0", Slot = "111")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public int GPMEKDBCOEO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x9C84EB0", Offset = "0x9C83EB0", VA = "0x189C84EB0", Slot = "112")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public float OIBINLGMBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x9C84220", Offset = "0x9C83220", VA = "0x189C84220", Slot = "113")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public float GIOPDDFCDPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x9C85E80", Offset = "0x9C84E80", VA = "0x189C85E80", Slot = "114")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public Color OOEKLAAEAPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x9C83F10", Offset = "0x9C82F10", VA = "0x189C83F10", Slot = "115")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public Texture BPHPBIMEALP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x9C839B0", Offset = "0x9C829B0", VA = "0x189C839B0", Slot = "116")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public double DNJLOGDBFCC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x9C85EE0", Offset = "0x9C84EE0", VA = "0x189C85EE0", Slot = "117")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public Vector2 KGDCILCJLAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x9C846A0", Offset = "0x9C836A0", VA = "0x189C846A0", Slot = "118")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public Vector2 APDIIDOECFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x9C85930", Offset = "0x9C84930", VA = "0x189C85930", Slot = "119")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public int ADJGGKBEHKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x9C85630", Offset = "0x9C84630", VA = "0x189C85630", Slot = "120")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public Texture GCJEFGNDEPH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x9C85870", Offset = "0x9C84870", VA = "0x189C85870", Slot = "121")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public double EFDODGKHHJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x9C84B40", Offset = "0x9C83B40", VA = "0x189C84B40", Slot = "122")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Vector2 MALJHMIHDNA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x9C84900", Offset = "0x9C83900", VA = "0x189C84900", Slot = "123")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public Vector2 OFBJINNPHPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x9C85040", Offset = "0x9C84040", VA = "0x189C85040", Slot = "124")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public int PFHFHJJCFBM
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x9C85D60", Offset = "0x9C84D60", VA = "0x189C85D60", Slot = "125")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public double GGMILDIELPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x9C859F0", Offset = "0x9C849F0", VA = "0x189C859F0", Slot = "131")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public double LLFDHHFKDHL
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x9C85450", Offset = "0x9C84450", VA = "0x189C85450", Slot = "132")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Texture OMAFANBAPPO
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x9C84340", Offset = "0x9C83340", VA = "0x189C84340", Slot = "126")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public double PELKGEDAIGK
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x9C85BE0", Offset = "0x9C84BE0", VA = "0x189C85BE0", Slot = "128")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector2 KENHMCKOPFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x9C85990", Offset = "0x9C84990", VA = "0x189C85990", Slot = "127")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector2 CHLENBPLLGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x9C84A20", Offset = "0x9C83A20", VA = "0x189C84A20", Slot = "129")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public int DNLMJHMJOKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x9C83A70", Offset = "0x9C82A70", VA = "0x189C83A70", Slot = "130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x9C860E0", Offset = "0x9C850E0", VA = "0x189C860E0")]
	public GPKCDOFOEHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x9C86170", Offset = "0x9C85170", VA = "0x189C86170")]
	protected GPKCDOFOEHE(string IHECHONANLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x9C86070", Offset = "0x9C85070", VA = "0x189C86070")]
	public GPKCDOFOEHE(Material LAJKOJDAIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x9C837E0", Offset = "0x9C827E0", VA = "0x189C837E0", Slot = "10")]
	public override BPEOEFBMGHM AABAGJPEDHJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class GNDEJBEBBFI : HBGPKIMECPP, PIAOFMBOKEP, JPPPBCFBFOB, BPEOEFBMGHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	private Vector2 ICNMOFLGKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	private Vector2 NMHIIFCLIFH;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public virtual Texture LDLPELPDJJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x9C833D0", Offset = "0x9C823D0", VA = "0x189C833D0", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public virtual int EAANEHMJMAF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public virtual Vector2 NECPCOHFDNI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x9C835C0", Offset = "0x9C825C0", VA = "0x189C835C0", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public virtual double LDNECLNEKAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public virtual Vector2 CLONJHFGAAP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x9C83530", Offset = "0x9C82530", VA = "0x189C83530", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public virtual int LELHCOBFBAE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "82")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public virtual Color IFHDDMCEKGM
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x9C83750", Offset = "0x9C82750", VA = "0x189C83750", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public virtual Texture GHFPPDIEIBP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x9C83320", Offset = "0x9C82320", VA = "0x189C83320", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public virtual int MHNOGNNHFDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public virtual Vector2 FKNKCPACNHA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x9C834C0", Offset = "0x9C824C0", VA = "0x189C834C0", Slot = "86")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public virtual double IFHGEGGMAPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public virtual Vector2 GJANDFGJOOC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x9C836C0", Offset = "0x9C826C0", VA = "0x189C836C0", Slot = "88")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public virtual int GEDFDPPIGGC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public virtual Vector3 BOHEOINOLBP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x9C83430", Offset = "0x9C82430", VA = "0x189C83430", Slot = "90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public virtual double KPHIJCBJKOF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x9C83630", Offset = "0x9C82630", VA = "0x189C83630", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x9C837C0", Offset = "0x9C827C0", VA = "0x189C837C0")]
	protected GNDEJBEBBFI(string IHECHONANLE, string IDODBPEDLHJ, int PIEFANJNOAH = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x9C7ED90", Offset = "0x9C7DD90", VA = "0x189C7ED90")]
	protected GNDEJBEBBFI(Material DIPAFMFHPBG, int PIEFANJNOAH = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x9C831F0", Offset = "0x9C821F0", VA = "0x189C831F0", Slot = "60")]
	public override BPEOEFBMGHM AABAGJPEDHJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class EKHIOLHLOHE : GNDEJBEBBFI
{
	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public override int HAGCIIGLKDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public override int KIDGEPMEDGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public override int BILJODGCECA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public override int EAANEHMJMAF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public override int MHNOGNNHFDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x9C7EDB0", Offset = "0x9C7DDB0", VA = "0x189C7EDB0")]
	public EKHIOLHLOHE(string IHECHONANLE, int PIEFANJNOAH = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x9C7ED90", Offset = "0x9C7DD90", VA = "0x189C7ED90")]
	protected EKHIOLHLOHE(Material DIPAFMFHPBG, int PIEFANJNOAH = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x9C7EC60", Offset = "0x9C7DC60", VA = "0x189C7EC60", Slot = "60")]
	public override BPEOEFBMGHM AABAGJPEDHJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class HBGPKIMECPP : JPPPBCFBFOB, BPEOEFBMGHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	protected Material GEOHPNLOPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private LEGNKCJJFDB MJPANPHCPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private double FHMLGBICJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private Vector2 CIMIMMHMOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private Vector2 DFCENOAHKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private Vector2 JDDCGDEFNEJ;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public Material AGLIMLFKBOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public virtual Texture EKPBOMCCLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x9C86880", Offset = "0x9C85880", VA = "0x189C86880", Slot = "33")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x9C86960", Offset = "0x9C85960", VA = "0x189C86960", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public virtual int HAGCIIGLKDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public virtual Vector2 DNGEBMADHED
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x9C868F0", Offset = "0x9C858F0", VA = "0x189C868F0", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public virtual double HOOEJPMDEOE
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public virtual Vector2 HAADIFBIPHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x9C87060", Offset = "0x9C86060", VA = "0x189C87060", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public virtual int IPDNEIJCKAL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "39")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public virtual double DLMNNOPPJJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x9C86290", Offset = "0x9C85290", VA = "0x189C86290", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public virtual Texture DOJKBBHGADK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x9C86730", Offset = "0x9C85730", VA = "0x189C86730", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public virtual int KIDGEPMEDGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public virtual Vector2 AGOCEIBDHDB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x9C870F0", Offset = "0x9C860F0", VA = "0x189C870F0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public virtual double OOMAIAJJPEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public virtual Vector2 CKHLJLGHMND
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x9C866A0", Offset = "0x9C856A0", VA = "0x189C866A0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public virtual int NMPIIAJCNDG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public virtual double ENBGOMIAMEO
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x9C865E0", Offset = "0x9C855E0", VA = "0x189C865E0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public virtual Texture HBIDKCMJIHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x9C86350", Offset = "0x9C85350", VA = "0x189C86350", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public virtual int BILJODGCECA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public virtual Vector2 NJLMIBNIIFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x9C86570", Offset = "0x9C85570", VA = "0x189C86570", Slot = "50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public virtual double LBDJGPFHFBO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public virtual Vector2 FBIOLGLCKOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x9C86430", Offset = "0x9C85430", VA = "0x189C86430", Slot = "52")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public virtual int KGAOPNHEMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public virtual Color BBDLEIKMOEN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x9C86F50", Offset = "0x9C85F50", VA = "0x189C86F50", Slot = "54")]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x9C864C0", Offset = "0x9C854C0", VA = "0x189C864C0", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public virtual LEGNKCJJFDB KOBLGAJOLBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x9C86AC0", Offset = "0x9C85AC0", VA = "0x189C86AC0", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public virtual double NKKAKIJCMFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x9C867F0", Offset = "0x9C857F0", VA = "0x189C867F0", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public virtual bool BOGFNIHNNOL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x9C86FF0", Offset = "0x9C85FF0", VA = "0x189C86FF0", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public virtual bool ANLDGLEAENM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x9C86A40", Offset = "0x9C85A40", VA = "0x189C86A40", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x9C87200", Offset = "0x9C86200", VA = "0x189C87200")]
	protected HBGPKIMECPP(string IHECHONANLE, string BIIPIONLMEL, int PIEFANJNOAH = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x9C87370", Offset = "0x9C86370", VA = "0x189C87370")]
	protected HBGPKIMECPP(Material LAJKOJDAIOK, int PIEFANJNOAH = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x9C861E0", Offset = "0x9C851E0", VA = "0x189C861E0", Slot = "60")]
	public virtual BPEOEFBMGHM AABAGJPEDHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x9C87160", Offset = "0x9C86160", VA = "0x189C87160", Slot = "61")]
	protected virtual void PBLMCCENHMO(JPPPBCFBFOB FOIEAAPDPLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface BPEOEFBMGHM
{
	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	Material AGLIMLFKBOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	LEGNKCJJFDB KOBLGAJOLBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	double NKKAKIJCMFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	bool BOGFNIHNNOL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	bool ANLDGLEAENM
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BPEOEFBMGHM AABAGJPEDHJ();
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface JPPPBCFBFOB : BPEOEFBMGHM
{
	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	Texture EKPBOMCCLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	int HAGCIIGLKDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	double DLMNNOPPJJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	Vector2 DNGEBMADHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	double HOOEJPMDEOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	Vector2 HAADIFBIPHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	int IPDNEIJCKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	Texture DOJKBBHGADK
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	int KIDGEPMEDGF
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	double ENBGOMIAMEO
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	Vector2 AGOCEIBDHDB
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	double OOMAIAJJPEA
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	Vector2 CKHLJLGHMND
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	int NMPIIAJCNDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	Texture HBIDKCMJIHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	int BILJODGCECA
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(Slot = "16")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	Color BBDLEIKMOEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(Slot = "18")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	Vector2 NJLMIBNIIFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	double LBDJGPFHFBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(Slot = "20")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	Vector2 FBIOLGLCKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	int KGAOPNHEMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(Slot = "22")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface MIPCKGCEMKO : JPPPBCFBFOB, BPEOEFBMGHM
{
	[Cpp2IlInjected.Token(Token = "0x17000107")]
	Texture EMDKFOLOPOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	int PEEHBLEOPED
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	Vector2 FMCEANENMHN
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	double MLJEOKODGED
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	Vector2 PBBDKHCKHML
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	int KAPFNNKBHPH
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	Color ONHFMPOLHBG
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	Texture CLGEDKKLPIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	int FBCNLGCPKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	Vector2 GAIFBNHNFLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	double KDGLLKHFGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	Vector2 APJMBELLJFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	int CGPLGLCOKJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(Slot = "12")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	double POJLMIGDAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	double IBCMAIBEGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public interface PACFKJOADHB : MIPCKGCEMKO, JPPPBCFBFOB, BPEOEFBMGHM
{
	[Cpp2IlInjected.Token(Token = "0x17000116")]
	double DMFNFCEDAHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	Texture PFCAGONEKON
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	Vector2 BMEKAJECKIG
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	double IPEKCIDDCJP
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	Vector2 OCGNGBLIIPB
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	int AOCOFAJBFME
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	double CHKKOOKIOMF
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	Color GDCPNIGNGPD
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public interface ACHCPLPOMDK : MIPCKGCEMKO, JPPPBCFBFOB, BPEOEFBMGHM
{
	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	double HCHFEMGCAIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	Texture CCPPKNBGEJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	Vector2 LLAPPGIPJLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	double NFPFMFLODKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	Vector2 EMEOFIGGLDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	int LIIGCMOPGBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public interface POOALCDPIDE : MIPCKGCEMKO, JPPPBCFBFOB, BPEOEFBMGHM
{
	[Cpp2IlInjected.Token(Token = "0x17000124")]
	float GIOPDDFCDPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	Color OOEKLAAEAPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	Texture BPHPBIMEALP
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	double DNJLOGDBFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	Vector2 KGDCILCJLAK
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	Vector2 APDIIDOECFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	int ADJGGKBEHKE
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	Texture GCJEFGNDEPH
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	double EFDODGKHHJH
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	Vector2 MALJHMIHDNA
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	Vector2 OFBJINNPHPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	int PFHFHJJCFBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public interface JHJOBMJMHLL : ACHCPLPOMDK, MIPCKGCEMKO, JPPPBCFBFOB, BPEOEFBMGHM
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	float OIBINLGMBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public interface JIMLAFKCFLM : MIPCKGCEMKO, JPPPBCFBFOB, BPEOEFBMGHM
{
	[Cpp2IlInjected.Token(Token = "0x17000131")]
	double BJFMMFJOGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public interface NBDNEPCEENA : MIPCKGCEMKO, JPPPBCFBFOB, BPEOEFBMGHM
{
	[Cpp2IlInjected.Token(Token = "0x17000132")]
	double BOHEOINOLBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	Texture NFJHMGAANAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	Vector2 LJADDAEPBNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	double HIKLBLHCKBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	Vector2 HCPMCHPCDPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	int FAJCEFFMJLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	Color OIHHOKLBIOA
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	Texture AEFEOAEEEMD
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	Vector2 AKKEEHPIIKO
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	double MEFEAFFDOIM
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	Vector2 HGIEOHPFAEK
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	int LMOONPGGDCA
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public interface BOEEGNEIKDK : MIPCKGCEMKO, JPPPBCFBFOB, BPEOEFBMGHM
{
	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	double OGMBDKBBFIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	double CAINAEIOLCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	double NJLEHHMPPDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	double MLHJPIJCMLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	Texture HBJEDMMPPLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	Vector2 KGJEOEOAJBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	double FNOGKKKEMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	Vector2 LPAJOCNMNEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	int DDIMGDBNFOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	Texture GHCEIONGNFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	Vector2 ELIFELKIHLH
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	double JHIOOHKMOEA
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	Vector2 FKLCCKNNFII
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	int EHKDPPGGLJF
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public interface PIAOFMBOKEP : JPPPBCFBFOB, BPEOEFBMGHM
{
	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	Texture LDLPELPDJJA
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	int EAANEHMJMAF
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	Vector2 NECPCOHFDNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	double LDNECLNEKAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	Vector2 CLONJHFGAAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	int LELHCOBFBAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	Color IFHDDMCEKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	Texture GHFPPDIEIBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	int MHNOGNNHFDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	Vector2 FKNKCPACNHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	double IFHGEGGMAPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	Vector2 GJANDFGJOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	int GEDFDPPIGGC
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	Vector3 BOHEOINOLBP
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	double KPHIJCBJKOF
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public interface MGKOEEEOANB : MIPCKGCEMKO, JPPPBCFBFOB, BPEOEFBMGHM
{
	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	double MBDCJLNGMHD
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	Texture KBIDIDILEGN
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	Vector2 ANJIKODMPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	double CFANPELDHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	Vector2 DLDFJNICEDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	int CACKEPFANLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	double PLONFAHMOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	Texture KKCKBJELBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	Vector2 DCIPPKPDIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	double DJKGPHELECN
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	Vector2 MJADKPAFOPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	int GPMEKDBCOEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public interface FPNMDPGGGEN
{
	[Cpp2IlInjected.Token(Token = "0x17000167")]
	Texture EONJHPANOFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	Vector2 DJLLKNLILEC
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	double MAJCGLFNPLL
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	Vector2 ILDNNGCGAFG
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	int GJEMEHBLAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public interface OMONKLPLMJF
{
	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	Texture OMAFANBAPPO
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	Vector2 KENHMCKOPFA
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	double PELKGEDAIGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	Vector2 CHLENBPLLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	int DNLMJHMJOKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	double GGMILDIELPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	double LLFDHHFKDHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public interface KHNMANOJLAJ : BPEOEFBMGHM
{
	[Cpp2IlInjected.Token(Token = "0x17000173")]
	Texture EMDKFOLOPOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	int PEEHBLEOPED
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	Vector2 FMCEANENMHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	double MLJEOKODGED
	{
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	Vector2 PBBDKHCKHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	int KAPFNNKBHPH
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	Color ONHFMPOLHBG
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class PNHOHPMCLIE : BODLAMAKHOO, KHNMANOJLAJ, BPEOEFBMGHM
{
	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x9C90400", Offset = "0x9C8F400", VA = "0x189C90400")]
	public PNHOHPMCLIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x9C90320", Offset = "0x9C8F320", VA = "0x189C90320")]
	protected PNHOHPMCLIE(string IHECHONANLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x9C90390", Offset = "0x9C8F390", VA = "0x189C90390")]
	public PNHOHPMCLIE(Material LAJKOJDAIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x9C90210", Offset = "0x9C8F210", VA = "0x189C90210", Slot = "10")]
	public override BPEOEFBMGHM AABAGJPEDHJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class OHMAIGMPALD : HBGPKIMECPP, KHNMANOJLAJ, BPEOEFBMGHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private Vector2 GENDDPJKLEP;

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public Texture EMDKFOLOPOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x9C8ED80", Offset = "0x9C8DD80", VA = "0x189C8ED80", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public virtual int PEEHBLEOPED
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public virtual Vector2 FMCEANENMHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x9C8ED10", Offset = "0x9C8DD10", VA = "0x189C8ED10", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public virtual double MLJEOKODGED
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public virtual Vector2 PBBDKHCKHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x9C8EE50", Offset = "0x9C8DE50", VA = "0x189C8EE50", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	public virtual int KAPFNNKBHPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	public virtual Color ONHFMPOLHBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x9C8EDE0", Offset = "0x9C8DDE0", VA = "0x189C8EDE0", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x9C89110", Offset = "0x9C88110", VA = "0x189C89110")]
	public OHMAIGMPALD(string IHECHONANLE, string IDODBPEDLHJ, int PIEFANJNOAH = 1000)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class GILOKJEMKCP
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public delegate void FBPEBFFDLBK(OILDJGILLJL IDDFACHJLOD);

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public delegate void FJMDMODOPJD(FJOCBDIEKEE IDDFACHJLOD);

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class FJOCBDIEKEE
	{
		[Cpp2IlInjected.Token(Token = "0x17000183")]
		private Bounds LEPHBLLDALH
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x90FFF00", Offset = "0x90FEF00", VA = "0x1890FFF00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000184")]
		private EEJGCGOJGCD LOOOMCELFGA
		{
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000185")]
		private CNIIHPEFGGP GMAMOKHJKBI
		{
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x9C92AE0", Offset = "0x9C91AE0", VA = "0x189C92AE0")]
		internal FJOCBDIEKEE(Bounds DINFOBEKDOC, EEJGCGOJGCD LNCGGHOFHBA, CNIIHPEFGGP HPAACAMAKIF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class OILDJGILLJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		internal PJHEDOCBNGG.IIDGOKCHBLF DBJOFLEBBIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public float[] JBNGBCCHMII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public object[] JDDHHJMKIPL;

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xD64110", Offset = "0xD63110", VA = "0x180D64110")]
		internal OILDJGILLJL(PJHEDOCBNGG.IIDGOKCHBLF IDFIBMDACFC, float[] JOBOINPBNOA, object[] NCIPNLHDHEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	internal class PJHEDOCBNGG
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		internal class KFOKCJCDFLL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			public string JFNKBOFNMLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			public Type LDHHKGCJCBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			public Func<Transform, UnityEngine.Object> HOACMIKJLMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			public Func<Transform, UnityEngine.Object, PJHEDOCBNGG, object> IHNIMHLAHMG;

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x109CF30", Offset = "0x109BF30", VA = "0x18109CF30")]
			public KFOKCJCDFLL(string JFNKBOFNMLM, Type LDHHKGCJCBM, Func<Transform, UnityEngine.Object> HOACMIKJLMD, Func<Transform, UnityEngine.Object, PJHEDOCBNGG, object> IHNIMHLAHMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x9C96C50", Offset = "0x9C95C50", VA = "0x189C96C50")]
			public object PNKKDLNPAAI(PJHEDOCBNGG INCJDDLACNP)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000098")]
		internal class IIDGOKCHBLF
		{
			[Cpp2IlInjected.Token(Token = "0x2000099")]
			private class MOADPILEKFM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000376")]
				public double JAPNNLNNKKI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000377")]
				public object IOALKPFEKEK;

				[Cpp2IlInjected.Token(Token = "0x60003B7")]
				[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
				public MOADPILEKFM()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			private PJHEDOCBNGG IDFIBMDACFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			private KFOKCJCDFLL OMBKBNHDGFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			private Dictionary<double, object> KNEHCBOFJBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			private MOADPILEKFM OAIPCFNKJBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			private MOADPILEKFM BFEMIPECAEH;

			[Cpp2IlInjected.Token(Token = "0x17000186")]
			public UnityEngine.Object KPIKKFCLPGF
			{
				[Cpp2IlInjected.Token(Token = "0x60003B1")]
				[Cpp2IlInjected.Address(RVA = "0x9C96360", Offset = "0x9C95360", VA = "0x189C96360")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000187")]
			public string JFNKBOFNMLM
			{
				[Cpp2IlInjected.Token(Token = "0x60003B2")]
				[Cpp2IlInjected.Address(RVA = "0x596A8B0", Offset = "0x59698B0", VA = "0x18596A8B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000188")]
			public float[] JOBOINPBNOA
			{
				[Cpp2IlInjected.Token(Token = "0x60003B3")]
				[Cpp2IlInjected.Address(RVA = "0x9C963A0", Offset = "0x9C953A0", VA = "0x189C963A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000189")]
			public object[] NCIPNLHDHEI
			{
				[Cpp2IlInjected.Token(Token = "0x60003B4")]
				[Cpp2IlInjected.Address(RVA = "0x9C96300", Offset = "0x9C95300", VA = "0x189C96300")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x9C96510", Offset = "0x9C95510", VA = "0x189C96510")]
			public IIDGOKCHBLF(PJHEDOCBNGG IDFIBMDACFC, KFOKCJCDFLL OMBKBNHDGFB, double JAPNNLNNKKI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x9C960B0", Offset = "0x9C950B0", VA = "0x189C960B0")]
			public void CBAJPLEIHCJ(double JAPNNLNNKKI)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		internal Transform IDFIBMDACFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private SkinnedMeshRenderer CFNGLDDBAGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private bool DOAOPOIPGAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private bool JHDKJPPCHBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private bool KEFIGBNIJCG;

		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private static List<KFOKCJCDFLL> KAGCKMIGPDM;

		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private static MaterialPropertyBlock FMOALAMGLEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		internal List<IIDGOKCHBLF> NCFILJBKOHK;

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x9C9FDA0", Offset = "0x9C9EDA0", VA = "0x189C9FDA0")]
		public PJHEDOCBNGG(Transform IDFIBMDACFC, double JAPNNLNNKKI, bool BFPMNCECPJD = false, bool DOAOPOIPGAG = true, bool JHDKJPPCHBF = false, bool KEFIGBNIJCG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x9C9FBF0", Offset = "0x9C9EBF0", VA = "0x189C9FBF0")]
		public void PHBANHJIEKG(double JAPNNLNNKKI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	internal ICollection<Transform> CEIAFNENEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private Transform NKBKNNLLHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private Dictionary<Transform, PJHEDOCBNGG> INCJDDLACNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private double NBMPCLDEACH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private double MABAKPNLGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private bool GJEINFLMMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	private bool CBAEICEBENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private readonly bool DOAOPOIPGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	private readonly bool HNFKPBDFIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private readonly bool KEFIGBNIJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public string FJBGAHFFKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public FBPEBFFDLBK LGJPDLPBNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public FJMDMODOPJD DBCCFGGBHCF;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	private static ProfilerMarker JKEJBFBIOEN;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private static ProfilerMarker MBKJCEMMGFJ;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private static ProfilerMarker KOMOKHGICIL;

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	public bool DKCNHLEJKCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x14E9270", Offset = "0x14E8270", VA = "0x1814E9270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	public double LIODHAPOPMM
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x74C4910", Offset = "0x74C3910", VA = "0x1874C4910")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x9C81490", Offset = "0x9C80490", VA = "0x189C81490")]
	public GILOKJEMKCP(Transform NKBKNNLLHKF, bool DOAOPOIPGAG = true, bool HNFKPBDFIHO = false, bool KEFIGBNIJCG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x9C812F0", Offset = "0x9C802F0", VA = "0x189C812F0")]
	private bool OKDIBGMHOFJ(Transform IDFIBMDACFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x9C7FFB0", Offset = "0x9C7EFB0", VA = "0x189C7FFB0")]
	public void EPMIILMBJIM(double JAPNNLNNKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x9C7FCC0", Offset = "0x9C7ECC0", VA = "0x189C7FCC0")]
	public void DHHFGPJNEHD(double JAPNNLNNKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x9C80750", Offset = "0x9C7F750", VA = "0x189C80750")]
	public void MKNBLKFDMAH(string HDCLHHGFDJB, string CINCJCFMCFM = "scene", [Optional] GLTFSettings KGDNAKPKMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x9C808D0", Offset = "0x9C7F8D0", VA = "0x189C808D0")]
	public void MKNBLKFDMAH(Stream PMBDKJADIJM, string CINCJCFMCFM = "scene", [Optional] GLTFSettings KGDNAKPKMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x9C7FAB0", Offset = "0x9C7EAB0", VA = "0x189C7FAB0")]
	private void CKFHJADHPPB(EEJGCGOJGCD LNCGGHOFHBA, CNIIHPEFGGP HPAACAMAKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x9C801F0", Offset = "0x9C7F1F0", VA = "0x189C801F0")]
	private void JCOOJMHCOBA(EEJGCGOJGCD MDJOCFNJONM, PJMIPDFECKP NHHIHMIHDCF, bool KKIEIDAMEAA, [Out] Bounds AGALMEJDKNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public class MCPJCHDPCBD : PlayableBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	private sealed class DPJPFPOOKBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public MCPJCHDPCBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public double time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public Playable playable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public FrameData info;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public object playerData;

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public DPJPFPOOKBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x9C920E0", Offset = "0x9C910E0", VA = "0x189C920E0")]
		internal void OIKLOIJMPKF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400038A")]
	private GILOKJEMKCP BOKMFDOBLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public GLTFRecorderClip OGCFOJHIHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400038C")]
	private bool OCKMADPIPAL;

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x9C98130", Offset = "0x9C97130", VA = "0x189C98130")]
	private void GLOGHLLOEOC(double OIFDFGNECCE, Transform JFOPFLNHKLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x9C980D0", Offset = "0x9C970D0", VA = "0x189C980D0")]
	private void GGKIHDCBLGM(double OIFDFGNECCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x9C98200", Offset = "0x9C97200", VA = "0x189C98200")]
	private void JCFDNFIJKHP(double OIFDFGNECCE, Transform JFOPFLNHKLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0")]
	private static bool BAGDBJFJLHK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x9C98790", Offset = "0x9C97790", VA = "0x189C98790", Slot = "16")]
	public override void OnPlayableDestroy(Playable BHGLGDNBDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x9C98560", Offset = "0x9C97560", VA = "0x189C98560", Slot = "13")]
	public override void OnGraphStart(Playable BHGLGDNBDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x9C986F0", Offset = "0x9C976F0", VA = "0x189C986F0", Slot = "14")]
	public override void OnGraphStop(Playable BHGLGDNBDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x9C98830", Offset = "0x9C97830", VA = "0x189C98830", Slot = "20")]
	public override void ProcessFrame(Playable BHGLGDNBDON, FrameData OGECODCBMEN, object BJEIIPFAAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x24B6E90", Offset = "0x24B5E90", VA = "0x1824B6E90", Slot = "17")]
	public override void OnBehaviourPlay(Playable BHGLGDNBDON, FrameData OGECODCBMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0xD12B60", Offset = "0xD11B60", VA = "0x180D12B60", Slot = "18")]
	public override void OnBehaviourPause(Playable BHGLGDNBDON, FrameData OGECODCBMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x9C98330", Offset = "0x9C97330", VA = "0x189C98330")]
	public void NFGJGEAHDKN(double JAPNNLNNKKI, Playable BHGLGDNBDON, FrameData OGECODCBMEN, object BJEIIPFAAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
	public MCPJCHDPCBD()
	{
	}
}
namespace UnityGLTF.Timeline
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[DisplayName("glTF Recorder Clip")]
	public class GLTFRecorderClip : PlayableAsset, ITimelineClipAsset
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public ExposedReference<Transform> m_exportRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public string m_File;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public string m_AnimationName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public int m_CaptureFrameRate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public bool m_RecordBlendShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		[Tooltip("Enable the KHR_animation_pointer extension. This allows recording material and script properties, but is not supported in all viewers.")]
		public bool m_RecordAnimationPointer;

		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		public ClipCaps clipCaps
		{
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0xD16000", Offset = "0xD15000", VA = "0x180D16000", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(ClipCaps);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x9C95720", Offset = "0x9C94720", VA = "0x189C95720", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph BKGCMOAONFI, GameObject FICFFHNKAMC)
		{
			return default(Playable);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x9C95830", Offset = "0x9C94830", VA = "0x189C95830")]
		public Transform PLEHGOKEPDO(PlayableGraph BKGCMOAONFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x9C95890", Offset = "0x9C94890", VA = "0x189C95890")]
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
		private sealed class DLMILPOEFGD : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			public GLTFRecorderHelper <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700018B")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003E7")]
				[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700018C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003E9")]
				[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0xA5F480", Offset = "0xA5E480", VA = "0x180A5F480")]
			[DebuggerHidden]
			public DLMILPOEFGD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x9C91E50", Offset = "0x9C90E50", VA = "0x189C91E50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x9C92090", Offset = "0x9C91090", VA = "0x189C92090", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private List<Action> DHGHILAADFM;

		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private static GLTFRecorderHelper KLKDHLJDBBB;

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x9C95920", Offset = "0x9C94920", VA = "0x189C95920")]
		public static void Add(Action HCEFPMMOBCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x9C95C60", Offset = "0x9C94C60", VA = "0x189C95C60")]
		private static GLTFRecorderHelper MEFFENIIJAC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x9C95B60", Offset = "0x9C94B60", VA = "0x189C95B60")]
		[IteratorStateMachine(typeof(DLMILPOEFGD))]
		private IEnumerator FIHDKNBJEGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x9C95BE0", Offset = "0x9C94BE0", VA = "0x189C95BE0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x9C95E00", Offset = "0x9C94E00", VA = "0x189C95E00")]
		public GLTFRecorderHelper()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[TrackColor(0.7f, 0f, 0f)]
	[TrackClipType(typeof(GLTFRecorderClip))]
	public class GLTFRecorderTrack : TrackAsset
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x9C95E90", Offset = "0x9C94E90", VA = "0x189C95E90")]
		public GLTFRecorderTrack()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
internal static class ANFAJMEDNGI
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class NGDHIBEGDEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public int primaryComponentCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public NNAKHEJPNEA propertyMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public NECCFLHHOBN pointerDataCopy;

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public NGDHIBEGDEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x9C9DC70", Offset = "0x9C9CC70", VA = "0x189C9DC70")]
		internal float[] DBGBOAJKAAO(NECCFLHHOBN data, int frame)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x9C9DD00", Offset = "0x9C9CD00", VA = "0x189C9DD00")]
		internal float[] GJAEANCJMDD(NECCFLHHOBN data, int frame)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x9C9DBE0", Offset = "0x9C9CBE0", VA = "0x189C9DBE0")]
		internal float[] BPNKODGCLJN(NECCFLHHOBN data, int frame)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x9C9DD90", Offset = "0x9C9CD90", VA = "0x189C9DD90")]
		internal float[] HLGNEAPDJAN(NECCFLHHOBN data, int frame)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	private static readonly string[] FKMNHNINBIO;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	private static readonly string[] PEIFDHHPPLM;

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x9C90DA0", Offset = "0x9C8FDA0", VA = "0x189C90DA0")]
	internal static bool KINGMFCJLGD(string JPMCDANAIOP, OOIENDGMDPE KPKLNLKKGGG, Material JNBIMACAHOC, string NJNINLAANKA, KKFEHMEFPIL JEDNHMHDDAP, [Out] NECCFLHHOBN EBGNGDPKAIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x9C91360", Offset = "0x9C90360", VA = "0x189C91360")]
	internal static string[] NEPLNOEKGFA(string JFNKBOFNMLM, int HCGEHMCFCDI, int MPMCHHHOMJD = 0, bool ADJBFBHEIMK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x9C907B0", Offset = "0x9C8F7B0", VA = "0x189C907B0")]
	internal static float[] FKFMNMALIEO(int HLGKMAPOEBE, int HCGEHMCFCDI, NNAKHEJPNEA JPAPECBEEIF, NECCFLHHOBN EBGNGDPKAIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class NNAKHEJPNEA
{
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public enum OHEJINCMJLP
	{
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		LinearColor,
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		SRGBColor,
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		Texture,
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		LinearTexture,
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		TextureTransform,
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		Float
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public enum LPNFDLNJKGL
	{
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		SameAsPrimary,
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		Override
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public delegate float[] DAIDIOJOOBI(float[] KFPENGKFHFH, float[] GPELPLBHPGI, int GGEDCIFAIEJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public OHEJINCMJLP JNPPOBJDBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public string KLPHFLFMJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public string FGJHDMJNJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public bool KLKFEPGHKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public LPNFDLNJKGL JMHJODAMLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public AGJNLFBCPOB EHPGPHKPMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public bool OIMCCMIFPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public bool JOLCJAEBMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x36")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public bool IJJCIDMOBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public float OLJIFCAKDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public string KLJPGMBHONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public DAIDIOJOOBI CHDNIBAAJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private string[] ALOHJDOPCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	internal int[] IFPEHPOLAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	internal int[] EOKILJHHJKL;

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	public string[] NLPJEMBHBLC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xA631E0", Offset = "0xA621E0", VA = "0x180A631E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x9C9DFC0", Offset = "0x9C9CFC0", VA = "0x189C9DFC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	public bool PJELKEGKAJN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x9C9E1E0", Offset = "0x9C9D1E0", VA = "0x189C9E1E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x9C9E200", Offset = "0x9C9D200", VA = "0x189C9E200")]
	public NNAKHEJPNEA(OHEJINCMJLP ENLLGBMKCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x9C9DE20", Offset = "0x9C9CE20", VA = "0x189C9DE20")]
	private void AGKMEKEEKGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x9C9E090", Offset = "0x9C9D090", VA = "0x189C9E090")]
	private static float[] FJIOMMDKMPN(float[] KFPENGKFHFH, float[] GPELPLBHPGI, int GGEDCIFAIEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x9C9DFF0", Offset = "0x9C9CFF0", VA = "0x189C9DFF0")]
	private void DEKNCAGDEDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class OOIENDGMDPE
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public enum HILOIAHNMHC
	{
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		ImportOnly,
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		ExportOnly,
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		ImportAndExport
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	private Dictionary<string, NNAKHEJPNEA> JOLKPILNNFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	private Dictionary<string, NNAKHEJPNEA> BDKOGPBAEKE;

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x9C9EF60", Offset = "0x9C9DF60", VA = "0x189C9EF60")]
	public void CLEFFHKNHEA(string HBONJLCELAM, string[] DJEKOIPPNLE, [Optional] string HLMOOHDFPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x9C9EB20", Offset = "0x9C9DB20", VA = "0x189C9EB20")]
	public void BEGCLOCHAHA(NNAKHEJPNEA JPAPECBEEIF, HILOIAHNMHC EEDLEJEOMOJ = HILOIAHNMHC.ImportAndExport)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x9C9ED40", Offset = "0x9C9DD40", VA = "0x189C9ED40")]
	public bool BMHLINNJBLL(Material LAJKOJDAIOK, string CAFNAIDNFEI, [Out] NNAKHEJPNEA JPAPECBEEIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x9C9F630", Offset = "0x9C9E630", VA = "0x189C9F630")]
	public bool DPHJKNLNDEI(Material LAJKOJDAIOK, string EIKKIKDMEGK, [Out] string JFNKBOFNMLM, [Out] NNAKHEJPNEA JPAPECBEEIF, [Out] bool BCNKDMGLPNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x9C9FA00", Offset = "0x9C9EA00", VA = "0x189C9FA00")]
	public OOIENDGMDPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public class MJGEEMOMIOA : OOIENDGMDPE
{
	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x9C98980", Offset = "0x9C97980", VA = "0x189C98980")]
	public MJGEEMOMIOA()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public class AnimationPointerExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x1700018F")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x9C91AE0", Offset = "0x9C90AE0", VA = "0x189C91AE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000190")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0x9C91AB0", Offset = "0x9C90AB0", VA = "0x189C91AB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000191")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x9C91A00", Offset = "0x9C90A00", VA = "0x189C91A00", Slot = "14")]
		public override GMHJHFOKIMI KMLAPGGADGC(DBPHECMOGDF IEGLIFIOOBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x153A960", Offset = "0x1539960", VA = "0x18153A960")]
		public AnimationPointerExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public class LBADIHDDKDE : GMHJHFOKIMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public OOIENDGMDPE FJJHLKBAPFN;

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x9C96E50", Offset = "0x9C95E50", VA = "0x189C96E50")]
	public LBADIHDDKDE()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public class AnimationPointerImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000192")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x9C91BF0", Offset = "0x9C90BF0", VA = "0x189C91BF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000193")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x9C91BC0", Offset = "0x9C90BC0", VA = "0x189C91BC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x9C91B10", Offset = "0x9C90B10", VA = "0x189C91B10", Slot = "13")]
		public override BJGLPJBGPPC KMLAPGGADGC(JNADKFAPCEK IEGLIFIOOBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x153A960", Offset = "0x1539960", VA = "0x18153A960")]
		public AnimationPointerImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class KGLBLEENMAC : BJGLPJBGPPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public OOIENDGMDPE FJJHLKBAPFN;

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x9C96CC0", Offset = "0x9C95CC0", VA = "0x189C96CC0")]
	public KGLBLEENMAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[AttributeUsage(AttributeTargets.Class)]
public class HHGMMINJFGO : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public string CFCJBFAKNLE;

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0xA8B7C0", Offset = "0xA8A7C0", VA = "0x180A8B7C0")]
	public HHGMMINJFGO([Optional] string CFCJBFAKNLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[AttributeUsage(AttributeTargets.Class)]
public class HLIIDKLNKKH : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public string CFCJBFAKNLE;

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0xA8B7C0", Offset = "0xA8A7C0", VA = "0x180A8B7C0")]
	public HLIIDKLNKKH([Optional] string CFCJBFAKNLE)
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public abstract class GLTFExportPlugin : GLTFPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000194")]
		public virtual JToken AssetExtras
		{
			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(Slot = "14")]
		public abstract GMHJHFOKIMI KMLAPGGADGC(DBPHECMOGDF IEGLIFIOOBM);

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x153A960", Offset = "0x1539960", VA = "0x18153A960")]
		protected GLTFExportPlugin()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public abstract class GMHJHFOKIMI
{
	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public virtual void AMJBAOFMAAI(EEJGCGOJGCD LNCGGHOFHBA, CNIIHPEFGGP HPAACAMAKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
	public virtual void OOPHHNDAEGJ(EEJGCGOJGCD LNCGGHOFHBA, CNIIHPEFGGP HPAACAMAKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0", Slot = "6")]
	public virtual bool MGMCJPIOPIF(EEJGCGOJGCD LNCGGHOFHBA, CNIIHPEFGGP HPAACAMAKIF, Transform PLPGMCABFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "7")]
	public virtual void IPECIJEIOIO(EEJGCGOJGCD LNCGGHOFHBA, CNIIHPEFGGP HPAACAMAKIF, Transform PLPGMCABFBF, EOEJDHNLIOH ABOLKPCCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "8")]
	public virtual void GLFMIBKLNCM(EEJGCGOJGCD LNCGGHOFHBA, CNIIHPEFGGP HPAACAMAKIF, Transform PLPGMCABFBF, EOEJDHNLIOH ABOLKPCCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "9")]
	public virtual bool GCMNDLLJCDH(EEJGCGOJGCD LNCGGHOFHBA, CNIIHPEFGGP HPAACAMAKIF, Material JNBIMACAHOC, HLAGMJEKLKG MPDMBPBHNNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "10")]
	public virtual void MBFLKCEGKKK(EEJGCGOJGCD LNCGGHOFHBA, CNIIHPEFGGP HPAACAMAKIF, Material JNBIMACAHOC, HLAGMJEKLKG MPDMBPBHNNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "11")]
	public virtual void NHNPHGCBMID(EEJGCGOJGCD LNCGGHOFHBA, EEJGCGOJGCD.HGNPPBKLOMB GHHJBAFAEIA, string CFHCCHPAJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "12")]
	public virtual void PEMGEGHHNJB(EEJGCGOJGCD LNCGGHOFHBA, EEJGCGOJGCD.HGNPPBKLOMB GHHJBAFAEIA, int HLGKMAPOEBE, JPFBMCKMIAL BNBNLOFPBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "13")]
	public virtual void GDEFIHGNEGE(EEJGCGOJGCD LNCGGHOFHBA, Mesh BFBFJIKLAEJ, OHJGEJHMLLK CIMBBBAALLD, int HLGKMAPOEBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "14")]
	public virtual void DCHKIEJFDBF(EEJGCGOJGCD LNCGGHOFHBA, Mesh BFBFJIKLAEJ, IHBCEMMPKLA EPJKFKKONHF, int HLGKMAPOEBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	protected GMHJHFOKIMI()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public abstract class GLTFImportPlugin : GLTFPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(Slot = "13")]
		public abstract BJGLPJBGPPC KMLAPGGADGC(JNADKFAPCEK IEGLIFIOOBM);

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x153A960", Offset = "0x1539960", VA = "0x18153A960")]
		protected GLTFImportPlugin()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public abstract class BJGLPJBGPPC
{
	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public virtual void LGNMJMDGKHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
	public virtual void EICAIIHNJAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "6")]
	public virtual void BLOAIGDJNDC(CNIIHPEFGGP HPAACAMAKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "7")]
	public virtual void BMIGCAJEDAJ(EJGANAMIGAK KJIOEGBKNOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "8")]
	public virtual void AHMJLKAIMMI(EOEJDHNLIOH ABOLKPCCJOL, int KJEACKDADJM, GameObject OOJEEGFLMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "9")]
	public virtual void PGLLDEKOCDM(HLAGMJEKLKG JNBIMACAHOC, int IFGMJLPFAMJ, Material OIHOJAILALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "10")]
	public virtual void KHBLPNPBBIP(JPFBMCKMIAL GHHJBAFAEIA, int AGBFMKONNGG, Texture FCDHAOANOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "11")]
	public virtual void LFHLMGMKLLE(EJGANAMIGAK KJIOEGBKNOL, int MAENJMKCDDI, GameObject BKPEODADMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	protected BJGLPJBGPPC()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public abstract class GLTFPlugin : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		[SerializeField]
		[HideInInspector]
		private bool enabled;

		[Cpp2IlInjected.Token(Token = "0x17000195")]
		public abstract string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000196")]
		public virtual string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000197")]
		public virtual string HelpUrl
		{
			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000198")]
		public virtual bool Enabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0x9C95700", Offset = "0x9C94700", VA = "0x189C95700", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0xA69F60", Offset = "0xA68F60", VA = "0x180A69F60", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		public virtual bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		public virtual bool AlwaysEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		public virtual string Warning
		{
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		public virtual bool PackageMissing
		{
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x153A960", Offset = "0x1539960", VA = "0x18153A960")]
		protected GLTFPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[Obsolete("Use UnityGLTF.Plugins.GLTFPlugin instead. (UnityUpgradable) -> UnityGLTF.Plugins.GLTFPlugin")]
	public abstract class GltfPlugin : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0xCF9400", Offset = "0xCF8400", VA = "0x180CF9400")]
		protected GltfPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[Obsolete("Use UnityGLTF.Plugins.GLTFImportPlugin instead. (UnityUpgradable) -> UnityGLTF.Plugins.GLTFImportPlugin")]
	public abstract class GltfImportPlugin : GltfPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xCF9400", Offset = "0xCF8400", VA = "0x180CF9400")]
		protected GltfImportPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[Obsolete("Use UnityGLTF.Plugins.GLTFExportPlugin instead. (UnityUpgradable) -> UnityGLTF.Plugins.GLTFExportPlugin")]
	public abstract class GltfExportPlugin : GltfPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0xCF9400", Offset = "0xCF8400", VA = "0x180CF9400")]
		protected GltfExportPlugin()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public class JNADKFAPCEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public readonly List<BJGLPJBGPPC> JCAGDIANMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public OBGDAHNJGCJ JBKHNOBBHOL;

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	public CNIIHPEFGGP AOHAMHAHFAH
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x9C96BF0", Offset = "0x9C95BF0", VA = "0x189C96BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x9C969D0", Offset = "0x9C959D0", VA = "0x189C969D0")]
	private List<BJGLPJBGPPC> GJDMINNLMIL(GLTFSettings KGDNAKPKMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x9C96C10", Offset = "0x9C95C10", VA = "0x189C96C10")]
	internal JNADKFAPCEK(GLTFSettings KGDNAKPKMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x3CF0EC0", Offset = "0x3CEFEC0", VA = "0x183CF0EC0")]
	public bool HLKGHJDNJEL<T>([Out] T FOIEAAPDPLJ) where T : BJGLPJBGPPC
	{
		return default(bool);
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public class DracoImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0x9C921E0", Offset = "0x9C911E0", VA = "0x189C921E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0x9C921B0", Offset = "0x9C911B0", VA = "0x189C921B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A0")]
		public override bool PackageMissing
		{
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x9C92160", Offset = "0x9C91160", VA = "0x189C92160", Slot = "13")]
		public override BJGLPJBGPPC KMLAPGGADGC(JNADKFAPCEK IEGLIFIOOBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x153A960", Offset = "0x1539960", VA = "0x18153A960")]
		public DracoImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public class JKFHMFEMDAL : BJGLPJBGPPC
{
	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public JKFHMFEMDAL()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public class GPUInstancingImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001A1")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0x9C95F60", Offset = "0x9C94F60", VA = "0x189C95F60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A2")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(RVA = "0x9C95F30", Offset = "0x9C94F30", VA = "0x189C95F30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x9C95EE0", Offset = "0x9C94EE0", VA = "0x189C95EE0", Slot = "13")]
		public override BJGLPJBGPPC KMLAPGGADGC(JNADKFAPCEK IEGLIFIOOBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x153A960", Offset = "0x1539960", VA = "0x18153A960")]
		public GPUInstancingImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public class DIHHCEOEGIL : BJGLPJBGPPC
{
	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public DIHHCEOEGIL()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public class Ktx2Import : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001A3")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000449")]
			[Cpp2IlInjected.Address(RVA = "0x9C96E20", Offset = "0x9C95E20", VA = "0x189C96E20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A4")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0x9C96DF0", Offset = "0x9C95DF0", VA = "0x189C96DF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A5")]
		public override bool PackageMissing
		{
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x9C96DA0", Offset = "0x9C95DA0", VA = "0x189C96DA0", Slot = "13")]
		public override BJGLPJBGPPC KMLAPGGADGC(JNADKFAPCEK IEGLIFIOOBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x153A960", Offset = "0x1539960", VA = "0x18153A960")]
		public Ktx2Import()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public class GJHNNIAHPMF : BJGLPJBGPPC
{
	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public GJHNNIAHPMF()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public class LightsPunctualExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001A6")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0x9C97E90", Offset = "0x9C96E90", VA = "0x189C97E90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A7")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x9C97E60", Offset = "0x9C96E60", VA = "0x189C97E60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x9C97E10", Offset = "0x9C96E10", VA = "0x189C97E10", Slot = "14")]
		public override GMHJHFOKIMI KMLAPGGADGC(DBPHECMOGDF IEGLIFIOOBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x153A960", Offset = "0x1539960", VA = "0x18153A960")]
		public LightsPunctualExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public class CJEKFHDBFJE : GMHJHFOKIMI
{
	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "8")]
	public override void GLFMIBKLNCM(EEJGCGOJGCD LNCGGHOFHBA, CNIIHPEFGGP HPAACAMAKIF, Transform PLPGMCABFBF, EOEJDHNLIOH ABOLKPCCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public CJEKFHDBFJE()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public class LightsPunctualImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001A8")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0x9C97F40", Offset = "0x9C96F40", VA = "0x189C97F40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A9")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x9C97F10", Offset = "0x9C96F10", VA = "0x189C97F10", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x9C97EC0", Offset = "0x9C96EC0", VA = "0x189C97EC0", Slot = "13")]
		public override BJGLPJBGPPC KMLAPGGADGC(JNADKFAPCEK IEGLIFIOOBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x153A960", Offset = "0x1539960", VA = "0x18153A960")]
		public LightsPunctualImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public class MDDOLMNEKOJ : BJGLPJBGPPC
{
	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public MDDOLMNEKOJ()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[HHGMMINJFGO(null)]
	public class LodsExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0x9C97FF0", Offset = "0x9C96FF0", VA = "0x189C97FF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0x9C97FC0", Offset = "0x9C96FC0", VA = "0x189C97FC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x9C97F70", Offset = "0x9C96F70", VA = "0x189C97F70", Slot = "14")]
		public override GMHJHFOKIMI KMLAPGGADGC(DBPHECMOGDF IEGLIFIOOBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x153A960", Offset = "0x1539960", VA = "0x18153A960")]
		public LodsExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public class MNIGPCMBPJL : GMHJHFOKIMI
{
	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x9C9D540", Offset = "0x9C9C540", VA = "0x189C9D540", Slot = "8")]
	public override void GLFMIBKLNCM(EEJGCGOJGCD LNCGGHOFHBA, CNIIHPEFGGP GGJNHNJNFJD, Transform PLPGMCABFBF, EOEJDHNLIOH ABOLKPCCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public MNIGPCMBPJL()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[HHGMMINJFGO(null)]
	public class LodsImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000460")]
			[Cpp2IlInjected.Address(RVA = "0x9C980A0", Offset = "0x9C970A0", VA = "0x189C980A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0x9C98070", Offset = "0x9C97070", VA = "0x189C98070", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x9C98020", Offset = "0x9C97020", VA = "0x189C98020", Slot = "13")]
		public override BJGLPJBGPPC KMLAPGGADGC(JNADKFAPCEK IEGLIFIOOBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x153A960", Offset = "0x1539960", VA = "0x18153A960")]
		public LodsImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public class FGBADEHIELK : BJGLPJBGPPC
{
	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public FGBADEHIELK()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	public class MaterialExtensionsExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public bool KHR_materials_ior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public bool KHR_materials_transmission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public bool KHR_materials_volume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public bool KHR_materials_iridescence;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public bool KHR_materials_specular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public bool KHR_materials_clearcoat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public bool KHR_materials_emissive_strength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public bool KHR_materials_sheen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public bool KHR_materials_anisotropy;

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0x9C9DA10", Offset = "0x9C9CA10", VA = "0x189C9DA10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0x9C9D9E0", Offset = "0x9C9C9E0", VA = "0x189C9D9E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x9C9D950", Offset = "0x9C9C950", VA = "0x189C9D950", Slot = "14")]
		public override GMHJHFOKIMI KMLAPGGADGC(DBPHECMOGDF IEGLIFIOOBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x9C9D9C0", Offset = "0x9C9C9C0", VA = "0x189C9D9C0")]
		public MaterialExtensionsExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public class FKFEAKOPCEK : GMHJHFOKIMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	internal readonly MaterialExtensionsExport KGDNAKPKMMC;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private static readonly int COLDJHKDNNE;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private static readonly int DEPEIGCOPNK;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private static readonly int AELDAFGOCGF;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	private static readonly int MDHIOHACMKB;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	private static readonly int DJGLCDDPOIO;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	private static readonly int IGCIJJDMOJJ;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	private static readonly int CCCFIOIMLBN;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	private static readonly int MBKIHLFPIBJ;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	private static readonly int GPPIDCAMFMN;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	private static readonly int GLOEGNJKGFD;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	private static readonly int NJJGFGNNLBG;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	private static readonly int JEJGBDAJPBL;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	private static readonly int LACLLEPDPOJ;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	private static readonly int NBOMGELFBIK;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	private static readonly int PFOHLEOOHLM;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	private static readonly int KOKCEECAJEG;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	private static readonly int IIFDIDBJNNA;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	private static readonly int EAIAHCGBGON;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	private static readonly int PJKANOEPJHK;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	private static readonly int IDCMCEMLLEK;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	private static readonly int EJKDIOANMPM;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	private static readonly int KLEAHKPJCFM;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	private static readonly int DCJDEIEABLA;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	private static readonly int IEPJNFMDPFJ;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	private static readonly int IDOMHIMKOPL;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	private static readonly int MPJGLHADBID;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	private static readonly int GJGBIJJPCAP;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	private static readonly int GGMILDIELPM;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	private static readonly int LLFDHHFKDHL;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	private static readonly int OMAFANBAPPO;

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0xA6BBE0", Offset = "0xA6ABE0", VA = "0x180A6BBE0")]
	public FKFEAKOPCEK(MaterialExtensionsExport KGDNAKPKMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x9C92B50", Offset = "0x9C91B50", VA = "0x189C92B50", Slot = "10")]
	public override void MBFLKCEGKKK(EEJGCGOJGCD LNCGGHOFHBA, CNIIHPEFGGP GGJNHNJNFJD, Material JNBIMACAHOC, HLAGMJEKLKG IJHPBLNHHBM)
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public class MaterialExtensionsImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public bool KHR_materials_ior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public bool KHR_materials_transmission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public bool KHR_materials_volume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public bool KHR_materials_iridescence;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public bool KHR_materials_specular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public bool KHR_materials_clearcoat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public bool KHR_materials_sheen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		[HideInInspector]
		public bool KHR_materials_pbrSpecularGlossiness;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public bool KHR_materials_emissive_strength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public bool KHR_materials_anisotropy;

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0x9C9DB00", Offset = "0x9C9CB00", VA = "0x189C9DB00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0x9C9DAD0", Offset = "0x9C9CAD0", VA = "0x189C9DAD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x9C9DA40", Offset = "0x9C9CA40", VA = "0x189C9DA40", Slot = "13")]
		public override BJGLPJBGPPC KMLAPGGADGC(JNADKFAPCEK IEGLIFIOOBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x9C9DAB0", Offset = "0x9C9CAB0", VA = "0x189C9DAB0")]
		public MaterialExtensionsImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class PMLNEDCKEBA : BJGLPJBGPPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	internal readonly MaterialExtensionsImport KGDNAKPKMMC;

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0xA6BBE0", Offset = "0xA6ABE0", VA = "0x180A6BBE0")]
	public PMLNEDCKEBA(MaterialExtensionsImport IOHFIJOMFNM)
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public class MeshoptImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0x9C9DBB0", Offset = "0x9C9CBB0", VA = "0x189C9DBB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0x9C9DB80", Offset = "0x9C9CB80", VA = "0x189C9DB80", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		public override bool PackageMissing
		{
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x9C9DB30", Offset = "0x9C9CB30", VA = "0x189C9DB30", Slot = "13")]
		public override BJGLPJBGPPC KMLAPGGADGC(JNADKFAPCEK IEGLIFIOOBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x153A960", Offset = "0x1539960", VA = "0x18153A960")]
		public MeshoptImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public class OILMKNNJNNC : BJGLPJBGPPC
{
	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public OILMKNNJNNC()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public class TextureTransformExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0x9CA0CD0", Offset = "0x9C9FCD0", VA = "0x189CA0CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0x9CA0CA0", Offset = "0x9C9FCA0", VA = "0x189CA0CA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		public override bool AlwaysEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000479")]
			[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "14")]
		public override GMHJHFOKIMI KMLAPGGADGC(DBPHECMOGDF IEGLIFIOOBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x153A960", Offset = "0x1539960", VA = "0x18153A960")]
		public TextureTransformExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public class TextureTransformImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001B8")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(RVA = "0x9CA0D30", Offset = "0x9C9FD30", VA = "0x189CA0D30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B9")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600047D")]
			[Cpp2IlInjected.Address(RVA = "0x9CA0D00", Offset = "0x9C9FD00", VA = "0x189CA0D00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		public override bool AlwaysEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x600047E")]
			[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "13")]
		public override BJGLPJBGPPC KMLAPGGADGC(JNADKFAPCEK IEGLIFIOOBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x153A960", Offset = "0x1539960", VA = "0x18153A960")]
		public TextureTransformImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public class UnlitMaterialsExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001BB")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000481")]
			[Cpp2IlInjected.Address(RVA = "0x9CA1C90", Offset = "0x9CA0C90", VA = "0x189CA1C90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000482")]
			[Cpp2IlInjected.Address(RVA = "0x9CA1C60", Offset = "0x9CA0C60", VA = "0x189CA1C60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		public override bool AlwaysEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000483")]
			[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "14")]
		public override GMHJHFOKIMI KMLAPGGADGC(DBPHECMOGDF IEGLIFIOOBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x153A960", Offset = "0x1539960", VA = "0x18153A960")]
		public UnlitMaterialsExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public class UnlitMaterialsImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001BE")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000486")]
			[Cpp2IlInjected.Address(RVA = "0x9CA1CF0", Offset = "0x9CA0CF0", VA = "0x189CA1CF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000487")]
			[Cpp2IlInjected.Address(RVA = "0x9CA1CC0", Offset = "0x9CA0CC0", VA = "0x189CA1CC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		public override bool AlwaysEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "13")]
		public override BJGLPJBGPPC KMLAPGGADGC(JNADKFAPCEK IEGLIFIOOBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x153A960", Offset = "0x1539960", VA = "0x18153A960")]
		public UnlitMaterialsImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public class VisibilityExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001C1")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600048B")]
			[Cpp2IlInjected.Address(RVA = "0x9CA1D50", Offset = "0x9CA0D50", VA = "0x189CA1D50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C2")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600048C")]
			[Cpp2IlInjected.Address(RVA = "0x9CA1D20", Offset = "0x9CA0D20", VA = "0x189CA1D20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C3")]
		public override bool AlwaysEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "14")]
		public override GMHJHFOKIMI KMLAPGGADGC(DBPHECMOGDF IEGLIFIOOBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x153A960", Offset = "0x1539960", VA = "0x18153A960")]
		public VisibilityExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public class VisibilityImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0x9CA1DB0", Offset = "0x9CA0DB0", VA = "0x189CA1DB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000492")]
			[Cpp2IlInjected.Address(RVA = "0x9CA1D80", Offset = "0x9CA0D80", VA = "0x189CA1D80", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		public override bool AlwaysEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000493")]
			[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "13")]
		public override BJGLPJBGPPC KMLAPGGADGC(JNADKFAPCEK IEGLIFIOOBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x153A960", Offset = "0x1539960", VA = "0x18153A960")]
		public VisibilityImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public class APGIOLJFHOM
{
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	internal class PKFKAHLKHPG : MemoryStream
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public readonly string LKIHJEMNIMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public readonly string FAJOPJFBBAL;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public interface AGCDJCAHHLN
{
	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<Stream> KNBDEKOLMBJ(string CONHGGCBFPF);
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public interface EAOPNGNAJJC : AGCDJCAHHLN
{
	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Stream AEGKOEPDLDP(string CONHGGCBFPF);
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[Obsolete("Please switch to IDataLoader.  This interface is deprecated and will be removed in a future release.")]
public interface EKHNEEONEEL
{
	[Cpp2IlInjected.Token(Token = "0x170001C8")]
	Stream NALKCAAFCMA
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	bool IJJOPLPJHBI
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task AEGKOEPDLDP(string CONHGGCBFPF);

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BBAGIKOABFL(string EANHPKMBIHH);
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public static class IHKLGNACGFA
{
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	private class LOEECGLHDKI : AGCDJCAHHLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		protected readonly EKHNEEONEEL FLDIMOKDAMA;

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0xA6BBE0", Offset = "0xA6ABE0", VA = "0x180A6BBE0")]
		public LOEECGLHDKI(EKHNEEONEEL NCOMCOONIGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x9C97CF0", Offset = "0x9C96CF0", VA = "0x189C97CF0", Slot = "4")]
		public Task<Stream> KNBDEKOLMBJ(string CONHGGCBFPF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	private class MLMBOLJJPPJ : LOEECGLHDKI, EAOPNGNAJJC, AGCDJCAHHLN
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0xA6BBE0", Offset = "0xA6ABE0", VA = "0x180A6BBE0")]
		public MLMBOLJJPPJ(EKHNEEONEEL NCOMCOONIGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x9C9D460", Offset = "0x9C9C460", VA = "0x189C9D460", Slot = "5")]
		public Stream AEGKOEPDLDP(string CONHGGCBFPF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x9C95F90", Offset = "0x9C94F90", VA = "0x189C95F90")]
	public static AGCDJCAHHLN PECBJBGLKMB(EKHNEEONEEL NCOMCOONIGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public class DAJPKKCOPGN : AGCDJCAHHLN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private struct FCCFEAKGFCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public AsyncTaskMethodBuilder<Stream> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public DAJPKKCOPGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public string relativeFilePath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		private string <path>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		private UnityWebRequest <request>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		private UnityWebRequestAsyncOperation <asyncOperation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x9C92340", Offset = "0x9C91340", VA = "0x189C92340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x9C92A70", Offset = "0x9C91A70", VA = "0x189C92A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	private string IHKIBPHMOEF;

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0xA6BBE0", Offset = "0xA6ABE0", VA = "0x180A6BBE0")]
	public DAJPKKCOPGN(string IHKIBPHMOEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x9C91D20", Offset = "0x9C90D20", VA = "0x189C91D20", Slot = "4")]
	[AsyncStateMachine(typeof(FCCFEAKGFCJ))]
	public Task<Stream> KNBDEKOLMBJ(string CONHGGCBFPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public class LDDEJGGJEJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	private readonly List<ENPCMBDPIJO> DCICEHDODEC;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	private static readonly ProfilerMarker KBOHMFIEKDF;

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x9C97A50", Offset = "0x9C96A50", VA = "0x189C97A50")]
	public void DOPEKGIEJEC(ENPCMBDPIJO NHHIHMIHDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x9C96ED0", Offset = "0x9C95ED0", VA = "0x189C96ED0")]
	public void CHIILPDEIKN(EEJGCGOJGCD LNCGGHOFHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x9C97B60", Offset = "0x9C96B60", VA = "0x189C97B60")]
	public LDDEJGGJEJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public interface IGOJLJPNMOC
{
	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CDJLEHFBKCD(object AOJAHPGAGPO, string AIPDNDCFPID);
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public struct EIELBNJIGNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public KKFEHMEFPIL DGLJDCBGKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public KKFEHMEFPIL GLBLKJLMPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public CLMIMDMFHPB NINGHMOODGF;
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public class KMBOGHLAKHA
{
	[Cpp2IlInjected.Token(Token = "0x170001CA")]
	public AnimationClip ECEADNIHGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CB")]
	public EIELBNJIGNO[] EMOOECOGDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x9C96D40", Offset = "0x9C95D40", VA = "0x189C96D40")]
	public KMBOGHLAKHA(int HBLBDNMPGEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public class JEPENAPKLKO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001CC")]
	public Stream[] BGJBPJEGJKB
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CD")]
	public Texture2D[] KGGPGKJKGCH
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CE")]
	public Texture2D[] GCBBKFHLFAI
	{
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CF")]
	public FMDMNBABBNB[] ADHEKIBEMPD
	{
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D0")]
	public LKGJKIJHMAM[] JIOFABHPBLL
	{
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D1")]
	public DJGAAPLKBNG[] CHBLDPCCDOE
	{
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0xA68420", Offset = "0xA67420", VA = "0x180A68420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D2")]
	public PDBDAJFPPBL[] CLFCPGJNFOK
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0xA66F70", Offset = "0xA65F70", VA = "0x180A66F70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0xA674F0", Offset = "0xA664F0", VA = "0x180A674F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D3")]
	public AGDPDPGJEPB[] NHEBADAMOPP
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0xA683E0", Offset = "0xA673E0", VA = "0x180A683E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0xA68520", Offset = "0xA67520", VA = "0x180A68520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D4")]
	public KMBOGHLAKHA[] HIFLDNENJJO
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0xA631E0", Offset = "0xA621E0", VA = "0x180A631E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0xA631D0", Offset = "0xA621D0", VA = "0x180A631D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D5")]
	public GameObject[] FKIJKOLJPLC
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0xA63170", Offset = "0xA62170", VA = "0x180A63170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0xA631B0", Offset = "0xA621B0", VA = "0x180A631B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x9C966F0", Offset = "0x9C956F0", VA = "0x189C966F0")]
	public JEPENAPKLKO(CNIIHPEFGGP NKBKNNLLHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x9C965E0", Offset = "0x9C955E0", VA = "0x189C965E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public class DJGAAPLKBNG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001D6")]
	public uint IGNFDMLHFFC
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		[CompilerGenerated]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D7")]
	public Stream EMLKKGDGGAN
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D8")]
	public NativeArray<byte> BLFJFNJCFJA
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0xE60260", Offset = "0xE5F260", VA = "0x180E60260")]
		[CompilerGenerated]
		get
		{
			return default(NativeArray<byte>);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0xF3B430", Offset = "0xF3A430", VA = "0x180F3B430")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x702D810", Offset = "0x702C810", VA = "0x18702D810", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public DJGAAPLKBNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
internal static class NKKOCFKLHFK
{
	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0xF1F780", Offset = "0xF1E780", VA = "0x180F1F780")]
	public static bool KOIIDCDEAJE(UnityEngine.Object JIJOLLBNLFE, string FABCICCGGJJ, [Out] byte[] ODOOLGJOBIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520")]
	public static void NOABMLHCIDL(UnityEngine.Object JIJOLLBNLFE, string FABCICCGGJJ, byte[] ODOOLGJOBIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public class LKGJKIJHMAM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001D9")]
	public Material KJNHFDDMJHO
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DA")]
	public Material IEBKAELLHGO
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DB")]
	public HLAGMJEKLKG COAMPNGMMJD
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x9C97BF0", Offset = "0x9C96BF0", VA = "0x189C97BF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public LKGJKIJHMAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public class PDBDAJFPPBL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public class EPHDHJOPOIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public bool EGOFGKPPCCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public Dictionary<string, KKFEHMEFPIL> ACOKGNEHMEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public List<Dictionary<string, KKFEHMEFPIL>> FKMKCBFHJDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public Dictionary<string, (KKFEHMEFPIL sparseIndices, KKFEHMEFPIL sparseValues)> MNNNFLOPGGJ;

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x9C92210", Offset = "0x9C91210", VA = "0x189C92210")]
		public EPHDHJOPOIJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public List<EPHDHJOPOIJ> HLKNALOGMID;

	[Cpp2IlInjected.Token(Token = "0x170001DC")]
	public Mesh LHNMKBBGFOK
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x9C9FAC0", Offset = "0x9C9EAC0", VA = "0x189C9FAC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x9C9FB60", Offset = "0x9C9EB60", VA = "0x189C9FB60")]
	public PDBDAJFPPBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public class OFHCNPCLCIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000427")]
	private bool CIIOLODFDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000428")]
	private int PNEJFOBMFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000429")]
	private readonly object IGOOPNFDKNG;

	[Cpp2IlInjected.Token(Token = "0x170001DD")]
	public PDBDAJFPPBL[] CLFCPGJNFOK
	{
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DE")]
	public UnityEngine.Object[] EHKHMFKKMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DF")]
	public LKGJKIJHMAM[] JIOFABHPBLL
	{
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E0")]
	public FMDMNBABBNB[] ADHEKIBEMPD
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0xA68420", Offset = "0xA67420", VA = "0x180A68420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E1")]
	public KMBOGHLAKHA[] HIFLDNENJJO
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0xA66F70", Offset = "0xA65F70", VA = "0x180A66F70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0xA674F0", Offset = "0xA664F0", VA = "0x180A674F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E2")]
	public Texture2D[] KGGPGKJKGCH
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0xA683E0", Offset = "0xA673E0", VA = "0x180A683E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0xA68520", Offset = "0xA67520", VA = "0x180A68520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x9C9EA10", Offset = "0x9C9DA10", VA = "0x189C9EA10")]
	public OFHCNPCLCIF(LKGJKIJHMAM[] JGPENKCPCAN, PDBDAJFPPBL[] NNMECFNHHPN, FMDMNBABBNB[] MPKOHJHFBBE, Texture2D[] ENKHHACCDED, KMBOGHLAKHA[] OLINCFILBLN, UnityEngine.Object[] IPONFJGKFMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x9C9E920", Offset = "0x9C9D920", VA = "0x189C9E920")]
	public void OBLGAEIBMEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x9C9E7C0", Offset = "0x9C9D7C0", VA = "0x189C9E7C0")]
	public void NPIOPGGOHHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x9C9E3D0", Offset = "0x9C9D3D0", VA = "0x189C9E3D0")]
	private void MAACGKEGLFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public class FMDMNBABBNB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public JPFBMCKMIAL DBOIPBAOOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public Texture2D AHAKDEILDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public bool NLCGAOPIJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public bool AOPOLIDMJFH;

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x9C95660", Offset = "0x9C94660", VA = "0x189C95660", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public FMDMNBABBNB()
	{
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
