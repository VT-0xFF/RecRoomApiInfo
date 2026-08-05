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
	public class _AssemblyIndex : GADMOBJFAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6D32640", Offset = "0x6D31A40", VA = "0x186D32640", Slot = "8")]
		public override void NALDPPFDOAA(JBGBENDLNHF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x64A1D70", Offset = "0x64A1170", VA = "0x1864A1D70")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6D30630", Offset = "0x6D2FA30", VA = "0x186D30630")]
		public CoordinationBeaconScriptableConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class FJDHECEPJIG
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static CoordinationBeaconScriptableConfig FKMJLLKHOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6D31050", Offset = "0x6D30450", VA = "0x186D31050")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface HBEGDOOKGFB
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CoordinationBeacon> BMFIMMABJPO();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BJCMANKMNHL(Guid BFDKKIJCPND);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JNBICJJLDEA(int MPBCJIKLLGA, [Out] CoordinationBeacon PIPOFCOFMNL);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface NDIDCHEHJHP
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float DIEDHCKJDBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float KEEEGLADHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool MABOPNMEMJH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface GDAIKDLDEGI
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task CAHOJGCIFGF(Guid BFDKKIJCPND, int MPBCJIKLLGA, Vector3 GLLGCJDBMMN, DIBPHDLEKMI JCPOMHNJOIE, Color DFKHKPKCOFI);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EEOBEDMELCD(Guid BFDKKIJCPND);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IDAHOEKOKFE(int MPBCJIKLLGA, [Out] Guid ECCLCNBLBJJ);
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
		private float BLLJIBDDNOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool ICPJGPJCDCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private float CJNMKOJJNLO;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Guid BMLMCKPLKGH
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xF4BA90", Offset = "0xF4AE90", VA = "0x180F4BA90")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x19BBB30", Offset = "0x19BAF30", VA = "0x1819BBB30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int FJBFLAKMNIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8C8A80", Offset = "0x8C7E80", VA = "0x1808C8A80")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xF2D4F0", Offset = "0xF2C8F0", VA = "0x180F2D4F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public DIBPHDLEKMI PKLKHEINCJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8C8A90", Offset = "0x8C7E90", VA = "0x1808C8A90")]
			[CompilerGenerated]
			get
			{
				return default(DIBPHDLEKMI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x13B3F80", Offset = "0x13B3380", VA = "0x1813B3F80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<Guid> BAFKIGJCKKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6D307A0", Offset = "0x6D2FBA0", VA = "0x186D307A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6D30850", Offset = "0x6D2FC50", VA = "0x186D30850")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6D30730", Offset = "0x6D2FB30", VA = "0x186D30730")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6D306B0", Offset = "0x6D2FAB0", VA = "0x186D306B0")]
		public void Initialize(Guid BFDKKIJCPND, int HGHFGJCHCCF, DIBPHDLEKMI JCPOMHNJOIE, Color DFKHKPKCOFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6D30710", Offset = "0x6D2FB10", VA = "0x186D30710")]
		public void StartTimer(float KDNLHNMJFBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6D30720", Offset = "0x6D2FB20", VA = "0x186D30720")]
		public void StopTimer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6D306C0", Offset = "0x6D2FAC0", VA = "0x186D306C0")]
		public void SetVisibility(bool CKLACCPDBBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6D30670", Offset = "0x6D2FA70", VA = "0x186D30670")]
		private void HNDJNMHNNBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE20", Offset = "0x8AB220", VA = "0x1808ABE20")]
		public CoordinationBeacon()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class EBFKAGGBJGH : NDIDCHEHJHP
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static CCENJGFOMNL DDEODOKIJEE;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float DIEDHCKJDBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6D30900", Offset = "0x6D2FD00", VA = "0x186D30900", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float KEEEGLADHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6D309F0", Offset = "0x6D2FDF0", VA = "0x186D309F0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool MABOPNMEMJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6D30A70", Offset = "0x6D2FE70", VA = "0x186D30A70", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6D30B90", Offset = "0x6D2FF90", VA = "0x186D30B90")]
	[RecRoom.NoEngine.Common.Preserve]
	public EBFKAGGBJGH([ACGOIOBGIEE(null)] CCENJGFOMNL LJNLIKDCHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6D30980", Offset = "0x6D2FD80", VA = "0x186D30980")]
	[FHFMOACGLML.LJNENKAOIID.CBBLLNOFCJC]
	internal static void IBMMKCGOKOK(ACFNHMKNHLL KLAPMCLMAPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum DIBPHDLEKMI
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
public class GFMDPJIPEPE : HBEGDOOKGFB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private class NKPDAMOOEKG
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public CoordinationBeacon KJPIEBHCAAF
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool KJLECOACFNC
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xB81E30", Offset = "0xB81230", VA = "0x180B81E30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8B60D0", Offset = "0x8B54D0", VA = "0x1808B60D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5F7B420", Offset = "0x5F7A820", VA = "0x185F7B420")]
		public NKPDAMOOEKG(CoordinationBeacon KBAMADDAEGH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct OEMCJJKNDLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<CoordinationBeacon> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public GFMDPJIPEPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6D31FE0", Offset = "0x6D313E0", VA = "0x186D31FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6D325D0", Offset = "0x6D319D0", VA = "0x186D325D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly NDIDCHEHJHP GLKOAGFLAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<NKPDAMOOEKG> NJLNDPGLGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly List<FLIAEPPCPCN<GameObject>> IGGECGFJHHP;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6D31940", Offset = "0x6D30D40", VA = "0x186D31940")]
	[FHFMOACGLML.FCMFIOLNDJB.DDEGNENCINE]
	internal static void IBMMKCGOKOK(ACFNHMKNHLL KLAPMCLMAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6D31B40", Offset = "0x6D30F40", VA = "0x186D31B40")]
	[RecRoom.NoEngine.Common.Preserve]
	public GFMDPJIPEPE([ACGOIOBGIEE(null)] NDIDCHEHJHP IEOFCCGBKMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6D314A0", Offset = "0x6D308A0", VA = "0x186D314A0", Slot = "4")]
	[AsyncStateMachine(typeof(OEMCJJKNDLG))]
	public Task<CoordinationBeacon> BMFIMMABJPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6D311F0", Offset = "0x6D305F0", VA = "0x186D311F0", Slot = "5")]
	public void BJCMANKMNHL(Guid BFDKKIJCPND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6D319B0", Offset = "0x6D30DB0", VA = "0x186D319B0", Slot = "6")]
	public bool JNBICJJLDEA(int MPBCJIKLLGA, [Out] CoordinationBeacon PIPOFCOFMNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6D31590", Offset = "0x6D30990", VA = "0x186D31590", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6D31080", Offset = "0x6D30480", VA = "0x186D31080")]
	private bool APBKOFMKOLH([Out] NKPDAMOOEKG CCJDPDNMKKF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class LMGKILEHMBJ : GDAIKDLDEGI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct EOPOLNBIJAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public LMGKILEHMBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public Guid beaconId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int ownerRecNetAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public DIBPHDLEKMI context;

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
		[Cpp2IlInjected.Address(RVA = "0x6D30C00", Offset = "0x6D30000", VA = "0x186D30C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6D30FF0", Offset = "0x6D303F0", VA = "0x186D30FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly NDIDCHEHJHP GLKOAGFLAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly HBEGDOOKGFB DLHFLECFNDC;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6D31E50", Offset = "0x6D31250", VA = "0x186D31E50")]
	[FHFMOACGLML.FCMFIOLNDJB.DDEGNENCINE]
	internal static void IBMMKCGOKOK(ACFNHMKNHLL KLAPMCLMAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8A9CD0", Offset = "0x8A90D0", VA = "0x1808A9CD0")]
	[RecRoom.NoEngine.Common.Preserve]
	public LMGKILEHMBJ([ACGOIOBGIEE(null)] NDIDCHEHJHP IEOFCCGBKMF, [ACGOIOBGIEE(null)] HBEGDOOKGFB LGGGOLIBBMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6D31C30", Offset = "0x6D31030", VA = "0x186D31C30", Slot = "4")]
	[AsyncStateMachine(typeof(EOPOLNBIJAC))]
	public Task CAHOJGCIFGF(Guid BFDKKIJCPND, int MPBCJIKLLGA, Vector3 GLLGCJDBMMN, DIBPHDLEKMI JCPOMHNJOIE, Color DFKHKPKCOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6D31D80", Offset = "0x6D31180", VA = "0x186D31D80", Slot = "5")]
	public void EEOBEDMELCD(Guid BFDKKIJCPND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6D31EC0", Offset = "0x6D312C0", VA = "0x186D31EC0", Slot = "6")]
	public bool IDAHOEKOKFE(int MPBCJIKLLGA, [Out] Guid ECCLCNBLBJJ)
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
