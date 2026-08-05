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
	public struct ViewId
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
			[Cpp2IlInjected.Address(RVA = "0x8EAFA0", Offset = "0x8E9DA0", VA = "0x1808EAFA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int ActorNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x60E75A0", Offset = "0x60E63A0", VA = "0x1860E75A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool DestroyOnLeave
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x60E75C0", Offset = "0x60E63C0", VA = "0x1860E75C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x60E75F0", Offset = "0x60E63F0", VA = "0x1860E75F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x60E7490", Offset = "0x60E6290", VA = "0x1860E7490")]
		private static int JEJALMMPDAP(int CGBNDCMKOGK, int PPBECGKKLHC, bool NLAOIACHANN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x60E74D0", Offset = "0x60E62D0", VA = "0x1860E74D0")]
		public static ViewId KHOJGIEPAJJ(int CGBNDCMKOGK, int PPBECGKKLHC, bool NLAOIACHANN)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xD7D620", Offset = "0xD7C420", VA = "0x180D7D620")]
		public static ViewId KHOJGIEPAJJ(int HNNLIEFHACP)
		{
			return default(ViewId);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x60E7370", Offset = "0x60E6170", VA = "0x1860E7370")]
		public static bool EILLJGMDDAM(ViewId LDPIALBNJEB, ViewId HLCIAKLFNHE)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x60E72D0", Offset = "0x60E60D0", VA = "0x1860E72D0")]
		public static bool CDMEFABOJMD(ViewId LDPIALBNJEB, ViewId HLCIAKLFNHE)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x60E7320", Offset = "0x60E6120", VA = "0x1860E7320")]
		public static bool EILLJGMDDAM(int LDPIALBNJEB, ViewId HLCIAKLFNHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x60E73C0", Offset = "0x60E61C0", VA = "0x1860E73C0", Slot = "0")]
		public override bool Equals(object KDHDNCADFDJ)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class NAFGABOIBOI
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static int HOFDIDOPBHK;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static int GBMPHACDILJ;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static int DGGBDGMFADA;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x60E7280", Offset = "0x60E6080", VA = "0x1860E7280")]
	public static void HBHILHANIPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x60E71A0", Offset = "0x60E5FA0", VA = "0x1860E71A0")]
	public static void HBENBIDEIFM(int[] IHHKNMFGKFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x60E6F00", Offset = "0x60E5D00", VA = "0x1860E6F00")]
	public static int CBFEGHCAFLO(int EOFDDBDNKMA, Func<int, bool> FFIMNFFLDJE, bool NLAOIACHANN = true)
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
