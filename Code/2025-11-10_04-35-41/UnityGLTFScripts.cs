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
		private sealed class VCQNFSGNIYY : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			private int JIPOOQUWCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private object JOTWNIKQVJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public AsyncCoroutineHelper MXVWDMPVVWS;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			private object PNRLUNGDWHZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000008")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x600000A")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAB07E0", Offset = "0xAAFBE0", VA = "0x180AB07E0")]
			[DebuggerHidden]
			public VCQNFSGNIYY(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "5")]
			[DebuggerHidden]
			private void AEBWHPMOWJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x9FAEB20", Offset = "0x9FADF20", VA = "0x189FAEB20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9FAEAE0", Offset = "0x9FADEE0", VA = "0x189FAEAE0", Slot = "8")]
			[DebuggerHidden]
			private void MJTKPUASZVA()
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
			[Cpp2IlInjected.Address(RVA = "0x9FAD660", Offset = "0x9FACA60", VA = "0x189FAD660", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9FAD850", Offset = "0x9FACC50", VA = "0x189FAD850", Slot = "5")]
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
		private WaitForEndOfFrame DCNWCPYFKAU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private float AXXXMYMGWZM;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9F99770", Offset = "0x9F98B70", VA = "0x189F99770")]
		[AsyncStateMachine(typeof(<YieldOnTimeout>d__3))]
		public Task YieldOnTimeout()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9F996E0", Offset = "0x9F98AE0", VA = "0x189F996E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9F99670", Offset = "0x9F98A70", VA = "0x189F99670")]
		[IteratorStateMachine(typeof(VCQNFSGNIYY))]
		private IEnumerator NRMNBOLUYYV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9F99840", Offset = "0x9F98C40", VA = "0x189F99840")]
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
			private YCKHOEPLNAL <importOptions>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private GLTFSceneImporter <sceneImporter>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x9FA8770", Offset = "0x9FA7B70", VA = "0x189FA8770", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9FA9460", Offset = "0x9FA8860", VA = "0x189FA9460", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9FA94C0", Offset = "0x9FA88C0", VA = "0x189FA94C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
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
		private int XDISLJGAUCE;

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
		public IEnumerable<Animation> KXXITNPWXWV
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xAAA840", Offset = "0xAA9C40", VA = "0x180AAA840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public GameObject XUMNAAZNURX
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAA3120", Offset = "0xAA2520", VA = "0x180AA3120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAA3140", Offset = "0xAA2540", VA = "0x180AA3140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Shader GGSKQAGJLOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xAA5380", Offset = "0xAA4780", VA = "0x180AA5380")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x9F9A270", Offset = "0x9F99670", VA = "0x189F9A270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A150", Offset = "0x9F99550", VA = "0x189F9A150")]
		[AsyncStateMachine(typeof(<Start>d__33))]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A080", Offset = "0x9F99480", VA = "0x189F9A080")]
		[AsyncStateMachine(typeof(<Load>d__34))]
		public Task Load()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9F99F90", Offset = "0x9F99390", VA = "0x189F99F90")]
		public void ApplyOverrideShader()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xD80C50", Offset = "0xD80050", VA = "0x180D80C50")]
		private void EWQJSBPGZUT(GameObject a, ExceptionDispatchInfo b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A200", Offset = "0x9F99600", VA = "0x189F9A200")]
		public GLTFComponent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class GLTFRecorderComponent : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class SVRCOFWKDEH : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private int JIPOOQUWCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private object JOTWNIKQVJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public GLTFRecorderComponent MXVWDMPVVWS;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object PNRLUNGDWHZ
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xAB07E0", Offset = "0xAAFBE0", VA = "0x180AB07E0")]
			[DebuggerHidden]
			public SVRCOFWKDEH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "5")]
			[DebuggerHidden]
			private void AEBWHPMOWJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9FA81A0", Offset = "0x9FA75A0", VA = "0x189FA81A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x9FA8160", Offset = "0x9FA7560", VA = "0x189FA8160", Slot = "8")]
			[DebuggerHidden]
			private void MJTKPUASZVA()
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
		protected RMRJQQSCXOZ LLQONLXLVRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public UnityEvent recordingStarted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public UnityEvent<string> recordingEnded;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool GFKQGBRNYBP
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9F9AA80", Offset = "0x9F99E80", VA = "0x189F9AA80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private double DZLFGKXDXSO
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x9F9A9B0", Offset = "0x9F99DB0", VA = "0x189F9A9B0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A470", Offset = "0x9F99870", VA = "0x189F9A470", Slot = "4")]
		[ContextMenu("Start Recording")]
		public virtual void StartRecording()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A7F0", Offset = "0x9F99BF0", VA = "0x189F9A7F0", Slot = "5")]
		[ContextMenu("Stop Recording")]
		public virtual void StopRecording()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A2A0", Offset = "0x9F996A0", VA = "0x189F9A2A0")]
		private void YBCJSVJNHGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A760", Offset = "0x9F99B60", VA = "0x189F9A760")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A450", Offset = "0x9F99850", VA = "0x189F9A450")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A400", Offset = "0x9F99800", VA = "0x189F9A400", Slot = "6")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A960", Offset = "0x9F99D60", VA = "0x189F9A960", Slot = "7")]
		protected virtual void WGKFIVYIJXI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A8F0", Offset = "0x9F99CF0", VA = "0x189F9A8F0")]
		[IteratorStateMachine(typeof(SVRCOFWKDEH))]
		private IEnumerator TFDHIIPHCYB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A9C0", Offset = "0x9F99DC0", VA = "0x189F9A9C0")]
		public GLTFRecorderComponent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A2A0", Offset = "0x9F996A0", VA = "0x189F9A2A0")]
		[CompilerGenerated]
		private void EODUFJBEWGQ(InputAction.CallbackContext a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class NKLWKJFHFKH
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		internal class AIMSNSFGBBL : KHHMAMVATRX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private readonly NKLWKJFHFKH WRWMSCRHSZW;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xACEB40", Offset = "0xACDF40", VA = "0x180ACEB40")]
			internal AIMSNSFGBBL(NKLWKJFHFKH a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9F99280", Offset = "0x9F98680", VA = "0x189F99280", Slot = "4")]
			public override void PXEIMKWKIRL(GLTFSceneExporter a, FZUMGSVMSUT b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9F992C0", Offset = "0x9F986C0", VA = "0x189F992C0", Slot = "5")]
			public override void YVPQFSMLYHM(GLTFSceneExporter a, FZUMGSVMSUT b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9F99240", Offset = "0x9F98640", VA = "0x189F99240", Slot = "8")]
			public override void OAMIIQWBWOK(GLTFSceneExporter a, FZUMGSVMSUT b, Transform c, CFDTQFFCTZU d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x9F99030", Offset = "0x9F98430", VA = "0x189F99030", Slot = "9")]
			public override bool CNJGQHSQJZU(GLTFSceneExporter a, FZUMGSVMSUT b, Material c, WKXGTXFNJNI d)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x9F99180", Offset = "0x9F98580", VA = "0x189F99180", Slot = "10")]
			public override void GDBMTTLOZLJ(GLTFSceneExporter a, FZUMGSVMSUT b, Material c, WKXGTXFNJNI d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9F99200", Offset = "0x9F98600", VA = "0x189F99200", Slot = "11")]
			public override void JOAMAMAABMS(GLTFSceneExporter a, GLTFSceneExporter.UniqueTexture b, string c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x9F99300", Offset = "0x9F98700", VA = "0x189F99300", Slot = "12")]
			public override void ZQDRVUXWWAF(GLTFSceneExporter a, GLTFSceneExporter.UniqueTexture b, int c, XRKEDLFRQLY d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9F99140", Offset = "0x9F98540", VA = "0x189F99140", Slot = "13")]
			public override void EGGZEKNATYP(GLTFSceneExporter a, Mesh b, JRRIGPAJAOY c, int d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9F991C0", Offset = "0x9F985C0", VA = "0x189F991C0", Slot = "14")]
			public override void IQHIPRUOGHR(GLTFSceneExporter a, Mesh b, DERQUSIAPDY c, int d)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public bool KJXCTEUZSGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public LayerMask PZUPCZSRHLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public ILogger HTJZWUEHBYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		internal readonly GLTFSettings NJRVEUBYIBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public GLTFSceneExporter.RetrieveTexturePathDelegate IWNZALNYFSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public GLTFSceneExporter.AfterSceneExportDelegate YVPQFSMLYHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public GLTFSceneExporter.BeforeSceneExportDelegate PXEIMKWKIRL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public GLTFSceneExporter.AfterNodeExportDelegate OAMIIQWBWOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public GLTFSceneExporter.BeforeMaterialExportDelegate CNJGQHSQJZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public GLTFSceneExporter.AfterMaterialExportDelegate GDBMTTLOZLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public GLTFSceneExporter.BeforeTextureExportDelegate JOAMAMAABMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public GLTFSceneExporter.AfterTextureExportDelegate ZQDRVUXWWAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public GLTFSceneExporter.AfterPrimitiveExportDelegate EGGZEKNATYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public GLTFSceneExporter.AfterMeshExportDelegate IQHIPRUOGHR;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9FA7DA0", Offset = "0x9FA71A0", VA = "0x189FA7DA0")]
		public NKLWKJFHFKH(GLTFSettings a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9FA7D40", Offset = "0x9FA7140", VA = "0x189FA7D40")]
		internal KHHMAMVATRX GOQQDQICLNH()
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
		public delegate void BeforeSceneExportDelegate(GLTFSceneExporter exporter, FZUMGSVMSUT gltfRoot);

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public delegate void AfterSceneExportDelegate(GLTFSceneExporter exporter, FZUMGSVMSUT gltfRoot);

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void AfterNodeExportDelegate(GLTFSceneExporter exporter, FZUMGSVMSUT gltfRoot, Transform transform, CFDTQFFCTZU node);

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate bool BeforeMaterialExportDelegate(GLTFSceneExporter exporter, FZUMGSVMSUT gltfRoot, Material material, WKXGTXFNJNI materialNode);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void AfterMaterialExportDelegate(GLTFSceneExporter exporter, FZUMGSVMSUT gltfRoot, Material material, WKXGTXFNJNI materialNode);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void BeforeTextureExportDelegate(GLTFSceneExporter exporter, UniqueTexture texture, string textureSlot);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public delegate void AfterTextureExportDelegate(GLTFSceneExporter exporter, UniqueTexture texture, int index, XRKEDLFRQLY tex);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public delegate void AfterPrimitiveExportDelegate(GLTFSceneExporter exporter, Mesh mesh, JRRIGPAJAOY primitive, int index);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public delegate void AfterMeshExportDelegate(GLTFSceneExporter exporter, Mesh mesh, DERQUSIAPDY gltfMesh, int index);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class ULYPKOUGKXO : KHHMAMVATRX
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x9FADBD0", Offset = "0x9FACFD0", VA = "0x189FADBD0", Slot = "5")]
			public override void YVPQFSMLYHM(GLTFSceneExporter a, FZUMGSVMSUT b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x9FADB50", Offset = "0x9FACF50", VA = "0x189FADB50", Slot = "4")]
			public override void PXEIMKWKIRL(GLTFSceneExporter a, FZUMGSVMSUT b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x9FADAB0", Offset = "0x9FACEB0", VA = "0x189FADAB0", Slot = "8")]
			public override void OAMIIQWBWOK(GLTFSceneExporter a, FZUMGSVMSUT b, Transform c, CFDTQFFCTZU d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x9FAD8B0", Offset = "0x9FACCB0", VA = "0x189FAD8B0", Slot = "9")]
			public override bool CNJGQHSQJZU(GLTFSceneExporter a, FZUMGSVMSUT b, Material c, WKXGTXFNJNI d)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x9FADA10", Offset = "0x9FACE10", VA = "0x189FADA10", Slot = "10")]
			public override void GDBMTTLOZLJ(GLTFSceneExporter a, FZUMGSVMSUT b, Material c, WKXGTXFNJNI d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
			public ULYPKOUGKXO()
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
			[Cpp2IlInjected.Address(RVA = "0x9FA8730", Offset = "0x9FA7B30", VA = "0x189FA8730")]
			public TextureExportSettings(TextureExportSettings source)
			{
			}

			[SpecialName]
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x9FA86F0", Offset = "0x9FA7AF0", VA = "0x189FA86F0")]
			public static bool ZWISVWGZSLY(TextureExportSettings a, TextureExportSettings b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x9FA8510", Offset = "0x9FA7910", VA = "0x189FA8510")]
			public bool Equals(TextureExportSettings other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x9FA8460", Offset = "0x9FA7860", VA = "0x189FA8460", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x9FA85F0", Offset = "0x9FA79F0", VA = "0x189FA85F0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x9FAE960", Offset = "0x9FADD60", VA = "0x189FAE960")]
			public int ZNLAHGIELLM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x9FAE920", Offset = "0x9FADD20", VA = "0x189FAE920")]
			public int PEJFXBZESBX()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x9FAEA30", Offset = "0x9FADE30", VA = "0x189FAEA30")]
			public UniqueTexture(Texture tex, string textureSlot, GLTFSceneExporter exporter)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x9FAE9A0", Offset = "0x9FADDA0", VA = "0x189FAE9A0")]
			public UniqueTexture(Texture tex, TextureExportSettings exportSettings)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x9FAE6C0", Offset = "0x9FADAC0", VA = "0x189FAE6C0", Slot = "4")]
			public bool Equals(UniqueTexture other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x9FAE610", Offset = "0x9FADA10", VA = "0x189FAE610", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x9FAE880", Offset = "0x9FADC80", VA = "0x189FAE880", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x9FAE2D0", Offset = "0x9FAD6D0", VA = "0x189FAE2D0")]
			public bool Equals(UniquePrimitive other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x9FAE420", Offset = "0x9FAD820", VA = "0x189FAE420", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x9FAE4C0", Offset = "0x9FAD8C0", VA = "0x189FAE4C0", Slot = "2")]
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
			public ZIHJPSCCEDS aPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public ZIHJPSCCEDS aNormal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public ZIHJPSCCEDS aTangent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public ZIHJPSCCEDS aTexcoord0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public ZIHJPSCCEDS aTexcoord1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public ZIHJPSCCEDS aTexcoord2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public ZIHJPSCCEDS aColor0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public ZIHJPSCCEDS aJoints0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public ZIHJPSCCEDS aWeights0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public Dictionary<int, JRRIGPAJAOY> subMeshPrimitives;
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private struct BlendShapeAccessors
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public List<Dictionary<string, ZIHJPSCCEDS>> targets;

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
			public bool ZMXKPWYFCDR
			{
				[Cpp2IlInjected.Token(Token = "0x60000C7")]
				[Cpp2IlInjected.Address(RVA = "0xBB8560", Offset = "0xBB7960", VA = "0x180BB8560")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public bool KTUUIDFXKWW
			{
				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x72DFE80", Offset = "0x72DF280", VA = "0x1872DFE80")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x9FA83D0", Offset = "0x9FA77D0", VA = "0x189FA83D0")]
			public SamplerRelevantTextureData(Texture texture)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x9FA8320", Offset = "0x9FA7720", VA = "0x189FA8320", Slot = "4")]
			public bool Equals(SamplerRelevantTextureData other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x9FA8260", Offset = "0x9FA7660", VA = "0x189FA8260", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x9FA8350", Offset = "0x9FA7750", VA = "0x189FA8350", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class CRCKWDIATNK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public bool HRJJKJKFYNG;

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public CRCKWDIATNK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x9F999D0", Offset = "0x9F98DD0", VA = "0x189F999D0")]
			internal Color ZGDEFHOXVIZ(object a)
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class CRHRTKBYCYT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public float QCJTWLRZNVT;

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public CRHRTKBYCYT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x9F99AC0", Offset = "0x9F98EC0", VA = "0x189F99AC0")]
			internal float ZFXXIAVALXQ(object a)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class UVRZIOGECOD : IEnumerable<(int, JRRIGPAJAOY)>, IEnumerable, IEnumerator<(int, JRRIGPAJAOY)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private int JIPOOQUWCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private (int subMeshIndex, JRRIGPAJAOY prim) JOTWNIKQVJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private int PLMFUAHXCWL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public GLTFSceneExporter MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private Mesh FQBRAHPLIZV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public Mesh XVIEOMSIUXM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private Dictionary<int, JRRIGPAJAOY>.Enumerator BPMZBLFMONE;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private (int, JRRIGPAJAOY) PJVIRJHFYFC
			{
				[Cpp2IlInjected.Token(Token = "0x60000E5")]
				[Cpp2IlInjected.Address(RVA = "0xC66740", Offset = "0xC65B40", VA = "0x180C66740", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((int, JRRIGPAJAOY));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0x9FAE230", Offset = "0x9FAD630", VA = "0x189FAE230", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x19C1760", Offset = "0x19C0B60", VA = "0x1819C1760")]
			[DebuggerHidden]
			public UVRZIOGECOD(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x9FADDE0", Offset = "0x9FAD1E0", VA = "0x189FADDE0", Slot = "7")]
			[DebuggerHidden]
			private void AEBWHPMOWJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x9FADF60", Offset = "0x9FAD360", VA = "0x189FADF60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x9FAE280", Offset = "0x9FAD680", VA = "0x189FAE280")]
			private void RYZDNTQONZF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x9FADF20", Offset = "0x9FAD320", VA = "0x189FADF20", Slot = "10")]
			[DebuggerHidden]
			private void MJTKPUASZVA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x9FADE70", Offset = "0x9FAD270", VA = "0x189FADE70", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(int, JRRIGPAJAOY)> FBWZDTBMQQT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x9FADE70", Offset = "0x9FAD270", VA = "0x189FADE70", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator CQMSCGRISCD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static ILogger TSHIAIKNEOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private List<KHHMAMVATRX> HTZEUHELCDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private Transform[] KPRYLSLFUHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private FZUMGSVMSUT YRXDBKRTGHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private HGPMTRNOTAJ UAYHJJCHMVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private SHEUFKKLCGJ IIIBOADOUUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private List<ImageInfo> ZQZTHPPNQVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private HashSet<string> FOLTWYWURIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private List<FileInfo> XPODQSGTJTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private HashSet<string> KJHHZXBKGOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private List<UniqueTexture> RTVAWLMGDBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private Dictionary<int, int> GTGDQGBXNXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private bool NVXBLDMABJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private Dictionary<int, int> EQVQUDTWJPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private List<Transform> GOARWDQLVXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private int ZSEJHBQCCHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private NKLWKJFHFKH WRWMSCRHSZW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private Material SRKRBCQMZCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private Material ILXMRSKQMZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private Material SHHGMWQWNCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private bool JCTMQFDCVGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly Dictionary<UniquePrimitive, HXARMPGUANY> IJRQJIBTZTQ;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static ProfilerMarker VNYYVOUJHFR;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static ProfilerMarker PHDNAMSZRNN;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static ProfilerMarker RTGMJQPCMIL;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static ProfilerMarker HAYGNTZBVCP;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static ProfilerMarker SYIJAKBGSCO;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static ProfilerMarker OYOXDLVJSGT;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static ProfilerMarker HNJKPPNACAR;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static ProfilerMarker NGCMPWGEALX;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static ProfilerMarker RVSTBAJOISG;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static ProfilerMarker AASTXCQBMIU;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static ProfilerMarker KZPFKAWNOPS;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static ProfilerMarker ZNFJGIGXGVD;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static ProfilerMarker OJCTYWNHAJV;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static ProfilerMarker ITTOPAAPXEK;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static ProfilerMarker BPSJCKTMNAU;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static ProfilerMarker NIDBONTTERN;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static ProfilerMarker FYPPOWXYAJP;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static ProfilerMarker VULYPKYLKVO;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static ProfilerMarker MNJILYCVNUM;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static ProfilerMarker YUDFSIMZAVX;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static ProfilerMarker GYJAIZHBSCF;

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static ProfilerMarker JMUZLSIDJIH;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private static ProfilerMarker TEIQBEBTXHQ;

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private static ProfilerMarker UFBXBZEBFBL;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private static ProfilerMarker ETUGXFWCOGE;

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private static ProfilerMarker ZYHURQMANKF;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static ProfilerMarker UPIZOOARPNO;

		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private static ProfilerMarker VYCAWUEZRCD;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static ProfilerMarker HNUHWIVWYWS;

		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private static ProfilerMarker JPOTVSLFAFG;

		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private static ProfilerMarker GVUMHLVTSKX;

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private static ProfilerMarker WECXQHTVFJE;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private static ProfilerMarker LICVKFRBPMF;

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private static ProfilerMarker QUGUVDCAOOI;

		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private static ProfilerMarker EGWRJAHIQKK;

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private static ProfilerMarker BFFJKIECZZL;

		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private static ProfilerMarker XZANGGNGZYD;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private static ProfilerMarker AJVRLENXVLY;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static ProfilerMarker BNRDCIMMBMJ;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private static ProfilerMarker DTPVUWWLUYG;

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private static ProfilerMarker NEBBUUDTEQX;

		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private static ProfilerMarker QKNBYMPXOQN;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private static ProfilerMarker ZVAUCIKTSRR;

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static ProfilerMarker XCWGUCVQEYW;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static ProfilerMarker EPJVHQORKFN;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static ProfilerMarker GYMTXYQSYBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private UnityGLTF.BinaryWriterWithLessAllocations QMIOIINFXUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private bool? SRTSOSTULTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		internal readonly List<RRYCSCAUSGO> XBOPVCKGQPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly FNIBNPHGBPL SGBAMBFAZPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private Dictionary<int, int> AMGWTAXDGFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private Dictionary<int, int> OODUCQUGRZH;

		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[CompilerGenerated]
		private static BeforeSceneExportDelegate PXEIMKWKIRL;

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[CompilerGenerated]
		private static AfterSceneExportDelegate YVPQFSMLYHM;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[CompilerGenerated]
		private static AfterNodeExportDelegate OAMIIQWBWOK;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[CompilerGenerated]
		private static BeforeMaterialExportDelegate CNJGQHSQJZU;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[CompilerGenerated]
		private static AfterMaterialExportDelegate GDBMTTLOZLJ;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static Material JFLTUMYRKIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private HashSet<Material> LHROTIWBQLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly Dictionary<Mesh, MeshAccessors> AXPCJMUCIKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly Dictionary<Mesh, BlendShapeAccessors> FRDDSWXFFYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly Dictionary<SkinnedMeshRenderer, List<double>> NODNTLCRZPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private List<Transform> WBQBZJGMTWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private Dictionary<SkinnedMeshRenderer, Mesh> IZCFXKJYKHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private Dictionary<SamplerRelevantTextureData, int> AJLAKEWHFYX;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public IReadOnlyList<Transform> OJGXGPTWXKT
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private GLTFSettings NJRVEUBYIBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x9F934B0", Offset = "0x9F928B0", VA = "0x189F934B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private bool JCKANUFISUE
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x9F928A0", Offset = "0x9F91CA0", VA = "0x189F928A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private bool KVMJTNPBTJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x9F87410", Offset = "0x9F86810", VA = "0x189F87410")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private bool GOKJUDKCYKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9F81D70", Offset = "0x9F81170", VA = "0x189F81D70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static Material AQYCPYEZNIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9F96A10", Offset = "0x9F95E10", VA = "0x189F96A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9F81A70", Offset = "0x9F80E70", VA = "0x189F81A70")]
		public TextureExportSettings GPFBQKNYAJS(string a)
		{
			return default(TextureExportSettings);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9F7E2B0", Offset = "0x9F7D6B0", VA = "0x189F7E2B0")]
		private Material BGLZHWVVOTR(TextureExportSettings a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9F93E70", Offset = "0x9F93270", VA = "0x189F93E70")]
		private static Material UZNWWGNNCLI(Material a, TextureExportSettings b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9F97930", Offset = "0x9F96D30", VA = "0x189F97930")]
		public GLTFSceneExporter(Transform[] rootTransforms, NKLWKJFHFKH context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9F8A9B0", Offset = "0x9F89DB0", VA = "0x189F8A9B0")]
		public void MKVUEACRRPZ(Stream a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9F81860", Offset = "0x9F80C60", VA = "0x189F81860")]
		public void GKPMJHSUHPW(string a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9F8E0E0", Offset = "0x9F8D4E0", VA = "0x189F8E0E0")]
		private bool PICQPPSAPHH(Transform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9F7E410", Offset = "0x9F7D810", VA = "0x189F7E410")]
		private RNZJRTZBRDZ CEVJPVYLPHS(string a, Transform[] b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9F8D080", Offset = "0x9F8C480", VA = "0x189F8D080")]
		private GDEBWNCDUBF PFFROYPGDNC(Transform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9F826D0", Offset = "0x9F81AD0", VA = "0x189F826D0")]
		private static bool IUGUYIAQIUQ(GameObject a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9F8A730", Offset = "0x9F89B30", VA = "0x189F8A730")]
		private void MDEZCKQVCRE(Transform a, [Out] GameObject[] b, [Out] GameObject[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9F81EF0", Offset = "0x9F812F0", VA = "0x189F81EF0")]
		private void HKPPIBZPBLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9F93D20", Offset = "0x9F93120", VA = "0x189F93D20")]
		public AOGCDBYZIFE UKBHSXTJCNQ(FZUMGSVMSUT a, Material b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9F8C8C0", Offset = "0x9F8BCC0", VA = "0x189F8C8C0")]
		public SNZWXCMIXSE NHHQKZEXTAE(FZUMGSVMSUT a, UniqueTexture b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9F941A0", Offset = "0x9F935A0", VA = "0x189F941A0")]
		public OEAGHAUWJNY VXHMFFHCCNY(FZUMGSVMSUT a, Texture b, TextureExportSettings c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9F86D20", Offset = "0x9F86120", VA = "0x189F86D20")]
		private static void KCXIZDUOXEH(Stream a, BinaryWriter b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9F7E890", Offset = "0x9F7DC90", VA = "0x189F7E890")]
		private static void CFAPDJOEUHK(Stream a, byte b = 32, uint c = 4u)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9F92C00", Offset = "0x9F92000", VA = "0x189F92C00")]
		public static uint SGZYFUYJZUX(uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9F95800", Offset = "0x9F94C00", VA = "0x189F95800")]
		private ZIHJPSCCEDS XSQPUTNBJOT(Vector4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9F7F660", Offset = "0x9F7EA60", VA = "0x189F7F660")]
		private ZIHJPSCCEDS EFQJSATXSIM(Quaternion[] a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9F86130", Offset = "0x9F85530", VA = "0x189F86130")]
		private ZIHJPSCCEDS JROADSQVQFZ(Matrix4x4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9F854C0", Offset = "0x9F848C0", VA = "0x189F854C0")]
		private ZIHJPSCCEDS JROADSQVQFZ(float[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9F865D0", Offset = "0x9F859D0", VA = "0x189F865D0")]
		private ZIHJPSCCEDS JROADSQVQFZ(int[] a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9F84530", Offset = "0x9F83930", VA = "0x189F84530")]
		private ZIHJPSCCEDS JROADSQVQFZ(Vector2[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9F859F0", Offset = "0x9F84DF0", VA = "0x189F859F0")]
		private ZIHJPSCCEDS JROADSQVQFZ(Vector3[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9F82940", Offset = "0x9F81D40", VA = "0x189F82940")]
		private ZIHJPSCCEDS JDASAETBHEP(ZIHJPSCCEDS a, Vector3[] b, Vector3[] c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9F84BC0", Offset = "0x9F83FC0", VA = "0x189F84BC0")]
		private ZIHJPSCCEDS JROADSQVQFZ(Vector4[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9F83980", Offset = "0x9F82D80", VA = "0x189F83980")]
		private ZIHJPSCCEDS JROADSQVQFZ(Color[] a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9F8FEC0", Offset = "0x9F8F2C0", VA = "0x189F8FEC0")]
		private AUBFOGSNMLW QKZATLPJPRR(uint a, uint b, uint c = 0u)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public void KXLUBQVJOYC(Transform a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9F86DF0", Offset = "0x9F861F0", VA = "0x189F86DF0")]
		internal int KLGACHUARFY(object a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9F95440", Offset = "0x9F94840", VA = "0x189F95440")]
		public int WNNFURQNGSS(Transform a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9F95500", Offset = "0x9F94900", VA = "0x189F95500")]
		public int WOSPPTULKEN(Material a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9F8CA50", Offset = "0x9F8BE50", VA = "0x189F8CA50")]
		public int NUULKDPEKUS(Light a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9F927E0", Offset = "0x9F91BE0", VA = "0x189F927E0")]
		public int QUTOYJPWGCD(Camera a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9F94110", Offset = "0x9F93510", VA = "0x189F94110")]
		[IteratorStateMachine(typeof(UVRZIOGECOD))]
		public IEnumerable<(int, JRRIGPAJAOY)> VJPPCLVMEIW(Mesh a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9F928D0", Offset = "0x9F91CD0", VA = "0x189F928D0")]
		private static void RUCYOTXGAJF(Color a, [Out] Color b, [Out] float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9F96DE0", Offset = "0x9F961E0", VA = "0x189F96DE0")]
		private static void ZUTUJRCTEVS(Vector4 a, [Out] Vector2 b, [Out] Vector2 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9F96100", Offset = "0x9F95500", VA = "0x189F96100")]
		private bool XWWPGKDMLNX(object[] a, int b, int c, int d, int e, int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9F7ED20", Offset = "0x9F7E120", VA = "0x189F7ED20")]
		public void CREVWKMWQPX(float[] a, object[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9F87ED0", Offset = "0x9F872D0", VA = "0x189F87ED0")]
		public void MBGBQIVOPWN(UnityEngine.Object a, string b, PTLIBJBFTSP c, float[] d, object[] e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9F81290", Offset = "0x9F80690", VA = "0x189F81290")]
		private void FOWKGZKIRZN(object a, string b, RXJYREPLVAW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9F8CB80", Offset = "0x9F8BF80", VA = "0x189F8CB80")]
		private IWYNEKCFAPK PCNAWLPHDZF(Camera a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9F7DB20", Offset = "0x9F7CF20", VA = "0x189F7DB20")]
		private BXYDSMGQXTF BDFKWISNXSQ(Light a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9F90270", Offset = "0x9F8F670", VA = "0x189F90270")]
		public AOGCDBYZIFE QOIVMGMXJPL(Material a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9F934D0", Offset = "0x9F928D0", VA = "0x189F934D0")]
		private AOGCDBYZIFE TKJXJVFJZMK(Material a, WKXGTXFNJNI b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9F81610", Offset = "0x9F80A10", VA = "0x189F81610")]
		private bool FULQMQJSXWX(Material a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9F8F470", Offset = "0x9F8E870", VA = "0x189F8F470")]
		private bool QKPZGFDMSIS(Material a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9F8CB10", Offset = "0x9F8BF10", VA = "0x189F8CB10")]
		private bool OWMHPFLIJLP(Material a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x9F87E30", Offset = "0x9F87230", VA = "0x189F87E30")]
		private bool LLWYNZONTAL(Material a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9F956D0", Offset = "0x9F94AD0", VA = "0x189F956D0")]
		private static bool XHXHZKVJQJQ(Shader a, string b, ShaderPropertyType c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9F87440", Offset = "0x9F86840", VA = "0x189F87440")]
		private void LGJOJAVSRSJ(GQTAFWBMEER a, Material b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9F8E310", Offset = "0x9F8D710", VA = "0x189F8E310")]
		public HXDZCZNDUHS PWPSLQNTAHY(Texture a, string b, Material c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9F92AA0", Offset = "0x9F91EA0", VA = "0x189F92AA0")]
		private IXMOGGFTQGG SEITMLQSCVW(Texture a, string b, Material c, [Optional] SNZWXCMIXSE d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9F8E500", Offset = "0x9F8D900", VA = "0x189F8E500")]
		public HOITQIKWFGL PYKLNFTSLSN(Material a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9F937F0", Offset = "0x9F92BF0", VA = "0x189F937F0")]
		public void TWNCQDEJTAQ(WKXGTXFNJNI a, Material b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9F81F80", Offset = "0x9F81380", VA = "0x189F81F80")]
		private void HZKWQBUVPLF(WKXGTXFNJNI a, Material b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9F7E960", Offset = "0x9F7DD60", VA = "0x189F7E960")]
		private NXOKLBUFARA CQXFSADKLHT(Material a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9F817D0", Offset = "0x9F80BD0", VA = "0x189F817D0")]
		internal static void GGDXLQVIBGN(Color a, [Out] Color b, [Out] float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9F80090", Offset = "0x9F7F490", VA = "0x189F80090")]
		public void ENPXKLAIQAJ(CFDTQFFCTZU a, List<UniquePrimitive> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9F96290", Offset = "0x9F95690", VA = "0x189F96290")]
		private static List<UniquePrimitive> YQDWVLUIJQD(IEnumerable<GameObject> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x9F8E0A0", Offset = "0x9F8D4A0", VA = "0x189F8E0A0")]
		public GDEBWNCDUBF PFFROYPGDNC(GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9F92C20", Offset = "0x9F92020", VA = "0x189F92C20")]
		public HXARMPGUANY SHFGTPQXKKF(string a, List<UniquePrimitive> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x9F7C5D0", Offset = "0x9F7B9D0", VA = "0x189F7C5D0")]
		private JRRIGPAJAOY[] AWXRHEDLCEF(UniquePrimitive a, DERQUSIAPDY b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x9F96C40", Offset = "0x9F96040", VA = "0x189F96C40")]
		private List<double> ZODIERIQNRN(SkinnedMeshRenderer a, Mesh b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9F8BE80", Offset = "0x9F8B280", VA = "0x189F8BE80")]
		private void MWVBODJZXKB(SkinnedMeshRenderer a, Mesh b, int c, JRRIGPAJAOY d, DERQUSIAPDY e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9F87140", Offset = "0x9F86540", VA = "0x189F87140")]
		private static bool KOVJINGFYTK(JRRIGPAJAOY a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x9F806C0", Offset = "0x9F7FAC0", VA = "0x189F806C0")]
		private static DrawMode EWGDWCDJHGH(MeshTopology a)
		{
			return default(DrawMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9F81120", Offset = "0x9F80520", VA = "0x189F81120")]
		private static bool EZFIJFMYWVB(Mesh a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9F94370", Offset = "0x9F93770", VA = "0x189F94370")]
		private void WHWJGMJTNTT(Transform a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9F813E0", Offset = "0x9F807E0", VA = "0x189F813E0")]
		private Mesh FQWHLDDFOFI(GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9F7DA20", Offset = "0x9F7CE20", VA = "0x189F7DA20")]
		private Material[] BCEDQNLRHAB(GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9F93320", Offset = "0x9F92720", VA = "0x189F93320")]
		private Vector4[] SMLZSPQUUGN(BoneWeight[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9F81140", Offset = "0x9F80540", VA = "0x189F81140")]
		private Vector4[] FGLVPFFCTFF(BoneWeight[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9F90050", Offset = "0x9F8F450", VA = "0x189F90050")]
		private string QLEDMPHLSCS(HashSet<string> a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9F955C0", Offset = "0x9F949C0", VA = "0x189F955C0")]
		public GQTAFWBMEER WYVJDBWXKPF(Texture a, string b, [Optional] TextureExportSettings c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9F7F570", Offset = "0x9F7E970", VA = "0x189F7F570")]
		public GQTAFWBMEER DJIXJTFKWJI(Material a, Texture b, string c, [Optional] TextureExportSettings d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9F8F530", Offset = "0x9F8E930", VA = "0x189F8F530")]
		public SNZWXCMIXSE QKWKPDPJJBJ(Texture a, string b, [Optional] TextureExportSettings c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x9F87160", Offset = "0x9F86560", VA = "0x189F87160")]
		private string KPJCKDVWZAN(Texture a, TextureExportSettings b, string c, [Out] bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9F807C0", Offset = "0x9F7FBC0", VA = "0x189F807C0")]
		private OEAGHAUWJNY EWZXZWSDIMB(UniqueTexture a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x47545C0", Offset = "0x47539C0", VA = "0x1847545C0")]
		private bool HZMTTGFGUZE(TextureExportSettings a, Texture b, [Out] string c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920")]
		private byte[] YMPGGRYGWCQ(Texture a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x9F95770", Offset = "0x9F94B70", VA = "0x189F95770")]
		private bool XPVGTCRXQSE(Texture a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x9F7E390", Offset = "0x9F7D790", VA = "0x189F7E390")]
		private bool BIULMGBPHRP(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9F8E240", Offset = "0x9F8D640", VA = "0x189F8E240")]
		private bool PURGENCBUEQ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9F8B2C0", Offset = "0x9F8A6C0", VA = "0x189F8B2C0")]
		private OEAGHAUWJNY MTFAOKVDCPY(UniqueTexture a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9F80200", Offset = "0x9F7F600", VA = "0x189F80200")]
		private TVGWPUDKMGL EUTEEFNMAQE(Texture a)
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
	public class YCKHOEPLNAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public QYHPHOAMODM LXMGNUXBTGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public MYLULKZASJQ RGOPNVJSUTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public AsyncCoroutineHelper AQFZXDVLGCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public bool HZUCJGBOJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public AnimationMethod XQSSVKLBCMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public bool ESLEXNTONJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public DeduplicateOptions XXBXOAAFYNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public bool DWKMCXBLGUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public GLTFImporterNormals MNOLXIERQSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public GLTFImporterNormals GHGMXAWVWVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public bool NHXNMQWDVLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public CameraImportOption OAWQWBICXNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public RuntimeTextureCompression DLTXJHKQENX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public BlendShapeFrameWeightSetting UZJZFIAHRPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public NEFZNIVNFTP UVRSICMQVKC;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public ILogger HTJZWUEHBYW;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9FAEBA0", Offset = "0x9FADFA0", VA = "0x189FAEBA0")]
		public YCKHOEPLNAL()
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
		public float RGAIMYLSJBT
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x9FA79B0", Offset = "0x9FA6DB0", VA = "0x189FA79B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x9FA79E0", Offset = "0x9FA6DE0", VA = "0x189FA79E0", Slot = "3")]
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
		private class QZPTVWGYTQF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Texture WAUEOSCTHAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public int NZUUEVBHGCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public double XMNPLOZLNVD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Vector2 TSALMPZNIUJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public double GYPOFJPFDYQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Vector2 UATJXLHWCDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public int? YQZTKETRVOO;

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x9FA8080", Offset = "0x9FA7480", VA = "0x189FA8080")]
			public QZPTVWGYTQF()
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
			public AsyncTaskMethodBuilder<WCFAQEMIIMZ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public ZIHJPSCCEDS accessorId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public bool isPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			private DPGOAWAAUSB <accessor>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			private TaskAwaiter<VKHNVDPDWUK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x9FAB690", Offset = "0x9FAAA90", VA = "0x189FAB690", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x9FABBA0", Offset = "0x9FAAFA0", VA = "0x189FABBA0", Slot = "5")]
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
			public PTLIBJBFTSP animation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			public YBXZZMCYPGO animationCache;
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class EKJGRDPHPLD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public OSDKPJWNUNL SMZKTYQSAXJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			public ValuesConvertion GSPESOSWWJT;

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public EKJGRDPHPLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x9F99F50", Offset = "0x9F99350", VA = "0x189F99F50")]
			internal float[] GEHLWGQBRJZ(NumericArray a, int b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class EJTLZJHPNDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public bool WOEZLEWNLZZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			public int ULAKPJTNYXI;

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public EJTLZJHPNDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x9F99BE0", Offset = "0x9F98FE0", VA = "0x189F99BE0")]
			internal float[] GFNBFVFLWAB(NumericArray a, int b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class EJYSWQBMWOL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			public float[] XSTIEXXTLVC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			public BlendShapeFrameWeightSetting YCVDVBBMTCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			public EJTLZJHPNDC AAFJFKGKTGT;

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public EJYSWQBMWOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x9F99E80", Offset = "0x9F99280", VA = "0x189F99E80")]
			internal float[] JIKLUSLVKZI(NumericArray a, int b)
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
			public XCWKPVCUDXR mapper;
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class ITQHVKWVKND
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
				public ITQHVKWVKND <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400016A")]
				private WKXGTXFNJNI <def>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400016B")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000177")]
				[Cpp2IlInjected.Address(RVA = "0x9FABC10", Offset = "0x9FAB010", VA = "0x189FABC10", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000178")]
				[Cpp2IlInjected.Address(RVA = "0x9FAC030", Offset = "0x9FAB430", VA = "0x189FAC030", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public int BWAJOBVRUPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public GLTFSceneImporter MXVWDMPVVWS;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public ITQHVKWVKND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x9FA78E0", Offset = "0x9FA6CE0", VA = "0x189FA78E0")]
			[AsyncStateMachine(typeof(<<LoadMaterialAsync>b__0>d))]
			internal Task MTDQAPVGXMZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private sealed class EAELPGFHEOM
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
				public EAELPGFHEOM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000172")]
				private DERQUSIAPDY <def>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000173")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600017B")]
				[Cpp2IlInjected.Address(RVA = "0x9FAC090", Offset = "0x9FAB490", VA = "0x189FAC090", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600017C")]
				[Cpp2IlInjected.Address(RVA = "0x9FAC640", Offset = "0x9FABA40", VA = "0x189FAC640", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public int VIIBLECMIUF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public GLTFSceneImporter MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public CancellationToken UJYJWIIBMHU;

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public EAELPGFHEOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x9F99B10", Offset = "0x9F98F10", VA = "0x189F99B10")]
			[AsyncStateMachine(typeof(<<LoadMeshAsync>b__0>d))]
			internal Task BEATTQCAWZP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class ANYJVXQWQWP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public GLTFSceneImporter MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public NBTPTIGRVVC TCNHXAIGMWF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public string VHAHWIFSYEN;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public ANYJVXQWQWP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x9F99370", Offset = "0x9F98770", VA = "0x189F99370")]
			internal Stream FOCZNJIWHOS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x9F99460", Offset = "0x9F98860", VA = "0x189F99460")]
			internal void FOIGKQCTRAB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class UTMAQKCDRHN
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
				public UTMAQKCDRHN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				public bool onlyMesh;

				[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
				[Cpp2IlInjected.Token(Token = "0x4000180")]
				public bool ignoreMesh;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000181")]
				private List<GDEBWNCDUBF>.Enumerator <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000182")]
				private TaskAwaiter<GameObject> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000183")]
				private DERQUSIAPDY <mesh>5__3;

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
				[Cpp2IlInjected.Address(RVA = "0x9FA99B0", Offset = "0x9FA8DB0", VA = "0x189FA99B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000184")]
				[Cpp2IlInjected.Address(RVA = "0x9FAB630", Offset = "0x9FAAA30", VA = "0x189FAB630", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public GameObject TOZIJJOBXOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public CFDTQFFCTZU QMXJVPYWNHQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public GLTFSceneImporter MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public CancellationToken UJYJWIIBMHU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public int RGLVADZASGK;

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public UTMAQKCDRHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x9FADCC0", Offset = "0x9FAD0C0", VA = "0x189FADCC0")]
			[AsyncStateMachine(typeof(<<ConstructNode>g__CreateNodeComponentsAndChilds|0>d))]
			internal Task OAILCUQUPQM(bool a = false, bool b = false)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x9FADC50", Offset = "0x9FAD050", VA = "0x189FADC50")]
			internal Material JNWNPUNVJNS(JRRIGPAJAOY a)
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
			public PTLIBJBFTSP animation;

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
			private Dictionary<string, List<WCFAQEMIIMZ>> <samplersByType>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			private int <i>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			private KANTXWFPHCU <samplerDef>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			private TaskAwaiter<VKHNVDPDWUK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x9FAEC80", Offset = "0x9FAE080", VA = "0x189FAEC80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x9FAF930", Offset = "0x9FAED30", VA = "0x189FAF930", Slot = "5")]
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
			public HWSSUNICCRC image;

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
			[Cpp2IlInjected.Address(RVA = "0x9FAF990", Offset = "0x9FAED90", VA = "0x189FAF990", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x9FB0160", Offset = "0x9FAF560", VA = "0x189FB0160", Slot = "5")]
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
			public SHEUFKKLCGJ buffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			private TaskAwaiter<Stream> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x9FB07E0", Offset = "0x9FAFBE0", VA = "0x189FB07E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x9FB0F60", Offset = "0x9FB0360", VA = "0x189FB0F60", Slot = "5")]
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
			public CFDTQFFCTZU node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			private List<GDEBWNCDUBF>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x9FB01D0", Offset = "0x9FAF5D0", VA = "0x189FB01D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x9FB0780", Offset = "0x9FAFB80", VA = "0x189FB0780", Slot = "5")]
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
			private EKJGRDPHPLD <>8__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			private AnimationClip <clip>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			private int[] <nodeIds>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			private BLUQDNUIDET <pointerImportContext>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			private List<JUFJRVKRBML>.Enumerator <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			private JUFJRVKRBML <channel>5__6;

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
			[Cpp2IlInjected.Address(RVA = "0x9FB0FC0", Offset = "0x9FB03C0", VA = "0x189FB0FC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x9FB4570", Offset = "0x9FB3970", VA = "0x189FB4570", Slot = "5")]
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
			public HWSSUNICCRC image;

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
			[Cpp2IlInjected.Address(RVA = "0x9FB4CE0", Offset = "0x9FB40E0", VA = "0x189FB4CE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x9FB5090", Offset = "0x9FB4490", VA = "0x189FB5090", Slot = "5")]
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
			public XRKEDLFRQLY texture;

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
			[Cpp2IlInjected.Address(RVA = "0x9FB45E0", Offset = "0x9FB39E0", VA = "0x189FB45E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x9FB4C80", Offset = "0x9FB4080", VA = "0x189FB4C80", Slot = "5")]
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
			public CFDTQFFCTZU node;

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
			private QCSEZVJOTMF <lodsExtension>5__2;

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
			[Cpp2IlInjected.Address(RVA = "0x9FB50F0", Offset = "0x9FB44F0", VA = "0x189FB50F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x9FB5CA0", Offset = "0x9FB50A0", VA = "0x189FB5CA0", Slot = "5")]
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
			public WKXGTXFNJNI def;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			private <>c__DisplayClass119_0 <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			public int materialIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			private MRGSQSRILXF <mrMapper>5__2;

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
			private BLHWOZUEHFM <sgMapper>5__12;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			private OWJJGYBXMNL <unlitMapper>5__13;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			private RZNUULKKPCQ <sheenMapper>5__14;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			private WYOBAPGIYZP <anisotropyMapper>5__15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			private CTTAZLKMCIJ <transmissionMapper>5__16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			private ENUNDHZLWIP <volumeMapper>5__17;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			private WNMCDZBAHYX <iridescenceMapper>5__18;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			private LESSVSFUXSG <specularMapper>5__19;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			private FBFSTDKYMIN <clearcoatMapper>5__20;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			private DOYINZTHIZO <uniformMapper>5__21;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			private HOITQIKWFGL <pbr>5__22;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			private SNZWXCMIXSE <textureId>5__23;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			private JUONWFCJJIB <specGloss>5__24;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			private KHR_materials_sheen <sheen>5__25;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			private TaskAwaiter<QZPTVWGYTQF> <>u__2;

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
			private NJVIGLESUOM <clearcoatNormalMapper>5__32;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x9FB5D00", Offset = "0x9FB5100", VA = "0x189FB5D00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x9FBD9D0", Offset = "0x9FBCDD0", VA = "0x189FBD9D0", Slot = "5")]
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
			public DERQUSIAPDY mesh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			private ZGBHUJWMFFN <meshCache>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			private ZOWJCSGELOO <unityData>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400020E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			private int <i>5__4;

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x9FBF180", Offset = "0x9FBE580", VA = "0x189FBF180", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x9FBFBB0", Offset = "0x9FBEFB0", VA = "0x189FBFBB0", Slot = "5")]
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
			public HXARMPGUANY meshId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public DERQUSIAPDY mesh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000215")]
			private int <meshIndex>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			private int <i>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000217")]
			private JRRIGPAJAOY <primitive>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x9FBDA30", Offset = "0x9FBCE30", VA = "0x189FBDA30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x9FBE070", Offset = "0x9FBD470", VA = "0x189FBE070", Slot = "5")]
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
			public JRRIGPAJAOY primitive;

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
			private List<Dictionary<string, WCFAQEMIIMZ>> <newTargets>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			private int <i>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			private Dictionary<string, ZIHJPSCCEDS>.Enumerator <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000222")]
			private KeyValuePair<string, ZIHJPSCCEDS> <targetAttribute>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000223")]
			private int <bufferID>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000224")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			private TaskAwaiter<VKHNVDPDWUK> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x9FBE0D0", Offset = "0x9FBD4D0", VA = "0x189FBE0D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x9FBF120", Offset = "0x9FBE520", VA = "0x189FBF120", Slot = "5")]
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
			public CFDTQFFCTZU node;

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
			private UTMAQKCDRHN <>8__1;

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
			[Cpp2IlInjected.Address(RVA = "0x9FBFC10", Offset = "0x9FBF010", VA = "0x189FBFC10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x9FC0D20", Offset = "0x9FC0120", VA = "0x189FC0D20", Slot = "5")]
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
			public JRRIGPAJAOY primitive;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000239")]
			private ZGBHUJWMFFN.AIHVYAIFZVR <primData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400023A")]
			private Dictionary<string, ZIHJPSCCEDS>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400023B")]
			private KeyValuePair<string, ZIHJPSCCEDS> <attributePair>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400023C")]
			private XBCTJLLFDTT <sparse>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400023D")]
			private TaskAwaiter<VKHNVDPDWUK> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400023E")]
			private WCFAQEMIIMZ <sparseValues>5__6;

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x9FC79D0", Offset = "0x9FC6DD0", VA = "0x189FC79D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x9FC8B10", Offset = "0x9FC7F10", VA = "0x189FC8B10", Slot = "5")]
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
			public VNYFQYNHQCR scene;

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
			[Cpp2IlInjected.Address(RVA = "0x9FC8B70", Offset = "0x9FC7F70", VA = "0x189FC8B70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x9FC9890", Offset = "0x9FC8C90", VA = "0x189FC9890", Slot = "5")]
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
			public XRKEDLFRQLY texture;

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
			private HWSSUNICCRC <image>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000258")]
			private bool <isFirstInstance>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000259")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x9FC98F0", Offset = "0x9FC8CF0", VA = "0x189FC98F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x9FCAB60", Offset = "0x9FC9F60", VA = "0x189FCAB60", Slot = "5")]
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
			public ZOWJCSGELOO unityMeshData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000260")]
			private Mesh <mesh>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000261")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x9FCABC0", Offset = "0x9FC9FC0", VA = "0x189FCABC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x9FCBCE0", Offset = "0x9FCB0E0", VA = "0x189FCBCE0", Slot = "5")]
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
			public HWSSUNICCRC image;

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
			private VKHNVDPDWUK <bufferView>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400026E")]
			private TaskAwaiter<VKHNVDPDWUK> <>u__1;

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
			[Cpp2IlInjected.Address(RVA = "0x9FCBD40", Offset = "0x9FCB140", VA = "0x189FCBD40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x9FCD830", Offset = "0x9FCCC30", VA = "0x189FCD830", Slot = "5")]
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
			public JRRIGPAJAOY primitive;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000277")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000278")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x9FCDF20", Offset = "0x9FCD320", VA = "0x189FCDF20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x9FCE1C0", Offset = "0x9FCD5C0", VA = "0x189FCE1C0", Slot = "5")]
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
			public DERQUSIAPDY mesh;

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
			[Cpp2IlInjected.Address(RVA = "0x9FCE220", Offset = "0x9FCD620", VA = "0x189FCE220", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x9FCE420", Offset = "0x9FCD820", VA = "0x189FCE420", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9FCE480", Offset = "0x9FCD880", VA = "0x189FCE480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x9FCE900", Offset = "0x9FCDD00", VA = "0x189FCE900", Slot = "5")]
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
			public AsyncTaskMethodBuilder<QZPTVWGYTQF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000286")]
			public GQTAFWBMEER textureInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000287")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000288")]
			public bool isNormal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000289")]
			private QZPTVWGYTQF <result>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400028A")]
			private SNZWXCMIXSE <textureId>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400028B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x9FCE960", Offset = "0x9FCDD60", VA = "0x189FCE960", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x9FCEF20", Offset = "0x9FCE320", VA = "0x189FCEF20", Slot = "5")]
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
			public AsyncTaskMethodBuilder<VKHNVDPDWUK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400028E")]
			public HGPMTRNOTAJ bufferId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400028F")]
			public GLTFSceneImporter <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000290")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x9FCEF90", Offset = "0x9FCE390", VA = "0x189FCEF90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x9FCF220", Offset = "0x9FCE620", VA = "0x189FCF220", Slot = "5")]
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
			public CFDTQFFCTZU node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000295")]
			private WCFAQEMIIMZ <positionsAttr>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000296")]
			private WCFAQEMIIMZ <rotationAttr>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000297")]
			private WCFAQEMIIMZ <scaleAttr>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000298")]
			private EXT_mesh_gpu_instancing <extMeshGPUInstancing>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000299")]
			private int <instancesCount>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400029A")]
			private TaskAwaiter<WCFAQEMIIMZ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x9FCF290", Offset = "0x9FCE690", VA = "0x189FCF290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x9FCFEE0", Offset = "0x9FCF2E0", VA = "0x189FCFEE0", Slot = "5")]
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
			private CFDTQFFCTZU <node>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002A2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002A3")]
			private QCSEZVJOTMF <lodsExtension>5__4;

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
			[Cpp2IlInjected.Address(RVA = "0x9FCFF50", Offset = "0x9FCF350", VA = "0x189FCFF50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x9FD0DE0", Offset = "0x9FD01E0", VA = "0x189FD0DE0", Slot = "5")]
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
			private ANYJVXQWQWP <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002AC")]
			private TaskAwaiter<Stream> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002AD")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x9FD0E50", Offset = "0x9FD0250", VA = "0x189FD0E50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x9FD1590", Offset = "0x9FD0990", VA = "0x189FD1590", Slot = "5")]
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
			private ITQHVKWVKND <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002B3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x9FD15F0", Offset = "0x9FD09F0", VA = "0x189FD15F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x9FD18F0", Offset = "0x9FD0CF0", VA = "0x189FD18F0", Slot = "5")]
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
			private EAELPGFHEOM <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002BA")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x9FD1960", Offset = "0x9FD0D60", VA = "0x189FD1960", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x9FD1C80", Offset = "0x9FD1080", VA = "0x189FD1C80", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9FD1CF0", Offset = "0x9FD10F0", VA = "0x189FD1CF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x9FD2CD0", Offset = "0x9FD20D0", VA = "0x189FD2CD0", Slot = "5")]
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
			private WKXGTXFNJNI <def>5__3;

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x9FD2D30", Offset = "0x9FD2130", VA = "0x189FD2D30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x9FD31A0", Offset = "0x9FD25A0", VA = "0x189FD31A0", Slot = "5")]
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
			private DERQUSIAPDY <gltfMesh>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002D0")]
			private int <i>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002D1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x9FD3200", Offset = "0x9FD2600", VA = "0x189FD3200", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x9FD38A0", Offset = "0x9FD2CA0", VA = "0x189FD38A0", Slot = "5")]
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
			public CRODCQRPSXF skin;

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
			private TaskAwaiter<VKHNVDPDWUK> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			private int <i>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40002DE")]
			private TaskAwaiter<GameObject> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x9FD3900", Offset = "0x9FD2D00", VA = "0x189FD3900", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x9FD43E0", Offset = "0x9FD37E0", VA = "0x189FD43E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9FD4440", Offset = "0x9FD3840", VA = "0x189FD4440", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x9FD4A40", Offset = "0x9FD3E40", VA = "0x189FD4A40", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9FD4CB0", Offset = "0x9FD40B0", VA = "0x189FD4CB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x9FD4ED0", Offset = "0x9FD42D0", VA = "0x189FD4ED0", Slot = "5")]
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
			private VNYFQYNHQCR <scene>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x9FD4F30", Offset = "0x9FD4330", VA = "0x189FD4F30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x9FD5BF0", Offset = "0x9FD4FF0", VA = "0x189FD5BF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public int OGXYJCRCKMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public int XGNGMZLVWDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private bool OZFQWABGDAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private bool PTOAPXVCLNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private Dictionary<Stream, NativeArray<byte>> BPDZJPNVLIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public bool NIVMEHKYFLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public bool QCPTSJDUMHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public bool DMOEESZWVON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x63")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public bool BFLVMWSJDYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public bool MMTIYAVJVRL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public ImportStatistics CTXDHRUHERH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		protected YCKHOEPLNAL TYMZSMQMRQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		protected MFFNSAABIBG CJPKEHVRDMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		protected GameObject SEQYIFUOIVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		protected readonly WKXGTXFNJNI AQYCPYEZNIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		internal WNNQVCCVEFF HLKLIHNGQRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		protected string FTVNKOOBHZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		protected GLBStream LVVAKOWNXKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		protected FZUMGSVMSUT OJWASYGZTLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		protected ZVGYAWFIQVG BPLEZRTTOXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		protected bool DFUGXSNHKQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		protected ImportProgress OWJQROGLNCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		protected IProgress<ImportProgress> LBUDPRCCFAN;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static ILogger TSHIAIKNEOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		protected ColorSpace JNCVADRGCYO;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		internal static List<Texture> GFNCEHYAWDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private Dictionary<int, int> PRAKJBUQZEO;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool LLHPGCQKHRU
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x9FA3470", Offset = "0x9FA2870", VA = "0x189FA3470")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xAA7380", Offset = "0xAA6780", VA = "0x180AA7380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public FZUMGSVMSUT JNBRJWHHBWC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xBDEAA0", Offset = "0xBDDEA0", VA = "0x180BDEAA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Transform DKCRPFESOKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public GameObject YUUMWKCJCJX
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private AnimationClip[] OZBJGJTQPUD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ColliderType CSMUVBWZASC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xAD4020", Offset = "0xAD3420", VA = "0x180AD4020")]
			[CompilerGenerated]
			get
			{
				return default(ColliderType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xB10400", Offset = "0xB0F800", VA = "0x180B10400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public string WDRLGUYMSID
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xAAA840", Offset = "0xAA9C40", VA = "0x180AAA840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public GameObject XUMNAAZNURX
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xAAC9A0", Offset = "0xAABDA0", VA = "0x180AAC9A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public BUQSFKRWQAB[] ZBJPVATIKJP
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x9F9ABD0", Offset = "0x9F99FD0", VA = "0x189F9ABD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Texture2D[] UGLZGDKVUSE
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x9FA1160", Offset = "0x9FA0560", VA = "0x189FA1160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public WNNQVCCVEFF[] FJTAYCYTTYD
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x9F9E550", Offset = "0x9F9D950", VA = "0x189F9E550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public YBXZZMCYPGO[] ALCWUVOJRYK
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x9F9E530", Offset = "0x9F9D930", VA = "0x189F9E530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public ZGBHUJWMFFN[] QCMOZDFHZPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x9FA4AE0", Offset = "0x9FA3EE0", VA = "0x189FA4AE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public List<UnityEngine.Object> ZTXHAZXCDSG
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xAA3370", Offset = "0xAA2770", VA = "0x180AA3370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected NEFZNIVNFTP UNMOTZWGDXX
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x9FA2270", Offset = "0x9FA1670", VA = "0x189FA2270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x9FA74E0", Offset = "0x9FA68E0", VA = "0x189FA74E0")]
		public GLTFSceneImporter(string gltfFileName, YCKHOEPLNAL options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x9FA7530", Offset = "0x9FA6930", VA = "0x189FA7530")]
		public GLTFSceneImporter(Stream gltfStream, YCKHOEPLNAL options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x9FA7630", Offset = "0x9FA6A30", VA = "0x189FA7630")]
		private GLTFSceneImporter(YCKHOEPLNAL options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x9FA0ED0", Offset = "0x9FA02D0", VA = "0x189FA0ED0")]
		private NativeArray<byte> MGWLIYAIDOO(Stream a)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F2C0", Offset = "0x9F9E6C0", VA = "0x189F9F2C0")]
		private void JKQSUQIZKGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x9F9D3E0", Offset = "0x9F9C7E0", VA = "0x189F9D3E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x9FA2D90", Offset = "0x9FA2190", VA = "0x189FA2D90")]
		[AsyncStateMachine(typeof(<LoadSceneAsync>d__81))]
		public Task RDMJOJQOINA(int a = -1, bool b = true, [Optional] Action<GameObject, ExceptionDispatchInfo> c, [Optional] CancellationToken d, [Optional] IProgress<ImportProgress> e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x9FA4170", Offset = "0x9FA3570", VA = "0x189FA4170")]
		[AsyncStateMachine(typeof(<LoadUnreferencedAssetsAsync>d__82))]
		private Task UBVSYLWJWDD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x9FA2C80", Offset = "0x9FA2080", VA = "0x189FA2C80", Slot = "5")]
		[AsyncStateMachine(typeof(<LoadMaterialAsync>d__85))]
		public virtual Task<Material> QUVHSDPWRTT(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x9F9E570", Offset = "0x9F9D970", VA = "0x189F9E570", Slot = "6")]
		[AsyncStateMachine(typeof(<LoadMeshAsync>d__86))]
		public virtual Task<Mesh> GQAWQSVPJHH(int a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x9FA0B50", Offset = "0x9F9FF50", VA = "0x189FA0B50")]
		[AsyncStateMachine(typeof(<LoadJson>d__87))]
		private Task LRJWJFGHZVK(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x9F9D2A0", Offset = "0x9F9C6A0", VA = "0x189F9D2A0")]
		private void DZFTKJQNHTX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x9F9E8B0", Offset = "0x9F9DCB0", VA = "0x189F9E8B0")]
		[AsyncStateMachine(typeof(<_LoadScene>d__90))]
		protected Task HLCTFCHNOEZ(int a = -1, bool b = true, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x9F9EE20", Offset = "0x9F9E220", VA = "0x189F9EE20")]
		private void IPTYHRGJHAT(VNYFQYNHQCR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9FA5700", Offset = "0x9FA4B00", VA = "0x189FA5700")]
		public NativeArray<byte> XNUJJTFYXWF(SAALMDNJRJD a)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9FA23D0", Offset = "0x9FA17D0", VA = "0x189FA23D0")]
		[AsyncStateMachine(typeof(<GetBufferData>d__93))]
		private Task<VKHNVDPDWUK> PWLACWFWKZK(HGPMTRNOTAJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9FA1810", Offset = "0x9FA0C10", VA = "0x189FA1810")]
		private float NBWWVTWZHGH(List<double> a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9FA07C0", Offset = "0x9F9FBC0", VA = "0x189FA07C0")]
		[AsyncStateMachine(typeof(<GetNode>d__95))]
		private Task<GameObject> LDITQJSASGC(int a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x9FA6EB0", Offset = "0x9FA62B0", VA = "0x189FA6EB0")]
		[AsyncStateMachine(typeof(<GetInstancesTRS>d__96))]
		private Task<(Vector3, Quaternion, Vector3)[]> ZWSOHBSRFZD(CFDTQFFCTZU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9F9AE90", Offset = "0x9F9A290", VA = "0x189F9AE90")]
		private bool BULTDACQEGK(CFDTQFFCTZU a, GameObject b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x9FA5170", Offset = "0x9FA4570", VA = "0x189FA5170", Slot = "7")]
		[AsyncStateMachine(typeof(<ConstructNode>d__98))]
		protected virtual Task XDTOAADQKTB(CFDTQFFCTZU a, int b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x9F9CB10", Offset = "0x9F9BF10", VA = "0x189F9CB10")]
		[AsyncStateMachine(typeof(<ConstructBufferData>d__99))]
		private Task DMAWFSCQJDL(CFDTQFFCTZU a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F650", Offset = "0x9F9EA50", VA = "0x189F9F650")]
		[AsyncStateMachine(typeof(<ConstructBuffer>d__100))]
		protected Task JXIFROFWXGF(SHEUFKKLCGJ a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9FA46C0", Offset = "0x9FA3AC0", VA = "0x189FA46C0", Slot = "8")]
		[AsyncStateMachine(typeof(<ConstructScene>d__101))]
		protected virtual Task VDYHIDZGJJX(VNYFQYNHQCR a, bool b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9FA4060", Offset = "0x9FA3460", VA = "0x189FA4060", Slot = "9")]
		protected virtual VKHNVDPDWUK TYXGOOJULBG(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9F9C7F0", Offset = "0x9F9BBF0", VA = "0x189F9C7F0")]
		private void Cleanup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9FA0C50", Offset = "0x9FA0050", VA = "0x189FA0C50")]
		private void LWMACBEZSKT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9F9E9D0", Offset = "0x9F9DDD0", VA = "0x189F9E9D0")]
		[AsyncStateMachine(typeof(<SetupLoad>d__107))]
		private Task HNKWHJJDJPJ(Func<Task> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9F9E6A0", Offset = "0x9F9DAA0", VA = "0x189F9E6A0")]
		[AsyncStateMachine(typeof(<YieldOnTimeoutAndThrowOnLowMemory>d__108))]
		protected Task GYPQFSWAJHC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9FA57E0", Offset = "0x9FA4BE0", VA = "0x189FA57E0")]
		private static string YBZMNTLMXHL(Transform a, Transform b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9F9D430", Offset = "0x9F9C830", VA = "0x189F9D430", Slot = "10")]
		[AsyncStateMachine(typeof(<BuildAnimationSamplers>d__110))]
		protected virtual Task EFEDZAOZBER(PTLIBJBFTSP a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9F9AF80", Offset = "0x9F9A380", VA = "0x189F9AF80")]
		protected void BWWASXWQAJF(AnimationClip a, string b, string[] c, NumericArray d, NumericArray e, InterpolationType f, Type g, ValuesConvertion h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9FA42B0", Offset = "0x9FA36B0", VA = "0x189FA42B0")]
		private void UJZBNCPMPTO(Keyframe[] a, int b, InterpolationType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F470", Offset = "0x9F9E870", VA = "0x189F9F470")]
		private static float JKZVLDCRWIQ(Keyframe[] a, int b, bool c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F160", Offset = "0x9F9E560", VA = "0x189F9F160")]
		[AsyncStateMachine(typeof(<ConstructClip>d__114))]
		protected Task<AnimationClip> ITGHRBLTGRH(Transform a, int b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9FA3030", Offset = "0x9FA2430", VA = "0x189FA3030")]
		private bool RIRTZPDWVZK(GameObject a, CFDTQFFCTZU b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9FA1180", Offset = "0x9FA0580", VA = "0x189FA1180")]
		private bool MXPMLNMHAUW(GameObject a, CFDTQFFCTZU b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9FA3B60", Offset = "0x9FA2F60", VA = "0x189FA3B60")]
		[AsyncStateMachine(typeof(<ConstructLods>d__117))]
		private Task SJLTZXIPJQP(FZUMGSVMSUT a, GameObject b, CFDTQFFCTZU c, int d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9FA3A60", Offset = "0x9FA2E60", VA = "0x189FA3A60", Slot = "11")]
		[AsyncStateMachine(typeof(<ConstructMaterial>d__119))]
		protected virtual Task SIMLEUNKGFE(WKXGTXFNJNI a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x9FA6060", Offset = "0x9FA5460", VA = "0x189FA6060", Slot = "12")]
		protected virtual Task ZQQADGOTACC(WKXGTXFNJNI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9FA34F0", Offset = "0x9FA28F0", VA = "0x189FA34F0", Slot = "13")]
		protected virtual OYZLRQXQNSN RSDYCMQQWZR(GQTAFWBMEER a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9F9CD60", Offset = "0x9F9C160", VA = "0x189F9CD60", Slot = "14")]
		protected virtual KHR_materials_emissive_strength DVOGDOCNFNK(WKXGTXFNJNI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9F9AA90", Offset = "0x9F99E90", VA = "0x189F9AA90", Slot = "15")]
		protected virtual KHR_materials_transmission AYUIKWTWSZA(WKXGTXFNJNI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9FA2130", Offset = "0x9FA1530", VA = "0x189FA2130", Slot = "16")]
		protected virtual KHR_materials_sheen PUIIDIDOLNJ(WKXGTXFNJNI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9F9EAC0", Offset = "0x9F9DEC0", VA = "0x189F9EAC0", Slot = "17")]
		protected virtual KHR_materials_anisotropy IEOWEGNMOTA(WKXGTXFNJNI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9F9EC00", Offset = "0x9F9E000", VA = "0x189F9EC00", Slot = "18")]
		protected virtual KHR_materials_dispersion IHWJZROJUXW(WKXGTXFNJNI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9FA1BF0", Offset = "0x9FA0FF0", VA = "0x189FA1BF0", Slot = "19")]
		protected virtual KHR_materials_volume OODGIYRXVAA(WKXGTXFNJNI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9FA4EF0", Offset = "0x9FA42F0", VA = "0x189FA4EF0", Slot = "20")]
		protected virtual KHR_materials_ior WYQUOPEIVUU(WKXGTXFNJNI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x9FA5030", Offset = "0x9FA4430", VA = "0x189FA5030", Slot = "21")]
		protected virtual KHR_materials_iridescence XCIGXDMLJFY(WKXGTXFNJNI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x9FA3F20", Offset = "0x9FA3320", VA = "0x189FA3F20", Slot = "22")]
		protected virtual KHR_materials_specular TUGGLGIUMVN(WKXGTXFNJNI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9F9E770", Offset = "0x9F9DB70", VA = "0x189F9E770", Slot = "23")]
		protected virtual KHR_materials_clearcoat HHQBRRQXBVS(WKXGTXFNJNI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x9FA0DE0", Offset = "0x9FA01E0", VA = "0x189FA0DE0")]
		[AsyncStateMachine(typeof(<CreateMaterials>d__132))]
		private Task MBZOOONXPCM(JRRIGPAJAOY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9F9CC30", Offset = "0x9F9C030", VA = "0x189F9CC30", Slot = "24")]
		[AsyncStateMachine(typeof(<ConstructMesh>d__133))]
		protected virtual Task DOTJKRYHPGK(DERQUSIAPDY a, int b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x9F9E430", Offset = "0x9F9D830", VA = "0x189F9E430")]
		[AsyncStateMachine(typeof(<CreateMeshMaterials>d__134))]
		private Task ETJNKSVMBFV(DERQUSIAPDY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9FA47F0", Offset = "0x9FA3BF0", VA = "0x189FA47F0")]
		private static uint[] WCYDRINLLFC(DERQUSIAPDY a, [Out] uint b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9FA5990", Offset = "0x9FA4D90", VA = "0x189FA5990")]
		protected void YDHLHLBVWYT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9FA37F0", Offset = "0x9FA2BF0", VA = "0x189FA37F0")]
		protected void SGDOGLNHIMT(Mesh a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F8A0", Offset = "0x9F9ECA0", VA = "0x189F9F8A0")]
		private ZOWJCSGELOO LAKRNEPTDLQ(DERQUSIAPDY a, int b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9FA0900", Offset = "0x9F9FD00", VA = "0x189FA0900")]
		[AsyncStateMachine(typeof(<ConstructUnityMesh>d__139))]
		protected Task LMSOPJEVBZD(ZOWJCSGELOO a, int b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x9FA3CA0", Offset = "0x9FA30A0", VA = "0x189FA3CA0")]
		private void SJQQVDZQIJA(ZOWJCSGELOO a, int b, Mesh c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9FA52B0", Offset = "0x9FA46B0", VA = "0x189FA52B0", Slot = "25")]
		[AsyncStateMachine(typeof(<ConstructMeshTargetsPrepareBuffers>d__141))]
		protected virtual Task XELTYQIQTDM(JRRIGPAJAOY a, int b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x9F9B890", Offset = "0x9F9AC90", VA = "0x189F9B890", Slot = "26")]
		protected virtual void CVYKUGOQXPW(JRRIGPAJAOY a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x9FA24E0", Offset = "0x9FA18E0", VA = "0x189FA24E0")]
		private void QNYNZUURWPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9F9AC50", Offset = "0x9F9A050", VA = "0x189F9AC50")]
		[AsyncStateMachine(typeof(<PreparePrimitiveAttributes>d__144))]
		private Task BMWYYDLLBRF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9FA0A30", Offset = "0x9F9FE30", VA = "0x189FA0A30")]
		[AsyncStateMachine(typeof(<ConstructMeshAttributes>d__145))]
		private Task LQNXXXYBECD(DERQUSIAPDY a, HXARMPGUANY b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9FA1FF0", Offset = "0x9FA13F0", VA = "0x189FA1FF0", Slot = "27")]
		[AsyncStateMachine(typeof(<ConstructPrimitiveAttributes>d__146))]
		protected virtual Task PQKHQNTRHZP(JRRIGPAJAOY a, int b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x9F9D550", Offset = "0x9F9C950", VA = "0x189F9D550")]
		protected void EIWCNHYLMUW(ZGBHUJWMFFN.AIHVYAIFZVR a, ZOWJCSGELOO b, uint c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x9FA44A0", Offset = "0x9FA38A0", VA = "0x189FA44A0")]
		private void UPKYJUTFQYU(Dictionary<string, WCFAQEMIIMZ> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x9FA3630", Offset = "0x9FA2A30", VA = "0x189FA3630")]
		protected MeshTopology RZWBHFBTIQH(DrawMode a)
		{
			return default(MeshTopology);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9FA6FE0", Offset = "0x9FA63E0", VA = "0x189FA6FE0")]
		private void ZYYZOCWKYHU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x9FA1AB0", Offset = "0x9FA0EB0", VA = "0x189FA1AB0", Slot = "28")]
		[AsyncStateMachine(typeof(<SetupBones>d__153))]
		protected virtual Task NQVNCGQORHE(CRODCQRPSXF a, SkinnedMeshRenderer b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9F9CEA0", Offset = "0x9F9C2A0", VA = "0x189F9CEA0")]
		private void DYCZYCWMKHD(Vector4[] a, Vector4[] b, BoneWeight[] c, uint d = 0u)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x9F9ED40", Offset = "0x9F9E140", VA = "0x189F9ED40")]
		[AsyncStateMachine(typeof(<CreateNotReferencedTexture>d__158))]
		private Task IHXNCFUZIQD(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x9FA2B40", Offset = "0x9FA1F40", VA = "0x189FA2B40")]
		[AsyncStateMachine(typeof(<FromTextureInfo>d__159))]
		private Task<QZPTVWGYTQF> QTXDXRGINVH(GQTAFWBMEER a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x9F9ABF0", Offset = "0x9F99FF0", VA = "0x189F9ABF0")]
		private static int BJWGAQDYJMX(byte[] a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x9FA5C10", Offset = "0x9FA5010", VA = "0x189FA5C10")]
		private Dictionary<int, int> YSIPUKFJXAR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x9F9C840", Offset = "0x9F9BC40", VA = "0x189F9C840")]
		private void DETZFVEFUTS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x9FA53E0", Offset = "0x9FA47E0", VA = "0x189FA53E0")]
		private Stream XJGHTKNJMOL(HWSSUNICCRC a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x9FA55C0", Offset = "0x9FA49C0", VA = "0x189FA55C0")]
		[AsyncStateMachine(typeof(<ConstructImage>d__164))]
		protected Task XNBHYUKPSDO(HWSSUNICCRC a, int b, bool c, bool d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9FA5F40", Offset = "0x9FA5340", VA = "0x189FA5F40")]
		[AsyncStateMachine(typeof(<ConstructImageBuffer>d__165))]
		protected Task ZOVPDRQDEHY(XRKEDLFRQLY a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9F9AD30", Offset = "0x9F9A130", VA = "0x189F9AD30")]
		[AsyncStateMachine(typeof(<CheckMimeTypeAndLoadImage>d__166))]
		private Task<Texture2D> BTHKRBVVOKY(HWSSUNICCRC a, Texture2D b, NativeArray<byte> c, bool d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9FA16D0", Offset = "0x9FA0AD0", VA = "0x189FA16D0", Slot = "29")]
		[AsyncStateMachine(typeof(<ConstructUnityTexture>d__167))]
		protected virtual Task MZTLDTKKNZB(Stream a, bool b, bool c, bool d, HWSSUNICCRC e, int f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x9FA2ED0", Offset = "0x9FA22D0", VA = "0x189FA2ED0", Slot = "30")]
		protected virtual int RFGDHNGYOXP(XRKEDLFRQLY a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9FA4240", Offset = "0x9FA3640", VA = "0x189FA4240", Slot = "31")]
		protected virtual bool UDCBJAUIXEP(XRKEDLFRQLY a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F760", Offset = "0x9F9EB60", VA = "0x189F9F760", Slot = "32")]
		[AsyncStateMachine(typeof(<ConstructTexture>d__173))]
		protected virtual Task KGDZKXCPBKG(XRKEDLFRQLY a, int b, bool c, bool d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x9FA2290", Offset = "0x9FA1690", VA = "0x189FA2290")]
		[AsyncStateMachine(typeof(<<GetInstancesTRS>g__GetAttrAccessorAndAccessorContent|96_0>d))]
		[CompilerGenerated]
		private Task<WCFAQEMIIMZ> PWHQLXSAPDL(ZIHJPSCCEDS a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9FA4C60", Offset = "0x9FA4060", VA = "0x189FA4C60")]
		[CompilerGenerated]
		internal static WCFAQEMIIMZ WYPRGXIVYVR(string a, <>c__DisplayClass114_0 b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x9FA4B00", Offset = "0x9FA3F00", VA = "0x189FA4B00")]
		[CompilerGenerated]
		private void WXAMZIJXGMA(SNZWXCMIXSE a, OYZLRQXQNSN b, [Out] Vector2 c, [Out] Vector2 d, <>c__DisplayClass119_0 e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x9FA1D30", Offset = "0x9FA1130", VA = "0x189FA1D30")]
		[CompilerGenerated]
		private void OPCFXSNDFHV(<>c__DisplayClass119_0 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9FA1E00", Offset = "0x9FA1200", VA = "0x189FA1E00")]
		[CompilerGenerated]
		private void OYSSGCWOGEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x9FA18A0", Offset = "0x9FA0CA0", VA = "0x189FA18A0")]
		[CompilerGenerated]
		private TextureWrapMode NHUDPMUUMYF(GLTF.Schema.WrapMode a)
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
		private sealed class WVNYVDLQPSI<a> where a : GLTFPlugin
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			public Type NANRSRFEWON;

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public WVNYVDLQPSI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x65C63B0", Offset = "0x65C57B0", VA = "0x1865C63B0")]
			internal bool IEQFSAHOQDY(a a)
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
		public string YIQMUWTPYOP
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x9FC2430", Offset = "0x9FC1830", VA = "0x189FC2430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool JCKANUFISUE
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xAF9F90", Offset = "0xAF9390", VA = "0x180AF9F90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0xAF9170", Offset = "0xAF8570", VA = "0x180AF9170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool ATUYERJHUPU
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xC6AC80", Offset = "0xC6A080", VA = "0x180C6AC80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xCA3E90", Offset = "0xCA3290", VA = "0x180CA3E90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool OVVOOLNYBMT
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x17EEB60", Offset = "0x17EDF60", VA = "0x1817EEB60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x17EEB70", Offset = "0x17EDF70", VA = "0x1817EEB70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool CTTMNVXMNIQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xC0DEA0", Offset = "0xC0D2A0", VA = "0x180C0DEA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xC0E190", Offset = "0xC0D590", VA = "0x180C0E190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool HTECHJJHEVE
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xC0E000", Offset = "0xC0D400", VA = "0x180C0E000")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xC0DE80", Offset = "0xC0D280", VA = "0x180C0DE80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool ITCIHDQUEZI
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x239DC70", Offset = "0x239D070", VA = "0x18239DC70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x239DDF0", Offset = "0x239D1F0", VA = "0x18239DDF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public int RKRRFNKARGC
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xAD4020", Offset = "0xAD3420", VA = "0x180AD4020")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xB10400", Offset = "0xB0F800", VA = "0x180B10400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool TXIAGEODWKO
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x1DC5B10", Offset = "0x1DC4F10", VA = "0x181DC5B10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x849CCB0", Offset = "0x849C0B0", VA = "0x18849CCB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool KVMJTNPBTJF
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xBEE6C0", Offset = "0xBEDAC0", VA = "0x180BEE6C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xCDA280", Offset = "0xCD9680", VA = "0x180CDA280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool PCMGCQQODQS
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xCDA260", Offset = "0xCD9660", VA = "0x180CDA260")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xCDAEF0", Offset = "0xCDA2F0", VA = "0x180CDAEF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		[Obsolete("Add/remove \"AnimationPointerPlugin\" from ExportPlugins instead.")]
		public bool GOKJUDKCYKK
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x9FC2440", Offset = "0x9FC1840", VA = "0x189FC2440")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x9FC2560", Offset = "0x9FC1960", VA = "0x189FC2560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool OIVWHUGOXOT
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xCDAF00", Offset = "0xCDA300", VA = "0x180CDAF00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xCDACB0", Offset = "0xCDA0B0", VA = "0x180CDACB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool VWDNNHSBVRC
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x16C50A0", Offset = "0x16C44A0", VA = "0x1816C50A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x16C5090", Offset = "0x16C4490", VA = "0x1816C5090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public BlendShapeExportPropertyFlags AJYQPSFISAB
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xAC1F70", Offset = "0xAC1370", VA = "0x180AC1F70")]
			get
			{
				return default(BlendShapeExportPropertyFlags);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0xBDCB60", Offset = "0xBDBF60", VA = "0x180BDCB60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool XYZWQEZDBCA
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x9C20B10", Offset = "0x9C1FF10", VA = "0x189C20B10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x9C39540", Offset = "0x9C38940", VA = "0x189C39540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x9FC1900", Offset = "0x9FC0D00", VA = "0x189FC1900")]
		internal string GJKGVIIVPVR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x9FC1BE0", Offset = "0x9FC0FE0", VA = "0x189FC1BE0")]
		public static GLTFSettings GetOrCreateSettings()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x9FC1B70", Offset = "0x9FC0F70", VA = "0x189FC1B70")]
		public static GLTFSettings GetDefaultSettings()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x9FC1DB0", Offset = "0x9FC11B0", VA = "0x189FC1DB0")]
		public static bool TryGetSettings([Out] GLTFSettings settings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x9FC1850", Offset = "0x9FC0C50", VA = "0x189FC1850")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ClearStatics()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x9FC1EE0", Offset = "0x9FC12E0", VA = "0x189FC1EE0")]
		private static void WFIPPWRXZGF(GLTFSettings a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x9FC2340", Offset = "0x9FC1740", VA = "0x189FC2340")]
		public GLTFSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x364F810", Offset = "0x364EC10", VA = "0x18364F810")]
		[CompilerGenerated]
		internal static List<Type> VZYWRGPPPJW<a>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x364F490", Offset = "0x364E890", VA = "0x18364F490")]
		[CompilerGenerated]
		internal static void PQDHNBGCXPQ<b>(List<b> a) where b : GLTFPlugin
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class ShaderNotFoundException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7980", Offset = "0x9FC6D80", VA = "0x189FC7980")]
		public ShaderNotFoundException()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x9FC78D0", Offset = "0x9FC6CD0", VA = "0x189FC78D0")]
		public ShaderNotFoundException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7930", Offset = "0x9FC6D30", VA = "0x189FC7930")]
		protected ShaderNotFoundException(SerializationInfo info, StreamingContext context)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class GLTFLoadException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x9FC17F0", Offset = "0x9FC0BF0", VA = "0x189FC17F0")]
		public GLTFLoadException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class MEYBYOBKVLZ : ILogHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private readonly StringBuilder RNYRUSEAZHV;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x9FC3060", Offset = "0x9FC2460", VA = "0x189FC3060")]
		private string FSAVULAJOYR(LogType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x9FC3180", Offset = "0x9FC2580", VA = "0x189FC3180", Slot = "4")]
		public void LogFormat(LogType logType, UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x9FC30E0", Offset = "0x9FC24E0", VA = "0x189FC30E0", Slot = "5")]
		public void LogException(Exception exception, UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x9FC3240", Offset = "0x9FC2640", VA = "0x189FC3240")]
		public void UDPVHKUCZGC(string a = "{0}")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x9FC33B0", Offset = "0x9FC27B0", VA = "0x189FC33B0")]
		public MEYBYOBKVLZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class BALDVZPTIYI
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x9FC10B0", Offset = "0x9FC04B0", VA = "0x189FC10B0")]
		public static string BUVHQKEIRMS(Uri a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x9FC1110", Offset = "0x9FC0510", VA = "0x189FC1110")]
		public static string HKDEETVPLTA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x9FC1210", Offset = "0x9FC0610", VA = "0x189FC1210")]
		public static void QUPAEANUIUN(string a, [Out] byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x9FC1180", Offset = "0x9FC0580", VA = "0x189FC1180")]
		public static bool HZAOVXSXBMB(string a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class InstantiatedGLTFObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private HLEREIEYUIT SQDQMRBFYQY;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public HLEREIEYUIT TLJWVLHEQRG
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x9FC2940", Offset = "0x9FC1D40", VA = "0x189FC2940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x9FC2810", Offset = "0x9FC1C10", VA = "0x189FC2810")]
		public InstantiatedGLTFObject Duplicate()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x9FC28F0", Offset = "0x9FC1CF0", VA = "0x189FC28F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xAA4900", Offset = "0xAA3D00", VA = "0x180AA4900")]
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
		public float QJUCBDACWVX
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x9FC1320", Offset = "0x9FC0720", VA = "0x189FC1320")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x9FC13A0", Offset = "0x9FC07A0", VA = "0x189FC13A0")]
		public BlendShapeFrameWeightSetting(MultiplierOption option)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x9FC13B0", Offset = "0x9FC07B0", VA = "0x189FC13B0")]
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
		public abstract GLTFSceneImporter CreateSceneImporter(string gltfFileName, YCKHOEPLNAL options);

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xBA6820", Offset = "0xBA5C20", VA = "0x180BA6820")]
		protected ImporterFactory()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class DefaultImporterFactory : ImporterFactory
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x9FC1430", Offset = "0x9FC0830", VA = "0x189FC1430", Slot = "4")]
		public override GLTFSceneImporter CreateSceneImporter(string gltfFileName, YCKHOEPLNAL options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xBA6820", Offset = "0xBA5C20", VA = "0x180BA6820")]
		public DefaultImporterFactory()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	internal static class ONUTTMKYCJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7810", Offset = "0x9FC6C10", VA = "0x189FC7810")]
		internal static void MCGUZIDQVJX(this Material a, string b, bool c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class MaterialLibrary : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xBA6820", Offset = "0xBA5C20", VA = "0x180BA6820")]
		public MaterialLibrary()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	internal static class VEGPDSZLHWQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class EZOENQOHZNW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400031F")]
			public Texture2D AIPXGROOENE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			public Texture2D GHDQVXYJJAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			public Color[] TTDXIQTTXCD;

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public EZOENQOHZNW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x9FC14A0", Offset = "0x9FC08A0", VA = "0x189FC14A0")]
			internal void ESRECWHZVWD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x9FC1700", Offset = "0x9FC0B00", VA = "0x189FC1700")]
			internal void OPHRVCSHQBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x9FC1750", Offset = "0x9FC0B50", VA = "0x189FC1750")]
			internal void UQKULTXEKQP()
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
			private EZOENQOHZNW <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x9FCD890", Offset = "0x9FCCC90", VA = "0x189FCD890", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x9FCDEB0", Offset = "0x9FCD2B0", VA = "0x189FCDEB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x9FD5C50", Offset = "0x9FD5050", VA = "0x189FD5C50")]
		[AsyncStateMachine(typeof(<ConvertToDxt5nmAndCheckTextureFormatAsync>d__0))]
		public static Task<Texture2D> XGLMEEXKVAB(Texture2D a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class ZOWJCSGELOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public bool[] RXFBBXZAVPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public Vector3[] PFVAXYEMHOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public Vector3[] KGFYSKWIHNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public Vector4[] XIWIAMVWHWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public Vector2[] HRUKTFOBCGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public Vector2[] HSKFKZVTEOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public Vector2[] HSEYNTBVVDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public Vector2[] HREQBLGIZYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public Color[] FLIKJNDQTFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public BoneWeight[] NHSPFORWNPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public Vector3[][] KCWHHFZZIGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public Vector3[][] BFEHVCWISHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public Vector3[][] DMWFEFAKJBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public MeshTopology[] KOAKRLFNXXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public DrawMode[] UDYWHRWDRHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public int[][] SNTSIHYPTRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public HashSet<int> JUEPFGFBZQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public uint[] OAODWMKTMQY;

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x9FD62D0", Offset = "0x9FD56D0", VA = "0x189FD62D0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x9FD63E0", Offset = "0x9FD57E0", VA = "0x189FD63E0")]
		public bool VZICGSGREJE(ZOWJCSGELOO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x9FD6630", Offset = "0x9FD5A30", VA = "0x189FD6630")]
		public ZOWJCSGELOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3C29CA0", Offset = "0x3C290A0", VA = "0x183C29CA0")]
		[CompilerGenerated]
		internal static bool USISWFPRTZK<a>(a[] a, a[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3C297B0", Offset = "0x3C28BB0", VA = "0x183C297B0")]
		[CompilerGenerated]
		internal static bool FQYFDEPPWRR<b>(b[][] a, b[][] b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public abstract class MVBJQTRVRLT : XCWKPVCUDXR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		internal Material VKHSCBVZZTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private AlphaMode CBCKMYZCYXM;

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public static readonly int ORUJBLHOWXF;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private static readonly int VFEPOPHYCQS;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private static readonly int CJLYIDSROGR;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private static readonly int QWITDDCDLSA;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private static readonly int IBKONLCNFHQ;

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private static readonly int SCNAULFOWHH;

		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private static readonly int FVDVPGTCHZV;

		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private static readonly int XMIWEDNZTWC;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private static readonly int XAYRJRZWVHI;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private static readonly int VSCZUDNKCPL;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private static readonly int BQPWPYCIWDR;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private static readonly int AUQXPVXFFZC;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private static readonly int FOOFRYBZKED;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private static readonly int GABYHUQEQVN;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Material UIIQDVLKWCX
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public virtual AlphaMode OIFUOCHYQZT
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x9FC3840", Offset = "0x9FC2C40", VA = "0x189FC3840", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public double NCRNFAAGSQD
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x9FC4650", Offset = "0x9FC3A50", VA = "0x189FC4650", Slot = "12")]
			get
			{
				return default(double);
			}
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x9FC3630", Offset = "0x9FC2A30", VA = "0x189FC3630", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public virtual bool TQOVUOYGESA
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x9FC3690", Offset = "0x9FC2A90", VA = "0x189FC3690", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public virtual bool SPHLBRNGTOZ
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x9FC4870", Offset = "0x9FC3C70", VA = "0x189FC4870", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public Texture UCGPGETGTVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x9FC3570", Offset = "0x9FC2970", VA = "0x189FC3570", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int GHLOBOGMIZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x9FC3770", Offset = "0x9FC2B70", VA = "0x189FC3770", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Vector2 RSLUNUVIMNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x9FC4580", Offset = "0x9FC3980", VA = "0x189FC4580", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public double JBSXYZJGORC
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x9FC35D0", Offset = "0x9FC29D0", VA = "0x189FC35D0", Slot = "18")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Vector2 RVWKJNGFXMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x9FC37E0", Offset = "0x9FC2BE0", VA = "0x189FC37E0", Slot = "19")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public int FZMHWUCVTIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x9FC45E0", Offset = "0x9FC39E0", VA = "0x189FC45E0", Slot = "20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public Color YMHAAWWQZRH
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x9FC3500", Offset = "0x9FC2900", VA = "0x189FC3500", Slot = "21")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract XCWKPVCUDXR Clone();

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		protected MVBJQTRVRLT(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x9FC4B50", Offset = "0x9FC3F50", VA = "0x189FC4B50")]
		protected MVBJQTRVRLT(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x9FC3420", Offset = "0x9FC2820", VA = "0x189FC3420")]
		protected void AEIVYCDVPMQ(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x9FC46A0", Offset = "0x9FC3AA0", VA = "0x189FC46A0")]
		protected void YJOFKCWVSJP(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x9FC42D0", Offset = "0x9FC36D0", VA = "0x189FC42D0")]
		protected void ONZYHHDMNPJ(Material a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class KFVIZFKOLEZ : VMVYQXBMIMH, MRGSQSRILXF, DOYINZTHIZO, XCWKPVCUDXR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private Vector2 ORADLBHXGIV;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public virtual Texture UCGPGETGTVH
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x9FC2D30", Offset = "0x9FC2130", VA = "0x189FC2D30", Slot = "77")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public virtual int GHLOBOGMIZS
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "78")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public virtual Vector2 RSLUNUVIMNH
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x9FC2FD0", Offset = "0x9FC23D0", VA = "0x189FC2FD0", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public virtual double JBSXYZJGORC
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public virtual Vector2 RVWKJNGFXMQ
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x9FC2E40", Offset = "0x9FC2240", VA = "0x189FC2E40", Slot = "81")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public virtual int FZMHWUCVTIM
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "82")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public virtual Color YMHAAWWQZRH
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x9FC2CC0", Offset = "0x9FC20C0", VA = "0x189FC2CC0", Slot = "83")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public virtual Texture NKWTCQIAYHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x9FC2ED0", Offset = "0x9FC22D0", VA = "0x189FC2ED0", Slot = "84")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public virtual int XFRHXUMVZYF
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public virtual Vector2 JGVBORINFDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "86")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public virtual double SKIASFHYBIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual Vector2 PLPYCCHDNEZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "88")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public virtual int REQWZNCABET
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public virtual double MXKILPKNNGQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x9FC2F20", Offset = "0x9FC2320", VA = "0x189FC2F20", Slot = "90")]
			get
			{
				return default(double);
			}
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x9FC2F70", Offset = "0x9FC2370", VA = "0x189FC2F70", Slot = "91")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public virtual double CGEKVQSHBXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "92")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x9FC3040", Offset = "0x9FC2440", VA = "0x189FC3040")]
		protected KFVIZFKOLEZ(string a, string b, int c = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x9FC3050", Offset = "0x9FC2450", VA = "0x189FC3050")]
		protected KFVIZFKOLEZ(Material a, int b = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x9FC2D90", Offset = "0x9FC2190", VA = "0x189FC2D90", Slot = "60")]
		public override XCWKPVCUDXR Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class JUDUQDQSDDG : KFVIZFKOLEZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private Vector2 PJVIFTCRJYV;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public override int LDDXQBCYEMD
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "35")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public override int VVOYLJHUPUV
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public override int FLFAPXMBZAL
		{
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "49")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public override int GHLOBOGMIZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "78")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public override Texture NKWTCQIAYHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x9FC2A50", Offset = "0x9FC1E50", VA = "0x189FC2A50", Slot = "84")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public override int XFRHXUMVZYF
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public override Vector2 JGVBORINFDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x9FC2B60", Offset = "0x9FC1F60", VA = "0x189FC2B60", Slot = "86")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public override double SKIASFHYBIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public override Vector2 PLPYCCHDNEZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x9FC2AD0", Offset = "0x9FC1ED0", VA = "0x189FC2AD0", Slot = "88")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public override int REQWZNCABET
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public override double CGEKVQSHBXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x9FC2BD0", Offset = "0x9FC1FD0", VA = "0x189FC2BD0", Slot = "92")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x9FC2C50", Offset = "0x9FC2050", VA = "0x189FC2C50")]
		public JUDUQDQSDDG(string a, int b = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x9FC2C30", Offset = "0x9FC2030", VA = "0x189FC2C30")]
		protected JUDUQDQSDDG(Material a, int b = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x9FC29A0", Offset = "0x9FC1DA0", VA = "0x189FC29A0", Slot = "60")]
		public override XCWKPVCUDXR Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class NOCXIOPTELK : MVBJQTRVRLT, MRGSQSRILXF, DOYINZTHIZO, XCWKPVCUDXR, ENUNDHZLWIP, CTTAZLKMCIJ, VNBDCPKVUCZ, WNMCDZBAHYX, LESSVSFUXSG, FBFSTDKYMIN, YIPEUXEYCRJ, RZNUULKKPCQ, WYOBAPGIYZP
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public Texture XVSSISCCBCU
		{
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x9FC7370", Offset = "0x9FC6770", VA = "0x189FC7370", Slot = "37")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x9FC57A0", Offset = "0x9FC4BA0", VA = "0x189FC57A0", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public int LDDXQBCYEMD
		{
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x9FC6110", Offset = "0x9FC5510", VA = "0x189FC6110", Slot = "39")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public double YNJIQFUKXZO
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x9FC6AB0", Offset = "0x9FC5EB0", VA = "0x189FC6AB0", Slot = "40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public Vector2 ZGCBSUYXAHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x9FC55B0", Offset = "0x9FC49B0", VA = "0x189FC55B0", Slot = "41")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public double IHXCESTBDWR
		{
			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x9FC7420", Offset = "0x9FC6820", VA = "0x189FC7420", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public Vector2 OHQAVNERGPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x9FC5980", Offset = "0x9FC4D80", VA = "0x189FC5980", Slot = "43")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int VASTYBDGDZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x9FC59E0", Offset = "0x9FC4DE0", VA = "0x189FC59E0", Slot = "44")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public Texture BHPWZUVBJCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x9FC56E0", Offset = "0x9FC4AE0", VA = "0x189FC56E0", Slot = "45")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int VVOYLJHUPUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x9FC61E0", Offset = "0x9FC55E0", VA = "0x189FC61E0", Slot = "46")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public double BXSYPGLDLKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x9FC4D80", Offset = "0x9FC4180", VA = "0x189FC4D80", Slot = "47")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public Vector2 OYEGYESOZBQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x9FC50C0", Offset = "0x9FC44C0", VA = "0x189FC50C0", Slot = "48")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public double LVZOZDFZEXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x9FC6C40", Offset = "0x9FC6040", VA = "0x189FC6C40", Slot = "49")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public Vector2 UOFEGPDEAHP
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x9FC5550", Offset = "0x9FC4950", VA = "0x189FC5550", Slot = "50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public int PDELOPJRSKD
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x9FC7240", Offset = "0x9FC6640", VA = "0x189FC7240", Slot = "51")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Texture TPBHOOPPTAM
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x9FC5310", Offset = "0x9FC4710", VA = "0x189FC5310", Slot = "52")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public int FLFAPXMBZAL
		{
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x9FC5AB0", Offset = "0x9FC4EB0", VA = "0x189FC5AB0", Slot = "53")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Color FVXPWTMNCKW
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x9FC5670", Offset = "0x9FC4A70", VA = "0x189FC5670", Slot = "54")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x9FC6BD0", Offset = "0x9FC5FD0", VA = "0x189FC6BD0", Slot = "55")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector2 VCPESHDWRQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x9FC5B70", Offset = "0x9FC4F70", VA = "0x189FC5B70", Slot = "56")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public double RCWHSFOJGRL
		{
			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x9FC7120", Offset = "0x9FC6520", VA = "0x189FC7120", Slot = "57")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector2 OJQVLCVHVBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x9FC5860", Offset = "0x9FC4C60", VA = "0x189FC5860", Slot = "58")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public int GNLCRSLJGJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x9FC5DB0", Offset = "0x9FC51B0", VA = "0x189FC5DB0", Slot = "59")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public Texture NKWTCQIAYHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x9FC5F30", Offset = "0x9FC5330", VA = "0x189FC5F30", Slot = "29")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public int XFRHXUMVZYF
		{
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x9FC6870", Offset = "0x9FC5C70", VA = "0x189FC6870", Slot = "30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Vector2 JGVBORINFDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x9FC6B10", Offset = "0x9FC5F10", VA = "0x189FC6B10", Slot = "31")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public double SKIASFHYBIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x9FC62B0", Offset = "0x9FC56B0", VA = "0x189FC62B0", Slot = "32")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Vector2 PLPYCCHDNEZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x9FC64F0", Offset = "0x9FC58F0", VA = "0x189FC64F0", Slot = "33")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public int REQWZNCABET
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x9FC6430", Offset = "0x9FC5830", VA = "0x189FC6430", Slot = "34")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public double MXKILPKNNGQ
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x9FC65B0", Offset = "0x9FC59B0", VA = "0x189FC65B0", Slot = "35")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public double CGEKVQSHBXV
		{
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x9FC6F40", Offset = "0x9FC6340", VA = "0x189FC6F40", Slot = "36")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public double YJCRWHNMPLB
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x9FC4DE0", Offset = "0x9FC41E0", VA = "0x189FC4DE0", Slot = "60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public Texture DNSJGUYJAQL
		{
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x9FC5920", Offset = "0x9FC4D20", VA = "0x189FC5920", Slot = "61")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public double KPPRGTFEIYN
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x9FC6B70", Offset = "0x9FC5F70", VA = "0x189FC6B70", Slot = "63")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public Vector2 YYFOXWAXWDC
		{
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x9FC70C0", Offset = "0x9FC64C0", VA = "0x189FC70C0", Slot = "62")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public Vector2 KDBWVLPGETN
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x9FC71E0", Offset = "0x9FC65E0", VA = "0x189FC71E0", Slot = "64")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public int ISYUIAZSMUB
		{
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x9FC5A50", Offset = "0x9FC4E50", VA = "0x189FC5A50", Slot = "65")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public double TLMOPTZPBNX
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x9FC4C60", Offset = "0x9FC4060", VA = "0x189FC4C60", Slot = "66")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Color SCSMPMFFMSV
		{
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x9FC5120", Offset = "0x9FC4520", VA = "0x189FC5120", Slot = "67")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public double BVWNVBFXBLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x9FC4F60", Offset = "0x9FC4360", VA = "0x189FC4F60", Slot = "68")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public Texture RCIERWOYQTT
		{
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x9FC5C90", Offset = "0x9FC5090", VA = "0x189FC5C90", Slot = "69")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public double CNFTLECLHBV
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x9FC6180", Offset = "0x9FC5580", VA = "0x189FC6180", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Vector2 IAMVAKXBXNY
		{
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x9FC5190", Offset = "0x9FC4590", VA = "0x189FC5190", Slot = "70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Vector2 KRHHCOQBBNX
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x9FC6490", Offset = "0x9FC5890", VA = "0x189FC6490", Slot = "72")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public int IRLDCXHJHYD
		{
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x9FC5610", Offset = "0x9FC4A10", VA = "0x189FC5610", Slot = "73")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public double HVRTTVBPVAY
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x9FC5250", Offset = "0x9FC4650", VA = "0x189FC5250", Slot = "74")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public double SONZXCDXYAV
		{
			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x9FC5370", Offset = "0x9FC4770", VA = "0x189FC5370", Slot = "75")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public double KUJSWOZUWCU
		{
			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x9FC60B0", Offset = "0x9FC54B0", VA = "0x189FC60B0", Slot = "76")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public double AAWOTOSAUQA
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x9FC7060", Offset = "0x9FC6460", VA = "0x189FC7060", Slot = "77")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public double RKPRYGFKFBM
		{
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x9FC4F00", Offset = "0x9FC4300", VA = "0x189FC4F00", Slot = "78")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public Texture ZQSAZNBMMSJ
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x9FC5CF0", Offset = "0x9FC50F0", VA = "0x189FC5CF0", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public double UHVYTHRMFYD
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x9FC6250", Offset = "0x9FC5650", VA = "0x189FC6250", Slot = "81")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public Vector2 RWHCFVGAHKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x9FC5B10", Offset = "0x9FC4F10", VA = "0x189FC5B10", Slot = "80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public Vector2 BUGVCMUVJXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x9FC5F90", Offset = "0x9FC5390", VA = "0x189FC5F90", Slot = "82")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public int GNATJUGYISH
		{
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x9FC6050", Offset = "0x9FC5450", VA = "0x189FC6050", Slot = "83")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Texture BKPDJQAUCTZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0x9FC6610", Offset = "0x9FC5A10", VA = "0x189FC6610", Slot = "84")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public double KWHDPJVRQDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x9FC5ED0", Offset = "0x9FC52D0", VA = "0x189FC5ED0", Slot = "86")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public Vector2 XXGDNUPJZDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x9FC5740", Offset = "0x9FC4B40", VA = "0x189FC5740", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public Vector2 WELOZCFCWKT
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x9FC6EE0", Offset = "0x9FC62E0", VA = "0x189FC6EE0", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public int EDKVHFUMYWR
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x9FC5E70", Offset = "0x9FC5270", VA = "0x189FC5E70", Slot = "88")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public double DFDTMVYWXFW
		{
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x9FC4CC0", Offset = "0x9FC40C0", VA = "0x189FC4CC0", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public Texture WTVXZPQQUUC
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x9FC53D0", Offset = "0x9FC47D0", VA = "0x189FC53D0", Slot = "90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public double XMBWJLPNDNS
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x9FC5D50", Offset = "0x9FC5150", VA = "0x189FC5D50", Slot = "92")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public Vector2 NXIIATRVJUJ
		{
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0x9FC6370", Offset = "0x9FC5770", VA = "0x189FC6370", Slot = "91")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public Vector2 YBNYJTISYNO
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x9FC5C30", Offset = "0x9FC5030", VA = "0x189FC5C30", Slot = "93")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public int DMNDYGNSLYI
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x9FC51F0", Offset = "0x9FC45F0", VA = "0x189FC51F0", Slot = "94")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Color VEHYIRIEYWB
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x9FC67A0", Offset = "0x9FC5BA0", VA = "0x189FC67A0", Slot = "95")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Texture WGYRZQDTHPT
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x9FC4EA0", Offset = "0x9FC42A0", VA = "0x189FC4EA0", Slot = "96")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public double GAVDLIJZVNZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x9FC54F0", Offset = "0x9FC48F0", VA = "0x189FC54F0", Slot = "98")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public Vector2 YODFTCVCZZE
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x9FC4D20", Offset = "0x9FC4120", VA = "0x189FC4D20", Slot = "97")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public Vector2 QSBJZHKKDMV
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x9FC5490", Offset = "0x9FC4890", VA = "0x189FC5490", Slot = "99")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public int XZDWLHNNHPB
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x9FC6D60", Offset = "0x9FC6160", VA = "0x189FC6D60", Slot = "100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public double ATDFFIIDZCX
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x9FC6310", Offset = "0x9FC5710", VA = "0x189FC6310", Slot = "101")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public Texture SRJPWNOHHFR
		{
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x9FC7480", Offset = "0x9FC6880", VA = "0x189FC7480", Slot = "102")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public double ZELBUMNJDTX
		{
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x9FC63D0", Offset = "0x9FC57D0", VA = "0x189FC63D0", Slot = "104")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public Vector2 OUCBPPJXRDC
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x9FC4E40", Offset = "0x9FC4240", VA = "0x189FC4E40", Slot = "103")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Vector2 GMQTLDZGCNN
		{
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x9FC6550", Offset = "0x9FC5950", VA = "0x189FC6550", Slot = "105")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public int FJKQPVHNQGB
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x9FC6810", Offset = "0x9FC5C10", VA = "0x189FC6810", Slot = "106")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public double OKJYQFQLXBL
		{
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x9FC7310", Offset = "0x9FC6710", VA = "0x189FC7310", Slot = "107")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public Texture FGSXRGDCUBX
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x9FC6E20", Offset = "0x9FC6220", VA = "0x189FC6E20", Slot = "108")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public double ALCQILZEAAT
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x9FC7180", Offset = "0x9FC6580", VA = "0x189FC7180", Slot = "110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public Vector2 SKZCALPQZUC
		{
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x9FC6D00", Offset = "0x9FC6100", VA = "0x189FC6D00", Slot = "109")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public Vector2 HSYNWYGFDRH
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x9FC5BD0", Offset = "0x9FC4FD0", VA = "0x189FC5BD0", Slot = "111")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public int ZSDWDJFFTQD
		{
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x9FC5430", Offset = "0x9FC4830", VA = "0x189FC5430", Slot = "112")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public float HKEOZDBZEEI
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x9FC73C0", Offset = "0x9FC67C0", VA = "0x189FC73C0", Slot = "113")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public float RQFAJNDAXTW
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x9FC6930", Offset = "0x9FC5D30", VA = "0x189FC6930", Slot = "114")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public Color HPVKAZZIYSZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x9FC66D0", Offset = "0x9FC5AD0", VA = "0x189FC66D0", Slot = "115")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public Texture KFDJKFSKBSV
		{
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x9FC6A50", Offset = "0x9FC5E50", VA = "0x189FC6A50", Slot = "116")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public double CGYCCLFWRLV
		{
			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x9FC52B0", Offset = "0x9FC46B0", VA = "0x189FC52B0", Slot = "117")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public Vector2 WXBPJWDLSNQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x9FC6CA0", Offset = "0x9FC60A0", VA = "0x189FC6CA0", Slot = "118")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public Vector2 TNTGEJFVWDL
		{
			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x9FC6E80", Offset = "0x9FC6280", VA = "0x189FC6E80", Slot = "119")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public int OMCWSXVIUFZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x9FC6FA0", Offset = "0x9FC63A0", VA = "0x189FC6FA0", Slot = "120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public Texture DLLNUBSUIRE
		{
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x9FC6670", Offset = "0x9FC5A70", VA = "0x189FC6670", Slot = "121")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public double PNNKDKBQKMU
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x9FC68D0", Offset = "0x9FC5CD0", VA = "0x189FC68D0", Slot = "122")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public Vector2 KVWIDREHOHD
		{
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x9FC5800", Offset = "0x9FC4C00", VA = "0x189FC5800", Slot = "123")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public Vector2 HIPQRCXCDBW
		{
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x9FC58C0", Offset = "0x9FC4CC0", VA = "0x189FC58C0", Slot = "124")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public int EKUNWFGQRHG
		{
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x9FC6740", Offset = "0x9FC5B40", VA = "0x189FC6740", Slot = "125")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public double LSFVDRUESQT
		{
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x9FC6990", Offset = "0x9FC5D90", VA = "0x189FC6990", Slot = "131")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public double WGZNJKMDYBW
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x9FC5FF0", Offset = "0x9FC53F0", VA = "0x189FC5FF0", Slot = "132")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Texture OVFEDVCYNNH
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x9FC72B0", Offset = "0x9FC66B0", VA = "0x189FC72B0", Slot = "126")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public double HRINBVLHUTB
		{
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x9FC7000", Offset = "0x9FC6400", VA = "0x189FC7000", Slot = "128")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public Vector2 MZQZGDDFBSS
		{
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x9FC69F0", Offset = "0x9FC5DF0", VA = "0x189FC69F0", Slot = "127")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public Vector2 EAVVKGOGRWJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x9FC6DC0", Offset = "0x9FC61C0", VA = "0x189FC6DC0", Slot = "129")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public int NHXBEMZFDRN
		{
			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x9FC5E10", Offset = "0x9FC5210", VA = "0x189FC5E10", Slot = "130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x9FC76A0", Offset = "0x9FC6AA0", VA = "0x189FC76A0")]
		public NOCXIOPTELK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x9FC74E0", Offset = "0x9FC68E0", VA = "0x189FC74E0")]
		protected NOCXIOPTELK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7630", Offset = "0x9FC6A30", VA = "0x189FC7630")]
		public NOCXIOPTELK(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x9FC4FC0", Offset = "0x9FC43C0", VA = "0x189FC4FC0", Slot = "10")]
		public override XCWKPVCUDXR Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class YEZDDHIXVKG : VMVYQXBMIMH, BLHWOZUEHFM, DOYINZTHIZO, XCWKPVCUDXR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private Vector2 PYIIUDOOGFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private Vector2 IGUAFULNOGW;

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public virtual Texture WRESFTJMFZZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x9FD6030", Offset = "0x9FD5430", VA = "0x189FD6030", Slot = "77")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public virtual int CJEEGMHIUSC
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "78")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public virtual Vector2 RGZPGLQHYFN
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x9FD6090", Offset = "0x9FD5490", VA = "0x189FD6090", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public virtual double FTHQUJPHKGO
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public virtual Vector2 IDLGWGGQXFY
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x9FD6170", Offset = "0x9FD5570", VA = "0x189FD6170", Slot = "81")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public virtual int JQGITFMTKIW
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "82")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public virtual Color ZSMRNEWGTPF
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x9FD6100", Offset = "0x9FD5500", VA = "0x189FD6100", Slot = "83")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public virtual Texture GIHOJMFAUVC
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x9FD5E40", Offset = "0x9FD5240", VA = "0x189FD5E40", Slot = "84")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public virtual int XOLGSKJPEQL
		{
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public virtual Vector2 WNCWLBKSXQA
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x9FD5D40", Offset = "0x9FD5140", VA = "0x189FD5D40", Slot = "86")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public virtual double THGNEFNTVSJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public virtual Vector2 YXFSUDFDBED
		{
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x9FD6200", Offset = "0x9FD5600", VA = "0x189FD6200", Slot = "88")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public virtual int ITMPCCMWSCZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public virtual Vector3 DFDTMVYWXFW
		{
			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x9FD5DB0", Offset = "0x9FD51B0", VA = "0x189FD5DB0", Slot = "90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public virtual double GNXBQDHXMTN
		{
			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x9FD5EF0", Offset = "0x9FD52F0", VA = "0x189FD5EF0", Slot = "91")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x9FD6290", Offset = "0x9FD5690", VA = "0x189FD6290")]
		protected YEZDDHIXVKG(string a, string b, int c = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x9FD62B0", Offset = "0x9FD56B0", VA = "0x189FD62B0")]
		protected YEZDDHIXVKG(Material a, int b = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x9FD5F80", Offset = "0x9FD5380", VA = "0x189FD5F80", Slot = "60")]
		public override XCWKPVCUDXR Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class JUGTCFWXROR : YEZDDHIXVKG
	{
		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public override int LDDXQBCYEMD
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "35")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public override int VVOYLJHUPUV
		{
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public override int FLFAPXMBZAL
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "49")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public override int CJEEGMHIUSC
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "78")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public override int XOLGSKJPEQL
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x9FDD480", Offset = "0x9FDC880", VA = "0x189FDD480")]
		public JUGTCFWXROR(string a, int b = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x9FDD4F0", Offset = "0x9FDC8F0", VA = "0x189FDD4F0")]
		protected JUGTCFWXROR(Material a, int b = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x9FDD370", Offset = "0x9FDC770", VA = "0x189FDD370", Slot = "60")]
		public override XCWKPVCUDXR Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class VMVYQXBMIMH : DOYINZTHIZO, XCWKPVCUDXR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		protected Material VKHSCBVZZTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private AlphaMode CBCKMYZCYXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private double NNPOULMHNIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private Vector2 KPGKZJULNSC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private Vector2 XBFTIXAZGEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private Vector2 FAOZOTOIDAC;

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public Material UIIQDVLKWCX
		{
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public virtual Texture XVSSISCCBCU
		{
			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x9FE7720", Offset = "0x9FE6B20", VA = "0x189FE7720", Slot = "33")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x9FE6EB0", Offset = "0x9FE62B0", VA = "0x189FE6EB0", Slot = "34")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public virtual int LDDXQBCYEMD
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "35")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public virtual Vector2 ZGCBSUYXAHG
		{
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x9FE6C70", Offset = "0x9FE6070", VA = "0x189FE6C70", Slot = "36")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public virtual double IHXCESTBDWR
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "37")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public virtual Vector2 OHQAVNERGPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x9FE7020", Offset = "0x9FE6420", VA = "0x189FE7020", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public virtual int VASTYBDGDZX
		{
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "39")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public virtual double YNJIQFUKXZO
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x9FE75B0", Offset = "0x9FE69B0", VA = "0x189FE75B0", Slot = "40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public virtual Texture BHPWZUVBJCC
		{
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x9FE6D80", Offset = "0x9FE6180", VA = "0x189FE6D80", Slot = "41")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public virtual int VVOYLJHUPUV
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public virtual Vector2 OYEGYESOZBQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x9FE6A90", Offset = "0x9FE5E90", VA = "0x189FE6A90", Slot = "43")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public virtual double LVZOZDFZEXF
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "44")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public virtual Vector2 UOFEGPDEAHP
		{
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x9FE6BE0", Offset = "0x9FE5FE0", VA = "0x189FE6BE0", Slot = "45")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public virtual int PDELOPJRSKD
		{
			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "46")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		public virtual double BXSYPGLDLKB
		{
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x9FE6710", Offset = "0x9FE5B10", VA = "0x189FE6710", Slot = "47")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public virtual Texture TPBHOOPPTAM
		{
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x9FE6B00", Offset = "0x9FE5F00", VA = "0x189FE6B00", Slot = "48")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public virtual int FLFAPXMBZAL
		{
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "49")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public virtual Vector2 VCPESHDWRQE
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x9FE7540", Offset = "0x9FE6940", VA = "0x189FE7540", Slot = "50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public virtual double RCWHSFOJGRL
		{
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "51")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public virtual Vector2 OJQVLCVHVBN
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x9FE6F90", Offset = "0x9FE6390", VA = "0x189FE6F90", Slot = "52")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public virtual int GNLCRSLJGJH
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "53")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public virtual Color FVXPWTMNCKW
		{
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x9FE6CE0", Offset = "0x9FE60E0", VA = "0x189FE6CE0", Slot = "54")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x9FE7670", Offset = "0x9FE6A70", VA = "0x189FE7670", Slot = "55")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public virtual AlphaMode OIFUOCHYQZT
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x9FE70B0", Offset = "0x9FE64B0", VA = "0x189FE70B0", Slot = "56")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		public virtual double NCRNFAAGSQD
		{
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x9FE67D0", Offset = "0x9FE5BD0", VA = "0x189FE67D0", Slot = "57")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public virtual bool TQOVUOYGESA
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x9FE6E40", Offset = "0x9FE6240", VA = "0x189FE6E40", Slot = "58")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		public virtual bool SPHLBRNGTOZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x9FE7790", Offset = "0x9FE6B90", VA = "0x189FE7790", Slot = "59")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x9FE7810", Offset = "0x9FE6C10", VA = "0x189FE7810")]
		protected VMVYQXBMIMH(string a, string b, int c = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x9FE7970", Offset = "0x9FE6D70", VA = "0x189FE7970")]
		protected VMVYQXBMIMH(Material a, int b = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x9FE6860", Offset = "0x9FE5C60", VA = "0x189FE6860", Slot = "60")]
		public virtual XCWKPVCUDXR Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x9FE69F0", Offset = "0x9FE5DF0", VA = "0x189FE69F0", Slot = "61")]
		protected virtual void Copy(DOYINZTHIZO o)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public interface XCWKPVCUDXR
	{
		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		Material UIIQDVLKWCX
		{
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		AlphaMode OIFUOCHYQZT
		{
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		double NCRNFAAGSQD
		{
			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		bool TQOVUOYGESA
		{
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		bool SPHLBRNGTOZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(Slot = "5")]
		XCWKPVCUDXR Clone();
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public interface DOYINZTHIZO : XCWKPVCUDXR
	{
		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		Texture XVSSISCCBCU
		{
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		int LDDXQBCYEMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		double YNJIQFUKXZO
		{
			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		Vector2 ZGCBSUYXAHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		double IHXCESTBDWR
		{
			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		Vector2 OHQAVNERGPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		int VASTYBDGDZX
		{
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		Texture BHPWZUVBJCC
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		int VVOYLJHUPUV
		{
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FE")]
		double BXSYPGLDLKB
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FF")]
		Vector2 OYEGYESOZBQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000100")]
		double LVZOZDFZEXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000101")]
		Vector2 UOFEGPDEAHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000102")]
		int PDELOPJRSKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		Texture TPBHOOPPTAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(Slot = "15")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		int FLFAPXMBZAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(Slot = "16")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		Color FVXPWTMNCKW
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(Slot = "18")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		Vector2 VCPESHDWRQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(Slot = "19")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000107")]
		double RCWHSFOJGRL
		{
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(Slot = "20")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		Vector2 OJQVLCVHVBN
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(Slot = "21")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		int GNLCRSLJGJH
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(Slot = "22")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public interface MRGSQSRILXF : DOYINZTHIZO, XCWKPVCUDXR
	{
		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		Texture UCGPGETGTVH
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		int GHLOBOGMIZS
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		Vector2 RSLUNUVIMNH
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		double JBSXYZJGORC
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010E")]
		Vector2 RVWKJNGFXMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010F")]
		int FZMHWUCVTIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000110")]
		Color YMHAAWWQZRH
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		Texture NKWTCQIAYHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		int XFRHXUMVZYF
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		Vector2 JGVBORINFDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		double SKIASFHYBIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000115")]
		Vector2 PLPYCCHDNEZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		int REQWZNCABET
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		double MXKILPKNNGQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000118")]
		double CGEKVQSHBXV
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public interface ENUNDHZLWIP : MRGSQSRILXF, DOYINZTHIZO, XCWKPVCUDXR
	{
		[Cpp2IlInjected.Token(Token = "0x17000119")]
		double YJCRWHNMPLB
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		Texture DNSJGUYJAQL
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		Vector2 YYFOXWAXWDC
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		double KPPRGTFEIYN
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		Vector2 KDBWVLPGETN
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		int ISYUIAZSMUB
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		double TLMOPTZPBNX
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		Color SCSMPMFFMSV
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public interface CTTAZLKMCIJ : MRGSQSRILXF, DOYINZTHIZO, XCWKPVCUDXR
	{
		[Cpp2IlInjected.Token(Token = "0x17000121")]
		double BVWNVBFXBLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		Texture RCIERWOYQTT
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		Vector2 IAMVAKXBXNY
		{
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		double CNFTLECLHBV
		{
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		Vector2 KRHHCOQBBNX
		{
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		int IRLDCXHJHYD
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public interface RZNUULKKPCQ : MRGSQSRILXF, DOYINZTHIZO, XCWKPVCUDXR
	{
		[Cpp2IlInjected.Token(Token = "0x17000127")]
		float RQFAJNDAXTW
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		Color HPVKAZZIYSZ
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		Texture KFDJKFSKBSV
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		double CGYCCLFWRLV
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012B")]
		Vector2 WXBPJWDLSNQ
		{
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012C")]
		Vector2 TNTGEJFVWDL
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		int OMCWSXVIUFZ
		{
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012E")]
		Texture DLLNUBSUIRE
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012F")]
		double PNNKDKBQKMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000130")]
		Vector2 KVWIDREHOHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		Vector2 HIPQRCXCDBW
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		int EKUNWFGQRHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public interface YIPEUXEYCRJ : CTTAZLKMCIJ, MRGSQSRILXF, DOYINZTHIZO, XCWKPVCUDXR
	{
		[Cpp2IlInjected.Token(Token = "0x17000133")]
		float HKEOZDBZEEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public interface VNBDCPKVUCZ : MRGSQSRILXF, DOYINZTHIZO, XCWKPVCUDXR
	{
		[Cpp2IlInjected.Token(Token = "0x17000134")]
		double HVRTTVBPVAY
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public interface LESSVSFUXSG : MRGSQSRILXF, DOYINZTHIZO, XCWKPVCUDXR
	{
		[Cpp2IlInjected.Token(Token = "0x17000135")]
		double DFDTMVYWXFW
		{
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		Texture WTVXZPQQUUC
		{
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		Vector2 NXIIATRVJUJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		double XMBWJLPNDNS
		{
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		Vector2 YBNYJTISYNO
		{
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013A")]
		int DMNDYGNSLYI
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013B")]
		Color VEHYIRIEYWB
		{
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013C")]
		Texture WGYRZQDTHPT
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013D")]
		Vector2 YODFTCVCZZE
		{
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013E")]
		double GAVDLIJZVNZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013F")]
		Vector2 QSBJZHKKDMV
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000140")]
		int XZDWLHNNHPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public interface WNMCDZBAHYX : MRGSQSRILXF, DOYINZTHIZO, XCWKPVCUDXR
	{
		[Cpp2IlInjected.Token(Token = "0x17000141")]
		double SONZXCDXYAV
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000142")]
		double KUJSWOZUWCU
		{
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		double AAWOTOSAUQA
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		double RKPRYGFKFBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		Texture ZQSAZNBMMSJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000146")]
		Vector2 RWHCFVGAHKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		double UHVYTHRMFYD
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		Vector2 BUGVCMUVJXH
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		int GNATJUGYISH
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		Texture BKPDJQAUCTZ
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		Vector2 XXGDNUPJZDK
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		double KWHDPJVRQDL
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		Vector2 WELOZCFCWKT
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		int EDKVHFUMYWR
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public interface BLHWOZUEHFM : DOYINZTHIZO, XCWKPVCUDXR
	{
		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		Texture WRESFTJMFZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		int CJEEGMHIUSC
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		Vector2 RGZPGLQHYFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		double FTHQUJPHKGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		Vector2 IDLGWGGQXFY
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000154")]
		int JQGITFMTKIW
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000155")]
		Color ZSMRNEWGTPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		Texture GIHOJMFAUVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		int XOLGSKJPEQL
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000158")]
		Vector2 WNCWLBKSXQA
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		double THGNEFNTVSJ
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		Vector2 YXFSUDFDBED
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		int ITMPCCMWSCZ
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		Vector3 DFDTMVYWXFW
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		double GNXBQDHXMTN
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public interface FBFSTDKYMIN : MRGSQSRILXF, DOYINZTHIZO, XCWKPVCUDXR
	{
		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		double ATDFFIIDZCX
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		Texture SRJPWNOHHFR
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000160")]
		Vector2 OUCBPPJXRDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		double ZELBUMNJDTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		Vector2 GMQTLDZGCNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		int FJKQPVHNQGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		double OKJYQFQLXBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		Texture FGSXRGDCUBX
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		Vector2 SKZCALPQZUC
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		double ALCQILZEAAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000168")]
		Vector2 HSYNWYGFDRH
		{
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		int ZSDWDJFFTQD
		{
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public interface NJVIGLESUOM
	{
		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		Texture AQCRYDDWWOK
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700016B")]
		Vector2 XXZEVTCOGOF
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		double LVZHVNOZZYY
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700016D")]
		Vector2 CFBLBZEKRSE
		{
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700016E")]
		int SKZALWXAQIQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public interface WYOBAPGIYZP
	{
		[Cpp2IlInjected.Token(Token = "0x1700016F")]
		Texture OVFEDVCYNNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000170")]
		Vector2 MZQZGDDFBSS
		{
			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000171")]
		double HRINBVLHUTB
		{
			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000172")]
		Vector2 EAVVKGOGRWJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000173")]
		int NHXBEMZFDRN
		{
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000174")]
		double LSFVDRUESQT
		{
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000175")]
		double WGZNJKMDYBW
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public interface OWJJGYBXMNL : XCWKPVCUDXR
	{
		[Cpp2IlInjected.Token(Token = "0x17000176")]
		Texture UCGPGETGTVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000177")]
		int GHLOBOGMIZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000178")]
		Vector2 RSLUNUVIMNH
		{
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000179")]
		double JBSXYZJGORC
		{
			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700017A")]
		Vector2 RVWKJNGFXMQ
		{
			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700017B")]
		int FZMHWUCVTIM
		{
			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700017C")]
		Color YMHAAWWQZRH
		{
			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class DEVJAOIDRZK : MVBJQTRVRLT, OWJJGYBXMNL, XCWKPVCUDXR
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x9FDABE0", Offset = "0x9FD9FE0", VA = "0x189FDABE0")]
		public DEVJAOIDRZK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x9FDACD0", Offset = "0x9FDA0D0", VA = "0x189FDACD0")]
		protected DEVJAOIDRZK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x9FDAC70", Offset = "0x9FDA070", VA = "0x189FDAC70")]
		public DEVJAOIDRZK(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x9FDAAF0", Offset = "0x9FD9EF0", VA = "0x189FDAAF0", Slot = "10")]
		public override XCWKPVCUDXR Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class JWYUQVZMSTC : VMVYQXBMIMH, OWJJGYBXMNL, XCWKPVCUDXR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private Vector2 ORADLBHXGIV;

		[Cpp2IlInjected.Token(Token = "0x1700017D")]
		public Texture UCGPGETGTVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x9FDD570", Offset = "0x9FDC970", VA = "0x189FDD570", Slot = "62")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017E")]
		public virtual int GHLOBOGMIZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "69")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017F")]
		public virtual Vector2 RSLUNUVIMNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x9FDD660", Offset = "0x9FDCA60", VA = "0x189FDD660", Slot = "70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000180")]
		public virtual double JBSXYZJGORC
		{
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000181")]
		public virtual Vector2 RVWKJNGFXMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x9FDD5D0", Offset = "0x9FDC9D0", VA = "0x189FDD5D0", Slot = "72")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000182")]
		public virtual int FZMHWUCVTIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "73")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000183")]
		public virtual Color YMHAAWWQZRH
		{
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x9FDD500", Offset = "0x9FDC900", VA = "0x189FDD500", Slot = "74")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x9FDD6D0", Offset = "0x9FDCAD0", VA = "0x189FDD6D0")]
		public JWYUQVZMSTC(string a, string b, int c = 1000)
		{
		}
	}
}
namespace UnityGLTF.Timeline
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class RMRJQQSCXOZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000092")]
		public delegate void OnBeforeAddAnimationDataDelegate(YGMLDCDFUEO animationData);

		[Cpp2IlInjected.Token(Token = "0x2000093")]
		public delegate void OnPostExportDelegate(XXLYKRBOZVJ animationData);

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		public class XXLYKRBOZVJ
		{
			[Cpp2IlInjected.Token(Token = "0x17000186")]
			private Bounds MDCVPTLZDRU
			{
				[Cpp2IlInjected.Token(Token = "0x60003AA")]
				[Cpp2IlInjected.Address(RVA = "0x9159710", Offset = "0x9158B10", VA = "0x189159710")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000187")]
			private GLTFSceneExporter RPIBRZPZEED
			{
				[Cpp2IlInjected.Token(Token = "0x60003AB")]
				[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000188")]
			private FZUMGSVMSUT VBRVXJNQUBZ
			{
				[Cpp2IlInjected.Token(Token = "0x60003AC")]
				[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x9FE8170", Offset = "0x9FE7570", VA = "0x189FE8170")]
			internal XXLYKRBOZVJ(Bounds a, GLTFSceneExporter b, FZUMGSVMSUT c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		public class YGMLDCDFUEO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			internal AnimationData.WTLLWPZLISR GUDXVQTGPBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			public float[] NEMLOXLKKMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public object[] KYESJTZRVXC;

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0xD92220", Offset = "0xD91620", VA = "0x180D92220")]
			internal YGMLDCDFUEO(AnimationData.WTLLWPZLISR a, float[] b, object[] c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000096")]
		internal class AnimationData
		{
			[Cpp2IlInjected.Token(Token = "0x2000097")]
			internal class ZAVUGNHTDAD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000372")]
				public string BEQNIKKFMHC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000373")]
				public Type WDDTGKGVFNQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000374")]
				public Func<Transform, UnityEngine.Object> ZIQGDFKWQJR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000375")]
				public Func<Transform, UnityEngine.Object, AnimationData, object> OTKQASIOZCS;

				[Cpp2IlInjected.Token(Token = "0x60003B2")]
				[Cpp2IlInjected.Address(RVA = "0xE213F0", Offset = "0xE207F0", VA = "0x180E213F0")]
				public ZAVUGNHTDAD(string a, Type b, Func<Transform, UnityEngine.Object> c, Func<Transform, UnityEngine.Object, AnimationData, object> d)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003B3")]
				[Cpp2IlInjected.Address(RVA = "0x9FE8320", Offset = "0x9FE7720", VA = "0x189FE8320")]
				public object QJNSWFEGNRO(AnimationData a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000098")]
			internal class WTLLWPZLISR
			{
				[Cpp2IlInjected.Token(Token = "0x2000099")]
				private class QHLSPOVBDZX
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400037B")]
					public double KLHRBXIQOJV;

					[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
					[Cpp2IlInjected.Token(Token = "0x400037C")]
					public object VLFARCGJFNR;

					[Cpp2IlInjected.Token(Token = "0x60003BA")]
					[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
					public QHLSPOVBDZX()
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000376")]
				private AnimationData VPHKTLNCNIA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000377")]
				private ZAVUGNHTDAD HQXGZMDPCIF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000378")]
				private Dictionary<double, object> EZBDSZZWJEB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000379")]
				private QHLSPOVBDZX VVOCHOAWYOM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400037A")]
				private QHLSPOVBDZX PKNYCLRXSGR;

				[Cpp2IlInjected.Token(Token = "0x17000189")]
				public UnityEngine.Object UBRLADRRHTW
				{
					[Cpp2IlInjected.Token(Token = "0x60003B4")]
					[Cpp2IlInjected.Address(RVA = "0x9FE7C50", Offset = "0x9FE7050", VA = "0x189FE7C50")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018A")]
				public string BEQNIKKFMHC
				{
					[Cpp2IlInjected.Token(Token = "0x60003B5")]
					[Cpp2IlInjected.Address(RVA = "0x27AB4B0", Offset = "0x27AA8B0", VA = "0x1827AB4B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018B")]
				public float[] KBMPPFNHLKU
				{
					[Cpp2IlInjected.Token(Token = "0x60003B6")]
					[Cpp2IlInjected.Address(RVA = "0x9FE7EE0", Offset = "0x9FE72E0", VA = "0x189FE7EE0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018C")]
				public object[] KSUHZBWOOIM
				{
					[Cpp2IlInjected.Token(Token = "0x60003B7")]
					[Cpp2IlInjected.Address(RVA = "0x9FE8040", Offset = "0x9FE7440", VA = "0x189FE8040")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60003B8")]
				[Cpp2IlInjected.Address(RVA = "0x9FE80A0", Offset = "0x9FE74A0", VA = "0x189FE80A0")]
				public WTLLWPZLISR(AnimationData a, ZAVUGNHTDAD b, double c)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003B9")]
				[Cpp2IlInjected.Address(RVA = "0x9FE7C90", Offset = "0x9FE7090", VA = "0x189FE7C90")]
				public void FMRYIKWTLJT(double a)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			internal Transform VPHKTLNCNIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			private SkinnedMeshRenderer WLWIJWLIOUE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			private bool CSAVPFXQFKU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			private bool JCIAUFBUQNR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			private bool MMHMOBIMCMY;

			[Cpp2IlInjected.Token(Token = "0x400036F")]
			private static List<ZAVUGNHTDAD> HLOIHUANEWY;

			[Cpp2IlInjected.Token(Token = "0x4000370")]
			private static MaterialPropertyBlock UTWMTYVVNSP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			internal List<WTLLWPZLISR> ROZOEHJFOQK;

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x9FD9930", Offset = "0x9FD8D30", VA = "0x189FD9930")]
			public AnimationData(Transform tr, double time, bool zeroScale = false, bool recordBlendShapes = true, bool inWorldSpace = false, bool recordAnimationPointer = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x9FD9790", Offset = "0x9FD8B90", VA = "0x189FD9790")]
			public void Update(double time)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		internal ICollection<Transform> MFVRPYDDTQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private Transform XUVHPHBAVDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private Dictionary<Transform, AnimationData> LYKVCINIYGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private double DGBSZAOQHRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private double CBPDXNZTSWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		private bool MWEPTIEXNJX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		private bool ECIWIUIGPPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private readonly bool CSAVPFXQFKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private readonly bool VFHHAMBTISC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private readonly bool MMHMOBIMCMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public string PQBCBCDJUWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public OnBeforeAddAnimationDataDelegate GFTXNSRTQNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public OnPostExportDelegate VPKWYAQRPBR;

		[Cpp2IlInjected.Token(Token = "0x4000361")]
		private static ProfilerMarker BFZFYYGHETT;

		[Cpp2IlInjected.Token(Token = "0x4000362")]
		private static ProfilerMarker YRPWJZBMQEA;

		[Cpp2IlInjected.Token(Token = "0x4000363")]
		private static ProfilerMarker AFIYPTCECUB;

		[Cpp2IlInjected.Token(Token = "0x17000184")]
		public bool GFKQGBRNYBP
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x1813510", Offset = "0x1812910", VA = "0x181813510")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000185")]
		public double PLEHZDYZOZF
		{
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0xB2AF90", Offset = "0xB2A390", VA = "0x180B2AF90")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x9FE2440", Offset = "0x9FE1840", VA = "0x189FE2440")]
		public RMRJQQSCXOZ(Transform a, bool b = true, bool c = false, bool d = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x9FE20B0", Offset = "0x9FE14B0", VA = "0x189FE20B0")]
		private bool YNUMXDXZOLY(Transform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x9FE0DF0", Offset = "0x9FE01F0", VA = "0x189FE0DF0")]
		public void KHJJGVMSQBT(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x9FE1DE0", Offset = "0x9FE11E0", VA = "0x189FE1DE0")]
		public void WGKFIVYIJXI(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x9FE1700", Offset = "0x9FE0B00", VA = "0x189FE1700")]
		public void OTTVJORQGDQ(string a, string b = "scene", [Optional] GLTFSettings c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x9FE1030", Offset = "0x9FE0430", VA = "0x189FE1030")]
		public void OTTVJORQGDQ(Stream a, string b = "scene", [Optional] GLTFSettings c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x9FE2170", Offset = "0x9FE1570", VA = "0x189FE2170")]
		private void YZVDTUOCUSC(GLTFSceneExporter a, FZUMGSVMSUT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x9FE1870", Offset = "0x9FE0C70", VA = "0x189FE1870")]
		private void VRIFTCDXHDC(GLTFSceneExporter a, PTLIBJBFTSP b, bool c, [Out] Bounds d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public class GLTFRecorderBehaviour : PlayableBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class MWLHREALRTF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			public GLTFRecorderBehaviour MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			public double KLHRBXIQOJV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			public Playable KWQZIZHJXLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			public FrameData MRAZTCLTYUO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			public object CSSICAXBPPV;

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public MWLHREALRTF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x9FDE250", Offset = "0x9FDD650", VA = "0x189FDE250")]
			internal void GDPPOLMZDLY()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private RMRJQQSCXOZ LLQONLXLVRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public GLTFRecorderClip Clip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private bool WNRREXIXCDO;

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x9FDC370", Offset = "0x9FDB770", VA = "0x189FDC370")]
		private void YWQWLJPFZFQ(double a, Transform b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x9FDBCC0", Offset = "0x9FDB0C0", VA = "0x189FDBCC0")]
		private void FQMAHNOXJUB(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x9FDC130", Offset = "0x9FDB530", VA = "0x189FDC130")]
		private void QNYQFMMJTGO(double a, Transform b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0")]
		private static bool PBTOMSREBCU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x9FDBF50", Offset = "0x9FDB350", VA = "0x189FDBF50", Slot = "16")]
		public override void OnPlayableDestroy(Playable playable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x9FDBD20", Offset = "0x9FDB120", VA = "0x189FDBD20", Slot = "13")]
		public override void OnGraphStart(Playable playable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x9FDBEB0", Offset = "0x9FDB2B0", VA = "0x189FDBEB0", Slot = "14")]
		public override void OnGraphStop(Playable playable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x9FDBFF0", Offset = "0x9FDB3F0", VA = "0x189FDBFF0", Slot = "20")]
		public override void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x17534D0", Offset = "0x17528D0", VA = "0x1817534D0", Slot = "17")]
		public override void OnBehaviourPlay(Playable playable, FrameData info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x153C700", Offset = "0x153BB00", VA = "0x18153C700", Slot = "18")]
		public override void OnBehaviourPause(Playable playable, FrameData info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x9FDBB80", Offset = "0x9FDAF80", VA = "0x189FDBB80")]
		public void CAGDZHJYSCF(double a, Playable b, FrameData c, object d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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
			[Cpp2IlInjected.Address(RVA = "0xAC1F70", Offset = "0xAC1370", VA = "0x180AC1F70", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(ClipCaps);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x9FDC440", Offset = "0x9FDB840", VA = "0x189FDC440", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x9FDC550", Offset = "0x9FDB950", VA = "0x189FDC550")]
		public Transform GetExportRoot(PlayableGraph graph)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x9FDC5B0", Offset = "0x9FDB9B0", VA = "0x189FDC5B0")]
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
		private sealed class ERUTOTLORAR : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			private int JIPOOQUWCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			private object JOTWNIKQVJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public GLTFRecorderHelper MXVWDMPVVWS;

			[Cpp2IlInjected.Token(Token = "0x1700018E")]
			private object PNRLUNGDWHZ
			{
				[Cpp2IlInjected.Token(Token = "0x60003EA")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700018F")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x60003EC")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0xAB07E0", Offset = "0xAAFBE0", VA = "0x180AB07E0")]
			[DebuggerHidden]
			public ERUTOTLORAR(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "5")]
			[DebuggerHidden]
			private void AEBWHPMOWJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x9FDAE30", Offset = "0x9FDA230", VA = "0x189FDAE30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x9FDADF0", Offset = "0x9FDA1F0", VA = "0x189FDADF0", Slot = "8")]
			[DebuggerHidden]
			private void MJTKPUASZVA()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private List<Action> MSSKDIVLMJY;

		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private static GLTFRecorderHelper HEWJBQCTFXH;

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x9FDC7C0", Offset = "0x9FDBBC0", VA = "0x189FDC7C0")]
		public static void Add(Action callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x9FDC640", Offset = "0x9FDBA40", VA = "0x189FDC640")]
		private static GLTFRecorderHelper ANWCWGDECRD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x9FDCA60", Offset = "0x9FDBE60", VA = "0x189FDCA60")]
		[IteratorStateMachine(typeof(ERUTOTLORAR))]
		private IEnumerator PZXQGHTVLHN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x9FDC9E0", Offset = "0x9FDBDE0", VA = "0x189FDC9E0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x9FDCAD0", Offset = "0x9FDBED0", VA = "0x189FDCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FDCB50", Offset = "0x9FDBF50", VA = "0x189FDCB50")]
		public GLTFRecorderTrack()
		{
		}
	}
}
namespace UnityGLTF.Plugins
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	internal static class MYDKEONBHFU
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		[CompilerGenerated]
		private sealed class OFEBALTHFAS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			public int VLZOWSREXTM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			public MHJYDDFCIMV UZRSULGHOUD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			public OSDKPJWNUNL UAZMORBLYAW;

			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public OFEBALTHFAS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x9FDF960", Offset = "0x9FDED60", VA = "0x189FDF960")]
			internal float[] QZGACBKMGIB(OSDKPJWNUNL a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x9FDF8D0", Offset = "0x9FDECD0", VA = "0x189FDF8D0")]
			internal float[] QZATEUQOWWS(OSDKPJWNUNL a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x9FDF840", Offset = "0x9FDEC40", VA = "0x189FDF840")]
			internal float[] QYVMHNWRNLJ(OSDKPJWNUNL a, int b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0x9FDF7B0", Offset = "0x9FDEBB0", VA = "0x189FDF7B0")]
			internal float[] QYQFKHCUEAA(OSDKPJWNUNL a, int b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private static readonly string[] FNZVEXCGNKC;

		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private static readonly string[] IJVFCKNCAFQ;

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x9FDE3A0", Offset = "0x9FDD7A0", VA = "0x189FDE3A0")]
		internal static bool MSBQUNGPHXH(string a, PAZYSFHWSWC b, Material c, string d, WCFAQEMIIMZ e, [Out] OSDKPJWNUNL f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x9FDE920", Offset = "0x9FDDD20", VA = "0x189FDE920")]
		internal static string[] NEYKDCHIKTU(string a, int b, int c = 0, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x9FDEAD0", Offset = "0x9FDDED0", VA = "0x189FDEAD0")]
		internal static float[] OTXFMKFJBKY(int a, int b, MHJYDDFCIMV c, OSDKPJWNUNL d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class MHJYDDFCIMV
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
		public PropertyTypeOption JETPMBKSLHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public string VGKUXPVURCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public string LNDJJOZDGFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public bool VLJJEZZXPDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public CombineResultType TXGPOCAXXLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public GLTFAccessorAttributeType XZVONDIOYEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public bool JHUMDGEBWSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public bool YLJWZQBCGPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x36")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public bool HZLVQGRJPXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public float DAUYCKWFBHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public string UHGEOMJGOJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public CombinePrimaryAndSecondaryData UGHULSAHWHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private string[] NEGZNKNCDKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		internal int[] RCKVUYNFSHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		internal int[] UVROLYPMHOU;

		[Cpp2IlInjected.Token(Token = "0x17000190")]
		public string[] TAJYVWCLATT
		{
			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0xAA3370", Offset = "0xAA2770", VA = "0x180AA3370")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0x9FDDFD0", Offset = "0x9FDD3D0", VA = "0x189FDDFD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000191")]
		public bool GHVJGJXQHHD
		{
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x9FDDFB0", Offset = "0x9FDD3B0", VA = "0x189FDDFB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x9FDE000", Offset = "0x9FDD400", VA = "0x189FDE000")]
		public MHJYDDFCIMV(PropertyTypeOption a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x9FDDBA0", Offset = "0x9FDCFA0", VA = "0x189FDDBA0")]
		private void BYKGUQVYPSD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x9FDDD40", Offset = "0x9FDD140", VA = "0x189FDDD40")]
		private static float[] CFJUODZJEWO(float[] a, float[] b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x9FDDE90", Offset = "0x9FDD290", VA = "0x189FDDE90")]
		private void KDXHQFGMMUG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class PAZYSFHWSWC
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
		private Dictionary<string, MHJYDDFCIMV> TMHQCIJUHLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private Dictionary<string, MHJYDDFCIMV> FCKECHLEQRR;

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x9FDFC10", Offset = "0x9FDF010", VA = "0x189FDFC10")]
		public void BNBOJUYWWFE(string a, string[] b, [Optional] string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x9FDF9F0", Offset = "0x9FDEDF0", VA = "0x189FDF9F0")]
		public void AEEQZQZWPKJ(MHJYDDFCIMV a, ImportExportUsageOption b = ImportExportUsageOption.ImportAndExport)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x9FE04E0", Offset = "0x9FDF8E0", VA = "0x189FE04E0")]
		public bool UZDDJIFLLAY(Material a, string b, [Out] MHJYDDFCIMV c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x9FE0110", Offset = "0x9FDF510", VA = "0x189FE0110")]
		public bool NRJPDLRFEUN(Material a, string b, [Out] string c, [Out] MHJYDDFCIMV d, [Out] bool e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x9FE0700", Offset = "0x9FDFB00", VA = "0x189FE0700")]
		public PAZYSFHWSWC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public class AGEFWZOVXNZ : PAZYSFHWSWC
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x9FD66B0", Offset = "0x9FD5AB0", VA = "0x189FD66B0")]
		public AGEFWZOVXNZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public class AnimationPointerExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000192")]
		public override string DRFCVJECLED
		{
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0x9FDA8B0", Offset = "0x9FD9CB0", VA = "0x189FDA8B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000193")]
		public override string SKIARNWWPAU
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x9FDA880", Offset = "0x9FD9C80", VA = "0x189FDA880", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		public override bool IYJYHIJDDIH
		{
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x9FDA7E0", Offset = "0x9FD9BE0", VA = "0x189FDA7E0", Slot = "14")]
		public override KHHMAMVATRX CreateInstance(NKLWKJFHFKH context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x12D71D0", Offset = "0x12D65D0", VA = "0x1812D71D0")]
		public AnimationPointerExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public class UGAYRELNKMS : KHHMAMVATRX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public PAZYSFHWSWC RWNIJMKJUDA;

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x9FE3B60", Offset = "0x9FE2F60", VA = "0x189FE3B60")]
		public UGAYRELNKMS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public class AnimationPointerImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000195")]
		public override string DRFCVJECLED
		{
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x9FDA9B0", Offset = "0x9FD9DB0", VA = "0x189FDA9B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000196")]
		public override string SKIARNWWPAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x9FDA980", Offset = "0x9FD9D80", VA = "0x189FDA980", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x9FDA8E0", Offset = "0x9FD9CE0", VA = "0x189FDA8E0", Slot = "13")]
		public override ZLIAVBNTOQQ CreateInstance(NEFZNIVNFTP context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x12D71D0", Offset = "0x12D65D0", VA = "0x1812D71D0")]
		public AnimationPointerImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	public class BLUQDNUIDET : ZLIAVBNTOQQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public PAZYSFHWSWC RWNIJMKJUDA;

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x9FDA9E0", Offset = "0x9FD9DE0", VA = "0x189FDA9E0")]
		public BLUQDNUIDET()
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
		[Cpp2IlInjected.Address(RVA = "0xACEB40", Offset = "0xACDF40", VA = "0x180ACEB40")]
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
		[Cpp2IlInjected.Address(RVA = "0xACEB40", Offset = "0xACDF40", VA = "0x180ACEB40")]
		public ExperimentalPluginAttribute([Optional] string tooltip)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public abstract class GLTFExportPlugin : GLTFPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x17000197")]
		public virtual JToken TSXZAXHMMIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(Slot = "14")]
		public abstract KHHMAMVATRX CreateInstance(NKLWKJFHFKH context);

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x12D71D0", Offset = "0x12D65D0", VA = "0x1812D71D0")]
		protected GLTFExportPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public abstract class KHHMAMVATRX
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "4")]
		public virtual void PXEIMKWKIRL(GLTFSceneExporter a, FZUMGSVMSUT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "5")]
		public virtual void YVPQFSMLYHM(GLTFSceneExporter a, FZUMGSVMSUT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "6")]
		public virtual bool CLUWDMZFZRJ(GLTFSceneExporter a, FZUMGSVMSUT b, Transform c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "7")]
		public virtual void TBETSFXMOJF(GLTFSceneExporter a, FZUMGSVMSUT b, Transform c, CFDTQFFCTZU d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "8")]
		public virtual void OAMIIQWBWOK(GLTFSceneExporter a, FZUMGSVMSUT b, Transform c, CFDTQFFCTZU d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "9")]
		public virtual bool CNJGQHSQJZU(GLTFSceneExporter a, FZUMGSVMSUT b, Material c, WKXGTXFNJNI d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "10")]
		public virtual void GDBMTTLOZLJ(GLTFSceneExporter a, FZUMGSVMSUT b, Material c, WKXGTXFNJNI d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "11")]
		public virtual void JOAMAMAABMS(GLTFSceneExporter a, GLTFSceneExporter.UniqueTexture b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "12")]
		public virtual void ZQDRVUXWWAF(GLTFSceneExporter a, GLTFSceneExporter.UniqueTexture b, int c, XRKEDLFRQLY d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "13")]
		public virtual void EGGZEKNATYP(GLTFSceneExporter a, Mesh b, JRRIGPAJAOY c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "14")]
		public virtual void IQHIPRUOGHR(GLTFSceneExporter a, Mesh b, DERQUSIAPDY c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		protected KHHMAMVATRX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public abstract class GLTFImportPlugin : GLTFPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(Slot = "13")]
		public abstract ZLIAVBNTOQQ CreateInstance(NEFZNIVNFTP context);

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x12D71D0", Offset = "0x12D65D0", VA = "0x1812D71D0")]
		protected GLTFImportPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public abstract class ZLIAVBNTOQQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "4")]
		public virtual void XDPTKAVUJON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "5")]
		public virtual void FUTSGNQMQQN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "6")]
		public virtual void XURSLQCLSBA(FZUMGSVMSUT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "7")]
		public virtual void ZAOCBNJMDSL(VNYFQYNHQCR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "8")]
		public virtual void KPFXQEXJTDI(CFDTQFFCTZU a, int b, GameObject c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "9")]
		public virtual void ROSQOIQHSGX(WKXGTXFNJNI a, int b, Material c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "10")]
		public virtual void ZFAHZSVEHMN(XRKEDLFRQLY a, int b, Texture c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "11")]
		public virtual void PHFGKZZEEGS(VNYFQYNHQCR a, int b, GameObject c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		protected ZLIAVBNTOQQ()
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
		public abstract string DRFCVJECLED
		{
			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		public virtual string SKIARNWWPAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		public virtual string FNXHNQGOHDY
		{
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		public virtual bool AFDDQPQJFSL
		{
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0x9FDBB60", Offset = "0x9FDAF60", VA = "0x189FDBB60", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0xAA7380", Offset = "0xAA6780", VA = "0x180AA7380", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		public virtual bool IYJYHIJDDIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019D")]
		public virtual bool NEGROMZEEZW
		{
			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		public virtual string GAFGMYJWZZE
		{
			[Cpp2IlInjected.Token(Token = "0x6000437")]
			[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		public virtual bool SGVENYNQCMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x12D71D0", Offset = "0x12D65D0", VA = "0x1812D71D0")]
		protected GLTFPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[Obsolete("Use UnityGLTF.Plugins.GLTFPlugin instead. (UnityUpgradable) -> UnityGLTF.Plugins.GLTFPlugin")]
	public abstract class GltfPlugin : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0xBA6820", Offset = "0xBA5C20", VA = "0x180BA6820")]
		protected GltfPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[Obsolete("Use UnityGLTF.Plugins.GLTFImportPlugin instead. (UnityUpgradable) -> UnityGLTF.Plugins.GLTFImportPlugin")]
	public abstract class GltfImportPlugin : GltfPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0xBA6820", Offset = "0xBA5C20", VA = "0x180BA6820")]
		protected GltfImportPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[Obsolete("Use UnityGLTF.Plugins.GLTFExportPlugin instead. (UnityUpgradable) -> UnityGLTF.Plugins.GLTFExportPlugin")]
	public abstract class GltfExportPlugin : GltfPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0xBA6820", Offset = "0xBA5C20", VA = "0x180BA6820")]
		protected GltfExportPlugin()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public class NEFZNIVNFTP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public readonly List<ZLIAVBNTOQQ> JOZMUHJERUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public GLTFSceneImporter YDXLRONHYMQ;

		[Cpp2IlInjected.Token(Token = "0x170001A0")]
		public FZUMGSVMSUT JNBRJWHHBWC
		{
			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0x9FDF750", Offset = "0x9FDEB50", VA = "0x189FDF750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x9FDF540", Offset = "0x9FDE940", VA = "0x189FDF540")]
		private List<ZLIAVBNTOQQ> CNHAZGVDKEU(GLTFSettings a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x9FDF770", Offset = "0x9FDEB70", VA = "0x189FDF770")]
		internal NEFZNIVNFTP(GLTFSettings a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x381D870", Offset = "0x381CC70", VA = "0x18381D870")]
		public bool BDZZCDVWHMC<a>([Out] a a) where a : ZLIAVBNTOQQ
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public class DracoImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001A1")]
		public override string DRFCVJECLED
		{
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0x9FDADC0", Offset = "0x9FDA1C0", VA = "0x189FDADC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A2")]
		public override string SKIARNWWPAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0x9FDAD90", Offset = "0x9FDA190", VA = "0x189FDAD90", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A3")]
		public override bool SGVENYNQCMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x9FDAD40", Offset = "0x9FDA140", VA = "0x189FDAD40", Slot = "13")]
		public override ZLIAVBNTOQQ CreateInstance(NEFZNIVNFTP context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x12D71D0", Offset = "0x12D65D0", VA = "0x1812D71D0")]
		public DracoImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public class CLTHVSXFFAP : ZLIAVBNTOQQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public CLTHVSXFFAP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public class GPUInstancingImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001A4")]
		public override string DRFCVJECLED
		{
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0x9FDCC20", Offset = "0x9FDC020", VA = "0x189FDCC20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A5")]
		public override string SKIARNWWPAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(RVA = "0x9FDCBF0", Offset = "0x9FDBFF0", VA = "0x189FDCBF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x9FDCBA0", Offset = "0x9FDBFA0", VA = "0x189FDCBA0", Slot = "13")]
		public override ZLIAVBNTOQQ CreateInstance(NEFZNIVNFTP context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x12D71D0", Offset = "0x12D65D0", VA = "0x1812D71D0")]
		public GPUInstancingImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public class USHWUOWGNEI : ZLIAVBNTOQQ
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public USHWUOWGNEI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public class Ktx2Import : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001A6")]
		public override string DRFCVJECLED
		{
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0x9FDD8B0", Offset = "0x9FDCCB0", VA = "0x189FDD8B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A7")]
		public override string SKIARNWWPAU
		{
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0x9FDD880", Offset = "0x9FDCC80", VA = "0x189FDD880", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A8")]
		public override bool SGVENYNQCMS
		{
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x9FDD830", Offset = "0x9FDCC30", VA = "0x189FDD830", Slot = "13")]
		public override ZLIAVBNTOQQ CreateInstance(NEFZNIVNFTP context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x12D71D0", Offset = "0x12D65D0", VA = "0x1812D71D0")]
		public Ktx2Import()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public class ZDQXPYQGWWZ : ZLIAVBNTOQQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public ZDQXPYQGWWZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public class LightsPunctualExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001A9")]
		public override string DRFCVJECLED
		{
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x9FDD960", Offset = "0x9FDCD60", VA = "0x189FDD960", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		public override string SKIARNWWPAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0x9FDD930", Offset = "0x9FDCD30", VA = "0x189FDD930", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x9FDD8E0", Offset = "0x9FDCCE0", VA = "0x189FDD8E0", Slot = "14")]
		public override KHHMAMVATRX CreateInstance(NKLWKJFHFKH context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x12D71D0", Offset = "0x12D65D0", VA = "0x1812D71D0")]
		public LightsPunctualExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public class CGXDQDJWQDY : KHHMAMVATRX
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "8")]
		public override void OAMIIQWBWOK(GLTFSceneExporter a, FZUMGSVMSUT b, Transform c, CFDTQFFCTZU d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public CGXDQDJWQDY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public class LightsPunctualImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		public override string DRFCVJECLED
		{
			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0x9FDDA10", Offset = "0x9FDCE10", VA = "0x189FDDA10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public override string SKIARNWWPAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0x9FDD9E0", Offset = "0x9FDCDE0", VA = "0x189FDD9E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x9FDD990", Offset = "0x9FDCD90", VA = "0x189FDD990", Slot = "13")]
		public override ZLIAVBNTOQQ CreateInstance(NEFZNIVNFTP context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x12D71D0", Offset = "0x12D65D0", VA = "0x1812D71D0")]
		public LightsPunctualImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public class PMABYKZNOEL : ZLIAVBNTOQQ
	{
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public PMABYKZNOEL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[NonRatifiedPlugin(null)]
	public class LodsExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		public override string DRFCVJECLED
		{
			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0x9FDDAC0", Offset = "0x9FDCEC0", VA = "0x189FDDAC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		public override string SKIARNWWPAU
		{
			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0x9FDDA90", Offset = "0x9FDCE90", VA = "0x189FDDA90", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x9FDDA40", Offset = "0x9FDCE40", VA = "0x189FDDA40", Slot = "14")]
		public override KHHMAMVATRX CreateInstance(NKLWKJFHFKH context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x12D71D0", Offset = "0x12D65D0", VA = "0x1812D71D0")]
		public LodsExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public class PUFOLZJIUDZ : KHHMAMVATRX
	{
		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x9FE08C0", Offset = "0x9FDFCC0", VA = "0x189FE08C0", Slot = "8")]
		public override void OAMIIQWBWOK(GLTFSceneExporter a, FZUMGSVMSUT b, Transform c, CFDTQFFCTZU d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public PUFOLZJIUDZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[NonRatifiedPlugin(null)]
	public class LodsImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		public override string DRFCVJECLED
		{
			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0x9FDDB70", Offset = "0x9FDCF70", VA = "0x189FDDB70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		public override string SKIARNWWPAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0x9FDDB40", Offset = "0x9FDCF40", VA = "0x189FDDB40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x9FDDAF0", Offset = "0x9FDCEF0", VA = "0x189FDDAF0", Slot = "13")]
		public override ZLIAVBNTOQQ CreateInstance(NEFZNIVNFTP context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x12D71D0", Offset = "0x12D65D0", VA = "0x1812D71D0")]
		public LodsImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public class ULVHLZFVLSW : ZLIAVBNTOQQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public ULVHLZFVLSW()
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
		public override string DRFCVJECLED
		{
			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0x9FDF380", Offset = "0x9FDE780", VA = "0x189FDF380", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		public override string SKIARNWWPAU
		{
			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0x9FDF350", Offset = "0x9FDE750", VA = "0x189FDF350", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x9FDF2D0", Offset = "0x9FDE6D0", VA = "0x189FDF2D0", Slot = "14")]
		public override KHHMAMVATRX CreateInstance(NKLWKJFHFKH context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x9FDF330", Offset = "0x9FDE730", VA = "0x189FDF330")]
		public MaterialExtensionsExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public class UKHYLOFVBTA : KHHMAMVATRX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		internal readonly MaterialExtensionsExport NJRVEUBYIBB;

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private static readonly int GVEXLYUNMMD;

		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private static readonly int HGUYMKRSFDJ;

		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private static readonly int ADRTXJESRZX;

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private static readonly int YXWLLRDOBEF;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private static readonly int BNYKOGLTVKU;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private static readonly int MKCVUZBKHHH;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private static readonly int JTVYDRYBLVL;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private static readonly int GFPQSUQRFNK;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private static readonly int OIXSUBQZNWF;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private static readonly int ZMTRUPOGQMI;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private static readonly int VQSPUPOENTO;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private static readonly int PAHPZWZOVXQ;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private static readonly int OLIRBYHPFYR;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private static readonly int ZAHBLGUYTQD;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private static readonly int VCQEOKPZDCM;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private static readonly int HWUMCMYJOBD;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private static readonly int EOOXLQZJLFU;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private static readonly int JIQFDKCTEOJ;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private static readonly int FERKJTISIIH;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private static readonly int IMREMOMPBAL;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private static readonly int FNSLDJUGJFD;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private static readonly int LCYDYFBQBHX;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private static readonly int RTZLMCBOXJI;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private static readonly int BCQHJINSZTL;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private static readonly int EEZVDRJLUJO;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private static readonly int DJZNWQITZOV;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private static readonly int CRVKEGKHUUO;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private static readonly int LSFVDRUESQT;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private static readonly int WGZNJKMDYBW;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private static readonly int OVFEDVCYNNH;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		public UKHYLOFVBTA(MaterialExtensionsExport a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x9FE3BD0", Offset = "0x9FE2FD0", VA = "0x189FE3BD0", Slot = "10")]
		public override void GDBMTTLOZLJ(GLTFSceneExporter a, FZUMGSVMSUT b, Material c, WKXGTXFNJNI d)
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
		public override string DRFCVJECLED
		{
			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0x9FDF460", Offset = "0x9FDE860", VA = "0x189FDF460", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		public override string SKIARNWWPAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0x9FDF430", Offset = "0x9FDE830", VA = "0x189FDF430", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x9FDF3B0", Offset = "0x9FDE7B0", VA = "0x189FDF3B0", Slot = "13")]
		public override ZLIAVBNTOQQ CreateInstance(NEFZNIVNFTP context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x9FDF410", Offset = "0x9FDE810", VA = "0x189FDF410")]
		public MaterialExtensionsImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public class BQBPXXOPULB : ZLIAVBNTOQQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		internal readonly MaterialExtensionsImport NJRVEUBYIBB;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		public BQBPXXOPULB(MaterialExtensionsImport a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public class MeshoptImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		public override string DRFCVJECLED
		{
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0x9FDF510", Offset = "0x9FDE910", VA = "0x189FDF510", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public override string SKIARNWWPAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x9FDF4E0", Offset = "0x9FDE8E0", VA = "0x189FDF4E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		public override bool SGVENYNQCMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x9FDF490", Offset = "0x9FDE890", VA = "0x189FDF490", Slot = "13")]
		public override ZLIAVBNTOQQ CreateInstance(NEFZNIVNFTP context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x12D71D0", Offset = "0x12D65D0", VA = "0x1812D71D0")]
		public MeshoptImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public class TYCZLKQTKRW : ZLIAVBNTOQQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public TYCZLKQTKRW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public class TextureTransformExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001B8")]
		public override string DRFCVJECLED
		{
			[Cpp2IlInjected.Token(Token = "0x600047A")]
			[Cpp2IlInjected.Address(RVA = "0x9FE25F0", Offset = "0x9FE19F0", VA = "0x189FE25F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B9")]
		public override string SKIARNWWPAU
		{
			[Cpp2IlInjected.Token(Token = "0x600047B")]
			[Cpp2IlInjected.Address(RVA = "0x9FE25C0", Offset = "0x9FE19C0", VA = "0x189FE25C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		public override bool NEGROMZEEZW
		{
			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "14")]
		public override KHHMAMVATRX CreateInstance(NKLWKJFHFKH context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x12D71D0", Offset = "0x12D65D0", VA = "0x1812D71D0")]
		public TextureTransformExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public class TextureTransformImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001BB")]
		public override string DRFCVJECLED
		{
			[Cpp2IlInjected.Token(Token = "0x600047F")]
			[Cpp2IlInjected.Address(RVA = "0x9FE2650", Offset = "0x9FE1A50", VA = "0x189FE2650", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		public override string SKIARNWWPAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000480")]
			[Cpp2IlInjected.Address(RVA = "0x9FE2620", Offset = "0x9FE1A20", VA = "0x189FE2620", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		public override bool NEGROMZEEZW
		{
			[Cpp2IlInjected.Token(Token = "0x6000481")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "13")]
		public override ZLIAVBNTOQQ CreateInstance(NEFZNIVNFTP context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x12D71D0", Offset = "0x12D65D0", VA = "0x1812D71D0")]
		public TextureTransformImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public class UnlitMaterialsExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001BE")]
		public override string DRFCVJECLED
		{
			[Cpp2IlInjected.Token(Token = "0x6000484")]
			[Cpp2IlInjected.Address(RVA = "0x9FE6560", Offset = "0x9FE5960", VA = "0x189FE6560", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		public override string SKIARNWWPAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000485")]
			[Cpp2IlInjected.Address(RVA = "0x9FE6530", Offset = "0x9FE5930", VA = "0x189FE6530", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		public override bool NEGROMZEEZW
		{
			[Cpp2IlInjected.Token(Token = "0x6000486")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "14")]
		public override KHHMAMVATRX CreateInstance(NKLWKJFHFKH context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x12D71D0", Offset = "0x12D65D0", VA = "0x1812D71D0")]
		public UnlitMaterialsExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public class UnlitMaterialsImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001C1")]
		public override string DRFCVJECLED
		{
			[Cpp2IlInjected.Token(Token = "0x6000489")]
			[Cpp2IlInjected.Address(RVA = "0x9FE65C0", Offset = "0x9FE59C0", VA = "0x189FE65C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C2")]
		public override string SKIARNWWPAU
		{
			[Cpp2IlInjected.Token(Token = "0x600048A")]
			[Cpp2IlInjected.Address(RVA = "0x9FE6590", Offset = "0x9FE5990", VA = "0x189FE6590", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C3")]
		public override bool NEGROMZEEZW
		{
			[Cpp2IlInjected.Token(Token = "0x600048B")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "13")]
		public override ZLIAVBNTOQQ CreateInstance(NEFZNIVNFTP context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x12D71D0", Offset = "0x12D65D0", VA = "0x1812D71D0")]
		public UnlitMaterialsImport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public class VisibilityExport : GLTFExportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		public override string DRFCVJECLED
		{
			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0x9FE7AC0", Offset = "0x9FE6EC0", VA = "0x189FE7AC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		public override string SKIARNWWPAU
		{
			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0x9FE7A90", Offset = "0x9FE6E90", VA = "0x189FE7A90", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		public override bool NEGROMZEEZW
		{
			[Cpp2IlInjected.Token(Token = "0x6000490")]
			[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		public override bool IYJYHIJDDIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "14")]
		public override KHHMAMVATRX CreateInstance(NKLWKJFHFKH context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x12D71D0", Offset = "0x12D65D0", VA = "0x1812D71D0")]
		public VisibilityExport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public class VisibilityImport : GLTFImportPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		public override string DRFCVJECLED
		{
			[Cpp2IlInjected.Token(Token = "0x6000494")]
			[Cpp2IlInjected.Address(RVA = "0x9FE7B20", Offset = "0x9FE6F20", VA = "0x189FE7B20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		public override string SKIARNWWPAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000495")]
			[Cpp2IlInjected.Address(RVA = "0x9FE7AF0", Offset = "0x9FE6EF0", VA = "0x189FE7AF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CA")]
		public override bool NEGROMZEEZW
		{
			[Cpp2IlInjected.Token(Token = "0x6000496")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "13")]
		public override ZLIAVBNTOQQ CreateInstance(NEFZNIVNFTP context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x12D71D0", Offset = "0x12D65D0", VA = "0x1812D71D0")]
		public VisibilityImport()
		{
		}
	}
}
namespace UnityGLTF.Loader
{
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public class JYSOZZQIENB
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
	public interface MYLULKZASJQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Stream> MUVCCXHWBSK(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public interface NBTPTIGRVVC : MYLULKZASJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Stream EJNCHJRRJVA(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[Obsolete("Please switch to IDataLoader.  This interface is deprecated and will be removed in a future release.")]
	public interface QYHPHOAMODM
	{
		[Cpp2IlInjected.Token(Token = "0x170001CB")]
		Stream URSNMNJWKSD
		{
			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		bool XHTCEUGFNEA
		{
			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task EJNCHJRRJVA(string a);

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void WSAEUAEAJHD(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	public static class PBNEOPBJYTX
	{
		[Cpp2IlInjected.Token(Token = "0x20000DC")]
		private class VKWWMRBZGBQ : MYLULKZASJQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000405")]
			protected readonly QYHPHOAMODM UJYLNLHSTHO;

			[Cpp2IlInjected.Token(Token = "0x60004A0")]
			[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
			public VKWWMRBZGBQ(QYHPHOAMODM a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A1")]
			[Cpp2IlInjected.Address(RVA = "0x9FE65F0", Offset = "0x9FE59F0", VA = "0x189FE65F0", Slot = "4")]
			public Task<Stream> MUVCCXHWBSK(string a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000DD")]
		private class YUCPFUORIZG : VKWWMRBZGBQ, NBTPTIGRVVC, MYLULKZASJQ
		{
			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
			public YUCPFUORIZG(QYHPHOAMODM a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0x9FE8240", Offset = "0x9FE7640", VA = "0x189FE8240", Slot = "5")]
			public Stream EJNCHJRRJVA(string a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x9FE07B0", Offset = "0x9FDFBB0", VA = "0x189FE07B0")]
		public static MYLULKZASJQ RLAAHPQYVGK(QYHPHOAMODM a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public class QOSOTHYNLED : MYLULKZASJQ
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
			public QOSOTHYNLED <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x9FE2680", Offset = "0x9FE1A80", VA = "0x189FE2680", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0x9FE2C60", Offset = "0x9FE2060", VA = "0x189FE2C60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		private string LMEIQGHTKCR;

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		public QOSOTHYNLED(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x9FE0CC0", Offset = "0x9FE00C0", VA = "0x189FE0CC0", Slot = "4")]
		[AsyncStateMachine(typeof(<LoadStreamAsync>d__2))]
		public Task<Stream> MUVCCXHWBSK(string a)
		{
			return null;
		}
	}
}
namespace UnityGLTF.Extensions
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public class FNIBNPHGBPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private readonly List<KHR_animation_pointer> KABYSANMSXI;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private static readonly ProfilerMarker YLIBNDXPSAB;

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x9FDB060", Offset = "0x9FDA460", VA = "0x189FDB060")]
		public void Add(KHR_animation_pointer anim)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x9FDB110", Offset = "0x9FDA510", VA = "0x189FDB110")]
		public void ZJSVSRYAXBI(GLTFSceneExporter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x9FDBAE0", Offset = "0x9FDAEE0", VA = "0x189FDBAE0")]
		public FNIBNPHGBPL()
		{
		}
	}
}
namespace UnityGLTF.JsonPointer
{
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public interface RRYCSCAUSGO
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool VPAVAFCZPXX(object a, string b);
	}
}
namespace UnityGLTF.Cache
{
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	public struct AnimationSamplerCacheData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public WCFAQEMIIMZ Input;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public WCFAQEMIIMZ Output;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public InterpolationType Interpolation;
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public class YBXZZMCYPGO
	{
		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		public AnimationClip TSGDIHXTJHP
		{
			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		public AnimationSamplerCacheData[] HCGECLGAZPB
		{
			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x9FE81E0", Offset = "0x9FE75E0", VA = "0x189FE81E0")]
		public YBXZZMCYPGO(int a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public class ZVGYAWFIQVG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		public Stream[] ZKPOIBSBQAH
		{
			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		public Texture2D[] UDSZLEZHSQX
		{
			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D1")]
		public Texture2D[] UGLZGDKVUSE
		{
			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		public BUQSFKRWQAB[] ZBJPVATIKJP
		{
			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		public WNNQVCCVEFF[] FJTAYCYTTYD
		{
			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		public VKHNVDPDWUK[] REZUZHKNWIS
		{
			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0xAAA110", Offset = "0xAA9510", VA = "0x180AAA110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		public ZGBHUJWMFFN[] QCMOZDFHZPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0xAAA840", Offset = "0xAA9C40", VA = "0x180AAA840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		public ZOWJCSGELOO[] KTZGNDLXZSE
		{
			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0xAAA870", Offset = "0xAA9C70", VA = "0x180AAA870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public YBXZZMCYPGO[] ALCWUVOJRYK
		{
			[Cpp2IlInjected.Token(Token = "0x60004C2")]
			[Cpp2IlInjected.Address(RVA = "0xAA3370", Offset = "0xAA2770", VA = "0x180AA3370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C3")]
			[Cpp2IlInjected.Address(RVA = "0xAA3390", Offset = "0xAA2790", VA = "0x180AA3390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		public GameObject[] XCSQKZCBVEE
		{
			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C5")]
			[Cpp2IlInjected.Address(RVA = "0xAA33A0", Offset = "0xAA27A0", VA = "0x180AA33A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x9FE85C0", Offset = "0x9FE79C0", VA = "0x189FE85C0")]
		public ZVGYAWFIQVG(FZUMGSVMSUT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x9FE84B0", Offset = "0x9FE78B0", VA = "0x189FE84B0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public class VKHNVDPDWUK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		public uint LTVUXGFUSKM
		{
			[Cpp2IlInjected.Token(Token = "0x60004C8")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		public Stream ENAXDINYOJM
		{
			[Cpp2IlInjected.Token(Token = "0x60004CA")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004CB")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		public NativeArray<byte> MKXTZJAAAVO
		{
			[Cpp2IlInjected.Token(Token = "0x60004CC")]
			[Cpp2IlInjected.Address(RVA = "0xBB85E0", Offset = "0xBB79E0", VA = "0x180BB85E0")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x60004CD")]
			[Cpp2IlInjected.Address(RVA = "0xC99FF0", Offset = "0xC993F0", VA = "0x180C99FF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x716F420", Offset = "0x716E820", VA = "0x18716F420", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public VKHNVDPDWUK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	internal static class KZPOSZYWPKO
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0xC7AF10", Offset = "0xC7A310", VA = "0x180C7AF10")]
		public static bool EKGJJXNWGMY(UnityEngine.Object a, string b, [Out] byte[] c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void ZGSZZLKZKZC(UnityEngine.Object a, string b, byte[] c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	public class WNNQVCCVEFF : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		public Material LBUHUGKTGQK
		{
			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		public Material VRIMIFXELPZ
		{
			[Cpp2IlInjected.Token(Token = "0x60004D4")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		public WKXGTXFNJNI WKXGTXFNJNI
		{
			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x9FE7B50", Offset = "0x9FE6F50", VA = "0x189FE7B50", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public WNNQVCCVEFF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public class ZGBHUJWMFFN : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		public class AIHVYAIFZVR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			public bool VVDVHQQWOLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000429")]
			public Dictionary<string, WCFAQEMIIMZ> TLFJOOEAPRF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042A")]
			public List<Dictionary<string, WCFAQEMIIMZ>> WSWWGRSUBLS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			public Dictionary<string, (WCFAQEMIIMZ sparseIndices, WCFAQEMIIMZ sparseValues)> ERPZSBNZWVU;

			[Cpp2IlInjected.Token(Token = "0x60004DD")]
			[Cpp2IlInjected.Address(RVA = "0x9FD9670", Offset = "0x9FD8A70", VA = "0x189FD9670")]
			public AIHVYAIFZVR()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public List<AIHVYAIFZVR> SCAGWIAUUXK;

		[Cpp2IlInjected.Token(Token = "0x170001DF")]
		public Mesh JRZDPWCDFCS
		{
			[Cpp2IlInjected.Token(Token = "0x60004D9")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004DA")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x9FE8390", Offset = "0x9FE7790", VA = "0x189FE8390", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x9FE8430", Offset = "0x9FE7830", VA = "0x189FE8430")]
		public ZGBHUJWMFFN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	public class HLEREIEYUIT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private bool CHQGPKPZUBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private int WCUFYOGXTMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private readonly object WITAHWQKSCQ;

		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		public ZGBHUJWMFFN[] QCMOZDFHZPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60004DE")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004DF")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		public UnityEngine.Object[] CAYKCVBAJVA
		{
			[Cpp2IlInjected.Token(Token = "0x60004E0")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E1")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		public WNNQVCCVEFF[] FJTAYCYTTYD
		{
			[Cpp2IlInjected.Token(Token = "0x60004E2")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E3")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		public BUQSFKRWQAB[] ZBJPVATIKJP
		{
			[Cpp2IlInjected.Token(Token = "0x60004E4")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E5")]
			[Cpp2IlInjected.Address(RVA = "0xAAA110", Offset = "0xAA9510", VA = "0x180AAA110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		public YBXZZMCYPGO[] ALCWUVOJRYK
		{
			[Cpp2IlInjected.Token(Token = "0x60004E6")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E7")]
			[Cpp2IlInjected.Address(RVA = "0xAAA840", Offset = "0xAA9C40", VA = "0x180AAA840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		public Texture2D[] UDSZLEZHSQX
		{
			[Cpp2IlInjected.Token(Token = "0x60004E8")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E9")]
			[Cpp2IlInjected.Address(RVA = "0xAAA870", Offset = "0xAA9C70", VA = "0x180AAA870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x9FDD270", Offset = "0x9FDC670", VA = "0x189FDD270")]
		public HLEREIEYUIT(WNNQVCCVEFF[] a, ZGBHUJWMFFN[] b, BUQSFKRWQAB[] c, Texture2D[] d, YBXZZMCYPGO[] e, UnityEngine.Object[] f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x9FDD190", Offset = "0x9FDC590", VA = "0x189FDD190")]
		public void PYGLNYEZRYC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x9FDD040", Offset = "0x9FDC440", VA = "0x189FDD040")]
		public void IDHTCAXLGZE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x9FDCC50", Offset = "0x9FDC050", VA = "0x189FDCC50")]
		private void IBACVOOPWKW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public class BUQSFKRWQAB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public XRKEDLFRQLY BBKUHENLMHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public Texture2D WAUEOSCTHAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public bool LNJPOFTZVIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public bool SYHGKNQRNNT;

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x9FDAA50", Offset = "0x9FD9E50", VA = "0x189FDAA50", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public BUQSFKRWQAB()
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
