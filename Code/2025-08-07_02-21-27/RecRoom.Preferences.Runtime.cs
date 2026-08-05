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
namespace _AssemblyRegistry.RecRoom_Preferences_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8E49C20", Offset = "0x8E48820", VA = "0x188E49C20", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2C401F0", Offset = "0x2C3EDF0", VA = "0x182C401F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Preferences
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum AccountPreferenceBackingStoreTypes : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		CLOUD,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		DISK
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	internal static class IZPSGVKTWFP
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		internal delegate void CustomSaveHandler(DPYORKABOGH backingStore);

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E442C0", Offset = "0x8E42EC0", VA = "0x188E442C0")]
		private static void KRFGMWKKCCS(DPYORKABOGH a, CustomSaveHandler b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8E44340", Offset = "0x8E42F40", VA = "0x188E44340")]
		public static bool KVGVIQPMEGE(this DPYORKABOGH a, string b, [Optional] CustomSaveHandler c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8E44170", Offset = "0x8E42D70", VA = "0x188E44170")]
		public static SetResult GYINVTHVPIH(this DPYORKABOGH a, string b, string c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8E445E0", Offset = "0x8E431E0", VA = "0x188E445E0")]
		public static SetResult YAZWBBQFNGV(this DPYORKABOGH a, string b, int c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8E44030", Offset = "0x8E42C30", VA = "0x188E44030")]
		public static SetResult BMHUACGTEOC(this DPYORKABOGH a, string b, bool c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8E44720", Offset = "0x8E43320", VA = "0x188E44720")]
		public static SetResult YXVWJXBRCPA(this DPYORKABOGH a, string b, float c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8E43EC0", Offset = "0x8E42AC0", VA = "0x188E43EC0")]
		public static SetResult ASKFMUGHNLB(this DPYORKABOGH a, string b, DateTime c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8E444A0", Offset = "0x8E430A0", VA = "0x188E444A0")]
		public static SetResult XHICTGCZBUM(this DPYORKABOGH a, string b, long c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class ICWMWIYICVC : CLOCYVETOME, DPYORKABOGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly QYUBPQVIAUV FJGWGZDCIPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly Dictionary<string, byte> TXLVFJPGZOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Dictionary<string, string> EIFCTRNWTTP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool VAIKGMZRCIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Dictionary<string, string> SKCFKLJWOOV
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8E427B0", Offset = "0x8E413B0", VA = "0x188E427B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action NCCLOGKOKRF
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8E43E20", Offset = "0x8E42A20", VA = "0x188E43E20")]
		[UnityEngine.Scripting.Preserve]
		public ICWMWIYICVC([Inject(null)] QYUBPQVIAUV unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "8")]
		public void UOYLZEXSXHV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8E43CC0", Offset = "0x8E428C0", VA = "0x188E43CC0")]
		private DirectoryInfo XPZKGUOBSCH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8E43C30", Offset = "0x8E42830", VA = "0x188E43C30", Slot = "6")]
		public Task XNYWESRZNBB(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8E434F0", Offset = "0x8E420F0", VA = "0x188E434F0", Slot = "14")]
		public float OUHRUHMBODV(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8E43710", Offset = "0x8E42310", VA = "0x188E43710", Slot = "13")]
		public void SEWVFJCHDOX(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8E435D0", Offset = "0x8E421D0", VA = "0x188E435D0", Slot = "12")]
		public bool PVEARDDDPZF(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8E426D0", Offset = "0x8E412D0", VA = "0x188E426D0", Slot = "10")]
		public int GSCAFFHZXSA(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8E43AC0", Offset = "0x8E426C0", VA = "0x188E43AC0", Slot = "18")]
		public DateTime UISPXBIGNKS(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8E42CE0", Offset = "0x8E418E0", VA = "0x188E42CE0", Slot = "19")]
		public void NNDDUYYSVVQ(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8E42740", Offset = "0x8E41340", VA = "0x188E42740", Slot = "15")]
		public void HEIHGIJXPID(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8E43560", Offset = "0x8E42160", VA = "0x188E43560", Slot = "11")]
		public void PLMMWHERLKE(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8E423B0", Offset = "0x8E40FB0", VA = "0x188E423B0", Slot = "20")]
		public long CQBXYCGYEOF(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8E43DB0", Offset = "0x8E429B0", VA = "0x188E43DB0", Slot = "21")]
		public void YXODQXDERER(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x38FFD10", Offset = "0x38FE910", VA = "0x1838FFD10", Slot = "22")]
		public a ZGRKTYJPCGQ<a>(string a, a b, EDYEQLIPZND<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x38FD5A0", Offset = "0x38FC1A0", VA = "0x1838FD5A0", Slot = "23")]
		public void CJNJLCYJFBS<b>(string a, b b, EDYEQLIPZND<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8E42420", Offset = "0x8E41020", VA = "0x188E42420", Slot = "16")]
		public string CYNWVUHUSXE(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8E436A0", Offset = "0x8E422A0", VA = "0x188E436A0", Slot = "17")]
		public void RYLBEVCMCEG(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8E42B90", Offset = "0x8E41790", VA = "0x188E42B90", Slot = "24")]
		public void KLWTIKPNWRH(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8E42320", Offset = "0x8E40F20", VA = "0x188E42320", Slot = "9")]
		public bool ASQVQGAAPGS(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8E43780", Offset = "0x8E42380", VA = "0x188E43780", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8E427F0", Offset = "0x8E413F0", VA = "0x188E427F0")]
		private void JOSOTDTBGON(DirectoryInfo a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8E424D0", Offset = "0x8E410D0", VA = "0x188E424D0")]
		private static string DEQTUKKSDRC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8E43B30", Offset = "0x8E42730", VA = "0x188E43B30")]
		private static string WGDFVASQBLT(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3BF0BF0", Offset = "0x3BEF7F0", VA = "0x183BF0BF0")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] EDYEQLIPZND<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3BF21C0", Offset = "0x3BF0DC0", VA = "0x183BF21C0")]
		private void Set<T>(string propertyName, T value, [Optional] EDYEQLIPZND<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8E42D50", Offset = "0x8E41950", VA = "0x188E42D50")]
		private Dictionary<string, string> NTYFRAWKXFX()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal static class WEDIQISGUFM
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8E49AD0", Offset = "0x8E486D0", VA = "0x188E49AD0")]
		[IFIZWETSKCB.Root]
		internal static void IFIZWETSKCB(DiContainer a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class FGUEIPWGQLR : BCRZLHHGGDA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8E41530", Offset = "0x8E40130", VA = "0x188E41530")]
		[UnityEngine.Scripting.Preserve]
		public FGUEIPWGQLR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class BCRZLHHGGDA : CLOCYVETOME, DPYORKABOGH, VPTEZVETZTI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly Dictionary<string, object> YLJBBGXEMTQ;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool VAIKGMZRCIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action NCCLOGKOKRF
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "8")]
		public void UOYLZEXSXHV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8E41440", Offset = "0x8E40040", VA = "0x188E41440", Slot = "6")]
		public Task XNYWESRZNBB(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8E40ED0", Offset = "0x8E3FAD0", VA = "0x188E40ED0", Slot = "9")]
		public bool ASQVQGAAPGS(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8E40FF0", Offset = "0x8E3FBF0", VA = "0x188E40FF0", Slot = "10")]
		public int GSCAFFHZXSA(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8E411D0", Offset = "0x8E3FDD0", VA = "0x188E411D0", Slot = "11")]
		public void PLMMWHERLKE(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8E41230", Offset = "0x8E3FE30", VA = "0x188E41230", Slot = "12")]
		public bool PVEARDDDPZF(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8E412F0", Offset = "0x8E3FEF0", VA = "0x188E412F0", Slot = "13")]
		public void SEWVFJCHDOX(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8E41170", Offset = "0x8E3FD70", VA = "0x188E41170", Slot = "14")]
		public float OUHRUHMBODV(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8E41050", Offset = "0x8E3FC50", VA = "0x188E41050", Slot = "15")]
		public void HEIHGIJXPID(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8E40F90", Offset = "0x8E3FB90", VA = "0x188E40F90", Slot = "16")]
		public string CYNWVUHUSXE(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8E41290", Offset = "0x8E3FE90", VA = "0x188E41290", Slot = "17")]
		public void RYLBEVCMCEG(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8E413E0", Offset = "0x8E3FFE0", VA = "0x188E413E0", Slot = "18")]
		public DateTime UISPXBIGNKS(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8E41110", Offset = "0x8E3FD10", VA = "0x188E41110", Slot = "19")]
		public void NNDDUYYSVVQ(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8E40F30", Offset = "0x8E3FB30", VA = "0x188E40F30", Slot = "20")]
		public long CQBXYCGYEOF(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8E414D0", Offset = "0x8E400D0", VA = "0x188E414D0", Slot = "21")]
		public void YXODQXDERER(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x38FBB80", Offset = "0x38FA780", VA = "0x1838FBB80", Slot = "22")]
		public a ZGRKTYJPCGQ<a>(string a, a b, EDYEQLIPZND<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x38FA8E0", Offset = "0x38F94E0", VA = "0x1838FA8E0", Slot = "23")]
		public void CJNJLCYJFBS<b>(string a, b b, EDYEQLIPZND<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x38FAB40", Offset = "0x38F9740", VA = "0x1838FAB40")]
		public T Get<T>(string propertyName, T defaultValue)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x38FB5D0", Offset = "0x38FA1D0", VA = "0x1838FB5D0")]
		public void Set<T>(string propertyName, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8E410B0", Offset = "0x8E3FCB0", VA = "0x188E410B0", Slot = "24")]
		public void KLWTIKPNWRH(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8E41350", Offset = "0x8E3FF50", VA = "0x188E41350", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8E41530", Offset = "0x8E40130", VA = "0x188E41530")]
		public BCRZLHHGGDA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public abstract class KAAQQSRGYGB<a> where a : DPYORKABOGH
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly HashSet<KAAQQSRGYGB<a>> TKNWTJKTVGK;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x57EDE80", Offset = "0x57ECA80", VA = "0x1857EDE80")]
		protected KAAQQSRGYGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void Clear();

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void MNAPBDGTASV(string a);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x57ED7C0", Offset = "0x57EC3C0", VA = "0x1857ED7C0")]
		public static void SLLFWGHAQKF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x57ED5E0", Offset = "0x57EC1E0", VA = "0x1857ED5E0")]
		public static void DPMWUAAPNIN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class JZKVYYJOVYA<a, b> : KAAQQSRGYGB<a> where a : DPYORKABOGH
	{
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly JZKVYYJOVYA<a, b> ERMGBLVPTJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<string, b> RBNAJCOTPSB;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5736630", Offset = "0x5735230", VA = "0x185736630")]
		public bool KCRQOJGIJUH(string a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5736AA0", Offset = "0x57356A0", VA = "0x185736AA0")]
		public void Store(string cacheKey, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5736540", Offset = "0x5735140", VA = "0x185736540", Slot = "4")]
		protected override void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5736710", Offset = "0x5735310", VA = "0x185736710", Slot = "5")]
		protected override void MNAPBDGTASV(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5736C60", Offset = "0x5735860", VA = "0x185736C60")]
		public JZKVYYJOVYA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface DPYORKABOGH
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool VAIKGMZRCIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void UOYLZEXSXHV();

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool ASQVQGAAPGS(string a);

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int GSCAFFHZXSA(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void PLMMWHERLKE(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool PVEARDDDPZF(string a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void SEWVFJCHDOX(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float OUHRUHMBODV(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void HEIHGIJXPID(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		string CYNWVUHUSXE(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void RYLBEVCMCEG(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		DateTime UISPXBIGNKS(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void NNDDUYYSVVQ(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "13")]
		long CQBXYCGYEOF(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void YXODQXDERER(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "15")]
		a ZGRKTYJPCGQ<a>(string a, a b, EDYEQLIPZND<a> c);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void CJNJLCYJFBS<b>(string a, b b, EDYEQLIPZND<b> c);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void KLWTIKPNWRH(string a);

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Task Save([Optional] CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface CLOCYVETOME : DPYORKABOGH
	{
		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action NCCLOGKOKRF;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task XNYWESRZNBB(long a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface VPTEZVETZTI : DPYORKABOGH
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class TGKOWDWLTZO : CLOCYVETOME, DPYORKABOGH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct <Save>d__38 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public TGKOWDWLTZO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x8E48ED0", Offset = "0x8E47AD0", VA = "0x188E48ED0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8E49290", Offset = "0x8E47E90", VA = "0x188E49290", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class KXGTEKHBLQX : IEnumerator<UGECMBPSTCZ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private UGECMBPSTCZ DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public TGKOWDWLTZO VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private UGECMBPSTCZ RADPMWRJHYU
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public KXGTEKHBLQX(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8E44870", Offset = "0x8E43470", VA = "0x188E44870", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8E448E0", Offset = "0x8E434E0", VA = "0x188E448E0", Slot = "8")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly QYUBPQVIAUV FJGWGZDCIPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool NEEOTWNUUZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private bool POEYKQIVJVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private PABQSBFBGZX LVOZVQMMXRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private GEUHFRHGIWS QKNQIDNLWMM;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool VAIKGMZRCIN
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action NCCLOGKOKRF
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8E48550", Offset = "0x8E47150", VA = "0x188E48550")]
		[UnityEngine.Scripting.Preserve]
		public TGKOWDWLTZO([Inject(null)] QYUBPQVIAUV unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "8")]
		public void UOYLZEXSXHV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8E483E0", Offset = "0x8E46FE0", VA = "0x188E483E0", Slot = "6")]
		public Task XNYWESRZNBB(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2141380", Offset = "0x213FF80", VA = "0x182141380")]
		private static int JKIXULWORIJ(bool a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8E47D70", Offset = "0x8E46970", VA = "0x188E47D70", Slot = "9")]
		public bool ASQVQGAAPGS(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8E47E90", Offset = "0x8E46A90", VA = "0x188E47E90", Slot = "10")]
		public int GSCAFFHZXSA(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8E48130", Offset = "0x8E46D30", VA = "0x188E48130", Slot = "11")]
		public void PLMMWHERLKE(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8E48160", Offset = "0x8E46D60", VA = "0x188E48160", Slot = "12")]
		public bool PVEARDDDPZF(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8E481C0", Offset = "0x8E46DC0", VA = "0x188E481C0", Slot = "13")]
		public void SEWVFJCHDOX(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8E48100", Offset = "0x8E46D00", VA = "0x188E48100", Slot = "14")]
		public float OUHRUHMBODV(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8E47EC0", Offset = "0x8E46AC0", VA = "0x188E47EC0", Slot = "15")]
		public void HEIHGIJXPID(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8E482E0", Offset = "0x8E46EE0", VA = "0x188E482E0", Slot = "18")]
		public DateTime UISPXBIGNKS(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8E48020", Offset = "0x8E46C20", VA = "0x188E48020", Slot = "19")]
		public void NNDDUYYSVVQ(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8E47D90", Offset = "0x8E46990", VA = "0x188E47D90", Slot = "20")]
		public long CQBXYCGYEOF(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8E484E0", Offset = "0x8E470E0", VA = "0x188E484E0", Slot = "21")]
		public void YXODQXDERER(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x4037050", Offset = "0x4035C50", VA = "0x184037050", Slot = "22")]
		public a ZGRKTYJPCGQ<a>(string a, a b, EDYEQLIPZND<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x40355C0", Offset = "0x40341C0", VA = "0x1840355C0", Slot = "23")]
		public void CJNJLCYJFBS<b>(string a, b b, EDYEQLIPZND<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4035800", Offset = "0x4034400", VA = "0x184035800")]
		private c EJSOMGTPHKR<c>(string a, c b, [Optional] EDYEQLIPZND<c> c)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x40366A0", Offset = "0x40352A0", VA = "0x1840366A0")]
		private void NSCJHBTBQJT<d>(string a, d b, [Optional] EDYEQLIPZND<d> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8E47E00", Offset = "0x8E46A00", VA = "0x188E47E00", Slot = "16")]
		public string CYNWVUHUSXE(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8E48190", Offset = "0x8E46D90", VA = "0x188E48190", Slot = "17")]
		public void RYLBEVCMCEG(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8E483C0", Offset = "0x8E46FC0", VA = "0x188E483C0")]
		private void VFWIPTAZRIP(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8E47D50", Offset = "0x8E46950", VA = "0x188E47D50")]
		private string AFMMSTIQYPZ(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8E47EF0", Offset = "0x8E46AF0", VA = "0x188E47EF0", Slot = "24")]
		public void KLWTIKPNWRH(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8E47F80", Offset = "0x8E46B80", VA = "0x188E47F80")]
		private string KNOHVLYCCHT(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8E481F0", Offset = "0x8E46DF0", VA = "0x188E481F0", Slot = "25")]
		[AsyncStateMachine(typeof(<Save>d__38))]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8E48350", Offset = "0x8E46F50", VA = "0x188E48350")]
		[IteratorStateMachine(typeof(KXGTEKHBLQX))]
		private IEnumerator<UGECMBPSTCZ> UTMLCEJCYDD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8E47E30", Offset = "0x8E46A30", VA = "0x188E47E30")]
		private void EYLODXWILUJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8E48470", Offset = "0x8E47070", VA = "0x188E48470")]
		private void YFODIOXSVCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8E48090", Offset = "0x8E46C90", VA = "0x188E48090")]
		private void OBEMWYVNXEK(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class BNASUFVBXPE : CLOCYVETOME, DPYORKABOGH
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private struct KVP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public string k;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public string v;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private struct KVPs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public KVP[] kvps;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private Dictionary<string, string> EIFCTRNWTTP;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool VAIKGMZRCIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private string IGGDTQFVHLU
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8E41F00", Offset = "0x8E40B00", VA = "0x188E41F00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Dictionary<string, string> SKCFKLJWOOV
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x8E41840", Offset = "0x8E40440", VA = "0x188E41840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action NCCLOGKOKRF
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		[UnityEngine.Scripting.Preserve]
		public BNASUFVBXPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "8")]
		public void UOYLZEXSXHV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8E42220", Offset = "0x8E40E20", VA = "0x188E42220", Slot = "6")]
		public Task XNYWESRZNBB(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8E41C40", Offset = "0x8E40840", VA = "0x188E41C40", Slot = "14")]
		public float OUHRUHMBODV(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8E41E90", Offset = "0x8E40A90", VA = "0x188E41E90", Slot = "13")]
		public void SEWVFJCHDOX(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8E41D20", Offset = "0x8E40920", VA = "0x188E41D20", Slot = "12")]
		public bool PVEARDDDPZF(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8E41760", Offset = "0x8E40360", VA = "0x188E41760", Slot = "10")]
		public int GSCAFFHZXSA(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8E421B0", Offset = "0x8E40DB0", VA = "0x188E421B0", Slot = "18")]
		public DateTime UISPXBIGNKS(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8E41940", Offset = "0x8E40540", VA = "0x188E41940", Slot = "19")]
		public void NNDDUYYSVVQ(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8E417D0", Offset = "0x8E403D0", VA = "0x188E417D0", Slot = "15")]
		public void HEIHGIJXPID(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8E41CB0", Offset = "0x8E408B0", VA = "0x188E41CB0", Slot = "11")]
		public void PLMMWHERLKE(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8E41640", Offset = "0x8E40240", VA = "0x188E41640", Slot = "20")]
		public long CQBXYCGYEOF(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8E422B0", Offset = "0x8E40EB0", VA = "0x188E422B0", Slot = "21")]
		public void YXODQXDERER(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x38FFD10", Offset = "0x38FE910", VA = "0x1838FFD10", Slot = "22")]
		public a ZGRKTYJPCGQ<a>(string a, a b, EDYEQLIPZND<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x38FD5A0", Offset = "0x38FC1A0", VA = "0x1838FD5A0", Slot = "23")]
		public void CJNJLCYJFBS<b>(string a, b b, EDYEQLIPZND<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8E416B0", Offset = "0x8E402B0", VA = "0x188E416B0", Slot = "16")]
		public string CYNWVUHUSXE(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8E41DF0", Offset = "0x8E409F0", VA = "0x188E41DF0", Slot = "17")]
		public void RYLBEVCMCEG(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8E41880", Offset = "0x8E40480", VA = "0x188E41880", Slot = "24")]
		public void KLWTIKPNWRH(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8E415B0", Offset = "0x8E401B0", VA = "0x188E415B0", Slot = "9")]
		public bool ASQVQGAAPGS(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8E41F90", Offset = "0x8E40B90", VA = "0x188E41F90", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x38FD7B0", Offset = "0x38FC3B0", VA = "0x1838FD7B0")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] EDYEQLIPZND<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x38FED00", Offset = "0x38FD900", VA = "0x1838FED00")]
		private void Set<T>(string propertyName, T value, [Optional] EDYEQLIPZND<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8E419B0", Offset = "0x8E405B0", VA = "0x188E419B0")]
		private Dictionary<string, string> NTYFRAWKXFX()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface PPDHWZWSJQC
	{
		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event Action NCCLOGKOKRF;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void UOYLZEXSXHV();

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task EBRLCVCRATL(long a);

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool ZNVHJHZSJTT(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool QPHAEKSUIEF(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool LJAOEKIRQEM(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		string DPTTPPMDFQP(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "8")]
		SetResult XPFTYJWAPFJ(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "9")]
		int BAOAJXJFYCP(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "10")]
		SetResult JYKUYVEPATR(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool PRPTJQRUFNY(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		SetResult IPHLHXAGGEK(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "13")]
		float TDYDZUHWPFC(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "14")]
		SetResult BILOSOFMIBS(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "15")]
		DateTime DLSZXMSJZOH(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "16")]
		SetResult AEUKEXSVPTR(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "17")]
		long GLQXPISFBYQ(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "18")]
		SetResult EDHMFHZVOVO(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "19")]
		a XJRODDVFBKB<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "20")]
		SetResult KMJLAQNCPPD<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool BILMLJZHPSZ(string a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool XXBBQKCQNCS(string a);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "23")]
		string GQHPYTFJRXF(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "24")]
		SetResult CGWHOWWNNSD(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "25")]
		int BWIEGUXRPAT(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "26")]
		SetResult WJMMOBOOXQX(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "27")]
		bool NCWCGHVZKEC(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "28")]
		SetResult XAQTJTMZHKO(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "29")]
		float QAWOXVYCQBC(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "30")]
		SetResult IAWOQESIFEM(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "31")]
		DateTime APEGEMRBHCL(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "32")]
		SetResult BTKUNINUOGT(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "33")]
		long FDDHYKLLKXK(string a, long b = 0L);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "34")]
		SetResult XNEDIKYUPUQ(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void XMPRHBLSTAH<e>(EDYEQLIPZND<e> a, [Optional] IEqualityComparer<e> b);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void DRCLQVYTQVO<f>();

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "37")]
		IDisposable RTDIZNYIRGF();

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void GDDCNYVEJWS(float a);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "39")]
		Task EYLODXWILUJ([Optional] CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum SetResult : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Unchanged,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		New,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Changed
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class Preferences : PPDHWZWSJQC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private abstract class QFCHJGOBFVO
		{
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			protected static readonly HashSet<QFCHJGOBFVO> QKLMMIZVAGP;

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x8E47B80", Offset = "0x8E46780", VA = "0x188E47B80")]
			public static void DPMWUAAPNIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract void Clear();

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			protected QFCHJGOBFVO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private class JDBDHHYFGVN<a> : QFCHJGOBFVO
		{
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public static readonly JDBDHHYFGVN<a> CFGULCWBBYG;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public EDYEQLIPZND<a> HIJBDCXWAPE
			{
				[Cpp2IlInjected.Token(Token = "0x6000123")]
				[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000124")]
				[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public IEqualityComparer<a> BRLALTWGAYG
			{
				[Cpp2IlInjected.Token(Token = "0x6000125")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0xB13A60", Offset = "0xB12660", VA = "0x180B13A60")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public bool KHWFVSKQMAR
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x56361B0", Offset = "0x5634DB0", VA = "0x1856361B0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x5636620", Offset = "0x5635220", VA = "0x185636620")]
			private JDBDHHYFGVN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x5635CD0", Offset = "0x56348D0", VA = "0x185635CD0")]
			public void Register(EDYEQLIPZND<a> parser, [Optional] IEqualityComparer<a> equalityComparer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x5635C80", Offset = "0x5634880", VA = "0x185635C80", Slot = "4")]
			public override void Clear()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class VUYLMQNNPWE : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private readonly Preferences IDMCMVUIDDT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private readonly object SDRZYZSKCZN;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x8E49A20", Offset = "0x8E48620", VA = "0x188E49A20")]
			public VUYLMQNNPWE(Preferences a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x8E499F0", Offset = "0x8E485F0", VA = "0x188E499F0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private struct <InitializeForPlayerInternal>d__23 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public Preferences <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public long playerAccountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x8E48650", Offset = "0x8E47250", VA = "0x188E48650", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x8E48940", Offset = "0x8E47540", VA = "0x188E48940", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private struct <Save>d__77 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public Preferences <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public DPYORKABOGH backingStoreToSave;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x8E492F0", Offset = "0x8E47EF0", VA = "0x188E492F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private struct <SaveImmediate>d__78 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public Preferences <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x8E489A0", Offset = "0x8E475A0", VA = "0x188E489A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x8E48E70", Offset = "0x8E47A70", VA = "0x188E48E70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class NLLCJVTXLLA : IEnumerator<UGECMBPSTCZ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private UGECMBPSTCZ DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public Preferences VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public float XHWKOWORCCW;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private UGECMBPSTCZ RADPMWRJHYU
			{
				[Cpp2IlInjected.Token(Token = "0x6000137")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x6000139")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public NLLCJVTXLLA(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x8E44920", Offset = "0x8E43520", VA = "0x188E44920", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x8E449B0", Offset = "0x8E435B0", VA = "0x188E449B0", Slot = "8")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly CLOCYVETOME OWIAECSWWPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly CLOCYVETOME THZNFTFWNII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly VPTEZVETZTI XUNGYAYGLTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly PABQSBFBGZX LVOZVQMMXRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly IZPSGVKTWFP.CustomSaveHandler DRPTMPUVCOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly SVJYJIPYDON RZINLCBPDYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly HashSet<DPYORKABOGH> EUDMAAUCGMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Task QBUGDZDTVUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private Dictionary<string, string> RODZTUVKOIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private GEUHFRHGIWS VTGQTHZJNFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly object SMQIGLJCCDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly object BBDEOZLGSTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private long OSSRDBIWUXF;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private bool WEQCLXJRTGN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1D40FE0", Offset = "0x1D3FBE0", VA = "0x181D40FE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private CancellationTokenSource KMJBTUTGVSC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xB13B30", Offset = "0xB12730", VA = "0x180B13B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xB13B40", Offset = "0xB12740", VA = "0x180B13B40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action NCCLOGKOKRF
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x8E44F30", Offset = "0x8E43B30", VA = "0x188E44F30", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x8E468E0", Offset = "0x8E454E0", VA = "0x188E468E0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8E46870", Offset = "0x8E45470", VA = "0x188E46870")]
		[IFIZWETSKCB.Root]
		internal static void RIWNJSDCBRY(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8E477F0", Offset = "0x8E463F0", VA = "0x188E477F0")]
		[UnityEngine.Scripting.Preserve]
		public Preferences([Inject("Disk")] CLOCYVETOME localBackingStore, [Inject("Cloud")] CLOCYVETOME cloudBackingStore, [Inject(null)] VPTEZVETZTI editorBackingStore, [Inject(null)] PABQSBFBGZX scheduler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8E45520", Offset = "0x8E44120", VA = "0x188E45520", Slot = "44")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8E476F0", Offset = "0x8E462F0", VA = "0x188E476F0")]
		private void YOOELAEOCDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8E46F20", Offset = "0x8E45B20", VA = "0x188E46F20", Slot = "6")]
		public void UOYLZEXSXHV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8E45560", Offset = "0x8E44160", VA = "0x188E45560", Slot = "7")]
		public Task EBRLCVCRATL(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8E47170", Offset = "0x8E45D70", VA = "0x188E47170")]
		[AsyncStateMachine(typeof(<InitializeForPlayerInternal>d__23))]
		private Task VOKUIQEITBY(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8E453B0", Offset = "0x8E43FB0", VA = "0x188E453B0")]
		private void DQKMDHONUAD(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8E472B0", Offset = "0x8E45EB0", VA = "0x188E472B0")]
		private void WKJOHDUPUCO(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8E46EC0", Offset = "0x8E45AC0", VA = "0x188E46EC0")]
		private string UFHUVVGVMXH(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8E46D20", Offset = "0x8E45920", VA = "0x188E46D20")]
		private void TPELNJVJQQR(AccountPreferenceBackingStoreTypes a, string b, [Out] CLOCYVETOME c, [Out] string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8E466E0", Offset = "0x8E452E0", VA = "0x188E466E0")]
		private CLOCYVETOME PSPUIHLPNNL(AccountPreferenceBackingStoreTypes a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8E47740", Offset = "0x8E46340", VA = "0x188E47740", Slot = "8")]
		public bool ZNVHJHZSJTT(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8E467D0", Offset = "0x8E453D0", VA = "0x188E467D0", Slot = "9")]
		public bool QPHAEKSUIEF(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8E46270", Offset = "0x8E44E70", VA = "0x188E46270", Slot = "10")]
		public bool LJAOEKIRQEM(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8E45310", Offset = "0x8E43F10", VA = "0x188E45310", Slot = "11")]
		public string DPTTPPMDFQP(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8E474D0", Offset = "0x8E460D0", VA = "0x188E474D0", Slot = "12")]
		public SetResult XPFTYJWAPFJ(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8E44C00", Offset = "0x8E43800", VA = "0x188E44C00", Slot = "13")]
		public int BAOAJXJFYCP(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8E45FB0", Offset = "0x8E44BB0", VA = "0x188E45FB0", Slot = "14")]
		public SetResult JYKUYVEPATR(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8E46630", Offset = "0x8E45230", VA = "0x188E46630", Slot = "15")]
		public bool PRPTJQRUFNY(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8E45E30", Offset = "0x8E44A30", VA = "0x188E45E30", Slot = "16")]
		public SetResult IPHLHXAGGEK(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8E46C70", Offset = "0x8E45870", VA = "0x188E46C70", Slot = "17")]
		public float TDYDZUHWPFC(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8E44D10", Offset = "0x8E43910", VA = "0x188E44D10", Slot = "18")]
		public SetResult BILOSOFMIBS(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8E45270", Offset = "0x8E43E70", VA = "0x188E45270", Slot = "19")]
		public DateTime DLSZXMSJZOH(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8E449F0", Offset = "0x8E435F0", VA = "0x188E449F0", Slot = "20")]
		public SetResult AEUKEXSVPTR(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8E45CF0", Offset = "0x8E448F0", VA = "0x188E45CF0", Slot = "21")]
		public long GLQXPISFBYQ(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8E45730", Offset = "0x8E44330", VA = "0x188E45730", Slot = "22")]
		public SetResult EDHMFHZVOVO(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3EA96E0", Offset = "0x3EA82E0", VA = "0x183EA96E0", Slot = "23")]
		public a XJRODDVFBKB<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3EA8EE0", Offset = "0x3EA7AE0", VA = "0x183EA8EE0", Slot = "24")]
		public SetResult KMJLAQNCPPD<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8E44CB0", Offset = "0x8E438B0", VA = "0x188E44CB0", Slot = "25")]
		public bool BILMLJZHPSZ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8E47660", Offset = "0x8E46260", VA = "0x188E47660", Slot = "26")]
		public bool XXBBQKCQNCS(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8E45D90", Offset = "0x8E44990", VA = "0x188E45D90", Slot = "27")]
		public string GQHPYTFJRXF(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8E44FD0", Offset = "0x8E43BD0", VA = "0x188E44FD0", Slot = "28")]
		public SetResult CGWHOWWNNSD(string a, string b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8E44EC0", Offset = "0x8E43AC0", VA = "0x188E44EC0", Slot = "29")]
		public int BWIEGUXRPAT(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8E47280", Offset = "0x8E45E80", VA = "0x188E47280", Slot = "30")]
		public SetResult WJMMOBOOXQX(string a, int b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8E46420", Offset = "0x8E45020", VA = "0x188E46420", Slot = "31")]
		public bool NCWCGHVZKEC(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8E47470", Offset = "0x8E46070", VA = "0x188E47470", Slot = "32")]
		public SetResult XAQTJTMZHKO(string a, bool b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8E46760", Offset = "0x8E45360", VA = "0x188E46760", Slot = "33")]
		public float QAWOXVYCQBC(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8E45E00", Offset = "0x8E44A00", VA = "0x188E45E00", Slot = "34")]
		public SetResult IAWOQESIFEM(string a, float b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8E44B90", Offset = "0x8E43790", VA = "0x188E44B90", Slot = "35")]
		public DateTime APEGEMRBHCL(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8E44E90", Offset = "0x8E43A90", VA = "0x188E44E90", Slot = "36")]
		public SetResult BTKUNINUOGT(string a, DateTime b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8E45B00", Offset = "0x8E44700", VA = "0x188E45B00", Slot = "37")]
		public long FDDHYKLLKXK(string a, long b = 0L)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8E474A0", Offset = "0x8E460A0", VA = "0x188E474A0", Slot = "38")]
		public SetResult XNEDIKYUPUQ(string a, long b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8E46490", Offset = "0x8E45090", VA = "0x188E46490")]
		private bool OYAMGIRKEZR(DPYORKABOGH a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8E459A0", Offset = "0x8E445A0", VA = "0x188E459A0")]
		private bool FADNECEIMLM(DPYORKABOGH a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8E46980", Offset = "0x8E45580", VA = "0x188E46980")]
		private SetResult RRAGTAFIZFI(DPYORKABOGH a, string b, string c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8E47330", Offset = "0x8E45F30", VA = "0x188E47330")]
		private SetResult WZJXNNHCVLK(DPYORKABOGH a, string b, int c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8E46130", Offset = "0x8E44D30", VA = "0x188E46130")]
		private SetResult LBQDRMSNQEH(DPYORKABOGH a, string b, bool c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8E453D0", Offset = "0x8E43FD0", VA = "0x188E453D0")]
		private SetResult DVPWSVOTNCH(DPYORKABOGH a, string b, float c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8E45B70", Offset = "0x8E44770", VA = "0x188E45B70")]
		private SetResult FDOLBWKBGXI(DPYORKABOGH a, string b, DateTime c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8E464F0", Offset = "0x8E450F0", VA = "0x188E464F0")]
		private SetResult PIAUKGVYQVL(DPYORKABOGH a, string b, long c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x3EA9190", Offset = "0x3EA7D90", VA = "0x183EA9190")]
		private e LVENSGQUGMM<e>(DPYORKABOGH a, string b, e c)
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x3EA9E70", Offset = "0x3EA8A70", VA = "0x183EA9E70")]
		private SetResult YHOJESGLXZC<f>(DPYORKABOGH a, string b, f c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x3EA9C60", Offset = "0x3EA8860", VA = "0x183EA9C60", Slot = "39")]
		public void XMPRHBLSTAH<g>(EDYEQLIPZND<g> a, [Optional] IEqualityComparer<g> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x3EA8E50", Offset = "0x3EA7A50", VA = "0x183EA8E50", Slot = "40")]
		public void DRCLQVYTQVO<h>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8E46BA0", Offset = "0x8E457A0", VA = "0x188E46BA0")]
		[AsyncStateMachine(typeof(<Save>d__77))]
		private void Save(DPYORKABOGH backingStoreToSave)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8E458B0", Offset = "0x8E444B0", VA = "0x188E458B0", Slot = "43")]
		[AsyncStateMachine(typeof(<SaveImmediate>d__78))]
		public Task EYLODXWILUJ([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8E46F90", Offset = "0x8E45B90", VA = "0x188E46F90")]
		private void VNOECAKDYRZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8E46AD0", Offset = "0x8E456D0", VA = "0x188E46AD0", Slot = "41")]
		public IDisposable RTDIZNYIRGF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8E45CE0", Offset = "0x8E448E0", VA = "0x188E45CE0", Slot = "42")]
		public void GDDCNYVEJWS(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8E45000", Offset = "0x8E43C00", VA = "0x188E45000")]
		private void DBOIEGSEMGC(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8E47670", Offset = "0x8E46270", VA = "0x188E47670")]
		[IteratorStateMachine(typeof(NLLCJVTXLLA))]
		private IEnumerator<UGECMBPSTCZ> YELFRNXICGI(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8E463F0", Offset = "0x8E44FF0", VA = "0x188E463F0")]
		[CompilerGenerated]
		private void LKVURITGPAD()
		{
		}
	}
}
namespace RecRoom.Preferences.CustomParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class UCGMBGODKTH : UMEZLOBANCV<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static UCGMBGODKTH CFGULCWBBYG
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x8E497E0", Offset = "0x8E483E0", VA = "0x188E497E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8E49830", Offset = "0x8E48430", VA = "0x188E49830", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8E49560", Offset = "0x8E48160", VA = "0x188E49560", Slot = "10")]
		protected override bool IPMHCNWMEDG(string a, [Out] bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8E499B0", Offset = "0x8E485B0", VA = "0x188E499B0")]
		public UCGMBGODKTH()
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
