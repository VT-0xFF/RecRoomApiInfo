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
	private readonly struct CEAIPBLOJFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly BBPFIBIBDBM NPFBIGBFAJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string MCPIOFNNGEP;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB268B0", Offset = "0xB25AB0", VA = "0x180B268B0")]
		public CEAIPBLOJFJ(BBPFIBIBDBM JOLDIIMPPCI, string BNIMKPGBJDA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct ONCGDDBADJG : IAsyncStateMachine
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
		public CEAIPBLOJFJ queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7C95DB0", Offset = "0x7C94FB0", VA = "0x187C95DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7C96170", Offset = "0x7C95370", VA = "0x187C96170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider BHJGHBBCINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private OLAJMGFHKDD<CEAIPBLOJFJ, GameObject> DBBPAECOFNG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public BKGOIEBKDAO MAKPKMBNCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA00F60", Offset = "0xA00160", VA = "0x180A00F60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private OLAJMGFHKDD<CEAIPBLOJFJ, GameObject> BKLJHIPKEDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7C8F100", Offset = "0x7C8E300", VA = "0x187C8F100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int KMDEAFDLNHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7C8F0B0", Offset = "0x7C8E2B0", VA = "0x187C8F0B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7C8EFD0", Offset = "0x7C8E1D0", VA = "0x187C8EFD0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7C8F560", Offset = "0x7C8E760", VA = "0x187C8F560", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7C8F260", Offset = "0x7C8E460", VA = "0x187C8F260")]
	[AsyncStateMachine(typeof(ONCGDDBADJG))]
	private Task<GameObject> JEHPGFELBNJ(CEAIPBLOJFJ OKKKNBLEDBI, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7C8F380", Offset = "0x7C8E580", VA = "0x187C8F380")]
	public Task<GameObject> LoadItemAsync(BBPFIBIBDBM JOLDIIMPPCI, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7C8F5D0", Offset = "0x7C8E7D0", VA = "0x187C8F5D0")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class DCAOFBHHNFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public BBPFIBIBDBM GBMCLHKBECC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture BBPCNBDODJK;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA058E0", Offset = "0xA04AE0", VA = "0x180A058E0")]
		public DCAOFBHHNFM(BBPFIBIBDBM IMECKHMAANA, Texture NANHFKKMKAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum OIIDHOCOBLD
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
	private class GLEOKPPEMPE : GJBDDJLFOPI<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct LHAJGEABCFH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public GLEOKPPEMPE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7C94CD0", Offset = "0x7C93ED0", VA = "0x187C94CD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7C954D0", Offset = "0x7C946D0", VA = "0x187C954D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly BBPFIBIBDBM IMECKHMAANA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture AFCFGGMHNBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig KAJEABBAINA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken FHBCOAHILMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D PFOFHGDDPEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject LKOIHKKPGHL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override GFHJFJDJPFP<Texture2D> MDECBJCIJNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7C90C40", Offset = "0x7C8FE40", VA = "0x187C90C40", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> BGFIFFKAHGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA00F70", Offset = "0xA00170", VA = "0x180A00F70", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7C90E10", Offset = "0x7C90010", VA = "0x187C90E10")]
		public GLEOKPPEMPE(BBPFIBIBDBM IMECKHMAANA, RenderTexture AFCFGGMHNBC, ImposterRenderConfig KAJEABBAINA, CancellationToken FHBCOAHILMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7C90CA0", Offset = "0x7C8FEA0", VA = "0x187C90CA0")]
		[AsyncStateMachine(typeof(LHAJGEABCFH))]
		private Task<Texture2D> LEIIJIKDIPO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7C90C10", Offset = "0x7C8FE10", VA = "0x187C90C10", Slot = "10")]
		protected override void BOEKPCDEEIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7C90D90", Offset = "0x7C8FF90", VA = "0x187C90D90")]
		private static void NKCKAGHFICF(GameObject LKOIHKKPGHL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct NHNIKJCKCMJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7C95570", Offset = "0x7C94770", VA = "0x187C95570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA508E0", Offset = "0xA4FAE0", VA = "0x180A508E0", Slot = "5")]
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
	[GBCGIPBAICF(CFJMFGLCHFI.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private OIIDHOCOBLD size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[DGHDPMNMPGC("size", OIIDHOCOBLD.Custom)]
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
	private static int ENIAPMDOKFL;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture HPMGLKFHAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private EGLJIPPDGFA<GameObject> APLABNKFCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private ABAHHGGDFBO CELBHGBFODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource IHOFGGILNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private HLHLINEFKHE<Texture2D> BGMNGIGLABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private BBPFIBIBDBM BJPLIJJGMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture BLBHEAPCJNO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int HKNEECGKIIM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7C91F40", Offset = "0x7C91140", VA = "0x187C91F40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7C91F90", Offset = "0x7C91190", VA = "0x187C91F90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture BLCLMKKCHAD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7C91A20", Offset = "0x7C90C20", VA = "0x187C91A20")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA00BC0", Offset = "0x9FFDC0", VA = "0x180A00BC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private BBPFIBIBDBM GBMCLHKBECC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA00370", Offset = "0x9FF570", VA = "0x180A00370")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7C916F0", Offset = "0x7C908F0", VA = "0x187C916F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool LKFFIFCCAKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x22B2980", Offset = "0x22B1B80", VA = "0x1822B2980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int IONOOPLDCEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7C91660", Offset = "0x7C90860", VA = "0x187C91660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7C91510", Offset = "0x7C90710", VA = "0x187C91510")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7C91850", Offset = "0x7C90A50", VA = "0x187C91850")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7C915E0", Offset = "0x7C907E0", VA = "0x187C915E0")]
	private void ENKOPECOIKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7C91E60", Offset = "0x7C91060", VA = "0x187C91E60")]
	public void Set(BBPFIBIBDBM FFHHHPFJJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7C91E50", Offset = "0x7C91050", VA = "0x187C91E50")]
	public void Set(Texture NANHFKKMKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7C91E10", Offset = "0x7C91010", VA = "0x187C91E10")]
	public void Set(DCAOFBHHNFM KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7C915D0", Offset = "0x7C907D0", VA = "0x187C915D0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7C91C10", Offset = "0x7C90E10", VA = "0x187C91C10")]
	public void SetInternal(BBPFIBIBDBM FFHHHPFJJFJ, [Optional] Texture DDGPKFCFOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C91C00", Offset = "0x7C90E00", VA = "0x187C91C00")]
	public void SetCustomSize(int NMHHMBCHPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xA00F40", Offset = "0xA00140", VA = "0x180A00F40")]
	public void SetAntiAliasing(int NMEHLIMABLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7C91520", Offset = "0x7C90720", VA = "0x187C91520")]
	[AsyncStateMachine(typeof(NHNIKJCKCMJ))]
	private void CLCDAJFMKEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7C91940", Offset = "0x7C90B40", VA = "0x187C91940")]
	private void PIPDJGEMEPI(Texture NANHFKKMKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7C91EC0", Offset = "0x7C910C0", VA = "0x187C91EC0")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, DCONMFCCMIB
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float NOIAIJMPOHK = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "4")]
	public void PrepareImposter(CHNLMCCIOIF AJLJPILGNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7C914D0", Offset = "0x7C906D0", VA = "0x187C914D0")]
	public void SetReferencePoint(Vector3 JCHDHELBFIA, Quaternion FODPIPCFDKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7C912E0", Offset = "0x7C904E0", VA = "0x187C912E0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7C914B0", Offset = "0x7C906B0", VA = "0x187C914B0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1F4A1B0", Offset = "0x1F493B0", VA = "0x181F4A1B0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct CCMEBEGELFM
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static CCMEBEGELFM GNOMODMHHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float HBHOMJGEOFI;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2ACD610", Offset = "0x2ACC810", VA = "0x182ACD610")]
	public CCMEBEGELFM(float AMPBCBHCDPF)
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
		[Cpp2IlInjected.Address(RVA = "0x7C96490", Offset = "0x7C95690", VA = "0x187C96490", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x274B560", Offset = "0x274A760", VA = "0x18274B560")]
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
		[GBCGIPBAICF(CFJMFGLCHFI.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int NKJEAMHMDEJ = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int NKFLBCIGHNM = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> DLIPKGNLKDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool FLPPJDHOMLD;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7C921A0", Offset = "0x7C913A0", VA = "0x187C921A0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7C920A0", Offset = "0x7C912A0", VA = "0x187C920A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7C923F0", Offset = "0x7C915F0", VA = "0x187C923F0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BBPFIBIBDBM
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string JINPHAAIEGG
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	CCMEBEGELFM CCMEBEGELFM
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action KANIAPNNEGN;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> NDGNCFJECCE(CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PBEHFONFPHH(BBPFIBIBDBM CMOCFNBHPLJ);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CMPHBEAAKOB();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PFIBHLBLPHM();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool MKCGELLDBGD(uint? LCDDHMCKCBL, [Out] HLHLINEFKHE<Texture2D> EPEAJHAFHCF);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GHAFJFCBEJG
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7C90B20", Offset = "0x7C8FD20", VA = "0x187C90B20")]
	public static bool OMOMHFLPGBI(BBPFIBIBDBM NFDNGEMKENJ, BBPFIBIBDBM LBKEELGKIAB)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, DCONMFCCMIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7C8E470", Offset = "0x7C8D670", VA = "0x187C8E470", Slot = "4")]
		public void PrepareImposter(CHNLMCCIOIF AJLJPILGNIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA02C50", Offset = "0xA01E50", VA = "0x180A02C50")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA02C50", Offset = "0xA01E50", VA = "0x180A02C50")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface DCONMFCCMIB
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(CHNLMCCIOIF AJLJPILGNIP);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface FDPIMGOMGMN
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> MJNJKFJFLGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> DKEHLCLPOOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface BKGOIEBKDAO
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FBFMCGOLDLF(params Type[] DMNPMGMDJEK);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject AIIIJNABMEP(GameObject IJDBKPEJDOI, Transform FLKKOCNDECC, bool OHACPPPBHHJ = false);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T AIIIJNABMEP<T>(T IJDBKPEJDOI, Transform FLKKOCNDECC, bool OHACPPPBHHJ = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T AIIIJNABMEP<T>(GameObject IJDBKPEJDOI, Transform FLKKOCNDECC, bool OHACPPPBHHJ = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject AIIIJNABMEP(GameObject IJDBKPEJDOI, Transform FLKKOCNDECC, CHNLMCCIOIF AJLJPILGNIP, bool OHACPPPBHHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class FBFIOAOPGLB : IDisposable, BKGOIEBKDAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> LNPNLPEDJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> BGIBKNGAPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform MPNLFODGKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> NBENDGPJOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> KILELJJAIEO;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7C8FE00", Offset = "0x7C8F000", VA = "0x187C8FE00")]
	[MGCKGAIBEHC.PCMIGKEOIEO]
	public static void CNMFKDBOHKK(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7C906E0", Offset = "0x7C8F8E0", VA = "0x187C906E0")]
	[UnityEngine.Scripting.Preserve]
	public FBFIOAOPGLB([NGLIAOPBMFM(null)] FDPIMGOMGMN BBDNFCKOEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7C90180", Offset = "0x7C8F380", VA = "0x187C90180", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7C90260", Offset = "0x7C8F460", VA = "0x187C90260", Slot = "5")]
	public void FBFMCGOLDLF(params Type[] DMNPMGMDJEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7C8F610", Offset = "0x7C8E810", VA = "0x187C8F610", Slot = "6")]
	public GameObject AIIIJNABMEP(GameObject IJDBKPEJDOI, Transform FLKKOCNDECC, bool OHACPPPBHHJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x39DA9B0", Offset = "0x39D9BB0", VA = "0x1839DA9B0", Slot = "7")]
	public T AIIIJNABMEP<T>(T IJDBKPEJDOI, Transform FLKKOCNDECC, bool OHACPPPBHHJ = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x39DA980", Offset = "0x39D9B80", VA = "0x1839DA980", Slot = "8")]
	public T AIIIJNABMEP<T>(GameObject IJDBKPEJDOI, Transform FLKKOCNDECC, bool OHACPPPBHHJ = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7C8F6A0", Offset = "0x7C8E8A0", VA = "0x187C8F6A0", Slot = "9")]
	public GameObject AIIIJNABMEP(GameObject IJDBKPEJDOI, Transform FLKKOCNDECC, CHNLMCCIOIF AJLJPILGNIP, bool OHACPPPBHHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x39DAF80", Offset = "0x39DA180", VA = "0x1839DAF80", Slot = "10")]
	public T AIIIJNABMEP<T>(GameObject IJDBKPEJDOI, Transform FLKKOCNDECC, CHNLMCCIOIF AJLJPILGNIP, bool OHACPPPBHHJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x39DAA20", Offset = "0x39D9C20", VA = "0x1839DAA20")]
	private T AIIIJNABMEP<T>(GameObject IJDBKPEJDOI, Transform FLKKOCNDECC, CHNLMCCIOIF AJLJPILGNIP, bool OHACPPPBHHJ, [Out] GameObject CLDDGAOOMAM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x39DAFC0", Offset = "0x39DA1C0", VA = "0x1839DAFC0")]
	private T PHJBHOHCCEC<T>(GameObject LBBGHAOMHLO, CHNLMCCIOIF AJLJPILGNIP, bool OHACPPPBHHJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7C8FBD0", Offset = "0x7C8EDD0", VA = "0x187C8FBD0")]
	private void BMPBJCKIEDO(CHNLMCCIOIF AJLJPILGNIP, bool OHACPPPBHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7C8F730", Offset = "0x7C8E930", VA = "0x187C8F730")]
	private void BAJAOOIHAKM(CHNLMCCIOIF AJLJPILGNIP, bool OHACPPPBHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7C8FF00", Offset = "0x7C8F100", VA = "0x187C8FF00")]
	private void COKODCOJLFF(Component JCAGDPHNPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7C8F960", Offset = "0x7C8EB60", VA = "0x187C8F960")]
	private void BAJAOOIHAKM(Component JCAGDPHNPIB, CHNLMCCIOIF AJLJPILGNIP, bool OHACPPPBHHJ, bool NEMMKJMNDIP, [Optional] Type MACDLNOGCJG, [Optional] Type KKFOAJEEFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7C902B0", Offset = "0x7C8F4B0", VA = "0x187C902B0")]
	private void PAFOHKNPKNM(Component JCAGDPHNPIB, CHNLMCCIOIF AJLJPILGNIP, bool OHACPPPBHHJ, bool NEMMKJMNDIP, [Optional] Type MACDLNOGCJG, [Optional] Type KKFOAJEEFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7C90010", Offset = "0x7C8F210", VA = "0x187C90010")]
	private void DAAJCLHAEGN(GameObject LBBGHAOMHLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct CHNLMCCIOIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> DHFIDNPEGDI;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x37F38B0", Offset = "0x37F2AB0", VA = "0x1837F38B0")]
	public CHNLMCCIOIF DEEMOOGCBGF<T>(T HLCPBMPIDMK)
	{
		return default(CHNLMCCIOIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x37F37A0", Offset = "0x37F29A0", VA = "0x1837F37A0")]
	public T AFHCIICHJIO<T>(T FEOJADDJKIL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x37F3FE0", Offset = "0x37F31E0", VA = "0x1837F3FE0")]
	public bool LHFIILLJKMI<T>([Out] T HLCPBMPIDMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7C8E3B0", Offset = "0x7C8D5B0", VA = "0x187C8E3B0")]
	public void OLKFAGPLGGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct JHHHOBOPPJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool IMHFPIDPPJM;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2ACF3E0", Offset = "0x2ACE5E0", VA = "0x182ACF3E0")]
	public JHHHOBOPPJB(bool HDGMHJBDNJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct GOANGPFNLEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool KHLMFFHKKCB;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7C90FD0", Offset = "0x7C901D0", VA = "0x187C90FD0")]
	public GOANGPFNLEO(bool CGAELFHHILL)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA02C50", Offset = "0xA01E50", VA = "0x180A02C50")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, DCONMFCCMIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7C961E0", Offset = "0x7C953E0", VA = "0x187C961E0", Slot = "4")]
		public void PrepareImposter(CHNLMCCIOIF AJLJPILGNIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA02C50", Offset = "0xA01E50", VA = "0x180A02C50")]
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
		public Bounds BGMGAPFIKHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7C91150", Offset = "0x7C90350", VA = "0x187C91150")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7C91110", Offset = "0x7C90310", VA = "0x187C91110")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7C910D0", Offset = "0x7C902D0", VA = "0x187C910D0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7C90FE0", Offset = "0x7C901E0", VA = "0x187C90FE0")]
		private void GLKJOFGKAKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA02C50", Offset = "0xA01E50", VA = "0x180A02C50")]
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
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x7C95550", Offset = "0x7C94750", VA = "0x187C95550")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x7C95540", Offset = "0x7C94740", VA = "0x187C95540")]
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
		[DGHDPMNMPGC("frameCameraToImposterBounds", true)]
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
		[DGHDPMNMPGC("autoRotateYawImposter", true)]
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

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7C92000", Offset = "0x7C91200", VA = "0x187C92000")]
		public void FIGKFOIDMCL(Vector3 AIIIMPELBKA, Quaternion DCKKBKNGAOP, float JIAIJEPBPFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7C92030", Offset = "0x7C91230", VA = "0x187C92030")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class LFEEPEOIBCH
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly Vector3 KOLPBFNFCGD;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly List<URPLight> MKAKBMLCPFB;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<Light> IPAKDGMEKHE;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Camera HMHGJIONKPH;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly List<Renderer> HBODMAPBDFB;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<ImposterBoundsOverride> LLPPCGAOFKO;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static AmbientMode KFKBAIPPNCN;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static Color HFKJJLLNHKI;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static Color MBFIPLEKIDE;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Color ENIODAACOKB;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static Cubemap FNOHOOJLENE;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static bool GOOOOKBFEPO;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> BJFJAADCJPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7C937B0", Offset = "0x7C929B0", VA = "0x187C937B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> GKOMIILGIKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7C92820", Offset = "0x7C91A20", VA = "0x187C92820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera LAGLNEKJBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7C94890", Offset = "0x7C93A90", VA = "0x187C94890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7C92870", Offset = "0x7C91A70", VA = "0x187C92870")]
	public static void FNCHCLKEFAB(Vector3 DMEPKACCNKC, Quaternion BDCGLLNFNGJ, ImposterRenderConfig DBCJGJFFGIA, bool LEBNMPLEGEJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7C94570", Offset = "0x7C93770", VA = "0x187C94570")]
	private static void PLHEFKALIJJ(Vector3 DMEPKACCNKC, Quaternion BDCGLLNFNGJ, URPLight EFLGPHCACEP, ImposterRenderConfig.LightConfig OOMLPNOJPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7C92740", Offset = "0x7C91940", VA = "0x187C92740")]
	public static void DHBPHNGJDAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7C92BD0", Offset = "0x7C91DD0", VA = "0x187C92BD0")]
	private static void LMBNFKPINFE(int MPCNOACEDEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7C93B70", Offset = "0x7C92D70", VA = "0x187C93B70")]
	public static void NKPLJJACFPC(ImposterRenderConfig DBCJGJFFGIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7C936D0", Offset = "0x7C928D0", VA = "0x187C936D0")]
	public static void MCDKDJHHLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7C94230", Offset = "0x7C93430", VA = "0x187C94230")]
	public static void OGBPLLBFDJC(GameObject DPJAKEPFPCO, RenderTexture AFCFGGMHNBC, ImposterRenderConfig DBCJGJFFGIA, CCMEBEGELFM AJNMMLCIIAO, [Optional] Vector3? GMBONKMHCPA, [Optional] Vector3? LHFCONJIIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7C930A0", Offset = "0x7C922A0", VA = "0x187C930A0")]
	private static void MBNPMJOCGEB(GameObject DPJAKEPFPCO, RenderTexture AFCFGGMHNBC, ImposterRenderConfig DBCJGJFFGIA, CCMEBEGELFM AJNMMLCIIAO, Vector3 GMBONKMHCPA, Vector3 LHFCONJIIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7C92480", Offset = "0x7C91680", VA = "0x187C92480")]
	private static void AONMJLMPOFL(GameObject DPJAKEPFPCO, Vector3 ICJJCCGDAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7C93800", Offset = "0x7C92A00", VA = "0x187C93800")]
	public static void NCLMGCFIDOC(Bounds LIKELJGJECE, ImposterRenderConfig DBCJGJFFGIA, [Out] Vector3 LCOFAKJPELN, [Out] Quaternion CDKDHNEONLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7C93D20", Offset = "0x7C92F20", VA = "0x187C93D20")]
	private static void ODDNDPKHCCJ(GameObject IJDBKPEJDOI, ImposterRenderConfig DBCJGJFFGIA, CCMEBEGELFM AJNMMLCIIAO, [Out] Vector3 LCOFAKJPELN, [Out] Quaternion CDKDHNEONLB, [Out] float BJOCPOBEHCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7C92B00", Offset = "0x7C91D00", VA = "0x187C92B00")]
	public static RenderTexture KKHHLIAMMIK(int NIPKIDIFIFA, int PDMAOPMNGEB, RenderTextureFormat LHADPGCGDPB = RenderTextureFormat.ARGB32, string FPLPIJGNIJH = "[ImposterRendering]Preview")
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
		public struct CKBHDJIHCHF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public IDGPNCLCNDO MCKOACFOBMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public GameObject HIDLDBGOHLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public RenderTexture BLCLMKKCHAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public ImposterRenderConfig PBFFFMBDBAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public CCMEBEGELFM CCMEBEGELFM;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7C8E400", Offset = "0x7C8D600", VA = "0x187C8E400")]
			public CKBHDJIHCHF(IDGPNCLCNDO EBKLEOAGJJF, GameObject JFFLCPGFNNN, RenderTexture AFCFGGMHNBC, ImposterRenderConfig KAJEABBAINA, CCMEBEGELFM AJNMMLCIIAO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static OLAJMGFHKDD<CKBHDJIHCHF, RenderTexture> LIDDNPEGOCC;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly List<CKBHDJIHCHF> FHKGOEKLPJI;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int MNEEOIGAIPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x7C8EA70", Offset = "0x7C8DC70", VA = "0x187C8EA70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7C8EB90", Offset = "0x7C8DD90", VA = "0x187C8EB90")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject DPJAKEPFPCO, RenderTexture AFCFGGMHNBC, ImposterRenderConfig DBCJGJFFGIA, CCMEBEGELFM AJNMMLCIIAO, CancellationToken FHBCOAHILMJ, bool LEPKGKHFHGO = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7C8E5C0", Offset = "0x7C8D7C0", VA = "0x187C8E5C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7C8EB00", Offset = "0x7C8DD00", VA = "0x187C8EB00", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7C8E7D0", Offset = "0x7C8D9D0", VA = "0x187C8E7D0")]
		private static Task<RenderTexture> IHLOKMKOECP(CKBHDJIHCHF IHINECFKNMD, CancellationToken FHBCOAHILMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7C8EF90", Offset = "0x7C8E190", VA = "0x187C8EF90")]
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
