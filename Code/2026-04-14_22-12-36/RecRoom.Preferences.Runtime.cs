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
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C51DB0", Offset = "0x9C509B0", VA = "0x189C51DB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD19850", Offset = "0xD18450", VA = "0x180D19850")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_Preferences_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9C51BD0", Offset = "0x9C507D0", VA = "0x189C51BD0", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Preferences_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9C5A040", Offset = "0x9C58C40", VA = "0x189C5A040", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x29F8180", Offset = "0x29F6D80", VA = "0x1829F8180")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Preferences
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum AccountPreferenceBackingStoreTypes : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		CLOUD,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		DISK
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal static class JBUYDEPBVXS
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		internal delegate void CustomSaveHandler(FWDDJKISYCY backingStore);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9C4E790", Offset = "0x9C4D390", VA = "0x189C4E790")]
		private static void HAHSIKQFJUP(FWDDJKISYCY a, CustomSaveHandler b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9C4EA90", Offset = "0x9C4D690", VA = "0x189C4EA90")]
		public static bool LOQJIKUUIYF(this FWDDJKISYCY a, string b, [Optional] CustomSaveHandler c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9C4E4F0", Offset = "0x9C4D0F0", VA = "0x189C4E4F0")]
		public static SetResult DQUASEVGJQY(this FWDDJKISYCY a, string b, string c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9C4EBF0", Offset = "0x9C4D7F0", VA = "0x189C4EBF0")]
		public static SetResult TTQPDBMXDYA(this FWDDJKISYCY a, string b, int c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9C4E950", Offset = "0x9C4D550", VA = "0x189C4E950")]
		public static SetResult KWNWBJAWSZP(this FWDDJKISYCY a, string b, bool c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9C4E640", Offset = "0x9C4D240", VA = "0x189C4E640")]
		public static SetResult DVSHGBDNWMX(this FWDDJKISYCY a, string b, float c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9C4ED30", Offset = "0x9C4D930", VA = "0x189C4ED30")]
		public static SetResult XKPLZKNFTNS(this FWDDJKISYCY a, string b, DateTime c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9C4E810", Offset = "0x9C4D410", VA = "0x189C4E810")]
		public static SetResult IRATEJICQAD(this FWDDJKISYCY a, string b, long c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class SDYIORZXWBT : ZFDAPHSPYER, FWDDJKISYCY
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log AWZAYZHQABY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly HPYGNHKGIYE ZOUJREVDJSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Dictionary<string, byte> BHBYUWGMVYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Dictionary<string, string> UUMBNIIEWCU;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool PWWECYVUCJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Dictionary<string, string> MNOCALOZIOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9C555C0", Offset = "0x9C541C0", VA = "0x189C555C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action XRKISDBTAJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9C57AC0", Offset = "0x9C566C0", VA = "0x189C57AC0")]
		[UnityEngine.Scripting.Preserve]
		public SDYIORZXWBT([Inject(null)] HPYGNHKGIYE unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "8")]
		public void UBYRWVAVOXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9C572F0", Offset = "0x9C55EF0", VA = "0x189C572F0")]
		private DirectoryInfo RUVOVUJNGRC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9C56350", Offset = "0x9C54F50", VA = "0x189C56350", Slot = "6")]
		public Task OROICLDNWEA(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9C55600", Offset = "0x9C54200", VA = "0x189C55600", Slot = "14")]
		public float BICZAKOTTES(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9C56270", Offset = "0x9C54E70", VA = "0x189C56270", Slot = "13")]
		public void MVYOWXFBYQY(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9C55A80", Offset = "0x9C54680", VA = "0x189C55A80", Slot = "12")]
		public bool LMYOCXVGACQ(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9C57800", Offset = "0x9C56400", VA = "0x189C57800", Slot = "10")]
		public int XFGLJJICOSJ(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9C579E0", Offset = "0x9C565E0", VA = "0x189C579E0", Slot = "18")]
		public DateTime ZQTOGBOWEVP(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9C57280", Offset = "0x9C55E80", VA = "0x189C57280", Slot = "19")]
		public void RMLSZBSDALP(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9C562E0", Offset = "0x9C54EE0", VA = "0x189C562E0", Slot = "15")]
		public void NGBXFFZTZDQ(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9C57720", Offset = "0x9C56320", VA = "0x189C57720", Slot = "11")]
		public void UOLRMCBBXKJ(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9C57790", Offset = "0x9C56390", VA = "0x189C57790", Slot = "20")]
		public long VACXPISJHOK(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9C57160", Offset = "0x9C55D60", VA = "0x189C57160", Slot = "21")]
		public void PCZCIJFSIAO(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3F029B0", Offset = "0x3F015B0", VA = "0x183F029B0", Slot = "22")]
		public a XAZIOXTNTPF<a>(string a, a b, BILDKLRZYOS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3EFFAA0", Offset = "0x3EFE6A0", VA = "0x183EFFAA0", Slot = "23")]
		public void AYGFZABJFXR<b>(string a, b b, BILDKLRZYOS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9C571D0", Offset = "0x9C55DD0", VA = "0x189C571D0", Slot = "16")]
		public string QGOSMAICKCR(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9C55B50", Offset = "0x9C54750", VA = "0x189C55B50", Slot = "17")]
		public void LSGQKGXBITT(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9C57870", Offset = "0x9C56470", VA = "0x189C57870", Slot = "24")]
		public void YXHJXTPLZOK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9C557D0", Offset = "0x9C543D0", VA = "0x189C557D0", Slot = "9")]
		public bool KDMDMFGWMYX(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9C573E0", Offset = "0x9C55FE0", VA = "0x189C573E0", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9C55BC0", Offset = "0x9C547C0", VA = "0x189C55BC0")]
		private void MHUZKQVUBVE(DirectoryInfo a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9C55860", Offset = "0x9C54460", VA = "0x189C55860")]
		private static string LHAEHSQOMNF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9C556D0", Offset = "0x9C542D0", VA = "0x189C556D0")]
		private static string FXLGVDTHUKA(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3EFFC40", Offset = "0x3EFE840", VA = "0x183EFFC40")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] BILDKLRZYOS<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3F01430", Offset = "0x3F00030", VA = "0x183F01430")]
		private void Set<T>(string propertyName, T value, [Optional] BILDKLRZYOS<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9C563E0", Offset = "0x9C54FE0", VA = "0x189C563E0")]
		private Dictionary<string, string> PCFYDYHEZKG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9C55670", Offset = "0x9C54270", VA = "0x189C55670")]
		private void DJQPSCLEWQG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9C56200", Offset = "0x9C54E00", VA = "0x189C56200")]
		private void MUOOFQELMJL(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class VLTMCAKRULX
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly Log AWZAYZHQABY;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9C599E0", Offset = "0x9C585E0", VA = "0x189C599E0")]
		[GEPWJNEAFDW.Root]
		internal static void GEPWJNEAFDW(VIGMLMXVCUS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class EQDAPTMPDRU : ORGZOGVYTFB
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9C4E470", Offset = "0x9C4D070", VA = "0x189C4E470")]
		[UnityEngine.Scripting.Preserve]
		public EQDAPTMPDRU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class CJWDCSUVBTO : ZFDAPHSPYER, FWDDJKISYCY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly HPYGNHKGIYE ZOUJREVDJSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly Dictionary<string, string> PHZBIKWWZRM;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool PWWECYVUCJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action XRKISDBTAJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9C4D440", Offset = "0x9C4C040", VA = "0x189C4D440")]
		[UnityEngine.Scripting.Preserve]
		public CJWDCSUVBTO([Inject(null)] HPYGNHKGIYE unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9C4CF70", Offset = "0x9C4BB70", VA = "0x189C4CF70", Slot = "6")]
		public Task OROICLDNWEA(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "8")]
		public void UBYRWVAVOXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9C4CD50", Offset = "0x9C4B950", VA = "0x189C4CD50", Slot = "9")]
		public bool KDMDMFGWMYX(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9C4D2D0", Offset = "0x9C4BED0", VA = "0x189C4D2D0", Slot = "10")]
		public int XFGLJJICOSJ(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9C4D1F0", Offset = "0x9C4BDF0", VA = "0x189C4D1F0", Slot = "11")]
		public void UOLRMCBBXKJ(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9C4CDB0", Offset = "0x9C4B9B0", VA = "0x189C4CDB0", Slot = "12")]
		public bool LMYOCXVGACQ(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9C4CE90", Offset = "0x9C4BA90", VA = "0x189C4CE90", Slot = "13")]
		public void MVYOWXFBYQY(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9C4CCE0", Offset = "0x9C4B8E0", VA = "0x189C4CCE0", Slot = "14")]
		public float BICZAKOTTES(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9C4CF00", Offset = "0x9C4BB00", VA = "0x189C4CF00", Slot = "15")]
		public void NGBXFFZTZDQ(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9C4D070", Offset = "0x9C4BC70", VA = "0x189C4D070", Slot = "16")]
		public string QGOSMAICKCR(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9C4CE20", Offset = "0x9C4BA20", VA = "0x189C4CE20", Slot = "17")]
		public void LSGQKGXBITT(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9C4D3D0", Offset = "0x9C4BFD0", VA = "0x189C4D3D0", Slot = "18")]
		public DateTime ZQTOGBOWEVP(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9C4D0F0", Offset = "0x9C4BCF0", VA = "0x189C4D0F0", Slot = "19")]
		public void RMLSZBSDALP(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9C4D260", Offset = "0x9C4BE60", VA = "0x189C4D260", Slot = "20")]
		public long VACXPISJHOK(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9C4D000", Offset = "0x9C4BC00", VA = "0x189C4D000", Slot = "21")]
		public void PCZCIJFSIAO(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x37E12A0", Offset = "0x37DFEA0", VA = "0x1837E12A0", Slot = "22")]
		public a XAZIOXTNTPF<a>(string a, a b, BILDKLRZYOS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x37DE7C0", Offset = "0x37DD3C0", VA = "0x1837DE7C0", Slot = "23")]
		public void AYGFZABJFXR<b>(string a, b b, BILDKLRZYOS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9C4D340", Offset = "0x9C4BF40", VA = "0x189C4D340", Slot = "24")]
		public void YXHJXTPLZOK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9C4D160", Offset = "0x9C4BD60", VA = "0x189C4D160", Slot = "25")]
		public Task Save([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x37DE960", Offset = "0x37DD560", VA = "0x1837DE960")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] BILDKLRZYOS<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x37E0150", Offset = "0x37DED50", VA = "0x1837E0150")]
		private void Set<T>(string propertyName, T value, [Optional] BILDKLRZYOS<T> parser)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ORGZOGVYTFB : ZFDAPHSPYER, FWDDJKISYCY, OKZZSQTUEMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly Dictionary<string, object> WTRDIUDPCBX;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool PWWECYVUCJM
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action XRKISDBTAJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "8")]
		public void UBYRWVAVOXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9C52070", Offset = "0x9C50C70", VA = "0x189C52070", Slot = "6")]
		public Task OROICLDNWEA(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9C51E90", Offset = "0x9C50A90", VA = "0x189C51E90", Slot = "9")]
		public bool KDMDMFGWMYX(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9C52370", Offset = "0x9C50F70", VA = "0x189C52370", Slot = "10")]
		public int XFGLJJICOSJ(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9C522B0", Offset = "0x9C50EB0", VA = "0x189C522B0", Slot = "11")]
		public void UOLRMCBBXKJ(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9C51EF0", Offset = "0x9C50AF0", VA = "0x189C51EF0", Slot = "12")]
		public bool LMYOCXVGACQ(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9C51FB0", Offset = "0x9C50BB0", VA = "0x189C51FB0", Slot = "13")]
		public void MVYOWXFBYQY(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9C51E30", Offset = "0x9C50A30", VA = "0x189C51E30", Slot = "14")]
		public float BICZAKOTTES(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9C52010", Offset = "0x9C50C10", VA = "0x189C52010", Slot = "15")]
		public void NGBXFFZTZDQ(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9C52160", Offset = "0x9C50D60", VA = "0x189C52160", Slot = "16")]
		public string QGOSMAICKCR(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9C51F50", Offset = "0x9C50B50", VA = "0x189C51F50", Slot = "17")]
		public void LSGQKGXBITT(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9C52430", Offset = "0x9C51030", VA = "0x189C52430", Slot = "18")]
		public DateTime ZQTOGBOWEVP(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9C521C0", Offset = "0x9C50DC0", VA = "0x189C521C0", Slot = "19")]
		public void RMLSZBSDALP(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9C52310", Offset = "0x9C50F10", VA = "0x189C52310", Slot = "20")]
		public long VACXPISJHOK(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9C52100", Offset = "0x9C50D00", VA = "0x189C52100", Slot = "21")]
		public void PCZCIJFSIAO(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3D89DB0", Offset = "0x3D889B0", VA = "0x183D89DB0", Slot = "22")]
		public a XAZIOXTNTPF<a>(string a, a b, BILDKLRZYOS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x3D88A50", Offset = "0x3D87650", VA = "0x183D88A50", Slot = "23")]
		public void AYGFZABJFXR<b>(string a, b b, BILDKLRZYOS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3D88C50", Offset = "0x3D87850", VA = "0x183D88C50")]
		public T Get<T>(string propertyName, T defaultValue)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3D896E0", Offset = "0x3D882E0", VA = "0x183D896E0")]
		public void Set<T>(string propertyName, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9C523D0", Offset = "0x9C50FD0", VA = "0x189C523D0", Slot = "24")]
		public void YXHJXTPLZOK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9C52220", Offset = "0x9C50E20", VA = "0x189C52220", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9C4E470", Offset = "0x9C4D070", VA = "0x189C4E470")]
		public ORGZOGVYTFB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public abstract class TLLHFJLEYRM<a> where a : FWDDJKISYCY
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static readonly HashSet<TLLHFJLEYRM<a>> VIMUXTOMENJ;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7A8ADE0", Offset = "0x7A899E0", VA = "0x187A8ADE0")]
		protected TLLHFJLEYRM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void Clear();

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void GXLNJFYYQBM(string a);

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7A8A930", Offset = "0x7A89530", VA = "0x187A8A930")]
		public static void QMAPDNOOLBO(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7A8A1E0", Offset = "0x7A88DE0", VA = "0x187A8A1E0")]
		public static void IEEYZUXTILW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class TLGAICRHPGD<a, b> : TLLHFJLEYRM<a> where a : FWDDJKISYCY
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly TLGAICRHPGD<a, b> FYIBPTBKDJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly Dictionary<string, b> SOWLQBALBPO;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7A89D20", Offset = "0x7A88920", VA = "0x187A89D20")]
		public bool XXTFUCBFMWE(string a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7A89AE0", Offset = "0x7A886E0", VA = "0x187A89AE0")]
		public void Store(string cacheKey, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
		public IEnumerable<KeyValuePair<string, b>> IXJYSGURNKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7670810", Offset = "0x766F410", VA = "0x187670810", Slot = "4")]
		protected override void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7A89880", Offset = "0x7A88480", VA = "0x187A89880", Slot = "5")]
		protected override void GXLNJFYYQBM(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7A8A060", Offset = "0x7A88C60", VA = "0x187A8A060")]
		public TLGAICRHPGD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface FWDDJKISYCY
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool PWWECYVUCJM
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void UBYRWVAVOXQ();

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool KDMDMFGWMYX(string a);

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int XFGLJJICOSJ(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void UOLRMCBBXKJ(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool LMYOCXVGACQ(string a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void MVYOWXFBYQY(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float BICZAKOTTES(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void NGBXFFZTZDQ(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "9")]
		string QGOSMAICKCR(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void LSGQKGXBITT(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		DateTime ZQTOGBOWEVP(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void RMLSZBSDALP(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		long VACXPISJHOK(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void PCZCIJFSIAO(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		a XAZIOXTNTPF<a>(string a, a b, BILDKLRZYOS<a> c);

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void AYGFZABJFXR<b>(string a, b b, BILDKLRZYOS<b> c);

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void YXHJXTPLZOK(string a);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Task Save([Optional] CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface ZFDAPHSPYER : FWDDJKISYCY
	{
		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event Action XRKISDBTAJO;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task OROICLDNWEA(long a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface OKZZSQTUEMJ : FWDDJKISYCY
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class LQVCURLRAAP : ZFDAPHSPYER, FWDDJKISYCY
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct <Save>d__40 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public LQVCURLRAAP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x9C58AF0", Offset = "0x9C576F0", VA = "0x189C58AF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x9C58EB0", Offset = "0x9C57AB0", VA = "0x189C58EB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class DKNLFUMVHSF : IEnumerator<NVIJVYVFXPY>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private NVIJVYVFXPY PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public LQVCURLRAAP DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private NVIJVYVFXPY YPZFRLKUQEB
			{
				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public DKNLFUMVHSF(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x9C4D520", Offset = "0x9C4C120", VA = "0x189C4D520", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x9C4D4E0", Offset = "0x9C4C0E0", VA = "0x189C4D4E0", Slot = "8")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly Log AWZAYZHQABY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly HPYGNHKGIYE ZOUJREVDJSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool YJILUJQMUXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool BLIEJHCKJUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private EIGPTYHGYCM KWAEVTXZJMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private YDHSMJLFZLP FHCSOXXHYDB;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool PWWECYVUCJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action XRKISDBTAJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9C51AD0", Offset = "0x9C506D0", VA = "0x189C51AD0")]
		[UnityEngine.Scripting.Preserve]
		public LQVCURLRAAP([Inject(null)] HPYGNHKGIYE unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "8")]
		public void UBYRWVAVOXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9C4F550", Offset = "0x9C4E150", VA = "0x189C4F550", Slot = "6")]
		public Task OROICLDNWEA(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1E8E8B0", Offset = "0x1E8D4B0", VA = "0x181E8E8B0")]
		private static int EZPKYWBBFLQ(bool a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9C4F0A0", Offset = "0x9C4DCA0", VA = "0x189C4F0A0", Slot = "9")]
		public bool KDMDMFGWMYX(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9C51700", Offset = "0x9C50300", VA = "0x189C51700", Slot = "10")]
		public int XFGLJJICOSJ(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9C51560", Offset = "0x9C50160", VA = "0x189C51560", Slot = "11")]
		public void UOLRMCBBXKJ(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9C4F0C0", Offset = "0x9C4DCC0", VA = "0x189C4F0C0", Slot = "12")]
		public bool LMYOCXVGACQ(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9C4F3B0", Offset = "0x9C4DFB0", VA = "0x189C4F3B0", Slot = "13")]
		public void MVYOWXFBYQY(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9C4EEA0", Offset = "0x9C4DAA0", VA = "0x189C4EEA0", Slot = "14")]
		public float BICZAKOTTES(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9C4F490", Offset = "0x9C4E090", VA = "0x189C4F490", Slot = "15")]
		public void NGBXFFZTZDQ(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9C519F0", Offset = "0x9C505F0", VA = "0x189C519F0", Slot = "18")]
		public DateTime ZQTOGBOWEVP(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9C4F9B0", Offset = "0x9C4E5B0", VA = "0x189C4F9B0", Slot = "19")]
		public void RMLSZBSDALP(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9C51620", Offset = "0x9C50220", VA = "0x189C51620", Slot = "20")]
		public long VACXPISJHOK(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9C4F5E0", Offset = "0x9C4E1E0", VA = "0x189C4F5E0", Slot = "21")]
		public void PCZCIJFSIAO(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3BF0E10", Offset = "0x3BEFA10", VA = "0x183BF0E10", Slot = "22")]
		public a XAZIOXTNTPF<a>(string a, a b, BILDKLRZYOS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3BEFFD0", Offset = "0x3BEEBD0", VA = "0x183BEFFD0", Slot = "23")]
		public void AYGFZABJFXR<b>(string a, b b, BILDKLRZYOS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3BF1010", Offset = "0x3BEFC10", VA = "0x183BF1010")]
		private c ZGENTANSZVU<c>(string a, c b, [Optional] BILDKLRZYOS<c> c)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3BF0190", Offset = "0x3BEED90", VA = "0x183BF0190")]
		private void FCGKPNQRPEC<d>(string a, d b, [Optional] BILDKLRZYOS<d> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9C4F650", Offset = "0x9C4E250", VA = "0x189C4F650", Slot = "16")]
		public string QGOSMAICKCR(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9C4F210", Offset = "0x9C4DE10", VA = "0x189C4F210", Slot = "17")]
		public void LSGQKGXBITT(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9C51830", Offset = "0x9C50430", VA = "0x189C51830")]
		private void YEMIURUMHWE(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9C4F800", Offset = "0x9C4E400", VA = "0x189C4F800")]
		private string RKRMRLIRNBC(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9C51960", Offset = "0x9C50560", VA = "0x189C51960", Slot = "24")]
		public void YXHJXTPLZOK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9C514C0", Offset = "0x9C500C0", VA = "0x189C514C0")]
		private string UKOLEHHHOUO(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9C4FA80", Offset = "0x9C4E680", VA = "0x189C4FA80")]
		public void SHVISIUNHZT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9C4F040", Offset = "0x9C4DC40", VA = "0x189C4F040", Slot = "26")]
		public void GFGFUMRQURE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9C513D0", Offset = "0x9C4FFD0", VA = "0x189C513D0", Slot = "25")]
		[AsyncStateMachine(typeof(<Save>d__40))]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9C51690", Offset = "0x9C50290", VA = "0x189C51690")]
		[IteratorStateMachine(typeof(DKNLFUMVHSF))]
		private IEnumerator<NVIJVYVFXPY> XAZORADDEIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9C4FA20", Offset = "0x9C4E620", VA = "0x189C4FA20")]
		private void RPINLRKAUNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9C4EFD0", Offset = "0x9C4DBD0", VA = "0x189C4EFD0")]
		private void DJQPSCLEWQG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9C4F340", Offset = "0x9C4DF40", VA = "0x189C4F340")]
		private void MUOOFQELMJL(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class EERKMDWMGNB : ZFDAPHSPYER, FWDDJKISYCY
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private struct KVP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public string k;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public string v;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private struct KVPs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public KVP[] kvps;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private Dictionary<string, string> UUMBNIIEWCU;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool PWWECYVUCJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private string HGXJPZZGYPB
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x9C4D6D0", Offset = "0x9C4C2D0", VA = "0x189C4D6D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private string LEIDNZQQNOB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x9C4D640", Offset = "0x9C4C240", VA = "0x189C4D640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Dictionary<string, string> MNOCALOZIOG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x9C4D590", Offset = "0x9C4C190", VA = "0x189C4D590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action XRKISDBTAJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		[UnityEngine.Scripting.Preserve]
		public EERKMDWMGNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "8")]
		public void UBYRWVAVOXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9C4DA40", Offset = "0x9C4C640", VA = "0x189C4DA40", Slot = "6")]
		public Task OROICLDNWEA(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9C4D5D0", Offset = "0x9C4C1D0", VA = "0x189C4D5D0", Slot = "14")]
		public float BICZAKOTTES(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9C4D960", Offset = "0x9C4C560", VA = "0x189C4D960", Slot = "13")]
		public void MVYOWXFBYQY(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9C4D7F0", Offset = "0x9C4C3F0", VA = "0x189C4D7F0", Slot = "12")]
		public bool LMYOCXVGACQ(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9C4E2D0", Offset = "0x9C4CED0", VA = "0x189C4E2D0", Slot = "10")]
		public int XFGLJJICOSJ(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9C4E400", Offset = "0x9C4D000", VA = "0x189C4E400", Slot = "18")]
		public DateTime ZQTOGBOWEVP(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9C4DF20", Offset = "0x9C4CB20", VA = "0x189C4DF20", Slot = "19")]
		public void RMLSZBSDALP(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9C4D9D0", Offset = "0x9C4C5D0", VA = "0x189C4D9D0", Slot = "15")]
		public void NGBXFFZTZDQ(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9C4E1F0", Offset = "0x9C4CDF0", VA = "0x189C4E1F0", Slot = "11")]
		public void UOLRMCBBXKJ(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9C4E260", Offset = "0x9C4CE60", VA = "0x189C4E260", Slot = "20")]
		public long VACXPISJHOK(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9C4DE00", Offset = "0x9C4CA00", VA = "0x189C4DE00", Slot = "21")]
		public void PCZCIJFSIAO(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x392EB60", Offset = "0x392D760", VA = "0x18392EB60", Slot = "22")]
		public a XAZIOXTNTPF<a>(string a, a b, BILDKLRZYOS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x392BFF0", Offset = "0x392ABF0", VA = "0x18392BFF0", Slot = "23")]
		public void AYGFZABJFXR<b>(string a, b b, BILDKLRZYOS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9C4DE70", Offset = "0x9C4CA70", VA = "0x189C4DE70", Slot = "16")]
		public string QGOSMAICKCR(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9C4D8C0", Offset = "0x9C4C4C0", VA = "0x189C4D8C0", Slot = "17")]
		public void LSGQKGXBITT(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9C4E340", Offset = "0x9C4CF40", VA = "0x189C4E340", Slot = "24")]
		public void YXHJXTPLZOK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9C4D760", Offset = "0x9C4C360", VA = "0x189C4D760", Slot = "9")]
		public bool KDMDMFGWMYX(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9C4DF90", Offset = "0x9C4CB90", VA = "0x189C4DF90", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x392C190", Offset = "0x392AD90", VA = "0x18392C190")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] BILDKLRZYOS<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x392D980", Offset = "0x392C580", VA = "0x18392D980")]
		private void Set<T>(string propertyName, T value, [Optional] BILDKLRZYOS<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9C4DAD0", Offset = "0x9C4C6D0", VA = "0x189C4DAD0")]
		private Dictionary<string, string> PCFYDYHEZKG()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface LLJFKJJXSMP
	{
		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event Action XRKISDBTAJO;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void UBYRWVAVOXQ();

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task GBCTPUKMHXS(long a);

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool QLHKIWLUYDW(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool JLHTCBFCYUW(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool NCLRDYKOUKR(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		string ILAFEQKASKK(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "8")]
		SetResult LNFBOLAXHNU(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "9")]
		int NJOOZPZHNUY(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "10")]
		SetResult WRYJMMZJDUU(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool KAHGEFYOKQP(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "12")]
		SetResult LSBTWOVNQUL(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "13")]
		float MKFVSXYVZMT(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "14")]
		SetResult ZAQKSRDDFCL(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "15")]
		DateTime UPFBRKOZXFQ(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "16")]
		SetResult XMTOQFCOTVE(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "17")]
		long QSYOPTZLYGJ(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "18")]
		SetResult ADCULKPXVNL(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "19")]
		a JYTIGQBWZNS<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "20")]
		SetResult OXNHEWAMGZS<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool BVSKIFANOTC(string a);

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool OKBBAVGFMZH(string a);

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "23")]
		string SMCDNJOWTEE(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "24")]
		SetResult SQZNZFNFZWU(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "25")]
		int IOTSQCRZYTI(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "26")]
		SetResult GAYHJOYWCFY(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "27")]
		bool FRHGLHQVNFP(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "28")]
		SetResult EIVRXBDIQZX(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "29")]
		float UDSAUUSGIOZ(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "30")]
		SetResult VUSLVFTVXVT(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "31")]
		DateTime EBYGQYKDLEU(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "32")]
		SetResult UKWCCRNPUNC(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "33")]
		long SIFWJINOHCT(string a, long b = 0L);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "34")]
		SetResult JCYHONYVQNF(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void XPXIDRBOXOK<e>(BILDKLRZYOS<e> a, [Optional] IEqualityComparer<e> b);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void XJBMXOWBEHH<f>();

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "37")]
		IDisposable DZEIWCNNNLY();

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void ZZDYWQWGVRH(float a);

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "39")]
		Task RPINLRKAUNA([Optional] CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public enum SetResult : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		Unchanged,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		New,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		Changed
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class Preferences : LLJFKJJXSMP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private abstract class TIXQYVBTFIZ
		{
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			protected static readonly HashSet<TIXQYVBTFIZ> NAENLTJDUQA;

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x9C580A0", Offset = "0x9C56CA0", VA = "0x189C580A0")]
			public static void IEEYZUXTILW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract void Clear();

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			protected TIXQYVBTFIZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		private class AJULTQXDILE<a> : TIXQYVBTFIZ
		{
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public static readonly AJULTQXDILE<a> UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public BILDKLRZYOS<a> VHXLUUGKSBV
			{
				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2FC0", VA = "0x180CF43C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public IEqualityComparer<a> CXRGVNSOHIH
			{
				[Cpp2IlInjected.Token(Token = "0x600015D")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0xCF1A10", Offset = "0xCF0610", VA = "0x180CF1A10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public bool JLIIVGUMTJC
			{
				[Cpp2IlInjected.Token(Token = "0x600015F")]
				[Cpp2IlInjected.Address(RVA = "0xE968E0", Offset = "0xE954E0", VA = "0x180E968E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x71C4D30", Offset = "0x71C3930", VA = "0x1871C4D30")]
			private AJULTQXDILE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x71C4240", Offset = "0x71C2E40", VA = "0x1871C4240")]
			public void SIFQFAPRLAF(BILDKLRZYOS<a> a, [Optional] IEqualityComparer<a> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x102F010", Offset = "0x102DC10", VA = "0x18102F010", Slot = "4")]
			public override void Clear()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private class MFUJGKSUHZX : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private readonly Preferences LNDCSVWIATM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private readonly object CDEYAHSIJZS;

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x9C51D00", Offset = "0x9C50900", VA = "0x189C51D00")]
			public MFUJGKSUHZX(Preferences a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x9C51CD0", Offset = "0x9C508D0", VA = "0x189C51CD0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private struct <InitializeForPlayerInternal>d__23 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Preferences <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public long playerAccountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x9C58270", Offset = "0x9C56E70", VA = "0x189C58270", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x9C58560", Offset = "0x9C57160", VA = "0x189C58560", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private struct <Save>d__77 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public Preferences <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public FWDDJKISYCY backingStoreToSave;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x9C58F10", Offset = "0x9C57B10", VA = "0x189C58F10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private struct <SaveImmediate>d__78 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public Preferences <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x9C585C0", Offset = "0x9C571C0", VA = "0x189C585C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x9C58A90", Offset = "0x9C57690", VA = "0x189C58A90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class UOZCEVSWGOL : IEnumerator<NVIJVYVFXPY>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private NVIJVYVFXPY PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public Preferences DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float UGBWVKUXDFX;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private NVIJVYVFXPY YPZFRLKUQEB
			{
				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public UOZCEVSWGOL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x9C59950", Offset = "0x9C58550", VA = "0x189C59950", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x9C59910", Offset = "0x9C58510", VA = "0x189C59910", Slot = "8")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly ZFDAPHSPYER DFSHVXVKOIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly ZFDAPHSPYER ZHYDBIGGKNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly OKZZSQTUEMJ WZFCGTGJTCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly EIGPTYHGYCM KWAEVTXZJMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly JBUYDEPBVXS.CustomSaveHandler DXFTFCGRJYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly SMMLEVHGFEC RSNORQBMWXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly HashSet<FWDDJKISYCY> LJHKDUJIZDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private Task QJIUXMQVARX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Dictionary<string, string> MWYWRXXCTAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private YDHSMJLFZLP HTKBCBETTUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly object ZGKJDVJZIDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly object IFTLVIGKAIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private long ZVCANGRGCNY;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private bool BLTVTAHLKDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x1A66180", Offset = "0x1A64D80", VA = "0x181A66180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private CancellationTokenSource NACYWWYCXOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xCEE120", Offset = "0xCECD20", VA = "0x180CEE120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xCEE170", Offset = "0xCECD70", VA = "0x180CEE170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action XRKISDBTAJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x9C53340", Offset = "0x9C51F40", VA = "0x189C53340", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x9C53130", Offset = "0x9C51D30", VA = "0x189C53130", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9C53670", Offset = "0x9C52270", VA = "0x189C53670")]
		[GEPWJNEAFDW.Root]
		internal static void KKBMLZYGTKX(VIGMLMXVCUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x9C55230", Offset = "0x9C53E30", VA = "0x189C55230")]
		[UnityEngine.Scripting.Preserve]
		public Preferences([Inject("Disk")] ZFDAPHSPYER localBackingStore, [Inject("Cloud")] ZFDAPHSPYER cloudBackingStore, [Inject(null)] OKZZSQTUEMJ editorBackingStore, [Inject(null)] EIGPTYHGYCM scheduler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9C52A90", Offset = "0x9C51690", VA = "0x189C52A90", Slot = "44")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9C545D0", Offset = "0x9C531D0", VA = "0x189C545D0")]
		private void TDBLUHKFZPW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9C54790", Offset = "0x9C53390", VA = "0x189C54790", Slot = "6")]
		public void UBYRWVAVOXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9C52F60", Offset = "0x9C51B60", VA = "0x189C52F60", Slot = "7")]
		public Task GBCTPUKMHXS(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9C533E0", Offset = "0x9C51FE0", VA = "0x189C533E0")]
		[AsyncStateMachine(typeof(<InitializeForPlayerInternal>d__23))]
		private Task IRHAIJQJJFL(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9C54940", Offset = "0x9C53540", VA = "0x189C54940")]
		private void UXABHOCEJDW(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9C54C40", Offset = "0x9C53840", VA = "0x189C54C40")]
		private void WXLFPPTREYJ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9C54E60", Offset = "0x9C53A60", VA = "0x189C54E60")]
		private string YFDXEUZBBTK(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9C52820", Offset = "0x9C51420", VA = "0x189C52820")]
		private void DRGRWMFHGCO(AccountPreferenceBackingStoreTypes a, string b, [Out] ZFDAPHSPYER c, [Out] string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9C52D70", Offset = "0x9C51970", VA = "0x189C52D70")]
		private ZFDAPHSPYER FSWCTLNOULM(AccountPreferenceBackingStoreTypes a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9C53F20", Offset = "0x9C52B20", VA = "0x189C53F20", Slot = "8")]
		public bool QLHKIWLUYDW(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9C53520", Offset = "0x9C52120", VA = "0x189C53520", Slot = "9")]
		public bool JLHTCBFCYUW(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9C53CE0", Offset = "0x9C528E0", VA = "0x189C53CE0", Slot = "10")]
		public bool NCLRDYKOUKR(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9C53230", Offset = "0x9C51E30", VA = "0x189C53230", Slot = "11")]
		public string ILAFEQKASKK(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9C536E0", Offset = "0x9C522E0", VA = "0x189C536E0", Slot = "12")]
		public SetResult LNFBOLAXHNU(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9C53E60", Offset = "0x9C52A60", VA = "0x189C53E60", Slot = "13")]
		public int NJOOZPZHNUY(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x9C54AD0", Offset = "0x9C536D0", VA = "0x189C54AD0", Slot = "14")]
		public SetResult WRYJMMZJDUU(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9C535C0", Offset = "0x9C521C0", VA = "0x189C535C0", Slot = "15")]
		public bool KAHGEFYOKQP(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9C53860", Offset = "0x9C52460", VA = "0x189C53860", Slot = "16")]
		public SetResult LSBTWOVNQUL(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9C539D0", Offset = "0x9C525D0", VA = "0x189C539D0", Slot = "17")]
		public float MKFVSXYVZMT(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9C550A0", Offset = "0x9C53CA0", VA = "0x189C550A0", Slot = "18")]
		public SetResult ZAQKSRDDFCL(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9C548A0", Offset = "0x9C534A0", VA = "0x189C548A0", Slot = "19")]
		public DateTime UPFBRKOZXFQ(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9C54CC0", Offset = "0x9C538C0", VA = "0x189C54CC0", Slot = "20")]
		public SetResult XMTOQFCOTVE(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9C54110", Offset = "0x9C52D10", VA = "0x189C54110", Slot = "21")]
		public long QSYOPTZLYGJ(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9C52490", Offset = "0x9C51090", VA = "0x189C52490", Slot = "22")]
		public SetResult ADCULKPXVNL(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x3DD4B70", Offset = "0x3DD3770", VA = "0x183DD4B70", Slot = "23")]
		public a JYTIGQBWZNS<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x3DD5240", Offset = "0x3DD3E40", VA = "0x183DD5240", Slot = "24")]
		public SetResult OXNHEWAMGZS<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9C527C0", Offset = "0x9C513C0", VA = "0x189C527C0", Slot = "25")]
		public bool BVSKIFANOTC(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x9C53F10", Offset = "0x9C52B10", VA = "0x189C53F10", Slot = "26")]
		public bool OKBBAVGFMZH(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9C54460", Offset = "0x9C53060", VA = "0x189C54460", Slot = "27")]
		public string SMCDNJOWTEE(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x9C544D0", Offset = "0x9C530D0", VA = "0x189C544D0", Slot = "28")]
		public SetResult SQZNZFNFZWU(string a, string b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9C532D0", Offset = "0x9C51ED0", VA = "0x189C532D0", Slot = "29")]
		public int IOTSQCRZYTI(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9C52F30", Offset = "0x9C51B30", VA = "0x189C52F30", Slot = "30")]
		public SetResult GAYHJOYWCFY(string a, int b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9C52D00", Offset = "0x9C51900", VA = "0x189C52D00", Slot = "31")]
		public bool FRHGLHQVNFP(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9C52B40", Offset = "0x9C51740", VA = "0x189C52B40", Slot = "32")]
		public SetResult EIVRXBDIQZX(string a, bool b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9C54800", Offset = "0x9C53400", VA = "0x189C54800", Slot = "33")]
		public float UDSAUUSGIOZ(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x9C54AA0", Offset = "0x9C536A0", VA = "0x189C54AA0", Slot = "34")]
		public SetResult VUSLVFTVXVT(string a, float b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9C52AD0", Offset = "0x9C516D0", VA = "0x189C52AD0", Slot = "35")]
		public DateTime EBYGQYKDLEU(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x9C54870", Offset = "0x9C53470", VA = "0x189C54870", Slot = "36")]
		public SetResult UKWCCRNPUNC(string a, DateTime b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x9C543F0", Offset = "0x9C52FF0", VA = "0x189C543F0", Slot = "37")]
		public long SIFWJINOHCT(string a, long b = 0L)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9C534F0", Offset = "0x9C520F0", VA = "0x189C534F0", Slot = "38")]
		public SetResult JCYHONYVQNF(string a, long b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9C531D0", Offset = "0x9C51DD0", VA = "0x189C531D0")]
		private bool GYDVJFQCIHK(FWDDJKISYCY a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9C52BA0", Offset = "0x9C517A0", VA = "0x189C52BA0")]
		private bool EPPCIVKZRFV(FWDDJKISYCY a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x9C542A0", Offset = "0x9C52EA0", VA = "0x189C542A0")]
		private SetResult SCVTJAYEAAR(FWDDJKISYCY a, string b, string c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x9C52680", Offset = "0x9C51280", VA = "0x189C52680")]
		private SetResult BNCXYCVGRYV(FWDDJKISYCY a, string b, int c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x9C53FD0", Offset = "0x9C52BD0", VA = "0x189C53FD0")]
		private SetResult QLTTPTVZXQE(FWDDJKISYCY a, string b, bool c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9C52DF0", Offset = "0x9C519F0", VA = "0x189C52DF0")]
		private SetResult FWFMSKVNZXY(FWDDJKISYCY a, string b, float c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x9C54620", Offset = "0x9C53220", VA = "0x189C54620")]
		private SetResult TRNAHHCRLUJ(FWDDJKISYCY a, string b, DateTime c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9C54960", Offset = "0x9C53560", VA = "0x189C54960")]
		private SetResult UYHFGPCGUKC(FWDDJKISYCY a, string b, long c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3DD4550", Offset = "0x3DD3150", VA = "0x183DD4550")]
		private e EIEXTZRXLVZ<e>(FWDDJKISYCY a, string b, e c)
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3DD3970", Offset = "0x3DD2570", VA = "0x183DD3970")]
		private SetResult DQGXREVJDQH<f>(FWDDJKISYCY a, string b, f c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3DD55A0", Offset = "0x3DD41A0", VA = "0x183DD55A0", Slot = "39")]
		public void XPXIDRBOXOK<g>(BILDKLRZYOS<g> a, [Optional] IEqualityComparer<g> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3DD5460", Offset = "0x3DD4060", VA = "0x183DD5460", Slot = "40")]
		public void XJBMXOWBEHH<h>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x9C54500", Offset = "0x9C53100", VA = "0x189C54500")]
		[AsyncStateMachine(typeof(<Save>d__77))]
		private void Save(FWDDJKISYCY backingStoreToSave)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x9C541B0", Offset = "0x9C52DB0", VA = "0x189C541B0", Slot = "43")]
		[AsyncStateMachine(typeof(<SaveImmediate>d__78))]
		public Task RPINLRKAUNA([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x9C54EC0", Offset = "0x9C53AC0", VA = "0x189C54EC0")]
		private void YSFFUJNMVRM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9C529C0", Offset = "0x9C515C0", VA = "0x189C529C0", Slot = "41")]
		public IDisposable DZEIWCNNNLY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9C55220", Offset = "0x9C53E20", VA = "0x189C55220", Slot = "42")]
		public void ZZDYWQWGVRH(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9C53A80", Offset = "0x9C52680", VA = "0x189C53A80")]
		private void MQEPSBJCPUB(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x9C52600", Offset = "0x9C51200", VA = "0x189C52600")]
		[IteratorStateMachine(typeof(UOZCEVSWGOL))]
		private IEnumerator<NVIJVYVFXPY> AHVTFFJRHHN(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9C52B70", Offset = "0x9C51770", VA = "0x189C52B70")]
		[CompilerGenerated]
		private void EJZUZFVLVCE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class WTJFSRGMPBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9C59DC0", Offset = "0x9C589C0", VA = "0x189C59DC0")]
		public static string IOZJRACKAHI(this LLJFKJJXSMP a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9C59C20", Offset = "0x9C58820", VA = "0x189C59C20")]
		public static byte[] IHZLKOZPYQW(this LLJFKJJXSMP a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9C59F30", Offset = "0x9C58B30", VA = "0x189C59F30")]
		public static SetResult ZFGXUFKPKIK(this LLJFKJJXSMP a, string b, ReadOnlySpan<byte> value)
		{
			return default(SetResult);
		}
	}
}
namespace RecRoom.Preferences.CustomParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class SXFKOKFITKU : NVNXNDGEDVG<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static SXFKOKFITKU UXEDIFVFAQD
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x9C57C10", Offset = "0x9C56810", VA = "0x189C57C10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9C57C60", Offset = "0x9C56860", VA = "0x189C57C60", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9C57D50", Offset = "0x9C56950", VA = "0x189C57D50", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9C58060", Offset = "0x9C56C60", VA = "0x189C58060")]
		public SXFKOKFITKU()
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
