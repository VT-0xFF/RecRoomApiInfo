using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Circuits.Shared.Utilities;
using Circuits.Static.Core.TreeSystem.Protobuf;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.DataStructures.Performance;

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
		[Cpp2IlInjected.Address(RVA = "0x28C5B90", Offset = "0x28C4790", VA = "0x1828C5B90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC01D0", Offset = "0xABEDD0", VA = "0x180AC01D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC0210", Offset = "0xABEE10", VA = "0x180AC0210")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Static.Core.TreeSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct PathToRootEnumerator<TMNode> : IEnumerator<Id32<TMNode>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly Id32<TMNode> _start;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly SOAField<TMNode, Id32<TMNode>> _parents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private Id32<TMNode> _current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool _started;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Id32<TMNode> Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA9D1C0", Offset = "0xA9BDC0", VA = "0x180A9D1C0", Slot = "4")]
			get
			{
				return default(Id32<TMNode>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private object JGIILLOFTSJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x59FFF30", Offset = "0x59FEB30", VA = "0x1859FFF30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5A003E0", Offset = "0x59FEFE0", VA = "0x185A003E0")]
		internal PathToRootEnumerator(Id32<TMNode> start, [In] SOAField<TMNode, Id32<TMNode>> parents)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5A001C0", Offset = "0x59FEDC0", VA = "0x185A001C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5A003D0", Offset = "0x59FEFD0", VA = "0x185A003D0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "5")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct TreeSys<TMNode>
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal static readonly Id32<TMNode> _noParentId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal SOAId32<TMNode> _ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal SOAField<TMNode, Id32<TMNode>> _parents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal SOAField<TMNode, UnsafeList<Id32<TMNode>>> _children;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x28C0B40", Offset = "0x28BF740", VA = "0x1828C0B40")]
		internal TreeSys([In] SOAId32<TMNode> ids, [In] SOAField<TMNode, Id32<TMNode>> parents, [In] SOAField<TMNode, UnsafeList<Id32<TMNode>>> children)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5FB8E60", Offset = "0x5FB7A60", VA = "0x185FB8E60")]
		public static TreeSys<TMNode> New()
		{
			return default(TreeSys<TMNode>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class TWRXSKEEBSY
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3A85090", Offset = "0x3A83C90", VA = "0x183A85090")]
		public static RCUVTFSRCFG DKWNNTIDYNZ<TMNode>([In] this TreeSys<TMNode> self) where TMNode : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3A85F80", Offset = "0x3A84B80", VA = "0x183A85F80")]
		internal static CSHORONVZFK NJHZFCTAAWY<TMNode>([In] this UnsafeList<Id32<TMNode>> self) where TMNode : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3A84A30", Offset = "0x3A83630", VA = "0x183A84A30")]
		internal static UnsafeList<Id32<TMNode>> BSBDTMGLFKR<TMNode>(this CSHORONVZFK a) where TMNode : notnull
		{
			return default(UnsafeList<Id32<TMNode>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3A85660", Offset = "0x3A84260", VA = "0x183A85660")]
		public static void Destroy<TMNode>(this TreeSys<TMNode> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3A845F0", Offset = "0x3A831F0", VA = "0x183A845F0")]
		public static bool BFVJNESXOIH<a>([In] this TreeSys<a> self, Id32<a> id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3A85BA0", Offset = "0x3A847A0", VA = "0x183A85BA0")]
		public static int HBMCASSTFEU<b>([In] this TreeSys<b> self)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3A86E00", Offset = "0x3A85A00", VA = "0x183A86E00")]
		public static Id32<c?> VUNWDQZPSQW<c>(this TreeSys<c> self)
		{
			return default(Id32<c>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3A869F0", Offset = "0x3A855F0", VA = "0x183A869F0")]
		public static Id32<d?> TPCWFTMYEPE<d>(this TreeSys<d> self, Id32<d> parent)
		{
			return default(Id32<d>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3A863A0", Offset = "0x3A84FA0", VA = "0x183A863A0")]
		public static void Release<TMNode>(this TreeSys<TMNode> self, Id32<TMNode> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3A84720", Offset = "0x3A83320", VA = "0x183A84720")]
		public static bool BIEOTABIEBD<e>([In] this TreeSys<e> self, Id32<e> id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3A85D60", Offset = "0x3A84960", VA = "0x183A85D60")]
		public static Id32<f?> JKHENJESUTD<f>([In] this TreeSys<f> self, Id32<f> id)
		{
			return default(Id32<f>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3A85AC0", Offset = "0x3A846C0", VA = "0x183A85AC0")]
		public static Id32<TMNode?>? GetParentOrNull<TMNode>([In] this TreeSys<TMNode> self, Id32<TMNode> id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3A867A0", Offset = "0x3A853A0", VA = "0x183A867A0")]
		public static void Reparent<TMNode>(this TreeSys<TMNode> self, Id32<TMNode> id, Id32<TMNode> newParentId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3A85C60", Offset = "0x3A84860", VA = "0x183A85C60")]
		public static ConstEnumerable<Id32<j?>, UnsafeList<Id32<j?>>.Enumerator> IOGPSHUFKIH<j>([In] this TreeSys<j> self, Id32<j> id)
		{
			return default(ConstEnumerable<Id32<j>, UnsafeList<Id32<j>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xB15960", Offset = "0xB14560", VA = "0x180B15960")]
		public static SOAId32<k?> ONJAQBHREKJ<k>([In] this TreeSys<k> self)
		{
			return default(SOAId32<k>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x345F7E0", Offset = "0x345E3E0", VA = "0x18345F7E0")]
		public static SOAId32<TMNode?>.Enumerator GetEnumerator<TMNode>([In] this TreeSys<TMNode> self)
		{
			return default(SOAId32<TMNode>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x345F140", Offset = "0x345DD40", VA = "0x18345F140")]
		public static CopyEnumerable<Id32<l?>, SOAId32<l?>.Enumerator> FMOQJCWLCCD<l>([In] this TreeSys<l> self)
		{
			return default(CopyEnumerable<Id32<l>, SOAId32<l>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3A86BC0", Offset = "0x3A857C0", VA = "0x183A86BC0")]
		public static bool UOYQDVMSITA<m>([In] this TreeSys<m> self, Id32<m> node, Id32<m> possibleAncestor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3A858F0", Offset = "0x3A844F0", VA = "0x183A858F0")]
		public static CopyEnumerable<Id32<n?>, PathToRootEnumerator<n?>> FGFWYOGIJZF<n>([In] this TreeSys<n> self, Id32<n> node)
		{
			return default(CopyEnumerable<Id32<n>, PathToRootEnumerator<n>>);
		}
	}
}
namespace Circuits.Static.Core.TreeSystem.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class SYTUSDTAOYD
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3A3FEC0", Offset = "0x3A3EAC0", VA = "0x183A3FEC0")]
		public static TreeSys<TMNode> RIPHTNDVABI<TMNode>(this RCUVTFSRCFG a) where TMNode : notnull
		{
			return default(TreeSys<TMNode>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x28C5C10", Offset = "0x28C4810", VA = "0x1828C5C10")]
		public static void Release(this RCUVTFSRCFG self, int id)
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
