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
	private readonly struct EIFALIAOJJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly CGOJFHAAFAK KOEJOHGIBON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string HFLFOHLMPIC;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC55370", Offset = "0xC54170", VA = "0x180C55370")]
		public EIFALIAOJJB(CGOJFHAAFAK NEAMJEFJGEE, string CGDIPBADIMH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct FJILFGHBDBE : IAsyncStateMachine
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
		public EIFALIAOJJB queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x83C4460", Offset = "0x83C3260", VA = "0x1883C4460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x83C4820", Offset = "0x83C3620", VA = "0x1883C4820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider JMOONJOLPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private KODEPIGHBEG<EIFALIAOJJB, GameObject> DDMPIHAEKNG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public GAMMPLGCBNP FOOFOICBGLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private KODEPIGHBEG<EIFALIAOJJB, GameObject> OEILLMCHLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x83C3F00", Offset = "0x83C2D00", VA = "0x1883C3F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int FKHJCEGGLCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x83C4360", Offset = "0x83C3160", VA = "0x1883C4360")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x83C3E20", Offset = "0x83C2C20", VA = "0x1883C3E20", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x83C43B0", Offset = "0x83C31B0", VA = "0x1883C43B0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x83C4060", Offset = "0x83C2E60", VA = "0x1883C4060")]
	[AsyncStateMachine(typeof(FJILFGHBDBE))]
	private Task<GameObject> HLDACGAODOJ(EIFALIAOJJB NADMPOALJNK, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x83C4180", Offset = "0x83C2F80", VA = "0x1883C4180")]
	public Task<GameObject> LoadItemAsync(CGOJFHAAFAK NEAMJEFJGEE, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x83C4420", Offset = "0x83C3220", VA = "0x1883C4420")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class EGHGIIMEGMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public CGOJFHAAFAK MHFHIKJOBFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture IKJGNDCECOC;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA9BCE0", Offset = "0xA9AAE0", VA = "0x180A9BCE0")]
		public EGHGIIMEGMI(CGOJFHAAFAK BHHDCOHFEKO, Texture JDNNGPGPIOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum CEENBAICKOO
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
	private class GJEOMKAMPAF : PLOEJGCOECH<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct GCAMBHLAFPK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public GJEOMKAMPAF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x83C4890", Offset = "0x83C3690", VA = "0x1883C4890", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x83C5090", Offset = "0x83C3E90", VA = "0x1883C5090", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly CGOJFHAAFAK BHHDCOHFEKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture LLOJDDLPEIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig FBDPHBONDIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken BKHGNHANFKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D EGAGJPMPAIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject MKGMMENGIFH;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override AIKJELDGMEB<Texture2D> JMNJOBCDBLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x83C5240", Offset = "0x83C4040", VA = "0x1883C5240", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> HEEBFPGMOHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x83C5350", Offset = "0x83C4150", VA = "0x1883C5350")]
		public GJEOMKAMPAF(CGOJFHAAFAK BHHDCOHFEKO, RenderTexture LLOJDDLPEIM, ImposterRenderConfig FBDPHBONDIL, CancellationToken BKHGNHANFKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x83C5150", Offset = "0x83C3F50", VA = "0x1883C5150")]
		[AsyncStateMachine(typeof(GCAMBHLAFPK))]
		private Task<Texture2D> EBBPHIJGMAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x83C52A0", Offset = "0x83C40A0", VA = "0x1883C52A0", Slot = "10")]
		protected override void ICOIHHDPGHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x83C52D0", Offset = "0x83C40D0", VA = "0x1883C52D0")]
		private static void MFEJJJFHIDH(GameObject MKGMMENGIFH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct BKGBEJFDLBJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x83C2A80", Offset = "0x83C1880", VA = "0x1883C2A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xAE56D0", Offset = "0xAE44D0", VA = "0x180AE56D0", Slot = "5")]
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
	[LAEBPIHCEIF(FBMDOBLPJCI.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private CEENBAICKOO size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[JGMPKKPOOFB("size", CEENBAICKOO.Custom)]
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
	private static int AGKIDJOIIFB;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture EJEKPCEAANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private DNANMDPEAJD<GameObject> MKIHGALMNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private MDIEIFNFGHA LLFBLHABLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource DPCAFKKKHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private HNDICJJKNNH<Texture2D> BFGEJJAAALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private CGOJFHAAFAK HNAJKANCGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture DOGCPMJOFFG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int APDKLMHPMPL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x83C8C70", Offset = "0x83C7A70", VA = "0x1883C8C70")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x83C8CC0", Offset = "0x83C7AC0", VA = "0x1883C8CC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture CMLMOKPNHMD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x83C8660", Offset = "0x83C7460", VA = "0x1883C8660")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA98AB0", Offset = "0xA978B0", VA = "0x180A98AB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private CGOJFHAAFAK MHFHIKJOBFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA931D0", Offset = "0xA91FD0", VA = "0x180A931D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x83C8450", Offset = "0x83C7250", VA = "0x1883C8450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool CDKNIBFELHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x24E03D0", Offset = "0x24DF1D0", VA = "0x1824E03D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int NENAECMHKEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x83C8340", Offset = "0x83C7140", VA = "0x1883C8340")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x83C8240", Offset = "0x83C7040", VA = "0x1883C8240")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x83C8840", Offset = "0x83C7640", VA = "0x1883C8840")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x83C83D0", Offset = "0x83C71D0", VA = "0x1883C83D0")]
	private void EJEAACIGCCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x83C8B90", Offset = "0x83C7990", VA = "0x1883C8B90")]
	public void Set(CGOJFHAAFAK ACKMKEADLFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x83C8B40", Offset = "0x83C7940", VA = "0x1883C8B40")]
	public void Set(Texture JDNNGPGPIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x83C8B50", Offset = "0x83C7950", VA = "0x1883C8B50")]
	public void Set(EGHGIIMEGMI HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x83C8330", Offset = "0x83C7130", VA = "0x1883C8330")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x83C8940", Offset = "0x83C7740", VA = "0x1883C8940")]
	public void SetInternal(CGOJFHAAFAK ACKMKEADLFF, [Optional] Texture MLKKIJMGHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x83C8930", Offset = "0x83C7730", VA = "0x1883C8930")]
	public void SetCustomSize(int DGBENPPPOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xAA23A0", Offset = "0xAA11A0", VA = "0x180AA23A0")]
	public void SetAntiAliasing(int PGHOOLFIMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x83C85B0", Offset = "0x83C73B0", VA = "0x1883C85B0")]
	[AsyncStateMachine(typeof(BKGBEJFDLBJ))]
	private void IPGAMIOBHLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x83C8250", Offset = "0x83C7050", VA = "0x1883C8250")]
	private void CJBAOKKHEHO(Texture JDNNGPGPIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x83C8BF0", Offset = "0x83C79F0", VA = "0x1883C8BF0")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, LPGHONBEGBM
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float OMMFPCPMEAB = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void PrepareImposter(GCEDHLINDHC ONHEEOKCMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x83C8200", Offset = "0x83C7000", VA = "0x1883C8200")]
	public void SetReferencePoint(Vector3 JONEPNABAIM, Quaternion NIALEBCNBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x83C8010", Offset = "0x83C6E10", VA = "0x1883C8010")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x83C81E0", Offset = "0x83C6FE0", VA = "0x1883C81E0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2141400", Offset = "0x2140200", VA = "0x182141400")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct NNLPJCOANHM
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static NNLPJCOANHM MKGDDOMLHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float EKIDCJCODME;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2D58AE0", Offset = "0x2D578E0", VA = "0x182D58AE0")]
	public NNLPJCOANHM(float LJLKFELOKFG)
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
		[Cpp2IlInjected.Address(RVA = "0x83CA940", Offset = "0x83C9740", VA = "0x1883CA940", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2941360", Offset = "0x2940160", VA = "0x182941360")]
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
		[LAEBPIHCEIF(FBMDOBLPJCI.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int COIEPNMHKML = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int MMMHMEJMCIK = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> KIDAHLONHKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool BPHLDLPFNDF;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x83C8ED0", Offset = "0x83C7CD0", VA = "0x1883C8ED0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x83C8DD0", Offset = "0x83C7BD0", VA = "0x1883C8DD0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x83C9110", Offset = "0x83C7F10", VA = "0x1883C9110")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CGOJFHAAFAK
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string LBLJDJKEHAN
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	NNLPJCOANHM NNLPJCOANHM
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action PNGKFMNDAFN;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> CIIKIPOJHOC(CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EAFFAMBJHNI(CGOJFHAAFAK FGAEAFBDBPK);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JKJPDPNCMGP();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OLDBGBIKCLM();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool CPACLNNFNCF(uint? DKHJBPJAEON, [Out] HNDICJJKNNH<Texture2D> OEKEIECBPHA);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class APMGAIFJHAF
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x83C2990", Offset = "0x83C1790", VA = "0x1883C2990")]
	public static bool AJLJMGOJNCP(CGOJFHAAFAK GLLLHHDJGBC, CGOJFHAAFAK CLPCGIIAAEG)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, LPGHONBEGBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x83C32C0", Offset = "0x83C20C0", VA = "0x1883C32C0", Slot = "4")]
		public void PrepareImposter(GCEDHLINDHC ONHEEOKCMKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA969E0", Offset = "0xA957E0", VA = "0x180A969E0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA969E0", Offset = "0xA957E0", VA = "0x180A969E0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface LPGHONBEGBM
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(GCEDHLINDHC ONHEEOKCMKO);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface AFHHMPBCBPK
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> KFLBKKCAALM
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> EEELGNHDLDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface GAMMPLGCBNP
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IOGOLBINJEO(params Type[] FKDLLLIDCPB);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T MEPKNOBJHOO<T>(T BLNABJHHOFA, Transform PJGOIMBEKPK, bool HHHEELBMGHI = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T MEPKNOBJHOO<T>(GameObject BLNABJHHOFA, Transform PJGOIMBEKPK, bool HHHEELBMGHI = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GameObject MEPKNOBJHOO(GameObject BLNABJHHOFA, Transform PJGOIMBEKPK, GCEDHLINDHC ONHEEOKCMKO, bool HHHEELBMGHI);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class OGLFCHEEBCL : IDisposable, GAMMPLGCBNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> ECKPJJGNCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> LHKDEFEMHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform KHCNCNHGLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> DFLMMKMHBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> PENJIINKHCO;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x83C98E0", Offset = "0x83C86E0", VA = "0x1883C98E0")]
	[NKOKDPHOKEP.APMGAGDLDLC]
	public static void DKLHNMBDELP(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x83CA250", Offset = "0x83C9050", VA = "0x1883CA250")]
	[UnityEngine.Scripting.Preserve]
	public OGLFCHEEBCL([POMNKOCGGBN(null)] AFHHMPBCBPK FHOPFBELMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x83C99E0", Offset = "0x83C87E0", VA = "0x1883C99E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x83CA170", Offset = "0x83C8F70", VA = "0x1883CA170", Slot = "5")]
	public void IOGOLBINJEO(params Type[] FKDLLLIDCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3EB2FA0", Offset = "0x3EB1DA0", VA = "0x183EB2FA0", Slot = "6")]
	public T MEPKNOBJHOO<T>(T BLNABJHHOFA, Transform PJGOIMBEKPK, bool HHHEELBMGHI = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3EB3050", Offset = "0x3EB1E50", VA = "0x183EB3050", Slot = "7")]
	public T MEPKNOBJHOO<T>(GameObject BLNABJHHOFA, Transform PJGOIMBEKPK, bool HHHEELBMGHI = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x83CA1C0", Offset = "0x83C8FC0", VA = "0x1883CA1C0", Slot = "8")]
	public GameObject MEPKNOBJHOO(GameObject BLNABJHHOFA, Transform PJGOIMBEKPK, GCEDHLINDHC ONHEEOKCMKO, bool HHHEELBMGHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3EB3010", Offset = "0x3EB1E10", VA = "0x183EB3010", Slot = "9")]
	public T MEPKNOBJHOO<T>(GameObject BLNABJHHOFA, Transform PJGOIMBEKPK, GCEDHLINDHC ONHEEOKCMKO, bool HHHEELBMGHI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3EB3080", Offset = "0x3EB1E80", VA = "0x183EB3080")]
	private T MEPKNOBJHOO<T>(GameObject BLNABJHHOFA, Transform PJGOIMBEKPK, GCEDHLINDHC ONHEEOKCMKO, bool HHHEELBMGHI, [Out] GameObject OIEDEFINKDM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3EB2CB0", Offset = "0x3EB1AB0", VA = "0x183EB2CB0")]
	private T AJKIGFAAFBL<T>(GameObject DFFAMKHOIDB, GCEDHLINDHC ONHEEOKCMKO, bool HHHEELBMGHI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x83C96B0", Offset = "0x83C84B0", VA = "0x1883C96B0")]
	private void BPDCNDBNMEB(GCEDHLINDHC ONHEEOKCMKO, bool HHHEELBMGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x83C9480", Offset = "0x83C8280", VA = "0x1883C9480")]
	private void ABCBALIJJMO(GCEDHLINDHC ONHEEOKCMKO, bool HHHEELBMGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x83C9AC0", Offset = "0x83C88C0", VA = "0x1883C9AC0")]
	private void ENOHGGOPMIF(Component PGJHFGMMOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x83C9210", Offset = "0x83C8010", VA = "0x1883C9210")]
	private void ABCBALIJJMO(Component PGJHFGMMOON, GCEDHLINDHC ONHEEOKCMKO, bool HHHEELBMGHI, bool KCCBPFNMIDF, [Optional] Type IACHCLBDJID, [Optional] Type AOAAFCLFIIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x83C9D40", Offset = "0x83C8B40", VA = "0x1883C9D40")]
	private void IKHDJOPKKMM(Component PGJHFGMMOON, GCEDHLINDHC ONHEEOKCMKO, bool HHHEELBMGHI, bool KCCBPFNMIDF, [Optional] Type IACHCLBDJID, [Optional] Type AOAAFCLFIIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x83C9BD0", Offset = "0x83C89D0", VA = "0x1883C9BD0")]
	private void GPENNPLEHMF(GameObject DFFAMKHOIDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct GCEDHLINDHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> IJJFFNCMJAG;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3CF35B0", Offset = "0x3CF23B0", VA = "0x183CF35B0")]
	public GCEDHLINDHC BNFJAIPBEBA<T>(T MPJGAOEBIDH)
	{
		return default(GCEDHLINDHC);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3CF44B0", Offset = "0x3CF32B0", VA = "0x183CF44B0")]
	public T DPMBHNJHJDJ<T>(T PGFMONBPOJI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3CF3CE0", Offset = "0x3CF2AE0", VA = "0x183CF3CE0")]
	public bool DDAKMEGCLEF<T>([Out] T MPJGAOEBIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x83C5100", Offset = "0x83C3F00", VA = "0x1883C5100")]
	public void FMJEOCFJDAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct IKOGEALLPFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool KHGHMEPFGGA;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2D58AB0", Offset = "0x2D578B0", VA = "0x182D58AB0")]
	public IKOGEALLPFG(bool KGOOIGLKCIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct AMMPDKKMEGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool HINILBFBMNG;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x83C2980", Offset = "0x83C1780", VA = "0x1883C2980")]
	public AMMPDKKMEGA(bool IEIDLJFFDMP)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA969E0", Offset = "0xA957E0", VA = "0x180A969E0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, LPGHONBEGBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x83CA690", Offset = "0x83C9490", VA = "0x1883CA690", Slot = "4")]
		public void PrepareImposter(GCEDHLINDHC ONHEEOKCMKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA969E0", Offset = "0xA957E0", VA = "0x180A969E0")]
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
		public Bounds OPBPNNGGGMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x83C7E80", Offset = "0x83C6C80", VA = "0x1883C7E80")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x83C7E40", Offset = "0x83C6C40", VA = "0x1883C7E40")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x83C7E00", Offset = "0x83C6C00", VA = "0x1883C7E00")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x83C7D10", Offset = "0x83C6B10", VA = "0x1883C7D10")]
		private void CGNHJHGPAHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA969E0", Offset = "0xA957E0", VA = "0x180A969E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x83C91B0", Offset = "0x83C7FB0", VA = "0x1883C91B0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x83C91A0", Offset = "0x83C7FA0", VA = "0x1883C91A0")]
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
		[JGMPKKPOOFB("frameCameraToImposterBounds", true)]
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
		[JGMPKKPOOFB("autoRotateYawImposter", true)]
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
		[Cpp2IlInjected.Address(RVA = "0x83C8D30", Offset = "0x83C7B30", VA = "0x1883C8D30")]
		public void JNCBCMNOBEK(Vector3 EHGNGBDPBKM, Quaternion CFNEMKEDFGD, float LNINPLNMBLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x83C8D60", Offset = "0x83C7B60", VA = "0x1883C8D60")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class HHGEOPGBLLB
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly Vector3 LFFICNGHAHG;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly List<URPLight> NJFNEGDOMMK;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<Light> JIBNPEIKLLM;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Camera PLFOCDIPKFC;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly List<Renderer> PENOPDFEOEF;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<ImposterBoundsOverride> CJHAIAGCGBG;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static AmbientMode KNLJNIPGEKJ;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static Color HJPLHKPOCEG;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static Color BGHBJHDIDKI;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Color LODFGCCOOBD;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static Cubemap EBIIJJBDIPE;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static bool NMPGFFCOIEI;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> PCOKNAKIDFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x83C5F50", Offset = "0x83C4D50", VA = "0x1883C5F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> CBDABDACMEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x83C71B0", Offset = "0x83C5FB0", VA = "0x1883C71B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera GKBFFOHCGBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x83C78D0", Offset = "0x83C66D0", VA = "0x1883C78D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x83C5660", Offset = "0x83C4460", VA = "0x1883C5660")]
	public static void BFAEBBBPPPF(Vector3 KMFGNOCBLJP, Quaternion IFEAPIGEBBK, ImposterRenderConfig COLCADJGMEA, bool OBIPEJECPPE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x83C5C30", Offset = "0x83C4A30", VA = "0x1883C5C30")]
	private static void EIONLDJKDBG(Vector3 KMFGNOCBLJP, Quaternion IFEAPIGEBBK, URPLight FPOJOMCDBEB, ImposterRenderConfig.LightConfig FIAOLKMLGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x83C6070", Offset = "0x83C4E70", VA = "0x1883C6070")]
	public static void HIAAIJFJJNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x83C7200", Offset = "0x83C6000", VA = "0x1883C7200")]
	private static void MKGIHGHBKJE(int DAKOJACLBKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x83C64C0", Offset = "0x83C52C0", VA = "0x1883C64C0")]
	public static void IGGIHGJLEKB(ImposterRenderConfig COLCADJGMEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x83C5580", Offset = "0x83C4380", VA = "0x1883C5580")]
	public static void BDPFCEEAJHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x83C58F0", Offset = "0x83C46F0", VA = "0x1883C58F0")]
	public static void BNEBMIMJJMH(GameObject BODPLBIMPHP, RenderTexture LLOJDDLPEIM, ImposterRenderConfig COLCADJGMEA, NNLPJCOANHM OFPIEHODBOL, [Optional] Vector3? DMKDCOHHDCO, [Optional] Vector3? FGEKACHJIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x83C6B80", Offset = "0x83C5980", VA = "0x1883C6B80")]
	private static void KBKEIMIKNIP(GameObject BODPLBIMPHP, RenderTexture LLOJDDLPEIM, ImposterRenderConfig COLCADJGMEA, NNLPJCOANHM OFPIEHODBOL, Vector3 DMKDCOHHDCO, Vector3 FGEKACHJIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x83C7610", Offset = "0x83C6410", VA = "0x1883C7610")]
	private static void NGONPHMHHFP(GameObject BODPLBIMPHP, Vector3 GJOPIJPNBML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x83C6150", Offset = "0x83C4F50", VA = "0x1883C6150")]
	public static void HJMFICFKHBD(Bounds AOHIOPOKGED, ImposterRenderConfig COLCADJGMEA, [Out] Vector3 DKFPMNBEGJB, [Out] Quaternion KBJLKDOPLNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x83C6670", Offset = "0x83C5470", VA = "0x1883C6670")]
	private static void JHOIICGNMNH(GameObject BLNABJHHOFA, ImposterRenderConfig COLCADJGMEA, NNLPJCOANHM OFPIEHODBOL, [Out] Vector3 DKFPMNBEGJB, [Out] Quaternion KBJLKDOPLNL, [Out] float LMEKBMLCGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x83C5FA0", Offset = "0x83C4DA0", VA = "0x1883C5FA0")]
	public static RenderTexture GLFDOJHGEJB(int FIJCBEGFDBD, int HBJICDOMHDE, RenderTextureFormat DILPKDIDKCM = RenderTextureFormat.ARGB32, string LCEIMAHCAGM = "[ImposterRendering]Preview")
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
		public struct GOLNCDBEMFC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public EPDLJACCEEM LHFGIHJIPGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public GameObject KPGHOLINLMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public RenderTexture CMLMOKPNHMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public ImposterRenderConfig IKIMFGJFNCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public NNLPJCOANHM NNLPJCOANHM;

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x83C5510", Offset = "0x83C4310", VA = "0x1883C5510")]
			public GOLNCDBEMFC(EPDLJACCEEM LDOEPLPMHHM, GameObject FNCODKLDHKD, RenderTexture LLOJDDLPEIM, ImposterRenderConfig FBDPHBONDIL, NNLPJCOANHM OFPIEHODBOL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static KODEPIGHBEG<GOLNCDBEMFC, RenderTexture> OIEJMBDJLOC;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly List<GOLNCDBEMFC> NKOBOLKLFCC;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int BOMKEJLOKOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x83C3620", Offset = "0x83C2420", VA = "0x1883C3620")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x83C39E0", Offset = "0x83C27E0", VA = "0x1883C39E0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject BODPLBIMPHP, RenderTexture LLOJDDLPEIM, ImposterRenderConfig COLCADJGMEA, NNLPJCOANHM OFPIEHODBOL, CancellationToken BKHGNHANFKK, bool HBNIKBHDDNG = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x83C3410", Offset = "0x83C2210", VA = "0x1883C3410", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x83C3950", Offset = "0x83C2750", VA = "0x1883C3950", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x83C36B0", Offset = "0x83C24B0", VA = "0x1883C36B0")]
		private static Task<RenderTexture> EJMOBIKEBJD(GOLNCDBEMFC LFMGBMKLLLP, CancellationToken BKHGNHANFKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x83C3DE0", Offset = "0x83C2BE0", VA = "0x1883C3DE0")]
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
