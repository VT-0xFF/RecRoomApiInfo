using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CoordinateBeacons.Concretes;
using CoordinateBeacons.Configs;
using Cpp2IlInjected;
using RecRoom.Configs;
using RecRoom.DataLayer.Attributes;
using RecRoom.NoEngine.Common;
using UnityEngine;
using UnityEngine.AddressableAssets;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_CoordinateBeacons_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : FDEGBGNEMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6AEDB10", Offset = "0x6AEC510", VA = "0x186AEDB10", Slot = "8")]
		public override void CPJKPCOPIOF(INNEGFJDCKJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x626DEE0", Offset = "0x626C8E0", VA = "0x18626DEE0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace CoordinateBeacons.Configs
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class CoordinationBeaconScriptableConfig : SingletonScriptableObject<CoordinationBeaconScriptableConfig>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private AssetReference _beaconPrefabAssetReference;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public AssetReference BeaconPrefabAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6AEC6B0", Offset = "0x6AEB0B0", VA = "0x186AEC6B0")]
		public CoordinationBeaconScriptableConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class POOOBHJJICK
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static CoordinationBeaconScriptableConfig GHBFIIGNNDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6AEDAE0", Offset = "0x6AEC4E0", VA = "0x186AEDAE0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PGFMLBCEHHK
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CoordinationBeacon> PEDHGKLNOFI();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LHDAABNKIEL(Guid ICBGGPIKAGL);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GEIJOIBKEKP(int DPAFJPLKIAL, [Out] CoordinationBeacon FLGHMDKKILP);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface EKNCODACCDH
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float KJHMDHHFAFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float DLADJAEONMC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool MCABKGGMMMG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface IEKBKLKJEDH
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task OKMPABDLOJI(Guid ICBGGPIKAGL, int DPAFJPLKIAL, Vector3 LGLIJEKAICC, APCPLNGJJKB MPOBGCPIOEI, Color BJCIGJMGMBG);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KAEOLDDGBPG(Guid ICBGGPIKAGL);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GODHEFFOMKE(int DPAFJPLKIAL, [Out] Guid BDBFKPLLCAI);
}
namespace CoordinateBeacons.Concretes
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class CoordinationBeacon : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private SpriteRenderer _iconRegularSpriteRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private SpriteRenderer _iconDepthIgnoreSpriteRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private float GFIICBDBMMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool DGIHDPCFLJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private float BHBCFDFJLHL;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Guid POAGINPHPCH
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xE73910", Offset = "0xE72310", VA = "0x180E73910")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x1861280", Offset = "0x185FC80", VA = "0x181861280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int NMJPKJNNFLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8A2140", Offset = "0x8A0B40", VA = "0x1808A2140")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xE3C900", Offset = "0xE3B300", VA = "0x180E3C900")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public APCPLNGJJKB FHCCMGMAEMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8A2150", Offset = "0x8A0B50", VA = "0x1808A2150")]
			[CompilerGenerated]
			get
			{
				return default(APCPLNGJJKB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x12D90F0", Offset = "0x12D7AF0", VA = "0x1812D90F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<Guid> FGBNCBBAMCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6AEC820", Offset = "0x6AEB220", VA = "0x186AEC820")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6AEC8D0", Offset = "0x6AEB2D0", VA = "0x186AEC8D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6AEC7B0", Offset = "0x6AEB1B0", VA = "0x186AEC7B0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6AEC6F0", Offset = "0x6AEB0F0", VA = "0x186AEC6F0")]
		public void Initialize(Guid ICBGGPIKAGL, int KKINMHFAFPD, APCPLNGJJKB MPOBGCPIOEI, Color BJCIGJMGMBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6AEC790", Offset = "0x6AEB190", VA = "0x186AEC790")]
		public void StartTimer(float HKAHAODILFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6AEC7A0", Offset = "0x6AEB1A0", VA = "0x186AEC7A0")]
		public void StopTimer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6AEC740", Offset = "0x6AEB140", VA = "0x186AEC740")]
		public void SetVisibility(bool EIMECBCGEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6AEC700", Offset = "0x6AEB100", VA = "0x186AEC700")]
		private void PFPHAHGMDNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
		public CoordinationBeacon()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class KNKBECKIJMD : EKNCODACCDH
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static OKLMGPLPKNE GEIHIJIEJKK;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float KJHMDHHFAFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6AECDA0", Offset = "0x6AEB7A0", VA = "0x186AECDA0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float DLADJAEONMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6AECE20", Offset = "0x6AEB820", VA = "0x186AECE20", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool MCABKGGMMMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6AECEA0", Offset = "0x6AEB8A0", VA = "0x186AECEA0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6AECFC0", Offset = "0x6AEB9C0", VA = "0x186AECFC0")]
	[RecRoom.NoEngine.Common.Preserve]
	public KNKBECKIJMD([LKKACOOMNBP(null)] OKLMGPLPKNE KGEAHMJPFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6AECD30", Offset = "0x6AEB730", VA = "0x186AECD30")]
	[MDINNNLEANF.KEEBDGCHOPC.PPGDDFHJFHO]
	internal static void BIJCGGGFNIO(FNNNJBMCDDC NKDOKEFKKDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum APCPLNGJJKB
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	POINT_OF_INTEREST,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	PLAYER,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	INTERACTIVE_OBJECT,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	HELP_NEEDED,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	WATCH_OUT
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class BDIJBJMJNAM : PGFMLBCEHHK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private class LKOKKBCKBOH
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public CoordinationBeacon DENIALMGDKN
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool BKJNELOBHFP
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xAAC0B0", Offset = "0xAAAAB0", VA = "0x180AAC0B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x88CDB0", Offset = "0x88B7B0", VA = "0x18088CDB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5D4A700", Offset = "0x5D49100", VA = "0x185D4A700")]
		public LKOKKBCKBOH(CoordinationBeacon OCPMCGCOLKH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct MPAIDEGOIHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<CoordinationBeacon> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public BDIJBJMJNAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6AED030", Offset = "0x6AEBA30", VA = "0x186AED030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6AED620", Offset = "0x6AEC020", VA = "0x186AED620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly EKNCODACCDH MNECMHBHBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<LKOKKBCKBOH> JIGPOBLMAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly List<NNLLBGLJADF<GameObject>> FKDLEBBFDPB;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6AEBB00", Offset = "0x6AEA500", VA = "0x186AEBB00")]
	[MDINNNLEANF.KOGFDGIBLGF.BIFDJBAGEKD]
	internal static void BIJCGGGFNIO(FNNNJBMCDDC NKDOKEFKKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC5C0", Offset = "0x6AEAFC0", VA = "0x186AEC5C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public BDIJBJMJNAM([LKKACOOMNBP(null)] EKNCODACCDH HCHLIAOEMOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC4D0", Offset = "0x6AEAED0", VA = "0x186AEC4D0", Slot = "4")]
	[AsyncStateMachine(typeof(MPAIDEGOIHB))]
	public Task<CoordinationBeacon> PEDHGKLNOFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC220", Offset = "0x6AEAC20", VA = "0x186AEC220", Slot = "5")]
	public void LHDAABNKIEL(Guid ICBGGPIKAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6AEBF20", Offset = "0x6AEA920", VA = "0x186AEBF20", Slot = "6")]
	public bool GEIJOIBKEKP(int DPAFJPLKIAL, [Out] CoordinationBeacon FLGHMDKKILP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6AEBB70", Offset = "0x6AEA570", VA = "0x186AEBB70", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC0B0", Offset = "0x6AEAAB0", VA = "0x186AEC0B0")]
	private bool IAIHLJHIDBI([Out] LKOKKBCKBOH APILDFBICGD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class IAHDONFANOK : IEKBKLKJEDH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct OELFJDDCHGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public IAHDONFANOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public Guid beaconId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int ownerRecNetAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public APCPLNGJJKB context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public Color color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public Vector3 worldSpacePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private TaskAwaiter<CoordinationBeacon> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6AED690", Offset = "0x6AEC090", VA = "0x186AED690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6AEDA80", Offset = "0x6AEC480", VA = "0x186AEDA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly EKNCODACCDH MNECMHBHBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly PGFMLBCEHHK PPJPCDJGOIN;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC980", Offset = "0x6AEB380", VA = "0x186AEC980")]
	[MDINNNLEANF.KOGFDGIBLGF.BIFDJBAGEKD]
	internal static void BIJCGGGFNIO(FNNNJBMCDDC NKDOKEFKKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x887590", Offset = "0x885F90", VA = "0x180887590")]
	[RecRoom.NoEngine.Common.Preserve]
	public IAHDONFANOK([LKKACOOMNBP(null)] EKNCODACCDH HCHLIAOEMOO, [LKKACOOMNBP(null)] PGFMLBCEHHK JEHAACOHJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6AECBE0", Offset = "0x6AEB5E0", VA = "0x186AECBE0", Slot = "4")]
	[AsyncStateMachine(typeof(OELFJDDCHGG))]
	public Task OKMPABDLOJI(Guid ICBGGPIKAGL, int DPAFJPLKIAL, Vector3 LGLIJEKAICC, APCPLNGJJKB MPOBGCPIOEI, Color BJCIGJMGMBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6AECB10", Offset = "0x6AEB510", VA = "0x186AECB10", Slot = "5")]
	public void KAEOLDDGBPG(Guid ICBGGPIKAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC9F0", Offset = "0x6AEB3F0", VA = "0x186AEC9F0", Slot = "6")]
	public bool GODHEFFOMKE(int DPAFJPLKIAL, [Out] Guid BDBFKPLLCAI)
	{
		return default(bool);
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
