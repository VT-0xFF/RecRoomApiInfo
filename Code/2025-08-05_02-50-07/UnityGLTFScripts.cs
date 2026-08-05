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
		private struct IOHACJCDIDH : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x9D9DD30", Offset = "0x9D9D130", VA = "0x189D9DD30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9D9DF20", Offset = "0x9D9D320", VA = "0x189D9DF20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class FFHGANIOCBI : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
			[DebuggerHidden]
			public FFHGANIOCBI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9D9B860", Offset = "0x9D9AC60", VA = "0x189D9B860", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9D9B8E0", Offset = "0x9D9ACE0", VA = "0x189D9B8E0", Slot = "8")]
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
		private WaitForEndOfFrame DKLBMBFCNAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private float MOECLJLMDPI;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9D99870", Offset = "0x9D98C70", VA = "0x189D99870")]
		[AsyncStateMachine(typeof(IOHACJCDIDH))]
		public Task YieldOnTimeout()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9D997E0", Offset = "0x9D98BE0", VA = "0x189D997E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D99760", Offset = "0x9D98B60", VA = "0x189D99760")]
		[IteratorStateMachine(typeof(FFHGANIOCBI))]
		private IEnumerator FDCOJONBANH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9D99940", Offset = "0x9D98D40", VA = "0x189D99940")]
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
		private struct BHJEHHMMAOG : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x9D999C0", Offset = "0x9D98DC0", VA = "0x189D999C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xAC9F20", Offset = "0xAC9320", VA = "0x180AC9F20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private struct BMFKBNBDDCC : IAsyncStateMachine
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
			private LBEJPCLLNNC <importOptions>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private KNDCPNFIJBM <sceneImporter>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9D99EB0", Offset = "0x9D992B0", VA = "0x189D99EB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x9D9ABB0", Offset = "0x9D99FB0", VA = "0x189D9ABB0", Slot = "5")]
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
		private int HJJDLICCDPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int MaximumLod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int Timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public KNDCPNFIJBM.IEDNMJMDHLC Collider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private Shader shaderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[Header("Import Settings")]
		public MJEKKNDMJOM TextureCompression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public EIMDIMFPGMH ImportNormals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public EIMDIMFPGMH ImportTangents;

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
		public IEnumerable<Animation> BCCEMLIDPNG
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA702C0", Offset = "0xA6F6C0", VA = "0x180A702C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public GameObject EGIJGCJKKJN
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA74030", Offset = "0xA73430", VA = "0x180A74030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA74020", Offset = "0xA73420", VA = "0x180A74020")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Shader CBONDAHEFDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xA70440", Offset = "0xA6F840", VA = "0x180A70440")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x9D9D020", Offset = "0x9D9C420", VA = "0x189D9D020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9D9CF00", Offset = "0x9D9C300", VA = "0x189D9CF00")]
		[AsyncStateMachine(typeof(BHJEHHMMAOG))]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9D9CE30", Offset = "0x9D9C230", VA = "0x189D9CE30")]
		[AsyncStateMachine(typeof(BMFKBNBDDCC))]
		public Task Load()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9D9CD40", Offset = "0x9D9C140", VA = "0x189D9CD40")]
		public void ApplyOverrideShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1029C00", Offset = "0x1029000", VA = "0x181029C00")]
		private void BGCLFAKOJDI(GameObject DEJGDIIDCDN, ExceptionDispatchInfo JMIMDLMIFKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9D9CFB0", Offset = "0x9D9C3B0", VA = "0x189D9CFB0")]
		public GLTFComponent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class GLTFRecorderComponent : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class MNLFEMEBMBF : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
			[DebuggerHidden]
			public MNLFEMEBMBF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9DABEE0", Offset = "0x9DAB2E0", VA = "0x189DABEE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x9DABFB0", Offset = "0x9DAB3B0", VA = "0x189DABFB0", Slot = "8")]
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
		protected KJPEIALEBKA AKGENALANDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public UnityEvent recordingStarted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public UnityEvent<string> recordingEnded;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool BACDCAMCLAH
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9D9D870", Offset = "0x9D9CC70", VA = "0x189D9D870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private double BIEHOGNMPFB
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x9D9D280", Offset = "0x9D9C680", VA = "0x189D9D280")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D300", Offset = "0x9D9C700", VA = "0x189D9D300", Slot = "4")]
		[ContextMenu("Start Recording")]
		public virtual void StartRecording()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D6A0", Offset = "0x9D9CAA0", VA = "0x189D9D6A0", Slot = "5")]
		[ContextMenu("Stop Recording")]
		public virtual void StopRecording()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D050", Offset = "0x9D9C450", VA = "0x189D9D050")]
		private void FNLGFMDDMEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D610", Offset = "0x9D9CA10", VA = "0x189D9D610")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D2E0", Offset = "0x9D9C6E0", VA = "0x189D9D2E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D290", Offset = "0x9D9C690", VA = "0x189D9D290", Slot = "6")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D230", Offset = "0x9D9C630", VA = "0x189D9D230", Slot = "7")]
		protected virtual void GEAEMFMFAMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D1B0", Offset = "0x9D9C5B0", VA = "0x189D9D1B0")]
		[IteratorStateMachine(typeof(MNLFEMEBMBF))]
		private IEnumerator DBDGDCHHPGG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D7A0", Offset = "0x9D9CBA0", VA = "0x189D9D7A0")]
		public GLTFRecorderComponent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D050", Offset = "0x9D9C450", VA = "0x189D9D050")]
		[CompilerGenerated]
		private void CKBCKLJILKB(InputAction.CallbackContext PCKIEOGDDCF)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class OOOLKIAIIAN
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal class PPEJNDMMENA : DOPOEHGBNMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly OOOLKIAIIAN OLKAHDEBPIG;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA99B00", Offset = "0xA98F00", VA = "0x180A99B00")]
		internal PPEJNDMMENA(OOOLKIAIIAN HFJHENFIDEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9DAEA30", Offset = "0x9DADE30", VA = "0x189DAEA30", Slot = "4")]
		public override void CLJGGLIODMN(CENIKCKFPGL HAIJNNMMFMM, PMNJJNLALOI NGJGEBLCKFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9DAECC0", Offset = "0x9DAE0C0", VA = "0x189DAECC0", Slot = "5")]
		public override void PNAFJOGCKMC(CENIKCKFPGL HAIJNNMMFMM, PMNJJNLALOI NGJGEBLCKFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9DAEA70", Offset = "0x9DADE70", VA = "0x189DAEA70", Slot = "8")]
		public override void FOFLGJKJPFI(CENIKCKFPGL HAIJNNMMFMM, PMNJJNLALOI NGJGEBLCKFB, Transform GANAIKEBLIG, FIPHLEDNLPF BLJBPFHLMML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9DAEAF0", Offset = "0x9DADEF0", VA = "0x189DAEAF0", Slot = "9")]
		public override bool GKEAJOHNDBK(CENIKCKFPGL HAIJNNMMFMM, PMNJJNLALOI NGJGEBLCKFB, Material GMFBEMFEGJH, INLMCJFCOPF ANBGNMOFNEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9DAEC40", Offset = "0x9DAE040", VA = "0x189DAEC40", Slot = "10")]
		public override void KJIFEILAPIN(CENIKCKFPGL HAIJNNMMFMM, PMNJJNLALOI NGJGEBLCKFB, Material GMFBEMFEGJH, INLMCJFCOPF ANBGNMOFNEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9DAEC80", Offset = "0x9DAE080", VA = "0x189DAEC80", Slot = "11")]
		public override void PIJBIMOFLGE(CENIKCKFPGL HAIJNNMMFMM, CENIKCKFPGL.FNIFBJIKCDJ IOFLDLKHGCB, string KNNFDFCLOKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE9C0", Offset = "0x9DADDC0", VA = "0x189DAE9C0", Slot = "12")]
		public override void ACNJNFGJJEJ(CENIKCKFPGL HAIJNNMMFMM, CENIKCKFPGL.FNIFBJIKCDJ IOFLDLKHGCB, int NOEININIMIL, KGHMDFPAGCC MEMLPMCKIJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9DAEAB0", Offset = "0x9DADEB0", VA = "0x189DAEAB0", Slot = "13")]
		public override void GICGDBAHDFL(CENIKCKFPGL HAIJNNMMFMM, Mesh NIKBNBLEJEO, NENMAJLCAIO BBJELFHBAMM, int NOEININIMIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9DAEC00", Offset = "0x9DAE000", VA = "0x189DAEC00", Slot = "14")]
		public override void IFNFCMBJFIM(CENIKCKFPGL HAIJNNMMFMM, Mesh NIKBNBLEJEO, IOHOGCBKNJA COIFEIMFCGJ, int NOEININIMIL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public bool AELPOABFPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public LayerMask BJEGGPAMCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public ILogger JFOJLBDGNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal readonly GLTFSettings FKBCJNJEHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public CENIKCKFPGL.PGLDFBKNPDO ONHCIJNAKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public CENIKCKFPGL.AEANPPDNFBN PNAFJOGCKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public CENIKCKFPGL.LLNHFLFKHAD CLJGGLIODMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public CENIKCKFPGL.MALHACMLGBE FOFLGJKJPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public CENIKCKFPGL.POBPBJIBIBC GKEAJOHNDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public CENIKCKFPGL.PABNKANBPHC KJIFEILAPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public CENIKCKFPGL.CLJDNPBDOLN PIJBIMOFLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public CENIKCKFPGL.ECLCOJPEAFB ACNJNFGJJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public CENIKCKFPGL.ELIKOAILLME GICGDBAHDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public CENIKCKFPGL.HDMOBBLIOHL IFNFCMBJFIM;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x9DAE550", Offset = "0x9DAD950", VA = "0x189DAE550")]
	public OOOLKIAIIAN(GLTFSettings FKBCJNJEHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x9DAE4E0", Offset = "0x9DAD8E0", VA = "0x189DAE4E0")]
	internal DOPOEHGBNMC PBPINOLGBKP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class CENIKCKFPGL
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate string PGLDFBKNPDO(Texture IOFLDLKHGCB);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public delegate void LLNHFLFKHAD(CENIKCKFPGL HAIJNNMMFMM, PMNJJNLALOI NGJGEBLCKFB);

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate void AEANPPDNFBN(CENIKCKFPGL HAIJNNMMFMM, PMNJJNLALOI NGJGEBLCKFB);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate void MALHACMLGBE(CENIKCKFPGL HAIJNNMMFMM, PMNJJNLALOI NGJGEBLCKFB, Transform GANAIKEBLIG, FIPHLEDNLPF BLJBPFHLMML);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate bool POBPBJIBIBC(CENIKCKFPGL HAIJNNMMFMM, PMNJJNLALOI NGJGEBLCKFB, Material GMFBEMFEGJH, INLMCJFCOPF ANBGNMOFNEL);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void PABNKANBPHC(CENIKCKFPGL HAIJNNMMFMM, PMNJJNLALOI NGJGEBLCKFB, Material GMFBEMFEGJH, INLMCJFCOPF ANBGNMOFNEL);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void CLJDNPBDOLN(CENIKCKFPGL HAIJNNMMFMM, FNIFBJIKCDJ IOFLDLKHGCB, string KNNFDFCLOKN);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public delegate void ECLCOJPEAFB(CENIKCKFPGL HAIJNNMMFMM, FNIFBJIKCDJ IOFLDLKHGCB, int NOEININIMIL, KGHMDFPAGCC MEMLPMCKIJB);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public delegate void ELIKOAILLME(CENIKCKFPGL HAIJNNMMFMM, Mesh NIKBNBLEJEO, NENMAJLCAIO BBJELFHBAMM, int NOEININIMIL);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate void HDMOBBLIOHL(CENIKCKFPGL HAIJNNMMFMM, Mesh NIKBNBLEJEO, IOHOGCBKNJA COIFEIMFCGJ, int NOEININIMIL);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class NJAHAGCIFNM : DOPOEHGBNMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD7D0", Offset = "0x9DACBD0", VA = "0x189DAD7D0", Slot = "5")]
		public override void PNAFJOGCKMC(CENIKCKFPGL HAIJNNMMFMM, PMNJJNLALOI NGJGEBLCKFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD4B0", Offset = "0x9DAC8B0", VA = "0x189DAD4B0", Slot = "4")]
		public override void CLJGGLIODMN(CENIKCKFPGL HAIJNNMMFMM, PMNJJNLALOI NGJGEBLCKFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD530", Offset = "0x9DAC930", VA = "0x189DAD530", Slot = "8")]
		public override void FOFLGJKJPFI(CENIKCKFPGL HAIJNNMMFMM, PMNJJNLALOI NGJGEBLCKFB, Transform GANAIKEBLIG, FIPHLEDNLPF BLJBPFHLMML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD5D0", Offset = "0x9DAC9D0", VA = "0x189DAD5D0", Slot = "9")]
		public override bool GKEAJOHNDBK(CENIKCKFPGL HAIJNNMMFMM, PMNJJNLALOI NGJGEBLCKFB, Material GMFBEMFEGJH, INLMCJFCOPF ANBGNMOFNEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD730", Offset = "0x9DACB30", VA = "0x189DAD730", Slot = "10")]
		public override void KJIFEILAPIN(CENIKCKFPGL HAIJNNMMFMM, PMNJJNLALOI NGJGEBLCKFB, Material GMFBEMFEGJH, INLMCJFCOPF ANBGNMOFNEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
		public NJAHAGCIFNM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct IOEIDMMCKGL
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public enum OKGPEBIHFIH
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
		public enum HNKNEBCAOPN
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
		public bool FFOMBOPIAHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public OKGPEBIHFIH GONJKJDACDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public HNKNEBCAOPN HLNGNIBFIIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool MNOBIPGDMGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public float LCKNEHKDDDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public float AKLFDKJJHKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public float OHCAPAAFCIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public float BCKOEJIJGAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public float GIBEPPAAPKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public float FFBGDHCIGHA;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x9D9DCF0", Offset = "0x9D9D0F0", VA = "0x189D9DCF0")]
		public IOEIDMMCKGL(IOEIDMMCKGL NHDOFIDIKGL)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9D9DCB0", Offset = "0x9D9D0B0", VA = "0x189D9DCB0")]
		public static bool ILMCFLMCOJH(IOEIDMMCKGL KEHFCBFJCMA, IOEIDMMCKGL KGECIONKOCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9D9DBD0", Offset = "0x9D9CFD0", VA = "0x189D9DBD0")]
		public bool HELOPPPCEGA(IOEIDMMCKGL LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9D9DA00", Offset = "0x9D9CE00", VA = "0x189D9DA00", Slot = "0")]
		public override bool Equals(object DEJGDIIDCDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9D9DAB0", Offset = "0x9D9CEB0", VA = "0x189D9DAB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private struct NAPLHGLDMJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Texture2D IOFLDLKHGCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public IOEIDMMCKGL IMGNEMENFGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public string FAELHOCGCGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public bool DKNBAKDEPCK;
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private struct AIDOJPMAJAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Stream GBHJNKNIPGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public string MFPLLLAAENM;
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct FNIFBJIKCDJ : IEquatable<FNIFBJIKCDJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Texture HGHKHPLOOBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public int JKJFPAOHKFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public IOEIDMMCKGL MHDBEBHADEP;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BC90", Offset = "0x9D9B090", VA = "0x189D9BC90")]
		public int JIFBHGKPHCB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9D9B930", Offset = "0x9D9AD30", VA = "0x189D9B930")]
		public int EHNBFIFJGBI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BCD0", Offset = "0x9D9B0D0", VA = "0x189D9BCD0")]
		public FNIFBJIKCDJ(Texture MEMLPMCKIJB, string KNNFDFCLOKN, CENIKCKFPGL HAIJNNMMFMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BD80", Offset = "0x9D9B180", VA = "0x189D9BD80")]
		public FNIFBJIKCDJ(Texture MEMLPMCKIJB, IOEIDMMCKGL KAPPAFACKML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BA30", Offset = "0x9D9AE30", VA = "0x189D9BA30", Slot = "4")]
		public bool Equals(FNIFBJIKCDJ LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9D9B970", Offset = "0x9D9AD70", VA = "0x189D9B970", Slot = "0")]
		public override bool Equals(object DEJGDIIDCDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BBF0", Offset = "0x9D9AFF0", VA = "0x189D9BBF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct OHACIEGFEKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Mesh GEGAOALOAKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Material[] HHEAKEOKMNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public SkinnedMeshRenderer EOOMPGCKANB;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE280", Offset = "0x9DAD680", VA = "0x189DAE280")]
		public bool HELOPPPCEGA(OHACIEGFEKO LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE080", Offset = "0x9DAD480", VA = "0x189DAE080", Slot = "0")]
		public override bool Equals(object DEJGDIIDCDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE130", Offset = "0x9DAD530", VA = "0x189DAE130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private struct EOGMJLGGMOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public IBIHMHAHFHN OACCMODGGLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public IBIHMHAHFHN IAGCBLMKHML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public IBIHMHAHFHN GKGBLPFPAJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public IBIHMHAHFHN JAJELIFDCJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public IBIHMHAHFHN MGGFDJKBFHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public IBIHMHAHFHN HAFNOBGNHNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public IBIHMHAHFHN CHBKEKMGOEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public IBIHMHAHFHN BKMOGNGKCFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public IBIHMHAHFHN OBIPHANNEFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public Dictionary<int, NENMAJLCAIO> MGCEBONIFFH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct JDCAKIFBHKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public List<Dictionary<string, IBIHMHAHFHN>> KIBNCDDDBLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public List<double> PGNNPOLJBOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public List<string> PIEJJDNHODC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		internal SkinnedMeshRenderer MHHACKCOGNL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct DJFEEMDDNPE : IEquatable<DJFEEMDDNPE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly TextureWrapMode GHPFEJJEKFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly FilterMode MEDKNMLOIBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly bool BMFEHIFBAIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly bool HNHFFIIMIPG;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool LCLHCNGONGB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xE62630", Offset = "0xE61A30", VA = "0x180E62630")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool ADNIDHEPDGG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x72CC240", Offset = "0x72CB640", VA = "0x1872CC240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9D9AEB0", Offset = "0x9D9A2B0", VA = "0x189D9AEB0")]
		public DJFEEMDDNPE(Texture IOFLDLKHGCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9D9ADD0", Offset = "0x9D9A1D0", VA = "0x189D9ADD0", Slot = "4")]
		public bool Equals(DJFEEMDDNPE LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9D9AD10", Offset = "0x9D9A110", VA = "0x189D9AD10", Slot = "0")]
		public override bool Equals(object DEJGDIIDCDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9D9AE00", Offset = "0x9D9A200", VA = "0x189D9AE00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class JDBLBDJMPKM : IEnumerable<(int, NENMAJLCAIO)>, IEnumerable, IEnumerator<(int, NENMAJLCAIO)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private (int subMeshIndex, NENMAJLCAIO prim) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public CENIKCKFPGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private Mesh mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Mesh <>3__mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private Dictionary<int, NENMAJLCAIO>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private (int, NENMAJLCAIO) System.Collections.Generic.IEnumerator<(System.Int32subMeshIndex,GLTF.Schema.MeshPrimitiveprim)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xD45140", Offset = "0xD44540", VA = "0x180D45140", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((int, NENMAJLCAIO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x9D9EBC0", Offset = "0x9D9DFC0", VA = "0x189D9EBC0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x291E530", Offset = "0x291D930", VA = "0x18291E530")]
		[DebuggerHidden]
		public JDBLBDJMPKM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9D9EC10", Offset = "0x9D9E010", VA = "0x189D9EC10", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9D9E7E0", Offset = "0x9D9DBE0", VA = "0x189D9E7E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9D9E790", Offset = "0x9D9DB90", VA = "0x189D9E790")]
		private void DKMCMBPCGHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9D9EB70", Offset = "0x9D9DF70", VA = "0x189D9EB70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9D9EAB0", Offset = "0x9D9DEB0", VA = "0x189D9EAB0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(int, NENMAJLCAIO)> System.Collections.Generic.IEnumerable<(System.Int32subMeshIndex,GLTF.Schema.MeshPrimitiveprim)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9D9EAB0", Offset = "0x9D9DEB0", VA = "0x189D9EAB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class DIAOCDGIBLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public bool convertToLinearColor;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public DIAOCDGIBLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x9D9AC10", Offset = "0x9D9A010", VA = "0x189D9AC10")]
		internal Color DLLPELCKBAI(object e)
		{
			return default(Color);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class KAAJDKFKPFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public float multiplier;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public KAAJDKFKPFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9D9ECA0", Offset = "0x9D9E0A0", VA = "0x189D9ECA0")]
		internal float NJNJMNGHBBG(object e)
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static ILogger IFAPBMPKCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private List<DOPOEHGBNMC> DMGEEABKIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private Transform[] NLECAAMBHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private PMNJJNLALOI JANIGEANJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private BJOAALABNMG HFJOKCPDICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private ADJNLGCIMOG LHJEDJIFOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private List<NAPLHGLDMJL> IIIINGCJEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private HashSet<string> CNDGENGHHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private List<AIDOJPMAJAL> BPILIPIJIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private HashSet<string> JOKJODHEKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<FNIFBJIKCDJ> AOAFPCKGBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private Dictionary<int, int> IBIEHJPHNMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private bool FCCLMDMDEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private Dictionary<int, int> JPNJJCOHPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private List<Transform> FJCONFDNBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private int KNAIIKFHJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private OOOLKIAIIAN OLKAHDEBPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private Material CMNPEKOEPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private Material FIEHNAFLEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private Material JPGODPMMAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private bool MNCHGNMJGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<OHACIEGFEKO, DONCFGCPOKC> MCGLAPGPCEK;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static ProfilerMarker LFKAOPJJOKD;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static ProfilerMarker AJBLBOPOKBI;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static ProfilerMarker LOHOPPFCFAA;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static ProfilerMarker PHMHAAFGCBL;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static ProfilerMarker GGABFLNIHMB;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static ProfilerMarker DGFOHEEOKBK;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static ProfilerMarker NJAFPGAJDOG;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static ProfilerMarker FDCIGPBBJBD;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static ProfilerMarker JLNGCPEBBPF;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static ProfilerMarker MFAIECJDJME;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static ProfilerMarker CNDPGACJNAH;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static ProfilerMarker HCNBEHKECEM;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static ProfilerMarker LBEGPEBICLL;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static ProfilerMarker FLNBIOJHDAP;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static ProfilerMarker DBECPDILBMH;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static ProfilerMarker JGCMILPLJDH;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static ProfilerMarker JDHDICJEBJB;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static ProfilerMarker IDOOPAAKIIM;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static ProfilerMarker EJAEKHECNAE;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static ProfilerMarker IENCAKDINLL;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static ProfilerMarker KDAEDHCNBDG;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static ProfilerMarker IDHFEFGMNJO;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static ProfilerMarker EAJDEPMBKDI;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static ProfilerMarker GPAECDNMKBJ;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static ProfilerMarker OGMAKMIEHAJ;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static ProfilerMarker PMEJPDIIOIN;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static ProfilerMarker NECOKJADDIM;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static ProfilerMarker FMKELLNMFBD;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private static ProfilerMarker MFEEFFHCJIA;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static ProfilerMarker CNJFCKNHCDE;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static ProfilerMarker OKOCCAIDLCB;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static ProfilerMarker FHNACLONONL;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static ProfilerMarker CAIANCBCIKJ;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static ProfilerMarker KEFAEJDKPHD;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private static ProfilerMarker EGBCPBPIALA;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static ProfilerMarker HBPPECHDHLC;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static ProfilerMarker FHIGLCICGHF;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static ProfilerMarker EFADBKLADPC;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static ProfilerMarker OFFKIGBIBJI;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private static ProfilerMarker GPGIPAEPHNG;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static ProfilerMarker IPBCELPOOJL;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static ProfilerMarker FCCINDADGJG;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static ProfilerMarker HJPOPICDPAC;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static ProfilerMarker JBGJEBNPHHM;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private static ProfilerMarker EPCGCCKEMMC;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static ProfilerMarker DIMGAJHJABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private global::DCLCOJGFLAD CGFIKOCLBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool? EEGNNLKHPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	internal readonly List<DINENABICMC> MKBBBJPKELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly AHGCJGEADIO EDPGIJHELKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Dictionary<int, int> NNBIOGJDEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Dictionary<int, int> KJDFCCCLKIM;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	[CompilerGenerated]
	private static LLNHFLFKHAD CLJGGLIODMN;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[CompilerGenerated]
	private static AEANPPDNFBN PNAFJOGCKMC;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	[CompilerGenerated]
	private static MALHACMLGBE FOFLGJKJPFI;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[CompilerGenerated]
	private static POBPBJIBIBC GKEAJOHNDBK;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[CompilerGenerated]
	private static PABNKANBPHC KJIFEILAPIN;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static Material JKJJPODDJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private HashSet<Material> GGEAHMKDAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly Dictionary<Mesh, EOGMJLGGMOI> NBPGMJEENGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly Dictionary<Mesh, JDCAKIFBHKL> ALNIJBLDFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly Dictionary<SkinnedMeshRenderer, List<double>> LLOIMNEDFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private List<Transform> OHPOBAKKCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Dictionary<SkinnedMeshRenderer, Mesh> OLJMMDKPBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Dictionary<DJFEEMDDNPE, int> MABMODOEBIJ;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyList<Transform> IIJDHIKDFLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private GLTFSettings FKBCJNJEHBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9D89210", Offset = "0x9D88610", VA = "0x189D89210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private bool JFIOJKODKHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9D966A0", Offset = "0x9D95AA0", VA = "0x189D966A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private bool EMAMMJMPINA
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9D93410", Offset = "0x9D92810", VA = "0x189D93410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private bool EMOKFIIAPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9D935D0", Offset = "0x9D929D0", VA = "0x189D935D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static Material JFJEDAOECCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9D7C600", Offset = "0x9D7BA00", VA = "0x189D7C600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x9D93110", Offset = "0x9D92510", VA = "0x189D93110")]
	public IOEIDMMCKGL NFCIJNOHEND(string KNNFDFCLOKN)
	{
		return default(IOEIDMMCKGL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x9D86290", Offset = "0x9D85690", VA = "0x189D86290")]
	private Material GGEPEFNLIID(IOEIDMMCKGL IMGNEMENFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x9D85530", Offset = "0x9D84930", VA = "0x189D85530")]
	private static Material EFOCBBEKFBO(Material GMFBEMFEGJH, IOEIDMMCKGL IMGNEMENFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x9D97CE0", Offset = "0x9D970E0", VA = "0x189D97CE0")]
	public CENIKCKFPGL(Transform[] OJPOIKACKPM, OOOLKIAIIAN HFJHENFIDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x9D88640", Offset = "0x9D87A40", VA = "0x189D88640")]
	public void HOFBKCGJLJC(Stream GBHJNKNIPGA, string CGAJOJLBJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x9D89040", Offset = "0x9D88440", VA = "0x189D89040")]
	public void IENMBMIDJJC(string BJNAOAPMOAJ, bool JPCDFIOEMMI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x9D8BD80", Offset = "0x9D8B180", VA = "0x189D8BD80")]
	private bool JHNAAAOBFJN(Transform GANAIKEBLIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x9D88010", Offset = "0x9D87410", VA = "0x189D88010")]
	private AEMPHJEDMDN HKAFPJILKEB(string HDNPPEBJPAE, Transform[] LKNEJGIJBJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x9D8AD40", Offset = "0x9D8A140", VA = "0x189D8AD40")]
	private ECEFENKLINI JCMPAPIBFIJ(Transform DMDMPADAANG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x9D966D0", Offset = "0x9D95AD0", VA = "0x189D966D0")]
	private static bool PHAIPECIKCM(GameObject JBJNKCGNJKP, bool PMGNBMGMNHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x9D940E0", Offset = "0x9D934E0", VA = "0x189D940E0")]
	private void OEFDKLPDOFB(Transform GANAIKEBLIG, [Out] GameObject[] JJPCACLOGCO, [Out] GameObject[] PPGMGPGEOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x9D94340", Offset = "0x9D93740", VA = "0x189D94340")]
	private void OFANLCMEOMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x9D85E40", Offset = "0x9D85240", VA = "0x189D85E40")]
	public MLOKFFHMMHG FKLNKNMMKPL(PMNJJNLALOI LDEPDDDHLLO, Material ANHEEJNNBEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x9D7E9E0", Offset = "0x9D7DDE0", VA = "0x189D7E9E0")]
	public BOCMKGHCPPL BGJFMGNKMAE(PMNJJNLALOI LDEPDDDHLLO, FNIFBJIKCDJ PLCPEKBJBPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x9D828E0", Offset = "0x9D81CE0", VA = "0x189D828E0")]
	public FPMLCOMKFOM CNMOMKGOKDG(PMNJJNLALOI LDEPDDDHLLO, Texture AIHKEKODBHI, IOEIDMMCKGL IMGNEMENFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x9D884A0", Offset = "0x9D878A0", VA = "0x189D884A0")]
	private static void HKAGMLAMLAF(Stream MICKAKKPGLH, BinaryWriter AHGBOFMNHGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x9D88570", Offset = "0x9D87970", VA = "0x189D88570")]
	private static void HKLMNHDGGHE(Stream GBHJNKNIPGA, byte GFMIOAHJEBB = 32, uint ALMIGFMMMEJ = 4u)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x9D89020", Offset = "0x9D88420", VA = "0x189D89020")]
	public static uint IAJGCFFAODD(uint PFBENPHKCGL, uint AOBALFAGJNE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x9D93770", Offset = "0x9D92B70", VA = "0x189D93770")]
	private IBIHMHAHFHN NNFKJCJGJOD(Vector4[] OLEJLIDKEEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x9D7CB20", Offset = "0x9D7BF20", VA = "0x189D7CB20")]
	private IBIHMHAHFHN BCJCIAEKPAG(Quaternion[] OLEJLIDKEEL, bool PMFJFGMNKHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x9D80520", Offset = "0x9D7F920", VA = "0x189D80520")]
	private IBIHMHAHFHN CIOGNFOOJGC(Matrix4x4[] OLEJLIDKEEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x9D81C20", Offset = "0x9D81020", VA = "0x189D81C20")]
	private IBIHMHAHFHN CIOGNFOOJGC(float[] OLEJLIDKEEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x9D7FDD0", Offset = "0x9D7F1D0", VA = "0x189D7FDD0")]
	private IBIHMHAHFHN CIOGNFOOJGC(int[] OLEJLIDKEEL, bool KOKNIBBNBKA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x9D81590", Offset = "0x9D80990", VA = "0x189D81590")]
	private IBIHMHAHFHN CIOGNFOOJGC(Vector2[] OLEJLIDKEEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x9D7ED40", Offset = "0x9D7E140", VA = "0x189D7ED40")]
	private IBIHMHAHFHN CIOGNFOOJGC(Vector3[] OLEJLIDKEEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x9D8E0E0", Offset = "0x9D8D4E0", VA = "0x189D8E0E0")]
	private IBIHMHAHFHN KCFAGGFIKCA(IBIHMHAHFHN IGPAEDINCFK, Vector3[] AAGLBNPOLLF, Vector3[] OLEJLIDKEEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x9D7F490", Offset = "0x9D7E890", VA = "0x189D7F490")]
	private IBIHMHAHFHN CIOGNFOOJGC(Vector4[] OLEJLIDKEEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x9D809C0", Offset = "0x9D7FDC0", VA = "0x189D809C0")]
	private IBIHMHAHFHN CIOGNFOOJGC(Color[] OLEJLIDKEEL, bool INDAFMCBHPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x9D961C0", Offset = "0x9D955C0", VA = "0x189D961C0")]
	private JKKOFFJEIDG PBNAHIIFLOK(uint AOJAECCDFED, uint OAKIIMLHCHI, uint IMLJMIMBCDJ = 0u)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
	public void PMHDFOLOKDP(Transform GANAIKEBLIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x9D96350", Offset = "0x9D95750", VA = "0x189D96350")]
	internal int PCCPKEHPMJF(object DEJGDIIDCDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x9D95BE0", Offset = "0x9D94FE0", VA = "0x189D95BE0")]
	public int OPOPDMBKPEC(Transform GANAIKEBLIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x9D85D80", Offset = "0x9D85180", VA = "0x189D85D80")]
	public int FAHGPIIJGEJ(Material AMAOJDGFJIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x9D92910", Offset = "0x9D91D10", VA = "0x189D92910")]
	public int MLKPCKMICHP(Light JDNHGEMKEDG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x9D88F60", Offset = "0x9D88360", VA = "0x189D88F60")]
	public int HPOOAFOEMHE(Camera OFIEAEEOPFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x9D96940", Offset = "0x9D95D40", VA = "0x189D96940")]
	[IteratorStateMachine(typeof(JDBLBDJMPKM))]
	public IEnumerable<(int, NENMAJLCAIO)> PIJJBGCBCOE(Mesh NIKBNBLEJEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x9D7EB70", Offset = "0x9D7DF70", VA = "0x189D7EB70")]
	private static void BNOGOPBBNIB(Color MICKAKKPGLH, [Out] Color AHGBOFMNHGN, [Out] float BHCOBPFFKLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x9D8FBD0", Offset = "0x9D8EFD0", VA = "0x189D8FBD0")]
	private static void KIGICJKFLLC(Vector4 MICKAKKPGLH, [Out] Vector2 MJHAIBCGLLD, [Out] Vector2 FDIDNNCIDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x9D93440", Offset = "0x9D92840", VA = "0x189D93440")]
	private bool NMFAIKINLDH(object[] LMLCJEFLFMP, int DICKFINAKEH, int PFJAMDDHAHN, int MDHDMNAFMPD, int JHOOBJNFEEE, int DLIALLIKDMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x9D89560", Offset = "0x9D88960", VA = "0x189D89560")]
	public void INOFKPKDIAL(float[] HALABAAPLEK, object[] EJCCOPPBIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x9D82B80", Offset = "0x9D81F80", VA = "0x189D82B80")]
	public void EFBCADOOHHI(UnityEngine.Object EIMHDDKMIGJ, string MDDEFFMKGMP, HKPHIBPBAKP EFAFCAIAEHO, float[] HALABAAPLEK, object[] EJCCOPPBIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x9D92350", Offset = "0x9D91750", VA = "0x189D92350")]
	private void LIINPCNFCJK(object EIMHDDKMIGJ, string MDDEFFMKGMP, HKMBKPFFLMN NJJNDJLGDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x9D929D0", Offset = "0x9D91DD0", VA = "0x189D929D0")]
	private JGIMMKHNMKL MNLDKLGOEPD(Camera NAAFKKODMKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x9D86DD0", Offset = "0x9D861D0", VA = "0x189D86DD0")]
	private OIGANJHOCLK GLPFOOGJHGK(Light JGNNPOCGDKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x9D8FE00", Offset = "0x9D8F200", VA = "0x189D8FE00")]
	public MLOKFFHMMHG LFBOHIPNEEE(Material ANHEEJNNBEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x9D89230", Offset = "0x9D88630", VA = "0x189D89230")]
	private MLOKFFHMMHG INELLEEDFJF(Material ANHEEJNNBEH, INLMCJFCOPF GMFBEMFEGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x9D87530", Offset = "0x9D86930", VA = "0x189D87530")]
	private bool GPPAOABPPPD(Material GMFBEMFEGJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x9D85A10", Offset = "0x9D84E10", VA = "0x189D85A10")]
	private bool EMGHOKIEJJN(Material GMFBEMFEGJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x9D94070", Offset = "0x9D93470", VA = "0x189D94070")]
	private bool ODOGHJAIHED(Material GMFBEMFEGJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x9D82840", Offset = "0x9D81C40", VA = "0x189D82840")]
	private bool CJFMHEHFHDD(Material GMFBEMFEGJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x9D8FC00", Offset = "0x9D8F000", VA = "0x189D8FC00")]
	private static bool KLDOAGABCMF(Shader COPKOKBBIPN, string HDNPPEBJPAE, ShaderPropertyType IIHAKBEOLJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x9D94540", Offset = "0x9D93940", VA = "0x189D94540")]
	private void OLEMEFDDKKI(DFIALILHGFE OJMMNEBDONA, Material AMAOJDGFJIG, string GBAMJGDCDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x9D85F90", Offset = "0x9D85390", VA = "0x189D85F90")]
	public AJNJBKGNEEF FKNKACCHMLA(Texture IOFLDLKHGCB, string KNNFDFCLOKN, Material GMFBEMFEGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9D8FCA0", Offset = "0x9D8F0A0", VA = "0x189D8FCA0")]
	private HDDPGOFDJJG KLOJIKIBLMG(Texture IOFLDLKHGCB, string KNNFDFCLOKN, Material GMFBEMFEGJH, [Optional] BOCMKGHCPPL GOFEGOMNNJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x9D89D90", Offset = "0x9D89190", VA = "0x189D89D90")]
	public EPELPOIKEOB JACMNICJOKE(Material GMFBEMFEGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x9D95CA0", Offset = "0x9D950A0", VA = "0x189D95CA0")]
	public void PBCCJJCBNDA(INLMCJFCOPF OJMMNEBDONA, Material GMFBEMFEGJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x9D87870", Offset = "0x9D86C70", VA = "0x189D87870")]
	private void HINDJOOBONN(INLMCJFCOPF GMFBEMFEGJH, Material ANHEEJNNBEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x9D924A0", Offset = "0x9D918A0", VA = "0x189D924A0")]
	private ANPHHJFHLKL LLBEGDGIOBG(Material ANHEEJNNBEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x9D877E0", Offset = "0x9D86BE0", VA = "0x189D877E0")]
	internal static void HHHEPMJHPDI(Color CJIFLCCCMIH, [Out] Color NPLKLHFCJJM, [Out] float BHCOBPFFKLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x9D943D0", Offset = "0x9D937D0", VA = "0x189D943D0")]
	public void OHEJLMGHOLG(FIPHLEDNLPF BLJBPFHLMML, List<OHACIEGFEKO> LINFAGIPBKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x9D969D0", Offset = "0x9D95DD0", VA = "0x189D969D0")]
	private static List<OHACIEGFEKO> PJJFMCOCMLM(IEnumerable<GameObject> JJPCACLOGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x9D8AD00", Offset = "0x9D8A100", VA = "0x189D8AD00")]
	public ECEFENKLINI JCMPAPIBFIJ(GameObject JBJNKCGNJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x9D82160", Offset = "0x9D81560", VA = "0x189D82160")]
	public DONCFGCPOKC CIPCDEMEJED(string HDNPPEBJPAE, List<OHACIEGFEKO> LINFAGIPBKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x9D7D560", Offset = "0x9D7C960", VA = "0x189D7D560")]
	private NENMAJLCAIO[] BCKCPEIOMII(OHACIEGFEKO FLPBCOEGLGJ, IOHOGCBKNJA NIKBNBLEJEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x9D7C850", Offset = "0x9D7BC50", VA = "0x189D7C850")]
	private List<double> ADGEJFAEGFE(SkinnedMeshRenderer HIFHHFKLDND, Mesh IIFAOBONAHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x9D8F1B0", Offset = "0x9D8E5B0", VA = "0x189D8F1B0")]
	private void KCKLKCHIHAO(SkinnedMeshRenderer HIFHHFKLDND, Mesh IIFAOBONAHP, int BJLAIEDIMHG, NENMAJLCAIO BBJELFHBAMM, IOHOGCBKNJA NIKBNBLEJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x9D82820", Offset = "0x9D81C20", VA = "0x189D82820")]
	private static bool CJFFAHODNFD(NENMAJLCAIO EODGCIPJIMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x9D7C9F0", Offset = "0x9D7BDF0", VA = "0x189D7C9F0")]
	private static MDMNGJPOAOG AOOPNEGNEDP(MeshTopology FNHFKILGDIB)
	{
		return default(MDMNGJPOAOG);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x9D7CB00", Offset = "0x9D7BF00", VA = "0x189D7CB00")]
	private static bool BALBCHGNEOD(Mesh NIKBNBLEJEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x9D8CA20", Offset = "0x9D8BE20", VA = "0x189D8CA20")]
	private void JMPMIPHFLPM(Transform GANAIKEBLIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x9D857D0", Offset = "0x9D84BD0", VA = "0x189D857D0")]
	private Mesh EIHPLAGCGEP(GameObject JBJNKCGNJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x9D86190", Offset = "0x9D85590", VA = "0x189D86190")]
	private Material[] GFFFKLJPEJE(GameObject JBJNKCGNJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x9D8BEE0", Offset = "0x9D8B2E0", VA = "0x189D8BEE0")]
	private Vector4[] JJGHKAHNFAE(BoneWeight[] MIFHLJNGFFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x9D8DF90", Offset = "0x9D8D390", VA = "0x189D8DF90")]
	private Vector4[] KAOOHMHOHPE(BoneWeight[] MIFHLJNGFFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x9D92EE0", Offset = "0x9D922E0", VA = "0x189D92EE0")]
	private string MOCAHFGBCDF(HashSet<string> KMAIOEJLJKC, string HDNPPEBJPAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x9D86370", Offset = "0x9D85770", VA = "0x189D86370")]
	public DFIALILHGFE GJOHIKBJNHH(Texture IOFLDLKHGCB, string KNNFDFCLOKN, [Optional] IOEIDMMCKGL KAPPAFACKML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x9D876F0", Offset = "0x9D86AF0", VA = "0x189D876F0")]
	public DFIALILHGFE HFILONOBGDJ(Material AMAOJDGFJIG, Texture IOFLDLKHGCB, string KNNFDFCLOKN, [Optional] IOEIDMMCKGL KAPPAFACKML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x9D8C070", Offset = "0x9D8B470", VA = "0x189D8C070")]
	public BOCMKGHCPPL JKGCKIEPGNJ(Texture PLCPEKBJBPP, string KNNFDFCLOKN, [Optional] IOEIDMMCKGL KAPPAFACKML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x9D85AD0", Offset = "0x9D84ED0", VA = "0x189D85AD0")]
	private string EOGLDAABEAK(Texture IOFLDLKHGCB, IOEIDMMCKGL IMGNEMENFGI, string KNNFDFCLOKN, [Out] bool APONLAPBOGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x9D86480", Offset = "0x9D85880", VA = "0x189D86480")]
	private FPMLCOMKFOM GKODMDNAOAC(FNIFBJIKCDJ GDBKGMHBOGN, string KNNFDFCLOKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x49AB8E0", Offset = "0x49AACE0", VA = "0x1849AB8E0")]
	private bool OBMFDCHKGCB(IOEIDMMCKGL IMGNEMENFGI, Texture IOFLDLKHGCB, [Out] string GADMOJMIIGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80")]
	private byte[] EAMEAFMCOJH(Texture IOFLDLKHGCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x9D95B50", Offset = "0x9D94F50", VA = "0x189D95B50")]
	private bool OPAABKEGIFN(Texture DFIBBPMJMDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x9D92890", Offset = "0x9D91C90", VA = "0x189D92890")]
	private bool MIBCCPJIMIF(string AFMPILNIBJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x9D82AB0", Offset = "0x9D81EB0", VA = "0x189D82AB0")]
	private bool DDOCPGKJCIL(string AFMPILNIBJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x9D94F90", Offset = "0x9D94390", VA = "0x189D94F90")]
	private FPMLCOMKFOM OMFBIBNKJFJ(FNIFBJIKCDJ GDBKGMHBOGN, string KNNFDFCLOKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x9D8DAE0", Offset = "0x9D8CEE0", VA = "0x189D8DAE0")]
	private EOIKLMIHGFK JPLKKNMALKL(Texture IOFLDLKHGCB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Flags]
public enum IECHKDGBIAD
{
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	Meshes = 1,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	Textures = 2
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum MJEKKNDMJOM
{
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	LowQuality,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	HighQuality
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class LBEJPCLLNNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public JLMHGLECAKJ NOCHMDBMKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public BNEFKNFOHNL DBPGOBAAJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public AsyncCoroutineHelper GPJLOGKCJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public bool ELJFOEEJPGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public LDLDNCBPBLB HAPKOACDKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public bool JFEKMIIANOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public IECHKDGBIAD KMGMAKJKOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public bool NDAFNBIJJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public EIMDIMFPGMH GHOGBKOIFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public EIMDIMFPGMH PEKOBBJJKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public bool ABNKINHLCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public CPNMCGJIKLA FADAEAMKCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public MJEKKNDMJOM HJGJPCJHNIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public BlendShapeFrameWeightSetting HHMBIINBPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public PJEHNIFJDKO KIOICGECIKB;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public ILogger JFOJLBDGNEA;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x9DABDF0", Offset = "0x9DAB1F0", VA = "0x189DABDF0")]
	public LBEJPCLLNNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum CPNMCGJIKLA
{
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	ImportAndActive,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	ImportAndCameraDisabled
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public enum LDLDNCBPBLB
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
public struct DNONNAFKEMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public bool ONDHIEMLFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public int CAINIAKCFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public int ENFBOPAEIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public int ELIFIJHIKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public int PEFKOLFAEAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public int MDKPKEIPFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public int LIEGAJHHLHI;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public float DHFDOCCKCJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9D9AF40", Offset = "0x9D9A340", VA = "0x189D9AF40")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x9D9AF70", Offset = "0x9D9A370", VA = "0x189D9AF70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct HHLJAEPGNDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public long KLLJANBCKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public long FDPLHEOFKJD;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public delegate float[] DMADGBPNPDF(NAILLCKBMNB NGIAGNLBILI, int LDKNLDANNLF);
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class KNDCPNFIJBM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public enum IEDNMJMDHLC
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
	protected struct LOMELBLHCHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public Stream NNBALDJOGHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public long EBEEHMENGHO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class OKFIACBEIAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public Texture HGHKHPLOOBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public int KONGBIGHJJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public double FKMOJGIALFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public Vector2 JDOCBDPHMKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public double GGEGPGBJIHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public Vector2 HNGFPHJMIIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public int? CAJDJDLDNFH;

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE3F0", Offset = "0x9DAD7F0", VA = "0x189DAE3F0")]
		public OKFIACBEIAD()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct NBONBJFBBPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public IProgress<DNONNAFKEMG> progress;

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
		[Cpp2IlInjected.Address(RVA = "0x9DAC000", Offset = "0x9DAB400", VA = "0x189DAC000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD450", Offset = "0x9DAC850", VA = "0x189DAD450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct OEKGEOFPFEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private INLMCJFCOPF <def>5__3;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x9DADBD0", Offset = "0x9DACFD0", VA = "0x189DADBD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE020", Offset = "0x9DAD420", VA = "0x189DAE020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class ALBOHDGHMLG
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
			public ALBOHDGHMLG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			private INLMCJFCOPF <def>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x9DAED00", Offset = "0x9DAE100", VA = "0x189DAED00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x9DAF130", Offset = "0x9DAE530", VA = "0x189DAF130", Slot = "5")]
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
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public ALBOHDGHMLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9D99690", Offset = "0x9D98A90", VA = "0x189D99690")]
		[AsyncStateMachine(typeof(<<LoadMaterialAsync>b__0>d))]
		internal Task IBAHLCKKPNP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct OAHDALIILCF : IAsyncStateMachine
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
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private ALBOHDGHMLG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD850", Offset = "0x9DACC50", VA = "0x189DAD850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9DADB60", Offset = "0x9DACF60", VA = "0x189DADB60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class GLOHBFNAFKA
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
			public GLOHBFNAFKA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			private IOHOGCBKNJA <def>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x9DAF190", Offset = "0x9DAE590", VA = "0x189DAF190", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x9DAF750", Offset = "0x9DAEB50", VA = "0x189DAF750", Slot = "5")]
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
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public GLOHBFNAFKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x9D9CC70", Offset = "0x9D9C070", VA = "0x189D9CC70")]
		[AsyncStateMachine(typeof(<<LoadMeshAsync>b__0>d))]
		internal Task OLABLOFAEGJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct EDPPAOPGNIH : IAsyncStateMachine
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
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private GLOHBFNAFKA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x9D9B4B0", Offset = "0x9D9A8B0", VA = "0x189D9B4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9D9B7F0", Offset = "0x9D9ABF0", VA = "0x189D9B7F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class IIDGHKNMLOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public EHIIFFFDMGN dataLoader2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public string jsonFilePath;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public IIDGHKNMLOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D880", Offset = "0x9D9CC80", VA = "0x189D9D880")]
		internal Stream KLJNNGBABKL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D970", Offset = "0x9D9CD70", VA = "0x189D9D970")]
		internal void POOPBCNKAHJ()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct IOPELHBGMLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public string jsonFilePath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private IIDGHKNMLOM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private TaskAwaiter<Stream> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x9D9DF80", Offset = "0x9D9D380", VA = "0x189D9DF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x9D9E730", Offset = "0x9D9DB30", VA = "0x189D9E730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct GKJGLINIIPI : IAsyncStateMachine
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
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public bool showSceneObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private HLGNGKKCPCP <scene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BE10", Offset = "0x9D9B210", VA = "0x189D9BE10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9D9CC10", Offset = "0x9D9C010", VA = "0x189D9CC10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct ABDJAEOCJFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public AsyncTaskMethodBuilder<ICJGPNOLOIL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public BJOAALABNMG bufferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9DB01D0", Offset = "0x9DAF5D0", VA = "0x189DB01D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9DB0460", Offset = "0x9DAF860", VA = "0x189DB0460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct EDJBNKNEJIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public int nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private FIPHLEDNLPF <node>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private EOMPNCMDMIN <lodsExtension>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9DB35C0", Offset = "0x9DB29C0", VA = "0x189DB35C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9DB41D0", Offset = "0x9DB35D0", VA = "0x189DB41D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct FHJNEFOFLPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public AsyncTaskMethodBuilder<(Vector3, Quaternion, Vector3)[]> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public FIPHLEDNLPF node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private BBDNLDIFIMC <positionsAttr>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private BBDNLDIFIMC <rotationAttr>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private BBDNLDIFIMC <scaleAttr>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private EXT_mesh_gpu_instancing <extMeshGPUInstancing>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private int <instancesCount>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private TaskAwaiter<BBDNLDIFIMC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9DB4850", Offset = "0x9DB3C50", VA = "0x189DB4850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9DB54A0", Offset = "0x9DB48A0", VA = "0x189DB54A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class JBKICFDNNEH
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
			public JBKICFDNNEH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public bool onlyMesh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public bool ignoreMesh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			private List<ECEFENKLINI>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			private IOHOGCBKNJA <mesh>5__3;

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
			[Cpp2IlInjected.Address(RVA = "0x9DC2EE0", Offset = "0x9DC22E0", VA = "0x189DC2EE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x9DC4960", Offset = "0x9DC3D60", VA = "0x189DC4960", Slot = "5")]
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
		public FIPHLEDNLPF node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public int nodeIndex;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public JBKICFDNNEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x9DBA470", Offset = "0x9DB9870", VA = "0x189DBA470")]
		[AsyncStateMachine(typeof(<<ConstructNode>g__CreateNodeComponentsAndChilds|0>d))]
		internal Task HPBOHPEEADN(bool ignoreMesh, bool onlyMesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9DBA590", Offset = "0x9DB9990", VA = "0x189DBA590")]
		internal Material MBODBHBEEBC(NENMAJLCAIO p)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct HDPKNLOGNIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public FIPHLEDNLPF node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public int nodeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private JBKICFDNNEH <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x9DB91F0", Offset = "0x9DB85F0", VA = "0x189DB91F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x9DBA410", Offset = "0x9DB9810", VA = "0x189DBA410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct FENNBMMOJID : IAsyncStateMachine
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
		public FIPHLEDNLPF node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private List<ECEFENKLINI>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x9DB4240", Offset = "0x9DB3640", VA = "0x189DB4240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x9DB47F0", Offset = "0x9DB3BF0", VA = "0x189DB47F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct AIIJLHLLHEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public int bufferIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public ADJNLGCIMOG buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private TaskAwaiter<Stream> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x9DB04D0", Offset = "0x9DAF8D0", VA = "0x189DB04D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x9DB0D50", Offset = "0x9DB0150", VA = "0x189DB0D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct DOBOCIHFLNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public HLGNGKKCPCP scene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public bool showSceneObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public KNDCPNFIJBM <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x9DB2A10", Offset = "0x9DB1E10", VA = "0x189DB2A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x9DB3560", Offset = "0x9DB2960", VA = "0x189DB3560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct PFKHLNFDPLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public Func<Task> callback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x9DC25D0", Offset = "0x9DC19D0", VA = "0x189DC25D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x9DC2C00", Offset = "0x9DC2000", VA = "0x189DC2C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct PLGHICPMONB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x9DC2C60", Offset = "0x9DC2060", VA = "0x189DC2C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x9DC2E80", Offset = "0x9DC2280", VA = "0x189DC2E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct AKMOEMECJBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public HKPHIBPBAKP animation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public int animationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private Dictionary<int, string> <typeMap>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private KKNDFIICGMK[] <samplers>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private Dictionary<string, List<BBDNLDIFIMC>> <samplersByType>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private BGFBBKLAIHN <samplerDef>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private TaskAwaiter<ICJGPNOLOIL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x9DB0DB0", Offset = "0x9DB01B0", VA = "0x189DB0DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x9DB1AB0", Offset = "0x9DB0EB0", VA = "0x189DB1AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct ONKBOAADAHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public HKPHIBPBAKP animation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public OBNMBGHFPLJ animationCache;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class GCDPLDKCOPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public AMFNCJMAPJJ pointerData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public DMADGBPNPDF <>9__6;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public GCDPLDKCOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x9DB5510", Offset = "0x9DB4910", VA = "0x189DB5510")]
		internal float[] JCJFPBAKIEJ(NAILLCKBMNB data, int frame)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class DIGGMLMCIDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public bool flipRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public int targetCount;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public DIGGMLMCIDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x9DB1B10", Offset = "0x9DB0F10", VA = "0x189DB1B10")]
		internal float[] MJFCPGDLLBK(NAILLCKBMNB data, int frame)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class OIHPEJBECMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public float[] frameFloats;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public BlendShapeFrameWeightSetting blendShapeFrameWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public DIGGMLMCIDF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public OIHPEJBECMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x9DC2500", Offset = "0x9DC1900", VA = "0x189DC2500")]
		internal float[] AIIPKEJFIIM(NAILLCKBMNB data, int frame)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct GOJLMDAKLII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public AsyncTaskMethodBuilder<AnimationClip> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public int animationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private ONKBOAADAHO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public Transform root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private GCDPLDKCOPG <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private AnimationClip <clip>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private int[] <nodeIds>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private AMCIMOEDEHJ <pointerImportContext>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private List<KBONKFGFIPC>.Enumerator <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private KBONKFGFIPC <channel>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private bool <usesPointer>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private KKNDFIICGMK <samplerCache>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private IJKOFPPOKCO <path>5__9;

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
		[Cpp2IlInjected.Address(RVA = "0x9DB5550", Offset = "0x9DB4950", VA = "0x189DB5550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x9DB9180", Offset = "0x9DB8580", VA = "0x189DB9180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct DILMEOFOJLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public FIPHLEDNLPF node;

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
		private EOMPNCMDMIN <lodsExtension>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x9DB1DB0", Offset = "0x9DB11B0", VA = "0x189DB1DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x9DB29B0", Offset = "0x9DB1DB0", VA = "0x189DB29B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct LDGCCLFBKKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public EFFBADENAPC mapper;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct JMPLOCFJFOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public INLMCJFCOPF def;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private LDGCCLFBKKB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public int materialIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private IEDBBPABGHD <mrMapper>5__2;

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
		private HOAICHHICJE <sgMapper>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private OPBKPLKMGKL <unlitMapper>5__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private FIBMNDCDFJI <sheenMapper>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private BMPHOFNPGEB <anisotropyMapper>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private BJKKDGAHDGG <transmissionMapper>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private CBIKEGLFGHA <volumeMapper>5__17;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private FOHJDHMBGCA <iridescenceMapper>5__18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private EAKPEOFALDB <specularMapper>5__19;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private JJKNOOCBILN <clearcoatMapper>5__20;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private LFIBDDJBFCC <uniformMapper>5__21;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private EPELPOIKEOB <pbr>5__22;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private BOCMKGHCPPL <textureId>5__23;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private MJJHCPMHMPD <specGloss>5__24;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private KHR_materials_sheen <sheen>5__25;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private TaskAwaiter<OKFIACBEIAD> <>u__2;

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
		private KKOMLHEGOOF <clearcoatNormalMapper>5__32;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x9DBA600", Offset = "0x9DB9A00", VA = "0x189DBA600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x9DC24A0", Offset = "0x9DC18A0", VA = "0x189DC24A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct CBCOHMEMNCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public NENMAJLCAIO primitive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x9DCA270", Offset = "0x9DC9670", VA = "0x189DCA270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x9DCA510", Offset = "0x9DC9910", VA = "0x189DCA510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct BBLKCCLIKJI : IAsyncStateMachine
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
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public int meshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public IOHOGCBKNJA mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private KLFBFCLJFKM <meshCache>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private NIHNMIIKCPE <unityData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x9DC8820", Offset = "0x9DC7C20", VA = "0x189DC8820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x9DC9270", Offset = "0x9DC8670", VA = "0x189DC9270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct PANCHEEMEML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public IOHOGCBKNJA mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x9DDB440", Offset = "0x9DDA840", VA = "0x189DDB440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x9DDB640", Offset = "0x9DDAA40", VA = "0x189DDB640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct FFHLNOOGPMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int meshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public NIHNMIIKCPE unityMeshData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private Mesh <mesh>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x9DCEDF0", Offset = "0x9DCE1F0", VA = "0x189DCEDF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x9DCFF10", Offset = "0x9DCF310", VA = "0x189DCFF10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct GCJHKMNJALD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public NENMAJLCAIO primitive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public int meshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public int primitiveIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private List<Dictionary<string, BBDNLDIFIMC>> <newTargets>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private Dictionary<string, IBIHMHAHFHN>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private KeyValuePair<string, IBIHMHAHFHN> <targetAttribute>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private int <bufferID>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private TaskAwaiter<ICJGPNOLOIL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x9DCFF70", Offset = "0x9DCF370", VA = "0x189DCFF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x9DD0FE0", Offset = "0x9DD03E0", VA = "0x189DD0FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct ADICBOJOHOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private int <meshIndex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private IOHOGCBKNJA <gltfMesh>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5180", Offset = "0x9DC4580", VA = "0x189DC5180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5840", Offset = "0x9DC4C40", VA = "0x189DC5840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct JAOGJKFCDPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public DONCFGCPOKC meshId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public IOHOGCBKNJA mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private int <meshIndex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private NENMAJLCAIO <primitive>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x9DD4200", Offset = "0x9DD3600", VA = "0x189DD4200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x9DD4850", Offset = "0x9DD3C50", VA = "0x189DD4850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct MBOKLJJCHBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public int meshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public int primitiveIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public NENMAJLCAIO primitive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private KLFBFCLJFKM.BGCPBBEAPIO <primData>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private Dictionary<string, IBIHMHAHFHN>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private KeyValuePair<string, IBIHMHAHFHN> <attributePair>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private PFEIFMKKOFI <sparse>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private TaskAwaiter<ICJGPNOLOIL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private BBDNLDIFIMC <sparseValues>5__6;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x9DD9600", Offset = "0x9DD8A00", VA = "0x189DD9600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x9DDA760", Offset = "0x9DD9B60", VA = "0x189DDA760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct JOGIAMCKDJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public HJMBLLFHCLI skin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public KNDCPNFIJBM <>4__this;

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
		private TaskAwaiter<ICJGPNOLOIL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private int <i>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x9DD49A0", Offset = "0x9DD3DA0", VA = "0x189DD49A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x9DD5490", Offset = "0x9DD4890", VA = "0x189DD5490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private struct GDEGFGKCMLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1040", Offset = "0x9DD0440", VA = "0x189DD1040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x9DD14C0", Offset = "0x9DD08C0", VA = "0x189DD14C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private struct DDCBBKBIMOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public AsyncTaskMethodBuilder<OKFIACBEIAD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public DFIALILHGFE textureInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public bool isNormal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private OKFIACBEIAD <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private BOCMKGHCPPL <textureId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x9DCA940", Offset = "0x9DC9D40", VA = "0x189DCA940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x9DCAF10", Offset = "0x9DCA310", VA = "0x189DCAF10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct BLILLOBLKMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public int imageCacheIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public BOJKGJAKLFC image;

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
		[Cpp2IlInjected.Address(RVA = "0x9DC9D30", Offset = "0x9DC9130", VA = "0x189DC9D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x9DCA0E0", Offset = "0x9DC94E0", VA = "0x189DCA0E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct BDFLDHPOPMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public KGHMDFPAGCC texture;

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
		[Cpp2IlInjected.Address(RVA = "0x9DC9540", Offset = "0x9DC8940", VA = "0x189DC9540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x9DC9CD0", Offset = "0x9DC90D0", VA = "0x189DC9CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct DFFIADDBLKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public bool markGpuOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public BOJKGJAKLFC image;

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
		[Cpp2IlInjected.Address(RVA = "0x9DCAF80", Offset = "0x9DCA380", VA = "0x189DCAF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x9DCB860", Offset = "0x9DCAC60", VA = "0x189DCB860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct LDKJJNOAGHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public bool isLinear;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public BOJKGJAKLFC image;

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
		private ICJGPNOLOIL <bufferView>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private TaskAwaiter<ICJGPNOLOIL> <>u__1;

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
		[Cpp2IlInjected.Address(RVA = "0x9DD7770", Offset = "0x9DD6B70", VA = "0x189DD7770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x9DD95A0", Offset = "0x9DD89A0", VA = "0x189DD95A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct FBOEBJLKOHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public int textureIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public KGHMDFPAGCC texture;

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
		private BOJKGJAKLFC <image>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private bool <isFirstInstance>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x9DCD760", Offset = "0x9DCCB60", VA = "0x189DCD760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x9DCEB10", Offset = "0x9DCDF10", VA = "0x189DCEB10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct AOEJMHHGNHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public AsyncTaskMethodBuilder<BBDNLDIFIMC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public KNDCPNFIJBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public IBIHMHAHFHN accessorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public bool isPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private HCNLBGHFAEC <accessor>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private TaskAwaiter<ICJGPNOLOIL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x9DC58A0", Offset = "0x9DC4CA0", VA = "0x189DC58A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5DB0", Offset = "0x9DC51B0", VA = "0x189DC5DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public int ALLPNGNMLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public int DBDPOFGNANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private bool HMFEFBEKPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private bool OOCKBPLENBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private Dictionary<Stream, NativeArray<byte>> PGCMKJFPCME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public bool MAPBICKIODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public bool CKMPHAIKHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public bool NKOJGBEGGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x63")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public bool GENOLGPAODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public bool NBMGPENENIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public HHLJAEPGNDJ AEAIMDFJODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	protected LBEJPCLLNNC GJDDMOEJHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	protected OKBGGDLEOMO DMADLIEIMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	protected GameObject GBKFPLEPGEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	protected readonly INLMCJFCOPF JFJEDAOECCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	internal HNNPCIAIMAF ODLAOKOHAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	protected string JEMIJIIEBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	protected LOMELBLHCHF ABDBOFCGJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	protected PMNJJNLALOI PMGDJEFALLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	protected DJFECOOGHEF HEHHFEDHBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	protected bool JEJALGKEMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	protected DNONNAFKEMG EIJCGGDFIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	protected IProgress<DNONNAFKEMG> JFGJNLEONKB;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static ILogger IFAPBMPKCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	protected ColorSpace MGKCMMNCCKH;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	internal static List<Texture> HDKBKKIGICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private Dictionary<int, int> ONGAJHKEMEF;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool HFIPKIANMGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x9DA3880", Offset = "0x9DA2C80", VA = "0x189DA3880")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA7DA60", Offset = "0xA7CE60", VA = "0x180A7DA60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public PMNJJNLALOI NDDFGLPMAHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xE7BEF0", Offset = "0xE7B2F0", VA = "0x180E7BEF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Transform HFLCJFBDJBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public GameObject LBNPBJEDCIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private AnimationClip[] FKAOIPIFOGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public IEDNMJMDHLC NBIAHJNINMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA8CC50", Offset = "0xA8C050", VA = "0x180A8CC50")]
		[CompilerGenerated]
		get
		{
			return default(IEDNMJMDHLC);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xE94D20", Offset = "0xE94120", VA = "0x180E94D20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public string EDHNAPMODGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA70180", Offset = "0xA6F580", VA = "0x180A70180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public GameObject EGIJGCJKKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA7C960", Offset = "0xA7BD60", VA = "0x180A7C960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public CMNOCIIEMDP[] PEBJOIFLIDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x9DA2DB0", Offset = "0x9DA21B0", VA = "0x189DA2DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public HNNPCIAIMAF[] JKCNDLKAEEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x9DA9DE0", Offset = "0x9DA91E0", VA = "0x189DA9DE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public List<UnityEngine.Object> LBCMLFBMMFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA70280", Offset = "0xA6F680", VA = "0x180A70280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	protected PJEHNIFJDKO DDEDGOAKMIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x9DAB490", Offset = "0x9DAA890", VA = "0x189DAB490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x9DABAD0", Offset = "0x9DAAED0", VA = "0x189DABAD0")]
	public KNDCPNFIJBM(string NHAILKBHNMG, LBEJPCLLNNC LFFPIIDBFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x9DAB9D0", Offset = "0x9DAADD0", VA = "0x189DAB9D0")]
	public KNDCPNFIJBM(Stream EKIGIJCLDOH, LBEJPCLLNNC LFFPIIDBFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x9DABB20", Offset = "0x9DAAF20", VA = "0x189DABB20")]
	private KNDCPNFIJBM(LBEJPCLLNNC LFFPIIDBFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x9DA0660", Offset = "0x9D9FA60", VA = "0x189DA0660")]
	private NativeArray<byte> CNEELLAMGIP(Stream GBHJNKNIPGA)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x9DA50D0", Offset = "0x9DA44D0", VA = "0x189DA50D0")]
	private void IBBGAKOEPEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x9DA22A0", Offset = "0x9DA16A0", VA = "0x189DA22A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x9DA7450", Offset = "0x9DA6850", VA = "0x189DA7450")]
	[AsyncStateMachine(typeof(NBONBJFBBPJ))]
	public Task LDHJPDOLDDI(int HBEJOBODBKL = -1, bool NGIGLPJABGA = true, [Optional] Action<GameObject, ExceptionDispatchInfo> JJCPBHJILLK, [Optional] CancellationToken GMKBGHHNCDJ, [Optional] IProgress<DNONNAFKEMG> JFGJNLEONKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x9DA22F0", Offset = "0x9DA16F0", VA = "0x189DA22F0")]
	[AsyncStateMachine(typeof(OEKGEOFPFEE))]
	private Task EBFEGDDMPJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x9DA3770", Offset = "0x9DA2B70", VA = "0x189DA3770", Slot = "5")]
	[AsyncStateMachine(typeof(OAHDALIILCF))]
	public virtual Task<Material> GGNJMACJHJO(int LGBNJHMFDIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x9DA9CB0", Offset = "0x9DA90B0", VA = "0x189DA9CB0", Slot = "6")]
	[AsyncStateMachine(typeof(EDPPAOPGNIH))]
	public virtual Task<Mesh> NMDKLPLKPEF(int CNGMKCKIBLA, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x9DA8A90", Offset = "0x9DA7E90", VA = "0x189DA8A90")]
	[AsyncStateMachine(typeof(IOPELHBGMLC))]
	private Task LLHNLOHPIDI(string IODIJBEMNOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x9D9EE60", Offset = "0x9D9E260", VA = "0x189D9EE60")]
	private void ADHEHMEEFEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x9DA6880", Offset = "0x9DA5C80", VA = "0x189DA6880")]
	[AsyncStateMachine(typeof(GKJGLINIIPI))]
	protected Task JFLCCCAOOMJ(int HBEJOBODBKL = -1, bool NGIGLPJABGA = true, [Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x9DA2A70", Offset = "0x9DA1E70", VA = "0x189DA2A70")]
	private void EFGOCKLLMFP(HLGNGKKCPCP CHBELKDGKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x9D9FCD0", Offset = "0x9D9F0D0", VA = "0x189D9FCD0")]
	public NativeArray<byte> BDGPBHHMKKD(JIEOOJGMCGN PFOPNFJGBOO)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x9DA8980", Offset = "0x9DA7D80", VA = "0x189DA8980")]
	[AsyncStateMachine(typeof(ABDJAEOCJFB))]
	private Task<ICJGPNOLOIL> LKOFIEPEHDI(BJOAALABNMG GGKMHOHIDCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x9DA3370", Offset = "0x9DA2770", VA = "0x189DA3370")]
	private float FOKPEGDENJK(List<double> JBPPIMCKDKG, int CFHINFFOKOM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x9DA3400", Offset = "0x9DA2800", VA = "0x189DA3400")]
	[AsyncStateMachine(typeof(EDJBNKNEJIK))]
	private Task<GameObject> FOPEHOPFELF(int BBEBJBEHHMM, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x9DA0180", Offset = "0x9D9F580", VA = "0x189DA0180")]
	[AsyncStateMachine(typeof(FHJNEFOFLPP))]
	private Task<(Vector3, Quaternion, Vector3)[]> BPPMLBMIGGB(FIPHLEDNLPF BLJBPFHLMML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x9DA6540", Offset = "0x9DA5940", VA = "0x189DA6540")]
	private bool IPPHABKPAMI(FIPHLEDNLPF BLJBPFHLMML, GameObject MHFLOPCIHBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x9DA5530", Offset = "0x9DA4930", VA = "0x189DA5530", Slot = "7")]
	[AsyncStateMachine(typeof(HDPKNLOGNIN))]
	protected virtual Task IIBIPGHALIG(FIPHLEDNLPF BLJBPFHLMML, int GAIGLCAGPEN, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x9DA1CE0", Offset = "0x9DA10E0", VA = "0x189DA1CE0")]
	[AsyncStateMachine(typeof(FENNBMMOJID))]
	private Task DJJGJGHNKHD(FIPHLEDNLPF BLJBPFHLMML, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x9DAB380", Offset = "0x9DAA780", VA = "0x189DAB380")]
	[AsyncStateMachine(typeof(AIIJLHLLHEI))]
	protected Task OJMALEFKJLI(ADJNLGCIMOG JCGBEKOGKKD, int LBPLBPJDLGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x9DA1E00", Offset = "0x9DA1200", VA = "0x189DA1E00", Slot = "8")]
	[AsyncStateMachine(typeof(DOBOCIHFLNM))]
	protected virtual Task DKKHMNFEILN(HLGNGKKCPCP CHBELKDGKBD, bool NGIGLPJABGA, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x9DA6770", Offset = "0x9DA5B70", VA = "0x189DA6770", Slot = "9")]
	protected virtual ICJGPNOLOIL JDPADDBHMCO(int LBPLBPJDLGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x9DA23C0", Offset = "0x9DA17C0", VA = "0x189DA23C0")]
	private void ECACKBMHMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x9DAB4B0", Offset = "0x9DAA8B0", VA = "0x189DAB4B0")]
	private void PEDOFGNIJOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x9DA3680", Offset = "0x9DA2A80", VA = "0x189DA3680")]
	[AsyncStateMachine(typeof(PFKHLNFDPLE))]
	private Task GGCCAEAMEEF(Func<Task> BFDLNHAHOHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x9DA00B0", Offset = "0x9D9F4B0", VA = "0x189DA00B0")]
	[AsyncStateMachine(typeof(PLGHICPMONB))]
	protected Task BHGMGKLGPMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x9DA96C0", Offset = "0x9DA8AC0", VA = "0x189DA96C0")]
	private static string MPLEACOCJNI(Transform DMFKPMONDPO, Transform LDEPDDDHLLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x9D9F0D0", Offset = "0x9D9E4D0", VA = "0x189D9F0D0", Slot = "10")]
	[AsyncStateMachine(typeof(AKMOEMECJBD))]
	protected virtual Task ALGFGDHFOMN(HKPHIBPBAKP EFAFCAIAEHO, int OMEILGGBFLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x9DAA1A0", Offset = "0x9DA95A0", VA = "0x189DAA1A0")]
	protected void OFLCAOPCPPN(AnimationClip NIAPFHFAOCC, string IFKEAGBPLEE, string[] EJIKNFKCOOK, NAILLCKBMNB MICKAKKPGLH, NAILLCKBMNB AHGBOFMNHGN, KDFMGFHMONH KLNPGHMOELH, Type MJCBOELBPIB, DMADGBPNPDF KBNKGFLMBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x9D9F330", Offset = "0x9D9E730", VA = "0x189D9F330")]
	private void AMFNHHFMEJP(Keyframe[] HJMDEDHAOOB, int CACHKKKLPIJ, KDFMGFHMONH JCAGECOGNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x9DA5670", Offset = "0x9DA4A70", VA = "0x189DA5670")]
	private static float IIICEMJBENJ(Keyframe[] HJMDEDHAOOB, int CACHKKKLPIJ, bool MKKOAOFPEGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x9DA8820", Offset = "0x9DA7C20", VA = "0x189DA8820")]
	[AsyncStateMachine(typeof(GOJLMDAKLII))]
	protected Task<AnimationClip> LKNDLCHKMKP(Transform LDEPDDDHLLO, int OMEILGGBFLM, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x9DA69A0", Offset = "0x9DA5DA0", VA = "0x189DA69A0")]
	private bool JOMAJADKGGJ(GameObject MHFLOPCIHBB, FIPHLEDNLPF BLJBPFHLMML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x9DAAB30", Offset = "0x9DA9F30", VA = "0x189DAAB30")]
	private bool OHHDJKDHPMP(GameObject MHFLOPCIHBB, FIPHLEDNLPF BLJBPFHLMML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x9DA3050", Offset = "0x9DA2450", VA = "0x189DA3050")]
	[AsyncStateMachine(typeof(DILMEOFOJLB))]
	private Task FLBKFMDEBIK(PMNJJNLALOI NGJGEBLCKFB, GameObject MHFLOPCIHBB, FIPHLEDNLPF BLJBPFHLMML, int GAIGLCAGPEN, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x9DA9870", Offset = "0x9DA8C70", VA = "0x189DA9870", Slot = "11")]
	[AsyncStateMachine(typeof(JMPLOCFJFOL))]
	protected virtual Task NBBICIGHHAM(INLMCJFCOPF OJMMNEBDONA, int LGBNJHMFDIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x9DA5850", Offset = "0x9DA4C50", VA = "0x189DA5850", Slot = "12")]
	protected virtual Task IPAGNKBANHD(INLMCJFCOPF OJMMNEBDONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x9DA0900", Offset = "0x9D9FD00", VA = "0x189DA0900", Slot = "13")]
	protected virtual IKHPCJHEHAH CNOHKCPMGNC(DFIALILHGFE OJMMNEBDONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x9DA4D10", Offset = "0x9DA4110", VA = "0x189DA4D10", Slot = "14")]
	protected virtual GGIIIEGLGID HEBPMNJKKBM(INLMCJFCOPF OJMMNEBDONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x9DA6DE0", Offset = "0x9DA61E0", VA = "0x189DA6DE0", Slot = "15")]
	protected virtual KHR_materials_transmission JOMCNFIJAAJ(INLMCJFCOPF OJMMNEBDONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x9D9ED20", Offset = "0x9D9E120", VA = "0x189D9ED20", Slot = "16")]
	protected virtual KHR_materials_sheen ACBLGDKPNEF(INLMCJFCOPF OJMMNEBDONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x9DA03F0", Offset = "0x9D9F7F0", VA = "0x189DA03F0", Slot = "17")]
	protected virtual KHR_materials_anisotropy CJKFBAOIEBN(INLMCJFCOPF OJMMNEBDONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x9DA9180", Offset = "0x9DA8580", VA = "0x189DA9180", Slot = "18")]
	protected virtual KHR_materials_dispersion MMHINJCBOKO(INLMCJFCOPF OJMMNEBDONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x9DA6F20", Offset = "0x9DA6320", VA = "0x189DA6F20", Slot = "19")]
	protected virtual KHR_materials_volume KCHLDBKPEAN(INLMCJFCOPF OJMMNEBDONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x9DA53F0", Offset = "0x9DA47F0", VA = "0x189DA53F0", Slot = "20")]
	protected virtual KHR_materials_ior IGCIINFAHPP(INLMCJFCOPF OJMMNEBDONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x9DAA060", Offset = "0x9DA9460", VA = "0x189DAA060", Slot = "21")]
	protected virtual KHR_materials_iridescence OFAHJOEJDLA(INLMCJFCOPF OJMMNEBDONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x9DA02B0", Offset = "0x9D9F6B0", VA = "0x189DA02B0", Slot = "22")]
	protected virtual KHR_materials_specular CIIMEKPDCGG(INLMCJFCOPF OJMMNEBDONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x9DA3540", Offset = "0x9DA2940", VA = "0x189DA3540", Slot = "23")]
	protected virtual KHR_materials_clearcoat GCHHLILGKDC(INLMCJFCOPF OJMMNEBDONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x9DA4C20", Offset = "0x9DA4020", VA = "0x189DA4C20")]
	[AsyncStateMachine(typeof(CBCOHMEMNCA))]
	private Task HCOBNPEBKNB(NENMAJLCAIO BBJELFHBAMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x9D9EFA0", Offset = "0x9D9E3A0", VA = "0x189D9EFA0", Slot = "24")]
	[AsyncStateMachine(typeof(BBLKCCLIKJI))]
	protected virtual Task AHJANAKNKAE(IOHOGCBKNJA NIKBNBLEJEO, int CNGMKCKIBLA, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x9DA9080", Offset = "0x9DA8480", VA = "0x189DA9080")]
	[AsyncStateMachine(typeof(PANCHEEMEML))]
	private Task MMFDPOPGIHJ(IOHOGCBKNJA NIKBNBLEJEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x9DAB090", Offset = "0x9DAA490", VA = "0x189DAB090")]
	private static uint[] OIDCPKJCJKB(IOHOGCBKNJA NIKBNBLEJEO, [Out] uint OKAHGAAKMDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x9DA2DD0", Offset = "0x9DA21D0", VA = "0x189DA2DD0")]
	protected void FJMENPPIPJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x9DA38C0", Offset = "0x9DA2CC0", VA = "0x189DA38C0")]
	protected void GNOGJJECICK(Mesh NIKBNBLEJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x9DA3C50", Offset = "0x9DA3050", VA = "0x189DA3C50")]
	private NIHNMIIKCPE HAKAPAPJNFC(IOHOGCBKNJA COIFEIMFCGJ, int CNGMKCKIBLA, bool COICJMPLIPF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x9DA0530", Offset = "0x9D9F930", VA = "0x189DA0530")]
	[AsyncStateMachine(typeof(FFHLNOOGPMC))]
	protected Task CMFOFMFIDPM(NIHNMIIKCPE FBPONHIHBEN, int CNGMKCKIBLA, string OODHDKLMIHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x9DA2020", Offset = "0x9DA1420", VA = "0x189DA2020")]
	private void DNPCDMAEPOK(NIHNMIIKCPE FBPONHIHBEN, int CNGMKCKIBLA, Mesh NIKBNBLEJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x9DAB710", Offset = "0x9DAAB10", VA = "0x189DAB710", Slot = "25")]
	[AsyncStateMachine(typeof(GCJHKMNJALD))]
	protected virtual Task POBOGOHJCPL(NENMAJLCAIO BBJELFHBAMM, int CNGMKCKIBLA, int COLHHLGJMHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x9DA7590", Offset = "0x9DA6990", VA = "0x189DA7590", Slot = "26")]
	protected virtual void LELHKHIHLKN(NENMAJLCAIO BBJELFHBAMM, int CNGMKCKIBLA, int COLHHLGJMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x9DA2410", Offset = "0x9DA1810", VA = "0x189DA2410")]
	private void EEABALOBFJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x9D9F520", Offset = "0x9D9E920", VA = "0x189D9F520")]
	[AsyncStateMachine(typeof(ADICBOJOHOJ))]
	private Task ANAJABEJLCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x9DA9B90", Offset = "0x9DA8F90", VA = "0x189DA9B90")]
	[AsyncStateMachine(typeof(JAOGJKFCDPH))]
	private Task NDBGNBACMEA(IOHOGCBKNJA NIKBNBLEJEO, DONCFGCPOKC NKOOGILMHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x9DA9F20", Offset = "0x9DA9320", VA = "0x189DA9F20", Slot = "27")]
	[AsyncStateMachine(typeof(MBOKLJJCHBK))]
	protected virtual Task ODMBGJDLLDE(NENMAJLCAIO BBJELFHBAMM, int CNGMKCKIBLA, int COLHHLGJMHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x9DA0C70", Offset = "0x9DA0070", VA = "0x189DA0C70")]
	protected void DIDDOEPALJH(KLFBFCLJFKM.BGCPBBEAPIO PFCHIBJHMLC, NIHNMIIKCPE NFKENLLGOII, uint ELLEMJFEBFF, int EJDGFAAHGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x9DA0A40", Offset = "0x9D9FE40", VA = "0x189DA0A40")]
	private void DDFALGOIOFC(Dictionary<string, BBDNLDIFIMC> BGAANPHMGGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x9DA9970", Offset = "0x9DA8D70", VA = "0x189DA9970")]
	protected MeshTopology NBMOBNIFIIN(MDMNGJPOAOG KLNPGHMOELH)
	{
		return default(MeshTopology);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x9D9F8D0", Offset = "0x9D9ECD0", VA = "0x189D9F8D0")]
	private void BCOIBEAFIHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x9DA6630", Offset = "0x9DA5A30", VA = "0x189DA6630", Slot = "28")]
	[AsyncStateMachine(typeof(JOGIAMCKDJC))]
	protected virtual Task JDBADDMMCAD(HJMBLLFHCLI JGKAKNLFKCG, SkinnedMeshRenderer FOGLHINMCEC, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x9DA92C0", Offset = "0x9DA86C0", VA = "0x189DA92C0")]
	private void MOCDJDBBABA(Vector4[] MCGHNPFCNFD, Vector4[] PGNNPOLJBOP, BoneWeight[] FDDEHJDNKEH, uint FDIDNNCIDHK = 0u)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x9DA1F40", Offset = "0x9DA1340", VA = "0x189DA1F40")]
	[AsyncStateMachine(typeof(GDEGFGKCMLF))]
	private Task DMPAGFFHLFF(int NOEININIMIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x9DA4F90", Offset = "0x9DA4390", VA = "0x189DA4F90")]
	[AsyncStateMachine(typeof(DDCBBKBIMOI))]
	private Task<OKFIACBEIAD> HLMKJOCKHOM(DFIALILHGFE LJGGIGDECJD, bool BJAIPGFJDCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x9DA8CF0", Offset = "0x9DA80F0", VA = "0x189DA8CF0")]
	private static int MHKDHKDBMLJ(byte[] NGIAGNLBILI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x9DA8D50", Offset = "0x9DA8150", VA = "0x189DA8D50")]
	private Dictionary<int, int> MIAHAFNCJOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x9D9F600", Offset = "0x9D9EA00", VA = "0x189D9F600")]
	private void BBBCGCALEKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x9DA3190", Offset = "0x9DA2590", VA = "0x189DA3190")]
	private Stream FNCNIDBOBIG(BOJKGJAKLFC LFFIAPHCJGH, int HGDEPLDAEFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x9DA4E50", Offset = "0x9DA4250", VA = "0x189DA4E50")]
	[AsyncStateMachine(typeof(BLILLOBLKMF))]
	protected Task HGJOPPLEKBB(BOJKGJAKLFC LFFIAPHCJGH, int HGDEPLDAEFC, bool BFOEHNFFDPE, bool CKKPKHIOOEO, bool BJAIPGFJDCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x9DA9E00", Offset = "0x9DA9200", VA = "0x189DA9E00")]
	[AsyncStateMachine(typeof(BDFLDHPOPMA))]
	protected Task NOINFGKMDKP(KGHMDFPAGCC IOFLDLKHGCB, int FIMMMHIOKPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x9DA72F0", Offset = "0x9DA66F0", VA = "0x189DA72F0")]
	[AsyncStateMachine(typeof(DFFIADDBLKL))]
	private Task<Texture2D> KJFBALGMMFN(BOJKGJAKLFC LFFIAPHCJGH, Texture2D IOFLDLKHGCB, NativeArray<byte> NGIAGNLBILI, bool BFOEHNFFDPE, bool CKKPKHIOOEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x9DA1BA0", Offset = "0x9DA0FA0", VA = "0x189DA1BA0", Slot = "29")]
	[AsyncStateMachine(typeof(LDKJJNOAGHO))]
	protected virtual Task DIIENPKJJFH(Stream GBHJNKNIPGA, bool BFOEHNFFDPE, bool CKKPKHIOOEO, bool BJAIPGFJDCI, BOJKGJAKLFC LFFIAPHCJGH, int HGDEPLDAEFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x9DA5290", Offset = "0x9DA4690", VA = "0x189DA5290", Slot = "30")]
	protected virtual int IEJFMKKPFIM(KGHMDFPAGCC IOFLDLKHGCB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x9DAB840", Offset = "0x9DAAC40", VA = "0x189DAB840", Slot = "31")]
	protected virtual bool PPILBGJEPHL(KGHMDFPAGCC IOFLDLKHGCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x9DA3B10", Offset = "0x9DA2F10", VA = "0x189DA3B10", Slot = "32")]
	[AsyncStateMachine(typeof(FBOEBJLKOHC))]
	protected virtual Task GOBLEMJBKAG(KGHMDFPAGCC IOFLDLKHGCB, int FIMMMHIOKPH, bool BFOEHNFFDPE, bool CKKPKHIOOEO, bool BJAIPGFJDCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x9D9F1F0", Offset = "0x9D9E5F0", VA = "0x189D9F1F0")]
	[AsyncStateMachine(typeof(AOEJMHHGNHC))]
	[CompilerGenerated]
	private Task<BBDNLDIFIMC> ALNDCCEAPKE(IBIHMHAHFHN JHBHFIANHOO, bool FOKHKCHGGPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x9DA7060", Offset = "0x9DA6460", VA = "0x189DA7060")]
	[CompilerGenerated]
	internal static BBDNLDIFIMC KICFMHNIMPP(string NHKEJPFCNHN, ONKBOAADAHO P_1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x9DA8B90", Offset = "0x9DA7F90", VA = "0x189DA8B90")]
	[CompilerGenerated]
	private void MBIIBGIJMJL(BOCMKGHCPPL KKJDAPNKMBG, IKHPCJHEHAH BDCIMHIODEN, [Out] Vector2 MJHAIBCGLLD, [Out] Vector2 FDIDNNCIDHK, LDGCCLFBKKB P_4)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x9DAB640", Offset = "0x9DAAA40", VA = "0x189DAB640")]
	[CompilerGenerated]
	private void PEIJHIPHAKD(LDGCCLFBKKB P_0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x9D9FEC0", Offset = "0x9D9F2C0", VA = "0x189D9FEC0")]
	[CompilerGenerated]
	private void BFCGDBHBLEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x9DA84F0", Offset = "0x9DA78F0", VA = "0x189DA84F0")]
	[CompilerGenerated]
	private TextureWrapMode LHNJECOAEIH(KDLDBFCDKKD HBKGGCIFEEK)
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
		public enum LKNGPKNNDEA
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
		private sealed class NIOGIEKMDCA<T> where T : GLTFPlugin
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			public Type pluginType;

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public NIOGIEKMDCA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x5810540", Offset = "0x580F940", VA = "0x185810540")]
			internal bool LDKHAOEHENO(T p)
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
		private LKNGPKNNDEA blendShapeExportProperties;

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
			[Cpp2IlInjected.Address(RVA = "0x9DD2A10", Offset = "0x9DD1E10", VA = "0x189DD2A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool ExportNames
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xA9C690", Offset = "0xA9BA90", VA = "0x180A9C690")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xA9C410", Offset = "0xA9B810", VA = "0x180A9C410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool ExportFullPath
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0xF1B7F0", Offset = "0xF1ABF0", VA = "0x180F1B7F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x158DBB0", Offset = "0x158CFB0", VA = "0x18158DBB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool UseMainCameraVisibility
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x1C8FCE0", Offset = "0x1C8F0E0", VA = "0x181C8FCE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x2A2B1B0", Offset = "0x2A2A5B0", VA = "0x182A2B1B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool TryExportTexturesFromDisk
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xEA8FB0", Offset = "0xEA83B0", VA = "0x180EA8FB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xED2D00", Offset = "0xED2100", VA = "0x180ED2D00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool UseTextureFileTypeHeuristic
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xED28F0", Offset = "0xED1CF0", VA = "0x180ED28F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xED2700", Offset = "0xED1B00", VA = "0x180ED2700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool ExportVertexColors
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x75DF600", Offset = "0x75DEA00", VA = "0x1875DF600")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x76828C0", Offset = "0x7681CC0", VA = "0x1876828C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public int DefaultJpegQuality
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xA8CC50", Offset = "0xA8C050", VA = "0x180A8CC50")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xE94D20", Offset = "0xE94120", VA = "0x180E94D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool ExportDisabledGameObjects
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x29F8230", Offset = "0x29F7630", VA = "0x1829F8230")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x84CAB10", Offset = "0x84C9F10", VA = "0x1884CAB10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool ExportAnimations
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xF79120", Offset = "0xF78520", VA = "0x180F79120")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xF78A80", Offset = "0xF77E80", VA = "0x180F78A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool BakeAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xF78700", Offset = "0xF77B00", VA = "0x180F78700")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xF78DB0", Offset = "0xF781B0", VA = "0x180F78DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		[Obsolete("Add/remove \"AnimationPointerPlugin\" from ExportPlugins instead.")]
		public bool UseAnimationPointer
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x9DD2A20", Offset = "0x9DD1E20", VA = "0x189DD2A20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x9DD2B60", Offset = "0x9DD1F60", VA = "0x189DD2B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool UniqueAnimationNames
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xF78710", Offset = "0xF77B10", VA = "0x180F78710")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xF78CF0", Offset = "0xF780F0", VA = "0x180F78CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool BlendShapeExportSparseAccessors
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x19341E0", Offset = "0x19335E0", VA = "0x1819341E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x19457A0", Offset = "0x1944BA0", VA = "0x1819457A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public LKNGPKNNDEA BlendShapeExportProperties
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xAD8D80", Offset = "0xAD8180", VA = "0x180AD8D80")]
			get
			{
				return default(LKNGPKNNDEA);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CE0", Offset = "0xAD80E0", VA = "0x180AD8CE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool BakeSkinnedMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x9DD2A00", Offset = "0x9DD1E00", VA = "0x189DD2A00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x9DD2B50", Offset = "0x9DD1F50", VA = "0x189DD2B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1E90", Offset = "0x9DD1290", VA = "0x189DD1E90")]
		internal string EHIEIAMHAOL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x9DD2620", Offset = "0x9DD1A20", VA = "0x189DD2620")]
		public static GLTFSettings IGCAOLGDKCM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x9DD27F0", Offset = "0x9DD1BF0", VA = "0x189DD27F0")]
		public static GLTFSettings JJKNDLBDPNK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1CA0", Offset = "0x9DD10A0", VA = "0x189DD1CA0")]
		public static bool CIONLMNKPDK([Out] GLTFSettings FKBCJNJEHBA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1DD0", Offset = "0x9DD11D0", VA = "0x189DD1DD0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ClearStatics()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x9DD2210", Offset = "0x9DD1610", VA = "0x189DD2210")]
		private static void GMIDGIOCDDE(GLTFSettings FKBCJNJEHBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x9DD2900", Offset = "0x9DD1D00", VA = "0x189DD2900")]
		public GLTFSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3CBAA80", Offset = "0x3CB9E80", VA = "0x183CBAA80")]
		[CompilerGenerated]
		internal static List<Type> PCHELDKAGBK<T>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x3CBACE0", Offset = "0x3CBA0E0", VA = "0x183CBACE0")]
		[CompilerGenerated]
		internal static void PGFIBAGLHAF<T>(List<T> JAABMEKFBKM) where T : GLTFPlugin
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class ShaderNotFoundException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x9DDB750", Offset = "0x9DDAB50", VA = "0x189DDB750")]
		public ShaderNotFoundException()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x9DDB6A0", Offset = "0x9DDAAA0", VA = "0x189DDB6A0")]
		public ShaderNotFoundException(string AFDNIPHJHMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x9DDB700", Offset = "0x9DDAB00", VA = "0x189DDB700")]
		protected ShaderNotFoundException(SerializationInfo LFDKNECEJEF, StreamingContext HFJHENFIDEF)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class KKBNCHNEMNJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x9DD7710", Offset = "0x9DD6B10", VA = "0x189DD7710")]
	public KKBNCHNEMNJ(string AFDNIPHJHMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class CIFMKKPMHLB : ILogHandler
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private readonly StringBuilder LDJKPABJDHL;

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x9DCA6E0", Offset = "0x9DC9AE0", VA = "0x189DCA6E0")]
	private string LPGAIBPINIL(LogType AIFHIPGNONC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x9DCA800", Offset = "0x9DC9C00", VA = "0x189DCA800", Slot = "4")]
	public void LogFormat(LogType AIFHIPGNONC, UnityEngine.Object HFJHENFIDEF, string LKPDHLBCOHA, params object[] PHAOHJHLKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x9DCA760", Offset = "0x9DC9B60", VA = "0x189DCA760", Slot = "5")]
	public void LogException(Exception GGJDDHMDBJI, UnityEngine.Object HFJHENFIDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x9DCA570", Offset = "0x9DC9970", VA = "0x189DCA570")]
	public void AAOPDFAJNHI(string LKPDHLBCOHA = "{0}")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x9DCA8C0", Offset = "0x9DC9CC0", VA = "0x189DCA8C0")]
	public CIFMKKPMHLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class BBMHIDBOJMD
{
	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x9DC92D0", Offset = "0x9DC86D0", VA = "0x189DC92D0")]
	public static string CJCBBBJODKP(Uri FLIDMJHLHCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x9DC94D0", Offset = "0x9DC88D0", VA = "0x189DC94D0")]
	public static string POIMBEJEAHE(string JKBAFFKCIEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x9DC9330", Offset = "0x9DC8730", VA = "0x189DC9330")]
	public static void GAFFHKNEDNG(string FLIDMJHLHCC, [Out] byte[] OKENHOMINHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x9DC9440", Offset = "0x9DC8840", VA = "0x189DC9440")]
	public static bool NCEOGFPNLAK(string FLIDMJHLHCC)
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
		private IPFICMCCFIJ JPDKEDNFOOG;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public IPFICMCCFIJ CDBDNKFEBPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x9DD41A0", Offset = "0x9DD35A0", VA = "0x189DD41A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x9DD4070", Offset = "0x9DD3470", VA = "0x189DD4070")]
		public InstantiatedGLTFObject Duplicate()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x9DD4150", Offset = "0x9DD3550", VA = "0x189DD4150")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED60", Offset = "0xA6E160", VA = "0x180A6ED60")]
		public InstantiatedGLTFObject()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public struct BlendShapeFrameWeightSetting
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public enum BCLCMJKGPCH
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
		internal BCLCMJKGPCH _option;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		[SerializeField]
		internal float _multiplier;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float Multiplier
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x9DCA1E0", Offset = "0x9DC95E0", VA = "0x189DCA1E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x9DCA1D0", Offset = "0x9DC95D0", VA = "0x189DCA1D0")]
		public BlendShapeFrameWeightSetting(BCLCMJKGPCH EKMAKONICKM)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x9DCA140", Offset = "0x9DC9540", VA = "0x189DCA140")]
		public static float GKKMDDPCKIG(BlendShapeFrameWeightSetting MJDDPNCJAHC)
		{
			return default(float);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public enum EIMDIMFPGMH
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
		public abstract KNDCPNFIJBM NMMCAHCBAKP(string NHAILKBHNMG, LBEJPCLLNNC LFFPIIDBFOJ);

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xCFA860", Offset = "0xCF9C60", VA = "0x180CFA860")]
		protected ImporterFactory()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class DefaultImporterFactory : ImporterFactory
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x9DCB8D0", Offset = "0x9DCACD0", VA = "0x189DCB8D0", Slot = "4")]
		public override KNDCPNFIJBM NMMCAHCBAKP(string NHAILKBHNMG, LBEJPCLLNNC LFFPIIDBFOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xCFA860", Offset = "0xCF9C60", VA = "0x180CFA860")]
		public DefaultImporterFactory()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal static class KGGFKEOHLEO
{
	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x9DD54F0", Offset = "0x9DD48F0", VA = "0x189DD54F0")]
	internal static void HNNOKIGPJII(this Material GMFBEMFEGJH, string KNFLHKDHGNG, bool JPDKKKJJNLC)
	{
	}
}
namespace UnityGLTF
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class MaterialLibrary : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xCFA860", Offset = "0xCF9C60", VA = "0x180CFA860")]
		public MaterialLibrary()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal static class JCGCJFMDIMO
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class GLEOCGDMOJN
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
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public GLEOCGDMOJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A30", Offset = "0x9DD0E30", VA = "0x189DD1A30")]
		internal void HEDIDGCPPBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1940", Offset = "0x9DD0D40", VA = "0x189DD1940")]
		internal void CIEAJKCENHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1990", Offset = "0x9DD0D90", VA = "0x189DD1990")]
		internal void DPFBOBCJGLB()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct MKMLIDGOPDF : IAsyncStateMachine
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
		private GLEOCGDMOJN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x9DDA7C0", Offset = "0x9DD9BC0", VA = "0x189DDA7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x9DDAE10", Offset = "0x9DDA210", VA = "0x189DDAE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x9DD48B0", Offset = "0x9DD3CB0", VA = "0x189DD48B0")]
	[AsyncStateMachine(typeof(MKMLIDGOPDF))]
	public static Task<Texture2D> LOIBECJIEBF(Texture2D NHDOFIDIKGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class NIHNMIIKCPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public bool[] OHCFPKCPBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public Vector3[] PCHBAJDDIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public Vector3[] GGJILDJKAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public Vector4[] BPCJMPHJINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public Vector2[] BMMEBPPHFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public Vector2[] FMPLINABIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public Vector2[] NAPPDKJJNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public Vector2[] MAJABKDIEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public Color[] ONCMNAHKJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public BoneWeight[] OLCLODOFDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public Vector3[][] LFHACFKDEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public Vector3[][] MNAICGJEPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public Vector3[][] PPLEDNGJANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public MeshTopology[] IMONMFENLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public MDMNGJPOAOG[] CLIKKKIPJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public int[][] DBPEDIFKMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public HashSet<int> DKHEBLINGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public uint[] FLNIANILNDH;

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x9DDAE80", Offset = "0x9DDA280", VA = "0x189DDAE80")]
	public void HBLMHKLDBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x9DDAF90", Offset = "0x9DDA390", VA = "0x189DDAF90")]
	public bool OMDFDEFKKGJ(NIHNMIIKCPE LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x9DDB1E0", Offset = "0x9DDA5E0", VA = "0x189DDB1E0")]
	public NIHNMIIKCPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x3E5E9D0", Offset = "0x3E5DDD0", VA = "0x183E5E9D0")]
	[CompilerGenerated]
	internal static bool AICIKAMOHIG<T>(T[] ADMDGKMAJGH, T[] LOIGHNJAJFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x3E5F710", Offset = "0x3E5EB10", VA = "0x183E5F710")]
	[CompilerGenerated]
	internal static bool LIJGHOCGKEL<T>(T[][] ADMDGKMAJGH, T[][] LOIGHNJAJFN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public abstract class EJLJFIELBLE : EFFBADENAPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	internal Material AFDACPAFHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private OAJNGKCLKHC NNLBEGGLIDK;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly int CCPEOFDBBLL;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private static readonly int HHCICPLGLGC;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private static readonly int IPNJHAIEDGP;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private static readonly int HPJFANMJKAA;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private static readonly int DAOGENGODAM;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private static readonly int NIAJFOIIEMF;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	private static readonly int KEBDMFDIHFL;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	private static readonly int OINGFGONACN;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	private static readonly int OHIMJJDLNJN;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	private static readonly int KGHFCELAEMO;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	private static readonly int PONCPJMKAKB;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	private static readonly int MHBMBKDIKHF;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	private static readonly int CIJOIKFLOMB;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	private static readonly int DMKKBHHNLAL;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Material NOKPIKBDEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public virtual OAJNGKCLKHC PNHKKLFBNCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x9DCBED0", Offset = "0x9DCB2D0", VA = "0x189DCBED0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public double MMAKFPPLPBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x9DCBBE0", Offset = "0x9DCAFE0", VA = "0x189DCBBE0", Slot = "12")]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x9DCB940", Offset = "0x9DCAD40", VA = "0x189DCB940", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public virtual bool DJEMGNCNDEI
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x9DCBC30", Offset = "0x9DCB030", VA = "0x189DCBC30", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public virtual bool FFMHACAJGBE
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x9DCBDF0", Offset = "0x9DCB1F0", VA = "0x189DCBDF0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Texture JCPLBLKONOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x9DCCD10", Offset = "0x9DCC110", VA = "0x189DCCD10", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int DMJAIGAPCHO
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x9DCC970", Offset = "0x9DCBD70", VA = "0x189DCC970", Slot = "16")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Vector2 GCCLFFOFFLO
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x9DCCDE0", Offset = "0x9DCC1E0", VA = "0x189DCCDE0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public double DPNABHJDFNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x9DCBE70", Offset = "0x9DCB270", VA = "0x189DCBE70", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public Vector2 IGOJFIBPHBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x9DCB9A0", Offset = "0x9DCADA0", VA = "0x189DCB9A0", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int DEHFMOBCNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x9DCC9E0", Offset = "0x9DCBDE0", VA = "0x189DCC9E0", Slot = "20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Color IDDGGPJDMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x9DCCD70", Offset = "0x9DCC170", VA = "0x189DCCD70", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract EFFBADENAPC JCIOENFMGMF();

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0xA75990", Offset = "0xA74D90", VA = "0x180A75990")]
	protected EJLJFIELBLE(Material AMAOJDGFJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x9DCD0D0", Offset = "0x9DCC4D0", VA = "0x189DCD0D0")]
	protected EJLJFIELBLE(string HMKAMHBJKHD, string OBKJAMCALJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x9DCBD10", Offset = "0x9DCB110", VA = "0x189DCBD10")]
	protected void EIDBONDNOCE(Material GMFBEMFEGJH, bool AKKBELJIBBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x9DCBA00", Offset = "0x9DCAE00", VA = "0x189DCBA00")]
	protected void CGMOBHEDFHN(Material GMFBEMFEGJH, bool MKEDKNOFBGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x9DCCA50", Offset = "0x9DCBE50", VA = "0x189DCCA50")]
	protected void LIDCOHPKIGA(Material GMFBEMFEGJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class GKOHFBKMCNG : HDHCOFAOEAH, IEDBBPABGHD, LFIBDDJBFCC, EFFBADENAPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	private Vector2 GJAFHNLCAFG;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public virtual Texture JCPLBLKONOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1790", Offset = "0x9DD0B90", VA = "0x189DD1790", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public virtual int DMJAIGAPCHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public virtual Vector2 GCCLFFOFFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1860", Offset = "0x9DD0C60", VA = "0x189DD1860", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public virtual double DPNABHJDFNO
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public virtual Vector2 IGOJFIBPHBK
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x9DD15D0", Offset = "0x9DD09D0", VA = "0x189DD15D0", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public virtual int DEHFMOBCNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "82")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public virtual Color IDDGGPJDMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x9DD17F0", Offset = "0x9DD0BF0", VA = "0x189DD17F0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public virtual Texture NHCEKGFLOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x9DD18D0", Offset = "0x9DD0CD0", VA = "0x189DD18D0", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public virtual int PMKBBBGELEG
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public virtual Vector2 KIKAJNNFILO
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "86")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public virtual double FCGEDEHABBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public virtual Vector2 BIGJCFMEKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "88")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public virtual int CAFCFCBKJLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public virtual double LBNLMDIAGCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1580", Offset = "0x9DD0980", VA = "0x189DD1580", Slot = "90")]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1520", Offset = "0x9DD0920", VA = "0x189DD1520", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual double CLCCKHCFLBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "92")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x9DD1920", Offset = "0x9DD0D20", VA = "0x189DD1920")]
	protected GKOHFBKMCNG(string HMKAMHBJKHD, string BBHAHPAFMMN, int EDELGNFDFFG = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x9DD1930", Offset = "0x9DD0D30", VA = "0x189DD1930")]
	protected GKOHFBKMCNG(Material MJMLIEBHGEF, int EDELGNFDFFG = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x9DD1660", Offset = "0x9DD0A60", VA = "0x189DD1660", Slot = "60")]
	public override EFFBADENAPC JCIOENFMGMF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class EJMCCMPEMJM : GKOHFBKMCNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	private Vector2 FDGCNMBDCGD;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public override int EMDCBCOJNAB
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public override int FFMKCGAKHFH
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public override int IEOLJFHGFOA
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override int DMJAIGAPCHO
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override Texture NHCEKGFLOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x9DCD490", Offset = "0x9DCC890", VA = "0x189DCD490", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public override int PMKBBBGELEG
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public override Vector2 KIKAJNNFILO
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x9DCD200", Offset = "0x9DCC600", VA = "0x189DCD200", Slot = "86")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public override double FCGEDEHABBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public override Vector2 BIGJCFMEKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x9DCD400", Offset = "0x9DCC800", VA = "0x189DCD400", Slot = "88")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public override int CAFCFCBKJLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public override double CLCCKHCFLBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x9DCD3A0", Offset = "0x9DCC7A0", VA = "0x189DCD3A0", Slot = "92")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x9DCD530", Offset = "0x9DCC930", VA = "0x189DCD530")]
	public EJMCCMPEMJM(string HMKAMHBJKHD, int EDELGNFDFFG = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x9DCD510", Offset = "0x9DCC910", VA = "0x189DCD510")]
	protected EJMCCMPEMJM(Material MJMLIEBHGEF, int EDELGNFDFFG = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x9DCD270", Offset = "0x9DCC670", VA = "0x189DCD270", Slot = "60")]
	public override EFFBADENAPC JCIOENFMGMF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class BADLJECDBKG : EJLJFIELBLE, IEDBBPABGHD, LFIBDDJBFCC, EFFBADENAPC, CBIKEGLFGHA, BJKKDGAHDGG, NJBOBPACPEG, FOHJDHMBGCA, EAKPEOFALDB, JJKNOOCBILN, HALHEHLCJFL, FIBMNDCDFJI, BMPHOFNPGEB
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Texture EAGJNGDJFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7C30", Offset = "0x9DC7030", VA = "0x189DC7C30", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6750", Offset = "0x9DC5B50", VA = "0x189DC6750", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public int EMDCBCOJNAB
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x9DC71A0", Offset = "0x9DC65A0", VA = "0x189DC71A0", Slot = "39")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public double NHNMJJHABJN
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6E20", Offset = "0x9DC6220", VA = "0x189DC6E20", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public Vector2 CKMPBFPPOFP
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x9DC70E0", Offset = "0x9DC64E0", VA = "0x189DC70E0", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public double DLFNEOOEGNA
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6EF0", Offset = "0x9DC62F0", VA = "0x189DC6EF0", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Vector2 MONPLPKOJAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7E60", Offset = "0x9DC7260", VA = "0x189DC7E60", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int HPAHIOIJCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6FB0", Offset = "0x9DC63B0", VA = "0x189DC6FB0", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Texture OOHCDMAJGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x9DC66F0", Offset = "0x9DC5AF0", VA = "0x189DC66F0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public int FFMKCGAKHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6CF0", Offset = "0x9DC60F0", VA = "0x189DC6CF0", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public double FDOGAEPEOJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x9DC85F0", Offset = "0x9DC79F0", VA = "0x189DC85F0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public Vector2 FMEDOPIODNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6020", Offset = "0x9DC5420", VA = "0x189DC6020", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public double EPGCAFBLBOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7860", Offset = "0x9DC6C60", VA = "0x189DC7860", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Vector2 CANAMNCJBPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7140", Offset = "0x9DC6540", VA = "0x189DC7140", Slot = "50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int CCMHJDOFDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x9DC8580", Offset = "0x9DC7980", VA = "0x189DC8580", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public Texture IBMIHFJKJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x9DC68D0", Offset = "0x9DC5CD0", VA = "0x189DC68D0", Slot = "52")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public int IEOLJFHGFOA
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x9DC60E0", Offset = "0x9DC54E0", VA = "0x189DC60E0", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Color KDNMKHBIEMN
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6E80", Offset = "0x9DC6280", VA = "0x189DC6E80", Slot = "54")]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x9DC64A0", Offset = "0x9DC58A0", VA = "0x189DC64A0", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector2 HILGDAIMEOI
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6AB0", Offset = "0x9DC5EB0", VA = "0x189DC6AB0", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public double PKHOIGOAKAC
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6440", Offset = "0x9DC5840", VA = "0x189DC6440", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector2 JHAJGCJGPEF
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7980", Offset = "0x9DC6D80", VA = "0x189DC7980", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public int EELIIADGDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7210", Offset = "0x9DC6610", VA = "0x189DC7210", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public Texture NHCEKGFLOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x9DC83A0", Offset = "0x9DC77A0", VA = "0x189DC83A0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public int PMKBBBGELEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x9DC8340", Offset = "0x9DC7740", VA = "0x189DC8340", Slot = "30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Vector2 KIKAJNNFILO
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5E20", Offset = "0x9DC5220", VA = "0x189DC5E20", Slot = "31")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public double FCGEDEHABBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6990", Offset = "0x9DC5D90", VA = "0x189DC6990", Slot = "32")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector2 BIGJCFMEKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7E00", Offset = "0x9DC7200", VA = "0x189DC7E00", Slot = "33")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public int CAFCFCBKJLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7B10", Offset = "0x9DC6F10", VA = "0x189DC7B10", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public double LBNLMDIAGCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5EF0", Offset = "0x9DC52F0", VA = "0x189DC5EF0", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public double CLCCKHCFLBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7560", Offset = "0x9DC6960", VA = "0x189DC7560", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public double JDGEHDFDAKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x9DC8100", Offset = "0x9DC7500", VA = "0x189DC8100", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Texture MGONMALMEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x9DC8220", Offset = "0x9DC7620", VA = "0x189DC8220", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public double KDGFMGPLCFK
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7EC0", Offset = "0x9DC72C0", VA = "0x189DC7EC0", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Vector2 FKPDFKNHGOB
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x9DC73F0", Offset = "0x9DC67F0", VA = "0x189DC73F0", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public Vector2 DNDOMNEOELK
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x9DC81C0", Offset = "0x9DC75C0", VA = "0x189DC81C0", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public int KPAFHEFMFDI
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7F20", Offset = "0x9DC7320", VA = "0x189DC7F20", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public double DHEMBCHJHPK
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7680", Offset = "0x9DC6A80", VA = "0x189DC7680", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Color NJAKIDMGEDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5FB0", Offset = "0x9DC53B0", VA = "0x189DC5FB0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public double CIPNJFHEIHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6380", Offset = "0x9DC5780", VA = "0x189DC6380", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Texture KMLHFOCIGIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x9DC84C0", Offset = "0x9DC78C0", VA = "0x189DC84C0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public double JNCMJBGOLFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7CE0", Offset = "0x9DC70E0", VA = "0x189DC7CE0", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Vector2 CPEJNNCIBPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x9DC78C0", Offset = "0x9DC6CC0", VA = "0x189DC78C0", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector2 GDBAALIPFPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6A50", Offset = "0x9DC5E50", VA = "0x189DC6A50", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public int JKDICOJBFDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6C90", Offset = "0x9DC6090", VA = "0x189DC6C90", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public double AMIJGKOALBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6080", Offset = "0x9DC5480", VA = "0x189DC6080", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public double OIEGLOPIOJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6D60", Offset = "0x9DC6160", VA = "0x189DC6D60", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public double PBHLCCFPCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x9DC72D0", Offset = "0x9DC66D0", VA = "0x189DC72D0", Slot = "76")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public double AIDMGNBOMCO
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7920", Offset = "0x9DC6D20", VA = "0x189DC7920", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public double EJMNGAIELEF
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x9DC63E0", Offset = "0x9DC57E0", VA = "0x189DC63E0", Slot = "78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public Texture JKEBLDBMKHE
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6810", Offset = "0x9DC5C10", VA = "0x189DC6810", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public double BEIMJIPLPAG
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7DA0", Offset = "0x9DC71A0", VA = "0x189DC7DA0", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public Vector2 GMJGNIBBHJA
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x9DC8520", Offset = "0x9DC7920", VA = "0x189DC8520", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public Vector2 NLEJPAHLHGH
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6630", Offset = "0x9DC5A30", VA = "0x189DC6630", Slot = "82")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public int BMBJAGHMEJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7F80", Offset = "0x9DC7380", VA = "0x189DC7F80", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public Texture PEJMFGMABJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x9DC8160", Offset = "0x9DC7560", VA = "0x189DC8160", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public double IJEMGOJPJOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x9DC8650", Offset = "0x9DC7A50", VA = "0x189DC8650", Slot = "86")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public Vector2 OGAOPIOFKLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5F50", Offset = "0x9DC5350", VA = "0x189DC5F50", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public Vector2 IJHNAAGIFHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x9DC8400", Offset = "0x9DC7800", VA = "0x189DC8400", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public int LNGCIAKBIIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x9DC79E0", Offset = "0x9DC6DE0", VA = "0x189DC79E0", Slot = "88")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public double AJMJBHDLABB
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6930", Offset = "0x9DC5D30", VA = "0x189DC6930", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public Texture ANIBMJAIFKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7C80", Offset = "0x9DC7080", VA = "0x189DC7C80", Slot = "90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public double GILFAENEMHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x9DC65D0", Offset = "0x9DC59D0", VA = "0x189DC65D0", Slot = "92")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public Vector2 IDBEIAICADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6870", Offset = "0x9DC5C70", VA = "0x189DC6870", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public Vector2 BALMGDNMKNC
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6140", Offset = "0x9DC5540", VA = "0x189DC6140", Slot = "93")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public int FMAOGLJGAJO
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6320", Offset = "0x9DC5720", VA = "0x189DC6320", Slot = "94")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public Color LFEGAHBLNFM
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7AA0", Offset = "0x9DC6EA0", VA = "0x189DC7AA0", Slot = "95")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public Texture EBDLDJBEOEC
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6B70", Offset = "0x9DC5F70", VA = "0x189DC6B70", Slot = "96")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public double IFKFAKIHKCN
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7080", Offset = "0x9DC6480", VA = "0x189DC7080", Slot = "98")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector2 IOFFEBEPHPK
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7390", Offset = "0x9DC6790", VA = "0x189DC7390", Slot = "97")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector2 OIJGIAMHKPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x9DC69F0", Offset = "0x9DC5DF0", VA = "0x189DC69F0", Slot = "99")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public int OOGGPBNGDJN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x9DC82E0", Offset = "0x9DC76E0", VA = "0x189DC82E0", Slot = "100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public double HLAMCJGKEKI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6690", Offset = "0x9DC5A90", VA = "0x189DC6690", Slot = "101")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Texture KEPEBMLILDI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6260", Offset = "0x9DC5660", VA = "0x189DC6260", Slot = "102")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public double CDDBAIPGHDG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7270", Offset = "0x9DC6670", VA = "0x189DC7270", Slot = "104")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector2 EJMMMPEJEFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x9DC8280", Offset = "0x9DC7680", VA = "0x189DC8280", Slot = "103")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector2 GFOAJCNHFGE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6570", Offset = "0x9DC5970", VA = "0x189DC6570", Slot = "105")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int NBELCCMMCJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7BD0", Offset = "0x9DC6FD0", VA = "0x189DC7BD0", Slot = "106")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public double ENJLDBMPKFN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x9DC8040", Offset = "0x9DC7440", VA = "0x189DC8040", Slot = "107")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Texture CNMNFDAHDDH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x9DC62C0", Offset = "0x9DC56C0", VA = "0x189DC62C0", Slot = "108")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public double DBDNADJADAL
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x9DC76E0", Offset = "0x9DC6AE0", VA = "0x189DC76E0", Slot = "110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public Vector2 LMHIPPGILMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6C30", Offset = "0x9DC6030", VA = "0x189DC6C30", Slot = "109")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public Vector2 GPOGLJLJNOB
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6BD0", Offset = "0x9DC5FD0", VA = "0x189DC6BD0", Slot = "111")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public int EDKHEEOFAND
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x9DC67B0", Offset = "0x9DC5BB0", VA = "0x189DC67B0", Slot = "112")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public float DKOIBJIAKNA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7620", Offset = "0x9DC6A20", VA = "0x189DC7620", Slot = "113")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public float GPLLMBFBIDE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x9DC8460", Offset = "0x9DC7860", VA = "0x189DC8460", Slot = "114")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public Color PPJIAABMMHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5E80", Offset = "0x9DC5280", VA = "0x189DC5E80", Slot = "115")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public Texture KFNGOMLLECA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x9DC61A0", Offset = "0x9DC55A0", VA = "0x189DC61A0", Slot = "116")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public double FFGLDPCICLE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7800", Offset = "0x9DC6C00", VA = "0x189DC7800", Slot = "117")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public Vector2 DCDEHJNBECA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7020", Offset = "0x9DC6420", VA = "0x189DC7020", Slot = "118")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public Vector2 HPHOPEAJJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7B70", Offset = "0x9DC6F70", VA = "0x189DC7B70", Slot = "119")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public int KCLJIMFDDLG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7740", Offset = "0x9DC6B40", VA = "0x189DC7740", Slot = "120")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public Texture POALEEHKGNG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6510", Offset = "0x9DC5910", VA = "0x189DC6510", Slot = "121")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public double MHNCJINALFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6DC0", Offset = "0x9DC61C0", VA = "0x189DC6DC0", Slot = "122")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Vector2 JGLDHPPLDLL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7A40", Offset = "0x9DC6E40", VA = "0x189DC7A40", Slot = "123")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public Vector2 MILFNCFGOMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7330", Offset = "0x9DC6730", VA = "0x189DC7330", Slot = "124")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public int EEDMGACPNCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7D40", Offset = "0x9DC7140", VA = "0x189DC7D40", Slot = "125")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public double FGAIFDOGAMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6B10", Offset = "0x9DC5F10", VA = "0x189DC6B10", Slot = "131")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public double OBNPEKLIHKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7FE0", Offset = "0x9DC73E0", VA = "0x189DC7FE0", Slot = "132")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Texture MODNNFPMCFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x9DC80A0", Offset = "0x9DC74A0", VA = "0x189DC80A0", Slot = "126")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public double PFMGFICPFAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x9DC77A0", Offset = "0x9DC6BA0", VA = "0x189DC77A0", Slot = "128")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector2 LBPPDAGDFPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6200", Offset = "0x9DC5600", VA = "0x189DC6200", Slot = "127")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector2 KIMEHFFHBKI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6F50", Offset = "0x9DC6350", VA = "0x189DC6F50", Slot = "129")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public int EKBAABNIEHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x9DC75C0", Offset = "0x9DC69C0", VA = "0x189DC75C0", Slot = "130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x9DC8720", Offset = "0x9DC7B20", VA = "0x189DC8720")]
	public BADLJECDBKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x9DC87B0", Offset = "0x9DC7BB0", VA = "0x189DC87B0")]
	protected BADLJECDBKG(string HMKAMHBJKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x9DC86B0", Offset = "0x9DC7AB0", VA = "0x189DC86B0")]
	public BADLJECDBKG(Material AMAOJDGFJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x9DC7450", Offset = "0x9DC6850", VA = "0x189DC7450", Slot = "10")]
	public override EFFBADENAPC JCIOENFMGMF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class KINMLHJHHGE : HDHCOFAOEAH, HOAICHHICJE, LFIBDDJBFCC, EFFBADENAPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	private Vector2 BGJMPKJNKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	private Vector2 IOIAEMOGLBP;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public virtual Texture OIFACDPCJBA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x9DD56D0", Offset = "0x9DD4AD0", VA = "0x189DD56D0", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public virtual int PAACLLPCFNH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public virtual Vector2 JLLEAPHGLNK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x9DD5B10", Offset = "0x9DD4F10", VA = "0x189DD5B10", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public virtual double GAIJKLPMGCG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public virtual Vector2 IIHNBGAELJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x9DD55B0", Offset = "0x9DD49B0", VA = "0x189DD55B0", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public virtual int EPGHAHOBHEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "82")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public virtual Color ADBDMFMAHDN
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x9DD59F0", Offset = "0x9DD4DF0", VA = "0x189DD59F0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public virtual Texture FDPIMMFEAPC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x9DD5A60", Offset = "0x9DD4E60", VA = "0x189DD5A60", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public virtual int PDLPCNLNDHF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public virtual Vector2 EGENOFDOEJB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x9DD5730", Offset = "0x9DD4B30", VA = "0x189DD5730", Slot = "86")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public virtual double OBFJICEBADK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public virtual Vector2 ALBJOPPABIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x9DD5830", Offset = "0x9DD4C30", VA = "0x189DD5830", Slot = "88")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public virtual int MNBFCJAOPNN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public virtual Vector3 AJMJBHDLABB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x9DD57A0", Offset = "0x9DD4BA0", VA = "0x189DD57A0", Slot = "90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public virtual double GGEDEOPPHMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x9DD5640", Offset = "0x9DD4A40", VA = "0x189DD5640", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x9DD5B80", Offset = "0x9DD4F80", VA = "0x189DD5B80")]
	protected KINMLHJHHGE(string HMKAMHBJKHD, string BBHAHPAFMMN, int EDELGNFDFFG = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x9DCD6D0", Offset = "0x9DCCAD0", VA = "0x189DCD6D0")]
	protected KINMLHJHHGE(Material MJMLIEBHGEF, int EDELGNFDFFG = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x9DD58C0", Offset = "0x9DD4CC0", VA = "0x189DD58C0", Slot = "60")]
	public override EFFBADENAPC JCIOENFMGMF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class FAKOJGOFGBC : KINMLHJHHGE
{
	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public override int EMDCBCOJNAB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public override int FFMKCGAKHFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public override int IEOLJFHGFOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public override int PAACLLPCFNH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public override int PDLPCNLNDHF
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x9DCD6F0", Offset = "0x9DCCAF0", VA = "0x189DCD6F0")]
	public FAKOJGOFGBC(string HMKAMHBJKHD, int EDELGNFDFFG = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x9DCD6D0", Offset = "0x9DCCAD0", VA = "0x189DCD6D0")]
	protected FAKOJGOFGBC(Material MJMLIEBHGEF, int EDELGNFDFFG = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x9DCD5A0", Offset = "0x9DCC9A0", VA = "0x189DCD5A0", Slot = "60")]
	public override EFFBADENAPC JCIOENFMGMF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class HDHCOFAOEAH : LFIBDDJBFCC, EFFBADENAPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	protected Material AFDACPAFHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private OAJNGKCLKHC NNLBEGGLIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private double AFDLDIOMMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private Vector2 NPBCIPMLJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private Vector2 NNCGFEHNFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private Vector2 MBKHPFOGEGP;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public Material NOKPIKBDEMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public virtual Texture EAGJNGDJFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x9DD3B80", Offset = "0x9DD2F80", VA = "0x189DD3B80", Slot = "33")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x9DD30A0", Offset = "0x9DD24A0", VA = "0x189DD30A0", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public virtual int EMDCBCOJNAB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public virtual Vector2 CKMPBFPPOFP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x9DD3940", Offset = "0x9DD2D40", VA = "0x189DD3940", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public virtual double DLFNEOOEGNA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public virtual Vector2 MONPLPKOJAB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x9DD3BF0", Offset = "0x9DD2FF0", VA = "0x189DD3BF0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public virtual int HPAHIOIJCKI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "39")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public virtual double NHNMJJHABJN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x9DD3350", Offset = "0x9DD2750", VA = "0x189DD3350", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public virtual Texture OOHCDMAJGCG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x9DD2F70", Offset = "0x9DD2370", VA = "0x189DD2F70", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public virtual int FFMKCGAKHFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public virtual Vector2 FMEDOPIODNN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x9DD2E50", Offset = "0x9DD2250", VA = "0x189DD2E50", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public virtual double EPGCAFBLBOO
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public virtual Vector2 CANAMNCJBPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x9DD39B0", Offset = "0x9DD2DB0", VA = "0x189DD39B0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public virtual int CCMHJDOFDKC
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public virtual double FDOGAEPEOJN
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x9DD3D20", Offset = "0x9DD3120", VA = "0x189DD3D20", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public virtual Texture IBMIHFJKJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x9DD3180", Offset = "0x9DD2580", VA = "0x189DD3180", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public virtual int IEOLJFHGFOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public virtual Vector2 HILGDAIMEOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x9DD32E0", Offset = "0x9DD26E0", VA = "0x189DD32E0", Slot = "50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public virtual double PKHOIGOAKAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public virtual Vector2 JHAJGCJGPEF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x9DD3AF0", Offset = "0x9DD2EF0", VA = "0x189DD3AF0", Slot = "52")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public virtual int EELIIADGDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public virtual Color KDNMKHBIEMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x9DD3410", Offset = "0x9DD2810", VA = "0x189DD3410", Slot = "54")]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x9DD2EC0", Offset = "0x9DD22C0", VA = "0x189DD2EC0", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public virtual OAJNGKCLKHC PNHKKLFBNCM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x9DD34B0", Offset = "0x9DD28B0", VA = "0x189DD34B0", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public virtual double MMAKFPPLPBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x9DD2DC0", Offset = "0x9DD21C0", VA = "0x189DD2DC0", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public virtual bool DJEMGNCNDEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x9DD3030", Offset = "0x9DD2430", VA = "0x189DD3030", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public virtual bool FFMHACAJGBE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x9DD3260", Offset = "0x9DD2660", VA = "0x189DD3260", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x9DD3F00", Offset = "0x9DD3300", VA = "0x189DD3F00")]
	protected HDHCOFAOEAH(string HMKAMHBJKHD, string OBKJAMCALJP, int EDELGNFDFFG = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x9DD3DE0", Offset = "0x9DD31E0", VA = "0x189DD3DE0")]
	protected HDHCOFAOEAH(Material AMAOJDGFJIG, int EDELGNFDFFG = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x9DD3A40", Offset = "0x9DD2E40", VA = "0x189DD3A40", Slot = "60")]
	public virtual EFFBADENAPC JCIOENFMGMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x9DD3C80", Offset = "0x9DD3080", VA = "0x189DD3C80", Slot = "61")]
	protected virtual void PKJKLOPGALM(LFIBDDJBFCC DJOJHAINEJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface EFFBADENAPC
{
	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	Material NOKPIKBDEMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	OAJNGKCLKHC PNHKKLFBNCM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	double MMAKFPPLPBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	bool DJEMGNCNDEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	bool FFMHACAJGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EFFBADENAPC JCIOENFMGMF();
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface LFIBDDJBFCC : EFFBADENAPC
{
	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	Texture EAGJNGDJFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	int EMDCBCOJNAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	double NHNMJJHABJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	Vector2 CKMPBFPPOFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	double DLFNEOOEGNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	Vector2 MONPLPKOJAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	int HPAHIOIJCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	Texture OOHCDMAJGCG
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	int FFMKCGAKHFH
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	double FDOGAEPEOJN
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	Vector2 FMEDOPIODNN
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	double EPGCAFBLBOO
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	Vector2 CANAMNCJBPB
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	int CCMHJDOFDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	Texture IBMIHFJKJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	int IEOLJFHGFOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(Slot = "16")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	Color KDNMKHBIEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(Slot = "18")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	Vector2 HILGDAIMEOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	double PKHOIGOAKAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(Slot = "20")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	Vector2 JHAJGCJGPEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	int EELIIADGDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(Slot = "22")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface IEDBBPABGHD : LFIBDDJBFCC, EFFBADENAPC
{
	[Cpp2IlInjected.Token(Token = "0x17000107")]
	Texture JCPLBLKONOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	int DMJAIGAPCHO
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	Vector2 GCCLFFOFFLO
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	double DPNABHJDFNO
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	Vector2 IGOJFIBPHBK
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	int DEHFMOBCNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	Color IDDGGPJDMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	Texture NHCEKGFLOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	int PMKBBBGELEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	Vector2 KIKAJNNFILO
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	double FCGEDEHABBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	Vector2 BIGJCFMEKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	int CAFCFCBKJLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(Slot = "12")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	double LBNLMDIAGCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	double CLCCKHCFLBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public interface CBIKEGLFGHA : IEDBBPABGHD, LFIBDDJBFCC, EFFBADENAPC
{
	[Cpp2IlInjected.Token(Token = "0x17000116")]
	double JDGEHDFDAKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	Texture MGONMALMEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	Vector2 FKPDFKNHGOB
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	double KDGFMGPLCFK
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	Vector2 DNDOMNEOELK
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	int KPAFHEFMFDI
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	double DHEMBCHJHPK
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	Color NJAKIDMGEDD
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public interface BJKKDGAHDGG : IEDBBPABGHD, LFIBDDJBFCC, EFFBADENAPC
{
	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	double CIPNJFHEIHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	Texture KMLHFOCIGIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	Vector2 CPEJNNCIBPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	double JNCMJBGOLFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	Vector2 GDBAALIPFPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	int JKDICOJBFDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public interface FIBMNDCDFJI : IEDBBPABGHD, LFIBDDJBFCC, EFFBADENAPC
{
	[Cpp2IlInjected.Token(Token = "0x17000124")]
	float GPLLMBFBIDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	Color PPJIAABMMHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	Texture KFNGOMLLECA
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	double FFGLDPCICLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	Vector2 DCDEHJNBECA
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	Vector2 HPHOPEAJJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	int KCLJIMFDDLG
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	Texture POALEEHKGNG
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	double MHNCJINALFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	Vector2 JGLDHPPLDLL
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	Vector2 MILFNCFGOMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	int EEDMGACPNCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public interface HALHEHLCJFL : BJKKDGAHDGG, IEDBBPABGHD, LFIBDDJBFCC, EFFBADENAPC
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	float DKOIBJIAKNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public interface NJBOBPACPEG : IEDBBPABGHD, LFIBDDJBFCC, EFFBADENAPC
{
	[Cpp2IlInjected.Token(Token = "0x17000131")]
	double AMIJGKOALBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public interface EAKPEOFALDB : IEDBBPABGHD, LFIBDDJBFCC, EFFBADENAPC
{
	[Cpp2IlInjected.Token(Token = "0x17000132")]
	double AJMJBHDLABB
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	Texture ANIBMJAIFKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	Vector2 IDBEIAICADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	double GILFAENEMHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	Vector2 BALMGDNMKNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	int FMAOGLJGAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	Color LFEGAHBLNFM
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	Texture EBDLDJBEOEC
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	Vector2 IOFFEBEPHPK
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	double IFKFAKIHKCN
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	Vector2 OIJGIAMHKPB
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	int OOGGPBNGDJN
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public interface FOHJDHMBGCA : IEDBBPABGHD, LFIBDDJBFCC, EFFBADENAPC
{
	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	double OIEGLOPIOJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	double PBHLCCFPCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	double AIDMGNBOMCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	double EJMNGAIELEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	Texture JKEBLDBMKHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	Vector2 GMJGNIBBHJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	double BEIMJIPLPAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	Vector2 NLEJPAHLHGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	int BMBJAGHMEJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	Texture PEJMFGMABJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	Vector2 OGAOPIOFKLC
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	double IJEMGOJPJOL
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	Vector2 IJHNAAGIFHI
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	int LNGCIAKBIIC
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public interface HOAICHHICJE : LFIBDDJBFCC, EFFBADENAPC
{
	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	Texture OIFACDPCJBA
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	int PAACLLPCFNH
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	Vector2 JLLEAPHGLNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	double GAIJKLPMGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	Vector2 IIHNBGAELJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	int EPGHAHOBHEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	Color ADBDMFMAHDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	Texture FDPIMMFEAPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	int PDLPCNLNDHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	Vector2 EGENOFDOEJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	double OBFJICEBADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	Vector2 ALBJOPPABIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	int MNBFCJAOPNN
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	Vector3 AJMJBHDLABB
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	double GGEDEOPPHMM
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public interface JJKNOOCBILN : IEDBBPABGHD, LFIBDDJBFCC, EFFBADENAPC
{
	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	double HLAMCJGKEKI
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	Texture KEPEBMLILDI
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	Vector2 EJMMMPEJEFG
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	double CDDBAIPGHDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	Vector2 GFOAJCNHFGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	int NBELCCMMCJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	double ENJLDBMPKFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	Texture CNMNFDAHDDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	Vector2 LMHIPPGILMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	double DBDNADJADAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	Vector2 GPOGLJLJNOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	int EDKHEEOFAND
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public interface KKOMLHEGOOF
{
	[Cpp2IlInjected.Token(Token = "0x17000167")]
	Texture BBBICOMAEMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	Vector2 PEOKJAEFLJI
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	double JLACJNKJGCC
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	Vector2 HMCKFAPMLHO
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	int NLCAMLIBNAI
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public interface BMPHOFNPGEB
{
	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	Texture MODNNFPMCFG
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	Vector2 LBPPDAGDFPE
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	double PFMGFICPFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	Vector2 KIMEHFFHBKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	int EKBAABNIEHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	double FGAIFDOGAMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	double OBNPEKLIHKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public interface OPBKPLKMGKL : EFFBADENAPC
{
	[Cpp2IlInjected.Token(Token = "0x17000173")]
	Texture JCPLBLKONOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	int DMJAIGAPCHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	Vector2 GCCLFFOFFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	double DPNABHJDFNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	Vector2 IGOJFIBPHBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	int DEHFMOBCNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	Color IDDGGPJDMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class FCFOMFILDOO : EJLJFIELBLE, OPBKPLKMGKL, EFFBADENAPC
{
	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x9DCED60", Offset = "0x9DCE160", VA = "0x189DCED60")]
	public FCFOMFILDOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x9DCEC80", Offset = "0x9DCE080", VA = "0x189DCEC80")]
	protected FCFOMFILDOO(string HMKAMHBJKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x9DCECF0", Offset = "0x9DCE0F0", VA = "0x189DCECF0")]
	public FCFOMFILDOO(Material AMAOJDGFJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x9DCEB70", Offset = "0x9DCDF70", VA = "0x189DCEB70", Slot = "10")]
	public override EFFBADENAPC JCIOENFMGMF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class OCNIGHCEIEO : HDHCOFAOEAH, OPBKPLKMGKL, EFFBADENAPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private Vector2 GJAFHNLCAFG;

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public Texture JCPLBLKONOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x9DDB300", Offset = "0x9DDA700", VA = "0x189DDB300", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public virtual int DMJAIGAPCHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public virtual Vector2 GCCLFFOFFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x9DDB3D0", Offset = "0x9DDA7D0", VA = "0x189DDB3D0", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public virtual double DPNABHJDFNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public virtual Vector2 IGOJFIBPHBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x9DDB270", Offset = "0x9DDA670", VA = "0x189DDB270", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	public virtual int DEHFMOBCNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	public virtual Color IDDGGPJDMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x9DDB360", Offset = "0x9DDA760", VA = "0x189DDB360", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x9DD1920", Offset = "0x9DD0D20", VA = "0x189DD1920")]
	public OCNIGHCEIEO(string HMKAMHBJKHD, string BBHAHPAFMMN, int EDELGNFDFFG = 1000)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class KJPEIALEBKA
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public delegate void IHLLKAGBAPL(FOFIBOMOIBN NGGPANNMNBG);

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public delegate void LDOAMNCFFGO(PJOMGBFLBDE NGGPANNMNBG);

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class PJOMGBFLBDE
	{
		[Cpp2IlInjected.Token(Token = "0x17000183")]
		private Bounds JHJMDEAAPML
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x9248D70", Offset = "0x9248170", VA = "0x189248D70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000184")]
		private CENIKCKFPGL OMHNBMAFMDF
		{
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000185")]
		private PMNJJNLALOI NEGFFMBOECP
		{
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x9DEBE50", Offset = "0x9DEB250", VA = "0x189DEBE50")]
		internal PJOMGBFLBDE(Bounds KGBBNCCBJME, CENIKCKFPGL HAIJNNMMFMM, PMNJJNLALOI NGJGEBLCKFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class FOFIBOMOIBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		internal ELDFMMKKLGF.HDLJOAJLPMN LGAFOALCIPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public float[] LIOPOAMFJMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public object[] ALLICKBJCMD;

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xDA1DB0", Offset = "0xDA11B0", VA = "0x180DA1DB0")]
		internal FOFIBOMOIBN(ELDFMMKKLGF.HDLJOAJLPMN LEGBAJKMFEK, float[] HALABAAPLEK, object[] EJCCOPPBIIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	internal class ELDFMMKKLGF
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		internal class FAMPEGJMCMG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			public string MDDEFFMKGMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			public Type JFBHJADDBNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			public Func<Transform, UnityEngine.Object> JKJGAKDEDGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			public Func<Transform, UnityEngine.Object, ELDFMMKKLGF, object> GLIFNCBFEHC;

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x10BB460", Offset = "0x10BA860", VA = "0x1810BB460")]
			public FAMPEGJMCMG(string MDDEFFMKGMP, Type JFBHJADDBNB, Func<Transform, UnityEngine.Object> JKJGAKDEDGK, Func<Transform, UnityEngine.Object, ELDFMMKKLGF, object> GLIFNCBFEHC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x9DDE400", Offset = "0x9DDD800", VA = "0x189DDE400")]
			public object MFLMGFDMJMP(ELDFMMKKLGF NGIAGNLBILI)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000098")]
		internal class HDLJOAJLPMN
		{
			[Cpp2IlInjected.Token(Token = "0x2000099")]
			private class BHBDOECALPO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000376")]
				public double GIKDKPMHFDA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000377")]
				public object CBMEHPPMEEA;

				[Cpp2IlInjected.Token(Token = "0x60003B7")]
				[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
				public BHBDOECALPO()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			private ELDFMMKKLGF LEGBAJKMFEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			private FAMPEGJMCMG NOPOBINEFNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			private Dictionary<double, object> IDHGNOPFHHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			private BHBDOECALPO EMCEDDFGDKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			private BHBDOECALPO KBINJKFNHCF;

			[Cpp2IlInjected.Token(Token = "0x17000186")]
			public UnityEngine.Object EIMHDDKMIGJ
			{
				[Cpp2IlInjected.Token(Token = "0x60003B1")]
				[Cpp2IlInjected.Address(RVA = "0x9DDF100", Offset = "0x9DDE500", VA = "0x189DDF100")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000187")]
			public string MDDEFFMKGMP
			{
				[Cpp2IlInjected.Token(Token = "0x60003B2")]
				[Cpp2IlInjected.Address(RVA = "0x59FF0B0", Offset = "0x59FE4B0", VA = "0x1859FF0B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000188")]
			public float[] HALABAAPLEK
			{
				[Cpp2IlInjected.Token(Token = "0x60003B3")]
				[Cpp2IlInjected.Address(RVA = "0x9DDEF90", Offset = "0x9DDE390", VA = "0x189DDEF90")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000189")]
			public object[] EJCCOPPBIIG
			{
				[Cpp2IlInjected.Token(Token = "0x60003B4")]
				[Cpp2IlInjected.Address(RVA = "0x9DDF390", Offset = "0x9DDE790", VA = "0x189DDF390")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x9DDF3F0", Offset = "0x9DDE7F0", VA = "0x189DDF3F0")]
			public HDLJOAJLPMN(ELDFMMKKLGF LEGBAJKMFEK, FAMPEGJMCMG NOPOBINEFNP, double GIKDKPMHFDA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x9DDF140", Offset = "0x9DDE540", VA = "0x189DDF140")]
			public void GKGIDCPEGMP(double GIKDKPMHFDA)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		internal Transform LEGBAJKMFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private SkinnedMeshRenderer HIFHHFKLDND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private bool IIELEELOGJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private bool NOHJGAMBFPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private bool CPPIBIAPOHJ;

		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private static List<FAMPEGJMCMG> IPPEGKLDNEP;

		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private static MaterialPropertyBlock IPFJJAOFFIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		internal List<HDLJOAJLPMN> KAJADFBEMCD;

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x9DDD500", Offset = "0x9DDC900", VA = "0x189DDD500")]
		public ELDFMMKKLGF(Transform LEGBAJKMFEK, double GIKDKPMHFDA, bool FIMOOGJGHBF = false, bool IIELEELOGJA = true, bool NOHJGAMBFPD = false, bool CPPIBIAPOHJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x9DDD350", Offset = "0x9DDC750", VA = "0x189DDD350")]
		public void OGELNPLKAMN(double GIKDKPMHFDA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	internal ICollection<Transform> LDBGDFKEFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private Transform LDEPDDDHLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private Dictionary<Transform, ELDFMMKKLGF> NGIAGNLBILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private double PJLONFPDOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private double BCKFDMCDEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private bool GKNIEHLLMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	private bool GBOCHPEAMOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private readonly bool IIELEELOGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	private readonly bool MJMANBPICDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private readonly bool CPPIBIAPOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public string KEKPLCBENHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public IHLLKAGBAPL FGKIHPDIFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public LDOAMNCFFGO JEDEGKONMND;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	private static ProfilerMarker HHEFKLEFLFP;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private static ProfilerMarker KFKFLPDGIDP;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private static ProfilerMarker OBLNBACHNML;

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	public bool BACDCAMCLAH
	{
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x152AB90", Offset = "0x1529F90", VA = "0x18152AB90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	public double OBBIKGMAOLA
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x75E8970", Offset = "0x75E7D70", VA = "0x1875E8970")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x9DD7580", Offset = "0x9DD6980", VA = "0x189DD7580")]
	public KJPEIALEBKA(Transform LDEPDDDHLLO, bool IIELEELOGJA = true, bool MJMANBPICDN = false, bool CPPIBIAPOHJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x9DD5BA0", Offset = "0x9DD4FA0", VA = "0x189DD5BA0")]
	private bool BDKCGNBFHIP(Transform LEGBAJKMFEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x9DD6160", Offset = "0x9DD5560", VA = "0x189DD6160")]
	public void HOBLBLPPNBI(double GIKDKPMHFDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x9DD5E70", Offset = "0x9DD5270", VA = "0x189DD5E70")]
	public void GEAEMFMFAMA(double GIKDKPMHFDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x9DD6900", Offset = "0x9DD5D00", VA = "0x189DD6900")]
	public void PMGBNGMKPCN(string AFMPILNIBJI, string CGAJOJLBJOM = "scene", [Optional] GLTFSettings FKBCJNJEHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x9DD6A80", Offset = "0x9DD5E80", VA = "0x189DD6A80")]
	public void PMGBNGMKPCN(Stream GBHJNKNIPGA, string CGAJOJLBJOM = "scene", [Optional] GLTFSettings FKBCJNJEHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x9DD5C60", Offset = "0x9DD5060", VA = "0x189DD5C60")]
	private void EPEMCMEJNLO(CENIKCKFPGL HAIJNNMMFMM, PMNJJNLALOI NGJGEBLCKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x9DD63A0", Offset = "0x9DD57A0", VA = "0x189DD63A0")]
	private void IGCFJDOFDIO(CENIKCKFPGL DBALLOEGOMJ, HKPHIBPBAKP CDDFMFMJKNO, bool HNFODDPJBCE, [Out] Bounds FGCPPGGOKLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public class PCINHOCLEPA : PlayableBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	private sealed class OFBMJDFPFBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public PCINHOCLEPA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public OFBMJDFPFBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x9DEAD90", Offset = "0x9DEA190", VA = "0x189DEAD90")]
		internal void DGDICEABONL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400038A")]
	private KJPEIALEBKA AKGENALANDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public GLTFRecorderClip FONHPNMNIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400038C")]
	private bool JFEBNBOFHHB;

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x9DEB680", Offset = "0x9DEAA80", VA = "0x189DEB680")]
	private void OEDLIDGGONJ(double DPLPIJALPIC, Transform DBJGBMODBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x9DEBA20", Offset = "0x9DEAE20", VA = "0x189DEBA20")]
	private void PFODHDCAFOC(double DPLPIJALPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x9DEB550", Offset = "0x9DEA950", VA = "0x189DEB550")]
	private void IOOCCPLJEOL(double DPLPIJALPIC, Transform DBJGBMODBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690")]
	private static bool IMOLPPGMOJM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x9DEB980", Offset = "0x9DEAD80", VA = "0x189DEB980", Slot = "16")]
	public override void OnPlayableDestroy(Playable GNKCIGICLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x9DEB750", Offset = "0x9DEAB50", VA = "0x189DEB750", Slot = "13")]
	public override void OnGraphStart(Playable GNKCIGICLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x9DEB8E0", Offset = "0x9DEACE0", VA = "0x189DEB8E0", Slot = "14")]
	public override void OnGraphStop(Playable GNKCIGICLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x9DEBA80", Offset = "0x9DEAE80", VA = "0x189DEBA80", Slot = "20")]
	public override void ProcessFrame(Playable GNKCIGICLMH, FrameData LFDKNECEJEF, object FDPKLGPDEKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x24F2FB0", Offset = "0x24F23B0", VA = "0x1824F2FB0", Slot = "17")]
	public override void OnBehaviourPlay(Playable GNKCIGICLMH, FrameData LFDKNECEJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0xD1E460", Offset = "0xD1D860", VA = "0x180D1E460", Slot = "18")]
	public override void OnBehaviourPause(Playable GNKCIGICLMH, FrameData LFDKNECEJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x9DEB320", Offset = "0x9DEA720", VA = "0x189DEB320")]
	public void IFCNENKEEEL(double GIKDKPMHFDA, Playable GNKCIGICLMH, FrameData LFDKNECEJEF, object FDPKLGPDEKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
	public PCINHOCLEPA()
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
			[Cpp2IlInjected.Address(RVA = "0xAD8D80", Offset = "0xAD8180", VA = "0x180AD8D80", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(ClipCaps);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x9DDE780", Offset = "0x9DDDB80", VA = "0x189DDE780", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph KBCGJHHFJKD, GameObject CCGANJILKHA)
		{
			return default(Playable);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x9DDE720", Offset = "0x9DDDB20", VA = "0x189DDE720")]
		public Transform CMDNELCIBEH(PlayableGraph KBCGJHHFJKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x9DDE890", Offset = "0x9DDDC90", VA = "0x189DDE890")]
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
		private sealed class GELFKCDEABK : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
			[DebuggerHidden]
			public GELFKCDEABK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x9DDE470", Offset = "0x9DDD870", VA = "0x189DDE470", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x9DDE6B0", Offset = "0x9DDDAB0", VA = "0x189DDE6B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private List<Action> LBHKLOCBOCE;

		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private static GLTFRecorderHelper CDEDDCLKCCJ;

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x9DDE920", Offset = "0x9DDDD20", VA = "0x189DDE920")]
		public static void Add(Action BFDLNHAHOHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x9DDEB60", Offset = "0x9DDDF60", VA = "0x189DDEB60")]
		private static GLTFRecorderHelper JGMEPBBLGLA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x9DDED80", Offset = "0x9DDE180", VA = "0x189DDED80")]
		[IteratorStateMachine(typeof(GELFKCDEABK))]
		private IEnumerator MFCPKENNODJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x9DDED00", Offset = "0x9DDE100", VA = "0x189DDED00")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x9DDEE00", Offset = "0x9DDE200", VA = "0x189DDEE00")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DDEE90", Offset = "0x9DDE290", VA = "0x189DDEE90")]
		public GLTFRecorderTrack()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
internal static class LPDKGHGHMHB
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class BLCFIEMFDEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public int primaryComponentCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public HIANDPFIMOB propertyMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public AMFNCJMAPJJ pointerDataCopy;

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public BLCFIEMFDEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x9DDCC70", Offset = "0x9DDC070", VA = "0x189DDCC70")]
		internal float[] PIFHCNIJCPL(AMFNCJMAPJJ data, int frame)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x9DDCB50", Offset = "0x9DDBF50", VA = "0x189DDCB50")]
		internal float[] JJBDEFOADPF(AMFNCJMAPJJ data, int frame)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x9DDCAC0", Offset = "0x9DDBEC0", VA = "0x189DDCAC0")]
		internal float[] IHAMENEIMEK(AMFNCJMAPJJ data, int frame)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x9DDCBE0", Offset = "0x9DDBFE0", VA = "0x189DDCBE0")]
		internal float[] PIAENBOONOD(AMFNCJMAPJJ data, int frame)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	private static readonly string[] DNKAINNHBLK;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	private static readonly string[] AMGLHPGMBJJ;

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x9DE3B80", Offset = "0x9DE2F80", VA = "0x189DE3B80")]
	internal static bool HPONDOCDBAC(string IHJAPFCOJBD, NBCNOBCINEK LHIIANOMPAH, Material GMFBEMFEGJH, string GADALMDJODD, BBDNLDIFIMC JHIELHEPCMO, [Out] AMFNCJMAPJJ LNKKIABIBHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x9DE38D0", Offset = "0x9DE2CD0", VA = "0x189DE38D0")]
	internal static string[] EIICGLPMJAA(string MDDEFFMKGMP, int LIDJJKKCIOH, int DJDNDCFHCAJ = 0, bool JBFIAABJFBD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x9DE4140", Offset = "0x9DE3540", VA = "0x189DE4140")]
	internal static float[] IEINNICFCEG(int NOEININIMIL, int LIDJJKKCIOH, HIANDPFIMOB FKMIOCNPCCJ, AMFNCJMAPJJ LNKKIABIBHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class HIANDPFIMOB
{
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public enum COKECOLEDFD
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
	public enum PNJKAMKHMDM
	{
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		SameAsPrimary,
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		Override
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public delegate float[] OJLBGHLKGAF(float[] GDBBAIIJEDL, float[] OOBCMIIIIOM, int PCBCEAOJNEA);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public COKECOLEDFD NBFFAIKCBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public string CKEPLJOPOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public string NELEJGPLEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public bool BKELKCBNEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public PNJKAMKHMDM FCHMJHGAPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public CIIKKHFECMM EJHLBDGJBEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public bool JMCDAAJKCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public bool EMKHMDDNECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x36")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public bool FFOMACCIMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public float FODHJGBFONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public string MKNCCDHABNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public OJLBGHLKGAF KFCOPFMJJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private string[] ICNLOMIHFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	internal int[] NANEOCENNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	internal int[] OJDPGCBDJFA;

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	public string[] KDLPMNGKKIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xA70280", Offset = "0xA6F680", VA = "0x180A70280")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x9DDF4C0", Offset = "0x9DDE8C0", VA = "0x189DDF4C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	public bool DHAHDCPEEJD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x9DDF7E0", Offset = "0x9DDEBE0", VA = "0x189DDF7E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x9DDF8A0", Offset = "0x9DDECA0", VA = "0x189DDF8A0")]
	public HIANDPFIMOB(COKECOLEDFD BFNAOJPNIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x9DDF640", Offset = "0x9DDEA40", VA = "0x189DDF640")]
	private void GBECBDNDKON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x9DDF4F0", Offset = "0x9DDE8F0", VA = "0x189DDF4F0")]
	private static float[] FNJIHINAKAN(float[] GDBBAIIJEDL, float[] OOBCMIIIIOM, int PCBCEAOJNEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x9DDF800", Offset = "0x9DDEC00", VA = "0x189DDF800")]
	private void PJGJCIOJIKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class NBCNOBCINEK
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public enum PLBNPLKELDH
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
	private Dictionary<string, HIANDPFIMOB> OFEMKKEDJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	private Dictionary<string, HIANDPFIMOB> LIGHAOINEHA;

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x9DE59B0", Offset = "0x9DE4DB0", VA = "0x189DE59B0")]
	public void PAHLMOCFNGC(string IFCDJPIAKKD, string[] ICFNIFOJMBL, [Optional] string BJNAOAPMOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x9DE5570", Offset = "0x9DE4970", VA = "0x189DE5570")]
	public void FAHOMBMHLFF(HIANDPFIMOB FKMIOCNPCCJ, PLBNPLKELDH HFGIBLIADPB = PLBNPLKELDH.ImportAndExport)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x9DE5790", Offset = "0x9DE4B90", VA = "0x189DE5790")]
	public bool MJFCBNEBGBM(Material AMAOJDGFJIG, string KCKFIEFHBKJ, [Out] HIANDPFIMOB FKMIOCNPCCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x9DE51A0", Offset = "0x9DE45A0", VA = "0x189DE51A0")]
	public bool CKGCBHDNJFE(Material AMAOJDGFJIG, string BKDPAJGCGNC, [Out] string MDDEFFMKGMP, [Out] HIANDPFIMOB FKMIOCNPCCJ, [Out] bool LKMKICMBGOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x9DE6080", Offset = "0x9DE5480", VA = "0x189DE6080")]
	public NBCNOBCINEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public class NKEDCHPLJBP : NBCNOBCINEK
{
	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x9DE6140", Offset = "0x9DE5540", VA = "0x189DE6140")]
	public NKEDCHPLJBP()
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
			[Cpp2IlInjected.Address(RVA = "0x9DDC850", Offset = "0x9DDBC50", VA = "0x189DDC850", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000190")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0x9DDC820", Offset = "0x9DDBC20", VA = "0x189DDC820", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000191")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x9DDC770", Offset = "0x9DDBB70", VA = "0x189DDC770", Slot = "14")]
		public override DOPOEHGBNMC DGPAGPJNMNG(OOOLKIAIIAN HFJHENFIDEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x1555490", Offset = "0x1554890", VA = "0x181555490")]
		public AnimationPointerExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public class JAJCCHHMCLE : DOPOEHGBNMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public NBCNOBCINEK IPHINNDJMKI;

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x9DE03A0", Offset = "0x9DDF7A0", VA = "0x189DE03A0")]
	public JAJCCHHMCLE()
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
			[Cpp2IlInjected.Address(RVA = "0x9DDC960", Offset = "0x9DDBD60", VA = "0x189DDC960", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000193")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x9DDC930", Offset = "0x9DDBD30", VA = "0x189DDC930", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x9DDC880", Offset = "0x9DDBC80", VA = "0x189DDC880", Slot = "13")]
		public override MILFNMHALHA DGPAGPJNMNG(PJEHNIFJDKO HFJHENFIDEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x1555490", Offset = "0x1554890", VA = "0x181555490")]
		public AnimationPointerImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class AMCIMOEDEHJ : MILFNMHALHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public NBCNOBCINEK IPHINNDJMKI;

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x9DDC6F0", Offset = "0x9DDBAF0", VA = "0x189DDC6F0")]
	public AMCIMOEDEHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[AttributeUsage(AttributeTargets.Class)]
public class GAIKBIHOOGP : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public string GGNOKCHEJFE;

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0xA99B00", Offset = "0xA98F00", VA = "0x180A99B00")]
	public GAIKBIHOOGP([Optional] string GGNOKCHEJFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[AttributeUsage(AttributeTargets.Class)]
public class EDCIJEIBKAE : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public string GGNOKCHEJFE;

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0xA99B00", Offset = "0xA98F00", VA = "0x180A99B00")]
	public EDCIJEIBKAE([Optional] string GGNOKCHEJFE)
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
			[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(Slot = "14")]
		public abstract DOPOEHGBNMC DGPAGPJNMNG(OOOLKIAIIAN HFJHENFIDEF);

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x1555490", Offset = "0x1554890", VA = "0x181555490")]
		protected GLTFExportPlugin()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public abstract class DOPOEHGBNMC
{
	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public virtual void CLJGGLIODMN(CENIKCKFPGL HAIJNNMMFMM, PMNJJNLALOI NGJGEBLCKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
	public virtual void PNAFJOGCKMC(CENIKCKFPGL HAIJNNMMFMM, PMNJJNLALOI NGJGEBLCKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "6")]
	public virtual bool IPCDOEKLBDB(CENIKCKFPGL HAIJNNMMFMM, PMNJJNLALOI NGJGEBLCKFB, Transform GANAIKEBLIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "7")]
	public virtual void FJCNJMJABAJ(CENIKCKFPGL HAIJNNMMFMM, PMNJJNLALOI NGJGEBLCKFB, Transform GANAIKEBLIG, FIPHLEDNLPF BLJBPFHLMML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "8")]
	public virtual void FOFLGJKJPFI(CENIKCKFPGL HAIJNNMMFMM, PMNJJNLALOI NGJGEBLCKFB, Transform GANAIKEBLIG, FIPHLEDNLPF BLJBPFHLMML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "9")]
	public virtual bool GKEAJOHNDBK(CENIKCKFPGL HAIJNNMMFMM, PMNJJNLALOI NGJGEBLCKFB, Material GMFBEMFEGJH, INLMCJFCOPF ANBGNMOFNEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "10")]
	public virtual void KJIFEILAPIN(CENIKCKFPGL HAIJNNMMFMM, PMNJJNLALOI NGJGEBLCKFB, Material GMFBEMFEGJH, INLMCJFCOPF ANBGNMOFNEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "11")]
	public virtual void PIJBIMOFLGE(CENIKCKFPGL HAIJNNMMFMM, CENIKCKFPGL.FNIFBJIKCDJ IOFLDLKHGCB, string KNNFDFCLOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "12")]
	public virtual void ACNJNFGJJEJ(CENIKCKFPGL HAIJNNMMFMM, CENIKCKFPGL.FNIFBJIKCDJ IOFLDLKHGCB, int NOEININIMIL, KGHMDFPAGCC MEMLPMCKIJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "13")]
	public virtual void GICGDBAHDFL(CENIKCKFPGL HAIJNNMMFMM, Mesh NIKBNBLEJEO, NENMAJLCAIO BBJELFHBAMM, int NOEININIMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "14")]
	public virtual void IFNFCMBJFIM(CENIKCKFPGL HAIJNNMMFMM, Mesh NIKBNBLEJEO, IOHOGCBKNJA COIFEIMFCGJ, int NOEININIMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	protected DOPOEHGBNMC()
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
		public abstract MILFNMHALHA DGPAGPJNMNG(PJEHNIFJDKO HFJHENFIDEF);

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x1555490", Offset = "0x1554890", VA = "0x181555490")]
		protected GLTFImportPlugin()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public abstract class MILFNMHALHA
{
	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public virtual void GKCPHCKNHCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
	public virtual void PLLINOPKBKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "6")]
	public virtual void JJIFHKHHLEP(PMNJJNLALOI NGJGEBLCKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "7")]
	public virtual void NACLGPLPDPN(HLGNGKKCPCP CHBELKDGKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "8")]
	public virtual void DIGBDCHILEL(FIPHLEDNLPF BLJBPFHLMML, int GAIGLCAGPEN, GameObject JILFFADBPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "9")]
	public virtual void DAMEACPAKGK(INLMCJFCOPF GMFBEMFEGJH, int LGBNJHMFDIE, Material NHAMHPDOINL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "10")]
	public virtual void JBKECDLIHMO(KGHMDFPAGCC IOFLDLKHGCB, int FIMMMHIOKPH, Texture NOPLPNENPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "11")]
	public virtual void GCIMEPEGGHJ(HLGNGKKCPCP CHBELKDGKBD, int HBEJOBODBKL, GameObject FAPCIJDLIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	protected MILFNMHALHA()
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
			[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000197")]
		public virtual string HelpUrl
		{
			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000198")]
		public virtual bool Enabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0x9DDE700", Offset = "0x9DDDB00", VA = "0x189DDE700", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0xA7DA60", Offset = "0xA7CE60", VA = "0x180A7DA60", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		public virtual bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		public virtual bool AlwaysEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		public virtual string Warning
		{
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		public virtual bool PackageMissing
		{
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x1555490", Offset = "0x1554890", VA = "0x181555490")]
		protected GLTFPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[Obsolete("Use UnityGLTF.Plugins.GLTFPlugin instead. (UnityUpgradable) -> UnityGLTF.Plugins.GLTFPlugin")]
	public abstract class GltfPlugin : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0xCFA860", Offset = "0xCF9C60", VA = "0x180CFA860")]
		protected GltfPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[Obsolete("Use UnityGLTF.Plugins.GLTFImportPlugin instead. (UnityUpgradable) -> UnityGLTF.Plugins.GLTFImportPlugin")]
	public abstract class GltfImportPlugin : GltfPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xCFA860", Offset = "0xCF9C60", VA = "0x180CFA860")]
		protected GltfImportPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[Obsolete("Use UnityGLTF.Plugins.GLTFExportPlugin instead. (UnityUpgradable) -> UnityGLTF.Plugins.GLTFExportPlugin")]
	public abstract class GltfExportPlugin : GltfPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0xCFA860", Offset = "0xCF9C60", VA = "0x180CFA860")]
		protected GltfExportPlugin()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public class PJEHNIFJDKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public readonly List<MILFNMHALHA> MOHJGCDKAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public KNDCPNFIJBM ICCPNLICEAM;

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	public PMNJJNLALOI NDDFGLPMAHI
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x9DEBDF0", Offset = "0x9DEB1F0", VA = "0x189DEBDF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x9DEBBD0", Offset = "0x9DEAFD0", VA = "0x189DEBBD0")]
	private List<MILFNMHALHA> GHBMOFNGHLC(GLTFSettings FKBCJNJEHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x9DEBE10", Offset = "0x9DEB210", VA = "0x189DEBE10")]
	internal PJEHNIFJDKO(GLTFSettings FKBCJNJEHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x3ED1000", Offset = "0x3ED0400", VA = "0x183ED1000")]
	public bool OMDHDOJHHME<T>([Out] T DJOJHAINEJD) where T : MILFNMHALHA
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
			[Cpp2IlInjected.Address(RVA = "0x9DDD320", Offset = "0x9DDC720", VA = "0x189DDD320", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0x9DDD2F0", Offset = "0x9DDC6F0", VA = "0x189DDD2F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A0")]
		public override bool PackageMissing
		{
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x9DDD2A0", Offset = "0x9DDC6A0", VA = "0x189DDD2A0", Slot = "13")]
		public override MILFNMHALHA DGPAGPJNMNG(PJEHNIFJDKO HFJHENFIDEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x1555490", Offset = "0x1554890", VA = "0x181555490")]
		public DracoImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public class KMMLKJOLNBE : MILFNMHALHA
{
	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public KMMLKJOLNBE()
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
			[Cpp2IlInjected.Address(RVA = "0x9DDEF60", Offset = "0x9DDE360", VA = "0x189DDEF60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A2")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(RVA = "0x9DDEF30", Offset = "0x9DDE330", VA = "0x189DDEF30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x9DDEEE0", Offset = "0x9DDE2E0", VA = "0x189DDEEE0", Slot = "13")]
		public override MILFNMHALHA DGPAGPJNMNG(PJEHNIFJDKO HFJHENFIDEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x1555490", Offset = "0x1554890", VA = "0x181555490")]
		public GPUInstancingImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public class MBJOANIKEFM : MILFNMHALHA
{
	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public MBJOANIKEFM()
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
			[Cpp2IlInjected.Address(RVA = "0x9DE0D70", Offset = "0x9DE0170", VA = "0x189DE0D70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A4")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0x9DE0D40", Offset = "0x9DE0140", VA = "0x189DE0D40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A5")]
		public override bool PackageMissing
		{
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x9DE0CF0", Offset = "0x9DE00F0", VA = "0x189DE0CF0", Slot = "13")]
		public override MILFNMHALHA DGPAGPJNMNG(PJEHNIFJDKO HFJHENFIDEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x1555490", Offset = "0x1554890", VA = "0x181555490")]
		public Ktx2Import()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public class JGMLCPFBLIO : MILFNMHALHA
{
	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public JGMLCPFBLIO()
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
			[Cpp2IlInjected.Address(RVA = "0x9DE4BA0", Offset = "0x9DE3FA0", VA = "0x189DE4BA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A7")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x9DE4B70", Offset = "0x9DE3F70", VA = "0x189DE4B70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x9DE4B20", Offset = "0x9DE3F20", VA = "0x189DE4B20", Slot = "14")]
		public override DOPOEHGBNMC DGPAGPJNMNG(OOOLKIAIIAN HFJHENFIDEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x1555490", Offset = "0x1554890", VA = "0x181555490")]
		public LightsPunctualExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public class PFGHMCPBJFO : DOPOEHGBNMC
{
	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "8")]
	public override void FOFLGJKJPFI(CENIKCKFPGL HAIJNNMMFMM, PMNJJNLALOI NGJGEBLCKFB, Transform GANAIKEBLIG, FIPHLEDNLPF BLJBPFHLMML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public PFGHMCPBJFO()
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
			[Cpp2IlInjected.Address(RVA = "0x9DE4C50", Offset = "0x9DE4050", VA = "0x189DE4C50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A9")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x9DE4C20", Offset = "0x9DE4020", VA = "0x189DE4C20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x9DE4BD0", Offset = "0x9DE3FD0", VA = "0x189DE4BD0", Slot = "13")]
		public override MILFNMHALHA DGPAGPJNMNG(PJEHNIFJDKO HFJHENFIDEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x1555490", Offset = "0x1554890", VA = "0x181555490")]
		public LightsPunctualImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public class LDNEAIGFMGP : MILFNMHALHA
{
	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public LDNEAIGFMGP()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[GAIKBIHOOGP(null)]
	public class LodsExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0x9DE4D00", Offset = "0x9DE4100", VA = "0x189DE4D00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0x9DE4CD0", Offset = "0x9DE40D0", VA = "0x189DE4CD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x9DE4C80", Offset = "0x9DE4080", VA = "0x189DE4C80", Slot = "14")]
		public override DOPOEHGBNMC DGPAGPJNMNG(OOOLKIAIIAN HFJHENFIDEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x1555490", Offset = "0x1554890", VA = "0x181555490")]
		public LodsExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public class OMHLFCJEMFL : DOPOEHGBNMC
{
	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x9DEAF10", Offset = "0x9DEA310", VA = "0x189DEAF10", Slot = "8")]
	public override void FOFLGJKJPFI(CENIKCKFPGL HAIJNNMMFMM, PMNJJNLALOI OFNPHDNKKOM, Transform GANAIKEBLIG, FIPHLEDNLPF BLJBPFHLMML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public OMHLFCJEMFL()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[GAIKBIHOOGP(null)]
	public class LodsImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000460")]
			[Cpp2IlInjected.Address(RVA = "0x9DE4DB0", Offset = "0x9DE41B0", VA = "0x189DE4DB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0x9DE4D80", Offset = "0x9DE4180", VA = "0x189DE4D80", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x9DE4D30", Offset = "0x9DE4130", VA = "0x189DE4D30", Slot = "13")]
		public override MILFNMHALHA DGPAGPJNMNG(PJEHNIFJDKO HFJHENFIDEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x1555490", Offset = "0x1554890", VA = "0x181555490")]
		public LodsImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public class JCKPAMDBAKN : MILFNMHALHA
{
	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public JCKPAMDBAKN()
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
			[Cpp2IlInjected.Address(RVA = "0x9DE4FD0", Offset = "0x9DE43D0", VA = "0x189DE4FD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0x9DE4FA0", Offset = "0x9DE43A0", VA = "0x189DE4FA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x9DE4F10", Offset = "0x9DE4310", VA = "0x189DE4F10", Slot = "14")]
		public override DOPOEHGBNMC DGPAGPJNMNG(OOOLKIAIIAN HFJHENFIDEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x9DE4F80", Offset = "0x9DE4380", VA = "0x189DE4F80")]
		public MaterialExtensionsExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public class LHOAEPOMIPD : DOPOEHGBNMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	internal readonly MaterialExtensionsExport FKBCJNJEHBA;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private static readonly int DNMMCGJHGEP;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private static readonly int AOALIFPGOGJ;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private static readonly int KBCNKCPOFPA;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	private static readonly int PKLJIOEEBPG;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	private static readonly int BKBFAMNJGJO;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	private static readonly int KCONAGIJHFP;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	private static readonly int AKOGDGNKJLP;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	private static readonly int HFCPOLCHGAL;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	private static readonly int DPMKNGMAOBG;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	private static readonly int PKEBNFPHGPP;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	private static readonly int KFIAPGKPEGM;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	private static readonly int FCPDGPCMKGL;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	private static readonly int JDMLMKBFAMM;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	private static readonly int GHAMLDCOLAG;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	private static readonly int HOMMJHEMDEE;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	private static readonly int MJLBIFCJEIB;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	private static readonly int LCCCHANHCDF;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	private static readonly int AMOLEMPPCIH;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	private static readonly int IPLGEKPMIJH;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	private static readonly int KLFGGIEFOIP;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	private static readonly int AKJOEDDEPLB;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	private static readonly int BCIONINMDHP;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	private static readonly int PPCFLPIOMHI;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	private static readonly int OGAKFGKDCNH;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	private static readonly int DPJHBNMEFAP;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	private static readonly int MBADAJFCPKF;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	private static readonly int LCPPIOHFNGD;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	private static readonly int FGAIFDOGAMM;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	private static readonly int OBNPEKLIHKB;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	private static readonly int MODNNFPMCFG;

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0xA75990", Offset = "0xA74D90", VA = "0x180A75990")]
	public LHOAEPOMIPD(MaterialExtensionsExport FKBCJNJEHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x9DE0DA0", Offset = "0x9DE01A0", VA = "0x189DE0DA0", Slot = "10")]
	public override void KJIFEILAPIN(CENIKCKFPGL HAIJNNMMFMM, PMNJJNLALOI OFNPHDNKKOM, Material GMFBEMFEGJH, INLMCJFCOPF FLJNHHPCAIE)
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
			[Cpp2IlInjected.Address(RVA = "0x9DE50C0", Offset = "0x9DE44C0", VA = "0x189DE50C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0x9DE5090", Offset = "0x9DE4490", VA = "0x189DE5090", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x9DE5000", Offset = "0x9DE4400", VA = "0x189DE5000", Slot = "13")]
		public override MILFNMHALHA DGPAGPJNMNG(PJEHNIFJDKO HFJHENFIDEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x9DE5070", Offset = "0x9DE4470", VA = "0x189DE5070")]
		public MaterialExtensionsImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class GFKANJLLELA : MILFNMHALHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	internal readonly MaterialExtensionsImport FKBCJNJEHBA;

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0xA75990", Offset = "0xA74D90", VA = "0x180A75990")]
	public GFKANJLLELA(MaterialExtensionsImport LJALHBHLIOI)
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
			[Cpp2IlInjected.Address(RVA = "0x9DE5170", Offset = "0x9DE4570", VA = "0x189DE5170", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0x9DE5140", Offset = "0x9DE4540", VA = "0x189DE5140", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		public override bool PackageMissing
		{
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x9DE50F0", Offset = "0x9DE44F0", VA = "0x189DE50F0", Slot = "13")]
		public override MILFNMHALHA DGPAGPJNMNG(PJEHNIFJDKO HFJHENFIDEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x1555490", Offset = "0x1554890", VA = "0x181555490")]
		public MeshoptImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public class BLLHOFPLHAD : MILFNMHALHA
{
	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public BLLHOFPLHAD()
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
			[Cpp2IlInjected.Address(RVA = "0x9DEBEF0", Offset = "0x9DEB2F0", VA = "0x189DEBEF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0x9DEBEC0", Offset = "0x9DEB2C0", VA = "0x189DEBEC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		public override bool AlwaysEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000479")]
			[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "14")]
		public override DOPOEHGBNMC DGPAGPJNMNG(OOOLKIAIIAN HFJHENFIDEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x1555490", Offset = "0x1554890", VA = "0x181555490")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DEBF50", Offset = "0x9DEB350", VA = "0x189DEBF50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B9")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600047D")]
			[Cpp2IlInjected.Address(RVA = "0x9DEBF20", Offset = "0x9DEB320", VA = "0x189DEBF20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		public override bool AlwaysEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x600047E")]
			[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "13")]
		public override MILFNMHALHA DGPAGPJNMNG(PJEHNIFJDKO HFJHENFIDEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x1555490", Offset = "0x1554890", VA = "0x181555490")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DECEB0", Offset = "0x9DEC2B0", VA = "0x189DECEB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000482")]
			[Cpp2IlInjected.Address(RVA = "0x9DECE80", Offset = "0x9DEC280", VA = "0x189DECE80", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		public override bool AlwaysEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000483")]
			[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "14")]
		public override DOPOEHGBNMC DGPAGPJNMNG(OOOLKIAIIAN HFJHENFIDEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x1555490", Offset = "0x1554890", VA = "0x181555490")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DECF10", Offset = "0x9DEC310", VA = "0x189DECF10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000487")]
			[Cpp2IlInjected.Address(RVA = "0x9DECEE0", Offset = "0x9DEC2E0", VA = "0x189DECEE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		public override bool AlwaysEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "13")]
		public override MILFNMHALHA DGPAGPJNMNG(PJEHNIFJDKO HFJHENFIDEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x1555490", Offset = "0x1554890", VA = "0x181555490")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DECF70", Offset = "0x9DEC370", VA = "0x189DECF70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C2")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600048C")]
			[Cpp2IlInjected.Address(RVA = "0x9DECF40", Offset = "0x9DEC340", VA = "0x189DECF40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C3")]
		public override bool AlwaysEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "14")]
		public override DOPOEHGBNMC DGPAGPJNMNG(OOOLKIAIIAN HFJHENFIDEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x1555490", Offset = "0x1554890", VA = "0x181555490")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DECFD0", Offset = "0x9DEC3D0", VA = "0x189DECFD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000492")]
			[Cpp2IlInjected.Address(RVA = "0x9DECFA0", Offset = "0x9DEC3A0", VA = "0x189DECFA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		public override bool AlwaysEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000493")]
			[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "13")]
		public override MILFNMHALHA DGPAGPJNMNG(PJEHNIFJDKO HFJHENFIDEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x1555490", Offset = "0x1554890", VA = "0x181555490")]
		public VisibilityImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public class PFKCLHJHOJF
{
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	internal class FCECEAJOHNP : MemoryStream
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public readonly string DBCPLEFAEON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public readonly string MKEFFMHOPAC;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public interface BNEFKNFOHNL
{
	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<Stream> BKBLPBADONL(string CBCFDBGODOC);
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public interface EHIIFFFDMGN : BNEFKNFOHNL
{
	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Stream NNMPCHNLCGG(string CBCFDBGODOC);
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[Obsolete("Please switch to IDataLoader.  This interface is deprecated and will be removed in a future release.")]
public interface JLMHGLECAKJ
{
	[Cpp2IlInjected.Token(Token = "0x170001C8")]
	Stream CGBFODEGMDM
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	bool CKGIGKNCGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NNMPCHNLCGG(string CBCFDBGODOC);

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IJEJHEEMLJN(string IODIJBEMNOL);
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public static class OCOAJNNMJMB
{
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	private class CJHKIIPBNHF : BNEFKNFOHNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		protected readonly JLMHGLECAKJ DGODHOBOAJF;

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0xA75990", Offset = "0xA74D90", VA = "0x180A75990")]
		public CJHKIIPBNHF(JLMHGLECAKJ LEIDIHBIANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x9DDCD00", Offset = "0x9DDC100", VA = "0x189DDCD00", Slot = "4")]
		public Task<Stream> BKBLPBADONL(string CBCFDBGODOC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	private class IIJEOCOEPJL : CJHKIIPBNHF, EHIIFFFDMGN, BNEFKNFOHNL
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0xA75990", Offset = "0xA74D90", VA = "0x180A75990")]
		public IIJEOCOEPJL(JLMHGLECAKJ LEIDIHBIANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x9DDFB70", Offset = "0x9DDEF70", VA = "0x189DDFB70", Slot = "5")]
		public Stream NNMPCHNLCGG(string CBCFDBGODOC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x9DEAC80", Offset = "0x9DEA080", VA = "0x189DEAC80")]
	public static BNEFKNFOHNL IBDACBBJJDC(JLMHGLECAKJ LEIDIHBIANH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public class MCMPDNEHECO : BNEFKNFOHNL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private struct JMIJJFJFAHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public AsyncTaskMethodBuilder<Stream> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public MCMPDNEHECO <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x9DE0420", Offset = "0x9DDF820", VA = "0x189DE0420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x9DE0B50", Offset = "0x9DDFF50", VA = "0x189DE0B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	private string MDDFLLOOHHF;

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0xA75990", Offset = "0xA74D90", VA = "0x180A75990")]
	public MCMPDNEHECO(string MDDFLLOOHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x9DE4DE0", Offset = "0x9DE41E0", VA = "0x189DE4DE0", Slot = "4")]
	[AsyncStateMachine(typeof(JMIJJFJFAHN))]
	public Task<Stream> BKBLPBADONL(string CBCFDBGODOC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public class AHGCJGEADIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	private readonly List<OEKPDKIONJM> ILMOELKFEKN;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	private static readonly ProfilerMarker OIBCKCILLPP;

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x9DDC550", Offset = "0x9DDB950", VA = "0x189DDC550")]
	public void KOBMLIBBKBO(OEKPDKIONJM CDDFMFMJKNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x9DDB9C0", Offset = "0x9DDADC0", VA = "0x189DDB9C0")]
	public void BPJJLBDHEMO(CENIKCKFPGL HAIJNNMMFMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x9DDC660", Offset = "0x9DDBA60", VA = "0x189DDC660")]
	public AHGCJGEADIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public interface DINENABICMC
{
	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HBEJMNCGPBP(object NJJNDJLGDNH, string GADMOJMIIGI);
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public struct KKNDFIICGMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public BBDNLDIFIMC NBPMMMBKFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public BBDNLDIFIMC IBKFJPMLPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public KDFMGFHMONH OFIEJHDFGMG;
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public class OBNMBGHFPLJ
{
	[Cpp2IlInjected.Token(Token = "0x170001CA")]
	public AnimationClip KONHMOHLDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CB")]
	public KKNDFIICGMK[] EAFLDPNIBMP
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x9DEAC20", Offset = "0x9DEA020", VA = "0x189DEAC20")]
	public OBNMBGHFPLJ(int OGBKMOOAKHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public class DJFECOOGHEF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001CC")]
	public Stream[] KDOIKCBCIOH
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CD")]
	public Texture2D[] JNHIJMPECGG
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CE")]
	public Texture2D[] EHBIMHAPAPL
	{
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CF")]
	public CMNOCIIEMDP[] PEBJOIFLIDL
	{
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D0")]
	public HNNPCIAIMAF[] JKCNDLKAEEA
	{
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D1")]
	public ICJGPNOLOIL[] BMLKOHIKLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0xA702C0", Offset = "0xA6F6C0", VA = "0x180A702C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D2")]
	public KLFBFCLJFKM[] BOPJOAMGKOP
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0xA70180", Offset = "0xA6F580", VA = "0x180A70180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D3")]
	public NIHNMIIKCPE[] IIIEKGAJPFG
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0xA70420", Offset = "0xA6F820", VA = "0x180A70420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0xA70430", Offset = "0xA6F830", VA = "0x180A70430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D4")]
	public OBNMBGHFPLJ[] NMBIOODEGIP
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0xA70280", Offset = "0xA6F680", VA = "0x180A70280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0xA70270", Offset = "0xA6F670", VA = "0x180A70270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D5")]
	public GameObject[] NBKBBGBAEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0xA703D0", Offset = "0xA6F7D0", VA = "0x180A703D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0xA70390", Offset = "0xA6F790", VA = "0x180A70390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x9DDCFC0", Offset = "0x9DDC3C0", VA = "0x189DDCFC0")]
	public DJFECOOGHEF(PMNJJNLALOI LDEPDDDHLLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x9DDCEB0", Offset = "0x9DDC2B0", VA = "0x189DDCEB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public class ICJGPNOLOIL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001D6")]
	public uint PAACCIIAHBC
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D7")]
	public Stream NNBALDJOGHG
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D8")]
	public NativeArray<byte> OKENHOMINHP
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0xE6C740", Offset = "0xE6BB40", VA = "0x180E6C740")]
		[CompilerGenerated]
		get
		{
			return default(NativeArray<byte>);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0xF57B20", Offset = "0xF56F20", VA = "0x180F57B20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x7149040", Offset = "0x7148440", VA = "0x187149040", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public ICJGPNOLOIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
internal static class NFABMEFJMBC
{
	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0xF28990", Offset = "0xF27D90", VA = "0x180F28990")]
	public static bool JJELLOAIAEP(UnityEngine.Object OBIOPHMKHBM, string DEMHLMIPBKA, [Out] byte[] FGHKEPJEKFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
	public static void LPEDOLAPHGB(UnityEngine.Object OBIOPHMKHBM, string DEMHLMIPBKA, byte[] FGHKEPJEKFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public class HNNPCIAIMAF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001D9")]
	public Material BPNPHOHFKEA
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DA")]
	public Material DAOENDKJFPL
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DB")]
	public INLMCJFCOPF KKJHHIGKLPK
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x9DDFA70", Offset = "0x9DDEE70", VA = "0x189DDFA70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public HNNPCIAIMAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public class KLFBFCLJFKM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public class BGCPBBEAPIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public bool JAOJMMJIHOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public Dictionary<string, BBDNLDIFIMC> PJIALKBJDAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public List<Dictionary<string, BBDNLDIFIMC>> JDEDIKIMPGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public Dictionary<string, (BBDNLDIFIMC sparseIndices, BBDNLDIFIMC sparseValues)> EKLLGBFBIHI;

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x9DDC990", Offset = "0x9DDBD90", VA = "0x189DDC990")]
		public BGCPBBEAPIO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public List<BGCPBBEAPIO> ODNCABGPHBH;

	[Cpp2IlInjected.Token(Token = "0x170001DC")]
	public Mesh KGDPEBMMCIF
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x9DE0BC0", Offset = "0x9DDFFC0", VA = "0x189DE0BC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x9DE0C60", Offset = "0x9DE0060", VA = "0x189DE0C60")]
	public KLFBFCLJFKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public class IPFICMCCFIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000427")]
	private bool DNODMDGCLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000428")]
	private int LDHPGBDABNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000429")]
	private readonly object PJKPJIMDECO;

	[Cpp2IlInjected.Token(Token = "0x170001DD")]
	public KLFBFCLJFKM[] BOPJOAMGKOP
	{
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DE")]
	public UnityEngine.Object[] ECALJGIOHGM
	{
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DF")]
	public HNNPCIAIMAF[] JKCNDLKAEEA
	{
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E0")]
	public CMNOCIIEMDP[] PEBJOIFLIDL
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0xA702C0", Offset = "0xA6F6C0", VA = "0x180A702C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E1")]
	public OBNMBGHFPLJ[] NMBIOODEGIP
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0xA70180", Offset = "0xA6F580", VA = "0x180A70180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E2")]
	public Texture2D[] JNHIJMPECGG
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0xA70420", Offset = "0xA6F820", VA = "0x180A70420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0xA70430", Offset = "0xA6F830", VA = "0x180A70430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x9DE0290", Offset = "0x9DDF690", VA = "0x189DE0290")]
	public IPFICMCCFIJ(HNNPCIAIMAF[] NEPGKMGGJOJ, KLFBFCLJFKM[] KNKAHDBLMFI, CMNOCIIEMDP[] ODCOLIPIMIO, Texture2D[] EKFNJEFAGOG, OBNMBGHFPLJ[] ANBELOJMLLH, UnityEngine.Object[] PFIOIHFOCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x9DE01A0", Offset = "0x9DDF5A0", VA = "0x189DE01A0")]
	public void KLMBCKBKFOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x9DDFC50", Offset = "0x9DDF050", VA = "0x189DDFC50")]
	public void BEPGKBMEAHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x9DDFDB0", Offset = "0x9DDF1B0", VA = "0x189DDFDB0")]
	private void HBKKDKPMIIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public class CMNOCIIEMDP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public KGHMDFPAGCC CHEBIDBOKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public Texture2D HGHKHPLOOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public bool LAGCDNJFGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public bool EOABDAEBFMC;

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x9DDCE10", Offset = "0x9DDC210", VA = "0x189DDCE10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public CMNOCIIEMDP()
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
