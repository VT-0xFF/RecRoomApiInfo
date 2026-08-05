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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C50300", Offset = "0x9C4ED00", VA = "0x189C50300")]
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
		[Cpp2IlInjected.Address(RVA = "0xD19850", Offset = "0xD18250", VA = "0x180D19850")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C50120", Offset = "0x9C4EB20", VA = "0x189C50120", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C58590", Offset = "0x9C56F90", VA = "0x189C58590", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x29F6EF0", Offset = "0x29F58F0", VA = "0x1829F6EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C4CCE0", Offset = "0x9C4B6E0", VA = "0x189C4CCE0")]
		private static void HAHSIKQFJUP(FWDDJKISYCY a, CustomSaveHandler b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9C4CFE0", Offset = "0x9C4B9E0", VA = "0x189C4CFE0")]
		public static bool LOQJIKUUIYF(this FWDDJKISYCY a, string b, [Optional] CustomSaveHandler c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9C4CA40", Offset = "0x9C4B440", VA = "0x189C4CA40")]
		public static SetResult DQUASEVGJQY(this FWDDJKISYCY a, string b, string c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9C4D140", Offset = "0x9C4BB40", VA = "0x189C4D140")]
		public static SetResult TTQPDBMXDYA(this FWDDJKISYCY a, string b, int c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9C4CEA0", Offset = "0x9C4B8A0", VA = "0x189C4CEA0")]
		public static SetResult KWNWBJAWSZP(this FWDDJKISYCY a, string b, bool c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9C4CB90", Offset = "0x9C4B590", VA = "0x189C4CB90")]
		public static SetResult DVSHGBDNWMX(this FWDDJKISYCY a, string b, float c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9C4D280", Offset = "0x9C4BC80", VA = "0x189C4D280")]
		public static SetResult XKPLZKNFTNS(this FWDDJKISYCY a, string b, DateTime c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9C4CD60", Offset = "0x9C4B760", VA = "0x189C4CD60")]
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
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD085A0", VA = "0x180D09BA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Dictionary<string, string> MNOCALOZIOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9C53B10", Offset = "0x9C52510", VA = "0x189C53B10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action XRKISDBTAJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9C56010", Offset = "0x9C54A10", VA = "0x189C56010")]
		[UnityEngine.Scripting.Preserve]
		public SDYIORZXWBT([Inject(null)] HPYGNHKGIYE unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "8")]
		public void UBYRWVAVOXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9C55840", Offset = "0x9C54240", VA = "0x189C55840")]
		private DirectoryInfo RUVOVUJNGRC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9C548A0", Offset = "0x9C532A0", VA = "0x189C548A0", Slot = "6")]
		public Task OROICLDNWEA(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9C53B50", Offset = "0x9C52550", VA = "0x189C53B50", Slot = "14")]
		public float BICZAKOTTES(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9C547C0", Offset = "0x9C531C0", VA = "0x189C547C0", Slot = "13")]
		public void MVYOWXFBYQY(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9C53FD0", Offset = "0x9C529D0", VA = "0x189C53FD0", Slot = "12")]
		public bool LMYOCXVGACQ(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9C55D50", Offset = "0x9C54750", VA = "0x189C55D50", Slot = "10")]
		public int XFGLJJICOSJ(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F30", Offset = "0x9C54930", VA = "0x189C55F30", Slot = "18")]
		public DateTime ZQTOGBOWEVP(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9C557D0", Offset = "0x9C541D0", VA = "0x189C557D0", Slot = "19")]
		public void RMLSZBSDALP(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9C54830", Offset = "0x9C53230", VA = "0x189C54830", Slot = "15")]
		public void NGBXFFZTZDQ(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9C55C70", Offset = "0x9C54670", VA = "0x189C55C70", Slot = "11")]
		public void UOLRMCBBXKJ(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9C55CE0", Offset = "0x9C546E0", VA = "0x189C55CE0", Slot = "20")]
		public long VACXPISJHOK(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9C556B0", Offset = "0x9C540B0", VA = "0x189C556B0", Slot = "21")]
		public void PCZCIJFSIAO(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3F012C0", Offset = "0x3EFFCC0", VA = "0x183F012C0", Slot = "22")]
		public a XAZIOXTNTPF<a>(string a, a b, BILDKLRZYOS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3EFE3B0", Offset = "0x3EFCDB0", VA = "0x183EFE3B0", Slot = "23")]
		public void AYGFZABJFXR<b>(string a, b b, BILDKLRZYOS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9C55720", Offset = "0x9C54120", VA = "0x189C55720", Slot = "16")]
		public string QGOSMAICKCR(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9C540A0", Offset = "0x9C52AA0", VA = "0x189C540A0", Slot = "17")]
		public void LSGQKGXBITT(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9C55DC0", Offset = "0x9C547C0", VA = "0x189C55DC0", Slot = "24")]
		public void YXHJXTPLZOK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9C53D20", Offset = "0x9C52720", VA = "0x189C53D20", Slot = "9")]
		public bool KDMDMFGWMYX(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9C55930", Offset = "0x9C54330", VA = "0x189C55930", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9C54110", Offset = "0x9C52B10", VA = "0x189C54110")]
		private void MHUZKQVUBVE(DirectoryInfo a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9C53DB0", Offset = "0x9C527B0", VA = "0x189C53DB0")]
		private static string LHAEHSQOMNF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9C53C20", Offset = "0x9C52620", VA = "0x189C53C20")]
		private static string FXLGVDTHUKA(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3EFE550", Offset = "0x3EFCF50", VA = "0x183EFE550")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] BILDKLRZYOS<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3EFFD40", Offset = "0x3EFE740", VA = "0x183EFFD40")]
		private void Set<T>(string propertyName, T value, [Optional] BILDKLRZYOS<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9C54930", Offset = "0x9C53330", VA = "0x189C54930")]
		private Dictionary<string, string> PCFYDYHEZKG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9C53BC0", Offset = "0x9C525C0", VA = "0x189C53BC0")]
		private void DJQPSCLEWQG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9C54750", Offset = "0x9C53150", VA = "0x189C54750")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C57F30", Offset = "0x9C56930", VA = "0x189C57F30")]
		[GEPWJNEAFDW.Root]
		internal static void GEPWJNEAFDW(VIGMLMXVCUS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class EQDAPTMPDRU : ORGZOGVYTFB
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9C4C9C0", Offset = "0x9C4B3C0", VA = "0x189C4C9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD085A0", VA = "0x180D09BA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action XRKISDBTAJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9C4B990", Offset = "0x9C4A390", VA = "0x189C4B990")]
		[UnityEngine.Scripting.Preserve]
		public CJWDCSUVBTO([Inject(null)] HPYGNHKGIYE unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9C4B4C0", Offset = "0x9C49EC0", VA = "0x189C4B4C0", Slot = "6")]
		public Task OROICLDNWEA(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "8")]
		public void UBYRWVAVOXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9C4B2A0", Offset = "0x9C49CA0", VA = "0x189C4B2A0", Slot = "9")]
		public bool KDMDMFGWMYX(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9C4B820", Offset = "0x9C4A220", VA = "0x189C4B820", Slot = "10")]
		public int XFGLJJICOSJ(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9C4B740", Offset = "0x9C4A140", VA = "0x189C4B740", Slot = "11")]
		public void UOLRMCBBXKJ(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9C4B300", Offset = "0x9C49D00", VA = "0x189C4B300", Slot = "12")]
		public bool LMYOCXVGACQ(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9C4B3E0", Offset = "0x9C49DE0", VA = "0x189C4B3E0", Slot = "13")]
		public void MVYOWXFBYQY(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9C4B230", Offset = "0x9C49C30", VA = "0x189C4B230", Slot = "14")]
		public float BICZAKOTTES(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9C4B450", Offset = "0x9C49E50", VA = "0x189C4B450", Slot = "15")]
		public void NGBXFFZTZDQ(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9C4B5C0", Offset = "0x9C49FC0", VA = "0x189C4B5C0", Slot = "16")]
		public string QGOSMAICKCR(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9C4B370", Offset = "0x9C49D70", VA = "0x189C4B370", Slot = "17")]
		public void LSGQKGXBITT(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9C4B920", Offset = "0x9C4A320", VA = "0x189C4B920", Slot = "18")]
		public DateTime ZQTOGBOWEVP(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9C4B640", Offset = "0x9C4A040", VA = "0x189C4B640", Slot = "19")]
		public void RMLSZBSDALP(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9C4B7B0", Offset = "0x9C4A1B0", VA = "0x189C4B7B0", Slot = "20")]
		public long VACXPISJHOK(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9C4B550", Offset = "0x9C49F50", VA = "0x189C4B550", Slot = "21")]
		public void PCZCIJFSIAO(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x37DFBB0", Offset = "0x37DE5B0", VA = "0x1837DFBB0", Slot = "22")]
		public a XAZIOXTNTPF<a>(string a, a b, BILDKLRZYOS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x37DD0D0", Offset = "0x37DBAD0", VA = "0x1837DD0D0", Slot = "23")]
		public void AYGFZABJFXR<b>(string a, b b, BILDKLRZYOS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9C4B890", Offset = "0x9C4A290", VA = "0x189C4B890", Slot = "24")]
		public void YXHJXTPLZOK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9C4B6B0", Offset = "0x9C4A0B0", VA = "0x189C4B6B0", Slot = "25")]
		public Task Save([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x37DD270", Offset = "0x37DBC70", VA = "0x1837DD270")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] BILDKLRZYOS<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x37DEA60", Offset = "0x37DD460", VA = "0x1837DEA60")]
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
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD085A0", VA = "0x180D09BA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action XRKISDBTAJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "8")]
		public void UBYRWVAVOXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9C505C0", Offset = "0x9C4EFC0", VA = "0x189C505C0", Slot = "6")]
		public Task OROICLDNWEA(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9C503E0", Offset = "0x9C4EDE0", VA = "0x189C503E0", Slot = "9")]
		public bool KDMDMFGWMYX(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9C508C0", Offset = "0x9C4F2C0", VA = "0x189C508C0", Slot = "10")]
		public int XFGLJJICOSJ(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9C50800", Offset = "0x9C4F200", VA = "0x189C50800", Slot = "11")]
		public void UOLRMCBBXKJ(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9C50440", Offset = "0x9C4EE40", VA = "0x189C50440", Slot = "12")]
		public bool LMYOCXVGACQ(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9C50500", Offset = "0x9C4EF00", VA = "0x189C50500", Slot = "13")]
		public void MVYOWXFBYQY(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9C50380", Offset = "0x9C4ED80", VA = "0x189C50380", Slot = "14")]
		public float BICZAKOTTES(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9C50560", Offset = "0x9C4EF60", VA = "0x189C50560", Slot = "15")]
		public void NGBXFFZTZDQ(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9C506B0", Offset = "0x9C4F0B0", VA = "0x189C506B0", Slot = "16")]
		public string QGOSMAICKCR(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9C504A0", Offset = "0x9C4EEA0", VA = "0x189C504A0", Slot = "17")]
		public void LSGQKGXBITT(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9C50980", Offset = "0x9C4F380", VA = "0x189C50980", Slot = "18")]
		public DateTime ZQTOGBOWEVP(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9C50710", Offset = "0x9C4F110", VA = "0x189C50710", Slot = "19")]
		public void RMLSZBSDALP(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9C50860", Offset = "0x9C4F260", VA = "0x189C50860", Slot = "20")]
		public long VACXPISJHOK(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9C50650", Offset = "0x9C4F050", VA = "0x189C50650", Slot = "21")]
		public void PCZCIJFSIAO(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3D886C0", Offset = "0x3D870C0", VA = "0x183D886C0", Slot = "22")]
		public a XAZIOXTNTPF<a>(string a, a b, BILDKLRZYOS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x3D87360", Offset = "0x3D85D60", VA = "0x183D87360", Slot = "23")]
		public void AYGFZABJFXR<b>(string a, b b, BILDKLRZYOS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3D87560", Offset = "0x3D85F60", VA = "0x183D87560")]
		public T Get<T>(string propertyName, T defaultValue)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3D87FF0", Offset = "0x3D869F0", VA = "0x183D87FF0")]
		public void Set<T>(string propertyName, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9C50920", Offset = "0x9C4F320", VA = "0x189C50920", Slot = "24")]
		public void YXHJXTPLZOK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9C50770", Offset = "0x9C4F170", VA = "0x189C50770", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9C4C9C0", Offset = "0x9C4B3C0", VA = "0x189C4C9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A89660", Offset = "0x7A88060", VA = "0x187A89660")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A891B0", Offset = "0x7A87BB0", VA = "0x187A891B0")]
		public static void QMAPDNOOLBO(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7A88A60", Offset = "0x7A87460", VA = "0x187A88A60")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A885A0", Offset = "0x7A86FA0", VA = "0x187A885A0")]
		public bool XXTFUCBFMWE(string a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7A88360", Offset = "0x7A86D60", VA = "0x187A88360")]
		public void Store(string cacheKey, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310")]
		public IEnumerable<KeyValuePair<string, b>> IXJYSGURNKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x766F090", Offset = "0x766DA90", VA = "0x18766F090", Slot = "4")]
		protected override void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7A88100", Offset = "0x7A86B00", VA = "0x187A88100", Slot = "5")]
		protected override void GXLNJFYYQBM(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7A888E0", Offset = "0x7A872E0", VA = "0x187A888E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C57040", Offset = "0x9C55A40", VA = "0x189C57040", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x9C57400", Offset = "0x9C55E00", VA = "0x189C57400", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8BC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public DKNLFUMVHSF(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x9C4BA70", Offset = "0x9C4A470", VA = "0x189C4BA70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x9C4BA30", Offset = "0x9C4A430", VA = "0x189C4BA30", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD085A0", VA = "0x180D09BA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action XRKISDBTAJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9C50020", Offset = "0x9C4EA20", VA = "0x189C50020")]
		[UnityEngine.Scripting.Preserve]
		public LQVCURLRAAP([Inject(null)] HPYGNHKGIYE unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "8")]
		public void UBYRWVAVOXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9C4DAA0", Offset = "0x9C4C4A0", VA = "0x189C4DAA0", Slot = "6")]
		public Task OROICLDNWEA(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1E8D010", Offset = "0x1E8BA10", VA = "0x181E8D010")]
		private static int EZPKYWBBFLQ(bool a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9C4D5F0", Offset = "0x9C4BFF0", VA = "0x189C4D5F0", Slot = "9")]
		public bool KDMDMFGWMYX(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9C4FC50", Offset = "0x9C4E650", VA = "0x189C4FC50", Slot = "10")]
		public int XFGLJJICOSJ(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9C4FAB0", Offset = "0x9C4E4B0", VA = "0x189C4FAB0", Slot = "11")]
		public void UOLRMCBBXKJ(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9C4D610", Offset = "0x9C4C010", VA = "0x189C4D610", Slot = "12")]
		public bool LMYOCXVGACQ(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9C4D900", Offset = "0x9C4C300", VA = "0x189C4D900", Slot = "13")]
		public void MVYOWXFBYQY(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9C4D3F0", Offset = "0x9C4BDF0", VA = "0x189C4D3F0", Slot = "14")]
		public float BICZAKOTTES(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9C4D9E0", Offset = "0x9C4C3E0", VA = "0x189C4D9E0", Slot = "15")]
		public void NGBXFFZTZDQ(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9C4FF40", Offset = "0x9C4E940", VA = "0x189C4FF40", Slot = "18")]
		public DateTime ZQTOGBOWEVP(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9C4DF00", Offset = "0x9C4C900", VA = "0x189C4DF00", Slot = "19")]
		public void RMLSZBSDALP(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9C4FB70", Offset = "0x9C4E570", VA = "0x189C4FB70", Slot = "20")]
		public long VACXPISJHOK(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9C4DB30", Offset = "0x9C4C530", VA = "0x189C4DB30", Slot = "21")]
		public void PCZCIJFSIAO(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3BEF720", Offset = "0x3BEE120", VA = "0x183BEF720", Slot = "22")]
		public a XAZIOXTNTPF<a>(string a, a b, BILDKLRZYOS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3BEE8E0", Offset = "0x3BED2E0", VA = "0x183BEE8E0", Slot = "23")]
		public void AYGFZABJFXR<b>(string a, b b, BILDKLRZYOS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3BEF920", Offset = "0x3BEE320", VA = "0x183BEF920")]
		private c ZGENTANSZVU<c>(string a, c b, [Optional] BILDKLRZYOS<c> c)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3BEEAA0", Offset = "0x3BED4A0", VA = "0x183BEEAA0")]
		private void FCGKPNQRPEC<d>(string a, d b, [Optional] BILDKLRZYOS<d> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9C4DBA0", Offset = "0x9C4C5A0", VA = "0x189C4DBA0", Slot = "16")]
		public string QGOSMAICKCR(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9C4D760", Offset = "0x9C4C160", VA = "0x189C4D760", Slot = "17")]
		public void LSGQKGXBITT(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9C4FD80", Offset = "0x9C4E780", VA = "0x189C4FD80")]
		private void YEMIURUMHWE(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9C4DD50", Offset = "0x9C4C750", VA = "0x189C4DD50")]
		private string RKRMRLIRNBC(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9C4FEB0", Offset = "0x9C4E8B0", VA = "0x189C4FEB0", Slot = "24")]
		public void YXHJXTPLZOK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9C4FA10", Offset = "0x9C4E410", VA = "0x189C4FA10")]
		private string UKOLEHHHOUO(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9C4DFD0", Offset = "0x9C4C9D0", VA = "0x189C4DFD0")]
		public void SHVISIUNHZT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9C4D590", Offset = "0x9C4BF90", VA = "0x189C4D590", Slot = "26")]
		public void GFGFUMRQURE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9C4F920", Offset = "0x9C4E320", VA = "0x189C4F920", Slot = "25")]
		[AsyncStateMachine(typeof(<Save>d__40))]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9C4FBE0", Offset = "0x9C4E5E0", VA = "0x189C4FBE0")]
		[IteratorStateMachine(typeof(DKNLFUMVHSF))]
		private IEnumerator<NVIJVYVFXPY> XAZORADDEIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9C4DF70", Offset = "0x9C4C970", VA = "0x189C4DF70")]
		private void RPINLRKAUNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9C4D520", Offset = "0x9C4BF20", VA = "0x189C4D520")]
		private void DJQPSCLEWQG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9C4D890", Offset = "0x9C4C290", VA = "0x189C4D890")]
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
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD085A0", VA = "0x180D09BA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private string HGXJPZZGYPB
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x9C4BC20", Offset = "0x9C4A620", VA = "0x189C4BC20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private string LEIDNZQQNOB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x9C4BB90", Offset = "0x9C4A590", VA = "0x189C4BB90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Dictionary<string, string> MNOCALOZIOG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x9C4BAE0", Offset = "0x9C4A4E0", VA = "0x189C4BAE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action XRKISDBTAJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		[UnityEngine.Scripting.Preserve]
		public EERKMDWMGNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "8")]
		public void UBYRWVAVOXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9C4BF90", Offset = "0x9C4A990", VA = "0x189C4BF90", Slot = "6")]
		public Task OROICLDNWEA(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9C4BB20", Offset = "0x9C4A520", VA = "0x189C4BB20", Slot = "14")]
		public float BICZAKOTTES(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9C4BEB0", Offset = "0x9C4A8B0", VA = "0x189C4BEB0", Slot = "13")]
		public void MVYOWXFBYQY(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9C4BD40", Offset = "0x9C4A740", VA = "0x189C4BD40", Slot = "12")]
		public bool LMYOCXVGACQ(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9C4C820", Offset = "0x9C4B220", VA = "0x189C4C820", Slot = "10")]
		public int XFGLJJICOSJ(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9C4C950", Offset = "0x9C4B350", VA = "0x189C4C950", Slot = "18")]
		public DateTime ZQTOGBOWEVP(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9C4C470", Offset = "0x9C4AE70", VA = "0x189C4C470", Slot = "19")]
		public void RMLSZBSDALP(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9C4BF20", Offset = "0x9C4A920", VA = "0x189C4BF20", Slot = "15")]
		public void NGBXFFZTZDQ(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9C4C740", Offset = "0x9C4B140", VA = "0x189C4C740", Slot = "11")]
		public void UOLRMCBBXKJ(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9C4C7B0", Offset = "0x9C4B1B0", VA = "0x189C4C7B0", Slot = "20")]
		public long VACXPISJHOK(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9C4C350", Offset = "0x9C4AD50", VA = "0x189C4C350", Slot = "21")]
		public void PCZCIJFSIAO(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x392D510", Offset = "0x392BF10", VA = "0x18392D510", Slot = "22")]
		public a XAZIOXTNTPF<a>(string a, a b, BILDKLRZYOS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x392A9A0", Offset = "0x39293A0", VA = "0x18392A9A0", Slot = "23")]
		public void AYGFZABJFXR<b>(string a, b b, BILDKLRZYOS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9C4C3C0", Offset = "0x9C4ADC0", VA = "0x189C4C3C0", Slot = "16")]
		public string QGOSMAICKCR(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9C4BE10", Offset = "0x9C4A810", VA = "0x189C4BE10", Slot = "17")]
		public void LSGQKGXBITT(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9C4C890", Offset = "0x9C4B290", VA = "0x189C4C890", Slot = "24")]
		public void YXHJXTPLZOK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9C4BCB0", Offset = "0x9C4A6B0", VA = "0x189C4BCB0", Slot = "9")]
		public bool KDMDMFGWMYX(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9C4C4E0", Offset = "0x9C4AEE0", VA = "0x189C4C4E0", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x392AB40", Offset = "0x3929540", VA = "0x18392AB40")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] BILDKLRZYOS<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x392C330", Offset = "0x392AD30", VA = "0x18392C330")]
		private void Set<T>(string propertyName, T value, [Optional] BILDKLRZYOS<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9C4C020", Offset = "0x9C4AA20", VA = "0x189C4C020")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C565F0", Offset = "0x9C54FF0", VA = "0x189C565F0")]
			public static void IEEYZUXTILW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract void Clear();

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2DC0", VA = "0x180CF43C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public IEqualityComparer<a> CXRGVNSOHIH
			{
				[Cpp2IlInjected.Token(Token = "0x600015D")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0xCF1A10", Offset = "0xCF0410", VA = "0x180CF1A10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public bool JLIIVGUMTJC
			{
				[Cpp2IlInjected.Token(Token = "0x600015F")]
				[Cpp2IlInjected.Address(RVA = "0xE968E0", Offset = "0xE952E0", VA = "0x180E968E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x71C35B0", Offset = "0x71C1FB0", VA = "0x1871C35B0")]
			private AJULTQXDILE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x71C2AC0", Offset = "0x71C14C0", VA = "0x1871C2AC0")]
			public void SIFQFAPRLAF(BILDKLRZYOS<a> a, [Optional] IEqualityComparer<a> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x102F010", Offset = "0x102DA10", VA = "0x18102F010", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C50250", Offset = "0x9C4EC50", VA = "0x189C50250")]
			public MFUJGKSUHZX(Preferences a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x9C50220", Offset = "0x9C4EC20", VA = "0x189C50220", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C567C0", Offset = "0x9C551C0", VA = "0x189C567C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x9C56AB0", Offset = "0x9C554B0", VA = "0x189C56AB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C57460", Offset = "0x9C55E60", VA = "0x189C57460", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51630", VA = "0x180D52C30", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C56B10", Offset = "0x9C55510", VA = "0x189C56B10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x9C56FE0", Offset = "0x9C559E0", VA = "0x189C56FE0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8BC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public UOZCEVSWGOL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x9C57EA0", Offset = "0x9C568A0", VA = "0x189C57EA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x9C57E60", Offset = "0x9C56860", VA = "0x189C57E60", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x1A648E0", Offset = "0x1A632E0", VA = "0x181A648E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private CancellationTokenSource NACYWWYCXOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xCEE120", Offset = "0xCECB20", VA = "0x180CEE120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xCEE170", Offset = "0xCECB70", VA = "0x180CEE170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action XRKISDBTAJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x9C51890", Offset = "0x9C50290", VA = "0x189C51890", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x9C51680", Offset = "0x9C50080", VA = "0x189C51680", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9C51BC0", Offset = "0x9C505C0", VA = "0x189C51BC0")]
		[GEPWJNEAFDW.Root]
		internal static void KKBMLZYGTKX(VIGMLMXVCUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x9C53780", Offset = "0x9C52180", VA = "0x189C53780")]
		[UnityEngine.Scripting.Preserve]
		public Preferences([Inject("Disk")] ZFDAPHSPYER localBackingStore, [Inject("Cloud")] ZFDAPHSPYER cloudBackingStore, [Inject(null)] OKZZSQTUEMJ editorBackingStore, [Inject(null)] EIGPTYHGYCM scheduler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9C50FE0", Offset = "0x9C4F9E0", VA = "0x189C50FE0", Slot = "44")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9C52B20", Offset = "0x9C51520", VA = "0x189C52B20")]
		private void TDBLUHKFZPW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9C52CE0", Offset = "0x9C516E0", VA = "0x189C52CE0", Slot = "6")]
		public void UBYRWVAVOXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9C514B0", Offset = "0x9C4FEB0", VA = "0x189C514B0", Slot = "7")]
		public Task GBCTPUKMHXS(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9C51930", Offset = "0x9C50330", VA = "0x189C51930")]
		[AsyncStateMachine(typeof(<InitializeForPlayerInternal>d__23))]
		private Task IRHAIJQJJFL(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9C52E90", Offset = "0x9C51890", VA = "0x189C52E90")]
		private void UXABHOCEJDW(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9C53190", Offset = "0x9C51B90", VA = "0x189C53190")]
		private void WXLFPPTREYJ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9C533B0", Offset = "0x9C51DB0", VA = "0x189C533B0")]
		private string YFDXEUZBBTK(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9C50D70", Offset = "0x9C4F770", VA = "0x189C50D70")]
		private void DRGRWMFHGCO(AccountPreferenceBackingStoreTypes a, string b, [Out] ZFDAPHSPYER c, [Out] string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9C512C0", Offset = "0x9C4FCC0", VA = "0x189C512C0")]
		private ZFDAPHSPYER FSWCTLNOULM(AccountPreferenceBackingStoreTypes a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9C52470", Offset = "0x9C50E70", VA = "0x189C52470", Slot = "8")]
		public bool QLHKIWLUYDW(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9C51A70", Offset = "0x9C50470", VA = "0x189C51A70", Slot = "9")]
		public bool JLHTCBFCYUW(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9C52230", Offset = "0x9C50C30", VA = "0x189C52230", Slot = "10")]
		public bool NCLRDYKOUKR(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9C51780", Offset = "0x9C50180", VA = "0x189C51780", Slot = "11")]
		public string ILAFEQKASKK(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9C51C30", Offset = "0x9C50630", VA = "0x189C51C30", Slot = "12")]
		public SetResult LNFBOLAXHNU(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9C523B0", Offset = "0x9C50DB0", VA = "0x189C523B0", Slot = "13")]
		public int NJOOZPZHNUY(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x9C53020", Offset = "0x9C51A20", VA = "0x189C53020", Slot = "14")]
		public SetResult WRYJMMZJDUU(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9C51B10", Offset = "0x9C50510", VA = "0x189C51B10", Slot = "15")]
		public bool KAHGEFYOKQP(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9C51DB0", Offset = "0x9C507B0", VA = "0x189C51DB0", Slot = "16")]
		public SetResult LSBTWOVNQUL(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9C51F20", Offset = "0x9C50920", VA = "0x189C51F20", Slot = "17")]
		public float MKFVSXYVZMT(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9C535F0", Offset = "0x9C51FF0", VA = "0x189C535F0", Slot = "18")]
		public SetResult ZAQKSRDDFCL(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9C52DF0", Offset = "0x9C517F0", VA = "0x189C52DF0", Slot = "19")]
		public DateTime UPFBRKOZXFQ(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9C53210", Offset = "0x9C51C10", VA = "0x189C53210", Slot = "20")]
		public SetResult XMTOQFCOTVE(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9C52660", Offset = "0x9C51060", VA = "0x189C52660", Slot = "21")]
		public long QSYOPTZLYGJ(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9C509E0", Offset = "0x9C4F3E0", VA = "0x189C509E0", Slot = "22")]
		public SetResult ADCULKPXVNL(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x3DD3480", Offset = "0x3DD1E80", VA = "0x183DD3480", Slot = "23")]
		public a JYTIGQBWZNS<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x3DD3B50", Offset = "0x3DD2550", VA = "0x183DD3B50", Slot = "24")]
		public SetResult OXNHEWAMGZS<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9C50D10", Offset = "0x9C4F710", VA = "0x189C50D10", Slot = "25")]
		public bool BVSKIFANOTC(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x9C52460", Offset = "0x9C50E60", VA = "0x189C52460", Slot = "26")]
		public bool OKBBAVGFMZH(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9C529B0", Offset = "0x9C513B0", VA = "0x189C529B0", Slot = "27")]
		public string SMCDNJOWTEE(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x9C52A20", Offset = "0x9C51420", VA = "0x189C52A20", Slot = "28")]
		public SetResult SQZNZFNFZWU(string a, string b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9C51820", Offset = "0x9C50220", VA = "0x189C51820", Slot = "29")]
		public int IOTSQCRZYTI(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9C51480", Offset = "0x9C4FE80", VA = "0x189C51480", Slot = "30")]
		public SetResult GAYHJOYWCFY(string a, int b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9C51250", Offset = "0x9C4FC50", VA = "0x189C51250", Slot = "31")]
		public bool FRHGLHQVNFP(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9C51090", Offset = "0x9C4FA90", VA = "0x189C51090", Slot = "32")]
		public SetResult EIVRXBDIQZX(string a, bool b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9C52D50", Offset = "0x9C51750", VA = "0x189C52D50", Slot = "33")]
		public float UDSAUUSGIOZ(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x9C52FF0", Offset = "0x9C519F0", VA = "0x189C52FF0", Slot = "34")]
		public SetResult VUSLVFTVXVT(string a, float b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9C51020", Offset = "0x9C4FA20", VA = "0x189C51020", Slot = "35")]
		public DateTime EBYGQYKDLEU(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x9C52DC0", Offset = "0x9C517C0", VA = "0x189C52DC0", Slot = "36")]
		public SetResult UKWCCRNPUNC(string a, DateTime b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x9C52940", Offset = "0x9C51340", VA = "0x189C52940", Slot = "37")]
		public long SIFWJINOHCT(string a, long b = 0L)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9C51A40", Offset = "0x9C50440", VA = "0x189C51A40", Slot = "38")]
		public SetResult JCYHONYVQNF(string a, long b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9C51720", Offset = "0x9C50120", VA = "0x189C51720")]
		private bool GYDVJFQCIHK(FWDDJKISYCY a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9C510F0", Offset = "0x9C4FAF0", VA = "0x189C510F0")]
		private bool EPPCIVKZRFV(FWDDJKISYCY a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x9C527F0", Offset = "0x9C511F0", VA = "0x189C527F0")]
		private SetResult SCVTJAYEAAR(FWDDJKISYCY a, string b, string c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x9C50BD0", Offset = "0x9C4F5D0", VA = "0x189C50BD0")]
		private SetResult BNCXYCVGRYV(FWDDJKISYCY a, string b, int c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x9C52520", Offset = "0x9C50F20", VA = "0x189C52520")]
		private SetResult QLTTPTVZXQE(FWDDJKISYCY a, string b, bool c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9C51340", Offset = "0x9C4FD40", VA = "0x189C51340")]
		private SetResult FWFMSKVNZXY(FWDDJKISYCY a, string b, float c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x9C52B70", Offset = "0x9C51570", VA = "0x189C52B70")]
		private SetResult TRNAHHCRLUJ(FWDDJKISYCY a, string b, DateTime c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9C52EB0", Offset = "0x9C518B0", VA = "0x189C52EB0")]
		private SetResult UYHFGPCGUKC(FWDDJKISYCY a, string b, long c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3DD2E60", Offset = "0x3DD1860", VA = "0x183DD2E60")]
		private e EIEXTZRXLVZ<e>(FWDDJKISYCY a, string b, e c)
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3DD2280", Offset = "0x3DD0C80", VA = "0x183DD2280")]
		private SetResult DQGXREVJDQH<f>(FWDDJKISYCY a, string b, f c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3DD3EB0", Offset = "0x3DD28B0", VA = "0x183DD3EB0", Slot = "39")]
		public void XPXIDRBOXOK<g>(BILDKLRZYOS<g> a, [Optional] IEqualityComparer<g> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3DD3D70", Offset = "0x3DD2770", VA = "0x183DD3D70", Slot = "40")]
		public void XJBMXOWBEHH<h>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x9C52A50", Offset = "0x9C51450", VA = "0x189C52A50")]
		[AsyncStateMachine(typeof(<Save>d__77))]
		private void Save(FWDDJKISYCY backingStoreToSave)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x9C52700", Offset = "0x9C51100", VA = "0x189C52700", Slot = "43")]
		[AsyncStateMachine(typeof(<SaveImmediate>d__78))]
		public Task RPINLRKAUNA([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x9C53410", Offset = "0x9C51E10", VA = "0x189C53410")]
		private void YSFFUJNMVRM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9C50F10", Offset = "0x9C4F910", VA = "0x189C50F10", Slot = "41")]
		public IDisposable DZEIWCNNNLY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9C53770", Offset = "0x9C52170", VA = "0x189C53770", Slot = "42")]
		public void ZZDYWQWGVRH(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9C51FD0", Offset = "0x9C509D0", VA = "0x189C51FD0")]
		private void MQEPSBJCPUB(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x9C50B50", Offset = "0x9C4F550", VA = "0x189C50B50")]
		[IteratorStateMachine(typeof(UOZCEVSWGOL))]
		private IEnumerator<NVIJVYVFXPY> AHVTFFJRHHN(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9C510C0", Offset = "0x9C4FAC0", VA = "0x189C510C0")]
		[CompilerGenerated]
		private void EJZUZFVLVCE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class WTJFSRGMPBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9C58310", Offset = "0x9C56D10", VA = "0x189C58310")]
		public static string IOZJRACKAHI(this LLJFKJJXSMP a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9C58170", Offset = "0x9C56B70", VA = "0x189C58170")]
		public static byte[] IHZLKOZPYQW(this LLJFKJJXSMP a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9C58480", Offset = "0x9C56E80", VA = "0x189C58480")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C56160", Offset = "0x9C54B60", VA = "0x189C56160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9C561B0", Offset = "0x9C54BB0", VA = "0x189C561B0", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9C562A0", Offset = "0x9C54CA0", VA = "0x189C562A0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9C565B0", Offset = "0x9C54FB0", VA = "0x189C565B0")]
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
