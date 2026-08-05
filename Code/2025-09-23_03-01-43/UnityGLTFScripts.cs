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
		private struct LOKCBHCGOMJ : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0xA02A2D0", Offset = "0xA0288D0", VA = "0x18A02A2D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA02A4C0", Offset = "0xA028AC0", VA = "0x18A02A4C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class OCNANKEPECB : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
			[DebuggerHidden]
			public OCNANKEPECB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA02B3F0", Offset = "0xA0299F0", VA = "0x18A02B3F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA02B470", Offset = "0xA029A70", VA = "0x18A02B470", Slot = "8")]
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
		private WaitForEndOfFrame DKJEPGKPEIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private float OOGCNFPAIIK;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA018760", Offset = "0xA016D60", VA = "0x18A018760")]
		[AsyncStateMachine(typeof(LOKCBHCGOMJ))]
		public Task YieldOnTimeout()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA0186D0", Offset = "0xA016CD0", VA = "0x18A0186D0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA018650", Offset = "0xA016C50", VA = "0x18A018650")]
		[IteratorStateMachine(typeof(OCNANKEPECB))]
		private IEnumerator GBMIIMIGHOO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA018830", Offset = "0xA016E30", VA = "0x18A018830")]
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
		private struct PAMIEAJADBO : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0xA02C220", Offset = "0xA02A820", VA = "0x18A02C220", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xB035A0", Offset = "0xB01BA0", VA = "0x180B035A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private struct OKFLNCIDHLG : IAsyncStateMachine
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
			private IKIADIKLFCH <importOptions>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private COOKOPJMGEL <sceneImporter>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xA02B4C0", Offset = "0xA029AC0", VA = "0x18A02B4C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xA02C1C0", Offset = "0xA02A7C0", VA = "0x18A02C1C0", Slot = "5")]
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
		private int KDJMPGDLBBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int MaximumLod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int Timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public COOKOPJMGEL.MJKJLONOBJM Collider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private Shader shaderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[Header("Import Settings")]
		public BLEMBIKKIAM TextureCompression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public GPELHADHKPH ImportNormals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public GPELHADHKPH ImportTangents;

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
		public IEnumerable<Animation> LCGJDLDBNJB
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xAA54B0", Offset = "0xAA3AB0", VA = "0x180AA54B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xAA56F0", Offset = "0xAA3CF0", VA = "0x180AA56F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public GameObject LIFHDDDGPOE
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAAAEC0", Offset = "0xAA94C0", VA = "0x180AAAEC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAAAED0", Offset = "0xAA94D0", VA = "0x180AAAED0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Shader DAOOBGONGLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xAA5600", Offset = "0xAA3C00", VA = "0x180AA5600")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xA028820", Offset = "0xA026E20", VA = "0x18A028820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA028700", Offset = "0xA026D00", VA = "0x18A028700")]
		[AsyncStateMachine(typeof(PAMIEAJADBO))]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA028630", Offset = "0xA026C30", VA = "0x18A028630")]
		[AsyncStateMachine(typeof(OKFLNCIDHLG))]
		public Task Load()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA028540", Offset = "0xA026B40", VA = "0x18A028540")]
		public void ApplyOverrideShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x10B3500", Offset = "0x10B1B00", VA = "0x1810B3500")]
		private void BNJHKLENMJG(GameObject MPIDDJPOOMJ, ExceptionDispatchInfo LPNNFDLADED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA0287B0", Offset = "0xA026DB0", VA = "0x18A0287B0")]
		public GLTFComponent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class GLTFRecorderComponent : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class KEGKAGIMIGP : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
			[DebuggerHidden]
			public KEGKAGIMIGP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xA029FF0", Offset = "0xA0285F0", VA = "0x18A029FF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xA02A0C0", Offset = "0xA0286C0", VA = "0x18A02A0C0", Slot = "8")]
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
		protected MMLCKMOOMCB EMCCOBPOANN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public UnityEvent recordingStarted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public UnityEvent<string> recordingEnded;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool MEEFOJEDNLM
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xA029070", Offset = "0xA027670", VA = "0x18A029070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private double DOFEDGNHLCN
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xA0289B0", Offset = "0xA026FB0", VA = "0x18A0289B0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA028B00", Offset = "0xA027100", VA = "0x18A028B00", Slot = "4")]
		[ContextMenu("Start Recording")]
		public virtual void StartRecording()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA028EA0", Offset = "0xA0274A0", VA = "0x18A028EA0", Slot = "5")]
		[ContextMenu("Stop Recording")]
		public virtual void StopRecording()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA028850", Offset = "0xA026E50", VA = "0x18A028850")]
		private void DLIIJBENAKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA028E10", Offset = "0xA027410", VA = "0x18A028E10")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA028AE0", Offset = "0xA0270E0", VA = "0x18A028AE0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA028A90", Offset = "0xA027090", VA = "0x18A028A90", Slot = "6")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA028A40", Offset = "0xA027040", VA = "0x18A028A40", Slot = "7")]
		protected virtual void NEBGLELDBDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA0289C0", Offset = "0xA026FC0", VA = "0x18A0289C0")]
		[IteratorStateMachine(typeof(KEGKAGIMIGP))]
		private IEnumerator LAMEOBJBFKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA028FA0", Offset = "0xA0275A0", VA = "0x18A028FA0")]
		public GLTFRecorderComponent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA028850", Offset = "0xA026E50", VA = "0x18A028850")]
		[CompilerGenerated]
		private void AKHKOHBKLEA(InputAction.CallbackContext APAPCLFINDP)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class CCLFPBBKELG
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal class DMBBKAFIFJM : LEPJFGIFCMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly CCLFPBBKELG NILANFBLCLD;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xAD1900", Offset = "0xACFF00", VA = "0x180AD1900")]
		internal DMBBKAFIFJM(CCLFPBBKELG JIFPJFGEAIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA028390", Offset = "0xA026990", VA = "0x18A028390", Slot = "4")]
		public override void JHALPCHCADC(ILJINGLACKB NPLAFPNKHGN, HHLPFANFNFB HMJMPFHGNOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA0282D0", Offset = "0xA0268D0", VA = "0x18A0282D0", Slot = "5")]
		public override void BKPGHCMBJOK(ILJINGLACKB NPLAFPNKHGN, HHLPFANFNFB HMJMPFHGNOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA028180", Offset = "0xA026780", VA = "0x18A028180", Slot = "8")]
		public override void ALPMPEPJCPP(ILJINGLACKB NPLAFPNKHGN, HHLPFANFNFB HMJMPFHGNOJ, Transform CCHLCEHOKAD, EPNFLCKAFCM EMOGDLPNEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA0281C0", Offset = "0xA0267C0", VA = "0x18A0281C0", Slot = "9")]
		public override bool AMGHOCJJIEC(ILJINGLACKB NPLAFPNKHGN, HHLPFANFNFB HMJMPFHGNOJ, Material PFHPGDKJCCC, LPKIABJLDGD CCPAGGJAIBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA028310", Offset = "0xA026910", VA = "0x18A028310", Slot = "10")]
		public override void EHIGLHLIDEP(ILJINGLACKB NPLAFPNKHGN, HHLPFANFNFB HMJMPFHGNOJ, Material PFHPGDKJCCC, LPKIABJLDGD CCPAGGJAIBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA0283D0", Offset = "0xA0269D0", VA = "0x18A0283D0", Slot = "11")]
		public override void LDALDFPDJJJ(ILJINGLACKB NPLAFPNKHGN, ILJINGLACKB.NCHFDCDPKHB BDFJHOHMCFM, string EBECMHBHDHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA028450", Offset = "0xA026A50", VA = "0x18A028450", Slot = "12")]
		public override void PLBLHFLCODF(ILJINGLACKB NPLAFPNKHGN, ILJINGLACKB.NCHFDCDPKHB BDFJHOHMCFM, int PMIGBJGNLLP, BOOEFBPDPHN OJHEPEGBMBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA028350", Offset = "0xA026950", VA = "0x18A028350", Slot = "13")]
		public override void IKELJLDKCIJ(ILJINGLACKB NPLAFPNKHGN, Mesh KNHPHEPPGOL, PLLBMPLNJGP EBFGEDGGNBO, int PMIGBJGNLLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA028410", Offset = "0xA026A10", VA = "0x18A028410", Slot = "14")]
		public override void OEBKIFODIDL(ILJINGLACKB NPLAFPNKHGN, Mesh KNHPHEPPGOL, HBAJBPALING JJHNBBAHFKM, int PMIGBJGNLLP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public bool CJKKPHEDEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public LayerMask CAAJEJFDAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public ILogger ILOAKPGEOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal readonly GLTFSettings CJEINKGIPEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public ILJINGLACKB.BCFOMHLKGJL LFKIGDCNNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public ILJINGLACKB.MBMJJHPEJME BKPGHCMBJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public ILJINGLACKB.NGNADILGHMA JHALPCHCADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public ILJINGLACKB.JEKIPMGKAMM ALPMPEPJCPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public ILJINGLACKB.HMCLCCABJMH AMGHOCJJIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public ILJINGLACKB.EGFCECNIDPA EHIGLHLIDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public ILJINGLACKB.JHJEEJJJALK LDALDFPDJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public ILJINGLACKB.PMFDBFECHFD PLBLHFLCODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public ILJINGLACKB.GGKPFBJFCGJ IKELJLDKCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public ILJINGLACKB.JOGDNEIPOJJ OEBKIFODIDL;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xA018DD0", Offset = "0xA0173D0", VA = "0x18A018DD0")]
	public CCLFPBBKELG(GLTFSettings CJEINKGIPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xA018D60", Offset = "0xA017360", VA = "0x18A018D60")]
	internal LEPJFGIFCMO ONOLODKPBHE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class ILJINGLACKB
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate string BCFOMHLKGJL(Texture BDFJHOHMCFM);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public delegate void NGNADILGHMA(ILJINGLACKB NPLAFPNKHGN, HHLPFANFNFB HMJMPFHGNOJ);

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate void MBMJJHPEJME(ILJINGLACKB NPLAFPNKHGN, HHLPFANFNFB HMJMPFHGNOJ);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate void JEKIPMGKAMM(ILJINGLACKB NPLAFPNKHGN, HHLPFANFNFB HMJMPFHGNOJ, Transform CCHLCEHOKAD, EPNFLCKAFCM EMOGDLPNEGA);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate bool HMCLCCABJMH(ILJINGLACKB NPLAFPNKHGN, HHLPFANFNFB HMJMPFHGNOJ, Material PFHPGDKJCCC, LPKIABJLDGD CCPAGGJAIBC);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void EGFCECNIDPA(ILJINGLACKB NPLAFPNKHGN, HHLPFANFNFB HMJMPFHGNOJ, Material PFHPGDKJCCC, LPKIABJLDGD CCPAGGJAIBC);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void JHJEEJJJALK(ILJINGLACKB NPLAFPNKHGN, NCHFDCDPKHB BDFJHOHMCFM, string EBECMHBHDHH);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public delegate void PMFDBFECHFD(ILJINGLACKB NPLAFPNKHGN, NCHFDCDPKHB BDFJHOHMCFM, int PMIGBJGNLLP, BOOEFBPDPHN OJHEPEGBMBH);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public delegate void GGKPFBJFCGJ(ILJINGLACKB NPLAFPNKHGN, Mesh KNHPHEPPGOL, PLLBMPLNJGP EBFGEDGGNBO, int PMIGBJGNLLP);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate void JOGDNEIPOJJ(ILJINGLACKB NPLAFPNKHGN, Mesh KNHPHEPPGOL, HBAJBPALING JJHNBBAHFKM, int PMIGBJGNLLP);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class IGADPHBNMAE : LEPJFGIFCMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xA0293D0", Offset = "0xA0279D0", VA = "0x18A0293D0", Slot = "5")]
		public override void BKPGHCMBJOK(ILJINGLACKB NPLAFPNKHGN, HHLPFANFNFB HMJMPFHGNOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA0294F0", Offset = "0xA027AF0", VA = "0x18A0294F0", Slot = "4")]
		public override void JHALPCHCADC(ILJINGLACKB NPLAFPNKHGN, HHLPFANFNFB HMJMPFHGNOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA0291D0", Offset = "0xA0277D0", VA = "0x18A0291D0", Slot = "8")]
		public override void ALPMPEPJCPP(ILJINGLACKB NPLAFPNKHGN, HHLPFANFNFB HMJMPFHGNOJ, Transform CCHLCEHOKAD, EPNFLCKAFCM EMOGDLPNEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA029270", Offset = "0xA027870", VA = "0x18A029270", Slot = "9")]
		public override bool AMGHOCJJIEC(ILJINGLACKB NPLAFPNKHGN, HHLPFANFNFB HMJMPFHGNOJ, Material PFHPGDKJCCC, LPKIABJLDGD CCPAGGJAIBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA029450", Offset = "0xA027A50", VA = "0x18A029450", Slot = "10")]
		public override void EHIGLHLIDEP(ILJINGLACKB NPLAFPNKHGN, HHLPFANFNFB HMJMPFHGNOJ, Material PFHPGDKJCCC, LPKIABJLDGD CCPAGGJAIBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
		public IGADPHBNMAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct MHEKPBGMBIM
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public enum PDBMAPGNAIF
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
		public enum AKCJHOIGFNB
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
		public bool OCIBJICFJEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public PDBMAPGNAIF NHCKLJIBADD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AKCJHOIGFNB JIGGEGMHMCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool HBOKHNGHIOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public float FOFPMMAGPCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public float BKCOOKHIMNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public float LDPDEKLECEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public float BCHGCBHHINP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public float IAJGEHEOJNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public float AIPKEPMGIGN;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA02A900", Offset = "0xA028F00", VA = "0x18A02A900")]
		public MHEKPBGMBIM(MHEKPBGMBIM NGOJMGCIOHB)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xA02A8C0", Offset = "0xA028EC0", VA = "0x18A02A8C0")]
		public static bool MGLHCKHANFO(MHEKPBGMBIM BNPLNGPMIIG, MHEKPBGMBIM DIIGMDFDOAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA02A6C0", Offset = "0xA028CC0", VA = "0x18A02A6C0")]
		public bool GIDJLDBOFOE(MHEKPBGMBIM AAGCKLPFJME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA02A610", Offset = "0xA028C10", VA = "0x18A02A610", Slot = "0")]
		public override bool Equals(object MPIDDJPOOMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA02A7A0", Offset = "0xA028DA0", VA = "0x18A02A7A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private struct KBDCPIMGFPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Texture2D BDFJHOHMCFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public MHEKPBGMBIM CIMJKDDLGOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public string KBPCIDHIDAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public bool AMLNHFGDBPC;
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private struct IBMDBDKCIFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Stream ICLFABGEPJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public string BCEHFAJJCGI;
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct NCHFDCDPKHB : IEquatable<NCHFDCDPKHB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Texture JAKHKFPCPLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public int HJCPDDEBJPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public MHEKPBGMBIM GHDKKHPDGJF;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA02AE20", Offset = "0xA029420", VA = "0x18A02AE20")]
		public int FGFHGPBIFCJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA02AB70", Offset = "0xA029170", VA = "0x18A02AB70")]
		public int APOACEGGBOB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xA02AF90", Offset = "0xA029590", VA = "0x18A02AF90")]
		public NCHFDCDPKHB(Texture OJHEPEGBMBH, string EBECMHBHDHH, ILJINGLACKB NPLAFPNKHGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA02AF00", Offset = "0xA029500", VA = "0x18A02AF00")]
		public NCHFDCDPKHB(Texture OJHEPEGBMBH, MHEKPBGMBIM GGJCDJECFJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA02ABB0", Offset = "0xA0291B0", VA = "0x18A02ABB0", Slot = "4")]
		public bool Equals(NCHFDCDPKHB AAGCKLPFJME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA02AD70", Offset = "0xA029370", VA = "0x18A02AD70", Slot = "0")]
		public override bool Equals(object MPIDDJPOOMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA02AE60", Offset = "0xA029460", VA = "0x18A02AE60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct PFBGJEGCFJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Mesh PHFGECIDFPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Material[] EFHBFNGFKDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public SkinnedMeshRenderer GHOLNJMGGOK;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xA02D610", Offset = "0xA02BC10", VA = "0x18A02D610")]
		public bool GIDJLDBOFOE(PFBGJEGCFJB AAGCKLPFJME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA02D570", Offset = "0xA02BB70", VA = "0x18A02D570", Slot = "0")]
		public override bool Equals(object MPIDDJPOOMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xA02D780", Offset = "0xA02BD80", VA = "0x18A02D780", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private struct MGNMJMHACKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public POAPBJAHENH IHPLCFBOIJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public POAPBJAHENH KLOFIBPNJOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public POAPBJAHENH ONJDKGCHHPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public POAPBJAHENH DBKODGGLHBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public POAPBJAHENH JBCKEEOPCON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public POAPBJAHENH LHKFLDOGHHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public POAPBJAHENH MBCKGDCBJFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public POAPBJAHENH BBCANNGKKEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public POAPBJAHENH NCKJLFICCCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public Dictionary<int, PLLBMPLNJGP> HAPKMLJKAMD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct PHJAFLGGCOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public List<Dictionary<string, POAPBJAHENH>> OAOCMEKPNDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public List<double> CFJKLHHEILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public List<string> JPPCLDPHEDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		internal SkinnedMeshRenderer IFBJIMDHFDO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct MMDLGHBOGDN : IEquatable<MMDLGHBOGDN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly TextureWrapMode FELMOEEJFFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly FilterMode EKACEANNGBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly bool ILFNKEEDFEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly bool CKPJCOGFICE;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool AKNLDNFGCDP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xECF560", Offset = "0xECDB60", VA = "0x180ECF560")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool JALEOICGKCA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x74F7170", Offset = "0x74F5770", VA = "0x1874F7170")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA02AAE0", Offset = "0xA0290E0", VA = "0x18A02AAE0")]
		public MMDLGHBOGDN(Texture BDFJHOHMCFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xA02A940", Offset = "0xA028F40", VA = "0x18A02A940", Slot = "4")]
		public bool Equals(MMDLGHBOGDN AAGCKLPFJME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xA02A970", Offset = "0xA028F70", VA = "0x18A02A970", Slot = "0")]
		public override bool Equals(object MPIDDJPOOMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xA02AA30", Offset = "0xA029030", VA = "0x18A02AA30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class JONPKGEIGMI : IEnumerable<(int, PLLBMPLNJGP)>, IEnumerable, IEnumerator<(int, PLLBMPLNJGP)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private (int subMeshIndex, PLLBMPLNJGP prim) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public ILJINGLACKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private Mesh mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Mesh <>3__mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private Dictionary<int, PLLBMPLNJGP>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private (int, PLLBMPLNJGP) System.Collections.Generic.IEnumerator<(System.Int32subMeshIndex,GLTF.Schema.MeshPrimitiveprim)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xBF19C0", Offset = "0xBEFFC0", VA = "0x180BF19C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((int, PLLBMPLNJGP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xA029B60", Offset = "0xA028160", VA = "0x18A029B60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xBF1B00", Offset = "0xBF0100", VA = "0x180BF1B00")]
		[DebuggerHidden]
		public JONPKGEIGMI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA029BB0", Offset = "0xA0281B0", VA = "0x18A029BB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA029780", Offset = "0xA027D80", VA = "0x18A029780", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xA029730", Offset = "0xA027D30", VA = "0x18A029730")]
		private void MPMIGDGBFBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA029B10", Offset = "0xA028110", VA = "0x18A029B10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA029A50", Offset = "0xA028050", VA = "0x18A029A50", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(int, PLLBMPLNJGP)> System.Collections.Generic.IEnumerable<(System.Int32subMeshIndex,GLTF.Schema.MeshPrimitiveprim)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA029A50", Offset = "0xA028050", VA = "0x18A029A50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class MGIFHHAMEJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public bool convertToLinearColor;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public MGIFHHAMEJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA02A520", Offset = "0xA028B20", VA = "0x18A02A520")]
		internal Color OFKNHPDCLFO(object e)
		{
			return default(Color);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class EPCPLGEPEKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public float multiplier;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public EPCPLGEPEKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA0284C0", Offset = "0xA026AC0", VA = "0x18A0284C0")]
		internal float LPLAEEDDKPK(object e)
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static ILogger FJPEHIICMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private List<LEPJFGIFCMO> DCJOJJMALEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private Transform[] DJAKCDBGEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private HHLPFANFNFB LHEJAKHAEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private NIFLFOIDJEE NNONHMDCGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private FCKJNBPIEKG KKMIHIHHCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private List<KBDCPIMGFPF> FCNILKNCGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private HashSet<string> ABHFHBJGKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private List<IBMDBDKCIFO> HLHAGFCPPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private HashSet<string> OMJHGKOEIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<NCHFDCDPKHB> FGONAKEILJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private Dictionary<int, int> HAFIBLEJMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private bool EHJOMECBJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private Dictionary<int, int> OABPBDGGNOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private List<Transform> KIMJJGDOPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private int MOEFPIKDLBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private CCLFPBBKELG NILANFBLCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private Material CEBOJOLCBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private Material OEJIPIGPJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private Material HEBHIEMKBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private bool NJOIBIEBGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<PFBGJEGCFJB, DGFCBHHHIFG> APNGDPKAOMC;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static ProfilerMarker NJLKABJMELA;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static ProfilerMarker AGAALNHHMDP;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static ProfilerMarker OAPHFHDKKKG;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static ProfilerMarker OJKDJEBKHFA;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static ProfilerMarker HAHJLPNODNP;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static ProfilerMarker BKPGCJEHOCP;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static ProfilerMarker BBPIKJDFLDI;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static ProfilerMarker AOMOKCKFJKG;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static ProfilerMarker AGHLHLFCJAG;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static ProfilerMarker PLCMODPIMOL;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static ProfilerMarker KGFPABEIDBA;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static ProfilerMarker JMEAPDGCMJJ;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static ProfilerMarker DDPBHPHOLAK;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static ProfilerMarker KDIECFAKFGE;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static ProfilerMarker KBCPKFEHILN;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static ProfilerMarker MJLBPHJNFDC;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static ProfilerMarker EPJLMIFBBME;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static ProfilerMarker NGICAAJAKLI;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static ProfilerMarker MPNGDOENGNF;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static ProfilerMarker LBEDMINNFNJ;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static ProfilerMarker CJBKHLPAKFO;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static ProfilerMarker GPKGCKMOHOA;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static ProfilerMarker MPPOGDCLMAK;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static ProfilerMarker FOBKMLIKIFK;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static ProfilerMarker KKFHMNABIIF;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static ProfilerMarker DPFGCCCBNPI;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static ProfilerMarker BMJBNIMPCDJ;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static ProfilerMarker BJJFNNGPAFL;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private static ProfilerMarker IGFPJMJCKCJ;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static ProfilerMarker FJKIIHMEIJO;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static ProfilerMarker COMPOHDFDFE;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static ProfilerMarker KCLHFMAPBBE;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static ProfilerMarker MGAKGBMCLGM;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static ProfilerMarker GINEPDCNNHB;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private static ProfilerMarker DMGHPFBHKHJ;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static ProfilerMarker DHCNKONDBEH;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static ProfilerMarker AMLBCNBGHAC;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static ProfilerMarker MKHEPEHHMJN;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static ProfilerMarker CAPGJIABNMG;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private static ProfilerMarker KLLNKICAGLJ;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static ProfilerMarker FDNIMACKJFC;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static ProfilerMarker DHDNKKABBMA;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static ProfilerMarker BOLHOLODMID;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static ProfilerMarker KJBHCMGBGPG;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private static ProfilerMarker IAPOFECJPEM;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static ProfilerMarker NGCGFIPKEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private global::FOEPIAPEAMN MCPFNGONLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool? DKEPNLEFBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	internal readonly List<OMGLNHKMEEK> DLOPICCICNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly LEILFJOCFOG HOMPCJJIOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Dictionary<int, int> HEKKIDNDLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Dictionary<int, int> EMDHPNFCMDE;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	[CompilerGenerated]
	private static NGNADILGHMA JHALPCHCADC;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[CompilerGenerated]
	private static MBMJJHPEJME BKPGHCMBJOK;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	[CompilerGenerated]
	private static JEKIPMGKAMM ALPMPEPJCPP;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[CompilerGenerated]
	private static HMCLCCABJMH AMGHOCJJIEC;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[CompilerGenerated]
	private static EGFCECNIDPA EHIGLHLIDEP;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static Material KCFMGCDIBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private HashSet<Material> JFMIKDHMGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly Dictionary<Mesh, MGNMJMHACKI> AOJLOGIKEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly Dictionary<Mesh, PHJAFLGGCOG> EPNOINOOPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly Dictionary<SkinnedMeshRenderer, List<double>> NBCMKIDDDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private List<Transform> LKHDADCDAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Dictionary<SkinnedMeshRenderer, Mesh> DMKBFBMHGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Dictionary<MMDLGHBOGDN, int> BOANOEEBCLE;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyList<Transform> BCABDLDEDPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private GLTFSettings CJEINKGIPEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA0076B0", Offset = "0xA005CB0", VA = "0x18A0076B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private bool CKKGHGHCHEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA002A00", Offset = "0xA001000", VA = "0x18A002A00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private bool NDKGKJGMMDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA007010", Offset = "0xA005610", VA = "0x18A007010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private bool CIFOEPEOJAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA003430", Offset = "0xA001A30", VA = "0x18A003430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static Material PMDJFCMBMIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA007460", Offset = "0xA005A60", VA = "0x18A007460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0xA005680", Offset = "0xA003C80", VA = "0x18A005680")]
	public MHEKPBGMBIM GJMGDKAIOIL(string EBECMHBHDHH)
	{
		return default(MHEKPBGMBIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0xA003350", Offset = "0xA001950", VA = "0x18A003350")]
	private Material EDOMECODIGL(MHEKPBGMBIM CIMJKDDLGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xA000D50", Offset = "0x9FFF350", VA = "0x18A000D50")]
	private static Material CCFFOFAFEPC(Material PFHPGDKJCCC, MHEKPBGMBIM CIMJKDDLGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0xA016C30", Offset = "0xA015230", VA = "0x18A016C30")]
	public ILJINGLACKB(Transform[] EBJBFFKCDLL, CCLFPBBKELG JIFPJFGEAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xA002A30", Offset = "0xA001030", VA = "0x18A002A30")]
	public void EDFHNGPDEFI(Stream ICLFABGEPJB, string DPEHEEBEAND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xA014410", Offset = "0xA012A10", VA = "0x18A014410")]
	public void OMBPDDBHHOO(string BEFEDMIPOOM, bool ANINNBNILMG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0xA00A350", Offset = "0xA008950", VA = "0x18A00A350")]
	private bool KDIEJLELMCO(Transform CCHLCEHOKAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0xA0059B0", Offset = "0xA003FB0", VA = "0x18A0059B0")]
	private KGCACPHOPEM GLHPAOANPPM(string NDIENANOGEK, Transform[] LBFBPGBHNEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xA0046C0", Offset = "0xA002CC0", VA = "0x18A0046C0")]
	private JFPFEKGIBOO GBOOPNIMDNI(Transform EFMKJBBEBAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0xA015340", Offset = "0xA013940", VA = "0x18A015340")]
	private static bool PEGLLBBGFCN(GameObject JJEACKINPOJ, bool DLOPGGHEAHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0xA006E00", Offset = "0xA005400", VA = "0x18A006E00")]
	private void HOAGKCHBPLE(Transform CCHLCEHOKAD, [Out] GameObject[] MPMALMOAMEL, [Out] GameObject[] FKEMPDCNAAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0xA000BB0", Offset = "0x9FFF1B0", VA = "0x18A000BB0")]
	private void BHCPFFNGLOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xA00A4B0", Offset = "0xA008AB0", VA = "0x18A00A4B0")]
	public NNLNLAFBKJO KNLPDMFPHGP(HHLPFANFNFB BOCNDANOLJJ, Material IGOCIKBGCOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xA009D30", Offset = "0xA008330", VA = "0x18A009D30")]
	public DFKGBBMCCND JCHKOKLEGFE(HHLPFANFNFB BOCNDANOLJJ, NCHFDCDPKHB BFHJJNMPEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0xA005F80", Offset = "0xA004580", VA = "0x18A005F80")]
	public JPMPPPPCLEO HJCNNBKEDBK(HHLPFANFNFB BOCNDANOLJJ, Texture NNDCELBFPBG, MHEKPBGMBIM CIMJKDDLGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xA003730", Offset = "0xA001D30", VA = "0x18A003730")]
	private static void FAOCOOKGLDC(Stream ECBHOIMIBKD, BinaryWriter PCCGPNIJDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA00BDB0", Offset = "0xA00A3B0", VA = "0x18A00BDB0")]
	private static void LMCPAMGAGMN(Stream ICLFABGEPJB, byte MADOLICIACD = 32, uint CEPFCPDBEGE = 4u)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x9FFEA70", Offset = "0x9FFD070", VA = "0x189FFEA70")]
	public static uint AFDBKMNPFBC(uint AEDCHBDCKFJ, uint KKGAPPOPCFO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xA012330", Offset = "0xA010930", VA = "0x18A012330")]
	private POAPBJAHENH NOLKDDPAAPK(Vector4[] MDIMFHGEOCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0xA006350", Offset = "0xA004950", VA = "0x18A006350")]
	private POAPBJAHENH HNCINDBDKFB(Quaternion[] MDIMFHGEOCP, bool CCCHADDNOAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xA010DB0", Offset = "0xA00F3B0", VA = "0x18A010DB0")]
	private POAPBJAHENH NHLDFDGAMHD(Matrix4x4[] MDIMFHGEOCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xA00EF10", Offset = "0xA00D510", VA = "0x18A00EF10")]
	private POAPBJAHENH NHLDFDGAMHD(float[] MDIMFHGEOCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xA0106B0", Offset = "0xA00ECB0", VA = "0x18A0106B0")]
	private POAPBJAHENH NHLDFDGAMHD(int[] MDIMFHGEOCP, bool LOBGBEGIKHA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xA00DFC0", Offset = "0xA00C5C0", VA = "0x18A00DFC0")]
	private POAPBJAHENH NHLDFDGAMHD(Vector2[] MDIMFHGEOCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0xA00F400", Offset = "0xA00DA00", VA = "0x18A00F400")]
	private POAPBJAHENH NHLDFDGAMHD(Vector3[] MDIMFHGEOCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x9FFEA90", Offset = "0x9FFD090", VA = "0x189FFEA90")]
	private POAPBJAHENH AHFGEMIBDGE(POAPBJAHENH FEFGJAFADIL, Vector3[] LBPNHHDODFH, Vector3[] MDIMFHGEOCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xA00E610", Offset = "0xA00CC10", VA = "0x18A00E610")]
	private POAPBJAHENH NHLDFDGAMHD(Vector4[] MDIMFHGEOCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xA00FB10", Offset = "0xA00E110", VA = "0x18A00FB10")]
	private POAPBJAHENH NHLDFDGAMHD(Color[] MDIMFHGEOCP, bool HPHCCHKOIGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xA0076D0", Offset = "0xA005CD0", VA = "0x18A0076D0")]
	private AFEACAJDLPM IOJBBIEJCDM(uint BFIFOHHOMCO, uint KAEJALJBPKP, uint JPHLIIOINOF = 0u)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
	public void DEHMKMIBMMG(Transform CCHLCEHOKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xA015D30", Offset = "0xA014330", VA = "0x18A015D30")]
	internal int PPHEAHPKLIP(object MPIDDJPOOMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xA00BA50", Offset = "0xA00A050", VA = "0x18A00BA50")]
	public int LFICDLEDICM(Transform CCHLCEHOKAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xA00BE80", Offset = "0xA00A480", VA = "0x18A00BE80")]
	public int LMKGNIKJIFM(Material BEAKBILFDLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xA000FF0", Offset = "0x9FFF5F0", VA = "0x18A000FF0")]
	public int CPAOBJMENHP(Light IPEJDBFOFDA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xA003800", Offset = "0xA001E00", VA = "0x18A003800")]
	public int FDCCDLBFIKD(Camera ENIKBDIGLBK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0xA001A00", Offset = "0xA000000", VA = "0x18A001A00")]
	[IteratorStateMachine(typeof(JONPKGEIGMI))]
	public IEnumerable<(int, PLLBMPLNJGP)> DBFLHBHKJGF(Mesh KNHPHEPPGOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xA00DC30", Offset = "0xA00C230", VA = "0x18A00DC30")]
	private static void NAOIIPDOMKJ(Color ECBHOIMIBKD, [Out] Color PCCGPNIJDPB, [Out] float DPOHEHDFABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xA005980", Offset = "0xA003F80", VA = "0x18A005980")]
	private static void GLCJAOOOBEL(Vector4 ECBHOIMIBKD, [Out] Vector2 EAHAEIJNIMH, [Out] Vector2 PIOCNHLFCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xA009F40", Offset = "0xA008540", VA = "0x18A009F40")]
	private bool JMBNMFGKKBM(object[] GHKPAFFMJAO, int AGJDOCKMAHO, int LDANOHNMFAJ, int BIKAHEMPIPH, int DBFLGBEKFKG, int AGGKHLMPCDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xA0003C0", Offset = "0x9FFE9C0", VA = "0x18A0003C0")]
	public void BGCAJCFMAPE(float[] HKBHFFANFFG, object[] LGMBOCEBOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x9FFBC70", Offset = "0x9FFA270", VA = "0x189FFBC70")]
	public void AAGBEEIPJFB(UnityEngine.Object KCDMCCLJDPL, string JKLGGALPDGD, FHGFGFEMDFE AGCIMJNMJCM, float[] HKBHFFANFFG, object[] LGMBOCEBOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xA00D3C0", Offset = "0xA00B9C0", VA = "0x18A00D3C0")]
	private void MEIIABGANEJ(object KCDMCCLJDPL, string JKLGGALPDGD, HDEJDNOIEKA AMMKGILEHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xA00A600", Offset = "0xA008C00", VA = "0x18A00A600")]
	private OPNBKMDMJHF LAPPPBIBDAH(Camera CEHLEEMBFOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xA00D530", Offset = "0xA00BB30", VA = "0x18A00D530")]
	private INDPHAKBEMG MODAIIFOJOG(Light PJABKCEJFBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xA007800", Offset = "0xA005E00", VA = "0x18A007800")]
	public NNLNLAFBKJO IOPLGMDPEBC(Material IGOCIKBGCOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0xA007190", Offset = "0xA005790", VA = "0x18A007190")]
	private NNLNLAFBKJO IKBPLPLLMMP(Material IGOCIKBGCOL, LPKIABJLDGD PFHPGDKJCCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xA00DE00", Offset = "0xA00C400", VA = "0x18A00DE00")]
	private bool NBDGJPJNCLB(Material PFHPGDKJCCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xA0035D0", Offset = "0xA001BD0", VA = "0x18A0035D0")]
	private bool EFNOBBGGBFB(Material PFHPGDKJCCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xA011250", Offset = "0xA00F850", VA = "0x18A011250")]
	private bool NNCFMELCCPO(Material PFHPGDKJCCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xA006D60", Offset = "0xA005360", VA = "0x18A006D60")]
	private bool HNNLHBFKKFO(Material PFHPGDKJCCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xA003690", Offset = "0xA001C90", VA = "0x18A003690")]
	private static bool EOBJMJAMMIO(Shader LAGKJJFLJJJ, string NDIENANOGEK, ShaderPropertyType GPEIAHGICNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA0145E0", Offset = "0xA012BE0", VA = "0x18A0145E0")]
	private void OOHGEAGLHAA(CMFBMCFCJEH NDLIDFKNCIJ, Material BEAKBILFDLK, string MJBMEDPJHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xA006150", Offset = "0xA004750", VA = "0x18A006150")]
	public JNBAPJONGIM HJPALBNCMMB(Texture BDFJHOHMCFM, string EBECMHBHDHH, Material PFHPGDKJCCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xA0038C0", Offset = "0xA001EC0", VA = "0x18A0038C0")]
	private HMPMOGKKHCI FDPIEIIDAOE(Texture BDFJHOHMCFM, string EBECMHBHDHH, Material PFHPGDKJCCC, [Optional] DFKGBBMCCND EMFAMCLIPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA001A90", Offset = "0xA000090", VA = "0x18A001A90")]
	public ODHBOOCPHDE DEPMJNMFJMF(Material PFHPGDKJCCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA012C00", Offset = "0xA011200", VA = "0x18A012C00")]
	public void OAEKOAJOBDJ(LPKIABJLDGD NDLIDFKNCIJ, Material PFHPGDKJCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x9FFFB10", Offset = "0x9FFE110", VA = "0x189FFFB10")]
	private void BCDIJMLGEFK(LPKIABJLDGD PFHPGDKJCCC, Material IGOCIKBGCOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xA00AAA0", Offset = "0xA0090A0", VA = "0x18A00AAA0")]
	private NEFBDMNFBCI LFBMPKACPPB(Material IGOCIKBGCOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0xA004630", Offset = "0xA002C30", VA = "0x18A004630")]
	internal static void FNBFBKBAGGO(Color NDFGIOMEBJI, [Out] Color NHNBBIAGIJK, [Out] float DPOHEHDFABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xA005DF0", Offset = "0xA0043F0", VA = "0x18A005DF0")]
	public void GOAPHFMOJLB(EPNFLCKAFCM EMOGDLPNEGA, List<PFBGJEGCFJB> ELGHFEDAGMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0xA0155B0", Offset = "0xA013BB0", VA = "0x18A0155B0")]
	private static List<PFBGJEGCFJB> POOIEFOJPNJ(IEnumerable<GameObject> MPMALMOAMEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0xA005640", Offset = "0xA003C40", VA = "0x18A005640")]
	public JFPFEKGIBOO GBOOPNIMDNI(GameObject JJEACKINPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xA013B80", Offset = "0xA012180", VA = "0x18A013B80")]
	public DGFCBHHHIFG OHIKHFAAANI(string NDIENANOGEK, List<PFBGJEGCFJB> ELGHFEDAGMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xA00BF40", Offset = "0xA00A540", VA = "0x18A00BF40")]
	private PLLBMPLNJGP[] MBGBHOKAIIM(PFBGJEGCFJB NDMAHHICGHE, HBAJBPALING KNHPHEPPGOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xA00BB10", Offset = "0xA00A110", VA = "0x18A00BB10")]
	private List<double> LFMHCMPJBAD(SkinnedMeshRenderer NNCHINPECMF, Mesh MFMJGGFJNJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0xA0131B0", Offset = "0xA0117B0", VA = "0x18A0131B0")]
	private void OAJNGCJEMJN(SkinnedMeshRenderer NNCHINPECMF, Mesh MFMJGGFJNJL, int JIDCHPBODJD, PLLBMPLNJGP EBFGEDGGNBO, HBAJBPALING KNHPHEPPGOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xA00D510", Offset = "0xA00BB10", VA = "0x18A00D510")]
	private static bool MIKIKAHIIDB(PLLBMPLNJGP LONHJLCNBJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xA000C40", Offset = "0x9FFF240", VA = "0x18A000C40")]
	private static IINGIELCDJB BKBAKDOEIJI(MeshTopology PLAIKMICKLE)
	{
		return default(IINGIELCDJB);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0xA005F60", Offset = "0xA004560", VA = "0x18A005F60")]
	private static bool HJBONOIDGOC(Mesh KNHPHEPPGOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0xA0112C0", Offset = "0xA00F8C0", VA = "0x18A0112C0")]
	private void NNLEBKLGKJF(Transform CCHLCEHOKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xA015030", Offset = "0xA013630", VA = "0x18A015030")]
	private Mesh OONMIFJKCMF(GameObject JJEACKINPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xA00BCB0", Offset = "0xA00A2B0", VA = "0x18A00BCB0")]
	private Material[] LLLNEIGNJEK(GameObject JJEACKINPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xA00A1C0", Offset = "0xA0087C0", VA = "0x18A00A1C0")]
	private Vector4[] KAKLHOCOPKM(BoneWeight[] FBPMFKJOMBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0xA007040", Offset = "0xA005640", VA = "0x18A007040")]
	private Vector4[] IIKMBPBOEOA(BoneWeight[] FBPMFKJOMBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0xA0141E0", Offset = "0xA0127E0", VA = "0x18A0141E0")]
	private string OLLIDAHCIAJ(HashSet<string> EABLHCAALCL, string NDIENANOGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0xA0002B0", Offset = "0x9FFE8B0", VA = "0x18A0002B0")]
	public CMFBMCFCJEH BFDNFCENNOG(Texture BDFJHOHMCFM, string EBECMHBHDHH, [Optional] MHEKPBGMBIM GGJCDJECFJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xA00A0D0", Offset = "0xA0086D0", VA = "0x18A00A0D0")]
	public CMFBMCFCJEH JPNCPBGOLEB(Material BEAKBILFDLK, Texture BDFJHOHMCFM, string EBECMHBHDHH, [Optional] MHEKPBGMBIM GGJCDJECFJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xA003A20", Offset = "0xA002020", VA = "0x18A003A20")]
	public DFKGBBMCCND FMIAAMMAOHL(Texture BFHJJNMPEFB, string EBECMHBHDHH, [Optional] MHEKPBGMBIM GGJCDJECFJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xA004380", Offset = "0xA002980", VA = "0x18A004380")]
	private string FMNEEBKOHLK(Texture BDFJHOHMCFM, MHEKPBGMBIM CIMJKDDLGOF, string EBECMHBHDHH, [Out] bool EMKJLIBADBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA0010B0", Offset = "0x9FFF6B0", VA = "0x18A0010B0")]
	private JPMPPPPCLEO CPLILCHONPK(NCHFDCDPKHB DKEHOFLAIGB, string EBECMHBHDHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4AEE230", Offset = "0x4AEC830", VA = "0x184AEE230")]
	private bool CLAJKHIALJI(MHEKPBGMBIM CIMJKDDLGOF, Texture BDFJHOHMCFM, [Out] string BFHDBHOMJKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990")]
	private byte[] FDHGCLPFAAN(Texture BDFJHOHMCFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0xA013120", Offset = "0xA011720", VA = "0x18A013120")]
	private bool OAFFMMGGIBA(Texture CMMJPMFOJIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xA009EC0", Offset = "0xA0084C0", VA = "0x18A009EC0")]
	private bool JFDFLNGELKG(string GDCFOAHKBOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xA015270", Offset = "0xA013870", VA = "0x18A015270")]
	private bool OPNGOKMNANE(string GDCFOAHKBOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xA00AE90", Offset = "0xA009490", VA = "0x18A00AE90")]
	private JPMPPPPCLEO LFDIBJNKCEA(NCHFDCDPKHB DKEHOFLAIGB, string EBECMHBHDHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x9FFE610", Offset = "0x9FFCC10", VA = "0x189FFE610")]
	private CJOIJCKOEGE AFBIMKHPPDC(Texture BDFJHOHMCFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Flags]
public enum EFLFLLAKIPA
{
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	Meshes = 1,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	Textures = 2
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum BLEMBIKKIAM
{
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	LowQuality,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	HighQuality
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class IKIADIKLFCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public HDLBLBOMOEF OBHEOGPJIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public ELFOIBFCJID KNEKDOOKEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public AsyncCoroutineHelper KNBFCPAEMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public bool JJEMDCGBLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public ICBIGGKLCJM FOGNJBEOEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public bool MEAJECACDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public EFLFLLAKIPA BFAFHCBGAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public bool CAIFFBPIICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public GPELHADHKPH LLCJNJHDPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public GPELHADHKPH JPFPKLICACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public bool FOINJFPLACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public NNFHLGNBPEP OICKPOPLPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public BLEMBIKKIAM MCDCENHKBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public BlendShapeFrameWeightSetting IOOJCBGAMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public HOLINFLNHMO AKPMAOGDOOK;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public ILogger ILOAKPGEOPI;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0xA029570", Offset = "0xA027B70", VA = "0x18A029570")]
	public IKIADIKLFCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum NNFHLGNBPEP
{
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	ImportAndActive,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	ImportAndCameraDisabled
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public enum ICBIGGKLCJM
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
public struct NKILHPIMAEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public bool HJMHPGLJDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public int GPFEBOGMBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public int EEMFKEDHAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public int KPLFMHHDCPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public int ONIIILJOBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public int BNDHNCLHLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public int JLFKKKJOGBK;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public float ACOMHOFIOBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA02B040", Offset = "0xA029640", VA = "0x18A02B040")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0xA02B070", Offset = "0xA029670", VA = "0x18A02B070", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct APGDOOLEJPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public long DHKLCKGOHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public long NMNACDAMGPA;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public delegate float[] MCPGCIIHAMJ(ONNDPLHOGAP CDDIADBJAOB, int KACMJLICFCL);
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class COOKOPJMGEL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public enum MJKJLONOBJM
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
	protected struct PFJIDLENMNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public Stream KOAAPNPBOJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public long HHCOCMJCMMF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class KFFEEAHOIEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public Texture JAKHKFPCPLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public int MPKKDKDADGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public double MPAIBCHNGJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public Vector2 CDOMHMKBDBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public double BGKDKGECOAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public Vector2 KHGBNADOONJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public int? HDJJIONEPPO;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA02A110", Offset = "0xA028710", VA = "0x18A02A110")]
		public KFFEEAHOIEA()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct CJAEDFNMIGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public IProgress<NKILHPIMAEN> progress;

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

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xA0190F0", Offset = "0xA0176F0", VA = "0x18A0190F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA01A4B0", Offset = "0xA018AB0", VA = "0x18A01A4B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct BHEPNLIMCFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private LPKIABJLDGD <def>5__3;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA0188B0", Offset = "0xA016EB0", VA = "0x18A0188B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA018D00", Offset = "0xA017300", VA = "0x18A018D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class ILAMBPKBHAD
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
			public ILAMBPKBHAD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			private LPKIABJLDGD <def>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xA02DA80", Offset = "0xA02C080", VA = "0x18A02DA80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xA02DEB0", Offset = "0xA02C4B0", VA = "0x18A02DEB0", Slot = "5")]
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
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public ILAMBPKBHAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA029660", Offset = "0xA027C60", VA = "0x18A029660")]
		[AsyncStateMachine(typeof(<<LoadMaterialAsync>b__0>d))]
		internal Task GIHMBDNAMHK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct DIBOHEDOFNP : IAsyncStateMachine
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
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private ILAMBPKBHAD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA027E00", Offset = "0xA026400", VA = "0x18A027E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA028110", Offset = "0xA026710", VA = "0x18A028110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class LKBEJMDMBOB
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
			public LKBEJMDMBOB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			private HBAJBPALING <def>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xA02DF10", Offset = "0xA02C510", VA = "0x18A02DF10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0xA02E4D0", Offset = "0xA02CAD0", VA = "0x18A02E4D0", Slot = "5")]
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
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public LKBEJMDMBOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA02A200", Offset = "0xA028800", VA = "0x18A02A200")]
		[AsyncStateMachine(typeof(<<LoadMeshAsync>b__0>d))]
		internal Task GFBJEFCJENP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct KEELPAFMGDJ : IAsyncStateMachine
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
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private LKBEJMDMBOB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA029C40", Offset = "0xA028240", VA = "0x18A029C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA029F80", Offset = "0xA028580", VA = "0x18A029F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class AFIOPADHNDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public GEFPGBLKBPC dataLoader2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public string jsonFilePath;

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public AFIOPADHNDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA0184D0", Offset = "0xA016AD0", VA = "0x18A0184D0")]
		internal Stream HHNGCCBNLCO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA0185C0", Offset = "0xA016BC0", VA = "0x18A0185C0")]
		internal void OLIBHKAJJIC()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct DFLKGLNKAKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public string jsonFilePath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private AFIOPADHNDP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private TaskAwaiter<Stream> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA0275F0", Offset = "0xA025BF0", VA = "0x18A0275F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA027DA0", Offset = "0xA0263A0", VA = "0x18A027DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct PBMIBJBAHKC : IAsyncStateMachine
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
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public bool showSceneObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private ECGPILHJDAN <scene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA02C710", Offset = "0xA02AD10", VA = "0x18A02C710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA02D510", Offset = "0xA02BB10", VA = "0x18A02D510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct ECHJBLNJBOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public AsyncTaskMethodBuilder<JHEHCIOMFDO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public NIFLFOIDJEE bufferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA030130", Offset = "0xA02E730", VA = "0x18A030130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA0303C0", Offset = "0xA02E9C0", VA = "0x18A0303C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct OKFAEHLMOIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public int nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private EPNFLCKAFCM <node>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private FNLIJDHPCCI <lodsExtension>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA03ABA0", Offset = "0xA0391A0", VA = "0x18A03ABA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA03B7B0", Offset = "0xA039DB0", VA = "0x18A03B7B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct PPEOHHPGKDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public AsyncTaskMethodBuilder<(Vector3, Quaternion, Vector3)[]> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public EPNFLCKAFCM node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private INLJELLPHNA <positionsAttr>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private INLJELLPHNA <rotationAttr>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private INLJELLPHNA <scaleAttr>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private EXT_mesh_gpu_instancing <extMeshGPUInstancing>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private int <instancesCount>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private TaskAwaiter<INLJELLPHNA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA03CF80", Offset = "0xA03B580", VA = "0x18A03CF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA03DBD0", Offset = "0xA03C1D0", VA = "0x18A03DBD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class KPPGEOMKOCL
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
			public KPPGEOMKOCL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public bool onlyMesh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public bool ignoreMesh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			private List<JFPFEKGIBOO>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			private HBAJBPALING <mesh>5__3;

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

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xA041890", Offset = "0xA03FE90", VA = "0x18A041890", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xA043310", Offset = "0xA041910", VA = "0x18A043310", Slot = "5")]
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
		public EPNFLCKAFCM node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public int nodeIndex;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public KPPGEOMKOCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA0313A0", Offset = "0xA02F9A0", VA = "0x18A0313A0")]
		[AsyncStateMachine(typeof(<<ConstructNode>g__CreateNodeComponentsAndChilds|0>d))]
		internal Task EHDBLNEKEIG(bool ignoreMesh, bool onlyMesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA0314C0", Offset = "0xA02FAC0", VA = "0x18A0314C0")]
		internal Material GDOFNHOGFDF(PLLBMPLNJGP p)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct ODAOLBCGFON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public EPNFLCKAFCM node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public int nodeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private KPPGEOMKOCL <>8__1;

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

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA0399C0", Offset = "0xA037FC0", VA = "0x18A0399C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA03AB40", Offset = "0xA039140", VA = "0x18A03AB40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct CNFKNPNFCFB : IAsyncStateMachine
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
		public EPNFLCKAFCM node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private List<JFPFEKGIBOO>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA02FB20", Offset = "0xA02E120", VA = "0x18A02FB20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA0300D0", Offset = "0xA02E6D0", VA = "0x18A0300D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct PLHJOIDLMJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public int bufferIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public FCKJNBPIEKG buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private TaskAwaiter<Stream> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA03C480", Offset = "0xA03AA80", VA = "0x18A03C480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA03CCA0", Offset = "0xA03B2A0", VA = "0x18A03CCA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct ANPINBKILEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public ECGPILHJDAN scene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public bool showSceneObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public COOKOPJMGEL <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xA02EF10", Offset = "0xA02D510", VA = "0x18A02EF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xA02F9F0", Offset = "0xA02DFF0", VA = "0x18A02F9F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct NHCOGOOMKNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public Func<Task> callback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xA039330", Offset = "0xA037930", VA = "0x18A039330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xA039960", Offset = "0xA037F60", VA = "0x18A039960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct PNBLPICAJBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xA03CD00", Offset = "0xA03B300", VA = "0x18A03CD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA03CF20", Offset = "0xA03B520", VA = "0x18A03CF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct KGDHKJEAACG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public FHGFGFEMDFE animation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public int animationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private Dictionary<int, string> <typeMap>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private LCJPGEFECDJ[] <samplers>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private Dictionary<string, List<INLJELLPHNA>> <samplersByType>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private MNNABCHAOPN <samplerDef>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private TaskAwaiter<JHEHCIOMFDO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA030710", Offset = "0xA02ED10", VA = "0x18A030710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA031340", Offset = "0xA02F940", VA = "0x18A031340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct IIHABCGPJJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public FHGFGFEMDFE animation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public KOGALHOOKGL animationCache;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class HPMHALNPAFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public DGIBBMBELKH pointerData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public MCPGCIIHAMJ <>9__6;

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public HPMHALNPAFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA030430", Offset = "0xA02EA30", VA = "0x18A030430")]
		internal float[] EBHHNLEMIHI(ONNDPLHOGAP data, int frame)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class IBPOECPGOND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public bool flipRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public int targetCount;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public IBPOECPGOND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA030470", Offset = "0xA02EA70", VA = "0x18A030470")]
		internal float[] MFOJCLOKMCG(ONNDPLHOGAP data, int frame)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class BBFOJBEGMHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public float[] frameFloats;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public BlendShapeFrameWeightSetting blendShapeFrameWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public IBPOECPGOND CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public BBFOJBEGMHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA02FA50", Offset = "0xA02E050", VA = "0x18A02FA50")]
		internal float[] OKFILBBCDDG(ONNDPLHOGAP data, int frame)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct PPKNJINFDDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public AsyncTaskMethodBuilder<AnimationClip> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public int animationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private IIHABCGPJJG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public Transform root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private HPMHALNPAFC <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private AnimationClip <clip>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private int[] <nodeIds>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private KMFGAABCMIN <pointerImportContext>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private List<CKOENGNKBEL>.Enumerator <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private CKOENGNKBEL <channel>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private bool <usesPointer>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private LCJPGEFECDJ <samplerCache>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private MENHOJMHFAK <path>5__9;

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

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA03DC40", Offset = "0xA03C240", VA = "0x18A03DC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA041820", Offset = "0xA03FE20", VA = "0x18A041820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct PEDNKEDJKIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public EPNFLCKAFCM node;

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
		private FNLIJDHPCCI <lodsExtension>5__2;

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

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA03B820", Offset = "0xA039E20", VA = "0x18A03B820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA03C420", Offset = "0xA03AA20", VA = "0x18A03C420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct GMAPOKHLOFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public PPGIJKGLBKD mapper;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct NGNNBGOCOPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public LPKIABJLDGD def;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private GMAPOKHLOFK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public int materialIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private OOJAHKPFMPN <mrMapper>5__2;

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
		private IKDGKNJHLFL <sgMapper>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private BFIAEMEEPNO <unlitMapper>5__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private APHCIAKHOAN <sheenMapper>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private EANIAFLNAIH <anisotropyMapper>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private ODENNGGODCJ <transmissionMapper>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private HIFNDNADNJA <volumeMapper>5__17;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private NKFBANJCDJE <iridescenceMapper>5__18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private NDDJEAOAPMN <specularMapper>5__19;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private PFHJHNJNBDK <clearcoatMapper>5__20;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private ONCHABJKMJN <uniformMapper>5__21;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private ODHBOOCPHDE <pbr>5__22;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private DFKGBBMCCND <textureId>5__23;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private OPMHEIDHNDP <specGloss>5__24;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private KHR_materials_sheen <sheen>5__25;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private TaskAwaiter<KFFEEAHOIEA> <>u__2;

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
		private PCMEOKAEMIN <clearcoatNormalMapper>5__32;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA031530", Offset = "0xA02FB30", VA = "0x18A031530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA0392D0", Offset = "0xA0378D0", VA = "0x18A0392D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct JDDGAKNELGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public PLLBMPLNJGP primitive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xA04F6F0", Offset = "0xA04DCF0", VA = "0x18A04F6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA04F990", Offset = "0xA04DF90", VA = "0x18A04F990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct MGNNOBLJDEE : IAsyncStateMachine
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
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public int meshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public HBAJBPALING mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private NBAANDLELJE <meshCache>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private JFPLKAKPFEG <unityData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA052A40", Offset = "0xA051040", VA = "0x18A052A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA053490", Offset = "0xA051A90", VA = "0x18A053490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct DANAMOKKFEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public HBAJBPALING mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA045550", Offset = "0xA043B50", VA = "0x18A045550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA045750", Offset = "0xA043D50", VA = "0x18A045750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct DIOHEKEFIJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int meshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public JFPLKAKPFEG unityMeshData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private Mesh <mesh>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xA047110", Offset = "0xA045710", VA = "0x18A047110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA048230", Offset = "0xA046830", VA = "0x18A048230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct GJJPMDCMPDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public PLLBMPLNJGP primitive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public int meshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public int primitiveIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private List<Dictionary<string, INLJELLPHNA>> <newTargets>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private Dictionary<string, POAPBJAHENH>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private KeyValuePair<string, POAPBJAHENH> <targetAttribute>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private int <bufferID>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private TaskAwaiter<JHEHCIOMFDO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA049510", Offset = "0xA047B10", VA = "0x18A049510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xA04A520", Offset = "0xA048B20", VA = "0x18A04A520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct CEEJPJIOIDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private int <meshIndex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private HBAJBPALING <gltfMesh>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA044C70", Offset = "0xA043270", VA = "0x18A044C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xA045330", Offset = "0xA043930", VA = "0x18A045330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct DHDEOFMKEAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public DGFCBHHHIFG meshId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public HBAJBPALING mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private int <meshIndex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private PLLBMPLNJGP <primitive>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xA0457B0", Offset = "0xA043DB0", VA = "0x18A0457B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xA045E00", Offset = "0xA044400", VA = "0x18A045E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct INFIHOFJMOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public int meshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public int primitiveIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public PLLBMPLNJGP primitive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private NBAANDLELJE.DMDEEILDIDA <primData>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private Dictionary<string, POAPBJAHENH>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private KeyValuePair<string, POAPBJAHENH> <attributePair>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private HPKEMHMNNJL <sparse>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private TaskAwaiter<JHEHCIOMFDO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private INLJELLPHNA <sparseValues>5__6;

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xA04E400", Offset = "0xA04CA00", VA = "0x18A04E400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xA04F500", Offset = "0xA04DB00", VA = "0x18A04F500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct FFJGJDKCGHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public JHKMAOOHJON skin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public COOKOPJMGEL <>4__this;

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
		private TaskAwaiter<JHEHCIOMFDO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private int <i>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xA048760", Offset = "0xA046D60", VA = "0x18A048760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA049240", Offset = "0xA047840", VA = "0x18A049240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private struct LNINHDGNHDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA051F20", Offset = "0xA050520", VA = "0x18A051F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xA0523A0", Offset = "0xA0509A0", VA = "0x18A0523A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private struct MFFFCGMAKFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public AsyncTaskMethodBuilder<KFFEEAHOIEA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public CMFBMCFCJEH textureInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public bool isNormal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private KFFEEAHOIEA <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private DFKGBBMCCND <textureId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA052400", Offset = "0xA050A00", VA = "0x18A052400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xA0529D0", Offset = "0xA050FD0", VA = "0x18A0529D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct OGCNNMEPAAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public int imageCacheIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public CCCOOFINFDM image;

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

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA059500", Offset = "0xA057B00", VA = "0x18A059500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA0598B0", Offset = "0xA057EB0", VA = "0x18A0598B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct OBMFLAOLEIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public BOOEFBPDPHN texture;

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

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xA058730", Offset = "0xA056D30", VA = "0x18A058730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA058EB0", Offset = "0xA0574B0", VA = "0x18A058EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct KGOPDMBBJDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public bool markGpuOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public CCCOOFINFDM image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public NativeArray<byte> data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public Texture2D texture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xA04FDE0", Offset = "0xA04E3E0", VA = "0x18A04FDE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA0506B0", Offset = "0xA04ECB0", VA = "0x18A0506B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct NDJDGFNGMCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public bool isLinear;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public CCCOOFINFDM image;

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
		private JHEHCIOMFDO <bufferView>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private TaskAwaiter<JHEHCIOMFDO> <>u__1;

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

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA0568C0", Offset = "0xA054EC0", VA = "0x18A0568C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xA0586D0", Offset = "0xA056CD0", VA = "0x18A0586D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct KJPNPELKEEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public int textureIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public BOOEFBPDPHN texture;

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
		private CCCOOFINFDM <image>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private bool <isFirstInstance>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xA050720", Offset = "0xA04ED20", VA = "0x18A050720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xA051AB0", Offset = "0xA0500B0", VA = "0x18A051AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct BKMADAGCDOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public AsyncTaskMethodBuilder<INLJELLPHNA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public COOKOPJMGEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public POAPBJAHENH accessorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public bool isPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private AJGPAILNNFH <accessor>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private TaskAwaiter<JHEHCIOMFDO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xA0445C0", Offset = "0xA042BC0", VA = "0x18A0445C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xA044AD0", Offset = "0xA0430D0", VA = "0x18A044AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public int BHBGLDFDGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public int OGCCPKPBHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private bool LBMFJMLJAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private bool EELFOJMKDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private Dictionary<Stream, NativeArray<byte>> GFPLFHPLJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public bool DLAAJIGNAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public bool GMIFPJCMGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public bool FJHPNGDACGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x63")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public bool DFOAILFNFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public bool HMJDCEBGHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public APGDOOLEJPN PJHHMHKIICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	protected IKIADIKLFCH JEGDGGNBMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	protected MMFFMLJGBMO DDJABOPKHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	protected GameObject LGPMDFFGHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	protected readonly LPKIABJLDGD PMDJFCMBMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	internal CNNJFIOEFEH DKAGLAOAOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	protected string NGKCDPAGMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	protected PFJIDLENMNG DHCEGBJODLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	protected HHLPFANFNFB IECJNMFAOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	protected HBGFMPKCGMN FBNNBMPIMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	protected bool IFPEKINICBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	protected NKILHPIMAEN CJKPNLIFGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	protected IProgress<NKILHPIMAEN> ACDFBAHPKJI;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static ILogger FJPEHIICMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	protected ColorSpace DECENEONBMG;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	internal static List<Texture> GDAJFOMOGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private Dictionary<int, int> HPHJHPIAPDL;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool CKCIIBHPNLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA023BA0", Offset = "0xA0221A0", VA = "0x18A023BA0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xAB4E30", Offset = "0xAB3430", VA = "0x180AB4E30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public HHLPFANFNFB HMJJONKLDKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xEDC690", Offset = "0xEDAC90", VA = "0x180EDC690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Transform HBAFMPONHEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xAA70F0", Offset = "0xAA56F0", VA = "0x180AA70F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public GameObject MLIOPANEEMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xAA5560", Offset = "0xAA3B60", VA = "0x180AA5560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xAA9ED0", Offset = "0xAA84D0", VA = "0x180AA9ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private AnimationClip[] PMGBPMEMFDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xAB2A30", Offset = "0xAB1030", VA = "0x180AB2A30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public MJKJLONOBJM GNMONFDAJEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xAC5000", Offset = "0xAC3600", VA = "0x180AC5000")]
		[CompilerGenerated]
		get
		{
			return default(MJKJLONOBJM);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xEF6820", Offset = "0xEF4E20", VA = "0x180EF6820")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public string FNAELLCMEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xAA5620", Offset = "0xAA3C20", VA = "0x180AA5620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xAA5640", Offset = "0xAA3C40", VA = "0x180AA5640")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public GameObject LIFHDDDGPOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xAB0560", Offset = "0xAAEB60", VA = "0x180AB0560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public JPOLJPEMOMM[] OEEFCGJAFDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA01F3B0", Offset = "0xA01D9B0", VA = "0x18A01F3B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Texture2D[] PNKLKPGHIEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x14E0B80", Offset = "0x14DF180", VA = "0x1814E0B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public CNNJFIOEFEH[] FDGPEAPHMNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA01EE60", Offset = "0xA01D460", VA = "0x18A01EE60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public KOGALHOOKGL[] AFAPHHEDPMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xA01F3D0", Offset = "0xA01D9D0", VA = "0x18A01F3D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public NBAANDLELJE[] FJBENILIHGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xA025CF0", Offset = "0xA0242F0", VA = "0x18A025CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public List<UnityEngine.Object> DDAPFOABOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xAA5710", Offset = "0xAA3D10", VA = "0x180AA5710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	protected HOLINFLNHMO OALJMBCNDOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA025D10", Offset = "0xA024310", VA = "0x18A025D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0xA0272D0", Offset = "0xA0258D0", VA = "0x18A0272D0")]
	public COOKOPJMGEL(string OEHDACAAMFL, IKIADIKLFCH PLMLGIGGGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0xA0271D0", Offset = "0xA0257D0", VA = "0x18A0271D0")]
	public COOKOPJMGEL(Stream DHHOKJCCPJH, IKIADIKLFCH PLMLGIGGGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0xA027320", Offset = "0xA025920", VA = "0x18A027320")]
	private COOKOPJMGEL(IKIADIKLFCH PLMLGIGGGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xA01AAC0", Offset = "0xA0190C0", VA = "0x18A01AAC0")]
	private NativeArray<byte> APNFHJEMKGC(Stream ICLFABGEPJB)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0xA01C170", Offset = "0xA01A770", VA = "0x18A01C170")]
	private void DEGPNANOPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0xA01C4C0", Offset = "0xA01AAC0", VA = "0x18A01C4C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0xA026420", Offset = "0xA024A20", VA = "0x18A026420")]
	[AsyncStateMachine(typeof(CJAEDFNMIGF))]
	public Task PCFOFOPCDEG(int FMKCJNDALPC = -1, bool CAKMDIAJJBC = true, [Optional] Action<GameObject, ExceptionDispatchInfo> JADLNAKKKPC, [Optional] CancellationToken PJCIHHKJKBP, [Optional] IProgress<NKILHPIMAEN> ACDFBAHPKJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0xA022E20", Offset = "0xA021420", VA = "0x18A022E20")]
	[AsyncStateMachine(typeof(BHEPNLIMCFP))]
	private Task LPHIHHCFEAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0xA020540", Offset = "0xA01EB40", VA = "0x18A020540", Slot = "5")]
	[AsyncStateMachine(typeof(DIBOHEDOFNP))]
	public virtual Task<Material> KOAEIPCHNEH(int JJCENJEBMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0xA01C040", Offset = "0xA01A640", VA = "0x18A01C040", Slot = "6")]
	[AsyncStateMachine(typeof(KEELPAFMGDJ))]
	public virtual Task<Mesh> DAGNNJDELDK(int EGNNMNKHPCA, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0xA024610", Offset = "0xA022C10", VA = "0x18A024610")]
	[AsyncStateMachine(typeof(DFLKGLNKAKP))]
	private Task NIFDGOAPGJL(string CMAJFHODALG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xA025BB0", Offset = "0xA0241B0", VA = "0x18A025BB0")]
	private void NNJLAJJIDKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0xA01EC00", Offset = "0xA01D200", VA = "0x18A01EC00")]
	[AsyncStateMachine(typeof(PBMIBJBAHKC))]
	protected Task GONMLJLOFEG(int FMKCJNDALPC = -1, bool CAKMDIAJJBC = true, [Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA01BD00", Offset = "0xA01A300", VA = "0x18A01BD00")]
	private void CNGGNDIEBDC(ECGPILHJDAN BLFJNFOGIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xA01D2C0", Offset = "0xA01B8C0", VA = "0x18A01D2C0")]
	public NativeArray<byte> GAHAFBFNPNM(GOEMCIBDHAJ NAPFCPGLOLA)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0xA025D30", Offset = "0xA024330", VA = "0x18A025D30")]
	[AsyncStateMachine(typeof(ECHJBLNJBOM))]
	private Task<JHEHCIOMFDO> OFMAMFOCAKA(NIFLFOIDJEE DDFCPKBJMED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0xA026960", Offset = "0xA024F60", VA = "0x18A026960")]
	private float PLFLPMFIBJL(List<double> BCJGCBOAFIK, int IPBGABBAMLK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xA01F960", Offset = "0xA01DF60", VA = "0x18A01F960")]
	[AsyncStateMachine(typeof(OKFAEHLMOIE))]
	private Task<GameObject> KBJKGMMKGAI(int PLBMJMHLGMM, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0xA01F3F0", Offset = "0xA01D9F0", VA = "0x18A01F3F0")]
	[AsyncStateMachine(typeof(PPEOHHPGKDP))]
	private Task<(Vector3, Quaternion, Vector3)[]> IAIBHIJBJPD(EPNFLCKAFCM EMOGDLPNEGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0xA01FAA0", Offset = "0xA01E0A0", VA = "0x18A01FAA0")]
	private bool KIPHMADIDHJ(EPNFLCKAFCM EMOGDLPNEGA, GameObject PCFJPEACHBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0xA01C650", Offset = "0xA01AC50", VA = "0x18A01C650", Slot = "7")]
	[AsyncStateMachine(typeof(ODAOLBCGFON))]
	protected virtual Task EENMFOHINEJ(EPNFLCKAFCM EMOGDLPNEGA, int EGKCHCJOJAH, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0xA01F840", Offset = "0xA01DE40", VA = "0x18A01F840")]
	[AsyncStateMachine(typeof(CNFKNPNFCFB))]
	private Task KBDMOILFFHE(EPNFLCKAFCM EMOGDLPNEGA, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0xA01B5E0", Offset = "0xA019BE0", VA = "0x18A01B5E0")]
	[AsyncStateMachine(typeof(PLHJOIDLMJP))]
	protected Task CEBJOGBPLDG(FCKJNBPIEKG DNGAEEFBGGO, int AHGMLIKOIKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0xA01E910", Offset = "0xA01CF10", VA = "0x18A01E910", Slot = "8")]
	[AsyncStateMachine(typeof(ANPINBKILEM))]
	protected virtual Task GJNEGELOBDP(ECGPILHJDAN BLFJNFOGIPN, bool CAKMDIAJJBC, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0xA01F730", Offset = "0xA01DD30", VA = "0x18A01F730", Slot = "9")]
	protected virtual JHEHCIOMFDO JHPLBOCMFEL(int AHGMLIKOIKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0xA01BCB0", Offset = "0xA01A2B0", VA = "0x18A01BCB0")]
	private void CNCNJGCEOGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0xA01C330", Offset = "0xA01A930", VA = "0x18A01C330")]
	private void DPCHCFKJJMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0xA01D070", Offset = "0xA01B670", VA = "0x18A01D070")]
	[AsyncStateMachine(typeof(NHCOGOOMKNE))]
	private Task FKNNOIKLFOB(Func<Task> LAOAAOBGDLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0xA020650", Offset = "0xA01EC50", VA = "0x18A020650")]
	[AsyncStateMachine(typeof(PNBLPICAJBB))]
	protected Task KOGAOABDALL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0xA025E40", Offset = "0xA024440", VA = "0x18A025E40")]
	private static string OFODCMIBCMG(Transform JNMMMBJNOND, Transform BOCNDANOLJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0xA01C790", Offset = "0xA01AD90", VA = "0x18A01C790", Slot = "10")]
	[AsyncStateMachine(typeof(KGDHKJEAACG))]
	protected virtual Task EFOEDCDMBNN(FHGFGFEMDFE AGCIMJNMJCM, int DJMHFDEMABG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0xA022EF0", Offset = "0xA0214F0", VA = "0x18A022EF0")]
	protected void MBDKECKFJLD(AnimationClip DAEDHPPGLAG, string OKJEOIMPAIB, string[] MIFDKLLPDKG, ONNDPLHOGAP ECBHOIMIBKD, ONNDPLHOGAP PCCGPNIJDPB, EPGLIBFPAPA IBLGEJEKAPD, Type DABNHAGDCEB, MCPGCIIHAMJ AIFGAGJNDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0xA0201F0", Offset = "0xA01E7F0", VA = "0x18A0201F0")]
	private void KMMBJCNJPMF(Keyframe[] CAPJEICGMEJ, int NOJPBNJGOMH, EPGLIBFPAPA IFOFJDILHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0xA023BE0", Offset = "0xA0221E0", VA = "0x18A023BE0")]
	private static float MMNNCPDLOEC(Keyframe[] CAPJEICGMEJ, int NOJPBNJGOMH, bool CBONECEPNIA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xA023DC0", Offset = "0xA0223C0", VA = "0x18A023DC0")]
	[AsyncStateMachine(typeof(PPKNJINFDDC))]
	protected Task<AnimationClip> MPDNJOKKBHK(Transform BOCNDANOLJJ, int DJMHFDEMABG, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0xA026C70", Offset = "0xA025270", VA = "0x18A026C70")]
	private bool POJJFONPJDH(GameObject PCFJPEACHBC, EPNFLCKAFCM EMOGDLPNEGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0xA0228C0", Offset = "0xA020EC0", VA = "0x18A0228C0")]
	private bool LOLDMNKFDDD(GameObject PCFJPEACHBC, EPNFLCKAFCM EMOGDLPNEGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0xA01C8B0", Offset = "0xA01AEB0", VA = "0x18A01C8B0")]
	[AsyncStateMachine(typeof(PEDNKEDJKIJ))]
	private Task EHGIKBDLOMC(HHLPFANFNFB HMJMPFHGNOJ, GameObject PCFJPEACHBC, EPNFLCKAFCM EMOGDLPNEGA, int EGKCHCJOJAH, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0xA024710", Offset = "0xA022D10", VA = "0x18A024710", Slot = "11")]
	[AsyncStateMachine(typeof(NGNNBGOCOPN))]
	protected virtual Task NJCDHLFCIKN(LPKIABJLDGD NDLIDFKNCIJ, int JJCENJEBMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0xA01D9A0", Offset = "0xA01BFA0", VA = "0x18A01D9A0", Slot = "12")]
	protected virtual Task GFLKIGLFMKD(LPKIABJLDGD NDLIDFKNCIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0xA01B990", Offset = "0xA019F90", VA = "0x18A01B990", Slot = "13")]
	protected virtual JMFJCBMAOAN CLEECEANPEP(CMFBMCFCJEH NDLIDFKNCIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0xA0269F0", Offset = "0xA024FF0", VA = "0x18A0269F0", Slot = "14")]
	protected virtual OJFIOFGCNIC PLKMOJCAFDM(LPKIABJLDGD NDLIDFKNCIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0xA01B3C0", Offset = "0xA0199C0", VA = "0x18A01B3C0", Slot = "15")]
	protected virtual KHR_materials_transmission CCKEFPNNNNN(LPKIABJLDGD NDLIDFKNCIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0xA01CDF0", Offset = "0xA01B3F0", VA = "0x18A01CDF0", Slot = "16")]
	protected virtual KHR_materials_sheen FFKMMGMMPME(LPKIABJLDGD NDLIDFKNCIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0xA026B30", Offset = "0xA025130", VA = "0x18A026B30", Slot = "17")]
	protected virtual KHR_materials_anisotropy POFGJBOFFOH(LPKIABJLDGD NDLIDFKNCIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0xA01CF30", Offset = "0xA01B530", VA = "0x18A01CF30", Slot = "18")]
	protected virtual KHR_materials_dispersion FGNJPONKLCN(LPKIABJLDGD NDLIDFKNCIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0xA01A510", Offset = "0xA018B10", VA = "0x18A01A510", Slot = "19")]
	protected virtual KHR_materials_volume AABCLDNCGAB(LPKIABJLDGD NDLIDFKNCIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0xA01B280", Offset = "0xA019880", VA = "0x18A01B280", Slot = "20")]
	protected virtual KHR_materials_ior BOMBNFFIGPL(LPKIABJLDGD NDLIDFKNCIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0xA01A840", Offset = "0xA018E40", VA = "0x18A01A840", Slot = "21")]
	protected virtual KHR_materials_iridescence AICDEPKLIFB(LPKIABJLDGD NDLIDFKNCIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0xA01F520", Offset = "0xA01DB20", VA = "0x18A01F520", Slot = "22")]
	protected virtual KHR_materials_specular ICHGDPGGBIA(LPKIABJLDGD NDLIDFKNCIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0xA01B850", Offset = "0xA019E50", VA = "0x18A01B850", Slot = "23")]
	protected virtual KHR_materials_clearcoat CJIINMBJGEC(LPKIABJLDGD NDLIDFKNCIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0xA026870", Offset = "0xA024E70", VA = "0x18A026870")]
	[AsyncStateMachine(typeof(JDDGAKNELGL))]
	private Task PLBIMPAJFCJ(PLLBMPLNJGP EBFGEDGGNBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0xA01EE80", Offset = "0xA01D480", VA = "0x18A01EE80", Slot = "24")]
	[AsyncStateMachine(typeof(MGNNOBLJDEE))]
	protected virtual Task HFFCODHJLFN(HBAJBPALING KNHPHEPPGOL, int EGNNMNKHPCA, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0xA0241F0", Offset = "0xA0227F0", VA = "0x18A0241F0")]
	[AsyncStateMachine(typeof(DANAMOKKFEP))]
	private Task NEBDEHDCDLF(HBAJBPALING KNHPHEPPGOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0xA026130", Offset = "0xA024730", VA = "0x18A026130")]
	private static uint[] OIIFBKDGMOB(HBAJBPALING KNHPHEPPGOL, [Out] uint KEHLCMKHPIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0xA0216E0", Offset = "0xA01FCE0", VA = "0x18A0216E0")]
	protected void LHACBLLJKIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0xA01B030", Offset = "0xA019630", VA = "0x18A01B030")]
	protected void BMHPEFKDEEK(Mesh KNHPHEPPGOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0xA020720", Offset = "0xA01ED20", VA = "0x18A020720")]
	private JFPLKAKPFEG LCIPOJHLNFK(HBAJBPALING JJHNBBAHFKM, int EGNNMNKHPCA, bool MDHEKMAKIDF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0xA024810", Offset = "0xA022E10", VA = "0x18A024810")]
	[AsyncStateMachine(typeof(DIOHEKEFIJN))]
	protected Task NJEDCAPGOHI(JFPLKAKPFEG CCJALOKAAPE, int EGNNMNKHPCA, string JPKCEBKHLFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0xA01E690", Offset = "0xA01CC90", VA = "0x18A01E690")]
	private void GGELMBFJNHF(JFPLKAKPFEG CCJALOKAAPE, int EGNNMNKHPCA, Mesh KNHPHEPPGOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0xA01AD60", Offset = "0xA019360", VA = "0x18A01AD60", Slot = "25")]
	[AsyncStateMachine(typeof(GJJPMDCMPDN))]
	protected virtual Task BAHGLAGPNJA(PLLBMPLNJGP EBFGEDGGNBO, int EGNNMNKHPCA, int JMNPCPHJGBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0xA021960", Offset = "0xA01FF60", VA = "0x18A021960", Slot = "26")]
	protected virtual void LOHLHAOLJMG(PLLBMPLNJGP EBFGEDGGNBO, int EGNNMNKHPCA, int JMNPCPHJGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0xA01FB90", Offset = "0xA01E190", VA = "0x18A01FB90")]
	private void KKPLGKECLGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0xA01B500", Offset = "0xA019B00", VA = "0x18A01B500")]
	[AsyncStateMachine(typeof(CEEJPJIOIDD))]
	private Task CCPJPFKEEIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0xA024940", Offset = "0xA022F40", VA = "0x18A024940")]
	[AsyncStateMachine(typeof(DHDEOFMKEAO))]
	private Task NLJNHOPGLLO(HBAJBPALING KNHPHEPPGOL, DGFCBHHHIFG BGPDDCDFJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0xA01D860", Offset = "0xA01BE60", VA = "0x18A01D860", Slot = "27")]
	[AsyncStateMachine(typeof(INFIHOFJMOI))]
	protected virtual Task GCONHCDJOBM(PLLBMPLNJGP EBFGEDGGNBO, int EGNNMNKHPCA, int JMNPCPHJGBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0xA024C80", Offset = "0xA023280", VA = "0x18A024C80")]
	protected void NMPLFPMCEFK(NBAANDLELJE.DMDEEILDIDA GLILOJBBJLI, JFPLKAKPFEG DEAMNIPHHCP, uint FCHDOEINBAK, int LMLMFMNBOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0xA026560", Offset = "0xA024B60", VA = "0x18A026560")]
	private void PDIELBNELHM(Dictionary<string, INLJELLPHNA> AAJLLJNOJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0xA024A60", Offset = "0xA023060", VA = "0x18A024A60")]
	protected MeshTopology NMOAEBBMLNP(IINGIELCDJB IBLGEJEKAPD)
	{
		return default(MeshTopology);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0xA01EFB0", Offset = "0xA01D5B0", VA = "0x18A01EFB0")]
	private void HFGJKDJKHJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0xA01C510", Offset = "0xA01AB10", VA = "0x18A01C510", Slot = "28")]
	[AsyncStateMachine(typeof(FFJGJDKCGHH))]
	protected virtual Task EEMLCPBFEDD(JHKMAOOHJON MDLOFBNGHJH, SkinnedMeshRenderer MAFJPEPPLNH, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0xA01C9F0", Offset = "0xA01AFF0", VA = "0x18A01C9F0")]
	private void EJJPKJLKPKC(Vector4[] FJOHDOKPHNI, Vector4[] CFJKLHHEILI, BoneWeight[] MFIDFMLHDJP, uint PIOCNHLFCNE = 0u)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0xA026790", Offset = "0xA024D90", VA = "0x18A026790")]
	[AsyncStateMachine(typeof(LNINHDGNHDF))]
	private Task PFCHINODNGN(int PMIGBJGNLLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0xA025FF0", Offset = "0xA0245F0", VA = "0x18A025FF0")]
	[AsyncStateMachine(typeof(MFFFCGMAKFL))]
	private Task<KFFEEAHOIEA> OIGAIOENDHP(CMFBMCFCJEH KNKIHPAHNJE, bool CDKOEICBPFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0xA01AFD0", Offset = "0xA0195D0", VA = "0x18A01AFD0")]
	private static int BMEODHDHFNC(byte[] CDDIADBJAOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0xA0242F0", Offset = "0xA0228F0", VA = "0x18A0242F0")]
	private Dictionary<int, int> NFGOGJMOCDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0xA023F20", Offset = "0xA022520", VA = "0x18A023F20")]
	private void NDJNJFINOBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0xA01BAD0", Offset = "0xA01A0D0", VA = "0x18A01BAD0")]
	private Stream CNBLBCJGAMA(CCCOOFINFDM FHMCLBFBJBJ, int BCENIPBEEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0xA01AE90", Offset = "0xA019490", VA = "0x18A01AE90")]
	[AsyncStateMachine(typeof(OGCNNMEPAAI))]
	protected Task BHKPKNHLPLC(CCCOOFINFDM FHMCLBFBJBJ, int BCENIPBEEFB, bool ODFLAAGHNNC, bool GNLFAOKCCFM, bool CDKOEICBPFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0xA01D4B0", Offset = "0xA01BAB0", VA = "0x18A01D4B0")]
	[AsyncStateMachine(typeof(OBMFLAOLEIH))]
	protected Task GBPLJHEHPKO(BOOEFBPDPHN BDFJHOHMCFM, int OBCPINMCNPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0xA01B6F0", Offset = "0xA019CF0", VA = "0x18A01B6F0")]
	[AsyncStateMachine(typeof(KGOPDMBBJDD))]
	private Task<Texture2D> CIALLLJGEKB(CCCOOFINFDM FHMCLBFBJBJ, Texture2D BDFJHOHMCFM, NativeArray<byte> CDDIADBJAOB, bool ODFLAAGHNNC, bool GNLFAOKCCFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0xA01A980", Offset = "0xA018F80", VA = "0x18A01A980", Slot = "29")]
	[AsyncStateMachine(typeof(NDJDGFNGMCO))]
	protected virtual Task AKABNLGBPJH(Stream ICLFABGEPJB, bool ODFLAAGHNNC, bool GNLFAOKCCFM, bool CDKOEICBPFK, CCCOOFINFDM FHMCLBFBJBJ, int BCENIPBEEFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0xA0203E0", Offset = "0xA01E9E0", VA = "0x18A0203E0", Slot = "30")]
	protected virtual int KMMIOHNAGJL(BOOEFBPDPHN BDFJHOHMCFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0xA01EB90", Offset = "0xA01D190", VA = "0x18A01EB90", Slot = "31")]
	protected virtual bool GMHEFGCLCID(BOOEFBPDPHN BDFJHOHMCFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0xA01EA50", Offset = "0xA01D050", VA = "0x18A01EA50", Slot = "32")]
	[AsyncStateMachine(typeof(KJPNPELKEEB))]
	protected virtual Task GMCKEFPKLJF(BOOEFBPDPHN BDFJHOHMCFM, int OBCPINMCNPD, bool ODFLAAGHNNC, bool GNLFAOKCCFM, bool CDKOEICBPFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0xA01ED20", Offset = "0xA01D320", VA = "0x18A01ED20")]
	[AsyncStateMachine(typeof(BKMADAGCDOG))]
	[CompilerGenerated]
	private Task<INLJELLPHNA> GPDNPFFCHEP(POAPBJAHENH LFNHFOMPJNE, bool OFFGJDDDCOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0xA01D5D0", Offset = "0xA01BBD0", VA = "0x18A01D5D0")]
	[CompilerGenerated]
	internal static INLJELLPHNA GCAEOAHKBGB(string ALDNDGMMNLD, IIHABCGPJJG P_1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0xA01D160", Offset = "0xA01B760", VA = "0x18A01D160")]
	[CompilerGenerated]
	private void FNNGNEIODOB(DFKGBBMCCND KJMDCGMNCKC, JMFJCBMAOAN OPECENJPGMK, [Out] Vector2 EAHAEIJNIMH, [Out] Vector2 PIOCNHLFCNE, GMAPOKHLOFK P_4)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0xA01F660", Offset = "0xA01DC60", VA = "0x18A01F660")]
	[CompilerGenerated]
	private void JBKPMNMIMOL(GMAPOKHLOFK P_0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0xA01A650", Offset = "0xA018C50", VA = "0x18A01A650")]
	[CompilerGenerated]
	private void AFJFANAPDAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0xA023880", Offset = "0xA021E80", VA = "0x18A023880")]
	[CompilerGenerated]
	private TextureWrapMode MCHLBDLHLGF(FGBEDDKNMDH MIKLOHLNMJI)
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
		public enum OIKGHIAPJLH
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
		private sealed class CFPELFFJNDI<T> where T : GLTFPlugin
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			public Type pluginType;

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public CFPELFFJNDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x6F87B50", Offset = "0x6F86150", VA = "0x186F87B50")]
			internal bool FBMOEGLBHCI(T p)
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
		private OIKGHIAPJLH blendShapeExportProperties;

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

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string Generator
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xA04B290", Offset = "0xA049890", VA = "0x18A04B290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool ExportNames
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xAD4490", Offset = "0xAD2A90", VA = "0x180AD4490")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0xAD43F0", Offset = "0xAD29F0", VA = "0x180AD43F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool ExportFullPath
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xF77430", Offset = "0xF75A30", VA = "0x180F77430")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x1618980", Offset = "0x1616F80", VA = "0x181618980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool UseMainCameraVisibility
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x1D69430", Offset = "0x1D67A30", VA = "0x181D69430")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x2AECF70", Offset = "0x2AEB570", VA = "0x182AECF70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool TryExportTexturesFromDisk
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xF28FA0", Offset = "0xF275A0", VA = "0x180F28FA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xF3FBF0", Offset = "0xF3E1F0", VA = "0x180F3FBF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool UseTextureFileTypeHeuristic
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xF3F9E0", Offset = "0xF3DFE0", VA = "0x180F3F9E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xF3F930", Offset = "0xF3DF30", VA = "0x180F3F930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool ExportVertexColors
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x7807960", Offset = "0x7805F60", VA = "0x187807960")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x78A7460", Offset = "0x78A5A60", VA = "0x1878A7460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public int DefaultJpegQuality
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xAC5000", Offset = "0xAC3600", VA = "0x180AC5000")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xEF6820", Offset = "0xEF4E20", VA = "0x180EF6820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool ExportDisabledGameObjects
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x2AD1EA0", Offset = "0x2AD04A0", VA = "0x182AD1EA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x871FC50", Offset = "0x871E250", VA = "0x18871FC50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool ExportAnimations
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xFE10B0", Offset = "0xFDF6B0", VA = "0x180FE10B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xFE0520", Offset = "0xFDEB20", VA = "0x180FE0520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool BakeAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xFE0530", Offset = "0xFDEB30", VA = "0x180FE0530")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xFE0FF0", Offset = "0xFDF5F0", VA = "0x180FE0FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		[Obsolete("Add/remove \"AnimationPointerPlugin\" from ExportPlugins instead.")]
		public bool UseAnimationPointer
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xA04B2A0", Offset = "0xA0498A0", VA = "0x18A04B2A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xA04B3E0", Offset = "0xA0499E0", VA = "0x18A04B3E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool UniqueAnimationNames
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xFE0AB0", Offset = "0xFDF0B0", VA = "0x180FE0AB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xFE0AA0", Offset = "0xFDF0A0", VA = "0x180FE0AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool BlendShapeExportSparseAccessors
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x19D4810", Offset = "0x19D2E10", VA = "0x1819D4810")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x19DAEA0", Offset = "0x19D94A0", VA = "0x1819DAEA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public OIKGHIAPJLH BlendShapeExportProperties
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xB28EF0", Offset = "0xB274F0", VA = "0x180B28EF0")]
			get
			{
				return default(OIKGHIAPJLH);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0xB28E50", Offset = "0xB27450", VA = "0x180B28E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool BakeSkinnedMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xA04B280", Offset = "0xA049880", VA = "0x18A04B280")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0xA04B3D0", Offset = "0xA0499D0", VA = "0x18A04B3D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xA04AC40", Offset = "0xA049240", VA = "0x18A04AC40")]
		internal string MGOIHHLGFEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xA04AA70", Offset = "0xA049070", VA = "0x18A04AA70")]
		public static GLTFSettings KEOJLMHELMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xA04AA00", Offset = "0xA049000", VA = "0x18A04AA00")]
		public static GLTFSettings JAOBLODBBOH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xA04AFB0", Offset = "0xA0495B0", VA = "0x18A04AFB0")]
		public static bool MKDEEDOJPON([Out] GLTFSettings CJEINKGIPEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0xA04A580", Offset = "0xA048B80", VA = "0x18A04A580")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ClearStatics()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA04A640", Offset = "0xA048C40", VA = "0x18A04A640")]
		private static void EGGMEEEHBOI(GLTFSettings CJEINKGIPEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA04B180", Offset = "0xA049780", VA = "0x18A04B180")]
		public GLTFSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3DE0120", Offset = "0x3DDE720", VA = "0x183DE0120")]
		[CompilerGenerated]
		internal static List<Type> HCEAMKHIDBL<T>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3DDFD20", Offset = "0x3DDE320", VA = "0x183DDFD20")]
		[CompilerGenerated]
		internal static void CGHPOCELDNI<T>(List<T> GIOPDCKENIL) where T : GLTFPlugin
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class ShaderNotFoundException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xA059F10", Offset = "0xA058510", VA = "0x18A059F10")]
		public ShaderNotFoundException()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA059E60", Offset = "0xA058460", VA = "0x18A059E60")]
		public ShaderNotFoundException(string GKNICJPCIJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xA059EC0", Offset = "0xA0584C0", VA = "0x18A059EC0")]
		protected ShaderNotFoundException(SerializationInfo PCLIBIJEFPO, StreamingContext JIFPJFGEAIK)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class GMOLDLIBGFD : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0xA04B640", Offset = "0xA049C40", VA = "0x18A04B640")]
	public GMOLDLIBGFD(string GKNICJPCIJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class AKKLFNAEKIP : ILogHandler
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private readonly StringBuilder GLBOAFALJBG;

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0xA0441F0", Offset = "0xA0427F0", VA = "0x18A0441F0")]
	private string JCFPDIMEEBG(LogType ENKIGIHKONI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0xA044310", Offset = "0xA042910", VA = "0x18A044310", Slot = "4")]
	public void LogFormat(LogType ENKIGIHKONI, UnityEngine.Object JIFPJFGEAIK, string OFCLANOKPBA, params object[] PNGANGECEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0xA044270", Offset = "0xA042870", VA = "0x18A044270", Slot = "5")]
	public void LogException(Exception MPBIHBFIGPI, UnityEngine.Object JIFPJFGEAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0xA0443D0", Offset = "0xA0429D0", VA = "0x18A0443D0")]
	public void MJNHJIMCJNM(string OFCLANOKPBA = "{0}")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0xA044540", Offset = "0xA042B40", VA = "0x18A044540")]
	public AKKLFNAEKIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class FFMLMBPIJKI
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0xA049440", Offset = "0xA047A40", VA = "0x18A049440")]
	public static string OKNDAPMDHNA(Uri BCKMBPACMHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0xA0494A0", Offset = "0xA047AA0", VA = "0x18A0494A0")]
	public static string PAGIOHMIEMK(string EGKKFAOJKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0xA049330", Offset = "0xA047930", VA = "0x18A049330")]
	public static void LPNOECNKIEK(string BCKMBPACMHN, [Out] byte[] JFFCIGPAGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0xA0492A0", Offset = "0xA0478A0", VA = "0x18A0492A0")]
	public static bool KMDFFJHNGMH(string BCKMBPACMHN)
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
		private KCBKDEHHPJJ JMOKLIGIKNF;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public KCBKDEHHPJJ BPJODHANJAF
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0xA04F690", Offset = "0xA04DC90", VA = "0x18A04F690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xA04F560", Offset = "0xA04DB60", VA = "0x18A04F560")]
		public InstantiatedGLTFObject Duplicate()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xA04F640", Offset = "0xA04DC40", VA = "0x18A04F640")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
		public InstantiatedGLTFObject()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public struct BlendShapeFrameWeightSetting
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public enum CBGEJOMFNIM
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
		internal CBGEJOMFNIM _option;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		[SerializeField]
		internal float _multiplier;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float Multiplier
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0xA044BE0", Offset = "0xA0431E0", VA = "0x18A044BE0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xA044BD0", Offset = "0xA0431D0", VA = "0x18A044BD0")]
		public BlendShapeFrameWeightSetting(CBGEJOMFNIM BOPNBEFPBIO)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xA044B40", Offset = "0xA043140", VA = "0x18A044B40")]
		public static float HNGLNPFKABH(BlendShapeFrameWeightSetting DOLPOBDGKFC)
		{
			return default(float);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public enum GPELHADHKPH
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
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract COOKOPJMGEL GKICIEPEBGN(string OEHDACAAMFL, IKIADIKLFCH PLMLGIGGGNL);

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xD5F7D0", Offset = "0xD5DDD0", VA = "0x180D5F7D0")]
		protected ImporterFactory()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class DefaultImporterFactory : ImporterFactory
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xA048290", Offset = "0xA046890", VA = "0x18A048290", Slot = "4")]
		public override COOKOPJMGEL GKICIEPEBGN(string OEHDACAAMFL, IKIADIKLFCH PLMLGIGGGNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xD5F7D0", Offset = "0xD5DDD0", VA = "0x180D5F7D0")]
		public DefaultImporterFactory()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal static class PNBPMAMNBII
{
	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0xA059A00", Offset = "0xA058000", VA = "0x18A059A00")]
	internal static void CMJDJFPMPIM(this Material PFHPGDKJCCC, string DJJGHDIMGHN, bool HFPFCKAPBFI)
	{
	}
}
namespace UnityGLTF
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class MaterialLibrary : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xD5F7D0", Offset = "0xD5DDD0", VA = "0x180D5F7D0")]
		public MaterialLibrary()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal static class OICCGDHLHGO
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class IJIEFBPEGPM
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

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public IJIEFBPEGPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xA04E0A0", Offset = "0xA04C6A0", VA = "0x18A04E0A0")]
		internal void JJHOFCILCGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xA04E3B0", Offset = "0xA04C9B0", VA = "0x18A04E3B0")]
		internal void LIBFMFEHJGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xA04E310", Offset = "0xA04C910", VA = "0x18A04E310")]
		internal void LGCNCBPNOCD()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct AJAIJGIHAEK : IAsyncStateMachine
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
		private IJIEFBPEGPM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xA043B30", Offset = "0xA042130", VA = "0x18A043B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xA044180", Offset = "0xA042780", VA = "0x18A044180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0xA059910", Offset = "0xA057F10", VA = "0x18A059910")]
	[AsyncStateMachine(typeof(AJAIJGIHAEK))]
	public static Task<Texture2D> FLCJAFMBOHM(Texture2D NGOJMGCIOHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class JFPLKAKPFEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public bool[] NCIEBOFMOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public Vector3[] DBGOMLAELID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public Vector3[] ECNCFIBLKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public Vector4[] OGIBBOIMDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public Vector2[] HDIDFCDNMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public Vector2[] ANBLLPCPBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public Vector2[] FBHLJCGDLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public Vector2[] FFMCNNOOCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public Color[] HPCAJCKPPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public BoneWeight[] CFCKIDIKDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public Vector3[][] PLANKIAFAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public Vector3[][] KDJNHOHPMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public Vector3[][] DDGLOIMMHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public MeshTopology[] OFDBOHEEJLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public IINGIELCDJB[] EOCLHOKHFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public int[][] PJOANHLJOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public HashSet<int> PJFHNGMJELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public uint[] NENEHMHGFGN;

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0xA04F9F0", Offset = "0xA04DFF0", VA = "0x18A04F9F0")]
	public void ELFNJAKNOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0xA04FB00", Offset = "0xA04E100", VA = "0x18A04FB00")]
	public bool LJKEBEPAJAB(JFPLKAKPFEG AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0xA04FD50", Offset = "0xA04E350", VA = "0x18A04FD50")]
	public JFPLKAKPFEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x3E54930", Offset = "0x3E52F30", VA = "0x183E54930")]
	[CompilerGenerated]
	internal static bool OBNJMIOFLMD<T>(T[] LGJJNEKEFFJ, T[] OLELCCDLJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x3E541E0", Offset = "0x3E527E0", VA = "0x183E541E0")]
	[CompilerGenerated]
	internal static bool KAAMMFFMECB<T>(T[][] LGJJNEKEFFJ, T[][] OLELCCDLJHN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public abstract class NAINCKDDDAF : PPGIJKGLBKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	internal Material BKMHIMIHCLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private GDNANKPHMIN NHNAFOCJNMJ;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly int ENMJNMACNLO;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private static readonly int OFCHIGIKECN;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private static readonly int FAFEELJGIGE;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private static readonly int DIGKBCDHDCG;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private static readonly int ECLINKJGGKG;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private static readonly int LAJHEGOPIJD;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	private static readonly int IDACBMGDBKF;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	private static readonly int BKLOIAMDGAC;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	private static readonly int PGPAHAPNNID;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	private static readonly int HMLHFPCAGMN;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	private static readonly int HPFLBKGHABG;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	private static readonly int HGNLIKAGHEF;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	private static readonly int KKDKDJACJHH;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	private static readonly int FMFJJNKDLFD;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Material GOHKLGDEHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public virtual GDNANKPHMIN ODLBPNOEBJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xA0550D0", Offset = "0xA0536D0", VA = "0x18A0550D0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public double NBOIHMBGAPL
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xA056300", Offset = "0xA054900", VA = "0x18A056300", Slot = "12")]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xA0564A0", Offset = "0xA054AA0", VA = "0x18A0564A0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public virtual bool HHFICGMFKNB
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xA0563C0", Offset = "0xA0549C0", VA = "0x18A0563C0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public virtual bool NJMAPGNJOCE
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xA056080", Offset = "0xA054680", VA = "0x18A056080", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Texture FBDIBKIKOPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xA056240", Offset = "0xA054840", VA = "0x18A056240", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int GBFPIGCHFKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xA055000", Offset = "0xA053600", VA = "0x18A055000", Slot = "16")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public Vector2 MEOKMOKBFOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xA0562A0", Offset = "0xA0548A0", VA = "0x18A0562A0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public double OEACGHPBFAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xA056100", Offset = "0xA054700", VA = "0x18A056100", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public Vector2 KODGAIGNPAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xA055070", Offset = "0xA053670", VA = "0x18A055070", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int MMBLDKBFMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xA055E30", Offset = "0xA054430", VA = "0x18A055E30", Slot = "20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Color GDMHJLEIDOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0xA056350", Offset = "0xA054950", VA = "0x18A056350", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract PPGIJKGLBKD JGHKMFOJCLP();

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0xAB22B0", Offset = "0xAB08B0", VA = "0x180AB22B0")]
	protected NAINCKDDDAF(Material BEAKBILFDLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0xA056790", Offset = "0xA054D90", VA = "0x18A056790")]
	protected NAINCKDDDAF(string JGKMDNFNPPN, string PLHNAHAEBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0xA056160", Offset = "0xA054760", VA = "0x18A056160")]
	protected void JBOAOAKOFLP(Material PFHPGDKJCCC, bool DHEOGMCFHLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0xA055EA0", Offset = "0xA0544A0", VA = "0x18A055EA0")]
	protected void FONDPCPOAJH(Material PFHPGDKJCCC, bool EIJKBIIDAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0xA055B70", Offset = "0xA054170", VA = "0x18A055B70")]
	protected void EGPOOIJEBJD(Material PFHPGDKJCCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class LHPADLNOMAL : DILBMJNPGOC, OOJAHKPFMPN, ONCHABJKMJN, PPGIJKGLBKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	private Vector2 OMMPIHBJFIJ;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public virtual Texture FBDIBKIKOPF
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xA051BA0", Offset = "0xA0501A0", VA = "0x18A051BA0", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public virtual int GBFPIGCHFKO
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public virtual Vector2 MEOKMOKBFOK
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xA051D30", Offset = "0xA050330", VA = "0x18A051D30", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public virtual double OEACGHPBFAI
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public virtual Vector2 KODGAIGNPAB
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0xA051B10", Offset = "0xA050110", VA = "0x18A051B10", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public virtual int MMBLDKBFMII
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "82")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public virtual Color GDMHJLEIDOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xA051E40", Offset = "0xA050440", VA = "0x18A051E40", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public virtual Texture CFEMFGAJOPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xA051DF0", Offset = "0xA0503F0", VA = "0x18A051DF0", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public virtual int PNCHJCPBNBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public virtual Vector2 HBFGPCADOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "86")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public virtual double OBHAOCHNIJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual Vector2 MLECLGEMCLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "88")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public virtual int MPOLEGPOCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public virtual double AIDGPBNAGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xA051DA0", Offset = "0xA0503A0", VA = "0x18A051DA0", Slot = "90")]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xA051EB0", Offset = "0xA0504B0", VA = "0x18A051EB0", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public virtual double IKCDCHDAPAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "92")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0xA0484D0", Offset = "0xA046AD0", VA = "0x18A0484D0")]
	protected LHPADLNOMAL(string JGKMDNFNPPN, string KPDLNLHIOLG, int NOCFLPDBBAL = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0xA051F10", Offset = "0xA050510", VA = "0x18A051F10")]
	protected LHPADLNOMAL(Material GKBAKEEHEPP, int NOCFLPDBBAL = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0xA051C00", Offset = "0xA050200", VA = "0x18A051C00", Slot = "60")]
	public override PPGIJKGLBKD JGHKMFOJCLP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class PNFIMLILDOF : LHPADLNOMAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	private Vector2 EENEKOPLKHD;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override int MGPAJPBELFH
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override int DMMLAOGCPLB
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public override int LFAAFOIBKBB
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public override int GBFPIGCHFKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public override Texture CFEMFGAJOPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xA059D50", Offset = "0xA058350", VA = "0x18A059D50", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public override int PNCHJCPBNBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public override Vector2 HBFGPCADOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xA059B50", Offset = "0xA058150", VA = "0x18A059B50", Slot = "86")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public override double OBHAOCHNIJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public override Vector2 MLECLGEMCLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xA059AC0", Offset = "0xA0580C0", VA = "0x18A059AC0", Slot = "88")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public override int MPOLEGPOCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public override double IKCDCHDAPAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xA059CF0", Offset = "0xA0582F0", VA = "0x18A059CF0", Slot = "92")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0xA059DF0", Offset = "0xA0583F0", VA = "0x18A059DF0")]
	public PNFIMLILDOF(string JGKMDNFNPPN, int NOCFLPDBBAL = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0xA059DD0", Offset = "0xA0583D0", VA = "0x18A059DD0")]
	protected PNFIMLILDOF(Material GKBAKEEHEPP, int NOCFLPDBBAL = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0xA059BC0", Offset = "0xA0581C0", VA = "0x18A059BC0", Slot = "60")]
	public override PPGIJKGLBKD JGHKMFOJCLP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class HPBPPPDLFEN : NAINCKDDDAF, OOJAHKPFMPN, ONCHABJKMJN, PPGIJKGLBKD, HIFNDNADNJA, ODENNGGODCJ, GNHAEDJBBIL, NKFBANJCDJE, NDDJEAOAPMN, PFHJHNJNBDK, HMPPHFPDPBA, APHCIAKHOAN, EANIAFLNAIH
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public Texture KOMMGCPBCNK
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xA04D8C0", Offset = "0xA04BEC0", VA = "0x18A04D8C0", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xA04C8E0", Offset = "0xA04AEE0", VA = "0x18A04C8E0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int MGPAJPBELFH
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xA04C4B0", Offset = "0xA04AAB0", VA = "0x18A04C4B0", Slot = "39")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public double JLBPKEHDHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xA04D740", Offset = "0xA04BD40", VA = "0x18A04D740", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Vector2 MONNDEIGFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xA04CBE0", Offset = "0xA04B1E0", VA = "0x18A04CBE0", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public double POLFOKFPODF
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xA04C520", Offset = "0xA04AB20", VA = "0x18A04C520", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Vector2 CJCBBFDMKNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xA04C6A0", Offset = "0xA04ACA0", VA = "0x18A04C6A0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int HGGJPJFHPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xA04CFA0", Offset = "0xA04B5A0", VA = "0x18A04CFA0", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public Texture AJHGBKNBFDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xA04C5E0", Offset = "0xA04ABE0", VA = "0x18A04C5E0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public int DMMLAOGCPLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xA04DB50", Offset = "0xA04C150", VA = "0x18A04DB50", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public double FLBDOFLLFHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xA04BF60", Offset = "0xA04A560", VA = "0x18A04BF60", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public Vector2 BKEJNMMBCDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0xA04D500", Offset = "0xA04BB00", VA = "0x18A04D500", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public double HLIFABFEILC
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0xA04BFC0", Offset = "0xA04A5C0", VA = "0x18A04BFC0", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector2 DOHBJEDBICP
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xA04BD10", Offset = "0xA04A310", VA = "0x18A04BD10", Slot = "50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public int NPPPFEKGGCL
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xA04C320", Offset = "0xA04A920", VA = "0x18A04C320", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Texture GHNGIOCNMJC
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xA04BAC0", Offset = "0xA04A0C0", VA = "0x18A04BAC0", Slot = "52")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int LFAAFOIBKBB
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xA04DE10", Offset = "0xA04C410", VA = "0x18A04DE10", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Color KGGFFIAMPHB
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xA04BE90", Offset = "0xA04A490", VA = "0x18A04BE90", Slot = "54")]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xA04CCA0", Offset = "0xA04B2A0", VA = "0x18A04CCA0", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector2 AEOEGEANNOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xA04C0E0", Offset = "0xA04A6E0", VA = "0x18A04C0E0", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public double AHBFMEHBOAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xA04B880", Offset = "0xA049E80", VA = "0x18A04B880", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public Vector2 EPEHKEDDHIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xA04DA30", Offset = "0xA04C030", VA = "0x18A04DA30", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public int EAKIGGPECJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xA04D130", Offset = "0xA04B730", VA = "0x18A04D130", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Texture CFEMFGAJOPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0xA04D910", Offset = "0xA04BF10", VA = "0x18A04D910", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public int PNCHJCPBNBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0xA04C760", Offset = "0xA04AD60", VA = "0x18A04C760", Slot = "30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector2 HBFGPCADOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0xA04CDD0", Offset = "0xA04B3D0", VA = "0x18A04CDD0", Slot = "31")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public double OBHAOCHNIJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xA04BCB0", Offset = "0xA04A2B0", VA = "0x18A04BCB0", Slot = "32")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Vector2 MLECLGEMCLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xA04B940", Offset = "0xA049F40", VA = "0x18A04B940", Slot = "33")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public int MPOLEGPOCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xA04BA00", Offset = "0xA04A000", VA = "0x18A04BA00", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public double AIDGPBNAGLD
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xA04DDB0", Offset = "0xA04C3B0", VA = "0x18A04DDB0", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public double IKCDCHDAPAD
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xA04D560", Offset = "0xA04BB60", VA = "0x18A04D560", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public double PJJJNIPPLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0xA04BC50", Offset = "0xA04A250", VA = "0x18A04BC50", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public Texture FLDBHGGKFAO
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xA04D800", Offset = "0xA04BE00", VA = "0x18A04D800", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public double OHNEBIIGDBI
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xA04DCF0", Offset = "0xA04C2F0", VA = "0x18A04DCF0", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public Vector2 EJLIENNCFFH
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xA04BF00", Offset = "0xA04A500", VA = "0x18A04BF00", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Vector2 HENGNOLKMPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xA04C820", Offset = "0xA04AE20", VA = "0x18A04C820", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public int CCGADFFJGPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0xA04C260", Offset = "0xA04A860", VA = "0x18A04C260", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public double NFAHNLCGPOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xA04BA60", Offset = "0xA04A060", VA = "0x18A04BA60", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Color BMIEPKGKHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xA04DBC0", Offset = "0xA04C1C0", VA = "0x18A04DBC0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public double JLGGGILBNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xA04D200", Offset = "0xA04B800", VA = "0x18A04D200", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Texture AMIIMJBDDOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xA04CA60", Offset = "0xA04B060", VA = "0x18A04CA60", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public double FGNNHMDDLAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xA04D680", Offset = "0xA04BC80", VA = "0x18A04D680", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector2 IEFMNMNPHNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xA04DAF0", Offset = "0xA04C0F0", VA = "0x18A04DAF0", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Vector2 BILCKAJJLAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xA04D860", Offset = "0xA04BE60", VA = "0x18A04D860", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public int PNOKFEGEHGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xA04C1A0", Offset = "0xA04A7A0", VA = "0x18A04C1A0", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public double HBKMJOLCACF
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0xA04D9D0", Offset = "0xA04BFD0", VA = "0x18A04D9D0", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public double IPNNILAKHFK
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xA04B9A0", Offset = "0xA049FA0", VA = "0x18A04B9A0", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public double CFELNLOOFLE
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0xA04D970", Offset = "0xA04BF70", VA = "0x18A04D970", Slot = "76")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public double KAEMOBIPKAL
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xA04C390", Offset = "0xA04A990", VA = "0x18A04C390", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public double DFAFLNECJBK
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xA04BD70", Offset = "0xA04A370", VA = "0x18A04BD70", Slot = "78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public Texture MDILIICPMAK
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xA04C200", Offset = "0xA04A800", VA = "0x18A04C200", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public double EHIMEKOMNAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0xA04DD50", Offset = "0xA04C350", VA = "0x18A04DD50", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public Vector2 EGBBACIKENI
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xA04C700", Offset = "0xA04AD00", VA = "0x18A04C700", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public Vector2 CADDKHDBDIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0xA04D6E0", Offset = "0xA04BCE0", VA = "0x18A04D6E0", Slot = "82")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public int BJJCKCFOHCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xA04D0D0", Offset = "0xA04B6D0", VA = "0x18A04D0D0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public Texture OOCNFKPDDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xA04C450", Offset = "0xA04AA50", VA = "0x18A04C450", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public double FCAHAKFLHOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xA04C020", Offset = "0xA04A620", VA = "0x18A04C020", Slot = "86")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Vector2 BPGCBOKDGGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xA04C7C0", Offset = "0xA04ADC0", VA = "0x18A04C7C0", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public Vector2 NMEOAEFPGAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xA04CD10", Offset = "0xA04B310", VA = "0x18A04CD10", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public int ENHLNDBCPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0xA04B8E0", Offset = "0xA049EE0", VA = "0x18A04B8E0", Slot = "88")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public double HPPAHBHPFKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xA04DC30", Offset = "0xA04C230", VA = "0x18A04DC30", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public Texture KPBCAJCPDJE
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xA04D4A0", Offset = "0xA04BAA0", VA = "0x18A04D4A0", Slot = "90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public double EBHPALMBIHC
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA04CE30", Offset = "0xA04B430", VA = "0x18A04CE30", Slot = "92")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public Vector2 CBIODNGODAM
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xA04D620", Offset = "0xA04BC20", VA = "0x18A04D620", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public Vector2 DEMBKEFCOCH
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xA04D070", Offset = "0xA04B670", VA = "0x18A04D070", Slot = "93")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public int GCMADOGKAGO
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xA04C880", Offset = "0xA04AE80", VA = "0x18A04C880", Slot = "94")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Color JOFEHDBBLGG
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0xA04D190", Offset = "0xA04B790", VA = "0x18A04D190", Slot = "95")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Texture GNNECECNFEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xA04DA90", Offset = "0xA04C090", VA = "0x18A04DA90", Slot = "96")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public double HCFMKBJMCLH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xA04C640", Offset = "0xA04AC40", VA = "0x18A04C640", Slot = "98")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector2 JIHDNANIJKM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xA04B7C0", Offset = "0xA049DC0", VA = "0x18A04B7C0", Slot = "97")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector2 LBNFBDJDJHI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0xA04BE30", Offset = "0xA04A430", VA = "0x18A04BE30", Slot = "99")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public int JMKOKBKHPFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xA04CB20", Offset = "0xA04B120", VA = "0x18A04CB20", Slot = "100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public double NNLOEHNJNEG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xA04CA00", Offset = "0xA04B000", VA = "0x18A04CA00", Slot = "101")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Texture GCLFMOJKGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xA04B700", Offset = "0xA049D00", VA = "0x18A04B700", Slot = "102")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public double BDALKKKCBML
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xA04DC90", Offset = "0xA04C290", VA = "0x18A04DC90", Slot = "104")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector2 BELAIHIAOEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xA04D260", Offset = "0xA04B860", VA = "0x18A04D260", Slot = "103")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Vector2 LKEGKIBINBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xA04CAC0", Offset = "0xA04B0C0", VA = "0x18A04CAC0", Slot = "105")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public int HMCFLFLNHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xA04D3E0", Offset = "0xA04B9E0", VA = "0x18A04D3E0", Slot = "106")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public double GCDKEEANKHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xA04D320", Offset = "0xA04B920", VA = "0x18A04D320", Slot = "107")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public Texture BFGLNEJAGEB
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xA04D380", Offset = "0xA04B980", VA = "0x18A04D380", Slot = "108")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public double MEFLINOBLLE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xA04DE70", Offset = "0xA04C470", VA = "0x18A04DE70", Slot = "110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Vector2 INNFENOCLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0xA04BB20", Offset = "0xA04A120", VA = "0x18A04BB20", Slot = "109")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public Vector2 LLFBODIPEJO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0xA04CB80", Offset = "0xA04B180", VA = "0x18A04CB80", Slot = "111")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public int IEHPCJBMFMA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xA04D2C0", Offset = "0xA04B8C0", VA = "0x18A04D2C0", Slot = "112")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public float LANKINFDDJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xA04CD70", Offset = "0xA04B370", VA = "0x18A04CD70", Slot = "113")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public float EKKGNPHPIPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xA04C080", Offset = "0xA04A680", VA = "0x18A04C080", Slot = "114")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public Color FJBPIEMJNGP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xA04BB80", Offset = "0xA04A180", VA = "0x18A04BB80", Slot = "115")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public Texture KDJHKJCNPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xA04BBF0", Offset = "0xA04A1F0", VA = "0x18A04BBF0", Slot = "116")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public double ECMIGMBNJDP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xA04C140", Offset = "0xA04A740", VA = "0x18A04C140", Slot = "117")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public Vector2 HHJKFKEILKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xA04CC40", Offset = "0xA04B240", VA = "0x18A04CC40", Slot = "118")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public Vector2 LEKDPNOLHNO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xA04D440", Offset = "0xA04BA40", VA = "0x18A04D440", Slot = "119")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public int KPOMMCMPLHA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xA04DED0", Offset = "0xA04C4D0", VA = "0x18A04DED0", Slot = "120")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public Texture PMOEBIKIDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xA04B6A0", Offset = "0xA049CA0", VA = "0x18A04B6A0", Slot = "121")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public double BCMPOENGLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xA04C580", Offset = "0xA04AB80", VA = "0x18A04C580", Slot = "122")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public Vector2 INALDOGCGEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xA04BDD0", Offset = "0xA04A3D0", VA = "0x18A04BDD0", Slot = "123")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public Vector2 PCGOCFIDHEG
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xA04C3F0", Offset = "0xA04A9F0", VA = "0x18A04C3F0", Slot = "124")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public int LDMALDPMIGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0xA04D7A0", Offset = "0xA04BDA0", VA = "0x18A04D7A0", Slot = "125")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public double GLAELMHNJJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xA04D010", Offset = "0xA04B610", VA = "0x18A04D010", Slot = "131")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public double IKCNMKNOOCN
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xA04B760", Offset = "0xA049D60", VA = "0x18A04B760", Slot = "132")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Texture LJNHBHLDBBH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xA04C2C0", Offset = "0xA04A8C0", VA = "0x18A04C2C0", Slot = "126")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public double IFCDGFKCCFK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xA04C940", Offset = "0xA04AF40", VA = "0x18A04C940", Slot = "128")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector2 BJGELDCJHHI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0xA04D5C0", Offset = "0xA04BBC0", VA = "0x18A04D5C0", Slot = "127")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public Vector2 CGIEHCBGLCK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xA04C9A0", Offset = "0xA04AFA0", VA = "0x18A04C9A0", Slot = "129")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public int MCNGJAMDPKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xA04B820", Offset = "0xA049E20", VA = "0x18A04B820", Slot = "130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0xA04DFA0", Offset = "0xA04C5A0", VA = "0x18A04DFA0")]
	public HPBPPPDLFEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0xA04E030", Offset = "0xA04C630", VA = "0x18A04E030")]
	protected HPBPPPDLFEN(string JGKMDNFNPPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0xA04DF30", Offset = "0xA04C530", VA = "0x18A04DF30")]
	public HPBPPPDLFEN(Material BEAKBILFDLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0xA04CE90", Offset = "0xA04B490", VA = "0x18A04CE90", Slot = "10")]
	public override PPGIJKGLBKD JGHKMFOJCLP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class OCOKOBOJEME : DILBMJNPGOC, IKDGKNJHLFL, ONCHABJKMJN, PPGIJKGLBKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	private Vector2 NDOJLLEOJAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	private Vector2 DFMKHNCINFP;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public virtual Texture AOPGNGMHAPI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xA0593F0", Offset = "0xA0579F0", VA = "0x18A0593F0", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public virtual int MAACEANODBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public virtual Vector2 KBPAINKJDGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xA058FA0", Offset = "0xA0575A0", VA = "0x18A058FA0", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public virtual double HNELOHIPPCG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public virtual Vector2 GACAACKGOOC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xA059010", Offset = "0xA057610", VA = "0x18A059010", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public virtual int DEKGGEDLPPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "82")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public virtual Color OKHONJPAELN
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xA0590A0", Offset = "0xA0576A0", VA = "0x18A0590A0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public virtual Texture FHFNMNMCDLL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xA059340", Offset = "0xA057940", VA = "0x18A059340", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public virtual int BCOAGIHFOPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public virtual Vector2 CKOAFDAKNID
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xA0592D0", Offset = "0xA0578D0", VA = "0x18A0592D0", Slot = "86")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public virtual double CNFMBKODAIB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public virtual Vector2 BNHAKIHAFCI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xA059240", Offset = "0xA057840", VA = "0x18A059240", Slot = "88")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public virtual int DKCAOCGKFOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public virtual Vector3 HPPAHBHPFKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xA059450", Offset = "0xA057A50", VA = "0x18A059450", Slot = "90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public virtual double GGFAPPAHMPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xA058F10", Offset = "0xA057510", VA = "0x18A058F10", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0xA0594E0", Offset = "0xA057AE0", VA = "0x18A0594E0")]
	protected OCOKOBOJEME(string JGKMDNFNPPN, string KPDLNLHIOLG, int NOCFLPDBBAL = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0xA0454C0", Offset = "0xA043AC0", VA = "0x18A0454C0")]
	protected OCOKOBOJEME(Material GKBAKEEHEPP, int NOCFLPDBBAL = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0xA059110", Offset = "0xA057710", VA = "0x18A059110", Slot = "60")]
	public override PPGIJKGLBKD JGHKMFOJCLP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class CLKAKBJOFEI : OCOKOBOJEME
{
	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public override int MGPAJPBELFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public override int DMMLAOGCPLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public override int LFAAFOIBKBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public override int MAACEANODBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public override int BCOAGIHFOPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0xA0454E0", Offset = "0xA043AE0", VA = "0x18A0454E0")]
	public CLKAKBJOFEI(string JGKMDNFNPPN, int NOCFLPDBBAL = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0xA0454C0", Offset = "0xA043AC0", VA = "0x18A0454C0")]
	protected CLKAKBJOFEI(Material GKBAKEEHEPP, int NOCFLPDBBAL = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0xA045390", Offset = "0xA043990", VA = "0x18A045390", Slot = "60")]
	public override PPGIJKGLBKD JGHKMFOJCLP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class DILBMJNPGOC : ONCHABJKMJN, PPGIJKGLBKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	protected Material BKMHIMIHCLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private GDNANKPHMIN NHNAFOCJNMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private double NMIIKGMCJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private Vector2 AHJECHGBHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private Vector2 MMKLEHBBMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private Vector2 AHKAAKNGFFN;

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public Material GOHKLGDEHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public virtual Texture KOMMGCPBCNK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xA046C80", Offset = "0xA045280", VA = "0x18A046C80", Slot = "33")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xA046780", Offset = "0xA044D80", VA = "0x18A046780", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public virtual int MGPAJPBELFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public virtual Vector2 MONNDEIGFHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xA0468E0", Offset = "0xA044EE0", VA = "0x18A0468E0", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public virtual double POLFOKFPODF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public virtual Vector2 CJCBBFDMKNB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xA0466F0", Offset = "0xA044CF0", VA = "0x18A0466F0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public virtual int HGGJPJFHPMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "39")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public virtual double JLBPKEHDHJK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xA046BC0", Offset = "0xA0451C0", VA = "0x18A046BC0", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public virtual Texture AJHGBKNBFDO
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xA046630", Offset = "0xA044C30", VA = "0x18A046630", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public virtual int DMMLAOGCPLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public virtual Vector2 BKEJNMMBCDB
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xA046B50", Offset = "0xA045150", VA = "0x18A046B50", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public virtual double HLIFABFEILC
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public virtual Vector2 DOHBJEDBICP
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xA045F40", Offset = "0xA044540", VA = "0x18A045F40", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public virtual int NPPPFEKGGCL
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public virtual double FLBDOFLLFHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xA046070", Offset = "0xA044670", VA = "0x18A046070", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public virtual Texture GHNGIOCNMJC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xA045E60", Offset = "0xA044460", VA = "0x18A045E60", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public virtual int LFAAFOIBKBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public virtual Vector2 AEOEGEANNOK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xA046130", Offset = "0xA044730", VA = "0x18A046130", Slot = "50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public virtual double AHBFMEHBOAI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public virtual Vector2 EPEHKEDDHIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xA046CF0", Offset = "0xA0452F0", VA = "0x18A046CF0", Slot = "52")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public virtual int EAKIGGPECJO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public virtual Color KGGFFIAMPHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xA045FD0", Offset = "0xA0445D0", VA = "0x18A045FD0", Slot = "54")]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xA046950", Offset = "0xA044F50", VA = "0x18A046950", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public virtual GDNANKPHMIN ODLBPNOEBJD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xA0461A0", Offset = "0xA0447A0", VA = "0x18A0461A0", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public virtual double NBOIHMBGAPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xA046DF0", Offset = "0xA0453F0", VA = "0x18A046DF0", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public virtual bool HHFICGMFKNB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xA046D80", Offset = "0xA045380", VA = "0x18A046D80", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public virtual bool NJMAPGNJOCE
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xA046860", Offset = "0xA044E60", VA = "0x18A046860", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0xA046FA0", Offset = "0xA0455A0", VA = "0x18A046FA0")]
	protected DILBMJNPGOC(string JGKMDNFNPPN, string PLHNAHAEBJC, int NOCFLPDBBAL = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0xA046E80", Offset = "0xA045480", VA = "0x18A046E80")]
	protected DILBMJNPGOC(Material BEAKBILFDLK, int NOCFLPDBBAL = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0xA046A00", Offset = "0xA045000", VA = "0x18A046A00", Slot = "60")]
	public virtual PPGIJKGLBKD JGHKMFOJCLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0xA046AB0", Offset = "0xA0450B0", VA = "0x18A046AB0", Slot = "61")]
	protected virtual void JOENHKFEPHF(ONCHABJKMJN KGIGKNOAIOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface PPGIJKGLBKD
{
	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	Material GOHKLGDEHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	GDNANKPHMIN ODLBPNOEBJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	double NBOIHMBGAPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	bool HHFICGMFKNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	bool NJMAPGNJOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PPGIJKGLBKD JGHKMFOJCLP();
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface ONCHABJKMJN : PPGIJKGLBKD
{
	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	Texture KOMMGCPBCNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	int MGPAJPBELFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	double JLBPKEHDHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	Vector2 MONNDEIGFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	double POLFOKFPODF
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	Vector2 CJCBBFDMKNB
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	int HGGJPJFHPMM
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	Texture AJHGBKNBFDO
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	int DMMLAOGCPLB
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	double FLBDOFLLFHN
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	Vector2 BKEJNMMBCDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	double HLIFABFEILC
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(Slot = "12")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	Vector2 DOHBJEDBICP
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	int NPPPFEKGGCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	Texture GHNGIOCNMJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	int LFAAFOIBKBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(Slot = "16")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	Color KGGFFIAMPHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(Slot = "18")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	Vector2 AEOEGEANNOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	double AHBFMEHBOAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(Slot = "20")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	Vector2 EPEHKEDDHIO
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	int EAKIGGPECJO
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(Slot = "22")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface OOJAHKPFMPN : ONCHABJKMJN, PPGIJKGLBKD
{
	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	Texture FBDIBKIKOPF
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	int GBFPIGCHFKO
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	Vector2 MEOKMOKBFOK
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	double OEACGHPBFAI
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	Vector2 KODGAIGNPAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	int MMBLDKBFMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	Color GDMHJLEIDOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	Texture CFEMFGAJOPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	int PNCHJCPBNBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	Vector2 HBFGPCADOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	double OBHAOCHNIJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	Vector2 MLECLGEMCLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	int MPOLEGPOCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(Slot = "12")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	double AIDGPBNAGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	double IKCDCHDAPAD
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public interface HIFNDNADNJA : OOJAHKPFMPN, ONCHABJKMJN, PPGIJKGLBKD
{
	[Cpp2IlInjected.Token(Token = "0x17000119")]
	double PJJJNIPPLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	Texture FLDBHGGKFAO
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	Vector2 EJLIENNCFFH
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	double OHNEBIIGDBI
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	Vector2 HENGNOLKMPP
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	int CCGADFFJGPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	double NFAHNLCGPOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	Color BMIEPKGKHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public interface ODENNGGODCJ : OOJAHKPFMPN, ONCHABJKMJN, PPGIJKGLBKD
{
	[Cpp2IlInjected.Token(Token = "0x17000121")]
	double JLGGGILBNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	Texture AMIIMJBDDOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	Vector2 IEFMNMNPHNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	double FGNNHMDDLAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	Vector2 BILCKAJJLAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	int PNOKFEGEHGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public interface APHCIAKHOAN : OOJAHKPFMPN, ONCHABJKMJN, PPGIJKGLBKD
{
	[Cpp2IlInjected.Token(Token = "0x17000127")]
	float EKKGNPHPIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	Color FJBPIEMJNGP
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	Texture KDJHKJCNPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	double ECMIGMBNJDP
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	Vector2 HHJKFKEILKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	Vector2 LEKDPNOLHNO
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	int KPOMMCMPLHA
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	Texture PMOEBIKIDJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	double BCMPOENGLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	Vector2 INALDOGCGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	Vector2 PCGOCFIDHEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	int LDMALDPMIGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public interface HMPPHFPDPBA : ODENNGGODCJ, OOJAHKPFMPN, ONCHABJKMJN, PPGIJKGLBKD
{
	[Cpp2IlInjected.Token(Token = "0x17000133")]
	float LANKINFDDJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public interface GNHAEDJBBIL : OOJAHKPFMPN, ONCHABJKMJN, PPGIJKGLBKD
{
	[Cpp2IlInjected.Token(Token = "0x17000134")]
	double HBKMJOLCACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public interface NDDJEAOAPMN : OOJAHKPFMPN, ONCHABJKMJN, PPGIJKGLBKD
{
	[Cpp2IlInjected.Token(Token = "0x17000135")]
	double HPPAHBHPFKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	Texture KPBCAJCPDJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	Vector2 CBIODNGODAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	double EBHPALMBIHC
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	Vector2 DEMBKEFCOCH
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	int GCMADOGKAGO
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	Color JOFEHDBBLGG
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	Texture GNNECECNFEK
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	Vector2 JIHDNANIJKM
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	double HCFMKBJMCLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	Vector2 LBNFBDJDJHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	int JMKOKBKHPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public interface NKFBANJCDJE : OOJAHKPFMPN, ONCHABJKMJN, PPGIJKGLBKD
{
	[Cpp2IlInjected.Token(Token = "0x17000141")]
	double IPNNILAKHFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	double CFELNLOOFLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	double KAEMOBIPKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	double DFAFLNECJBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	Texture MDILIICPMAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	Vector2 EGBBACIKENI
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	double EHIMEKOMNAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	Vector2 CADDKHDBDIB
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	int BJJCKCFOHCK
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	Texture OOCNFKPDDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	Vector2 BPGCBOKDGGK
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	double FCAHAKFLHOF
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	Vector2 NMEOAEFPGAD
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	int ENHLNDBCPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public interface IKDGKNJHLFL : ONCHABJKMJN, PPGIJKGLBKD
{
	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	Texture AOPGNGMHAPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	int MAACEANODBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	Vector2 KBPAINKJDGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	double HNELOHIPPCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	Vector2 GACAACKGOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	int DEKGGEDLPPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	Color OKHONJPAELN
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	Texture FHFNMNMCDLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	int BCOAGIHFOPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	Vector2 CKOAFDAKNID
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	double CNFMBKODAIB
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	Vector2 BNHAKIHAFCI
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	int DKCAOCGKFOI
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	Vector3 HPPAHBHPFKG
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	double GGFAPPAHMPK
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public interface PFHJHNJNBDK : OOJAHKPFMPN, ONCHABJKMJN, PPGIJKGLBKD
{
	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	double NNLOEHNJNEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	Texture GCLFMOJKGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	Vector2 BELAIHIAOEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	double BDALKKKCBML
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	Vector2 LKEGKIBINBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	int HMCFLFLNHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	double GCDKEEANKHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	Texture BFGLNEJAGEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	Vector2 INNFENOCLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	double MEFLINOBLLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	Vector2 LLFBODIPEJO
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	int IEHPCJBMFMA
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public interface PCMEOKAEMIN
{
	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	Texture OCHOANNGCGD
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	Vector2 CELPCGNBNOF
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	double NPNGDGGAIBM
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	Vector2 FFHCIFFMGCB
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	int MNEMHBIGIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public interface EANIAFLNAIH
{
	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	Texture LJNHBHLDBBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	Vector2 BJGELDCJHHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	double IFCDGFKCCFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	Vector2 CGIEHCBGLCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	int MCNGJAMDPKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	double GLAELMHNJJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	double IKCNMKNOOCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public interface BFIAEMEEPNO : PPGIJKGLBKD
{
	[Cpp2IlInjected.Token(Token = "0x17000176")]
	Texture FBDIBKIKOPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	int GBFPIGCHFKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	Vector2 MEOKMOKBFOK
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	double OEACGHPBFAI
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	Vector2 KODGAIGNPAB
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	int MMBLDKBFMII
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	Color GDMHJLEIDOO
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class FECBHOGOLDJ : NAINCKDDDAF, BFIAEMEEPNO, PPGIJKGLBKD
{
	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0xA0486D0", Offset = "0xA046CD0", VA = "0x18A0486D0")]
	public FECBHOGOLDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0xA048660", Offset = "0xA046C60", VA = "0x18A048660")]
	protected FECBHOGOLDJ(string JGKMDNFNPPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0xA0485F0", Offset = "0xA046BF0", VA = "0x18A0485F0")]
	public FECBHOGOLDJ(Material BEAKBILFDLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0xA0484E0", Offset = "0xA046AE0", VA = "0x18A0484E0", Slot = "10")]
	public override PPGIJKGLBKD JGHKMFOJCLP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class EMBEPDNAMHO : DILBMJNPGOC, BFIAEMEEPNO, PPGIJKGLBKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private Vector2 OMMPIHBJFIJ;

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public Texture FBDIBKIKOPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xA048390", Offset = "0xA046990", VA = "0x18A048390", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public virtual int GBFPIGCHFKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	public virtual Vector2 MEOKMOKBFOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0xA0483F0", Offset = "0xA0469F0", VA = "0x18A0483F0", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	public virtual double OEACGHPBFAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	public virtual Vector2 KODGAIGNPAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xA048300", Offset = "0xA046900", VA = "0x18A048300", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	public virtual int MMBLDKBFMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	public virtual Color GDMHJLEIDOO
	{
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0xA048460", Offset = "0xA046A60", VA = "0x18A048460", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0xA0484D0", Offset = "0xA046AD0", VA = "0x18A0484D0")]
	public EMBEPDNAMHO(string JGKMDNFNPPN, string KPDLNLHIOLG, int NOCFLPDBBAL = 1000)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class MMLCKMOOMCB
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public delegate void CJDEDGLFIJN(BPMKIFEDFIC MPINLOKCOLG);

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public delegate void PJEHIFJKKLO(BMFHMJKAIMP MPINLOKCOLG);

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class BMFHMJKAIMP
	{
		[Cpp2IlInjected.Token(Token = "0x17000186")]
		private Bounds PBMCJPJCGKG
		{
			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x94CB220", Offset = "0x94C9820", VA = "0x1894CB220")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000187")]
		private ILJINGLACKB IJHEDGCAEOH
		{
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0xAA9ED0", Offset = "0xAA84D0", VA = "0x180AA9ED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000188")]
		private HHLPFANFNFB OFDJHEMJFHC
		{
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0xAB2A30", Offset = "0xAB1030", VA = "0x180AB2A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xA05A420", Offset = "0xA058A20", VA = "0x18A05A420")]
		internal BMFHMJKAIMP(Bounds BLBKOMIFPLD, ILJINGLACKB NPLAFPNKHGN, HHLPFANFNFB HMJMPFHGNOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class BPMKIFEDFIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		internal EPMIBHJIFEA.DNNLLECHELG PBEBFHPEAAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public float[] ODGINDDCKEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public object[] FFNODFMPDNC;

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xDF7730", Offset = "0xDF5D30", VA = "0x180DF7730")]
		internal BPMKIFEDFIC(EPMIBHJIFEA.DNNLLECHELG LBBNCAPFGPD, float[] HKBHFFANFFG, object[] LGMBOCEBOMM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	internal class EPMIBHJIFEA
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		internal class HFNICNEABLG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			public string JKLGGALPDGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			public Type PINAJEKEGDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			public Func<Transform, UnityEngine.Object> GIIONGKCEAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			public Func<Transform, UnityEngine.Object, EPMIBHJIFEA, object> KICLLNPACEC;

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x1125D70", Offset = "0x1124370", VA = "0x181125D70")]
			public HFNICNEABLG(string JKLGGALPDGD, Type PINAJEKEGDF, Func<Transform, UnityEngine.Object> GIIONGKCEAI, Func<Transform, UnityEngine.Object, EPMIBHJIFEA, object> KICLLNPACEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0xA05EF50", Offset = "0xA05D550", VA = "0x18A05EF50")]
			public object IICDLOAHOPJ(EPMIBHJIFEA CDDIADBJAOB)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000098")]
		internal class DNNLLECHELG
		{
			[Cpp2IlInjected.Token(Token = "0x2000099")]
			private class ICPNEGEDCMC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000376")]
				public double HBAPMMDKJDM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000377")]
				public object KOPHBHGIACG;

				[Cpp2IlInjected.Token(Token = "0x60003BA")]
				[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
				public ICPNEGEDCMC()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			private EPMIBHJIFEA LBBNCAPFGPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			private HFNICNEABLG BBFMBBGEKEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			private Dictionary<double, object> JDONDHOKKFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			private ICPNEGEDCMC MOPKMJCPCMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			private ICPNEGEDCMC FAGLEMIHDOB;

			[Cpp2IlInjected.Token(Token = "0x17000189")]
			public UnityEngine.Object KCDMCCLJDPL
			{
				[Cpp2IlInjected.Token(Token = "0x60003B4")]
				[Cpp2IlInjected.Address(RVA = "0xA05AA50", Offset = "0xA059050", VA = "0x18A05AA50")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700018A")]
			public string JKLGGALPDGD
			{
				[Cpp2IlInjected.Token(Token = "0x60003B5")]
				[Cpp2IlInjected.Address(RVA = "0x2A87B10", Offset = "0x2A86110", VA = "0x182A87B10")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700018B")]
			public float[] HKBHFFANFFG
			{
				[Cpp2IlInjected.Token(Token = "0x60003B6")]
				[Cpp2IlInjected.Address(RVA = "0xA05AA90", Offset = "0xA059090", VA = "0x18A05AA90")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700018C")]
			public object[] LGMBOCEBOMM
			{
				[Cpp2IlInjected.Token(Token = "0x60003B7")]
				[Cpp2IlInjected.Address(RVA = "0xA05AE50", Offset = "0xA059450", VA = "0x18A05AE50")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0xA05AEB0", Offset = "0xA0594B0", VA = "0x18A05AEB0")]
			public DNNLLECHELG(EPMIBHJIFEA LBBNCAPFGPD, HFNICNEABLG BBFMBBGEKEI, double HBAPMMDKJDM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0xA05AC00", Offset = "0xA059200", VA = "0x18A05AC00")]
			public void BJOCNOMMMCL(double HBAPMMDKJDM)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		internal Transform LBBNCAPFGPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private SkinnedMeshRenderer NNCHINPECMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private bool DJGHNPKJOHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private bool EFCMFDMGHLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private bool PFNMBKKIBDC;

		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private static List<HFNICNEABLG> CECOFDJICJM;

		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private static MaterialPropertyBlock MBMJCJMHIPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		internal List<DNNLLECHELG> CJDBCNMKIAD;

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xA05B500", Offset = "0xA059B00", VA = "0x18A05B500")]
		public EPMIBHJIFEA(Transform LBBNCAPFGPD, double HBAPMMDKJDM, bool HOPBNNAMBGD = false, bool DJGHNPKJOHG = true, bool EFCMFDMGHLF = false, bool PFNMBKKIBDC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xA05B350", Offset = "0xA059950", VA = "0x18A05B350")]
		public void FPGILMIKMIA(double HBAPMMDKJDM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	internal ICollection<Transform> OOMEDLONGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private Transform BOCNDANOLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private Dictionary<Transform, EPMIBHJIFEA> CDDIADBJAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private double FJOIBADLBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private double PNGAAOKBNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private bool FGLEJPAKOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	private bool KBCJKBEAGGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private readonly bool DJGHNPKJOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	private readonly bool AGICDDOOCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private readonly bool PFNMBKKIBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public string HNIKOFINIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public CJDEDGLFIJN PINFNMLCHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public PJEHIFJKKLO HHHEJEPMBFH;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	private static ProfilerMarker KPIANAPJBNP;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private static ProfilerMarker FDPBJIELOJD;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private static ProfilerMarker FKOIIECDKPA;

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	public bool MEEFOJEDNLM
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x15C0AB0", Offset = "0x15BF0B0", VA = "0x1815C0AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	public double INLHFOFLOGI
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x7805F50", Offset = "0x7804550", VA = "0x187805F50")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0xA054E70", Offset = "0xA053470", VA = "0x18A054E70")]
	public MMLCKMOOMCB(Transform BOCNDANOLJJ, bool DJGHNPKJOHG = true, bool AGICDDOOCMI = false, bool PFNMBKKIBDC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0xA054CC0", Offset = "0xA0532C0", VA = "0x18A054CC0")]
	private bool OGJELINGMPP(Transform LBBNCAPFGPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0xA053A50", Offset = "0xA052050", VA = "0x18A053A50")]
	public void FFHMCPLHHPH(double HBAPMMDKJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0xA0549D0", Offset = "0xA052FD0", VA = "0x18A0549D0")]
	public void NEBGLELDBDL(double HBAPMMDKJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0xA053E40", Offset = "0xA052440", VA = "0x18A053E40")]
	public void MEFGHOLLFBI(string GDCFOAHKBOL, string DPEHEEBEAND = "scene", [Optional] GLTFSettings CJEINKGIPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0xA053FC0", Offset = "0xA0525C0", VA = "0x18A053FC0")]
	public void MEFGHOLLFBI(Stream ICLFABGEPJB, string DPEHEEBEAND = "scene", [Optional] GLTFSettings CJEINKGIPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0xA053C90", Offset = "0xA052290", VA = "0x18A053C90")]
	private void GFCJMBPIPBG(ILJINGLACKB NPLAFPNKHGN, HHLPFANFNFB HMJMPFHGNOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0xA0534F0", Offset = "0xA051AF0", VA = "0x18A0534F0")]
	private void BMNGKLHLDIE(ILJINGLACKB AEDCJJMFOCE, FHGFGFEMDFE NFJLHNFNPGG, bool KBEPDNOLPFJ, [Out] Bounds JMPEPFFHOOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public class FDCNGNPBKOA : PlayableBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	private sealed class IIKJDGHCLHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public FDCNGNPBKOA <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public IIKJDGHCLHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0xA061D70", Offset = "0xA060370", VA = "0x18A061D70")]
		internal void DIBIJIMAKEL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400038A")]
	private MMLCKMOOMCB EMCCOBPOANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public GLTFRecorderClip MNLOIKOJJHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400038C")]
	private bool PKPKJMNOJHC;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0xA05CBD0", Offset = "0xA05B1D0", VA = "0x18A05CBD0")]
	private void FOEBIJDEBMB(double OAHHIOINFAK, Transform GBCPDNJELBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0xA05CA40", Offset = "0xA05B040", VA = "0x18A05CA40")]
	private void BINOJOBDGDD(double OAHHIOINFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0xA05CAA0", Offset = "0xA05B0A0", VA = "0x18A05CAA0")]
	private void EHDCPMLJNHG(double OAHHIOINFAK, Transform GBCPDNJELBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50")]
	private static bool FFCNCFEIINJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0xA05CED0", Offset = "0xA05B4D0", VA = "0x18A05CED0", Slot = "16")]
	public override void OnPlayableDestroy(Playable GBAIKHBMJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0xA05CCA0", Offset = "0xA05B2A0", VA = "0x18A05CCA0", Slot = "13")]
	public override void OnGraphStart(Playable GBAIKHBMJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0xA05CE30", Offset = "0xA05B430", VA = "0x18A05CE30", Slot = "14")]
	public override void OnGraphStop(Playable GBAIKHBMJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0xA05CF70", Offset = "0xA05B570", VA = "0x18A05CF70", Slot = "20")]
	public override void ProcessFrame(Playable GBAIKHBMJBK, FrameData PCLIBIJEFPO, object HPAABCEOCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x18D46F0", Offset = "0x18D2CF0", VA = "0x1818D46F0", Slot = "17")]
	public override void OnBehaviourPlay(Playable GBAIKHBMJBK, FrameData PCLIBIJEFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0xD7DFD0", Offset = "0xD7C5D0", VA = "0x180D7DFD0", Slot = "18")]
	public override void OnBehaviourPause(Playable GBAIKHBMJBK, FrameData PCLIBIJEFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0xA05C810", Offset = "0xA05AE10", VA = "0x18A05C810")]
	public void BBLBHLPPJOH(double HBAPMMDKJDM, Playable GBAIKHBMJBK, FrameData PCLIBIJEFPO, object HPAABCEOCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
	public FDCNGNPBKOA()
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

		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		public ClipCaps clipCaps
		{
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0xB28EF0", Offset = "0xB274F0", VA = "0x180B28EF0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(ClipCaps);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0xA05E350", Offset = "0xA05C950", VA = "0x18A05E350", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph HEKJGPKFKAD, GameObject PCLFJGMAHBI)
		{
			return default(Playable);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xA05E460", Offset = "0xA05CA60", VA = "0x18A05E460")]
		public Transform LCDCIJPNICA(PlayableGraph HEKJGPKFKAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xA05E4C0", Offset = "0xA05CAC0", VA = "0x18A05E4C0")]
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
		private sealed class CMILNMHIDAP : IEnumerator<object>, IEnumerator, IDisposable
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

			[Cpp2IlInjected.Token(Token = "0x1700018E")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003EA")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700018F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003EC")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
			[DebuggerHidden]
			public CMILNMHIDAP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0xA05A490", Offset = "0xA058A90", VA = "0x18A05A490", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0xA05A6D0", Offset = "0xA058CD0", VA = "0x18A05A6D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private List<Action> LNCEJPODMLG;

		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private static GLTFRecorderHelper MHKMPBAHOMB;

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xA05E550", Offset = "0xA05CB50", VA = "0x18A05E550")]
		public static void Add(Action LAOAAOBGDLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0xA05E7B0", Offset = "0xA05CDB0", VA = "0x18A05E7B0")]
		private static GLTFRecorderHelper JMJIMHLJHEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0xA05E730", Offset = "0xA05CD30", VA = "0x18A05E730")]
		[IteratorStateMachine(typeof(CMILNMHIDAP))]
		private IEnumerator CLAOEKMFNEE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0xA05E950", Offset = "0xA05CF50", VA = "0x18A05E950")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0xA05E9D0", Offset = "0xA05CFD0", VA = "0x18A05E9D0")]
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
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0xA05EA60", Offset = "0xA05D060", VA = "0x18A05EA60")]
		public GLTFRecorderTrack()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
internal static class NOCEGNBKGPI
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class EDLLPGCBPMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public int primaryComponentCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public MPBEKNAAPNE propertyMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public DGIBBMBELKH pointerDataCopy;

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public EDLLPGCBPMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xA05B1A0", Offset = "0xA0597A0", VA = "0x18A05B1A0")]
		internal float[] MCCAPKENBPB(DGIBBMBELKH data, int frame)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xA05B2C0", Offset = "0xA0598C0", VA = "0x18A05B2C0")]
		internal float[] OEMOOJBEKGK(DGIBBMBELKH data, int frame)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xA05B110", Offset = "0xA059710", VA = "0x18A05B110")]
		internal float[] CDGDHHDPPPO(DGIBBMBELKH data, int frame)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0xA05B230", Offset = "0xA059830", VA = "0x18A05B230")]
		internal float[] NOKGBHBPNFP(DGIBBMBELKH data, int frame)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	private static readonly string[] MADDFMFFGKG;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	private static readonly string[] EJBHCPJJAMI;

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0xA064900", Offset = "0xA062F00", VA = "0x18A064900")]
	internal static bool PCBMIOKOEIH(string LCIKDDMADBH, GKOBMLJBPPE NBLLMKFPHJK, Material PFHPGDKJCCC, string MHIFBDKGPKO, INLJELLPHNA JFEJDFEEGND, [Out] DGIBBMBELKH ADELLNMAPKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0xA064660", Offset = "0xA062C60", VA = "0x18A064660")]
	internal static string[] MIOKFMJEBOK(string JKLGGALPDGD, int NOPKBIBODNH, int MHCNCJIELEC = 0, bool PAIFPIHPIPI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0xA064070", Offset = "0xA062670", VA = "0x18A064070")]
	internal static float[] LKGCELDLFNJ(int PMIGBJGNLLP, int NOPKBIBODNH, MPBEKNAAPNE PLDHKFPNKBN, DGIBBMBELKH ADELLNMAPKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class MPBEKNAAPNE
{
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public enum MNGPPPKJFFG
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
	public enum MPEKDJACABG
	{
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		SameAsPrimary,
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		Override
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public delegate float[] DCADCEEOKNE(float[] NOONPPBNDPD, float[] AEJNNBJJIGB, int JMMFIMJBHDC);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public MNGPPPKJFFG CBPEGPFKLHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public string AKKJFAPDEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public string JAFMFGICHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public bool LBAHBJGGALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public MPEKDJACABG JFLOFODONPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public MAFMALOADCG EOCHBHCKIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public bool MNJICPDNAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public bool KHILHIIMLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x36")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public bool KEDDLODMKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public float OHDFJBFPEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public string GGBCCOKEDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public DCADCEEOKNE DNNHBHNPJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private string[] BMOOCPILEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	internal int[] DKFMDCNCPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	internal int[] FHHCCCGKMNK;

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	public string[] DCPLKDPCJFM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xAA5710", Offset = "0xAA3D10", VA = "0x180AA5710")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xA063700", Offset = "0xA061D00", VA = "0x18A063700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	public bool EBLCLCBKGAL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0xA063880", Offset = "0xA061E80", VA = "0x18A063880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0xA063AE0", Offset = "0xA0620E0", VA = "0x18A063AE0")]
	public MPBEKNAAPNE(MNGPPPKJFFG OCIIABCKJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0xA063940", Offset = "0xA061F40", VA = "0x18A063940")]
	private void MAKBKICMABM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0xA063730", Offset = "0xA061D30", VA = "0x18A063730")]
	private static float[] BOLJNHKDJKI(float[] NOONPPBNDPD, float[] AEJNNBJJIGB, int JMMFIMJBHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0xA0638A0", Offset = "0xA061EA0", VA = "0x18A0638A0")]
	private void HAHEPIFHPNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class GKOBMLJBPPE
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public enum CJGDMEMFFIC
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
	private Dictionary<string, MPBEKNAAPNE> HBLFKAJBPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	private Dictionary<string, MPBEKNAAPNE> MCEKKDEDOHJ;

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0xA05D390", Offset = "0xA05B990", VA = "0x18A05D390")]
	public void ADBAHCJMHOH(string MGCPOOJNMKC, string[] GAMCNJKIJEN, [Optional] string BEFEDMIPOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0xA05E050", Offset = "0xA05C650", VA = "0x18A05E050")]
	public void JJMDELOGFNF(MPBEKNAAPNE PLDHKFPNKBN, CJGDMEMFFIC AIEBPKAECBH = CJGDMEMFFIC.ImportAndExport)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0xA05DA60", Offset = "0xA05C060", VA = "0x18A05DA60")]
	public bool BDFKHIKBKOK(Material BEAKBILFDLK, string EJGOEAJOODM, [Out] MPBEKNAAPNE PLDHKFPNKBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0xA05DC80", Offset = "0xA05C280", VA = "0x18A05DC80")]
	public bool DOCLLAIJMPO(Material BEAKBILFDLK, string LNIEJHDBFPD, [Out] string JKLGGALPDGD, [Out] MPBEKNAAPNE PLDHKFPNKBN, [Out] bool NOBEAGJDHNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0xA05E270", Offset = "0xA05C870", VA = "0x18A05E270")]
	public GKOBMLJBPPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public class PJCJKIEGKKP : GKOBMLJBPPE
{
	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0xA065B60", Offset = "0xA064160", VA = "0x18A065B60")]
	public PJCJKIEGKKP()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public class AnimationPointerExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000192")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0xA05A260", Offset = "0xA058860", VA = "0x18A05A260", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000193")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0xA05A230", Offset = "0xA058830", VA = "0x18A05A230", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0xA05A180", Offset = "0xA058780", VA = "0x18A05A180", Slot = "14")]
		public override LEPJFGIFCMO CHPLBBCBBMN(CCLFPBBKELG JIFPJFGEAIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x1611790", Offset = "0x160FD90", VA = "0x181611790")]
		public AnimationPointerExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public class BCDKLMMBFCD : LEPJFGIFCMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public GKOBMLJBPPE JEGFCEHCJHB;

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0xA05A3A0", Offset = "0xA0589A0", VA = "0x18A05A3A0")]
	public BCDKLMMBFCD()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public class AnimationPointerImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000195")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0xA05A370", Offset = "0xA058970", VA = "0x18A05A370", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000196")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0xA05A340", Offset = "0xA058940", VA = "0x18A05A340", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0xA05A290", Offset = "0xA058890", VA = "0x18A05A290", Slot = "13")]
		public override CMDLLNAPBAF CHPLBBCBBMN(HOLINFLNHMO JIFPJFGEAIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x1611790", Offset = "0x160FD90", VA = "0x181611790")]
		public AnimationPointerImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class KMFGAABCMIN : CMDLLNAPBAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public GKOBMLJBPPE JEGFCEHCJHB;

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0xA0625E0", Offset = "0xA060BE0", VA = "0x18A0625E0")]
	public KMFGAABCMIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[AttributeUsage(AttributeTargets.Class)]
public class FPLFCAKGIHI : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public string PFFNJAFFEAK;

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0xAD1900", Offset = "0xACFF00", VA = "0x180AD1900")]
	public FPLFCAKGIHI([Optional] string PFFNJAFFEAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[AttributeUsage(AttributeTargets.Class)]
public class HEAEBJGIEHF : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public string PFFNJAFFEAK;

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0xAD1900", Offset = "0xACFF00", VA = "0x180AD1900")]
	public HEAEBJGIEHF([Optional] string PFFNJAFFEAK)
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public abstract class GLTFExportPlugin : GLTFPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000197")]
		public virtual JToken AssetExtras
		{
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(Slot = "14")]
		public abstract LEPJFGIFCMO CHPLBBCBBMN(CCLFPBBKELG JIFPJFGEAIK);

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x1611790", Offset = "0x160FD90", VA = "0x181611790")]
		protected GLTFExportPlugin()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public abstract class LEPJFGIFCMO
{
	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "4")]
	public virtual void JHALPCHCADC(ILJINGLACKB NPLAFPNKHGN, HHLPFANFNFB HMJMPFHGNOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
	public virtual void BKPGHCMBJOK(ILJINGLACKB NPLAFPNKHGN, HHLPFANFNFB HMJMPFHGNOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "6")]
	public virtual bool CNNDNOJJFAA(ILJINGLACKB NPLAFPNKHGN, HHLPFANFNFB HMJMPFHGNOJ, Transform CCHLCEHOKAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "7")]
	public virtual void EDODCLDHCOF(ILJINGLACKB NPLAFPNKHGN, HHLPFANFNFB HMJMPFHGNOJ, Transform CCHLCEHOKAD, EPNFLCKAFCM EMOGDLPNEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "8")]
	public virtual void ALPMPEPJCPP(ILJINGLACKB NPLAFPNKHGN, HHLPFANFNFB HMJMPFHGNOJ, Transform CCHLCEHOKAD, EPNFLCKAFCM EMOGDLPNEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "9")]
	public virtual bool AMGHOCJJIEC(ILJINGLACKB NPLAFPNKHGN, HHLPFANFNFB HMJMPFHGNOJ, Material PFHPGDKJCCC, LPKIABJLDGD CCPAGGJAIBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "10")]
	public virtual void EHIGLHLIDEP(ILJINGLACKB NPLAFPNKHGN, HHLPFANFNFB HMJMPFHGNOJ, Material PFHPGDKJCCC, LPKIABJLDGD CCPAGGJAIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "11")]
	public virtual void LDALDFPDJJJ(ILJINGLACKB NPLAFPNKHGN, ILJINGLACKB.NCHFDCDPKHB BDFJHOHMCFM, string EBECMHBHDHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "12")]
	public virtual void PLBLHFLCODF(ILJINGLACKB NPLAFPNKHGN, ILJINGLACKB.NCHFDCDPKHB BDFJHOHMCFM, int PMIGBJGNLLP, BOOEFBPDPHN OJHEPEGBMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "13")]
	public virtual void IKELJLDKCIJ(ILJINGLACKB NPLAFPNKHGN, Mesh KNHPHEPPGOL, PLLBMPLNJGP EBFGEDGGNBO, int PMIGBJGNLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "14")]
	public virtual void OEBKIFODIDL(ILJINGLACKB NPLAFPNKHGN, Mesh KNHPHEPPGOL, HBAJBPALING JJHNBBAHFKM, int PMIGBJGNLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	protected LEPJFGIFCMO()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public abstract class GLTFImportPlugin : GLTFPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(Slot = "13")]
		public abstract CMDLLNAPBAF CHPLBBCBBMN(HOLINFLNHMO JIFPJFGEAIK);

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x1611790", Offset = "0x160FD90", VA = "0x181611790")]
		protected GLTFImportPlugin()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public abstract class CMDLLNAPBAF
{
	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "4")]
	public virtual void JHIAHHEDHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
	public virtual void AKFMCDKOMKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "6")]
	public virtual void KDIOACKDNLH(HHLPFANFNFB HMJMPFHGNOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "7")]
	public virtual void DGLDBFBOMKG(ECGPILHJDAN BLFJNFOGIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "8")]
	public virtual void BIIMPHGJCML(EPNFLCKAFCM EMOGDLPNEGA, int EGKCHCJOJAH, GameObject LAHGCGOJCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "9")]
	public virtual void BCCGIJDBONM(LPKIABJLDGD PFHPGDKJCCC, int JJCENJEBMDL, Material IBNEDGFBDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "10")]
	public virtual void PBIOIAHJPLA(BOOEFBPDPHN BDFJHOHMCFM, int OBCPINMCNPD, Texture MELNOEJOIBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "11")]
	public virtual void EHJPCKPNGIM(ECGPILHJDAN BLFJNFOGIPN, int FMKCJNDALPC, GameObject DKDHLDHNOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	protected CMDLLNAPBAF()
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

		[Cpp2IlInjected.Token(Token = "0x17000198")]
		public abstract string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		public virtual string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		public virtual string HelpUrl
		{
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		public virtual bool Enabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0xA05E330", Offset = "0xA05C930", VA = "0x18A05E330", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0xAB4E30", Offset = "0xAB3430", VA = "0x180AB4E30", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		public virtual bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019D")]
		public virtual bool AlwaysEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		public virtual string Warning
		{
			[Cpp2IlInjected.Token(Token = "0x6000437")]
			[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		public virtual bool PackageMissing
		{
			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x1611790", Offset = "0x160FD90", VA = "0x181611790")]
		protected GLTFPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[Obsolete("Use UnityGLTF.Plugins.GLTFPlugin instead. (UnityUpgradable) -> UnityGLTF.Plugins.GLTFPlugin")]
	public abstract class GltfPlugin : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0xD5F7D0", Offset = "0xD5DDD0", VA = "0x180D5F7D0")]
		protected GltfPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[Obsolete("Use UnityGLTF.Plugins.GLTFImportPlugin instead. (UnityUpgradable) -> UnityGLTF.Plugins.GLTFImportPlugin")]
	public abstract class GltfImportPlugin : GltfPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0xD5F7D0", Offset = "0xD5DDD0", VA = "0x180D5F7D0")]
		protected GltfImportPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[Obsolete("Use UnityGLTF.Plugins.GLTFExportPlugin instead. (UnityUpgradable) -> UnityGLTF.Plugins.GLTFExportPlugin")]
	public abstract class GltfExportPlugin : GltfPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0xD5F7D0", Offset = "0xD5DDD0", VA = "0x180D5F7D0")]
		protected GltfExportPlugin()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public class HOLINFLNHMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public readonly List<CMDLLNAPBAF> AMAANKGCHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public COOKOPJMGEL IOODIJBCPAP;

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	public HHLPFANFNFB HMJJONKLDKG
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0xA061AF0", Offset = "0xA0600F0", VA = "0x18A061AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0xA061B10", Offset = "0xA060110", VA = "0x18A061B10")]
	private List<CMDLLNAPBAF> JNHKAMFFEGP(GLTFSettings CJEINKGIPEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0xA061D30", Offset = "0xA060330", VA = "0x18A061D30")]
	internal HOLINFLNHMO(GLTFSettings CJEINKGIPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x3DF76B0", Offset = "0x3DF5CB0", VA = "0x183DF76B0")]
	public bool DJBMAIJLEKI<T>([Out] T KGIGKNOAIOJ) where T : CMDLLNAPBAF
	{
		return default(bool);
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public class DracoImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001A1")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0xA05B0E0", Offset = "0xA0596E0", VA = "0x18A05B0E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A2")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0xA05B0B0", Offset = "0xA0596B0", VA = "0x18A05B0B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A3")]
		public override bool PackageMissing
		{
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0xA05B060", Offset = "0xA059660", VA = "0x18A05B060", Slot = "13")]
		public override CMDLLNAPBAF CHPLBBCBBMN(HOLINFLNHMO JIFPJFGEAIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x1611790", Offset = "0x160FD90", VA = "0x181611790")]
		public DracoImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public class HHDNLCEOKKN : CMDLLNAPBAF
{
	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public HHDNLCEOKKN()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public class GPUInstancingImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001A4")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0xA05EB30", Offset = "0xA05D130", VA = "0x18A05EB30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A5")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(RVA = "0xA05EB00", Offset = "0xA05D100", VA = "0x18A05EB00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0xA05EAB0", Offset = "0xA05D0B0", VA = "0x18A05EAB0", Slot = "13")]
		public override CMDLLNAPBAF CHPLBBCBBMN(HOLINFLNHMO JIFPJFGEAIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x1611790", Offset = "0x160FD90", VA = "0x181611790")]
		public GPUInstancingImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public class FECHGEDKHDO : CMDLLNAPBAF
{
	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public FECHGEDKHDO()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public class Ktx2Import : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001A6")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0xA062740", Offset = "0xA060D40", VA = "0x18A062740", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A7")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0xA062710", Offset = "0xA060D10", VA = "0x18A062710", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A8")]
		public override bool PackageMissing
		{
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0xA0626C0", Offset = "0xA060CC0", VA = "0x18A0626C0", Slot = "13")]
		public override CMDLLNAPBAF CHPLBBCBBMN(HOLINFLNHMO JIFPJFGEAIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x1611790", Offset = "0x160FD90", VA = "0x181611790")]
		public Ktx2Import()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public class CJEFAHMHEHK : CMDLLNAPBAF
{
	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public CJEFAHMHEHK()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public class LightsPunctualExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001A9")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0xA0634C0", Offset = "0xA061AC0", VA = "0x18A0634C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0xA063490", Offset = "0xA061A90", VA = "0x18A063490", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0xA063440", Offset = "0xA061A40", VA = "0x18A063440", Slot = "14")]
		public override LEPJFGIFCMO CHPLBBCBBMN(CCLFPBBKELG JIFPJFGEAIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x1611790", Offset = "0x160FD90", VA = "0x181611790")]
		public LightsPunctualExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public class MFDGCOKOLNP : LEPJFGIFCMO
{
	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "8")]
	public override void ALPMPEPJCPP(ILJINGLACKB NPLAFPNKHGN, HHLPFANFNFB HMJMPFHGNOJ, Transform CCHLCEHOKAD, EPNFLCKAFCM EMOGDLPNEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public MFDGCOKOLNP()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public class LightsPunctualImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xA063570", Offset = "0xA061B70", VA = "0x18A063570", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xA063540", Offset = "0xA061B40", VA = "0x18A063540", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0xA0634F0", Offset = "0xA061AF0", VA = "0x18A0634F0", Slot = "13")]
		public override CMDLLNAPBAF CHPLBBCBBMN(HOLINFLNHMO JIFPJFGEAIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x1611790", Offset = "0x160FD90", VA = "0x181611790")]
		public LightsPunctualImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public class FCKOLJEMLFG : CMDLLNAPBAF
{
	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public FCKOLJEMLFG()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[FPLFCAKGIHI(null)]
	public class LodsExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0xA063620", Offset = "0xA061C20", VA = "0x18A063620", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0xA0635F0", Offset = "0xA061BF0", VA = "0x18A0635F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0xA0635A0", Offset = "0xA061BA0", VA = "0x18A0635A0", Slot = "14")]
		public override LEPJFGIFCMO CHPLBBCBBMN(CCLFPBBKELG JIFPJFGEAIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x1611790", Offset = "0x160FD90", VA = "0x181611790")]
		public LodsExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public class FACEANBAEGB : LEPJFGIFCMO
{
	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0xA05C400", Offset = "0xA05AA00", VA = "0x18A05C400", Slot = "8")]
	public override void ALPMPEPJCPP(ILJINGLACKB NPLAFPNKHGN, HHLPFANFNFB HMAECAIJJCI, Transform CCHLCEHOKAD, EPNFLCKAFCM EMOGDLPNEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public FACEANBAEGB()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[FPLFCAKGIHI(null)]
	public class LodsImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0xA0636D0", Offset = "0xA061CD0", VA = "0x18A0636D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0xA0636A0", Offset = "0xA061CA0", VA = "0x18A0636A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0xA063650", Offset = "0xA061C50", VA = "0x18A063650", Slot = "13")]
		public override CMDLLNAPBAF CHPLBBCBBMN(HOLINFLNHMO JIFPJFGEAIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x1611790", Offset = "0x160FD90", VA = "0x181611790")]
		public LodsImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public class ECEALAFLABL : CMDLLNAPBAF
{
	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public ECEALAFLABL()
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

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0xA063D70", Offset = "0xA062370", VA = "0x18A063D70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0xA063D40", Offset = "0xA062340", VA = "0x18A063D40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0xA063CB0", Offset = "0xA0622B0", VA = "0x18A063CB0", Slot = "14")]
		public override LEPJFGIFCMO CHPLBBCBBMN(CCLFPBBKELG JIFPJFGEAIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0xA063D20", Offset = "0xA062320", VA = "0x18A063D20")]
		public MaterialExtensionsExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public class HKNJAMLHNPI : LEPJFGIFCMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	internal readonly MaterialExtensionsExport CJEINKGIPEA;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private static readonly int CMMPCGNKDIN;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private static readonly int DPLPPPIICKJ;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private static readonly int BGJIMHFBJEG;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	private static readonly int AHPNIENIKMK;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	private static readonly int PHMEEIFJOBH;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	private static readonly int LDMHDPIDDJB;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	private static readonly int HMJGKNIIABL;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	private static readonly int AFEOMJGCFHP;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	private static readonly int NLBGPCCJPNK;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	private static readonly int PCLABCHFDPM;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	private static readonly int PKMPOOJMIGB;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	private static readonly int KPFFDBAHDDD;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	private static readonly int AHGLBAPBJNC;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	private static readonly int CJCDJIKGBJG;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	private static readonly int HBJLDPHHKBK;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	private static readonly int JNEOAHNAHLM;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	private static readonly int LJOCIOBJKFN;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	private static readonly int APGBABCNJMP;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	private static readonly int DDCHOBINPGG;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	private static readonly int JGNEBMIPJNG;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	private static readonly int IHEJCJNJJFC;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	private static readonly int PEEIBOKBOFC;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	private static readonly int ICOPECOAKLI;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	private static readonly int AMFOFPJLFHM;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	private static readonly int BPANKCLGCGO;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	private static readonly int HMEHEPAJDIA;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	private static readonly int JDAPNIMMJMO;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	private static readonly int GLAELMHNJJI;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	private static readonly int IKCNMKNOOCN;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	private static readonly int LJNHBHLDBBH;

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0xAB22B0", Offset = "0xAB08B0", VA = "0x180AB22B0")]
	public HKNJAMLHNPI(MaterialExtensionsExport CJEINKGIPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0xA05EFC0", Offset = "0xA05D5C0", VA = "0x18A05EFC0", Slot = "10")]
	public override void EHIGLHLIDEP(ILJINGLACKB NPLAFPNKHGN, HHLPFANFNFB HMAECAIJJCI, Material PFHPGDKJCCC, LPKIABJLDGD GLPEFLOLIDC)
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

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0xA063E60", Offset = "0xA062460", VA = "0x18A063E60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0xA063E30", Offset = "0xA062430", VA = "0x18A063E30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0xA063DA0", Offset = "0xA0623A0", VA = "0x18A063DA0", Slot = "13")]
		public override CMDLLNAPBAF CHPLBBCBBMN(HOLINFLNHMO JIFPJFGEAIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0xA063E10", Offset = "0xA062410", VA = "0x18A063E10")]
		public MaterialExtensionsImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class AAKJCOIIPHP : CMDLLNAPBAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	internal readonly MaterialExtensionsImport CJEINKGIPEA;

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0xAB22B0", Offset = "0xAB08B0", VA = "0x180AB22B0")]
	public AAKJCOIIPHP(MaterialExtensionsImport ELCKHBMOINJ)
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public class MeshoptImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0xA063F10", Offset = "0xA062510", VA = "0x18A063F10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0xA063EE0", Offset = "0xA0624E0", VA = "0x18A063EE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		public override bool PackageMissing
		{
			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0xA063E90", Offset = "0xA062490", VA = "0x18A063E90", Slot = "13")]
		public override CMDLLNAPBAF CHPLBBCBBMN(HOLINFLNHMO JIFPJFGEAIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x1611790", Offset = "0x160FD90", VA = "0x181611790")]
		public MeshoptImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public class MPDFJDGAOAL : CMDLLNAPBAF
{
	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public MPDFJDGAOAL()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public class TextureTransformExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001B8")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600047A")]
			[Cpp2IlInjected.Address(RVA = "0xA06A650", Offset = "0xA068C50", VA = "0x18A06A650", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B9")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600047B")]
			[Cpp2IlInjected.Address(RVA = "0xA06A620", Offset = "0xA068C20", VA = "0x18A06A620", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		public override bool AlwaysEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "14")]
		public override LEPJFGIFCMO CHPLBBCBBMN(CCLFPBBKELG JIFPJFGEAIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x1611790", Offset = "0x160FD90", VA = "0x181611790")]
		public TextureTransformExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public class TextureTransformImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001BB")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600047F")]
			[Cpp2IlInjected.Address(RVA = "0xA06A6B0", Offset = "0xA068CB0", VA = "0x18A06A6B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000480")]
			[Cpp2IlInjected.Address(RVA = "0xA06A680", Offset = "0xA068C80", VA = "0x18A06A680", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		public override bool AlwaysEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000481")]
			[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "13")]
		public override CMDLLNAPBAF CHPLBBCBBMN(HOLINFLNHMO JIFPJFGEAIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x1611790", Offset = "0x160FD90", VA = "0x181611790")]
		public TextureTransformImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public class UnlitMaterialsExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001BE")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000484")]
			[Cpp2IlInjected.Address(RVA = "0xA06B610", Offset = "0xA069C10", VA = "0x18A06B610", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000485")]
			[Cpp2IlInjected.Address(RVA = "0xA06B5E0", Offset = "0xA069BE0", VA = "0x18A06B5E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		public override bool AlwaysEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000486")]
			[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "14")]
		public override LEPJFGIFCMO CHPLBBCBBMN(CCLFPBBKELG JIFPJFGEAIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x1611790", Offset = "0x160FD90", VA = "0x181611790")]
		public UnlitMaterialsExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public class UnlitMaterialsImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001C1")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000489")]
			[Cpp2IlInjected.Address(RVA = "0xA06B670", Offset = "0xA069C70", VA = "0x18A06B670", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C2")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600048A")]
			[Cpp2IlInjected.Address(RVA = "0xA06B640", Offset = "0xA069C40", VA = "0x18A06B640", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C3")]
		public override bool AlwaysEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x600048B")]
			[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "13")]
		public override CMDLLNAPBAF CHPLBBCBBMN(HOLINFLNHMO JIFPJFGEAIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x1611790", Offset = "0x160FD90", VA = "0x181611790")]
		public UnlitMaterialsImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public class VisibilityExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0xA06B6D0", Offset = "0xA069CD0", VA = "0x18A06B6D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0xA06B6A0", Offset = "0xA069CA0", VA = "0x18A06B6A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		public override bool AlwaysEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000490")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "14")]
		public override LEPJFGIFCMO CHPLBBCBBMN(CCLFPBBKELG JIFPJFGEAIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x1611790", Offset = "0x160FD90", VA = "0x181611790")]
		public VisibilityExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public class VisibilityImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000494")]
			[Cpp2IlInjected.Address(RVA = "0xA06B730", Offset = "0xA069D30", VA = "0x18A06B730", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000495")]
			[Cpp2IlInjected.Address(RVA = "0xA06B700", Offset = "0xA069D00", VA = "0x18A06B700", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CA")]
		public override bool AlwaysEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000496")]
			[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "13")]
		public override CMDLLNAPBAF CHPLBBCBBMN(HOLINFLNHMO JIFPJFGEAIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x1611790", Offset = "0x160FD90", VA = "0x181611790")]
		public VisibilityImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public class MOJCGFALFGE
{
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	internal class HNBHFLBHDFF : MemoryStream
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public readonly string HPMMJEAJOIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public readonly string COGDEMPDBCE;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public interface ELFOIBFCJID
{
	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<Stream> LPBONJFFBKI(string FMGEDNCMFEB);
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public interface GEFPGBLKBPC : ELFOIBFCJID
{
	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Stream HOIGGCGCBOB(string FMGEDNCMFEB);
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[Obsolete("Please switch to IDataLoader.  This interface is deprecated and will be removed in a future release.")]
public interface HDLBLBOMOEF
{
	[Cpp2IlInjected.Token(Token = "0x170001CB")]
	Stream MFHLCJOCJKG
	{
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CC")]
	bool BBHDKOIKJHI
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HOIGGCGCBOB(string FMGEDNCMFEB);

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BAOGCLGKOEC(string CMAJFHODALG);
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public static class FJBEFONCJGA
{
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	private class PMIHMFCCHKC : ELFOIBFCJID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		protected readonly HDLBLBOMOEF HKHHOKPNLCM;

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0xAB22B0", Offset = "0xAB08B0", VA = "0x180AB22B0")]
		public PMIHMFCCHKC(HDLBLBOMOEF MCOEIHMLMCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0xA06A500", Offset = "0xA068B00", VA = "0x18A06A500", Slot = "4")]
		public Task<Stream> LPBONJFFBKI(string FMGEDNCMFEB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	private class DOIJJELHOJE : PMIHMFCCHKC, GEFPGBLKBPC, ELFOIBFCJID
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0xAB22B0", Offset = "0xAB08B0", VA = "0x180AB22B0")]
		public DOIJJELHOJE(HDLBLBOMOEF MCOEIHMLMCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0xA05AF80", Offset = "0xA059580", VA = "0x18A05AF80", Slot = "5")]
		public Stream HOIGGCGCBOB(string FMGEDNCMFEB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0xA05D270", Offset = "0xA05B870", VA = "0x18A05D270")]
	public static ELFOIBFCJID HANBIKMKKKC(HDLBLBOMOEF MCOEIHMLMCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public class OPLNEEGCCGD : ELFOIBFCJID
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private struct OHJCJKGOJCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public AsyncTaskMethodBuilder<Stream> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public OPLNEEGCCGD <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0xA0652A0", Offset = "0xA0638A0", VA = "0x18A0652A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0xA0659C0", Offset = "0xA063FC0", VA = "0x18A0659C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	private string OOPALAJFGBM;

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0xAB22B0", Offset = "0xAB08B0", VA = "0x180AB22B0")]
	public OPLNEEGCCGD(string OOPALAJFGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0xA065A30", Offset = "0xA064030", VA = "0x18A065A30", Slot = "4")]
	[AsyncStateMachine(typeof(OHJCJKGOJCE))]
	public Task<Stream> LPBONJFFBKI(string FMGEDNCMFEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public class LEILFJOCFOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	private readonly List<JLLODLNEFAH> NIALCMPPAFH;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	private static readonly ProfilerMarker MGKGCDFFIFN;

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0xA062770", Offset = "0xA060D70", VA = "0x18A062770")]
	public void MEFAAGOGBHI(JLLODLNEFAH NFJLHNFNPGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0xA0627D0", Offset = "0xA060DD0", VA = "0x18A0627D0")]
	public void PMAEIEMADEL(ILJINGLACKB NPLAFPNKHGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0xA0633B0", Offset = "0xA0619B0", VA = "0x18A0633B0")]
	public LEILFJOCFOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public interface OMGLNHKMEEK
{
	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JGHMGECCBGF(object AMMKGILEHBG, string BFHDBHOMJKM);
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public struct LCJPGEFECDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public INLJELLPHNA NICJHEPCEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public INLJELLPHNA PJBGBLEGJBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public EPGLIBFPAPA GFLPFKMILHA;
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public class KOGALHOOKGL
{
	[Cpp2IlInjected.Token(Token = "0x170001CD")]
	public AnimationClip NCFHELLMNEP
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CE")]
	public LCJPGEFECDJ[] CDOINENKGDE
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0xA062660", Offset = "0xA060C60", VA = "0x18A062660")]
	public KOGALHOOKGL(int FNKFAHBMJPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public class HBGFMPKCGMN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001CF")]
	public Stream[] BIADGOMPKKC
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D0")]
	public Texture2D[] ANMFGNJNNDH
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D1")]
	public Texture2D[] PNKLKPGHIEM
	{
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0xAA70F0", Offset = "0xAA56F0", VA = "0x180AA70F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D2")]
	public JPOLJPEMOMM[] OEEFCGJAFDO
	{
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0xAA5560", Offset = "0xAA3B60", VA = "0x180AA5560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0xAA9ED0", Offset = "0xAA84D0", VA = "0x180AA9ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D3")]
	public CNNJFIOEFEH[] FDGPEAPHMNI
	{
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0xAB2A30", Offset = "0xAB1030", VA = "0x180AB2A30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D4")]
	public JHEHCIOMFDO[] NOAPBFHCJKM
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0xAA54B0", Offset = "0xAA3AB0", VA = "0x180AA54B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0xAA56F0", Offset = "0xAA3CF0", VA = "0x180AA56F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D5")]
	public NBAANDLELJE[] FJBENILIHGP
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0xAA5620", Offset = "0xAA3C20", VA = "0x180AA5620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0xAA5640", Offset = "0xAA3C40", VA = "0x180AA5640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D6")]
	public JFPLKAKPFEG[] EIDKGNDKGNL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0xAA55B0", Offset = "0xAA3BB0", VA = "0x180AA55B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0xAA57F0", Offset = "0xAA3DF0", VA = "0x180AA57F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D7")]
	public KOGALHOOKGL[] AFAPHHEDPMA
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0xAA5710", Offset = "0xAA3D10", VA = "0x180AA5710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0xAA5590", Offset = "0xAA3B90", VA = "0x180AA5590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D8")]
	public GameObject[] BJFGKCMBOGF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0xAA54C0", Offset = "0xAA3AC0", VA = "0x180AA54C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xAA5570", Offset = "0xAA3B70", VA = "0x180AA5570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0xA05EC70", Offset = "0xA05D270", VA = "0x18A05EC70")]
	public HBGFMPKCGMN(HHLPFANFNFB BOCNDANOLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0xA05EB60", Offset = "0xA05D160", VA = "0x18A05EB60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public class JHEHCIOMFDO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001D9")]
	public uint AGBIAJPLIAM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180")]
		[CompilerGenerated]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0xAA7130", Offset = "0xAA5730", VA = "0x180AA7130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DA")]
	public Stream KOAAPNPBOJM
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DB")]
	public NativeArray<byte> JFFCIGPAGEF
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0xEC0AD0", Offset = "0xEBF0D0", VA = "0x180EC0AD0")]
		[CompilerGenerated]
		get
		{
			return default(NativeArray<byte>);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0xFBC0D0", Offset = "0xFBA6D0", VA = "0x180FBC0D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x73748C0", Offset = "0x7372EC0", VA = "0x1873748C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public JHEHCIOMFDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
internal static class AJIIOCLFNBL
{
	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0xF9D570", Offset = "0xF9BB70", VA = "0x180F9D570")]
	public static bool ODCIGFLMOJJ(UnityEngine.Object MIJCADJIHEK, string LEIFMFPCLJB, [Out] byte[] EIJIDGHNNNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
	public static void FKNJMFOJBNN(UnityEngine.Object MIJCADJIHEK, string LEIFMFPCLJB, byte[] EIJIDGHNNNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public class CNNJFIOEFEH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001DC")]
	public Material ICMPBHCNDPP
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DD")]
	public Material JDIDOEKEANF
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DE")]
	public LPKIABJLDGD IJIAEABOHFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0xAA70F0", Offset = "0xAA56F0", VA = "0x180AA70F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0xA05A720", Offset = "0xA058D20", VA = "0x18A05A720", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public CNNJFIOEFEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public class NBAANDLELJE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public class DMDEEILDIDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public bool LCCEHKEMAFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public Dictionary<string, INLJELLPHNA> JMGBLHALMBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public List<Dictionary<string, INLJELLPHNA>> NONGPOLBPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public Dictionary<string, (INLJELLPHNA sparseIndices, INLJELLPHNA sparseValues)> NNOBPFINEJK;

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0xA05A920", Offset = "0xA058F20", VA = "0x18A05A920")]
		public DMDEEILDIDA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public List<DMDEEILDIDA> DCBNBAKMJKI;

	[Cpp2IlInjected.Token(Token = "0x170001DF")]
	public Mesh PJMJEIOEDGG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0xA063F40", Offset = "0xA062540", VA = "0x18A063F40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0xA063FE0", Offset = "0xA0625E0", VA = "0x18A063FE0")]
	public NBAANDLELJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public class KCBKDEHHPJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000427")]
	private bool JFLGABEFEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000428")]
	private int DGKMIKHMEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000429")]
	private readonly object LEMEDKCKLPH;

	[Cpp2IlInjected.Token(Token = "0x170001E0")]
	public NBAANDLELJE[] FJBENILIHGP
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0xAA70F0", Offset = "0xAA56F0", VA = "0x180AA70F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E1")]
	public UnityEngine.Object[] HCFHKMNHMEL
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0xAA5560", Offset = "0xAA3B60", VA = "0x180AA5560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0xAA9ED0", Offset = "0xAA84D0", VA = "0x180AA9ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E2")]
	public CNNJFIOEFEH[] FDGPEAPHMNI
	{
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0xAB2A30", Offset = "0xAB1030", VA = "0x180AB2A30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E3")]
	public JPOLJPEMOMM[] OEEFCGJAFDO
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0xAA54B0", Offset = "0xAA3AB0", VA = "0x180AA54B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0xAA56F0", Offset = "0xAA3CF0", VA = "0x180AA56F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E4")]
	public KOGALHOOKGL[] AFAPHHEDPMA
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0xAA5620", Offset = "0xAA3C20", VA = "0x180AA5620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0xAA5640", Offset = "0xAA3C40", VA = "0x180AA5640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E5")]
	public Texture2D[] ANMFGNJNNDH
	{
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0xAA55B0", Offset = "0xAA3BB0", VA = "0x180AA55B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0xAA57F0", Offset = "0xAA3DF0", VA = "0x180AA57F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0xA0624D0", Offset = "0xA060AD0", VA = "0x18A0624D0")]
	public KCBKDEHHPJJ(CNNJFIOEFEH[] GCGANANDHAK, NBAANDLELJE[] KCHNCOPJIKF, JPOLJPEMOMM[] OLLOCDPKBJG, Texture2D[] JCMGHCEHJHI, KOGALHOOKGL[] BNHBLBMBAGI, UnityEngine.Object[] DKFONKGPMNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0xA061FF0", Offset = "0xA0605F0", VA = "0x18A061FF0")]
	public void NDJNJNAEHDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0xA061E90", Offset = "0xA060490", VA = "0x18A061E90")]
	public void GOELOBJKNEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0xA0620E0", Offset = "0xA0606E0", VA = "0x18A0620E0")]
	private void OBPIMAPAGBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public class JPOLJPEMOMM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public BOOEFBPDPHN JMOPPFDKBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public Texture2D JAKHKFPCPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public bool KOAKCMLCDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public bool MAHIDHLKLDK;

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0xA061DF0", Offset = "0xA0603F0", VA = "0x18A061DF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public JPOLJPEMOMM()
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
