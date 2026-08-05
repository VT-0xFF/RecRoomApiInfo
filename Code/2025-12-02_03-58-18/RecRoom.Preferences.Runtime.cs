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
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x85B6210", Offset = "0x85B4E10", VA = "0x1885B6210")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC0210", Offset = "0xABEE10", VA = "0x180AC0210")]
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
		[Cpp2IlInjected.Address(RVA = "0x85BCAE0", Offset = "0x85BB6E0", VA = "0x1885BCAE0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2721D10", Offset = "0x2720910", VA = "0x182721D10")]
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
	internal static class YMIXZXBDMQX
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		internal delegate void CustomSaveHandler(AZFORCCGMZL backingStore);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x85BC260", Offset = "0x85BAE60", VA = "0x1885BC260")]
		private static void GKETRGKQNXS(AZFORCCGMZL a, CustomSaveHandler b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x85BC2E0", Offset = "0x85BAEE0", VA = "0x1885BC2E0")]
		public static bool GTGDQQVKPMW(this AZFORCCGMZL a, string b, [Optional] CustomSaveHandler c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x85BC580", Offset = "0x85BB180", VA = "0x1885BC580")]
		public static SetResult TQRCJDFDKHL(this AZFORCCGMZL a, string b, string c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x85BC120", Offset = "0x85BAD20", VA = "0x1885BC120")]
		public static SetResult GEFYVNCABSD(this AZFORCCGMZL a, string b, int c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x85BC990", Offset = "0x85BB590", VA = "0x1885BC990")]
		public static SetResult XUQHAKFMWRG(this AZFORCCGMZL a, string b, bool c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x85BC6D0", Offset = "0x85BB2D0", VA = "0x1885BC6D0")]
		public static SetResult VVRJRYOCVBC(this AZFORCCGMZL a, string b, float c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x85BC820", Offset = "0x85BB420", VA = "0x1885BC820")]
		public static SetResult WQDYJXSPMWV(this AZFORCCGMZL a, string b, DateTime c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x85BC440", Offset = "0x85BB040", VA = "0x1885BC440")]
		public static SetResult NUMVQSWNNFM(this AZFORCCGMZL a, string b, long c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class MICWUBVEJBU : PPKMKFNHJOC, AZFORCCGMZL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly YMDJGMEJKKH DXESFXTZQIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly Dictionary<string, byte> FXSJNEUVNXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private Dictionary<string, string> YWQFMWEWLMT;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool FBOXVAHKOPR
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Dictionary<string, string> MFXOXVMJKNR
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x85B5F70", Offset = "0x85B4B70", VA = "0x1885B5F70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action KSJFCWPRGAV
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x85B6170", Offset = "0x85B4D70", VA = "0x1885B6170")]
		[UnityEngine.Scripting.Preserve]
		public MICWUBVEJBU([Inject(null)] YMDJGMEJKKH unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "8")]
		public void OWEBBSMKVWJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x85B59B0", Offset = "0x85B45B0", VA = "0x1885B59B0")]
		private DirectoryInfo QBVOPQGCXYJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x85B5B10", Offset = "0x85B4710", VA = "0x1885B5B10", Slot = "6")]
		public Task RGLLPURANUB(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x85B5AA0", Offset = "0x85B46A0", VA = "0x1885B5AA0", Slot = "14")]
		public float QDECOWTRVBD(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x85B6090", Offset = "0x85B4C90", VA = "0x1885B6090", Slot = "13")]
		public void WQEEQHRZAOB(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x85B4640", Offset = "0x85B3240", VA = "0x1885B4640", Slot = "12")]
		public bool AUGDZRGDIVX(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x85B6100", Offset = "0x85B4D00", VA = "0x1885B6100", Slot = "10")]
		public int YQBQLKRSNOS(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x85B4FE0", Offset = "0x85B3BE0", VA = "0x1885B4FE0", Slot = "18")]
		public DateTime KFSWWJJWCBK(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x85B5FB0", Offset = "0x85B4BB0", VA = "0x1885B5FB0", Slot = "19")]
		public void VVFHIWTEWAA(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x85B5050", Offset = "0x85B3C50", VA = "0x1885B5050", Slot = "15")]
		public void KYIPKLZCQHX(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x85B5940", Offset = "0x85B4540", VA = "0x1885B5940", Slot = "11")]
		public void PKJCXXOGZNA(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x85B4710", Offset = "0x85B3310", VA = "0x1885B4710", Slot = "20")]
		public long BDRRGDHJHLN(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x85B4780", Offset = "0x85B3380", VA = "0x1885B4780", Slot = "21")]
		public void CYHLTHOTFAP(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x37B2180", Offset = "0x37B0D80", VA = "0x1837B2180", Slot = "22")]
		public a RPMKVQLJGOO<a>(string a, a b, KKPQSGFSPLZ<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x37B1F70", Offset = "0x37B0B70", VA = "0x1837B1F70", Slot = "23")]
		public void OIDZWNAHZFY<b>(string a, b b, KKPQSGFSPLZ<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x85B50C0", Offset = "0x85B3CC0", VA = "0x1885B50C0", Slot = "16")]
		public string LSYQVOCHFCM(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x85B6020", Offset = "0x85B4C20", VA = "0x1885B6020", Slot = "17")]
		public void WDTKSRZIFEE(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x85B4B90", Offset = "0x85B3790", VA = "0x1885B4B90", Slot = "24")]
		public void GUTDAXQTTHZ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x85B5BA0", Offset = "0x85B47A0", VA = "0x1885B5BA0", Slot = "9")]
		public bool RORGNUCBYSQ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x85B5C30", Offset = "0x85B4830", VA = "0x1885B5C30", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x85B47F0", Offset = "0x85B33F0", VA = "0x1885B47F0")]
		private void GFKXGRHASAH(DirectoryInfo a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x85B4CE0", Offset = "0x85B38E0", VA = "0x1885B4CE0")]
		private static string INNRULHTPES(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x85B4EE0", Offset = "0x85B3AE0", VA = "0x1885B4EE0")]
		private static string JBDYCQDAVZR(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x37B09C0", Offset = "0x37AF5C0", VA = "0x1837B09C0")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] KKPQSGFSPLZ<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x37B2410", Offset = "0x37B1010", VA = "0x1837B2410")]
		private void Set<T>(string propertyName, T value, [Optional] KKPQSGFSPLZ<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x85B5170", Offset = "0x85B3D70", VA = "0x1885B5170")]
		private Dictionary<string, string> NOZRPYVGZLZ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal static class RFFIACYEWGE
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x85B9A30", Offset = "0x85B8630", VA = "0x1885B9A30")]
		[YLZSHGPPZTN.Root]
		internal static void YLZSHGPPZTN(URVRSSRGCJF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class VHNROZPQJOB : RYMOQDKNPNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x85BB0D0", Offset = "0x85B9CD0", VA = "0x1885BB0D0")]
		[UnityEngine.Scripting.Preserve]
		public VHNROZPQJOB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class RYMOQDKNPNC : PPKMKFNHJOC, AZFORCCGMZL, GKJHIACDTQI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly Dictionary<string, object> PVCSRXEVUYY;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool FBOXVAHKOPR
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action KSJFCWPRGAV
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "8")]
		public void OWEBBSMKVWJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x85BADD0", Offset = "0x85B99D0", VA = "0x1885BADD0", Slot = "6")]
		public Task RGLLPURANUB(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x85BAE60", Offset = "0x85B9A60", VA = "0x1885BAE60", Slot = "9")]
		public bool RORGNUCBYSQ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x85BB070", Offset = "0x85B9C70", VA = "0x1885BB070", Slot = "10")]
		public int YQBQLKRSNOS(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x85BAD10", Offset = "0x85B9910", VA = "0x1885BAD10", Slot = "11")]
		public void PKJCXXOGZNA(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x85BAA70", Offset = "0x85B9670", VA = "0x1885BAA70", Slot = "12")]
		public bool AUGDZRGDIVX(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x85BB010", Offset = "0x85B9C10", VA = "0x1885BB010", Slot = "13")]
		public void WQEEQHRZAOB(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x85BAD70", Offset = "0x85B9970", VA = "0x1885BAD70", Slot = "14")]
		public float QDECOWTRVBD(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x85BAC50", Offset = "0x85B9850", VA = "0x1885BAC50", Slot = "15")]
		public void KYIPKLZCQHX(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x85BACB0", Offset = "0x85B98B0", VA = "0x1885BACB0", Slot = "16")]
		public string LSYQVOCHFCM(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x85BAFB0", Offset = "0x85B9BB0", VA = "0x1885BAFB0", Slot = "17")]
		public void WDTKSRZIFEE(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x85BABF0", Offset = "0x85B97F0", VA = "0x1885BABF0", Slot = "18")]
		public DateTime KFSWWJJWCBK(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x85BAF50", Offset = "0x85B9B50", VA = "0x1885BAF50", Slot = "19")]
		public void VVFHIWTEWAA(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x85BAAD0", Offset = "0x85B96D0", VA = "0x1885BAAD0", Slot = "20")]
		public long BDRRGDHJHLN(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x85BAB30", Offset = "0x85B9730", VA = "0x1885BAB30", Slot = "21")]
		public void CYHLTHOTFAP(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3A0BCF0", Offset = "0x3A0A8F0", VA = "0x183A0BCF0", Slot = "22")]
		public a RPMKVQLJGOO<a>(string a, a b, KKPQSGFSPLZ<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3A0BA80", Offset = "0x3A0A680", VA = "0x183A0BA80", Slot = "23")]
		public void OIDZWNAHZFY<b>(string a, b b, KKPQSGFSPLZ<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3A0AFE0", Offset = "0x3A09BE0", VA = "0x183A0AFE0")]
		public T Get<T>(string propertyName, T defaultValue)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3A0C0B0", Offset = "0x3A0ACB0", VA = "0x183A0C0B0")]
		public void Set<T>(string propertyName, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x85BAB90", Offset = "0x85B9790", VA = "0x1885BAB90", Slot = "24")]
		public void GUTDAXQTTHZ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x85BAEC0", Offset = "0x85B9AC0", VA = "0x1885BAEC0", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x85BB0D0", Offset = "0x85B9CD0", VA = "0x1885BB0D0")]
		public RYMOQDKNPNC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class MVAWSJXXMST<a> where a : AZFORCCGMZL
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly HashSet<MVAWSJXXMST<a>> EEXFRBRLGXC;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5710840", Offset = "0x570F440", VA = "0x185710840")]
		protected MVAWSJXXMST()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void Clear();

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void VXNIVBXXNDF(string a);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x570FCF0", Offset = "0x570E8F0", VA = "0x18570FCF0")]
		public static void BIIIRZBWLNJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5710450", Offset = "0x570F050", VA = "0x185710450")]
		public static void TKXMOZHNFJF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class MVGDPQRUWEC<a, b> : MVAWSJXXMST<a> where a : AZFORCCGMZL
	{
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly MVGDPQRUWEC<a, b> YNAVUHJMGMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<string, b> NFSINDXRRSD;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x57109C0", Offset = "0x570F5C0", VA = "0x1857109C0")]
		public bool CLNAOHYEVON(string a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5710CE0", Offset = "0x570F8E0", VA = "0x185710CE0")]
		public void Store(string cacheKey, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5710B00", Offset = "0x570F700", VA = "0x185710B00", Slot = "4")]
		protected override void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5710E10", Offset = "0x570FA10", VA = "0x185710E10", Slot = "5")]
		protected override void VXNIVBXXNDF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x57110B0", Offset = "0x570FCB0", VA = "0x1857110B0")]
		public MVGDPQRUWEC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface AZFORCCGMZL
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool FBOXVAHKOPR
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OWEBBSMKVWJ();

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool RORGNUCBYSQ(string a);

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int YQBQLKRSNOS(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void PKJCXXOGZNA(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool AUGDZRGDIVX(string a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void WQEEQHRZAOB(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float QDECOWTRVBD(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void KYIPKLZCQHX(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		string LSYQVOCHFCM(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void WDTKSRZIFEE(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "11")]
		DateTime KFSWWJJWCBK(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void VVFHIWTEWAA(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "13")]
		long BDRRGDHJHLN(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void CYHLTHOTFAP(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "15")]
		a RPMKVQLJGOO<a>(string a, a b, KKPQSGFSPLZ<a> c);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void OIDZWNAHZFY<b>(string a, b b, KKPQSGFSPLZ<b> c);

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void GUTDAXQTTHZ(string a);

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Task Save([Optional] CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface PPKMKFNHJOC : AZFORCCGMZL
	{
		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action KSJFCWPRGAV;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task RGLLPURANUB(long a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface GKJHIACDTQI : AZFORCCGMZL
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class EUXYHINRKRI : PPKMKFNHJOC, AZFORCCGMZL
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
			public EUXYHINRKRI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x85BB9D0", Offset = "0x85BA5D0", VA = "0x1885BB9D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x85BBDA0", Offset = "0x85BA9A0", VA = "0x1885BBDA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class XLGFOZXPAFH : IEnumerator<YRPRUNTVYNF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private int VIUVMRSCWZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private YRPRUNTVYNF VWMVUJJYLQY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public EUXYHINRKRI BIVSZSMQJUR;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private YRPRUNTVYNF AYWYUYDOKDY
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private object JGIILLOFTSJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xAA1F30", Offset = "0xAA0B30", VA = "0x180AA1F30")]
			[DebuggerHidden]
			public XLGFOZXPAFH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "5")]
			[DebuggerHidden]
			private void YZDXQKWRCHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x85BC070", Offset = "0x85BAC70", VA = "0x1885BC070", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x85BC0E0", Offset = "0x85BACE0", VA = "0x1885BC0E0", Slot = "8")]
			[DebuggerHidden]
			private void XHCIYLVFRPR()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly YMDJGMEJKKH DXESFXTZQIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool XBGTGJREFHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private bool UBIIOJNQRLS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private WTRHWJWHRVJ GBVSZXEDWSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private ZOKTFPQAJUY XCJSXWLRHXQ;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool FBOXVAHKOPR
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action KSJFCWPRGAV
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x85B3F60", Offset = "0x85B2B60", VA = "0x1885B3F60")]
		[UnityEngine.Scripting.Preserve]
		public EUXYHINRKRI([Inject(null)] YMDJGMEJKKH unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "8")]
		public void OWEBBSMKVWJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x85B3C20", Offset = "0x85B2820", VA = "0x1885B3C20", Slot = "6")]
		public Task RGLLPURANUB(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1B6A730", Offset = "0x1B69330", VA = "0x181B6A730")]
		private static int EUCUDSMKEAL(bool a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x85B3CB0", Offset = "0x85B28B0", VA = "0x1885B3CB0", Slot = "9")]
		public bool RORGNUCBYSQ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x85B3ED0", Offset = "0x85B2AD0", VA = "0x1885B3ED0", Slot = "10")]
		public int YQBQLKRSNOS(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x85B3B50", Offset = "0x85B2750", VA = "0x1885B3B50", Slot = "11")]
		public void PKJCXXOGZNA(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x85B3760", Offset = "0x85B2360", VA = "0x1885B3760", Slot = "12")]
		public bool AUGDZRGDIVX(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x85B3EA0", Offset = "0x85B2AA0", VA = "0x1885B3EA0", Slot = "13")]
		public void WQEEQHRZAOB(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x85B3BF0", Offset = "0x85B27F0", VA = "0x1885B3BF0", Slot = "14")]
		public float QDECOWTRVBD(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x85B39E0", Offset = "0x85B25E0", VA = "0x1885B39E0", Slot = "15")]
		public void KYIPKLZCQHX(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x85B3970", Offset = "0x85B2570", VA = "0x1885B3970", Slot = "18")]
		public DateTime KFSWWJJWCBK(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x85B3E00", Offset = "0x85B2A00", VA = "0x1885B3E00", Slot = "19")]
		public void VVFHIWTEWAA(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x85B3790", Offset = "0x85B2390", VA = "0x1885B3790", Slot = "20")]
		public long BDRRGDHJHLN(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x85B3800", Offset = "0x85B2400", VA = "0x1885B3800", Slot = "21")]
		public void CYHLTHOTFAP(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x35B55F0", Offset = "0x35B41F0", VA = "0x1835B55F0", Slot = "22")]
		public a RPMKVQLJGOO<a>(string a, a b, KKPQSGFSPLZ<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x35B53A0", Offset = "0x35B3FA0", VA = "0x1835B53A0", Slot = "23")]
		public void OIDZWNAHZFY<b>(string a, b b, KKPQSGFSPLZ<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x35B58B0", Offset = "0x35B44B0", VA = "0x1835B58B0")]
		private c TCQUYNHTDFJ<c>(string a, c b, [Optional] KKPQSGFSPLZ<c> c)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x35B49F0", Offset = "0x35B35F0", VA = "0x1835B49F0")]
		private void IZGPGQEDVLR<d>(string a, d b, [Optional] KKPQSGFSPLZ<d> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x85B3A10", Offset = "0x85B2610", VA = "0x1885B3A10", Slot = "16")]
		public string LSYQVOCHFCM(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x85B3E70", Offset = "0x85B2A70", VA = "0x1885B3E70", Slot = "17")]
		public void WDTKSRZIFEE(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x85B3DC0", Offset = "0x85B29C0", VA = "0x1885B3DC0")]
		private void VIVZSGIURVL(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x85B3DE0", Offset = "0x85B29E0", VA = "0x1885B3DE0")]
		private string VQFWILOFCSR(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x85B38E0", Offset = "0x85B24E0", VA = "0x1885B38E0", Slot = "24")]
		public void GUTDAXQTTHZ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x85B3A40", Offset = "0x85B2640", VA = "0x1885B3A40")]
		private string NWQLYTRRFOD(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x85B3CD0", Offset = "0x85B28D0", VA = "0x1885B3CD0", Slot = "25")]
		[AsyncStateMachine(typeof(<Save>d__38))]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x85B3B80", Offset = "0x85B2780", VA = "0x1885B3B80")]
		[IteratorStateMachine(typeof(XLGFOZXPAFH))]
		private IEnumerator<YRPRUNTVYNF> PTRHYUPWBIX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x85B3F00", Offset = "0x85B2B00", VA = "0x1885B3F00")]
		private void ZVJUGKJMSFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x85B3AE0", Offset = "0x85B26E0", VA = "0x1885B3AE0")]
		private void OZJIJFXBQKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x85B3870", Offset = "0x85B2470", VA = "0x1885B3870")]
		private void FZWIBLHSEHG(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class RVVMQRFDIQU : PPKMKFNHJOC, AZFORCCGMZL
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
		private Dictionary<string, string> YWQFMWEWLMT;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool FBOXVAHKOPR
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private string JVRXXTWNEEQ
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x85BA330", Offset = "0x85B8F30", VA = "0x1885BA330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private string CCBGBJKFFGO
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x85BA7B0", Offset = "0x85B93B0", VA = "0x1885BA7B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Dictionary<string, string> MFXOXVMJKNR
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x85BA840", Offset = "0x85B9440", VA = "0x1885BA840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action KSJFCWPRGAV
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		[UnityEngine.Scripting.Preserve]
		public RVVMQRFDIQU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "8")]
		public void OWEBBSMKVWJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x85BA430", Offset = "0x85B9030", VA = "0x1885BA430", Slot = "6")]
		public Task RGLLPURANUB(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x85BA3C0", Offset = "0x85B8FC0", VA = "0x1885BA3C0", Slot = "14")]
		public float QDECOWTRVBD(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x85BA990", Offset = "0x85B9590", VA = "0x1885BA990", Slot = "13")]
		public void WQEEQHRZAOB(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x85B9B90", Offset = "0x85B8790", VA = "0x1885B9B90", Slot = "12")]
		public bool AUGDZRGDIVX(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x85BAA00", Offset = "0x85B9600", VA = "0x1885BAA00", Slot = "10")]
		public int YQBQLKRSNOS(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x85B9E00", Offset = "0x85B8A00", VA = "0x1885B9E00", Slot = "18")]
		public DateTime KFSWWJJWCBK(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x85BA880", Offset = "0x85B9480", VA = "0x1885BA880", Slot = "19")]
		public void VVFHIWTEWAA(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x85B9E70", Offset = "0x85B8A70", VA = "0x1885B9E70", Slot = "15")]
		public void KYIPKLZCQHX(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x85BA2C0", Offset = "0x85B8EC0", VA = "0x1885BA2C0", Slot = "11")]
		public void PKJCXXOGZNA(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x85B9C60", Offset = "0x85B8860", VA = "0x1885B9C60", Slot = "20")]
		public long BDRRGDHJHLN(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x85B9CD0", Offset = "0x85B88D0", VA = "0x1885B9CD0", Slot = "21")]
		public void CYHLTHOTFAP(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x37B2180", Offset = "0x37B0D80", VA = "0x1837B2180", Slot = "22")]
		public a RPMKVQLJGOO<a>(string a, a b, KKPQSGFSPLZ<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x37B1F70", Offset = "0x37B0B70", VA = "0x1837B1F70", Slot = "23")]
		public void OIDZWNAHZFY<b>(string a, b b, KKPQSGFSPLZ<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x85B9EE0", Offset = "0x85B8AE0", VA = "0x1885B9EE0", Slot = "16")]
		public string LSYQVOCHFCM(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x85BA8F0", Offset = "0x85B94F0", VA = "0x1885BA8F0", Slot = "17")]
		public void WDTKSRZIFEE(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x85B9D40", Offset = "0x85B8940", VA = "0x1885B9D40", Slot = "24")]
		public void GUTDAXQTTHZ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x85BA4C0", Offset = "0x85B90C0", VA = "0x1885BA4C0", Slot = "9")]
		public bool RORGNUCBYSQ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x85BA550", Offset = "0x85B9150", VA = "0x1885BA550", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3A061F0", Offset = "0x3A04DF0", VA = "0x183A061F0")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] KKPQSGFSPLZ<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x3A07A20", Offset = "0x3A06620", VA = "0x183A07A20")]
		private void Set<T>(string propertyName, T value, [Optional] KKPQSGFSPLZ<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x85B9F90", Offset = "0x85B8B90", VA = "0x1885B9F90")]
		private Dictionary<string, string> NOZRPYVGZLZ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface VNCXHMYABJK
	{
		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event Action KSJFCWPRGAV;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OWEBBSMKVWJ();

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task WVNOOJMABTV(long a);

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool ZYCRLHRMDAT(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool YWUIHKLKPUH(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool XEFAWEBSJGC(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		string QAZQVRGTBGB(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		SetResult RCJPPGFFGZL(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "9")]
		int ASQURGRZEHD(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "10")]
		SetResult DZHCJGROWSR(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool WAEZXBZJEPC(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "12")]
		SetResult OXPHQXYJVLC(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "13")]
		float AIXCHXUDLXQ(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "14")]
		SetResult ECWHTYUQAQW(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "15")]
		DateTime DDGHSMPWNOF(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "16")]
		SetResult GOHYLDZKGEZ(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "17")]
		long BEGAKVBFBIC(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "18")]
		SetResult ADFXQXJPXZE(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "19")]
		a SQVLRSATZDJ<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "20")]
		SetResult RIAEZEIVFXV<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool SROUAYGKYNJ(string a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool YITPFAPCEVS(string a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "23")]
		string JNPBPOWLQZX(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "24")]
		SetResult EJYISYAAECR(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "25")]
		int BBQYQESBXMF(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "26")]
		SetResult SPRSFCWURYZ(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "27")]
		bool QVQIWTGFBMM(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "28")]
		SetResult XWUFWLLQDIA(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "29")]
		float HXMOJLZIZNE(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "30")]
		SetResult LGDBYYHZVSG(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "31")]
		DateTime RYJCGBZBHWV(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "32")]
		SetResult OJXNADSHKUB(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "33")]
		long VZRJKMIAYFM(string a, long b = 0L);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "34")]
		SetResult SXSRAFHGOFI(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void KRECDNEPRXH<e>(KKPQSGFSPLZ<e> a, [Optional] IEqualityComparer<e> b);

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void ULGIRDPQOYC<f>();

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "37")]
		IDisposable TGLASBHMALV();

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void ERMSMJFDOHO(float a);

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "39")]
		Task ZVJUGKJMSFJ([Optional] CancellationToken a);
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
	public class Preferences : VNCXHMYABJK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		private abstract class PWXRWMBMMPI
		{
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			protected static readonly HashSet<PWXRWMBMMPI> GDRABUIAOUF;

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x85B6720", Offset = "0x85B5320", VA = "0x1885B6720")]
			public static void TKXMOZHNFJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract void Clear();

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			protected PWXRWMBMMPI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		private class XUNDWQLAIOF<a> : PWXRWMBMMPI
		{
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public static readonly XUNDWQLAIOF<a> PGFSJHGESKI;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public KKPQSGFSPLZ<a> KKALELEWEFW
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0xA974E0", Offset = "0xA960E0", VA = "0x180A974E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public IEqualityComparer<a> MSYHVYODYJO
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600012A")]
				[Cpp2IlInjected.Address(RVA = "0xA98600", Offset = "0xA97200", VA = "0x180A98600")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool WLGWXTFGNMT
			{
				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0x3DCFD40", Offset = "0x3DCE940", VA = "0x183DCFD40")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x3DD01B0", Offset = "0x3DCEDB0", VA = "0x183DD01B0")]
			private XUNDWQLAIOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x3DCFA30", Offset = "0x3DCE630", VA = "0x183DCFA30")]
			public void OGBNJYRINGK(KKPQSGFSPLZ<a> a, [Optional] IEqualityComparer<a> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x3DCF810", Offset = "0x3DCE410", VA = "0x183DCF810", Slot = "4")]
			public override void Clear()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		private class LUXMFMZLOFI : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private readonly Preferences YZFYWPWOEUT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private readonly object GJWCHICLBMR;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x85B4590", Offset = "0x85B3190", VA = "0x1885B4590")]
			public LUXMFMZLOFI(Preferences a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x85B4560", Offset = "0x85B3160", VA = "0x1885B4560", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x85BB150", Offset = "0x85B9D50", VA = "0x1885BB150", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x85BB440", Offset = "0x85BA040", VA = "0x1885BB440", Slot = "5")]
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
			public AZFORCCGMZL backingStoreToSave;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x85BBE00", Offset = "0x85BAA00", VA = "0x1885BBE00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xAF5C80", Offset = "0xAF4880", VA = "0x180AF5C80", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x85BB4A0", Offset = "0x85BA0A0", VA = "0x1885BB4A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x85BB970", Offset = "0x85BA570", VA = "0x1885BB970", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class JHLIPTOBQDK : IEnumerator<YRPRUNTVYNF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private int VIUVMRSCWZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private YRPRUNTVYNF VWMVUJJYLQY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public Preferences BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public float SCQRALXJIXG;

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			private YRPRUNTVYNF AYWYUYDOKDY
			{
				[Cpp2IlInjected.Token(Token = "0x600013B")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private object JGIILLOFTSJ
			{
				[Cpp2IlInjected.Token(Token = "0x600013D")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xAA1F30", Offset = "0xAA0B30", VA = "0x180AA1F30")]
			[DebuggerHidden]
			public JHLIPTOBQDK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "5")]
			[DebuggerHidden]
			private void YZDXQKWRCHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x85B4490", Offset = "0x85B3090", VA = "0x1885B4490", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x85B4520", Offset = "0x85B3120", VA = "0x1885B4520", Slot = "8")]
			[DebuggerHidden]
			private void XHCIYLVFRPR()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly PPKMKFNHJOC EQCKEVISELG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly PPKMKFNHJOC LTMYIINWJLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly GKJHIACDTQI ZRMBMVKHYTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly WTRHWJWHRVJ GBVSZXEDWSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly YMIXZXBDMQX.CustomSaveHandler MBBGHIMZIQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly DXNVWYSIFYL OKTJSOTWMQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly HashSet<AZFORCCGMZL> OMJPMQKPDAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private Task MWVMMSSINTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private Dictionary<string, string> IUHXSTCWVZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private ZOKTFPQAJUY QAFNNKQHFVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly object MGWOBSKVMXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly object KVCGWUQJBSF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private long EAZUVUNSXNL;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private bool XXPDKRAMANJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x172B7F0", Offset = "0x172A3F0", VA = "0x18172B7F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private CancellationTokenSource EUGFBTRZVGY
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xA9A5C0", Offset = "0xA991C0", VA = "0x180A9A5C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xA9A5B0", Offset = "0xA991B0", VA = "0x180A9A5B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action KSJFCWPRGAV
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x85B8980", Offset = "0x85B7580", VA = "0x1885B8980", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x85B7560", Offset = "0x85B6160", VA = "0x1885B7560", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x85B8BE0", Offset = "0x85B77E0", VA = "0x1885B8BE0")]
		[YLZSHGPPZTN.Root]
		internal static void UYMINUXTTWE(URVRSSRGCJF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x85B96A0", Offset = "0x85B82A0", VA = "0x1885B96A0")]
		[UnityEngine.Scripting.Preserve]
		public Preferences([Inject("Disk")] PPKMKFNHJOC localBackingStore, [Inject("Cloud")] PPKMKFNHJOC cloudBackingStore, [Inject(null)] GKJHIACDTQI editorBackingStore, [Inject(null)] WTRHWJWHRVJ scheduler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x85B7030", Offset = "0x85B5C30", VA = "0x1885B7030", Slot = "44")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x85B8150", Offset = "0x85B6D50", VA = "0x1885B8150")]
		private void QJCOIEUFJSP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x85B7ED0", Offset = "0x85B6AD0", VA = "0x1885B7ED0", Slot = "6")]
		public void OWEBBSMKVWJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x85B8EC0", Offset = "0x85B7AC0", VA = "0x1885B8EC0", Slot = "7")]
		public Task WVNOOJMABTV(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x85B72B0", Offset = "0x85B5EB0", VA = "0x1885B72B0")]
		[AsyncStateMachine(typeof(<InitializeForPlayerInternal>d__23))]
		private Task GHRYYNHCNQU(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x85B85F0", Offset = "0x85B71F0", VA = "0x1885B85F0")]
		private void SRNPYJPCLSF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x85B7C20", Offset = "0x85B6820", VA = "0x1885B7C20")]
		private void LQXJADAFMBO(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x85B8A20", Offset = "0x85B7620", VA = "0x1885B8A20")]
		private string TKLGSFQZLIL(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x85B7CA0", Offset = "0x85B68A0", VA = "0x1885B7CA0")]
		private void LVDKMHUHYCX(AccountPreferenceBackingStoreTypes a, string b, [Out] PPKMKFNHJOC c, [Out] string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x85B8210", Offset = "0x85B6E10", VA = "0x1885B8210")]
		private PPKMKFNHJOC QVQVVRQXCDF(AccountPreferenceBackingStoreTypes a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x85B95F0", Offset = "0x85B81F0", VA = "0x1885B95F0", Slot = "8")]
		public bool ZYCRLHRMDAT(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x85B9430", Offset = "0x85B8030", VA = "0x1885B9430", Slot = "9")]
		public bool YWUIHKLKPUH(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x85B9090", Offset = "0x85B7C90", VA = "0x1885B9090", Slot = "10")]
		public bool XEFAWEBSJGC(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x85B80B0", Offset = "0x85B6CB0", VA = "0x1885B80B0", Slot = "11")]
		public string QAZQVRGTBGB(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x85B8290", Offset = "0x85B6E90", VA = "0x1885B8290", Slot = "12")]
		public SetResult RCJPPGFFGZL(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x85B6B10", Offset = "0x85B5710", VA = "0x1885B6B10", Slot = "13")]
		public int ASQURGRZEHD(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x85B6EC0", Offset = "0x85B5AC0", VA = "0x1885B6EC0", Slot = "14")]
		public SetResult DZHCJGROWSR(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x85B8CC0", Offset = "0x85B78C0", VA = "0x1885B8CC0", Slot = "15")]
		public bool WAEZXBZJEPC(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x85B7F40", Offset = "0x85B6B40", VA = "0x1885B7F40", Slot = "16")]
		public SetResult OXPHQXYJVLC(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x85B6A60", Offset = "0x85B5660", VA = "0x1885B6A60", Slot = "17")]
		public float AIXCHXUDLXQ(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x85B7070", Offset = "0x85B5C70", VA = "0x1885B7070", Slot = "18")]
		public SetResult ECWHTYUQAQW(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x85B6CD0", Offset = "0x85B58D0", VA = "0x1885B6CD0", Slot = "19")]
		public DateTime DDGHSMPWNOF(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x85B73C0", Offset = "0x85B5FC0", VA = "0x1885B73C0", Slot = "20")]
		public SetResult GOHYLDZKGEZ(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x85B6C30", Offset = "0x85B5830", VA = "0x1885B6C30", Slot = "21")]
		public long BEGAKVBFBIC(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x85B68F0", Offset = "0x85B54F0", VA = "0x1885B68F0", Slot = "22")]
		public SetResult ADFXQXJPXZE(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x38F2650", Offset = "0x38F1250", VA = "0x1838F2650", Slot = "23")]
		public a SQVLRSATZDJ<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x38F2390", Offset = "0x38F0F90", VA = "0x1838F2390", Slot = "24")]
		public SetResult RIAEZEIVFXV<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x85B8610", Offset = "0x85B7210", VA = "0x1885B8610", Slot = "25")]
		public bool SROUAYGKYNJ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x85B9240", Offset = "0x85B7E40", VA = "0x1885B9240", Slot = "26")]
		public bool YITPFAPCEVS(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x85B7A40", Offset = "0x85B6640", VA = "0x1885B7A40", Slot = "27")]
		public string JNPBPOWLQZX(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x85B71F0", Offset = "0x85B5DF0", VA = "0x1885B71F0", Slot = "28")]
		public SetResult EJYISYAAECR(string a, string b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x85B6BC0", Offset = "0x85B57C0", VA = "0x1885B6BC0", Slot = "29")]
		public int BBQYQESBXMF(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x85B85C0", Offset = "0x85B71C0", VA = "0x1885B85C0", Slot = "30")]
		public SetResult SPRSFCWURYZ(string a, int b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x85B81A0", Offset = "0x85B6DA0", VA = "0x1885B81A0", Slot = "31")]
		public bool QVQIWTGFBMM(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x85B9210", Offset = "0x85B7E10", VA = "0x1885B9210", Slot = "32")]
		public SetResult XWUFWLLQDIA(string a, bool b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x85B7600", Offset = "0x85B6200", VA = "0x1885B7600", Slot = "33")]
		public float HXMOJLZIZNE(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x85B7BF0", Offset = "0x85B67F0", VA = "0x1885B7BF0", Slot = "34")]
		public SetResult LGDBYYHZVSG(string a, float b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x85B8550", Offset = "0x85B7150", VA = "0x1885B8550", Slot = "35")]
		public DateTime RYJCGBZBHWV(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x85B7EA0", Offset = "0x85B6AA0", VA = "0x1885B7EA0", Slot = "36")]
		public SetResult OJXNADSHKUB(string a, DateTime b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x85B8C50", Offset = "0x85B7850", VA = "0x1885B8C50", Slot = "37")]
		public long VZRJKMIAYFM(string a, long b = 0L)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x85B8670", Offset = "0x85B7270", VA = "0x1885B8670", Slot = "38")]
		public SetResult SXSRAFHGOFI(string a, long b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x85B7E40", Offset = "0x85B6A40", VA = "0x1885B7E40")]
		private bool NNOPFAOOJYB(AZFORCCGMZL a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x85B8A80", Offset = "0x85B7680", VA = "0x1885B8A80")]
		private bool UJBEPVWUDEQ(AZFORCCGMZL a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x85B6D70", Offset = "0x85B5970", VA = "0x1885B6D70")]
		private SetResult DZAWXXSFUJW(AZFORCCGMZL a, string b, string c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x85B8410", Offset = "0x85B7010", VA = "0x1885B8410")]
		private SetResult RMYUJSTILEK(AZFORCCGMZL a, string b, int c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x85B7AB0", Offset = "0x85B66B0", VA = "0x1885B7AB0")]
		private SetResult KIXFDHSVQNL(AZFORCCGMZL a, string b, bool c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x85B8D70", Offset = "0x85B7970", VA = "0x1885B8D70")]
		private SetResult WUXPANROLFP(AZFORCCGMZL a, string b, float c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x85B7670", Offset = "0x85B6270", VA = "0x1885B7670")]
		private SetResult IJLQMFMCFUU(AZFORCCGMZL a, string b, DateTime c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x85B86A0", Offset = "0x85B72A0", VA = "0x1885B86A0")]
		private SetResult SYFCQGBEUVB(AZFORCCGMZL a, string b, long c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x38F2BE0", Offset = "0x38F17E0", VA = "0x1838F2BE0")]
		private e TQXNYWIOFMO<e>(AZFORCCGMZL a, string b, e c)
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x38F1510", Offset = "0x38F0110", VA = "0x1838F1510")]
		private SetResult CRNRUIZOSKS<f>(AZFORCCGMZL a, string b, f c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x38F2180", Offset = "0x38F0D80", VA = "0x1838F2180", Slot = "39")]
		public void KRECDNEPRXH<g>(KKPQSGFSPLZ<g> a, [Optional] IEqualityComparer<g> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x38F3140", Offset = "0x38F1D40", VA = "0x1838F3140", Slot = "40")]
		public void ULGIRDPQOYC<h>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x85B87E0", Offset = "0x85B73E0", VA = "0x1885B87E0")]
		[AsyncStateMachine(typeof(<Save>d__77))]
		private void Save(AZFORCCGMZL backingStoreToSave)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x85B9500", Offset = "0x85B8100", VA = "0x1885B9500", Slot = "43")]
		[AsyncStateMachine(typeof(<SaveImmediate>d__78))]
		public Task ZVJUGKJMSFJ([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x85B9250", Offset = "0x85B7E50", VA = "0x1885B9250")]
		private void YOGSSVPXKTX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x85B88B0", Offset = "0x85B74B0", VA = "0x1885B88B0", Slot = "41")]
		public IDisposable TGLASBHMALV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x85B7220", Offset = "0x85B5E20", VA = "0x1885B7220", Slot = "42")]
		public void ERMSMJFDOHO(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x85B77E0", Offset = "0x85B63E0", VA = "0x1885B77E0")]
		private void IYONNWPKXVC(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x85B7230", Offset = "0x85B5E30", VA = "0x1885B7230")]
		[IteratorStateMachine(typeof(JHLIPTOBQDK))]
		private IEnumerator<YRPRUNTVYNF> FKBOLYIKCUS(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x85B94D0", Offset = "0x85B80D0", VA = "0x1885B94D0")]
		[CompilerGenerated]
		private void ZRVDTKHFOMZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class GQYKETCRFBA
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x85B4320", Offset = "0x85B2F20", VA = "0x1885B4320")]
		public static string ZLZDMNWJSMV(this VNCXHMYABJK a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x85B4060", Offset = "0x85B2C60", VA = "0x1885B4060")]
		public static byte[] CNMAEBKCZTZ(this VNCXHMYABJK a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x85B4210", Offset = "0x85B2E10", VA = "0x1885B4210")]
		public static SetResult HGKOBEYURSP(this VNCXHMYABJK a, string b, ReadOnlySpan<byte> value)
		{
			return default(SetResult);
		}
	}
}
namespace RecRoom.Preferences.CustomParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class PLSGSNZBHAT : VICDNBVOCID<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static PLSGSNZBHAT PGFSJHGESKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x85B6600", Offset = "0x85B5200", VA = "0x1885B6600")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x85B6290", Offset = "0x85B4E90", VA = "0x1885B6290", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x85B6380", Offset = "0x85B4F80", VA = "0x1885B6380", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x85B66E0", Offset = "0x85B52E0", VA = "0x1885B66E0")]
		public PLSGSNZBHAT()
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
