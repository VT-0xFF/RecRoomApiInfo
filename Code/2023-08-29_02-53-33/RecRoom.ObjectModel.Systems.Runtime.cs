using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using AOT;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;
using RecRoom.CodeGen.Attributes;
using RecRoom.Components;
using RecRoom.ObjectModel;
using RecRoom.ObjectModel.Systems;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Core;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.SceneManagement;
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
		[Cpp2IlInjected.Address(RVA = "0x7F1AF0", Offset = "0x7F0EF0", VA = "0x1807F1AF0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7F1AF0", Offset = "0x7F0EF0", VA = "0x1807F1AF0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Unity.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class EntityManagerTemporarySingletonExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2E81CC0", Offset = "0x2E810C0", VA = "0x182E81CC0")]
		public static LCDBGDJGFGE<T> CreateTemporarySingleton<T>(this EntityManager entityManager, T componentData) where T : struct, IComponentData
		{
			return default(LCDBGDJGFGE<T>);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal struct FMDAIPKFLJF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[GKFPOBEDICJ]
public static class LEGNBDDPDLN
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2A5E100", Offset = "0x2A5D500", VA = "0x182A5E100")]
	static LEGNBDDPDLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x24246C0", Offset = "0x2423AC0", VA = "0x1824246C0")]
	public static void HOGEDLONAAA<T>(T CDNLFOGBLLG, ref T OPMNDBPHMGG, GKONMMGJICI OOALNHDBAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2A5DDE0", Offset = "0x2A5D1E0", VA = "0x182A5DDE0")]
	public static void HOGEDLONAAA(FixedString32Bytes CDNLFOGBLLG, ref string OPMNDBPHMGG, GKONMMGJICI OOALNHDBAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2A5E010", Offset = "0x2A5D410", VA = "0x182A5E010")]
	public static void HOGEDLONAAA(string CDNLFOGBLLG, ref FixedString32Bytes OPMNDBPHMGG, GKONMMGJICI OOALNHDBAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2A5DCE0", Offset = "0x2A5D0E0", VA = "0x182A5DCE0")]
	public static void HOGEDLONAAA(FixedString64Bytes CDNLFOGBLLG, ref string OPMNDBPHMGG, GKONMMGJICI OOALNHDBAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2A5E050", Offset = "0x2A5D450", VA = "0x182A5E050")]
	public static void HOGEDLONAAA(string CDNLFOGBLLG, ref FixedString64Bytes OPMNDBPHMGG, GKONMMGJICI OOALNHDBAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2A5E0B0", Offset = "0x2A5D4B0", VA = "0x182A5E0B0")]
	public static void HOGEDLONAAA(DHPKAEBADFF CDNLFOGBLLG, ref Vector3 OPMNDBPHMGG, GKONMMGJICI OOALNHDBAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2A5DF90", Offset = "0x2A5D390", VA = "0x182A5DF90")]
	public static void HOGEDLONAAA(Vector3 CDNLFOGBLLG, ref DHPKAEBADFF OPMNDBPHMGG, GKONMMGJICI OOALNHDBAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2A5DE10", Offset = "0x2A5D210", VA = "0x182A5DE10")]
	public static void HOGEDLONAAA(CCINDBJJLPI CDNLFOGBLLG, ref Vector4 OPMNDBPHMGG, GKONMMGJICI OOALNHDBAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2A5DD10", Offset = "0x2A5D110", VA = "0x182A5DD10")]
	public static void HOGEDLONAAA(Vector4 CDNLFOGBLLG, ref CCINDBJJLPI OPMNDBPHMGG, GKONMMGJICI OOALNHDBAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2A5DE10", Offset = "0x2A5D210", VA = "0x182A5DE10")]
	public static void HOGEDLONAAA(CCINDBJJLPI CDNLFOGBLLG, ref Quaternion OPMNDBPHMGG, GKONMMGJICI OOALNHDBAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2A5DD10", Offset = "0x2A5D110", VA = "0x182A5DD10")]
	public static void HOGEDLONAAA(Quaternion CDNLFOGBLLG, ref CCINDBJJLPI OPMNDBPHMGG, GKONMMGJICI OOALNHDBAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2A5DE70", Offset = "0x2A5D270", VA = "0x182A5DE70")]
	public static void HOGEDLONAAA(DHPKAEBADFF CDNLFOGBLLG, ref float3 OPMNDBPHMGG, GKONMMGJICI OOALNHDBAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2A5DF90", Offset = "0x2A5D390", VA = "0x182A5DF90")]
	public static void HOGEDLONAAA(float3 CDNLFOGBLLG, ref DHPKAEBADFF OPMNDBPHMGG, GKONMMGJICI OOALNHDBAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2A5DC40", Offset = "0x2A5D040", VA = "0x182A5DC40")]
	public static void HOGEDLONAAA(CCINDBJJLPI CDNLFOGBLLG, ref float4 OPMNDBPHMGG, GKONMMGJICI OOALNHDBAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2A5DD10", Offset = "0x2A5D110", VA = "0x182A5DD10")]
	public static void HOGEDLONAAA(float4 CDNLFOGBLLG, ref CCINDBJJLPI OPMNDBPHMGG, GKONMMGJICI OOALNHDBAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2A5DC40", Offset = "0x2A5D040", VA = "0x182A5DC40")]
	public static void HOGEDLONAAA(CCINDBJJLPI CDNLFOGBLLG, ref quaternion OPMNDBPHMGG, GKONMMGJICI OOALNHDBAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2A5DEE0", Offset = "0x2A5D2E0", VA = "0x182A5DEE0")]
	public static void HOGEDLONAAA(quaternion CDNLFOGBLLG, ref CCINDBJJLPI OPMNDBPHMGG, GKONMMGJICI OOALNHDBAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2A5DDA0", Offset = "0x2A5D1A0", VA = "0x182A5DDA0")]
	public static void HOGEDLONAAA(Entity CDNLFOGBLLG, ref ACHDHFLBDDH OPMNDBPHMGG, GKONMMGJICI OOALNHDBAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2A5DF60", Offset = "0x2A5D360", VA = "0x182A5DF60")]
	public static void HOGEDLONAAA(ACHDHFLBDDH CDNLFOGBLLG, ref Entity OPMNDBPHMGG, GKONMMGJICI OOALNHDBAGI)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class RRCustomPropTag : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private SerializableGuid guid;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public SerializableGuid GPADECEPDCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA38A80", Offset = "0xA37E80", VA = "0x180A38A80")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2240B80", Offset = "0x223FF80", VA = "0x182240B80")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8CEA50", Offset = "0x8CDE50", VA = "0x1808CEA50")]
		public RRCustomPropTag()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[DefaultMember("Item")]
[EFDJEPLIMOC(typeof(ABLEKJPBMJE), new string[] { })]
public class CBHHIGHFHOE : ABLEKJPBMJE, IEnumerable<MLIEHECMNHI>, IEnumerable, OOLEGKACHHE, DEPDOFHIDBA, AKFIPDJCCOH, CBKELFDIEEL, KFBFMDMFJDA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[ONGFANECMJO]
	private AOONNPAOEFB FHJACJEANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[ONGFANECMJO]
	private JKPBDEIBINB DJGFELMBIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private MLIEHECMNHI[] NHOMCGEOKNF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int NPBPHODFKMP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2515EA0", Offset = "0x25152A0", VA = "0x182515EA0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public MLIEHECMNHI OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x25157B0", Offset = "0x2514BB0", VA = "0x1825157B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "10")]
	public void MCOOCEGHCPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2515C10", Offset = "0x2515010", VA = "0x182515C10", Slot = "11")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "12")]
	public void JFCLKDMBJND(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2515AE0", Offset = "0x2514EE0", VA = "0x182515AE0", Slot = "6")]
	public MLIEHECMNHI IMOMPCNDOJA(NNHEPJDBKBI KKIJPENOLBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2515930", Offset = "0x2514D30", VA = "0x182515930", Slot = "7")]
	public GLFLLKHPAHK ELFFHKHOAAN(NNHEPJDBKBI KKIJPENOLBP)
	{
		return default(GLFLLKHPAHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2515A00", Offset = "0x2514E00", VA = "0x182515A00", Slot = "8")]
	public IEnumerator<MLIEHECMNHI> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2515EB0", Offset = "0x25152B0", VA = "0x182515EB0", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5150E70", Offset = "0x5150270", VA = "0x185150E70", Slot = "13")]
	public void LNAMDFAOIPA<TKey, T>(MHOBFBAOGME<TKey, T> HNNIGEFAIIM, [Optional] object JNNDIHFHMHC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x25157F0", Offset = "0x2514BF0", VA = "0x1825157F0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public CBHHIGHFHOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x25157B0", Offset = "0x2514BB0", VA = "0x1825157B0")]
	[CompilerGenerated]
	private MLIEHECMNHI JECPOKKGOAG(int GNPGECNAJNK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[LOJHKAHIJPC(typeof(OHDDHPCBLAA))]
[EFDJEPLIMOC(typeof(PGKBPEGCPKO), new string[] { })]
public class OHDDHPCBLAA : PGKBPEGCPKO, AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly PILIJFIMAJF IFIHPJHLOAE;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly PILIJFIMAJF AIKDHOBNEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private AOONNPAOEFB FHJACJEANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private JGJJAGMGKPI FBCPJLHEMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private OBMMBDFHEPO FLAALGKHIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private PFJMBDHJHAN BDLCNPMEDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private IIKMCLIAKNK FEJKNPAOBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private NICJNOMPEDE JBKPDBMJCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private DNMGNPMNFDI EGEBFNBKGKB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private EntityManager GLPCEPPDPLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2A75240", Offset = "0x2A74640", VA = "0x182A75240")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2A76C00", Offset = "0x2A76000", VA = "0x182A76C00", Slot = "34")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2A779D0", Offset = "0x2A76DD0", VA = "0x182A779D0", Slot = "35")]
	public bool NAGMLCICLNG(Transform FELEGEFPADK, out KDLENLDMBAK LCODCOPGHJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2A78500", Offset = "0x2A77900", VA = "0x182A78500", Slot = "36")]
	public Transform PMKLLIGFFND(Entity FKNFFDFGNMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2A748D0", Offset = "0x2A73CD0", VA = "0x182A748D0", Slot = "31")]
	public bool AMHGHJGADGN(Entity FKNFFDFGNMN, out Transform FELEGEFPADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2A74B00", Offset = "0x2A73F00", VA = "0x182A74B00")]
	private void CBFPCHALAPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2A771D0", Offset = "0x2A765D0", VA = "0x182A771D0", Slot = "30")]
	public void JPGEJBJOLPN(Entity FKNFFDFGNMN, out float4x4 GKMKJBANBPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2A77480", Offset = "0x2A76880", VA = "0x182A77480", Slot = "4")]
	public void KLLJBIFKDHL(Entity FKNFFDFGNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2A74F80", Offset = "0x2A74380", VA = "0x182A74F80", Slot = "28")]
	public void CLGHDJGBMCO(Entity FKNFFDFGNMN, out float4x4 GKMKJBANBPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2A77E60", Offset = "0x2A77260", VA = "0x182A77E60")]
	public void NEGGJLHLKNJ(Entity FKNFFDFGNMN, in float4x4 GKMKJBANBPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2A75100", Offset = "0x2A74500", VA = "0x182A75100")]
	public void PEFPLBIKJOF(Entity FKNFFDFGNMN, in float3 KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2A77290", Offset = "0x2A76690", VA = "0x182A77290", Slot = "6")]
	public float3 KLGLGOFKLKK(Entity FKNFFDFGNMN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2A768F0", Offset = "0x2A75CF0", VA = "0x182A768F0")]
	public void IMDNKOPAAID(Entity FKNFFDFGNMN, in quaternion KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2A78340", Offset = "0x2A77740", VA = "0x182A78340", Slot = "8")]
	public quaternion OJALBBDGOLE(Entity FKNFFDFGNMN)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2A76AC0", Offset = "0x2A75EC0", VA = "0x182A76AC0")]
	public void IOHCNOFDJGP(Entity FKNFFDFGNMN, in float3 KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2A74700", Offset = "0x2A73B00", VA = "0x182A74700", Slot = "12")]
	public float3 AKEMNHBHJLN(Entity FKNFFDFGNMN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2A75DA0", Offset = "0x2A751A0", VA = "0x182A75DA0", Slot = "15")]
	public float FJNJBFLENFO(Entity FKNFFDFGNMN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2A78140", Offset = "0x2A77540", VA = "0x182A78140", Slot = "14")]
	public void NNFCJEOBJJG(Entity FKNFFDFGNMN, float KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2A77C90", Offset = "0x2A77090", VA = "0x182A77C90", Slot = "17")]
	public float3 NCHOCFKCMEJ(Entity FKNFFDFGNMN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2A75EA0", Offset = "0x2A752A0", VA = "0x182A75EA0")]
	public void FNAHBLFDOOC(Entity FKNFFDFGNMN, in float3 JALOCDAJKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2A76260", Offset = "0x2A75660", VA = "0x182A76260", Slot = "9")]
	public void FNECNGGHHBL(Entity FKNFFDFGNMN, out float3 OMFIFBMFGMG, out quaternion PFHPGOOLCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2A76040", Offset = "0x2A75440", VA = "0x182A76040", Slot = "10")]
	public void FNECNGGHHBL(Entity FKNFFDFGNMN, out RigidTransform FGPGCDAKBPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2A76D10", Offset = "0x2A76110", VA = "0x182A76D10", Slot = "37")]
	public void JHIFLLJCCAI(Entity FKNFFDFGNMN, out float3 OMFIFBMFGMG, out quaternion PFHPGOOLCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2A76E90", Offset = "0x2A76290", VA = "0x182A76E90", Slot = "11")]
	public void JHIFLLJCCAI(Entity FKNFFDFGNMN, out RigidTransform FGPGCDAKBPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2A749C0", Offset = "0x2A73DC0", VA = "0x182A749C0")]
	public void BJOOBAJCHIA(Entity FKNFFDFGNMN, in float3 KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2A754B0", Offset = "0x2A748B0", VA = "0x182A754B0", Slot = "19")]
	public float3 EBNIMCFMDDE(Entity FKNFFDFGNMN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2A755E0", Offset = "0x2A749E0", VA = "0x182A755E0")]
	public void MFOMCJMMBPP(Entity FKNFFDFGNMN, in quaternion KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2A74B20", Offset = "0x2A73F20", VA = "0x182A74B20", Slot = "21")]
	public quaternion CCCAIKOJMAO(Entity FKNFFDFGNMN)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2A766D0", Offset = "0x2A75AD0", VA = "0x182A766D0")]
	public void IKEICOPHCJK(Entity FKNFFDFGNMN, in float3 KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2A75290", Offset = "0x2A74690", VA = "0x182A75290", Slot = "22")]
	public float3 EAKMOACDLLI(Entity FKNFFDFGNMN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2A76480", Offset = "0x2A75880", VA = "0x182A76480", Slot = "24")]
	public void GOIKJJIMLKO(Entity FKNFFDFGNMN, float CBIJGKILOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2A753C0", Offset = "0x2A747C0", VA = "0x182A753C0", Slot = "25")]
	public float EANEEINKPOJ(Entity FKNFFDFGNMN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2A74C40", Offset = "0x2A74040", VA = "0x182A74C40")]
	public void CIOMNINEODE(Entity FKNFFDFGNMN, in float3 LFCMEMLJNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2A77010", Offset = "0x2A76410", VA = "0x182A77010", Slot = "27")]
	public float3 JOFIOKOAPDD(Entity FKNFFDFGNMN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2A75710", Offset = "0x2A74B10", VA = "0x182A75710", Slot = "32")]
	public void EJCCDMCCDNF(Entity FKNFFDFGNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2A77BB0", Offset = "0x2A76FB0", VA = "0x182A77BB0")]
	private KDLENLDMBAK NALPOBPKHMP(Transform FELEGEFPADK)
	{
		return default(KDLENLDMBAK);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2A77760", Offset = "0x2A76B60", VA = "0x182A77760")]
	private static TransformEntity LHPGLLJOBJI(LENINMGJJHF JLNNFEOBAMK, GameObject BKJBFAHBGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x12C5C20", Offset = "0x12C5020", VA = "0x1812C5C20")]
	private static T GBNKABOJBJN<T>(GameObject BKJBFAHBGJH) where T : MonoBehaviour
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2A75C80", Offset = "0x2A75080", VA = "0x182A75C80", Slot = "33")]
	public void FECCAPKOEFF(Entity FKNFFDFGNMN, Entity KMKEMACKNKI, Entity GHLIBENNEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public OHDDHPCBLAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2A75100", Offset = "0x2A74500", VA = "0x182A75100", Slot = "5")]
	private void DHGLLFJLMAI(Entity FKNFFDFGNMN, in float3 KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2A785C0", Offset = "0x2A779C0", VA = "0x182A785C0", Slot = "7")]
	private void PPHNNBGMJDL(Entity FKNFFDFGNMN, in quaternion KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2A76AC0", Offset = "0x2A75EC0", VA = "0x182A76AC0", Slot = "13")]
	private void OMLFJJKGENO(Entity FKNFFDFGNMN, in float3 KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2A75EA0", Offset = "0x2A752A0", VA = "0x182A75EA0", Slot = "16")]
	private void HLAHGEFAPGE(Entity FKNFFDFGNMN, in float3 KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2A749C0", Offset = "0x2A73DC0", VA = "0x182A749C0", Slot = "18")]
	private void MIEIKPOFIJE(Entity FKNFFDFGNMN, in float3 KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2A755E0", Offset = "0x2A749E0", VA = "0x182A755E0", Slot = "20")]
	private void EIOLEHGCAFO(Entity FKNFFDFGNMN, in quaternion KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2A78330", Offset = "0x2A77730", VA = "0x182A78330", Slot = "23")]
	private void NNFGDHLKNHJ(Entity FKNFFDFGNMN, in float3 KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2A766C0", Offset = "0x2A75AC0", VA = "0x182A766C0", Slot = "26")]
	private void HCKODBKCHEJ(Entity FKNFFDFGNMN, in float3 KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2A75E90", Offset = "0x2A75290", VA = "0x182A75E90", Slot = "29")]
	private void FMBGBMGDFLH(Entity FKNFFDFGNMN, in float4x4 EDPPOHIOEHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class HCBFIKJEBLI
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class CKKLELCKANA : EKFCEBIIGNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly string CMGDHIHGGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly CKKLELCKANA CCKKMJOKCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly List<CKKLELCKANA> DAIFLLDJBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly List<LJHGDPGPANM> NFDNHCCMBMJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string IAGIIMOLDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7E8110", Offset = "0x7E7510", VA = "0x1807E8110", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public EKFCEBIIGNK HMBOANPLIHM
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IEnumerable<EKFCEBIIGNK> JLIAMNCJPJN
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7E8120", Offset = "0x7E7520", VA = "0x1807E8120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x251C8D0", Offset = "0x251BCD0", VA = "0x18251C8D0")]
	public CKKLELCKANA(string DKPHPKDPBCM, CKKLELCKANA ILDFJHMNOPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
[EFDJEPLIMOC(typeof(OKGCFPBMNKK), new string[] { })]
internal class OKGCFPBMNKK : DEPDOFHIDBA
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2229720", Offset = "0x2228B20", VA = "0x182229720", Slot = "4")]
	public void MCOOCEGHCPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public OKGCFPBMNKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[EFDJEPLIMOC(typeof(DGDICPPMDDO), new string[] { })]
public class EOIJBAMFFIO : AKFIPDJCCOH, DGDICPPMDDO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private EntityManager GLPCEPPDPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private PGEMHDJNMBJ KONCEINPAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private KKJECAIDLGC NPOFINHBGBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool MMLDFGNKLLJ;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x28CA4C0", Offset = "0x28C98C0", VA = "0x1828CA4C0", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x28CA410", Offset = "0x28C9810", VA = "0x1828CA410", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x28CA590", Offset = "0x28C9990", VA = "0x1828CA590", Slot = "5")]
	public bool JHJFJJLBANG(KDLENLDMBAK LCODCOPGHJA, out Collider JGLBLFOJFCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x28CA720", Offset = "0x28C9B20", VA = "0x1828CA720", Slot = "6")]
	public GameObject OOCICAKKFHO(KDLENLDMBAK ILEDIHBNDFN, GameObject IFEHFDIPHFJ, Vector3 KLNBLJCMMCM, Quaternion EDHIFCBPMNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x28CA420", Offset = "0x28C9820", VA = "0x1828CA420", Slot = "7")]
	public void GIGBIENJMDO(GameObject JGLBLFOJFCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1F98800", Offset = "0x1F97C00", VA = "0x181F98800", Slot = "8")]
	public TCollider KGMGHOKKADC<TCollider>(GameObject AJOEPLFEHEE) where TCollider : Collider
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x28CA660", Offset = "0x28C9A60", VA = "0x1828CA660", Slot = "9")]
	public void OJIMNACABAH(Collider JGLBLFOJFCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1F98800", Offset = "0x1F97C00", VA = "0x181F98800", Slot = "10")]
	public GameObject AIGLDMEDHNN<TCollider>(string DKPHPKDPBCM) where TCollider : Collider
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public EOIJBAMFFIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class AJAFLEAMLNK
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class BAHKBHMHHLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private NativeList<CDLJJAHPLFA> EIIGEOPPAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private NativeList<PEHOAOEGBBM> HFFDABOACMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private NativeList<BEHJCNECJCL> KPEBECEHHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private NativeList<PEHOAOEGBBM> MLOHNDFJPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private bool MMLDFGNKLLJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NativeList<CDLJJAHPLFA> MMPCJEPJLLA
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9CDA70", Offset = "0x9CCE70", VA = "0x1809CDA70")]
		get
		{
			return default(NativeList<CDLJJAHPLFA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public NativeList<PEHOAOEGBBM> AHCCKFJBMDK
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9CDA80", Offset = "0x9CCE80", VA = "0x1809CDA80")]
		get
		{
			return default(NativeList<PEHOAOEGBBM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NativeList<BEHJCNECJCL> FPEBHFIJDEG
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xC0F7F0", Offset = "0xC0EBF0", VA = "0x180C0F7F0")]
		get
		{
			return default(NativeList<BEHJCNECJCL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public NativeList<PEHOAOEGBBM> FHPBLGGCAOC
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9CDA90", Offset = "0x9CCE90", VA = "0x1809CDA90")]
		get
		{
			return default(NativeList<PEHOAOEGBBM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public JobHandle NFGFOHGFMOM
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x98EEA0", Offset = "0x98E2A0", VA = "0x18098EEA0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x98D8D0", Offset = "0x98CCD0", VA = "0x18098D8D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool MFBOKABNEDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2510C80", Offset = "0x2510080", VA = "0x182510C80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2510F00", Offset = "0x2510300", VA = "0x182510F00")]
	public BAHKBHMHHLL(Allocator GMMIODGPFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2510E70", Offset = "0x2510270", VA = "0x182510E70")]
	public void PEHJALIONDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2510D40", Offset = "0x2510140", VA = "0x182510D40")]
	public void NEAHAFKMCLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2510940", Offset = "0x250FD40", VA = "0x182510940")]
	public void EBOHBLNDMAL(Entity FKNFFDFGNMN, Entity KMKEMACKNKI, Entity GHLIBENNEBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
internal class JBNBFLICIDL : JKIEMPJPHGI
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private EntityQuery PNGFJEAJDGO;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2887580", Offset = "0x2886980", VA = "0x182887580", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2887620", Offset = "0x2886A20", VA = "0x182887620", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public JBNBFLICIDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[HONNCCIFPDK(CAGOEBHGGNL.OMRoom)]
internal class PKMKELBJJGF : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private EGBDNLKFOBI IPBNMJJAIHM;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2235050", Offset = "0x2234450", VA = "0x182235050", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x22350A0", Offset = "0x22344A0", VA = "0x1822350A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public PKMKELBJJGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class OODPHCGCIOL
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class AGKADKCKECM
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class OPGBKOAILPJ<T> : CDGFPKEPFIC<T>, MHOBFBAOGME<CMFFIMLEPBE, T>, KFFHHBDDKDC<CMFFIMLEPBE>, COKGGJJNNDI, IDisposable, MLIEHECMNHI where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly KFFHHBDDKDC<Entity> HNNIGEFAIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly AOONNPAOEFB FHJACJEANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private Delegate DLPCLNEAINL;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public string GHALHBJBCAO
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x37C53B0", Offset = "0x37C47B0", VA = "0x1837C53B0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Type JJGFPAEGNBA
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x37BDFA0", Offset = "0x37BD3A0", VA = "0x1837BDFA0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public OPHEKAOFDCM BDLMLIAIJEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x37BF830", Offset = "0x37BEC30", VA = "0x1837BF830", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int FFKGOHONJLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x37C5180", Offset = "0x37C4580", VA = "0x1837C5180", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public CBKEFCCBIHK CGPBOEFMOBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x37C3660", Offset = "0x37C2A60", VA = "0x1837C3660", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event CDOKGDJBJCM<CMFFIMLEPBE> FMPPFIKKFCM
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x37C0030", Offset = "0x37BF430", VA = "0x1837C0030", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x37C5AF0", Offset = "0x37C4EF0", VA = "0x1837C5AF0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2F3B930", Offset = "0x2F3AD30", VA = "0x182F3B930")]
	public OPGBKOAILPJ(KFFHHBDDKDC<Entity> HNNIGEFAIIM, AOONNPAOEFB FHJACJEANIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x37C7820", Offset = "0x37C6C20", VA = "0x1837C7820")]
	private Entity OILFFIENIEA(CMFFIMLEPBE AIOICCOKGOP)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x37C7670", Offset = "0x37C6A70", VA = "0x1837C7670")]
	private CMFFIMLEPBE OILFFIENIEA(Entity FKNFFDFGNMN)
	{
		return default(CMFFIMLEPBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x37C2EE0", Offset = "0x37C22E0", VA = "0x1837C2EE0", Slot = "4")]
	public T IKHPLCCBENN(CMFFIMLEPBE AIOICCOKGOP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x37BF460", Offset = "0x37BE860", VA = "0x1837BF460")]
	public bool DADPJLGDIHI(CMFFIMLEPBE AIOICCOKGOP, in T NDKKBDCFLEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x37C10B0", Offset = "0x37C04B0", VA = "0x1837C10B0", Slot = "7")]
	public bool HABKCECLKEN(CMFFIMLEPBE AIOICCOKGOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x37C2280", Offset = "0x37C1680", VA = "0x1837C2280", Slot = "8")]
	public void IKHPLCCBENN(CMFFIMLEPBE AIOICCOKGOP, PHJBMACKBCD KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x37BE0C0", Offset = "0x37BD4C0", VA = "0x1837BE0C0", Slot = "9")]
	public bool DADPJLGDIHI(CMFFIMLEPBE AIOICCOKGOP, NBOENLAPDFO NDKKBDCFLEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2F3AD60", Offset = "0x2F3A160", VA = "0x182F3AD60", Slot = "16")]
	public void KOJIBCNMEML(KFBFMDMFJDA MFMFLMKKKDK, [Optional] object JNNDIHFHMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x37BF970", Offset = "0x37BED70", VA = "0x1837BF970", Slot = "10")]
	public bool DGCDPJOAHEA(CMFFIMLEPBE OPMNDBPHMGG, CMFFIMLEPBE CDNLFOGBLLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x37C05B0", Offset = "0x37BF9B0", VA = "0x1837C05B0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x37C7F40", Offset = "0x37C7340", VA = "0x1837C7F40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x37C7210", Offset = "0x37C6610", VA = "0x1837C7210")]
	private void MJFIIHCCNAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x37C4BB0", Offset = "0x37C3FB0", VA = "0x1837C4BB0")]
	private void KBPJDJHEFFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x37BD3A0", Offset = "0x37BC7A0", VA = "0x1837BD3A0")]
	private void AIADOGEBBDD(Entity FKNFFDFGNMN, in NBOENLAPDFO PHNODIMLADH, in NBOENLAPDFO NDKKBDCFLEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x37C05E0", Offset = "0x37BF9E0", VA = "0x1837C05E0")]
	private void GLJLAMPAIGL(Entity FKNFFDFGNMN, in NBOENLAPDFO PHNODIMLADH, in NBOENLAPDFO NDKKBDCFLEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class MLAAMIDJKGF : PADOFPJBFIO
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2A678B0", Offset = "0x2A66CB0", VA = "0x182A678B0", Slot = "5")]
	public override Action DIDJMLFICEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[UnityEngine.Scripting.Preserve]
	public abstract void CNJANGMIDFH<T>() where T : EKKONKFFCGH;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2A67940", Offset = "0x2A66D40", VA = "0x182A67940")]
	[UnityEngine.Scripting.Preserve]
	public void FBCDLLLINCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2514550", Offset = "0x2513950", VA = "0x182514550")]
	protected MLAAMIDJKGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[EFDJEPLIMOC(typeof(MBJPBGDNNCH), new string[] { })]
public class HAMHECCJFGO : AKFIPDJCCOH, MBJPBGDNNCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private EntityManager GLPCEPPDPLB;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x28DC050", Offset = "0x28DB450", VA = "0x1828DC050", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x28DBFE0", Offset = "0x28DB3E0", VA = "0x1828DBFE0", Slot = "5")]
	public void GAHFFFEGJHJ(KDLENLDMBAK BGPCGOEKFEF, bool KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x180E8D0", Offset = "0x180DCD0", VA = "0x18180E8D0")]
	private void DADPJLGDIHI<T>(KDLENLDMBAK BGPCGOEKFEF, bool KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public HAMHECCJFGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[EFDJEPLIMOC(typeof(DPDGJLIFKMC), new string[] { })]
[JOCOBGMDOKK(CAGOEBHGGNL.LoadInstance)]
public class DPDGJLIFKMC : AKFIPDJCCOH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class EALNDOHHJKP : IEnumerable<ELAIMCPDFHF>, IEnumerable, IEnumerator<ELAIMCPDFHF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private ELAIMCPDFHF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public NativeArray<Entity> <>3__entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public DPDGJLIFKMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private EntityManager <entityManager>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private NativeArray<Entity>.Enumerator <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private Entity <entity>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private OEDLHJHPJCL <rbex>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private ELAIMCPDFHF System.Collections.Generic.IEnumerator<RecRoom.Rbex.IOMRigidbodyExImpl>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xB48080", Offset = "0xB47480", VA = "0x180B48080")]
		[DebuggerHidden]
		public EALNDOHHJKP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x270C0B0", Offset = "0x270B4B0", VA = "0x18270C0B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x270BDB0", Offset = "0x270B1B0", VA = "0x18270BDB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x270BD60", Offset = "0x270B160", VA = "0x18270BD60")]
		private void MIMEIPDHABP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x270C070", Offset = "0x270B470", VA = "0x18270C070", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x270BFC0", Offset = "0x270B3C0", VA = "0x18270BFC0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ELAIMCPDFHF> System.Collections.Generic.IEnumerable<RecRoom.Rbex.IOMRigidbodyExImpl>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x270BFC0", Offset = "0x270B3C0", VA = "0x18270BFC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly List<(NativeArray<Entity> entities, bool awake, bool hasRigidbody)> EEOCOAGJICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ONGFANECMJO]
	private PFJMBDHJHAN GKACEDOEIPO;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x28C05D0", Offset = "0x28BF9D0", VA = "0x1828C05D0", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x28C0350", Offset = "0x28BF750", VA = "0x1828C0350")]
	public void CEEBHAOLFMK(NativeArray<Entity> PGJLMFPAKDA, bool PPFEONKIEDM, bool ILPBJPMPILL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x28C0090", Offset = "0x28BF490", VA = "0x1828C0090")]
	public void ANIPCHIAHDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x28C0620", Offset = "0x28BFA20", VA = "0x1828C0620")]
	private void ONEFNEBBCJB(NativeArray<Entity> PGJLMFPAKDA, bool PPFEONKIEDM, bool ILPBJPMPILL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x28C02C0", Offset = "0x28BF6C0", VA = "0x1828C02C0")]
	[IteratorStateMachine(typeof(EALNDOHHJKP))]
	private IEnumerable<ELAIMCPDFHF> BPHCKDGJPLG(NativeArray<Entity> PGJLMFPAKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x28C0470", Offset = "0x28BF870", VA = "0x1828C0470", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x28C0D60", Offset = "0x28C0160", VA = "0x1828C0D60")]
	public DPDGJLIFKMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[JOCOBGMDOKK(CAGOEBHGGNL.LoadInstance)]
[EFDJEPLIMOC(typeof(CAAJLLDIGHE), new string[] { })]
public class CAAJLLDIGHE : AKFIPDJCCOH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<NativeListAsync<EDOBMHDMGJF>> BKMJDGJHNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[ONGFANECMJO]
	private PFJMBDHJHAN GKACEDOEIPO;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2515650", Offset = "0x2514A50", VA = "0x182515650", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2515480", Offset = "0x2514880", VA = "0x182515480")]
	public void CEEBHAOLFMK(NativeListAsync<EDOBMHDMGJF> PGJLMFPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2515080", Offset = "0x2514480", VA = "0x182515080")]
	public void ANIPCHIAHDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x25154F0", Offset = "0x25148F0", VA = "0x1825154F0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2515730", Offset = "0x2514B30", VA = "0x182515730")]
	public CAAJLLDIGHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class AMAMGAIKCFN
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static readonly ProfilerMarker AAKOECPBFCG;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly ProfilerMarker GEHDNNKIOHM;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x250F410", Offset = "0x250E810", VA = "0x18250F410")]
	public static void LPGLFILFNHK(this HKJKANBGCIL PHPOLCBAEBM, ABPNKIGHGCN NNGHEIFAPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x250F0A0", Offset = "0x250E4A0", VA = "0x18250F0A0")]
	public static void DEAMLPDEOOP(this HKJKANBGCIL PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x250F800", Offset = "0x250EC00", VA = "0x18250F800")]
	private static string[] OCKBMEHKDAC(ABPNKIGHGCN NNGHEIFAPDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x250F250", Offset = "0x250E650", VA = "0x18250F250")]
	private static bool ELGNOMAHEGC(ABPNKIGHGCN NNGHEIFAPDC, out string[] JBIKCMPFNCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7E8C00", Offset = "0x7E8000", VA = "0x1807E8C00")]
	private static bool HMHFOEGJDFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[EFDJEPLIMOC(typeof(AOONNPAOEFB), new string[] { })]
public class HFBNJFGGAAM : AKFIPDJCCOH, AOONNPAOEFB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static readonly PILIJFIMAJF NLFFMPAIDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ONGFANECMJO]
	private GIFAPDPEGID OEBMDJNIHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ONGFANECMJO]
	private EONNPNOIBPC MCJOPJDGNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ONGFANECMJO]
	private DNMGNPMNFDI EGEBFNBKGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ONGFANECMJO]
	private JKFGGDBFGOH EDNPFADAINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ONGFANECMJO]
	private EDAGPFPPFFG AJMDHBOAFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private ILIBONIKHOI CDIHHIPDEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private CIEAPPOCDCN KKLGCCIPMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool MMLDFGNKLLJ;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public GIFAPDPEGID PMIDMGFEIFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7E8110", Offset = "0x7E7510", VA = "0x1807E8110", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public JODLCELHFNO FCDPIDPOEPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8FE990", Offset = "0x8FDD90", VA = "0x1808FE990", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(JODLCELHFNO);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8FE9A0", Offset = "0x8FDDA0", VA = "0x1808FE9A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<PPACDBGDBCI, NativeArray<LENINMGJJHF>> HFAEMBOIGMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x28DDE40", Offset = "0x28DD240", VA = "0x1828DDE40", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x28DC330", Offset = "0x28DB730", VA = "0x1828DC330", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<PPACDBGDBCI> NNKPECFFFIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x28DD020", Offset = "0x28DC420", VA = "0x1828DD020", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x28DDEE0", Offset = "0x28DD2E0", VA = "0x1828DDEE0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x28DD730", Offset = "0x28DCB30", VA = "0x1828DD730", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x28DCD90", Offset = "0x28DC190", VA = "0x1828DCD90", Slot = "40")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x28DD6B0", Offset = "0x28DCAB0", VA = "0x1828DD6B0")]
	private void IEPMAPNNLGG(PPACDBGDBCI AHGPNHPBGNL, NativeArray<LENINMGJJHF> PMMGJMLABKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x28DDA30", Offset = "0x28DCE30", VA = "0x1828DDA30")]
	private void JBKMANEMEEM(PPACDBGDBCI AHGPNHPBGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x28DDCA0", Offset = "0x28DD0A0", VA = "0x1828DDCA0")]
	internal KDLENLDMBAK LJMNJHEFGPL(Entity FKNFFDFGNMN)
	{
		return default(KDLENLDMBAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x28DCCB0", Offset = "0x28DC0B0", VA = "0x1828DCCB0", Slot = "11")]
	public CJNBAFDACBF DODEMOFAKND(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(CJNBAFDACBF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x28DDAA0", Offset = "0x28DCEA0", VA = "0x1828DDAA0", Slot = "12")]
	public LENINMGJJHF KKPCNJHFKAF(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(LENINMGJJHF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x28DD5C0", Offset = "0x28DC9C0", VA = "0x1828DD5C0", Slot = "39")]
	public bool HABKCECLKEN(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x28DD2B0", Offset = "0x28DC6B0", VA = "0x1828DD2B0", Slot = "34")]
	public void FMEHBMDFEDJ(PPACDBGDBCI KOJOICDCDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x28DD0C0", Offset = "0x28DC4C0", VA = "0x1828DD0C0", Slot = "35")]
	public void FBDDBFFKADI(KDLENLDMBAK LCODCOPGHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x28DCFB0", Offset = "0x28DC3B0", VA = "0x1828DCFB0", Slot = "36")]
	public void EHKGCEAOOAN(KDLENLDMBAK LCODCOPGHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x28DD180", Offset = "0x28DC580", VA = "0x1828DD180", Slot = "37")]
	public void FMEHBMDFEDJ(KDLENLDMBAK LCODCOPGHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x28DE300", Offset = "0x28DD700", VA = "0x1828DE300", Slot = "24")]
	public PPACDBGDBCI OIPIJNOEBKM(NativeArray<CMFFIMLEPBE> AIOICCOKGOP, Allocator GMMIODGPFPJ)
	{
		return default(PPACDBGDBCI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x28DCB60", Offset = "0x28DBF60", VA = "0x1828DCB60", Slot = "25")]
	public PPACDBGDBCI DHDMDNFIBGC(NativeArray<CMFFIMLEPBE> AIOICCOKGOP, NativeArray<EFFOMHNHCBO> JONOBDJBMLJ, Allocator GMMIODGPFPJ)
	{
		return default(PPACDBGDBCI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x28DC5C0", Offset = "0x28DB9C0", VA = "0x1828DC5C0", Slot = "26")]
	public EFBPNECENII CGDIEAADOPD(LENINMGJJHF MNOKFAHHNHH, bool LKMELNGEJFK)
	{
		return default(EFBPNECENII);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x28DC6B0", Offset = "0x28DBAB0", VA = "0x1828DC6B0", Slot = "27")]
	public EFBPNECENII CGDIEAADOPD(LENINMGJJHF MNOKFAHHNHH)
	{
		return default(EFBPNECENII);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x28DDBC0", Offset = "0x28DCFC0", VA = "0x1828DDBC0", Slot = "28")]
	public EFBPNECENII KNDJPPIAOGM(LENINMGJJHF MNOKFAHHNHH)
	{
		return default(EFBPNECENII);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x28DE040", Offset = "0x28DD440", VA = "0x1828DE040", Slot = "29")]
	public EFBPNECENII OBMHIMMNIBM(LENINMGJJHF MNOKFAHHNHH)
	{
		return default(EFBPNECENII);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x28DC900", Offset = "0x28DBD00", VA = "0x1828DC900", Slot = "30")]
	public EFBPNECENII DHDMDNFIBGC(CMFFIMLEPBE AIOICCOKGOP, LENINMGJJHF MNOKFAHHNHH)
	{
		return default(EFBPNECENII);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x28DD4B0", Offset = "0x28DC8B0", VA = "0x1828DD4B0", Slot = "31")]
	public IPHCFGGLOCO GJEGPKDJIKJ()
	{
		return default(IPHCFGGLOCO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x28DC3D0", Offset = "0x28DB7D0", VA = "0x1828DC3D0", Slot = "32")]
	public BPHMAGJHJEM BIMCGJHILGA()
	{
		return default(BPHMAGJHJEM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x28DC4C0", Offset = "0x28DB8C0", VA = "0x1828DC4C0", Slot = "33")]
	public APMGOACLPEO BNHELOPAIOO(EHKHPDFBEJD JLNNFEOBAMK)
	{
		return default(APMGOACLPEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x28DD160", Offset = "0x28DC560", VA = "0x1828DD160", Slot = "13")]
	public void FIMKNKKCEGK(CMFFIMLEPBE AIOICCOKGOP, CJHAGIKCJCL CJBENKPGJFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x28DDCF0", Offset = "0x28DD0F0", VA = "0x1828DDCF0", Slot = "14")]
	public EFBPNECENII MIPMPNEGLMG(KDLENLDMBAK LCODCOPGHJA, [Optional] object GAOLOMEJCOK)
	{
		return default(EFBPNECENII);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x28DC290", Offset = "0x28DB690", VA = "0x1828DC290", Slot = "15")]
	public bool BDGDJOEOFJD(KDLENLDMBAK LCODCOPGHJA, out CJHAGIKCJCL OHCLGKAJOMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x28DC1F0", Offset = "0x28DB5F0", VA = "0x1828DC1F0", Slot = "16")]
	public bool AMHGHJGADGN(KDLENLDMBAK LCODCOPGHJA, out Transform FELEGEFPADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x28DC790", Offset = "0x28DBB90", VA = "0x1828DC790", Slot = "17")]
	public bool CGEGNOGJDCD(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x28DC820", Offset = "0x28DBC20", VA = "0x1828DC820", Slot = "18")]
	public void CLGLMEJAHPF(KDLENLDMBAK LCODCOPGHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x28DD660", Offset = "0x28DCA60", VA = "0x1828DD660", Slot = "19")]
	public bool IDHHCLLPEJO(LocalId LCODCOPGHJA, object GAOLOMEJCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x28DC8B0", Offset = "0x28DBCB0", VA = "0x1828DC8B0", Slot = "20")]
	public bool DDGMIIBELPN(LocalId LCODCOPGHJA, object GAOLOMEJCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x28DDF80", Offset = "0x28DD380", VA = "0x1828DDF80", Slot = "38")]
	public PPACDBGDBCI MOCOOKLAOJK(PPACDBGDBCI GEKPNOHHCDG, Allocator GMMIODGPFPJ)
	{
		return default(PPACDBGDBCI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x28DE000", Offset = "0x28DD400", VA = "0x1828DE000", Slot = "23")]
	public CMFFIMLEPBE NLOPILAOEJF(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(CMFFIMLEPBE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x28DE2C0", Offset = "0x28DD6C0", VA = "0x1828DE2C0", Slot = "21")]
	public KDLENLDMBAK OIPIJNOEBKM(CMFFIMLEPBE AIOICCOKGOP)
	{
		return default(KDLENLDMBAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x28DDFE0", Offset = "0x28DD3E0", VA = "0x1828DDFE0", Slot = "22")]
	public bool NAGMLCICLNG(CMFFIMLEPBE AIOICCOKGOP, out KDLENLDMBAK LCODCOPGHJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x28DE1B0", Offset = "0x28DD5B0", VA = "0x1828DE1B0")]
	private void OCNKGBHEFCP(LENINMGJJHF CKDJGOFBFEJ, KDLENLDMBAK LCODCOPGHJA, CMFFIMLEPBE AIOICCOKGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public HFBNJFGGAAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[EFDJEPLIMOC(typeof(ADBHPBOEEGG), new string[] { })]
public class LPCGGEJPLLN : AKFIPDJCCOH, ADBHPBOEEGG
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[ONGFANECMJO]
	private PFJMBDHJHAN GKACEDOEIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[ONGFANECMJO]
	private LPMPALGCIEF PJDNDHAAPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ONGFANECMJO]
	private HGCCGCKMNPO KOKLPBCLJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	[ONGFANECMJO]
	private HDMAPPDIGGB PPFKADKNPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	[ONGFANECMJO]
	private NICJNOMPEDE IHNOHNBJLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ONGFANECMJO]
	private MLIPPJCKHBF DGLIEJINEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private World OINEMFIGHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private ABPMPKFPHAH NEKHICCBKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private ABPMPKFPHAH NACODKBJNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private ABPMPKFPHAH GHCAOIMDGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private ABPMPKFPHAH EDOBMHONBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ABPMPKFPHAH BOBILMMHGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private ABPMPKFPHAH LIKKHNKOOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private ABPMPKFPHAH JLIJDLBIGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private ABPMPKFPHAH HNCJLJAPEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private ABPMPKFPHAH LOEEBKLNKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private ABPMPKFPHAH KMCNGMKAJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private ABPMPKFPHAH BOLEGLNPFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ABPMPKFPHAH JADBEMNBGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private ABPMPKFPHAH LNKEHAKFFGJ;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private bool ENMFHCNHCAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2A62C00", Offset = "0x2A62000", VA = "0x182A62C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private bool CKKPJJIMPLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2A62B50", Offset = "0x2A61F50", VA = "0x182A62B50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool EHACGGAMNCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2A62C00", Offset = "0x2A62000", VA = "0x182A62C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool GIMLFPDELIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2A62C00", Offset = "0x2A62000", VA = "0x182A62C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2A62E40", Offset = "0x2A62240", VA = "0x182A62E40", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2930FD0", Offset = "0x29303D0", VA = "0x182930FD0")]
	private ABPMPKFPHAH IJCEMIAIIAL<T>() where T : EFJAMNAKIBJ
	{
		return default(ABPMPKFPHAH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2A62D30", Offset = "0x2A62130", VA = "0x182A62D30")]
	private ABPMPKFPHAH IJCEMIAIIAL(Type JLNNFEOBAMK)
	{
		return default(ABPMPKFPHAH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2A62DC0", Offset = "0x2A621C0", VA = "0x182A62DC0", Slot = "14")]
	public void IPKAMPAPJMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2A632D0", Offset = "0x2A626D0", VA = "0x182A632D0", Slot = "15")]
	public void MKPPGFIPBBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2A62DA0", Offset = "0x2A621A0", VA = "0x182A62DA0", Slot = "5")]
	public void IOJIAPMAHCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2A62810", Offset = "0x2A61C10", VA = "0x182A62810", Slot = "6")]
	public void ADDDAHNAOGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2A62C70", Offset = "0x2A62070", VA = "0x182A62C70", Slot = "7")]
	public void GMKDJKLHCDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2A62D60", Offset = "0x2A62160", VA = "0x182A62D60", Slot = "8")]
	public void INFMFOFLOFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2A62AD0", Offset = "0x2A61ED0", VA = "0x182A62AD0", Slot = "9")]
	public void DBKALKPGPNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2A63240", Offset = "0x2A62640", VA = "0x182A63240", Slot = "10")]
	public void KBBPJIBLDNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2A62B10", Offset = "0x2A61F10", VA = "0x182A62B10", Slot = "11")]
	public void DFOFEIPLCGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2A63350", Offset = "0x2A62750", VA = "0x182A63350", Slot = "12")]
	public void NAMNPCMKHML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2A62850", Offset = "0x2A61C50", VA = "0x182A62850", Slot = "13")]
	public void AIENBNGNHLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2A62CB0", Offset = "0x2A620B0", VA = "0x182A62CB0")]
	private void HNEBLFLNEGI(ABPMPKFPHAH JJBAHIPIPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2A62A30", Offset = "0x2A61E30", VA = "0x182A62A30")]
	private void BNOCEDMBDBJ(ABPMPKFPHAH JJBAHIPIPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2A62AB0", Offset = "0x2A61EB0", VA = "0x182A62AB0")]
	private void CJDFALKIAHK(ABPMPKFPHAH JJBAHIPIPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public LPCGGEJPLLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
[EFDJEPLIMOC(typeof(KNMAOLNPOGJ), new string[] { "Editor" })]
public sealed class KNMAOLNPOGJ
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate void DPAFGPGDALB(CMFFIMLEPBE EFKFHONOLKA, EFFOMHNHCBO KJFNAECAHBA, bool CACIJJIMHHI);

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate void DPPDBHOINHI(CMFFIMLEPBE EFKFHONOLKA, bool CACIJJIMHHI);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate void LAMOGJMCENH(CMFFIMLEPBE EFKFHONOLKA, GLFLLKHPAHK HNNIGEFAIIM, in NBOENLAPDFO KKIAKNLLHIO, bool CACIJJIMHHI);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public KNMAOLNPOGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[EFDJEPLIMOC(typeof(global::GHEMABPOFFC), new string[] { })]
internal class HKFKHHDPIFD : global::GHEMABPOFFC, AKFIPDJCCOH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[ONGFANECMJO]
	private AOONNPAOEFB FHJACJEANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[ONGFANECMJO]
	private IIKMCLIAKNK FEJKNPAOBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[ONGFANECMJO]
	private BLHCLDIBPBL NFDNHCCMBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[ONGFANECMJO]
	private CEJCPOECKAC LEGFAAONKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private Action<OJGPABLJLLP> GBCKPIBLKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private MDGCCNJAIOM<Entity> ILDFJHMNOPJ;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<OJGPABLJLLP> MBBDIEJLJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x287B7B0", Offset = "0x287ABB0", VA = "0x18287B7B0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x287B500", Offset = "0x287A900", VA = "0x18287B500", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x287B8F0", Offset = "0x287ACF0", VA = "0x18287B8F0", Slot = "6")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x287B640", Offset = "0x287AA40", VA = "0x18287B640", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x287B7B0", Offset = "0x287ABB0", VA = "0x18287B7B0")]
	private void FFCADBIBAFA(Action<OJGPABLJLLP> KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x287B500", Offset = "0x287A900", VA = "0x18287B500")]
	private void FCLPKACPPND(Action<OJGPABLJLLP> KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x287BAA0", Offset = "0x287AEA0", VA = "0x18287BAA0")]
	private void KPECEEIMOND(NPCCBNHIEEP KJFNAECAHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public HKFKHHDPIFD()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct HHICEMKENIH : ISystem
{
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "4")]
	public void OnCreate(ref SystemState PJAFLHHFBPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
	public void OnDestroy(ref SystemState PJAFLHHFBPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x287A930", Offset = "0x2879D30", VA = "0x18287A930", Slot = "6")]
	public void OnUpdate(ref SystemState PJAFLHHFBPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	[Unity.Entities.MonoPInvokeCallback(typeof(SystemBaseDelegates.Function))]
	internal static void NELAOKLPEBD(IntPtr JCOLBAAGCGE, IntPtr PJAFLHHFBPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x287A930", Offset = "0x2879D30", VA = "0x18287A930")]
	[Unity.Entities.MonoPInvokeCallback(typeof(SystemBaseDelegates.Function))]
	internal static void ICKEFFOHHHH(IntPtr JCOLBAAGCGE, IntPtr PJAFLHHFBPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	[Unity.Entities.MonoPInvokeCallback(typeof(SystemBaseDelegates.Function))]
	internal static void MKACDNMBIPC(IntPtr JCOLBAAGCGE, IntPtr PJAFLHHFBPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[HONNCCIFPDK(CAGOEBHGGNL.OMRoom)]
internal class MJLHDIIGDGE : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NLLKOIOEBHH FLAALGKHIJL;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2A66A10", Offset = "0x2A65E10", VA = "0x182A66A10", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2A66A60", Offset = "0x2A65E60", VA = "0x182A66A60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public MJLHDIIGDGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class BKPKBMIEPDH : PADOFPJBFIO
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private enum OINPPLGHPMP
	{

	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2514430", Offset = "0x2513830", VA = "0x182514430", Slot = "5")]
	public override Action DIDJMLFICEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[UnityEngine.Scripting.Preserve]
	public abstract void ANNBAKEJHBN<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x25144C0", Offset = "0x25138C0", VA = "0x1825144C0")]
	[UnityEngine.Scripting.Preserve]
	public void FBCDLLLINCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2514550", Offset = "0x2513950", VA = "0x182514550")]
	protected BKPKBMIEPDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
[EFDJEPLIMOC(typeof(KGINENEDIOC), new string[] { })]
public class KGINENEDIOC : AKFIPDJCCOH, CBKELFDIEEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private ILIBONIKHOI CDIHHIPDEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private ABLEKJPBMJE NFDNHCCMBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private GLFLLKHPAHK[] FNMOPKIMBDL;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x28927C0", Offset = "0x2891BC0", VA = "0x1828927C0", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2892830", Offset = "0x2891C30", VA = "0x182892830", Slot = "5")]
	public void JFCLKDMBJND(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2892B00", Offset = "0x2891F00", VA = "0x182892B00")]
	public void PEHBEOHGDIL(CMFFIMLEPBE AIOICCOKGOP, bool LGJJDNJOLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public KGINENEDIOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
[EFDJEPLIMOC(typeof(JKPBDEIBINB), new string[] { })]
public class GEELFLMBGFN : JKPBDEIBINB, IEnumerable<OMADGHGGHJN>, IEnumerable, OOLEGKACHHE, DEPDOFHIDBA, AKFIPDJCCOH, CBKELFDIEEL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	[ONGFANECMJO]
	private BLHCLDIBPBL NFDNHCCMBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly Dictionary<(Type, string), int> MBIKAOEBFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private NativeBitArray NFBKBGCPBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeArray<int> EABHMLGJINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NNDFCMOOFMO NNLKOEPMNGI;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public NativeBitArray BEKLCMJJOGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9CDA80", Offset = "0x9CCE80", VA = "0x1809CDA80", Slot = "4")]
		get
		{
			return default(NativeBitArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public NativeArray<int> FLDMMOECGOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xC0F7F0", Offset = "0xC0EBF0", VA = "0x180C0F7F0", Slot = "5")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private int LBKFFMPBPIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9777D0", Offset = "0x976BD0", VA = "0x1809777D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int NPBPHODFKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x28D5DF0", Offset = "0x28D51F0", VA = "0x1828D5DF0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public OMADGHGGHJN OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x28D57E0", Offset = "0x28D4BE0", VA = "0x1828D57E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public OMADGHGGHJN OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x28D57E0", Offset = "0x28D4BE0", VA = "0x1828D57E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x28D5E10", Offset = "0x28D5210", VA = "0x1828D5E10", Slot = "13")]
	public void MCOOCEGHCPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x28D5D70", Offset = "0x28D5170", VA = "0x1828D5D70", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "15")]
	public void JFCLKDMBJND(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x28D5E60", Offset = "0x28D5260", VA = "0x1828D5E60")]
	private void OPBDILOBNLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x28D5BC0", Offset = "0x28D4FC0", VA = "0x1828D5BC0", Slot = "9")]
	public OMADGHGGHJN IMOMPCNDOJA(NNHEPJDBKBI KKIJPENOLBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x28D5A50", Offset = "0x28D4E50", VA = "0x1828D5A50")]
	private bool GOJPNELNCHD(Type NJHGLCPHLGF, string DKPHPKDPBCM, out OMADGHGGHJN CHLMEBOBPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x28D5850", Offset = "0x28D4C50", VA = "0x1828D5850", Slot = "10")]
	public GLFLLKHPAHK ELFFHKHOAAN(NNHEPJDBKBI KKIJPENOLBP)
	{
		return default(GLFLLKHPAHK);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x28D5BA0", Offset = "0x28D4FA0", VA = "0x1828D5BA0", Slot = "11")]
	public IEnumerator<OMADGHGGHJN> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x28D5BA0", Offset = "0x28D4FA0", VA = "0x1828D5BA0", Slot = "12")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x28D5800", Offset = "0x28D4C00", VA = "0x1828D5800", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x28D6270", Offset = "0x28D5670", VA = "0x1828D6270")]
	public GEELFLMBGFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class PJPDPAMOADG
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x2234010", Offset = "0x2233410", VA = "0x182234010")]
	public static void JOEHBHHOJMO(EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN, in float3 KLNBLJCMMCM, in quaternion EDHIFCBPMNM, in float3 HMCGKJPEMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x2234480", Offset = "0x2233880", VA = "0x182234480")]
	public static void JPGEJBJOLPN(EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN, out float4x4 GKMKJBANBPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x2234320", Offset = "0x2233720", VA = "0x182234320")]
	private static void JPGEJBJOLPN(EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN, Entity ILDFJHMNOPJ, out float4x4 GKMKJBANBPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x22349A0", Offset = "0x2233DA0", VA = "0x1822349A0")]
	public static void NEGGJLHLKNJ(EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN, in float4x4 GKMKJBANBPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x2232760", Offset = "0x2231B60", VA = "0x182232760")]
	public static void CMENGPDLKOE(EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN, out float4x4 KKPJEDKJFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x22337C0", Offset = "0x2232BC0", VA = "0x1822337C0")]
	public static void GPOBOIPNHPO(EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN, in float4x4 KKPJEDKJFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x22345C0", Offset = "0x22339C0", VA = "0x1822345C0")]
	public static float3 KLGLGOFKLKK(EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2234F00", Offset = "0x2234300", VA = "0x182234F00")]
	public static void PEFPLBIKJOF(EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN, in float3 KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2234E10", Offset = "0x2234210", VA = "0x182234E10")]
	public static quaternion OJALBBDGOLE(EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x2233B70", Offset = "0x2232F70", VA = "0x182233B70")]
	public static void IMDNKOPAAID(EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN, in quaternion KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2231E20", Offset = "0x2231220", VA = "0x182231E20")]
	public static float3 AKEMNHBHJLN(EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x2233C30", Offset = "0x2233030", VA = "0x182233C30")]
	public static void IOHCNOFDJGP(EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN, in float3 KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x2233270", Offset = "0x2232670", VA = "0x182233270")]
	public static float FJNJBFLENFO(EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x2234D90", Offset = "0x2234190", VA = "0x182234D90")]
	public static void NNFCJEOBJJG(EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN, float KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x22348B0", Offset = "0x2233CB0", VA = "0x1822348B0")]
	public static float3 NCHOCFKCMEJ(EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2233340", Offset = "0x2232740", VA = "0x182233340")]
	public static void FNAHBLFDOOC(EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN, in float3 KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x22334F0", Offset = "0x22328F0", VA = "0x1822334F0")]
	public static void FNECNGGHHBL(EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN, out RigidTransform KKPJEDKJFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x22333D0", Offset = "0x22327D0", VA = "0x1822333D0")]
	public static void FNECNGGHHBL(EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN, out float3 OMFIFBMFGMG, out quaternion PFHPGOOLCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x2232190", Offset = "0x2231590", VA = "0x182232190")]
	public static void BPDCJNOIBCC(EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN, in float3 KLNBLJCMMCM, in quaternion EDHIFCBPMNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x2233DB0", Offset = "0x22331B0", VA = "0x182233DB0")]
	public static void JHIFLLJCCAI(EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN, out float3 OMFIFBMFGMG, out quaternion PFHPGOOLCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2233000", Offset = "0x2232400", VA = "0x182233000")]
	public static float3 EBNIMCFMDDE(EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x2231EF0", Offset = "0x22312F0", VA = "0x182231EF0")]
	public static void BJOOBAJCHIA(EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN, in float3 KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x22346C0", Offset = "0x2233AC0", VA = "0x1822346C0")]
	public static void MFOMCJMMBPP(EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN, in quaternion KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x2232250", Offset = "0x2231650", VA = "0x182232250")]
	public static quaternion CCCAIKOJMAO(EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x2232B50", Offset = "0x2231F50", VA = "0x182232B50")]
	public static float3 EAKMOACDLLI(EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2233900", Offset = "0x2232D00", VA = "0x182233900")]
	public static void IKEICOPHCJK(EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN, in float3 KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x2232E10", Offset = "0x2232210", VA = "0x182232E10")]
	public static float EANEEINKPOJ(EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2233680", Offset = "0x2232A80", VA = "0x182233680")]
	public static void GOIKJJIMLKO(EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN, float CBIJGKILOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x22340B0", Offset = "0x22334B0", VA = "0x1822340B0")]
	public static float3 JOFIOKOAPDD(EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x2232480", Offset = "0x2231880", VA = "0x182232480")]
	public static void CIOMNINEODE(EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN, in float3 LFCMEMLJNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x22335E0", Offset = "0x22329E0", VA = "0x1822335E0")]
	public static bool GJBANCIBOAL(EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN, out Entity ILDFJHMNOPJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[EFDJEPLIMOC(typeof(HNIPNFEMKKN), new string[] { })]
public class IHDIFFAKHOM : AKFIPDJCCOH, HNIPNFEMKKN
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class FLFFNBKOFCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public KDLENLDMBAK localId;

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public FLFFNBKOFCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x270DC80", Offset = "0x270D080", VA = "0x18270DC80")]
		internal object EPFFHPNBKPL(IHDIFFAKHOM a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class HGGPKAHJPDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public KDLENLDMBAK localId;

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public HGGPKAHJPDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x270F1F0", Offset = "0x270E5F0", VA = "0x18270F1F0")]
		internal object HGDEKDNDMIG(IHDIFFAKHOM a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private PFJMBDHJHAN GKACEDOEIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private AOONNPAOEFB FHJACJEANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private PGKBPEGCPKO KMPMKIKDFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private World BDLCNPMEDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private GCNJIPMMPBN LBOCEOBNMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ONGFANECMJO]
	private MDBOACJLHAE HNFAJKHJNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private EntityManager FJNGGFEILKE;

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x2881970", Offset = "0x2880D70", VA = "0x182881970", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x28812E0", Offset = "0x28806E0", VA = "0x1828812E0", Slot = "6")]
	public ELAIMCPDFHF HNJEAIJMHBN(KDLENLDMBAK LCODCOPGHJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x2883A20", Offset = "0x2882E20", VA = "0x182883A20", Slot = "5")]
	public void POONOMKELDH(KDLENLDMBAK LCODCOPGHJA, ELAIMCPDFHF KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x287F680", Offset = "0x287EA80", VA = "0x18287F680", Slot = "31")]
	public CollisionDetectionMode BEGKKJLFPHM(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(CollisionDetectionMode);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x287F2D0", Offset = "0x287E6D0", VA = "0x18287F2D0", Slot = "32")]
	public void AJNNKGJLFBN(KDLENLDMBAK LCODCOPGHJA, CollisionDetectionMode KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x287F060", Offset = "0x287E460", VA = "0x18287F060", Slot = "33")]
	public PPADPBDPHGN AAJPPHGACBL(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(PPADPBDPHGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x2883B10", Offset = "0x2882F10", VA = "0x182883B10", Slot = "34")]
	public void PPFHMLBAOPK(KDLENLDMBAK LCODCOPGHJA, PPADPBDPHGN KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x2882420", Offset = "0x2881820", VA = "0x182882420", Slot = "35")]
	public bool JHHFJHHPMNI(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x2880280", Offset = "0x287F680", VA = "0x182880280", Slot = "36")]
	public void EKNEALNFDBM(KDLENLDMBAK LCODCOPGHJA, bool KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x2881090", Offset = "0x2880490", VA = "0x182881090", Slot = "37")]
	public KDLENLDMBAK HIJCLBEKBJN(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(KDLENLDMBAK);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2883730", Offset = "0x2882B30", VA = "0x182883730", Slot = "38")]
	public void ONKICCKEALM(KDLENLDMBAK LCODCOPGHJA, KDLENLDMBAK KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x287F7D0", Offset = "0x287EBD0", VA = "0x18287F7D0", Slot = "39")]
	public KDLENLDMBAK BGOPCJKFHEJ(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(KDLENLDMBAK);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x287FA60", Offset = "0x287EE60", VA = "0x18287FA60", Slot = "40")]
	public void CIGBDIGMBAB(KDLENLDMBAK LCODCOPGHJA, KDLENLDMBAK KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x287FD40", Offset = "0x287F140", VA = "0x18287FD40", Slot = "7")]
	public void DHPKFCEIGDC(KDLENLDMBAK LCODCOPGHJA, KDLENLDMBAK KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2881F80", Offset = "0x2881380", VA = "0x182881F80", Slot = "8")]
	public void JGCNEKOCFFL(KDLENLDMBAK LCODCOPGHJA, KDLENLDMBAK KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2881E80", Offset = "0x2881280", VA = "0x182881E80", Slot = "9")]
	public int JEONIAELMNM(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x28805F0", Offset = "0x287F9F0", VA = "0x1828805F0", Slot = "10")]
	public KDLENLDMBAK EOJCKGCFKPD(KDLENLDMBAK LCODCOPGHJA, int NANJAGEOPJI)
	{
		return default(KDLENLDMBAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2883630", Offset = "0x2882A30", VA = "0x182883630", Slot = "11")]
	public void OLKHAAMOCPF(KDLENLDMBAK LCODCOPGHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x2882600", Offset = "0x2881A00", VA = "0x182882600", Slot = "12")]
	public void JPOEKBEILCA(KDLENLDMBAK LCODCOPGHJA, object GAOLOMEJCOK, KDLENLDMBAK KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x287F710", Offset = "0x287EB10", VA = "0x18287F710", Slot = "13")]
	public void BENPJPFGFKL(KDLENLDMBAK LCODCOPGHJA, object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x2881CE0", Offset = "0x28810E0", VA = "0x182881CE0", Slot = "14")]
	public bool JENLOODCAIE(KDLENLDMBAK LCODCOPGHJA, out KDLENLDMBAK KKIAKNLLHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x2883140", Offset = "0x2882540", VA = "0x182883140", Slot = "15")]
	public void NIEPNGNODNH(KDLENLDMBAK LCODCOPGHJA, float3 KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x2880B80", Offset = "0x287FF80", VA = "0x182880B80", Slot = "16")]
	public bool GKMLBOKHBGP(KDLENLDMBAK LCODCOPGHJA, out float3 KKIAKNLLHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2881820", Offset = "0x2880C20", VA = "0x182881820", Slot = "17")]
	public void INCMHCDJAJC(KDLENLDMBAK LCODCOPGHJA, float3 KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x2880750", Offset = "0x287FB50", VA = "0x182880750", Slot = "18")]
	public bool FMDKCGFMHLD(KDLENLDMBAK LCODCOPGHJA, out float3 KKIAKNLLHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2880F20", Offset = "0x2880320", VA = "0x182880F20", Slot = "23")]
	[Obsolete]
	public float3 HEKNMNIKLIH(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2880330", Offset = "0x287F730", VA = "0x182880330", Slot = "24")]
	public float3 EKNLDIAEDIL(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x287F170", Offset = "0x287E570", VA = "0x18287F170", Slot = "25")]
	public void AFDKBPGBFOP(KDLENLDMBAK LCODCOPGHJA, float3 KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2881760", Offset = "0x2880B60", VA = "0x182881760", Slot = "26")]
	public void IINDCHHCPBG(KDLENLDMBAK LCODCOPGHJA, float3 KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x28824B0", Offset = "0x28818B0", VA = "0x1828824B0", Slot = "27")]
	[Obsolete]
	public float JNMHPMHDKNK(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x287FB30", Offset = "0x287EF30", VA = "0x18287FB30", Slot = "28")]
	public float DAFCBPBOEFJ(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2881C30", Offset = "0x2881030", VA = "0x182881C30", Slot = "29")]
	public void JENCFFBEKON(KDLENLDMBAK LCODCOPGHJA, float KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x28808F0", Offset = "0x287FCF0", VA = "0x1828808F0", Slot = "30")]
	public void FOBBEKKGLOD(KDLENLDMBAK LCODCOPGHJA, float KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x28800D0", Offset = "0x287F4D0", VA = "0x1828800D0", Slot = "19")]
	public void EHKDALFLAIJ(KDLENLDMBAK LCODCOPGHJA, (Quaternion rot, Vector3 moments) KKLEBPJFJGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x28813B0", Offset = "0x28807B0", VA = "0x1828813B0", Slot = "20")]
	public bool IFAMIFFPHOL(KDLENLDMBAK LCODCOPGHJA, out quaternion IFDCCCEDOFF, out float3 BBHGAMIEKKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2882FD0", Offset = "0x28823D0", VA = "0x182882FD0", Slot = "41")]
	public BFEGGBIPHDI MKPPFBJNEDF(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(BFEGGBIPHDI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2882F30", Offset = "0x2882330", VA = "0x182882F30", Slot = "42")]
	public void MKJNDPEEJKO(KDLENLDMBAK LCODCOPGHJA, BFEGGBIPHDI KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x287FBD0", Offset = "0x287EFD0", VA = "0x18287FBD0", Slot = "66")]
	public void DHCKBHKDGOA(KDLENLDMBAK LCODCOPGHJA, object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x2880010", Offset = "0x287F410", VA = "0x182880010", Slot = "67")]
	public void EDFJDPBIJCE(KDLENLDMBAK LCODCOPGHJA, object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2882A80", Offset = "0x2881E80", VA = "0x182882A80", Slot = "68")]
	public bool KKNMGGMOBHB(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x2882890", Offset = "0x2881C90", VA = "0x182882890", Slot = "82")]
	public bool KHECNLMGIHO(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x28820E0", Offset = "0x28814E0", VA = "0x1828820E0", Slot = "83")]
	public void JHAKEHDCGIK(KDLENLDMBAK LCODCOPGHJA, object GAOLOMEJCOK, bool OLBFAGCJMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x287F4E0", Offset = "0x287E8E0", VA = "0x18287F4E0", Slot = "84")]
	public void ANHHNAEHEAP(KDLENLDMBAK LCODCOPGHJA, bool DHMDHJJOHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2882E80", Offset = "0x2882280", VA = "0x182882E80", Slot = "86")]
	public bool MJLLEOCCDKJ(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2882BC0", Offset = "0x2881FC0", VA = "0x182882BC0", Slot = "85")]
	public void KPFDLNKKCBC(KDLENLDMBAK LCODCOPGHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x2883200", Offset = "0x2882600", VA = "0x182883200", Slot = "43")]
	public bool NINDJMHMLHP(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x2881AF0", Offset = "0x2880EF0", VA = "0x182881AF0", Slot = "44")]
	public void JCLEKBOHOEE(KDLENLDMBAK LCODCOPGHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x2880E90", Offset = "0x2880290", VA = "0x182880E90", Slot = "45")]
	public bool HABCIFAFHLP(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x2880490", Offset = "0x287F890", VA = "0x182880490", Slot = "46")]
	public void EMPLLCLNICH(KDLENLDMBAK LCODCOPGHJA, bool KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x2882390", Offset = "0x2881790", VA = "0x182882390", Slot = "47")]
	public bool JHBDLEJMDML(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x2883800", Offset = "0x2882C00", VA = "0x182883800", Slot = "48")]
	public void PEMAJJBCNLH(KDLENLDMBAK LCODCOPGHJA, bool KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x2882B30", Offset = "0x2881F30", VA = "0x182882B30", Slot = "49")]
	public RigidbodyConstraints KNJGAOPOOLK(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(RigidbodyConstraints);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x28803F0", Offset = "0x287F7F0", VA = "0x1828803F0", Slot = "50")]
	public void ELKBALPBCDG(KDLENLDMBAK LCODCOPGHJA, RigidbodyConstraints KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x287F370", Offset = "0x287E770", VA = "0x18287F370", Slot = "51")]
	public float ALDJFBKMGIK(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x287FC90", Offset = "0x287F090", VA = "0x18287FC90", Slot = "52")]
	public void DHMMBIJIGCN(KDLENLDMBAK LCODCOPGHJA, float KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x287F230", Offset = "0x287E630", VA = "0x18287F230", Slot = "53")]
	public float AIEOHGNHJKI(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x2881610", Offset = "0x2880A10", VA = "0x182881610", Slot = "54")]
	public void IIDCOFDFJCO(KDLENLDMBAK LCODCOPGHJA, float KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x287F9D0", Offset = "0x287EDD0", VA = "0x18287F9D0", Slot = "55")]
	public bool BMLJEINJMMP(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x2880DE0", Offset = "0x28801E0", VA = "0x182880DE0", Slot = "56")]
	public void GOEPHFBLEIO(KDLENLDMBAK LCODCOPGHJA, bool KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x28829F0", Offset = "0x2881DF0", VA = "0x1828829F0", Slot = "57")]
	public bool KICINIEFMJK(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x2883580", Offset = "0x2882980", VA = "0x182883580", Slot = "58")]
	public void OKKNADNHCHH(KDLENLDMBAK LCODCOPGHJA, bool KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x28816C0", Offset = "0x2880AC0", VA = "0x1828816C0", Slot = "59")]
	public void IIKMPPBGOKE(KDLENLDMBAK LCODCOPGHJA, int KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x287F410", Offset = "0x287E810", VA = "0x18287F410", Slot = "73")]
	public Rigidbody ALONCOMHLHI(KDLENLDMBAK LCODCOPGHJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x28838B0", Offset = "0x2882CB0", VA = "0x1828838B0", Slot = "74")]
	public void PMKAPGKELNJ(KDLENLDMBAK LCODCOPGHJA, Rigidbody KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x28809A0", Offset = "0x287FDA0", VA = "0x1828809A0", Slot = "75")]
	public void FOEDBBCKFAI(KDLENLDMBAK LCODCOPGHJA, object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x2880D20", Offset = "0x2880120", VA = "0x182880D20", Slot = "76")]
	public void GNGBJDCLCGN(KDLENLDMBAK LCODCOPGHJA, object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x2882C60", Offset = "0x2882060", VA = "0x182882C60", Slot = "77")]
	public bool LFALHCLOLNJ(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x2883410", Offset = "0x2882810", VA = "0x182883410", Slot = "60")]
	public object OGOBFKJIMLF(KDLENLDMBAK LCODCOPGHJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2882D10", Offset = "0x2882110", VA = "0x182882D10", Slot = "61")]
	public void LIAFBCOCMHD(KDLENLDMBAK LCODCOPGHJA, object KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x2881170", Offset = "0x2880570", VA = "0x182881170", Slot = "62")]
	public object HIKPELDOOCD(KDLENLDMBAK LCODCOPGHJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x287FEA0", Offset = "0x287F2A0", VA = "0x18287FEA0", Slot = "63")]
	public void DLNBIIBMBIB(KDLENLDMBAK LCODCOPGHJA, object KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x2881B90", Offset = "0x2880F90", VA = "0x182881B90", Slot = "64")]
	public float JCPNDJFNKJP(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x287F8D0", Offset = "0x287ECD0", VA = "0x18287F8D0", Slot = "65")]
	public void BHBJAIOINPH(KDLENLDMBAK LCODCOPGHJA, float KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x2883350", Offset = "0x2882750", VA = "0x182883350", Slot = "69")]
	public void OAJFCJHCBKL(KDLENLDMBAK LCODCOPGHJA, object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x2883290", Offset = "0x2882690", VA = "0x182883290", Slot = "70")]
	public void NNNDLBAIMJN(KDLENLDMBAK LCODCOPGHJA, object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x2880540", Offset = "0x287F940", VA = "0x182880540", Slot = "71")]
	public bool EOGCOOLDAAF(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x28834E0", Offset = "0x28828E0", VA = "0x1828834E0", Slot = "21")]
	public void OIPPDNGMOPI(KDLENLDMBAK LCODCOPGHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x2881240", Offset = "0x2880640", VA = "0x182881240", Slot = "22")]
	public void HKOKHONODBB(KDLENLDMBAK LCODCOPGHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x28818E0", Offset = "0x2880CE0", VA = "0x1828818E0", Slot = "72")]
	public bool IPGOBKJCEOD(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x2880A60", Offset = "0x287FE60", VA = "0x182880A60", Slot = "78")]
	public void GGIBEBDBOBI(KDLENLDMBAK LCODCOPGHJA, float3 CPDGHJJAFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x287F560", Offset = "0x287E960", VA = "0x18287F560", Slot = "79")]
	public void BCPGILPBCMJ(KDLENLDMBAK LCODCOPGHJA, float3 HNJKKMCILJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x287F980", Offset = "0x287ED80", VA = "0x18287F980", Slot = "80")]
	public bool BHGMIDANAFH(KDLENLDMBAK LCODCOPGHJA, out float3 CPDGHJJAFAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x2882840", Offset = "0x2881C40", VA = "0x182882840", Slot = "81")]
	public bool KCJMGOOICDI(KDLENLDMBAK LCODCOPGHJA, out float3 HNJKKMCILJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x2882760", Offset = "0x2881B60", VA = "0x182882760")]
	private DynamicBuffer<Entity> KCCFIMIKBII(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(DynamicBuffer<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x2883060", Offset = "0x2882460", VA = "0x182883060")]
	private DynamicBuffer<Entity> NHHKKJKHNCO(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(DynamicBuffer<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x1818C30", Offset = "0x1818030", VA = "0x181818C30")]
	private void MOGEFPAHAKG<T>(KDLENLDMBAK LCODCOPGHJA, object KKIAKNLLHIO, Func<object, T> AGEGEMBGALM) where T : class, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public IHDIFFAKHOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[UnityEngine.Scripting.Preserve]
internal sealed class KACNHJGELIH<T> : JKIEMPJPHGI where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private EntityQuery PNGFJEAJDGO;

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x2102B60", Offset = "0x2101F60", VA = "0x182102B60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x2102C80", Offset = "0x2102080", VA = "0x182102C80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x2102CF0", Offset = "0x21020F0", VA = "0x182102CF0")]
	public KACNHJGELIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[EFDJEPLIMOC(typeof(EDAGPFPPFFG), new string[] { })]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
internal sealed class EDAGPFPPFFG : OOLEGKACHHE, DEPDOFHIDBA, AKFIPDJCCOH, CBKELFDIEEL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ONGFANECMJO]
	private PFJMBDHJHAN BDLCNPMEDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private EntityQuery CJMLLNLKCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private EntityQuery CCFLGCJHBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private EntityQuery OOMBFIEIHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private EntityQuery OCLMEBEHBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private EntityQuery KCBPHCOPECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private EntityQuery CFHFOFJMDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private EntityQuery EBGMHKLKNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private bool MMLDFGNKLLJ;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private EntityManager FCLKPLIBOOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x28C43A0", Offset = "0x28C37A0", VA = "0x1828C43A0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EntityQuery KIGJPFMJHCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1019C20", Offset = "0x1019020", VA = "0x181019C20")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "4")]
	public void MCOOCEGHCPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x28C3D80", Offset = "0x28C3180", VA = "0x1828C3D80", Slot = "5")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x28C3DD0", Offset = "0x28C31D0", VA = "0x1828C3DD0", Slot = "6")]
	public void JFCLKDMBJND(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x28C3D20", Offset = "0x28C3120", VA = "0x1828C3D20")]
	private EntityQueryDesc HNIAFKMGLHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x28C3CB0", Offset = "0x28C30B0", VA = "0x1828C3CB0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x28C3BE0", Offset = "0x28C2FE0", VA = "0x1828C3BE0")]
	public CJNBAFDACBF DODEMOFAKND(KDLENLDMBAK BGPCGOEKFEF)
	{
		return default(CJNBAFDACBF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x28C42F0", Offset = "0x28C36F0", VA = "0x1828C42F0")]
	public LENINMGJJHF KKPCNJHFKAF(Entity FKNFFDFGNMN)
	{
		return default(LENINMGJJHF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x28C43F0", Offset = "0x28C37F0", VA = "0x1828C43F0")]
	public EDAGPFPPFFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class AEEHMMHKAIE
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[LOJHKAHIJPC(typeof(EGBJFBCNELH))]
[EFDJEPLIMOC(typeof(BPJPLKILODH), new string[] { })]
internal class EGBJFBCNELH : BPJPLKILODH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<LILHPPGJGND> MNHHKLGLJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<LILHPPGJGND> EJLGGPGEDNF;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action NBGGPFMKNJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x28C65B0", Offset = "0x28C59B0", VA = "0x1828C65B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x28C6650", Offset = "0x28C5A50", VA = "0x1828C6650", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action KNAAOKMKOEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x28C68D0", Offset = "0x28C5CD0", VA = "0x1828C68D0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x28C6970", Offset = "0x28C5D70", VA = "0x1828C6970", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action OMPBBHFMBEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x28C67E0", Offset = "0x28C5BE0", VA = "0x1828C67E0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x28C6740", Offset = "0x28C5B40", VA = "0x1828C6740", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0xA27170", Offset = "0xA26570", VA = "0x180A27170")]
	public void EEEFMKMBIOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0xC220E0", Offset = "0xC214E0", VA = "0x180C220E0")]
	public void KPCNBEODGDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0xF27B80", Offset = "0xF26F80", VA = "0x180F27B80")]
	public void HJGJCLFCFDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x28C6880", Offset = "0x28C5C80", VA = "0x1828C6880")]
	public void HODLNLHBNME(LILHPPGJGND NFIBHFKKFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x28C66F0", Offset = "0x28C5AF0", VA = "0x1828C66F0")]
	public void FGPCDNGJIAD(LILHPPGJGND NFIBHFKKFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public EGBJFBCNELH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[HONNCCIFPDK(CAGOEBHGGNL.OMRoom)]
internal class IIOMJJFBBCH : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private EGBDNLKFOBI IPBNMJJAIHM;

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x2883CB0", Offset = "0x28830B0", VA = "0x182883CB0", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x2883D00", Offset = "0x2883100", VA = "0x182883D00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public IIOMJJFBBCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class FNKNBDEPOJP
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class OJICDKPKOGA
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private sealed class <<CalculateTransformPath>g__getNames|0>d
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public OJICDKPKOGA()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[Flags]
public enum ECMNFJLFBIC
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	Main = 2,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	Load = 4,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	NetworkReceive = 8,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	Suppressed = 0x10
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
[EFDJEPLIMOC(typeof(IPJCHCHPAMO), new string[] { "Editor" })]
public sealed class IPJCHCHPAMO
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate void CBIIADAOAPB(CMFFIMLEPBE AIOICCOKGOP, EFFOMHNHCBO KJFNAECAHBA, ECMNFJLFBIC NNGHEIFAPDC);

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public delegate void DPBAAKHHIFH(CMFFIMLEPBE AIOICCOKGOP, ECMNFJLFBIC NNGHEIFAPDC);

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate void MBMHOKBBFOB(CMFFIMLEPBE AIOICCOKGOP, GLFLLKHPAHK HNNIGEFAIIM, NBOENLAPDFO LCEOCHLKMEN, NBOENLAPDFO OIKAFLDALHD, ECMNFJLFBIC NNGHEIFAPDC);

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public delegate void AFNJJLOIOLN(EBBOOPFABOA KOFPKIJDAMC, ReadOnlySpan<byte> KBLLMJIHKAK);

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public IPJCHCHPAMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal class LDKAAJNGHGH : HLOJAODEAAM
{
	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x2899970", Offset = "0x2898D70", VA = "0x182899970", Slot = "15")]
	protected override ComponentSystemBase BHJHPJOJPMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x2229A50", Offset = "0x2228E50", VA = "0x182229A50")]
	public LDKAAJNGHGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[EFDJEPLIMOC(typeof(GIAAALCEHCB), new string[] { })]
public class LAMFGFAKCMM : GIAAALCEHCB, AKFIPDJCCOH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[ONGFANECMJO]
	private AOONNPAOEFB POKBDJCFNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[ONGFANECMJO]
	private KKJECAIDLGC NPOFINHBGBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly List<NativeListAsync<Entity>> MEHPHMAJOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<(NativeListAsync<Entity>, bool)> CIDGIPOACLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private OCKLHPIJMNK GILHECFPBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Dictionary<Entity, FAAACEJLHBB> HNPOONDGAFK;

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x2899490", Offset = "0x2898890", VA = "0x182899490", Slot = "8")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x2899420", Offset = "0x2898820", VA = "0x182899420", Slot = "4")]
	public void HNPEMLPKEOI(NativeListAsync<Entity> PGJLMFPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x2899790", Offset = "0x2898B90", VA = "0x182899790", Slot = "5")]
	public void PAKCGAECLBI(OCKLHPIJMNK GILHECFPBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x2898AC0", Offset = "0x2897EC0", VA = "0x182898AC0", Slot = "6")]
	public void EIHAMNDAKFL(NativeListAsync<Entity> PGJLMFPAKDA, bool NIEDLIODGPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x2898BA0", Offset = "0x2897FA0", VA = "0x182898BA0", Slot = "7")]
	public void ELCPLOFAOMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x2898630", Offset = "0x2897A30", VA = "0x182898630", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x28991C0", Offset = "0x28985C0", VA = "0x1828991C0")]
	private int HNKNBJEFMNN(NativeListAsync<Entity> MEHPHMAJOHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x2898F20", Offset = "0x2898320", VA = "0x182898F20")]
	private int HKEPNAPAKDJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x2899500", Offset = "0x2898900", VA = "0x182899500")]
	private int KFJFKAAJKAN(NativeListAsync<Entity> CIDGIPOACLG, bool LGACBDBKOHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x2899870", Offset = "0x2898C70", VA = "0x182899870")]
	public LAMFGFAKCMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x2899740", Offset = "0x2898B40", VA = "0x182899740")]
	[CompilerGenerated]
	private KDLENLDMBAK KKEBPDLEOEC(Entity FKNFFDFGNMN)
	{
		return default(KDLENLDMBAK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
[EFDJEPLIMOC(typeof(DIOBGNHCMAF), new string[] { })]
public class DIOBGNHCMAF
{
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private bool GDHKPCGLKJL;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool EHMEEIIOBGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xA2ED20", Offset = "0xA2E120", VA = "0x180A2ED20")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x25230E0", Offset = "0x25224E0", VA = "0x1825230E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public DIOBGNHCMAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal abstract class KGEHHGMJDBH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private uint BFANPFMNMNI;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public abstract uint LJLKJAPGJNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x28925D0", Offset = "0x28919D0", VA = "0x1828925D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x28925F0", Offset = "0x28919F0", VA = "0x1828925F0")]
	public CMFFIMLEPBE KHJEDKBAGNM()
	{
		return default(CMFFIMLEPBE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x2892730", Offset = "0x2891B30", VA = "0x182892730")]
	public void MFPPPOFGICL(NativeArray<CMFFIMLEPBE> MAEMAKOHEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x28927A0", Offset = "0x2891BA0", VA = "0x1828927A0")]
	public void MFPPPOFGICL(CMFFIMLEPBE AIOICCOKGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0xB7AC60", Offset = "0xB7A060", VA = "0x180B7AC60", Slot = "6")]
	public virtual void FJKIFKDAPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x2892530", Offset = "0x2891930", VA = "0x182892530")]
	private unsafe void CNCAAOMCBJN(CMFFIMLEPBE* OJEHIPCHIOL, int ECOAGJBCGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x2892640", Offset = "0x2891A40", VA = "0x182892640")]
	private unsafe void MFPPPOFGICL(CMFFIMLEPBE* OJEHIPCHIOL, int ECOAGJBCGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0xFC7A90", Offset = "0xFC6E90", VA = "0x180FC7A90")]
	protected KGEHHGMJDBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
[EFDJEPLIMOC(typeof(CLBEKBFHODM), new string[] { })]
internal sealed class CLBEKBFHODM : KGEHHGMJDBH, AKFIPDJCCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[ONGFANECMJO]
	private KBLGMDKDIMA FBCPJLHEMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private uint ELEHMFAPFEI;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public override uint LJLKJAPGJNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA71600", Offset = "0xA70A00", VA = "0x180A71600", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x251CA30", Offset = "0x251BE30", VA = "0x18251CA30", Slot = "7")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x251CAC0", Offset = "0x251BEC0", VA = "0x18251CAC0")]
	private void KJJLJEGAKIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x251C9D0", Offset = "0x251BDD0", VA = "0x18251C9D0", Slot = "6")]
	public override void FJKIFKDAPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x251CB10", Offset = "0x251BF10", VA = "0x18251CB10")]
	public CLBEKBFHODM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[EFDJEPLIMOC(typeof(NDOILFJJPKF), new string[] { })]
[JOCOBGMDOKK(CAGOEBHGGNL.LoadInstance)]
internal sealed class NDOILFJJPKF : AKFIPDJCCOH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	[ONGFANECMJO]
	private OCIGMOAGHIJ FBCPJLHEMAI;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x2A6DAB0", Offset = "0x2A6CEB0", VA = "0x182A6DAB0", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x2A6DA60", Offset = "0x2A6CE60", VA = "0x182A6DA60", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public NDOILFJJPKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[EFDJEPLIMOC(typeof(JKKLNKDPKBJ), new string[] { })]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
public class JKKLNKDPKBJ : FDGKLMNACMK, OOLEGKACHHE, DEPDOFHIDBA, AKFIPDJCCOH, CBKELFDIEEL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class AIGFMCNOJAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public EMFBCBAOENA services;

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public AIGFMCNOJAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x2707F80", Offset = "0x2707380", VA = "0x182707F80")]
		internal void JGNOMBCIFOD(AKFIPDJCCOH svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class NNAIGDCFLFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public EMFBCBAOENA services;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public NNAIGDCFLFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x2715AC0", Offset = "0x2714EC0", VA = "0x182715AC0")]
		internal void EBBCADKFHEI(CBKELFDIEEL svc)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[ONGFANECMJO]
	private PFJMBDHJHAN GKACEDOEIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[ONGFANECMJO]
	private FMHENAEHCJH NACHIPPFPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[ONGFANECMJO]
	private ANLJAEDMKMC KLBBCPHGEPH;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public AIDFLENHCFG MBAGIEMANEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xB977F0", Offset = "0xB96BF0", VA = "0x180B977F0", Slot = "4")]
		get
		{
			return default(AIDFLENHCFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x288E2F0", Offset = "0x288D6F0", VA = "0x18288E2F0", Slot = "5")]
	public void BDMFHPOGKDD(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x288E670", Offset = "0x288DA70", VA = "0x18288E670", Slot = "6")]
	public void MCOOCEGHCPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x288E4B0", Offset = "0x288D8B0", VA = "0x18288E4B0", Slot = "7")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x288E590", Offset = "0x288D990", VA = "0x18288E590", Slot = "8")]
	public void JFCLKDMBJND(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x288E380", Offset = "0x288D780", VA = "0x18288E380", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x2024330", Offset = "0x2023730", VA = "0x182024330")]
	private void PKOIILEIBOI<T>(Action<T> GHCMDIKIHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public JKKLNKDPKBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[EFDJEPLIMOC(typeof(JCNEDKKCDCA), new string[] { })]
public sealed class BDFHGDFAENO : JCNEDKKCDCA, OOLEGKACHHE, DEPDOFHIDBA, AKFIPDJCCOH, CBKELFDIEEL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class DFNPAHCIOLM : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private (string path, string token) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private string groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public string <>3__groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public BDFHGDFAENO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private string[] <tokens>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private StringBuilder <path>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private string <token>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		private (string, string) System.Collections.Generic.IEnumerator<(System.Stringpath,System.Stringtoken)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0xA38A80", Offset = "0xA37E80", VA = "0x180A38A80", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((string, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x2709CE0", Offset = "0x27090E0", VA = "0x182709CE0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x2709D30", Offset = "0x2709130", VA = "0x182709D30")]
		[DebuggerHidden]
		public DFNPAHCIOLM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x27099A0", Offset = "0x2708DA0", VA = "0x1827099A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x2709CA0", Offset = "0x27090A0", VA = "0x182709CA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x2709BF0", Offset = "0x2708FF0", VA = "0x182709BF0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x2709BF0", Offset = "0x2708FF0", VA = "0x182709BF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[ONGFANECMJO]
	private KHCHBOKCLCH NFDNHCCMBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly PKDDPLFKGBL GJCJBMKNAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly Dictionary<string, CKKLELCKANA> PJMHALLPMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly Dictionary<int, EKFCEBIIGNK> APBCDEOINDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly List<LJHGDPGPANM> HDBHPGAFPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private CEJCPOECKAC CJDOLIICMHE;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public EKFCEBIIGNK HELJEIPNKAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x2511E40", Offset = "0x2511240", VA = "0x182511E40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public List<LJHGDPGPANM> CMOINNDNKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x8BC350", Offset = "0x8BB750", VA = "0x1808BC350", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "9")]
	public void MCOOCEGHCPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x2512010", Offset = "0x2511410", VA = "0x182512010", Slot = "10")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x2512070", Offset = "0x2511470", VA = "0x182512070", Slot = "11")]
	public void JFCLKDMBJND(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2511800", Offset = "0x2510C00", VA = "0x182511800", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2511EA0", Offset = "0x25112A0", VA = "0x182511EA0", Slot = "6")]
	public bool HCIICAGPEIN(LJHGDPGPANM HNNIGEFAIIM, out EKFCEBIIGNK IBAIAINEMLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x2511AB0", Offset = "0x2510EB0", VA = "0x182511AB0")]
	private void GJKGNFIHCMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x25126A0", Offset = "0x2511AA0", VA = "0x1825126A0")]
	private void PFJPPNMGDEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x25117A0", Offset = "0x2510BA0", VA = "0x1825117A0")]
	private CKKLELCKANA DLJDLLJDDLA(string GGGCDLHJPMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x2511E40", Offset = "0x2511240", VA = "0x182511E40")]
	private CKKLELCKANA HKDOKOLGJHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x2512180", Offset = "0x2511580", VA = "0x182512180")]
	private CKKLELCKANA LNCAKGJBDJH(string GGGCDLHJPMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x25124D0", Offset = "0x25118D0", VA = "0x1825124D0")]
	private CKKLELCKANA OBBCFGIJFKO(string EKHKAHMLNOP, string GAOLOMEJCOK, [Optional] CKKLELCKANA CCKKMJOKCII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x25123F0", Offset = "0x25117F0", VA = "0x1825123F0")]
	[IteratorStateMachine(typeof(DFNPAHCIOLM))]
	private IEnumerable<(string, string)> NILJPKPEFKC(string GGGCDLHJPMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x2511FC0", Offset = "0x25113C0", VA = "0x182511FC0")]
	private bool IILLFEGIBEK(LJHGDPGPANM HNNIGEFAIIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x25116C0", Offset = "0x2510AC0", VA = "0x1825116C0")]
	private PKDDPLFKGBL CKDHDCDLKHI(LJHGDPGPANM HNNIGEFAIIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x2512480", Offset = "0x2511880", VA = "0x182512480")]
	private PKDDPLFKGBL NOKIIKJGGFE(LJHGDPGPANM HNNIGEFAIIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x2511970", Offset = "0x2510D70", VA = "0x182511970")]
	private PKDDPLFKGBL FDDIHILIGAF(LJHGDPGPANM HNNIGEFAIIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x143B130", Offset = "0x143A530", VA = "0x18143B130")]
	private T IHKBILIPDJC<T>(LJHGDPGPANM HNNIGEFAIIM) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x2511890", Offset = "0x2510C90", VA = "0x182511890")]
	private FieldInfo EMDJJAHFDPJ(LJHGDPGPANM HNNIGEFAIIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x2511A00", Offset = "0x2510E00", VA = "0x182511A00", Slot = "7")]
	public void FIMKNKKCEGK(LJHGDPGPANM HNNIGEFAIIM, NPBEDHNLGJD HOOGECPFBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x25120D0", Offset = "0x25114D0", VA = "0x1825120D0", Slot = "8")]
	public void JOMNAIGJLOO(LJHGDPGPANM HNNIGEFAIIM, NPBEDHNLGJD HOOGECPFBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x2512840", Offset = "0x2511C40", VA = "0x182512840")]
	public BDFHGDFAENO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x2511F30", Offset = "0x2511330", VA = "0x182511F30")]
	[CompilerGenerated]
	private int HDHFELPGKNK(LJHGDPGPANM EJOFMGLMADH, LJHGDPGPANM CMACFBOCONA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class ONIKEOOJBBB
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class LEFCJOJIPAF
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class AOAMGNDLFIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2510330", Offset = "0x250F730", VA = "0x182510330")]
	public static void DGNDNHBKLFE(PILIJFIMAJF FDJKGAAPBBG, string FJBDLPFLPPA, KDLENLDMBAK BDNFNCMKEFH, Action AGEGEMBGALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x2510590", Offset = "0x250F990", VA = "0x182510590")]
	public static void DGNDNHBKLFE(PILIJFIMAJF FDJKGAAPBBG, string FJBDLPFLPPA, PPACDBGDBCI GJFPKLMKEOA, Action AGEGEMBGALM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[EFDJEPLIMOC(typeof(LEECIPHPBNO), new string[] { })]
public class HJOMGIMILJA : AKFIPDJCCOH, LEECIPHPBNO
{
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private EntityManager GLPCEPPDPLB;

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x287B1B0", Offset = "0x287A5B0", VA = "0x18287B1B0", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x287B2A0", Offset = "0x287A6A0", VA = "0x18287B2A0", Slot = "5")]
	public void LDGLMGBHCME(KDLENLDMBAK BGPCGOEKFEF, bool KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x287B230", Offset = "0x287A630", VA = "0x18287B230", Slot = "6")]
	public void KMODDNBHENJ(KDLENLDMBAK BGPCGOEKFEF, bool KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x287B0E0", Offset = "0x287A4E0", VA = "0x18287B0E0", Slot = "7")]
	public void ICPMDBABKPK(KDLENLDMBAK BGPCGOEKFEF, int KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x1811B20", Offset = "0x1810F20", VA = "0x181811B20")]
	private void DADPJLGDIHI<T>(KDLENLDMBAK BGPCGOEKFEF, bool KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x1811A70", Offset = "0x1810E70", VA = "0x181811A70")]
	private void DADPJLGDIHI<T>(KDLENLDMBAK BGPCGOEKFEF, T KJFNAECAHBA) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public HJOMGIMILJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[JOCOBGMDOKK(CAGOEBHGGNL.LoadInstance)]
[EFDJEPLIMOC(typeof(MNMMEIHENAM), new string[] { })]
public sealed class MNMMEIHENAM : AKFIPDJCCOH, CBKELFDIEEL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class DNBDBALEJDC : IEnumerable<RRCustomPropTag>, IEnumerable, IEnumerator<RRCustomPropTag>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private RRCustomPropTag <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public MNMMEIHENAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private List<RRCustomPropTag> <list>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private Scene <scene>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private GameObject[] <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private int <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private GameObject <root>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private List<RRCustomPropTag>.Enumerator <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private RRCustomPropTag <tag>5__8;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		RRCustomPropTag IEnumerator<RRCustomPropTag>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xB48080", Offset = "0xB47480", VA = "0x180B48080")]
		[DebuggerHidden]
		public DNBDBALEJDC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x3DE6050", Offset = "0x3DE5450", VA = "0x183DE6050", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x3DE5C30", Offset = "0x3DE5030", VA = "0x183DE5C30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x3DE5BE0", Offset = "0x3DE4FE0", VA = "0x183DE5BE0")]
		private void MIMEIPDHABP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x3DE6010", Offset = "0x3DE5410", VA = "0x183DE6010", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x3DE5F70", Offset = "0x3DE5370", VA = "0x183DE5F70", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x3DE5F70", Offset = "0x3DE5370", VA = "0x183DE5F70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Dictionary<SerializableGuid, KKHDEPBDMGH> ENEJCOPIKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly List<SerializableGuid> CPJPMOMGBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly Dictionary<SerializableGuid, GameObject> EDNPFADAINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private AOONNPAOEFB FHJACJEANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private KHCHBOKCLCH NFDNHCCMBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private NIOKIOAHGMB FBCPJLHEMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private BPJPLKILODH PJDNDHAAPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private ANLJAEDMKMC KLBBCPHGEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private AOJLADIGKFN<KKHDEPBDMGH> BBCCHOEAGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private GameObject PGGHAEPBJAC;

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x2A6BE90", Offset = "0x2A6B290", VA = "0x182A6BE90", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x2A6BF60", Offset = "0x2A6B360", VA = "0x182A6BF60", Slot = "5")]
	public void JFCLKDMBJND(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x2A6B620", Offset = "0x2A6AA20", VA = "0x182A6B620", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x2A6B7C0", Offset = "0x2A6ABC0", VA = "0x182A6B7C0")]
	private void EGKDIKALHBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x2A6C2D0", Offset = "0x2A6B6D0", VA = "0x182A6C2D0")]
	internal void OIHJDMPLCPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x2A6C0F0", Offset = "0x2A6B4F0", VA = "0x182A6C0F0")]
	private void KMMHMDPLDKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x2A6C760", Offset = "0x2A6BB60", VA = "0x182A6C760")]
	private void PMAIEDMMFJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x2A6B5B0", Offset = "0x2A6A9B0", VA = "0x182A6B5B0")]
	[IteratorStateMachine(typeof(DNBDBALEJDC))]
	private IEnumerable<RRCustomPropTag> CFPMINBGNKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x2A6B0F0", Offset = "0x2A6A4F0", VA = "0x182A6B0F0")]
	private void AOEAAOAOLFA(KDLENLDMBAK LCODCOPGHJA, in NBOENLAPDFO PHNODIMLADH, in NBOENLAPDFO NDKKBDCFLEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x2A6B9A0", Offset = "0x2A6ADA0", VA = "0x182A6B9A0")]
	private void FIMKNKKCEGK(SerializableGuid EBABBHGKMJL, GameObject GACFHLOJJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x2A6BAE0", Offset = "0x2A6AEE0", VA = "0x182A6BAE0")]
	private void FMOCHLJGAIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x2A6B7D0", Offset = "0x2A6ABD0", VA = "0x182A6B7D0")]
	private bool FDCMLNOAFJJ(KKHDEPBDMGH EGBCBLDCFOA, Transform ILDFJHMNOPJ, out GameObject PFLHMFKPPJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x2A6C710", Offset = "0x2A6BB10", VA = "0x182A6C710")]
	public void PEHJALIONDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x2A6C8F0", Offset = "0x2A6BCF0", VA = "0x182A6C8F0")]
	public MNMMEIHENAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[DefaultMember("Item")]
[EFDJEPLIMOC(typeof(KHCHBOKCLCH), new string[] { })]
public class KFMDCDOHIPJ : KHCHBOKCLCH, IEnumerable<LJHGDPGPANM>, IEnumerable, AKFIPDJCCOH, CBKELFDIEEL, KFBFMDMFJDA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[ONGFANECMJO]
	private AOONNPAOEFB FHJACJEANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[ONGFANECMJO]
	private JKPBDEIBINB DJGFELMBIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private LJHGDPGPANM[] NHOMCGEOKNF;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int NPBPHODFKMP
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x28924E0", Offset = "0x28918E0", VA = "0x1828924E0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public LJHGDPGPANM OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x2891D90", Offset = "0x2891190", VA = "0x182891D90", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x2892220", Offset = "0x2891620", VA = "0x182892220", Slot = "10")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x2892290", Offset = "0x2891690", VA = "0x182892290", Slot = "11")]
	public void JFCLKDMBJND(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x2892020", Offset = "0x2891420", VA = "0x182892020")]
	private LJHGDPGPANM ILENKPCJIEF(int NANJAGEOPJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x2892100", Offset = "0x2891500", VA = "0x182892100", Slot = "6")]
	public LJHGDPGPANM IMOMPCNDOJA(NNHEPJDBKBI KKIJPENOLBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x2891E40", Offset = "0x2891240", VA = "0x182891E40", Slot = "7")]
	public GLFLLKHPAHK ELFFHKHOAAN(NNHEPJDBKBI KKIJPENOLBP)
	{
		return default(GLFLLKHPAHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x2891F10", Offset = "0x2891310", VA = "0x182891F10", Slot = "8")]
	public IEnumerator<LJHGDPGPANM> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x2891F10", Offset = "0x2891310", VA = "0x182891F10", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x228CE60", Offset = "0x228C260", VA = "0x18228CE60", Slot = "12")]
	public void LNAMDFAOIPA<TKey, T>(MHOBFBAOGME<TKey, T> HNNIGEFAIIM, [Optional] object JNNDIHFHMHC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x2891DA0", Offset = "0x28911A0", VA = "0x182891DA0", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public KFMDCDOHIPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x2891D90", Offset = "0x2891190", VA = "0x182891D90")]
	[CompilerGenerated]
	private LJHGDPGPANM JECPOKKGOAG(int GNPGECNAJNK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[UnityEngine.Scripting.Preserve]
internal class OGGHLHJCHCC : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private EntityQuery FFGGADDKMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private AOONNPAOEFB FHJACJEANIP;

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x2A74290", Offset = "0x2A73690", VA = "0x182A74290", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x2A742E0", Offset = "0x2A736E0", VA = "0x182A742E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x2A74370", Offset = "0x2A73770", VA = "0x182A74370", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public OGGHLHJCHCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[DefaultMember("Item")]
public class NDNFBMDHDJB<From, To> where From : struct, IEquatable<From>
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
[EFDJEPLIMOC(typeof(BAPPNLJJFJJ), new string[] { })]
public class BAPPNLJJFJJ : AKFIPDJCCOH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	[ONGFANECMJO]
	private NLLKOIOEBHH JJBMHHKCDGP;

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x2511030", Offset = "0x2510430", VA = "0x182511030", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x2511010", Offset = "0x2510410", VA = "0x182511010", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public BAPPNLJJFJJ()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class DisembodiedObjectView : MonoBehaviour, KNAEKBFOOHL
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool MADHFPDLGFA
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x7FFD60", Offset = "0x7FF160", VA = "0x1807FFD60", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public KDLENLDMBAK KEENOEKFOKI
		{
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x10732F0", Offset = "0x10726F0", VA = "0x1810732F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(KDLENLDMBAK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x1073310", Offset = "0x1072710", VA = "0x181073310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x28C37A0", Offset = "0x28C2BA0", VA = "0x1828C37A0")]
		public void SetName(string DKPHPKDPBCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8CEA50", Offset = "0x8CDE50", VA = "0x1808CEA50")]
		public DisembodiedObjectView()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class AEHHPPCGKGA
{
	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x250D1E0", Offset = "0x250C5E0", VA = "0x18250D1E0")]
	public static void POLDDJGGEOE(ComponentSystemBase JJBAHIPIPHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[EFDJEPLIMOC(typeof(LAEBFAHMGJG), new string[] { })]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
internal sealed class LAEBFAHMGJG : KGEHHGMJDBH
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public override uint LJLKJAPGJNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x7F35A0", Offset = "0x7F29A0", VA = "0x1807F35A0", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0xFC7A90", Offset = "0xFC6E90", VA = "0x180FC7A90")]
	public LAEBFAHMGJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class JFPDHNGHIML
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class BKFNNBLOMPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public EMFBCBAOENA services;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public BKFNNBLOMPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x2708B00", Offset = "0x2707F00", VA = "0x182708B00")]
		internal void OHFJKEJFIAN(AKFIPDJCCOH svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x2708AA0", Offset = "0x2707EA0", VA = "0x182708AA0")]
		internal void COKKLCNEMHA(CBKELFDIEEL svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x288A540", Offset = "0x2889940", VA = "0x18288A540")]
	public static void EBLHBMCKHPL(this World BDLCNPMEDLI, EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0xBC7240", Offset = "0xBC6640", VA = "0x180BC7240")]
	public static void KLFBHCOBFIL<T>(this World BDLCNPMEDLI, Action<T> GHCMDIKIHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x201A8D0", Offset = "0x2019CD0", VA = "0x18201A8D0")]
	public static void AMLKMEIPGIM<T>(this World BDLCNPMEDLI, Action<T> GHCMDIKIHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x201AB20", Offset = "0x2019F20", VA = "0x18201AB20")]
	public static void AMLKMEIPGIM<T>(IEnumerable<ComponentSystemBase> OEBMDJNIHNJ, Action<T> GHCMDIKIHJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[EFDJEPLIMOC(typeof(AJMPOCCEJIG), new string[] { })]
internal class IMECHNJLEKM : AJMPOCCEJIG, AKFIPDJCCOH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private enum Flag
	{
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		Allowed,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		Clone,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		Copy,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		Undo,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		UndoCreation,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		Physics,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		SerializationV4,
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		HierarchyViewVisible
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class ININCAJODGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public ININCAJODGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x2711430", Offset = "0x2710830", VA = "0x182711430")]
		internal object KIAGBNJBIEL((string name, bool value) a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[ONGFANECMJO]
	private LJKNMEOKCJF FBCPJLHEMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[ONGFANECMJO]
	private GFGEKEKINCH GDHKPCGLKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private NativeBitArray CMCLOPFEMNP;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public DDKNJPLJEMG HCCILABALFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x2886560", Offset = "0x2885960", VA = "0x182886560", Slot = "4")]
		get
		{
			return default(DDKNJPLJEMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public DDKNJPLJEMG KNFLIILNBJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x2886980", Offset = "0x2885D80", VA = "0x182886980", Slot = "5")]
		get
		{
			return default(DDKNJPLJEMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public DDKNJPLJEMG DGCDPJOAHEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x28867B0", Offset = "0x2885BB0", VA = "0x1828867B0", Slot = "6")]
		get
		{
			return default(DDKNJPLJEMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public DDKNJPLJEMG EBMIPOGEBNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x2886970", Offset = "0x2885D70", VA = "0x182886970", Slot = "7")]
		get
		{
			return default(DDKNJPLJEMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public DDKNJPLJEMG ODGLNDCHDMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x2886990", Offset = "0x2885D90", VA = "0x182886990", Slot = "8")]
		get
		{
			return default(DDKNJPLJEMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DDKNJPLJEMG LLNIBAPEILO
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x2886640", Offset = "0x2885A40", VA = "0x182886640", Slot = "9")]
		get
		{
			return default(DDKNJPLJEMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DDKNJPLJEMG AACPEKPIMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x2886580", Offset = "0x2885980", VA = "0x182886580", Slot = "10")]
		get
		{
			return default(DDKNJPLJEMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DDKNJPLJEMG NIGNEOOFOKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x28867E0", Offset = "0x2885BE0", VA = "0x1828867E0", Slot = "11")]
		get
		{
			return default(DDKNJPLJEMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private int DCALGOPMAEB
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x28867F0", Offset = "0x2885BF0", VA = "0x1828867F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x2886650", Offset = "0x2885A50", VA = "0x182886650", Slot = "12")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x2886590", Offset = "0x2885990", VA = "0x182886590", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x2886920", Offset = "0x2885D20", VA = "0x182886920")]
	private void MDCNPKJODBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x28869A0", Offset = "0x2885DA0", VA = "0x1828869A0")]
	private void PHCHECAHHLN(Flag HJFEJJMKLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x28868A0", Offset = "0x2885CA0", VA = "0x1828868A0")]
	private DDKNJPLJEMG KJJPPCOGEND(Flag HJFEJJMKLEL)
	{
		return default(DDKNJPLJEMG);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x28867C0", Offset = "0x2885BC0", VA = "0x1828867C0")]
	private DDKNJPLJEMG JOEGNHJNBGN(Flag HJFEJJMKLEL)
	{
		return default(DDKNJPLJEMG);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public IMECHNJLEKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[EFDJEPLIMOC(typeof(BKIGCJIBBEC), new string[] { })]
public class MPBNEPMOBIL : AKFIPDJCCOH, CBKELFDIEEL, BKIGCJIBBEC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private AOONNPAOEFB FHJACJEANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private IIKMCLIAKNK FEJKNPAOBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private PFJMBDHJHAN BDLCNPMEDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private CJNHILKEKFP IMMGGKGMOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private CEJCPOECKAC CJDOLIICMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private IDIBGBEDHIB MMLDANAKHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private int MHNDJLOEBBA;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool CHHFBBKAHGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x2A6D5D0", Offset = "0x2A6C9D0", VA = "0x182A6D5D0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public KDLENLDMBAK JGEMJAJAFAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x2A6D160", Offset = "0x2A6C560", VA = "0x182A6D160", Slot = "9")]
		get
		{
			return default(KDLENLDMBAK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x2A6CDE0", Offset = "0x2A6C1E0", VA = "0x182A6CDE0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public EFBPNECENII JADINPGHHLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x2A6D560", Offset = "0x2A6C960", VA = "0x182A6D560", Slot = "11")]
		get
		{
			return default(EFBPNECENII);
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x2A6CDE0", Offset = "0x2A6C1E0", VA = "0x182A6CDE0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private uint JCNOHLGLKDF
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x2A6D0B0", Offset = "0x2A6C4B0", VA = "0x182A6D0B0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event GEOHHBJAGFH AGEJNEJCHBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x2A6D9C0", Offset = "0x2A6CDC0", VA = "0x182A6D9C0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x2A6CD40", Offset = "0x2A6C140", VA = "0x182A6CD40", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x2A6D1D0", Offset = "0x2A6C5D0", VA = "0x182A6D1D0", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x2A6D3C0", Offset = "0x2A6C7C0", VA = "0x182A6D3C0", Slot = "5")]
	public void JFCLKDMBJND(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x2A6CFC0", Offset = "0x2A6C3C0", VA = "0x182A6CFC0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x2A6CA10", Offset = "0x2A6BE10", VA = "0x182A6CA10")]
	private void APKKMBOEEJI(NPCCBNHIEEP KJFNAECAHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x2A6D2A0", Offset = "0x2A6C6A0", VA = "0x182A6D2A0", Slot = "13")]
	public KDLENLDMBAK JDMHPFIMIIA(KDLENLDMBAK GDNOLIODDHJ, KDLENLDMBAK NNMGPKBMOKD)
	{
		return default(KDLENLDMBAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x2A6D620", Offset = "0x2A6CA20", VA = "0x182A6D620", Slot = "14")]
	public bool NECHJOFNONE(KDLENLDMBAK GDNOLIODDHJ, KDLENLDMBAK NNMGPKBMOKD, out KDLENLDMBAK DCAFPIJMBKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x2A6D850", Offset = "0x2A6CC50", VA = "0x182A6D850", Slot = "15")]
	public void PDLPFGIDGID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x2A6D1A0", Offset = "0x2A6C5A0", VA = "0x182A6D1A0", Slot = "16")]
	public void GEKJMNCIDDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x2A6CE10", Offset = "0x2A6C210", VA = "0x182A6CE10", Slot = "17")]
	public bool CHBFJLENKOF(KDLENLDMBAK GDNOLIODDHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x2A6D730", Offset = "0x2A6CB30", VA = "0x182A6D730")]
	private void OLMFEIGKANI(KDLENLDMBAK ADCBJCIFHLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public MPBNEPMOBIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
[EFDJEPLIMOC(typeof(DAPPLPNBBCK), new string[] { })]
internal class DAPPLPNBBCK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	public void EEPPPMEIEHE(string DKPHPKDPBCM, EntityManager GLPCEPPDPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public DAPPLPNBBCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class ACJABBJBKEA
{
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x250CEB0", Offset = "0x250C2B0", VA = "0x18250CEB0")]
	public static bool IPNNEBJCOGI(CJHAGIKCJCL ECLLGFEOHLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x250CC70", Offset = "0x250C070", VA = "0x18250CC70")]
	public static CJHAGIKCJCL FIMKNKKCEGK(GameObject GACFHLOJJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x250CA90", Offset = "0x250BE90", VA = "0x18250CA90")]
	public static CJHAGIKCJCL FIMKNKKCEGK(GameObject GACFHLOJJGF, CMFFIMLEPBE AIOICCOKGOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x250CF60", Offset = "0x250C360", VA = "0x18250CF60")]
	public static bool OMKKFIBENOP(GameObject BKJBFAHBGJH, string EODCFKJDCMD, bool IAJCCPJOOCE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal readonly struct ABPMPKFPHAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly ComponentSystemBase JJBAHIPIPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly ProfilerMarker EFGOHNJJAOH;

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x250C910", Offset = "0x250BD10", VA = "0x18250C910")]
	public ABPMPKFPHAH(World BDLCNPMEDLI, Type JLNNFEOBAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x250C890", Offset = "0x250BC90", VA = "0x18250C890")]
	public void CJDFALKIAHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
[EFDJEPLIMOC(typeof(PJNOCLLALMF), new string[] { })]
internal sealed class PJNOCLLALMF : AKFIPDJCCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private JKFGGDBFGOH EDNPFADAINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	[ONGFANECMJO]
	private EDAGPFPPFFG AJMDHBOAFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	[ONGFANECMJO]
	private PFJMBDHJHAN BDLCNPMEDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	[ONGFANECMJO]
	private ANLJAEDMKMC BCODCENCABJ;

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x2231C40", Offset = "0x2231040", VA = "0x182231C40", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x2231CF0", Offset = "0x22310F0", VA = "0x182231CF0")]
	public PPACDBGDBCI MOCOOKLAOJK(PPACDBGDBCI GEKPNOHHCDG, Allocator GMMIODGPFPJ)
	{
		return default(PPACDBGDBCI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x2231750", Offset = "0x2230B50", VA = "0x182231750")]
	private void DLIOOKFBGCJ(NativeParallelMultiHashMap<int, (KDLENLDMBAK src, KDLENLDMBAK dst)> GJMHCLLLGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x22312D0", Offset = "0x22306D0", VA = "0x1822312D0")]
	private void DAAEOMEBPIA(NativeParallelMultiHashMap<int, (KDLENLDMBAK src, KDLENLDMBAK dst)> GJMHCLLLGDH, int MNOKFAHHNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x22310D0", Offset = "0x22304D0", VA = "0x1822310D0")]
	private void ADDAFAELEFE(NativeParallelMultiHashMap<int, (KDLENLDMBAK src, KDLENLDMBAK dst)> GJMHCLLLGDH, int MNOKFAHHNHH, GKAKPCKINHA NFDNHCCMBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x22318F0", Offset = "0x2230CF0", VA = "0x1822318F0")]
	private NativeParallelMultiHashMap<int, (KDLENLDMBAK, KDLENLDMBAK)> HNDNBOJAOMF(Allocator GMMIODGPFPJ, PPACDBGDBCI GEKPNOHHCDG, out PPACDBGDBCI HLPMEBHEALO)
	{
		return default(NativeParallelMultiHashMap<int, (KDLENLDMBAK, KDLENLDMBAK)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public PJNOCLLALMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[EFDJEPLIMOC(typeof(FBMPIPPNPOF), new string[] { })]
[JOCOBGMDOKK(CAGOEBHGGNL.LoadInstance)]
public class FBMPIPPNPOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly Dictionary<EHKHPDFBEJD, string> EJKBCPIIGMK;

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x28CE170", Offset = "0x28CD570", VA = "0x1828CE170")]
	public GameObject LKPAJLHCOFP(EHKHPDFBEJD MHEFEHIKCFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x28CE240", Offset = "0x28CD640", VA = "0x1828CE240")]
	public FBMPIPPNPOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DefaultMember("Item")]
public class LDPEFEAEDLN<From, To>
{
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[JOCOBGMDOKK(CAGOEBHGGNL.PhotonRoom)]
[EFDJEPLIMOC(typeof(LPIHKEBMEKO), new string[] { })]
public class LPIHKEBMEKO : OOLEGKACHHE, DEPDOFHIDBA, AKFIPDJCCOH, CBKELFDIEEL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private NIOKIOAHGMB FBCPJLHEMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private LCDMECHMCNI PHGDMOLIACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private NativeList<int> NGAADFFAAFP;

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x2A63630", Offset = "0x2A62A30", VA = "0x182A63630", Slot = "4")]
	public void MCOOCEGHCPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x2A634E0", Offset = "0x2A628E0", VA = "0x182A634E0", Slot = "5")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x2A63550", Offset = "0x2A62950", VA = "0x182A63550", Slot = "6")]
	public void JFCLKDMBJND(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x2A63420", Offset = "0x2A62820", VA = "0x182A63420", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x2A63690", Offset = "0x2A62A90", VA = "0x182A63690")]
	public void PHDKIBAIKNM(NativeParallelHashSet<int> BBONCDKEMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x2A635F0", Offset = "0x2A629F0", VA = "0x182A635F0")]
	public void JKKCEGEGJCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public LPIHKEBMEKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[EFDJEPLIMOC(typeof(DMACADNGJAP), new string[] { })]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
internal class DMACADNGJAP : AKFIPDJCCOH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static readonly PILIJFIMAJF CJCCIDOEGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	[ONGFANECMJO]
	private MILFLABAMPI FBCPJLHEMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	[ONGFANECMJO]
	private PFJMBDHJHAN GKACEDOEIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	[ONGFANECMJO]
	private AOONNPAOEFB FHJACJEANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	[ONGFANECMJO]
	private PGKBPEGCPKO KMPMKIKDFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private LPMPALGCIEF PJDNDHAAPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private EntityQuery PNGFJEAJDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private EntityQuery PAMGGCOPPLC;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private EntityManager FCLKPLIBOOP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x2526150", Offset = "0x2525550", VA = "0x182526150")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x25256B0", Offset = "0x2524AB0", VA = "0x1825256B0", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x2523FD0", Offset = "0x25233D0", VA = "0x182523FD0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x2526040", Offset = "0x2525440", VA = "0x182526040")]
	public JLLNNHEPACB MIPHHPPEMHP(IEnumerable<PIFKOMHKCPK> BJNEFCGPFGN)
	{
		return default(JLLNNHEPACB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x2523FE0", Offset = "0x25233E0", VA = "0x182523FE0")]
	public static bool FIKHJDPCMIK(PIFKOMHKCPK IPCJOMPDMMM, out CMFFIMLEPBE AIOICCOKGOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x2524130", Offset = "0x2523530", VA = "0x182524130")]
	private JLLNNHEPACB GBBKCPMIAKD(IEnumerable<PIFKOMHKCPK> BJNEFCGPFGN)
	{
		return default(JLLNNHEPACB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x2525440", Offset = "0x2524840", VA = "0x182525440")]
	private (List<PIFKOMHKCPK>, int[], int) IEKDNDPFKIA(IEnumerable<PIFKOMHKCPK> BJNEFCGPFGN)
	{
		return default((List<PIFKOMHKCPK>, int[], int));
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x2525910", Offset = "0x2524D10", VA = "0x182525910")]
	private Dictionary<CMFFIMLEPBE, (PIFKOMHKCPK, int)> KLJECHDLEBF(IEnumerable<PIFKOMHKCPK> BJNEFCGPFGN, Entity EBCHMACJPMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x2524610", Offset = "0x2523A10", VA = "0x182524610")]
	private void GKDFNMCJGIK(Dictionary<CMFFIMLEPBE, (PIFKOMHKCPK request, int srcIndex)> MPJINGGNEFK, IEnumerable<PIFKOMHKCPK> BJNEFCGPFGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x2523610", Offset = "0x2522A10", VA = "0x182523610")]
	private void CFFJMHDOMIP(Dictionary<CMFFIMLEPBE, (PIFKOMHKCPK request, int srcIndex)> MPJINGGNEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x25237F0", Offset = "0x2522BF0", VA = "0x1825237F0")]
	private void DAECHLONMIL(Dictionary<CMFFIMLEPBE, (PIFKOMHKCPK request, int srcIndex)> MPJINGGNEFK, CMFFIMLEPBE AIOICCOKGOP, string DKPHPKDPBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x2525030", Offset = "0x2524430", VA = "0x182525030")]
	private void HLGCGPNMPIJ(Dictionary<CMFFIMLEPBE, (PIFKOMHKCPK request, int srcIndex)> MPJINGGNEFK, Entity EBCHMACJPMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x2524980", Offset = "0x2523D80", VA = "0x182524980")]
	private (List<PIFKOMHKCPK>, int[], int) GNLOHCGHNIA(Dictionary<CMFFIMLEPBE, (PIFKOMHKCPK request, int srcIndex)> MPJINGGNEFK, Entity EBCHMACJPMC)
	{
		return default((List<PIFKOMHKCPK>, int[], int));
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x2523D50", Offset = "0x2523150", VA = "0x182523D50")]
	private void DHJEIHCMHMB(Dictionary<CMFFIMLEPBE, (PIFKOMHKCPK request, int srcIndex)> MPJINGGNEFK, List<PIFKOMHKCPK> JBJEGGPJCGJ, int[] JEEHNBOJABM, NativeArray<Entity> PGJLMFPAKDA, NativeList<CMFFIMLEPBE> MAEMAKOHEBK, NativeList<Entity> ADGHFOGIHGF, Entity EBCHMACJPMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x2523350", Offset = "0x2522750", VA = "0x182523350")]
	private static bool BMIPLCELEHE(Entity FKNFFDFGNMN, ComponentDataFromEntity<ELLKBCJMOKK> LFBEOFENMBN, Entity EBCHMACJPMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2525AE0", Offset = "0x2524EE0", VA = "0x182525AE0")]
	private void MBIMMKAMCEB(Dictionary<CMFFIMLEPBE, (PIFKOMHKCPK request, int srcIndex)> MPJINGGNEFK, List<PIFKOMHKCPK> JBJEGGPJCGJ, int[] JEEHNBOJABM, NativeList<Entity> ADGHFOGIHGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2525E30", Offset = "0x2525230", VA = "0x182525E30")]
	private NativeList<CMFFIMLEPBE> MCGLOIEGKPG(Dictionary<CMFFIMLEPBE, (PIFKOMHKCPK request, int srcIndex)> MPJINGGNEFK)
	{
		return default(NativeList<CMFFIMLEPBE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2523420", Offset = "0x2522820", VA = "0x182523420")]
	private NativeArray<Entity> BOPPCHFFLMP(NativeList<CMFFIMLEPBE> MAEMAKOHEBK)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x25259C0", Offset = "0x2524DC0", VA = "0x1825259C0")]
	private static void KPAHOGFBMHN(Dictionary<CMFFIMLEPBE, (PIFKOMHKCPK request, int srcIndex)> MPJINGGNEFK, CMFFIMLEPBE AIOICCOKGOP, PIFKOMHKCPK IPCJOMPDMMM, string DKPHPKDPBCM, int PFCGBKHJJHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2525620", Offset = "0x2524A20", VA = "0x182525620")]
	private void ILLAJGKDJLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public DMACADNGJAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
[EFDJEPLIMOC(typeof(MLIPPJCKHBF), new string[] { })]
public class MLIPPJCKHBF : DEPDOFHIDBA, AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	[ONGFANECMJO]
	private MDBOACJLHAE HNFAJKHJNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private bool PFIEAHFFKHI;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public TimeData HPKNPABPHBP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x2A6A810", Offset = "0x2A69C10", VA = "0x182A6A810")]
		get
		{
			return default(TimeData);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x2A6A7B0", Offset = "0x2A69BB0", VA = "0x182A6A7B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool NEFBMCKIPJF
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x9937F0", Offset = "0x992BF0", VA = "0x1809937F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x1782140", Offset = "0x1781540", VA = "0x181782140", Slot = "4")]
	public void MCOOCEGHCPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x2A6A760", Offset = "0x2A69B60", VA = "0x182A6A760", Slot = "5")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x2A6A880", Offset = "0x2A69C80", VA = "0x182A6A880")]
	public void PAINPFAMLCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	public void DNHHKEKIGLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public MLIPPJCKHBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[EFDJEPLIMOC(typeof(IIKMCLIAKNK), new string[] { })]
public class JJBNIJCAMHO : IIKMCLIAKNK, OOLEGKACHHE, DEPDOFHIDBA, AKFIPDJCCOH, CBKELFDIEEL, IDisposable, JJBNIJCAMHO.MJDNGKOAFOP
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	internal interface MJDNGKOAFOP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ADOFLJEFPII(global::GHEMABPOFFC KIPLHKMDGNM);
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private AOONNPAOEFB FHJACJEANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private PFJMBDHJHAN BDLCNPMEDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private GDDLKDHJNAI NKKFHEHKJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private JCHEPGFOMNF AJMDHBOAFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private DNMGNPMNFDI FCGEAJNLBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private bool MMLDFGNKLLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private global::GHEMABPOFFC JPJAANFKNAB;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	private AOJLADIGKFN<KDLENLDMBAK> CECPGAGDNBI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x94B820", Offset = "0x94AC20", VA = "0x18094B820")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	private EntityManager FCLKPLIBOOP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x288D730", Offset = "0x288CB30", VA = "0x18288D730")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<OJGPABLJLLP> MBBDIEJLJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x288D2E0", Offset = "0x288C6E0", VA = "0x18288D2E0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x288C9E0", Offset = "0x288BDE0", VA = "0x18288C9E0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0xE6BCE0", Offset = "0xE6B0E0", VA = "0x180E6BCE0", Slot = "17")]
	public void MCOOCEGHCPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x288CC80", Offset = "0x288C080", VA = "0x18288CC80", Slot = "18")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x288D1F0", Offset = "0x288C5F0", VA = "0x18288D1F0", Slot = "19")]
	public void JFCLKDMBJND(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x94CDF0", Offset = "0x94C1F0", VA = "0x18094CDF0", Slot = "21")]
	private void IKFMKJBGLAG(global::GHEMABPOFFC KIPLHKMDGNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0xE6BC20", Offset = "0xE6B020", VA = "0x180E6BC20", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x2529D90", Offset = "0x2529190", VA = "0x182529D90")]
	private KDLENLDMBAK LJMNJHEFGPL(Entity FKNFFDFGNMN)
	{
		return default(KDLENLDMBAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x288CB60", Offset = "0x288BF60", VA = "0x18288CB60", Slot = "6")]
	public KDLENLDMBAK HIJCLBEKBJN(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(KDLENLDMBAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x288CD50", Offset = "0x288C150", VA = "0x18288CD50", Slot = "7")]
	public void JBEEHEFECLP(ref List<KDLENLDMBAK> OLLDFGPFFGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x288D140", Offset = "0x288C540", VA = "0x18288D140", Slot = "11")]
	public int JEONIAELMNM(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x288CA40", Offset = "0x288BE40", VA = "0x18288CA40", Slot = "12")]
	public PPACDBGDBCI FBEOMFECMBG(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(PPACDBGDBCI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x288CF80", Offset = "0x288C380", VA = "0x18288CF80", Slot = "15")]
	public KDLENLDMBAK JDMHPFIMIIA(KDLENLDMBAK GDNOLIODDHJ, KDLENLDMBAK NNMGPKBMOKD)
	{
		return default(KDLENLDMBAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x288D490", Offset = "0x288C890", VA = "0x18288D490", Slot = "16")]
	public bool NECHJOFNONE(KDLENLDMBAK GDNOLIODDHJ, KDLENLDMBAK NNMGPKBMOKD, out KDLENLDMBAK DCAFPIJMBKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x288C8C0", Offset = "0x288BCC0", VA = "0x18288C8C0", Slot = "8")]
	public KDLENLDMBAK BGOPCJKFHEJ(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(KDLENLDMBAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x288D640", Offset = "0x288CA40", VA = "0x18288D640", Slot = "14")]
	public bool OFOEOMJNIKA(KDLENLDMBAK LCODCOPGHJA, KDLENLDMBAK MODHKGGCBAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x288D3A0", Offset = "0x288C7A0", VA = "0x18288D3A0", Slot = "13")]
	public bool MGKPNBNCMAF(KDLENLDMBAK LCODCOPGHJA, KDLENLDMBAK BHKMKEODELA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x288C960", Offset = "0x288BD60", VA = "0x18288C960", Slot = "9")]
	public bool CIGBDIGMBAB(KDLENLDMBAK LCODCOPGHJA, KDLENLDMBAK ILDFJHMNOPJ, bool IHNOCHJJPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x288D340", Offset = "0x288C740", VA = "0x18288D340", Slot = "10")]
	public bool LBKKOGFBAGN(KDLENLDMBAK LCODCOPGHJA, KDLENLDMBAK ILDFJHMNOPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public JJBNIJCAMHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class JGHKPFGGNID : LILHPPGJGND, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> LHCOOFKJLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int FDMAFFFKDKK;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> GMJBBLHMCPD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x9CDA70", Offset = "0x9CCE70", VA = "0x1809CDA70", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int JGKLPOMFGJF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xA71600", Offset = "0xA70A00", VA = "0x180A71600", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x288B230", Offset = "0x288A630", VA = "0x18288B230")]
	public JGHKPFGGNID(NativeArray<EntityRemapUtility.EntityRemapInfo> LHCOOFKJLML, int FDMAFFFKDKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x288B150", Offset = "0x288A550", VA = "0x18288B150", Slot = "6")]
	public KDLENLDMBAK JENKENCJDAG(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(KDLENLDMBAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x288B1F0", Offset = "0x288A5F0", VA = "0x18288B1F0", Slot = "8")]
	public LocalId JENKENCJDAG(LocalId FKNFFDFGNMN)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x288B0F0", Offset = "0x288A4F0", VA = "0x18288B0F0", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[EFDJEPLIMOC(typeof(NBGOAKDNEPN), new string[] { })]
[LOJHKAHIJPC(typeof(GFGEKEKINCH))]
public class LFKHGCCHNKJ : NBGOAKDNEPN, FDGKLMNACMK, GFGEKEKINCH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static readonly ProfilerMarker OBPAFKIHAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private HKJKANBGCIL PHPOLCBAEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private GIFAPDPEGID OEBMDJNIHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private MLIEFKPODIE FBCPJLHEMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private HDMAPPDIGGB KGIKIENCPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private LCDMECHMCNI JCCJKLDIGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private bool MMLDFGNKLLJ;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public HKJKANBGCIL FNKCBJOHLDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x7E8110", Offset = "0x7E7510", VA = "0x1807E8110", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public MLIEFKPODIE MANJOJKJFDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x7E8120", Offset = "0x7E7520", VA = "0x1807E8120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public GIFAPDPEGID PMIDMGFEIFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public LCDMECHMCNI OEFCADIFJNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x8BC350", Offset = "0x8BB750", VA = "0x1808BC350", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool MPIAMCJMFLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xA4B130", Offset = "0xA4A530", VA = "0x180A4B130", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool EHMEEIIOBGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x2A5EE90", Offset = "0x2A5E290", VA = "0x182A5EE90", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public AIDFLENHCFG MBAGIEMANEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xB977F0", Offset = "0xB96BF0", VA = "0x180B977F0", Slot = "9")]
		get
		{
			return default(AIDFLENHCFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x2A5EEB0", Offset = "0x2A5E2B0", VA = "0x182A5EEB0")]
	public static LFKHGCCHNKJ OBPHLOEIGIJ(HKJKANBGCIL PHPOLCBAEBM, ABPNKIGHGCN NNGHEIFAPDC = ABPNKIGHGCN.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	private static void PGBLHOFPGII(HKJKANBGCIL PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	private static void MFJHPJFMACG(HKJKANBGCIL PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x2A5EC30", Offset = "0x2A5E030", VA = "0x182A5EC30", Slot = "10")]
	public void BDMFHPOGKDD(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0xE6BCE0", Offset = "0xE6B0E0", VA = "0x180E6BCE0")]
	private void MCOOCEGHCPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x2A5EDC0", Offset = "0x2A5E1C0", VA = "0x182A5EDC0")]
	private void LPFBFMCNGBK(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	private void JFCLKDMBJND(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x2A5ED60", Offset = "0x2A5E160", VA = "0x182A5ED60", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public LFKHGCCHNKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public static class HEMKECBHIAP
{
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[DisallowMultipleComponent]
	public class TransformEntity : MonoBehaviour, KNAEKBFOOHL
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly PILIJFIMAJF FDJKGAAPBBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[SerializeField]
		private LENINMGJJHF prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private KDLENLDMBAK LCODCOPGHJA;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual LENINMGJJHF CIFLKDOINGO
		{
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x9C0750", Offset = "0x9BFB50", VA = "0x1809C0750", Slot = "6")]
			get
			{
				return default(LENINMGJJHF);
			}
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0xC0C1E0", Offset = "0xC0B5E0", VA = "0x180C0C1E0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public KDLENLDMBAK KEENOEKFOKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x1105550", Offset = "0x1104950", VA = "0x181105550", Slot = "5")]
			get
			{
				return default(KDLENLDMBAK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool MADHFPDLGFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x977980", Offset = "0x976D80", VA = "0x180977980", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x977870", Offset = "0x976C70", VA = "0x180977870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		internal Entity KONLACAKAKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x2243C20", Offset = "0x2243020", VA = "0x182243C20")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		internal AOONNPAOEFB OFAMBFDPDBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x2243C10", Offset = "0x2243010", VA = "0x182243C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		internal PGKBPEGCPKO CJICLLCCKHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x2243B90", Offset = "0x2242F90", VA = "0x182243B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x2243650", Offset = "0x2242A50", VA = "0x182243650")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x2243A80", Offset = "0x2242E80", VA = "0x182243A80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x2243660", Offset = "0x2242A60", VA = "0x182243660")]
		internal void BEFDPLAELIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x2243C30", Offset = "0x2243030", VA = "0x182243C30")]
		private bool NFPONBFIHCA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x2243A50", Offset = "0x2242E50", VA = "0x182243A50")]
		private void FMKNJKOLALN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x2243A80", Offset = "0x2242E80", VA = "0x182243A80")]
		internal void GGFEFJPGMCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x2243CD0", Offset = "0x22430D0", VA = "0x182243CD0")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x2243E30", Offset = "0x2243230", VA = "0x182243E30")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public abstract class KKMECPBNOFL : PADOFPJBFIO
{
	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x2892D50", Offset = "0x2892150", VA = "0x182892D50", Slot = "5")]
	public override Action DIDJMLFICEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[UnityEngine.Scripting.Preserve]
	public abstract void FBHFDJFLNLL<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x2892DE0", Offset = "0x28921E0", VA = "0x182892DE0")]
	[UnityEngine.Scripting.Preserve]
	public void FBCDLLLINCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x2514550", Offset = "0x2513950", VA = "0x182514550")]
	protected KKMECPBNOFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[EFDJEPLIMOC(typeof(PFJMBDHJHAN), new string[] { })]
public class FAFNGGGNFMN : PFJMBDHJHAN, IDisposable, AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	[ONGFANECMJO]
	private EEFGHGFDIPG AOEDEMFCBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	[ONGFANECMJO]
	private IPJCHCHPAMO KIKIIAMJNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private World OINEMFIGHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private World GLMOAKNBFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private bool ODINFFOGFNM;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public World DFKBAKJLNEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x7E8120", Offset = "0x7E7520", VA = "0x1807E8120", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public World DIMECBCAKBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x7F2BB0", Offset = "0x7F1FB0", VA = "0x1807F2BB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public EntityManager FCLKPLIBOOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x28CDBE0", Offset = "0x28CCFE0", VA = "0x1828CDBE0", Slot = "6")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool MPIAMCJMFLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x28CD500", Offset = "0x28CC900", VA = "0x1828CD500", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x28CD830", Offset = "0x28CCC30", VA = "0x1828CD830", Slot = "10")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x28CDA50", Offset = "0x28CCE50", VA = "0x1828CDA50")]
	private void OBPHLOEIGIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x28CD510", Offset = "0x28CC910", VA = "0x1828CD510", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x28CD810", Offset = "0x28CCC10", VA = "0x1828CD810", Slot = "8")]
	public ComponentSystemBase IJCEMIAIIAL(Type JLNNFEOBAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public FAFNGGGNFMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[EFDJEPLIMOC(typeof(EDMKCBGGPIB), new string[] { })]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
public class EDMKCBGGPIB : AKFIPDJCCOH, FNMJCBCJFHI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private struct LEKNIJNHDFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private NativeArray<int> NHCIHPMGCAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private NativeArray<int> NLMDNELOIKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private Dictionary<ComponentSystemBase, int> BHMLPLLDBEE;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x27137E0", Offset = "0x2712BE0", VA = "0x1827137E0")]
		public LEKNIJNHDFM(NativeArray<int> NHCIHPMGCAM, NativeArray<int> NLMDNELOIKN, Dictionary<ComponentSystemBase, int> BHMLPLLDBEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x2713420", Offset = "0x2712820", VA = "0x182713420")]
		public static void JOCMGLCOIMC(World BDLCNPMEDLI, CAGOEBHGGNL DLAGDAOLECA, NativeArray<int> NHCIHPMGCAM, NativeArray<int> NLMDNELOIKN, Dictionary<ComponentSystemBase, int> BHMLPLLDBEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x2713550", Offset = "0x2712950", VA = "0x182713550")]
		public void LGNAJNMPFPD(IEnumerable<ComponentSystemBase> OEBMDJNIHNJ, CAGOEBHGGNL DLAGDAOLECA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class OPNFLBIPDEM : IEnumerable<ComponentSystemBase>, IEnumerable, IEnumerator<ComponentSystemBase>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private ComponentSystemBase <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private int start;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public int <>3__start;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private int end;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public int <>3__end;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public EDMKCBGGPIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private int <i>5__1;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		ComponentSystemBase IEnumerator<ComponentSystemBase>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xB48080", Offset = "0xB47480", VA = "0x180B48080")]
		[DebuggerHidden]
		public OPNFLBIPDEM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x2716330", Offset = "0x2715730", VA = "0x182716330", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x2716500", Offset = "0x2715900", VA = "0x182716500", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x2716450", Offset = "0x2715850", VA = "0x182716450", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<ComponentSystemBase> IEnumerable<ComponentSystemBase>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x2716450", Offset = "0x2715850", VA = "0x182716450", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static readonly PILIJFIMAJF EPCELEOKBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	[ONGFANECMJO]
	private PFJMBDHJHAN GKACEDOEIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private World BDLCNPMEDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private EMFBCBAOENA PHPOLCBAEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private NativeArray<int> AOCHMNKFCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private NativeArray<int> HKOMMEDEENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private int HEGEMCIFGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private CAGOEBHGGNL FFGEKJBEOEI;

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x28C4B70", Offset = "0x28C3F70", VA = "0x1828C4B70", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x28C45F0", Offset = "0x28C39F0", VA = "0x1828C45F0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x28C4D30", Offset = "0x28C4130", VA = "0x1828C4D30")]
	[IteratorStateMachine(typeof(OPNFLBIPDEM))]
	private IEnumerable<ComponentSystemBase> LEFBELCAPFM(int GNBCIEFMNKN, int IGMAELCNDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x28C4400", Offset = "0x28C3800", VA = "0x1828C4400", Slot = "5")]
	public void AGEJNEJCHBN(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x28C4400", Offset = "0x28C3800", VA = "0x1828C4400")]
	private void OPDGPCEKPDD(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x28C52D0", Offset = "0x28C46D0", VA = "0x1828C52D0")]
	public void OPDGPCEKPDD(CAGOEBHGGNL HPGNJILLFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x28C4680", Offset = "0x28C3A80", VA = "0x1828C4680")]
	private void HEIICKLAJFD(CAGOEBHGGNL HPGNJILLFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x28C4920", Offset = "0x28C3D20", VA = "0x1828C4920")]
	private void HMLEGFOKOHO(CAGOEBHGGNL HPGNJILLFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x28C44C0", Offset = "0x28C38C0", VA = "0x1828C44C0")]
	private void CKGDGCPFENF(CAGOEBHGGNL HPGNJILLFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x28C4C50", Offset = "0x28C4050", VA = "0x1828C4C50")]
	private void JPIDBFAKAMJ(int GNBCIEFMNKN, int IGMAELCNDHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x28C4530", Offset = "0x28C3930", VA = "0x1828C4530")]
	private void DKBIEMPEEBP(int GNBCIEFMNKN, int IGMAELCNDHD, bool GDHKPCGLKJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x28C4D10", Offset = "0x28C4110", VA = "0x1828C4D10")]
	private int LDEILAJMGFI(CAGOEBHGGNL HPGNJILLFHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x28C4DC0", Offset = "0x28C41C0", VA = "0x1828C4DC0")]
	private bool MHNIGKDODJD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x28C49C0", Offset = "0x28C3DC0", VA = "0x1828C49C0")]
	private Dictionary<ComponentSystemBase, int> IDIOCKKNAAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x28C4480", Offset = "0x28C3880", VA = "0x1828C4480")]
	private void AGJILBBOBDK(NativeArray<int> NHCIHPMGCAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x28C5440", Offset = "0x28C4840", VA = "0x1828C5440")]
	private void PPJFADFDKIB(NativeArray<int> NLMDNELOIKN, NativeArray<int> NHCIHPMGCAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x28C4B10", Offset = "0x28C3F10", VA = "0x1828C4B10")]
	private static CAGOEBHGGNL INKNHPABFBC(Type JLNNFEOBAMK, CAGOEBHGGNL OLNFJPNAOBM)
	{
		return default(CAGOEBHGGNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x28C55C0", Offset = "0x28C49C0", VA = "0x1828C55C0")]
	public EDMKCBGGPIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x28C4AB0", Offset = "0x28C3EB0", VA = "0x1828C4AB0")]
	[CompilerGenerated]
	private void IFHOIBLOPJP(AKFIPDJCCOH GHGKMCPGGOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x28C53E0", Offset = "0x28C47E0", VA = "0x1828C53E0")]
	[CompilerGenerated]
	private void PLEFOMJEMJE(CBKELFDIEEL GHGKMCPGGOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal class FMBBOPILHPC : HLOJAODEAAM
{
	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x28D2F40", Offset = "0x28D2340", VA = "0x1828D2F40", Slot = "15")]
	protected override ComponentSystemBase BHJHPJOJPMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x28D3180", Offset = "0x28D2580", VA = "0x1828D3180")]
	[UnityEngine.Scripting.Preserve]
	private void IEAEIHNCBBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x2229A50", Offset = "0x2228E50", VA = "0x182229A50")]
	public FMBBOPILHPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[EFDJEPLIMOC(typeof(LCDMECHMCNI), new string[] { })]
public class OBGFCBCGAJP : LCDMECHMCNI, AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static readonly PILIJFIMAJF HMPIFKHOHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private HKJKANBGCIL PHPOLCBAEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private HDMAPPDIGGB KGIKIENCPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private MLIEFKPODIE FBCPJLHEMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private NBGOAKDNEPN NNBEJFPKHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private LPMPALGCIEF PJDNDHAAPGO;

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool MGIAMALJMBL
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x2A74060", Offset = "0x2A73460", VA = "0x182A74060", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action MANDAMLLCMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x2A740D0", Offset = "0x2A734D0", VA = "0x182A740D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x2A739A0", Offset = "0x2A72DA0", VA = "0x182A739A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x2A73AA0", Offset = "0x2A72EA0", VA = "0x182A73AA0", Slot = "15")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x2A73E30", Offset = "0x2A73230", VA = "0x182A73E30", Slot = "11")]
	public Task LGOOMDJEDKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x2A74170", Offset = "0x2A73570", VA = "0x182A74170", Slot = "12")]
	public Task PPAICFPHGCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x2A73F30", Offset = "0x2A73330", VA = "0x182A73F30", Slot = "13")]
	public Task MJACODMALGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x2A73B70", Offset = "0x2A72F70", VA = "0x182A73B70", Slot = "8")]
	public void JBIKHGGLJIK(bool GDHKPCGLKJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x2A73A40", Offset = "0x2A72E40", VA = "0x182A73A40", Slot = "9")]
	public bool GHOHIFDICAL(ByteString OEKDIKJACFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x2A73EA0", Offset = "0x2A732A0", VA = "0x182A73EA0", Slot = "6")]
	public void LIMIHEDCBKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x9BD040", Offset = "0x9BC440", VA = "0x1809BD040", Slot = "7")]
	public void NLFCIAOAAHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x2A73FA0", Offset = "0x2A733A0", VA = "0x182A73FA0", Slot = "14")]
	public void NBGGPFMKNJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public OBGFCBCGAJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[Flags]
public enum ABPNKIGHGCN
{
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	ExcludeIgnore = 1,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	ExcludePhoton = 2,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	ExcludeAssemblyCSharp = 4,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	IncludeMock = 8,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	IncludeEditor = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	Default = 1
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[EFDJEPLIMOC(typeof(DMPPFDLMONO), new string[] { })]
[JOCOBGMDOKK(CAGOEBHGGNL.LoadInstance)]
public class DMPPFDLMONO : AKFIPDJCCOH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[ONGFANECMJO]
	private DIOBGNHCMAF CKLBBPLIDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[ONGFANECMJO]
	private EDMKCBGGPIB KGMGDKBCBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[ONGFANECMJO]
	private NLLKOIOEBHH JJBMHHKCDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ONGFANECMJO]
	private DNMGNPMNFDI FCGEAJNLBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ONGFANECMJO]
	private PFJMBDHJHAN GKACEDOEIPO;

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x2526380", Offset = "0x2525780", VA = "0x182526380", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x2526330", Offset = "0x2525730", VA = "0x182526330", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x2526270", Offset = "0x2525670", VA = "0x182526270")]
	private void AHICKJAGMGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x2526330", Offset = "0x2525730", VA = "0x182526330")]
	private void GONDJKDFOCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x2526510", Offset = "0x2525910", VA = "0x182526510")]
	private void PFBKJKJKMID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public DMPPFDLMONO()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class EntityReference : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x8CEA50", Offset = "0x8CDE50", VA = "0x1808CEA50")]
		public EntityReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
[EFDJEPLIMOC(typeof(BLHCLDIBPBL), new string[] { })]
internal class BLHCLDIBPBL : AKFIPDJCCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private PFJMBDHJHAN BDLCNPMEDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private JKPBDEIBINB DJGFELMBIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private KHCHBOKCLCH FPOHAILGCPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private ABLEKJPBMJE HLIMBDLGFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[ONGFANECMJO]
	private ANLJAEDMKMC KLBBCPHGEPH;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public NNDFCMOOFMO DNDMPKFAFMG
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x94BE70", Offset = "0x94B270", VA = "0x18094BE70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x94BE50", Offset = "0x94B250", VA = "0x18094BE50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x25146D0", Offset = "0x2513AD0", VA = "0x1825146D0", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x2514630", Offset = "0x2513A30", VA = "0x182514630")]
	private void HGJAGBIIGOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x2514560", Offset = "0x2513960", VA = "0x182514560")]
	public OMADGHGGHJN BDPFPLJBNHK(NNHEPJDBKBI DKPHPKDPBCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x3306830", Offset = "0x3305C30", VA = "0x183306830")]
	public OGKKIFKAIGA<T> DGPMPGENCFL<T>(NNHEPJDBKBI DKPHPKDPBCM) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public BLHCLDIBPBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal static class MFIJLFDNDJM
{
	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x24A8C90", Offset = "0x24A8090", VA = "0x1824A8C90")]
	public static MDGCCNJAIOM<T> BDPFPLJBNHK<T>(this BLHCLDIBPBL KOGOHDPCGKI, AFHAKKMHKHI<T> DKPHPKDPBCM) where T : struct
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class ObjectModelConfigAsset : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public const string RUNTIME_CONFIG_FOLDER = "ObjectModelConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[SerializeField]
		private EmbodiedObject objectPrefab;

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public EmbodiedObject ObjectPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x222D870", Offset = "0x222CC70", VA = "0x18222D870")]
		public static ObjectModelConfigAsset HMKOFHLNLGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x992770", Offset = "0x991B70", VA = "0x180992770")]
		public ObjectModelConfigAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public abstract class PADOFPJBFIO : HBDOKBANKBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private readonly MethodInfo JCPBDFBEJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly Type[] KLEPOOAJLPJ;

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x222DB00", Offset = "0x222CF00", VA = "0x18222DB00")]
	public PADOFPJBFIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action DIDJMLFICEC();

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x222DAC0", Offset = "0x222CEC0", VA = "0x18222DAC0")]
	public MethodInfo JNGIBGKFHOA(Action FJBAKNFCPGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x222D910", Offset = "0x222CD10", VA = "0x18222D910", Slot = "4")]
	public void FIMKNKKCEGK(Type JLNNFEOBAMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[LOJHKAHIJPC(typeof(JIPGODLIPAL))]
[EFDJEPLIMOC(typeof(LPMPALGCIEF), new string[] { })]
internal class JIPGODLIPAL : LPMPALGCIEF, IDisposable, AKFIPDJCCOH, FNMJCBCJFHI
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class OABGJPEFHEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public JIPGODLIPAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public OABGJPEFHEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x2715D90", Offset = "0x2715190", VA = "0x182715D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private static readonly PILIJFIMAJF HMPIFKHOHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	[ONGFANECMJO]
	private MLIEFKPODIE FBCPJLHEMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	[ONGFANECMJO]
	private LCDMECHMCNI JCCJKLDIGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	[ONGFANECMJO]
	private EGBJFBCNELH NIABELHCNNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	[ONGFANECMJO]
	private HDMAPPDIGGB KGIKIENCPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private NBGOAKDNEPN NNBEJFPKHDA;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool FPBGNIALCNP
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0xA4B130", Offset = "0xA4A530", VA = "0x180A4B130", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xA4B060", Offset = "0xA4A460", VA = "0x180A4B060", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool FNOGJLCJGGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xCED260", Offset = "0xCEC660", VA = "0x180CED260", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool NJJLPDCMGHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xA4B150", Offset = "0xA4A550", VA = "0x180A4B150", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0xA4B0A0", Offset = "0xA4A4A0", VA = "0x180A4B0A0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public PDOBJBPMLLM DGAIHMEADPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x8C2FB0", Offset = "0x8C23B0", VA = "0x1808C2FB0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x94CDF0", Offset = "0x94C1F0", VA = "0x18094CDF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x288C0E0", Offset = "0x288B4E0", VA = "0x18288C0E0", Slot = "16")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x288B400", Offset = "0x288A800", VA = "0x18288B400", Slot = "15")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x288C210", Offset = "0x288B610", VA = "0x18288C210", Slot = "8")]
	public LJMLKHMFDNK KFFHJEIGHPH(bool LBACNOAIGNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x288B510", Offset = "0x288A910", VA = "0x18288B510")]
	public LJMLKHMFDNK BIGJPCOPFJP(IEnumerable<KDLENLDMBAK> KOJOICDCDNK, in JHHGOKLOOPH NKJIKOHPNDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x288BB90", Offset = "0x288AF90", VA = "0x18288BB90", Slot = "10")]
	public LLEIAOFCAJL FFKMLIIKPIG(ByteString OEKDIKJACFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x288B9A0", Offset = "0x288ADA0", VA = "0x18288B9A0")]
	public EGPAMILOEKO EGOMNFFJPKE(ByteString OEKDIKJACFK, KDLENLDMBAK ILDFJHMNOPJ, in JHHGOKLOOPH OHHNNICFOGI, NPKIHKJLIJM PCAJHGGKAME, bool KFBCEJHHGFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x288B7E0", Offset = "0x288ABE0", VA = "0x18288B7E0", Slot = "12")]
	public void EEEFMKMBIOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x288C490", Offset = "0x288B890", VA = "0x18288C490", Slot = "14")]
	public JLLNNHEPACB MIPHHPPEMHP(IEnumerable<PIFKOMHKCPK> EECPPFPKBHF)
	{
		return default(JLLNNHEPACB);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x288BDE0", Offset = "0x288B1E0", VA = "0x18288BDE0")]
	public static bool GHOHIFDICAL(ByteString OEKDIKJACFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x288C650", Offset = "0x288BA50", VA = "0x18288C650", Slot = "13")]
	public void MPIHIMJOKNI(bool NMGHCFGCMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x288C1B0", Offset = "0x288B5B0", VA = "0x18288C1B0")]
	private void JBIKHGGLJIK(bool GDHKPCGLKJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x288B400", Offset = "0x288A800", VA = "0x18288B400")]
	private void ADPGACCMOJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x125F6C0", Offset = "0x125EAC0", VA = "0x18125F6C0")]
	private void CJMAMIIJLBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x288C430", Offset = "0x288B830", VA = "0x18288C430")]
	private void LMGHDDLKDLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x288B460", Offset = "0x288A860", VA = "0x18288B460", Slot = "17")]
	public void AGEJNEJCHBN(EMFBCBAOENA CHPNHBOHJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public JIPGODLIPAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x288B510", Offset = "0x288A910", VA = "0x18288B510", Slot = "9")]
	private LJMLKHMFDNK BMAGFFHAANK(IEnumerable<KDLENLDMBAK> KOJOICDCDNK, in JHHGOKLOOPH NKJIKOHPNDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x288BEE0", Offset = "0x288B2E0", VA = "0x18288BEE0", Slot = "11")]
	private EGPAMILOEKO IIHPNNMIEKP(ByteString OEKDIKJACFK, KDLENLDMBAK ILDFJHMNOPJ, in JHHGOKLOOPH OHHNNICFOGI, NPKIHKJLIJM PCAJHGGKAME, bool KFBCEJHHGFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x288B6C0", Offset = "0x288AAC0", VA = "0x18288B6C0")]
	[CompilerGenerated]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OABGJPEFHEJ))]
	private Task BIPIOPODAJO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct EMFFPKIJPCM : IEnumerable<LICGLELKAHO>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public enum NEMBJMGLILO
	{
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public struct FGPHBMDPGAF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private NativeList<byte> KJFNAECAHBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private EMFFPKIJPCM OCCNFAKIALD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly LICGLELKAHO CANIEFMHGCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private readonly int GNBCIEFMNKN;

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x270DBE0", Offset = "0x270CFE0", VA = "0x18270DBE0")]
		internal FGPHBMDPGAF(EMFFPKIJPCM OCCNFAKIALD, LICGLELKAHO CANIEFMHGCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x270DA00", Offset = "0x270CE00", VA = "0x18270DA00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x270DA30", Offset = "0x270CE30", VA = "0x18270DA30")]
		public void EOBDOLDOJNC(ReadOnlySpan<byte> KKIAKNLLHIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x270DAE0", Offset = "0x270CEE0", VA = "0x18270DAE0")]
		private void KCOGBPFIJEM(ReadOnlySpan<byte> KKIAKNLLHIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x270DB80", Offset = "0x270CF80", VA = "0x18270DB80")]
		private unsafe void KCOGBPFIJEM(void* OJEHIPCHIOL, int PGBALNGGNPG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public struct EDDJGCKODAA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private EMFFPKIJPCM OCCNFAKIALD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private NativeArray<byte> KJFNAECAHBA;

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x270C3A0", Offset = "0x270B7A0", VA = "0x18270C3A0")]
		internal EDDJGCKODAA(EMFFPKIJPCM OCCNFAKIALD, NativeArray<byte> KJFNAECAHBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x270C190", Offset = "0x270B590", VA = "0x18270C190", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x270C1A0", Offset = "0x270B5A0", VA = "0x18270C1A0")]
		public NativeArray<byte> GODGJAIPDAH(int PGBALNGGNPG)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x270C260", Offset = "0x270B660", VA = "0x18270C260")]
		public void NEDGAEBCDBH(Span<byte> KKIAKNLLHIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public struct HJLMNBEKDLM : IEnumerator<LICGLELKAHO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private readonly NativeList<LICGLELKAHO> KGHLGBOMEFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private int NANJAGEOPJI;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public LICGLELKAHO NEGPJPJCKFH
		{
			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x270F3F0", Offset = "0x270E7F0", VA = "0x18270F3F0", Slot = "4")]
			get
			{
				return default(LICGLELKAHO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x270F3B0", Offset = "0x270E7B0", VA = "0x18270F3B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x270F260", Offset = "0x270E660", VA = "0x18270F260", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x270F370", Offset = "0x270E770", VA = "0x18270F370", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private struct OLGAEGGGEOD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private NativeArray<int> KJFNAECAHBA;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public bool DDCIGFMHKIH
		{
			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x27161C0", Offset = "0x27155C0", VA = "0x1827161C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public int OHFENMKNBKA
		{
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x2716240", Offset = "0x2715640", VA = "0x182716240")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x2716280", Offset = "0x2715680", VA = "0x182716280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public NEMBJMGLILO OHOBMPHFBLB
		{
			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x27161B0", Offset = "0x27155B0", VA = "0x1827161B0")]
			get
			{
				return default(NEMBJMGLILO);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x2716140", Offset = "0x2715540", VA = "0x182716140")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool GOGKGFNPCGK
		{
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x2716150", Offset = "0x2715550", VA = "0x182716150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool GLPGBOBNMAI
		{
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x2716290", Offset = "0x2715690", VA = "0x182716290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x27162B0", Offset = "0x27156B0", VA = "0x1827162B0")]
		public OLGAEGGGEOD(NEMBJMGLILO GBAOBADLAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x2716250", Offset = "0x2715650", VA = "0x182716250")]
		private int IKHPLCCBENN(int IFONHBAKCAB, int DHOALNLDFIA = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x2716170", Offset = "0x2715570", VA = "0x182716170")]
		private void DADPJLGDIHI(int IFONHBAKCAB, int KKIAKNLLHIO, int DHOALNLDFIA = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x2716200", Offset = "0x2715600", VA = "0x182716200", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly LICGLELKAHO FFPFANOOKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private NativeParallelHashMap<LICGLELKAHO, int> CEPMLMFPDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private NativeList<LICGLELKAHO> NIABELHCNNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private NativeList<int> HKOMMEDEENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private NativeList<byte> DAOKOLFHCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private NativeList<byte> KJFNAECAHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private OLGAEGGGEOD ANKHOKAAJLH;

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x28C9870", Offset = "0x28C8C70", VA = "0x1828C9870")]
	public static EMFFPKIJPCM OBPHLOEIGIJ(NEMBJMGLILO GBAOBADLAKH = NEMBJMGLILO.Last, int HLADENLCHGL = 16, int ECNGNJEOMCD = 256)
	{
		return default(EMFFPKIJPCM);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x28C9A90", Offset = "0x28C8E90", VA = "0x1828C9A90")]
	private EMFFPKIJPCM(NEMBJMGLILO GBAOBADLAKH, int HLADENLCHGL, int ECNGNJEOMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x28C91B0", Offset = "0x28C85B0", VA = "0x1828C91B0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x28C9290", Offset = "0x28C8690", VA = "0x1828C9290")]
	public FGPHBMDPGAF EBDIKMKCNAF(LICGLELKAHO CANIEFMHGCA)
	{
		return default(FGPHBMDPGAF);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x28C8FC0", Offset = "0x28C83C0", VA = "0x1828C8FC0")]
	public bool BOHGILEGILK(LICGLELKAHO CANIEFMHGCA, out EDDJGCKODAA KPHJKKGHHEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x28C9750", Offset = "0x28C8B50", VA = "0x1828C9750")]
	public bool NFNLKPEONEB(LICGLELKAHO CANIEFMHGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x28C97A0", Offset = "0x28C8BA0", VA = "0x1828C97A0")]
	public bool NGKFICNLNKP(LICGLELKAHO CANIEFMHGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x28C98B0", Offset = "0x28C8CB0", VA = "0x1828C98B0")]
	public void PEHJALIONDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x28C9380", Offset = "0x28C8780", VA = "0x1828C9380")]
	private void IAAFDMKCOEO(LICGLELKAHO CANIEFMHGCA, int GNBCIEFMNKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x28C9570", Offset = "0x28C8970", VA = "0x1828C9570")]
	private void IDDJMGOMGFF(int AEPPGJOKKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x28C9660", Offset = "0x28C8A60", VA = "0x1828C9660")]
	private void LJKOILMGLPE(LICGLELKAHO CANIEFMHGCA, int GNBCIEFMNKN, int PGBALNGGNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x28C99D0", Offset = "0x28C8DD0", VA = "0x1828C99D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x28C9990", Offset = "0x28C8D90", VA = "0x1828C9990", Slot = "4")]
	private IEnumerator<LICGLELKAHO> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[DisallowMultipleComponent]
	public class RbexEntity : TransformEntity
	{
		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public override LENINMGJJHF CIFLKDOINGO
		{
			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x2240C60", Offset = "0x2240060", VA = "0x182240C60", Slot = "6")]
			get
			{
				return default(LENINMGJJHF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x2240C00", Offset = "0x2240000", VA = "0x182240C00")]
		public RbexEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public static class IJGKHKLGBAN
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public static class BBKFJFILBOO
	{
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private static readonly PILIJFIMAJF FDJKGAAPBBG;

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x2708360", Offset = "0x2707760", VA = "0x182708360")]
		public static CMFFIMLEPBE OCNFGHOCHEJ(int GDEFNMGHDLM, PDOBJBPMLLM NMAOCBMPAGO)
		{
			return default(CMFFIMLEPBE);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x2707FE0", Offset = "0x27073E0", VA = "0x182707FE0")]
		private static KDLENLDMBAK MAJLKKNKGMI(PDOBJBPMLLM PNOLCOOAMPM, KDLENLDMBAK FHAKJIJMNLM)
		{
			return default(KDLENLDMBAK);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x2708800", Offset = "0x2707C00", VA = "0x182708800")]
		private static void OGMMINONJNK(KDLENLDMBAK FEGCDMFOKIA, KDLENLDMBAK LKAPLFAEMLF, CMFFIMLEPBE AIOICCOKGOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x2708100", Offset = "0x2707500", VA = "0x182708100")]
		public static int NHJGNDOHNKA(GameObject GACFHLOJJGF, LJMLKHMFDNK DJJLHIBGCIP)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static HKJKANBGCIL LDFFEEECKDP;

	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private static NBGOAKDNEPN NNBEJFPKHDA;

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public static NBGOAKDNEPN HOHAGLFEHPH
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x2884FF0", Offset = "0x28843F0", VA = "0x182884FF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public static bool BNBEJIMCPKE
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x28847A0", Offset = "0x2883BA0", VA = "0x1828847A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public static EMFBCBAOENA FNKCBJOHLDL
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x2884720", Offset = "0x2883B20", VA = "0x182884720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public static GIFAPDPEGID PMIDMGFEIFO
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x2884D30", Offset = "0x2884130", VA = "0x182884D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public static BKIGCJIBBEC IIJFBCCMPBK
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x28858B0", Offset = "0x2884CB0", VA = "0x1828858B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public static AOONNPAOEFB OFAMBFDPDBC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x2884F70", Offset = "0x2884370", VA = "0x182884F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public static IIKMCLIAKNK HIGPLAHDIIH
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x2884940", Offset = "0x2883D40", VA = "0x182884940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public static AJMPOCCEJIG LFCPLAFINOB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x28856B0", Offset = "0x2884AB0", VA = "0x1828856B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public static bool CHHFBBKAHGB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x2885270", Offset = "0x2884670", VA = "0x182885270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public static bool ILJDPPABHJE
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x2884CE0", Offset = "0x28840E0", VA = "0x182884CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public static EFBPNECENII JADINPGHHLL
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x2884BA0", Offset = "0x2883FA0", VA = "0x182884BA0")]
		get
		{
			return default(EFBPNECENII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public static bool NLPMNACKAHO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x28849C0", Offset = "0x2883DC0", VA = "0x1828849C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public static byte EAHBOBNBHPN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x2885590", Offset = "0x2884990", VA = "0x182885590")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public static bool LMHALLIAHML
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x28844E0", Offset = "0x28838E0", VA = "0x1828844E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public static bool GOFJMENNHIN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x2884DB0", Offset = "0x28841B0", VA = "0x182884DB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x28852F0", Offset = "0x28846F0", VA = "0x1828852F0")]
	public static void MCPDNMKNAAD(HKJKANBGCIL KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x2885730", Offset = "0x2884B30", VA = "0x182885730")]
	public static KDLENLDMBAK OIPIJNOEBKM(GameObject GACFHLOJJGF)
	{
		return default(KDLENLDMBAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x2884540", Offset = "0x2883940", VA = "0x182884540")]
	public static EFBPNECENII ANBJDPECJGN(CMFFIMLEPBE AIOICCOKGOP)
	{
		return default(EFBPNECENII);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x2884A60", Offset = "0x2883E60", VA = "0x182884A60")]
	public static bool HKEKKGCJEDM(GameObject GACFHLOJJGF, out CMFFIMLEPBE AIOICCOKGOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x2885450", Offset = "0x2884850", VA = "0x182885450")]
	public static JLLNNHEPACB MIPHHPPEMHP(IEnumerable<PIFKOMHKCPK> EECPPFPKBHF)
	{
		return default(JLLNNHEPACB);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x2885930", Offset = "0x2884D30", VA = "0x182885930")]
	public static void PPMONDGIILK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x2885150", Offset = "0x2884550", VA = "0x182885150")]
	private static NBGOAKDNEPN LIJCINMMPJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x2884E10", Offset = "0x2884210", VA = "0x182884E10")]
	private static bool LDANCMBPENC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class OECMDHKBNLH
{
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct LICGLELKAHO : IComparable<LICGLELKAHO>, IEquatable<LICGLELKAHO>
{
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public static readonly LICGLELKAHO GBNLDGHKLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public CMFFIMLEPBE BGPCGOEKFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public GLFLLKHPAHK KOAJDKDANHI;

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public bool MFCBPLJLPNA
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x2A602E0", Offset = "0x2A5F6E0", VA = "0x182A602E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0xA28DB0", Offset = "0xA281B0", VA = "0x180A28DB0")]
	public LICGLELKAHO(CMFFIMLEPBE BGPCGOEKFEF, GLFLLKHPAHK KOAJDKDANHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x2A602F0", Offset = "0x2A5F6F0", VA = "0x182A602F0", Slot = "4")]
	public int CompareTo(LICGLELKAHO LNOOAJJNCAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x2A60460", Offset = "0x2A5F860", VA = "0x182A60460", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x2A60380", Offset = "0x2A5F780", VA = "0x182A60380", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x2A60330", Offset = "0x2A5F730", VA = "0x182A60330", Slot = "5")]
	public bool Equals(LICGLELKAHO LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x2A60420", Offset = "0x2A5F820", VA = "0x182A60420", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[JOCOBGMDOKK(CAGOEBHGGNL.LoadInstance)]
[EFDJEPLIMOC(typeof(PIIJIAKBOIK), new string[] { })]
internal class PIIJIAKBOIK : AKFIPDJCCOH, CBKELFDIEEL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private PGKBPEGCPKO KMPMKIKDFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private MDGCCNJAIOM<Entity> ILDFJHMNOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private DNMGNPMNFDI EGEBFNBKGKB;

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x2230D70", Offset = "0x2230170", VA = "0x182230D70", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x2230DE0", Offset = "0x22301E0", VA = "0x182230DE0", Slot = "5")]
	public void JFCLKDMBJND(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x2230CD0", Offset = "0x22300D0", VA = "0x182230CD0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x2230F10", Offset = "0x2230310", VA = "0x182230F10")]
	private void KEOHPHBMKPH(Entity FKNFFDFGNMN, in NBOENLAPDFO PHNODIMLADH, in NBOENLAPDFO NDKKBDCFLEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public PIIJIAKBOIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
[EFDJEPLIMOC(typeof(OMKBGDBGLMG), new string[] { })]
internal class OMKBGDBGLMG : AKFIPDJCCOH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	[ONGFANECMJO]
	private JKPBDEIBINB NFDNHCCMBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private readonly Dictionary<int, BAHKBHMHHLL> NNEAHOHOEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private bool MMLDFGNKLLJ;

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x2229BC0", Offset = "0x2228FC0", VA = "0x182229BC0", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x2229A60", Offset = "0x2228E60", VA = "0x182229A60", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x2229D50", Offset = "0x2229150", VA = "0x182229D50")]
	public BAHKBHMHHLL ONCHBHIJDFM(NNHEPJDBKBI KKIJPENOLBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x2229C10", Offset = "0x2229010", VA = "0x182229C10")]
	public BAHKBHMHHLL ONCHBHIJDFM(GLFLLKHPAHK KOAJDKDANHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x2229F60", Offset = "0x2229360", VA = "0x182229F60")]
	public void PEHJALIONDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x222A080", Offset = "0x2229480", VA = "0x18222A080")]
	public OMKBGDBGLMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
[EFDJEPLIMOC(typeof(MOAFKOGGIKO), new string[] { })]
public class MOAFKOGGIKO
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public struct NFLNMHNCOON : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private readonly MOAFKOGGIKO ILDFJHMNOPJ;

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x3DE6A80", Offset = "0x3DE5E80", VA = "0x183DE6A80", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private int EBOPDIFHPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action BHCDALLPIFG;

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x2A6C9F0", Offset = "0x2A6BDF0", VA = "0x182A6C9F0")]
	public void JHIIACOMIMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public MOAFKOGGIKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[DefaultMember("Item")]
public class IHLIJMKHPCJ<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly Func<From, To> IABGFIOJHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly Func<To, From> NBAEHBFFFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public NativeArray<From> KGHLGBOMEFA;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public To OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xF00200", Offset = "0xEFF600", VA = "0x180F00200", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xF00250", Offset = "0xEFF650", VA = "0x180F00250", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public int NPBPHODFKMP
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xF001C0", Offset = "0xEFF5C0", VA = "0x180F001C0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool PAJHIMACICC
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x7FFD60", Offset = "0x7FF160", VA = "0x1807FFD60", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0xF00160", Offset = "0xEFF560", VA = "0x180F00160")]
	public IHLIJMKHPCJ(Func<From, To> IABGFIOJHML, Func<To, From> NBAEHBFFFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0xEFFD40", Offset = "0xEFF140", VA = "0x180EFFD40", Slot = "11")]
	public void Add(To ADJFAODNAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0xEFFD80", Offset = "0xEFF180", VA = "0x180EFFD80", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0xEFFDC0", Offset = "0xEFF1C0", VA = "0x180EFFDC0", Slot = "13")]
	public bool Contains(To ADJFAODNAMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0xEFFE80", Offset = "0xEFF280", VA = "0x180EFFE80", Slot = "14")]
	public void CopyTo(To[] KGHLGBOMEFA, int BHHKGKOCFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0xEFFF40", Offset = "0xEFF340", VA = "0x180EFFF40", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0xF00000", Offset = "0xEFF400", VA = "0x180F00000", Slot = "6")]
	public int IndexOf(To ADJFAODNAMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0xF00070", Offset = "0xEFF470", VA = "0x180F00070", Slot = "7")]
	public void Insert(int NANJAGEOPJI, To ADJFAODNAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0xF000F0", Offset = "0xEFF4F0", VA = "0x180F000F0", Slot = "15")]
	public bool Remove(To ADJFAODNAMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0xF000B0", Offset = "0xEFF4B0", VA = "0x180F000B0", Slot = "8")]
	public void RemoveAt(int NANJAGEOPJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0xF00130", Offset = "0xEFF530", VA = "0x180F00130", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[PFNECKMFGPE]
public class JANBAKDDDNO : ComponentSystem, AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	private EMFBCBAOENA FNKCBJOHLDL
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x94BE50", Offset = "0x94B250", VA = "0x18094BE50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private GIFAPDPEGID PMIDMGFEIFO
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x94CDF0", Offset = "0x94C1F0", VA = "0x18094CDF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x28874E0", Offset = "0x28868E0", VA = "0x1828874E0", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AF0", Offset = "0x7F0EF0", VA = "0x1807F1AF0")]
	public JANBAKDDDNO()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[DisallowMultipleComponent]
	public sealed class EmbodiedObject : MonoBehaviour, CJHAGIKCJCL, KNAEKBFOOHL
	{
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private static readonly PILIJFIMAJF FDJKGAAPBBG;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private const string EIOGFOLCKKB = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private BIFEDELOJOL PJAFLHHFBPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private KDLENLDMBAK BGPCGOEKFEF;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public KDLENLDMBAK KEENOEKFOKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0x28CD2D0", Offset = "0x28CC6D0", VA = "0x1828CD2D0", Slot = "15")]
			get
			{
				return default(KDLENLDMBAK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public EFBPNECENII BHABMIFKNBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0x28CD380", Offset = "0x28CC780", VA = "0x1828CD380", Slot = "6")]
			get
			{
				return default(EFBPNECENII);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public bool MADHFPDLGFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x28CD2C0", Offset = "0x28CC6C0", VA = "0x1828CD2C0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public BIFEDELOJOL GLNIKJNLCIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0xB95230", Offset = "0xB94630", VA = "0x180B95230", Slot = "7")]
			get
			{
				return default(BIFEDELOJOL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		private GIFAPDPEGID PMIDMGFEIFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0x28CC720", Offset = "0x28CBB20", VA = "0x1828CC720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool ECBHPEOEFKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0x977980", Offset = "0x976D80", VA = "0x180977980", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0x977870", Offset = "0x976C70", VA = "0x180977870", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<bool> PEBCOOOFPKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x28CD180", Offset = "0x28CC580", VA = "0x1828CD180")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x28CD3C0", Offset = "0x28CC7C0", VA = "0x1828CD3C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		public event Action<CJHAGIKCJCL> KIMLDMDILJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0x28CD220", Offset = "0x28CC620", VA = "0x1828CD220", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0x28CD460", Offset = "0x28CC860", VA = "0x1828CD460", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x28CC600", Offset = "0x28CBA00", VA = "0x1828CC600")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x28CCED0", Offset = "0x28CC2D0", VA = "0x1828CCED0", Slot = "17")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x28CC980", Offset = "0x28CBD80", VA = "0x1828CC980", Slot = "18")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x28CCE60", Offset = "0x28CC260", VA = "0x1828CCE60", Slot = "10")]
		public void OnEmbody(PFJMBDHJHAN BDLCNPMEDLI, KDLENLDMBAK BGPCGOEKFEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x287DDB0", Offset = "0x287D1B0", VA = "0x18287DDB0", Slot = "11")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x28CCCB0", Offset = "0x28CC0B0", VA = "0x1828CCCB0", Slot = "12")]
		public void OnDisembody(bool MPMOJAKCGPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x28CC7B0", Offset = "0x28CBBB0", VA = "0x1828CC7B0")]
		private void LKCGBIEFNMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x28CC920", Offset = "0x28CBD20", VA = "0x1828CC920", Slot = "13")]
		public void NotifyInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x8CEA50", Offset = "0x8CDE50", VA = "0x1808CEA50")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x9F6750", Offset = "0x9F5B50", VA = "0x1809F6750", Slot = "9")]
		private GameObject BFADICOBPEH()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[DefaultMember("Item")]
public class OGKKIFKAIGA<T> : AOJLADIGKFN<T>, MHOBFBAOGME<KDLENLDMBAK, T>, KFFHHBDDKDC<KDLENLDMBAK>, COKGGJJNNDI, IDisposable, LJHGDPGPANM where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly KFFHHBDDKDC<Entity> HNNIGEFAIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly AOONNPAOEFB FHJACJEANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private Delegate DLPCLNEAINL;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public string GHALHBJBCAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x2F3AD90", Offset = "0x2F3A190", VA = "0x182F3AD90", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Type JJGFPAEGNBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x2F38C90", Offset = "0x2F38090", VA = "0x182F38C90", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public OPHEKAOFDCM BDLMLIAIJEL
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x2F39340", Offset = "0x2F38740", VA = "0x182F39340", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public int FFKGOHONJLM
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x2F3AD10", Offset = "0x2F3A110", VA = "0x182F3AD10", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public CBKEFCCBIHK CGPBOEFMOBO
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x2F3A520", Offset = "0x2F39920", VA = "0x182F3A520", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event CDOKGDJBJCM<KDLENLDMBAK> FMPPFIKKFCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x2F39550", Offset = "0x2F38950", VA = "0x182F39550", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x2F3AF30", Offset = "0x2F3A330", VA = "0x182F3AF30", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x2F3B930", Offset = "0x2F3AD30", VA = "0x182F3B930")]
	public OGKKIFKAIGA(KFFHHBDDKDC<Entity> HNNIGEFAIIM, AOONNPAOEFB FHJACJEANIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x2F3B740", Offset = "0x2F3AB40", VA = "0x182F3B740")]
	private Entity OILFFIENIEA(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x2F3B6F0", Offset = "0x2F3AAF0", VA = "0x182F3B6F0")]
	private KDLENLDMBAK OILFFIENIEA(Entity FKNFFDFGNMN)
	{
		return default(KDLENLDMBAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x2F39F00", Offset = "0x2F39300", VA = "0x182F39F00", Slot = "4")]
	public T IKHPLCCBENN(KDLENLDMBAK LCODCOPGHJA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x2F39170", Offset = "0x2F38570", VA = "0x182F39170")]
	public bool DADPJLGDIHI(KDLENLDMBAK LCODCOPGHJA, in T NDKKBDCFLEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x2F39AE0", Offset = "0x2F38EE0", VA = "0x182F39AE0", Slot = "7")]
	public bool HABKCECLKEN(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x2F39E90", Offset = "0x2F39290", VA = "0x182F39E90", Slot = "8")]
	public void IKHPLCCBENN(KDLENLDMBAK LCODCOPGHJA, PHJBMACKBCD KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x2F38D50", Offset = "0x2F38150", VA = "0x182F38D50", Slot = "9")]
	public bool DADPJLGDIHI(KDLENLDMBAK LCODCOPGHJA, NBOENLAPDFO NDKKBDCFLEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x2F3AD60", Offset = "0x2F3A160", VA = "0x182F3AD60", Slot = "16")]
	public void KOJIBCNMEML(KFBFMDMFJDA MFMFLMKKKDK, [Optional] object JNNDIHFHMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x2F39430", Offset = "0x2F38830", VA = "0x182F39430", Slot = "10")]
	public bool DGCDPJOAHEA(KDLENLDMBAK OPMNDBPHMGG, KDLENLDMBAK CDNLFOGBLLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x2F3B090", Offset = "0x2F3A490", VA = "0x182F3B090")]
	private void MJFIIHCCNAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x2F3A830", Offset = "0x2F39C30", VA = "0x182F3A830")]
	private void KBPJDJHEFFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x2F38350", Offset = "0x2F37750", VA = "0x182F38350")]
	private void AIADOGEBBDD(Entity FKNFFDFGNMN, in NBOENLAPDFO PHNODIMLADH, in NBOENLAPDFO NDKKBDCFLEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x2F39820", Offset = "0x2F38C20", VA = "0x182F39820")]
	private void GLJLAMPAIGL(Entity FKNFFDFGNMN, in NBOENLAPDFO PHNODIMLADH, in NBOENLAPDFO NDKKBDCFLEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x2557F20", Offset = "0x2557320", VA = "0x182557F20", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x2F3B750", Offset = "0x2F3AB50", VA = "0x182F3B750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[EFDJEPLIMOC(typeof(HDMAPPDIGGB), new string[] { })]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
internal class HDMAPPDIGGB
{
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private bool GDHKPCGLKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private bool MIPOMLNMKAJ;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool EHMEEIIOBGG
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0xA2ED20", Offset = "0xA2E120", VA = "0x180A2ED20")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x25230E0", Offset = "0x25224E0", VA = "0x1825230E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool IBGBHPCMLFC
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0xB94ED0", Offset = "0xB942D0", VA = "0x180B94ED0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x28DC150", Offset = "0x28DB550", VA = "0x1828DC150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public HDMAPPDIGGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[EFDJEPLIMOC(typeof(KGIPPHJNDDF), new string[] { })]
public class JEGLGBMCBJJ : KGIPPHJNDDF, AKFIPDJCCOH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private class OCHFOILAIHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public List<CapsuleCollider> KCDAJEFIAMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public List<SphereCollider> FDPJFNGBPGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public GameObject CIIHKGOBGJI;

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x2716080", Offset = "0x2715480", VA = "0x182716080")]
		public OCHFOILAIHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	[ONGFANECMJO]
	private AOONNPAOEFB POKBDJCFNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	[ONGFANECMJO]
	private DGDICPPMDDO DEHLAMAFJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private readonly Dictionary<Entity, OCHFOILAIHD> KFONGBBFOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private GameObject CGCBNEMEMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private GameObject HPBLNKACJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private GameObject EJGIILGBBEJ;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private GameObject EJAJKIFANMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x2888DB0", Offset = "0x28881B0", VA = "0x182888DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x28897B0", Offset = "0x2888BB0", VA = "0x1828897B0", Slot = "6")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x2889990", Offset = "0x2888D90", VA = "0x182889990", Slot = "4")]
	public void KJEDHFBPNKF(Entity NPIDDFCIBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x28891E0", Offset = "0x28885E0", VA = "0x1828891E0", Slot = "5")]
	public void IODLPDOICIP(Entity NPIDDFCIBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x2888E70", Offset = "0x2888270", VA = "0x182888E70", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x2889820", Offset = "0x2888C20", VA = "0x182889820")]
	private OCHFOILAIHD JDMLCFADLDB(Entity NPIDDFCIBDJ, BPHMAGJHJEM BMBJJEDFMKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x2888210", Offset = "0x2887610", VA = "0x182888210")]
	private void AFCMEALMBKJ(BPHMAGJHJEM BMBJJEDFMKB, OCHFOILAIHD FMADKMMEOGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x2888FD0", Offset = "0x28883D0", VA = "0x182888FD0")]
	private void EILHBEOMOFK(BPHMAGJHJEM BMBJJEDFMKB, OCHFOILAIHD FMADKMMEOGG, int HDGHIIIBHBG, Vector3 OMFIFBMFGMG, Quaternion PFHPGOOLCFP, float IPHDKMMKPIL, float IPGOHDEENMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x288A080", Offset = "0x2889480", VA = "0x18288A080")]
	private void MEJIPEJEEDN(OCHFOILAIHD FMADKMMEOGG, int DCDCMANMDHM, Vector3 OMFIFBMFGMG, float IPHDKMMKPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x2889D80", Offset = "0x2889180", VA = "0x182889D80")]
	private void LEFBONBCFPP(BPHMAGJHJEM BMBJJEDFMKB, OCHFOILAIHD FMADKMMEOGG, int OMHLDFCECIH, int HNELOBPPMON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0xBD6250", Offset = "0xBD5650", VA = "0x180BD6250")]
	private T AAALANNAMOE<T>(BPHMAGJHJEM BMBJJEDFMKB, ref GameObject OCCJOMPABPO, Vector3 KLNBLJCMMCM, Quaternion EDHIFCBPMNM) where T : Collider
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x288A2D0", Offset = "0x28896D0", VA = "0x18288A2D0")]
	public JEGLGBMCBJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[DefaultMember("Item")]
public class FJDEDAOADGO<From, To> where From : struct, IEquatable<From>
{
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[GCHMNDFEPKK(typeof(OKGCFPBMNKK))]
[EFDJEPLIMOC(typeof(OKPGNAADCIJ), new string[] { })]
public class LIDONCOOONG : OKPGNAADCIJ, DEPDOFHIDBA, AKFIPDJCCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private readonly Dictionary<int, ACBMDIMIIAP> JKGCJMKFJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private readonly Dictionary<ACBMDIMIIAP, int> GMLPLHBLOKC;

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x2A60810", Offset = "0x2A5FC10", VA = "0x182A60810", Slot = "6")]
	public void MCOOCEGHCPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x2A60720", Offset = "0x2A5FB20", VA = "0x182A60720", Slot = "7")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x2A608E0", Offset = "0x2A5FCE0", VA = "0x182A608E0")]
	private void PCHEDOMICCE(List<(ACBMDIMIIAP nameHash, ILPAELJEFKD stableTypeHash, Type type)> OCCNFAKIALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x2A605D0", Offset = "0x2A5F9D0", VA = "0x182A605D0", Slot = "4")]
	public ACBMDIMIIAP GAHBLMCANFI(int EPAJCDGEEKI)
	{
		return default(ACBMDIMIIAP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x2A60560", Offset = "0x2A5F960", VA = "0x182A60560", Slot = "5")]
	public int FMLBEHHFHNP(ACBMDIMIIAP DCDKOALONMG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x2A60AF0", Offset = "0x2A5FEF0", VA = "0x182A60AF0")]
	public LIDONCOOONG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class EGIGNBGOCAO
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class BOGAHHHCHHJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class NCJBPBLKKBJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class CGPPAINMDJP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x28C6D60", Offset = "0x28C6160", VA = "0x1828C6D60")]
	public static Entity BHMANKOAAHD(this EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x28C7860", Offset = "0x28C6C60", VA = "0x1828C7860")]
	public static DynamicBuffer<OOENBAEOKLI> NHHKKJKHNCO(this EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN)
	{
		return default(DynamicBuffer<OOENBAEOKLI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x28C6DD0", Offset = "0x28C61D0", VA = "0x1828C6DD0")]
	public static bool ELNJDNDBBHF(this EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN, Allocator GMMIODGPFPJ, out NativeArray<Entity> PIJFFONPCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x28C71F0", Offset = "0x28C65F0", VA = "0x1828C71F0")]
	public static NativeArray<Entity> HIMIOHCCBCC(this EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x28C7360", Offset = "0x28C6760", VA = "0x1828C7360")]
	public static int JEONIAELMNM(this EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x28C6A10", Offset = "0x28C5E10", VA = "0x1828C6A10")]
	public static void ACFDIMLLJOA(NativeArray<Entity> NKKFHEHKJKO, NativeArray<Entity> CIHGKBGGPMF, EntityManager GLPCEPPDPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x28C78F0", Offset = "0x28C6CF0", VA = "0x1828C78F0")]
	public static bool OFOEOMJNIKA(this EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN, Entity MODHKGGCBAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x28C7470", Offset = "0x28C6870", VA = "0x1828C7470")]
	public static bool MGKPNBNCMAF(this EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN, Entity BHKMKEODELA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x28C6ED0", Offset = "0x28C62D0", VA = "0x1828C6ED0")]
	public static NativeList<Entity> GNNEPMHANFN(this EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN, bool MHEKEMFLOBK = false, Allocator GMMIODGPFPJ = Allocator.Temp)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x28C70F0", Offset = "0x28C64F0", VA = "0x1828C70F0")]
	public static Entity HIJCLBEKBJN(this EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x28C7610", Offset = "0x28C6A10", VA = "0x1828C7610")]
	public static bool NECHJOFNONE(this EntityManager GLPCEPPDPLB, Entity GDNOLIODDHJ, Entity NNMGPKBMOKD, out Entity NONKAECCKAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x28C7A60", Offset = "0x28C6E60", VA = "0x1828C7A60")]
	internal static void PAIEIHLDPBG(EntityManager GLPCEPPDPLB, Entity ILDFJHMNOPJ, Entity CDFHGECAPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x28C6C70", Offset = "0x28C6070", VA = "0x1828C6C70")]
	private static bool BAMPJCCGAII(EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN, Entity MODHKGGCBAP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[GDOKNPFKFMM]
internal struct GHCANGACFBB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public JHHGOKLOOPH NKJIKOHPNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public DJLGGHMIKCI CDBIHHMMALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public JKEPICPKEKM.AHJBHAPGIOE.DOHFJMOONME HEGEMCIFGEI;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public static readonly ACMLBEEJFIH<GHCANGACFBB> DEEICBABDMJ;

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x28D62F0", Offset = "0x28D56F0", VA = "0x1828D62F0")]
	public static GHCANGACFBB MNKDDDLIFEK(in JHHGOKLOOPH NKJIKOHPNDP)
	{
		return default(GHCANGACFBB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
public interface JAEEHGLCHDB
{
	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	JKEPICPKEKM.AHJBHAPGIOE.DOHFJMOONME JNNPMJCEPPL
	{
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public static class HOCKBIMENHA
{
	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x287C1C0", Offset = "0x287B5C0", VA = "0x18287C1C0")]
	public static JHHGOKLOOPH KALMLLLNCAF(EFBPNECENII ILDFJHMNOPJ)
	{
		return default(JHHGOKLOOPH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class FKNPOBMCANB : LJMLKHMFDNK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private readonly bool GDHKPCGLKJL;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public LILHPPGJGND NMPAJDKKPMO
	{
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x7F35A0", Offset = "0x7F29A0", VA = "0x1807F35A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x182F240", Offset = "0x182E640", VA = "0x18182F240")]
	public FKNPOBMCANB(bool GDHKPCGLKJL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x28D0E60", Offset = "0x28D0260", VA = "0x1828D0E60", Slot = "5")]
	public ByteString AFMFBLIACIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
internal class MLHMJPANAKE
{
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private static readonly PILIJFIMAJF MLGODNEFJAJ;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private static readonly PILIJFIMAJF HMPIFKHOHKJ;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private static readonly ProfilerMarker FEPGAJOFEPM;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private static readonly ProfilerMarker CMCPOBPBOKL;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private static readonly ProfilerMarker LLPBGGJNMAH;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private static readonly ProfilerMarker GPOPLGGGKHG;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private static readonly ProfilerMarker FDACCDNAECF;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private static readonly ProfilerMarker BDIPIKMNGHF;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static readonly ProfilerMarker MOJCDKCIIGP;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly ProfilerMarker EOACPKGPAAN;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly ProfilerMarker JDIDJOLDIAF;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly ProfilerMarker KDFPICHPFJO;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static readonly ProfilerMarker JGLPHOFJMCP;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static readonly ProfilerMarker LINJLGGADFI;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly ProfilerMarker NAMHHLDKPMA;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly ProfilerMarker HNHNBMEGEEO;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly ProfilerMarker GDHDJPMDBCG;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly ProfilerMarker KJFCCPEIHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private readonly IEGLIHAFNMJ HIHOODFHFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private readonly ByteString OEKDIKJACFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private readonly HKJKANBGCIL PHPOLCBAEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private readonly IIONFMDPDBM FBCPJLHEMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private readonly JIPGODLIPAL MHKNHEGHFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private readonly EGBJFBCNELH NIABELHCNNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private readonly DAPPLPNBBCK GCPHKMCHKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private readonly HDMAPPDIGGB KGIKIENCPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private readonly TaskCompletionSource<bool> NAPIEOOPGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private readonly JMJABMMIMPK ANKHOKAAJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private readonly GIHEDKAKMHD.HKDONGJNAAM BDONKFCFJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private PFJMBDHJHAN BDLCNPMEDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private EEFGHGFDIPG OGDCNKEMGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private ADBHPBOEEGG AOFNEPAGJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private JKEPICPKEKM CMFJNFFHOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private LILHPPGJGND NFIBHFKKFIH;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public Action<bool> BOFDGGFOLCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x905C80", Offset = "0x905080", VA = "0x180905C80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0xA04BE0", Offset = "0xA03FE0", VA = "0x180A04BE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public Action GIPBHLNEEEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x905B70", Offset = "0x904F70", VA = "0x180905B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x905C60", Offset = "0x905060", VA = "0x180905C60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public Action KNIODNACGCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x9066A0", Offset = "0x905AA0", VA = "0x1809066A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x906900", Offset = "0x905D00", VA = "0x180906900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public Action PMMKCIMKAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x975AE0", Offset = "0x974EE0", VA = "0x180975AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x974FB0", Offset = "0x9743B0", VA = "0x180974FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public IEnumerable<PIFKOMHKCPK> EAGGBJJMICA
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x953B50", Offset = "0x952F50", VA = "0x180953B50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x960360", Offset = "0x95F760", VA = "0x180960360")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public JLLNNHEPACB OGOCPGCJELL
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x1865FA0", Offset = "0x18653A0", VA = "0x181865FA0")]
		[CompilerGenerated]
		get
		{
			return default(JLLNNHEPACB);
		}
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x18620E0", Offset = "0x18614E0", VA = "0x1818620E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public LILHPPGJGND NMPAJDKKPMO
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x9BC180", Offset = "0x9BB580", VA = "0x1809BC180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public LBPKNEPPDAM NGGFJAKCAJA
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x1785B00", Offset = "0x1784F00", VA = "0x181785B00")]
		get
		{
			return default(LBPKNEPPDAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public LocalId CECPGAGDNBI
	{
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x2A68100", Offset = "0x2A67500", VA = "0x182A68100")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public Task MJNPEKKLJJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x2A69000", Offset = "0x2A68400", VA = "0x182A69000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x2A6A4A0", Offset = "0x2A698A0", VA = "0x182A6A4A0")]
	public MLHMJPANAKE(ByteString OEKDIKJACFK, LBPKNEPPDAM NOGMGADAKBB, in JMJABMMIMPK ANKHOKAAJLH, HKJKANBGCIL PHPOLCBAEBM, PDOBJBPMLLM LEONMABPACO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x2A69B90", Offset = "0x2A68F90", VA = "0x182A69B90")]
	public void NEAHAFKMCLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x2A68780", Offset = "0x2A67B80", VA = "0x182A68780")]
	public bool GFPNCFCIMGJ(LBPKNEPPDAM GDNOLIODDHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x2A68A30", Offset = "0x2A67E30", VA = "0x182A68A30")]
	private bool HMAPPMMIBOK(LBPKNEPPDAM GKOGFPHIKMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x2A680B0", Offset = "0x2A674B0", VA = "0x182A680B0")]
	private void EJGMHEMOKBO(LBPKNEPPDAM JJFBJOMHLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x2A687A0", Offset = "0x2A67BA0", VA = "0x182A687A0")]
	private bool GJEECMJEJEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x2A69A40", Offset = "0x2A68E40", VA = "0x182A69A40")]
	private bool NCBPBJKGKCM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x2A68D50", Offset = "0x2A68150", VA = "0x182A68D50")]
	public bool IJLGIEPAEAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x2A69290", Offset = "0x2A68690", VA = "0x182A69290")]
	private bool MEOBPAEPELN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x2A67C70", Offset = "0x2A67070", VA = "0x182A67C70")]
	private bool BKPFCPJMONO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x2A679D0", Offset = "0x2A66DD0", VA = "0x182A679D0")]
	private bool ADIHFAPHFNB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x2A68EE0", Offset = "0x2A682E0", VA = "0x182A68EE0")]
	private bool JGELNCFPIFA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x2A68F00", Offset = "0x2A68300", VA = "0x182A68F00")]
	private bool KDHFNOJEKKE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x2A695D0", Offset = "0x2A689D0", VA = "0x182A695D0")]
	public void MILFNNDJCMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x2A69E60", Offset = "0x2A69260", VA = "0x182A69E60")]
	[CompilerGenerated]
	private void OPFMOMAOIAL(LBPKNEPPDAM GKOGFPHIKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x2A67F30", Offset = "0x2A67330", VA = "0x182A67F30")]
	[CompilerGenerated]
	private bool ECDOIEKIKEB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x2A68340", Offset = "0x2A67740", VA = "0x182A68340")]
	[CompilerGenerated]
	private void FPBBBLGKOPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x2A690C0", Offset = "0x2A684C0", VA = "0x182A690C0")]
	[CompilerGenerated]
	private World LKNMDHCLHAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x2A68110", Offset = "0x2A67510", VA = "0x182A68110")]
	[CompilerGenerated]
	private void ELJBMAJNDKG(World KHEAJHPMECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x2A69F10", Offset = "0x2A69310", VA = "0x182A69F10")]
	[CompilerGenerated]
	private int PJGFCMCOADC(World KHEAJHPMECK, ByteString OEKDIKJACFK, JKEPICPKEKM.AHJBHAPGIOE.DOHFJMOONME HEGEMCIFGEI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x2A69C80", Offset = "0x2A69080", VA = "0x182A69C80")]
	[CompilerGenerated]
	private void OANIAEONLKH(World BDLCNPMEDLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x2A68200", Offset = "0x2A67600", VA = "0x182A68200")]
	[CompilerGenerated]
	internal static JGHKPFGGNID EPGMGBMOMBE(EntityManager HGNEGIPDHJM, EntityManager HPCPANKIFHE, int FDMAFFFKDKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x2A68960", Offset = "0x2A67D60", VA = "0x182A68960")]
	[CompilerGenerated]
	private void HCNHKLAMLML(LILHPPGJGND NFIBHFKKFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x2A67AA0", Offset = "0x2A66EA0", VA = "0x182A67AA0")]
	[CompilerGenerated]
	private void BDBNMKNNOCK(EntityManager GLPCEPPDPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x2A691D0", Offset = "0x2A685D0", VA = "0x182A691D0")]
	[CompilerGenerated]
	private void MBHLMAFKIFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x2A691B0", Offset = "0x2A685B0", VA = "0x182A691B0")]
	[CompilerGenerated]
	private void LMMEPAOIGCC(string DKPHPKDPBCM, EntityManager GLPCEPPDPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x2A69040", Offset = "0x2A68440", VA = "0x182A69040")]
	[CompilerGenerated]
	private LCDBGDJGFGE<JMJABMMIMPK> LBHOPDMBKMD(EntityManager GLPCEPPDPLB)
	{
		return default(LCDBGDJGFGE<JMJABMMIMPK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal class OJMHHEMGBEB : NKCBEJKKHOI
{
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly PILIJFIMAJF HMPIFKHOHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly bool GDHKPCGLKJL;

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x2229640", Offset = "0x2228A40", VA = "0x182229640")]
	public OJMHHEMGBEB(bool GDHKPCGLKJL, HKJKANBGCIL PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x9BB610", Offset = "0x9BAA10", VA = "0x1809BB610", Slot = "10")]
	protected override bool HPHOJGEHFPH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x2229510", Offset = "0x2228910", VA = "0x182229510", Slot = "11")]
	protected override void PMCBJCDMBLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x2229500", Offset = "0x2228900", VA = "0x182229500", Slot = "12")]
	protected override NativeArray<EntityRemapUtility.EntityRemapInfo> CNGPPCMDHDD(NativeArray<EntityRemapUtility.EntityRemapInfo> DIHFPPJFIPL)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
internal struct JMJABMMIMPK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	public JHHGOKLOOPH OHHNNICFOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	public Entity ILDFJHMNOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	public OBAEFFAKPIM CDBIHHMMALH;

	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	public static readonly ACMLBEEJFIH<JMJABMMIMPK> DEEICBABDMJ;
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
internal class IEGLIHAFNMJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	private enum BOMIAFPKJPE
	{
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		Running,
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		Completed,
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		Cancelled,
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		Disposed
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class JIEHCCFGOBA : IEnumerable<LBPKNEPPDAM>, IEnumerable, IEnumerator<LBPKNEPPDAM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private LBPKNEPPDAM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private LBPKNEPPDAM target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public LBPKNEPPDAM <>3__target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public IEGLIHAFNMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private int <allowedTarget>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private int <nextCompletedPhases>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private LBPKNEPPDAM <phase>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		private LBPKNEPPDAM System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.Serialization.DeserializePhases>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x9CDAB0", Offset = "0x9CCEB0", VA = "0x1809CDAB0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(LBPKNEPPDAM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0x2711AB0", Offset = "0x2710EB0", VA = "0x182711AB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0xB5E5A0", Offset = "0xB5D9A0", VA = "0x180B5E5A0")]
		[DebuggerHidden]
		public JIEHCCFGOBA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x2711930", Offset = "0x2710D30", VA = "0x182711930", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x2711A70", Offset = "0x2710E70", VA = "0x182711A70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x27119C0", Offset = "0x2710DC0", VA = "0x1827119C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LBPKNEPPDAM> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Serialization.DeserializePhases>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x27119C0", Offset = "0x2710DC0", VA = "0x1827119C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class MHEFHNLPLPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public LBPKNEPPDAM phase;

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public MHEFHNLPLPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x2714F90", Offset = "0x2714390", VA = "0x182714F90")]
		internal object FJNFMLJMILL(LBPKNEPPDAM a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly PILIJFIMAJF HMPIFKHOHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private readonly LBPKNEPPDAM NOGMGADAKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private readonly Func<LBPKNEPPDAM, bool> OCFNIHHOHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private readonly Action<LBPKNEPPDAM> PCIEDJDNCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private int HIOHGBJGONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private BOMIAFPKJPE PJAFLHHFBPC;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public LBPKNEPPDAM NGGFJAKCAJA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x7E8250", Offset = "0x7E7650", VA = "0x1807E8250")]
		get
		{
			return default(LBPKNEPPDAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool MPIAMCJMFLB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x287DD20", Offset = "0x287D120", VA = "0x18287DD20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x287E290", Offset = "0x287D690", VA = "0x18287E290")]
	public IEGLIHAFNMJ(LBPKNEPPDAM NOGMGADAKBB, Func<LBPKNEPPDAM, bool> OCFNIHHOHHN, Action<LBPKNEPPDAM> PCIEDJDNCJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x287DD30", Offset = "0x287D130", VA = "0x18287DD30")]
	[IteratorStateMachine(typeof(JIEHCCFGOBA))]
	private IEnumerable<LBPKNEPPDAM> DJCCKLGMJBI(LBPKNEPPDAM GDNOLIODDHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x287DDC0", Offset = "0x287D1C0", VA = "0x18287DDC0")]
	public bool GFPNCFCIMGJ(LBPKNEPPDAM GDNOLIODDHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x287E160", Offset = "0x287D560", VA = "0x18287E160")]
	private void OEEOLLFJOAH(LBPKNEPPDAM GKOGFPHIKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x287DDB0", Offset = "0x287D1B0", VA = "0x18287DDB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct LCDBGDJGFGE<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private EntityManager GLPCEPPDPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private readonly Entity EHJCNENFLKL;

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x203B6C0", Offset = "0x203AAC0", VA = "0x18203B6C0")]
	public LCDBGDJGFGE(EntityManager GLPCEPPDPLB, in T ANKHOKAAJLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x203B6B0", Offset = "0x203AAB0", VA = "0x18203B6B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class FBBLCJAFFGL : NKCBEJKKHOI
{
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private static readonly PILIJFIMAJF HMPIFKHOHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	private readonly GHCANGACFBB ANKHOKAAJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	private NativeList<Entity> MANNJBEFAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	private NativeArray<Entity> JEGIGAGHHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> KFDLBNNHIIK;

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x28CDFD0", Offset = "0x28CD3D0", VA = "0x1828CDFD0")]
	public FBBLCJAFFGL(IEnumerable<KDLENLDMBAK> KOJOICDCDNK, in GHCANGACFBB ANKHOKAAJLH, HKJKANBGCIL PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD60", Offset = "0x7FF160", VA = "0x1807FFD60", Slot = "10")]
	protected override bool HPHOJGEHFPH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x28CDDC0", Offset = "0x28CD1C0", VA = "0x1828CDDC0", Slot = "9")]
	protected override GHCANGACFBB KLHIGFCJEJJ()
	{
		return default(GHCANGACFBB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x28CDDF0", Offset = "0x28CD1F0", VA = "0x1828CDDF0", Slot = "11")]
	protected override void PMCBJCDMBLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x28CDC90", Offset = "0x28CD090", VA = "0x1828CDC90", Slot = "12")]
	protected override NativeArray<EntityRemapUtility.EntityRemapInfo> CNGPPCMDHDD(NativeArray<EntityRemapUtility.EntityRemapInfo> DIHFPPJFIPL)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x28CDD50", Offset = "0x28CD150", VA = "0x1828CDD50", Slot = "8")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal abstract class NKCBEJKKHOI : LJMLKHMFDNK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	private static readonly ProfilerMarker GPOPLGGGKHG;

	[Cpp2IlInjected.Token(Token = "0x4000213")]
	private static readonly ProfilerMarker IBFMMONDLPL;

	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private static readonly ProfilerMarker FDACCDNAECF;

	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private static readonly ProfilerMarker KIGEOEMPIIN;

	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private static readonly ProfilerMarker MOJCDKCIIGP;

	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private static readonly ProfilerMarker CKBCHKJEHGC;

	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private static readonly ProfilerMarker OCFEDFDMOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private readonly HKJKANBGCIL PHPOLCBAEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private readonly PFJMBDHJHAN BDLCNPMEDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private readonly EEFGHGFDIPG OGDCNKEMGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private readonly DAPPLPNBBCK GCPHKMCHKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private readonly EGBJFBCNELH NIABELHCNNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private readonly PILIJFIMAJF HMPIFKHOHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private readonly GIHEDKAKMHD.HKDONGJNAAM BDONKFCFJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private World GGHCPDDKBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private LILHPPGJGND NFIBHFKKFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private IDisposable KJKEACHFFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private ByteString JMLPFDPKOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private JKEPICPKEKM.AHJBHAPGIOE.DOHFJMOONME OLKKLIDBLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private bool ANJHIMEAMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private IPJCHCHPAMO KIKIIAMJNEE;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	protected World AGINHABGFNH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x94A400", Offset = "0x949800", VA = "0x18094A400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	protected World DFKBAKJLNEK
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x2A6FEE0", Offset = "0x2A6F2E0", VA = "0x182A6FEE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public LILHPPGJGND NMPAJDKKPMO
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x94B830", Offset = "0x94AC30", VA = "0x18094B830", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x2A70B30", Offset = "0x2A6FF30", VA = "0x182A70B30")]
	public NKCBEJKKHOI(HKJKANBGCIL PHPOLCBAEBM, PILIJFIMAJF FDJKGAAPBBG, PILIJFIMAJF HMPIFKHOHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x2A6FD80", Offset = "0x2A6F180", VA = "0x182A6FD80", Slot = "5")]
	public ByteString AFMFBLIACIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x2A70000", Offset = "0x2A6F400", VA = "0x182A70000", Slot = "7")]
	public void OHDJLENCJMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x2A6FE80", Offset = "0x2A6F280", VA = "0x182A6FE80", Slot = "8")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x2A6FF30", Offset = "0x2A6F330", VA = "0x182A6FF30", Slot = "9")]
	protected virtual GHCANGACFBB KLHIGFCJEJJ()
	{
		return default(GHCANGACFBB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool HPHOJGEHFPH();

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract void PMCBJCDMBLB();

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract NativeArray<EntityRemapUtility.EntityRemapInfo> CNGPPCMDHDD(NativeArray<EntityRemapUtility.EntityRemapInfo> DIHFPPJFIPL);
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[EFDJEPLIMOC(typeof(JAEEHGLCHDB), new string[] { })]
internal sealed class ALKKIJDOGFE : JAEEHGLCHDB, AKFIPDJCCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	[ONGFANECMJO]
	private AJMPOCCEJIG OIHDCKHDAJL;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public JKEPICPKEKM.AHJBHAPGIOE.DOHFJMOONME JNNPMJCEPPL
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x250EF60", Offset = "0x250E360", VA = "0x18250EF60", Slot = "4")]
		get
		{
			return default(JKEPICPKEKM.AHJBHAPGIOE.DOHFJMOONME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x250EFD0", Offset = "0x250E3D0", VA = "0x18250EFD0", Slot = "5")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public ALKKIJDOGFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal class HABJJEEFBIJ : LLEIAOFCAJL, PDOBJBPMLLM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private readonly MLHMJPANAKE NMAOCBMPAGO;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public LocalId CNJBNLEIPDC
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x28DBE10", Offset = "0x28DB210", VA = "0x1828DBE10", Slot = "6")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public IEnumerable<PIFKOMHKCPK> EAGGBJJMICA
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x251E2C0", Offset = "0x251D6C0", VA = "0x18251E2C0", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public JLLNNHEPACB OGOCPGCJELL
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x251E180", Offset = "0x251D580", VA = "0x18251E180", Slot = "5")]
		get
		{
			return default(JLLNNHEPACB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Task MJNPEKKLJJB
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x251E220", Offset = "0x251D620", VA = "0x18251E220", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public LILHPPGJGND PGKIOADFAPK
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x251E200", Offset = "0x251D600", VA = "0x18251E200", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x28DBE20", Offset = "0x28DB220", VA = "0x1828DBE20")]
	public HABJJEEFBIJ(ByteString OEKDIKJACFK, HKJKANBGCIL PHPOLCBAEBM, Action<bool> FDEGCLFOLKA, Action ANOFFPAIHNB, Action HINBKHILJBA, Action NEOLAOAJOPA, bool CGMJEPOIEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x251E1E0", Offset = "0x251D5E0", VA = "0x18251E1E0", Slot = "9")]
	public bool GFPNCFCIMGJ(LBPKNEPPDAM GKOGFPHIKMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x251E1C0", Offset = "0x251D5C0", VA = "0x18251E1C0", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
internal static class NFGJLGABCAF
{
	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x2A6EA70", Offset = "0x2A6DE70", VA = "0x182A6EA70")]
	public static GIHEDKAKMHD.HKDONGJNAAM JEMOLGCDHMA(HKJKANBGCIL PHPOLCBAEBM)
	{
		return default(GIHEDKAKMHD.HKDONGJNAAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E700", Offset = "0x2A6DB00", VA = "0x182A6E700")]
	public static NativeList<Entity> DEOAMGMPKLI(EntityManager GLPCEPPDPLB, IEnumerable<KDLENLDMBAK> KOJOICDCDNK)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E650", Offset = "0x2A6DA50", VA = "0x182A6E650")]
	public static void CNGPPCMDHDD(NativeArray<Entity> JEGIGAGHHJB, NativeList<Entity> MANNJBEFAJG, NativeArray<EntityRemapUtility.EntityRemapInfo> DIHFPPJFIPL, NativeArray<EntityRemapUtility.EntityRemapInfo> KFDLBNNHIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x2BD1A00", Offset = "0x2BD0E00", VA = "0x182BD1A00")]
	public static Entity LPOMFDAIFAP<T>(EntityManager GLPCEPPDPLB, in T KKIAKNLLHIO) where T : struct, IComponentData
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal class CNHOKCLPJFP : EGPAMILOEKO, PDOBJBPMLLM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private readonly MLHMJPANAKE NMAOCBMPAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private readonly EGBDNLKFOBI JHBIIAAOKIL;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public NPKIHKJLIJM LHOFHPLHFNF
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x7E8120", Offset = "0x7E7520", VA = "0x1807E8120", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public LocalId CNJBNLEIPDC
	{
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x251E2A0", Offset = "0x251D6A0", VA = "0x18251E2A0", Slot = "9")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Task MJNPEKKLJJB
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x251E220", Offset = "0x251D620", VA = "0x18251E220", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public IEnumerable<PIFKOMHKCPK> EAGGBJJMICA
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x251E2C0", Offset = "0x251D6C0", VA = "0x18251E2C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public JLLNNHEPACB OGOCPGCJELL
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x251E180", Offset = "0x251D580", VA = "0x18251E180", Slot = "8")]
		get
		{
			return default(JLLNNHEPACB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public LILHPPGJGND PGKIOADFAPK
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x251E200", Offset = "0x251D600", VA = "0x18251E200", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x251E2F0", Offset = "0x251D6F0", VA = "0x18251E2F0")]
	public CNHOKCLPJFP(ByteString OEKDIKJACFK, NPKIHKJLIJM AHGMBAAOHOA, in JMJABMMIMPK ANKHOKAAJLH, HKJKANBGCIL PHPOLCBAEBM, Action NEOLAOAJOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x251E260", Offset = "0x251D660", VA = "0x18251E260", Slot = "5")]
	public void OHDJLENCJMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x251E1E0", Offset = "0x251D5E0", VA = "0x18251E1E0", Slot = "12")]
	public bool GFPNCFCIMGJ(LBPKNEPPDAM GKOGFPHIKMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x251E240", Offset = "0x251D640", VA = "0x18251E240", Slot = "6")]
	public void MILFNNDJCMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x251E1C0", Offset = "0x251D5C0", VA = "0x18251E1C0", Slot = "13")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[EFDJEPLIMOC(typeof(GIFAPDPEGID), new string[] { })]
public class AIPPLGEIPLC : GIFAPDPEGID, FDGKLMNACMK, FNMJCBCJFHI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private EMFBCBAOENA PHPOLCBAEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private MLIEFKPODIE FBCPJLHEMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private PFJMBDHJHAN BDLCNPMEDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private ADBHPBOEEGG AOFNEPAGJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private NBGOAKDNEPN NNBEJFPKHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private AOONNPAOEFB FHJACJEANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private IIKMCLIAKNK FEJKNPAOBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private PGKBPEGCPKO KMPMKIKDFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private LPMPALGCIEF PJDNDHAAPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private KHCHBOKCLCH NFDNHCCMBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private EACJNKBBOAA HPJDIECPBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private EBNGCKDPAGC HPFCJJKFEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private CBFLHDPJONH ILOFLGHFJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private BKIGCJIBBEC KPHJKKGHHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private DGDICPPMDDO ODCOMKOLEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private MBJPBGDNNCH NMPOIKAOLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private LEECIPHPBNO KDMIOMMLLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private JAOEAHCDOAB EGLOAJBABMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private BGNPLHOEAII KJEMHAEPBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private HNIPNFEMKKN LJACJOOEGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private AJMPOCCEJIG EKDBECOOKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private ANLJAEDMKMC KLBBCPHGEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private bool MMLDFGNKLLJ;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public EMFBCBAOENA FNKCBJOHLDL
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x7E8110", Offset = "0x7E7510", VA = "0x1807E8110", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public MLIEFKPODIE MANJOJKJFDL
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public PFJMBDHJHAN AIOAKOJFGNH
	{
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x7E8120", Offset = "0x7E7520", VA = "0x1807E8120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public AOONNPAOEFB OFAMBFDPDBC
	{
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x94BE70", Offset = "0x94B270", VA = "0x18094BE70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public IIKMCLIAKNK HIGPLAHDIIH
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x8C2FB0", Offset = "0x8C23B0", VA = "0x1808C2FB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public PGKBPEGCPKO CJICLLCCKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x94B1A0", Offset = "0x94A5A0", VA = "0x18094B1A0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public LPMPALGCIEF CLMJPLGKAMA
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x8C1300", Offset = "0x8C0700", VA = "0x1808C1300", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public EACJNKBBOAA CKABAILNMBA
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x94A400", Offset = "0x949800", VA = "0x18094A400", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public EBNGCKDPAGC BNCGELIECNG
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x94B830", Offset = "0x94AC30", VA = "0x18094B830", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public CBFLHDPJONH DNBFJLILFCM
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x94CDE0", Offset = "0x94C1E0", VA = "0x18094CDE0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public BKIGCJIBBEC IIJFBCCMPBK
	{
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x91F290", Offset = "0x91E690", VA = "0x18091F290", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public DGDICPPMDDO LLNIBAPEILO
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x94CE00", Offset = "0x94C200", VA = "0x18094CE00", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public MBJPBGDNNCH MMCANDAFKLO
	{
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x8C3110", Offset = "0x8C2510", VA = "0x1808C3110", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public LEECIPHPBNO OPCNKLIEFBL
	{
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x94B230", Offset = "0x94A630", VA = "0x18094B230", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public JAOEAHCDOAB MBGPLLABIDL
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0xA49860", Offset = "0xA48C60", VA = "0x180A49860", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public BGNPLHOEAII KLBCJPHKOBO
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x9EA9A0", Offset = "0x9E9DA0", VA = "0x1809EA9A0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public HNIPNFEMKKN OOGPGPFEINH
	{
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x9F76E0", Offset = "0x9F6AE0", VA = "0x1809F76E0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public AJMPOCCEJIG LFCPLAFINOB
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x8C3DA0", Offset = "0x8C31A0", VA = "0x1808C3DA0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public ANLJAEDMKMC COPHCJCEHIG
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x9924A0", Offset = "0x9918A0", VA = "0x1809924A0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public AIDFLENHCFG MBAGIEMANEG
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x9EA990", Offset = "0x9E9D90", VA = "0x1809EA990", Slot = "23")]
		get
		{
			return default(AIDFLENHCFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x250EB60", Offset = "0x250DF60", VA = "0x18250EB60", Slot = "24")]
	public void BDMFHPOGKDD(EMFBCBAOENA CHPNHBOHJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x250EE70", Offset = "0x250E270", VA = "0x18250EE70", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x250EB40", Offset = "0x250DF40", VA = "0x18250EB40", Slot = "25")]
	public void AGEJNEJCHBN(EMFBCBAOENA CHPNHBOHJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public AIPPLGEIPLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[EFDJEPLIMOC(typeof(MLIEFKPODIE), new string[] { })]
public class PGCDEKHNPEN : MLIEFKPODIE, AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public OCIGMOAGHIJ CBDOGBLGAKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x7E8110", Offset = "0x7E7510", VA = "0x1807E8110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x7F3140", Offset = "0x7F2540", VA = "0x1807F3140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private HAGBJEJOLJL MLHEOLJMGID
	{
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x7F3110", Offset = "0x7F2510", VA = "0x1807F3110")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private EBCPMJGAKEI OLLPHEAPOBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x7F2C10", Offset = "0x7F2010", VA = "0x1807F2C10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private LJKNMEOKCJF KMNAMELHGJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x7F3120", Offset = "0x7F2520", VA = "0x1807F3120")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public MILFLABAMPI FKDHDBNPPAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x8BC350", Offset = "0x8BB750", VA = "0x1808BC350", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x940BC0", Offset = "0x93FFC0", VA = "0x180940BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public CMEBPNCBCMD PBEFJDJDDEC
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x94BE70", Offset = "0x94B270", VA = "0x18094BE70", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x94BE50", Offset = "0x94B250", VA = "0x18094BE50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public NIOKIOAHGMB AEBPHNIBJDD
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x8C2FB0", Offset = "0x8C23B0", VA = "0x1808C2FB0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x94CDF0", Offset = "0x94C1F0", VA = "0x18094CDF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public IAMHJKNKNMA KFANDOBJIAD
	{
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x94B1A0", Offset = "0x94A5A0", VA = "0x18094B1A0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x94B820", Offset = "0x94AC20", VA = "0x18094B820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public IIONFMDPDBM ALCFCGLIOEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x8C1300", Offset = "0x8C0700", VA = "0x1808C1300", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x8D19B0", Offset = "0x8D0DB0", VA = "0x1808D19B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public KBLGMDKDIMA BDEFBAGPIHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x94A3F0", Offset = "0x9497F0", VA = "0x18094A3F0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x94A450", Offset = "0x949850", VA = "0x18094A450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public LGOEJMHMEMO KEGIGPILKGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x94A400", Offset = "0x949800", VA = "0x18094A400", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x94B840", Offset = "0x94AC40", VA = "0x18094B840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	private AJDMCFNBEEO HBFNPMBNJCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x94CE10", Offset = "0x94C210", VA = "0x18094CE10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public LOIFKPOLLGP MPDELMHGDGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x94CDE0", Offset = "0x94C1E0", VA = "0x18094CDE0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x94B180", Offset = "0x94A580", VA = "0x18094B180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	private HKFAIGLNOBD IIJFBCCMPBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x98D750", Offset = "0x98CB50", VA = "0x18098D750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	private JGJJAGMGKPI OPFEAPJFNBB
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x94C610", Offset = "0x94BA10", VA = "0x18094C610")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x222F460", Offset = "0x222E860", VA = "0x18222F460", Slot = "13")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public PGCDEKHNPEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[DefaultMember("Item")]
public class MNANJHMNEJL : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class JEKINDFEOEH : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public MNANJHMNEJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private int <indexOffset>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private int <intCount>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private ulong <value>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private int <index>5__5;

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		int IEnumerator<int>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000524")]
			[Cpp2IlInjected.Address(RVA = "0x9CDAB0", Offset = "0x9CCEB0", VA = "0x1809CDAB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000526")]
			[Cpp2IlInjected.Address(RVA = "0x27118E0", Offset = "0x2710CE0", VA = "0x1827118E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0xA21140", Offset = "0xA20540", VA = "0x180A21140")]
		[DebuggerHidden]
		public JEKINDFEOEH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x2711720", Offset = "0x2710B20", VA = "0x182711720", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x27118A0", Offset = "0x2710CA0", VA = "0x1827118A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private readonly List<ulong> LMMDEMDIJBL;

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public int NPBPHODFKMP
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x9C0750", Offset = "0x9BFB50", VA = "0x1809C0750")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x2A6AD80", Offset = "0x2A6A180", VA = "0x182A6AD80")]
	public MNANJHMNEJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x2A6AD10", Offset = "0x2A6A110", VA = "0x182A6AD10", Slot = "4")]
	[IteratorStateMachine(typeof(JEKINDFEOEH))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x2A6AD10", Offset = "0x2A6A110", VA = "0x182A6AD10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public static class NICKNDFANJM
{
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	public static readonly ComponentType[] LFMNJHOLOJG;

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x2A6EC40", Offset = "0x2A6E040", VA = "0x182A6EC40")]
	public static Entity DNKDHNFECDG(this EntityManager GLPCEPPDPLB)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public sealed class FECMDPHHGCH<T> : IGCDAKECFML<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x1947D50", Offset = "0x1947150", VA = "0x181947D50")]
	public FECMDPHHGCH(T JMCICGNCKGD, T NMNMMIHHPBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[EFDJEPLIMOC(typeof(NMANAGPHMFF), new string[] { })]
public sealed class DOJLBJAPLMH : NMANAGPHMFF, HDFALLAHAME<NMANAGPHMFF>, DEPDOFHIDBA, AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private readonly Dictionary<GLFLLKHPAHK, ALDCMKEKMHG> HHLACOBBFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private OGJBLKABFKO MJLODINJDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private ABLEKJPBMJE NFDNHCCMBMJ;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool LKMHKNMJEJB
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x977980", Offset = "0x976D80", VA = "0x180977980")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x252B2C0", Offset = "0x252A6C0", VA = "0x18252B2C0")]
	public DOJLBJAPLMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x252B0A0", Offset = "0x252A4A0", VA = "0x18252B0A0", Slot = "5")]
	public void MCOOCEGHCPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x252B020", Offset = "0x252A420", VA = "0x18252B020", Slot = "6")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x252B100", Offset = "0x252A500", VA = "0x18252B100", Slot = "4")]
	public bool NALDPHOGDDM(GLFLLKHPAHK MLGAFKBKMCE, out ALDCMKEKMHG BGHJBFABJHA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
[EFDJEPLIMOC(typeof(OGJBLKABFKO), new string[] { })]
internal sealed class OGJBLKABFKO : DEPDOFHIDBA
{
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	private readonly Dictionary<Type, ALDCMKEKMHG> HHLACOBBFMI;

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x2A744C0", Offset = "0x2A738C0", VA = "0x182A744C0", Slot = "4")]
	public void MCOOCEGHCPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x2A743B0", Offset = "0x2A737B0", VA = "0x182A743B0")]
	public void FIMKNKKCEGK(Type JLNNFEOBAMK, ALDCMKEKMHG BGHJBFABJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x2A74510", Offset = "0x2A73910", VA = "0x182A74510")]
	public bool NALDPHOGDDM(Type JLNNFEOBAMK, out ALDCMKEKMHG BGHJBFABJHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x2A74680", Offset = "0x2A73A80", VA = "0x182A74680")]
	public OGJBLKABFKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class MIDFMCDNKCO
{
	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x2A65F80", Offset = "0x2A65380", VA = "0x182A65F80")]
	public static void FIMKNKKCEGK(this OGJBLKABFKO OBOAIKCPODL, ALDCMKEKMHG BGHJBFABJHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class IGCDAKECFML<T> : EOAJDNCBEDL<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	protected GPJLDEBNJCD<T> AONKELMKJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	protected GIPLGEADADM<T> OGIICMCEAJN;

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0xEFD960", Offset = "0xEFCD60", VA = "0x180EFD960")]
	public IGCDAKECFML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0xEFD990", Offset = "0xEFCD90", VA = "0x180EFD990")]
	public IGCDAKECFML(GPJLDEBNJCD<T> AONKELMKJBI, GIPLGEADADM<T> OGIICMCEAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0xEFD620", Offset = "0xEFCA20", VA = "0x180EFD620", Slot = "10")]
	protected override T LFPLIBEJFBF(ref BEGJGPBPAMC IKAHLLCDMBG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0xEFD270", Offset = "0xEFC670", VA = "0x180EFD270", Slot = "11")]
	protected override void IBKPGJDIIJI(ref OHCCHEPHCOE FLKCFLIMMIK, T KKIAKNLLHIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public static class IGMOCGKLANM
{
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[EFDJEPLIMOC(typeof(EHFICGMFONF), new string[] { })]
internal sealed class GJNGAMLBDIF : EHFICGMFONF, DEPDOFHIDBA, AKFIPDJCCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private readonly Dictionary<GLFLLKHPAHK, MEGKNEHDLON> OKHDMCJAONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private ABLEKJPBMJE NFDNHCCMBMJ;

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x28D76E0", Offset = "0x28D6AE0", VA = "0x1828D76E0", Slot = "6")]
	public void MCOOCEGHCPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x28D7680", Offset = "0x28D6A80", VA = "0x1828D7680", Slot = "7")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x28D7610", Offset = "0x28D6A10", VA = "0x1828D7610", Slot = "4")]
	public void FIMKNKKCEGK(GLFLLKHPAHK KOAJDKDANHI, Type MAFHOOIMPEH, MEGKNEHDLON HKOCODKCJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x28D75A0", Offset = "0x28D69A0", VA = "0x1828D75A0", Slot = "5")]
	public bool EHAFFDDLPBM(GLFLLKHPAHK KOAJDKDANHI, out MEGKNEHDLON HKOCODKCJEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x28D7730", Offset = "0x28D6B30", VA = "0x1828D7730")]
	public GJNGAMLBDIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[EFDJEPLIMOC(typeof(ILIBONIKHOI), new string[] { })]
internal sealed class NEILIJFEAHB : ILIBONIKHOI, AKFIPDJCCOH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	[ONGFANECMJO]
	private ABLEKJPBMJE NFDNHCCMBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	private NativeBitArray CMCLOPFEMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private NativeParallelHashMap<CMFFIMLEPBE, int> BPEAFMFCBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	private NativeList<int> IMKODGIOIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private int PEEIDNCNAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	private int FBCHFOPMOMF;

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public bool EHMEEIIOBGG
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x2A6DE50", Offset = "0x2A6D250", VA = "0x182A6DE50", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public NGMJNNOBIHE FGOJMECAJGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x2A6DB60", Offset = "0x2A6CF60", VA = "0x182A6DB60", Slot = "7")]
		get
		{
			return default(NGMJNNOBIHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x2A6DDD0", Offset = "0x2A6D1D0", VA = "0x182A6DDD0", Slot = "4")]
	public bool HKNFLDAFCFK(CMFFIMLEPBE AIOICCOKGOP, GLFLLKHPAHK HNNIGEFAIIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E0F0", Offset = "0x2A6D4F0", VA = "0x182A6E0F0", Slot = "8")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x2A6DC40", Offset = "0x2A6D040", VA = "0x182A6DC40", Slot = "6")]
	public void GMFDEDBBEAF(NativeArray<CMFFIMLEPBE> MAEMAKOHEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x2A6DE70", Offset = "0x2A6D270", VA = "0x182A6DE70", Slot = "5")]
	public void INPFIBIHNMF(CMFFIMLEPBE AIOICCOKGOP, Span<GLFLLKHPAHK> NFDNHCCMBMJ, bool FJHKHBKNEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x2A6DBB0", Offset = "0x2A6CFB0", VA = "0x182A6DBB0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public NEILIJFEAHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[EFDJEPLIMOC(typeof(CJNHILKEKFP), new string[] { })]
public class HMGAAFGBKAI : CJNHILKEKFP, AKFIPDJCCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	[ONGFANECMJO]
	private KBLGMDKDIMA FBCPJLHEMAI;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	private uint DKNBOACFPLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x287C0C0", Offset = "0x287B4C0", VA = "0x18287C0C0", Slot = "4")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x287C110", Offset = "0x287B510", VA = "0x18287C110", Slot = "5")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public HMGAAFGBKAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public abstract class DEEACGMFFCG : ALDCMKEKMHG
{
	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public abstract Type BNMJEFLPMCL
	{
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void LFPLIBEJFBF(ref BEGJGPBPAMC IKAHLLCDMBG, Span<byte> KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void IBKPGJDIIJI(ref OHCCHEPHCOE FLKCFLIMMIK, ReadOnlySpan<byte> KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	protected DEEACGMFFCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public abstract class EOAJDNCBEDL<T> : DEEACGMFFCG where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public override Type BNMJEFLPMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x1EFE190", Offset = "0x1EFD590", VA = "0x181EFE190", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract T LFPLIBEJFBF(ref BEGJGPBPAMC IKAHLLCDMBG);

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract void IBKPGJDIIJI(ref OHCCHEPHCOE FLKCFLIMMIK, T KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x1EFEC20", Offset = "0x1EFE020", VA = "0x181EFEC20", Slot = "8")]
	public override void LFPLIBEJFBF(ref BEGJGPBPAMC IKAHLLCDMBG, Span<byte> GDNOLIODDHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x1EFD8B0", Offset = "0x1EFCCB0", VA = "0x181EFD8B0", Slot = "9")]
	public override void IBKPGJDIIJI(ref OHCCHEPHCOE FLKCFLIMMIK, ReadOnlySpan<byte> CANIEFMHGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x1EFEF40", Offset = "0x1EFE340", VA = "0x181EFEF40")]
	protected EOAJDNCBEDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
internal static class OOCAJGPOFDB
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public struct PGACPGAILCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public AOONNPAOEFB FHJACJEANIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public ABLEKJPBMJE PEJCBLOKAEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public JKPBDEIBINB DJGFELMBIFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public ILIBONIKHOI CDIHHIPDEOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public MGGIKJGDIFI PALNDCFDCLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public NMANAGPHMFF HHLACOBBFMI;

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x3DE6BA0", Offset = "0x3DE5FA0", VA = "0x183DE6BA0")]
		public void BFCHCMHGCOO(EMFBCBAOENA PHPOLCBAEBM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public struct JBNPJDKPNAO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public NativeList<CMFFIMLEPBE> LMKFIAKIJAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public NativeList<EFFOMHNHCBO> JONOBDJBMLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public NativeList<CMFFIMLEPBE> KNDKMEFEGCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public NativeParallelMultiHashMap<CMFFIMLEPBE, GPPEENBHCHN> NFDNHCCMBMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public NativeList<byte> FFDMFKPKOKB;

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public bool JFMHMLHFLCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000563")]
			[Cpp2IlInjected.Address(RVA = "0x3DE6640", Offset = "0x3DE5A40", VA = "0x183DE6640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x3DE65A0", Offset = "0x3DE59A0", VA = "0x183DE65A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private struct MJLCFEHFGIL : IComparer<GPPEENBHCHN>
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x3DE6A50", Offset = "0x3DE5E50", VA = "0x183DE6A50", Slot = "4")]
		public int Compare(GPPEENBHCHN GEAEMIOLNKK, GPPEENBHCHN KFMHCNGHPHP)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000272")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	private static readonly PILIJFIMAJF GKJGFBACJED;

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x222ACB0", Offset = "0x222A0B0", VA = "0x18222ACB0")]
	public static void DJGNINPPIFL(ref OHCCHEPHCOE FLKCFLIMMIK, JBNPJDKPNAO KJFNAECAHBA, PGACPGAILCB PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x222AF50", Offset = "0x222A350", VA = "0x18222AF50")]
	public static JBNPJDKPNAO GOPFGMBEHNK(ref BEGJGPBPAMC IKAHLLCDMBG, Allocator GMMIODGPFPJ, PGACPGAILCB PHPOLCBAEBM)
	{
		return default(JBNPJDKPNAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x222B4D0", Offset = "0x222A8D0", VA = "0x18222B4D0")]
	public static void MMHHMMDEGLF(JBNPJDKPNAO KJFNAECAHBA, PGACPGAILCB PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x222A9C0", Offset = "0x2229DC0", VA = "0x18222A9C0")]
	public static void BIJDMGPCPAN(JBNPJDKPNAO KJFNAECAHBA, PGACPGAILCB PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x222B330", Offset = "0x222A730", VA = "0x18222B330")]
	public static int KFAEEJMKIPF(JBNPJDKPNAO KJFNAECAHBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x222B270", Offset = "0x222A670", VA = "0x18222B270")]
	private static void IGLJPCCOKMH(ref OHCCHEPHCOE FLKCFLIMMIK, NativeArray<CMFFIMLEPBE> LMKFIAKIJAP, NativeArray<EFFOMHNHCBO> JONOBDJBMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x222C3C0", Offset = "0x222B7C0", VA = "0x18222C3C0")]
	private static void OHIBOHJNAIB(ref BEGJGPBPAMC IKAHLLCDMBG, Allocator GMMIODGPFPJ, out NativeList<CMFFIMLEPBE> LMKFIAKIJAP, out NativeList<EFFOMHNHCBO> HEIKIGLIBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x222B860", Offset = "0x222AC60", VA = "0x18222B860")]
	private static void MNENJHPNGLH(ref OHCCHEPHCOE FLKCFLIMMIK, NativeArray<CMFFIMLEPBE> KNDKMEFEGCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x222A8C0", Offset = "0x2229CC0", VA = "0x18222A8C0")]
	private static void BBAAHABELNH(ref BEGJGPBPAMC IKAHLLCDMBG, Allocator GMMIODGPFPJ, out NativeList<CMFFIMLEPBE> KNDKMEFEGCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x222B8F0", Offset = "0x222ACF0", VA = "0x18222B8F0")]
	private static void NDGCCIJPAMJ(ref OHCCHEPHCOE FLKCFLIMMIK, NativeParallelMultiHashMap<CMFFIMLEPBE, GPPEENBHCHN> NFDNHCCMBMJ, NativeList<byte> FFDMFKPKOKB, PGACPGAILCB PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x222C550", Offset = "0x222B950", VA = "0x18222C550")]
	private static void PGBBMCBJPJN(ref BEGJGPBPAMC IKAHLLCDMBG, Allocator GMMIODGPFPJ, out NativeParallelMultiHashMap<CMFFIMLEPBE, GPPEENBHCHN> NFDNHCCMBMJ, out NativeList<byte> FFDMFKPKOKB, PGACPGAILCB PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x222C3A0", Offset = "0x222B7A0", VA = "0x18222C3A0")]
	private static void NMBAJFFIGIE(int PKIIAPNCOAK, ref int NEPNLICNGKA, ref OHCCHEPHCOE FLKCFLIMMIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x222B4B0", Offset = "0x222A8B0", VA = "0x18222B4B0")]
	private static int MCCCADOIHPN(int NEPNLICNGKA, ref BEGJGPBPAMC IKAHLLCDMBG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal static class CGIIJJOJDFP
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private class LFPEPNOPEGA
	{
		[Cpp2IlInjected.Token(Token = "0x20000C5")]
		[CompilerGenerated]
		private sealed class GEPKBKPCGND<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400027F")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x6000570")]
			[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
			public GEPKBKPCGND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000571")]
			[Cpp2IlInjected.Address(RVA = "0x2129EB0", Offset = "0x21292B0", VA = "0x182129EB0")]
			internal void LOGKHMEIMHO(ref OHCCHEPHCOE writer, T value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000572")]
			[Cpp2IlInjected.Address(RVA = "0x2129BD0", Offset = "0x2128FD0", VA = "0x182129BD0")]
			internal T HNNJMGJLJCD(ref BEGJGPBPAMC reader)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x2713C60", Offset = "0x2713060", VA = "0x182713C60")]
		public static void BEMNGOPNAJD(OGJBLKABFKO HHLACOBBFMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x264FE00", Offset = "0x264F200", VA = "0x18264FE00")]
		private static void FJANJJDLIOF<T>(OGJBLKABFKO HHLACOBBFMI, int NMNMMIHHPBN) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x26505D0", Offset = "0x264F9D0", VA = "0x1826505D0")]
		private static void NCACMABMFDK<T>(ref OHCCHEPHCOE FLKCFLIMMIK, T GCKJNKPJMJF, int NMNMMIHHPBN) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x264FF20", Offset = "0x264F320", VA = "0x18264FF20")]
		private static T JMFBDJHHBLE<T>(ref BEGJGPBPAMC IKAHLLCDMBG, int NMNMMIHHPBN) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public LFPEPNOPEGA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	private class DONNPNOLCAG : BKPKBMIEPDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private OGJBLKABFKO HHLACOBBFMI;

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x264F1D0", Offset = "0x264E5D0", VA = "0x18264F1D0", Slot = "6")]
		public override void ANNBAKEJHBN<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x270A430", Offset = "0x2709830", VA = "0x18270A430")]
		public static void JBKGELNMPFD(OGJBLKABFKO HHLACOBBFMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x270A4E0", Offset = "0x27098E0", VA = "0x18270A4E0")]
		public DONNPNOLCAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x2518740", Offset = "0x2517B40", VA = "0x182518740")]
	public static void EDJKNJLCPIJ(OGJBLKABFKO HHLACOBBFMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x251A1A0", Offset = "0x25195A0", VA = "0x18251A1A0")]
	private static void ENLHGLABBFA(ref OHCCHEPHCOE EFCIMGFJGNL, quaternion GCKJNKPJMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x251A2A0", Offset = "0x25196A0", VA = "0x18251A2A0")]
	private static quaternion FLJHLJHFHEC(ref BEGJGPBPAMC OBNCFODAOCD)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x1CE9150", Offset = "0x1CE8550", VA = "0x181CE9150")]
	public static void IEMOJFOMLFA<T>(OGJBLKABFKO HHLACOBBFMI, GPJLDEBNJCD<T> AONKELMKJBI, GIPLGEADADM<T> OGIICMCEAJN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x1CE90E0", Offset = "0x1CE84E0", VA = "0x181CE90E0")]
	public static void EHCLHKKIGMI<T>(OGJBLKABFKO BGHJBFABJHA) where T : struct, EKKONKFFCGH
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[EFDJEPLIMOC(typeof(CPCDMMFNECK), new string[] { })]
internal class DHJOEOMNBIP : AKFIPDJCCOH, CPCDMMFNECK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	[ONGFANECMJO]
	private CJNHILKEKFP IMMGGKGMOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	private IKINGBNPGOH LKDJJILLMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	private int NLCIICGPEBE;

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x2522C70", Offset = "0x2522070", VA = "0x182522C70", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x2522AC0", Offset = "0x2521EC0", VA = "0x182522AC0", Slot = "5")]
	public EBBOOPFABOA AMPNCDLCDAG(ReadOnlySpan<byte> KBLLMJIHKAK)
	{
		return default(EBBOOPFABOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x2522C60", Offset = "0x2522060", VA = "0x182522C60", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public DHJOEOMNBIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[EFDJEPLIMOC(typeof(MGGIKJGDIFI), new string[] { })]
public class MKLJGPBDDHJ : MGGIKJGDIFI, DEPDOFHIDBA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	private EMFFPKIJPCM LMLGDLIKOIO;

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x2A674A0", Offset = "0x2A668A0", VA = "0x182A674A0", Slot = "8")]
	public void MCOOCEGHCPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x2A67030", Offset = "0x2A66430", VA = "0x182A67030", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x2A67540", Offset = "0x2A66940", VA = "0x182A67540", Slot = "4")]
	public void MMHHMMDEGLF(CMFFIMLEPBE BGPCGOEKFEF, GLFLLKHPAHK KOAJDKDANHI, ReadOnlySpan<byte> EBBFFECDKCH, ReadOnlySpan<byte> MKKPKAKGCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x2A676A0", Offset = "0x2A66AA0", VA = "0x182A676A0", Slot = "7")]
	public bool PKGEJCODJKP(CMFFIMLEPBE BGPCGOEKFEF, GLFLLKHPAHK KOAJDKDANHI, Span<byte> EBBFFECDKCH, Span<byte> MKKPKAKGCKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x2A66FD0", Offset = "0x2A663D0", VA = "0x182A66FD0", Slot = "5")]
	public bool APOGAKKJDFP(CMFFIMLEPBE BGPCGOEKFEF, GLFLLKHPAHK KOAJDKDANHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x2A66FF0", Offset = "0x2A663F0", VA = "0x182A66FF0", Slot = "6")]
	public bool BIJDMGPCPAN(CMFFIMLEPBE BGPCGOEKFEF, GLFLLKHPAHK KOAJDKDANHI, ReadOnlySpan<byte> MKKPKAKGCKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x2A67040", Offset = "0x2A66440", VA = "0x182A67040")]
	private bool GCGPFJGKHGN(CMFFIMLEPBE BGPCGOEKFEF, GLFLLKHPAHK KOAJDKDANHI, ReadOnlySpan<byte> MKKPKAKGCKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public MKLJGPBDDHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class KLGNFGEFJFI<T> : EOAJDNCBEDL<T> where T : struct, EKKONKFFCGH
{
	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x2218F50", Offset = "0x2218350", VA = "0x182218F50", Slot = "10")]
	protected override T LFPLIBEJFBF(ref BEGJGPBPAMC IKAHLLCDMBG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x2218E30", Offset = "0x2218230", VA = "0x182218E30", Slot = "11")]
	protected override void IBKPGJDIIJI(ref OHCCHEPHCOE FLKCFLIMMIK, T KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x1E17BF0", Offset = "0x1E16FF0", VA = "0x181E17BF0")]
	public KLGNFGEFJFI()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
	public class PhysicsSceneAddCollidersSystem : JKIEMPJPHGI, AKFIPDJCCOH
	{
		[Cpp2IlInjected.Token(Token = "0x20000CC")]
		private struct PhysicsSceneAddCollidersSystem_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002A8")]
			public PhysicsSceneAddCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002A9")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002AA")]
			[ReadOnly]
			public EntityTypeHandle __eTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0x3DE6C90", Offset = "0x3DE6090", VA = "0x183DE6C90")]
			private void EJBLFCAPFKM(Entity e)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x3DE6D90", Offset = "0x3DE6190", VA = "0x183DE6D90", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private BFAEKJANJNA ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private PGEMHDJNMBJ colliderService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private EntityQuery PhysicsSceneAddCollidersSystem_Query;

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x22363F0", Offset = "0x22357F0", VA = "0x1822363F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x2236190", Offset = "0x2235590", VA = "0x182236190", Slot = "14")]
		public void InitReferences(EMFBCBAOENA services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x2236450", Offset = "0x2235850", VA = "0x182236450", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x22360A0", Offset = "0x22354A0", VA = "0x1822360A0")]
		private void IFBKICPKOBI(ref EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x22361F0", Offset = "0x22355F0", VA = "0x1822361F0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
		public PhysicsSceneAddCollidersSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal class JKEAPDGKBOM : PCOIJKOLHMH
{
	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	protected override GCGDNGNDAMG LBPOJFOKAEB
	{
		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x7F35A0", Offset = "0x7F29A0", VA = "0x1807F35A0", Slot = "17")]
		get
		{
			return default(GCGDNGNDAMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x288D780", Offset = "0x288CB80", VA = "0x18288D780")]
	public JKEAPDGKBOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public class OMNGLGJLHAE : JKIEMPJPHGI
{
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[BurstCompile]
	private struct FONHAPFEEPD : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		[ReadOnly]
		public ComponentTypeHandle<BOIDEJCAFGI> NEJBCFEPCHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public ComponentTypeHandle<HNDLOHCHOMJ> GCILBALGIJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public ComponentTypeHandle<NEPPICPDJAN> OGKJFGGOPCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public ComponentTypeHandle<IGJCCCPFMIK> IIODBOAHIOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public uint COFHBFKJOIM;

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x3DE6170", Offset = "0x3DE5570", VA = "0x183DE6170", Slot = "4")]
		public void Execute(ArchetypeChunk NCPBFICMLEP, int NANJAGEOPJI, int OACOHOELHFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x3DE60E0", Offset = "0x3DE54E0", VA = "0x183DE60E0")]
		public bool BEBJJPJJHPD(ArchetypeChunk NCPBFICMLEP)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	private EntityQuery KMPMKIKDFIP;

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x222A100", Offset = "0x2229500", VA = "0x18222A100", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x222A210", Offset = "0x2229610", VA = "0x18222A210", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public OMNGLGJLHAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
public sealed class PGHFBHFJDCC : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	private CEJCPOECKAC MLODHIKJENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	private EGBDNLKFOBI JHBIIAAOKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	private NICJNOMPEDE GKOGFPHIKMK;

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x222FB00", Offset = "0x222EF00", VA = "0x18222FB00", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x222FB90", Offset = "0x222EF90", VA = "0x18222FB90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public PGHFBHFJDCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public sealed class APIMOOLCNOO : HLOJAODEAAM
{
	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(RVA = "0x2510860", Offset = "0x250FC60", VA = "0x182510860", Slot = "15")]
	protected override ComponentSystemBase BHJHPJOJPMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x2229A50", Offset = "0x2228E50", VA = "0x182229A50")]
	public APIMOOLCNOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[EFDJEPLIMOC(typeof(BKFELPACBKA), new string[] { })]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
internal class BKFELPACBKA : CBKELFDIEEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	private POICFBHIEPP<GBNALMICONM, FNBFFOBOBID, GMDDLLEBDJO, NCPFCBDGLKK> HPCLGKAKGHC;

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x2514360", Offset = "0x2513760", VA = "0x182514360", Slot = "4")]
	public void JFCLKDMBJND(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public BKFELPACBKA()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	public class PreSerializeTransformRoots : JKIEMPJPHGI
	{
		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		[NoAlias]
		[BurstCompile]
		private struct PreSerializeTransformRoots_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002BA")]
			public RigidTransform pose;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40002BB")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002BC")]
			public ComponentTypeHandle<KPMOMMGMLCH> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0x3DE4280", Offset = "0x3DE3680", VA = "0x183DE4280")]
			private void EJBLFCAPFKM([NoAlias] ref KPMOMMGMLCH data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0x3DE9990", Offset = "0x3DE8D90", VA = "0x183DE9990", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		[BurstCompile]
		[NoAlias]
		private struct PreSerializeTransformRoots_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002BD")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002BE")]
			public ComponentTypeHandle<ANCGJKBPAIA> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0x3DE2EE0", Offset = "0x3DE22E0", VA = "0x183DE2EE0")]
			private void EJBLFCAPFKM([NoAlias] ref ANCGJKBPAIA data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x3DE9A60", Offset = "0x3DE8E60", VA = "0x183DE9A60", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private EntityQuery PreSerializeTransformRoots_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private EntityQuery PreSerializeTransformRoots_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private EntityQuery __query_2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private ComponentTypeHandle<KPMOMMGMLCH> __RecRoom_Components_LocalPoseData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private ComponentTypeHandle<ANCGJKBPAIA> __RecRoom_Components_LocalUniformScaleData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x2240850", Offset = "0x223FC50", VA = "0x182240850", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x22400F0", Offset = "0x223F4F0", VA = "0x1822400F0")]
		private void JHFLOMEDIBC(in JHHGOKLOOPH transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x223FEA0", Offset = "0x223F2A0", VA = "0x18223FEA0")]
		private JobHandle DKPJFAFMAHN(RigidTransform pose, float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x223FFE0", Offset = "0x223F3E0", VA = "0x18223FFE0")]
		private JobHandle GOJBEEKNAEM(float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x2240310", Offset = "0x223F710", VA = "0x182240310", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
		public PreSerializeTransformRoots()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
internal sealed class AHMOMHOFNJA : HLOJAODEAAM
{
	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x250EAF0", Offset = "0x250DEF0", VA = "0x18250EAF0", Slot = "15")]
	protected override ComponentSystemBase BHJHPJOJPMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x2229A50", Offset = "0x2228E50", VA = "0x182229A50")]
	public AHMOMHOFNJA()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[AlwaysUpdateSystem]
	[CompilerGenerated]
	[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
	public class PhysicsSceneRemoveCollidersSystem : JKIEMPJPHGI, AKFIPDJCCOH
	{
		[Cpp2IlInjected.Token(Token = "0x20000D8")]
		private struct PhysicsSceneRemoveCollidersSystem_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C3")]
			public PhysicsSceneRemoveCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002C4")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002C5")]
			[ReadOnly]
			public EntityTypeHandle __eTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40002C6")]
			[ReadOnly]
			public ComponentTypeHandle<CJPEPCAHCNO> __chTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x3DE6E40", Offset = "0x3DE6240", VA = "0x183DE6E40")]
			private void EJBLFCAPFKM(Entity e, in CJPEPCAHCNO ch)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0x3DE6F40", Offset = "0x3DE6340", VA = "0x183DE6F40", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private BFAEKJANJNA ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private PGEMHDJNMBJ colliderService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private EntityQuery PhysicsSceneRemoveCollidersSystem_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private ComponentTypeHandle<CJPEPCAHCNO> __RecRoom_ObjectModel_Systems_PhysicsSceneColliderHandleData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x22367F0", Offset = "0x2235BF0", VA = "0x1822367F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x2236550", Offset = "0x2235950", VA = "0x182236550", Slot = "14")]
		public void InitReferences(EMFBCBAOENA services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x2236850", Offset = "0x2235C50", VA = "0x182236850", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x22369B0", Offset = "0x2235DB0", VA = "0x1822369B0")]
		private void PEIHKFBEJFF(ref EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x22365B0", Offset = "0x22359B0", VA = "0x1822365B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
		public PhysicsSceneRemoveCollidersSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public class AHKHGHPHNFA : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[BurstCompile]
	private struct DPNKPFPGIKL : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		[ReadOnly]
		public NativeArray<GFPIBEIJMOG> GFJFJJGOLFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		[ReadOnly]
		public NativeArray<Entity> PGJLMFPAKDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public ComponentDataFromEntity KOKONPBGHBF;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x270B1F0", Offset = "0x270A5F0", VA = "0x18270B1F0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[BurstCompile]
	private struct LPCCDKEFBKB : IJob, INativeDisposable, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		[ReadOnly]
		public NativeParallelHashMap<int, Entity> EONAKMICEKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		[ReadOnly]
		public NativeParallelHashMap<int, EntityArchetype> HENMFHFNKOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		[ReadOnly]
		public NativeParallelHashMap<int, int> PAHCJFHHFDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		[ReadOnly]
		public NativeArray<ArchetypeChunk> NKDLKMCJIGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		[ReadOnly]
		public SharedComponentTypeHandle<RRObjectPrefabV2Data> PLNLPDHJOPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public NativeList<EntityArchetype> GNFDOHCFMAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public NativeList<EntityArchetype> PFDJBLFOOLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public NativeList<NDLCDGPEBGB> PFHLHLNEEEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public NativeList<NDLCDGPEBGB> EKDLCPMGLMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public NativeList<GFPIBEIJMOG> INCFFFELOOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public NativeList<ComponentType> DLFDEDPKHME;

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x2714950", Offset = "0x2713D50", VA = "0x182714950", Slot = "6")]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x2713F90", Offset = "0x2713390", VA = "0x182713F90", Slot = "5")]
		public JobHandle Dispose(JobHandle PPCGBBAKOHO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x2714190", Offset = "0x2713590", VA = "0x182714190", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x27146B0", Offset = "0x2713AB0", VA = "0x1827146B0")]
		private int LLOMJCHCILB(NDLCDGPEBGB JNFNFIHGOAI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x2714750", Offset = "0x2713B50", VA = "0x182714750")]
		private bool MNPIGAPHDCI(int LOODPOAGNPC, EntityArchetype ILMMFBCFJAG, out EntityArchetype GPMIEFPBAMI, out Entity LEJHCBCAPAM)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[BurstCompile]
	private struct BKNNGBLFIHI : IComparer<GFPIBEIJMOG>
	{
		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x2708B60", Offset = "0x2707F60", VA = "0x182708B60", Slot = "4")]
		public int Compare(GFPIBEIJMOG GEAEMIOLNKK, GFPIBEIJMOG KFMHCNGHPHP)
		{
			return default(int);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[BurstCompile]
	private struct KPPIDMNEELI : CFICKDFMDBF<GFPIBEIJMOG, int>
	{
		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x1A45BF0", Offset = "0x1A44FF0", VA = "0x181A45BF0")]
		public int MIOHAAIMNDI(in GFPIBEIJMOG CDNLFOGBLLG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x1A45BF0", Offset = "0x1A44FF0", VA = "0x181A45BF0", Slot = "4")]
		private int POLLHPHOCJP(in GFPIBEIJMOG KKIAKNLLHIO)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	private struct GFPIBEIJMOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public Entity LEJHCBCAPAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public NDLCDGPEBGB PGJLMFPAKDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public int OAOBCIJDDNK;
	}

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private EntityQuery PNGFJEAJDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	private GNCJLPLLPLA EDNPFADAINI;

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x250DB00", Offset = "0x250CF00", VA = "0x18250DB00", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x250E380", Offset = "0x250D780", VA = "0x18250E380", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x250E430", Offset = "0x250D830", VA = "0x18250E430", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x250DB50", Offset = "0x250CF50", VA = "0x18250DB50")]
	private LPCCDKEFBKB KKHDJOKOICI(NativeArray<ArchetypeChunk> FPBMIPLJIKG)
	{
		return default(LPCCDKEFBKB);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x250DE00", Offset = "0x250D200", VA = "0x18250DE00")]
	private void LJNMMJIDGOB(NativeArray<EntityArchetype> PFDJBLFOOLM, NativeArray<NDLCDGPEBGB> PFHLHLNEEEA, NativeArray<NDLCDGPEBGB> EKDLCPMGLMO, NativeArray<ComponentType> DLFDEDPKHME, NativeArray<ArchetypeChunk> FPBMIPLJIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x250DF60", Offset = "0x250D360", VA = "0x18250DF60")]
	private EntityArchetype MPFGEGFOJDO(EntityArchetype BOILJIOKKBE, NativeArray<ComponentType> DLFDEDPKHME, NDLCDGPEBGB PJNDNKMLPNK)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x250D550", Offset = "0x250C950", VA = "0x18250D550")]
	private JobHandle BIFFHLPFMMJ(NativeList<GFPIBEIJMOG> GFJFJJGOLFO, NativeArray<Entity> PGJLMFPAKDA, JobHandle OMGHOAKHCEK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x250E1B0", Offset = "0x250D5B0", VA = "0x18250E1B0")]
	private JobHandle OIEMNIHGHOG(NativeArray<Entity> PGJLMFPAKDA, NativeArray<GFPIBEIJMOG> GFJFJJGOLFO, int EPAJCDGEEKI, NDLCDGPEBGB PJNDNKMLPNK, JobHandle OMGHOAKHCEK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0x250E1A0", Offset = "0x250D5A0", VA = "0x18250E1A0")]
	public static bool NMDFGHAAIHF(ComponentType IJBDFBDGHPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public AHKHGHPHNFA()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	public class PostDeserializeTransformRoots : JKIEMPJPHGI
	{
		[Cpp2IlInjected.Token(Token = "0x20000E0")]
		[NoAlias]
		[BurstCompile]
		private struct PostDeserializeTransformRoots_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002E6")]
			public RigidTransform pose;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40002E7")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002E8")]
			public ComponentTypeHandle<KPMOMMGMLCH> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005ED")]
			[Cpp2IlInjected.Address(RVA = "0x3DE2E00", Offset = "0x3DE2200", VA = "0x183DE2E00")]
			private void EJBLFCAPFKM([NoAlias] ref KPMOMMGMLCH data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EE")]
			[Cpp2IlInjected.Address(RVA = "0x3DE7510", Offset = "0x3DE6910", VA = "0x183DE7510", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		[BurstCompile]
		[NoAlias]
		private struct PostDeserializeTransformRoots_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002E9")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002EA")]
			public ComponentTypeHandle<ANCGJKBPAIA> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x3DE2EE0", Offset = "0x3DE22E0", VA = "0x183DE2EE0")]
			private void EJBLFCAPFKM([NoAlias] ref ANCGJKBPAIA data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0x3DE75E0", Offset = "0x3DE69E0", VA = "0x183DE75E0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[BurstCompile]
		[NoAlias]
		private struct PostDeserializeTransformRoots_LambdaJob_2_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002EB")]
			public ComponentTypeHandle<NEHEFBBJJKL> __authoredPoseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40002EC")]
			[ReadOnly]
			public ComponentTypeHandle<KPMOMMGMLCH> __poseTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0x3DE2EF0", Offset = "0x3DE22F0", VA = "0x183DE2EF0")]
			private void EJBLFCAPFKM([NoAlias] ref NEHEFBBJJKL authoredPose, [NoAlias] in KPMOMMGMLCH pose)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F2")]
			[Cpp2IlInjected.Address(RVA = "0x3DE76B0", Offset = "0x3DE6AB0", VA = "0x183DE76B0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[BurstCompile]
		[NoAlias]
		private struct PostDeserializeTransformRoots_LambdaJob_3_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002ED")]
			public ComponentTypeHandle<GHNNNODAEGP> __authoredScaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			[ReadOnly]
			public ComponentTypeHandle<ANCGJKBPAIA> __scaleTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0x3DE2F10", Offset = "0x3DE2310", VA = "0x183DE2F10")]
			private void EJBLFCAPFKM([NoAlias] ref GHNNNODAEGP authoredScale, [NoAlias] in ANCGJKBPAIA scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F4")]
			[Cpp2IlInjected.Address(RVA = "0x3DE7800", Offset = "0x3DE6C00", VA = "0x183DE7800", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private EntityQuery PostDeserializeTransformRoots_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private EntityQuery PostDeserializeTransformRoots_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private EntityQuery PostDeserializeTransformRoots_LambdaJob_2_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		private EntityQuery PostDeserializeTransformRoots_LambdaJob_3_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private EntityQuery __query_4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private ComponentTypeHandle<KPMOMMGMLCH> __RecRoom_Components_LocalPoseData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private ComponentTypeHandle<ANCGJKBPAIA> __RecRoom_Components_LocalUniformScaleData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private ComponentTypeHandle<NEHEFBBJJKL> __RecRoom_Components_AuthoredLocalPoseData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private ComponentTypeHandle<KPMOMMGMLCH> __RecRoom_Components_LocalPoseData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private ComponentTypeHandle<GHNNNODAEGP> __RecRoom_Components_AuthoredLocalUniformScaleData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private ComponentTypeHandle<ANCGJKBPAIA> __RecRoom_Components_LocalUniformScaleData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x2239350", Offset = "0x2238750", VA = "0x182239350", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x2238560", Offset = "0x2237960", VA = "0x182238560")]
		private void JHFLOMEDIBC(in JHHGOKLOOPH transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x2238790", Offset = "0x2237B90", VA = "0x182238790")]
		private void NOPOCLNNDOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x22381B0", Offset = "0x22375B0", VA = "0x1822381B0")]
		private JobHandle CLIHLLFOHHH(RigidTransform pose, float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x22382F0", Offset = "0x22376F0", VA = "0x1822382F0")]
		private JobHandle DAMPBGENGAA(float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x2238400", Offset = "0x2237800", VA = "0x182238400")]
		private JobHandle FIHEGNDCFOH(JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x2238050", Offset = "0x2237450", VA = "0x182238050")]
		private JobHandle AEMANKAJMCC(JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x22389E0", Offset = "0x2237DE0", VA = "0x1822389E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
		public PostDeserializeTransformRoots()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E5")]
internal struct HIOPBAMMKBL : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
	internal class SplinePointParentChangedSystem : JKIEMPJPHGI, AKFIPDJCCOH
	{
		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[NoAlias]
		[BurstCompile]
		private struct SplinePointParentChangedSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002F7")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002F8")]
			public DynamicBuffer<global::DHBCNOAODED> splineIndexUpdatesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002F9")]
			[ReadOnly]
			public EntityTypeHandle __splinePointTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40002FA")]
			[ReadOnly]
			public ComponentTypeHandle<OCGHCEBJNGN> __splinePointParentDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0x3DEC9A0", Offset = "0x3DEBDA0", VA = "0x183DEC9A0")]
			private void EJBLFCAPFKM(Entity splinePoint, [NoAlias] in OCGHCEBJNGN splinePointParentData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0x3DECAB0", Offset = "0x3DEBEB0", VA = "0x183DECAB0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E8")]
		[BurstCompile]
		[NoAlias]
		private struct SplinePointParentChangedSystem_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002FB")]
			public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002FC")]
			[ReadOnly]
			public EntityTypeHandle __splinePointTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40002FD")]
			[ReadOnly]
			public ComponentTypeHandle<global::FEJNLFHLHLG> __splinePointParentSystemDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0x3DECBD0", Offset = "0x3DEBFD0", VA = "0x183DECBD0")]
			private void EJBLFCAPFKM(Entity splinePoint, [NoAlias] in global::FEJNLFHLHLG splinePointParentSystemData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0x3DECD00", Offset = "0x3DEC100", VA = "0x183DECD00", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private EntityQuery needsAdd;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private EntityQuery needsRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		[ONGFANECMJO]
		private MDBOACJLHAE singletonService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private EntityQuery SplinePointParentChangedSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private EntityQuery SplinePointParentChangedSystem_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private ComponentTypeHandle<OCGHCEBJNGN> __RecRoom_Components_SplinePointParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private ComponentTypeHandle<global::FEJNLFHLHLG> __RecRoom_Components_SplinePointParentSystemData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x2242DF0", Offset = "0x22421F0", VA = "0x182242DF0", Slot = "14")]
		public void InitReferences(EMFBCBAOENA services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x2243400", Offset = "0x2242800", VA = "0x182243400", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x22433F0", Offset = "0x22427F0", VA = "0x1822433F0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x2242900", Offset = "0x2241D00", VA = "0x182242900")]
		private void FJMJIPKNOLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x2242B50", Offset = "0x2241F50", VA = "0x182242B50")]
		private void IOJEKFDBLBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x2242FA0", Offset = "0x22423A0", VA = "0x182242FA0")]
		private EntityCommandBufferSystem KMBJDEEDCKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x2242E40", Offset = "0x2242240", VA = "0x182242E40")]
		private JobHandle JEEHHMHAMAM(EntityCommandBuffer ecb, DynamicBuffer<global::DHBCNOAODED> splineIndexUpdatesRO, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x22427B0", Offset = "0x2241BB0", VA = "0x1822427B0")]
		private JobHandle AHEGADPBOPH(BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x2242FF0", Offset = "0x22423F0", VA = "0x182242FF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
		public SplinePointParentChangedSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[CompilerGenerated]
	[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
	public class UpdateInertialProperties : JKIEMPJPHGI, AKFIPDJCCOH
	{
		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		[NoAlias]
		[BurstCompile]
		private struct UpdateInertialProperties_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.Token(Token = "0x20000EB")]
			public delegate void RunWithoutJobSystem_00000783$PostfixBurstDelegate(IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x20000EC")]
			internal static class RunWithoutJobSystem_00000783$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x4000313")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x4000314")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x6000617")]
				[Cpp2IlInjected.Address(RVA = "0x3DEAC80", Offset = "0x3DEA080", VA = "0x183DEAC80")]
				[BurstDiscard]
				private static void BPOGIOPNKPI(ref IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000618")]
				[Cpp2IlInjected.Address(RVA = "0x3DEB0B0", Offset = "0x3DEA4B0", VA = "0x183DEB0B0")]
				private static IntPtr OGEDALIJNIF()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000619")]
				[Cpp2IlInjected.Address(RVA = "0x3DEAFF0", Offset = "0x3DEA3F0", VA = "0x183DEAFF0")]
				public static void JEJODENPHGJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600061A")]
				[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
				public static void BEFDPLAELIH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600061C")]
				[Cpp2IlInjected.Address(RVA = "0x3DEADD0", Offset = "0x3DEA1D0", VA = "0x183DEADD0")]
				public static void GDOLIKHHLHI(IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000305")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x4000306")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000307")]
			public EntityQueryInJob isTaggedForUpdate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000308")]
			public EntityQueryInJob rootRbexChangedQuery;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000309")]
			public EntityQueryInJob deformationScaleChangedQuery;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			public EntityQueryInJob generalRbexChangedQuery;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400030B")]
			public ChunkFilterAnyOf5ComponentsChanged changeFilter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400030C")]
			public int maxEntityCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			public NativeList<Entity> changedRoots;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			[ReadOnly]
			public EntityExistenceLookupByEntity entityExists;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400030F")]
			[ReadOnly]
			public EntityTypeHandle entityTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
			[Cpp2IlInjected.Token(Token = "0x4000310")]
			[ReadOnly]
			public ComponentTypeHandle<LGBDFCDPOFB> rbexRootTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			[ReadOnly]
			public ComponentDataFromEntity<IMEBJPCKOHK> rbexIsKinematicRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			public Allocator allocator;

			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x3DED270", Offset = "0x3DEC670", VA = "0x183DED270")]
			private void EJBLFCAPFKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x3DED890", Offset = "0x3DECC90", VA = "0x183DED890", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0x3DED210", Offset = "0x3DEC610", VA = "0x183DED210")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void CFNDGCJBDDN(IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0x3DED8A0", Offset = "0x3DECCA0", VA = "0x183DED8A0")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void HFPJMCLHCIA(IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private EntityQuery isTaggedForUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private EntityQuery generalRbexChangedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private EntityQuery rootRbexChangedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		private EntityQuery deformationScaleChangedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		private EntityQuery removeMassOfHierarchyQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private FKMCIKMFIDA rbexServiceCallbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private AOONNPAOEFB objects;

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x2248DE0", Offset = "0x22481E0", VA = "0x182248DE0", Slot = "14")]
		public void InitReferences(EMFBCBAOENA services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x2249270", Offset = "0x2248670", VA = "0x182249270", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x22495E0", Offset = "0x22489E0", VA = "0x1822495E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x2248640", Offset = "0x2247A40", VA = "0x182248640")]
		protected void DHEKLBGCINI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x2249130", Offset = "0x2248530", VA = "0x182249130")]
		protected void MDNLJFNFOBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x22489D0", Offset = "0x2247DD0", VA = "0x1822489D0")]
		private bool IKAACNMGJJJ(EntityQueryInJob isTaggedForUpdate, EntityQueryInJob rootRbexChangedQuery, EntityQueryInJob deformationScaleChangedQuery, EntityQueryInJob generalRbexChangedQuery, out NativeList<Entity> results)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x2248E50", Offset = "0x2248250", VA = "0x182248E50")]
		private void KBJDPAELCDK(ref EntityQueryInJob isTaggedForUpdate, ref EntityQueryInJob rootRbexChangedQuery, ref EntityQueryInJob deformationScaleChangedQuery, ref EntityQueryInJob generalRbexChangedQuery, ref ChunkFilterAnyOf5ComponentsChanged changeFilter, ref int maxEntityCount, ref NativeList<Entity> changedRoots, ref EntityExistenceLookupByEntity entityExists, ref EntityTypeHandle entityTypeRO, ref ComponentTypeHandle<LGBDFCDPOFB> rbexRootTypeRO, ref ComponentDataFromEntity<IMEBJPCKOHK> rbexIsKinematicRO, ref Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x22491B0", Offset = "0x22485B0", VA = "0x1822491B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
		public UpdateInertialProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x2248980", Offset = "0x2247D80", VA = "0x182248980")]
		public static void GHDIDDOJJMP()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public class EENOPKPHJML : JKIEMPJPHGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	private EntityQuery PNGFJEAJDGO;

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x28C5810", Offset = "0x28C4C10", VA = "0x1828C5810", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x28C58D0", Offset = "0x28C4CD0", VA = "0x1828C58D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public EENOPKPHJML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
[DefaultMember("Item")]
public readonly struct GPAHDFKBGLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000316")]
	private readonly int EPAJCDGEEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000317")]
	private readonly int BCDNJJPDNMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	private readonly NativeArray<NDLCDGPEBGB>.ReadOnly NFDNHCCMBMJ;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public int KPHJAIPOAJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x28DAC80", Offset = "0x28DA080", VA = "0x1828DAC80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public GIJIABNLIPB OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x28DABF0", Offset = "0x28D9FF0", VA = "0x1828DABF0")]
		get
		{
			return default(GIJIABNLIPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public int JJAMODNONOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x16CFC90", Offset = "0x16CF090", VA = "0x1816CFC90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public NativeArray<NDLCDGPEBGB>.ReadOnly BMPIIHELEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x16CFC40", Offset = "0x16CF040", VA = "0x1816CFC40")]
		get
		{
			return default(NativeArray<NDLCDGPEBGB>.ReadOnly);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x28DACD0", Offset = "0x28DA0D0", VA = "0x1828DACD0")]
	public GPAHDFKBGLB(int EPAJCDGEEKI, int BCDNJJPDNMB, NativeArray<NDLCDGPEBGB>.ReadOnly NFDNHCCMBMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
internal class GKONCIBKBCD : OPIOBIJBFDM
{
	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	protected override GBICPCJAFPO OLPAAHHJIKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x28D7DC0", Offset = "0x28D71C0", VA = "0x1828D7DC0", Slot = "15")]
		get
		{
			return default(GBICPCJAFPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x250C880", Offset = "0x250BC80", VA = "0x18250C880")]
	public GKONCIBKBCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
public class FMJJIPMPDJE : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	private struct CDHEBJEOHJP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public NNDEHNEEJEM KMPMKIKDFIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public NativeParallelHashSet<Entity> PGJLMFPAKDA;

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x2708FF0", Offset = "0x27083F0", VA = "0x182708FF0")]
		public CDHEBJEOHJP(int EPMEDFGLJOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x2708F70", Offset = "0x2708370", VA = "0x182708F70", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[BurstCompile]
	private struct JABENGPIFFJ : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		[ReadOnly]
		public NativeArray<Entity> PGJLMFPAKDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		[ReadOnly]
		public ComponentDataFromEntity<HNDLOHCHOMJ> PAJPOJDJNIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		[ReadOnly]
		public ComponentDataFromEntity<IGJCCCPFMIK> EPPCEEPHIGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		[ReadOnly]
		public ComponentDataFromEntity<NEPPICPDJAN> KKBKMNIPDGG;

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x27114B0", Offset = "0x27108B0", VA = "0x1827114B0", Slot = "4")]
		public void Execute(int NANJAGEOPJI, TransformAccess FELEGEFPADK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[BurstCompile]
	private struct EKAEKMIBJNP : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		[ReadOnly]
		public NativeArray<Entity> PGJLMFPAKDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		[ReadOnly]
		public ComponentDataFromEntity<HNDLOHCHOMJ> PAJPOJDJNIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		[ReadOnly]
		public ComponentDataFromEntity<NEPPICPDJAN> KKBKMNIPDGG;

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x270CC70", Offset = "0x270C070", VA = "0x18270CC70", Slot = "4")]
		public void Execute(int NANJAGEOPJI, TransformAccess FELEGEFPADK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	private PGEMHDJNMBJ OAJPGNEHMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400031B")]
	private EntityQuery IOCOFNKBOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	private EntityQuery NEMCHADJOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	private EntityQuery BMPLGJDPKKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400031E")]
	private EntityQuery PBBIOGHCFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400031F")]
	private EntityQuery HDNKJPBONEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000320")]
	private JobHandle BHPGPEHFBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000321")]
	private CDHEBJEOHJP AEKLMAJIBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000322")]
	private CDHEBJEOHJP HODCBLBHCFK;

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x28D3E00", Offset = "0x28D3200", VA = "0x1828D3E00", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x28D3FC0", Offset = "0x28D33C0", VA = "0x1828D3FC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x28D37C0", Offset = "0x28D2BC0", VA = "0x1828D37C0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x28D4270", Offset = "0x28D3670", VA = "0x1828D4270", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x28D3CC0", Offset = "0x28D30C0", VA = "0x1828D3CC0")]
	private void HCMBODKFGLI(EntityQuery PNGFJEAJDGO, out (NativeArrayAsync<CJPEPCAHCNO> handles, NativeArrayAsync<FIKOEBGBDLM> bounds) KJFNAECAHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x28D3960", Offset = "0x28D2D60", VA = "0x1828D3960")]
	private void APPOGPPAKDI((NativeArrayAsync<CJPEPCAHCNO> handles, NativeArrayAsync<FIKOEBGBDLM> bounds) KJFNAECAHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x28D37C0", Offset = "0x28D2BC0", VA = "0x1828D37C0")]
	private void AFLIHFFLCPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x28D3B80", Offset = "0x28D2F80", VA = "0x1828D3B80")]
	private void DKLBEHJIMLO(EntityQuery PNGFJEAJDGO, out (NativeArrayAsync<Entity> entities, NativeArrayAsync<CJPEPCAHCNO> handles) KJFNAECAHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x28D4A20", Offset = "0x28D3E20", VA = "0x1828D4A20")]
	private void PDCLCMHKIKJ((NativeArrayAsync<Entity> entities, NativeArrayAsync<CJPEPCAHCNO> handles) KJFNAECAHBA, CDHEBJEOHJP HNFFJIBONPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x28D3800", Offset = "0x28D2C00", VA = "0x1828D3800")]
	private JobHandle AHKJMLMOJPP(CDHEBJEOHJP HNFFJIBONPK, ComponentDataFromEntity<HNDLOHCHOMJ> PAJPOJDJNIK, ComponentDataFromEntity<NEPPICPDJAN> KKBKMNIPDGG, ComponentDataFromEntity<IGJCCCPFMIK> EPPCEEPHIGE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x28D3E60", Offset = "0x28D3260", VA = "0x1828D3E60")]
	private JobHandle OBBOMGFGGJE(CDHEBJEOHJP HNFFJIBONPK, ComponentDataFromEntity<HNDLOHCHOMJ> PAJPOJDJNIK, ComponentDataFromEntity<NEPPICPDJAN> KKBKMNIPDGG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public FMJJIPMPDJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
[ALIINGEKIMD]
public class CNBPKFIFFGD : JKIEMPJPHGI, IBKHNFKEFMN.GPOJBALCDLB
{
	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x251E070", Offset = "0x251D470", VA = "0x18251E070", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x251E020", Offset = "0x251D420", VA = "0x18251E020")]
	private EntityCommandBufferSystem KMBJDEEDCKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public CNBPKFIFFGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
[LOJHKAHIJPC(typeof(FHGIEPBNGKE))]
[EFDJEPLIMOC(typeof(CDGICEOEFLL), new string[] { })]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
internal class CDGICEOEFLL : AKFIPDJCCOH, FHGIEPBNGKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	[ONGFANECMJO]
	private DIOBGNHCMAF CKLBBPLIDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private IPJCHCHPAMO PACFDNMFNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private NativeList<byte> KJFNAECAHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private NativeList<EBBOOPFABOA> MDNDLMJNHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private NativeList<NDLCDGPEBGB> IEMFDMABFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private int DJKFGOAIPHC;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<EBBOOPFABOA, NativeArray<byte>> LMJDACJJENC
	{
		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x25163C0", Offset = "0x25157C0", VA = "0x1825163C0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x2516460", Offset = "0x2515860", VA = "0x182516460")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x2516580", Offset = "0x2515980", VA = "0x182516580", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x2516500", Offset = "0x2515900", VA = "0x182516500", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x25166B0", Offset = "0x2515AB0", VA = "0x1825166B0", Slot = "5")]
	public void MBABJJKIAOP(EBBOOPFABOA CANIEFMHGCA, ReadOnlySpan<byte> KBLLMJIHKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x2516860", Offset = "0x2515C60", VA = "0x182516860")]
	public void PEHJALIONDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x2516970", Offset = "0x2515D70", VA = "0x182516970")]
	public CDGICEOEFLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public class ALIINGEKIMD : IFPCMOOGJCE
{
	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0xD17B50", Offset = "0xD16F50", VA = "0x180D17B50")]
	public ALIINGEKIMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
public class BGJPHAKOIKG : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[BurstCompile]
	private struct NNPAGEDOLAE : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		[ReadOnly]
		public NativeArray<Entity> PGJLMFPAKDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<KPMOMMGMLCH> KMOJMCOHDKC;

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x2715B20", Offset = "0x2714F20", VA = "0x182715B20", Slot = "4")]
		public void Execute(int NANJAGEOPJI, TransformAccess FELEGEFPADK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x2715CF0", Offset = "0x27150F0", VA = "0x182715CF0")]
		private bool FMDIHCFILPE(float3 OIKAFLDALHD, float3 LCEOCHLKMEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x2715D20", Offset = "0x2715120", VA = "0x182715D20")]
		private bool IHFNODAAOGN(quaternion OIKAFLDALHD, quaternion LCEOCHLKMEN)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[BurstCompile]
	private struct KFFODJOKABC : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		[ReadOnly]
		public NativeArray<Entity> PGJLMFPAKDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<ANCGJKBPAIA> HLGPNAJNAKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<OGGOJLEGOPG> HPFGJBANLHA;

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x27124B0", Offset = "0x27118B0", VA = "0x1827124B0", Slot = "4")]
		public void Execute(int NANJAGEOPJI, TransformAccess FELEGEFPADK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private static readonly PILIJFIMAJF OEDJBCFCBEB;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private static readonly PILIJFIMAJF GIBDPCLMCEI;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private static readonly PILIJFIMAJF EFEIHLPGPDH;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private static readonly ProfilerMarker CDODHEKNCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private NPDFHBHBCOI ENIGIEHDNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private PFJMBDHJHAN GKACEDOEIPO;

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(RVA = "0x2513190", Offset = "0x2512590", VA = "0x182513190", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0x2513200", Offset = "0x2512600", VA = "0x182513200", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x2513240", Offset = "0x2512640", VA = "0x182513240", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public BGJPHAKOIKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public sealed class PAPFDGAFFCF : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x4000340")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	private EntityQuery PNGFJEAJDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	private AOONNPAOEFB FHJACJEANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	private IIKMCLIAKNK FEJKNPAOBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	private CLNNDLPCIAD HMLHGKKIAHM;

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x222DDA0", Offset = "0x222D1A0", VA = "0x18222DDA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x222DD10", Offset = "0x222D110", VA = "0x18222DD10", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x222DEA0", Offset = "0x222D2A0", VA = "0x18222DEA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public PAPFDGAFFCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
[EBCKCHNKEDI]
internal abstract class ICDMBOJCFKC : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	protected AOONNPAOEFB FHJACJEANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	protected HNIPNFEMKKN LJACJOOEGHH;

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	protected abstract GBICPCJAFPO OLPAAHHJIKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x287CF50", Offset = "0x287C350", VA = "0x18287CF50", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x287CAB0", Offset = "0x287BEB0", VA = "0x18287CAB0")]
	protected void DKAIIMCJJGL(EntityQuery PNGFJEAJDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x287CD00", Offset = "0x287C100", VA = "0x18287CD00")]
	protected void DOLKANKCBNJ(EntityQuery PNGFJEAJDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x287CA40", Offset = "0x287BE40", VA = "0x18287CA40")]
	protected PPACDBGDBCI DCCMOFNKKLK(EntityQuery PNGFJEAJDGO)
	{
		return default(PPACDBGDBCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	protected ICDMBOJCFKC()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000FC")]
internal struct KBCDHGJOPBA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public struct NNDEHNEEJEM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	private NativeList<Entity> PGJLMFPAKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private TransformAccessArray KMPMKIKDFIP;

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public int NPBPHODFKMP
	{
		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x2A72740", Offset = "0x2A71B40", VA = "0x182A72740")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public NativeList<Entity> DLEOKIGAIOF
	{
		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x12E63E0", Offset = "0x12E57E0", VA = "0x1812E63E0")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public TransformAccessArray JDBDBDNNHPL
	{
		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x7E8110", Offset = "0x7E7510", VA = "0x1807E8110")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public bool MPIAMCJMFLB
	{
		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x2A72510", Offset = "0x2A71910", VA = "0x182A72510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x2A727E0", Offset = "0x2A71BE0", VA = "0x182A727E0")]
	public NNDEHNEEJEM(int EPMEDFGLJOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x2A72750", Offset = "0x2A71B50", VA = "0x182A72750")]
	public Entity LMHMGKHPPFF(int NANJAGEOPJI)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x2A72670", Offset = "0x2A71A70", VA = "0x182A72670")]
	public void ENAJKAIBKHM(int EPMEDFGLJOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x2A725B0", Offset = "0x2A719B0", VA = "0x182A725B0")]
	public int EBOHBLNDMAL(Transform FELEGEFPADK, Entity FKNFFDFGNMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x2A726C0", Offset = "0x2A71AC0", VA = "0x182A726C0")]
	public int GFOJLLGGPFB(int NANJAGEOPJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x2A72530", Offset = "0x2A71930", VA = "0x182A72530", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x2A727A0", Offset = "0x2A71BA0", VA = "0x182A727A0")]
	private void OPFLCMBENNA(int DKBIFCDKIGA = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public class MNADAHLMKHK : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private EntityQuery PNGFJEAJDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private DOAELEMMHCE LEGFAAONKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private AOONNPAOEFB FHJACJEANIP;

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x2A6AA20", Offset = "0x2A69E20", VA = "0x182A6AA20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x2A6A9B0", Offset = "0x2A69DB0", VA = "0x182A6A9B0", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x2A6AAF0", Offset = "0x2A69EF0", VA = "0x182A6AAF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public MNADAHLMKHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
[EFDJEPLIMOC(typeof(PGEMHDJNMBJ), new string[] { })]
public sealed class KOGGDLDNAMG : PGEMHDJNMBJ, CINMFIJPFIM, DEPDOFHIDBA, AKFIPDJCCOH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	[ONGFANECMJO]
	private BPJPLKILODH PJDNDHAAPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private Collider[] HIIPHNCKPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private RaycastHit[] PJFFGCINMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private FAFDPBICOBM<AJIEIAAKCCA, BoxCollider> LJGBDEBPEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private Scene EOOPPEEEACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private PhysicsScene GFNIAOKAKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	private GameObject OCCJOMPABPO;

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x2896210", Offset = "0x2895610", VA = "0x182896210", Slot = "9")]
	public void MCOOCEGHCPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x2895B90", Offset = "0x2894F90", VA = "0x182895B90", Slot = "10")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x2895560", Offset = "0x2894960", VA = "0x182895560", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x2895C50", Offset = "0x2895050", VA = "0x182895C50", Slot = "4")]
	public AJIEIAAKCCA JEDEDABKHGE(Entity FKNFFDFGNMN)
	{
		return default(AJIEIAAKCCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x2895780", Offset = "0x2894B80", VA = "0x182895780", Slot = "5")]
	public void GDGINFALDOO(NativeArray<AJIEIAAKCCA> KFFIGCKCIIO, NativeArray<FIKOEBGBDLM> LJFLOLJGCND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x2895210", Offset = "0x2894610", VA = "0x182895210", Slot = "6")]
	public void CFGGHHMDFIL(AJIEIAAKCCA PPCGBBAKOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x28963D0", Offset = "0x28957D0", VA = "0x1828963D0", Slot = "7")]
	public bool OPDODEHBCLM(AJIEIAAKCCA PPCGBBAKOHO, out Collider JGLBLFOJFCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x2895F10", Offset = "0x2895310", VA = "0x182895F10")]
	public bool LJCJBGODPCK(in float3 OCPINBDMADB, in float3 KDLMOBCGODE, float AMDMMLBNHAH, Allocator GMMIODGPFPJ, out NativeArray<Entity> PGJLMFPAKDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x2895510", Offset = "0x2894910", VA = "0x182895510")]
	private void DFPPFPBIHDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0xFB7D10", Offset = "0xFB7110", VA = "0x180FB7D10")]
	private void HHEBMFIMDOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x2895EC0", Offset = "0x28952C0", VA = "0x182895EC0")]
	private void KJLDCHEILHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x12B7510", Offset = "0x12B6910", VA = "0x1812B7510")]
	private void CHDMKEOFNDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x2895660", Offset = "0x2894A60", VA = "0x182895660")]
	private BoxCollider GAOPFJKJPAA(Entity FKNFFDFGNMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x2895190", Offset = "0x2894590", VA = "0x182895190")]
	private void BEKJDOOFOKA(BoxCollider BHJHNIGNJFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x2895990", Offset = "0x2894D90", VA = "0x182895990")]
	private void GJBJPNLBPLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x2895DA0", Offset = "0x28951A0", VA = "0x182895DA0")]
	private void KJCOGODEEEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x28952E0", Offset = "0x28946E0", VA = "0x1828952E0")]
	private void CJGNLLKNLCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x2896460", Offset = "0x2895860", VA = "0x182896460")]
	private void OPEHJOOMADM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x2896380", Offset = "0x2895780", VA = "0x182896380")]
	private void NFAFFEPDAFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x2896390", Offset = "0x2895790", VA = "0x182896390")]
	private void NNAPDMDDKHD(Scene MBNKLCOGGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public KOGGDLDNAMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x2895B80", Offset = "0x2894F80", VA = "0x182895B80", Slot = "8")]
	private bool ICKOACCLHHP(in float3 OCPINBDMADB, in float3 KDLMOBCGODE, float AMDMMLBNHAH, Allocator GMMIODGPFPJ, out NativeArray<Entity> PGJLMFPAKDA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public readonly struct GBICPCJAFPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public readonly ComponentType? GKEMGGKPLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public readonly ComponentType? BHPDNCFOBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public readonly ComponentType ELGLBPKFHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public readonly object GAOLOMEJCOK;

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0x28D4DD0", Offset = "0x28D41D0", VA = "0x1828D4DD0")]
	public GBICPCJAFPO(ComponentType? GKEMGGKPLEK, ComponentType? BHPDNCFOBFB, ComponentType ELGLBPKFHNP, object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0x196C510", Offset = "0x196B910", VA = "0x18196C510")]
	public static GBICPCJAFPO KFBIAEPLDII<TReq, TTag>(object GAOLOMEJCOK)
	{
		return default(GBICPCJAFPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x196C7E0", Offset = "0x196BBE0", VA = "0x18196C7E0")]
	public static GBICPCJAFPO LFHENLNFNGJ<TReq, TMissing, TTag>(object GAOLOMEJCOK)
	{
		return default(GBICPCJAFPO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
internal class AGGPDEMGFMK : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private ILIBONIKHOI CDIHHIPDEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private EGBDNLKFOBI NFOOMJHPEJF;

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x250D2B0", Offset = "0x250C6B0", VA = "0x18250D2B0", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x250D320", Offset = "0x250C720", VA = "0x18250D320", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public AGGPDEMGFMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
[EFDJEPLIMOC(typeof(FMHENAEHCJH), new string[] { })]
[GCHMNDFEPKK(typeof(OKGCFPBMNKK))]
public class BEEGDHPDJOA : FMHENAEHCJH, DEPDOFHIDBA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400035C")]
	private readonly Dictionary<int, PKOHIJKDADP> BFCOMCCICLI;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public IEnumerable<PKOHIJKDADP> MOBJPGNHINP
	{
		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x2512A90", Offset = "0x2511E90", VA = "0x182512A90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x2512AE0", Offset = "0x2511EE0", VA = "0x182512AE0", Slot = "6")]
	public void MCOOCEGHCPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x25129D0", Offset = "0x2511DD0", VA = "0x1825129D0", Slot = "5")]
	public bool CPNDMBNJMDG(int EPAJCDGEEKI, out PKOHIJKDADP BGHJBFABJHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x2512A40", Offset = "0x2511E40", VA = "0x182512A40", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x2512E90", Offset = "0x2512290", VA = "0x182512E90")]
	public BEEGDHPDJOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
internal class DIHDLKBCOIA : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private EntityQuery DJGOCMOKPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private JGJJAGMGKPI FBCPJLHEMAI;

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x2522D50", Offset = "0x2522150", VA = "0x182522D50", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x2522DA0", Offset = "0x25221A0", VA = "0x182522DA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x2522E50", Offset = "0x2522250", VA = "0x182522E50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x2D422C0", Offset = "0x2D416C0", VA = "0x182D422C0")]
	private bool DLJLFIPGKAD<TComponentData>(EntityQuery PNGFJEAJDGO, out NativeArray<Entity> PGJLMFPAKDA, out NativeArray<TComponentData> NMIBCPIHMNH) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x2522CE0", Offset = "0x25220E0", VA = "0x182522CE0")]
	public CJHAGIKCJCL IJGILLEHHFG(Entity FKNFFDFGNMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public DIHDLKBCOIA()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000104")]
public struct PCIOJFEEDKP : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
[EBCKCHNKEDI]
public class CJLGHHDODNO : JKIEMPJPHGI
{
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[BurstCompile]
	private struct FBEOOOECGGK : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		[ReadOnly]
		public NativeArray<Entity> ADIMLPFIHLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		[ReadOnly]
		public ComponentDataFromEntity<OCGHCEBJNGN> AGJNAGGNCEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		[ReadOnly]
		public ComponentDataFromEntity<FIKOEBGBDLM> HFFJAEIAIPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		[WriteOnly]
		public NativeParallelHashSet<Entity>.ParallelWriter DBNDCOFMLJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		[WriteOnly]
		public NativeList<Entity>.ParallelWriter AEODBOIGLCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		[WriteOnly]
		public NativeList<Entity>.ParallelWriter LLDPJLNHNOJ;

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x270CDC0", Offset = "0x270C1C0", VA = "0x18270CDC0", Slot = "4")]
		public void Execute(int NANJAGEOPJI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[BurstCompile]
	private struct KBOPNMPBGAD : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		[ReadOnly]
		public NativeArray<Entity> MNFHJGGNMGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> NOBDGFENFJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		[ReadOnly]
		public ComponentDataFromEntity<NGCCGHIFCBM> FIFJBJEMILD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		[ReadOnly]
		public ComponentDataFromEntity<DIAHLMCFEAG> BCOCIOIPFOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		[NativeDisableContainerSafetyRestriction]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<FIKOEBGBDLM> EEFFMIIHKBD;

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x2712210", Offset = "0x2711610", VA = "0x182712210", Slot = "4")]
		public void Execute(int NANJAGEOPJI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private EntityQuery OFHFNFJCLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private EntityQuery JLGJELGJHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private EntityQuery LNDBDMKMJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	private EntityQuery MDIPLEAKAFA;

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x251C000", Offset = "0x251B400", VA = "0x18251C000", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x251C210", Offset = "0x251B610", VA = "0x18251C210", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(RVA = "0x251BF20", Offset = "0x251B320", VA = "0x18251BF20")]
	private JobHandle ODPKHFEMOME(NativeArrayAsync<Entity> KGHLGBOMEFA, int PGBALNGGNPG, JobHandle OMGHOAKHCEK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x251BCF0", Offset = "0x251B0F0", VA = "0x18251BCF0")]
	private JobHandle ODPKHFEMOME(NativeArray<Entity> MNGPBPKLMPO, int PGBALNGGNPG, [Optional] JobHandle OMGHOAKHCEK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x251B810", Offset = "0x251AC10", VA = "0x18251B810")]
	private (NativeListAsync<Entity>, NativeListAsync<Entity>) HAPAFLMEIAP(NativeArrayAsync<Entity> IMMGKJBDMOE)
	{
		return default((NativeListAsync<Entity>, NativeListAsync<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0x251BC60", Offset = "0x251B060", VA = "0x18251BC60")]
	private void MDICEJDMFME(out NativeArray<Entity> PGJLMFPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x251B250", Offset = "0x251A650", VA = "0x18251B250")]
	private void AFDCEPPJLBN(NativeList<Entity> PGJLMFPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x251B2E0", Offset = "0x251A6E0", VA = "0x18251B2E0")]
	private void AFDCEPPJLBN(NativeArray<Entity> PGJLMFPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x251B3B0", Offset = "0x251A7B0", VA = "0x18251B3B0")]
	private void FAEJHHECKJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	private static void LLBDOPEPEIA(int LFGCHFFENPA, int EIFOHKNIPJO, int HKNNMLCCHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x251B4E0", Offset = "0x251A8E0", VA = "0x18251B4E0")]
	private static FIKOEBGBDLM GNABCHALFBO(NativeArray<Entity> ACAICFLBJGE, ComponentDataFromEntity<NGCCGHIFCBM> FIFJBJEMILD, ComponentDataFromEntity<DIAHLMCFEAG> BCOCIOIPFOI)
	{
		return default(FIKOEBGBDLM);
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public CJLGHHDODNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public struct IJEMANMGDHA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400036F")]
	private NativeArray<NDLCDGPEBGB> HLAMMGIHLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000370")]
	private NativeArray<int> DEGLNHMGFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000371")]
	private NativeParallelHashMap<int, NDLCDGPEBGB> OAEEFMJINIJ;

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public readonly int MIJGDFGFNJD
	{
		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x976C20", Offset = "0x976020", VA = "0x180976C20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public readonly int EDMANLFCLMK
	{
		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0xE5B620", Offset = "0xE5AA20", VA = "0x180E5B620")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x2883EF0", Offset = "0x28832F0", VA = "0x182883EF0")]
	public IJEMANMGDHA(IReadOnlyCollection<GKAKPCKINHA> NMIBCPIHMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0x2883DB0", Offset = "0x28831B0", VA = "0x182883DB0")]
	public readonly GPAHDFKBGLB PHBEADLJDEK(int EPAJCDGEEKI)
	{
		return default(GPAHDFKBGLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x2883D30", Offset = "0x2883130", VA = "0x182883D30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
[AlwaysUpdateSystem]
public abstract class KOEELCMGFDH : JKIEMPJPHGI, IBKHNFKEFMN.GPOJBALCDLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000376")]
	private NativeList<EntityQuery> AJMDHBOAFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000377")]
	private bool HLJDIDOCPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000378")]
	private EntityCommandBufferSystem DCLHOGPFELA;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	protected bool NGKCNIJNPNN
	{
		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x2894FB0", Offset = "0x28943B0", VA = "0x182894FB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	protected abstract PILIJFIMAJF GEPKNBOCDIP
	{
		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract IEnumerable<IBKHNFKEFMN.AHKJOPMIMKP> JAONDHGNIEF();

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x2895010", Offset = "0x2894410", VA = "0x182895010", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x2895130", Offset = "0x2894530", VA = "0x182895130", Slot = "13")]
	protected sealed override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x28950E0", Offset = "0x28944E0", VA = "0x1828950E0", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract void KKMHPKEJHOP();

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x2894FC0", Offset = "0x28943C0", VA = "0x182894FC0")]
	protected EntityCommandBufferSystem KMBJDEEDCKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0x2420C40", Offset = "0x2420040", VA = "0x182420C40")]
	protected EntityQuery HIIIMDDBCGN<T>() where T : struct, IComponentData
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(RVA = "0x2421140", Offset = "0x2420540", VA = "0x182421140")]
	protected NFONADLCMPK<T> IACGKLAJJFA<T>() where T : struct, IComponentData
	{
		return default(NFONADLCMPK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(RVA = "0x2420B30", Offset = "0x241FF30", VA = "0x182420B30")]
	protected BHLLODNGMFM<T> HHANLBDOKIF<T>() where T : struct, IComponentData
	{
		return default(BHLLODNGMFM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(RVA = "0x2421E40", Offset = "0x2421240", VA = "0x182421E40")]
	protected static void IFGCMNPLJFN<T1, T2>(LHFHADLJOHO<T1> DCHPHDADGIE, LHFHADLJOHO<T2> CELOLNGLLIA) where T1 : struct, IComponentData where T2 : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(RVA = "0x2421E40", Offset = "0x2421240", VA = "0x182421E40")]
	protected static void IFGCMNPLJFN<T1, T2>(LHFHADLJOHO<T1> DCHPHDADGIE, BBAGIBOCELJ<T2> CELOLNGLLIA) where T1 : struct, IComponentData where T2 : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(RVA = "0x2421F40", Offset = "0x2421340", VA = "0x182421F40")]
	private static void IFGCMNPLJFN<T1, T2>(OAGAALHEKIF<T1> DCHPHDADGIE, OAGAALHEKIF<T2> CELOLNGLLIA) where T1 : struct, IComponentData where T2 : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	protected KOEELCMGFDH()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[ALIINGEKIMD]
	[CompilerGenerated]
	public class PostDeserializeUpgrade_Convert_ObjectPolicyData : KOEELCMGFDH
	{
		[Cpp2IlInjected.Token(Token = "0x200010C")]
		[NoAlias]
		[BurstCompile]
		private struct PostDeserializeUpgrade_Convert_ObjectPolicyData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			public NFONADLCMPK<MFEHEBNNCHG> v0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			public NFONADLCMPK<EHBGDPJMKFG> v1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			public NFONADLCMPK<DNJNACAIJOD> v2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			public NFONADLCMPK<HOCGLGHDOPG> v3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			public BHLLODNGMFM<JDPPKCPDCCN> v4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			public DNJNACAIJOD v2Default;

			[Cpp2IlInjected.Token(Token = "0x60006C1")]
			[Cpp2IlInjected.Address(RVA = "0x3DE7BF0", Offset = "0x3DE6FF0", VA = "0x183DE7BF0")]
			private void EJBLFCAPFKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C2")]
			[Cpp2IlInjected.Address(RVA = "0x3DE82C0", Offset = "0x3DE76C0", VA = "0x183DE82C0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000379")]
		private static readonly PILIJFIMAJF log;

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		protected override PILIJFIMAJF Log
		{
			[Cpp2IlInjected.Token(Token = "0x60006B7")]
			[Cpp2IlInjected.Address(RVA = "0x223A930", Offset = "0x2239D30", VA = "0x18223A930", Slot = "14")]
			get
			{
				return default(PILIJFIMAJF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x223A0C0", Offset = "0x22394C0", VA = "0x18223A0C0", Slot = "15")]
		public override IEnumerable<IBKHNFKEFMN.AHKJOPMIMKP> JAONDHGNIEF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x223A480", Offset = "0x2239880", VA = "0x18223A480", Slot = "16")]
		protected override void KKMHPKEJHOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x223A2E0", Offset = "0x22396E0", VA = "0x18223A2E0")]
		private static void JKLHGJPJBOF(OAGAALHEKIF<EHBGDPJMKFG> srcVersion, OAGAALHEKIF<DNJNACAIJOD> dstVersion, DNJNACAIJOD dstDefault)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x223A810", Offset = "0x2239C10", VA = "0x18223A810")]
		private static void LFDNIPHGPLD(OAGAALHEKIF<DNJNACAIJOD> srcVersion, OAGAALHEKIF<HOCGLGHDOPG> dstVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x2239D60", Offset = "0x2239160", VA = "0x182239D60")]
		private static void HGPHBCDGLIM(OAGAALHEKIF<HOCGLGHDOPG> srcVersion, OAGAALHEKIF<JDPPKCPDCCN> dstVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x2239E90", Offset = "0x2239290", VA = "0x182239E90")]
		private JobHandle IBDCKCMDICN(NFONADLCMPK<MFEHEBNNCHG> v0, NFONADLCMPK<EHBGDPJMKFG> v1, NFONADLCMPK<DNJNACAIJOD> v2, NFONADLCMPK<HOCGLGHDOPG> v3, BHLLODNGMFM<JDPPKCPDCCN> v4, DNJNACAIJOD v2Default, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x2239D50", Offset = "0x2239150", VA = "0x182239D50")]
		public PostDeserializeUpgrade_Convert_ObjectPolicyData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
[AlwaysUpdateSystem]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
public abstract class DPMFBCJDGFB : JKIEMPJPHGI, CBKELFDIEEL
{
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	private struct IENKMNGNLHN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public NativeListAsync<Entity> ODIJIMKILPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public NativeListAsync<Entity> HKOMNOMDFIC;

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x27110F0", Offset = "0x27104F0", VA = "0x1827110F0")]
		public IENKMNGNLHN(NativeList<Entity> ODIJIMKILPC, NativeList<Entity> HKOMNOMDFIC, JobHandle FPNNHINBDNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x2711070", Offset = "0x2710470", VA = "0x182711070")]
		public JobHandle JBKAMEONPCP(JobHandle OMGHOAKHCEK)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x2710FE0", Offset = "0x27103E0", VA = "0x182710FE0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[BurstCompile]
	private struct IDKHMJEKIMN : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x2000110")]
		[Flags]
		public enum HPLHBBCCHDM
		{
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			ReadParentFromArray = 1,
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			FetchParentFromEntity = 2,
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			AncestorTagValue = 4,
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			ConstNoAncestorTag = 0,
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			ConstHasAncestorTag = 4
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		[WriteOnly]
		public NativeList<Entity> HOMLMGOLEFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		[WriteOnly]
		public NativeList<Entity> EBFDPHJPAEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		[ReadOnly]
		public NativeArray<Entity> EHHJOJHIAIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		[ReadOnly]
		public BufferFromEntity<OOENBAEOKLI> GKBHKHKECDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		[ReadOnly]
		public ComponentDataFromEntity MNEPGOCILMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		[ReadOnly]
		public ComponentDataFromEntity EJMKGCHFLFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		[ReadOnly]
		public ComponentDataFromEntity<ELLKBCJMOKK> PMOCPGHDACC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public int IKEGPAPACGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public int HHLGKCIFAMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private HPLHBBCCHDM LGEBLOBJMJD;

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x2710960", Offset = "0x270FD60", VA = "0x182710960", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x27106C0", Offset = "0x270FAC0", VA = "0x1827106C0")]
		private bool BIBGHOMPDDA(Entity FKNFFDFGNMN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x2710A90", Offset = "0x270FE90", VA = "0x182710A90")]
		private void IBDOPPGLLHJ(Entity FKNFFDFGNMN, bool JJOOKPOKEIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x2710770", Offset = "0x270FB70", VA = "0x182710770")]
		private void ECLIBNMCNDE(Entity FKNFFDFGNMN, bool JJOOKPOKEIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x2710640", Offset = "0x270FA40", VA = "0x182710640")]
		public IENKMNGNLHN AAAENIEBEHA(NativeArray<Entity> OLLDFGPFFGN, JobHandle OMGHOAKHCEK)
		{
			return default(IENKMNGNLHN);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x2710E80", Offset = "0x2710280", VA = "0x182710E80")]
		public IENKMNGNLHN LHMICGADFJJ(NativeArray<Entity> OLLDFGPFFGN, JobHandle OMGHOAKHCEK)
		{
			return default(IENKMNGNLHN);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x2710880", Offset = "0x270FC80", VA = "0x182710880")]
		public IENKMNGNLHN EILCFIPODOM(NativeList<PEHOAOEGBBM> OCCNFAKIALD, JobHandle OMGHOAKHCEK)
		{
			return default(IENKMNGNLHN);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x2710F00", Offset = "0x2710300", VA = "0x182710F00")]
		public IENKMNGNLHN MLLMEFOAMFH(NativeList<PEHOAOEGBBM> OCCNFAKIALD, JobHandle OMGHOAKHCEK)
		{
			return default(IENKMNGNLHN);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x2710DA0", Offset = "0x27101A0", VA = "0x182710DA0")]
		public IENKMNGNLHN LANBKAFPAFI(NativeList<BEHJCNECJCL> OCCNFAKIALD, JobHandle OMGHOAKHCEK)
		{
			return default(IENKMNGNLHN);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x264F700", Offset = "0x264EB00", VA = "0x18264F700")]
		private IENKMNGNLHN JLMINEFFHPP<T>(NativeList<T> OCCNFAKIALD, int IMJIOLLLKHE, int ECBMIAFGEAB, HPLHBBCCHDM MMGKIPGKNHG, JobHandle OMGHOAKHCEK) where T : struct
		{
			return default(IENKMNGNLHN);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x2710B20", Offset = "0x270FF20", VA = "0x182710B20")]
		private IENKMNGNLHN JLMINEFFHPP(NativeArray<Entity> PGJLMFPAKDA, int IMJIOLLLKHE, int ECBMIAFGEAB, HPLHBBCCHDM MMGKIPGKNHG, JobHandle OMGHOAKHCEK)
		{
			return default(IENKMNGNLHN);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000380")]
	private readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000381")]
	private EntityQuery CLFAOINGHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000382")]
	private EntityQuery FBLGAKCEJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000383")]
	private BAHKBHMHHLL MHEHDNFNNDJ;

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	protected abstract ComponentType PDHNPENHMAM
	{
		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	protected abstract ComponentType IMMDMMODPGD
	{
		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	protected abstract ComponentType IEBBBMGCEFM
	{
		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x28C26C0", Offset = "0x28C1AC0", VA = "0x1828C26C0")]
	protected DPMFBCJDGFB(PILIJFIMAJF FDJKGAAPBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x28C10F0", Offset = "0x28C04F0", VA = "0x1828C10F0", Slot = "14")]
	public void JFCLKDMBJND(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x28C1460", Offset = "0x28C0860", VA = "0x1828C1460", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x28C1690", Offset = "0x28C0A90", VA = "0x1828C1690", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x1531680", Offset = "0x1530A80", VA = "0x181531680", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x28C0E60", Offset = "0x28C0260", VA = "0x1828C0E60")]
	private void CGJELMCEDIM(NativeArray<Entity> OCCNFAKIALD, EntityCommandBuffer FFLDGNLHFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x28C1410", Offset = "0x28C0810", VA = "0x1828C1410")]
	private void NDDOCCNMNIG(NativeArray<Entity> OCCNFAKIALD, EntityCommandBuffer FFLDGNLHFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x28C0FC0", Offset = "0x28C03C0", VA = "0x1828C0FC0")]
	private void CINGFPMNEEP(IENKMNGNLHN PKIAFNONMCN, string CIDIPJNLOCI, EntityCommandBuffer FFLDGNLHFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x28C0EB0", Offset = "0x28C02B0", VA = "0x1828C0EB0")]
	private void CINGFPMNEEP(NativeListAsync<Entity> GIIFKAALDNP, string CIDIPJNLOCI, EntityCommandBuffer FFLDGNLHFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x28C12E0", Offset = "0x28C06E0", VA = "0x1828C12E0")]
	private void MHCGPGIFMHI(IENKMNGNLHN PKIAFNONMCN, string CIDIPJNLOCI, EntityCommandBuffer FFLDGNLHFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x28C11D0", Offset = "0x28C05D0", VA = "0x1828C11D0")]
	private void MHCGPGIFMHI(NativeListAsync<Entity> GIIFKAALDNP, string CIDIPJNLOCI, EntityCommandBuffer FFLDGNLHFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x28C0DE0", Offset = "0x28C01E0", VA = "0x1828C0DE0")]
	private bool APIAHGHCHAG()
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
	public class RegisterTransforms : JKIEMPJPHGI, AKFIPDJCCOH
	{
		[Cpp2IlInjected.Token(Token = "0x2000112")]
		private struct RegisterTransforms_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			public RegisterTransforms __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			[ReadOnly]
			public ComponentTypeHandle<JHOHCLIGMLG> __arrayIndexTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			public ComponentTypeHandle<Transform> __transformTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60006EE")]
			[Cpp2IlInjected.Address(RVA = "0x3DEAB70", Offset = "0x3DE9F70", VA = "0x183DEAB70")]
			private void OriginalLambdaBody(Entity entity, in JHOHCLIGMLG arrayIndex, Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006EF")]
			[Cpp2IlInjected.Address(RVA = "0x3DEA980", Offset = "0x3DE9D80", VA = "0x183DEA980", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private static readonly PILIJFIMAJF log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private NPDFHBHBCOI embodiedTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private EntityQuery allTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private EntityQuery addNewTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private EntityQuery removeOldTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private EntityQuery clearTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private EntityQuery RegisterTransforms_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private ComponentTypeHandle<JHOHCLIGMLG> __RecRoom_Components_TransformAccessArrayIndexData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x2241130", Offset = "0x2240530", VA = "0x182241130", Slot = "14")]
		public void InitReferences(EMFBCBAOENA services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x22413B0", Offset = "0x22407B0", VA = "0x1822413B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x2241620", Offset = "0x2240A20", VA = "0x182241620", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x2240DB0", Offset = "0x22401B0", VA = "0x182240DB0")]
		private void AddTransforms(EntityQuery query, NNDEHNEEJEM accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x2241950", Offset = "0x2240D50", VA = "0x182241950")]
		private void RemoveTransforms(EntityQuery query, NNDEHNEEJEM accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x22415C0", Offset = "0x22409C0", VA = "0x1822415C0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x2240C70", Offset = "0x2240070", VA = "0x182240C70")]
		private void AddNewTransforms(NativeArray<Entity> entities, NNDEHNEEJEM accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x2241710", Offset = "0x2240B10", VA = "0x182241710")]
		internal static void RemoveOldTransforms(NativeArray<JHOHCLIGMLG> arrayIndices, ComponentDataFromEntity<JHOHCLIGMLG> transformAccess, NNDEHNEEJEM accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		private static void DebugLogRemove(int index, NNDEHNEEJEM accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x2241000", Offset = "0x2240400", VA = "0x182241000")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void DebugLogUninitializedTransformAccessArrayIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x2241000", Offset = "0x2240400", VA = "0x182241000")]
		private void RegisterTransforms_LambdaJob_0_Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x2241180", Offset = "0x2240580", VA = "0x182241180", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
		public RegisterTransforms()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
[EFDJEPLIMOC(typeof(DNMGNPMNFDI), new string[] { })]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
internal sealed class DNMGNPMNFDI : OOLEGKACHHE, DEPDOFHIDBA, AKFIPDJCCOH, CBKELFDIEEL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	private AOONNPAOEFB FHJACJEANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	[ONGFANECMJO]
	private PFJMBDHJHAN BDLCNPMEDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	[ONGFANECMJO]
	private PGKBPEGCPKO KMPMKIKDFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	[ONGFANECMJO]
	private MLIEFKPODIE FBCPJLHEMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	[ONGFANECMJO]
	private BPJPLKILODH PJDNDHAAPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	[ONGFANECMJO]
	private KGINENEDIOC CMFPLPGONGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	[ONGFANECMJO]
	private GCNJIPMMPBN HBKLPJBKKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	[ONGFANECMJO]
	private NICJNOMPEDE GKOGFPHIKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	private readonly Dictionary<CMFFIMLEPBE, CJHAGIKCJCL> AJMOKMGBAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	private KDHGDKMHHJP HFAEEBBGJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	private bool MMLDFGNKLLJ;

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	private EntityManager FCLKPLIBOOP
	{
		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x252AEC0", Offset = "0x252A2C0", VA = "0x18252AEC0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x10A3FB0", Offset = "0x10A33B0", VA = "0x1810A3FB0", Slot = "4")]
	public void MCOOCEGHCPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x2529C60", Offset = "0x2529060", VA = "0x182529C60", Slot = "5")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0x2529EC0", Offset = "0x25292C0", VA = "0x182529EC0")]
	public void JNAIFDNHNFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x2529DE0", Offset = "0x25291E0", VA = "0x182529DE0", Slot = "6")]
	public void JFCLKDMBJND(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0x25283C0", Offset = "0x25277C0", VA = "0x1825283C0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0x2527A20", Offset = "0x2526E20", VA = "0x182527A20")]
	public int CJDFFFLCCIG(SceneTag EOOPPEEEACO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(RVA = "0x2527A40", Offset = "0x2526E40", VA = "0x182527A40")]
	public bool CKMMCAGLLNK(Entity FKNFFDFGNMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(RVA = "0x2527A00", Offset = "0x2526E00", VA = "0x182527A00")]
	public bool CGEGNOGJDCD(Entity FKNFFDFGNMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x2527400", Offset = "0x2526800", VA = "0x182527400")]
	public bool BDGDJOEOFJD(Entity FKNFFDFGNMN, out CJHAGIKCJCL FCGEAJNLBED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x2527480", Offset = "0x2526880", VA = "0x182527480")]
	private bool BDGDJOEOFJD(Transform FELEGEFPADK, out CJHAGIKCJCL FCGEAJNLBED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x2528A60", Offset = "0x2527E60", VA = "0x182528A60")]
	private void GHDACDPKBCM(Entity FKNFFDFGNMN, CJHAGIKCJCL FCGEAJNLBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x2528240", Offset = "0x2527640", VA = "0x182528240")]
	private bool CPDJCFLACPL(Entity FKNFFDFGNMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x2528470", Offset = "0x2527870", VA = "0x182528470")]
	public void FIMKNKKCEGK(CMFFIMLEPBE AIOICCOKGOP, CJHAGIKCJCL CJBENKPGJFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x252A8A0", Offset = "0x2529CA0", VA = "0x18252A8A0")]
	public bool PJAEEICDDNM(KDLENLDMBAK LCODCOPGHJA, object GAOLOMEJCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x252A830", Offset = "0x2529C30", VA = "0x18252A830")]
	public bool PJAEEICDDNM(Entity FKNFFDFGNMN, [Optional] object GAOLOMEJCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0x252A800", Offset = "0x2529C00", VA = "0x18252A800")]
	public bool PJAEEICDDNM(CJHAGIKCJCL KKPHHAGKLLH, object GAOLOMEJCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x2527CA0", Offset = "0x25270A0", VA = "0x182527CA0")]
	public bool CLGLMEJAHPF(Entity FKNFFDFGNMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x252A7D0", Offset = "0x2529BD0", VA = "0x18252A7D0")]
	public bool PJAEEICDDNM(CJHAGIKCJCL FCGEAJNLBED, bool FCCLLNHHFFA, [Optional] object GAOLOMEJCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x2529F10", Offset = "0x2529310", VA = "0x182529F10")]
	private bool LGFPJEPHNNJ(CJHAGIKCJCL FCGEAJNLBED, object GAOLOMEJCOK, bool FCCLLNHHFFA, bool EKLIDFHIGEM, bool PGOPPKOGOGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x2529810", Offset = "0x2528C10", VA = "0x182529810")]
	public Transform IDIBIJPKICM(Entity FKNFFDFGNMN, [Optional] object GAOLOMEJCOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x2527030", Offset = "0x2526430", VA = "0x182527030")]
	public bool AMHGHJGADGN(Entity FKNFFDFGNMN, out Transform FELEGEFPADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x252A590", Offset = "0x2529990", VA = "0x18252A590")]
	public CJHAGIKCJCL MIPMPNEGLMG(Entity FKNFFDFGNMN, [Optional] object GAOLOMEJCOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x25270F0", Offset = "0x25264F0", VA = "0x1825270F0")]
	public void AMHGOGMPBJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x2527530", Offset = "0x2526930", VA = "0x182527530")]
	public void BMHGPDJCGNF(SceneTag EOOPPEEEACO, bool EKLIDFHIGEM, NativeParallelHashSet<int> JLMEBGOBPAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x2528CA0", Offset = "0x25280A0", VA = "0x182528CA0")]
	private void HHHGLGKNGJP(Entity FKNFFDFGNMN, bool EKLIDFHIGEM, bool PGOPPKOGOGB, NativeParallelHashSet<int> JLMEBGOBPAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(RVA = "0x2529790", Offset = "0x2528B90", VA = "0x182529790")]
	public bool IDHHCLLPEJO(Entity FKNFFDFGNMN, object GAOLOMEJCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x2528260", Offset = "0x2527660", VA = "0x182528260")]
	public bool DDGMIIBELPN(Entity FKNFFDFGNMN, object GAOLOMEJCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x2526C40", Offset = "0x2526040", VA = "0x182526C40")]
	public bool ACCCALIBIEJ(Entity FKNFFDFGNMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0x252A480", Offset = "0x2529880", VA = "0x18252A480")]
	private void LNCAPHKCAPN(bool KKNCPEJEKOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x2527970", Offset = "0x2526D70", VA = "0x182527970")]
	private bool CDNOCBLNLJF(Entity FKNFFDFGNMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x252A540", Offset = "0x2529940", VA = "0x18252A540")]
	public CJHAGIKCJCL MINLNEAGDBD(Entity FKNFFDFGNMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0x252A660", Offset = "0x2529A60", VA = "0x18252A660")]
	private CJHAGIKCJCL OFFHLLCOAML(Entity FKNFFDFGNMN, object GAOLOMEJCOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(RVA = "0x25299F0", Offset = "0x2528DF0", VA = "0x1825299F0")]
	private CJHAGIKCJCL ILNNCLJIJJA(Entity FKNFFDFGNMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000714")]
	[Cpp2IlInjected.Address(RVA = "0x2528B00", Offset = "0x2527F00", VA = "0x182528B00")]
	public void HBBDDECODBD(NativeArray<CMFFIMLEPBE> MAEMAKOHEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(RVA = "0x25278A0", Offset = "0x2526CA0", VA = "0x1825278A0")]
	private void BMPHBOJEJEI(KDLENLDMBAK LCODCOPGHJA, CJHAGIKCJCL CJBENKPGJFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000716")]
	[Cpp2IlInjected.Address(RVA = "0x25296C0", Offset = "0x2528AC0", VA = "0x1825296C0")]
	private void HMOMCGCOCPK(CJHAGIKCJCL CJBENKPGJFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x2526D00", Offset = "0x2526100", VA = "0x182526D00")]
	private void AFMLFDJONPO(CJHAGIKCJCL FCGEAJNLBED, Entity FKNFFDFGNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x2528660", Offset = "0x2527A60", VA = "0x182528660")]
	private void GEHHJKCKHAF(Entity FKNFFDFGNMN, CJHAGIKCJCL FCGEAJNLBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x25282E0", Offset = "0x25276E0", VA = "0x1825282E0")]
	private void DPKHLLFFDNL(Entity FKNFFDFGNMN, Transform FELEGEFPADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x2529D90", Offset = "0x2529190", VA = "0x182529D90")]
	private KDLENLDMBAK JAEMFBMMNNL(Entity FKNFFDFGNMN)
	{
		return default(KDLENLDMBAK);
	}

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(RVA = "0x252AFA0", Offset = "0x252A3A0", VA = "0x18252AFA0")]
	public DNMGNPMNFDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x252A700", Offset = "0x2529B00", VA = "0x18252A700")]
	[CompilerGenerated]
	private void PCGLEKLMMJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public struct CJPEPCAHCNO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public AJIEIAAKCCA PPCGBBAKOHO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x7E80A0", Offset = "0x7E74A0", VA = "0x1807E80A0")]
	public static CJPEPCAHCNO PGDDHPNABOB(in AJIEIAAKCCA CBLOHEIPBDC)
	{
		return default(CJPEPCAHCNO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x7E80A0", Offset = "0x7E74A0", VA = "0x1807E80A0")]
	public static AJIEIAAKCCA PGDDHPNABOB(in CJPEPCAHCNO OEBODPMPOAA)
	{
		return default(AJIEIAAKCCA);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	[ALIINGEKIMD]
	public class PostDeserializeUpgrade_Split_ContainerData : JKIEMPJPHGI, IBKHNFKEFMN.GPOJBALCDLB
	{
		[Cpp2IlInjected.Token(Token = "0x2000117")]
		[NoAlias]
		[BurstCompile]
		private struct PostDeserializeUpgrade_Split_ContainerData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			public NativeArray<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			public NativeArray<GMLBDPBDFED> v1Data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			public ComponentTypes newComponents;

			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x3DE88B0", Offset = "0x3DE7CB0", VA = "0x183DE88B0")]
			private void EJBLFCAPFKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0x3DE8B60", Offset = "0x3DE7F60", VA = "0x183DE8B60", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private static readonly PILIJFIMAJF log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private ComponentType[] newComponentTypes;

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x223B520", Offset = "0x223A920", VA = "0x18223B520", Slot = "14")]
		public IEnumerable<IBKHNFKEFMN.AHKJOPMIMKP> JAONDHGNIEF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x223B640", Offset = "0x223AA40", VA = "0x18223B640", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x223B5F0", Offset = "0x223A9F0", VA = "0x18223B5F0")]
		private EntityCommandBufferSystem KMBJDEEDCKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x223BA80", Offset = "0x223AE80", VA = "0x18223BA80")]
		private JobHandle PJJAKLMJFMH(EntityCommandBuffer ecb, NativeArray<Entity> entities, NativeArray<GMLBDPBDFED> v1Data, ComponentTypes newComponents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x223BC60", Offset = "0x223B060", VA = "0x18223BC60")]
		public PostDeserializeUpgrade_Split_ContainerData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
internal class LJPNMKKEDNN : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	private EntityQuery PNGFJEAJDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	private AOONNPAOEFB FHJACJEANIP;

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x2A60EE0", Offset = "0x2A602E0", VA = "0x182A60EE0", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x2A60F30", Offset = "0x2A60330", VA = "0x182A60F30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x2A60FF0", Offset = "0x2A603F0", VA = "0x182A60FF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x2A60C10", Offset = "0x2A60010", VA = "0x182A60C10")]
	private NativeArray<Entity> ENJDNLMFEMF(int ECOAGJBCGAI)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(RVA = "0x2A60DD0", Offset = "0x2A601D0", VA = "0x182A60DD0")]
	private void HLHJNJAFDMN(NativeArray<Entity> GBIBKJFKLDC, NativeArray<Entity> JCDNANLLLKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public LJPNMKKEDNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
[DefaultMember("Item")]
public struct CKDBDNHCBFH<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	private DAAOPGJAJOL<T> KJFNAECAHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	private int PGBALNGGNPG;

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x328A5B0", Offset = "0x32899B0", VA = "0x18328A5B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x328A600", Offset = "0x3289A00", VA = "0x18328A600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
[BurstCompile]
public struct IMFAAJOOHCA<T> : IEqualityComparer<ArchetypeChunk> where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	[ReadOnly]
	public SharedComponentTypeHandle<T> PLNLPDHJOPL;

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x19E8DF0", Offset = "0x19E81F0", VA = "0x1819E8DF0")]
	public IMFAAJOOHCA(SharedComponentTypeHandle<T> PLNLPDHJOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x2592890", Offset = "0x2591C90", VA = "0x182592890", Slot = "4")]
	public bool Equals(ArchetypeChunk GEAEMIOLNKK, ArchetypeChunk KFMHCNGHPHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0x25929A0", Offset = "0x2591DA0", VA = "0x1825929A0", Slot = "5")]
	public int GetHashCode(ArchetypeChunk NCPBFICMLEP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
[EBCKCHNKEDI]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
public class GNEIGJIFKLO : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	private MLIPPJCKHBF DGLIEJINEGA;

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x28DA9A0", Offset = "0x28D9DA0", VA = "0x1828DA9A0", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x28DA9F0", Offset = "0x28D9DF0", VA = "0x1828DA9F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public GNEIGJIFKLO()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	[EBCKCHNKEDI]
	[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
	public class UpdateConnectableVisuals : JKIEMPJPHGI, AKFIPDJCCOH
	{
		[Cpp2IlInjected.Token(Token = "0x200011D")]
		private struct HandlePosition
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			public BHFODDCOKNF handle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			public float3 position;

			[Cpp2IlInjected.Token(Token = "0x600075D")]
			[Cpp2IlInjected.Address(RVA = "0x3DE6580", Offset = "0x3DE5980", VA = "0x183DE6580")]
			public HandlePosition(BHFODDCOKNF handle, float3 position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600075E")]
			[Cpp2IlInjected.Address(RVA = "0x3DE6560", Offset = "0x3DE5960", VA = "0x183DE6560")]
			public void IAFKAHLPOAN(out BHFODDCOKNF handle, out float3 position)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011E")]
		private struct UpdateVisualPositions_ParentWoutCoM_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			public UpdateConnectableVisuals __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			public NativeList<HandlePosition> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			[ReadOnly]
			public ComponentTypeHandle<HNDLOHCHOMJ> __poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			public BufferTypeHandle<DIHOLKIOMAL> __stateTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0x3DEE650", Offset = "0x3DEDA50", VA = "0x183DEE650")]
			private void EJBLFCAPFKM(Entity entity, in HNDLOHCHOMJ pose, DynamicBuffer<DIHOLKIOMAL> state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000760")]
			[Cpp2IlInjected.Address(RVA = "0x3DEE8D0", Offset = "0x3DEDCD0", VA = "0x183DEE8D0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011F")]
		[NoAlias]
		[BurstCompile]
		private struct UpdateVisualPositions_ChildWoutCoM_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public NativeList<HandlePosition> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			[ReadOnly]
			public ComponentTypeHandle<HNDLOHCHOMJ> __poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			public BufferTypeHandle<OIOMMJOPPHE> __stateTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(RVA = "0x3DEE3F0", Offset = "0x3DED7F0", VA = "0x183DEE3F0")]
			private void EJBLFCAPFKM([NoAlias] in HNDLOHCHOMJ pose, DynamicBuffer<OIOMMJOPPHE> state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(RVA = "0x3DEE4E0", Offset = "0x3DED8E0", VA = "0x183DEE4E0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000120")]
		[BurstCompile]
		[NoAlias]
		private struct UpdateVisualPositions_ChildWithCoM_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			public NativeList<HandlePosition> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			[ReadOnly]
			public ComponentTypeHandle<HNDLOHCHOMJ> __poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			[ReadOnly]
			public ComponentTypeHandle<EPPAOJFMIIL> __comTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			public BufferTypeHandle<OIOMMJOPPHE> __stateTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(RVA = "0x3DEE0D0", Offset = "0x3DED4D0", VA = "0x183DEE0D0")]
			private void EJBLFCAPFKM([NoAlias] in HNDLOHCHOMJ pose, [NoAlias] in EPPAOJFMIIL com, DynamicBuffer<OIOMMJOPPHE> state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000764")]
			[Cpp2IlInjected.Address(RVA = "0x3DEE210", Offset = "0x3DED610", VA = "0x183DEE210", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private static readonly PILIJFIMAJF log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private EntityQuery addGizmos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private EntityQuery addGizmosInScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private EntityQuery updateGizmos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private EntityQuery updateGizmosInScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private EntityQuery removeExpiredGizmos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private EntityQuery removeExpiredGizmosInScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private EntityQuery removeAllGizmos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private EntityQuery queryLegacyGizmoParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private EntityQuery queryChildrenWoutCom;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private EntityQuery queryChildrenWithCom;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private FAFDPBICOBM<BHFODDCOKNF, ICOBLLMLJBN> linkVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private BGNPLHOEAII connectables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private AOONNPAOEFB objects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private BKIGCJIBBEC scope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private BJPDMBGDPHK makerPen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private EntityQuery UpdateVisualPositions_ParentWoutCoM_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private EntityQuery UpdateVisualPositions_ChildWoutCoM_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private EntityQuery UpdateVisualPositions_ChildWithCoM_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private ComponentTypeHandle<HNDLOHCHOMJ> __RecRoom_Components_WorldPoseData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private ComponentTypeHandle<EPPAOJFMIIL> __RecRoom_Rbex_RbexLocalCenterOfMassOfSelfData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000738")]
			[Cpp2IlInjected.Address(RVA = "0x22461B0", Offset = "0x22455B0", VA = "0x1822461B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x2246160", Offset = "0x2245560", VA = "0x182246160")]
		internal ICOBLLMLJBN JJKJLMCHBKL(BHFODDCOKNF handle)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x2245F00", Offset = "0x2245300", VA = "0x182245F00", Slot = "14")]
		public void InitReferences(EMFBCBAOENA services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0x2247DF0", Offset = "0x22471F0", VA = "0x182247DF0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0x2248060", Offset = "0x2247460", VA = "0x182248060", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(RVA = "0x22481F0", Offset = "0x22475F0", VA = "0x1822481F0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0x2248020", Offset = "0x2247420", VA = "0x182248020", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0x2244670", Offset = "0x2243A70", VA = "0x182244670")]
		private void CEMBINFONEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x2246B00", Offset = "0x2245F00", VA = "0x182246B00")]
		private void NOLNKDNCKBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x22471C0", Offset = "0x22465C0", VA = "0x1822471C0")]
		private void OJBHFCPHLEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x2248230", Offset = "0x2247630", VA = "0x182248230", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x2244780", Offset = "0x2243B80", VA = "0x182244780")]
		private void COCGDBGCNKP(EntityQuery add, EntityQuery update, EntityQuery remove)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x2248360", Offset = "0x2247760", VA = "0x182248360")]
		private void PBDAKCGNFND(EntityQuery remove)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x2246740", Offset = "0x2245B40", VA = "0x182246740")]
		private void LLENLNCEJCL(NativeArrayAsync<Entity> oldEntities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x22451A0", Offset = "0x22445A0", VA = "0x1822451A0")]
		private void FDIDDKEHKEH(NativeArrayAsync<Entity> newEntities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x2243E40", Offset = "0x2243240", VA = "0x182243E40")]
		private void ADEKEHBONJM(NativeArrayAsync<Entity> updateEntities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x2246640", Offset = "0x2245A40", VA = "0x182246640")]
		private void LIKADJNJLMB(NativeList<BHFODDCOKNF> freeLinks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x2246C40", Offset = "0x2246040", VA = "0x182246C40")]
		private NativeList<BHFODDCOKNF> OCOPNAEECKA(NativeArray<Entity> entities)
		{
			return default(NativeList<BHFODDCOKNF>);
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x2245920", Offset = "0x2244D20", VA = "0x182245920")]
		private void HEOODBOIPFI(NativeArray<Entity> entities, NativeList<BHFODDCOKNF> freeLinks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x2244C30", Offset = "0x2244030", VA = "0x182244C30")]
		private void DLNIFONHCII(NativeArray<Entity> addParents, NativeArray<Entity> addChildren, NativeList<BHFODDCOKNF> freeList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x22461F0", Offset = "0x22455F0", VA = "0x1822461F0")]
		private void LAHLJHPJEHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0x2247570", Offset = "0x2246970", VA = "0x182247570")]
		private NativeListAsync<HandlePosition> ONEALHNDBNP(EntityQuery query, Func<NativeList<HandlePosition>, JobHandle> populateHandles)
		{
			return default(NativeListAsync<HandlePosition>);
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x2248440", Offset = "0x2247840", VA = "0x182248440")]
		private JobHandle POJBAIPEPFA(NativeList<HandlePosition> list)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x22457B0", Offset = "0x2244BB0", VA = "0x1822457B0")]
		private JobHandle GNDIMIAJDEJ(NativeList<HandlePosition> list)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x22452B0", Offset = "0x22446B0", VA = "0x1822452B0")]
		private JobHandle FKENBIMNICM(NativeList<HandlePosition> list)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x22443E0", Offset = "0x22437E0", VA = "0x1822443E0")]
		private void CBJJAEODKFB(NativeListAsync<HandlePosition> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x2245520", Offset = "0x2244920", VA = "0x182245520")]
		private void FNFLPMIHLFG(NativeListAsync<HandlePosition> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x2245EA0", Offset = "0x22452A0", VA = "0x182245EA0")]
		private bool IECEJIBAOPF(Entity entity)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x2245450", Offset = "0x2244850", VA = "0x182245450")]
		private NativeArray<Entity> FLELAAIGIAN(Entity entity)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x2243FE0", Offset = "0x22433E0", VA = "0x182243FE0")]
		private BHFODDCOKNF AHOFBLPPJAF(NativeList<BHFODDCOKNF> freeList)
		{
			return default(BHFODDCOKNF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x22442F0", Offset = "0x22436F0", VA = "0x1822442F0")]
		private void BBPLDLEKFNL(BHFODDCOKNF handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x22441A0", Offset = "0x22435A0", VA = "0x1822441A0")]
		private void APIDLKLJDPG(ref NativeList<HandlePosition> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x2246990", Offset = "0x2245D90", VA = "0x182246990")]
		private JobHandle NNNLNAECKIB(NativeList<HandlePosition> list, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x2245FC0", Offset = "0x22453C0", VA = "0x182245FC0")]
		private JobHandle JDFLEGIOOBI(NativeList<HandlePosition> list, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x22476D0", Offset = "0x2246AD0", VA = "0x1822476D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
		public UpdateConnectableVisuals()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	[AlwaysUpdateSystem]
	[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
	internal sealed class WriteDiffChangePacketToNetworkSystem : JKIEMPJPHGI, AKFIPDJCCOH
	{
		[Cpp2IlInjected.Token(Token = "0x2000123")]
		[BurstCompile]
		[NoAlias]
		private struct WriteDiffChangePacketToNetworkSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.Token(Token = "0x2000124")]
			public delegate void RunWithoutJobSystem_00000913$PostfixBurstDelegate(IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x2000125")]
			internal static class RunWithoutJobSystem_00000913$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x40003F8")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x40003F9")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x6000784")]
				[Cpp2IlInjected.Address(RVA = "0x3DEB2C0", Offset = "0x3DEA6C0", VA = "0x183DEB2C0")]
				[BurstDiscard]
				private static void BPOGIOPNKPI(ref IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000785")]
				[Cpp2IlInjected.Address(RVA = "0x3DEB6F0", Offset = "0x3DEAAF0", VA = "0x183DEB6F0")]
				private static IntPtr OGEDALIJNIF()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000786")]
				[Cpp2IlInjected.Address(RVA = "0x3DEB630", Offset = "0x3DEAA30", VA = "0x183DEB630")]
				public static void JEJODENPHGJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000787")]
				[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
				public static void BEFDPLAELIH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000789")]
				[Cpp2IlInjected.Address(RVA = "0x3DEB410", Offset = "0x3DEA810", VA = "0x183DEB410")]
				public static void GDOLIKHHLHI(IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public NGMJNNOBIHE replication;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			public NativeBitArray entityByProperty;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			[ReadOnly]
			public NativeArray<CMFFIMLEPBE> srcCreatedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			[ReadOnly]
			public NativeArray<EFFOMHNHCBO> srcCreationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			[ReadOnly]
			public NativeArray<CMFFIMLEPBE> srcDestroyedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			[ReadOnly]
			public NativeKeyValueArrays<Entity, ELGEKKCACLJ> srcPropertyKeyValues;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public NativeList<CMFFIMLEPBE> dstCreatedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public NativeList<EFFOMHNHCBO> dstCreationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			public NativeList<CMFFIMLEPBE> dstDestroyedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			public NativeParallelMultiHashMap<CMFFIMLEPBE, GPPEENBHCHN> dstProperties;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			public NativeList<byte> dstPropertyData;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			public ComponentDataFromEntity<PCCFEGNEHCE> __RecRoom_Components_ObjectNetworkIdComponentData_FromEntity;

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(RVA = "0x3DEEAF0", Offset = "0x3DEDEF0", VA = "0x183DEEAF0")]
			private void EJBLFCAPFKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077D")]
			[Cpp2IlInjected.Address(RVA = "0x3DEEFE0", Offset = "0x3DEE3E0", VA = "0x183DEEFE0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(RVA = "0x3DEEA90", Offset = "0x3DEDE90", VA = "0x183DEEA90")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void CFNDGCJBDDN(IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077F")]
			[Cpp2IlInjected.Address(RVA = "0x3DEEFF0", Offset = "0x3DEE3F0", VA = "0x183DEEFF0")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void HFPJMCLHCIA(IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private static readonly PILIJFIMAJF log;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private static readonly PILIJFIMAJF logEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		[ONGFANECMJO]
		private CPCDMMFNECK packetService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		[ONGFANECMJO]
		private EGBDNLKFOBI diffService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		[ONGFANECMJO]
		private IPJCHCHPAMO editorEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		[ONGFANECMJO]
		private DIOBGNHCMAF transmission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private OOCAJGPOFDB.PGACPGAILCB utilServices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		private bool HasEditorListeners
		{
			[Cpp2IlInjected.Token(Token = "0x600076A")]
			[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		private ECMNFJLFBIC EventFlagsForPhase
		{
			[Cpp2IlInjected.Token(Token = "0x600076D")]
			[Cpp2IlInjected.Address(RVA = "0x271AB20", Offset = "0x2719F20", VA = "0x18271AB20")]
			get
			{
				return default(ECMNFJLFBIC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x271A950", Offset = "0x2719D50", VA = "0x18271A950", Slot = "14")]
		public void InitReferences(EMFBCBAOENA services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x271BAE0", Offset = "0x271AEE0", VA = "0x18271BAE0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x271AC10", Offset = "0x271A010", VA = "0x18271AC10")]
		private bool LNDBLMLCOGG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x271AA10", Offset = "0x2719E10", VA = "0x18271AA10")]
		private bool JALEFMEKGDK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x271A900", Offset = "0x2719D00", VA = "0x18271A900")]
		private bool HKGFALGBONF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x271B020", Offset = "0x271A420", VA = "0x18271B020")]
		private OOCAJGPOFDB.JBNPJDKPNAO MPPFMGAEEHH(PGBPMCLMNHE state)
		{
			return default(OOCAJGPOFDB.JBNPJDKPNAO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x271ACE0", Offset = "0x271A0E0", VA = "0x18271ACE0")]
		private NativeKeyValueArrays<Entity, ELGEKKCACLJ> MJNHNELMJMP(PGBPMCLMNHE state, out int capacity)
		{
			return default(NativeKeyValueArrays<Entity, ELGEKKCACLJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x2719680", Offset = "0x2718A80", VA = "0x182719680")]
		private void ANPIDEIABAF(OOCAJGPOFDB.JBNPJDKPNAO data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x271AF30", Offset = "0x271A330", VA = "0x18271AF30")]
		private void MMHHMMDEGLF(OOCAJGPOFDB.JBNPJDKPNAO data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x271A1C0", Offset = "0x27195C0", VA = "0x18271A1C0")]
		private void FEEDCKMDHJM(OOCAJGPOFDB.JBNPJDKPNAO data, PGBPMCLMNHE state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x27199E0", Offset = "0x2718DE0", VA = "0x1827199E0")]
		private void BFHCJFCPPCJ(NativeArray<CMFFIMLEPBE> createdIds, NativeArray<EFFOMHNHCBO> creationData, ECMNFJLFBIC flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x2719AF0", Offset = "0x2718EF0", VA = "0x182719AF0")]
		private void EHIEPLAHDMD(NativeMultiHashMapAsync<Entity, ELGEKKCACLJ> differences, ECMNFJLFBIC flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x271A570", Offset = "0x2719970", VA = "0x18271A570")]
		private void GIGBPKKKDIH(NativeArray<CMFFIMLEPBE> destroyedIds, ECMNFJLFBIC flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x271A630", Offset = "0x2719A30", VA = "0x18271A630")]
		private void HAAELLJHIOB(ref NGMJNNOBIHE replication, ref NativeBitArray entityByProperty, ref NativeArray<CMFFIMLEPBE> srcCreatedIds, ref NativeArray<EFFOMHNHCBO> srcCreationData, ref NativeArray<CMFFIMLEPBE> srcDestroyedIds, ref NativeKeyValueArrays<Entity, ELGEKKCACLJ> srcPropertyKeyValues, ref NativeList<CMFFIMLEPBE> dstCreatedIds, ref NativeList<EFFOMHNHCBO> dstCreationData, ref NativeList<CMFFIMLEPBE> dstDestroyedIds, ref NativeParallelMultiHashMap<CMFFIMLEPBE, GPPEENBHCHN> dstProperties, ref NativeList<byte> dstPropertyData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x271B880", Offset = "0x271AC80", VA = "0x18271B880", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
		public WriteDiffChangePacketToNetworkSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x271ABC0", Offset = "0x2719FC0", VA = "0x18271ABC0")]
		public static void JPLENHBILGN()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
internal readonly struct BCKNEBNOIKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	private readonly FMHGLEAKEIM CBOGLIIPGED;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	private static readonly ProfilerMarker EFGOHNJJAOH;

	[Cpp2IlInjected.Token(Token = "0x600078A")]
	[Cpp2IlInjected.Address(RVA = "0x2511660", Offset = "0x2510A60", VA = "0x182511660")]
	public BCKNEBNOIKL(World GLMOAKNBFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078B")]
	[Cpp2IlInjected.Address(RVA = "0x25114D0", Offset = "0x25108D0", VA = "0x1825114D0")]
	public JobHandle COCGDBGCNKP(JobHandle HIGKDFHBJCK)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
internal static class DDJKGPIHLCA
{
	[Cpp2IlInjected.Token(Token = "0x600078D")]
	[Cpp2IlInjected.Address(RVA = "0x268EFE0", Offset = "0x268E3E0", VA = "0x18268EFE0")]
	public static NativeArray<T> JLMINEFFHPP<T>(NativeArray<Entity> PGJLMFPAKDA, EntityManager GLPCEPPDPLB) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600078E")]
	[Cpp2IlInjected.Address(RVA = "0x2522660", Offset = "0x2521A60", VA = "0x182522660")]
	public static void AMJEFBNLFFH(EntityQuery PNGFJEAJDGO, EntityManager GLPCEPPDPLB, AOONNPAOEFB FHJACJEANIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078F")]
	[Cpp2IlInjected.Address(RVA = "0x25227A0", Offset = "0x2521BA0", VA = "0x1825227A0")]
	public static void CDJGJFMJNBB(NativeArray<Entity> GBIBKJFKLDC, AOONNPAOEFB FHJACJEANIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000790")]
	[Cpp2IlInjected.Address(RVA = "0x25228F0", Offset = "0x2521CF0", VA = "0x1825228F0")]
	public static void PPLHNFLKFOH(NativeArray<Entity> GBIBKJFKLDC, AOONNPAOEFB FHJACJEANIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
public class PGAHCDANCHA : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	private DPDGJLIFKMC NHCJIPNFMGB;

	[Cpp2IlInjected.Token(Token = "0x6000791")]
	[Cpp2IlInjected.Address(RVA = "0x222F3F0", Offset = "0x222E7F0", VA = "0x18222F3F0", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000792")]
	[Cpp2IlInjected.Address(RVA = "0x222F440", Offset = "0x222E840", VA = "0x18222F440", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000793")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public PGAHCDANCHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public class KPCMLPBMLGM : JKIEMPJPHGI
{
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	private static PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	private EntityQuery FNFHJAGAJCP;

	[Cpp2IlInjected.Token(Token = "0x6000794")]
	[Cpp2IlInjected.Address(RVA = "0x2898250", Offset = "0x2897650", VA = "0x182898250", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000795")]
	[Cpp2IlInjected.Address(RVA = "0x28984F0", Offset = "0x28978F0", VA = "0x1828984F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000796")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public KPCMLPBMLGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
internal struct LKKINKJNPNA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	private static readonly ProfilerMarker EFGOHNJJAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	private readonly JKIEMPJPHGI JJBAHIPIPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	private NativeList<(EntityQuery query, int componentIndex)> IGAFMONCCPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	private NativeList<(EntityQuery query, int componentIndex)> KJBENMBPPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	private NativeList<(EntityQuery query, int componentIndex)> OFMMHDMNFLN;

	[Cpp2IlInjected.Token(Token = "0x6000798")]
	[Cpp2IlInjected.Address(RVA = "0x2A62100", Offset = "0x2A61500", VA = "0x182A62100")]
	public LKKINKJNPNA(JKIEMPJPHGI JJBAHIPIPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000799")]
	[Cpp2IlInjected.Address(RVA = "0x2A61940", Offset = "0x2A60D40", VA = "0x182A61940", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079A")]
	[Cpp2IlInjected.Address(RVA = "0x2A619A0", Offset = "0x2A60DA0", VA = "0x182A619A0")]
	public NativeList<(EntityQuery, int, int, EOLDLAAGOPC.NCEKOCOMNLC)> IGBEAGNMEGE(uint JHFCHEEONFK, out int BHMPAAGKHCH)
	{
		return default(NativeList<(EntityQuery, int, int, EOLDLAAGOPC.NCEKOCOMNLC)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600079B")]
	[Cpp2IlInjected.Address(RVA = "0x2A61790", Offset = "0x2A60B90", VA = "0x182A61790")]
	private int DPPFHIACNOD(EOLDLAAGOPC.NCEKOCOMNLC MMGKIPGKNHG, NativeList<(EntityQuery query, int typeIndex)> IGBONFEPFAO, NativeList<(EntityQuery query, int typeIndex, int count, EOLDLAAGOPC.NCEKOCOMNLC mode)> IMNECLPHLGG, uint JHFCHEEONFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600079C")]
	[Cpp2IlInjected.Address(RVA = "0x2A61FB0", Offset = "0x2A613B0", VA = "0x182A61FB0")]
	private NativeList<(EntityQuery, int)> LDDAEIGLILN(NativeParallelHashSet<int> NMIBCPIHMNH, int EALOHFBBPOF)
	{
		return default(NativeList<(EntityQuery, int)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0x2A61FF0", Offset = "0x2A613F0", VA = "0x182A61FF0")]
	private NativeList<(EntityQuery, int)> MKJPAKFNHAB(NativeParallelHashSet<int> NMIBCPIHMNH, int EALOHFBBPOF)
	{
		return default(NativeList<(EntityQuery, int)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600079E")]
	[Cpp2IlInjected.Address(RVA = "0x2A61BD0", Offset = "0x2A60FD0", VA = "0x182A61BD0")]
	private NativeList<(EntityQuery, int)> KFPPIEMGOBL(NativeParallelHashSet<int> NMIBCPIHMNH, int EALOHFBBPOF, EOLDLAAGOPC.NCEKOCOMNLC MMGKIPGKNHG)
	{
		return default(NativeList<(EntityQuery, int)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600079F")]
	[Cpp2IlInjected.Address(RVA = "0x2A614A0", Offset = "0x2A608A0", VA = "0x182A614A0")]
	private NativeList<(EntityQuery, int)> ALEBHPIFBAK()
	{
		return default(NativeList<(EntityQuery, int)>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public enum DINANNGALDJ
{
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	NewParent,
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	ChangedParent,
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	OldParent
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public struct CDLJJAHPLFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public DINANNGALDJ EDNGDELIOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public int AEPPGJOKKGP;

	[Cpp2IlInjected.Token(Token = "0x60007A1")]
	[Cpp2IlInjected.Address(RVA = "0xA28DB0", Offset = "0xA281B0", VA = "0x180A28DB0")]
	public CDLJJAHPLFA(DINANNGALDJ EDNGDELIOBC, int AEPPGJOKKGP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60007A2")]
	[Cpp2IlInjected.Address(RVA = "0x2516990", Offset = "0x2515D90", VA = "0x182516990")]
	public static CDLJJAHPLFA PGDDHPNABOB((DINANNGALDJ eventType, int eventIndex) GEAEMIOLNKK)
	{
		return default(CDLJJAHPLFA);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A3")]
	[Cpp2IlInjected.Address(RVA = "0x2516980", Offset = "0x2515D80", VA = "0x182516980")]
	public void IAFKAHLPOAN(out DINANNGALDJ EDNGDELIOBC, out int AEPPGJOKKGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public struct BHLLODNGMFM<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	private HDBJHGJLHNF<T> HEGEMCIFGEI;

	[Cpp2IlInjected.Token(Token = "0x60007A4")]
	[Cpp2IlInjected.Address(RVA = "0x24CA7C0", Offset = "0x24C9BC0", VA = "0x1824CA7C0")]
	public BHLLODNGMFM(HDBJHGJLHNF<T> HEGEMCIFGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A5")]
	[Cpp2IlInjected.Address(RVA = "0x24CA640", Offset = "0x24C9A40", VA = "0x1824CA640")]
	public BBAGIBOCELJ<T> JOELDEHDNMM()
	{
		return default(BBAGIBOCELJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public readonly struct ELGEKKCACLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private readonly GLFLLKHPAHK MLGAFKBKMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	private readonly int IBJLEPPHMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	private unsafe readonly byte* AJHJAEIINDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	private unsafe readonly byte* JHBNKDKKBDN;

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public GLFLLKHPAHK MNMNLKIGNGC
	{
		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0xBDECE0", Offset = "0xBDE0E0", VA = "0x180BDECE0")]
		get
		{
			return default(GLFLLKHPAHK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public int FMHNBEKGHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x16CFC90", Offset = "0x16CF090", VA = "0x1816CFC90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public unsafe byte* MAKLDGBLGKI
	{
		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0xA9C2D0", Offset = "0xA9B6D0", VA = "0x180A9C2D0")]
		get
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public unsafe byte* LGIKGINCOOE
	{
		[Cpp2IlInjected.Token(Token = "0x60007AC")]
		[Cpp2IlInjected.Address(RVA = "0x7E8110", Offset = "0x7E7510", VA = "0x1807E8110")]
		get
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007A8")]
	[Cpp2IlInjected.Address(RVA = "0x28C8DC0", Offset = "0x28C81C0", VA = "0x1828C8DC0")]
	public NBOENLAPDFO BLGBFPAEEBE(Type JLNNFEOBAMK)
	{
		return default(NBOENLAPDFO);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A9")]
	[Cpp2IlInjected.Address(RVA = "0x1F928F0", Offset = "0x1F91CF0", VA = "0x181F928F0")]
	public T PEJJNBKOPBJ<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007AA")]
	[Cpp2IlInjected.Address(RVA = "0x1F928D0", Offset = "0x1F91CD0", VA = "0x181F928D0")]
	public T BLGBFPAEEBE<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007AD")]
	[Cpp2IlInjected.Address(RVA = "0x28C8FA0", Offset = "0x28C83A0", VA = "0x1828C8FA0")]
	public unsafe ELGEKKCACLJ(GLFLLKHPAHK MLGAFKBKMCE, int JECAINLJFKC, byte* AJHJAEIINDB, byte* JHBNKDKKBDN)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200012F")]
internal struct INAEDKGBGKI : IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	[ALIINGEKIMD]
	public class PostDeserializeUpgrade_Convert_OMShapeContainerData : KOEELCMGFDH
	{
		[Cpp2IlInjected.Token(Token = "0x2000131")]
		[NoAlias]
		[BurstCompile]
		private struct PostDeserializeUpgrade_Convert_OMShapeContainerData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000411")]
			public NFONADLCMPK<JDCPFOCIBJC> v1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000412")]
			public BHLLODNGMFM<LCEBLCAALOE> v2;

			[Cpp2IlInjected.Token(Token = "0x60007B6")]
			[Cpp2IlInjected.Address(RVA = "0x3DE7950", Offset = "0x3DE6D50", VA = "0x183DE7950")]
			private void EJBLFCAPFKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0x3DE7BE0", Offset = "0x3DE6FE0", VA = "0x183DE7BE0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private static readonly PILIJFIMAJF log;

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		protected override PILIJFIMAJF Log
		{
			[Cpp2IlInjected.Token(Token = "0x60007AE")]
			[Cpp2IlInjected.Address(RVA = "0x2239C60", Offset = "0x2239060", VA = "0x182239C60", Slot = "14")]
			get
			{
				return default(PILIJFIMAJF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0x2239960", Offset = "0x2238D60", VA = "0x182239960", Slot = "15")]
		public override IEnumerable<IBKHNFKEFMN.AHKJOPMIMKP> JAONDHGNIEF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0x2239AF0", Offset = "0x2238EF0", VA = "0x182239AF0", Slot = "16")]
		protected override void KKMHPKEJHOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0x2239A20", Offset = "0x2238E20", VA = "0x182239A20")]
		private static void JKLHGJPJBOF(OAGAALHEKIF<JDCPFOCIBJC> srcVersion, OAGAALHEKIF<LCEBLCAALOE> dstVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0x2239830", Offset = "0x2238C30", VA = "0x182239830")]
		private JobHandle DOJILMPODGL(NFONADLCMPK<JDCPFOCIBJC> v1, BHLLODNGMFM<LCEBLCAALOE> v2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0x2239D50", Offset = "0x2239150", VA = "0x182239D50")]
		public PostDeserializeUpgrade_Convert_OMShapeContainerData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal class JCBKBJFMIBG : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	private EntityQuery PFDLDKIHEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private EntityQuery JANFNMGDLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	private HKFAIGLNOBD FBCPJLHEMAI;

	[Cpp2IlInjected.Token(Token = "0x60007B8")]
	[Cpp2IlInjected.Address(RVA = "0x2887A60", Offset = "0x2886E60", VA = "0x182887A60", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B9")]
	[Cpp2IlInjected.Address(RVA = "0x2887AB0", Offset = "0x2886EB0", VA = "0x182887AB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BA")]
	[Cpp2IlInjected.Address(RVA = "0x2887C00", Offset = "0x2887000", VA = "0x182887C00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BB")]
	[Cpp2IlInjected.Address(RVA = "0x28879F0", Offset = "0x2886DF0", VA = "0x1828879F0")]
	private void FGPIGMPFGAG(EntityQuery PNGFJEAJDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BC")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public JCBKBJFMIBG()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000133")]
public struct NLNJIILEPIG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
internal class FIACLIIFJJG : JDLBPHHOKOP, PGBPMCLMNHE
{
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private readonly KNHBDNEIEIA GHGKMCPGGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000419")]
	private readonly GCGDNGNDAMG GKOGFPHIKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400041A")]
	private readonly World GLMOAKNBFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400041B")]
	private readonly List<KAKBNCDEGLG> LACKIGFNMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400041C")]
	private NativeParallelMultiHashMap<Entity, ELGEKKCACLJ> JCOFAGHCNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400041D")]
	private NativeParallelHashMap<int, int> PAHJAPKFJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400041E")]
	private NativeArray<CMFFIMLEPBE> LMKFIAKIJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	private NativeArray<EFFOMHNHCBO> JONOBDJBMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000420")]
	private NativeArray<CMFFIMLEPBE> KNDKMEFEGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000421")]
	private JobHandle LNLDEMDCAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	private JobHandle BNCJGDDMKCA;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private NativeParallelMultiHashMap<Entity, ELGEKKCACLJ> IEBLJGJNFBI
	{
		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0xC0F7F0", Offset = "0xC0EBF0", VA = "0x180C0F7F0", Slot = "4")]
		get
		{
			return default(NativeParallelMultiHashMap<Entity, ELGEKKCACLJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	private uint LOKDKCFMDJP
	{
		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0x28CF800", Offset = "0x28CEC00", VA = "0x1828CF800", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	private bool HFGNEBKPFMA
	{
		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0x28CEFE0", Offset = "0x28CE3E0", VA = "0x1828CEFE0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	private NativeArray<CMFFIMLEPBE> HAGHHEGIKDO
	{
		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0x17433E0", Offset = "0x17427E0", VA = "0x1817433E0", Slot = "10")]
		get
		{
			return default(NativeArray<CMFFIMLEPBE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private NativeArray<EFFOMHNHCBO> CHKJFGBOFNM
	{
		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0x17433F0", Offset = "0x17427F0", VA = "0x1817433F0", Slot = "11")]
		get
		{
			return default(NativeArray<EFFOMHNHCBO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private NativeArray<CMFFIMLEPBE> DDANMAFGEFC
	{
		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0x2596190", Offset = "0x2595590", VA = "0x182596190", Slot = "12")]
		get
		{
			return default(NativeArray<CMFFIMLEPBE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007BE")]
	[Cpp2IlInjected.Address(RVA = "0x28CFE10", Offset = "0x28CF210", VA = "0x1828CFE10")]
	public FIACLIIFJJG(KNHBDNEIEIA GHGKMCPGGOC, GCGDNGNDAMG GKOGFPHIKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C1")]
	[Cpp2IlInjected.Address(RVA = "0x28CEFF0", Offset = "0x28CE3F0", VA = "0x1828CEFF0", Slot = "6")]
	private bool CNIEICELHPJ(NativeArray<CMFFIMLEPBE> LMKFIAKIJAP, NativeArray<EFFOMHNHCBO> JONOBDJBMLJ, NativeArray<CMFFIMLEPBE> KNDKMEFEGCC, int OOKKPFFACCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C2")]
	[Cpp2IlInjected.Address(RVA = "0x28CF720", Offset = "0x28CEB20", VA = "0x1828CF720", Slot = "7")]
	private void LGODIIMHNKD(in KAKBNCDEGLG ODHKPLOJGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C3")]
	[Cpp2IlInjected.Address(RVA = "0x28CFC30", Offset = "0x28CF030", VA = "0x1828CFC30", Slot = "8")]
	private void PFINIGOFJIB(JobHandle PPCGBBAKOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C8")]
	[Cpp2IlInjected.Address(RVA = "0x28CF670", Offset = "0x28CEA70", VA = "0x1828CF670", Slot = "13")]
	private bool ELKHKMBNIBH(out NativeArray<int> NFJAHCFFAKM, Allocator GMMIODGPFPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C9")]
	[Cpp2IlInjected.Address(RVA = "0x28CF490", Offset = "0x28CE890", VA = "0x1828CF490", Slot = "14")]
	private bool DOKFKCIHENG(ComponentType IJBDFBDGHPH, out KAKBNCDEGLG PPJPLFACPBB, out GPAHDFKBGLB CNFPICPCCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007CA")]
	[Cpp2IlInjected.Address(RVA = "0x28CF850", Offset = "0x28CEC50", VA = "0x1828CF850", Slot = "15")]
	private NativeMultiHashMapAsync<Entity, ELGEKKCACLJ> MENDJOFECPH()
	{
		return default(NativeMultiHashMapAsync<Entity, ELGEKKCACLJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007CB")]
	[Cpp2IlInjected.Address(RVA = "0x28CF8D0", Offset = "0x28CECD0", VA = "0x1828CF8D0")]
	public void PEHJALIONDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CC")]
	[Cpp2IlInjected.Address(RVA = "0x28CF1F0", Offset = "0x28CE5F0", VA = "0x1828CF1F0")]
	private bool DEOCDMHACBD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
[InternalBufferCapacity(4)]
internal struct DIHOLKIOMAL : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public BHFODDCOKNF PPCGBBAKOHO;
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
internal sealed class CMPLEJGPNAA : HLOJAODEAAM
{
	[Cpp2IlInjected.Token(Token = "0x60007CE")]
	[Cpp2IlInjected.Address(RVA = "0x251D370", Offset = "0x251C770", VA = "0x18251D370", Slot = "15")]
	protected override ComponentSystemBase BHJHPJOJPMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007CF")]
	[Cpp2IlInjected.Address(RVA = "0x2229A50", Offset = "0x2228E50", VA = "0x182229A50")]
	public CMPLEJGPNAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000137")]
internal class NIJODPPMKEM : ECINBHDAKID
{
	[Cpp2IlInjected.Token(Token = "0x60007D0")]
	[Cpp2IlInjected.Address(RVA = "0x2229A50", Offset = "0x2228E50", VA = "0x182229A50")]
	public NIJODPPMKEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal class CIENBMNMFNF
{
	[Cpp2IlInjected.Token(Token = "0x60007D1")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public CIENBMNMFNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
public readonly struct GPPEENBHCHN : IEquatable<GPPEENBHCHN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000424")]
	private readonly GLFLLKHPAHK MLGAFKBKMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000425")]
	private readonly int IBJLEPPHMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000426")]
	private readonly int AJHJAEIINDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000427")]
	private readonly int JHBNKDKKBDN;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public GLFLLKHPAHK MNMNLKIGNGC
	{
		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0xBDECE0", Offset = "0xBDE0E0", VA = "0x180BDECE0")]
		get
		{
			return default(GLFLLKHPAHK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007D3")]
	[Cpp2IlInjected.Address(RVA = "0x28DAED0", Offset = "0x28DA2D0", VA = "0x1828DAED0")]
	public unsafe ReadOnlySpan<byte> PEJJNBKOPBJ(void* PNLDEFLCKHC)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007D4")]
	[Cpp2IlInjected.Address(RVA = "0x28DACE0", Offset = "0x28DA0E0", VA = "0x1828DACE0")]
	public unsafe ReadOnlySpan<byte> BLGBFPAEEBE(void* PNLDEFLCKHC)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007D5")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB180", Offset = "0x1FCA580", VA = "0x181FCB180")]
	public GPPEENBHCHN(GLFLLKHPAHK MLGAFKBKMCE, int JECAINLJFKC, int AJHJAEIINDB, int JHBNKDKKBDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D6")]
	[Cpp2IlInjected.Address(RVA = "0x28DAD50", Offset = "0x28DA150", VA = "0x1828DAD50", Slot = "4")]
	public bool Equals(GPPEENBHCHN LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007D7")]
	[Cpp2IlInjected.Address(RVA = "0x28DADC0", Offset = "0x28DA1C0", VA = "0x1828DADC0", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007D8")]
	[Cpp2IlInjected.Address(RVA = "0x28DAE90", Offset = "0x28DA290", VA = "0x1828DAE90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[ALIINGEKIMD]
	[CompilerGenerated]
	[EBCKCHNKEDI]
	public class PostDeserializeUpgrade_Convert_RRObjectPrefabV1Data : KOEELCMGFDH, IBKHNFKEFMN.GPOJBALCDLB
	{
		[Cpp2IlInjected.Token(Token = "0x200013B")]
		private struct PostDeserializeUpgrade_Convert_RRObjectPrefabV1Data_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000429")]
			public NFONADLCMPK<OOINIJOGBJF> v0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400042A")]
			public NFONADLCMPK<ICGKPPOKBOG> v1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.Token(Token = "0x60007E1")]
			[Cpp2IlInjected.Address(RVA = "0x3DE82D0", Offset = "0x3DE76D0", VA = "0x183DE82D0")]
			private void EJBLFCAPFKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E2")]
			[Cpp2IlInjected.Address(RVA = "0x3DE8630", Offset = "0x3DE7A30", VA = "0x183DE8630", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private static readonly PILIJFIMAJF log;

		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		protected override PILIJFIMAJF Log
		{
			[Cpp2IlInjected.Token(Token = "0x60007D9")]
			[Cpp2IlInjected.Address(RVA = "0x223AE90", Offset = "0x223A290", VA = "0x18223AE90", Slot = "14")]
			get
			{
				return default(PILIJFIMAJF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0x223AA20", Offset = "0x2239E20", VA = "0x18223AA20", Slot = "15")]
		public override IEnumerable<IBKHNFKEFMN.AHKJOPMIMKP> JAONDHGNIEF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007DB")]
		[Cpp2IlInjected.Address(RVA = "0x223AC90", Offset = "0x223A090", VA = "0x18223AC90", Slot = "16")]
		protected override void KKMHPKEJHOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DC")]
		[Cpp2IlInjected.Address(RVA = "0x223AB50", Offset = "0x2239F50", VA = "0x18223AB50")]
		private static void JMDCCCHNEOG(LHFHADLJOHO<ICGKPPOKBOG> d1, EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0x223AEF0", Offset = "0x223A2F0", VA = "0x18223AEF0")]
		private JobHandle PJDIGIKDBDN(NFONADLCMPK<OOINIJOGBJF> v0, NFONADLCMPK<ICGKPPOKBOG> v1, EntityCommandBuffer ecb, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0x2239D50", Offset = "0x2239150", VA = "0x182239D50")]
		public PostDeserializeUpgrade_Convert_RRObjectPrefabV1Data()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
public readonly struct KAKBNCDEGLG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public NativeList<Entity> DLEOKIGAIOF
	{
		[Cpp2IlInjected.Token(Token = "0x60007E3")]
		[Cpp2IlInjected.Address(RVA = "0x12E63E0", Offset = "0x12E57E0", VA = "0x1812E63E0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public NativeList<Entity> JCBHIKHHJLL
	{
		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x9CDA70", Offset = "0x9CCE70", VA = "0x1809CDA70")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public NativeList<byte> ABMJIFHEBNC
	{
		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x9CDA80", Offset = "0x9CCE80", VA = "0x1809CDA80")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public NativeList<byte> PIJPEOIANMI
	{
		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0xC0F7F0", Offset = "0xC0EBF0", VA = "0x180C0F7F0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public NativeList<byte> GLJMKKELGNM
	{
		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x9CDA90", Offset = "0x9CCE90", VA = "0x1809CDA90")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public ComponentType LDKGIKHKCGM
	{
		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0x8C1300", Offset = "0x8C0700", VA = "0x1808C1300")]
		[CompilerGenerated]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public JobHandle FCDPIDPOEPN
	{
		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0x98EEA0", Offset = "0x98E2A0", VA = "0x18098EEA0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public int JJAMODNONOC
	{
		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0x1EDCA60", Offset = "0x1EDBE60", VA = "0x181EDCA60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public int EMKGPCFKNLG
	{
		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0xB61E80", Offset = "0xB61280", VA = "0x180B61E80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public bool HFDMAKGHOFK
	{
		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0x2891440", Offset = "0x2890840", VA = "0x182891440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007ED")]
	[Cpp2IlInjected.Address(RVA = "0x28914C0", Offset = "0x28908C0", VA = "0x1828914C0")]
	public KAKBNCDEGLG(ComponentType IJBDFBDGHPH, JobHandle PPCGBBAKOHO, NativeList<Entity> PGJLMFPAKDA, NativeList<Entity> LDMJFEKGEJN, NativeList<byte> KDALOKOGMBP, NativeList<byte> AJJFCLOHIEK, NativeList<byte> BKCDIFHLEBC, int BCDNJJPDNMB, int IBJLEPPHMPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EE")]
	[Cpp2IlInjected.Address(RVA = "0x2891320", Offset = "0x2890720", VA = "0x182891320", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
public abstract class GKFFCAOGGHG : JKIEMPJPHGI
{
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	protected virtual EFNMGKCCGPP CDJGPMHIKAK
	{
		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0x7F35A0", Offset = "0x7F29A0", VA = "0x1807F35A0", Slot = "14")]
		get
		{
			return default(EFNMGKCCGPP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	protected virtual EFNMGKCCGPP EIOENNCKBJH
	{
		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0x9EA990", Offset = "0x9E9D90", VA = "0x1809EA990", Slot = "15")]
		get
		{
			return default(EFNMGKCCGPP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007F1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract void GFCCJNMOBMN(EFNMGKCCGPP HEGEMCIFGEI);

	[Cpp2IlInjected.Token(Token = "0x60007F2")]
	[Cpp2IlInjected.Address(RVA = "0x28D7A10", Offset = "0x28D6E10", VA = "0x1828D7A10", Slot = "13")]
	protected sealed override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F3")]
	[Cpp2IlInjected.Address(RVA = "0x28D79B0", Offset = "0x28D6DB0", VA = "0x1828D79B0")]
	private EFNMGKCCGPP NDGBPOMPPGO()
	{
		return default(EFNMGKCCGPP);
	}

	[Cpp2IlInjected.Token(Token = "0x60007F4")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	protected GKFFCAOGGHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
[EFDJEPLIMOC(typeof(CEJCPOECKAC), new string[] { })]
[JOCOBGMDOKK(CAGOEBHGGNL.LoadInstance)]
[LOJHKAHIJPC(typeof(EACJNKBBOAA))]
public class CEJCPOECKAC : EACJNKBBOAA, AKFIPDJCCOH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	private struct LOHLCPLEEAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public NPBEDHNLGJD PIBDJHBJKDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public Type JLNNFEOBAMK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000140")]
	private struct FJELDOLKBHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public LOHLCPLEEAO[] NFDNHCCMBMJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[BurstCompile]
	private struct MMLAMMCJFHH : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		[ReadOnly]
		public NativeArray<byte> MLJMGGFHAFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		[ReadOnly]
		public NativeArray<Entity> KJFBCAAOHDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		[ReadOnly]
		public NativeArray<byte> FKEHPCBOHNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		[ReadOnly]
		public NativeArray<byte> HKMHDGGDJHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		[WriteOnly]
		public NativeList<Entity> EMGJKPMJGOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		[WriteOnly]
		public NativeList<byte> IHMAHFNPJIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		[WriteOnly]
		public NativeList<byte> PFPKMMDKMBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public int FBCHFOPMOMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public int DCAHPGBJNOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public int PPMCJCJACEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public int HJKBAIEDLHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public int AAPPHBJEKCC;

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x2715840", Offset = "0x2714C40", VA = "0x182715840", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	private readonly Dictionary<GLFLLKHPAHK, NPBEDHNLGJD> IPENIBNMHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private readonly Dictionary<int, FJELDOLKBHK> EBNCKJOIKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	private JKPBDEIBINB NFDNHCCMBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	private AOONNPAOEFB FHJACJEANIP;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action AENFCEIFEBF
	{
		[Cpp2IlInjected.Token(Token = "0x60007F6")]
		[Cpp2IlInjected.Address(RVA = "0x2516C50", Offset = "0x2516050", VA = "0x182516C50")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60007F7")]
		[Cpp2IlInjected.Address(RVA = "0x2517BD0", Offset = "0x2516FD0", VA = "0x182517BD0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action AONODOPOCIH
	{
		[Cpp2IlInjected.Token(Token = "0x60007F8")]
		[Cpp2IlInjected.Address(RVA = "0x2517B30", Offset = "0x2516F30", VA = "0x182517B30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0x2517F50", Offset = "0x2517350", VA = "0x182517F50")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007FA")]
	[Cpp2IlInjected.Address(RVA = "0x2517C70", Offset = "0x2517070", VA = "0x182517C70", Slot = "6")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FB")]
	[Cpp2IlInjected.Address(RVA = "0x25175F0", Offset = "0x25169F0", VA = "0x1825175F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FC")]
	[Cpp2IlInjected.Address(RVA = "0x25178F0", Offset = "0x2516CF0", VA = "0x1825178F0", Slot = "4")]
	public void FIMKNKKCEGK(NNHEPJDBKBI HNNIGEFAIIM, NPBEDHNLGJD HOOGECPFBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FD")]
	[Cpp2IlInjected.Address(RVA = "0x2517CE0", Offset = "0x25170E0", VA = "0x182517CE0", Slot = "5")]
	public void JOMNAIGJLOO(NNHEPJDBKBI HNNIGEFAIIM, NPBEDHNLGJD HOOGECPFBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FE")]
	[Cpp2IlInjected.Address(RVA = "0x2517A40", Offset = "0x2516E40", VA = "0x182517A40", Slot = "8")]
	public void FIMKNKKCEGK(GLFLLKHPAHK KOAJDKDANHI, NPBEDHNLGJD GBCKPIBLKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FF")]
	[Cpp2IlInjected.Address(RVA = "0x2517E30", Offset = "0x2517230", VA = "0x182517E30", Slot = "9")]
	public void JOMNAIGJLOO(GLFLLKHPAHK KOAJDKDANHI, NPBEDHNLGJD GBCKPIBLKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000800")]
	[Cpp2IlInjected.Address(RVA = "0x25184A0", Offset = "0x25178A0", VA = "0x1825184A0")]
	private void PKLOBKNBNGP(GLFLLKHPAHK KOAJDKDANHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000801")]
	[Cpp2IlInjected.Address(RVA = "0x2517FF0", Offset = "0x25173F0", VA = "0x182517FF0")]
	internal void OPHCNINOFKK(PGBPMCLMNHE PJAFLHHFBPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000802")]
	[Cpp2IlInjected.Address(RVA = "0x2516CF0", Offset = "0x25160F0", VA = "0x182516CF0")]
	private void CEPNJOINGDG(PGBPMCLMNHE PJAFLHHFBPC, int EPAJCDGEEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000803")]
	[Cpp2IlInjected.Address(RVA = "0x2517680", Offset = "0x2516A80", VA = "0x182517680")]
	private void EDILCDFMALE(OMADGHGGHJN CHLMEBOBPLJ, OPHEKAOFDCM JHNBINJNEPJ, LOHLCPLEEAO JLOPMEMGFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000804")]
	[Cpp2IlInjected.Address(RVA = "0x2518320", Offset = "0x2517720", VA = "0x182518320")]
	private FJELDOLKBHK PHJJPHGKNGI(OMADGHGGHJN CHLMEBOBPLJ, OPHEKAOFDCM JHNBINJNEPJ)
	{
		return default(FJELDOLKBHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000805")]
	[Cpp2IlInjected.Address(RVA = "0x2518230", Offset = "0x2517630", VA = "0x182518230")]
	private LOHLCPLEEAO PAMFONPEKBP(FJELDOLKBHK CNFPICPCCAE, OMADGHGGHJN CHLMEBOBPLJ, OPHEKAOFDCM JHNBINJNEPJ)
	{
		return default(LOHLCPLEEAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000806")]
	[Cpp2IlInjected.Address(RVA = "0x2518680", Offset = "0x2517A80", VA = "0x182518680")]
	public CEJCPOECKAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
internal class HHNJKKBFGPP : PCOIJKOLHMH
{
	[Cpp2IlInjected.Token(Token = "0x17000108")]
	protected override GCGDNGNDAMG LBPOJFOKAEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x9EA990", Offset = "0x9E9D90", VA = "0x1809EA990", Slot = "17")]
		get
		{
			return default(GCGDNGNDAMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600080A")]
	[Cpp2IlInjected.Address(RVA = "0x287A940", Offset = "0x2879D40", VA = "0x18287A940")]
	public HHNJKKBFGPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000143")]
public class BIFFFPPHALP : JKIEMPJPHGI
{
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[BurstCompile]
	private struct KACMCMLIMBJ : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		[ReadOnly]
		public ComponentTypeHandle<COEOEGLCBOG> CJBEGBCKEPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		[ReadOnly]
		public BufferTypeHandle<OOENBAEOKLI> ALPIHCDGAML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		[ReadOnly]
		public BufferFromEntity<OOENBAEOKLI> GKBHKHKECDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		[ReadOnly]
		public ComponentDataFromEntity<COEOEGLCBOG> JHAKDOADIKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public ComponentTypeHandle<BOIDEJCAFGI> CCFJAGMBHND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		[NativeDisableContainerSafetyRestriction]
		public ComponentDataFromEntity<BOIDEJCAFGI> GKKFKPGCCIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public uint COFHBFKJOIM;

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x2711F10", Offset = "0x2711310", VA = "0x182711F10", Slot = "4")]
		public void Execute(ArchetypeChunk NCPBFICMLEP, int NANJAGEOPJI, int OACOHOELHFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x2711B00", Offset = "0x2710F00", VA = "0x182711B00")]
		private void DDEEKGPGAED(float4x4 GJBLMAHOKAB, Entity FKNFFDFGNMN, bool ANOFCGIMEAK, int NIACHINLKFI = 1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400044D")]
	private EntityQuery NEBAMFAPADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400044E")]
	private EntityQuery PGDEGJDKLKB;

	[Cpp2IlInjected.Token(Token = "0x600080B")]
	[Cpp2IlInjected.Address(RVA = "0x25139D0", Offset = "0x2512DD0", VA = "0x1825139D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080C")]
	[Cpp2IlInjected.Address(RVA = "0x2513AF0", Offset = "0x2512EF0", VA = "0x182513AF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080D")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public BIFFFPPHALP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
[EBCKCHNKEDI]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
public class EOAJODBKMIP : JKIEMPJPHGI, DEPDOFHIDBA, AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[BurstCompile]
	private struct LENNHANFDEF : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		[ReadOnly]
		public EntityTypeHandle KJFBCAAOHDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		[ReadOnly]
		public ComponentTypeHandle<HNDLOHCHOMJ> NDMJNFGOIKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		[WriteOnly]
		public NativeList<EDOBMHDMGJF>.ParallelWriter DFKONIMCKDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public ComponentTypeHandle<NHFDNMIFLMP> DMBGIOKMLEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public float3 GDNOLIODDHJ;

		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private static readonly float4x2 EPMCNCGFFBJ;

		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private static readonly float4x2 HEOJLLKNHBN;

		[Cpp2IlInjected.Token(Token = "0x4000464")]
		private static readonly int4x2 OFCKIEFBBDB;

		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0x2713800", Offset = "0x2712C00", VA = "0x182713800", Slot = "4")]
		public void Execute(ArchetypeChunk NCPBFICMLEP, int ENBIMODBIAK, int HHILCJGIMIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	private static PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000457")]
	private EntityQuery EPNAFHACPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000458")]
	private EntityQuery DAPIBCPHHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000459")]
	private double EFLMEICNNIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400045A")]
	private KBLGMDKDIMA FBCPJLHEMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400045B")]
	private CAAJLLDIGHE ELICALMKHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400045C")]
	private MLIPPJCKHBF DGLIEJINEGA;

	[Cpp2IlInjected.Token(Token = "0x6000811")]
	[Cpp2IlInjected.Address(RVA = "0x28CA020", Offset = "0x28C9420", VA = "0x1828CA020", Slot = "14")]
	public void MCOOCEGHCPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000812")]
	[Cpp2IlInjected.Address(RVA = "0x28C9F90", Offset = "0x28C9390", VA = "0x1828C9F90", Slot = "15")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000813")]
	[Cpp2IlInjected.Address(RVA = "0x28CA030", Offset = "0x28C9430", VA = "0x1828CA030", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000814")]
	[Cpp2IlInjected.Address(RVA = "0x28CA180", Offset = "0x28C9580", VA = "0x1828CA180", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000815")]
	[Cpp2IlInjected.Address(RVA = "0x28C9F20", Offset = "0x28C9320", VA = "0x1828C9F20")]
	private bool EHLAGIAJEKB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000816")]
	[Cpp2IlInjected.Address(RVA = "0x28C9C30", Offset = "0x28C9030", VA = "0x1828C9C30")]
	private void DPMCIBKGMJK(EntityQuery PNGFJEAJDGO, float3 FELDBIGNINI, string DKPHPKDPBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000817")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public EOAJODBKMIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
[EFDJEPLIMOC(typeof(ANLJAEDMKMC), new string[] { })]
[GCHMNDFEPKK(typeof(OKGCFPBMNKK))]
public class LKLEMFDHFFB : ANLJAEDMKMC, DEPDOFHIDBA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	private readonly Dictionary<int, GKAKPCKINHA> LONLMGGKNPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	private readonly Dictionary<Type, GKAKPCKINHA> GGGMCKDGDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	private readonly Dictionary<Type, GKAKPCKINHA> EMNLENLOBJE;

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public IReadOnlyCollection<GKAKPCKINHA> DGLNIIDFHFI
	{
		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0x2A622F0", Offset = "0x2A616F0", VA = "0x182A622F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600081C")]
	[Cpp2IlInjected.Address(RVA = "0x2A62480", Offset = "0x2A61880", VA = "0x182A62480", Slot = "7")]
	public void MCOOCEGHCPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600081D")]
	[Cpp2IlInjected.Address(RVA = "0x2A62400", Offset = "0x2A61800", VA = "0x182A62400", Slot = "6")]
	public GKAKPCKINHA FGBNPDAOODO(Type JLNNFEOBAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081E")]
	[Cpp2IlInjected.Address(RVA = "0x2A62390", Offset = "0x2A61790", VA = "0x182A62390", Slot = "5")]
	public bool EIOKANDHIEG(int EPAJCDGEEKI, out GKAKPCKINHA NFDNHCCMBMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600081F")]
	[Cpp2IlInjected.Address(RVA = "0x2A62340", Offset = "0x2A61740", VA = "0x182A62340", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000820")]
	[Cpp2IlInjected.Address(RVA = "0x2A62720", Offset = "0x2A61B20", VA = "0x182A62720")]
	public LKLEMFDHFFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
internal class GLNAMPMBHBC : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	private EntityQuery PNGFJEAJDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000469")]
	private HAGBJEJOLJL FBCPJLHEMAI;

	[Cpp2IlInjected.Token(Token = "0x6000821")]
	[Cpp2IlInjected.Address(RVA = "0x28D8370", Offset = "0x28D7770", VA = "0x1828D8370", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000822")]
	[Cpp2IlInjected.Address(RVA = "0x28D83C0", Offset = "0x28D77C0", VA = "0x1828D83C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000823")]
	[Cpp2IlInjected.Address(RVA = "0x28D8470", Offset = "0x28D7870", VA = "0x1828D8470", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000824")]
	[Cpp2IlInjected.Address(RVA = "0x28D7E40", Offset = "0x28D7240", VA = "0x1828D7E40")]
	private void BGHGFOJGAKD(NativeArray<Entity> PGJLMFPAKDA, NativeList<Entity> BKMJDGJHNLD, ComponentDataFromEntity<CKHCBEKGHBH> BGCPPBCABFK, BufferFromEntity<OOENBAEOKLI> IHNECOPJOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000825")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public GLNAMPMBHBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
public class GNNCNBIEFOI : JKIEMPJPHGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	private EntityQuery PNGFJEAJDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	private MAHFNHANKIE DCLHOGPFELA;

	[Cpp2IlInjected.Token(Token = "0x6000826")]
	[Cpp2IlInjected.Address(RVA = "0x28DAA10", Offset = "0x28D9E10", VA = "0x1828DAA10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000827")]
	[Cpp2IlInjected.Address(RVA = "0x28DAAE0", Offset = "0x28D9EE0", VA = "0x1828DAAE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000828")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public GNNCNBIEFOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
public static class PAEFMPJKFNF
{
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly GBICPCJAFPO OPCNKLIEFBL;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly GBICPCJAFPO HDKOOEMCCHA;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly GBICPCJAFPO MIBJNFKFKBP;
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
public class EBACHIKBHEJ : JKIEMPJPHGI
{
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[BurstCompile]
	private struct MKELDHENMAO : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		[ReadOnly]
		public ComponentTypeHandle<KPMOMMGMLCH> MKHHNANEKDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		[ReadOnly]
		public ComponentTypeHandle<OGGOJLEGOPG> NBBKIMJIAHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		[ReadOnly]
		public ComponentTypeHandle<ANCGJKBPAIA> NLLHJPBPIFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public ComponentTypeHandle<COEOEGLCBOG> CBAJENHKLHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public uint COFHBFKJOIM;

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0x2715100", Offset = "0x2714500", VA = "0x182715100", Slot = "4")]
		public void Execute(ArchetypeChunk NCPBFICMLEP, int NANJAGEOPJI, int OACOHOELHFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x2715000", Offset = "0x2714400", VA = "0x182715000")]
		public bool BEBJJPJJHPD(ArchetypeChunk NCPBFICMLEP)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400046F")]
	private EntityQuery KMPMKIKDFIP;

	[Cpp2IlInjected.Token(Token = "0x600082A")]
	[Cpp2IlInjected.Address(RVA = "0x28C38F0", Offset = "0x28C2CF0", VA = "0x1828C38F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082B")]
	[Cpp2IlInjected.Address(RVA = "0x28C3A20", Offset = "0x28C2E20", VA = "0x1828C3A20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082C")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public EBACHIKBHEJ()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	internal class PostDeserializeSortSplinePoints : JKIEMPJPHGI
	{
		[Cpp2IlInjected.Token(Token = "0x200014E")]
		private struct OrderComparer : IComparer<Entity>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000477")]
			[ReadOnly]
			public ComponentDataFromEntity<EOGEBMPBCME> orderRO;

			[Cpp2IlInjected.Token(Token = "0x6000833")]
			[Cpp2IlInjected.Address(RVA = "0x3DE6B20", Offset = "0x3DE5F20", VA = "0x183DE6B20", Slot = "4")]
			public int Compare(Entity x, Entity y)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200014F")]
		[NoAlias]
		[BurstCompile]
		private struct PostDeserializeSortSplinePoints_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000478")]
			public OrderComparer comparer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000479")]
			[ReadOnly]
			public EntityTypeHandle __splineTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400047A")]
			public BufferTypeHandle<LinkedEntityGroup> __bufferTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000834")]
			[Cpp2IlInjected.Address(RVA = "0x3DE7350", Offset = "0x3DE6750", VA = "0x183DE7350")]
			private void EJBLFCAPFKM(Entity spline, DynamicBuffer<LinkedEntityGroup> buffer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000835")]
			[Cpp2IlInjected.Address(RVA = "0x3DE73E0", Offset = "0x3DE67E0", VA = "0x183DE73E0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		private EntityQuery PostDeserializeSortSplinePoints_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private EntityQuery __query_1;

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x2237EA0", Offset = "0x22372A0", VA = "0x182237EA0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0x2237A30", Offset = "0x2236E30", VA = "0x182237A30")]
		private void LGOPFEMIPEK(OrderComparer comparer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0x2237B60", Offset = "0x2236F60", VA = "0x182237B60", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
		public PostDeserializeSortSplinePoints()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
public static class IBKHNFKEFMN
{
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	public interface GPOJBALCDLB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000152")]
	public interface AHKJOPMIMKP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000153")]
	public class MLIBGDHFCAM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000154")]
	public class LEGLBOHMAAP : AHKJOPMIMKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0x27133E0", Offset = "0x27127E0", VA = "0x1827133E0")]
		public LEGLBOHMAAP(ComponentType CANIEFMHGCA, ComponentType HFILJMEEAPA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000155")]
	public class EAMCEBJBGGB : AHKJOPMIMKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0x270C140", Offset = "0x270B540", VA = "0x18270C140")]
		public EAMCEBJBGGB(ComponentType CANIEFMHGCA, ComponentType[] HFILJMEEAPA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000156")]
	public class EDEMFMDDMMD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000836")]
	[Cpp2IlInjected.Address(RVA = "0x1816040", Offset = "0x1815440", VA = "0x181816040")]
	public static AHKJOPMIMKP HOGEDLONAAA<TFrom, TTo>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000837")]
	[Cpp2IlInjected.Address(RVA = "0x18164C0", Offset = "0x18158C0", VA = "0x1818164C0")]
	public static AHKJOPMIMKP NPNHGHLEEEB<TFrom>(params ComponentType[] DKMLMFNFONI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000157")]
[EFDJEPLIMOC(typeof(EONNPNOIBPC), new string[] { })]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
internal sealed class EONNPNOIBPC : AKFIPDJCCOH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000480")]
	[ONGFANECMJO]
	private PFJMBDHJHAN GKACEDOEIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000481")]
	private DNMGNPMNFDI FCGEAJNLBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000482")]
	private FDNIKINPGPI COBKFBMBCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	private bool MMLDFGNKLLJ;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	private EntityManager FCLKPLIBOOP
	{
		[Cpp2IlInjected.Token(Token = "0x600083E")]
		[Cpp2IlInjected.Address(RVA = "0x28CC520", Offset = "0x28CB920", VA = "0x1828CC520")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<PPACDBGDBCI, NativeArray<LENINMGJJHF>> HFAEMBOIGMI
	{
		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0x28CC3E0", Offset = "0x28CB7E0", VA = "0x1828CC3E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600083B")]
		[Cpp2IlInjected.Address(RVA = "0x28CB180", Offset = "0x28CA580", VA = "0x1828CB180")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<PPACDBGDBCI> NNKPECFFFIK
	{
		[Cpp2IlInjected.Token(Token = "0x600083C")]
		[Cpp2IlInjected.Address(RVA = "0x28CB540", Offset = "0x28CA940", VA = "0x1828CB540")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600083D")]
		[Cpp2IlInjected.Address(RVA = "0x28CC480", Offset = "0x28CB880", VA = "0x1828CC480")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600083F")]
	[Cpp2IlInjected.Address(RVA = "0x28CBAB0", Offset = "0x28CAEB0", VA = "0x1828CBAB0", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000840")]
	[Cpp2IlInjected.Address(RVA = "0x114B2D0", Offset = "0x114A6D0", VA = "0x18114B2D0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000841")]
	[Cpp2IlInjected.Address(RVA = "0x28CB970", Offset = "0x28CAD70", VA = "0x1828CB970")]
	public bool HABKCECLKEN(Entity FKNFFDFGNMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000842")]
	[Cpp2IlInjected.Address(RVA = "0x28CB4A0", Offset = "0x28CA8A0", VA = "0x1828CB4A0")]
	public void EHKGCEAOOAN(Entity FKNFFDFGNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000843")]
	[Cpp2IlInjected.Address(RVA = "0x28CB9F0", Offset = "0x28CADF0", VA = "0x1828CB9F0")]
	public void INAMBFLEJDM(Entity FKNFFDFGNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000844")]
	[Cpp2IlInjected.Address(RVA = "0x28CB7E0", Offset = "0x28CABE0", VA = "0x1828CB7E0")]
	private bool FPIBHEOJAAB(Entity FKNFFDFGNMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000845")]
	[Cpp2IlInjected.Address(RVA = "0x28CB660", Offset = "0x28CAA60", VA = "0x1828CB660")]
	public void FBDDBFFKADI(Entity FKNFFDFGNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000846")]
	[Cpp2IlInjected.Address(RVA = "0x28CBE00", Offset = "0x28CB200", VA = "0x1828CBE00")]
	private bool JMHNMKFIKJH(Entity FKNFFDFGNMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000847")]
	[Cpp2IlInjected.Address(RVA = "0x28CB6D0", Offset = "0x28CAAD0", VA = "0x1828CB6D0")]
	public void FMEHBMDFEDJ(Entity FKNFFDFGNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000848")]
	[Cpp2IlInjected.Address(RVA = "0x28CB440", Offset = "0x28CA840", VA = "0x1828CB440")]
	private void EBADNANMDIH(Entity FKNFFDFGNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000849")]
	[Cpp2IlInjected.Address(RVA = "0x28CB220", Offset = "0x28CA620", VA = "0x1828CB220")]
	private void BHNLLKLGDJL(Entity FKNFFDFGNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084A")]
	[Cpp2IlInjected.Address(RVA = "0x28CB4E0", Offset = "0x28CA8E0", VA = "0x1828CB4E0")]
	private void EHNNMIIHLJJ(Entity FKNFFDFGNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084B")]
	[Cpp2IlInjected.Address(RVA = "0x28CBB60", Offset = "0x28CAF60", VA = "0x1828CBB60")]
	private void JCBHLOFAPIA(Entity FKNFFDFGNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084C")]
	[Cpp2IlInjected.Address(RVA = "0x28CB5E0", Offset = "0x28CA9E0", VA = "0x1828CB5E0")]
	public void EJMLHOAHINJ(PPACDBGDBCI AHGPNHPBGNL, NativeArray<LENINMGJJHF> PMMGJMLABKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084D")]
	[Cpp2IlInjected.Address(RVA = "0x28CBA40", Offset = "0x28CAE40", VA = "0x1828CBA40")]
	public void IPGBFGKMMNF(PPACDBGDBCI AHGPNHPBGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084E")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	private void GIFOBGAOCCE(Entity FKNFFDFGNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084F")]
	[Cpp2IlInjected.Address(RVA = "0x28CC0A0", Offset = "0x28CB4A0", VA = "0x1828CC0A0")]
	private void LPEKMLIGLME(Entity FKNFFDFGNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000850")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public EONNPNOIBPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000158")]
public class KDHGDKMHHJP : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000486")]
	private EntityQuery CKJIFFCAACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000487")]
	private EntityQuery BIDOILOFMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000488")]
	private EntityQuery BALLLJPPJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000489")]
	private EntityQuery BKOKFAFDEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400048A")]
	private DNMGNPMNFDI OGNMOHLFCPM;

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public int CHBECPLKOPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0x28916C0", Offset = "0x2890AC0", VA = "0x1828916C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000853")]
	[Cpp2IlInjected.Address(RVA = "0x2891910", Offset = "0x2890D10", VA = "0x182891910", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000854")]
	[Cpp2IlInjected.Address(RVA = "0x2891B70", Offset = "0x2890F70", VA = "0x182891B70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0x2891D70", Offset = "0x2891170", VA = "0x182891D70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000856")]
	[Cpp2IlInjected.Address(RVA = "0x2891640", Offset = "0x2890A40", VA = "0x182891640")]
	public int CJDFFFLCCIG(SceneTag EOOPPEEEACO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000857")]
	[Cpp2IlInjected.Address(RVA = "0x2891970", Offset = "0x2890D70", VA = "0x182891970")]
	protected void MFBBAOFKCEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000858")]
	[Cpp2IlInjected.Address(RVA = "0x28917F0", Offset = "0x2890BF0", VA = "0x1828917F0")]
	protected void HPIOEADPIEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000859")]
	[Cpp2IlInjected.Address(RVA = "0x28916D0", Offset = "0x2890AD0", VA = "0x1828916D0")]
	public NativeArrayAsync<Entity> EECMPDHKLGD(SceneTag EOOPPEEEACO, Allocator GMMIODGPFPJ = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600085A")]
	[Cpp2IlInjected.Address(RVA = "0x2891B20", Offset = "0x2890F20", VA = "0x182891B20")]
	public NativeArrayAsync<Entity> NHGOKJLMMHC(SceneTag EOOPPEEEACO, Allocator GMMIODGPFPJ = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600085B")]
	[Cpp2IlInjected.Address(RVA = "0x2891720", Offset = "0x2890B20", VA = "0x182891720")]
	public bool EJIFDNCBCCF(SceneTag EOOPPEEEACO, out NativeArrayAsync<Entity> FCGEAJNLBED, Allocator GMMIODGPFPJ = Allocator.TempJob)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600085C")]
	[Cpp2IlInjected.Address(RVA = "0x28915E0", Offset = "0x28909E0", VA = "0x1828915E0")]
	public bool CGEGNOGJDCD(Entity FKNFFDFGNMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600085D")]
	[Cpp2IlInjected.Address(RVA = "0x2891570", Offset = "0x2890970", VA = "0x182891570")]
	public bool BDGDJOEOFJD(Entity FKNFFDFGNMN, out AEHOCFDGEHI FCGEAJNLBED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600085E")]
	[Cpp2IlInjected.Address(RVA = "0x28917B0", Offset = "0x2890BB0", VA = "0x1828917B0")]
	public void GHDACDPKBCM(Entity FKNFFDFGNMN, AEHOCFDGEHI FCGEAJNLBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085F")]
	[Cpp2IlInjected.Address(RVA = "0x2891660", Offset = "0x2890A60", VA = "0x182891660")]
	public bool CPDJCFLACPL(Entity FKNFFDFGNMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000860")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public KDHGDKMHHJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
[EFDJEPLIMOC(typeof(NICJNOMPEDE), new string[] { })]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
internal sealed class NICJNOMPEDE
{
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	public enum COOGLHKJAOK
	{
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		Gameplay,
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		ObjectModel
	}

	[Cpp2IlInjected.Token(Token = "0x200015B")]
	public struct CKKLCGODPFK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private COOGLHKJAOK LGNENIGMIIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		private readonly NICJNOMPEDE ILDFJHMNOPJ;

		[Cpp2IlInjected.Token(Token = "0x6000868")]
		[Cpp2IlInjected.Address(RVA = "0x3DE5B80", Offset = "0x3DE4F80", VA = "0x183DE5B80")]
		public CKKLCGODPFK(NICJNOMPEDE ILDFJHMNOPJ, COOGLHKJAOK GKOGFPHIKMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000869")]
		[Cpp2IlInjected.Address(RVA = "0x3DE5B50", Offset = "0x3DE4F50", VA = "0x183DE5B50", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public COOGLHKJAOK GKOGFPHIKMK;

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public COOGLHKJAOK DCEDMEDCLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x7E8250", Offset = "0x7E7650", VA = "0x1807E8250")]
		get
		{
			return default(COOGLHKJAOK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x902B60", Offset = "0x901F60", VA = "0x180902B60")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public bool KELOJCJGMDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0x1F7FDF0", Offset = "0x1F7F1F0", VA = "0x181F7FDF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000864")]
	[Cpp2IlInjected.Address(RVA = "0x2A6EB80", Offset = "0x2A6DF80", VA = "0x182A6EB80")]
	public CKKLCGODPFK NAMFLGKABJJ()
	{
		return default(CKKLCGODPFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000865")]
	[Cpp2IlInjected.Address(RVA = "0x2A6EB50", Offset = "0x2A6DF50", VA = "0x182A6EB50")]
	public CKKLCGODPFK HAJEOEDOJED()
	{
		return default(CKKLCGODPFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000866")]
	[Cpp2IlInjected.Address(RVA = "0xFC7A90", Offset = "0xFC6E90", VA = "0x180FC7A90")]
	public NICJNOMPEDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal readonly struct NNPCJELMPNE
{
	[Cpp2IlInjected.Token(Token = "0x4000492")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	private static readonly ProfilerMarker EFGOHNJJAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	private readonly JKIEMPJPHGI JJBAHIPIPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	private readonly World GLMOAKNBFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	private readonly EntityQuery GHELIPJNJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	private readonly EntityQuery KJFHNOIAGDE;

	[Cpp2IlInjected.Token(Token = "0x600086A")]
	[Cpp2IlInjected.Address(RVA = "0x2A737E0", Offset = "0x2A72BE0", VA = "0x182A737E0")]
	public NNPCJELMPNE(JKIEMPJPHGI JJBAHIPIPHK, World GLMOAKNBFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086B")]
	[Cpp2IlInjected.Address(RVA = "0x2A73190", Offset = "0x2A72590", VA = "0x182A73190")]
	public NativeArray<CMFFIMLEPBE> COCGDBGCNKP()
	{
		return default(NativeArray<CMFFIMLEPBE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600086C")]
	[Cpp2IlInjected.Address(RVA = "0x2A736B0", Offset = "0x2A72AB0", VA = "0x182A736B0")]
	public void LFFFHBPKNAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086D")]
	[Cpp2IlInjected.Address(RVA = "0x2A732A0", Offset = "0x2A726A0", VA = "0x182A732A0")]
	private NativeArray<CMFFIMLEPBE> GFPNCFCIMGJ(EntityQuery PNGFJEAJDGO)
	{
		return default(NativeArray<CMFFIMLEPBE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200015D")]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
internal sealed class PHOOCBPIMFM : HLOJAODEAAM
{
	[Cpp2IlInjected.Token(Token = "0x600086F")]
	[Cpp2IlInjected.Address(RVA = "0x222FC50", Offset = "0x222F050", VA = "0x18222FC50", Slot = "15")]
	protected override ComponentSystemBase BHJHPJOJPMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000870")]
	[Cpp2IlInjected.Address(RVA = "0x2229A50", Offset = "0x2228E50", VA = "0x182229A50")]
	public PHOOCBPIMFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal class EFOGNHCBNBF : ECINBHDAKID
{
	[Cpp2IlInjected.Token(Token = "0x6000871")]
	[Cpp2IlInjected.Address(RVA = "0x2229A50", Offset = "0x2228E50", VA = "0x182229A50")]
	public EFOGNHCBNBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015F")]
internal class CBAEHEOBOBL : ECINBHDAKID
{
	[Cpp2IlInjected.Token(Token = "0x6000872")]
	[Cpp2IlInjected.Address(RVA = "0x2229A50", Offset = "0x2228E50", VA = "0x182229A50")]
	public CBAEHEOBOBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000160")]
internal struct EONGFACGDFM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public int BJNMAHEDMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public int EGCDHDOFEEK;
}
[Cpp2IlInjected.Token(Token = "0x2000161")]
public class CLNFCIDMHGC : ParentSystemBase<GBNALMICONM, FNBFFOBOBID, NCPFCBDGLKK>
{
	[Cpp2IlInjected.Token(Token = "0x6000873")]
	[Cpp2IlInjected.Address(RVA = "0x251CB60", Offset = "0x251BF60", VA = "0x18251CB60", Slot = "14")]
	protected override EntityQueryDesc MNBFCFJEKII(EntityQueryDesc PNGFJEAJDGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000874")]
	[Cpp2IlInjected.Address(RVA = "0x93C3C0", Offset = "0x93B7C0", VA = "0x18093C3C0", Slot = "15")]
	protected override EntityQueryDesc GGJAABHGMHI(EntityQueryDesc PNGFJEAJDGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000875")]
	[Cpp2IlInjected.Address(RVA = "0x251CBA0", Offset = "0x251BFA0", VA = "0x18251CBA0", Slot = "16")]
	protected override EntityQueryDesc OEIDGIHNLKF(EntityQueryDesc PNGFJEAJDGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000876")]
	[Cpp2IlInjected.Address(RVA = "0x251CB20", Offset = "0x251BF20", VA = "0x18251CB20", Slot = "17")]
	protected override EntityQueryDesc HDGEMLFEPJG(EntityQueryDesc PNGFJEAJDGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000877")]
	[Cpp2IlInjected.Address(RVA = "0x251CBE0", Offset = "0x251BFE0", VA = "0x18251CBE0")]
	public CLNFCIDMHGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
internal class AADHBFILIOG : OPIOBIJBFDM
{
	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	protected override GBICPCJAFPO OLPAAHHJIKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0x250C800", Offset = "0x250BC00", VA = "0x18250C800", Slot = "15")]
		get
		{
			return default(GBICPCJAFPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000879")]
	[Cpp2IlInjected.Address(RVA = "0x250C880", Offset = "0x250BC80", VA = "0x18250C880")]
	public AADHBFILIOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
public sealed class JGHDJOAEDGE : HLOJAODEAAM
{
	[Cpp2IlInjected.Token(Token = "0x600087A")]
	[Cpp2IlInjected.Address(RVA = "0x288A790", Offset = "0x2889B90", VA = "0x18288A790", Slot = "15")]
	protected override ComponentSystemBase BHJHPJOJPMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600087B")]
	[Cpp2IlInjected.Address(RVA = "0x2229A50", Offset = "0x2228E50", VA = "0x182229A50")]
	public JGHDJOAEDGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
[ExecuteAlways]
public class MEFPLGKABMN : KMPGAAGIPLF
{
	[Cpp2IlInjected.Token(Token = "0x600087C")]
	[Cpp2IlInjected.Address(RVA = "0xD17B50", Offset = "0xD16F50", VA = "0x180D17B50")]
	public MEFPLGKABMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
public class AMKOFOAMCJF : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x400049A")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400049B")]
	private EntityQuery IBAHPPNJBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	private EntityQuery DFDHBGDFKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	private EntityQuery LBJDMEMHDLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	private EntityQuery MLDLCCAJBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	private MILFLABAMPI FBCPJLHEMAI;

	[Cpp2IlInjected.Token(Token = "0x600087D")]
	[Cpp2IlInjected.Address(RVA = "0x250FE80", Offset = "0x250F280", VA = "0x18250FE80", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600087E")]
	[Cpp2IlInjected.Address(RVA = "0x250FED0", Offset = "0x250F2D0", VA = "0x18250FED0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600087F")]
	[Cpp2IlInjected.Address(RVA = "0x2510100", Offset = "0x250F500", VA = "0x182510100", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000880")]
	[Cpp2IlInjected.Address(RVA = "0x250FB00", Offset = "0x250EF00", VA = "0x18250FB00")]
	private void EBOHBLNDMAL(EntityQuery PNGFJEAJDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000881")]
	[Cpp2IlInjected.Address(RVA = "0x2510230", Offset = "0x250F630", VA = "0x182510230")]
	private void PBDAKCGNFND(EntityQuery PNGFJEAJDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000882")]
	[Cpp2IlInjected.Address(RVA = "0x2510090", Offset = "0x250F490", VA = "0x182510090", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000883")]
	[Cpp2IlInjected.Address(RVA = "0x250FB70", Offset = "0x250EF70", VA = "0x18250FB70")]
	private void HHLFEFACCMM(EntityQuery PNGFJEAJDGO, bool IDLFGFDILBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000884")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public AMKOFOAMCJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
public sealed class LECCNIKFDPO : HLOJAODEAAM
{
	[Cpp2IlInjected.Token(Token = "0x6000886")]
	[Cpp2IlInjected.Address(RVA = "0x2899AC0", Offset = "0x2898EC0", VA = "0x182899AC0", Slot = "15")]
	protected override ComponentSystemBase BHJHPJOJPMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000887")]
	[Cpp2IlInjected.Address(RVA = "0x2229A50", Offset = "0x2228E50", VA = "0x182229A50")]
	public LECCNIKFDPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
[JOCOBGMDOKK(CAGOEBHGGNL.LoadInstance)]
[EFDJEPLIMOC(typeof(DGLFHLMKCCN), new string[] { })]
internal sealed class DGLFHLMKCCN : AKFIPDJCCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	private PFJMBDHJHAN BDLCNPMEDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	private NICJNOMPEDE IHNOHNBJLLP;

	[Cpp2IlInjected.Token(Token = "0x6000888")]
	[Cpp2IlInjected.Address(RVA = "0x2522A40", Offset = "0x2521E40", VA = "0x182522A40", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000889")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public DGLFHLMKCCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal class IJHAMPIKCMH : CBHLJLLPMCM
{
	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	protected override GBICPCJAFPO OLPAAHHJIKN
	{
		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x2885C00", Offset = "0x2885000", VA = "0x182885C00", Slot = "15")]
		get
		{
			return default(GBICPCJAFPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600088B")]
	[Cpp2IlInjected.Address(RVA = "0x2885C80", Offset = "0x2885080", VA = "0x182885C80")]
	public IJHAMPIKCMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
[EFDJEPLIMOC(typeof(BGNPLHOEAII), new string[] { })]
internal class DCENBJBHFGO : BGNPLHOEAII, AKFIPDJCCOH, CBKELFDIEEL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private sealed class LANJACBMCDD : IEnumerable<KDLENLDMBAK>, IEnumerable, IEnumerator<KDLENLDMBAK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private KDLENLDMBAK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private KDLENLDMBAK localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public KDLENLDMBAK <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public DCENBJBHFGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private EntityManager <entityManager>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private LocalId <entity>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private DynamicBuffer<NCPFCBDGLKK> <children>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private NativeArray<Entity> <childEntities>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private NativeArray<Entity> <childEntitiesCopy>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private NativeArray<Entity>.Enumerator <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private Entity <child>5__7;

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		private KDLENLDMBAK System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60008B1")]
			[Cpp2IlInjected.Address(RVA = "0x2711380", Offset = "0x2710780", VA = "0x182711380", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KDLENLDMBAK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60008B3")]
			[Cpp2IlInjected.Address(RVA = "0x27132C0", Offset = "0x27126C0", VA = "0x1827132C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0xB48080", Offset = "0xB47480", VA = "0x180B48080")]
		[DebuggerHidden]
		public LANJACBMCDD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x2713310", Offset = "0x2712710", VA = "0x182713310", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0x2712E90", Offset = "0x2712290", VA = "0x182712E90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0x2712E40", Offset = "0x2712240", VA = "0x182712E40")]
		private void MIMEIPDHABP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x2712DF0", Offset = "0x27121F0", VA = "0x182712DF0")]
		private void HHNPGKLOEAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0x2713280", Offset = "0x2712680", VA = "0x182713280", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x27131D0", Offset = "0x27125D0", VA = "0x1827131D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KDLENLDMBAK> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0x27131D0", Offset = "0x27125D0", VA = "0x1827131D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	private static readonly PILIJFIMAJF GGHAGNAPFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	private AOONNPAOEFB FHJACJEANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	private PFJMBDHJHAN BDLCNPMEDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	private EBCPMJGAKEI FBCPJLHEMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	private CEJCPOECKAC CJDOLIICMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	private MDGCCNJAIOM<Entity> JMFCAJHLMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	private MDGCCNJAIOM<float3> GFGPPFLBMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	private MDGCCNJAIOM<quaternion> NEFGFPOCKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	private MDGCCNJAIOM<float> KJKMGPDDBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	private HashSet<Entity> PDMMMCHFPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	private HashSet<Entity> PEOGNMKAECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	private EntityQuery NEILNAJDGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	private bool MMLDFGNKLLJ;

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public Func<ICOBLLMLJBN> HIHOLIJFJGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0xA49860", Offset = "0xA48C60", VA = "0x180A49860", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0x9EA9B0", Offset = "0x9E9DB0", VA = "0x1809EA9B0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<KDLENLDMBAK, KDLENLDMBAK> BDMGLKFFOCP
	{
		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0x2521D70", Offset = "0x2521170", VA = "0x182521D70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x2522280", Offset = "0x2521680", VA = "0x182522280", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<KDLENLDMBAK, KDLENLDMBAK> FBDGMEGFMJF
	{
		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0x2521E10", Offset = "0x2521210", VA = "0x182521E10", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x2521EB0", Offset = "0x25212B0", VA = "0x182521EB0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<KDLENLDMBAK, KDLENLDMBAK, KDLENLDMBAK> JNOJPOMHJKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0x2520A00", Offset = "0x251FE00", VA = "0x182520A00", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0x25221E0", Offset = "0x25215E0", VA = "0x1825221E0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<KDLENLDMBAK> JENDLBAAIPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x2520960", Offset = "0x251FD60", VA = "0x182520960", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0x2522440", Offset = "0x2521840", VA = "0x182522440", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000896")]
	[Cpp2IlInjected.Address(RVA = "0x2521500", Offset = "0x2520900", VA = "0x182521500", Slot = "26")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000897")]
	[Cpp2IlInjected.Address(RVA = "0x2521660", Offset = "0x2520A60", VA = "0x182521660", Slot = "27")]
	public void JFCLKDMBJND(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000898")]
	[Cpp2IlInjected.Address(RVA = "0x2520590", Offset = "0x251F990", VA = "0x182520590", Slot = "28")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000899")]
	[Cpp2IlInjected.Address(RVA = "0x2520F70", Offset = "0x2520370", VA = "0x182520F70")]
	private void ICEAKDOBLDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089A")]
	[Cpp2IlInjected.Address(RVA = "0x2521F50", Offset = "0x2521350", VA = "0x182521F50")]
	private void MLABPBFBLKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089B")]
	[Cpp2IlInjected.Address(RVA = "0x25201C0", Offset = "0x251F5C0", VA = "0x1825201C0")]
	private void ACKLFLDKMAO(NPCCBNHIEEP KJFNAECAHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089C")]
	[Cpp2IlInjected.Address(RVA = "0x2522320", Offset = "0x2521720", VA = "0x182522320")]
	private void OLKBCDAHGLB(NPCCBNHIEEP KJFNAECAHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089D")]
	[Cpp2IlInjected.Address(RVA = "0x16760E0", Offset = "0x16754E0", VA = "0x1816760E0", Slot = "14")]
	public Color MKOIEIIEJMF(KDLENLDMBAK LCODCOPGHJA, int GCEEJDKIGOF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600089E")]
	[Cpp2IlInjected.Address(RVA = "0x2521B40", Offset = "0x2520F40", VA = "0x182521B40", Slot = "15")]
	public float3 JINKKIFJBDB(KDLENLDMBAK LCODCOPGHJA, int GCEEJDKIGOF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600089F")]
	[Cpp2IlInjected.Address(RVA = "0x2521420", Offset = "0x2520820", VA = "0x182521420", Slot = "16")]
	public bool IPOLINNBOEF(KDLENLDMBAK LCODCOPGHJA, KDLENLDMBAK FABBINCJJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008A0")]
	[Cpp2IlInjected.Address(RVA = "0x25220E0", Offset = "0x25214E0", VA = "0x1825220E0", Slot = "17")]
	public KDLENLDMBAK MNMAJHDMHMK(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(KDLENLDMBAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60008A1")]
	[Cpp2IlInjected.Address(RVA = "0x2521280", Offset = "0x2520680", VA = "0x182521280", Slot = "20")]
	public void IJOMAPONLCD(KDLENLDMBAK LCODCOPGHJA, Vector3 JMIHADOHNEA, Quaternion LJEJBFIKBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A2")]
	[Cpp2IlInjected.Address(RVA = "0x2520EB0", Offset = "0x25202B0", VA = "0x182520EB0", Slot = "21")]
	public void HMEOHJEJBJN(KDLENLDMBAK LCODCOPGHJA, float JOHKAAPFFLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A3")]
	[Cpp2IlInjected.Address(RVA = "0x25211B0", Offset = "0x25205B0", VA = "0x1825211B0", Slot = "24")]
	public float3 IEFDEONLEEO(DNCIFCFDCBN EEBCOGPBBCB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60008A4")]
	[Cpp2IlInjected.Address(RVA = "0x25204D0", Offset = "0x251F8D0", VA = "0x1825204D0", Slot = "25")]
	public quaternion CILHEKNNIOB(DNCIFCFDCBN EEBCOGPBBCB)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60008A5")]
	[Cpp2IlInjected.Address(RVA = "0x2520FD0", Offset = "0x25203D0", VA = "0x182520FD0", Slot = "22")]
	public bool IDJNFENJBAD(KDLENLDMBAK LCODCOPGHJA, out RigidTransform LCNILANGJMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008A6")]
	[Cpp2IlInjected.Address(RVA = "0x2520D30", Offset = "0x2520130", VA = "0x182520D30", Slot = "23")]
	public bool FOPLPKIAPCH(KDLENLDMBAK LCODCOPGHJA, out float JOHKAAPFFLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008A7")]
	[Cpp2IlInjected.Address(RVA = "0x25208D0", Offset = "0x251FCD0", VA = "0x1825208D0", Slot = "18")]
	[IteratorStateMachine(typeof(LANJACBMCDD))]
	public IEnumerable<KDLENLDMBAK> EFILPCJOIIA(KDLENLDMBAK LCODCOPGHJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008A8")]
	[Cpp2IlInjected.Address(RVA = "0x2520AA0", Offset = "0x251FEA0", VA = "0x182520AA0", Slot = "19")]
	public KDLENLDMBAK FDNIGEOEFFN(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(KDLENLDMBAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60008A9")]
	[Cpp2IlInjected.Address(RVA = "0x2520C20", Offset = "0x2520020", VA = "0x182520C20")]
	private Entity FDNIGEOEFFN(Entity FKNFFDFGNMN)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008AA")]
	[Cpp2IlInjected.Address(RVA = "0x25225B0", Offset = "0x25219B0", VA = "0x1825225B0")]
	public DCENBJBHFGO()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	public class PreSerializeDowngrade_RRObjectPrefabTypeData : JKIEMPJPHGI
	{
		[Cpp2IlInjected.Token(Token = "0x200016C")]
		[BurstCompile]
		[NoAlias]
		private struct PreSerializeDowngrade_RRObjectPrefabTypeData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C5")]
			[ReadOnly]
			public SharedComponentTypeHandle<RRObjectPrefabV2Data> prefabTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004C6")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004C7")]
			[ReadOnly]
			public NativeArray<ArchetypeChunk> chunksRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004C8")]
			[ReadOnly]
			public NativeParallelHashMap<int, int> prefabTypeFromIndexRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C9")]
			public KGBKIFFMFNI.MMNCABAOFFE<ArchetypeChunk, IMFAAJOOHCA<RRObjectPrefabV2Data>> it;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40004CA")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40004CB")]
			public NativeList<ICGKPPOKBOG> prefabTypeData;

			[Cpp2IlInjected.Token(Token = "0x60008BD")]
			[Cpp2IlInjected.Address(RVA = "0x3DE96C0", Offset = "0x3DE8AC0", VA = "0x183DE96C0")]
			private void EJBLFCAPFKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008BE")]
			[Cpp2IlInjected.Address(RVA = "0x3DE9980", Offset = "0x3DE8D80", VA = "0x183DE9980", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private static readonly PILIJFIMAJF log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private EntityQuery queryV2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0x223ED70", Offset = "0x223E170", VA = "0x18223ED70", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B7")]
		[Cpp2IlInjected.Address(RVA = "0x223EE00", Offset = "0x223E200", VA = "0x18223EE00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x223EB60", Offset = "0x223DF60", VA = "0x18223EB60")]
		private EntityCommandBufferSystem KMBJDEEDCKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x223E9B0", Offset = "0x223DDB0", VA = "0x18223E9B0")]
		private JobHandle HMGMBCNIAKK(SharedComponentTypeHandle<RRObjectPrefabV2Data> prefabTypeHandleRO, EntityTypeHandle entityTypeHandleRO, NativeArray<ArchetypeChunk> chunksRO, NativeParallelHashMap<int, int> prefabTypeFromIndexRO, KGBKIFFMFNI.MMNCABAOFFE<ArchetypeChunk, IMFAAJOOHCA<RRObjectPrefabV2Data>> it, NativeList<Entity> entities, NativeList<ICGKPPOKBOG> prefabTypeData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x223EBB0", Offset = "0x223DFB0", VA = "0x18223EBB0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
		public PreSerializeDowngrade_RRObjectPrefabTypeData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
internal struct BHFODDCOKNF : AJHCFBOLAKM, IEquatable<BHFODDCOKNF>
{
	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public int BJNMAHEDMNC
	{
		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0xBDECE0", Offset = "0xBDE0E0", VA = "0x180BDECE0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x8D4800", Offset = "0x8D3C00", VA = "0x1808D4800", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public int EGCDHDOFEEK
	{
		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x16CFC90", Offset = "0x16CF090", VA = "0x1816CFC90", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x2513720", Offset = "0x2512B20", VA = "0x182513720", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008C3")]
	[Cpp2IlInjected.Address(RVA = "0x2513730", Offset = "0x2512B30", VA = "0x182513730", Slot = "8")]
	public bool Equals(BHFODDCOKNF LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008C4")]
	[Cpp2IlInjected.Address(RVA = "0x2513780", Offset = "0x2512B80", VA = "0x182513780", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016E")]
[EFDJEPLIMOC(typeof(JKFGGDBFGOH), new string[] { })]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
internal sealed class JKFGGDBFGOH : AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	[ONGFANECMJO]
	private PFJMBDHJHAN BDLCNPMEDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	[ONGFANECMJO]
	private LAEBFAHMGJG FHPJAFHOKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	[ONGFANECMJO]
	private CLBEKBFHODM CKNDLLCLHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	[ONGFANECMJO]
	private CIEAPPOCDCN KKLGCCIPMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	[ONGFANECMJO]
	private GNCJLPLLPLA EDNPFADAINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	[ONGFANECMJO]
	private PJNOCLLALMF HOLOPGCACNK;

	[Cpp2IlInjected.Token(Token = "0x60008C5")]
	[Cpp2IlInjected.Address(RVA = "0x288DF20", Offset = "0x288D320", VA = "0x18288DF20", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C6")]
	[Cpp2IlInjected.Address(RVA = "0x288D8E0", Offset = "0x288CCE0", VA = "0x18288D8E0")]
	public void DHDMDNFIBGC(NativeArray<LENINMGJJHF> PMMGJMLABKC, NativeArray<CMFFIMLEPBE> MAEMAKOHEBK, NativeArray<Entity> FJGBHHFPLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C7")]
	[Cpp2IlInjected.Address(RVA = "0x288D8D0", Offset = "0x288CCD0", VA = "0x18288D8D0")]
	public Entity DHDMDNFIBGC(LENINMGJJHF MNOKFAHHNHH, CMFFIMLEPBE AIOICCOKGOP)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008C8")]
	[Cpp2IlInjected.Address(RVA = "0x288D840", Offset = "0x288CC40", VA = "0x18288D840")]
	public Entity CGDIEAADOPD(LENINMGJJHF MNOKFAHHNHH, bool LKMELNGEJFK)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008C9")]
	[Cpp2IlInjected.Address(RVA = "0x288D830", Offset = "0x288CC30", VA = "0x18288D830")]
	public Entity CGDIEAADOPD(LENINMGJJHF MNOKFAHHNHH)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008CA")]
	[Cpp2IlInjected.Address(RVA = "0x288D7E0", Offset = "0x288CBE0", VA = "0x18288D7E0")]
	public Entity BIMCGJHILGA()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008CB")]
	[Cpp2IlInjected.Address(RVA = "0x288D7F0", Offset = "0x288CBF0", VA = "0x18288D7F0")]
	public Entity BNHELOPAIOO(EHKHPDFBEJD JLNNFEOBAMK)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008CC")]
	[Cpp2IlInjected.Address(RVA = "0x288E030", Offset = "0x288D430", VA = "0x18288E030")]
	public PPACDBGDBCI MOCOOKLAOJK(PPACDBGDBCI GEKPNOHHCDG, Allocator GMMIODGPFPJ)
	{
		return default(PPACDBGDBCI);
	}

	[Cpp2IlInjected.Token(Token = "0x60008CD")]
	[Cpp2IlInjected.Address(RVA = "0x288DAC0", Offset = "0x288CEC0", VA = "0x18288DAC0")]
	public EntityArchetype EFOEJJFLFAE(LENINMGJJHF MNOKFAHHNHH)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x60008CE")]
	[Cpp2IlInjected.Address(RVA = "0x288E010", Offset = "0x288D410", VA = "0x18288E010")]
	public Entity KNDJPPIAOGM(LENINMGJJHF MNOKFAHHNHH)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008CF")]
	[Cpp2IlInjected.Address(RVA = "0x288DE90", Offset = "0x288D290", VA = "0x18288DE90")]
	private Entity IICHIDFCMEN(LENINMGJJHF MNOKFAHHNHH, bool LKMELNGEJFK)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008D0")]
	[Cpp2IlInjected.Address(RVA = "0x288DE00", Offset = "0x288D200", VA = "0x18288DE00")]
	private Entity IICHIDFCMEN(LENINMGJJHF MNOKFAHHNHH)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008D1")]
	[Cpp2IlInjected.Address(RVA = "0x288DC50", Offset = "0x288D050", VA = "0x18288DC50")]
	private Entity IICHIDFCMEN(LENINMGJJHF MNOKFAHHNHH, CMFFIMLEPBE AIOICCOKGOP)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008D2")]
	[Cpp2IlInjected.Address(RVA = "0x288DB00", Offset = "0x288CF00", VA = "0x18288DB00")]
	private void GELBGNHFFFG(LENINMGJJHF MNOKFAHHNHH, NativeArray<CMFFIMLEPBE> MAEMAKOHEBK, NativeArray<Entity> FJGBHHFPLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D3")]
	[Cpp2IlInjected.Address(RVA = "0x288E090", Offset = "0x288D490", VA = "0x18288E090")]
	private void OFLAFGOMCJF(NativeArray<LENINMGJJHF> PMMGJMLABKC, NativeArray<CMFFIMLEPBE> MAEMAKOHEBK, NativeArray<Entity> FJGBHHFPLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D4")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public JKFGGDBFGOH()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	[EBCKCHNKEDI]
	public class PostDeserializeRemoveComponentSerializedVersionDataSystem : JKIEMPJPHGI
	{
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private static readonly PILIJFIMAJF log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0x22376B0", Offset = "0x2236AB0", VA = "0x1822376B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D7")]
		[Cpp2IlInjected.Address(RVA = "0x2237740", Offset = "0x2236B40", VA = "0x182237740", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x22374A0", Offset = "0x22368A0", VA = "0x1822374A0")]
		private EntityCommandBufferSystem KMBJDEEDCKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x22374F0", Offset = "0x22368F0", VA = "0x1822374F0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
		public PostDeserializeRemoveComponentSerializedVersionDataSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000170")]
[ExecuteAlways]
public class MAHFNHANKIE : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x60008DC")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AF0", Offset = "0x7F0EF0", VA = "0x1807F1AF0")]
	public MAHFNHANKIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000171")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
[EFDJEPLIMOC(typeof(NLLKOIOEBHH), new string[] { })]
internal class NLLKOIOEBHH : AKFIPDJCCOH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly SceneTag PAIILNFBGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	[ONGFANECMJO]
	private PFJMBDHJHAN BDLCNPMEDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	[ONGFANECMJO]
	private ADBHPBOEEGG AOFNEPAGJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	[ONGFANECMJO]
	private DNMGNPMNFDI FCGEAJNLBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	[ONGFANECMJO]
	private EDAGPFPPFFG AJMDHBOAFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	[ONGFANECMJO]
	private MDBOACJLHAE APOEHIJFKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	[ONGFANECMJO]
	private LPIHKEBMEKO PFKFIOJAFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	private EntityQuery HDOEHPANOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	private EntityQuery HJNIEPDCNEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	private EntityQuery ONHMIMOJKLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private Entity FDJABHHNEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	private bool MMLDFGNKLLJ;

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public NativeArray<Entity> PBJBNENHJFA
	{
		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0xA49870", Offset = "0xA48C70", VA = "0x180A49870")]
		[CompilerGenerated]
		get
		{
			return default(NativeArray<Entity>);
		}
		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0xA482C0", Offset = "0xA476C0", VA = "0x180A482C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public Entity CDPNOIIGANM
	{
		[Cpp2IlInjected.Token(Token = "0x60008DF")]
		[Cpp2IlInjected.Address(RVA = "0x2A71C50", Offset = "0x2A71050", VA = "0x182A71C50")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public SceneTag PGLIHOGNHFP
	{
		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x2A70CD0", Offset = "0x2A700D0", VA = "0x182A70CD0")]
		get
		{
			return default(SceneTag);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public Entity HHBEDLCLIJF
	{
		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x2A70CD0", Offset = "0x2A700D0", VA = "0x182A70CD0")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x2A711D0", Offset = "0x2A705D0", VA = "0x182A711D0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	private EntityManager FCLKPLIBOOP
	{
		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0x2A72310", Offset = "0x2A71710", VA = "0x182A72310")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008E4")]
	[Cpp2IlInjected.Address(RVA = "0x2A71680", Offset = "0x2A70A80", VA = "0x182A71680", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E5")]
	[Cpp2IlInjected.Address(RVA = "0x2A71090", Offset = "0x2A70490", VA = "0x182A71090", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E6")]
	[Cpp2IlInjected.Address(RVA = "0x2A71D40", Offset = "0x2A71140", VA = "0x182A71D40")]
	public void MLDMMDFLOBL(Entity FKNFFDFGNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E7")]
	[Cpp2IlInjected.Address(RVA = "0x2A71610", Offset = "0x2A70A10", VA = "0x182A71610")]
	public NativeArray<Entity> GJCOBCPNCDL(Allocator GMMIODGPFPJ = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60008E8")]
	[Cpp2IlInjected.Address(RVA = "0x2A71270", Offset = "0x2A70670", VA = "0x182A71270")]
	public void FMEFHAOJFBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E9")]
	[Cpp2IlInjected.Address(RVA = "0x2A710D0", Offset = "0x2A704D0", VA = "0x182A710D0")]
	public void EHCOPHKEOLO(Entity EOOPPEEEACO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008EA")]
	[Cpp2IlInjected.Address(RVA = "0x2A71B30", Offset = "0x2A70F30", VA = "0x182A71B30")]
	public Entity JNKANKGAMJN(string DKPHPKDPBCM = "")
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008EB")]
	[Cpp2IlInjected.Address(RVA = "0x2A71E60", Offset = "0x2A71260", VA = "0x182A71E60")]
	public void NCABBFDNHGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008EC")]
	[Cpp2IlInjected.Address(RVA = "0x2A70D20", Offset = "0x2A70120", VA = "0x182A70D20")]
	public void CABDBNKCDNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008ED")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	public void AKIIEMMKFFL(Entity EOOPPEEEACO, string DKPHPKDPBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008EE")]
	[Cpp2IlInjected.Address(RVA = "0x2A72360", Offset = "0x2A71760", VA = "0x182A72360")]
	public void PPNDBIAHNGL(Entity EOOPPEEEACO, bool ACKOFDDPIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008EF")]
	[Cpp2IlInjected.Address(RVA = "0x2A71F40", Offset = "0x2A71340", VA = "0x182A71F40")]
	public void PKIOFPAGGEC(Entity FKNFFDFGNMN, Entity EOOPPEEEACO, bool AHNELKHHBHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F0")]
	[Cpp2IlInjected.Address(RVA = "0x2A72130", Offset = "0x2A71530", VA = "0x182A72130")]
	public void PKIOFPAGGEC(NativeArray<Entity> PGJLMFPAKDA, Entity EOOPPEEEACO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F1")]
	[Cpp2IlInjected.Address(RVA = "0x2A712C0", Offset = "0x2A706C0", VA = "0x182A712C0")]
	private void FMNKCEACGGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F2")]
	[Cpp2IlInjected.Address(RVA = "0x2A71240", Offset = "0x2A70640", VA = "0x182A71240")]
	private void FFNHPJODANP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F3")]
	[Cpp2IlInjected.Address(RVA = "0x2A71C50", Offset = "0x2A71050", VA = "0x182A71C50")]
	private Entity LOCCNOKGFDD()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008F4")]
	[Cpp2IlInjected.Address(RVA = "0x2A71780", Offset = "0x2A70B80", VA = "0x182A71780")]
	private void JIIGKGBCNCC(EntityQuery OMLENFDANLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F5")]
	[Cpp2IlInjected.Address(RVA = "0x2A71850", Offset = "0x2A70C50", VA = "0x182A71850")]
	private void JIIGKGBCNCC(NativeArray<Entity> FLAALGKHIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F6")]
	[Cpp2IlInjected.Address(RVA = "0x2A70E70", Offset = "0x2A70270", VA = "0x182A70E70")]
	private void CDHFHDHFNJM(Entity EOOPPEEEACO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F7")]
	[Cpp2IlInjected.Address(RVA = "0x2A70D40", Offset = "0x2A70140", VA = "0x182A70D40")]
	private void CBAOMPGHKMC(Entity EOOPPEEEACO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F8")]
	[Cpp2IlInjected.Address(RVA = "0x2A70F20", Offset = "0x2A70320", VA = "0x182A70F20")]
	private void CNKJEHFJBKI(SceneTag MDBOBEEIDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F9")]
	[Cpp2IlInjected.Address(RVA = "0x2A71640", Offset = "0x2A70A40", VA = "0x182A71640")]
	private void IPJFKIBDNPM(SceneTag MDBOBEEIDNC, NativeParallelHashSet<int> JLMEBGOBPAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008FA")]
	[Cpp2IlInjected.Address(RVA = "0x2A71470", Offset = "0x2A70870", VA = "0x182A71470")]
	private void GBLEFGFHCJI(SceneTag MDBOBEEIDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008FB")]
	[Cpp2IlInjected.Address(RVA = "0x2A71E80", Offset = "0x2A71280", VA = "0x182A71E80")]
	private void NPPGFFBMNKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008FC")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9390", Offset = "0x2BD8790", VA = "0x182BD9390")]
	private void AJBAGAJPCCJ<T>() where T : ComponentSystemBase
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008FD")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public NLLKOIOEBHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000172")]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
internal class BIILILPLANK : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	private DNMGNPMNFDI EGEBFNBKGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	private EGBDNLKFOBI NFOOMJHPEJF;

	[Cpp2IlInjected.Token(Token = "0x60008FF")]
	[Cpp2IlInjected.Address(RVA = "0x2513E20", Offset = "0x2513220", VA = "0x182513E20", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000900")]
	[Cpp2IlInjected.Address(RVA = "0x2513E90", Offset = "0x2513290", VA = "0x182513E90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000901")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public BIILILPLANK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
[EFDJEPLIMOC(typeof(CIEAPPOCDCN), new string[] { })]
internal sealed class CIEAPPOCDCN : AKFIPDJCCOH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	[ONGFANECMJO]
	private PFJMBDHJHAN GKACEDOEIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	[ONGFANECMJO]
	private LAEBFAHMGJG JLEJAPJJCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	[ONGFANECMJO]
	private CLBEKBFHODM BEAIJNEIBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	private AOONNPAOEFB FHJACJEANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	private NativeParallelHashMap<CMFFIMLEPBE, Entity> HJGHCFODCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private EntityManager GLPCEPPDPLB;

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	internal NativeParallelHashMap<CMFFIMLEPBE, Entity> BNANJDBGNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0xC0F7F0", Offset = "0xC0EBF0", VA = "0x180C0F7F0")]
		get
		{
			return default(NativeParallelHashMap<CMFFIMLEPBE, Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	internal uint IPKKJCFFADA
	{
		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x251A990", Offset = "0x2519D90", VA = "0x18251A990")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	private bool MPIAMCJMFLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0xA828E0", Offset = "0xA81CE0", VA = "0x180A828E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000906")]
	[Cpp2IlInjected.Address(RVA = "0x251A810", Offset = "0x2519C10", VA = "0x18251A810", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000907")]
	[Cpp2IlInjected.Address(RVA = "0x251A5C0", Offset = "0x25199C0", VA = "0x18251A5C0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000908")]
	[Cpp2IlInjected.Address(RVA = "0x251B140", Offset = "0x251A540", VA = "0x18251B140")]
	public void PEHJALIONDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000909")]
	[Cpp2IlInjected.Address(RVA = "0x251A9C0", Offset = "0x2519DC0", VA = "0x18251A9C0")]
	public CMFFIMLEPBE KGINOODAPHB(int ECOAGJBCGAI)
	{
		return default(CMFFIMLEPBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600090A")]
	[Cpp2IlInjected.Address(RVA = "0x251A400", Offset = "0x2519800", VA = "0x18251A400")]
	public void BPONGNIAJLH(CMFFIMLEPBE AIOICCOKGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090B")]
	[Cpp2IlInjected.Address(RVA = "0x251AF20", Offset = "0x251A320", VA = "0x18251AF20")]
	public KDLENLDMBAK OIPIJNOEBKM(CMFFIMLEPBE AIOICCOKGOP)
	{
		return default(KDLENLDMBAK);
	}

	[Cpp2IlInjected.Token(Token = "0x600090C")]
	[Cpp2IlInjected.Address(RVA = "0x251AAB0", Offset = "0x2519EB0", VA = "0x18251AAB0")]
	public bool NAGMLCICLNG(CMFFIMLEPBE AIOICCOKGOP, out KDLENLDMBAK LCODCOPGHJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600090D")]
	[Cpp2IlInjected.Address(RVA = "0x251ADC0", Offset = "0x251A1C0", VA = "0x18251ADC0")]
	public PPACDBGDBCI OIPIJNOEBKM(NativeArray<CMFFIMLEPBE> AIOICCOKGOP, Allocator GMMIODGPFPJ)
	{
		return default(PPACDBGDBCI);
	}

	[Cpp2IlInjected.Token(Token = "0x600090E")]
	[Cpp2IlInjected.Address(RVA = "0x251AC10", Offset = "0x251A010", VA = "0x18251AC10")]
	public CMFFIMLEPBE NLOPILAOEJF(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(CMFFIMLEPBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600090F")]
	[Cpp2IlInjected.Address(RVA = "0x251ACF0", Offset = "0x251A0F0", VA = "0x18251ACF0")]
	public CMFFIMLEPBE NLOPILAOEJF(Entity FKNFFDFGNMN)
	{
		return default(CMFFIMLEPBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000910")]
	[Cpp2IlInjected.Address(RVA = "0x251A630", Offset = "0x2519A30", VA = "0x18251A630")]
	public void GFMDPPCGGFM(NativeArray<Entity> PGJLMFPAKDA, NativeArray<CMFFIMLEPBE> MAEMAKOHEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000911")]
	[Cpp2IlInjected.Address(RVA = "0x251A940", Offset = "0x2519D40", VA = "0x18251A940")]
	private KDLENLDMBAK JAEMFBMMNNL(Entity FKNFFDFGNMN)
	{
		return default(KDLENLDMBAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000912")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public CIEAPPOCDCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
[EFDJEPLIMOC(typeof(MDBOACJLHAE), new string[] { })]
internal sealed class MDBOACJLHAE : AKFIPDJCCOH, CBKELFDIEEL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	[ONGFANECMJO]
	private PFJMBDHJHAN BDLCNPMEDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	[ONGFANECMJO]
	private EDAGPFPPFFG AJMDHBOAFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	private Entity FKNFFDFGNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	private ComponentTypeList NMIBCPIHMNH;

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public EntityManager FCLKPLIBOOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x2A65D00", Offset = "0x2A65100", VA = "0x182A65D00")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000915")]
	[Cpp2IlInjected.Address(RVA = "0x293E1C0", Offset = "0x293D5C0", VA = "0x18293E1C0")]
	public T IKHPLCCBENN<T>() where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000916")]
	[Cpp2IlInjected.Address(RVA = "0x293DFF0", Offset = "0x293D3F0", VA = "0x18293DFF0")]
	public void DADPJLGDIHI<T>(T KKIAKNLLHIO) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000917")]
	[Cpp2IlInjected.Address(RVA = "0x293E0C0", Offset = "0x293D4C0", VA = "0x18293E0C0")]
	public DynamicBuffer<T> EJAMLOFBANC<T>(bool LIHCGKJOJDH = false) where T : struct, IBufferElementData
	{
		return default(DynamicBuffer<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000918")]
	[Cpp2IlInjected.Address(RVA = "0x293E280", Offset = "0x293D680", VA = "0x18293E280")]
	public void JBAEECDIAPE<T>(T KKIAKNLLHIO) where T : struct, IBufferElementData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000919")]
	[Cpp2IlInjected.Address(RVA = "0x2A65AF0", Offset = "0x2A64EF0", VA = "0x182A65AF0", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600091A")]
	[Cpp2IlInjected.Address(RVA = "0x2A65B60", Offset = "0x2A64F60", VA = "0x182A65B60", Slot = "5")]
	public void JFCLKDMBJND(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600091B")]
	[Cpp2IlInjected.Address(RVA = "0x2A65B60", Offset = "0x2A64F60", VA = "0x182A65B60")]
	private void MOFPMMFMOAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600091C")]
	[Cpp2IlInjected.Address(RVA = "0x2A653A0", Offset = "0x2A647A0", VA = "0x182A653A0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600091D")]
	[Cpp2IlInjected.Address(RVA = "0x2A65750", Offset = "0x2A64B50", VA = "0x182A65750")]
	private ComponentTypeList HABFJKBOHDO()
	{
		return default(ComponentTypeList);
	}

	[Cpp2IlInjected.Token(Token = "0x600091E")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	private static void EIMEOGEMCFG(int ECOAGJBCGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600091F")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	private static void KCHJEAIDFAE(Type JLNNFEOBAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000920")]
	[Cpp2IlInjected.Address(RVA = "0x2A65650", Offset = "0x2A64A50", VA = "0x182A65650")]
	private static void FIKNGDDNDOG(Type JLNNFEOBAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000921")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public MDBOACJLHAE()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000175")]
[NFMOBAODLHH]
internal struct GEFHOKDHFMB : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000176")]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
internal class PGGHIOAOLGL : JKIEMPJPHGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	private EntityQuery IJMAPDJJPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	private EntityQuery GCJKLELGCGA;

	[Cpp2IlInjected.Token(Token = "0x6000923")]
	[Cpp2IlInjected.Address(RVA = "0x222F970", Offset = "0x222ED70", VA = "0x18222F970", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000924")]
	[Cpp2IlInjected.Address(RVA = "0x222FA60", Offset = "0x222EE60", VA = "0x18222FA60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000925")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public PGGHIOAOLGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
[ALIINGEKIMD]
public class HKAOLLLLPMM : JKIEMPJPHGI, IBKHNFKEFMN.GPOJBALCDLB
{
	[Cpp2IlInjected.Token(Token = "0x6000926")]
	[Cpp2IlInjected.Address(RVA = "0x287B3F0", Offset = "0x287A7F0", VA = "0x18287B3F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000927")]
	[Cpp2IlInjected.Address(RVA = "0x287B3A0", Offset = "0x287A7A0", VA = "0x18287B3A0")]
	private EntityCommandBufferSystem KMBJDEEDCKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000928")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public HKAOLLLLPMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
public class CBHMGKONCDI : JKIEMPJPHGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	private EntityQuery PNGFJEAJDGO;

	[Cpp2IlInjected.Token(Token = "0x6000929")]
	[Cpp2IlInjected.Address(RVA = "0x25162D0", Offset = "0x25156D0", VA = "0x1825162D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600092A")]
	[Cpp2IlInjected.Address(RVA = "0x2516360", Offset = "0x2515760", VA = "0x182516360", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600092B")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public CBHMGKONCDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
[AlwaysUpdateSystem]
public class BFAEKJANJNA : KMPGAAGIPLF
{
	[Cpp2IlInjected.Token(Token = "0x600092C")]
	[Cpp2IlInjected.Address(RVA = "0x2513160", Offset = "0x2512560", VA = "0x182513160", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600092D")]
	[Cpp2IlInjected.Address(RVA = "0xD17B50", Offset = "0xD16F50", VA = "0x180D17B50")]
	public BFAEKJANJNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
[EFDJEPLIMOC(typeof(EGBDNLKFOBI), new string[] { })]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
internal class EGBDNLKFOBI : AKFIPDJCCOH, CBKELFDIEEL, KNHBDNEIEIA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	internal readonly struct BFHDOIFCHLK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private readonly GCGDNGNDAMG BCDFAICIHBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private readonly EGBDNLKFOBI OBOAIKCPODL;

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0x2708A50", Offset = "0x2707E50", VA = "0x182708A50")]
		public BFHDOIFCHLK(EGBDNLKFOBI OBOAIKCPODL, GCGDNGNDAMG FHKLPGFAIGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0x2708A30", Offset = "0x2707E30", VA = "0x182708A30", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private static readonly PILIJFIMAJF OOHLCBNNOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	[ONGFANECMJO]
	private PFJMBDHJHAN GKACEDOEIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	[ONGFANECMJO]
	private ANLJAEDMKMC KLBBCPHGEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	[ONGFANECMJO]
	private GNCJLPLLPLA EDNPFADAINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	private readonly FIACLIIFJJG[] BHIDIADCLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	private IJEMANMGDHA NHFIOAOABBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000500")]
	private NativeParallelHashMap<int, Entity> GPHMFMMLINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000501")]
	private GCGDNGNDAMG BNDIJNEFHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000502")]
	private bool MMLDFGNKLLJ;

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public World DFKBAKJLNEK
	{
		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0x28C5CF0", Offset = "0x28C50F0", VA = "0x1828C5CF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public World DIMECBCAKBF
	{
		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x94CE00", Offset = "0x94C200", VA = "0x18094CE00", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0x94C610", Offset = "0x94BA10", VA = "0x18094C610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public IJEMANMGDHA CLGMHJGDFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0x28C6050", Offset = "0x28C5450", VA = "0x1828C6050", Slot = "8")]
		get
		{
			return default(IJEMANMGDHA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public uint COFHBFKJOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0x17E4540", Offset = "0x17E3940", VA = "0x1817E4540", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0xEC72F0", Offset = "0xEC66F0", VA = "0x180EC72F0", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	private bool FKJCJFKFJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(RVA = "0x17E4C10", Offset = "0x17E4010", VA = "0x1817E4C10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool MPIAMCJMFLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x1772610", Offset = "0x1771A10", VA = "0x181772610", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public NativeParallelHashMap<int, Entity> KLFGIDLHBGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x1B135B0", Offset = "0x1B129B0", VA = "0x181B135B0")]
		get
		{
			return default(NativeParallelHashMap<int, Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public PGBPMCLMNHE ENJAHFAINEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000939")]
		[Cpp2IlInjected.Address(RVA = "0x28C5CB0", Offset = "0x28C50B0", VA = "0x1828C5CB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public JDLBPHHOKOP LCIKEFKNHND
	{
		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0x28C5CB0", Offset = "0x28C50B0", VA = "0x1828C5CB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public GCGDNGNDAMG DCEDMEDCLKE
	{
		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0x9C4340", Offset = "0x9C3740", VA = "0x1809C4340")]
		get
		{
			return default(GCGDNGNDAMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000937")]
	[Cpp2IlInjected.Address(RVA = "0x28C6310", Offset = "0x28C5710", VA = "0x1828C6310")]
	public PGBPMCLMNHE MHDDKJCPJIO(GCGDNGNDAMG GKOGFPHIKMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000938")]
	[Cpp2IlInjected.Address(RVA = "0x28C6310", Offset = "0x28C5710", VA = "0x1828C6310")]
	public JDLBPHHOKOP PBMLDMNJHBA(GCGDNGNDAMG GKOGFPHIKMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600093C")]
	[Cpp2IlInjected.Address(RVA = "0x28C5D40", Offset = "0x28C5140", VA = "0x1828C5D40", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093D")]
	[Cpp2IlInjected.Address(RVA = "0x28C5E10", Offset = "0x28C5210", VA = "0x1828C5E10", Slot = "5")]
	public void JFCLKDMBJND(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093E")]
	[Cpp2IlInjected.Address(RVA = "0x28C6080", Offset = "0x28C5480", VA = "0x1828C6080")]
	private NativeParallelHashMap<int, Entity> MEHJBNILNBA()
	{
		return default(NativeParallelHashMap<int, Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600093F")]
	[Cpp2IlInjected.Address(RVA = "0x28C5B40", Offset = "0x28C4F40", VA = "0x1828C5B40")]
	public void BHOOCFJBJDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000940")]
	[Cpp2IlInjected.Address(RVA = "0x28C6350", Offset = "0x28C5750", VA = "0x1828C6350")]
	public void PEHJALIONDD(GCGDNGNDAMG GKOGFPHIKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000941")]
	[Cpp2IlInjected.Address(RVA = "0x28C63A0", Offset = "0x28C57A0", VA = "0x1828C63A0")]
	public void PEHJALIONDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000942")]
	[Cpp2IlInjected.Address(RVA = "0x28C5B90", Offset = "0x28C4F90", VA = "0x1828C5B90", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000943")]
	[Cpp2IlInjected.Address(RVA = "0x28C62F0", Offset = "0x28C56F0", VA = "0x1828C62F0")]
	public BFHDOIFCHLK MGCDECIIBIB(GCGDNGNDAMG GKOGFPHIKMK)
	{
		return default(BFHDOIFCHLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000944")]
	[Cpp2IlInjected.Address(RVA = "0x28C6540", Offset = "0x28C5940", VA = "0x1828C6540")]
	public EGBDNLKFOBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
internal class DLMHCJFGPCN : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	private EntityQuery NLEFPPELPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	private GDDLKDHJNAI NKKFHEHKJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	private AOONNPAOEFB FHJACJEANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	private BKIGCJIBBEC JFEIOACDBLI;

	[Cpp2IlInjected.Token(Token = "0x6000948")]
	[Cpp2IlInjected.Address(RVA = "0x2523180", Offset = "0x2522580", VA = "0x182523180", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000949")]
	[Cpp2IlInjected.Address(RVA = "0x2523210", Offset = "0x2522610", VA = "0x182523210", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600094A")]
	[Cpp2IlInjected.Address(RVA = "0x25232B0", Offset = "0x25226B0", VA = "0x1825232B0", Slot = "6")]
	protected override void OnStartRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600094B")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600094C")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public DLMHCJFGPCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
[EBCKCHNKEDI]
public class LHHAHGBDHNM : KBODFINGEBH
{
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private EntityQuery PNGFJEAJDGO;

	[Cpp2IlInjected.Token(Token = "0x600094E")]
	[Cpp2IlInjected.Address(RVA = "0x2A5FD40", Offset = "0x2A5F140", VA = "0x182A5FD40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600094F")]
	[Cpp2IlInjected.Address(RVA = "0x2A5FDF0", Offset = "0x2A5F1F0", VA = "0x182A5FDF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000950")]
	[Cpp2IlInjected.Address(RVA = "0x2A5FCF0", Offset = "0x2A5F0F0", VA = "0x182A5FCF0")]
	private EntityCommandBufferSystem KMBJDEEDCKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000951")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public LHHAHGBDHNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
public class MAKOMBIACKJ : KBODFINGEBH
{
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.Token(Token = "0x6000953")]
	[Cpp2IlInjected.Address(RVA = "0x2A63940", Offset = "0x2A62D40", VA = "0x182A63940", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000954")]
	[Cpp2IlInjected.Address(RVA = "0x2A638F0", Offset = "0x2A62CF0", VA = "0x182A638F0")]
	private EntityCommandBufferSystem KMBJDEEDCKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000955")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public MAKOMBIACKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
public struct HCECBPEAHJA<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	private GCHandle PPCGBBAKOHO;

	[Cpp2IlInjected.Token(Token = "0x600095A")]
	[Cpp2IlInjected.Address(RVA = "0x3591020", Offset = "0x3590420", VA = "0x183591020", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
[ALIINGEKIMD]
public class JAJDAPDFNNG : JKIEMPJPHGI, IBKHNFKEFMN.GPOJBALCDLB
{
	[Cpp2IlInjected.Token(Token = "0x600095B")]
	[Cpp2IlInjected.Address(RVA = "0x28873D0", Offset = "0x28867D0", VA = "0x1828873D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095C")]
	[Cpp2IlInjected.Address(RVA = "0x2887380", Offset = "0x2886780", VA = "0x182887380")]
	private EntityCommandBufferSystem KMBJDEEDCKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600095D")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public JAJDAPDFNNG()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	public class PreSerializeSaveNetworkIds : JKIEMPJPHGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x600095E")]
		[Cpp2IlInjected.Address(RVA = "0x223FAA0", Offset = "0x223EEA0", VA = "0x18223FAA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095F")]
		[Cpp2IlInjected.Address(RVA = "0x223FB30", Offset = "0x223EF30", VA = "0x18223FB30", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000960")]
		[Cpp2IlInjected.Address(RVA = "0x223F890", Offset = "0x223EC90", VA = "0x18223F890")]
		private EntityCommandBufferSystem EKGEGEFMAIN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000961")]
		[Cpp2IlInjected.Address(RVA = "0x223F8E0", Offset = "0x223ECE0", VA = "0x18223F8E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000962")]
		[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
		public PreSerializeSaveNetworkIds()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
[AlwaysUpdateSystem]
public class HHPJFODLPLB : JKIEMPJPHGI
{
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.Token(Token = "0x6000963")]
	[Cpp2IlInjected.Address(RVA = "0x287A9A0", Offset = "0x2879DA0", VA = "0x18287A9A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000964")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public HHPJFODLPLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
[EBCKCHNKEDI]
[HONNCCIFPDK(CAGOEBHGGNL.OMRoom)]
public class BCCJBPCFNPO : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	private PGEMHDJNMBJ OAJPGNEHMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	private NLLKOIOEBHH FLAALGKHIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	private EntityQuery PNGFJEAJDGO;

	[Cpp2IlInjected.Token(Token = "0x6000966")]
	[Cpp2IlInjected.Address(RVA = "0x2511080", Offset = "0x2510480", VA = "0x182511080", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000967")]
	[Cpp2IlInjected.Address(RVA = "0x25110F0", Offset = "0x25104F0", VA = "0x1825110F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000968")]
	[Cpp2IlInjected.Address(RVA = "0x2511190", Offset = "0x2510590", VA = "0x182511190", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000969")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public BCCJBPCFNPO()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
	internal class SplinePointOrderingUpdateSystem : JKIEMPJPHGI, AKFIPDJCCOH
	{
		[Cpp2IlInjected.Token(Token = "0x2000186")]
		[BurstCompile]
		private struct UpdateSplineIndexJob : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400051C")]
			[ReadOnly]
			public NativeArray<global::DHBCNOAODED> indexUpdatesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400051D")]
			[ReadOnly]
			public ComponentDataFromEntity<OCGHCEBJNGN> splinePointParentDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400051E")]
			public ComponentDataFromEntity<EOGEBMPBCME> splinePointOrderDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400051F")]
			public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

			[Cpp2IlInjected.Token(Token = "0x6000972")]
			[Cpp2IlInjected.Address(RVA = "0x3DEDEA0", Offset = "0x3DED2A0", VA = "0x183DEDEA0", Slot = "4")]
			public void Execute(int i)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000187")]
		private struct OrderComparer : IComparer<Entity>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000520")]
			[ReadOnly]
			public ComponentDataFromEntity<EOGEBMPBCME> orderRO;

			[Cpp2IlInjected.Token(Token = "0x6000973")]
			[Cpp2IlInjected.Address(RVA = "0x3DE6AA0", Offset = "0x3DE5EA0", VA = "0x183DE6AA0", Slot = "4")]
			public int Compare(Entity x, Entity y)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000188")]
		[NoAlias]
		[BurstCompile]
		private struct SplinePointOrderingUpdateSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000521")]
			public OrderComparer comparer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000522")]
			[ReadOnly]
			public EntityTypeHandle __splineTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000523")]
			public BufferTypeHandle<LinkedEntityGroup> __bufferTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000974")]
			[Cpp2IlInjected.Address(RVA = "0x3DEC7E0", Offset = "0x3DEBBE0", VA = "0x183DEC7E0")]
			private void EJBLFCAPFKM(Entity spline, DynamicBuffer<LinkedEntityGroup> buffer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000975")]
			[Cpp2IlInjected.Address(RVA = "0x3DEC870", Offset = "0x3DEBC70", VA = "0x183DEC870", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private EntityQuery needsUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		[ONGFANECMJO]
		private MDBOACJLHAE singletonService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		private EntityQuery SplinePointOrderingUpdateSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(RVA = "0x2241FB0", Offset = "0x22413B0", VA = "0x182241FB0", Slot = "14")]
		public void InitReferences(EMFBCBAOENA services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096B")]
		[Cpp2IlInjected.Address(RVA = "0x2242650", Offset = "0x2241A50", VA = "0x182242650", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096C")]
		[Cpp2IlInjected.Address(RVA = "0x2241C20", Offset = "0x2241020", VA = "0x182241C20")]
		private void CEBKGLLLGDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096D")]
		[Cpp2IlInjected.Address(RVA = "0x2242000", Offset = "0x2241400", VA = "0x182242000")]
		private void JHDOAIJNJHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096E")]
		[Cpp2IlInjected.Address(RVA = "0x22422A0", Offset = "0x22416A0", VA = "0x1822422A0")]
		private static CMGJAEOCGHK NOEGFJOIPMC(int insertionIndex, ComponentDataFromEntity<EOGEBMPBCME> splinePointOrderDataRO, NativeArray<Entity> children)
		{
			return default(CMGJAEOCGHK);
		}

		[Cpp2IlInjected.Token(Token = "0x600096F")]
		[Cpp2IlInjected.Address(RVA = "0x2242160", Offset = "0x2241560", VA = "0x182242160")]
		private JobHandle MILOMEKPOLA(OrderComparer comparer, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000970")]
		[Cpp2IlInjected.Address(RVA = "0x2242400", Offset = "0x2241800", VA = "0x182242400", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000971")]
		[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
		public SplinePointOrderingUpdateSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	public class UpdateMassOfShapes : JKIEMPJPHGI
	{
		[Cpp2IlInjected.Token(Token = "0x200018A")]
		[BurstCompile]
		[NoAlias]
		private struct UpdateMassOfShapes_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000526")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000527")]
			[ReadOnly]
			public ComponentDataFromEntity<OGGOJLEGOPG> worldDeformableScalesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000528")]
			[ReadOnly]
			public ComponentDataFromEntity<NEPPICPDJAN> worldUniformScalesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000529")]
			[ReadOnly]
			public ComponentDataFromEntity<JBOOJPNGIGM> physicsMaterialsRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400052A")]
			[ReadOnly]
			public ComponentDataFromEntity<BIDKPBGLPNE> primitiveShapesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400052B")]
			[ReadOnly]
			public ComponentDataFromEntity<ANCGJKBPAIA> localUniformScalesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x400052C")]
			public ComponentDataFromEntity<LOKNJKCACCH> massesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x400052D")]
			public ComponentDataFromEntity<EPPAOJFMIIL> centerOfMassesRW;

			[Cpp2IlInjected.Token(Token = "0x600097D")]
			[Cpp2IlInjected.Address(RVA = "0x3DED900", Offset = "0x3DECD00", VA = "0x183DED900")]
			private void EJBLFCAPFKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600097E")]
			[Cpp2IlInjected.Address(RVA = "0x3DEDD60", Offset = "0x3DED160", VA = "0x183DEDD60", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private static readonly PILIJFIMAJF log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private EntityQuery query;

		[Cpp2IlInjected.Token(Token = "0x6000976")]
		[Cpp2IlInjected.Address(RVA = "0x2249B50", Offset = "0x2248F50", VA = "0x182249B50", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000977")]
		[Cpp2IlInjected.Address(RVA = "0x2249C80", Offset = "0x2249080", VA = "0x182249C80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000978")]
		[Cpp2IlInjected.Address(RVA = "0x2249840", Offset = "0x2248C40", VA = "0x182249840")]
		private void OEKJINGGCPE(NativeList<Entity> entities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000979")]
		[Cpp2IlInjected.Address(RVA = "0x2249660", Offset = "0x2248A60", VA = "0x182249660")]
		private JobHandle HOHBFPNAABO(NativeList<Entity> entities, ComponentDataFromEntity<OGGOJLEGOPG> worldDeformableScalesRO, ComponentDataFromEntity<NEPPICPDJAN> worldUniformScalesRO, ComponentDataFromEntity<JBOOJPNGIGM> physicsMaterialsRO, ComponentDataFromEntity<BIDKPBGLPNE> primitiveShapesRO, ComponentDataFromEntity<ANCGJKBPAIA> localUniformScalesRO, ComponentDataFromEntity<LOKNJKCACCH> massesRW, ComponentDataFromEntity<EPPAOJFMIIL> centerOfMassesRW, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600097A")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
		public UpdateMassOfShapes()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200018B")]
internal struct CNDNMNBBFPH : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
public class KDCDCBMEBGA : ICBEHEHALDJ
{
	[Cpp2IlInjected.Token(Token = "0x600097F")]
	[Cpp2IlInjected.Address(RVA = "0x2891520", Offset = "0x2890920", VA = "0x182891520", Slot = "14")]
	protected override EntityCommandBufferSystem KMBJDEEDCKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000980")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public KDCDCBMEBGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018D")]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
internal class NIGFJIMPBPI : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	private AOONNPAOEFB FHJACJEANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	private HAGBJEJOLJL FBCPJLHEMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	private EntityQuery DLIMNIELMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	private EntityQuery HEHNBNFPLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	private EntityQuery MLDLCCAJBAG;

	[Cpp2IlInjected.Token(Token = "0x6000981")]
	[Cpp2IlInjected.Address(RVA = "0x2A6F780", Offset = "0x2A6EB80", VA = "0x182A6F780", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000982")]
	[Cpp2IlInjected.Address(RVA = "0x2A6FB30", Offset = "0x2A6EF30", VA = "0x182A6FB30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000983")]
	[Cpp2IlInjected.Address(RVA = "0x2A6FCB0", Offset = "0x2A6F0B0", VA = "0x182A6FCB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000984")]
	[Cpp2IlInjected.Address(RVA = "0x2A6FC80", Offset = "0x2A6F080", VA = "0x182A6FC80", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000985")]
	[Cpp2IlInjected.Address(RVA = "0x2A6F7F0", Offset = "0x2A6EBF0", VA = "0x182A6F7F0")]
	private void JLAMCLKOEPP(EntityQuery PNGFJEAJDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000986")]
	[Cpp2IlInjected.Address(RVA = "0x2A6EFD0", Offset = "0x2A6E3D0", VA = "0x182A6EFD0")]
	private void GAIKDCIFEDK(NativeArray<Entity> PGJLMFPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000987")]
	[Cpp2IlInjected.Address(RVA = "0x2A6F340", Offset = "0x2A6E740", VA = "0x182A6F340")]
	private void IJEPDKMIGIE(NativeArray<Entity> PGJLMFPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000988")]
	[Cpp2IlInjected.Address(RVA = "0x2A6F180", Offset = "0x2A6E580", VA = "0x182A6F180")]
	private void HNLFNJCFBFF(EntityQuery PNGFJEAJDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000989")]
	[Cpp2IlInjected.Address(RVA = "0x2A6EDC0", Offset = "0x2A6E1C0", VA = "0x182A6EDC0")]
	private void CEOCNJLFHCF(NativeArray<Entity> PGJLMFPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098A")]
	[Cpp2IlInjected.Address(RVA = "0x2A6F640", Offset = "0x2A6EA40", VA = "0x182A6F640")]
	private void INCNIJCCDJF(KDLENLDMBAK LCODCOPGHJA, int ELEHMFAPFEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098B")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public NIGFJIMPBPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
[GCHMNDFEPKK(typeof(OKGCFPBMNKK))]
[EFDJEPLIMOC(typeof(LCMOEGKNFDM), new string[] { })]
public class NFBDGNJFIPM : LCMOEGKNFDM, DEPDOFHIDBA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	private static readonly Dictionary<int, int> MPGHMILGJOE;

	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E2D0", Offset = "0x2A6D6D0", VA = "0x182A6E2D0", Slot = "5")]
	public void MCOOCEGHCPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098E")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E530", Offset = "0x2A6D930", VA = "0x182A6E530", Slot = "4")]
	public int NDGBPOMPPGO(int EPAJCDGEEKI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600098F")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E250", Offset = "0x2A6D650", VA = "0x182A6E250", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000990")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public NFBDGNJFIPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
[EFDJEPLIMOC(typeof(EBNGCKDPAGC), new string[] { })]
public class GJCFDJKIGCG : AKFIPDJCCOH, CBKELFDIEEL, EBNGCKDPAGC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000190")]
	[CompilerGenerated]
	private sealed class IJCMEIBCFLM : IEnumerable<KDLENLDMBAK>, IEnumerable, IEnumerator<KDLENLDMBAK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private KDLENLDMBAK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private KDLENLDMBAK splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public KDLENLDMBAK <>3__splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public GJCFDJKIGCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private NativeArray<Entity> <children>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		private KDLENLDMBAK System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60009A7")]
			[Cpp2IlInjected.Address(RVA = "0x2711380", Offset = "0x2710780", VA = "0x182711380", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KDLENLDMBAK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60009A9")]
			[Cpp2IlInjected.Address(RVA = "0x27113E0", Offset = "0x27107E0", VA = "0x1827113E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0xB48080", Offset = "0xB47480", VA = "0x180B48080")]
		[DebuggerHidden]
		public IJCMEIBCFLM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A5")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A6")]
		[Cpp2IlInjected.Address(RVA = "0x27111E0", Offset = "0x27105E0", VA = "0x1827111E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A8")]
		[Cpp2IlInjected.Address(RVA = "0x27113A0", Offset = "0x27107A0", VA = "0x1827113A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AA")]
		[Cpp2IlInjected.Address(RVA = "0x27112D0", Offset = "0x27106D0", VA = "0x1827112D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KDLENLDMBAK> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009AB")]
		[Cpp2IlInjected.Address(RVA = "0x27112D0", Offset = "0x27106D0", VA = "0x1827112D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	private PFJMBDHJHAN BDLCNPMEDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	private AOONNPAOEFB FHJACJEANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	private ANLJAEDMKMC KLBBCPHGEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	private JKFGGDBFGOH EDNPFADAINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	private EONNPNOIBPC MCJOPJDGNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	private MDBOACJLHAE HNFAJKHJNCK;

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	private EntityManager FCLKPLIBOOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000992")]
		[Cpp2IlInjected.Address(RVA = "0x28D73B0", Offset = "0x28D67B0", VA = "0x1828D73B0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000993")]
	[Cpp2IlInjected.Address(RVA = "0x28D67B0", Offset = "0x28D5BB0", VA = "0x1828D67B0", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000994")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
	public void JFCLKDMBJND(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000995")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "15")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000996")]
	[Cpp2IlInjected.Address(RVA = "0x28D64C0", Offset = "0x28D58C0", VA = "0x1828D64C0")]
	private void EGGJOALKMGF(Entity HHGGGAMLHBP, int NANJAGEOPJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000997")]
	[Cpp2IlInjected.Address(RVA = "0x28D72D0", Offset = "0x28D66D0", VA = "0x1828D72D0", Slot = "10")]
	public void POMLPAGDIHL(KDLENLDMBAK LCODCOPGHJA, NDDEKGODHLE ANKHOKAAJLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000998")]
	[Cpp2IlInjected.Address(RVA = "0x28D6A10", Offset = "0x28D5E10", VA = "0x1828D6A10", Slot = "9")]
	public NDDEKGODHLE KLHIGFCJEJJ(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(NDDEKGODHLE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000999")]
	[Cpp2IlInjected.Address(RVA = "0x28D6E60", Offset = "0x28D6260", VA = "0x1828D6E60", Slot = "11")]
	public KDLENLDMBAK MMACMFDAAGD(KDLENLDMBAK ANMICKKKMJM, [Optional] float3? OMFIFBMFGMG, [Optional] quaternion? PFHPGOOLCFP, [Optional] float3? DBJGDGDHOMC)
	{
		return default(KDLENLDMBAK);
	}

	[Cpp2IlInjected.Token(Token = "0x600099A")]
	[Cpp2IlInjected.Address(RVA = "0x28D6AF0", Offset = "0x28D5EF0", VA = "0x1828D6AF0", Slot = "12")]
	public KDLENLDMBAK LNLGPDFEDJP(KDLENLDMBAK ANMICKKKMJM, int NANJAGEOPJI, [Optional] float3? OMFIFBMFGMG, [Optional] quaternion? PFHPGOOLCFP, [Optional] float3? DBJGDGDHOMC)
	{
		return default(KDLENLDMBAK);
	}

	[Cpp2IlInjected.Token(Token = "0x600099B")]
	[Cpp2IlInjected.Address(RVA = "0x28D6BA0", Offset = "0x28D5FA0", VA = "0x1828D6BA0")]
	private KDLENLDMBAK LPAGGILLAPB(KDLENLDMBAK ANMICKKKMJM, int NANJAGEOPJI, [Optional] float3? OMFIFBMFGMG, [Optional] quaternion? PFHPGOOLCFP, [Optional] float3? DBJGDGDHOMC)
	{
		return default(KDLENLDMBAK);
	}

	[Cpp2IlInjected.Token(Token = "0x600099C")]
	[Cpp2IlInjected.Address(RVA = "0x28D6650", Offset = "0x28D5A50", VA = "0x1828D6650", Slot = "7")]
	public KDLENLDMBAK GNJNHGDOJCM(KDLENLDMBAK ANMICKKKMJM, int NANJAGEOPJI)
	{
		return default(KDLENLDMBAK);
	}

	[Cpp2IlInjected.Token(Token = "0x600099D")]
	[Cpp2IlInjected.Address(RVA = "0x28D6540", Offset = "0x28D5940", VA = "0x1828D6540", Slot = "16")]
	public void FCMDPBNABDA(KDLENLDMBAK ANMICKKKMJM, KDLENLDMBAK HHGGGAMLHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600099E")]
	[Cpp2IlInjected.Address(RVA = "0x28D7400", Offset = "0x28D6800", VA = "0x1828D7400", Slot = "13")]
	public void PPICEFIMCPJ(KDLENLDMBAK ANMICKKKMJM, int NANJAGEOPJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600099F")]
	[Cpp2IlInjected.Address(RVA = "0x28D6F10", Offset = "0x28D6310", VA = "0x1828D6F10", Slot = "14")]
	public void NGKJKLFHPAN(KDLENLDMBAK ANMICKKKMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A0")]
	[Cpp2IlInjected.Address(RVA = "0x28D63E0", Offset = "0x28D57E0", VA = "0x1828D63E0", Slot = "8")]
	public int BMNEOBLEHMD(KDLENLDMBAK ANMICKKKMJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A1")]
	[Cpp2IlInjected.Address(RVA = "0x28D6980", Offset = "0x28D5D80", VA = "0x1828D6980", Slot = "6")]
	[IteratorStateMachine(typeof(IJCMEIBCFLM))]
	public IEnumerable<KDLENLDMBAK> KBIPLGCLKGL(KDLENLDMBAK ANMICKKKMJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009A2")]
	[Cpp2IlInjected.Address(RVA = "0x28D68A0", Offset = "0x28D5CA0", VA = "0x1828D68A0")]
	private bool JABJLIEFIOA(KDLENLDMBAK ANMICKKKMJM, out NativeArray<Entity> CIHGKBGGPMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A3")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public GJCFDJKIGCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
[AlwaysUpdateSystem]
public class LHPHKELMHKD : JKIEMPJPHGI
{
	[Cpp2IlInjected.Token(Token = "0x60009AC")]
	[Cpp2IlInjected.Address(RVA = "0x2A600D0", Offset = "0x2A5F4D0", VA = "0x182A600D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AD")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public LHPHKELMHKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000192")]
internal class FILAICGOIIM : DPMFBCJDGFB
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	public struct PGDKIJPOCPN : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x4000543")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	protected override ComponentType PDHNPENHMAM
	{
		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0x28CFEF0", Offset = "0x28CF2F0", VA = "0x1828CFEF0", Slot = "15")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	protected override ComponentType IMMDMMODPGD
	{
		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0x28CFF20", Offset = "0x28CF320", VA = "0x1828CFF20", Slot = "16")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	protected override ComponentType IEBBBMGCEFM
	{
		[Cpp2IlInjected.Token(Token = "0x60009B1")]
		[Cpp2IlInjected.Address(RVA = "0x28CFF50", Offset = "0x28CF350", VA = "0x1828CFF50", Slot = "17")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009AE")]
	[Cpp2IlInjected.Address(RVA = "0x28D0010", Offset = "0x28CF410", VA = "0x1828D0010")]
	public FILAICGOIIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
public class KLHCDEHCLFL : JKIEMPJPHGI, CBKELFDIEEL
{
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	private OMKBGDBGLMG LHPBIJEDFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	private BAHKBHMHHLL KCAHGNNGIDP;

	[Cpp2IlInjected.Token(Token = "0x60009B3")]
	[Cpp2IlInjected.Address(RVA = "0x25232B0", Offset = "0x25226B0", VA = "0x1825232B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B4")]
	[Cpp2IlInjected.Address(RVA = "0x2894500", Offset = "0x2893900", VA = "0x182894500", Slot = "14")]
	public void JFCLKDMBJND(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B5")]
	[Cpp2IlInjected.Address(RVA = "0x2894790", Offset = "0x2893B90", VA = "0x182894790", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B6")]
	[Cpp2IlInjected.Address(RVA = "0x2894610", Offset = "0x2893A10", VA = "0x182894610")]
	private static void KBNNNFFBMEB(EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN, Entity ILDFJHMNOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B7")]
	[Cpp2IlInjected.Address(RVA = "0x2894460", Offset = "0x2893860", VA = "0x182894460")]
	private static bool AMHGHJGADGN(EntityManager GLPCEPPDPLB, Entity FKNFFDFGNMN, out Transform FELEGEFPADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009B8")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public KLHCDEHCLFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
public struct LHFHADLJOHO<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	private OAGAALHEKIF<T> HEGEMCIFGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	private EntityCommandBuffer FFLDGNLHFCF;

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public OAGAALHEKIF<T> JDGPAHAMPDO
	{
		[Cpp2IlInjected.Token(Token = "0x60009BA")]
		[Cpp2IlInjected.Address(RVA = "0x16CFAB0", Offset = "0x16CEEB0", VA = "0x1816CFAB0")]
		get
		{
			return default(OAGAALHEKIF<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009BB")]
	[Cpp2IlInjected.Address(RVA = "0x2044740", Offset = "0x2043B40", VA = "0x182044740")]
	public LHFHADLJOHO(OAGAALHEKIF<T> HEGEMCIFGEI, EntityCommandBuffer FFLDGNLHFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009BC")]
	[Cpp2IlInjected.Address(RVA = "0x2043E60", Offset = "0x2043260", VA = "0x182043E60")]
	public void DGHHCPOGPNJ(HDBJHGJLHNF<T> GLKJJBOMPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009BD")]
	[Cpp2IlInjected.Address(RVA = "0x2044270", Offset = "0x2043670", VA = "0x182044270", Slot = "4")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60009BE")]
	[Cpp2IlInjected.Address(RVA = "0x2044720", Offset = "0x2043B20", VA = "0x182044720")]
	public static OAGAALHEKIF<T> PGDDHPNABOB(LHFHADLJOHO<T> GCKJNKPJMJF)
	{
		return default(OAGAALHEKIF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000196")]
public class AEHOCFDGEHI : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	public CJHAGIKCJCL FCGEAJNLBED;

	[Cpp2IlInjected.Token(Token = "0x60009BF")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public AEHOCFDGEHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C0")]
	[Cpp2IlInjected.Address(RVA = "0x7FF090", Offset = "0x7FE490", VA = "0x1807FF090")]
	public AEHOCFDGEHI(CJHAGIKCJCL FCGEAJNLBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C1")]
	[Cpp2IlInjected.Address(RVA = "0x250D240", Offset = "0x250C640", VA = "0x18250D240", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	[ALIINGEKIMD]
	public class PostDeserializeUpgrade_Convert_SerializeEmbodiedData : KOEELCMGFDH
	{
		[Cpp2IlInjected.Token(Token = "0x2000198")]
		[NoAlias]
		[BurstCompile]
		private struct PostDeserializeUpgrade_Convert_SerializeEmbodiedData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400054B")]
			public NFONADLCMPK<CBKOKNFIMAH> v0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400054C")]
			public BHLLODNGMFM<LMAEJBKEBOI> v1;

			[Cpp2IlInjected.Token(Token = "0x60009C9")]
			[Cpp2IlInjected.Address(RVA = "0x3DE8640", Offset = "0x3DE7A40", VA = "0x183DE8640")]
			private void EJBLFCAPFKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009CA")]
			[Cpp2IlInjected.Address(RVA = "0x3DE88A0", Offset = "0x3DE7CA0", VA = "0x183DE88A0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private static readonly PILIJFIMAJF log;

		[Cpp2IlInjected.Token(Token = "0x1700012F")]
		protected override PILIJFIMAJF Log
		{
			[Cpp2IlInjected.Token(Token = "0x60009C2")]
			[Cpp2IlInjected.Address(RVA = "0x223B430", Offset = "0x223A830", VA = "0x18223B430", Slot = "14")]
			get
			{
				return default(PILIJFIMAJF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0x223B0D0", Offset = "0x223A4D0", VA = "0x18223B0D0", Slot = "15")]
		public override IEnumerable<IBKHNFKEFMN.AHKJOPMIMKP> JAONDHGNIEF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0x223B190", Offset = "0x223A590", VA = "0x18223B190", Slot = "16")]
		protected override void KKMHPKEJHOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0x223B300", Offset = "0x223A700", VA = "0x18223B300")]
		private JobHandle LGAAPFLCKMP(NFONADLCMPK<CBKOKNFIMAH> v0, BHLLODNGMFM<LMAEJBKEBOI> v1, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0x2239D50", Offset = "0x2239150", VA = "0x182239D50")]
		public PostDeserializeUpgrade_Convert_SerializeEmbodiedData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
[AlwaysUpdateSystem]
internal class LNBPGFBKOKG : JKIEMPJPHGI
{
	[Cpp2IlInjected.Token(Token = "0x60009CB")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CC")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public LNBPGFBKOKG()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	public class DebugPostLoadValidateParentData : KBODFINGEBH, AKFIPDJCCOH
	{
		[Cpp2IlInjected.Token(Token = "0x200019B")]
		private struct DebugPostLoadValidateParentData_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000550")]
			public DebugPostLoadValidateParentData __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000551")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000552")]
			[ReadOnly]
			public ComponentTypeHandle<ELLKBCJMOKK> __parentDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60009D3")]
			[Cpp2IlInjected.Address(RVA = "0x270B9E0", Offset = "0x270ADE0", VA = "0x18270B9E0")]
			private void EJBLFCAPFKM(Entity entity, in ELLKBCJMOKK parentData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009D4")]
			[Cpp2IlInjected.Address(RVA = "0x270BC40", Offset = "0x270B040", VA = "0x18270BC40", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private AOONNPAOEFB objects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private EntityQuery DebugPostLoadValidateParentData_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private ComponentTypeHandle<ELLKBCJMOKK> __RecRoom_Components_ParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x28C3510", Offset = "0x28C2910", VA = "0x1828C3510", Slot = "14")]
		public void InitReferences(EMFBCBAOENA services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CE")]
		[Cpp2IlInjected.Address(RVA = "0x28C31E0", Offset = "0x28C25E0", VA = "0x1828C31E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CF")]
		[Cpp2IlInjected.Address(RVA = "0x28C31E0", Offset = "0x28C25E0", VA = "0x1828C31E0")]
		private void HPGABBBEBML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D0")]
		[Cpp2IlInjected.Address(RVA = "0x28C3570", Offset = "0x28C2970", VA = "0x1828C3570", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D1")]
		[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
		public DebugPostLoadValidateParentData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D2")]
		[Cpp2IlInjected.Address(RVA = "0x28C32C0", Offset = "0x28C26C0", VA = "0x1828C32C0")]
		[CompilerGenerated]
		private void IIMLKEMKOPO(Entity entity, in ELLKBCJMOKK parentData)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
internal class IELNFMBAEOI : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	private EntityQuery PNGFJEAJDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	private object OMKMIHEBPCM;

	[Cpp2IlInjected.Token(Token = "0x60009D5")]
	[Cpp2IlInjected.Address(RVA = "0x287E300", Offset = "0x287D700", VA = "0x18287E300", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D6")]
	[Cpp2IlInjected.Address(RVA = "0x287E380", Offset = "0x287D780", VA = "0x18287E380", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D7")]
	[Cpp2IlInjected.Address(RVA = "0x287E420", Offset = "0x287D820", VA = "0x18287E420", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D8")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public IELNFMBAEOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
[BurstCompatible]
internal readonly struct BEADJPACJDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	private readonly NABKNKHLMPP FEAMFDCPIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	private readonly JACBBANCLJG PIAMNDKENMK;

	[Cpp2IlInjected.Token(Token = "0x60009D9")]
	[Cpp2IlInjected.Address(RVA = "0xA28DB0", Offset = "0xA281B0", VA = "0x180A28DB0")]
	public BEADJPACJDM(NABKNKHLMPP FEAMFDCPIDJ, JACBBANCLJG PIAMNDKENMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DA")]
	[Cpp2IlInjected.Address(RVA = "0x25129B0", Offset = "0x2511DB0", VA = "0x1825129B0")]
	public bool EMADAFMPEGC(BEADJPACJDM ILDFJHMNOPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009DB")]
	[Cpp2IlInjected.Address(RVA = "0x25129B0", Offset = "0x2511DB0", VA = "0x1825129B0")]
	public bool LPODJJPGFPE(BEADJPACJDM CDFHGECAPKI)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[CompilerGenerated]
	[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
	public class CalculateContainerCollisionIslandGraphChangesSystem : JKIEMPJPHGI, AKFIPDJCCOH
	{
		[Cpp2IlInjected.Token(Token = "0x200019F")]
		[BurstCompile]
		private struct FindChangedIslandsJob : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000560")]
			[ReadOnly]
			public EntityQueryInJob deletedConnectablesQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000561")]
			[ReadOnly]
			public EntityQueryInJob changedIslandQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000562")]
			[ReadOnly]
			public EntityQueryInJob hierarchyChangeQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000563")]
			[ReadOnly]
			public EntityQueryInJob newRootsQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000564")]
			[ReadOnly]
			public ChunkFilterAnyOf2ComponentsChanged islandSplitChangeFilterRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000565")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000566")]
			[ReadOnly]
			public ComponentTypeHandle<NCBDLCCOLLK> islandRootSystemDataTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000567")]
			[ReadOnly]
			public ComponentDataFromEntity<NBMIGEPLFOM> dontPropagatePhysicsPropertiesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000568")]
			[ReadOnly]
			public ComponentDataFromEntity<NABKNKHLMPP> containerCollisionModeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000569")]
			[ReadOnly]
			public ComponentDataFromEntity<JACBBANCLJG> containerCollisionLayerRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400056A")]
			[ReadOnly]
			public ComponentDataFromEntity<LIMNCIOFPGM> containerCollisionIslandRootTagRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400056B")]
			[ReadOnly]
			public ComponentDataFromEntity<ELLKBCJMOKK> parentRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x400056C")]
			[ReadOnly]
			public BufferFromEntity<OOENBAEOKLI> childrenRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x400056D")]
			[WriteOnly]
			public NativeList<Entity> changedIslandComponentsBufferWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x400056E")]
			[WriteOnly]
			public NativeList<GNJBMJAPDOO> changedIslandRootsWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x400056F")]
			[WriteOnly]
			public NativeList<Entity> removedIslandRootsWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x4000570")]
			[WriteOnly]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x4000571")]
			public ComponentDataFromEntity<JLGOPHNCNPJ> collisionIslandRootDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
			[Cpp2IlInjected.Token(Token = "0x4000572")]
			public NativeParallelHashSet<Entity> visitedRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
			[Cpp2IlInjected.Token(Token = "0x4000573")]
			private int bufferHead;

			[Cpp2IlInjected.Token(Token = "0x60009E4")]
			[Cpp2IlInjected.Address(RVA = "0x270E080", Offset = "0x270D480", VA = "0x18270E080", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009E5")]
			[Cpp2IlInjected.Address(RVA = "0x270DEC0", Offset = "0x270D2C0", VA = "0x18270DEC0")]
			private void BFFMOHEBFHC(Entity startEntity, bool checkForUnchanged)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009E6")]
			[Cpp2IlInjected.Address(RVA = "0x270E790", Offset = "0x270DB90", VA = "0x18270E790")]
			private Entity GKEPPFBENNJ(Entity curEntity, BEADJPACJDM classifier)
			{
				return default(Entity);
			}

			[Cpp2IlInjected.Token(Token = "0x60009E7")]
			[Cpp2IlInjected.Address(RVA = "0x270DDF0", Offset = "0x270D1F0", VA = "0x18270DDF0")]
			private bool AMCKPGGADJH(Entity curEntity, BEADJPACJDM classifier, out Entity parentEntity, out BEADJPACJDM parentClassifier)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60009E8")]
			[Cpp2IlInjected.Address(RVA = "0x270E980", Offset = "0x270DD80", VA = "0x18270E980")]
			private void JOBJABFAHGI(Entity islandRoot, BEADJPACJDM classifier)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009E9")]
			[Cpp2IlInjected.Address(RVA = "0x270EA50", Offset = "0x270DE50", VA = "0x18270EA50")]
			private void LGOFMPDPMCA(Entity islandRoot, Entity entity, BEADJPACJDM classifier)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009EA")]
			[Cpp2IlInjected.Address(RVA = "0x270E8A0", Offset = "0x270DCA0", VA = "0x18270E8A0")]
			private void HGOANPBCLFB(Entity islandRoot, Entity component)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009EB")]
			[Cpp2IlInjected.Address(RVA = "0x270E810", Offset = "0x270DC10", VA = "0x18270E810")]
			private bool HGMHBBHOKGI(Entity entity, out BEADJPACJDM classifier)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60009EC")]
			[Cpp2IlInjected.Address(RVA = "0x270E6F0", Offset = "0x270DAF0", VA = "0x18270E6F0")]
			private BEADJPACJDM FADBMAAFAAM(Entity entity)
			{
				return default(BEADJPACJDM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001A0")]
		[NoAlias]
		[BurstCompile]
		private struct CalculateContainerCollisionIslandGraphChangesSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000574")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000575")]
			public NativeList<Entity> removedIslandRootsWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000576")]
			[ReadOnly]
			public EntityTypeHandle entityType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000577")]
			public EntityQueryInJob queryInJob;

			[Cpp2IlInjected.Token(Token = "0x60009ED")]
			[Cpp2IlInjected.Address(RVA = "0x27098A0", Offset = "0x2708CA0", VA = "0x1827098A0")]
			private void EJBLFCAPFKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009EE")]
			[Cpp2IlInjected.Address(RVA = "0x2709990", Offset = "0x2708D90", VA = "0x182709990", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		[ONGFANECMJO]
		private GIAAALCEHCB collisionIslandService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		private EntityQuery changedIslandStructureQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private EntityQuery hierarchyChangeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private EntityQuery newRootsQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private EntityQuery deletedConnectablesQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		private EntityQuery deletedRootsQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private EntityQuery islandRootDataQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		private EntityQuery islandRootTagQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private KGMJBKCABEM ecbs;

		[Cpp2IlInjected.Token(Token = "0x60009DC")]
		[Cpp2IlInjected.Address(RVA = "0x251F250", Offset = "0x251E650", VA = "0x18251F250", Slot = "14")]
		public void InitReferences(EMFBCBAOENA services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DD")]
		[Cpp2IlInjected.Address(RVA = "0x251FB00", Offset = "0x251EF00", VA = "0x18251FB00", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DE")]
		[Cpp2IlInjected.Address(RVA = "0x251FF10", Offset = "0x251F310", VA = "0x18251FF10", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DF")]
		[Cpp2IlInjected.Address(RVA = "0x251F3A0", Offset = "0x251E7A0", VA = "0x18251F3A0")]
		private JobHandle LFDDOMLLFNC(JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009E0")]
		[Cpp2IlInjected.Address(RVA = "0x251EF90", Offset = "0x251E390", VA = "0x18251EF90")]
		private JobHandle ABJDAILNADJ(JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009E1")]
		[Cpp2IlInjected.Address(RVA = "0x251F2A0", Offset = "0x251E6A0", VA = "0x18251F2A0")]
		private JobHandle KADNICCJEGK(EntityCommandBuffer ecb, NativeList<Entity> removedIslandRootsWO, EntityTypeHandle entityType, EntityQueryInJob queryInJob, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009E2")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E3")]
		[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
		public CalculateContainerCollisionIslandGraphChangesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
[EBCKCHNKEDI]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
public class KLBBNIBPECO : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x4000578")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000579")]
	private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> PIIMOHCEKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400057A")]
	private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> NCIBEBFDLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400057B")]
	private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> HOAOLKAOHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400057C")]
	private DPDGJLIFKMC NHCJIPNFMGB;

	[Cpp2IlInjected.Token(Token = "0x60009EF")]
	[Cpp2IlInjected.Address(RVA = "0x2893380", Offset = "0x2892780", VA = "0x182893380", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0x2893D80", Offset = "0x2893180", VA = "0x182893D80", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0x2893B30", Offset = "0x2892F30", VA = "0x182893B30")]
	private void OJHAKNMOJBD(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> OCCNFAKIALD, EntityQueryDesc OJKACCBEPFN, bool HCHEOFCJLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0x2893C40", Offset = "0x2893040", VA = "0x182893C40")]
	private void OJHAKNMOJBD(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> OCCNFAKIALD, EntityQueryDesc OJKACCBEPFN, bool HCHEOFCJLMB, bool CPDGHJJAFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0x2893FE0", Offset = "0x28933E0", VA = "0x182893FE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F4")]
	[Cpp2IlInjected.Address(RVA = "0x28931D0", Offset = "0x28925D0", VA = "0x1828931D0")]
	private void IKBHHOGFNFL(EntityQuery PNGFJEAJDGO, bool DJIKKGNDPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F5")]
	[Cpp2IlInjected.Address(RVA = "0x2892E70", Offset = "0x2892270", VA = "0x182892E70")]
	private void BLJOMLCNGOJ(EntityQuery PNGFJEAJDGO, bool ILPBJPMPILL, bool DJIKKGNDPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F6")]
	[Cpp2IlInjected.Address(RVA = "0x2893630", Offset = "0x2892A30", VA = "0x182893630")]
	private void LMNKMOJFDNP(NativeArray<Entity> PGJLMFPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F7")]
	[Cpp2IlInjected.Address(RVA = "0x2893060", Offset = "0x2892460", VA = "0x182893060")]
	private void GHPGMKJLABF(NativeList<Entity> PGJLMFPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F8")]
	[Cpp2IlInjected.Address(RVA = "0x2893A10", Offset = "0x2892E10", VA = "0x182893A10")]
	private void NOKFFLPNBPE(NativeArray<Entity> PGJLMFPAKDA, bool ILPBJPMPILL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F9")]
	[Cpp2IlInjected.Address(RVA = "0x28933D0", Offset = "0x28927D0", VA = "0x1828933D0")]
	private NativeList<Entity> JOAENAIODJL(NativeArray<Entity> PGJLMFPAKDA)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60009FA")]
	[Cpp2IlInjected.Address(RVA = "0x2893020", Offset = "0x2892420", VA = "0x182893020")]
	private NativeList<Entity> FHJOHDONLKJ(NativeArray<Entity> PGJLMFPAKDA)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60009FB")]
	[Cpp2IlInjected.Address(RVA = "0x28935F0", Offset = "0x28929F0", VA = "0x1828935F0")]
	private NativeList<Entity> LAGMBCFGDHH(NativeArray<Entity> PGJLMFPAKDA)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60009FC")]
	[Cpp2IlInjected.Address(RVA = "0x2893850", Offset = "0x2892C50", VA = "0x182893850")]
	private NativeList<Entity> NDNEBNCAGFM(NativeArray<Entity> PGJLMFPAKDA, bool JLGNDDKEKIB)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60009FD")]
	[Cpp2IlInjected.Address(RVA = "0x2894390", Offset = "0x2893790", VA = "0x182894390")]
	public KLBBNIBPECO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
internal class AMAFAHAAMOF : OPIOBIJBFDM
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	protected override GBICPCJAFPO OLPAAHHJIKN
	{
		[Cpp2IlInjected.Token(Token = "0x60009FF")]
		[Cpp2IlInjected.Address(RVA = "0x250F020", Offset = "0x250E420", VA = "0x18250F020", Slot = "15")]
		get
		{
			return default(GBICPCJAFPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A00")]
	[Cpp2IlInjected.Address(RVA = "0x250C880", Offset = "0x250BC80", VA = "0x18250C880")]
	public AMAFAHAAMOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
[UpdateBefore(typeof(MNJBGKKJLIK))]
public class JEODGNIFNMP : JKIEMPJPHGI
{
	[Cpp2IlInjected.Token(Token = "0x400057D")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400057E")]
	private EntityQuery PNGFJEAJDGO;

	[Cpp2IlInjected.Token(Token = "0x6000A01")]
	[Cpp2IlInjected.Address(RVA = "0x288A350", Offset = "0x2889750", VA = "0x18288A350", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A02")]
	[Cpp2IlInjected.Address(RVA = "0x288A3F0", Offset = "0x28897F0", VA = "0x18288A3F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A03")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public JEODGNIFNMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
public class FKKCMGKPJDE : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[BurstCompile]
	private struct EDFDOIMLLCB : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		[ReadOnly]
		public ComponentDataFromEntity<KPMOMMGMLCH> KMOJMCOHDKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		[ReadOnly]
		public NativeArray<Entity> PGJLMFPAKDA;

		[Cpp2IlInjected.Token(Token = "0x6000A0D")]
		[Cpp2IlInjected.Address(RVA = "0x270C3E0", Offset = "0x270B7E0", VA = "0x18270C3E0", Slot = "4")]
		public void Execute(int NANJAGEOPJI, TransformAccess FELEGEFPADK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	[BurstCompile]
	private struct PKCEOGDFOLE : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		[ReadOnly]
		public ComponentDataFromEntity<ANCGJKBPAIA> HLGPNAJNAKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		[ReadOnly]
		public NativeArray<Entity> PGJLMFPAKDA;

		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x2716540", Offset = "0x2715940", VA = "0x182716540", Slot = "4")]
		public void Execute(int NANJAGEOPJI, TransformAccess FELEGEFPADK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[BurstCompile]
	private struct FOOGOPMPFMO : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		[ReadOnly]
		public ComponentDataFromEntity<ANCGJKBPAIA> HLGPNAJNAKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		[ReadOnly]
		public ComponentDataFromEntity<OGGOJLEGOPG> HPFGJBANLHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		[ReadOnly]
		public NativeArray<Entity> PGJLMFPAKDA;

		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0x270DCF0", Offset = "0x270D0F0", VA = "0x18270DCF0", Slot = "4")]
		public void Execute(int NANJAGEOPJI, TransformAccess FELEGEFPADK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400057F")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.Token(Token = "0x4000580")]
	private static readonly PILIJFIMAJF OEDJBCFCBEB;

	[Cpp2IlInjected.Token(Token = "0x4000581")]
	private static readonly PILIJFIMAJF GIBDPCLMCEI;

	[Cpp2IlInjected.Token(Token = "0x4000582")]
	private static readonly PILIJFIMAJF EFEIHLPGPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000583")]
	private NPDFHBHBCOI ENIGIEHDNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000584")]
	private EntityQuery MHFKMLPMKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000585")]
	private EntityQuery HAAIPLGGPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000586")]
	private EntityQuery GILHJECPMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000587")]
	private TransformAccessArray LCKADPHLMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000588")]
	private TransformAccessArray MNMOBMOJDIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000589")]
	private TransformAccessArray FCPFCJKOMGB;

	[Cpp2IlInjected.Token(Token = "0x6000A05")]
	[Cpp2IlInjected.Address(RVA = "0x28D0230", Offset = "0x28CF630", VA = "0x1828D0230", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A06")]
	[Cpp2IlInjected.Address(RVA = "0x28D0280", Offset = "0x28CF680", VA = "0x1828D0280", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A07")]
	[Cpp2IlInjected.Address(RVA = "0x28D0470", Offset = "0x28CF870", VA = "0x1828D0470", Slot = "6")]
	protected override void OnStartRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A08")]
	[Cpp2IlInjected.Address(RVA = "0x28D0500", Offset = "0x28CF900", VA = "0x1828D0500", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A09")]
	[Cpp2IlInjected.Address(RVA = "0x28D0530", Offset = "0x28CF930", VA = "0x1828D0530", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0A")]
	[Cpp2IlInjected.Address(RVA = "0x28D0090", Offset = "0x28CF490", VA = "0x1828D0090")]
	private NativeArray<Entity> DPINDBJGELE(NativeArray<JHOHCLIGMLG> NLMDNELOIKN, NativeList<Entity> OCPHAAPMGNM, TransformAccessArray IBBEFPABLDI, TransformAccessArray DGJDCOPHPBD)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0B")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public FKKCMGKPJDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
internal sealed class ELBDBMEBODI : HLOJAODEAAM
{
	[Cpp2IlInjected.Token(Token = "0x6000A10")]
	[Cpp2IlInjected.Address(RVA = "0x28C8C70", Offset = "0x28C8070", VA = "0x1828C8C70", Slot = "15")]
	protected override ComponentSystemBase BHJHPJOJPMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A11")]
	[Cpp2IlInjected.Address(RVA = "0x2229A50", Offset = "0x2228E50", VA = "0x182229A50")]
	public ELBDBMEBODI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
[EFDJEPLIMOC(typeof(GCNJIPMMPBN), new string[] { })]
internal sealed class GCNJIPMMPBN : AKFIPDJCCOH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000591")]
	private static readonly PILIJFIMAJF CDOGPFJLJNP;

	[Cpp2IlInjected.Token(Token = "0x4000592")]
	private static readonly PILIJFIMAJF JJCGEPPJNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000593")]
	[ONGFANECMJO]
	private PFJMBDHJHAN BDLCNPMEDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000594")]
	private GGBAMIOCDFC<LFFHABKPMBP, Entity> PABHLNMNKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000595")]
	private DFOLNBFBKAD<FNKECKEFKKB> KFFBACOMFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000596")]
	private DFOLNBFBKAD<IMEBJPCKOHK> EDHMKMPBJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000597")]
	private DFOLNBFBKAD<ELEDFEOOPFD> NPCHLMMACMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000598")]
	private DFOLNBFBKAD<OHMJHNOHEHH> HCKMDBBLMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000599")]
	private DFOLNBFBKAD<OKOIFDEOMEB> EGEBFNBKGKB;

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public LKNDCGPKKAH<Entity> GIMJAFHJBBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000A12")]
		[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public MAJNHENMBOI MNFNMGPBHCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000A13")]
		[Cpp2IlInjected.Address(RVA = "0x7E8120", Offset = "0x7E7520", VA = "0x1807E8120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public MAJNHENMBOI CDNOKCBKKOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000A14")]
		[Cpp2IlInjected.Address(RVA = "0x7F2BB0", Offset = "0x7F1FB0", VA = "0x1807F2BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public MAJNHENMBOI PNNMPMGEFGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000A15")]
		[Cpp2IlInjected.Address(RVA = "0x8BC350", Offset = "0x8BB750", VA = "0x1808BC350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public MAJNHENMBOI NFOMMPFCEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000A16")]
		[Cpp2IlInjected.Address(RVA = "0x94BE70", Offset = "0x94B270", VA = "0x18094BE70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public MAJNHENMBOI MEMJLMGLALF
	{
		[Cpp2IlInjected.Token(Token = "0x6000A17")]
		[Cpp2IlInjected.Address(RVA = "0x8C2FB0", Offset = "0x8C23B0", VA = "0x1808C2FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private EntityManager FCLKPLIBOOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000A18")]
		[Cpp2IlInjected.Address(RVA = "0x28D5130", Offset = "0x28D4530", VA = "0x1828D5130")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A19")]
	[Cpp2IlInjected.Address(RVA = "0x28D4F00", Offset = "0x28D4300", VA = "0x1828D4F00", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1A")]
	[Cpp2IlInjected.Address(RVA = "0x28D4E10", Offset = "0x28D4210", VA = "0x1828D4E10", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1B")]
	[Cpp2IlInjected.Address(RVA = "0x19700C0", Offset = "0x196F4C0", VA = "0x1819700C0")]
	private void BFCHCMHGCOO<T>(ref DFOLNBFBKAD<T> AODIHFFJMKM, EntityCommandBufferSystem DCLHOGPFELA, PILIJFIMAJF FDJKGAAPBBG) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1C")]
	[Cpp2IlInjected.Address(RVA = "0x1970170", Offset = "0x196F570", VA = "0x181970170")]
	private void BFCHCMHGCOO<TC, TV>(ref GGBAMIOCDFC<TC, TV> AODIHFFJMKM) where TC : struct, KFABDBNJOME
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1D")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public GCNJIPMMPBN()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001AA")]
public struct IMEBJPCKOHK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001AB")]
public struct FNKECKEFKKB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001AC")]
public struct ELEDFEOOPFD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001AD")]
public struct OHMJHNOHEHH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001AE")]
public struct OKOIFDEOMEB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20001AF")]
[ExecuteAlways]
public class IJGELGMIDPC : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000A1F")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AF0", Offset = "0x7F0EF0", VA = "0x1807F1AF0")]
	public IJGELGMIDPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
internal readonly struct PDKCPOCMDOL
{
	[Cpp2IlInjected.Token(Token = "0x20001B1")]
	[CompilerGenerated]
	private sealed class AFHDHNPGELE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public JKIEMPJPHGI system;

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public AFHDHNPGELE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0x3DE5890", Offset = "0x3DE4C90", VA = "0x183DE5890")]
		internal (EntityQuery, ComponentType) AEDLAEGMGHJ((ComponentType userTag, ComponentType stateTag, ComponentType componentTag) t)
		{
			return default((EntityQuery, ComponentType));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400059A")]
	private static readonly ProfilerMarker EFGOHNJJAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059B")]
	private readonly JKIEMPJPHGI JJBAHIPIPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400059C")]
	private readonly (EntityQuery userTagQuery, ComponentType stateTag)[] KLIKBMNLOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400059D")]
	private readonly EntityQuery KPOMHBJJENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400059E")]
	private readonly EntityQuery LHOHEDPKELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400059F")]
	private readonly ComponentTypes LCPCNGPPNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40005A0")]
	private readonly ComponentTypes BONMONGENJA;

	[Cpp2IlInjected.Token(Token = "0x6000A20")]
	[Cpp2IlInjected.Address(RVA = "0x222ECF0", Offset = "0x222E0F0", VA = "0x18222ECF0")]
	public PDKCPOCMDOL(JKIEMPJPHGI JJBAHIPIPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A21")]
	[Cpp2IlInjected.Address(RVA = "0x222EA30", Offset = "0x222DE30", VA = "0x18222EA30")]
	public void COCGDBGCNKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
public class IPGHACBCJCI : ICBEHEHALDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000A29")]
	[Cpp2IlInjected.Address(RVA = "0x2887330", Offset = "0x2886730", VA = "0x182887330", Slot = "14")]
	protected override EntityCommandBufferSystem KMBJDEEDCKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2A")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public IPGHACBCJCI()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001B4")]
	[EBCKCHNKEDI]
	[CompilerGenerated]
	public class DebugPostDeserializeRemoveOrphanedSplinePoints : KBODFINGEBH
	{
		[Cpp2IlInjected.Token(Token = "0x20001B5")]
		[BurstCompile]
		[NoAlias]
		private struct DebugPostDeserializeRemoveOrphanedSplinePoints_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005A8")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40005A9")]
			[ReadOnly]
			public ComponentDataFromEntity<JFIGADANBCE> splineDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005AA")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40005AB")]
			[ReadOnly]
			public ComponentTypeHandle<OCGHCEBJNGN> __pointTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000A31")]
			[Cpp2IlInjected.Address(RVA = "0x270B680", Offset = "0x270AA80", VA = "0x18270B680")]
			private void EJBLFCAPFKM(Entity entity, [NoAlias] in OCGHCEBJNGN point)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A32")]
			[Cpp2IlInjected.Address(RVA = "0x270B6F0", Offset = "0x270AAF0", VA = "0x18270B6F0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private EntityQuery DebugPostDeserializeRemoveOrphanedSplinePoints_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private ComponentTypeHandle<OCGHCEBJNGN> __RecRoom_Components_SplinePointParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000A2B")]
		[Cpp2IlInjected.Address(RVA = "0x28C2B20", Offset = "0x28C1F20", VA = "0x1828C2B20", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2C")]
		[Cpp2IlInjected.Address(RVA = "0x28C26F0", Offset = "0x28C1AF0", VA = "0x1828C26F0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void FECDJHLKJOC(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2D")]
		[Cpp2IlInjected.Address(RVA = "0x28C28D0", Offset = "0x28C1CD0", VA = "0x1828C28D0")]
		private EntityCommandBufferSystem KMBJDEEDCKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2E")]
		[Cpp2IlInjected.Address(RVA = "0x28C2790", Offset = "0x28C1B90", VA = "0x1828C2790")]
		private JobHandle HMBMNKOKIDB(EntityCommandBuffer ecb, ComponentDataFromEntity<JFIGADANBCE> splineDataRO, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2F")]
		[Cpp2IlInjected.Address(RVA = "0x28C2920", Offset = "0x28C1D20", VA = "0x1828C2920", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
		public DebugPostDeserializeRemoveOrphanedSplinePoints()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
public struct HDBJHGJLHNF<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005AC")]
	[ReadOnly]
	public EntityQueryInJob PNGFJEAJDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005AD")]
	[ReadOnly]
	public EntityTypeHandle INCJCNJPPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005AE")]
	[ReadOnly]
	public ComponentTypeHandle<T> GBBIBJIKFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005AF")]
	[WriteOnly]
	public EntityCommandBuffer FFLDGNLHFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005B0")]
	public AllocatorManager.AllocatorHandle GMMIODGPFPJ;

	[Cpp2IlInjected.Token(Token = "0x6000A33")]
	[Cpp2IlInjected.Address(RVA = "0x20293E0", Offset = "0x20287E0", VA = "0x1820293E0")]
	public OAGAALHEKIF<T> JOELDEHDNMM()
	{
		return default(OAGAALHEKIF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B7")]
public static class MAPFBNKIOOH
{
	[Cpp2IlInjected.Token(Token = "0x20001B8")]
	[BurstCompile]
	private struct DJGPNNPDFOP : IJob, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		[ReadOnly]
		public NativeParallelHashSet<int> EHNLDALIPEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		[ReadOnly]
		public NativeArray<ArchetypeChunk> NKDLKMCJIGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public NativeList<EntityArchetype> CNBKEOKPHCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public NativeList<NDLCDGPEBGB> PFHLHLNEEEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public NativeList<NDLCDGPEBGB> EKDLCPMGLMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public NativeList<ComponentType> LIKJNBFMFBB;

		[Cpp2IlInjected.Token(Token = "0x6000A3D")]
		[Cpp2IlInjected.Address(RVA = "0x2709DF0", Offset = "0x27091F0", VA = "0x182709DF0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3E")]
		[Cpp2IlInjected.Address(RVA = "0x2709D60", Offset = "0x2709160", VA = "0x182709D60", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A34")]
	[Cpp2IlInjected.Address(RVA = "0x2A645C0", Offset = "0x2A639C0", VA = "0x182A645C0")]
	public static NativeParallelHashSet<int> GDOIJEFEJOE(Allocator GMMIODGPFPJ)
	{
		return default(NativeParallelHashSet<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A35")]
	[Cpp2IlInjected.Address(RVA = "0x2A63E30", Offset = "0x2A63230", VA = "0x182A63E30")]
	public static NativeParallelHashSet<int> AEBNEOFKOAK(Allocator GMMIODGPFPJ)
	{
		return default(NativeParallelHashSet<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A36")]
	[Cpp2IlInjected.Address(RVA = "0x2A65020", Offset = "0x2A64420", VA = "0x182A65020")]
	private static void NMJLDEKLDNA(NativeParallelHashSet<int> HNFFJIBONPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A37")]
	[Cpp2IlInjected.Address(RVA = "0x2A646A0", Offset = "0x2A63AA0", VA = "0x182A646A0")]
	private static bool KPENAKBBFMH(Type JLNNFEOBAMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A38")]
	[Cpp2IlInjected.Address(RVA = "0x2A63F90", Offset = "0x2A63390", VA = "0x182A63F90")]
	private static void EABFPLCAOJI(NativeParallelHashSet<int> HNFFJIBONPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A39")]
	[Cpp2IlInjected.Address(RVA = "0x2A64120", Offset = "0x2A63520", VA = "0x182A64120")]
	private static void ECHPDHNOLJO(NativeParallelHashSet<int> HNFFJIBONPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3A")]
	[Cpp2IlInjected.Address(RVA = "0x2A64430", Offset = "0x2A63830", VA = "0x182A64430")]
	private static void FMKCCLLGCHE(NativeParallelHashSet<int> HNFFJIBONPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0x2A64790", Offset = "0x2A63B90", VA = "0x182A64790")]
	public static void LDGBGBJPGEH(EntityManager GLPCEPPDPLB, EntityQuery PNGFJEAJDGO, NativeParallelHashSet<int> BAPIEJOJHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3C")]
	[Cpp2IlInjected.Address(RVA = "0x2A642B0", Offset = "0x2A636B0", VA = "0x182A642B0")]
	public static void FJOMFFFPFFD(EntityManager GLPCEPPDPLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B9")]
public class MFFFFIOJAMG : ParentSystemBase<ELLKBCJMOKK, LGGMOLOMIMK, OOENBAEOKLI>
{
	[Cpp2IlInjected.Token(Token = "0x6000A3F")]
	[Cpp2IlInjected.Address(RVA = "0x2A65EC0", Offset = "0x2A652C0", VA = "0x182A65EC0", Slot = "14")]
	protected override EntityQueryDesc MNBFCFJEKII(EntityQueryDesc PNGFJEAJDGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A40")]
	[Cpp2IlInjected.Address(RVA = "0x93C3C0", Offset = "0x93B7C0", VA = "0x18093C3C0", Slot = "15")]
	protected override EntityQueryDesc GGJAABHGMHI(EntityQueryDesc PNGFJEAJDGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A41")]
	[Cpp2IlInjected.Address(RVA = "0x2A65F00", Offset = "0x2A65300", VA = "0x182A65F00", Slot = "16")]
	protected override EntityQueryDesc OEIDGIHNLKF(EntityQueryDesc PNGFJEAJDGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A42")]
	[Cpp2IlInjected.Address(RVA = "0x2A65E80", Offset = "0x2A65280", VA = "0x182A65E80", Slot = "17")]
	protected override EntityQueryDesc HDGEMLFEPJG(EntityQueryDesc PNGFJEAJDGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A43")]
	[Cpp2IlInjected.Address(RVA = "0x2A65F40", Offset = "0x2A65340", VA = "0x182A65F40")]
	public MFFFFIOJAMG()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001BA")]
	public abstract class ParentSystemBase<TParentData, TPreviousParentData, TChildrenData> : JKIEMPJPHGI where TParentData : struct, IComponentData, GDGEAAKNBIK where TPreviousParentData : struct, IComponentData, GDGEAAKNBIK where TChildrenData : struct, ISystemStateBufferElementData, IEquatable<TChildrenData>, GDGEAAKNBIK
	{
		[Cpp2IlInjected.Token(Token = "0x20001BB")]
		[BurstCompile]
		internal struct KCFFIIELLCL : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005BF")]
			public NativeParallelMultiHashMap<Entity, Entity>.ParallelWriter ICBGMIKMACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C0")]
			public NativeParallelMultiHashMap<Entity, Entity>.ParallelWriter HMHAGHIGGHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C1")]
			public NativeParallelHashMap<Entity, int>.ParallelWriter HLONKBOBENN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C2")]
			public ComponentTypeHandle<TPreviousParentData> JOAKLKGHBED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C3")]
			[ReadOnly]
			public ComponentTypeHandle<TParentData> HDJEFGEJPHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C4")]
			[ReadOnly]
			public EntityTypeHandle LKNHJLJNOKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C5")]
			public uint COFHBFKJOIM;

			[Cpp2IlInjected.Token(Token = "0x6000A52")]
			[Cpp2IlInjected.Address(RVA = "0x210A470", Offset = "0x2109870", VA = "0x18210A470", Slot = "4")]
			public void Execute(ArchetypeChunk NCPBFICMLEP, int ENBIMODBIAK, int HHILCJGIMIC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001BC")]
		[BurstCompile]
		internal struct LMEGNFNGJKD : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C6")]
			[ReadOnly]
			public NativeParallelHashMap<Entity, int> HLONKBOBENN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C7")]
			[ReadOnly]
			public BufferFromEntity<TChildrenData> DNAFKJDKBLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C8")]
			public NativeList<Entity> OPDBKAPEAHJ;

			[Cpp2IlInjected.Token(Token = "0x6000A53")]
			[Cpp2IlInjected.Address(RVA = "0x3FEF760", Offset = "0x3FEEB60", VA = "0x183FEF760", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001BD")]
		[BurstCompile]
		internal struct OGILBMIEIGH : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C9")]
			[ReadOnly]
			public NativeParallelMultiHashMap<Entity, Entity> ICBGMIKMACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CA")]
			[ReadOnly]
			public NativeParallelMultiHashMap<Entity, Entity> HMHAGHIGGHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CB")]
			[ReadOnly]
			public NativeParallelHashMap<Entity, int> HLONKBOBENN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CC")]
			public BufferFromEntity<TChildrenData> DNAFKJDKBLH;

			[Cpp2IlInjected.Token(Token = "0x6000A54")]
			[Cpp2IlInjected.Address(RVA = "0x2F37820", Offset = "0x2F36C20", VA = "0x182F37820")]
			private int DALMIMCFNMD(DynamicBuffer<TChildrenData> CIHGKBGGPMF, Entity FKNFFDFGNMN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A55")]
			[Cpp2IlInjected.Address(RVA = "0x2F37560", Offset = "0x2F36960", VA = "0x182F37560")]
			private void BMGMBJCKOFO(Entity ILDFJHMNOPJ, DynamicBuffer<TChildrenData> CIHGKBGGPMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A56")]
			[Cpp2IlInjected.Address(RVA = "0x2F37C80", Offset = "0x2F37080", VA = "0x182F37C80")]
			private void LALBAPDANJF(Entity ILDFJHMNOPJ, DynamicBuffer<TChildrenData> CIHGKBGGPMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A57")]
			[Cpp2IlInjected.Address(RVA = "0x2F379A0", Offset = "0x2F36DA0", VA = "0x182F379A0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001BE")]
		[BurstCompile]
		private struct DKFLPFLEINC : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CD")]
			[ReadOnly]
			public NativeArray<Entity> MHBJBOAHKPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CE")]
			public NativeList<Entity> MNIKMGFJGLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CF")]
			[ReadOnly]
			public BufferFromEntity<TChildrenData> DNAFKJDKBLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005D0")]
			[ReadOnly]
			public ComponentDataFromEntity<TParentData> GMNEICHBJOJ;

			[Cpp2IlInjected.Token(Token = "0x6000A58")]
			[Cpp2IlInjected.Address(RVA = "0x24F1440", Offset = "0x24F0840", VA = "0x1824F1440", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		protected EntityQuery JHMFOFBOFKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		protected EntityQuery GFHPBCCEDEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		protected EntityQuery LIPOBJBCKPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		protected EntityQuery HNKEBLKFOBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		protected ProfilerMarker CLOBMKBGFAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		protected ProfilerMarker FIIOFONMBIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		protected ProfilerMarker JMCELAOOMMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		protected ProfilerMarker GAKPHGEBFEB;

		[Cpp2IlInjected.Token(Token = "0x6000A44")]
		[Cpp2IlInjected.Address(RVA = "0x229B1E0", Offset = "0x229A5E0", VA = "0x18229B1E0")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A45")]
		[Cpp2IlInjected.Address(RVA = "0x2298CF0", Offset = "0x22980F0", VA = "0x182298CF0")]
		private int DALMIMCFNMD(DynamicBuffer<TChildrenData> CIHGKBGGPMF, Entity FKNFFDFGNMN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A46")]
		[Cpp2IlInjected.Address(RVA = "0x2299D10", Offset = "0x2299110", VA = "0x182299D10")]
		private void GNCFHEMNAGJ(Entity GDMBBNAAAPH, Entity LBBGPDLKAGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A47")]
		[Cpp2IlInjected.Address(RVA = "0x93C3C0", Offset = "0x93B7C0", VA = "0x18093C3C0", Slot = "14")]
		protected virtual EntityQueryDesc MNBFCFJEKII(EntityQueryDesc PNGFJEAJDGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A48")]
		[Cpp2IlInjected.Address(RVA = "0x93C3C0", Offset = "0x93B7C0", VA = "0x18093C3C0", Slot = "15")]
		protected virtual EntityQueryDesc GGJAABHGMHI(EntityQueryDesc PNGFJEAJDGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A49")]
		[Cpp2IlInjected.Address(RVA = "0x93C3C0", Offset = "0x93B7C0", VA = "0x18093C3C0", Slot = "16")]
		protected virtual EntityQueryDesc OEIDGIHNLKF(EntityQueryDesc PNGFJEAJDGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc HDGEMLFEPJG(EntityQueryDesc PNGFJEAJDGO);

		[Cpp2IlInjected.Token(Token = "0x6000A4B")]
		[Cpp2IlInjected.Address(RVA = "0x229A9F0", Offset = "0x2299DF0", VA = "0x18229A9F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4C")]
		[Cpp2IlInjected.Address(RVA = "0x2299360", Offset = "0x2298760", VA = "0x182299360")]
		private void EENEEOECFAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4D")]
		[Cpp2IlInjected.Address(RVA = "0x2298ED0", Offset = "0x22982D0", VA = "0x182298ED0")]
		private void ECOGGLKHKEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4E")]
		[Cpp2IlInjected.Address(RVA = "0x229A430", Offset = "0x2299830", VA = "0x18229A430")]
		private JobHandle LDKNACGKMHN(JobHandle OMGHOAKHCEK)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4F")]
		[Cpp2IlInjected.Address(RVA = "0x22997F0", Offset = "0x2298BF0", VA = "0x1822997F0")]
		private void EFGNLKAHDBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A50")]
		[Cpp2IlInjected.Address(RVA = "0x229AFB0", Offset = "0x229A3B0", VA = "0x18229AFB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A51")]
		[Cpp2IlInjected.Address(RVA = "0x1F662C0", Offset = "0x1F656C0", VA = "0x181F662C0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BF")]
public class OMPKENFGCJN : GKFFCAOGGHG
{
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	protected override EFNMGKCCGPP EIOENNCKBJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000A59")]
		[Cpp2IlInjected.Address(RVA = "0x7F35A0", Offset = "0x7F29A0", VA = "0x1807F35A0", Slot = "15")]
		get
		{
			return default(EFNMGKCCGPP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0x222A3D0", Offset = "0x22297D0", VA = "0x18222A3D0", Slot = "16")]
	protected override void GFCCJNMOBMN(EFNMGKCCGPP HEGEMCIFGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5B")]
	[Cpp2IlInjected.Address(RVA = "0x222A6A0", Offset = "0x2229AA0", VA = "0x18222A6A0")]
	private EntityCommandBufferSystem KMBJDEEDCKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5C")]
	[Cpp2IlInjected.Address(RVA = "0x222A780", Offset = "0x2229B80", VA = "0x18222A780")]
	public OMPKENFGCJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C0")]
[EBCKCHNKEDI]
public class LHBKMEBGEJE : KBODFINGEBH
{
	[Cpp2IlInjected.Token(Token = "0x20001C1")]
	private struct JBNIFOCDGBA : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		[ReadOnly]
		public NativeParallelHashSet<int> BOCJBDCJMMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		[ReadOnly]
		public EntityTypeHandle AKCDCICFDKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		[ReadOnly]
		public SharedComponentTypeHandle<RRObjectPrefabV2Data> LCINFIDGECM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public NativeList<Entity>.ParallelWriter EAEHJOEJALJ;

		[Cpp2IlInjected.Token(Token = "0x6000A63")]
		[Cpp2IlInjected.Address(RVA = "0x2711640", Offset = "0x2710A40", VA = "0x182711640", Slot = "4")]
		public void Execute(ArchetypeChunk NCPBFICMLEP, int ENBIMODBIAK, int HHILCJGIMIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40005D2")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005D3")]
	private EntityQuery PNGFJEAJDGO;

	[Cpp2IlInjected.Token(Token = "0x6000A5E")]
	[Cpp2IlInjected.Address(RVA = "0x2A5F790", Offset = "0x2A5EB90", VA = "0x182A5F790", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x2A5F820", Offset = "0x2A5EC20", VA = "0x182A5F820", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A60")]
	[Cpp2IlInjected.Address(RVA = "0x2A5F740", Offset = "0x2A5EB40", VA = "0x182A5F740")]
	private EntityCommandBufferSystem KMBJDEEDCKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A61")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public LHBKMEBGEJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C2")]
public struct EDOBMHDMGJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D8")]
	public Entity FKNFFDFGNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D9")]
	public GIOFAADFPJL LCEOCHLKMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40005DA")]
	public GIOFAADFPJL OIKAFLDALHD;
}
[Cpp2IlInjected.Token(Token = "0x20001C3")]
[EFDJEPLIMOC(typeof(NPDFHBHBCOI), new string[] { })]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
internal sealed class NPDFHBHBCOI : DEPDOFHIDBA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005DB")]
	private NNDEHNEEJEM MKNMKJMIAAH;

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public NNDEHNEEJEM KHHLCFAJKHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000A64")]
		[Cpp2IlInjected.Address(RVA = "0x26A1FA0", Offset = "0x26A13A0", VA = "0x1826A1FA0")]
		get
		{
			return default(NNDEHNEEJEM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A65")]
	[Cpp2IlInjected.Address(RVA = "0x2A73910", Offset = "0x2A72D10", VA = "0x182A73910", Slot = "4")]
	public void MCOOCEGHCPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A66")]
	[Cpp2IlInjected.Address(RVA = "0x2A73900", Offset = "0x2A72D00", VA = "0x182A73900", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A67")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public NPDFHBHBCOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C4")]
internal sealed class IMEHLOBFJLG : ParentSystemBase<ELLKBCJMOKK, LGGMOLOMIMK, OOENBAEOKLI>
{
	[Cpp2IlInjected.Token(Token = "0x6000A68")]
	[Cpp2IlInjected.Address(RVA = "0x93C3C0", Offset = "0x93B7C0", VA = "0x18093C3C0", Slot = "14")]
	protected override EntityQueryDesc MNBFCFJEKII(EntityQueryDesc PNGFJEAJDGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A69")]
	[Cpp2IlInjected.Address(RVA = "0x93C3C0", Offset = "0x93B7C0", VA = "0x18093C3C0", Slot = "15")]
	protected override EntityQueryDesc GGJAABHGMHI(EntityQueryDesc PNGFJEAJDGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6A")]
	[Cpp2IlInjected.Address(RVA = "0x93C3C0", Offset = "0x93B7C0", VA = "0x18093C3C0", Slot = "16")]
	protected override EntityQueryDesc OEIDGIHNLKF(EntityQueryDesc PNGFJEAJDGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6B")]
	[Cpp2IlInjected.Address(RVA = "0x2886C90", Offset = "0x2886090", VA = "0x182886C90", Slot = "17")]
	protected override EntityQueryDesc HDGEMLFEPJG(EntityQueryDesc PNGFJEAJDGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6C")]
	[Cpp2IlInjected.Address(RVA = "0x2886CD0", Offset = "0x28860D0", VA = "0x182886CD0")]
	public IMEHLOBFJLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C5")]
[EFDJEPLIMOC(typeof(EEFGHGFDIPG), new string[] { })]
internal class INKPPLKCKIC : EEFGHGFDIPG, AKFIPDJCCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	[ONGFANECMJO]
	private HGCCGCKMNPO KOKLPBCLJKP;

	[Cpp2IlInjected.Token(Token = "0x6000A6D")]
	[Cpp2IlInjected.Address(RVA = "0x2886EE0", Offset = "0x28862E0", VA = "0x182886EE0", Slot = "8")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6E")]
	[Cpp2IlInjected.Address(RVA = "0x2886FD0", Offset = "0x28863D0", VA = "0x182886FD0", Slot = "4")]
	public World NMGDIIEPECH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6F")]
	[Cpp2IlInjected.Address(RVA = "0x2886D10", Offset = "0x2886110", VA = "0x182886D10", Slot = "5")]
	public World HNFNCHJDNHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A70")]
	[Cpp2IlInjected.Address(RVA = "0x2886F30", Offset = "0x2886330", VA = "0x182886F30", Slot = "6")]
	public World NMDNBCKPEDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A71")]
	[Cpp2IlInjected.Address(RVA = "0x2886DB0", Offset = "0x28861B0", VA = "0x182886DB0", Slot = "7")]
	public World IADBJHLEJLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A72")]
	[Cpp2IlInjected.Address(RVA = "0x2886E50", Offset = "0x2886250", VA = "0x182886E50")]
	private World IDGBKCEHIIK(string DKPHPKDPBCM, AHCAMFMAIIJ NNGHEIFAPDC, Type FDBFLEKEOAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A73")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public INKPPLKCKIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C6")]
public enum GCGDNGNDAMG
{
	[Cpp2IlInjected.Token(Token = "0x40005DE")]
	Main,
	[Cpp2IlInjected.Token(Token = "0x40005DF")]
	NetworkReceive,
	[Cpp2IlInjected.Token(Token = "0x40005E0")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x40005E1")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20001C7")]
internal class MIJEHGMPAMD : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005E2")]
	private EntityQuery PNGFJEAJDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005E3")]
	private object OMKMIHEBPCM;

	[Cpp2IlInjected.Token(Token = "0x6000A74")]
	[Cpp2IlInjected.Address(RVA = "0x2A66690", Offset = "0x2A65A90", VA = "0x182A66690", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A75")]
	[Cpp2IlInjected.Address(RVA = "0x2A66710", Offset = "0x2A65B10", VA = "0x182A66710", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A76")]
	[Cpp2IlInjected.Address(RVA = "0x2A667B0", Offset = "0x2A65BB0", VA = "0x182A667B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A77")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public MIJEHGMPAMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C8")]
internal class KAAMANBAJKM : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	private KBLGMDKDIMA FBCPJLHEMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005E6")]
	private EntityQuery HPLAIPIMJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005E7")]
	private EntityQuery NAMHFKMNICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40005E8")]
	private NLLKOIOEBHH JJBMHHKCDGP;

	[Cpp2IlInjected.Token(Token = "0x6000A78")]
	[Cpp2IlInjected.Address(RVA = "0x2890FE0", Offset = "0x28903E0", VA = "0x182890FE0", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A79")]
	[Cpp2IlInjected.Address(RVA = "0x2891160", Offset = "0x2890560", VA = "0x182891160", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7A")]
	[Cpp2IlInjected.Address(RVA = "0x2891270", Offset = "0x2890670", VA = "0x182891270", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7B")]
	[Cpp2IlInjected.Address(RVA = "0x2891050", Offset = "0x2890450", VA = "0x182891050")]
	private void OBKMOPBDFPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7C")]
	[Cpp2IlInjected.Address(RVA = "0x2890D30", Offset = "0x2890130", VA = "0x182890D30")]
	private void DELPLLBODFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7D")]
	[Cpp2IlInjected.Address(RVA = "0x2890910", Offset = "0x288FD10", VA = "0x182890910")]
	private void ALPHMFILLHE(NativeArray<Entity> PGJLMFPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7E")]
	[Cpp2IlInjected.Address(RVA = "0x2890EA0", Offset = "0x28902A0", VA = "0x182890EA0")]
	private void DFFCAFBCACB(NativeArray<Entity> PGJLMFPAKDA, int HOLCJNDBEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7F")]
	[Cpp2IlInjected.Address(RVA = "0x2890C20", Offset = "0x2890020", VA = "0x182890C20")]
	private void CHHKGGCEHEI(NativeArray<Entity> PGJLMFPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A80")]
	[Cpp2IlInjected.Address(RVA = "0x28908B0", Offset = "0x288FCB0", VA = "0x1828908B0")]
	private void AFFGOCODHCK(Entity FKNFFDFGNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A81")]
	[Cpp2IlInjected.Address(RVA = "0x8C6B70", Offset = "0x8C5F70", VA = "0x1808C6B70")]
	private static void EHCPLPNMDFI(int ELEHMFAPFEI, Transform FELEGEFPADK, Entity FKNFFDFGNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A82")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public KAAMANBAJKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C9")]
internal static class MCJGHJAAIBC
{
	[Cpp2IlInjected.Token(Token = "0x6000A84")]
	[Cpp2IlInjected.Address(RVA = "0x2A65310", Offset = "0x2A64710", VA = "0x182A65310")]
	public static bool HNPHGGJJEAD(this SystemBase JJBAHIPIPHK, out Entity FKNFFDFGNMN)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001CA")]
	[CompilerGenerated]
	[HONNCCIFPDK(CAGOEBHGGNL.OMRoom)]
	public class PostLoadRemapCircuitIds : JKIEMPJPHGI, AKFIPDJCCOH
	{
		[Cpp2IlInjected.Token(Token = "0x20001CB")]
		private struct PostLoadRemapCircuitIds_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005EC")]
			public NPKIHKJLIJM remap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005ED")]
			public ComponentTypeHandle<ILOMABJPLIM> __nodeTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000A8B")]
			[Cpp2IlInjected.Address(RVA = "0x3DE93B0", Offset = "0x3DE87B0", VA = "0x183DE93B0")]
			private void EJBLFCAPFKM(ref ILOMABJPLIM node)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A8C")]
			[Cpp2IlInjected.Address(RVA = "0x3DE95F0", Offset = "0x3DE89F0", VA = "0x183DE95F0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		[ONGFANECMJO]
		private LPMPALGCIEF serialization;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		private EntityQuery PostLoadRemapCircuitIds_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		private ComponentTypeHandle<ILOMABJPLIM> __RecRoom_Components_ObjectBoardNodeData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000A85")]
		[Cpp2IlInjected.Address(RVA = "0x223E5C0", Offset = "0x223D9C0", VA = "0x18223E5C0", Slot = "14")]
		public void InitReferences(EMFBCBAOENA services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A86")]
		[Cpp2IlInjected.Address(RVA = "0x223E840", Offset = "0x223DC40", VA = "0x18223E840", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A87")]
		[Cpp2IlInjected.Address(RVA = "0x223E3E0", Offset = "0x223D7E0", VA = "0x18223E3E0")]
		private void CIFNCPIOELK(NPKIHKJLIJM remap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A88")]
		[Cpp2IlInjected.Address(RVA = "0x223E4D0", Offset = "0x223D8D0", VA = "0x18223E4D0")]
		private void DCEOBIDMCGA(ref NPKIHKJLIJM remap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A89")]
		[Cpp2IlInjected.Address(RVA = "0x223E610", Offset = "0x223DA10", VA = "0x18223E610", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8A")]
		[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
		public PostLoadRemapCircuitIds()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CC")]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
internal class FLDDPCLDNCP : JKIEMPJPHGI, AKFIPDJCCOH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40005EE")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.Token(Token = "0x40005EF")]
	private static readonly PILIJFIMAJF MKECCMKDHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005F0")]
	[ONGFANECMJO]
	private CJNHILKEKFP IMMGGKGMOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	[ONGFANECMJO]
	private AOONNPAOEFB FHJACJEANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	[ONGFANECMJO]
	private MGGIKJGDIFI PALNDCFDCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005F3")]
	[ONGFANECMJO]
	private EHFICGMFONF HKOCODKCJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40005F4")]
	[ONGFANECMJO]
	private CDGICEOEFLL FEANHDDFDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40005F5")]
	[ONGFANECMJO]
	private KNMAOLNPOGJ KIKIIAMJNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40005F6")]
	private OOCAJGPOFDB.PGACPGAILCB NJEFCCGKLBG;

	[Cpp2IlInjected.Token(Token = "0x6000A8D")]
	[Cpp2IlInjected.Address(RVA = "0x28D22D0", Offset = "0x28D16D0", VA = "0x1828D22D0", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8E")]
	[Cpp2IlInjected.Address(RVA = "0x28D1190", Offset = "0x28D0590", VA = "0x1828D1190", Slot = "15")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8F")]
	[Cpp2IlInjected.Address(RVA = "0x28D2E50", Offset = "0x28D2250", VA = "0x1828D2E50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A90")]
	[Cpp2IlInjected.Address(RVA = "0x28D29E0", Offset = "0x28D1DE0", VA = "0x1828D29E0")]
	private void NAFHHDCMIAN(EBBOOPFABOA KOFPKIJDAMC, NativeArray<byte> ECBDFHKIBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A91")]
	[Cpp2IlInjected.Address(RVA = "0x28D2480", Offset = "0x28D1880", VA = "0x1828D2480")]
	private bool JONPENEHCAO(EBBOOPFABOA KOFPKIJDAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A92")]
	[Cpp2IlInjected.Address(RVA = "0x28D1EF0", Offset = "0x28D12F0", VA = "0x1828D1EF0")]
	private OOCAJGPOFDB.JBNPJDKPNAO GOPFGMBEHNK(NativeArray<byte> ECBDFHKIBMG, Allocator GMMIODGPFPJ)
	{
		return default(OOCAJGPOFDB.JBNPJDKPNAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A93")]
	[Cpp2IlInjected.Address(RVA = "0x28D10A0", Offset = "0x28D04A0", VA = "0x1828D10A0")]
	private void BIJDMGPCPAN(OOCAJGPOFDB.JBNPJDKPNAO LMLGDLIKOIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A94")]
	[Cpp2IlInjected.Address(RVA = "0x28D18D0", Offset = "0x28D0CD0", VA = "0x1828D18D0")]
	private void EIKENGKMJNM(NativeList<CMFFIMLEPBE> LMKFIAKIJAP, NativeList<EFFOMHNHCBO> JONOBDJBMLJ, Allocator GMMIODGPFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A95")]
	[Cpp2IlInjected.Address(RVA = "0x28D24E0", Offset = "0x28D18E0", VA = "0x1828D24E0")]
	private void LEOKJAGPKCD(NativeParallelMultiHashMap<CMFFIMLEPBE, GPPEENBHCHN> GJEBDFEMJIE, NativeList<byte> GBCDFJOMAAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A96")]
	[Cpp2IlInjected.Address(RVA = "0x28D2070", Offset = "0x28D1470", VA = "0x1828D2070")]
	private void IAKMCCEKNBF(NativeList<CMFFIMLEPBE> KNDKMEFEGCC, Allocator GMMIODGPFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A97")]
	[Cpp2IlInjected.Address(RVA = "0x28D1AC0", Offset = "0x28D0EC0", VA = "0x1828D1AC0")]
	private void FEEDCKMDHJM(OOCAJGPOFDB.JBNPJDKPNAO KJFNAECAHBA, bool PADNBMCBCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A98")]
	[Cpp2IlInjected.Address(RVA = "0x28D0F20", Offset = "0x28D0320", VA = "0x1828D0F20")]
	private void BFHCJFCPPCJ(NativeList<CMFFIMLEPBE> LMKFIAKIJAP, NativeList<EFFOMHNHCBO> JONOBDJBMLJ, bool PADNBMCBCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A99")]
	[Cpp2IlInjected.Address(RVA = "0x28D1230", Offset = "0x28D0630", VA = "0x1828D1230")]
	private void EHIEPLAHDMD(NativeParallelMultiHashMap<CMFFIMLEPBE, GPPEENBHCHN> GJEBDFEMJIE, NativeList<byte> GBCDFJOMAAA, bool PADNBMCBCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9A")]
	[Cpp2IlInjected.Address(RVA = "0x28D1DE0", Offset = "0x28D11E0", VA = "0x1828D1DE0")]
	private void GIGBPKKKDIH(NativeList<CMFFIMLEPBE> KNDKMEFEGCC, bool PADNBMCBCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9B")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	private static void KIFKMGGILLH(EBBOOPFABOA KOFPKIJDAMC, bool PADNBMCBCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9C")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public FLDDPCLDNCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CD")]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
internal sealed class OLNAJFNHAJA : HLOJAODEAAM
{
	[Cpp2IlInjected.Token(Token = "0x6000A9E")]
	[Cpp2IlInjected.Address(RVA = "0x2229770", Offset = "0x2228B70", VA = "0x182229770", Slot = "15")]
	protected override ComponentSystemBase BHJHPJOJPMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9F")]
	[Cpp2IlInjected.Address(RVA = "0x2229A50", Offset = "0x2228E50", VA = "0x182229A50")]
	public OLNAJFNHAJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CE")]
[JOCOBGMDOKK(CAGOEBHGGNL.LoadInstance)]
internal interface JDLBPHHOKOP
{
	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	NativeParallelMultiHashMap<Entity, ELGEKKCACLJ> BDFIIMPIGJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000AA0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	uint COFHBFKJOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000AA1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KOEECEDEBCJ(NativeArray<CMFFIMLEPBE> LMKFIAKIJAP, NativeArray<EFFOMHNHCBO> JONOBDJBMLJ, NativeArray<CMFFIMLEPBE> KNDKMEFEGCC, int OOKKPFFACCG);

	[Cpp2IlInjected.Token(Token = "0x6000AA3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FBGAAAJGBPB(in KAKBNCDEGLG ODHKPLOJGGM);

	[Cpp2IlInjected.Token(Token = "0x6000AA4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MNJPBKNOHBH(JobHandle PPCGBBAKOHO);
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001CF")]
	[CompilerGenerated]
	[AlwaysUpdateSystem]
	[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
	public class CalculateCollisionIslandUpdatesSystem : JKIEMPJPHGI, AKFIPDJCCOH
	{
		[Cpp2IlInjected.Token(Token = "0x20001D0")]
		[BurstCompile]
		[NoAlias]
		private struct CalculateCollisionIslandUpdatesSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005FD")]
			public NativeList<Entity> rootsWithForcedCollisionUpdate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005FE")]
			public NativeList<Entity> rootsWithoutForcedCollisionUpdate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005FF")]
			[ReadOnly]
			public ComponentTypeHandle<JLGOPHNCNPJ> collisionIslandRootDataHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000600")]
			[ReadOnly]
			public ComponentDataFromEntity<JLGOPHNCNPJ> collisionIslandRootDataFromEntityRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000601")]
			[ReadOnly]
			public ComponentTypeHandle<OCGHCEBJNGN> splineParentHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000602")]
			public EntityQueryInJob changedLocalPoseQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000603")]
			public EntityQueryInJob changedSplinePointsQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000604")]
			public EntityQueryInJob splinesWithChangedChildrenQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000605")]
			public EntityQueryInJob changedCollisionModeQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000606")]
			public EntityQueryInJob changedScopeRootQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000607")]
			public Allocator allocator;

			[Cpp2IlInjected.Token(Token = "0x6000AAB")]
			[Cpp2IlInjected.Address(RVA = "0x2709090", Offset = "0x2708490", VA = "0x182709090")]
			private void EJBLFCAPFKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AAC")]
			[Cpp2IlInjected.Address(RVA = "0x2709890", Offset = "0x2708C90", VA = "0x182709890", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		private EntityQuery changedLocalPoseQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		private EntityQuery changedSplinePointsQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		private EntityQuery splinesWithChangedChildrenQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		private EntityQuery changedCollisionModeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private EntityQuery scopeRootChangeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private GIAAALCEHCB collisionIslandService;

		[Cpp2IlInjected.Token(Token = "0x6000AA5")]
		[Cpp2IlInjected.Address(RVA = "0x251E3F0", Offset = "0x251D7F0", VA = "0x18251E3F0", Slot = "14")]
		public void InitReferences(EMFBCBAOENA services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA6")]
		[Cpp2IlInjected.Address(RVA = "0x251E5F0", Offset = "0x251D9F0", VA = "0x18251E5F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA7")]
		[Cpp2IlInjected.Address(RVA = "0x251E950", Offset = "0x251DD50", VA = "0x18251E950", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA8")]
		[Cpp2IlInjected.Address(RVA = "0x251E440", Offset = "0x251D840", VA = "0x18251E440")]
		private JobHandle NILEFGNAOBH(NativeList<Entity> rootsWithForcedCollisionUpdate, NativeList<Entity> rootsWithoutForcedCollisionUpdate, ComponentTypeHandle<JLGOPHNCNPJ> collisionIslandRootDataHandleRO, ComponentDataFromEntity<JLGOPHNCNPJ> collisionIslandRootDataFromEntityRO, ComponentTypeHandle<OCGHCEBJNGN> splineParentHandleRO, EntityQueryInJob changedLocalPoseQueryInJob, EntityQueryInJob changedSplinePointsQueryInJob, EntityQueryInJob splinesWithChangedChildrenQueryInJob, EntityQueryInJob changedCollisionModeQueryInJob, EntityQueryInJob changedScopeRootQueryInJob, Allocator allocator, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA9")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAA")]
		[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
		public CalculateCollisionIslandUpdatesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D1")]
[EBCKCHNKEDI]
public class BNDBLICEKKI : KBODFINGEBH
{
	[Cpp2IlInjected.Token(Token = "0x4000608")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000609")]
	private EntityQuery PNGFJEAJDGO;

	[Cpp2IlInjected.Token(Token = "0x6000AAD")]
	[Cpp2IlInjected.Address(RVA = "0x2514D00", Offset = "0x2514100", VA = "0x182514D00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAE")]
	[Cpp2IlInjected.Address(RVA = "0x2514D90", Offset = "0x2514190", VA = "0x182514D90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAF")]
	[Cpp2IlInjected.Address(RVA = "0x2514CB0", Offset = "0x25140B0", VA = "0x182514CB0")]
	private EntityCommandBufferSystem KMBJDEEDCKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB0")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public BNDBLICEKKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D2")]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
public class MIFNPFNAABE : JKIEMPJPHGI
{
	[Cpp2IlInjected.Token(Token = "0x20001D3")]
	[BurstCompile]
	private struct FGAMJBEFIKP : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		[ReadOnly]
		public int PPHHFAANMED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		[ReadOnly]
		public EntityQueryInJob OANAIBJANCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		[ReadOnly]
		public EntityQueryInJob EAJIFFKICDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		[ReadOnly]
		public ChunkFilterAnyOf3ComponentsChanged PKICGBPHKAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		[ReadOnly]
		public EntityTypeHandle AKCDCICFDKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		[ReadOnly]
		public ComponentDataFromEntity<JBOOJPNGIGM> APIEILJHEBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		[ReadOnly]
		public ComponentDataFromEntity<NEPPICPDJAN> IGHCCGKBJDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> AIPIJLAPCDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		[ReadOnly]
		public ComponentTypeHandle<OCGHCEBJNGN> MANIBHGCGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		[ReadOnly]
		public ComponentDataFromEntity<NGCCGHIFCBM> JEHKNIADNCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		[ReadOnly]
		public ComponentDataFromEntity<DIAHLMCFEAG> BCOCIOIPFOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		[WriteOnly]
		public ComponentDataFromEntity<LOKNJKCACCH> OBBHKDKHOJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		[WriteOnly]
		public ComponentDataFromEntity<EPPAOJFMIIL> KPNBNINJPBP;

		[Cpp2IlInjected.Token(Token = "0x6000AB6")]
		[Cpp2IlInjected.Address(RVA = "0x270CEA0", Offset = "0x270C2A0", VA = "0x18270CEA0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB7")]
		[Cpp2IlInjected.Address(RVA = "0x270D040", Offset = "0x270C440", VA = "0x18270D040")]
		private void IMEFODOAEGN(NativeList<Entity> HPFCJJKFEJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB8")]
		[Cpp2IlInjected.Address(RVA = "0x270D550", Offset = "0x270C950", VA = "0x18270D550")]
		private void KKKAOPGKFOE(Entity BMBJJEDFMKB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400060A")]
	private EntityQuery DBAPAHPDPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400060B")]
	private EntityQuery JLKJNLMAPAF;

	[Cpp2IlInjected.Token(Token = "0x6000AB2")]
	[Cpp2IlInjected.Address(RVA = "0x2A660D0", Offset = "0x2A654D0", VA = "0x182A660D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB3")]
	[Cpp2IlInjected.Address(RVA = "0x2A66270", Offset = "0x2A65670", VA = "0x182A66270", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB4")]
	[Cpp2IlInjected.Address(RVA = "0x24AAB20", Offset = "0x24A9F20", VA = "0x1824AAB20")]
	private bool NGKCNIJNPNN<T>(T FALBMJBGLPG, out int BPENNMMEEMB) where T : struct, IChunkChangeFilter
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB5")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public MIFNPFNAABE()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001D4")]
	[CompilerGenerated]
	public class DebugPostLoadValidateNetworkId : KBODFINGEBH, AKFIPDJCCOH
	{
		[Cpp2IlInjected.Token(Token = "0x20001D5")]
		private struct DebugPostLoadValidateNetworkId_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400061C")]
			public NativeParallelHashMap<CMFFIMLEPBE, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400061D")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400061E")]
			[ReadOnly]
			public ComponentTypeHandle<PCCFEGNEHCE> __networkComponentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000ABE")]
			[Cpp2IlInjected.Address(RVA = "0x270B810", Offset = "0x270AC10", VA = "0x18270B810")]
			private void EJBLFCAPFKM(Entity entity, in PCCFEGNEHCE networkComponent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000ABF")]
			[Cpp2IlInjected.Address(RVA = "0x270B8C0", Offset = "0x270ACC0", VA = "0x18270B8C0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		private CIEAPPOCDCN networkToLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		private EntityQuery DebugPostLoadValidateNetworkId_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		private ComponentTypeHandle<PCCFEGNEHCE> __RecRoom_Components_ObjectNetworkIdComponentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000AB9")]
		[Cpp2IlInjected.Address(RVA = "0x28C2E60", Offset = "0x28C2260", VA = "0x1828C2E60", Slot = "14")]
		public void InitReferences(EMFBCBAOENA services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABA")]
		[Cpp2IlInjected.Address(RVA = "0x28C30F0", Offset = "0x28C24F0", VA = "0x1828C30F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABB")]
		[Cpp2IlInjected.Address(RVA = "0x28C2D70", Offset = "0x28C2170", VA = "0x1828C2D70")]
		private void GMNPHGJJCAG(ref NativeParallelHashMap<CMFFIMLEPBE, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABC")]
		[Cpp2IlInjected.Address(RVA = "0x28C2EC0", Offset = "0x28C22C0", VA = "0x1828C2EC0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
		public DebugPostLoadValidateNetworkId()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D6")]
public readonly struct GIJIABNLIPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400061F")]
	private readonly int EPAJCDGEEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000620")]
	private readonly int MLGAFKBKMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000621")]
	private readonly NDLCDGPEBGB PJNDNKMLPNK;

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public NDLCDGPEBGB KJJLEAAOCEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC1")]
		[Cpp2IlInjected.Address(RVA = "0xA9C2D0", Offset = "0xA9B6D0", VA = "0x180A9C2D0")]
		get
		{
			return default(NDLCDGPEBGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC0")]
	[Cpp2IlInjected.Address(RVA = "0x28D63D0", Offset = "0x28D57D0", VA = "0x1828D63D0")]
	public GIJIABNLIPB(int EPAJCDGEEKI, int MLGAFKBKMCE, NDLCDGPEBGB PJNDNKMLPNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D7")]
[InternalBufferCapacity(1)]
internal struct OIOMMJOPPHE : ISystemStateBufferElementData, IBufferElementData, IEquatable<OIOMMJOPPHE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000622")]
	public BHFODDCOKNF PPCGBBAKOHO;

	[Cpp2IlInjected.Token(Token = "0x6000AC2")]
	[Cpp2IlInjected.Address(RVA = "0x2A7A0F0", Offset = "0x2A794F0", VA = "0x182A7A0F0", Slot = "4")]
	public bool Equals(OIOMMJOPPHE LNOOAJJNCAE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000AC3")]
	[Cpp2IlInjected.Address(RVA = "0x9BB570", Offset = "0x9BA970", VA = "0x1809BB570")]
	public static OIOMMJOPPHE PGDDHPNABOB(BHFODDCOKNF PPCGBBAKOHO)
	{
		return default(OIOMMJOPPHE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D8")]
[EFDJEPLIMOC(typeof(CBFLHDPJONH), new string[] { })]
public sealed class OOHENPOGDBO : CBFLHDPJONH, AKFIPDJCCOH
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x20001D9")]
	private struct FECCGMDABFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public float PIHOECLOCCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public uint ENOMIPCIFIK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000623")]
	[ONGFANECMJO]
	private AOONNPAOEFB FHJACJEANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000624")]
	[ONGFANECMJO]
	private CINMFIJPFIM INNGMMKJPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000625")]
	[ONGFANECMJO]
	private IJNHJLKNADD KBPDIKHOINO;

	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x222CD80", Offset = "0x222C180", VA = "0x18222CD80", Slot = "5")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC5")]
	[Cpp2IlInjected.Address(RVA = "0x222CE10", Offset = "0x222C210", VA = "0x18222CE10")]
	public bool LJCJBGODPCK(in float3 OCPINBDMADB, in float3 KDLMOBCGODE, float AMDMMLBNHAH, out BMJAGFBFJOH LGKDBFIOHEG, out KDLENLDMBAK BMBJJEDFMKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC6")]
	[Cpp2IlInjected.Address(RVA = "0x222CCA0", Offset = "0x222C0A0", VA = "0x18222CCA0")]
	public static bool CHCIPCJCGIC(in Span<BMJAGFBFJOH> OEHDNAHPCPB, float AMDMMLBNHAH, out int NANJAGEOPJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC7")]
	[Cpp2IlInjected.Address(RVA = "0x222D2F0", Offset = "0x222C6F0", VA = "0x18222D2F0")]
	public static float MFFHGBDFKGH(float PIHOECLOCCD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC8")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public OOHENPOGDBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC9")]
	[Cpp2IlInjected.Address(RVA = "0x222D320", Offset = "0x222C720", VA = "0x18222D320", Slot = "4")]
	private bool NBNDFIEPHGP(in float3 OCPINBDMADB, in float3 KDLMOBCGODE, float AMDMMLBNHAH, out BMJAGFBFJOH LGKDBFIOHEG, out KDLENLDMBAK BMBJJEDFMKB)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001DA")]
internal struct AJNPGAIGMCD : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20001DB")]
public class FMHGLEAKEIM : JKIEMPJPHGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000628")]
	private EntityQuery PNGFJEAJDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000629")]
	private EntityQuery PGNDKIAOKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400062A")]
	private ComponentTypes HGHPGIPKPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400062B")]
	private NativeParallelHashSet<int> BAPIEJOJHNA;

	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0x28D32A0", Offset = "0x28D26A0", VA = "0x1828D32A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACB")]
	[Cpp2IlInjected.Address(RVA = "0x28D3670", Offset = "0x28D2A70", VA = "0x1828D3670", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACC")]
	[Cpp2IlInjected.Address(RVA = "0x28D36F0", Offset = "0x28D2AF0", VA = "0x1828D36F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0x28D3200", Offset = "0x28D2600", VA = "0x1828D3200")]
	public JobHandle ODGDBICIBDJ(JobHandle OMGHOAKHCEK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACE")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public FMHGLEAKEIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DD")]
public class OIPHFJBCAIF : JKIEMPJPHGI
{
	[Cpp2IlInjected.Token(Token = "0x20001DE")]
	[BurstCompile]
	private struct BNAKPDIKOMB : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		[ReadOnly]
		public ComponentTypeHandle<COEOEGLCBOG> CJBEGBCKEPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public ComponentTypeHandle<BOIDEJCAFGI> CCFJAGMBHND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public uint COFHBFKJOIM;

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0x3DE5A40", Offset = "0x3DE4E40", VA = "0x183DE5A40", Slot = "4")]
		public void Execute(ArchetypeChunk NCPBFICMLEP, int NANJAGEOPJI, int OACOHOELHFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0x3DE59B0", Offset = "0x3DE4DB0", VA = "0x183DE59B0")]
		public bool BEBJJPJJHPD(ArchetypeChunk NCPBFICMLEP)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400062F")]
	private EntityQuery NEBAMFAPADK;

	[Cpp2IlInjected.Token(Token = "0x6000AD3")]
	[Cpp2IlInjected.Address(RVA = "0x2229280", Offset = "0x2228680", VA = "0x182229280", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD4")]
	[Cpp2IlInjected.Address(RVA = "0x22293B0", Offset = "0x22287B0", VA = "0x1822293B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD5")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public OIPHFJBCAIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DF")]
[ExecuteAlways]
public class KGMJBKCABEM : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000AD8")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AF0", Offset = "0x7F0EF0", VA = "0x1807F1AF0")]
	public KGMJBKCABEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E0")]
public struct NFONADLCMPK<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000633")]
	private HDBJHGJLHNF<T> HEGEMCIFGEI;

	[Cpp2IlInjected.Token(Token = "0x6000AD9")]
	[Cpp2IlInjected.Address(RVA = "0x24CA7C0", Offset = "0x24C9BC0", VA = "0x1824CA7C0")]
	public NFONADLCMPK(HDBJHGJLHNF<T> HEGEMCIFGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADA")]
	[Cpp2IlInjected.Address(RVA = "0x27C9A70", Offset = "0x27C8E70", VA = "0x1827C9A70")]
	public LHFHADLJOHO<T> NFINBPNIKPN()
	{
		return default(LHFHADLJOHO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E1")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
[EFDJEPLIMOC(typeof(GJPHNBBCJCP), new string[] { })]
public class GJPHNBBCJCP : AKFIPDJCCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000634")]
	[ONGFANECMJO]
	private PFJMBDHJHAN GKACEDOEIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000635")]
	[ONGFANECMJO]
	private ANLJAEDMKMC KLBBCPHGEPH;

	[Cpp2IlInjected.Token(Token = "0x6000ADB")]
	[Cpp2IlInjected.Address(RVA = "0x28D77B0", Offset = "0x28D6BB0", VA = "0x1828D77B0", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADC")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public GJPHNBBCJCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E2")]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
internal class PGEDCALEJCO : JHKLBCGALML<GHLNMFNBDJO>
{
	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0x222F710", Offset = "0x222EB10", VA = "0x18222F710", Slot = "14")]
	protected override void BFMPNCEOKAI(NativeArray<Entity> PGJLMFPAKDA, NativeArray<Entity> ACIJPDFENHE, NativeArray<Entity> EIEGKDOGOIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x222F860", Offset = "0x222EC60", VA = "0x18222F860")]
	private static void BFMPNCEOKAI(NativeArray<Entity> PGJLMFPAKDA, NativeArray<Entity> EIEGKDOGOIO, ComponentDataFromEntity<global::JKKDNEMHJFM> ADJNEPMIPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0x222F930", Offset = "0x222ED30", VA = "0x18222F930")]
	public PGEDCALEJCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E3")]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
internal sealed class EKDHAPJACPP : HLOJAODEAAM
{
	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0x28C8AA0", Offset = "0x28C7EA0", VA = "0x1828C8AA0", Slot = "15")]
	protected override ComponentSystemBase BHJHPJOJPMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE1")]
	[Cpp2IlInjected.Address(RVA = "0x2229A50", Offset = "0x2228E50", VA = "0x182229A50")]
	public EKDHAPJACPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E4")]
public abstract class MJNLCLLFKPH : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000636")]
	private DNMGNPMNFDI EGEBFNBKGKB;

	[Cpp2IlInjected.Token(Token = "0x6000AE2")]
	[Cpp2IlInjected.Address(RVA = "0x2A66F20", Offset = "0x2A66320", VA = "0x182A66F20", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0x2A66F80", Offset = "0x2A66380", VA = "0x182A66F80", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0x2A66FB0", Offset = "0x2A663B0", VA = "0x182A66FB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE5")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	protected MJNLCLLFKPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E5")]
public static class BEGFHAAHNNI
{
	[Cpp2IlInjected.Token(Token = "0x4000637")]
	public static readonly (ComponentType userTag, ComponentType stateTag, ComponentType componentTag)[] JHEFDACPGDF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001E6")]
internal struct MMGJJCICLNB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001E7")]
internal struct FGBBHJHPLGI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20001E8")]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
public class LGDGBKNMNOF : KBODFINGEBH
{
	[Cpp2IlInjected.Token(Token = "0x4000638")]
	private static PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000639")]
	private EntityQuery OBBFOGHLBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400063A")]
	private EntityQuery DAHELKPMOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400063B")]
	private EntityQuery OBBBKGJMNFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400063C")]
	private EntityQuery JBBBLBNMNMA;

	[Cpp2IlInjected.Token(Token = "0x6000AE7")]
	[Cpp2IlInjected.Address(RVA = "0x2A5F2B0", Offset = "0x2A5E6B0", VA = "0x182A5F2B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE8")]
	[Cpp2IlInjected.Address(RVA = "0x2A5F470", Offset = "0x2A5E870", VA = "0x182A5F470", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE9")]
	[Cpp2IlInjected.Address(RVA = "0x2A5F0F0", Offset = "0x2A5E4F0", VA = "0x182A5F0F0")]
	private void NPGAPHMKBAG(EntityQuery PNGFJEAJDGO, bool CKDJGOFBFEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEA")]
	[Cpp2IlInjected.Address(RVA = "0x2A5F4F0", Offset = "0x2A5E8F0", VA = "0x182A5F4F0")]
	private void PJPADDMNBFN(EntityQuery PNGFJEAJDGO, bool CKDJGOFBFEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEB")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public LGDGBKNMNOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E9")]
internal class CHOIBJDKMHM : CBHLJLLPMCM
{
	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	protected override GBICPCJAFPO OLPAAHHJIKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000AED")]
		[Cpp2IlInjected.Address(RVA = "0x251A380", Offset = "0x2519780", VA = "0x18251A380", Slot = "15")]
		get
		{
			return default(GBICPCJAFPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEE")]
	[Cpp2IlInjected.Address(RVA = "0x2516270", Offset = "0x2515670", VA = "0x182516270")]
	public CHOIBJDKMHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001EA")]
[DefaultMember("Item")]
public struct OAGAALHEKIF<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400063D")]
	public NativeList<Entity> PGJLMFPAKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400063E")]
	public NativeList<T> KJFNAECAHBA;

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public int KPHJAIPOAJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000AEF")]
		[Cpp2IlInjected.Address(RVA = "0x27026E0", Offset = "0x2701AE0", VA = "0x1827026E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public (Entity entity, T value) OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000AF0")]
		[Cpp2IlInjected.Address(RVA = "0x27012D0", Offset = "0x27006D0", VA = "0x1827012D0")]
		get
		{
			return default((Entity, T));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF1")]
	[Cpp2IlInjected.Address(RVA = "0x27021A0", Offset = "0x27015A0", VA = "0x1827021A0")]
	public void EBOHBLNDMAL(Entity FKNFFDFGNMN, T KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF2")]
	[Cpp2IlInjected.Address(RVA = "0x27019F0", Offset = "0x2700DF0", VA = "0x1827019F0")]
	public void BNPPEBKKNKC(NativeArray<Entity> FKNFFDFGNMN, NativeArray<T> KKIAKNLLHIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001EB")]
[EBCKCHNKEDI]
public class FDNIKINPGPI : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x400063F")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.Token(Token = "0x4000640")]
	private static readonly PILIJFIMAJF FFAJFPHHEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000641")]
	[ONGFANECMJO]
	private CIEAPPOCDCN KKLGCCIPMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000642")]
	private EntityQuery KHMMJEKGIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000643")]
	private EntityQuery MLDLCCAJBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000644")]
	private bool MMLDFGNKLLJ;

	[Cpp2IlInjected.Token(Token = "0x6000AF3")]
	[Cpp2IlInjected.Address(RVA = "0x28CECF0", Offset = "0x28CE0F0", VA = "0x1828CECF0", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF4")]
	[Cpp2IlInjected.Address(RVA = "0x28CED60", Offset = "0x28CE160", VA = "0x1828CED60")]
	public bool KMFFINDBGDH(Entity FKNFFDFGNMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF5")]
	[Cpp2IlInjected.Address(RVA = "0x28CEE10", Offset = "0x28CE210", VA = "0x1828CEE10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF6")]
	[Cpp2IlInjected.Address(RVA = "0x28CED40", Offset = "0x28CE140", VA = "0x1828CED40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF7")]
	[Cpp2IlInjected.Address(RVA = "0xF896F0", Offset = "0xF88AF0", VA = "0x180F896F0", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF8")]
	[Cpp2IlInjected.Address(RVA = "0x28CEEF0", Offset = "0x28CE2F0", VA = "0x1828CEEF0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF9")]
	[Cpp2IlInjected.Address(RVA = "0x28CED40", Offset = "0x28CE140", VA = "0x1828CED40")]
	private void KMELJKCFKPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFA")]
	[Cpp2IlInjected.Address(RVA = "0x28CE9E0", Offset = "0x28CDDE0", VA = "0x1828CE9E0")]
	private void HOEABCFDGFC(EntityQuery PNGFJEAJDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFB")]
	[Cpp2IlInjected.Address(RVA = "0x28CE870", Offset = "0x28CDC70", VA = "0x1828CE870")]
	private void GLEMMDGAKEF(NativeArray<Entity> PGJLMFPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFC")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public FDNIKINPGPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001EC")]
public struct BBAGIBOCELJ<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000645")]
	private OAGAALHEKIF<T> HEGEMCIFGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000646")]
	private EntityCommandBuffer FFLDGNLHFCF;

	[Cpp2IlInjected.Token(Token = "0x6000AFE")]
	[Cpp2IlInjected.Address(RVA = "0x2044740", Offset = "0x2043B40", VA = "0x182044740")]
	public BBAGIBOCELJ(OAGAALHEKIF<T> HEGEMCIFGEI, EntityCommandBuffer FFLDGNLHFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFF")]
	[Cpp2IlInjected.Address(RVA = "0x24BBCA0", Offset = "0x24BB0A0", VA = "0x1824BBCA0", Slot = "4")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000B00")]
	[Cpp2IlInjected.Address(RVA = "0x2044720", Offset = "0x2043B20", VA = "0x182044720")]
	public static OAGAALHEKIF<T> PGDDHPNABOB(BBAGIBOCELJ<T> GCKJNKPJMJF)
	{
		return default(OAGAALHEKIF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001ED")]
public static class KNBEHDBNGNJ
{
	[Cpp2IlInjected.Token(Token = "0x4000647")]
	internal static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.Token(Token = "0x6000B01")]
	[Cpp2IlInjected.Address(RVA = "0x2420680", Offset = "0x241FA80", VA = "0x182420680")]
	public static void BFCHCMHGCOO<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData>(EMFBCBAOENA PHPOLCBAEBM, AFHAKKMHKHI<Entity> KKIJPENOLBP, out POICFBHIEPP<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> MPIPHGAAHJH) where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, GDGEAAKNBIK where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, GDGEAAKNBIK, IEquatable<TChildrenData>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B02")]
	[Cpp2IlInjected.Address(RVA = "0x2894ED0", Offset = "0x28942D0", VA = "0x182894ED0")]
	public static bool BNDFJDDEAAN(EFBPNECENII KKPHHAGKLLH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001EE")]
public class POICFBHIEPP<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, GDGEAAKNBIK where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, GDGEAAKNBIK, IEquatable<TChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x4000648")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000649")]
	private readonly PFJMBDHJHAN BDLCNPMEDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400064A")]
	private readonly MDGCCNJAIOM<Entity> HNNIGEFAIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400064B")]
	private readonly EDAGPFPPFFG OGKBECOAAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400064C")]
	private readonly MLIEHECMNHI ILDFJHMNOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400064D")]
	private readonly EntityManager GLPCEPPDPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400064E")]
	private readonly BAHKBHMHHLL KCAHGNNGIDP;

	[Cpp2IlInjected.Token(Token = "0x6000B04")]
	[Cpp2IlInjected.Address(RVA = "0x255BAB0", Offset = "0x255AEB0", VA = "0x18255BAB0")]
	public POICFBHIEPP(EMFBCBAOENA PHPOLCBAEBM, AFHAKKMHKHI<Entity> KKIJPENOLBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B05")]
	[Cpp2IlInjected.Address(RVA = "0x255ACE0", Offset = "0x255A0E0", VA = "0x18255ACE0")]
	private bool JNHKPOLIGCE(Entity FKNFFDFGNMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B06")]
	[Cpp2IlInjected.Address(RVA = "0x255A640", Offset = "0x2559A40", VA = "0x18255A640")]
	private bool DMCBCHILIDJ(Entity FKNFFDFGNMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B07")]
	[Cpp2IlInjected.Address(RVA = "0x255ADD0", Offset = "0x255A1D0", VA = "0x18255ADD0")]
	private bool LLHJNEHKAII(Entity FKNFFDFGNMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B08")]
	[Cpp2IlInjected.Address(RVA = "0x255AD40", Offset = "0x255A140", VA = "0x18255AD40")]
	public bool LBKKOGFBAGN(Entity FKNFFDFGNMN, in Entity GHLIBENNEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B09")]
	[Cpp2IlInjected.Address(RVA = "0x255B540", Offset = "0x255A940", VA = "0x18255B540")]
	public bool OGKBEDDIKGG(Entity FKNFFDFGNMN, in Entity GHLIBENNEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0A")]
	[Cpp2IlInjected.Address(RVA = "0x255B0E0", Offset = "0x255A4E0", VA = "0x18255B0E0")]
	private bool OGKBEDDIKGG(Entity FKNFFDFGNMN, in Entity GHLIBENNEBB, bool AKKBAKDEDPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0B")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	private static void LMCHHMIKJED(Entity FKNFFDFGNMN, in Entity GHLIBENNEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0C")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	private static void KIFONLGDLKL(Entity FKNFFDFGNMN, in Entity GHLIBENNEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0D")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	private static void FEOLJHHAJLJ(Entity FKNFFDFGNMN, in Entity GHLIBENNEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0E")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	private static void MDPLCKOHCLM(Entity FKNFFDFGNMN, in Entity GHLIBENNEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0F")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	private static void IFKJGHODPIO(Entity FKNFFDFGNMN, in Entity GHLIBENNEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B10")]
	[Cpp2IlInjected.Address(RVA = "0x255AF20", Offset = "0x255A320", VA = "0x18255AF20")]
	private bool OFOEOMJNIKA(Entity FKNFFDFGNMN, Entity MODHKGGCBAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B11")]
	[Cpp2IlInjected.Address(RVA = "0x255AE30", Offset = "0x255A230", VA = "0x18255AE30")]
	private void NCKPNDCJHLB(Entity FKNFFDFGNMN, in Entity KMKEMACKNKI, in Entity GHLIBENNEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B12")]
	[Cpp2IlInjected.Address(RVA = "0x255A8A0", Offset = "0x2559CA0", VA = "0x18255A8A0")]
	private void GGKMJKPLJML(Entity FKNFFDFGNMN, in Entity KMKEMACKNKI, in Entity GHLIBENNEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B13")]
	[Cpp2IlInjected.Address(RVA = "0x255B570", Offset = "0x255A970", VA = "0x18255B570")]
	private bool PFKEADIHGDN(MGGIKJGDIFI DBOMOFCMPIC, in CMFFIMLEPBE EOPFPGCENPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B14")]
	[Cpp2IlInjected.Address(RVA = "0x255AA40", Offset = "0x2559E40", VA = "0x18255AA40")]
	private void JGCNEKOCFFL(Entity ILDFJHMNOPJ, Entity CDFHGECAPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B15")]
	[Cpp2IlInjected.Address(RVA = "0x255A5B0", Offset = "0x25599B0", VA = "0x18255A5B0")]
	private void DHPKFCEIGDC(Entity ILDFJHMNOPJ, Entity CDFHGECAPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B16")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	private void IPICPHAJLBE(Entity FKNFFDFGNMN, Entity KMKEMACKNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B17")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	private void NHBBCMPMEKD(Entity FKNFFDFGNMN, Entity GHLIBENNEBB)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001EF")]
	[CompilerGenerated]
	public class GatherModifiedParents : JKIEMPJPHGI, CBKELFDIEEL
	{
		[Cpp2IlInjected.Token(Token = "0x20001F0")]
		[BurstCompile]
		[NoAlias]
		private struct GatherModifiedParents_AddNewParents_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000655")]
			public NativeList<PEHOAOEGBBM> newParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000656")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000657")]
			[ReadOnly]
			public ComponentTypeHandle<ELLKBCJMOKK> __currentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000B20")]
			[Cpp2IlInjected.Address(RVA = "0x270EEB0", Offset = "0x270E2B0", VA = "0x18270EEB0")]
			private void EJBLFCAPFKM(Entity entity, [NoAlias] in ELLKBCJMOKK current)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B21")]
			[Cpp2IlInjected.Address(RVA = "0x270EF30", Offset = "0x270E330", VA = "0x18270EF30", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001F1")]
		[BurstCompile]
		[NoAlias]
		private struct GatherModifiedParents_AddChangedParents_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000658")]
			public NativeList<BEHJCNECJCL> changedParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000659")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400065A")]
			[ReadOnly]
			public ComponentTypeHandle<ELLKBCJMOKK> __currentTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400065B")]
			[ReadOnly]
			public ComponentTypeHandle<LGGMOLOMIMK> __previousTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000B22")]
			[Cpp2IlInjected.Address(RVA = "0x270EC50", Offset = "0x270E050", VA = "0x18270EC50")]
			private void EJBLFCAPFKM(Entity entity, [NoAlias] in ELLKBCJMOKK current, [NoAlias] in LGGMOLOMIMK previous)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B23")]
			[Cpp2IlInjected.Address(RVA = "0x270ED10", Offset = "0x270E110", VA = "0x18270ED10", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001F2")]
		[BurstCompile]
		[NoAlias]
		private struct GatherModifiedParents_AddRemovedParents_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400065C")]
			public NativeList<PEHOAOEGBBM> oldParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400065D")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400065E")]
			[ReadOnly]
			public ComponentTypeHandle<LGGMOLOMIMK> __previousTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000B24")]
			[Cpp2IlInjected.Address(RVA = "0x270F050", Offset = "0x270E450", VA = "0x18270F050")]
			private void EJBLFCAPFKM(Entity entity, [NoAlias] in LGGMOLOMIMK previous)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B25")]
			[Cpp2IlInjected.Address(RVA = "0x270F0D0", Offset = "0x270E4D0", VA = "0x18270F0D0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		private BAHKBHMHHLL parentEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		private EntityQuery GatherModifiedParents_AddNewParents_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		private EntityQuery GatherModifiedParents_AddChangedParents_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		private EntityQuery GatherModifiedParents_AddRemovedParents_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		private ComponentTypeHandle<ELLKBCJMOKK> __RecRoom_Components_ParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		private ComponentTypeHandle<LGGMOLOMIMK> __RecRoom_Components_PreviousParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000B19")]
		[Cpp2IlInjected.Address(RVA = "0x28DB0B0", Offset = "0x28DA4B0", VA = "0x1828DB0B0", Slot = "14")]
		public void JFCLKDMBJND(EMFBCBAOENA services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1A")]
		[Cpp2IlInjected.Address(RVA = "0x28DBA80", Offset = "0x28DAE80", VA = "0x1828DBA80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1B")]
		[Cpp2IlInjected.Address(RVA = "0x28DB2C0", Offset = "0x28DA6C0", VA = "0x1828DB2C0")]
		private JobHandle NMDKOCBGNGH(NativeList<PEHOAOEGBBM> newParents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1C")]
		[Cpp2IlInjected.Address(RVA = "0x28DAF40", Offset = "0x28DA340", VA = "0x1828DAF40")]
		private JobHandle FHFNABCEOKM(NativeList<BEHJCNECJCL> changedParents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x28DB190", Offset = "0x28DA590", VA = "0x1828DB190")]
		private JobHandle KICKBFNKPOH(NativeList<PEHOAOEGBBM> oldParents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x28DB3F0", Offset = "0x28DA7F0", VA = "0x1828DB3F0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1F")]
		[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
		public GatherModifiedParents()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F3")]
[UpdateBefore(typeof(AHKHGHPHNFA))]
public class MNJBGKKJLIK : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x400065F")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000660")]
	private NLLKOIOEBHH JJBMHHKCDGP;

	[Cpp2IlInjected.Token(Token = "0x6000B26")]
	[Cpp2IlInjected.Address(RVA = "0x2A6AE00", Offset = "0x2A6A200", VA = "0x182A6AE00", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B27")]
	[Cpp2IlInjected.Address(RVA = "0x2A6AE50", Offset = "0x2A6A250", VA = "0x182A6AE50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B28")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public MNJBGKKJLIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F4")]
[EFDJEPLIMOC(typeof(GNCJLPLLPLA), new string[] { })]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
internal class GNCJLPLLPLA : BPCGJMMPFKK, AKFIPDJCCOH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20001F6")]
	[CompilerGenerated]
	private sealed class KIJHPEJANJM : IEnumerable<(EHKHPDFBEJD, LENINMGJJHF)>, IEnumerable, IEnumerator<(EHKHPDFBEJD, LENINMGJJHF)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		private (EHKHPDFBEJD primitiveType, LENINMGJJHF prefabType) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public GNCJLPLLPLA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		private int <i>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		private EHKHPDFBEJD <primitiveType>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		private LENINMGJJHF <prefabType>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000142")]
		private (EHKHPDFBEJD, LENINMGJJHF) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000B47")]
			[Cpp2IlInjected.Address(RVA = "0x2259F80", Offset = "0x2259380", VA = "0x182259F80", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((EHKHPDFBEJD, LENINMGJJHF));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000B49")]
			[Cpp2IlInjected.Address(RVA = "0x2712920", Offset = "0x2711D20", VA = "0x182712920", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0x2712970", Offset = "0x2711D70", VA = "0x182712970")]
		[DebuggerHidden]
		public KIJHPEJANJM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B45")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x2712760", Offset = "0x2711B60", VA = "0x182712760", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B48")]
		[Cpp2IlInjected.Address(RVA = "0x27128E0", Offset = "0x2711CE0", VA = "0x1827128E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4A")]
		[Cpp2IlInjected.Address(RVA = "0x2712840", Offset = "0x2711C40", VA = "0x182712840", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(EHKHPDFBEJD, LENINMGJJHF)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4B")]
		[Cpp2IlInjected.Address(RVA = "0x2712840", Offset = "0x2711C40", VA = "0x182712840", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000661")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000662")]
	[ONGFANECMJO]
	private PFJMBDHJHAN GKACEDOEIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000663")]
	private World BDLCNPMEDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000664")]
	private NativeParallelHashMap<int, Entity> EDNPFADAINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000665")]
	private NativeParallelHashMap<int, EntityArchetype> CNBKEOKPHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000666")]
	private NativeParallelHashMap<int, int> PAHCJFHHFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000667")]
	private LENINMGJJHF[] PMMGJMLABKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000668")]
	private readonly Dictionary<EHKHPDFBEJD, LENINMGJJHF> LPGILLADJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000669")]
	private readonly Dictionary<IPKCLDKJBAH, LENINMGJJHF> IBFKEKLACGI;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public int NPBPHODFKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(RVA = "0x28D9DB0", Offset = "0x28D91B0", VA = "0x1828D9DB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public EntityManager FCLKPLIBOOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000B2B")]
		[Cpp2IlInjected.Address(RVA = "0x94B830", Offset = "0x94AC30", VA = "0x18094B830")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B2C")]
		[Cpp2IlInjected.Address(RVA = "0x97D5C0", Offset = "0x97C9C0", VA = "0x18097D5C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2D")]
	[Cpp2IlInjected.Address(RVA = "0x28D91E0", Offset = "0x28D85E0", VA = "0x1828D91E0", Slot = "5")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2E")]
	[Cpp2IlInjected.Address(RVA = "0x28D8BD0", Offset = "0x28D7FD0", VA = "0x1828D8BD0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2F")]
	[Cpp2IlInjected.Address(RVA = "0x9CDA80", Offset = "0x9CCE80", VA = "0x1809CDA80")]
	internal NativeParallelHashMap<int, Entity> GCEFGHJHMDG()
	{
		return default(NativeParallelHashMap<int, Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B30")]
	[Cpp2IlInjected.Address(RVA = "0xC0F7F0", Offset = "0xC0EBF0", VA = "0x180C0F7F0")]
	internal NativeParallelHashMap<int, EntityArchetype> KEEFGLCOOKN()
	{
		return default(NativeParallelHashMap<int, EntityArchetype>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B31")]
	[Cpp2IlInjected.Address(RVA = "0x9CDA90", Offset = "0x9CCE90", VA = "0x1809CDA90")]
	internal NativeParallelHashMap<int, int> MCCMOAOMJLG()
	{
		return default(NativeParallelHashMap<int, int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B32")]
	[Cpp2IlInjected.Address(RVA = "0x28D8870", Offset = "0x28D7C70", VA = "0x1828D8870")]
	internal IEnumerable<Type> CFJMGJDIAHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B33")]
	[Cpp2IlInjected.Address(RVA = "0x28D8800", Offset = "0x28D7C00", VA = "0x1828D8800")]
	internal AKNPKFGMABO ANLBKOCBNAD(Type JLNNFEOBAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B34")]
	[Cpp2IlInjected.Address(RVA = "0x28D8F40", Offset = "0x28D8340", VA = "0x1828D8F40")]
	public EntityArchetype EFOEJJFLFAE(LENINMGJJHF MNOKFAHHNHH)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B35")]
	[Cpp2IlInjected.Address(RVA = "0x28D8FB0", Offset = "0x28D83B0", VA = "0x1828D8FB0", Slot = "4")]
	[IteratorStateMachine(typeof(KIJHPEJANJM))]
	public IEnumerable<(EHKHPDFBEJD, LENINMGJJHF)> EMGAEMHEJJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B36")]
	[Cpp2IlInjected.Address(RVA = "0x28DA180", Offset = "0x28D9580", VA = "0x1828DA180")]
	public Entity MOCOOKLAOJK(LENINMGJJHF MNOKFAHHNHH)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B37")]
	[Cpp2IlInjected.Address(RVA = "0x28DA270", Offset = "0x28D9670", VA = "0x1828DA270")]
	public void OFLAFGOMCJF(NativeArray<LENINMGJJHF> PMMGJMLABKC, NativeArray<Entity> FJGBHHFPLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B38")]
	[Cpp2IlInjected.Address(RVA = "0x28D9020", Offset = "0x28D8420", VA = "0x1828D9020")]
	public void GELBGNHFFFG(LENINMGJJHF MNOKFAHHNHH, NativeArray<Entity> PGJLMFPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B39")]
	[Cpp2IlInjected.Address(RVA = "0x28DA120", Offset = "0x28D9520", VA = "0x1828DA120")]
	public LENINMGJJHF KKPCNJHFKAF(EHKHPDFBEJD JLNNFEOBAMK)
	{
		return default(LENINMGJJHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3A")]
	[Cpp2IlInjected.Address(RVA = "0x28D9CD0", Offset = "0x28D90D0", VA = "0x1828D9CD0")]
	public Entity JGGCHBKNDNE(LENINMGJJHF MNOKFAHHNHH)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3B")]
	[Cpp2IlInjected.Address(RVA = "0x28D88D0", Offset = "0x28D7CD0", VA = "0x1828D88D0")]
	private void DGHPLIHOOAK(AKNPKFGMABO BHINAHMLIJM, NativeList<int> PMMGJMLABKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3C")]
	[Cpp2IlInjected.Address(RVA = "0x28D9DF0", Offset = "0x28D91F0", VA = "0x1828D9DF0")]
	internal void KAIDCMEBIPI(LENINMGJJHF MNOKFAHHNHH, ComponentTypeList DLFDEDPKHME, KPBCDGJDDHN GGNGCFNNAGI, AKNPKFGMABO BHINAHMLIJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3D")]
	[Cpp2IlInjected.Address(RVA = "0x28D9070", Offset = "0x28D8470", VA = "0x1828D9070")]
	private EntityArchetype HGAFIJNHHFN(LENINMGJJHF MNOKFAHHNHH, ComponentTypeList NMIBCPIHMNH)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3E")]
	[Cpp2IlInjected.Address(RVA = "0x28DA480", Offset = "0x28D9880", VA = "0x1828DA480")]
	public GNCJLPLLPLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F7")]
[EFDJEPLIMOC(typeof(JAOEAHCDOAB), new string[] { })]
public class JOODAEPBMOO : AKFIPDJCCOH, JAOEAHCDOAB
{
	[Cpp2IlInjected.Token(Token = "0x20001F8")]
	[CompilerGenerated]
	private sealed class DPGPCMMMPKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public NDPNDFLPOGF objBoard;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public KDLENLDMBAK parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public JOODAEPBMOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		private EFBPNECENII <parentObject>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		private Vector3 <pos>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		private Quaternion <rot>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000B5D")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public DPGPCMMMPKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5E")]
		[Cpp2IlInjected.Address(RVA = "0x270AC60", Offset = "0x270A060", VA = "0x18270AC60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5F")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001F9")]
	[CompilerGenerated]
	private sealed class DNDKDKNIOEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		public EFBPNECENII obj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		public JOODAEPBMOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000B60")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public DNDKDKNIOEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B61")]
		[Cpp2IlInjected.Address(RVA = "0x270A0A0", Offset = "0x27094A0", VA = "0x18270A0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B62")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000675")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000676")]
	[ONGFANECMJO]
	private MJHECCLPBHE LEGFAAONKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000677")]
	private EntityManager GLPCEPPDPLB;

	[Cpp2IlInjected.Token(Token = "0x6000B4C")]
	[Cpp2IlInjected.Address(RVA = "0x288FDF0", Offset = "0x288F1F0", VA = "0x18288FDF0", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4D")]
	[Cpp2IlInjected.Address(RVA = "0x28905A0", Offset = "0x288F9A0", VA = "0x1828905A0", Slot = "5")]
	public bool NOOCHNBNFON(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4E")]
	[Cpp2IlInjected.Address(RVA = "0x288F6B0", Offset = "0x288EAB0", VA = "0x18288F6B0", Slot = "7")]
	public bool FOHEPMIDLHB(KDLENLDMBAK LCODCOPGHJA, out Guid GHNPAEHCAPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4F")]
	[Cpp2IlInjected.Address(RVA = "0x288FAC0", Offset = "0x288EEC0", VA = "0x18288FAC0", Slot = "8")]
	public Guid GOEBDMKJCJI(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B50")]
	[Cpp2IlInjected.Address(RVA = "0x288FE90", Offset = "0x288F290", VA = "0x18288FE90", Slot = "9")]
	public void LAGPEHNGOBH(KDLENLDMBAK LCODCOPGHJA, Guid GHNPAEHCAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B51")]
	[Cpp2IlInjected.Address(RVA = "0x288F300", Offset = "0x288E700", VA = "0x18288F300", Slot = "10")]
	public bool BODCJGNHGEP(KDLENLDMBAK LCODCOPGHJA, out Guid AGMGFKBEKDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B52")]
	[Cpp2IlInjected.Address(RVA = "0x28906D0", Offset = "0x288FAD0", VA = "0x1828906D0", Slot = "11")]
	public Guid PPFBJONDPEK(KDLENLDMBAK LCODCOPGHJA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B53")]
	[Cpp2IlInjected.Address(RVA = "0x288F7D0", Offset = "0x288EBD0", VA = "0x18288F7D0", Slot = "12")]
	public void GLIBCGGMKCG(KDLENLDMBAK LCODCOPGHJA, Guid AGMGFKBEKDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B54")]
	[Cpp2IlInjected.Address(RVA = "0x288EF50", Offset = "0x288E350", VA = "0x18288EF50", Slot = "13")]
	public void AMKCOFMHHJO(KDLENLDMBAK LCODCOPGHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B55")]
	[Cpp2IlInjected.Address(RVA = "0x2890180", Offset = "0x288F580", VA = "0x182890180", Slot = "14")]
	public void LCFAIMDJBOL(KDLENLDMBAK GDNOLIODDHJ, KDLENLDMBAK ILDFJHMNOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B56")]
	[Cpp2IlInjected.Address(RVA = "0x288F000", Offset = "0x288E400", VA = "0x18288F000")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DPGPCMMMPKB))]
	private Task BHKLEHKJHOO(NDPNDFLPOGF JAMBKHGPJEK, KDLENLDMBAK ILDFJHMNOPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B57")]
	[Cpp2IlInjected.Address(RVA = "0x288F180", Offset = "0x288E580", VA = "0x18288F180")]
	private void BOBKLNCKOLH(NDPNDFLPOGF JAMBKHGPJEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B58")]
	[Cpp2IlInjected.Address(RVA = "0x288FC10", Offset = "0x288F010", VA = "0x18288FC10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DNDKDKNIOEK))]
	private Task HIEDEIPJFFG(EFBPNECENII ICNDEPGFBMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B59")]
	[Cpp2IlInjected.Address(RVA = "0x288F420", Offset = "0x288E820", VA = "0x18288F420")]
	private Task EJACEOBFKEP(EFBPNECENII ICNDEPGFBMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5A")]
	[Cpp2IlInjected.Address(RVA = "0x288FD60", Offset = "0x288F160", VA = "0x18288FD60", Slot = "6")]
	public bool HIPMBPGLBJH(KDLENLDMBAK BGPCGOEKFEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5B")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public JOODAEPBMOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FA")]
internal class PFELCKDPKPB : DPMFBCJDGFB
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20001FB")]
	public struct KAFGCCMHAOA : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x4000686")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	protected override ComponentType PDHNPENHMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000B64")]
		[Cpp2IlInjected.Address(RVA = "0x222F260", Offset = "0x222E660", VA = "0x18222F260", Slot = "15")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	protected override ComponentType IMMDMMODPGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000B65")]
		[Cpp2IlInjected.Address(RVA = "0x222F290", Offset = "0x222E690", VA = "0x18222F290", Slot = "16")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	protected override ComponentType IEBBBMGCEFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000B66")]
		[Cpp2IlInjected.Address(RVA = "0x222F2C0", Offset = "0x222E6C0", VA = "0x18222F2C0", Slot = "17")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B63")]
	[Cpp2IlInjected.Address(RVA = "0x222F380", Offset = "0x222E780", VA = "0x18222F380")]
	public PFELCKDPKPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FC")]
internal abstract class JHKLBCGALML<TPlayerTag> : JKIEMPJPHGI where TPlayerTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000687")]
	private EntityQuery EHPDPFMPFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000688")]
	private EntityQuery LNIDKGHLBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000689")]
	private EntityQuery KKAPFOFGHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400068A")]
	private EntityQuery DHDKKMKKEDK;

	[Cpp2IlInjected.Token(Token = "0x6000B68")]
	[Cpp2IlInjected.Address(RVA = "0x2D21EA0", Offset = "0x2D212A0", VA = "0x182D21EA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B69")]
	[Cpp2IlInjected.Address(RVA = "0x2D22270", Offset = "0x2D21670", VA = "0x182D22270", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6A")]
	[Cpp2IlInjected.Address(RVA = "0x2D22240", Offset = "0x2D21640", VA = "0x182D22240", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6B")]
	[Cpp2IlInjected.Address(RVA = "0x2D216E0", Offset = "0x2D20AE0", VA = "0x182D216E0")]
	private void HCGLHECNLBB(EntityQuery PNGFJEAJDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6C")]
	[Cpp2IlInjected.Address(RVA = "0x2D20F80", Offset = "0x2D20380", VA = "0x182D20F80")]
	private void EFNJHOGFKPJ(EntityQuery PNGFJEAJDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6D")]
	[Cpp2IlInjected.Address(RVA = "0x2D20B90", Offset = "0x2D1FF90", VA = "0x182D20B90")]
	private void BJABMHBIFKG(EntityQuery PNGFJEAJDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	protected abstract void BFMPNCEOKAI(NativeArray<Entity> PGJLMFPAKDA, NativeArray<Entity> ACIJPDFENHE, NativeArray<Entity> EIEGKDOGOIO);

	[Cpp2IlInjected.Token(Token = "0x6000B6F")]
	[Cpp2IlInjected.Address(RVA = "0x2102CF0", Offset = "0x21020F0", VA = "0x182102CF0")]
	protected JHKLBCGALML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FD")]
[AlwaysUpdateSystem]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
public class BMLMJGNEJFH : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400068B")]
	private AOONNPAOEFB FHJACJEANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400068C")]
	[ONGFANECMJO]
	private MDBOACJLHAE HNFAJKHJNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400068D")]
	[ONGFANECMJO]
	private FKMCIKMFIDA PBEKHCPKAGN;

	[Cpp2IlInjected.Token(Token = "0x6000B70")]
	[Cpp2IlInjected.Address(RVA = "0x25148A0", Offset = "0x2513CA0", VA = "0x1825148A0", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B71")]
	[Cpp2IlInjected.Address(RVA = "0x2514820", Offset = "0x2513C20", VA = "0x182514820")]
	protected void GJKDIODCJFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B72")]
	[Cpp2IlInjected.Address(RVA = "0x2514930", Offset = "0x2513D30", VA = "0x182514930", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B73")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public BMLMJGNEJFH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001FE")]
public struct ONOEMEJJFPL : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x400068E")]
	public static readonly ONOEMEJJFPL DEEICBABDMJ;

	[Cpp2IlInjected.Token(Token = "0x6000B74")]
	[Cpp2IlInjected.Address(RVA = "0x222A7E0", Offset = "0x2229BE0", VA = "0x18222A7E0", Slot = "4")]
	public bool Equals(LinkedEntityGroup GEAEMIOLNKK, LinkedEntityGroup KFMHCNGHPHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B75")]
	[Cpp2IlInjected.Address(RVA = "0x222A800", Offset = "0x2229C00", VA = "0x18222A800", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup ICNDEPGFBMI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FF")]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
public class HFINAEACCGM : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400068F")]
	private CAAJLLDIGHE ELICALMKHOD;

	[Cpp2IlInjected.Token(Token = "0x6000B77")]
	[Cpp2IlInjected.Address(RVA = "0x287A8C0", Offset = "0x2879CC0", VA = "0x18287A8C0", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B78")]
	[Cpp2IlInjected.Address(RVA = "0x287A910", Offset = "0x2879D10", VA = "0x18287A910", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B79")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public HFINAEACCGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000200")]
internal abstract class OPIOBIJBFDM : ICDMBOJCFKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000690")]
	private EntityQuery AKDABPMJGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000691")]
	private EntityQuery GOHMCJPPDNH;

	[Cpp2IlInjected.Token(Token = "0x6000B7A")]
	[Cpp2IlInjected.Address(RVA = "0x222D3E0", Offset = "0x222C7E0", VA = "0x18222D3E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7B")]
	[Cpp2IlInjected.Address(RVA = "0x222D760", Offset = "0x222CB60", VA = "0x18222D760", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7C")]
	[Cpp2IlInjected.Address(RVA = "0x222D330", Offset = "0x222C730", VA = "0x18222D330")]
	private void FGPIGMPFGAG(EntityQuery PNGFJEAJDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7D")]
	[Cpp2IlInjected.Address(RVA = "0x222D810", Offset = "0x222CC10", VA = "0x18222D810")]
	protected OPIOBIJBFDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000202")]
public class OILIEAEJNBN : JKIEMPJPHGI
{
	[Cpp2IlInjected.Token(Token = "0x6000B80")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B81")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public OILIEAEJNBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000203")]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
internal class NNNFHDLCHFN : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x4000693")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000694")]
	private AOONNPAOEFB FHJACJEANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000695")]
	private EGBDNLKFOBI NFOOMJHPEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000696")]
	private EONNPNOIBPC MCJOPJDGNIK;

	[Cpp2IlInjected.Token(Token = "0x6000B82")]
	[Cpp2IlInjected.Address(RVA = "0x2A72870", Offset = "0x2A71C70", VA = "0x182A72870", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B83")]
	[Cpp2IlInjected.Address(RVA = "0x2A72900", Offset = "0x2A71D00", VA = "0x182A72900", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B84")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public NNNFHDLCHFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000204")]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
[EFDJEPLIMOC(typeof(GDDLKDHJNAI), new string[] { })]
internal sealed class GDDLKDHJNAI : AKFIPDJCCOH, CBKELFDIEEL
{
	[Cpp2IlInjected.Token(Token = "0x4000697")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000698")]
	[ONGFANECMJO]
	private PGKBPEGCPKO KMPMKIKDFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000699")]
	private MDGCCNJAIOM<Entity> HNNIGEFAIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400069A")]
	private POICFBHIEPP<ELLKBCJMOKK, LGGMOLOMIMK, IFLOCLHFHHI, OOENBAEOKLI> HPCLGKAKGHC;

	[Cpp2IlInjected.Token(Token = "0x6000B86")]
	[Cpp2IlInjected.Address(RVA = "0x28D5560", Offset = "0x28D4960", VA = "0x1828D5560", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B87")]
	[Cpp2IlInjected.Address(RVA = "0x28D55B0", Offset = "0x28D49B0", VA = "0x1828D55B0", Slot = "5")]
	public void JFCLKDMBJND(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B88")]
	[Cpp2IlInjected.Address(RVA = "0x28D5240", Offset = "0x28D4640", VA = "0x1828D5240")]
	public Entity BGOPCJKFHEJ(Entity FKNFFDFGNMN)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B89")]
	[Cpp2IlInjected.Address(RVA = "0x28D56F0", Offset = "0x28D4AF0", VA = "0x1828D56F0")]
	public bool LBKKOGFBAGN(Entity FKNFFDFGNMN, Entity GHLIBENNEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8A")]
	[Cpp2IlInjected.Address(RVA = "0x28D5290", Offset = "0x28D4690", VA = "0x1828D5290")]
	public bool CIGBDIGMBAB(Entity FKNFFDFGNMN, Entity GHLIBENNEBB, bool IHNOCHJJPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8B")]
	[Cpp2IlInjected.Address(RVA = "0x28D5330", Offset = "0x28D4730", VA = "0x1828D5330")]
	private bool GEBLJKHEBFA(Entity FKNFFDFGNMN, Entity GHLIBENNEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8C")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public GDDLKDHJNAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000205")]
internal readonly struct EHPPEJBAPGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000206")]
	[BurstCompile]
	private struct EJGPCGOMGIH : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		[ReadOnly]
		public EntityTypeHandle KLDKHBGCCAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		[ReadOnly]
		public ComponentDataFromEntity<EONGFACGDFM> BJGKPCLJGCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		[ReadOnly]
		public DynamicComponentTypeHandle MDPAMDBKABJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		[ReadOnly]
		public SharedComponentTypeHandle<RRObjectPrefabV2Data> DKGAGLLCNPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		[ReadOnly]
		public NativeParallelHashMap<int, Entity> PGFIHLKANJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		[ReadOnly]
		public ComponentDataFromEntity MIPNNDGFCEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		[ReadOnly]
		public NativeArray<byte>.ReadOnly JPJLIECAGOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		[ReadOnly]
		public NativeArray<NDLCDGPEBGB>.ReadOnly FIHIPJLEDHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public ComponentDataFromEntity OIINIKPGGJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		public NativeList<Entity> HCILMHGKPIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public NativeList<Entity> EIOBKCKDBID;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public NativeList<byte> NGBMFNELBPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public NativeList<byte> KHOKAFDFHHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public NativeList<byte> NPGICOBFCLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public int IBJLEPPHMPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public int BCDNJJPDNMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public bool KGGEBNEEAAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public EOLDLAAGOPC.NCEKOCOMNLC MMGKIPGKNHG;

		[Cpp2IlInjected.Token(Token = "0x6000B94")]
		[Cpp2IlInjected.Address(RVA = "0x270C520", Offset = "0x270B920", VA = "0x18270C520", Slot = "4")]
		public void Execute(ArchetypeChunk NCPBFICMLEP, int ENBIMODBIAK, int HHILCJGIMIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B95")]
		[Cpp2IlInjected.Address(RVA = "0x270C9A0", Offset = "0x270BDA0", VA = "0x18270C9A0")]
		private unsafe bool OEBOFJGHECF(Entity EILGABICEKL, Entity CAFBHNAJGNL, byte* ECOHOMOLLMM, byte* JEBGMCFFADG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B96")]
		[Cpp2IlInjected.Address(RVA = "0x270C500", Offset = "0x270B900", VA = "0x18270C500")]
		private unsafe void DGCDPJOAHEA(byte* ECOHOMOLLMM, byte* JEBGMCFFADG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B97")]
		[Cpp2IlInjected.Address(RVA = "0x270C890", Offset = "0x270BC90", VA = "0x18270C890")]
		private unsafe byte* HJOMBHPLOAJ(NativeArray<byte> MBDOAJBNMJI, int GNPGECNAJNK)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B98")]
		[Cpp2IlInjected.Address(RVA = "0x270C930", Offset = "0x270BD30", VA = "0x18270C930")]
		private unsafe byte* JONOFHPEMED(Entity CAFBHNAJGNL)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B99")]
		[Cpp2IlInjected.Address(RVA = "0x270CB70", Offset = "0x270BF70", VA = "0x18270CB70")]
		private unsafe byte* PCOOOKGIPDP(ArchetypeChunk NCPBFICMLEP)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9A")]
		[Cpp2IlInjected.Address(RVA = "0x270C4C0", Offset = "0x270B8C0", VA = "0x18270C4C0")]
		private static Entity AHGOMJBKCJA(in EONGFACGDFM KJFNAECAHBA)
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000207")]
	[BurstCompile]
	private struct LHCPKHNNGDD : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		[ReadOnly]
		public NativeList<Entity> IOCAOKPPANB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		[ReadOnly]
		public NativeList<byte> PIGIMLOBKHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		[ReadOnly]
		public NativeList<byte> GOBEHLKJMKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		[ReadOnly]
		public NativeList<byte> GFAPFNCNLCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		[ReadOnly]
		public NativeArray<NDLCDGPEBGB>.ReadOnly FIHIPJLEDHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		public NativeParallelMultiHashMap<Entity, ELGEKKCACLJ> JKIPGIEADGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public int IBJLEPPHMPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		public int BCDNJJPDNMB;

		[Cpp2IlInjected.Token(Token = "0x6000B9B")]
		[Cpp2IlInjected.Address(RVA = "0x2713D20", Offset = "0x2713120", VA = "0x182713D20", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400069B")]
	private static readonly ProfilerMarker EFGOHNJJAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400069C")]
	private readonly JKIEMPJPHGI JJBAHIPIPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400069D")]
	private readonly World GLMOAKNBFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400069E")]
	private readonly IJEMANMGDHA NHFIOAOABBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400069F")]
	private readonly NativeParallelHashMap<int, Entity> GPHMFMMLINI;

	[Cpp2IlInjected.Token(Token = "0x6000B8E")]
	[Cpp2IlInjected.Address(RVA = "0x28C8A20", Offset = "0x28C7E20", VA = "0x1828C8A20")]
	public EHPPEJBAPGJ(JKIEMPJPHGI JJBAHIPIPHK, World GLMOAKNBFDB, EGBDNLKFOBI JHBIIAAOKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8F")]
	[Cpp2IlInjected.Address(RVA = "0x28C80A0", Offset = "0x28C74A0", VA = "0x1828C80A0")]
	public JobHandle COCGDBGCNKP(JDLBPHHOKOP PJAFLHHFBPC, NativeList<(EntityQuery query, int typeIndex, int count, EOLDLAAGOPC.NCEKOCOMNLC mode)> AJMDHBOAFHI, JobHandle OMGHOAKHCEK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B90")]
	[Cpp2IlInjected.Address(RVA = "0x28C8780", Offset = "0x28C7B80", VA = "0x1828C8780")]
	private LHCPKHNNGDD DFBPNPMKLDJ(in EJGPCGOMGIH EMCAMMBNILG, NativeParallelMultiHashMap<Entity, ELGEKKCACLJ> JHCBOCGNECE)
	{
		return default(LHCPKHNNGDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B91")]
	[Cpp2IlInjected.Address(RVA = "0x28C7C10", Offset = "0x28C7010", VA = "0x1828C7C10")]
	private EJGPCGOMGIH BDGDBKOMDFF(ComponentType IJBDFBDGHPH, EntityManager IOIBHKNNBJO, int FIBDNHOHFBN, EOLDLAAGOPC.NCEKOCOMNLC MMGKIPGKNHG)
	{
		return default(EJGPCGOMGIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B92")]
	[Cpp2IlInjected.Address(RVA = "0x28C87F0", Offset = "0x28C7BF0", VA = "0x1828C87F0")]
	private static void DHHOFAMDIJN(JDLBPHHOKOP PJAFLHHFBPC, ComponentType IJBDFBDGHPH, JobHandle FPNNHINBDNF, in EJGPCGOMGIH EMCAMMBNILG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000208")]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
internal class KONJLLMJMDB : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x40006BA")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006BB")]
	private EntityQuery PNGFJEAJDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006BC")]
	private AOONNPAOEFB FHJACJEANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006BD")]
	private OHDDHPCBLAA KMPMKIKDFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006BE")]
	private EONNPNOIBPC MCJOPJDGNIK;

	[Cpp2IlInjected.Token(Token = "0x6000B9C")]
	[Cpp2IlInjected.Address(RVA = "0x2897060", Offset = "0x2896460", VA = "0x182897060", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9D")]
	[Cpp2IlInjected.Address(RVA = "0x2897FA0", Offset = "0x28973A0", VA = "0x182897FA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9E")]
	[Cpp2IlInjected.Address(RVA = "0x2898040", Offset = "0x2897440", VA = "0x182898040", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9F")]
	[Cpp2IlInjected.Address(RVA = "0x28970F0", Offset = "0x28964F0", VA = "0x1828970F0")]
	private void JBLIKLBKJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA0")]
	[Cpp2IlInjected.Address(RVA = "0x2896F50", Offset = "0x2896350", VA = "0x182896F50")]
	private void IAHNFOANBNH(NativeArray<Entity> GBIBKJFKLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA1")]
	[Cpp2IlInjected.Address(RVA = "0x2897760", Offset = "0x2896B60", VA = "0x182897760")]
	private void KJOCAHKPBGP(NativeArray<Entity> PGJLMFPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA2")]
	[Cpp2IlInjected.Address(RVA = "0x2898050", Offset = "0x2897450", VA = "0x182898050")]
	private void PCHADNLJECJ(NativeArray<Entity> JCDNANLLLKA, NativeArray<RigidTransform> PKDNKIMCKKP, NativeArray<RigidTransform> CMKOEMPIKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA3")]
	[Cpp2IlInjected.Address(RVA = "0x2896AD0", Offset = "0x2895ED0", VA = "0x182896AD0")]
	private void DMIFDDAHGJK(NativeArray<RigidTransform> CMKOEMPIKKE, NativeArray<Entity> JCDNANLLLKA, NativeList<Entity> LCOODFJJOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA4")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public KONJLLMJMDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000209")]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
internal sealed class CEIPCENOHPO : HLOJAODEAAM
{
	[Cpp2IlInjected.Token(Token = "0x6000BA6")]
	[Cpp2IlInjected.Address(RVA = "0x25169B0", Offset = "0x2515DB0", VA = "0x1825169B0", Slot = "15")]
	protected override ComponentSystemBase BHJHPJOJPMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA7")]
	[Cpp2IlInjected.Address(RVA = "0x2229A50", Offset = "0x2228E50", VA = "0x182229A50")]
	public CEIPCENOHPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020A")]
internal abstract class PCOIJKOLHMH : HLOJAODEAAM, AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x40006BF")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40006C0")]
	private EGBDNLKFOBI JHBIIAAOKIL;

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	protected abstract GCGDNGNDAMG LBPOJFOKAEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000BA8")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA9")]
	[Cpp2IlInjected.Address(RVA = "0x222E8B0", Offset = "0x222DCB0", VA = "0x18222E8B0", Slot = "16")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAA")]
	[Cpp2IlInjected.Address(RVA = "0x222E900", Offset = "0x222DD00", VA = "0x18222E900", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAB")]
	[Cpp2IlInjected.Address(RVA = "0x222E4A0", Offset = "0x222D8A0", VA = "0x18222E4A0", Slot = "15")]
	protected override ComponentSystemBase BHJHPJOJPMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAC")]
	[Cpp2IlInjected.Address(RVA = "0x2229A50", Offset = "0x2228E50", VA = "0x182229A50")]
	protected PCOIJKOLHMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020B")]
public class IPECBLONBKH : JKIEMPJPHGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006C1")]
	private EntityQuery PNGFJEAJDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006C2")]
	private MAHFNHANKIE DCLHOGPFELA;

	[Cpp2IlInjected.Token(Token = "0x6000BAE")]
	[Cpp2IlInjected.Address(RVA = "0x2887150", Offset = "0x2886550", VA = "0x182887150", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAF")]
	[Cpp2IlInjected.Address(RVA = "0x2887220", Offset = "0x2886620", VA = "0x182887220", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB0")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public IPECBLONBKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020C")]
[UpdateAfter(typeof(LHBKMEBGEJE))]
public class IBPFGDKCHOH : JKIEMPJPHGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006C3")]
	private EntityArchetype DMPELCHDJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006C4")]
	private EntityQuery PNGFJEAJDGO;

	[Cpp2IlInjected.Token(Token = "0x6000BB1")]
	[Cpp2IlInjected.Address(RVA = "0x287C340", Offset = "0x287B740", VA = "0x18287C340", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB2")]
	[Cpp2IlInjected.Address(RVA = "0x287C430", Offset = "0x287B830", VA = "0x18287C430", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB3")]
	[Cpp2IlInjected.Address(RVA = "0x287C2F0", Offset = "0x287B6F0", VA = "0x18287C2F0")]
	private EntityCommandBufferSystem KMBJDEEDCKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB4")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public IBPFGDKCHOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020D")]
internal class JHGCFEAECPB : DPMFBCJDGFB
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200020E")]
	public struct LIBHCJOALHB : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x40006C5")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	protected override ComponentType PDHNPENHMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000BB6")]
		[Cpp2IlInjected.Address(RVA = "0x288B270", Offset = "0x288A670", VA = "0x18288B270", Slot = "15")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	protected override ComponentType IMMDMMODPGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000BB7")]
		[Cpp2IlInjected.Address(RVA = "0x288B2A0", Offset = "0x288A6A0", VA = "0x18288B2A0", Slot = "16")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	protected override ComponentType IEBBBMGCEFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000BB8")]
		[Cpp2IlInjected.Address(RVA = "0x288B2D0", Offset = "0x288A6D0", VA = "0x18288B2D0", Slot = "17")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB5")]
	[Cpp2IlInjected.Address(RVA = "0x288B390", Offset = "0x288A790", VA = "0x18288B390")]
	public JHGCFEAECPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020F")]
[AlwaysUpdateSystem]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
public class OHNNICJFNDG : JKIEMPJPHGI, AKFIPDJCCOH, DEPDOFHIDBA
{
	[Cpp2IlInjected.Token(Token = "0x2000210")]
	[CompilerGenerated]
	private sealed class MIEOFBPGHIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		public KDLENLDMBAK localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		public GLOKJOPHMOK collisionLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		public bool collidersEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		public GBLMPIODHGH containerFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		public bool physicsEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		public bool gravityEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		public bool hasUnityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		public OHNNICJFNDG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public MIEOFBPGHIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x3DE6810", Offset = "0x3DE5C10", VA = "0x183DE6810")]
		internal void DMDCEJAANOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0x3DE6930", Offset = "0x3DE5D30", VA = "0x183DE6930")]
		internal void OJCCJDIFKIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0x3DE66D0", Offset = "0x3DE5AD0", VA = "0x183DE66D0")]
		internal void AOKEMEIMNOI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006C6")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006C7")]
	private EntityQuery PNGFJEAJDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006C8")]
	[ONGFANECMJO]
	private FKMCIKMFIDA PBEKHCPKAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	[ONGFANECMJO]
	private KKJECAIDLGC NPOFINHBGBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006CA")]
	[ONGFANECMJO]
	private AJMPOCCEJIG EKDBECOOKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006CB")]
	private AOONNPAOEFB FHJACJEANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006CC")]
	public ComponentTypeHandle<GBLMPIODHGH> CKMHMNFOPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40006CD")]
	public ComponentTypeHandle<NABKNKHLMPP> PDCBLJHBIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006CE")]
	public ComponentTypeHandle<JACBBANCLJG> HOLFHEOICBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40006CF")]
	public ComponentTypeHandle<LCEBLCAALOE> INLLBALBMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40006D0")]
	public ComponentTypeHandle<ANMBIFMMJPJ> IKODFCGKJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40006D1")]
	public DynamicComponentTypeHandle FMFBDFLDIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40006D2")]
	public EntityTypeHandle AKCDCICFDKC;

	[Cpp2IlInjected.Token(Token = "0x6000BBA")]
	[Cpp2IlInjected.Address(RVA = "0x2A78F50", Offset = "0x2A78350", VA = "0x182A78F50", Slot = "15")]
	public void MCOOCEGHCPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBB")]
	[Cpp2IlInjected.Address(RVA = "0x2A78EA0", Offset = "0x2A782A0", VA = "0x182A78EA0", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBC")]
	[Cpp2IlInjected.Address(RVA = "0x2A79010", Offset = "0x2A78410", VA = "0x182A79010", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBD")]
	[Cpp2IlInjected.Address(RVA = "0x2A789C0", Offset = "0x2A77DC0", VA = "0x182A789C0")]
	private void AOBDBDNACED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBE")]
	[Cpp2IlInjected.Address(RVA = "0x2A78B90", Offset = "0x2A77F90", VA = "0x182A78B90")]
	private bool APIAHGHCHAG(out int ODPNBGGDIBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBF")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public OHNNICJFNDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000211")]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
public sealed class HCAIOHKAFIF : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	private OMKBGDBGLMG LHPBIJEDFLB;

	[Cpp2IlInjected.Token(Token = "0x6000BC5")]
	[Cpp2IlInjected.Address(RVA = "0x28DC0D0", Offset = "0x28DB4D0", VA = "0x1828DC0D0", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC6")]
	[Cpp2IlInjected.Address(RVA = "0x28DC130", Offset = "0x28DB530", VA = "0x1828DC130", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC7")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public HCAIOHKAFIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000212")]
internal abstract class CBHLJLLPMCM : ICDMBOJCFKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	private EntityQuery PNGFJEAJDGO;

	[Cpp2IlInjected.Token(Token = "0x6000BC8")]
	[Cpp2IlInjected.Address(RVA = "0x2515ED0", Offset = "0x25152D0", VA = "0x182515ED0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC9")]
	[Cpp2IlInjected.Address(RVA = "0x25161B0", Offset = "0x25155B0", VA = "0x1825161B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCA")]
	[Cpp2IlInjected.Address(RVA = "0x2516270", Offset = "0x2515670", VA = "0x182516270")]
	protected CBHLJLLPMCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000213")]
[AlwaysUpdateSystem]
public class EOLDLAAGOPC : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x2000214")]
	public enum NCEKOCOMNLC
	{
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		Create,
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		Remove
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006DD")]
	[ONGFANECMJO]
	private PFJMBDHJHAN GKACEDOEIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006DE")]
	[ONGFANECMJO]
	private EGBDNLKFOBI JHBIIAAOKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006DF")]
	private IJLKKJEHNDK NLOHDONILHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006E0")]
	private NNPCJELMPNE LOLPAIFLNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40006E1")]
	private PDKCPOCMDOL BKPBAEFMAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40006E2")]
	private BCKNEBNOIKL PIILPINNEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40006E3")]
	private EHPPEJBAPGJ OKEFAODCOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40006E4")]
	private LKKINKJNPNA AMPCAJOGADF;

	[Cpp2IlInjected.Token(Token = "0x6000BCB")]
	[Cpp2IlInjected.Address(RVA = "0x28CAA70", Offset = "0x28C9E70", VA = "0x1828CAA70", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCC")]
	[Cpp2IlInjected.Address(RVA = "0x28CAD40", Offset = "0x28CA140", VA = "0x1828CAD40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCD")]
	[Cpp2IlInjected.Address(RVA = "0x28CADD0", Offset = "0x28CA1D0", VA = "0x1828CADD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCE")]
	[Cpp2IlInjected.Address(RVA = "0x28CA9A0", Offset = "0x28C9DA0", VA = "0x1828CA9A0")]
	private void BMMLFNHIPEJ(out NativeArray<CMFFIMLEPBE> LMKFIAKIJAP, out NativeArray<EFFOMHNHCBO> JONOBDJBMLJ, out NativeArray<CMFFIMLEPBE> KNDKMEFEGCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCF")]
	[Cpp2IlInjected.Address(RVA = "0x28CADC0", Offset = "0x28CA1C0", VA = "0x1828CADC0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD0")]
	[Cpp2IlInjected.Address(RVA = "0x28CADB0", Offset = "0x28CA1B0", VA = "0x1828CADB0", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD1")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public EOLDLAAGOPC()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000215")]
	[CompilerGenerated]
	[HONNCCIFPDK(CAGOEBHGGNL.OMRoom)]
	public class PostLoadInitializeNetworkId : JKIEMPJPHGI, AKFIPDJCCOH
	{
		[Cpp2IlInjected.Token(Token = "0x2000216")]
		[BurstCompile]
		[NoAlias]
		private struct PostLoadInitializeNetworkId_LambdaJob_0_Job : IJobEntityBatchWithIndex
		{
			[Cpp2IlInjected.Token(Token = "0x2000217")]
			public delegate void RunWithoutJobSystem_00000DE1$PostfixBurstDelegate(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x2000218")]
			internal static class RunWithoutJobSystem_00000DE1$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x40006FC")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x40006FD")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x6000BEC")]
				[Cpp2IlInjected.Address(RVA = "0x3DEB900", Offset = "0x3DEAD00", VA = "0x183DEB900")]
				[BurstDiscard]
				private static void BPOGIOPNKPI(ref IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000BED")]
				[Cpp2IlInjected.Address(RVA = "0x3DEBD50", Offset = "0x3DEB150", VA = "0x183DEBD50")]
				private static IntPtr OGEDALIJNIF()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000BEE")]
				[Cpp2IlInjected.Address(RVA = "0x3DEBC90", Offset = "0x3DEB090", VA = "0x183DEBC90")]
				public static void JEJODENPHGJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000BEF")]
				[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
				public static void BEFDPLAELIH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000BF1")]
				[Cpp2IlInjected.Address(RVA = "0x3DEBA50", Offset = "0x3DEAE50", VA = "0x183DEBA50")]
				public static void GDOLIKHHLHI(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40006F5")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x40006F6")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006F7")]
			public NativeParallelHashMap<CMFFIMLEPBE, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006F8")]
			public uint playerId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006F9")]
			public uint offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006FA")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40006FB")]
			public ComponentTypeHandle<PCCFEGNEHCE> __dstValueTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000BE4")]
			[Cpp2IlInjected.Address(RVA = "0x3DE8BE0", Offset = "0x3DE7FE0", VA = "0x183DE8BE0")]
			private void EJBLFCAPFKM(Entity entity, int entityInQueryIndex, [NoAlias] ref PCCFEGNEHCE dstValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BE5")]
			[Cpp2IlInjected.Address(RVA = "0x3DE8C70", Offset = "0x3DE8070", VA = "0x183DE8C70", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex, int indexOfFirstEntityInQuery)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BE6")]
			[Cpp2IlInjected.Address(RVA = "0x3DE8B70", Offset = "0x3DE7F70", VA = "0x183DE8B70")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void CFNDGCJBDDN(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BE7")]
			[Cpp2IlInjected.Address(RVA = "0x3DE8DB0", Offset = "0x3DE81B0", VA = "0x183DE8DB0")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void HFPJMCLHCIA(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000219")]
		[NoAlias]
		[BurstCompile]
		private struct PostLoadInitializeNetworkId_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.Token(Token = "0x200021A")]
			public delegate void RunWithoutJobSystem_00000DE4$PostfixBurstDelegate(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x200021B")]
			internal static class RunWithoutJobSystem_00000DE4$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x4000704")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x4000705")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x6000BFA")]
				[Cpp2IlInjected.Address(RVA = "0x3DEC160", Offset = "0x3DEB560", VA = "0x183DEC160")]
				[BurstDiscard]
				private static void BPOGIOPNKPI(ref IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000BFB")]
				[Cpp2IlInjected.Address(RVA = "0x3DEC5B0", Offset = "0x3DEB9B0", VA = "0x183DEC5B0")]
				private static IntPtr OGEDALIJNIF()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000BFC")]
				[Cpp2IlInjected.Address(RVA = "0x3DEC4F0", Offset = "0x3DEB8F0", VA = "0x183DEC4F0")]
				public static void JEJODENPHGJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000BFD")]
				[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
				public static void BEFDPLAELIH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000BFF")]
				[Cpp2IlInjected.Address(RVA = "0x3DEC2B0", Offset = "0x3DEB6B0", VA = "0x183DEC2B0")]
				public static void GDOLIKHHLHI(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40006FE")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x40006FF")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000700")]
			public NativeParallelHashMap<CMFFIMLEPBE, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000701")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000702")]
			public ComponentTypeHandle<PCCFEGNEHCE> __dstValueTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000703")]
			[ReadOnly]
			public ComponentTypeHandle<OverrideObjectNetworkIdData> __srcValueTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000BF2")]
			[Cpp2IlInjected.Address(RVA = "0x3DE8EA0", Offset = "0x3DE82A0", VA = "0x183DE8EA0")]
			private void EJBLFCAPFKM(Entity entity, [NoAlias] ref PCCFEGNEHCE dstValue, [NoAlias] in OverrideObjectNetworkIdData srcValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BF3")]
			[Cpp2IlInjected.Address(RVA = "0x3DE8F40", Offset = "0x3DE8340", VA = "0x183DE8F40", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BF4")]
			[Cpp2IlInjected.Address(RVA = "0x3DE8E30", Offset = "0x3DE8230", VA = "0x183DE8E30")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void CFNDGCJBDDN(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BF5")]
			[Cpp2IlInjected.Address(RVA = "0x3DE90E0", Offset = "0x3DE84E0", VA = "0x183DE90E0")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void HFPJMCLHCIA(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200021C")]
		private struct PostLoadInitializeNetworkId_LambdaJob_2_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000706")]
			public NativeParallelHashMap<CMFFIMLEPBE, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000707")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000708")]
			[ReadOnly]
			public ComponentTypeHandle<OverrideObjectNetworkIdData> __srcValueTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000C00")]
			[Cpp2IlInjected.Address(RVA = "0x3DE9160", Offset = "0x3DE8560", VA = "0x183DE9160")]
			private void EJBLFCAPFKM(Entity entity, in OverrideObjectNetworkIdData srcValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C01")]
			[Cpp2IlInjected.Address(RVA = "0x3DE9290", Offset = "0x3DE8690", VA = "0x183DE9290", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		public static readonly PILIJFIMAJF log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		[ONGFANECMJO]
		private CIEAPPOCDCN networkToLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		[ONGFANECMJO]
		private NLLKOIOEBHH scenes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		private EntityQuery queryAllInScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		private EntityQuery queryAllInActiveRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		private EntityQuery additiveQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		private EntityQuery PostLoadInitializeNetworkId_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		private EntityQuery PostLoadInitializeNetworkId_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		private EntityQuery PostLoadInitializeNetworkId_LambdaJob_2_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		private EntityQuery __query_3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		private ComponentTypeHandle<PCCFEGNEHCE> __RecRoom_Components_ObjectNetworkIdComponentData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		private ComponentTypeHandle<OverrideObjectNetworkIdData> __RecRoom_Components_OverrideObjectNetworkIdData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000BD2")]
		[Cpp2IlInjected.Address(RVA = "0x223C530", Offset = "0x223B930", VA = "0x18223C530", Slot = "14")]
		public void InitReferences(EMFBCBAOENA services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD3")]
		[Cpp2IlInjected.Address(RVA = "0x223D830", Offset = "0x223CC30", VA = "0x18223D830", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD4")]
		[Cpp2IlInjected.Address(RVA = "0x223D960", Offset = "0x223CD60", VA = "0x18223D960", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD5")]
		[Cpp2IlInjected.Address(RVA = "0x223DBC0", Offset = "0x223CFC0", VA = "0x18223DBC0")]
		public void PFBKJKJKMID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0x223CAE0", Offset = "0x223BEE0", VA = "0x18223CAE0")]
		private void LBJGIEIPDDP(NativeParallelHashMap<CMFFIMLEPBE, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x223C750", Offset = "0x223BB50", VA = "0x18223C750")]
		private void LANGALADKDE(NativeParallelHashMap<CMFFIMLEPBE, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD8")]
		[Cpp2IlInjected.Address(RVA = "0x223C310", Offset = "0x223B710", VA = "0x18223C310")]
		private void GDHDPONKJIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x223BFA0", Offset = "0x223B3A0", VA = "0x18223BFA0")]
		private void BAPCCOKOOCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0x223C120", Offset = "0x223B520", VA = "0x18223C120")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void CLKAGIEOFBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDB")]
		[Cpp2IlInjected.Address(RVA = "0x223CFB0", Offset = "0x223C3B0", VA = "0x18223CFB0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void MNIMJCFAHBK(NativeParallelHashMap<CMFFIMLEPBE, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x223C5F0", Offset = "0x223B9F0", VA = "0x18223C5F0")]
		private void KPGODGHGFFA(ref NativeParallelHashMap<CMFFIMLEPBE, Entity> map, ref uint playerId, ref uint offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x223C140", Offset = "0x223B540", VA = "0x18223C140")]
		private void EIJCHFLDNFB(ref NativeParallelHashMap<CMFFIMLEPBE, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x223BEA0", Offset = "0x223B2A0", VA = "0x18223BEA0")]
		private void AFPMKGLNKPK(ref NativeParallelHashMap<CMFFIMLEPBE, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDF")]
		[Cpp2IlInjected.Address(RVA = "0x223D0A0", Offset = "0x223C4A0", VA = "0x18223D0A0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE0")]
		[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
		public PostLoadInitializeNetworkId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE2")]
		[Cpp2IlInjected.Address(RVA = "0x223C5A0", Offset = "0x223B9A0", VA = "0x18223C5A0")]
		public static void JFOGDPDFPFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE3")]
		[Cpp2IlInjected.Address(RVA = "0x223C2C0", Offset = "0x223B6C0", VA = "0x18223C2C0")]
		public static void FMMGGOAMNMH()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200021D")]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
internal class BHHNOJLFKLE : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x4000709")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400070A")]
	private EntityQuery PFDLDKIHEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400070B")]
	private BKIGCJIBBEC JFEIOACDBLI;

	[Cpp2IlInjected.Token(Token = "0x6000C02")]
	[Cpp2IlInjected.Address(RVA = "0x25137D0", Offset = "0x2512BD0", VA = "0x1825137D0", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C03")]
	[Cpp2IlInjected.Address(RVA = "0x2513820", Offset = "0x2512C20", VA = "0x182513820", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C04")]
	[Cpp2IlInjected.Address(RVA = "0x25138D0", Offset = "0x2512CD0", VA = "0x1825138D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C05")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public BHHNOJLFKLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200021E")]
[JOCOBGMDOKK(CAGOEBHGGNL.PhotonRoom)]
[EFDJEPLIMOC(typeof(OBMMBDFHEPO), new string[] { })]
internal class KOJIGIFHELH : AKFIPDJCCOH, OBMMBDFHEPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400070C")]
	[ONGFANECMJO]
	private PFJMBDHJHAN BDLCNPMEDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400070D")]
	[ONGFANECMJO]
	private NLLKOIOEBHH FLAALGKHIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400070E")]
	private readonly Dictionary<int, Entity> BAABPBAPDCJ;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private EntityManager FCLKPLIBOOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000C07")]
		[Cpp2IlInjected.Address(RVA = "0x2896A00", Offset = "0x2895E00", VA = "0x182896A00")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C08")]
	[Cpp2IlInjected.Address(RVA = "0x28967E0", Offset = "0x2895BE0", VA = "0x1828967E0", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C09")]
	[Cpp2IlInjected.Address(RVA = "0x2896870", Offset = "0x2895C70", VA = "0x182896870", Slot = "5")]
	public void MLDMMDFLOBL(KDLENLDMBAK LCODCOPGHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C0A")]
	[Cpp2IlInjected.Address(RVA = "0x2896520", Offset = "0x2895920", VA = "0x182896520", Slot = "6")]
	public bool AACDFIMAHAA(KDLENLDMBAK LCODCOPGHJA, Transform FELEGEFPADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C0B")]
	[Cpp2IlInjected.Address(RVA = "0x2896770", Offset = "0x2895B70", VA = "0x182896770")]
	private bool FIIOLFNOPFK(Scene EOOPPEEEACO, out Entity KKDCPJNPLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C0C")]
	[Cpp2IlInjected.Address(RVA = "0x2896A50", Offset = "0x2895E50", VA = "0x182896A50")]
	public KOJIGIFHELH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200021F")]
public class DAKBPBOEHDH : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400070F")]
	[ONGFANECMJO]
	private EGBDNLKFOBI NOPMCNMGBLD;

	[Cpp2IlInjected.Token(Token = "0x6000C0D")]
	[Cpp2IlInjected.Address(RVA = "0x2520000", Offset = "0x251F400", VA = "0x182520000", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C0E")]
	[Cpp2IlInjected.Address(RVA = "0x2520050", Offset = "0x251F450", VA = "0x182520050", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C0F")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public DAKBPBOEHDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000220")]
public abstract class ICBEHEHALDJ : JKIEMPJPHGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000710")]
	private EntityQuery PNGFJEAJDGO;

	[Cpp2IlInjected.Token(Token = "0x6000C10")]
	[Cpp2IlInjected.Address(Slot = "14")]
	protected abstract EntityCommandBufferSystem KMBJDEEDCKH();

	[Cpp2IlInjected.Token(Token = "0x6000C11")]
	[Cpp2IlInjected.Address(RVA = "0x287C580", Offset = "0x287B980", VA = "0x18287C580", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C12")]
	[Cpp2IlInjected.Address(RVA = "0x287C610", Offset = "0x287BA10", VA = "0x18287C610", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C13")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	protected ICBEHEHALDJ()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000221")]
public struct JBCAOAIOODF : HJDFDEAFANN<ELLKBCJMOKK>
{
	[Cpp2IlInjected.Token(Token = "0x6000C14")]
	[Cpp2IlInjected.Address(RVA = "0x2887550", Offset = "0x2886950", VA = "0x182887550", Slot = "4")]
	public bool LBAEOOMNBFE(ELLKBCJMOKK KKIAKNLLHIO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000222")]
public static class DNDMCJKECOH
{
	[Cpp2IlInjected.Token(Token = "0x6000C15")]
	[Cpp2IlInjected.Address(RVA = "0x2526560", Offset = "0x2525960", VA = "0x182526560")]
	public static NativeParallelHashSet<int> AFPIHHKKIIJ(EntityManager GLPCEPPDPLB, Allocator GMMIODGPFPJ)
	{
		return default(NativeParallelHashSet<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C16")]
	[Cpp2IlInjected.Address(RVA = "0x2526A80", Offset = "0x2525E80", VA = "0x182526A80")]
	public static NativeParallelHashMap<int, int> NJLJLAAINKJ(EntityManager GLPCEPPDPLB, Allocator GMMIODGPFPJ)
	{
		return default(NativeParallelHashMap<int, int>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000223")]
internal readonly struct IJLKKJEHNDK
{
	[Cpp2IlInjected.Token(Token = "0x4000711")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.Token(Token = "0x4000712")]
	private static readonly ProfilerMarker EFGOHNJJAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000713")]
	private readonly JKIEMPJPHGI JJBAHIPIPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000714")]
	private readonly World GLMOAKNBFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000715")]
	private readonly EntityQuery PNGFJEAJDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000716")]
	private readonly EntityQuery OLIEJLGFIPN;

	[Cpp2IlInjected.Token(Token = "0x6000C17")]
	[Cpp2IlInjected.Address(RVA = "0x2886270", Offset = "0x2885670", VA = "0x182886270")]
	public IJLKKJEHNDK(JKIEMPJPHGI JJBAHIPIPHK, World GLMOAKNBFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C18")]
	[Cpp2IlInjected.Address(RVA = "0x2885C90", Offset = "0x2885090", VA = "0x182885C90")]
	public (NativeArray<CMFFIMLEPBE>, NativeArray<EFFOMHNHCBO>) COCGDBGCNKP()
	{
		return default((NativeArray<CMFFIMLEPBE>, NativeArray<EFFOMHNHCBO>));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000224")]
internal interface PGBPMCLMNHE
{
	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	bool HFDMAKGHOFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000C1A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	NativeArray<CMFFIMLEPBE> AHPALJJJCJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000C1B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	NativeArray<EFFOMHNHCBO> ABAFOJNAOMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000C1C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	NativeArray<CMFFIMLEPBE> OCADKODJFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000C1D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MGDDHJINDHM(out NativeArray<int> NFJAHCFFAKM, Allocator GMMIODGPFPJ);

	[Cpp2IlInjected.Token(Token = "0x6000C1F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NMGOCMPCDME(ComponentType IJBDFBDGHPH, out KAKBNCDEGLG PPJPLFACPBB, out GPAHDFKBGLB CNFPICPCCAE);

	[Cpp2IlInjected.Token(Token = "0x6000C20")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeMultiHashMapAsync<Entity, ELGEKKCACLJ> EDPOHAJOANI();
}
[Cpp2IlInjected.Token(Token = "0x2000225")]
internal static class KKAFAPKLMLC
{
	[Cpp2IlInjected.Token(Token = "0x6000C21")]
	[Cpp2IlInjected.Address(RVA = "0x2892C20", Offset = "0x2892020", VA = "0x182892C20")]
	public static bool JFMHMLHFLCB(this PGBPMCLMNHE PJAFLHHFBPC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000226")]
[EFDJEPLIMOC(typeof(IJNHJLKNADD), new string[] { })]
public sealed class HKMKIDBMMEK : IJNHJLKNADD, AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x2000227")]
	[BurstCompile]
	private struct HKDNLOPEDKA : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		[ReadOnly]
		public NativeArray<Entity> PGJLMFPAKDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		[ReadOnly]
		public float3 PLLEGPFDNGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		[ReadOnly]
		public float3 GPFPINPLOFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		[ReadOnly]
		public ComponentDataFromEntity<ELLKBCJMOKK> AJJANKJJJCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		[ReadOnly]
		public ComponentDataFromEntity<BOIDEJCAFGI> BPDBKMDPNBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> NOBDGFENFJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		[ReadOnly]
		public ComponentDataFromEntity<NGCCGHIFCBM> JEHKNIADNCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		[ReadOnly]
		public ComponentDataFromEntity<DIAHLMCFEAG> BCOCIOIPFOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		[WriteOnly]
		public NativeArray<BMJAGFBFJOH> PCAAPMMDMLM;

		[Cpp2IlInjected.Token(Token = "0x4000721")]
		private static readonly BMJAGFBFJOH FPELDAIINAI;

		[Cpp2IlInjected.Token(Token = "0x6000C26")]
		[Cpp2IlInjected.Address(RVA = "0x270FC70", Offset = "0x270F070", VA = "0x18270FC70", Slot = "4")]
		public void Execute(int NANJAGEOPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C27")]
		[Cpp2IlInjected.Address(RVA = "0x2710500", Offset = "0x270F900", VA = "0x182710500")]
		private static float3 JDAEJDLAMCK(in float4x4 IOPDIGKHGJO, in float3 FJMJPHIILFN)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C28")]
		[Cpp2IlInjected.Address(RVA = "0x2710070", Offset = "0x270F470", VA = "0x182710070")]
		private static float3 GENMCEBGHIG(in float4x4 IOPDIGKHGJO, in float3 GOFPOLBMIKB)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C29")]
		[Cpp2IlInjected.Address(RVA = "0x270FF60", Offset = "0x270F360", VA = "0x18270FF60")]
		private static float3 GCBJKOINPIC(in float4x4 IOPDIGKHGJO, in float3 FJMJPHIILFN)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2A")]
		[Cpp2IlInjected.Address(RVA = "0x270FAA0", Offset = "0x270EEA0", VA = "0x18270FAA0")]
		private static float3 BONBGDIPEDJ(in float4x4 IOPDIGKHGJO, in float3 GOFPOLBMIKB)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2B")]
		[Cpp2IlInjected.Address(RVA = "0x27101E0", Offset = "0x270F5E0", VA = "0x1827101E0")]
		private bool IEKDFPGNEAP(in float3 OCPINBDMADB, in float3 KDLMOBCGODE, in NativeArray<Entity> BIGKDLMNOCM, out float3 LGKDBFIOHEG, out float3 LHLKLIEJLPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2C")]
		[Cpp2IlInjected.Address(RVA = "0x270F440", Offset = "0x270E840", VA = "0x18270F440")]
		public static bool AHPKAMIHAGF(in float3 PLLOKICEEHG, in float3 MIIHHEEPAHA, in float3 EBJOECCCCFN, in float3 FLNNEAAEEHI, float DEODOOIBMKB, float KLHBDGFDIBK, out float CECLOGMADIP, out float3 ALOJIBNKIDG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000717")]
	private EntityManager GLPCEPPDPLB;

	[Cpp2IlInjected.Token(Token = "0x6000C22")]
	[Cpp2IlInjected.Address(RVA = "0x287BB50", Offset = "0x287AF50", VA = "0x18287BB50", Slot = "5")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C23")]
	[Cpp2IlInjected.Address(RVA = "0x287BBD0", Offset = "0x287AFD0", VA = "0x18287BBD0")]
	public void LJCJBGODPCK(in NativeArray<Entity> PGJLMFPAKDA, in float3 OCPINBDMADB, in float3 KDLMOBCGODE, in NativeArray<BMJAGFBFJOH> PKCFIPFALAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C24")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public HKMKIDBMMEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C25")]
	[Cpp2IlInjected.Address(RVA = "0x287BB40", Offset = "0x287AF40", VA = "0x18287BB40", Slot = "4")]
	private void EEOJMFIMDLM(in NativeArray<Entity> PGJLMFPAKDA, in float3 OCPINBDMADB, in float3 KDLMOBCGODE, in NativeArray<BMJAGFBFJOH> PKCFIPFALAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000228")]
[DefaultMember("Item")]
public struct DAAOPGJAJOL<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000722")]
	private T[] KJFNAECAHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000723")]
	private int PGBALNGGNPG;

	[Cpp2IlInjected.Token(Token = "0x6000C2E")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2CD0", Offset = "0x2AF20D0", VA = "0x182AF2CD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000229")]
public struct BEHJCNECJCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000724")]
	public Entity FKNFFDFGNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000725")]
	public Entity KMKEMACKNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000726")]
	public Entity GHLIBENNEBB;

	[Cpp2IlInjected.Token(Token = "0x6000C2F")]
	[Cpp2IlInjected.Address(RVA = "0x2513150", Offset = "0x2512550", VA = "0x182513150")]
	public BEHJCNECJCL(Entity FKNFFDFGNMN, Entity KMKEMACKNKI, Entity GHLIBENNEBB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000C30")]
	[Cpp2IlInjected.Address(RVA = "0x2513110", Offset = "0x2512510", VA = "0x182513110")]
	public static BEHJCNECJCL PGDDHPNABOB((Entity entity, Entity oldParent, Entity newParent) OFOCCDIGAPO)
	{
		return default(BEHJCNECJCL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C31")]
	[Cpp2IlInjected.Address(RVA = "0x25130F0", Offset = "0x25124F0", VA = "0x1825130F0")]
	public void IAFKAHLPOAN(out Entity FKNFFDFGNMN, out Entity KMKEMACKNKI, out Entity GHLIBENNEBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022A")]
public class POJKEFGPOBP : JKIEMPJPHGI
{
	[Cpp2IlInjected.Token(Token = "0x4000727")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000728")]
	private EntityQuery PNGFJEAJDGO;

	[Cpp2IlInjected.Token(Token = "0x6000C32")]
	[Cpp2IlInjected.Address(RVA = "0x2235D60", Offset = "0x2235160", VA = "0x182235D60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C33")]
	[Cpp2IlInjected.Address(RVA = "0x2235E10", Offset = "0x2235210", VA = "0x182235E10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C34")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public POJKEFGPOBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022B")]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
internal class IDIBGBEDHIB : JHKLBCGALML<GCNILGBAOHO>, AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x4000729")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400072A")]
	private AOONNPAOEFB FHJACJEANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400072B")]
	private MBJPBGDNNCH NMPOIKAOLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400072C")]
	private EntityQuery GGGECGOOHKG;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private Entity NDBGGHBJIJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000C36")]
		[Cpp2IlInjected.Address(RVA = "0x287D710", Offset = "0x287CB10", VA = "0x18287D710")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000C37")]
		[Cpp2IlInjected.Address(RVA = "0x287DA30", Offset = "0x287CE30", VA = "0x18287DA30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public KDLENLDMBAK IFBGCOFKNAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000C38")]
		[Cpp2IlInjected.Address(RVA = "0x287DBB0", Offset = "0x287CFB0", VA = "0x18287DBB0")]
		get
		{
			return default(KDLENLDMBAK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000C39")]
		[Cpp2IlInjected.Address(RVA = "0x287D770", Offset = "0x287CB70", VA = "0x18287D770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3A")]
	[Cpp2IlInjected.Address(RVA = "0x287DA90", Offset = "0x287CE90", VA = "0x18287DA90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3B")]
	[Cpp2IlInjected.Address(RVA = "0x287D8B0", Offset = "0x287CCB0", VA = "0x18287D8B0", Slot = "15")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3C")]
	[Cpp2IlInjected.Address(RVA = "0x287DB30", Offset = "0x287CF30", VA = "0x18287DB30", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3D")]
	[Cpp2IlInjected.Address(RVA = "0x287D050", Offset = "0x287C450", VA = "0x18287D050", Slot = "14")]
	protected override void BFMPNCEOKAI(NativeArray<Entity> PGJLMFPAKDA, NativeArray<Entity> ACIJPDFENHE, NativeArray<Entity> EIEGKDOGOIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3E")]
	[Cpp2IlInjected.Address(RVA = "0x287D1B0", Offset = "0x287C5B0", VA = "0x18287D1B0")]
	private void DKLBJLDHLAJ(NativeArray<Entity> PGJLMFPAKDA, NativeArray<Entity> EIEGKDOGOIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3F")]
	[Cpp2IlInjected.Address(RVA = "0x287D290", Offset = "0x287C690", VA = "0x18287D290")]
	private void DLBDAEMHPBH(Entity FKNFFDFGNMN, Entity GCJOMBLCJDH, Entity NLJAGLHMKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C40")]
	[Cpp2IlInjected.Address(RVA = "0x1817160", Offset = "0x1816560", VA = "0x181817160")]
	private bool NALDPHOGDDM<T>(out T KKIAKNLLHIO) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C41")]
	[Cpp2IlInjected.Address(RVA = "0x18170A0", Offset = "0x18164A0", VA = "0x1818170A0")]
	private void JBONFABJGBC<T>(T KKIAKNLLHIO) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C42")]
	[Cpp2IlInjected.Address(RVA = "0x287D920", Offset = "0x287CD20", VA = "0x18287D920")]
	public bool JPJGHMIEAMA(KDLENLDMBAK KODLNCAGOOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C43")]
	[Cpp2IlInjected.Address(RVA = "0x287D820", Offset = "0x287CC20", VA = "0x18287D820")]
	private static bool HMHMIECJFJB(KDLENLDMBAK HODKGENDEJE, KDLENLDMBAK CCIAIHFJBCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C44")]
	[Cpp2IlInjected.Address(RVA = "0x287DCE0", Offset = "0x287D0E0", VA = "0x18287DCE0")]
	public IDIBGBEDHIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022C")]
internal class GALJEHCNOAI : CBHLJLLPMCM
{
	[Cpp2IlInjected.Token(Token = "0x17000152")]
	protected override GBICPCJAFPO OLPAAHHJIKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000C46")]
		[Cpp2IlInjected.Address(RVA = "0x28D4D50", Offset = "0x28D4150", VA = "0x1828D4D50", Slot = "15")]
		get
		{
			return default(GBICPCJAFPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C47")]
	[Cpp2IlInjected.Address(RVA = "0x2885C80", Offset = "0x2885080", VA = "0x182885C80")]
	public GALJEHCNOAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022D")]
public class CMLIICDMNBK : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x400072D")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400072E")]
	[ONGFANECMJO]
	private EGBDNLKFOBI NOPMCNMGBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400072F")]
	[ONGFANECMJO]
	private CIEAPPOCDCN CDJABACJGDG;

	[Cpp2IlInjected.Token(Token = "0x6000C48")]
	[Cpp2IlInjected.Address(RVA = "0x251D170", Offset = "0x251C570", VA = "0x18251D170", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C49")]
	[Cpp2IlInjected.Address(RVA = "0x251D1E0", Offset = "0x251C5E0", VA = "0x18251D1E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4A")]
	[Cpp2IlInjected.Address(RVA = "0x251CC20", Offset = "0x251C020", VA = "0x18251CC20")]
	private void EJDIGECNNKM(NativeArray<CMFFIMLEPBE> IGAJFEHCFIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4B")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public CMLIICDMNBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022E")]
public class GKLDKOMOHOG : JKIEMPJPHGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000730")]
	private EntityQuery CKJIFFCAACP;

	[Cpp2IlInjected.Token(Token = "0x6000C4D")]
	[Cpp2IlInjected.Address(RVA = "0x28D7BA0", Offset = "0x28D6FA0", VA = "0x1828D7BA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4E")]
	[Cpp2IlInjected.Address(RVA = "0x28D7C30", Offset = "0x28D7030", VA = "0x1828D7C30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4F")]
	[Cpp2IlInjected.Address(RVA = "0x28D7B50", Offset = "0x28D6F50", VA = "0x1828D7B50")]
	private EntityCommandBufferSystem EKGEGEFMAIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C50")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public GKLDKOMOHOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022F")]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
internal sealed class IKKGOPOGLFC : HLOJAODEAAM
{
	[Cpp2IlInjected.Token(Token = "0x6000C51")]
	[Cpp2IlInjected.Address(RVA = "0x2886390", Offset = "0x2885790", VA = "0x182886390", Slot = "15")]
	protected override ComponentSystemBase BHJHPJOJPMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C52")]
	[Cpp2IlInjected.Address(RVA = "0x2229A50", Offset = "0x2228E50", VA = "0x182229A50")]
	public IKKGOPOGLFC()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000230")]
	[CompilerGenerated]
	public class PostLoadMoveRootsUnderParent : JKIEMPJPHGI
	{
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		private static readonly PILIJFIMAJF log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0x223DE80", Offset = "0x223D280", VA = "0x18223DE80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0x223DF60", Offset = "0x223D360", VA = "0x18223DF60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0x223DCC0", Offset = "0x223D0C0", VA = "0x18223DCC0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C56")]
		[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
		public PostLoadMoveRootsUnderParent()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000231")]
public struct PEHOAOEGBBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000734")]
	public Entity FKNFFDFGNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000735")]
	public Entity ILDFJHMNOPJ;

	[Cpp2IlInjected.Token(Token = "0x6000C58")]
	[Cpp2IlInjected.Address(RVA = "0x16CEC80", Offset = "0x16CE080", VA = "0x1816CEC80")]
	public PEHOAOEGBBM(Entity FKNFFDFGNMN, Entity ILDFJHMNOPJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000C59")]
	[Cpp2IlInjected.Address(RVA = "0x222F230", Offset = "0x222E630", VA = "0x18222F230")]
	public static PEHOAOEGBBM PGDDHPNABOB((Entity entity, Entity parent) OFOCCDIGAPO)
	{
		return default(PEHOAOEGBBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5A")]
	[Cpp2IlInjected.Address(RVA = "0x222F220", Offset = "0x222E620", VA = "0x18222F220")]
	public void IAFKAHLPOAN(out Entity FKNFFDFGNMN, out Entity ILDFJHMNOPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000232")]
[AlwaysUpdateSystem]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
public class MEGKFKNEBHF : JKIEMPJPHGI, AKFIPDJCCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000736")]
	[ONGFANECMJO]
	private GIAAALCEHCB AMFHONJJCJL;

	[Cpp2IlInjected.Token(Token = "0x6000C5B")]
	[Cpp2IlInjected.Address(RVA = "0x2A65DE0", Offset = "0x2A651E0", VA = "0x182A65DE0", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5C")]
	[Cpp2IlInjected.Address(RVA = "0x2A65E30", Offset = "0x2A65230", VA = "0x182A65E30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5D")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public MEGKFKNEBHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000233")]
[EFDJEPLIMOC(typeof(JCHEPGFOMNF), new string[] { })]
[JOCOBGMDOKK(CAGOEBHGGNL.OMRoom)]
internal sealed class JCHEPGFOMNF : AKFIPDJCCOH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000737")]
	[ONGFANECMJO]
	private PFJMBDHJHAN BDLCNPMEDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000738")]
	private EntityQuery NEILNAJDGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000739")]
	private bool MMLDFGNKLLJ;

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	private EntityManager FCLKPLIBOOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000C5E")]
		[Cpp2IlInjected.Address(RVA = "0x28881C0", Offset = "0x28875C0", VA = "0x1828881C0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5F")]
	[Cpp2IlInjected.Address(RVA = "0x2887E20", Offset = "0x2887220", VA = "0x182887E20", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C60")]
	[Cpp2IlInjected.Address(RVA = "0x2887D50", Offset = "0x2887150", VA = "0x182887D50", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C61")]
	[Cpp2IlInjected.Address(RVA = "0x2888100", Offset = "0x2887500", VA = "0x182888100")]
	public bool OFOEOMJNIKA(Entity FKNFFDFGNMN, Entity MODHKGGCBAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C62")]
	[Cpp2IlInjected.Address(RVA = "0x2887F70", Offset = "0x2887370", VA = "0x182887F70")]
	public bool MGKPNBNCMAF(Entity FKNFFDFGNMN, Entity BHKMKEODELA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C63")]
	[Cpp2IlInjected.Address(RVA = "0x2887D70", Offset = "0x2887170", VA = "0x182887D70")]
	public Entity HIJCLBEKBJN(Entity FKNFFDFGNMN)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C64")]
	[Cpp2IlInjected.Address(RVA = "0x2887F20", Offset = "0x2887320", VA = "0x182887F20")]
	public NativeArray<Entity> JBEEHEFECLP()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C65")]
	[Cpp2IlInjected.Address(RVA = "0x2888030", Offset = "0x2887430", VA = "0x182888030")]
	public bool NECHJOFNONE(Entity GDNOLIODDHJ, Entity NNMGPKBMOKD, out Entity DCAFPIJMBKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C66")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public JCHEPGFOMNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000234")]
internal interface KNHBDNEIEIA
{
	[Cpp2IlInjected.Token(Token = "0x17000154")]
	World DFKBAKJLNEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000C67")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	World DIMECBCAKBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000C68")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	IJEMANMGDHA CLGMHJGDFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000C69")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	uint COFHBFKJOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000C6A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	bool MPIAMCJMFLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000C6C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000235")]
	[CompilerGenerated]
	internal class PostDeserializeAddSplinePointsToSplines : JKIEMPJPHGI
	{
		[Cpp2IlInjected.Token(Token = "0x2000236")]
		[BurstCompile]
		[NoAlias]
		private struct PostDeserializeAddSplinePointsToSplines_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400073E")]
			public EntityCommandBuffer cb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400073F")]
			[ReadOnly]
			public EntityTypeHandle __splineTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000C74")]
			[Cpp2IlInjected.Address(RVA = "0x3DE7060", Offset = "0x3DE6460", VA = "0x183DE7060")]
			private void EJBLFCAPFKM(Entity spline)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C75")]
			[Cpp2IlInjected.Address(RVA = "0x3DE70F0", Offset = "0x3DE64F0", VA = "0x183DE70F0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000237")]
		[NoAlias]
		[BurstCompile]
		private struct PostDeserializeAddSplinePointsToSplines_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000740")]
			public EntityCommandBuffer cb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000741")]
			[ReadOnly]
			public EntityTypeHandle __splinePointTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000742")]
			[ReadOnly]
			public ComponentTypeHandle<OCGHCEBJNGN> __splinePointParentDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000C76")]
			[Cpp2IlInjected.Address(RVA = "0x3DE71A0", Offset = "0x3DE65A0", VA = "0x183DE71A0")]
			private void EJBLFCAPFKM(Entity splinePoint, [NoAlias] in OCGHCEBJNGN splinePointParentData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C77")]
			[Cpp2IlInjected.Address(RVA = "0x3DE7230", Offset = "0x3DE6630", VA = "0x183DE7230", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		private EntityQuery PostDeserializeAddSplinePointsToSplines_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		private EntityQuery PostDeserializeAddSplinePointsToSplines_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		private ComponentTypeHandle<OCGHCEBJNGN> __RecRoom_Components_SplinePointParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000C6D")]
		[Cpp2IlInjected.Address(RVA = "0x22370E0", Offset = "0x22364E0", VA = "0x1822370E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0x2237190", Offset = "0x2236590", VA = "0x182237190", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(RVA = "0x2236D40", Offset = "0x2236140", VA = "0x182236D40")]
		private EntityCommandBufferSystem KMBJDEEDCKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C70")]
		[Cpp2IlInjected.Address(RVA = "0x2236AF0", Offset = "0x2235EF0", VA = "0x182236AF0")]
		private void CJMNMMFIGDO(EntityCommandBuffer cb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C71")]
		[Cpp2IlInjected.Address(RVA = "0x2236BF0", Offset = "0x2235FF0", VA = "0x182236BF0")]
		private void FKBAEICAFOD(EntityCommandBuffer cb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C72")]
		[Cpp2IlInjected.Address(RVA = "0x2236D90", Offset = "0x2236190", VA = "0x182236D90", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C73")]
		[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
		public PostDeserializeAddSplinePointsToSplines()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000238")]
	[CompilerGenerated]
	[AlwaysUpdateSystem]
	[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
	public class UpdateSplineGameCollidersSystem : JKIEMPJPHGI, AKFIPDJCCOH
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000239")]
		public struct SplineGameCollisionSystemTag : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200023A")]
		private struct ProcessCollisionModeChangesForSplineGameCollision_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000750")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000751")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000752")]
			[ReadOnly]
			public ComponentDataFromEntity<JFIGADANBCE> splineComponentAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000753")]
			[ReadOnly]
			public ComponentDataFromEntity<SplineGameCollisionSystemTag> systemStateAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000754")]
			[ReadOnly]
			public ComponentTypeHandle<NABKNKHLMPP> __collisionModeTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000755")]
			public BufferTypeHandle<OOENBAEOKLI> __childrenTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000C86")]
			[Cpp2IlInjected.Address(RVA = "0x3DE9D10", Offset = "0x3DE9110", VA = "0x183DE9D10")]
			private void EJBLFCAPFKM(in NABKNKHLMPP collisionMode, DynamicBuffer<OOENBAEOKLI> children)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C87")]
			[Cpp2IlInjected.Address(RVA = "0x3DEA060", Offset = "0x3DE9460", VA = "0x183DEA060", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200023B")]
		private struct ProcessActiveSplineReparentsForGameCollision_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000756")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000757")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000758")]
			[ReadOnly]
			public ComponentDataFromEntity<NABKNKHLMPP> containerCollisionModeAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000759")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400075A")]
			[ReadOnly]
			public ComponentTypeHandle<ELLKBCJMOKK> __parentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000C88")]
			[Cpp2IlInjected.Address(RVA = "0x3DE9B30", Offset = "0x3DE8F30", VA = "0x183DE9B30")]
			private void EJBLFCAPFKM(Entity entity, in ELLKBCJMOKK parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C89")]
			[Cpp2IlInjected.Address(RVA = "0x3DE9BF0", Offset = "0x3DE8FF0", VA = "0x183DE9BF0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200023C")]
		private struct ProcessInactiveSplineReparentsForGameCollision_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400075B")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400075C")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400075D")]
			[ReadOnly]
			public ComponentDataFromEntity<NABKNKHLMPP> containerCollisionModeAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400075E")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400075F")]
			[ReadOnly]
			public ComponentTypeHandle<ELLKBCJMOKK> __parentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000C8A")]
			[Cpp2IlInjected.Address(RVA = "0x3DEA1D0", Offset = "0x3DE95D0", VA = "0x183DEA1D0")]
			private void EJBLFCAPFKM(Entity entity, in ELLKBCJMOKK parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C8B")]
			[Cpp2IlInjected.Address(RVA = "0x3DEA280", Offset = "0x3DE9680", VA = "0x183DEA280", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200023D")]
		private struct UpdateSplineGameCollidersSystem_LambdaJob_3_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000760")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000761")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000762")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000C8C")]
			[Cpp2IlInjected.Address(RVA = "0x3DEDD70", Offset = "0x3DED170", VA = "0x183DEDD70")]
			private void EJBLFCAPFKM(Entity entity)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C8D")]
			[Cpp2IlInjected.Address(RVA = "0x3DEDDF0", Offset = "0x3DED1F0", VA = "0x183DEDDF0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200023E")]
		private struct ProcessSplineEditsForGameCollision_Job : IJob
		{
			[Cpp2IlInjected.Token(Token = "0x4000763")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000764")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000765")]
			[ReadOnly]
			public ComponentTypeHandle<OCGHCEBJNGN> splinePointParentHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000766")]
			[ReadOnly]
			public EntityTypeHandle entityHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000767")]
			[ReadOnly]
			public ComponentDataFromEntity<SplineGameCollisionSystemTag> systemTagAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000768")]
			public EntityQueryInJob splinePointEditedQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000769")]
			public EntityQueryInJob splineStructureChangedQueryInJob;

			[Cpp2IlInjected.Token(Token = "0x6000C8E")]
			[Cpp2IlInjected.Address(RVA = "0x3DEA400", Offset = "0x3DE9800", VA = "0x183DEA400")]
			private void EJBLFCAPFKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C8F")]
			[Cpp2IlInjected.Address(RVA = "0x3DEA970", Offset = "0x3DE9D70", VA = "0x183DEA970", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C90")]
			[Cpp2IlInjected.Address(RVA = "0x3DEA3A0", Offset = "0x3DE97A0", VA = "0x183DEA3A0")]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void CFNDGCJBDDN(IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		private KGIPPHJNDDF splineCollisionService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		private EntityQuery collisionModeChangeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		private EntityQuery activeSplineReparentedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		private EntityQuery inactiveSplineReparentedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000747")]
		private EntityQuery splinePointEditedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		private EntityQuery splineStructureChangedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000749")]
		private EntityQuery splinesDeletedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400074A")]
		private EntityQuery ProcessCollisionModeChangesForSplineGameCollision_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400074B")]
		private EntityQuery ProcessActiveSplineReparentsForGameCollision_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400074C")]
		private EntityQuery ProcessInactiveSplineReparentsForGameCollision_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400074D")]
		private EntityQuery UpdateSplineGameCollidersSystem_LambdaJob_3_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		private ComponentTypeHandle<NABKNKHLMPP> __RecRoom_Components_ContainerCollisionModeData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		private ComponentTypeHandle<ELLKBCJMOKK> __RecRoom_Components_ParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(RVA = "0x2717B80", Offset = "0x2716F80", VA = "0x182717B80", Slot = "14")]
		public void InitReferences(EMFBCBAOENA services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C79")]
		[Cpp2IlInjected.Address(RVA = "0x2718C00", Offset = "0x2718000", VA = "0x182718C00", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0x2718DD0", Offset = "0x27181D0", VA = "0x182718DD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7B")]
		[Cpp2IlInjected.Address(RVA = "0x2717BD0", Offset = "0x2716FD0", VA = "0x182717BD0")]
		private void JEPIDHIIMAC(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7C")]
		[Cpp2IlInjected.Address(RVA = "0x2717FA0", Offset = "0x27173A0", VA = "0x182717FA0")]
		private void NLIBPCDIKEG(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7D")]
		[Cpp2IlInjected.Address(RVA = "0x2717DF0", Offset = "0x27171F0", VA = "0x182717DF0")]
		private void KDHADPHBPHH(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7E")]
		[Cpp2IlInjected.Address(RVA = "0x2717A90", Offset = "0x2716E90", VA = "0x182717A90")]
		private void IDJEHNJHDGL(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7F")]
		[Cpp2IlInjected.Address(RVA = "0x2717730", Offset = "0x2716B30", VA = "0x182717730")]
		private void HLNNBIJBOPF(ref EntityCommandBuffer ecb, ref ComponentDataFromEntity<JFIGADANBCE> splineComponentAccess, ref ComponentDataFromEntity<SplineGameCollisionSystemTag> systemStateAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C80")]
		[Cpp2IlInjected.Address(RVA = "0x2717920", Offset = "0x2716D20", VA = "0x182717920")]
		private void ICCAPDGGKFH(ref EntityCommandBuffer ecb, ref ComponentDataFromEntity<NABKNKHLMPP> containerCollisionModeAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C81")]
		[Cpp2IlInjected.Address(RVA = "0x27175C0", Offset = "0x27169C0", VA = "0x1827175C0")]
		private void AAGPCOJCKKB(ref EntityCommandBuffer ecb, ref ComponentDataFromEntity<NABKNKHLMPP> containerCollisionModeAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C82")]
		[Cpp2IlInjected.Address(RVA = "0x2718260", Offset = "0x2717660", VA = "0x182718260")]
		private void OFMKNIKEDCE(ref EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C83")]
		[Cpp2IlInjected.Address(RVA = "0x2719540", Offset = "0x2718940", VA = "0x182719540")]
		private void PFAKHEGANMM(ref ComponentTypeHandle<OCGHCEBJNGN> splinePointParentHandle, ref EntityTypeHandle entityHandle, ref ComponentDataFromEntity<SplineGameCollisionSystemTag> systemTagAccess, ref EntityQueryInJob splinePointEditedQueryInJob, ref EntityQueryInJob splineStructureChangedQueryInJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C84")]
		[Cpp2IlInjected.Address(RVA = "0x2718350", Offset = "0x2717750", VA = "0x182718350", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C85")]
		[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
		public UpdateSplineGameCollidersSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200023F")]
public sealed class POHLMMKHCAJ : HLOJAODEAAM
{
	[Cpp2IlInjected.Token(Token = "0x6000C91")]
	[Cpp2IlInjected.Address(RVA = "0x2235630", Offset = "0x2234A30", VA = "0x182235630", Slot = "15")]
	protected override ComponentSystemBase BHJHPJOJPMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C92")]
	[Cpp2IlInjected.Address(RVA = "0x2229A50", Offset = "0x2228E50", VA = "0x182229A50")]
	public POHLMMKHCAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000240")]
[ExecuteAlways]
public class LNDEIBPDLBO : KMPGAAGIPLF
{
	[Cpp2IlInjected.Token(Token = "0x6000C93")]
	[Cpp2IlInjected.Address(RVA = "0xD17B50", Offset = "0xD16F50", VA = "0x180D17B50")]
	public LNDEIBPDLBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000241")]
public sealed class PLCLCKOPAPE : HLOJAODEAAM
{
	[Cpp2IlInjected.Token(Token = "0x6000C94")]
	[Cpp2IlInjected.Address(RVA = "0x22350C0", Offset = "0x22344C0", VA = "0x1822350C0", Slot = "15")]
	protected override ComponentSystemBase BHJHPJOJPMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C95")]
	[Cpp2IlInjected.Address(RVA = "0x2229A50", Offset = "0x2228E50", VA = "0x182229A50")]
	public PLCLCKOPAPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000242")]
public class AOEBAHNIKAK : KBODFINGEBH, AKFIPDJCCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400076A")]
	private NLLKOIOEBHH JJBMHHKCDGP;

	[Cpp2IlInjected.Token(Token = "0x6000C96")]
	[Cpp2IlInjected.Address(RVA = "0x2510800", Offset = "0x250FC00", VA = "0x182510800", Slot = "14")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C97")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C98")]
	[Cpp2IlInjected.Address(RVA = "0x22294F0", Offset = "0x22288F0", VA = "0x1822294F0")]
	public AOEBAHNIKAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000243")]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
internal sealed class JKOMKELFPHP : HLOJAODEAAM
{
	[Cpp2IlInjected.Token(Token = "0x6000C99")]
	[Cpp2IlInjected.Address(RVA = "0x288E7A0", Offset = "0x288DBA0", VA = "0x18288E7A0", Slot = "15")]
	protected override ComponentSystemBase BHJHPJOJPMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9A")]
	[Cpp2IlInjected.Address(RVA = "0x2229A50", Offset = "0x2228E50", VA = "0x182229A50")]
	public JKOMKELFPHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000244")]
internal class HNGPEFKJLBB : PCOIJKOLHMH
{
	[Cpp2IlInjected.Token(Token = "0x17000159")]
	protected override GCGDNGNDAMG LBPOJFOKAEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000C9B")]
		[Cpp2IlInjected.Address(RVA = "0x9427E0", Offset = "0x941BE0", VA = "0x1809427E0", Slot = "17")]
		get
		{
			return default(GCGDNGNDAMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9C")]
	[Cpp2IlInjected.Address(RVA = "0x287C160", Offset = "0x287B560", VA = "0x18287C160")]
	public HNGPEFKJLBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000245")]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
public sealed class EEHPGFDDOLJ : HLOJAODEAAM
{
	[Cpp2IlInjected.Token(Token = "0x6000C9D")]
	[Cpp2IlInjected.Address(RVA = "0x28C55D0", Offset = "0x28C49D0", VA = "0x1828C55D0", Slot = "15")]
	protected override ComponentSystemBase BHJHPJOJPMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9E")]
	[Cpp2IlInjected.Address(RVA = "0x2229A50", Offset = "0x2228E50", VA = "0x182229A50")]
	public EEHPGFDDOLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000246")]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
internal sealed class ALHACLENEEO : HLOJAODEAAM
{
	[Cpp2IlInjected.Token(Token = "0x6000C9F")]
	[Cpp2IlInjected.Address(RVA = "0x250EE80", Offset = "0x250E280", VA = "0x18250EE80", Slot = "15")]
	protected override ComponentSystemBase BHJHPJOJPMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA0")]
	[Cpp2IlInjected.Address(RVA = "0x2229A50", Offset = "0x2228E50", VA = "0x182229A50")]
	public ALHACLENEEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000247")]
[JKECMDGJAIN(typeof(KPMOMMGMLCH))]
public sealed class DBODAFJPJPG : PLAPLOGILJC
{
	[Cpp2IlInjected.Token(Token = "0x6000CA1")]
	[Cpp2IlInjected.Address(RVA = "0x2520130", Offset = "0x251F530", VA = "0x182520130", Slot = "8")]
	protected override bool NMMEKCFKCMH(ReadOnlySpan<KPMOMMGMLCH> KHFPKPBIJME, GKONMMGJICI OOALNHDBAGI, out ReadOnlySpan<byte> OEKDIKJACFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA2")]
	[Cpp2IlInjected.Address(RVA = "0x2520070", Offset = "0x251F470", VA = "0x182520070", Slot = "9")]
	protected override bool GCJJHEOCKGG(int HEGEMCIFGEI, Span<KPMOMMGMLCH> KHFPKPBIJME, in ReadOnlySpan<byte> OEKDIKJACFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA3")]
	[Cpp2IlInjected.Address(RVA = "0x25201B0", Offset = "0x251F5B0", VA = "0x1825201B0")]
	public DBODAFJPJPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000248")]
[JKECMDGJAIN(typeof(NEHEFBBJJKL))]
public sealed class LEHDBPMPMGD : DIBEICEPIGF
{
	[Cpp2IlInjected.Token(Token = "0x6000CA4")]
	[Cpp2IlInjected.Address(RVA = "0x2A5EBA0", Offset = "0x2A5DFA0", VA = "0x182A5EBA0", Slot = "8")]
	protected override bool NMMEKCFKCMH(ReadOnlySpan<NEHEFBBJJKL> KHFPKPBIJME, GKONMMGJICI OOALNHDBAGI, out ReadOnlySpan<byte> OEKDIKJACFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA5")]
	[Cpp2IlInjected.Address(RVA = "0x2A5EAE0", Offset = "0x2A5DEE0", VA = "0x182A5EAE0", Slot = "9")]
	protected override bool GCJJHEOCKGG(int HEGEMCIFGEI, Span<NEHEFBBJJKL> KHFPKPBIJME, in ReadOnlySpan<byte> OEKDIKJACFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA6")]
	[Cpp2IlInjected.Address(RVA = "0x2A5EC20", Offset = "0x2A5E020", VA = "0x182A5EC20")]
	public LEHDBPMPMGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000249")]
[HONNCCIFPDK(CAGOEBHGGNL.LoadInstance)]
internal sealed class IFJNJMLCMML : HLOJAODEAAM
{
	[Cpp2IlInjected.Token(Token = "0x6000CA7")]
	[Cpp2IlInjected.Address(RVA = "0x287E680", Offset = "0x287DA80", VA = "0x18287E680", Slot = "15")]
	protected override ComponentSystemBase BHJHPJOJPMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA8")]
	[Cpp2IlInjected.Address(RVA = "0x2229A50", Offset = "0x2228E50", VA = "0x182229A50")]
	public IFJNJMLCMML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024A")]
internal class FLFKFMNGEIA : ECINBHDAKID
{
	[Cpp2IlInjected.Token(Token = "0x6000CA9")]
	[Cpp2IlInjected.Address(RVA = "0x2229A50", Offset = "0x2228E50", VA = "0x182229A50")]
	public FLFKFMNGEIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024B")]
[EFDJEPLIMOC(typeof(CINMFIJPFIM), new string[] { })]
public sealed class OHEADODMKPL : CINMFIJPFIM, AKFIPDJCCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400076B")]
	private PGEMHDJNMBJ OAJPGNEHMOL;

	[Cpp2IlInjected.Token(Token = "0x6000CAA")]
	[Cpp2IlInjected.Address(RVA = "0x2A78970", Offset = "0x2A77D70", VA = "0x182A78970", Slot = "5")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CAB")]
	[Cpp2IlInjected.Address(RVA = "0x2A78890", Offset = "0x2A77C90", VA = "0x182A78890")]
	public bool LJCJBGODPCK(in float3 OCPINBDMADB, in float3 KDLMOBCGODE, float AMDMMLBNHAH, Allocator GMMIODGPFPJ, out NativeArray<Entity> PGJLMFPAKDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CAC")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public OHEADODMKPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CAD")]
	[Cpp2IlInjected.Address(RVA = "0x2A78890", Offset = "0x2A77C90", VA = "0x182A78890", Slot = "4")]
	private bool ICKOACCLHHP(in float3 OCPINBDMADB, in float3 KDLMOBCGODE, float AMDMMLBNHAH, Allocator GMMIODGPFPJ, out NativeArray<Entity> PGJLMFPAKDA)
	{
		return default(bool);
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200024C")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : DMCBJAFGDBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000CAE")]
		[Cpp2IlInjected.Address(RVA = "0x7F1AF0", Offset = "0x7F0EF0", VA = "0x1807F1AF0")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAF")]
		[Cpp2IlInjected.Address(RVA = "0x271C200", Offset = "0x271B600", VA = "0x18271C200", Slot = "6")]
		public sealed override void LPGLFILFNHK(AOEKEIHNKAE GBCKPIBLKJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB0")]
		[Cpp2IlInjected.Address(RVA = "0x271C000", Offset = "0x271B400", VA = "0x18271C000", Slot = "4")]
		public sealed override void DGJCFGACDCK()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200024D")]
internal class __UnmanagedPostProcessorOutput__3051310927
{
	[Cpp2IlInjected.Token(Token = "0x6000CB1")]
	[Cpp2IlInjected.Address(RVA = "0x271E920", Offset = "0x271DD20", VA = "0x18271E920")]
	[RuntimeInitializeOnLoadMethod]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024E")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3051310927
{
	[Cpp2IlInjected.Token(Token = "0x6000CB2")]
	[Cpp2IlInjected.Address(RVA = "0x271D370", Offset = "0x271C770", VA = "0x18271D370")]
	public static void DIKIEKHLDOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB3")]
	[Cpp2IlInjected.Address(RVA = "0x271E910", Offset = "0x271DD10", VA = "0x18271E910")]
	[RuntimeInitializeOnLoadMethod]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024F")]
internal class JMIHOBCKJOK : ContainerPropertyBag<AEHOCFDGEHI>
{
	[Cpp2IlInjected.Token(Token = "0x2000250")]
	private class NCMEMJPENMI : Property<AEHOCFDGEHI, CJHAGIKCJCL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		public override string GHALHBJBCAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000CB5")]
			[Cpp2IlInjected.Address(RVA = "0x2715A90", Offset = "0x2714E90", VA = "0x182715A90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		public override bool PAJHIMACICC
		{
			[Cpp2IlInjected.Token(Token = "0x6000CB6")]
			[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB7")]
		[Cpp2IlInjected.Address(RVA = "0x2715A50", Offset = "0x2714E50", VA = "0x182715A50")]
		public NCMEMJPENMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB8")]
		[Cpp2IlInjected.Address(RVA = "0x2715A00", Offset = "0x2714E00", VA = "0x182715A00", Slot = "14")]
		public override CJHAGIKCJCL GetValue(ref AEHOCFDGEHI OHJGEOICJDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB9")]
		[Cpp2IlInjected.Address(RVA = "0x2715A20", Offset = "0x2714E20", VA = "0x182715A20", Slot = "15")]
		public override void SetValue(ref AEHOCFDGEHI OHJGEOICJDB, CJHAGIKCJCL KKIAKNLLHIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB4")]
	[Cpp2IlInjected.Address(RVA = "0x288EDA0", Offset = "0x288E1A0", VA = "0x18288EDA0")]
	public JMIHOBCKJOK()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000251")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000CBA")]
		[Cpp2IlInjected.Address(RVA = "0x2240B20", Offset = "0x223FF20", VA = "0x182240B20")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod]
		public static void Initialize()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000252")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000CBB")]
	[Cpp2IlInjected.Address(RVA = "0x252B340", Offset = "0x252A740", VA = "0x18252B340")]
	[RuntimeInitializeOnLoadMethod]
	private static void Initialize()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000253")]
public class CBCPDCNEBEL
{
	[Cpp2IlInjected.Token(Token = "0x6000CBC")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public CBCPDCNEBEL()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000254")]
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
