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
	public class _AssemblyIndex : PBJLLMOALLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6BA9100", Offset = "0x6BA7B00", VA = "0x186BA9100", Slot = "8")]
		public override void BHEMPDPJNII(CGCPPALGHJA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x632F010", Offset = "0x632DA10", VA = "0x18632F010")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6BA73D0", Offset = "0x6BA5DD0", VA = "0x186BA73D0")]
		public CoordinationBeaconScriptableConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PEMCFJMHHMM
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static CoordinationBeaconScriptableConfig DFEEMNKDOMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6BA8C80", Offset = "0x6BA7680", VA = "0x186BA8C80")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PAMHMDIAMHC
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CoordinationBeacon> PFOCIHOBLBL();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FNOHFPMIECE(Guid IMDAPDGPENA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MPKJNJPFJJJ(int FENFEOLFMEM, [Out] CoordinationBeacon GIJJELNONMN);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface AFFFMFFAHAA
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float CEFFGBHECAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float LOIHDHOLDCM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool OGOKFFIKMNF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HACLAGOLALL
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task EALNMHMKEBA(Guid IMDAPDGPENA, int FENFEOLFMEM, Vector3 DNEGANNBNIM, LPJBFHNAJCN EIGKPCONJCB, Color FEHNKBJAMFH);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NKBDKGMPPMN(Guid IMDAPDGPENA);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DFBAANFCOCJ(int FENFEOLFMEM, [Out] Guid OHIGMKDFLHM);
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
		private float BPMNBGCNNPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool IGFNJIKDEIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private float BIADABGEFDC;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Guid OMPMKCIPJEE
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xE883A0", Offset = "0xE86DA0", VA = "0x180E883A0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x18776A0", Offset = "0x18760A0", VA = "0x1818776A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int OBCNBKPFFAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8B58D0", Offset = "0x8B42D0", VA = "0x1808B58D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xE507F0", Offset = "0xE4F1F0", VA = "0x180E507F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public LPJBFHNAJCN PBHDHDJFPDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8B58E0", Offset = "0x8B42E0", VA = "0x1808B58E0")]
			[CompilerGenerated]
			get
			{
				return default(LPJBFHNAJCN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x1301900", Offset = "0x1300300", VA = "0x181301900")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<Guid> GMIKGEKINMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6BA7540", Offset = "0x6BA5F40", VA = "0x186BA7540")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6BA75F0", Offset = "0x6BA5FF0", VA = "0x186BA75F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6BA74D0", Offset = "0x6BA5ED0", VA = "0x186BA74D0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6BA7450", Offset = "0x6BA5E50", VA = "0x186BA7450")]
		public void Initialize(Guid IMDAPDGPENA, int FLKLGJLEFDN, LPJBFHNAJCN EIGKPCONJCB, Color FEHNKBJAMFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6BA74B0", Offset = "0x6BA5EB0", VA = "0x186BA74B0")]
		public void StartTimer(float KBPKCMOLNGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6BA74C0", Offset = "0x6BA5EC0", VA = "0x186BA74C0")]
		public void StopTimer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6BA7460", Offset = "0x6BA5E60", VA = "0x186BA7460")]
		public void SetVisibility(bool HGLBAGAGDBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6BA7410", Offset = "0x6BA5E10", VA = "0x186BA7410")]
		private void FAGGEBONHGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x897340", Offset = "0x895D40", VA = "0x180897340")]
		public CoordinationBeacon()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class BPBDHMDNHJH : AFFFMFFAHAA
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static LEBBOCDPOJL MMONEJKNGMO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float CEFFGBHECAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6BA72E0", Offset = "0x6BA5CE0", VA = "0x186BA72E0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float LOIHDHOLDCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6BA7260", Offset = "0x6BA5C60", VA = "0x186BA7260", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool OGOKFFIKMNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6BA7140", Offset = "0x6BA5B40", VA = "0x186BA7140", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6BA7360", Offset = "0x6BA5D60", VA = "0x186BA7360")]
	[RecRoom.NoEngine.Common.Preserve]
	public BPBDHMDNHJH([OLJNBPOCBCJ(null)] LEBBOCDPOJL JGGOGAFIBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6BA70D0", Offset = "0x6BA5AD0", VA = "0x186BA70D0")]
	[DJINMBCHLNM.PJKIGKAPDIK.PCJJKFLDJEL]
	internal static void ABFKOJMEBJE(JEFLJDHAGDI EOPOOELIKIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum LPJBFHNAJCN
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
public class KBAAHEMPFKI : PAMHMDIAMHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private class APMFNPKPJHN
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public CoordinationBeacon ADDKOPIONME
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool GOPKNBCKDJC
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xAC0390", Offset = "0xABED90", VA = "0x180AC0390")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8A08A0", Offset = "0x89F2A0", VA = "0x1808A08A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5E0A3D0", Offset = "0x5E08DD0", VA = "0x185E0A3D0")]
		public APMFNPKPJHN(CoordinationBeacon GCPOOCFELBK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct FFIOOFHPAHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder<CoordinationBeacon> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public KBAAHEMPFKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6BA76A0", Offset = "0x6BA60A0", VA = "0x186BA76A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6BA7CA0", Offset = "0x6BA66A0", VA = "0x186BA7CA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly AFFFMFFAHAA MBDABDKBJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<APMFNPKPJHN> HMJEGGCHPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly List<POLPOFEBNLM<GameObject>> GNLPDPOBKLO;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6BA80D0", Offset = "0x6BA6AD0", VA = "0x186BA80D0")]
	[DJINMBCHLNM.BKIMOKOFNKD.FLNKNIPJPIH]
	internal static void ABFKOJMEBJE(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6BA8B90", Offset = "0x6BA7590", VA = "0x186BA8B90")]
	[RecRoom.NoEngine.Common.Preserve]
	public KBAAHEMPFKI([OLJNBPOCBCJ(null)] AFFFMFFAHAA DBIKOJALIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6BA8AA0", Offset = "0x6BA74A0", VA = "0x186BA8AA0", Slot = "4")]
	[AsyncStateMachine(typeof(FFIOOFHPAHD))]
	public Task<CoordinationBeacon> PFOCIHOBLBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6BA84F0", Offset = "0x6BA6EF0", VA = "0x186BA84F0", Slot = "5")]
	public void FNOHFPMIECE(Guid IMDAPDGPENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6BA8910", Offset = "0x6BA7310", VA = "0x186BA8910", Slot = "6")]
	public bool MPKJNJPFJJJ(int FENFEOLFMEM, [Out] CoordinationBeacon GIJJELNONMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6BA8140", Offset = "0x6BA6B40", VA = "0x186BA8140", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6BA87A0", Offset = "0x6BA71A0", VA = "0x186BA87A0")]
	private bool GODKLNOKJGG([Out] APMFNPKPJHN OBHJJIGNONG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class JKBFDPCNLHL : HACLAGOLALL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct PHJLKMCGGMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public JKBFDPCNLHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public Guid beaconId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int ownerRecNetAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public LPJBFHNAJCN context;

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
		[Cpp2IlInjected.Address(RVA = "0x6BA8CB0", Offset = "0x6BA76B0", VA = "0x186BA8CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6BA90A0", Offset = "0x6BA7AA0", VA = "0x186BA90A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly AFFFMFFAHAA MBDABDKBJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly PAMHMDIAMHC JJJLKANKNKI;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6BA7D10", Offset = "0x6BA6710", VA = "0x186BA7D10")]
	[DJINMBCHLNM.BKIMOKOFNKD.FLNKNIPJPIH]
	internal static void ABFKOJMEBJE(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x89CB80", Offset = "0x89B580", VA = "0x18089CB80")]
	[RecRoom.NoEngine.Common.Preserve]
	public JKBFDPCNLHL([OLJNBPOCBCJ(null)] AFFFMFFAHAA DBIKOJALIOO, [OLJNBPOCBCJ(null)] PAMHMDIAMHC BDDJFNFCOGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6BA7EB0", Offset = "0x6BA68B0", VA = "0x186BA7EB0", Slot = "4")]
	[AsyncStateMachine(typeof(PHJLKMCGGMC))]
	public Task EALNMHMKEBA(Guid IMDAPDGPENA, int FENFEOLFMEM, Vector3 DNEGANNBNIM, LPJBFHNAJCN EIGKPCONJCB, Color FEHNKBJAMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6BA8000", Offset = "0x6BA6A00", VA = "0x186BA8000", Slot = "5")]
	public void NKBDKGMPPMN(Guid IMDAPDGPENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6BA7D80", Offset = "0x6BA6780", VA = "0x186BA7D80", Slot = "6")]
	public bool DFBAANFCOCJ(int FENFEOLFMEM, [Out] Guid OHIGMKDFLHM)
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
