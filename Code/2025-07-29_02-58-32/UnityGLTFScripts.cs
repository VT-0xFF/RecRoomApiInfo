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
		private struct PDOAGHAEINP : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x9DE80E0", Offset = "0x9DE6AE0", VA = "0x189DE80E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9DE82D0", Offset = "0x9DE6CD0", VA = "0x189DE82D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class HPPHJGNGPMC : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA8AF50", Offset = "0xA89950", VA = "0x180A8AF50")]
			[DebuggerHidden]
			public HPPHJGNGPMC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9DD7FF0", Offset = "0x9DD69F0", VA = "0x189DD7FF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9DD8070", Offset = "0x9DD6A70", VA = "0x189DD8070", Slot = "8")]
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
		private WaitForEndOfFrame KMHAPGCJOKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private float ECJGCNJHLNA;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9DD3D50", Offset = "0x9DD2750", VA = "0x189DD3D50")]
		[AsyncStateMachine(typeof(PDOAGHAEINP))]
		public Task YieldOnTimeout()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9DD3CC0", Offset = "0x9DD26C0", VA = "0x189DD3CC0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9DD3C40", Offset = "0x9DD2640", VA = "0x189DD3C40")]
		[IteratorStateMachine(typeof(HPPHJGNGPMC))]
		private IEnumerator AIONHOCNDNB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9DD3E20", Offset = "0x9DD2820", VA = "0x189DD3E20")]
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
		private struct AGOEILIAGOP : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x9DD2F40", Offset = "0x9DD1940", VA = "0x189DD2F40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xAE21E0", Offset = "0xAE0BE0", VA = "0x180AE21E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private struct CDMIAHPJPEI : IAsyncStateMachine
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
			private FCHIMHCBINK <importOptions>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private JGLMIIHJDFL <sceneImporter>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9DD4370", Offset = "0x9DD2D70", VA = "0x189DD4370", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x9DD5070", Offset = "0x9DD3A70", VA = "0x189DD5070", Slot = "5")]
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
		private int PLOKAAFPLBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int MaximumLod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int Timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public JGLMIIHJDFL.FEFBFHBIACA Collider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private Shader shaderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[Header("Import Settings")]
		public AIFKJAJBNEC TextureCompression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public FDNLENBNCDB ImportNormals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public FDNLENBNCDB ImportTangents;

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
		public IEnumerable<Animation> GKAMLNGHEGK
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA88310", Offset = "0xA86D10", VA = "0x180A88310")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public GameObject DGCHCMMJEIO
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA841E0", Offset = "0xA82BE0", VA = "0x180A841E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA841C0", Offset = "0xA82BC0", VA = "0x180A841C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Shader HLNPGNGIDNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xA841B0", Offset = "0xA82BB0", VA = "0x180A841B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x9DD7670", Offset = "0x9DD6070", VA = "0x189DD7670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9DD7550", Offset = "0x9DD5F50", VA = "0x189DD7550")]
		[AsyncStateMachine(typeof(AGOEILIAGOP))]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9DD7480", Offset = "0x9DD5E80", VA = "0x189DD7480")]
		[AsyncStateMachine(typeof(CDMIAHPJPEI))]
		public Task Load()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9DD7390", Offset = "0x9DD5D90", VA = "0x189DD7390")]
		public void ApplyOverrideShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x105CF70", Offset = "0x105B970", VA = "0x18105CF70")]
		private void GKALBBNPKOL(GameObject CEFJEHJNIAP, ExceptionDispatchInfo JEEAEIICNKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9DD7600", Offset = "0x9DD6000", VA = "0x189DD7600")]
		public GLTFComponent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class GLTFRecorderComponent : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class HNBBHKAIPOF : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xA8AF50", Offset = "0xA89950", VA = "0x180A8AF50")]
			[DebuggerHidden]
			public HNBBHKAIPOF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9DD7ED0", Offset = "0x9DD68D0", VA = "0x189DD7ED0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x9DD7FA0", Offset = "0x9DD69A0", VA = "0x189DD7FA0", Slot = "8")]
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
		protected AMBFBNPLPEL CDLNBKNEMEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public UnityEvent recordingStarted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public UnityEvent<string> recordingEnded;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool OCFGKFHFBGE
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9DD7EC0", Offset = "0x9DD68C0", VA = "0x189DD7EC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private double ODOHFKACJON
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x9DD78D0", Offset = "0x9DD62D0", VA = "0x189DD78D0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9DD7950", Offset = "0x9DD6350", VA = "0x189DD7950", Slot = "4")]
		[ContextMenu("Start Recording")]
		public virtual void StartRecording()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9DD7CF0", Offset = "0x9DD66F0", VA = "0x189DD7CF0", Slot = "5")]
		[ContextMenu("Stop Recording")]
		public virtual void StopRecording()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9DD76A0", Offset = "0x9DD60A0", VA = "0x189DD76A0")]
		private void BBBDNBAMAOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9DD7C60", Offset = "0x9DD6660", VA = "0x189DD7C60")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9DD7930", Offset = "0x9DD6330", VA = "0x189DD7930")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9DD78E0", Offset = "0x9DD62E0", VA = "0x189DD78E0", Slot = "6")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9DD7880", Offset = "0x9DD6280", VA = "0x189DD7880", Slot = "7")]
		protected virtual void KMBFLBNHKEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9DD7800", Offset = "0x9DD6200", VA = "0x189DD7800")]
		[IteratorStateMachine(typeof(HNBBHKAIPOF))]
		private IEnumerator CMDKKBJOKFC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9DD7DF0", Offset = "0x9DD67F0", VA = "0x189DD7DF0")]
		public GLTFRecorderComponent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9DD76A0", Offset = "0x9DD60A0", VA = "0x189DD76A0")]
		[CompilerGenerated]
		private void KDBGHFIHFCG(InputAction.CallbackContext GIGDEGEMDAC)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class LIDEFDAPMMN
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal class IDPPFJOENDP : PDBJIPMJIIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly LIDEFDAPMMN IMEANCKICLA;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xAB0110", Offset = "0xAAEB10", VA = "0x180AB0110")]
		internal IDPPFJOENDP(LIDEFDAPMMN HCLPHJDKMCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9DD8380", Offset = "0x9DD6D80", VA = "0x189DD8380", Slot = "4")]
		public override void NNNEILPGEJI(GENLMNMPIND HIMDLPAHKOO, EFAGEPFJOIC MLPDGDMMEHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9DD83C0", Offset = "0x9DD6DC0", VA = "0x189DD83C0", Slot = "5")]
		public override void ODKAGIAEEAB(GENLMNMPIND HIMDLPAHKOO, EFAGEPFJOIC MLPDGDMMEHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9DD8230", Offset = "0x9DD6C30", VA = "0x189DD8230", Slot = "8")]
		public override void MEPLLBKDIJM(GENLMNMPIND HIMDLPAHKOO, EFAGEPFJOIC MLPDGDMMEHF, Transform EOBBLENOIHL, BEPOCDMOBMH AAPGFEFGBOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9DD8270", Offset = "0x9DD6C70", VA = "0x189DD8270", Slot = "9")]
		public override bool NDBAACIGCGM(GENLMNMPIND HIMDLPAHKOO, EFAGEPFJOIC MLPDGDMMEHF, Material POCHLMCAOAO, LCMNEMHMEMN JNPJLGBGEJH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9DD81B0", Offset = "0x9DD6BB0", VA = "0x189DD81B0", Slot = "10")]
		public override void IGOMIKDBHHA(GENLMNMPIND HIMDLPAHKOO, EFAGEPFJOIC MLPDGDMMEHF, Material POCHLMCAOAO, LCMNEMHMEMN JNPJLGBGEJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9DD80C0", Offset = "0x9DD6AC0", VA = "0x189DD80C0", Slot = "11")]
		public override void CFDBPIBOMJA(GENLMNMPIND HIMDLPAHKOO, GENLMNMPIND.BDKCOOLEBKG GIAGKAKEOKD, string DEDCEAPAKEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9DD8140", Offset = "0x9DD6B40", VA = "0x189DD8140", Slot = "12")]
		public override void IAPLHCDGKAO(GENLMNMPIND HIMDLPAHKOO, GENLMNMPIND.BDKCOOLEBKG GIAGKAKEOKD, int FILGHJLFKAL, DHNJMKCGALD BPFBEDAOOJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9DD8100", Offset = "0x9DD6B00", VA = "0x189DD8100", Slot = "13")]
		public override void IADKDEFCGOB(GENLMNMPIND HIMDLPAHKOO, Mesh HFCMFMCGELA, GNHEIJGFIHM PKPIFEMAIAE, int FILGHJLFKAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9DD81F0", Offset = "0x9DD6BF0", VA = "0x189DD81F0", Slot = "14")]
		public override void LIENEKKEJOP(GENLMNMPIND HIMDLPAHKOO, Mesh HFCMFMCGELA, BEALLOFPNOF PDHFPJJNOJI, int FILGHJLFKAL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public bool DICIFFOMANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public LayerMask JABDOPOILFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public ILogger DADGPCINNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal readonly GLTFSettings IMFNJOKFKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public GENLMNMPIND.PBKEDHOBBKE BMHAKAOIHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public GENLMNMPIND.GHDLBGAIBCH ODKAGIAEEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public GENLMNMPIND.GLGJNJHCFPO NNNEILPGEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public GENLMNMPIND.EJPPIBBFCLJ MEPLLBKDIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public GENLMNMPIND.PGMDHBLLDKI NDBAACIGCGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public GENLMNMPIND.NJFLHNGHCFI IGOMIKDBHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public GENLMNMPIND.HJJMEKGEIAL CFDBPIBOMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public GENLMNMPIND.EGPFEPAJAHC IAPLHCDGKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public GENLMNMPIND.LONLBADMNLD IADKDEFCGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public GENLMNMPIND.GOPOMKBODFN LIENEKKEJOP;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x9DE6140", Offset = "0x9DE4B40", VA = "0x189DE6140")]
	public LIDEFDAPMMN(GLTFSettings IMFNJOKFKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x9DE60D0", Offset = "0x9DE4AD0", VA = "0x189DE60D0")]
	internal PDBJIPMJIIJ KDIPHHDDOKA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class GENLMNMPIND
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate string PBKEDHOBBKE(Texture GIAGKAKEOKD);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public delegate void GLGJNJHCFPO(GENLMNMPIND HIMDLPAHKOO, EFAGEPFJOIC MLPDGDMMEHF);

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate void GHDLBGAIBCH(GENLMNMPIND HIMDLPAHKOO, EFAGEPFJOIC MLPDGDMMEHF);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate void EJPPIBBFCLJ(GENLMNMPIND HIMDLPAHKOO, EFAGEPFJOIC MLPDGDMMEHF, Transform EOBBLENOIHL, BEPOCDMOBMH AAPGFEFGBOK);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate bool PGMDHBLLDKI(GENLMNMPIND HIMDLPAHKOO, EFAGEPFJOIC MLPDGDMMEHF, Material POCHLMCAOAO, LCMNEMHMEMN JNPJLGBGEJH);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void NJFLHNGHCFI(GENLMNMPIND HIMDLPAHKOO, EFAGEPFJOIC MLPDGDMMEHF, Material POCHLMCAOAO, LCMNEMHMEMN JNPJLGBGEJH);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void HJJMEKGEIAL(GENLMNMPIND HIMDLPAHKOO, BDKCOOLEBKG GIAGKAKEOKD, string DEDCEAPAKEH);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public delegate void EGPFEPAJAHC(GENLMNMPIND HIMDLPAHKOO, BDKCOOLEBKG GIAGKAKEOKD, int FILGHJLFKAL, DHNJMKCGALD BPFBEDAOOJO);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public delegate void LONLBADMNLD(GENLMNMPIND HIMDLPAHKOO, Mesh HFCMFMCGELA, GNHEIJGFIHM PKPIFEMAIAE, int FILGHJLFKAL);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate void GOPOMKBODFN(GENLMNMPIND HIMDLPAHKOO, Mesh HFCMFMCGELA, BEALLOFPNOF PDHFPJJNOJI, int FILGHJLFKAL);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class FIAMBMDIFKJ : PDBJIPMJIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9DD7310", Offset = "0x9DD5D10", VA = "0x189DD7310", Slot = "5")]
		public override void ODKAGIAEEAB(GENLMNMPIND HIMDLPAHKOO, EFAGEPFJOIC MLPDGDMMEHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9DD7290", Offset = "0x9DD5C90", VA = "0x189DD7290", Slot = "4")]
		public override void NNNEILPGEJI(GENLMNMPIND HIMDLPAHKOO, EFAGEPFJOIC MLPDGDMMEHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9DD7090", Offset = "0x9DD5A90", VA = "0x189DD7090", Slot = "8")]
		public override void MEPLLBKDIJM(GENLMNMPIND HIMDLPAHKOO, EFAGEPFJOIC MLPDGDMMEHF, Transform EOBBLENOIHL, BEPOCDMOBMH AAPGFEFGBOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9DD7130", Offset = "0x9DD5B30", VA = "0x189DD7130", Slot = "9")]
		public override bool NDBAACIGCGM(GENLMNMPIND HIMDLPAHKOO, EFAGEPFJOIC MLPDGDMMEHF, Material POCHLMCAOAO, LCMNEMHMEMN JNPJLGBGEJH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9DD6FF0", Offset = "0x9DD59F0", VA = "0x189DD6FF0", Slot = "10")]
		public override void IGOMIKDBHHA(GENLMNMPIND HIMDLPAHKOO, EFAGEPFJOIC MLPDGDMMEHF, Material POCHLMCAOAO, LCMNEMHMEMN JNPJLGBGEJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
		public FIAMBMDIFKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct NACOIFEIKPF
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public enum JJBGOOLHLCL
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
		public enum IMPCPGPBCDB
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
		public bool CIIMGBCFCFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public JJBGOOLHLCL EHOKJMIDLHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public IMPCPGPBCDB OKFFNEMMDFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool IECDOACIIHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public float KEPDBCIIOGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public float BEMGIELJPJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public float LEHFFKFMMGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public float JGPOPDFAPKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public float JEMABAPICHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public float GNKDMCIBJKJ;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x9DE6840", Offset = "0x9DE5240", VA = "0x189DE6840")]
		public NACOIFEIKPF(NACOIFEIKPF PEIDNFHKHFH)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9DE6800", Offset = "0x9DE5200", VA = "0x189DE6800")]
		public static bool JJNADAGGMDE(NACOIFEIKPF HEOFBNHHDGF, NACOIFEIKPF HEGCIIKIHGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9DE6600", Offset = "0x9DE5000", VA = "0x189DE6600")]
		public bool FMOEJGBHBPC(NACOIFEIKPF EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9DE6550", Offset = "0x9DE4F50", VA = "0x189DE6550", Slot = "0")]
		public override bool Equals(object CEFJEHJNIAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9DE66E0", Offset = "0x9DE50E0", VA = "0x189DE66E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private struct HJNFPAFKCHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Texture2D GIAGKAKEOKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public NACOIFEIKPF GAJLKJNKEKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public string KNOGKELFBKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public bool FIDHLNBFDKA;
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private struct MAPMKNEGCNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Stream AKDFBDNJGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public string GFOGLKNBPCA;
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct BDKCOOLEBKG : IEquatable<BDKCOOLEBKG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Texture IBEMOGNKKEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public int MKJBAIGMPLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public NACOIFEIKPF IACGFAMPDJP;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x9DD41F0", Offset = "0x9DD2BF0", VA = "0x189DD41F0")]
		public int MKKGAIPGDHO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9DD4110", Offset = "0x9DD2B10", VA = "0x189DD4110")]
		public int FBCLAKHEDOB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x9DD4230", Offset = "0x9DD2C30", VA = "0x189DD4230")]
		public BDKCOOLEBKG(Texture BPFBEDAOOJO, string DEDCEAPAKEH, GENLMNMPIND HIMDLPAHKOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9DD42E0", Offset = "0x9DD2CE0", VA = "0x189DD42E0")]
		public BDKCOOLEBKG(Texture BPFBEDAOOJO, NACOIFEIKPF KKMJMAOLJEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9DD3F50", Offset = "0x9DD2950", VA = "0x189DD3F50", Slot = "4")]
		public bool Equals(BDKCOOLEBKG EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9DD3EA0", Offset = "0x9DD28A0", VA = "0x189DD3EA0", Slot = "0")]
		public override bool Equals(object CEFJEHJNIAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9DD4150", Offset = "0x9DD2B50", VA = "0x189DD4150", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct DNJHODIHKIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Mesh OHLAJAADLAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Material[] MKNLDALIANJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public SkinnedMeshRenderer GOJGDHAMLLJ;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x9DD6580", Offset = "0x9DD4F80", VA = "0x189DD6580")]
		public bool FMOEJGBHBPC(DNJHODIHKIP EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9DD64E0", Offset = "0x9DD4EE0", VA = "0x189DD64E0", Slot = "0")]
		public override bool Equals(object CEFJEHJNIAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x9DD66F0", Offset = "0x9DD50F0", VA = "0x189DD66F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private struct PNDACICNBGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public CBIGKEBPCGM JLCGDPLMABJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public CBIGKEBPCGM EMGAKKCBEIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public CBIGKEBPCGM JJLMFNKCEMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public CBIGKEBPCGM CKAILMDCDLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public CBIGKEBPCGM LJMBLPGBEIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public CBIGKEBPCGM EJAEHMAPLGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public CBIGKEBPCGM LLEOEGIEEMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public CBIGKEBPCGM FNLLLOLHBOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public CBIGKEBPCGM JHOAHAIOGCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public Dictionary<int, GNHEIJGFIHM> NGNOEHIOEHJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct PCFFCLADAEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public List<Dictionary<string, CBIGKEBPCGM>> KAKEELPILFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public List<double> MKGDFJHNEIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public List<string> KIFJBOGFLEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		internal SkinnedMeshRenderer HMPIGLELNHA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct COHIFIKHLJF : IEquatable<COHIFIKHLJF>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly TextureWrapMode FNPEJNLGEJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly FilterMode BFBPGKDBBAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly bool INEAGDFPFJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly bool KHDIFMKHBGN;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool EGILECBPLHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xE765D0", Offset = "0xE74FD0", VA = "0x180E765D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool OLNEOPOIIII
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x73363D0", Offset = "0x7334DD0", VA = "0x1873363D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9DD5270", Offset = "0x9DD3C70", VA = "0x189DD5270")]
		public COHIFIKHLJF(Texture GIAGKAKEOKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9DD5190", Offset = "0x9DD3B90", VA = "0x189DD5190", Slot = "4")]
		public bool Equals(COHIFIKHLJF EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9DD50D0", Offset = "0x9DD3AD0", VA = "0x189DD50D0", Slot = "0")]
		public override bool Equals(object CEFJEHJNIAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9DD51C0", Offset = "0x9DD3BC0", VA = "0x189DD51C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class EPCJNJMIIHK : IEnumerable<(int, GNHEIJGFIHM)>, IEnumerable, IEnumerator<(int, GNHEIJGFIHM)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private (int subMeshIndex, GNHEIJGFIHM prim) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public GENLMNMPIND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private Mesh mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Mesh <>3__mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private Dictionary<int, GNHEIJGFIHM>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private (int, GNHEIJGFIHM) System.Collections.Generic.IEnumerator<(System.Int32subMeshIndex,GLTF.Schema.MeshPrimitiveprim)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xD5CF80", Offset = "0xD5B980", VA = "0x180D5CF80", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((int, GNHEIJGFIHM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x9DD6E20", Offset = "0x9DD5820", VA = "0x189DD6E20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2905350", Offset = "0x2903D50", VA = "0x182905350")]
		[DebuggerHidden]
		public EPCJNJMIIHK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9DD6E70", Offset = "0x9DD5870", VA = "0x189DD6E70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9DD6A40", Offset = "0x9DD5440", VA = "0x189DD6A40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9DD69F0", Offset = "0x9DD53F0", VA = "0x189DD69F0")]
		private void ALLLMJKJJCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9DD6DD0", Offset = "0x9DD57D0", VA = "0x189DD6DD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9DD6D10", Offset = "0x9DD5710", VA = "0x189DD6D10", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(int, GNHEIJGFIHM)> System.Collections.Generic.IEnumerable<(System.Int32subMeshIndex,GLTF.Schema.MeshPrimitiveprim)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9DD6D10", Offset = "0x9DD5710", VA = "0x189DD6D10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class MMEBEKPIHCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public bool convertToLinearColor;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public MMEBEKPIHCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x9DE6460", Offset = "0x9DE4E60", VA = "0x189DE6460")]
		internal Color CPCNDEAKPBC(object e)
		{
			return default(Color);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class KICLMBDACFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public float multiplier;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public KICLMBDACFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9DE5F80", Offset = "0x9DE4980", VA = "0x189DE5F80")]
		internal float EJIHBKNCPDA(object e)
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static ILogger IBCCEPEBFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private List<PDBJIPMJIIJ> DOOGHJMBCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private Transform[] MNNGJEPFPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private EFAGEPFJOIC MIIJBCOMCPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private NIBDKOGDPGA KBLHFAIENAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private HPGPKKBHOBO EMGOPPNCHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private List<HJNFPAFKCHH> FLNDAANKNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private HashSet<string> NMLAPFMPGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private List<MAPMKNEGCNF> KIEBFMHAHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private HashSet<string> NJINMAOGLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<BDKCOOLEBKG> BFHDLIHMFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private Dictionary<int, int> IPPFJCMLFIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private bool FJODCFJCPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private Dictionary<int, int> DEHHAEDBOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private List<Transform> HPILJOPJAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private int FOLHIMOJBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private LIDEFDAPMMN IMEANCKICLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private Material NFKLOJBKFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private Material HPANKENDICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private Material HECAAPABAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private bool NHNJAKKGEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<DNJHODIHKIP, MANMOFDPDPG> OELMBAMPLPI;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static ProfilerMarker PKEGLBOFCGH;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static ProfilerMarker DMLHKCIGGJJ;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static ProfilerMarker JDAMOBHGMBC;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static ProfilerMarker DPDJMKHODHF;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static ProfilerMarker EONIMCCHNGE;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static ProfilerMarker MFFHAFHDDPG;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static ProfilerMarker GPJAKLCDIJI;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static ProfilerMarker DBPHBGIOICL;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static ProfilerMarker OEKPKFFLAKL;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static ProfilerMarker BHMPHOALMJK;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static ProfilerMarker OHDGBFJAFID;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static ProfilerMarker KDDHLBBLHLL;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static ProfilerMarker DONDEFBIMLM;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static ProfilerMarker NPJLCIJNDEE;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static ProfilerMarker AJALAOFBLNF;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static ProfilerMarker HPOJGKOJIIA;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static ProfilerMarker NICIAKHHNNI;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static ProfilerMarker BIOFOGGGHED;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static ProfilerMarker CKHPNIGFMND;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static ProfilerMarker GGMOELBANPA;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static ProfilerMarker GAPDNNHDPPM;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static ProfilerMarker KHDNFFDMNLB;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static ProfilerMarker NBPHCADKANL;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static ProfilerMarker PPBPIOPHKLF;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static ProfilerMarker KDHJJLAPEOJ;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static ProfilerMarker CDKFJNJCJIC;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static ProfilerMarker PLENCMGLFEI;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static ProfilerMarker NLBIMMOAHHI;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private static ProfilerMarker GJEPHAILKOA;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static ProfilerMarker GNBOJPHOAEG;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static ProfilerMarker KPEJJNNEIKE;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static ProfilerMarker HJFLKOANINI;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static ProfilerMarker AKFBNDBODKH;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static ProfilerMarker CAJHEEIPEKN;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private static ProfilerMarker CKEIKOIBKJB;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static ProfilerMarker JOILKIOPDCJ;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static ProfilerMarker NDFKPAEOLAK;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static ProfilerMarker CAOJEHIHIKO;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static ProfilerMarker DNCIAODCHFD;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private static ProfilerMarker PMHAPEKLIPL;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static ProfilerMarker DADPPJPEGDF;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static ProfilerMarker IMPDPHPGLEP;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static ProfilerMarker PMIFABGAKBP;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static ProfilerMarker IADHMLPNJCP;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private static ProfilerMarker DHNBIFLLEGC;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static ProfilerMarker COCDDJBHHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private global::NAKGAABKNAC LNAIEICAAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool? OMJNPABIJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	internal readonly List<FMGHKJDAGLC> ONKGNJAGIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly FJBLHCCIDHK EGBGPIFMMFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Dictionary<int, int> DMDAJCIGOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Dictionary<int, int> DKENIBEJGFH;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	[CompilerGenerated]
	private static GLGJNJHCFPO NNNEILPGEJI;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[CompilerGenerated]
	private static GHDLBGAIBCH ODKAGIAEEAB;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	[CompilerGenerated]
	private static EJPPIBBFCLJ MEPLLBKDIJM;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[CompilerGenerated]
	private static PGMDHBLLDKI NDBAACIGCGM;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[CompilerGenerated]
	private static NJFLHNGHCFI IGOMIKDBHHA;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static Material CFGIDIHPHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private HashSet<Material> KABNAGJOEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly Dictionary<Mesh, PNDACICNBGM> PMMGAIMDCGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly Dictionary<Mesh, PCFFCLADAEG> GPPIAEOAGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly Dictionary<SkinnedMeshRenderer, List<double>> JDHEBPDKOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private List<Transform> KCAOPGOAINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Dictionary<SkinnedMeshRenderer, Mesh> DLGEEPHFLBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Dictionary<COHIFIKHLJF, int> FDFPEHLMFCJ;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyList<Transform> EFKBNOODJGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private GLTFSettings IMFNJOKFKEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9DBC5F0", Offset = "0x9DBAFF0", VA = "0x189DBC5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private bool EHDMGMDMHIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9DC3540", Offset = "0x9DC1F40", VA = "0x189DC3540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private bool EBCGIFLBHNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9DCD3B0", Offset = "0x9DCBDB0", VA = "0x189DCD3B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private bool MOKLGCAAEBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9DC2340", Offset = "0x9DC0D40", VA = "0x189DC2340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static Material GIMGHHOFMBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9DC8DF0", Offset = "0x9DC77F0", VA = "0x189DC8DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x9DC1850", Offset = "0x9DC0250", VA = "0x189DC1850")]
	public NACOIFEIKPF JAPIEPEJCJB(string DEDCEAPAKEH)
	{
		return default(NACOIFEIKPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x9DCFE50", Offset = "0x9DCE850", VA = "0x189DCFE50")]
	private Material PBNNFEGNJOF(NACOIFEIKPF GAJLKJNKEKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x9DC3690", Offset = "0x9DC2090", VA = "0x189DC3690")]
	private static Material LPEOMACLHFM(Material POCHLMCAOAO, NACOIFEIKPF GAJLKJNKEKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x9DD15D0", Offset = "0x9DCFFD0", VA = "0x189DD15D0")]
	public GENLMNMPIND(Transform[] KBNNOLPIDCI, LIDEFDAPMMN HCLPHJDKMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x9DBE5E0", Offset = "0x9DBCFE0", VA = "0x189DBE5E0")]
	public void GICIADEAEHE(Stream AKDFBDNJGIO, string MPIBHFEHILP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x9DB9830", Offset = "0x9DB8230", VA = "0x189DB9830")]
	public void CPCMOPGEHAM(string ACHJMLCMOOL, bool KFHPPBJPNKN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x9DC0520", Offset = "0x9DBEF20", VA = "0x189DC0520")]
	private bool HDEPCLEGMFM(Transform EOBBLENOIHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x9DC9CE0", Offset = "0x9DC86E0", VA = "0x189DC9CE0")]
	private GMNGICNBBCA MOJPABPHOHJ(string FLBFBHGDBLM, Transform[] HLNKOIDFGJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x9DB9CE0", Offset = "0x9DB86E0", VA = "0x189DB9CE0")]
	private JNFOCPPKDAF DCOPLLMEFPG(Transform POPKELOMCNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x9DB8350", Offset = "0x9DB6D50", VA = "0x189DB8350")]
	private static bool BMFFFFFMGLJ(GameObject CEENMGBCJEJ, bool BKEBBPFEDAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x9DB87A0", Offset = "0x9DB71A0", VA = "0x189DB87A0")]
	private void CDDJHFGFBLG(Transform EOBBLENOIHL, [Out] GameObject[] AIBHFOFPIBC, [Out] GameObject[] KFPHJKIEPIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x9DC0C60", Offset = "0x9DBF660", VA = "0x189DC0C60")]
	private void HOAIGPKOMNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x9DD08D0", Offset = "0x9DCF2D0", VA = "0x189DD08D0")]
	public DJNPGCHMDPA PPNGPDGBKFE(EFAGEPFJOIC PJFDNMGHMBL, Material LFOCIKLNJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x9DC8C60", Offset = "0x9DC7660", VA = "0x189DC8C60")]
	public MIGEAKAJGAO MGGFLIFJDEK(EFAGEPFJOIC PJFDNMGHMBL, BDKCOOLEBKG COFBIBGIOKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x9DBBC80", Offset = "0x9DBA680", VA = "0x189DBBC80")]
	public NEOOHBGCDPE DLKCDAEOMGG(EFAGEPFJOIC PJFDNMGHMBL, Texture DGJIMCGGKOA, NACOIFEIKPF GAJLKJNKEKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x9DD0550", Offset = "0x9DCEF50", VA = "0x189DD0550")]
	private static void PNNFDNNCACL(Stream GMLILPJAKBM, BinaryWriter PDBEMMKOCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x9DCE490", Offset = "0x9DCCE90", VA = "0x189DCE490")]
	private static void OCNKDIMLDDM(Stream AKDFBDNJGIO, byte AFMPBKMBNPL = 32, uint MBIFFKHECAJ = 4u)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x9DB6690", Offset = "0x9DB5090", VA = "0x189DB6690")]
	public static uint AMAHOANEBIA(uint OGGIFGLNJPG, uint BNBMKIILMLI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x9DB8ED0", Offset = "0x9DB78D0", VA = "0x189DB8ED0")]
	private CBIGKEBPCGM CIMOAKLPCOK(Vector4[] LDAMGPGPNCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x9DB6F50", Offset = "0x9DB5950", VA = "0x189DB6F50")]
	private CBIGKEBPCGM BKOIMMOPEGH(Quaternion[] LDAMGPGPNCL, bool JOCKPKFIGLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x9DCC610", Offset = "0x9DCB010", VA = "0x189DCC610")]
	private CBIGKEBPCGM NAFPLPBGLBA(Matrix4x4[] LDAMGPGPNCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x9DCA120", Offset = "0x9DC8B20", VA = "0x189DCA120")]
	private CBIGKEBPCGM NAFPLPBGLBA(float[] LDAMGPGPNCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x9DCA610", Offset = "0x9DC9010", VA = "0x189DCA610")]
	private CBIGKEBPCGM NAFPLPBGLBA(int[] LDAMGPGPNCL, bool IJKAIGNEMMK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x9DCBFC0", Offset = "0x9DCA9C0", VA = "0x189DCBFC0")]
	private CBIGKEBPCGM NAFPLPBGLBA(Vector2[] LDAMGPGPNCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x9DCB8B0", Offset = "0x9DCA2B0", VA = "0x189DCB8B0")]
	private CBIGKEBPCGM NAFPLPBGLBA(Vector3[] LDAMGPGPNCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x9DCD410", Offset = "0x9DCBE10", VA = "0x189DCD410")]
	private CBIGKEBPCGM NPGGBGEOECD(CBIGKEBPCGM KCFLGNPKILB, Vector3[] DEEGMKGGGPC, Vector3[] LDAMGPGPNCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x9DCCAB0", Offset = "0x9DCB4B0", VA = "0x189DCCAB0")]
	private CBIGKEBPCGM NAFPLPBGLBA(Vector4[] LDAMGPGPNCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x9DCAD10", Offset = "0x9DC9710", VA = "0x189DCAD10")]
	private CBIGKEBPCGM NAFPLPBGLBA(Color[] LDAMGPGPNCL, bool JBNENHOIFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x9DBB090", Offset = "0x9DB9A90", VA = "0x189DBB090")]
	private EMHJNGAKLGJ DFKPNOINOFI(uint AHHMDEEHHFP, uint HGANDDOAGAH, uint AMBJECIOABE = 0u)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40")]
	public void DLKJPCNOJFP(Transform EOBBLENOIHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x9DCFF30", Offset = "0x9DCE930", VA = "0x189DCFF30")]
	internal int PHAFKMIFCNM(object CEFJEHJNIAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x9DD0490", Offset = "0x9DCEE90", VA = "0x189DD0490")]
	public int PMMNCDOIMDK(Transform EOBBLENOIHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x9DD03D0", Offset = "0x9DCEDD0", VA = "0x189DD03D0")]
	public int PKOIBEAKIBD(Material CLDFHHJKFAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x9DC0BA0", Offset = "0x9DBF5A0", VA = "0x189DC0BA0")]
	public int HNAENHJLGKM(Light DNABMLFFAHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x9DB8E10", Offset = "0x9DB7810", VA = "0x189DB8E10")]
	public int CHLCBAAOCFK(Camera HJOPGHFLKPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x9DB8710", Offset = "0x9DB7110", VA = "0x189DB8710")]
	[IteratorStateMachine(typeof(EPCJNJMIIHK))]
	public IEnumerable<(int, GNHEIJGFIHM)> CAIDBGEHOEM(Mesh HFCMFMCGELA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x9DB9B10", Offset = "0x9DB8510", VA = "0x189DB9B10")]
	private static void DBCKHJEMHEB(Color GMLILPJAKBM, [Out] Color PDBEMMKOCBP, [Out] float BOBENCENLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x9DCD3E0", Offset = "0x9DCBDE0", VA = "0x189DCD3E0")]
	private static void NOLEEMHMFKA(Vector4 GMLILPJAKBM, [Out] Vector2 DILGPPEHCGK, [Out] Vector2 KIOPHNHDMKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x9DC0CF0", Offset = "0x9DBF6F0", VA = "0x189DC0CF0")]
	private bool HOBCPIIAGKI(object[] JCEJMKLBKKB, int MFEKNAPJEAH, int BMOHMBEGMDG, int LILEKHLOIAI, int OEKECJDKABK, int IINMPPDDOBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x9DC1B50", Offset = "0x9DC0550", VA = "0x189DC1B50")]
	public void JBGPGHBADON(float[] HHHDIEJDCEF, object[] EJKNLPOFFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x9DC5E60", Offset = "0x9DC4860", VA = "0x189DC5E60")]
	public void MDLLNMDOKHB(UnityEngine.Object OLCMKMKLADE, string GGDGFENODPM, BDBAMGNDDHA MDFLDMJKGCH, float[] HHHDIEJDCEF, object[] EJKNLPOFFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x9DD0280", Offset = "0x9DCEC80", VA = "0x189DD0280")]
	private void PHKAFPDBENF(object OLCMKMKLADE, string GGDGFENODPM, NGABBCBFCOM IMFCAPGBDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x9DBD580", Offset = "0x9DBBF80", VA = "0x189DBD580")]
	private LNOFLAEECGC FKKPDOHNCAG(Camera FBCKJOLHDHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x9DCE560", Offset = "0x9DCCF60", VA = "0x189DCE560")]
	private EOIBKEKOGFF OFKILHPKMJG(Light APMOHDCEFCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x9DC3930", Offset = "0x9DC2330", VA = "0x189DC3930")]
	public DJNPGCHMDPA MCJMALOHGOO(Material LFOCIKLNJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x9DC24E0", Offset = "0x9DC0EE0", VA = "0x189DC24E0")]
	private DJNPGCHMDPA KAIKBGHJGPE(Material LFOCIKLNJKC, LCMNEMHMEMN POCHLMCAOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x9DC3380", Offset = "0x9DC1D80", VA = "0x189DC3380")]
	private bool LACNLKLLONI(Material POCHLMCAOAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x9DB6E90", Offset = "0x9DB5890", VA = "0x189DB6E90")]
	private bool BIOKDGEGBAF(Material POCHLMCAOAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x9DB6620", Offset = "0x9DB5020", VA = "0x189DB6620")]
	private bool AFOKBAFNBAO(Material POCHLMCAOAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x9DC35F0", Offset = "0x9DC1FF0", VA = "0x189DC35F0")]
	private bool LIAFCAPIHAE(Material POCHLMCAOAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x9DB7960", Offset = "0x9DB6360", VA = "0x189DB7960")]
	private static bool BLNEBKNIMFJ(Shader GJIEMLKGCHL, string FLBFBHGDBLM, ShaderPropertyType AEOGKDPPBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x9DC9040", Offset = "0x9DC7A40", VA = "0x189DC9040")]
	private void MIACOCNEIAB(AEKKEGKCFDG LJPDADGMNIB, Material CLDFHHJKFAI, string DAKEKCCKHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x9DB89B0", Offset = "0x9DB73B0", VA = "0x189DB89B0")]
	public BAJHMIANCIJ CFGDFAILAIM(Texture GIAGKAKEOKD, string DEDCEAPAKEH, Material POCHLMCAOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9DB6D10", Offset = "0x9DB5710", VA = "0x189DB6D10")]
	private LOKGCAFPFCN BEOPICHCMBA(Texture GIAGKAKEOKD, string DEDCEAPAKEH, Material POCHLMCAOAO, [Optional] MIGEAKAJGAO JNAGFKKFJCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x9DBC610", Offset = "0x9DBB010", VA = "0x189DBC610")]
	public EFGIMNBIJHO FGMAMGICKFL(Material POCHLMCAOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x9DC0680", Offset = "0x9DBF080", VA = "0x189DC0680")]
	public void HFKMLNFAHKC(LCMNEMHMEMN LJPDADGMNIB, Material POCHLMCAOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x9DBBE50", Offset = "0x9DBA850", VA = "0x189DBBE50")]
	private void EPMCCODFAEA(LCMNEMHMEMN POCHLMCAOAO, Material LFOCIKLNJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x9DBACA0", Offset = "0x9DB96A0", VA = "0x189DBACA0")]
	private IAMEJICJOMB DDKBLOPHAPF(Material LFOCIKLNJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x9DCFDC0", Offset = "0x9DCE7C0", VA = "0x189DCFDC0")]
	internal static void PAADDEDFDLM(Color HDBNOCOEMLE, [Out] Color CFHPBGGKHEF, [Out] float BOBENCENLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x9DC27B0", Offset = "0x9DC11B0", VA = "0x189DC27B0")]
	public void KJKBHHFDPDI(BEPOCDMOBMH AAPGFEFGBOK, List<DNJHODIHKIP> JGPDJMDCEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x9DBB510", Offset = "0x9DB9F10", VA = "0x189DBB510")]
	private static List<DNJHODIHKIP> DKLNPCFMAKC(IEnumerable<GameObject> AIBHFOFPIBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x9DBAC60", Offset = "0x9DB9660", VA = "0x189DBAC60")]
	public JNFOCPPKDAF DCOPLLMEFPG(GameObject CEENMGBCJEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x9DB66B0", Offset = "0x9DB50B0", VA = "0x189DB66B0")]
	public MANMOFDPDPG BEECOBOGDOJ(string FLBFBHGDBLM, List<DNJHODIHKIP> JGPDJMDCEKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x9DBEF00", Offset = "0x9DBD900", VA = "0x189DBEF00")]
	private GNHEIJGFIHM[] GLGIIOLFDIP(DNJHODIHKIP KDCOFKDIEEM, BEALLOFPNOF HFCMFMCGELA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x9DC0380", Offset = "0x9DBED80", VA = "0x189DC0380")]
	private List<double> GMCEJPEOHEK(SkinnedMeshRenderer FHHDEFAFLFE, Mesh GDJECPNFELE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x9DC0E80", Offset = "0x9DBF880", VA = "0x189DC0E80")]
	private void HPDNBKFFCFH(SkinnedMeshRenderer FHHDEFAFLFE, Mesh GDJECPNFELE, int NKPFFFPAGCC, GNHEIJGFIHM PKPIFEMAIAE, BEALLOFPNOF HFCMFMCGELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x9DC9CC0", Offset = "0x9DC86C0", VA = "0x189DC9CC0")]
	private static bool MKLGCCOEBEM(GNHEIJGFIHM IHELCGCDNOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x9DB9A00", Offset = "0x9DB8400", VA = "0x189DB9A00")]
	private static IOILALGGFDJ CPJDEKPKEIO(MeshTopology NCCLEHGMFFH)
	{
		return default(IOILALGGFDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x9DB6E70", Offset = "0x9DB5870", VA = "0x189DB6E70")]
	private static bool BFKPLBEOCGL(Mesh HFCMFMCGELA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x9DCED50", Offset = "0x9DCD750", VA = "0x189DCED50")]
	private void OMIAFMBNIPE(Transform EOBBLENOIHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x9DBB1C0", Offset = "0x9DB9BC0", VA = "0x189DBB1C0")]
	private Mesh DGKHCOPIJFG(GameObject CEENMGBCJEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x9DC2920", Offset = "0x9DC1320", VA = "0x189DC2920")]
	private Material[] KNCODHBCFDH(GameObject CEENMGBCJEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x9DB8C80", Offset = "0x9DB7680", VA = "0x189DB8C80")]
	private Vector4[] CGEIMAHGMNI(BoneWeight[] DBLEKJHEIKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x9DB85C0", Offset = "0x9DB6FC0", VA = "0x189DB85C0")]
	private Vector4[] BPBGOIAHGIF(BoneWeight[] DBLEKJHEIKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x9DC9A90", Offset = "0x9DC8490", VA = "0x189DC9A90")]
	private string MIDBDBFFELH(HashSet<string> FFOPMFGPPLH, string FLBFBHGDBLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x9DBB400", Offset = "0x9DB9E00", VA = "0x189DBB400")]
	public AEKKEGKCFDG DIBPDKFAGIF(Texture GIAGKAKEOKD, string DEDCEAPAKEH, [Optional] NACOIFEIKPF KKMJMAOLJEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x9DCEC60", Offset = "0x9DCD660", VA = "0x189DCEC60")]
	public AEKKEGKCFDG OINJKFKKAJK(Material CLDFHHJKFAI, Texture GIAGKAKEOKD, string DEDCEAPAKEH, [Optional] NACOIFEIKPF KKMJMAOLJEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x9DC2A20", Offset = "0x9DC1420", VA = "0x189DC2A20")]
	public MIGEAKAJGAO KOIHJIELOGM(Texture COFBIBGIOKF, string DEDCEAPAKEH, [Optional] NACOIFEIKPF KKMJMAOLJEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x9DD0620", Offset = "0x9DCF020", VA = "0x189DD0620")]
	private string PNPONOGPENL(Texture GIAGKAKEOKD, NACOIFEIKPF GAJLKJNKEKH, string DEDCEAPAKEH, [Out] bool IAJKGLKGFCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x9DB7A00", Offset = "0x9DB6400", VA = "0x189DB7A00")]
	private NEOOHBGCDPE BLPCBHKDGOJ(BDKCOOLEBKG KHOAEJLFEIB, string DEDCEAPAKEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4901DC0", Offset = "0x49007C0", VA = "0x184901DC0")]
	private bool EFKKJLCEFIB(NACOIFEIKPF GAJLKJNKEKH, Texture GIAGKAKEOKD, [Out] string HODLOHIDPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50")]
	private byte[] BNJDJAJJMAF(Texture GIAGKAKEOKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x9DB97A0", Offset = "0x9DB81A0", VA = "0x189DB97A0")]
	private bool CIODFHBMJFC(Texture LNEGFOFIDBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x9DC3570", Offset = "0x9DC1F70", VA = "0x189DC3570")]
	private bool LGBKJMKELLE(string PNIDKKDGNMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x9DB8BB0", Offset = "0x9DB75B0", VA = "0x189DB8BB0")]
	private bool CGDFNLOJLAA(string PNIDKKDGNMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x9DBDA20", Offset = "0x9DBC420", VA = "0x189DBDA20")]
	private NEOOHBGCDPE GGJDEFHNJKB(BDKCOOLEBKG KHOAEJLFEIB, string DEDCEAPAKEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x9DC8800", Offset = "0x9DC7200", VA = "0x189DC8800")]
	private DEPAKAIGHNH MELHBAJDEMI(Texture GIAGKAKEOKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Flags]
public enum KNKBNECCKDI
{
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	Meshes = 1,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	Textures = 2
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum AIFKJAJBNEC
{
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	LowQuality,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	HighQuality
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class FCHIMHCBINK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public IGJJAMLKKOF LGLHPABIAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public JEOKGPMFBLN BJJMELGEDDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public AsyncCoroutineHelper HCNIJNKNGPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public bool KOAPHJMGADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public MJFAFDPCCIM KIANGOGILCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public bool PJKIGPHHANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public KNKBNECCKDI HCPCCCGIJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public bool LJDNADOLLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public FDNLENBNCDB NINCELLDMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public FDNLENBNCDB LBOIADNNNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public bool BJOLAHCAMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public IEABPFFNPJE HDAJOKCACEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public AIFKJAJBNEC CHGJBHHDBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public BlendShapeFrameWeightSetting IMEDLMDMOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public IGCMHMGLAFB NHGCFHGAHJC;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public ILogger DADGPCINNEJ;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x9DD6F00", Offset = "0x9DD5900", VA = "0x189DD6F00")]
	public FCHIMHCBINK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum IEABPFFNPJE
{
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	ImportAndActive,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	ImportAndCameraDisabled
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public enum MJFAFDPCCIM
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
public struct KFPCDMLIDNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public bool KEDKJAONFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public int MCIPHICADBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public int OCEMKGPBDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public int CFFCMPPNJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public int DADKCNCGLLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public int KAIJJOADHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public int OLLHFEPHKHD;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public float PHFLOHEHEMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9DE5BD0", Offset = "0x9DE45D0", VA = "0x189DE5BD0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x9DE5C00", Offset = "0x9DE4600", VA = "0x189DE5C00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct NKEIEOFDLEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public long BCONNHHNCEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public long MCBFPBEPDOA;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public delegate float[] KAPHOOGFLKC(KHJIHCHAIMO GPCDCFCPGFK, int POOICGLOBBE);
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class JGLMIIHJDFL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public enum FEFBFHBIACA
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
	protected struct NAGMCHKHNLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public Stream JGEIGCGPHON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public long JOIPDAFHJOC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class JLEIGLBOJEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public Texture IBEMOGNKKEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public int IPHIJAHGDOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public double CGKODIEHNPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public Vector2 MPEIPFAGFHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public double MBCEPOHNHOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public Vector2 FKKBOCKEFLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public int? HILKMAHPGEB;

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x9DE5AE0", Offset = "0x9DE44E0", VA = "0x189DE5AE0")]
		public JLEIGLBOJEI()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct OPCKMLLNPIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public IProgress<KFPCDMLIDNC> progress;

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
		[Cpp2IlInjected.Address(RVA = "0x9DE6C30", Offset = "0x9DE5630", VA = "0x189DE6C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x9DE8080", Offset = "0x9DE6A80", VA = "0x189DE8080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct IGKJNDPPGON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private LCMNEMHMEMN <def>5__3;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x9DD8400", Offset = "0x9DD6E00", VA = "0x189DD8400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x9DD8850", Offset = "0x9DD7250", VA = "0x189DD8850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class KIMLPFBFOPH
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
			public KIMLPFBFOPH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			private LCMNEMHMEMN <def>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x9DE8480", Offset = "0x9DE6E80", VA = "0x189DE8480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x9DE88B0", Offset = "0x9DE72B0", VA = "0x189DE88B0", Slot = "5")]
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
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public KIMLPFBFOPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9DE6000", Offset = "0x9DE4A00", VA = "0x189DE6000")]
		[AsyncStateMachine(typeof(<<LoadMaterialAsync>b__0>d))]
		internal Task MKCCIBGNIKN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct CPOLKCBDIIH : IAsyncStateMachine
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
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private KIMLPFBFOPH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9DD5300", Offset = "0x9DD3D00", VA = "0x189DD5300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9DD5610", Offset = "0x9DD4010", VA = "0x189DD5610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class ABJKFGCCIAD
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
			public ABJKFGCCIAD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			private BEALLOFPNOF <def>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x9DE8910", Offset = "0x9DE7310", VA = "0x189DE8910", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x9DE8ED0", Offset = "0x9DE78D0", VA = "0x189DE8ED0", Slot = "5")]
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
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public ABJKFGCCIAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x9DD2E70", Offset = "0x9DD1870", VA = "0x189DD2E70")]
		[AsyncStateMachine(typeof(<<LoadMeshAsync>b__0>d))]
		internal Task KIMLPCHKANO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct OLGFMFMGFDJ : IAsyncStateMachine
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
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private ABJKFGCCIAD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x9DE6880", Offset = "0x9DE5280", VA = "0x189DE6880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9DE6BC0", Offset = "0x9DE55C0", VA = "0x189DE6BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class JFDHDELDJCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public JNPBKMIAFKH dataLoader2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public string jsonFilePath;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public JFDHDELDJCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9DD88B0", Offset = "0x9DD72B0", VA = "0x189DD88B0")]
		internal Stream NBBCKPKKEJK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x9DD89A0", Offset = "0x9DD73A0", VA = "0x189DD89A0")]
		internal void OHPALMLBONH()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct AKJIABKBDPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public string jsonFilePath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private JFDHDELDJCI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private TaskAwaiter<Stream> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x9DD3430", Offset = "0x9DD1E30", VA = "0x189DD3430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x9DD3BE0", Offset = "0x9DD25E0", VA = "0x189DD3BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct DLCMGLJOJCB : IAsyncStateMachine
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
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public bool showSceneObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private DEMHKDOKLMC <scene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9DD5680", Offset = "0x9DD4080", VA = "0x189DD5680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9DD6480", Offset = "0x9DD4E80", VA = "0x189DD6480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct CKEOEJHGCBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public AsyncTaskMethodBuilder<BFJLBGEAFBP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public NIBDKOGDPGA bufferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9DEA9E0", Offset = "0x9DE93E0", VA = "0x189DEA9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9DEAC70", Offset = "0x9DE9670", VA = "0x189DEAC70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct JIPOAHHGEDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public int nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private BEPOCDMOBMH <node>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private OGEIALOLHEK <lodsExtension>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9DF5760", Offset = "0x9DF4160", VA = "0x189DF5760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9DF6370", Offset = "0x9DF4D70", VA = "0x189DF6370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct CBHKGJJJFEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public AsyncTaskMethodBuilder<(Vector3, Quaternion, Vector3)[]> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public BEPOCDMOBMH node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private HFGLIDLAEEJ <positionsAttr>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private HFGLIDLAEEJ <rotationAttr>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private HFGLIDLAEEJ <scaleAttr>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private EXT_mesh_gpu_instancing <extMeshGPUInstancing>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private int <instancesCount>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private TaskAwaiter<HFGLIDLAEEJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9DE9D20", Offset = "0x9DE8720", VA = "0x189DE9D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9DEA970", Offset = "0x9DE9370", VA = "0x189DEA970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class BMEOIALCJLK
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
			public BMEOIALCJLK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public bool onlyMesh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public bool ignoreMesh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			private List<JNFOCPPKDAF>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			private BEALLOFPNOF <mesh>5__3;

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
			[Cpp2IlInjected.Address(RVA = "0x9DFC4A0", Offset = "0x9DFAEA0", VA = "0x189DFC4A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x9DFDF20", Offset = "0x9DFC920", VA = "0x189DFDF20", Slot = "5")]
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
		public BEPOCDMOBMH node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public int nodeIndex;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public BMEOIALCJLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x9DE9C00", Offset = "0x9DE8600", VA = "0x189DE9C00")]
		[AsyncStateMachine(typeof(<<ConstructNode>g__CreateNodeComponentsAndChilds|0>d))]
		internal Task NCFMCJDONFP(bool ignoreMesh, bool onlyMesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9DE9B90", Offset = "0x9DE8590", VA = "0x189DE9B90")]
		internal Material GLLFPFNEKGO(GNHEIJGFIHM p)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct CKNINAMKODN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public BEPOCDMOBMH node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public int nodeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private BMEOIALCJLK <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x9DEACE0", Offset = "0x9DE96E0", VA = "0x189DEACE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x9DEBEF0", Offset = "0x9DEA8F0", VA = "0x189DEBEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct MNNDAGGCLLC : IAsyncStateMachine
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
		public BEPOCDMOBMH node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private List<JNFOCPPKDAF>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x9DF7BB0", Offset = "0x9DF65B0", VA = "0x189DF7BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF8160", Offset = "0x9DF6B60", VA = "0x189DF8160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct GBBHHADLNHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public int bufferIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public HPGPKKBHOBO buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private TaskAwaiter<Stream> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x9DECE50", Offset = "0x9DEB850", VA = "0x189DECE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x9DED6E0", Offset = "0x9DEC0E0", VA = "0x189DED6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct LIJIGPPGDHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public DEMHKDOKLMC scene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public bool showSceneObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public JGLMIIHJDFL <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x9DF7070", Offset = "0x9DF5A70", VA = "0x189DF7070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x9DF7B50", Offset = "0x9DF6550", VA = "0x189DF7B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct NPIIOPAACEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public Func<Task> callback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x9DF81C0", Offset = "0x9DF6BC0", VA = "0x189DF81C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x9DF87F0", Offset = "0x9DF71F0", VA = "0x189DF87F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct ALKCAJLPLKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x9DE9910", Offset = "0x9DE8310", VA = "0x189DE9910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x9DE9B30", Offset = "0x9DE8530", VA = "0x189DE9B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct KAEMICLCIOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public BDBAMGNDDHA animation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public int animationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private Dictionary<int, string> <typeMap>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private AGEILGOKDIA[] <samplers>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private Dictionary<string, List<HFGLIDLAEEJ>> <samplersByType>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private LPBNOODMOHI <samplerDef>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private TaskAwaiter<BFJLBGEAFBP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x9DF63E0", Offset = "0x9DF4DE0", VA = "0x189DF63E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x9DF7010", Offset = "0x9DF5A10", VA = "0x189DF7010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct GAPHICLGHCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public BDBAMGNDDHA animation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public ECKFPJOMPLC animationCache;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class HOEEKKACPKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public PILGHGOCPEH pointerData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public KAPHOOGFLKC <>9__6;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public HOEEKKACPKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF5720", Offset = "0x9DF4120", VA = "0x189DF5720")]
		internal float[] POFINDLCDHA(KHJIHCHAIMO data, int frame)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class EEOIFEMANFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public bool flipRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public int targetCount;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public EEOIFEMANFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x9DEBF50", Offset = "0x9DEA950", VA = "0x189DEBF50")]
		internal float[] HFNAIIHIJGJ(KHJIHCHAIMO data, int frame)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class GLDAEBFNCII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public float[] frameFloats;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public BlendShapeFrameWeightSetting blendShapeFrameWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public EEOIFEMANFG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public GLDAEBFNCII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x9DED740", Offset = "0x9DEC140", VA = "0x189DED740")]
		internal float[] ALIOMLNOFKG(KHJIHCHAIMO data, int frame)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct OMNODPCFGGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public AsyncTaskMethodBuilder<AnimationClip> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public int animationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private GAPHICLGHCD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public Transform root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private HOEEKKACPKF <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private AnimationClip <clip>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private int[] <nodeIds>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private BECPIGNOPHI <pointerImportContext>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private List<LBAIMCOCNJN>.Enumerator <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private LBAIMCOCNJN <channel>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private bool <usesPointer>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private AGEILGOKDIA <samplerCache>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private ENJNJPCLDLN <path>5__9;

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
		[Cpp2IlInjected.Address(RVA = "0x9DF8850", Offset = "0x9DF7250", VA = "0x189DF8850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x9DFC430", Offset = "0x9DFAE30", VA = "0x189DFC430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct FDGKPIALJAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public BEPOCDMOBMH node;

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
		private OGEIALOLHEK <lodsExtension>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x9DEC1F0", Offset = "0x9DEABF0", VA = "0x189DEC1F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x9DECDF0", Offset = "0x9DEB7F0", VA = "0x189DECDF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct EIOFGAJBDGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public EHPELOKNIJO mapper;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct HBBLAPKNDEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public LCMNEMHMEMN def;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private EIOFGAJBDGL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public int materialIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private PGPBAJCAKOJ <mrMapper>5__2;

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
		private FPHEDNBNLKO <sgMapper>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private BMCPPHAHCDI <unlitMapper>5__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private AGEMADHDELI <sheenMapper>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private PCNDHHHGBKH <anisotropyMapper>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private ODLMDEOLOML <transmissionMapper>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private NOONMLCANNM <volumeMapper>5__17;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private GAIINLHPPHJ <iridescenceMapper>5__18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private GBHGKLFEDAK <specularMapper>5__19;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private PBIBBBPNCCL <clearcoatMapper>5__20;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private GJGCMGPHBPO <uniformMapper>5__21;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private EFGIMNBIJHO <pbr>5__22;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private MIGEAKAJGAO <textureId>5__23;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private JKNJIHIBNBG <specGloss>5__24;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private KHR_materials_sheen <sheen>5__25;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private TaskAwaiter<JLEIGLBOJEI> <>u__2;

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
		private NBKIOHDNAAC <clearcoatNormalMapper>5__32;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x9DED810", Offset = "0x9DEC210", VA = "0x189DED810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x9DF56C0", Offset = "0x9DF40C0", VA = "0x189DF56C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct PGJGPDHALBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public GNHEIJGFIHM primitive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x9E13390", Offset = "0x9E11D90", VA = "0x189E13390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x9E13630", Offset = "0x9E12030", VA = "0x189E13630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct GNEOLOFKDGB : IAsyncStateMachine
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
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public int meshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public BEALLOFPNOF mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private HBLHJMLFBIB <meshCache>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private BCPDNECGOAF <unityData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x9E075E0", Offset = "0x9E05FE0", VA = "0x189E075E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x9E08030", Offset = "0x9E06A30", VA = "0x189E08030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct ICDHCPMCLDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public BEALLOFPNOF mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x9E094F0", Offset = "0x9E07EF0", VA = "0x189E094F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x9E096F0", Offset = "0x9E080F0", VA = "0x189E096F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct BHECIKDCKBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int meshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public BCPDNECGOAF unityMeshData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private Mesh <mesh>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x9E02180", Offset = "0x9E00B80", VA = "0x189E02180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x9E032A0", Offset = "0x9E01CA0", VA = "0x189E032A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct JEIOHHKOIAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public GNHEIJGFIHM primitive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public int meshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public int primitiveIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private List<Dictionary<string, HFGLIDLAEEJ>> <newTargets>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private Dictionary<string, CBIGKEBPCGM>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private KeyValuePair<string, CBIGKEBPCGM> <targetAttribute>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private int <bufferID>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private TaskAwaiter<BFJLBGEAFBP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x9E099D0", Offset = "0x9E083D0", VA = "0x189E099D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x9E0A9E0", Offset = "0x9E093E0", VA = "0x189E0A9E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct NPGIKOHKCJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private int <meshIndex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private BEALLOFPNOF <gltfMesh>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x9E0BD60", Offset = "0x9E0A760", VA = "0x189E0BD60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x9E0C420", Offset = "0x9E0AE20", VA = "0x189E0C420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct JMAJIPGGJHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public MANMOFDPDPG meshId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public BEALLOFPNOF mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private int <meshIndex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private GNHEIJGFIHM <primitive>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x9E0AA40", Offset = "0x9E09440", VA = "0x189E0AA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x9E0B090", Offset = "0x9E09A90", VA = "0x189E0B090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct PJPAABLGJAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public int meshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public int primitiveIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public GNHEIJGFIHM primitive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private HBLHJMLFBIB.NJDNEAHEOIL <primData>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private Dictionary<string, CBIGKEBPCGM>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private KeyValuePair<string, CBIGKEBPCGM> <attributePair>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private PHHLDJDLBGC <sparse>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private TaskAwaiter<BFJLBGEAFBP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private HFGLIDLAEEJ <sparseValues>5__6;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x9E13690", Offset = "0x9E12090", VA = "0x189E13690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x9E14790", Offset = "0x9E13190", VA = "0x189E14790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct PGGPNAOAOMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public ODGKCBIKJHA skin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public JGLMIIHJDFL <>4__this;

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
		private TaskAwaiter<BFJLBGEAFBP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private int <i>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x9E12850", Offset = "0x9E11250", VA = "0x189E12850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x9E13330", Offset = "0x9E11D30", VA = "0x189E13330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private struct HCLECNNPBPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x9E08090", Offset = "0x9E06A90", VA = "0x189E08090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x9E08510", Offset = "0x9E06F10", VA = "0x189E08510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private struct HFCIAFOCGPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public AsyncTaskMethodBuilder<JLEIGLBOJEI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public AEKKEGKCFDG textureInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public bool isNormal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private JLEIGLBOJEI <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private MIGEAKAJGAO <textureId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x9E08570", Offset = "0x9E06F70", VA = "0x189E08570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x9E08B40", Offset = "0x9E07540", VA = "0x189E08B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct CLBDKOMNLKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public int imageCacheIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public COBELDDAPPH image;

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
		[Cpp2IlInjected.Address(RVA = "0x9E04CF0", Offset = "0x9E036F0", VA = "0x189E04CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x9E050A0", Offset = "0x9E03AA0", VA = "0x189E050A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct DANBGDJLFBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public DHNJMKCGALD texture;

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
		[Cpp2IlInjected.Address(RVA = "0x9E05100", Offset = "0x9E03B00", VA = "0x189E05100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x9E05880", Offset = "0x9E04280", VA = "0x189E05880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct HLCAKKNEEMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public bool markGpuOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public COBELDDAPPH image;

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
		[Cpp2IlInjected.Address(RVA = "0x9E08BB0", Offset = "0x9E075B0", VA = "0x189E08BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x9E09480", Offset = "0x9E07E80", VA = "0x189E09480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct OJLKMIMABGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public bool isLinear;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public COBELDDAPPH image;

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
		private BFJLBGEAFBP <bufferView>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private TaskAwaiter<BFJLBGEAFBP> <>u__1;

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
		[Cpp2IlInjected.Address(RVA = "0x9E0D870", Offset = "0x9E0C270", VA = "0x189E0D870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x9E0F680", Offset = "0x9E0E080", VA = "0x189E0F680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct OJFAHLJPKCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public int textureIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public DHNJMKCGALD texture;

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
		private COBELDDAPPH <image>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private bool <isFirstInstance>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x9E0C480", Offset = "0x9E0AE80", VA = "0x189E0C480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x9E0D810", Offset = "0x9E0C210", VA = "0x189E0D810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct NJBCKCILJGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public AsyncTaskMethodBuilder<HFGLIDLAEEJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public JGLMIIHJDFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public CBIGKEBPCGM accessorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public bool isPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private AEDLGEMLKKC <accessor>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private TaskAwaiter<BFJLBGEAFBP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x9E0B3D0", Offset = "0x9E09DD0", VA = "0x189E0B3D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x9E0B8E0", Offset = "0x9E0A2E0", VA = "0x189E0B8E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public int LNBKGPFKMFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public int IJEGPHKMIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private bool JJMCADFCMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private bool NOAKLOJAGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private Dictionary<Stream, NativeArray<byte>> ENDDONFFGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public bool PMJEBMCNFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public bool FFBPGOJJEBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public bool EDGIBGNAJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x63")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public bool NGDMJLJOBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public bool JDABLGPNJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public NKEIEOFDLEA LDMJMNEBFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	protected FCHIMHCBINK NHIAHPGIPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	protected NDGAEMHCBHB LEDIHOAMOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	protected GameObject LOJCFDPGIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	protected readonly LCMNEMHMEMN GIMGHHOFMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	internal PFOGFFHBAHP NPJPDOMLLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	protected string MALOKMEIJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	protected NAGMCHKHNLI OPNFJFJEIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	protected EFAGEPFJOIC BDOKGMGGBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	protected LHNOLCAEJGH LJHGOKDADJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	protected bool BGMILOHGHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	protected KFPCDMLIDNC PIJADNDOJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	protected IProgress<KFPCDMLIDNC> LEHODIGOOEA;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static ILogger IBCCEPEBFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	protected ColorSpace PDAHIAFCKHF;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	internal static List<Texture> BKFEPOHAEPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private Dictionary<int, int> EAHBHOAKCIM;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool JJNLCNNIKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x9DDA580", Offset = "0x9DD8F80", VA = "0x189DDA580")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA87B30", Offset = "0xA86530", VA = "0x180A87B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public EFAGEPFJOIC BDILIHENIPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xE93590", Offset = "0xE91F90", VA = "0x180E93590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Transform KGKKMJPPAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public GameObject EOEOIIMMLLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private AnimationClip[] ADAPPKACNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public FEFBFHBIACA NMMAJFEKCNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xAA3B30", Offset = "0xAA2530", VA = "0x180AA3B30")]
		[CompilerGenerated]
		get
		{
			return default(FEFBFHBIACA);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xEAC2E0", Offset = "0xEAACE0", VA = "0x180EAC2E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public string NDGCIADFPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA91C70", Offset = "0xA90670", VA = "0x180A91C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA88530", Offset = "0xA86F30", VA = "0x180A88530")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public GameObject DGCHCMMJEIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA909D0", Offset = "0xA8F3D0", VA = "0x180A909D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public EJCFPFKPJLJ[] IDOIKOACIHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x9DDEA50", Offset = "0x9DDD450", VA = "0x189DDEA50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public PFOGFFHBAHP[] PIANMBBAANM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x9DD8C50", Offset = "0x9DD7650", VA = "0x189DD8C50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public List<UnityEngine.Object> FIAJNKLJJJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA84210", Offset = "0xA82C10", VA = "0x180A84210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	protected IGCMHMGLAFB BEPAAGAEPJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x9DDE770", Offset = "0x9DDD170", VA = "0x189DDE770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x9DE56C0", Offset = "0x9DE40C0", VA = "0x189DE56C0")]
	public JGLMIIHJDFL(string KCOABCKIPCG, FCHIMHCBINK HHMKDMNANOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x9DE59E0", Offset = "0x9DE43E0", VA = "0x189DE59E0")]
	public JGLMIIHJDFL(Stream KODLEFJJPHE, FCHIMHCBINK HHMKDMNANOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x9DE5710", Offset = "0x9DE4110", VA = "0x189DE5710")]
	private JGLMIIHJDFL(FCHIMHCBINK HHMKDMNANOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x9DE15D0", Offset = "0x9DDFFD0", VA = "0x189DE15D0")]
	private NativeArray<byte> KLDFJAFFCLI(Stream AKDFBDNJGIO)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x9DDE380", Offset = "0x9DDCD80", VA = "0x189DDE380")]
	private void FHFKAGDCEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x9DDC3D0", Offset = "0x9DDADD0", VA = "0x189DDC3D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x9DDBF20", Offset = "0x9DDA920", VA = "0x189DDBF20")]
	[AsyncStateMachine(typeof(OPCKMLLNPIN))]
	public Task DHKNGMBBCFH(int HKMFODDFBIF = -1, bool KHFMCMMKJGL = true, [Optional] Action<GameObject, ExceptionDispatchInfo> PCLEHFGFJKM, [Optional] CancellationToken OMJKEHOJJFF, [Optional] IProgress<KFPCDMLIDNC> LEHODIGOOEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x9DE1500", Offset = "0x9DDFF00", VA = "0x189DE1500")]
	[AsyncStateMachine(typeof(IGKJNDPPGON))]
	private Task KGGPEOCGBLF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x9DE2D10", Offset = "0x9DE1710", VA = "0x189DE2D10", Slot = "5")]
	[AsyncStateMachine(typeof(CPOLKCBDIIH))]
	public virtual Task<Material> LODLGINFDGJ(int EHLCELNNEBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x9DDFE30", Offset = "0x9DDE830", VA = "0x189DDFE30", Slot = "6")]
	[AsyncStateMachine(typeof(OLGFMFMGFDJ))]
	public virtual Task<Mesh> IKHIHFMLDAL(int KMJOPMHAPEL, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x9DE4530", Offset = "0x9DE2F30", VA = "0x189DE4530")]
	[AsyncStateMachine(typeof(AKJIABKBDPB))]
	private Task OLBFLEHHNID(string NPDJAHAHDEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x9DD8A30", Offset = "0x9DD7430", VA = "0x189DD8A30")]
	private void AEJPGPCMHHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x9DE2AB0", Offset = "0x9DE14B0", VA = "0x189DE2AB0")]
	[AsyncStateMachine(typeof(DLCMGLJOJCB))]
	protected Task LILFLOLEIDM(int HKMFODDFBIF = -1, bool KHFMCMMKJGL = true, [Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x9DE4100", Offset = "0x9DE2B00", VA = "0x189DE4100")]
	private void NPLDNMLAAMG(DEMHKDOKLMC FPJGDNNEOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x9DDCBD0", Offset = "0x9DDB5D0", VA = "0x189DDCBD0")]
	public NativeArray<byte> ELLACBCDEOJ(BKDGLBNDAOF GNOOBKBDNLH)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x9DE3BD0", Offset = "0x9DE25D0", VA = "0x189DE3BD0")]
	[AsyncStateMachine(typeof(CKEOEJHGCBN))]
	private Task<BFJLBGEAFBP> NNKMNFEAMKM(NIBDKOGDPGA AAEFNJPLLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x9DE1470", Offset = "0x9DDFE70", VA = "0x189DE1470")]
	private float KCFIMPOMJOK(List<double> KKHKPHBKINE, int GCLBNLOCJBD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x9DE2BD0", Offset = "0x9DE15D0", VA = "0x189DE2BD0")]
	[AsyncStateMachine(typeof(JIPOAHHGEDG))]
	private Task<GameObject> LMGNAABPIDK(int KALNIGICCJC, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x9DDE640", Offset = "0x9DDD040", VA = "0x189DDE640")]
	[AsyncStateMachine(typeof(CBHKGJJJFEP))]
	private Task<(Vector3, Quaternion, Vector3)[]> FLKOIKKKGIM(BEPOCDMOBMH AAPGFEFGBOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x9DDC2E0", Offset = "0x9DDACE0", VA = "0x189DDC2E0")]
	private bool DLCACMNGPHG(BEPOCDMOBMH AAPGFEFGBOK, GameObject MKHGLNGIPGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x9DDF9D0", Offset = "0x9DDE3D0", VA = "0x189DDF9D0", Slot = "7")]
	[AsyncStateMachine(typeof(CKNINAMKODN))]
	protected virtual Task HPINGFOKMKM(BEPOCDMOBMH AAPGFEFGBOK, int PBKEGCHOAEH, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x9DE3AB0", Offset = "0x9DE24B0", VA = "0x189DE3AB0")]
	[AsyncStateMachine(typeof(MNNDAGGCLLC))]
	private Task NLFPPCPLOHK(BEPOCDMOBMH AAPGFEFGBOK, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x9DDBE10", Offset = "0x9DDA810", VA = "0x189DDBE10")]
	[AsyncStateMachine(typeof(GBBHHADLNHJ))]
	protected Task DFNIHMLOEKK(HPGPKKBHOBO AEJOONCILAD, int IFNMKOPKJGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x9DDCF10", Offset = "0x9DDB910", VA = "0x189DDCF10", Slot = "8")]
	[AsyncStateMachine(typeof(LIJIGPPGDHF))]
	protected virtual Task EPOFGLABEFJ(DEMHKDOKLMC FPJGDNNEOIB, bool KHFMCMMKJGL, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x9DE49A0", Offset = "0x9DE33A0", VA = "0x189DE49A0", Slot = "9")]
	protected virtual BFJLBGEAFBP PFNBBOFIBMO(int IFNMKOPKJGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x9DE0080", Offset = "0x9DDEA80", VA = "0x189DE0080")]
	private void IMMJLLEIOEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x9DDD050", Offset = "0x9DDBA50", VA = "0x189DDD050")]
	private void FAKPEDAJPFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x9DDB660", Offset = "0x9DDA060", VA = "0x189DDB660")]
	[AsyncStateMachine(typeof(NPIIOPAACEF))]
	private Task DDFGGHLEEBB(Func<Task> EMBEDGKMMHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x9DE3640", Offset = "0x9DE2040", VA = "0x189DE3640")]
	[AsyncStateMachine(typeof(ALKCAJLPLKF))]
	protected Task MOMEHPOCLBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x9DE3F50", Offset = "0x9DE2950", VA = "0x189DE3F50")]
	private static string NPIEPENEJJB(Transform NLDLHIJAJBO, Transform PJFDNMGHMBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x9DDFF60", Offset = "0x9DDE960", VA = "0x189DDFF60", Slot = "10")]
	[AsyncStateMachine(typeof(KAEMICLCIOO))]
	protected virtual Task ILEHJHJKEFM(BDBAMGNDDHA MDFLDMJKGCH, int KMGGKKLABCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x9DD9320", Offset = "0x9DD7D20", VA = "0x189DD9320")]
	protected void BLPCKBDNBMN(AnimationClip MIINEKHOHCC, string ICPMCGFFHKN, string[] ICCAOAPJAGN, KHJIHCHAIMO GMLILPJAKBM, KHJIHCHAIMO PDBEMMKOCBP, GCJBIJIFCIF JFFMBFIHKJN, Type LMDCJPIGAOJ, KAPHOOGFLKC ECFKKMBGCFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x9DE1280", Offset = "0x9DDFC80", VA = "0x189DE1280")]
	private void JNBBLBEGDJI(Keyframe[] GAGIPKKDHOF, int EMIOLDMICBJ, GCJBIJIFCIF NBEEAECOIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x9DDD1E0", Offset = "0x9DDBBE0", VA = "0x189DDD1E0")]
	private static float FDPPBICDDPF(Keyframe[] GAGIPKKDHOF, int EMIOLDMICBJ, bool EPJHLKJKGEN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x9DDEBB0", Offset = "0x9DDD5B0", VA = "0x189DDEBB0")]
	[AsyncStateMachine(typeof(OMNODPCFGGI))]
	protected Task<AnimationClip> GLOBACNPCDE(Transform PJFDNMGHMBL, int KMGGKKLABCC, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x9DDC790", Offset = "0x9DDB190", VA = "0x189DDC790")]
	private bool EGOMFNFDOJD(GameObject MKHGLNGIPGA, BEPOCDMOBMH AAPGFEFGBOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x9DE2F40", Offset = "0x9DE1940", VA = "0x189DE2F40")]
	private bool MEKKNKBFJBC(GameObject MKHGLNGIPGA, BEPOCDMOBMH AAPGFEFGBOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x9DE4860", Offset = "0x9DE3260", VA = "0x189DE4860")]
	[AsyncStateMachine(typeof(FDGKPIALJAF))]
	private Task PDFJAOHBOEO(EFAGEPFJOIC MLPDGDMMEHF, GameObject MKHGLNGIPGA, BEPOCDMOBMH AAPGFEFGBOK, int PBKEGCHOAEH, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x9DDE540", Offset = "0x9DDCF40", VA = "0x189DDE540", Slot = "11")]
	[AsyncStateMachine(typeof(HBBLAPKNDEM))]
	protected virtual Task FHOKPGPLEDA(LCMNEMHMEMN LJPDADGMNIB, int EHLCELNNEBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x9DE1DC0", Offset = "0x9DE07C0", VA = "0x189DE1DC0", Slot = "12")]
	protected virtual Task LIGJELDNADK(LCMNEMHMEMN LJPDADGMNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x9DE00D0", Offset = "0x9DDEAD0", VA = "0x189DE00D0", Slot = "13")]
	protected virtual MJPPPBPOKAA JIPPIMLEBKF(AEKKEGKCFDG LJPDADGMNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x9DD9FD0", Offset = "0x9DD89D0", VA = "0x189DD9FD0", Slot = "14")]
	protected virtual GKLPLEOFHNM CBCOAHFFNHN(LCMNEMHMEMN LJPDADGMNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x9DDC580", Offset = "0x9DDAF80", VA = "0x189DDC580", Slot = "15")]
	protected virtual KHR_materials_transmission EFDHIMDJPGF(LCMNEMHMEMN LJPDADGMNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x9DDFCF0", Offset = "0x9DDE6F0", VA = "0x189DDFCF0", Slot = "16")]
	protected virtual KHR_materials_sheen IDLGIDKMMNJ(LCMNEMHMEMN LJPDADGMNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x9DDEA70", Offset = "0x9DDD470", VA = "0x189DDEA70", Slot = "17")]
	protected virtual KHR_materials_anisotropy GJCCAKCLLHC(LCMNEMHMEMN LJPDADGMNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x9DDB9E0", Offset = "0x9DDA3E0", VA = "0x189DDB9E0", Slot = "18")]
	protected virtual KHR_materials_dispersion DEECABPJBCN(LCMNEMHMEMN LJPDADGMNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x9DE3CE0", Offset = "0x9DE26E0", VA = "0x189DE3CE0", Slot = "19")]
	protected virtual KHR_materials_volume NOGJNCDNBJI(LCMNEMHMEMN LJPDADGMNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x9DE3970", Offset = "0x9DE2370", VA = "0x189DE3970", Slot = "20")]
	protected virtual KHR_materials_ior NKLLJJNLONH(LCMNEMHMEMN LJPDADGMNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x9DE3830", Offset = "0x9DE2230", VA = "0x189DE3830", Slot = "21")]
	protected virtual KHR_materials_iridescence NGMFPMFGDOP(LCMNEMHMEMN LJPDADGMNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x9DDED10", Offset = "0x9DDD710", VA = "0x189DDED10", Slot = "22")]
	protected virtual KHR_materials_specular HDAOIKHEKME(LCMNEMHMEMN LJPDADGMNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x9DDA440", Offset = "0x9DD8E40", VA = "0x189DDA440", Slot = "23")]
	protected virtual KHR_materials_clearcoat CGPDCINPIAA(LCMNEMHMEMN LJPDADGMNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x9DE4440", Offset = "0x9DE2E40", VA = "0x189DE4440")]
	[AsyncStateMachine(typeof(PGJGPDHALBE))]
	private Task OBNIKOGLMHI(GNHEIJGFIHM PKPIFEMAIAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x9DE5110", Offset = "0x9DE3B10", VA = "0x189DE5110", Slot = "24")]
	[AsyncStateMachine(typeof(GNEOLOFKDGB))]
	protected virtual Task PKOEOKHPCAK(BEALLOFPNOF HFCMFMCGELA, int KMJOPMHAPEL, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x9DD8C70", Offset = "0x9DD7670", VA = "0x189DD8C70")]
	[AsyncStateMachine(typeof(ICDHCPMCLDF))]
	private Task AJIAHIOOFOO(BEALLOFPNOF HFCMFMCGELA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x9DDBB20", Offset = "0x9DDA520", VA = "0x189DDBB20")]
	private static uint[] DFBKNKCGHFC(BEALLOFPNOF HFCMFMCGELA, [Out] uint NKLIBCILELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x9DD8F60", Offset = "0x9DD7960", VA = "0x189DD8F60")]
	protected void BAAPJKAEAMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x9DDEF80", Offset = "0x9DDD980", VA = "0x189DDEF80")]
	protected void HEACHNMBOLL(Mesh HFCMFMCGELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x9DDD3C0", Offset = "0x9DDBDC0", VA = "0x189DDD3C0")]
	private BCPDNECGOAF FGAMIFJFKGN(BEALLOFPNOF PDHFPJJNOJI, int KMJOPMHAPEL, bool FIIJFFLCGDD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x9DDEE50", Offset = "0x9DDD850", VA = "0x189DDEE50")]
	[AsyncStateMachine(typeof(BHECIKDCKBC))]
	protected Task HDNNLELHKFB(BCPDNECGOAF JGACIFLGDKG, int KMJOPMHAPEL, string MPONCKBONFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x9DDC060", Offset = "0x9DDAA60", VA = "0x189DDC060")]
	private void DJFCLPGHJEC(BCPDNECGOAF JGACIFLGDKG, int KMJOPMHAPEL, Mesh HFCMFMCGELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x9DE3E20", Offset = "0x9DE2820", VA = "0x189DE3E20", Slot = "25")]
	[AsyncStateMachine(typeof(JEIOHHKOIAJ))]
	protected virtual Task NOLHIHMECOA(GNHEIJGFIHM PKPIFEMAIAE, int KMJOPMHAPEL, int NMJECBGFKHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x9DDA5C0", Offset = "0x9DD8FC0", VA = "0x189DDA5C0", Slot = "26")]
	protected virtual void DAFGLGNAPKE(GNHEIJGFIHM PKPIFEMAIAE, int KMJOPMHAPEL, int NMJECBGFKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x9DE4AB0", Offset = "0x9DE34B0", VA = "0x189DE4AB0")]
	private void PIPBHFJEEEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x9DD8B70", Offset = "0x9DD7570", VA = "0x189DD8B70")]
	[AsyncStateMachine(typeof(NPGIKOHKCJG))]
	private Task AFDDLMLDFNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x9DE2E20", Offset = "0x9DE1820", VA = "0x189DE2E20")]
	[AsyncStateMachine(typeof(JMAJIPGGJHN))]
	private Task MDJOCFFMIGC(BEALLOFPNOF HFCMFMCGELA, MANMOFDPDPG JHKLOOAMEOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x9DDB520", Offset = "0x9DD9F20", VA = "0x189DDB520", Slot = "27")]
	[AsyncStateMachine(typeof(PJPAABLGJAC))]
	protected virtual Task DBHGMOBLNNG(GNHEIJGFIHM PKPIFEMAIAE, int KMJOPMHAPEL, int NMJECBGFKHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x9DE0210", Offset = "0x9DDEC10", VA = "0x189DE0210")]
	protected void JJKPOBLLDAG(HBLHJMLFBIB.NJDNEAHEOIL CMKFCKFIDCL, BCPDNECGOAF JNFCAPONEKD, uint JNGJHNPDMCE, int ONNHGJFLBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x9DE4630", Offset = "0x9DE3030", VA = "0x189DE4630")]
	private void PAGOCKMAKEO(Dictionary<string, HFGLIDLAEEJ> BFFJLAIOEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x9DE5380", Offset = "0x9DE3D80", VA = "0x189DE5380")]
	protected MeshTopology PPBMGFKLNCB(IOILALGGFDJ JFFMBFIHKJN)
	{
		return default(MeshTopology);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x9DDF5D0", Offset = "0x9DDDFD0", VA = "0x189DDF5D0")]
	private void HNDLJONIJGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x9DE34A0", Offset = "0x9DE1EA0", VA = "0x189DE34A0", Slot = "28")]
	[AsyncStateMachine(typeof(PGGPNAOAOMP))]
	protected virtual Task MJAAAHGBJFF(ODGKCBIKJHA NAOAOJKOJPK, SkinnedMeshRenderer BDBIAPPPJPF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x9DDF1D0", Offset = "0x9DDDBD0", VA = "0x189DDF1D0")]
	private void HGHFAOFDAJL(Vector4[] LPOKMKGIIPP, Vector4[] MKGDFJHNEIK, BoneWeight[] MODMCDJAOAP, uint KIOPHNHDMKE = 0u)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x9DDCDC0", Offset = "0x9DDB7C0", VA = "0x189DDCDC0")]
	[AsyncStateMachine(typeof(HCLECNNPBPG))]
	private Task EMFDFMKPJAB(int FILGHJLFKAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x9DE1C80", Offset = "0x9DE0680", VA = "0x189DE1C80")]
	[AsyncStateMachine(typeof(HFCIAFOCGPN))]
	private Task<JLEIGLBOJEI> LHGLGEIHBMB(AEKKEGKCFDG GPICDEMIJPK, bool LLHCACBGKAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x9DE35E0", Offset = "0x9DE1FE0", VA = "0x189DE35E0")]
	private static int MOEPJFINAHM(byte[] GPCDCFCPGFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x9DDA110", Offset = "0x9DD8B10", VA = "0x189DDA110")]
	private Dictionary<int, int> CFFLGGGCIMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x9DE19B0", Offset = "0x9DE03B0", VA = "0x189DE19B0")]
	private void LCPKBNLBLJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x9DDFB10", Offset = "0x9DDE510", VA = "0x189DDFB10")]
	private Stream IBKDLBMJIAD(COBELDDAPPH MCLLPLPMNNL, int EFFDKMBOOHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x9DE5240", Offset = "0x9DE3C40", VA = "0x189DE5240")]
	[AsyncStateMachine(typeof(CLBDKOMNLKD))]
	protected Task POOJNONGGAF(COBELDDAPPH MCLLPLPMNNL, int EFFDKMBOOHA, bool NOAAMMNBFAI, bool IIGKJAENFCE, bool LLHCACBGKAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x9DE3710", Offset = "0x9DE2110", VA = "0x189DE3710")]
	[AsyncStateMachine(typeof(DANBGDJLFBA))]
	protected Task MOPNPNOPFCB(DHNJMKCGALD GIAGKAKEOKD, int BLHHNIHBHJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x9DDE790", Offset = "0x9DDD190", VA = "0x189DDE790")]
	[AsyncStateMachine(typeof(HLCAKKNEEMA))]
	private Task<Texture2D> GCLHHFMANAL(COBELDDAPPH MCLLPLPMNNL, Texture2D GIAGKAKEOKD, NativeArray<byte> GPCDCFCPGFK, bool NOAAMMNBFAI, bool IIGKJAENFCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x9DD91E0", Offset = "0x9DD7BE0", VA = "0x189DD91E0", Slot = "29")]
	[AsyncStateMachine(typeof(OJLKMIMABGK))]
	protected virtual Task BCAMBLLDPAA(Stream AKDFBDNJGIO, bool NOAAMMNBFAI, bool IIGKJAENFCE, bool LLHCACBGKAJ, COBELDDAPPH MCLLPLPMNNL, int EFFDKMBOOHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x9DDC420", Offset = "0x9DDAE20", VA = "0x189DDC420", Slot = "30")]
	protected virtual int EECJFDPEJAP(DHNJMKCGALD GIAGKAKEOKD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x9DDCEA0", Offset = "0x9DDB8A0", VA = "0x189DDCEA0", Slot = "31")]
	protected virtual bool EPJCJAPDNLI(DHNJMKCGALD GIAGKAKEOKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x9DE1870", Offset = "0x9DE0270", VA = "0x189DE1870", Slot = "32")]
	[AsyncStateMachine(typeof(OJFAHLJPKCA))]
	protected virtual Task LCAOBFJGNDL(DHNJMKCGALD GIAGKAKEOKD, int BLHHNIHBHJM, bool NOAAMMNBFAI, bool IIGKJAENFCE, bool LLHCACBGKAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x9DE1140", Offset = "0x9DDFB40", VA = "0x189DE1140")]
	[AsyncStateMachine(typeof(NJBCKCILJGJ))]
	[CompilerGenerated]
	private Task<HFGLIDLAEEJ> JLLMPJMFMNG(CBIGKEBPCGM NGBAPEDEEJE, bool OPNMNEDNIKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x9DDB750", Offset = "0x9DDA150", VA = "0x189DDB750")]
	[CompilerGenerated]
	internal static HFGLIDLAEEJ DDPHMKGKDCO(string KCALMDAEJCM, GAPHICLGHCD P_1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x9DDE8F0", Offset = "0x9DDD2F0", VA = "0x189DDE8F0")]
	[CompilerGenerated]
	private void GEMDBGHBBPJ(MIGEAKAJGAO BAABIJAELGF, MJPPPBPOKAA JIDNFBNIPIA, [Out] Vector2 DILGPPEHCGK, [Out] Vector2 KIOPHNHDMKE, EIOFGAJBDGL P_4)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x9DDC6C0", Offset = "0x9DDB0C0", VA = "0x189DDC6C0")]
	[CompilerGenerated]
	private void EFMFPFDKHJI(EIOFGAJBDGL P_0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x9DD8D70", Offset = "0x9DD7770", VA = "0x189DD8D70")]
	[CompilerGenerated]
	private void AMFDGNANFDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x9DD9CB0", Offset = "0x9DD86B0", VA = "0x189DD9CB0")]
	[CompilerGenerated]
	private TextureWrapMode BPAPNCBFNIB(HGKKMGONOAN NBAFHDNNFBL)
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
		public enum PCNIGJHDEBA
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
		private sealed class GFGCPKKKOFD<T> where T : GLTFPlugin
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			public Type pluginType;

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
			public GFGCPKKKOFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x4F566C0", Offset = "0x4F550C0", VA = "0x184F566C0")]
			internal bool MDJJBNHHDND(T p)
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
		private PCNIGJHDEBA blendShapeExportProperties;

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
			[Cpp2IlInjected.Address(RVA = "0x9E07090", Offset = "0x9E05A90", VA = "0x189E07090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool ExportNames
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xAB3420", Offset = "0xAB1E20", VA = "0x180AB3420")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xAB31A0", Offset = "0xAB1BA0", VA = "0x180AB31A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool ExportFullPath
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0xF26B10", Offset = "0xF25510", VA = "0x180F26B10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x157F750", Offset = "0x157E150", VA = "0x18157F750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool UseMainCameraVisibility
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x1C890E0", Offset = "0x1C87AE0", VA = "0x181C890E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x2A04F70", Offset = "0x2A03970", VA = "0x182A04F70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool TryExportTexturesFromDisk
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xEBDB60", Offset = "0xEBC560", VA = "0x180EBDB60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xEF2790", Offset = "0xEF1190", VA = "0x180EF2790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool UseTextureFileTypeHeuristic
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xEF2420", Offset = "0xEF0E20", VA = "0x180EF2420")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xEF2840", Offset = "0xEF1240", VA = "0x180EF2840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool ExportVertexColors
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x7645E40", Offset = "0x7644840", VA = "0x187645E40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x76FF670", Offset = "0x76FE070", VA = "0x1876FF670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public int DefaultJpegQuality
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xAA3B30", Offset = "0xAA2530", VA = "0x180AA3B30")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xEAC2E0", Offset = "0xEAACE0", VA = "0x180EAC2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool ExportDisabledGameObjects
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x29DE140", Offset = "0x29DCB40", VA = "0x1829DE140")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x8522CD0", Offset = "0x85216D0", VA = "0x188522CD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool ExportAnimations
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xF91F00", Offset = "0xF90900", VA = "0x180F91F00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xF91390", Offset = "0xF8FD90", VA = "0x180F91390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool BakeAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xF91F10", Offset = "0xF90910", VA = "0x180F91F10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xF91F90", Offset = "0xF90990", VA = "0x180F91F90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		[Obsolete("Add/remove \"AnimationPointerPlugin\" from ExportPlugins instead.")]
		public bool UseAnimationPointer
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x9E070A0", Offset = "0x9E05AA0", VA = "0x189E070A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x9E071E0", Offset = "0x9E05BE0", VA = "0x189E071E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool UniqueAnimationNames
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xF91F30", Offset = "0xF90930", VA = "0x180F91F30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xF91F20", Offset = "0xF90920", VA = "0x180F91F20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool BlendShapeExportSparseAccessors
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x192DCA0", Offset = "0x192C6A0", VA = "0x18192DCA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x193BDC0", Offset = "0x193A7C0", VA = "0x18193BDC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public PCNIGJHDEBA BlendShapeExportProperties
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xAF1310", Offset = "0xAEFD10", VA = "0x180AF1310")]
			get
			{
				return default(PCNIGJHDEBA);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xAF1670", Offset = "0xAF0070", VA = "0x180AF1670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool BakeSkinnedMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x9E07080", Offset = "0x9E05A80", VA = "0x189E07080")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x9E071D0", Offset = "0x9E05BD0", VA = "0x189E071D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x9E06B70", Offset = "0x9E05570", VA = "0x189E06B70")]
		internal string JPDLCALDDCN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x9E06870", Offset = "0x9E05270", VA = "0x189E06870")]
		public static GLTFSettings EMCNPAKALMK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x9E06740", Offset = "0x9E05140", VA = "0x189E06740")]
		public static GLTFSettings CPGNGPBKAOH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x9E06A40", Offset = "0x9E05440", VA = "0x189E06A40")]
		public static bool IKMOJOBCAIC([Out] GLTFSettings IMFNJOKFKEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x9E067B0", Offset = "0x9E051B0", VA = "0x189E067B0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ClearStatics()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x9E06380", Offset = "0x9E04D80", VA = "0x189E06380")]
		private static void BKEBPFBCOOB(GLTFSettings IMFNJOKFKEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x9E06F80", Offset = "0x9E05980", VA = "0x189E06F80")]
		public GLTFSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3C74A50", Offset = "0x3C73450", VA = "0x183C74A50")]
		[CompilerGenerated]
		internal static List<Type> KKHFDOJJMOA<T>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x3C74650", Offset = "0x3C73050", VA = "0x183C74650")]
		[CompilerGenerated]
		internal static void HFJONPBFKLL<T>(List<T> BCHECOPOLLM) where T : GLTFPlugin
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class ShaderNotFoundException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x9E14B10", Offset = "0x9E13510", VA = "0x189E14B10")]
		public ShaderNotFoundException()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x9E14A60", Offset = "0x9E13460", VA = "0x189E14A60")]
		public ShaderNotFoundException(string ONGDPODJNBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x9E14AC0", Offset = "0x9E134C0", VA = "0x189E14AC0")]
		protected ShaderNotFoundException(SerializationInfo LJOFOOFMAON, StreamingContext HCLPHJDKMCA)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class NFBHPIEMGML : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x9E0B370", Offset = "0x9E09D70", VA = "0x189E0B370")]
	public NFBHPIEMGML(string ONGDPODJNBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class OOCODNEBMDD : ILogHandler
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private readonly StringBuilder AHDCFMKAOPA;

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x9E0FA80", Offset = "0x9E0E480", VA = "0x189E0FA80")]
	private string EOLMLDJEEDM(LogType DCEAOLCIOHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x9E0FD10", Offset = "0x9E0E710", VA = "0x189E0FD10", Slot = "4")]
	public void LogFormat(LogType DCEAOLCIOHK, UnityEngine.Object HCLPHJDKMCA, string NANAIMNHOFH, params object[] GACFFBLMJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x9E0FC70", Offset = "0x9E0E670", VA = "0x189E0FC70", Slot = "5")]
	public void LogException(Exception CMHNFFEOOMC, UnityEngine.Object HCLPHJDKMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x9E0FB00", Offset = "0x9E0E500", VA = "0x189E0FB00")]
	public void JFOOJHNHLLB(string NANAIMNHOFH = "{0}")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x9E0FDD0", Offset = "0x9E0E7D0", VA = "0x189E0FDD0")]
	public OOCODNEBMDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class PLBAMBAEKLG
{
	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x9E14880", Offset = "0x9E13280", VA = "0x189E14880")]
	public static string GFIGKEFGGKM(Uri HLLDFJPPNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x9E149F0", Offset = "0x9E133F0", VA = "0x189E149F0")]
	public static string HJHMPFBHMBI(string PDDBNENKIGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x9E148E0", Offset = "0x9E132E0", VA = "0x189E148E0")]
	public static void GOMMMLOLNDC(string HLLDFJPPNON, [Out] byte[] JIJHHLEOJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x9E147F0", Offset = "0x9E131F0", VA = "0x189E147F0")]
	public static bool EGOJCPBAIMJ(string HLLDFJPPNON)
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
		private AFHEPOOAMDB MFNFONHGHGF;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public AFHEPOOAMDB KMMIMFFGDAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x9E09970", Offset = "0x9E08370", VA = "0x189E09970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x9E09840", Offset = "0x9E08240", VA = "0x189E09840")]
		public InstantiatedGLTFObject Duplicate()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x9E09920", Offset = "0x9E08320", VA = "0x189E09920")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xA85A30", Offset = "0xA84430", VA = "0x180A85A30")]
		public InstantiatedGLTFObject()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public struct BlendShapeFrameWeightSetting
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public enum OPOIBHAHNJC
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
		internal OPOIBHAHNJC _option;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		[SerializeField]
		internal float _multiplier;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float Multiplier
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x9E04C60", Offset = "0x9E03660", VA = "0x189E04C60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x9E04C50", Offset = "0x9E03650", VA = "0x189E04C50")]
		public BlendShapeFrameWeightSetting(OPOIBHAHNJC JFODLPOMLPE)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x9E04BC0", Offset = "0x9E035C0", VA = "0x189E04BC0")]
		public static float LHJBCIIELME(BlendShapeFrameWeightSetting ANOGGBMBOOO)
		{
			return default(float);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public enum FDNLENBNCDB
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
		public abstract JGLMIIHJDFL DIPJGCHHJPA(string KCOABCKIPCG, FCHIMHCBINK HHMKDMNANOF);

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xD12090", Offset = "0xD10A90", VA = "0x180D12090")]
		protected ImporterFactory()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class DefaultImporterFactory : ImporterFactory
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x9E05C40", Offset = "0x9E04640", VA = "0x189E05C40", Slot = "4")]
		public override JGLMIIHJDFL DIPJGCHHJPA(string KCOABCKIPCG, FCHIMHCBINK HHMKDMNANOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xD12090", Offset = "0xD10A90", VA = "0x180D12090")]
		public DefaultImporterFactory()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal static class EPLDGOOANNL
{
	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x9E05CB0", Offset = "0x9E046B0", VA = "0x189E05CB0")]
	internal static void CAGAHIDOMNP(this Material POCHLMCAOAO, string CMJFNGCMIKN, bool BLKFHFCBEDC)
	{
	}
}
namespace UnityGLTF
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class MaterialLibrary : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xD12090", Offset = "0xD10A90", VA = "0x180D12090")]
		public MaterialLibrary()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal static class IMODCOLIDGF
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class DCCHCJGEDOG
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
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public DCCHCJGEDOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x9E059D0", Offset = "0x9E043D0", VA = "0x189E059D0")]
		internal void IBAPAHIGEEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x9E058E0", Offset = "0x9E042E0", VA = "0x189E058E0")]
		internal void APBOHIPACJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x9E05930", Offset = "0x9E04330", VA = "0x189E05930")]
		internal void GMCLLDAINCK()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct AAICFHGEBCK : IAsyncStateMachine
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
		private DCCHCJGEDOG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x9DFE740", Offset = "0x9DFD140", VA = "0x189DFE740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x9DFED90", Offset = "0x9DFD790", VA = "0x189DFED90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x9E09750", Offset = "0x9E08150", VA = "0x189E09750")]
	[AsyncStateMachine(typeof(AAICFHGEBCK))]
	public static Task<Texture2D> PABOKLALEJE(Texture2D PEIDNFHKHFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class BCPDNECGOAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public bool[] AECMLCFHLGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public Vector3[] GEHHPIGBGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public Vector3[] BIEPCGNFIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public Vector4[] DMCNPNFGKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public Vector2[] GIJCPECPPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public Vector2[] ICEGEGAFBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public Vector2[] CBBLFPNCODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public Vector2[] KMAPPPOGMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public Color[] CCCHGDIOACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public BoneWeight[] IJNPCGLJIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public Vector3[][] NPJDJILKMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public Vector3[][] DBHPONNMOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public Vector3[][] HHEDOADMNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public MeshTopology[] GLAJCCOCDAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public IOILALGGFDJ[] OBADKEBAOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public int[][] GHKDGJKMPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public HashSet<int> HLBLCBIIBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public uint[] NJMKABADGAB;

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x9E01D90", Offset = "0x9E00790", VA = "0x189E01D90")]
	public void CHLOADNGFGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x9E01EA0", Offset = "0x9E008A0", VA = "0x189E01EA0")]
	public bool PMOGDCLMPMP(BCPDNECGOAF EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x9E020F0", Offset = "0x9E00AF0", VA = "0x189E020F0")]
	public BCPDNECGOAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x39F8410", Offset = "0x39F6E10", VA = "0x1839F8410")]
	[CompilerGenerated]
	internal static bool CDDCOMDBIMA<T>(T[] OCDBKJIJEFH, T[] AFIEDJMMALG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x39F9130", Offset = "0x39F7B30", VA = "0x1839F9130")]
	[CompilerGenerated]
	internal static bool CGNMHLKFMCK<T>(T[][] OCDBKJIJEFH, T[][] AFIEDJMMALG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public abstract class BMMNDDOCPAN : EHPELOKNIJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	internal Material LHHFAOMEJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private HJFLCKJDKKA IOACBJPOJJN;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly int GMLFKAELLEI;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private static readonly int AGMKKIAOJFM;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private static readonly int CPLMLHFHPEO;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private static readonly int EOBELLKFENE;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private static readonly int PLKCFDIGBOD;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private static readonly int AICIMKOAODA;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	private static readonly int KHJMKNJNIDA;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	private static readonly int HIIKEGNDIEI;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	private static readonly int JHCJMGCBMPP;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	private static readonly int HHOJCCABAKO;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	private static readonly int FPAMHHCIEFM;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	private static readonly int PCOECEKALII;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	private static readonly int LEBFJNNPDKD;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	private static readonly int HOHEGJBGHCK;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Material ADBOMPMBHDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public virtual HJFLCKJDKKA GLMFJOJKLCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x9E03890", Offset = "0x9E02290", VA = "0x189E03890", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public double ADAOAMNKKHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x9E044F0", Offset = "0x9E02EF0", VA = "0x189E044F0", Slot = "12")]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x9E04490", Offset = "0x9E02E90", VA = "0x189E04490", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public virtual bool NDHDDHFOIEB
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x9E04720", Offset = "0x9E03120", VA = "0x189E04720", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public virtual bool FLECLCAJIPK
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x9E04410", Offset = "0x9E02E10", VA = "0x189E04410", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Texture AAOJMLMLKJA
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x9E03440", Offset = "0x9E01E40", VA = "0x189E03440", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int AAOHCCHLADP
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x9E04330", Offset = "0x9E02D30", VA = "0x189E04330", Slot = "16")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Vector2 CDBAENGIKON
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x9E03760", Offset = "0x9E02160", VA = "0x189E03760", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public double BJONEANPKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x9E03300", Offset = "0x9E01D00", VA = "0x189E03300", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public Vector2 DPNOLKMDBIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x9E037C0", Offset = "0x9E021C0", VA = "0x189E037C0", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int HLBDDEBJNMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x9E03820", Offset = "0x9E02220", VA = "0x189E03820", Slot = "20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Color AABFEBBMHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x9E043A0", Offset = "0x9E02DA0", VA = "0x189E043A0", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract EHPELOKNIJO GICKIFLNCPB();

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0xA93860", Offset = "0xA92260", VA = "0x180A93860")]
	protected BMMNDDOCPAN(Material CLDFHHJKFAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x9E04A90", Offset = "0x9E03490", VA = "0x189E04A90")]
	protected BMMNDDOCPAN(string AEBNOGAOAFD, string BMPJGLIOHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x9E03360", Offset = "0x9E01D60", VA = "0x189E03360")]
	protected void BGNLNGLDKEG(Material POCHLMCAOAO, bool EECIABGEMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x9E04540", Offset = "0x9E02F40", VA = "0x189E04540")]
	protected void PCJEHKNLJEH(Material POCHLMCAOAO, bool NHLLOLAOKOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x9E034A0", Offset = "0x9E01EA0", VA = "0x189E034A0")]
	protected void EDLOPAPKPJK(Material POCHLMCAOAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class NLKJNKPOOOP : AJDLBFMHNMH, PGPBAJCAKOJ, GJGCMGPHBPO, EHPELOKNIJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	private Vector2 FGNAEKFAENM;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public virtual Texture AAOJMLMLKJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x9E0B950", Offset = "0x9E0A350", VA = "0x189E0B950", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public virtual int AAOHCCHLADP
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public virtual Vector2 CDBAENGIKON
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x9E0BA00", Offset = "0x9E0A400", VA = "0x189E0BA00", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public virtual double BJONEANPKKG
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public virtual Vector2 DPNOLKMDBIG
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x9E0BBA0", Offset = "0x9E0A5A0", VA = "0x189E0BBA0", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public virtual int HLBDDEBJNMP
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "82")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public virtual Color AABFEBBMHCM
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x9E0BC30", Offset = "0x9E0A630", VA = "0x189E0BC30", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public virtual Texture AGMLIAKGPLO
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x9E0B9B0", Offset = "0x9E0A3B0", VA = "0x189E0B9B0", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public virtual int KMFFKGNCPCE
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public virtual Vector2 DNDMPNJHOHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "86")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public virtual double FCJHDFAJAIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public virtual Vector2 JHECCBLPPEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "88")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public virtual int DLFPBHILGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public virtual double NMNDHOFMHHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x9E0BCA0", Offset = "0x9E0A6A0", VA = "0x189E0BCA0", Slot = "90")]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x9E0BCF0", Offset = "0x9E0A6F0", VA = "0x189E0BCF0", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual double IJJHKIBFHLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "92")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x9E01D80", Offset = "0x9E00780", VA = "0x189E01D80")]
	protected NLKJNKPOOOP(string AEBNOGAOAFD, string CKKHBMHIJCP, int GOJNIDHPMKF = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x9E0BD50", Offset = "0x9E0A750", VA = "0x189E0BD50")]
	protected NLKJNKPOOOP(Material JMIAOOHBHPN, int GOJNIDHPMKF = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x9E0BA70", Offset = "0x9E0A470", VA = "0x189E0BA70", Slot = "60")]
	public override EHPELOKNIJO GICKIFLNCPB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class OJOPLFPOIJB : NLKJNKPOOOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	private Vector2 JMIFBOGFBPH;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public override int ILPGFJODFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public override int MFJECIDNIAK
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public override int GLPNGKMAABE
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override int AAOHCCHLADP
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override Texture AGMLIAKGPLO
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x9E0F770", Offset = "0x9E0E170", VA = "0x189E0F770", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public override int KMFFKGNCPCE
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public override Vector2 DNDMPNJHOHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x9E0F920", Offset = "0x9E0E320", VA = "0x189E0F920", Slot = "86")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public override double FCJHDFAJAIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public override Vector2 JHECCBLPPEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x9E0F6E0", Offset = "0x9E0E0E0", VA = "0x189E0F6E0", Slot = "88")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public override int DLFPBHILGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public override double IJJHKIBFHLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x9E0F990", Offset = "0x9E0E390", VA = "0x189E0F990", Slot = "92")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x9E0F9F0", Offset = "0x9E0E3F0", VA = "0x189E0F9F0")]
	public OJOPLFPOIJB(string AEBNOGAOAFD, int GOJNIDHPMKF = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x9E0FA60", Offset = "0x9E0E460", VA = "0x189E0FA60")]
	protected OJOPLFPOIJB(Material JMIAOOHBHPN, int GOJNIDHPMKF = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x9E0F7F0", Offset = "0x9E0E1F0", VA = "0x189E0F7F0", Slot = "60")]
	public override EHPELOKNIJO GICKIFLNCPB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class PBGLKNIIHAO : BMMNDDOCPAN, PGPBAJCAKOJ, GJGCMGPHBPO, EHPELOKNIJO, NOONMLCANNM, ODLMDEOLOML, LLKEHLCMMNH, GAIINLHPPHJ, GBHGKLFEDAK, PBIBBBPNCCL, IJJAGOOPDJF, AGEMADHDELI, PCNDHHHGBKH
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Texture CBDCCFJLDHK
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x9E110A0", Offset = "0x9E0FAA0", VA = "0x189E110A0", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x9E11570", Offset = "0x9E0FF70", VA = "0x189E11570", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public int ILPGFJODFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x9E10A30", Offset = "0x9E0F430", VA = "0x189E10A30", Slot = "39")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public double PCHMECCOACG
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x9E0FF10", Offset = "0x9E0E910", VA = "0x189E0FF10", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public Vector2 EOPMJBBIJCM
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x9E10B70", Offset = "0x9E0F570", VA = "0x189E10B70", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public double FHABDAAMHPP
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x9E12620", Offset = "0x9E11020", VA = "0x189E12620", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Vector2 NHHMBPCHGPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x9E124A0", Offset = "0x9E10EA0", VA = "0x189E124A0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int HINGJJBNGGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x9E10280", Offset = "0x9E0EC80", VA = "0x189E10280", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Texture OEBMMNHJKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x9E102F0", Offset = "0x9E0ECF0", VA = "0x189E102F0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public int MFJECIDNIAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x9E11690", Offset = "0x9E10090", VA = "0x189E11690", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public double EIJGOKDPMEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x9E10970", Offset = "0x9E0F370", VA = "0x189E10970", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public Vector2 LNBCLDOCIMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x9E109D0", Offset = "0x9E0F3D0", VA = "0x189E109D0", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public double FBAOAAAFEFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x9E108B0", Offset = "0x9E0F2B0", VA = "0x189E108B0", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Vector2 HJDIOKJIPBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x9E11FB0", Offset = "0x9E109B0", VA = "0x189E11FB0", Slot = "50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int BIGNCEBOPKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x9E10AA0", Offset = "0x9E0F4A0", VA = "0x189E10AA0", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public Texture MHBHJBFAGEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x9E11B30", Offset = "0x9E10530", VA = "0x189E11B30", Slot = "52")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public int GLPNGKMAABE
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x9E10030", Offset = "0x9E0EA30", VA = "0x189E10030", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Color EHHBOFCKJAI
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x9E11820", Offset = "0x9E10220", VA = "0x189E11820", Slot = "54")]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x9E10410", Offset = "0x9E0EE10", VA = "0x189E10410", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector2 GCFLLOAFKLB
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x9E11CB0", Offset = "0x9E106B0", VA = "0x189E11CB0", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public double IHKGKPMOGJG
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x9E10CF0", Offset = "0x9E0F6F0", VA = "0x189E10CF0", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector2 EBIJMCPNOCO
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x9E101C0", Offset = "0x9E0EBC0", VA = "0x189E101C0", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public int EINEOHGIAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x9E10100", Offset = "0x9E0EB00", VA = "0x189E10100", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public Texture AGMLIAKGPLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x9E10850", Offset = "0x9E0F250", VA = "0x189E10850", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public int KMFFKGNCPCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x9E10350", Offset = "0x9E0ED50", VA = "0x189E10350", Slot = "30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Vector2 DNDMPNJHOHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x9E10E60", Offset = "0x9E0F860", VA = "0x189E10E60", Slot = "31")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public double FCJHDFAJAIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x9E0FF70", Offset = "0x9E0E970", VA = "0x189E0FF70", Slot = "32")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector2 JHECCBLPPEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x9E10600", Offset = "0x9E0F000", VA = "0x189E10600", Slot = "33")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public int DLFPBHILGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x9E11F50", Offset = "0x9E10950", VA = "0x189E11F50", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public double NMNDHOFMHHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x9E12260", Offset = "0x9E10C60", VA = "0x189E12260", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public double IJJHKIBFHLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x9E12010", Offset = "0x9E10A10", VA = "0x189E12010", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public double IGLDPBCNJIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x9E11BF0", Offset = "0x9E105F0", VA = "0x189E11BF0", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Texture ELGLEDGGKFB
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x9E12500", Offset = "0x9E10F00", VA = "0x189E12500", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public double LLFHJJHPGBK
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x9E12680", Offset = "0x9E11080", VA = "0x189E12680", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Vector2 BGEKDJAJPLL
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x9E10C30", Offset = "0x9E0F630", VA = "0x189E10C30", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public Vector2 ENODCLPFIIB
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x9E10BD0", Offset = "0x9E0F5D0", VA = "0x189E10BD0", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public int CCCDGNDAKBF
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x9E11270", Offset = "0x9E0FC70", VA = "0x189E11270", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public double ALPHKGPJPDE
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x9E11D70", Offset = "0x9E10770", VA = "0x189E11D70", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Color PGIAMKHBHKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x9E10660", Offset = "0x9E0F060", VA = "0x189E10660", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public double EIEPHIGICBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x9E115D0", Offset = "0x9E0FFD0", VA = "0x189E115D0", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Texture CNNNIFMMEKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x9E10790", Offset = "0x9E0F190", VA = "0x189E10790", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public double HOIOHCOKCNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x9E11E30", Offset = "0x9E10830", VA = "0x189E11E30", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Vector2 MKMHIMPMBDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x9E11EF0", Offset = "0x9E108F0", VA = "0x189E11EF0", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector2 FCFLKEEHBOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x9E12140", Offset = "0x9E10B40", VA = "0x189E12140", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public int PJJPGKDCFIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x9E110F0", Offset = "0x9E0FAF0", VA = "0x189E110F0", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public double PBFKHPDPMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x9E111B0", Offset = "0x9E0FBB0", VA = "0x189E111B0", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public double MCPBFOFPDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x9E11330", Offset = "0x9E0FD30", VA = "0x189E11330", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public double HFMOELPLLDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x9E122C0", Offset = "0x9E10CC0", VA = "0x189E122C0", Slot = "76")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public double OPENCKMBBPK
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x9E104E0", Offset = "0x9E0EEE0", VA = "0x189E104E0", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public double ICHBMGCGMEM
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x9E12320", Offset = "0x9E10D20", VA = "0x189E12320", Slot = "78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public Texture EHHCJBGHEMK
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x9E11DD0", Offset = "0x9E107D0", VA = "0x189E11DD0", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public double IGPDIHHALEM
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x9E11A10", Offset = "0x9E10410", VA = "0x189E11A10", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public Vector2 DBKKFJBNENK
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x9E113F0", Offset = "0x9E0FDF0", VA = "0x189E113F0", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public Vector2 IDJBNIFGEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x9E10220", Offset = "0x9E0EC20", VA = "0x189E10220", Slot = "82")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public int IAFKHMNCMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x9E10540", Offset = "0x9E0EF40", VA = "0x189E10540", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public Texture PCJAPBBMAMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x9E0FE50", Offset = "0x9E0E850", VA = "0x189E0FE50", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public double GIFMOPAAODI
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x9E10F20", Offset = "0x9E0F920", VA = "0x189E10F20", Slot = "86")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public Vector2 GJLLIAGOIDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x9E11390", Offset = "0x9E0FD90", VA = "0x189E11390", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public Vector2 GKMFBAEGGKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x9E10910", Offset = "0x9E0F310", VA = "0x189E10910", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public int HLNOMJFOCGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x9E11700", Offset = "0x9E10100", VA = "0x189E11700", Slot = "88")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public double KGIGHNFGPNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x9E125C0", Offset = "0x9E10FC0", VA = "0x189E125C0", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public Texture AIGKNMPEFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x9E10FE0", Offset = "0x9E0F9E0", VA = "0x189E10FE0", Slot = "90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public double JLCGOMPJFEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x9E11950", Offset = "0x9E10350", VA = "0x189E11950", Slot = "92")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public Vector2 JMKAKOMAEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x9E10B10", Offset = "0x9E0F510", VA = "0x189E10B10", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public Vector2 ELNAHADLGNC
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x9E12440", Offset = "0x9E10E40", VA = "0x189E12440", Slot = "93")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public int IIPOKJKPMGK
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x9E117C0", Offset = "0x9E101C0", VA = "0x189E117C0", Slot = "94")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public Color ALFOIDAAKGL
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x9E10090", Offset = "0x9E0EA90", VA = "0x189E10090", Slot = "95")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public Texture MAGCDHIIEMB
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x9E11B90", Offset = "0x9E10590", VA = "0x189E11B90", Slot = "96")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public double MFOHFKHPMCE
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x9E11630", Offset = "0x9E10030", VA = "0x189E11630", Slot = "98")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector2 FJGMLABDEBH
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x9E10480", Offset = "0x9E0EE80", VA = "0x189E10480", Slot = "97")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector2 HALECIMGJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x9E12380", Offset = "0x9E10D80", VA = "0x189E12380", Slot = "99")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public int NDDNIIJCKNH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x9E12200", Offset = "0x9E10C00", VA = "0x189E12200", Slot = "100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public double IFKOGOOBDFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x9E11AD0", Offset = "0x9E104D0", VA = "0x189E11AD0", Slot = "101")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Texture HLGIFMBBBMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x9E11040", Offset = "0x9E0FA40", VA = "0x189E11040", Slot = "102")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public double OFNEEBMFKEF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x9E11210", Offset = "0x9E0FC10", VA = "0x189E11210", Slot = "104")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector2 ELEHFIPDKMA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x9E0FEB0", Offset = "0x9E0E8B0", VA = "0x189E0FEB0", Slot = "103")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector2 HENLOPGBKLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x9E11450", Offset = "0x9E0FE50", VA = "0x189E11450", Slot = "105")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int FGHFBCDAANG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x9E123E0", Offset = "0x9E10DE0", VA = "0x189E123E0", Slot = "106")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public double NJMGMDMDMFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x9E11510", Offset = "0x9E0FF10", VA = "0x189E11510", Slot = "107")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Texture DFLMLMEOBHC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x9E105A0", Offset = "0x9E0EFA0", VA = "0x189E105A0", Slot = "108")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public double AGMDPMMJKKN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x9E11A70", Offset = "0x9E10470", VA = "0x189E11A70", Slot = "110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public Vector2 NLONOJGFKCC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x9E121A0", Offset = "0x9E10BA0", VA = "0x189E121A0", Slot = "109")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public Vector2 EPDLOGMDCLA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x9E11E90", Offset = "0x9E10890", VA = "0x189E11E90", Slot = "111")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public int HFGDGAPEHFC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x9E10F80", Offset = "0x9E0F980", VA = "0x189E10F80", Slot = "112")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public float GGEFHDJAFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x9E10730", Offset = "0x9E0F130", VA = "0x189E10730", Slot = "113")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public float DOCKDNNCKDK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x9E11150", Offset = "0x9E0FB50", VA = "0x189E11150", Slot = "114")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public Color LFBOFPPLKIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x9E120D0", Offset = "0x9E10AD0", VA = "0x189E120D0", Slot = "115")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public Texture MEMKJNHFJPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x9E10EC0", Offset = "0x9E0F8C0", VA = "0x189E10EC0", Slot = "116")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public double JAAOPBEHINA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x9E118F0", Offset = "0x9E102F0", VA = "0x189E118F0", Slot = "117")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public Vector2 NLMPEBEMKNK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x9E0FFD0", Offset = "0x9E0E9D0", VA = "0x189E0FFD0", Slot = "118")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public Vector2 DOOFEFGAHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x9E11890", Offset = "0x9E10290", VA = "0x189E11890", Slot = "119")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public int KNILBCCCLOM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x9E10160", Offset = "0x9E0EB60", VA = "0x189E10160", Slot = "120")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public Texture OPNBOOPFMPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x9E112D0", Offset = "0x9E0FCD0", VA = "0x189E112D0", Slot = "121")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public double HBCHCBDPOCK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x9E107F0", Offset = "0x9E0F1F0", VA = "0x189E107F0", Slot = "122")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Vector2 JJEEGAGMKKM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x9E114B0", Offset = "0x9E0FEB0", VA = "0x189E114B0", Slot = "123")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public Vector2 KDNECBKENJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x9E119B0", Offset = "0x9E103B0", VA = "0x189E119B0", Slot = "124")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public int HDDPHAAECFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x9E12070", Offset = "0x9E10A70", VA = "0x189E12070", Slot = "125")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public double CBEBGDINMHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x9E10C90", Offset = "0x9E0F690", VA = "0x189E10C90", Slot = "131")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public double BAGBCEIELLD
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x9E106D0", Offset = "0x9E0F0D0", VA = "0x189E106D0", Slot = "132")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Texture DDNLFFCHEEN
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x9E103B0", Offset = "0x9E0EDB0", VA = "0x189E103B0", Slot = "126")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public double OHLKOFBPDFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x9E11760", Offset = "0x9E10160", VA = "0x189E11760", Slot = "128")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector2 EKBKKJHBPCG
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x9E11D10", Offset = "0x9E10710", VA = "0x189E11D10", Slot = "127")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector2 PGHGKEAKJLD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x9E11C50", Offset = "0x9E10650", VA = "0x189E11C50", Slot = "129")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public int EAFCLGFEHAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x9E12560", Offset = "0x9E10F60", VA = "0x189E12560", Slot = "130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x9E126E0", Offset = "0x9E110E0", VA = "0x189E126E0")]
	public PBGLKNIIHAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x9E12770", Offset = "0x9E11170", VA = "0x189E12770")]
	protected PBGLKNIIHAO(string AEBNOGAOAFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x9E127E0", Offset = "0x9E111E0", VA = "0x189E127E0")]
	public PBGLKNIIHAO(Material CLDFHHJKFAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x9E10D50", Offset = "0x9E0F750", VA = "0x189E10D50", Slot = "10")]
	public override EHPELOKNIJO GICKIFLNCPB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class FMEIDLFEMPO : AJDLBFMHNMH, FPHEDNBNLKO, GJGCMGPHBPO, EHPELOKNIJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	private Vector2 KPKLCMGKHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	private Vector2 EFNNKFOFFPD;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public virtual Texture IGEGGDIFALF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x9E06150", Offset = "0x9E04B50", VA = "0x189E06150", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public virtual int DODPCNLDLIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public virtual Vector2 GEOMPNGPCGO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x9E05F40", Offset = "0x9E04940", VA = "0x189E05F40", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public virtual double NDJKABIKDCI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public virtual Vector2 MABGPLKNNHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x9E06220", Offset = "0x9E04C20", VA = "0x189E06220", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public virtual int EENEPCOJEJB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "82")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public virtual Color NOIIILLKMKN
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x9E05FB0", Offset = "0x9E049B0", VA = "0x189E05FB0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public virtual Texture NFNPAMAJCGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x9E05E90", Offset = "0x9E04890", VA = "0x189E05E90", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public virtual int NFPJHHJONLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public virtual Vector2 ILLOOCDNEDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x9E061B0", Offset = "0x9E04BB0", VA = "0x189E061B0", Slot = "86")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public virtual double GOJOJEEDNNN
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public virtual Vector2 EBDIBNICEJK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x9E05E00", Offset = "0x9E04800", VA = "0x189E05E00", Slot = "88")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public virtual int LDJCOMHOOCN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public virtual Vector3 KGIGHNFGPNA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x9E062B0", Offset = "0x9E04CB0", VA = "0x189E062B0", Slot = "90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public virtual double BLKOJNICJCA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x9E05D70", Offset = "0x9E04770", VA = "0x189E05D70", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x9E06340", Offset = "0x9E04D40", VA = "0x189E06340")]
	protected FMEIDLFEMPO(string AEBNOGAOAFD, string CKKHBMHIJCP, int GOJNIDHPMKF = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x9E06360", Offset = "0x9E04D60", VA = "0x189E06360")]
	protected FMEIDLFEMPO(Material JMIAOOHBHPN, int GOJNIDHPMKF = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x9E06020", Offset = "0x9E04A20", VA = "0x189E06020", Slot = "60")]
	public override EHPELOKNIJO GICKIFLNCPB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class GMLFKNGGJJL : FMEIDLFEMPO
{
	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public override int ILPGFJODFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public override int MFJECIDNIAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public override int GLPNGKMAABE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public override int DODPCNLDLIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public override int NFPJHHJONLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x9E07570", Offset = "0x9E05F70", VA = "0x189E07570")]
	public GMLFKNGGJJL(string AEBNOGAOAFD, int GOJNIDHPMKF = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x9E06360", Offset = "0x9E04D60", VA = "0x189E06360")]
	protected GMLFKNGGJJL(Material JMIAOOHBHPN, int GOJNIDHPMKF = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x9E07440", Offset = "0x9E05E40", VA = "0x189E07440", Slot = "60")]
	public override EHPELOKNIJO GICKIFLNCPB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class AJDLBFMHNMH : GJGCMGPHBPO, EHPELOKNIJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	protected Material LHHFAOMEJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private HJFLCKJDKKA IOACBJPOJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private double MDFNLMNMLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private Vector2 MKFIFNDELML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private Vector2 OGJCIDPIOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private Vector2 GNFJLHJDDIH;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public Material ADBOMPMBHDI
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public virtual Texture CBDCCFJLDHK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x9DFF840", Offset = "0x9DFE240", VA = "0x189DFF840", Slot = "33")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x9DFF8B0", Offset = "0x9DFE2B0", VA = "0x189DFF8B0", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public virtual int ILPGFJODFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public virtual Vector2 EOPMJBBIJCM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x9DFF290", Offset = "0x9DFDC90", VA = "0x189DFF290", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public virtual double FHABDAAMHPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public virtual Vector2 NHHMBPCHGPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x9DFFD90", Offset = "0x9DFE790", VA = "0x189DFFD90", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public virtual int HINGJJBNGGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "39")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public virtual double PCHMECCOACG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x9DFEE00", Offset = "0x9DFD800", VA = "0x189DFEE00", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public virtual Texture OEBMMNHJKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x9DFEF50", Offset = "0x9DFD950", VA = "0x189DFEF50", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public virtual int MFJECIDNIAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public virtual Vector2 LNBCLDOCIMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x9DFF220", Offset = "0x9DFDC20", VA = "0x189DFF220", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public virtual double FBAOAAAFEFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public virtual Vector2 HJDIOKJIPBE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x9DFFC00", Offset = "0x9DFE600", VA = "0x189DFFC00", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public virtual int BIGNCEBOPKH
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public virtual double EIJGOKDPMEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x9DFF160", Offset = "0x9DFDB60", VA = "0x189DFF160", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public virtual Texture MHBHJBFAGEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x9DFFA30", Offset = "0x9DFE430", VA = "0x189DFFA30", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public virtual int GLPNGKMAABE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public virtual Vector2 GCFLLOAFKLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x9DFFB90", Offset = "0x9DFE590", VA = "0x189DFFB90", Slot = "50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public virtual double IHKGKPMOGJG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public virtual Vector2 EBIJMCPNOCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x9DFEEC0", Offset = "0x9DFD8C0", VA = "0x189DFEEC0", Slot = "52")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public virtual int EINEOHGIAKN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public virtual Color EHHBOFCKJAI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x9DFF990", Offset = "0x9DFE390", VA = "0x189DFF990", Slot = "54")]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x9DFF010", Offset = "0x9DFDA10", VA = "0x189DFF010", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public virtual HJFLCKJDKKA GLMFJOJKLCC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x9DFF3B0", Offset = "0x9DFDDB0", VA = "0x189DFF3B0", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public virtual double ADAOAMNKKHP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x9DFFC90", Offset = "0x9DFE690", VA = "0x189DFFC90", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public virtual bool NDHDDHFOIEB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x9DFFD20", Offset = "0x9DFE720", VA = "0x189DFFD20", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public virtual bool FLECLCAJIPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x9DFFB10", Offset = "0x9DFE510", VA = "0x189DFFB10", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x9DFFE20", Offset = "0x9DFE820", VA = "0x189DFFE20")]
	protected AJDLBFMHNMH(string AEBNOGAOAFD, string BMPJGLIOHLB, int GOJNIDHPMKF = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x9DFFF90", Offset = "0x9DFE990", VA = "0x189DFFF90")]
	protected AJDLBFMHNMH(Material CLDFHHJKFAI, int GOJNIDHPMKF = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x9DFF300", Offset = "0x9DFDD00", VA = "0x189DFF300", Slot = "60")]
	public virtual EHPELOKNIJO GICKIFLNCPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x9DFF0C0", Offset = "0x9DFDAC0", VA = "0x189DFF0C0", Slot = "61")]
	protected virtual void BCDPIPBINMD(GJGCMGPHBPO EJBIGGIEBEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface EHPELOKNIJO
{
	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	Material ADBOMPMBHDI
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	HJFLCKJDKKA GLMFJOJKLCC
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	double ADAOAMNKKHP
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	bool NDHDDHFOIEB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	bool FLECLCAJIPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EHPELOKNIJO GICKIFLNCPB();
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface GJGCMGPHBPO : EHPELOKNIJO
{
	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	Texture CBDCCFJLDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	int ILPGFJODFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	double PCHMECCOACG
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	Vector2 EOPMJBBIJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	double FHABDAAMHPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	Vector2 NHHMBPCHGPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	int HINGJJBNGGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	Texture OEBMMNHJKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	int MFJECIDNIAK
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	double EIJGOKDPMEK
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	Vector2 LNBCLDOCIMM
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	double FBAOAAAFEFH
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	Vector2 HJDIOKJIPBE
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	int BIGNCEBOPKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	Texture MHBHJBFAGEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	int GLPNGKMAABE
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(Slot = "16")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	Color EHHBOFCKJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(Slot = "18")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	Vector2 GCFLLOAFKLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	double IHKGKPMOGJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(Slot = "20")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	Vector2 EBIJMCPNOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	int EINEOHGIAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(Slot = "22")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface PGPBAJCAKOJ : GJGCMGPHBPO, EHPELOKNIJO
{
	[Cpp2IlInjected.Token(Token = "0x17000107")]
	Texture AAOJMLMLKJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	int AAOHCCHLADP
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	Vector2 CDBAENGIKON
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	double BJONEANPKKG
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	Vector2 DPNOLKMDBIG
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	int HLBDDEBJNMP
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	Color AABFEBBMHCM
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	Texture AGMLIAKGPLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	int KMFFKGNCPCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	Vector2 DNDMPNJHOHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	double FCJHDFAJAIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	Vector2 JHECCBLPPEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	int DLFPBHILGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(Slot = "12")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	double NMNDHOFMHHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	double IJJHKIBFHLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public interface NOONMLCANNM : PGPBAJCAKOJ, GJGCMGPHBPO, EHPELOKNIJO
{
	[Cpp2IlInjected.Token(Token = "0x17000116")]
	double IGLDPBCNJIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	Texture ELGLEDGGKFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	Vector2 BGEKDJAJPLL
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	double LLFHJJHPGBK
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	Vector2 ENODCLPFIIB
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	int CCCDGNDAKBF
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	double ALPHKGPJPDE
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	Color PGIAMKHBHKL
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public interface ODLMDEOLOML : PGPBAJCAKOJ, GJGCMGPHBPO, EHPELOKNIJO
{
	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	double EIEPHIGICBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	Texture CNNNIFMMEKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	Vector2 MKMHIMPMBDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	double HOIOHCOKCNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	Vector2 FCFLKEEHBOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	int PJJPGKDCFIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public interface AGEMADHDELI : PGPBAJCAKOJ, GJGCMGPHBPO, EHPELOKNIJO
{
	[Cpp2IlInjected.Token(Token = "0x17000124")]
	float DOCKDNNCKDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	Color LFBOFPPLKIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	Texture MEMKJNHFJPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	double JAAOPBEHINA
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	Vector2 NLMPEBEMKNK
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	Vector2 DOOFEFGAHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	int KNILBCCCLOM
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	Texture OPNBOOPFMPG
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	double HBCHCBDPOCK
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	Vector2 JJEEGAGMKKM
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	Vector2 KDNECBKENJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	int HDDPHAAECFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public interface IJJAGOOPDJF : ODLMDEOLOML, PGPBAJCAKOJ, GJGCMGPHBPO, EHPELOKNIJO
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	float GGEFHDJAFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public interface LLKEHLCMMNH : PGPBAJCAKOJ, GJGCMGPHBPO, EHPELOKNIJO
{
	[Cpp2IlInjected.Token(Token = "0x17000131")]
	double PBFKHPDPMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public interface GBHGKLFEDAK : PGPBAJCAKOJ, GJGCMGPHBPO, EHPELOKNIJO
{
	[Cpp2IlInjected.Token(Token = "0x17000132")]
	double KGIGHNFGPNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	Texture AIGKNMPEFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	Vector2 JMKAKOMAEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	double JLCGOMPJFEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	Vector2 ELNAHADLGNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	int IIPOKJKPMGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	Color ALFOIDAAKGL
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	Texture MAGCDHIIEMB
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	Vector2 FJGMLABDEBH
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	double MFOHFKHPMCE
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	Vector2 HALECIMGJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	int NDDNIIJCKNH
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public interface GAIINLHPPHJ : PGPBAJCAKOJ, GJGCMGPHBPO, EHPELOKNIJO
{
	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	double MCPBFOFPDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	double HFMOELPLLDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	double OPENCKMBBPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	double ICHBMGCGMEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	Texture EHHCJBGHEMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	Vector2 DBKKFJBNENK
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	double IGPDIHHALEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	Vector2 IDJBNIFGEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	int IAFKHMNCMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	Texture PCJAPBBMAMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	Vector2 GJLLIAGOIDM
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	double GIFMOPAAODI
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	Vector2 GKMFBAEGGKF
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	int HLNOMJFOCGB
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public interface FPHEDNBNLKO : GJGCMGPHBPO, EHPELOKNIJO
{
	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	Texture IGEGGDIFALF
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	int DODPCNLDLIM
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	Vector2 GEOMPNGPCGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	double NDJKABIKDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	Vector2 MABGPLKNNHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	int EENEPCOJEJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	Color NOIIILLKMKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	Texture NFNPAMAJCGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	int NFPJHHJONLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	Vector2 ILLOOCDNEDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	double GOJOJEEDNNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	Vector2 EBDIBNICEJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	int LDJCOMHOOCN
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	Vector3 KGIGHNFGPNA
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	double BLKOJNICJCA
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public interface PBIBBBPNCCL : PGPBAJCAKOJ, GJGCMGPHBPO, EHPELOKNIJO
{
	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	double IFKOGOOBDFH
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	Texture HLGIFMBBBMP
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	Vector2 ELEHFIPDKMA
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	double OFNEEBMFKEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	Vector2 HENLOPGBKLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	int FGHFBCDAANG
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	double NJMGMDMDMFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	Texture DFLMLMEOBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	Vector2 NLONOJGFKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	double AGMDPMMJKKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	Vector2 EPDLOGMDCLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	int HFGDGAPEHFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public interface NBKIOHDNAAC
{
	[Cpp2IlInjected.Token(Token = "0x17000167")]
	Texture PEILMPJOFFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	Vector2 PEANLBKCMAB
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	double OCHLOCEABMG
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	Vector2 KJOBOGEPAHD
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	int FJGCBHKNGHA
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public interface PCNDHHHGBKH
{
	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	Texture DDNLFFCHEEN
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	Vector2 EKBKKJHBPCG
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	double OHLKOFBPDFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	Vector2 PGHGKEAKJLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	int EAFCLGFEHAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	double CBEBGDINMHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	double BAGBCEIELLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public interface BMCPPHAHCDI : EHPELOKNIJO
{
	[Cpp2IlInjected.Token(Token = "0x17000173")]
	Texture AAOJMLMLKJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	int AAOHCCHLADP
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	Vector2 CDBAENGIKON
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	double BJONEANPKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	Vector2 DPNOLKMDBIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	int HLBDDEBJNMP
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	Color AABFEBBMHCM
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class MKKBFNMNEJK : BMMNDDOCPAN, BMCPPHAHCDI, EHPELOKNIJO
{
	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x9E0B2E0", Offset = "0x9E09CE0", VA = "0x189E0B2E0")]
	public MKKBFNMNEJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x9E0B200", Offset = "0x9E09C00", VA = "0x189E0B200")]
	protected MKKBFNMNEJK(string AEBNOGAOAFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x9E0B270", Offset = "0x9E09C70", VA = "0x189E0B270")]
	public MKKBFNMNEJK(Material CLDFHHJKFAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x9E0B0F0", Offset = "0x9E09AF0", VA = "0x189E0B0F0", Slot = "10")]
	public override EHPELOKNIJO GICKIFLNCPB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class AMENADJKINK : AJDLBFMHNMH, BMCPPHAHCDI, EHPELOKNIJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private Vector2 FGNAEKFAENM;

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public Texture AAOJMLMLKJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x9E01BB0", Offset = "0x9E005B0", VA = "0x189E01BB0", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public virtual int AAOHCCHLADP
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public virtual Vector2 CDBAENGIKON
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x9E01C10", Offset = "0x9E00610", VA = "0x189E01C10", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public virtual double BJONEANPKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public virtual Vector2 DPNOLKMDBIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x9E01C80", Offset = "0x9E00680", VA = "0x189E01C80", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	public virtual int HLBDDEBJNMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	public virtual Color AABFEBBMHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x9E01D10", Offset = "0x9E00710", VA = "0x189E01D10", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x9E01D80", Offset = "0x9E00780", VA = "0x189E01D80")]
	public AMENADJKINK(string AEBNOGAOAFD, string CKKHBMHIJCP, int GOJNIDHPMKF = 1000)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class AMBFBNPLPEL
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public delegate void NIEPHJKGHGP(JCMGBNFKOCO GFNBDMCCBGJ);

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public delegate void ABOAFGHDHAM(GAEOCFOCCBD GFNBDMCCBGJ);

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class GAEOCFOCCBD
	{
		[Cpp2IlInjected.Token(Token = "0x17000183")]
		private Bounds ELPKKEHFOPB
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x928A500", Offset = "0x9288F00", VA = "0x18928A500")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000184")]
		private GENLMNMPIND FIKFKMELBCI
		{
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000185")]
		private EFAGEPFJOIC EIGPFKLCPAH
		{
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x9E198A0", Offset = "0x9E182A0", VA = "0x189E198A0")]
		internal GAEOCFOCCBD(Bounds FALHHAMEAKN, GENLMNMPIND HIMDLPAHKOO, EFAGEPFJOIC MLPDGDMMEHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class JCMGBNFKOCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		internal MOFLBDOIIJI.GNODOEAHIBP DAHFKPDPPOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public float[] KGHEGBMJPKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public object[] MFALEKJCBMJ;

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xDB36D0", Offset = "0xDB20D0", VA = "0x180DB36D0")]
		internal JCMGBNFKOCO(MOFLBDOIIJI.GNODOEAHIBP AAAKMAAEEAF, float[] HHHDIEJDCEF, object[] EJKNLPOFFNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	internal class MOFLBDOIIJI
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		internal class LEBFKLDGIIL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			public string GGDGFENODPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			public Type IHIGFFKJLJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			public Func<Transform, UnityEngine.Object> DPAABMNNIKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			public Func<Transform, UnityEngine.Object, MOFLBDOIIJI, object> FLGAPNHJLJO;

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x10D4760", Offset = "0x10D3160", VA = "0x1810D4760")]
			public LEBFKLDGIIL(string GGDGFENODPM, Type IHIGFFKJLJM, Func<Transform, UnityEngine.Object> DPAABMNNIKJ, Func<Transform, UnityEngine.Object, MOFLBDOIIJI, object> FLGAPNHJLJO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x9E23340", Offset = "0x9E21D40", VA = "0x189E23340")]
			public object DPDDMKHILOO(MOFLBDOIIJI GPCDCFCPGFK)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000098")]
		internal class GNODOEAHIBP
		{
			[Cpp2IlInjected.Token(Token = "0x2000099")]
			private class BBPPBGPPKFP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000376")]
				public double FPIFKAOGCDC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000377")]
				public object PDKJBMPOMNC;

				[Cpp2IlInjected.Token(Token = "0x60003B7")]
				[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
				public BBPPBGPPKFP()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			private MOFLBDOIIJI AAAKMAAEEAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			private LEBFKLDGIIL ALOJOCPCMIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			private Dictionary<double, object> HOJPNGNMCGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			private BBPPBGPPKFP DMBNBMECIMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			private BBPPBGPPKFP IIELMFOGHDA;

			[Cpp2IlInjected.Token(Token = "0x17000186")]
			public UnityEngine.Object OLCMKMKLADE
			{
				[Cpp2IlInjected.Token(Token = "0x60003B1")]
				[Cpp2IlInjected.Address(RVA = "0x9E1A4B0", Offset = "0x9E18EB0", VA = "0x189E1A4B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000187")]
			public string GGDGFENODPM
			{
				[Cpp2IlInjected.Token(Token = "0x60003B2")]
				[Cpp2IlInjected.Address(RVA = "0x5A471D0", Offset = "0x5A45BD0", VA = "0x185A471D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000188")]
			public float[] HHHDIEJDCEF
			{
				[Cpp2IlInjected.Token(Token = "0x60003B3")]
				[Cpp2IlInjected.Address(RVA = "0x9E1A2E0", Offset = "0x9E18CE0", VA = "0x189E1A2E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000189")]
			public object[] EJKNLPOFFNN
			{
				[Cpp2IlInjected.Token(Token = "0x60003B4")]
				[Cpp2IlInjected.Address(RVA = "0x9E1A450", Offset = "0x9E18E50", VA = "0x189E1A450")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x9E1A4F0", Offset = "0x9E18EF0", VA = "0x189E1A4F0")]
			public GNODOEAHIBP(MOFLBDOIIJI AAAKMAAEEAF, LEBFKLDGIIL ALOJOCPCMIM, double FPIFKAOGCDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x9E1A090", Offset = "0x9E18A90", VA = "0x189E1A090")]
			public void IOFBBBCEEHP(double FPIFKAOGCDC)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		internal Transform AAAKMAAEEAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private SkinnedMeshRenderer FHHDEFAFLFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private bool JDPIJDGMNNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private bool CCBJKEMKDPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private bool GIFGKNBPCCE;

		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private static List<LEBFKLDGIIL> EEHFNCGMHEO;

		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private static MaterialPropertyBlock KBLHKCKFEMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		internal List<GNODOEAHIBP> FIIDLDHJGHI;

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x9E23D40", Offset = "0x9E22740", VA = "0x189E23D40")]
		public MOFLBDOIIJI(Transform AAAKMAAEEAF, double FPIFKAOGCDC, bool HFGEHGNKFGI = false, bool JDPIJDGMNNF = true, bool CCBJKEMKDPP = false, bool GIFGKNBPCCE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x9E23B90", Offset = "0x9E22590", VA = "0x189E23B90")]
		public void AIICKBIOPNB(double FPIFKAOGCDC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	internal ICollection<Transform> HMCHNFLLBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private Transform PJFDNMGHMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private Dictionary<Transform, MOFLBDOIIJI> GPCDCFCPGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private double ABGKAAONMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private double BDIBDELOFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private bool IICBJOCOLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	private bool NGBAHBAPEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private readonly bool JDPIJDGMNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	private readonly bool HMFFDOMLBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private readonly bool GIFGKNBPCCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public string LGOMOEKAJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public NIEPHJKGHGP OOKMOEEAKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public ABOAFGHDHAM HCJGGKEAOKK;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	private static ProfilerMarker EJNNIGMGLNB;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private static ProfilerMarker MMJFPEBGOPN;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private static ProfilerMarker IAHDLPKIGMP;

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	public bool OCFGKFHFBGE
	{
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x1525280", Offset = "0x1523C80", VA = "0x181525280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	public double CBMGJOBFNAI
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x764D4A0", Offset = "0x764BEA0", VA = "0x18764D4A0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x9E01A20", Offset = "0x9E00420", VA = "0x189E01A20")]
	public AMBFBNPLPEL(Transform PJFDNMGHMBL, bool JDPIJDGMNNF = true, bool HMFFDOMLBLO = false, bool GIFGKNBPCCE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x9E000B0", Offset = "0x9DFEAB0", VA = "0x189E000B0")]
	private bool BCLENHCGGOG(Transform AAAKMAAEEAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x9E01410", Offset = "0x9DFFE10", VA = "0x189E01410")]
	public void JHJOEEHMALB(double FPIFKAOGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x9E01650", Offset = "0x9E00050", VA = "0x189E01650")]
	public void KMBFLBNHKEO(double FPIFKAOGCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x9E00170", Offset = "0x9DFEB70", VA = "0x189E00170")]
	public void HMAFFFONFAC(string PNIDKKDGNMJ, string MPIBHFEHILP = "scene", [Optional] GLTFSettings IMFNJOKFKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x9E002F0", Offset = "0x9DFECF0", VA = "0x189E002F0")]
	public void HMAFFFONFAC(Stream AKDFBDNJGIO, string MPIBHFEHILP = "scene", [Optional] GLTFSettings IMFNJOKFKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x9E00D00", Offset = "0x9DFF700", VA = "0x189E00D00")]
	private void IAHPPPPCPAA(GENLMNMPIND HIMDLPAHKOO, EFAGEPFJOIC MLPDGDMMEHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x9E00EB0", Offset = "0x9DFF8B0", VA = "0x189E00EB0")]
	private void IODCAIDABDD(GENLMNMPIND KNDBONGFIMC, BDBAMGNDDHA HMKDAFLEBDJ, bool GNLBFAJONEO, [Out] Bounds GALAODBKLNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public class IIAJKKODDDG : PlayableBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	private sealed class HDNPMFFFLAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public IIAJKKODDDG <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public HDNPMFFFLAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x9E1A7A0", Offset = "0x9E191A0", VA = "0x189E1A7A0")]
		internal void DGNKFHEGABI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400038A")]
	private AMBFBNPLPEL CDLNBKNEMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public GLTFRecorderClip HBCLIMLIDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400038C")]
	private bool GCHKKHEONPJ;

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x9E1D980", Offset = "0x9E1C380", VA = "0x189E1D980")]
	private void HIMOINEBJCL(double DPIGJBBPKFM, Transform KAHGFJIPKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x9E1DA50", Offset = "0x9E1C450", VA = "0x189E1DA50")]
	private void LBPDKGABIFO(double DPIGJBBPKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x9E1D620", Offset = "0x9E1C020", VA = "0x189E1D620")]
	private void BCOLKOAIMIM(double DPIGJBBPKFM, Transform KAHGFJIPKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980")]
	private static bool EMHEMAJJPMB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x9E1DCE0", Offset = "0x9E1C6E0", VA = "0x189E1DCE0", Slot = "16")]
	public override void OnPlayableDestroy(Playable MJAICDFBHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x9E1DAB0", Offset = "0x9E1C4B0", VA = "0x189E1DAB0", Slot = "13")]
	public override void OnGraphStart(Playable MJAICDFBHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x9E1DC40", Offset = "0x9E1C640", VA = "0x189E1DC40", Slot = "14")]
	public override void OnGraphStop(Playable MJAICDFBHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x9E1DD80", Offset = "0x9E1C780", VA = "0x189E1DD80", Slot = "20")]
	public override void ProcessFrame(Playable MJAICDFBHGM, FrameData LJOFOOFMAON, object DJOJNMMDAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x24EDBB0", Offset = "0x24EC5B0", VA = "0x1824EDBB0", Slot = "17")]
	public override void OnBehaviourPlay(Playable MJAICDFBHGM, FrameData LJOFOOFMAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0xD35410", Offset = "0xD33E10", VA = "0x180D35410", Slot = "18")]
	public override void OnBehaviourPause(Playable MJAICDFBHGM, FrameData LJOFOOFMAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x9E1D750", Offset = "0x9E1C150", VA = "0x189E1D750")]
	public void HHGMBEOGAOE(double FPIFKAOGCDC, Playable MJAICDFBHGM, FrameData LJOFOOFMAON, object DJOJNMMDAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
	public IIAJKKODDDG()
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
			[Cpp2IlInjected.Address(RVA = "0xAF1310", Offset = "0xAEFD10", VA = "0x180AF1310", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(ClipCaps);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x9E19990", Offset = "0x9E18390", VA = "0x189E19990", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph IEEBPAIPHOB, GameObject ICBGFNPAHKN)
		{
			return default(Playable);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x9E19930", Offset = "0x9E18330", VA = "0x189E19930")]
		public Transform BNFPDMGJDIK(PlayableGraph IEEBPAIPHOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x9E19AA0", Offset = "0x9E184A0", VA = "0x189E19AA0")]
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
		private sealed class FEGHGIAGJIE : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0xA8AF50", Offset = "0xA89950", VA = "0x180A8AF50")]
			[DebuggerHidden]
			public FEGHGIAGJIE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x9E15D30", Offset = "0x9E14730", VA = "0x189E15D30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x9E15F70", Offset = "0x9E14970", VA = "0x189E15F70", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private List<Action> HBDPJLIMLIH;

		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private static GLTFRecorderHelper PKGDNOOHCCN;

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x9E19B30", Offset = "0x9E18530", VA = "0x189E19B30")]
		public static void Add(Action EMBEDGKMMHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x9E19D90", Offset = "0x9E18790", VA = "0x189E19D90")]
		private static GLTFRecorderHelper HOLGDEPPPHH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x9E19D10", Offset = "0x9E18710", VA = "0x189E19D10")]
		[IteratorStateMachine(typeof(FEGHGIAGJIE))]
		private IEnumerator GPDEJJMPKMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x9E19F30", Offset = "0x9E18930", VA = "0x189E19F30")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x9E19FB0", Offset = "0x9E189B0", VA = "0x189E19FB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9E1A040", Offset = "0x9E18A40", VA = "0x189E1A040")]
		public GLTFRecorderTrack()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
internal static class IAHJMGFHDFD
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class IOBHBHDJIID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public int primaryComponentCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public KCNMOKACGBI propertyMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public PILGHGOCPEH pointerDataCopy;

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public IOBHBHDJIID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x9E1E100", Offset = "0x9E1CB00", VA = "0x189E1E100")]
		internal float[] CNGJBJENDMP(PILGHGOCPEH data, int frame)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x9E1E2B0", Offset = "0x9E1CCB0", VA = "0x189E1E2B0")]
		internal float[] ODLDIAMCEHB(PILGHGOCPEH data, int frame)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x9E1E220", Offset = "0x9E1CC20", VA = "0x189E1E220")]
		internal float[] KGHPDIEEBFF(PILGHGOCPEH data, int frame)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x9E1E190", Offset = "0x9E1CB90", VA = "0x189E1E190")]
		internal float[] IGGBGOHOMLI(PILGHGOCPEH data, int frame)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	private static readonly string[] BIIHPGMANDJ;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	private static readonly string[] PEAHCPHANMD;

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x9E1C270", Offset = "0x9E1AC70", VA = "0x189E1C270")]
	internal static bool OEDLKOGAPGD(string GBMCCEKLJOC, HJCOCALNIKA DANHHHOPANK, Material POCHLMCAOAO, string EABLBHOILBN, HFGLIDLAEEJ NCFIPDLNHFH, [Out] PILGHGOCPEH CPIMOENJOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x9E1B9E0", Offset = "0x9E1A3E0", VA = "0x189E1B9E0")]
	internal static string[] IMOCBGCEPPA(string GGDGFENODPM, int JEGBDHJCEHO, int LEOMDHGLDDJ = 0, bool CAAHDIFMHKL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x9E1BC80", Offset = "0x9E1A680", VA = "0x189E1BC80")]
	internal static float[] NJJOHLJDOHB(int FILGHJLFKAL, int JEGBDHJCEHO, KCNMOKACGBI EKGECJENMCF, PILGHGOCPEH CPIMOENJOOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class KCNMOKACGBI
{
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public enum IONACDBJLGP
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
	public enum KPDENEPJKLK
	{
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		SameAsPrimary,
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		Override
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public delegate float[] HLCDLNOCKFH(float[] IMNJFEHGKPO, float[] OLHNNNGKCIG, int JFJIHNEAAHF);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public IONACDBJLGP DKIFNAFPJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public string CELNDPNKCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public string CDCNIOCCJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public bool ODAMIELOCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public KPDENEPJKLK PGHEDJJDJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public DJADGPFBHIP CNJBNJOJMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public bool EPHFGHIFHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public bool NNJMANPFNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x36")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public bool AIMKOKPABIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public float MFJGKMCKNJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public string JBHJNPFGKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public HLCDLNOCKFH BABOCEPDMGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private string[] GPBLJHLEJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	internal int[] ADPPGPONKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	internal int[] CGBFKOGGDMD;

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	public string[] FDIJEOIPOAL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xA84210", Offset = "0xA82C10", VA = "0x180A84210")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x9E22F40", Offset = "0x9E21940", VA = "0x189E22F40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	public bool PJPLDBDEKCF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x9E22D80", Offset = "0x9E21780", VA = "0x189E22D80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x9E230C0", Offset = "0x9E21AC0", VA = "0x189E230C0")]
	public KCNMOKACGBI(IONACDBJLGP LFONINCANLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x9E22DA0", Offset = "0x9E217A0", VA = "0x189E22DA0")]
	private void LGFNBLBGBDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x9E22F70", Offset = "0x9E21970", VA = "0x189E22F70")]
	private static float[] OOEDPHJGHEO(float[] IMNJFEHGKPO, float[] OLHNNNGKCIG, int JFJIHNEAAHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x9E22CE0", Offset = "0x9E216E0", VA = "0x189E22CE0")]
	private void BLAIEIPMIEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class HJCOCALNIKA
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public enum LDEAFDECKPN
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
	private Dictionary<string, KCNMOKACGBI> OEIMKMOKHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	private Dictionary<string, KCNMOKACGBI> IOLGJMDHGBO;

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x9E1B030", Offset = "0x9E19A30", VA = "0x189E1B030")]
	public void MDCFMAFELPC(string HLOIMGGKOLD, string[] PHMHPLDLBHF, [Optional] string ACHJMLCMOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x9E1AA40", Offset = "0x9E19440", VA = "0x189E1AA40")]
	public void GBCFGKGAJPD(KCNMOKACGBI EKGECJENMCF, LDEAFDECKPN FGGLLGEDENH = LDEAFDECKPN.ImportAndExport)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x9E1A820", Offset = "0x9E19220", VA = "0x189E1A820")]
	public bool EKEMJHGPFBB(Material CLDFHHJKFAI, string ACLBODBFMPD, [Out] KCNMOKACGBI EKGECJENMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x9E1AC60", Offset = "0x9E19660", VA = "0x189E1AC60")]
	public bool KBEDCCIFFJC(Material CLDFHHJKFAI, string DJJJKMMPLJK, [Out] string GGDGFENODPM, [Out] KCNMOKACGBI EKGECJENMCF, [Out] bool BOIGCAPOAPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x9E1B700", Offset = "0x9E1A100", VA = "0x189E1B700")]
	public HJCOCALNIKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public class JEMIEPBFANL : HJCOCALNIKA
{
	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x9E1E340", Offset = "0x9E1CD40", VA = "0x189E1E340")]
	public JEMIEPBFANL()
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
			[Cpp2IlInjected.Address(RVA = "0x9E159C0", Offset = "0x9E143C0", VA = "0x189E159C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000190")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0x9E15990", Offset = "0x9E14390", VA = "0x189E15990", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000191")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x9E158E0", Offset = "0x9E142E0", VA = "0x189E158E0", Slot = "14")]
		public override PDBJIPMJIIJ FCAIPCNJKCP(LIDEFDAPMMN HCLPHJDKMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x1575BD0", Offset = "0x15745D0", VA = "0x181575BD0")]
		public AnimationPointerExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public class ILPIMMCEKLH : PDBJIPMJIIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public HJCOCALNIKA MEGGLPLJAJP;

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x9E1E080", Offset = "0x9E1CA80", VA = "0x189E1E080")]
	public ILPIMMCEKLH()
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
			[Cpp2IlInjected.Address(RVA = "0x9E15AD0", Offset = "0x9E144D0", VA = "0x189E15AD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000193")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x9E15AA0", Offset = "0x9E144A0", VA = "0x189E15AA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x9E159F0", Offset = "0x9E143F0", VA = "0x189E159F0", Slot = "13")]
		public override CIAGMPPOCJL FCAIPCNJKCP(IGCMHMGLAFB HCLPHJDKMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x1575BD0", Offset = "0x15745D0", VA = "0x181575BD0")]
		public AnimationPointerImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class BECPIGNOPHI : CIAGMPPOCJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public HJCOCALNIKA MEGGLPLJAJP;

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x9E15B00", Offset = "0x9E14500", VA = "0x189E15B00")]
	public BECPIGNOPHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[AttributeUsage(AttributeTargets.Class)]
public class BLFADFOELKL : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public string JIPOFOKLOJJ;

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0xAB0110", Offset = "0xAAEB10", VA = "0x180AB0110")]
	public BLFADFOELKL([Optional] string JIPOFOKLOJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[AttributeUsage(AttributeTargets.Class)]
public class GNBDMJMBJHD : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public string JIPOFOKLOJJ;

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0xAB0110", Offset = "0xAAEB10", VA = "0x180AB0110")]
	public GNBDMJMBJHD([Optional] string JIPOFOKLOJJ)
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
			[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(Slot = "14")]
		public abstract PDBJIPMJIIJ FCAIPCNJKCP(LIDEFDAPMMN HCLPHJDKMCA);

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x1575BD0", Offset = "0x15745D0", VA = "0x181575BD0")]
		protected GLTFExportPlugin()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public abstract class PDBJIPMJIIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public virtual void NNNEILPGEJI(GENLMNMPIND HIMDLPAHKOO, EFAGEPFJOIC MLPDGDMMEHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
	public virtual void ODKAGIAEEAB(GENLMNMPIND HIMDLPAHKOO, EFAGEPFJOIC MLPDGDMMEHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "6")]
	public virtual bool JDKNMDEDFMC(GENLMNMPIND HIMDLPAHKOO, EFAGEPFJOIC MLPDGDMMEHF, Transform EOBBLENOIHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "7")]
	public virtual void FKKFHAJNHOK(GENLMNMPIND HIMDLPAHKOO, EFAGEPFJOIC MLPDGDMMEHF, Transform EOBBLENOIHL, BEPOCDMOBMH AAPGFEFGBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "8")]
	public virtual void MEPLLBKDIJM(GENLMNMPIND HIMDLPAHKOO, EFAGEPFJOIC MLPDGDMMEHF, Transform EOBBLENOIHL, BEPOCDMOBMH AAPGFEFGBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "9")]
	public virtual bool NDBAACIGCGM(GENLMNMPIND HIMDLPAHKOO, EFAGEPFJOIC MLPDGDMMEHF, Material POCHLMCAOAO, LCMNEMHMEMN JNPJLGBGEJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "10")]
	public virtual void IGOMIKDBHHA(GENLMNMPIND HIMDLPAHKOO, EFAGEPFJOIC MLPDGDMMEHF, Material POCHLMCAOAO, LCMNEMHMEMN JNPJLGBGEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "11")]
	public virtual void CFDBPIBOMJA(GENLMNMPIND HIMDLPAHKOO, GENLMNMPIND.BDKCOOLEBKG GIAGKAKEOKD, string DEDCEAPAKEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "12")]
	public virtual void IAPLHCDGKAO(GENLMNMPIND HIMDLPAHKOO, GENLMNMPIND.BDKCOOLEBKG GIAGKAKEOKD, int FILGHJLFKAL, DHNJMKCGALD BPFBEDAOOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "13")]
	public virtual void IADKDEFCGOB(GENLMNMPIND HIMDLPAHKOO, Mesh HFCMFMCGELA, GNHEIJGFIHM PKPIFEMAIAE, int FILGHJLFKAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "14")]
	public virtual void LIENEKKEJOP(GENLMNMPIND HIMDLPAHKOO, Mesh HFCMFMCGELA, BEALLOFPNOF PDHFPJJNOJI, int FILGHJLFKAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	protected PDBJIPMJIIJ()
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
		public abstract CIAGMPPOCJL FCAIPCNJKCP(IGCMHMGLAFB HCLPHJDKMCA);

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x1575BD0", Offset = "0x15745D0", VA = "0x181575BD0")]
		protected GLTFImportPlugin()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public abstract class CIAGMPPOCJL
{
	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public virtual void AMHIFIJAMEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
	public virtual void BIBIDGOEIND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "6")]
	public virtual void CLLJJMJMEOK(EFAGEPFJOIC MLPDGDMMEHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "7")]
	public virtual void DAABDKHICHM(DEMHKDOKLMC FPJGDNNEOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "8")]
	public virtual void MFHCGMINBHG(BEPOCDMOBMH AAPGFEFGBOK, int PBKEGCHOAEH, GameObject HKLEFEBJHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "9")]
	public virtual void AGBMOMILALM(LCMNEMHMEMN POCHLMCAOAO, int EHLCELNNEBG, Material GHAIBOKEKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "10")]
	public virtual void OMECNFDAJKP(DHNJMKCGALD GIAGKAKEOKD, int BLHHNIHBHJM, Texture EGAIFAMCKGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "11")]
	public virtual void LJNEAGOLBKP(DEMHKDOKLMC FPJGDNNEOIB, int HKMFODDFBIF, GameObject OPPPNBNEPEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	protected CIAGMPPOCJL()
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
			[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000197")]
		public virtual string HelpUrl
		{
			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000198")]
		public virtual bool Enabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0x9E19910", Offset = "0x9E18310", VA = "0x189E19910", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0xA87B30", Offset = "0xA86530", VA = "0x180A87B30", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		public virtual bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		public virtual bool AlwaysEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		public virtual string Warning
		{
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		public virtual bool PackageMissing
		{
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x1575BD0", Offset = "0x15745D0", VA = "0x181575BD0")]
		protected GLTFPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[Obsolete("Use UnityGLTF.Plugins.GLTFPlugin instead. (UnityUpgradable) -> UnityGLTF.Plugins.GLTFPlugin")]
	public abstract class GltfPlugin : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0xD12090", Offset = "0xD10A90", VA = "0x180D12090")]
		protected GltfPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[Obsolete("Use UnityGLTF.Plugins.GLTFImportPlugin instead. (UnityUpgradable) -> UnityGLTF.Plugins.GLTFImportPlugin")]
	public abstract class GltfImportPlugin : GltfPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xD12090", Offset = "0xD10A90", VA = "0x180D12090")]
		protected GltfImportPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[Obsolete("Use UnityGLTF.Plugins.GLTFExportPlugin instead. (UnityUpgradable) -> UnityGLTF.Plugins.GLTFExportPlugin")]
	public abstract class GltfExportPlugin : GltfPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0xD12090", Offset = "0xD10A90", VA = "0x180D12090")]
		protected GltfExportPlugin()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public class IGCMHMGLAFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public readonly List<CIAGMPPOCJL> OJDIJIEEPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public JGLMIIHJDFL BCHHBLKEADO;

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	public EFAGEPFJOIC BDILIHENIPK
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x9E1D3A0", Offset = "0x9E1BDA0", VA = "0x189E1D3A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x9E1D3C0", Offset = "0x9E1BDC0", VA = "0x189E1D3C0")]
	private List<CIAGMPPOCJL> DJDLKFBFCPO(GLTFSettings IMFNJOKFKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x9E1D5E0", Offset = "0x9E1BFE0", VA = "0x189E1D5E0")]
	internal IGCMHMGLAFB(GLTFSettings IMFNJOKFKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x3CB0920", Offset = "0x3CAF320", VA = "0x183CB0920")]
	public bool KDDAFJMMAFM<T>([Out] T EJBIGGIEBEA) where T : CIAGMPPOCJL
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
			[Cpp2IlInjected.Address(RVA = "0x9E15C00", Offset = "0x9E14600", VA = "0x189E15C00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0x9E15BD0", Offset = "0x9E145D0", VA = "0x189E15BD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A0")]
		public override bool PackageMissing
		{
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x9E15B80", Offset = "0x9E14580", VA = "0x189E15B80", Slot = "13")]
		public override CIAGMPPOCJL FCAIPCNJKCP(IGCMHMGLAFB HCLPHJDKMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x1575BD0", Offset = "0x15745D0", VA = "0x181575BD0")]
		public DracoImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public class AEIAEJOHNBA : CIAGMPPOCJL
{
	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public AEIAEJOHNBA()
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
			[Cpp2IlInjected.Address(RVA = "0x9E1A640", Offset = "0x9E19040", VA = "0x189E1A640", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A2")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(RVA = "0x9E1A610", Offset = "0x9E19010", VA = "0x189E1A610", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x9E1A5C0", Offset = "0x9E18FC0", VA = "0x189E1A5C0", Slot = "13")]
		public override CIAGMPPOCJL FCAIPCNJKCP(IGCMHMGLAFB HCLPHJDKMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x1575BD0", Offset = "0x15745D0", VA = "0x181575BD0")]
		public GPUInstancingImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public class IPEDBIOICLM : CIAGMPPOCJL
{
	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public IPEDBIOICLM()
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
			[Cpp2IlInjected.Address(RVA = "0x9E23310", Offset = "0x9E21D10", VA = "0x189E23310", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A4")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0x9E232E0", Offset = "0x9E21CE0", VA = "0x189E232E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A5")]
		public override bool PackageMissing
		{
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x9E23290", Offset = "0x9E21C90", VA = "0x189E23290", Slot = "13")]
		public override CIAGMPPOCJL FCAIPCNJKCP(IGCMHMGLAFB HCLPHJDKMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x1575BD0", Offset = "0x15745D0", VA = "0x181575BD0")]
		public Ktx2Import()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public class JKOIOMOFNEP : CIAGMPPOCJL
{
	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public JKOIOMOFNEP()
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
			[Cpp2IlInjected.Address(RVA = "0x9E23820", Offset = "0x9E22220", VA = "0x189E23820", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A7")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x9E237F0", Offset = "0x9E221F0", VA = "0x189E237F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x9E237A0", Offset = "0x9E221A0", VA = "0x189E237A0", Slot = "14")]
		public override PDBJIPMJIIJ FCAIPCNJKCP(LIDEFDAPMMN HCLPHJDKMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x1575BD0", Offset = "0x15745D0", VA = "0x181575BD0")]
		public LightsPunctualExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public class MCHEOKAHMLC : PDBJIPMJIIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "8")]
	public override void MEPLLBKDIJM(GENLMNMPIND HIMDLPAHKOO, EFAGEPFJOIC MLPDGDMMEHF, Transform EOBBLENOIHL, BEPOCDMOBMH AAPGFEFGBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public MCHEOKAHMLC()
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
			[Cpp2IlInjected.Address(RVA = "0x9E238D0", Offset = "0x9E222D0", VA = "0x189E238D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A9")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x9E238A0", Offset = "0x9E222A0", VA = "0x189E238A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x9E23850", Offset = "0x9E22250", VA = "0x189E23850", Slot = "13")]
		public override CIAGMPPOCJL FCAIPCNJKCP(IGCMHMGLAFB HCLPHJDKMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x1575BD0", Offset = "0x15745D0", VA = "0x181575BD0")]
		public LightsPunctualImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public class KCDNABMOJHG : CIAGMPPOCJL
{
	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public KCDNABMOJHG()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[BLFADFOELKL(null)]
	public class LodsExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0x9E23980", Offset = "0x9E22380", VA = "0x189E23980", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0x9E23950", Offset = "0x9E22350", VA = "0x189E23950", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x9E23900", Offset = "0x9E22300", VA = "0x189E23900", Slot = "14")]
		public override PDBJIPMJIIJ FCAIPCNJKCP(LIDEFDAPMMN HCLPHJDKMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x1575BD0", Offset = "0x15745D0", VA = "0x181575BD0")]
		public LodsExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public class APNOIICNMGJ : PDBJIPMJIIJ
{
	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x9E154D0", Offset = "0x9E13ED0", VA = "0x189E154D0", Slot = "8")]
	public override void MEPLLBKDIJM(GENLMNMPIND HIMDLPAHKOO, EFAGEPFJOIC NOLLCKNLCCB, Transform EOBBLENOIHL, BEPOCDMOBMH AAPGFEFGBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public APNOIICNMGJ()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[BLFADFOELKL(null)]
	public class LodsImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000460")]
			[Cpp2IlInjected.Address(RVA = "0x9E23A30", Offset = "0x9E22430", VA = "0x189E23A30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0x9E23A00", Offset = "0x9E22400", VA = "0x189E23A00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x9E239B0", Offset = "0x9E223B0", VA = "0x189E239B0", Slot = "13")]
		public override CIAGMPPOCJL FCAIPCNJKCP(IGCMHMGLAFB HCLPHJDKMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x1575BD0", Offset = "0x15745D0", VA = "0x181575BD0")]
		public LodsImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public class BAKDGAEOGIL : CIAGMPPOCJL
{
	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public BAKDGAEOGIL()
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
			[Cpp2IlInjected.Address(RVA = "0x9E24D00", Offset = "0x9E23700", VA = "0x189E24D00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0x9E24CD0", Offset = "0x9E236D0", VA = "0x189E24CD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x9E24C40", Offset = "0x9E23640", VA = "0x189E24C40", Slot = "14")]
		public override PDBJIPMJIIJ FCAIPCNJKCP(LIDEFDAPMMN HCLPHJDKMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x9E24CB0", Offset = "0x9E236B0", VA = "0x189E24CB0")]
		public MaterialExtensionsExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public class FKBCJFBAPKN : PDBJIPMJIIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	internal readonly MaterialExtensionsExport IMFNJOKFKEG;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private static readonly int MHPPONDCHGN;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private static readonly int KMKLIHLIJEL;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private static readonly int BHHADFIMHKL;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	private static readonly int NHJGPDGGMEP;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	private static readonly int NJGLGAEGFIH;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	private static readonly int JHFJOIPFAHI;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	private static readonly int JBCCDIHFHOD;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	private static readonly int KPNCLFNDLDI;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	private static readonly int JBCLJMHGIND;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	private static readonly int NIJNLPNHAEE;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	private static readonly int KLMKODNGECL;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	private static readonly int PKEHPAGAPLE;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	private static readonly int KCIAFEMHOJH;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	private static readonly int PPKEHGHBABG;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	private static readonly int FOKJJPBDIHN;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	private static readonly int GCJDHIPKEMF;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	private static readonly int DOKANEEMOAA;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	private static readonly int LCEFEOKKHGE;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	private static readonly int AGANKIBGEAM;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	private static readonly int CAGGKNAAPPE;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	private static readonly int CCDFGEGPINC;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	private static readonly int KIFFPFLJEPK;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	private static readonly int OMGMHKPBMMB;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	private static readonly int HNMKOEJIANG;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	private static readonly int DCBNPCNLICJ;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	private static readonly int GIKMCGLIOPH;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	private static readonly int HCFIFKAIDAK;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	private static readonly int CBEBGDINMHD;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	private static readonly int BAGBCEIELLD;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	private static readonly int DDNLFFCHEEN;

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0xA93860", Offset = "0xA92260", VA = "0x180A93860")]
	public FKBCJFBAPKN(MaterialExtensionsExport IMFNJOKFKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x9E16C90", Offset = "0x9E15690", VA = "0x189E16C90", Slot = "10")]
	public override void IGOMIKDBHHA(GENLMNMPIND HIMDLPAHKOO, EFAGEPFJOIC NOLLCKNLCCB, Material POCHLMCAOAO, LCMNEMHMEMN DBEOJOFBDMJ)
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
			[Cpp2IlInjected.Address(RVA = "0x9E24DF0", Offset = "0x9E237F0", VA = "0x189E24DF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0x9E24DC0", Offset = "0x9E237C0", VA = "0x189E24DC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x9E24D30", Offset = "0x9E23730", VA = "0x189E24D30", Slot = "13")]
		public override CIAGMPPOCJL FCAIPCNJKCP(IGCMHMGLAFB HCLPHJDKMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x9E24DA0", Offset = "0x9E237A0", VA = "0x189E24DA0")]
		public MaterialExtensionsImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class MKEACAGOLDP : CIAGMPPOCJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	internal readonly MaterialExtensionsImport IMFNJOKFKEG;

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0xA93860", Offset = "0xA92260", VA = "0x180A93860")]
	public MKEACAGOLDP(MaterialExtensionsImport JLIJDPOLOEM)
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
			[Cpp2IlInjected.Address(RVA = "0x9E24EA0", Offset = "0x9E238A0", VA = "0x189E24EA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0x9E24E70", Offset = "0x9E23870", VA = "0x189E24E70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		public override bool PackageMissing
		{
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x9E24E20", Offset = "0x9E23820", VA = "0x189E24E20", Slot = "13")]
		public override CIAGMPPOCJL FCAIPCNJKCP(IGCMHMGLAFB HCLPHJDKMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x1575BD0", Offset = "0x15745D0", VA = "0x181575BD0")]
		public MeshoptImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public class PAKFKKKPGMD : CIAGMPPOCJL
{
	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public PAKFKKKPGMD()
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
			[Cpp2IlInjected.Address(RVA = "0x9E25250", Offset = "0x9E23C50", VA = "0x189E25250", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0x9E25220", Offset = "0x9E23C20", VA = "0x189E25220", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		public override bool AlwaysEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000479")]
			[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "14")]
		public override PDBJIPMJIIJ FCAIPCNJKCP(LIDEFDAPMMN HCLPHJDKMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x1575BD0", Offset = "0x15745D0", VA = "0x181575BD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9E252B0", Offset = "0x9E23CB0", VA = "0x189E252B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B9")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600047D")]
			[Cpp2IlInjected.Address(RVA = "0x9E25280", Offset = "0x9E23C80", VA = "0x189E25280", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		public override bool AlwaysEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x600047E")]
			[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "13")]
		public override CIAGMPPOCJL FCAIPCNJKCP(IGCMHMGLAFB HCLPHJDKMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x1575BD0", Offset = "0x15745D0", VA = "0x181575BD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9E26210", Offset = "0x9E24C10", VA = "0x189E26210", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000482")]
			[Cpp2IlInjected.Address(RVA = "0x9E261E0", Offset = "0x9E24BE0", VA = "0x189E261E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		public override bool AlwaysEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000483")]
			[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "14")]
		public override PDBJIPMJIIJ FCAIPCNJKCP(LIDEFDAPMMN HCLPHJDKMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x1575BD0", Offset = "0x15745D0", VA = "0x181575BD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9E26270", Offset = "0x9E24C70", VA = "0x189E26270", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000487")]
			[Cpp2IlInjected.Address(RVA = "0x9E26240", Offset = "0x9E24C40", VA = "0x189E26240", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		public override bool AlwaysEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "13")]
		public override CIAGMPPOCJL FCAIPCNJKCP(IGCMHMGLAFB HCLPHJDKMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x1575BD0", Offset = "0x15745D0", VA = "0x181575BD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9E262D0", Offset = "0x9E24CD0", VA = "0x189E262D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C2")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600048C")]
			[Cpp2IlInjected.Address(RVA = "0x9E262A0", Offset = "0x9E24CA0", VA = "0x189E262A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C3")]
		public override bool AlwaysEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "14")]
		public override PDBJIPMJIIJ FCAIPCNJKCP(LIDEFDAPMMN HCLPHJDKMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x1575BD0", Offset = "0x15745D0", VA = "0x181575BD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9E26330", Offset = "0x9E24D30", VA = "0x189E26330", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000492")]
			[Cpp2IlInjected.Address(RVA = "0x9E26300", Offset = "0x9E24D00", VA = "0x189E26300", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		public override bool AlwaysEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000493")]
			[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "13")]
		public override CIAGMPPOCJL FCAIPCNJKCP(IGCMHMGLAFB HCLPHJDKMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x1575BD0", Offset = "0x15745D0", VA = "0x181575BD0")]
		public VisibilityImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public class MOICFAODJKA
{
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	internal class KKDOMJADLCM : MemoryStream
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public readonly string MOJKBBFEJHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public readonly string EGPLIGCJDHP;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public interface JEOKGPMFBLN
{
	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<Stream> NPKMPCKFKPP(string KOJMHHJOALH);
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public interface JNPBKMIAFKH : JEOKGPMFBLN
{
	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Stream GKLMPNPLLMH(string KOJMHHJOALH);
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[Obsolete("Please switch to IDataLoader.  This interface is deprecated and will be removed in a future release.")]
public interface IGJJAMLKKOF
{
	[Cpp2IlInjected.Token(Token = "0x170001C8")]
	Stream MHOFBJBJJEE
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	bool BEPLMEPEOCG
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task GKLMPNPLLMH(string KOJMHHJOALH);

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EBFFFPPECLI(string NPDJAHAHDEJ);
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public static class HPAJNAJKOHA
{
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	private class NFHBLJFBFFF : JEOKGPMFBLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		protected readonly IGJJAMLKKOF LMGOLEHOBCH;

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0xA93860", Offset = "0xA92260", VA = "0x180A93860")]
		public NFHBLJFBFFF(IGJJAMLKKOF CIGIHDPILIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x9E24ED0", Offset = "0x9E238D0", VA = "0x189E24ED0", Slot = "4")]
		public Task<Stream> NPKMPCKFKPP(string KOJMHHJOALH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	private class FKBILNLAAJO : NFHBLJFBFFF, JNPBKMIAFKH, JEOKGPMFBLN
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0xA93860", Offset = "0xA92260", VA = "0x180A93860")]
		public FKBILNLAAJO(IGJJAMLKKOF CIGIHDPILIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x9E197C0", Offset = "0x9E181C0", VA = "0x189E197C0", Slot = "5")]
		public Stream GKLMPNPLLMH(string KOJMHHJOALH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x9E1B8C0", Offset = "0x9E1A2C0", VA = "0x189E1B8C0")]
	public static JEOKGPMFBLN BANEKPHAKMP(IGJJAMLKKOF CIGIHDPILIC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public class MIPBAOPBPDJ : JEOKGPMFBLN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private struct IEGBOGCHGMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public AsyncTaskMethodBuilder<Stream> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public MIPBAOPBPDJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x9E1CC10", Offset = "0x9E1B610", VA = "0x189E1CC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x9E1D330", Offset = "0x9E1BD30", VA = "0x189E1D330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	private string HLDFGBGLIFF;

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0xA93860", Offset = "0xA92260", VA = "0x180A93860")]
	public MIPBAOPBPDJ(string HLDFGBGLIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x9E23A60", Offset = "0x9E22460", VA = "0x189E23A60", Slot = "4")]
	[AsyncStateMachine(typeof(IEGBOGCHGMO))]
	public Task<Stream> NPKMPCKFKPP(string KOJMHHJOALH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public class FJBLHCCIDHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	private readonly List<DMMFIILHJNO> EFEHDGLBCBG;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	private static readonly ProfilerMarker CNDPLHLHCGI;

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x9E16B40", Offset = "0x9E15540", VA = "0x189E16B40")]
	public void MJGPLOFFIKO(DMMFIILHJNO HMKDAFLEBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x9E15FC0", Offset = "0x9E149C0", VA = "0x189E15FC0")]
	public void GOAFGJPPNIN(GENLMNMPIND HIMDLPAHKOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x9E16C00", Offset = "0x9E15600", VA = "0x189E16C00")]
	public FJBLHCCIDHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public interface FMGHKJDAGLC
{
	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DPCKGIMNGFN(object IMFCAPGBDGB, string HODLOHIDPMG);
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public struct AGEILGOKDIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public HFGLIDLAEEJ ADGCIFKJEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public HFGLIDLAEEJ LPACNNPHKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public GCJBIJIFCIF EMNANIECAHI;
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public class ECKFPJOMPLC
{
	[Cpp2IlInjected.Token(Token = "0x170001CA")]
	public AnimationClip NEPHOCABHAF
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CB")]
	public AGEILGOKDIA[] LPIDFNFICFI
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x9E15C30", Offset = "0x9E14630", VA = "0x189E15C30")]
	public ECKFPJOMPLC(int LMEHDBCMOLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public class LHNOLCAEJGH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001CC")]
	public Stream[] NIPMDBHPJNI
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CD")]
	public Texture2D[] GEAHOAGCLED
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CE")]
	public Texture2D[] NHCOFGCEIIE
	{
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CF")]
	public EJCFPFKPJLJ[] IDOIKOACIHD
	{
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D0")]
	public PFOGFFHBAHP[] PIANMBBAANM
	{
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D1")]
	public BFJLBGEAFBP[] DNLKOOODNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0xA88310", Offset = "0xA86D10", VA = "0x180A88310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D2")]
	public HBLHJMLFBIB[] MBKODCEPKCB
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0xA91C70", Offset = "0xA90670", VA = "0x180A91C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0xA88530", Offset = "0xA86F30", VA = "0x180A88530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D3")]
	public BCPDNECGOAF[] FKPJKOBMCOF
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0xA88320", Offset = "0xA86D20", VA = "0x180A88320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0xA88300", Offset = "0xA86D00", VA = "0x180A88300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D4")]
	public ECKFPJOMPLC[] GPAMDBGHPBA
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0xA84210", Offset = "0xA82C10", VA = "0x180A84210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0xA84220", Offset = "0xA82C20", VA = "0x180A84220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D5")]
	public GameObject[] DJEEPBBNGMC
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0xA84200", Offset = "0xA82C00", VA = "0x180A84200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0xA84190", Offset = "0xA82B90", VA = "0x180A84190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x9E234C0", Offset = "0x9E21EC0", VA = "0x189E234C0")]
	public LHNOLCAEJGH(EFAGEPFJOIC PJFDNMGHMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x9E233B0", Offset = "0x9E21DB0", VA = "0x189E233B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public class BFJLBGEAFBP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001D6")]
	public uint MHCHOIPEDKE
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		[CompilerGenerated]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D7")]
	public Stream JGEIGCGPHON
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D8")]
	public NativeArray<byte> JIJHHLEOJHF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0xE7AD80", Offset = "0xE79780", VA = "0x180E7AD80")]
		[CompilerGenerated]
		get
		{
			return default(NativeArray<byte>);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0xF67A70", Offset = "0xF66470", VA = "0x180F67A70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x71B3AD0", Offset = "0x71B24D0", VA = "0x1871B3AD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public BFJLBGEAFBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
internal static class GBHEHGJFPJL
{
	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0xF3F300", Offset = "0xF3DD00", VA = "0x180F3F300")]
	public static bool ANNBMIIIAGK(UnityEngine.Object PEPAIGKDMLN, string KKFEAIHODFG, [Out] byte[] LHALFHPGBPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40")]
	public static void ODAAHMNBFLF(UnityEngine.Object PEPAIGKDMLN, string KKFEAIHODFG, byte[] LHALFHPGBPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public class PFOGFFHBAHP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001D9")]
	public Material KMAGFKFCNOL
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DA")]
	public Material NEDDELMIFNB
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DB")]
	public LCMNEMHMEMN OOBDKCGIGEK
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x9E25120", Offset = "0x9E23B20", VA = "0x189E25120", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public PFOGFFHBAHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public class HBLHJMLFBIB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public class NJDNEAHEOIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public bool PAAHDGMALDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public Dictionary<string, HFGLIDLAEEJ> BGBCIOOKMOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public List<Dictionary<string, HFGLIDLAEEJ>> IGBOJCMDLCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public Dictionary<string, (HFGLIDLAEEJ sparseIndices, HFGLIDLAEEJ sparseValues)> LFOLBJFCMIK;

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x9E24FF0", Offset = "0x9E239F0", VA = "0x189E24FF0")]
		public NJDNEAHEOIL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public List<NJDNEAHEOIL> BCBFHCALMCB;

	[Cpp2IlInjected.Token(Token = "0x170001DC")]
	public Mesh LMPJDFEIKCD
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x9E1A670", Offset = "0x9E19070", VA = "0x189E1A670", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x9E1A710", Offset = "0x9E19110", VA = "0x189E1A710")]
	public HBLHJMLFBIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public class AFHEPOOAMDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000427")]
	private bool NNCAPPLEPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000428")]
	private int MMPHOCOAHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000429")]
	private readonly object ADGEKHCOCDN;

	[Cpp2IlInjected.Token(Token = "0x170001DD")]
	public HBLHJMLFBIB[] MBKODCEPKCB
	{
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DE")]
	public UnityEngine.Object[] BLNDMOBLLKD
	{
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DF")]
	public PFOGFFHBAHP[] PIANMBBAANM
	{
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E0")]
	public EJCFPFKPJLJ[] IDOIKOACIHD
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0xA88310", Offset = "0xA86D10", VA = "0x180A88310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E1")]
	public ECKFPJOMPLC[] GPAMDBGHPBA
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0xA91C70", Offset = "0xA90670", VA = "0x180A91C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0xA88530", Offset = "0xA86F30", VA = "0x180A88530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E2")]
	public Texture2D[] GEAHOAGCLED
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0xA88320", Offset = "0xA86D20", VA = "0x180A88320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0xA88300", Offset = "0xA86D00", VA = "0x180A88300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x9E153C0", Offset = "0x9E13DC0", VA = "0x189E153C0")]
	public AFHEPOOAMDB(PFOGFFHBAHP[] ELGBBDONKHF, HBLHJMLFBIB[] DNGHGLLNCDM, EJCFPFKPJLJ[] PAHCNCBJGLJ, Texture2D[] HBNDGFBOHAF, ECKFPJOMPLC[] KPFEPLNIFIJ, UnityEngine.Object[] LJLANOBMFJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x9E14D80", Offset = "0x9E13780", VA = "0x189E14D80")]
	public void HGOMIIPOKDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x9E14E70", Offset = "0x9E13870", VA = "0x189E14E70")]
	public void IANLFOKBKPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x9E14FD0", Offset = "0x9E139D0", VA = "0x189E14FD0")]
	private void NMLCMGMNMMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public class EJCFPFKPJLJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public DHNJMKCGALD GKFFELFKIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public Texture2D IBEMOGNKKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public bool LDCCADJJOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public bool KLOIJNMMCLP;

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x9E15C90", Offset = "0x9E14690", VA = "0x189E15C90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public EJCFPFKPJLJ()
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
