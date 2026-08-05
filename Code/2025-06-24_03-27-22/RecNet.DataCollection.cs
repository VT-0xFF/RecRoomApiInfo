using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x72AE490", Offset = "0x72AD090", VA = "0x1872AE490")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA48850", Offset = "0xA47450", VA = "0x180A48850")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA48890", Offset = "0xA47490", VA = "0x180A48890")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecNet_DataCollection
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.Logging.Attributes.Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : KHEEPBINELP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x72AD830", Offset = "0x72AC430", VA = "0x1872AD830", Slot = "4")]
		public override void KHPGHNAFBFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecNet_DataCollection
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x72B1A80", Offset = "0x72B0680", VA = "0x1872B1A80", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x27CE7F0", Offset = "0x27CD3F0", VA = "0x1827CE7F0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JIFOMANIMGF
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<string, object> LKOEGPGOMNG();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class ODGNHNIJOHE
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x72AE510", Offset = "0x72AD110", VA = "0x1872AE510")]
	public static void KAAHHGLGCIP(this NMLGHOHBLGO.BHKLBFJIPFD OCBBJACBAIO, string LJMFGNPBIHD, string OPEIBHDJNDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x72AE580", Offset = "0x72AD180", VA = "0x1872AE580")]
	public static void KAAHHGLGCIP(this NMLGHOHBLGO.BHKLBFJIPFD OCBBJACBAIO, string LJMFGNPBIHD, bool OPEIBHDJNDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x72AE610", Offset = "0x72AD210", VA = "0x1872AE610")]
	public static void KAAHHGLGCIP(this NMLGHOHBLGO.BHKLBFJIPFD OCBBJACBAIO, string LJMFGNPBIHD, float OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x72AE710", Offset = "0x72AD310", VA = "0x1872AE710")]
	public static void KAAHHGLGCIP(this NMLGHOHBLGO.BHKLBFJIPFD OCBBJACBAIO, string LJMFGNPBIHD, DDCBIKNOOEN OPEIBHDJNDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class NMLGHOHBLGO
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface GBHAEONELHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		BHKLBFJIPFD FHLJAGGDPBG(Guid JNOOHOGABAI, string ADLAENGIAGH, [Optional] string LNLBGGBIELG, [Optional] long? KBCGHBCMFPD, [Optional] string PBLHCAGNECO, [Optional] string NEMOCPGGCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class HIFAALLIENF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x72AB930", Offset = "0x72AA530", VA = "0x1872AB930")]
		public static BHKLBFJIPFD BPOLDICEFPB(Guid JNOOHOGABAI, string ADLAENGIAGH, string LNLBGGBIELG, [Optional] long? KBCGHBCMFPD, [Optional] string PBLHCAGNECO, [Optional] string NEMOCPGGCEJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class BHKLBFJIPFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected MKIPNPCNFOC AGFKEDPOHKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly IDictionary<string, IDictionary<string, object>> KAPHCNJKLID;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool HNGLKPHHGMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x72A8110", Offset = "0x72A6D10", VA = "0x1872A8110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string OGINKEBADJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x116B720", Offset = "0x116A320", VA = "0x18116B720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x72A8490", Offset = "0x72A7090", VA = "0x1872A8490")]
		public BHKLBFJIPFD(MKIPNPCNFOC AGFKEDPOHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x72A7D10", Offset = "0x72A6910", VA = "0x1872A7D10")]
		public BHKLBFJIPFD BPPGBLBHPKB(string NMCGBFDKCMK, string OOHGFGHCOAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x72A7E90", Offset = "0x72A6A90", VA = "0x1872A7E90")]
		public BHKLBFJIPFD DKCJJNKDDMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x41BDE40", Offset = "0x41BCA40", VA = "0x1841BDE40")]
		public BHKLBFJIPFD BPPGBLBHPKB<T>(string NMCGBFDKCMK, T OOHGFGHCOAJ) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x72A8410", Offset = "0x72A7010", VA = "0x1872A8410")]
		public BHKLBFJIPFD POCMDGMBLKN(string NMCGBFDKCMK, object OOHGFGHCOAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x41BE1E0", Offset = "0x41BCDE0", VA = "0x1841BE1E0")]
		public BHKLBFJIPFD EPAPIOHILHB<T>(string NMCGBFDKCMK, T? OOHGFGHCOAJ) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x72A8020", Offset = "0x72A6C20", VA = "0x1872A8020")]
		public BHKLBFJIPFD EPAPIOHILHB(string NMCGBFDKCMK, string OOHGFGHCOAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x72A80B0", Offset = "0x72A6CB0", VA = "0x1872A80B0")]
		public BHKLBFJIPFD JOFHOMOMEJN(string NMCGBFDKCMK, string OOHGFGHCOAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x72A7A90", Offset = "0x72A6690", VA = "0x1872A7A90")]
		public BHKLBFJIPFD AAFDHMHMGLJ(string MHLEEJBIPDM, string MEPFFFGIFGB, object PEDMEJIDLNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x72A7BD0", Offset = "0x72A67D0", VA = "0x1872A7BD0")]
		public BHKLBFJIPFD AAFDHMHMGLJ(string MHLEEJBIPDM, IDictionary<string, object> IDAGLLCCAJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x72A7CB0", Offset = "0x72A68B0", VA = "0x1872A7CB0")]
		private static IDictionary<string, object> ACOJKCNAFCB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x72A8150", Offset = "0x72A6D50", VA = "0x1872A8150")]
		public void OKJHPKALEKA(bool JMPFOEMKFOI, string NFODIMIHBFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x72A7D90", Offset = "0x72A6990", VA = "0x1872A7D90")]
		public Task CANFMKKAMHJ([Optional] CancellationToken DKKNFNCKCEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x29083D0", Offset = "0x2906FD0", VA = "0x1829083D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MKIPNPCNFOC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct PPLJPBIPKOC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public MKIPNPCNFOC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x72B12C0", Offset = "0x72AFEC0", VA = "0x1872B12C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x72B1730", Offset = "0x72B0330", VA = "0x1872B1730", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static Action<MKIPNPCNFOC> BHJIGJCFDND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly string GIFLBJADOFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<string, object> IAHPLBNFODO;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string OGINKEBADJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x72ADBF0", Offset = "0x72AC7F0", VA = "0x1872ADBF0")]
		private MKIPNPCNFOC(string GIFLBJADOFH, int LOOPKKAOJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x72ADA10", Offset = "0x72AC610", VA = "0x1872ADA10")]
		public static BHKLBFJIPFD GLOMJONEBBE(string GIFLBJADOFH, int LOOPKKAOJGG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x72AD8C0", Offset = "0x72AC4C0", VA = "0x1872AD8C0")]
		[AsyncStateMachine(typeof(PPLJPBIPKOC))]
		public Task CANFMKKAMHJ([Optional] CancellationToken DKKNFNCKCEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x72ADB80", Offset = "0x72AC780", VA = "0x1872ADB80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3839CF0", Offset = "0x38388F0", VA = "0x183839CF0")]
		internal void ECOJPKHGAPP<T>(string NMCGBFDKCMK, T OOHGFGHCOAJ) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x72ADB20", Offset = "0x72AC720", VA = "0x1872ADB20")]
		internal void MEDLMCJBJAF(string NMCGBFDKCMK, object OOHGFGHCOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x72AD9B0", Offset = "0x72AC5B0", VA = "0x1872AD9B0")]
		internal void ECOJPKHGAPP(string NMCGBFDKCMK, string OOHGFGHCOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x41C08A0", Offset = "0x41BF4A0", VA = "0x1841C08A0")]
		private void MOMDNGEFJEL<T>(string NMCGBFDKCMK, T OOHGFGHCOAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct NAFFHLNKEON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string MLOJBENBAPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly long? PAKBEKGHOMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly short? POMLLGPCEDO;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x72ADF30", Offset = "0x72ACB30", VA = "0x1872ADF30")]
		public NAFFHLNKEON(string JMBKCMCCHOA, [Optional] long? JKJNCHGDMGL, [Optional] short? DPOGGMPINCD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct PCFPFGIPLCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly int JCELGBHKINM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly string OMFGMPOKGHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly short FBMALPOFIOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly string IJLFMGOFJCG;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x72AF780", Offset = "0x72AE380", VA = "0x1872AF780")]
		public PCFPFGIPLCC(int DDDDLKEPDDI, string KFFCNJECBCA, short KILEGLLLLFO, string HKDACOMGGKP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HDCNCKBKIJC : BNENLENKBEA<LPOGFNMAJAJ, PCFPFGIPLCC, NAFFHLNKEON>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private string KFFCNJECBCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private short KILEGLLLLFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private string HKDACOMGGKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Dictionary<short, int> OMKAAMCFJJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int LDOCPAGHCFH;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x72AB8B0", Offset = "0x72AA4B0", VA = "0x1872AB8B0")]
		public HDCNCKBKIJC(string KCKLKNJPFEO, Guid NJLBKOHLMIM, long HFCFEBHICAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x72AB5C0", Offset = "0x72AA1C0", VA = "0x1872AB5C0", Slot = "4")]
		public override void KODBKECLFPN(PCFPFGIPLCC AGJOMOOHMGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x72AA450", Offset = "0x72A9050", VA = "0x1872AA450")]
		public void BEACOBKKLFJ(short KILEGLLLLFO, bool DBEJJEFKHPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4B74C00", Offset = "0x4B73800", VA = "0x184B74C00")]
		public void BFDKMEIFBFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6B0", Offset = "0xA1B2B0", VA = "0x180A1C6B0")]
		public void CKDGKKGHNKL(string CINJHKPDMGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x72AA7E0", Offset = "0x72A93E0", VA = "0x1872AA7E0", Slot = "5")]
		public override void KEPHBDKDHNJ(bool OMCKPHOPFCO, NAFFHLNKEON DCPGADJNLMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x72AA530", Offset = "0x72A9130", VA = "0x1872AA530", Slot = "6")]
		public override DOKJPFJMAFF EMAHOHHOKHI(LPOGFNMAJAJ HAMOPMKCEEG, int EMMACFPOKFB, string JALLLEOFPKG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class DMFHGDOEHNH : DOKJPFJMAFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private string KFFCNJECBCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly short KILEGLLLLFO;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x72A88C0", Offset = "0x72A74C0", VA = "0x1872A88C0")]
		public DMFHGDOEHNH(long DGLGMEAJHHO, int DDDDLKEPDDI, string LNLBGGBIELG, long HFCFEBHICAO, int GJAFEAJHLKN, string PBLHCAGNECO, short KILEGLLLLFO, string KFFCNJECBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x72A8840", Offset = "0x72A7440", VA = "0x1872A8840")]
		public void JAKAKHOHDPM(int DDDDLKEPDDI, string KFFCNJECBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x72A8710", Offset = "0x72A7310", VA = "0x1872A8710", Slot = "5")]
		public override BHKLBFJIPFD FHLJAGGDPBG(Guid JNOOHOGABAI, string ADLAENGIAGH, [Optional] string LNLBGGBIELG, [Optional] long? KBCGHBCMFPD, [Optional] string PBLHCAGNECO, [Optional] string NEMOCPGGCEJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class KPBNCKLCKMD
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class FCLJGBHIBKC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public float nextEventSendTime;

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public FCLJGBHIBKC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x72A9DB0", Offset = "0x72A89B0", VA = "0x1872A9DB0")]
			internal bool LAEPGMFFJPC()
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private struct PBGOPACJMKG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private FCLJGBHIBKC <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private TimeSpan <delayPollingInterval>5__2;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x72AEA60", Offset = "0x72AD660", VA = "0x1872AEA60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x72AF720", Offset = "0x72AE320", VA = "0x1872AF720", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct KBMAKNHLDCO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public bool isForcedEvent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x72AC010", Offset = "0x72AAC10", VA = "0x1872AC010", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x72AC590", Offset = "0x72AB190", VA = "0x1872AC590", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly float NBADKKIGGAD;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static FJCEKCIPLIL DDNEOJGAKLE;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static CancellationTokenSource LAIKAEKBBFK;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static bool DEELHOCNJMG;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static int MPKJAHNMDBL;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly BICCMPNJHAK<BHKLBFJIPFD, bool> KAMFCFFADBO;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static JAJMDJOHNPD<BHKLBFJIPFD, bool> CGAFFBLLNOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x72AD2C0", Offset = "0x72ABEC0", VA = "0x1872AD2C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static bool FFGJGHCLDFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x72ACEE0", Offset = "0x72ABAE0", VA = "0x1872ACEE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x72AC7A0", Offset = "0x72AB3A0", VA = "0x1872AC7A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private static bool BBOGIGBLPPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x72ACF30", Offset = "0x72ABB30", VA = "0x1872ACF30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x72AC800", Offset = "0x72AB400", VA = "0x1872AC800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private static float FGOFKICJEFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x72ACE90", Offset = "0x72ABA90", VA = "0x1872ACE90")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x72AD260", Offset = "0x72ABE60", VA = "0x1872AD260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x72AD5D0", Offset = "0x72AC1D0", VA = "0x1872AD5D0")]
		[JPDFIGCCABC.KAGELKALKJI]
		internal static void LHGJIFHLBHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x72AD3F0", Offset = "0x72ABFF0", VA = "0x1872AD3F0")]
		internal static void LEIJOMGLGOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x72AC5F0", Offset = "0x72AB1F0", VA = "0x1872AC5F0")]
		internal static void AJLHHIGEIBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x72ACC90", Offset = "0x72AB890", VA = "0x1872ACC90")]
		internal static void CLGPKBEKDCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x72AD6F0", Offset = "0x72AC2F0", VA = "0x1872AD6F0")]
		public static void OKDNGCGALBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x72AC860", Offset = "0x72AB460", VA = "0x1872AC860")]
		private static void BEHJEBMJBEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x72ACF80", Offset = "0x72ABB80", VA = "0x1872ACF80")]
		private static void HPCMFIDMHHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x72ACDC0", Offset = "0x72AB9C0", VA = "0x1872ACDC0")]
		[AsyncStateMachine(typeof(PBGOPACJMKG))]
		private static Task EONMIDALIAI(CancellationToken DKKNFNCKCEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x72ACCF0", Offset = "0x72AB8F0", VA = "0x1872ACCF0")]
		private static void DLEAAEELCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x72AD310", Offset = "0x72ABF10", VA = "0x1872AD310")]
		[AsyncStateMachine(typeof(KBMAKNHLDCO))]
		private static Task LAGCFFNJAHM(bool IJADFOMLOPI, [Optional] CancellationToken DKKNFNCKCEB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class NLHKJKHDIAA<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class PCODLOBGOGG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public NLHKJKHDIAA<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public PCODLOBGOGG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x57C0D00", Offset = "0x57BF900", VA = "0x1857C0D00")]
			internal object OMOIHNGEPOG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class NPIMKPIKFIK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public NLHKJKHDIAA<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public NPIMKPIKFIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x5556180", Offset = "0x5554D80", VA = "0x185556180")]
			internal object MCOJADOKFFP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class ABGNBKKINML
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public NLHKJKHDIAA<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public ABGNBKKINML()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x4CDFAE0", Offset = "0x4CDE6E0", VA = "0x184CDFAE0")]
			internal object MGNGOFJGAJC()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class DKKLGCHEGLN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public NLHKJKHDIAA<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public DKKLGCHEGLN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x42C3400", Offset = "0x42C2000", VA = "0x1842C3400")]
			internal object OPCCABGDILJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class EAMBLILLNEN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public NLHKJKHDIAA<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public EAMBLILLNEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x470AC00", Offset = "0x4709800", VA = "0x18470AC00")]
			internal object DPAFFBFIDNB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class DPKNLDBKGNH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public NLHKJKHDIAA<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public DPKNLDBKGNH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x42DCE20", Offset = "0x42DBA20", VA = "0x1842DCE20")]
			internal object NIEMAGFFBJM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class APCNJGHEEFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public NLHKJKHDIAA<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public APCNJGHEEFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x5071120", Offset = "0x506FD20", VA = "0x185071120")]
			internal object OBDFGGKIOPP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const float KHOFHBCBEMP = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Guid JNOOHOGABAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly Guid DJOGNFCFDPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly string PBLHCAGNECO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly string AAPEJOHBGOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private string FOCNMIFFPNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private string NEMOCPGGCEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private string HBGNGMMHGBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private string BGJALDJFLDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private string HMPNMOFJHGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private string CBKMLJBGONP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private string GFLMGIFKFBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private string BDAGCMHDAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private string NDPFMMIJBDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Guid? MLJOBBHHKDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private (int, int)? KPFJMOFBLCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly HashSet<T> MMFDALEPBEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly Dictionary<(T, int), string> JNBBKOKBJCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly Dictionary<(T, int), float> PICLJMEJKCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly Dictionary<T, string> ONPKGHJIDFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly Dictionary<T, string> IBKCNAHDBBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<T, string> GGLKNHOMNAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly Dictionary<T, string[]> NIHGFDAMCPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private string EPAMFLIGBCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private bool HFJJBJCKPJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private Task OMFGCACKGKA;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x55318B0", Offset = "0x55304B0", VA = "0x1855318B0")]
		public NLHKJKHDIAA(Guid JNOOHOGABAI, Guid DJOGNFCFDPF, string AAPEJOHBGOB, string PBLHCAGNECO, string FOCNMIFFPNO, [Optional] string NEMOCPGGCEJ, [Optional] string HBGNGMMHGBB, [Optional] string BGJALDJFLDC, [Optional] string GFLMGIFKFBK, [Optional] string EPAMFLIGBCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA24890", Offset = "0xA23490", VA = "0x180A24890")]
		public void JKPFOHEIABB(string NEMOCPGGCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA247C0", Offset = "0xA233C0", VA = "0x180A247C0")]
		public void HOEDGFAHLJF(string FOCNMIFFPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA85F40", Offset = "0xA84B40", VA = "0x180A85F40")]
		public void IDDAJPONHFG(string EPAMFLIGBCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA1C690", Offset = "0xA1B290", VA = "0x180A1C690")]
		public void BLPEHEDEMIJ(string HMPNMOFJHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA2BDA0", Offset = "0xA2A9A0", VA = "0x180A2BDA0")]
		public void EHFMHHNNKOP(string BDAGCMHDAHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA2BDB0", Offset = "0xA2A9B0", VA = "0x180A2BDB0")]
		public void AJCHODAJDGP(string NDPFMMIJBDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x552FA70", Offset = "0x552E670", VA = "0x18552FA70")]
		public void GAJLJNIAAEN(Guid? JNOOHOGABAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1820080", Offset = "0x181EC80", VA = "0x181820080")]
		public void POCJOCCOCAF((int, int)? KPFJMOFBLCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6B0", Offset = "0xA1B2B0", VA = "0x180A1C6B0")]
		public void LNHPBNCBGIF(string CBKMLJBGONP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5530570", Offset = "0x552F170", VA = "0x185530570")]
		public void GMNKKCLKDOA(T KBCGHBCMFPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x552B5A0", Offset = "0x552A1A0", VA = "0x18552B5A0")]
		public void AOKLHOHFDPL(T KBCGHBCMFPD, int KOCBHPFEMKF, float PMNGLFBCFIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x552EED0", Offset = "0x552DAD0", VA = "0x18552EED0")]
		public void FBADGHDLGPI(T KBCGHBCMFPD, int KOCBHPFEMKF, string CMEJMPLLGDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5530290", Offset = "0x552EE90", VA = "0x185530290")]
		public void GHNLGOCKLHL(T KBCGHBCMFPD, string CLLLPHMHJOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x552FFB0", Offset = "0x552EBB0", VA = "0x18552FFB0")]
		public void GGCDBCNHEDI(T KBCGHBCMFPD, string JLFKHHNJJJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x552F740", Offset = "0x552E340", VA = "0x18552F740")]
		public void FPNJLEFAEEA(T KBCGHBCMFPD, bool CACBCMPGBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x552ED60", Offset = "0x552D960", VA = "0x18552ED60")]
		public void EJPFCDDLNPB(T KBCGHBCMFPD, string[] LPAHKHHODLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x552CD00", Offset = "0x552B900", VA = "0x18552CD00")]
		public Task CANFMKKAMHJ(bool JMDCPKFBLOI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x552AD00", Offset = "0x5529900", VA = "0x18552AD00")]
		private (IEnumerable<T>, string) ACJPOCBACFF()
		{
			return default((IEnumerable<T>, string));
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5530980", Offset = "0x552F580", VA = "0x185530980")]
		public static BHKLBFJIPFD LJHOEOAPKOM(Guid JNOOHOGABAI, Guid DJOGNFCFDPF, string AAPEJOHBGOB, T KBCGHBCMFPD, string PBLHCAGNECO, string PPJFAEJGDAP, string NEMOCPGGCEJ, int? EMMACFPOKFB, [Optional] string IGNJBLNEBGA, [Optional] string CLLLPHMHJOK, [Optional] int? MIDKCGFLCCK, [Optional] Guid? MLJOBBHHKDL, [Optional] string EPAMFLIGBCE, [Optional] string LNLBGGBIELG, [Optional] (int, int)? KPFJMOFBLCD, [Optional] string BMNGPGFELNN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x552BDC0", Offset = "0x552A9C0", VA = "0x18552BDC0")]
		[CompilerGenerated]
		private string BNOPHEKBAHM(T ALPNKEJICNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5531730", Offset = "0x5530330", VA = "0x185531730")]
		[CompilerGenerated]
		private string PLJJPOEEHJL(T ALPNKEJICNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x552FB50", Offset = "0x552E750", VA = "0x18552FB50")]
		[CompilerGenerated]
		private string GDHHDFNOFHP(T ALPNKEJICNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x552BB40", Offset = "0x552A740", VA = "0x18552BB40")]
		[CompilerGenerated]
		private string BNJEFHEEKFI(T ALPNKEJICNA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public abstract class BNENLENKBEA<TItem, TListSessionStartParams, TListSessionLogParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		protected readonly string KCKLKNJPFEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		protected readonly Guid NJLBKOHLMIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		protected readonly long HFCFEBHICAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		protected int DDDDLKEPDDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		protected int EMCKECCGNFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		protected DateTime KEEOCOENJDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		protected bool CACOCILOENE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		protected Dictionary<long, DOKJPFJMAFF> PHPPMEPBIGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		protected bool LIGMCJCIGJG;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool LMKOJHJBBGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xCBAD70", Offset = "0xCB9970", VA = "0x180CBAD70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool CCJLLAKKLJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xD0ED10", Offset = "0xD0D910", VA = "0x180D0ED10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x661D8D0", Offset = "0x661C4D0", VA = "0x18661D8D0")]
		public BNENLENKBEA(string KCKLKNJPFEO, Guid NJLBKOHLMIM, long HFCFEBHICAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void KODBKECLFPN(TListSessionStartParams AGJOMOOHMGF);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x51D8B10", Offset = "0x51D7710", VA = "0x1851D8B10")]
		public void KLLFHPNFKOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void KEPHBDKDHNJ(bool OMCKPHOPFCO, TListSessionLogParams DCPGADJNLMC);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x661D5C0", Offset = "0x661C1C0", VA = "0x18661D5C0")]
		public void BPBOFJJIKFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x661D610", Offset = "0x661C210", VA = "0x18661D610")]
		public void CNHKAMBBNCG(long DGLGMEAJHHO, int EMMACFPOKFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x661D7B0", Offset = "0x661C3B0", VA = "0x18661D7B0")]
		public void PKOJIJBFHCG(long DGLGMEAJHHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract DOKJPFJMAFF EMAHOHHOKHI(TItem ONKLOOMCJOM, int EMMACFPOKFB, string JALLLEOFPKG);
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class DOKJPFJMAFF : GBHAEONELHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private int DDDDLKEPDDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private long DGLGMEAJHHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private long HFCFEBHICAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly string IGKLGOMMKOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly string ICPGEDIBBOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly int GJAFEAJHLKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private DateTime DEDNFFOFAAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private double CPKPFBNDBJC;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool DCHMIMPMMBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xEE9190", Offset = "0xEE7D90", VA = "0x180EE9190")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xEE9180", Offset = "0xEE7D80", VA = "0x180EE9180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x72A9090", Offset = "0x72A7C90", VA = "0x1872A9090")]
		public DOKJPFJMAFF(long DGLGMEAJHHO, int DDDDLKEPDDI, string LNLBGGBIELG, long HFCFEBHICAO, int GJAFEAJHLKN, [Optional] string PBLHCAGNECO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x72A89B0", Offset = "0x72A75B0", VA = "0x1872A89B0")]
		public void AEKLBICLEHC(int DDDDLKEPDDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x72A8A80", Offset = "0x72A7680", VA = "0x1872A8A80")]
		public void BHHNINKJIFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x72A8AD0", Offset = "0x72A76D0", VA = "0x1872A8AD0")]
		public void CEDKFDJDMBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x72A8A20", Offset = "0x72A7620", VA = "0x1872A8A20")]
		private void ANMEHJPDIHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x72A8BE0", Offset = "0x72A77E0", VA = "0x1872A8BE0", Slot = "5")]
		public virtual BHKLBFJIPFD FHLJAGGDPBG(Guid JNOOHOGABAI, string ADLAENGIAGH, [Optional] string LNLBGGBIELG, [Optional] long? KBCGHBCMFPD, [Optional] string PBLHCAGNECO, [Optional] string NEMOCPGGCEJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class PIBIGJEINNG
	{
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static Dictionary<string, Dictionary<string, object>> GACECLBDCBL;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static string CONKNHPMFND;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static int BDIPIOFIFKK;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly Dictionary<string, JIFOMANIMGF> EMMHBHIJOMK;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static string IGMGPBIEFFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x72AFB30", Offset = "0x72AE730", VA = "0x1872AFB30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x72B02D0", Offset = "0x72AEED0", VA = "0x1872B02D0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool PPNOEONNDMD
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x72AF7D0", Offset = "0x72AE3D0", VA = "0x1872AF7D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static Dictionary<string, Dictionary<string, object>> JIGMFEIFKCI
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x72AFB80", Offset = "0x72AE780", VA = "0x1872AFB80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static Guid? FENIHKCMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x72AFF60", Offset = "0x72AEB60", VA = "0x1872AFF60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x72AFFC0", Offset = "0x72AEBC0", VA = "0x1872AFFC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static Guid? PGNKFMNLIIF
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x72B0B30", Offset = "0x72AF730", VA = "0x1872B0B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x72B0AD0", Offset = "0x72AF6D0", VA = "0x1872B0AD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x72AFBD0", Offset = "0x72AE7D0", VA = "0x1872AFBD0")]
		public static void BIFOLJDAEPC(string NCLBIFDFNHI, JIFOMANIMGF BGJPLNOBNOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x72B09F0", Offset = "0x72AF5F0", VA = "0x1872B09F0")]
		internal static void LEIJOMGLGOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x72AF860", Offset = "0x72AE460", VA = "0x1872AF860")]
		internal static void AJLHHIGEIBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x72AFDD0", Offset = "0x72AE9D0", VA = "0x1872AFDD0")]
		internal static void CLGPKBEKDCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x72B0420", Offset = "0x72AF020", VA = "0x1872B0420")]
		public static Guid KODBKECLFPN(string NCLBIFDFNHI, [Optional] string? EADMMIIBIFJ, [Optional] Dictionary<string, object>? BFNEGDJCGJH)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x72B0380", Offset = "0x72AEF80", VA = "0x1872B0380")]
		public static Guid KODBKECLFPN(string NCLBIFDFNHI, long EADMMIIBIFJ, [Optional] Dictionary<string, object>? BFNEGDJCGJH)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x72B0070", Offset = "0x72AEC70", VA = "0x1872B0070")]
		public static void KLLFHPNFKOM(string NCLBIFDFNHI, [Optional] Guid? LHECJJHBNHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x72B0B90", Offset = "0x72AF790", VA = "0x1872B0B90")]
		public static void NFPGJKJBECE(string NCLBIFDFNHI, string MHLEEJBIPDM, object FNIBKBIHAPF, bool DEELHOCNJMG = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x72AF940", Offset = "0x72AE540", VA = "0x1872AF940")]
		public static bool AOGBEPIFFML(string NCLBIFDFNHI, [Optional] string? EADMMIIBIFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x72AFC60", Offset = "0x72AE860", VA = "0x1872AFC60")]
		private static void CDMCMGMCBCL(bool OKNNGJEMOID = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x72B0020", Offset = "0x72AEC20", VA = "0x1872B0020")]
		public static void KKPBEOCDHHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x72AFE50", Offset = "0x72AEA50", VA = "0x1872AFE50")]
		private static void HPCMFIDMHHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x72B0D90", Offset = "0x72AF990", VA = "0x1872B0D90")]
		private static void NHDFHKIKKPM(string NCLBIFDFNHI, Guid JNOOHOGABAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class JCIIIBDELBL
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public struct DIDFOOGCFDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public bool MBDJGJKJICC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public string DBMKCGLJJHI;

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xCBBDC0", Offset = "0xCBA9C0", VA = "0x180CBBDC0")]
			public DIDFOOGCFDP(bool MBDJGJKJICC, string DBMKCGLJJHI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x72ABB40", Offset = "0x72AA740", VA = "0x1872ABB40")]
		public static DIDFOOGCFDP HOEGMFFOKBK(BHKLBFJIPFD OCBBJACBAIO)
		{
			return default(DIDFOOGCFDP);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x72ABE50", Offset = "0x72AAA50", VA = "0x1872ABE50")]
		private static void LCKFOOMCGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x72ABF50", Offset = "0x72AAB50", VA = "0x1872ABF50")]
		private static void MFJMFCBALHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class GJHHKDIHHAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x72AA3F0", Offset = "0x72A8FF0", VA = "0x1872AA3F0")]
		public static BHKLBFJIPFD AIHHNFLEDPN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class GJHAEHADDGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x72AA1B0", Offset = "0x72A8DB0", VA = "0x1872AA1B0")]
		public static BHKLBFJIPFD LOODPPEJAEO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x72AA270", Offset = "0x72A8E70", VA = "0x1872AA270")]
		public static BHKLBFJIPFD NKCPGFEHANP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x72AA390", Offset = "0x72A8F90", VA = "0x1872AA390")]
		public static BHKLBFJIPFD OHOAMJKKIKA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x72AA330", Offset = "0x72A8F30", VA = "0x1872AA330")]
		public static BHKLBFJIPFD NPBDAMGDGEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x72A9FD0", Offset = "0x72A8BD0", VA = "0x1872A9FD0")]
		public static BHKLBFJIPFD GMDOJMCNFAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x72A9E50", Offset = "0x72A8A50", VA = "0x1872A9E50")]
		public static BHKLBFJIPFD BHIKHGNHHBB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x72A9EB0", Offset = "0x72A8AB0", VA = "0x1872A9EB0")]
		public static BHKLBFJIPFD DJEMNGGHIBC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x72AA0F0", Offset = "0x72A8CF0", VA = "0x1872AA0F0")]
		public static BHKLBFJIPFD KNCKNIFEBOK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x72AA090", Offset = "0x72A8C90", VA = "0x1872AA090")]
		public static BHKLBFJIPFD KHJBMBGEECP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x72A9F10", Offset = "0x72A8B10", VA = "0x1872A9F10")]
		public static BHKLBFJIPFD EEAMGLJBHIL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x72AA030", Offset = "0x72A8C30", VA = "0x1872AA030")]
		public static BHKLBFJIPFD HBEAOHNMPPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x72AA150", Offset = "0x72A8D50", VA = "0x1872AA150")]
		public static BHKLBFJIPFD LCIBPPCNGBO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x72AA2D0", Offset = "0x72A8ED0", VA = "0x1872AA2D0")]
		public static BHKLBFJIPFD NLDFKHCOFAO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x72AA210", Offset = "0x72A8E10", VA = "0x1872AA210")]
		public static BHKLBFJIPFD NDAGEGEGMCM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x72A9F70", Offset = "0x72A8B70", VA = "0x1872A9F70")]
		public static BHKLBFJIPFD FEFDECCGGNB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class CPJDKCOMDLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x72A8530", Offset = "0x72A7130", VA = "0x1872A8530")]
		public static BHKLBFJIPFD IGDALCIGFOA(long JKJNCHGDMGL, long KBGIBOKAOOO, bool DHFDLMFONCP, string NBCBAMLCLDH, string JIGGDIKIGHN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class EANGDINABIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x72A9410", Offset = "0x72A8010", VA = "0x1872A9410")]
		public static BHKLBFJIPFD BAIPAJFPLLM(string BHANLJMEECN, string OGPPGODCKHD, bool PFCMNMHDGFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x72A9160", Offset = "0x72A7D60", VA = "0x1872A9160")]
		public static BHKLBFJIPFD AANNNODLEFL(Guid DJOGNFCFDPF, string CBLPKFIJGLH, string JFPMMBJKLMI, string NLONLIKNJIG, [Optional] int? DBBGCOMFNDA, [Optional] double[] LHGCMNLKCAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x72A9580", Offset = "0x72A8180", VA = "0x1872A9580")]
		public static BHKLBFJIPFD EAPPIDEOIFE(Guid DJOGNFCFDPF, Guid APJPHGAHPBJ, bool GBKLKDCGFMP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class EOPMIDNOCAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x72A96B0", Offset = "0x72A82B0", VA = "0x1872A96B0")]
		public static BHKLBFJIPFD AIMDJHNELGB(string KMEGJAELIPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x72A9CD0", Offset = "0x72A88D0", VA = "0x1872A9CD0")]
		public static BHKLBFJIPFD PPPKFOLPMGB(string FNFMBBJKFHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x72A9B20", Offset = "0x72A8720", VA = "0x1872A9B20")]
		public static BHKLBFJIPFD MNADFAOJJAH(int LOOPKKAOJGG, string LAOCJKNALFF, string ALPNKEJICNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x72A9A00", Offset = "0x72A8600", VA = "0x1872A9A00")]
		public static BHKLBFJIPFD EFHHKCJLHIN(int LOOPKKAOJGG, string LAOCJKNALFF, string ALPNKEJICNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x72A9AC0", Offset = "0x72A86C0", VA = "0x1872A9AC0")]
		public static BHKLBFJIPFD MEGEJKDLJHI(int LOOPKKAOJGG, string LAOCJKNALFF, string ALPNKEJICNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x72A9A60", Offset = "0x72A8660", VA = "0x1872A9A60")]
		public static BHKLBFJIPFD IDNMAHEEHHJ(int LOOPKKAOJGG, string LAOCJKNALFF, string ALPNKEJICNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x72A9B80", Offset = "0x72A8780", VA = "0x1872A9B80")]
		public static BHKLBFJIPFD PIPEBPLFBJO(string LAOCJKNALFF, string ALPNKEJICNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x72A98C0", Offset = "0x72A84C0", VA = "0x1872A98C0")]
		private static BHKLBFJIPFD BFHFICLFOOC(string KCKLKNJPFEO, int LOOPKKAOJGG, string JMFNHKHHGKJ, string CNFMBKLLKAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x72A9790", Offset = "0x72A8390", VA = "0x1872A9790")]
		private static BHKLBFJIPFD BFHFICLFOOC(string KCKLKNJPFEO, string JMFNHKHHGKJ, string CNFMBKLLKAF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly JPIBGNDAFKP HOEGMFFOKBK;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static MFHMPBFKGLM ADPMIMAAEHC;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static KAFBJENNCBI DKJHFIBPJHK;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static Queue<BHKLBFJIPFD> BBDNJKPLAIJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static long BAJKNJGELLP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x72AE2C0", Offset = "0x72ACEC0", VA = "0x1872AE2C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x72AE0B0", Offset = "0x72ACCB0", VA = "0x1872AE0B0")]
	[JPDFIGCCABC.KAGELKALKJI]
	internal static void HKPKJIOEEJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x72ADFF0", Offset = "0x72ACBF0", VA = "0x1872ADFF0")]
	private static void HHDKLMPLBON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x72ADF70", Offset = "0x72ACB70", VA = "0x1872ADF70")]
	public static BHKLBFJIPFD CCABHJGLEPM(string GIFLBJADOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x72ADA10", Offset = "0x72AC610", VA = "0x1872ADA10")]
	public static BHKLBFJIPFD CCABHJGLEPM(string GIFLBJADOFH, int LOOPKKAOJGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x72AE3B0", Offset = "0x72ACFB0", VA = "0x1872AE3B0")]
	public static bool ILPPLPMFLCO(this FJCEKCIPLIL KFDHNPIBLBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x72AE1A0", Offset = "0x72ACDA0", VA = "0x1872AE1A0")]
	[JPDFIGCCABC.KAGELKALKJI]
	internal static void ILDJMKAKKJK()
	{
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
