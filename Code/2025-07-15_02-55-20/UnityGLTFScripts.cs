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
		private struct LNDFDMIFIPO : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x9BE9130", Offset = "0x9BE7D30", VA = "0x189BE9130", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9BE9320", Offset = "0x9BE7F20", VA = "0x189BE9320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class OJCJKPFBKEP : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
			[DebuggerHidden]
			public OJCJKPFBKEP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9BE9BE0", Offset = "0x9BE87E0", VA = "0x189BE9BE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9BE9C60", Offset = "0x9BE8860", VA = "0x189BE9C60", Slot = "8")]
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
		private WaitForEndOfFrame NAAMHNMFFLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private float GDPIKKFDPEE;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9BE29A0", Offset = "0x9BE15A0", VA = "0x189BE29A0")]
		[AsyncStateMachine(typeof(LNDFDMIFIPO))]
		public Task YieldOnTimeout()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9BE2910", Offset = "0x9BE1510", VA = "0x189BE2910")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BE2890", Offset = "0x9BE1490", VA = "0x189BE2890")]
		[IteratorStateMachine(typeof(OJCJKPFBKEP))]
		private IEnumerator KJPECDBMEDC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9BE2A70", Offset = "0x9BE1670", VA = "0x189BE2A70")]
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
		private struct ADOADEPBIFP : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x9BD52D0", Offset = "0x9BD3ED0", VA = "0x189BD52D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xAB3320", Offset = "0xAB1F20", VA = "0x180AB3320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private struct HIJOLAKCHDG : IAsyncStateMachine
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
			private CALMGHCKIPD <importOptions>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private AOLODCHEPKL <sceneImporter>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9BE6110", Offset = "0x9BE4D10", VA = "0x189BE6110", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x9BE6E10", Offset = "0x9BE5A10", VA = "0x189BE6E10", Slot = "5")]
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
		private int JGPBADPNPGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int MaximumLod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int Timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AOLODCHEPKL.BJFIMHOFDME Collider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private Shader shaderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[Header("Import Settings")]
		public DMCBMPFCLKI TextureCompression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CMGEHFAFAMK ImportNormals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CMGEHFAFAMK ImportTangents;

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
		public IEnumerable<Animation> HGBLOFFGEPB
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA5B560", Offset = "0xA5A160", VA = "0x180A5B560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA5B5D0", Offset = "0xA5A1D0", VA = "0x180A5B5D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public GameObject MBBLFJPKPHN
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA633E0", Offset = "0xA61FE0", VA = "0x180A633E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA633D0", Offset = "0xA61FD0", VA = "0x180A633D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Shader NDEDEJPDKEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xA5B760", Offset = "0xA5A360", VA = "0x180A5B760")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x9BE5760", Offset = "0x9BE4360", VA = "0x189BE5760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9BE5640", Offset = "0x9BE4240", VA = "0x189BE5640")]
		[AsyncStateMachine(typeof(ADOADEPBIFP))]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9BE5570", Offset = "0x9BE4170", VA = "0x189BE5570")]
		[AsyncStateMachine(typeof(HIJOLAKCHDG))]
		public Task Load()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9BE5480", Offset = "0x9BE4080", VA = "0x189BE5480")]
		public void ApplyOverrideShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1000940", Offset = "0xFFF540", VA = "0x181000940")]
		private void GHFIJCPKMGG(GameObject KOJLNGLNBMH, ExceptionDispatchInfo ELKIGOLDKPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9BE56F0", Offset = "0x9BE42F0", VA = "0x189BE56F0")]
		public GLTFComponent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class GLTFRecorderComponent : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class FPMEDGBNJMI : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
			[DebuggerHidden]
			public FPMEDGBNJMI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9BE4480", Offset = "0x9BE3080", VA = "0x189BE4480", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x9BE4550", Offset = "0x9BE3150", VA = "0x189BE4550", Slot = "8")]
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
		protected GNNCEMBODDB NGBHBPNAPEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public UnityEvent recordingStarted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public UnityEvent<string> recordingEnded;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool JAJLLJAPGIL
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9BE5FB0", Offset = "0x9BE4BB0", VA = "0x189BE5FB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private double OAACALLFBJD
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x9BE58F0", Offset = "0x9BE44F0", VA = "0x189BE58F0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9BE5A40", Offset = "0x9BE4640", VA = "0x189BE5A40", Slot = "4")]
		[ContextMenu("Start Recording")]
		public virtual void StartRecording()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9BE5DE0", Offset = "0x9BE49E0", VA = "0x189BE5DE0", Slot = "5")]
		[ContextMenu("Stop Recording")]
		public virtual void StopRecording()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9BE5790", Offset = "0x9BE4390", VA = "0x189BE5790")]
		private void DBGMJGMLEIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9BE5D50", Offset = "0x9BE4950", VA = "0x189BE5D50")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9BE5A20", Offset = "0x9BE4620", VA = "0x189BE5A20")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9BE59D0", Offset = "0x9BE45D0", VA = "0x189BE59D0", Slot = "6")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9BE5980", Offset = "0x9BE4580", VA = "0x189BE5980", Slot = "7")]
		protected virtual void NNJFPFLACNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9BE5900", Offset = "0x9BE4500", VA = "0x189BE5900")]
		[IteratorStateMachine(typeof(FPMEDGBNJMI))]
		private IEnumerator NENPIIJMGNE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9BE5EE0", Offset = "0x9BE4AE0", VA = "0x189BE5EE0")]
		public GLTFRecorderComponent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9BE5790", Offset = "0x9BE4390", VA = "0x189BE5790")]
		[CompilerGenerated]
		private void DFKDBGKBGMH(InputAction.CallbackContext HPNKJCMLGMJ)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class CCCKJDAIOAF
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal class MBEKJEJGOBB : HAINKNBMHAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly CCCKJDAIOAF DAMDELBIHFM;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA87960", Offset = "0xA86560", VA = "0x180A87960")]
		internal MBEKJEJGOBB(CCCKJDAIOAF PBHLPKLGFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9BE9380", Offset = "0x9BE7F80", VA = "0x189BE9380", Slot = "4")]
		public override void BAODBFMAJHO(DDIHIDBGEBH OOJHOOBDAMG, EEBBIHGHGOL LPFALNIFEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9BE94B0", Offset = "0x9BE80B0", VA = "0x189BE94B0", Slot = "5")]
		public override void LEFJOHKPFPH(DDIHIDBGEBH OOJHOOBDAMG, EEBBIHGHGOL LPFALNIFEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9BE94F0", Offset = "0x9BE80F0", VA = "0x189BE94F0", Slot = "8")]
		public override void MLOPPEFHAKP(DDIHIDBGEBH OOJHOOBDAMG, EEBBIHGHGOL LPFALNIFEHN, Transform LMGPODOPMIJ, GCJECACEHBN PBBEMEGKFPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9BE9530", Offset = "0x9BE8130", VA = "0x189BE9530", Slot = "9")]
		public override bool OAAPCPEPDAP(DDIHIDBGEBH OOJHOOBDAMG, EEBBIHGHGOL LPFALNIFEHN, Material CIBNABIMGCK, IBKALPNABJD FIAJENKIKEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9BE9640", Offset = "0x9BE8240", VA = "0x189BE9640", Slot = "10")]
		public override void OCDIPALLGIC(DDIHIDBGEBH OOJHOOBDAMG, EEBBIHGHGOL LPFALNIFEHN, Material CIBNABIMGCK, IBKALPNABJD FIAJENKIKEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9BE9470", Offset = "0x9BE8070", VA = "0x189BE9470", Slot = "11")]
		public override void LAFPBIBAEAN(DDIHIDBGEBH OOJHOOBDAMG, DDIHIDBGEBH.EFKNFANKFBH PMMGDHEEDKB, string OKCBMOOGHJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9BE9400", Offset = "0x9BE8000", VA = "0x189BE9400", Slot = "12")]
		public override void KAPEMAFAEKC(DDIHIDBGEBH OOJHOOBDAMG, DDIHIDBGEBH.EFKNFANKFBH PMMGDHEEDKB, int LCCBBMBENOH, BHPGBKFIKFO BAPGOEBIAGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9BE9680", Offset = "0x9BE8280", VA = "0x189BE9680", Slot = "13")]
		public override void PIEKGLNNFFF(DDIHIDBGEBH OOJHOOBDAMG, Mesh MOGMOMKEFJC, CGAJCOIJKND LENPJBDMDOJ, int LCCBBMBENOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9BE93C0", Offset = "0x9BE7FC0", VA = "0x189BE93C0", Slot = "14")]
		public override void ILKKGACOAFC(DDIHIDBGEBH OOJHOOBDAMG, Mesh MOGMOMKEFJC, BJCLAFDPBIO MKGHNILONOF, int LCCBBMBENOH)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public bool OOHDGHPLJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public LayerMask HLCEHFHDLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public ILogger BOCJBHAACPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal readonly GLTFSettings DKFCHCGNBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public DDIHIDBGEBH.BJJFAEPGLLO JCDMNGHHGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public DDIHIDBGEBH.NJICKLANOAF LEFJOHKPFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public DDIHIDBGEBH.NJHOJBEMKFN BAODBFMAJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public DDIHIDBGEBH.ECEEJLCPCNN MLOPPEFHAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public DDIHIDBGEBH.GMMAJJILMNK OAAPCPEPDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public DDIHIDBGEBH.MMHLANAGEEA OCDIPALLGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public DDIHIDBGEBH.JJMIOMJNHPM LAFPBIBAEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public DDIHIDBGEBH.MDGNCJCFFIF KAPEMAFAEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public DDIHIDBGEBH.JLMOOINOMIF PIEKGLNNFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public DDIHIDBGEBH.PAHCFOIBKEN ILKKGACOAFC;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x9BE2E80", Offset = "0x9BE1A80", VA = "0x189BE2E80")]
	public CCCKJDAIOAF(GLTFSettings DKFCHCGNBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x9BE2E10", Offset = "0x9BE1A10", VA = "0x189BE2E10")]
	internal HAINKNBMHAH OHBIBPDAMFH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class DDIHIDBGEBH
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate string BJJFAEPGLLO(Texture PMMGDHEEDKB);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public delegate void NJHOJBEMKFN(DDIHIDBGEBH OOJHOOBDAMG, EEBBIHGHGOL LPFALNIFEHN);

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate void NJICKLANOAF(DDIHIDBGEBH OOJHOOBDAMG, EEBBIHGHGOL LPFALNIFEHN);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate void ECEEJLCPCNN(DDIHIDBGEBH OOJHOOBDAMG, EEBBIHGHGOL LPFALNIFEHN, Transform LMGPODOPMIJ, GCJECACEHBN PBBEMEGKFPO);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate bool GMMAJJILMNK(DDIHIDBGEBH OOJHOOBDAMG, EEBBIHGHGOL LPFALNIFEHN, Material CIBNABIMGCK, IBKALPNABJD FIAJENKIKEB);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void MMHLANAGEEA(DDIHIDBGEBH OOJHOOBDAMG, EEBBIHGHGOL LPFALNIFEHN, Material CIBNABIMGCK, IBKALPNABJD FIAJENKIKEB);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void JJMIOMJNHPM(DDIHIDBGEBH OOJHOOBDAMG, EFKNFANKFBH PMMGDHEEDKB, string OKCBMOOGHJA);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public delegate void MDGNCJCFFIF(DDIHIDBGEBH OOJHOOBDAMG, EFKNFANKFBH PMMGDHEEDKB, int LCCBBMBENOH, BHPGBKFIKFO BAPGOEBIAGP);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public delegate void JLMOOINOMIF(DDIHIDBGEBH OOJHOOBDAMG, Mesh MOGMOMKEFJC, CGAJCOIJKND LENPJBDMDOJ, int LCCBBMBENOH);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate void PAHCFOIBKEN(DDIHIDBGEBH OOJHOOBDAMG, Mesh MOGMOMKEFJC, BJCLAFDPBIO MKGHNILONOF, int LCCBBMBENOH);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class FPFKPMPIGNP : HAINKNBMHAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9BE4160", Offset = "0x9BE2D60", VA = "0x189BE4160", Slot = "5")]
		public override void LEFJOHKPFPH(DDIHIDBGEBH OOJHOOBDAMG, EEBBIHGHGOL LPFALNIFEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9BE40E0", Offset = "0x9BE2CE0", VA = "0x189BE40E0", Slot = "4")]
		public override void BAODBFMAJHO(DDIHIDBGEBH OOJHOOBDAMG, EEBBIHGHGOL LPFALNIFEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9BE41E0", Offset = "0x9BE2DE0", VA = "0x189BE41E0", Slot = "8")]
		public override void MLOPPEFHAKP(DDIHIDBGEBH OOJHOOBDAMG, EEBBIHGHGOL LPFALNIFEHN, Transform LMGPODOPMIJ, GCJECACEHBN PBBEMEGKFPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9BE4280", Offset = "0x9BE2E80", VA = "0x189BE4280", Slot = "9")]
		public override bool OAAPCPEPDAP(DDIHIDBGEBH OOJHOOBDAMG, EEBBIHGHGOL LPFALNIFEHN, Material CIBNABIMGCK, IBKALPNABJD FIAJENKIKEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9BE43E0", Offset = "0x9BE2FE0", VA = "0x189BE43E0", Slot = "10")]
		public override void OCDIPALLGIC(DDIHIDBGEBH OOJHOOBDAMG, EEBBIHGHGOL LPFALNIFEHN, Material CIBNABIMGCK, IBKALPNABJD FIAJENKIKEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
		public FPFKPMPIGNP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct KGKHGGDIHMA
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public enum JGNBNILHLFH
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
		public enum JDEKGKONJKL
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
		public bool FMJNMGABEIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public JGNBNILHLFH MDDDEIDKGPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public JDEKGKONJKL JDDNDICAMBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool NDOPACMFJFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public float NCLJPPIIBLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public float HLDIPNONAIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public float GLCLGAHBAGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public float PKPPAKCONHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public float DOAPCGHPAGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public float KCDGFFLAFAA;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x9BE8D70", Offset = "0x9BE7970", VA = "0x189BE8D70")]
		public KGKHGGDIHMA(KGKHGGDIHMA NDMEBHICHPO)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9BE8A80", Offset = "0x9BE7680", VA = "0x189BE8A80")]
		public static bool CDGFDPOPEPC(KGKHGGDIHMA OHEOONFKODG, KGKHGGDIHMA GOPANKCDGOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9BE8C90", Offset = "0x9BE7890", VA = "0x189BE8C90")]
		public bool PIPOKDEFBMK(KGKHGGDIHMA IIOGPDPGOLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9BE8AC0", Offset = "0x9BE76C0", VA = "0x189BE8AC0", Slot = "0")]
		public override bool Equals(object KOJLNGLNBMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9BE8B70", Offset = "0x9BE7770", VA = "0x189BE8B70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private struct NDBCACEBBMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Texture2D PMMGDHEEDKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public KGKHGGDIHMA FDBOPEFNJMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public string PGCOKGKPHFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public bool HBCCBGHLALN;
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private struct ONBMINKOBOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Stream NKIPIPEKKIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public string LIKDLCABCDK;
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct EFKNFANKFBH : IEquatable<EFKNFANKFBH>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Texture DPGDMBNBPIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public int ADEGOEAHCGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public KGKHGGDIHMA EPFPIIOEMLI;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x9BE3D70", Offset = "0x9BE2970", VA = "0x189BE3D70")]
		public int PGJKLIJGELB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9BE3D30", Offset = "0x9BE2930", VA = "0x189BE3D30")]
		public int NCNPFKIDMMO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x9BE3DB0", Offset = "0x9BE29B0", VA = "0x189BE3DB0")]
		public EFKNFANKFBH(Texture BAPGOEBIAGP, string OKCBMOOGHJA, DDIHIDBGEBH OOJHOOBDAMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9BE3E60", Offset = "0x9BE2A60", VA = "0x189BE3E60")]
		public EFKNFANKFBH(Texture BAPGOEBIAGP, KGKHGGDIHMA LEGIHKBKMMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9BE3AD0", Offset = "0x9BE26D0", VA = "0x189BE3AD0", Slot = "4")]
		public bool Equals(EFKNFANKFBH IIOGPDPGOLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9BE3A10", Offset = "0x9BE2610", VA = "0x189BE3A10", Slot = "0")]
		public override bool Equals(object KOJLNGLNBMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9BE3C90", Offset = "0x9BE2890", VA = "0x189BE3C90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct NJEIBHGFHGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Mesh FFKMDKFBNNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Material[] DINLCIFLIOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public SkinnedMeshRenderer ECELJBLLCKD;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x9BE9A70", Offset = "0x9BE8670", VA = "0x189BE9A70")]
		public bool PIPOKDEFBMK(NJEIBHGFHGB IIOGPDPGOLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9BE9870", Offset = "0x9BE8470", VA = "0x189BE9870", Slot = "0")]
		public override bool Equals(object KOJLNGLNBMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x9BE9920", Offset = "0x9BE8520", VA = "0x189BE9920", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private struct EPFHHINGOAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public OKIMNFHOFJN IGNINGBFAED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public OKIMNFHOFJN HMPJLCABIHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public OKIMNFHOFJN EILMOIOFMPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public OKIMNFHOFJN BPHMLPABNCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public OKIMNFHOFJN JJPCLFLLDIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public OKIMNFHOFJN COFMGGPFHIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public OKIMNFHOFJN EPMFFBFCDIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public OKIMNFHOFJN PHNFKNJDGMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public OKIMNFHOFJN BBBPILDJNMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public Dictionary<int, CGAJCOIJKND> PCICFCKOBHA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct JIOPGOGBNFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public List<Dictionary<string, OKIMNFHOFJN>> AHNBPPOPJNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public List<double> GEEDPNAIKKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public List<string> GHDPFDNLDNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		internal SkinnedMeshRenderer KEGCIIJNNBH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct BPOFNJAOFDB : IEquatable<BPOFNJAOFDB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly TextureWrapMode BONOAPNJDAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly FilterMode KCLJHPPKDIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly bool ANGHBAELHLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly bool AKCGIGBMLPO;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool BNHKKMKJFPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xE4EA70", Offset = "0xE4D670", VA = "0x180E4EA70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool ONLGBFHICGK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x7142560", Offset = "0x7141160", VA = "0x187142560")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9BE2C90", Offset = "0x9BE1890", VA = "0x189BE2C90")]
		public BPOFNJAOFDB(Texture PMMGDHEEDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9BE2AF0", Offset = "0x9BE16F0", VA = "0x189BE2AF0", Slot = "4")]
		public bool Equals(BPOFNJAOFDB IIOGPDPGOLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9BE2B20", Offset = "0x9BE1720", VA = "0x189BE2B20", Slot = "0")]
		public override bool Equals(object KOJLNGLNBMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9BE2BE0", Offset = "0x9BE17E0", VA = "0x189BE2BE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class JIEIFIGGFJN : IEnumerable<(int, CGAJCOIJKND)>, IEnumerable, IEnumerator<(int, CGAJCOIJKND)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private (int subMeshIndex, CGAJCOIJKND prim) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public DDIHIDBGEBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private Mesh mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Mesh <>3__mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private Dictionary<int, CGAJCOIJKND>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private (int, CGAJCOIJKND) System.Collections.Generic.IEnumerator<(System.Int32subMeshIndex,GLTF.Schema.MeshPrimitiveprim)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xD1C5C0", Offset = "0xD1B1C0", VA = "0x180D1C5C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((int, CGAJCOIJKND));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x9BE89A0", Offset = "0x9BE75A0", VA = "0x189BE89A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x28B1F30", Offset = "0x28B0B30", VA = "0x1828B1F30")]
		[DebuggerHidden]
		public JIEIFIGGFJN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9BE89F0", Offset = "0x9BE75F0", VA = "0x189BE89F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9BE85C0", Offset = "0x9BE71C0", VA = "0x189BE85C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9BE8570", Offset = "0x9BE7170", VA = "0x189BE8570")]
		private void BOPPOGEKEOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9BE8950", Offset = "0x9BE7550", VA = "0x189BE8950", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9BE8890", Offset = "0x9BE7490", VA = "0x189BE8890", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(int, CGAJCOIJKND)> System.Collections.Generic.IEnumerable<(System.Int32subMeshIndex,GLTF.Schema.MeshPrimitiveprim)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9BE8890", Offset = "0x9BE7490", VA = "0x189BE8890", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class EIBGABHKONI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public bool convertToLinearColor;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public EIBGABHKONI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x9BE3EF0", Offset = "0x9BE2AF0", VA = "0x189BE3EF0")]
		internal Color KABCFCNCACH(object e)
		{
			return default(Color);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class GHCACHHAKML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public float multiplier;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public GHCACHHAKML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9BE5400", Offset = "0x9BE4000", VA = "0x189BE5400")]
		internal float HPMKIDMGKFL(object e)
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static ILogger KAHGADOJMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private List<HAINKNBMHAH> KGDLDINMMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private Transform[] PNJAOKEJAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private EEBBIHGHGOL COPMBFGCJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private CHHOOPGMLMC OMCKPOINBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private LHKMCLCPHBH HGAPPCKDFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private List<NDBCACEBBMP> GMIBBMNBFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private HashSet<string> MAEDBAIBJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private List<ONBMINKOBOC> CJGNGNDEHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private HashSet<string> LGBIOJGBNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<EFKNFANKFBH> HGHKHGIBCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private Dictionary<int, int> JGOBHBNEJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private bool JNGIMIPBHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private Dictionary<int, int> OJHOLFLCKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private List<Transform> HOBDNBKPPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private int KOFJKKMNEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private CCCKJDAIOAF DAMDELBIHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private Material DPINKHCOHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private Material CEGMDLACKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private Material AALGGALOPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private bool KLPJKAIDECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<NJEIBHGFHGB, HDIKJDGIJBJ> DNFAGMKCHHD;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static ProfilerMarker ANABGLPKEKM;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static ProfilerMarker BNFFGFOBOND;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static ProfilerMarker AKJBHPKJKBA;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static ProfilerMarker AELPFJEIEMP;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static ProfilerMarker AGLKLOJANEE;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static ProfilerMarker MFCFDGANBHH;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static ProfilerMarker HBDHKEDBFCE;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static ProfilerMarker PEGIMFEMOKF;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static ProfilerMarker ENIDKDJJECA;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static ProfilerMarker JKFDCMGAFIB;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static ProfilerMarker IPCIJOMOPEP;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static ProfilerMarker CHDAMBEIELF;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static ProfilerMarker EHDPDCEKLBP;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static ProfilerMarker IMBIFJLFNOK;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static ProfilerMarker PCIAKDPGLEN;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static ProfilerMarker BNAOAPEJJHB;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static ProfilerMarker CAPLDIHMKIC;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static ProfilerMarker JKDOELOLNCI;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static ProfilerMarker EMHHLLIPIJK;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static ProfilerMarker CMONDPMNDFH;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static ProfilerMarker LKDFPPEMJOM;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static ProfilerMarker EDEHIGFHMHH;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static ProfilerMarker HAAGEKLEGPN;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static ProfilerMarker HDKBKDAACEM;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static ProfilerMarker MAHDACDNECO;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static ProfilerMarker DPDIIGNJMNB;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static ProfilerMarker JBCCIEIDFAD;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static ProfilerMarker FFDJHLCFBHC;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private static ProfilerMarker HNDMAMKHFFC;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static ProfilerMarker PAIIPHMNIEH;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static ProfilerMarker OFDKFEALCEC;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static ProfilerMarker KBDKIAFINDH;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static ProfilerMarker ADKLOIJPAIG;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static ProfilerMarker ENMNBIMMLPH;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private static ProfilerMarker JFAPFOMOFAE;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static ProfilerMarker EKFHFFJOBOO;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static ProfilerMarker CNIIOICPEHE;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static ProfilerMarker CHCDMAIFBJN;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static ProfilerMarker HPHHFAPIGJL;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private static ProfilerMarker DNHJNMCDEDF;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static ProfilerMarker ICLJLPCFLHA;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static ProfilerMarker ELDINFIPJIP;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static ProfilerMarker OMGPAGBGNLK;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static ProfilerMarker AJMGLDFCDAG;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private static ProfilerMarker HOGIOOAFPHJ;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static ProfilerMarker ECELLFNJKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private global::KJNOBCGKKOO AOOJEJABJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool? JDIBHFDCCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	internal readonly List<KCGOCDFKCOL> MPABPBNAGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly DOIFAMAIJDG NJEMLCHLMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Dictionary<int, int> KHGPLANGEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Dictionary<int, int> FOHJHFBOKFH;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	[CompilerGenerated]
	private static NJHOJBEMKFN BAODBFMAJHO;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[CompilerGenerated]
	private static NJICKLANOAF LEFJOHKPFPH;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	[CompilerGenerated]
	private static ECEEJLCPCNN MLOPPEFHAKP;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[CompilerGenerated]
	private static GMMAJJILMNK OAAPCPEPDAP;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[CompilerGenerated]
	private static MMHLANAGEEA OCDIPALLGIC;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static Material GOKABFGHPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private HashSet<Material> ACGMJJJJLHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly Dictionary<Mesh, EPFHHINGOAP> HIGHBBGLPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly Dictionary<Mesh, JIOPGOGBNFJ> EPOFJKKOCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly Dictionary<SkinnedMeshRenderer, List<double>> GEBLKBBNPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private List<Transform> CPOLLJODMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Dictionary<SkinnedMeshRenderer, Mesh> MFHDAFCCFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Dictionary<BPOFNJAOFDB, int> IIHIKIOEFCC;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyList<Transform> NEMFCKACFHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private GLTFSettings DKFCHCGNBIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9BD2B80", Offset = "0x9BD1780", VA = "0x189BD2B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private bool ELGLOHLOKDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9BB9860", Offset = "0x9BB8460", VA = "0x189BB9860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private bool DMCBKDHIJBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9BD1310", Offset = "0x9BCFF10", VA = "0x189BD1310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private bool HCBBLGGMKME
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9BBBEE0", Offset = "0x9BBAAE0", VA = "0x189BBBEE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static Material LPLIOAFHDLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9BB9D50", Offset = "0x9BB8950", VA = "0x189BB9D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x9BC2380", Offset = "0x9BC0F80", VA = "0x189BC2380")]
	public KGKHGGDIHMA HMJJCHBPOMC(string OKCBMOOGHJA)
	{
		return default(KGKHGGDIHMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x9BBDD60", Offset = "0x9BBC960", VA = "0x189BBDD60")]
	private Material GEFABDIFKNE(KGKHGGDIHMA FDBOPEFNJMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x9BD0F60", Offset = "0x9BCFB60", VA = "0x189BD0F60")]
	private static Material NHEKAKKPMNE(Material CIBNABIMGCK, KGKHGGDIHMA FDBOPEFNJMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x9BD3920", Offset = "0x9BD2520", VA = "0x189BD3920")]
	public DDIHIDBGEBH(Transform[] OLHHLDPLPMM, CCCKJDAIOAF PBHLPKLGFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x9BD1EF0", Offset = "0x9BD0AF0", VA = "0x189BD1EF0")]
	public void PHNAFFOCKEN(Stream NKIPIPEKKIL, string BEKFDLHNIFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x9BD2BA0", Offset = "0x9BD17A0", VA = "0x189BD2BA0")]
	public void PNJAKIFFKIH(string PCDDHKMCDPN, bool HBIACPKPNMO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x9BD1340", Offset = "0x9BCFF40", VA = "0x189BD1340")]
	private bool OMJOLDNFCPF(Transform LMGPODOPMIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x9BB8D20", Offset = "0x9BB7920", VA = "0x189BB8D20")]
	private FFLEHBLIIBK ALLMACDFBED(string BKILENEPEEB, Transform[] PCMEOOMKCAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x9BC75D0", Offset = "0x9BC61D0", VA = "0x189BC75D0")]
	private AOBJCOPLPOP KNJHPCBOFEK(Transform KNLCBNIINOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x9BBA360", Offset = "0x9BB8F60", VA = "0x189BBA360")]
	private static bool CMEJBBACGCL(GameObject HLOIBGDKPID, bool ABNJGFDNHCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x9BCECD0", Offset = "0x9BCD8D0", VA = "0x189BCECD0")]
	private void MECGLHJNCNG(Transform LMGPODOPMIJ, [Out] GameObject[] HINMBLJHMNM, [Out] GameObject[] IAKHPFMPPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x9BBDE40", Offset = "0x9BBCA40", VA = "0x189BBDE40")]
	private void GHCNODABJBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x9BC1F20", Offset = "0x9BC0B20", VA = "0x189BC1F20")]
	public HEKOFHNHHGD HKDALBHNKLP(EEBBIHGHGOL OLIIIAEGOLD, Material GIKENIAPJPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x9BBD500", Offset = "0x9BBC100", VA = "0x189BBD500")]
	public DPLFMIFMAHH FDKKJOCFFDI(EEBBIHGHGOL OLIIIAEGOLD, EFKNFANKFBH NEDMPAFIEII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x9BC8680", Offset = "0x9BC7280", VA = "0x189BC8680")]
	public EKOBAKDFLHN KPFOBGHMPAI(EEBBIHGHGOL OLIIIAEGOLD, Texture OCHEEGLBDCD, KGKHGGDIHMA FDBOPEFNJMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x9BC8850", Offset = "0x9BC7450", VA = "0x189BC8850")]
	private static void KPKFFNNLLMO(Stream HOKNBAKODNG, BinaryWriter CLKDMEDAKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x9BC2070", Offset = "0x9BC0C70", VA = "0x189BC2070")]
	private static void HKEEAMCFBGL(Stream NKIPIPEKKIL, byte NEJPAHMOMBG = 32, uint HJNLKBLDCGF = 4u)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x9BCB530", Offset = "0x9BCA130", VA = "0x189BCB530")]
	public static uint LIJNIEDEMKG(uint FMCEDIOCNHI, uint JHKFKIOGGOP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x9BC28F0", Offset = "0x9BC14F0", VA = "0x189BC28F0")]
	private OKIMNFHOFJN IIJJPAOKHMJ(Vector4[] JPLCDDPKPCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x9BC42B0", Offset = "0x9BC2EB0", VA = "0x189BC42B0")]
	private OKIMNFHOFJN IPPCKPBENNJ(Quaternion[] JPLCDDPKPCC, bool BILGONNEEBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x9BC13B0", Offset = "0x9BBFFB0", VA = "0x189BC13B0")]
	private OKIMNFHOFJN HGADAHGKNFI(Matrix4x4[] JPLCDDPKPCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x9BC1850", Offset = "0x9BC0450", VA = "0x189BC1850")]
	private OKIMNFHOFJN HGADAHGKNFI(float[] JPLCDDPKPCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x9BC0C60", Offset = "0x9BBF860", VA = "0x189BC0C60")]
	private OKIMNFHOFJN HGADAHGKNFI(int[] JPLCDDPKPCC, bool HAKBIMDGBIB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x9BBE970", Offset = "0x9BBD570", VA = "0x189BBE970")]
	private OKIMNFHOFJN HGADAHGKNFI(Vector2[] JPLCDDPKPCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x9BBFBD0", Offset = "0x9BBE7D0", VA = "0x189BBFBD0")]
	private OKIMNFHOFJN HGADAHGKNFI(Vector3[] JPLCDDPKPCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x9BCFE90", Offset = "0x9BCEA90", VA = "0x189BCFE90")]
	private OKIMNFHOFJN NELFOHIDKBK(OKIMNFHOFJN IOOLKCNMDGG, Vector3[] GJMKBJNGIIN, Vector3[] JPLCDDPKPCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x9BC0320", Offset = "0x9BBEF20", VA = "0x189BC0320")]
	private OKIMNFHOFJN HGADAHGKNFI(Vector4[] JPLCDDPKPCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x9BBF000", Offset = "0x9BBDC00", VA = "0x189BBF000")]
	private OKIMNFHOFJN HGADAHGKNFI(Color[] JPLCDDPKPCC, bool OFMCLONPADJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x9BC2740", Offset = "0x9BC1340", VA = "0x189BC2740")]
	private DOKIGGJJNLN IEBKEDLCFEB(uint BPOCDEEIJDG, uint IPKIEFMBGFI, uint FNDCINEPBKE = 0u)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020")]
	public void CFOIPCLLHAA(Transform LMGPODOPMIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x9BCFAC0", Offset = "0x9BCE6C0", VA = "0x189BCFAC0")]
	internal int NDPBAPKILJE(object KOJLNGLNBMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x9BD2AC0", Offset = "0x9BD16C0", VA = "0x189BD2AC0")]
	public int PMAOKNBJHNC(Transform LMGPODOPMIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x9BC2680", Offset = "0x9BC1280", VA = "0x189BC2680")]
	public int HPIJPHDADIA(Material GPMNIJPCANI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x9BB9C90", Offset = "0x9BB8890", VA = "0x189BB9C90")]
	public int CDDBLOHBKPF(Light OMIHNLKKKGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x9BBB380", Offset = "0x9BB9F80", VA = "0x189BBB380")]
	public int EELEMFOBDMG(Camera BLOFKJIANGK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x9BBA5D0", Offset = "0x9BB91D0", VA = "0x189BBA5D0")]
	[IteratorStateMachine(typeof(JIEIFIGGFJN))]
	public IEnumerable<(int, CGAJCOIJKND)> DACELGNHMEI(Mesh MOGMOMKEFJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x9BBDED0", Offset = "0x9BBCAD0", VA = "0x189BBDED0")]
	private static void HBHFCHAJEDB(Color HOKNBAKODNG, [Out] Color CLKDMEDAKFD, [Out] float KGHINJENAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x9BC8650", Offset = "0x9BC7250", VA = "0x189BC8650")]
	private static void KPADNPHKEHM(Vector4 HOKNBAKODNG, [Out] Vector2 ECJMFFOLCCL, [Out] Vector2 HDEKJKJDEIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x9BBD690", Offset = "0x9BBC290", VA = "0x189BBD690")]
	private bool FELCMFKPNKI(object[] COJHNLDFDFB, int HCBLOGLEDFA, int MNMGPPDHJHA, int NNFLEAMGLKE, int LGLCBAKKPIB, int OEBOPGBLACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x9BC5E20", Offset = "0x9BC4A20", VA = "0x189BC5E20")]
	public void JJEFFAGDEIN(float[] DPMMIPDBPJC, object[] OKFGGFMLPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x9BCC340", Offset = "0x9BCAF40", VA = "0x189BCC340")]
	public void LMNHFHGFDJD(UnityEngine.Object ADELBPFFNIJ, string BABLEGNKCCH, LBBDFKNJCBO FLFIOKJPIIB, float[] DPMMIPDBPJC, object[] OKFGGFMLPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x9BCF970", Offset = "0x9BCE570", VA = "0x189BCF970")]
	private void MLBFPDCJKPJ(object ADELBPFFNIJ, string BABLEGNKCCH, BCPBAELLNCG ADGCHNLKFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x9BC6650", Offset = "0x9BC5250", VA = "0x189BC6650")]
	private CNEGEMHJOPP JKHOJALGHCI(Camera MHHEEPJGIJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x9BB85C0", Offset = "0x9BB71C0", VA = "0x189BB85C0")]
	private KHMBBAMILFL ALAFMBCAJFD(Light PILCGDPJOEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x9BC8FE0", Offset = "0x9BC7BE0", VA = "0x189BC8FE0")]
	public HEKOFHNHHGD LIGLOOAMAIO(Material GIKENIAPJPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x9BB9890", Offset = "0x9BB8490", VA = "0x189BB9890")]
	private HEKOFHNHHGD CBJGIFPNIAG(Material GIKENIAPJPD, IBKALPNABJD CIBNABIMGCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x9BC5C60", Offset = "0x9BC4860", VA = "0x189BC5C60")]
	private bool JIKIBFEIIKH(Material CIBNABIMGCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x9BC7510", Offset = "0x9BC6110", VA = "0x189BC7510")]
	private bool KHJLLFNADGN(Material CIBNABIMGCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x9BB9FA0", Offset = "0x9BB8BA0", VA = "0x189BB9FA0")]
	private bool CFFFMKLHADH(Material CIBNABIMGCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x9BB8480", Offset = "0x9BB7080", VA = "0x189BB8480")]
	private bool ABLOEIFNMIN(Material CIBNABIMGCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x9BB8520", Offset = "0x9BB7120", VA = "0x189BB8520")]
	private static bool AKECCBEPCBB(Shader NKBOHNKGJLG, string BKILENEPEEB, ShaderPropertyType MDCDODCGNEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x9BD14A0", Offset = "0x9BD00A0", VA = "0x189BD14A0")]
	private void PFIALKJGIDC(PJDBNGEFJOL HHBJDCIBLBD, Material GPMNIJPCANI, string NBODOKDMIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x9BBA010", Offset = "0x9BB8C10", VA = "0x189BBA010")]
	public EINNNEKIADG CJJJMMKEPFD(Texture PMMGDHEEDKB, string OKCBMOOGHJA, Material CIBNABIMGCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9BBE0A0", Offset = "0x9BBCCA0", VA = "0x189BBE0A0")]
	private DIHEFCDGLOD HCLCKPOHPOB(Texture PMMGDHEEDKB, string OKCBMOOGHJA, Material CIBNABIMGCK, [Optional] DPLFMIFMAHH LKLMFOGKHIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x9BC4CF0", Offset = "0x9BC38F0", VA = "0x189BC4CF0")]
	public KDNBLABMDPM JCMFMDGGHKO(Material CIBNABIMGCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x9BBD840", Offset = "0x9BBC440", VA = "0x189BBD840")]
	public void GAOBFJIGILE(IBKALPNABJD HHBJDCIBLBD, Material CIBNABIMGCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x9BCBBA0", Offset = "0x9BCA7A0", VA = "0x189BCBBA0")]
	private void LMHDGCILDCI(IBKALPNABJD CIBNABIMGCK, Material GIKENIAPJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x9BB9470", Offset = "0x9BB8070", VA = "0x189BB9470")]
	private DKIDEDBANGN BMENAMOPIOL(Material GIKENIAPJPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x9BB91B0", Offset = "0x9BB7DB0", VA = "0x189BB91B0")]
	internal static void AOJNFBLCHJB(Color GNMLGPOGHMF, [Out] Color MKPGCFAOHAM, [Out] float KGHINJENAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x9BBA660", Offset = "0x9BB9260", VA = "0x189BBA660")]
	public void DGKIAEAJBEG(GCJECACEHBN PBBEMEGKFPO, List<NJEIBHGFHGB> GCANMNCDGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x9BBE200", Offset = "0x9BBCE00", VA = "0x189BBE200")]
	private static List<NJEIBHGFHGB> HDMKCMOACMN(IEnumerable<GameObject> HINMBLJHMNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x9BC8610", Offset = "0x9BC7210", VA = "0x189BC8610")]
	public AOBJCOPLPOP KNJHPCBOFEK(GameObject HLOIBGDKPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x9BC8920", Offset = "0x9BC7520", VA = "0x189BC8920")]
	public HDIKJDGIJBJ LHCFAJMGGKP(string BKILENEPEEB, List<NJEIBHGFHGB> GCANMNCDGHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x9BBC080", Offset = "0x9BBAC80", VA = "0x189BBC080")]
	private CGAJCOIJKND[] FCDEGNLMLOP(NJEIBHGFHGB FPEKCEHOLPJ, BJCLAFDPBIO MOGMOMKEFJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x9BCB550", Offset = "0x9BCA150", VA = "0x189BCB550")]
	private List<double> LJIGIJGJADA(SkinnedMeshRenderer HDHHGHHFCGB, Mesh HHMFOCJKGKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x9BBB4C0", Offset = "0x9BBA0C0", VA = "0x189BBB4C0")]
	private void EJCONLBNOAP(SkinnedMeshRenderer HDHHGHHFCGB, Mesh HHMFOCJKGKL, int DCOPKJLBMBJ, CGAJCOIJKND LENPJBDMDOJ, BJCLAFDPBIO MOGMOMKEFJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x9BC28D0", Offset = "0x9BC14D0", VA = "0x189BC28D0")]
	private static bool IEIIABGGIPG(CGAJCOIJKND EDEIIMGEHCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x9BB8270", Offset = "0x9BB6E70", VA = "0x189BB8270")]
	private static FFJCDOLCIFG ABDIMFBMNGB(MeshTopology NJAMNBJINEI)
	{
		return default(FFJCDOLCIFG);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x9BBD820", Offset = "0x9BBC420", VA = "0x189BBD820")]
	private static bool FGEDGOBKFHE(Mesh MOGMOMKEFJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x9BC31F0", Offset = "0x9BC1DF0", VA = "0x189BC31F0")]
	private void ILIOANOANNO(Transform LMGPODOPMIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x9BC2140", Offset = "0x9BC0D40", VA = "0x189BC2140")]
	private Mesh HLFJAJMENLA(GameObject HLOIBGDKPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x9BB8380", Offset = "0x9BB6F80", VA = "0x189BB8380")]
	private Material[] ABINJMIPNFL(GameObject HLOIBGDKPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x9BC1D90", Offset = "0x9BC0990", VA = "0x189BC1D90")]
	private Vector4[] HGDFIALBEFM(BoneWeight[] OEIDHKLLCIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x9BBA210", Offset = "0x9BB8E10", VA = "0x189BBA210")]
	private Vector4[] CKBOKJNANDI(BoneWeight[] OEIDHKLLCIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x9BB9240", Offset = "0x9BB7E40", VA = "0x189BB9240")]
	private string BFODAFODNHB(HashSet<string> AOHJPMNNNDK, string BKILENEPEEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x9BD1200", Offset = "0x9BCFE00", VA = "0x189BD1200")]
	public PJDBNGEFJOL NPEMJHBAJBD(Texture PMMGDHEEDKB, string OKCBMOOGHJA, [Optional] KGKHGGDIHMA LEGIHKBKMMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x9BCEF30", Offset = "0x9BCDB30", VA = "0x189BCEF30")]
	public PJDBNGEFJOL MGKHFBFFPOF(Material GPMNIJPCANI, Texture PMMGDHEEDKB, string OKCBMOOGHJA, [Optional] KGKHGGDIHMA LEGIHKBKMMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x9BC6B60", Offset = "0x9BC5760", VA = "0x189BC6B60")]
	public DPLFMIFMAHH JMCHFFGMLEG(Texture NEDMPAFIEII, string OKCBMOOGHJA, [Optional] KGKHGGDIHMA LEGIHKBKMMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x9BD2810", Offset = "0x9BD1410", VA = "0x189BD2810")]
	private string PLNIACGLMJP(Texture PMMGDHEEDKB, KGKHGGDIHMA FDBOPEFNJMC, string OKCBMOOGHJA, [Out] bool MPLNFJNAOJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x9BCF020", Offset = "0x9BCDC20", VA = "0x189BCF020")]
	private EKOBAKDFLHN MIFFFBOJOPD(EFKNFANKFBH HKLBJHAMFGJ, string OKCBMOOGHJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x48BD420", Offset = "0x48BC020", VA = "0x1848BD420")]
	private bool LCDIGJPNGHP(KGKHGGDIHMA FDBOPEFNJMC, Texture PMMGDHEEDKB, [Out] string OKJOHKDNPGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030")]
	private byte[] BENNBDMFOGI(Texture PMMGDHEEDKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x9BCFE00", Offset = "0x9BCEA00", VA = "0x189BCFE00")]
	private bool NEDMOBLMLAO(Texture JIGKELCOPHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x9BBB440", Offset = "0x9BBA040", VA = "0x189BBB440")]
	private bool EHBMDJACJMC(string EANLPJPIAHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x9BB9BC0", Offset = "0x9BB87C0", VA = "0x189BB9BC0")]
	private bool CCLMAGMIMMF(string EANLPJPIAHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x9BBA7D0", Offset = "0x9BB93D0", VA = "0x189BBA7D0")]
	private EKOBAKDFLHN DLPJNJBHKHF(EFKNFANKFBH HKLBJHAMFGJ, string OKCBMOOGHJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x9BCB6F0", Offset = "0x9BCA2F0", VA = "0x189BCB6F0")]
	private PCMPEFCBGIJ LMBJMBLHDNG(Texture PMMGDHEEDKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Flags]
public enum BPJFCAAFNAC
{
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	Meshes = 1,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	Textures = 2
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum DMCBMPFCLKI
{
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	LowQuality,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	HighQuality
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class CALMGHCKIPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public KLFFACBIPLK DNKPNNJILAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public GOABIIABKHB PLJGOPDGEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public AsyncCoroutineHelper PAHJDKONJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public bool MFINIGLAGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public DKHILGFDEDD IBCHJNMNICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public bool FFGDHMKGACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public BPJFCAAFNAC BDLFBKJNEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public bool COGMKLGODJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public CMGEHFAFAMK OHPJNIJIOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public CMGEHFAFAMK MJFEEFKNPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public bool LLJGDEBBPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public HCAEGKFFCEH DJAIGDNIGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public DMCBMPFCLKI ICKCDFHBKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public BlendShapeFrameWeightSetting EBKAFJAGFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public CCACMMEEOIH JKEBKOLDKNE;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public ILogger BOCJBHAACPI;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x9BE2D20", Offset = "0x9BE1920", VA = "0x189BE2D20")]
	public CALMGHCKIPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum HCAEGKFFCEH
{
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	ImportAndActive,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	ImportAndCameraDisabled
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public enum DKHILGFDEDD
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
public struct DPPLINPNFPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public bool COAKOKLBBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public int CILLJDAFJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public int GOELACNILLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public int KBJGGBCNPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public int JDPBLADEMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public int IHDLOFBDFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public int JGAPAKIBLJN;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public float MIDLKPJOJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9BE3650", Offset = "0x9BE2250", VA = "0x189BE3650")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x9BE3680", Offset = "0x9BE2280", VA = "0x189BE3680", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct CPONOENGNCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public long BENMJKNEJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public long PGAGAJGEJGH;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public delegate float[] GMPFFJJOMLA(CBBMPCEBCIA CBCNBAPLLJM, int PICEAKIDPJO);
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class AOLODCHEPKL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public enum BJFIMHOFDME
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
	protected struct DNPAIGCGCBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public Stream MFJHHDIDMBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public long MCFMCLNGLOK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class FNBJDJLDKLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public Texture DPGDMBNBPIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public int HLMCLPHDFJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public double ANGHIBPCDHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public Vector2 MMKAIHHLJCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public double EFKBKJCNDBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public Vector2 CBMLEOEPLHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public int? OGLBNAPLLPD;

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x9BE3FF0", Offset = "0x9BE2BF0", VA = "0x189BE3FF0")]
		public FNBJDJLDKLM()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct HMMJMGHAGPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public IProgress<DPPLINPNFPK> progress;

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
		[Cpp2IlInjected.Address(RVA = "0x9BE6E70", Offset = "0x9BE5A70", VA = "0x189BE6E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x9BE82C0", Offset = "0x9BE6EC0", VA = "0x189BE82C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct DCCNAOFDHDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private IBKALPNABJD <def>5__3;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x9BE31A0", Offset = "0x9BE1DA0", VA = "0x189BE31A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x9BE35F0", Offset = "0x9BE21F0", VA = "0x189BE35F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class HOCKLMHOMCN
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
			public HOCKLMHOMCN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			private IBKALPNABJD <def>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x9BEA870", Offset = "0x9BE9470", VA = "0x189BEA870", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x9BEACA0", Offset = "0x9BE98A0", VA = "0x189BEACA0", Slot = "5")]
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
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public HOCKLMHOMCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9BE8320", Offset = "0x9BE6F20", VA = "0x189BE8320")]
		[AsyncStateMachine(typeof(<<LoadMaterialAsync>b__0>d))]
		internal Task AOMMGNFCDNA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct KOJEIOIMJFH : IAsyncStateMachine
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
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private HOCKLMHOMCN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9BE8DB0", Offset = "0x9BE79B0", VA = "0x189BE8DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9BE90C0", Offset = "0x9BE7CC0", VA = "0x189BE90C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class AIIDGOHCFML
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
			public AIIDGOHCFML <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			private BJCLAFDPBIO <def>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x9BEAD00", Offset = "0x9BE9900", VA = "0x189BEAD00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x9BEB2C0", Offset = "0x9BE9EC0", VA = "0x189BEB2C0", Slot = "5")]
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
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public AIIDGOHCFML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x9BD57C0", Offset = "0x9BD43C0", VA = "0x189BD57C0")]
		[AsyncStateMachine(typeof(<<LoadMeshAsync>b__0>d))]
		internal Task MFCDJMKAPDF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct PKLBNFFHHHI : IAsyncStateMachine
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
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private AIIDGOHCFML <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x9BEA4C0", Offset = "0x9BE90C0", VA = "0x189BEA4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9BEA800", Offset = "0x9BE9400", VA = "0x189BEA800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class IMJPOKDGJAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public PJDCDDJOLPM dataLoader2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public string jsonFilePath;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public IMJPOKDGJAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9BE83F0", Offset = "0x9BE6FF0", VA = "0x189BE83F0")]
		internal Stream IBJDPPMCNJM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x9BE84E0", Offset = "0x9BE70E0", VA = "0x189BE84E0")]
		internal void LIJOEHKCLBL()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct PBEPFMPEIHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public string jsonFilePath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private IMJPOKDGJAO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private TaskAwaiter<Stream> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x9BE9CB0", Offset = "0x9BE88B0", VA = "0x189BE9CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x9BEA460", Offset = "0x9BE9060", VA = "0x189BEA460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct GBECOEGMFON : IAsyncStateMachine
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
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public bool showSceneObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private DPPJKKPNPHL <scene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9BE45A0", Offset = "0x9BE31A0", VA = "0x189BE45A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9BE53A0", Offset = "0x9BE3FA0", VA = "0x189BE53A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct GLAOCKFFOHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public AsyncTaskMethodBuilder<IPACCMMHAIP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public CHHOOPGMLMC bufferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9BF5600", Offset = "0x9BF4200", VA = "0x189BF5600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9BF5890", Offset = "0x9BF4490", VA = "0x189BF5890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct BONMLMJOOIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public int nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private GCJECACEHBN <node>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private FLGBBCAHIEK <lodsExtension>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9BEE200", Offset = "0x9BECE00", VA = "0x189BEE200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9BEEE10", Offset = "0x9BEDA10", VA = "0x189BEEE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct GHPCIKHOGCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public AsyncTaskMethodBuilder<(Vector3, Quaternion, Vector3)[]> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public GCJECACEHBN node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private IFFIEJDGJCN <positionsAttr>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private IFFIEJDGJCN <rotationAttr>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private IFFIEJDGJCN <scaleAttr>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private EXT_mesh_gpu_instancing <extMeshGPUInstancing>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private int <instancesCount>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private TaskAwaiter<IFFIEJDGJCN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9BF4950", Offset = "0x9BF3550", VA = "0x189BF4950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9BF5590", Offset = "0x9BF4190", VA = "0x189BF5590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class BIONIHODDLH
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
			public BIONIHODDLH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public bool onlyMesh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public bool ignoreMesh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			private List<AOBJCOPLPOP>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			private BJCLAFDPBIO <mesh>5__3;

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
			[Cpp2IlInjected.Address(RVA = "0x9BFEA50", Offset = "0x9BFD650", VA = "0x189BFEA50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x9C004D0", Offset = "0x9BFF0D0", VA = "0x189C004D0", Slot = "5")]
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
		public GCJECACEHBN node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public int nodeIndex;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public BIONIHODDLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x9BED780", Offset = "0x9BEC380", VA = "0x189BED780")]
		[AsyncStateMachine(typeof(<<ConstructNode>g__CreateNodeComponentsAndChilds|0>d))]
		internal Task CKBFLJNJBJB(bool ignoreMesh, bool onlyMesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9BED8A0", Offset = "0x9BEC4A0", VA = "0x189BED8A0")]
		internal Material FFBNEBGANGK(CGAJCOIJKND p)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct GEBFBEOLCFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public GCJECACEHBN node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public int nodeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private BIONIHODDLH <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x9BF36D0", Offset = "0x9BF22D0", VA = "0x189BF36D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x9BF48F0", Offset = "0x9BF34F0", VA = "0x189BF48F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct APGLLICKKCH : IAsyncStateMachine
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
		public GCJECACEHBN node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private List<AOBJCOPLPOP>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x9BECAA0", Offset = "0x9BEB6A0", VA = "0x189BECAA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x9BED050", Offset = "0x9BEBC50", VA = "0x189BED050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct BNDCJFHMGPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public int bufferIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public LHKMCLCPHBH buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private TaskAwaiter<Stream> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x9BED910", Offset = "0x9BEC510", VA = "0x189BED910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x9BEE1A0", Offset = "0x9BECDA0", VA = "0x189BEE1A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct EOCIPJPICON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public DPPJKKPNPHL scene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public bool showSceneObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public AOLODCHEPKL <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x9BF2B20", Offset = "0x9BF1720", VA = "0x189BF2B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x9BF3670", Offset = "0x9BF2270", VA = "0x189BF3670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct BGFEBPLKGNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public Func<Task> callback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x9BED0B0", Offset = "0x9BEBCB0", VA = "0x189BED0B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x9BED6E0", Offset = "0x9BEC2E0", VA = "0x189BED6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct MLPLGKIGFDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x9BFE7D0", Offset = "0x9BFD3D0", VA = "0x189BFE7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x9BFE9F0", Offset = "0x9BFD5F0", VA = "0x189BFE9F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct AHADHHANOOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public LBBDFKNJCBO animation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public int animationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private Dictionary<int, string> <typeMap>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private DCILNNFLNEG[] <samplers>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private Dictionary<string, List<IFFIEJDGJCN>> <samplersByType>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private JGDBLMDIFBH <samplerDef>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private TaskAwaiter<IPACCMMHAIP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x9BEBD40", Offset = "0x9BEA940", VA = "0x189BEBD40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x9BECA40", Offset = "0x9BEB640", VA = "0x189BECA40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct AKBKEPIPPPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public LBBDFKNJCBO animation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public GDKODCHHPPH animationCache;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class BHOLGILINKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public AGFALBKGFIF pointerData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public GMPFFJJOMLA <>9__6;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public BHOLGILINKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x9BED740", Offset = "0x9BEC340", VA = "0x189BED740")]
		internal float[] NFFKKAIFNNI(CBBMPCEBCIA data, int frame)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class IBBPACAPNKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public bool flipRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public int targetCount;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public IBBPACAPNKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x9BF5900", Offset = "0x9BF4500", VA = "0x189BF5900")]
		internal float[] FBCDCLHKFPI(CBBMPCEBCIA data, int frame)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class MHNECKEJOGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public float[] frameFloats;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public BlendShapeFrameWeightSetting blendShapeFrameWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public IBBPACAPNKP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public MHNECKEJOGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x9BFE700", Offset = "0x9BFD300", VA = "0x189BFE700")]
		internal float[] CNOLKPAPIAF(CBBMPCEBCIA data, int frame)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct DHMIDBBAGJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public AsyncTaskMethodBuilder<AnimationClip> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public int animationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private AKBKEPIPPPP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public Transform root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private BHOLGILINKF <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private AnimationClip <clip>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private int[] <nodeIds>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private JAFIBBOODBL <pointerImportContext>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private List<PNNHLMJCFJE>.Enumerator <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private PNNHLMJCFJE <channel>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private bool <usesPointer>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private DCILNNFLNEG <samplerCache>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private LPGOJILKIAO <path>5__9;

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
		[Cpp2IlInjected.Address(RVA = "0x9BEEE80", Offset = "0x9BEDA80", VA = "0x189BEEE80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x9BF2AB0", Offset = "0x9BF16B0", VA = "0x189BF2AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct MGGNGODBHBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public GCJECACEHBN node;

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
		private FLGBBCAHIEK <lodsExtension>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x9BFDAB0", Offset = "0x9BFC6B0", VA = "0x189BFDAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x9BFE6A0", Offset = "0x9BFD2A0", VA = "0x189BFE6A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct NDIAOICGJFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public EMCJJJEAHOG mapper;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct KLPCPNADDEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public IBKALPNABJD def;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private NDIAOICGJFC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public int materialIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private JFNHLFCFLIG <mrMapper>5__2;

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
		private GIINNGPBEJA <sgMapper>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private BJOAIPKGIOB <unlitMapper>5__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private EGNGIONJJHJ <sheenMapper>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private ANKDOIKFPNP <anisotropyMapper>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private CJODENILCML <transmissionMapper>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private ICAJNHEEFGA <volumeMapper>5__17;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private DABMELMGCDC <iridescenceMapper>5__18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private IDNEBPPDLAG <specularMapper>5__19;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private HDFKKKCECEI <clearcoatMapper>5__20;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private EKGEINMHCBL <uniformMapper>5__21;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private KDNBLABMDPM <pbr>5__22;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private DPLFMIFMAHH <textureId>5__23;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private PEKLJBDMNIO <specGloss>5__24;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private KHR_materials_sheen <sheen>5__25;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private TaskAwaiter<FNBJDJLDKLM> <>u__2;

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
		private BMADAMEEEJC <clearcoatNormalMapper>5__32;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x9BF5BA0", Offset = "0x9BF47A0", VA = "0x189BF5BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x9BFDA50", Offset = "0x9BFC650", VA = "0x189BFDA50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct MGJMDIIGAIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public CGAJCOIJKND primitive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x9C11BE0", Offset = "0x9C107E0", VA = "0x189C11BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x9C11E80", Offset = "0x9C10A80", VA = "0x189C11E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct MPLNINHEBOL : IAsyncStateMachine
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
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public int meshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public BJCLAFDPBIO mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private CFOGGKEJONC <meshCache>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private FOKIBNIMBHB <unityData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x9C12280", Offset = "0x9C10E80", VA = "0x189C12280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x9C12CD0", Offset = "0x9C118D0", VA = "0x189C12CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct FBMBFNBADKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public BJCLAFDPBIO mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x9C07170", Offset = "0x9C05D70", VA = "0x189C07170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x9C07370", Offset = "0x9C05F70", VA = "0x189C07370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct LNEHOOAKKEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int meshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public FOKIBNIMBHB unityMeshData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private Mesh <mesh>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x9C0CDB0", Offset = "0x9C0B9B0", VA = "0x189C0CDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x9C0DED0", Offset = "0x9C0CAD0", VA = "0x189C0DED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct EPCGEHOOIEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public CGAJCOIJKND primitive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public int meshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public int primitiveIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private List<Dictionary<string, IFFIEJDGJCN>> <newTargets>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private Dictionary<string, OKIMNFHOFJN>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private KeyValuePair<string, OKIMNFHOFJN> <targetAttribute>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private int <bufferID>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private TaskAwaiter<IPACCMMHAIP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x9C05FB0", Offset = "0x9C04BB0", VA = "0x189C05FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x9C07020", Offset = "0x9C05C20", VA = "0x189C07020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct KPDHNJOIPFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private int <meshIndex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private BJCLAFDPBIO <gltfMesh>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x9C0C690", Offset = "0x9C0B290", VA = "0x189C0C690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x9C0CD50", Offset = "0x9C0B950", VA = "0x189C0CD50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct EFGONLNHABB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public HDIKJDGIJBJ meshId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public BJCLAFDPBIO mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private int <meshIndex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private CGAJCOIJKND <primitive>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x9C05740", Offset = "0x9C04340", VA = "0x189C05740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x9C05D90", Offset = "0x9C04990", VA = "0x189C05D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct PJOIHEAFCGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public int meshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public int primitiveIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public CGAJCOIJKND primitive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private CFOGGKEJONC.JCHKKGCAFAJ <primData>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private Dictionary<string, OKIMNFHOFJN>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private KeyValuePair<string, OKIMNFHOFJN> <attributePair>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private PLKJOGNBFOH <sparse>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private TaskAwaiter<IPACCMMHAIP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private IFFIEJDGJCN <sparseValues>5__6;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x9C14640", Offset = "0x9C13240", VA = "0x189C14640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x9C157A0", Offset = "0x9C143A0", VA = "0x189C157A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct PALPBBJNPGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public IAKDHHGKPLM skin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public AOLODCHEPKL <>4__this;

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
		private TaskAwaiter<IPACCMMHAIP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private int <i>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x9C136E0", Offset = "0x9C122E0", VA = "0x189C136E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x9C141D0", Offset = "0x9C12DD0", VA = "0x189C141D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private struct BOOINEMIHEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x9C04430", Offset = "0x9C03030", VA = "0x189C04430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x9C048B0", Offset = "0x9C034B0", VA = "0x189C048B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private struct CMJMMCIBAPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public AsyncTaskMethodBuilder<FNBJDJLDKLM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public PJDBNGEFJOL textureInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public bool isNormal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private FNBJDJLDKLM <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private DPLFMIFMAHH <textureId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x9C05090", Offset = "0x9C03C90", VA = "0x189C05090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x9C05660", Offset = "0x9C04260", VA = "0x189C05660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct PCLLEIJDJCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public int imageCacheIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public MCDNKANAEIC image;

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
		[Cpp2IlInjected.Address(RVA = "0x9C14230", Offset = "0x9C12E30", VA = "0x189C14230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x9C145E0", Offset = "0x9C131E0", VA = "0x189C145E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct FDAHJBNPGHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public BHPGBKFIKFO texture;

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
		[Cpp2IlInjected.Address(RVA = "0x9C073D0", Offset = "0x9C05FD0", VA = "0x189C073D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x9C07B60", Offset = "0x9C06760", VA = "0x189C07B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct ODDHCKKBLGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public bool markGpuOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public MCDNKANAEIC image;

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
		[Cpp2IlInjected.Address(RVA = "0x9C12D30", Offset = "0x9C11930", VA = "0x189C12D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x9C13610", Offset = "0x9C12210", VA = "0x189C13610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct BJLENBIKFIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public bool isLinear;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public MCDNKANAEIC image;

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
		private IPACCMMHAIP <bufferView>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private TaskAwaiter<IPACCMMHAIP> <>u__1;

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
		[Cpp2IlInjected.Address(RVA = "0x9C025B0", Offset = "0x9C011B0", VA = "0x189C025B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x9C043D0", Offset = "0x9C02FD0", VA = "0x189C043D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct PNEJFPAIDNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public int textureIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public BHPGBKFIKFO texture;

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
		private MCDNKANAEIC <image>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private bool <isFirstInstance>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x9C15800", Offset = "0x9C14400", VA = "0x189C15800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x9C16BB0", Offset = "0x9C157B0", VA = "0x189C16BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct HPCHFALFKIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public AsyncTaskMethodBuilder<IFFIEJDGJCN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public AOLODCHEPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public OKIMNFHOFJN accessorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public bool isPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private JCCJJPDBFFM <accessor>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private TaskAwaiter<IPACCMMHAIP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x9C0BEC0", Offset = "0x9C0AAC0", VA = "0x189C0BEC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x9C0C3D0", Offset = "0x9C0AFD0", VA = "0x189C0C3D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public int JHCCPLLLCCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public int PONCELFFKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private bool DGMCIKNDHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private bool KFPNAPLPFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private Dictionary<Stream, NativeArray<byte>> FDNFHHPFEPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public bool NBAHJELOBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public bool MMDDJFAILDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public bool KNAJMFDMICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x63")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public bool MJMPDAELNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public bool OKDBHJGLFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public CPONOENGNCG KKAEBNEBDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	protected CALMGHCKIPD JKOBGGCGBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	protected CICOKJMDMOE OJANDBAELFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	protected GameObject FPCCAKPCFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	protected readonly IBKALPNABJD LPLIOAFHDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	internal AOBBJBJKEJK OMLKMCNNJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	protected string MIPFDIJJLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	protected DNPAIGCGCBI DMNHAMKIODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	protected EEBBIHGHGOL KDIOIGLJMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	protected APIFPDKINHA KPMCEGIDALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	protected bool NEPIADHPPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	protected DPPLINPNFPK KKLDIEDFONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	protected IProgress<DPPLINPNFPK> BICEBNIJDLJ;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static ILogger KAHGADOJMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	protected ColorSpace OGHKCMHIGED;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	internal static List<Texture> MJIOFCDJMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private Dictionary<int, int> FBPKLCNPNOJ;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool KMENGLCCIMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x9BD6380", Offset = "0x9BD4F80", VA = "0x189BD6380")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA61310", Offset = "0xA5FF10", VA = "0x180A61310")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public EEBBIHGHGOL AMCBICJEEBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xE62030", Offset = "0xE60C30", VA = "0x180E62030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Transform LOOAKHMPAAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA5C790", Offset = "0xA5B390", VA = "0x180A5C790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7A0", Offset = "0xA5B3A0", VA = "0x180A5C7A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public GameObject GKHKAGJFKCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5E0", Offset = "0xA5A1E0", VA = "0x180A5B5E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA683D0", Offset = "0xA66FD0", VA = "0x180A683D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private AnimationClip[] PMOBKFCGPHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA5FCB0", Offset = "0xA5E8B0", VA = "0x180A5FCB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public BJFIMHOFDME NJNNIEAHKOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA7B160", Offset = "0xA79D60", VA = "0x180A7B160")]
		[CompilerGenerated]
		get
		{
			return default(BJFIMHOFDME);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xE7B530", Offset = "0xE7A130", VA = "0x180E7B530")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public string GELCNMCPEDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA5B600", Offset = "0xA5A200", VA = "0x180A5B600")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA5B430", Offset = "0xA5A030", VA = "0x180A5B430")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public GameObject MBBLFJPKPHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA5EA70", Offset = "0xA5D670", VA = "0x180A5EA70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public HGNCIFNBJIL[] JCLHBAFEOCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x9BD6030", Offset = "0x9BD4C30", VA = "0x189BD6030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public AOBBJBJKEJK[] KOBILMOFPKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x9BDF490", Offset = "0x9BDE090", VA = "0x189BDF490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public List<UnityEngine.Object> LIOPJDJFEIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA5B670", Offset = "0xA5A270", VA = "0x180A5B670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	protected CCACMMEEOIH NFMCACNMIGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x9BDE360", Offset = "0x9BDCF60", VA = "0x189BDE360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x9BE2470", Offset = "0x9BE1070", VA = "0x189BE2470")]
	public AOLODCHEPKL(string CLGAOEPCDND, CALMGHCKIPD ENJHAFMCLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x9BE24C0", Offset = "0x9BE10C0", VA = "0x189BE24C0")]
	public AOLODCHEPKL(Stream KHBIFHJEDJA, CALMGHCKIPD ENJHAFMCLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x9BE25C0", Offset = "0x9BE11C0", VA = "0x189BE25C0")]
	private AOLODCHEPKL(CALMGHCKIPD ENJHAFMCLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x9BD63C0", Offset = "0x9BD4FC0", VA = "0x189BD63C0")]
	private NativeArray<byte> AMGDAFEOBCN(Stream NKIPIPEKKIL)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x9BD6660", Offset = "0x9BD5260", VA = "0x189BD6660")]
	private void BBDFGILJMOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x9BD8140", Offset = "0x9BD6D40", VA = "0x189BD8140", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x9BD7CE0", Offset = "0x9BD68E0", VA = "0x189BD7CE0")]
	[AsyncStateMachine(typeof(HMMJMGHAGPO))]
	public Task DMFJKGBGFAA(int NIHHGEAIOGB = -1, bool OLNMJOJNNNE = true, [Optional] Action<GameObject, ExceptionDispatchInfo> FFLINMKBFGF, [Optional] CancellationToken JHCOCAANJDL, [Optional] IProgress<DPPLINPNFPK> BICEBNIJDLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x9BD9620", Offset = "0x9BD8220", VA = "0x189BD9620")]
	[AsyncStateMachine(typeof(DCCNAOFDHDG))]
	private Task EJGCLGHOPOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x9BD9D30", Offset = "0x9BD8930", VA = "0x189BD9D30", Slot = "5")]
	[AsyncStateMachine(typeof(KOJEIOIMJFH))]
	public virtual Task<Material> FJBHNIGFMOH(int EFJMIKDMGKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x9BDE380", Offset = "0x9BDCF80", VA = "0x189BDE380", Slot = "6")]
	[AsyncStateMachine(typeof(PKLBNFFHHHI))]
	public virtual Task<Mesh> JLFIOEFOGFO(int GOPKHOKNFBK, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x9BDEEB0", Offset = "0x9BDDAB0", VA = "0x189BDEEB0")]
	[AsyncStateMachine(typeof(PBEPFMPEIHP))]
	private Task KHOLINNHFGG(string ACJJLLMFKNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x9BD5EF0", Offset = "0x9BD4AF0", VA = "0x189BD5EF0")]
	private void AFBIDNFEPNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x9BE0FC0", Offset = "0x9BDFBC0", VA = "0x189BE0FC0")]
	[AsyncStateMachine(typeof(GBECOEGMFON))]
	protected Task NDPBDGFAEBM(int NIHHGEAIOGB = -1, bool OLNMJOJNNNE = true, [Optional] CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x9BD7860", Offset = "0x9BD6460", VA = "0x189BD7860")]
	private void DIGLGKAHHNM(DPPJKKPNPHL CMBCIMNOCEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x9BDFB60", Offset = "0x9BDE760", VA = "0x189BDFB60")]
	public NativeArray<byte> MEIADPEGMGG(JNACIMADPIO PCNJGEAPENB)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x9BDFD50", Offset = "0x9BDE950", VA = "0x189BDFD50")]
	[AsyncStateMachine(typeof(GLAOCKFFOHE))]
	private Task<IPACCMMHAIP> MHJJJALKLOE(CHHOOPGMLMC LCBFKPIDHMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x9BD6940", Offset = "0x9BD5540", VA = "0x189BD6940")]
	private float BMBJGMDLPID(List<double> LMHKKNLKBOJ, int JHAGJBFJBOE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x9BD93B0", Offset = "0x9BD7FB0", VA = "0x189BD93B0")]
	[AsyncStateMachine(typeof(BONMLMJOOIG))]
	private Task<GameObject> EDKCEEGADAN(int LJOMDKEKAFC, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x9BE1530", Offset = "0x9BE0130", VA = "0x189BE1530")]
	[AsyncStateMachine(typeof(GHPCIKHOGCD))]
	private Task<(Vector3, Quaternion, Vector3)[]> NIOHPACPAEJ(GCJECACEHBN PBBEMEGKFPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x9BE1440", Offset = "0x9BE0040", VA = "0x189BE1440")]
	private bool NIGAOGFKGIH(GCJECACEHBN PBBEMEGKFPO, GameObject KBHPNAJAHMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x9BDA1B0", Offset = "0x9BD8DB0", VA = "0x189BDA1B0", Slot = "7")]
	[AsyncStateMachine(typeof(GEBFBEOLCFG))]
	protected virtual Task GDBBMIDGMNI(GCJECACEHBN PBBEMEGKFPO, int DGOOJPINDFJ, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x9BDCC90", Offset = "0x9BDB890", VA = "0x189BDCC90")]
	[AsyncStateMachine(typeof(APGLLICKKCH))]
	private Task IKCCGEIEMOL(GCJECACEHBN PBBEMEGKFPO, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x9BD9E40", Offset = "0x9BD8A40", VA = "0x189BD9E40")]
	[AsyncStateMachine(typeof(BNDCJFHMGPA))]
	protected Task FLALABDCGOB(LHKMCLCPHBH HAPOFGGDNGL, int GBGEAJPGEMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x9BD7BA0", Offset = "0x9BD67A0", VA = "0x189BD7BA0", Slot = "8")]
	[AsyncStateMachine(typeof(EOCIPJPICON))]
	protected virtual Task DJJKLDOBPJH(DPPJKKPNPHL CMBCIMNOCEH, bool OLNMJOJNNNE, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x9BDC390", Offset = "0x9BDAF90", VA = "0x189BDC390", Slot = "9")]
	protected virtual IPACCMMHAIP HMMLLILIOHB(int GBGEAJPGEMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x9BE1850", Offset = "0x9BE0450", VA = "0x189BE1850")]
	private void OCPEIGBLBFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x9BD97D0", Offset = "0x9BD83D0", VA = "0x189BD97D0")]
	private void FFGKCHEGHDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x9BD74F0", Offset = "0x9BD60F0", VA = "0x189BD74F0")]
	[AsyncStateMachine(typeof(BGFEBPLKGNL))]
	private Task DBJLOBJFACF(Func<Task> HFBNHPDLHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x9BDA2F0", Offset = "0x9BD8EF0", VA = "0x189BDA2F0")]
	[AsyncStateMachine(typeof(MLPLGKIGFDO))]
	protected Task GEIKIKBBCEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x9BDE1B0", Offset = "0x9BDCDB0", VA = "0x189BDE1B0")]
	private static string JHDAFEGHCOG(Transform JBDFDFABHKD, Transform OLIIIAEGOLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x9BE1A00", Offset = "0x9BE0600", VA = "0x189BE1A00", Slot = "10")]
	[AsyncStateMachine(typeof(AHADHHANOOB))]
	protected virtual Task OJJBDGCJDKK(LBBDFKNJCBO FLFIOKJPIIB, int JDJLJMHGKOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x9BE00D0", Offset = "0x9BDECD0", VA = "0x189BE00D0")]
	protected void MOPPBOJMHAI(AnimationClip EFFFLPIDNGA, string MKEJNEKDHNG, string[] NAKPODPMOEB, CBBMPCEBCIA HOKNBAKODNG, CBBMPCEBCIA CLKDMEDAKFD, KAJCEOHBMDH CEBNHJNKAJN, Type FLABFAIKJBL, GMPFFJJOMLA FJECJCLKLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x9BE0A60", Offset = "0x9BDF660", VA = "0x189BE0A60")]
	private void MPNEENNLKND(Keyframe[] IJELPFJIEGP, int EKOCDEIJNOG, KAJCEOHBMDH EJMCFNKKGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x9BD7F60", Offset = "0x9BD6B60", VA = "0x189BD7F60")]
	private static float DONIHIAGOEN(Keyframe[] IJELPFJIEGP, int EKOCDEIJNOG, bool FLCBBKHHFHJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x9BD69D0", Offset = "0x9BD55D0", VA = "0x189BD69D0")]
	[AsyncStateMachine(typeof(DHMIDBBAGJI))]
	protected Task<AnimationClip> CBGNLJNHABI(Transform OLIIIAEGOLD, int JDJLJMHGKOB, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x9BDC4A0", Offset = "0x9BDB0A0", VA = "0x189BDC4A0")]
	private bool IDKEIEAPJLH(GameObject KBHPNAJAHMG, GCJECACEHBN PBBEMEGKFPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x9BDE4B0", Offset = "0x9BDD0B0", VA = "0x189BDE4B0")]
	private bool JMAHPEHHIGB(GameObject KBHPNAJAHMG, GCJECACEHBN PBBEMEGKFPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x9BE1D50", Offset = "0x9BE0950", VA = "0x189BE1D50")]
	[AsyncStateMachine(typeof(MGGNGODBHBP))]
	private Task OMFKKMMNNGM(EEBBIHGHGOL LPFALNIFEHN, GameObject KBHPNAJAHMG, GCJECACEHBN PBBEMEGKFPO, int DGOOJPINDFJ, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x9BE1210", Offset = "0x9BDFE10", VA = "0x189BE1210", Slot = "11")]
	[AsyncStateMachine(typeof(KLPCPNADDEI))]
	protected virtual Task NHDBLBMNHCG(IBKALPNABJD HHBJDCIBLBD, int EFJMIKDMGKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x9BDB6B0", Offset = "0x9BDA2B0", VA = "0x189BDB6B0", Slot = "12")]
	protected virtual Task HLNHGPIFFDI(IBKALPNABJD HHBJDCIBLBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x9BE1B20", Offset = "0x9BE0720", VA = "0x189BE1B20", Slot = "13")]
	protected virtual DDCKGKIHMOD OLOGJKENMEH(PJDBNGEFJOL HHBJDCIBLBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x9BDA080", Offset = "0x9BD8C80", VA = "0x189BDA080", Slot = "14")]
	protected virtual JHJNHMPBDNH GAHOLAPJNCE(IBKALPNABJD HHBJDCIBLBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x9BD9C00", Offset = "0x9BD8800", VA = "0x189BD9C00", Slot = "15")]
	protected virtual KHR_materials_transmission FIHLAOIOLGF(IBKALPNABJD HHBJDCIBLBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x9BE21C0", Offset = "0x9BE0DC0", VA = "0x189BE21C0", Slot = "16")]
	protected virtual KHR_materials_sheen PGPDAJJFLNM(IBKALPNABJD HHBJDCIBLBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x9BD94F0", Offset = "0x9BD80F0", VA = "0x189BD94F0", Slot = "17")]
	protected virtual KHR_materials_anisotropy EIECCNNACKP(IBKALPNABJD HHBJDCIBLBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x9BDCB60", Offset = "0x9BDB760", VA = "0x189BDCB60", Slot = "18")]
	protected virtual KHR_materials_dispersion IIIPBJLIIPL(IBKALPNABJD HHBJDCIBLBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x9BE1310", Offset = "0x9BDFF10", VA = "0x189BE1310", Slot = "19")]
	protected virtual KHR_materials_volume NHDIOFDMBEM(IBKALPNABJD HHBJDCIBLBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x9BDEB30", Offset = "0x9BDD730", VA = "0x189BDEB30", Slot = "20")]
	protected virtual KHR_materials_ior KALFHDPCJEF(IBKALPNABJD HHBJDCIBLBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x9BDEA00", Offset = "0x9BDD600", VA = "0x189BDEA00", Slot = "21")]
	protected virtual KHR_materials_iridescence JMDHHMEBJGJ(IBKALPNABJD HHBJDCIBLBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x9BDFE60", Offset = "0x9BDEA60", VA = "0x189BDFE60", Slot = "22")]
	protected virtual KHR_materials_specular MKKJEKNMIOD(IBKALPNABJD HHBJDCIBLBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x9BE10E0", Offset = "0x9BDFCE0", VA = "0x189BE10E0", Slot = "23")]
	protected virtual KHR_materials_clearcoat NFHGPKBDHOE(IBKALPNABJD HHBJDCIBLBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x9BE0ED0", Offset = "0x9BDFAD0", VA = "0x189BE0ED0")]
	[AsyncStateMachine(typeof(MGJMDIIGAIE))]
	private Task NDKIBKJCBJH(CGAJCOIJKND LENPJBDMDOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x9BDED80", Offset = "0x9BDD980", VA = "0x189BDED80", Slot = "24")]
	[AsyncStateMachine(typeof(MPLNINHEBOL))]
	protected virtual Task KGMIMBMHIGG(BJCLAFDPBIO MOGMOMKEFJC, int GOPKHOKNFBK, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x9BE1C50", Offset = "0x9BE0850", VA = "0x189BE1C50")]
	[AsyncStateMachine(typeof(FBMBFNBADKI))]
	private Task OMEJJMIGBON(BJCLAFDPBIO MOGMOMKEFJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x9BD7200", Offset = "0x9BD5E00", VA = "0x189BD7200")]
	private static uint[] CHICMLOIDFC(BJCLAFDPBIO MOGMOMKEFJC, [Out] uint HMPAOHCFCPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x9BDC8E0", Offset = "0x9BDB4E0", VA = "0x189BDC8E0")]
	protected void IGPGNDDHOFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x9BD9160", Offset = "0x9BD7D60", VA = "0x189BD9160")]
	protected void ECHKJEFJAEG(Mesh MOGMOMKEFJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x9BD8190", Offset = "0x9BD6D90", VA = "0x189BD8190")]
	private FOKIBNIMBHB EANNAMBBLMK(BJCLAFDPBIO MKGHNILONOF, int GOPKHOKNFBK, bool LHLINGKNLKA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x9BDF960", Offset = "0x9BDE560", VA = "0x189BDF960")]
	[AsyncStateMachine(typeof(LNEHOOAKKEB))]
	protected Task LOJGFMNKCFI(FOKIBNIMBHB DNGLKAIFAFM, int GOPKHOKNFBK, string GLANGCJHONP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x9BE0C50", Offset = "0x9BDF850", VA = "0x189BE0C50")]
	private void NDBKGEHMMGO(FOKIBNIMBHB DNGLKAIFAFM, int GOPKHOKNFBK, Mesh MOGMOMKEFJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x9BD9F50", Offset = "0x9BD8B50", VA = "0x189BD9F50", Slot = "25")]
	[AsyncStateMachine(typeof(EPCGEHOOIEE))]
	protected virtual Task FPJIBNBNFFG(CGAJCOIJKND LENPJBDMDOJ, int GOPKHOKNFBK, int KIFLBBANIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x9BDA750", Offset = "0x9BD9350", VA = "0x189BDA750", Slot = "26")]
	protected virtual void HFEMMAHMGKN(CGAJCOIJKND LENPJBDMDOJ, int GOPKHOKNFBK, int KIFLBBANIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x9BD5890", Offset = "0x9BD4490", VA = "0x189BD5890")]
	private void AAOHDJODFAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x9BD96F0", Offset = "0x9BD82F0", VA = "0x189BD96F0")]
	[AsyncStateMachine(typeof(KPDHNJOIPFO))]
	private Task FDANKAODOII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x9BDEC60", Offset = "0x9BDD860", VA = "0x189BDEC60")]
	[AsyncStateMachine(typeof(EFGONLNHABB))]
	private Task KDCPDEJOPGB(BJCLAFDPBIO MOGMOMKEFJC, HDIKJDGIJBJ AMCBMBFJDPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x9BDA3C0", Offset = "0x9BD8FC0", VA = "0x189BDA3C0", Slot = "27")]
	[AsyncStateMachine(typeof(PJOIHEAFCGL))]
	protected virtual Task GJHGGBGAJFI(CGAJCOIJKND LENPJBDMDOJ, int GOPKHOKNFBK, int KIFLBBANIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x9BDD120", Offset = "0x9BDBD20", VA = "0x189BDD120")]
	protected void IPIKMCGBAAI(CFOGGKEJONC.JCHKKGCAFAJ DFFNIMONGAF, FOKIBNIMBHB BOEFBNNPIIP, uint GBMLFIJAPIE, int MGHEPKKBBIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x9BDCEF0", Offset = "0x9BDBAF0", VA = "0x189BDCEF0")]
	private void ILLEHEGLIFO(Dictionary<string, IFFIEJDGJCN> IANFNFABAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x9BDF4B0", Offset = "0x9BDE0B0", VA = "0x189BDF4B0")]
	protected MeshTopology LMGFINKHCBM(FFJCDOLCIFG CEBNHJNKAJN)
	{
		return default(MeshTopology);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x9BDF090", Offset = "0x9BDDC90", VA = "0x189BDF090")]
	private void KLOKCKLPELH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x9BD7720", Offset = "0x9BD6320", VA = "0x189BD7720", Slot = "28")]
	[AsyncStateMachine(typeof(PALPBBJNPGJ))]
	protected virtual Task DGDKPHHLJFE(IAKDHHGKPLM OJBEHJDDFDC, SkinnedMeshRenderer NMGNJGPOFCI, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x9BD6E00", Offset = "0x9BD5A00", VA = "0x189BD6E00")]
	private void CFIMMENFAKH(Vector4[] BHCFHLFDJCC, Vector4[] GEEDPNAIKKK, BoneWeight[] FMOLBLIAKOG, uint HDEKJKJDEIC = 0u)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x9BDEFB0", Offset = "0x9BDDBB0", VA = "0x189BDEFB0")]
	[AsyncStateMachine(typeof(BOOINEMIHEA))]
	private Task KJMNKMJIFOM(int LCCBBMBENOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x9BD75E0", Offset = "0x9BD61E0", VA = "0x189BD75E0")]
	[AsyncStateMachine(typeof(CMJMMCIBAPK))]
	private Task<FNBJDJLDKLM> DFPKDIAABLJ(PJDBNGEFJOL LMFBMFHCJLE, bool EGBDMBFKPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x9BE22F0", Offset = "0x9BE0EF0", VA = "0x189BE22F0")]
	private static int PLDBBDENCMJ(byte[] CBCNBAPLLJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x9BD6050", Offset = "0x9BD4C50", VA = "0x189BD6050")]
	private Dictionary<int, int> AFNMDJJPALH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x9BD6B30", Offset = "0x9BD5730", VA = "0x189BD6B30")]
	private void CEMDCHEAFJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x9BDA500", Offset = "0x9BD9100", VA = "0x189BDA500")]
	private Stream HALOMNCNOLL(MCDNKANAEIC OEFDPFNAKJP, int OAOFFPOMAEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x9BDFF90", Offset = "0x9BDEB90", VA = "0x189BDFF90")]
	[AsyncStateMachine(typeof(PCLLEIJDJCK))]
	protected Task MONNEENGKNC(MCDNKANAEIC OEFDPFNAKJP, int OAOFFPOMAEB, bool HODJCJEDEHH, bool LAKLLIIMGHM, bool EGBDMBFKPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x9BD6820", Offset = "0x9BD5420", VA = "0x189BD6820")]
	[AsyncStateMachine(typeof(FDAHJBNPGHB))]
	protected Task BGMNEKAMHEK(BHPGBKFIKFO PMMGDHEEDKB, int KCNHJGOIBHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x9BD9960", Offset = "0x9BD8560", VA = "0x189BD9960")]
	[AsyncStateMachine(typeof(ODDHCKKBLGI))]
	private Task<Texture2D> FGCHKDJAAKB(MCDNKANAEIC OEFDPFNAKJP, Texture2D PMMGDHEEDKB, NativeArray<byte> CBCNBAPLLJM, bool HODJCJEDEHH, bool LAKLLIIMGHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x9BD7E20", Offset = "0x9BD6A20", VA = "0x189BD7E20", Slot = "29")]
	[AsyncStateMachine(typeof(BJLENBIKFIE))]
	protected virtual Task DMIKJOIAOMJ(Stream NKIPIPEKKIL, bool HODJCJEDEHH, bool LAKLLIIMGHM, bool EGBDMBFKPDA, MCDNKANAEIC OEFDPFNAKJP, int OAOFFPOMAEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x9BDE050", Offset = "0x9BDCC50", VA = "0x189BDE050", Slot = "30")]
	protected virtual int JFLKFMKNGNH(BHPGBKFIKFO PMMGDHEEDKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x9BDA6E0", Offset = "0x9BD92E0", VA = "0x189BDA6E0", Slot = "31")]
	protected virtual bool HBKJPLABNKP(BHPGBKFIKFO PMMGDHEEDKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x9BDCDB0", Offset = "0x9BDB9B0", VA = "0x189BDCDB0", Slot = "32")]
	[AsyncStateMachine(typeof(PNEJFPAIDNE))]
	protected virtual Task ILGKCPMMKOJ(BHPGBKFIKFO PMMGDHEEDKB, int KCNHJGOIBHH, bool HODJCJEDEHH, bool LAKLLIIMGHM, bool EGBDMBFKPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x9BD9AC0", Offset = "0x9BD86C0", VA = "0x189BD9AC0")]
	[AsyncStateMachine(typeof(HPCHFALFKIJ))]
	[CompilerGenerated]
	private Task<IFFIEJDGJCN> FGFMFJJGEKD(OKIMNFHOFJN PLBPHCAAKEE, bool HEFILKIEIBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x9BDF6D0", Offset = "0x9BDE2D0", VA = "0x189BDF6D0")]
	[CompilerGenerated]
	internal static IFFIEJDGJCN LNIOLHADKAF(string MFCODBGLPHN, AKBKEPIPPPP P_1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x9BE18A0", Offset = "0x9BE04A0", VA = "0x189BE18A0")]
	[CompilerGenerated]
	private void OFPBOKEPFEH(DPLFMIFMAHH CPNMNHELBME, DDCKGKIHMOD AMCMDODCCHA, [Out] Vector2 ECJMFFOLCCL, [Out] Vector2 HDEKJKJDEIC, NDIAOICGJFC P_4)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x9BDFA90", Offset = "0x9BDE690", VA = "0x189BDFA90")]
	[CompilerGenerated]
	private void MBBEFJBCIDM(NDIAOICGJFC P_0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x9BE1660", Offset = "0x9BE0260", VA = "0x189BE1660")]
	[CompilerGenerated]
	private void NNOLPPKBFHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x9BE1E90", Offset = "0x9BE0A90", VA = "0x189BE1E90")]
	[CompilerGenerated]
	private TextureWrapMode PAHCLCMGMJP(LFLKKBNODFN GDDCHINGNHB)
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
		public enum NOODPILGHHB
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
		private sealed class OMNPPFEDMNN<T> where T : GLTFPlugin
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			public Type pluginType;

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
			public OMNPPFEDMNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x58863F0", Offset = "0x5884FF0", VA = "0x1858863F0")]
			internal bool PACGBONNIMM(T p)
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
		private NOODPILGHHB blendShapeExportProperties;

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
			[Cpp2IlInjected.Address(RVA = "0x9C09740", Offset = "0x9C08340", VA = "0x189C09740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool ExportNames
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xA8A4F0", Offset = "0xA890F0", VA = "0x180A8A4F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xA8A270", Offset = "0xA88E70", VA = "0x180A8A270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool ExportFullPath
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0xEF51A0", Offset = "0xEF3DA0", VA = "0x180EF51A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x152DC00", Offset = "0x152C800", VA = "0x18152DC00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool UseMainCameraVisibility
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x1C373D0", Offset = "0x1C35FD0", VA = "0x181C373D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x29A9AB0", Offset = "0x29A86B0", VA = "0x1829A9AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool TryExportTexturesFromDisk
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xE8E870", Offset = "0xE8D470", VA = "0x180E8E870")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xEB2320", Offset = "0xEB0F20", VA = "0x180EB2320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool UseTextureFileTypeHeuristic
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xEB22A0", Offset = "0xEB0EA0", VA = "0x180EB22A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xEB25F0", Offset = "0xEB11F0", VA = "0x180EB25F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool ExportVertexColors
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x7455BD0", Offset = "0x74547D0", VA = "0x187455BD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x74FFB00", Offset = "0x74FE700", VA = "0x1874FFB00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public int DefaultJpegQuality
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xA7B160", Offset = "0xA79D60", VA = "0x180A7B160")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xE7B530", Offset = "0xE7A130", VA = "0x180E7B530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool ExportDisabledGameObjects
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x298B670", Offset = "0x298A270", VA = "0x18298B670")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x8318890", Offset = "0x8317490", VA = "0x188318890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool ExportAnimations
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xF64F50", Offset = "0xF63B50", VA = "0x180F64F50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xF64F40", Offset = "0xF63B40", VA = "0x180F64F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool BakeAnimationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xF64E70", Offset = "0xF63A70", VA = "0x180F64E70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xF64D70", Offset = "0xF63970", VA = "0x180F64D70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		[Obsolete("Add/remove \"AnimationPointerPlugin\" from ExportPlugins instead.")]
		public bool UseAnimationPointer
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x9C09750", Offset = "0x9C08350", VA = "0x189C09750")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x9C09890", Offset = "0x9C08490", VA = "0x189C09890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool UniqueAnimationNames
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xF64D90", Offset = "0xF63990", VA = "0x180F64D90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xF64D80", Offset = "0xF63980", VA = "0x180F64D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool BlendShapeExportSparseAccessors
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x18AC360", Offset = "0x18AAF60", VA = "0x1818AC360")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x18BD890", Offset = "0x18BC490", VA = "0x1818BD890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public NOODPILGHHB BlendShapeExportProperties
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xD050B0", Offset = "0xD03CB0", VA = "0x180D050B0")]
			get
			{
				return default(NOODPILGHHB);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xF59B10", Offset = "0xF58710", VA = "0x180F59B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool BakeSkinnedMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x9C09730", Offset = "0x9C08330", VA = "0x189C09730")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x9C09880", Offset = "0x9C08480", VA = "0x189C09880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x9C08C30", Offset = "0x9C07830", VA = "0x189C08C30")]
		internal string IPJHGLONADK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x9C093C0", Offset = "0x9C07FC0", VA = "0x189C093C0")]
		public static GLTFSettings JNCMICBCMMO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x9C089D0", Offset = "0x9C075D0", VA = "0x189C089D0")]
		public static GLTFSettings ALKNKKBMABK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x9C08B00", Offset = "0x9C07700", VA = "0x189C08B00")]
		public static bool EMIDJEONNAK([Out] GLTFSettings DKFCHCGNBIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x9C08A40", Offset = "0x9C07640", VA = "0x189C08A40")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ClearStatics()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x9C08FB0", Offset = "0x9C07BB0", VA = "0x189C08FB0")]
		private static void JKANKIIIMML(GLTFSettings DKFCHCGNBIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x9C09630", Offset = "0x9C08230", VA = "0x189C09630")]
		public GLTFSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3C4A5A0", Offset = "0x3C491A0", VA = "0x183C4A5A0")]
		[CompilerGenerated]
		internal static List<Type> NEGFMEGBCFP<T>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x3C4A1A0", Offset = "0x3C48DA0", VA = "0x183C4A1A0")]
		[CompilerGenerated]
		internal static void MLFJKOODFDJ<T>(List<T> APMGKDOFJOF) where T : GLTFPlugin
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class ShaderNotFoundException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x9C172A0", Offset = "0x9C15EA0", VA = "0x189C172A0")]
		public ShaderNotFoundException()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x9C171F0", Offset = "0x9C15DF0", VA = "0x189C171F0")]
		public ShaderNotFoundException(string HLMEMBFCHLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x9C17250", Offset = "0x9C15E50", VA = "0x189C17250")]
		protected ShaderNotFoundException(SerializationInfo ACLFBNHJPDH, StreamingContext PBHLPKLGFAP)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class OLOMPAHGEDC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x9C13680", Offset = "0x9C12280", VA = "0x189C13680")]
	public OLOMPAHGEDC(string HLMEMBFCHLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class CGOLAGLLBLA : ILogHandler
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private readonly StringBuilder EAPMCFJDNJO;

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x9C04A40", Offset = "0x9C03640", VA = "0x189C04A40")]
	private string BIHKOGMDIAD(LogType BFOBJGKDHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x9C04CD0", Offset = "0x9C038D0", VA = "0x189C04CD0", Slot = "4")]
	public void LogFormat(LogType BFOBJGKDHNI, UnityEngine.Object PBHLPKLGFAP, string DNHJAJKHKHI, params object[] AHEPAEIEJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x9C04C30", Offset = "0x9C03830", VA = "0x189C04C30", Slot = "5")]
	public void LogException(Exception BIBIMCAHIHC, UnityEngine.Object PBHLPKLGFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x9C04AC0", Offset = "0x9C036C0", VA = "0x189C04AC0")]
	public void LPBDKHJPEEN(string DNHJAJKHKHI = "{0}")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x9C04D90", Offset = "0x9C03990", VA = "0x189C04D90")]
	public CGOLAGLLBLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class GNJPEFCNPAD
{
	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x9C0A2F0", Offset = "0x9C08EF0", VA = "0x189C0A2F0")]
	public static string OCOLBJHPCEC(Uri BKNLKENGIKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x9C0A280", Offset = "0x9C08E80", VA = "0x189C0A280")]
	public static string JIAOMODJGHC(string PMLOPLKNIFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x9C0A0E0", Offset = "0x9C08CE0", VA = "0x189C0A0E0")]
	public static void AAFONHNLIME(string BKNLKENGIKI, [Out] byte[] HPBOLKEANIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x9C0A1F0", Offset = "0x9C08DF0", VA = "0x189C0A1F0")]
	public static bool IEDLGAIFCDL(string BKNLKENGIKI)
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
		private IIFGDJLFJLH LFIBFFHDBBE;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public IIFGDJLFJLH CJBDECJJLMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x9C0C570", Offset = "0x9C0B170", VA = "0x189C0C570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x9C0C440", Offset = "0x9C0B040", VA = "0x189C0C440")]
		public InstantiatedGLTFObject Duplicate()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x9C0C520", Offset = "0x9C0B120", VA = "0x189C0C520")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xA5E010", Offset = "0xA5CC10", VA = "0x180A5E010")]
		public InstantiatedGLTFObject()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public struct BlendShapeFrameWeightSetting
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public enum GBHHNHMLECG
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
		internal GBHHNHMLECG _option;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		[SerializeField]
		internal float _multiplier;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float Multiplier
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x9C049B0", Offset = "0x9C035B0", VA = "0x189C049B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x9C049A0", Offset = "0x9C035A0", VA = "0x189C049A0")]
		public BlendShapeFrameWeightSetting(GBHHNHMLECG BIIIPOEBDMO)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x9C04910", Offset = "0x9C03510", VA = "0x189C04910")]
		public static float KDDDGPNBGLG(BlendShapeFrameWeightSetting ICBMFDLJOPF)
		{
			return default(float);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public enum CMGEHFAFAMK
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
		public abstract AOLODCHEPKL EOMLFAAOJBG(string CLGAOEPCDND, CALMGHCKIPD ENJHAFMCLFP);

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xCCB4F0", Offset = "0xCCA0F0", VA = "0x180CCB4F0")]
		protected ImporterFactory()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class DefaultImporterFactory : ImporterFactory
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x9C056D0", Offset = "0x9C042D0", VA = "0x189C056D0", Slot = "4")]
		public override AOLODCHEPKL EOMLFAAOJBG(string CLGAOEPCDND, CALMGHCKIPD ENJHAFMCLFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xCCB4F0", Offset = "0xCCA0F0", VA = "0x180CCB4F0")]
		public DefaultImporterFactory()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal static class KCGDGBBNDOL
{
	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x9C0C5D0", Offset = "0x9C0B1D0", VA = "0x189C0C5D0")]
	internal static void MPGJLFMPJFK(this Material CIBNABIMGCK, string BLHMNKIHNIJ, bool EKPDKNLBIHJ)
	{
	}
}
namespace UnityGLTF
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class MaterialLibrary : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xCCB4F0", Offset = "0xCCA0F0", VA = "0x180CCB4F0")]
		public MaterialLibrary()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal static class FBDHMIIOIDB
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class FEAHIIPNKBD
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
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public FEAHIIPNKBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x9C07BC0", Offset = "0x9C067C0", VA = "0x189C07BC0")]
		internal void AFHOIAGFGBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x9C07E30", Offset = "0x9C06A30", VA = "0x189C07E30")]
		internal void ENJCBHFHBMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x9C07E80", Offset = "0x9C06A80", VA = "0x189C07E80")]
		internal void NIBHNAHJFHG()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct FIAOPKHDBIH : IAsyncStateMachine
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
		private FEAHIIPNKBD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x9C07F20", Offset = "0x9C06B20", VA = "0x189C07F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x9C08570", Offset = "0x9C07170", VA = "0x189C08570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x9C07080", Offset = "0x9C05C80", VA = "0x189C07080")]
	[AsyncStateMachine(typeof(FIAOPKHDBIH))]
	public static Task<Texture2D> HHCNBDNFJHH(Texture2D NDMEBHICHPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class FOKIBNIMBHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public bool[] DDFBHEBBMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public Vector3[] AOCEIFILNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public Vector3[] JJENIHLDKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public Vector4[] AIHABBOLFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public Vector2[] LDPOJNEHFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public Vector2[] EGPPMKIHMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public Vector2[] ABNPPHKIHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public Vector2[] DFMOKPJPOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public Color[] FJEEMKJFNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public BoneWeight[] LAEPOFIMJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public Vector3[][] KJJHOPFFKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public Vector3[][] FOCINFDECAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public Vector3[][] JGPAHBOODII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public MeshTopology[] ONAPDNCGDJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public FFJCDOLCIFG[] NEOOPJBBHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public int[][] IEIOHFKEMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public HashSet<int> IFMBIIOGDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public uint[] CHBBMDEJDDM;

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x9C085E0", Offset = "0x9C071E0", VA = "0x189C085E0")]
	public void HAGLLFMPLGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x9C086F0", Offset = "0x9C072F0", VA = "0x189C086F0")]
	public bool HNNDNEBDJCF(FOKIBNIMBHB IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x9C08940", Offset = "0x9C07540", VA = "0x189C08940")]
	public FOKIBNIMBHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x3C368C0", Offset = "0x3C354C0", VA = "0x183C368C0")]
	[CompilerGenerated]
	internal static bool PMGCJJPMMPH<T>(T[] KBBBOGAGMLN, T[] FEKCHHBCMOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x3C36170", Offset = "0x3C34D70", VA = "0x183C36170")]
	[CompilerGenerated]
	internal static bool GJNDNDFMFLL<T>(T[][] KBBBOGAGMLN, T[][] FEKCHHBCMOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public abstract class AMFDIDEDMOG : EMCJJJEAHOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	internal Material BLBKBPHLOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private IEIBDPNHKIB DGLDKMGGPFG;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly int EKLGBELDLBK;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private static readonly int ILFMBKEDBHB;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private static readonly int NCIKADDINFB;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private static readonly int JMLNHMFFKFL;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private static readonly int GPBEOBDPGJA;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private static readonly int IDBKJEFBHHJ;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	private static readonly int NJCGJOGHJCI;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	private static readonly int EEAAEIIKDJH;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	private static readonly int OKJOFJJKLJD;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	private static readonly int NMLFFMMMMOD;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	private static readonly int EOHGDMGKIEF;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	private static readonly int LDMJPJBKFPD;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	private static readonly int PJELJOFDJMK;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	private static readonly int KKHAEPFOMHB;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Material HLAFGCCNOEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public virtual IEIBDPNHKIB PHJJHKBCOOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x9C01750", Offset = "0x9C00350", VA = "0x189C01750", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public double DFPHAIJHNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x9C016A0", Offset = "0x9C002A0", VA = "0x189C016A0", Slot = "12")]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x9C01020", Offset = "0x9BFFC20", VA = "0x189C01020", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public virtual bool HFCIDBCNBHC
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x9C011C0", Offset = "0x9BFFDC0", VA = "0x189C011C0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public virtual bool GDJINFGDGNC
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x9C01360", Offset = "0x9BFFF60", VA = "0x189C01360", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Texture IEBGCFIIAEC
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x9C016F0", Offset = "0x9C002F0", VA = "0x189C016F0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int GBDDAFNABJD
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x9C01080", Offset = "0x9BFFC80", VA = "0x189C01080", Slot = "16")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Vector2 BPFPFINEKCL
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x9C012A0", Offset = "0x9BFFEA0", VA = "0x189C012A0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public double BPANNDCAJII
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x9C01160", Offset = "0x9BFFD60", VA = "0x189C01160", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public Vector2 FPGMBBKGICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x9C01300", Offset = "0x9BFFF00", VA = "0x189C01300", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int LBBJNDBFNON
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x9C010F0", Offset = "0x9BFFCF0", VA = "0x189C010F0", Slot = "20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Color LPBNAPJKAIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x9C00CF0", Offset = "0x9BFF8F0", VA = "0x189C00CF0", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract EMCJJJEAHOG JEKMEOOFFAJ();

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0xA628A0", Offset = "0xA614A0", VA = "0x180A628A0")]
	protected AMFDIDEDMOG(Material GPMNIJPCANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x9C02480", Offset = "0x9C01080", VA = "0x189C02480")]
	protected AMFDIDEDMOG(string ALPAIJKDBHL, string BIPNMBGKKHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x9C015C0", Offset = "0x9C001C0", VA = "0x189C015C0")]
	protected void MIGAONJPOFD(Material CIBNABIMGCK, bool NDDBPONKIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x9C013E0", Offset = "0x9BFFFE0", VA = "0x189C013E0")]
	protected void KBELLHFJFNG(Material CIBNABIMGCK, bool IKOCIJBNOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x9C00D60", Offset = "0x9BFF960", VA = "0x189C00D60")]
	protected void AGBFGHMHNGD(Material CIBNABIMGCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class PPPBMEJKDEM : LOFAKLDNOFD, JFNHLFCFLIG, EKGEINMHCBL, EMCJJJEAHOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	private Vector2 KJOABDOCDHO;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public virtual Texture IEBGCFIIAEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x9C17180", Offset = "0x9C15D80", VA = "0x189C17180", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public virtual int GBDDAFNABJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public virtual Vector2 BPFPFINEKCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x9C16F60", Offset = "0x9C15B60", VA = "0x189C16F60", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public virtual double BPANNDCAJII
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public virtual Vector2 FPGMBBKGICL
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x9C16FD0", Offset = "0x9C15BD0", VA = "0x189C16FD0", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public virtual int LBBJNDBFNON
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "82")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public virtual Color LPBNAPJKAIL
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x9C16DF0", Offset = "0x9C159F0", VA = "0x189C16DF0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public virtual Texture AEAKFGALIKG
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x9C16EB0", Offset = "0x9C15AB0", VA = "0x189C16EB0", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public virtual int FMBMNIOEMNP
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public virtual Vector2 HPEEPDAKBEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "86")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public virtual double GHBBNPDOGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public virtual Vector2 JNKCMPLEHHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "88")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public virtual int LJFDGNMGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public virtual double KMIDLFLDFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x9C16E60", Offset = "0x9C15A60", VA = "0x189C16E60", Slot = "90")]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x9C16F00", Offset = "0x9C15B00", VA = "0x189C16F00", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual double GPCLGCCPANI
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "92")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x9C16DE0", Offset = "0x9C159E0", VA = "0x189C16DE0")]
	protected PPPBMEJKDEM(string ALPAIJKDBHL, string HFOFIGOPNHB, int BCCGGLCCCDK = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x9C171E0", Offset = "0x9C15DE0", VA = "0x189C171E0")]
	protected PPPBMEJKDEM(Material NIHABAJECDI, int BCCGGLCCCDK = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x9C17060", Offset = "0x9C15C60", VA = "0x189C17060", Slot = "60")]
	public override EMCJJJEAHOG JEKMEOOFFAJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class MOKPKILNIMG : PPPBMEJKDEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	private Vector2 JBFEMIKBHEJ;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public override int MKOOHAMAAAI
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public override int CCNKALBIFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public override int GEBIGCCDFOD
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override int GBDDAFNABJD
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override Texture AEAKFGALIKG
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x9C11EE0", Offset = "0x9C10AE0", VA = "0x189C11EE0", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public override int FMBMNIOEMNP
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public override Vector2 HPEEPDAKBEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x9C12180", Offset = "0x9C10D80", VA = "0x189C12180", Slot = "86")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public override double GHBBNPDOGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public override Vector2 JNKCMPLEHHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x9C11FC0", Offset = "0x9C10BC0", VA = "0x189C11FC0", Slot = "88")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public override int LJFDGNMGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public override double GPCLGCCPANI
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x9C11F60", Offset = "0x9C10B60", VA = "0x189C11F60", Slot = "92")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x9C12210", Offset = "0x9C10E10", VA = "0x189C12210")]
	public MOKPKILNIMG(string ALPAIJKDBHL, int BCCGGLCCCDK = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x9C121F0", Offset = "0x9C10DF0", VA = "0x189C121F0")]
	protected MOKPKILNIMG(Material NIHABAJECDI, int BCCGGLCCCDK = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x9C12050", Offset = "0x9C10C50", VA = "0x189C12050", Slot = "60")]
	public override EMCJJJEAHOG JEKMEOOFFAJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class LOPGEDLJHIN : AMFDIDEDMOG, JFNHLFCFLIG, EKGEINMHCBL, EMCJJJEAHOG, ICAJNHEEFGA, CJODENILCML, DDNKNOMGCJF, DABMELMGCDC, IDNEBPPDLAG, HDFKKKCECEI, CLMONGHPGGK, EGNGIONJJHJ, ANKDOIKFPNP
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Texture OFFPAHCNLCM
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x9C119C0", Offset = "0x9C105C0", VA = "0x189C119C0", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x9C117D0", Offset = "0x9C103D0", VA = "0x189C117D0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public int MKOOHAMAAAI
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x9C11330", Offset = "0x9C0FF30", VA = "0x189C11330", Slot = "39")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public double GICFEMKJGKG
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x9C113A0", Offset = "0x9C0FFA0", VA = "0x189C113A0", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public Vector2 PDCPCNFKLNK
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x9C11090", Offset = "0x9C0FC90", VA = "0x189C11090", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public double NOFABOHPPJA
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x9C112D0", Offset = "0x9C0FED0", VA = "0x189C112D0", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Vector2 PCCDBMINOEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x9C11150", Offset = "0x9C0FD50", VA = "0x189C11150", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int CNIJKJNLJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x9C0F5B0", Offset = "0x9C0E1B0", VA = "0x189C0F5B0", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Texture BDPJAPIFGHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x9C0FE20", Offset = "0x9C0EA20", VA = "0x189C0FE20", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public int CCNKALBIFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x9C0FA40", Offset = "0x9C0E640", VA = "0x189C0FA40", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public double PAOMCJCPLBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x9C11770", Offset = "0x9C10370", VA = "0x189C11770", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public Vector2 GNBBNLHHPIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x9C0F3D0", Offset = "0x9C0DFD0", VA = "0x189C0F3D0", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public double DCHCJPCHMIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x9C0F4F0", Offset = "0x9C0E0F0", VA = "0x189C0F4F0", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Vector2 LGJJDIAJKKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x9C104F0", Offset = "0x9C0F0F0", VA = "0x189C104F0", Slot = "50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int LDHOEOOJKDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x9C11950", Offset = "0x9C10550", VA = "0x189C11950", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public Texture FLOCLEPCPHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x9C10DF0", Offset = "0x9C0F9F0", VA = "0x189C10DF0", Slot = "52")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public int GEBIGCCDFOD
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x9C0F8C0", Offset = "0x9C0E4C0", VA = "0x189C0F8C0", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Color EEJGDHGNJDO
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x9C114C0", Offset = "0x9C100C0", VA = "0x189C114C0", Slot = "54")]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x9C0FD50", Offset = "0x9C0E950", VA = "0x189C0FD50", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector2 DEDAPFMHDDL
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x9C10EB0", Offset = "0x9C0FAB0", VA = "0x189C10EB0", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public double NKIBEIPOFJP
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x9C10190", Offset = "0x9C0ED90", VA = "0x189C10190", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector2 KIIJMOAFHBO
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x9C10D90", Offset = "0x9C0F990", VA = "0x189C10D90", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public int LFCFHELABFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x9C10FD0", Offset = "0x9C0FBD0", VA = "0x189C10FD0", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public Texture AEAKFGALIKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x9C0F9E0", Offset = "0x9C0E5E0", VA = "0x189C0F9E0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public int FMBMNIOEMNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x9C11890", Offset = "0x9C10490", VA = "0x189C11890", Slot = "30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Vector2 HPEEPDAKBEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x9C11460", Offset = "0x9C10060", VA = "0x189C11460", Slot = "31")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public double GHBBNPDOGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x9C10800", Offset = "0x9C0F400", VA = "0x189C10800", Slot = "32")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector2 JNKCMPLEHHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x9C10130", Offset = "0x9C0ED30", VA = "0x189C10130", Slot = "33")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public int LJFDGNMGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x9C101F0", Offset = "0x9C0EDF0", VA = "0x189C101F0", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public double KMIDLFLDFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x9C0FF40", Offset = "0x9C0EB40", VA = "0x189C0FF40", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public double GPCLGCCPANI
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x9C100D0", Offset = "0x9C0ECD0", VA = "0x189C100D0", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public double ABIADEKMHMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x9C107A0", Offset = "0x9C0F3A0", VA = "0x189C107A0", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Texture JFKJFJKGLOH
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x9C10D30", Offset = "0x9C0F930", VA = "0x189C10D30", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public double NHKEOLIFJAE
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x9C0FCF0", Offset = "0x9C0E8F0", VA = "0x189C0FCF0", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Vector2 BEFFOMAKHAM
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x9C0F620", Offset = "0x9C0E220", VA = "0x189C0F620", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public Vector2 OKKGKEOKMOC
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x9C0FC90", Offset = "0x9C0E890", VA = "0x189C0FC90", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public int DPEBJOCNPAL
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x9C10550", Offset = "0x9C0F150", VA = "0x189C10550", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public double IBINMFILEPE
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x9C0FBD0", Offset = "0x9C0E7D0", VA = "0x189C0FBD0", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Color PFICJPIFPJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x9C10670", Offset = "0x9C0F270", VA = "0x189C10670", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public double AJEKGECKNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x9C0F920", Offset = "0x9C0E520", VA = "0x189C0F920", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Texture OGJLNOEEHOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x9C11400", Offset = "0x9C10000", VA = "0x189C11400", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public double CPBLCBFDFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x9C10C10", Offset = "0x9C0F810", VA = "0x189C10C10", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Vector2 AIKKFIKMDAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x9C11030", Offset = "0x9C0FC30", VA = "0x189C11030", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector2 MIDLABBHCIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x9C10070", Offset = "0x9C0EC70", VA = "0x189C10070", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public int FBDGGMBIJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x9C102B0", Offset = "0x9C0EEB0", VA = "0x189C102B0", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public double GOKCEDMKALM
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x9C10F70", Offset = "0x9C0FB70", VA = "0x189C10F70", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public double EPPGIMIJOCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x9C11830", Offset = "0x9C10430", VA = "0x189C11830", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public double KJDNIANOJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x9C0F980", Offset = "0x9C0E580", VA = "0x189C0F980", Slot = "76")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public double MJBABLFINEO
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x9C0F310", Offset = "0x9C0DF10", VA = "0x189C0F310", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public double FHFKAOJPKCH
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x9C11650", Offset = "0x9C10250", VA = "0x189C11650", Slot = "78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public Texture FHNFMDBCCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x9C0FB70", Offset = "0x9C0E770", VA = "0x189C0FB70", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public double BEIEGCJONKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x9C11590", Offset = "0x9C10190", VA = "0x189C11590", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public Vector2 KBOPFAPBMAO
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x9C0F7A0", Offset = "0x9C0E3A0", VA = "0x189C0F7A0", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public Vector2 OLLFBLKAEIP
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x9C105B0", Offset = "0x9C0F1B0", VA = "0x189C105B0", Slot = "82")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public int JLMNOOLCKMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x9C10310", Offset = "0x9C0EF10", VA = "0x189C10310", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public Texture CPDOLELHGHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x9C11210", Offset = "0x9C0FE10", VA = "0x189C11210", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public double KABEIINAKEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x9C0F860", Offset = "0x9C0E460", VA = "0x189C0F860", Slot = "86")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public Vector2 FKIHKAFMAJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x9C109D0", Offset = "0x9C0F5D0", VA = "0x189C109D0", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public Vector2 FDKMLIHBJJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x9C103D0", Offset = "0x9C0EFD0", VA = "0x189C103D0", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public int PGLFGOABDJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x9C10A90", Offset = "0x9C0F690", VA = "0x189C10A90", Slot = "88")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public double HGJAIPAMFJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x9C10AF0", Offset = "0x9C0F6F0", VA = "0x189C10AF0", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public Texture KGFEFMMOPPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x9C10BB0", Offset = "0x9C0F7B0", VA = "0x189C10BB0", Slot = "90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public double DNNCEMFIDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x9C0F370", Offset = "0x9C0DF70", VA = "0x189C0F370", Slot = "92")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public Vector2 IKIOFJKJPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x9C10250", Offset = "0x9C0EE50", VA = "0x189C10250", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public Vector2 APIJPJENMIC
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x9C118F0", Offset = "0x9C104F0", VA = "0x189C118F0", Slot = "93")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public int JLMJLKCNGFN
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x9C0FEE0", Offset = "0x9C0EAE0", VA = "0x189C0FEE0", Slot = "94")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public Color BFPHAACLKKK
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x9C0F2A0", Offset = "0x9C0DEA0", VA = "0x189C0F2A0", Slot = "95")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public Texture KPCOKGJIOOK
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x9C0FC30", Offset = "0x9C0E830", VA = "0x189C0FC30", Slot = "96")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public double APMNAGBMPMP
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x9C10C70", Offset = "0x9C0F870", VA = "0x189C10C70", Slot = "98")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector2 AMFLPIFHJII
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x9C10430", Offset = "0x9C0F030", VA = "0x189C10430", Slot = "97")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector2 MLAMPNDICOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x9C10370", Offset = "0x9C0EF70", VA = "0x189C10370", Slot = "99")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public int CIBDEFHOCGD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x9C0F680", Offset = "0x9C0E280", VA = "0x189C0F680", Slot = "100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public double NEICKPHFAAI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x9C0F490", Offset = "0x9C0E090", VA = "0x189C0F490", Slot = "101")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Texture JBODFLOLCDN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x9C11A10", Offset = "0x9C10610", VA = "0x189C11A10", Slot = "102")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public double FFPFPLJEMHA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x9C106E0", Offset = "0x9C0F2E0", VA = "0x189C106E0", Slot = "104")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector2 GLEINJCEAIK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x9C10490", Offset = "0x9C0F090", VA = "0x189C10490", Slot = "103")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector2 JFCGIFNLNPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x9C10A30", Offset = "0x9C0F630", VA = "0x189C10A30", Slot = "105")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int MJNNPHMAJHE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x9C11270", Offset = "0x9C0FE70", VA = "0x189C11270", Slot = "106")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public double NGHHKNFOJKD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x9C0F430", Offset = "0x9C0E030", VA = "0x189C0F430", Slot = "107")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Texture KCGPCGMJFIA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x9C0F240", Offset = "0x9C0DE40", VA = "0x189C0F240", Slot = "108")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public double OMKCMEKKIHP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x9C11530", Offset = "0x9C10130", VA = "0x189C11530", Slot = "110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public Vector2 IJDOPPPMEJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x9C10740", Offset = "0x9C0F340", VA = "0x189C10740", Slot = "109")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public Vector2 NDACMMJILPI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x9C0F740", Offset = "0x9C0E340", VA = "0x189C0F740", Slot = "111")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public int NJOPFENHHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x9C10610", Offset = "0x9C0F210", VA = "0x189C10610", Slot = "112")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public float EMCOECKINBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x9C10F10", Offset = "0x9C0FB10", VA = "0x189C10F10", Slot = "113")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public float HNBNIFFBMLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x9C0F1E0", Offset = "0x9C0DDE0", VA = "0x189C0F1E0", Slot = "114")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public Color DFPLDKCNBAG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x9C10000", Offset = "0x9C0EC00", VA = "0x189C10000", Slot = "115")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public Texture PNDKACOLLAI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x9C10970", Offset = "0x9C0F570", VA = "0x189C10970", Slot = "116")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public double DMGOIJJPHLA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x9C0FAB0", Offset = "0x9C0E6B0", VA = "0x189C0FAB0", Slot = "117")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public Vector2 CDDDLADDFGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x9C0F550", Offset = "0x9C0E150", VA = "0x189C0F550", Slot = "118")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public Vector2 AIBFIEHACLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x9C10B50", Offset = "0x9C0F750", VA = "0x189C10B50", Slot = "119")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public int ADCLLKFCJBO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x9C0FDC0", Offset = "0x9C0E9C0", VA = "0x189C0FDC0", Slot = "120")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public Texture HEPCMACHOGD
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x9C0FFA0", Offset = "0x9C0EBA0", VA = "0x189C0FFA0", Slot = "121")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public double FDDJONFMJGC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x9C0F800", Offset = "0x9C0E400", VA = "0x189C0F800", Slot = "122")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Vector2 BDBKPNBEMFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x9C0FB10", Offset = "0x9C0E710", VA = "0x189C0FB10", Slot = "123")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public Vector2 IJHBNIJMPHI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x9C110F0", Offset = "0x9C0FCF0", VA = "0x189C110F0", Slot = "124")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public int KAABPFEIGHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x9C116B0", Offset = "0x9C102B0", VA = "0x189C116B0", Slot = "125")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public double EINJJNKDDOB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x9C10E50", Offset = "0x9C0FA50", VA = "0x189C10E50", Slot = "131")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public double BLMKJPKGEEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x9C115F0", Offset = "0x9C101F0", VA = "0x189C115F0", Slot = "132")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Texture FBCCINEDFDF
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x9C0FE80", Offset = "0x9C0EA80", VA = "0x189C0FE80", Slot = "126")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public double OALJNIFEDGA
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x9C0F6E0", Offset = "0x9C0E2E0", VA = "0x189C0F6E0", Slot = "128")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector2 IIOFFCLHBKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x9C10CD0", Offset = "0x9C0F8D0", VA = "0x189C10CD0", Slot = "127")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector2 ACKIOGOCPGL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x9C111B0", Offset = "0x9C0FDB0", VA = "0x189C111B0", Slot = "129")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public int FLEKIDCFKIF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x9C11710", Offset = "0x9C10310", VA = "0x189C11710", Slot = "130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x9C11AE0", Offset = "0x9C106E0", VA = "0x189C11AE0")]
	public LOPGEDLJHIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x9C11B70", Offset = "0x9C10770", VA = "0x189C11B70")]
	protected LOPGEDLJHIN(string ALPAIJKDBHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x9C11A70", Offset = "0x9C10670", VA = "0x189C11A70")]
	public LOPGEDLJHIN(Material GPMNIJPCANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x9C10860", Offset = "0x9C0F460", VA = "0x189C10860", Slot = "10")]
	public override EMCJJJEAHOG JEKMEOOFFAJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class GMEMECBEOOO : LOFAKLDNOFD, GIINNGPBEJA, EKGEINMHCBL, EMCJJJEAHOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	private Vector2 GEDDLHDNCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	private Vector2 OCHDJKBDMHI;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public virtual Texture PPLKOKMDOLL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x9C09C40", Offset = "0x9C08840", VA = "0x189C09C40", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public virtual int NLIFLNGAJMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public virtual Vector2 IKEAPHPPCGL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x9C09BD0", Offset = "0x9C087D0", VA = "0x189C09BD0", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public virtual double OOMNJNKKLEG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public virtual Vector2 CBENLFDLLIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x9C09E60", Offset = "0x9C08A60", VA = "0x189C09E60", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public virtual int AOHGKADPGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "82")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public virtual Color KJDCBCLPNHA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x9C09AF0", Offset = "0x9C086F0", VA = "0x189C09AF0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public virtual Texture DMPBMKFEKPN
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x9C09F80", Offset = "0x9C08B80", VA = "0x189C09F80", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public virtual int CPBNFECLIOL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public virtual Vector2 MLHIIGGFAFE
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x9C09B60", Offset = "0x9C08760", VA = "0x189C09B60", Slot = "86")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public virtual double CCJABAIBNBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public virtual Vector2 FKDFOGHAACP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x9C09EF0", Offset = "0x9C08AF0", VA = "0x189C09EF0", Slot = "88")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public virtual int OMDOBMNLIPH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public virtual Vector3 HGJAIPAMFJB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x9C09DD0", Offset = "0x9C089D0", VA = "0x189C09DD0", Slot = "90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public virtual double JBKNDMAJKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x9C0A030", Offset = "0x9C08C30", VA = "0x189C0A030", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x9C0A0C0", Offset = "0x9C08CC0", VA = "0x189C0A0C0")]
	protected GMEMECBEOOO(string ALPAIJKDBHL, string HFOFIGOPNHB, int BCCGGLCCCDK = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x9C05F90", Offset = "0x9C04B90", VA = "0x189C05F90")]
	protected GMEMECBEOOO(Material NIHABAJECDI, int BCCGGLCCCDK = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x9C09CA0", Offset = "0x9C088A0", VA = "0x189C09CA0", Slot = "60")]
	public override EMCJJJEAHOG JEKMEOOFFAJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class ENBDGEDCOMI : GMEMECBEOOO
{
	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public override int MKOOHAMAAAI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public override int CCNKALBIFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public override int GEBIGCCDFOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public override int NLIFLNGAJMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public override int CPBNFECLIOL
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x9C05F20", Offset = "0x9C04B20", VA = "0x189C05F20")]
	public ENBDGEDCOMI(string ALPAIJKDBHL, int BCCGGLCCCDK = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x9C05F90", Offset = "0x9C04B90", VA = "0x189C05F90")]
	protected ENBDGEDCOMI(Material NIHABAJECDI, int BCCGGLCCCDK = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x9C05DF0", Offset = "0x9C049F0", VA = "0x189C05DF0", Slot = "60")]
	public override EMCJJJEAHOG JEKMEOOFFAJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class LOFAKLDNOFD : EKGEINMHCBL, EMCJJJEAHOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	protected Material BLBKBPHLOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private IEIBDPNHKIB DGLDKMGGPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private double LPNFOONMAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private Vector2 MPKNFKINLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private Vector2 IJJEANPOABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private Vector2 PJDKGIFNGPL;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public Material HLAFGCCNOEP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public virtual Texture OFFPAHCNLCM
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x9C0EA50", Offset = "0x9C0D650", VA = "0x189C0EA50", Slot = "33")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x9C0E970", Offset = "0x9C0D570", VA = "0x189C0E970", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public virtual int MKOOHAMAAAI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public virtual Vector2 PDCPCNFKLNK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x9C0E650", Offset = "0x9C0D250", VA = "0x189C0E650", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public virtual double NOFABOHPPJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public virtual Vector2 PCCDBMINOEP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x9C0E6C0", Offset = "0x9C0D2C0", VA = "0x189C0E6C0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public virtual int CNIJKJNLJFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "39")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public virtual double GICFEMKJGKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x9C0E750", Offset = "0x9C0D350", VA = "0x189C0E750", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public virtual Texture BDPJAPIFGHH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x9C0E1F0", Offset = "0x9C0CDF0", VA = "0x189C0E1F0", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public virtual int CCNKALBIFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public virtual Vector2 GNBBNLHHPIL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x9C0DF30", Offset = "0x9C0CB30", VA = "0x189C0DF30", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public virtual double DCHCJPCHMIA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public virtual Vector2 LGJJDIAJKKH
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x9C0E2B0", Offset = "0x9C0CEB0", VA = "0x189C0E2B0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public virtual int LDHOEOOJKDH
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public virtual double PAOMCJCPLBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x9C0E8B0", Offset = "0x9C0D4B0", VA = "0x189C0E8B0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public virtual Texture FLOCLEPCPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x9C0E500", Offset = "0x9C0D100", VA = "0x189C0E500", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public virtual int GEBIGCCDFOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public virtual Vector2 DEDAPFMHDDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x9C0E5E0", Offset = "0x9C0D1E0", VA = "0x189C0E5E0", Slot = "50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public virtual double NKIBEIPOFJP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public virtual Vector2 KIIJMOAFHBO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x9C0E470", Offset = "0x9C0D070", VA = "0x189C0E470", Slot = "52")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public virtual int LFCFHELABFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public virtual Color EEJGDHGNJDO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x9C0E810", Offset = "0x9C0D410", VA = "0x189C0E810", Slot = "54")]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x9C0E140", Offset = "0x9C0CD40", VA = "0x189C0E140", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public virtual IEIBDPNHKIB PHJJHKBCOOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x9C0EAC0", Offset = "0x9C0D6C0", VA = "0x189C0EAC0", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public virtual double DFPHAIJHNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x9C0DFA0", Offset = "0x9C0CBA0", VA = "0x189C0DFA0", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public virtual bool HFCIDBCNBHC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x9C0E0D0", Offset = "0x9C0CCD0", VA = "0x189C0E0D0", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public virtual bool GDJINFGDGNC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x9C0E3F0", Offset = "0x9C0CFF0", VA = "0x189C0E3F0", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x9C0EF50", Offset = "0x9C0DB50", VA = "0x189C0EF50")]
	protected LOFAKLDNOFD(string ALPAIJKDBHL, string BIPNMBGKKHF, int BCCGGLCCCDK = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x9C0F0C0", Offset = "0x9C0DCC0", VA = "0x189C0F0C0")]
	protected LOFAKLDNOFD(Material GPMNIJPCANI, int BCCGGLCCCDK = 1000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x9C0E340", Offset = "0x9C0CF40", VA = "0x189C0E340", Slot = "60")]
	public virtual EMCJJJEAHOG JEKMEOOFFAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x9C0E030", Offset = "0x9C0CC30", VA = "0x189C0E030", Slot = "61")]
	protected virtual void EAKGOBIEKMJ(EKGEINMHCBL FKPCPEEFHLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface EMCJJJEAHOG
{
	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	Material HLAFGCCNOEP
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	IEIBDPNHKIB PHJJHKBCOOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	double DFPHAIJHNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	bool HFCIDBCNBHC
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	bool GDJINFGDGNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EMCJJJEAHOG JEKMEOOFFAJ();
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface EKGEINMHCBL : EMCJJJEAHOG
{
	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	Texture OFFPAHCNLCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	int MKOOHAMAAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	double GICFEMKJGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	Vector2 PDCPCNFKLNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	double NOFABOHPPJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	Vector2 PCCDBMINOEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	int CNIJKJNLJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	Texture BDPJAPIFGHH
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	int CCNKALBIFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	double PAOMCJCPLBL
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	Vector2 GNBBNLHHPIL
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	double DCHCJPCHMIA
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	Vector2 LGJJDIAJKKH
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	int LDHOEOOJKDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	Texture FLOCLEPCPHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	int GEBIGCCDFOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(Slot = "16")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	Color EEJGDHGNJDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(Slot = "18")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	Vector2 DEDAPFMHDDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	double NKIBEIPOFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(Slot = "20")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	Vector2 KIIJMOAFHBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	int LFCFHELABFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(Slot = "22")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface JFNHLFCFLIG : EKGEINMHCBL, EMCJJJEAHOG
{
	[Cpp2IlInjected.Token(Token = "0x17000107")]
	Texture IEBGCFIIAEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	int GBDDAFNABJD
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	Vector2 BPFPFINEKCL
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	double BPANNDCAJII
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	Vector2 FPGMBBKGICL
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	int LBBJNDBFNON
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	Color LPBNAPJKAIL
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	Texture AEAKFGALIKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	int FMBMNIOEMNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	Vector2 HPEEPDAKBEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	double GHBBNPDOGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	Vector2 JNKCMPLEHHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	int LJFDGNMGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(Slot = "12")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	double KMIDLFLDFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	double GPCLGCCPANI
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public interface ICAJNHEEFGA : JFNHLFCFLIG, EKGEINMHCBL, EMCJJJEAHOG
{
	[Cpp2IlInjected.Token(Token = "0x17000116")]
	double ABIADEKMHMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	Texture JFKJFJKGLOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	Vector2 BEFFOMAKHAM
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	double NHKEOLIFJAE
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	Vector2 OKKGKEOKMOC
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	int DPEBJOCNPAL
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	double IBINMFILEPE
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	Color PFICJPIFPJC
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public interface CJODENILCML : JFNHLFCFLIG, EKGEINMHCBL, EMCJJJEAHOG
{
	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	double AJEKGECKNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	Texture OGJLNOEEHOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	Vector2 AIKKFIKMDAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	double CPBLCBFDFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	Vector2 MIDLABBHCIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	int FBDGGMBIJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public interface EGNGIONJJHJ : JFNHLFCFLIG, EKGEINMHCBL, EMCJJJEAHOG
{
	[Cpp2IlInjected.Token(Token = "0x17000124")]
	float HNBNIFFBMLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	Color DFPLDKCNBAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	Texture PNDKACOLLAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	double DMGOIJJPHLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	Vector2 CDDDLADDFGI
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	Vector2 AIBFIEHACLI
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	int ADCLLKFCJBO
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	Texture HEPCMACHOGD
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	double FDDJONFMJGC
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	Vector2 BDBKPNBEMFH
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	Vector2 IJHBNIJMPHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	int KAABPFEIGHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public interface CLMONGHPGGK : CJODENILCML, JFNHLFCFLIG, EKGEINMHCBL, EMCJJJEAHOG
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	float EMCOECKINBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public interface DDNKNOMGCJF : JFNHLFCFLIG, EKGEINMHCBL, EMCJJJEAHOG
{
	[Cpp2IlInjected.Token(Token = "0x17000131")]
	double GOKCEDMKALM
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public interface IDNEBPPDLAG : JFNHLFCFLIG, EKGEINMHCBL, EMCJJJEAHOG
{
	[Cpp2IlInjected.Token(Token = "0x17000132")]
	double HGJAIPAMFJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	Texture KGFEFMMOPPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	Vector2 IKIOFJKJPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	double DNNCEMFIDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	Vector2 APIJPJENMIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	int JLMJLKCNGFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	Color BFPHAACLKKK
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	Texture KPCOKGJIOOK
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	Vector2 AMFLPIFHJII
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	double APMNAGBMPMP
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	Vector2 MLAMPNDICOI
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	int CIBDEFHOCGD
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public interface DABMELMGCDC : JFNHLFCFLIG, EKGEINMHCBL, EMCJJJEAHOG
{
	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	double EPPGIMIJOCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	double KJDNIANOJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	double MJBABLFINEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	double FHFKAOJPKCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	Texture FHNFMDBCCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	Vector2 KBOPFAPBMAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	double BEIEGCJONKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	Vector2 OLLFBLKAEIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	int JLMNOOLCKMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	Texture CPDOLELHGHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	Vector2 FKIHKAFMAJA
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	double KABEIINAKEC
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	Vector2 FDKMLIHBJJO
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	int PGLFGOABDJG
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public interface GIINNGPBEJA : EKGEINMHCBL, EMCJJJEAHOG
{
	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	Texture PPLKOKMDOLL
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	int NLIFLNGAJMG
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	Vector2 IKEAPHPPCGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	double OOMNJNKKLEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	Vector2 CBENLFDLLIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	int AOHGKADPGBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	Color KJDCBCLPNHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	Texture DMPBMKFEKPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	int CPBNFECLIOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	Vector2 MLHIIGGFAFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	double CCJABAIBNBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	Vector2 FKDFOGHAACP
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	int OMDOBMNLIPH
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	Vector3 HGJAIPAMFJB
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	double JBKNDMAJKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public interface HDFKKKCECEI : JFNHLFCFLIG, EKGEINMHCBL, EMCJJJEAHOG
{
	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	double NEICKPHFAAI
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	Texture JBODFLOLCDN
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	Vector2 GLEINJCEAIK
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	double FFPFPLJEMHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	Vector2 JFCGIFNLNPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	int MJNNPHMAJHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	double NGHHKNFOJKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	Texture KCGPCGMJFIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	Vector2 IJDOPPPMEJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	double OMKCMEKKIHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	Vector2 NDACMMJILPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	int NJOPFENHHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public interface BMADAMEEEJC
{
	[Cpp2IlInjected.Token(Token = "0x17000167")]
	Texture MEIIDPHOLKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	Vector2 DEDCOCCCILA
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	double LPEIHEBHLOA
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	Vector2 NCECGFJLBGC
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	int GGCIFEGGFMG
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public interface ANKDOIKFPNP
{
	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	Texture FBCCINEDFDF
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	Vector2 IIOFFCLHBKK
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	double OALJNIFEDGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	Vector2 ACKIOGOCPGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	int FLEKIDCFKIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	double EINJJNKDDOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	double BLMKJPKGEEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public interface BJOAIPKGIOB : EMCJJJEAHOG
{
	[Cpp2IlInjected.Token(Token = "0x17000173")]
	Texture IEBGCFIIAEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	int GBDDAFNABJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	Vector2 BPFPFINEKCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	double BPANNDCAJII
	{
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	Vector2 FPGMBBKGICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	int LBBJNDBFNON
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	Color LPBNAPJKAIL
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class CLKJMAJIEIA : AMFDIDEDMOG, BJOAIPKGIOB, EMCJJJEAHOG
{
	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x9C05000", Offset = "0x9C03C00", VA = "0x189C05000")]
	public CLKJMAJIEIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x9C04F20", Offset = "0x9C03B20", VA = "0x189C04F20")]
	protected CLKJMAJIEIA(string ALPAIJKDBHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x9C04F90", Offset = "0x9C03B90", VA = "0x189C04F90")]
	public CLKJMAJIEIA(Material GPMNIJPCANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x9C04E10", Offset = "0x9C03A10", VA = "0x189C04E10", Slot = "10")]
	public override EMCJJJEAHOG JEKMEOOFFAJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class PNHBMPEKJHJ : LOFAKLDNOFD, BJOAIPKGIOB, EMCJJJEAHOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private Vector2 KJOABDOCDHO;

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public Texture IEBGCFIIAEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x9C16D80", Offset = "0x9C15980", VA = "0x189C16D80", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public virtual int GBDDAFNABJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public virtual Vector2 BPFPFINEKCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x9C16C80", Offset = "0x9C15880", VA = "0x189C16C80", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public virtual double BPANNDCAJII
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public virtual Vector2 FPGMBBKGICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x9C16CF0", Offset = "0x9C158F0", VA = "0x189C16CF0", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	public virtual int LBBJNDBFNON
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	public virtual Color LPBNAPJKAIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x9C16C10", Offset = "0x9C15810", VA = "0x189C16C10", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x9C16DE0", Offset = "0x9C159E0", VA = "0x189C16DE0")]
	public PNHBMPEKJHJ(string ALPAIJKDBHL, string HFOFIGOPNHB, int BCCGGLCCCDK = 1000)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class GNNCEMBODDB
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public delegate void MLKIJODKMEM(HKFMEFKPMED ACJICCPJEHG);

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public delegate void ENKFAFEPDNH(KGFJPAJBBEO ACJICCPJEHG);

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class KGFJPAJBBEO
	{
		[Cpp2IlInjected.Token(Token = "0x17000183")]
		private Bounds HEOIAFMPNHI
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x9086E30", Offset = "0x9085A30", VA = "0x189086E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000184")]
		private DDIHIDBGEBH PHJAHJHLFND
		{
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0xA683D0", Offset = "0xA66FD0", VA = "0x180A683D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000185")]
		private EEBBIHGHGOL EPPFBJIBOKD
		{
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0xA5FCB0", Offset = "0xA5E8B0", VA = "0x180A5FCB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x9C1F360", Offset = "0x9C1DF60", VA = "0x189C1F360")]
		internal KGFJPAJBBEO(Bounds AIFAMJFGGJP, DDIHIDBGEBH OOJHOOBDAMG, EEBBIHGHGOL LPFALNIFEHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class HKFMEFKPMED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		internal NHKAINPFJJL.FIIBBBEODKJ DGMKHLEIIPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public float[] HGHMLHLAFLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public object[] OGINALBFHEH;

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xD56060", Offset = "0xD54C60", VA = "0x180D56060")]
		internal HKFMEFKPMED(NHKAINPFJJL.FIIBBBEODKJ HOKJJIHKKNO, float[] DPMMIPDBPJC, object[] OKFGGFMLPHB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	internal class NHKAINPFJJL
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		internal class FLBPJIHLFIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			public string BABLEGNKCCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			public Type GAPPGJIFANP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			public Func<Transform, UnityEngine.Object> JMPIHIIHAJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			public Func<Transform, UnityEngine.Object, NHKAINPFJJL, object> MNHLGFCLHJH;

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x107AF70", Offset = "0x1079B70", VA = "0x18107AF70")]
			public FLBPJIHLFIJ(string BABLEGNKCCH, Type GAPPGJIFANP, Func<Transform, UnityEngine.Object> JMPIHIIHAJM, Func<Transform, UnityEngine.Object, NHKAINPFJJL, object> MNHLGFCLHJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x9C1A820", Offset = "0x9C19420", VA = "0x189C1A820")]
			public object FJFADGDICCM(NHKAINPFJJL CBCNBAPLLJM)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000098")]
		internal class FIIBBBEODKJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000099")]
			private class LKKCBJNHHOL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000376")]
				public double HCMFNJGJPMC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000377")]
				public object BKMPCFIAHIG;

				[Cpp2IlInjected.Token(Token = "0x60003B7")]
				[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
				public LKKCBJNHHOL()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			private NHKAINPFJJL HOKJJIHKKNO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			private FLBPJIHLFIJ CPOPDPPEEBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			private Dictionary<double, object> MPFONBMLLDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			private LKKCBJNHHOL DBDAKCGJIPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			private LKKCBJNHHOL MHLLLBKPNIE;

			[Cpp2IlInjected.Token(Token = "0x17000186")]
			public UnityEngine.Object ADELBPFFNIJ
			{
				[Cpp2IlInjected.Token(Token = "0x60003B1")]
				[Cpp2IlInjected.Address(RVA = "0x9C1A710", Offset = "0x9C19310", VA = "0x189C1A710")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000187")]
			public string BABLEGNKCCH
			{
				[Cpp2IlInjected.Token(Token = "0x60003B2")]
				[Cpp2IlInjected.Address(RVA = "0x59181B0", Offset = "0x5916DB0", VA = "0x1859181B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000188")]
			public float[] DPMMIPDBPJC
			{
				[Cpp2IlInjected.Token(Token = "0x60003B3")]
				[Cpp2IlInjected.Address(RVA = "0x9C1A5A0", Offset = "0x9C191A0", VA = "0x189C1A5A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000189")]
			public object[] OKFGGFMLPHB
			{
				[Cpp2IlInjected.Token(Token = "0x60003B4")]
				[Cpp2IlInjected.Address(RVA = "0x9C1A540", Offset = "0x9C19140", VA = "0x189C1A540")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x9C1A750", Offset = "0x9C19350", VA = "0x189C1A750")]
			public FIIBBBEODKJ(NHKAINPFJJL HOKJJIHKKNO, FLBPJIHLFIJ CPOPDPPEEBM, double HCMFNJGJPMC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x9C1A2F0", Offset = "0x9C18EF0", VA = "0x189C1A2F0")]
			public void DIJNCOKNOGC(double HCMFNJGJPMC)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		internal Transform HOKJJIHKKNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private SkinnedMeshRenderer HDHHGHHFCGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private bool ICMLEMGLLKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private bool OEBPFNHENMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private bool OEPJLEDOGJO;

		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private static List<FLBPJIHLFIJ> HCCFGLCIEHJ;

		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private static MaterialPropertyBlock PMNNKJEDBDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		internal List<FIIBBBEODKJ> NHDIOKADDLM;

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x9C260A0", Offset = "0x9C24CA0", VA = "0x189C260A0")]
		public NHKAINPFJJL(Transform HOKJJIHKKNO, double HCMFNJGJPMC, bool EDKPIOHLFDC = false, bool ICMLEMGLLKI = true, bool OEBPFNHENMD = false, bool OEPJLEDOGJO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x9C25EF0", Offset = "0x9C24AF0", VA = "0x189C25EF0")]
		public void MONBEGLCAAD(double HCMFNJGJPMC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	internal ICollection<Transform> KHPLFMCGFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private Transform OLIIIAEGOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private Dictionary<Transform, NHKAINPFJJL> CBCNBAPLLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private double BLMNNDJKEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private double OFLFOMFOALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private bool IJJOOIFCNDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	private bool MAGMPBNAEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private readonly bool ICMLEMGLLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	private readonly bool KCGKOEJALKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private readonly bool OEPJLEDOGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public string MHDMKLCBFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public MLKIJODKMEM ACEENDHJOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public ENKFAFEPDNH JEFBIADIIPP;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	private static ProfilerMarker MLKGDFJIPGK;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private static ProfilerMarker MOEABFMNGEJ;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private static ProfilerMarker NGIIBKDFCEL;

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	public bool JAJLLJAPGIL
	{
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x14B8540", Offset = "0x14B7140", VA = "0x1814B8540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	public double OLAFMEOONHD
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x7454610", Offset = "0x7453210", VA = "0x187454610")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x9C0BD30", Offset = "0x9C0A930", VA = "0x189C0BD30")]
	public GNNCEMBODDB(Transform OLIIIAEGOLD, bool ICMLEMGLLKI = true, bool KCGKOEJALKK = false, bool OEPJLEDOGJO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x9C0B340", Offset = "0x9C09F40", VA = "0x189C0B340")]
	private bool EMAOICEPABH(Transform HOKJJIHKKNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x9C0A560", Offset = "0x9C09160", VA = "0x189C0A560")]
	public void BOMBFDEAGGF(double HCMFNJGJPMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x9C0B960", Offset = "0x9C0A560", VA = "0x189C0B960")]
	public void NNJFPFLACNN(double HCMFNJGJPMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x9C0A7A0", Offset = "0x9C093A0", VA = "0x189C0A7A0")]
	public void DKKEMLAPKPC(string EANLPJPIAHA, string BEKFDLHNIFG = "scene", [Optional] GLTFSettings DKFCHCGNBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x9C0A920", Offset = "0x9C09520", VA = "0x189C0A920")]
	public void DKKEMLAPKPC(Stream NKIPIPEKKIL, string BEKFDLHNIFG = "scene", [Optional] GLTFSettings DKFCHCGNBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x9C0A350", Offset = "0x9C08F50", VA = "0x189C0A350")]
	private void AGNMKGJJAOB(DDIHIDBGEBH OOJHOOBDAMG, EEBBIHGHGOL LPFALNIFEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x9C0B400", Offset = "0x9C0A000", VA = "0x189C0B400")]
	private void JNJBFBGLELN(DDIHIDBGEBH CAGBNCGJGBC, LBBDFKNJCBO BEIDELPBDBK, bool KCHEGDKPAJP, [Out] Bounds DLMOCLGHCNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public class OAPGGHBJINJ : PlayableBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	private sealed class JGFKGIBGKJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public OAPGGHBJINJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public JGFKGIBGKJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x9C1F1E0", Offset = "0x9C1DDE0", VA = "0x189C1F1E0")]
		internal void PMOGCLJPKIM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400038A")]
	private GNNCEMBODDB NGBHBPNAPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public GLTFRecorderClip LIPPNFIDFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400038C")]
	private bool AJKGAHOKJDP;

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x9C27360", Offset = "0x9C25F60", VA = "0x189C27360")]
	private void NNIIJLDMJBP(double NHNCAILENMO, Transform OKOCPDLAHGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x9C26FA0", Offset = "0x9C25BA0", VA = "0x189C26FA0")]
	private void FOPHDFEAHLE(double NHNCAILENMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x9C27230", Offset = "0x9C25E30", VA = "0x189C27230")]
	private void MGGGBHGOODF(double NHNCAILENMO, Transform OKOCPDLAHGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810")]
	private static bool IOHCGBGCLEM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x9C27660", Offset = "0x9C26260", VA = "0x189C27660", Slot = "16")]
	public override void OnPlayableDestroy(Playable HCFOINGEKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x9C27430", Offset = "0x9C26030", VA = "0x189C27430", Slot = "13")]
	public override void OnGraphStart(Playable HCFOINGEKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x9C275C0", Offset = "0x9C261C0", VA = "0x189C275C0", Slot = "14")]
	public override void OnGraphStop(Playable HCFOINGEKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x9C27700", Offset = "0x9C26300", VA = "0x189C27700", Slot = "20")]
	public override void ProcessFrame(Playable HCFOINGEKAC, FrameData ACLFBNHJPDH, object NDPOHCANLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x249BA10", Offset = "0x249A610", VA = "0x18249BA10", Slot = "17")]
	public override void OnBehaviourPlay(Playable HCFOINGEKAC, FrameData ACLFBNHJPDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0xD18A30", Offset = "0xD17630", VA = "0x180D18A30", Slot = "18")]
	public override void OnBehaviourPause(Playable HCFOINGEKAC, FrameData ACLFBNHJPDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x9C27000", Offset = "0x9C25C00", VA = "0x189C27000")]
	public void LNBCJJAPNJL(double HCMFNJGJPMC, Playable HCFOINGEKAC, FrameData ACLFBNHJPDH, object NDPOHCANLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
	public OAPGGHBJINJ()
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
			[Cpp2IlInjected.Address(RVA = "0xD050B0", Offset = "0xD03CB0", VA = "0x180D050B0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(ClipCaps);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x9C1AD20", Offset = "0x9C19920", VA = "0x189C1AD20", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph EAMANPAHEGF, GameObject JAOGNEOIMGK)
		{
			return default(Playable);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x9C1AE30", Offset = "0x9C19A30", VA = "0x189C1AE30")]
		public Transform IMCCGBADFIE(PlayableGraph EAMANPAHEGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x9C1AE90", Offset = "0x9C19A90", VA = "0x189C1AE90")]
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
		private sealed class CFMLNBHKGBB : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
			[DebuggerHidden]
			public CFMLNBHKGBB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x9C18E40", Offset = "0x9C17A40", VA = "0x189C18E40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x9C19080", Offset = "0x9C17C80", VA = "0x189C19080", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private List<Action> CMMGMJEEGID;

		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private static GLTFRecorderHelper MIOFGENCPDE;

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x9C1AF20", Offset = "0x9C19B20", VA = "0x189C1AF20")]
		public static void Add(Action HFBNHPDLHHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x9C1B160", Offset = "0x9C19D60", VA = "0x189C1B160")]
		private static GLTFRecorderHelper GPFDGFBFOBL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x9C1B300", Offset = "0x9C19F00", VA = "0x189C1B300")]
		[IteratorStateMachine(typeof(CFMLNBHKGBB))]
		private IEnumerator JNFCIKAPPCJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x9C1B380", Offset = "0x9C19F80", VA = "0x189C1B380")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x9C1B400", Offset = "0x9C1A000", VA = "0x189C1B400")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C1B490", Offset = "0x9C1A090", VA = "0x189C1B490")]
		public GLTFRecorderTrack()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
internal static class KOEAHEPDPHF
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class NFJIFNBNNKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public int primaryComponentCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public MLPACKFJPHM propertyMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public AGFALBKGFIF pointerDataCopy;

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public NFJIFNBNNKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x9C25E60", Offset = "0x9C24A60", VA = "0x189C25E60")]
		internal float[] OMBEFHJMLAC(AGFALBKGFIF data, int frame)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x9C25CB0", Offset = "0x9C248B0", VA = "0x189C25CB0")]
		internal float[] BABDPGBKGJL(AGFALBKGFIF data, int frame)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x9C25D40", Offset = "0x9C24940", VA = "0x189C25D40")]
		internal float[] CDLPHOMBLFD(AGFALBKGFIF data, int frame)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x9C25DD0", Offset = "0x9C249D0", VA = "0x189C25DD0")]
		internal float[] FCJLALFKBCC(AGFALBKGFIF data, int frame)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	private static readonly string[] KCAHNDIDNNF;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	private static readonly string[] KPEMHFFCOPC;

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x9C1F9C0", Offset = "0x9C1E5C0", VA = "0x189C1F9C0")]
	internal static bool HDCAIAOHILD(string GECPPJNGLOM, AFAFOIMFAGE MIAMBKAOMHK, Material CIBNABIMGCK, string DMNLJGCKAHA, IFFIEJDGJCN MFECAFIFBLE, [Out] AGFALBKGFIF FHCODJEBIKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x9C1FF80", Offset = "0x9C1EB80", VA = "0x189C1FF80")]
	internal static string[] JFHENNDGJMI(string BABLEGNKCCH, int MGFODLOPHKP, int NDCBEOBPIHO = 0, bool DFCKNLLKPCG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x9C1F3D0", Offset = "0x9C1DFD0", VA = "0x189C1F3D0")]
	internal static float[] DHCPGAEBKHI(int LCCBBMBENOH, int MGFODLOPHKP, MLPACKFJPHM LDOBEDEHEFO, AGFALBKGFIF FHCODJEBIKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class MLPACKFJPHM
{
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public enum LHHHOJDKJPG
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
	public enum PMGDBKBNPCG
	{
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		SameAsPrimary,
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		Override
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public delegate float[] JKPHMDPLPCL(float[] IKMHACJGAMJ, float[] BLKMPCPALNC, int EANHPJICKOP);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public LHHHOJDKJPG ONIENPDOKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public string DNFEIPBNDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public string EAEGFLHLNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public bool IPEBCMLMAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public PMGDBKBNPCG FAGFPCCNCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public JNBIMEAPKHG JCNFLNNKNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public bool LAAHLBAMBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public bool GFEPFMINCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x36")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public bool MPFPKJDPBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public float MACPIDEEEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public string MDANLOBNJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public JKPHMDPLPCL PCJJEGMKBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private string[] PLGBABKDGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	internal int[] AMANDBOLNMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	internal int[] DLEDJCBHMOF;

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	public string[] IBJBIGKILEO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xA5B670", Offset = "0xA5A270", VA = "0x180A5B670")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x9C25610", Offset = "0x9C24210", VA = "0x189C25610")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	public bool HNBNPFCNBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x9C25830", Offset = "0x9C24430", VA = "0x189C25830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x9C25850", Offset = "0x9C24450", VA = "0x189C25850")]
	public MLPACKFJPHM(LHHHOJDKJPG IEPCGNNBPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x9C25470", Offset = "0x9C24070", VA = "0x189C25470")]
	private void ANFEHEMLFAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x9C25640", Offset = "0x9C24240", VA = "0x189C25640")]
	private static float[] EBEKBPLEKBK(float[] IKMHACJGAMJ, float[] BLKMPCPALNC, int EANHPJICKOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x9C25790", Offset = "0x9C24390", VA = "0x189C25790")]
	private void FBBBJFJHLAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class AFAFOIMFAGE
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public enum LNKCDKOHAMN
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
	private Dictionary<string, MLPACKFJPHM> JCEDFJHHCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	private Dictionary<string, MLPACKFJPHM> AAJPPCBEPPC;

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x9C17730", Offset = "0x9C16330", VA = "0x189C17730")]
	public void DMNFHMPGDFB(string ABDOEBLPFAM, string[] ABMIGEGALGA, [Optional] string PCDDHKMCDPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x9C17510", Offset = "0x9C16110", VA = "0x189C17510")]
	public void CEEDNFANBGK(MLPACKFJPHM LDOBEDEHEFO, LNKCDKOHAMN MNCFFIHIJHL = LNKCDKOHAMN.ImportAndExport)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x9C181D0", Offset = "0x9C16DD0", VA = "0x189C181D0")]
	public bool NPPAFDDFDAJ(Material GPMNIJPCANI, string MELLOJAOMPG, [Out] MLPACKFJPHM LDOBEDEHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x9C17E00", Offset = "0x9C16A00", VA = "0x189C17E00")]
	public bool NCKJBJGFDFG(Material GPMNIJPCANI, string JBLEMDBHCEA, [Out] string BABLEGNKCCH, [Out] MLPACKFJPHM LDOBEDEHEFO, [Out] bool ONCDOKADNHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x9C183F0", Offset = "0x9C16FF0", VA = "0x189C183F0")]
	public AFAFOIMFAGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public class LAEHJPKDIHL : AFAFOIMFAGE
{
	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x9C206D0", Offset = "0x9C1F2D0", VA = "0x189C206D0")]
	public LAEHJPKDIHL()
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
			[Cpp2IlInjected.Address(RVA = "0x9C18A80", Offset = "0x9C17680", VA = "0x189C18A80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000190")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0x9C18A50", Offset = "0x9C17650", VA = "0x189C18A50", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000191")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x9C189A0", Offset = "0x9C175A0", VA = "0x189C189A0", Slot = "14")]
		public override HAINKNBMHAH HCMACMJACJA(CCCKJDAIOAF PBHLPKLGFAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x1524780", Offset = "0x1523380", VA = "0x181524780")]
		public AnimationPointerExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public class OGGDMDEMKIH : HAINKNBMHAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public AFAFOIMFAGE EIECHNEMCEK;

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x9C27850", Offset = "0x9C26450", VA = "0x189C27850")]
	public OGGDMDEMKIH()
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
			[Cpp2IlInjected.Address(RVA = "0x9C18B90", Offset = "0x9C17790", VA = "0x189C18B90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000193")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x9C18B60", Offset = "0x9C17760", VA = "0x189C18B60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x9C18AB0", Offset = "0x9C176B0", VA = "0x189C18AB0", Slot = "13")]
		public override ICGIFJEBFLF HCMACMJACJA(CCACMMEEOIH PBHLPKLGFAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x1524780", Offset = "0x1523380", VA = "0x181524780")]
		public AnimationPointerImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class JAFIBBOODBL : ICGIFJEBFLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public AFAFOIMFAGE EIECHNEMCEK;

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x9C1F030", Offset = "0x9C1DC30", VA = "0x189C1F030")]
	public JAFIBBOODBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[AttributeUsage(AttributeTargets.Class)]
public class LLINJMKJHDE : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public string HHHKBKPIMNC;

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0xA87960", Offset = "0xA86560", VA = "0x180A87960")]
	public LLINJMKJHDE([Optional] string HHHKBKPIMNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[AttributeUsage(AttributeTargets.Class)]
public class MPDMAAHGFJO : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public string HHHKBKPIMNC;

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0xA87960", Offset = "0xA86560", VA = "0x180A87960")]
	public MPDMAAHGFJO([Optional] string HHHKBKPIMNC)
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
			[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(Slot = "14")]
		public abstract HAINKNBMHAH HCMACMJACJA(CCCKJDAIOAF PBHLPKLGFAP);

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x1524780", Offset = "0x1523380", VA = "0x181524780")]
		protected GLTFExportPlugin()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public abstract class HAINKNBMHAH
{
	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "4")]
	public virtual void BAODBFMAJHO(DDIHIDBGEBH OOJHOOBDAMG, EEBBIHGHGOL LPFALNIFEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
	public virtual void LEFJOHKPFPH(DDIHIDBGEBH OOJHOOBDAMG, EEBBIHGHGOL LPFALNIFEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810", Slot = "6")]
	public virtual bool HLBPFKDLCCN(DDIHIDBGEBH OOJHOOBDAMG, EEBBIHGHGOL LPFALNIFEHN, Transform LMGPODOPMIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "7")]
	public virtual void OFGEELJJIDB(DDIHIDBGEBH OOJHOOBDAMG, EEBBIHGHGOL LPFALNIFEHN, Transform LMGPODOPMIJ, GCJECACEHBN PBBEMEGKFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "8")]
	public virtual void MLOPPEFHAKP(DDIHIDBGEBH OOJHOOBDAMG, EEBBIHGHGOL LPFALNIFEHN, Transform LMGPODOPMIJ, GCJECACEHBN PBBEMEGKFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "9")]
	public virtual bool OAAPCPEPDAP(DDIHIDBGEBH OOJHOOBDAMG, EEBBIHGHGOL LPFALNIFEHN, Material CIBNABIMGCK, IBKALPNABJD FIAJENKIKEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "10")]
	public virtual void OCDIPALLGIC(DDIHIDBGEBH OOJHOOBDAMG, EEBBIHGHGOL LPFALNIFEHN, Material CIBNABIMGCK, IBKALPNABJD FIAJENKIKEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "11")]
	public virtual void LAFPBIBAEAN(DDIHIDBGEBH OOJHOOBDAMG, DDIHIDBGEBH.EFKNFANKFBH PMMGDHEEDKB, string OKCBMOOGHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "12")]
	public virtual void KAPEMAFAEKC(DDIHIDBGEBH OOJHOOBDAMG, DDIHIDBGEBH.EFKNFANKFBH PMMGDHEEDKB, int LCCBBMBENOH, BHPGBKFIKFO BAPGOEBIAGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "13")]
	public virtual void PIEKGLNNFFF(DDIHIDBGEBH OOJHOOBDAMG, Mesh MOGMOMKEFJC, CGAJCOIJKND LENPJBDMDOJ, int LCCBBMBENOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "14")]
	public virtual void ILKKGACOAFC(DDIHIDBGEBH OOJHOOBDAMG, Mesh MOGMOMKEFJC, BJCLAFDPBIO MKGHNILONOF, int LCCBBMBENOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	protected HAINKNBMHAH()
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
		public abstract ICGIFJEBFLF HCMACMJACJA(CCACMMEEOIH PBHLPKLGFAP);

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x1524780", Offset = "0x1523380", VA = "0x181524780")]
		protected GLTFImportPlugin()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public abstract class ICGIFJEBFLF
{
	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "4")]
	public virtual void GDLFPEOHAFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
	public virtual void MDFIPEHNJIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "6")]
	public virtual void GNBOPHLPJEC(EEBBIHGHGOL LPFALNIFEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "7")]
	public virtual void PAOMFACGEIG(DPPJKKPNPHL CMBCIMNOCEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "8")]
	public virtual void OBMANOPCBCO(GCJECACEHBN PBBEMEGKFPO, int DGOOJPINDFJ, GameObject BJPENCKFDJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "9")]
	public virtual void MENLJKPNMKI(IBKALPNABJD CIBNABIMGCK, int EFJMIKDMGKB, Material LGBBKBAMFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "10")]
	public virtual void ONDKFDMBMOI(BHPGBKFIKFO PMMGDHEEDKB, int KCNHJGOIBHH, Texture MLHHLCMFCHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "11")]
	public virtual void GNEGNJAKEPF(DPPJKKPNPHL CMBCIMNOCEH, int NIHHGEAIOGB, GameObject PFOGMIDIHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	protected ICGIFJEBFLF()
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
			[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000197")]
		public virtual string HelpUrl
		{
			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000198")]
		public virtual bool Enabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0x9C1AD00", Offset = "0x9C19900", VA = "0x189C1AD00", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0xA61310", Offset = "0xA5FF10", VA = "0x180A61310", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		public virtual bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		public virtual bool AlwaysEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		public virtual string Warning
		{
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		public virtual bool PackageMissing
		{
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x1524780", Offset = "0x1523380", VA = "0x181524780")]
		protected GLTFPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[Obsolete("Use UnityGLTF.Plugins.GLTFPlugin instead. (UnityUpgradable) -> UnityGLTF.Plugins.GLTFPlugin")]
	public abstract class GltfPlugin : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0xCCB4F0", Offset = "0xCCA0F0", VA = "0x180CCB4F0")]
		protected GltfPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[Obsolete("Use UnityGLTF.Plugins.GLTFImportPlugin instead. (UnityUpgradable) -> UnityGLTF.Plugins.GLTFImportPlugin")]
	public abstract class GltfImportPlugin : GltfPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xCCB4F0", Offset = "0xCCA0F0", VA = "0x180CCB4F0")]
		protected GltfImportPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[Obsolete("Use UnityGLTF.Plugins.GLTFExportPlugin instead. (UnityUpgradable) -> UnityGLTF.Plugins.GLTFExportPlugin")]
	public abstract class GltfExportPlugin : GltfPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0xCCB4F0", Offset = "0xCCA0F0", VA = "0x180CCB4F0")]
		protected GltfExportPlugin()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public class CCACMMEEOIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public readonly List<ICGIFJEBFLF> AGANGPKNGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public AOLODCHEPKL PMAALKEDKFL;

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	public EEBBIHGHGOL AMCBICJEEBO
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x9C18BC0", Offset = "0x9C177C0", VA = "0x189C18BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x9C18BE0", Offset = "0x9C177E0", VA = "0x189C18BE0")]
	private List<ICGIFJEBFLF> FMNAOCIMCPP(GLTFSettings DKFCHCGNBIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x9C18E00", Offset = "0x9C17A00", VA = "0x189C18E00")]
	internal CCACMMEEOIH(GLTFSettings DKFCHCGNBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x3A30DB0", Offset = "0x3A2F9B0", VA = "0x183A30DB0")]
	public bool BOAGEECJEHC<T>([Out] T FKPCPEEFHLN) where T : ICGIFJEBFLF
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
			[Cpp2IlInjected.Address(RVA = "0x9C1A0C0", Offset = "0x9C18CC0", VA = "0x189C1A0C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0x9C1A090", Offset = "0x9C18C90", VA = "0x189C1A090", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A0")]
		public override bool PackageMissing
		{
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x9C1A040", Offset = "0x9C18C40", VA = "0x189C1A040", Slot = "13")]
		public override ICGIFJEBFLF HCMACMJACJA(CCACMMEEOIH PBHLPKLGFAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x1524780", Offset = "0x1523380", VA = "0x181524780")]
		public DracoImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public class AMAIGDIIFLF : ICGIFJEBFLF
{
	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public AMAIGDIIFLF()
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
			[Cpp2IlInjected.Address(RVA = "0x9C1B560", Offset = "0x9C1A160", VA = "0x189C1B560", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A2")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(RVA = "0x9C1B530", Offset = "0x9C1A130", VA = "0x189C1B530", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x9C1B4E0", Offset = "0x9C1A0E0", VA = "0x189C1B4E0", Slot = "13")]
		public override ICGIFJEBFLF HCMACMJACJA(CCACMMEEOIH PBHLPKLGFAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x1524780", Offset = "0x1523380", VA = "0x181524780")]
		public GPUInstancingImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public class CMGJAALBFJB : ICGIFJEBFLF
{
	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public CMGJAALBFJB()
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
			[Cpp2IlInjected.Address(RVA = "0x9C206A0", Offset = "0x9C1F2A0", VA = "0x189C206A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A4")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0x9C20670", Offset = "0x9C1F270", VA = "0x189C20670", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A5")]
		public override bool PackageMissing
		{
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x9C20620", Offset = "0x9C1F220", VA = "0x189C20620", Slot = "13")]
		public override ICGIFJEBFLF HCMACMJACJA(CCACMMEEOIH PBHLPKLGFAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x1524780", Offset = "0x1523380", VA = "0x181524780")]
		public Ktx2Import()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public class PKKJEGHMAPD : ICGIFJEBFLF
{
	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public PKKJEGHMAPD()
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
			[Cpp2IlInjected.Address(RVA = "0x9C25230", Offset = "0x9C23E30", VA = "0x189C25230", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A7")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x9C25200", Offset = "0x9C23E00", VA = "0x189C25200", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x9C251B0", Offset = "0x9C23DB0", VA = "0x189C251B0", Slot = "14")]
		public override HAINKNBMHAH HCMACMJACJA(CCCKJDAIOAF PBHLPKLGFAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x1524780", Offset = "0x1523380", VA = "0x181524780")]
		public LightsPunctualExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public class FAFDLBPMMMH : HAINKNBMHAH
{
	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "8")]
	public override void MLOPPEFHAKP(DDIHIDBGEBH OOJHOOBDAMG, EEBBIHGHGOL LPFALNIFEHN, Transform LMGPODOPMIJ, GCJECACEHBN PBBEMEGKFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public FAFDLBPMMMH()
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
			[Cpp2IlInjected.Address(RVA = "0x9C252E0", Offset = "0x9C23EE0", VA = "0x189C252E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A9")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x9C252B0", Offset = "0x9C23EB0", VA = "0x189C252B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x9C25260", Offset = "0x9C23E60", VA = "0x189C25260", Slot = "13")]
		public override ICGIFJEBFLF HCMACMJACJA(CCACMMEEOIH PBHLPKLGFAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x1524780", Offset = "0x1523380", VA = "0x181524780")]
		public LightsPunctualImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public class GOCMBCMNEIL : ICGIFJEBFLF
{
	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public GOCMBCMNEIL()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[LLINJMKJHDE(null)]
	public class LodsExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0x9C25390", Offset = "0x9C23F90", VA = "0x189C25390", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0x9C25360", Offset = "0x9C23F60", VA = "0x189C25360", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x9C25310", Offset = "0x9C23F10", VA = "0x189C25310", Slot = "14")]
		public override HAINKNBMHAH HCMACMJACJA(CCCKJDAIOAF PBHLPKLGFAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x1524780", Offset = "0x1523380", VA = "0x181524780")]
		public LodsExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public class GAFJIAJBJPP : HAINKNBMHAH
{
	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x9C1A890", Offset = "0x9C19490", VA = "0x189C1A890", Slot = "8")]
	public override void MLOPPEFHAKP(DDIHIDBGEBH OOJHOOBDAMG, EEBBIHGHGOL NOENPNBGFHN, Transform LMGPODOPMIJ, GCJECACEHBN PBBEMEGKFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public GAFJIAJBJPP()
	{
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[LLINJMKJHDE(null)]
	public class LodsImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000460")]
			[Cpp2IlInjected.Address(RVA = "0x9C25440", Offset = "0x9C24040", VA = "0x189C25440", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0x9C25410", Offset = "0x9C24010", VA = "0x189C25410", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x9C253C0", Offset = "0x9C23FC0", VA = "0x189C253C0", Slot = "13")]
		public override ICGIFJEBFLF HCMACMJACJA(CCACMMEEOIH PBHLPKLGFAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x1524780", Offset = "0x1523380", VA = "0x181524780")]
		public LodsImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public class GDCFJAKCOGD : ICGIFJEBFLF
{
	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public GDCFJAKCOGD()
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
			[Cpp2IlInjected.Address(RVA = "0x9C25AE0", Offset = "0x9C246E0", VA = "0x189C25AE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0x9C25AB0", Offset = "0x9C246B0", VA = "0x189C25AB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x9C25A20", Offset = "0x9C24620", VA = "0x189C25A20", Slot = "14")]
		public override HAINKNBMHAH HCMACMJACJA(CCCKJDAIOAF PBHLPKLGFAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x9C25A90", Offset = "0x9C24690", VA = "0x189C25A90")]
		public MaterialExtensionsExport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public class INCCIGMEEHB : HAINKNBMHAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	internal readonly MaterialExtensionsExport DKFCHCGNBIM;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private static readonly int MCOGJMDCJFD;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private static readonly int NCCHHNCHDGP;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private static readonly int IEDDKBEEJPE;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	private static readonly int GEJGCHHPJAC;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	private static readonly int FKMCJPBKPJO;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	private static readonly int AIOPPHOHOLM;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	private static readonly int GIGLDIDCGHM;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	private static readonly int LMOGMOKFIMO;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	private static readonly int JLGOOOGNCHD;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	private static readonly int PABOAPHGLNG;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	private static readonly int LABBCIEGKMA;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	private static readonly int MINBPKALIBP;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	private static readonly int CCMDDEIDBHI;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	private static readonly int FNADFJJLPCM;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	private static readonly int HNIDGMDPAKA;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	private static readonly int NDKBOEEKJGE;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	private static readonly int AFEHPLMPDPG;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	private static readonly int PDGDOCGCLKB;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	private static readonly int PPLNGHMBHCM;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	private static readonly int NEFPAIMHPEG;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	private static readonly int KFMHHJIFMME;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	private static readonly int FJBNFOEHEPL;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	private static readonly int LJELINHLLBJ;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	private static readonly int FNPFAMPCKJN;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	private static readonly int KDIFAAOOBDG;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	private static readonly int BFACDJDJDBP;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	private static readonly int EGADPCADNHO;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	private static readonly int EINJJNKDDOB;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	private static readonly int BLMKJPKGEEA;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	private static readonly int FBCCINEDFDF;

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0xA628A0", Offset = "0xA614A0", VA = "0x180A628A0")]
	public INCCIGMEEHB(MaterialExtensionsExport DKFCHCGNBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x9C1C520", Offset = "0x9C1B120", VA = "0x189C1C520", Slot = "10")]
	public override void OCDIPALLGIC(DDIHIDBGEBH OOJHOOBDAMG, EEBBIHGHGOL NOENPNBGFHN, Material CIBNABIMGCK, IBKALPNABJD CJHNLLPOGAB)
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
			[Cpp2IlInjected.Address(RVA = "0x9C25BD0", Offset = "0x9C247D0", VA = "0x189C25BD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0x9C25BA0", Offset = "0x9C247A0", VA = "0x189C25BA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x9C25B10", Offset = "0x9C24710", VA = "0x189C25B10", Slot = "13")]
		public override ICGIFJEBFLF HCMACMJACJA(CCACMMEEOIH PBHLPKLGFAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x9C25B80", Offset = "0x9C24780", VA = "0x189C25B80")]
		public MaterialExtensionsImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class GPHPOAFGFJN : ICGIFJEBFLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	internal readonly MaterialExtensionsImport DKFCHCGNBIM;

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0xA628A0", Offset = "0xA614A0", VA = "0x180A628A0")]
	public GPHPOAFGFJN(MaterialExtensionsImport GOHCEEEFEOG)
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
			[Cpp2IlInjected.Address(RVA = "0x9C25C80", Offset = "0x9C24880", VA = "0x189C25C80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0x9C25C50", Offset = "0x9C24850", VA = "0x189C25C50", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		public override bool PackageMissing
		{
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x9C25C00", Offset = "0x9C24800", VA = "0x189C25C00", Slot = "13")]
		public override ICGIFJEBFLF HCMACMJACJA(CCACMMEEOIH PBHLPKLGFAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x1524780", Offset = "0x1523380", VA = "0x181524780")]
		public MeshoptImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public class FCBJALMMEND : ICGIFJEBFLF
{
	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public FCBJALMMEND()
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
			[Cpp2IlInjected.Address(RVA = "0x9C27A30", Offset = "0x9C26630", VA = "0x189C27A30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0x9C27A00", Offset = "0x9C26600", VA = "0x189C27A00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		public override bool AlwaysEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000479")]
			[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "14")]
		public override HAINKNBMHAH HCMACMJACJA(CCCKJDAIOAF PBHLPKLGFAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x1524780", Offset = "0x1523380", VA = "0x181524780")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C27A90", Offset = "0x9C26690", VA = "0x189C27A90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B9")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600047D")]
			[Cpp2IlInjected.Address(RVA = "0x9C27A60", Offset = "0x9C26660", VA = "0x189C27A60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		public override bool AlwaysEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x600047E")]
			[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "13")]
		public override ICGIFJEBFLF HCMACMJACJA(CCACMMEEOIH PBHLPKLGFAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x1524780", Offset = "0x1523380", VA = "0x181524780")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C289F0", Offset = "0x9C275F0", VA = "0x189C289F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000482")]
			[Cpp2IlInjected.Address(RVA = "0x9C289C0", Offset = "0x9C275C0", VA = "0x189C289C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		public override bool AlwaysEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000483")]
			[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "14")]
		public override HAINKNBMHAH HCMACMJACJA(CCCKJDAIOAF PBHLPKLGFAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x1524780", Offset = "0x1523380", VA = "0x181524780")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C28A50", Offset = "0x9C27650", VA = "0x189C28A50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000487")]
			[Cpp2IlInjected.Address(RVA = "0x9C28A20", Offset = "0x9C27620", VA = "0x189C28A20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		public override bool AlwaysEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "13")]
		public override ICGIFJEBFLF HCMACMJACJA(CCACMMEEOIH PBHLPKLGFAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x1524780", Offset = "0x1523380", VA = "0x181524780")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C28AB0", Offset = "0x9C276B0", VA = "0x189C28AB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C2")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600048C")]
			[Cpp2IlInjected.Address(RVA = "0x9C28A80", Offset = "0x9C27680", VA = "0x189C28A80", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C3")]
		public override bool AlwaysEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		public override bool EnabledByDefault
		{
			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "14")]
		public override HAINKNBMHAH HCMACMJACJA(CCCKJDAIOAF PBHLPKLGFAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x1524780", Offset = "0x1523380", VA = "0x181524780")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C28B10", Offset = "0x9C27710", VA = "0x189C28B10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		public override string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000492")]
			[Cpp2IlInjected.Address(RVA = "0x9C28AE0", Offset = "0x9C276E0", VA = "0x189C28AE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		public override bool AlwaysEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000493")]
			[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "13")]
		public override ICGIFJEBFLF HCMACMJACJA(CCACMMEEOIH PBHLPKLGFAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x1524780", Offset = "0x1523380", VA = "0x181524780")]
		public VisibilityImport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public class AMBKLJIBLAK
{
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	internal class NOHEFEHAAGI : MemoryStream
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public readonly string OJIKEMLFEPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public readonly string MMGPEBBBGLK;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public interface GOABIIABKHB
{
	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<Stream> BMGIFBIFOHM(string NNOLBOLFDOB);
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public interface PJDCDDJOLPM : GOABIIABKHB
{
	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Stream NCFGKCHKLDM(string NNOLBOLFDOB);
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[Obsolete("Please switch to IDataLoader.  This interface is deprecated and will be removed in a future release.")]
public interface KLFFACBIPLK
{
	[Cpp2IlInjected.Token(Token = "0x170001C8")]
	Stream DJCOKCHIBCK
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	bool ELBFPLBGMHC
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NCFGKCHKLDM(string NNOLBOLFDOB);

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PMKKFNADGMI(string ACJJLLMFKNB);
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public static class EKBPFEIMNMA
{
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	private class DBOJMDNGBKO : GOABIIABKHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		protected readonly KLFFACBIPLK BAGMNINILCD;

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0xA628A0", Offset = "0xA614A0", VA = "0x180A628A0")]
		public DBOJMDNGBKO(KLFFACBIPLK EHDCHAMGMFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x9C19200", Offset = "0x9C17E00", VA = "0x189C19200", Slot = "4")]
		public Task<Stream> BMGIFBIFOHM(string NNOLBOLFDOB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	private class ELCPKIDHGNP : DBOJMDNGBKO, PJDCDDJOLPM, GOABIIABKHB
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0xA628A0", Offset = "0xA614A0", VA = "0x180A628A0")]
		public ELCPKIDHGNP(KLFFACBIPLK EHDCHAMGMFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x9C1A210", Offset = "0x9C18E10", VA = "0x189C1A210", Slot = "5")]
		public Stream NCFGKCHKLDM(string NNOLBOLFDOB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x9C1A0F0", Offset = "0x9C18CF0", VA = "0x189C1A0F0")]
	public static GOABIIABKHB IJBKNEDKCNG(KLFFACBIPLK EHDCHAMGMFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public class PCPHBNINMFC : GOABIIABKHB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private struct HHJLLODDHPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public AsyncTaskMethodBuilder<Stream> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public PCPHBNINMFC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x9C1B630", Offset = "0x9C1A230", VA = "0x189C1B630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x9C1BD60", Offset = "0x9C1A960", VA = "0x189C1BD60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	private string HKIBLDIPHCL;

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0xA628A0", Offset = "0xA614A0", VA = "0x180A628A0")]
	public PCPHBNINMFC(string HKIBLDIPHCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x9C278D0", Offset = "0x9C264D0", VA = "0x189C278D0", Slot = "4")]
	[AsyncStateMachine(typeof(HHJLLODDHPK))]
	public Task<Stream> BMGIFBIFOHM(string NNOLBOLFDOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public class DOIFAMAIJDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	private readonly List<AJPEDAMLJMO> GFKOFHDBJMF;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	private static readonly ProfilerMarker KNKGCHHDHPJ;

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x9C19320", Offset = "0x9C17F20", VA = "0x189C19320")]
	public void NDGLNAHKHEG(AJPEDAMLJMO BEIDELPBDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x9C193D0", Offset = "0x9C17FD0", VA = "0x189C193D0")]
	public void PDFLBKDEBLO(DDIHIDBGEBH OOJHOOBDAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x9C19FB0", Offset = "0x9C18BB0", VA = "0x189C19FB0")]
	public DOIFAMAIJDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public interface KCGOCDFKCOL
{
	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PLNGILFAMDD(object ADGCHNLKFKK, string OKJOHKDNPGK);
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public struct DCILNNFLNEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public IFFIEJDGJCN CGLDONJEHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public IFFIEJDGJCN OLOPPMEIEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public KAJCEOHBMDH AFKBNGLHHAJ;
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public class GDKODCHHPPH
{
	[Cpp2IlInjected.Token(Token = "0x170001CA")]
	public AnimationClip LLHOIDMHLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0xA5B460", Offset = "0xA5A060", VA = "0x180A5B460")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CB")]
	public DCILNNFLNEG[] PNLOGMDDIMI
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0xA5B740", Offset = "0xA5A340", VA = "0x180A5B740")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x9C1ACA0", Offset = "0x9C198A0", VA = "0x189C1ACA0")]
	public GDKODCHHPPH(int EOFMONECLBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public class APIFPDKINHA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001CC")]
	public Stream[] ANJDBGKKHPG
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0xA5B460", Offset = "0xA5A060", VA = "0x180A5B460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CD")]
	public Texture2D[] OHBIPOGCCPF
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0xA5B740", Offset = "0xA5A340", VA = "0x180A5B740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CE")]
	public Texture2D[] IOAABMBMPEE
	{
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0xA5C790", Offset = "0xA5B390", VA = "0x180A5C790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7A0", Offset = "0xA5B3A0", VA = "0x180A5C7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CF")]
	public HGNCIFNBJIL[] JCLHBAFEOCI
	{
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5E0", Offset = "0xA5A1E0", VA = "0x180A5B5E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0xA683D0", Offset = "0xA66FD0", VA = "0x180A683D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D0")]
	public AOBBJBJKEJK[] KOBILMOFPKL
	{
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5A0", Offset = "0xA5A1A0", VA = "0x180A5B5A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0xA5FCB0", Offset = "0xA5E8B0", VA = "0x180A5FCB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D1")]
	public IPACCMMHAIP[] LPOIBLAAPBO
	{
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0xA5B560", Offset = "0xA5A160", VA = "0x180A5B560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5D0", Offset = "0xA5A1D0", VA = "0x180A5B5D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D2")]
	public CFOGGKEJONC[] GGCBIJFHAJB
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0xA5B600", Offset = "0xA5A200", VA = "0x180A5B600")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0xA5B430", Offset = "0xA5A030", VA = "0x180A5B430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D3")]
	public FOKIBNIMBHB[] AGODBFENPNI
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0xA5B690", Offset = "0xA5A290", VA = "0x180A5B690")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0xA5B550", Offset = "0xA5A150", VA = "0x180A5B550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D4")]
	public GDKODCHHPPH[] FIDGIFBONCN
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0xA5B670", Offset = "0xA5A270", VA = "0x180A5B670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0xA5B580", Offset = "0xA5A180", VA = "0x180A5B580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D5")]
	public GameObject[] DDCACJBEDIO
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0xA5B530", Offset = "0xA5A130", VA = "0x180A5B530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0xA5B780", Offset = "0xA5A380", VA = "0x180A5B780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x9C186C0", Offset = "0x9C172C0", VA = "0x189C186C0")]
	public APIFPDKINHA(EEBBIHGHGOL OLIIIAEGOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x9C185B0", Offset = "0x9C171B0", VA = "0x189C185B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public class IPACCMMHAIP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001D6")]
	public uint NAELLOLIBIN
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xA5B110", Offset = "0xA59D10", VA = "0x180A5B110")]
		[CompilerGenerated]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7B0", Offset = "0xA5B3B0", VA = "0x180A5C7B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D7")]
	public Stream MFJHHDIDMBP
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0xA5B740", Offset = "0xA5A340", VA = "0x180A5B740")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D8")]
	public NativeArray<byte> HPBOLKEANIH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0xE4A620", Offset = "0xE49220", VA = "0x180E4A620")]
		[CompilerGenerated]
		get
		{
			return default(NativeArray<byte>);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0xF40730", Offset = "0xF3F330", VA = "0x180F40730")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x6FBF630", Offset = "0x6FBE230", VA = "0x186FBF630", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public IPACCMMHAIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
internal static class ACFALCMMGFC
{
	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0xF1AEE0", Offset = "0xF19AE0", VA = "0x180F1AEE0")]
	public static bool INGLBOIJPDM(UnityEngine.Object DBMJCCGHNMG, string DLFHFKNPPFE, [Out] byte[] LNEJCNPADCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020")]
	public static void BEDMFEPBLAE(UnityEngine.Object DBMJCCGHNMG, string DLFHFKNPPFE, byte[] LNEJCNPADCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public class AOBBJBJKEJK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001D9")]
	public Material MABNDDHFKPB
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0xA5B460", Offset = "0xA5A060", VA = "0x180A5B460")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DA")]
	public Material GPCPLGKMAAH
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0xA5B740", Offset = "0xA5A340", VA = "0x180A5B740")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DB")]
	public IBKALPNABJD AMOAKIFGBLK
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7A0", Offset = "0xA5B3A0", VA = "0x180A5C7A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x9C184B0", Offset = "0x9C170B0", VA = "0x189C184B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public AOBBJBJKEJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public class CFOGGKEJONC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public class JCHKKGCAFAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public bool AHHAGAMFDJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public Dictionary<string, IFFIEJDGJCN> KKBKBHCAFAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public List<Dictionary<string, IFFIEJDGJCN>> FEJDCONKNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public Dictionary<string, (IFFIEJDGJCN sparseIndices, IFFIEJDGJCN sparseValues)> HAMDDCFPEKD;

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x9C1F0B0", Offset = "0x9C1DCB0", VA = "0x189C1F0B0")]
		public JCHKKGCAFAJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public List<JCHKKGCAFAJ> FKFOKEPHADC;

	[Cpp2IlInjected.Token(Token = "0x170001DC")]
	public Mesh MDIEBFAOOHI
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0xA5B740", Offset = "0xA5A340", VA = "0x180A5B740")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x9C190D0", Offset = "0x9C17CD0", VA = "0x189C190D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x9C19170", Offset = "0x9C17D70", VA = "0x189C19170")]
	public CFOGGKEJONC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public class IIFGDJLFJLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000427")]
	private bool MODEJDFHKGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000428")]
	private int HBADAGCJFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000429")]
	private readonly object OGPOAPACLHI;

	[Cpp2IlInjected.Token(Token = "0x170001DD")]
	public CFOGGKEJONC[] GGCBIJFHAJB
	{
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0xA5C790", Offset = "0xA5B390", VA = "0x180A5C790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7A0", Offset = "0xA5B3A0", VA = "0x180A5C7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DE")]
	public UnityEngine.Object[] KBHLLNOBPDL
	{
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5E0", Offset = "0xA5A1E0", VA = "0x180A5B5E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0xA683D0", Offset = "0xA66FD0", VA = "0x180A683D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DF")]
	public AOBBJBJKEJK[] KOBILMOFPKL
	{
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5A0", Offset = "0xA5A1A0", VA = "0x180A5B5A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0xA5FCB0", Offset = "0xA5E8B0", VA = "0x180A5FCB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E0")]
	public HGNCIFNBJIL[] JCLHBAFEOCI
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0xA5B560", Offset = "0xA5A160", VA = "0x180A5B560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5D0", Offset = "0xA5A1D0", VA = "0x180A5B5D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E1")]
	public GDKODCHHPPH[] FIDGIFBONCN
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0xA5B600", Offset = "0xA5A200", VA = "0x180A5B600")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0xA5B430", Offset = "0xA5A030", VA = "0x180A5B430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E2")]
	public Texture2D[] OHBIPOGCCPF
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0xA5B690", Offset = "0xA5A290", VA = "0x180A5B690")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0xA5B550", Offset = "0xA5A150", VA = "0x180A5B550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x9C1C410", Offset = "0x9C1B010", VA = "0x189C1C410")]
	public IIFGDJLFJLH(AOBBJBJKEJK[] IFNJJACHFAI, CFOGGKEJONC[] FAICBGKGLKF, HGNCIFNBJIL[] FBKIGAPCKKL, Texture2D[] DOLDKEJCDME, GDKODCHHPPH[] OJONNDBKALC, UnityEngine.Object[] APIGAPGFKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x9C1BDD0", Offset = "0x9C1A9D0", VA = "0x189C1BDD0")]
	public void DJOOAFPIDEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x9C1BEC0", Offset = "0x9C1AAC0", VA = "0x189C1BEC0")]
	public void HHEPJLICKJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x9C1C020", Offset = "0x9C1AC20", VA = "0x189C1C020")]
	private void JEIPHCNHMKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public class HGNCIFNBJIL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public BHPGBKFIKFO IDBFBPEPPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public Texture2D DPGDMBNBPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public bool CDIGNGDAKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public bool PMHBJIIIECP;

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x9C1B590", Offset = "0x9C1A190", VA = "0x189C1B590", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public HGNCIFNBJIL()
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
