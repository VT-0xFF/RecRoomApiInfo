using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class KDIABHFNKJP : ENLJNEOAHMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string HCNJOJHJACH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8117C60", Offset = "0x8116660", VA = "0x188117C60")]
	public KDIABHFNKJP(string JGECGGLCFAK, string HCNJOJHJACH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
public class EGNGIPBAIAA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
	public EGNGIPBAIAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Field, Inherited = true)]
public class EBIHJLPHMNK : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string BJJGMPGKNHG;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x81179A0", Offset = "0x81163A0", VA = "0x1881179A0")]
	public EBIHJLPHMNK(string BJJGMPGKNHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum MGLGMLBODOF
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Self,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Parent,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Children,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	SelfAndParent,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	SelfAndChildren,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	NestedParent
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class OICBHOIKJDP : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8117D80", Offset = "0x8116780", VA = "0x188117D80")]
	public OICBHOIKJDP(MGLGMLBODOF AEOGKDPPBBE = MGLGMLBODOF.Self, bool KKFABIMCLMI = false, bool COIKALFMICP = false, bool PJLDMLKBIBP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class MMLCBHDIIDA : OICBHOIKJDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly Type COOBIECEPJL;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8117DD0", Offset = "0x81167D0", VA = "0x188117DD0")]
	public MMLCBHDIIDA(Type BOJPAFKLMDD, MGLGMLBODOF AEOGKDPPBBE = MGLGMLBODOF.Self, bool KKFABIMCLMI = false, bool COIKALFMICP = false, bool PJLDMLKBIBP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class MICOBDMLFEG : OICBHOIKJDP
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8117D80", Offset = "0x8116780", VA = "0x188117D80")]
	public MICOBDMLFEG(MGLGMLBODOF AEOGKDPPBBE = MGLGMLBODOF.Self, bool KKFABIMCLMI = false, bool COIKALFMICP = false, bool PJLDMLKBIBP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
public class FBECCKFBOFB : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum EENGDGKCLOM
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		Info,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		Error
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly string BCLNCLHGOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly EENGDGKCLOM AEOGKDPPBBE;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8117C20", Offset = "0x8116620", VA = "0x188117C20")]
	public FBECCKFBOFB(string BCLNCLHGOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x74C2EB0", Offset = "0x74C18B0", VA = "0x1874C2EB0")]
	public FBECCKFBOFB(string BCLNCLHGOEM, EENGDGKCLOM AEOGKDPPBBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ENLJNEOAHMH : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string JGECGGLCFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool DHHLHNOKGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] PEJJMIBKFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool MBNEDIHPJDL;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x81179E0", Offset = "0x81163E0", VA = "0x1881179E0")]
	public ENLJNEOAHMH(string JGECGGLCFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8117B40", Offset = "0x8116540", VA = "0x188117B40")]
	public ENLJNEOAHMH(string JGECGGLCFAK, object DICMFGLEEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8117AE0", Offset = "0x81164E0", VA = "0x188117AE0")]
	public ENLJNEOAHMH(string JGECGGLCFAK, params object[] PEJJMIBKFDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class EPABNNCOLAE : ENLJNEOAHMH
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8117B40", Offset = "0x8116540", VA = "0x188117B40")]
	public EPABNNCOLAE(string JGECGGLCFAK, object DICMFGLEEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8117AE0", Offset = "0x81164E0", VA = "0x188117AE0")]
	public EPABNNCOLAE(string JGECGGLCFAK, params object[] PEJJMIBKFDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class OIJMCBIBLMF : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly bool EHGHCDBLBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly string MIMAJJOIGLE;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8117E40", Offset = "0x8116840", VA = "0x188117E40")]
	public OIJMCBIBLMF(string FMOJCBBKKEP, bool JILJPMLGEMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class GCICFFOLEHE : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x234AA50", Offset = "0x2349450", VA = "0x18234AA50")]
	public GCICFFOLEHE()
	{
	}
}
namespace RecRoom.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ReadOnlyFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x234AA50", Offset = "0x2349450", VA = "0x18234AA50")]
		public ReadOnlyFieldAttribute()
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
