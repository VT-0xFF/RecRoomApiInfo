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
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B19AA0", Offset = "0x8B18AA0", VA = "0x188B19AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF8980", Offset = "0xAF7980", VA = "0x180AF8980")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B209C0", Offset = "0x8B1F9C0", VA = "0x188B209C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x29F5B20", Offset = "0x29F4B20", VA = "0x1829F5B20")]
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
	internal static class BTTYIJCLTMZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		internal delegate void CustomSaveHandler(LXQAJKDVVNB backingStore);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8B179E0", Offset = "0x8B169E0", VA = "0x188B179E0")]
		private static void IDJAXJDYXLQ(LXQAJKDVVNB a, CustomSaveHandler b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8B17BA0", Offset = "0x8B16BA0", VA = "0x188B17BA0")]
		public static bool QAWTMYYDKWQ(this LXQAJKDVVNB a, string b, [Optional] CustomSaveHandler c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8B17890", Offset = "0x8B16890", VA = "0x188B17890")]
		public static SetResult HLFOZELDDLF(this LXQAJKDVVNB a, string b, string c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8B17E40", Offset = "0x8B16E40", VA = "0x188B17E40")]
		public static SetResult XUWCPJFQXVL(this LXQAJKDVVNB a, string b, int c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8B17A60", Offset = "0x8B16A60", VA = "0x188B17A60")]
		public static SetResult PYSHWCEKARI(this LXQAJKDVVNB a, string b, bool c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8B17740", Offset = "0x8B16740", VA = "0x188B17740")]
		public static SetResult CGFCUEYGJZE(this LXQAJKDVVNB a, string b, float c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8B17F80", Offset = "0x8B16F80", VA = "0x188B17F80")]
		public static SetResult YFQRKPWCSCD(this LXQAJKDVVNB a, string b, DateTime c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8B17D00", Offset = "0x8B16D00", VA = "0x188B17D00")]
		public static SetResult WXULVLKJRUA(this LXQAJKDVVNB a, string b, long c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class YXUOTHVBCVO : FBDWFOINOAA, LXQAJKDVVNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly FIWRSGHZEVP WFZHBCQZUWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly Dictionary<string, byte> RWMLWFTDEVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private Dictionary<string, string> FRZOEVJYUNT;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool DUUJRRBKXGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Dictionary<string, string> IKAENTYLVMZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8B1F8A0", Offset = "0x8B1E8A0", VA = "0x188B1F8A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action USPISEYQXKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8B20920", Offset = "0x8B1F920", VA = "0x188B20920")]
		[UnityEngine.Scripting.Preserve]
		public YXUOTHVBCVO([Inject(null)] FIWRSGHZEVP unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "8")]
		public void LBPUYJUUDTZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8B20630", Offset = "0x8B1F630", VA = "0x188B20630")]
		private DirectoryInfo XTVFTDTKAFV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8B1F950", Offset = "0x8B1E950", VA = "0x188B1F950", Slot = "6")]
		public Task JVXXSEXAECX(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8B201A0", Offset = "0x8B1F1A0", VA = "0x188B201A0", Slot = "14")]
		public float SGIKCFVKAYH(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8B20550", Offset = "0x8B1F550", VA = "0x188B20550", Slot = "13")]
		public void WUSCOGEYWOP(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8B1FAC0", Offset = "0x8B1EAC0", VA = "0x188B1FAC0", Slot = "12")]
		public bool NGDPMFXEMFF(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8B1EE20", Offset = "0x8B1DE20", VA = "0x188B1EE20", Slot = "10")]
		public int BJLRNAIVRDC(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8B1F9E0", Offset = "0x8B1E9E0", VA = "0x188B1F9E0", Slot = "18")]
		public DateTime LBEKXPYTKAW(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8B1EF90", Offset = "0x8B1DF90", VA = "0x188B1EF90", Slot = "19")]
		public void FAPBULBZPNU(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8B20130", Offset = "0x8B1F130", VA = "0x188B20130", Slot = "15")]
		public void RHSTHTJFBST(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8B1FA50", Offset = "0x8B1EA50", VA = "0x188B1FA50", Slot = "11")]
		public void LFBXQSERMIA(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8B205C0", Offset = "0x8B1F5C0", VA = "0x188B205C0", Slot = "20")]
		public long WVVLAAZHNEJ(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8B1F8E0", Offset = "0x8B1E8E0", VA = "0x188B1F8E0", Slot = "21")]
		public void JPPZVFITLDP(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x39988A0", Offset = "0x39978A0", VA = "0x1839988A0", Slot = "22")]
		public a UYEEWNDSGJG<a>(string a, a b, LIWZIBCMUYN<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3997670", Offset = "0x3996670", VA = "0x183997670", Slot = "23")]
		public void OQLHVTHIEDO<b>(string a, b b, LIWZIBCMUYN<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8B1FB90", Offset = "0x8B1EB90", VA = "0x188B1FB90", Slot = "16")]
		public string OBSIVEYETQK(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8B1EE90", Offset = "0x8B1DE90", VA = "0x188B1EE90", Slot = "17")]
		public void EQXVKEZLXZE(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8B1FFE0", Offset = "0x8B1EFE0", VA = "0x188B1FFE0", Slot = "24")]
		public void RDTWBHBYXRH(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8B1EF00", Offset = "0x8B1DF00", VA = "0x188B1EF00", Slot = "9")]
		public bool EYREECFIISK(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8B20210", Offset = "0x8B1F210", VA = "0x188B20210", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8B1FC40", Offset = "0x8B1EC40", VA = "0x188B1FC40")]
		private void PMIKGMECBZX(DirectoryInfo a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8B20720", Offset = "0x8B1F720", VA = "0x188B20720")]
		private static string YCKCKWFJCLG(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8B1F7A0", Offset = "0x8B1E7A0", VA = "0x188B1F7A0")]
		private static string JJTXGPALXSJ(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3F6B0B0", Offset = "0x3F6A0B0", VA = "0x183F6B0B0")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] LIWZIBCMUYN<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3F6C7A0", Offset = "0x3F6B7A0", VA = "0x183F6C7A0")]
		private void Set<T>(string propertyName, T value, [Optional] LIWZIBCMUYN<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8B1F000", Offset = "0x8B1E000", VA = "0x188B1F000")]
		private Dictionary<string, string> ITMRKZRVBLX()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal static class LYQNTLLHRDY
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8B19950", Offset = "0x8B18950", VA = "0x188B19950")]
		[OKVIBKJHYHD.Root]
		internal static void OKVIBKJHYHD(QXIJOLGHAIZ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class WURNKOFYLKT : KTLBJDSTTVM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8B19800", Offset = "0x8B18800", VA = "0x188B19800")]
		[UnityEngine.Scripting.Preserve]
		public WURNKOFYLKT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class KTLBJDSTTVM : FBDWFOINOAA, LXQAJKDVVNB, IBPOWQPKWYW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly Dictionary<string, object> XFLJXQINSGO;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool DUUJRRBKXGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action USPISEYQXKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "8")]
		public void LBPUYJUUDTZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8B19380", Offset = "0x8B18380", VA = "0x188B19380", Slot = "6")]
		public Task JVXXSEXAECX(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8B19260", Offset = "0x8B18260", VA = "0x188B19260", Slot = "9")]
		public bool EYREECFIISK(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8B191A0", Offset = "0x8B181A0", VA = "0x188B191A0", Slot = "10")]
		public int BJLRNAIVRDC(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8B19470", Offset = "0x8B18470", VA = "0x188B19470", Slot = "11")]
		public void LFBXQSERMIA(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8B194D0", Offset = "0x8B184D0", VA = "0x188B194D0", Slot = "12")]
		public bool NGDPMFXEMFF(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8B19740", Offset = "0x8B18740", VA = "0x188B19740", Slot = "13")]
		public void WUSCOGEYWOP(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8B19650", Offset = "0x8B18650", VA = "0x188B19650", Slot = "14")]
		public float SGIKCFVKAYH(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8B195F0", Offset = "0x8B185F0", VA = "0x188B195F0", Slot = "15")]
		public void RHSTHTJFBST(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8B19530", Offset = "0x8B18530", VA = "0x188B19530", Slot = "16")]
		public string OBSIVEYETQK(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8B19200", Offset = "0x8B18200", VA = "0x188B19200", Slot = "17")]
		public void EQXVKEZLXZE(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8B19410", Offset = "0x8B18410", VA = "0x188B19410", Slot = "18")]
		public DateTime LBEKXPYTKAW(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8B192C0", Offset = "0x8B182C0", VA = "0x188B192C0", Slot = "19")]
		public void FAPBULBZPNU(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8B197A0", Offset = "0x8B187A0", VA = "0x188B197A0", Slot = "20")]
		public long WVVLAAZHNEJ(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8B19320", Offset = "0x8B18320", VA = "0x188B19320", Slot = "21")]
		public void JPPZVFITLDP(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3A54660", Offset = "0x3A53660", VA = "0x183A54660", Slot = "22")]
		public a UYEEWNDSGJG<a>(string a, a b, LIWZIBCMUYN<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3A53E40", Offset = "0x3A52E40", VA = "0x183A53E40", Slot = "23")]
		public void OQLHVTHIEDO<b>(string a, b b, LIWZIBCMUYN<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3A533A0", Offset = "0x3A523A0", VA = "0x183A533A0")]
		public T Get<T>(string propertyName, T defaultValue)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3A540B0", Offset = "0x3A530B0", VA = "0x183A540B0")]
		public void Set<T>(string propertyName, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8B19590", Offset = "0x8B18590", VA = "0x188B19590", Slot = "24")]
		public void RDTWBHBYXRH(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8B196B0", Offset = "0x8B186B0", VA = "0x188B196B0", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8B19800", Offset = "0x8B18800", VA = "0x188B19800")]
		public KTLBJDSTTVM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class AIZUXIYCCNH<a> where a : LXQAJKDVVNB
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly HashSet<AIZUXIYCCNH<a>> LORXFLMLXIC;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x57415B0", Offset = "0x57405B0", VA = "0x1857415B0")]
		protected AIZUXIYCCNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void Clear();

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void PVQIIWMTWRT(string a);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x57409E0", Offset = "0x573F9E0", VA = "0x1857409E0")]
		public static void ISLIEJFYEZD(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5741190", Offset = "0x5740190", VA = "0x185741190")]
		public static void YIRXXNZKDPD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AIKAFOQKAFG<a, b> : AIZUXIYCCNH<a> where a : LXQAJKDVVNB
	{
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly AIKAFOQKAFG<a, b> MQLQILIKRCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<string, b> GIRHBJLMHLL;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x573EA80", Offset = "0x573DA80", VA = "0x18573EA80")]
		public bool HAJBBFYHMJF(string a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x573EBC0", Offset = "0x573DBC0", VA = "0x18573EBC0")]
		public void Store(string cacheKey, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x573E8D0", Offset = "0x573D8D0", VA = "0x18573E8D0", Slot = "4")]
		protected override void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x573EAB0", Offset = "0x573DAB0", VA = "0x18573EAB0", Slot = "5")]
		protected override void PVQIIWMTWRT(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x573F020", Offset = "0x573E020", VA = "0x18573F020")]
		public AIKAFOQKAFG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface LXQAJKDVVNB
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool DUUJRRBKXGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LBPUYJUUDTZ();

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool EYREECFIISK(string a);

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int BJLRNAIVRDC(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void LFBXQSERMIA(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool NGDPMFXEMFF(string a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void WUSCOGEYWOP(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float SGIKCFVKAYH(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void RHSTHTJFBST(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		string OBSIVEYETQK(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void EQXVKEZLXZE(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "11")]
		DateTime LBEKXPYTKAW(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void FAPBULBZPNU(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "13")]
		long WVVLAAZHNEJ(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void JPPZVFITLDP(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "15")]
		a UYEEWNDSGJG<a>(string a, a b, LIWZIBCMUYN<a> c);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void OQLHVTHIEDO<b>(string a, b b, LIWZIBCMUYN<b> c);

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void RDTWBHBYXRH(string a);

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Task Save([Optional] CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface FBDWFOINOAA : LXQAJKDVVNB
	{
		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action USPISEYQXKD;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task JVXXSEXAECX(long a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface IBPOWQPKWYW : LXQAJKDVVNB
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class TNEGEEZNYVW : FBDWFOINOAA, LXQAJKDVVNB
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
			public TNEGEEZNYVW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x8B1E790", Offset = "0x8B1D790", VA = "0x188B1E790", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8B1EB50", Offset = "0x8B1DB50", VA = "0x188B1EB50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class SCWAKBDSWHJ : IEnumerator<UNBASXFCXPD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private int WDQRLRKBTGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private UNBASXFCXPD IGHQXRUYHSG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public TNEGEEZNYVW FOYWNDAXKGX;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private UNBASXFCXPD UORWHXRETNW
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private object UQAIKHVHSEP
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xAD7C10", Offset = "0xAD6C10", VA = "0x180AD7C10")]
			[DebuggerHidden]
			public SCWAKBDSWHJ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "5")]
			[DebuggerHidden]
			private void PRJHWGPKORK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x8B1D110", Offset = "0x8B1C110", VA = "0x188B1D110", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8B1D0D0", Offset = "0x8B1C0D0", VA = "0x188B1D0D0", Slot = "8")]
			[DebuggerHidden]
			private void HJPFLPVTXYN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly FIWRSGHZEVP WFZHBCQZUWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool FKVOQIRNNIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private bool XSICKQRQXZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private UDOEIWDLMUV SVPPPFJDELQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private CRSHLUEXDAO VWJKBWFSVBC;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool DUUJRRBKXGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action USPISEYQXKD
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8B1D980", Offset = "0x8B1C980", VA = "0x188B1D980")]
		[UnityEngine.Scripting.Preserve]
		public TNEGEEZNYVW([Inject(null)] FIWRSGHZEVP unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "8")]
		public void LBPUYJUUDTZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8B1D450", Offset = "0x8B1C450", VA = "0x188B1D450", Slot = "6")]
		public Task JVXXSEXAECX(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1EF7570", Offset = "0x1EF6570", VA = "0x181EF7570")]
		private static int NUILFEHSEUZ(bool a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8B1D1E0", Offset = "0x8B1C1E0", VA = "0x188B1D1E0", Slot = "9")]
		public bool EYREECFIISK(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8B1D180", Offset = "0x8B1C180", VA = "0x188B1D180", Slot = "10")]
		public int BJLRNAIVRDC(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8B1D550", Offset = "0x8B1C550", VA = "0x188B1D550", Slot = "11")]
		public void LFBXQSERMIA(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8B1D680", Offset = "0x8B1C680", VA = "0x188B1D680", Slot = "12")]
		public bool NGDPMFXEMFF(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8B1D8C0", Offset = "0x8B1C8C0", VA = "0x188B1D8C0", Slot = "13")]
		public void WUSCOGEYWOP(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8B1D7A0", Offset = "0x8B1C7A0", VA = "0x188B1D7A0", Slot = "14")]
		public float SGIKCFVKAYH(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8B1D770", Offset = "0x8B1C770", VA = "0x188B1D770", Slot = "15")]
		public void RHSTHTJFBST(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8B1D4E0", Offset = "0x8B1C4E0", VA = "0x188B1D4E0", Slot = "18")]
		public DateTime LBEKXPYTKAW(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8B1D200", Offset = "0x8B1C200", VA = "0x188B1D200", Slot = "19")]
		public void FAPBULBZPNU(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8B1D8F0", Offset = "0x8B1C8F0", VA = "0x188B1D8F0", Slot = "20")]
		public long WVVLAAZHNEJ(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8B1D3E0", Offset = "0x8B1C3E0", VA = "0x188B1D3E0", Slot = "21")]
		public void JPPZVFITLDP(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3DDE080", Offset = "0x3DDD080", VA = "0x183DDE080", Slot = "22")]
		public a UYEEWNDSGJG<a>(string a, a b, LIWZIBCMUYN<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3DDDE30", Offset = "0x3DDCE30", VA = "0x183DDDE30", Slot = "23")]
		public void OQLHVTHIEDO<b>(string a, b b, LIWZIBCMUYN<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3DDCF90", Offset = "0x3DDBF90", VA = "0x183DDCF90")]
		private c DWPUCKUUORD<c>(string a, c b, [Optional] LIWZIBCMUYN<c> c)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3DDC5E0", Offset = "0x3DDB5E0", VA = "0x183DDC5E0")]
		private void BOHLXDZNTSB<d>(string a, d b, [Optional] LIWZIBCMUYN<d> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8B1D6B0", Offset = "0x8B1C6B0", VA = "0x188B1D6B0", Slot = "16")]
		public string OBSIVEYETQK(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8B1D1B0", Offset = "0x8B1C1B0", VA = "0x188B1D1B0", Slot = "17")]
		public void EQXVKEZLXZE(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8B1D960", Offset = "0x8B1C960", VA = "0x188B1D960")]
		private void WXJZGDYJSBV(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8B1D660", Offset = "0x8B1C660", VA = "0x188B1D660")]
		private string MJKAPSRAFGL(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8B1D6E0", Offset = "0x8B1C6E0", VA = "0x188B1D6E0", Slot = "24")]
		public void RDTWBHBYXRH(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8B1D2E0", Offset = "0x8B1C2E0", VA = "0x188B1D2E0")]
		private string HQBHTCWTZLT(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8B1D7D0", Offset = "0x8B1C7D0", VA = "0x188B1D7D0", Slot = "25")]
		[AsyncStateMachine(typeof(<Save>d__38))]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8B1D270", Offset = "0x8B1C270", VA = "0x188B1D270")]
		[IteratorStateMachine(typeof(SCWAKBDSWHJ))]
		private IEnumerator<UNBASXFCXPD> FKXDXGVXFSN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8B1D380", Offset = "0x8B1C380", VA = "0x188B1D380")]
		private void JJQTAWFGLFT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8B1D580", Offset = "0x8B1C580", VA = "0x188B1D580")]
		private void LZCPYAMOPEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8B1D5F0", Offset = "0x8B1C5F0", VA = "0x188B1D5F0")]
		private void MHJNQEQWNWC(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class GAORMOLFDDI : FBDWFOINOAA, LXQAJKDVVNB
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
		private Dictionary<string, string> FRZOEVJYUNT;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DUUJRRBKXGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private string PVGXCHIFMGG
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8B18300", Offset = "0x8B17300", VA = "0x188B18300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private string MNBEOUEXOBW
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x8B18F40", Offset = "0x8B17F40", VA = "0x188B18F40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Dictionary<string, string> IKAENTYLVMZ
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8B186C0", Offset = "0x8B176C0", VA = "0x188B186C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action USPISEYQXKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		[UnityEngine.Scripting.Preserve]
		public GAORMOLFDDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "8")]
		public void LBPUYJUUDTZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8B18770", Offset = "0x8B17770", VA = "0x188B18770", Slot = "6")]
		public Task JVXXSEXAECX(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8B18B90", Offset = "0x8B17B90", VA = "0x188B18B90", Slot = "14")]
		public float SGIKCFVKAYH(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8B18E60", Offset = "0x8B17E60", VA = "0x188B18E60", Slot = "13")]
		public void WUSCOGEYWOP(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8B188E0", Offset = "0x8B178E0", VA = "0x188B188E0", Slot = "12")]
		public bool NGDPMFXEMFF(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8B180F0", Offset = "0x8B170F0", VA = "0x188B180F0", Slot = "10")]
		public int BJLRNAIVRDC(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8B18800", Offset = "0x8B17800", VA = "0x188B18800", Slot = "18")]
		public DateTime LBEKXPYTKAW(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8B18290", Offset = "0x8B17290", VA = "0x188B18290", Slot = "19")]
		public void FAPBULBZPNU(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8B18B20", Offset = "0x8B17B20", VA = "0x188B18B20", Slot = "15")]
		public void RHSTHTJFBST(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8B18870", Offset = "0x8B17870", VA = "0x188B18870", Slot = "11")]
		public void LFBXQSERMIA(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8B18ED0", Offset = "0x8B17ED0", VA = "0x188B18ED0", Slot = "20")]
		public long WVVLAAZHNEJ(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8B18700", Offset = "0x8B17700", VA = "0x188B18700", Slot = "21")]
		public void JPPZVFITLDP(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x39988A0", Offset = "0x39978A0", VA = "0x1839988A0", Slot = "22")]
		public a UYEEWNDSGJG<a>(string a, a b, LIWZIBCMUYN<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3997670", Offset = "0x3996670", VA = "0x183997670", Slot = "23")]
		public void OQLHVTHIEDO<b>(string a, b b, LIWZIBCMUYN<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8B189B0", Offset = "0x8B179B0", VA = "0x188B189B0", Slot = "16")]
		public string OBSIVEYETQK(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8B18160", Offset = "0x8B17160", VA = "0x188B18160", Slot = "17")]
		public void EQXVKEZLXZE(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8B18A60", Offset = "0x8B17A60", VA = "0x188B18A60", Slot = "24")]
		public void RDTWBHBYXRH(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8B18200", Offset = "0x8B17200", VA = "0x188B18200", Slot = "9")]
		public bool EYREECFIISK(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8B18C00", Offset = "0x8B17C00", VA = "0x188B18C00", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x39960A0", Offset = "0x39950A0", VA = "0x1839960A0")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] LIWZIBCMUYN<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x3997880", Offset = "0x3996880", VA = "0x183997880")]
		private void Set<T>(string propertyName, T value, [Optional] LIWZIBCMUYN<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8B18390", Offset = "0x8B17390", VA = "0x188B18390")]
		private Dictionary<string, string> ITMRKZRVBLX()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface VUZKNGQNDWC
	{
		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event Action USPISEYQXKD;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LBPUYJUUDTZ();

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task PGAOCYWIWKB(long a);

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool DJNFKGHTEZX(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool VOXZXICHFQN(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool ZEZGYLFZMDK(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		string XOERMCYBVJB(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		SetResult CPQODKJIRQH(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "9")]
		int VAHOGEMKEOL(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "10")]
		SetResult BXIDGIHIKQD(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool SJVDDVFLUHM(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "12")]
		SetResult QKIRUGUYBHU(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "13")]
		float CWFEGBKBXHC(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "14")]
		SetResult CWMAOLGJOMI(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "15")]
		DateTime PXNTCDXUIBZ(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "16")]
		SetResult WJIKVQFAVKX(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "17")]
		long YSWWFRFNAUA(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "18")]
		SetResult POQITYZOSIU(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "19")]
		a XLSCKLJQRDD<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "20")]
		SetResult LMXATWJNFYF<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool HTOADTBALQR(string a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool FUVPJGGNYMO(string a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "23")]
		string ZFLWEZGKRJV(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "24")]
		SetResult UGPVIJEUDAL(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "25")]
		int TJLEPZTJSRJ(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "26")]
		SetResult INWWFWOIUOL(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "27")]
		bool QQQKPURSJKO(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "28")]
		SetResult GTCWADRUBXA(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "29")]
		float FLSUFECBQIQ(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "30")]
		SetResult BOQNYVVRLUA(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "31")]
		DateTime EAKXTQSLOQH(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "32")]
		SetResult QDPSECMZKFB(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "33")]
		long LVICBUGCBGE(string a, long b = 0L);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "34")]
		SetResult NYIJNVGUEUY(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void JZLJRJEEFQL<e>(LIWZIBCMUYN<e> a, [Optional] IEqualityComparer<e> b);

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void ACBQGMPDIUU<f>();

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "37")]
		IDisposable CAZYIXNAQKF();

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void SGFMEZTTJGO(float a);

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "39")]
		Task JJQTAWFGLFT([Optional] CancellationToken a);
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
	public class Preferences : VUZKNGQNDWC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		private abstract class HREJMTBCTZK
		{
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			protected static readonly HashSet<HREJMTBCTZK> TDPQAQWXSCD;

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8B18FD0", Offset = "0x8B17FD0", VA = "0x188B18FD0")]
			public static void YIRXXNZKDPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract void Clear();

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			protected HREJMTBCTZK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		private class HUULVERVDDR<a> : HREJMTBCTZK
		{
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public static readonly HUULVERVDDR<a> HNQVBJEYTYC;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public LIWZIBCMUYN<a> BFYQWCDJJIC
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0xACFF70", Offset = "0xACEF70", VA = "0x180ACFF70")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public IEqualityComparer<a> OGKIPTBDHOK
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600012A")]
				[Cpp2IlInjected.Address(RVA = "0xAD0490", Offset = "0xACF490", VA = "0x180AD0490")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool BDFFLSUZGHX
			{
				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0x5272200", Offset = "0x5271200", VA = "0x185272200")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x5272B30", Offset = "0x5271B30", VA = "0x185272B30")]
			private HUULVERVDDR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x5272600", Offset = "0x5271600", VA = "0x185272600")]
			public void YTBQRMTMKZK(LIWZIBCMUYN<a> a, [Optional] IEqualityComparer<a> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x52721B0", Offset = "0x52711B0", VA = "0x1852721B0", Slot = "4")]
			public override void Clear()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		private class BKOGYTNTLBK : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private readonly Preferences PCRBIUUBVRL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private readonly object LECCXDWSBYX;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x8B17690", Offset = "0x8B16690", VA = "0x188B17690")]
			public BKOGYTNTLBK(Preferences a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x8B17660", Offset = "0x8B16660", VA = "0x188B17660", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8B1DF10", Offset = "0x8B1CF10", VA = "0x188B1DF10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x8B1E200", Offset = "0x8B1D200", VA = "0x188B1E200", Slot = "5")]
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
			public LXQAJKDVVNB backingStoreToSave;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x8B1EBB0", Offset = "0x8B1DBB0", VA = "0x188B1EBB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8B1E260", Offset = "0x8B1D260", VA = "0x188B1E260", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x8B1E730", Offset = "0x8B1D730", VA = "0x188B1E730", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class KTTGOYIKDZQ : IEnumerator<UNBASXFCXPD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private int WDQRLRKBTGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private UNBASXFCXPD IGHQXRUYHSG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public Preferences FOYWNDAXKGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public float PNJKNKQBRVA;

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			private UNBASXFCXPD UORWHXRETNW
			{
				[Cpp2IlInjected.Token(Token = "0x600013B")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private object UQAIKHVHSEP
			{
				[Cpp2IlInjected.Token(Token = "0x600013D")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xAD7C10", Offset = "0xAD6C10", VA = "0x180AD7C10")]
			[DebuggerHidden]
			public KTTGOYIKDZQ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "5")]
			[DebuggerHidden]
			private void PRJHWGPKORK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x8B198C0", Offset = "0x8B188C0", VA = "0x188B198C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x8B19880", Offset = "0x8B18880", VA = "0x188B19880", Slot = "8")]
			[DebuggerHidden]
			private void HJPFLPVTXYN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly FBDWFOINOAA LACMYYMIPHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly FBDWFOINOAA AIVHAXGURKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly IBPOWQPKWYW EFULHRNLQFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly UDOEIWDLMUV SVPPPFJDELQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly BTTYIJCLTMZ.CustomSaveHandler GYCWNBIVLMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly VOFSXJFIEEZ YFHYWIAERSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly HashSet<LXQAJKDVVNB> REASXDAOSEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private Task QRCXWJQMIHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private Dictionary<string, string> RFCZTNCHWQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private CRSHLUEXDAO OZYMYTFLSQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly object MLTLAIUQTUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly object DRTQLHDZWSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private long XFZGVUCCLQT;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private bool YSVSJBZRFJT
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x1AFED30", Offset = "0x1AFDD30", VA = "0x181AFED30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private CancellationTokenSource MVJBBHRZMIW
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xACEE90", Offset = "0xACDE90", VA = "0x180ACEE90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xACEBC0", Offset = "0xACDBC0", VA = "0x180ACEBC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action USPISEYQXKD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x8B1AF00", Offset = "0x8B19F00", VA = "0x188B1AF00", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x8B1A600", Offset = "0x8B19600", VA = "0x188B1A600", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8B1A2B0", Offset = "0x8B192B0", VA = "0x188B1A2B0")]
		[OKVIBKJHYHD.Root]
		internal static void CQLKHQZBQNQ(QXIJOLGHAIZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8B1C920", Offset = "0x8B1B920", VA = "0x188B1C920")]
		[UnityEngine.Scripting.Preserve]
		public Preferences([Inject("Disk")] FBDWFOINOAA localBackingStore, [Inject("Cloud")] FBDWFOINOAA cloudBackingStore, [Inject(null)] IBPOWQPKWYW editorBackingStore, [Inject(null)] UDOEIWDLMUV scheduler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8B1A6A0", Offset = "0x8B196A0", VA = "0x188B1A6A0", Slot = "44")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8B1BBC0", Offset = "0x8B1ABC0", VA = "0x188B1BBC0")]
		private void SNPHFWWTJLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8B1AE20", Offset = "0x8B19E20", VA = "0x188B1AE20", Slot = "6")]
		public void LBPUYJUUDTZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8B1B030", Offset = "0x8B1A030", VA = "0x188B1B030", Slot = "7")]
		public Task PGAOCYWIWKB(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8B1A010", Offset = "0x8B19010", VA = "0x188B1A010")]
		[AsyncStateMachine(typeof(<InitializeForPlayerInternal>d__23))]
		private Task CMSLGBASXFM(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8B1AB20", Offset = "0x8B19B20", VA = "0x188B1AB20")]
		private void IVOQOUKZIEH(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8B1AC30", Offset = "0x8B19C30", VA = "0x188B1AC30")]
		private void JVWXWHUPXAC(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8B1AFA0", Offset = "0x8B19FA0", VA = "0x188B1AFA0")]
		private string NSPRQJWMTHP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8B1B560", Offset = "0x8B1A560", VA = "0x188B1B560")]
		private void PZEYMTBPPBX(AccountPreferenceBackingStoreTypes a, string b, [Out] FBDWFOINOAA c, [Out] string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8B1BA90", Offset = "0x8B1AA90", VA = "0x188B1BA90")]
		private FBDWFOINOAA SGKRFXGCWFD(AccountPreferenceBackingStoreTypes a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8B1A550", Offset = "0x8B19550", VA = "0x188B1A550", Slot = "8")]
		public bool DJNFKGHTEZX(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8B1BF80", Offset = "0x8B1AF80", VA = "0x188B1BF80", Slot = "9")]
		public bool VOXZXICHFQN(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8B1C5F0", Offset = "0x8B1B5F0", VA = "0x188B1C5F0", Slot = "10")]
		public bool ZEZGYLFZMDK(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8B1C450", Offset = "0x8B1B450", VA = "0x188B1C450", Slot = "11")]
		public string XOERMCYBVJB(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8B1A120", Offset = "0x8B19120", VA = "0x188B1A120", Slot = "12")]
		public SetResult CPQODKJIRQH(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8B1BD80", Offset = "0x8B1AD80", VA = "0x188B1BD80", Slot = "13")]
		public int VAHOGEMKEOL(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8B19DC0", Offset = "0x8B18DC0", VA = "0x188B19DC0", Slot = "14")]
		public SetResult BXIDGIHIKQD(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8B1BB10", Offset = "0x8B1AB10", VA = "0x188B1BB10", Slot = "15")]
		public bool SJVDDVFLUHM(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8B1B730", Offset = "0x8B1A730", VA = "0x188B1B730", Slot = "16")]
		public SetResult QKIRUGUYBHU(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8B1A320", Offset = "0x8B19320", VA = "0x188B1A320", Slot = "17")]
		public float CWFEGBKBXHC(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8B1A3D0", Offset = "0x8B193D0", VA = "0x188B1A3D0", Slot = "18")]
		public SetResult CWMAOLGJOMI(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8B1B4C0", Offset = "0x8B1A4C0", VA = "0x188B1B4C0", Slot = "19")]
		public DateTime PXNTCDXUIBZ(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8B1C0A0", Offset = "0x8B1B0A0", VA = "0x188B1C0A0", Slot = "20")]
		public SetResult WJIKVQFAVKX(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8B1C550", Offset = "0x8B1B550", VA = "0x188B1C550", Slot = "21")]
		public long YSWWFRFNAUA(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8B1B340", Offset = "0x8B1A340", VA = "0x188B1B340", Slot = "22")]
		public SetResult POQITYZOSIU(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3C3E6A0", Offset = "0x3C3D6A0", VA = "0x183C3E6A0", Slot = "23")]
		public a XLSCKLJQRDD<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3C3D210", Offset = "0x3C3C210", VA = "0x183C3D210", Slot = "24")]
		public SetResult LMXATWJNFYF<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8B1A950", Offset = "0x8B19950", VA = "0x188B1A950", Slot = "25")]
		public bool HTOADTBALQR(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8B1A910", Offset = "0x8B19910", VA = "0x188B1A910", Slot = "26")]
		public bool FUVPJGGNYMO(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8B1C770", Offset = "0x8B1B770", VA = "0x188B1C770", Slot = "27")]
		public string ZFLWEZGKRJV(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8B1BD50", Offset = "0x8B1AD50", VA = "0x188B1BD50", Slot = "28")]
		public SetResult UGPVIJEUDAL(string a, string b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8B1BCE0", Offset = "0x8B1ACE0", VA = "0x188B1BCE0", Slot = "29")]
		public int TJLEPZTJSRJ(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8B1AAF0", Offset = "0x8B19AF0", VA = "0x188B1AAF0", Slot = "30")]
		public SetResult INWWFWOIUOL(string a, int b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8B1BA10", Offset = "0x8B1AA10", VA = "0x188B1BA10", Slot = "31")]
		public bool QQQKPURSJKO(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8B1A920", Offset = "0x8B19920", VA = "0x188B1A920", Slot = "32")]
		public SetResult GTCWADRUBXA(string a, bool b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8B1A8A0", Offset = "0x8B198A0", VA = "0x188B1A8A0", Slot = "33")]
		public float FLSUFECBQIQ(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8B19D90", Offset = "0x8B18D90", VA = "0x188B19D90", Slot = "34")]
		public SetResult BOQNYVVRLUA(string a, float b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8B1A6E0", Offset = "0x8B196E0", VA = "0x188B1A6E0", Slot = "35")]
		public DateTime EAKXTQSLOQH(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8B1B700", Offset = "0x8B1A700", VA = "0x188B1B700", Slot = "36")]
		public SetResult QDPSECMZKFB(string a, DateTime b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8B1AE90", Offset = "0x8B19E90", VA = "0x188B1AE90", Slot = "37")]
		public long LVICBUGCBGE(string a, long b = 0L)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8B1B000", Offset = "0x8B1A000", VA = "0x188B1B000", Slot = "38")]
		public SetResult NYIJNVGUEUY(string a, long b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8B1C4F0", Offset = "0x8B1B4F0", VA = "0x188B1C4F0")]
		private bool YCONLNSAAMP(LXQAJKDVVNB a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8B1B8B0", Offset = "0x8B1A8B0", VA = "0x188B1B8B0")]
		private bool QMYMDJANZUK(LXQAJKDVVNB a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8B1A750", Offset = "0x8B19750", VA = "0x188B1A750")]
		private SetResult FJOAOEATHTA(LXQAJKDVVNB a, string b, string c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8B1A9B0", Offset = "0x8B199B0", VA = "0x188B1A9B0")]
		private SetResult IDCAVCINXRC(LXQAJKDVVNB a, string b, int c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8B1C7E0", Offset = "0x8B1B7E0", VA = "0x188B1C7E0")]
		private SetResult ZHDHWBDNPPR(LXQAJKDVVNB a, string b, bool c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8B1BE30", Offset = "0x8B1AE30", VA = "0x188B1BE30")]
		private SetResult VMLYIXEOAWP(LXQAJKDVVNB a, string b, float c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8B1ACB0", Offset = "0x8B19CB0", VA = "0x188B1ACB0")]
		private SetResult KVXXQJFXYWW(LXQAJKDVVNB a, string b, DateTime c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8B1B200", Offset = "0x8B1A200", VA = "0x188B1B200")]
		private SetResult PIKNVORRIPL(LXQAJKDVVNB a, string b, long c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x3C3D4D0", Offset = "0x3C3C4D0", VA = "0x183C3D4D0")]
		private e LRMASSVLIDK<e>(LXQAJKDVVNB a, string b, e c)
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x3C3DA30", Offset = "0x3C3CA30", VA = "0x183C3DA30")]
		private SetResult RTEPURNRMDG<f>(LXQAJKDVVNB a, string b, f c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3C3D000", Offset = "0x3C3C000", VA = "0x183C3D000", Slot = "39")]
		public void JZLJRJEEFQL<g>(LIWZIBCMUYN<g> a, [Optional] IEqualityComparer<g> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x3C3CF70", Offset = "0x3C3BF70", VA = "0x183C3CF70", Slot = "40")]
		public void ACBQGMPDIUU<h>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8B1BC10", Offset = "0x8B1AC10", VA = "0x188B1BC10")]
		[AsyncStateMachine(typeof(<Save>d__77))]
		private void Save(LXQAJKDVVNB backingStoreToSave)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8B1AB40", Offset = "0x8B19B40", VA = "0x188B1AB40", Slot = "43")]
		[AsyncStateMachine(typeof(<SaveImmediate>d__78))]
		public Task JJQTAWFGLFT([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8B1C270", Offset = "0x8B1B270", VA = "0x188B1C270")]
		private void WMYIGQDSOSD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8B19F40", Offset = "0x8B18F40", VA = "0x188B19F40", Slot = "41")]
		public IDisposable CAZYIXNAQKF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8B1BA80", Offset = "0x8B1AA80", VA = "0x188B1BA80", Slot = "42")]
		public void SGFMEZTTJGO(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8B19B20", Offset = "0x8B18B20", VA = "0x188B19B20")]
		private void BMIZQVQZRIW(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8B1C020", Offset = "0x8B1B020", VA = "0x188B1C020")]
		[IteratorStateMachine(typeof(KTTGOYIKDZQ))]
		private IEnumerator<UNBASXFCXPD> WEPHYHAGFZC(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8B1C240", Offset = "0x8B1B240", VA = "0x188B1C240")]
		[CompilerGenerated]
		private void WKEQEEVQRIP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class QKLZVLKHXVC
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8B1CF60", Offset = "0x8B1BF60", VA = "0x188B1CF60")]
		public static string ZFWPHDTGTYD(this VUZKNGQNDWC a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8B1CCB0", Offset = "0x8B1BCB0", VA = "0x188B1CCB0")]
		public static byte[] DMQNKCMMMQZ(this VUZKNGQNDWC a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8B1CE50", Offset = "0x8B1BE50", VA = "0x188B1CE50")]
		public static SetResult JVHEWLQMHXP(this VUZKNGQNDWC a, string b, ReadOnlySpan<byte> value)
		{
			return default(SetResult);
		}
	}
}
namespace RecRoom.Preferences.CustomParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class TUGPSNKJEGV : YCZMMYZLALT<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static TUGPSNKJEGV HNQVBJEYTYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x8B1DA80", Offset = "0x8B1CA80", VA = "0x188B1DA80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8B1DAD0", Offset = "0x8B1CAD0", VA = "0x188B1DAD0", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8B1DBC0", Offset = "0x8B1CBC0", VA = "0x188B1DBC0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8B1DED0", Offset = "0x8B1CED0", VA = "0x188B1DED0")]
		public TUGPSNKJEGV()
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
