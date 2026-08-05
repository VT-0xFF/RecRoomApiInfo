using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x7965400", Offset = "0x7963E00", VA = "0x187965400")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D8490", Offset = "0x9D6E90", VA = "0x1809D8490")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9D84D0", Offset = "0x9D6ED0", VA = "0x1809D84D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Maker_Core_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x79659F0", Offset = "0x79643F0", VA = "0x1879659F0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2571680", Offset = "0x2570080", VA = "0x182571680")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LDFADPOIMNP<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn GHGLGIKKHLA(TData OIIGDBLKEDN);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface KJMJEKDMPJI<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(IGNMFEOKFOK KPFFGNCKOBP);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData HIKBDNMPFJK, Collider FAJCOBECNNH, IGNMFEOKFOK KPFFGNCKOBP, [Optional] MPMOFPPLHCF? PPGCIMEANJO);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData HIKBDNMPFJK);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider FAJCOBECNNH);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BDOMFFKNNKO<TData> : AHOIIEEOCMB, LEMGDMFIANK<TData>, NOKHLIIFEOO<TData>, CDCACDBEDMM<TData>, BLDMPJKOENG, AOJDAOFCAGD<TData>, ICCDIDJJHGA, IKLOCHGCKAK
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface AOJDAOFCAGD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 JOCLDJFCONL, Vector3 BJECPMGLFMN, float FPNKBMPOCJL, [Out] T AEDIGMPAJLJ, [Out] Vector3 CGMNHLOPNJE, [Out] Collider FAJCOBECNNH);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 JOCLDJFCONL, Vector3 BJECPMGLFMN, float EHGDBLMHNMP, float FPNKBMPOCJL, T[] JMOBMDLEDPL, [Out] Vector3 JBIMCHOJKEM, [Out] Collider KAGNPGLILGK);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 JOCLDJFCONL, float EHGDBLMHNMP, Vector3 DNJLLEKJEGK, T[] JMOBMDLEDPL);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider GKCCNNFCLIL, [Out] T KIKNJEJHGFN);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface AHOIIEEOCMB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds MEIMLBFDCBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform IBBCAGFLOEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds MOOBMPCBNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform KMAJKIOOGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 LHDCHHPKBMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool BOHPAGBNHCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void UpdateLocalSelectionBounds();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetSelectionBoundsDirty(bool PJCPGMKGAEB = true, int GIEIDFAFKCE = 0);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ShouldHideSelectionBoundsPreview(bool ICLMMPONPGD, object GNAAILLDOKI);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface IKLOCHGCKAK
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	COOFKGJALFM AILBEMMDBMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface IHFJKNDKNKC
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool LEFGIDKJAHC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool LPKOLFOHKOP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool KKADGPHJOPA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Dictionary<Guid, Guid> TryGetPreviousCloneMapping();

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> GALPBODHLGO);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CDCACDBEDMM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool HFECHKEPDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int MKPDKBJBHMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> PHAAGKEDHFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData OIBJKKOCOBE);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData OIBJKKOCOBE);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LEMGDMFIANK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T OIIGDBLKEDN, [Optional] MPMOFPPLHCF? FGIHDPOHIFO, bool MHKMPMAENBL = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int PGJKBFGEJNK, IEnumerable<T> CBPBOKCLBOJ, bool MHKMPMAENBL = true);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int PGJKBFGEJNK, IEnumerable<T> CBPBOKCLBOJ, MPMOFPPLHCF FGIHDPOHIFO, bool MHKMPMAENBL = true);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ICCDIDJJHGA
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface BLDMPJKOENG
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool PDCOLPPDIKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool JGNEJBHIMEB
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool LOBNKLDOBKG
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool GINABFHKJPL
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct GKFEFPOICCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public bool LMJMIDIKNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float? BHFDADNDCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public float? AEBIEEMEBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public float? HDICNCEPAPH;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct JOKICCFJJLA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public IEnumerable<TData> KAPGLJHCENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public GKFEFPOICCG KOKKFMJAOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool LPCJPICBOHJ;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4D1AB70", Offset = "0x4D19570", VA = "0x184D1AB70")]
	public JOKICCFJJLA(IEnumerable<TData> FHANMPNELBN, bool OKPDIDEAOMK, float? OMLFEOIKIPO, float? BAKNOLAPDBG, float? JMKHKGILLEJ, bool LPCJPICBOHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface MEKMEHAFDFK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BALGFNNJCDG([In] JOKICCFJJLA<TData> CPDOLKLJBKL);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class GKHJKBENFBL<TData> : EGLNLNGCOJK<MEKMEHAFDFK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly JOKICCFJJLA<TData> CPDOLKLJBKL;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x48D9500", Offset = "0x48D7F00", VA = "0x1848D9500")]
	public GKHJKBENFBL(IEnumerable<TData> FHANMPNELBN, bool OKPDIDEAOMK, float? OMLFEOIKIPO, float? BAKNOLAPDBG, float? JMKHKGILLEJ, bool LPCJPICBOHJ, MEKMEHAFDFK<TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4358B80", Offset = "0x4357580", VA = "0x184358B80", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct FOMIIFBDFAP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public IEnumerable<TData> KAPGLJHCENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public string DJHEIEKDICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public bool PAHKJKCAFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public bool LPCJPICBOHJ;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x47E66E0", Offset = "0x47E50E0", VA = "0x1847E66E0")]
	public FOMIIFBDFAP(IEnumerable<TData> FHANMPNELBN, string PJDPJIKHFCG, bool HLBKMIHOKCF, bool LPCJPICBOHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface OCIIEFCNGLC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BALGFNNJCDG([In] FOMIIFBDFAP<TData> CPDOLKLJBKL);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class LGAIIBKBCCP<TData> : EGLNLNGCOJK<OCIIEFCNGLC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly FOMIIFBDFAP<TData> CPDOLKLJBKL;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4EBB290", Offset = "0x4EB9C90", VA = "0x184EBB290")]
	public LGAIIBKBCCP(IEnumerable<TData> FHANMPNELBN, string PJDPJIKHFCG, bool HLBKMIHOKCF, bool LPCJPICBOHJ, OCIIEFCNGLC<TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4358B80", Offset = "0x4357580", VA = "0x184358B80", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public abstract class EGLNLNGCOJK<TReceiver> : CLEFGIAEJJK<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x435B870", Offset = "0x435A270", VA = "0x18435B870")]
	public EGLNLNGCOJK(TReceiver ELHMFGLAFBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class OPJHBNNNBLL<TReceiver, TFromTask> : CLEFGIAEJJK<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x435B870", Offset = "0x435A270", VA = "0x18435B870")]
	public OPJHBNNNBLL(TReceiver ELHMFGLAFBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class CLEFGIAEJJK<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected TReceiver ELHMFGLAFBF;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6581AE0", Offset = "0x65804E0", VA = "0x186581AE0")]
	public CLEFGIAEJJK(TReceiver ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute BALGFNNJCDG();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class PEBCMPHBIEA<TReceiver, TResult> : CLEFGIAEJJK<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x435B870", Offset = "0x435A270", VA = "0x18435B870")]
	public PEBCMPHBIEA(TReceiver ELHMFGLAFBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct DEHCBCHHOOG<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public TGroup ANIIAOLKCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public TData LNLCHJNKDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public IEnumerable<TData> KAPGLJHCENE;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2582190", Offset = "0x2580B90", VA = "0x182582190")]
	public DEHCBCHHOOG(TGroup GBBMNPADGLC, TData GJODHLHCNCK, IEnumerable<TData> FHANMPNELBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct GDMMELCDCOG<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public TGroup ANIIAOLKCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public IEnumerable<TData> KAPGLJHCENE;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xA487F0", Offset = "0xA471F0", VA = "0x180A487F0")]
	public GDMMELCDCOG(TGroup GBBMNPADGLC, IEnumerable<TData> FHANMPNELBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct FIJFICKIOLF<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public TGroup ANIIAOLKCDC;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xC9BA30", Offset = "0xC9A430", VA = "0x180C9BA30")]
	public FIJFICKIOLF(TGroup GBBMNPADGLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct BDIPJHCNMHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public IEnumerable<Guid> KAPGLJHCENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public Guid NGEBAJBIBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly bool IEKOHPNLGPG;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7963EB0", Offset = "0x79628B0", VA = "0x187963EB0")]
	public BDIPJHCNMHF(IEnumerable<Guid> FHANMPNELBN, Guid DKEABFPCJLD, bool LPCJPICBOHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct ODIJGDGNMIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Guid NGEBAJBIBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly bool IEKOHPNLGPG;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x24728C0", Offset = "0x24712C0", VA = "0x1824728C0")]
	public ODIJGDGNMIJ(Guid DKEABFPCJLD, bool LPCJPICBOHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface MLCCCOFCPHB<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PKJJFLPLKEF KHNAEKLFFNM(DEHCBCHHOOG<TGroup, TData> AIMMCAFHMAP);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PKJJFLPLKEF PKGFHELNNBG(DEHCBCHHOOG<TGroup, TData> AIMMCAFHMAP);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PKJJFLPLKEF AOMBGCLGGNE(GDMMELCDCOG<TGroup, TData> AIMMCAFHMAP);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PKJJFLPLKEF HNOFKPHJCBD(FIJFICKIOLF<TGroup> AIMMCAFHMAP);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface FGNBLPOBHLA
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PKJJFLPLKEF> KHNAEKLFFNM(BDIPJHCNMHF AIMMCAFHMAP);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<PKJJFLPLKEF> PKGFHELNNBG(ODIJGDGNMIJ AIMMCAFHMAP);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class GANFJHKLDNB<TGroup, TData> : PEBCMPHBIEA<MLCCCOFCPHB<TGroup, TData>, PKJJFLPLKEF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly GDMMELCDCOG<TGroup, TData> AIMMCAFHMAP;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x487C3A0", Offset = "0x487ADA0", VA = "0x18487C3A0")]
	public GANFJHKLDNB(TGroup GBBMNPADGLC, IEnumerable<TData> FHANMPNELBN, MLCCCOFCPHB<TGroup, TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x487C2E0", Offset = "0x487ACE0", VA = "0x18487C2E0", Slot = "4")]
	public override PKJJFLPLKEF BALGFNNJCDG()
	{
		return default(PKJJFLPLKEF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class EFMEOBJIGLH<TGroup, TData> : PEBCMPHBIEA<MLCCCOFCPHB<TGroup, TData>, PKJJFLPLKEF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly DEHCBCHHOOG<TGroup, TData> AIMMCAFHMAP;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x435A350", Offset = "0x4358D50", VA = "0x18435A350")]
	public EFMEOBJIGLH(TGroup GBBMNPADGLC, TData BNECIOKKFNB, IEnumerable<TData> FHANMPNELBN, MLCCCOFCPHB<TGroup, TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x435A280", Offset = "0x4358C80", VA = "0x18435A280", Slot = "4")]
	public override PKJJFLPLKEF BALGFNNJCDG()
	{
		return default(PKJJFLPLKEF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class ALMJOBHJHHN<TGroup, TData> : PEBCMPHBIEA<MLCCCOFCPHB<TGroup, TData>, PKJJFLPLKEF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly FIJFICKIOLF<TGroup> AIMMCAFHMAP;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4358CC0", Offset = "0x43576C0", VA = "0x184358CC0")]
	public ALMJOBHJHHN(TGroup GBBMNPADGLC, MLCCCOFCPHB<TGroup, TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5087970", Offset = "0x5086370", VA = "0x185087970", Slot = "4")]
	public override PKJJFLPLKEF BALGFNNJCDG()
	{
		return default(PKJJFLPLKEF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class FKFPNIFGIBL<TGroup, TData> : PEBCMPHBIEA<MLCCCOFCPHB<TGroup, TData>, PKJJFLPLKEF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly DEHCBCHHOOG<TGroup, TData> AIMMCAFHMAP;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x435A350", Offset = "0x4358D50", VA = "0x18435A350")]
	public FKFPNIFGIBL(TGroup GBBMNPADGLC, TData GJODHLHCNCK, IEnumerable<TData> FHANMPNELBN, MLCCCOFCPHB<TGroup, TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x47D6FF0", Offset = "0x47D59F0", VA = "0x1847D6FF0", Slot = "4")]
	public override PKJJFLPLKEF BALGFNNJCDG()
	{
		return default(PKJJFLPLKEF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class ALOBIOEJMEA : OPJHBNNNBLL<FGNBLPOBHLA, PKJJFLPLKEF>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct ACPJLIJLHPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AsyncTaskMethodBuilder<PKJJFLPLKEF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public ALOBIOEJMEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<PKJJFLPLKEF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x79639F0", Offset = "0x79623F0", VA = "0x1879639F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7963C90", Offset = "0x7962690", VA = "0x187963C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private BDIPJHCNMHF AIMMCAFHMAP;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7963DF0", Offset = "0x79627F0", VA = "0x187963DF0")]
	public ALOBIOEJMEA(IEnumerable<Guid> LIHIENHOAAD, Guid DKEABFPCJLD, bool LPCJPICBOHJ, FGNBLPOBHLA ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7963D00", Offset = "0x7962700", VA = "0x187963D00", Slot = "4")]
	[AsyncStateMachine(typeof(ACPJLIJLHPA))]
	public override Task<PKJJFLPLKEF> BALGFNNJCDG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class CJKBBEDJELO : OPJHBNNNBLL<FGNBLPOBHLA, PKJJFLPLKEF>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct EGAGFCJFOAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder<PKJJFLPLKEF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public CJKBBEDJELO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private TaskAwaiter<PKJJFLPLKEF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7964170", Offset = "0x7962B70", VA = "0x187964170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7964410", Offset = "0x7962E10", VA = "0x187964410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly ODIJGDGNMIJ AIMMCAFHMAP;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7963FE0", Offset = "0x79629E0", VA = "0x187963FE0")]
	public CJKBBEDJELO(Guid DKEABFPCJLD, bool LPCJPICBOHJ, FGNBLPOBHLA ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7963EF0", Offset = "0x79628F0", VA = "0x187963EF0", Slot = "4")]
	[AsyncStateMachine(typeof(EGAGFCJFOAG))]
	public override Task<PKJJFLPLKEF> BALGFNNJCDG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct EKGDMLCCGOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly KOBGOPLNGON BPBHMFDOMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly bool IEKOHPNLGPG;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7964480", Offset = "0x7962E80", VA = "0x187964480")]
	public EKGDMLCCGOA(KOBGOPLNGON BFNMIPHCBIN, bool LPCJPICBOHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface AEPEJFPFHEF<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> BALGFNNJCDG(EKGDMLCCGOA FAOLMEAPLOM);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class EHJLFKBOLFJ<TSpawnType> : OPJHBNNNBLL<AEPEJFPFHEF<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct OIPGMBNANHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public EHJLFKBOLFJ<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x52E3240", Offset = "0x52E1C40", VA = "0x1852E3240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x3EE3B30", Offset = "0x3EE2530", VA = "0x183EE3B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly EKGDMLCCGOA FAOLMEAPLOM;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x435E7D0", Offset = "0x435D1D0", VA = "0x18435E7D0")]
	public EHJLFKBOLFJ(KOBGOPLNGON BFNMIPHCBIN, bool LPCJPICBOHJ, AEPEJFPFHEF<TSpawnType> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x435E6D0", Offset = "0x435D0D0", VA = "0x18435E6D0", Slot = "4")]
	[AsyncStateMachine(typeof(EHJLFKBOLFJ<>.OIPGMBNANHN))]
	public override Task<TSpawnType> BALGFNNJCDG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct KOBGOPLNGON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly bool BCOJMOMCNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly Vector3 EHKFFBMDPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly Vector3 NHAANPHMDOL;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7965310", Offset = "0x7963D10", VA = "0x187965310")]
	public KOBGOPLNGON(Transform FNGNLAMDBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x79652E0", Offset = "0x7963CE0", VA = "0x1879652E0")]
	public KOBGOPLNGON(Vector3 MDIKGGEOGCO, Vector3 KKIJMCHODGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7965230", Offset = "0x7963C30", VA = "0x187965230")]
	public static KOBGOPLNGON MBAELHOLOJC()
	{
		return default(KOBGOPLNGON);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7965260", Offset = "0x7963C60", VA = "0x187965260")]
	private KOBGOPLNGON(bool MDJOOLMPNNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct DDBLDLFCAPA<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public TNode IFLGIMNEHHG;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3EE4E30", Offset = "0x3EE3830", VA = "0x183EE4E30")]
	public DDBLDLFCAPA(TNode IFLGIMNEHHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct OCAHOCMCLJD<TNode, TReparentOperations> where TNode : notnull where TReparentOperations : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public TNode EDHODBHJBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public TReparentOperations JFCPCACEBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public BFNFBKLGMFH CKBMHOMOEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly bool IEKOHPNLGPG;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x52C9F20", Offset = "0x52C8920", VA = "0x1852C9F20")]
	public OCAHOCMCLJD(TNode EDHODBHJBCB, TReparentOperations JFCPCACEBII, BFNFBKLGMFH CKBMHOMOEIG, bool LPCJPICBOHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface FKFMPIPJMGI<TNode, TReparentOperations>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PFNHIBCCJJJ([In] DDBLDLFCAPA<TNode> PEABDKMNHBP);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AOBLJOECOKJ([In] OCAHOCMCLJD<TNode, TReparentOperations> FLJNFOEENNB);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NALMODDEEDD();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class EKLCIMCEOMF<TNode, TReparentOperations> : EGLNLNGCOJK<FKFMPIPJMGI<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x435B870", Offset = "0x435A270", VA = "0x18435B870")]
	public EKLCIMCEOMF(FKFMPIPJMGI<TNode, TReparentOperations> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x436DD00", Offset = "0x436C700", VA = "0x18436DD00", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class CGGIDGEDKNJ<TNode, TReparentOperations> : EGLNLNGCOJK<FKFMPIPJMGI<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly OCAHOCMCLJD<TNode, TReparentOperations> FLJNFOEENNB;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x65749C0", Offset = "0x65733C0", VA = "0x1865749C0")]
	public CGGIDGEDKNJ(TNode EDHODBHJBCB, TReparentOperations JFCPCACEBII, BFNFBKLGMFH CKBMHOMOEIG, FKFMPIPJMGI<TNode, TReparentOperations> ELHMFGLAFBF, bool LPCJPICBOHJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3F16FA0", Offset = "0x3F159A0", VA = "0x183F16FA0", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class FFPBJEMLBDF<TNode, TReparentOperations> : EGLNLNGCOJK<FKFMPIPJMGI<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly DDBLDLFCAPA<TNode> PEABDKMNHBP;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x47C2F10", Offset = "0x47C1910", VA = "0x1847C2F10")]
	public FFPBJEMLBDF(TNode JEGFNILNDKP, FKFMPIPJMGI<TNode, TReparentOperations> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4358B80", Offset = "0x4357580", VA = "0x184358B80", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct LBGELADLGKL<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public TSpawnInfo JEIJKCOMEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Vector3 KKIJMCHODGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Quaternion KONJHPLFEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float GFDDEGDNEEN;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4EA7F20", Offset = "0x4EA6920", VA = "0x184EA7F20")]
	public LBGELADLGKL(TSpawnInfo JEIJKCOMEKO, Vector3 KKIJMCHODGC, Quaternion KONJHPLFEME, float GFDDEGDNEEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface JCGNGNIJIIO<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> ADJAMMGKKAG([In] LBGELADLGKL<TSpawnInfo> NCIFCEHPNOL, CancellationToken BJEPDCCBCHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class LAKJGNPBCPO<TSpawnType, TSpawnInfo> : OPJHBNNNBLL<JCGNGNIJIIO<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly LBGELADLGKL<TSpawnInfo> CPDOLKLJBKL;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4EA72A0", Offset = "0x4EA5CA0", VA = "0x184EA72A0")]
	public LAKJGNPBCPO(TSpawnInfo GEKPBMLBBPG, Vector3 KKIJMCHODGC, Quaternion KONJHPLFEME, float GFDDEGDNEEN, JCGNGNIJIIO<TSpawnType, TSpawnInfo> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3F16C00", Offset = "0x3F15600", VA = "0x183F16C00", Slot = "4")]
	public override Task<TSpawnType> BALGFNNJCDG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public readonly struct PEJHGEFCMDD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly IEnumerable<TData> KAPGLJHCENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly bool IEKOHPNLGPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly bool FDMAFDNFEGP;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x53CDA50", Offset = "0x53CC450", VA = "0x1853CDA50")]
	public PEJHGEFCMDD(IEnumerable<TData> FHANMPNELBN, bool LPCJPICBOHJ = false, bool MIGBCMHKAKA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface AKNKKELBHPI<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PKJJFLPLKEF> MAHANBDMBJM([In] PEJHGEFCMDD<TData> JDLAIFFPNGC, CancellationToken BJEPDCCBCHJ);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class DJAGMJLLOEJ<TData> : OPJHBNNNBLL<AKNKKELBHPI<TData>, PKJJFLPLKEF> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly PEJHGEFCMDD<TData> LGHEJDGHDHO;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3F16CE0", Offset = "0x3F156E0", VA = "0x183F16CE0")]
	public DJAGMJLLOEJ(IEnumerable<TData> FHANMPNELBN, bool LPCJPICBOHJ, AKNKKELBHPI<TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3F16C00", Offset = "0x3F15600", VA = "0x183F16C00", Slot = "4")]
	public override Task<PKJJFLPLKEF> BALGFNNJCDG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct OMDFCOJPOAG<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T HIKBDNMPFJK;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x50C0A80", Offset = "0x50BF480", VA = "0x1850C0A80")]
	public OMDFCOJPOAG(T NJIDOJJJDNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface PKOEKBGOPDA<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PFNHIBCCJJJ([In] OMDFCOJPOAG<T> OFDPCFBICCA);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AOBLJOECOKJ();
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface BLLICBAIKGP<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BALGFNNJCDG([In] FHFENLJIECM<T> FPGNBGILFCJ);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct FHFENLJIECM<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T HIKBDNMPFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly bool DPIGINIEPCB;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x47C6D50", Offset = "0x47C5750", VA = "0x1847C6D50")]
	public FHFENLJIECM(T NJIDOJJJDNB, bool LFFGEEEAIHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class JJFAFNCHFGG<T> : EGLNLNGCOJK<PKOEKBGOPDA<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x435B870", Offset = "0x435A270", VA = "0x18435B870")]
	public JJFAFNCHFGG(PKOEKBGOPDA<T> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4CCAE10", Offset = "0x4CC9810", VA = "0x184CCAE10", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class EELCCIBDMHL<T> : EGLNLNGCOJK<PKOEKBGOPDA<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly OMDFCOJPOAG<T> OFDPCFBICCA;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4358C30", Offset = "0x4357630", VA = "0x184358C30")]
	public EELCCIBDMHL(T HIKBDNMPFJK, PKOEKBGOPDA<T> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4358B80", Offset = "0x4357580", VA = "0x184358B80", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class MDLLDBCLEHN<T> : EGLNLNGCOJK<BLLICBAIKGP<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly FHFENLJIECM<T> FPGNBGILFCJ;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5127000", Offset = "0x5125A00", VA = "0x185127000")]
	public MDLLDBCLEHN(T HIKBDNMPFJK, bool LFFGEEEAIHC, BLLICBAIKGP<T> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4358B80", Offset = "0x4357580", VA = "0x184358B80", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct JGJGPAGANCB<TData> where TData : notnull, NBCPKGCBGDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public IEnumerable<TData> KAPGLJHCENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public bool DDALAENBNHP;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4CC6CD0", Offset = "0x4CC56D0", VA = "0x184CC6CD0")]
	public JGJGPAGANCB(IEnumerable<TData> DFDHDOCLBKG, bool CEEEBLPENGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct LOEAOHDBBPA<TData> where TData : notnull, NBCPKGCBGDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public List<TData> KAPGLJHCENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public List<bool> DFAMFEHHLCA;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4EE4F50", Offset = "0x4EE3950", VA = "0x184EE4F50")]
	public LOEAOHDBBPA(List<TData> DFDHDOCLBKG, List<bool> LLPAJDFNBJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface NBCPKGCBGDI
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool BGDIEOLPDCD
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface KPBMBHOONAG<TData> where TData : NBCPKGCBGDI
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BALGFNNJCDG([In] JGJGPAGANCB<TData> MAJOFBHPOOM);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BALGFNNJCDG([In] LOEAOHDBBPA<TData> MAJOFBHPOOM);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface CIGFNKBKHNA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MGGECANGALF(T HIKBDNMPFJK);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class HHMGLIJPANC<TData> : EGLNLNGCOJK<KPBMBHOONAG<TData>> where TData : notnull, NBCPKGCBGDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly JGJGPAGANCB<TData> MAJOFBHPOOM;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4960510", Offset = "0x495EF10", VA = "0x184960510")]
	public HHMGLIJPANC(List<TData> FHANMPNELBN, bool DDALAENBNHP, KPBMBHOONAG<TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4358B80", Offset = "0x4357580", VA = "0x184358B80", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class KOAEBMNPHAJ<TData> : EGLNLNGCOJK<KPBMBHOONAG<TData>> where TData : notnull, NBCPKGCBGDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly LOEAOHDBBPA<TData> MAJOFBHPOOM;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4E22F40", Offset = "0x4E21940", VA = "0x184E22F40")]
	public KOAEBMNPHAJ(List<TData> FHANMPNELBN, List<bool> DFAMFEHHLCA, KPBMBHOONAG<TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4E22E80", Offset = "0x4E21880", VA = "0x184E22E80", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface DKLBCJMHNMM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PKJJFLPLKEF> BALGFNNJCDG(KGIBCKEIMBF<TData> JHDMGLGOOAA);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class GNFPGBAIDBM<TData> : OPJHBNNNBLL<DKLBCJMHNMM<TData>, PKJJFLPLKEF> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct MNIEDMCCAMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder<PKJJFLPLKEF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public GNFPGBAIDBM<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter<PKJJFLPLKEF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5142C50", Offset = "0x5141650", VA = "0x185142C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5142F30", Offset = "0x5141930", VA = "0x185142F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly KGIBCKEIMBF<TData> ONGDIMCEJJM;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x48DDA00", Offset = "0x48DC400", VA = "0x1848DDA00")]
	public GNFPGBAIDBM(TData CMDMHNCFGFC, IReadOnlyList<TData> IFKMLCFCNCP, bool LPCJPICBOHJ, DKLBCJMHNMM<TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x48DD900", Offset = "0x48DC300", VA = "0x1848DD900", Slot = "4")]
	[AsyncStateMachine(typeof(GNFPGBAIDBM<>.MNIEDMCCAMF))]
	public override Task<PKJJFLPLKEF> BALGFNNJCDG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct KGIBCKEIMBF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public TData BPKPKGJIMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public IReadOnlyList<TData> BKKDNLJKEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public bool IEKOHPNLGPG;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4E000F0", Offset = "0x4DFEAF0", VA = "0x184E000F0")]
	public KGIBCKEIMBF(TData CMDMHNCFGFC, IReadOnlyList<TData> IFKMLCFCNCP, bool LPCJPICBOHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface BGKIBPENMIP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BALGFNNJCDG([In] HLLEEKEPIAH<TData> MHKOECHHGHG);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface PNIAJDAJEAE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BALGFNNJCDG([In] JAGEOGDKHMP<TData> MHKOECHHGHG);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface KNNDKIBBKMK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HIGKJDHFOJA([In] MNMDMAOPFJL<TData> MHKOECHHGHG);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AOBLJOECOKJ();
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class HOJALOKFALN<TData> : EGLNLNGCOJK<BGKIBPENMIP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly HLLEEKEPIAH<TData> MHKOECHHGHG;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4977100", Offset = "0x4975B00", VA = "0x184977100")]
	public HOJALOKFALN(IEnumerable<TData> FHANMPNELBN, ADADNEEPCEF IFFOAMBAJEI, KJDEIJDKCCB GMIALIBEKEC, float EEILIJKHAHG, string? PJDPJIKHFCG, bool LMCLEEFIJKH, bool LPCJPICBOHJ, BGKIBPENMIP<TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4358B80", Offset = "0x4357580", VA = "0x184358B80", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class KKNGINLMJOO<TData> : EGLNLNGCOJK<PNIAJDAJEAE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly JAGEOGDKHMP<TData> MHKOECHHGHG;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4E0DC40", Offset = "0x4E0C640", VA = "0x184E0DC40")]
	public KKNGINLMJOO(TData[] FHANMPNELBN, ADADNEEPCEF[] IFFOAMBAJEI, KJDEIJDKCCB[] GMIALIBEKEC, float[] EEILIJKHAHG, PNIAJDAJEAE<TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4359E10", Offset = "0x4358810", VA = "0x184359E10", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class CLPOKGBCEGL<TData> : EGLNLNGCOJK<KNNDKIBBKMK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x435B870", Offset = "0x435A270", VA = "0x18435B870")]
	public CLPOKGBCEGL(KNNDKIBBKMK<TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x65BD460", Offset = "0x65BBE60", VA = "0x1865BD460", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class EEPDMKPDFPP<TData> : EGLNLNGCOJK<KNNDKIBBKMK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly MNMDMAOPFJL<TData> MHKOECHHGHG;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4359EC0", Offset = "0x43588C0", VA = "0x184359EC0")]
	public EEPDMKPDFPP(IEnumerable<TData> FHANMPNELBN, ADADNEEPCEF IFFOAMBAJEI, KJDEIJDKCCB GMIALIBEKEC, float EEILIJKHAHG, KNNDKIBBKMK<TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4359E10", Offset = "0x4358810", VA = "0x184359E10", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct HLLEEKEPIAH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public IEnumerable<TData> KAPGLJHCENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public ADADNEEPCEF NAFKEKHKPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public KJDEIJDKCCB LFCKJDCIBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float LADMGFNEMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public string? DJHEIEKDICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public bool? IFHDCLHELBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public bool IEKOHPNLGPG;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x496CB40", Offset = "0x496B540", VA = "0x18496CB40")]
	public HLLEEKEPIAH(IEnumerable<TData> FHANMPNELBN, ADADNEEPCEF IFFOAMBAJEI, KJDEIJDKCCB GMIALIBEKEC, float EEILIJKHAHG, string? PJDPJIKHFCG, bool? LMCLEEFIJKH, bool LPCJPICBOHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct JAGEOGDKHMP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public TData[] KAPGLJHCENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public ADADNEEPCEF[] NAFKEKHKPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public KJDEIJDKCCB[] LFCKJDCIBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public float[] EEILIJKHAHG;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4C89610", Offset = "0x4C88010", VA = "0x184C89610")]
	public JAGEOGDKHMP(TData[] FHANMPNELBN, ADADNEEPCEF[] IFFOAMBAJEI, KJDEIJDKCCB[] GMIALIBEKEC, float[] EEILIJKHAHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct MNMDMAOPFJL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public IEnumerable<TData> KAPGLJHCENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public ADADNEEPCEF NAFKEKHKPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public KJDEIJDKCCB LFCKJDCIBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float EEILIJKHAHG;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5144410", Offset = "0x5142E10", VA = "0x185144410")]
	public MNMDMAOPFJL(IEnumerable<TData> FHANMPNELBN, ADADNEEPCEF IFFOAMBAJEI, KJDEIJDKCCB GMIALIBEKEC, float EEILIJKHAHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface NOKHLIIFEOO<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AOMBGCLGGNE([In] KJDDJIBIDLG<TData> JDLAIFFPNGC);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HNOFKPHJCBD([In] KJDDJIBIDLG<TData> JDLAIFFPNGC);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DFFDCFDKJEH([In] bool BNKNEJHELLK);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CNNNEHIAJPM([In] KJDDJIBIDLG<TData> JDLAIFFPNGC);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NJLPNNMAGNF();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HOCHGKNOCOI([In] TData JEIKLGKFBLF);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class LMOHJDLOBFI<TData> : EGLNLNGCOJK<NOKHLIIFEOO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly KJDDJIBIDLG<TData> JDLAIFFPNGC;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4EE3C80", Offset = "0x4EE2680", VA = "0x184EE3C80")]
	public LMOHJDLOBFI(List<TData> NNLLAHLBLIH, NOKHLIIFEOO<TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4358B80", Offset = "0x4357580", VA = "0x184358B80", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class FOGEDFNCEOD<TData> : EGLNLNGCOJK<NOKHLIIFEOO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x435B870", Offset = "0x435A270", VA = "0x18435B870")]
	public FOGEDFNCEOD(NOKHLIIFEOO<TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x47E6690", Offset = "0x47E5090", VA = "0x1847E6690", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class PKDNFHFGFDN<TData> : EGLNLNGCOJK<NOKHLIIFEOO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly bool LPCJPICBOHJ;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x53DBBE0", Offset = "0x53DA5E0", VA = "0x1853DBBE0")]
	public PKDNFHFGFDN(bool LPCJPICBOHJ, NOKHLIIFEOO<TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x53DBB80", Offset = "0x53DA580", VA = "0x1853DBB80", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class NLJMENJHILF<TData> : EGLNLNGCOJK<NOKHLIIFEOO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly KJDDJIBIDLG<TData> JDLAIFFPNGC;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x51BC250", Offset = "0x51BAC50", VA = "0x1851BC250")]
	public NLJMENJHILF(List<TData> NNLLAHLBLIH, bool LPCJPICBOHJ, NOKHLIIFEOO<TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4E22E80", Offset = "0x4E21880", VA = "0x184E22E80", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class OAHKAAAHCII<TData> : EGLNLNGCOJK<NOKHLIIFEOO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly TData JEIKLGKFBLF;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x52C8E40", Offset = "0x52C7840", VA = "0x1852C8E40")]
	public OAHKAAAHCII(TData JEIKLGKFBLF, NOKHLIIFEOO<TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x52C8CC0", Offset = "0x52C76C0", VA = "0x1852C8CC0", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class NNFFJAJJBOP<TData> : EGLNLNGCOJK<NOKHLIIFEOO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly KJDDJIBIDLG<TData> JDLAIFFPNGC;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x51C0BC0", Offset = "0x51BF5C0", VA = "0x1851C0BC0")]
	public NNFFJAJJBOP(IEnumerable<TData> NNLLAHLBLIH, NOKHLIIFEOO<TData> ELHMFGLAFBF, bool LPCJPICBOHJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x51C0A50", Offset = "0x51BF450", VA = "0x1851C0A50", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct KJDDJIBIDLG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public IEnumerable<TData> KAPGLJHCENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public bool LPCJPICBOHJ;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4E04070", Offset = "0x4E02A70", VA = "0x184E04070")]
	public KJDDJIBIDLG(IEnumerable<TData> DFDHDOCLBKG, bool OEDMGBLNPOD = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface LNKEOLPKLKD
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PKJJFLPLKEF> BALGFNNJCDG(BFGKCAMHMHF BBEKFJLIKIH);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class JOMPHKPDGOK : OPJHBNNNBLL<LNKEOLPKLKD, PKJJFLPLKEF>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct GEEPEJDFIPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public AsyncTaskMethodBuilder<PKJJFLPLKEF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public JOMPHKPDGOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<PKJJFLPLKEF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x79644A0", Offset = "0x7962EA0", VA = "0x1879644A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7964710", Offset = "0x7963110", VA = "0x187964710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly BFGKCAMHMHF IHFGFMFIKIF;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7964E20", Offset = "0x7963820", VA = "0x187964E20")]
	public JOMPHKPDGOK(bool LPCJPICBOHJ, LNKEOLPKLKD ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7964D30", Offset = "0x7963730", VA = "0x187964D30", Slot = "4")]
	[AsyncStateMachine(typeof(GEEPEJDFIPD))]
	public override Task<PKJJFLPLKEF> BALGFNNJCDG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct BFGKCAMHMHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool IEKOHPNLGPG;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2883870", Offset = "0x2882270", VA = "0x182883870")]
	public BFGKCAMHMHF(bool LPCJPICBOHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public readonly struct IJLCOKPIDNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool PNDFNDCKBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly bool OAJEKNNNOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly bool GFDDEGDNEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly bool LPCJPICBOHJ;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x59D39A0", Offset = "0x59D23A0", VA = "0x1859D39A0")]
	public IJLCOKPIDNH(bool PNDFNDCKBHH, bool OAJEKNNNOHE, bool GFDDEGDNEEN, bool LPCJPICBOHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7964A10", Offset = "0x7963410", VA = "0x187964A10")]
	public IJLCOKPIDNH(bool OAJEKNNNOHE, bool LPCJPICBOHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface GLOIHBHJBFO
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NDENOJHKPML(IJLCOKPIDNH FNBNELBKODN);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EEHEELDBECK(IJLCOKPIDNH FNBNELBKODN);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class JHJDFCEDLMN : EGLNLNGCOJK<GLOIHBHJBFO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly IJLCOKPIDNH FNBNELBKODN;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7964A70", Offset = "0x7963470", VA = "0x187964A70")]
	public JHJDFCEDLMN(bool GBIMAJCBFCJ, bool OAJEKNNNOHE, bool GFDDEGDNEEN, bool LPCJPICBOHJ, GLOIHBHJBFO ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7964A20", Offset = "0x7963420", VA = "0x187964A20", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class PGCGMJHDFCG : EGLNLNGCOJK<GLOIHBHJBFO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly IJLCOKPIDNH FNBNELBKODN;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7965510", Offset = "0x7963F10", VA = "0x187965510")]
	public PGCGMJHDFCG(bool OAJEKNNNOHE, bool LPCJPICBOHJ, GLOIHBHJBFO ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x79654C0", Offset = "0x7963EC0", VA = "0x1879654C0", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface EIEKDLLGDJB
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BALGFNNJCDG([In] PNEOKJEMIPJ JFHEACAHHPK);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class GHOJFFIFFAA : EGLNLNGCOJK<EIEKDLLGDJB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly PNEOKJEMIPJ JFHEACAHHPK;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7964830", Offset = "0x7963230", VA = "0x187964830")]
	public GHOJFFIFFAA(Guid[] NMLKNMNDEMH, Vector3[] LAAHPPLLGFA, Quaternion[] ABMEKMEICMO, float[] GFHNAJKIMBD, Dictionary<Guid, Vector3> APNHEPAHADL, EIEKDLLGDJB ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7964780", Offset = "0x7963180", VA = "0x187964780", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface HHDDHMGBCHD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PFNHIBCCJJJ([In] FJNBEJLFADD<TData> PEABDKMNHBP);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HIGKJDHFOJA([In] OGOEFBAMGEP APCFCAOMMKE);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HIGKJDHFOJA([In] MAMPNKAOMEA APCFCAOMMKE);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AOBLJOECOKJ();
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class BACCLFPPGMO<TData> : EGLNLNGCOJK<HHDDHMGBCHD<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x435B870", Offset = "0x435A270", VA = "0x18435B870")]
	public BACCLFPPGMO(HHDDHMGBCHD<TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x64573C0", Offset = "0x6455DC0", VA = "0x1864573C0", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class LPCBLGLGAOF<TData> : EGLNLNGCOJK<HHDDHMGBCHD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly OGOEFBAMGEP PHAECLDPJIK;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4EF1340", Offset = "0x4EEFD40", VA = "0x184EF1340")]
	public LPCBLGLGAOF(Vector3 GOKLBLCIFAP, bool KAEPNJDMFBK, HHDDHMGBCHD<TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x47D68A0", Offset = "0x47D52A0", VA = "0x1847D68A0", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class KBPAOKMKGOG<TData> : EGLNLNGCOJK<HHDDHMGBCHD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly MAMPNKAOMEA PHAECLDPJIK;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4DE0760", Offset = "0x4DDF160", VA = "0x184DE0760")]
	public KBPAOKMKGOG(Guid LABPKDLPFDO, int DOAKEFBOPIA, Vector3 KKIJMCHODGC, Quaternion KONJHPLFEME, float OAIHKLDEKFL, bool KAEPNJDMFBK, HHDDHMGBCHD<TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4DE0700", Offset = "0x4DDF100", VA = "0x184DE0700", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class ICMALIBKCFI<TData> : EGLNLNGCOJK<HHDDHMGBCHD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly FJNBEJLFADD<TData> PHAECLDPJIK;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4A6FDD0", Offset = "0x4A6E7D0", VA = "0x184A6FDD0")]
	public ICMALIBKCFI(TData HIKBDNMPFJK, bool LPCJPICBOHJ, HHDDHMGBCHD<TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4358B80", Offset = "0x4357580", VA = "0x184358B80", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct OGOEFBAMGEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly Vector3 GOKLBLCIFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool KAEPNJDMFBK;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7965480", Offset = "0x7963E80", VA = "0x187965480")]
	public OGOEFBAMGEP(Vector3 GOKLBLCIFAP, bool KAEPNJDMFBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct MAMPNKAOMEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly Guid LABPKDLPFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly int DOAKEFBOPIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly Vector3 KKIJMCHODGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly Quaternion KONJHPLFEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly float OAIHKLDEKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public readonly bool KAEPNJDMFBK;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7965380", Offset = "0x7963D80", VA = "0x187965380")]
	public MAMPNKAOMEA(Guid LABPKDLPFDO, int DOAKEFBOPIA, Vector3 KKIJMCHODGC, Quaternion KONJHPLFEME, float OAIHKLDEKFL, bool KAEPNJDMFBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct FJNBEJLFADD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public readonly TData HIKBDNMPFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly bool LPCJPICBOHJ;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x47D66B0", Offset = "0x47D50B0", VA = "0x1847D66B0")]
	public FJNBEJLFADD(TData HIKBDNMPFJK, bool LPCJPICBOHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public interface HLAJLNPIBAB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BALGFNNJCDG([In] CAHCPOMAFOD<TData> ONENBLCEPFP);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BALGFNNJCDG([In] EPNIHEBEJBP<TData> ONENBLCEPFP);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface JFLFCEANMLO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PFNHIBCCJJJ([In] EAJACENKIJA<TData> ECMCMLFPANK);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HIGKJDHFOJA([In] PAKEDEFNCKO APCFCAOMMKE);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AOBLJOECOKJ();
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class JHACOKCOPGI<TData> : EGLNLNGCOJK<HLAJLNPIBAB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly CAHCPOMAFOD<TData> ONENBLCEPFP;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4CC70D0", Offset = "0x4CC5AD0", VA = "0x184CC70D0")]
	public JHACOKCOPGI(IEnumerable<TData> FHANMPNELBN, Vector3 FOEGHKEJBAI, bool LPCJPICBOHJ, HLAJLNPIBAB<TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4358B80", Offset = "0x4357580", VA = "0x184358B80", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class JGILFLLMMND<TData> : EGLNLNGCOJK<JFLFCEANMLO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x435B870", Offset = "0x435A270", VA = "0x18435B870")]
	public JGILFLLMMND(JFLFCEANMLO<TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x436DD00", Offset = "0x436C700", VA = "0x18436DD00", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class FONOPNGDHHG<TData> : EGLNLNGCOJK<JFLFCEANMLO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly EAJACENKIJA<TData> ONENBLCEPFP;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x47E68B0", Offset = "0x47E52B0", VA = "0x1847E68B0")]
	public FONOPNGDHHG(IEnumerable<TData> FHANMPNELBN, bool LPCJPICBOHJ, JFLFCEANMLO<TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4358B80", Offset = "0x4357580", VA = "0x184358B80", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class DJIPFDAGHNI<TData> : EGLNLNGCOJK<HLAJLNPIBAB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly EPNIHEBEJBP<TData> ONENBLCEPFP;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3F17060", Offset = "0x3F15A60", VA = "0x183F17060")]
	public DJIPFDAGHNI(IEnumerable<TData> FHANMPNELBN, Vector3 LLNLGMANDKL, KBNMFNLJADF KHCIEEKDPBG, bool LPCJPICBOHJ, HLAJLNPIBAB<TData> ELHMFGLAFBF, Space DGNKDGNIIFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3F16FA0", Offset = "0x3F159A0", VA = "0x183F16FA0", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class FJPFLGCMDNC<TData> : EGLNLNGCOJK<JFLFCEANMLO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly PAKEDEFNCKO ONENBLCEPFP;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x47D6900", Offset = "0x47D5300", VA = "0x1847D6900")]
	public FJPFLGCMDNC(Vector3 FOEGHKEJBAI, JFLFCEANMLO<TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x47D68A0", Offset = "0x47D52A0", VA = "0x1847D68A0", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct CAHCPOMAFOD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly IEnumerable<TData> FHANMPNELBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly Vector3 FOEGHKEJBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly bool LPCJPICBOHJ;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x65439B0", Offset = "0x65423B0", VA = "0x1865439B0")]
	public CAHCPOMAFOD(IEnumerable<TData> FHANMPNELBN, Vector3 FOEGHKEJBAI, bool LPCJPICBOHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct EAJACENKIJA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly IEnumerable<TData> FHANMPNELBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly bool LPCJPICBOHJ;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4348140", Offset = "0x4346B40", VA = "0x184348140")]
	public EAJACENKIJA(IEnumerable<TData> FHANMPNELBN, bool LPCJPICBOHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct EPNIHEBEJBP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly IEnumerable<TData> FHANMPNELBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly Vector3 LLNLGMANDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly KBNMFNLJADF KHCIEEKDPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly bool LPCJPICBOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Space DGNKDGNIIFH;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x439D9D0", Offset = "0x439C3D0", VA = "0x18439D9D0")]
	public EPNIHEBEJBP(IEnumerable<TData> FHANMPNELBN, Vector3 LLNLGMANDKL, KBNMFNLJADF KHCIEEKDPBG, bool LPCJPICBOHJ, Space DGNKDGNIIFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct PAKEDEFNCKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly Vector3 FOEGHKEJBAI;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0xE49760", Offset = "0xE48160", VA = "0x180E49760")]
	public PAKEDEFNCKO(Vector3 FOEGHKEJBAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public enum KBNMFNLJADF
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public interface OLCBCAACDEF
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BALGFNNJCDG([In] CEGLFFHCANA NNMKGCMCDGN);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class EEEOIEBEIPI : EGLNLNGCOJK<OLCBCAACDEF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly CEGLFFHCANA NNMKGCMCDGN;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7964110", Offset = "0x7962B10", VA = "0x187964110")]
	public EEEOIEBEIPI(bool LPCJPICBOHJ, OLCBCAACDEF ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7964060", Offset = "0x7962A60", VA = "0x187964060", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public readonly struct CEGLFFHCANA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly bool LPCJPICBOHJ;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2883870", Offset = "0x2882270", VA = "0x182883870")]
	public CEGLFFHCANA(bool LPCJPICBOHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface NBANCCBCMKK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BALGFNNJCDG([In] LCFPFGAMHDE<TData> JKMEGANGFDI);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BALGFNNJCDG([In] JKNCIKIMGEH<TData> JKMEGANGFDI);
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface OODNPBLMPBJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PFNHIBCCJJJ([In] OEDGNOANLNA<TData> PEABDKMNHBP);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HIGKJDHFOJA([In] NNKKBOFGEHF APCFCAOMMKE);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AOBLJOECOKJ();
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class PLEINIKBBJB<TData> : EGLNLNGCOJK<NBANCCBCMKK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly LCFPFGAMHDE<TData> JKMEGANGFDI;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x53DEB90", Offset = "0x53DD590", VA = "0x1853DEB90")]
	public PLEINIKBBJB(IEnumerable<TData> FHANMPNELBN, Quaternion FOEGHKEJBAI, Vector3? FJKODKELIID, bool GJNDOACANPD, bool LPCJPICBOHJ, NBANCCBCMKK<TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4358B80", Offset = "0x4357580", VA = "0x184358B80", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class BBEECBJHKCD<TData> : EGLNLNGCOJK<OODNPBLMPBJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x435B870", Offset = "0x435A270", VA = "0x18435B870")]
	public BBEECBJHKCD(OODNPBLMPBJ<TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x436DD00", Offset = "0x436C700", VA = "0x18436DD00", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class GLDAOOOJMFI<TData> : EGLNLNGCOJK<OODNPBLMPBJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly OEDGNOANLNA<TData> JKMEGANGFDI;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x48D98E0", Offset = "0x48D82E0", VA = "0x1848D98E0")]
	public GLDAOOOJMFI(IEnumerable<TData> FHANMPNELBN, bool LPCJPICBOHJ, OODNPBLMPBJ<TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4358B80", Offset = "0x4357580", VA = "0x184358B80", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class OENMNCILKED<TData> : EGLNLNGCOJK<NBANCCBCMKK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly JKNCIKIMGEH<TData> JKMEGANGFDI;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x52D41E0", Offset = "0x52D2BE0", VA = "0x1852D41E0")]
	public OENMNCILKED(IEnumerable<TData> FHANMPNELBN, Quaternion NPDHIIPPEJF, KBNMFNLJADF OMCEOBPAAIJ, Vector3? FJKODKELIID, bool GJNDOACANPD, bool LPCJPICBOHJ, Space DGNKDGNIIFH, NBANCCBCMKK<TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3F16FA0", Offset = "0x3F159A0", VA = "0x183F16FA0", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class MENNIHNAOBF<TData> : EGLNLNGCOJK<OODNPBLMPBJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly NNKKBOFGEHF JKMEGANGFDI;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5127980", Offset = "0x5126380", VA = "0x185127980")]
	public MENNIHNAOBF(Quaternion FOEGHKEJBAI, Vector3? FJKODKELIID, bool GJNDOACANPD, OODNPBLMPBJ<TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x47D68A0", Offset = "0x47D52A0", VA = "0x1847D68A0", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct LCFPFGAMHDE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly IEnumerable<TData> FHANMPNELBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly Quaternion FOEGHKEJBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly Vector3? FJKODKELIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly bool GJNDOACANPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly bool LPCJPICBOHJ;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4EA8A40", Offset = "0x4EA7440", VA = "0x184EA8A40")]
	public LCFPFGAMHDE(IEnumerable<TData> FHANMPNELBN, Quaternion FOEGHKEJBAI, Vector3? FJKODKELIID, bool GJNDOACANPD, bool LPCJPICBOHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct OEDGNOANLNA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly IEnumerable<TData> FHANMPNELBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly bool LPCJPICBOHJ;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x52CFFE0", Offset = "0x52CE9E0", VA = "0x1852CFFE0")]
	public OEDGNOANLNA(IEnumerable<TData> FHANMPNELBN, bool LPCJPICBOHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct JKNCIKIMGEH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public readonly IEnumerable<TData> FHANMPNELBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public readonly Quaternion NPDHIIPPEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public readonly KBNMFNLJADF OMCEOBPAAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public readonly Vector3? FJKODKELIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly bool GJNDOACANPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly bool LPCJPICBOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly Space DGNKDGNIIFH;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x4D02A90", Offset = "0x4D01490", VA = "0x184D02A90")]
	public JKNCIKIMGEH(IEnumerable<TData> FHANMPNELBN, Quaternion NPDHIIPPEJF, KBNMFNLJADF OMCEOBPAAIJ, Vector3? FJKODKELIID, bool GJNDOACANPD, bool LPCJPICBOHJ, Space DGNKDGNIIFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct NNKKBOFGEHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly Quaternion FOEGHKEJBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly Vector3? FJKODKELIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly bool GJNDOACANPD;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x599A830", Offset = "0x5999230", VA = "0x18599A830")]
	public NNKKBOFGEHF(Quaternion FOEGHKEJBAI, Vector3? FJKODKELIID, bool GJNDOACANPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public interface PIAACKEAKAN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PFNHIBCCJJJ([In] NIMOBOPKEHN<TData> PEABDKMNHBP);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HIGKJDHFOJA([In] DENIMDEEPLM APCFCAOMMKE);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HIGKJDHFOJA([In] PAOLHCKIMLL APCFCAOMMKE);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HIGKJDHFOJA([In] NONHBENADEJ APCFCAOMMKE);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AOBLJOECOKJ();
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public class CNDFGPMEGBB<TData> : EGLNLNGCOJK<PIAACKEAKAN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly NONHBENADEJ AJFMDPCDCBI;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x65BF620", Offset = "0x65BE020", VA = "0x1865BF620")]
	public CNDFGPMEGBB(Vector3 NAEGBJGCHBD, float DFLDIKKIDLP, Vector3 FJKODKELIID, bool MKBCMKALPAF, bool NBODJHKHGPI, PIAACKEAKAN<TData> ELHMFGLAFBF, Space DGNKDGNIIFH = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x65BF5C0", Offset = "0x65BDFC0", VA = "0x1865BF5C0", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class OFMHHGMDMDF<TData> : EGLNLNGCOJK<PIAACKEAKAN<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x435B870", Offset = "0x435A270", VA = "0x18435B870")]
	public OFMHHGMDMDF(PIAACKEAKAN<TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x52D4330", Offset = "0x52D2D30", VA = "0x1852D4330", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class FENPINKJKDE<TData> : EGLNLNGCOJK<PIAACKEAKAN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly NIMOBOPKEHN<TData> AJFMDPCDCBI;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x47BEC40", Offset = "0x47BD640", VA = "0x1847BEC40")]
	public FENPINKJKDE(IEnumerable<TData> FHANMPNELBN, bool LPCJPICBOHJ, PIAACKEAKAN<TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4358B80", Offset = "0x4357580", VA = "0x184358B80", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class EFJPFHIPFMG<TData> : EGLNLNGCOJK<PIAACKEAKAN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly PAOLHCKIMLL AJFMDPCDCBI;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x435A1C0", Offset = "0x4358BC0", VA = "0x18435A1C0")]
	public EFJPFHIPFMG(float KEILMJFDKGE, bool MFCDDOJNEMK, Vector3 FJKODKELIID, PIAACKEAKAN<TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x435A100", Offset = "0x4358B00", VA = "0x18435A100", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class OOKGHPPOEBM<TData> : EGLNLNGCOJK<PIAACKEAKAN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly DENIMDEEPLM AJFMDPCDCBI;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5326DE0", Offset = "0x53257E0", VA = "0x185326DE0")]
	public OOKGHPPOEBM(float DFLDIKKIDLP, Vector3 FJKODKELIID, PIAACKEAKAN<TData> ELHMFGLAFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x47D68A0", Offset = "0x47D52A0", VA = "0x1847D68A0", Slot = "4")]
	public override bool BALGFNNJCDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public struct NONHBENADEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly Vector3 NAEGBJGCHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly float DFLDIKKIDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly Vector3 FJKODKELIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly bool KAEPNJDMFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly Space DGNKDGNIIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly bool NBODJHKHGPI;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x79653C0", Offset = "0x7963DC0", VA = "0x1879653C0")]
	public NONHBENADEJ(Vector3 NAEGBJGCHBD, float DFLDIKKIDLP, Vector3 FJKODKELIID, bool KAEPNJDMFBK, bool CBPCIFFEBGD, Space DGNKDGNIIFH = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct NIMOBOPKEHN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly IEnumerable<TData> FHANMPNELBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly bool LPCJPICBOHJ;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x51AFCF0", Offset = "0x51AE6F0", VA = "0x1851AFCF0")]
	public NIMOBOPKEHN(IEnumerable<TData> FHANMPNELBN, bool LPCJPICBOHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct PAOLHCKIMLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly float KEILMJFDKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly bool MFCDDOJNEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly Vector3 FJKODKELIID;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x79654A0", Offset = "0x7963EA0", VA = "0x1879654A0")]
	public PAOLHCKIMLL(float KEILMJFDKGE, bool MFCDDOJNEMK, Vector3 FJKODKELIID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct DENIMDEEPLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly float DFLDIKKIDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly Vector3 FJKODKELIID;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x595F940", Offset = "0x595E340", VA = "0x18595F940")]
	public DENIMDEEPLM(float DFLDIKKIDLP, Vector3 FJKODKELIID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct PNEOKJEMIPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly Guid[] FHANMPNELBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public readonly bool DLNBIKOBGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public readonly bool DMCNAJFFNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly bool MBDANPPEJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly Vector3[] LAAHPPLLGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public readonly Quaternion[] ABMEKMEICMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public readonly float[] GFHNAJKIMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public readonly Dictionary<Guid, Vector3> APNHEPAHADL;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7965760", Offset = "0x7964160", VA = "0x187965760")]
	public PNEOKJEMIPJ(Guid[] NMLKNMNDEMH, Vector3[] LAAHPPLLGFA, Quaternion[] ABMEKMEICMO, float[] GFHNAJKIMBD, Dictionary<Guid, Vector3> APNHEPAHADL, bool DLNBIKOBGGB = true, bool DMCNAJFFNFD = true, bool MBDANPPEJKI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7965590", Offset = "0x7963F90", VA = "0x187965590")]
	private static void PPHLPABFGKB(Dictionary<Guid, Vector3> APNHEPAHADL, int IECIHJOBNEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class KKLAGOFKMDG
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private struct LOFNLKBPDGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public bool EHIMBFBHPCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public LKOLOODKMPF PIOEPEIOALH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public LKOLOODKMPF JFHCIABIBCL;
	}

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static LOFNLKBPDGE GPEBKADCCIF;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken PLJNONKKEDA
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7965210", Offset = "0x7963C10", VA = "0x187965210")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static LKOLOODKMPF PIOEPEIOALH
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7965020", Offset = "0x7963A20", VA = "0x187965020")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7964E80", Offset = "0x7963880", VA = "0x187964E80")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7964F30", Offset = "0x7963930", VA = "0x187964F30")]
	[EFEOGKEOEKD.CFCDPMMHJPB]
	internal static void OFOBEAIFMFF(LKOLOODKMPF GMHCBPCIBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x79650C0", Offset = "0x7963AC0", VA = "0x1879650C0")]
	public static void OPIOKFDHGCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7964EE0", Offset = "0x79638E0", VA = "0x187964EE0")]
	private static LKOLOODKMPF OFNKCFGECPB(LKOLOODKMPF BMNODBGPMBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class DFDAMBMHOHI
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public enum LILMLOLOGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x34633C0", Offset = "0x3461DC0", VA = "0x1834633C0")]
	public static void PCEBDLJFJDJ<T>(T FPJBBOHNMAA, LILMLOLOGHJ OHCGINPDMEI) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3463350", Offset = "0x3461D50", VA = "0x183463350")]
	public static void PCEBDLJFJDJ<T>(T FPJBBOHNMAA) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3462F80", Offset = "0x3461980", VA = "0x183462F80")]
	public static void DMPCPAHMKPM<T>(T FPJBBOHNMAA) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3462DC0", Offset = "0x34617C0", VA = "0x183462DC0")]
	public static T BLCCCENAIKI<T>(LILMLOLOGHJ OHCGINPDMEI) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3463030", Offset = "0x3461A30", VA = "0x183463030")]
	public static bool EHJIJKOKNAC<T>(LILMLOLOGHJ OHCGINPDMEI, T? CELPOPGCHMD, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T OFIDOFGDMNC) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3463240", Offset = "0x3461C40", VA = "0x183463240")]
	public static bool JIADIFBOIFH<T>(LILMLOLOGHJ OHCGINPDMEI, [Out][MaybeNullWhen(false)][NotNullWhen(true)] T PNMPOMDKPBE) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3462ED0", Offset = "0x34618D0", VA = "0x183462ED0")]
	public static bool DJIAIGDNHLA<T>(LILMLOLOGHJ OHCGINPDMEI) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3462E70", Offset = "0x3461870", VA = "0x183462E70")]
	public static T BLCCCENAIKI<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3463180", Offset = "0x3461B80", VA = "0x183463180")]
	public static bool EHJIJKOKNAC<T>(T CELPOPGCHMD, [Out] T OFIDOFGDMNC) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3462E70", Offset = "0x3461870", VA = "0x183462E70")]
	public static bool DJIAIGDNHLA<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal static class JJNHLAOEMKN
{
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7964B00", Offset = "0x7963500", VA = "0x187964B00")]
	public static void EBLAMJFPLAM(IEnumerable GOHDIJDDKLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x36E2140", Offset = "0x36E0B40", VA = "0x1836E2140")]
	public static void EBLAMJFPLAM<T>(T[] NAKGFAINKPB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x36E2320", Offset = "0x36E0D20", VA = "0x1836E2320")]
	public static void EBLAMJFPLAM<T>(T PMMCFCOBIDM) where T : notnull, Enum
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
