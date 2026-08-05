using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2AF22C0", Offset = "0x2AF10C0", VA = "0x182AF22C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xABFA20", Offset = "0xABE820", VA = "0x180ABFA20")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xABFA60", Offset = "0xABE860", VA = "0x180ABFA60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HCFFCLAMEEF : FCKCACEJLLC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2280", Offset = "0x2AF1080", VA = "0x182AF2280", Slot = "7")]
	public override string PGDOAEFAHEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2AF22B0", Offset = "0x2AF10B0", VA = "0x182AF22B0")]
	private HCFFCLAMEEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2230", Offset = "0x2AF1030", VA = "0x182AF2230")]
	public static HCFFCLAMEEF ELDPFIHNJDG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct MBCCNJMJGDN<TPartialAction, TPartialActionId, TFullAction, TDeps> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull where TDeps : notnull, ICACBOAFKLD.ELKHCPDENOK<TPartialAction, TPartialActionId, TFullAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class PGBENEOCKBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly TPartialAction?[] OCLELCOBNAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int JBHHEMOPNJE;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x10058E0", Offset = "0x10046E0", VA = "0x1810058E0")]
		private PGBENEOCKBG(TPartialAction[] ACMGLOGPHDN, int JHGIMNGEKDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5BF8F10", Offset = "0x5BF7D10", VA = "0x185BF8F10")]
		public static MBCCNJMJGDN<TPartialAction, TPartialActionId, TFullAction, TDeps>.PGBENEOCKBG ELDPFIHNJDG(int BCEKOFAHDGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5BF9230", Offset = "0x5BF8030", VA = "0x185BF9230")]
		public KJAHANGMDME<TFullAction> JBHNFIDMGPO(TPartialAction IJNNIADGIHG, TDeps OPJFEEDOIEH)
		{
			return default(KJAHANGMDME<TFullAction>);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private Dictionary<TPartialActionId, PGBENEOCKBG>? NBLFCDLBNIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private TDeps BFCDJMDIFNA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Dictionary<TPartialActionId, PGBENEOCKBG> MPCNLDAKCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5882070", Offset = "0x5880E70", VA = "0x185882070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5883000", Offset = "0x5881E00", VA = "0x185883000")]
	private MBCCNJMJGDN(Dictionary<TPartialActionId, PGBENEOCKBG>? JPFCKHLHFLJ, TDeps OPJFEEDOIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5882020", Offset = "0x5880E20", VA = "0x185882020")]
	public static MBCCNJMJGDN<TPartialAction, TPartialActionId, TFullAction, TDeps> ELDPFIHNJDG(TDeps OPJFEEDOIEH)
	{
		return default(MBCCNJMJGDN<TPartialAction, TPartialActionId, TFullAction, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5882150", Offset = "0x5880F50", VA = "0x185882150")]
	public GECIHKBMECG<KJAHANGMDME<TFullAction>, HFPJGMECLBA> JBHNFIDMGPO(TPartialAction IJNNIADGIHG)
	{
		return default(GECIHKBMECG<KJAHANGMDME<TFullAction>, HFPJGMECLBA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5882F50", Offset = "0x5881D50", VA = "0x185882F50")]
	public void KJJPDNMJLHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class ICACBOAFKLD
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface ELKHCPDENOK<TPartialAction, out TPartialActionId, out TFullAction> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int PPFNOPGOICF([In] TPartialAction IJNNIADGIHG);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int ANNJFJBBGLC([In] TPartialAction IJNNIADGIHG);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TPartialActionId HIHNDANCDLP([In] TPartialAction IJNNIADGIHG);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TFullAction NHHAKBJLAKB(TPartialAction[] FDPILCALEGH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct FECCJOJDFNN<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : CAHPEFIBGBO.JBLKFAHCILG<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal TPartialSnapshot[] FGDNKEEMMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal int OJMCDHDIBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal TDeps BFCDJMDIFNA;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4F00260", Offset = "0x4EFF060", VA = "0x184F00260")]
	internal FECCJOJDFNN(TPartialSnapshot[] IGMCIIPMLMM, int CMJEPPJCOMI, TDeps OPJFEEDOIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4F00200", Offset = "0x4EFF000", VA = "0x184F00200")]
	public static FECCJOJDFNN<TPartialSnapshot, TFullSnapshot, TDeps> ELDPFIHNJDG(TDeps OPJFEEDOIEH)
	{
		return default(FECCJOJDFNN<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class CAHPEFIBGBO
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface JBLKFAHCILG<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int BDEPMMJOHOG([In] TPartialSnapshot HGHDNEMAGAI);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot AIMOMIBHCCB(TPartialSnapshot[] EKCHPNJAPMF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3AFDF80", Offset = "0x3AFCD80", VA = "0x183AFDF80")]
	public static KJAHANGMDME<TFullSnapshot> JBHNFIDMGPO<TFullSnapshot, TPartialSnapshot, TDeps>(this FECCJOJDFNN<TPartialSnapshot, TFullSnapshot, TDeps> DBBEADIHLKO, TPartialSnapshot HGHDNEMAGAI) where TDeps : JBLKFAHCILG<TPartialSnapshot, TFullSnapshot>
	{
		return default(KJAHANGMDME<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3AFDE30", Offset = "0x3AFCC30", VA = "0x183AFDE30")]
	public static bool IPICDNFBMKG<TPartialSnapshot, TFullSnapshot, TDeps>(this FECCJOJDFNN<TPartialSnapshot, TFullSnapshot, TDeps> DBBEADIHLKO, TPartialSnapshot HGHDNEMAGAI) where TDeps : JBLKFAHCILG<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class PPBCEMFLDCP : FCKCACEJLLC
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2340", Offset = "0x2AF1140", VA = "0x182AF2340", Slot = "7")]
	public override string PGDOAEFAHEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2AF22B0", Offset = "0x2AF10B0", VA = "0x182AF22B0")]
	public PPBCEMFLDCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class NMLFOCEABCJ<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : JKMPAGDAEHD.DACBMIEMALJ<TAction, TNetSys> where TReceiverDeps : JKMPAGDAEHD.PLNAJAJLLNB<TAction, TReceiver> where TRootDeps : JKMPAGDAEHD.PBAJJOLFMDE<TAction, TRoot> where TDeps : JKMPAGDAEHD.FBFHCMOGFBE<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private interface EKABBMADJNP
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void EFNONEGDKCI([In] GECIHKBMECG<object, HFPJGMECLBA> MOBFLOHJOKJ);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GECIHKBMECG<object, HFPJGMECLBA> HKCCEGACPGF();
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class EKBJIPHGBEE : EKABBMADJNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly List<GECIHKBMECG<object, FHNKPFADLOA>> AJMAPBIEEON;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4A64F30", Offset = "0x4A63D30", VA = "0x184A64F30")]
		public static EKBJIPHGBEE ELDPFIHNJDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4A64D30", Offset = "0x4A63B30", VA = "0x184A64D30")]
		public void EFNONEGDKCI([In] GECIHKBMECG<object, HFPJGMECLBA> MOBFLOHJOKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4A650C0", Offset = "0x4A63EC0", VA = "0x184A650C0", Slot = "5")]
		public GECIHKBMECG<object, HFPJGMECLBA> HKCCEGACPGF()
		{
			return default(GECIHKBMECG<object, HFPJGMECLBA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4A652B0", Offset = "0x4A640B0", VA = "0x184A652B0")]
		public EKBJIPHGBEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4A64FF0", Offset = "0x4A63DF0", VA = "0x184A64FF0", Slot = "4")]
		private void GAKMAJJIILF([In] GECIHKBMECG<object, HFPJGMECLBA> MOBFLOHJOKJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class LMGJHMPCLAI : EKABBMADJNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private GECIHKBMECG<object, HFPJGMECLBA> HHDBHAFHPPI;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4A64F30", Offset = "0x4A63D30", VA = "0x184A64F30")]
		public static LMGJHMPCLAI ELDPFIHNJDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x26A6F20", Offset = "0x26A5D20", VA = "0x1826A6F20")]
		public void EFNONEGDKCI([In] GECIHKBMECG<object, HFPJGMECLBA> MOBFLOHJOKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xEAB020", Offset = "0xEA9E20", VA = "0x180EAB020", Slot = "5")]
		public GECIHKBMECG<object, HFPJGMECLBA> HKCCEGACPGF()
		{
			return default(GECIHKBMECG<object, HFPJGMECLBA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public LMGJHMPCLAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4A64FF0", Offset = "0x4A63DF0", VA = "0x184A64FF0", Slot = "4")]
		private void GAKMAJJIILF([In] GECIHKBMECG<object, HFPJGMECLBA> MOBFLOHJOKJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct DBIBBBECNEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public AsyncTaskMethodBuilder<GECIHKBMECG<object, HFPJGMECLBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public NMLFOCEABCJ<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public PFJMKELOBBL<DLKFGHJHLMA> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TaskAwaiter<GECIHKBMECG<object, HFPJGMECLBA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x452CCB0", Offset = "0x452BAB0", VA = "0x18452CCB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x452CF60", Offset = "0x452BD60", VA = "0x18452CF60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct FPJIMKGGHFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<GECIHKBMECG<object, HFPJGMECLBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public NMLFOCEABCJ<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public PFJMKELOBBL<DLKFGHJHLMA> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private TaskAwaiter<GECIHKBMECG<object, HFPJGMECLBA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4F35590", Offset = "0x4F34390", VA = "0x184F35590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4F35A40", Offset = "0x4F34840", VA = "0x184F35A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct COELPHFONHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder<GECIHKBMECG<object, HFPJGMECLBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public NMLFOCEABCJ<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public PFJMKELOBBL<DLKFGHJHLMA> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<GECIHKBMECG<object, HFPJGMECLBA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6D44910", Offset = "0x6D43710", VA = "0x186D44910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6D44C50", Offset = "0x6D43A50", VA = "0x186D44C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct KCDGKLDLCJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<GECIHKBMECG<object, HFPJGMECLBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public NMLFOCEABCJ<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public PFJMKELOBBL<DLKFGHJHLMA> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private EKABBMADJNP <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x556B780", Offset = "0x556A580", VA = "0x18556B780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x556C320", Offset = "0x556B120", VA = "0x18556C320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct COLAEPFMNBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public NMLFOCEABCJ<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public EKABBMADJNP completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private EKABBMADJNP <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<GECIHKBMECG<object?, HFPJGMECLBA>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6E1BF50", Offset = "0x6E1AD50", VA = "0x186E1BF50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6E21980", Offset = "0x6E20780", VA = "0x186E21980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct MIAFHIHFDEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public TAction[] snapshotActions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NMLFOCEABCJ<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public PFJMKELOBBL<DLKFGHJHLMA> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x58B7780", Offset = "0x58B6580", VA = "0x1858B7780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x58B7B50", Offset = "0x58B6950", VA = "0x1858B7B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly TDeps BFCDJMDIFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool AEJDEFMJOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int PJPFHMBLNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Task KILPJPJIABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int FNJANJLIMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private int POIENFMLIGJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TActionDeps NJPFIPGMLNM
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x59A8A10", Offset = "0x59A7810", VA = "0x1859A8A10")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TRootDeps IEDHHPILOLC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x59A7810", Offset = "0x59A6610", VA = "0x1859A7810")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private TReceiverDeps JGKFLBDOHEO
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x59A78E0", Offset = "0x59A66E0", VA = "0x1859A78E0")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool MADMLJLNPEA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xB7BC30", Offset = "0xB7AA30", VA = "0x180B7BC30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xB7BC40", Offset = "0xB7AA40", VA = "0x180B7BC40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int FJOCANKPENN
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xAE1B10", Offset = "0xAE0910", VA = "0x180AE1B10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int ELBONAJMKFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xAE69D0", Offset = "0xAE57D0", VA = "0x180AE69D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int IDBHMMPBPBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xC38810", Offset = "0xC37610", VA = "0x180C38810")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x59A8C00", Offset = "0x59A7A00", VA = "0x1859A8C00")]
	public NMLFOCEABCJ(TDeps OPJFEEDOIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x59A5800", Offset = "0x59A4600", VA = "0x1859A5800")]
	public Task<GECIHKBMECG<object, HFPJGMECLBA>> CJGPEGMNMCN(TRoot MMENCBNBOBJ, TNetSys PFHCGHGEHDI, PFJMKELOBBL<DLKFGHJHLMA> LBDMJCCNJOD, TAction IJBAPONMLAP, bool AJACKFAPAJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x59A5AE0", Offset = "0x59A48E0", VA = "0x1859A5AE0")]
	[AsyncStateMachine(typeof(NMLFOCEABCJ<, , , , , , , >.DBIBBBECNEB))]
	private Task<GECIHKBMECG<object, HFPJGMECLBA>> CJGPEGMNMCN(TRoot MMENCBNBOBJ, PFJMKELOBBL<DLKFGHJHLMA> LBDMJCCNJOD, TAction IJBAPONMLAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x59A5260", Offset = "0x59A4060", VA = "0x1859A5260")]
	[AsyncStateMachine(typeof(NMLFOCEABCJ<, , , , , , , >.FPJIMKGGHFH))]
	private Task<GECIHKBMECG<object, HFPJGMECLBA>> BLIEPALNGEN(TRoot MMENCBNBOBJ, PFJMKELOBBL<DLKFGHJHLMA> LBDMJCCNJOD, TAction[] PGJKIIMGDBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x59A6DF0", Offset = "0x59A5BF0", VA = "0x1859A6DF0")]
	[AsyncStateMachine(typeof(NMLFOCEABCJ<, , , , , , , >.COELPHFONHP))]
	public Task<GECIHKBMECG<object, HFPJGMECLBA>> FMPDGCGNEKC(TRoot MMENCBNBOBJ, TNetSys DFGPEOEPHCH, TReceiver BIJLHPHALFD, PFJMKELOBBL<DLKFGHJHLMA> LBDMJCCNJOD, TAction IJBAPONMLAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x59A6B00", Offset = "0x59A5900", VA = "0x1859A6B00")]
	[AsyncStateMachine(typeof(NMLFOCEABCJ<, , , , , , , >.KCDGKLDLCJP))]
	private Task<GECIHKBMECG<object, HFPJGMECLBA>> FCNLJIEEJEK(TRoot MMENCBNBOBJ, TNetSys DFGPEOEPHCH, TReceiver BIJLHPHALFD, PFJMKELOBBL<DLKFGHJHLMA> LBDMJCCNJOD, TAction IJBAPONMLAP, Task HACAJDCPDDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x59A6540", Offset = "0x59A5340", VA = "0x1859A6540")]
	[AsyncStateMachine(typeof(NMLFOCEABCJ<, , , , , , , >.COLAEPFMNBN))]
	private Task EADNALDBHOG(TRoot MMENCBNBOBJ, TNetSys DFGPEOEPHCH, TReceiver BIJLHPHALFD, TAction IJBAPONMLAP, EKABBMADJNP GEPKCANNNBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x59A6380", Offset = "0x59A5180", VA = "0x1859A6380")]
	private void DGLLNNLCOMA(TReceiver BIJLHPHALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x59A8640", Offset = "0x59A7440", VA = "0x1859A8640")]
	private void MKCCGPLMBHD(TRoot MMENCBNBOBJ, TNetSys DFGPEOEPHCH, TReceiver BIJLHPHALFD, PFJMKELOBBL<DLKFGHJHLMA> LBDMJCCNJOD, TAction IJBAPONMLAP, bool MCOOEEGMOHG, bool DCDOJKNMBEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x59A7BA0", Offset = "0x59A69A0", VA = "0x1859A7BA0")]
	[AsyncStateMachine(typeof(NMLFOCEABCJ<, , , , , , , >.MIAFHIHFDEA))]
	public Task LMPLGAJLJCL(TRoot MMENCBNBOBJ, TNetSys DFGPEOEPHCH, PFJMKELOBBL<DLKFGHJHLMA> LBDMJCCNJOD, TAction[] PJAOIPGKPEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x59A70D0", Offset = "0x59A5ED0", VA = "0x1859A70D0")]
	private (TAction, int) GDLKBCMNCOK(TRoot MMENCBNBOBJ, TNetSys OBMEHGPNKGF, TAction IJBAPONMLAP)
	{
		return default((TAction, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class JKMPAGDAEHD
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface DACBMIEMALJ<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int FGPBDFAPCPM(TNetSys PGAMHBJJEGM, TAction IJBAPONMLAP);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction AIELKAGJJKO(TNetSys PGAMHBJJEGM, TAction IJBAPONMLAP);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction PLBAPEHHPMB(TNetSys PGAMHBJJEGM, TAction IJBAPONMLAP);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> GOCCKFGOHHO(TNetSys PGAMHBJJEGM, TAction IJBAPONMLAP);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] AINKLKMDNIO(TNetSys PGAMHBJJEGM, TAction IJBAPONMLAP, int NFCBHFIIHFD);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool PPINAKCOLHI(TNetSys PGAMHBJJEGM, TAction IJBAPONMLAP);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool PCPCGPIPHLI(TNetSys PGAMHBJJEGM, TAction IJBAPONMLAP);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool KAIIBBGEFOI(TNetSys PGAMHBJJEGM, TAction IJBAPONMLAP);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool LEJKEAKABBA(TNetSys PGAMHBJJEGM, TAction IJBAPONMLAP);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool MGMGAPFJPEG(TNetSys PGAMHBJJEGM, TAction IJBAPONMLAP);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool DACKMKBMEIB(TNetSys PGAMHBJJEGM, TAction IJBAPONMLAP);
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface FBFHCMOGFBE<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TActionDeps NJPFIPGMLNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		TReceiverDeps JGKFLBDOHEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		TRootDeps IEDHHPILOLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface PLNAJAJLLNB<TAction, TReceiver> where TAction : notnull where TReceiver : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PFJMKELOBBL<DLKFGHJHLMA> LAJEIEPNLMP(TReceiver BIJLHPHALFD);

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MKGLJMCAHGK(TReceiver BIJLHPHALFD);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<GECIHKBMECG<object, HFPJGMECLBA>> FMPDGCGNEKC(TReceiver BIJLHPHALFD, TAction IJBAPONMLAP);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TAction[] KDOKACJNBGN(TReceiver BIJLHPHALFD);
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface PBAJJOLFMDE<TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int OFCMPDOFAFG(TRoot MMENCBNBOBJ);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int GOAFCDAGFHN(TRoot MMENCBNBOBJ);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int NFGEHIFOAHP(TRoot MMENCBNBOBJ);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int MCFAKLKAMAI(TRoot MMENCBNBOBJ);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void JGOLLBMELEF(TRoot MMENCBNBOBJ);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool PGDAPHGMEFJ(TRoot MMENCBNBOBJ, PFJMKELOBBL<DLKFGHJHLMA> LBDMJCCNJOD, TAction[] PGJKIIMGDBO);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool NEJPMMLEMBD(TRoot MMENCBNBOBJ, int PGHNPONLPMN);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task<GECIHKBMECG<object, HFPJGMECLBA>> CJGPEGMNMCN(TRoot MMENCBNBOBJ, PFJMKELOBBL<DLKFGHJHLMA> LBDMJCCNJOD, TAction IJBAPONMLAP, bool EBNCDCINGKM = true);
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
