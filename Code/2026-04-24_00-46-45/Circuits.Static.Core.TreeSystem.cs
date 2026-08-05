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
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BD2370", Offset = "0x2BD0D70", VA = "0x182BD2370")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD3B3B0", Offset = "0xD39DB0", VA = "0x180D3B3B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3B3F0", Offset = "0xD39DF0", VA = "0x180D3B3F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD1B420", Offset = "0xD19E20", VA = "0x180D1B420", Slot = "4")]
			get
			{
				return default(Id32<TMNode>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private object IFKDFAMTOCU
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x7419A80", Offset = "0x7418480", VA = "0x187419A80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7419B90", Offset = "0x7418590", VA = "0x187419B90")]
		internal PathToRootEnumerator(Id32<TMNode> start, [In] SOAField<TMNode, Id32<TMNode>> parents)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7419860", Offset = "0x7418260", VA = "0x187419860", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7419B80", Offset = "0x7418580", VA = "0x187419B80", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BCF1A0", Offset = "0x2BCDBA0", VA = "0x182BCF1A0")]
		internal TreeSys([In] SOAId32<TMNode> ids, [In] SOAField<TMNode, Id32<TMNode>> parents, [In] SOAField<TMNode, UnsafeList<Id32<TMNode>>> children)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7BE7D50", Offset = "0x7BE6750", VA = "0x187BE7D50")]
		public static TreeSys<TMNode> New()
		{
			return default(TreeSys<TMNode>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class NONYWISFUTR
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3D5E7E0", Offset = "0x3D5D1E0", VA = "0x183D5E7E0")]
		public static YIAZMXZZDNJ NZJDRENIZKU<TMNode>([In] this TreeSys<TMNode> self) where TMNode : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3D5DD60", Offset = "0x3D5C760", VA = "0x183D5DD60")]
		internal static ELFYLSVOQNT EADNXYFMGST<TMNode>([In] this UnsafeList<Id32<TMNode>> self) where TMNode : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3D5EDD0", Offset = "0x3D5D7D0", VA = "0x183D5EDD0")]
		internal static UnsafeList<Id32<TMNode>> PRCFPWALWLE<TMNode>(this ELFYLSVOQNT a) where TMNode : notnull
		{
			return default(UnsafeList<Id32<TMNode>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3D5D9E0", Offset = "0x3D5C3E0", VA = "0x183D5D9E0")]
		public static void Destroy<TMNode>(this TreeSys<TMNode> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3D5E390", Offset = "0x3D5CD90", VA = "0x183D5E390")]
		public static bool LWZEGEKDDWW<a>([In] this TreeSys<a> self, Id32<a> id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3D5FEA0", Offset = "0x3D5E8A0", VA = "0x183D5FEA0")]
		public static int XAVQJSXVKBX<b>([In] this TreeSys<b> self)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3D5FA80", Offset = "0x3D5E480", VA = "0x183D5FA80")]
		public static Id32<c?> TNFSOTFAQBJ<c>(this TreeSys<c> self)
		{
			return default(Id32<c>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3D5D6C0", Offset = "0x3D5C0C0", VA = "0x183D5D6C0")]
		public static Id32<d?> CITKRCBACFZ<d>(this TreeSys<d> self, Id32<d> parent)
		{
			return default(Id32<d>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3D5F410", Offset = "0x3D5DE10", VA = "0x183D5F410")]
		public static void Release<TMNode>(this TreeSys<TMNode> self, Id32<TMNode> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3D5E2E0", Offset = "0x3D5CCE0", VA = "0x183D5E2E0")]
		public static bool IOAXHOBNRTU<e>([In] this TreeSys<e> self, Id32<e> id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3D5DFB0", Offset = "0x3D5C9B0", VA = "0x183D5DFB0")]
		public static Id32<f?> GYJEZGJLXWC<f>([In] this TreeSys<f> self, Id32<f> id)
		{
			return default(Id32<f>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3D5E120", Offset = "0x3D5CB20", VA = "0x183D5E120")]
		public static Id32<TMNode?>? GetParentOrNull<TMNode>([In] this TreeSys<TMNode> self, Id32<TMNode> id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3D5F820", Offset = "0x3D5E220", VA = "0x183D5F820")]
		public static void Reparent<TMNode>(this TreeSys<TMNode> self, Id32<TMNode> id, Id32<TMNode> newParentId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3D5FBF0", Offset = "0x3D5E5F0", VA = "0x183D5FBF0")]
		public static ConstEnumerable<Id32<j?>, UnsafeList<Id32<j?>>.Enumerator> TWNFWZFYADE<j>([In] this TreeSys<j> self, Id32<j> id)
		{
			return default(ConstEnumerable<Id32<j>, UnsafeList<Id32<j>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xE354B0", Offset = "0xE33EB0", VA = "0x180E354B0")]
		public static SOAId32<k?> KQWWYNQTVJW<k>([In] this TreeSys<k> self)
		{
			return default(SOAId32<k>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x386A770", Offset = "0x3869170", VA = "0x18386A770")]
		public static SOAId32<TMNode?>.Enumerator GetEnumerator<TMNode>([In] this TreeSys<TMNode> self)
		{
			return default(SOAId32<TMNode>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3868FE0", Offset = "0x38679E0", VA = "0x183868FE0")]
		public static CopyEnumerable<Id32<l?>, SOAId32<l?>.Enumerator> SXJZHXIMNGQ<l>([In] this TreeSys<l> self)
		{
			return default(CopyEnumerable<Id32<l>, SOAId32<l>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3D5FD60", Offset = "0x3D5E760", VA = "0x183D5FD60")]
		public static bool WYEUYQCDBGL<m>([In] this TreeSys<m> self, Id32<m> node, Id32<m> possibleAncestor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3D5F110", Offset = "0x3D5DB10", VA = "0x183D5F110")]
		public static CopyEnumerable<Id32<n?>, PathToRootEnumerator<n?>> QXDUMSGPPOQ<n>([In] this TreeSys<n> self, Id32<n> node)
		{
			return default(CopyEnumerable<Id32<n>, PathToRootEnumerator<n>>);
		}
	}
}
namespace Circuits.Static.Core.TreeSystem.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class TAADEAMZWBI
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3F6D770", Offset = "0x3F6C170", VA = "0x183F6D770")]
		public static TreeSys<TMNode> IVDFFFMFEGJ<TMNode>(this YIAZMXZZDNJ a) where TMNode : notnull
		{
			return default(TreeSys<TMNode>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD23F0", Offset = "0x2BD0DF0", VA = "0x182BD23F0")]
		public static void Release(this YIAZMXZZDNJ self, int id)
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
