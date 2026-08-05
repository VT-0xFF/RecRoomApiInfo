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
		private sealed class XDAJSRJZAGS : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private object MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public AsyncCoroutineHelper CDTALOACOKM;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			private object ENGTUJRFGYV
			{
				[Cpp2IlInjected.Token(Token = "0x6000008")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAA9B40", Offset = "0xAA8140", VA = "0x180AA9B40")]
			[DebuggerHidden]
			public XDAJSRJZAGS(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA233C40", Offset = "0xA232240", VA = "0x18A233C40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA233CC0", Offset = "0xA2322C0", VA = "0x18A233CC0", Slot = "8")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
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
			[Cpp2IlInjected.Address(RVA = "0xA232D30", Offset = "0xA231330", VA = "0x18A232D30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA232F20", Offset = "0xA231520", VA = "0x18A232F20", Slot = "5")]
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
		private WaitForEndOfFrame PHUVAIBUERU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private float QTVQEBAVYVO;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA21E700", Offset = "0xA21CD00", VA = "0x18A21E700")]
		[AsyncStateMachine(typeof(<YieldOnTimeout>d__3))]
		public Task YieldOnTimeout()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA21E670", Offset = "0xA21CC70", VA = "0x18A21E670")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA21E600", Offset = "0xA21CC00", VA = "0x18A21E600")]
		[IteratorStateMachine(typeof(XDAJSRJZAGS))]
		private IEnumerator PWTTCKSQCLR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA21E7D0", Offset = "0xA21CDD0", VA = "0x18A21E7D0")]
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
			private WPKHZAXWWKZ <importOptions>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private GLTFSceneImporter <sceneImporter>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA22DE00", Offset = "0xA22C400", VA = "0x18A22DE00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xA22EAF0", Offset = "0xA22D0F0", VA = "0x18A22EAF0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA22EB50", Offset = "0xA22D150", VA = "0x18A22EB50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
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
		private int NVXBFCQNOEC;

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
		public IEnumerable<Animation> TLMOTSISARF
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEE0", Offset = "0xAAE4E0", VA = "0x180AAFEE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xAB0770", Offset = "0xAAED70", VA = "0x180AB0770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public GameObject JCHPFMCSTBN
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAACA50", Offset = "0xAAB050", VA = "0x180AACA50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAACD30", Offset = "0xAAB330", VA = "0x180AACD30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Shader PCBQBAMAYEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xAACA90", Offset = "0xAAB090", VA = "0x180AACA90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xA21EDD0", Offset = "0xA21D3D0", VA = "0x18A21EDD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA21ECB0", Offset = "0xA21D2B0", VA = "0x18A21ECB0")]
		[AsyncStateMachine(typeof(<Start>d__33))]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA21EBE0", Offset = "0xA21D1E0", VA = "0x18A21EBE0")]
		[AsyncStateMachine(typeof(<Load>d__34))]
		public Task Load()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA21EAF0", Offset = "0xA21D0F0", VA = "0x18A21EAF0")]
		public void ApplyOverrideShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x10F9300", Offset = "0x10F7900", VA = "0x1810F9300")]
		private void UNOEGOXIWTT(GameObject a, ExceptionDispatchInfo b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA21ED60", Offset = "0xA21D360", VA = "0x18A21ED60")]
		public GLTFComponent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class GLTFRecorderComponent : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class JEKNXXCKCOJ : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private object MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public GLTFRecorderComponent CDTALOACOKM;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object ENGTUJRFGYV
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xAA9B40", Offset = "0xAA8140", VA = "0x180AA9B40")]
			[DebuggerHidden]
			public JEKNXXCKCOJ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xA22CE20", Offset = "0xA22B420", VA = "0x18A22CE20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xA22CEE0", Offset = "0xA22B4E0", VA = "0x18A22CEE0", Slot = "8")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
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
		protected NCPEFBXMBJR RWRPJINMKKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public UnityEvent recordingStarted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public UnityEvent<string> recordingEnded;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool HCYFJDIQQFZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xA21F5E0", Offset = "0xA21DBE0", VA = "0x18A21F5E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private double AYAYGTDBDSU
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xA21EF60", Offset = "0xA21D560", VA = "0x18A21EF60")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA21F0A0", Offset = "0xA21D6A0", VA = "0x18A21F0A0", Slot = "4")]
		[ContextMenu("Start Recording")]
		public virtual void StartRecording()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA21F420", Offset = "0xA21DA20", VA = "0x18A21F420", Slot = "5")]
		[ContextMenu("Stop Recording")]
		public virtual void StopRecording()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA21EE00", Offset = "0xA21D400", VA = "0x18A21EE00")]
		private void AQFCBZEAWNV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA21F390", Offset = "0xA21D990", VA = "0x18A21F390")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA21F010", Offset = "0xA21D610", VA = "0x18A21F010")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA21EFC0", Offset = "0xA21D5C0", VA = "0x18A21EFC0", Slot = "6")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA21EF70", Offset = "0xA21D570", VA = "0x18A21EF70", Slot = "7")]
		protected virtual void FXKDQHPLPZC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA21F030", Offset = "0xA21D630", VA = "0x18A21F030")]
		[IteratorStateMachine(typeof(JEKNXXCKCOJ))]
		private IEnumerator SYVCCWUJXMT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA21F520", Offset = "0xA21DB20", VA = "0x18A21F520")]
		public GLTFRecorderComponent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA21EE00", Offset = "0xA21D400", VA = "0x18A21EE00")]
		[CompilerGenerated]
		private void ULMLBGEQZRA(InputAction.CallbackContext a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class PPPKVVWBNXH
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		internal class GTHAMJEZHDJ : NIJBGKZVPPN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private readonly PPPKVVWBNXH OCKYWFPRVBE;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAD0950", Offset = "0xACEF50", VA = "0x180AD0950")]
			internal GTHAMJEZHDJ(PPPKVVWBNXH a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA22C6A0", Offset = "0xA22ACA0", VA = "0x18A22C6A0", Slot = "4")]
			public override void SDOFLZDWLET(GLTFSceneExporter a, YBVGUQCSKJP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xA22C720", Offset = "0xA22AD20", VA = "0x18A22C720", Slot = "5")]
			public override void XUHGDBIMMOE(GLTFSceneExporter a, YBVGUQCSKJP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA22C660", Offset = "0xA22AC60", VA = "0x18A22C660", Slot = "8")]
			public override void OJAHNLKAQFS(GLTFSceneExporter a, YBVGUQCSKJP b, Transform c, QPBKESVYPXS d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xA22C4A0", Offset = "0xA22AAA0", VA = "0x18A22C4A0", Slot = "9")]
			public override bool HFBSGFYGMUA(GLTFSceneExporter a, YBVGUQCSKJP b, Material c, SWTHYRWJKEM d)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA22C6E0", Offset = "0xA22ACE0", VA = "0x18A22C6E0", Slot = "10")]
			public override void UETUAYSCOPH(GLTFSceneExporter a, YBVGUQCSKJP b, Material c, SWTHYRWJKEM d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA22C460", Offset = "0xA22AA60", VA = "0x18A22C460", Slot = "11")]
			public override void AVKCGIAJUMQ(GLTFSceneExporter a, GLTFSceneExporter.UniqueTexture b, string c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xA22C5F0", Offset = "0xA22ABF0", VA = "0x18A22C5F0", Slot = "12")]
			public override void NIFFWLOXAVZ(GLTFSceneExporter a, GLTFSceneExporter.UniqueTexture b, int c, RAXRAOUEMWM d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xA22C5B0", Offset = "0xA22ABB0", VA = "0x18A22C5B0", Slot = "13")]
			public override void IVKWQIWEOKB(GLTFSceneExporter a, Mesh b, TOEZEOEVPIK c, int d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA22C760", Offset = "0xA22AD60", VA = "0x18A22C760", Slot = "14")]
			public override void ZPTLCEYDNIV(GLTFSceneExporter a, Mesh b, BFGGSXOTTTO c, int d)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public bool DBNHCGHGMST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public LayerMask WQPFDKCMFIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public ILogger EJCYMILAWTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		internal readonly GLTFSettings QVFBSGRPICZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public GLTFSceneExporter.RetrieveTexturePathDelegate NIYPWMKGULI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public GLTFSceneExporter.AfterSceneExportDelegate XUHGDBIMMOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public GLTFSceneExporter.BeforeSceneExportDelegate SDOFLZDWLET;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public GLTFSceneExporter.AfterNodeExportDelegate OJAHNLKAQFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public GLTFSceneExporter.BeforeMaterialExportDelegate HFBSGFYGMUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public GLTFSceneExporter.AfterMaterialExportDelegate UETUAYSCOPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public GLTFSceneExporter.BeforeTextureExportDelegate AVKCGIAJUMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public GLTFSceneExporter.AfterTextureExportDelegate NIFFWLOXAVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public GLTFSceneExporter.AfterPrimitiveExportDelegate IVKWQIWEOKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public GLTFSceneExporter.AfterMeshExportDelegate ZPTLCEYDNIV;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA22D540", Offset = "0xA22BB40", VA = "0x18A22D540")]
		public PPPKVVWBNXH(GLTFSettings a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA22D4E0", Offset = "0xA22BAE0", VA = "0x18A22D4E0")]
		internal NIJBGKZVPPN RYXRJDPNIWD()
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
		public delegate void BeforeSceneExportDelegate(GLTFSceneExporter exporter, YBVGUQCSKJP gltfRoot);

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public delegate void AfterSceneExportDelegate(GLTFSceneExporter exporter, YBVGUQCSKJP gltfRoot);

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void AfterNodeExportDelegate(GLTFSceneExporter exporter, YBVGUQCSKJP gltfRoot, Transform transform, QPBKESVYPXS node);

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate bool BeforeMaterialExportDelegate(GLTFSceneExporter exporter, YBVGUQCSKJP gltfRoot, Material material, SWTHYRWJKEM materialNode);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void AfterMaterialExportDelegate(GLTFSceneExporter exporter, YBVGUQCSKJP gltfRoot, Material material, SWTHYRWJKEM materialNode);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void BeforeTextureExportDelegate(GLTFSceneExporter exporter, UniqueTexture texture, string textureSlot);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public delegate void AfterTextureExportDelegate(GLTFSceneExporter exporter, UniqueTexture texture, int index, RAXRAOUEMWM tex);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public delegate void AfterPrimitiveExportDelegate(GLTFSceneExporter exporter, Mesh mesh, TOEZEOEVPIK primitive, int index);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public delegate void AfterMeshExportDelegate(GLTFSceneExporter exporter, Mesh mesh, BFGGSXOTTTO gltfMesh, int index);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class AHJPGXIAVNI : NIJBGKZVPPN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xA21E400", Offset = "0xA21CA00", VA = "0x18A21E400", Slot = "5")]
			public override void XUHGDBIMMOE(GLTFSceneExporter a, YBVGUQCSKJP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xA21E2E0", Offset = "0xA21C8E0", VA = "0x18A21E2E0", Slot = "4")]
			public override void SDOFLZDWLET(GLTFSceneExporter a, YBVGUQCSKJP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xA21E240", Offset = "0xA21C840", VA = "0x18A21E240", Slot = "8")]
			public override void OJAHNLKAQFS(GLTFSceneExporter a, YBVGUQCSKJP b, Transform c, QPBKESVYPXS d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xA21E0E0", Offset = "0xA21C6E0", VA = "0x18A21E0E0", Slot = "9")]
			public override bool HFBSGFYGMUA(GLTFSceneExporter a, YBVGUQCSKJP b, Material c, SWTHYRWJKEM d)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xA21E360", Offset = "0xA21C960", VA = "0x18A21E360", Slot = "10")]
			public override void UETUAYSCOPH(GLTFSceneExporter a, YBVGUQCSKJP b, Material c, SWTHYRWJKEM d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
			public AHJPGXIAVNI()
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
			[Cpp2IlInjected.Address(RVA = "0xA22DDC0", Offset = "0xA22C3C0", VA = "0x18A22DDC0")]
			public TextureExportSettings(TextureExportSettings source)
			{
			}

			[SpecialName]
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xA22DD80", Offset = "0xA22C380", VA = "0x18A22DD80")]
			public static bool HCJGUXGANNO(TextureExportSettings a, TextureExportSettings b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xA22DBA0", Offset = "0xA22C1A0", VA = "0x18A22DBA0")]
			public bool Equals(TextureExportSettings other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xA22DAF0", Offset = "0xA22C0F0", VA = "0x18A22DAF0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xA22DC80", Offset = "0xA22C280", VA = "0x18A22DC80", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0xA2339A0", Offset = "0xA231FA0", VA = "0x18A2339A0")]
			public int XFMKWEMHMAI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xA2339E0", Offset = "0xA231FE0", VA = "0x18A2339E0")]
			public int XZVNHJATMUX()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xA233AB0", Offset = "0xA2320B0", VA = "0x18A233AB0")]
			public UniqueTexture(Texture tex, string textureSlot, GLTFSceneExporter exporter)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xA233A20", Offset = "0xA232020", VA = "0x18A233A20")]
			public UniqueTexture(Texture tex, TextureExportSettings exportSettings)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xA233740", Offset = "0xA231D40", VA = "0x18A233740", Slot = "4")]
			public bool Equals(UniqueTexture other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xA233680", Offset = "0xA231C80", VA = "0x18A233680", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xA233900", Offset = "0xA231F00", VA = "0x18A233900", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0xA233330", Offset = "0xA231930", VA = "0x18A233330")]
			public bool Equals(UniquePrimitive other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xA233480", Offset = "0xA231A80", VA = "0x18A233480", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xA233530", Offset = "0xA231B30", VA = "0x18A233530", Slot = "2")]
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
			public BGOSXQNMGFA aPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public BGOSXQNMGFA aNormal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public BGOSXQNMGFA aTangent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public BGOSXQNMGFA aTexcoord0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public BGOSXQNMGFA aTexcoord1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public BGOSXQNMGFA aTexcoord2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public BGOSXQNMGFA aColor0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public BGOSXQNMGFA aJoints0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public BGOSXQNMGFA aWeights0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public Dictionary<int, TOEZEOEVPIK> subMeshPrimitives;
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private struct BlendShapeAccessors
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public List<Dictionary<string, BGOSXQNMGFA>> targets;

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
			public bool VSLJMOJQLTH
			{
				[Cpp2IlInjected.Token(Token = "0x60000C7")]
				[Cpp2IlInjected.Address(RVA = "0xF411E0", Offset = "0xF3F7E0", VA = "0x180F411E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public bool WPDUXCJAGYE
			{
				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x758D750", Offset = "0x758BD50", VA = "0x18758D750")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xA22DA60", Offset = "0xA22C060", VA = "0x18A22DA60")]
			public SamplerRelevantTextureData(Texture texture)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xA22D9B0", Offset = "0xA22BFB0", VA = "0x18A22D9B0", Slot = "4")]
			public bool Equals(SamplerRelevantTextureData other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xA22D8F0", Offset = "0xA22BEF0", VA = "0x18A22D8F0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xA22D9E0", Offset = "0xA22BFE0", VA = "0x18A22D9E0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class IGIMYCOMDWW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public bool UVJDUMWTYOO;

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public IGIMYCOMDWW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xA22C920", Offset = "0xA22AF20", VA = "0x18A22C920")]
			internal Color YHNUVGSZIVJ(object a)
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class IGNTVJIJNIF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public float NJFNBGUNVPN;

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public IGNTVJIJNIF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xA22CA20", Offset = "0xA22B020", VA = "0x18A22CA20")]
			internal float YHINXZZBZKA(object a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class OZEQOHXVDNX : IEnumerable<(int, TOEZEOEVPIK)>, IEnumerable, IEnumerator<(int, TOEZEOEVPIK)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private (int subMeshIndex, TOEZEOEVPIK prim) MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private int NVRLJVISCMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public GLTFSceneExporter CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private Mesh WOFXDPXIQSZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public Mesh YNDOUYKXAPW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private Dictionary<int, TOEZEOEVPIK>.Enumerator TPFONUYPLCA;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private (int, TOEZEOEVPIK) WLQQIRPMXFE
			{
				[Cpp2IlInjected.Token(Token = "0x60000E5")]
				[Cpp2IlInjected.Address(RVA = "0xC5F3C0", Offset = "0xC5D9C0", VA = "0x180C5F3C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((int, TOEZEOEVPIK));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0xA22D130", Offset = "0xA22B730", VA = "0x18A22D130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xC5F770", Offset = "0xC5DD70", VA = "0x180C5F770")]
			[DebuggerHidden]
			public OZEQOHXVDNX(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xA22CFF0", Offset = "0xA22B5F0", VA = "0x18A22CFF0", Slot = "7")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xA22D1D0", Offset = "0xA22B7D0", VA = "0x18A22D1D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xA22D180", Offset = "0xA22B780", VA = "0x18A22D180")]
			private void KPIRURCCWVL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xA22D4A0", Offset = "0xA22BAA0", VA = "0x18A22D4A0", Slot = "10")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xA22D080", Offset = "0xA22B680", VA = "0x18A22D080", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(int, TOEZEOEVPIK)> ICPXCLHXFOR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xA22D080", Offset = "0xA22B680", VA = "0x18A22D080", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator MZPFIUHPQEF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static ILogger IXIYPFFXAJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private List<NIJBGKZVPPN> KGQTNJKCSLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private Transform[] YTEZXWZMODS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private YBVGUQCSKJP IKGSZDANXIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private KFOQMVQOIBF YWPNWUDDPFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private RUEBWFIIWST QOMDZYFBDCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private List<ImageInfo> HGLBPLZNOJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private HashSet<string> GXLNARKXZSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private List<FileInfo> MUFGCOPEXEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private HashSet<string> EWWJNGODFGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private List<UniqueTexture> OUZIMHYDPNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private Dictionary<int, int> CKBVOTOTUGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private bool SVKABPIBANF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private Dictionary<int, int> ODURKKDGYCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private List<Transform> IYHPVPNLRFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private int LYLOVYSFXYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private PPPKVVWBNXH OCKYWFPRVBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private Material YQEHDBENZDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private Material TNKLJYQDORG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private Material PZGVNTKRGWE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private bool DNGZCROGYJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly Dictionary<UniquePrimitive, RDRLREPEFYU> DJIPJGCACOQ;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static ProfilerMarker QLXCEZDORIJ;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static ProfilerMarker MIXKDUMXWKN;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static ProfilerMarker TNDPCUIZBXT;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static ProfilerMarker ZWMLHULCKYZ;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static ProfilerMarker WURVIEKPWQU;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static ProfilerMarker KMKNLOKHRKV;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static ProfilerMarker PEJZWGTPTTB;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static ProfilerMarker QTPNNHPAEVZ;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static ProfilerMarker IEFBOVZMYXK;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static ProfilerMarker IFPNFWWOTDU;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static ProfilerMarker TQEDLLUIHJU;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static ProfilerMarker HEKHNYWNEFB;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static ProfilerMarker SHCGHHTXHMJ;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static ProfilerMarker UKEYTBZFYZS;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static ProfilerMarker PLMXNTEUDFU;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static ProfilerMarker FPJVKHNZHJT;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static ProfilerMarker EYVEFQUYMFV;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static ProfilerMarker OQBVQFOYIHY;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static ProfilerMarker SCJNOHLAEBA;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static ProfilerMarker PWIQMIOPHEL;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static ProfilerMarker IPIZOIFQDYH;

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static ProfilerMarker GTZHWOESEMZ;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private static ProfilerMarker LUKIHEZSTDW;

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private static ProfilerMarker JELEVSYWTXF;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private static ProfilerMarker QYFYRXRWPIW;

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private static ProfilerMarker RFFVROSCKVV;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static ProfilerMarker EJDGSHASLZY;

		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private static ProfilerMarker RFFKHJAMKLP;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static ProfilerMarker EMNWNBFBBWE;

		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private static ProfilerMarker BTWHXWONTMK;

		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private static ProfilerMarker WPKGVHIOTVP;

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private static ProfilerMarker WJGDDMMVBUQ;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private static ProfilerMarker PBTURXRMYSX;

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private static ProfilerMarker SKMGIKCAQXI;

		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private static ProfilerMarker SKXRBNWPBDG;

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private static ProfilerMarker BODKRBBAKAP;

		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private static ProfilerMarker GPQGPBLIYNH;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private static ProfilerMarker FXTKYTMUMTK;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static ProfilerMarker PCROIXWENMH;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private static ProfilerMarker APUMCFPRSYA;

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private static ProfilerMarker YNDWXDADBDT;

		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private static ProfilerMarker SPACESDXYTV;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private static ProfilerMarker YIFAVPKZUIN;

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static ProfilerMarker QFFPNQMGVLO;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static ProfilerMarker CSSWSTVDADH;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static ProfilerMarker UBZZCROYFXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private UnityGLTF.BinaryWriterWithLessAllocations QPHVZYTHECY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private bool? LPASZHHMTCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		internal readonly List<QRQJRDONJFG> UMOAFKHDFUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly LPZSROKDRIL YCSDJEXFGLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private Dictionary<int, int> KHOWZPZTDLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private Dictionary<int, int> LSBFWXVSLZZ;

		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[CompilerGenerated]
		private static BeforeSceneExportDelegate SDOFLZDWLET;

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[CompilerGenerated]
		private static AfterSceneExportDelegate XUHGDBIMMOE;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[CompilerGenerated]
		private static AfterNodeExportDelegate OJAHNLKAQFS;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[CompilerGenerated]
		private static BeforeMaterialExportDelegate HFBSGFYGMUA;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[CompilerGenerated]
		private static AfterMaterialExportDelegate UETUAYSCOPH;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static Material HHNNAQOGFAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private HashSet<Material> CGQQWEWWRRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly Dictionary<Mesh, MeshAccessors> DQLFIZEHKFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly Dictionary<Mesh, BlendShapeAccessors> OVAFWTAFXFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly Dictionary<SkinnedMeshRenderer, List<double>> RSHMBOCJKDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private List<Transform> FFJSWYDUQDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private Dictionary<SkinnedMeshRenderer, Mesh> ZQKEAYYOJDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private Dictionary<SamplerRelevantTextureData, int> XHFUPKPLDPL;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public IReadOnlyList<Transform> QUVTRSIJMJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private GLTFSettings QVFBSGRPICZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA201630", Offset = "0xA1FFC30", VA = "0x18A201630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private bool FGZVZFMLKPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA213940", Offset = "0xA211F40", VA = "0x18A213940")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private bool QZLRFOBHUQF
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xA21BAD0", Offset = "0xA21A0D0", VA = "0x18A21BAD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private bool XDCFKGHNBPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xA212950", Offset = "0xA210F50", VA = "0x18A212950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static Material SQSDGZEIUGU
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xA206A20", Offset = "0xA205020", VA = "0x18A206A20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA21BBC0", Offset = "0xA21A1C0", VA = "0x18A21BBC0")]
		public TextureExportSettings ZWOTXKIUFAC(string a)
		{
			return default(TextureExportSettings);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA20C6F0", Offset = "0xA20ACF0", VA = "0x18A20C6F0")]
		private Material JPFVOHTGXAJ(TextureExportSettings a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA203B20", Offset = "0xA202120", VA = "0x18A203B20")]
		private static Material FTPMBBQXSUM(Material a, TextureExportSettings b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA21C9E0", Offset = "0xA21AFE0", VA = "0x18A21C9E0")]
		public GLTFSceneExporter(Transform[] rootTransforms, PPPKVVWBNXH context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA215190", Offset = "0xA213790", VA = "0x18A215190")]
		public void PQVOFKQRUUN(Stream a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA219820", Offset = "0xA217E20", VA = "0x18A219820")]
		public void WJEOGEYHRLE(string a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA212F70", Offset = "0xA211570", VA = "0x18A212F70")]
		private bool NELBKWEHIBN(Transform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA202840", Offset = "0xA200E40", VA = "0x18A202840")]
		private VUKMLPLUBJP CTLTNWFUBYK(string a, Transform[] b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA21A7A0", Offset = "0xA218DA0", VA = "0x18A21A7A0")]
		private INANEINPBQN YVCHUIEJORA(Transform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA218CB0", Offset = "0xA2172B0", VA = "0x18A218CB0")]
		private static bool WEEPITVRZSG(GameObject a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA217640", Offset = "0xA215C40", VA = "0x18A217640")]
		private void TPFVWQHLIWY(Transform a, [Out] GameObject[] b, [Out] GameObject[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA212AD0", Offset = "0xA2110D0", VA = "0x18A212AD0")]
		private void MXSMQHBLLXS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA20C940", Offset = "0xA20AF40", VA = "0x18A20C940")]
		public DLQSFWWUUNC LNAGCTWKEWM(YBVGUQCSKJP a, Material b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA215AA0", Offset = "0xA2140A0", VA = "0x18A215AA0")]
		public SXDMJXWDAIG PRVICQCTUBA(YBVGUQCSKJP a, UniqueTexture b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA201720", Offset = "0xA1FFD20", VA = "0x18A201720")]
		public NVYZNLYAPSA AWGXFIPAYKA(YBVGUQCSKJP a, Texture b, TextureExportSettings c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA21A0C0", Offset = "0xA2186C0", VA = "0x18A21A0C0")]
		private static void YDDPMUBBWPP(Stream a, BinaryWriter b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA202DF0", Offset = "0xA2013F0", VA = "0x18A202DF0")]
		private static void DLTLHJXQLSK(Stream a, byte b = 32, uint c = 4u)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA206420", Offset = "0xA204A20", VA = "0x18A206420")]
		public static uint HDGGFQBMADT(uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA218F20", Offset = "0xA217520", VA = "0x18A218F20")]
		private BGOSXQNMGFA WGDAROLEEAR(Vector4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA203F40", Offset = "0xA202540", VA = "0x18A203F40")]
		private BGOSXQNMGFA GFVQBADIPSC(Quaternion[] a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA20F4E0", Offset = "0xA20DAE0", VA = "0x18A20F4E0")]
		private BGOSXQNMGFA MSNUEJAWSJT(Matrix4x4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA20CD30", Offset = "0xA20B330", VA = "0x18A20CD30")]
		private BGOSXQNMGFA MSNUEJAWSJT(float[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA20F980", Offset = "0xA20DF80", VA = "0x18A20F980")]
		private BGOSXQNMGFA MSNUEJAWSJT(int[] a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA20EE50", Offset = "0xA20D450", VA = "0x18A20EE50")]
		private BGOSXQNMGFA MSNUEJAWSJT(Vector2[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA20D260", Offset = "0xA20B860", VA = "0x18A20D260")]
		private BGOSXQNMGFA MSNUEJAWSJT(Vector3[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA206C50", Offset = "0xA205250", VA = "0x18A206C50")]
		private BGOSXQNMGFA IEUCEWZOSUR(BGOSXQNMGFA a, Vector3[] b, Vector3[] c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA20D9A0", Offset = "0xA20BFA0", VA = "0x18A20D9A0")]
		private BGOSXQNMGFA MSNUEJAWSJT(Vector4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA20E2A0", Offset = "0xA20C8A0", VA = "0x18A20E2A0")]
		private BGOSXQNMGFA MSNUEJAWSJT(Color[] a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA2174B0", Offset = "0xA215AB0", VA = "0x18A2174B0")]
		private ZOZHHVTIIKS TGZHGJBZPTX(uint a, uint b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		public void SNNIOKSELLW(Transform a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA212B60", Offset = "0xA211160", VA = "0x18A212B60")]
		internal int MXWWWVJKWII(object a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA207C90", Offset = "0xA206290", VA = "0x18A207C90")]
		public int IPBILUUIMJC(Transform a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA203DC0", Offset = "0xA2023C0", VA = "0x18A203DC0")]
		public int GAGUFLEVNDZ(Material a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA203E80", Offset = "0xA202480", VA = "0x18A203E80")]
		public int GBJHRFAONTC(Light a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA208400", Offset = "0xA206A00", VA = "0x18A208400")]
		public int JCFAVIBVGCF(Camera a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA202CD0", Offset = "0xA2012D0", VA = "0x18A202CD0")]
		[IteratorStateMachine(typeof(OZEQOHXVDNX))]
		public IEnumerable<(int, TOEZEOEVPIK)> CZPICLJQOKU(Mesh a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA219CE0", Offset = "0xA2182E0", VA = "0x18A219CE0")]
		private static void WPXXSCMHIRX(Color a, [Out] Color b, [Out] float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA21BB00", Offset = "0xA21A100", VA = "0x18A21BB00")]
		private static void ZPCCDEGTBZA(Vector4 a, [Out] Vector2 b, [Out] Vector2 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA208110", Offset = "0xA206710", VA = "0x18A208110")]
		private bool ISMGDQSZYAH(object[] a, int b, int c, int d, int e, int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA2084C0", Offset = "0xA206AC0", VA = "0x18A2084C0")]
		public void JMONQQKWRTF(float[] a, object[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA2100D0", Offset = "0xA20E6D0", VA = "0x18A2100D0")]
		public void MUVOXRDDTUP(UnityEngine.Object a, string b, VJEIIZXANCJ c, float[] d, object[] e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA21B7C0", Offset = "0xA219DC0", VA = "0x18A21B7C0")]
		private void ZBPYNCBIVMF(object a, string b, ZTREVSYUBDC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA202250", Offset = "0xA200850", VA = "0x18A202250")]
		private DDOEZJZRPAW CCAMKYJOOHP(Camera a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA215C30", Offset = "0xA214230", VA = "0x18A215C30")]
		private DGCVVJOBVKR QRVDFTCIXVU(Light a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA20A160", Offset = "0xA208760", VA = "0x18A20A160")]
		public DLQSFWWUUNC JOGWVXMXICH(Material a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA206700", Offset = "0xA204D00", VA = "0x18A206700")]
		private DLQSFWWUUNC HZSBBWRMQAQ(Material a, SWTHYRWJKEM b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA21B910", Offset = "0xA219F10", VA = "0x18A21B910")]
		private bool ZKDHDOKKMPD(Material a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA212EB0", Offset = "0xA2114B0", VA = "0x18A212EB0")]
		private bool NBNDKSNFOKU(Material a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA213850", Offset = "0xA211E50", VA = "0x18A213850")]
		private bool NQZDKPFKAKH(Material a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA203A80", Offset = "0xA202080", VA = "0x18A203A80")]
		private bool EZETGSNVCUZ(Material a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA206440", Offset = "0xA204A40", VA = "0x18A206440")]
		private static bool HIIVEMANXDS(Shader a, string b, ShaderPropertyType c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA204970", Offset = "0xA202F70", VA = "0x18A204970")]
		private void GJMMNAETOCT(SSGOAVDMOMX a, Material b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA219ED0", Offset = "0xA2184D0", VA = "0x18A219ED0")]
		public EERBVHFJWRY XGEIMVQOWRO(Texture a, string b, Material c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA2082A0", Offset = "0xA2068A0", VA = "0x18A2082A0")]
		private NOLTSBDXCXW IXAVZIUFOPU(Texture a, string b, Material c, [Optional] SXDMJXWDAIG d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA2054B0", Offset = "0xA203AB0", VA = "0x18A2054B0")]
		public YQSYAEFQCCV GRXXBLUBDQH(Material a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA216D50", Offset = "0xA215350", VA = "0x18A216D50")]
		public void SREFJZVDTSW(SWTHYRWJKEM a, Material b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA213970", Offset = "0xA211F70", VA = "0x18A213970")]
		private void OKSLNVBYKPH(SWTHYRWJKEM a, Material b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA207D50", Offset = "0xA206350", VA = "0x18A207D50")]
		private IQHJOZBUORK IPIVDMMPGSX(Material a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA202D60", Offset = "0xA201360", VA = "0x18A202D60")]
		internal static void DHJCEWOIGVV(Color a, [Out] Color b, [Out] float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA20C7D0", Offset = "0xA20ADD0", VA = "0x18A20C7D0")]
		public void KFIJMDTBUZR(QPBKESVYPXS a, List<UniquePrimitive> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA2130D0", Offset = "0xA2116D0", VA = "0x18A2130D0")]
		private static List<UniquePrimitive> NQFKUYURUZP(IEnumerable<GameObject> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA21A760", Offset = "0xA218D60", VA = "0x18A21A760")]
		public INANEINPBQN YVCHUIEJORA(GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA2178C0", Offset = "0xA215EC0", VA = "0x18A2178C0")]
		public RDRLREPEFYU UCVQGWMQPTN(string a, List<UniquePrimitive> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA208D10", Offset = "0xA207310", VA = "0x18A208D10")]
		private TOEZEOEVPIK[] JNKPKEAFCZZ(UniquePrimitive a, BFGGSXOTTTO b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA20CA90", Offset = "0xA20B090", VA = "0x18A20CA90")]
		private List<double> LUJNIQYZBMF(SkinnedMeshRenderer a, Mesh b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA2180E0", Offset = "0xA2166E0", VA = "0x18A2180E0")]
		private void UZOCMINQZVB(SkinnedMeshRenderer a, Mesh b, int c, TOEZEOEVPIK d, BFGGSXOTTTO e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA219EB0", Offset = "0xA2184B0", VA = "0x18A219EB0")]
		private static bool WWLTLDRVMMS(TOEZEOEVPIK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA217FE0", Offset = "0xA2165E0", VA = "0x18A217FE0")]
		private static DrawMode UTGLYWFDXUR(MeshTopology a)
		{
			return default(DrawMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA217FC0", Offset = "0xA2165C0", VA = "0x18A217FC0")]
		private static bool UOQQRNXYART(Mesh a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA2140C0", Offset = "0xA2126C0", VA = "0x18A2140C0")]
		private void OQBTORHAPQL(Transform a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA217280", Offset = "0xA215880", VA = "0x18A217280")]
		private Mesh TCSAEHQINNK(GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA20CC30", Offset = "0xA20B230", VA = "0x18A20CC30")]
		private Material[] MBWNMXNEHKD(GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA218B20", Offset = "0xA217120", VA = "0x18A218B20")]
		private Vector4[] WDWBEBTPFTN(BoneWeight[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA205360", Offset = "0xA203960", VA = "0x18A205360")]
		private Vector4[] GLODGYWSMEF(BoneWeight[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA2064E0", Offset = "0xA204AE0", VA = "0x18A2064E0")]
		private string HYSYAXWQDJK(HashSet<string> a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA21A650", Offset = "0xA218C50", VA = "0x18A21A650")]
		public SSGOAVDMOMX YMOBOYLTEWV(Texture a, string b, [Optional] TextureExportSettings c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA202750", Offset = "0xA200D50", VA = "0x18A202750")]
		public SSGOAVDMOMX CGPLCQKRNDO(Material a, Texture b, string c, [Optional] TextureExportSettings d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA2163C0", Offset = "0xA2149C0", VA = "0x18A2163C0")]
		public SXDMJXWDAIG SGHXZLDVGRH(Texture a, string b, [Optional] TextureExportSettings c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA219A30", Offset = "0xA218030", VA = "0x18A219A30")]
		private string WLSCEQPVJDV(Texture a, TextureExportSettings b, string c, [Out] bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA2018F0", Offset = "0xA1FFEF0", VA = "0x18A2018F0")]
		private NVYZNLYAPSA BTWKGQNZWKP(UniqueTexture a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x491EB40", Offset = "0x491D140", VA = "0x18491EB40")]
		private bool NWLTMUPQCZW(TextureExportSettings a, Texture b, [Out] string c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860")]
		private byte[] YHYYCVGPQWO(Texture a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xA21BB30", Offset = "0xA21A130", VA = "0x18A21BB30")]
		private bool ZPZGTESEXVQ(Texture a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xA2138C0", Offset = "0xA211EC0", VA = "0x18A2138C0")]
		private bool OENNUCYQQFF(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA201650", Offset = "0xA1FFC50", VA = "0x18A201650")]
		private bool AHBHBWECYPY(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xA202EC0", Offset = "0xA2014C0", VA = "0x18A202EC0")]
		private NVYZNLYAPSA DWAPFECAEHW(UniqueTexture a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xA21A190", Offset = "0xA218790", VA = "0x18A21A190")]
		private QYYGORGDVXT YENXRJQVJBE(Texture a)
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
	public class WPKHZAXWWKZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public IQUUCFQFESE BTSHEYWZSLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public YABGTNFERRK RNWRJEGRKLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public AsyncCoroutineHelper EDJLWXVXZJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public bool AFQNWJYKFYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public AnimationMethod ARBPIJGLYFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public bool MOQKPXPJJBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public DeduplicateOptions GWNLNBYPOOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public bool TZHHGTJMEGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public GLTFImporterNormals ZVMHCXTAMSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public GLTFImporterNormals ZUIJLODOSED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public bool JLAIYXZUHFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public CameraImportOption AETHFQBFRJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public RuntimeTextureCompression TNAZMUXIMST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public BlendShapeFrameWeightSetting HOQBFTWSCLX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public UWIWONGEACP XZFPQROJRWE;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public ILogger EJCYMILAWTG;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA233B60", Offset = "0xA232160", VA = "0x18A233B60")]
		public WPKHZAXWWKZ()
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
		public float VVRBWQMVWJR
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA22CA80", Offset = "0xA22B080", VA = "0x18A22CA80")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xA22CAB0", Offset = "0xA22B0B0", VA = "0x18A22CAB0", Slot = "3")]
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
		private class XNXXYLGERIX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Texture GSRNUFNSHIX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public int MJWETYALAFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public double MQSCJWKFBOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Vector2 YKTGULEOTLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public double VBLUIXJXMKS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Vector2 ZZGGBTRPGMS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public int? AQVXPZEUEYY;

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0xA233D00", Offset = "0xA232300", VA = "0x18A233D00")]
			public XNXXYLGERIX()
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
			public AsyncTaskMethodBuilder<UZAMOXUXDLF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public BGOSXQNMGFA accessorId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public bool isPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			private OERFMZANDAT <accessor>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			private TaskAwaiter<MBXESCOTZRS> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xA230D20", Offset = "0xA22F320", VA = "0x18A230D20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0xA231230", Offset = "0xA22F830", VA = "0x18A231230", Slot = "5")]
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
			public VJEIIZXANCJ animation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			public TARSEFBHMVS animationCache;
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class UYXZSLCEYHV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public XYFZUQCULVJ FPEZFKHWOBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			public ValuesConvertion LHHDSXHGNKP;

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public UYXZSLCEYHV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0xA232F80", Offset = "0xA231580", VA = "0x18A232F80")]
			internal float[] JIOCGWGWXMR(NumericArray a, int b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class UZDGPRWCHTE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public bool WUTGYUFCIKZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			public int DQWGOIFWZWI;

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public UZDGPRWCHTE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xA232FC0", Offset = "0xA2315C0", VA = "0x18A232FC0")]
			internal float[] JIYQBJURQJJ(NumericArray a, int b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class UZINMYPZREN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			public float[] MOBZWOVYDVU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			public BlendShapeFrameWeightSetting KPEFVASUMCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			public UZDGPRWCHTE GOOXOIYUWOV;

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public UZINMYPZREN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0xA233260", Offset = "0xA231860", VA = "0x18A233260")]
			internal float[] TERYNQZPERO(NumericArray a, int b)
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
			public XWGHBGDRRSJ mapper;
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class RNAASMMKDOH
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
				public RNAASMMKDOH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400016A")]
				private SWTHYRWJKEM <def>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400016B")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000177")]
				[Cpp2IlInjected.Address(RVA = "0xA2312A0", Offset = "0xA22F8A0", VA = "0x18A2312A0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000178")]
				[Cpp2IlInjected.Address(RVA = "0xA2316C0", Offset = "0xA22FCC0", VA = "0x18A2316C0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public int UZBPDIQNDQT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public GLTFSceneImporter CDTALOACOKM;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public RNAASMMKDOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0xA22D820", Offset = "0xA22BE20", VA = "0x18A22D820")]
			[AsyncStateMachine(typeof(<<LoadMaterialAsync>b__0>d))]
			internal Task YZMTJSWPWFV()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private sealed class MTTIYUEKDGW
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
				public MTTIYUEKDGW <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000172")]
				private BFGGSXOTTTO <def>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000173")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600017B")]
				[Cpp2IlInjected.Address(RVA = "0xA231720", Offset = "0xA22FD20", VA = "0x18A231720", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600017C")]
				[Cpp2IlInjected.Address(RVA = "0xA231CD0", Offset = "0xA2302D0", VA = "0x18A231CD0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public int KSKVBNKWYFR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public GLTFSceneImporter CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public CancellationToken YBWQEIOLJEU;

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public MTTIYUEKDGW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xA22CF20", Offset = "0xA22B520", VA = "0x18A22CF20")]
			[AsyncStateMachine(typeof(<<LoadMeshAsync>b__0>d))]
			internal Task GUZYDMMFIPF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class IAHMSPMVXIF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public GLTFSceneImporter CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public ACYERDLMEEW LJDOERGLBBV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public string TJQJGKUKXJV;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public IAHMSPMVXIF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xA22C7A0", Offset = "0xA22ADA0", VA = "0x18A22C7A0")]
			internal Stream LNOPAEPIOEI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xA22C890", Offset = "0xA22AE90", VA = "0x18A22C890")]
			internal void LNTVXLJFXPR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class BDFGCCOHIAJ
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
				public BDFGCCOHIAJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				public bool onlyMesh;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x4000180")]
				public bool ignoreMesh;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000181")]
				private List<INANEINPBQN>.Enumerator <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000182")]
				private TaskAwaiter<GameObject> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000183")]
				private BFGGSXOTTTO <mesh>5__3;

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
				[Cpp2IlInjected.Address(RVA = "0xA22F040", Offset = "0xA22D640", VA = "0x18A22F040", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000184")]
				[Cpp2IlInjected.Address(RVA = "0xA230CC0", Offset = "0xA22F2C0", VA = "0x18A230CC0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public GameObject LCZIHYNSTOR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public QPBKESVYPXS JOZJMPXRKWY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public GLTFSceneImporter CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public CancellationToken YBWQEIOLJEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public int HRGIOVLOPDG;

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public BDFGCCOHIAJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xA21E840", Offset = "0xA21CE40", VA = "0x18A21E840")]
			[AsyncStateMachine(typeof(<<ConstructNode>g__CreateNodeComponentsAndChilds|0>d))]
			internal Task HGSTSZLPCYC(bool a = false, bool b = false)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0xA21E960", Offset = "0xA21CF60", VA = "0x18A21E960")]
			internal Material UVMPSMEXHTU(TOEZEOEVPIK a)
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
			public VJEIIZXANCJ animation;

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
			private Dictionary<string, List<UZAMOXUXDLF>> <samplersByType>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			private int <i>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			private PWBLEBRREXU <samplerDef>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			private TaskAwaiter<MBXESCOTZRS> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xA233DE0", Offset = "0xA2323E0", VA = "0x18A233DE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xA234A90", Offset = "0xA233090", VA = "0x18A234A90", Slot = "5")]
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
			public KISYKKNMMPI image;

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
			[Cpp2IlInjected.Address(RVA = "0xA234AF0", Offset = "0xA2330F0", VA = "0x18A234AF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xA2352C0", Offset = "0xA2338C0", VA = "0x18A2352C0", Slot = "5")]
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
			public RUEBWFIIWST buffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			private TaskAwaiter<Stream> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xA235940", Offset = "0xA233F40", VA = "0x18A235940", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xA236130", Offset = "0xA234730", VA = "0x18A236130", Slot = "5")]
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
			public QPBKESVYPXS node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			private List<INANEINPBQN>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xA235330", Offset = "0xA233930", VA = "0x18A235330", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xA2358E0", Offset = "0xA233EE0", VA = "0x18A2358E0", Slot = "5")]
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
			private UYXZSLCEYHV <>8__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			private AnimationClip <clip>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			private int[] <nodeIds>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			private IAZFUYYLNJT <pointerImportContext>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			private List<PJWNKQUOEGF>.Enumerator <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			private PJWNKQUOEGF <channel>5__6;

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
			[Cpp2IlInjected.Address(RVA = "0xA236190", Offset = "0xA234790", VA = "0x18A236190", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xA239740", Offset = "0xA237D40", VA = "0x18A239740", Slot = "5")]
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
			public KISYKKNMMPI image;

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
			[Cpp2IlInjected.Address(RVA = "0xA239EB0", Offset = "0xA2384B0", VA = "0x18A239EB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xA23A260", Offset = "0xA238860", VA = "0x18A23A260", Slot = "5")]
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
			public RAXRAOUEMWM texture;

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
			[Cpp2IlInjected.Address(RVA = "0xA2397B0", Offset = "0xA237DB0", VA = "0x18A2397B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xA239E50", Offset = "0xA238450", VA = "0x18A239E50", Slot = "5")]
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
			public QPBKESVYPXS node;

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
			private WEGURTSPULR <lodsExtension>5__2;

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
			[Cpp2IlInjected.Address(RVA = "0xA23A2C0", Offset = "0xA2388C0", VA = "0x18A23A2C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xA23AE70", Offset = "0xA239470", VA = "0x18A23AE70", Slot = "5")]
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
			public SWTHYRWJKEM def;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			private <>c__DisplayClass119_0 <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			public int materialIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			private IFSNSAVGWXL <mrMapper>5__2;

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
			private KVORKFEEDAY <sgMapper>5__12;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			private WSKIYUJIIBZ <unlitMapper>5__13;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			private WJTGDSNUYJU <sheenMapper>5__14;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			private WIZYEANETAL <anisotropyMapper>5__15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			private HSHWNWLFIPB <transmissionMapper>5__16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			private XYDSQUBGKJH <volumeMapper>5__17;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			private QWFHTBPVSFT <iridescenceMapper>5__18;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			private OQMKNSEXWPG <specularMapper>5__19;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			private TXHYJCXYUEL <clearcoatMapper>5__20;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			private MYJPYVSGRBQ <uniformMapper>5__21;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			private YQSYAEFQCCV <pbr>5__22;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			private SXDMJXWDAIG <textureId>5__23;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			private GHSLEETSMXZ <specGloss>5__24;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			private KHR_materials_sheen <sheen>5__25;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			private TaskAwaiter<XNXXYLGERIX> <>u__2;

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
			private XNFBIHXGYUK <clearcoatNormalMapper>5__32;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xA23AED0", Offset = "0xA2394D0", VA = "0x18A23AED0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xA242CA0", Offset = "0xA2412A0", VA = "0x18A242CA0", Slot = "5")]
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
			public BFGGSXOTTTO mesh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			private BFQECECDEFT <meshCache>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			private GHNZIBVCRDK <unityData>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400020E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			private int <i>5__4;

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xA244460", Offset = "0xA242A60", VA = "0x18A244460", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xA244E90", Offset = "0xA243490", VA = "0x18A244E90", Slot = "5")]
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
			public RDRLREPEFYU meshId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public BFGGSXOTTTO mesh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000215")]
			private int <meshIndex>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			private int <i>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000217")]
			private TOEZEOEVPIK <primitive>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xA242D00", Offset = "0xA241300", VA = "0x18A242D00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xA243350", Offset = "0xA241950", VA = "0x18A243350", Slot = "5")]
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
			public TOEZEOEVPIK primitive;

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
			private List<Dictionary<string, UZAMOXUXDLF>> <newTargets>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			private int <i>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			private Dictionary<string, BGOSXQNMGFA>.Enumerator <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000222")]
			private KeyValuePair<string, BGOSXQNMGFA> <targetAttribute>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000223")]
			private int <bufferID>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000224")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			private TaskAwaiter<MBXESCOTZRS> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xA2433B0", Offset = "0xA2419B0", VA = "0x18A2433B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xA244400", Offset = "0xA242A00", VA = "0x18A244400", Slot = "5")]
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
			public QPBKESVYPXS node;

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
			private BDFGCCOHIAJ <>8__1;

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
			[Cpp2IlInjected.Address(RVA = "0xA244EF0", Offset = "0xA2434F0", VA = "0x18A244EF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xA246090", Offset = "0xA244690", VA = "0x18A246090", Slot = "5")]
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
			public TOEZEOEVPIK primitive;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000239")]
			private BFQECECDEFT.WEBXKBISNDH <primData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400023A")]
			private Dictionary<string, BGOSXQNMGFA>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400023B")]
			private KeyValuePair<string, BGOSXQNMGFA> <attributePair>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400023C")]
			private GLCKQYBTAIT <sparse>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400023D")]
			private TaskAwaiter<MBXESCOTZRS> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400023E")]
			private UZAMOXUXDLF <sparseValues>5__6;

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xA24BF60", Offset = "0xA24A560", VA = "0x18A24BF60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xA24D0A0", Offset = "0xA24B6A0", VA = "0x18A24D0A0", Slot = "5")]
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
			public HFFDYZWKXSX scene;

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
			[Cpp2IlInjected.Address(RVA = "0xA24D100", Offset = "0xA24B700", VA = "0x18A24D100", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xA24DE20", Offset = "0xA24C420", VA = "0x18A24DE20", Slot = "5")]
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
			public RAXRAOUEMWM texture;

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
			private KISYKKNMMPI <image>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000258")]
			private bool <isFirstInstance>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000259")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xA24DE80", Offset = "0xA24C480", VA = "0x18A24DE80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xA24F100", Offset = "0xA24D700", VA = "0x18A24F100", Slot = "5")]
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
			public GHNZIBVCRDK unityMeshData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000260")]
			private Mesh <mesh>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000261")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xA24F160", Offset = "0xA24D760", VA = "0x18A24F160", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xA250280", Offset = "0xA24E880", VA = "0x18A250280", Slot = "5")]
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
			public KISYKKNMMPI image;

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
			private MBXESCOTZRS <bufferView>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400026E")]
			private TaskAwaiter<MBXESCOTZRS> <>u__1;

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
			[Cpp2IlInjected.Address(RVA = "0xA2502E0", Offset = "0xA24E8E0", VA = "0x18A2502E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xA251DD0", Offset = "0xA2503D0", VA = "0x18A251DD0", Slot = "5")]
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
			public TOEZEOEVPIK primitive;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000277")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000278")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xA2524C0", Offset = "0xA250AC0", VA = "0x18A2524C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xA252760", Offset = "0xA250D60", VA = "0x18A252760", Slot = "5")]
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
			public BFGGSXOTTTO mesh;

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
			[Cpp2IlInjected.Address(RVA = "0xA2527C0", Offset = "0xA250DC0", VA = "0x18A2527C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0xA2529C0", Offset = "0xA250FC0", VA = "0x18A2529C0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA252A20", Offset = "0xA251020", VA = "0x18A252A20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xA252EA0", Offset = "0xA2514A0", VA = "0x18A252EA0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<XNXXYLGERIX> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000286")]
			public SSGOAVDMOMX textureInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000287")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000288")]
			public bool isNormal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000289")]
			private XNXXYLGERIX <result>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400028A")]
			private SXDMJXWDAIG <textureId>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400028B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xA252F00", Offset = "0xA251500", VA = "0x18A252F00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0xA2534C0", Offset = "0xA251AC0", VA = "0x18A2534C0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<MBXESCOTZRS> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400028E")]
			public KFOQMVQOIBF bufferId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400028F")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000290")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0xA253530", Offset = "0xA251B30", VA = "0x18A253530", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xA2537C0", Offset = "0xA251DC0", VA = "0x18A2537C0", Slot = "5")]
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
			public QPBKESVYPXS node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000295")]
			private UZAMOXUXDLF <positionsAttr>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000296")]
			private UZAMOXUXDLF <rotationAttr>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000297")]
			private UZAMOXUXDLF <scaleAttr>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000298")]
			private EXT_mesh_gpu_instancing <extMeshGPUInstancing>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000299")]
			private int <instancesCount>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400029A")]
			private TaskAwaiter<UZAMOXUXDLF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xA253830", Offset = "0xA251E30", VA = "0x18A253830", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0xA254480", Offset = "0xA252A80", VA = "0x18A254480", Slot = "5")]
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
			private QPBKESVYPXS <node>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002A2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002A3")]
			private WEGURTSPULR <lodsExtension>5__4;

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
			[Cpp2IlInjected.Address(RVA = "0xA2544F0", Offset = "0xA252AF0", VA = "0x18A2544F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0xA255380", Offset = "0xA253980", VA = "0x18A255380", Slot = "5")]
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
			private IAHMSPMVXIF <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002AC")]
			private TaskAwaiter<Stream> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002AD")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0xA2553F0", Offset = "0xA2539F0", VA = "0x18A2553F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0xA255B30", Offset = "0xA254130", VA = "0x18A255B30", Slot = "5")]
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
			private RNAASMMKDOH <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002B3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xA255B90", Offset = "0xA254190", VA = "0x18A255B90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0xA255E90", Offset = "0xA254490", VA = "0x18A255E90", Slot = "5")]
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
			private MTTIYUEKDGW <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002BA")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0xA255F00", Offset = "0xA254500", VA = "0x18A255F00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0xA256220", Offset = "0xA254820", VA = "0x18A256220", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA256290", Offset = "0xA254890", VA = "0x18A256290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0xA257300", Offset = "0xA255900", VA = "0x18A257300", Slot = "5")]
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
			private SWTHYRWJKEM <def>5__3;

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xA257360", Offset = "0xA255960", VA = "0x18A257360", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xA2577D0", Offset = "0xA255DD0", VA = "0x18A2577D0", Slot = "5")]
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
			private BFGGSXOTTTO <gltfMesh>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002D0")]
			private int <i>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002D1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0xA257830", Offset = "0xA255E30", VA = "0x18A257830", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0xA257EE0", Offset = "0xA2564E0", VA = "0x18A257EE0", Slot = "5")]
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
			public SXIOEAXYCPD skin;

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
			private TaskAwaiter<MBXESCOTZRS> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			private int <i>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40002DE")]
			private TaskAwaiter<GameObject> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0xA257F40", Offset = "0xA256540", VA = "0x18A257F40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xA258A20", Offset = "0xA257020", VA = "0x18A258A20", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA258A80", Offset = "0xA257080", VA = "0x18A258A80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xA259080", Offset = "0xA257680", VA = "0x18A259080", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA2592F0", Offset = "0xA2578F0", VA = "0x18A2592F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xA259510", Offset = "0xA257B10", VA = "0x18A259510", Slot = "5")]
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
			private HFFDYZWKXSX <scene>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xA259570", Offset = "0xA257B70", VA = "0x18A259570", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xA25A230", Offset = "0xA258830", VA = "0x18A25A230", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public int EULMIBAJVZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public int VWJSEOXYZGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private bool ITWDYVBSSIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private bool HXMPEQRKFEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private Dictionary<Stream, NativeArray<byte>> GUKTQREDEMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public bool JNAUBYBIKGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public bool JZRNUZOWIAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public bool IWHZADYTXAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x63")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public bool NKJDWLVGQUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public bool QNXJZSJFBYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public ImportStatistics LTTPQKRHLOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		protected WPKHZAXWWKZ AWSUENYOALH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		protected TVGKYBLVOTQ BABADRYKPPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		protected GameObject OKQDFKLCRDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		protected readonly SWTHYRWJKEM SQSDGZEIUGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		internal DZXWPWAZLNL TESZCJNFEDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		protected string ZGUXZVFFNAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		protected GLBStream DALCMUQFVVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		protected YBVGUQCSKJP UHXRELIXSQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		protected FWVPWEKFKPM RAIUGPSTPUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		protected bool XSMLSCWBPPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		protected ImportProgress ZBTGYJRUTMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		protected IProgress<ImportProgress> JBIEHHEDNHZ;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static ILogger IXIYPFFXAJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		protected ColorSpace YPBVZBMMKQQ;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		internal static List<Texture> VMUQARBWEGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private Dictionary<int, int> JFOUWQPHLMI;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool NILTMSDRRNK
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xA226910", Offset = "0xA224F10", VA = "0x18A226910")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xAB3D10", Offset = "0xAB2310", VA = "0x180AB3D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public YBVGUQCSKJP KXNQQKPTVYU
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xF66510", Offset = "0xF64B10", VA = "0x180F66510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Transform AJIUWFMLAKU
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xAA7770", Offset = "0xAA5D70", VA = "0x180AA7770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public GameObject ZJDELWCVULZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0xAA8690", Offset = "0xAA6C90", VA = "0x180AA8690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private AnimationClip[] XPVVWIJJTFD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9B0", Offset = "0xAA8FB0", VA = "0x180AAA9B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ColliderType GDKNCNXXDYY
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xAD6210", Offset = "0xAD4810", VA = "0x180AD6210")]
			[CompilerGenerated]
			get
			{
				return default(ColliderType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xE799B0", Offset = "0xE77FB0", VA = "0x180E799B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public string INUKYBMXZMZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEE0", Offset = "0xAAE4E0", VA = "0x180AAFEE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xAB0770", Offset = "0xAAED70", VA = "0x180AB0770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public GameObject JCHPFMCSTBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xAB4960", Offset = "0xAB2F60", VA = "0x180AB4960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public NWWJEMMFXIL[] BMWFSUEIRDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xA228990", Offset = "0xA226F90", VA = "0x18A228990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Texture2D[] QLVEWWNOSPE
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xA221030", Offset = "0xA21F630", VA = "0x18A221030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public DZXWPWAZLNL[] ZSPZEZPCZUV
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xA224D90", Offset = "0xA223390", VA = "0x18A224D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public TARSEFBHMVS[] TTIPGOIHZXS
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xA21F5F0", Offset = "0xA21DBF0", VA = "0x18A21F5F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public BFQECECDEFT[] CRACXNQONCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0xA2230E0", Offset = "0xA2216E0", VA = "0x18A2230E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public List<UnityEngine.Object> RLJLPIHSFDS
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xAACD40", Offset = "0xAAB340", VA = "0x180AACD40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected UWIWONGEACP SLFOLBZCRNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xA225390", Offset = "0xA223990", VA = "0x18A225390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xA22C060", Offset = "0xA22A660", VA = "0x18A22C060")]
		public GLTFSceneImporter(string gltfFileName, WPKHZAXWWKZ options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xA22C0B0", Offset = "0xA22A6B0", VA = "0x18A22C0B0")]
		public GLTFSceneImporter(Stream gltfStream, WPKHZAXWWKZ options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xA22C1B0", Offset = "0xA22A7B0", VA = "0x18A22C1B0")]
		private GLTFSceneImporter(WPKHZAXWWKZ options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xA223740", Offset = "0xA221D40", VA = "0x18A223740")]
		private NativeArray<byte> JXZVPOSGORG(Stream a)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xA228050", Offset = "0xA226650", VA = "0x18A228050")]
		private void TBXSFFMSPUO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xA220DA0", Offset = "0xA21F3A0", VA = "0x18A220DA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xA223600", Offset = "0xA221C00", VA = "0x18A223600")]
		[AsyncStateMachine(typeof(<LoadSceneAsync>d__81))]
		public Task JWVFBUBNFDG(int a = -1, bool b = true, [Optional] Action<GameObject, ExceptionDispatchInfo> c, [Optional] CancellationToken d, [Optional] IProgress<ImportProgress> e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA21FAD0", Offset = "0xA21E0D0", VA = "0x18A21FAD0")]
		[AsyncStateMachine(typeof(<LoadUnreferencedAssetsAsync>d__82))]
		private Task BYDWFXKYAGH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xA226990", Offset = "0xA224F90", VA = "0x18A226990", Slot = "5")]
		[AsyncStateMachine(typeof(<LoadMaterialAsync>d__85))]
		public virtual Task<Material> RACOVEWCYKT(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xA220DF0", Offset = "0xA21F3F0", VA = "0x18A220DF0", Slot = "6")]
		[AsyncStateMachine(typeof(<LoadMeshAsync>d__86))]
		public virtual Task<Mesh> EDZZUNBYKPV(int a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xA228750", Offset = "0xA226D50", VA = "0x18A228750")]
		[AsyncStateMachine(typeof(<LoadJson>d__87))]
		private Task TURZTOXKSJE(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xA2253B0", Offset = "0xA2239B0", VA = "0x18A2253B0")]
		private void NKMCLCSHPDZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xA226480", Offset = "0xA224A80", VA = "0x18A226480")]
		[AsyncStateMachine(typeof(<_LoadScene>d__90))]
		protected Task QPSCJWVQRGX(int a = -1, bool b = true, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xA228DC0", Offset = "0xA2273C0", VA = "0x18A228DC0")]
		private void WNZIEYGICDH(HFFDYZWKXSX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xA221050", Offset = "0xA21F650", VA = "0x18A221050")]
		public NativeArray<byte> ERAXZLEAKWT(VARYPRXVVUX a)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xA228B80", Offset = "0xA227180", VA = "0x18A228B80")]
		[AsyncStateMachine(typeof(<GetBufferData>d__93))]
		private Task<MBXESCOTZRS> VXFCNRGJBFA(KFOQMVQOIBF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA2289B0", Offset = "0xA226FB0", VA = "0x18A2289B0")]
		private float UUYLHVQKXNX(List<double> a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xA225170", Offset = "0xA223770", VA = "0x18A225170")]
		[AsyncStateMachine(typeof(<GetNode>d__95))]
		private Task<GameObject> MKOYUAPWNEU(int a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xA222860", Offset = "0xA220E60", VA = "0x18A222860")]
		[AsyncStateMachine(typeof(<GetInstancesTRS>d__96))]
		private Task<(Vector3, Quaternion, Vector3)[]> GREVIMJBGZF(QPBKESVYPXS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA225080", Offset = "0xA223680", VA = "0x18A225080")]
		private bool LYZTAVYCBFO(QPBKESVYPXS a, GameObject b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA223C40", Offset = "0xA222240", VA = "0x18A223C40", Slot = "7")]
		[AsyncStateMachine(typeof(<ConstructNode>d__98))]
		protected virtual Task KGXCCHOZMNL(QPBKESVYPXS a, int b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xA222AD0", Offset = "0xA2210D0", VA = "0x18A222AD0")]
		[AsyncStateMachine(typeof(<ConstructBufferData>d__99))]
		private Task HMZYVXURLSD(QPBKESVYPXS a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xA220F20", Offset = "0xA21F520", VA = "0x18A220F20")]
		[AsyncStateMachine(typeof(<ConstructBuffer>d__100))]
		protected Task EMHWIXJYVMH(RUEBWFIIWST a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA222E70", Offset = "0xA221470", VA = "0x18A222E70", Slot = "8")]
		[AsyncStateMachine(typeof(<ConstructScene>d__101))]
		protected virtual Task ILYTQKDOKQT(HFFDYZWKXSX a, bool b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA22A8C0", Offset = "0xA228EC0", VA = "0x18A22A8C0", Slot = "9")]
		protected virtual MBXESCOTZRS ZFZOBHHKLGC(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA220100", Offset = "0xA21E700", VA = "0x18A220100")]
		private void Cleanup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA2261D0", Offset = "0xA2247D0", VA = "0x18A2261D0")]
		private void PTWXZJZYLJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA21F9E0", Offset = "0xA21DFE0", VA = "0x18A21F9E0")]
		[AsyncStateMachine(typeof(<SetupLoad>d__107))]
		private Task BOBBOLXZYOV(Func<Task> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA224AA0", Offset = "0xA2230A0", VA = "0x18A224AA0")]
		[AsyncStateMachine(typeof(<YieldOnTimeoutAndThrowOnLowMemory>d__108))]
		protected Task LFZPRMUFOZE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA222050", Offset = "0xA220650", VA = "0x18A222050")]
		private static string GCUYJZZIBHB(Transform a, Transform b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA225BE0", Offset = "0xA2241E0", VA = "0x18A225BE0", Slot = "10")]
		[AsyncStateMachine(typeof(<BuildAnimationSamplers>d__110))]
		protected virtual Task ODJGPXKMFAP(VJEIIZXANCJ a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xA2201B0", Offset = "0xA21E7B0", VA = "0x18A2201B0")]
		protected void DQDICKSSYQZ(AnimationClip a, string b, string[] c, NumericArray d, NumericArray e, InterpolationType f, Type g, ValuesConvertion h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xA21FBA0", Offset = "0xA21E1A0", VA = "0x18A21FBA0")]
		private void CPXTYEQRVHM(Keyframe[] a, int b, InterpolationType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xA2258D0", Offset = "0xA223ED0", VA = "0x18A2258D0")]
		private static float NZREDDFFIAO(Keyframe[] a, int b, bool c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xA2265A0", Offset = "0xA224BA0", VA = "0x18A2265A0")]
		[AsyncStateMachine(typeof(<ConstructClip>d__114))]
		protected Task<AnimationClip> QQCVREVFRYX(Transform a, int b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA223D80", Offset = "0xA222380", VA = "0x18A223D80")]
		private bool KLEAISURDRY(GameObject a, QPBKESVYPXS b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA228200", Offset = "0xA226800", VA = "0x18A228200")]
		private bool TDLVQBEEVQY(GameObject a, QPBKESVYPXS b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xA228A40", Offset = "0xA227040", VA = "0x18A228A40")]
		[AsyncStateMachine(typeof(<ConstructLods>d__117))]
		private Task VIODESJTBKJ(YBVGUQCSKJP a, GameObject b, QPBKESVYPXS c, int d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA220CA0", Offset = "0xA21F2A0", VA = "0x18A220CA0", Slot = "11")]
		[AsyncStateMachine(typeof(<ConstructMaterial>d__119))]
		protected virtual Task DYXPXJQBHVS(SWTHYRWJKEM a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA227040", Offset = "0xA225640", VA = "0x18A227040", Slot = "12")]
		protected virtual Task SBWMWBSPUDC(SWTHYRWJKEM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xA228850", Offset = "0xA226E50", VA = "0x18A228850", Slot = "13")]
		protected virtual YKTIIZGBCZZ TYKTHDPUVQN(SSGOAVDMOMX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xA226AA0", Offset = "0xA2250A0", VA = "0x18A226AA0", Slot = "14")]
		protected virtual KHR_materials_emissive_strength RKUUTKCLQSK(SWTHYRWJKEM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xA223B00", Offset = "0xA222100", VA = "0x18A223B00", Slot = "15")]
		protected virtual KHR_materials_transmission KDUSCZLGUFW(SWTHYRWJKEM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xA22A640", Offset = "0xA228C40", VA = "0x18A22A640", Slot = "16")]
		protected virtual KHR_materials_sheen XSXZCEUHGLX(SWTHYRWJKEM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xA22B930", Offset = "0xA229F30", VA = "0x18A22B930", Slot = "17")]
		protected virtual KHR_materials_anisotropy ZGYQNFIBBLK(SWTHYRWJKEM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xA22BCD0", Offset = "0xA22A2D0", VA = "0x18A22BCD0", Slot = "18")]
		protected virtual KHR_materials_dispersion ZRXUHQYUDVU(SWTHYRWJKEM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA222FA0", Offset = "0xA2215A0", VA = "0x18A222FA0", Slot = "19")]
		protected virtual KHR_materials_volume IQZBZBKUEAW(SWTHYRWJKEM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA225D00", Offset = "0xA224300", VA = "0x18A225D00", Slot = "20")]
		protected virtual KHR_materials_ior OPQTHXLXPBA(SWTHYRWJKEM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA2234C0", Offset = "0xA221AC0", VA = "0x18A2234C0", Slot = "21")]
		protected virtual KHR_materials_iridescence JRNJBMKWIUI(SWTHYRWJKEM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA21F8A0", Offset = "0xA21DEA0", VA = "0x18A21F8A0", Slot = "22")]
		protected virtual KHR_materials_specular BAOGUQATJZX(SWTHYRWJKEM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA223100", Offset = "0xA221700", VA = "0x18A223100", Slot = "23")]
		protected virtual KHR_materials_clearcoat JGAJJRDONXM(SWTHYRWJKEM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xA2260E0", Offset = "0xA2246E0", VA = "0x18A2260E0")]
		[AsyncStateMachine(typeof(<CreateMaterials>d__132))]
		private Task PNXIRELPQUS(TOEZEOEVPIK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xA2239D0", Offset = "0xA221FD0", VA = "0x18A2239D0", Slot = "24")]
		[AsyncStateMachine(typeof(<ConstructMesh>d__133))]
		protected virtual Task KBGOENTEQFS(BFGGSXOTTTO a, int b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xA220000", Offset = "0xA21E600", VA = "0x18A220000")]
		[AsyncStateMachine(typeof(<CreateMeshMaterials>d__134))]
		private Task CTNYNDEQEEF(BFGGSXOTTTO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xA2247B0", Offset = "0xA222DB0", VA = "0x18A2247B0")]
		private static uint[] LCOQDSKEWZU(BFGGSXOTTTO a, [Out] uint b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xA225650", Offset = "0xA223C50", VA = "0x18A225650")]
		protected void NMODCVZBPIZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xA21FD90", Offset = "0xA21E390", VA = "0x18A21FD90")]
		protected void CSVZBAOYDHH(Mesh a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xA221130", Offset = "0xA21F730", VA = "0x18A221130")]
		private GHNZIBVCRDK FVYJESGYTNS(BFGGSXOTTTO a, int b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA228C90", Offset = "0xA227290", VA = "0x18A228C90")]
		[AsyncStateMachine(typeof(<ConstructUnityMesh>d__139))]
		protected Task WEPMZKAVEPN(GHNZIBVCRDK a, int b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xA222BF0", Offset = "0xA2211F0", VA = "0x18A222BF0")]
		private void HSYCGGBBFGU(GHNZIBVCRDK a, int b, Mesh c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xA225AB0", Offset = "0xA2240B0", VA = "0x18A225AB0", Slot = "25")]
		[AsyncStateMachine(typeof(<ConstructMeshTargetsPrepareBuffers>d__141))]
		protected virtual Task ODATDQEOVXC(TOEZEOEVPIK a, int b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xA22A9D0", Offset = "0xA228FD0", VA = "0x18A22A9D0", Slot = "26")]
		protected virtual void ZGMIALETKMC(TOEZEOEVPIK a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xA222200", Offset = "0xA220800", VA = "0x18A222200")]
		private void GPURTNFENNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xA22A560", Offset = "0xA228B60", VA = "0x18A22A560")]
		[AsyncStateMachine(typeof(<PreparePrimitiveAttributes>d__144))]
		private Task XSTMCVCJAJP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xA22BA70", Offset = "0xA22A070", VA = "0x18A22BA70")]
		[AsyncStateMachine(typeof(<ConstructMeshAttributes>d__145))]
		private Task ZJXSZABWKXX(BFGGSXOTTTO a, RDRLREPEFYU b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xA225FA0", Offset = "0xA2245A0", VA = "0x18A225FA0", Slot = "27")]
		[AsyncStateMachine(typeof(<ConstructPrimitiveAttributes>d__146))]
		protected virtual Task PMFHLRWEKLF(TOEZEOEVPIK a, int b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xA229110", Offset = "0xA227710", VA = "0x18A229110")]
		protected void WZCLKOYYHCY(BFQECECDEFT.WEBXKBISNDH a, GHNZIBVCRDK b, uint c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xA224B70", Offset = "0xA223170", VA = "0x18A224B70")]
		private void LGYJKKQQCGG(Dictionary<string, UZAMOXUXDLF> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xA227E90", Offset = "0xA226490", VA = "0x18A227E90")]
		protected MeshTopology SOARXJEDKUR(DrawMode a)
		{
			return default(MeshTopology);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xA226BE0", Offset = "0xA2251E0", VA = "0x18A226BE0")]
		private void RPOYWPCMRVK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xA22BE10", Offset = "0xA22A410", VA = "0x18A22BE10", Slot = "28")]
		[AsyncStateMachine(typeof(<SetupBones>d__153))]
		protected virtual Task ZYCYFQWXUJS(SXIOEAXYCPD a, SkinnedMeshRenderer b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xA2243B0", Offset = "0xA2229B0", VA = "0x18A2243B0")]
		private void KULFYVBKGGH(Vector4[] a, Vector4[] b, BoneWeight[] c, uint d = 0u)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xA2252B0", Offset = "0xA2238B0", VA = "0x18A2252B0")]
		[AsyncStateMachine(typeof(<CreateNotReferencedTexture>d__158))]
		private Task MXLHUNCDJEB(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xA22A780", Offset = "0xA228D80", VA = "0x18A22A780")]
		[AsyncStateMachine(typeof(<FromTextureInfo>d__159))]
		private Task<XNXXYLGERIX> XWFLVAAXCNV(SSGOAVDMOMX a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0xA220150", Offset = "0xA21E750", VA = "0x18A220150")]
		private static int ComputeHash(byte[] data)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xA229FF0", Offset = "0xA2285F0", VA = "0x18A229FF0")]
		private Dictionary<int, int> XIPAAQGIIPR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xA224DB0", Offset = "0xA2233B0", VA = "0x18A224DB0")]
		private void LXRJFQTBXLY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xA220AC0", Offset = "0xA21F0C0", VA = "0x18A220AC0")]
		private Stream DXDQXEBNLJL(KISYKKNMMPI a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xA223380", Offset = "0xA221980", VA = "0x18A223380")]
		[AsyncStateMachine(typeof(<ConstructImage>d__164))]
		protected Task JOGBNYOKHAG(KISYKKNMMPI a, int b, bool c, bool d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xA226360", Offset = "0xA224960", VA = "0x18A226360")]
		[AsyncStateMachine(typeof(<ConstructImageBuffer>d__165))]
		protected Task QNPEOQSAHZW(RAXRAOUEMWM a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xA22A330", Offset = "0xA228930", VA = "0x18A22A330")]
		[AsyncStateMachine(typeof(<CheckMimeTypeAndLoadImage>d__166))]
		private Task<Texture2D> XPBKUDXPSIC(KISYKKNMMPI a, Texture2D b, NativeArray<byte> c, bool d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xA222990", Offset = "0xA220F90", VA = "0x18A222990", Slot = "29")]
		[AsyncStateMachine(typeof(<ConstructUnityTexture>d__167))]
		protected virtual Task HHFPUIXIMUN(Stream a, bool b, bool c, bool d, KISYKKNMMPI e, int f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA2254F0", Offset = "0xA223AF0", VA = "0x18A2254F0", Slot = "30")]
		protected virtual int NLUDKBFNKWL(RAXRAOUEMWM a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xA226FD0", Offset = "0xA2255D0", VA = "0x18A226FD0", Slot = "31")]
		protected virtual bool RRKBUYOHIVP(RAXRAOUEMWM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xA22BB90", Offset = "0xA22A190", VA = "0x18A22BB90", Slot = "32")]
		[AsyncStateMachine(typeof(<ConstructTexture>d__173))]
		protected virtual Task ZNTPWLOPTEQ(RAXRAOUEMWM a, int b, bool c, bool d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xA223240", Offset = "0xA221840", VA = "0x18A223240")]
		[AsyncStateMachine(typeof(<<GetInstancesTRS>g__GetAttrAccessorAndAccessorContent|96_0>d))]
		[CompilerGenerated]
		private Task<UZAMOXUXDLF> JOBFPKCWHXB(BGOSXQNMGFA a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA21F610", Offset = "0xA21DC10", VA = "0x18A21F610")]
		[CompilerGenerated]
		internal static UZAMOXUXDLF ARJCJJNLBRP(string a, <>c__DisplayClass114_0 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA225E40", Offset = "0xA224440", VA = "0x18A225E40")]
		[CompilerGenerated]
		private void OWXESAGQYFU(SXDMJXWDAIG a, YKTIIZGBCZZ b, [Out] Vector2 c, [Out] Vector2 d, <>c__DisplayClass119_0 e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xA22A490", Offset = "0xA228A90", VA = "0x18A22A490")]
		[CompilerGenerated]
		private void XSHDCRMSJRL(<>c__DisplayClass119_0 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA2241C0", Offset = "0xA2227C0", VA = "0x18A2241C0")]
		[CompilerGenerated]
		private void KPAWDOQNGKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA226700", Offset = "0xA224D00", VA = "0x18A226700")]
		[CompilerGenerated]
		private TextureWrapMode QQNOOMCULCP(GLTF.Schema.WrapMode a)
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
		private sealed class PCANQBYTROS<a> where a : GLTFPlugin
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			public Type SDIHDAMDFGL;

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public PCANQBYTROS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x5C7C570", Offset = "0x5C7AB70", VA = "0x185C7C570")]
			internal bool AFKXXQUAZXG(a a)
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
		public string HFFGQLYPMVL
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xA2479A0", Offset = "0xA245FA0", VA = "0x18A2479A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool FGZVZFMLKPU
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xAFD4E0", Offset = "0xAFBAE0", VA = "0x180AFD4E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0xAFD1B0", Offset = "0xAFB7B0", VA = "0x180AFD1B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool YCQUCYZRDNK
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xFC1340", Offset = "0xFBF940", VA = "0x180FC1340")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x100E010", Offset = "0x100C610", VA = "0x18100E010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BTRMEYDAPQF
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x1B3AAD0", Offset = "0x1B390D0", VA = "0x181B3AAD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x1B3AAE0", Offset = "0x1B390E0", VA = "0x181B3AAE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool BVJOISYBVRE
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xF83F40", Offset = "0xF82540", VA = "0x180F83F40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xF841A0", Offset = "0xF827A0", VA = "0x180F841A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool MTVSPAOAQGQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xF83F60", Offset = "0xF82560", VA = "0x180F83F60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xF84270", Offset = "0xF82870", VA = "0x180F84270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool MJSVXRDHBKQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x2A37960", Offset = "0x2A35F60", VA = "0x182A37960")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x2A37F80", Offset = "0x2A36580", VA = "0x182A37F80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public int CGEQEJFGEPC
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xAD6210", Offset = "0xAD4810", VA = "0x180AD6210")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xE799B0", Offset = "0xE77FB0", VA = "0x180E799B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool LIJOQNOLREU
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x232D580", Offset = "0x232BB80", VA = "0x18232D580")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x871DA80", Offset = "0x871C080", VA = "0x18871DA80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool QZLRFOBHUQF
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xF75580", Offset = "0xF73B80", VA = "0x180F75580")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x102BCC0", Offset = "0x102A2C0", VA = "0x18102BCC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool SVQRYJHYBXO
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x102B970", Offset = "0x1029F70", VA = "0x18102B970")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x102B2C0", Offset = "0x10298C0", VA = "0x18102B2C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		[Obsolete("Add/remove \"AnimationPointerPlugin\" from ExportPlugins instead.")]
		public bool XDCFKGHNBPG
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xA2479B0", Offset = "0xA245FB0", VA = "0x18A2479B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xA247AD0", Offset = "0xA2460D0", VA = "0x18A247AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool ZVYVCEDROQV
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x102B8C0", Offset = "0x1029EC0", VA = "0x18102B8C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x102B020", Offset = "0x1029620", VA = "0x18102B020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool YVDXLEJTJQW
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x1A25B40", Offset = "0x1A24140", VA = "0x181A25B40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x1A25C80", Offset = "0x1A24280", VA = "0x181A25C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public BlendShapeExportPropertyFlags TPTBCPLFSAX
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xAC4500", Offset = "0xAC2B00", VA = "0x180AC4500")]
			get
			{
				return default(BlendShapeExportPropertyFlags);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0xB89800", Offset = "0xB87E00", VA = "0x180B89800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool WMEGCZFIWPQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x9EA51C0", Offset = "0x9EA37C0", VA = "0x189EA51C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x9EBDC10", Offset = "0x9EBC210", VA = "0x189EBDC10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xA247480", Offset = "0xA245A80", VA = "0x18A247480")]
		internal string NGHBZGICBVD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xA246EE0", Offset = "0xA2454E0", VA = "0x18A246EE0")]
		public static GLTFSettings GetOrCreateSettings()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xA246E70", Offset = "0xA245470", VA = "0x18A246E70")]
		public static GLTFSettings GetDefaultSettings()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xA2476F0", Offset = "0xA245CF0", VA = "0x18A2476F0")]
		public static bool TryGetSettings([Out] GLTFSettings settings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0xA246DC0", Offset = "0xA2453C0", VA = "0x18A246DC0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ClearStatics()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA2470B0", Offset = "0xA2456B0", VA = "0x18A2470B0")]
		private static void HLSIEFEEQDB(GLTFSettings a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA2478B0", Offset = "0xA245EB0", VA = "0x18A2478B0")]
		public GLTFSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x38E3BF0", Offset = "0x38E21F0", VA = "0x1838E3BF0")]
		[CompilerGenerated]
		internal static List<Type> REZHEGUVWAC<a>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x38E3E30", Offset = "0x38E2430", VA = "0x1838E3E30")]
		[CompilerGenerated]
		internal static void RRXVOZPYGKI<b>(List<b> a) where b : GLTFPlugin
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class ShaderNotFoundException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xA24BF10", Offset = "0xA24A510", VA = "0x18A24BF10")]
		public ShaderNotFoundException()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA24BE60", Offset = "0xA24A460", VA = "0x18A24BE60")]
		public ShaderNotFoundException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xA24BEC0", Offset = "0xA24A4C0", VA = "0x18A24BEC0")]
		protected ShaderNotFoundException(SerializationInfo info, StreamingContext context)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class GLTFLoadException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA246D60", Offset = "0xA245360", VA = "0x18A246D60")]
		public GLTFLoadException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class HIFUYXXUAGV : ILogHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private readonly StringBuilder VAWYODTZVKJ;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA247D80", Offset = "0xA246380", VA = "0x18A247D80")]
		private string IUUITEKZMPR(LogType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xA247EA0", Offset = "0xA2464A0", VA = "0x18A247EA0", Slot = "4")]
		public void LogFormat(LogType logType, UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0xA247E00", Offset = "0xA246400", VA = "0x18A247E00", Slot = "5")]
		public void LogException(Exception exception, UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xA247F60", Offset = "0xA246560", VA = "0x18A247F60")]
		public void XDAOECYXAVK(string a = "{0}")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xA2480D0", Offset = "0xA2466D0", VA = "0x18A2480D0")]
		public HIFUYXXUAGV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class QFMLVQNUBWW
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA248860", Offset = "0xA246E60", VA = "0x18A248860")]
		public static string QZXHWSAERKQ(Uri a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xA2487F0", Offset = "0xA246DF0", VA = "0x18A2487F0")]
		public static string QLJVFMYZNGE(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xA2488C0", Offset = "0xA246EC0", VA = "0x18A2488C0")]
		public static void WLBDHDJJKSL(string a, [Out] byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xA248760", Offset = "0xA246D60", VA = "0x18A248760")]
		public static bool OMZBSOTTJTF(string a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class InstantiatedGLTFObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private DMUBFIANBSV QPKJCNHRSTU;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public DMUBFIANBSV XRSTLPHEBMW
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0xA248270", Offset = "0xA246870", VA = "0x18A248270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xA248140", Offset = "0xA246740", VA = "0x18A248140")]
		public InstantiatedGLTFObject Duplicate()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xA248220", Offset = "0xA246820", VA = "0x18A248220")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xAA6840", Offset = "0xAA4E40", VA = "0x180AA6840")]
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
		public float FSLKUQSHGIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0xA246740", Offset = "0xA244D40", VA = "0x18A246740")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xA2467C0", Offset = "0xA244DC0", VA = "0x18A2467C0")]
		public BlendShapeFrameWeightSetting(MultiplierOption option)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xA2467D0", Offset = "0xA244DD0", VA = "0x18A2467D0")]
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
		public abstract GLTFSceneImporter CreateSceneImporter(string gltfFileName, WPKHZAXWWKZ options);

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xDB5160", Offset = "0xDB3760", VA = "0x180DB5160")]
		protected ImporterFactory()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class DefaultImporterFactory : ImporterFactory
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xA246850", Offset = "0xA244E50", VA = "0x18A246850", Slot = "4")]
		public override GLTFSceneImporter CreateSceneImporter(string gltfFileName, WPKHZAXWWKZ options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xDB5160", Offset = "0xDB3760", VA = "0x180DB5160")]
		public DefaultImporterFactory()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	internal static class FBAOBIHZKWC
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xA2468C0", Offset = "0xA244EC0", VA = "0x18A2468C0")]
		internal static void LKZBBRDPJOD(this Material a, string b, bool c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class MaterialLibrary : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xDB5160", Offset = "0xDB3760", VA = "0x180DB5160")]
		public MaterialLibrary()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	internal static class KUHHYWRAGJQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class SPJGRQAUTAO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400031F")]
			public Texture2D AFYNWFJKCQU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			public Texture2D EEOYAONDPON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			public Color[] MNXNBQKREEZ;

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public SPJGRQAUTAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0xA24BB60", Offset = "0xA24A160", VA = "0x18A24BB60")]
			internal void PJWBUYDEMRX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0xA24BB10", Offset = "0xA24A110", VA = "0x18A24BB10")]
			internal void EJEOZVOFGZV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0xA24BDC0", Offset = "0xA24A3C0", VA = "0x18A24BDC0")]
			internal void YMXFLBXTXXX()
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
			private SPJGRQAUTAO <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0xA251E30", Offset = "0xA250430", VA = "0x18A251E30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0xA252450", Offset = "0xA250A50", VA = "0x18A252450", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xA2482D0", Offset = "0xA2468D0", VA = "0x18A2482D0")]
		[AsyncStateMachine(typeof(<ConvertToDxt5nmAndCheckTextureFormatAsync>d__0))]
		public static Task<Texture2D> XLECMTLRCZJ(Texture2D a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class GHNZIBVCRDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public bool[] GBZGAKMDXKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public Vector3[] MARIVJHPDDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public Vector3[] SVEYIBAODCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public Vector4[] TIJUMYBKQKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public Vector2[] RBJRGQMMZUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public Vector2[] RBEKJJSPQJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public Vector2[] RAZDMCYSGXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public Vector2[] RCJZSYHZUZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public Color[] BSPRTILFWOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public BoneWeight[] PJKEFGEEWMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public Vector3[][] FUBSILFKWAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public Vector3[][] GHYMEOIONSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public Vector3[][] HDDGOEPUFDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public MeshTopology[] YUFCOUBGJVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public DrawMode[] XFJMWRGJSNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public int[][] DXXPMGDNOKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public HashSet<int> OVVHXMOZONA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public uint[] LZXYSJEHSCG;

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xA246980", Offset = "0xA244F80", VA = "0x18A246980")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xA246A90", Offset = "0xA245090", VA = "0x18A246A90")]
		public bool GHIDNHOCLDO(GHNZIBVCRDK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xA246CE0", Offset = "0xA2452E0", VA = "0x18A246CE0")]
		public GHNZIBVCRDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x38DF9F0", Offset = "0x38DDFF0", VA = "0x1838DF9F0")]
		[CompilerGenerated]
		internal static bool WZHOFXJVJZM<a>(a[] a, a[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x38E0B60", Offset = "0x38DF160", VA = "0x1838E0B60")]
		[CompilerGenerated]
		internal static bool XEJBSXEACDP<b>(b[][] a, b[][] b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public abstract class YHGJMQXDVFR : XWGHBGDRRSJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		internal Material VUDPHIHDOTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private AlphaMode KHJFYOOBNKE;

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public static readonly int APMPLYUQVTL;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private static readonly int WDRGLMUENPO;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private static readonly int YLSWXMMWJQT;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private static readonly int SXUDLSCKLIK;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private static readonly int XPPGASGPLJO;

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private static readonly int EEBCGUGHDEX;

		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private static readonly int UJCGSFIUTOJ;

		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private static readonly int YEKWEQXPTRG;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private static readonly int HXXUHKJDEOQ;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private static readonly int IGIRNRMQJYD;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private static readonly int ZEULLFTOUPX;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private static readonly int EBUMNQUVXLE;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private static readonly int LEVKRZEHFFT;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private static readonly int VEBIOVKVYQB;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Material PRMMTXGXHIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public virtual AlphaMode BBSJAUILMRN
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0xA25ACD0", Offset = "0xA2592D0", VA = "0x18A25ACD0", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public double VTZIWWZBIFP
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0xA25A290", Offset = "0xA258890", VA = "0x18A25A290", Slot = "12")]
			get
			{
				return default(double);
			}
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0xA25A410", Offset = "0xA258A10", VA = "0x18A25A410", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public virtual bool MDQDCETBDHE
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0xA25A470", Offset = "0xA258A70", VA = "0x18A25A470", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public virtual bool IFDUDYAFMKP
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0xA25A620", Offset = "0xA258C20", VA = "0x18A25A620", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public Texture XSYLITIEEUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0xA25A3B0", Offset = "0xA2589B0", VA = "0x18A25A3B0", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int SNTTQDVGQHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0xA25A2E0", Offset = "0xA2588E0", VA = "0x18A25A2E0", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Vector2 SBNJNIUEZKT
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0xA25A550", Offset = "0xA258B50", VA = "0x18A25A550", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public double UAIEXQWUAGS
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0xA25A350", Offset = "0xA258950", VA = "0x18A25A350", Slot = "18")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Vector2 JCJZMQMLOXE
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0xA25A6A0", Offset = "0xA258CA0", VA = "0x18A25A6A0", Slot = "19")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public int HZTGWLEGYXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0xA25AC60", Offset = "0xA259260", VA = "0x18A25AC60", Slot = "20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public Color CDQIJHBSMVR
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xA25A5B0", Offset = "0xA258BB0", VA = "0x18A25A5B0", Slot = "21")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract XWGHBGDRRSJ Clone();

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
		protected YHGJMQXDVFR(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xA25B9C0", Offset = "0xA259FC0", VA = "0x18A25B9C0")]
		protected YHGJMQXDVFR(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xA25A700", Offset = "0xA258D00", VA = "0x18A25A700")]
		protected void SHUZGPKHNTE(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xA25AA90", Offset = "0xA259090", VA = "0x18A25AA90")]
		protected void UQRDZGINZOT(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xA25A7E0", Offset = "0xA258DE0", VA = "0x18A25A7E0")]
		protected void TKBTQKMPFMR(Material a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class OGYGXYSZEPN : LSXJVVMHKWN, IFSNSAVGWXL, MYJPYVSGRBQ, XWGHBGDRRSJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private Vector2 XTIZUYINYRB;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public virtual Texture XSYLITIEEUD
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xA248470", Offset = "0xA246A70", VA = "0x18A248470", Slot = "77")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public virtual int SNTTQDVGQHM
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "78")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public virtual Vector2 SBNJNIUEZKT
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0xA2484D0", Offset = "0xA246AD0", VA = "0x18A2484D0", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public virtual double UAIEXQWUAGS
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public virtual Vector2 JCJZMQMLOXE
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xA2485B0", Offset = "0xA246BB0", VA = "0x18A2485B0", Slot = "81")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public virtual int HZTGWLEGYXU
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "82")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public virtual Color CDQIJHBSMVR
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0xA248540", Offset = "0xA246B40", VA = "0x18A248540", Slot = "83")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public virtual Texture AKGSAGHCXUI
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0xA248640", Offset = "0xA246C40", VA = "0x18A248640", Slot = "84")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public virtual int ZIWGNJHVOUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public virtual Vector2 FYSIBOVBBXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "86")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public virtual double CVFRWMSJVLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual Vector2 IRGXLNGCOAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "88")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public virtual int QMDPGGGFSGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public virtual double OADGSHAITBY
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0xA2486F0", Offset = "0xA246CF0", VA = "0x18A2486F0", Slot = "90")]
			get
			{
				return default(double);
			}
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0xA248690", Offset = "0xA246C90", VA = "0x18A248690", Slot = "91")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public virtual double SXXFIZBAIBT
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "92")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xA248740", Offset = "0xA246D40", VA = "0x18A248740")]
		protected OGYGXYSZEPN(string a, string b, int c = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0xA248750", Offset = "0xA246D50", VA = "0x18A248750")]
		protected OGYGXYSZEPN(Material a, int b = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xA2483C0", Offset = "0xA2469C0", VA = "0x18A2483C0", Slot = "60")]
		public override XWGHBGDRRSJ Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class BLRYQWCQSSW : OGYGXYSZEPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private Vector2 RCETSZUWLKX;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public override int PCVVIVPJPMV
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "35")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public override int CHDEIIYAQZN
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public override int ZUVOSTGKYGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "49")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public override int SNTTQDVGQHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "78")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public override Texture AKGSAGHCXUI
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0xA246630", Offset = "0xA244C30", VA = "0x18A246630", Slot = "84")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public override int ZIWGNJHVOUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public override Vector2 FYSIBOVBBXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0xA2464D0", Offset = "0xA244AD0", VA = "0x18A2464D0", Slot = "86")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public override double CVFRWMSJVLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public override Vector2 IRGXLNGCOAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0xA246540", Offset = "0xA244B40", VA = "0x18A246540", Slot = "88")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public override int QMDPGGGFSGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public override double SXXFIZBAIBT
		{
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0xA2465D0", Offset = "0xA244BD0", VA = "0x18A2465D0", Slot = "92")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xA2466B0", Offset = "0xA244CB0", VA = "0x18A2466B0")]
		public BLRYQWCQSSW(string a, int b = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xA246720", Offset = "0xA244D20", VA = "0x18A246720")]
		protected BLRYQWCQSSW(Material a, int b = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xA246420", Offset = "0xA244A20", VA = "0x18A246420", Slot = "60")]
		public override XWGHBGDRRSJ Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class QWUYNMJPGHY : YHGJMQXDVFR, IFSNSAVGWXL, MYJPYVSGRBQ, XWGHBGDRRSJ, XYDSQUBGKJH, HSHWNWLFIPB, LVGYDKIEOCX, QWFHTBPVSFT, OQMKNSEXWPG, TXHYJCXYUEL, CBIUBESHVBD, WJTGDSNUYJU, WIZYEANETAL
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public Texture ZECGTXGCJIW
		{
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0xA249850", Offset = "0xA247E50", VA = "0x18A249850", Slot = "37")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0xA2495B0", Offset = "0xA247BB0", VA = "0x18A2495B0", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public int PCVVIVPJPMV
		{
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0xA24AA10", Offset = "0xA249010", VA = "0x18A24AA10", Slot = "39")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public double CQUALRYEQHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0xA24A710", Offset = "0xA248D10", VA = "0x18A24A710", Slot = "40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public Vector2 DRARTTOKWLQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0xA24A2E0", Offset = "0xA2488E0", VA = "0x18A24A2E0", Slot = "41")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public double NLZSKAEBDFV
		{
			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0xA249F80", Offset = "0xA248580", VA = "0x18A249F80", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public Vector2 LUGRTZMTVZH
		{
			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0xA24ABA0", Offset = "0xA2491A0", VA = "0x18A24ABA0", Slot = "43")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int SNCTKOPNXUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0xA249960", Offset = "0xA247F60", VA = "0x18A249960", Slot = "44")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public Texture BPRNSMXBCQA
		{
			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0xA24A160", Offset = "0xA248760", VA = "0x18A24A160", Slot = "45")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int CHDEIIYAQZN
		{
			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0xA24A580", Offset = "0xA248B80", VA = "0x18A24A580", Slot = "46")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public double GPPXCMGPFDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0xA24B5A0", Offset = "0xA249BA0", VA = "0x18A24B5A0", Slot = "47")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public Vector2 OUBFXPTHONW
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0xA24AF20", Offset = "0xA249520", VA = "0x18A24AF20", Slot = "48")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public double OYOJFMBYSGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0xA24A460", Offset = "0xA248A60", VA = "0x18A24A460", Slot = "49")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public Vector2 AQMCHSBOSJR
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0xA24AFE0", Offset = "0xA2495E0", VA = "0x18A24AFE0", Slot = "50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public int TTFLUYEYALD
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0xA24B410", Offset = "0xA249A10", VA = "0x18A24B410", Slot = "51")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Texture SGAZLIYIZLE
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0xA24AA80", Offset = "0xA249080", VA = "0x18A24AA80", Slot = "52")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public int ZUVOSTGKYGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0xA2498A0", Offset = "0xA247EA0", VA = "0x18A2498A0", Slot = "53")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Color OMWIJWZWQPC
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0xA249A90", Offset = "0xA248090", VA = "0x18A249A90", Slot = "54")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0xA24AC00", Offset = "0xA249200", VA = "0x18A24AC00", Slot = "55")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector2 KSTQJZTVNTI
		{
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0xA24AF80", Offset = "0xA249580", VA = "0x18A24AF80", Slot = "56")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public double TQVYXLWZCEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0xA249EC0", Offset = "0xA2484C0", VA = "0x18A249EC0", Slot = "57")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector2 MYDWCGBFDYF
		{
			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0xA24B600", Offset = "0xA249C00", VA = "0x18A24B600", Slot = "58")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public int NNJQNDWMDYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0xA24B230", Offset = "0xA249830", VA = "0x18A24B230", Slot = "59")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public Texture AKGSAGHCXUI
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0xA24AB40", Offset = "0xA249140", VA = "0x18A24AB40", Slot = "29")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public int ZIWGNJHVOUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0xA249FE0", Offset = "0xA2485E0", VA = "0x18A249FE0", Slot = "30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Vector2 FYSIBOVBBXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0xA249A30", Offset = "0xA248030", VA = "0x18A249A30", Slot = "31")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public double CVFRWMSJVLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0xA249BC0", Offset = "0xA2481C0", VA = "0x18A249BC0", Slot = "32")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Vector2 IRGXLNGCOAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0xA249D40", Offset = "0xA248340", VA = "0x18A249D40", Slot = "33")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public int QMDPGGGFSGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0xA24A340", Offset = "0xA248940", VA = "0x18A24A340", Slot = "34")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public double OADGSHAITBY
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0xA24ADA0", Offset = "0xA2493A0", VA = "0x18A24ADA0", Slot = "35")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public double SXXFIZBAIBT
		{
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0xA24AAE0", Offset = "0xA2490E0", VA = "0x18A24AAE0", Slot = "36")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public double XYUNIZFGIYN
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0xA24A400", Offset = "0xA248A00", VA = "0x18A24A400", Slot = "60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public Texture HEMLRWFLEAF
		{
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0xA24B290", Offset = "0xA249890", VA = "0x18A24B290", Slot = "61")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public double QPAEQJYREPZ
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0xA24A9B0", Offset = "0xA248FB0", VA = "0x18A24A9B0", Slot = "63")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public Vector2 LMWBEZMRMDM
		{
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0xA249150", Offset = "0xA247750", VA = "0x18A249150", Slot = "62")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public Vector2 JWEVXNOSODT
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0xA24A1C0", Offset = "0xA2487C0", VA = "0x18A24A1C0", Slot = "64")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public int UDBIOWSXGRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0xA2491B0", Offset = "0xA2477B0", VA = "0x18A2491B0", Slot = "65")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public double FLLGEITDUVB
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0xA249670", Offset = "0xA247C70", VA = "0x18A249670", Slot = "66")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Color WCUTKINXKGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0xA24ACD0", Offset = "0xA2492D0", VA = "0x18A24ACD0", Slot = "67")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public double RQMXQWXFYIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0xA24A7D0", Offset = "0xA248DD0", VA = "0x18A24A7D0", Slot = "68")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public Texture HDUXGBEKSST
		{
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0xA24A280", Offset = "0xA248880", VA = "0x18A24A280", Slot = "69")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public double QTCTHORMTXP
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0xA24AC70", Offset = "0xA249270", VA = "0x18A24AC70", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Vector2 YWREHLGKKXW
		{
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0xA249DA0", Offset = "0xA2483A0", VA = "0x18A249DA0", Slot = "70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Vector2 DDHSFJISNET
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0xA249610", Offset = "0xA247C10", VA = "0x18A249610", Slot = "72")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public int LCHXIWMDQAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0xA24A890", Offset = "0xA248E90", VA = "0x18A24A890", Slot = "73")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public double VVFNSXGOPRM
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0xA2496D0", Offset = "0xA247CD0", VA = "0x18A2496D0", Slot = "74")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public double VBEOZQYUPVR
		{
			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0xA24B720", Offset = "0xA249D20", VA = "0x18A24B720", Slot = "75")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public double KXNVDMJLYIW
		{
			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0xA249270", Offset = "0xA247870", VA = "0x18A249270", Slot = "76")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public double GQRYHZYJTXQ
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0xA24B6C0", Offset = "0xA249CC0", VA = "0x18A24B6C0", Slot = "77")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public double HHCPATNQZIM
		{
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0xA24B780", Offset = "0xA249D80", VA = "0x18A24B780", Slot = "78")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public Texture MESHJGOUWHR
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xA24AE60", Offset = "0xA249460", VA = "0x18A24AE60", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public double OPEEKFIKTVD
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0xA249390", Offset = "0xA247990", VA = "0x18A249390", Slot = "81")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public Vector2 DNNWFZRDSEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0xA24A4C0", Offset = "0xA248AC0", VA = "0x18A24A4C0", Slot = "80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public Vector2 NPAMFOBXYTJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0xA24B350", Offset = "0xA249950", VA = "0x18A24B350", Slot = "82")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public int GBIVJGBWCOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0xA24A8F0", Offset = "0xA248EF0", VA = "0x18A24A8F0", Slot = "83")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Texture DPLTDCYJAOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0xA249B60", Offset = "0xA248160", VA = "0x18A249B60", Slot = "84")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public double GUJMRNZOIMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0xA24AD40", Offset = "0xA249340", VA = "0x18A24AD40", Slot = "86")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public Vector2 OFNMNGNUWYO
		{
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0xA2497F0", Offset = "0xA247DF0", VA = "0x18A2497F0", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public Vector2 AQNWBYGABFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0xA249330", Offset = "0xA247930", VA = "0x18A249330", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public int ALMMVTRSRLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0xA24B110", Offset = "0xA249710", VA = "0x18A24B110", Slot = "88")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public double MFXMQHYZCOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0xA249790", Offset = "0xA247D90", VA = "0x18A249790", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public Texture DMSZVGNCKHK
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0xA24B040", Offset = "0xA249640", VA = "0x18A24B040", Slot = "90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public double WGSLDWEZOQO
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0xA249F20", Offset = "0xA248520", VA = "0x18A249F20", Slot = "92")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public Vector2 PLDTEMKXXQH
		{
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0xA24B1D0", Offset = "0xA2497D0", VA = "0x18A24B1D0", Slot = "91")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public Vector2 HHUBIDHFWOO
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xA24B2F0", Offset = "0xA2498F0", VA = "0x18A24B2F0", Slot = "93")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public int KSCIMPUHPBM
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xA2492D0", Offset = "0xA2478D0", VA = "0x18A2492D0", Slot = "94")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Color VPOVMCTMPAL
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0xA249020", Offset = "0xA247620", VA = "0x18A249020", Slot = "95")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Texture GEUIOGZFRSH
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0xA24A5F0", Offset = "0xA248BF0", VA = "0x18A24A5F0", Slot = "96")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public double DGCKSQFWBAV
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0xA249900", Offset = "0xA247F00", VA = "0x18A249900", Slot = "98")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public Vector2 PSRFACWIVKU
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0xA2490F0", Offset = "0xA2476F0", VA = "0x18A2490F0", Slot = "97")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public Vector2 IYHOQMMJAHZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0xA24A770", Offset = "0xA248D70", VA = "0x18A24A770", Slot = "99")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public int LEUQBSQPDRH
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0xA24AEC0", Offset = "0xA2494C0", VA = "0x18A24AEC0", Slot = "100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public double WULNYULRCFD
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0xA249090", Offset = "0xA247690", VA = "0x18A249090", Slot = "101")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public Texture IOTPAAGNPBX
		{
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0xA2499D0", Offset = "0xA247FD0", VA = "0x18A2499D0", Slot = "102")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public double LTUVPHFKLGH
		{
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0xA24B480", Offset = "0xA249A80", VA = "0x18A24B480", Slot = "104")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public Vector2 LBJFFZCMKTE
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0xA24A650", Offset = "0xA248C50", VA = "0x18A24A650", Slot = "103")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Vector2 EJGVFDSZTOB
		{
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0xA249B00", Offset = "0xA248100", VA = "0x18A249B00", Slot = "105")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public int JZKSULBRLUX
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0xA249C20", Offset = "0xA248220", VA = "0x18A249C20", Slot = "106")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public double CYDREPJMAYT
		{
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0xA249E00", Offset = "0xA248400", VA = "0x18A249E00", Slot = "107")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public Texture JLFHQGZPVTB
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0xA249E60", Offset = "0xA248460", VA = "0x18A249E60", Slot = "108")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public double FIFYUOPXSND
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0xA24A3A0", Offset = "0xA2489A0", VA = "0x18A24A3A0", Slot = "110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public Vector2 GRLTOPCUHKI
		{
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0xA24A040", Offset = "0xA248640", VA = "0x18A24A040", Slot = "109")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public Vector2 UGDEXQUKFIP
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0xA249550", Offset = "0xA247B50", VA = "0x18A249550", Slot = "111")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public int RNIVPOAKWUR
		{
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0xA24B170", Offset = "0xA249770", VA = "0x18A24B170", Slot = "112")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public float YIUEJQHYWTA
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0xA249210", Offset = "0xA247810", VA = "0x18A249210", Slot = "113")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public float IAVTBXWYQPM
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0xA24A950", Offset = "0xA248F50", VA = "0x18A24A950", Slot = "114")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public Color QYKUAVVGXQL
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0xA24B0A0", Offset = "0xA2496A0", VA = "0x18A24B0A0", Slot = "115")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public Texture ABOYZGHMRGX
		{
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0xA249C80", Offset = "0xA248280", VA = "0x18A249C80", Slot = "116")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public double SNALYGKSLVL
		{
			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0xA249CE0", Offset = "0xA2482E0", VA = "0x18A249CE0", Slot = "117")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public Vector2 QZTTBTNBNDC
		{
			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0xA24B660", Offset = "0xA249C60", VA = "0x18A24B660", Slot = "118")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public Vector2 KYQWZJZNPJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0xA24A6B0", Offset = "0xA248CB0", VA = "0x18A24A6B0", Slot = "119")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public int FCMTYECRHVP
		{
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0xA24A220", Offset = "0xA248820", VA = "0x18A24A220", Slot = "120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public Texture ATCNPDDKIUQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0xA24B540", Offset = "0xA249B40", VA = "0x18A24B540", Slot = "121")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public double DPWSJYNELHM
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0xA2494F0", Offset = "0xA247AF0", VA = "0x18A2494F0", Slot = "122")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public Vector2 EXENPVOMGYD
		{
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0xA24AE00", Offset = "0xA249400", VA = "0x18A24AE00", Slot = "123")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public Vector2 TWYHLXCMLZE
		{
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0xA24A520", Offset = "0xA248B20", VA = "0x18A24A520", Slot = "124")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public int ZSSCMPZHDEO
		{
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0xA24A830", Offset = "0xA248E30", VA = "0x18A24A830", Slot = "125")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public double AZBTAESPIWV
		{
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0xA24A0A0", Offset = "0xA2486A0", VA = "0x18A24A0A0", Slot = "131")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public double SUQDUVODKUG
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xA249730", Offset = "0xA247D30", VA = "0x18A249730", Slot = "132")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Texture TBWXHLAKIOH
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0xA24A100", Offset = "0xA248700", VA = "0x18A24A100", Slot = "126")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public double DOQMUFVGMJD
		{
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0xA24B4E0", Offset = "0xA249AE0", VA = "0x18A24B4E0", Slot = "128")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public Vector2 OEUWLHHFLWQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0xA248F60", Offset = "0xA247560", VA = "0x18A248F60", Slot = "127")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public Vector2 RHZPGVRXQQT
		{
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0xA248FC0", Offset = "0xA2475C0", VA = "0x18A248FC0", Slot = "129")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public int LJMQZEQIMTL
		{
			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0xA24B3B0", Offset = "0xA2499B0", VA = "0x18A24B3B0", Slot = "130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xA24B9A0", Offset = "0xA249FA0", VA = "0x18A24B9A0")]
		public QWUYNMJPGHY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xA24B850", Offset = "0xA249E50", VA = "0x18A24B850")]
		protected QWUYNMJPGHY(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xA24B7E0", Offset = "0xA249DE0", VA = "0x18A24B7E0")]
		public QWUYNMJPGHY(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xA2493F0", Offset = "0xA2479F0", VA = "0x18A2493F0", Slot = "10")]
		public override XWGHBGDRRSJ Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class QVAJSEMNBRO : LSXJVVMHKWN, KVORKFEEDAY, MYJPYVSGRBQ, XWGHBGDRRSJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private Vector2 FRTSIXPYEOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private Vector2 WWBBGTHGLGQ;

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public virtual Texture NKQQJBIPBXH
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0xA248DC0", Offset = "0xA2473C0", VA = "0x18A248DC0", Slot = "77")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public virtual int HGQAIJFSKBG
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "78")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public virtual Vector2 NLMIGTAKYKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0xA248E20", Offset = "0xA247420", VA = "0x18A248E20", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public virtual double XOLQICKPIOU
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public virtual Vector2 TMKNGKDEJEE
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0xA248D30", Offset = "0xA247330", VA = "0x18A248D30", Slot = "81")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public virtual int FPSPTSFLVII
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "82")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public virtual Color OPKYUDYKCNX
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0xA248CC0", Offset = "0xA2472C0", VA = "0x18A248CC0", Slot = "83")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public virtual Texture XBWFDNQNYZE
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0xA248A60", Offset = "0xA247060", VA = "0x18A248A60", Slot = "84")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public virtual int RPNHDFCOBUJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public virtual Vector2 WSKFPCWJKSO
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xA248C50", Offset = "0xA247250", VA = "0x18A248C50", Slot = "86")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public virtual double AMEGLMHXBUD
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public virtual Vector2 QXNKWIRDJBD
		{
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0xA248E90", Offset = "0xA247490", VA = "0x18A248E90", Slot = "88")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public virtual int EAFKJZCDDVV
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public virtual Vector3 MFXMQHYZCOG
		{
			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0xA248BC0", Offset = "0xA2471C0", VA = "0x18A248BC0", Slot = "90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public virtual double YZEGIUBLLHX
		{
			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0xA2489D0", Offset = "0xA246FD0", VA = "0x18A2489D0", Slot = "91")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0xA248F20", Offset = "0xA247520", VA = "0x18A248F20")]
		protected QVAJSEMNBRO(string a, string b, int c = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0xA248F40", Offset = "0xA247540", VA = "0x18A248F40")]
		protected QVAJSEMNBRO(Material a, int b = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xA248B10", Offset = "0xA247110", VA = "0x18A248B10", Slot = "60")]
		public override XWGHBGDRRSJ Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class WRONTMXFAWX : QVAJSEMNBRO
	{
		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public override int PCVVIVPJPMV
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "35")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public override int CHDEIIYAQZN
		{
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public override int ZUVOSTGKYGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "49")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public override int HGQAIJFSKBG
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "78")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public override int RPNHDFCOBUJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xA26D9F0", Offset = "0xA26BFF0", VA = "0x18A26D9F0")]
		public WRONTMXFAWX(string a, int b = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xA26D9E0", Offset = "0xA26BFE0", VA = "0x18A26D9E0")]
		protected WRONTMXFAWX(Material a, int b = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xA26D8D0", Offset = "0xA26BED0", VA = "0x18A26D8D0", Slot = "60")]
		public override XWGHBGDRRSJ Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class LSXJVVMHKWN : MYJPYVSGRBQ, XWGHBGDRRSJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		protected Material VUDPHIHDOTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private AlphaMode KHJFYOOBNKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private double VOKDKAVKTWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private Vector2 MZIZFTMWGJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private Vector2 JMYJMPEJZIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private Vector2 QALJEZJKEBS;

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public Material PRMMTXGXHIN
		{
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public virtual Texture ZECGTXGCJIW
		{
			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0xA267980", Offset = "0xA265F80", VA = "0x18A267980", Slot = "33")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0xA2678A0", Offset = "0xA265EA0", VA = "0x18A2678A0", Slot = "34")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public virtual int PCVVIVPJPMV
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "35")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public virtual Vector2 DRARTTOKWLQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0xA267B50", Offset = "0xA266150", VA = "0x18A267B50", Slot = "36")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public virtual double NLZSKAEBDFV
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "37")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public virtual Vector2 LUGRTZMTVZH
		{
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0xA267EE0", Offset = "0xA2664E0", VA = "0x18A267EE0", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public virtual int SNCTKOPNXUD
		{
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "39")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public virtual double CQUALRYEQHM
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xA267D40", Offset = "0xA266340", VA = "0x18A267D40", Slot = "40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public virtual Texture BPRNSMXBCQA
		{
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0xA267A90", Offset = "0xA266090", VA = "0x18A267A90", Slot = "41")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public virtual int CHDEIIYAQZN
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public virtual Vector2 OUBFXPTHONW
		{
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0xA268020", Offset = "0xA266620", VA = "0x18A268020", Slot = "43")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public virtual double OYOJFMBYSGR
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "44")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public virtual Vector2 AQMCHSBOSJR
		{
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0xA268100", Offset = "0xA266700", VA = "0x18A268100", Slot = "45")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public virtual int TTFLUYEYALD
		{
			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "46")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		public virtual double GPPXCMGPFDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0xA268620", Offset = "0xA266C20", VA = "0x18A268620", Slot = "47")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public virtual Texture SGAZLIYIZLE
		{
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0xA267E00", Offset = "0xA266400", VA = "0x18A267E00", Slot = "48")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public virtual int ZUVOSTGKYGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "49")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public virtual Vector2 KSTQJZTVNTI
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xA268090", Offset = "0xA266690", VA = "0x18A268090", Slot = "50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public virtual double TQVYXLWZCEP
		{
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "51")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public virtual Vector2 MYDWCGBFDYF
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xA2686E0", Offset = "0xA266CE0", VA = "0x18A2686E0", Slot = "52")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public virtual int NNJQNDWMDYP
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "53")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public virtual Color OMWIJWZWQPC
		{
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0xA2679F0", Offset = "0xA265FF0", VA = "0x18A2679F0", Slot = "54")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0xA267F70", Offset = "0xA266570", VA = "0x18A267F70", Slot = "55")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public virtual AlphaMode BBSJAUILMRN
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0xA268190", Offset = "0xA266790", VA = "0x18A268190", Slot = "56")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		public virtual double VTZIWWZBIFP
		{
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0xA267BC0", Offset = "0xA2661C0", VA = "0x18A267BC0", Slot = "57")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public virtual bool MDQDCETBDHE
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0xA267C50", Offset = "0xA266250", VA = "0x18A267C50", Slot = "58")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		public virtual bool IFDUDYAFMKP
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0xA267CC0", Offset = "0xA2662C0", VA = "0x18A267CC0", Slot = "59")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xA268890", Offset = "0xA266E90", VA = "0x18A268890")]
		protected LSXJVVMHKWN(string a, string b, int c = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xA268770", Offset = "0xA266D70", VA = "0x18A268770")]
		protected LSXJVVMHKWN(Material a, int b = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xA267670", Offset = "0xA265C70", VA = "0x18A267670", Slot = "60")]
		public virtual XWGHBGDRRSJ Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xA267800", Offset = "0xA265E00", VA = "0x18A267800", Slot = "61")]
		protected virtual void Copy(MYJPYVSGRBQ o)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public interface XWGHBGDRRSJ
	{
		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		Material PRMMTXGXHIN
		{
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		AlphaMode BBSJAUILMRN
		{
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		double VTZIWWZBIFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		bool MDQDCETBDHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		bool IFDUDYAFMKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(Slot = "5")]
		XWGHBGDRRSJ Clone();
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public interface MYJPYVSGRBQ : XWGHBGDRRSJ
	{
		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		Texture ZECGTXGCJIW
		{
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		int PCVVIVPJPMV
		{
			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		double CQUALRYEQHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		Vector2 DRARTTOKWLQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		double NLZSKAEBDFV
		{
			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		Vector2 LUGRTZMTVZH
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		int SNCTKOPNXUD
		{
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		Texture BPRNSMXBCQA
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		int CHDEIIYAQZN
		{
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FE")]
		double GPPXCMGPFDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FF")]
		Vector2 OUBFXPTHONW
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000100")]
		double OYOJFMBYSGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000101")]
		Vector2 AQMCHSBOSJR
		{
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000102")]
		int TTFLUYEYALD
		{
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		Texture SGAZLIYIZLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(Slot = "15")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		int ZUVOSTGKYGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(Slot = "16")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		Color OMWIJWZWQPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(Slot = "18")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		Vector2 KSTQJZTVNTI
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(Slot = "19")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000107")]
		double TQVYXLWZCEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(Slot = "20")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		Vector2 MYDWCGBFDYF
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(Slot = "21")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		int NNJQNDWMDYP
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(Slot = "22")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public interface IFSNSAVGWXL : MYJPYVSGRBQ, XWGHBGDRRSJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		Texture XSYLITIEEUD
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		int SNTTQDVGQHM
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		Vector2 SBNJNIUEZKT
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		double UAIEXQWUAGS
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010E")]
		Vector2 JCJZMQMLOXE
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010F")]
		int HZTGWLEGYXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000110")]
		Color CDQIJHBSMVR
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		Texture AKGSAGHCXUI
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		int ZIWGNJHVOUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		Vector2 FYSIBOVBBXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		double CVFRWMSJVLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000115")]
		Vector2 IRGXLNGCOAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		int QMDPGGGFSGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		double OADGSHAITBY
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000118")]
		double SXXFIZBAIBT
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public interface XYDSQUBGKJH : IFSNSAVGWXL, MYJPYVSGRBQ, XWGHBGDRRSJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000119")]
		double XYUNIZFGIYN
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		Texture HEMLRWFLEAF
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		Vector2 LMWBEZMRMDM
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		double QPAEQJYREPZ
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		Vector2 JWEVXNOSODT
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		int UDBIOWSXGRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		double FLLGEITDUVB
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		Color WCUTKINXKGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public interface HSHWNWLFIPB : IFSNSAVGWXL, MYJPYVSGRBQ, XWGHBGDRRSJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000121")]
		double RQMXQWXFYIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		Texture HDUXGBEKSST
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		Vector2 YWREHLGKKXW
		{
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		double QTCTHORMTXP
		{
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		Vector2 DDHSFJISNET
		{
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		int LCHXIWMDQAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public interface WJTGDSNUYJU : IFSNSAVGWXL, MYJPYVSGRBQ, XWGHBGDRRSJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000127")]
		float IAVTBXWYQPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		Color QYKUAVVGXQL
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		Texture ABOYZGHMRGX
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		double SNALYGKSLVL
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012B")]
		Vector2 QZTTBTNBNDC
		{
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012C")]
		Vector2 KYQWZJZNPJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		int FCMTYECRHVP
		{
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012E")]
		Texture ATCNPDDKIUQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012F")]
		double DPWSJYNELHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000130")]
		Vector2 EXENPVOMGYD
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		Vector2 TWYHLXCMLZE
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		int ZSSCMPZHDEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public interface CBIUBESHVBD : HSHWNWLFIPB, IFSNSAVGWXL, MYJPYVSGRBQ, XWGHBGDRRSJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000133")]
		float YIUEJQHYWTA
		{
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public interface LVGYDKIEOCX : IFSNSAVGWXL, MYJPYVSGRBQ, XWGHBGDRRSJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000134")]
		double VVFNSXGOPRM
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public interface OQMKNSEXWPG : IFSNSAVGWXL, MYJPYVSGRBQ, XWGHBGDRRSJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000135")]
		double MFXMQHYZCOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		Texture DMSZVGNCKHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		Vector2 PLDTEMKXXQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		double WGSLDWEZOQO
		{
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		Vector2 HHUBIDHFWOO
		{
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013A")]
		int KSCIMPUHPBM
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013B")]
		Color VPOVMCTMPAL
		{
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013C")]
		Texture GEUIOGZFRSH
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013D")]
		Vector2 PSRFACWIVKU
		{
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013E")]
		double DGCKSQFWBAV
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013F")]
		Vector2 IYHOQMMJAHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000140")]
		int LEUQBSQPDRH
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public interface QWFHTBPVSFT : IFSNSAVGWXL, MYJPYVSGRBQ, XWGHBGDRRSJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000141")]
		double VBEOZQYUPVR
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000142")]
		double KXNVDMJLYIW
		{
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		double GQRYHZYJTXQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		double HHCPATNQZIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		Texture MESHJGOUWHR
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000146")]
		Vector2 DNNWFZRDSEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		double OPEEKFIKTVD
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		Vector2 NPAMFOBXYTJ
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		int GBIVJGBWCOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		Texture DPLTDCYJAOF
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		Vector2 OFNMNGNUWYO
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		double GUJMRNZOIMD
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		Vector2 AQNWBYGABFH
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		int ALMMVTRSRLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public interface KVORKFEEDAY : MYJPYVSGRBQ, XWGHBGDRRSJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		Texture NKQQJBIPBXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		int HGQAIJFSKBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		Vector2 NLMIGTAKYKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		double XOLQICKPIOU
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		Vector2 TMKNGKDEJEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000154")]
		int FPSPTSFLVII
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000155")]
		Color OPKYUDYKCNX
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		Texture XBWFDNQNYZE
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		int RPNHDFCOBUJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000158")]
		Vector2 WSKFPCWJKSO
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		double AMEGLMHXBUD
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		Vector2 QXNKWIRDJBD
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		int EAFKJZCDDVV
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		Vector3 MFXMQHYZCOG
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		double YZEGIUBLLHX
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public interface TXHYJCXYUEL : IFSNSAVGWXL, MYJPYVSGRBQ, XWGHBGDRRSJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		double WULNYULRCFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		Texture IOTPAAGNPBX
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000160")]
		Vector2 LBJFFZCMKTE
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		double LTUVPHFKLGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		Vector2 EJGVFDSZTOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		int JZKSULBRLUX
		{
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		double CYDREPJMAYT
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		Texture JLFHQGZPVTB
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		Vector2 GRLTOPCUHKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		double FIFYUOPXSND
		{
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000168")]
		Vector2 UGDEXQUKFIP
		{
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		int RNIVPOAKWUR
		{
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public interface XNFBIHXGYUK
	{
		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		Texture CGMQUTGPOVO
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700016B")]
		Vector2 OLGGTCZKOMT
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		double SNGEDUBICLQ
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700016D")]
		Vector2 HACFCLNNOUK
		{
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700016E")]
		int BTGMYBODPOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public interface WIZYEANETAL
	{
		[Cpp2IlInjected.Token(Token = "0x1700016F")]
		Texture TBWXHLAKIOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000170")]
		Vector2 OEUWLHHFLWQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000171")]
		double DOQMUFVGMJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000172")]
		Vector2 RHZPGVRXQQT
		{
			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000173")]
		int LJMQZEQIMTL
		{
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000174")]
		double AZBTAESPIWV
		{
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000175")]
		double SUQDUVODKUG
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public interface WSKIYUJIIBZ : XWGHBGDRRSJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000176")]
		Texture XSYLITIEEUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000177")]
		int SNTTQDVGQHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000178")]
		Vector2 SBNJNIUEZKT
		{
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000179")]
		double UAIEXQWUAGS
		{
			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700017A")]
		Vector2 JCJZMQMLOXE
		{
			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700017B")]
		int HZTGWLEGYXU
		{
			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700017C")]
		Color CDQIJHBSMVR
		{
			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class ZYENOCOSFIG : YHGJMQXDVFR, WSKIYUJIIBZ, XWGHBGDRRSJ
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xA26DC20", Offset = "0xA26C220", VA = "0x18A26DC20")]
		public ZYENOCOSFIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xA26DBB0", Offset = "0xA26C1B0", VA = "0x18A26DBB0")]
		protected ZYENOCOSFIG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0xA26DB50", Offset = "0xA26C150", VA = "0x18A26DB50")]
		public ZYENOCOSFIG(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xA26DA60", Offset = "0xA26C060", VA = "0x18A26DA60", Slot = "10")]
		public override XWGHBGDRRSJ Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class CBJQFUZLXGG : LSXJVVMHKWN, WSKIYUJIIBZ, XWGHBGDRRSJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private Vector2 XTIZUYINYRB;

		[Cpp2IlInjected.Token(Token = "0x1700017D")]
		public Texture XSYLITIEEUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0xA260190", Offset = "0xA25E790", VA = "0x18A260190", Slot = "62")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017E")]
		public virtual int SNTTQDVGQHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "69")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017F")]
		public virtual Vector2 SBNJNIUEZKT
		{
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0xA2601F0", Offset = "0xA25E7F0", VA = "0x18A2601F0", Slot = "70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000180")]
		public virtual double UAIEXQWUAGS
		{
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000181")]
		public virtual Vector2 JCJZMQMLOXE
		{
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0xA2602D0", Offset = "0xA25E8D0", VA = "0x18A2602D0", Slot = "72")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000182")]
		public virtual int HZTGWLEGYXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "73")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000183")]
		public virtual Color CDQIJHBSMVR
		{
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0xA260260", Offset = "0xA25E860", VA = "0x18A260260", Slot = "74")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xA260360", Offset = "0xA25E960", VA = "0x18A260360")]
		public CBJQFUZLXGG(string a, string b, int c = 1000)
		{
		}
	}
}
namespace UnityGLTF.Timeline
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class NCPEFBXMBJR
	{
		[Cpp2IlInjected.Token(Token = "0x2000092")]
		public delegate void OnBeforeAddAnimationDataDelegate(EEYKAOULRTO animationData);

		[Cpp2IlInjected.Token(Token = "0x2000093")]
		public delegate void OnPostExportDelegate(JWJLEDJAGZL animationData);

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		public class JWJLEDJAGZL
		{
			[Cpp2IlInjected.Token(Token = "0x17000186")]
			private Bounds NNVJRKOUHJG
			{
				[Cpp2IlInjected.Token(Token = "0x60003AA")]
				[Cpp2IlInjected.Address(RVA = "0x93DAC10", Offset = "0x93D9210", VA = "0x1893DAC10")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000187")]
			private GLTFSceneExporter MYZEUEJMZYV
			{
				[Cpp2IlInjected.Token(Token = "0x60003AB")]
				[Cpp2IlInjected.Address(RVA = "0xAA8690", Offset = "0xAA6C90", VA = "0x180AA8690")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000188")]
			private YBVGUQCSKJP CUUGRAUESMR
			{
				[Cpp2IlInjected.Token(Token = "0x60003AC")]
				[Cpp2IlInjected.Address(RVA = "0xAAA9B0", Offset = "0xAA8FB0", VA = "0x180AAA9B0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0xA266530", Offset = "0xA264B30", VA = "0x18A266530")]
			internal JWJLEDJAGZL(Bounds a, GLTFSceneExporter b, YBVGUQCSKJP c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		public class EEYKAOULRTO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			internal AnimationData.KCSIGIWXJLV VDLULFSEQTH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			public float[] OJTYEUBFDWW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public object[] LMDACHOVTPE;

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0xE38300", Offset = "0xE36900", VA = "0x180E38300")]
			internal EEYKAOULRTO(AnimationData.KCSIGIWXJLV a, float[] b, object[] c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000096")]
		internal class AnimationData
		{
			[Cpp2IlInjected.Token(Token = "0x2000097")]
			internal class WDCOQGYTKSB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000372")]
				public string AKGWDPRRAGW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000373")]
				public Type JCQIRMGZPIE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000374")]
				public Func<Transform, UnityEngine.Object> FRRPZULVDSF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000375")]
				public Func<Transform, UnityEngine.Object, AnimationData, object> LRFVAQDYLRG;

				[Cpp2IlInjected.Token(Token = "0x60003B2")]
				[Cpp2IlInjected.Address(RVA = "0x1183DB0", Offset = "0x11823B0", VA = "0x181183DB0")]
				public WDCOQGYTKSB(string a, Type b, Func<Transform, UnityEngine.Object> c, Func<Transform, UnityEngine.Object, AnimationData, object> d)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003B3")]
				[Cpp2IlInjected.Address(RVA = "0xA26D740", Offset = "0xA26BD40", VA = "0x18A26D740")]
				public object FATBUFCYLNM(AnimationData a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000098")]
			internal class KCSIGIWXJLV
			{
				[Cpp2IlInjected.Token(Token = "0x2000099")]
				private class OLHLSIYCXEX
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400037B")]
					public double RKBUCJXUHFT;

					[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
					[Cpp2IlInjected.Token(Token = "0x400037C")]
					public object ZXQVAYEVMSN;

					[Cpp2IlInjected.Token(Token = "0x60003BA")]
					[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
					public OLHLSIYCXEX()
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000376")]
				private AnimationData BEWLHSJLUFY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000377")]
				private WDCOQGYTKSB DPIFOVBOBQX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000378")]
				private Dictionary<double, object> AAHTEGEPSOP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000379")]
				private OLHLSIYCXEX XJSILKEBMKO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400037A")]
				private OLHLSIYCXEX HFNUKUBFUZJ;

				[Cpp2IlInjected.Token(Token = "0x17000189")]
				public UnityEngine.Object EJIJNDDSXFA
				{
					[Cpp2IlInjected.Token(Token = "0x60003B4")]
					[Cpp2IlInjected.Address(RVA = "0xA266850", Offset = "0xA264E50", VA = "0x18A266850")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018A")]
				public string AKGWDPRRAGW
				{
					[Cpp2IlInjected.Token(Token = "0x60003B5")]
					[Cpp2IlInjected.Address(RVA = "0x2A387D0", Offset = "0x2A36DD0", VA = "0x182A387D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018B")]
				public float[] TYDIFTDMKSK
				{
					[Cpp2IlInjected.Token(Token = "0x60003B6")]
					[Cpp2IlInjected.Address(RVA = "0xA266890", Offset = "0xA264E90", VA = "0x18A266890")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018C")]
				public object[] EJHSPXJBXKG
				{
					[Cpp2IlInjected.Token(Token = "0x60003B7")]
					[Cpp2IlInjected.Address(RVA = "0xA2667F0", Offset = "0xA264DF0", VA = "0x18A2667F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60003B8")]
				[Cpp2IlInjected.Address(RVA = "0xA2669F0", Offset = "0xA264FF0", VA = "0x18A2669F0")]
				public KCSIGIWXJLV(AnimationData a, WDCOQGYTKSB b, double c)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003B9")]
				[Cpp2IlInjected.Address(RVA = "0xA2665A0", Offset = "0xA264BA0", VA = "0x18A2665A0")]
				public void LAVOCDFDFZN(double a)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			internal Transform BEWLHSJLUFY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			private SkinnedMeshRenderer VBISMTSBEAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			private bool LFZNQKRQILE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			private bool DHYURWGQLUB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			private bool YGOAZZOTYGW;

			[Cpp2IlInjected.Token(Token = "0x400036F")]
			private static List<WDCOQGYTKSB> NKZWJSPKTQG;

			[Cpp2IlInjected.Token(Token = "0x4000370")]
			private static MaterialPropertyBlock PMXCUYYVLFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			internal List<KCSIGIWXJLV> DAKEQVYGWMU;

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0xA25BF20", Offset = "0xA25A520", VA = "0x18A25BF20")]
			public AnimationData(Transform tr, double time, bool zeroScale = false, bool recordBlendShapes = true, bool inWorldSpace = false, bool recordAnimationPointer = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0xA25BD80", Offset = "0xA25A380", VA = "0x18A25BD80")]
			public void Update(double time)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		internal ICollection<Transform> PBZLDPPJJEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private Transform UPYDKJXZEYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private Dictionary<Transform, AnimationData> QHPHTAHQMYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private double LLANFXHUDFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private double IRUIYIGHIWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		private bool FEYLAQCFJHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		private bool MYUTUSLINFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private readonly bool LFZNQKRQILE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private readonly bool YQXAGGKXCLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private readonly bool YGOAZZOTYGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public string VEXJUKMXEDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public OnBeforeAddAnimationDataDelegate AHJUJVQOFPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public OnPostExportDelegate TFCYEFNWAIJ;

		[Cpp2IlInjected.Token(Token = "0x4000361")]
		private static ProfilerMarker CFOIWXMOXIT;

		[Cpp2IlInjected.Token(Token = "0x4000362")]
		private static ProfilerMarker YLFDEEGBCDU;

		[Cpp2IlInjected.Token(Token = "0x4000363")]
		private static ProfilerMarker OSUYMQQPRID;

		[Cpp2IlInjected.Token(Token = "0x17000184")]
		public bool HCYFJDIQQFZ
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x1B792D0", Offset = "0x1B778D0", VA = "0x181B792D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000185")]
		public double YOWPOYGMNEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0xE8CC00", Offset = "0xE8B200", VA = "0x180E8CC00")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0xA26A570", Offset = "0xA268B70", VA = "0x18A26A570")]
		public NCPEFBXMBJR(Transform a, bool b = true, bool c = false, bool d = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xA268F20", Offset = "0xA267520", VA = "0x18A268F20")]
		private bool BMOUTABFRJO(Transform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0xA2692B0", Offset = "0xA2678B0", VA = "0x18A2692B0")]
		public void JEHWXRDLXSH(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xA268FE0", Offset = "0xA2675E0", VA = "0x18A268FE0")]
		public void FXKDQHPLPZC(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xA2694F0", Offset = "0xA267AF0", VA = "0x18A2694F0")]
		public void OWFAGTTTOSA(string a, string b = "scene", [Optional] GLTFSettings c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xA269660", Offset = "0xA267C60", VA = "0x18A269660")]
		public void OWFAGTTTOSA(Stream a, string b = "scene", [Optional] GLTFSettings c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xA269D30", Offset = "0xA268330", VA = "0x18A269D30")]
		private void OWMNAYXUCUA(GLTFSceneExporter a, YBVGUQCSKJP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xA269F30", Offset = "0xA268530", VA = "0x18A269F30")]
		private void QFTYMTOVLHE(GLTFSceneExporter a, VJEIIZXANCJ b, bool c, [Out] Bounds d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public class GLTFRecorderBehaviour : PlayableBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class TBDIAOPJOEZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			public GLTFRecorderBehaviour CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			public double RKBUCJXUHFT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			public Playable IKZTFJFAEGS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			public FrameData PCGFXAEHCYE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			public object INRFEEIONHD;

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public TBDIAOPJOEZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0xA26B5B0", Offset = "0xA269BB0", VA = "0x18A26B5B0")]
			internal void AIAXXUSDEIQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private NCPEFBXMBJR RWRPJINMKKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public GLTFRecorderClip Clip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private bool JCBOFIPTNRU;

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xA264C80", Offset = "0xA263280", VA = "0x18A264C80")]
		private void HUXRFOZRLXK(double a, Transform b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0xA264D50", Offset = "0xA263350", VA = "0x18A264D50")]
		private void JNSSINAAJPB(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xA2651C0", Offset = "0xA2637C0", VA = "0x18A2651C0")]
		private void QWDUIYMXFQA(double a, Transform b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350")]
		private static bool LWJRMPTXATI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xA264FE0", Offset = "0xA2635E0", VA = "0x18A264FE0", Slot = "16")]
		public override void OnPlayableDestroy(Playable playable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0xA264DB0", Offset = "0xA2633B0", VA = "0x18A264DB0", Slot = "13")]
		public override void OnGraphStart(Playable playable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xA264F40", Offset = "0xA263540", VA = "0x18A264F40", Slot = "14")]
		public override void OnGraphStop(Playable playable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xA265080", Offset = "0xA263680", VA = "0x18A265080", Slot = "20")]
		public override void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x1AD0A60", Offset = "0x1ACF060", VA = "0x181AD0A60", Slot = "17")]
		public override void OnBehaviourPlay(Playable playable, FrameData info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x1879C70", Offset = "0x1878270", VA = "0x181879C70", Slot = "18")]
		public override void OnBehaviourPause(Playable playable, FrameData info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xA264B40", Offset = "0xA263140", VA = "0x18A264B40")]
		public void GFZNVLVBNYT(double a, Playable b, FrameData c, object d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAC4500", Offset = "0xAC2B00", VA = "0x180AC4500", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(ClipCaps);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0xA265400", Offset = "0xA263A00", VA = "0x18A265400", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xA265510", Offset = "0xA263B10", VA = "0x18A265510")]
		public Transform GetExportRoot(PlayableGraph graph)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xA265570", Offset = "0xA263B70", VA = "0x18A265570")]
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
		private sealed class HEXAKSDZXRV : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			private object MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public GLTFRecorderHelper CDTALOACOKM;

			[Cpp2IlInjected.Token(Token = "0x1700018E")]
			private object ENGTUJRFGYV
			{
				[Cpp2IlInjected.Token(Token = "0x60003EA")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700018F")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x60003EC")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0xAA9B40", Offset = "0xAA8140", VA = "0x180AA9B40")]
			[DebuggerHidden]
			public HEXAKSDZXRV(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0xA265D20", Offset = "0xA264320", VA = "0x18A265D20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0xA265F50", Offset = "0xA264550", VA = "0x18A265F50", Slot = "8")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private List<Action> SQYCKRPBLZK;

		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private static GLTFRecorderHelper ADQBSUIXDPJ;

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xA265600", Offset = "0xA263C00", VA = "0x18A265600")]
		public static void Add(Action callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0xA265910", Offset = "0xA263F10", VA = "0x18A265910")]
		private static GLTFRecorderHelper MVNOLPDAVWP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0xA265820", Offset = "0xA263E20", VA = "0x18A265820")]
		[IteratorStateMachine(typeof(HEXAKSDZXRV))]
		private IEnumerator CHGJOZBQFWR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0xA265890", Offset = "0xA263E90", VA = "0x18A265890")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0xA265A90", Offset = "0xA264090", VA = "0x18A265A90")]
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
		[Cpp2IlInjected.Address(RVA = "0xA265B10", Offset = "0xA264110", VA = "0x18A265B10")]
		public GLTFRecorderTrack()
		{
		}
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	internal static class DJDQXTIHGQY
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		[CompilerGenerated]
		private sealed class AUWAEQXFGZW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			public int BMESQBTHLQA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			public TXPPJKRUCSP GLCTGUPHOVL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			public XYFZUQCULVJ OGLBFVTTULK;

			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public AUWAEQXFGZW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0xA25BBD0", Offset = "0xA25A1D0", VA = "0x18A25BBD0")]
			internal float[] MYMLMECQJFB(XYFZUQCULVJ a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0xA25BB40", Offset = "0xA25A140", VA = "0x18A25BB40")]
			internal float[] MYHEOXISZTS(XYFZUQCULVJ a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0xA25BCF0", Offset = "0xA25A2F0", VA = "0x18A25BCF0")]
			internal float[] MYWZGRQLCBT(XYFZUQCULVJ a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0xA25BC60", Offset = "0xA25A260", VA = "0x18A25BC60")]
			internal float[] MYRSJKWNSQK(XYFZUQCULVJ a, int b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private static readonly string[] PQESEDMZJBO;

		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private static readonly string[] ZJBFGPPXDSI;

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xA260780", Offset = "0xA25ED80", VA = "0x18A260780")]
		internal static bool VNNQYHDRROX(string a, NTXTAINCJGM b, Material c, string d, UZAMOXUXDLF e, [Out] XYFZUQCULVJ f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xA2605D0", Offset = "0xA25EBD0", VA = "0x18A2605D0")]
		internal static string[] GLKBHWWMOOY(string a, int b, int c = 0, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0xA260D00", Offset = "0xA25F300", VA = "0x18A260D00")]
		internal static float[] XMJMCNVELJI(int a, int b, TXPPJKRUCSP c, XYFZUQCULVJ d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class TXPPJKRUCSP
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
		public PropertyTypeOption SNWVJCGMFNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public string GNRVKYQELLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public string YCXEOAHRIHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public bool HXRGHKBRFMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public CombineResultType XMYEETNPKDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public GLTFAccessorAttributeType EXABBGFYKIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public bool JCZEGJNSJCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public bool XYMEROUFYRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x36")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public bool GGCOLPOTMCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public float XCPPMGKAGCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public string PUNTJCAYCUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public CombinePrimaryAndSecondaryData KUJRKRTPJWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private string[] TXBQAAAKXMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		internal int[] LOVESAIOKJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		internal int[] ZNLTQFPIPJU;

		[Cpp2IlInjected.Token(Token = "0x17000190")]
		public string[] PVLUSXBJTEP
		{
			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0xAACD40", Offset = "0xAAB340", VA = "0x180AACD40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0xA26BA10", Offset = "0xA26A010", VA = "0x18A26BA10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000191")]
		public bool PNEUQKJDERF
		{
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0xA26B8A0", Offset = "0xA269EA0", VA = "0x18A26B8A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0xA26BB60", Offset = "0xA26A160", VA = "0x18A26BB60")]
		public TXPPJKRUCSP(PropertyTypeOption a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xA26B700", Offset = "0xA269D00", VA = "0x18A26B700")]
		private void BOSTNXEDUJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xA26B8C0", Offset = "0xA269EC0", VA = "0x18A26B8C0")]
		private static float[] RDHGNDUNCBC(float[] a, float[] b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xA26BA40", Offset = "0xA26A040", VA = "0x18A26BA40")]
		private void XRSVEWXBILC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class NTXTAINCJGM
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
		private Dictionary<string, TXPPJKRUCSP> NSCQENJBTTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private Dictionary<string, TXPPJKRUCSP> YXDKPFDKFMV;

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xA26ACE0", Offset = "0xA2692E0", VA = "0x18A26ACE0")]
		public void UPTDWHVVZYA(string a, string[] b, [Optional] string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xA26AAC0", Offset = "0xA2690C0", VA = "0x18A26AAC0")]
		public void TUWZNKPMKVR(TXPPJKRUCSP a, ImportExportUsageOption b = ImportExportUsageOption.ImportAndExport)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0xA26B1E0", Offset = "0xA2697E0", VA = "0x18A26B1E0")]
		public bool WQMDITRODMW(Material a, string b, [Out] TXPPJKRUCSP c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0xA26A6F0", Offset = "0xA268CF0", VA = "0x18A26A6F0")]
		public bool MBRQDPZYAWD(Material a, string b, [Out] string c, [Out] TXPPJKRUCSP d, [Out] bool e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0xA26B400", Offset = "0xA269A00", VA = "0x18A26B400")]
		public NTXTAINCJGM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public class BUKVKQOMAYF : NTXTAINCJGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0xA25D0F0", Offset = "0xA25B6F0", VA = "0x18A25D0F0")]
		public BUKVKQOMAYF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public class AnimationPointerExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000192")]
		public override string RNVGACKCYSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0xA25CEA0", Offset = "0xA25B4A0", VA = "0x18A25CEA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000193")]
		public override string CJNFRMHQECO
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0xA25CE70", Offset = "0xA25B470", VA = "0x18A25CE70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		public override bool ZPAYGUIYITX
		{
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0xA25CDD0", Offset = "0xA25B3D0", VA = "0x18A25CDD0", Slot = "14")]
		public override NIJBGKZVPPN CreateInstance(PPPKVVWBNXH context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x163F6E0", Offset = "0x163DCE0", VA = "0x18163F6E0")]
		public AnimationPointerExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public class AJLXLVAMYLW : NIJBGKZVPPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public NTXTAINCJGM RRDZBQFRJJG;

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0xA25BAD0", Offset = "0xA25A0D0", VA = "0x18A25BAD0")]
		public AJLXLVAMYLW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public class AnimationPointerImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000195")]
		public override string RNVGACKCYSR
		{
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0xA25CFA0", Offset = "0xA25B5A0", VA = "0x18A25CFA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000196")]
		public override string CJNFRMHQECO
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0xA25CF70", Offset = "0xA25B570", VA = "0x18A25CF70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0xA25CED0", Offset = "0xA25B4D0", VA = "0x18A25CED0", Slot = "13")]
		public override RWBPLTFQPNM CreateInstance(UWIWONGEACP context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x163F6E0", Offset = "0x163DCE0", VA = "0x18163F6E0")]
		public AnimationPointerImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	public class IAZFUYYLNJT : RWBPLTFQPNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public NTXTAINCJGM RRDZBQFRJJG;

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0xA265F90", Offset = "0xA264590", VA = "0x18A265F90")]
		public IAZFUYYLNJT()
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
		[Cpp2IlInjected.Address(RVA = "0xAD0950", Offset = "0xACEF50", VA = "0x180AD0950")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD0950", Offset = "0xACEF50", VA = "0x180AD0950")]
		public ExperimentalPluginAttribute([Optional] string tooltip)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public abstract class GLTFExportPlugin : GLTFPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000197")]
		public virtual JToken WJDOTBVLAJV
		{
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(Slot = "14")]
		public abstract NIJBGKZVPPN CreateInstance(PPPKVVWBNXH context);

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x163F6E0", Offset = "0x163DCE0", VA = "0x18163F6E0")]
		protected GLTFExportPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public abstract class NIJBGKZVPPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "4")]
		public virtual void SDOFLZDWLET(GLTFSceneExporter a, YBVGUQCSKJP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
		public virtual void XUHGDBIMMOE(GLTFSceneExporter a, YBVGUQCSKJP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "6")]
		public virtual bool YEFXBPZMDCZ(GLTFSceneExporter a, YBVGUQCSKJP b, Transform c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "7")]
		public virtual void XASNQUCWQVH(GLTFSceneExporter a, YBVGUQCSKJP b, Transform c, QPBKESVYPXS d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "8")]
		public virtual void OJAHNLKAQFS(GLTFSceneExporter a, YBVGUQCSKJP b, Transform c, QPBKESVYPXS d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "9")]
		public virtual bool HFBSGFYGMUA(GLTFSceneExporter a, YBVGUQCSKJP b, Material c, SWTHYRWJKEM d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "10")]
		public virtual void UETUAYSCOPH(GLTFSceneExporter a, YBVGUQCSKJP b, Material c, SWTHYRWJKEM d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "11")]
		public virtual void AVKCGIAJUMQ(GLTFSceneExporter a, GLTFSceneExporter.UniqueTexture b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "12")]
		public virtual void NIFFWLOXAVZ(GLTFSceneExporter a, GLTFSceneExporter.UniqueTexture b, int c, RAXRAOUEMWM d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "13")]
		public virtual void IVKWQIWEOKB(GLTFSceneExporter a, Mesh b, TOEZEOEVPIK c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "14")]
		public virtual void ZPTLCEYDNIV(GLTFSceneExporter a, Mesh b, BFGGSXOTTTO c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		protected NIJBGKZVPPN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public abstract class GLTFImportPlugin : GLTFPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(Slot = "13")]
		public abstract RWBPLTFQPNM CreateInstance(UWIWONGEACP context);

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x163F6E0", Offset = "0x163DCE0", VA = "0x18163F6E0")]
		protected GLTFImportPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public abstract class RWBPLTFQPNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "4")]
		public virtual void XLWGENPSCIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
		public virtual void ZVHNTUJNXNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "6")]
		public virtual void PUHPOROECGQ(YBVGUQCSKJP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "7")]
		public virtual void TTGLNXIARJX(HFFDYZWKXSX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "8")]
		public virtual void VUKHPRWKXJK(QPBKESVYPXS a, int b, GameObject c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "9")]
		public virtual void NNULIVPFGBD(SWTHYRWJKEM a, int b, Material c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "10")]
		public virtual void OFBGQVCXVOH(RAXRAOUEMWM a, int b, Texture c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "11")]
		public virtual void PUTMZUQVJUI(HFFDYZWKXSX a, int b, GameObject c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		protected RWBPLTFQPNM()
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
		public abstract string RNVGACKCYSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		public virtual string CJNFRMHQECO
		{
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		public virtual string KHQCKJBXNMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		public virtual bool YGAJUXDHCKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0xA264B20", Offset = "0xA263120", VA = "0x18A264B20", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0xAB3D10", Offset = "0xAB2310", VA = "0x180AB3D10", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		public virtual bool ZPAYGUIYITX
		{
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019D")]
		public virtual bool YOEDSTZVTPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		public virtual string CHKIJTCVFVW
		{
			[Cpp2IlInjected.Token(Token = "0x6000437")]
			[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		public virtual bool LPXLFCWIETK
		{
			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x163F6E0", Offset = "0x163DCE0", VA = "0x18163F6E0")]
		protected GLTFPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[Obsolete("Use UnityGLTF.Plugins.GLTFPlugin instead. (UnityUpgradable) -> UnityGLTF.Plugins.GLTFPlugin")]
	public abstract class GltfPlugin : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0xDB5160", Offset = "0xDB3760", VA = "0x180DB5160")]
		protected GltfPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[Obsolete("Use UnityGLTF.Plugins.GLTFImportPlugin instead. (UnityUpgradable) -> UnityGLTF.Plugins.GLTFImportPlugin")]
	public abstract class GltfImportPlugin : GltfPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0xDB5160", Offset = "0xDB3760", VA = "0x180DB5160")]
		protected GltfImportPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[Obsolete("Use UnityGLTF.Plugins.GLTFExportPlugin instead. (UnityUpgradable) -> UnityGLTF.Plugins.GLTFExportPlugin")]
	public abstract class GltfExportPlugin : GltfPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0xDB5160", Offset = "0xDB3760", VA = "0x180DB5160")]
		protected GltfExportPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public class UWIWONGEACP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public readonly List<RWBPLTFQPNM> BDZPQZWAANW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public GLTFSceneImporter QWWGIFZAEEW;

		[Cpp2IlInjected.Token(Token = "0x170001A0")]
		public YBVGUQCSKJP KXNQQKPTVYU
		{
			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0xA26D560", Offset = "0xA26BB60", VA = "0x18A26D560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0xA26D350", Offset = "0xA26B950", VA = "0x18A26D350")]
		private List<RWBPLTFQPNM> JMFNNSUWFBQ(GLTFSettings a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0xA26D580", Offset = "0xA26BB80", VA = "0x18A26D580")]
		internal UWIWONGEACP(GLTFSettings a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x3E730F0", Offset = "0x3E716F0", VA = "0x183E730F0")]
		public bool JFHZLJFSUZO<a>([Out] a a) where a : RWBPLTFQPNM
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public class DracoImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001A1")]
		public override string RNVGACKCYSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0xA261DA0", Offset = "0xA2603A0", VA = "0x18A261DA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A2")]
		public override string CJNFRMHQECO
		{
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0xA261D70", Offset = "0xA260370", VA = "0x18A261D70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A3")]
		public override bool LPXLFCWIETK
		{
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0xA261D20", Offset = "0xA260320", VA = "0x18A261D20", Slot = "13")]
		public override RWBPLTFQPNM CreateInstance(UWIWONGEACP context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x163F6E0", Offset = "0x163DCE0", VA = "0x18163F6E0")]
		public DracoImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public class TSOYEORCLRP : RWBPLTFQPNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public TSOYEORCLRP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public class GPUInstancingImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001A4")]
		public override string RNVGACKCYSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0xA265BE0", Offset = "0xA2641E0", VA = "0x18A265BE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A5")]
		public override string CJNFRMHQECO
		{
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(RVA = "0xA265BB0", Offset = "0xA2641B0", VA = "0x18A265BB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0xA265B60", Offset = "0xA264160", VA = "0x18A265B60", Slot = "13")]
		public override RWBPLTFQPNM CreateInstance(UWIWONGEACP context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x163F6E0", Offset = "0x163DCE0", VA = "0x18163F6E0")]
		public GPUInstancingImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public class YXNPBCZZIEW : RWBPLTFQPNM
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public YXNPBCZZIEW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public class Ktx2Import : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001A6")]
		public override string RNVGACKCYSR
		{
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0xA266B40", Offset = "0xA265140", VA = "0x18A266B40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A7")]
		public override string CJNFRMHQECO
		{
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0xA266B10", Offset = "0xA265110", VA = "0x18A266B10", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A8")]
		public override bool LPXLFCWIETK
		{
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0xA266AC0", Offset = "0xA2650C0", VA = "0x18A266AC0", Slot = "13")]
		public override RWBPLTFQPNM CreateInstance(UWIWONGEACP context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x163F6E0", Offset = "0x163DCE0", VA = "0x18163F6E0")]
		public Ktx2Import()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public class DLDRIVKRRRZ : RWBPLTFQPNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public DLDRIVKRRRZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public class LightsPunctualExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001A9")]
		public override string RNVGACKCYSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0xA268A70", Offset = "0xA267070", VA = "0x18A268A70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		public override string CJNFRMHQECO
		{
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0xA268A40", Offset = "0xA267040", VA = "0x18A268A40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0xA2689F0", Offset = "0xA266FF0", VA = "0x18A2689F0", Slot = "14")]
		public override NIJBGKZVPPN CreateInstance(PPPKVVWBNXH context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x163F6E0", Offset = "0x163DCE0", VA = "0x18163F6E0")]
		public LightsPunctualExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public class RYUSYBONOHK : NIJBGKZVPPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "8")]
		public override void OJAHNLKAQFS(GLTFSceneExporter a, YBVGUQCSKJP b, Transform c, QPBKESVYPXS d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public RYUSYBONOHK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public class LightsPunctualImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		public override string RNVGACKCYSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xA268B20", Offset = "0xA267120", VA = "0x18A268B20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public override string CJNFRMHQECO
		{
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xA268AF0", Offset = "0xA2670F0", VA = "0x18A268AF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0xA268AA0", Offset = "0xA2670A0", VA = "0x18A268AA0", Slot = "13")]
		public override RWBPLTFQPNM CreateInstance(UWIWONGEACP context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x163F6E0", Offset = "0x163DCE0", VA = "0x18163F6E0")]
		public LightsPunctualImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public class RZLPRCIQYKB : RWBPLTFQPNM
	{
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public RZLPRCIQYKB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[NonRatifiedPlugin(null)]
	public class LodsExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		public override string RNVGACKCYSR
		{
			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0xA268BD0", Offset = "0xA2671D0", VA = "0x18A268BD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		public override string CJNFRMHQECO
		{
			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0xA268BA0", Offset = "0xA2671A0", VA = "0x18A268BA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0xA268B50", Offset = "0xA267150", VA = "0x18A268B50", Slot = "14")]
		public override NIJBGKZVPPN CreateInstance(PPPKVVWBNXH context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x163F6E0", Offset = "0x163DCE0", VA = "0x18163F6E0")]
		public LodsExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public class IRDVPSUHUSZ : NIJBGKZVPPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0xA266000", Offset = "0xA264600", VA = "0x18A266000", Slot = "8")]
		public override void OJAHNLKAQFS(GLTFSceneExporter a, YBVGUQCSKJP b, Transform c, QPBKESVYPXS d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public IRDVPSUHUSZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[NonRatifiedPlugin(null)]
	public class LodsImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		public override string RNVGACKCYSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0xA268C80", Offset = "0xA267280", VA = "0x18A268C80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		public override string CJNFRMHQECO
		{
			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0xA268C50", Offset = "0xA267250", VA = "0x18A268C50", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0xA268C00", Offset = "0xA267200", VA = "0x18A268C00", Slot = "13")]
		public override RWBPLTFQPNM CreateInstance(UWIWONGEACP context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x163F6E0", Offset = "0x163DCE0", VA = "0x18163F6E0")]
		public LodsImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public class AHBCTROUSVO : RWBPLTFQPNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public AHBCTROUSVO()
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
		public override string RNVGACKCYSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0xA268D60", Offset = "0xA267360", VA = "0x18A268D60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		public override string CJNFRMHQECO
		{
			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0xA268D30", Offset = "0xA267330", VA = "0x18A268D30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0xA268CB0", Offset = "0xA2672B0", VA = "0x18A268CB0", Slot = "14")]
		public override NIJBGKZVPPN CreateInstance(PPPKVVWBNXH context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0xA268D10", Offset = "0xA267310", VA = "0x18A268D10")]
		public MaterialExtensionsExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public class EINPUWTJYAE : NIJBGKZVPPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		internal readonly MaterialExtensionsExport QVFBSGRPICZ;

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private static readonly int HRBTPDKRXPT;

		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private static readonly int DZBGBLINISB;

		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private static readonly int UVLUZULJPRN;

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private static readonly int IAHWOWGDVUD;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private static readonly int CDUGHRNUFTA;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private static readonly int IBEWPRQPVQD;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private static readonly int UGPCIEKRLVJ;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private static readonly int RZEPJYYJEZU;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private static readonly int QPWSSPBFXDN;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private static readonly int XHBYGKWZLXE;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private static readonly int NCCRXDCBDXQ;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private static readonly int YYIFBCCSUQQ;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private static readonly int GVYKETPERBR;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private static readonly int CTEXEYGNWHD;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private static readonly int YXVAGZRXSWW;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private static readonly int SWWPAEVVPLF;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private static readonly int UDBNLHHHIZW;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private static readonly int FNLAXXMMAJN;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private static readonly int BGLQJJXBCYV;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private static readonly int UXZKHQJZUWR;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private static readonly int KAWQUPIPPSL;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private static readonly int SPNGZHYHTKD;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private static readonly int UAQJFKECQMY;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private static readonly int YIVRILRLJCH;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private static readonly int ECCVBNQGUIC;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private static readonly int ASIWCVFAKTB;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private static readonly int DYAAWOEHTGY;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private static readonly int AZBTAESPIWV;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private static readonly int SUQDUVODKUG;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private static readonly int TBWXHLAKIOH;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
		public EINPUWTJYAE(MaterialExtensionsExport a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0xA261DD0", Offset = "0xA2603D0", VA = "0x18A261DD0", Slot = "10")]
		public override void UETUAYSCOPH(GLTFSceneExporter a, YBVGUQCSKJP b, Material c, SWTHYRWJKEM d)
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
		public override string RNVGACKCYSR
		{
			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0xA268E40", Offset = "0xA267440", VA = "0x18A268E40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		public override string CJNFRMHQECO
		{
			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0xA268E10", Offset = "0xA267410", VA = "0x18A268E10", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0xA268D90", Offset = "0xA267390", VA = "0x18A268D90", Slot = "13")]
		public override RWBPLTFQPNM CreateInstance(UWIWONGEACP context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0xA268DF0", Offset = "0xA2673F0", VA = "0x18A268DF0")]
		public MaterialExtensionsImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public class ICBDNOIMQAB : RWBPLTFQPNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		internal readonly MaterialExtensionsImport QVFBSGRPICZ;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
		public ICBDNOIMQAB(MaterialExtensionsImport a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public class MeshoptImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		public override string RNVGACKCYSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0xA268EF0", Offset = "0xA2674F0", VA = "0x18A268EF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public override string CJNFRMHQECO
		{
			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0xA268EC0", Offset = "0xA2674C0", VA = "0x18A268EC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		public override bool LPXLFCWIETK
		{
			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0xA268E70", Offset = "0xA267470", VA = "0x18A268E70", Slot = "13")]
		public override RWBPLTFQPNM CreateInstance(UWIWONGEACP context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x163F6E0", Offset = "0x163DCE0", VA = "0x18163F6E0")]
		public MeshoptImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public class RYZTNQWQPES : RWBPLTFQPNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public RYZTNQWQPES()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public class TextureTransformExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001B8")]
		public override string RNVGACKCYSR
		{
			[Cpp2IlInjected.Token(Token = "0x600047A")]
			[Cpp2IlInjected.Address(RVA = "0xA26BDE0", Offset = "0xA26A3E0", VA = "0x18A26BDE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B9")]
		public override string CJNFRMHQECO
		{
			[Cpp2IlInjected.Token(Token = "0x600047B")]
			[Cpp2IlInjected.Address(RVA = "0xA26BDB0", Offset = "0xA26A3B0", VA = "0x18A26BDB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		public override bool YOEDSTZVTPE
		{
			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "14")]
		public override NIJBGKZVPPN CreateInstance(PPPKVVWBNXH context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x163F6E0", Offset = "0x163DCE0", VA = "0x18163F6E0")]
		public TextureTransformExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public class TextureTransformImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001BB")]
		public override string RNVGACKCYSR
		{
			[Cpp2IlInjected.Token(Token = "0x600047F")]
			[Cpp2IlInjected.Address(RVA = "0xA26BE40", Offset = "0xA26A440", VA = "0x18A26BE40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		public override string CJNFRMHQECO
		{
			[Cpp2IlInjected.Token(Token = "0x6000480")]
			[Cpp2IlInjected.Address(RVA = "0xA26BE10", Offset = "0xA26A410", VA = "0x18A26BE10", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		public override bool YOEDSTZVTPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000481")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "13")]
		public override RWBPLTFQPNM CreateInstance(UWIWONGEACP context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x163F6E0", Offset = "0x163DCE0", VA = "0x18163F6E0")]
		public TextureTransformImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public class UnlitMaterialsExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001BE")]
		public override string RNVGACKCYSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000484")]
			[Cpp2IlInjected.Address(RVA = "0xA26D5F0", Offset = "0xA26BBF0", VA = "0x18A26D5F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		public override string CJNFRMHQECO
		{
			[Cpp2IlInjected.Token(Token = "0x6000485")]
			[Cpp2IlInjected.Address(RVA = "0xA26D5C0", Offset = "0xA26BBC0", VA = "0x18A26D5C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		public override bool YOEDSTZVTPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000486")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "14")]
		public override NIJBGKZVPPN CreateInstance(PPPKVVWBNXH context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x163F6E0", Offset = "0x163DCE0", VA = "0x18163F6E0")]
		public UnlitMaterialsExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public class UnlitMaterialsImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001C1")]
		public override string RNVGACKCYSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000489")]
			[Cpp2IlInjected.Address(RVA = "0xA26D650", Offset = "0xA26BC50", VA = "0x18A26D650", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C2")]
		public override string CJNFRMHQECO
		{
			[Cpp2IlInjected.Token(Token = "0x600048A")]
			[Cpp2IlInjected.Address(RVA = "0xA26D620", Offset = "0xA26BC20", VA = "0x18A26D620", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C3")]
		public override bool YOEDSTZVTPE
		{
			[Cpp2IlInjected.Token(Token = "0x600048B")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "13")]
		public override RWBPLTFQPNM CreateInstance(UWIWONGEACP context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x163F6E0", Offset = "0x163DCE0", VA = "0x18163F6E0")]
		public UnlitMaterialsImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public class VisibilityExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		public override string RNVGACKCYSR
		{
			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0xA26D6B0", Offset = "0xA26BCB0", VA = "0x18A26D6B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		public override string CJNFRMHQECO
		{
			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0xA26D680", Offset = "0xA26BC80", VA = "0x18A26D680", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		public override bool YOEDSTZVTPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000490")]
			[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		public override bool ZPAYGUIYITX
		{
			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "14")]
		public override NIJBGKZVPPN CreateInstance(PPPKVVWBNXH context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x163F6E0", Offset = "0x163DCE0", VA = "0x18163F6E0")]
		public VisibilityExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public class VisibilityImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		public override string RNVGACKCYSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000494")]
			[Cpp2IlInjected.Address(RVA = "0xA26D710", Offset = "0xA26BD10", VA = "0x18A26D710", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		public override string CJNFRMHQECO
		{
			[Cpp2IlInjected.Token(Token = "0x6000495")]
			[Cpp2IlInjected.Address(RVA = "0xA26D6E0", Offset = "0xA26BCE0", VA = "0x18A26D6E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CA")]
		public override bool YOEDSTZVTPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000496")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "13")]
		public override RWBPLTFQPNM CreateInstance(UWIWONGEACP context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x163F6E0", Offset = "0x163DCE0", VA = "0x18163F6E0")]
		public VisibilityImport()
		{
		}
	}
}
namespace UnityGLTF.Loader
{
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public class MSNNNZKXXTH
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
	public interface YABGTNFERRK
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Stream> HDSGZWGSHNC(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public interface ACYERDLMEEW : YABGTNFERRK
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Stream CCBAVKNHUOY(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[Obsolete("Please switch to IDataLoader.  This interface is deprecated and will be removed in a future release.")]
	public interface IQUUCFQFESE
	{
		[Cpp2IlInjected.Token(Token = "0x170001CB")]
		Stream GOVAOJEEQAV
		{
			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		bool FQLZPMPZOCW
		{
			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task CCBAVKNHUOY(string a);

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void EKMDEJAZZTF(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	public static class HAIRRKEWKEX
	{
		[Cpp2IlInjected.Token(Token = "0x20000DC")]
		private class CVHPHYDTRNG : YABGTNFERRK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000405")]
			protected readonly IQUUCFQFESE UGCFGGDMDLY;

			[Cpp2IlInjected.Token(Token = "0x60004A0")]
			[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
			public CVHPHYDTRNG(IQUUCFQFESE a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A1")]
			[Cpp2IlInjected.Address(RVA = "0xA2604C0", Offset = "0xA25EAC0", VA = "0x18A2604C0", Slot = "4")]
			public Task<Stream> HDSGZWGSHNC(string a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000DD")]
		private class BZXUIPHCOMS : CVHPHYDTRNG, ACYERDLMEEW, YABGTNFERRK
		{
			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
			public BZXUIPHCOMS(IQUUCFQFESE a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0xA2600B0", Offset = "0xA25E6B0", VA = "0x18A2600B0", Slot = "5")]
			public Stream CCBAVKNHUOY(string a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0xA265C10", Offset = "0xA264210", VA = "0x18A265C10")]
		public static YABGTNFERRK VFWPIDTNKJS(IQUUCFQFESE a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public class JESOCBURGSV : YABGTNFERRK
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
			public JESOCBURGSV <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA26BE70", Offset = "0xA26A470", VA = "0x18A26BE70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0xA26C450", Offset = "0xA26AA50", VA = "0x18A26C450", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		private string HWRAQRMMSVV;

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
		public JESOCBURGSV(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0xA266400", Offset = "0xA264A00", VA = "0x18A266400", Slot = "4")]
		[AsyncStateMachine(typeof(<LoadStreamAsync>d__2))]
		public Task<Stream> HDSGZWGSHNC(string a)
		{
			return null;
		}
	}
}
namespace UnityGLTF.Extensions
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public class LPZSROKDRIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private readonly List<KHR_animation_pointer> VEMRDBKELXW;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private static readonly ProfilerMarker UOUMBJRBPLR;

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0xA266B70", Offset = "0xA265170", VA = "0x18A266B70")]
		public void Add(KHR_animation_pointer anim)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0xA266C20", Offset = "0xA265220", VA = "0x18A266C20")]
		public void RGQPLBMSLVG(GLTFSceneExporter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0xA2675F0", Offset = "0xA265BF0", VA = "0x18A2675F0")]
		public LPZSROKDRIL()
		{
		}
	}
}
namespace UnityGLTF.JsonPointer
{
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public interface QRQJRDONJFG
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool EORNXQMQSVV(object a, string b);
	}
}
namespace UnityGLTF.Cache
{
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	public struct AnimationSamplerCacheData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public UZAMOXUXDLF Input;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public UZAMOXUXDLF Output;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public InterpolationType Interpolation;
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public class TARSEFBHMVS
	{
		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		public AnimationClip UXWVBEJKPYX
		{
			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9C0", Offset = "0xAA8FC0", VA = "0x180AAA9C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		public AnimationSamplerCacheData[] AKJWSXDXHPX
		{
			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0xAA7A70", Offset = "0xAA6070", VA = "0x180AA7A70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0xA26B550", Offset = "0xA269B50", VA = "0x18A26B550")]
		public TARSEFBHMVS(int a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public class FWVPWEKFKPM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		public Stream[] QRVYUZMUQSB
		{
			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9C0", Offset = "0xAA8FC0", VA = "0x180AAA9C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		public Texture2D[] ZAEBSTBJQNL
		{
			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0xAA7A70", Offset = "0xAA6070", VA = "0x180AA7A70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D1")]
		public Texture2D[] QLVEWWNOSPE
		{
			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0xAA7770", Offset = "0xAA5D70", VA = "0x180AA7770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		public NWWJEMMFXIL[] BMWFSUEIRDF
		{
			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0xAA8690", Offset = "0xAA6C90", VA = "0x180AA8690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		public DZXWPWAZLNL[] ZSPZEZPCZUV
		{
			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6C0", Offset = "0xAA9CC0", VA = "0x180AAB6C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9B0", Offset = "0xAA8FB0", VA = "0x180AAA9B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		public MBXESCOTZRS[] CUNDRAKVBTG
		{
			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEF0", Offset = "0xAAE4F0", VA = "0x180AAFEF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0xAB0F10", Offset = "0xAAF510", VA = "0x180AB0F10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		public BFQECECDEFT[] CRACXNQONCF
		{
			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEE0", Offset = "0xAAE4E0", VA = "0x180AAFEE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0xAB0770", Offset = "0xAAED70", VA = "0x180AB0770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		public GHNZIBVCRDK[] VWWMFKQKFKO
		{
			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0xAB0EE0", Offset = "0xAAF4E0", VA = "0x180AB0EE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0xAB1500", Offset = "0xAAFB00", VA = "0x180AB1500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public TARSEFBHMVS[] TTIPGOIHZXS
		{
			[Cpp2IlInjected.Token(Token = "0x60004C2")]
			[Cpp2IlInjected.Address(RVA = "0xAACD40", Offset = "0xAAB340", VA = "0x180AACD40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C3")]
			[Cpp2IlInjected.Address(RVA = "0xAACAB0", Offset = "0xAAB0B0", VA = "0x180AACAB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		public GameObject[] PLOSIJHVQYG
		{
			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0xAACA80", Offset = "0xAAB080", VA = "0x180AACA80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C5")]
			[Cpp2IlInjected.Address(RVA = "0xAACAA0", Offset = "0xAAB0A0", VA = "0x180AACAA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0xA264840", Offset = "0xA262E40", VA = "0x18A264840")]
		public FWVPWEKFKPM(YBVGUQCSKJP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0xA264730", Offset = "0xA262D30", VA = "0x18A264730", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public class MBXESCOTZRS : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		public uint TIQXZRXFKEC
		{
			[Cpp2IlInjected.Token(Token = "0x60004C8")]
			[Cpp2IlInjected.Address(RVA = "0xAA5110", Offset = "0xAA3710", VA = "0x180AA5110")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0xAA7720", Offset = "0xAA5D20", VA = "0x180AA7720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		public Stream RZLPYBRMLKY
		{
			[Cpp2IlInjected.Token(Token = "0x60004CA")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004CB")]
			[Cpp2IlInjected.Address(RVA = "0xAA7A70", Offset = "0xAA6070", VA = "0x180AA7A70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		public NativeArray<byte> ZMUDHYPTQUC
		{
			[Cpp2IlInjected.Token(Token = "0x60004CC")]
			[Cpp2IlInjected.Address(RVA = "0xF331E0", Offset = "0xF317E0", VA = "0x180F331E0")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x60004CD")]
			[Cpp2IlInjected.Address(RVA = "0x1022B90", Offset = "0x1021190", VA = "0x181022B90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x741C580", Offset = "0x741AB80", VA = "0x18741C580", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public MBXESCOTZRS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	internal static class YFECDKUKUHW
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0xFEBC00", Offset = "0xFEA200", VA = "0x180FEBC00")]
		public static bool EXITJGPDSKC(UnityEngine.Object a, string b, [Out] byte[] c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		public static void JEICAIOIETQ(UnityEngine.Object a, string b, byte[] c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	public class DZXWPWAZLNL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		public Material OHEQPOGFBHG
		{
			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9C0", Offset = "0xAA8FC0", VA = "0x180AAA9C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		public Material DPFCCQXFORH
		{
			[Cpp2IlInjected.Token(Token = "0x60004D4")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0xAA7A70", Offset = "0xAA6070", VA = "0x180AA7A70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		public SWTHYRWJKEM SWTHYRWJKEM
		{
			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0xAA7770", Offset = "0xAA5D70", VA = "0x180AA7770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0xA261C20", Offset = "0xA260220", VA = "0x18A261C20", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public DZXWPWAZLNL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public class BFQECECDEFT : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		public class WEBXKBISNDH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			public bool NDAHPCARESY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000429")]
			public Dictionary<string, UZAMOXUXDLF> GDKZBGNTYER;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042A")]
			public List<Dictionary<string, UZAMOXUXDLF>> GNGPWHEGAOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			public Dictionary<string, (UZAMOXUXDLF sparseIndices, UZAMOXUXDLF sparseValues)> WHKBHXCBVXK;

			[Cpp2IlInjected.Token(Token = "0x60004DD")]
			[Cpp2IlInjected.Address(RVA = "0xA26D7B0", Offset = "0xA26BDB0", VA = "0x18A26D7B0")]
			public WEBXKBISNDH()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public List<WEBXKBISNDH> OPYINNLVAWK;

		[Cpp2IlInjected.Token(Token = "0x170001DF")]
		public Mesh MFVCLYNTVIA
		{
			[Cpp2IlInjected.Token(Token = "0x60004D9")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004DA")]
			[Cpp2IlInjected.Address(RVA = "0xAA7A70", Offset = "0xAA6070", VA = "0x180AA7A70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0xA25CFD0", Offset = "0xA25B5D0", VA = "0x18A25CFD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0xA25D070", Offset = "0xA25B670", VA = "0x18A25D070")]
		public BFQECECDEFT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	public class DMUBFIANBSV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private bool KXGMCHRFOYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private int RRMMNEDBEJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private readonly object ZJMLDVPXUUW;

		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		public BFQECECDEFT[] CRACXNQONCF
		{
			[Cpp2IlInjected.Token(Token = "0x60004DE")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004DF")]
			[Cpp2IlInjected.Address(RVA = "0xAA7770", Offset = "0xAA5D70", VA = "0x180AA7770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		public UnityEngine.Object[] PEKJNCZSNTW
		{
			[Cpp2IlInjected.Token(Token = "0x60004E0")]
			[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E1")]
			[Cpp2IlInjected.Address(RVA = "0xAA8690", Offset = "0xAA6C90", VA = "0x180AA8690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		public DZXWPWAZLNL[] ZSPZEZPCZUV
		{
			[Cpp2IlInjected.Token(Token = "0x60004E2")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6C0", Offset = "0xAA9CC0", VA = "0x180AAB6C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E3")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9B0", Offset = "0xAA8FB0", VA = "0x180AAA9B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		public NWWJEMMFXIL[] BMWFSUEIRDF
		{
			[Cpp2IlInjected.Token(Token = "0x60004E4")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEF0", Offset = "0xAAE4F0", VA = "0x180AAFEF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E5")]
			[Cpp2IlInjected.Address(RVA = "0xAB0F10", Offset = "0xAAF510", VA = "0x180AB0F10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		public TARSEFBHMVS[] TTIPGOIHZXS
		{
			[Cpp2IlInjected.Token(Token = "0x60004E6")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEE0", Offset = "0xAAE4E0", VA = "0x180AAFEE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E7")]
			[Cpp2IlInjected.Address(RVA = "0xAB0770", Offset = "0xAAED70", VA = "0x180AB0770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		public Texture2D[] ZAEBSTBJQNL
		{
			[Cpp2IlInjected.Token(Token = "0x60004E8")]
			[Cpp2IlInjected.Address(RVA = "0xAB0EE0", Offset = "0xAAF4E0", VA = "0x180AB0EE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E9")]
			[Cpp2IlInjected.Address(RVA = "0xAB1500", Offset = "0xAAFB00", VA = "0x180AB1500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0xA261B20", Offset = "0xA260120", VA = "0x18A261B20")]
		public DMUBFIANBSV(DZXWPWAZLNL[] a, BFQECECDEFT[] b, NWWJEMMFXIL[] c, Texture2D[] d, TARSEFBHMVS[] e, UnityEngine.Object[] f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0xA261500", Offset = "0xA25FB00", VA = "0x18A261500")]
		public void KDAQKREHNNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0xA2615E0", Offset = "0xA25FBE0", VA = "0x18A2615E0")]
		public void TFSYRZIBDAU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0xA261730", Offset = "0xA25FD30", VA = "0x18A261730")]
		private void VASCKQMLQMU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public class NWWJEMMFXIL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public RAXRAOUEMWM VZQBCYBNVKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public Texture2D GSRNUFNSHIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public bool KPTOGRXCEYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public bool KXWJAGSFJLZ;

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0xA26B4B0", Offset = "0xA269AB0", VA = "0x18A26B4B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public NWWJEMMFXIL()
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
