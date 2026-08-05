using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Core;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using RecRoom.NoEngine.DataStructures.Tokens;
using RecRoom.UnityContainers;
using RecRoom.Utils.PrefParsers;
using UJect;
using UJect.Injection;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x897E2F0", Offset = "0x897D0F0", VA = "0x18897E2F0")]
		public NullableAttribute(byte P_0)
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

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAE8B60", Offset = "0xAE7960", VA = "0x180AE8B60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Preferences_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x89849B0", Offset = "0x89837B0", VA = "0x1889849B0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2963E60", Offset = "0x2962C60", VA = "0x182963E60")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Preferences
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum AccountPreferenceBackingStoreTypes : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		CLOUD,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		DISK
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal static class HUDXAKZUUJV
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		internal delegate void CustomSaveHandler(OCZFRIEQPIZ backingStore);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x897C670", Offset = "0x897B470", VA = "0x18897C670")]
		private static void SKNKGOBOTYQ(OCZFRIEQPIZ a, CustomSaveHandler b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x897BE80", Offset = "0x897AC80", VA = "0x18897BE80")]
		public static bool IFJBTQRAIPE(this OCZFRIEQPIZ a, string b, [Optional] CustomSaveHandler c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x897C150", Offset = "0x897AF50", VA = "0x18897C150")]
		public static SetResult JTHWHNJUBEF(this OCZFRIEQPIZ a, string b, string c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x897C530", Offset = "0x897B330", VA = "0x18897C530")]
		public static SetResult QGGSIRTAKEL(this OCZFRIEQPIZ a, string b, int c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x897BD30", Offset = "0x897AB30", VA = "0x18897BD30")]
		public static SetResult FLDOOCRKZKQ(this OCZFRIEQPIZ a, string b, bool c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x897C2A0", Offset = "0x897B0A0", VA = "0x18897C2A0")]
		public static SetResult OEOITIACHIU(this OCZFRIEQPIZ a, string b, float c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x897BFE0", Offset = "0x897ADE0", VA = "0x18897BFE0")]
		public static SetResult JHIOFGPSQWN(this OCZFRIEQPIZ a, string b, DateTime c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x897C3F0", Offset = "0x897B1F0", VA = "0x18897C3F0")]
		public static SetResult PBXKRLHTCJA(this OCZFRIEQPIZ a, string b, long c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class LMLARBPAXQG : BMVPPZKNKBA, OCZFRIEQPIZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly UKIYUDFJSRR VGUKFFIKZDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly Dictionary<string, byte> KNTIQDKOMYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private Dictionary<string, string> GIDPEXYUWSL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool EBUTVQAGWPR
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Dictionary<string, string> HNYFKUMEPNV
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x897E210", Offset = "0x897D010", VA = "0x18897E210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action WQHMEUJSXTL
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x897E250", Offset = "0x897D050", VA = "0x18897E250")]
		[UnityEngine.Scripting.Preserve]
		public LMLARBPAXQG([Inject(null)] UKIYUDFJSRR unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "8")]
		public void QPVANJJYXHX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x897DAC0", Offset = "0x897C8C0", VA = "0x18897DAC0")]
		private DirectoryInfo QBYCIJGWWCZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x897DBB0", Offset = "0x897C9B0", VA = "0x18897DBB0", Slot = "6")]
		public Task RRSOCBYBOXH(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x897D380", Offset = "0x897C180", VA = "0x18897D380", Slot = "14")]
		public float GWGHEQORKHT(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x897D310", Offset = "0x897C110", VA = "0x18897D310", Slot = "13")]
		public void GRWXSQZHWQV(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x897DC40", Offset = "0x897CA40", VA = "0x18897DC40", Slot = "12")]
		public bool RXGZVDFHRJL(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x897C7E0", Offset = "0x897B5E0", VA = "0x18897C7E0", Slot = "10")]
		public int BUCKMWIGAPM(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x897C770", Offset = "0x897B570", VA = "0x18897C770", Slot = "18")]
		public DateTime ANDFUWMSZPC(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x897DA50", Offset = "0x897C850", VA = "0x18897DA50", Slot = "19")]
		public void MWFOEPCIQPS(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x897E130", Offset = "0x897CF30", VA = "0x18897E130", Slot = "15")]
		public void VHXJVMUYWGJ(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x897E1A0", Offset = "0x897CFA0", VA = "0x18897E1A0", Slot = "11")]
		public void YEGXISCWFLU(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x897DD00", Offset = "0x897CB00", VA = "0x18897DD00", Slot = "20")]
		public long SGSNBPGNPZB(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x897D0A0", Offset = "0x897BEA0", VA = "0x18897D0A0", Slot = "21")]
		public void EPAAMVXIKTF(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3905360", Offset = "0x3904160", VA = "0x183905360", Slot = "22")]
		public a HNFQJMASMJQ<a>(string a, a b, ZXDWIEXBMRB<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x39055E0", Offset = "0x39043E0", VA = "0x1839055E0", Slot = "23")]
		public void LYDJWZSEDRA<b>(string a, b b, ZXDWIEXBMRB<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x897CFF0", Offset = "0x897BDF0", VA = "0x18897CFF0", Slot = "16")]
		public string CMBNBSIGIWQ(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x897D890", Offset = "0x897C690", VA = "0x18897D890", Slot = "17")]
		public void LWGINYILBYU(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x897D900", Offset = "0x897C700", VA = "0x18897D900", Slot = "24")]
		public void MFAUYWASCED(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x897DD70", Offset = "0x897CB70", VA = "0x18897DD70", Slot = "9")]
		public bool SQAWFACIATO(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x897DE00", Offset = "0x897CC00", VA = "0x18897DE00", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x897D4F0", Offset = "0x897C2F0", VA = "0x18897D4F0")]
		private void KAKNAYNSQHZ(DirectoryInfo a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x897D110", Offset = "0x897BF10", VA = "0x18897D110")]
		private static string FTQOEMMBUPQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x897D3F0", Offset = "0x897C1F0", VA = "0x18897D3F0")]
		private static string IXISKTQHUTZ(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x39EEC90", Offset = "0x39EDA90", VA = "0x1839EEC90")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] ZXDWIEXBMRB<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x39F04B0", Offset = "0x39EF2B0", VA = "0x1839F04B0")]
		private void Set<T>(string propertyName, T value, [Optional] ZXDWIEXBMRB<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x897C850", Offset = "0x897B650", VA = "0x18897C850")]
		private Dictionary<string, string> CAOZPPHZMBJ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal static class GXUIHUHNVWA
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x897BBD0", Offset = "0x897A9D0", VA = "0x18897BBD0")]
		[FDNTPBIGLET.Root]
		internal static void FDNTPBIGLET(FDTRVDFSBYT a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class JYBCWFERIYZ : QUAYYDFACRW
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x897C6F0", Offset = "0x897B4F0", VA = "0x18897C6F0")]
		[UnityEngine.Scripting.Preserve]
		public JYBCWFERIYZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class QUAYYDFACRW : BMVPPZKNKBA, OCZFRIEQPIZ, REUXGLSVIGY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly Dictionary<string, object> VUHOIYLOFME;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool EBUTVQAGWPR
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action WQHMEUJSXTL
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "8")]
		public void QPVANJJYXHX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8981910", Offset = "0x8980710", VA = "0x188981910", Slot = "6")]
		public Task RRSOCBYBOXH(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8981A60", Offset = "0x8980860", VA = "0x188981A60", Slot = "9")]
		public bool SQAWFACIATO(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8981610", Offset = "0x8980410", VA = "0x188981610", Slot = "10")]
		public int BUCKMWIGAPM(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8981BB0", Offset = "0x89809B0", VA = "0x188981BB0", Slot = "11")]
		public void YEGXISCWFLU(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x89819A0", Offset = "0x89807A0", VA = "0x1889819A0", Slot = "12")]
		public bool RXGZVDFHRJL(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8981730", Offset = "0x8980530", VA = "0x188981730", Slot = "13")]
		public void GRWXSQZHWQV(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8981790", Offset = "0x8980590", VA = "0x188981790", Slot = "14")]
		public float GWGHEQORKHT(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8981B50", Offset = "0x8980950", VA = "0x188981B50", Slot = "15")]
		public void VHXJVMUYWGJ(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8981670", Offset = "0x8980470", VA = "0x188981670", Slot = "16")]
		public string CMBNBSIGIWQ(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x89817F0", Offset = "0x89805F0", VA = "0x1889817F0", Slot = "17")]
		public void LWGINYILBYU(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x89815B0", Offset = "0x89803B0", VA = "0x1889815B0", Slot = "18")]
		public DateTime ANDFUWMSZPC(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x89818B0", Offset = "0x89806B0", VA = "0x1889818B0", Slot = "19")]
		public void MWFOEPCIQPS(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8981A00", Offset = "0x8980800", VA = "0x188981A00", Slot = "20")]
		public long SGSNBPGNPZB(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x89816D0", Offset = "0x89804D0", VA = "0x1889816D0", Slot = "21")]
		public void EPAAMVXIKTF(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3C25BE0", Offset = "0x3C249E0", VA = "0x183C25BE0", Slot = "22")]
		public a HNFQJMASMJQ<a>(string a, a b, ZXDWIEXBMRB<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3C25F90", Offset = "0x3C24D90", VA = "0x183C25F90", Slot = "23")]
		public void LYDJWZSEDRA<b>(string a, b b, ZXDWIEXBMRB<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3C25150", Offset = "0x3C23F50", VA = "0x183C25150")]
		public T Get<T>(string propertyName, T defaultValue)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3C261F0", Offset = "0x3C24FF0", VA = "0x183C261F0")]
		public void Set<T>(string propertyName, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8981850", Offset = "0x8980650", VA = "0x188981850", Slot = "24")]
		public void MFAUYWASCED(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8981AC0", Offset = "0x89808C0", VA = "0x188981AC0", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x897C6F0", Offset = "0x897B4F0", VA = "0x18897C6F0")]
		public QUAYYDFACRW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class UTQTVKKCAPZ<a> where a : OCZFRIEQPIZ
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly HashSet<UTQTVKKCAPZ<a>> XZSIDSPFBLO;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6426690", Offset = "0x6425490", VA = "0x186426690")]
		protected UTQTVKKCAPZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void Clear();

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void MVVEJFGYOLJ(string a);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6425A40", Offset = "0x6424840", VA = "0x186425A40")]
		public static void JECTXSNMHBR(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x64261D0", Offset = "0x6424FD0", VA = "0x1864261D0")]
		public static void MTJMLYNMQOP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class UTWASRDZKBI<a, b> : UTQTVKKCAPZ<a> where a : OCZFRIEQPIZ
	{
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly UTWASRDZKBI<a, b> GUTFKAZYITC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<string, b> INIXCFABYHF;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6426820", Offset = "0x6425620", VA = "0x186426820")]
		public bool DBGOVWLVGUF(string a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6426BF0", Offset = "0x64259F0", VA = "0x186426BF0")]
		public void Store(string cacheKey, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6426730", Offset = "0x6425530", VA = "0x186426730", Slot = "4")]
		protected override void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6426970", Offset = "0x6425770", VA = "0x186426970", Slot = "5")]
		protected override void MVVEJFGYOLJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6426E70", Offset = "0x6425C70", VA = "0x186426E70")]
		public UTWASRDZKBI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface OCZFRIEQPIZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool EBUTVQAGWPR
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void QPVANJJYXHX();

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool SQAWFACIATO(string a);

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int BUCKMWIGAPM(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void YEGXISCWFLU(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool RXGZVDFHRJL(string a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void GRWXSQZHWQV(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float GWGHEQORKHT(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void VHXJVMUYWGJ(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		string CMBNBSIGIWQ(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void LWGINYILBYU(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "11")]
		DateTime ANDFUWMSZPC(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void MWFOEPCIQPS(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "13")]
		long SGSNBPGNPZB(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void EPAAMVXIKTF(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "15")]
		a HNFQJMASMJQ<a>(string a, a b, ZXDWIEXBMRB<a> c);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void LYDJWZSEDRA<b>(string a, b b, ZXDWIEXBMRB<b> c);

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void MFAUYWASCED(string a);

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Task Save([Optional] CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface BMVPPZKNKBA : OCZFRIEQPIZ
	{
		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action WQHMEUJSXTL;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task RRSOCBYBOXH(long a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface REUXGLSVIGY : OCZFRIEQPIZ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class RWXYWODLPXY : BMVPPZKNKBA, OCZFRIEQPIZ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct <Save>d__38 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public RWXYWODLPXY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x8983BE0", Offset = "0x89829E0", VA = "0x188983BE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8983FB0", Offset = "0x8982DB0", VA = "0x188983FB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class PBEPOVJPYAZ : IEnumerator<IMKAVQMVTAL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private IMKAVQMVTAL QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public RWXYWODLPXY WFAEFPOXIOJ;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private IMKAVQMVTAL TBVNXHVEJNY
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public PBEPOVJPYAZ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x897E3B0", Offset = "0x897D1B0", VA = "0x18897E3B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x897E370", Offset = "0x897D170", VA = "0x18897E370", Slot = "8")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly UKIYUDFJSRR VGUKFFIKZDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool KWYHQJEYJNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private bool ALSOSQDOYZK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TQPUKRRDZNZ LDPTRROTLSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private DLHIAPQRHVO GYJAUOCYCXM;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool EBUTVQAGWPR
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action WQHMEUJSXTL
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8982410", Offset = "0x8981210", VA = "0x188982410")]
		[UnityEngine.Scripting.Preserve]
		public RWXYWODLPXY([Inject(null)] UKIYUDFJSRR unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "8")]
		public void QPVANJJYXHX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x89820D0", Offset = "0x8980ED0", VA = "0x1889820D0", Slot = "6")]
		public Task RRSOCBYBOXH(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1E36670", Offset = "0x1E35470", VA = "0x181E36670")]
		private static int KVQTALQPTLZ(bool a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8982200", Offset = "0x8981000", VA = "0x188982200", Slot = "9")]
		public bool SQAWFACIATO(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8981CF0", Offset = "0x8980AF0", VA = "0x188981CF0", Slot = "10")]
		public int BUCKMWIGAPM(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x89823E0", Offset = "0x89811E0", VA = "0x1889823E0", Slot = "11")]
		public void YEGXISCWFLU(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8982160", Offset = "0x8980F60", VA = "0x188982160", Slot = "12")]
		public bool RXGZVDFHRJL(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8981E50", Offset = "0x8980C50", VA = "0x188981E50", Slot = "13")]
		public void GRWXSQZHWQV(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8981E80", Offset = "0x8980C80", VA = "0x188981E80", Slot = "14")]
		public float GWGHEQORKHT(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8982310", Offset = "0x8981110", VA = "0x188982310", Slot = "15")]
		public void VHXJVMUYWGJ(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8981C10", Offset = "0x8980A10", VA = "0x188981C10", Slot = "18")]
		public DateTime ANDFUWMSZPC(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8981F70", Offset = "0x8980D70", VA = "0x188981F70", Slot = "19")]
		public void MWFOEPCIQPS(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8982190", Offset = "0x8980F90", VA = "0x188982190", Slot = "20")]
		public long SGSNBPGNPZB(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8981DE0", Offset = "0x8980BE0", VA = "0x188981DE0", Slot = "21")]
		public void EPAAMVXIKTF(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3CBCF30", Offset = "0x3CBBD30", VA = "0x183CBCF30", Slot = "22")]
		public a HNFQJMASMJQ<a>(string a, a b, ZXDWIEXBMRB<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3CBD1F0", Offset = "0x3CBBFF0", VA = "0x183CBD1F0", Slot = "23")]
		public void LYDJWZSEDRA<b>(string a, b b, ZXDWIEXBMRB<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3CBD430", Offset = "0x3CBC230", VA = "0x183CBD430")]
		private c VNNTQJPSRWP<c>(string a, c b, [Optional] ZXDWIEXBMRB<c> c)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3CBE2B0", Offset = "0x3CBD0B0", VA = "0x183CBE2B0")]
		private void WFTUULELOHF<d>(string a, d b, [Optional] ZXDWIEXBMRB<d> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8981D20", Offset = "0x8980B20", VA = "0x188981D20", Slot = "16")]
		public string CMBNBSIGIWQ(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8981EB0", Offset = "0x8980CB0", VA = "0x188981EB0", Slot = "17")]
		public void LWGINYILBYU(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8981FE0", Offset = "0x8980DE0", VA = "0x188981FE0")]
		private void MWSGQEVHTEF(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8981D50", Offset = "0x8980B50", VA = "0x188981D50")]
		private string DFVBWWECHFX(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8981EE0", Offset = "0x8980CE0", VA = "0x188981EE0", Slot = "24")]
		public void MFAUYWASCED(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8982340", Offset = "0x8981140", VA = "0x188982340")]
		private string YAFOLWZGAQL(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8982220", Offset = "0x8981020", VA = "0x188982220", Slot = "25")]
		[AsyncStateMachine(typeof(<Save>d__38))]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8981D70", Offset = "0x8980B70", VA = "0x188981D70")]
		[IteratorStateMachine(typeof(PBEPOVJPYAZ))]
		private IEnumerator<IMKAVQMVTAL> DQEWYOIVPHB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8982000", Offset = "0x8980E00", VA = "0x188982000")]
		private void MXHJCYJEPMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8981C80", Offset = "0x8980A80", VA = "0x188981C80")]
		private void AQDIANYBZAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8982060", Offset = "0x8980E60", VA = "0x188982060")]
		private void RFEFUZNRHBO(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class SXXNNQESMUE : BMVPPZKNKBA, OCZFRIEQPIZ
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private struct KVP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public string k;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public string v;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private struct KVPs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public KVP[] kvps;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Dictionary<string, string> GIDPEXYUWSL;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool EBUTVQAGWPR
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private string ORFYTREAQJW
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8982C00", Offset = "0x8981A00", VA = "0x188982C00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private string HNAFDGDSAEO
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x8982C90", Offset = "0x8981A90", VA = "0x188982C90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Dictionary<string, string> HNYFKUMEPNV
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8983320", Offset = "0x8982120", VA = "0x188983320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action WQHMEUJSXTL
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		[UnityEngine.Scripting.Preserve]
		public SXXNNQESMUE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "8")]
		public void QPVANJJYXHX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8982D90", Offset = "0x8981B90", VA = "0x188982D90", Slot = "6")]
		public Task RRSOCBYBOXH(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8982A30", Offset = "0x8981830", VA = "0x188982A30", Slot = "14")]
		public float GWGHEQORKHT(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x89829C0", Offset = "0x89817C0", VA = "0x1889829C0", Slot = "13")]
		public void GRWXSQZHWQV(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8982E20", Offset = "0x8981C20", VA = "0x188982E20", Slot = "12")]
		public bool RXGZVDFHRJL(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8982580", Offset = "0x8981380", VA = "0x188982580", Slot = "10")]
		public int BUCKMWIGAPM(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8982510", Offset = "0x8981310", VA = "0x188982510", Slot = "18")]
		public DateTime ANDFUWMSZPC(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8982D20", Offset = "0x8981B20", VA = "0x188982D20", Slot = "19")]
		public void MWFOEPCIQPS(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8983240", Offset = "0x8982040", VA = "0x188983240", Slot = "15")]
		public void VHXJVMUYWGJ(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x89832B0", Offset = "0x89820B0", VA = "0x1889832B0", Slot = "11")]
		public void YEGXISCWFLU(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8982EE0", Offset = "0x8981CE0", VA = "0x188982EE0", Slot = "20")]
		public long SGSNBPGNPZB(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8982950", Offset = "0x8981750", VA = "0x188982950", Slot = "21")]
		public void EPAAMVXIKTF(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3905360", Offset = "0x3904160", VA = "0x183905360", Slot = "22")]
		public a HNFQJMASMJQ<a>(string a, a b, ZXDWIEXBMRB<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x39055E0", Offset = "0x39043E0", VA = "0x1839055E0", Slot = "23")]
		public void LYDJWZSEDRA<b>(string a, b b, ZXDWIEXBMRB<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x89828A0", Offset = "0x89816A0", VA = "0x1889828A0", Slot = "16")]
		public string CMBNBSIGIWQ(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8982AA0", Offset = "0x89818A0", VA = "0x188982AA0", Slot = "17")]
		public void LWGINYILBYU(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8982B40", Offset = "0x8981940", VA = "0x188982B40", Slot = "24")]
		public void MFAUYWASCED(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8982F50", Offset = "0x8981D50", VA = "0x188982F50", Slot = "9")]
		public bool SQAWFACIATO(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8982FE0", Offset = "0x8981DE0", VA = "0x188982FE0", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3CF09E0", Offset = "0x3CEF7E0", VA = "0x183CF09E0")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] ZXDWIEXBMRB<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x3CF2200", Offset = "0x3CF1000", VA = "0x183CF2200")]
		private void Set<T>(string propertyName, T value, [Optional] ZXDWIEXBMRB<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x89825F0", Offset = "0x89813F0", VA = "0x1889825F0")]
		private Dictionary<string, string> CAOZPPHZMBJ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface AWJSQTHCCJW
	{
		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event Action WQHMEUJSXTL;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void QPVANJJYXHX();

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task DZMSSOKNBVJ(long a);

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool HRAVTKSFQUP(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool BNICWPRUFZN(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool ECKVGTYBJTY(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		string WOLPNYLCEHD(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		SetResult AECELXLGVJX(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "9")]
		int KVYSDEULACF(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "10")]
		SetResult DTQXPFGHDYZ(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool GVGUGXHWASM(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "12")]
		SetResult YRCHILPLUWY(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "13")]
		float OMYYACOBAJI(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "14")]
		SetResult ADSFBWFJJFI(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "15")]
		DateTime CGPXTKPFCZL(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "16")]
		SetResult XCWZGTUDVGB(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "17")]
		long ZTYLVFXPHRA(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "18")]
		SetResult KKNFYHROTUO(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "19")]
		a XAOWTKZOOUD<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "20")]
		SetResult USWFIIYSDMD<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool DNILBIMUTTB(string a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool MNDCUZPKDXS(string a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "23")]
		string IFNIQCBOHXX(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "24")]
		SetResult EGVJVGMBDUJ(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "25")]
		int HSLOWOPTJDX(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "26")]
		SetResult ADEPMRYHSSJ(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "27")]
		bool AAAHTKACOMA(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "28")]
		SetResult GTTTFWMSFEQ(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "29")]
		float LCEFVPMVXVU(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "30")]
		SetResult CKWWZFBAHVI(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "31")]
		DateTime WZFRVHYDZUR(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "32")]
		SetResult CLAYMGKGAXT(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "33")]
		long FDFYXXKOUTQ(string a, long b = 0L);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "34")]
		SetResult RZKJFVXYHSS(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void KQJIZSSYWZH<e>(ZXDWIEXBMRB<e> a, [Optional] IEqualityComparer<e> b);

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void PTRGMKKXBUG<f>();

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "37")]
		IDisposable FHVHWCLLBTZ();

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void JBBJYMOKPPC(float a);

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "39")]
		Task MXHJCYJEPMP([Optional] CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public enum SetResult : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Unchanged,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		New,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		Changed
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class Preferences : AWJSQTHCCJW, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		private abstract class XPWUPRTQTMK
		{
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			protected static readonly HashSet<XPWUPRTQTMK> TQRDQBLGDVH;

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8984360", Offset = "0x8983160", VA = "0x188984360")]
			public static void MTJMLYNMQOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract void Clear();

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			protected XPWUPRTQTMK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		private class FRIPPANHFKR<a> : XPWUPRTQTMK
		{
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public static readonly FRIPPANHFKR<a> GUIRZRNRSLG;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public ZXDWIEXBMRB<a> SHDVJWTYLZC
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public IEqualityComparer<a> MWWDMQRNFDG
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600012A")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool DHLFRUDALQT
			{
				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0x505B780", Offset = "0x505A580", VA = "0x18505B780")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x505C0F0", Offset = "0x505AEF0", VA = "0x18505C0F0")]
			private FRIPPANHFKR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x505B990", Offset = "0x505A790", VA = "0x18505B990")]
			public void PUOFOOQAOVA(ZXDWIEXBMRB<a> a, [Optional] IEqualityComparer<a> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x505B730", Offset = "0x505A530", VA = "0x18505B730", Slot = "4")]
			public override void Clear()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		private class XGFKQDHTMTU : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private readonly Preferences UESSSIHPUQT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private readonly object MONWQXWOFUJ;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x89842B0", Offset = "0x89830B0", VA = "0x1889842B0")]
			public XGFKQDHTMTU(Preferences a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x8984280", Offset = "0x8983080", VA = "0x188984280", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private struct <InitializeForPlayerInternal>d__23 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public Preferences <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public long playerAccountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x8983360", Offset = "0x8982160", VA = "0x188983360", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x8983650", Offset = "0x8982450", VA = "0x188983650", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private struct <Save>d__77 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public Preferences <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public OCZFRIEQPIZ backingStoreToSave;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x8984010", Offset = "0x8982E10", VA = "0x188984010", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private struct <SaveImmediate>d__78 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public Preferences <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x89836B0", Offset = "0x89824B0", VA = "0x1889836B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x8983B80", Offset = "0x8982980", VA = "0x188983B80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class BPDSJDAFFGY : IEnumerator<IMKAVQMVTAL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private IMKAVQMVTAL QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public Preferences WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public float WWQSBBONECY;

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			private IMKAVQMVTAL TBVNXHVEJNY
			{
				[Cpp2IlInjected.Token(Token = "0x600013B")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x600013D")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public BPDSJDAFFGY(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x897B710", Offset = "0x897A510", VA = "0x18897B710", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x897B6D0", Offset = "0x897A4D0", VA = "0x18897B6D0", Slot = "8")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly BMVPPZKNKBA GRZKUITJTQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly BMVPPZKNKBA TYQPINHCYQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly REUXGLSVIGY BXZGREZJVJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly TQPUKRRDZNZ LDPTRROTLSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly HUDXAKZUUJV.CustomSaveHandler TKCONOFQMDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly MSAILQECLZZ YOORYLWHYVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly HashSet<OCZFRIEQPIZ> JDVHGXGGZCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private Task HQZZNMHVIAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private Dictionary<string, string> YNTKVTCXXCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private DLHIAPQRHVO LNVWGZSJYZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly object SFNENFVVZCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly object YNMIMKNLMWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private long BNRCNRDIKBX;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private bool OUACPTLDZRF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x1A23C40", Offset = "0x1A22A40", VA = "0x181A23C40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private CancellationTokenSource BKDCGNSKNUE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xAC31E0", Offset = "0xAC1FE0", VA = "0x180AC31E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xAC31C0", Offset = "0xAC1FC0", VA = "0x180AC31C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action WQHMEUJSXTL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x8980600", Offset = "0x897F400", VA = "0x188980600", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x89809C0", Offset = "0x897F7C0", VA = "0x1889809C0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8980BF0", Offset = "0x897F9F0", VA = "0x188980BF0")]
		[FDNTPBIGLET.Root]
		internal static void XWYNCRUHYPG(FDTRVDFSBYT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8981230", Offset = "0x8980030", VA = "0x188981230")]
		[UnityEngine.Scripting.Preserve]
		public Preferences([Inject("Disk")] BMVPPZKNKBA localBackingStore, [Inject("Cloud")] BMVPPZKNKBA cloudBackingStore, [Inject(null)] REUXGLSVIGY editorBackingStore, [Inject(null)] TQPUKRRDZNZ scheduler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x897EEB0", Offset = "0x897DCB0", VA = "0x18897EEB0", Slot = "44")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8980BA0", Offset = "0x897F9A0", VA = "0x188980BA0")]
		private void XRWWSTGXFYD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8980440", Offset = "0x897F240", VA = "0x188980440", Slot = "6")]
		public void QPVANJJYXHX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x897ECE0", Offset = "0x897DAE0", VA = "0x18897ECE0", Slot = "7")]
		public Task DZMSSOKNBVJ(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x897E850", Offset = "0x897D650", VA = "0x18897E850")]
		[AsyncStateMachine(typeof(<InitializeForPlayerInternal>d__23))]
		private Task AYNPPYOGRQE(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x89804B0", Offset = "0x897F2B0", VA = "0x1889804B0")]
		private void RZFUJEVCQJL(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x897F4F0", Offset = "0x897E2F0", VA = "0x18897F4F0")]
		private void HAZKAUENZBK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x897EEF0", Offset = "0x897DCF0", VA = "0x18897EEF0")]
		private string ECFPYTTTORF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x897FA60", Offset = "0x897E860", VA = "0x18897FA60")]
		private void JMQIRFNSRWT(AccountPreferenceBackingStoreTypes a, string b, [Out] BMVPPZKNKBA c, [Out] string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x897E7D0", Offset = "0x897D5D0", VA = "0x18897E7D0")]
		private BMVPPZKNKBA ASGLOSSZPXJ(AccountPreferenceBackingStoreTypes a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x897F6E0", Offset = "0x897E4E0", VA = "0x18897F6E0", Slot = "8")]
		public bool HRAVTKSFQUP(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x897E960", Offset = "0x897D760", VA = "0x18897E960", Slot = "9")]
		public bool BNICWPRUFZN(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x897EF50", Offset = "0x897DD50", VA = "0x18897EF50", Slot = "10")]
		public bool ECKVGTYBJTY(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8980700", Offset = "0x897F500", VA = "0x188980700", Slot = "11")]
		public string WOLPNYLCEHD(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x897E640", Offset = "0x897D440", VA = "0x18897E640", Slot = "12")]
		public SetResult AECELXLGVJX(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x897FD80", Offset = "0x897EB80", VA = "0x18897FD80", Slot = "13")]
		public int KVYSDEULACF(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x897EB60", Offset = "0x897D960", VA = "0x18897EB60", Slot = "14")]
		public SetResult DTQXPFGHDYZ(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x897F440", Offset = "0x897E240", VA = "0x18897F440", Slot = "15")]
		public bool GVGUGXHWASM(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8980ED0", Offset = "0x897FCD0", VA = "0x188980ED0", Slot = "16")]
		public SetResult YRCHILPLUWY(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8980230", Offset = "0x897F030", VA = "0x188980230", Slot = "17")]
		public float OMYYACOBAJI(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x897E4C0", Offset = "0x897D2C0", VA = "0x18897E4C0", Slot = "18")]
		public SetResult ADSFBWFJJFI(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x897EA00", Offset = "0x897D800", VA = "0x18897EA00", Slot = "19")]
		public DateTime CGPXTKPFCZL(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8980810", Offset = "0x897F610", VA = "0x188980810", Slot = "20")]
		public SetResult XCWZGTUDVGB(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8981190", Offset = "0x897FF90", VA = "0x188981190", Slot = "21")]
		public long ZTYLVFXPHRA(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x897FC00", Offset = "0x897EA00", VA = "0x18897FC00", Slot = "22")]
		public SetResult KKNFYHROTUO(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3BB7D70", Offset = "0x3BB6B70", VA = "0x183BB7D70", Slot = "23")]
		public a XAOWTKZOOUD<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3BB7AC0", Offset = "0x3BB68C0", VA = "0x183BB7AC0", Slot = "24")]
		public SetResult USWFIIYSDMD<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x897EB00", Offset = "0x897D900", VA = "0x18897EB00", Slot = "25")]
		public bool DNILBIMUTTB(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8980130", Offset = "0x897EF30", VA = "0x188980130", Slot = "26")]
		public bool MNDCUZPKDXS(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x897F800", Offset = "0x897E600", VA = "0x18897F800", Slot = "27")]
		public string IFNIQCBOHXX(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x897F0D0", Offset = "0x897DED0", VA = "0x18897F0D0", Slot = "28")]
		public SetResult EGVJVGMBDUJ(string a, string b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x897F790", Offset = "0x897E590", VA = "0x18897F790", Slot = "29")]
		public int HSLOWOPTJDX(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x897E490", Offset = "0x897D290", VA = "0x18897E490", Slot = "30")]
		public SetResult ADEPMRYHSSJ(string a, int b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x897E420", Offset = "0x897D220", VA = "0x18897E420", Slot = "31")]
		public bool AAAHTKACOMA(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x897F410", Offset = "0x897E210", VA = "0x18897F410", Slot = "32")]
		public SetResult GTTTFWMSFEQ(string a, bool b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x897FE30", Offset = "0x897EC30", VA = "0x18897FE30", Slot = "33")]
		public float LCEFVPMVXVU(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x897EAA0", Offset = "0x897D8A0", VA = "0x18897EAA0", Slot = "34")]
		public SetResult CKWWZFBAHVI(string a, float b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x89807A0", Offset = "0x897F5A0", VA = "0x1889807A0", Slot = "35")]
		public DateTime WZFRVHYDZUR(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x897EAD0", Offset = "0x897D8D0", VA = "0x18897EAD0", Slot = "36")]
		public SetResult CLAYMGKGAXT(string a, DateTime b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x897F100", Offset = "0x897DF00", VA = "0x18897F100", Slot = "37")]
		public long FDFYXXKOUTQ(string a, long b = 0L)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x89804D0", Offset = "0x897F2D0", VA = "0x1889804D0", Slot = "38")]
		public SetResult RZKJFVXYHSS(string a, long b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x89806A0", Offset = "0x897F4A0", VA = "0x1889806A0")]
		private bool VHLEUPWSHIZ(OCZFRIEQPIZ a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x89802E0", Offset = "0x897F0E0", VA = "0x1889802E0")]
		private bool QHSRVWPKFLC(OCZFRIEQPIZ a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x897F240", Offset = "0x897E040", VA = "0x18897F240")]
		private SetResult FSMFQAUKUEA(OCZFRIEQPIZ a, string b, string c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x897FFF0", Offset = "0x897EDF0", VA = "0x18897FFF0")]
		private SetResult LIVIDIVIHEK(OCZFRIEQPIZ a, string b, int c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8980A60", Offset = "0x897F860", VA = "0x188980A60")]
		private SetResult XNQRJDGKJQB(OCZFRIEQPIZ a, string b, bool c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x897FEA0", Offset = "0x897ECA0", VA = "0x18897FEA0")]
		private SetResult LEIODNJMDWV(OCZFRIEQPIZ a, string b, float c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x897F570", Offset = "0x897E370", VA = "0x18897F570")]
		private SetResult HEBSYJAZRSQ(OCZFRIEQPIZ a, string b, DateTime c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8981050", Offset = "0x897FE50", VA = "0x188981050")]
		private SetResult ZQKACVDQOLN(OCZFRIEQPIZ a, string b, long c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x3BB66B0", Offset = "0x3BB54B0", VA = "0x183BB66B0")]
		private e JRYVRRGFOUS<e>(OCZFRIEQPIZ a, string b, e c)
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x3BB6DE0", Offset = "0x3BB5BE0", VA = "0x183BB6DE0")]
		private SetResult LWELMHZBSFM<f>(OCZFRIEQPIZ a, string b, f c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3BB6C00", Offset = "0x3BB5A00", VA = "0x183BB6C00", Slot = "39")]
		public void KQJIZSSYWZH<g>(ZXDWIEXBMRB<g> a, [Optional] IEqualityComparer<g> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x3BB7A30", Offset = "0x3BB6830", VA = "0x183BB7A30", Slot = "40")]
		public void PTRGMKKXBUG<h>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8980500", Offset = "0x897F300", VA = "0x188980500")]
		[AsyncStateMachine(typeof(<Save>d__77))]
		private void Save(OCZFRIEQPIZ backingStoreToSave)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8980140", Offset = "0x897EF40", VA = "0x188980140", Slot = "43")]
		[AsyncStateMachine(typeof(<SaveImmediate>d__78))]
		public Task MXHJCYJEPMP([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x897F880", Offset = "0x897E680", VA = "0x18897F880")]
		private void JJCHWWOVTDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x897F170", Offset = "0x897DF70", VA = "0x18897F170", Slot = "41")]
		public IDisposable FHVHWCLLBTZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x897F870", Offset = "0x897E670", VA = "0x18897F870", Slot = "42")]
		public void JBBJYMOKPPC(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8980C60", Offset = "0x897FA60", VA = "0x188980C60")]
		private void YGIXWJUSKII(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x897F390", Offset = "0x897E190", VA = "0x18897F390")]
		[IteratorStateMachine(typeof(BPDSJDAFFGY))]
		private IEnumerator<IMKAVQMVTAL> GPSDXFKQEZI(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x89805D0", Offset = "0x897F3D0", VA = "0x1889805D0")]
		[CompilerGenerated]
		private void TTBFAYSLOGF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class ETAAXVJVLHM
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x897BA60", Offset = "0x897A860", VA = "0x18897BA60")]
		public static string YBHFJIGBRZX(this AWJSQTHCCJW a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x897B7A0", Offset = "0x897A5A0", VA = "0x18897B7A0")]
		public static byte[] SKARTKZHXIX(this AWJSQTHCCJW a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x897B950", Offset = "0x897A750", VA = "0x18897B950")]
		public static SetResult TXABVYNOZEL(this AWJSQTHCCJW a, string b, ReadOnlySpan<byte> value)
		{
			return default(SetResult);
		}
	}
}
namespace RecRoom.Preferences.CustomParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class XQNYAQYGITZ : GXCXYZPRHKT<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static XQNYAQYGITZ GUIRZRNRSLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x8984520", Offset = "0x8983320", VA = "0x188984520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x89847F0", Offset = "0x89835F0", VA = "0x1889847F0", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8984570", Offset = "0x8983370", VA = "0x188984570", Slot = "10")]
		protected override bool FBBQUPAPSVM(string a, [Out] bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8984970", Offset = "0x8983770", VA = "0x188984970")]
		public XQNYAQYGITZ()
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
