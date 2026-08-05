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
	private readonly struct NCMMHHHACCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly FDDBBPKJKHL CCPJMHPDPAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string NBMOENGHIIE;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x85EBA0", Offset = "0x85D5A0", VA = "0x18085EBA0")]
		public NCMMHHHACCO(FDDBBPKJKHL CANNHKFEACH, string PNCFHDMHAHL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct DNOEDAINMDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public NCMMHHHACCO queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5FDDA20", Offset = "0x5FDC420", VA = "0x185FDDA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5FDDDC0", Offset = "0x5FDC7C0", VA = "0x185FDDDC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider MBBAPNAAICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NFOGKJFLOMC<NCMMHHHACCO, GameObject> GPHEJNDJCAO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public CGHLFMDHPFD OLNLAKFBBCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x790C90", Offset = "0x78F690", VA = "0x180790C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private NFOGKJFLOMC<NCMMHHHACCO, GameObject> BLOPJLHFACG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5FDE840", Offset = "0x5FDD240", VA = "0x185FDE840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int CJJMMPMBHIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5FDE7F0", Offset = "0x5FDD1F0", VA = "0x185FDE7F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5FDE730", Offset = "0x5FDD130", VA = "0x185FDE730", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5FDECA0", Offset = "0x5FDD6A0", VA = "0x185FDECA0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5FDEB80", Offset = "0x5FDD580", VA = "0x185FDEB80")]
	[AsyncStateMachine(typeof(DNOEDAINMDE))]
	private Task<GameObject> NJEFGBLJMEJ(NCMMHHHACCO LDBKJDGNJNM, CancellationToken EAPNOLMLMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5FDE9A0", Offset = "0x5FDD3A0", VA = "0x185FDE9A0")]
	public Task<GameObject> LoadItemAsync(FDDBBPKJKHL CANNHKFEACH, CancellationToken EAPNOLMLMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5FDED10", Offset = "0x5FDD710", VA = "0x185FDED10")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class IJIPBDEHDHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public FDDBBPKJKHL DKKELNBMDFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture ACHPMLKCNPP;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x797640", Offset = "0x796040", VA = "0x180797640")]
		public IJIPBDEHDHE(FDDBBPKJKHL LFDFKDBMPDN, Texture JFFMCLFLHBI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum IDHIOEMIABL
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
	private class EJGADAIFHOE : PGIJLLFCBAB<Texture>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct IBAMAKGPDAO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public EJGADAIFHOE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5FDF110", Offset = "0x5FDDB10", VA = "0x185FDF110", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5FDF920", Offset = "0x5FDE320", VA = "0x185FDF920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly FDDBBPKJKHL LFDFKDBMPDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture OKCPNKOOJHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig MNJKJOBNJHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken EAPNOLMLMHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject LJIMHEKFGKJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override HECHONBOMGO<Texture> GKLDEHMEPDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5FDEED0", Offset = "0x5FDD8D0", VA = "0x185FDEED0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture> LKACNNIFJCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x793B30", Offset = "0x792530", VA = "0x180793B30", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5FDEF30", Offset = "0x5FDD930", VA = "0x185FDEF30")]
		public EJGADAIFHOE(FDDBBPKJKHL LFDFKDBMPDN, RenderTexture OKCPNKOOJHD, ImposterRenderConfig MNJKJOBNJHG, CancellationToken EAPNOLMLMHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5FDEDD0", Offset = "0x5FDD7D0", VA = "0x185FDEDD0")]
		[AsyncStateMachine(typeof(IBAMAKGPDAO))]
		private Task<Texture> LHJIIMDEJCF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5FDEEC0", Offset = "0x5FDD8C0", VA = "0x185FDEEC0", Slot = "10")]
		protected override void NCEPPALKHML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5FDED50", Offset = "0x5FDD750", VA = "0x185FDED50")]
		private static void IFGPCLEFOGC(GameObject LJIMHEKFGKJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct LMPCGDMIDAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public ImposterRawImage <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<Texture> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0E50", Offset = "0x5FDF850", VA = "0x185FE0E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x926CC0", Offset = "0x9256C0", VA = "0x180926CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[Tooltip("Texture shown when the imposter texture is not available")]
	[SerializeField]
	[Header("General")]
	private Texture defaultTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[IGEHDIPFLIF(EEBNILOIPCE.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private IDHIOEMIABL size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[FDMPAGPHLNK("size", IDHIOEMIABL.Custom)]
	[Tooltip("Custom pixel size for rendered imposter")]
	[SerializeField]
	private int customSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[SerializeField]
	private int antiAliasing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[Tooltip("Configuration specifying render properties for the imposter")]
	private ImposterRenderConfig imposterRenderConfig;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static int GKABLNOEECG;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture MANKDLNPGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private INGBOBMCOLM<GameObject> AAJEBNLLOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private MDCIDBDKHAG FLGIHKNEFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource DCEAHKDKEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private GDNMOKOHIIO<Texture> JDAPPFCGBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private FDDBBPKJKHL NLGKMCOFFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture CPCHIFCFIFB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int MMPGLACNCHG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0950", Offset = "0x5FDF350", VA = "0x185FE0950")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5FE09A0", Offset = "0x5FDF3A0", VA = "0x185FE09A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture LFKGEIBEPIL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0040", Offset = "0x5FDEA40", VA = "0x185FE0040")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x793900", Offset = "0x792300", VA = "0x180793900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private FDDBBPKJKHL DKKELNBMDFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x78FCB0", Offset = "0x78E6B0", VA = "0x18078FCB0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0290", Offset = "0x5FDEC90", VA = "0x185FE0290")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool MMJGLHJCIKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x513F0A0", Offset = "0x513DAA0", VA = "0x18513F0A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int JANJNHDAILC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5FE01F0", Offset = "0x5FDEBF0", VA = "0x185FE01F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5FDFF40", Offset = "0x5FDE940", VA = "0x185FDFF40")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5FE0520", Offset = "0x5FDEF20", VA = "0x185FE0520")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5FE04A0", Offset = "0x5FDEEA0", VA = "0x185FE04A0")]
	private void LKOANLHHAMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5FE0830", Offset = "0x5FDF230", VA = "0x185FE0830")]
	public void Set(FDDBBPKJKHL ICIHFMONHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5FE0820", Offset = "0x5FDF220", VA = "0x185FE0820")]
	public void Set(Texture JFFMCLFLHBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5FE0840", Offset = "0x5FDF240", VA = "0x185FE0840")]
	public void Set(IJIPBDEHDHE BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5FDFF50", Offset = "0x5FDE950", VA = "0x185FDFF50")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5FE0620", Offset = "0x5FDF020", VA = "0x185FE0620")]
	public void SetInternal(FDDBBPKJKHL ICIHFMONHEA, [Optional] Texture NCCJHGENLDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5FE0610", Offset = "0x5FDF010", VA = "0x185FE0610")]
	public void SetCustomSize(int IOEALAJCPGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x793B00", Offset = "0x792500", VA = "0x180793B00")]
	public void SetAntiAliasing(int PGOGBLFOAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5FE03F0", Offset = "0x5FDEDF0", VA = "0x185FE03F0")]
	[AsyncStateMachine(typeof(LMPCGDMIDAH))]
	private void LFDNPEMGBDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5FDFF60", Offset = "0x5FDE960", VA = "0x185FDFF60")]
	private void ELCCHNONIHD(Texture JFFMCLFLHBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5FE08D0", Offset = "0x5FDF2D0", VA = "0x185FE08D0")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, GJMIGIPHPHH
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float DMEBIEGEMPD = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "4")]
	public void PrepareImposter(OAPIIHOCBHD FLHMGGNKGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5FDFF00", Offset = "0x5FDE900", VA = "0x185FDFF00")]
	public void SetReferencePoint(Vector3 LAKIBICOBFE, Quaternion HDEHMDBACJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5FDFD00", Offset = "0x5FDE700", VA = "0x185FDFD00")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5FDFEE0", Offset = "0x5FDE8E0", VA = "0x185FDFEE0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x13B6350", Offset = "0x13B4D50", VA = "0x1813B6350")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct EKGKNLICODN
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static EKGKNLICODN NHPGPFFELGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float ALHMBCGBFBG;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x210BCA0", Offset = "0x210A6A0", VA = "0x18210BCA0")]
	public EKGKNLICODN(float HLKGDMIGKNK)
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class IncreaseTransparentRenderQueueWhenInUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		[IGEHDIPFLIF(EEBNILOIPCE.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int MEMFEDAJHDF = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int OFNKMCEAAGI = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> CIBGMPNAFNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool KAGPDDHEANH;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0B80", Offset = "0x5FDF580", VA = "0x185FE0B80")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0A80", Offset = "0x5FDF480", VA = "0x185FE0A80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0DC0", Offset = "0x5FDF7C0", VA = "0x185FE0DC0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FDDBBPKJKHL
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string CEDNNDMJNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	EKGKNLICODN EKGKNLICODN
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action OJEIACBPMCG;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> DODFAKJDEFN(CancellationToken EAPNOLMLMHM);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HIOLECMJOGA(FDDBBPKJKHL CGDFJMJIABO);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JMPHNMKBLMH();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EBJMBCPPLCG();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FIKCDGAJEMK([Out] GDNMOKOHIIO<Texture> EINGDMJGHMM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class PMAHPCGBNGL
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5FE4610", Offset = "0x5FE3010", VA = "0x185FE4610")]
	public static bool JDHEECOPNAO(FDDBBPKJKHL HHFNEJMPPPL, FDDBBPKJKHL FOEMDLPDJFE)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, GJMIGIPHPHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5FDD8D0", Offset = "0x5FDC2D0", VA = "0x185FDD8D0", Slot = "4")]
		public void PrepareImposter(OAPIIHOCBHD FLHMGGNKGKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x78F200", Offset = "0x78DC00", VA = "0x18078F200")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x78F200", Offset = "0x78DC00", VA = "0x18078F200")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface GJMIGIPHPHH
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(OAPIIHOCBHD FLHMGGNKGKC);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NLEBNFANMNM
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> DNBGJMNJOAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> FKJPOMLBMNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface CGHLFMDHPFD
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GameObject LBEOMAFKIIG(GameObject OPENNMAGMAF, Transform CDMOGOKIPKH, bool FMJNNMMGAOB = false);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T LBEOMAFKIIG<T>(T OPENNMAGMAF, Transform CDMOGOKIPKH, bool FMJNNMMGAOB = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T LBEOMAFKIIG<T>(GameObject OPENNMAGMAF, Transform CDMOGOKIPKH, bool FMJNNMMGAOB = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GameObject LBEOMAFKIIG(GameObject OPENNMAGMAF, Transform CDMOGOKIPKH, OAPIIHOCBHD FLHMGGNKGKC, bool FMJNNMMGAOB);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class MOIGDJGPCLP : IDisposable, CGHLFMDHPFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> MACADKPGPEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> GJDCIMLJIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform CNKGEJEDFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> EAHKLPOCEIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> LBHIDCOHEMD;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5FE1C00", Offset = "0x5FE0600", VA = "0x185FE1C00")]
	[BBBFDPEBAMC(HLEKCCEDPHP.None)]
	public static void KKNBNMHPDDL(AFDLAPABCDH DFLLKHNKNDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5FE20A0", Offset = "0x5FE0AA0", VA = "0x185FE20A0")]
	[Preserve]
	public MOIGDJGPCLP([KNBPONIPMPA(null)] NLEBNFANMNM KMGAHJHABCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5FE1640", Offset = "0x5FE0040", VA = "0x185FE1640", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5FE1D00", Offset = "0x5FE0700", VA = "0x185FE1D00", Slot = "5")]
	public GameObject LBEOMAFKIIG(GameObject OPENNMAGMAF, Transform CDMOGOKIPKH, bool FMJNNMMGAOB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x26EB540", Offset = "0x26E9F40", VA = "0x1826EB540", Slot = "6")]
	public T LBEOMAFKIIG<T>(T OPENNMAGMAF, Transform CDMOGOKIPKH, bool FMJNNMMGAOB = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x26EB5B0", Offset = "0x26E9FB0", VA = "0x1826EB5B0", Slot = "7")]
	public T LBEOMAFKIIG<T>(GameObject OPENNMAGMAF, Transform CDMOGOKIPKH, bool FMJNNMMGAOB = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5FE1D90", Offset = "0x5FE0790", VA = "0x185FE1D90", Slot = "8")]
	public GameObject LBEOMAFKIIG(GameObject OPENNMAGMAF, Transform CDMOGOKIPKH, OAPIIHOCBHD FLHMGGNKGKC, bool FMJNNMMGAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x26EAF90", Offset = "0x26E9990", VA = "0x1826EAF90", Slot = "9")]
	public T LBEOMAFKIIG<T>(GameObject OPENNMAGMAF, Transform CDMOGOKIPKH, OAPIIHOCBHD FLHMGGNKGKC, bool FMJNNMMGAOB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x26EAFD0", Offset = "0x26E99D0", VA = "0x1826EAFD0")]
	private T LBEOMAFKIIG<T>(GameObject OPENNMAGMAF, Transform CDMOGOKIPKH, OAPIIHOCBHD FLHMGGNKGKC, bool FMJNNMMGAOB, [Out] GameObject BPPBNGKMILJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x26EB5E0", Offset = "0x26E9FE0", VA = "0x1826EB5E0")]
	private T LMLGMEFHMDK<T>(GameObject PKKHAEKNIBL, OAPIIHOCBHD FLHMGGNKGKC, bool FMJNNMMGAOB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5FE1F90", Offset = "0x5FE0990", VA = "0x185FE1F90")]
	private void NLNGCPNKFOK(Component BBNHMANAAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5FE1720", Offset = "0x5FE0120", VA = "0x185FE1720")]
	private void ICGMEOKKDGI(Component BBNHMANAAIO, OAPIIHOCBHD FLHMGGNKGKC, bool FMJNNMMGAOB, bool NLGOIEBGLBB, [Optional] Type CDNJCHOMHHM, [Optional] Type CKBKNNJLANB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5FE1E20", Offset = "0x5FE0820", VA = "0x185FE1E20")]
	private void NIKHMMEOOHN(GameObject PKKHAEKNIBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct OAPIIHOCBHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> JFGNFGPLCLK;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2769EB0", Offset = "0x27688B0", VA = "0x182769EB0")]
	public OAPIIHOCBHD OGNHOBPFCBA<T>(T IBLKMNDDBPN)
	{
		return default(OAPIIHOCBHD);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2769DA0", Offset = "0x27687A0", VA = "0x182769DA0")]
	public T DKMKPEOPLDE<T>(T DMIGONFFMAF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x276A5E0", Offset = "0x2768FE0", VA = "0x18276A5E0")]
	public bool PPEMIFBBDMG<T>([Out] T IBLKMNDDBPN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct ANHLDKIHFFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool OGKMCGFNHDA;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0xC1A780", Offset = "0xC19180", VA = "0x180C1A780")]
	public ANHLDKIHFFB(bool DBIAPGDHHHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct BFAPMJFKJED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool HADPMNPGJHB;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5FDD8C0", Offset = "0x5FDC2C0", VA = "0x185FDD8C0")]
	public BFAPMJFKJED(bool FNPFPJKPKLF)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x78F200", Offset = "0x78DC00", VA = "0x18078F200")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, GJMIGIPHPHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5FE4700", Offset = "0x5FE3100", VA = "0x185FE4700", Slot = "4")]
		public void PrepareImposter(OAPIIHOCBHD FLHMGGNKGKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x78F200", Offset = "0x78DC00", VA = "0x18078F200")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ImposterBoundsOverride : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Bounds imposterBounds;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Bounds BNLMJPCHIMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5FDFB70", Offset = "0x5FDE570", VA = "0x185FDFB70")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5FDFB30", Offset = "0x5FDE530", VA = "0x185FDFB30")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5FDFAF0", Offset = "0x5FDE4F0", VA = "0x185FDFAF0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5FDFA00", Offset = "0x5FDE400", VA = "0x185FDFA00")]
		private void LAJADFEOEBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x78F200", Offset = "0x78DC00", VA = "0x18078F200")]
		public ImposterBoundsOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CreateAssetMenu(fileName = "ImposterRenderConfig", menuName = "RecRoom/Imposters/Imposter Render Config")]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			[Header("Shadows")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			[Range(0.1f, 10f)]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x5FE1620", Offset = "0x5FE0020", VA = "0x185FE1620")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x5FE1610", Offset = "0x5FE0010", VA = "0x185FE1610")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[ColorUsage(false, true)]
		[Header("Environment Lighting")]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0A20", Offset = "0x5FDF420", VA = "0x185FE0A20")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class PIKGDPILAPK
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly List<URPLight> OFOHJIBIFOF;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly Vector3 EEMMCMKGLBF;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly Vector3 HIMECAHKEMB;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static Camera OIHBDLHHEAG;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly List<Renderer> HEBKDFMJBHD;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly List<ImposterBoundsOverride> GNBDJHEDKOG;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static AmbientMode BANMHJKFLGA;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static Color DMIAMDOOHKP;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Color MOIOIDJCJIC;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static Color EDMKKNKDMDD;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static Cubemap IFBDCBFIFKD;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static bool MDNCNFJKIHL;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static Camera MAIALOCEOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5FE3440", Offset = "0x5FE1E40", VA = "0x185FE3440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5FE41B0", Offset = "0x5FE2BB0", VA = "0x185FE41B0")]
	public static void NHENKDKFJGM(Vector3 BHAMGFEFNDF, Quaternion IJLDJINJPNB, ImposterRenderConfig BDBPMHKMGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3110", Offset = "0x5FE1B10", VA = "0x185FE3110")]
	private static void FMHADGMCNKL(Vector3 BHAMGFEFNDF, Quaternion IJLDJINJPNB, URPLight IBFOFECFHBB, ImposterRenderConfig.LightConfig LDBDPAGKJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5FE2D90", Offset = "0x5FE1790", VA = "0x185FE2D90")]
	public static void FHMKBADMMFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5FE2840", Offset = "0x5FE1240", VA = "0x185FE2840")]
	private static void EBLJHPDMKNN(int DCJLICJDHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5FE25D0", Offset = "0x5FE0FD0", VA = "0x185FE25D0")]
	public static void CCPOGOGBBHK(ImposterRenderConfig BDBPMHKMGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5FE24E0", Offset = "0x5FE0EE0", VA = "0x185FE24E0")]
	public static void AAACFPLELCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5FE2BC0", Offset = "0x5FE15C0", VA = "0x185FE2BC0")]
	public static void EKMLJLOEFCB(GameObject EGBAKFCAHKP, RenderTexture OKCPNKOOJHD, ImposterRenderConfig BDBPMHKMGGE, EKGKNLICODN HKPNJNJIHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3BD0", Offset = "0x5FE25D0", VA = "0x185FE3BD0")]
	private static void LLFGOBLHJAE(GameObject EGBAKFCAHKP, RenderTexture OKCPNKOOJHD, ImposterRenderConfig BDBPMHKMGGE, EKGKNLICODN HKPNJNJIHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5FE2E70", Offset = "0x5FE1870", VA = "0x185FE2E70")]
	private static void FKAPMJHPDAO(GameObject EGBAKFCAHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3650", Offset = "0x5FE2050", VA = "0x185FE3650")]
	public static void KFAHPJCOPHO(GameObject OPENNMAGMAF, Vector3 FGDJGHBGIBA, Vector3 JMODGIDEELE, float EGHOJDEKHFD, EKGKNLICODN HKPNJNJIHHA, [Out] Vector3 MNIFCILKFOG, [Out] Quaternion MOPBMGIPKNC, [Out] float OCMICAIIILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5FE2790", Offset = "0x5FE1190", VA = "0x185FE2790")]
	public static RenderTexture CKMLLAFLKHE(int MIBJOODDNBG, int BGBFMDANLOG, RenderTextureFormat MPEIKHEGNLM = RenderTextureFormat.ARGB32)
	{
		return null;
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public struct IKNFEDBHICC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public JGJGMCLOHKB MOIOOGKCPPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public GameObject JOGAOKBHHFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public RenderTexture LFKGEIBEPIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public ImposterRenderConfig DKNLLBFPNKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public EKGKNLICODN EKGKNLICODN;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x5FDF990", Offset = "0x5FDE390", VA = "0x185FDF990")]
			public IKNFEDBHICC(JGJGMCLOHKB FGDCNGGOLDM, GameObject PDOKOOCFCKP, RenderTexture OKCPNKOOJHD, ImposterRenderConfig MNJKJOBNJHG, EKGKNLICODN HKPNJNJIHHA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static NFOGKJFLOMC<IKNFEDBHICC, RenderTexture> BOALFEDEOLJ;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly List<IKNFEDBHICC> NLKBMINNLBM;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private static int HMHNDANDJAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5FDDE30", Offset = "0x5FDC830", VA = "0x185FDDE30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5FDE2D0", Offset = "0x5FDCCD0", VA = "0x185FDE2D0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject EGBAKFCAHKP, RenderTexture OKCPNKOOJHD, ImposterRenderConfig BDBPMHKMGGE, EKGKNLICODN HKPNJNJIHHA, CancellationToken EAPNOLMLMHM, bool NIHNHFKEIII = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5FDDEA0", Offset = "0x5FDC8A0", VA = "0x185FDDEA0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5FDE090", Offset = "0x5FDCA90", VA = "0x185FDE090", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5FDE130", Offset = "0x5FDCB30", VA = "0x185FDE130")]
		private static Task<RenderTexture> POBIHPONFMD(IKNFEDBHICC AJBLABEMLKE, CancellationToken EAPNOLMLMHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5FDE6F0", Offset = "0x5FDD0F0", VA = "0x185FDE6F0")]
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
