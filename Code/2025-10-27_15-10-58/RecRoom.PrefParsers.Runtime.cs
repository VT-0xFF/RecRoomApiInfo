using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using RecRoom.NoEngine.DataStructures.Runtime.Caching;
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
		[Cpp2IlInjected.Address(RVA = "0xAF8940", Offset = "0xAF7940", VA = "0x180AF8940")]
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

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF8980", Offset = "0xAF7980", VA = "0x180AF8980")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Utils.PrefParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class SFKUOBNHELY : YCZMMYZLALT<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8B21DA0", Offset = "0x8B20DA0", VA = "0x188B21DA0", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8B21DD0", Offset = "0x8B20DD0", VA = "0x188B21DD0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8B21E20", Offset = "0x8B20E20", VA = "0x188B21E20")]
		public SFKUOBNHELY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class JSBZEVDGFAH : YCZMMYZLALT<DateTime>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8B21480", Offset = "0x8B20480", VA = "0x188B21480", Slot = "9")]
		public override string Serialize(DateTime input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8B21510", Offset = "0x8B20510", VA = "0x188B21510", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] DateTime value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8B215B0", Offset = "0x8B205B0", VA = "0x188B215B0")]
		public JSBZEVDGFAH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class TXMYJBCFXCD<a> : YCZMMYZLALT<a> where a : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Type LFZKZDIREKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly bool IBVBWEWNVBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly a[] GFYWHAFSBXN;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6311BD0", Offset = "0x6310BD0", VA = "0x186311BD0")]
		[Preserve]
		public TXMYJBCFXCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6311400", Offset = "0x6310400", VA = "0x186311400", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6311960", Offset = "0x6310960", VA = "0x186311960", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class QJKHOODWQNO<a> : YCZMMYZLALT<a> where a : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Type LFZKZDIREKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly LMHOQPVMZBM KCQWJPPBKWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly bool IBVBWEWNVBB;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5E45BC0", Offset = "0x5E44BC0", VA = "0x185E45BC0")]
		[Preserve]
		public QJKHOODWQNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5E45420", Offset = "0x5E44420", VA = "0x185E45420", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5E45500", Offset = "0x5E44500", VA = "0x185E45500", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class BYNFSXMSTNR
	{
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Dictionary<Type, LMHOQPVMZBM> IRHTNDLANHV;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8B20C00", Offset = "0x8B1FC00", VA = "0x188B20C00")]
		public static LMHOQPVMZBM SSHPSAWDSWX(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class UGLAWBSCEXO<a> : YCZMMYZLALT<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x659E9E0", Offset = "0x659D9E0", VA = "0x18659E9E0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x659EB30", Offset = "0x659DB30", VA = "0x18659EB30", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4253D80", Offset = "0x4252D80", VA = "0x184253D80")]
		public UGLAWBSCEXO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class ZIGQPUGGKCC<a, b> : YCZMMYZLALT<a> where a : IEnumerable<b>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected readonly LIWZIBCMUYN<b> RUULVSRVYLG;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x41C6ED0", Offset = "0x41C5ED0", VA = "0x1841C6ED0")]
		protected ZIGQPUGGKCC(LIWZIBCMUYN<b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x41C3DD0", Offset = "0x41C2DD0", VA = "0x1841C3DD0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x41C46F0", Offset = "0x41C36F0", VA = "0x1841C46F0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract a XJPBPTJQTLD(IEnumerable<b> a);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x41C3290", Offset = "0x41C2290", VA = "0x1841C3290", Slot = "12")]
		internal virtual IEnumerable<string> MGJRYVESBAR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x41C2D40", Offset = "0x41C1D40", VA = "0x1841C2D40")]
		[CompilerGenerated]
		private string JWVXYWMWKRA(b a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class YTOXBUXXPLA<a> : ZIGQPUGGKCC<a[], a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x41581A0", Offset = "0x41571A0", VA = "0x1841581A0")]
		[Preserve]
		public YTOXBUXXPLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4158160", Offset = "0x4157160", VA = "0x184158160")]
		[Preserve]
		public YTOXBUXXPLA(LIWZIBCMUYN<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x41A00F0", Offset = "0x419F0F0", VA = "0x1841A00F0", Slot = "11")]
		protected override a[] XJPBPTJQTLD(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class XAWMOYIFNKV<a> : ZIGQPUGGKCC<List<a>, a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x41581A0", Offset = "0x41571A0", VA = "0x1841581A0")]
		[Preserve]
		public XAWMOYIFNKV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4158160", Offset = "0x4157160", VA = "0x184158160")]
		[Preserve]
		public XAWMOYIFNKV([Optional] LIWZIBCMUYN<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4157CE0", Offset = "0x4156CE0", VA = "0x184157CE0", Slot = "11")]
		protected override List<a> XJPBPTJQTLD(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class YEVDSNEFNKZ<a> : YCZMMYZLALT<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly JsonSerializerSettings? CTGOMHUZHFU;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4198740", Offset = "0x4197740", VA = "0x184198740")]
		public YEVDSNEFNKZ(JsonSerializerSettings? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x41983A0", Offset = "0x41973A0", VA = "0x1841983A0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4198500", Offset = "0x4197500", VA = "0x184198500", Slot = "10")]
		protected override bool TryParseInternal([NotNull] string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class HGHZGFPXSCA : YCZMMYZLALT<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8B21350", Offset = "0x8B20350", VA = "0x188B21350", Slot = "9")]
		public override string Serialize(byte input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8B213B0", Offset = "0x8B203B0", VA = "0x188B213B0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] byte value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8B21440", Offset = "0x8B20440", VA = "0x188B21440")]
		public HGHZGFPXSCA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class UPHJDLETUHY : YCZMMYZLALT<short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8B21FA0", Offset = "0x8B20FA0", VA = "0x188B21FA0", Slot = "9")]
		public override string Serialize(short input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8B22000", Offset = "0x8B21000", VA = "0x188B22000", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] short value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8B220A0", Offset = "0x8B210A0", VA = "0x188B220A0")]
		public UPHJDLETUHY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class NDUOEZQBRDX : YCZMMYZLALT<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8B21850", Offset = "0x8B20850", VA = "0x188B21850", Slot = "9")]
		public override string Serialize(ushort input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8B218B0", Offset = "0x8B208B0", VA = "0x188B218B0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ushort value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8B21950", Offset = "0x8B20950", VA = "0x188B21950")]
		public NDUOEZQBRDX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class MZVQLGNPXDD : YCZMMYZLALT<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8B21720", Offset = "0x8B20720", VA = "0x188B21720", Slot = "9")]
		public override string Serialize(int input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8B21780", Offset = "0x8B20780", VA = "0x188B21780", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8B21810", Offset = "0x8B20810", VA = "0x188B21810")]
		public MZVQLGNPXDD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class MZLJVKCKWEK : YCZMMYZLALT<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8B215F0", Offset = "0x8B205F0", VA = "0x188B215F0", Slot = "9")]
		public override string Serialize(uint input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8B21650", Offset = "0x8B20650", VA = "0x188B21650", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] uint value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8B216E0", Offset = "0x8B206E0", VA = "0x188B216E0")]
		public MZLJVKCKWEK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class TZIFUNSVCQQ : YCZMMYZLALT<long>
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8B21E60", Offset = "0x8B20E60", VA = "0x188B21E60", Slot = "9")]
		public override string Serialize(long input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8B21EC0", Offset = "0x8B20EC0", VA = "0x188B21EC0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] long value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8B21F60", Offset = "0x8B20F60", VA = "0x188B21F60")]
		public TZIFUNSVCQQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class PLEJKIKXPNH : YCZMMYZLALT<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8B21C60", Offset = "0x8B20C60", VA = "0x188B21C60", Slot = "9")]
		public override string Serialize(ulong input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8B21CC0", Offset = "0x8B20CC0", VA = "0x188B21CC0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ulong value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8B21D60", Offset = "0x8B20D60", VA = "0x188B21D60")]
		public PLEJKIKXPNH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class XPYYBSZJTOW : YCZMMYZLALT<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8B221C0", Offset = "0x8B211C0", VA = "0x188B221C0", Slot = "9")]
		public override string Serialize(float input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8B22230", Offset = "0x8B21230", VA = "0x188B22230", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8B222C0", Offset = "0x8B212C0", VA = "0x188B222C0")]
		public XPYYBSZJTOW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface LMHOQPVMZBM
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string SHTGHNTZHHY(object a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool XKQLLAXIZXI([CanBeNull] string input, [Out] object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface LIWZIBCMUYN<a> : LMHOQPVMZBM
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool RTJDIESGOFD([CanBeNull] string input, [Out] a a);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		a BMXZHYVEDPG([CanBeNull] string input, [Optional] a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class YCZMMYZLALT<a> : LIWZIBCMUYN<a>, LMHOQPVMZBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Type RMOOFUKASZF;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4197E90", Offset = "0x4196E90", VA = "0x184197E90")]
		protected YCZMMYZLALT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4197C40", Offset = "0x4196C40", VA = "0x184197C40")]
		private a XMHBTEDATGP(object a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x41974D0", Offset = "0x41964D0", VA = "0x1841974D0", Slot = "7")]
		public string SHTGHNTZHHY(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4196FC0", Offset = "0x4195FC0", VA = "0x184196FC0", Slot = "5")]
		public bool RTJDIESGOFD(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract bool TryParseInternal([NotNull] string input, [Out] a value);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4196AC0", Offset = "0x4195AC0", VA = "0x184196AC0", Slot = "8")]
		private bool BZHWRHSNWQI(string a, [Out] object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4196930", Offset = "0x4195930", VA = "0x184196930", Slot = "6")]
		public a BMXZHYVEDPG(string a, [Optional] a b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class NWOIDRFBPPW<b>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static LIWZIBCMUYN<b> MQLQILIKRCK
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5069530", Offset = "0x5068530", VA = "0x185069530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3C7E4F0", Offset = "0x3C7D4F0", VA = "0x183C7E4F0")]
		public static LIWZIBCMUYN<a> TNBKMEFOVPD<a>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5B7BFE0", Offset = "0x5B7AFE0", VA = "0x185B7BFE0")]
		public static LMHOQPVMZBM TNBKMEFOVPD(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5B6E5A0", Offset = "0x5B6D5A0", VA = "0x185B6E5A0")]
		private static LMHOQPVMZBM AUMRWKLSGKW(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5B75710", Offset = "0x5B74710", VA = "0x185B75710")]
		private static LMHOQPVMZBM SPVZJYMZKKZ(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class GUOTTXRZJVR<a> : ZIGQPUGGKCC<a, string> where a : IEnumerable<string>
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class XUUVRLKPPXK : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int WDQRLRKBTGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private string IGHQXRUYHSG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private int FMHFHEECSRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private string QEQOPFNZASL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public string HQXTVPRTZWK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public GUOTTXRZJVR<a> FOYWNDAXKGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private PooledObject<StringBuilder> KNILEGESVVN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private StringBuilder VSHQRZXSNQP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private bool YTRLTQGQBEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private int GLQXDHICWZS;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private string MDNALUYVRKQ
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			private object UQAIKHVHSEP
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xBB3120", Offset = "0xBB2120", VA = "0x180BB3120")]
			[DebuggerHidden]
			public XUUVRLKPPXK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x418E730", Offset = "0x418D730", VA = "0x18418E730", Slot = "7")]
			[DebuggerHidden]
			private void PRJHWGPKORK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x418DDE0", Offset = "0x418CDE0", VA = "0x18418DDE0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x418E960", Offset = "0x418D960", VA = "0x18418E960")]
			private void ZLAPFDWYPLY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x405A760", Offset = "0x4059760", VA = "0x18405A760", Slot = "10")]
			[DebuggerHidden]
			private void HJPFLPVTXYN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x418E8A0", Offset = "0x418D8A0", VA = "0x18418E8A0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> UWDMQJJAIDJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x418DD10", Offset = "0x418CD10", VA = "0x18418DD10", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator JZJZEHYLQOE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly bool EYXOYGHTKPU;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x51FF650", Offset = "0x51FE650", VA = "0x1851FF650")]
		protected GUOTTXRZJVR(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x51FF0D0", Offset = "0x51FE0D0", VA = "0x1851FF0D0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x51FF020", Offset = "0x51FE020", VA = "0x1851FF020", Slot = "12")]
		[IteratorStateMachine(typeof(GUOTTXRZJVR<>.XUUVRLKPPXK))]
		internal override IEnumerable<string> MGJRYVESBAR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x51FEE70", Offset = "0x51FDE70", VA = "0x1851FEE70")]
		[CompilerGenerated]
		internal static string MBNBZUTQQKJ(StringBuilder a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class XEZIOSXZXVJ : GUOTTXRZJVR<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8B22170", Offset = "0x8B21170", VA = "0x188B22170")]
		[Preserve]
		public XEZIOSXZXVJ(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8B220E0", Offset = "0x8B210E0", VA = "0x188B220E0", Slot = "11")]
		protected override List<string> XJPBPTJQTLD(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class ZAUJGADAMOW : GUOTTXRZJVR<string[]>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8B223C0", Offset = "0x8B213C0", VA = "0x188B223C0")]
		[Preserve]
		public ZAUJGADAMOW(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8B22360", Offset = "0x8B21360", VA = "0x188B22360", Slot = "11")]
		protected override string[] XJPBPTJQTLD(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal class YVTKUOXYFPR : YCZMMYZLALT<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xB2F680", Offset = "0xB2E680", VA = "0x180B2F680", Slot = "9")]
		public override string Serialize(string input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8B22300", Offset = "0x8B21300", VA = "0x188B22300", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8B22320", Offset = "0x8B21320", VA = "0x188B22320")]
		public YVTKUOXYFPR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class NHIBJDTNIWU : YCZMMYZLALT<TimeSpan>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8B21990", Offset = "0x8B20990", VA = "0x188B21990", Slot = "9")]
		public override string Serialize(TimeSpan input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8B21AB0", Offset = "0x8B20AB0", VA = "0x188B21AB0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] TimeSpan value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8B21C20", Offset = "0x8B20C20", VA = "0x188B21C20")]
		public NHIBJDTNIWU()
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
