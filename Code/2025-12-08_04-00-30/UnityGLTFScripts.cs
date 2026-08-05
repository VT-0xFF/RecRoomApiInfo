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
		private sealed class LQRCRLCMCPZ : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private object YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public AsyncCoroutineHelper VIXLAPAPYNX;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			private object FHSTBNTIQTK
			{
				[Cpp2IlInjected.Token(Token = "0x6000008")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public LQRCRLCMCPZ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x9F65DD0", Offset = "0x9F645D0", VA = "0x189F65DD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9F65E50", Offset = "0x9F64650", VA = "0x189F65E50", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
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
			[Cpp2IlInjected.Address(RVA = "0x9F6BA70", Offset = "0x9F6A270", VA = "0x189F6BA70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BC60", Offset = "0x9F6A460", VA = "0x189F6BC60", Slot = "5")]
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
		private WaitForEndOfFrame BBJIFSWSCWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private float VMIFAVLJPED;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9F57200", Offset = "0x9F55A00", VA = "0x189F57200")]
		[AsyncStateMachine(typeof(<YieldOnTimeout>d__3))]
		public Task YieldOnTimeout()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9F57170", Offset = "0x9F55970", VA = "0x189F57170")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9F57100", Offset = "0x9F55900", VA = "0x189F57100")]
		[IteratorStateMachine(typeof(LQRCRLCMCPZ))]
		private IEnumerator DLLBTPSPETY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9F572D0", Offset = "0x9F55AD0", VA = "0x189F572D0")]
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
			private RVLDTTXHBEQ <importOptions>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private GLTFSceneImporter <sceneImporter>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x9F66B40", Offset = "0x9F65340", VA = "0x189F66B40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9F67830", Offset = "0x9F66030", VA = "0x189F67830", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F67890", Offset = "0x9F66090", VA = "0x189F67890", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xAFF690", Offset = "0xAFDE90", VA = "0x180AFF690", Slot = "5")]
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
		private int GHHIZHIESXD;

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
		public IEnumerable<Animation> TIFFEQERPFC
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xAA8580", Offset = "0xAA6D80", VA = "0x180AA8580")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xAA7D80", Offset = "0xAA6580", VA = "0x180AA7D80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public GameObject EWFWLLEJZQW
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9C980", VA = "0x180A9E180")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA9E420", Offset = "0xA9CC20", VA = "0x180A9E420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Shader SDHZOLYFYVU
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xA9E130", Offset = "0xA9C930", VA = "0x180A9E130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x9F57740", Offset = "0x9F55F40", VA = "0x189F57740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9F57620", Offset = "0x9F55E20", VA = "0x189F57620")]
		[AsyncStateMachine(typeof(<Start>d__33))]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9F57550", Offset = "0x9F55D50", VA = "0x189F57550")]
		[AsyncStateMachine(typeof(<Load>d__34))]
		public Task Load()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9F57460", Offset = "0x9F55C60", VA = "0x189F57460")]
		public void ApplyOverrideShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xDDE300", Offset = "0xDDCB00", VA = "0x180DDE300")]
		private void IHHDVHZMZPQ(GameObject a, ExceptionDispatchInfo b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9F576D0", Offset = "0x9F55ED0", VA = "0x189F576D0")]
		public GLTFComponent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class GLTFRecorderComponent : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class QCWWTHPWCYE : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private object YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public GLTFRecorderComponent VIXLAPAPYNX;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object FHSTBNTIQTK
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public QCWWTHPWCYE(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9F66110", Offset = "0x9F64910", VA = "0x189F66110", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x9F661D0", Offset = "0x9F649D0", VA = "0x189F661D0", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
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
		protected LNGBIMZDZSI WFKOTNOUDRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public UnityEvent recordingStarted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public UnityEvent<string> recordingEnded;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool YDGOHEMCXUO
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9F57F50", Offset = "0x9F56750", VA = "0x189F57F50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private double TVPBICCFAGZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x9F578D0", Offset = "0x9F560D0", VA = "0x189F578D0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9F57A10", Offset = "0x9F56210", VA = "0x189F57A10", Slot = "4")]
		[ContextMenu("Start Recording")]
		public virtual void StartRecording()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9F57D90", Offset = "0x9F56590", VA = "0x189F57D90", Slot = "5")]
		[ContextMenu("Stop Recording")]
		public virtual void StopRecording()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9F57770", Offset = "0x9F55F70", VA = "0x189F57770")]
		private void VOIYXZRVWTU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9F57D00", Offset = "0x9F56500", VA = "0x189F57D00")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9F579A0", Offset = "0x9F561A0", VA = "0x189F579A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9F57950", Offset = "0x9F56150", VA = "0x189F57950", Slot = "6")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9F579C0", Offset = "0x9F561C0", VA = "0x189F579C0", Slot = "7")]
		protected virtual void SHAFDMNQLQF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9F578E0", Offset = "0x9F560E0", VA = "0x189F578E0")]
		[IteratorStateMachine(typeof(QCWWTHPWCYE))]
		private IEnumerator KRMGJQVPBOU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9F57E90", Offset = "0x9F56690", VA = "0x189F57E90")]
		public GLTFRecorderComponent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9F57770", Offset = "0x9F55F70", VA = "0x189F57770")]
		[CompilerGenerated]
		private void BIQHHHBLQCB(InputAction.CallbackContext a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class QEOAQKJBNBK
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		internal class KOJWQGTGQSU : NVPVEURSWXA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private readonly QEOAQKJBNBK YAWEWSRKFBP;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAC9A60", Offset = "0xAC8260", VA = "0x180AC9A60")]
			internal KOJWQGTGQSU(QEOAQKJBNBK a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9F65C20", Offset = "0x9F64420", VA = "0x189F65C20", Slot = "4")]
			public override void TGGSUHVDIMS(GLTFSceneExporter a, WTVTOFLEGQC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9F65D50", Offset = "0x9F64550", VA = "0x189F65D50", Slot = "5")]
			public override void XPSISWXJQFV(GLTFSceneExporter a, WTVTOFLEGQC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9F65D10", Offset = "0x9F64510", VA = "0x189F65D10", Slot = "8")]
			public override void XGUTBCAIYDT(GLTFSceneExporter a, WTVTOFLEGQC b, Transform c, BERLEXGGYBZ d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x9F65B10", Offset = "0x9F64310", VA = "0x189F65B10", Slot = "9")]
			public override bool SYBEISKFSHN(GLTFSceneExporter a, WTVTOFLEGQC b, Material c, OFRYBPDMWCH d)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x9F65AD0", Offset = "0x9F642D0", VA = "0x189F65AD0", Slot = "10")]
			public override void NUOQYQFPDEE(GLTFSceneExporter a, WTVTOFLEGQC b, Material c, OFRYBPDMWCH d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9F65CD0", Offset = "0x9F644D0", VA = "0x189F65CD0", Slot = "11")]
			public override void VBAMIROOMAV(GLTFSceneExporter a, GLTFSceneExporter.UniqueTexture b, string c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x9F65C60", Offset = "0x9F64460", VA = "0x189F65C60", Slot = "12")]
			public override void UPTZBMOLRBS(GLTFSceneExporter a, GLTFSceneExporter.UniqueTexture b, int c, RAWOIEBXRSB d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9F65A90", Offset = "0x9F64290", VA = "0x189F65A90", Slot = "13")]
			public override void BWXMCYDCJBA(GLTFSceneExporter a, Mesh b, XABKJXLEVAH c, int d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9F65D90", Offset = "0x9F64590", VA = "0x189F65D90", Slot = "14")]
			public override void YTBRGDZWSME(GLTFSceneExporter a, Mesh b, HMCQBNAUHVJ c, int d)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public bool PBQGVZXQKBU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public LayerMask GHPLYALUEQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public ILogger IJXYKBYNHMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		internal readonly GLTFSettings ZGAONCAEWSS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public GLTFSceneExporter.RetrieveTexturePathDelegate KRZLYXVVQUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public GLTFSceneExporter.AfterSceneExportDelegate XPSISWXJQFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public GLTFSceneExporter.BeforeSceneExportDelegate TGGSUHVDIMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public GLTFSceneExporter.AfterNodeExportDelegate XGUTBCAIYDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public GLTFSceneExporter.BeforeMaterialExportDelegate SYBEISKFSHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public GLTFSceneExporter.AfterMaterialExportDelegate NUOQYQFPDEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public GLTFSceneExporter.BeforeTextureExportDelegate VBAMIROOMAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public GLTFSceneExporter.AfterTextureExportDelegate UPTZBMOLRBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public GLTFSceneExporter.AfterPrimitiveExportDelegate BWXMCYDCJBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public GLTFSceneExporter.AfterMeshExportDelegate YTBRGDZWSME;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9F66270", Offset = "0x9F64A70", VA = "0x189F66270")]
		public QEOAQKJBNBK(GLTFSettings a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9F66210", Offset = "0x9F64A10", VA = "0x189F66210")]
		internal NVPVEURSWXA VWDJRPYBQOO()
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
		public delegate void BeforeSceneExportDelegate(GLTFSceneExporter exporter, WTVTOFLEGQC gltfRoot);

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public delegate void AfterSceneExportDelegate(GLTFSceneExporter exporter, WTVTOFLEGQC gltfRoot);

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void AfterNodeExportDelegate(GLTFSceneExporter exporter, WTVTOFLEGQC gltfRoot, Transform transform, BERLEXGGYBZ node);

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate bool BeforeMaterialExportDelegate(GLTFSceneExporter exporter, WTVTOFLEGQC gltfRoot, Material material, OFRYBPDMWCH materialNode);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void AfterMaterialExportDelegate(GLTFSceneExporter exporter, WTVTOFLEGQC gltfRoot, Material material, OFRYBPDMWCH materialNode);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void BeforeTextureExportDelegate(GLTFSceneExporter exporter, UniqueTexture texture, string textureSlot);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public delegate void AfterTextureExportDelegate(GLTFSceneExporter exporter, UniqueTexture texture, int index, RAWOIEBXRSB tex);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public delegate void AfterPrimitiveExportDelegate(GLTFSceneExporter exporter, Mesh mesh, XABKJXLEVAH primitive, int index);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public delegate void AfterMeshExportDelegate(GLTFSceneExporter exporter, Mesh mesh, HMCQBNAUHVJ gltfMesh, int index);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class HMKIEGUQRDV : NVPVEURSWXA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x9F65510", Offset = "0x9F63D10", VA = "0x189F65510", Slot = "5")]
			public override void XPSISWXJQFV(GLTFSceneExporter a, WTVTOFLEGQC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x9F653F0", Offset = "0x9F63BF0", VA = "0x189F653F0", Slot = "4")]
			public override void TGGSUHVDIMS(GLTFSceneExporter a, WTVTOFLEGQC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x9F65470", Offset = "0x9F63C70", VA = "0x189F65470", Slot = "8")]
			public override void XGUTBCAIYDT(GLTFSceneExporter a, WTVTOFLEGQC b, Transform c, BERLEXGGYBZ d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x9F65290", Offset = "0x9F63A90", VA = "0x189F65290", Slot = "9")]
			public override bool SYBEISKFSHN(GLTFSceneExporter a, WTVTOFLEGQC b, Material c, OFRYBPDMWCH d)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x9F651F0", Offset = "0x9F639F0", VA = "0x189F651F0", Slot = "10")]
			public override void NUOQYQFPDEE(GLTFSceneExporter a, WTVTOFLEGQC b, Material c, OFRYBPDMWCH d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
			public HMKIEGUQRDV()
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
			[Cpp2IlInjected.Address(RVA = "0x9F66B00", Offset = "0x9F65300", VA = "0x189F66B00")]
			public TextureExportSettings(TextureExportSettings source)
			{
			}

			[SpecialName]
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x9F669C0", Offset = "0x9F651C0", VA = "0x189F669C0")]
			public static bool FYOQTCVQVIR(TextureExportSettings a, TextureExportSettings b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x9F668E0", Offset = "0x9F650E0", VA = "0x189F668E0")]
			public bool Equals(TextureExportSettings other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x9F66830", Offset = "0x9F65030", VA = "0x189F66830", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x9F66A00", Offset = "0x9F65200", VA = "0x189F66A00", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F6C010", Offset = "0x9F6A810", VA = "0x189F6C010")]
			public int EEYQPLOISSL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x9F6C370", Offset = "0x9F6AB70", VA = "0x189F6C370")]
			public int MGNSQVSKUHU()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x9F6C440", Offset = "0x9F6AC40", VA = "0x189F6C440")]
			public UniqueTexture(Texture tex, string textureSlot, GLTFSceneExporter exporter)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x9F6C3B0", Offset = "0x9F6ABB0", VA = "0x189F6C3B0")]
			public UniqueTexture(Texture tex, TextureExportSettings exportSettings)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x9F6C110", Offset = "0x9F6A910", VA = "0x189F6C110", Slot = "4")]
			public bool Equals(UniqueTexture other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x9F6C050", Offset = "0x9F6A850", VA = "0x189F6C050", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x9F6C2D0", Offset = "0x9F6AAD0", VA = "0x189F6C2D0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F6BCC0", Offset = "0x9F6A4C0", VA = "0x189F6BCC0")]
			public bool Equals(UniquePrimitive other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BE10", Offset = "0x9F6A610", VA = "0x189F6BE10", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BEC0", Offset = "0x9F6A6C0", VA = "0x189F6BEC0", Slot = "2")]
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
			public ANNHZWNIYUF aPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public ANNHZWNIYUF aNormal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public ANNHZWNIYUF aTangent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public ANNHZWNIYUF aTexcoord0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public ANNHZWNIYUF aTexcoord1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public ANNHZWNIYUF aTexcoord2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public ANNHZWNIYUF aColor0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public ANNHZWNIYUF aJoints0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public ANNHZWNIYUF aWeights0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public Dictionary<int, XABKJXLEVAH> subMeshPrimitives;
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private struct BlendShapeAccessors
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public List<Dictionary<string, ANNHZWNIYUF>> targets;

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
			public bool UMJZBZNASUO
			{
				[Cpp2IlInjected.Token(Token = "0x60000C7")]
				[Cpp2IlInjected.Address(RVA = "0xBE9B90", Offset = "0xBE8390", VA = "0x180BE9B90")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public bool QPMPUYOBIVB
			{
				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x732CFA0", Offset = "0x732B7A0", VA = "0x18732CFA0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x9F667A0", Offset = "0x9F64FA0", VA = "0x189F667A0")]
			public SamplerRelevantTextureData(Texture texture)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x9F666F0", Offset = "0x9F64EF0", VA = "0x189F666F0", Slot = "4")]
			public bool Equals(SamplerRelevantTextureData other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x9F66630", Offset = "0x9F64E30", VA = "0x189F66630", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x9F66720", Offset = "0x9F64F20", VA = "0x189F66720", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class JLSURXHEKPT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public bool VUKEHISTNIV;

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public JLSURXHEKPT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x9F65990", Offset = "0x9F64190", VA = "0x189F65990")]
			internal Color FSFIKDXDTAU(object a)
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class JLNNUQNHBEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public float PQVHSYRRTOY;

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public JLNNUQNHBEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x9F65930", Offset = "0x9F64130", VA = "0x189F65930")]
			internal float FSKPHKRBCMD(object a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class HGVSJGTUPUK : IEnumerable<(int, XABKJXLEVAH)>, IEnumerable, IEnumerator<(int, XABKJXLEVAH)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private (int subMeshIndex, XABKJXLEVAH prim) YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private int XJERYWNBAAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public GLTFSceneExporter VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private Mesh RNUVXSOSTUS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public Mesh NUHGQYZFJVL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private Dictionary<int, XABKJXLEVAH>.Enumerator RECIBZUSAYP;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private (int, XABKJXLEVAH) ARRHUQFQDRT
			{
				[Cpp2IlInjected.Token(Token = "0x60000E5")]
				[Cpp2IlInjected.Address(RVA = "0xC98390", Offset = "0xC96B90", VA = "0x180C98390", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((int, XABKJXLEVAH));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0x9F65080", Offset = "0x9F63880", VA = "0x189F65080", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1A228E0", Offset = "0x1A210E0", VA = "0x181A228E0")]
			[DebuggerHidden]
			public HGVSJGTUPUK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x9F650D0", Offset = "0x9F638D0", VA = "0x189F650D0", Slot = "7")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x9F64DB0", Offset = "0x9F635B0", VA = "0x189F64DB0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x9F65160", Offset = "0x9F63960", VA = "0x189F65160")]
			private void SNXRWXESNLS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x9F651B0", Offset = "0x9F639B0", VA = "0x189F651B0", Slot = "10")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x9F64D00", Offset = "0x9F63500", VA = "0x189F64D00", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(int, XABKJXLEVAH)> KQGUZQDEYOG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x9F64D00", Offset = "0x9F63500", VA = "0x189F64D00", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator WFEYQSZVQHA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static ILogger YPSRVFCUKIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private List<NVPVEURSWXA> VHNJDFSRZRW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private Transform[] FYPBWJXODEV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private WTVTOFLEGQC IUQWPOFPFTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private CPXGVJRXHMQ TGXTASUEGJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private BBDSDFOIDBC ZWRYTMZYRZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private List<ImageInfo> MDEYQRJLOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private HashSet<string> HRENRVZEJBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private List<FileInfo> CCVNOEQCAJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private HashSet<string> ZXHXPDVAXGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private List<UniqueTexture> ANXTVOJVYGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private Dictionary<int, int> UANJIZKSPNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private bool AZFDFLHCVGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private Dictionary<int, int> BSBSKQFEZYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private List<Transform> HNJQOOTFAKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private int MUQKJYBRHLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private QEOAQKJBNBK YAWEWSRKFBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private Material FAQREQFRHJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private Material SRUAEHMQLEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private Material DVYUHCGFRMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private bool SCAPMGYQGRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly Dictionary<UniquePrimitive, JDSRIUAAMBB> JIJJJROUBHR;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static ProfilerMarker FBVPWPZXTAS;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static ProfilerMarker BUYDNRNXQGM;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static ProfilerMarker YXNSKOWYQVY;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static ProfilerMarker HGVEKODVVWA;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static ProfilerMarker TEYIYQNFTWL;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static ProfilerMarker JTZQZBMFUWO;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static ProfilerMarker MGJLYLIXYSA;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static ProfilerMarker DNCHOZBIMNC;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static ProfilerMarker UQBOGAWTJYH;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static ProfilerMarker WJGYRPRWUKP;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static ProfilerMarker KLSEDHPFVNF;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static ProfilerMarker BAXUEPQNXJK;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static ProfilerMarker OTGBLPZLTAU;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static ProfilerMarker IWSMJLLWSEF;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static ProfilerMarker DRNNUSKPYFX;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static ProfilerMarker CLNDPAYMMDQ;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static ProfilerMarker REWHLDWQEKG;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static ProfilerMarker DWUHLYHFIJP;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static ProfilerMarker JTLLANJIITP;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static ProfilerMarker KRVHQSFBWQE;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static ProfilerMarker AJMKUKKCCDK;

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static ProfilerMarker OKPUUHQZDDQ;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private static ProfilerMarker WJEHKCMUUDD;

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private static ProfilerMarker CCEPFDRQLQU;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private static ProfilerMarker AKOZAMHBLTP;

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private static ProfilerMarker EERCZIEZVTS;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static ProfilerMarker TMQSRKBNPPB;

		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private static ProfilerMarker GCXIXBZODES;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static ProfilerMarker JKFJYZYFSQL;

		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private static ProfilerMarker QAOWUHUGXTB;

		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private static ProfilerMarker UEJOOTOGCMG;

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private static ProfilerMarker NEMQMUGBIGB;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private static ProfilerMarker ROTWZHGTCLW;

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private static ProfilerMarker HANEOXDVFKB;

		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private static ProfilerMarker HGVKPHFHERD;

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private static ProfilerMarker DIOISJRGHPA;

		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private static ProfilerMarker NRPBYHBOWQO;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private static ProfilerMarker LSSHQUGJHVT;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static ProfilerMarker ZHUBJKCEWLI;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private static ProfilerMarker JPTXLYGGUTJ;

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private static ProfilerMarker TNILQZJLARI;

		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private static ProfilerMarker CRFTFWWUGVS;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private static ProfilerMarker DODKHUEBMDA;

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static ProfilerMarker YUMUBSUGIWT;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static ProfilerMarker UDFBJDIBSUC;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static ProfilerMarker FMKXHVIUIKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private UnityGLTF.BinaryWriterWithLessAllocations GZGIYSDUQDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private bool? WKWCNNBHLAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		internal readonly List<EWWEHVFYVZR> QPUEBTKNLBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly XTPLBDEGCRK GRCDSEIUUVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private Dictionary<int, int> NXUVDDTAQOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private Dictionary<int, int> IRHWXTNYZPA;

		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[CompilerGenerated]
		private static BeforeSceneExportDelegate TGGSUHVDIMS;

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[CompilerGenerated]
		private static AfterSceneExportDelegate XPSISWXJQFV;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[CompilerGenerated]
		private static AfterNodeExportDelegate XGUTBCAIYDT;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[CompilerGenerated]
		private static BeforeMaterialExportDelegate SYBEISKFSHN;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[CompilerGenerated]
		private static AfterMaterialExportDelegate NUOQYQFPDEE;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static Material SYDOCJUBKXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private HashSet<Material> KWKRUXOZUMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly Dictionary<Mesh, MeshAccessors> YJCLJCBEZGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly Dictionary<Mesh, BlendShapeAccessors> FFDWFTESDGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly Dictionary<SkinnedMeshRenderer, List<double>> YWUDBFQKXXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private List<Transform> XBRWFWVTMWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private Dictionary<SkinnedMeshRenderer, Mesh> FHPNLZBGYKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private Dictionary<SamplerRelevantTextureData, int> KYXIODSKUPM;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public IReadOnlyList<Transform> QFZVLEZUYKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private GLTFSettings ZGAONCAEWSS
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x9F51810", Offset = "0x9F50010", VA = "0x189F51810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private bool ZGYGPUKMDQX
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x9F49DB0", Offset = "0x9F485B0", VA = "0x189F49DB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private bool DMGPXJLRQYO
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x9F43AF0", Offset = "0x9F422F0", VA = "0x189F43AF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private bool QALGUQTZCMZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9F3C100", Offset = "0x9F3A900", VA = "0x189F3C100")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static Material UUSTBZPBUTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9F3A6E0", Offset = "0x9F38EE0", VA = "0x189F3A6E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9F403C0", Offset = "0x9F3EBC0", VA = "0x189F403C0")]
		public TextureExportSettings EDDHXHKOHKJ(string a)
		{
			return default(TextureExportSettings);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9F48680", Offset = "0x9F46E80", VA = "0x189F48680")]
		private Material MNYOYGZBIRG(TextureExportSettings a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9F4D1D0", Offset = "0x9F4B9D0", VA = "0x189F4D1D0")]
		private static Material TPYUSIHVIHT(Material a, TextureExportSettings b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9F55880", Offset = "0x9F54080", VA = "0x189F55880")]
		public GLTFSceneExporter(Transform[] rootTransforms, QEOAQKJBNBK context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9F4A950", Offset = "0x9F49150", VA = "0x189F4A950")]
		public void RTPTXPFOBII(Stream a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9F4D5A0", Offset = "0x9F4BDA0", VA = "0x189F4D5A0")]
		public void VBRSMBLIXED(string a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9F3E810", Offset = "0x9F3D010", VA = "0x189F3E810")]
		private bool DFQJHOACPRY(Transform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9F4B280", Offset = "0x9F49A80", VA = "0x189F4B280")]
		private DAWXZYRRAUE SBQUWXKZXVR(string a, Transform[] b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9F3E970", Offset = "0x9F3D170", VA = "0x189F3E970")]
		private YQPLXVVAQMG DTPZBFSXWQB(Transform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9F3A910", Offset = "0x9F39110", VA = "0x189F3A910")]
		private static bool AGEYDJVBZDB(GameObject a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9F44AE0", Offset = "0x9F432E0", VA = "0x189F44AE0")]
		private void GAIZOHJPAKL(Transform a, [Out] GameObject[] b, [Out] GameObject[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9F43A60", Offset = "0x9F42260", VA = "0x189F43A60")]
		private void FHBKJWNUEWF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9F488F0", Offset = "0x9F470F0", VA = "0x189F488F0")]
		public HOWNCWMIGVN NMCZYAMNBKF(WTVTOFLEGQC a, Material b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9F48370", Offset = "0x9F46B70", VA = "0x189F48370")]
		public CUEDZTDBNVB LPDDGFCLAYZ(WTVTOFLEGQC a, UniqueTexture b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9F3A510", Offset = "0x9F38D10", VA = "0x189F3A510")]
		public NTSIBZNILIJ AFQOJMQRMNF(WTVTOFLEGQC a, Texture b, TextureExportSettings c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9F49DE0", Offset = "0x9F485E0", VA = "0x189F49DE0")]
		private static void RAZTZQBMSJA(Stream a, BinaryWriter b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9F4B710", Offset = "0x9F49F10", VA = "0x189F4B710")]
		private static void SGODXSNDCLV(Stream a, byte b = 32, uint c = 4u)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9F4B260", Offset = "0x9F49A60", VA = "0x189F4B260")]
		public static uint RXKXRDPAHGK(uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9F3D780", Offset = "0x9F3BF80", VA = "0x189F3D780")]
		private ANNHZWNIYUF CSCFSEVIXCC(Vector4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9F43B20", Offset = "0x9F42320", VA = "0x189F43B20")]
		private ANNHZWNIYUF FPAUFKOVOMZ(Quaternion[] a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9F435C0", Offset = "0x9F41DC0", VA = "0x189F435C0")]
		private ANNHZWNIYUF EHEDKQTGJEC(Matrix4x4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9F43090", Offset = "0x9F41890", VA = "0x189F43090")]
		private ANNHZWNIYUF EHEDKQTGJEC(float[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9F40D50", Offset = "0x9F3F550", VA = "0x189F40D50")]
		private ANNHZWNIYUF EHEDKQTGJEC(int[] a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9F406C0", Offset = "0x9F3EEC0", VA = "0x189F406C0")]
		private ANNHZWNIYUF EHEDKQTGJEC(Vector2[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9F42050", Offset = "0x9F40850", VA = "0x189F42050")]
		private ANNHZWNIYUF EHEDKQTGJEC(Vector3[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9F507D0", Offset = "0x9F4EFD0", VA = "0x189F507D0")]
		private ANNHZWNIYUF WUCIXLSOXFY(ANNHZWNIYUF a, Vector3[] b, Vector3[] c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9F42790", Offset = "0x9F40F90", VA = "0x189F42790")]
		private ANNHZWNIYUF EHEDKQTGJEC(Vector4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9F414A0", Offset = "0x9F3FCA0", VA = "0x189F414A0")]
		private ANNHZWNIYUF EHEDKQTGJEC(Color[] a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9F48760", Offset = "0x9F46F60", VA = "0x189F48760")]
		private JDSZTARAOKN NDFZVFOTZJE(uint a, uint b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990")]
		public void FDDGCLEGOPT(Transform a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9F3C280", Offset = "0x9F3AA80", VA = "0x189F3C280")]
		internal int CESHKLYXYMT(object a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9F4D050", Offset = "0x9F4B850", VA = "0x189F4D050")]
		public int SPMTIIEFVCZ(Transform a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9F4D7B0", Offset = "0x9F4BFB0", VA = "0x189F4D7B0")]
		public int VJUADIEQQBK(Material a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9F4D110", Offset = "0x9F4B910", VA = "0x189F4D110")]
		public int SRTSSEGOECZ(Light a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9F45FD0", Offset = "0x9F447D0", VA = "0x189F45FD0")]
		public int ISJUMGCOVIG(Camera a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9F44A50", Offset = "0x9F43250", VA = "0x189F44A50")]
		[IteratorStateMachine(typeof(HGVSJGTUPUK))]
		public IEnumerable<(int, XABKJXLEVAH)> FVOIUHJZCCX(Mesh a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9F52040", Offset = "0x9F50840", VA = "0x189F52040")]
		private static void YCHDCATWNNE(Color a, [Out] Color b, [Out] float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9F474E0", Offset = "0x9F45CE0", VA = "0x189F474E0")]
		private static void IYHZEMHFYXD(Vector4 a, [Out] Vector2 b, [Out] Vector2 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9F4FDF0", Offset = "0x9F4E5F0", VA = "0x189F4FDF0")]
		private bool WEDOWKDYQKI(object[] a, int b, int c, int d, int e, int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9F4FF80", Offset = "0x9F4E780", VA = "0x189F4FF80")]
		public void WFWOQMHPUXA(float[] a, object[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9F52500", Offset = "0x9F50D00", VA = "0x189F52500")]
		public void ZERBIMRUDCM(UnityEngine.Object a, string b, ZCPNPFGNFZG c, float[] d, object[] e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9F3BAF0", Offset = "0x9F3A2F0", VA = "0x189F3BAF0")]
		private void BGWZDWDZZUM(object a, string b, HQYCXRYQMTF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9F44550", Offset = "0x9F42D50", VA = "0x189F44550")]
		private CAHKCJZXWON FPDFHTBECQK(Camera a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9F3E080", Offset = "0x9F3C880", VA = "0x189F3E080")]
		private RAICXMWOJTG CZZHDFLZBZN(Light a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9F4D870", Offset = "0x9F4C070", VA = "0x189F4D870")]
		public HOWNCWMIGVN VLMZMQNOOOA(Material a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9F49A90", Offset = "0x9F48290", VA = "0x189F49A90")]
		private HOWNCWMIGVN QUXCEQEHINB(Material a, OFRYBPDMWCH b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9F45CC0", Offset = "0x9F444C0", VA = "0x189F45CC0")]
		private bool IAXFKLNWLMG(Material a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9F51F80", Offset = "0x9F50780", VA = "0x189F51F80")]
		private bool YAIZYACLEVH(Material a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9F47680", Offset = "0x9F45E80", VA = "0x189F47680")]
		private bool KOPHLVWQTLE(Material a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x9F4B7E0", Offset = "0x9F49FE0", VA = "0x189F4B7E0")]
		private bool SJFJXCHADBQ(Material a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9F4D470", Offset = "0x9F4BC70", VA = "0x189F4D470")]
		private static bool TWGARTMIVAP(Shader a, string b, ShaderPropertyType c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9F3F9D0", Offset = "0x9F3E1D0", VA = "0x189F3F9D0")]
		private void DWFKGJDCQAE(USWQQWDREUK a, Material b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9F52210", Offset = "0x9F50A10", VA = "0x189F52210")]
		public KPEFKKJMQLF YFBVPGASBEF(Texture a, string b, Material c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9F457A0", Offset = "0x9F43FA0", VA = "0x189F457A0")]
		private DKWTFROCKWH GHBPWAUQTQV(Texture a, string b, Material c, [Optional] CUEDZTDBNVB d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9F3AB80", Offset = "0x9F39380", VA = "0x189F3AB80")]
		public FWINARFTNES ATDVHYXLGVG(Material a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9F3D250", Offset = "0x9F3BA50", VA = "0x189F3D250")]
		public void CNVGFJRSAWP(OFRYBPDMWCH a, Material b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9F51830", Offset = "0x9F50030", VA = "0x189F51830")]
		private void XPWXSPELBJO(OFRYBPDMWCH a, Material b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9F45900", Offset = "0x9F44100", VA = "0x189F45900")]
		private CTRATNJFWMP HRRZWLXVLEY(Material a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9F4D510", Offset = "0x9F4BD10", VA = "0x189F4D510")]
		internal static void UCGPZXNTMNO(Color a, [Out] Color b, [Out] float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9F47510", Offset = "0x9F45D10", VA = "0x189F47510")]
		public void JLEWDRQVHKU(BERLEXGGYBZ a, List<UniquePrimitive> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9F48E30", Offset = "0x9F47630", VA = "0x189F48E30")]
		private static List<UniquePrimitive> OWTGPMUOMSK(IEnumerable<GameObject> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x9F3F990", Offset = "0x9F3E190", VA = "0x189F3F990")]
		public YQPLXVVAQMG DTPZBFSXWQB(GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9F4B880", Offset = "0x9F4A080", VA = "0x189F4B880")]
		public JDSRIUAAMBB SOELQOYGUEY(string a, List<UniquePrimitive> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x9F46090", Offset = "0x9F44890", VA = "0x189F46090")]
		private XABKJXLEVAH[] IXNODTRXFAW(UniquePrimitive a, HMCQBNAUHVJ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x9F481D0", Offset = "0x9F469D0", VA = "0x189F481D0")]
		private List<double> LNTZVQMTJIC(SkinnedMeshRenderer a, Mesh b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9F44D60", Offset = "0x9F43560", VA = "0x189F44D60")]
		private void GBYWMNIUSGK(SkinnedMeshRenderer a, Mesh b, int c, XABKJXLEVAH d, HMCQBNAUHVJ e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9F48A40", Offset = "0x9F47240", VA = "0x189F48A40")]
		private static bool NQAGFAIQOXT(XABKJXLEVAH a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x9F52400", Offset = "0x9F50C00", VA = "0x189F52400")]
		private static DrawMode YJRBFHZGQJK(MeshTopology a)
		{
			return default(DrawMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9F48A60", Offset = "0x9F47260", VA = "0x189F48A60")]
		private static bool OCZWABLSDNY(Mesh a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9F4BF80", Offset = "0x9F4A780", VA = "0x189F4BF80")]
		private void SORFIEPTCDK(Transform a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9F495B0", Offset = "0x9F47DB0", VA = "0x189F495B0")]
		private Mesh OZZMHUANCAF(GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9F48050", Offset = "0x9F46850", VA = "0x189F48050")]
		private Material[] LACIYXKXRVK(GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9F48A80", Offset = "0x9F47280", VA = "0x189F48A80")]
		private Vector4[] OKSCBOYFHNW(BoneWeight[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9F45E80", Offset = "0x9F44680", VA = "0x189F45E80")]
		private Vector4[] ILKAYFZKJBA(BoneWeight[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9F48C10", Offset = "0x9F47410", VA = "0x189F48C10")]
		private string OMAFDVAQAWB(HashSet<string> a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9F49EB0", Offset = "0x9F486B0", VA = "0x189F49EB0")]
		public USWQQWDREUK RCZZDHAXKOY(Texture a, string b, [Optional] TextureExportSettings c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9F48590", Offset = "0x9F46D90", VA = "0x189F48590")]
		public USWQQWDREUK MLFORAGFEIR(Material a, Texture b, string c, [Optional] TextureExportSettings d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9F49FC0", Offset = "0x9F487C0", VA = "0x189F49FC0")]
		public CUEDZTDBNVB RJREFOBNEKM(Texture a, string b, [Optional] TextureExportSettings c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x9F497E0", Offset = "0x9F47FE0", VA = "0x189F497E0")]
		private string PZXMLLURHRG(Texture a, TextureExportSettings b, string c, [Out] bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9F476F0", Offset = "0x9F45EF0", VA = "0x189F476F0")]
		private NTSIBZNILIJ KOVNRTIIFMC(UniqueTexture a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x466DF40", Offset = "0x466C740", VA = "0x18466DF40")]
		private bool WBHCBNMFSWZ(TextureExportSettings a, Texture b, [Out] string c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0")]
		private byte[] AXKQWLYSTIF(Texture a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x9F48500", Offset = "0x9F46D00", VA = "0x189F48500")]
		private bool MARSEBMXUGB(Texture a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x9F48150", Offset = "0x9F46950", VA = "0x189F48150")]
		private bool LKHOTMQUNLA(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9F3C5C0", Offset = "0x9F3ADC0", VA = "0x189F3C5C0")]
		private bool CFUXFLCDRYZ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9F3C690", Offset = "0x9F3AE90", VA = "0x189F3C690")]
		private NTSIBZNILIJ CLNIICBJWCV(UniqueTexture a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9F3BC40", Offset = "0x9F3A440", VA = "0x189F3BC40")]
		private CLUJQPIEVOU BLWXZWCJBMP(Texture a)
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
	public class RVLDTTXHBEQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public NWHPLDMHAXL NAUCUNAEMLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public VOPNHUYCENH IGHRWAAAYYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public AsyncCoroutineHelper WGZDHIORFMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public bool SAWASGTLGBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public AnimationMethod EBTMGDBMNCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public bool SWDUYFDZUKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public DeduplicateOptions MDOMPMJFQQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public bool QPLCVEGCZDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public GLTFImporterNormals ECMGATQMJDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public GLTFImporterNormals QWPWQVIGIHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public bool FMGVUPBEOPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public CameraImportOption YITJRYFSBND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public RuntimeTextureCompression DNYUEUFFWBU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public BlendShapeFrameWeightSetting IPNPXABPNPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public GKBIBFXCLMW AOVNXNTZGLH;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public ILogger IJXYKBYNHMP;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9F66550", Offset = "0x9F64D50", VA = "0x189F66550")]
		public RVLDTTXHBEQ()
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
		public float ZSBRJTRDQWI
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x9F65590", Offset = "0x9F63D90", VA = "0x189F65590")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x9F655C0", Offset = "0x9F63DC0", VA = "0x189F655C0", Slot = "3")]
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
		private class PRJQOYQVSXM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Texture LGICPUPIMLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public int VXGZDYOJIOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public double SDLYWKGTQKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Vector2 VBOLXXOSKHS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public double UWXJAJSPRJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Vector2 BDFPJJLKDEX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public int? IKCUVHHQFWF;

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x9F66030", Offset = "0x9F64830", VA = "0x189F66030")]
			public PRJQOYQVSXM()
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
			public AsyncTaskMethodBuilder<KGQVNKKAGMO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public ANNHZWNIYUF accessorId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public bool isPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			private XWLGDPDBHBS <accessor>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			private TaskAwaiter<WWINNTQBYHL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x9F69A60", Offset = "0x9F68260", VA = "0x189F69A60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x9F69F70", Offset = "0x9F68770", VA = "0x189F69F70", Slot = "5")]
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
			public ZCPNPFGNFZG animation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			public TGSVVWJZEJV animationCache;
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class ZPKCVBNAZOI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public WCSOTBUVZFK VISDVIMHXFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			public ValuesConvertion VQHAARXHAKU;

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public ZPKCVBNAZOI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x9F6C800", Offset = "0x9F6B000", VA = "0x189F6C800")]
			internal float[] DIMFFJLWUUU(NumericArray a, int b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class ZPZXMVUTBWJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public bool JEGGFANCIPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			public int KUXEEIPYAEN;

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public ZPZXMVUTBWJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x9F6C910", Offset = "0x9F6B110", VA = "0x189F6C910")]
			internal float[] DJRUOYBGZKW(NumericArray a, int b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class ZPUQPPAVSLA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			public float[] JZOGOGWVPOT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			public BlendShapeFrameWeightSetting WAZNYYETZTK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			public ZPZXMVUTBWJ MNSDRRJEMWM;

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public ZPUQPPAVSLA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x9F6C840", Offset = "0x9F6B040", VA = "0x189F6C840")]
			internal float[] KRSHNWUIYNZ(NumericArray a, int b)
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
			public GYJZSRYWUIU mapper;
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class PHBGZDPNLQC
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
				public PHBGZDPNLQC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400016A")]
				private OFRYBPDMWCH <def>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400016B")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000177")]
				[Cpp2IlInjected.Address(RVA = "0x9F69FE0", Offset = "0x9F687E0", VA = "0x189F69FE0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000178")]
				[Cpp2IlInjected.Address(RVA = "0x9F6A400", Offset = "0x9F68C00", VA = "0x189F6A400", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public int QIEDRASCGEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public GLTFSceneImporter VIXLAPAPYNX;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public PHBGZDPNLQC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x9F65F60", Offset = "0x9F64760", VA = "0x189F65F60")]
			[AsyncStateMachine(typeof(<<LoadMaterialAsync>b__0>d))]
			internal Task JVPSNZWGEMC()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private sealed class LYJNZIYKLHV
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
				public LYJNZIYKLHV <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000172")]
				private HMCQBNAUHVJ <def>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000173")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600017B")]
				[Cpp2IlInjected.Address(RVA = "0x9F6A460", Offset = "0x9F68C60", VA = "0x189F6A460", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600017C")]
				[Cpp2IlInjected.Address(RVA = "0x9F6AA10", Offset = "0x9F69210", VA = "0x189F6AA10", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public int MSTZMOMWXOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public GLTFSceneImporter VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public CancellationToken HDYRLXCNYRD;

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public LYJNZIYKLHV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x9F65E90", Offset = "0x9F64690", VA = "0x189F65E90")]
			[AsyncStateMachine(typeof(<<LoadMeshAsync>b__0>d))]
			internal Task KFCEFGLWUDI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class YTTUZAPBRWE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public GLTFSceneImporter VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public DXCRSXUTICF QSLZIPIABMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public string LJNDGCMBSZW;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public YTTUZAPBRWE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x9F6C710", Offset = "0x9F6AF10", VA = "0x189F6C710")]
			internal Stream WQBPCOXCCWP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x9F6C680", Offset = "0x9F6AE80", VA = "0x189F6C680")]
			internal void WPWIFIDETLG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class YDZYRBBKZSU
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
				public YDZYRBBKZSU <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				public bool onlyMesh;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x4000180")]
				public bool ignoreMesh;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000181")]
				private List<YQPLXVVAQMG>.Enumerator <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000182")]
				private TaskAwaiter<GameObject> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000183")]
				private HMCQBNAUHVJ <mesh>5__3;

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
				[Cpp2IlInjected.Address(RVA = "0x9F67D80", Offset = "0x9F66580", VA = "0x189F67D80", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000184")]
				[Cpp2IlInjected.Address(RVA = "0x9F69A00", Offset = "0x9F68200", VA = "0x189F69A00", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public GameObject CCDZGXELROA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public BERLEXGGYBZ CBWCVBMBGYT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public GLTFSceneImporter VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public CancellationToken HDYRLXCNYRD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public int EUGCWESOSZX;

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public YDZYRBBKZSU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x9F6C4F0", Offset = "0x9F6ACF0", VA = "0x189F6C4F0")]
			[AsyncStateMachine(typeof(<<ConstructNode>g__CreateNodeComponentsAndChilds|0>d))]
			internal Task SCIQCNONLPJ(bool a = false, bool b = false)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x9F6C610", Offset = "0x9F6AE10", VA = "0x189F6C610")]
			internal Material VHKRPWYLOLR(XABKJXLEVAH a)
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
			public ZCPNPFGNFZG animation;

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
			private Dictionary<string, List<KGQVNKKAGMO>> <samplersByType>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			private int <i>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			private YFTAWGGGKEJ <samplerDef>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			private TaskAwaiter<WWINNTQBYHL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x9F6CBB0", Offset = "0x9F6B3B0", VA = "0x189F6CBB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x9F6D860", Offset = "0x9F6C060", VA = "0x189F6D860", Slot = "5")]
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
			public NNQENYBDRHR image;

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
			[Cpp2IlInjected.Address(RVA = "0x9F6D8C0", Offset = "0x9F6C0C0", VA = "0x189F6D8C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x9F6E090", Offset = "0x9F6C890", VA = "0x189F6E090", Slot = "5")]
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
			public BBDSDFOIDBC buffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			private TaskAwaiter<Stream> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x9F6E710", Offset = "0x9F6CF10", VA = "0x189F6E710", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x9F6EF00", Offset = "0x9F6D700", VA = "0x189F6EF00", Slot = "5")]
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
			public BERLEXGGYBZ node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			private List<YQPLXVVAQMG>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x9F6E100", Offset = "0x9F6C900", VA = "0x189F6E100", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x9F6E6B0", Offset = "0x9F6CEB0", VA = "0x189F6E6B0", Slot = "5")]
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
			private ZPKCVBNAZOI <>8__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			private AnimationClip <clip>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			private int[] <nodeIds>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			private BGRGRTJIBVO <pointerImportContext>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			private List<CPFJIWONMQK>.Enumerator <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			private CPFJIWONMQK <channel>5__6;

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
			[Cpp2IlInjected.Address(RVA = "0x9F6EF60", Offset = "0x9F6D760", VA = "0x189F6EF60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x9F72510", Offset = "0x9F70D10", VA = "0x189F72510", Slot = "5")]
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
			public NNQENYBDRHR image;

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
			[Cpp2IlInjected.Address(RVA = "0x9F72C80", Offset = "0x9F71480", VA = "0x189F72C80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x9F73030", Offset = "0x9F71830", VA = "0x189F73030", Slot = "5")]
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
			public RAWOIEBXRSB texture;

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
			[Cpp2IlInjected.Address(RVA = "0x9F72580", Offset = "0x9F70D80", VA = "0x189F72580", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x9F72C20", Offset = "0x9F71420", VA = "0x189F72C20", Slot = "5")]
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
			public BERLEXGGYBZ node;

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
			private IDZXXQPYFYK <lodsExtension>5__2;

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
			[Cpp2IlInjected.Address(RVA = "0x9F73090", Offset = "0x9F71890", VA = "0x189F73090", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x9F73C30", Offset = "0x9F72430", VA = "0x189F73C30", Slot = "5")]
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
			public OFRYBPDMWCH def;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			private <>c__DisplayClass119_0 <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			public int materialIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			private EHTIMGTBALW <mrMapper>5__2;

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
			private QTFFZSGRMLV <sgMapper>5__12;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			private WSOZWSFFDDC <unlitMapper>5__13;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			private MNVNIVFMJEP <sheenMapper>5__14;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			private YUQSXNHTQXW <anisotropyMapper>5__15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			private XUNYDFKQVDG <transmissionMapper>5__16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			private PUMEVMLZKGK <volumeMapper>5__17;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			private UZQSYDOJWFC <iridescenceMapper>5__18;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			private EEFKXKVAYCH <specularMapper>5__19;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			private WJXOENUBRZM <clearcoatMapper>5__20;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			private KACXEGMDKDN <uniformMapper>5__21;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			private FWINARFTNES <pbr>5__22;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			private CUEDZTDBNVB <textureId>5__23;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			private MSHAEGPIMOE <specGloss>5__24;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			private KHR_materials_sheen <sheen>5__25;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			private TaskAwaiter<PRJQOYQVSXM> <>u__2;

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
			private XULSYQARDCX <clearcoatNormalMapper>5__32;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x9F73C90", Offset = "0x9F72490", VA = "0x189F73C90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x9F7BA50", Offset = "0x9F7A250", VA = "0x189F7BA50", Slot = "5")]
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
			public HMCQBNAUHVJ mesh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			private BDZRJNDXSAM <meshCache>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			private PNFTVZIKROF <unityData>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400020E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			private int <i>5__4;

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x9F7D210", Offset = "0x9F7BA10", VA = "0x189F7D210", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x9F7DC40", Offset = "0x9F7C440", VA = "0x189F7DC40", Slot = "5")]
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
			public JDSRIUAAMBB meshId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public HMCQBNAUHVJ mesh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000215")]
			private int <meshIndex>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			private int <i>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000217")]
			private XABKJXLEVAH <primitive>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x9F7BAB0", Offset = "0x9F7A2B0", VA = "0x189F7BAB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x9F7C100", Offset = "0x9F7A900", VA = "0x189F7C100", Slot = "5")]
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
			public XABKJXLEVAH primitive;

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
			private List<Dictionary<string, KGQVNKKAGMO>> <newTargets>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			private int <i>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			private Dictionary<string, ANNHZWNIYUF>.Enumerator <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000222")]
			private KeyValuePair<string, ANNHZWNIYUF> <targetAttribute>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000223")]
			private int <bufferID>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000224")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			private TaskAwaiter<WWINNTQBYHL> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x9F7C160", Offset = "0x9F7A960", VA = "0x189F7C160", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x9F7D1B0", Offset = "0x9F7B9B0", VA = "0x189F7D1B0", Slot = "5")]
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
			public BERLEXGGYBZ node;

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
			private YDZYRBBKZSU <>8__1;

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
			[Cpp2IlInjected.Address(RVA = "0x9F7DCA0", Offset = "0x9F7C4A0", VA = "0x189F7DCA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x9F7EE40", Offset = "0x9F7D640", VA = "0x189F7EE40", Slot = "5")]
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
			public XABKJXLEVAH primitive;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000239")]
			private BDZRJNDXSAM.CVUXWNXPKIK <primData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400023A")]
			private Dictionary<string, ANNHZWNIYUF>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400023B")]
			private KeyValuePair<string, ANNHZWNIYUF> <attributePair>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400023C")]
			private DAPTVCNOKYI <sparse>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400023D")]
			private TaskAwaiter<WWINNTQBYHL> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400023E")]
			private KGQVNKKAGMO <sparseValues>5__6;

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x9F83540", Offset = "0x9F81D40", VA = "0x189F83540", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x9F84680", Offset = "0x9F82E80", VA = "0x189F84680", Slot = "5")]
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
			public FHGUWOJFITY scene;

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
			[Cpp2IlInjected.Address(RVA = "0x9F846E0", Offset = "0x9F82EE0", VA = "0x189F846E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x9F853F0", Offset = "0x9F83BF0", VA = "0x189F853F0", Slot = "5")]
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
			public RAWOIEBXRSB texture;

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
			private NNQENYBDRHR <image>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000258")]
			private bool <isFirstInstance>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000259")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x9F85450", Offset = "0x9F83C50", VA = "0x189F85450", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x9F866D0", Offset = "0x9F84ED0", VA = "0x189F866D0", Slot = "5")]
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
			public PNFTVZIKROF unityMeshData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000260")]
			private Mesh <mesh>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000261")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x9F86730", Offset = "0x9F84F30", VA = "0x189F86730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x9F87850", Offset = "0x9F86050", VA = "0x189F87850", Slot = "5")]
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
			public NNQENYBDRHR image;

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
			private WWINNTQBYHL <bufferView>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400026E")]
			private TaskAwaiter<WWINNTQBYHL> <>u__1;

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
			[Cpp2IlInjected.Address(RVA = "0x9F878B0", Offset = "0x9F860B0", VA = "0x189F878B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x9F89390", Offset = "0x9F87B90", VA = "0x189F89390", Slot = "5")]
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
			public XABKJXLEVAH primitive;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000277")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000278")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x9F89A80", Offset = "0x9F88280", VA = "0x189F89A80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x9F89D20", Offset = "0x9F88520", VA = "0x189F89D20", Slot = "5")]
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
			public HMCQBNAUHVJ mesh;

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
			[Cpp2IlInjected.Address(RVA = "0x9F89D80", Offset = "0x9F88580", VA = "0x189F89D80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x9F89F80", Offset = "0x9F88780", VA = "0x189F89F80", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F89FE0", Offset = "0x9F887E0", VA = "0x189F89FE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x9F8A460", Offset = "0x9F88C60", VA = "0x189F8A460", Slot = "5")]
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
			public AsyncTaskMethodBuilder<PRJQOYQVSXM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000286")]
			public USWQQWDREUK textureInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000287")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000288")]
			public bool isNormal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000289")]
			private PRJQOYQVSXM <result>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400028A")]
			private CUEDZTDBNVB <textureId>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400028B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x9F8A4C0", Offset = "0x9F88CC0", VA = "0x189F8A4C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x9F8AA80", Offset = "0x9F89280", VA = "0x189F8AA80", Slot = "5")]
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
			public AsyncTaskMethodBuilder<WWINNTQBYHL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400028E")]
			public CPXGVJRXHMQ bufferId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400028F")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000290")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x9F8AAF0", Offset = "0x9F892F0", VA = "0x189F8AAF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x9F8AD80", Offset = "0x9F89580", VA = "0x189F8AD80", Slot = "5")]
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
			public BERLEXGGYBZ node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000295")]
			private KGQVNKKAGMO <positionsAttr>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000296")]
			private KGQVNKKAGMO <rotationAttr>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000297")]
			private KGQVNKKAGMO <scaleAttr>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000298")]
			private EXT_mesh_gpu_instancing <extMeshGPUInstancing>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000299")]
			private int <instancesCount>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400029A")]
			private TaskAwaiter<KGQVNKKAGMO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x9F8ADF0", Offset = "0x9F895F0", VA = "0x189F8ADF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x9F8BA40", Offset = "0x9F8A240", VA = "0x189F8BA40", Slot = "5")]
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
			private BERLEXGGYBZ <node>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002A2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002A3")]
			private IDZXXQPYFYK <lodsExtension>5__4;

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
			[Cpp2IlInjected.Address(RVA = "0x9F8BAB0", Offset = "0x9F8A2B0", VA = "0x189F8BAB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x9F8C920", Offset = "0x9F8B120", VA = "0x189F8C920", Slot = "5")]
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
			private YTTUZAPBRWE <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002AC")]
			private TaskAwaiter<Stream> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002AD")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x9F8C990", Offset = "0x9F8B190", VA = "0x189F8C990", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x9F8D0D0", Offset = "0x9F8B8D0", VA = "0x189F8D0D0", Slot = "5")]
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
			private PHBGZDPNLQC <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002B3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x9F8D130", Offset = "0x9F8B930", VA = "0x189F8D130", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x9F8D430", Offset = "0x9F8BC30", VA = "0x189F8D430", Slot = "5")]
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
			private LYJNZIYKLHV <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002BA")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x9F8D4A0", Offset = "0x9F8BCA0", VA = "0x189F8D4A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x9F8D7C0", Offset = "0x9F8BFC0", VA = "0x189F8D7C0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F8D830", Offset = "0x9F8C030", VA = "0x189F8D830", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x9F8E8A0", Offset = "0x9F8D0A0", VA = "0x189F8E8A0", Slot = "5")]
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
			private OFRYBPDMWCH <def>5__3;

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x9F8E900", Offset = "0x9F8D100", VA = "0x189F8E900", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x9F8ED70", Offset = "0x9F8D570", VA = "0x189F8ED70", Slot = "5")]
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
			private HMCQBNAUHVJ <gltfMesh>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002D0")]
			private int <i>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002D1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x9F8EDD0", Offset = "0x9F8D5D0", VA = "0x189F8EDD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x9F8F480", Offset = "0x9F8DC80", VA = "0x189F8F480", Slot = "5")]
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
			public XLGFUPUXDAO skin;

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
			private TaskAwaiter<WWINNTQBYHL> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			private int <i>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40002DE")]
			private TaskAwaiter<GameObject> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x9F8F4E0", Offset = "0x9F8DCE0", VA = "0x189F8F4E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x9F8FFC0", Offset = "0x9F8E7C0", VA = "0x189F8FFC0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F90020", Offset = "0x9F8E820", VA = "0x189F90020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x9F90620", Offset = "0x9F8EE20", VA = "0x189F90620", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F90890", Offset = "0x9F8F090", VA = "0x189F90890", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x9F90AB0", Offset = "0x9F8F2B0", VA = "0x189F90AB0", Slot = "5")]
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
			private FHGUWOJFITY <scene>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x9F90B10", Offset = "0x9F8F310", VA = "0x189F90B10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x9F917D0", Offset = "0x9F8FFD0", VA = "0x189F917D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public int SVXRMNCWUVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public int KIEFHWBXTVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private bool MJDYVIJSSQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private bool SNORZKDUFIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private Dictionary<Stream, NativeArray<byte>> CJKKNDLJZYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public bool KQMYOIHLBLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public bool GGUPOBZDBJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public bool BVXNEKGBPHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x63")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public bool KFOZAGIPWXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public bool KVCDOCXPYJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public ImportStatistics DYHAIDDIPPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		protected RVLDTTXHBEQ ORXLXWMWGBY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		protected UGTMLBJAJRF FBWYLPFMJXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		protected GameObject BENNFENRJXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		protected readonly OFRYBPDMWCH UUSTBZPBUTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		internal LWOCUPPHHEE ZXPCLCLJZON;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		protected string SBWSPFJJTOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		protected GLBStream WILFMXXCHIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		protected WTVTOFLEGQC PUVUBDHQCSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		protected GQZMQGTLBER IXGHKUXWEJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		protected bool WGOEHTZWBVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		protected ImportProgress ZSWEMBVUNLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		protected IProgress<ImportProgress> DBYHETESNMQ;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static ILogger YPSRVFCUKIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		protected ColorSpace IOAUAEJIKUZ;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		internal static List<Texture> CWNUCVJQYAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private Dictionary<int, int> PWTWGYPWLZR;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool TZROHFKLYMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x9F5DFD0", Offset = "0x9F5C7D0", VA = "0x189F5DFD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xAA2A00", Offset = "0xAA1200", VA = "0x180AA2A00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public WTVTOFLEGQC XQVYPEOBNLV
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xC11710", Offset = "0xC0FF10", VA = "0x180C11710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Transform JFZCHVLMXXP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AB0", Offset = "0xAA02B0", VA = "0x180AA1AB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xAA1370", Offset = "0xA9FB70", VA = "0x180AA1370")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public GameObject FDLVRLJCVFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xAA15F0", Offset = "0xA9FDF0", VA = "0x180AA15F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0xAA1380", Offset = "0xA9FB80", VA = "0x180AA1380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private AnimationClip[] QCCMYIDEPWY
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xAA1600", Offset = "0xA9FE00", VA = "0x180AA1600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ColliderType ESJPIOCSSPR
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xACF250", Offset = "0xACDA50", VA = "0x180ACF250")]
			[CompilerGenerated]
			get
			{
				return default(ColliderType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xB350E0", Offset = "0xB338E0", VA = "0x180B350E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public string PEVLCZJBIOW
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xAA8580", Offset = "0xAA6D80", VA = "0x180AA8580")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xAA7D80", Offset = "0xAA6580", VA = "0x180AA7D80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public GameObject EWFWLLEJZQW
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xAA38F0", Offset = "0xAA20F0", VA = "0x180AA38F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public SEXIHJFRYDC[] KCNNHFBRAAI
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x9F61FB0", Offset = "0x9F607B0", VA = "0x189F61FB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Texture2D[] KPADOOMCQUD
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x9F606A0", Offset = "0x9F5EEA0", VA = "0x189F606A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public LWOCUPPHHEE[] TLLKJXMNJCI
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x9F5AA00", Offset = "0x9F59200", VA = "0x189F5AA00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public TGSVVWJZEJV[] TIPRHHFMTRJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x9F5E050", Offset = "0x9F5C850", VA = "0x189F5E050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public BDZRJNDXSAM[] LSMTJRUKJJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x9F5CBF0", Offset = "0x9F5B3F0", VA = "0x189F5CBF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public List<UnityEngine.Object> JHYLRPUOTEV
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xA9E160", Offset = "0xA9C960", VA = "0x180A9E160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected GKBIBFXCLMW CZBFJPEOKFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x9F5AC60", Offset = "0x9F59460", VA = "0x189F5AC60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x9F64900", Offset = "0x9F63100", VA = "0x189F64900")]
		public GLTFSceneImporter(string gltfFileName, RVLDTTXHBEQ options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x9F64950", Offset = "0x9F63150", VA = "0x189F64950")]
		public GLTFSceneImporter(Stream gltfStream, RVLDTTXHBEQ options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x9F64A50", Offset = "0x9F63250", VA = "0x189F64A50")]
		private GLTFSceneImporter(RVLDTTXHBEQ options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x9F59C90", Offset = "0x9F58490", VA = "0x189F59C90")]
		private NativeArray<byte> FYSOZYHKLCJ(Stream a)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x9F599E0", Offset = "0x9F581E0", VA = "0x189F599E0")]
		private void FWVGTVPWQWN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x9F59050", Offset = "0x9F57850", VA = "0x189F59050", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x9F5FE20", Offset = "0x9F5E620", VA = "0x189F5FE20")]
		[AsyncStateMachine(typeof(<LoadSceneAsync>d__81))]
		public Task RZXDKPKWDGT(int a = -1, bool b = true, [Optional] Action<GameObject, ExceptionDispatchInfo> c, [Optional] CancellationToken d, [Optional] IProgress<ImportProgress> e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x9F58240", Offset = "0x9F56A40", VA = "0x189F58240")]
		[AsyncStateMachine(typeof(<LoadUnreferencedAssetsAsync>d__82))]
		private Task AWGGCGQISVA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x9F5D0F0", Offset = "0x9F5B8F0", VA = "0x189F5D0F0", Slot = "5")]
		[AsyncStateMachine(typeof(<LoadMaterialAsync>d__85))]
		public virtual Task<Material> LUTRETOVLCG(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x9F58790", Offset = "0x9F56F90", VA = "0x189F58790", Slot = "6")]
		[AsyncStateMachine(typeof(<LoadMeshAsync>d__86))]
		public virtual Task<Mesh> CLBWLKCTGZQ(int a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x9F58F50", Offset = "0x9F57750", VA = "0x189F58F50")]
		[AsyncStateMachine(typeof(<LoadJson>d__87))]
		private Task DVZQGVKMIYR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x9F5EE00", Offset = "0x9F5D600", VA = "0x189F5EE00")]
		private void RJJPUWNEUUE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x9F61940", Offset = "0x9F60140", VA = "0x189F61940")]
		[AsyncStateMachine(typeof(<_LoadScene>d__90))]
		protected Task VEDYOHRGBAM(int a = -1, bool b = true, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x9F592A0", Offset = "0x9F57AA0", VA = "0x189F592A0")]
		private void EMSUWOGNNWC(FHGUWOJFITY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9F58160", Offset = "0x9F56960", VA = "0x189F58160")]
		public NativeArray<byte> AODSSUOXRCG(TJHKYMCWPRO a)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9F583F0", Offset = "0x9F56BF0", VA = "0x189F583F0")]
		[AsyncStateMachine(typeof(<GetBufferData>d__93))]
		private Task<WWINNTQBYHL> BQWQBXOJWOP(CPXGVJRXHMQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9F64760", Offset = "0x9F62F60", VA = "0x189F64760")]
		private float ZKKBUWAZZXY(List<double> a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9F63D20", Offset = "0x9F62520", VA = "0x189F63D20")]
		[AsyncStateMachine(typeof(<GetNode>d__95))]
		private Task<GameObject> WQQUKUHPEMV(int a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x9F59170", Offset = "0x9F57970", VA = "0x189F59170")]
		[AsyncStateMachine(typeof(<GetInstancesTRS>d__96))]
		private Task<(Vector3, Quaternion, Vector3)[]> EKCULQUAFFE(BERLEXGGYBZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9F5D760", Offset = "0x9F5BF60", VA = "0x189F5D760")]
		private bool MLOVDNVOOHX(BERLEXGGYBZ a, GameObject b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x9F63F90", Offset = "0x9F62790", VA = "0x189F63F90", Slot = "7")]
		[AsyncStateMachine(typeof(<ConstructNode>d__98))]
		protected virtual Task XHIWWVMJOFW(BERLEXGGYBZ a, int b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x9F5CAD0", Offset = "0x9F5B2D0", VA = "0x189F5CAD0")]
		[AsyncStateMachine(typeof(<ConstructBufferData>d__99))]
		private Task KQVZWQNHBWO(BERLEXGGYBZ a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x9F59F20", Offset = "0x9F58720", VA = "0x189F59F20")]
		[AsyncStateMachine(typeof(<ConstructBuffer>d__100))]
		protected Task GALOFCLMTXE(BBDSDFOIDBC a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9F5AC80", Offset = "0x9F59480", VA = "0x189F5AC80", Slot = "8")]
		[AsyncStateMachine(typeof(<ConstructScene>d__101))]
		protected virtual Task HWAOWJTVBZO(FHGUWOJFITY a, bool b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9F5E710", Offset = "0x9F5CF10", VA = "0x189F5E710", Slot = "9")]
		protected virtual WWINNTQBYHL PCZJRKMTQWN(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9F58CD0", Offset = "0x9F574D0", VA = "0x189F58CD0")]
		private void Cleanup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9F595F0", Offset = "0x9F57DF0", VA = "0x189F595F0")]
		private void EOLQKKJUIWG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9F605B0", Offset = "0x9F5EDB0", VA = "0x189F605B0")]
		[AsyncStateMachine(typeof(<SetupLoad>d__107))]
		private Task TYRVHNOVNWA(Func<Task> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9F590A0", Offset = "0x9F578A0", VA = "0x189F590A0")]
		[AsyncStateMachine(typeof(<YieldOnTimeoutAndThrowOnLowMemory>d__108))]
		protected Task EHLZUAGNFAH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9F5E820", Offset = "0x9F5D020", VA = "0x189F5E820")]
		private static string PDLAWSCYEAE(Transform a, Transform b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9F57F60", Offset = "0x9F56760", VA = "0x189F57F60", Slot = "10")]
		[AsyncStateMachine(typeof(<BuildAnimationSamplers>d__110))]
		protected virtual Task AEGIVYAQTJS(ZCPNPFGNFZG a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9F62260", Offset = "0x9F60A60", VA = "0x189F62260")]
		protected void VQLEJBMUVTW(AnimationClip a, string b, string[] c, NumericArray d, NumericArray e, InterpolationType f, Type g, ValuesConvertion h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9F61750", Offset = "0x9F5FF50", VA = "0x189F61750")]
		private void UXXMPCXFPYZ(Keyframe[] a, int b, InterpolationType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9F5EC20", Offset = "0x9F5D420", VA = "0x189F5EC20")]
		private static float QRXCDWVOZDB(Keyframe[] a, int b, bool c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9F640D0", Offset = "0x9F628D0", VA = "0x189F640D0")]
		[AsyncStateMachine(typeof(<ConstructClip>d__114))]
		protected Task<AnimationClip> YMAONRRULEW(Transform a, int b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A2B0", Offset = "0x9F58AB0", VA = "0x189F5A2B0")]
		private bool GZVUXPAGEJB(GameObject a, BERLEXGGYBZ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9F61A60", Offset = "0x9F60260", VA = "0x189F61A60")]
		private bool VIULSMYIPOB(GameObject a, BERLEXGGYBZ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9F58A00", Offset = "0x9F57200", VA = "0x189F58A00")]
		[AsyncStateMachine(typeof(<ConstructLods>d__117))]
		private Task CTSAGEGVFBS(WTVTOFLEGQC a, GameObject b, BERLEXGGYBZ c, int d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9F5AA20", Offset = "0x9F59220", VA = "0x189F5AA20", Slot = "11")]
		[AsyncStateMachine(typeof(<ConstructMaterial>d__119))]
		protected virtual Task HHKDRCCZSKB(OFRYBPDMWCH a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x9F5BCA0", Offset = "0x9F5A4A0", VA = "0x189F5BCA0", Slot = "12")]
		protected virtual Task KKMXLVVSKGB(OFRYBPDMWCH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9F59780", Offset = "0x9F57F80", VA = "0x189F59780", Slot = "13")]
		protected virtual JDONLAFOJHG FIHLOQRBIDS(USWQQWDREUK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9F5B900", Offset = "0x9F5A100", VA = "0x189F5B900", Slot = "14")]
		protected virtual KHR_materials_emissive_strength KETIJJGMEZF(OFRYBPDMWCH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9F58BA0", Offset = "0x9F573A0", VA = "0x189F58BA0", Slot = "15")]
		protected virtual KHR_materials_transmission CWZNCKCHOSZ(OFRYBPDMWCH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9F5DEA0", Offset = "0x9F5C6A0", VA = "0x189F5DEA0", Slot = "16")]
		protected virtual KHR_materials_sheen NJHWKYGBFGW(OFRYBPDMWCH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9F5DD70", Offset = "0x9F5C570", VA = "0x189F5DD70", Slot = "17")]
		protected virtual KHR_materials_anisotropy NFHNQLNNFTL(OFRYBPDMWCH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9F5E9D0", Offset = "0x9F5D1D0", VA = "0x189F5E9D0", Slot = "18")]
		protected virtual KHR_materials_dispersion PTUWPMDJEZR(OFRYBPDMWCH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9F5D630", Offset = "0x9F5BE30", VA = "0x189F5D630", Slot = "19")]
		protected virtual KHR_materials_volume MJMFWWAJPVR(OFRYBPDMWCH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9F64630", Offset = "0x9F62E30", VA = "0x189F64630", Slot = "20")]
		protected virtual KHR_materials_ior ZDMILNIUYMJ(OFRYBPDMWCH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x9F598B0", Offset = "0x9F580B0", VA = "0x189F598B0", Slot = "21")]
		protected virtual KHR_materials_iridescence FLXTHKLOPZF(OFRYBPDMWCH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x9F63A90", Offset = "0x9F62290", VA = "0x189F63A90", Slot = "22")]
		protected virtual KHR_materials_specular WIWYPLQSNXO(OFRYBPDMWCH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9F63E60", Offset = "0x9F62660", VA = "0x189F63E60", Slot = "23")]
		protected virtual KHR_materials_clearcoat XDFSZWYKPEV(OFRYBPDMWCH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x9F58D20", Offset = "0x9F57520", VA = "0x189F58D20")]
		[AsyncStateMachine(typeof(<CreateMaterials>d__132))]
		private Task DCUTIWPRFUX(XABKJXLEVAH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9F5DC40", Offset = "0x9F5C440", VA = "0x189F5DC40", Slot = "24")]
		[AsyncStateMachine(typeof(<ConstructMesh>d__133))]
		protected virtual Task NAOTPWLXJLX(HMCQBNAUHVJ a, int b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x9F59B90", Offset = "0x9F58390", VA = "0x189F59B90")]
		[AsyncStateMachine(typeof(<CreateMeshMaterials>d__134))]
		private Task FXSCVSNCLMU(HMCQBNAUHVJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9F5D200", Offset = "0x9F5BA00", VA = "0x189F5D200")]
		private static uint[] MANSXVBRRVL(HMCQBNAUHVJ a, [Out] uint b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A030", Offset = "0x9F58830", VA = "0x189F5A030")]
		protected void GJTBQPTULDU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9F5BA30", Offset = "0x9F5A230", VA = "0x189F5BA30")]
		protected void KFRIXIGIZCO(Mesh a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9F62B70", Offset = "0x9F61370", VA = "0x189F62B70")]
		private PNFTVZIKROF VSFQROUFLNP(HMCQBNAUHVJ a, int b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9F61620", Offset = "0x9F5FE20", VA = "0x189F61620")]
		[AsyncStateMachine(typeof(<ConstructUnityMesh>d__139))]
		protected Task UTNOPROEBZK(PNFTVZIKROF a, int b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x9F5AEF0", Offset = "0x9F596F0", VA = "0x189F5AEF0")]
		private void JOJHKBOATTJ(PNFTVZIKROF a, int b, Mesh c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9F5B170", Offset = "0x9F59970", VA = "0x189F5B170", Slot = "25")]
		[AsyncStateMachine(typeof(<ConstructMeshTargetsPrepareBuffers>d__141))]
		protected virtual Task JWSUORZHXVZ(XABKJXLEVAH a, int b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x9F606C0", Offset = "0x9F5EEC0", VA = "0x189F606C0", Slot = "26")]
		protected virtual void UPWKODBOWBT(XABKJXLEVAH a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x9F5B2A0", Offset = "0x9F59AA0", VA = "0x189F5B2A0")]
		private void JXPVJNGFDKV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9F58310", Offset = "0x9F56B10", VA = "0x189F58310")]
		[AsyncStateMachine(typeof(<PreparePrimitiveAttributes>d__144))]
		private Task BJAYYRLEEQG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9F5EB00", Offset = "0x9F5D300", VA = "0x189F5EB00")]
		[AsyncStateMachine(typeof(<ConstructMeshAttributes>d__145))]
		private Task QQXMQYEKANW(HMCQBNAUHVJ a, JDSRIUAAMBB b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9F58E10", Offset = "0x9F57610", VA = "0x189F58E10", Slot = "27")]
		[AsyncStateMachine(typeof(<ConstructPrimitiveAttributes>d__146))]
		protected virtual Task DSJXPQEMDCU(XABKJXLEVAH a, int b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x9F5EF40", Offset = "0x9F5D740", VA = "0x189F5EF40")]
		protected void RNZQMHUYRYV(BDZRJNDXSAM.CVUXWNXPKIK a, PNFTVZIKROF b, uint c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x9F5E3B0", Offset = "0x9F5CBB0", VA = "0x189F5E3B0")]
		private void ORSCIEQDFYF(Dictionary<string, KGQVNKKAGMO> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x9F61FD0", Offset = "0x9F607D0", VA = "0x189F61FD0")]
		protected MeshTopology VMFBUWXSLHK(DrawMode a)
		{
			return default(MeshTopology);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9F5D850", Offset = "0x9F5C050", VA = "0x189F5D850")]
		private void MPICESRAXLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x9F588C0", Offset = "0x9F570C0", VA = "0x189F588C0", Slot = "28")]
		[AsyncStateMachine(typeof(<SetupBones>d__153))]
		protected virtual Task CNABWFPTLKT(XLGFUPUXDAO a, SkinnedMeshRenderer b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9F64230", Offset = "0x9F62A30", VA = "0x189F64230")]
		private void YPAZASWYFIC(Vector4[] a, Vector4[] b, BoneWeight[] c, uint d = 0u)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x9F58080", Offset = "0x9F56880", VA = "0x189F58080")]
		[AsyncStateMachine(typeof(<CreateNotReferencedTexture>d__158))]
		private Task AMNYULIKTDM(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x9F5FF60", Offset = "0x9F5E760", VA = "0x189F5FF60")]
		[AsyncStateMachine(typeof(<FromTextureInfo>d__159))]
		private Task<PRJQOYQVSXM> SAIIBIBPNOG(USWQQWDREUK a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x9F58B40", Offset = "0x9F57340", VA = "0x189F58B40")]
		private static int CTSEQEKXYMM(byte[] a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x9F5E070", Offset = "0x9F5C870", VA = "0x189F5E070")]
		private Dictionary<int, int> OOXCSJQHMMQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x9F5CE20", Offset = "0x9F5B620", VA = "0x189F5CE20")]
		private void LSPRUCDTWCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x9F600A0", Offset = "0x9F5E8A0", VA = "0x189F600A0")]
		private Stream SGKUQZZXIUK(NNQENYBDRHR a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x9F5E5D0", Offset = "0x9F5CDD0", VA = "0x189F5E5D0")]
		[AsyncStateMachine(typeof(<ConstructImage>d__164))]
		protected Task OZTJPNSPANP(NNQENYBDRHR a, int b, bool c, bool d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A8E0", Offset = "0x9F590E0", VA = "0x189F5A8E0")]
		[AsyncStateMachine(typeof(<ConstructImageBuffer>d__165))]
		protected Task HAAFIPJTUDJ(RAWOIEBXRSB a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9F63BC0", Offset = "0x9F623C0", VA = "0x189F63BC0")]
		[AsyncStateMachine(typeof(<CheckMimeTypeAndLoadImage>d__166))]
		private Task<Texture2D> WIXLPQAMCOX(NNQENYBDRHR a, Texture2D b, NativeArray<byte> c, bool d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9F5D4F0", Offset = "0x9F5BCF0", VA = "0x189F5D4F0", Slot = "29")]
		[AsyncStateMachine(typeof(<ConstructUnityTexture>d__167))]
		protected virtual Task MBMDKOACYCM(Stream a, bool b, bool c, bool d, NNQENYBDRHR e, int f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x9F60280", Offset = "0x9F5EA80", VA = "0x189F60280", Slot = "30")]
		protected virtual int SVMOMZURQYE(RAWOIEBXRSB a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9F60540", Offset = "0x9F5ED40", VA = "0x189F60540", Slot = "31")]
		protected virtual bool TOLQXRCRBJY(RAWOIEBXRSB a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x9F5ADB0", Offset = "0x9F595B0", VA = "0x189F5ADB0", Slot = "32")]
		[AsyncStateMachine(typeof(<ConstructTexture>d__173))]
		protected virtual Task IWLWIOLZXNR(RAWOIEBXRSB a, int b, bool c, bool d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x9F5AB20", Offset = "0x9F59320", VA = "0x189F5AB20")]
		[AsyncStateMachine(typeof(<<GetInstancesTRS>g__GetAttrAccessorAndAccessorContent|96_0>d))]
		[CompilerGenerated]
		private Task<KGQVNKKAGMO> HKVXGWKRMUU(ANNHZWNIYUF a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9F58500", Offset = "0x9F56D00", VA = "0x189F58500")]
		[CompilerGenerated]
		internal static KGQVNKKAGMO CFIFJJJMOLQ(string a, <>c__DisplayClass114_0 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x9F603E0", Offset = "0x9F5EBE0", VA = "0x189F603E0")]
		[CompilerGenerated]
		private void TFZNYWCGIJH(CUEDZTDBNVB a, JDONLAFOJHG b, [Out] Vector2 c, [Out] Vector2 d, <>c__DisplayClass119_0 e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x9F62190", Offset = "0x9F60990", VA = "0x189F62190")]
		[CompilerGenerated]
		private void VOPWTACQKOQ(<>c__DisplayClass119_0 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A6F0", Offset = "0x9F58EF0", VA = "0x189F5A6F0")]
		[CompilerGenerated]
		private void GZWBIAEJDUT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x9F5CC10", Offset = "0x9F5B410", VA = "0x189F5CC10")]
		[CompilerGenerated]
		private TextureWrapMode LSDACBMZOSY(GLTF.Schema.WrapMode a)
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
		private sealed class PUTROGZEIXJ<a> where a : GLTFPlugin
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			public Type IWPIAMOVKMI;

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public PUTROGZEIXJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x5B18D40", Offset = "0x5B17540", VA = "0x185B18D40")]
			internal bool REAMKNVXCBP(a a)
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
		public string HRMIJOUGJNS
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x9F80930", Offset = "0x9F7F130", VA = "0x189F80930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool ZGYGPUKMDQX
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xB02810", Offset = "0xB01010", VA = "0x180B02810")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0xB03320", Offset = "0xB01B20", VA = "0x180B03320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool AWPXTXTSJVR
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xC8B640", Offset = "0xC89E40", VA = "0x180C8B640")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xCD61F0", Offset = "0xCD49F0", VA = "0x180CD61F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool IXTBAQOEGCE
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x17F1580", Offset = "0x17EFD80", VA = "0x1817F1580")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x18306F0", Offset = "0x182EEF0", VA = "0x1818306F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool DRACRJBJEGP
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xC54BC0", Offset = "0xC533C0", VA = "0x180C54BC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xC54BD0", Offset = "0xC533D0", VA = "0x180C54BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool TDQCULWOKEZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xC54BB0", Offset = "0xC533B0", VA = "0x180C54BB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xC546F0", Offset = "0xC52EF0", VA = "0x180C546F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool WGPLZAQLJMX
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x241A3C0", Offset = "0x2418BC0", VA = "0x18241A3C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x241A540", Offset = "0x2418D40", VA = "0x18241A540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public int DPBPKVFNLVJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xACF250", Offset = "0xACDA50", VA = "0x180ACF250")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xB350E0", Offset = "0xB338E0", VA = "0x180B350E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool YMTXQUKZBTX
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x1E22A00", Offset = "0x1E21200", VA = "0x181E22A00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x8449080", Offset = "0x8447880", VA = "0x188449080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool DMGPXJLRQYO
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xC20850", Offset = "0xC1F050", VA = "0x180C20850")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xCFA6B0", Offset = "0xCF8EB0", VA = "0x180CFA6B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool OUWHZPIHQBN
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xCFA7C0", Offset = "0xCF8FC0", VA = "0x180CFA7C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xCFA7F0", Offset = "0xCF8FF0", VA = "0x180CFA7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		[Obsolete("Add/remove \"AnimationPointerPlugin\" from ExportPlugins instead.")]
		public bool QALGUQTZCMZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x9F80940", Offset = "0x9F7F140", VA = "0x189F80940")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x9F80A60", Offset = "0x9F7F260", VA = "0x189F80A60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool NLDCWYAWUBQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xCFA6C0", Offset = "0xCF8EC0", VA = "0x180CFA6C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xCFAAD0", Offset = "0xCF92D0", VA = "0x180CFAAD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool YIIKMSIAMTV
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x16D8370", Offset = "0x16D6B70", VA = "0x1816D8370")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x16D8380", Offset = "0x16D6B80", VA = "0x1816D8380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public BlendShapeExportPropertyFlags FXVQIIKWBYA
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xABD670", Offset = "0xABBE70", VA = "0x180ABD670")]
			get
			{
				return default(BlendShapeExportPropertyFlags);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0xC0EE50", Offset = "0xC0D650", VA = "0x180C0EE50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool IVZVVHFOCDB
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x9BDE3A0", Offset = "0x9BDCBA0", VA = "0x189BDE3A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x9BF6DF0", Offset = "0x9BF55F0", VA = "0x189BF6DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x9F80540", Offset = "0x9F7ED40", VA = "0x189F80540")]
		internal string VYSSMUQATIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x9F80240", Offset = "0x9F7EA40", VA = "0x189F80240")]
		public static GLTFSettings GetOrCreateSettings()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x9F801D0", Offset = "0x9F7E9D0", VA = "0x189F801D0")]
		public static GLTFSettings GetDefaultSettings()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x9F80410", Offset = "0x9F7EC10", VA = "0x189F80410")]
		public static bool TryGetSettings([Out] GLTFSettings settings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x9F80120", Offset = "0x9F7E920", VA = "0x189F80120")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ClearStatics()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x9F7FD50", Offset = "0x9F7E550", VA = "0x189F7FD50")]
		private static void BUNJASUQVXM(GLTFSettings a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x9F80840", Offset = "0x9F7F040", VA = "0x189F80840")]
		public GLTFSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3698590", Offset = "0x3696D90", VA = "0x183698590")]
		[CompilerGenerated]
		internal static List<Type> OZXZSFODEFP<a>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3698210", Offset = "0x3696A10", VA = "0x183698210")]
		[CompilerGenerated]
		internal static void KLNDXNWISIZ<b>(List<b> a) where b : GLTFPlugin
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class ShaderNotFoundException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x9F834F0", Offset = "0x9F81CF0", VA = "0x189F834F0")]
		public ShaderNotFoundException()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x9F83440", Offset = "0x9F81C40", VA = "0x189F83440")]
		public ShaderNotFoundException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x9F834A0", Offset = "0x9F81CA0", VA = "0x189F834A0")]
		protected ShaderNotFoundException(SerializationInfo info, StreamingContext context)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class GLTFLoadException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x9F7FCF0", Offset = "0x9F7E4F0", VA = "0x189F7FCF0")]
		public GLTFLoadException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class GVWOZLBAYVE : ILogHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private readonly StringBuilder SPWBWHLUJBY;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x9F80FE0", Offset = "0x9F7F7E0", VA = "0x189F80FE0")]
		private string XBTPIFAOHMI(LogType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x9F80DB0", Offset = "0x9F7F5B0", VA = "0x189F80DB0", Slot = "4")]
		public void LogFormat(LogType logType, UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x9F80D10", Offset = "0x9F7F510", VA = "0x189F80D10", Slot = "5")]
		public void LogException(Exception exception, UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x9F80E70", Offset = "0x9F7F670", VA = "0x189F80E70")]
		public void MIJVWTFFNFL(string a = "{0}")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x9F81060", Offset = "0x9F7F860", VA = "0x189F81060")]
		public GVWOZLBAYVE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class KJRSTOXWLWX
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x9F82B10", Offset = "0x9F81310", VA = "0x189F82B10")]
		public static string RSUGJVSSZRB(Uri a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x9F82AA0", Offset = "0x9F812A0", VA = "0x189F82AA0")]
		public static string NGSAVEXABKL(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x9F82C00", Offset = "0x9F81400", VA = "0x189F82C00")]
		public static void ZKQVUZZSQYE(string a, [Out] byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x9F82B70", Offset = "0x9F81370", VA = "0x189F82B70")]
		public static bool WHKAXBKYJHQ(string a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class InstantiatedGLTFObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private JXALHSHLRHW NZPFXIFJGKV;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public JXALHSHLRHW CWRPRBYAGZH
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AB0", Offset = "0xAA02B0", VA = "0x180AA1AB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x9F82A40", Offset = "0x9F81240", VA = "0x189F82A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x9F82910", Offset = "0x9F81110", VA = "0x189F82910")]
		public InstantiatedGLTFObject Duplicate()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x9F829F0", Offset = "0x9F811F0", VA = "0x189F829F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xA9F980", Offset = "0xA9E180", VA = "0x180A9F980")]
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
		public float TUCBZIDVLMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x9F7F1D0", Offset = "0x9F7D9D0", VA = "0x189F7F1D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x9F7F250", Offset = "0x9F7DA50", VA = "0x189F7F250")]
		public BlendShapeFrameWeightSetting(MultiplierOption option)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x9F7F260", Offset = "0x9F7DA60", VA = "0x189F7F260")]
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
		public abstract GLTFSceneImporter CreateSceneImporter(string gltfFileName, RVLDTTXHBEQ options);

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xBD9960", Offset = "0xBD8160", VA = "0x180BD9960")]
		protected ImporterFactory()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class DefaultImporterFactory : ImporterFactory
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x9F7F2E0", Offset = "0x9F7DAE0", VA = "0x189F7F2E0", Slot = "4")]
		public override GLTFSceneImporter CreateSceneImporter(string gltfFileName, RVLDTTXHBEQ options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xBD9960", Offset = "0xBD8160", VA = "0x180BD9960")]
		public DefaultImporterFactory()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	internal static class ULAYQJPTGSX
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x9F91830", Offset = "0x9F90030", VA = "0x189F91830")]
		internal static void BLUTTENNEIA(this Material a, string b, bool c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class MaterialLibrary : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xBD9960", Offset = "0xBD8160", VA = "0x180BD9960")]
		public MaterialLibrary()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	internal static class FFNGZRKBXWZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class QFMADIQWEXT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400031F")]
			public Texture2D WMHRIMEEUAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			public Texture2D MTREVSOVOFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			public Color[] JCNJHVCIFGW;

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public QFMADIQWEXT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x9F830F0", Offset = "0x9F818F0", VA = "0x189F830F0")]
			internal void ATOEJVPNZJI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x9F83350", Offset = "0x9F81B50", VA = "0x189F83350")]
			internal void FWAVTAWVCXK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x9F833A0", Offset = "0x9F81BA0", VA = "0x189F833A0")]
			internal void LEIFGSOUCKM()
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
			private QFMADIQWEXT <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x9F893F0", Offset = "0x9F87BF0", VA = "0x189F893F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x9F89A10", Offset = "0x9F88210", VA = "0x189F89A10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x9F7F8E0", Offset = "0x9F7E0E0", VA = "0x189F7F8E0")]
		[AsyncStateMachine(typeof(<ConvertToDxt5nmAndCheckTextureFormatAsync>d__0))]
		public static Task<Texture2D> GXYTMGNNRCW(Texture2D a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class PNFTVZIKROF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public bool[] TCDUIANATHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public Vector3[] CCGNMXZXRVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public Vector3[] RTXLWNVJSDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public Vector4[] HAFEPCDZGCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public Vector2[] UVPURYRRMCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public Vector2[] UVVBPFLOVNU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public Vector2[] UWAIMMFMEZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public Vector2[] UUPMFQWEQXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public Color[] TBZDDNQFCZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public BoneWeight[] MPIKIVZIYRI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public Vector3[][] CVNSOFGGSXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public Vector3[][] TJBKAYOSSKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public Vector3[][] XOEIOBKKIIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public MeshTopology[] GHCBISMHRNU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public DrawMode[] MGQJVUORPDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public int[][] KQGGERXYISM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public HashSet<int> IOHMVEXKEID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public uint[] SNEYGKQZFHZ;

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x9F82D10", Offset = "0x9F81510", VA = "0x189F82D10")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x9F82E20", Offset = "0x9F81620", VA = "0x189F82E20")]
		public bool FUOHTHLKCKB(PNFTVZIKROF a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x9F83070", Offset = "0x9F81870", VA = "0x189F83070")]
		public PNFTVZIKROF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x38BC970", Offset = "0x38BB170", VA = "0x1838BC970")]
		[CompilerGenerated]
		internal static bool KFDZYOYMEZN<a>(a[] a, a[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x38BC480", Offset = "0x38BAC80", VA = "0x1838BC480")]
		[CompilerGenerated]
		internal static bool BTHFQZTJABY<b>(b[][] a, b[][] b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public abstract class IITLFBNILHO : GYJZSRYWUIU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		internal Material IIPURJZYHSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private AlphaMode QCMEZCTXXWL;

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public static readonly int HMEPVZBTCBQ;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private static readonly int DZZITTSTKMH;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private static readonly int YXIEIMXFOIM;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private static readonly int PQFEFVYOACP;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private static readonly int EPWHMSWSRNX;

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private static readonly int MPCYNLAWTXW;

		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private static readonly int LBERTYZCYUE;

		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private static readonly int GNEEUEGTJHB;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private static readonly int NRHTEZUCQMZ;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private static readonly int HKVMRBTGTNO;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private static readonly int IJXAEKBAXOS;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private static readonly int APDOFPWBTHP;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private static readonly int DVDBDLGGQTE;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private static readonly int PCUHBBYGAFS;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Material AZNSACCNCRA
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public virtual AlphaMode GGJTCONIJJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x9F811B0", Offset = "0x9F7F9B0", VA = "0x189F811B0", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public double OTKURKCCJZS
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x9F824F0", Offset = "0x9F80CF0", VA = "0x189F824F0", Slot = "12")]
			get
			{
				return default(double);
			}
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x9F82540", Offset = "0x9F80D40", VA = "0x189F82540", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public virtual bool GKXCEMDFEYT
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x9F81FB0", Offset = "0x9F807B0", VA = "0x189F81FB0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public virtual bool YJHVHJWCDDQ
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x9F81130", Offset = "0x9F7F930", VA = "0x189F81130", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public Texture ZJNYPCYNDRC
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x9F81EF0", Offset = "0x9F806F0", VA = "0x189F81EF0", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int ABZOEMLQPBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x9F820F0", Offset = "0x9F808F0", VA = "0x189F820F0", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Vector2 HYRMTUXZAIQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x9F82090", Offset = "0x9F80890", VA = "0x189F82090", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public double DSMPGTNNPWF
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x9F81F50", Offset = "0x9F80750", VA = "0x189F81F50", Slot = "18")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Vector2 ZYSDOCVJZLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x9F810D0", Offset = "0x9F7F8D0", VA = "0x189F810D0", Slot = "19")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public int FIRSHJLCSAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x9F82160", Offset = "0x9F80960", VA = "0x189F82160", Slot = "20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public Color RNOGLQKPKBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x9F82480", Offset = "0x9F80C80", VA = "0x189F82480", Slot = "21")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract GYJZSRYWUIU Clone();

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xAAE900", Offset = "0xAAD100", VA = "0x180AAE900")]
		protected IITLFBNILHO(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x9F82800", Offset = "0x9F81000", VA = "0x189F82800")]
		protected IITLFBNILHO(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x9F81E10", Offset = "0x9F80610", VA = "0x189F81E10")]
		protected void EUHVCWTZVOB(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x9F81C40", Offset = "0x9F80440", VA = "0x189F81C40")]
		protected void EPUSKGYJCSE(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x9F821D0", Offset = "0x9F809D0", VA = "0x189F821D0")]
		protected void QMXZBGTXLBA(Material a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class VTLXEEQGZJO : ZBEIVOWWOFC, EHTIMGTBALW, KACXEGMDKDN, GYJZSRYWUIU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private Vector2 SAIUDCAFNJY;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public virtual Texture ZJNYPCYNDRC
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x9F91A30", Offset = "0x9F90230", VA = "0x189F91A30", Slot = "77")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public virtual int ABZOEMLQPBB
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "78")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public virtual Vector2 HYRMTUXZAIQ
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x9F91A90", Offset = "0x9F90290", VA = "0x189F91A90", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public virtual double DSMPGTNNPWF
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public virtual Vector2 ZYSDOCVJZLZ
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x9F918F0", Offset = "0x9F900F0", VA = "0x189F918F0", Slot = "81")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public virtual int FIRSHJLCSAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "82")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public virtual Color RNOGLQKPKBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x9F91BB0", Offset = "0x9F903B0", VA = "0x189F91BB0", Slot = "83")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public virtual Texture BFEIEVXINDZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x9F91B60", Offset = "0x9F90360", VA = "0x189F91B60", Slot = "84")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public virtual int HKXTPPKJJMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public virtual Vector2 IBEKSBVUWOX
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "86")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public virtual double QLQYQKHXTCW
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual Vector2 PUOIIRETDQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "88")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public virtual int BUVDTIPFNIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public virtual double JAGFIGDMXAZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x9F91C20", Offset = "0x9F90420", VA = "0x189F91C20", Slot = "90")]
			get
			{
				return default(double);
			}
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x9F91B00", Offset = "0x9F90300", VA = "0x189F91B00", Slot = "91")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public virtual double XLRLEPGUVIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "92")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x9F91C70", Offset = "0x9F90470", VA = "0x189F91C70")]
		protected VTLXEEQGZJO(string a, string b, int c = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x9F91C80", Offset = "0x9F90480", VA = "0x189F91C80")]
		protected VTLXEEQGZJO(Material a, int b = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x9F91980", Offset = "0x9F90180", VA = "0x189F91980", Slot = "60")]
		public override GYJZSRYWUIU Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class FRRSZGWGRWT : VTLXEEQGZJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private Vector2 UGBSWGYPSLC;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public override int RLUKCTYQGMW
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "35")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public override int TSUPNKZDOVM
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public override int PLCHXUBIDRE
		{
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "49")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public override int ABZOEMLQPBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "78")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public override Texture BFEIEVXINDZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x9F7FB80", Offset = "0x9F7E380", VA = "0x189F7FB80", Slot = "84")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public override int HKXTPPKJJMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public override Vector2 IBEKSBVUWOX
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x9F7FA80", Offset = "0x9F7E280", VA = "0x189F7FA80", Slot = "86")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public override double QLQYQKHXTCW
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public override Vector2 PUOIIRETDQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x9F7FAF0", Offset = "0x9F7E2F0", VA = "0x189F7FAF0", Slot = "88")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public override int BUVDTIPFNIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public override double XLRLEPGUVIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x9F7FC00", Offset = "0x9F7E400", VA = "0x189F7FC00", Slot = "92")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x9F7FC80", Offset = "0x9F7E480", VA = "0x189F7FC80")]
		public FRRSZGWGRWT(string a, int b = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x9F7FC60", Offset = "0x9F7E460", VA = "0x189F7FC60")]
		protected FRRSZGWGRWT(Material a, int b = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x9F7F9D0", Offset = "0x9F7E1D0", VA = "0x189F7F9D0", Slot = "60")]
		public override GYJZSRYWUIU Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class WGVBMQGYEGP : IITLFBNILHO, EHTIMGTBALW, KACXEGMDKDN, GYJZSRYWUIU, PUMEVMLZKGK, XUNYDFKQVDG, BYTDQWIEONA, UZQSYDOJWFC, EEFKXKVAYCH, WJXOENUBRZM, IZXGRHMLNDE, MNVNIVFMJEP, YUQSXNHTQXW
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public Texture FAMLFUDUFOH
		{
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x9F94280", Offset = "0x9F92A80", VA = "0x189F94280", Slot = "37")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x9F93670", Offset = "0x9F91E70", VA = "0x189F93670", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public int RLUKCTYQGMW
		{
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x9F92970", Offset = "0x9F91170", VA = "0x189F92970", Slot = "39")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public double AXTTZFRLVRD
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x9F93BB0", Offset = "0x9F923B0", VA = "0x189F93BB0", Slot = "40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public Vector2 LOXDWNEXZRB
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x9F92540", Offset = "0x9F90D40", VA = "0x189F92540", Slot = "41")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public double BXWRVQOENXA
		{
			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x9F922A0", Offset = "0x9F90AA0", VA = "0x189F922A0", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public Vector2 QYNYYYPFVXE
		{
			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x9F931E0", Offset = "0x9F919E0", VA = "0x189F931E0", Slot = "43")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int SNQIEMCTQHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x9F935A0", Offset = "0x9F91DA0", VA = "0x189F935A0", Slot = "44")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public Texture KWWDJKXRBDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x9F926C0", Offset = "0x9F90EC0", VA = "0x189F926C0", Slot = "45")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int TSUPNKZDOVM
		{
			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x9F93D30", Offset = "0x9F92530", VA = "0x189F93D30", Slot = "46")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public double BWQMCDNGDMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x9F941C0", Offset = "0x9F929C0", VA = "0x189F941C0", Slot = "47")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public Vector2 DCGVIUESXWX
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x9F92850", Offset = "0x9F91050", VA = "0x189F92850", Slot = "48")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public double LLAVRJYRAJQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x9F943F0", Offset = "0x9F92BF0", VA = "0x189F943F0", Slot = "49")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public Vector2 XMHDOQPRZWG
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x9F93CD0", Offset = "0x9F924D0", VA = "0x189F93CD0", Slot = "50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public int MSNGLRGNZIC
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x9F93050", Offset = "0x9F91850", VA = "0x189F93050", Slot = "51")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Texture AXDZLCKHOVR
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x9F92E70", Offset = "0x9F91670", VA = "0x189F92E70", Slot = "52")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public int PLCHXUBIDRE
		{
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x9F929E0", Offset = "0x9F911E0", VA = "0x189F929E0", Slot = "53")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Color LRYBHNQNDAH
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x9F91C90", Offset = "0x9F90490", VA = "0x189F91C90", Slot = "54")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x9F91E80", Offset = "0x9F90680", VA = "0x189F91E80", Slot = "55")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector2 TNJHGCANXPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x9F93B50", Offset = "0x9F92350", VA = "0x189F93B50", Slot = "56")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public double GBYZISGWRDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x9F92080", Offset = "0x9F90880", VA = "0x189F92080", Slot = "57")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector2 OZJAYGYBIEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x9F92720", Offset = "0x9F90F20", VA = "0x189F92720", Slot = "58")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public int FWZENZUEEWG
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x9F93FE0", Offset = "0x9F927E0", VA = "0x189F93FE0", Slot = "59")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public Texture BFEIEVXINDZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x9F93610", Offset = "0x9F91E10", VA = "0x189F93610", Slot = "29")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public int HKXTPPKJJMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x9F92020", Offset = "0x9F90820", VA = "0x189F92020", Slot = "30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Vector2 IBEKSBVUWOX
		{
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x9F92D50", Offset = "0x9F91550", VA = "0x189F92D50", Slot = "31")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public double QLQYQKHXTCW
		{
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x9F930C0", Offset = "0x9F918C0", VA = "0x189F930C0", Slot = "32")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Vector2 PUOIIRETDQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x9F93300", Offset = "0x9F91B00", VA = "0x189F93300", Slot = "33")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public int BUVDTIPFNIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x9F938B0", Offset = "0x9F920B0", VA = "0x189F938B0", Slot = "34")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public double JAGFIGDMXAZ
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x9F93540", Offset = "0x9F91D40", VA = "0x189F93540", Slot = "35")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public double XLRLEPGUVIE
		{
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x9F942D0", Offset = "0x9F92AD0", VA = "0x189F942D0", Slot = "36")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public double EVRTHTGWRFO
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x9F93120", Offset = "0x9F91920", VA = "0x189F93120", Slot = "60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public Texture TLFWQQWYGAC
		{
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x9F92AA0", Offset = "0x9F912A0", VA = "0x189F92AA0", Slot = "61")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public double GNTJSSSZOQI
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x9F925A0", Offset = "0x9F90DA0", VA = "0x189F925A0", Slot = "63")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public Vector2 FTFSXWSXKSZ
		{
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x9F91D60", Offset = "0x9F90560", VA = "0x189F91D60", Slot = "62")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public Vector2 GCZJXCKCQJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x9F92FF0", Offset = "0x9F917F0", VA = "0x189F92FF0", Slot = "64")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public int JREEFGPZJRO
		{
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x9F92F30", Offset = "0x9F91730", VA = "0x189F92F30", Slot = "65")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public double FGXYNBOFZFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x9F93E60", Offset = "0x9F92660", VA = "0x189F93E60", Slot = "66")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Color MHZRTUUPVCQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x9F92B60", Offset = "0x9F91360", VA = "0x189F92B60", Slot = "67")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public double DPVCSMGRBRK
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x9F933C0", Offset = "0x9F91BC0", VA = "0x189F933C0", Slot = "68")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public Texture HGRMMVHDASC
		{
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x9F93F20", Offset = "0x9F92720", VA = "0x189F93F20", Slot = "69")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public double SQZQOEHVRPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x9F93180", Offset = "0x9F91980", VA = "0x189F93180", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Vector2 YIQVPAWZPGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x9F940A0", Offset = "0x9F928A0", VA = "0x189F940A0", Slot = "70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Vector2 FRKLAVUNHXC
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x9F93420", Offset = "0x9F91C20", VA = "0x189F93420", Slot = "72")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public int USYASQMRLCY
		{
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x9F93A90", Offset = "0x9F92290", VA = "0x189F93A90", Slot = "73")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public double QPKCPQERCFB
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x9F93C10", Offset = "0x9F92410", VA = "0x189F93C10", Slot = "74")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public double FPYUBMMXSLE
		{
			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x9F93850", Offset = "0x9F92050", VA = "0x189F93850", Slot = "75")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public double LAWGESNXUIF
		{
			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x9F92E10", Offset = "0x9F91610", VA = "0x189F92E10", Slot = "76")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public double LAXDAZPQNVV
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x9F92240", Offset = "0x9F90A40", VA = "0x189F92240", Slot = "77")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public double HUBVYHSWRNX
		{
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x9F92C90", Offset = "0x9F91490", VA = "0x189F92C90", Slot = "78")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public Texture ZFOIWKRFQQQ
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x9F93E00", Offset = "0x9F92600", VA = "0x189F93E00", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public double YRAFSAZMEPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x9F92660", Offset = "0x9F90E60", VA = "0x189F92660", Slot = "81")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public Vector2 ROVOJRCWLIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x9F93360", Offset = "0x9F91B60", VA = "0x189F93360", Slot = "80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public Vector2 IYPXREWJTVU
		{
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x9F923C0", Offset = "0x9F90BC0", VA = "0x189F923C0", Slot = "82")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public int BYIJVIWLHNU
		{
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x9F94160", Offset = "0x9F92960", VA = "0x189F94160", Slot = "83")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Texture KANZDQFQQHS
		{
			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0x9F91F60", Offset = "0x9F90760", VA = "0x189F91F60", Slot = "84")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public double PKXKDBNUAVM
		{
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x9F94390", Offset = "0x9F92B90", VA = "0x189F94390", Slot = "86")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public Vector2 IZKMHBVRCWP
		{
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x9F932A0", Offset = "0x9F91AA0", VA = "0x189F932A0", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public Vector2 LQXLAHNGWYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x9F92DB0", Offset = "0x9F915B0", VA = "0x189F92DB0", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public int LNSUFSZWSSO
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x9F92C30", Offset = "0x9F91430", VA = "0x189F92C30", Slot = "88")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public double EJSMMTJHVDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x9F93910", Offset = "0x9F92110", VA = "0x189F93910", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public Texture LDRDUOAWPDL
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x9F921E0", Offset = "0x9F909E0", VA = "0x189F921E0", Slot = "90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public double AGSBPSBMMSL
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x9F92ED0", Offset = "0x9F916D0", VA = "0x189F92ED0", Slot = "92")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public Vector2 QWQBPPFSAEC
		{
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0x9F94040", Offset = "0x9F92840", VA = "0x189F94040", Slot = "91")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public Vector2 VXNDKWYLULL
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x9F93240", Offset = "0x9F91A40", VA = "0x189F93240", Slot = "93")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public int ZNRQCBJBUGP
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x9F93AF0", Offset = "0x9F922F0", VA = "0x189F93AF0", Slot = "94")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Color PCCVLPLWLZQ
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x9F927E0", Offset = "0x9F90FE0", VA = "0x189F927E0", Slot = "95")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Texture DUQYECNCREI
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x9F93DA0", Offset = "0x9F925A0", VA = "0x189F93DA0", Slot = "96")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public double FBJCYENEBDQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x9F93F80", Offset = "0x9F92780", VA = "0x189F93F80", Slot = "98")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public Vector2 QBWGYHEWEDB
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x9F93730", Offset = "0x9F91F30", VA = "0x189F93730", Slot = "97")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public Vector2 CQJQSPNJFLE
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x9F92360", Offset = "0x9F90B60", VA = "0x189F92360", Slot = "99")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public int EMNZOMKRHWO
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x9F944B0", Offset = "0x9F92CB0", VA = "0x189F944B0", Slot = "100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public double LOGHQOBJPFW
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x9F93970", Offset = "0x9F92170", VA = "0x189F93970", Slot = "101")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public Texture OISHPQVRCVQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x9F939D0", Offset = "0x9F921D0", VA = "0x189F939D0", Slot = "102")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public double NDLPYSAEZBC
		{
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x9F92480", Offset = "0x9F90C80", VA = "0x189F92480", Slot = "104")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public Vector2 XTWXGEKGXXT
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x9F93790", Offset = "0x9F91F90", VA = "0x189F93790", Slot = "103")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Vector2 SECUCPVWKDS
		{
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x9F94100", Offset = "0x9F92900", VA = "0x189F94100", Slot = "105")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public int BODRQJSXDKE
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x9F93EC0", Offset = "0x9F926C0", VA = "0x189F93EC0", Slot = "106")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public double FAYEUOGKAYY
		{
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x9F924E0", Offset = "0x9F90CE0", VA = "0x189F924E0", Slot = "107")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public Texture PIUQTWNQMAW
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x9F94450", Offset = "0x9F92C50", VA = "0x189F94450", Slot = "108")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public double LHFPAWXYWAU
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x9F91DC0", Offset = "0x9F905C0", VA = "0x189F91DC0", Slot = "110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public Vector2 OSFDBPXPTUV
		{
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x9F92F90", Offset = "0x9F91790", VA = "0x189F92F90", Slot = "109")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public Vector2 VYSOXANXDMI
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x9F92910", Offset = "0x9F91110", VA = "0x189F92910", Slot = "111")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public int BQSBUQSMKLC
		{
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x9F92420", Offset = "0x9F90C20", VA = "0x189F92420", Slot = "112")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public float WPNMXYKCXUJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x9F92A40", Offset = "0x9F91240", VA = "0x189F92A40", Slot = "113")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public float JNLZPDBDHGN
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x9F92600", Offset = "0x9F90E00", VA = "0x189F92600", Slot = "114")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public Color AJEOGXPZPMU
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x9F91EF0", Offset = "0x9F906F0", VA = "0x189F91EF0", Slot = "115")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public Texture JOSFPJMKQLA
		{
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x9F94330", Offset = "0x9F92B30", VA = "0x189F94330", Slot = "116")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public double HSLBLIFIJUY
		{
			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x9F937F0", Offset = "0x9F91FF0", VA = "0x189F937F0", Slot = "117")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public Vector2 RBYFJSBWUXT
		{
			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x9F936D0", Offset = "0x9F91ED0", VA = "0x189F936D0", Slot = "118")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public Vector2 JZPWVHIXIZK
		{
			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x9F93A30", Offset = "0x9F92230", VA = "0x189F93A30", Slot = "119")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public int LKKGZKMDMVG
		{
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x9F928B0", Offset = "0x9F910B0", VA = "0x189F928B0", Slot = "120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public Texture IFANTIYWIGB
		{
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x9F91E20", Offset = "0x9F90620", VA = "0x189F91E20", Slot = "121")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public double QFLCJFBYLBR
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x9F92BD0", Offset = "0x9F913D0", VA = "0x189F92BD0", Slot = "122")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public Vector2 AWQPRQHXJXA
		{
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x9F92300", Offset = "0x9F90B00", VA = "0x189F92300", Slot = "123")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public Vector2 ZZFHFUDYWTD
		{
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x9F91D00", Offset = "0x9F90500", VA = "0x189F91D00", Slot = "124")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public int VVZQLWPVUAD
		{
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x9F92CF0", Offset = "0x9F914F0", VA = "0x189F92CF0", Slot = "125")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public double GNHJWXNIPSS
		{
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x9F94220", Offset = "0x9F92A20", VA = "0x189F94220", Slot = "131")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public double TEYPPQXEXBD
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x9F91FC0", Offset = "0x9F907C0", VA = "0x189F91FC0", Slot = "132")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Texture EDLICIIKAQW
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x9F934E0", Offset = "0x9F91CE0", VA = "0x189F934E0", Slot = "126")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public double MIJHMXXWGIE
		{
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x9F92780", Offset = "0x9F90F80", VA = "0x189F92780", Slot = "128")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public Vector2 TCAPAAYGOYJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x9F93480", Offset = "0x9F91C80", VA = "0x189F93480", Slot = "127")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public Vector2 ZAASJQRBRBO
		{
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x9F92B00", Offset = "0x9F91300", VA = "0x189F92B00", Slot = "129")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public int NFEJVDYUXZS
		{
			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x9F93C70", Offset = "0x9F92470", VA = "0x189F93C70", Slot = "130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x9F946D0", Offset = "0x9F92ED0", VA = "0x189F946D0")]
		public WGVBMQGYEGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x9F94510", Offset = "0x9F92D10", VA = "0x189F94510")]
		protected WGVBMQGYEGP(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x9F94660", Offset = "0x9F92E60", VA = "0x189F94660")]
		public WGVBMQGYEGP(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x9F920E0", Offset = "0x9F908E0", VA = "0x189F920E0", Slot = "10")]
		public override GYJZSRYWUIU Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class EOIBMCJTMJT : ZBEIVOWWOFC, QTFFZSGRMLV, KACXEGMDKDN, GYJZSRYWUIU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private Vector2 RNKCLQKUQDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private Vector2 RPBRXUCGCTT;

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public virtual Texture ECQUMYOIXSS
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x9F7F5D0", Offset = "0x9F7DDD0", VA = "0x189F7F5D0", Slot = "77")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public virtual int UJXXHGBORJL
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "78")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public virtual Vector2 JEVFCZNNWOS
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x9F7F6A0", Offset = "0x9F7DEA0", VA = "0x189F7F6A0", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public virtual double YJEKVFUPWBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public virtual Vector2 JETMYDNWQIV
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x9F7F350", Offset = "0x9F7DB50", VA = "0x189F7F350", Slot = "81")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public virtual int SSNAJCAYXZR
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "82")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public virtual Color KJQSFYKRQCA
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x9F7F630", Offset = "0x9F7DE30", VA = "0x189F7F630", Slot = "83")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public virtual Texture SKXSQTIMKJV
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x9F7F520", Offset = "0x9F7DD20", VA = "0x189F7F520", Slot = "84")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public virtual int GXRBFIGFIUG
		{
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public virtual Vector2 SOPHOHQBDQT
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x9F7F7A0", Offset = "0x9F7DFA0", VA = "0x189F7F7A0", Slot = "86")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public virtual double FERMAKQEPTQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public virtual Vector2 WAYOLBGHZDM
		{
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x9F7F3E0", Offset = "0x9F7DBE0", VA = "0x189F7F3E0", Slot = "88")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public virtual int LRZXGEAUBDU
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public virtual Vector3 EJSMMTJHVDL
		{
			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x9F7F710", Offset = "0x9F7DF10", VA = "0x189F7F710", Slot = "90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public virtual double OEMJNEUXFDU
		{
			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x9F7F810", Offset = "0x9F7E010", VA = "0x189F7F810", Slot = "91")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x9F7F8A0", Offset = "0x9F7E0A0", VA = "0x189F7F8A0")]
		protected EOIBMCJTMJT(string a, string b, int c = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x9F7F8C0", Offset = "0x9F7E0C0", VA = "0x189F7F8C0")]
		protected EOIBMCJTMJT(Material a, int b = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x9F7F470", Offset = "0x9F7DC70", VA = "0x189F7F470", Slot = "60")]
		public override GYJZSRYWUIU Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class TNFJOJLNWKU : EOIBMCJTMJT
	{
		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public override int RLUKCTYQGMW
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "35")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public override int TSUPNKZDOVM
		{
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public override int PLCHXUBIDRE
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "49")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public override int UJXXHGBORJL
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "78")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public override int GXRBFIGFIUG
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x9FA06C0", Offset = "0x9F9EEC0", VA = "0x189FA06C0")]
		public TNFJOJLNWKU(string a, int b = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x9FA06B0", Offset = "0x9F9EEB0", VA = "0x189FA06B0")]
		protected TNFJOJLNWKU(Material a, int b = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x9FA05A0", Offset = "0x9F9EDA0", VA = "0x189FA05A0", Slot = "60")]
		public override GYJZSRYWUIU Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class ZBEIVOWWOFC : KACXEGMDKDN, GYJZSRYWUIU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		protected Material IIPURJZYHSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private AlphaMode QCMEZCTXXWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private double VIEVWNZFSXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private Vector2 VDBCZTXIVBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private Vector2 MKFCKJQMZNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private Vector2 MDVSXRVMBMP;

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public Material AZNSACCNCRA
		{
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public virtual Texture FAMLFUDUFOH
		{
			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x9FA6700", Offset = "0x9FA4F00", VA = "0x189FA6700", Slot = "33")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x9FA6310", Offset = "0x9FA4B10", VA = "0x189FA6310", Slot = "34")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public virtual int RLUKCTYQGMW
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "35")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public virtual Vector2 LOXDWNEXZRB
		{
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x9FA5F00", Offset = "0x9FA4700", VA = "0x189FA5F00", Slot = "36")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public virtual double BXWRVQOENXA
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "37")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public virtual Vector2 QYNYYYPFVXE
		{
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x9FA6280", Offset = "0x9FA4A80", VA = "0x189FA6280", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public virtual int SNQIEMCTQHI
		{
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "39")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public virtual double AXTTZFRLVRD
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x9FA6460", Offset = "0x9FA4C60", VA = "0x189FA6460", Slot = "40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public virtual Texture KWWDJKXRBDF
		{
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x9FA5F70", Offset = "0x9FA4770", VA = "0x189FA5F70", Slot = "41")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public virtual int TSUPNKZDOVM
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public virtual Vector2 DCGVIUESXWX
		{
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x9FA60C0", Offset = "0x9FA48C0", VA = "0x189FA60C0", Slot = "43")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public virtual double LLAVRJYRAJQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "44")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public virtual Vector2 XMHDOQPRZWG
		{
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x9FA6520", Offset = "0x9FA4D20", VA = "0x189FA6520", Slot = "45")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public virtual int MSNGLRGNZIC
		{
			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "46")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		public virtual double BWQMCDNGDMM
		{
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x9FA6640", Offset = "0x9FA4E40", VA = "0x189FA6640", Slot = "47")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public virtual Texture AXDZLCKHOVR
		{
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x9FA6130", Offset = "0x9FA4930", VA = "0x189FA6130", Slot = "48")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public virtual int PLCHXUBIDRE
		{
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "49")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public virtual Vector2 TNJHGCANXPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x9FA63F0", Offset = "0x9FA4BF0", VA = "0x189FA63F0", Slot = "50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public virtual double GBYZISGWRDU
		{
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "51")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public virtual Vector2 OZJAYGYBIEC
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x9FA6030", Offset = "0x9FA4830", VA = "0x189FA6030", Slot = "52")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public virtual int FWZENZUEEWG
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "53")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public virtual Color LRYBHNQNDAH
		{
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x9FA5670", Offset = "0x9FA3E70", VA = "0x189FA5670", Slot = "54")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x9FA5710", Offset = "0x9FA3F10", VA = "0x189FA5710", Slot = "55")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public virtual AlphaMode GGJTCONIJJE
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x9FA5A70", Offset = "0x9FA4270", VA = "0x189FA5A70", Slot = "56")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		public virtual double OTKURKCCJZS
		{
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x9FA65B0", Offset = "0x9FA4DB0", VA = "0x189FA65B0", Slot = "57")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public virtual bool GKXCEMDFEYT
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x9FA6210", Offset = "0x9FA4A10", VA = "0x189FA6210", Slot = "58")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		public virtual bool YJHVHJWCDDQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x9FA57C0", Offset = "0x9FA3FC0", VA = "0x189FA57C0", Slot = "59")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x9FA6770", Offset = "0x9FA4F70", VA = "0x189FA6770")]
		protected ZBEIVOWWOFC(string a, string b, int c = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x9FA68D0", Offset = "0x9FA50D0", VA = "0x189FA68D0")]
		protected ZBEIVOWWOFC(Material a, int b = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x9FA5840", Offset = "0x9FA4040", VA = "0x189FA5840", Slot = "60")]
		public virtual GYJZSRYWUIU Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x9FA59D0", Offset = "0x9FA41D0", VA = "0x189FA59D0", Slot = "61")]
		protected virtual void Copy(KACXEGMDKDN o)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public interface GYJZSRYWUIU
	{
		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		Material AZNSACCNCRA
		{
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		AlphaMode GGJTCONIJJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		double OTKURKCCJZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		bool GKXCEMDFEYT
		{
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		bool YJHVHJWCDDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(Slot = "5")]
		GYJZSRYWUIU Clone();
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public interface KACXEGMDKDN : GYJZSRYWUIU
	{
		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		Texture FAMLFUDUFOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		int RLUKCTYQGMW
		{
			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		double AXTTZFRLVRD
		{
			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		Vector2 LOXDWNEXZRB
		{
			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		double BXWRVQOENXA
		{
			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		Vector2 QYNYYYPFVXE
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		int SNQIEMCTQHI
		{
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		Texture KWWDJKXRBDF
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		int TSUPNKZDOVM
		{
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FE")]
		double BWQMCDNGDMM
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FF")]
		Vector2 DCGVIUESXWX
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000100")]
		double LLAVRJYRAJQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000101")]
		Vector2 XMHDOQPRZWG
		{
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000102")]
		int MSNGLRGNZIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		Texture AXDZLCKHOVR
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(Slot = "15")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		int PLCHXUBIDRE
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(Slot = "16")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		Color LRYBHNQNDAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(Slot = "18")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		Vector2 TNJHGCANXPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(Slot = "19")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000107")]
		double GBYZISGWRDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(Slot = "20")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		Vector2 OZJAYGYBIEC
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(Slot = "21")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		int FWZENZUEEWG
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(Slot = "22")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public interface EHTIMGTBALW : KACXEGMDKDN, GYJZSRYWUIU
	{
		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		Texture ZJNYPCYNDRC
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		int ABZOEMLQPBB
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		Vector2 HYRMTUXZAIQ
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		double DSMPGTNNPWF
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010E")]
		Vector2 ZYSDOCVJZLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010F")]
		int FIRSHJLCSAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000110")]
		Color RNOGLQKPKBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		Texture BFEIEVXINDZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		int HKXTPPKJJMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		Vector2 IBEKSBVUWOX
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		double QLQYQKHXTCW
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000115")]
		Vector2 PUOIIRETDQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		int BUVDTIPFNIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		double JAGFIGDMXAZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000118")]
		double XLRLEPGUVIE
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public interface PUMEVMLZKGK : EHTIMGTBALW, KACXEGMDKDN, GYJZSRYWUIU
	{
		[Cpp2IlInjected.Token(Token = "0x17000119")]
		double EVRTHTGWRFO
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		Texture TLFWQQWYGAC
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		Vector2 FTFSXWSXKSZ
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		double GNTJSSSZOQI
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		Vector2 GCZJXCKCQJW
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		int JREEFGPZJRO
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		double FGXYNBOFZFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		Color MHZRTUUPVCQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public interface XUNYDFKQVDG : EHTIMGTBALW, KACXEGMDKDN, GYJZSRYWUIU
	{
		[Cpp2IlInjected.Token(Token = "0x17000121")]
		double DPVCSMGRBRK
		{
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		Texture HGRMMVHDASC
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		Vector2 YIQVPAWZPGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		double SQZQOEHVRPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		Vector2 FRKLAVUNHXC
		{
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		int USYASQMRLCY
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public interface MNVNIVFMJEP : EHTIMGTBALW, KACXEGMDKDN, GYJZSRYWUIU
	{
		[Cpp2IlInjected.Token(Token = "0x17000127")]
		float JNLZPDBDHGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		Color AJEOGXPZPMU
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		Texture JOSFPJMKQLA
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		double HSLBLIFIJUY
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012B")]
		Vector2 RBYFJSBWUXT
		{
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012C")]
		Vector2 JZPWVHIXIZK
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		int LKKGZKMDMVG
		{
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012E")]
		Texture IFANTIYWIGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012F")]
		double QFLCJFBYLBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000130")]
		Vector2 AWQPRQHXJXA
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		Vector2 ZZFHFUDYWTD
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		int VVZQLWPVUAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public interface IZXGRHMLNDE : XUNYDFKQVDG, EHTIMGTBALW, KACXEGMDKDN, GYJZSRYWUIU
	{
		[Cpp2IlInjected.Token(Token = "0x17000133")]
		float WPNMXYKCXUJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public interface BYTDQWIEONA : EHTIMGTBALW, KACXEGMDKDN, GYJZSRYWUIU
	{
		[Cpp2IlInjected.Token(Token = "0x17000134")]
		double QPKCPQERCFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public interface EEFKXKVAYCH : EHTIMGTBALW, KACXEGMDKDN, GYJZSRYWUIU
	{
		[Cpp2IlInjected.Token(Token = "0x17000135")]
		double EJSMMTJHVDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		Texture LDRDUOAWPDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		Vector2 QWQBPPFSAEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		double AGSBPSBMMSL
		{
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		Vector2 VXNDKWYLULL
		{
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013A")]
		int ZNRQCBJBUGP
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013B")]
		Color PCCVLPLWLZQ
		{
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013C")]
		Texture DUQYECNCREI
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013D")]
		Vector2 QBWGYHEWEDB
		{
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013E")]
		double FBJCYENEBDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013F")]
		Vector2 CQJQSPNJFLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000140")]
		int EMNZOMKRHWO
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public interface UZQSYDOJWFC : EHTIMGTBALW, KACXEGMDKDN, GYJZSRYWUIU
	{
		[Cpp2IlInjected.Token(Token = "0x17000141")]
		double FPYUBMMXSLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000142")]
		double LAWGESNXUIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		double LAXDAZPQNVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		double HUBVYHSWRNX
		{
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		Texture ZFOIWKRFQQQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000146")]
		Vector2 ROVOJRCWLIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		double YRAFSAZMEPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		Vector2 IYPXREWJTVU
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		int BYIJVIWLHNU
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		Texture KANZDQFQQHS
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		Vector2 IZKMHBVRCWP
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		double PKXKDBNUAVM
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		Vector2 LQXLAHNGWYS
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		int LNSUFSZWSSO
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public interface QTFFZSGRMLV : KACXEGMDKDN, GYJZSRYWUIU
	{
		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		Texture ECQUMYOIXSS
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		int UJXXHGBORJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		Vector2 JEVFCZNNWOS
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		double YJEKVFUPWBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		Vector2 JETMYDNWQIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000154")]
		int SSNAJCAYXZR
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000155")]
		Color KJQSFYKRQCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		Texture SKXSQTIMKJV
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		int GXRBFIGFIUG
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000158")]
		Vector2 SOPHOHQBDQT
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		double FERMAKQEPTQ
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		Vector2 WAYOLBGHZDM
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		int LRZXGEAUBDU
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		Vector3 EJSMMTJHVDL
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		double OEMJNEUXFDU
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public interface WJXOENUBRZM : EHTIMGTBALW, KACXEGMDKDN, GYJZSRYWUIU
	{
		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		double LOGHQOBJPFW
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		Texture OISHPQVRCVQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000160")]
		Vector2 XTWXGEKGXXT
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		double NDLPYSAEZBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		Vector2 SECUCPVWKDS
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		int BODRQJSXDKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		double FAYEUOGKAYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		Texture PIUQTWNQMAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		Vector2 OSFDBPXPTUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		double LHFPAWXYWAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000168")]
		Vector2 VYSOXANXDMI
		{
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		int BQSBUQSMKLC
		{
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public interface XULSYQARDCX
	{
		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		Texture GUJMXRKHGZN
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700016B")]
		Vector2 QXJCIZFROAM
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		double VCPJLRBPRZT
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700016D")]
		Vector2 OKQLGBZTTZJ
		{
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700016E")]
		int OEKKBIBWQUN
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public interface YUQSXNHTQXW
	{
		[Cpp2IlInjected.Token(Token = "0x1700016F")]
		Texture EDLICIIKAQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000170")]
		Vector2 TCAPAAYGOYJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000171")]
		double MIJHMXXWGIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000172")]
		Vector2 ZAASJQRBRBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000173")]
		int NFEJVDYUXZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000174")]
		double GNHJWXNIPSS
		{
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000175")]
		double TEYPPQXEXBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public interface WSOZWSFFDDC : GYJZSRYWUIU
	{
		[Cpp2IlInjected.Token(Token = "0x17000176")]
		Texture ZJNYPCYNDRC
		{
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000177")]
		int ABZOEMLQPBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000178")]
		Vector2 HYRMTUXZAIQ
		{
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000179")]
		double DSMPGTNNPWF
		{
			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700017A")]
		Vector2 ZYSDOCVJZLZ
		{
			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700017B")]
		int FIRSHJLCSAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700017C")]
		Color RNOGLQKPKBA
		{
			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class WAIEKOIDFOP : IITLFBNILHO, WSOZWSFFDDC, GYJZSRYWUIU
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x9FA2080", Offset = "0x9FA0880", VA = "0x189FA2080")]
		public WAIEKOIDFOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x9FA1FB0", Offset = "0x9FA07B0", VA = "0x189FA1FB0")]
		protected WAIEKOIDFOP(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x9FA2020", Offset = "0x9FA0820", VA = "0x189FA2020")]
		public WAIEKOIDFOP(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x9FA1EC0", Offset = "0x9FA06C0", VA = "0x189FA1EC0", Slot = "10")]
		public override GYJZSRYWUIU Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class AOWDYYHDNCB : ZBEIVOWWOFC, WSOZWSFFDDC, GYJZSRYWUIU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private Vector2 SAIUDCAFNJY;

		[Cpp2IlInjected.Token(Token = "0x1700017D")]
		public Texture ZJNYPCYNDRC
		{
			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x9F948D0", Offset = "0x9F930D0", VA = "0x189F948D0", Slot = "62")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017E")]
		public virtual int ABZOEMLQPBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "69")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017F")]
		public virtual Vector2 HYRMTUXZAIQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x9F94930", Offset = "0x9F93130", VA = "0x189F94930", Slot = "70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000180")]
		public virtual double DSMPGTNNPWF
		{
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000181")]
		public virtual Vector2 ZYSDOCVJZLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x9F94840", Offset = "0x9F93040", VA = "0x189F94840", Slot = "72")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000182")]
		public virtual int FIRSHJLCSAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "73")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000183")]
		public virtual Color RNOGLQKPKBA
		{
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x9F949A0", Offset = "0x9F931A0", VA = "0x189F949A0", Slot = "74")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x9F94A10", Offset = "0x9F93210", VA = "0x189F94A10")]
		public AOWDYYHDNCB(string a, string b, int c = 1000)
		{
		}
	}
}
namespace UnityGLTF.Timeline
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class LNGBIMZDZSI
	{
		[Cpp2IlInjected.Token(Token = "0x2000092")]
		public delegate void OnBeforeAddAnimationDataDelegate(GQPNJPJQJXD animationData);

		[Cpp2IlInjected.Token(Token = "0x2000093")]
		public delegate void OnPostExportDelegate(FSQFTXCYISC animationData);

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		public class FSQFTXCYISC
		{
			[Cpp2IlInjected.Token(Token = "0x17000186")]
			private Bounds MHGBDMYHAJZ
			{
				[Cpp2IlInjected.Token(Token = "0x60003AA")]
				[Cpp2IlInjected.Address(RVA = "0x9108B40", Offset = "0x9107340", VA = "0x189108B40")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000187")]
			private GLTFSceneExporter CEAKNDAHLUW
			{
				[Cpp2IlInjected.Token(Token = "0x60003AB")]
				[Cpp2IlInjected.Address(RVA = "0xAA1380", Offset = "0xA9FB80", VA = "0x180AA1380")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000188")]
			private WTVTOFLEGQC WOPHBUBAIZQ
			{
				[Cpp2IlInjected.Token(Token = "0x60003AC")]
				[Cpp2IlInjected.Address(RVA = "0xAA1600", Offset = "0xA9FE00", VA = "0x180AA1600")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x9F99260", Offset = "0x9F97A60", VA = "0x189F99260")]
			internal FSQFTXCYISC(Bounds a, GLTFSceneExporter b, WTVTOFLEGQC c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		public class GQPNJPJQJXD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			internal AnimationData.GQNDLWIVBXQ TQIOQFNVLRM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			public float[] OVDZRWJUPGT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public object[] IFFINMZNWHT;

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0xB28F10", Offset = "0xB27710", VA = "0x180B28F10")]
			internal GQPNJPJQJXD(AnimationData.GQNDLWIVBXQ a, float[] b, object[] c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000096")]
		internal class AnimationData
		{
			[Cpp2IlInjected.Token(Token = "0x2000097")]
			internal class UTBRJDXHUZU
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000372")]
				public string AUGQVQKNNBL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000373")]
				public Type SYZLWUDSUFR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000374")]
				public Func<Transform, UnityEngine.Object> RPLJBVWKQVO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000375")]
				public Func<Transform, UnityEngine.Object, AnimationData, object> YZVFHBCABER;

				[Cpp2IlInjected.Token(Token = "0x60003B2")]
				[Cpp2IlInjected.Address(RVA = "0xE5BEC0", Offset = "0xE5A6C0", VA = "0x180E5BEC0")]
				public UTBRJDXHUZU(string a, Type b, Func<Transform, UnityEngine.Object> c, Func<Transform, UnityEngine.Object, AnimationData, object> d)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003B3")]
				[Cpp2IlInjected.Address(RVA = "0x9FA1CD0", Offset = "0x9FA04D0", VA = "0x189FA1CD0")]
				public object UYADMDGAZCR(AnimationData a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000098")]
			internal class GQNDLWIVBXQ
			{
				[Cpp2IlInjected.Token(Token = "0x2000099")]
				private class HXNQSHBEYVO
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400037B")]
					public double SAFVJFPAHJU;

					[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
					[Cpp2IlInjected.Token(Token = "0x400037C")]
					public object WHBDDYNVKGU;

					[Cpp2IlInjected.Token(Token = "0x60003BA")]
					[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
					public HXNQSHBEYVO()
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000376")]
				private AnimationData ORIFRTLCIEN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000377")]
				private UTBRJDXHUZU GFPLZXLQDYA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000378")]
				private Dictionary<double, object> RWUFUYGUCXQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000379")]
				private HXNQSHBEYVO VBUASLMZMLT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400037A")]
				private HXNQSHBEYVO ROLKUQWVQQI;

				[Cpp2IlInjected.Token(Token = "0x17000189")]
				public UnityEngine.Object XAHDPYQKACJ
				{
					[Cpp2IlInjected.Token(Token = "0x60003B4")]
					[Cpp2IlInjected.Address(RVA = "0x9F9AA40", Offset = "0x9F99240", VA = "0x189F9AA40")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018A")]
				public string AUGQVQKNNBL
				{
					[Cpp2IlInjected.Token(Token = "0x60003B5")]
					[Cpp2IlInjected.Address(RVA = "0x27EC730", Offset = "0x27EAF30", VA = "0x1827EC730")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018B")]
				public float[] JDSNHQARKUD
				{
					[Cpp2IlInjected.Token(Token = "0x60003B6")]
					[Cpp2IlInjected.Address(RVA = "0x9F9A690", Offset = "0x9F98E90", VA = "0x189F9A690")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018C")]
				public object[] CPYGRQASLYN
				{
					[Cpp2IlInjected.Token(Token = "0x60003B7")]
					[Cpp2IlInjected.Address(RVA = "0x9F9A630", Offset = "0x9F98E30", VA = "0x189F9A630")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60003B8")]
				[Cpp2IlInjected.Address(RVA = "0x9F9AA80", Offset = "0x9F99280", VA = "0x189F9AA80")]
				public GQNDLWIVBXQ(AnimationData a, UTBRJDXHUZU b, double c)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003B9")]
				[Cpp2IlInjected.Address(RVA = "0x9F9A7F0", Offset = "0x9F98FF0", VA = "0x189F9A7F0")]
				public void RBEHNJCQVZI(double a)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			internal Transform ORIFRTLCIEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			private SkinnedMeshRenderer TILNMTGXHKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			private bool TIPCYULYSOX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			private bool VHJHIZYQMNY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			private bool VURKKGERPLP;

			[Cpp2IlInjected.Token(Token = "0x400036F")]
			private static List<UTBRJDXHUZU> NEVEWIRCJFZ;

			[Cpp2IlInjected.Token(Token = "0x4000370")]
			private static MaterialPropertyBlock XQDHZIHNMAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			internal List<GQNDLWIVBXQ> QXGNSGKNBDZ;

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x9F94D80", Offset = "0x9F93580", VA = "0x189F94D80")]
			public AnimationData(Transform tr, double time, bool zeroScale = false, bool recordBlendShapes = true, bool inWorldSpace = false, bool recordAnimationPointer = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x9F94BE0", Offset = "0x9F933E0", VA = "0x189F94BE0")]
			public void Update(double time)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		internal ICollection<Transform> IXQQYWMSFFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private Transform OQYAWLRTKSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private Dictionary<Transform, AnimationData> SGFFMWMCVZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private double OFYSESDPPTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private double UDQRBZGCZQW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		private bool WYTDQQSJFIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		private bool DJUBBJKVQMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private readonly bool TIPCYULYSOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private readonly bool YSIIXRSDSCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private readonly bool VURKKGERPLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public string YONBQQEKIEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public OnBeforeAddAnimationDataDelegate TWHYSIPDCFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public OnPostExportDelegate SCNEEVTEYVU;

		[Cpp2IlInjected.Token(Token = "0x4000361")]
		private static ProfilerMarker SJZBZZFYVKE;

		[Cpp2IlInjected.Token(Token = "0x4000362")]
		private static ProfilerMarker NHSXOTAAFRJ;

		[Cpp2IlInjected.Token(Token = "0x4000363")]
		private static ProfilerMarker ZPHHSMZUODI;

		[Cpp2IlInjected.Token(Token = "0x17000184")]
		public bool YDGOHEMCXUO
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x1854910", Offset = "0x1853110", VA = "0x181854910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000185")]
		public double MULVCUCUEKW
		{
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0xB4DB10", Offset = "0xB4C310", VA = "0x180B4DB10")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x9F9D6E0", Offset = "0x9F9BEE0", VA = "0x189F9D6E0")]
		public LNGBIMZDZSI(Transform a, bool b = true, bool c = false, bool d = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x9F9D550", Offset = "0x9F9BD50", VA = "0x189F9D550")]
		private bool ZWAPQFQKWSF(Transform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x9F9D310", Offset = "0x9F9BB10", VA = "0x189F9D310")]
		public void VOYUGEVSGFO(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x9F9D040", Offset = "0x9F9B840", VA = "0x189F9D040")]
		public void SHAFDMNQLQF(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x9F9C090", Offset = "0x9F9A890", VA = "0x189F9C090")]
		public void ABGEIWZTEGH(string a, string b = "scene", [Optional] GLTFSettings c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x9F9C200", Offset = "0x9F9AA00", VA = "0x189F9C200")]
		public void ABGEIWZTEGH(Stream a, string b = "scene", [Optional] GLTFSettings c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x9F9C8D0", Offset = "0x9F9B0D0", VA = "0x189F9C8D0")]
		private void DSNCMWMNVIX(GLTFSceneExporter a, WTVTOFLEGQC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x9F9CAD0", Offset = "0x9F9B2D0", VA = "0x189F9CAD0")]
		private void HDWRQMBVOKZ(GLTFSceneExporter a, ZCPNPFGNFZG b, bool c, [Out] Bounds d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public class GLTFRecorderBehaviour : PlayableBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class GXJZCZDFVCM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			public GLTFRecorderBehaviour VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			public double SAFVJFPAHJU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			public Playable DATBVJBRVLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			public FrameData AGATNKZULWP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			public object QAKRHRSVDLA;

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public GXJZCZDFVCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x9F9B050", Offset = "0x9F99850", VA = "0x189F9B050")]
			internal void ZUYSRFTZECL()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private LNGBIMZDZSI WFKOTNOUDRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public GLTFRecorderClip Clip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private bool BYBQCYLWSSB;

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x9F99D50", Offset = "0x9F98550", VA = "0x189F99D50")]
		private void VGZNCODEHNB(double a, Transform b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x9F99CF0", Offset = "0x9F984F0", VA = "0x189F99CF0")]
		private void TDXRJCVFFZQ(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x9F996A0", Offset = "0x9F97EA0", VA = "0x189F996A0")]
		private void KIVPPQCNVLJ(double a, Transform b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0")]
		private static bool TLUCNTQIECH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x9F99B10", Offset = "0x9F98310", VA = "0x189F99B10", Slot = "16")]
		public override void OnPlayableDestroy(Playable playable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x9F998E0", Offset = "0x9F980E0", VA = "0x189F998E0", Slot = "13")]
		public override void OnGraphStart(Playable playable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x9F99A70", Offset = "0x9F98270", VA = "0x189F99A70", Slot = "14")]
		public override void OnGraphStop(Playable playable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x9F99BB0", Offset = "0x9F983B0", VA = "0x189F99BB0", Slot = "20")]
		public override void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x17C32A0", Offset = "0x17C1AA0", VA = "0x1817C32A0", Slot = "17")]
		public override void OnBehaviourPlay(Playable playable, FrameData info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x158CA60", Offset = "0x158B260", VA = "0x18158CA60", Slot = "18")]
		public override void OnBehaviourPause(Playable playable, FrameData info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x9F99560", Offset = "0x9F97D60", VA = "0x189F99560")]
		public void BCZRPKHRBFO(double a, Playable b, FrameData c, object d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD670", Offset = "0xABBE70", VA = "0x180ABD670", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(ClipCaps);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x9F99E20", Offset = "0x9F98620", VA = "0x189F99E20", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x9F99F30", Offset = "0x9F98730", VA = "0x189F99F30")]
		public Transform GetExportRoot(PlayableGraph graph)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x9F99F90", Offset = "0x9F98790", VA = "0x189F99F90")]
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
		private sealed class RBVQXCCJCXU : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			private object YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public GLTFRecorderHelper VIXLAPAPYNX;

			[Cpp2IlInjected.Token(Token = "0x1700018E")]
			private object FHSTBNTIQTK
			{
				[Cpp2IlInjected.Token(Token = "0x60003EA")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700018F")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x60003EC")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public RBVQXCCJCXU(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F300", Offset = "0x9F9DB00", VA = "0x189F9F300", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F530", Offset = "0x9F9DD30", VA = "0x189F9F530", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private List<Action> SGHICJISEKV;

		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private static GLTFRecorderHelper OCBBNXVVYII;

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A090", Offset = "0x9F98890", VA = "0x189F9A090")]
		public static void Add(Action callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A330", Offset = "0x9F98B30", VA = "0x189F9A330")]
		private static GLTFRecorderHelper NQPJNBBVKFY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A020", Offset = "0x9F98820", VA = "0x189F9A020")]
		[IteratorStateMachine(typeof(RBVQXCCJCXU))]
		private IEnumerator ALSEUSKBMAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A2B0", Offset = "0x9F98AB0", VA = "0x189F9A2B0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A4B0", Offset = "0x9F98CB0", VA = "0x189F9A4B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9A530", Offset = "0x9F98D30", VA = "0x189F9A530")]
		public GLTFRecorderTrack()
		{
		}
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	internal static class RUAPUEUTMNP
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		[CompilerGenerated]
		private sealed class GZWDQNLWZKX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			public int PDIOMLVUKZL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			public LYIBHYINFZW CMGQDCDQNUY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			public WCSOTBUVZFK VOUSAUVLZKN;

			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public GZWDQNLWZKX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x9F9B6C0", Offset = "0x9F99EC0", VA = "0x189F9B6C0")]
			internal float[] UXVUFOXQMXI(WCSOTBUVZFK a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x9F9B750", Offset = "0x9F99F50", VA = "0x189F9B750")]
			internal float[] UYBBCVRNWIR(WCSOTBUVZFK a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x9F9B5A0", Offset = "0x9F99DA0", VA = "0x189F9B5A0")]
			internal float[] UXLGLBJVUAQ(WCSOTBUVZFK a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0x9F9B630", Offset = "0x9F99E30", VA = "0x189F9B630")]
			internal float[] UXQNIIDTDLZ(WCSOTBUVZFK a, int b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private static readonly string[] BEBZQNLAHIL;

		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private static readonly string[] ITSIIMFQQMD;

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F720", Offset = "0x9F9DF20", VA = "0x189F9F720")]
		internal static bool MXQCRKDOSFU(string a, OCKTDBXZJAD b, Material c, string d, KGQVNKKAGMO e, [Out] WCSOTBUVZFK f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F570", Offset = "0x9F9DD70", VA = "0x189F9F570")]
		internal static string[] DOXUFABFHKR(string a, int b, int c = 0, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x9F9FCA0", Offset = "0x9F9E4A0", VA = "0x189F9FCA0")]
		internal static float[] ROLZDVAGMGH(int a, int b, LYIBHYINFZW c, WCSOTBUVZFK d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class LYIBHYINFZW
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
		public PropertyTypeOption TVZBPRYYIJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public string YVJUHXGPRNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public string BDDTDCLHKYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public bool MDUKHIXFMFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public CombineResultType EASSUYWGVGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public GLTFAccessorAttributeType BPNMXDNYVRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public bool MEMUPXFUOLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public bool UWMAXEFWYIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x36")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public bool VFLGDMDSBGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public float UZXVGJNKAWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public string IBOKXSJRGOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public CombinePrimaryAndSecondaryData RDAAMSXGYWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private string[] NRDAPKLXLWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		internal int[] VQBWCDXSKDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		internal int[] WUBDSJAWJDP;

		[Cpp2IlInjected.Token(Token = "0x17000190")]
		public string[] RBZZDAIQDHU
		{
			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0xA9E160", Offset = "0xA9C960", VA = "0x180A9E160")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0x9F9DD70", Offset = "0x9F9C570", VA = "0x189F9DD70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000191")]
		public bool OKUZBHHEELY
		{
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x9F9DDA0", Offset = "0x9F9C5A0", VA = "0x189F9DDA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x9F9DDC0", Offset = "0x9F9C5C0", VA = "0x189F9DDC0")]
		public LYIBHYINFZW(PropertyTypeOption a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x9F9D960", Offset = "0x9F9C160", VA = "0x189F9D960")]
		private void HHRRYXSNOHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x9F9DC20", Offset = "0x9F9C420", VA = "0x189F9DC20")]
		private static float[] RPHLAOKNHCJ(float[] a, float[] b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x9F9DB00", Offset = "0x9F9C300", VA = "0x189F9DB00")]
		private void IBMDMOQSWHT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class OCKTDBXZJAD
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
		private Dictionary<string, LYIBHYINFZW> ZJFZESHYSGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private Dictionary<string, LYIBHYINFZW> KZRHCSAOTCS;

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x9F9E760", Offset = "0x9F9CF60", VA = "0x189F9E760")]
		public void JSPWYQIDVRX(string a, string[] b, [Optional] string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x9F9EC60", Offset = "0x9F9D460", VA = "0x189F9EC60")]
		public void PRPRHBZRQHC(LYIBHYINFZW a, ImportExportUsageOption b = ImportExportUsageOption.ImportAndExport)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x9F9E540", Offset = "0x9F9CD40", VA = "0x189F9E540")]
		public bool HLRVHWUPCOP(Material a, string b, [Out] LYIBHYINFZW c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x9F9EE80", Offset = "0x9F9D680", VA = "0x189F9EE80")]
		public bool XMLPGJSHCIU(Material a, string b, [Out] string c, [Out] LYIBHYINFZW d, [Out] bool e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F250", Offset = "0x9F9DA50", VA = "0x189F9F250")]
		public OCKTDBXZJAD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public class DDVDWLPLZTW : OCKTDBXZJAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x9F960E0", Offset = "0x9F948E0", VA = "0x189F960E0")]
		public DDVDWLPLZTW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public class AnimationPointerExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000192")]
		public override string NROFRYQVSOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0x9F95D00", Offset = "0x9F94500", VA = "0x189F95D00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000193")]
		public override string HPFGLEEPXAT
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x9F95CD0", Offset = "0x9F944D0", VA = "0x189F95CD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		public override bool FUFYAALZRYS
		{
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x9F95C30", Offset = "0x9F94430", VA = "0x189F95C30", Slot = "14")]
		public override NVPVEURSWXA CreateInstance(QEOAQKJBNBK context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x1303990", Offset = "0x1302190", VA = "0x181303990")]
		public AnimationPointerExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public class ASFDZELHRGZ : NVPVEURSWXA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public OCKTDBXZJAD TVIKUZZVAIX;

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x9F94B70", Offset = "0x9F93370", VA = "0x189F94B70")]
		public ASFDZELHRGZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public class AnimationPointerImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000195")]
		public override string NROFRYQVSOM
		{
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x9F95E00", Offset = "0x9F94600", VA = "0x189F95E00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000196")]
		public override string HPFGLEEPXAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x9F95DD0", Offset = "0x9F945D0", VA = "0x189F95DD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x9F95D30", Offset = "0x9F94530", VA = "0x189F95D30", Slot = "13")]
		public override ZBWCSHABZTR CreateInstance(GKBIBFXCLMW context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x1303990", Offset = "0x1302190", VA = "0x181303990")]
		public AnimationPointerImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	public class BGRGRTJIBVO : ZBWCSHABZTR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public OCKTDBXZJAD TVIKUZZVAIX;

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x9F95F50", Offset = "0x9F94750", VA = "0x189F95F50")]
		public BGRGRTJIBVO()
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
		[Cpp2IlInjected.Address(RVA = "0xAC9A60", Offset = "0xAC8260", VA = "0x180AC9A60")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC9A60", Offset = "0xAC8260", VA = "0x180AC9A60")]
		public ExperimentalPluginAttribute([Optional] string tooltip)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public abstract class GLTFExportPlugin : GLTFPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000197")]
		public virtual JToken VMBGJEGYZWO
		{
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(Slot = "14")]
		public abstract NVPVEURSWXA CreateInstance(QEOAQKJBNBK context);

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x1303990", Offset = "0x1302190", VA = "0x181303990")]
		protected GLTFExportPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public abstract class NVPVEURSWXA
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "4")]
		public virtual void TGGSUHVDIMS(GLTFSceneExporter a, WTVTOFLEGQC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
		public virtual void XPSISWXJQFV(GLTFSceneExporter a, WTVTOFLEGQC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0", Slot = "6")]
		public virtual bool FSZXIYLIKSO(GLTFSceneExporter a, WTVTOFLEGQC b, Transform c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "7")]
		public virtual void DYLDTRGEEZU(GLTFSceneExporter a, WTVTOFLEGQC b, Transform c, BERLEXGGYBZ d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "8")]
		public virtual void XGUTBCAIYDT(GLTFSceneExporter a, WTVTOFLEGQC b, Transform c, BERLEXGGYBZ d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "9")]
		public virtual bool SYBEISKFSHN(GLTFSceneExporter a, WTVTOFLEGQC b, Material c, OFRYBPDMWCH d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "10")]
		public virtual void NUOQYQFPDEE(GLTFSceneExporter a, WTVTOFLEGQC b, Material c, OFRYBPDMWCH d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "11")]
		public virtual void VBAMIROOMAV(GLTFSceneExporter a, GLTFSceneExporter.UniqueTexture b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "12")]
		public virtual void UPTZBMOLRBS(GLTFSceneExporter a, GLTFSceneExporter.UniqueTexture b, int c, RAWOIEBXRSB d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "13")]
		public virtual void BWXMCYDCJBA(GLTFSceneExporter a, Mesh b, XABKJXLEVAH c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "14")]
		public virtual void YTBRGDZWSME(GLTFSceneExporter a, Mesh b, HMCQBNAUHVJ c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		protected NVPVEURSWXA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public abstract class GLTFImportPlugin : GLTFPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(Slot = "13")]
		public abstract ZBWCSHABZTR CreateInstance(GKBIBFXCLMW context);

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x1303990", Offset = "0x1302190", VA = "0x181303990")]
		protected GLTFImportPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public abstract class ZBWCSHABZTR
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "4")]
		public virtual void BIEYESJHKLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
		public virtual void SROGMHSTRAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "6")]
		public virtual void AKVRFNLAZUV(WTVTOFLEGQC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "7")]
		public virtual void CPVYYIRSYKU(FHGUWOJFITY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "8")]
		public virtual void AEIZNWAUJBT(BERLEXGGYBZ a, int b, GameObject c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "9")]
		public virtual void XNZDMYPYPII(OFRYBPDMWCH a, int b, Material c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "10")]
		public virtual void IPDMXBNNCTK(RAWOIEBXRSB a, int b, Texture c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "11")]
		public virtual void AOUXMVJCKGT(FHGUWOJFITY a, int b, GameObject c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		protected ZBWCSHABZTR()
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
		public abstract string NROFRYQVSOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		public virtual string HPFGLEEPXAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		public virtual string RDOZZEYEVKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		public virtual bool MVQOJPYSRSA
		{
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0x9F99540", Offset = "0x9F97D40", VA = "0x189F99540", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0xAA2A00", Offset = "0xAA1200", VA = "0x180AA2A00", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		public virtual bool FUFYAALZRYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019D")]
		public virtual bool AEGAOAJLSPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		public virtual string KVKTPIJSRPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000437")]
			[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		public virtual bool BIRGBVNSOGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x1303990", Offset = "0x1302190", VA = "0x181303990")]
		protected GLTFPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[Obsolete("Use UnityGLTF.Plugins.GLTFPlugin instead. (UnityUpgradable) -> UnityGLTF.Plugins.GLTFPlugin")]
	public abstract class GltfPlugin : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0xBD9960", Offset = "0xBD8160", VA = "0x180BD9960")]
		protected GltfPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[Obsolete("Use UnityGLTF.Plugins.GLTFImportPlugin instead. (UnityUpgradable) -> UnityGLTF.Plugins.GLTFImportPlugin")]
	public abstract class GltfImportPlugin : GltfPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0xBD9960", Offset = "0xBD8160", VA = "0x180BD9960")]
		protected GltfImportPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[Obsolete("Use UnityGLTF.Plugins.GLTFExportPlugin instead. (UnityUpgradable) -> UnityGLTF.Plugins.GLTFExportPlugin")]
	public abstract class GltfExportPlugin : GltfPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0xBD9960", Offset = "0xBD8160", VA = "0x180BD9960")]
		protected GltfExportPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public class GKBIBFXCLMW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public readonly List<ZBWCSHABZTR> VNIIDZCSQOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public GLTFSceneImporter WWLJSKWEWWL;

		[Cpp2IlInjected.Token(Token = "0x170001A0")]
		public WTVTOFLEGQC XQVYPEOBNLV
		{
			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0x9F992D0", Offset = "0x9F97AD0", VA = "0x189F992D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x9F992F0", Offset = "0x9F97AF0", VA = "0x189F992F0")]
		private List<ZBWCSHABZTR> VERWUDFWMTJ(GLTFSettings a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x9F99500", Offset = "0x9F97D00", VA = "0x189F99500")]
		internal GKBIBFXCLMW(GLTFSettings a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x3697D50", Offset = "0x3696550", VA = "0x183697D50")]
		public bool PPHDWAHLCVB<a>([Out] a a) where a : ZBWCSHABZTR
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public class DracoImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001A1")]
		public override string NROFRYQVSOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0x9F99120", Offset = "0x9F97920", VA = "0x189F99120", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A2")]
		public override string HPFGLEEPXAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0x9F990F0", Offset = "0x9F978F0", VA = "0x189F990F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A3")]
		public override bool BIRGBVNSOGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x9F990A0", Offset = "0x9F978A0", VA = "0x189F990A0", Slot = "13")]
		public override ZBWCSHABZTR CreateInstance(GKBIBFXCLMW context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x1303990", Offset = "0x1302190", VA = "0x181303990")]
		public DracoImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public class NBMBJKZHKYC : ZBWCSHABZTR
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public NBMBJKZHKYC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public class GPUInstancingImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001A4")]
		public override string NROFRYQVSOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0x9F9A600", Offset = "0x9F98E00", VA = "0x189F9A600", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A5")]
		public override string HPFGLEEPXAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(RVA = "0x9F9A5D0", Offset = "0x9F98DD0", VA = "0x189F9A5D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A580", Offset = "0x9F98D80", VA = "0x189F9A580", Slot = "13")]
		public override ZBWCSHABZTR CreateInstance(GKBIBFXCLMW context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x1303990", Offset = "0x1302190", VA = "0x181303990")]
		public GPUInstancingImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public class PWZTEZTFJMZ : ZBWCSHABZTR
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public PWZTEZTFJMZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public class Ktx2Import : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001A6")]
		public override string NROFRYQVSOM
		{
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0x9F9C060", Offset = "0x9F9A860", VA = "0x189F9C060", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A7")]
		public override string HPFGLEEPXAT
		{
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0x9F9C030", Offset = "0x9F9A830", VA = "0x189F9C030", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A8")]
		public override bool BIRGBVNSOGP
		{
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x9F9BFE0", Offset = "0x9F9A7E0", VA = "0x189F9BFE0", Slot = "13")]
		public override ZBWCSHABZTR CreateInstance(GKBIBFXCLMW context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x1303990", Offset = "0x1302190", VA = "0x181303990")]
		public Ktx2Import()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public class RRUJQXHMVLE : ZBWCSHABZTR
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public RRUJQXHMVLE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public class LightsPunctualExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001A9")]
		public override string NROFRYQVSOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x9F9E090", Offset = "0x9F9C890", VA = "0x189F9E090", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		public override string HPFGLEEPXAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0x9F9E060", Offset = "0x9F9C860", VA = "0x189F9E060", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x9F9E010", Offset = "0x9F9C810", VA = "0x189F9E010", Slot = "14")]
		public override NVPVEURSWXA CreateInstance(QEOAQKJBNBK context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x1303990", Offset = "0x1302190", VA = "0x181303990")]
		public LightsPunctualExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public class ZFZUGQTAQJP : NVPVEURSWXA
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "8")]
		public override void XGUTBCAIYDT(GLTFSceneExporter a, WTVTOFLEGQC b, Transform c, BERLEXGGYBZ d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public ZFZUGQTAQJP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public class LightsPunctualImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		public override string NROFRYQVSOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0x9F9E140", Offset = "0x9F9C940", VA = "0x189F9E140", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public override string HPFGLEEPXAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0x9F9E110", Offset = "0x9F9C910", VA = "0x189F9E110", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x9F9E0C0", Offset = "0x9F9C8C0", VA = "0x189F9E0C0", Slot = "13")]
		public override ZBWCSHABZTR CreateInstance(GKBIBFXCLMW context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x1303990", Offset = "0x1302190", VA = "0x181303990")]
		public LightsPunctualImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public class TDMFCQYJBBW : ZBWCSHABZTR
	{
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public TDMFCQYJBBW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[NonRatifiedPlugin(null)]
	public class LodsExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		public override string NROFRYQVSOM
		{
			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0x9F9E1F0", Offset = "0x9F9C9F0", VA = "0x189F9E1F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		public override string HPFGLEEPXAT
		{
			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0x9F9E1C0", Offset = "0x9F9C9C0", VA = "0x189F9E1C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x9F9E170", Offset = "0x9F9C970", VA = "0x189F9E170", Slot = "14")]
		public override NVPVEURSWXA CreateInstance(QEOAQKJBNBK context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x1303990", Offset = "0x1302190", VA = "0x181303990")]
		public LodsExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public class GYOGXPIVUVC : NVPVEURSWXA
	{
		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x9F9B1A0", Offset = "0x9F999A0", VA = "0x189F9B1A0", Slot = "8")]
		public override void XGUTBCAIYDT(GLTFSceneExporter a, WTVTOFLEGQC b, Transform c, BERLEXGGYBZ d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public GYOGXPIVUVC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[NonRatifiedPlugin(null)]
	public class LodsImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		public override string NROFRYQVSOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0x9F9E2A0", Offset = "0x9F9CAA0", VA = "0x189F9E2A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		public override string HPFGLEEPXAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0x9F9E270", Offset = "0x9F9CA70", VA = "0x189F9E270", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x9F9E220", Offset = "0x9F9CA20", VA = "0x189F9E220", Slot = "13")]
		public override ZBWCSHABZTR CreateInstance(GKBIBFXCLMW context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x1303990", Offset = "0x1302190", VA = "0x181303990")]
		public LodsImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public class ETTVNVKCVBL : ZBWCSHABZTR
	{
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public ETTVNVKCVBL()
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
		public override string NROFRYQVSOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0x9F9E380", Offset = "0x9F9CB80", VA = "0x189F9E380", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		public override string HPFGLEEPXAT
		{
			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0x9F9E350", Offset = "0x9F9CB50", VA = "0x189F9E350", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x9F9E2D0", Offset = "0x9F9CAD0", VA = "0x189F9E2D0", Slot = "14")]
		public override NVPVEURSWXA CreateInstance(QEOAQKJBNBK context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x9F9E330", Offset = "0x9F9CB30", VA = "0x189F9E330")]
		public MaterialExtensionsExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public class XTTWJVRIHDP : NVPVEURSWXA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		internal readonly MaterialExtensionsExport ZGAONCAEWSS;

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private static readonly int NPMHFADMTLA;

		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private static readonly int LTASKSSYWMU;

		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private static readonly int PEGFDRZPFCK;

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private static readonly int ZRKWQPKQUSM;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private static readonly int XKXULBLJYET;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private static readonly int XFGLTOMUUIQ;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private static readonly int GAVKWVZCHOW;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private static readonly int SMGSROXZFWV;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private static readonly int FHWRANXIETU;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private static readonly int YCHQAXZKGFT;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private static readonly int WFIERYZGCOH;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private static readonly int BYOXOIXBHPD;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private static readonly int EMCAVZXILZC;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private static readonly int HZWPZQNTAOE;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private static readonly int BPCZCUSPXHL;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private static readonly int EXHNOBYLLXM;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private static readonly int PVFBSWZOUTH;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private static readonly int EXBXHMOQBRW;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private static readonly int XVEBAPJUGLG;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private static readonly int UYBYPARPSZY;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private static readonly int DGLAOFKATQM;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private static readonly int VZTCRTXJOYW;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private static readonly int RTYEWHFQNXN;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private static readonly int IEPIYLMKJAM;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private static readonly int CCMVEUJWJEB;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private static readonly int OLPJVMPVXMC;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private static readonly int BXUVWSNPICR;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private static readonly int GNHJWXNIPSS;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private static readonly int TEYPPQXEXBD;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private static readonly int EDLICIIKAQW;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE900", Offset = "0xAAD100", VA = "0x180AAE900")]
		public XTTWJVRIHDP(MaterialExtensionsExport a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x9FA2C00", Offset = "0x9FA1400", VA = "0x189FA2C00", Slot = "10")]
		public override void NUOQYQFPDEE(GLTFSceneExporter a, WTVTOFLEGQC b, Material c, OFRYBPDMWCH d)
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
		public override string NROFRYQVSOM
		{
			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0x9F9E460", Offset = "0x9F9CC60", VA = "0x189F9E460", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		public override string HPFGLEEPXAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0x9F9E430", Offset = "0x9F9CC30", VA = "0x189F9E430", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x9F9E3B0", Offset = "0x9F9CBB0", VA = "0x189F9E3B0", Slot = "13")]
		public override ZBWCSHABZTR CreateInstance(GKBIBFXCLMW context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x9F9E410", Offset = "0x9F9CC10", VA = "0x189F9E410")]
		public MaterialExtensionsImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public class YVMEDLJCODW : ZBWCSHABZTR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		internal readonly MaterialExtensionsImport ZGAONCAEWSS;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0xAAE900", Offset = "0xAAD100", VA = "0x180AAE900")]
		public YVMEDLJCODW(MaterialExtensionsImport a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public class MeshoptImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		public override string NROFRYQVSOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0x9F9E510", Offset = "0x9F9CD10", VA = "0x189F9E510", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public override string HPFGLEEPXAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x9F9E4E0", Offset = "0x9F9CCE0", VA = "0x189F9E4E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		public override bool BIRGBVNSOGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x9F9E490", Offset = "0x9F9CC90", VA = "0x189F9E490", Slot = "13")]
		public override ZBWCSHABZTR CreateInstance(GKBIBFXCLMW context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x1303990", Offset = "0x1302190", VA = "0x181303990")]
		public MeshoptImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public class CEXXFYNYOJH : ZBWCSHABZTR
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public CEXXFYNYOJH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public class TextureTransformExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001B8")]
		public override string NROFRYQVSOM
		{
			[Cpp2IlInjected.Token(Token = "0x600047A")]
			[Cpp2IlInjected.Address(RVA = "0x9FA0760", Offset = "0x9F9EF60", VA = "0x189FA0760", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B9")]
		public override string HPFGLEEPXAT
		{
			[Cpp2IlInjected.Token(Token = "0x600047B")]
			[Cpp2IlInjected.Address(RVA = "0x9FA0730", Offset = "0x9F9EF30", VA = "0x189FA0730", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		public override bool AEGAOAJLSPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "14")]
		public override NVPVEURSWXA CreateInstance(QEOAQKJBNBK context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x1303990", Offset = "0x1302190", VA = "0x181303990")]
		public TextureTransformExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public class TextureTransformImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001BB")]
		public override string NROFRYQVSOM
		{
			[Cpp2IlInjected.Token(Token = "0x600047F")]
			[Cpp2IlInjected.Address(RVA = "0x9FA07C0", Offset = "0x9F9EFC0", VA = "0x189FA07C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		public override string HPFGLEEPXAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000480")]
			[Cpp2IlInjected.Address(RVA = "0x9FA0790", Offset = "0x9F9EF90", VA = "0x189FA0790", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		public override bool AEGAOAJLSPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000481")]
			[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "13")]
		public override ZBWCSHABZTR CreateInstance(GKBIBFXCLMW context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x1303990", Offset = "0x1302190", VA = "0x181303990")]
		public TextureTransformImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public class UnlitMaterialsExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001BE")]
		public override string NROFRYQVSOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000484")]
			[Cpp2IlInjected.Address(RVA = "0x9FA1D70", Offset = "0x9FA0570", VA = "0x189FA1D70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		public override string HPFGLEEPXAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000485")]
			[Cpp2IlInjected.Address(RVA = "0x9FA1D40", Offset = "0x9FA0540", VA = "0x189FA1D40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		public override bool AEGAOAJLSPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000486")]
			[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "14")]
		public override NVPVEURSWXA CreateInstance(QEOAQKJBNBK context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x1303990", Offset = "0x1302190", VA = "0x181303990")]
		public UnlitMaterialsExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public class UnlitMaterialsImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001C1")]
		public override string NROFRYQVSOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000489")]
			[Cpp2IlInjected.Address(RVA = "0x9FA1DD0", Offset = "0x9FA05D0", VA = "0x189FA1DD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C2")]
		public override string HPFGLEEPXAT
		{
			[Cpp2IlInjected.Token(Token = "0x600048A")]
			[Cpp2IlInjected.Address(RVA = "0x9FA1DA0", Offset = "0x9FA05A0", VA = "0x189FA1DA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C3")]
		public override bool AEGAOAJLSPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600048B")]
			[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "13")]
		public override ZBWCSHABZTR CreateInstance(GKBIBFXCLMW context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x1303990", Offset = "0x1302190", VA = "0x181303990")]
		public UnlitMaterialsImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public class VisibilityExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		public override string NROFRYQVSOM
		{
			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0x9FA1E30", Offset = "0x9FA0630", VA = "0x189FA1E30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		public override string HPFGLEEPXAT
		{
			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0x9FA1E00", Offset = "0x9FA0600", VA = "0x189FA1E00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		public override bool AEGAOAJLSPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000490")]
			[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		public override bool FUFYAALZRYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "14")]
		public override NVPVEURSWXA CreateInstance(QEOAQKJBNBK context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x1303990", Offset = "0x1302190", VA = "0x181303990")]
		public VisibilityExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public class VisibilityImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		public override string NROFRYQVSOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000494")]
			[Cpp2IlInjected.Address(RVA = "0x9FA1E90", Offset = "0x9FA0690", VA = "0x189FA1E90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		public override string HPFGLEEPXAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000495")]
			[Cpp2IlInjected.Address(RVA = "0x9FA1E60", Offset = "0x9FA0660", VA = "0x189FA1E60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CA")]
		public override bool AEGAOAJLSPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000496")]
			[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "13")]
		public override ZBWCSHABZTR CreateInstance(GKBIBFXCLMW context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x1303990", Offset = "0x1302190", VA = "0x181303990")]
		public VisibilityImport()
		{
		}
	}
}
namespace UnityGLTF.Loader
{
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public class RJFOJBITNXI
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
	public interface VOPNHUYCENH
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Stream> AHTRIEEKQSJ(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public interface DXCRSXUTICF : VOPNHUYCENH
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Stream WZBUXZOPCSH(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[Obsolete("Please switch to IDataLoader.  This interface is deprecated and will be removed in a future release.")]
	public interface NWHPLDMHAXL
	{
		[Cpp2IlInjected.Token(Token = "0x170001CB")]
		Stream PTGVRKQSMRQ
		{
			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		bool JBVFYGFEHJV
		{
			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task WZBUXZOPCSH(string a);

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void QBFYAEBAKQU(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	public static class FCQAGWMAXHE
	{
		[Cpp2IlInjected.Token(Token = "0x20000DC")]
		private class GSPFGJKFCYP : VOPNHUYCENH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000405")]
			protected readonly NWHPLDMHAXL IZMYJSBJZAD;

			[Cpp2IlInjected.Token(Token = "0x60004A0")]
			[Cpp2IlInjected.Address(RVA = "0xAAE900", Offset = "0xAAD100", VA = "0x180AAE900")]
			public GSPFGJKFCYP(NWHPLDMHAXL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A1")]
			[Cpp2IlInjected.Address(RVA = "0x9F9AF40", Offset = "0x9F99740", VA = "0x189F9AF40", Slot = "4")]
			public Task<Stream> AHTRIEEKQSJ(string a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000DD")]
		private class HYPBKLRMNML : GSPFGJKFCYP, DXCRSXUTICF, VOPNHUYCENH
		{
			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0xAAE900", Offset = "0xAAD100", VA = "0x180AAE900")]
			public HYPBKLRMNML(NWHPLDMHAXL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0x9F9B7E0", Offset = "0x9F99FE0", VA = "0x189F9B7E0", Slot = "5")]
			public Stream WZBUXZOPCSH(string a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x9F99150", Offset = "0x9F97950", VA = "0x189F99150")]
		public static VOPNHUYCENH ZLWQJUJROUL(NWHPLDMHAXL a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public class YFIKNKYDNWA : VOPNHUYCENH
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
			public YFIKNKYDNWA <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x9FA07F0", Offset = "0x9F9EFF0", VA = "0x189FA07F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0x9FA0DD0", Offset = "0x9F9F5D0", VA = "0x189FA0DD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		private string PGUQVNHVYZQ;

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE900", Offset = "0xAAD100", VA = "0x180AAE900")]
		public YFIKNKYDNWA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x9FA5540", Offset = "0x9FA3D40", VA = "0x189FA5540", Slot = "4")]
		[AsyncStateMachine(typeof(<LoadStreamAsync>d__2))]
		public Task<Stream> AHTRIEEKQSJ(string a)
		{
			return null;
		}
	}
}
namespace UnityGLTF.Extensions
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public class XTPLBDEGCRK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private readonly List<KHR_animation_pointer> VVZULOOKXOP;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private static readonly ProfilerMarker AMIBUNITBTW;

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x9FA2110", Offset = "0x9FA0910", VA = "0x189FA2110")]
		public void Add(KHR_animation_pointer anim)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x9FA21C0", Offset = "0x9FA09C0", VA = "0x189FA21C0")]
		public void KSFCDVEUHWF(GLTFSceneExporter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x9FA2B80", Offset = "0x9FA1380", VA = "0x189FA2B80")]
		public XTPLBDEGCRK()
		{
		}
	}
}
namespace UnityGLTF.JsonPointer
{
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public interface EWWEHVFYVZR
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool SRYSWPLJQCE(object a, string b);
	}
}
namespace UnityGLTF.Cache
{
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	public struct AnimationSamplerCacheData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public KGQVNKKAGMO Input;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public KGQVNKKAGMO Output;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public InterpolationType Interpolation;
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public class TGSVVWJZEJV
	{
		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		public AnimationClip BLALSCFSYFE
		{
			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0xAA1620", Offset = "0xA9FE20", VA = "0x180AA1620")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		public AnimationSamplerCacheData[] EKXUXTNWQZM
		{
			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0xAA1640", Offset = "0xA9FE40", VA = "0x180AA1640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x9FA0540", Offset = "0x9F9ED40", VA = "0x189FA0540")]
		public TGSVVWJZEJV(int a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public class GQZMQGTLBER : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		public Stream[] KZJSQVWASFI
		{
			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0xAA1620", Offset = "0xA9FE20", VA = "0x180AA1620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		public Texture2D[] GUQQVQHQIQS
		{
			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0xAA1640", Offset = "0xA9FE40", VA = "0x180AA1640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D1")]
		public Texture2D[] KPADOOMCQUD
		{
			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AB0", Offset = "0xAA02B0", VA = "0x180AA1AB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0xAA1370", Offset = "0xA9FB70", VA = "0x180AA1370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		public SEXIHJFRYDC[] KCNNHFBRAAI
		{
			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0xAA15F0", Offset = "0xA9FDF0", VA = "0x180AA15F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0xAA1380", Offset = "0xA9FB80", VA = "0x180AA1380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		public LWOCUPPHHEE[] TLLKJXMNJCI
		{
			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0xAA1630", Offset = "0xA9FE30", VA = "0x180AA1630")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0xAA1600", Offset = "0xA9FE00", VA = "0x180AA1600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		public WWINNTQBYHL[] VUJESMJHLXP
		{
			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0xAA7DA0", Offset = "0xAA65A0", VA = "0x180AA7DA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0xAA7D40", Offset = "0xAA6540", VA = "0x180AA7D40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		public BDZRJNDXSAM[] LSMTJRUKJJW
		{
			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0xAA8580", Offset = "0xAA6D80", VA = "0x180AA8580")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0xAA7D80", Offset = "0xAA6580", VA = "0x180AA7D80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		public PNFTVZIKROF[] WYNWWOTCJEZ
		{
			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0xAA3250", Offset = "0xAA1A50", VA = "0x180AA3250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0xAA3260", Offset = "0xAA1A60", VA = "0x180AA3260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public TGSVVWJZEJV[] TIPRHHFMTRJ
		{
			[Cpp2IlInjected.Token(Token = "0x60004C2")]
			[Cpp2IlInjected.Address(RVA = "0xA9E160", Offset = "0xA9C960", VA = "0x180A9E160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C3")]
			[Cpp2IlInjected.Address(RVA = "0xA9E120", Offset = "0xA9C920", VA = "0x180A9E120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		public GameObject[] FTCSMEUQSMX
		{
			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0xA9E400", Offset = "0xA9CC00", VA = "0x180A9E400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C5")]
			[Cpp2IlInjected.Address(RVA = "0xA9E150", Offset = "0xA9C950", VA = "0x180A9E150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x9F9AC60", Offset = "0x9F99460", VA = "0x189F9AC60")]
		public GQZMQGTLBER(WTVTOFLEGQC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x9F9AB50", Offset = "0x9F99350", VA = "0x189F9AB50", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public class WWINNTQBYHL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		public uint XEUBDQFNZDZ
		{
			[Cpp2IlInjected.Token(Token = "0x60004C8")]
			[Cpp2IlInjected.Address(RVA = "0xA9E110", Offset = "0xA9C910", VA = "0x180A9E110")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0xAA9530", Offset = "0xAA7D30", VA = "0x180AA9530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		public Stream ULROGACWTLB
		{
			[Cpp2IlInjected.Token(Token = "0x60004CA")]
			[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004CB")]
			[Cpp2IlInjected.Address(RVA = "0xAA1640", Offset = "0xA9FE40", VA = "0x180AA1640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		public NativeArray<byte> YUIOKUDNLEN
		{
			[Cpp2IlInjected.Token(Token = "0x60004CC")]
			[Cpp2IlInjected.Address(RVA = "0xBEB760", Offset = "0xBE9F60", VA = "0x180BEB760")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x60004CD")]
			[Cpp2IlInjected.Address(RVA = "0xCCCCA0", Offset = "0xCCB4A0", VA = "0x180CCCCA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x71BC590", Offset = "0x71BAD90", VA = "0x1871BC590", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public WWINNTQBYHL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	internal static class JPMBNLKTONX
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0xCC1740", Offset = "0xCBFF40", VA = "0x180CC1740")]
		public static bool VBDXUANNHLZ(UnityEngine.Object a, string b, [Out] byte[] c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990")]
		public static void ENZJCAVAZVH(UnityEngine.Object a, string b, byte[] c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	public class LWOCUPPHHEE : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		public Material VXTPXGXGJXP
		{
			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0xAA1620", Offset = "0xA9FE20", VA = "0x180AA1620")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		public Material GIPSQHXEGNE
		{
			[Cpp2IlInjected.Token(Token = "0x60004D4")]
			[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0xAA1640", Offset = "0xA9FE40", VA = "0x180AA1640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		public OFRYBPDMWCH OFRYBPDMWCH
		{
			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0xAA1370", Offset = "0xA9FB70", VA = "0x180AA1370")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x9F9D860", Offset = "0x9F9C060", VA = "0x189F9D860", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public LWOCUPPHHEE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public class BDZRJNDXSAM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		public class CVUXWNXPKIK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			public bool XOPMQSPRQOR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000429")]
			public Dictionary<string, KGQVNKKAGMO> HBWHKAHLKTA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042A")]
			public List<Dictionary<string, KGQVNKKAGMO>> NDZKUQJMMTR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			public Dictionary<string, (KGQVNKKAGMO sparseIndices, KGQVNKKAGMO sparseValues)> ENQWMFNTJAB;

			[Cpp2IlInjected.Token(Token = "0x60004DD")]
			[Cpp2IlInjected.Address(RVA = "0x9F95FC0", Offset = "0x9F947C0", VA = "0x189F95FC0")]
			public CVUXWNXPKIK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public List<CVUXWNXPKIK> LJNPRVWIJSR;

		[Cpp2IlInjected.Token(Token = "0x170001DF")]
		public Mesh TLJNZBFHQJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60004D9")]
			[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004DA")]
			[Cpp2IlInjected.Address(RVA = "0xAA1640", Offset = "0xA9FE40", VA = "0x180AA1640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x9F95E30", Offset = "0x9F94630", VA = "0x189F95E30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x9F95ED0", Offset = "0x9F946D0", VA = "0x189F95ED0")]
		public BDZRJNDXSAM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	public class JXALHSHLRHW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private bool GPVXIDBCNNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private int ROZOWVUOXFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private readonly object PNOIKCDHAYP;

		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		public BDZRJNDXSAM[] LSMTJRUKJJW
		{
			[Cpp2IlInjected.Token(Token = "0x60004DE")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AB0", Offset = "0xAA02B0", VA = "0x180AA1AB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004DF")]
			[Cpp2IlInjected.Address(RVA = "0xAA1370", Offset = "0xA9FB70", VA = "0x180AA1370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		public UnityEngine.Object[] BEOTFWZLDBR
		{
			[Cpp2IlInjected.Token(Token = "0x60004E0")]
			[Cpp2IlInjected.Address(RVA = "0xAA15F0", Offset = "0xA9FDF0", VA = "0x180AA15F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E1")]
			[Cpp2IlInjected.Address(RVA = "0xAA1380", Offset = "0xA9FB80", VA = "0x180AA1380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		public LWOCUPPHHEE[] TLLKJXMNJCI
		{
			[Cpp2IlInjected.Token(Token = "0x60004E2")]
			[Cpp2IlInjected.Address(RVA = "0xAA1630", Offset = "0xA9FE30", VA = "0x180AA1630")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E3")]
			[Cpp2IlInjected.Address(RVA = "0xAA1600", Offset = "0xA9FE00", VA = "0x180AA1600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		public SEXIHJFRYDC[] KCNNHFBRAAI
		{
			[Cpp2IlInjected.Token(Token = "0x60004E4")]
			[Cpp2IlInjected.Address(RVA = "0xAA7DA0", Offset = "0xAA65A0", VA = "0x180AA7DA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E5")]
			[Cpp2IlInjected.Address(RVA = "0xAA7D40", Offset = "0xAA6540", VA = "0x180AA7D40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		public TGSVVWJZEJV[] TIPRHHFMTRJ
		{
			[Cpp2IlInjected.Token(Token = "0x60004E6")]
			[Cpp2IlInjected.Address(RVA = "0xAA8580", Offset = "0xAA6D80", VA = "0x180AA8580")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E7")]
			[Cpp2IlInjected.Address(RVA = "0xAA7D80", Offset = "0xAA6580", VA = "0x180AA7D80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		public Texture2D[] GUQQVQHQIQS
		{
			[Cpp2IlInjected.Token(Token = "0x60004E8")]
			[Cpp2IlInjected.Address(RVA = "0xAA3250", Offset = "0xAA1A50", VA = "0x180AA3250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E9")]
			[Cpp2IlInjected.Address(RVA = "0xAA3260", Offset = "0xAA1A60", VA = "0x180AA3260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x9F9BEE0", Offset = "0x9F9A6E0", VA = "0x189F9BEE0")]
		public JXALHSHLRHW(LWOCUPPHHEE[] a, BDZRJNDXSAM[] b, SEXIHJFRYDC[] c, Texture2D[] d, TGSVVWJZEJV[] e, UnityEngine.Object[] f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x9F9B8C0", Offset = "0x9F9A0C0", VA = "0x189F9B8C0")]
		public void BNHMSPFBQYT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x9F9B9A0", Offset = "0x9F9A1A0", VA = "0x189F9B9A0")]
		public void QJSAZLAMODF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x9F9BAF0", Offset = "0x9F9A2F0", VA = "0x189F9BAF0")]
		private void XWAPAQFWTOZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public class SEXIHJFRYDC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public RAWOIEBXRSB XJMXAKWAZDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public Texture2D LGICPUPIMLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public bool KVABCRNLRCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public bool NFIMPHULMRO;

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x9FA04A0", Offset = "0x9F9ECA0", VA = "0x189FA04A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public SEXIHJFRYDC()
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
