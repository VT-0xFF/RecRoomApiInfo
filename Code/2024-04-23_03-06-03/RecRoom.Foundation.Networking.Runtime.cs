using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Foundation.Networking.DataTypes
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public struct ViewId : IEquatable<ViewId>
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public const int MAX_VIEW_IDS = 100000;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public const int MAX_PLAYER_IDS = 10000;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public const int MAX_VIEW_SUB_IDS = 50000;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public const int DONT_DESTROY_ON_LEAVE_FLAG = 50000;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public const int RUNTIME_INSTANTIATE_VIEW_ID_OFFSET = 90000;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public const int COMPILE_TIME_MAIN_ROOT_ID_OFFSET = 89000;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly ViewId Invalid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private int id;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public readonly int RawId
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x9151A0", Offset = "0x9141A0", VA = "0x1809151A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int ActorNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x62B8850", Offset = "0x62B7850", VA = "0x1862B8850")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool DestroyOnLeave
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x62B8870", Offset = "0x62B7870", VA = "0x1862B8870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x62B88A0", Offset = "0x62B78A0", VA = "0x1862B88A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x62B8780", Offset = "0x62B7780", VA = "0x1862B8780")]
		private static int KCKMHNICGFA(int KGNJJCALBPN, int FHLENIBCOCP, bool EMDMLGPGODL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x62B8490", Offset = "0x62B7490", VA = "0x1862B8490")]
		public static ViewId EJAHKPICHNP(int KGNJJCALBPN, int FHLENIBCOCP, bool EMDMLGPGODL)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xD80700", Offset = "0xD7F700", VA = "0x180D80700")]
		public static ViewId EJAHKPICHNP(int OAJHNCHLKKN)
		{
			return default(ViewId);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x62B8730", Offset = "0x62B7730", VA = "0x1862B8730")]
		public static bool JPKEALLKLNK(ViewId LHPJOLLNMHI, ViewId MGIFPMANJFK)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x62B87C0", Offset = "0x62B77C0", VA = "0x1862B87C0")]
		public static bool OECHKCIMKIG(ViewId LHPJOLLNMHI, ViewId MGIFPMANJFK)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x62B86E0", Offset = "0x62B76E0", VA = "0x1862B86E0")]
		public static bool JPKEALLKLNK(int LHPJOLLNMHI, ViewId MGIFPMANJFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x62B8520", Offset = "0x62B7520", VA = "0x1862B8520", Slot = "4")]
		public bool Equals(ViewId JNHFAFOIKEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x62B85B0", Offset = "0x62B75B0", VA = "0x1862B85B0", Slot = "0")]
		public override bool Equals(object KDEEPMDJGFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x62B8690", Offset = "0x62B7690", VA = "0x1862B8690", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class ACPJHOFAMGN
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static int LHALBBJBFJC;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static int CEOICBLCBDA;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static int AAEDAGCPHJC;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x62B8360", Offset = "0x62B7360", VA = "0x1862B8360")]
	public static void LLJMIHHCNBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x62B83B0", Offset = "0x62B73B0", VA = "0x1862B83B0")]
	public static void MGMOLKOONLB(int[] EMPELFGOMAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x62B80C0", Offset = "0x62B70C0", VA = "0x1862B80C0")]
	public static int FNMNIJMMLBE(int GPEICPBBBHJ, Func<int, bool> JBICCOAMKDD, bool EMDMLGPGODL = true)
	{
		return default(int);
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
