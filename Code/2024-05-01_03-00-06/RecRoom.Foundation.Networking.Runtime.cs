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
			[Cpp2IlInjected.Address(RVA = "0x905FC0", Offset = "0x904DC0", VA = "0x180905FC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int ActorNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x621CC50", Offset = "0x621BA50", VA = "0x18621CC50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool DestroyOnLeave
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x621CC70", Offset = "0x621BA70", VA = "0x18621CC70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x621CCA0", Offset = "0x621BAA0", VA = "0x18621CCA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x621C890", Offset = "0x621B690", VA = "0x18621C890")]
		private static int ANGIPLLBHOI(int PAAEECNHMFK, int MKBJDIGNNIK, bool PBDAJHNMGPI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x621CAE0", Offset = "0x621B8E0", VA = "0x18621CAE0")]
		public static ViewId LMFLNJNPHGE(int PAAEECNHMFK, int MKBJDIGNNIK, bool PBDAJHNMGPI)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xD6EEB0", Offset = "0xD6DCB0", VA = "0x180D6EEB0")]
		public static ViewId LMFLNJNPHGE(int ECAJDMFACLC)
		{
			return default(ViewId);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x621CB70", Offset = "0x621B970", VA = "0x18621CB70")]
		public static bool OFKPFEHPLBH(ViewId DCJCHFKPCOP, ViewId IKGIOHGPKCP)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x621C8D0", Offset = "0x621B6D0", VA = "0x18621C8D0")]
		public static bool CAAJBKCJNPA(ViewId DCJCHFKPCOP, ViewId IKGIOHGPKCP)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x621CBC0", Offset = "0x621B9C0", VA = "0x18621CBC0")]
		public static bool OFKPFEHPLBH(int DCJCHFKPCOP, ViewId IKGIOHGPKCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x621C920", Offset = "0x621B720", VA = "0x18621C920", Slot = "4")]
		public bool Equals(ViewId GGINNHLAMLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x621C9B0", Offset = "0x621B7B0", VA = "0x18621C9B0", Slot = "0")]
		public override bool Equals(object EIFMADKIHON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x621CA90", Offset = "0x621B890", VA = "0x18621CA90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MECEAPILJDM
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static int CFJLKPJCODL;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static int LACHKLGGFIE;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static int CLCGFHOHALK;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x621C4D0", Offset = "0x621B2D0", VA = "0x18621C4D0")]
	public static void KLLGGBEFBOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x621C7B0", Offset = "0x621B5B0", VA = "0x18621C7B0")]
	public static void PHGIEKCEPLP(int[] PBKGMGDOHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x621C520", Offset = "0x621B320", VA = "0x18621C520")]
	public static int ONNEEAALFIB(int DFKPEDELJOD, Func<int, bool> CDNMJBEOKDK, bool PBDAJHNMGPI = true)
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
