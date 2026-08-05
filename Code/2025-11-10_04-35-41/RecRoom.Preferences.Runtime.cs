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
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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
		[Cpp2IlInjected.Address(RVA = "0x867A350", Offset = "0x8679750", VA = "0x18867A350")]
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
		[Cpp2IlInjected.Address(RVA = "0xACEB80", Offset = "0xACDF80", VA = "0x180ACEB80")]
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
		[Cpp2IlInjected.Address(RVA = "0x8681120", Offset = "0x8680520", VA = "0x188681120", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x26F2710", Offset = "0x26F1B10", VA = "0x1826F2710")]
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
	internal static class AUPMALMMWNM
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		internal delegate void CustomSaveHandler(UFXYMDCRQHM backingStore);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8678210", Offset = "0x8677610", VA = "0x188678210")]
		private static void MEOFQSEDEIN(UFXYMDCRQHM a, CustomSaveHandler b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8678680", Offset = "0x8677A80", VA = "0x188678680")]
		public static bool VKJMAGJDPOD(this UFXYMDCRQHM a, string b, [Optional] CustomSaveHandler c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8677E30", Offset = "0x8677230", VA = "0x188677E30")]
		public static SetResult DPJBLJAZFZA(this UFXYMDCRQHM a, string b, string c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x86780D0", Offset = "0x86774D0", VA = "0x1886780D0")]
		public static SetResult IUNTWVDJYXI(this UFXYMDCRQHM a, string b, int c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8678540", Offset = "0x8677940", VA = "0x188678540")]
		public static SetResult UOORJXOUFVJ(this UFXYMDCRQHM a, string b, bool c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8677F80", Offset = "0x8677380", VA = "0x188677F80")]
		public static SetResult GCWIFIKCQMV(this UFXYMDCRQHM a, string b, float c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x86783D0", Offset = "0x86777D0", VA = "0x1886783D0")]
		public static SetResult SRLQQBIOXCS(this UFXYMDCRQHM a, string b, DateTime c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8678290", Offset = "0x8677690", VA = "0x188678290")]
		public static SetResult RUYVUGIVKUZ(this UFXYMDCRQHM a, string b, long c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class UAIWZSGJGIH : BLUTYXFJTHR, UFXYMDCRQHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly BHVDAFBVYCS EYXBWMKPEZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly Dictionary<string, byte> IAGBWNIWDWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private Dictionary<string, string> IBNTFMMONQO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool FTNBLRPOGMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Dictionary<string, string> PAAETIHKOVW
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x867E760", Offset = "0x867DB60", VA = "0x18867E760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action PPSJNXIREKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x86801D0", Offset = "0x867F5D0", VA = "0x1886801D0")]
		[UnityEngine.Scripting.Preserve]
		public UAIWZSGJGIH([Inject(null)] BHVDAFBVYCS unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "8")]
		public void UOZEIRDCIGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x867E910", Offset = "0x867DD10", VA = "0x18867E910")]
		private DirectoryInfo HQBSABWALCS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x867F4A0", Offset = "0x867E8A0", VA = "0x18867F4A0", Slot = "6")]
		public Task RWMNRQQKNNE(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x867E810", Offset = "0x867DC10", VA = "0x18867E810", Slot = "14")]
		public float GHRMTOZKXPW(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x867F2C0", Offset = "0x867E6C0", VA = "0x18867F2C0", Slot = "13")]
		public void MCFMREYFCCG(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x867FFC0", Offset = "0x867F3C0", VA = "0x18867FFC0", Slot = "12")]
		public bool XQBPAKMJDVQ(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x867FC00", Offset = "0x867F000", VA = "0x18867FC00", Slot = "10")]
		public int TWSMHBFUZCL(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x867FF50", Offset = "0x867F350", VA = "0x18867FF50", Slot = "18")]
		public DateTime XJRQWSYSSOD(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x867FC70", Offset = "0x867F070", VA = "0x18867FC70", Slot = "19")]
		public void UKBSRVYSSKX(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x867F430", Offset = "0x867E830", VA = "0x18867F430", Slot = "15")]
		public void QLAHSWXMITO(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x867E7A0", Offset = "0x867DBA0", VA = "0x18867E7A0", Slot = "11")]
		public void DJQRTYPDQTR(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x867E6F0", Offset = "0x867DAF0", VA = "0x18867E6F0", Slot = "20")]
		public long ADGFIXNPAJS(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x867FEE0", Offset = "0x867F2E0", VA = "0x18867FEE0", Slot = "21")]
		public void WELNHDOKSJO(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x355AB50", Offset = "0x3559F50", VA = "0x18355AB50", Slot = "22")]
		public a UJHTICSWKBH<a>(string a, a b, HNULQOWVXXS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3559A20", Offset = "0x3558E20", VA = "0x183559A20", Slot = "23")]
		public void SHATVEOQTEB<b>(string a, b b, HNULQOWVXXS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x867EA70", Offset = "0x867DE70", VA = "0x18867EA70", Slot = "16")]
		public string JPHZVEJTRTJ(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x867EA00", Offset = "0x867DE00", VA = "0x18867EA00", Slot = "17")]
		public void JKXQTBGYWSL(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8680080", Offset = "0x867F480", VA = "0x188680080", Slot = "24")]
		public void YUPTWGDFNGY(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x867E880", Offset = "0x867DC80", VA = "0x18867E880", Slot = "9")]
		public bool GIEXNMAWZWV(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x867F530", Offset = "0x867E930", VA = "0x18867F530", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x867F860", Offset = "0x867EC60", VA = "0x18867F860")]
		private void TDNITXQJMZS(DirectoryInfo a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x867FCE0", Offset = "0x867F0E0", VA = "0x18867FCE0")]
		private static string VRWYUOABITD(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x867F330", Offset = "0x867E730", VA = "0x18867F330")]
		private static string OOXVSULKPBM(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3BAAA60", Offset = "0x3BA9E60", VA = "0x183BAAA60")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] HNULQOWVXXS<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3BAC100", Offset = "0x3BAB500", VA = "0x183BAC100")]
		private void Set<T>(string propertyName, T value, [Optional] HNULQOWVXXS<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x867EB20", Offset = "0x867DF20", VA = "0x18867EB20")]
		private Dictionary<string, string> LBKEKCALIZO()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal static class LXQSBXIVIGX
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8679D70", Offset = "0x8679170", VA = "0x188679D70")]
		[CVOOPLRRRUK.Root]
		internal static void CVOOPLRRRUK(XRSJVGYQFTW a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class YWDPACIRIPS : BMLAVRQXRAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8678E40", Offset = "0x8678240", VA = "0x188678E40")]
		[UnityEngine.Scripting.Preserve]
		public YWDPACIRIPS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class BMLAVRQXRAJ : BLUTYXFJTHR, UFXYMDCRQHM, VMIGKHUQBHV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly Dictionary<string, object> NCPOJKKIECL;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool FTNBLRPOGMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action PPSJNXIREKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "8")]
		public void UOZEIRDCIGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8678AE0", Offset = "0x8677EE0", VA = "0x188678AE0", Slot = "6")]
		public Task RWMNRQQKNNE(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8678900", Offset = "0x8677D00", VA = "0x188678900", Slot = "9")]
		public bool GIEXNMAWZWV(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8678C00", Offset = "0x8678000", VA = "0x188678C00", Slot = "10")]
		public int TWSMHBFUZCL(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8678840", Offset = "0x8677C40", VA = "0x188678840", Slot = "11")]
		public void DJQRTYPDQTR(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8678D80", Offset = "0x8678180", VA = "0x188678D80", Slot = "12")]
		public bool XQBPAKMJDVQ(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8678A20", Offset = "0x8677E20", VA = "0x188678A20", Slot = "13")]
		public void MCFMREYFCCG(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x86788A0", Offset = "0x8677CA0", VA = "0x1886788A0", Slot = "14")]
		public float GHRMTOZKXPW(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8678A80", Offset = "0x8677E80", VA = "0x188678A80", Slot = "15")]
		public void QLAHSWXMITO(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x86789C0", Offset = "0x8677DC0", VA = "0x1886789C0", Slot = "16")]
		public string JPHZVEJTRTJ(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8678960", Offset = "0x8677D60", VA = "0x188678960", Slot = "17")]
		public void JKXQTBGYWSL(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8678D20", Offset = "0x8678120", VA = "0x188678D20", Slot = "18")]
		public DateTime XJRQWSYSSOD(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8678C60", Offset = "0x8678060", VA = "0x188678C60", Slot = "19")]
		public void UKBSRVYSSKX(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x86787E0", Offset = "0x8677BE0", VA = "0x1886787E0", Slot = "20")]
		public long ADGFIXNPAJS(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8678CC0", Offset = "0x86780C0", VA = "0x188678CC0", Slot = "21")]
		public void WELNHDOKSJO(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3364330", Offset = "0x3363730", VA = "0x183364330", Slot = "22")]
		public a UJHTICSWKBH<a>(string a, a b, HNULQOWVXXS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3363B10", Offset = "0x3362F10", VA = "0x183363B10", Slot = "23")]
		public void SHATVEOQTEB<b>(string a, b b, HNULQOWVXXS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x33630B0", Offset = "0x33624B0", VA = "0x1833630B0")]
		public T Get<T>(string propertyName, T defaultValue)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3363D80", Offset = "0x3363180", VA = "0x183363D80")]
		public void Set<T>(string propertyName, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8678DE0", Offset = "0x86781E0", VA = "0x188678DE0", Slot = "24")]
		public void YUPTWGDFNGY(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8678B70", Offset = "0x8677F70", VA = "0x188678B70", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8678E40", Offset = "0x8678240", VA = "0x188678E40")]
		public BMLAVRQXRAJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class HZWLXQHUVJO<a> where a : UFXYMDCRQHM
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly HashSet<HZWLXQHUVJO<a>> BPYRETCXZCN;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4F4D720", Offset = "0x4F4CB20", VA = "0x184F4D720")]
		protected HZWLXQHUVJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void Clear();

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void CKKWLPTJUYY(string a);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4F4CBF0", Offset = "0x4F4BFF0", VA = "0x184F4CBF0")]
		public static void LGELSNHJUHY(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4F4D0A0", Offset = "0x4F4C4A0", VA = "0x184F4D0A0")]
		public static void WNRSQSQUCVQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class IAMGPKPMXRP<a, b> : HZWLXQHUVJO<a> where a : UFXYMDCRQHM
	{
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly IAMGPKPMXRP<a, b> VDDQACCVTOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<string, b> YPUTALKXQPA;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4FE84D0", Offset = "0x4FE78D0", VA = "0x184FE84D0")]
		public bool NCIRIRZXKOC(string a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4FE8750", Offset = "0x4FE7B50", VA = "0x184FE8750")]
		public void Store(string cacheKey, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4FE8470", Offset = "0x4FE7870", VA = "0x184FE8470", Slot = "4")]
		protected override void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4FE8360", Offset = "0x4FE7760", VA = "0x184FE8360", Slot = "5")]
		protected override void CKKWLPTJUYY(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4FE8B80", Offset = "0x4FE7F80", VA = "0x184FE8B80")]
		public IAMGPKPMXRP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface UFXYMDCRQHM
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool FTNBLRPOGMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void UOZEIRDCIGI();

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool GIEXNMAWZWV(string a);

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int TWSMHBFUZCL(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DJQRTYPDQTR(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool XQBPAKMJDVQ(string a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void MCFMREYFCCG(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float GHRMTOZKXPW(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void QLAHSWXMITO(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		string JPHZVEJTRTJ(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void JKXQTBGYWSL(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "11")]
		DateTime XJRQWSYSSOD(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void UKBSRVYSSKX(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "13")]
		long ADGFIXNPAJS(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void WELNHDOKSJO(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "15")]
		a UJHTICSWKBH<a>(string a, a b, HNULQOWVXXS<a> c);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void SHATVEOQTEB<b>(string a, b b, HNULQOWVXXS<b> c);

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void YUPTWGDFNGY(string a);

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Task Save([Optional] CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface BLUTYXFJTHR : UFXYMDCRQHM
	{
		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action PPSJNXIREKO;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task RWMNRQQKNNE(long a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface VMIGKHUQBHV : UFXYMDCRQHM
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class KRMJIGAFVKZ : BLUTYXFJTHR, UFXYMDCRQHM
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
			public KRMJIGAFVKZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x867E060", Offset = "0x867D460", VA = "0x18867E060", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x867E420", Offset = "0x867D820", VA = "0x18867E420", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class GMGLRROIDKE : IEnumerator<EXCEMTVEEEU>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private int JIPOOQUWCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private EXCEMTVEEEU JOTWNIKQVJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public KRMJIGAFVKZ MXVWDMPVVWS;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private EXCEMTVEEEU RGLTPZKGWZB
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xAB07E0", Offset = "0xAAFBE0", VA = "0x180AB07E0")]
			[DebuggerHidden]
			public GMGLRROIDKE(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "5")]
			[DebuggerHidden]
			private void AEBWHPMOWJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x8679320", Offset = "0x8678720", VA = "0x188679320", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x86792E0", Offset = "0x86786E0", VA = "0x1886792E0", Slot = "8")]
			[DebuggerHidden]
			private void MJTKPUASZVA()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly BHVDAFBVYCS EYXBWMKPEZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool RUGIKUURGQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private bool VYRSGIIZZPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private WRIIEUEWQVY WECBNBUUWBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private VNDHQZCKPIP RORRDFRYTTP;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool FTNBLRPOGMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action PPSJNXIREKO
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8679B90", Offset = "0x8678F90", VA = "0x188679B90")]
		[UnityEngine.Scripting.Preserve]
		public KRMJIGAFVKZ([Inject(null)] BHVDAFBVYCS unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "8")]
		public void UOZEIRDCIGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x86797D0", Offset = "0x8678BD0", VA = "0x1886797D0", Slot = "6")]
		public Task RWMNRQQKNNE(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1B4AE50", Offset = "0x1B4A250", VA = "0x181B4AE50")]
		private static int ZKWGBAQUUSI(bool a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x86796B0", Offset = "0x8678AB0", VA = "0x1886796B0", Slot = "9")]
		public bool GIEXNMAWZWV(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8679950", Offset = "0x8678D50", VA = "0x188679950", Slot = "10")]
		public int TWSMHBFUZCL(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x86794E0", Offset = "0x86788E0", VA = "0x1886794E0", Slot = "11")]
		public void DJQRTYPDQTR(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8679AD0", Offset = "0x8678ED0", VA = "0x188679AD0", Slot = "12")]
		public bool XQBPAKMJDVQ(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8679730", Offset = "0x8678B30", VA = "0x188679730", Slot = "13")]
		public void MCFMREYFCCG(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8679680", Offset = "0x8678A80", VA = "0x188679680", Slot = "14")]
		public float GHRMTOZKXPW(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x86797A0", Offset = "0x8678BA0", VA = "0x1886797A0", Slot = "15")]
		public void QLAHSWXMITO(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8679A60", Offset = "0x8678E60", VA = "0x188679A60", Slot = "18")]
		public DateTime XJRQWSYSSOD(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8679980", Offset = "0x8678D80", VA = "0x188679980", Slot = "19")]
		public void UKBSRVYSSKX(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8679390", Offset = "0x8678790", VA = "0x188679390", Slot = "20")]
		public long ADGFIXNPAJS(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x86799F0", Offset = "0x8678DF0", VA = "0x1886799F0", Slot = "21")]
		public void WELNHDOKSJO(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x371D080", Offset = "0x371C480", VA = "0x18371D080", Slot = "22")]
		public a UJHTICSWKBH<a>(string a, a b, HNULQOWVXXS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x371CE30", Offset = "0x371C230", VA = "0x18371CE30", Slot = "23")]
		public void SHATVEOQTEB<b>(string a, b b, HNULQOWVXXS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x371BFC0", Offset = "0x371B3C0", VA = "0x18371BFC0")]
		private c JUDZQDLKJPK<c>(string a, c b, [Optional] HNULQOWVXXS<c> c)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x371B620", Offset = "0x371AA20", VA = "0x18371B620")]
		private void IQBGDWNQQAA<d>(string a, d b, [Optional] HNULQOWVXXS<d> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8679700", Offset = "0x8678B00", VA = "0x188679700", Slot = "16")]
		public string JPHZVEJTRTJ(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x86796D0", Offset = "0x8678AD0", VA = "0x1886796D0", Slot = "17")]
		public void JKXQTBGYWSL(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8679760", Offset = "0x8678B60", VA = "0x188679760")]
		private void NSWZXKWPKPI(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8679780", Offset = "0x8678B80", VA = "0x188679780")]
		private string PGTQZSDCJVM(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8679B00", Offset = "0x8678F00", VA = "0x188679B00", Slot = "24")]
		public void YUPTWGDFNGY(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8679580", Offset = "0x8678980", VA = "0x188679580")]
		private string EIPWKAHISGY(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8679860", Offset = "0x8678C60", VA = "0x188679860", Slot = "25")]
		[AsyncStateMachine(typeof(<Save>d__38))]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8679510", Offset = "0x8678910", VA = "0x188679510")]
		[IteratorStateMachine(typeof(GMGLRROIDKE))]
		private IEnumerator<EXCEMTVEEEU> DKWGNVFOYVK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8679620", Offset = "0x8678A20", VA = "0x188679620")]
		private void ESBBWTTHLSE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8679470", Offset = "0x8678870", VA = "0x188679470")]
		private void CRAUPIWVKBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8679400", Offset = "0x8678800", VA = "0x188679400")]
		private void AGFULGOQWOL(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class VKIKIRFLWAN : BLUTYXFJTHR, UFXYMDCRQHM
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
		private Dictionary<string, string> IBNTFMMONQO;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool FTNBLRPOGMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private string XIQPRXQENAB
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8680EA0", Offset = "0x86802A0", VA = "0x188680EA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private string MFULKILRFAL
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x8680490", Offset = "0x867F890", VA = "0x188680490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Dictionary<string, string> PAAETIHKOVW
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x86802E0", Offset = "0x867F6E0", VA = "0x1886802E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action PPSJNXIREKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		[UnityEngine.Scripting.Preserve]
		public VKIKIRFLWAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "8")]
		public void UOZEIRDCIGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8680A60", Offset = "0x867FE60", VA = "0x188680A60", Slot = "6")]
		public Task RWMNRQQKNNE(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8680390", Offset = "0x867F790", VA = "0x188680390", Slot = "14")]
		public float GHRMTOZKXPW(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8680980", Offset = "0x867FD80", VA = "0x188680980", Slot = "13")]
		public void MCFMREYFCCG(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8680FA0", Offset = "0x86803A0", VA = "0x188680FA0", Slot = "12")]
		public bool XQBPAKMJDVQ(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8680D50", Offset = "0x8680150", VA = "0x188680D50", Slot = "10")]
		public int TWSMHBFUZCL(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8680F30", Offset = "0x8680330", VA = "0x188680F30", Slot = "18")]
		public DateTime XJRQWSYSSOD(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8680DC0", Offset = "0x86801C0", VA = "0x188680DC0", Slot = "19")]
		public void UKBSRVYSSKX(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x86809F0", Offset = "0x867FDF0", VA = "0x1886809F0", Slot = "15")]
		public void QLAHSWXMITO(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8680320", Offset = "0x867F720", VA = "0x188680320", Slot = "11")]
		public void DJQRTYPDQTR(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8680270", Offset = "0x867F670", VA = "0x188680270", Slot = "20")]
		public long ADGFIXNPAJS(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8680E30", Offset = "0x8680230", VA = "0x188680E30", Slot = "21")]
		public void WELNHDOKSJO(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x355AB50", Offset = "0x3559F50", VA = "0x18355AB50", Slot = "22")]
		public a UJHTICSWKBH<a>(string a, a b, HNULQOWVXXS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3559A20", Offset = "0x3558E20", VA = "0x183559A20", Slot = "23")]
		public void SHATVEOQTEB<b>(string a, b b, HNULQOWVXXS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x86805C0", Offset = "0x867F9C0", VA = "0x1886805C0", Slot = "16")]
		public string JPHZVEJTRTJ(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8680520", Offset = "0x867F920", VA = "0x188680520", Slot = "17")]
		public void JKXQTBGYWSL(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8681060", Offset = "0x8680460", VA = "0x188681060", Slot = "24")]
		public void YUPTWGDFNGY(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8680400", Offset = "0x867F800", VA = "0x188680400", Slot = "9")]
		public bool GIEXNMAWZWV(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8680AF0", Offset = "0x867FEF0", VA = "0x188680AF0", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3BE68C0", Offset = "0x3BE5CC0", VA = "0x183BE68C0")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] HNULQOWVXXS<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x3BE7EE0", Offset = "0x3BE72E0", VA = "0x183BE7EE0")]
		private void Set<T>(string propertyName, T value, [Optional] HNULQOWVXXS<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8680670", Offset = "0x867FA70", VA = "0x188680670")]
		private Dictionary<string, string> LBKEKCALIZO()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface UQMTYYLRCUF
	{
		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event Action PPSJNXIREKO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void UOZEIRDCIGI();

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task ORNDZARPKMW(long a);

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool ZNKUBLCMNUG(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool OMHIHNMXEIQ(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool XXJIPFCGZRZ(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		string VNAYXTEXWFG(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		SetResult MWGQQEADNUA(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "9")]
		int ONOHPITRWRU(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "10")]
		SetResult WFSPLVBUZZM(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool YZXVTSNEWJL(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "12")]
		SetResult OKUAYJWNGNX(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "13")]
		float JHVOHHUYGGR(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "14")]
		SetResult JGAIPJEHTEV(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "15")]
		DateTime CRWKDIAKYLC(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "16")]
		SetResult CLVIHZZOSWQ(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "17")]
		long YMPKFZZUCFZ(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "18")]
		SetResult CYSYWIZLABV(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "19")]
		a FPQGUVLUZIK<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "20")]
		SetResult HZOHLRGXAKG<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool PUDVEVDACXY(string a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool ZCUFYWQGQWL(string a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "23")]
		string LLRSVXHFAXI(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "24")]
		SetResult NYXCGSQMTWK(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "25")]
		int RYFEMTDBWOA(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "26")]
		SetResult RPYVSZTISZG(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "27")]
		bool UHETETIKYKT(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "28")]
		SetResult RRBDXRFPXZF(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "29")]
		float LBNXNZUUTAL(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "30")]
		SetResult PTJRJPCZCKP(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "31")]
		DateTime OBZYRYMPJJQ(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "32")]
		SetResult WFHXUMODHKC(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "33")]
		long AZWBQHJIMAN(string a, long b = 0L);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "34")]
		SetResult HIZOGXKPZXP(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void NHACDEDSLAA<e>(HNULQOWVXXS<e> a, [Optional] IEqualityComparer<e> b);

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void LYDPVTGFVMX<f>();

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "37")]
		IDisposable GHQTTFXXTSM();

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void GNGBUNWPFSD(float a);

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "39")]
		Task ESBBWTTHLSE([Optional] CancellationToken a);
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
	public class Preferences : UQMTYYLRCUF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		private abstract class PPIDWQMJYAL
		{
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			protected static readonly HashSet<PPIDWQMJYAL> HBESRHFOWEO;

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x867A3D0", Offset = "0x86797D0", VA = "0x18867A3D0")]
			public static void WNRSQSQUCVQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract void Clear();

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			protected PPIDWQMJYAL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		private class KNSUIPMYLPW<a> : PPIDWQMJYAL
		{
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public static readonly KNSUIPMYLPW<a> LVYKDVFRYUJ;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public HNULQOWVXXS<a> FSTBWEGUUPT
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public IEqualityComparer<a> ROMJFONSKUR
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600012A")]
				[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool FXKJCVIESWG
			{
				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0x521FFC0", Offset = "0x521F3C0", VA = "0x18521FFC0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x5220750", Offset = "0x521FB50", VA = "0x185220750")]
			private KNSUIPMYLPW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x521FFF0", Offset = "0x521F3F0", VA = "0x18521FFF0")]
			public void SHWXSEAJSCT(HNULQOWVXXS<a> a, [Optional] IEqualityComparer<a> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x521FF70", Offset = "0x521F370", VA = "0x18521FF70", Slot = "4")]
			public override void Clear()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		private class KSVLTLZUDYL : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private readonly Preferences QMZPQFRCNYA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private readonly object UCUCCYVDPYO;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x8679CC0", Offset = "0x86790C0", VA = "0x188679CC0")]
			public KSVLTLZUDYL(Preferences a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x8679C90", Offset = "0x8679090", VA = "0x188679C90", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x867D7F0", Offset = "0x867CBF0", VA = "0x18867D7F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x867DAD0", Offset = "0x867CED0", VA = "0x18867DAD0", Slot = "5")]
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
			public UFXYMDCRQHM backingStoreToSave;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x867E480", Offset = "0x867D880", VA = "0x18867E480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x867DB30", Offset = "0x867CF30", VA = "0x18867DB30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x867E000", Offset = "0x867D400", VA = "0x18867E000", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class SWEQSYOHMJH : IEnumerator<EXCEMTVEEEU>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private int JIPOOQUWCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private EXCEMTVEEEU JOTWNIKQVJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public Preferences MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public float IRYCDSRQSCP;

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			private EXCEMTVEEEU RGLTPZKGWZB
			{
				[Cpp2IlInjected.Token(Token = "0x600013B")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x600013D")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xAB07E0", Offset = "0xAAFBE0", VA = "0x180AB07E0")]
			[DebuggerHidden]
			public SWEQSYOHMJH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "5")]
			[DebuggerHidden]
			private void AEBWHPMOWJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x867D760", Offset = "0x867CB60", VA = "0x18867D760", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x867D720", Offset = "0x867CB20", VA = "0x18867D720", Slot = "8")]
			[DebuggerHidden]
			private void MJTKPUASZVA()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly BLUTYXFJTHR FVTXGIIJSWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly BLUTYXFJTHR WWJOHJDPGTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly VMIGKHUQBHV YEFHILVZVKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly WRIIEUEWQVY WECBNBUUWBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly AUPMALMMWNM.CustomSaveHandler TGENKUWEDFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly YPHQWUVMKZC NIKCTJEGIGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly HashSet<UFXYMDCRQHM> GJNGLJEHIHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private Task GRTSGPEXBNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private Dictionary<string, string> BQOFOBDGPKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private VNDHQZCKPIP DQMRIZSEABI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly object WKIADZQOOQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly object JZKTTDPWMGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private long PUOWALRQPJW;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private bool NJIQVMGZDWG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x1714750", Offset = "0x1713B50", VA = "0x181714750")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private CancellationTokenSource MDDBEAQOLCL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xAA3370", Offset = "0xAA2770", VA = "0x180AA3370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xAA3390", Offset = "0xAA2790", VA = "0x180AA3390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action PPSJNXIREKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x867AA60", Offset = "0x8679E60", VA = "0x18867AA60", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x867A600", Offset = "0x8679A00", VA = "0x18867A600", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x867C5F0", Offset = "0x867B9F0", VA = "0x18867C5F0")]
		[CVOOPLRRRUK.Root]
		internal static void TGVIIHXYKSV(XRSJVGYQFTW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x867D390", Offset = "0x867C790", VA = "0x18867D390")]
		[UnityEngine.Scripting.Preserve]
		public Preferences([Inject("Disk")] BLUTYXFJTHR localBackingStore, [Inject("Cloud")] BLUTYXFJTHR cloudBackingStore, [Inject(null)] VMIGKHUQBHV editorBackingStore, [Inject(null)] WRIIEUEWQVY scheduler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x867AC60", Offset = "0x867A060", VA = "0x18867AC60", Slot = "44")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x867AB00", Offset = "0x8679F00", VA = "0x18867AB00")]
		private void DNRBLHIZMDY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x867C810", Offset = "0x867BC10", VA = "0x18867C810", Slot = "6")]
		public void UOZEIRDCIGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x867C0B0", Offset = "0x867B4B0", VA = "0x18867C0B0", Slot = "7")]
		public Task ORNDZARPKMW(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x867AB50", Offset = "0x8679F50", VA = "0x18867AB50")]
		[AsyncStateMachine(typeof(<InitializeForPlayerInternal>d__23))]
		private Task DQJBMCYSYAX(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x867CF80", Offset = "0x867C380", VA = "0x18867CF80")]
		private void YGKBWQQDAKS(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x867CD80", Offset = "0x867C180", VA = "0x18867CD80")]
		private void XJDNVNAPBGL(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x867B920", Offset = "0x867AD20", VA = "0x18867B920")]
		private string LNBSRGINAAC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x867ADC0", Offset = "0x867A1C0", VA = "0x18867ADC0")]
		private void EVSFWVLEMGU(AccountPreferenceBackingStoreTypes a, string b, [Out] BLUTYXFJTHR c, [Out] string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x867B430", Offset = "0x867A830", VA = "0x18867B430")]
		private BLUTYXFJTHR HWQSCFEHEHC(AccountPreferenceBackingStoreTypes a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x867D100", Offset = "0x867C500", VA = "0x18867D100", Slot = "8")]
		public bool ZNKUBLCMNUG(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x867BF60", Offset = "0x867B360", VA = "0x18867BF60", Slot = "9")]
		public bool OMHIHNMXEIQ(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x867CE00", Offset = "0x867C200", VA = "0x18867CE00", Slot = "10")]
		public bool XXJIPFCGZRZ(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x867C880", Offset = "0x867BC80", VA = "0x18867C880", Slot = "11")]
		public string VNAYXTEXWFG(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x867BB30", Offset = "0x867AF30", VA = "0x18867BB30", Slot = "12")]
		public SetResult MWGQQEADNUA(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x867C000", Offset = "0x867B400", VA = "0x18867C000", Slot = "13")]
		public int ONOHPITRWRU(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x867CC00", Offset = "0x867C000", VA = "0x18867CC00", Slot = "14")]
		public SetResult WFSPLVBUZZM(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x867D040", Offset = "0x867C440", VA = "0x18867D040", Slot = "15")]
		public bool YZXVTSNEWJL(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x867BDE0", Offset = "0x867B1E0", VA = "0x18867BDE0", Slot = "16")]
		public SetResult OKUAYJWNGNX(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x867B630", Offset = "0x867AA30", VA = "0x18867B630", Slot = "17")]
		public float JHVOHHUYGGR(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x867B4B0", Offset = "0x867A8B0", VA = "0x18867B4B0", Slot = "18")]
		public SetResult JGAIPJEHTEV(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x867A840", Offset = "0x8679C40", VA = "0x18867A840", Slot = "19")]
		public DateTime CRWKDIAKYLC(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x867A6A0", Offset = "0x8679AA0", VA = "0x18867A6A0", Slot = "20")]
		public SetResult CLVIHZZOSWQ(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x867CFA0", Offset = "0x867C3A0", VA = "0x18867CFA0", Slot = "21")]
		public long YMPKFZZUCFZ(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x867A8E0", Offset = "0x8679CE0", VA = "0x18867A8E0", Slot = "22")]
		public SetResult CYSYWIZLABV(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3916BA0", Offset = "0x3915FA0", VA = "0x183916BA0", Slot = "23")]
		public a FPQGUVLUZIK<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3917690", Offset = "0x3916A90", VA = "0x183917690", Slot = "24")]
		public SetResult HZOHLRGXAKG<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x867C3F0", Offset = "0x867B7F0", VA = "0x18867C3F0", Slot = "25")]
		public bool PUDVEVDACXY(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x867D0F0", Offset = "0x867C4F0", VA = "0x18867D0F0", Slot = "26")]
		public bool ZCUFYWQGQWL(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x867B8B0", Offset = "0x867ACB0", VA = "0x18867B8B0", Slot = "27")]
		public string LLRSVXHFAXI(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x867BD40", Offset = "0x867B140", VA = "0x18867BD40", Slot = "28")]
		public SetResult NYXCGSQMTWK(string a, string b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x867C4B0", Offset = "0x867B8B0", VA = "0x18867C4B0", Slot = "29")]
		public int RYFEMTDBWOA(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x867C450", Offset = "0x867B850", VA = "0x18867C450", Slot = "30")]
		public SetResult RPYVSZTISZG(string a, int b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x867C660", Offset = "0x867BA60", VA = "0x18867C660", Slot = "31")]
		public bool UHETETIKYKT(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x867C480", Offset = "0x867B880", VA = "0x18867C480", Slot = "32")]
		public SetResult RRBDXRFPXZF(string a, bool b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x867B840", Offset = "0x867AC40", VA = "0x18867B840", Slot = "33")]
		public float LBNXNZUUTAL(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x867C3C0", Offset = "0x867B7C0", VA = "0x18867C3C0", Slot = "34")]
		public SetResult PTJRJPCZCKP(string a, float b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x867BD70", Offset = "0x867B170", VA = "0x18867BD70", Slot = "35")]
		public DateTime OBZYRYMPJJQ(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x867CBD0", Offset = "0x867BFD0", VA = "0x18867CBD0", Slot = "36")]
		public SetResult WFHXUMODHKC(string a, DateTime b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x867A590", Offset = "0x8679990", VA = "0x18867A590", Slot = "37")]
		public long AZWBQHJIMAN(string a, long b = 0L)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x867B190", Offset = "0x867A590", VA = "0x18867B190", Slot = "38")]
		public SetResult HIZOGXKPZXP(string a, long b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x867BAD0", Offset = "0x867AED0", VA = "0x18867BAD0")]
		private bool MMBFMTEFJMS(UFXYMDCRQHM a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x867B6E0", Offset = "0x867AAE0", VA = "0x18867B6E0")]
		private bool KRVKUARCJBD(UFXYMDCRQHM a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x867AF60", Offset = "0x867A360", VA = "0x18867AF60")]
		private SetResult EZHMKIIDYZF(UFXYMDCRQHM a, string b, string c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x867C6D0", Offset = "0x867BAD0", VA = "0x18867C6D0")]
		private SetResult UJJOYJNGPJR(UFXYMDCRQHM a, string b, int c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x867C280", Offset = "0x867B680", VA = "0x18867C280")]
		private SetResult OYIDNUUMYUC(UFXYMDCRQHM a, string b, bool c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x867B980", Offset = "0x867AD80", VA = "0x18867B980")]
		private SetResult MKQEVHMBBWE(UFXYMDCRQHM a, string b, float c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x867CA60", Offset = "0x867BE60", VA = "0x18867CA60")]
		private SetResult WDVKHYHTTVV(UFXYMDCRQHM a, string b, DateTime c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x867C920", Offset = "0x867BD20", VA = "0x18867C920")]
		private SetResult VPXIVLPOFDW(UFXYMDCRQHM a, string b, long c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x3917130", Offset = "0x3916530", VA = "0x183917130")]
		private e HMVOEYQXUNX<e>(UFXYMDCRQHM a, string b, e c)
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x39179E0", Offset = "0x3916DE0", VA = "0x1839179E0")]
		private SetResult MNHQUIWKQKB<f>(UFXYMDCRQHM a, string b, f c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3918640", Offset = "0x3917A40", VA = "0x183918640", Slot = "39")]
		public void NHACDEDSLAA<g>(HNULQOWVXXS<g> a, [Optional] IEqualityComparer<g> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x3917950", Offset = "0x3916D50", VA = "0x183917950", Slot = "40")]
		public void LYDPVTGFVMX<h>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x867C520", Offset = "0x867B920", VA = "0x18867C520")]
		[AsyncStateMachine(typeof(<Save>d__77))]
		private void Save(UFXYMDCRQHM backingStoreToSave)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x867ACD0", Offset = "0x867A0D0", VA = "0x18867ACD0", Slot = "43")]
		[AsyncStateMachine(typeof(<SaveImmediate>d__78))]
		public Task ESBBWTTHLSE([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x867D1B0", Offset = "0x867C5B0", VA = "0x18867D1B0")]
		private void ZOICIDIQSGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x867B0B0", Offset = "0x867A4B0", VA = "0x18867B0B0", Slot = "41")]
		public IDisposable GHQTTFXXTSM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x867B180", Offset = "0x867A580", VA = "0x18867B180", Slot = "42")]
		public void GNGBUNWPFSD(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x867B1C0", Offset = "0x867A5C0", VA = "0x18867B1C0")]
		private void HUJNWDLARFV(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x867BCC0", Offset = "0x867B0C0", VA = "0x18867BCC0")]
		[IteratorStateMachine(typeof(SWEQSYOHMJH))]
		private IEnumerator<EXCEMTVEEEU> NEFDJAOMSUR(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x867ACA0", Offset = "0x867A0A0", VA = "0x18867ACA0")]
		[CompilerGenerated]
		private void EOENLXDYBCK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class CKPCRDIVIZN
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8679170", Offset = "0x8678570", VA = "0x188679170")]
		public static string XTBIJLEEYHO(this UQMTYYLRCUF a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8678FD0", Offset = "0x86783D0", VA = "0x188678FD0")]
		public static byte[] KKVIBDJWDQM(this UQMTYYLRCUF a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8678EC0", Offset = "0x86782C0", VA = "0x188678EC0")]
		public static SetResult JDPGMYLCJFK(this UQMTYYLRCUF a, string b, ReadOnlySpan<byte> value)
		{
			return default(SetResult);
		}
	}
}
namespace RecRoom.Preferences.CustomParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class MVDLXQAXHFE : ACNPEQLTMWK<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static MVDLXQAXHFE LVYKDVFRYUJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x8679EC0", Offset = "0x86792C0", VA = "0x188679EC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8679F10", Offset = "0x8679310", VA = "0x188679F10", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x867A000", Offset = "0x8679400", VA = "0x18867A000", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x867A310", Offset = "0x8679710", VA = "0x18867A310")]
		public MVDLXQAXHFE()
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
