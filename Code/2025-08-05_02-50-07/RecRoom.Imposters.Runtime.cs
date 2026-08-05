using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.Core.DataStructures;
using RecRoom.Core.Imposters;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class DeferredImposterSpawnManager : SingletonMonoBehaviour<DeferredImposterSpawnManager>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private readonly struct EGINDGNALFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly ICJFMEFDKNE AENGEIHDIAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string OPFNAEKCLPK;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xBFDA60", Offset = "0xBFCE60", VA = "0x180BFDA60")]
		public EGINDGNALFK(ICJFMEFDKNE GHIHPLFNCKD, string IEFGJLNKNBK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct DMNKMFPKOGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public EGINDGNALFK queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x82E6450", Offset = "0x82E5850", VA = "0x1882E6450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x82E6810", Offset = "0x82E5C10", VA = "0x1882E6810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider DDHEJNBGBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private KOKOAANOAGE<EGINDGNALFK, GameObject> MMBJMOIEPOA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public FFCDNLMOGCB CHDKCEEAGPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private KOKOAANOAGE<EGINDGNALFK, GameObject> DIJCEBOHBMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x82E74C0", Offset = "0x82E68C0", VA = "0x1882E74C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int DIKODEFCNNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x82E7620", Offset = "0x82E6A20", VA = "0x1882E7620")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x82E72C0", Offset = "0x82E66C0", VA = "0x1882E72C0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x82E7830", Offset = "0x82E6C30", VA = "0x1882E7830", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x82E73A0", Offset = "0x82E67A0", VA = "0x1882E73A0")]
	[AsyncStateMachine(typeof(DMNKMFPKOGI))]
	private Task<GameObject> GBPPGOPEIIB(EGINDGNALFK ABBOFKGFAFJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x82E7670", Offset = "0x82E6A70", VA = "0x1882E7670")]
	public Task<GameObject> LoadItemAsync(ICJFMEFDKNE GHIHPLFNCKD, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x82E78A0", Offset = "0x82E6CA0", VA = "0x1882E78A0")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class APCGLPNGFJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public ICJFMEFDKNE HJKLLFGBKOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture HGHKHPLOOBG;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA7A690", Offset = "0xA79A90", VA = "0x180A7A690")]
		public APCGLPNGFJF(ICJFMEFDKNE LGIHGPGNAAN, Texture IOFLDLKHGCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum ECDHAONFJPC
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Custom = 0,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		XS_128 = 0x80,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		S_256 = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		M_512 = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		L_1024 = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		XL_2048 = 0x800
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class EGCGBJNPLAP : POHFLPAEANN<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct IACGFBIMLMP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public EGCGBJNPLAP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x82E7CA0", Offset = "0x82E70A0", VA = "0x1882E7CA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x82E8490", Offset = "0x82E7890", VA = "0x1882E8490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly ICJFMEFDKNE LGIHGPGNAAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture PAABFJFKFJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig BCJKFCDKOOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken GMKBGHHNCDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D DNDGCAFIPMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject AAJNMFDMKBL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override FHMCAMOMJOP<Texture2D> LCACPCNKDPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x82E7A80", Offset = "0x82E6E80", VA = "0x1882E7A80", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> NMFCLADFKMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x82E7AE0", Offset = "0x82E6EE0", VA = "0x1882E7AE0")]
		public EGCGBJNPLAP(ICJFMEFDKNE LGIHGPGNAAN, RenderTexture PAABFJFKFJA, ImposterRenderConfig BCJKFCDKOOG, CancellationToken GMKBGHHNCDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x82E7960", Offset = "0x82E6D60", VA = "0x1882E7960")]
		[AsyncStateMachine(typeof(IACGFBIMLMP))]
		private Task<Texture2D> CPCGPHPDDPP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x82E7A50", Offset = "0x82E6E50", VA = "0x1882E7A50", Slot = "10")]
		protected override void DOACBKHCKFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x82E78E0", Offset = "0x82E6CE0", VA = "0x1882E78E0")]
		private static void BDFLPDAABFN(GameObject AAJNMFDMKBL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct BCDKPOGOONN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public ImposterRawImage <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<Texture2D> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x82E5AC0", Offset = "0x82E4EC0", VA = "0x1882E5AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xAC9F20", Offset = "0xAC9320", VA = "0x180AC9F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[SerializeField]
	[Header("General")]
	[Tooltip("Texture shown when the imposter texture is not available")]
	private Texture defaultTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[BNCHLJBJHLJ(FIPBCJPBODB.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private ECDHAONFJPC size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[GKAGFGDDNKD("size", ECDHAONFJPC.Custom)]
	[SerializeField]
	private int customSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[SerializeField]
	private int antiAliasing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[Tooltip("Configuration specifying render properties for the imposter")]
	[SerializeField]
	private ImposterRenderConfig imposterRenderConfig;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static int MENJGIIGIJM;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture MIEMDGCMBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private OIMJGCFNANM<GameObject> JPMEBOEKFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private BENMIFMGNEN MKLKICBNNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource HAGAAAKNION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private JAKNEJKGEIC<Texture2D> MPCDLLCNDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private ICJFMEFDKNE ACHBDDIBLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture EDDALJKLLPH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int NCKNJEJKENL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x82E94E0", Offset = "0x82E88E0", VA = "0x1882E94E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x82E9530", Offset = "0x82E8930", VA = "0x1882E9530")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture BBDJJGAPIKO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x82E8EE0", Offset = "0x82E82E0", VA = "0x1882E8EE0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA70180", Offset = "0xA6F580", VA = "0x180A70180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private ICJFMEFDKNE HJKLLFGBKOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA70440", Offset = "0xA6F840", VA = "0x180A70440")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x82E8C20", Offset = "0x82E8020", VA = "0x1882E8C20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool PKBDADMPNHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x24B64C0", Offset = "0x24B58C0", VA = "0x1824B64C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int LEGOCHKKFEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x82E8AB0", Offset = "0x82E7EB0", VA = "0x1882E8AB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x82E8B50", Offset = "0x82E7F50", VA = "0x1882E8B50")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x82E90C0", Offset = "0x82E84C0", VA = "0x1882E90C0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x82E8E60", Offset = "0x82E8260", VA = "0x1882E8E60")]
	private void KBOELODBJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x82E93C0", Offset = "0x82E87C0", VA = "0x1882E93C0")]
	public void Set(ICJFMEFDKNE GBPJGNEIOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x82E93B0", Offset = "0x82E87B0", VA = "0x1882E93B0")]
	public void Set(Texture IOFLDLKHGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x82E93D0", Offset = "0x82E87D0", VA = "0x1882E93D0")]
	public void Set(APCGLPNGFJF CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x82E8B60", Offset = "0x82E7F60", VA = "0x1882E8B60")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x82E91C0", Offset = "0x82E85C0", VA = "0x1882E91C0")]
	public void SetInternal(ICJFMEFDKNE GBPJGNEIOML, [Optional] Texture KFNEFIDMFEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x82E91B0", Offset = "0x82E85B0", VA = "0x1882E91B0")]
	public void SetCustomSize(int EJLDDCLKDFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xA7BA10", Offset = "0xA7AE10", VA = "0x180A7BA10")]
	public void SetAntiAliasing(int HJJEDJDLGCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x82E8B70", Offset = "0x82E7F70", VA = "0x1882E8B70")]
	[AsyncStateMachine(typeof(BCDKPOGOONN))]
	private void FAMINHMAALD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x82E8D80", Offset = "0x82E8180", VA = "0x1882E8D80")]
	private void GBNDICBDGNE(Texture IOFLDLKHGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x82E9460", Offset = "0x82E8860", VA = "0x1882E9460")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, DJADNNMHOGE
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float PILGCMAGIPP = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void PrepareImposter(OAJAKDOALFG FGEMBJJOPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x82E8A70", Offset = "0x82E7E70", VA = "0x1882E8A70")]
	public void SetReferencePoint(Vector3 IPGNGMJBFOL, Quaternion JJPOMEGMBHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x82E8880", Offset = "0x82E7C80", VA = "0x1882E8880")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x82E8A50", Offset = "0x82E7E50", VA = "0x1882E8A50")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x20FFF90", Offset = "0x20FF390", VA = "0x1820FFF90")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct AKNFIBKAFPE
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static AKNFIBKAFPE LIMJHLEGHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float EICIKOGEICJ;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2CEA450", Offset = "0x2CE9850", VA = "0x182CEA450")]
	public AKNFIBKAFPE(float EMGNFMDONDI)
	{
	}
}
namespace _AssemblyRegistry.RecRoom_Imposters_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x82EDC10", Offset = "0x82ED010", VA = "0x1882EDC10", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x291FE80", Offset = "0x291F280", VA = "0x18291FE80")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class IncreaseTransparentRenderQueueWhenInUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		[BNCHLJBJHLJ(FIPBCJPBODB.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int CPBKPDDEOGD = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int BMBHCGINAGL = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> PGIGJGJAGFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool HENFBDHJCEG;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x82E9750", Offset = "0x82E8B50", VA = "0x1882E9750")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x82E9650", Offset = "0x82E8A50", VA = "0x1882E9650")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x82E99A0", Offset = "0x82E8DA0", VA = "0x1882E99A0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ICJFMEFDKNE
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string EPFIMIPJANO
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	AKNFIBKAFPE AKNFIBKAFPE
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action NMDIIDPGNJK;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> NCJGFECLNHD(CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MAELHOLHIPG(ICJFMEFDKNE LHDOHAKINKP);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FMMMHKBFEDO();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HKHGBNDEJFC();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool IGACDCNGKMM(uint? CJDDBDMCINC, [Out] JAKNEJKGEIC<Texture2D> CIANAHMNBKH);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class LKFPFPGHFHB
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x82EC380", Offset = "0x82EB780", VA = "0x1882EC380")]
	public static bool DOCJFCNFFCP(ICJFMEFDKNE IIHLLNBHNLJ, ICJFMEFDKNE GKHHJKFDCKM)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, DJADNNMHOGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x82E6300", Offset = "0x82E5700", VA = "0x1882E6300", Slot = "4")]
		public void PrepareImposter(OAJAKDOALFG FGEMBJJOPFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED60", Offset = "0xA6E160", VA = "0x180A6ED60")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED60", Offset = "0xA6E160", VA = "0x180A6ED60")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface DJADNNMHOGE
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(OAJAKDOALFG FGEMBJJOPFK);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface ENGJCKHOBOK
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> GFFMLNNPDBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> KDOEAOMAABP
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface FFCDNLMOGCB
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJGHGLPKMFA(params Type[] LOJIBMFABIA);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T BPNLGECPCAL<T>(T MKFMLBCIMEB, Transform JIECBJMGMAC, bool MNPLANNPPHB = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T BPNLGECPCAL<T>(GameObject MKFMLBCIMEB, Transform JIECBJMGMAC, bool MNPLANNPPHB = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GameObject BPNLGECPCAL(GameObject MKFMLBCIMEB, Transform JIECBJMGMAC, OAJAKDOALFG FGEMBJJOPFK, bool MNPLANNPPHB);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class OAFCFFFFLMC : IDisposable, FFCDNLMOGCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> ILABJOKNPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> EEPHMDHLLAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform NLHKHBCDOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> OGFKDDMNHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> NCILGLBKLOH;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x82EC710", Offset = "0x82EBB10", VA = "0x1882EC710")]
	[MKODAOGKIAA.PMDGGDAFIAI]
	public static void EMILKHFAJPJ(JFAGCPCLAAF MNCIANLLPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x82ED4C0", Offset = "0x82EC8C0", VA = "0x1882ED4C0")]
	[UnityEngine.Scripting.Preserve]
	public OAFCFFFFLMC([PKIHAALFADL(null)] ENGJCKHOBOK DGMGLJMGMGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x82EC630", Offset = "0x82EBA30", VA = "0x1882EC630", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x82ED470", Offset = "0x82EC870", VA = "0x1882ED470", Slot = "5")]
	public void PJGHGLPKMFA(params Type[] LOJIBMFABIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3E85300", Offset = "0x3E84700", VA = "0x183E85300", Slot = "6")]
	public T BPNLGECPCAL<T>(T MKFMLBCIMEB, Transform JIECBJMGMAC, bool MNPLANNPPHB = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3E852D0", Offset = "0x3E846D0", VA = "0x183E852D0", Slot = "7")]
	public T BPNLGECPCAL<T>(GameObject MKFMLBCIMEB, Transform JIECBJMGMAC, bool MNPLANNPPHB = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x82EC5A0", Offset = "0x82EB9A0", VA = "0x1882EC5A0", Slot = "8")]
	public GameObject BPNLGECPCAL(GameObject MKFMLBCIMEB, Transform JIECBJMGMAC, OAJAKDOALFG FGEMBJJOPFK, bool MNPLANNPPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3E85370", Offset = "0x3E84770", VA = "0x183E85370", Slot = "9")]
	public T BPNLGECPCAL<T>(GameObject MKFMLBCIMEB, Transform JIECBJMGMAC, OAJAKDOALFG FGEMBJJOPFK, bool MNPLANNPPHB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3E853B0", Offset = "0x3E847B0", VA = "0x183E853B0")]
	private T BPNLGECPCAL<T>(GameObject MKFMLBCIMEB, Transform JIECBJMGMAC, OAJAKDOALFG FGEMBJJOPFK, bool MNPLANNPPHB, [Out] GameObject KOBDLONLCLC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3E84FE0", Offset = "0x3E843E0", VA = "0x183E84FE0")]
	private T AFMEMGPEIJK<T>(GameObject JBJNKCGNJKP, OAJAKDOALFG FGEMBJJOPFK, bool MNPLANNPPHB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x82EC800", Offset = "0x82EBC00", VA = "0x1882EC800")]
	private void EPOJNDMOINB(OAJAKDOALFG FGEMBJJOPFK, bool MNPLANNPPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x82ECE10", Offset = "0x82EC210", VA = "0x1882ECE10")]
	private void LPKPKOACJLP(OAJAKDOALFG FGEMBJJOPFK, bool MNPLANNPPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x82EC490", Offset = "0x82EB890", VA = "0x1882EC490")]
	private void BMIBDFDFBHB(Component FCIHIIPNCLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x82ECBA0", Offset = "0x82EBFA0", VA = "0x1882ECBA0")]
	private void LPKPKOACJLP(Component FCIHIIPNCLK, OAJAKDOALFG FGEMBJJOPFK, bool MNPLANNPPHB, bool OOEDAACBLAP, [Optional] Type JGCAEPDCNJB, [Optional] Type FNFIBOKFNLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x82ED040", Offset = "0x82EC440", VA = "0x1882ED040")]
	private void MPIAKEEPHHD(Component FCIHIIPNCLK, OAJAKDOALFG FGEMBJJOPFK, bool MNPLANNPPHB, bool OOEDAACBLAP, [Optional] Type JGCAEPDCNJB, [Optional] Type FNFIBOKFNLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x82ECA30", Offset = "0x82EBE30", VA = "0x1882ECA30")]
	private void IBDANAIPHGB(GameObject JBJNKCGNJKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct OAJAKDOALFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> EDJJFGBALEN;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3E865A0", Offset = "0x3E859A0", VA = "0x183E865A0")]
	public OAJAKDOALFG LFFCNKDPJLH<T>(T JDGCOAMCGBP)
	{
		return default(OAJAKDOALFG);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3E85CB0", Offset = "0x3E850B0", VA = "0x183E85CB0")]
	public T DIJAEKOIPED<T>(T ABINAMGBLJP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3E85DC0", Offset = "0x3E851C0", VA = "0x183E85DC0")]
	public bool KGHIMGHIPAA<T>([Out] T JDGCOAMCGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x82ED900", Offset = "0x82ECD00", VA = "0x1882ED900")]
	public void HBLMHKLDBPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct ALJCKIBEHPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool NCGFOHJCNPO;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2CEA490", Offset = "0x2CE9890", VA = "0x182CEA490")]
	public ALJCKIBEHPG(bool EJGMJGECLKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct INFFPKHBBGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool BEHICCHEGLN;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x82E8500", Offset = "0x82E7900", VA = "0x1882E8500")]
	public INFFPKHBBGL(bool KOHEHFJPOPF)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED60", Offset = "0xA6E160", VA = "0x180A6ED60")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, DJADNNMHOGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x82ED950", Offset = "0x82ECD50", VA = "0x1882ED950", Slot = "4")]
		public void PrepareImposter(OAJAKDOALFG FGEMBJJOPFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED60", Offset = "0xA6E160", VA = "0x180A6ED60")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class ImposterBoundsOverride : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private Bounds imposterBounds;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Bounds GLHPCEPNMEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x82E86F0", Offset = "0x82E7AF0", VA = "0x1882E86F0")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x82E86B0", Offset = "0x82E7AB0", VA = "0x1882E86B0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x82E8670", Offset = "0x82E7A70", VA = "0x1882E8670")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x82E8580", Offset = "0x82E7980", VA = "0x1882E8580")]
		private void OILGPENCEBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED60", Offset = "0xA6E160", VA = "0x180A6ED60")]
		public ImposterBoundsOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CreateAssetMenu(fileName = "ImposterRenderConfig", menuName = "RecRoom/Imposters/Imposter Render Config")]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			[Header("Shadows")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			[Range(0.1f, 10f)]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x82EC470", Offset = "0x82EB870", VA = "0x1882EC470")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x82EC460", Offset = "0x82EB860", VA = "0x1882EC460")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public float cameraOffsetMaxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Tooltip("Get initial camera position to capture the bounds of an imposter.")]
		public bool frameCameraToImposterBounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[GKAGFGDDNKD("frameCameraToImposterBounds", true)]
		public float heightCenterOffsetDivisor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Tooltip("If the player is using FBA, modify the position of the camera.")]
		public Vector3 fullBodyPositionModifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Header("Auto Rotation")]
		public bool autoRotateYawImposter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[GKAGFGDDNKD("autoRotateYawImposter", true)]
		public float autoRotateDegreesPerSecond;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[HideInInspector]
		public bool useExplicitCameraComposition;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[HideInInspector]
		public Vector3 explicitCameraPositionOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[HideInInspector]
		public Quaternion explicitCameraRotationOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[HideInInspector]
		public float explicitCameraOrthographicSize;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x82E95B0", Offset = "0x82E89B0", VA = "0x1882E95B0")]
		public void CCFGPCODJNN(Vector3 MABBIFENMIM, Quaternion FJHADOGKNBH, float FFJDBLENKGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x82E95E0", Offset = "0x82E89E0", VA = "0x1882E95E0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class KFAGIDFJFHK
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly Vector3 POFFDCBMNBB;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly List<URPLight> AGJBHHHBFMI;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<Light> JAKGHLBJKOH;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Camera ECOOIPOBEMA;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly List<Renderer> GMJPPNKCKBN;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<ImposterBoundsOverride> GOENOCDCNPL;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static AmbientMode HJJPFMNINDH;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static Color JJKDPCOKBPF;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static Color KKJBMLNOFNJ;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Color OPFIDBFFKAP;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static Cubemap OEFLAIDKEGE;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static bool DNKFMEPBJPC;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> LEOEKNMJKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x82E9A30", Offset = "0x82E8E30", VA = "0x1882E9A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> GAPHGIMHBHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x82EC100", Offset = "0x82EB500", VA = "0x1882EC100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera OKAOHNCNIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x82EA5D0", Offset = "0x82E99D0", VA = "0x1882EA5D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x82EBE60", Offset = "0x82EB260", VA = "0x1882EBE60")]
	public static void MINOFJBHJDM(Vector3 OHEDGJFPOJC, Quaternion NIABJNHOPAN, ImposterRenderConfig KDKEFHMDPIA, bool JABJHBEJDKE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x82EB360", Offset = "0x82EA760", VA = "0x1882EB360")]
	private static void IJNGBGFCPDK(Vector3 OHEDGJFPOJC, Quaternion NIABJNHOPAN, URPLight KEIPKLIFFJH, ImposterRenderConfig.LightConfig EBHPICCDFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x82EBD80", Offset = "0x82EB180", VA = "0x1882EBD80")]
	public static void JEDMBJIBNDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x82EAE80", Offset = "0x82EA280", VA = "0x1882EAE80")]
	private static void HNOBHCFJMDG(int BPNHOHPLCPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x82EBBB0", Offset = "0x82EAFB0", VA = "0x1882EBBB0")]
	public static void JCIPBHOGPMC(ImposterRenderConfig KDKEFHMDPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x82E9DC0", Offset = "0x82E91C0", VA = "0x1882E9DC0")]
	public static void COHGFNHHKKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x82E9A80", Offset = "0x82E8E80", VA = "0x1882E9A80")]
	public static void CEJNELFKMIH(GameObject MABHFHBKNGB, RenderTexture PAABFJFKFJA, ImposterRenderConfig KDKEFHMDPIA, AKNFIBKAFPE CMNMJLKHHED, [Optional] Vector3? BDOJDINBKNK, [Optional] Vector3? AEIMNNPFENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x82EA820", Offset = "0x82E9C20", VA = "0x1882EA820")]
	private static void HEAOFKGGAOM(GameObject MABHFHBKNGB, RenderTexture PAABFJFKFJA, ImposterRenderConfig KDKEFHMDPIA, AKNFIBKAFPE CMNMJLKHHED, Vector3 BDOJDINBKNK, Vector3 AEIMNNPFENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x82EA2F0", Offset = "0x82E96F0", VA = "0x1882EA2F0")]
	private static void FLMCJFOHPKF(GameObject MABHFHBKNGB, Vector3 AEGNEIGEKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x82E9EB0", Offset = "0x82E92B0", VA = "0x1882E9EB0")]
	public static void DDPHKGDEKEM(Bounds IFACEABKHHF, ImposterRenderConfig KDKEFHMDPIA, [Out] Vector3 MOAEPGCONHH, [Out] Quaternion KDGNDNNEDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x82EB680", Offset = "0x82EAA80", VA = "0x1882EB680")]
	private static void ILJJLGMCAIO(GameObject MKFMLBCIMEB, ImposterRenderConfig KDKEFHMDPIA, AKNFIBKAFPE CMNMJLKHHED, [Out] Vector3 MOAEPGCONHH, [Out] Quaternion KDGNDNNEDGD, [Out] float LMAFLGHAPKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x82EA220", Offset = "0x82E9620", VA = "0x1882EA220")]
	public static RenderTexture FGKPEJCHINI(int FGPFDBGIFDN, int MFIDIIHOELB, RenderTextureFormat LKPDHLBCOHA = RenderTextureFormat.ARGB32, string BKCAMLOLKGF = "[ImposterRendering]Preview")
	{
		return null;
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public struct INIBCALJOLB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public HJHGLMLAFFL HAOGIGMBPCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public GameObject LIOMKLGMMDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public RenderTexture BBDJJGAPIKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public ImposterRenderConfig IDIFPCHCDNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public AKNFIBKAFPE AKNFIBKAFPE;

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x82E8510", Offset = "0x82E7910", VA = "0x1882E8510")]
			public INIBCALJOLB(HJHGLMLAFFL KDLILNGLKGF, GameObject GAJBPIPJJMP, RenderTexture PAABFJFKFJA, ImposterRenderConfig BCJKFCDKOOG, AKNFIBKAFPE CMNMJLKHHED)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static KOKOAANOAGE<INIBCALJOLB, RenderTexture> CAOFAEJEKIK;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly List<INIBCALJOLB> HIOFKGODGAJ;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int GGNBHGINCDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x82E6D30", Offset = "0x82E6130", VA = "0x1882E6D30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x82E6E60", Offset = "0x82E6260", VA = "0x1882E6E60")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject MABHFHBKNGB, RenderTexture PAABFJFKFJA, ImposterRenderConfig KDKEFHMDPIA, AKNFIBKAFPE CMNMJLKHHED, CancellationToken GMKBGHHNCDJ, bool LHOKJPLDNJO = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x82E6880", Offset = "0x82E5C80", VA = "0x1882E6880", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x82E6DC0", Offset = "0x82E61C0", VA = "0x1882E6DC0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x82E6A90", Offset = "0x82E5E90", VA = "0x1882E6A90")]
		private static Task<RenderTexture> CHBEBIFHAHF(INIBCALJOLB LANPOGIKGPG, CancellationToken GMKBGHHNCDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x82E7280", Offset = "0x82E6680", VA = "0x1882E7280")]
		public DeferredImposterRenderer()
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
