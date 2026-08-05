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
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
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
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
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
		[Cpp2IlInjected.Address(RVA = "0x7670DF0", Offset = "0x766F3F0", VA = "0x187670DF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x97C6E0", Offset = "0x97ACE0", VA = "0x18097C6E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x97C720", Offset = "0x97AD20", VA = "0x18097C720")]
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
		[Cpp2IlInjected.Address(RVA = "0x7670520", Offset = "0x766EB20", VA = "0x187670520")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D45830", Offset = "0x3D43E30", VA = "0x183D45830")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x46328F0", Offset = "0x4630EF0", VA = "0x1846328F0")]
		public bool DMEJCABDKPG([Out] TValue KBGCCIOIGBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4632AE0", Offset = "0x46310E0", VA = "0x184632AE0")]
		public void HBHDBABAKDP(object LAAJFAFNFCN, TValue KBGCCIOIGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4632BC0", Offset = "0x46311C0", VA = "0x184632BC0")]
		public bool OCDDHDAHAOD(object LAAJFAFNFCN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4632A00", Offset = "0x4631000", VA = "0x184632A00")]
		public int FBHOADIJODJ(object LAAJFAFNFCN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4632C70", Offset = "0x4631270", VA = "0x184632C70")]
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
	[Cpp2IlInjected.Address(RVA = "0x4BC1C70", Offset = "0x4BC0270", VA = "0x184BC1C70")]
	public LJPBHEEFGCL(EntityManager IDCNJMKKJFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4BC17C0", Offset = "0x4BBFDC0", VA = "0x184BC17C0", Slot = "4")]
	public void LNHIFBIMEKL(Entity FCJGDHPNMHF, object LAAJFAFNFCN, TValue KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4BC1940", Offset = "0x4BBFF40", VA = "0x184BC1940", Slot = "5")]
	public bool LPFPAJKKJJE(Entity FCJGDHPNMHF, object LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4BC1590", Offset = "0x4BBFB90", VA = "0x184BC1590", Slot = "6")]
	public bool DMEJCABDKPG(Entity FCJGDHPNMHF, [Out] TValue KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4BC16A0", Offset = "0x4BBFCA0", VA = "0x184BC16A0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4BC1410", Offset = "0x4BBFA10", VA = "0x184BC1410")]
	private void BPOIDKGIGCM(HFDAJBLPELN MOKKKJGHAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4BC14D0", Offset = "0x4BBFAD0", VA = "0x184BC14D0")]
	private bool CHINOEHHCFB(Entity FCJGDHPNMHF, [Out] GCLOLCGDHHG ILIIBOPHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4BC16C0", Offset = "0x4BBFCC0", VA = "0x184BC16C0")]
	private void IEILLIGMEBM(Entity FCJGDHPNMHF, GCLOLCGDHHG ILIIBOPHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4BC1B30", Offset = "0x4BC0130", VA = "0x184BC1B30")]
	private bool LPOFGGELADP(GCLOLCGDHHG ILIIBOPHLDK, [Out] HFDAJBLPELN MOKKKJGHAGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4BC1B50", Offset = "0x4BC0150", VA = "0x184BC1B50")]
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
		[Cpp2IlInjected.Address(RVA = "0x99D850", Offset = "0x99BE50", VA = "0x18099D850", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x10AD620", Offset = "0x10ABC20", VA = "0x1810AD620", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BBB1F0", Offset = "0x2BB97F0", VA = "0x182BBB1F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x67C36C0", Offset = "0x67C1CC0", VA = "0x1867C36C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x76705F0", Offset = "0x766EBF0", VA = "0x1876705F0", Slot = "8")]
	public bool Equals(GCLOLCGDHHG OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7670640", Offset = "0x766EC40", VA = "0x187670640", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EA4CE0", Offset = "0x4EA32E0", VA = "0x184EA4CE0")]
	public NILOAKFBLIP(EntityManager IDCNJMKKJFI, EntityCommandBufferSystem FOELCIFKJBD, IBCMILIKEJG CPKAPNAGLFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4EA3C20", Offset = "0x4EA2220", VA = "0x184EA3C20", Slot = "4")]
	public bool LNHIFBIMEKL(Entity FCJGDHPNMHF, object LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4EA41D0", Offset = "0x4EA27D0", VA = "0x184EA41D0", Slot = "5")]
	public bool LPFPAJKKJJE(Entity FCJGDHPNMHF, object LAAJFAFNFCN, [Out] bool JLLPGEAIAFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1C80", Offset = "0x4EA0280", VA = "0x184EA1C80", Slot = "6")]
	public bool BEENACDECBP(Entity FCJGDHPNMHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1F40", Offset = "0x4EA0540", VA = "0x184EA1F40", Slot = "8")]
	public bool BEENACDECBP(GCLOLCGDHHG ILIIBOPHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4EA27F0", Offset = "0x4EA0DF0", VA = "0x184EA27F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4EA2060", Offset = "0x4EA0660", VA = "0x184EA2060")]
	private void BPOIDKGIGCM(HashSet<object> MOKKKJGHAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4EA2420", Offset = "0x4EA0A20", VA = "0x184EA2420")]
	private bool CHINOEHHCFB(Entity FCJGDHPNMHF, [Out] GCLOLCGDHHG ILIIBOPHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4EA25B0", Offset = "0x4EA0BB0", VA = "0x184EA25B0")]
	private bool DMPKLHIMBKP(Entity FCJGDHPNMHF, [Out] GCLOLCGDHHG ILIIBOPHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4EA2C70", Offset = "0x4EA1270", VA = "0x184EA2C70")]
	private void FHKJKNOICFN(Entity FCJGDHPNMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4EA3270", Offset = "0x4EA1870", VA = "0x184EA3270")]
	private void ICFGNMMDLMI(Entity FCJGDHPNMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4EA2990", Offset = "0x4EA0F90", VA = "0x184EA2990")]
	private void EHNAHHKPOEI(Entity FCJGDHPNMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4EA33E0", Offset = "0x4EA19E0", VA = "0x184EA33E0")]
	private void IEILLIGMEBM(Entity FCJGDHPNMHF, GCLOLCGDHHG ILIIBOPHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4EA3590", Offset = "0x4EA1B90", VA = "0x184EA3590")]
	private bool IJDEHBJHINK(GCLOLCGDHHG ILIIBOPHLDK, [Out] HashSet<object> MOKKKJGHAGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4EA4650", Offset = "0x4EA2C50", VA = "0x184EA4650")]
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
	[Cpp2IlInjected.Address(RVA = "0x7670C00", Offset = "0x766F200", VA = "0x187670C00")]
	public float BMBDKKIJGOB([In] float3 KBGCCIOIGBD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7670C00", Offset = "0x766F200", VA = "0x187670C00", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7670A20", Offset = "0x766F020", VA = "0x187670A20")]
	public float BMBDKKIJGOB([In] float3 KBGCCIOIGBD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7670A20", Offset = "0x766F020", VA = "0x187670A20", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0xD09D50", Offset = "0xD08350", VA = "0x180D09D50")]
	public float BMBDKKIJGOB([In] float3 KBGCCIOIGBD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xD09D50", Offset = "0xD08350", VA = "0x180D09D50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x1F19DE0", Offset = "0x1F183E0", VA = "0x181F19DE0")]
	public int BMBDKKIJGOB([In] int3 KBGCCIOIGBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1F19DE0", Offset = "0x1F183E0", VA = "0x181F19DE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x765F2E0", Offset = "0x765D8E0", VA = "0x18765F2E0")]
	public int BMBDKKIJGOB([In] int3 KBGCCIOIGBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x765F2E0", Offset = "0x765D8E0", VA = "0x18765F2E0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0xCEDFA0", Offset = "0xCEC5A0", VA = "0x180CEDFA0")]
	public int BMBDKKIJGOB([In] int3 KBGCCIOIGBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xCEDFA0", Offset = "0xCEC5A0", VA = "0x180CEDFA0", Slot = "4")]
	private int KCKGIFBDMDP([In] int3 KBGCCIOIGBD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class MGCKAMJHHLG : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1E0FC40", Offset = "0x1E0E240", VA = "0x181E0FC40")]
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
		[Cpp2IlInjected.Address(RVA = "0x7670880", Offset = "0x766EE80", VA = "0x187670880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x33E1F70", Offset = "0x33E0570", VA = "0x1833E1F70")]
	public void LFKIPFNIFKL<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x33E1F70", Offset = "0x33E0570", VA = "0x1833E1F70")]
	public void PECFOGIABCI<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x76708B0", Offset = "0x766EEB0", VA = "0x1876708B0")]
	public JobHandle NHIHBDHAEMA(ReadOnlySpan<int> GDIIOHJFBNA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x33E1DA0", Offset = "0x33E03A0", VA = "0x1833E1DA0")]
	public JobHandle FHJEFGMNIEE<T>() where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x76707C0", Offset = "0x766EDC0", VA = "0x1876707C0")]
	public JobHandle FHJEFGMNIEE(ReadOnlySpan<int> GDIIOHJFBNA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x33E1450", Offset = "0x33DFA50", VA = "0x1833E1450")]
	public void FENBOKAGMHO<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x33E14E0", Offset = "0x33DFAE0", VA = "0x1833E14E0")]
	public JobHandle FENBOKAGMHO<T>(JobHandle ILIIBOPHLDK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7670750", Offset = "0x766ED50", VA = "0x187670750")]
	public JobHandle FENBOKAGMHO(ReadOnlySpan<int> GDIIOHJFBNA, JobHandle ILIIBOPHLDK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x33E1450", Offset = "0x33DFA50", VA = "0x1833E1450")]
	public void MBNCDNJAAHH<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x33E1FD0", Offset = "0x33E05D0", VA = "0x1833E1FD0")]
	public JobHandle MBNCDNJAAHH<T>(JobHandle ILIIBOPHLDK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7670810", Offset = "0x766EE10", VA = "0x187670810")]
	public JobHandle MBNCDNJAAHH(Span<int> GDIIOHJFBNA, JobHandle ILIIBOPHLDK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x33E12B0", Offset = "0x33DF8B0", VA = "0x1833E12B0")]
	public ComponentDataFromEntity BEIHIAIIEOF<T>(bool PALJJFCJPCE = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7670690", Offset = "0x766EC90", VA = "0x187670690")]
	public ComponentDataFromEntity BEIHIAIIEOF(int EMKALOADEAO, bool PALJJFCJPCE = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x33E1380", Offset = "0x33DF980", VA = "0x1833E1380")]
	public SharedComponentIndexFromEntity<T> EGMDEMNEHLK<T>() where T : ISharedComponentData
	{
		return default(SharedComponentIndexFromEntity<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7670900", Offset = "0x766EF00", VA = "0x187670900")]
	[BurstCompatible]
	public ComponentTypeHandle OFKKMNEGELB(ComponentType CNJAPIPFOOO)
	{
		return default(ComponentTypeHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7670960", Offset = "0x766EF60", VA = "0x187670960")]
	public EntityExistenceLookupByEntity OKMLPNGICLP()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7670980", Offset = "0x766EF80", VA = "0x187670980", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x33E1E50", Offset = "0x33E0450", VA = "0x1833E1E50")]
	public bool FPHANGEJGDN<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "7")]
	protected sealed override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1E0FC40", Offset = "0x1E0E240", VA = "0x181E0FC40")]
	protected GNKNFKJHPCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class AEABKBFCCAP : GNKNFKJHPCF
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x76700D0", Offset = "0x766E6D0", VA = "0x1876700D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1E0FC40", Offset = "0x1E0E240", VA = "0x181E0FC40")]
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
		[Cpp2IlInjected.Address(RVA = "0xC0C590", Offset = "0xC0AB90", VA = "0x180C0C590")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7670A30", Offset = "0x766F030", VA = "0x187670A30")]
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
	[Cpp2IlInjected.Address(RVA = "0x7670E70", Offset = "0x766F470", VA = "0x187670E70", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7670540", Offset = "0x766EB40", VA = "0x187670540", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7670A60", Offset = "0x766F060", VA = "0x187670A60", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6318630", Offset = "0x6316C30", VA = "0x186318630", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7670420", Offset = "0x766EA20", VA = "0x187670420", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4438BD0", Offset = "0x44371D0", VA = "0x184438BD0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x50E8520", Offset = "0x50E6B20", VA = "0x1850E8520", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7670040", Offset = "0x766E640", VA = "0x187670040", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7670990", Offset = "0x766EF90", VA = "0x187670990", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3B711F0", Offset = "0x3B6F7F0", VA = "0x183B711F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7670390", Offset = "0x766E990", VA = "0x187670390")]
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
	[Cpp2IlInjected.Address(RVA = "0x34B6BA0", Offset = "0x34B51A0", VA = "0x1834B6BA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x36136C0", Offset = "0x3611CC0", VA = "0x1836136C0")]
	[JMPOMCPCCMI]
	public static JobHandle OJKNLIBHPKP<T>(this EntityCommandBufferSystem FOELCIFKJBD, NativeArray<Entity> AKCBEPDCJFL, NativeArray<T> GIDGOODJFLJ) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x36137B0", Offset = "0x3611DB0", VA = "0x1836137B0")]
	[JMPOMCPCCMI]
	public static JobHandle OJKNLIBHPKP<T>(this EntityCommandBufferSystem FOELCIFKJBD, NativeArrayAsync<Entity> AKCBEPDCJFL, NativeArrayAsync<T> GIDGOODJFLJ, [Optional] JobHandle ODEGOODBELJ) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3613590", Offset = "0x3611B90", VA = "0x183613590")]
	[JMPOMCPCCMI]
	public static JobHandle OJKNLIBHPKP<T>(this EntityCommandBufferSystem FOELCIFKJBD, NativeArray<Entity> AKCBEPDCJFL, [Optional] JobHandle ODEGOODBELJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x76710F0", Offset = "0x766F6F0", VA = "0x1876710F0")]
	[JMPOMCPCCMI]
	public static JobHandle OJKNLIBHPKP(this EntityCommandBufferSystem FOELCIFKJBD, NativeArray<Entity> AKCBEPDCJFL, ComponentTypes DGINANONIMD, [Optional] JobHandle ODEGOODBELJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7670FA0", Offset = "0x766F5A0", VA = "0x187670FA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7670100", Offset = "0x766E700", VA = "0x187670100")]
	[JMPOMCPCCMI]
	public static JobHandle OPMDCFLFKLA(this EntityCommandBufferSystem FOELCIFKJBD, NativeList<Entity> AKCBEPDCJFL, [Optional] JobHandle ODEGOODBELJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7670290", Offset = "0x766E890", VA = "0x187670290")]
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
	[Cpp2IlInjected.Address(RVA = "0x34B85B0", Offset = "0x34B6BB0", VA = "0x1834B85B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3509710", Offset = "0x3507D10", VA = "0x183509710")]
	public static NativeArray<T> BGILPIPOPFC<T>(this NativeList<Entity> LEMHIPNDEKF, EntityManager IDCNJMKKJFI, Allocator LEILKJFLDFN = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3509350", Offset = "0x3507950", VA = "0x183509350")]
	public static NativeArray<T> BGILPIPOPFC<T>(this NativeArray<Entity> LEMHIPNDEKF, EntityManager IDCNJMKKJFI, Allocator LEILKJFLDFN = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7670C10", Offset = "0x766F210", VA = "0x187670C10")]
	public static NativeArray<Entity> OJOINJNBINB(this NativeArray<Entity> LEMHIPNDEKF, EntityManager IDCNJMKKJFI, ComponentType CNJAPIPFOOO, Allocator LEILKJFLDFN = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3509A90", Offset = "0x3508090", VA = "0x183509A90")]
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
		[Cpp2IlInjected.Address(RVA = "0x76705E0", Offset = "0x766EBE0", VA = "0x1876705E0")]
		[BurstCompatible]
		public Entity BMBDKKIJGOB([In] Entity KBGCCIOIGBD)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x76705E0", Offset = "0x766EBE0", VA = "0x1876705E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4E7C010", Offset = "0x4E7A610", VA = "0x184E7C010", Slot = "4")]
		public int Compare((TKey, TValue) IKAEODCKAIP, (TKey, TValue) ACCJFOPIMAB)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x34C6950", Offset = "0x34C4F50", VA = "0x1834C6950")]
	public static void LFJNGICDIID<TKey, TValue>(NativeList<TKey> ICMACDJDFMF, NativeList<TValue> BMKDAHEBDHE) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x34C6E20", Offset = "0x34C5420", VA = "0x1834C6E20")]
	public static void LFJNGICDIID<TKey, TValue>(NativeArray<TKey> ICMACDJDFMF, NativeArray<TValue> BMKDAHEBDHE) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x34C6BE0", Offset = "0x34C51E0", VA = "0x1834C6BE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x33BC7A0", Offset = "0x33BADA0", VA = "0x1833BC7A0")]
	public static NativeList<Entity> GDLKHMLPACM<T>(this NativeList<Entity> JCIJLFIIGCI, EntityManager IDCNJMKKJFI, Allocator LEILKJFLDFN = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x33BC2F0", Offset = "0x33BA8F0", VA = "0x1833BC2F0")]
	public static NativeList<Entity> GDLKHMLPACM<T>(this NativeArray<Entity> JCIJLFIIGCI, EntityManager IDCNJMKKJFI, Allocator LEILKJFLDFN = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class DDPNHAHLNHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x324B350", Offset = "0x3249950", VA = "0x18324B350")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E36D90", Offset = "0x4E35390", VA = "0x184E36D90")]
			get
			{
				return default(AFAOEOIHAIH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public T LGLJDDOJIHE
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public (T, AFAOEOIHAIH) FJMLFGNPDDN
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x4E37170", Offset = "0x4E35770", VA = "0x184E37170")]
			get
			{
				return default((T, AFAOEOIHAIH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x4E37490", Offset = "0x4E35A90", VA = "0x184E37490")]
		public MOLMHKJFOIN(NativeArray<T> CJFOOLJEHLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x41193B0", Offset = "0x41179B0", VA = "0x1841193B0")]
		public MOLMHKJFOIN<T> BNIMLGJMJBK()
		{
			return default(MOLMHKJFOIN<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x4E36EA0", Offset = "0x4E354A0", VA = "0x184E36EA0")]
		public bool EIBHGILODBL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3599DB0", Offset = "0x35983B0", VA = "0x183599DB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E36D90", Offset = "0x4E35390", VA = "0x184E36D90")]
			get
			{
				return default(AFAOEOIHAIH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public T LGLJDDOJIHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public (T value, AFAOEOIHAIH range) FJMLFGNPDDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x4E37170", Offset = "0x4E35770", VA = "0x184E37170")]
			get
			{
				return default((T, AFAOEOIHAIH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x58A04C0", Offset = "0x589EAC0", VA = "0x1858A04C0")]
		public BHJELIFCCJB(NativeArray<T> CJFOOLJEHLK, TComparer GCKFDIGJEHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x35FB4D0", Offset = "0x35F9AD0", VA = "0x1835FB4D0")]
		public BHJELIFCCJB<T, TComparer> BNIMLGJMJBK()
		{
			return default(BHJELIFCCJB<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x58A0280", Offset = "0x589E880", VA = "0x1858A0280")]
		public bool EIBHGILODBL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x35B3B20", Offset = "0x35B2120", VA = "0x1835B3B20")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA1810", Offset = "0xA9FE10", VA = "0x180AA1810", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x449B5F0", Offset = "0x4499BF0", VA = "0x18449B5F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
		[DebuggerHidden]
		public PFMHGOLOBNK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x50E22B0", Offset = "0x50E08B0", VA = "0x1850E22B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x50E2480", Offset = "0x50E0A80", VA = "0x1850E2480", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8B580", Offset = "0xA89B80", VA = "0x180A8B580")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4047570", Offset = "0x4045B70", VA = "0x184047570", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x40475B0", Offset = "0x4045BB0", VA = "0x1840475B0", Slot = "4")]
	[IteratorStateMachine(typeof(EABGIENAIAB<>.PFMHGOLOBNK))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x40476B0", Offset = "0x4045CB0", VA = "0x1840476B0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4433830", Offset = "0x4431E30", VA = "0x184433830", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7670F60", Offset = "0x766F560", VA = "0x187670F60", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7670AE0", Offset = "0x766F0E0", VA = "0x187670AE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
