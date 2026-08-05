using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;
using RecRoom;
using Unity.Burst;
using Unity.Burst.CompilerServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Properties;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
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
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
		public IsUnmanagedAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x75D27F0", Offset = "0x75D1BF0", VA = "0x1875D27F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x975680", Offset = "0x974A80", VA = "0x180975680")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9756C0", Offset = "0x974AC0", VA = "0x1809756C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Unity.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class EntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x75D1F20", Offset = "0x75D1320", VA = "0x1875D1F20")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface NPHNMECBFFC : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	GCLOLCGDHHG LEBJBAKIKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BIEGIJNILGB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LNHIFBIMEKL(Entity FCJGDHPNMHF, object LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LPFPAJKKJJE(Entity FCJGDHPNMHF, object LAAJFAFNFCN, [Out] bool JLLPGEAIAFC);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BEENACDECBP(Entity FCJGDHPNMHF);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class LJPBHEEFGCL<TComponentData, TValue> : MIALEAAIKCH<TValue>, IDisposable where TComponentData : struct, NPHNMECBFFC
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class HFDAJBLPELN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<(object token, TValue value)> BHMKCPLLJPF;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int AGHLCEGEAOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x3CFDFC0", Offset = "0x3CFD3C0", VA = "0x183CFDFC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x45D8970", Offset = "0x45D7D70", VA = "0x1845D8970")]
		public bool DMEJCABDKPG([Out] TValue KBGCCIOIGBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x45D8B60", Offset = "0x45D7F60", VA = "0x1845D8B60")]
		public void HBHDBABAKDP(object LAAJFAFNFCN, TValue KBGCCIOIGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x45D8C40", Offset = "0x45D8040", VA = "0x1845D8C40")]
		public bool OCDDHDAHAOD(object LAAJFAFNFCN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x45D8A80", Offset = "0x45D7E80", VA = "0x1845D8A80")]
		public int FBHOADIJODJ(object LAAJFAFNFCN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x45D8CF0", Offset = "0x45D80F0", VA = "0x1845D8CF0")]
		public HFDAJBLPELN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Stack<HFDAJBLPELN> PNDMANKJMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private EIGPGNLJKGL<GCLOLCGDHHG, HFDAJBLPELN> EAJIFKHLIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private EntityManager IDCNJMKKJFI;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4B64EA0", Offset = "0x4B642A0", VA = "0x184B64EA0")]
	public LJPBHEEFGCL(EntityManager IDCNJMKKJFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4B649F0", Offset = "0x4B63DF0", VA = "0x184B649F0", Slot = "4")]
	public void LNHIFBIMEKL(Entity FCJGDHPNMHF, object LAAJFAFNFCN, TValue KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4B64B70", Offset = "0x4B63F70", VA = "0x184B64B70", Slot = "5")]
	public bool LPFPAJKKJJE(Entity FCJGDHPNMHF, object LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4B647C0", Offset = "0x4B63BC0", VA = "0x184B647C0", Slot = "6")]
	public bool DMEJCABDKPG(Entity FCJGDHPNMHF, [Out] TValue KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4B648D0", Offset = "0x4B63CD0", VA = "0x184B648D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4B64640", Offset = "0x4B63A40", VA = "0x184B64640")]
	private void BPOIDKGIGCM(HFDAJBLPELN MOKKKJGHAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4B64700", Offset = "0x4B63B00", VA = "0x184B64700")]
	private bool CHINOEHHCFB(Entity FCJGDHPNMHF, [Out] GCLOLCGDHHG ILIIBOPHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4B648F0", Offset = "0x4B63CF0", VA = "0x184B648F0")]
	private void IEILLIGMEBM(Entity FCJGDHPNMHF, GCLOLCGDHHG ILIIBOPHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4B64D60", Offset = "0x4B64160", VA = "0x184B64D60")]
	private bool LPOFGGELADP(GCLOLCGDHHG ILIIBOPHLDK, [Out] HFDAJBLPELN MOKKKJGHAGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4B64D80", Offset = "0x4B64180", VA = "0x184B64D80")]
	private HFDAJBLPELN PNEGDKJGKIC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MIALEAAIKCH<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LNHIFBIMEKL(Entity FCJGDHPNMHF, object LAAJFAFNFCN, TValue KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LPFPAJKKJJE(Entity FCJGDHPNMHF, object LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DMEJCABDKPG(Entity FCJGDHPNMHF, [Out] TValue KBGCCIOIGBD);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct GCLOLCGDHHG : KBLKBJHICLE, IEquatable<GCLOLCGDHHG>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly GCLOLCGDHHG NACGKDEGDLG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int MPMCCDHNNEC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x995B20", Offset = "0x994F20", VA = "0x180995B20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1098640", Offset = "0x1097A40", VA = "0x181098640", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int EMCKBBMGOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B85210", Offset = "0x2B84610", VA = "0x182B85210", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x675E500", Offset = "0x675D900", VA = "0x18675E500", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x75D1FF0", Offset = "0x75D13F0", VA = "0x1875D1FF0", Slot = "8")]
	public bool Equals(GCLOLCGDHHG OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x75D2040", Offset = "0x75D1440", VA = "0x1875D2040", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class NILOAKFBLIP<THasTokensTag> : BIEGIJNILGB, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Dictionary<Entity, GCLOLCGDHHG> MHMPIGKFGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Stack<HashSet<object>> PNDMANKJMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EIGPGNLJKGL<GCLOLCGDHHG, HashSet<object>> EAJIFKHLIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private EntityManager IDCNJMKKJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private EntityCommandBufferSystem FOELCIFKJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool NLNPPHMOFNH;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4E3A6D0", Offset = "0x4E39AD0", VA = "0x184E3A6D0")]
	public NILOAKFBLIP(EntityManager IDCNJMKKJFI, EntityCommandBufferSystem FOELCIFKJBD, IBCMILIKEJG CPKAPNAGLFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4E39610", Offset = "0x4E38A10", VA = "0x184E39610", Slot = "4")]
	public bool LNHIFBIMEKL(Entity FCJGDHPNMHF, object LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4E39BC0", Offset = "0x4E38FC0", VA = "0x184E39BC0", Slot = "5")]
	public bool LPFPAJKKJJE(Entity FCJGDHPNMHF, object LAAJFAFNFCN, [Out] bool JLLPGEAIAFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4E37670", Offset = "0x4E36A70", VA = "0x184E37670", Slot = "6")]
	public bool BEENACDECBP(Entity FCJGDHPNMHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4E37930", Offset = "0x4E36D30", VA = "0x184E37930", Slot = "8")]
	public bool BEENACDECBP(GCLOLCGDHHG ILIIBOPHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4E381E0", Offset = "0x4E375E0", VA = "0x184E381E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4E37A50", Offset = "0x4E36E50", VA = "0x184E37A50")]
	private void BPOIDKGIGCM(HashSet<object> MOKKKJGHAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4E37E10", Offset = "0x4E37210", VA = "0x184E37E10")]
	private bool CHINOEHHCFB(Entity FCJGDHPNMHF, [Out] GCLOLCGDHHG ILIIBOPHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4E37FA0", Offset = "0x4E373A0", VA = "0x184E37FA0")]
	private bool DMPKLHIMBKP(Entity FCJGDHPNMHF, [Out] GCLOLCGDHHG ILIIBOPHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4E38660", Offset = "0x4E37A60", VA = "0x184E38660")]
	private void FHKJKNOICFN(Entity FCJGDHPNMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4E38C60", Offset = "0x4E38060", VA = "0x184E38C60")]
	private void ICFGNMMDLMI(Entity FCJGDHPNMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4E38380", Offset = "0x4E37780", VA = "0x184E38380")]
	private void EHNAHHKPOEI(Entity FCJGDHPNMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4E38DD0", Offset = "0x4E381D0", VA = "0x184E38DD0")]
	private void IEILLIGMEBM(Entity FCJGDHPNMHF, GCLOLCGDHHG ILIIBOPHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4E38F80", Offset = "0x4E38380", VA = "0x184E38F80")]
	private bool IJDEHBJHINK(GCLOLCGDHHG ILIIBOPHLDK, [Out] HashSet<object> MOKKKJGHAGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4E3A040", Offset = "0x4E39440", VA = "0x184E3A040")]
	private HashSet<object> PNEGDKJGKIC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class NDNAAGCPIBA
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct LFHJGEGOBJC : EPHFAFOOMPH<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x75D2600", Offset = "0x75D1A00", VA = "0x1875D2600")]
	public float BMBDKKIJGOB([In] float3 KBGCCIOIGBD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x75D2600", Offset = "0x75D1A00", VA = "0x1875D2600", Slot = "4")]
	private float GDFFEJCOOLA([In] float3 KBGCCIOIGBD)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct JENIGCEGDJG : EPHFAFOOMPH<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x75D2420", Offset = "0x75D1820", VA = "0x1875D2420")]
	public float BMBDKKIJGOB([In] float3 KBGCCIOIGBD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x75D2420", Offset = "0x75D1820", VA = "0x1875D2420", Slot = "4")]
	private float GDFFEJCOOLA([In] float3 KBGCCIOIGBD)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct PIALIPIBGGD : EPHFAFOOMPH<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0xCF90E0", Offset = "0xCF84E0", VA = "0x180CF90E0")]
	public float BMBDKKIJGOB([In] float3 KBGCCIOIGBD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xCF90E0", Offset = "0xCF84E0", VA = "0x180CF90E0", Slot = "4")]
	private float GDFFEJCOOLA([In] float3 KBGCCIOIGBD)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct FPAIGEOGLNK : EPHFAFOOMPH<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1EF61A0", Offset = "0x1EF55A0", VA = "0x181EF61A0")]
	public int BMBDKKIJGOB([In] int3 KBGCCIOIGBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1EF61A0", Offset = "0x1EF55A0", VA = "0x181EF61A0", Slot = "4")]
	private int KCKGIFBDMDP([In] int3 KBGCCIOIGBD)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct AECIKNIBJIC : EPHFAFOOMPH<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x75C0CE0", Offset = "0x75C00E0", VA = "0x1875C0CE0")]
	public int BMBDKKIJGOB([In] int3 KBGCCIOIGBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x75C0CE0", Offset = "0x75C00E0", VA = "0x1875C0CE0", Slot = "4")]
	private int KCKGIFBDMDP([In] int3 KBGCCIOIGBD)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct IOGDELCMOJL : EPHFAFOOMPH<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xCDE240", Offset = "0xCDD640", VA = "0x180CDE240")]
	public int BMBDKKIJGOB([In] int3 KBGCCIOIGBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xCDE240", Offset = "0xCDD640", VA = "0x180CDE240", Slot = "4")]
	private int KCKGIFBDMDP([In] int3 KBGCCIOIGBD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class MGCKAMJHHLG : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1DEE790", Offset = "0x1DEDB90", VA = "0x181DEE790")]
	public MGCKAMJHHLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class GNKNFKJHPCF : SystemBase, KLHENFHFJFG
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string OPDMIMOEGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x75D2280", Offset = "0x75D1680", VA = "0x1875D2280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x339D9C0", Offset = "0x339CDC0", VA = "0x18339D9C0")]
	public void LFKIPFNIFKL<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x339D9C0", Offset = "0x339CDC0", VA = "0x18339D9C0")]
	public void PECFOGIABCI<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x75D22B0", Offset = "0x75D16B0", VA = "0x1875D22B0")]
	public JobHandle NHIHBDHAEMA(ReadOnlySpan<int> GDIIOHJFBNA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x339D7F0", Offset = "0x339CBF0", VA = "0x18339D7F0")]
	public JobHandle FHJEFGMNIEE<T>() where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x75D21C0", Offset = "0x75D15C0", VA = "0x1875D21C0")]
	public JobHandle FHJEFGMNIEE(ReadOnlySpan<int> GDIIOHJFBNA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x339CEA0", Offset = "0x339C2A0", VA = "0x18339CEA0")]
	public void FENBOKAGMHO<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x339CF30", Offset = "0x339C330", VA = "0x18339CF30")]
	public JobHandle FENBOKAGMHO<T>(JobHandle ILIIBOPHLDK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x75D2150", Offset = "0x75D1550", VA = "0x1875D2150")]
	public JobHandle FENBOKAGMHO(ReadOnlySpan<int> GDIIOHJFBNA, JobHandle ILIIBOPHLDK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x339CEA0", Offset = "0x339C2A0", VA = "0x18339CEA0")]
	public void MBNCDNJAAHH<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x339DA20", Offset = "0x339CE20", VA = "0x18339DA20")]
	public JobHandle MBNCDNJAAHH<T>(JobHandle ILIIBOPHLDK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x75D2210", Offset = "0x75D1610", VA = "0x1875D2210")]
	public JobHandle MBNCDNJAAHH(Span<int> GDIIOHJFBNA, JobHandle ILIIBOPHLDK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x339CD00", Offset = "0x339C100", VA = "0x18339CD00")]
	public ComponentDataFromEntity BEIHIAIIEOF<T>(bool PALJJFCJPCE = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x75D2090", Offset = "0x75D1490", VA = "0x1875D2090")]
	public ComponentDataFromEntity BEIHIAIIEOF(int EMKALOADEAO, bool PALJJFCJPCE = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x339CDD0", Offset = "0x339C1D0", VA = "0x18339CDD0")]
	public SharedComponentIndexFromEntity<T> EGMDEMNEHLK<T>() where T : ISharedComponentData
	{
		return default(SharedComponentIndexFromEntity<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x75D2300", Offset = "0x75D1700", VA = "0x1875D2300")]
	[BurstCompatible]
	public ComponentTypeHandle OFKKMNEGELB(ComponentType CNJAPIPFOOO)
	{
		return default(ComponentTypeHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x75D2360", Offset = "0x75D1760", VA = "0x1875D2360")]
	public EntityExistenceLookupByEntity OKMLPNGICLP()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x75D2380", Offset = "0x75D1780", VA = "0x1875D2380", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x339D8A0", Offset = "0x339CCA0", VA = "0x18339D8A0")]
	public bool FPHANGEJGDN<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "7")]
	protected sealed override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1DEE790", Offset = "0x1DEDB90", VA = "0x181DEE790")]
	protected GNKNFKJHPCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class AEABKBFCCAP : GNKNFKJHPCF
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x75D1AD0", Offset = "0x75D0ED0", VA = "0x1875D1AD0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1DEE790", Offset = "0x1DEDB90", VA = "0x181DEE790")]
	protected AEABKBFCCAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class OIIKGIGHCFE
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class KAJEDPMNAMN : EntityCommandBufferSystem, KLHENFHFJFG
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private IBCMILIKEJG IEGNOINNOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xC07FE0", Offset = "0xC073E0", VA = "0x180C07FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x75D2430", Offset = "0x75D1830", VA = "0x1875D2430")]
	public KAJEDPMNAMN(IBCMILIKEJG DDKJAEALMGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface EPHFAFOOMPH<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo BMBDKKIJGOB([In] TFrom KBGCCIOIGBD);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface NEFFKFBILLD<T>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FJFDKDAALHE(T KBGCCIOIGBD);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct OHBBBNAMNNC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> AKCBEPDCJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer OLJBMBDPGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public ComponentTypes DGINANONIMD;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x75D2870", Offset = "0x75D1C70", VA = "0x1875D2870", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct FCJAIIBKEDD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	public NativeArray<Entity> AKCBEPDCJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public EntityCommandBuffer OLJBMBDPGAK;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x75D1F40", Offset = "0x75D1340", VA = "0x1875D1F40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
internal struct LBLPFDDIMMA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> AKCBEPDCJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer OLJBMBDPGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public ComponentType CNJAPIPFOOO;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x75D2460", Offset = "0x75D1860", VA = "0x1875D2460", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[BurstCompile]
internal struct DJJOLOIEFAJ<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> AKCBEPDCJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> GIDGOODJFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer OLJBMBDPGAK;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x62B0460", Offset = "0x62AF860", VA = "0x1862B0460", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal struct NIINPNOGPDK<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> AKCBEPDCJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<T> BMKDAHEBDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer OLJBMBDPGAK;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal struct KMCFKOHOELK<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<Entity> AKCBEPDCJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public T KBGCCIOIGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public EntityCommandBuffer OLJBMBDPGAK;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct HIDHFDGOBAG<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, EPHFAFOOMPH<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<TFrom> ABPEPCEHPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<TTo> NIJPJBFDLGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public TMap PJDAFKMDDCG;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct EENOBFPNGBE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity MBJGLNHGCKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> ABPEPCEHPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeArray<byte> NIJPJBFDLGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int EBDFHKFLLAE;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x75D1E20", Offset = "0x75D1220", VA = "0x1875D1E20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct PHGEEDJNIKL<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> JGFLIPPADDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[ReadOnly]
	public NativeArray<Entity> ABPEPCEHPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[WriteOnly]
	public NativeList<T> OLGBFKJIGBD;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct GGHAPOCNPJL<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, EPHFAFOOMPH<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<TFrom> NEIIPIMINIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[WriteOnly]
	public NativeList<TTo> NIJPJBFDLGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public TMap PJDAFKMDDCG;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct LHOOEEGIFNJ<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> EIPNGMOKDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> JCIJLFIIGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> GKGANAJJPCO;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal struct FNNLGPDCCFK<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public ComponentDataFromEntity<T> EIPNGMOKDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<Entity> JCIJLFIIGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<bool> GKGANAJJPCO;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x43DEFF0", Offset = "0x43DE3F0", VA = "0x1843DEFF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct PHHAIHCPMOI<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<T> ABPEPCEHPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<T> OLGBFKJIGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<T> HKJPAOLEDME;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5089F10", Offset = "0x5089310", VA = "0x185089F10", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct JOEBDNONHKM<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : EPHFAFOOMPH<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<TFrom> ABPEPCEHPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public NativeList<TFrom> OLGBFKJIGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeParallelHashSet<TTo> HKJPAOLEDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TMap PJDAFKMDDCG;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct LLAEMMIIOOB<T, TPredicate> : IJob where T : struct where TPredicate : struct, NEFFKFBILLD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> ABPEPCEHPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<Entity> JAOLADMLAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<Entity> FEHNGENEKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate PJDAFKMDDCG;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct FADPHJBPPOB<T, TPredicate> : IJob where T : struct where TPredicate : struct, NEFFKFBILLD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> ABPEPCEHPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> OLGBFKJIGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TPredicate PJDAFKMDDCG;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct ADHGANIGANH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity EIPNGMOKDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> JCIJLFIIGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> LAAMEKFJPEO;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x75D1A40", Offset = "0x75D0E40", VA = "0x1875D1A40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct IJJDAMPBGJB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[ReadOnly]
	public ComponentDataFromEntity EIPNGMOKDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<Entity> JCIJLFIIGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<Entity> LAAMEKFJPEO;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x75D2390", Offset = "0x75D1790", VA = "0x1875D2390", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class NDJEFIHMGKG
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class AAPAHPDFGLB
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3B265E0", Offset = "0x3B259E0", VA = "0x183B265E0")]
	public static bool IDEDKEHGMIP<T>(this NativeArray<Entity> JCIJLFIIGCI, EntityManager IDCNJMKKJFI, Allocator LEILKJFLDFN = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class BMPACJCMPIM
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class IEANMJAEGFO<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		public IEANMJAEGFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class NIIKLFFEDCL<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		public NIIKLFFEDCL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly List<Func<JobHandle, JobHandle>> IBCBCNCMCDD;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x75D1D90", Offset = "0x75D1190", VA = "0x1875D1D90")]
	public BMPACJCMPIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class IEPEHGOIBIP
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class FELJENBHOCC
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct AKILGEIFFPO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct DGEFAHEFJKK<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal AKILGEIFFPO<TFrom> LDIAONMHHPK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator LEILKJFLDFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeArray<TFrom> MOEBIEOOLFC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct MHKOAEFDNGO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct FNPJKHKMDJD<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal MHKOAEFDNGO<TFrom> LDIAONMHHPK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator LEILKJFLDFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeList<TFrom> MOEBIEOOLFC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct HOPABBOEACN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct KJIBKGMKLEE<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal HOPABBOEACN<TFrom> LDIAONMHHPK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator LEILKJFLDFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeArrayAsync<TFrom> MOEBIEOOLFC;
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct LELLICLANMB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public struct KFGOFOLNJCE<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			internal LELLICLANMB<TFrom> LDIAONMHHPK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal Allocator LEILKJFLDFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal NativeListAsync<TFrom> MOEBIEOOLFC;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class GBCLKHGCDFN
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class KKMJLJAIPGC
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x346C300", Offset = "0x346B700", VA = "0x18346C300")]
	public static NativeList<T> NINCFPMAJMA<T>(this NativeArray<T> LEMHIPNDEKF, Allocator LEILKJFLDFN = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class IBPAKACJBIO
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class PNJMEBAILOB
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x35CF9F0", Offset = "0x35CEDF0", VA = "0x1835CF9F0")]
	[JMPOMCPCCMI]
	public static JobHandle OJKNLIBHPKP<T>(this EntityCommandBufferSystem FOELCIFKJBD, NativeArray<Entity> AKCBEPDCJFL, NativeArray<T> GIDGOODJFLJ) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x35CFAE0", Offset = "0x35CEEE0", VA = "0x1835CFAE0")]
	[JMPOMCPCCMI]
	public static JobHandle OJKNLIBHPKP<T>(this EntityCommandBufferSystem FOELCIFKJBD, NativeArrayAsync<Entity> AKCBEPDCJFL, NativeArrayAsync<T> GIDGOODJFLJ, [Optional] JobHandle ODEGOODBELJ) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x35CF8C0", Offset = "0x35CECC0", VA = "0x1835CF8C0")]
	[JMPOMCPCCMI]
	public static JobHandle OJKNLIBHPKP<T>(this EntityCommandBufferSystem FOELCIFKJBD, NativeArray<Entity> AKCBEPDCJFL, [Optional] JobHandle ODEGOODBELJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x75D2AF0", Offset = "0x75D1EF0", VA = "0x1875D2AF0")]
	[JMPOMCPCCMI]
	public static JobHandle OJKNLIBHPKP(this EntityCommandBufferSystem FOELCIFKJBD, NativeArray<Entity> AKCBEPDCJFL, ComponentTypes DGINANONIMD, [Optional] JobHandle ODEGOODBELJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x75D29A0", Offset = "0x75D1DA0", VA = "0x1875D29A0")]
	[JMPOMCPCCMI]
	public static JobHandle OJKNLIBHPKP(this EntityCommandBufferSystem FOELCIFKJBD, EntityCommandBuffer OLJBMBDPGAK, NativeArray<Entity> AKCBEPDCJFL, ComponentTypes DGINANONIMD, [Optional] JobHandle ODEGOODBELJ)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class NNBLCFLHLCJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class AGPGHNFOKDN
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x75D1B00", Offset = "0x75D0F00", VA = "0x1875D1B00")]
	[JMPOMCPCCMI]
	public static JobHandle OPMDCFLFKLA(this EntityCommandBufferSystem FOELCIFKJBD, NativeList<Entity> AKCBEPDCJFL, [Optional] JobHandle ODEGOODBELJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x75D1C90", Offset = "0x75D1090", VA = "0x1875D1C90")]
	[JMPOMCPCCMI]
	public static JobHandle OPMDCFLFKLA(this EntityCommandBufferSystem FOELCIFKJBD, NativeArrayAsync<Entity> AKCBEPDCJFL)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class GDFIGMAAODG
{
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class KOKLEDNBPME
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x346DD10", Offset = "0x346D110", VA = "0x18346DD10")]
	[JMPOMCPCCMI]
	public static JobHandle NAJIHHJNAEP<T>(this EntityCommandBufferSystem FOELCIFKJBD, NativeArray<Entity> AKCBEPDCJFL, NativeArray<T> GIDGOODJFLJ, JobHandle ODEGOODBELJ) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class LGFPOFKAHPA
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class KPKLLAOAPHN
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class MFLJFIEGGGM
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x34BEA80", Offset = "0x34BDE80", VA = "0x1834BEA80")]
	public static NativeArray<T> BGILPIPOPFC<T>(this NativeList<Entity> LEMHIPNDEKF, EntityManager IDCNJMKKJFI, Allocator LEILKJFLDFN = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x34BE6C0", Offset = "0x34BDAC0", VA = "0x1834BE6C0")]
	public static NativeArray<T> BGILPIPOPFC<T>(this NativeArray<Entity> LEMHIPNDEKF, EntityManager IDCNJMKKJFI, Allocator LEILKJFLDFN = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x75D2610", Offset = "0x75D1A10", VA = "0x1875D2610")]
	public static NativeArray<Entity> OJOINJNBINB(this NativeArray<Entity> LEMHIPNDEKF, EntityManager IDCNJMKKJFI, ComponentType CNJAPIPFOOO, Allocator LEILKJFLDFN = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x34BEE00", Offset = "0x34BE200", VA = "0x1834BEE00")]
	public static NativeArray<T> DNOPFPOHNAN<T>(this NativeArray<Entity> LEMHIPNDEKF, EntityManager IDCNJMKKJFI, Allocator LEILKJFLDFN = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class OJNFGCKDFNA
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct FILPFGAEANG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct JKKEPDAJFKK<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public FILPFGAEANG<TFrom> MOEBIEOOLFC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator LEILKJFLDFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArray<TFrom> ABPEPCEHPHC;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct IPHCDCCHKEE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct EIGJCDKBDMF<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public IPHCDCCHKEE<TFrom> MOEBIEOOLFC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator LEILKJFLDFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeArrayAsync<TFrom> ABPEPCEHPHC;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct CIJHBGDOPKI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public struct JFGNALFBELD<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public CIJHBGDOPKI<TFrom> MOEBIEOOLFC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator LEILKJFLDFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeListAsync<TFrom> ABPEPCEHPHC;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class DFNHPKILBPC
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class DEBEBFMFJCK
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct FGEAEFMLOJG : EPHFAFOOMPH<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> DMMMLPALPDD;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x75D1FE0", Offset = "0x75D13E0", VA = "0x1875D1FE0")]
		[BurstCompatible]
		public Entity BMBDKKIJGOB([In] Entity KBGCCIOIGBD)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x75D1FE0", Offset = "0x75D13E0", VA = "0x1875D1FE0", Slot = "4")]
		private Entity IMJLOFKECFO([In] Entity KBGCCIOIGBD)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class LDLPPFJEKNL
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct NALBOPLJOON<TKey, TValue> : IComparer<(TKey, TValue)> where TKey : struct, IComparable<TKey> where TValue : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4E1E1A0", Offset = "0x4E1D5A0", VA = "0x184E1E1A0", Slot = "4")]
		public int Compare((TKey, TValue) IKAEODCKAIP, (TKey, TValue) ACCJFOPIMAB)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x347BDF0", Offset = "0x347B1F0", VA = "0x18347BDF0")]
	public static void LFJNGICDIID<TKey, TValue>(NativeList<TKey> ICMACDJDFMF, NativeList<TValue> BMKDAHEBDHE) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x347C2C0", Offset = "0x347B6C0", VA = "0x18347C2C0")]
	public static void LFJNGICDIID<TKey, TValue>(NativeArray<TKey> ICMACDJDFMF, NativeArray<TValue> BMKDAHEBDHE) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x347C080", Offset = "0x347B480", VA = "0x18347C080")]
	public static void LFJNGICDIID<TKey, TValue, U>(NativeArray<TKey> ICMACDJDFMF, NativeArray<TValue> BMKDAHEBDHE, U GCKFDIGJEHJ) where TKey : struct where TValue : struct where U : struct, IComparer<(TKey, TValue)>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class LJIDKHOCCFP
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct INJIIMHGIBB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator LEILKJFLDFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<Entity> JAOLADMLAOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> ABPEPCEHPHC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct GBBOCIIIGMB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator LEILKJFLDFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeList<Entity> JAOLADMLAOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArray<T> ABPEPCEHPHC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct KNNKCEJBDAD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator LEILKJFLDFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArrayAsync<Entity> JAOLADMLAOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArrayAsync<T> ABPEPCEHPHC;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class EFNHKHHAMAL
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class BBELPNFBHMK
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct CMGKKGGNFFO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator LEILKJFLDFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArray<T> ABPEPCEHPHC;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct EDGBLIMHKLP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator LEILKJFLDFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeList<T> ABPEPCEHPHC;
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct CFLDHEKFJBL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator LEILKJFLDFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<T> ABPEPCEHPHC;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct OLHHABMBPDD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Allocator LEILKJFLDFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public NativeListAsync<T> ABPEPCEHPHC;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class AEGPLLDHIPA
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class FCKLIPEGGBN
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3377FD0", Offset = "0x33773D0", VA = "0x183377FD0")]
	public static NativeList<Entity> GDLKHMLPACM<T>(this NativeList<Entity> JCIJLFIIGCI, EntityManager IDCNJMKKJFI, Allocator LEILKJFLDFN = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3377B20", Offset = "0x3376F20", VA = "0x183377B20")]
	public static NativeList<Entity> GDLKHMLPACM<T>(this NativeArray<Entity> JCIJLFIIGCI, EntityManager IDCNJMKKJFI, Allocator LEILKJFLDFN = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class DDPNHAHLNHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x32022B0", Offset = "0x32016B0", VA = "0x1832022B0")]
	public static NativeList<Entity> KNLAEHPGGIC<T>(this NativeArray<Entity> JCIJLFIIGCI, EntityManager IDCNJMKKJFI, Allocator LEILKJFLDFN = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class BEIICDDCIFE
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public readonly struct CJICPLHNLON<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> CJFOOLJEHLK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public readonly struct OMJOGAHOEJD<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly NativeArray<TSrc> CJFOOLJEHLK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public readonly struct AJOIIENIGGN<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, EPHFAFOOMPH<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly NativeArray<TSrc> CJFOOLJEHLK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct IJJBPHJJLNN<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, EPHFAFOOMPH<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly NativeArray<TSrc> CJFOOLJEHLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TSelector CFOIADACGKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int EAHKFAJBNDN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct NELFDPLDDLN<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, EPHFAFOOMPH<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private IJJBPHJJLNN<TSrc, TValue, TSelector> KGHMANIHPMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TValue NEEADIPNPEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int EKDINNHMJFC;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class NGEHGLBJDII
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct MOLMHKJFOIN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<T> CJFOOLJEHLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int EKDINNHMJFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int FDLHNKBAJJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private T NEEADIPNPEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T FBNDIKIJGBM;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public AFAOEOIHAIH PFEPFBLCBEE
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x4DD9250", Offset = "0x4DD8650", VA = "0x184DD9250")]
			get
			{
				return default(AFAOEOIHAIH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public T LGLJDDOJIHE
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public (T, AFAOEOIHAIH) FJMLFGNPDDN
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x4DD9630", Offset = "0x4DD8A30", VA = "0x184DD9630")]
			get
			{
				return default((T, AFAOEOIHAIH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x4DD9950", Offset = "0x4DD8D50", VA = "0x184DD9950")]
		public MOLMHKJFOIN(NativeArray<T> CJFOOLJEHLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x40C41D0", Offset = "0x40C35D0", VA = "0x1840C41D0")]
		public MOLMHKJFOIN<T> BNIMLGJMJBK()
		{
			return default(MOLMHKJFOIN<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x4DD9360", Offset = "0x4DD8760", VA = "0x184DD9360")]
		public bool EIBHGILODBL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3563E90", Offset = "0x3563290", VA = "0x183563E90")]
		public BHJELIFCCJB<T, TComparer> LMMDHBJHHNB<TComparer>([Optional] TComparer GCKFDIGJEHJ) where TComparer : struct, IEqualityComparer<T>
		{
			return default(BHJELIFCCJB<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct BHJELIFCCJB<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly NativeArray<T> CJFOOLJEHLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int EKDINNHMJFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int FDLHNKBAJJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private T NEEADIPNPEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private T FBNDIKIJGBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TComparer GCKFDIGJEHJ;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public AFAOEOIHAIH PFEPFBLCBEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x4DD9250", Offset = "0x4DD8650", VA = "0x184DD9250")]
			get
			{
				return default(AFAOEOIHAIH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public T LGLJDDOJIHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public (T value, AFAOEOIHAIH range) FJMLFGNPDDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x4DD9630", Offset = "0x4DD8A30", VA = "0x184DD9630")]
			get
			{
				return default((T, AFAOEOIHAIH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x583CBD0", Offset = "0x583BFD0", VA = "0x18583CBD0")]
		public BHJELIFCCJB(NativeArray<T> CJFOOLJEHLK, TComparer GCKFDIGJEHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x35B7AC0", Offset = "0x35B6EC0", VA = "0x1835B7AC0")]
		public BHJELIFCCJB<T, TComparer> BNIMLGJMJBK()
		{
			return default(BHJELIFCCJB<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x583C990", Offset = "0x583BD90", VA = "0x18583C990")]
		public bool EIBHGILODBL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x353A310", Offset = "0x3539710", VA = "0x18353A310")]
	public static MOLMHKJFOIN<T> PDJCGJLLFGN<T>(this NativeArray<T> CJFOOLJEHLK) where T : struct
	{
		return default(MOLMHKJFOIN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface CMEOOJNHJGC
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class ILJPDDOMKCC
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct EABGIENAIAB<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class PFMHGOLOBNK : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public EABGIENAIAB<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xA998F0", Offset = "0xA98CF0", VA = "0x180A998F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x4441AB0", Offset = "0x4440EB0", VA = "0x184441AB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
		[DebuggerHidden]
		public PFMHGOLOBNK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5083C00", Offset = "0x5083000", VA = "0x185083C00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5083DD0", Offset = "0x50831D0", VA = "0x185083DD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly Action<Protobuf> NBKILJCMCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly MemoryStream EEGCINGNJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CodedInputStream KAMJMMAIFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Protobuf CAFMPIKGEAO;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly int AFNDGLAJDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA836D0", Offset = "0xA82AD0", VA = "0x180A836D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3FF5100", Offset = "0x3FF4500", VA = "0x183FF5100", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3FF5140", Offset = "0x3FF4540", VA = "0x183FF5140", Slot = "4")]
	[IteratorStateMachine(typeof(EABGIENAIAB<>.PFMHGOLOBNK))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3FF5240", Offset = "0x3FF4640", VA = "0x183FF5240", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct FLPCBMDKDKL<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly byte[] DEEIKCMDENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly Protobuf CAFMPIKGEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MemoryStream EEGCINGNJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CodedOutputStream MMBLGFBEHEH;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x43D9C50", Offset = "0x43D9050", VA = "0x1843D9C50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct OIDKIIMFDOK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream EEGCINGNJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedInputStream KAMJMMAIFEO;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x75D2960", Offset = "0x75D1D60", VA = "0x1875D2960", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct LECJMMCOCHH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] DEEIKCMDENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly MemoryStream EEGCINGNJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly CodedOutputStream MMBLGFBEHEH;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x75D24E0", Offset = "0x75D18E0", VA = "0x1875D24E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class DDPJJHLPCCE
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class JONDONMDAPP
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[Flags]
public enum LHPAAJNIOCL
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Live = 1,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Editor = 3,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Main = 5,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	Simulation = 9,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Conversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Staging = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	Shadow = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Loading = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	Saving = 0x100
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class MIFNJDKCEIL
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class OKEBKGOCPLK
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public OKEBKGOCPLK()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
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
