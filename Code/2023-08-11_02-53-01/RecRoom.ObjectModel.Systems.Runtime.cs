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
		[Cpp2IlInjected.Address(RVA = "0x7E01F0", Offset = "0x7DE9F0", VA = "0x1807E01F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E01F0", Offset = "0x7DE9F0", VA = "0x1807E01F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1AD03F0", Offset = "0x1ACEBF0", VA = "0x181AD03F0")]
		public static DNDKGEBNELK<T> CreateTemporarySingleton<T>(this EntityManager entityManager, T componentData) where T : struct, IComponentData
		{
			return default(DNDKGEBNELK<T>);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal struct HMEFDICCLAJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[GDHDJEDPJKJ]
public static class AHAFMBNOCAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2896550", Offset = "0x2894D50", VA = "0x182896550")]
	static AHAFMBNOCAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1DF0B40", Offset = "0x1DEF340", VA = "0x181DF0B40")]
	public static void GCKJENMEFPK<T>(T EMGBKAPJLEO, ref T KLLNOLIEMOA, NGDOIACAINC IALCMDCBOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2896220", Offset = "0x2894A20", VA = "0x182896220")]
	public static void GCKJENMEFPK(FixedString32Bytes EMGBKAPJLEO, ref string KLLNOLIEMOA, NGDOIACAINC IALCMDCBOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x28964E0", Offset = "0x2894CE0", VA = "0x1828964E0")]
	public static void GCKJENMEFPK(string EMGBKAPJLEO, ref FixedString32Bytes KLLNOLIEMOA, NGDOIACAINC IALCMDCBOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2896460", Offset = "0x2894C60", VA = "0x182896460")]
	public static void GCKJENMEFPK(FixedString64Bytes EMGBKAPJLEO, ref string KLLNOLIEMOA, NGDOIACAINC IALCMDCBOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x28961C0", Offset = "0x28949C0", VA = "0x1828961C0")]
	public static void GCKJENMEFPK(string EMGBKAPJLEO, ref FixedString64Bytes KLLNOLIEMOA, NGDOIACAINC IALCMDCBOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2896490", Offset = "0x2894C90", VA = "0x182896490")]
	public static void GCKJENMEFPK(GIFIIIDMNLK EMGBKAPJLEO, ref Vector3 KLLNOLIEMOA, NGDOIACAINC IALCMDCBOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x28962F0", Offset = "0x2894AF0", VA = "0x1828962F0")]
	public static void GCKJENMEFPK(Vector3 EMGBKAPJLEO, ref GIFIIIDMNLK KLLNOLIEMOA, NGDOIACAINC IALCMDCBOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2896160", Offset = "0x2894960", VA = "0x182896160")]
	public static void GCKJENMEFPK(JDGGCICJCEE EMGBKAPJLEO, ref Vector4 KLLNOLIEMOA, NGDOIACAINC IALCMDCBOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2896090", Offset = "0x2894890", VA = "0x182896090")]
	public static void GCKJENMEFPK(Vector4 EMGBKAPJLEO, ref JDGGCICJCEE KLLNOLIEMOA, NGDOIACAINC IALCMDCBOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2896160", Offset = "0x2894960", VA = "0x182896160")]
	public static void GCKJENMEFPK(JDGGCICJCEE EMGBKAPJLEO, ref Quaternion KLLNOLIEMOA, NGDOIACAINC IALCMDCBOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2896090", Offset = "0x2894890", VA = "0x182896090")]
	public static void GCKJENMEFPK(Quaternion EMGBKAPJLEO, ref JDGGCICJCEE KLLNOLIEMOA, NGDOIACAINC IALCMDCBOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x28963F0", Offset = "0x2894BF0", VA = "0x1828963F0")]
	public static void GCKJENMEFPK(GIFIIIDMNLK EMGBKAPJLEO, ref float3 KLLNOLIEMOA, NGDOIACAINC IALCMDCBOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x28962F0", Offset = "0x2894AF0", VA = "0x1828962F0")]
	public static void GCKJENMEFPK(float3 EMGBKAPJLEO, ref GIFIIIDMNLK KLLNOLIEMOA, NGDOIACAINC IALCMDCBOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2896250", Offset = "0x2894A50", VA = "0x182896250")]
	public static void GCKJENMEFPK(JDGGCICJCEE EMGBKAPJLEO, ref float4 KLLNOLIEMOA, NGDOIACAINC IALCMDCBOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2896090", Offset = "0x2894890", VA = "0x182896090")]
	public static void GCKJENMEFPK(float4 EMGBKAPJLEO, ref JDGGCICJCEE KLLNOLIEMOA, NGDOIACAINC IALCMDCBOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2896250", Offset = "0x2894A50", VA = "0x182896250")]
	public static void GCKJENMEFPK(JDGGCICJCEE EMGBKAPJLEO, ref quaternion KLLNOLIEMOA, NGDOIACAINC IALCMDCBOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2896370", Offset = "0x2894B70", VA = "0x182896370")]
	public static void GCKJENMEFPK(quaternion EMGBKAPJLEO, ref JDGGCICJCEE KLLNOLIEMOA, NGDOIACAINC IALCMDCBOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2896120", Offset = "0x2894920", VA = "0x182896120")]
	public static void GCKJENMEFPK(Entity EMGBKAPJLEO, ref MOGBIDAPAKD KLLNOLIEMOA, NGDOIACAINC IALCMDCBOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2896520", Offset = "0x2894D20", VA = "0x182896520")]
	public static void GCKJENMEFPK(MOGBIDAPAKD EMGBKAPJLEO, ref Entity KLLNOLIEMOA, NGDOIACAINC IALCMDCBOGJ)
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
		public SerializableGuid JMIPHCGDMAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA64970", Offset = "0xA63170", VA = "0x180A64970")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x22D0F10", Offset = "0x22CF710", VA = "0x1822D0F10")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x90A150", Offset = "0x908950", VA = "0x18090A150")]
		public RRCustomPropTag()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[KHNAILLFHGJ(typeof(OABILJFHBBI), new string[] { })]
[DefaultMember("Item")]
public class JICNFAKECGO : OABILJFHBBI, IEnumerable<ILFNLPAIJLJ>, IEnumerable, ODKCILIJMBA, PCAPGPPECJN, NOFCHOCEBPC, NOHOJBNCAJC, NADHHNFNDJH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[NAAJCOHOAKA]
	private HMBELPNBOEG LNJHNPCFKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[NAAJCOHOAKA]
	private NHLFCCPGHPO DFBCJBEDHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private ILFNLPAIJLJ[] FKPCEGHLHDK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int GKGAEPJBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x24F4C20", Offset = "0x24F3420", VA = "0x1824F4C20", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ILFNLPAIJLJ ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x24F4AA0", Offset = "0x24F32A0", VA = "0x1824F4AA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "10")]
	public void PAHLDMJMCEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x24F4E40", Offset = "0x24F3640", VA = "0x1824F4E40", Slot = "11")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "12")]
	public void GGJEPBDNAAH(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x24F4D10", Offset = "0x24F3510", VA = "0x1824F4D10", Slot = "6")]
	public ILFNLPAIJLJ HPADBCECEJC(FKFIIEPBNGA ELAAPFMOMBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x24F50D0", Offset = "0x24F38D0", VA = "0x1824F50D0", Slot = "7")]
	public LLNAAGHGEOA LNDPHGGBMPP(FKFIIEPBNGA ELAAPFMOMBJ)
	{
		return default(LLNAAGHGEOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x24F4C30", Offset = "0x24F3430", VA = "0x1824F4C30", Slot = "8")]
	public IEnumerator<ILFNLPAIJLJ> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x24F51A0", Offset = "0x24F39A0", VA = "0x1824F51A0", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x26C5CC0", Offset = "0x26C44C0", VA = "0x1826C5CC0", Slot = "13")]
	public void KBBEFAPNECG<TKey, T>(ALJIFOIANLF<TKey, T> OPCEAOKDBMJ, [Optional] object HNBDDLBIIOF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x24F4AE0", Offset = "0x24F32E0", VA = "0x1824F4AE0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public JICNFAKECGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x24F4AA0", Offset = "0x24F32A0", VA = "0x1824F4AA0")]
	[CompilerGenerated]
	private ILFNLPAIJLJ DFOBAJBIKDP(int NLNOELCPLOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[ANLOEBHPLMF(typeof(PPJGCIMLGBG))]
[KHNAILLFHGJ(typeof(IKCMADHPPKE), new string[] { })]
public class PPJGCIMLGBG : IKCMADHPPKE, NOFCHOCEBPC
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly JNGNMMOLKFF FDLHHLBKCGC;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly JNGNMMOLKFF JMBILNKMNHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private HMBELPNBOEG LNJHNPCFKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private NAHGLKOIEAI BOBHLPNKBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private ICLGKIICAFG DOEAPBCCKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private ILBBGIPPPPJ EJLFIBCCMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private AEDKFOCGAIL AAOAOHHKNIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private GHNAAIGKIGD LHGEACJDIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private LDDHDDLKFEJ HBLGPEBMOAO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private EntityManager EADLBIHJKBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x22C3370", Offset = "0x22C1B70", VA = "0x1822C3370")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x22C4C10", Offset = "0x22C3410", VA = "0x1822C4C10", Slot = "34")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x22C33D0", Offset = "0x22C1BD0", VA = "0x1822C33D0", Slot = "35")]
	public bool FJFGMMBNOBJ(Transform LAMNAOAMKPM, out LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x22C5B00", Offset = "0x22C4300", VA = "0x1822C5B00", Slot = "36")]
	public Transform LPJIDHLJEIH(Entity AJDEFAPHMKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x22C5A00", Offset = "0x22C4200", VA = "0x1822C5A00", Slot = "31")]
	public bool LOMNBKALOHK(Entity AJDEFAPHMKF, out Transform LAMNAOAMKPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x22C3710", Offset = "0x22C1F10", VA = "0x1822C3710")]
	private void FLIMNAGAKDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x22C2D60", Offset = "0x22C1560", VA = "0x1822C2D60", Slot = "30")]
	public void BKBHJGJHGAI(Entity AJDEFAPHMKF, out float4x4 EFACIDLJAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x22C5540", Offset = "0x22C3D40", VA = "0x1822C5540", Slot = "4")]
	public void LLPIKCHKOGG(Entity AJDEFAPHMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x22C53C0", Offset = "0x22C3BC0", VA = "0x1822C53C0", Slot = "28")]
	public void LLOMMEHAPFI(Entity AJDEFAPHMKF, out float4x4 EFACIDLJAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x22C5E40", Offset = "0x22C4640", VA = "0x1822C5E40")]
	public void PBCGBABMIAD(Entity AJDEFAPHMKF, in float4x4 EFACIDLJAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x22C35D0", Offset = "0x22C1DD0", VA = "0x1822C35D0")]
	public void KFDLIJACOBF(Entity AJDEFAPHMKF, in float3 MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x22C27C0", Offset = "0x22C0FC0", VA = "0x1822C27C0", Slot = "6")]
	public float3 AFHOMGAJMLH(Entity AJDEFAPHMKF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x22C4D20", Offset = "0x22C3520", VA = "0x1822C4D20")]
	public void KBGOAGBBAAK(Entity AJDEFAPHMKF, in quaternion MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x22C2FE0", Offset = "0x22C17E0", VA = "0x1822C2FE0", Slot = "8")]
	public quaternion CCLAJFGECPI(Entity AJDEFAPHMKF)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x22C2AF0", Offset = "0x22C12F0", VA = "0x1822C2AF0")]
	public void BBAPEDLDGHL(Entity AJDEFAPHMKF, in float3 MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x22C31A0", Offset = "0x22C19A0", VA = "0x1822C31A0", Slot = "12")]
	public float3 CLAGLONHNJJ(Entity AJDEFAPHMKF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x22C45A0", Offset = "0x22C2DA0", VA = "0x1822C45A0", Slot = "15")]
	public float IBKKBCCLKMB(Entity AJDEFAPHMKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x22C3730", Offset = "0x22C1F30", VA = "0x1822C3730", Slot = "14")]
	public void FPFILMBFBCA(Entity AJDEFAPHMKF, float MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x22C3920", Offset = "0x22C2120", VA = "0x1822C3920", Slot = "17")]
	public float3 GANHJMFFNFJ(Entity AJDEFAPHMKF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x22C5130", Offset = "0x22C3930", VA = "0x1822C5130")]
	public void KPFKAIIOHPG(Entity AJDEFAPHMKF, in float3 NMHBDGGJNDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x22C2380", Offset = "0x22C0B80", VA = "0x1822C2380", Slot = "9")]
	public void ADONEMEIFIN(Entity AJDEFAPHMKF, out float3 PAOMABBDKAH, out quaternion APAHFEOKBOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x22C25A0", Offset = "0x22C0DA0", VA = "0x1822C25A0", Slot = "10")]
	public void ADONEMEIFIN(Entity AJDEFAPHMKF, out RigidTransform FGPBBIHDJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x22C3F60", Offset = "0x22C2760", VA = "0x1822C3F60", Slot = "37")]
	public void HNGCHLOFNEH(Entity AJDEFAPHMKF, out float3 PAOMABBDKAH, out quaternion APAHFEOKBOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x22C40E0", Offset = "0x22C28E0", VA = "0x1822C40E0", Slot = "11")]
	public void HNGCHLOFNEH(Entity AJDEFAPHMKF, out RigidTransform FGPBBIHDJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x22C5BC0", Offset = "0x22C43C0", VA = "0x1822C5BC0")]
	public void OFPFKNFIPHK(Entity AJDEFAPHMKF, in float3 MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x22C2C30", Offset = "0x22C1430", VA = "0x1822C2C30", Slot = "19")]
	public float3 BGNBGEJHCHN(Entity AJDEFAPHMKF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x22C29B0", Offset = "0x22C11B0", VA = "0x1822C29B0")]
	public void PHPLCBBHGNF(Entity AJDEFAPHMKF, in quaternion MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x22C3AF0", Offset = "0x22C22F0", VA = "0x1822C3AF0", Slot = "21")]
	public quaternion GBMIBJMJHCF(Entity AJDEFAPHMKF)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x22C3D40", Offset = "0x22C2540", VA = "0x1822C3D40")]
	public void HGBCENPALNG(Entity AJDEFAPHMKF, in float3 MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x22C3C10", Offset = "0x22C2410", VA = "0x1822C3C10", Slot = "22")]
	public float3 GIJOOKNKPIK(Entity AJDEFAPHMKF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x22C4EF0", Offset = "0x22C36F0", VA = "0x1822C4EF0", Slot = "24")]
	public void KFNMBFMCJEL(Entity AJDEFAPHMKF, float IMBOBLNABFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x22C52D0", Offset = "0x22C3AD0", VA = "0x1822C52D0", Slot = "25")]
	public float LEMICPDPBOH(Entity AJDEFAPHMKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x22C4260", Offset = "0x22C2A60", VA = "0x1822C4260")]
	public void HOIKNANDLMA(Entity AJDEFAPHMKF, in float3 EOALGJMFLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x22C2E20", Offset = "0x22C1620", VA = "0x1822C2E20", Slot = "27")]
	public float3 CBFHIEGPLEE(Entity AJDEFAPHMKF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x22C4690", Offset = "0x22C2E90", VA = "0x1822C4690", Slot = "32")]
	public void IHDEDMGCIDL(Entity AJDEFAPHMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x22C5D00", Offset = "0x22C4500", VA = "0x1822C5D00")]
	private LPLJHAHPEEF OHFFMDCGKOF(Transform LAMNAOAMKPM)
	{
		return default(LPLJHAHPEEF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x22C6130", Offset = "0x22C4930", VA = "0x1822C6130")]
	private static TransformEntity PPFDPGJOHCO(KECBEHOHBCN EIOLDDJPDLH, GameObject HBPFJCNENNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2301990", Offset = "0x2300190", VA = "0x182301990")]
	private static T IAEFFNBKDAP<T>(GameObject HBPFJCNENNP) where T : MonoBehaviour
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x22C2260", Offset = "0x22C0A60", VA = "0x1822C2260", Slot = "33")]
	public void ABFEBEGFHKC(Entity AJDEFAPHMKF, Entity FNFODDOPDHK, Entity ILLDOGNGNOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public PPJGCIMLGBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x22C35D0", Offset = "0x22C1DD0", VA = "0x1822C35D0", Slot = "5")]
	private void FJKPEMNBKGI(Entity AJDEFAPHMKF, in float3 MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x22C5830", Offset = "0x22C4030", VA = "0x1822C5830", Slot = "7")]
	private void LOBNPCEHDJK(Entity AJDEFAPHMKF, in quaternion MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x22C2AF0", Offset = "0x22C12F0", VA = "0x1822C2AF0", Slot = "13")]
	private void BJGBIJGMIAI(Entity AJDEFAPHMKF, in float3 MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x22C5130", Offset = "0x22C3930", VA = "0x1822C5130", Slot = "16")]
	private void PIBICGGNPBD(Entity AJDEFAPHMKF, in float3 MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x22C5BC0", Offset = "0x22C43C0", VA = "0x1822C5BC0", Slot = "18")]
	private void MANOMBAKFCJ(Entity AJDEFAPHMKF, in float3 MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x22C29B0", Offset = "0x22C11B0", VA = "0x1822C29B0", Slot = "20")]
	private void AFPEFPFFPBK(Entity AJDEFAPHMKF, in quaternion MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x22C33C0", Offset = "0x22C1BC0", VA = "0x1822C33C0", Slot = "23")]
	private void FAAGOOABCGG(Entity AJDEFAPHMKF, in float3 MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x22C6120", Offset = "0x22C4920", VA = "0x1822C6120", Slot = "26")]
	private void PJDDGNOBHNI(Entity AJDEFAPHMKF, in float3 MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x22C2AE0", Offset = "0x22C12E0", VA = "0x1822C2AE0", Slot = "29")]
	private void APIGPBMLKHM(Entity AJDEFAPHMKF, in float4x4 ILDEBNONBOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class DGJAIDNGBLB
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class CPEALHPMBCC : FIJBLGANFNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly string NPJIBMFDANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly CPEALHPMBCC EKHCNAPLCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly List<CPEALHPMBCC> KLMNJJHECPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly List<KGGCPADPPEB> LAEPKFGACAO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string MOCKNNDLFAL
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public FIJBLGANFNJ NBCMFIEABFL
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IEnumerable<FIJBLGANFNJ> NCAFMHPOECD
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7EC6C0", Offset = "0x7EAEC0", VA = "0x1807EC6C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x28AAA10", Offset = "0x28A9210", VA = "0x1828AAA10")]
	public CPEALHPMBCC(string MDOAADHDBMA, CPEALHPMBCC GJPBCFJDGCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[HHKHACIGOAG(JLEAEANKKDG.Application)]
[KHNAILLFHGJ(typeof(KPDEPPFNAGM), new string[] { })]
internal class KPDEPPFNAGM : PCAPGPPECJN
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x291EBB0", Offset = "0x291D3B0", VA = "0x18291EBB0", Slot = "4")]
	public void PAHLDMJMCEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public KPDEPPFNAGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[KHNAILLFHGJ(typeof(OJMMJKOMFGB), new string[] { })]
public class DHNAPPDODKI : NOFCHOCEBPC, OJMMJKOMFGB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private EntityManager EADLBIHJKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private PCMJCEALPLG CPALFAMBLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private MDFAPHDDPNI ICCJCKNDIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool PMADFOMNIPK;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2C6A0E0", Offset = "0x2C688E0", VA = "0x182C6A0E0", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2C69E90", Offset = "0x2C68690", VA = "0x182C69E90", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2C69FA0", Offset = "0x2C687A0", VA = "0x182C69FA0", Slot = "5")]
	public bool EPPDCAAMLKG(LPLJHAHPEEF BBNGIDIFEAM, out Collider PINIOELHAHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2C69BF0", Offset = "0x2C683F0", VA = "0x182C69BF0", Slot = "6")]
	public GameObject AIMGMPANBJF(LPLJHAHPEEF NKMBOHGBBKP, GameObject KHAPGPKPDBB, Vector3 GGKJMICDBEF, Quaternion CCIFDEOEEEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2C69EA0", Offset = "0x2C686A0", VA = "0x182C69EA0", Slot = "7")]
	public void EGHICKFKCCP(GameObject PINIOELHAHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x30751B0", Offset = "0x30739B0", VA = "0x1830751B0", Slot = "8")]
	public TCollider BCLLCNDBFHG<TCollider>(GameObject BBPEBGOHEKI) where TCollider : Collider
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2C69DD0", Offset = "0x2C685D0", VA = "0x182C69DD0", Slot = "9")]
	public void AOHLPONKKAO(Collider PINIOELHAHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x30751B0", Offset = "0x30739B0", VA = "0x1830751B0", Slot = "10")]
	public GameObject FJLNOOKHOPM<TCollider>(string MDOAADHDBMA) where TCollider : Collider
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public DHNAPPDODKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class NJPAIGBFEDH
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class IGBOJICGIKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private NativeList<IMFFAHKLBNI> PGJDAJHCJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private NativeList<EJDGNFKIJAG> FFHAMOOEGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private NativeList<FLNMMMIIPBM> JMGJJBJDEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private NativeList<EJDGNFKIJAG> NJIEMDJODCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private bool PMADFOMNIPK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NativeList<IMFFAHKLBNI> KBMNNPIGKFA
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x918DC0", Offset = "0x9175C0", VA = "0x180918DC0")]
		get
		{
			return default(NativeList<IMFFAHKLBNI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public NativeList<EJDGNFKIJAG> HCPJNPHFDOD
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x918DD0", Offset = "0x9175D0", VA = "0x180918DD0")]
		get
		{
			return default(NativeList<EJDGNFKIJAG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NativeList<FLNMMMIIPBM> KKBFFHLKMNE
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xB28580", Offset = "0xB26D80", VA = "0x180B28580")]
		get
		{
			return default(NativeList<FLNMMMIIPBM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public NativeList<EJDGNFKIJAG> IGLKGICGMDG
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x918DF0", Offset = "0x9175F0", VA = "0x180918DF0")]
		get
		{
			return default(NativeList<EJDGNFKIJAG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public JobHandle PLGKNILFGEL
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x13BBA50", Offset = "0x13BA250", VA = "0x1813BBA50")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x13B9C70", Offset = "0x13B8470", VA = "0x1813B9C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool FMIGFGHOLOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x24EF220", Offset = "0x24EDA20", VA = "0x1824EF220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x24EF810", Offset = "0x24EE010", VA = "0x1824EF810")]
	public IGBOJICGIKC(Allocator HMGEFCKKBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x24EF2E0", Offset = "0x24EDAE0", VA = "0x1824EF2E0")]
	public void EEMEPIGIECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x24EF370", Offset = "0x24EDB70", VA = "0x1824EF370")]
	public void FEIFDLJJPLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x24EF4A0", Offset = "0x24EDCA0", VA = "0x1824EF4A0")]
	public void GLILACFFLBJ(Entity AJDEFAPHMKF, Entity FNFODDOPDHK, Entity ILLDOGNGNOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
internal class CGOFIGEGJIJ : NHLEGKPBPCC
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private EntityQuery EGFJCKOAGFH;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x28A5580", Offset = "0x28A3D80", VA = "0x1828A5580", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x28A5620", Offset = "0x28A3E20", VA = "0x1828A5620", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public CGOFIGEGJIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[KAPPDMKCEOO(JLEAEANKKDG.OMRoom)]
internal class NFADDJLOCHH : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private OIKLJKNPPOI KABPDMFAFHH;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x292F530", Offset = "0x292DD30", VA = "0x18292F530", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x292F580", Offset = "0x292DD80", VA = "0x18292F580", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public NFADDJLOCHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class COENKGINLAC
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class BMEHFKDHINB
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class HLABMJLCBHL<T> : GHMKFKAMLJJ<T>, ALJIFOIANLF<MHGAJIKGEGE, T>, KCHKLIOOFLC<MHGAJIKGEGE>, MNKCCJJMJKH, IDisposable, ILFNLPAIJLJ where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly KCHKLIOOFLC<Entity> OPCEAOKDBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HMBELPNBOEG LNJHNPCFKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private Delegate PHBEBNHEBPN;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public string EHNKIECOKGD
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x47C2AA0", Offset = "0x47C12A0", VA = "0x1847C2AA0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Type ILFDEIBDFFB
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x47D0D40", Offset = "0x47CF540", VA = "0x1847D0D40", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public BMPCFGMBEIA JFGADNLFGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x47C9B80", Offset = "0x47C8380", VA = "0x1847C9B80", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int EDHJHHDEOKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x47C2F50", Offset = "0x47C1750", VA = "0x1847C2F50", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public CICLHDCPBNI LFLBPEILMMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x47C86F0", Offset = "0x47C6EF0", VA = "0x1847C86F0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event EEJPKNFMFLB<MHGAJIKGEGE> NHPDJIPDPHC
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x47D1140", Offset = "0x47CF940", VA = "0x1847D1140", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x47CE520", Offset = "0x47CCD20", VA = "0x1847CE520", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x299C380", Offset = "0x299AB80", VA = "0x18299C380")]
	public HLABMJLCBHL(KCHKLIOOFLC<Entity> OPCEAOKDBMJ, HMBELPNBOEG LNJHNPCFKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x47C8D40", Offset = "0x47C7540", VA = "0x1847C8D40")]
	private Entity LADHFHOPINH(MHGAJIKGEGE ECBAIECDCID)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3F91CE0", Offset = "0x3F904E0", VA = "0x183F91CE0")]
	private MHGAJIKGEGE LADHFHOPINH(Entity AJDEFAPHMKF)
	{
		return default(MHGAJIKGEGE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x47CCEA0", Offset = "0x47CB6A0", VA = "0x1847CCEA0", Slot = "4")]
	public T LPKBLHIFLLL(MHGAJIKGEGE ECBAIECDCID)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x47CF0A0", Offset = "0x47CD8A0", VA = "0x1847CF0A0")]
	public bool OLFLGMGEIBD(MHGAJIKGEGE ECBAIECDCID, in T PCKLDBCFAAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x47D1FA0", Offset = "0x47D07A0", VA = "0x1847D1FA0", Slot = "7")]
	public bool PINCLHPNEDE(MHGAJIKGEGE ECBAIECDCID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3F938F0", Offset = "0x3F920F0", VA = "0x183F938F0", Slot = "8")]
	public void LPKBLHIFLLL(MHGAJIKGEGE ECBAIECDCID, KOAODCFHIDH MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3F96990", Offset = "0x3F95190", VA = "0x183F96990", Slot = "9")]
	public bool OLFLGMGEIBD(MHGAJIKGEGE ECBAIECDCID, DMEBMKFMGNA PCKLDBCFAAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2999B60", Offset = "0x2998360", VA = "0x182999B60", Slot = "16")]
	public void DMJAGMBBENO(NADHHNFNDJH INDEBDDLMDO, [Optional] object HNBDDLBIIOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3F8CF60", Offset = "0x3F8B760", VA = "0x183F8CF60", Slot = "10")]
	public bool BBGJPJPLCPO(MHGAJIKGEGE KLLNOLIEMOA, MHGAJIKGEGE EMGBKAPJLEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3F8D260", Offset = "0x3F8BA60", VA = "0x183F8D260", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x47D7B30", Offset = "0x47D6330", VA = "0x1847D7B30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x47C6C10", Offset = "0x47C5410", VA = "0x1847C6C10")]
	private void JHKFIIBMPAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x47C5870", Offset = "0x47C4070", VA = "0x1847C5870")]
	private void ILCAMAJGLFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x47D3CF0", Offset = "0x47D24F0", VA = "0x1847D3CF0")]
	private void PKLMDICGGEB(Entity AJDEFAPHMKF, in DMEBMKFMGNA MDBHGCNGNDL, in DMEBMKFMGNA PCKLDBCFAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x47CA170", Offset = "0x47C8970", VA = "0x1847CA170")]
	private void LKOFBKBKEJJ(Entity AJDEFAPHMKF, in DMEBMKFMGNA MDBHGCNGNDL, in DMEBMKFMGNA PCKLDBCFAAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class MFNAKBAOCJH : OJFKKPOGGCL
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x292A140", Offset = "0x2928940", VA = "0x18292A140", Slot = "5")]
	public override Action ECBGJMNDAAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[UnityEngine.Scripting.Preserve]
	public abstract void NCNIFMAHHPA<T>() where T : MIIOPAJPNBD;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x292A1D0", Offset = "0x29289D0", VA = "0x18292A1D0")]
	[UnityEngine.Scripting.Preserve]
	public void MKMNEFMGJPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x24F2DB0", Offset = "0x24F15B0", VA = "0x1824F2DB0")]
	protected MFNAKBAOCJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[KHNAILLFHGJ(typeof(BEGAPFFEIJA), new string[] { })]
public class ENOIMPFLLNM : NOFCHOCEBPC, BEGAPFFEIJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private EntityManager EADLBIHJKBG;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2C749B0", Offset = "0x2C731B0", VA = "0x182C749B0", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2C74940", Offset = "0x2C73140", VA = "0x182C74940", Slot = "5")]
	public void HHKBNMMEIAK(LPLJHAHPEEF PMFGMJJBADH, bool MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2B00090", Offset = "0x2AFE890", VA = "0x182B00090")]
	private void OLFLGMGEIBD<T>(LPLJHAHPEEF PMFGMJJBADH, bool MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public ENOIMPFLLNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[HHKHACIGOAG(JLEAEANKKDG.LoadInstance)]
[KHNAILLFHGJ(typeof(FJKBBPDKKKK), new string[] { })]
public class FJKBBPDKKKK : NOFCHOCEBPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class PMGGENCJIAB : IEnumerable<KBFDDENCLAP>, IEnumerable, IEnumerator<KBFDDENCLAP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private KBFDDENCLAP <>2__current;

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
		public FJKBBPDKKKK <>4__this;

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
		private LKIAEAEEIOP <rbex>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private KBFDDENCLAP System.Collections.Generic.IEnumerator<RecRoom.Rbex.IOMRigidbodyExImpl>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xABFAA0", Offset = "0xABE2A0", VA = "0x180ABFAA0")]
		[DebuggerHidden]
		public PMGGENCJIAB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x2237BC0", Offset = "0x22363C0", VA = "0x182237BC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x2237870", Offset = "0x2236070", VA = "0x182237870", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x2237A80", Offset = "0x2236280", VA = "0x182237A80")]
		private void PPLJHCFFCFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x2237B80", Offset = "0x2236380", VA = "0x182237B80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x2237AD0", Offset = "0x22362D0", VA = "0x182237AD0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KBFDDENCLAP> System.Collections.Generic.IEnumerable<RecRoom.Rbex.IOMRigidbodyExImpl>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x2237AD0", Offset = "0x22362D0", VA = "0x182237AD0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly List<(NativeArray<Entity> entities, bool awake, bool hasRigidbody)> GLCDCGFLDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[NAAJCOHOAKA]
	private ILBBGIPPPPJ KFELNFLBJDM;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2C78F80", Offset = "0x2C77780", VA = "0x182C78F80", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2C78E60", Offset = "0x2C77660", VA = "0x182C78E60")]
	public void FPLNKDMNPCJ(NativeArray<Entity> KFLBCCAJFMN, bool CIENKLIMLCH, bool NCMOKGMACCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2C78FD0", Offset = "0x2C777D0", VA = "0x182C78FD0")]
	public void MNFLNLIHJJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2C79200", Offset = "0x2C77A00", VA = "0x182C79200")]
	private void NHMOOHABHGH(NativeArray<Entity> KFLBCCAJFMN, bool CIENKLIMLCH, bool NCMOKGMACCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2C78C70", Offset = "0x2C77470", VA = "0x182C78C70")]
	[IteratorStateMachine(typeof(PMGGENCJIAB))]
	private IEnumerable<KBFDDENCLAP> DPFHIDGHHJC(NativeArray<Entity> KFLBCCAJFMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2C78D00", Offset = "0x2C77500", VA = "0x182C78D00", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2C79940", Offset = "0x2C78140", VA = "0x182C79940")]
	public FJKBBPDKKKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[KHNAILLFHGJ(typeof(FFHJPFHDABG), new string[] { })]
[HHKHACIGOAG(JLEAEANKKDG.LoadInstance)]
public class FFHJPFHDABG : NOFCHOCEBPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<NativeListAsync<CHFHHLLDIJI>> HHIFIGGPHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[NAAJCOHOAKA]
	private ILBBGIPPPPJ KFELNFLBJDM;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2C76BA0", Offset = "0x2C753A0", VA = "0x182C76BA0", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2C76B30", Offset = "0x2C75330", VA = "0x182C76B30")]
	public void FPLNKDMNPCJ(NativeListAsync<CHFHHLLDIJI> KFLBCCAJFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2C76BF0", Offset = "0x2C753F0", VA = "0x182C76BF0")]
	public void MNFLNLIHJJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2C769D0", Offset = "0x2C751D0", VA = "0x182C769D0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2C77080", Offset = "0x2C75880", VA = "0x182C77080")]
	public FFHJPFHDABG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class KELFENAGPHI
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static readonly ProfilerMarker KCFGFBADJIJ;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly ProfilerMarker OPNGFJAMNNP;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x24F7760", Offset = "0x24F5F60", VA = "0x1824F7760")]
	public static void CJHJKHMBMOJ(this NDJLNOJIHMB KGMNNCCACLI, ABPFOLFBKFD LPNNBGAFKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x24F7B50", Offset = "0x24F6350", VA = "0x1824F7B50")]
	public static void MEEOEHLPLCA(this NDJLNOJIHMB KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x24F7D00", Offset = "0x24F6500", VA = "0x1824F7D00")]
	private static string[] PBBFDHFPCIE(ABPFOLFBKFD LPNNBGAFKLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x24F75A0", Offset = "0x24F5DA0", VA = "0x1824F75A0")]
	private static bool ABBFHPEMPAH(ABPFOLFBKFD LPNNBGAFKLN, out string[] BLLBPHMCEHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x8A3C30", Offset = "0x8A2430", VA = "0x1808A3C30")]
	private static bool ACFIKOHDBNI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[KHNAILLFHGJ(typeof(HMBELPNBOEG), new string[] { })]
public class DEPLKPAFPFB : NOFCHOCEBPC, HMBELPNBOEG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static readonly JNGNMMOLKFF CFJADIKMKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[NAAJCOHOAKA]
	private NHHFEIDPNIC HMNAFOKFDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[NAAJCOHOAKA]
	private NAHGLKOIEAI BOBHLPNKBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[NAAJCOHOAKA]
	private KMFOAMJFLAH PBHLNILGHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[NAAJCOHOAKA]
	private LDDHDDLKFEJ HBLGPEBMOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[NAAJCOHOAKA]
	private GOHOPIDFNBA CBGOOONHBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[NAAJCOHOAKA]
	private NKHJADIBHEP OIPELOCIIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private MKFKBEBMKHL NBFLEJAKAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private DLLLPKHOKKN BIKLBHANPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private bool PMADFOMNIPK;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public NHHFEIDPNIC BNFKDIONJJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<MDHHOEPMEJH, NativeArray<KECBEHOHBCN>> NMCOOHJJDEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2C69810", Offset = "0x2C68010", VA = "0x182C69810", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2C67A80", Offset = "0x2C66280", VA = "0x182C67A80", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<MDHHOEPMEJH> POBNPMAMCEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2C68F00", Offset = "0x2C67700", VA = "0x182C68F00", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2C67C80", Offset = "0x2C66480", VA = "0x182C67C80", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2C686F0", Offset = "0x2C66EF0", VA = "0x182C686F0", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2C67B70", Offset = "0x2C66370", VA = "0x182C67B70", Slot = "38")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2C67E80", Offset = "0x2C66680", VA = "0x182C67E80")]
	private void HONLAMNKGMD(MDHHOEPMEJH NJCFCNKMPKG, NativeArray<KECBEHOHBCN> PGDPKHFFBIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2C68680", Offset = "0x2C66E80", VA = "0x182C68680")]
	private void IOIBMBIFHIB(MDHHOEPMEJH NJCFCNKMPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2C69590", Offset = "0x2C67D90", VA = "0x182C69590")]
	internal LPLJHAHPEEF OCMMBIABHIK(Entity AJDEFAPHMKF)
	{
		return default(LPLJHAHPEEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2C68FA0", Offset = "0x2C677A0", VA = "0x182C68FA0", Slot = "10")]
	public APFIBDNJBME JPCHGEPHIEH(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(APFIBDNJBME);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2C67DF0", Offset = "0x2C665F0", VA = "0x182C67DF0", Slot = "11")]
	public KECBEHOHBCN HDEFOGKKFEG(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(KECBEHOHBCN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2C698B0", Offset = "0x2C680B0", VA = "0x182C698B0", Slot = "37")]
	public bool PINCLHPNEDE(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2C67FD0", Offset = "0x2C667D0", VA = "0x182C67FD0", Slot = "32")]
	public void IKDLJOMDIEB(MDHHOEPMEJH ADGNPKODABN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2C678D0", Offset = "0x2C660D0", VA = "0x182C678D0", Slot = "33")]
	public void CLOOKKNDFON(LPLJHAHPEEF BBNGIDIFEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2C68920", Offset = "0x2C67120", VA = "0x182C68920", Slot = "34")]
	public void JBIKODGILBE(LPLJHAHPEEF BBNGIDIFEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2C67F90", Offset = "0x2C66790", VA = "0x182C67F90", Slot = "35")]
	public void IKDLJOMDIEB(LPLJHAHPEEF BBNGIDIFEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2C68980", Offset = "0x2C67180", VA = "0x182C68980", Slot = "22")]
	public MDHHOEPMEJH JIFMDGFNNCE(NativeArray<MHGAJIKGEGE> ECBAIECDCID, Allocator HMGEFCKKBID)
	{
		return default(MDHHOEPMEJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2C683E0", Offset = "0x2C66BE0", VA = "0x182C683E0", Slot = "23")]
	public MDHHOEPMEJH IMDNOOLOJIB(NativeArray<MHGAJIKGEGE> ECBAIECDCID, NativeArray<CBGNFPNAGKM> NHOIGPDOBNB, Allocator HMGEFCKKBID)
	{
		return default(MDHHOEPMEJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2C68FD0", Offset = "0x2C677D0", VA = "0x182C68FD0", Slot = "24")]
	public IFDBCDKGAKP KIDGLIGMFOC(KECBEHOHBCN MCBNACIDAGA, bool NICMHNKPPOK)
	{
		return default(IFDBCDKGAKP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2C69100", Offset = "0x2C67900", VA = "0x182C69100", Slot = "25")]
	public IFDBCDKGAKP KIDGLIGMFOC(KECBEHOHBCN MCBNACIDAGA)
	{
		return default(IFDBCDKGAKP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2C694B0", Offset = "0x2C67CB0", VA = "0x182C694B0", Slot = "26")]
	public IFDBCDKGAKP OBIOJJIDPBA(KECBEHOHBCN MCBNACIDAGA)
	{
		return default(IFDBCDKGAKP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2C67930", Offset = "0x2C66130", VA = "0x182C67930", Slot = "27")]
	public IFDBCDKGAKP CNPFDBKPHFC(KECBEHOHBCN MCBNACIDAGA)
	{
		return default(IFDBCDKGAKP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2C680B0", Offset = "0x2C668B0", VA = "0x182C680B0", Slot = "28")]
	public IFDBCDKGAKP IMDNOOLOJIB(MHGAJIKGEGE ECBAIECDCID, KECBEHOHBCN MCBNACIDAGA)
	{
		return default(IFDBCDKGAKP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2C68CE0", Offset = "0x2C674E0", VA = "0x182C68CE0", Slot = "29")]
	public HBILLJPEKGG JJOKELHAGFN()
	{
		return default(HBILLJPEKGG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2C67D20", Offset = "0x2C66520", VA = "0x182C67D20", Slot = "30")]
	public KNBBFGODFFJ GGBAPGAFNOF()
	{
		return default(KNBBFGODFFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2C693C0", Offset = "0x2C67BC0", VA = "0x182C693C0", Slot = "31")]
	public BMAEGOEOJJA NEIMIMJEBHI(JBOEKGNECFI EIOLDDJPDLH)
	{
		return default(BMAEGOEOJJA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2C68900", Offset = "0x2C67100", VA = "0x182C68900", Slot = "12")]
	public void JACMNDDEBJP(MHGAJIKGEGE ECBAIECDCID, FKKNGLCNOFO KLGNIICJIKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2C695D0", Offset = "0x2C67DD0", VA = "0x182C695D0", Slot = "13")]
	public IFDBCDKGAKP OMDNJAEMAPA(LPLJHAHPEEF BBNGIDIFEAM, [Optional] object AMCDGOPKAOE)
	{
		return default(IFDBCDKGAKP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2C68E60", Offset = "0x2C67660", VA = "0x182C68E60", Slot = "14")]
	public bool JLOABAPGJKJ(LPLJHAHPEEF BBNGIDIFEAM, out FKKNGLCNOFO LACIMGIMLFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2C692B0", Offset = "0x2C67AB0", VA = "0x182C692B0", Slot = "15")]
	public bool LOMNBKALOHK(LPLJHAHPEEF BBNGIDIFEAM, out Transform LAMNAOAMKPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2C67F00", Offset = "0x2C66700", VA = "0x182C67F00", Slot = "16")]
	public bool IGAMJDGIHFK(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2C69220", Offset = "0x2C67A20", VA = "0x182C69220", Slot = "17")]
	public void LALMNDMOKEI(LPLJHAHPEEF BBNGIDIFEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2C691D0", Offset = "0x2C679D0", VA = "0x182C691D0", Slot = "18")]
	public bool KPMJLLFPDAO(LocalId BBNGIDIFEAM, object AMCDGOPKAOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2C67B20", Offset = "0x2C66320", VA = "0x182C67B20", Slot = "19")]
	public bool DCBHKHFJOGA(LocalId BBNGIDIFEAM, object AMCDGOPKAOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2C69350", Offset = "0x2C67B50", VA = "0x182C69350", Slot = "36")]
	public MDHHOEPMEJH MMCNJDCOMKI(MDHHOEPMEJH FGPFEGPDAHM, Allocator HMGEFCKKBID)
	{
		return default(MDHHOEPMEJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2C69710", Offset = "0x2C67F10", VA = "0x182C69710", Slot = "21")]
	public MHGAJIKGEGE OMHDNNDLEHC(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(MHGAJIKGEGE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2C68AF0", Offset = "0x2C672F0", VA = "0x182C68AF0", Slot = "20")]
	public LPLJHAHPEEF JIFMDGFNNCE(MHGAJIKGEGE ECBAIECDCID)
	{
		return default(LPLJHAHPEEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2C68DD0", Offset = "0x2C675D0", VA = "0x182C68DD0")]
	private void JKGAIEIFEIE(KECBEHOHBCN EPFBMINCCNB, LPLJHAHPEEF BBNGIDIFEAM, MHGAJIKGEGE ECBAIECDCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public DEPLKPAFPFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[KHNAILLFHGJ(typeof(LBOJFNDAHOB), new string[] { })]
public class MHCJLNPLMFN : NOFCHOCEBPC, LBOJFNDAHOB
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[NAAJCOHOAKA]
	private ILBBGIPPPPJ KFELNFLBJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[NAAJCOHOAKA]
	private ILGLLPNDOPK NDJHELJNLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[NAAJCOHOAKA]
	private NIKEKFGBDPH KBPHPAFICFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	[NAAJCOHOAKA]
	private OMKEKEENCPE EJMPNJONADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	[NAAJCOHOAKA]
	private GHNAAIGKIGD BNAPCKICLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[NAAJCOHOAKA]
	private CKKBDPJEFPP AHBAIFGILLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private World GOJEBJMIDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private KMCAFCDDGHC HJBOEAINCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private KMCAFCDDGHC MIOHPCCPEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private KMCAFCDDGHC LKGJJHOGJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private KMCAFCDDGHC MINAAFGDPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private KMCAFCDDGHC FNKPIEEOENL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private KMCAFCDDGHC LAIEJBGHIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private KMCAFCDDGHC GKCJMEKANPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private KMCAFCDDGHC NPGOIDKBNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private KMCAFCDDGHC GFHMLBJMNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private KMCAFCDDGHC PLKKBLCHELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private KMCAFCDDGHC AKPKNHHGIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private KMCAFCDDGHC ICCOBNILCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private KMCAFCDDGHC KGPMLKBCJOB;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private bool PJCOBFKGDOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x292AAB0", Offset = "0x29292B0", VA = "0x18292AAB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private bool PHLHALMBKBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x292A960", Offset = "0x2929160", VA = "0x18292A960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private bool KILDFFOMOKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x292AAB0", Offset = "0x29292B0", VA = "0x18292AAB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool PLDBBONIKNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x292AAB0", Offset = "0x29292B0", VA = "0x18292AAB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x292AB20", Offset = "0x2929320", VA = "0x18292AB20", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2B6E420", Offset = "0x2B6CC20", VA = "0x182B6E420")]
	private KMCAFCDDGHC LNFLHCLCDLG<T>() where T : IBBLNIHHOKF
	{
		return default(KMCAFCDDGHC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x292AFE0", Offset = "0x29297E0", VA = "0x18292AFE0")]
	private KMCAFCDDGHC LNFLHCLCDLG(Type EIOLDDJPDLH)
	{
		return default(KMCAFCDDGHC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x292A5D0", Offset = "0x2928DD0", VA = "0x18292A5D0", Slot = "14")]
	public void BCPNPCJJOCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x292AF20", Offset = "0x2929720", VA = "0x18292AF20", Slot = "15")]
	public void JGAAFLNNEIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x292AA50", Offset = "0x2929250", VA = "0x18292AA50", Slot = "5")]
	public void GONCOPMMAPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x292AA70", Offset = "0x2929270", VA = "0x18292AA70", Slot = "6")]
	public void HCEHPONDPGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x292AA10", Offset = "0x2929210", VA = "0x18292AA10", Slot = "7")]
	public void GNIOEOAMOPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x292A8A0", Offset = "0x29290A0", VA = "0x18292A8A0", Slot = "8")]
	public void EMDIKPAKGKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x292B010", Offset = "0x2929810", VA = "0x18292B010", Slot = "9")]
	public void NILEGKHIDGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x292B050", Offset = "0x2929850", VA = "0x18292B050", Slot = "10")]
	public void OIIDANPGMAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x292AFA0", Offset = "0x29297A0", VA = "0x18292AFA0", Slot = "11")]
	public void JNFJGBLBKGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x292A650", Offset = "0x2928E50", VA = "0x18292A650", Slot = "12")]
	public void CDLJBNFGNHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x292A690", Offset = "0x2928E90", VA = "0x18292A690", Slot = "13")]
	public void CHOPHDFCICE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x292A550", Offset = "0x2928D50", VA = "0x18292A550")]
	private void AMHIODCJCBM(KMCAFCDDGHC EDPKAJCAKAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x292A8E0", Offset = "0x29290E0", VA = "0x18292A8E0")]
	private void GCNANLCLKEG(KMCAFCDDGHC EDPKAJCAKAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x292A880", Offset = "0x2929080", VA = "0x18292A880")]
	private void CMEMADLPGCL(KMCAFCDDGHC EDPKAJCAKAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public MHCJLNPLMFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[KHNAILLFHGJ(typeof(KBHALIKOHEM), new string[] { "Editor" })]
[HHKHACIGOAG(JLEAEANKKDG.Application)]
public sealed class KBHALIKOHEM
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate void AOEMLNAECCC(MHGAJIKGEGE ALMGAKBKBMK, CBGNFPNAGKM NFBDMLCENEN, bool HNEJDIADNHG);

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate void PHOFFKLNIIB(MHGAJIKGEGE ALMGAKBKBMK, bool HNEJDIADNHG);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate void HELCHHBDAPN(MHGAJIKGEGE ALMGAKBKBMK, LLNAAGHGEOA OPCEAOKDBMJ, in DMEBMKFMGNA MENBIMCLIOI, bool HNEJDIADNHG);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public KBHALIKOHEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[KHNAILLFHGJ(typeof(global::DGOGKMGLHNE), new string[] { })]
internal class NBJIBJBNAAG : global::DGOGKMGLHNE, NOFCHOCEBPC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[NAAJCOHOAKA]
	private HMBELPNBOEG LNJHNPCFKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[NAAJCOHOAKA]
	private AEDKFOCGAIL AAOAOHHKNIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[NAAJCOHOAKA]
	private KBLIELEJFEK LAEPKFGACAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[NAAJCOHOAKA]
	private CPPOLCLDFAK BOBHLPNKBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private Action<POJLFICOPEH> JJFOLBCEJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NIJBLPDKGGM<Entity> GJPBCFJDGCH;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<POJLFICOPEH> MMGBNMECLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x292DB60", Offset = "0x292C360", VA = "0x18292DB60", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x292DCA0", Offset = "0x292C4A0", VA = "0x18292DCA0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x292DDE0", Offset = "0x292C5E0", VA = "0x18292DDE0", Slot = "6")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x292D9F0", Offset = "0x292C1F0", VA = "0x18292D9F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x292DB60", Offset = "0x292C360", VA = "0x18292DB60")]
	private void LKCKLGFBIDP(Action<POJLFICOPEH> MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x292DCA0", Offset = "0x292C4A0", VA = "0x18292DCA0")]
	private void IGALHDALOBD(Action<POJLFICOPEH> MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x292D950", Offset = "0x292C150", VA = "0x18292D950")]
	private void ALJJHKPIONE(HDEKHHMMCPI NFBDMLCENEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public NBJIBJBNAAG()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct KKGOPGBAHAD : ISystem
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "4")]
	public void OnCreate(ref SystemState COOBJCJFHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
	public void OnDestroy(ref SystemState COOBJCJFHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x24FEAA0", Offset = "0x24FD2A0", VA = "0x1824FEAA0", Slot = "6")]
	public void OnUpdate(ref SystemState COOBJCJFHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	[Unity.Entities.MonoPInvokeCallback(typeof(SystemBaseDelegates.Function))]
	internal static void MCJIBPHDBKI(IntPtr PECDBPPMOJP, IntPtr COOBJCJFHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x24FEAA0", Offset = "0x24FD2A0", VA = "0x1824FEAA0")]
	[Unity.Entities.MonoPInvokeCallback(typeof(SystemBaseDelegates.Function))]
	internal static void DBGPMONIJHN(IntPtr PECDBPPMOJP, IntPtr COOBJCJFHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	[Unity.Entities.MonoPInvokeCallback(typeof(SystemBaseDelegates.Function))]
	internal static void KCKIFNLDNDI(IntPtr PECDBPPMOJP, IntPtr COOBJCJFHEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[KAPPDMKCEOO(JLEAEANKKDG.OMRoom)]
internal class EBLFNFMFDKD : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private GJCOMGMOGCM DOEAPBCCKPJ;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x2C71870", Offset = "0x2C70070", VA = "0x182C71870", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2C718C0", Offset = "0x2C700C0", VA = "0x182C718C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public EBLFNFMFDKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class LCPPCJJIKCK : OJFKKPOGGCL
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private enum AEKHOGDDKOG
	{

	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x291F560", Offset = "0x291DD60", VA = "0x18291F560", Slot = "5")]
	public override Action ECBGJMNDAAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[UnityEngine.Scripting.Preserve]
	public abstract void HJMMHIKHNLJ<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x291F5F0", Offset = "0x291DDF0", VA = "0x18291F5F0")]
	[UnityEngine.Scripting.Preserve]
	public void MKMNEFMGJPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x24F2DB0", Offset = "0x24F15B0", VA = "0x1824F2DB0")]
	protected LCPPCJJIKCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
[KHNAILLFHGJ(typeof(AIADALPADNN), new string[] { })]
public class AIADALPADNN : NOFCHOCEBPC, NOHOJBNCAJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private MKFKBEBMKHL NBFLEJAKAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private OABILJFHBBI LAEPKFGACAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private LLNAAGHGEOA[] CJLHBNACPDM;

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2897BC0", Offset = "0x28963C0", VA = "0x182897BC0", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x28977D0", Offset = "0x2895FD0", VA = "0x1828977D0", Slot = "5")]
	public void GGJEPBDNAAH(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2897AA0", Offset = "0x28962A0", VA = "0x182897AA0")]
	public void HKGEKJMBABC(MHGAJIKGEGE ECBAIECDCID, bool ONPKICLHALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public AIADALPADNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
[KHNAILLFHGJ(typeof(NHLFCCPGHPO), new string[] { })]
public class GBIDMFLCGCB : NHLFCCPGHPO, IEnumerable<BLECIIOHDPI>, IEnumerable, ODKCILIJMBA, PCAPGPPECJN, NOFCHOCEBPC, NOHOJBNCAJC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	[NAAJCOHOAKA]
	private KBLIELEJFEK LAEPKFGACAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly Dictionary<(Type, string), int> AFMBACOGMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private NativeBitArray PIDLFNGDCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeArray<int> BKODBINBLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private AINFFBPBMAB DIKGFIIFOFN;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public NativeBitArray JICDPEBNNJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x918DD0", Offset = "0x9175D0", VA = "0x180918DD0", Slot = "4")]
		get
		{
			return default(NativeBitArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public NativeArray<int> LKJCOIIECHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xB28580", Offset = "0xB26D80", VA = "0x180B28580", Slot = "5")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private int POJDHCBFNML
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xA74D40", Offset = "0xA73540", VA = "0x180A74D40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int GKGAEPJBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2C7B650", Offset = "0x2C79E50", VA = "0x182C7B650", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public BLECIIOHDPI ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2C7B5E0", Offset = "0x2C79DE0", VA = "0x182C7B5E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public BLECIIOHDPI ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2C7B5E0", Offset = "0x2C79DE0", VA = "0x182C7B5E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2C7BED0", Offset = "0x2C7A6D0", VA = "0x182C7BED0", Slot = "13")]
	public void PAHLDMJMCEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B840", Offset = "0x2C7A040", VA = "0x182C7B840", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "15")]
	public void GGJEPBDNAAH(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B8C0", Offset = "0x2C7A0C0", VA = "0x182C7B8C0")]
	private void LEPEPHIKEBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B690", Offset = "0x2C79E90", VA = "0x182C7B690", Slot = "9")]
	public BLECIIOHDPI HPADBCECEJC(FKFIIEPBNGA ELAAPFMOMBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2C7BF20", Offset = "0x2C7A720", VA = "0x182C7BF20")]
	private bool PPHODEGCEEH(Type DOHMIIFHLOD, string MDOAADHDBMA, out BLECIIOHDPI GDMDACGBKDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2C7BCD0", Offset = "0x2C7A4D0", VA = "0x182C7BCD0", Slot = "10")]
	public LLNAAGHGEOA LNDPHGGBMPP(FKFIIEPBNGA ELAAPFMOMBJ)
	{
		return default(LLNAAGHGEOA);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B670", Offset = "0x2C79E70", VA = "0x182C7B670", Slot = "11")]
	public IEnumerator<BLECIIOHDPI> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B670", Offset = "0x2C79E70", VA = "0x182C7B670", Slot = "12")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B600", Offset = "0x2C79E00", VA = "0x182C7B600", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2C7C070", Offset = "0x2C7A870", VA = "0x182C7C070")]
	public GBIDMFLCGCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class KGBCHIJNIKF
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x24FCAA0", Offset = "0x24FB2A0", VA = "0x1824FCAA0")]
	public static void NJCFOPGKAEE(EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF, in float3 GGKJMICDBEF, in quaternion CCIFDEOEEEF, in float3 PKMLPJIAAEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x24FA9C0", Offset = "0x24F91C0", VA = "0x1824FA9C0")]
	public static void BKBHJGJHGAI(EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF, out float4x4 EFACIDLJAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x24FAB00", Offset = "0x24F9300", VA = "0x1824FAB00")]
	private static void BKBHJGJHGAI(EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF, Entity GJPBCFJDGCH, out float4x4 EFACIDLJAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x24FCDE0", Offset = "0x24FB5E0", VA = "0x1824FCDE0")]
	public static void PBCGBABMIAD(EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF, in float4x4 EFACIDLJAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x24FB090", Offset = "0x24F9890", VA = "0x1824FB090")]
	public static void DCBFNLDEJMF(EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF, out float4x4 FEILPNOBNOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x24FC420", Offset = "0x24FAC20", VA = "0x1824FC420")]
	public static void IJAHKMNMPOD(EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF, in float4x4 FEILPNOBNOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x24FA430", Offset = "0x24F8C30", VA = "0x1824FA430")]
	public static float3 AFHOMGAJMLH(EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x24FC620", Offset = "0x24FAE20", VA = "0x1824FC620")]
	public static void KFDLIJACOBF(EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF, in float3 MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x24FAED0", Offset = "0x24F96D0", VA = "0x1824FAED0")]
	public static quaternion CCLAJFGECPI(EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x24FC560", Offset = "0x24FAD60", VA = "0x1824FC560")]
	public static void KBGOAGBBAAK(EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF, in quaternion MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x24FAFC0", Offset = "0x24F97C0", VA = "0x1824FAFC0")]
	public static float3 CLAGLONHNJJ(EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x24FA5D0", Offset = "0x24F8DD0", VA = "0x1824FA5D0")]
	public static void BBAPEDLDGHL(EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF, in float3 MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x24FC350", Offset = "0x24FAB50", VA = "0x1824FC350")]
	public static float IBKKBCCLKMB(EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x24FB540", Offset = "0x24F9D40", VA = "0x1824FB540")]
	public static void FPFILMBFBCA(EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF, float MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x24FB5C0", Offset = "0x24F9DC0", VA = "0x1824FB5C0")]
	public static float3 GANHJMFFNFJ(EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x24FC820", Offset = "0x24FB020", VA = "0x1824FC820")]
	public static void KPFKAIIOHPG(EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF, in float3 MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x24FA340", Offset = "0x24F8B40", VA = "0x1824FA340")]
	public static void ADONEMEIFIN(EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF, out RigidTransform FEILPNOBNOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x24FA220", Offset = "0x24F8A20", VA = "0x1824FA220")]
	public static void ADONEMEIFIN(EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF, out float3 PAOMABBDKAH, out quaternion APAHFEOKBOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x24FB480", Offset = "0x24F9C80", VA = "0x1824FB480")]
	public static void DJPAHKGHOIG(EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF, in float3 GGKJMICDBEF, in quaternion CCIFDEOEEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x24FBE10", Offset = "0x24FA610", VA = "0x1824FBE10")]
	public static void HNGCHLOFNEH(EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF, out float3 PAOMABBDKAH, out quaternion APAHFEOKBOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x24FA750", Offset = "0x24F8F50", VA = "0x1824FA750")]
	public static float3 BGNBGEJHCHN(EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x24FCB40", Offset = "0x24FB340", VA = "0x1824FCB40")]
	public static void OFPFKNFIPHK(EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF, in float3 MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x24FD1D0", Offset = "0x24FB9D0", VA = "0x1824FD1D0")]
	public static void PHPLCBBHGNF(EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF, in quaternion MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x24FB6B0", Offset = "0x24F9EB0", VA = "0x1824FB6B0")]
	public static quaternion GBMIBJMJHCF(EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x24FB8E0", Offset = "0x24FA0E0", VA = "0x1824FB8E0")]
	public static float3 GIJOOKNKPIK(EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x24FBBA0", Offset = "0x24FA3A0", VA = "0x1824FBBA0")]
	public static void HGBCENPALNG(EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF, in float3 MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x24FC8B0", Offset = "0x24FB0B0", VA = "0x1824FC8B0")]
	public static float LEMICPDPBOH(EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x24FC6E0", Offset = "0x24FAEE0", VA = "0x1824FC6E0")]
	public static void KFNMBFMCJEL(EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF, float IMBOBLNABFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x24FAC60", Offset = "0x24F9460", VA = "0x1824FAC60")]
	public static float3 CBFHIEGPLEE(EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x24FC070", Offset = "0x24FA870", VA = "0x1824FC070")]
	public static void HOIKNANDLMA(EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF, in float3 EOALGJMFLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x24FA530", Offset = "0x24F8D30", VA = "0x1824FA530")]
	public static bool AGKCNECALOO(EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF, out Entity GJPBCFJDGCH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[KHNAILLFHGJ(typeof(HCOBHGJLPEC), new string[] { })]
public class NNBAOGLCECI : NOFCHOCEBPC, HCOBHGJLPEC
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class AOMDIMNPJBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public LPLJHAHPEEF localId;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public AOMDIMNPJBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2228350", Offset = "0x2226B50", VA = "0x182228350")]
		internal object CFBGGHAECPE(NNBAOGLCECI a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class KBJILOKDJLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public LPLJHAHPEEF localId;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public KBJILOKDJLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x22320C0", Offset = "0x22308C0", VA = "0x1822320C0")]
		internal object HAKCPOMNEDG(NNBAOGLCECI a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private ILBBGIPPPPJ KFELNFLBJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private HMBELPNBOEG LNJHNPCFKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private IKCMADHPPKE MFHEANKMMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private World EJLFIBCCMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private LFLDNNOOPLA BHGBJCNNLOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[NAAJCOHOAKA]
	private OABNFEOAMFN HOAPIJEHJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private EntityManager EGPFDJODEOJ;

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x2937400", Offset = "0x2935C00", VA = "0x182937400", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x2936140", Offset = "0x2934940", VA = "0x182936140", Slot = "6")]
	public KBFDDENCLAP EOLDLHMFPPA(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x2936B00", Offset = "0x2935300", VA = "0x182936B00", Slot = "5")]
	public void HBCAGCEHILN(LPLJHAHPEEF BBNGIDIFEAM, KBFDDENCLAP MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x2937620", Offset = "0x2935E20", VA = "0x182937620", Slot = "31")]
	public CollisionDetectionMode JCECFPAKJHL(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(CollisionDetectionMode);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x2936520", Offset = "0x2934D20", VA = "0x182936520", Slot = "32")]
	public void FHIFEAIICMD(LPLJHAHPEEF BBNGIDIFEAM, CollisionDetectionMode MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x2939230", Offset = "0x2937A30", VA = "0x182939230", Slot = "33")]
	public JOKBKMCLMIE PBEFMJPBFFH(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(JOKBKMCLMIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x2937B40", Offset = "0x2936340", VA = "0x182937B40", Slot = "34")]
	public void KDBOHLJLONN(LPLJHAHPEEF BBNGIDIFEAM, JOKBKMCLMIE MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2935D60", Offset = "0x2934560", VA = "0x182935D60", Slot = "35")]
	public bool DNAHEOKDHGH(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x29351A0", Offset = "0x29339A0", VA = "0x1829351A0", Slot = "36")]
	public void BBNEPNCCNNG(LPLJHAHPEEF BBNGIDIFEAM, bool MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x2938300", Offset = "0x2936B00", VA = "0x182938300", Slot = "37")]
	public LPLJHAHPEEF MAPBPOGNGKF(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(LPLJHAHPEEF);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x2935590", Offset = "0x2933D90", VA = "0x182935590", Slot = "38")]
	public void CHOBMOLMBHF(LPLJHAHPEEF BBNGIDIFEAM, LPLJHAHPEEF MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x2935990", Offset = "0x2934190", VA = "0x182935990", Slot = "39")]
	public LPLJHAHPEEF DFDIEMMHEBB(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(LPLJHAHPEEF);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x2935EA0", Offset = "0x29346A0", VA = "0x182935EA0", Slot = "40")]
	public void EALODDMPHDN(LPLJHAHPEEF BBNGIDIFEAM, LPLJHAHPEEF MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2936F20", Offset = "0x2935720", VA = "0x182936F20", Slot = "7")]
	public void IFGNKHDPNPM(LPLJHAHPEEF BBNGIDIFEAM, LPLJHAHPEEF MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x2937C40", Offset = "0x2936440", VA = "0x182937C40", Slot = "8")]
	public void KNCIMBFFAPF(LPLJHAHPEEF BBNGIDIFEAM, LPLJHAHPEEF MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2937890", Offset = "0x2936090", VA = "0x182937890", Slot = "9")]
	public int JIDHEKFPBDJ(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x2935840", Offset = "0x2934040", VA = "0x182935840", Slot = "10")]
	public LPLJHAHPEEF DALAHDEPMGB(LPLJHAHPEEF BBNGIDIFEAM, int AMOEKOMGDLG)
	{
		return default(LPLJHAHPEEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2937520", Offset = "0x2935D20", VA = "0x182937520", Slot = "11")]
	public void JBLGNHMDAPL(LPLJHAHPEEF BBNGIDIFEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x29385B0", Offset = "0x2936DB0", VA = "0x1829385B0", Slot = "12")]
	public void MHOIOHDEBGB(LPLJHAHPEEF BBNGIDIFEAM, object AMCDGOPKAOE, LPLJHAHPEEF MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2938700", Offset = "0x2936F00", VA = "0x182938700", Slot = "13")]
	public void MIBNGBOOHIA(LPLJHAHPEEF BBNGIDIFEAM, object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2935000", Offset = "0x2933800", VA = "0x182935000", Slot = "14")]
	public bool BBAECJEMDLB(LPLJHAHPEEF BBNGIDIFEAM, out LPLJHAHPEEF MENBIMCLIOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x2938BE0", Offset = "0x29373E0", VA = "0x182938BE0", Slot = "15")]
	public void NCIJEEANNDH(LPLJHAHPEEF BBNGIDIFEAM, float3 MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x2934DB0", Offset = "0x29335B0", VA = "0x182934DB0", Slot = "16")]
	public bool APGHNMMDKBH(LPLJHAHPEEF BBNGIDIFEAM, out float3 MENBIMCLIOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x2937070", Offset = "0x2935870", VA = "0x182937070", Slot = "17")]
	public void IFNBNNACJOG(LPLJHAHPEEF BBNGIDIFEAM, float3 MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x2938170", Offset = "0x2936970", VA = "0x182938170", Slot = "18")]
	public bool LOANDJHLFAI(LPLJHAHPEEF BBNGIDIFEAM, out float3 MENBIMCLIOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x2937D90", Offset = "0x2936590", VA = "0x182937D90", Slot = "23")]
	[Obsolete]
	public float3 KOGHJGGGEMA(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2935790", Offset = "0x2933F90", VA = "0x182935790", Slot = "24")]
	public float3 CNGECPPJPHI(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x2935DF0", Offset = "0x29345F0", VA = "0x182935DF0", Slot = "25")]
	public void DOILEHPKOHH(LPLJHAHPEEF BBNGIDIFEAM, float3 MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2937EF0", Offset = "0x29366F0", VA = "0x182937EF0", Slot = "26")]
	public void LEEBNNKCKHE(LPLJHAHPEEF BBNGIDIFEAM, float3 MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2936CD0", Offset = "0x29354D0", VA = "0x182936CD0", Slot = "27")]
	[Obsolete]
	public float HJHFNOIPKII(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2935240", Offset = "0x2933A40", VA = "0x182935240", Slot = "28")]
	public float BHMOCKBJDPO(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2937120", Offset = "0x2935920", VA = "0x182937120", Slot = "29")]
	public void IJDFPPHCBKN(LPLJHAHPEEF BBNGIDIFEAM, float MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2938010", Offset = "0x2936810", VA = "0x182938010", Slot = "30")]
	public void LIPDAPHEECE(LPLJHAHPEEF BBNGIDIFEAM, float MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2935BC0", Offset = "0x29343C0", VA = "0x182935BC0", Slot = "19")]
	public void DKMAAEMKGOB(LPLJHAHPEEF BBNGIDIFEAM, (Quaternion rot, Vector3 moments) CLIBLALIAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2938870", Offset = "0x2937070", VA = "0x182938870", Slot = "20")]
	public bool MODBDLLOPDD(LPLJHAHPEEF BBNGIDIFEAM, out quaternion DMNMOPAJMNP, out float3 JOJNFBPIFKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x2936E00", Offset = "0x2935600", VA = "0x182936E00", Slot = "41")]
	public NNAEKKHECGM HOPMKNFJLHE(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(NNAEKKHECGM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2935650", Offset = "0x2933E50", VA = "0x182935650", Slot = "42")]
	public void CKIDEBMELDH(LPLJHAHPEEF BBNGIDIFEAM, NNAEKKHECGM MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x29365C0", Offset = "0x2934DC0", VA = "0x1829365C0", Slot = "66")]
	public void FIJFLKEJJJH(LPLJHAHPEEF BBNGIDIFEAM, object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x29354D0", Offset = "0x2933CD0", VA = "0x1829354D0", Slot = "67")]
	public void BOLLGHEGOHG(LPLJHAHPEEF BBNGIDIFEAM, object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2938500", Offset = "0x2936D00", VA = "0x182938500", Slot = "68")]
	public bool MGFDHGAOOGI(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x2937740", Offset = "0x2935F40", VA = "0x182937740", Slot = "82")]
	public bool JFPOCPBHJDN(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x2936200", Offset = "0x2934A00", VA = "0x182936200", Slot = "83")]
	public void FABLDMDCGON(LPLJHAHPEEF BBNGIDIFEAM, object AMCDGOPKAOE, bool KOHKILNBHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2937FA0", Offset = "0x29367A0", VA = "0x182937FA0", Slot = "84")]
	public void LFIMFKHCIBN(LPLJHAHPEEF BBNGIDIFEAM, bool MBNLNJHDMAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x2935A80", Offset = "0x2934280", VA = "0x182935A80", Slot = "86")]
	public bool DHPPJLKDPKC(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2939320", Offset = "0x2937B20", VA = "0x182939320", Slot = "85")]
	public void PCOCJDNBDCE(LPLJHAHPEEF BBNGIDIFEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x2938470", Offset = "0x2936C70", VA = "0x182938470", Slot = "43")]
	public bool MEHMPKDJBDP(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2939080", Offset = "0x2937880", VA = "0x182939080", Slot = "44")]
	public void OIBHKIADBLM(LPLJHAHPEEF BBNGIDIFEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2935440", Offset = "0x2933C40", VA = "0x182935440", Slot = "45")]
	public bool BOLJANMLGBK(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x2936900", Offset = "0x2935100", VA = "0x182936900", Slot = "46")]
	public void GJOBDMFJJOA(LPLJHAHPEEF BBNGIDIFEAM, bool MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x2936E90", Offset = "0x2935690", VA = "0x182936E90", Slot = "47")]
	public bool IDMDAIIDMJN(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x2936A60", Offset = "0x2935260", VA = "0x182936A60", Slot = "48")]
	public void GLJJFJKNOGO(LPLJHAHPEEF BBNGIDIFEAM, bool MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x2938AC0", Offset = "0x29372C0", VA = "0x182938AC0", Slot = "49")]
	public RigidbodyConstraints NAGDEBKFEHK(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(RigidbodyConstraints);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x2938F20", Offset = "0x2937720", VA = "0x182938F20", Slot = "50")]
	public void NPCGDOPBECA(LPLJHAHPEEF BBNGIDIFEAM, RigidbodyConstraints MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x2935B30", Offset = "0x2934330", VA = "0x182935B30", Slot = "51")]
	public float DJJMAFIGMJI(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x29383D0", Offset = "0x2936BD0", VA = "0x1829383D0", Slot = "52")]
	public void MBONBHFBAAB(LPLJHAHPEEF BBNGIDIFEAM, float MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x2938B50", Offset = "0x2937350", VA = "0x182938B50", Slot = "53")]
	public float NBECAMMDPCJ(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x2938D50", Offset = "0x2937550", VA = "0x182938D50", Slot = "54")]
	public void NDIJHBNNIHO(LPLJHAHPEEF BBNGIDIFEAM, float MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x29376B0", Offset = "0x2935EB0", VA = "0x1829376B0", Slot = "55")]
	public bool JDNGHPIHPKP(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x2938DF0", Offset = "0x29375F0", VA = "0x182938DF0", Slot = "56")]
	public void NNCPNKBNABL(LPLJHAHPEEF BBNGIDIFEAM, bool MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x2935320", Offset = "0x2933B20", VA = "0x182935320", Slot = "57")]
	public bool BLAKDEJJOGI(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x2936860", Offset = "0x2935060", VA = "0x182936860", Slot = "58")]
	public void GHCCKMLCBCC(LPLJHAHPEEF BBNGIDIFEAM, bool MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x29356F0", Offset = "0x2933EF0", VA = "0x1829356F0", Slot = "59")]
	public void CLFGOHGNNHE(LPLJHAHPEEF BBNGIDIFEAM, int MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x2938C90", Offset = "0x2937490", VA = "0x182938C90", Slot = "73")]
	public Rigidbody NCKOJKBACMA(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x29372A0", Offset = "0x2935AA0", VA = "0x1829372A0", Slot = "74")]
	public void IONILNJBNDH(LPLJHAHPEEF BBNGIDIFEAM, Rigidbody MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x2936710", Offset = "0x2934F10", VA = "0x182936710", Slot = "75")]
	public void FNHMFKFJJBB(LPLJHAHPEEF BBNGIDIFEAM, object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x2936080", Offset = "0x2934880", VA = "0x182936080", Slot = "76")]
	public void EFFIDBKNFJH(LPLJHAHPEEF BBNGIDIFEAM, object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x29387C0", Offset = "0x2936FC0", VA = "0x1829387C0", Slot = "77")]
	public bool MIIPAPHJJMM(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x29369A0", Offset = "0x29351A0", VA = "0x1829369A0", Slot = "60")]
	public object GKKNNDHOCAM(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x29393C0", Offset = "0x2937BC0", VA = "0x1829393C0", Slot = "61")]
	public void PKKMGBIEBJD(LPLJHAHPEEF BBNGIDIFEAM, object MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x29380B0", Offset = "0x29368B0", VA = "0x1829380B0", Slot = "62")]
	public object LMGDLPDINGP(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x2937990", Offset = "0x2936190", VA = "0x182937990", Slot = "63")]
	public void JIPAKHDJLAC(LPLJHAHPEEF BBNGIDIFEAM, object MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2938E90", Offset = "0x2937690", VA = "0x182938E90", Slot = "64")]
	public float NOPHEEGLMFC(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x2936480", Offset = "0x2934C80", VA = "0x182936480", Slot = "65")]
	public void FHCNDHPPAAH(LPLJHAHPEEF BBNGIDIFEAM, float MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x2938FC0", Offset = "0x29377C0", VA = "0x182938FC0", Slot = "69")]
	public void OHEOOLIKMOI(LPLJHAHPEEF BBNGIDIFEAM, object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x2934F40", Offset = "0x2933740", VA = "0x182934F40", Slot = "70")]
	public void BAMMBNKCJHF(LPLJHAHPEEF BBNGIDIFEAM, object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x2934D00", Offset = "0x2933500", VA = "0x182934D00", Slot = "71")]
	public bool AIIJIFICJHJ(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x2936680", Offset = "0x2934E80", VA = "0x182936680", Slot = "21")]
	public void FMPPOCGGNFC(LPLJHAHPEEF BBNGIDIFEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x29367D0", Offset = "0x2934FD0", VA = "0x1829367D0", Slot = "22")]
	public void GGBFIJIFPHG(LPLJHAHPEEF BBNGIDIFEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x29353B0", Offset = "0x2933BB0", VA = "0x1829353B0", Slot = "72")]
	public bool BMHHJAJLMPF(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x2935F60", Offset = "0x2934760", VA = "0x182935F60", Slot = "78")]
	public void ECNLGOMEKBO(LPLJHAHPEEF BBNGIDIFEAM, float3 KFENDEDNACE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x2939110", Offset = "0x2937910", VA = "0x182939110", Slot = "79")]
	public void OPMKNCFCKJJ(LPLJHAHPEEF BBNGIDIFEAM, float3 ODPEGCEAOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x2937AF0", Offset = "0x29362F0", VA = "0x182937AF0", Slot = "80")]
	public bool KCBCPJPKHLK(LPLJHAHPEEF BBNGIDIFEAM, out float3 KFENDEDNACE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x29352D0", Offset = "0x2933AD0", VA = "0x1829352D0", Slot = "81")]
	public bool BKOIHPALNFO(LPLJHAHPEEF BBNGIDIFEAM, out float3 ODPEGCEAOBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x29371C0", Offset = "0x29359C0", VA = "0x1829371C0")]
	private DynamicBuffer<Entity> IMMPGENINOI(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(DynamicBuffer<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x2936BF0", Offset = "0x29353F0", VA = "0x182936BF0")]
	private DynamicBuffer<Entity> HBEDFLDOOJA(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(DynamicBuffer<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x2E08E40", Offset = "0x2E07640", VA = "0x182E08E40")]
	private void AJFDAIFBHNC<T>(LPLJHAHPEEF BBNGIDIFEAM, object MENBIMCLIOI, Func<object, T> JKAMEOMADPB) where T : class, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public NNBAOGLCECI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[UnityEngine.Scripting.Preserve]
internal sealed class IBGEKONKIOO<T> : NHLEGKPBPCC where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private EntityQuery EGFJCKOAGFH;

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x570DB90", Offset = "0x570C390", VA = "0x18570DB90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x570DC20", Offset = "0x570C420", VA = "0x18570DC20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x29AA580", Offset = "0x29A8D80", VA = "0x1829AA580")]
	public IBGEKONKIOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
[KHNAILLFHGJ(typeof(NKHJADIBHEP), new string[] { })]
internal sealed class NKHJADIBHEP : ODKCILIJMBA, PCAPGPPECJN, NOFCHOCEBPC, NOHOJBNCAJC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[NAAJCOHOAKA]
	private ILBBGIPPPPJ EJLFIBCCMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private EntityQuery CKNMJMDBCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private EntityQuery IGPNEJLHLAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private EntityQuery AHKEGIPEFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private EntityQuery PJPGJFDIJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private EntityQuery HPCKIPKKCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private EntityQuery ODMHPAPDLFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private EntityQuery PILFAMINAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private bool PMADFOMNIPK;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private EntityManager EOOAJAELBGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2934390", Offset = "0x2932B90", VA = "0x182934390")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public EntityQuery MLKKLHKNPBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xFBE410", Offset = "0xFBCC10", VA = "0x180FBE410")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "4")]
	public void PAHLDMJMCEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x29343E0", Offset = "0x2932BE0", VA = "0x1829343E0", Slot = "5")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x2933DC0", Offset = "0x29325C0", VA = "0x182933DC0", Slot = "6")]
	public void GGJEPBDNAAH(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x2934430", Offset = "0x2932C30", VA = "0x182934430")]
	private EntityQueryDesc JEDENIBCIIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x2933D50", Offset = "0x2932550", VA = "0x182933D50", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x2934490", Offset = "0x2932C90", VA = "0x182934490")]
	public APFIBDNJBME JPCHGEPHIEH(LPLJHAHPEEF PMFGMJJBADH)
	{
		return default(APFIBDNJBME);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x29342E0", Offset = "0x2932AE0", VA = "0x1829342E0")]
	public KECBEHOHBCN HDEFOGKKFEG(Entity AJDEFAPHMKF)
	{
		return default(KECBEHOHBCN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x2934560", Offset = "0x2932D60", VA = "0x182934560")]
	public NKHJADIBHEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class FEOOGCDNBNJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[KHNAILLFHGJ(typeof(NBKDCPLNNHB), new string[] { })]
[ANLOEBHPLMF(typeof(GMHFFPADGAG))]
internal class GMHFFPADGAG : NBKDCPLNNHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<HIJMGKLGPJD> AHIHKGDEEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<HIJMGKLGPJD> LLAPAMGPDBM;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action OAAAMLDFDLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2C817F0", Offset = "0x2C7FFF0", VA = "0x182C817F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x2C81A70", Offset = "0x2C80270", VA = "0x182C81A70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action EJDGIIEFOAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x2C818E0", Offset = "0x2C800E0", VA = "0x182C818E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x2C81980", Offset = "0x2C80180", VA = "0x182C81980", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action CKPGHLPBGOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x2C81B10", Offset = "0x2C80310", VA = "0x182C81B10", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x2C81BB0", Offset = "0x2C803B0", VA = "0x182C81BB0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0xAB2A80", Offset = "0xAB1280", VA = "0x180AB2A80")]
	public void EBPLINDPDIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7F43B0", Offset = "0x7F2BB0", VA = "0x1807F43B0")]
	public void LNKECCGKFEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x8A4F00", Offset = "0x8A3700", VA = "0x1808A4F00")]
	public void MOOJJGLNKHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x2C81890", Offset = "0x2C80090", VA = "0x182C81890")]
	public void AOJCIJMOKBI(HIJMGKLGPJD ODNJCDEIIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x2C81A20", Offset = "0x2C80220", VA = "0x182C81A20")]
	public void FPCFBMJIOEG(HIJMGKLGPJD ODNJCDEIIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public GMHFFPADGAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[KAPPDMKCEOO(JLEAEANKKDG.OMRoom)]
internal class AFBCLHEICOO : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private OIKLJKNPPOI KABPDMFAFHH;

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x2894050", Offset = "0x2892850", VA = "0x182894050", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x28940A0", Offset = "0x28928A0", VA = "0x1828940A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public AFBCLHEICOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class LJNEHHNAECD
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class KGLFODANFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private sealed class <<CalculateTransformPath>g__getNames|0>d
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public KGLFODANFEJ()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[Flags]
public enum DDCCAPLGKMA
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
[KHNAILLFHGJ(typeof(AJCPLKBBBGL), new string[] { "Editor" })]
[HHKHACIGOAG(JLEAEANKKDG.Application)]
public sealed class AJCPLKBBBGL
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate void LNJBIKBKGNN(MHGAJIKGEGE ECBAIECDCID, CBGNFPNAGKM NFBDMLCENEN, DDCCAPLGKMA LPNNBGAFKLN);

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public delegate void GKPKKEBFFDO(MHGAJIKGEGE ECBAIECDCID, DDCCAPLGKMA LPNNBGAFKLN);

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate void LJILOFGCHGG(MHGAJIKGEGE ECBAIECDCID, LLNAAGHGEOA OPCEAOKDBMJ, DMEBMKFMGNA MMOFNBHFDNB, DMEBMKFMGNA MAIOOLBIJID, DDCCAPLGKMA LPNNBGAFKLN);

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public delegate void JNHECJDKOGM(ADKFIICEFJC EECINICJCLK, ReadOnlySpan<byte> BKHMACKFNNF);

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public AJCPLKBBBGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal class FKBFFDHHOKG : GJJADNOGMIL
{
	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A3A0", Offset = "0x2C78BA0", VA = "0x182C7A3A0", Slot = "15")]
	protected override ComponentSystemBase CMFPJFIFJLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x22BD2C0", Offset = "0x22BBAC0", VA = "0x1822BD2C0")]
	public FKBFFDHHOKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[KHNAILLFHGJ(typeof(PHBCFKHMBHC), new string[] { })]
public class GHKNHKCHCBF : PHBCFKHMBHC, NOFCHOCEBPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[NAAJCOHOAKA]
	private HMBELPNBOEG FLLOBPAICGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[NAAJCOHOAKA]
	private MDFAPHDDPNI ICCJCKNDIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly List<NativeListAsync<Entity>> AHBAJGGJOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<(NativeListAsync<Entity>, bool)> HLBNHMIFCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private ODEOGNCDGLA FHFICEBIOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Dictionary<Entity, AFNIAKIMNEA> FLBDPLNJDCD;

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x2C7D3E0", Offset = "0x2C7BBE0", VA = "0x182C7D3E0", Slot = "8")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x2C7D290", Offset = "0x2C7BA90", VA = "0x182C7D290", Slot = "4")]
	public void GHCHPDNLLNJ(NativeListAsync<Entity> KFLBCCAJFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x2C7D240", Offset = "0x2C7BA40", VA = "0x182C7D240", Slot = "5")]
	public void FBPDFGBFKHC(ODEOGNCDGLA FHFICEBIOIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x2C7D300", Offset = "0x2C7BB00", VA = "0x182C7D300", Slot = "6")]
	public void IJIIBGJOPKF(NativeListAsync<Entity> KFLBCCAJFMN, bool GOCFBHOEPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x2C7D6F0", Offset = "0x2C7BEF0", VA = "0x182C7D6F0", Slot = "7")]
	public void KPICKKJPMJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x2C7CDB0", Offset = "0x2C7B5B0", VA = "0x182C7CDB0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x2C7DA70", Offset = "0x2C7C270", VA = "0x182C7DA70")]
	private int LOJDKADGOGG(NativeListAsync<Entity> AHBAJGGJOGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x2C7D450", Offset = "0x2C7BC50", VA = "0x182C7D450")]
	private int KLCMJIKCHOP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x2C7DCD0", Offset = "0x2C7C4D0", VA = "0x182C7DCD0")]
	private int MIGBDEBNIMF(NativeListAsync<Entity> HLBNHMIFCPI, bool JCHLPADGMOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x2C7DFE0", Offset = "0x2C7C7E0", VA = "0x182C7DFE0")]
	public GHKNHKCHCBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x2C7DF00", Offset = "0x2C7C700", VA = "0x182C7DF00")]
	[CompilerGenerated]
	private LPLJHAHPEEF MMFFMACOABN(Entity AJDEFAPHMKF)
	{
		return default(LPLJHAHPEEF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[KHNAILLFHGJ(typeof(NMKNMBOOICD), new string[] { })]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
public class NMKNMBOOICD
{
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private bool HLEJICMEJHJ;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool JLFBNHADDGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x97D920", Offset = "0x97C120", VA = "0x18097D920")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x22BCBF0", Offset = "0x22BB3F0", VA = "0x1822BCBF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public NMKNMBOOICD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal abstract class ENGONJJKJON : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private uint LKDHAJGCELO;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public abstract uint PEJPADLBPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x2875E70", Offset = "0x2874670", VA = "0x182875E70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x2C746D0", Offset = "0x2C72ED0", VA = "0x182C746D0")]
	public MHGAJIKGEGE FDPCOHPFHFF()
	{
		return default(MHGAJIKGEGE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x2C747C0", Offset = "0x2C72FC0", VA = "0x182C747C0")]
	public void JCFJBKHCBKF(NativeArray<MHGAJIKGEGE> LJNBIMMNBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x2C74830", Offset = "0x2C73030", VA = "0x182C74830")]
	public void JCFJBKHCBKF(MHGAJIKGEGE ECBAIECDCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0xCC17D0", Offset = "0xCBFFD0", VA = "0x180CC17D0", Slot = "6")]
	public virtual void OGPDBFFONOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x2C74720", Offset = "0x2C72F20", VA = "0x182C74720")]
	private unsafe void FNMEEGBNNMO(MHGAJIKGEGE* IMFNFADDFOA, int JMKNAPEFDDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x2C74850", Offset = "0x2C73050", VA = "0x182C74850")]
	private unsafe void JCFJBKHCBKF(MHGAJIKGEGE* IMFNFADDFOA, int JMKNAPEFDDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x122BAF0", Offset = "0x122A2F0", VA = "0x18122BAF0")]
	protected ENGONJJKJON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
[KHNAILLFHGJ(typeof(BCLDABOBHLC), new string[] { })]
internal sealed class BCLDABOBHLC : ENGONJJKJON, NOFCHOCEBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[NAAJCOHOAKA]
	private NAHGLKOIEAI BOBHLPNKBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private uint LDFNOAINHMF;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public override uint PEJPADLBPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD10", Offset = "0x7DE510", VA = "0x1807DFD10", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x289A600", Offset = "0x2898E00", VA = "0x18289A600", Slot = "7")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x289A700", Offset = "0x2898F00", VA = "0x18289A700")]
	private void PAFDACDEMJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x289A6A0", Offset = "0x2898EA0", VA = "0x18289A6A0", Slot = "6")]
	public override void OGPDBFFONOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x289A750", Offset = "0x2898F50", VA = "0x18289A750")]
	public BCLDABOBHLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[HHKHACIGOAG(JLEAEANKKDG.LoadInstance)]
[KHNAILLFHGJ(typeof(AJOGCDGIFKP), new string[] { })]
internal sealed class AJOGCDGIFKP : NOFCHOCEBPC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	[NAAJCOHOAKA]
	private NAHGLKOIEAI BOBHLPNKBHC;

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x2898700", Offset = "0x2896F00", VA = "0x182898700", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x28986B0", Offset = "0x2896EB0", VA = "0x1828986B0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public AJOGCDGIFKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
[KHNAILLFHGJ(typeof(MHCMKAJNCAE), new string[] { })]
public class MHCMKAJNCAE : IIIIOJEFCCI, ODKCILIJMBA, PCAPGPPECJN, NOFCHOCEBPC, NOHOJBNCAJC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class DNELBKHFKDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public NCFCHDEHMHC services;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public DNELBKHFKDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x222BB60", Offset = "0x222A360", VA = "0x18222BB60")]
		internal void LGKCGAFNLKO(NOFCHOCEBPC svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class OHKPFKJMCMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public NCFCHDEHMHC services;

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public OHKPFKJMCMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x2236990", Offset = "0x2235190", VA = "0x182236990")]
		internal void DHMJKLKLPKN(NOHOJBNCAJC svc)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[NAAJCOHOAKA]
	private ILBBGIPPPPJ KFELNFLBJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[NAAJCOHOAKA]
	private CHEMKFODHFN PCLAPLAAGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[NAAJCOHOAKA]
	private LGNMGLONHCC ELMENJAOGJB;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public PJIPLFMPMBF EKMAFGNLMNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x7E1570", Offset = "0x7DFD70", VA = "0x1807E1570", Slot = "4")]
		get
		{
			return default(PJIPLFMPMBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x292B590", Offset = "0x2929D90", VA = "0x18292B590", Slot = "5")]
	public void PMIKACAIKGJ(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x292B460", Offset = "0x2929C60", VA = "0x18292B460", Slot = "6")]
	public void PAHLDMJMCEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x292B380", Offset = "0x2929B80", VA = "0x18292B380", Slot = "7")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x292B2A0", Offset = "0x2929AA0", VA = "0x18292B2A0", Slot = "8")]
	public void GGJEPBDNAAH(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x292B170", Offset = "0x2929970", VA = "0x18292B170", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x2B6E4C0", Offset = "0x2B6CCC0", VA = "0x182B6E4C0")]
	private void ALAKDKEBBJN<T>(Action<T> DAKODFMFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public MHCMKAJNCAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[KHNAILLFHGJ(typeof(HOPNNAKMIDH), new string[] { })]
public sealed class NJIGBEFJIFP : HOPNNAKMIDH, ODKCILIJMBA, PCAPGPPECJN, NOFCHOCEBPC, NOHOJBNCAJC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class LOHMMIGGJBC : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
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
		public NJIGBEFJIFP <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private (string, string) System.Collections.Generic.IEnumerator<(System.Stringpath,System.Stringtoken)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0xA64970", Offset = "0xA63170", VA = "0x180A64970", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((string, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x2234130", Offset = "0x2232930", VA = "0x182234130", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x21D5240", Offset = "0x21D3A40", VA = "0x1821D5240")]
		[DebuggerHidden]
		public LOHMMIGGJBC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x2233DF0", Offset = "0x22325F0", VA = "0x182233DF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x22340F0", Offset = "0x22328F0", VA = "0x1822340F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x2234040", Offset = "0x2232840", VA = "0x182234040", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x2234040", Offset = "0x2232840", VA = "0x182234040", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[NAAJCOHOAKA]
	private FCNMLNBCAFD LAEPKFGACAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly OBFAKEELOOG GAKDJLIHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly Dictionary<string, CPEALHPMBCC> ODOPOMIPKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly Dictionary<int, FIJBLGANFNJ> IHDBODOFDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly List<KGGCPADPPEB> CJBHMNOKMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private CPPOLCLDFAK DHLGLCIPIEP;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public FIJBLGANFNJ GCNHOFIBKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x29327A0", Offset = "0x2930FA0", VA = "0x1829327A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public List<KGGCPADPPEB> IPOLKGKKIKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7F3350", Offset = "0x7F1B50", VA = "0x1807F3350", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "9")]
	public void PAHLDMJMCEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x2933340", Offset = "0x2931B40", VA = "0x182933340", Slot = "10")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x29332E0", Offset = "0x2931AE0", VA = "0x1829332E0", Slot = "11")]
	public void GGJEPBDNAAH(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x29328E0", Offset = "0x29310E0", VA = "0x1829328E0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x2933580", Offset = "0x2931D80", VA = "0x182933580", Slot = "6")]
	public bool PCCNPEFMLBP(KGGCPADPPEB OPCEAOKDBMJ, out FIJBLGANFNJ PBBIBKAILDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x2932D00", Offset = "0x2931500", VA = "0x182932D00")]
	private void FJEHPDIHPMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2933140", Offset = "0x2931940", VA = "0x182933140")]
	private void GCNLBELGGKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2932740", Offset = "0x2930F40", VA = "0x182932740")]
	private CPEALHPMBCC CJEGJMEJKBB(string KMDHOHBKOIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x29327A0", Offset = "0x2930FA0", VA = "0x1829327A0")]
	private CPEALHPMBCC GPHNIKPNLIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x2932A90", Offset = "0x2931290", VA = "0x182932A90")]
	private CPEALHPMBCC EIDBKOJFIHF(string KMDHOHBKOIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x29336F0", Offset = "0x2931EF0", VA = "0x1829336F0")]
	private CPEALHPMBCC PIJFPFFLPLJ(string NFJIPFJDKNL, string AMCDGOPKAOE, [Optional] CPEALHPMBCC EKHCNAPLCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x2932850", Offset = "0x2931050", VA = "0x182932850")]
	[IteratorStateMachine(typeof(LOHMMIGGJBC))]
	private IEnumerable<(string, string)> DHMIAMAMMIO(string KMDHOHBKOIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x2933530", Offset = "0x2931D30", VA = "0x182933530")]
	private bool OLOEJKHPIBC(KGGCPADPPEB OPCEAOKDBMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x2933450", Offset = "0x2931C50", VA = "0x182933450")]
	private OBFAKEELOOG LAPGHJPICDI(KGGCPADPPEB OPCEAOKDBMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x2932800", Offset = "0x2931000", VA = "0x182932800")]
	private OBFAKEELOOG DAOHBGEHFJB(KGGCPADPPEB OPCEAOKDBMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x2932A00", Offset = "0x2931200", VA = "0x182932A00")]
	private OBFAKEELOOG EEHKMIEJFLC(KGGCPADPPEB OPCEAOKDBMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x2AD2390", Offset = "0x2AD0B90", VA = "0x182AD2390")]
	private T NBAEIHHLGNL<T>(KGGCPADPPEB OPCEAOKDBMJ) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x2933610", Offset = "0x2931E10", VA = "0x182933610")]
	private FieldInfo PGHNLKDBJDD(KGGCPADPPEB OPCEAOKDBMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x29333A0", Offset = "0x2931BA0", VA = "0x1829333A0", Slot = "7")]
	public void JACMNDDEBJP(KGGCPADPPEB OPCEAOKDBMJ, JEPLFFFAMKN LKAHNEAJLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x2933090", Offset = "0x2931890", VA = "0x182933090", Slot = "8")]
	public void GCELDLHNPGC(KGGCPADPPEB OPCEAOKDBMJ, JEPLFFFAMKN LKAHNEAJLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x2933800", Offset = "0x2932000", VA = "0x182933800")]
	public NJIGBEFJIFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x2932970", Offset = "0x2931170", VA = "0x182932970")]
	[CompilerGenerated]
	private int ECNHOJELEEB(KGGCPADPPEB MBLAPCMEEGI, KGGCPADPPEB NBEGIGNBOIE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class PCLAIAKPMKL
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class MMICHGFBEBN
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class NCCODAJMOJC
{
	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x292DF90", Offset = "0x292C790", VA = "0x18292DF90")]
	public static void HCABAALHOFC(JNGNMMOLKFF MBNJNNGOKFP, string JNDOHHLIMLH, LPLJHAHPEEF HDIMJNMJOGM, Action JKAMEOMADPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x292E1F0", Offset = "0x292C9F0", VA = "0x18292E1F0")]
	public static void HCABAALHOFC(JNGNMMOLKFF MBNJNNGOKFP, string JNDOHHLIMLH, MDHHOEPMEJH IIEMDPPGAGJ, Action JKAMEOMADPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[KHNAILLFHGJ(typeof(HMLONANDNGP), new string[] { })]
public class KJFFABNGPGA : NOFCHOCEBPC, HMLONANDNGP
{
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private EntityManager EADLBIHJKBG;

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x24FDE90", Offset = "0x24FC690", VA = "0x1824FDE90", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x24FDE20", Offset = "0x24FC620", VA = "0x1824FDE20", Slot = "5")]
	public void EEGACNDDJLF(LPLJHAHPEEF PMFGMJJBADH, bool MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x24FDFD0", Offset = "0x24FC7D0", VA = "0x1824FDFD0", Slot = "6")]
	public void PIKMHCOAEFM(LPLJHAHPEEF PMFGMJJBADH, bool MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x24FDF10", Offset = "0x24FC710", VA = "0x1824FDF10", Slot = "7")]
	public void LMIAFLCIBPJ(LPLJHAHPEEF PMFGMJJBADH, int MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x9A5220", Offset = "0x9A3A20", VA = "0x1809A5220")]
	private void OLFLGMGEIBD<T>(LPLJHAHPEEF PMFGMJJBADH, bool MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x9A5180", Offset = "0x9A3980", VA = "0x1809A5180")]
	private void OLFLGMGEIBD<T>(LPLJHAHPEEF PMFGMJJBADH, T NFBDMLCENEN) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public KJFFABNGPGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[KHNAILLFHGJ(typeof(NGBHDJDBPLD), new string[] { })]
[HHKHACIGOAG(JLEAEANKKDG.LoadInstance)]
public sealed class NGBHDJDBPLD : NOFCHOCEBPC, NOHOJBNCAJC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class HODJBMJHGJM : IEnumerable<RRCustomPropTag>, IEnumerable, IEnumerator<RRCustomPropTag>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private RRCustomPropTag <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public NGBHDJDBPLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private List<RRCustomPropTag> <list>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private Scene <scene>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private GameObject[] <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private int <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private GameObject <root>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private List<RRCustomPropTag>.Enumerator <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private RRCustomPropTag <tag>5__8;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		RRCustomPropTag IEnumerator<RRCustomPropTag>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xABFAA0", Offset = "0xABE2A0", VA = "0x180ABFAA0")]
		[DebuggerHidden]
		public HODJBMJHGJM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x2230860", Offset = "0x222F060", VA = "0x182230860", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x22303F0", Offset = "0x222EBF0", VA = "0x1822303F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x2230730", Offset = "0x222EF30", VA = "0x182230730")]
		private void PPLJHCFFCFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x2230820", Offset = "0x222F020", VA = "0x182230820", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x2230780", Offset = "0x222EF80", VA = "0x182230780", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x2230780", Offset = "0x222EF80", VA = "0x182230780", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Dictionary<SerializableGuid, GGEPJACPGID> ENHBBBMJIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly List<SerializableGuid> PIMICLDHGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly Dictionary<SerializableGuid, GameObject> CBGOOONHBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private HMBELPNBOEG LNJHNPCFKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private FCNMLNBCAFD LAEPKFGACAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private NAHGLKOIEAI BOBHLPNKBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private NBKDCPLNNHB NDJHELJNLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private ILBBGIPPPPJ EJLFIBCCMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private LGNMGLONHCC ELMENJAOGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private JPAJHNEFJFD<GGEPJACPGID> FAFAMPBOGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private GameObject FNAEALMKBAJ;

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x29307F0", Offset = "0x292EFF0", VA = "0x1829307F0", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x292FD70", Offset = "0x292E570", VA = "0x18292FD70", Slot = "5")]
	public void GGJEPBDNAAH(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x292F9A0", Offset = "0x292E1A0", VA = "0x18292F9A0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x292FB40", Offset = "0x292E340", VA = "0x18292FB40")]
	private void EDKGHFENDNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x29303B0", Offset = "0x292EBB0", VA = "0x1829303B0")]
	internal void IHNFADEGLNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x2930B20", Offset = "0x292F320", VA = "0x182930B20")]
	private void MHKOEBMFIKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x2930A20", Offset = "0x292F220", VA = "0x182930A20")]
	private void KMEEFAHNJBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x292F930", Offset = "0x292E130", VA = "0x18292F930")]
	[IteratorStateMachine(typeof(HODJBMJHGJM))]
	private IEnumerable<RRCustomPropTag> DOAODLPCOCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x292FF00", Offset = "0x292E700", VA = "0x18292FF00")]
	private void GGKPHFEOMIC(LPLJHAHPEEF BBNGIDIFEAM, in DMEBMKFMGNA MDBHGCNGNDL, in DMEBMKFMGNA PCKLDBCFAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x29308E0", Offset = "0x292F0E0", VA = "0x1829308E0")]
	private void JACMNDDEBJP(SerializableGuid IBLFHKFALNL, GameObject OAOEKKJFJKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x292F5A0", Offset = "0x292DDA0", VA = "0x18292F5A0")]
	private void AHGMCCILCAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x292FBA0", Offset = "0x292E3A0", VA = "0x18292FBA0")]
	private bool EJJGCLNHPHN(GGEPJACPGID BFIAIKKIHBG, Transform GJPBCFJDGCH, out GameObject KLLABPMEFNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x292FB50", Offset = "0x292E350", VA = "0x18292FB50")]
	public void EEMEPIGIECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x2930D90", Offset = "0x292F590", VA = "0x182930D90")]
	public NGBHDJDBPLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[DefaultMember("Item")]
[KHNAILLFHGJ(typeof(FCNMLNBCAFD), new string[] { })]
public class EOIOKMHFFDH : FCNMLNBCAFD, IEnumerable<KGGCPADPPEB>, IEnumerable, NOFCHOCEBPC, NOHOJBNCAJC, NADHHNFNDJH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[NAAJCOHOAKA]
	private HMBELPNBOEG LNJHNPCFKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	[NAAJCOHOAKA]
	private NHLFCCPGHPO DFBCJBEDHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private KGGCPADPPEB[] FKPCEGHLHDK;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int GKGAEPJBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x2C74EA0", Offset = "0x2C736A0", VA = "0x182C74EA0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public KGGCPADPPEB ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x2C74AC0", Offset = "0x2C732C0", VA = "0x182C74AC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x2C75120", Offset = "0x2C73920", VA = "0x182C75120", Slot = "10")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x2C74C50", Offset = "0x2C73450", VA = "0x182C74C50", Slot = "11")]
	public void GGJEPBDNAAH(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x2C74AD0", Offset = "0x2C732D0", VA = "0x182C74AD0")]
	private KGGCPADPPEB BKBAOJBAHCF(int AMOEKOMGDLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x2C75000", Offset = "0x2C73800", VA = "0x182C75000", Slot = "6")]
	public KGGCPADPPEB HPADBCECEJC(FKFIIEPBNGA ELAAPFMOMBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x2C75190", Offset = "0x2C73990", VA = "0x182C75190", Slot = "7")]
	public LLNAAGHGEOA LNDPHGGBMPP(FKFIIEPBNGA ELAAPFMOMBJ)
	{
		return default(LLNAAGHGEOA);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x2C74EF0", Offset = "0x2C736F0", VA = "0x182C74EF0", Slot = "8")]
	public IEnumerator<KGGCPADPPEB> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x2C74EF0", Offset = "0x2C736F0", VA = "0x182C74EF0", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x2B003B0", Offset = "0x2AFEBB0", VA = "0x182B003B0", Slot = "12")]
	public void KBBEFAPNECG<TKey, T>(ALJIFOIANLF<TKey, T> OPCEAOKDBMJ, [Optional] object HNBDDLBIIOF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x2C74BB0", Offset = "0x2C733B0", VA = "0x182C74BB0", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public EOIOKMHFFDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x2C74AC0", Offset = "0x2C732C0", VA = "0x182C74AC0")]
	[CompilerGenerated]
	private KGGCPADPPEB DFOBAJBIKDP(int NLNOELCPLOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[UnityEngine.Scripting.Preserve]
internal class GHNONPIMAFG : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private EntityQuery MIDGNNDNMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private HMBELPNBOEG LNJHNPCFKIL;

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x2C7E1D0", Offset = "0x2C7C9D0", VA = "0x182C7E1D0", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x2C7E220", Offset = "0x2C7CA20", VA = "0x182C7E220", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x2C7E2B0", Offset = "0x2C7CAB0", VA = "0x182C7E2B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public GHNONPIMAFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[DefaultMember("Item")]
public class BCHGHHJOBBJ<From, To> where From : struct, IEquatable<From>
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
[KHNAILLFHGJ(typeof(AEFMJFMMPFD), new string[] { })]
public class AEFMJFMMPFD : NOFCHOCEBPC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	[NAAJCOHOAKA]
	private GJCOMGMOGCM LJAHGKLIMIM;

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x2894000", Offset = "0x2892800", VA = "0x182894000", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x2893FE0", Offset = "0x28927E0", VA = "0x182893FE0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public AEFMJFMMPFD()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class DisembodiedObjectView : MonoBehaviour, INNKBFIJCKK
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool CENAPLLCNNC
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x7EE860", Offset = "0x7ED060", VA = "0x1807EE860", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public LPLJHAHPEEF OKNLLHGKDMP
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0xA64970", Offset = "0xA63170", VA = "0x180A64970", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(LPLJHAHPEEF);
			}
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x294EB40", Offset = "0x294D340", VA = "0x18294EB40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x2C6E890", Offset = "0x2C6D090", VA = "0x182C6E890")]
		public void SetName(string MDOAADHDBMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x90A150", Offset = "0x908950", VA = "0x18090A150")]
		public DisembodiedObjectView()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class IFMHKDDEJFN
{
	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x24EF1C0", Offset = "0x24ED9C0", VA = "0x1824EF1C0")]
	public static void CJLKDKIBMNE(ComponentSystemBase EDPKAJCAKAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
[KHNAILLFHGJ(typeof(BGNBCCFEDLB), new string[] { })]
internal sealed class BGNBCCFEDLB : ENGONJJKJON
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public override uint PEJPADLBPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x893100", Offset = "0x891900", VA = "0x180893100", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x289A750", Offset = "0x2898F50", VA = "0x18289A750")]
	public BGNBCCFEDLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class HBIPEGJNCJM
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class DGHJHMDOCAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public NCFCHDEHMHC services;

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public DGHJHMDOCAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x222B380", Offset = "0x2229B80", VA = "0x18222B380")]
		internal void CEIAOLAIEGI(NOFCHOCEBPC svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x222B3E0", Offset = "0x2229BE0", VA = "0x18222B3E0")]
		internal void PACJCLEFHGE(NOHOJBNCAJC svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x24E3F20", Offset = "0x24E2720", VA = "0x1824E3F20")]
	public static void DCJPBLFNJLO(this World EJLFIBCCMHH, NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x9A4170", Offset = "0x9A2970", VA = "0x1809A4170")]
	public static void ENPENIEBKPD<T>(this World EJLFIBCCMHH, Action<T> DAKODFMFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x1CAD710", Offset = "0x1CABF10", VA = "0x181CAD710")]
	public static void BBFGNPPJAGJ<T>(this World EJLFIBCCMHH, Action<T> DAKODFMFHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x1CAD4E0", Offset = "0x1CABCE0", VA = "0x181CAD4E0")]
	public static void BBFGNPPJAGJ<T>(IEnumerable<ComponentSystemBase> HMNAFOKFDKP, Action<T> DAKODFMFHFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[KHNAILLFHGJ(typeof(FNKAOJGCPPO), new string[] { })]
internal class FLDFDAGBLFI : FNKAOJGCPPO, NOFCHOCEBPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private enum Flag
	{
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		Allowed,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		Clone,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		Copy,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		Undo,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		UndoCreation,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		Physics,
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		SerializationV4,
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		HierarchyViewVisible
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class PGGHMFLKBJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public PGGHMFLKBJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x2237430", Offset = "0x2235C30", VA = "0x182237430")]
		internal object HGLICKIILMN((string name, bool value) a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[NAAJCOHOAKA]
	private NAHGLKOIEAI BOBHLPNKBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[NAAJCOHOAKA]
	private KANIKAONFJI HLEJICMEJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private NativeBitArray FANFGKCMBKI;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public KCIFFDLJEIC BMCOEBHBIOA
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x2C7A5A0", Offset = "0x2C78DA0", VA = "0x182C7A5A0", Slot = "4")]
		get
		{
			return default(KCIFFDLJEIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public KCIFFDLJEIC IFFNPFCMKEB
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x2C7A9B0", Offset = "0x2C791B0", VA = "0x182C7A9B0", Slot = "5")]
		get
		{
			return default(KCIFFDLJEIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public KCIFFDLJEIC BBGJPJPLCPO
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x2C7AB20", Offset = "0x2C79320", VA = "0x182C7AB20", Slot = "6")]
		get
		{
			return default(KCIFFDLJEIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public KCIFFDLJEIC LIFMNDKANBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x2C7A590", Offset = "0x2C78D90", VA = "0x182C7A590", Slot = "7")]
		get
		{
			return default(KCIFFDLJEIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public KCIFFDLJEIC GFIDAKODEAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x2C7AC30", Offset = "0x2C79430", VA = "0x182C7AC30", Slot = "8")]
		get
		{
			return default(KCIFFDLJEIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public KCIFFDLJEIC HKPJDPLPPEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x2C7A680", Offset = "0x2C78E80", VA = "0x182C7A680", Slot = "9")]
		get
		{
			return default(KCIFFDLJEIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public KCIFFDLJEIC OBIJHCNJMGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x2C7A710", Offset = "0x2C78F10", VA = "0x182C7A710", Slot = "10")]
		get
		{
			return default(KCIFFDLJEIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public KCIFFDLJEIC CFLOJLHMGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x2C7A5C0", Offset = "0x2C78DC0", VA = "0x182C7A5C0", Slot = "11")]
		get
		{
			return default(KCIFFDLJEIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private int EAPAFDKDONP
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x2C7AB80", Offset = "0x2C79380", VA = "0x182C7AB80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A9C0", Offset = "0x2C791C0", VA = "0x182C7A9C0", Slot = "12")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A5D0", Offset = "0x2C78DD0", VA = "0x182C7A5D0", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x2C7AB30", Offset = "0x2C79330", VA = "0x182C7AB30")]
	private void LKLFKKBPIEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A720", Offset = "0x2C78F20", VA = "0x182C7A720")]
	private void GODHJGNBNID(Flag KMIJNFGJKHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A690", Offset = "0x2C78E90", VA = "0x182C7A690")]
	private KCIFFDLJEIC FIOCPDMKNNF(Flag KMIJNFGJKHN)
	{
		return default(KCIFFDLJEIC);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A990", Offset = "0x2C79190", VA = "0x182C7A990")]
	private KCIFFDLJEIC HCLKPLOFNON(Flag KMIJNFGJKHN)
	{
		return default(KCIFFDLJEIC);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public FLDFDAGBLFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[KHNAILLFHGJ(typeof(JGHGFLIKNJI), new string[] { })]
public class ACLOCMAJKJJ : NOFCHOCEBPC, NOHOJBNCAJC, JGHGFLIKNJI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private HMBELPNBOEG LNJHNPCFKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private AEDKFOCGAIL AAOAOHHKNIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private ILBBGIPPPPJ EJLFIBCCMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private DLJKMJDECEO HJIMKOGCLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private CPPOLCLDFAK DHLGLCIPIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private OLPOJKFPPCB BAHDAKBABBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private int BFFNDNKIACF;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool BLNAFLEBMHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x2893B20", Offset = "0x2892320", VA = "0x182893B20", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public LPLJHAHPEEF NNFHGAOKNEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x2893570", Offset = "0x2891D70", VA = "0x182893570", Slot = "9")]
		get
		{
			return default(LPLJHAHPEEF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x2893140", Offset = "0x2891940", VA = "0x182893140", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public IFDBCDKGAKP GMHKNDAAOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x2893B70", Offset = "0x2892370", VA = "0x182893B70", Slot = "11")]
		get
		{
			return default(IFDBCDKGAKP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x2893140", Offset = "0x2891940", VA = "0x182893140", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public IFDBCDKGAKP NPDMMDFOPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x28935B0", Offset = "0x2891DB0", VA = "0x1828935B0", Slot = "13")]
		get
		{
			return default(IFDBCDKGAKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private uint GICKBLNLCIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x2892DE0", Offset = "0x28915E0", VA = "0x182892DE0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event IPKOFMACBNG IGCNDNBCPAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x2892D40", Offset = "0x2891540", VA = "0x182892D40", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x2893400", Offset = "0x2891C00", VA = "0x182893400", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x28934A0", Offset = "0x2891CA0", VA = "0x1828934A0", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x2893260", Offset = "0x2891A60", VA = "0x182893260", Slot = "5")]
	public void GGJEPBDNAAH(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x2892F60", Offset = "0x2891760", VA = "0x182892F60", Slot = "19")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x2893610", Offset = "0x2891E10", VA = "0x182893610")]
	private void LPIEPPHGBED(HDEKHHMMCPI NFBDMLCENEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x28938A0", Offset = "0x28920A0", VA = "0x1828938A0", Slot = "14")]
	public LPLJHAHPEEF MFGAAMGNJKL(LPLJHAHPEEF MPGGAHNCHOK, LPLJHAHPEEF PGMGJHKACLK)
	{
		return default(LPLJHAHPEEF);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x2893160", Offset = "0x2891960", VA = "0x182893160", Slot = "15")]
	public bool FOCFAPBPKCF(LPLJHAHPEEF MPGGAHNCHOK, LPLJHAHPEEF PGMGJHKACLK, out LPLJHAHPEEF PLFDJFKPNCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x2892E30", Offset = "0x2891630", VA = "0x182892E30", Slot = "16")]
	public void DLDFGGEEMKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x2893BD0", Offset = "0x28923D0", VA = "0x182893BD0", Slot = "17")]
	public void PGCLHELOFMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x28939A0", Offset = "0x28921A0", VA = "0x1828939A0", Slot = "18")]
	public bool NBEGJHJNAKK(LPLJHAHPEEF BEELAINJGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x2893050", Offset = "0x2891850", VA = "0x182893050")]
	private void EJBEPECEBDC(LPLJHAHPEEF CCNFOIAJJEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public ACLOCMAJKJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[HHKHACIGOAG(JLEAEANKKDG.Application)]
[KHNAILLFHGJ(typeof(DKKLEIPMCPM), new string[] { })]
internal class DKKLEIPMCPM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	public void LONOKKEGKEN(string MDOAADHDBMA, EntityManager EADLBIHJKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public DKKLEIPMCPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class PHNDDONOEJJ
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x22C1600", Offset = "0x22BFE00", VA = "0x1822C1600")]
	public static bool LNAHADNLGPP(FKKNGLCNOFO EFFNKFMAAGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x22C1210", Offset = "0x22BFA10", VA = "0x1822C1210")]
	public static FKKNGLCNOFO JACMNDDEBJP(GameObject OAOEKKJFJKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x22C1420", Offset = "0x22BFC20", VA = "0x1822C1420")]
	public static FKKNGLCNOFO JACMNDDEBJP(GameObject OAOEKKJFJKH, MHGAJIKGEGE ECBAIECDCID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x22C1020", Offset = "0x22BF820", VA = "0x1822C1020")]
	public static bool DNDLCPLJLGP(GameObject HBPFJCNENNP, string NECMDMMFDDJ, bool PCIGGGIFHAN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal readonly struct KMCAFCDDGHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly ComponentSystemBase EDPKAJCAKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly ProfilerMarker AJAJOBDBGFL;

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x2501670", Offset = "0x24FFE70", VA = "0x182501670")]
	public KMCAFCDDGHC(World EJLFIBCCMHH, Type EIOLDDJPDLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x25015F0", Offset = "0x24FFDF0", VA = "0x1825015F0")]
	public void CMEMADLPGCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
[KHNAILLFHGJ(typeof(KMJAMFMINGI), new string[] { })]
internal sealed class KMJAMFMINGI : NOFCHOCEBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private GOHOPIDFNBA CBGOOONHBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	[NAAJCOHOAKA]
	private NKHJADIBHEP OIPELOCIIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	[NAAJCOHOAKA]
	private ILBBGIPPPPJ EJLFIBCCMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	[NAAJCOHOAKA]
	private LGNMGLONHCC FMICHEFGCMM;

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x291DC20", Offset = "0x291C420", VA = "0x18291DC20", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x291DCD0", Offset = "0x291C4D0", VA = "0x18291DCD0")]
	public MDHHOEPMEJH MMCNJDCOMKI(MDHHOEPMEJH FGPFEGPDAHM, Allocator HMGEFCKKBID)
	{
		return default(MDHHOEPMEJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x291DA80", Offset = "0x291C280", VA = "0x18291DA80")]
	private void BGINOJMIJKG(NativeParallelMultiHashMap<int, (LPLJHAHPEEF src, LPLJHAHPEEF dst)> ALEOIFDHNOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x291E2D0", Offset = "0x291CAD0", VA = "0x18291E2D0")]
	private void PIAHODAFPOE(NativeParallelMultiHashMap<int, (LPLJHAHPEEF src, LPLJHAHPEEF dst)> ALEOIFDHNOE, int MCBNACIDAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x291DE00", Offset = "0x291C600", VA = "0x18291DE00")]
	private void NMIDAAFOOHF(NativeParallelMultiHashMap<int, (LPLJHAHPEEF src, LPLJHAHPEEF dst)> ALEOIFDHNOE, int MCBNACIDAGA, ADGLENNGCHF LAEPKFGACAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x291DFF0", Offset = "0x291C7F0", VA = "0x18291DFF0")]
	private NativeParallelMultiHashMap<int, (LPLJHAHPEEF, LPLJHAHPEEF)> PHFDLIKJKPC(Allocator HMGEFCKKBID, MDHHOEPMEJH FGPFEGPDAHM, out MDHHOEPMEJH CGNMMKCPHJE)
	{
		return default(NativeParallelMultiHashMap<int, (LPLJHAHPEEF, LPLJHAHPEEF)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public KMJAMFMINGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[HHKHACIGOAG(JLEAEANKKDG.LoadInstance)]
[KHNAILLFHGJ(typeof(KHCEBHPAGLP), new string[] { })]
public class KHCEBHPAGLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly Dictionary<JBOEKGNECFI, string> LDJKDMAEAHD;

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x24FD450", Offset = "0x24FBC50", VA = "0x1824FD450")]
	public GameObject OPAJAGHDAFO(JBOEKGNECFI JAAFDDAIDED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x24FD520", Offset = "0x24FBD20", VA = "0x1824FD520")]
	public KHCEBHPAGLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DefaultMember("Item")]
public class GIHKMJKONFK<From, To>
{
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[KHNAILLFHGJ(typeof(ELJIMGIPHHA), new string[] { })]
[HHKHACIGOAG(JLEAEANKKDG.PhotonRoom)]
public class ELJIMGIPHHA : ODKCILIJMBA, PCAPGPPECJN, NOFCHOCEBPC, NOHOJBNCAJC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private NAHGLKOIEAI BOBHLPNKBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private LDDLEDJLLMH IFMGAECCJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private NativeList<int> JFJOOEKOHCH;

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x2C745E0", Offset = "0x2C72DE0", VA = "0x182C745E0", Slot = "4")]
	public void PAHLDMJMCEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x2C74570", Offset = "0x2C72D70", VA = "0x182C74570", Slot = "5")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x2C744D0", Offset = "0x2C72CD0", VA = "0x182C744D0", Slot = "6")]
	public void GGJEPBDNAAH(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x2C74200", Offset = "0x2C72A00", VA = "0x182C74200", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x2C742C0", Offset = "0x2C72AC0", VA = "0x182C742C0")]
	public void ENEJDCAPJNI(NativeParallelHashSet<int> APODIEHBHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x2C74490", Offset = "0x2C72C90", VA = "0x182C74490")]
	public void FEFKMKJJMHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public ELJIMGIPHHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[KHNAILLFHGJ(typeof(IENJDONBBIN), new string[] { })]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
internal class IENJDONBBIN : NOFCHOCEBPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static readonly JNGNMMOLKFF AKAIBNBADMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	[NAAJCOHOAKA]
	private NAHGLKOIEAI BOBHLPNKBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	[NAAJCOHOAKA]
	private ILBBGIPPPPJ KFELNFLBJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	[NAAJCOHOAKA]
	private HMBELPNBOEG LNJHNPCFKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[NAAJCOHOAKA]
	private IKCMADHPPKE MFHEANKMMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private ILGLLPNDOPK NDJHELJNLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private EntityQuery EGFJCKOAGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private EntityQuery JBJIHLBELOA;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private EntityManager EOOAJAELBGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x24ED620", Offset = "0x24EBE20", VA = "0x1824ED620")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x24EDA90", Offset = "0x24EC290", VA = "0x1824EDA90", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x24ED4C0", Offset = "0x24EBCC0", VA = "0x1824ED4C0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x24EC470", Offset = "0x24EAC70", VA = "0x1824EC470")]
	public LIIAPEIGDIL AMOMLNLOMHC(IEnumerable<PMMFFJMLFOG> KPNKLACANNG)
	{
		return default(LIIAPEIGDIL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x24ED4D0", Offset = "0x24EBCD0", VA = "0x1824ED4D0")]
	public static bool EIKCFOHCOFH(PMMFFJMLFOG AJNIDCPPJGC, out MHGAJIKGEGE ECBAIECDCID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x24EC760", Offset = "0x24EAF60", VA = "0x1824EC760")]
	private LIIAPEIGDIL CBFDPNKGKGM(IEnumerable<PMMFFJMLFOG> KPNKLACANNG)
	{
		return default(LIIAPEIGDIL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x24EC580", Offset = "0x24EAD80", VA = "0x1824EC580")]
	private (List<PMMFFJMLFOG>, int[], int) APLIEJPHMPN(IEnumerable<PMMFFJMLFOG> KPNKLACANNG)
	{
		return default((List<PMMFFJMLFOG>, int[], int));
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x24ECC40", Offset = "0x24EB440", VA = "0x1824ECC40")]
	private Dictionary<MHGAJIKGEGE, (PMMFFJMLFOG, int)> CBFMGKIMJGA(IEnumerable<PMMFFJMLFOG> KPNKLACANNG, Entity LHHCDHGLOLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x24EEB90", Offset = "0x24ED390", VA = "0x1824EEB90")]
	private void PAGACMDLJDN(Dictionary<MHGAJIKGEGE, (PMMFFJMLFOG request, int srcIndex)> HEIOLDOFBJE, IEnumerable<PMMFFJMLFOG> KPNKLACANNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x24EC200", Offset = "0x24EAA00", VA = "0x1824EC200")]
	private void AEOAFHBPNEB(Dictionary<MHGAJIKGEGE, (PMMFFJMLFOG request, int srcIndex)> HEIOLDOFBJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x24EE3D0", Offset = "0x24ECBD0", VA = "0x1824EE3D0")]
	private void NHJJHIFEDDO(Dictionary<MHGAJIKGEGE, (PMMFFJMLFOG request, int srcIndex)> HEIOLDOFBJE, MHGAJIKGEGE ECBAIECDCID, string MDOAADHDBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x24EDF70", Offset = "0x24EC770", VA = "0x1824EDF70")]
	private void LOGCNOLDEKH(Dictionary<MHGAJIKGEGE, (PMMFFJMLFOG request, int srcIndex)> HEIOLDOFBJE, Entity LHHCDHGLOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x24ECE10", Offset = "0x24EB610", VA = "0x1824ECE10")]
	private (List<PMMFFJMLFOG>, int[], int) DKLOIOIFJBB(Dictionary<MHGAJIKGEGE, (PMMFFJMLFOG request, int srcIndex)> HEIOLDOFBJE, Entity LHHCDHGLOLJ)
	{
		return default((List<PMMFFJMLFOG>, int[], int));
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x24EDCF0", Offset = "0x24EC4F0", VA = "0x1824EDCF0")]
	private void LBGLADOKJLE(Dictionary<MHGAJIKGEGE, (PMMFFJMLFOG request, int srcIndex)> HEIOLDOFBJE, List<PMMFFJMLFOG> CDDAGNMOCFC, int[] EJKLGJBIOMA, NativeArray<Entity> KFLBCCAJFMN, NativeList<MHGAJIKGEGE> LJNBIMMNBCJ, NativeList<Entity> HOPGCBKGIDN, Entity LHHCDHGLOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x24ED670", Offset = "0x24EBE70", VA = "0x1824ED670")]
	private static bool IDEOOOEEECC(Entity AJDEFAPHMKF, ComponentDataFromEntity<OEKNEICFKDA> JEDHHJPDELA, Entity LHHCDHGLOLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x24ED740", Offset = "0x24EBF40", VA = "0x1824ED740")]
	private void IDFDPCLAKDO(Dictionary<MHGAJIKGEGE, (PMMFFJMLFOG request, int srcIndex)> HEIOLDOFBJE, List<PMMFFJMLFOG> CDDAGNMOCFC, int[] EJKLGJBIOMA, NativeList<Entity> HOPGCBKGIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x24EE980", Offset = "0x24ED180", VA = "0x1824EE980")]
	private NativeList<MHGAJIKGEGE> OPKABLHIDCP(Dictionary<MHGAJIKGEGE, (PMMFFJMLFOG request, int srcIndex)> HEIOLDOFBJE)
	{
		return default(NativeList<MHGAJIKGEGE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x24EEF00", Offset = "0x24ED700", VA = "0x1824EEF00")]
	private NativeArray<Entity> PDPEKFJDLJG(NativeList<MHGAJIKGEGE> LJNBIMMNBCJ)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x24ECCF0", Offset = "0x24EB4F0", VA = "0x1824ECCF0")]
	private static void CCGFLCIOMPK(Dictionary<MHGAJIKGEGE, (PMMFFJMLFOG request, int srcIndex)> HEIOLDOFBJE, MHGAJIKGEGE ECBAIECDCID, PMMFFJMLFOG AJNIDCPPJGC, string MDOAADHDBMA, int BNFGNOPCHLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x24EC3E0", Offset = "0x24EABE0", VA = "0x1824EC3E0")]
	private void AKAOFLAFHBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public IENJDONBBIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
[KHNAILLFHGJ(typeof(CKKBDPJEFPP), new string[] { })]
public class CKKBDPJEFPP : PCAPGPPECJN, NOFCHOCEBPC
{
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	[NAAJCOHOAKA]
	private OABNFEOAMFN HOAPIJEHJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private bool ENEFJKNCGAG;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public TimeData KHEDBLOCGOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x28A7FA0", Offset = "0x28A67A0", VA = "0x1828A7FA0")]
		get
		{
			return default(TimeData);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x28A80B0", Offset = "0x28A68B0", VA = "0x1828A80B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool PAENHBIFBKH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8F14D0", Offset = "0x8EFCD0", VA = "0x1808F14D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x1B19DD0", Offset = "0x1B185D0", VA = "0x181B19DD0", Slot = "4")]
	public void PAHLDMJMCEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x28A7F50", Offset = "0x28A6750", VA = "0x1828A7F50", Slot = "5")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x28A8010", Offset = "0x28A6810", VA = "0x1828A8010")]
	public void MODDGOPBMII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	public void IPNNLIPEDMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public CKKBDPJEFPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[KHNAILLFHGJ(typeof(AEDKFOCGAIL), new string[] { })]
public class APPMOBKBAML : AEDKFOCGAIL, ODKCILIJMBA, PCAPGPPECJN, NOFCHOCEBPC, NOHOJBNCAJC, IDisposable, APPMOBKBAML.GDOGFODNIBL
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	internal interface GDOGFODNIBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JJKHLCKKEEG(global::DGOGKMGLHNE DGMEPFOJPGH);
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private HMBELPNBOEG LNJHNPCFKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private ILBBGIPPPPJ EJLFIBCCMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private BMMKBDIEBCN KKDNOJEGEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private NAAOKPKOHFP OIPELOCIIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private LDDHDDLKFEJ CKMMOGKGLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private bool PMADFOMNIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private global::DGOGKMGLHNE MBDPGLOCJAJ;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	private JPAJHNEFJFD<LPLJHAHPEEF> PCBLKPOAMHF
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7ED760", Offset = "0x7EBF60", VA = "0x1807ED760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	private EntityManager EOOAJAELBGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x28999A0", Offset = "0x28981A0", VA = "0x1828999A0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<POJLFICOPEH> MMGBNMECLCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x2899730", Offset = "0x2897F30", VA = "0x182899730", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x2899BD0", Offset = "0x28983D0", VA = "0x182899BD0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x8F1E80", Offset = "0x8F0680", VA = "0x1808F1E80", Slot = "17")]
	public void PAHLDMJMCEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x2899A50", Offset = "0x2898250", VA = "0x182899A50", Slot = "18")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x28998B0", Offset = "0x28980B0", VA = "0x1828998B0", Slot = "19")]
	public void GGJEPBDNAAH(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0xA744F0", Offset = "0xA72CF0", VA = "0x180A744F0", Slot = "21")]
	private void POCLJKKOBDF(global::DGOGKMGLHNE DGMEPFOJPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x8F1DC0", Offset = "0x8F05C0", VA = "0x1808F1DC0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x2899DF0", Offset = "0x28985F0", VA = "0x182899DF0")]
	private LPLJHAHPEEF OCMMBIABHIK(Entity AJDEFAPHMKF)
	{
		return default(LPLJHAHPEEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x2899C30", Offset = "0x2898430", VA = "0x182899C30", Slot = "6")]
	public LPLJHAHPEEF MAPBPOGNGKF(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(LPLJHAHPEEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x28993A0", Offset = "0x2897BA0", VA = "0x1828993A0", Slot = "7")]
	public void DFJCHFPPGHC(ref List<LPLJHAHPEEF> BDNDLOBMJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x2899B20", Offset = "0x2898320", VA = "0x182899B20", Slot = "11")]
	public int JIDHEKFPBDJ(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x28991C0", Offset = "0x28979C0", VA = "0x1828991C0", Slot = "12")]
	public MDHHOEPMEJH AJPDFKPLCLJ(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(MDHHOEPMEJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x2899CC0", Offset = "0x28984C0", VA = "0x182899CC0", Slot = "15")]
	public LPLJHAHPEEF MFGAAMGNJKL(LPLJHAHPEEF MPGGAHNCHOK, LPLJHAHPEEF PGMGJHKACLK)
	{
		return default(LPLJHAHPEEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x2899790", Offset = "0x2897F90", VA = "0x182899790", Slot = "16")]
	public bool FOCFAPBPKCF(LPLJHAHPEEF MPGGAHNCHOK, LPLJHAHPEEF PGMGJHKACLK, out LPLJHAHPEEF PLFDJFKPNCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x28992E0", Offset = "0x2897AE0", VA = "0x1828992E0", Slot = "8")]
	public LPLJHAHPEEF DFDIEMMHEBB(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(LPLJHAHPEEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x28999F0", Offset = "0x28981F0", VA = "0x1828999F0", Slot = "14")]
	public bool IBBKINNCCLP(LPLJHAHPEEF BBNGIDIFEAM, LPLJHAHPEEF IKDGFEDODNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x2899E30", Offset = "0x2898630", VA = "0x182899E30", Slot = "13")]
	public bool PGFPMKJEAKM(LPLJHAHPEEF BBNGIDIFEAM, LPLJHAHPEEF MPGGAHNCHOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x2899670", Offset = "0x2897E70", VA = "0x182899670", Slot = "9")]
	public bool EALODDMPHDN(LPLJHAHPEEF BBNGIDIFEAM, LPLJHAHPEEF GJPBCFJDGCH, bool ECCMKOMFCJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x28995D0", Offset = "0x2897DD0", VA = "0x1828995D0", Slot = "10")]
	public bool DMMEGNFOAHA(LPLJHAHPEEF BBNGIDIFEAM, LPLJHAHPEEF GJPBCFJDGCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public APPMOBKBAML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class JBNLECMONHM : HIJMGKLGPJD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> KFDGLHMLGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private int CIIACOBABIL;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> IBAAAHEDHNB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x918DC0", Offset = "0x9175C0", VA = "0x180918DC0", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int IBDOOLKCJIF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD10", Offset = "0x7DE510", VA = "0x1807DFD10", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x24F2EE0", Offset = "0x24F16E0", VA = "0x1824F2EE0")]
	public JBNLECMONHM(NativeArray<EntityRemapUtility.EntityRemapInfo> KFDGLHMLGBN, int CIIACOBABIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x24F2E60", Offset = "0x24F1660", VA = "0x1824F2E60", Slot = "6")]
	public LPLJHAHPEEF LIOKLEGJMOA(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(LPLJHAHPEEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x24F2E20", Offset = "0x24F1620", VA = "0x1824F2E20", Slot = "8")]
	public LocalId LIOKLEGJMOA(LocalId AJDEFAPHMKF)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x24F2DC0", Offset = "0x24F15C0", VA = "0x1824F2DC0", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[ANLOEBHPLMF(typeof(KANIKAONFJI))]
[KHNAILLFHGJ(typeof(ABMIKBNFCBA), new string[] { })]
public class AHJOLHGFFIB : ABMIKBNFCBA, IIIIOJEFCCI, KANIKAONFJI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static readonly ProfilerMarker MBMHAIFCBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NDJLNOJIHMB KGMNNCCACLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NHHFEIDPNIC HMNAFOKFDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NAHGLKOIEAI BOBHLPNKBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private OMKEKEENCPE IDFNINJJCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private LDDLEDJLLMH DPAKBDEKGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private bool PMADFOMNIPK;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public NDJLNOJIHMB NGDMEGOLFHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public NAHGLKOIEAI BKEEIANIHAB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x7EC6C0", Offset = "0x7EAEC0", VA = "0x1807EC6C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public NHHFEIDPNIC BNFKDIONJJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public LDDLEDJLLMH KFFJIACNNGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x7F3350", Offset = "0x7F1B50", VA = "0x1807F3350", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool GKHBBLGCCAM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x8E7500", Offset = "0x8E5D00", VA = "0x1808E7500", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool JLFBNHADDGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x2897440", Offset = "0x2895C40", VA = "0x182897440", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public PJIPLFMPMBF EKMAFGNLMNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x7E1570", Offset = "0x7DFD70", VA = "0x1807E1570", Slot = "9")]
		get
		{
			return default(PJIPLFMPMBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x2897460", Offset = "0x2895C60", VA = "0x182897460")]
	public static AHJOLHGFFIB OIAKNFDBOOD(NDJLNOJIHMB KGMNNCCACLI, ABPFOLFBKFD LPNNBGAFKLN = ABPFOLFBKFD.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	private static void MMFFABELHLI(NDJLNOJIHMB KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	private static void BEIKGIGEDKC(NDJLNOJIHMB KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x28975E0", Offset = "0x2895DE0", VA = "0x1828975E0", Slot = "10")]
	public void PMIKACAIKGJ(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x8F1E80", Offset = "0x8F0680", VA = "0x1808F1E80")]
	private void PAHLDMJMCEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x2897310", Offset = "0x2895B10", VA = "0x182897310")]
	private void CMHKKLMEKOF(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	private void GGJEPBDNAAH(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x28973E0", Offset = "0x2895BE0", VA = "0x1828973E0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public AHJOLHGFFIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public static class LADLNPFILAO
{
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[DisallowMultipleComponent]
	public class TransformEntity : MonoBehaviour, INNKBFIJCKK
	{
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly JNGNMMOLKFF MBNJNNGOKFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[SerializeField]
		private KECBEHOHBCN prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private LPLJHAHPEEF BBNGIDIFEAM;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual KECBEHOHBCN DNIPPFHFAEK
		{
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x90BAA0", Offset = "0x90A2A0", VA = "0x18090BAA0", Slot = "6")]
			get
			{
				return default(KECBEHOHBCN);
			}
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x979F40", Offset = "0x978740", VA = "0x180979F40", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public LPLJHAHPEEF OKNLLHGKDMP
		{
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x918DD0", Offset = "0x9175D0", VA = "0x180918DD0", Slot = "5")]
			get
			{
				return default(LPLJHAHPEEF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool CENAPLLCNNC
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x7ECD80", Offset = "0x7EB580", VA = "0x1807ECD80", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x7ECD90", Offset = "0x7EB590", VA = "0x1807ECD90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		internal Entity JDPPHAELNBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x22D3EE0", Offset = "0x22D26E0", VA = "0x1822D3EE0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		internal HMBELPNBOEG AFLOIHDEPAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x7EC6C0", Offset = "0x7EAEC0", VA = "0x1807EC6C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		internal IKCMADHPPKE PNGKBDHOIOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x22D3F20", Offset = "0x22D2720", VA = "0x1822D3F20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x22D3A80", Offset = "0x22D2280", VA = "0x1822D3A80")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x22D3E00", Offset = "0x22D2600", VA = "0x1822D3E00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x22D3A90", Offset = "0x22D2290", VA = "0x1822D3A90")]
		internal void BDCEDMLOOPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x22D39E0", Offset = "0x22D21E0", VA = "0x1822D39E0")]
		private bool ADCJIAFAMDH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x22D3EF0", Offset = "0x22D26F0", VA = "0x1822D3EF0")]
		private void KBJHCIPAPMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x22D3E00", Offset = "0x22D2600", VA = "0x1822D3E00")]
		internal void CEEMIOIEFPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x22D3F90", Offset = "0x22D2790", VA = "0x1822D3F90")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x22D40E0", Offset = "0x22D28E0", VA = "0x1822D40E0")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public abstract class IPKIACFNLPE : OJFKKPOGGCL
{
	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x24F2C90", Offset = "0x24F1490", VA = "0x1824F2C90", Slot = "5")]
	public override Action ECBGJMNDAAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[UnityEngine.Scripting.Preserve]
	public abstract void JKFCFHPHNJM<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x24F2D20", Offset = "0x24F1520", VA = "0x1824F2D20")]
	[UnityEngine.Scripting.Preserve]
	public void MKMNEFMGJPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x24F2DB0", Offset = "0x24F15B0", VA = "0x1824F2DB0")]
	protected IPKIACFNLPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[KHNAILLFHGJ(typeof(ILBBGIPPPPJ), new string[] { })]
public class EDHCJIGIMLO : ILBBGIPPPPJ, IDisposable, NOFCHOCEBPC
{
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	[NAAJCOHOAKA]
	private DCAINADNFLE CGELDKNFLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	[NAAJCOHOAKA]
	private AJCPLKBBBGL KKDJPJAEFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private World GOJEBJMIDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private World LDJNMODKEPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private bool IBGAKOGFJGM;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public World IHPDJPJEIBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x7EC6C0", Offset = "0x7EAEC0", VA = "0x1807EC6C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public World IGCHJBGNJEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x8A5F80", Offset = "0x8A4780", VA = "0x1808A5F80", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public EntityManager EOOAJAELBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x2C72450", Offset = "0x2C70C50", VA = "0x182C72450", Slot = "6")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool GKHBBLGCCAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x2C72470", Offset = "0x2C70C70", VA = "0x182C72470", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x2C72480", Offset = "0x2C70C80", VA = "0x182C72480", Slot = "10")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x2C726C0", Offset = "0x2C70EC0", VA = "0x182C726C0")]
	private void OIAKNFDBOOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x2C72150", Offset = "0x2C70950", VA = "0x182C72150", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x2C726A0", Offset = "0x2C70EA0", VA = "0x182C726A0", Slot = "8")]
	public ComponentSystemBase LNFLHCLCDLG(Type EIOLDDJPDLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public EDHCJIGIMLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[KHNAILLFHGJ(typeof(CGINDCLBFLG), new string[] { })]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
public class CGINDCLBFLG : NOFCHOCEBPC, MKAOANKMGHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private struct MCOEEMNOIFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private NativeArray<int> CKPKKFPAECH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private NativeArray<int> EMCPHJIDOJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private Dictionary<ComponentSystemBase, int> ECMJHHMAGDA;

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x2234F80", Offset = "0x2233780", VA = "0x182234F80")]
		public MCOEEMNOIFP(NativeArray<int> CKPKKFPAECH, NativeArray<int> EMCPHJIDOJF, Dictionary<ComponentSystemBase, int> ECMJHHMAGDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x2234B70", Offset = "0x2233370", VA = "0x182234B70")]
		public static void MPFBALKDJAO(World EJLFIBCCMHH, JLEAEANKKDG MJPAPOOJPCL, NativeArray<int> CKPKKFPAECH, NativeArray<int> EMCPHJIDOJF, Dictionary<ComponentSystemBase, int> ECMJHHMAGDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x2234CA0", Offset = "0x22334A0", VA = "0x182234CA0")]
		public void NGDJDKEBJJD(IEnumerable<ComponentSystemBase> HMNAFOKFDKP, JLEAEANKKDG MJPAPOOJPCL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class MKDJGKKANEC : IEnumerable<ComponentSystemBase>, IEnumerable, IEnumerator<ComponentSystemBase>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private ComponentSystemBase <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private int start;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public int <>3__start;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private int end;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public int <>3__end;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public CGINDCLBFLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private int <i>5__1;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		ComponentSystemBase IEnumerator<ComponentSystemBase>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0xABFAA0", Offset = "0xABE2A0", VA = "0x180ABFAA0")]
		[DebuggerHidden]
		public MKDJGKKANEC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x2235610", Offset = "0x2233E10", VA = "0x182235610", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x22357E0", Offset = "0x2233FE0", VA = "0x1822357E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x2235730", Offset = "0x2233F30", VA = "0x182235730", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<ComponentSystemBase> IEnumerable<ComponentSystemBase>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x2235730", Offset = "0x2233F30", VA = "0x182235730", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly JNGNMMOLKFF BFMOIPEMMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	[NAAJCOHOAKA]
	private ILBBGIPPPPJ KFELNFLBJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private World EJLFIBCCMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private NCFCHDEHMHC KGMNNCCACLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private NativeArray<int> FMJFGPGNEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private NativeArray<int> AGCOFEOGAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private int MNJCDKNLLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private JLEAEANKKDG AMBKFFFHLCM;

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x28A5100", Offset = "0x28A3900", VA = "0x1828A5100", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x28A4B50", Offset = "0x28A3350", VA = "0x1828A4B50", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x28A51E0", Offset = "0x28A39E0", VA = "0x1828A51E0")]
	[IteratorStateMachine(typeof(MKDJGKKANEC))]
	private IEnumerable<ComponentSystemBase> MNPBDGFIOBB(int HKIGKJAPFHM, int IODGGLFACBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x28A4D70", Offset = "0x28A3570", VA = "0x1828A4D70", Slot = "5")]
	public void IGCNDNBCPAD(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x28A4D70", Offset = "0x28A3570", VA = "0x1828A4D70")]
	private void HJEEBHDKIJO(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x28A4C60", Offset = "0x28A3460", VA = "0x1828A4C60")]
	public void HJEEBHDKIJO(JLEAEANKKDG PJABDJJOHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x28A4E60", Offset = "0x28A3660", VA = "0x1828A4E60")]
	private void IEPLGFLCEKE(JLEAEANKKDG PJABDJJOHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x28A43B0", Offset = "0x28A2BB0", VA = "0x1828A43B0")]
	private void AADGIFNLDMP(JLEAEANKKDG PJABDJJOHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x28A4DF0", Offset = "0x28A35F0", VA = "0x1828A4DF0")]
	private void IBJONPCGBCA(JLEAEANKKDG PJABDJJOHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x28A53E0", Offset = "0x28A3BE0", VA = "0x1828A53E0")]
	private void OMHHGLOGICD(int HKIGKJAPFHM, int IODGGLFACBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x28A5320", Offset = "0x28A3B20", VA = "0x1828A5320")]
	private void NEFHCOODIBP(int HKIGKJAPFHM, int IODGGLFACBF, bool HLEJICMEJHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x28A4C40", Offset = "0x28A3440", VA = "0x1828A4C40")]
	private int HGEOJNIIKPF(JLEAEANKKDG PJABDJJOHNB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x28A4450", Offset = "0x28A2C50", VA = "0x1828A4450")]
	private bool AKGIDDJCLKL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x28A4A00", Offset = "0x28A3200", VA = "0x1828A4A00")]
	private Dictionary<ComponentSystemBase, int> COBKDNGLAOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x28A4960", Offset = "0x28A3160", VA = "0x1828A4960")]
	private void ALKMDNCAGOF(NativeArray<int> CKPKKFPAECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x28A5270", Offset = "0x28A3A70", VA = "0x1828A5270")]
	private void NDNEKKMCDGL(NativeArray<int> EMCPHJIDOJF, NativeArray<int> CKPKKFPAECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x28A4BE0", Offset = "0x28A33E0", VA = "0x1828A4BE0")]
	private static JLEAEANKKDG EILAJJDNIIF(Type EIOLDDJPDLH, JLEAEANKKDG GFJIAKNDNMH)
	{
		return default(JLEAEANKKDG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x28A5570", Offset = "0x28A3D70", VA = "0x1828A5570")]
	public CGINDCLBFLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x28A4AF0", Offset = "0x28A32F0", VA = "0x1828A4AF0")]
	[CompilerGenerated]
	private void DFJOMPIMHIO(NOFCHOCEBPC GLIEOKNLMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x28A49A0", Offset = "0x28A31A0", VA = "0x1828A49A0")]
	[CompilerGenerated]
	private void APHDEFKJLPO(NOHOJBNCAJC GLIEOKNLMIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal class ONEPBBCFCEJ : GJJADNOGMIL
{
	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x22BD2D0", Offset = "0x22BBAD0", VA = "0x1822BD2D0", Slot = "15")]
	protected override ComponentSystemBase CMFPJFIFJLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x22BD510", Offset = "0x22BBD10", VA = "0x1822BD510")]
	[UnityEngine.Scripting.Preserve]
	private void DAMBHDCJJMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x22BD2C0", Offset = "0x22BBAC0", VA = "0x1822BD2C0")]
	public ONEPBBCFCEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[KHNAILLFHGJ(typeof(LDDLEDJLLMH), new string[] { })]
public class EBGAPIHDFNO : LDDLEDJLLMH, NOFCHOCEBPC
{
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly JNGNMMOLKFF EILJILOGCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private NDJLNOJIHMB KGMNNCCACLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private OMKEKEENCPE IDFNINJJCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private NAHGLKOIEAI BOBHLPNKBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private ABMIKBNFCBA ODAMNCBMCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private ILGLLPNDOPK NDJHELJNLPN;

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool FMNPNMOJKKH
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x2C71680", Offset = "0x2C6FE80", VA = "0x182C71680", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action AABCIHAEHFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x2C71410", Offset = "0x2C6FC10", VA = "0x182C71410", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x2C71370", Offset = "0x2C6FB70", VA = "0x182C71370", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x2C71560", Offset = "0x2C6FD60", VA = "0x182C71560", Slot = "15")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x2C71630", Offset = "0x2C6FE30", VA = "0x182C71630", Slot = "11")]
	public Task KMOEBOKJHAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x2C71770", Offset = "0x2C6FF70", VA = "0x182C71770", Slot = "12")]
	public Task OILLINLDEFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x2C714B0", Offset = "0x2C6FCB0", VA = "0x182C714B0", Slot = "13")]
	public Task HPJEFGLFLEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x2C710F0", Offset = "0x2C6F8F0", VA = "0x182C710F0", Slot = "8")]
	public void EKABLNLPGLL(bool HLEJICMEJHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x2C71090", Offset = "0x2C6F890", VA = "0x182C71090", Slot = "9")]
	public bool DLMAIHLOBIE(ByteString BLAINNBNMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x2C71500", Offset = "0x2C6FD00", VA = "0x182C71500", Slot = "6")]
	public void IJDDMDKBAJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x8A4520", Offset = "0x8A2D20", VA = "0x1808A4520", Slot = "7")]
	public void HFDEGCECNCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x2C716D0", Offset = "0x2C6FED0", VA = "0x182C716D0", Slot = "14")]
	public void OAAAMLDFDLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public EBGAPIHDFNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[Flags]
public enum ABPFOLFBKFD
{
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	ExcludeIgnore = 1,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	ExcludePhoton = 2,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	ExcludeAssemblyCSharp = 4,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	IncludeMock = 8,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	IncludeEditor = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	Default = 1
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[KHNAILLFHGJ(typeof(HOFHJIADIBP), new string[] { })]
[HHKHACIGOAG(JLEAEANKKDG.LoadInstance)]
public class HOFHJIADIBP : NOFCHOCEBPC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[NAAJCOHOAKA]
	private NMKNMBOOICD GDBIIJIAFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[NAAJCOHOAKA]
	private CGINDCLBFLG MFBNNPLAJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[NAAJCOHOAKA]
	private GJCOMGMOGCM LJAHGKLIMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[NAAJCOHOAKA]
	private LDDHDDLKFEJ CKMMOGKGLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[NAAJCOHOAKA]
	private ILBBGIPPPPJ KFELNFLBJDM;

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x24E8100", Offset = "0x24E6900", VA = "0x1824E8100", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x24E80B0", Offset = "0x24E68B0", VA = "0x1824E80B0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x24E8020", Offset = "0x24E6820", VA = "0x1824E8020")]
	private void CAGGMIGHACF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x24E80B0", Offset = "0x24E68B0", VA = "0x1824E80B0")]
	private void NBENIBBGMMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x24E7FD0", Offset = "0x24E67D0", VA = "0x1824E7FD0")]
	private void BKNEPAHIMBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public HOFHJIADIBP()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class EntityReference : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x90A150", Offset = "0x908950", VA = "0x18090A150")]
		public EntityReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[KHNAILLFHGJ(typeof(KBLIELEJFEK), new string[] { })]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
internal class KBLIELEJFEK : NOFCHOCEBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private ILBBGIPPPPJ EJLFIBCCMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private NHLFCCPGHPO DFBCJBEDHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private FCNMLNBCAFD MALGKCPCNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private OABILJFHBBI LDDLGHMNIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	[NAAJCOHOAKA]
	private LGNMGLONHCC ELMENJAOGJB;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public AINFFBPBMAB NMMPJDILCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x7ED740", Offset = "0x7EBF40", VA = "0x1807ED740")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x7ED730", Offset = "0x7EBF30", VA = "0x1807ED730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x24F7100", Offset = "0x24F5900", VA = "0x1824F7100", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x24F7060", Offset = "0x24F5860", VA = "0x1824F7060")]
	private void DMLDCFHAENE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x24F7250", Offset = "0x24F5A50", VA = "0x1824F7250")]
	public BLECIIOHDPI JJCJAIMEMBF(FKFIIEPBNGA MDOAADHDBMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x99D8E0", Offset = "0x99C0E0", VA = "0x18099D8E0")]
	public HDJBIAICEGL<T> INAKJMPFKCC<T>(FKFIIEPBNGA MDOAADHDBMA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public KBLIELEJFEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal static class LNCEDBLIKBD
{
	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x1DB0530", Offset = "0x1DAED30", VA = "0x181DB0530")]
	public static NIJBLPDKGGM<T> JJCJAIMEMBF<T>(this KBLIELEJFEK DOMNKHJELLM, KNCFGIDDJIE<T> MDOAADHDBMA) where T : struct
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
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public const string RUNTIME_CONFIG_FOLDER = "ObjectModelConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private EmbodiedObject objectPrefab;

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public EmbodiedObject ObjectPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x22BEC50", Offset = "0x22BD450", VA = "0x1822BEC50")]
		public static ObjectModelConfigAsset BDOLPCDKNHM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x9176C0", Offset = "0x915EC0", VA = "0x1809176C0")]
		public ObjectModelConfigAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public abstract class OJFKKPOGGCL : JBCJLNDIPPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly MethodInfo PLNKPINBLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly Type[] HPDOEALAHJH;

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x293D580", Offset = "0x293BD80", VA = "0x18293D580")]
	public OJFKKPOGGCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action ECBGJMNDAAG();

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x293D540", Offset = "0x293BD40", VA = "0x18293D540")]
	public MethodInfo LEFMBGCCLFL(Action COPPLLLOGLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x293D390", Offset = "0x293BB90", VA = "0x18293D390", Slot = "4")]
	public void JACMNDDEBJP(Type EIOLDDJPDLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[KHNAILLFHGJ(typeof(ILGLLPNDOPK), new string[] { })]
[ANLOEBHPLMF(typeof(COBBILJPCCC))]
internal class COBBILJPCCC : ILGLLPNDOPK, IDisposable, NOFCHOCEBPC, MKAOANKMGHC
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class DMICPOCGOOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public COBBILJPCCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public DMICPOCGOOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x222B8C0", Offset = "0x222A0C0", VA = "0x18222B8C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private static readonly JNGNMMOLKFF EILJILOGCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	[NAAJCOHOAKA]
	private NAHGLKOIEAI BOBHLPNKBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	[NAAJCOHOAKA]
	private LDDLEDJLLMH DPAKBDEKGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	[NAAJCOHOAKA]
	private GMHFFPADGAG DPBIPCAHMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	[NAAJCOHOAKA]
	private OMKEKEENCPE IDFNINJJCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private ABMIKBNFCBA ODAMNCBMCAF;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool CLCDMMEHDBK
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x8E7500", Offset = "0x8E5D00", VA = "0x1808E7500", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x8E7470", Offset = "0x8E5C70", VA = "0x1808E7470", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool MFOOGNNDIAN
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0xA11DD0", Offset = "0xA105D0", VA = "0x180A11DD0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool EPHICNGJANM
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xA76FC0", Offset = "0xA757C0", VA = "0x180A76FC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xA76EE0", Offset = "0xA756E0", VA = "0x180A76EE0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public KFBLILCDCFC AAMNPMAJFHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x8A69F0", Offset = "0x8A51F0", VA = "0x1808A69F0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0xA744F0", Offset = "0xA72CF0", VA = "0x180A744F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x28AA3F0", Offset = "0x28A8BF0", VA = "0x1828AA3F0", Slot = "16")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x28A9D80", Offset = "0x28A8580", VA = "0x1828A9D80", Slot = "15")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x28A9940", Offset = "0x28A8140", VA = "0x1828A9940", Slot = "8")]
	public CANOBKDKPKE BHBEILODPMK(bool KIMBDGBPCDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x28A9B00", Offset = "0x28A8300", VA = "0x1828A9B00")]
	public CANOBKDKPKE OEIFJLJHGAF(IEnumerable<LPLJHAHPEEF> ADGNPKODABN, in JBNGNAKFECF ACCIBJJKHBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x28AA6A0", Offset = "0x28A8EA0", VA = "0x1828AA6A0", Slot = "10")]
	public LKLBFCMBGLM PJAKHLOHDBO(ByteString BLAINNBNMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x28AA1A0", Offset = "0x28A89A0", VA = "0x1828AA1A0")]
	public JHDIDEHGHHN HNCAPJKGLCH(ByteString BLAINNBNMDK, LPLJHAHPEEF GJPBCFJDGCH, in JBNGNAKFECF KPBEHAGEDNH, IMKNGLHILIB PCBJOBHPHLP, bool GKKIHDGELJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x28A9DE0", Offset = "0x28A85E0", VA = "0x1828A9DE0", Slot = "12")]
	public void EBPLINDPDIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x28A95E0", Offset = "0x28A7DE0", VA = "0x1828A95E0", Slot = "14")]
	public LIIAPEIGDIL AMOMLNLOMHC(IEnumerable<PMMFFJMLFOG> DBOJPELNHKC)
	{
		return default(LIIAPEIGDIL);
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x28A9C80", Offset = "0x28A8480", VA = "0x1828A9C80")]
	public static bool DLMAIHLOBIE(ByteString BLAINNBNMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x28AA000", Offset = "0x28A8800", VA = "0x1828AA000", Slot = "13")]
	public void HMHDKPNECEP(bool FBODNDKNFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x28A9FA0", Offset = "0x28A87A0", VA = "0x1828A9FA0")]
	private void EKABLNLPGLL(bool HLEJICMEJHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x28A9D80", Offset = "0x28A8580", VA = "0x1828A9D80")]
	private void DMCKLJIJHMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x1382540", Offset = "0x1380D40", VA = "0x181382540")]
	private void OMLCNJBBGIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x28AA4C0", Offset = "0x28A8CC0", VA = "0x1828AA4C0")]
	private void KEKNMHFEBNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x28AA340", Offset = "0x28A8B40", VA = "0x1828AA340", Slot = "17")]
	public void IGCNDNBCPAD(NCFCHDEHMHC JOCEPOLJMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public COBBILJPCCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x28A9B00", Offset = "0x28A8300", VA = "0x1828A9B00", Slot = "9")]
	private CANOBKDKPKE CAFPJFGHBMG(IEnumerable<LPLJHAHPEEF> ADGNPKODABN, in JBNGNAKFECF ACCIBJJKHBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x28A97A0", Offset = "0x28A7FA0", VA = "0x1828A97A0", Slot = "11")]
	private JHDIDEHGHHN AOJEICBNNCA(ByteString BLAINNBNMDK, LPLJHAHPEEF GJPBCFJDGCH, in JBNGNAKFECF KPBEHAGEDNH, IMKNGLHILIB PCBJOBHPHLP, bool GKKIHDGELJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x28AA580", Offset = "0x28A8D80", VA = "0x1828AA580")]
	[DebuggerStepThrough]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(DMICPOCGOOC))]
	private Task KLEKHJFBDHL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct EBFHNNCEJDJ : IEnumerable<IEGBFAEGKJN>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public enum NAEDJCPBMKB
	{
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public struct JGJANOJJPMO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private NativeList<byte> NFBDMLCENEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private EBFHNNCEJDJ DFMKDLJIHMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private readonly IEGBFAEGKJN ODHKMJMLAIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private readonly int HKIGKJAPFHM;

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x2231460", Offset = "0x222FC60", VA = "0x182231460")]
		internal JGJANOJJPMO(EBFHNNCEJDJ DFMKDLJIHMN, IEGBFAEGKJN ODHKMJMLAIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x2231380", Offset = "0x222FB80", VA = "0x182231380", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x22313B0", Offset = "0x222FBB0", VA = "0x1822313B0")]
		public void FFMIJBLINBC(ReadOnlySpan<byte> MENBIMCLIOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x2231280", Offset = "0x222FA80", VA = "0x182231280")]
		private void BFBELPBJEIA(ReadOnlySpan<byte> MENBIMCLIOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x2231320", Offset = "0x222FB20", VA = "0x182231320")]
		private unsafe void BFBELPBJEIA(void* IMFNFADDFOA, int AKLMFDJHPFM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public struct BGPBJCFGIAK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private EBFHNNCEJDJ DFMKDLJIHMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private NativeArray<byte> NFBDMLCENEN;

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x2228950", Offset = "0x2227150", VA = "0x182228950")]
		internal BGPBJCFGIAK(EBFHNNCEJDJ DFMKDLJIHMN, NativeArray<byte> NFBDMLCENEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x2228740", Offset = "0x2226F40", VA = "0x182228740", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x2228750", Offset = "0x2226F50", VA = "0x182228750")]
		public NativeArray<byte> JBMIAFCFEHC(int AKLMFDJHPFM)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x2228810", Offset = "0x2227010", VA = "0x182228810")]
		public void MBKMKJJKOJA(Span<byte> MENBIMCLIOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public struct DGPKPGMBJGE : IEnumerator<IEGBFAEGKJN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly NativeList<IEGBFAEGKJN> DLLMPOAIBGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private int AMOEKOMGDLG;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public IEGBFAEGKJN PDEEINOIIEF
		{
			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x222B5D0", Offset = "0x2229DD0", VA = "0x18222B5D0", Slot = "4")]
			get
			{
				return default(IEGBFAEGKJN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x222B590", Offset = "0x2229D90", VA = "0x18222B590", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x222B440", Offset = "0x2229C40", VA = "0x18222B440", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x222B550", Offset = "0x2229D50", VA = "0x18222B550", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private struct CLDNPKHLOMC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private NativeArray<int> NFBDMLCENEN;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public bool KHGFECIPALO
		{
			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x2229DD0", Offset = "0x22285D0", VA = "0x182229DD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public int JAANEFINBFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x2229DC0", Offset = "0x22285C0", VA = "0x182229DC0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x2229E10", Offset = "0x2228610", VA = "0x182229E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public NAEDJCPBMKB ADAAEFIOCOE
		{
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x2229DB0", Offset = "0x22285B0", VA = "0x182229DB0")]
			get
			{
				return default(NAEDJCPBMKB);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x2229D20", Offset = "0x2228520", VA = "0x182229D20")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool FFBECOIGHDI
		{
			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x2229D30", Offset = "0x2228530", VA = "0x182229D30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool JJDPHMIELOE
		{
			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x2229D50", Offset = "0x2228550", VA = "0x182229D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x2229E90", Offset = "0x2228690", VA = "0x182229E90")]
		public CLDNPKHLOMC(NAEDJCPBMKB GNNGFOJHOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x2229E20", Offset = "0x2228620", VA = "0x182229E20")]
		private int LPKBLHIFLLL(int CNJDAMBDKMB, int JNJGEMHMBJL = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x2229E50", Offset = "0x2228650", VA = "0x182229E50")]
		private void OLFLGMGEIBD(int CNJDAMBDKMB, int MENBIMCLIOI, int JNJGEMHMBJL = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x2229D70", Offset = "0x2228570", VA = "0x182229D70", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static readonly IEGBFAEGKJN OGMHDHDAOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private NativeParallelHashMap<IEGBFAEGKJN, int> DNBMDFJBOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private NativeList<IEGBFAEGKJN> DPBIPCAHMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private NativeList<int> AGCOFEOGAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private NativeList<byte> BIJMGDDELIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private NativeList<byte> NFBDMLCENEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private CLDNPKHLOMC LGKGBPHHHBD;

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x2C70DB0", Offset = "0x2C6F5B0", VA = "0x182C70DB0")]
	public static EBFHNNCEJDJ OIAKNFDBOOD(NAEDJCPBMKB GNNGFOJHOIN = NAEDJCPBMKB.Last, int HDODPDIODHE = 16, int ILKIMCPHMPO = 256)
	{
		return default(EBFHNNCEJDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x2C70EF0", Offset = "0x2C6F6F0", VA = "0x182C70EF0")]
	private EBFHNNCEJDJ(NAEDJCPBMKB GNNGFOJHOIN, int HDODPDIODHE, int ILKIMCPHMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x2C70510", Offset = "0x2C6ED10", VA = "0x182C70510", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x2C70420", Offset = "0x2C6EC20", VA = "0x182C70420")]
	public JGJANOJJPMO DMKHKMHFNEO(IEGBFAEGKJN ODHKMJMLAIP)
	{
		return default(JGJANOJJPMO);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x2C709D0", Offset = "0x2C6F1D0", VA = "0x182C709D0")]
	public bool MLNKLAIOCFK(IEGBFAEGKJN ODHKMJMLAIP, out BGPBJCFGIAK PHFMBPBGGLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x2C70890", Offset = "0x2C6F090", VA = "0x182C70890")]
	public bool LDIJGOLOOOK(IEGBFAEGKJN ODHKMJMLAIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x2C707C0", Offset = "0x2C6EFC0", VA = "0x182C707C0")]
	public bool KNNECGOPGPB(IEGBFAEGKJN ODHKMJMLAIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x2C705F0", Offset = "0x2C6EDF0", VA = "0x182C705F0")]
	public void EEMEPIGIECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x2C70BC0", Offset = "0x2C6F3C0", VA = "0x182C70BC0")]
	private void NNPCIDHIABJ(IEGBFAEGKJN ODHKMJMLAIP, int HKIGKJAPFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x2C708E0", Offset = "0x2C6F0E0", VA = "0x182C708E0")]
	private void LNEGPDFPNBJ(int OLNMDPKJIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x2C706D0", Offset = "0x2C6EED0", VA = "0x182C706D0")]
	private void KICNFENDAFF(IEGBFAEGKJN ODHKMJMLAIP, int HKIGKJAPFHM, int AKLMFDJHPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x2C70E30", Offset = "0x2C6F630", VA = "0x182C70E30", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x2C70DF0", Offset = "0x2C6F5F0", VA = "0x182C70DF0", Slot = "4")]
	private IEnumerator<IEGBFAEGKJN> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
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
		public override KECBEHOHBCN DNIPPFHFAEK
		{
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x22D0FF0", Offset = "0x22CF7F0", VA = "0x1822D0FF0", Slot = "6")]
			get
			{
				return default(KECBEHOHBCN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x22D0F90", Offset = "0x22CF790", VA = "0x1822D0F90")]
		public RbexEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public static class DNBKCBCMFAH
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public static class MAHMCFFOGKL
	{
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private static readonly JNGNMMOLKFF MBNJNNGOKFP;

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x2234180", Offset = "0x2232980", VA = "0x182234180")]
		public static MHGAJIKGEGE CGFMPAJEBHA(int LGBIAELDLAM, KFBLILCDCFC IKBOIGIEDJD)
		{
			return default(MHGAJIKGEGE);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x2234610", Offset = "0x2232E10", VA = "0x182234610")]
		private static LPLJHAHPEEF EGAGABDNKJP(KFBLILCDCFC AIIACLJIKMG, LPLJHAHPEEF BHANEDMGAIA)
		{
			return default(LPLJHAHPEEF);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x2234720", Offset = "0x2232F20", VA = "0x182234720")]
		private static void INIPBNMNPKM(LPLJHAHPEEF IOLPCJMPAGI, LPLJHAHPEEF JFMLIMDPMDK, MHGAJIKGEGE ECBAIECDCID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x22348B0", Offset = "0x22330B0", VA = "0x1822348B0")]
		public static int KILPJPPEOHK(GameObject OAOEKKJFJKH, CANOBKDKPKE HAMEMDDDJAK)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private static NDJLNOJIHMB LOPKMEOLICC;

	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private static ABMIKBNFCBA ODAMNCBMCAF;

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public static ABMIKBNFCBA PCDHCHMHHJI
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x2C6C2B0", Offset = "0x2C6AAB0", VA = "0x182C6C2B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public static bool NLNOMGMCCJH
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x2C6BDD0", Offset = "0x2C6A5D0", VA = "0x182C6BDD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public static NCFCHDEHMHC NGDMEGOLFHB
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x2C6C8F0", Offset = "0x2C6B0F0", VA = "0x182C6C8F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public static NHHFEIDPNIC BNFKDIONJJI
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x2C6C6F0", Offset = "0x2C6AEF0", VA = "0x182C6C6F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public static JGHGFLIKNJI FCPJBKLDKIE
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x2C6BF70", Offset = "0x2C6A770", VA = "0x182C6BF70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public static HMBELPNBOEG AFLOIHDEPAG
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x2C6BB10", Offset = "0x2C6A310", VA = "0x182C6BB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public static AEDKFOCGAIL EAFOKJKFLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x2C6CC90", Offset = "0x2C6B490", VA = "0x182C6CC90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public static FNKAOJGCPPO AILIOFHMAPP
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x2C6C770", Offset = "0x2C6AF70", VA = "0x182C6C770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public static bool BLNAFLEBMHC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x2C6CAD0", Offset = "0x2C6B2D0", VA = "0x182C6CAD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public static bool JPDJKKHAJOM
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x2C6C160", Offset = "0x2C6A960", VA = "0x182C6C160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public static IFDBCDKGAKP GMHKNDAAOMC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x2C6CB50", Offset = "0x2C6B350", VA = "0x182C6CB50")]
		get
		{
			return default(IFDBCDKGAKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public static bool DFKGHELIELM
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x2C6C850", Offset = "0x2C6B050", VA = "0x182C6C850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public static byte DINCDFILEEE
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x2C6BCB0", Offset = "0x2C6A4B0", VA = "0x182C6BCB0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public static bool JKGDHFFABDD
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x2C6C7F0", Offset = "0x2C6AFF0", VA = "0x182C6C7F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public static bool PLICPLHMAKC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x2C6BFF0", Offset = "0x2C6A7F0", VA = "0x182C6BFF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x2C6C970", Offset = "0x2C6B170", VA = "0x182C6C970")]
	public static void OHJJACENGAI(NDJLNOJIHMB MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x2C6C1B0", Offset = "0x2C6A9B0", VA = "0x182C6C1B0")]
	public static LPLJHAHPEEF JIFMDGFNNCE(GameObject OAOEKKJFJKH)
	{
		return default(LPLJHAHPEEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x2C6C410", Offset = "0x2C6AC10", VA = "0x182C6C410")]
	public static IFDBCDKGAKP KMHFICCGFIM(MHGAJIKGEGE ECBAIECDCID)
	{
		return default(IFDBCDKGAKP);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x2C6C5D0", Offset = "0x2C6ADD0", VA = "0x182C6C5D0")]
	public static bool LBGGLFBHLIJ(GameObject OAOEKKJFJKH, out MHGAJIKGEGE ECBAIECDCID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x2C6B9D0", Offset = "0x2C6A1D0", VA = "0x182C6B9D0")]
	public static LIIAPEIGDIL AMOMLNLOMHC(IEnumerable<PMMFFJMLFOG> DBOJPELNHKC)
	{
		return default(LIIAPEIGDIL);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x2C6C050", Offset = "0x2C6A850", VA = "0x182C6C050")]
	public static void HNIAKJOBOKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x2C6BB90", Offset = "0x2C6A390", VA = "0x182C6BB90")]
	private static ABMIKBNFCBA EBFAJBGKCLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x2C6B870", Offset = "0x2C6A070", VA = "0x182C6B870")]
	private static bool ALCNEGPFLBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class JJAPPIKPOBL
{
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct IEGBFAEGKJN : IComparable<IEGBFAEGKJN>, IEquatable<IEGBFAEGKJN>
{
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public static readonly IEGBFAEGKJN HCMFGAEBPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public MHGAJIKGEGE PMFGMJJBADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public LLNAAGHGEOA BAAPPBDHEJN;

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public bool JHEOEEGHFGE
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x24EC0A0", Offset = "0x24EA8A0", VA = "0x1824EC0A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0xAB38B0", Offset = "0xAB20B0", VA = "0x180AB38B0")]
	public IEGBFAEGKJN(MHGAJIKGEGE PMFGMJJBADH, LLNAAGHGEOA BAAPPBDHEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x24EBF30", Offset = "0x24EA730", VA = "0x1824EBF30", Slot = "4")]
	public int CompareTo(IEGBFAEGKJN OALEAAIPGBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x24EC0B0", Offset = "0x24EA8B0", VA = "0x1824EC0B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x24EBFC0", Offset = "0x24EA7C0", VA = "0x1824EBFC0", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x24EBF70", Offset = "0x24EA770", VA = "0x1824EBF70", Slot = "5")]
	public bool Equals(IEGBFAEGKJN OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x24EC060", Offset = "0x24EA860", VA = "0x1824EC060", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[KHNAILLFHGJ(typeof(DJMJGPMDFDA), new string[] { })]
[HHKHACIGOAG(JLEAEANKKDG.LoadInstance)]
internal class DJMJGPMDFDA : NOFCHOCEBPC, NOHOJBNCAJC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private IKCMADHPPKE MFHEANKMMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private NIJBLPDKGGM<Entity> GJPBCFJDGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private LDDHDDLKFEJ HBLGPEBMOAO;

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x2C6A540", Offset = "0x2C68D40", VA = "0x182C6A540", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x2C6A2E0", Offset = "0x2C68AE0", VA = "0x182C6A2E0", Slot = "5")]
	public void GGJEPBDNAAH(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x2C6A240", Offset = "0x2C68A40", VA = "0x182C6A240", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x2C6A410", Offset = "0x2C68C10", VA = "0x182C6A410")]
	private void HNBLGBIKCKP(Entity AJDEFAPHMKF, in DMEBMKFMGNA MDBHGCNGNDL, in DMEBMKFMGNA PCKLDBCFAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public DJMJGPMDFDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[KHNAILLFHGJ(typeof(JIHNNDGLHPF), new string[] { })]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
internal class JIHNNDGLHPF : NOFCHOCEBPC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	[NAAJCOHOAKA]
	private NHLFCCPGHPO LAEPKFGACAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly Dictionary<int, IGBOJICGIKC> OIMCBKIDFHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private bool PMADFOMNIPK;

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x24F55E0", Offset = "0x24F3DE0", VA = "0x1824F55E0", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x24F51C0", Offset = "0x24F39C0", VA = "0x1824F51C0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x24F5860", Offset = "0x24F4060", VA = "0x1824F5860")]
	public IGBOJICGIKC NLACHNHJMJN(FKFIIEPBNGA ELAAPFMOMBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x24F5630", Offset = "0x24F3E30", VA = "0x1824F5630")]
	public IGBOJICGIKC NLACHNHJMJN(LLNAAGHGEOA BAAPPBDHEJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x24F5440", Offset = "0x24F3C40", VA = "0x1824F5440")]
	public void EEMEPIGIECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x24F5960", Offset = "0x24F4160", VA = "0x1824F5960")]
	public JIHNNDGLHPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
[KHNAILLFHGJ(typeof(FKNGMJFACJG), new string[] { })]
public class FKNGMJFACJG
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public struct OHMGCCKKMKD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private readonly FKNGMJFACJG GJPBCFJDGCH;

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x22369F0", Offset = "0x22351F0", VA = "0x1822369F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private int FBPBCIDNNMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action OIBCNGDAKOD;

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A570", Offset = "0x2C78D70", VA = "0x182C7A570")]
	public void DACOEJJMABL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public FKNGMJFACJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[DefaultMember("Item")]
public class PEAAFNBNFAJ<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly Func<From, To> BALILHNHLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly Func<To, From> HLEBFPAALJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public NativeArray<From> DLLMPOAIBGN;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public To ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x21A6430", Offset = "0x21A4C30", VA = "0x1821A6430", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x21A6480", Offset = "0x21A4C80", VA = "0x1821A6480", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public int GKGAEPJBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x21A63F0", Offset = "0x21A4BF0", VA = "0x1821A63F0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool OAJKOPLILBN
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x7EE860", Offset = "0x7ED060", VA = "0x1807EE860", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x1EFAB10", Offset = "0x1EF9310", VA = "0x181EFAB10")]
	public PEAAFNBNFAJ(Func<From, To> BALILHNHLPP, Func<To, From> HLEBFPAALJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x21A6000", Offset = "0x21A4800", VA = "0x1821A6000", Slot = "11")]
	public void Add(To AMBKJGJJFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x21A6040", Offset = "0x21A4840", VA = "0x1821A6040", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x21A6080", Offset = "0x21A4880", VA = "0x1821A6080", Slot = "13")]
	public bool Contains(To AMBKJGJJFNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x21A6140", Offset = "0x21A4940", VA = "0x1821A6140", Slot = "14")]
	public void CopyTo(To[] DLLMPOAIBGN, int NIPJDFBICLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x21A6200", Offset = "0x21A4A00", VA = "0x1821A6200", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x21A62C0", Offset = "0x21A4AC0", VA = "0x1821A62C0", Slot = "6")]
	public int IndexOf(To AMBKJGJJFNP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x21A6330", Offset = "0x21A4B30", VA = "0x1821A6330", Slot = "7")]
	public void Insert(int AMOEKOMGDLG, To AMBKJGJJFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x21A63B0", Offset = "0x21A4BB0", VA = "0x1821A63B0", Slot = "15")]
	public bool Remove(To AMBKJGJJFNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x21A6370", Offset = "0x21A4B70", VA = "0x1821A6370", Slot = "8")]
	public void RemoveAt(int AMOEKOMGDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x1AAB720", Offset = "0x1AA9F20", VA = "0x181AAB720", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[PJEHGGACMLC]
public class FLNGPBLJIHE : ComponentSystem, NOFCHOCEBPC
{
	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	private NCFCHDEHMHC NGDMEGOLFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x7ED730", Offset = "0x7EBF30", VA = "0x1807ED730")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private NHHFEIDPNIC BNFKDIONJJI
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0xA744F0", Offset = "0xA72CF0", VA = "0x180A744F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B480", Offset = "0x2C79C80", VA = "0x182C7B480", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x7E01F0", Offset = "0x7DE9F0", VA = "0x1807E01F0")]
	public FLNGPBLJIHE()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[DisallowMultipleComponent]
	public sealed class EmbodiedObject : MonoBehaviour, FKKNGLCNOFO, INNKBFIJCKK
	{
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private static readonly JNGNMMOLKFF MBNJNNGOKFP;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private const string ABMLIGFIGKE = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private FOFNGPEFGJJ COOBJCJFHEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private LPLJHAHPEEF PMFGMJJBADH;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public LPLJHAHPEEF OKNLLHGKDMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0x2C75FA0", Offset = "0x2C747A0", VA = "0x182C75FA0", Slot = "15")]
			get
			{
				return default(LPLJHAHPEEF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public IFDBCDKGAKP JCLOAFMPDNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0x2C76050", Offset = "0x2C74850", VA = "0x182C76050", Slot = "6")]
			get
			{
				return default(IFDBCDKGAKP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public bool CENAPLLCNNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0x2C75F90", Offset = "0x2C74790", VA = "0x182C75F90", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public FOFNGPEFGJJ MLCPFJLJEPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0xBCC360", Offset = "0xBCAB60", VA = "0x180BCC360", Slot = "7")]
			get
			{
				return default(FOFNGPEFGJJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		private NHHFEIDPNIC BNFKDIONJJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x2C75580", Offset = "0x2C73D80", VA = "0x182C75580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool JONDFIGHAHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x951EF0", Offset = "0x9506F0", VA = "0x180951EF0", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0x951E10", Offset = "0x950610", VA = "0x180951E10", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<bool> EHNBOPEEBOA
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x2C75E50", Offset = "0x2C74650", VA = "0x182C75E50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x2C76080", Offset = "0x2C74880", VA = "0x182C76080")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		public event Action<FKKNGLCNOFO> IHOIIAANPFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x2C75EF0", Offset = "0x2C746F0", VA = "0x182C75EF0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x2C76120", Offset = "0x2C74920", VA = "0x182C76120", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x2C75320", Offset = "0x2C73B20", VA = "0x182C75320")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x2C75BD0", Offset = "0x2C743D0", VA = "0x182C75BD0", Slot = "17")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x2C756C0", Offset = "0x2C73EC0", VA = "0x182C756C0", Slot = "18")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x2C75B60", Offset = "0x2C74360", VA = "0x182C75B60", Slot = "10")]
		public void OnEmbody(ILBBGIPPPPJ EJLFIBCCMHH, LPLJHAHPEEF PMFGMJJBADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x24FEC90", Offset = "0x24FD490", VA = "0x1824FEC90", Slot = "11")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x2C759D0", Offset = "0x2C741D0", VA = "0x182C759D0", Slot = "12")]
		public void OnDisembody(bool KMABEKKILJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x2C75430", Offset = "0x2C73C30", VA = "0x182C75430")]
		private void HCMKKGMCCLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x2C75660", Offset = "0x2C73E60", VA = "0x182C75660", Slot = "13")]
		public void NotifyInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x90A150", Offset = "0x908950", VA = "0x18090A150")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x925DC0", Offset = "0x9245C0", VA = "0x180925DC0", Slot = "9")]
		private GameObject NDHBCJAHHDN()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[DefaultMember("Item")]
public class HDJBIAICEGL<T> : JPAJHNEFJFD<T>, ALJIFOIANLF<LPLJHAHPEEF, T>, KCHKLIOOFLC<LPLJHAHPEEF>, MNKCCJJMJKH, IDisposable, KGGCPADPPEB where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly KCHKLIOOFLC<Entity> OPCEAOKDBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly HMBELPNBOEG LNJHNPCFKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private Delegate PHBEBNHEBPN;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public string EHNKIECOKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x39683B0", Offset = "0x3966BB0", VA = "0x1839683B0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Type ILFDEIBDFFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x396D820", Offset = "0x396C020", VA = "0x18396D820", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public BMPCFGMBEIA JFGADNLFGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x396A850", Offset = "0x3969050", VA = "0x18396A850", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public int EDHJHHDEOKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x39684F0", Offset = "0x3966CF0", VA = "0x1839684F0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public CICLHDCPBNI LFLBPEILMMD
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x396A580", Offset = "0x3968D80", VA = "0x18396A580", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event EEJPKNFMFLB<LPLJHAHPEEF> NHPDJIPDPHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x396DB70", Offset = "0x396C370", VA = "0x18396DB70", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x396C690", Offset = "0x396AE90", VA = "0x18396C690", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x299C380", Offset = "0x299AB80", VA = "0x18299C380")]
	public HDJBIAICEGL(KCHKLIOOFLC<Entity> OPCEAOKDBMJ, HMBELPNBOEG LNJHNPCFKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x299A5F0", Offset = "0x2998DF0", VA = "0x18299A5F0")]
	private Entity LADHFHOPINH(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x299A600", Offset = "0x2998E00", VA = "0x18299A600")]
	private LPLJHAHPEEF LADHFHOPINH(Entity AJDEFAPHMKF)
	{
		return default(LPLJHAHPEEF);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x396B160", Offset = "0x3969960", VA = "0x18396B160", Slot = "4")]
	public T LPKBLHIFLLL(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x396D4A0", Offset = "0x396BCA0", VA = "0x18396D4A0")]
	public bool OLFLGMGEIBD(LPLJHAHPEEF BBNGIDIFEAM, in T PCKLDBCFAAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x396E0D0", Offset = "0x396C8D0", VA = "0x18396E0D0", Slot = "7")]
	public bool PINCLHPNEDE(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x396BB00", Offset = "0x396A300", VA = "0x18396BB00", Slot = "8")]
	public void LPKBLHIFLLL(LPLJHAHPEEF BBNGIDIFEAM, KOAODCFHIDH MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x396C950", Offset = "0x396B150", VA = "0x18396C950", Slot = "9")]
	public bool OLFLGMGEIBD(LPLJHAHPEEF BBNGIDIFEAM, DMEBMKFMGNA PCKLDBCFAAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x2999B60", Offset = "0x2998360", VA = "0x182999B60", Slot = "16")]
	public void DMJAGMBBENO(NADHHNFNDJH INDEBDDLMDO, [Optional] object HNBDDLBIIOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x3967F20", Offset = "0x3966720", VA = "0x183967F20", Slot = "10")]
	public bool BBGJPJPLCPO(LPLJHAHPEEF KLLNOLIEMOA, LPLJHAHPEEF EMGBKAPJLEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x39699A0", Offset = "0x39681A0", VA = "0x1839699A0")]
	private void JHKFIIBMPAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x3968F00", Offset = "0x3967700", VA = "0x183968F00")]
	private void ILCAMAJGLFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x396FF30", Offset = "0x396E730", VA = "0x18396FF30")]
	private void PKLMDICGGEB(Entity AJDEFAPHMKF, in DMEBMKFMGNA MDBHGCNGNDL, in DMEBMKFMGNA PCKLDBCFAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x396A950", Offset = "0x3969150", VA = "0x18396A950")]
	private void LKOFBKBKEJJ(Entity AJDEFAPHMKF, in DMEBMKFMGNA MDBHGCNGNDL, in DMEBMKFMGNA PCKLDBCFAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x23BD290", Offset = "0x23BBA90", VA = "0x1823BD290", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x3970590", Offset = "0x396ED90", VA = "0x183970590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[HHKHACIGOAG(JLEAEANKKDG.Application)]
[KHNAILLFHGJ(typeof(OMKEKEENCPE), new string[] { })]
internal class OMKEKEENCPE
{
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private bool HLEJICMEJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private bool MKFLCFFHPBF;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool JLFBNHADDGL
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x97D920", Offset = "0x97C120", VA = "0x18097D920")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x22BCBF0", Offset = "0x22BB3F0", VA = "0x1822BCBF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool NDKPLANDCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0xA0CDA0", Offset = "0xA0B5A0", VA = "0x180A0CDA0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x22BCC00", Offset = "0x22BB400", VA = "0x1822BCC00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public OMKEKEENCPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[KHNAILLFHGJ(typeof(ALFHDLJDEIN), new string[] { })]
public class LPGDCJFMCJH : ALFHDLJDEIN, NOFCHOCEBPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private class KJEOMKDMIKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public List<CapsuleCollider> KFJCLAFCEKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public List<SphereCollider> KCPBMHMDHAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public GameObject FGGLBNGACHO;

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x22327B0", Offset = "0x2230FB0", VA = "0x1822327B0")]
		public KJEOMKDMIKK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	[NAAJCOHOAKA]
	private HMBELPNBOEG FLLOBPAICGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	[NAAJCOHOAKA]
	private OJMMJKOMFGB BJALHBMCJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private readonly Dictionary<Entity, KJEOMKDMIKK> EPOAONKNKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private GameObject LHDFIDEOPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private GameObject NAPLNAEEFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private GameObject PLDABOMMPBN;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private GameObject KKOBPMJJMME
	{
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x2928A30", Offset = "0x2927230", VA = "0x182928A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x2928850", Offset = "0x2927050", VA = "0x182928850", Slot = "6")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x29290A0", Offset = "0x29278A0", VA = "0x1829290A0", Slot = "4")]
	public void OKAEPNPENJP(Entity PNLGFGIAADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x2928AF0", Offset = "0x29272F0", VA = "0x182928AF0", Slot = "5")]
	public void LBFHMOAJDMD(Entity PNLGFGIAADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x2928530", Offset = "0x2926D30", VA = "0x182928530", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x29288C0", Offset = "0x29270C0", VA = "0x1829288C0")]
	private KJEOMKDMIKK JFFPGJBDEJE(Entity PNLGFGIAADP, KNBBFGODFFJ BENEHBIADLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x29276F0", Offset = "0x2925EF0", VA = "0x1829276F0")]
	private void DGJGEJPGFFD(KNBBFGODFFJ BENEHBIADLM, KJEOMKDMIKK CMBJPMHHHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x2929460", Offset = "0x2927C60", VA = "0x182929460")]
	private void PEFEGLBPBNG(KNBBFGODFFJ BENEHBIADLM, KJEOMKDMIKK CMBJPMHHHIJ, int GGHDFDACLIP, Vector3 PAOMABBDKAH, Quaternion APAHFEOKBOD, float MMDOOKNHKEB, float AJHBENNHBJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x2928690", Offset = "0x2926E90", VA = "0x182928690")]
	private void FHKAFGEALAH(KJEOMKDMIKK CMBJPMHHHIJ, int FEIKJHECNJA, Vector3 PAOMABBDKAH, float MMDOOKNHKEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x2928230", Offset = "0x2926A30", VA = "0x182928230")]
	private void DIHNNMNDEMG(KNBBFGODFFJ BENEHBIADLM, KJEOMKDMIKK CMBJPMHHHIJ, int KCLDBNHDJHA, int CEILCAGDDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x2B57520", Offset = "0x2B55D20", VA = "0x182B57520")]
	private T BMNEDODNMIF<T>(KNBBFGODFFJ BENEHBIADLM, ref GameObject ALNJPMNLFGF, Vector3 GGKJMICDBEF, Quaternion CCIFDEOEEEF) where T : Collider
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x2929700", Offset = "0x2927F00", VA = "0x182929700")]
	public LPGDCJFMCJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[DefaultMember("Item")]
public class NKCJKIAPEHI<From, To> where From : struct, IEquatable<From>
{
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[CHALNEEBFJF(typeof(KPDEPPFNAGM))]
[KHNAILLFHGJ(typeof(LMFAIJHLJOL), new string[] { })]
public class CNCGIFAMJHB : LMFAIJHLJOL, PCAPGPPECJN, NOFCHOCEBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private readonly Dictionary<int, JFKJFANPLHM> NBOEIBMMFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private readonly Dictionary<JFKJFANPLHM, int> EAAKMPPFKMK;

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x28A93F0", Offset = "0x28A7BF0", VA = "0x1828A93F0", Slot = "6")]
	public void PAHLDMJMCEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x28A9300", Offset = "0x28A7B00", VA = "0x1828A9300", Slot = "7")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x28A9080", Offset = "0x28A7880", VA = "0x1828A9080")]
	private void DKPJAHIBHKJ(List<(JFKJFANPLHM nameHash, FGAIDOMHKBP stableTypeHash, Type type)> DFMKDLJIHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x28A8F30", Offset = "0x28A7730", VA = "0x1828A8F30", Slot = "4")]
	public JFKJFANPLHM AEDLPELAGEF(int KFGBCCEFCMB)
	{
		return default(JFKJFANPLHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x28A9290", Offset = "0x28A7A90", VA = "0x1828A9290", Slot = "5")]
	public int HICMHLBAJKB(JFKJFANPLHM NCCLPGLKOFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x28A94C0", Offset = "0x28A7CC0", VA = "0x1828A94C0")]
	public CNCGIFAMJHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class EDJNPINGKLL
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class NNAGOBJIOBB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class JNGMPMEABEE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class OLEOBIOMIAB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x2C73750", Offset = "0x2C71F50", VA = "0x182C73750")]
	public static Entity MGHOKJHDGAN(this EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x2C72EC0", Offset = "0x2C716C0", VA = "0x182C72EC0")]
	public static DynamicBuffer<OEOKFMKAJDD> HBEDFLDOOJA(this EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF)
	{
		return default(DynamicBuffer<OEOKFMKAJDD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x2C73960", Offset = "0x2C72160", VA = "0x182C73960")]
	public static bool PPGKKCPNFNE(this EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF, Allocator HMGEFCKKBID, out NativeArray<Entity> DAPHIBAMHGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x2C72AF0", Offset = "0x2C712F0", VA = "0x182C72AF0")]
	public static NativeArray<Entity> DMODGBBJGJP(this EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x2C732E0", Offset = "0x2C71AE0", VA = "0x182C732E0")]
	public static int JIDHEKFPBDJ(this EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x2C733F0", Offset = "0x2C71BF0", VA = "0x182C733F0")]
	public static void LGPJLLEGNFL(NativeArray<Entity> KKDNOJEGEJF, NativeArray<Entity> LHKEFPJAGID, EntityManager EADLBIHJKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x2C72F50", Offset = "0x2C71750", VA = "0x182C72F50")]
	public static bool IBBKINNCCLP(this EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF, Entity IKDGFEDODNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x2C737C0", Offset = "0x2C71FC0", VA = "0x182C737C0")]
	public static bool PGFPMKJEAKM(this EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF, Entity MPGGAHNCHOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x2C730C0", Offset = "0x2C718C0", VA = "0x182C730C0")]
	public static NativeList<Entity> IEHAIKCFKOK(this EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF, bool BPKEPDIPDBN = false, Allocator HMGEFCKKBID = Allocator.Temp)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x2C73650", Offset = "0x2C71E50", VA = "0x182C73650")]
	public static Entity MAPBPOGNGKF(this EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x2C72C60", Offset = "0x2C71460", VA = "0x182C72C60")]
	public static bool FOCFAPBPKCF(this EntityManager EADLBIHJKBG, Entity MPGGAHNCHOK, Entity PGMGJHKACLK, out Entity PLFDJFKPNCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x2C729D0", Offset = "0x2C711D0", VA = "0x182C729D0")]
	internal static void DCMFNGBKOHK(EntityManager EADLBIHJKBG, Entity GJPBCFJDGCH, Entity CICDHHEGIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x2C728E0", Offset = "0x2C710E0", VA = "0x182C728E0")]
	private static bool CMKCAJNCFPD(EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF, Entity IKDGFEDODNH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[NLPBPNHDEFE]
internal struct JCKIBOAMOOM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public JBNGNAKFECF ACCIBJJKHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public EJOPMBPGGHJ AMDKOMACAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public KNGEOHOLDBN.OKOCDJJIKOF.HLDOOKMFELB MNJCDKNLLPF;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public static readonly LIJOCGCHMIA<JCKIBOAMOOM> GDCPNJEFLGI;

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x24F3C50", Offset = "0x24F2450", VA = "0x1824F3C50")]
	public static JCKIBOAMOOM DLACBILIHKK(in JBNGNAKFECF ACCIBJJKHBD)
	{
		return default(JCKIBOAMOOM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[HHKHACIGOAG(JLEAEANKKDG.Application)]
public interface DPIBMMINHPF
{
	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	KNGEOHOLDBN.OKOCDJJIKOF.HLDOOKMFELB EEEJMDHDIBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public static class KOMPKGPJGBF
{
	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x291EAA0", Offset = "0x291D2A0", VA = "0x18291EAA0")]
	public static JBNGNAKFECF IIAHNGLAOKG(IFDBCDKGAKP GJPBCFJDGCH)
	{
		return default(JBNGNAKFECF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class EPHMCMHLONN : CANOBKDKPKE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private readonly bool HLEJICMEJHJ;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public HIJMGKLGPJD BHNPCKKBFBL
	{
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x893100", Offset = "0x891900", VA = "0x180893100", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x1B7EAF0", Offset = "0x1B7D2F0", VA = "0x181B7EAF0")]
	public EPHMCMHLONN(bool HLEJICMEJHJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x2C75260", Offset = "0x2C73A60", VA = "0x182C75260", Slot = "5")]
	public ByteString OHMEEAJBIJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
internal class BIOFFFJPOGG
{
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private static readonly JNGNMMOLKFF KHMBAFOGILH;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private static readonly JNGNMMOLKFF EILJILOGCEE;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private static readonly ProfilerMarker NEDJFHOPHJK;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private static readonly ProfilerMarker HLBGLMKBHLD;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private static readonly ProfilerMarker FEHEEICEHGM;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private static readonly ProfilerMarker NNEEBEMLNOL;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private static readonly ProfilerMarker GFCALECMKLF;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static readonly ProfilerMarker EIENDCBIMNF;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly ProfilerMarker NCGDAFJOAEF;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly ProfilerMarker MNAPIJCMPAN;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly ProfilerMarker ILFFPJINPOG;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static readonly ProfilerMarker OACJCFCNGNP;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static readonly ProfilerMarker GAPNIFLBFIA;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly ProfilerMarker FDDBCDFFKBH;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly ProfilerMarker HJPLLGPPAKH;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly ProfilerMarker PMAPJILPAOL;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly ProfilerMarker OENGFBPEFKO;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly ProfilerMarker LEABLICKPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private readonly KLNIFBHFODA JAPKMHMAMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private readonly ByteString BLAINNBNMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private readonly NDJLNOJIHMB KGMNNCCACLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private readonly NAHGLKOIEAI BOBHLPNKBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private readonly COBBILJPCCC HIIMPMANMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private readonly GMHFFPADGAG DPBIPCAHMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private readonly DKKLEIPMCPM DEEPDILHBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private readonly OMKEKEENCPE IDFNINJJCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private readonly TaskCompletionSource<bool> FDPDMNLGALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private readonly JMMEJCKOABA LGKGBPHHHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private readonly HFJJJPDEPIE.AMMIKNCOCNE MCJFNKGJPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private ILBBGIPPPPJ EJLFIBCCMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private DCAINADNFLE GIPIKBONFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private LBOJFNDAHOB FKGINHFEOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private KNGEOHOLDBN DDHCEFGCGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private HIJMGKLGPJD ODNJCDEIIJN;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public Action<bool> KLPMDHNNJMH
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x92DCB0", Offset = "0x92C4B0", VA = "0x18092DCB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x92D9E0", Offset = "0x92C1E0", VA = "0x18092D9E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public Action OHKIENGBHCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x8FC280", Offset = "0x8FAA80", VA = "0x1808FC280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0F0", Offset = "0x8F98F0", VA = "0x1808FB0F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public Action BJLJOPFKMKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x91A030", Offset = "0x918830", VA = "0x18091A030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0xAEAE70", Offset = "0xAE9670", VA = "0x180AEAE70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public Action JNPGKGKJADN
	{
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0xAE7B00", Offset = "0xAE6300", VA = "0x180AE7B00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0xE9BD60", Offset = "0xE9A560", VA = "0x180E9BD60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public IEnumerable<PMMFFJMLFOG> GOFBMLPNGIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x9F5010", Offset = "0x9F3810", VA = "0x1809F5010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x9F8FF0", Offset = "0x9F77F0", VA = "0x1809F8FF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public LIIAPEIGDIL MEOGKPPDLPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x16EF9C0", Offset = "0x16EE1C0", VA = "0x1816EF9C0")]
		[CompilerGenerated]
		get
		{
			return default(LIIAPEIGDIL);
		}
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x16EE480", Offset = "0x16ECC80", VA = "0x1816EE480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public HIJMGKLGPJD BHNPCKKBFBL
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x907500", Offset = "0x905D00", VA = "0x180907500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public MPAKIJEEIFP MDGENPGOMKP
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0xE58200", Offset = "0xE56A00", VA = "0x180E58200")]
		get
		{
			return default(MPAKIJEEIFP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public LocalId PCBLKPOAMHF
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x289B700", Offset = "0x2899F00", VA = "0x18289B700")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public Task HIEHBJMEMDB
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x289B8A0", Offset = "0x289A0A0", VA = "0x18289B8A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x289DC40", Offset = "0x289C440", VA = "0x18289DC40")]
	public BIOFFFJPOGG(ByteString BLAINNBNMDK, MPAKIJEEIFP AIMJDKDEKMH, in JMMEJCKOABA LGKGBPHHHBD, NDJLNOJIHMB KGMNNCCACLI, KFBLILCDCFC OMGIJLOIGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x289B730", Offset = "0x2899F30", VA = "0x18289B730")]
	public void FEIFDLJJPLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x289C870", Offset = "0x289B070", VA = "0x18289C870")]
	public bool LCEFAGCAIBN(MPAKIJEEIFP BEELAINJGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x289B220", Offset = "0x2899A20", VA = "0x18289B220")]
	private bool CPHOCJJPEBO(MPAKIJEEIFP PODDIAOEGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x289C6A0", Offset = "0x289AEA0", VA = "0x18289C6A0")]
	private void KDLNKIFLJGC(MPAKIJEEIFP NMDCNGACNKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x289B540", Offset = "0x2899D40", VA = "0x18289B540")]
	private bool DDELCEIPJLD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x289C3C0", Offset = "0x289ABC0", VA = "0x18289C3C0")]
	private bool JHJGMNCBINC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x289C510", Offset = "0x289AD10", VA = "0x18289C510")]
	public bool JJNHHGBIGAI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x289CEB0", Offset = "0x289B6B0", VA = "0x18289CEB0")]
	private bool MLMBIEJBEJB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x289D430", Offset = "0x289BC30", VA = "0x18289D430")]
	private bool PNCCEFDIBCJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x289D6F0", Offset = "0x289BEF0", VA = "0x18289D6F0")]
	private bool PNKPFHKIAOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x289B710", Offset = "0x2899F10", VA = "0x18289B710")]
	private bool EOBNFACMCDH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x289D330", Offset = "0x289BB30", VA = "0x18289D330")]
	private bool OJAMEACAFOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x289BF30", Offset = "0x289A730", VA = "0x18289BF30")]
	public void JCEGMOCDGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x289B170", Offset = "0x2899970", VA = "0x18289B170")]
	[CompilerGenerated]
	private void AMGAKMDGIFN(MPAKIJEEIFP PODDIAOEGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x289C6F0", Offset = "0x289AEF0", VA = "0x18289C6F0")]
	[CompilerGenerated]
	private bool KJPHCHLDJPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x289C890", Offset = "0x289B090", VA = "0x18289C890")]
	[CompilerGenerated]
	private void LMOPGBHMEAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x289B9D0", Offset = "0x289A1D0", VA = "0x18289B9D0")]
	[CompilerGenerated]
	private World GFBNCCOGLGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x289B8E0", Offset = "0x289A0E0", VA = "0x18289B8E0")]
	[CompilerGenerated]
	private void FIGFBGHKJGL(World NDJLFFHCOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x289BAC0", Offset = "0x289A2C0", VA = "0x18289BAC0")]
	[CompilerGenerated]
	private int HGECJAGMGDO(World NDJLFFHCOIL, ByteString BLAINNBNMDK, KNGEOHOLDBN.OKOCDJJIKOF.HLDOOKMFELB MNJCDKNLLPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x289CCD0", Offset = "0x289B4D0", VA = "0x18289CCD0")]
	[CompilerGenerated]
	private void LOLDJBOGHAB(World EJLFIBCCMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x289D1F0", Offset = "0x289B9F0", VA = "0x18289D1F0")]
	[CompilerGenerated]
	internal static JBNLECMONHM NKOPOILKPMF(EntityManager JMPILCJEGPD, EntityManager GPFONEAGMIL, int CIIACOBABIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x289BE60", Offset = "0x289A660", VA = "0x18289BE60")]
	[CompilerGenerated]
	private void IOJJOLAFJJM(HIJMGKLGPJD ODNJCDEIIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x289BBD0", Offset = "0x289A3D0", VA = "0x18289BBD0")]
	[CompilerGenerated]
	private void IIBMFGIHKIJ(EntityManager EADLBIHJKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x289BDA0", Offset = "0x289A5A0", VA = "0x18289BDA0")]
	[CompilerGenerated]
	private void IKNKPALNJND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x289C3A0", Offset = "0x289ABA0", VA = "0x18289C3A0")]
	[CompilerGenerated]
	private void JHHNPKNGDKN(string MDOAADHDBMA, EntityManager EADLBIHJKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x289B820", Offset = "0x289A020", VA = "0x18289B820")]
	[CompilerGenerated]
	private DNDKGEBNELK<JMMEJCKOABA> FEMAPOBLJPI(EntityManager EADLBIHJKBG)
	{
		return default(DNDKGEBNELK<JMMEJCKOABA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal class KJCJMPCEBLI : CCNMMNMNEDJ
{
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private static readonly JNGNMMOLKFF EILJILOGCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private readonly bool HLEJICMEJHJ;

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x24FDD40", Offset = "0x24FC540", VA = "0x1824FDD40")]
	public KJCJMPCEBLI(bool HLEJICMEJHJ, NDJLNOJIHMB KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0xA65CC0", Offset = "0xA644C0", VA = "0x180A65CC0", Slot = "10")]
	protected override bool ADPGNBDDFMO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x24FDC00", Offset = "0x24FC400", VA = "0x1824FDC00", Slot = "11")]
	protected override void BJKLCDPDBNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x24FDC60", Offset = "0x24FC460", VA = "0x1824FDC60", Slot = "12")]
	protected override NativeArray<EntityRemapUtility.EntityRemapInfo> KHBFMOEGBND(NativeArray<EntityRemapUtility.EntityRemapInfo> EMCICIGHLMH)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
internal struct JMMEJCKOABA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	public JBNGNAKFECF KPBEHAGEDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	public Entity GJPBCFJDGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	public ACCHBEBMBDA AMDKOMACAKL;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public static readonly LIJOCGCHMIA<JMMEJCKOABA> GDCPNJEFLGI;
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
internal class KLNIFBHFODA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	private enum LEIJONCMDFI
	{
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		Running,
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		Completed,
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		Cancelled,
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		Disposed
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class EPNDJMJOBPA : IEnumerable<MPAKIJEEIFP>, IEnumerable, IEnumerator<MPAKIJEEIFP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private MPAKIJEEIFP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private MPAKIJEEIFP target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public MPAKIJEEIFP <>3__target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public KLNIFBHFODA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private int <allowedTarget>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private int <nextCompletedPhases>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private MPAKIJEEIFP <phase>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		private MPAKIJEEIFP System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.Serialization.DeserializePhases>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0x918E20", Offset = "0x917620", VA = "0x180918E20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(MPAKIJEEIFP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x222C7A0", Offset = "0x222AFA0", VA = "0x18222C7A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x1055DD0", Offset = "0x10545D0", VA = "0x181055DD0")]
		[DebuggerHidden]
		public EPNDJMJOBPA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x222C620", Offset = "0x222AE20", VA = "0x18222C620", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x222C760", Offset = "0x222AF60", VA = "0x18222C760", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x222C6B0", Offset = "0x222AEB0", VA = "0x18222C6B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MPAKIJEEIFP> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Serialization.DeserializePhases>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x222C6B0", Offset = "0x222AEB0", VA = "0x18222C6B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class MHEHNGHLIPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public MPAKIJEEIFP phase;

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public MHEHNGHLIPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x2234FA0", Offset = "0x22337A0", VA = "0x182234FA0")]
		internal object HFOIJIPIDHA(MPAKIJEEIFP a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly JNGNMMOLKFF EILJILOGCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private readonly MPAKIJEEIFP AIMJDKDEKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private readonly Func<MPAKIJEEIFP, bool> JOLFPDFBKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly Action<MPAKIJEEIFP> JIPEEMMPFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private int JIMLHDBOCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private LEIJONCMDFI COOBJCJFHEP;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public MPAKIJEEIFP MDGENPGOMKP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x7DF240", Offset = "0x7DDA40", VA = "0x1807DF240")]
		get
		{
			return default(MPAKIJEEIFP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool GKHBBLGCCAM
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x24FECA0", Offset = "0x24FD4A0", VA = "0x1824FECA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x24FF1A0", Offset = "0x24FD9A0", VA = "0x1824FF1A0")]
	public KLNIFBHFODA(MPAKIJEEIFP AIMJDKDEKMH, Func<MPAKIJEEIFP, bool> JOLFPDFBKCP, Action<MPAKIJEEIFP> JIPEEMMPFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x24FF050", Offset = "0x24FD850", VA = "0x1824FF050")]
	[IteratorStateMachine(typeof(EPNDJMJOBPA))]
	private IEnumerable<MPAKIJEEIFP> LJFLNJCNMMI(MPAKIJEEIFP BEELAINJGPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x24FECB0", Offset = "0x24FD4B0", VA = "0x1824FECB0")]
	public bool LCEFAGCAIBN(MPAKIJEEIFP BEELAINJGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x24FEC30", Offset = "0x24FD430", VA = "0x1824FEC30")]
	private void CCPAFFLIAHM(MPAKIJEEIFP PODDIAOEGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x24FEC90", Offset = "0x24FD490", VA = "0x1824FEC90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct DNDKGEBNELK<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private EntityManager EADLBIHJKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private readonly Entity CDOLDNGFACE;

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x27F0190", Offset = "0x27EE990", VA = "0x1827F0190")]
	public DNDKGEBNELK(EntityManager EADLBIHJKBG, in T LGKGBPHHHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x27F0180", Offset = "0x27EE980", VA = "0x1827F0180", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class DNKKLEMMLLD : CCNMMNMNEDJ
{
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x400020E")]
	private static readonly JNGNMMOLKFF EILJILOGCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	private readonly JCKIBOAMOOM LGKGBPHHHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	private NativeList<Entity> KJCGENDADND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	private NativeArray<Entity> AGLNLJNMOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> MPMNOEDBMHG;

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x2C6D1D0", Offset = "0x2C6B9D0", VA = "0x182C6D1D0")]
	public DNKKLEMMLLD(IEnumerable<LPLJHAHPEEF> ADGNPKODABN, in JCKIBOAMOOM LGKGBPHHHBD, NDJLNOJIHMB KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x7EE860", Offset = "0x7ED060", VA = "0x1807EE860", Slot = "10")]
	protected override bool ADPGNBDDFMO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x2C6D0D0", Offset = "0x2C6B8D0", VA = "0x182C6D0D0", Slot = "9")]
	protected override JCKIBOAMOOM NCGJPMEIIBJ()
	{
		return default(JCKIBOAMOOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x2C6CE10", Offset = "0x2C6B610", VA = "0x182C6CE10", Slot = "11")]
	protected override void BJKLCDPDBNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x2C6CF90", Offset = "0x2C6B790", VA = "0x182C6CF90", Slot = "12")]
	protected override NativeArray<EntityRemapUtility.EntityRemapInfo> KHBFMOEGBND(NativeArray<EntityRemapUtility.EntityRemapInfo> EMCICIGHLMH)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x2C6CF20", Offset = "0x2C6B720", VA = "0x182C6CF20", Slot = "8")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal abstract class CCNMMNMNEDJ : CANOBKDKPKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	private static readonly ProfilerMarker NNEEBEMLNOL;

	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private static readonly ProfilerMarker EFENGKHLEDM;

	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private static readonly ProfilerMarker GFCALECMKLF;

	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private static readonly ProfilerMarker ILJJJCBMFBI;

	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private static readonly ProfilerMarker NCGDAFJOAEF;

	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private static readonly ProfilerMarker FHOJKELCEJE;

	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private static readonly ProfilerMarker GLJGEFPPHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private readonly NDJLNOJIHMB KGMNNCCACLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private readonly ILBBGIPPPPJ EJLFIBCCMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private readonly DCAINADNFLE GIPIKBONFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private readonly DKKLEIPMCPM DEEPDILHBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private readonly GMHFFPADGAG DPBIPCAHMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private readonly JNGNMMOLKFF EILJILOGCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private readonly HFJJJPDEPIE.AMMIKNCOCNE MCJFNKGJPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private World MCPBDMJPIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private HIJMGKLGPJD ODNJCDEIIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private IDisposable OJFIGCJDCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private ByteString JJJFJMBMIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private KNGEOHOLDBN.OKOCDJJIKOF.HLDOOKMFELB FOCLBNGBBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private bool KHIPHEGOBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private AJCPLKBBBGL KKDJPJAEFBP;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	protected World KFBNIPHCIKI
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x8A9EE0", Offset = "0x8A86E0", VA = "0x1808A9EE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	protected World IHPDJPJEIBM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x28A3E00", Offset = "0x28A2600", VA = "0x1828A3E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public HIJMGKLGPJD BHNPCKKBFBL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x8E9050", Offset = "0x8E7850", VA = "0x1808E9050", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x28A4010", Offset = "0x28A2810", VA = "0x1828A4010")]
	public CCNMMNMNEDJ(NDJLNOJIHMB KGMNNCCACLI, JNGNMMOLKFF MBNJNNGOKFP, JNGNMMOLKFF EILJILOGCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x28A3D00", Offset = "0x28A2500", VA = "0x1828A3D00", Slot = "5")]
	public ByteString OHMEEAJBIJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x28A32C0", Offset = "0x28A1AC0", VA = "0x1828A32C0", Slot = "7")]
	public void JELDACCCIFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x28A3260", Offset = "0x28A1A60", VA = "0x1828A3260", Slot = "8")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x28A3C30", Offset = "0x28A2430", VA = "0x1828A3C30", Slot = "9")]
	protected virtual JCKIBOAMOOM NCGJPMEIIBJ()
	{
		return default(JCKIBOAMOOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool ADPGNBDDFMO();

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract void BJKLCDPDBNO();

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract NativeArray<EntityRemapUtility.EntityRemapInfo> KHBFMOEGBND(NativeArray<EntityRemapUtility.EntityRemapInfo> EMCICIGHLMH);
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[KHNAILLFHGJ(typeof(DPIBMMINHPF), new string[] { })]
internal sealed class FCGEEOMMGDL : DPIBMMINHPF, NOFCHOCEBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	[NAAJCOHOAKA]
	private FNKAOJGCPPO IIJKCLDIFGA;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public KNGEOHOLDBN.OKOCDJJIKOF.HLDOOKMFELB EEEJMDHDIBO
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x2C763D0", Offset = "0x2C74BD0", VA = "0x182C763D0", Slot = "4")]
		get
		{
			return default(KNGEOHOLDBN.OKOCDJJIKOF.HLDOOKMFELB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x2C76440", Offset = "0x2C74C40", VA = "0x182C76440", Slot = "5")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public FCGEEOMMGDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal class PHKCGCGLNCC : LKLBFCMBGLM, KFBLILCDCFC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private readonly BIOFFFJPOGG IKBOIGIEDJD;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public LocalId PDHEKOKAFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x22C0DC0", Offset = "0x22BF5C0", VA = "0x1822C0DC0", Slot = "6")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public IEnumerable<PMMFFJMLFOG> GOFBMLPNGIO
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x22C0E30", Offset = "0x22BF630", VA = "0x1822C0E30", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public LIIAPEIGDIL MEOGKPPDLPO
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x22C0DD0", Offset = "0x22BF5D0", VA = "0x1822C0DD0", Slot = "5")]
		get
		{
			return default(LIIAPEIGDIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Task HIEHBJMEMDB
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x22C0D80", Offset = "0x22BF580", VA = "0x1822C0D80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public HIJMGKLGPJD KJOEGIKHDFH
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x22C0DA0", Offset = "0x22BF5A0", VA = "0x1822C0DA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x22C0E60", Offset = "0x22BF660", VA = "0x1822C0E60")]
	public PHKCGCGLNCC(ByteString BLAINNBNMDK, NDJLNOJIHMB KGMNNCCACLI, Action<bool> CDFCNODNBMC, Action DEAFOIAAGLA, Action DKFMJDOHIOO, Action DGDBOBKJJDN, bool LPKNHFMMJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x22C0E10", Offset = "0x22BF610", VA = "0x1822C0E10", Slot = "9")]
	public bool LCEFAGCAIBN(MPAKIJEEIFP PODDIAOEGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x22C0D60", Offset = "0x22BF560", VA = "0x1822C0D60", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
internal static class GKFCEJJOBPM
{
	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x2C81660", Offset = "0x2C7FE60", VA = "0x182C81660")]
	public static HFJJJPDEPIE.AMMIKNCOCNE GOGKCBDPMNN(NDJLNOJIHMB KGMNNCCACLI)
	{
		return default(HFJJJPDEPIE.AMMIKNCOCNE);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x2C81320", Offset = "0x2C7FB20", VA = "0x182C81320")]
	public static NativeList<Entity> GFHFPFLGEEA(EntityManager EADLBIHJKBG, IEnumerable<LPLJHAHPEEF> ADGNPKODABN)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x2C81740", Offset = "0x2C7FF40", VA = "0x182C81740")]
	public static void KHBFMOEGBND(NativeArray<Entity> AGLNLJNMOIC, NativeList<Entity> KJCGENDADND, NativeArray<EntityRemapUtility.EntityRemapInfo> EMCICIGHLMH, NativeArray<EntityRemapUtility.EntityRemapInfo> MPMNOEDBMHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x1CA7000", Offset = "0x1CA5800", VA = "0x181CA7000")]
	public static Entity MOADKCCJAMC<T>(EntityManager EADLBIHJKBG, in T MENBIMCLIOI) where T : struct, IComponentData
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal class KKNGENIPIFB : JHDIDEHGHHN, KFBLILCDCFC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private readonly BIOFFFJPOGG IKBOIGIEDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private readonly OIKLJKNPPOI PMEOGKNMBGE;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public IMKNGLHILIB KICFICJJDEL
	{
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x7EC6C0", Offset = "0x7EAEC0", VA = "0x1807EC6C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public LocalId PDHEKOKAFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x24FEAB0", Offset = "0x24FD2B0", VA = "0x1824FEAB0", Slot = "9")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Task HIEHBJMEMDB
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x22C0D80", Offset = "0x22BF580", VA = "0x1822C0D80", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public IEnumerable<PMMFFJMLFOG> GOFBMLPNGIO
	{
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x22C0E30", Offset = "0x22BF630", VA = "0x1822C0E30", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public LIIAPEIGDIL MEOGKPPDLPO
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x22C0DD0", Offset = "0x22BF5D0", VA = "0x1822C0DD0", Slot = "8")]
		get
		{
			return default(LIIAPEIGDIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public HIJMGKLGPJD KJOEGIKHDFH
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x22C0DA0", Offset = "0x22BF5A0", VA = "0x1822C0DA0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x24FEB30", Offset = "0x24FD330", VA = "0x1824FEB30")]
	public KKNGENIPIFB(ByteString BLAINNBNMDK, IMKNGLHILIB DIBGJEDAEBB, in JMMEJCKOABA LGKGBPHHHBD, NDJLNOJIHMB KGMNNCCACLI, Action DGDBOBKJJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x24FEAF0", Offset = "0x24FD2F0", VA = "0x1824FEAF0", Slot = "5")]
	public void JELDACCCIFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x22C0E10", Offset = "0x22BF610", VA = "0x1822C0E10", Slot = "12")]
	public bool LCEFAGCAIBN(MPAKIJEEIFP PODDIAOEGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x24FEAD0", Offset = "0x24FD2D0", VA = "0x1824FEAD0", Slot = "6")]
	public void JCEGMOCDGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x22C0D60", Offset = "0x22BF560", VA = "0x1822C0D60", Slot = "13")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[KHNAILLFHGJ(typeof(NHHFEIDPNIC), new string[] { })]
public class IJCOFHFJPPA : NHHFEIDPNIC, IIIIOJEFCCI, MKAOANKMGHC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private NCFCHDEHMHC KGMNNCCACLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private NAHGLKOIEAI BOBHLPNKBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private ILBBGIPPPPJ EJLFIBCCMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private LBOJFNDAHOB FKGINHFEOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private ABMIKBNFCBA ODAMNCBMCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private HMBELPNBOEG LNJHNPCFKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private AEDKFOCGAIL AAOAOHHKNIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private IKCMADHPPKE MFHEANKMMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private ILGLLPNDOPK NDJHELJNLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private FCNMLNBCAFD LAEPKFGACAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private MEGBGGHIJBE LGFOMKLEHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private NNHDHBPFLOE EIBIPCCLNGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private FKAJABEJDAD LLAOOFFHICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private JGHGFLIKNJI PHFMBPBGGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private OJMMJKOMFGB HFKPODFAPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private BEGAPFFEIJA KABEOEGJBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private HMLONANDNGP PMIKJKGKCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private GHENGDIBFHP ALEMELALCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private BHNAPIGDOEG EOMPLHBBDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private HCOBHGJLPEC KLEOGNMJFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private FNKAOJGCPPO KFLPLGKPMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private LGNMGLONHCC ELMENJAOGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private bool PMADFOMNIPK;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public NCFCHDEHMHC NGDMEGOLFHB
	{
		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public NAHGLKOIEAI BKEEIANIHAB
	{
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public ILBBGIPPPPJ FINDODONFAN
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x7EC6C0", Offset = "0x7EAEC0", VA = "0x1807EC6C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public HMBELPNBOEG AFLOIHDEPAG
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x7ED740", Offset = "0x7EBF40", VA = "0x1807ED740", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public AEDKFOCGAIL EAFOKJKFLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x8A69F0", Offset = "0x8A51F0", VA = "0x1808A69F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public IKCMADHPPKE PNGKBDHOIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x7DFCD0", Offset = "0x7DE4D0", VA = "0x1807DFCD0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public ILGLLPNDOPK GENBLHALMFO
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x7ED770", Offset = "0x7EBF70", VA = "0x1807ED770", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public MEGBGGHIJBE CBFCGAFOEKL
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x8A9EE0", Offset = "0x8A86E0", VA = "0x1808A9EE0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public NNHDHBPFLOE GHMDJOGEELA
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x8E9050", Offset = "0x8E7850", VA = "0x1808E9050", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public FKAJABEJDAD DGGJMABKKIK
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x8E8B60", Offset = "0x8E7360", VA = "0x1808E8B60", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public JGHGFLIKNJI FCPJBKLDKIE
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD00", Offset = "0x7DE500", VA = "0x1807DFD00", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public OJMMJKOMFGB HKPJDPLPPEG
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x7DFCF0", Offset = "0x7DE4F0", VA = "0x1807DFCF0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public BEGAPFFEIJA NCMCCDOKGMM
	{
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0xA51D10", Offset = "0xA50510", VA = "0x180A51D10", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public HMLONANDNGP KOBGPAMELOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0xA51E50", Offset = "0xA50650", VA = "0x180A51E50", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public GHENGDIBFHP OHHBPAEGGHG
	{
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x7F0CD0", Offset = "0x7EF4D0", VA = "0x1807F0CD0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public BHNAPIGDOEG FJDBDHFEDME
	{
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x7F39B0", Offset = "0x7F21B0", VA = "0x1807F39B0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public HCOBHGJLPEC GCLFBEPNJDP
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0xA0BDA0", Offset = "0xA0A5A0", VA = "0x180A0BDA0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public FNKAOJGCPPO AILIOFHMAPP
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0xA52590", Offset = "0xA50D90", VA = "0x180A52590", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public LGNMGLONHCC OJBBAPDGNDA
	{
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0xA4DA40", Offset = "0xA4C240", VA = "0x180A4DA40", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public PJIPLFMPMBF EKMAFGNLMNM
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x7F0C80", Offset = "0x7EF480", VA = "0x1807F0C80", Slot = "23")]
		get
		{
			return default(PJIPLFMPMBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x24F0880", Offset = "0x24EF080", VA = "0x1824F0880", Slot = "24")]
	public void PMIKACAIKGJ(NCFCHDEHMHC JOCEPOLJMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x24F0850", Offset = "0x24EF050", VA = "0x1824F0850", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x24F0860", Offset = "0x24EF060", VA = "0x1824F0860", Slot = "25")]
	public void IGCNDNBCPAD(NCFCHDEHMHC JOCEPOLJMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public IJCOFHFJPPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[DefaultMember("Item")]
public class OELKBGMILGH : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class NOLAKPCOODK : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public OELKBGMILGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private int <indexOffset>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private int <intCount>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private ulong <value>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private int <index>5__5;

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		int IEnumerator<int>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000508")]
			[Cpp2IlInjected.Address(RVA = "0x918E20", Offset = "0x917620", VA = "0x180918E20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600050A")]
			[Cpp2IlInjected.Address(RVA = "0x2235B10", Offset = "0x2234310", VA = "0x182235B10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0xA2B190", Offset = "0xA29990", VA = "0x180A2B190")]
		[DebuggerHidden]
		public NOLAKPCOODK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x2235950", Offset = "0x2234150", VA = "0x182235950", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x2235AD0", Offset = "0x22342D0", VA = "0x182235AD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private readonly List<ulong> IFCNDEJLHLH;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public int GKGAEPJBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x90BAA0", Offset = "0x90A2A0", VA = "0x18090BAA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x293BBA0", Offset = "0x293A3A0", VA = "0x18293BBA0")]
	public OELKBGMILGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x293BB30", Offset = "0x293A330", VA = "0x18293BB30", Slot = "4")]
	[IteratorStateMachine(typeof(NOLAKPCOODK))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x293BB30", Offset = "0x293A330", VA = "0x18293BB30", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public static class INLKDLGFKMF
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly ComponentType[] NLKECBJHOBO;

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x24F0ED0", Offset = "0x24EF6D0", VA = "0x1824F0ED0")]
	public static Entity BBGLEHACNCI(this EntityManager EADLBIHJKBG)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public sealed class CBMLHGBJNKB<T> : DKGMNOOPMJE<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x294D340", Offset = "0x294BB40", VA = "0x18294D340")]
	public CBMLHGBJNKB(T FFKEMABDPII, T JJHKIIGGPCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[KHNAILLFHGJ(typeof(LMIJBIFPCCA), new string[] { })]
public sealed class CKKIBFNAGPF : LMIJBIFPCCA, IGGLPBJEPAJ<LMIJBIFPCCA>, PCAPGPPECJN, NOFCHOCEBPC
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private readonly Dictionary<LLNAAGHGEOA, EOAAFILKOHP> IKLCLJIFNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private LJIAELGJFDM JALMPEJAFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private OABILJFHBBI LAEPKFGACAO;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool GOECCMDGBAM
	{
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x951EF0", Offset = "0x9506F0", VA = "0x180951EF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x28A8440", Offset = "0x28A6C40", VA = "0x1828A8440")]
	public CKKIBFNAGPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x28A8350", Offset = "0x28A6B50", VA = "0x1828A8350", Slot = "5")]
	public void PAHLDMJMCEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x28A81A0", Offset = "0x28A69A0", VA = "0x1828A81A0", Slot = "6")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x28A8220", Offset = "0x28A6A20", VA = "0x1828A8220", Slot = "4")]
	public bool NOPGAJGAFLG(LLNAAGHGEOA BMKPPKKOMAH, out EOAAFILKOHP PPCAJPBKNLP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
[KHNAILLFHGJ(typeof(LJIAELGJFDM), new string[] { })]
internal sealed class LJIAELGJFDM : PCAPGPPECJN
{
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private readonly Dictionary<Type, EOAAFILKOHP> IKLCLJIFNCH;

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x2926DB0", Offset = "0x29255B0", VA = "0x182926DB0", Slot = "4")]
	public void PAHLDMJMCEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x2926BC0", Offset = "0x29253C0", VA = "0x182926BC0")]
	public void JACMNDDEBJP(Type EIOLDDJPDLH, EOAAFILKOHP PPCAJPBKNLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x2926CD0", Offset = "0x29254D0", VA = "0x182926CD0")]
	public bool NOPGAJGAFLG(Type EIOLDDJPDLH, out EOAAFILKOHP PPCAJPBKNLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x2926E90", Offset = "0x2925690", VA = "0x182926E90")]
	public LJIAELGJFDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal static class KDLNMGPIMKB
{
	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x24F7420", Offset = "0x24F5C20", VA = "0x1824F7420")]
	public static void JACMNDDEBJP(this LJIAELGJFDM DBAHNFPKFPM, EOAAFILKOHP PPCAJPBKNLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public class DKGMNOOPMJE<T> : BEAINEABIAH<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	protected GDECLGLADHL<T> NJIAEMPIEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	protected MFNAOBGLAAN<T> EFNOHEGNMMD;

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0xCEBD20", Offset = "0xCEA520", VA = "0x180CEBD20")]
	public DKGMNOOPMJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x2CBCAC0", Offset = "0x2CBB2C0", VA = "0x182CBCAC0")]
	public DKGMNOOPMJE(GDECLGLADHL<T> NJIAEMPIEHF, MFNAOBGLAAN<T> EFNOHEGNMMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x2CBC780", Offset = "0x2CBAF80", VA = "0x182CBC780", Slot = "10")]
	protected override T KLHPMPNNHAA(ref LHEPNLFFJBK ENOKLPPGOAM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x2CBC3D0", Offset = "0x2CBABD0", VA = "0x182CBC3D0", Slot = "11")]
	protected override void CLIBMONIMNB(ref MHIICIMPJBH HAOHDNKGKPC, T MENBIMCLIOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public static class HIKEGFICMII
{
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[KHNAILLFHGJ(typeof(KOBNMPMOEEH), new string[] { })]
internal sealed class EECBOAEINML : KOBNMPMOEEH, PCAPGPPECJN, NOFCHOCEBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private readonly Dictionary<LLNAAGHGEOA, IDBBJEODNJK> PIIMKMAINMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private OABILJFHBBI LAEPKFGACAO;

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x2C73C30", Offset = "0x2C72430", VA = "0x182C73C30", Slot = "6")]
	public void PAHLDMJMCEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x2C73B60", Offset = "0x2C72360", VA = "0x182C73B60", Slot = "7")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x2C73BC0", Offset = "0x2C723C0", VA = "0x182C73BC0", Slot = "4")]
	public void JACMNDDEBJP(LLNAAGHGEOA BAAPPBDHEJN, Type KCMKPFGLECK, IDBBJEODNJK DBEDOFAPJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x2C73AF0", Offset = "0x2C722F0", VA = "0x182C73AF0", Slot = "5")]
	public bool BBDHLKEJMII(LLNAAGHGEOA BAAPPBDHEJN, out IDBBJEODNJK DBEDOFAPJFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x2C73C80", Offset = "0x2C72480", VA = "0x182C73C80")]
	public EECBOAEINML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[KHNAILLFHGJ(typeof(MKFKBEBMKHL), new string[] { })]
internal sealed class AGLMBBDCOKH : MKFKBEBMKHL, NOFCHOCEBPC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	[NAAJCOHOAKA]
	private OABILJFHBBI LAEPKFGACAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private NativeBitArray FANFGKCMBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private NativeParallelHashMap<MHGAJIKGEGE, int> KCOEPFNBNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private NativeList<int> MPKBIJIJEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private int KNDAGBKKIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private int GJHOLAKOCKJ;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public bool JLFBNHADDGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x2895CB0", Offset = "0x28944B0", VA = "0x182895CB0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public IKAONOBBNND NFEEKPKECEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x2895CD0", Offset = "0x28944D0", VA = "0x182895CD0", Slot = "7")]
		get
		{
			return default(IKAONOBBNND);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x2896010", Offset = "0x2894810", VA = "0x182896010", Slot = "4")]
	public bool PDPJBEINDAM(MHGAJIKGEGE ECBAIECDCID, LLNAAGHGEOA OPCEAOKDBMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x2895D20", Offset = "0x2894520", VA = "0x182895D20", Slot = "8")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x2895E80", Offset = "0x2894680", VA = "0x182895E80", Slot = "6")]
	public void MDBPDDHEDHP(NativeArray<MHGAJIKGEGE> LJNBIMMNBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x2895A30", Offset = "0x2894230", VA = "0x182895A30", Slot = "5")]
	public void FLJJGDAKGID(MHGAJIKGEGE ECBAIECDCID, Span<LLNAAGHGEOA> LAEPKFGACAO, bool INNOONKMDEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x28959A0", Offset = "0x28941A0", VA = "0x1828959A0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public AGLMBBDCOKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[KHNAILLFHGJ(typeof(DLJKMJDECEO), new string[] { })]
public class COBGNOLBIMF : DLJKMJDECEO, NOFCHOCEBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private NAHGLKOIEAI BOBHLPNKBHC;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private uint EDCFHLPIECA
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x28AA960", Offset = "0x28A9160", VA = "0x1828AA960", Slot = "4")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x28AA9B0", Offset = "0x28A91B0", VA = "0x1828AA9B0", Slot = "5")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public COBGNOLBIMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public abstract class ECEHICGGOMI : EOAAFILKOHP
{
	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public abstract Type KPBEFGAMNOG
	{
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void KLHPMPNNHAA(ref LHEPNLFFJBK ENOKLPPGOAM, Span<byte> MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void CLIBMONIMNB(ref MHIICIMPJBH HAOHDNKGKPC, ReadOnlySpan<byte> MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	protected ECEHICGGOMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public abstract class BEAINEABIAH<T> : ECEHICGGOMI where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public override Type KPBEFGAMNOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x218FC10", Offset = "0x218E410", VA = "0x18218FC10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract T KLHPMPNNHAA(ref LHEPNLFFJBK ENOKLPPGOAM);

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract void CLIBMONIMNB(ref MHIICIMPJBH HAOHDNKGKPC, T MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x21902D0", Offset = "0x218EAD0", VA = "0x1821902D0", Slot = "8")]
	public override void KLHPMPNNHAA(ref LHEPNLFFJBK ENOKLPPGOAM, Span<byte> BEELAINJGPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x218F520", Offset = "0x218DD20", VA = "0x18218F520", Slot = "9")]
	public override void CLIBMONIMNB(ref MHIICIMPJBH HAOHDNKGKPC, ReadOnlySpan<byte> ODHKMJMLAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x1FA5BD0", Offset = "0x1FA43D0", VA = "0x181FA5BD0")]
	protected BEAINEABIAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal static class KMBAJEOAHDK
{
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public struct OBNENDELMNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public HMBELPNBOEG LNJHNPCFKIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public OABILJFHBBI HIEDNLNIIOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public NHLFCCPGHPO DFBCJBEDHJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public MKFKBEBMKHL NBFLEJAKAJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public NMHGLGPLAKN MDDINJABOMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public LMIJBIFPCCA IKLCLJIFNCH;

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x2235E80", Offset = "0x2234680", VA = "0x182235E80")]
		public void LDEGPCHGKNG(NCFCHDEHMHC KGMNNCCACLI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public struct IKADDGCFNCG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public NativeList<MHGAJIKGEGE> OAPBHJIHLMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public NativeList<CBGNFPNAGKM> NHOIGPDOBNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public NativeList<MHGAJIKGEGE> OKDKKADGGHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public NativeParallelMultiHashMap<MHGAJIKGEGE, GODHOHPNOGF> LAEPKFGACAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public NativeList<byte> FJECEKKANMC;

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public bool MJNBPCBEDLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000547")]
			[Cpp2IlInjected.Address(RVA = "0x2230990", Offset = "0x222F190", VA = "0x182230990")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x22308F0", Offset = "0x222F0F0", VA = "0x1822308F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private struct LGBONGNPCEH : IComparer<GODHOHPNOGF>
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x2232A70", Offset = "0x2231270", VA = "0x182232A70", Slot = "4")]
		public int Compare(GODHOHPNOGF FBGKLELIKCG, GODHOHPNOGF LFJEFFKGLOE)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	private static readonly JNGNMMOLKFF NCMOLGKHELE;

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x2500A70", Offset = "0x24FF270", VA = "0x182500A70")]
	public static void FPKPNONPJPD(ref MHIICIMPJBH HAOHDNKGKPC, IKADDGCFNCG NFBDMLCENEN, OBNENDELMNH KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x24FF210", Offset = "0x24FDA10", VA = "0x1824FF210")]
	public static IKADDGCFNCG BOBELOKMLEK(ref LHEPNLFFJBK ENOKLPPGOAM, Allocator HMGEFCKKBID, OBNENDELMNH KGMNNCCACLI)
	{
		return default(IKADDGCFNCG);
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x25003D0", Offset = "0x24FEBD0", VA = "0x1825003D0")]
	public static void DIPAGPDLGIJ(IKADDGCFNCG NFBDMLCENEN, OBNENDELMNH KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x24FF530", Offset = "0x24FDD30", VA = "0x1824FF530")]
	public static void CKONMIBIIIM(IKADDGCFNCG NFBDMLCENEN, OBNENDELMNH KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x2500760", Offset = "0x24FEF60", VA = "0x182500760")]
	public static int FDFDNBMDMHJ(IKADDGCFNCG NFBDMLCENEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x2500DC0", Offset = "0x24FF5C0", VA = "0x182500DC0")]
	private static void NJNMJIMFECL(ref MHIICIMPJBH HAOHDNKGKPC, NativeArray<MHGAJIKGEGE> OAPBHJIHLMO, NativeArray<CBGNFPNAGKM> NHOIGPDOBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x25008E0", Offset = "0x24FF0E0", VA = "0x1825008E0")]
	private static void FKDACPAHHDO(ref LHEPNLFFJBK ENOKLPPGOAM, Allocator HMGEFCKKBID, out NativeList<MHGAJIKGEGE> OAPBHJIHLMO, out NativeList<CBGNFPNAGKM> OEPDBGKFGAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x2500D30", Offset = "0x24FF530", VA = "0x182500D30")]
	private static void LDKGKEHPDMF(ref MHIICIMPJBH HAOHDNKGKPC, NativeArray<MHGAJIKGEGE> OKDKKADGGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x24FF820", Offset = "0x24FE020", VA = "0x1824FF820")]
	private static void CLKIDOCDBNJ(ref LHEPNLFFJBK ENOKLPPGOAM, Allocator HMGEFCKKBID, out NativeList<MHGAJIKGEGE> OKDKKADGGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x24FF920", Offset = "0x24FE120", VA = "0x1824FF920")]
	private static void DIJKCLBDBCK(ref MHIICIMPJBH HAOHDNKGKPC, NativeParallelMultiHashMap<MHGAJIKGEGE, GODHOHPNOGF> LAEPKFGACAO, NativeList<byte> FJECEKKANMC, OBNENDELMNH KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x2500EA0", Offset = "0x24FF6A0", VA = "0x182500EA0")]
	private static void OOBONEMMGEA(ref LHEPNLFFJBK ENOKLPPGOAM, Allocator HMGEFCKKBID, out NativeParallelMultiHashMap<MHGAJIKGEGE, GODHOHPNOGF> LAEPKFGACAO, out NativeList<byte> FJECEKKANMC, OBNENDELMNH KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x2500D10", Offset = "0x24FF510", VA = "0x182500D10")]
	private static void HNKHBFNFEOC(int KADPANIACCO, ref int HLLCICDAFIH, ref MHIICIMPJBH HAOHDNKGKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x2500E80", Offset = "0x24FF680", VA = "0x182500E80")]
	private static int OINPMICGIFP(int HLLCICDAFIH, ref LHEPNLFFJBK ENOKLPPGOAM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class IPCPMCBJJHK
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private class EAGDKAPDNMB
	{
		[Cpp2IlInjected.Token(Token = "0x20000C4")]
		[CompilerGenerated]
		private sealed class BFCCAPPMJMB<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000271")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x6000554")]
			[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
			public BFCCAPPMJMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000555")]
			[Cpp2IlInjected.Address(RVA = "0x2194E70", Offset = "0x2193670", VA = "0x182194E70")]
			internal void LJOHLFJIFEG(ref MHIICIMPJBH writer, T value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000556")]
			[Cpp2IlInjected.Address(RVA = "0x2194BB0", Offset = "0x21933B0", VA = "0x182194BB0")]
			internal T BGJMKICPBEN(ref LHEPNLFFJBK reader)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x222C3A0", Offset = "0x222ABA0", VA = "0x18222C3A0")]
		public static void JIABDJKAKFN(LJIAELGJFDM IKLCLJIFNCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x295FBE0", Offset = "0x295E3E0", VA = "0x18295FBE0")]
		private static void GHEIFBDHHBO<T>(LJIAELGJFDM IKLCLJIFNCH, int JJHKIIGGPCB) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x295FB40", Offset = "0x295E340", VA = "0x18295FB40")]
		private static void CDFAODPNCKO<T>(ref MHIICIMPJBH HAOHDNKGKPC, T LAEIDNKAKOO, int JJHKIIGGPCB) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x295FD00", Offset = "0x295E500", VA = "0x18295FD00")]
		private static T KFLMJLKOKLP<T>(ref LHEPNLFFJBK ENOKLPPGOAM, int JJHKIIGGPCB) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public EAGDKAPDNMB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private class GFNOMLPNFAE : LCPPCJJIKCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private LJIAELGJFDM IKLCLJIFNCH;

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x2960590", Offset = "0x295ED90", VA = "0x182960590", Slot = "6")]
		public override void HJMMHIKHNLJ<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x222DD00", Offset = "0x222C500", VA = "0x18222DD00")]
		public static void FAAIDEFCFNC(LJIAELGJFDM IKLCLJIFNCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x222DDB0", Offset = "0x222C5B0", VA = "0x18222DDB0")]
		public GFNOMLPNFAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x24F1230", Offset = "0x24EFA30", VA = "0x1824F1230")]
	public static void LNDFJAJFHDB(LJIAELGJFDM IKLCLJIFNCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x24F1130", Offset = "0x24EF930", VA = "0x1824F1130")]
	private static void CIJGHIBMMHI(ref MHIICIMPJBH BBDFFBIEBJH, quaternion LAEIDNKAKOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x24F1050", Offset = "0x24EF850", VA = "0x1824F1050")]
	private static quaternion BFKMPGIHEEO(ref LHEPNLFFJBK LIOFIIHFDDK)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x1112E00", Offset = "0x1111600", VA = "0x181112E00")]
	public static void KPBJCIPBDBC<T>(LJIAELGJFDM IKLCLJIFNCH, GDECLGLADHL<T> NJIAEMPIEHF, MFNAOBGLAAN<T> EFNOHEGNMMD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x1112D90", Offset = "0x1111590", VA = "0x181112D90")]
	public static void CIOMLCDAKPJ<T>(LJIAELGJFDM PPCAJPBKNLP) where T : struct, MIIOPAJPNBD
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[KHNAILLFHGJ(typeof(KAABEMEKKIO), new string[] { })]
internal class BPADFHHIIEK : NOFCHOCEBPC, KAABEMEKKIO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	[NAAJCOHOAKA]
	private DLJKMJDECEO HJIMKOGCLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private INFEKLPHEGC KBMMDCCCIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private int LBCGEPEKNPP;

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x289F710", Offset = "0x289DF10", VA = "0x18289F710", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x289F5D0", Offset = "0x289DDD0", VA = "0x18289F5D0", Slot = "5")]
	public ADKFIICEFJC AEDABDKLHHF(ReadOnlySpan<byte> BKHMACKFNNF)
	{
		return default(ADKFIICEFJC);
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x289F700", Offset = "0x289DF00", VA = "0x18289F700", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public BPADFHHIIEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[KHNAILLFHGJ(typeof(NMHGLGPLAKN), new string[] { })]
public class FIBDBIIOOFA : NMHGLGPLAKN, PCAPGPPECJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private EBFHNNCEJDJ OKDFPIACNLH;

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x2C77F50", Offset = "0x2C76750", VA = "0x182C77F50", Slot = "8")]
	public void PAHLDMJMCEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x2C778D0", Offset = "0x2C760D0", VA = "0x182C778D0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x2C77760", Offset = "0x2C75F60", VA = "0x182C77760", Slot = "4")]
	public void DIPAGPDLGIJ(MHGAJIKGEGE PMFGMJJBADH, LLNAAGHGEOA BAAPPBDHEJN, ReadOnlySpan<byte> CNBLIGIGBNA, ReadOnlySpan<byte> OBDIMDDAHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x2C77DC0", Offset = "0x2C765C0", VA = "0x182C77DC0", Slot = "7")]
	public bool NBKFNAPJLJO(MHGAJIKGEGE PMFGMJJBADH, LLNAAGHGEOA BAAPPBDHEJN, Span<byte> CNBLIGIGBNA, Span<byte> OBDIMDDAHMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x2C77D50", Offset = "0x2C76550", VA = "0x182C77D50", Slot = "5")]
	public bool LEEFMGEANJH(MHGAJIKGEGE PMFGMJJBADH, LLNAAGHGEOA BAAPPBDHEJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x2C77720", Offset = "0x2C75F20", VA = "0x182C77720", Slot = "6")]
	public bool CKONMIBIIIM(MHGAJIKGEGE PMFGMJJBADH, LLNAAGHGEOA BAAPPBDHEJN, ReadOnlySpan<byte> OBDIMDDAHMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x2C778E0", Offset = "0x2C760E0", VA = "0x182C778E0")]
	private bool GBHPHJLFPPM(MHGAJIKGEGE PMFGMJJBADH, LLNAAGHGEOA BAAPPBDHEJN, ReadOnlySpan<byte> OBDIMDDAHMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public FIBDBIIOOFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public sealed class HBNMNDDMGFP<T> : BEAINEABIAH<T> where T : struct, MIIOPAJPNBD
{
	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x3955B00", Offset = "0x3954300", VA = "0x183955B00", Slot = "10")]
	protected override T KLHPMPNNHAA(ref LHEPNLFFJBK ENOKLPPGOAM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x3955A90", Offset = "0x3954290", VA = "0x183955A90", Slot = "11")]
	protected override void CLIBMONIMNB(ref MHIICIMPJBH HAOHDNKGKPC, T MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x1792D60", Offset = "0x1791560", VA = "0x181792D60")]
	public HBNMNDDMGFP()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[CompilerGenerated]
	[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
	public class PhysicsSceneAddCollidersSystem : NHLEGKPBPCC, NOFCHOCEBPC
	{
		[Cpp2IlInjected.Token(Token = "0x20000CB")]
		private struct PhysicsSceneAddCollidersSystem_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400029A")]
			public PhysicsSceneAddCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400029B")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400029C")]
			[ReadOnly]
			public EntityTypeHandle __eTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000590")]
			[Cpp2IlInjected.Address(RVA = "0x2237C50", Offset = "0x2236450", VA = "0x182237C50")]
			private void BNHOJHOEIPF(Entity e)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000591")]
			[Cpp2IlInjected.Address(RVA = "0x2237D50", Offset = "0x2236550", VA = "0x182237D50", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private NDPGBPGKIMO ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private PCMJCEALPLG colliderService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private EntityQuery PhysicsSceneAddCollidersSystem_Query;

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x22C67F0", Offset = "0x22C4FF0", VA = "0x1822C67F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x22C64A0", Offset = "0x22C4CA0", VA = "0x1822C64A0", Slot = "14")]
		public void InitReferences(NCFCHDEHMHC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x22C6850", Offset = "0x22C5050", VA = "0x1822C6850", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x22C6500", Offset = "0x22C4D00", VA = "0x1822C6500")]
		private void LEOHJFNCHDL(ref EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x22C65F0", Offset = "0x22C4DF0", VA = "0x1822C65F0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
		public PhysicsSceneAddCollidersSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal class LPGPKABJKIJ : PEPJPPPDFOK
{
	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	protected override HPOKAOBOIJC KKFMLANCONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x893100", Offset = "0x891900", VA = "0x180893100", Slot = "17")]
		get
		{
			return default(HPOKAOBOIJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x2929780", Offset = "0x2927F80", VA = "0x182929780")]
	public LPGPKABJKIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class APPMJAOMPAE : NHLEGKPBPCC
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[BurstCompile]
	private struct KIGDGIEBFOG : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		[ReadOnly]
		public ComponentTypeHandle<BGNDJFIJAFN> FAFBJLBALOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public ComponentTypeHandle<OGGLOODKLFP> HGAOONNHNCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public ComponentTypeHandle<HBPOHKHILDB> CPMMBGIOPIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public ComponentTypeHandle<NPLLHNDBMGA> CCJMBHEDAJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public uint EOFDFPDHALO;

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x22323C0", Offset = "0x2230BC0", VA = "0x1822323C0", Slot = "4")]
		public void Execute(ArchetypeChunk OPMNIAACDHI, int AMOEKOMGDLG, int LAFKFNODOKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x2232330", Offset = "0x2230B30", VA = "0x182232330")]
		public bool BDINEGGJLMH(ArchetypeChunk OPMNIAACDHI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private EntityQuery MFHEANKMMCA;

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x2898EF0", Offset = "0x28976F0", VA = "0x182898EF0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x2899000", Offset = "0x2897800", VA = "0x182899000", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public APPMJAOMPAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
public sealed class HFEKIDIBHLI : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	private CPPOLCLDFAK OAFFOBLPFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	private OIKLJKNPPOI PMEOGKNMBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	private GHNAAIGKIGD PODDIAOEGNA;

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x24E5A40", Offset = "0x24E4240", VA = "0x1824E5A40", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x24E5AD0", Offset = "0x24E42D0", VA = "0x1824E5AD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public HFEKIDIBHLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public sealed class PBKACGCLFBM : GJJADNOGMIL
{
	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x22C00F0", Offset = "0x22BE8F0", VA = "0x1822C00F0", Slot = "15")]
	protected override ComponentSystemBase CMFPJFIFJLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x22BD2C0", Offset = "0x22BBAC0", VA = "0x1822BD2C0")]
	public PBKACGCLFBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[KHNAILLFHGJ(typeof(GOJLLBPKGIE), new string[] { })]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
internal class GOJLLBPKGIE : NOHOJBNCAJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	private DMOLMGFOOHL<NBHKLDPKGLO, JMCPPLBMCKC, ENMBJJNMEAE, OCNLGAFGIKO> FOBEFOPMLJP;

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x2C832B0", Offset = "0x2C81AB0", VA = "0x182C832B0", Slot = "4")]
	public void GGJEPBDNAAH(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public GOJLLBPKGIE()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[CompilerGenerated]
	public class PreSerializeTransformRoots : NHLEGKPBPCC
	{
		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		[NoAlias]
		[BurstCompile]
		private struct PreSerializeTransformRoots_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002AC")]
			public RigidTransform pose;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40002AD")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002AE")]
			public ComponentTypeHandle<PMHMNKDEJIA> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005A6")]
			[Cpp2IlInjected.Address(RVA = "0x601B9A0", Offset = "0x601A1A0", VA = "0x18601B9A0")]
			private void BNHOJHOEIPF([NoAlias] ref PMHMNKDEJIA data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A7")]
			[Cpp2IlInjected.Address(RVA = "0x601E130", Offset = "0x601C930", VA = "0x18601E130", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		[NoAlias]
		[BurstCompile]
		private struct PreSerializeTransformRoots_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002AF")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002B0")]
			public ComponentTypeHandle<MEJJCGNBFDD> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0x2226D70", Offset = "0x2225570", VA = "0x182226D70")]
			private void BNHOJHOEIPF([NoAlias] ref MEJJCGNBFDD data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0x601E200", Offset = "0x601CA00", VA = "0x18601E200", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private EntityQuery PreSerializeTransformRoots_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private EntityQuery PreSerializeTransformRoots_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private EntityQuery __query_2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private ComponentTypeHandle<PMHMNKDEJIA> __RecRoom_Components_LocalPoseData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private ComponentTypeHandle<MEJJCGNBFDD> __RecRoom_Components_LocalUniformScaleData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x22D0BE0", Offset = "0x22CF3E0", VA = "0x1822D0BE0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x22D0340", Offset = "0x22CEB40", VA = "0x1822D0340")]
		private void HFGGGIPOHLB(in JBNGNAKFECF transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x22D0560", Offset = "0x22CED60", VA = "0x1822D0560")]
		private JobHandle MLDCHIHOIBG(RigidTransform pose, float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x22D0230", Offset = "0x22CEA30", VA = "0x1822D0230")]
		private JobHandle GJFEJLDHFLM(float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x22D06A0", Offset = "0x22CEEA0", VA = "0x1822D06A0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
		public PreSerializeTransformRoots()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
internal sealed class LALMCAPLFEP : GJJADNOGMIL
{
	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x291EC00", Offset = "0x291D400", VA = "0x18291EC00", Slot = "15")]
	protected override ComponentSystemBase CMFPJFIFJLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x22BD2C0", Offset = "0x22BBAC0", VA = "0x1822BD2C0")]
	public LALMCAPLFEP()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	[AlwaysUpdateSystem]
	[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
	public class PhysicsSceneRemoveCollidersSystem : NHLEGKPBPCC, NOFCHOCEBPC
	{
		[Cpp2IlInjected.Token(Token = "0x20000D7")]
		private struct PhysicsSceneRemoveCollidersSystem_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B5")]
			public PhysicsSceneRemoveCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002B6")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002B7")]
			[ReadOnly]
			public EntityTypeHandle __eTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40002B8")]
			[ReadOnly]
			public ComponentTypeHandle<PPAFHFDMEAA> __chTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005B2")]
			[Cpp2IlInjected.Address(RVA = "0x2237E00", Offset = "0x2236600", VA = "0x182237E00")]
			private void BNHOJHOEIPF(Entity e, in PPAFHFDMEAA ch)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B3")]
			[Cpp2IlInjected.Address(RVA = "0x2237F00", Offset = "0x2236700", VA = "0x182237F00", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private NDPGBPGKIMO ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private PCMJCEALPLG colliderService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private EntityQuery PhysicsSceneRemoveCollidersSystem_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private ComponentTypeHandle<PPAFHFDMEAA> __RecRoom_ObjectModel_Systems_PhysicsSceneColliderHandleData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x22C6BF0", Offset = "0x22C53F0", VA = "0x1822C6BF0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x22C6950", Offset = "0x22C5150", VA = "0x1822C6950", Slot = "14")]
		public void InitReferences(NCFCHDEHMHC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x22C6C50", Offset = "0x22C5450", VA = "0x1822C6C50", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x22C6DB0", Offset = "0x22C55B0", VA = "0x1822C6DB0")]
		private void POPOLBFDNJL(ref EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x22C69B0", Offset = "0x22C51B0", VA = "0x1822C69B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
		public PhysicsSceneRemoveCollidersSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public class HGHEBLMMPBI : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[BurstCompile]
	private struct DNKECHMLKAJ : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		[ReadOnly]
		public NativeArray<GMOILJEEEBN> ANBFECHNHBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		[ReadOnly]
		public NativeArray<Entity> KFLBCCAJFMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public ComponentDataFromEntity FCGONADCKDL;

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x222BBC0", Offset = "0x222A3C0", VA = "0x18222BBC0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[BurstCompile]
	private struct OEGPNONBPJJ : IJob, INativeDisposable, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		[ReadOnly]
		public NativeParallelHashMap<int, Entity> KHOAABHPPKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		[ReadOnly]
		public NativeParallelHashMap<int, EntityArchetype> ONFDMIIEPBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		[ReadOnly]
		public NativeParallelHashMap<int, int> JKGIAALGDJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		[ReadOnly]
		public NativeArray<ArchetypeChunk> IANHEBIGNNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		[ReadOnly]
		public SharedComponentTypeHandle<RRObjectPrefabV2Data> JCLJHMININN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public NativeList<EntityArchetype> FFGAMIBGJJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public NativeList<EntityArchetype> JNNDANNPHBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public NativeList<BECDCKEMJCA> LLEFNJMPEML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public NativeList<BECDCKEMJCA> LGCLDEMKAPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public NativeList<GMOILJEEEBN> ANEILNIMBIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public NativeList<ComponentType> KIKBKFAAADF;

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x2236950", Offset = "0x2235150", VA = "0x182236950", Slot = "6")]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x2235F90", Offset = "0x2234790", VA = "0x182235F90", Slot = "5")]
		public JobHandle Dispose(JobHandle BJJHADPHPJP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x2236190", Offset = "0x2234990", VA = "0x182236190", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x22366B0", Offset = "0x2234EB0", VA = "0x1822366B0")]
		private int IMIKDPLJALA(BECDCKEMJCA HLFDEADFDGA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x2236750", Offset = "0x2234F50", VA = "0x182236750")]
		private bool MDHPPANMAHG(int PGJDPJDFENI, EntityArchetype HKIEFOLBOIC, out EntityArchetype CCPKHOFAPFG, out Entity PLBLIMPHOBO)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[BurstCompile]
	private struct ODAKAONPFJP : IComparer<GMOILJEEEBN>
	{
		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x2235F70", Offset = "0x2234770", VA = "0x182235F70", Slot = "4")]
		public int Compare(GMOILJEEEBN FBGKLELIKCG, GMOILJEEEBN LFJEFFKGLOE)
		{
			return default(int);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[BurstCompile]
	private struct HBHILDHPNPK : DBJBEBMCMPD<GMOILJEEEBN, int>
	{
		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x195F270", Offset = "0x195DA70", VA = "0x18195F270")]
		public int PBIFCHCLFAG(in GMOILJEEEBN EMGBKAPJLEO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x195F270", Offset = "0x195DA70", VA = "0x18195F270", Slot = "4")]
		private int AHDMLKCPNED(in GMOILJEEEBN MENBIMCLIOI)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	private struct GMOILJEEEBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public Entity PLBLIMPHOBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public BECDCKEMJCA KFLBCCAJFMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public int GBBOLEFNLEO;
	}

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private EntityQuery EGFJCKOAGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private IDDDKKBGJPP CBGOOONHBMI;

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x24E67E0", Offset = "0x24E4FE0", VA = "0x1824E67E0", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x24E6A00", Offset = "0x24E5200", VA = "0x1824E6A00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x24E6AB0", Offset = "0x24E52B0", VA = "0x1824E6AB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0x24E6530", Offset = "0x24E4D30", VA = "0x1824E6530")]
	private OEGPNONBPJJ IIKNJKMHEBF(NativeArray<ArchetypeChunk> NAJMIDDONAG)
	{
		return default(OEGPNONBPJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(RVA = "0x24E63D0", Offset = "0x24E4BD0", VA = "0x1824E63D0")]
	private void HMGKOPAPMEB(NativeArray<EntityArchetype> JNNDANNPHBD, NativeArray<BECDCKEMJCA> LLEFNJMPEML, NativeArray<BECDCKEMJCA> LGCLDEMKAPD, NativeArray<ComponentType> KIKBKFAAADF, NativeArray<ArchetypeChunk> NAJMIDDONAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x24E6190", Offset = "0x24E4990", VA = "0x1824E6190")]
	private EntityArchetype GBBEOGKFIBE(EntityArchetype POKKLMJHEEL, NativeArray<ComponentType> KIKBKFAAADF, BECDCKEMJCA CJCFMILPBKA)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x24E5BD0", Offset = "0x24E43D0", VA = "0x1824E5BD0")]
	private JobHandle ENOCDGNMNBA(NativeList<GMOILJEEEBN> ANBFECHNHBJ, NativeArray<Entity> KFLBCCAJFMN, JobHandle BFAAEILACKK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x24E6830", Offset = "0x24E5030", VA = "0x1824E6830")]
	private JobHandle NIENANLJLNG(NativeArray<Entity> KFLBCCAJFMN, NativeArray<GMOILJEEEBN> ANBFECHNHBJ, int KFGBCCEFCMB, BECDCKEMJCA CJCFMILPBKA, JobHandle BFAAEILACKK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x24E6180", Offset = "0x24E4980", VA = "0x1824E6180")]
	public static bool EPAIKMDFJEO(ComponentType JHKLCDEPMAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public HGHEBLMMPBI()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[CompilerGenerated]
	public class PostDeserializeTransformRoots : NHLEGKPBPCC
	{
		[Cpp2IlInjected.Token(Token = "0x20000DF")]
		[NoAlias]
		[BurstCompile]
		private struct PostDeserializeTransformRoots_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002D8")]
			public RigidTransform pose;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40002D9")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002DA")]
			public ComponentTypeHandle<PMHMNKDEJIA> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x2226C90", Offset = "0x2225490", VA = "0x182226C90")]
			private void BNHOJHOEIPF([NoAlias] ref PMHMNKDEJIA data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0x22384D0", Offset = "0x2236CD0", VA = "0x1822384D0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E0")]
		[BurstCompile]
		[NoAlias]
		private struct PostDeserializeTransformRoots_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002DB")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			public ComponentTypeHandle<MEJJCGNBFDD> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0x2226D70", Offset = "0x2225570", VA = "0x182226D70")]
			private void BNHOJHOEIPF([NoAlias] ref MEJJCGNBFDD data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0x22385A0", Offset = "0x2236DA0", VA = "0x1822385A0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		[NoAlias]
		[BurstCompile]
		private struct PostDeserializeTransformRoots_LambdaJob_2_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			public ComponentTypeHandle<BLOFFPDIILE> __authoredPoseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40002DE")]
			[ReadOnly]
			public ComponentTypeHandle<PMHMNKDEJIA> __poseTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005D5")]
			[Cpp2IlInjected.Address(RVA = "0x2226D80", Offset = "0x2225580", VA = "0x182226D80")]
			private void BNHOJHOEIPF([NoAlias] ref BLOFFPDIILE authoredPose, [NoAlias] in PMHMNKDEJIA pose)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D6")]
			[Cpp2IlInjected.Address(RVA = "0x2238670", Offset = "0x2236E70", VA = "0x182238670", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[NoAlias]
		[BurstCompile]
		private struct PostDeserializeTransformRoots_LambdaJob_3_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002DF")]
			public ComponentTypeHandle<DGPOBCIGCLL> __authoredScaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40002E0")]
			[ReadOnly]
			public ComponentTypeHandle<MEJJCGNBFDD> __scaleTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005D7")]
			[Cpp2IlInjected.Address(RVA = "0x2226DA0", Offset = "0x22255A0", VA = "0x182226DA0")]
			private void BNHOJHOEIPF([NoAlias] ref DGPOBCIGCLL authoredScale, [NoAlias] in MEJJCGNBFDD scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D8")]
			[Cpp2IlInjected.Address(RVA = "0x22387C0", Offset = "0x2236FC0", VA = "0x1822387C0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private EntityQuery PostDeserializeTransformRoots_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private EntityQuery PostDeserializeTransformRoots_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private EntityQuery PostDeserializeTransformRoots_LambdaJob_2_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private EntityQuery PostDeserializeTransformRoots_LambdaJob_3_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private EntityQuery __query_4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private ComponentTypeHandle<PMHMNKDEJIA> __RecRoom_Components_LocalPoseData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private ComponentTypeHandle<MEJJCGNBFDD> __RecRoom_Components_LocalUniformScaleData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private ComponentTypeHandle<BLOFFPDIILE> __RecRoom_Components_AuthoredLocalPoseData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private ComponentTypeHandle<PMHMNKDEJIA> __RecRoom_Components_LocalPoseData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private ComponentTypeHandle<DGPOBCIGCLL> __RecRoom_Components_AuthoredLocalUniformScaleData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private ComponentTypeHandle<MEJJCGNBFDD> __RecRoom_Components_LocalUniformScaleData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x22C9640", Offset = "0x22C7E40", VA = "0x1822C9640", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x22C85B0", Offset = "0x22C6DB0", VA = "0x1822C85B0")]
		private void HFGGGIPOHLB(in JBNGNAKFECF transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x22C87E0", Offset = "0x22C6FE0", VA = "0x1822C87E0")]
		private void KDECMIDNBAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x22C8A30", Offset = "0x22C7230", VA = "0x1822C8A30")]
		private JobHandle KIECLKCLJAG(RigidTransform pose, float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x22C9B20", Offset = "0x22C8320", VA = "0x1822C9B20")]
		private JobHandle PHGMNCBNPCL(float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x22C8B70", Offset = "0x22C7370", VA = "0x1822C8B70")]
		private JobHandle MKECFJMGGCO(JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x22C8450", Offset = "0x22C6C50", VA = "0x1822C8450")]
		private JobHandle GPBPOMODJHE(JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x22C8CD0", Offset = "0x22C74D0", VA = "0x1822C8CD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
		public PostDeserializeTransformRoots()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E4")]
internal struct IHAFMOHIKDB : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[CompilerGenerated]
	[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
	internal class SplinePointParentChangedSystem : NHLEGKPBPCC, NOFCHOCEBPC
	{
		[Cpp2IlInjected.Token(Token = "0x20000E6")]
		[BurstCompile]
		[NoAlias]
		private struct SplinePointParentChangedSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002E9")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002EA")]
			public DynamicBuffer<global::HJKAJAPIIMN> splineIndexUpdatesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002EB")]
			[ReadOnly]
			public EntityTypeHandle __splinePointTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40002EC")]
			[ReadOnly]
			public ComponentTypeHandle<NLLEHLHFEHG> __splinePointParentDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005E5")]
			[Cpp2IlInjected.Address(RVA = "0x60217C0", Offset = "0x601FFC0", VA = "0x1860217C0")]
			private void BNHOJHOEIPF(Entity splinePoint, [NoAlias] in NLLEHLHFEHG splinePointParentData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E6")]
			[Cpp2IlInjected.Address(RVA = "0x60218D0", Offset = "0x60200D0", VA = "0x1860218D0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[NoAlias]
		[BurstCompile]
		private struct SplinePointParentChangedSystem_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002ED")]
			public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			[ReadOnly]
			public EntityTypeHandle __splinePointTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			[ReadOnly]
			public ComponentTypeHandle<global::JPEMLHJAMKJ> __splinePointParentSystemDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005E7")]
			[Cpp2IlInjected.Address(RVA = "0x60219F0", Offset = "0x60201F0", VA = "0x1860219F0")]
			private void BNHOJHOEIPF(Entity splinePoint, [NoAlias] in global::JPEMLHJAMKJ splinePointParentSystemData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E8")]
			[Cpp2IlInjected.Address(RVA = "0x6021B20", Offset = "0x6020320", VA = "0x186021B20", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private EntityQuery needsAdd;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private EntityQuery needsRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		[NAAJCOHOAKA]
		private OABNFEOAMFN singletonService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private EntityQuery SplinePointParentChangedSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private EntityQuery SplinePointParentChangedSystem_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private ComponentTypeHandle<NLLEHLHFEHG> __RecRoom_Components_SplinePointParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private ComponentTypeHandle<global::JPEMLHJAMKJ> __RecRoom_Components_SplinePointParentSystemData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x22D30E0", Offset = "0x22D18E0", VA = "0x1822D30E0", Slot = "14")]
		public void InitReferences(NCFCHDEHMHC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x22D3790", Offset = "0x22D1F90", VA = "0x1822D3790", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x22D3780", Offset = "0x22D1F80", VA = "0x1822D3780", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x22D3130", Offset = "0x22D1930", VA = "0x1822D3130")]
		private void KILLFNDHMAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x22D2B40", Offset = "0x22D1340", VA = "0x1822D2B40")]
		private void DBHMENLKPJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x22D2DE0", Offset = "0x22D15E0", VA = "0x1822D2DE0")]
		private EntityCommandBufferSystem EFIPACDBNFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x22D2E30", Offset = "0x22D1630", VA = "0x1822D2E30")]
		private JobHandle FDOPKMNBFPK(EntityCommandBuffer ecb, DynamicBuffer<global::HJKAJAPIIMN> splineIndexUpdatesRO, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x22D2F90", Offset = "0x22D1790", VA = "0x1822D2F90")]
		private JobHandle FLHIFDFMAOP(BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x22D3380", Offset = "0x22D1B80", VA = "0x1822D3380", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
		public SplinePointParentChangedSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
	public class UpdateInertialProperties : NHLEGKPBPCC, NOFCHOCEBPC
	{
		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		[NoAlias]
		[BurstCompile]
		private struct UpdateInertialProperties_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.Token(Token = "0x20000EA")]
			public delegate void RunWithoutJobSystem_00000761$PostfixBurstDelegate(IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x20000EB")]
			internal static class RunWithoutJobSystem_00000761$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x4000305")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x4000306")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x60005FB")]
				[Cpp2IlInjected.Address(RVA = "0x601F890", Offset = "0x601E090", VA = "0x18601F890")]
				[BurstDiscard]
				private static void POFINAJNFAL(ref IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005FC")]
				[Cpp2IlInjected.Address(RVA = "0x601F420", Offset = "0x601DC20", VA = "0x18601F420")]
				private static IntPtr GFGFNEBPFAM()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x60005FD")]
				[Cpp2IlInjected.Address(RVA = "0x601F7D0", Offset = "0x601DFD0", VA = "0x18601F7D0")]
				public static void MKAFKJABJJI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005FE")]
				[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
				public static void BDCEDMLOOPD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000600")]
				[Cpp2IlInjected.Address(RVA = "0x601F5B0", Offset = "0x601DDB0", VA = "0x18601F5B0")]
				public static void MADELAMLLLM(IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40002F7")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x40002F8")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002F9")]
			public EntityQueryInJob isTaggedForUpdate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002FA")]
			public EntityQueryInJob rootRbexChangedQuery;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002FB")]
			public EntityQueryInJob deformationScaleChangedQuery;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002FC")]
			public EntityQueryInJob generalRbexChangedQuery;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002FD")]
			public ChunkFilterAnyOf5ComponentsChanged changeFilter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40002FE")]
			public int maxEntityCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40002FF")]
			public NativeList<Entity> changedRoots;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000300")]
			[ReadOnly]
			public EntityExistenceLookupByEntity entityExists;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			[ReadOnly]
			public EntityTypeHandle entityTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
			[Cpp2IlInjected.Token(Token = "0x4000302")]
			[ReadOnly]
			public ComponentTypeHandle<ILPFBDBNCND> rbexRootTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000303")]
			[ReadOnly]
			public ComponentDataFromEntity<NCEDEMJMPKG> rbexIsKinematicRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000304")]
			public Allocator allocator;

			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0x6021E10", Offset = "0x6020610", VA = "0x186021E10")]
			private void BNHOJHOEIPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F4")]
			[Cpp2IlInjected.Address(RVA = "0x6022430", Offset = "0x6020C30", VA = "0x186022430", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0x6021DB0", Offset = "0x60205B0", VA = "0x186021DB0")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void AABEEOLFMKP(IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0x6022440", Offset = "0x6020C40", VA = "0x186022440")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void NDHFIMMDDCJ(IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private EntityQuery isTaggedForUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private EntityQuery generalRbexChangedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private EntityQuery rootRbexChangedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private EntityQuery deformationScaleChangedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private EntityQuery removeMassOfHierarchyQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private OBIIMMCNMNC rbexServiceCallbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private HMBELPNBOEG objects;

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x22D8D60", Offset = "0x22D7560", VA = "0x1822D8D60", Slot = "14")]
		public void InitReferences(NCFCHDEHMHC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x22D92A0", Offset = "0x22D7AA0", VA = "0x1822D92A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x22D9610", Offset = "0x22D7E10", VA = "0x1822D9610", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x22D8DD0", Offset = "0x22D75D0", VA = "0x1822D8DD0")]
		protected void JKAIIPECNDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x22D9160", Offset = "0x22D7960", VA = "0x1822D9160")]
		protected void KONKNINHKGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x22D8950", Offset = "0x22D7150", VA = "0x1822D8950")]
		private bool FAIIOPDNDLE(EntityQueryInJob isTaggedForUpdate, EntityQueryInJob rootRbexChangedQuery, EntityQueryInJob deformationScaleChangedQuery, EntityQueryInJob generalRbexChangedQuery, out NativeList<Entity> results)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x22D9690", Offset = "0x22D7E90", VA = "0x1822D9690")]
		private void PPONGIGCPHF(ref EntityQueryInJob isTaggedForUpdate, ref EntityQueryInJob rootRbexChangedQuery, ref EntityQueryInJob deformationScaleChangedQuery, ref EntityQueryInJob generalRbexChangedQuery, ref ChunkFilterAnyOf5ComponentsChanged changeFilter, ref int maxEntityCount, ref NativeList<Entity> changedRoots, ref EntityExistenceLookupByEntity entityExists, ref EntityTypeHandle entityTypeRO, ref ComponentTypeHandle<ILPFBDBNCND> rbexRootTypeRO, ref ComponentDataFromEntity<NCEDEMJMPKG> rbexIsKinematicRO, ref Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x22D91E0", Offset = "0x22D79E0", VA = "0x1822D91E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
		public UpdateInertialProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x22D9110", Offset = "0x22D7910", VA = "0x1822D9110")]
		public static void KANJPHHCGDB()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
[DefaultMember("Item")]
public readonly struct GGOBGEMCPKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	private readonly int KFGBCCEFCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	private readonly int ILIJGNGONLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	private readonly NativeArray<BECDCKEMJCA>.ReadOnly LAEPKFGACAO;

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public int EGAMNLBINDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x2C7CD50", Offset = "0x2C7B550", VA = "0x182C7CD50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public PJEPFNNEOOJ ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x2C7CCB0", Offset = "0x2C7B4B0", VA = "0x182C7CCB0")]
		get
		{
			return default(PJEPFNNEOOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public int DKPJIBEOHBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x1AB09C0", Offset = "0x1AAF1C0", VA = "0x181AB09C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public NativeArray<BECDCKEMJCA>.ReadOnly FDEABJOMLDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x1AB0880", Offset = "0x1AAF080", VA = "0x181AB0880")]
		get
		{
			return default(NativeArray<BECDCKEMJCA>.ReadOnly);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x2C7CDA0", Offset = "0x2C7B5A0", VA = "0x182C7CDA0")]
	public GGOBGEMCPKI(int KFGBCCEFCMB, int ILIJGNGONLE, NativeArray<BECDCKEMJCA>.ReadOnly LAEPKFGACAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
internal class LNHGOCKKIOG : FFGKGHJCIFC
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	protected override DGHCNLKFLNE JAJKCIDCJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x2927330", Offset = "0x2925B30", VA = "0x182927330", Slot = "15")]
		get
		{
			return default(DGHCNLKFLNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x289A800", Offset = "0x2899000", VA = "0x18289A800")]
	public LNHGOCKKIOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
public class CKDFFNGGDNJ : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	private struct GPNAJJPAJHA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public AOOPHAOFFDG MFHEANKMMCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public NativeParallelHashSet<Entity> KFLBCCAJFMN;

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x222EA00", Offset = "0x222D200", VA = "0x18222EA00")]
		public GPNAJJPAJHA(int LNKEFEELODK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x222E980", Offset = "0x222D180", VA = "0x18222E980", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[BurstCompile]
	private struct CHJAHAOIGOB : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		[ReadOnly]
		public NativeArray<Entity> KFLBCCAJFMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		[ReadOnly]
		public ComponentDataFromEntity<OGGLOODKLFP> OPBCHFDOPDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		[ReadOnly]
		public ComponentDataFromEntity<NPLLHNDBMGA> LOCCIHEFFDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		[ReadOnly]
		public ComponentDataFromEntity<HBPOHKHILDB> HJLIACNPPMH;

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x2228990", Offset = "0x2227190", VA = "0x182228990", Slot = "4")]
		public void Execute(int AMOEKOMGDLG, TransformAccess LAMNAOAMKPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[BurstCompile]
	private struct LLPAHJMKGNA : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		[ReadOnly]
		public NativeArray<Entity> KFLBCCAJFMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		[ReadOnly]
		public ComponentDataFromEntity<OGGLOODKLFP> OPBCHFDOPDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		[ReadOnly]
		public ComponentDataFromEntity<HBPOHKHILDB> HJLIACNPPMH;

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x22331A0", Offset = "0x22319A0", VA = "0x1822331A0", Slot = "4")]
		public void Execute(int AMOEKOMGDLG, TransformAccess LAMNAOAMKPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030B")]
	private PCMJCEALPLG MJMFLCKALLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400030C")]
	private EntityQuery DGOBMGHLPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	private EntityQuery IABGEKPFFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private EntityQuery JPDMHFCIHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private EntityQuery PJALPADENID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	private EntityQuery MDCDKPJGIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	private JobHandle LLJJGGFICJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	private GPNAJJPAJHA DAFCONADDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000313")]
	private GPNAJJPAJHA BMDCHBPIBFE;

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x28A5CD0", Offset = "0x28A44D0", VA = "0x1828A5CD0", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x28A65D0", Offset = "0x28A4DD0", VA = "0x1828A65D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0x28A5B30", Offset = "0x28A4330", VA = "0x1828A5B30", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x28A6880", Offset = "0x28A5080", VA = "0x1828A6880", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x28A61F0", Offset = "0x28A49F0", VA = "0x1828A61F0")]
	private void JPKGPFMCBJM(EntityQuery EGFJCKOAGFH, out (NativeArrayAsync<PPAFHFDMEAA> handles, NativeArrayAsync<NHHNAEGJEIL> bounds) NFBDMLCENEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x28A5D30", Offset = "0x28A4530", VA = "0x1828A5D30")]
	private void JFKOIKMHIKH((NativeArrayAsync<PPAFHFDMEAA> handles, NativeArrayAsync<NHHNAEGJEIL> bounds) NFBDMLCENEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x28A5B30", Offset = "0x28A4330", VA = "0x1828A5B30")]
	private void BLBKEJFDCFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x28A6330", Offset = "0x28A4B30", VA = "0x1828A6330")]
	private void LJMOJIHHJAI(EntityQuery EGFJCKOAGFH, out (NativeArrayAsync<Entity> entities, NativeArrayAsync<PPAFHFDMEAA> handles) NFBDMLCENEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x28A5F50", Offset = "0x28A4750", VA = "0x1828A5F50")]
	private void JNFHEIPBJOB((NativeArrayAsync<Entity> entities, NativeArrayAsync<PPAFHFDMEAA> handles) NFBDMLCENEN, GPNAJJPAJHA OJICEFMMHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x28A5B70", Offset = "0x28A4370", VA = "0x1828A5B70")]
	private JobHandle DCGOJMAAOIF(GPNAJJPAJHA OJICEFMMHOH, ComponentDataFromEntity<OGGLOODKLFP> OPBCHFDOPDB, ComponentDataFromEntity<HBPOHKHILDB> HJLIACNPPMH, ComponentDataFromEntity<NPLLHNDBMGA> LOCCIHEFFDD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x28A6470", Offset = "0x28A4C70", VA = "0x1828A6470")]
	private JobHandle ODLICKFNJDH(GPNAJJPAJHA OJICEFMMHOH, ComponentDataFromEntity<OGGLOODKLFP> OPBCHFDOPDB, ComponentDataFromEntity<HBPOHKHILDB> HJLIACNPPMH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public CKDFFNGGDNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
[LJMILPFECGO]
public class BNCDFKNBGDH : NHLEGKPBPCC, CICEKNFDMIA.LCADOJGBOPP
{
	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x289F4C0", Offset = "0x289DCC0", VA = "0x18289F4C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x289F470", Offset = "0x289DC70", VA = "0x18289F470")]
	private EntityCommandBufferSystem EFIPACDBNFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public BNCDFKNBGDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
[ANLOEBHPLMF(typeof(JDLNPAGPGDM))]
[KHNAILLFHGJ(typeof(GOMGMPAPJHK), new string[] { })]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
internal class GOMGMPAPJHK : NOFCHOCEBPC, JDLNPAGPGDM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400031F")]
	[NAAJCOHOAKA]
	private NMKNMBOOICD GDBIIJIAFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000320")]
	private AJCPLKBBBGL IBDKPPIFFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000321")]
	private NativeList<byte> NFBDMLCENEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000322")]
	private NativeList<ADKFIICEFJC> AKIPAJCIELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	private NativeList<BECDCKEMJCA> LFOLNJECFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	private int GIFCOANBAOJ;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<ADKFIICEFJC, NativeArray<byte>> JOEEHNHNNDG
	{
		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x2C83380", Offset = "0x2C81B80", VA = "0x182C83380")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x2C83520", Offset = "0x2C81D20", VA = "0x182C83520")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x2C83770", Offset = "0x2C81F70", VA = "0x182C83770", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x2C83420", Offset = "0x2C81C20", VA = "0x182C83420", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x2C835C0", Offset = "0x2C81DC0", VA = "0x182C835C0", Slot = "5")]
	public void IAKGAPOOEEK(ADKFIICEFJC ODHKMJMLAIP, ReadOnlySpan<byte> BKHMACKFNNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x2C834A0", Offset = "0x2C81CA0", VA = "0x182C834A0")]
	public void EEMEPIGIECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x2C83930", Offset = "0x2C82130", VA = "0x182C83930")]
	public GOMGMPAPJHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public class LJMILPFECGO : EFDDNEKNAJL
{
	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x97A870", Offset = "0x979070", VA = "0x18097A870")]
	public LJMILPFECGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
public class OFGCJNJEGGG : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[BurstCompile]
	private struct GPNJOBLDOKH : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		[ReadOnly]
		public NativeArray<Entity> KFLBCCAJFMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<PMHMNKDEJIA> JOGAOKKMAID;

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x222EAA0", Offset = "0x222D2A0", VA = "0x18222EAA0", Slot = "4")]
		public void Execute(int AMOEKOMGDLG, TransformAccess LAMNAOAMKPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x222EC70", Offset = "0x222D470", VA = "0x18222EC70")]
		private bool FMICKJPAHEJ(float3 MAIOOLBIJID, float3 MMOFNBHFDNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x222ECA0", Offset = "0x222D4A0", VA = "0x18222ECA0")]
		private bool LMMGCKJIKDP(quaternion MAIOOLBIJID, quaternion MMOFNBHFDNB)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[BurstCompile]
	private struct HDMOCCBBFDB : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		[ReadOnly]
		public NativeArray<Entity> KFLBCCAJFMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<MEJJCGNBFDD> KDNCCNIJIFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<DIABMIKHCMI> CFECNPKABOP;

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x222F2B0", Offset = "0x222DAB0", VA = "0x18222F2B0", Slot = "4")]
		public void Execute(int AMOEKOMGDLG, TransformAccess LAMNAOAMKPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	private static readonly JNGNMMOLKFF CCPALLAFONN;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private static readonly JNGNMMOLKFF DCDCHPEPNOG;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private static readonly JNGNMMOLKFF IGJNDMKIKKM;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	private static readonly ProfilerMarker PDBGFGBBKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	private JNIBHBOFDMB ILMCONKNODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	private ILBBGIPPPPJ KFELNFLBJDM;

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x293BC20", Offset = "0x293A420", VA = "0x18293BC20", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x293BC90", Offset = "0x293A490", VA = "0x18293BC90", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x293BCD0", Offset = "0x293A4D0", VA = "0x18293BCD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public OFGCJNJEGGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public sealed class FLHNHBFCKOC : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private EntityQuery EGFJCKOAGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private HMBELPNBOEG LNJHNPCFKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private AEDKFOCGAIL AAOAOHHKNIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private JKPMGMPNGAH MIIJDOIOOOJ;

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x2C7AD50", Offset = "0x2C79550", VA = "0x182C7AD50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x2C7ACC0", Offset = "0x2C794C0", VA = "0x182C7ACC0", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x2C7AE50", Offset = "0x2C79650", VA = "0x182C7AE50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public FLHNHBFCKOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
[GCAKKMGPAEI]
internal abstract class GDNJPKKODAP : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	protected HMBELPNBOEG LNJHNPCFKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	protected HCOBHGJLPEC KLEOGNMJFCE;

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	protected abstract DGHCNLKFLNE JAJKCIDCJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x2C7C590", Offset = "0x2C7AD90", VA = "0x182C7C590", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x2C7C0F0", Offset = "0x2C7A8F0", VA = "0x182C7C0F0")]
	protected void CGCLIIIINCP(EntityQuery EGFJCKOAGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x2C7C340", Offset = "0x2C7AB40", VA = "0x182C7C340")]
	protected void FPCPBGGLHCC(EntityQuery EGFJCKOAGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x2C7C600", Offset = "0x2C7AE00", VA = "0x182C7C600")]
	protected MDHHOEPMEJH KADKOJPBIBK(EntityQuery EGFJCKOAGFH)
	{
		return default(MDHHOEPMEJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	protected GDNJPKKODAP()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000FA")]
internal struct IMIFKNIDMII : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public struct AOOPHAOFFDG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private NativeList<Entity> KFLBCCAJFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private TransformAccessArray MFHEANKMMCA;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public int GKGAEPJBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x2898DA0", Offset = "0x28975A0", VA = "0x182898DA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public NativeList<Entity> LEHLEJFFNOO
	{
		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x13203E0", Offset = "0x131EBE0", VA = "0x1813203E0")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public TransformAccessArray BNJJPKCJGCK
	{
		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public bool GKHBBLGCCAM
	{
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x2898DB0", Offset = "0x28975B0", VA = "0x182898DB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x2898E60", Offset = "0x2897660", VA = "0x182898E60")]
	public AOOPHAOFFDG(int LNKEFEELODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x2898C90", Offset = "0x2897490", VA = "0x182898C90")]
	public Entity FEPIBNIBEDC(int AMOEKOMGDLG)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x2898DD0", Offset = "0x28975D0", VA = "0x182898DD0")]
	public void MFEONDMFONB(int LNKEFEELODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x2898CE0", Offset = "0x28974E0", VA = "0x182898CE0")]
	public int GLILACFFLBJ(Transform LAMNAOAMKPM, Entity AJDEFAPHMKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x2898B90", Offset = "0x2897390", VA = "0x182898B90")]
	public int BMEFMAKFKOC(int AMOEKOMGDLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x2898C10", Offset = "0x2897410", VA = "0x182898C10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(RVA = "0x2898E20", Offset = "0x2897620", VA = "0x182898E20")]
	private void MGJGJKGHPJK(int INKFNFIKAMP = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public class PDCLCCEDBGH : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	private EntityQuery EGFJCKOAGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	private IBFEILDIMEI BOBHLPNKBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400033E")]
	private HMBELPNBOEG LNJHNPCFKIL;

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0x22C02E0", Offset = "0x22BEAE0", VA = "0x1822C02E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x22C0270", Offset = "0x22BEA70", VA = "0x1822C0270", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x22C03B0", Offset = "0x22BEBB0", VA = "0x1822C03B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public PDCLCCEDBGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
[KHNAILLFHGJ(typeof(PCMJCEALPLG), new string[] { })]
public sealed class PBIFPBDGMFK : PCMJCEALPLG, HEJFCJDGGFG, PCAPGPPECJN, NOFCHOCEBPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000340")]
	[NAAJCOHOAKA]
	private NBKDCPLNNHB NDJHELJNLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	private Collider[] JDBFICDFIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	private RaycastHit[] IAJDJEEEMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	private MHOFOLMCDLI<ADLDIGGBGPP, BoxCollider> LHFIBODJHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	private Scene JJIAFDKCLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	private PhysicsScene HEFMMIGFCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	private GameObject ALNJPMNLFGF;

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x22BFE80", Offset = "0x22BE680", VA = "0x1822BFE80", Slot = "9")]
	public void PAHLDMJMCEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x22BF9C0", Offset = "0x22BE1C0", VA = "0x1822BF9C0", Slot = "10")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x22BF420", Offset = "0x22BDC20", VA = "0x1822BF420", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x22BF870", Offset = "0x22BE070", VA = "0x1822BF870", Slot = "4")]
	public ADLDIGGBGPP IJJGMIPANCG(Entity AJDEFAPHMKF)
	{
		return default(ADLDIGGBGPP);
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x22BF0F0", Offset = "0x22BD8F0", VA = "0x1822BF0F0", Slot = "5")]
	public void DEDIDDMDOOG(NativeArray<ADLDIGGBGPP> HDLMIMGKPDN, NativeArray<NHHNAEGJEIL> LMFHKKKEDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x22BED60", Offset = "0x22BD560", VA = "0x1822BED60", Slot = "6")]
	public void AHPDLEMLLNE(ADLDIGGBGPP BJJHADPHPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x22BFA80", Offset = "0x22BE280", VA = "0x1822BFA80", Slot = "7")]
	public bool KLOOEHPPIMP(ADLDIGGBGPP BJJHADPHPJP, out Collider PINIOELHAHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x22BF570", Offset = "0x22BDD70", VA = "0x1822BF570")]
	public bool EGANDJJHEIC(in float3 HPBBFNNBAFE, in float3 JJEDPBPHNPK, float BJICICOAOBE, Allocator HMGEFCKKBID, out NativeArray<Entity> KFLBCCAJFMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x22BF520", Offset = "0x22BDD20", VA = "0x1822BF520")]
	private void EBIPMOOIEPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x1193C50", Offset = "0x1192450", VA = "0x181193C50")]
	private void INACKBMHMEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x22BF0A0", Offset = "0x22BD8A0", VA = "0x1822BF0A0")]
	private void CJMJJCJOOJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x1A28720", Offset = "0x1A26F20", VA = "0x181A28720")]
	private void ANNGCJELILJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x22BF300", Offset = "0x22BDB00", VA = "0x1822BF300")]
	private BoxCollider DLMHMBPFAPC(Entity AJDEFAPHMKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x22BF020", Offset = "0x22BD820", VA = "0x1822BF020")]
	private void CHABMJLJEHF(BoxCollider BMCNBDFOIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x22BEE30", Offset = "0x22BD630", VA = "0x1822BEE30")]
	private void AOFFLNEDCJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x22BFB30", Offset = "0x22BE330", VA = "0x1822BFB30")]
	private void NFIMCJKCFBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x22BFC50", Offset = "0x22BE450", VA = "0x1822BFC50")]
	private void OJABJAJIHKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x22C0030", Offset = "0x22BE830", VA = "0x1822C0030")]
	private void PIEBJHPIDAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x22BFB10", Offset = "0x22BE310", VA = "0x1822BFB10")]
	private void LBDCOAFIKMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x22BFFF0", Offset = "0x22BE7F0", VA = "0x1822BFFF0")]
	private void PBCJGJAEPDN(Scene FDDDLLOCCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public PBIFPBDGMFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x22BFB20", Offset = "0x22BE320", VA = "0x1822BFB20", Slot = "8")]
	private bool MBOCEGJDCKP(in float3 HPBBFNNBAFE, in float3 JJEDPBPHNPK, float BJICICOAOBE, Allocator HMGEFCKKBID, out NativeArray<Entity> KFLBCCAJFMN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public readonly struct DGHCNLKFLNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public readonly ComponentType? ONMPBNNEPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public readonly ComponentType? CONIMDCDDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public readonly ComponentType GABNJOAMKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public readonly object AMCDGOPKAOE;

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x2C69970", Offset = "0x2C68170", VA = "0x182C69970")]
	public DGHCNLKFLNE(ComponentType? ONMPBNNEPGP, ComponentType? CONIMDCDDMI, ComponentType GABNJOAMKPH, object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x3BE25A0", Offset = "0x3BE0DA0", VA = "0x183BE25A0")]
	public static DGHCNLKFLNE GNIKMMGCMLE<TReq, TTag>(object AMCDGOPKAOE)
	{
		return default(DGHCNLKFLNE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x3BE2870", Offset = "0x3BE1070", VA = "0x183BE2870")]
	public static DGHCNLKFLNE NNJFNDMBJBO<TReq, TMissing, TTag>(object AMCDGOPKAOE)
	{
		return default(DGHCNLKFLNE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
internal class IKLANBLPKAH : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private MKFKBEBMKHL NBFLEJAKAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private OIKLJKNPPOI MFGFOJJEBIO;

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x24F0B90", Offset = "0x24EF390", VA = "0x1824F0B90", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x24F0C00", Offset = "0x24EF400", VA = "0x1824F0C00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public IKLANBLPKAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
[KHNAILLFHGJ(typeof(CHEMKFODHFN), new string[] { })]
[CHALNEEBFJF(typeof(KPDEPPFNAGM))]
public class GEKINEFAONG : CHEMKFODHFN, PCAPGPPECJN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private readonly Dictionary<int, MGDMPJGJKNM> KECGHDAEMKO;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public IEnumerable<MGDMPJGJKNM> CHEOJKMDPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x2C7C750", Offset = "0x2C7AF50", VA = "0x182C7C750", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x2C7C810", Offset = "0x2C7B010", VA = "0x182C7C810", Slot = "6")]
	public void PAHLDMJMCEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x2C7C7A0", Offset = "0x2C7AFA0", VA = "0x182C7C7A0", Slot = "5")]
	public bool ONLMHPAKKHH(int KFGBCCEFCMB, out MGDMPJGJKNM PPCAJPBKNLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x2C7C700", Offset = "0x2C7AF00", VA = "0x182C7C700", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x2C7CBC0", Offset = "0x2C7B3C0", VA = "0x182C7CBC0")]
	public GEKINEFAONG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
internal class ADGPCCONHLK : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private EntityQuery BNBADLMDCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private NAHGLKOIEAI BOBHLPNKBHC;

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x2893C60", Offset = "0x2892460", VA = "0x182893C60", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x2893CB0", Offset = "0x28924B0", VA = "0x182893CB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x2893D60", Offset = "0x2892560", VA = "0x182893D60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x1DEFA50", Offset = "0x1DEE250", VA = "0x181DEFA50")]
	private bool OKOHKHMHFPJ<TComponentData>(EntityQuery EGFJCKOAGFH, out NativeArray<Entity> KFLBCCAJFMN, out NativeArray<TComponentData> MPCPKFKACPN) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x2893BF0", Offset = "0x28923F0", VA = "0x182893BF0")]
	public FKKNGLCNOFO IEPBHMOAGIB(Entity AJDEFAPHMKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public ADGPCCONHLK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000102")]
public struct HKIJKPHIJBO : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
[GCAKKMGPAEI]
public class BPFPOBNBFHA : NHLEGKPBPCC
{
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[BurstCompile]
	private struct LDMMMIOIEFB : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		[ReadOnly]
		public NativeArray<Entity> HEHFIEHBNKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		[ReadOnly]
		public ComponentDataFromEntity<NLLEHLHFEHG> DACGLPMEFGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		[ReadOnly]
		public ComponentDataFromEntity<NHHNAEGJEIL> DFFKNLKIODE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		[WriteOnly]
		public NativeParallelHashSet<Entity>.ParallelWriter GOGANHKJHIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		[WriteOnly]
		public NativeList<Entity>.ParallelWriter PCMJOKLGEAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		[WriteOnly]
		public NativeList<Entity>.ParallelWriter BHDPCCEIGAA;

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x2232990", Offset = "0x2231190", VA = "0x182232990", Slot = "4")]
		public void Execute(int AMOEKOMGDLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[BurstCompile]
	private struct DJPPBIIOCCA : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		[ReadOnly]
		public NativeArray<Entity> LNJGKMBPNJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> HFHEEKEBJOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		[ReadOnly]
		public ComponentDataFromEntity<ANGCGFBDCKA> EMFFIGGLGCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		[ReadOnly]
		public ComponentDataFromEntity<NIGPOFBMGGH> KNJHFEGOBNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		[NativeDisableParallelForRestriction]
		[NativeDisableContainerSafetyRestriction]
		public ComponentDataFromEntity<NHHNAEGJEIL> OLFNPDKOJAI;

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x222B620", Offset = "0x2229E20", VA = "0x18222B620", Slot = "4")]
		public void Execute(int AMOEKOMGDLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private EntityQuery LGPBKALAIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private EntityQuery HMIAOMEOGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private EntityQuery JCOOBBNEFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private EntityQuery MIJGCJIEKOB;

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x28A0530", Offset = "0x289ED30", VA = "0x1828A0530", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x28A0740", Offset = "0x289EF40", VA = "0x1828A0740", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x289FD30", Offset = "0x289E530", VA = "0x18289FD30")]
	private JobHandle IBMBOIDEDGF(NativeArrayAsync<Entity> DLLMPOAIBGN, int AKLMFDJHPFM, JobHandle BFAAEILACKK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x289FE10", Offset = "0x289E610", VA = "0x18289FE10")]
	private JobHandle IBMBOIDEDGF(NativeArray<Entity> DMABFPCDIIH, int AKLMFDJHPFM, [Optional] JobHandle BFAAEILACKK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x289F8E0", Offset = "0x289E0E0", VA = "0x18289F8E0")]
	private (NativeListAsync<Entity>, NativeListAsync<Entity>) GNPAHDIFMLL(NativeArrayAsync<Entity> BNGBMPEDLIK)
	{
		return default((NativeListAsync<Entity>, NativeListAsync<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x28A04A0", Offset = "0x289ECA0", VA = "0x1828A04A0")]
	private void MGALOLIAHKI(out NativeArray<Entity> KFLBCCAJFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x289F850", Offset = "0x289E050", VA = "0x18289F850")]
	private void CIOGNIGKNCJ(NativeList<Entity> KFLBCCAJFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x289F780", Offset = "0x289DF80", VA = "0x18289F780")]
	private void CIOGNIGKNCJ(NativeArray<Entity> KFLBCCAJFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x28A0370", Offset = "0x289EB70", VA = "0x1828A0370")]
	private void JMOEJGFKJHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	private static void NMOLIDIJEFF(int FIAFFCMHJKO, int NGJLKKODHEA, int KNCOOCGIACB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x28A0040", Offset = "0x289E840", VA = "0x1828A0040")]
	private static NHHNAEGJEIL IFCPKJLIOKD(NativeArray<Entity> HLFPAACMKOJ, ComponentDataFromEntity<ANGCGFBDCKA> EMFFIGGLGCP, ComponentDataFromEntity<NIGPOFBMGGH> KNJHFEGOBNH)
	{
		return default(NHHNAEGJEIL);
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public BPFPOBNBFHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public struct BHCNLMFFMGM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private NativeArray<BECDCKEMJCA> KAPFOMKMBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private NativeArray<int> AGKJMFDOGMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private NativeParallelHashMap<int, BECDCKEMJCA> GFHNBBHOMFI;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public readonly int KEHIDKEJKKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x8E8B70", Offset = "0x8E7370", VA = "0x1808E8B70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public readonly int FOBBGCJGFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0xFA8F20", Offset = "0xFA7720", VA = "0x180FA8F20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x289AB70", Offset = "0x2899370", VA = "0x18289AB70")]
	public BHCNLMFFMGM(IReadOnlyCollection<ADGLENNGCHF> MPCPKFKACPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x289AA30", Offset = "0x2899230", VA = "0x18289AA30")]
	public readonly GGOBGEMCPKI HLGOHEKFAMC(int KFGBCCEFCMB)
	{
		return default(GGOBGEMCPKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x289A9B0", Offset = "0x28991B0", VA = "0x18289A9B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
[AlwaysUpdateSystem]
public abstract class HEKIBFENEHC : NHLEGKPBPCC, CICEKNFDMIA.LCADOJGBOPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	private NativeList<EntityQuery> OIPELOCIIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	private bool BPKGPOIGENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000369")]
	private EntityCommandBufferSystem KFAEBKFHHLM;

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	protected bool BCALMCDLPAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x24E58B0", Offset = "0x24E40B0", VA = "0x1824E58B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	protected abstract JNGNMMOLKFF MFCLMPLONOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract IEnumerable<CICEKNFDMIA.JGNBJAKJHDD> PMIFINAIMEN();

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x24E58C0", Offset = "0x24E40C0", VA = "0x1824E58C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x24E59E0", Offset = "0x24E41E0", VA = "0x1824E59E0", Slot = "13")]
	protected sealed override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x24E5990", Offset = "0x24E4190", VA = "0x1824E5990", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract void EKEMAMGGCKM();

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x24E5860", Offset = "0x24E4060", VA = "0x1824E5860")]
	protected EntityCommandBufferSystem EFIPACDBNFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x1CB2740", Offset = "0x1CB0F40", VA = "0x181CB2740")]
	protected EntityQuery KOGBDLFLEHM<T>() where T : struct, IComponentData
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x1CB1AD0", Offset = "0x1CB02D0", VA = "0x181CB1AD0")]
	protected PMBACLANEMA<T> AKLEGEBPIJE<T>() where T : struct, IComponentData
	{
		return default(PMBACLANEMA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(RVA = "0x1CB2630", Offset = "0x1CB0E30", VA = "0x181CB2630")]
	protected JBMKEACBOEA<T> KHNKBCNEBHF<T>() where T : struct, IComponentData
	{
		return default(JBMKEACBOEA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x1CB2C60", Offset = "0x1CB1460", VA = "0x181CB2C60")]
	protected static void NPGKBEELMDE<T1, T2>(FEKDHFGFMGK<T1> HKIJNLFBDNC, FEKDHFGFMGK<T2> PPEAFDAKAPP) where T1 : struct, IComponentData where T2 : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x1CB2C60", Offset = "0x1CB1460", VA = "0x181CB2C60")]
	protected static void NPGKBEELMDE<T1, T2>(FEKDHFGFMGK<T1> HKIJNLFBDNC, JKHBKCMHBNA<T2> PPEAFDAKAPP) where T1 : struct, IComponentData where T2 : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0x1CB2BA0", Offset = "0x1CB13A0", VA = "0x181CB2BA0")]
	private static void NPGKBEELMDE<T1, T2>(AHMKCFBDMHK<T1> HKIJNLFBDNC, AHMKCFBDMHK<T2> PPEAFDAKAPP) where T1 : struct, IComponentData where T2 : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	protected HEKIBFENEHC()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	[LJMILPFECGO]
	public class PostDeserializeUpgrade_Convert_ObjectPolicyData : HEKIBFENEHC
	{
		[Cpp2IlInjected.Token(Token = "0x200010A")]
		[BurstCompile]
		[NoAlias]
		private struct PostDeserializeUpgrade_Convert_ObjectPolicyData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public PMBACLANEMA<KCEEFPEFEBB> v0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			public PMBACLANEMA<NEDHFDFGMNM> v1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			public PMBACLANEMA<HJDEIJHBJIO> v2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			public JBMKEACBOEA<JIHGMPJLDLP> v3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			public HJDEIJHBJIO v2Default;

			[Cpp2IlInjected.Token(Token = "0x60006A1")]
			[Cpp2IlInjected.Address(RVA = "0x2238BB0", Offset = "0x22373B0", VA = "0x182238BB0")]
			private void BNHOJHOEIPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006A2")]
			[Cpp2IlInjected.Address(RVA = "0x2239150", Offset = "0x2237950", VA = "0x182239150", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private static readonly JNGNMMOLKFF log;

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		protected override JNGNMMOLKFF Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000698")]
			[Cpp2IlInjected.Address(RVA = "0x22CAAC0", Offset = "0x22C92C0", VA = "0x1822CAAC0", Slot = "14")]
			get
			{
				return default(JNGNMMOLKFF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x22CA910", Offset = "0x22C9110", VA = "0x1822CA910", Slot = "15")]
		public override IEnumerable<CICEKNFDMIA.JGNBJAKJHDD> PMIFINAIMEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x22CA4E0", Offset = "0x22C8CE0", VA = "0x1822CA4E0", Slot = "16")]
		protected override void EKEMAMGGCKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x22CA340", Offset = "0x22C8B40", VA = "0x1822CA340")]
		private static void EBNKGBECLHG(AHMKCFBDMHK<NEDHFDFGMNM> srcVersion, AHMKCFBDMHK<HJDEIJHBJIO> dstVersion, HJDEIJHBJIO dstDefault)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x22CA7F0", Offset = "0x22C8FF0", VA = "0x1822CA7F0")]
		private static void GBDAIBNAANP(AHMKCFBDMHK<HJDEIJHBJIO> srcVersion, AHMKCFBDMHK<JIHGMPJLDLP> dstVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x22CA160", Offset = "0x22C8960", VA = "0x1822CA160")]
		private JobHandle DJMIPAFANMG(PMBACLANEMA<KCEEFPEFEBB> v0, PMBACLANEMA<NEDHFDFGMNM> v1, PMBACLANEMA<HJDEIJHBJIO> v2, JBMKEACBOEA<JIHGMPJLDLP> v3, HJDEIJHBJIO v2Default, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x22CA150", Offset = "0x22C8950", VA = "0x1822CA150")]
		public PostDeserializeUpgrade_Convert_ObjectPolicyData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
[AlwaysUpdateSystem]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
public abstract class GKEKBMGOHDE : NHLEGKPBPCC, NOHOJBNCAJC
{
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	private struct KDGICKJNEAC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public NativeListAsync<Entity> KJKLGEGAEFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public NativeListAsync<Entity> CKCFIHMDILN;

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x2232240", Offset = "0x2230A40", VA = "0x182232240")]
		public KDGICKJNEAC(NativeList<Entity> KJKLGEGAEFI, NativeList<Entity> CKCFIHMDILN, JobHandle LELCJDGAKHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x22321C0", Offset = "0x22309C0", VA = "0x1822321C0")]
		public JobHandle JCAHCECMIBA(JobHandle BFAAEILACKK)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x2232130", Offset = "0x2230930", VA = "0x182232130", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[BurstCompile]
	private struct PGEPAJNCBAF : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x200010E")]
		[Flags]
		public enum FFGFGFILOPN
		{
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			ReadParentFromArray = 1,
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			FetchParentFromEntity = 2,
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			AncestorTagValue = 4,
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			ConstNoAncestorTag = 0,
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			ConstHasAncestorTag = 4
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		[WriteOnly]
		public NativeList<Entity> AKLDKGOLNAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		[WriteOnly]
		public NativeList<Entity> BNFGAGDBJAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		[ReadOnly]
		public NativeArray<Entity> JIAHAMJBBBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		[ReadOnly]
		public BufferFromEntity<OEOKFMKAJDD> KHLHMOGDMON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		[ReadOnly]
		public ComponentDataFromEntity FEFFGKBIKKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		[ReadOnly]
		public ComponentDataFromEntity CMIIDOFMDNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		[ReadOnly]
		public ComponentDataFromEntity<OEKNEICFKDA> JDBIGPHCGDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public int ECDMLOFKHCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public int ODAJPBNDLGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private FFGFGFILOPN MPEFEKMEMDF;

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x2236C50", Offset = "0x2235450", VA = "0x182236C50", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x2236BA0", Offset = "0x22353A0", VA = "0x182236BA0")]
		private bool DJLEEEBFADK(Entity AJDEFAPHMKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x2236B10", Offset = "0x2235310", VA = "0x182236B10")]
		private void CNAEPNIAPKC(Entity AJDEFAPHMKF, bool DCPOLKBCBGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x2237240", Offset = "0x2235A40", VA = "0x182237240")]
		private void LEGLALDCMFC(Entity AJDEFAPHMKF, bool DCPOLKBCBGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x2236A90", Offset = "0x2235290", VA = "0x182236A90")]
		public KDGICKJNEAC ANOOIHPPAJP(NativeArray<Entity> BDNDLOBMJJM, JobHandle BFAAEILACKK)
		{
			return default(KDGICKJNEAC);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x22371C0", Offset = "0x22359C0", VA = "0x1822371C0")]
		public KDGICKJNEAC JPIKEENBBEP(NativeArray<Entity> BDNDLOBMJJM, JobHandle BFAAEILACKK)
		{
			return default(KDGICKJNEAC);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x2237350", Offset = "0x2235B50", VA = "0x182237350")]
		public KDGICKJNEAC LNMEKNFLBJK(NativeList<EJDGNFKIJAG> DFMKDLJIHMN, JobHandle BFAAEILACKK)
		{
			return default(KDGICKJNEAC);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x22370E0", Offset = "0x22358E0", VA = "0x1822370E0")]
		public KDGICKJNEAC JCMDOAKPCJM(NativeList<EJDGNFKIJAG> DFMKDLJIHMN, JobHandle BFAAEILACKK)
		{
			return default(KDGICKJNEAC);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x2237000", Offset = "0x2235800", VA = "0x182237000")]
		public KDGICKJNEAC GBDMDILFBIK(NativeList<FLNMMMIIPBM> DFMKDLJIHMN, JobHandle BFAAEILACKK)
		{
			return default(KDGICKJNEAC);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x2961B50", Offset = "0x2960350", VA = "0x182961B50")]
		private KDGICKJNEAC FNHIPNGEGJD<T>(NativeList<T> DFMKDLJIHMN, int HOKEGPFBGDI, int HEFACMMLICB, FFGFGFILOPN EDGJKPJHBBC, JobHandle BFAAEILACKK) where T : struct
		{
			return default(KDGICKJNEAC);
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x2236D80", Offset = "0x2235580", VA = "0x182236D80")]
		private KDGICKJNEAC FNHIPNGEGJD(NativeArray<Entity> KFLBCCAJFMN, int HOKEGPFBGDI, int HEFACMMLICB, FFGFGFILOPN EDGJKPJHBBC, JobHandle BFAAEILACKK)
		{
			return default(KDGICKJNEAC);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000370")]
	private readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000371")]
	private EntityQuery CMEOCNBLHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000372")]
	private EntityQuery JGMHCMNKFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000373")]
	private IGBOJICGIKC PGGMMHFOFHJ;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	protected abstract ComponentType DGPOOFGMLPO
	{
		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	protected abstract ComponentType PPHMGJJPIMB
	{
		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	protected abstract ComponentType KBLJDBJPDPC
	{
		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x2C812F0", Offset = "0x2C7FAF0", VA = "0x182C812F0")]
	protected GKEKBMGOHDE(JNGNMMOLKFF MBNJNNGOKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x2C7FA90", Offset = "0x2C7E290", VA = "0x182C7FA90", Slot = "14")]
	public void GGJEPBDNAAH(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x2C80090", Offset = "0x2C7E890", VA = "0x182C80090", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x2C802C0", Offset = "0x2C7EAC0", VA = "0x182C802C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x1638200", Offset = "0x1636A00", VA = "0x181638200", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x2C80040", Offset = "0x2C7E840", VA = "0x182C80040")]
	private void MHKFNFLONFJ(NativeArray<Entity> DFMKDLJIHMN, EntityCommandBuffer PFGPHODPKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x2C7FFF0", Offset = "0x2C7E7F0", VA = "0x182C7FFF0")]
	private void IIELLFOIFLI(NativeArray<Entity> DFMKDLJIHMN, EntityCommandBuffer PFGPHODPKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x2C7FB70", Offset = "0x2C7E370", VA = "0x182C7FB70")]
	private void HCMCHMKFCBM(KDGICKJNEAC HBBFHABLAOM, string AJHPBFHBCEG, EntityCommandBuffer PFGPHODPKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x2C7FCA0", Offset = "0x2C7E4A0", VA = "0x182C7FCA0")]
	private void HCMCHMKFCBM(NativeListAsync<Entity> OBJJPJGJJAJ, string AJHPBFHBCEG, EntityCommandBuffer PFGPHODPKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x2C7FEC0", Offset = "0x2C7E6C0", VA = "0x182C7FEC0")]
	private void HDADMOAHNOF(KDGICKJNEAC HBBFHABLAOM, string AJHPBFHBCEG, EntityCommandBuffer PFGPHODPKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0x2C7FDB0", Offset = "0x2C7E5B0", VA = "0x182C7FDB0")]
	private void HDADMOAHNOF(NativeListAsync<Entity> OBJJPJGJJAJ, string AJHPBFHBCEG, EntityCommandBuffer PFGPHODPKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(RVA = "0x2C7FA10", Offset = "0x2C7E210", VA = "0x182C7FA10")]
	private bool AGPEDOMNCFO()
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
	public class RegisterTransforms : NHLEGKPBPCC, NOFCHOCEBPC
	{
		[Cpp2IlInjected.Token(Token = "0x2000110")]
		private struct RegisterTransforms_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			public RegisterTransforms __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			[ReadOnly]
			public ComponentTypeHandle<OEFBIKKPGEE> __arrayIndexTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			public ComponentTypeHandle<Transform> __transformTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60006CE")]
			[Cpp2IlInjected.Address(RVA = "0x601F310", Offset = "0x601DB10", VA = "0x18601F310")]
			private void OriginalLambdaBody(Entity entity, in OEFBIKKPGEE arrayIndex, Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006CF")]
			[Cpp2IlInjected.Address(RVA = "0x601F120", Offset = "0x601D920", VA = "0x18601F120", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private static readonly JNGNMMOLKFF log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private JNIBHBOFDMB embodiedTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private EntityQuery allTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private EntityQuery addNewTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private EntityQuery removeOldTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private EntityQuery clearTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private EntityQuery RegisterTransforms_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		private ComponentTypeHandle<OEFBIKKPGEE> __RecRoom_Components_TransformAccessArrayIndexData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x22D14C0", Offset = "0x22CFCC0", VA = "0x1822D14C0", Slot = "14")]
		public void InitReferences(NCFCHDEHMHC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x22D1740", Offset = "0x22CFF40", VA = "0x1822D1740", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x22D19B0", Offset = "0x22D01B0", VA = "0x1822D19B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x22D1140", Offset = "0x22CF940", VA = "0x1822D1140")]
		private void AddTransforms(EntityQuery query, AOOPHAOFFDG accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x22D1CE0", Offset = "0x22D04E0", VA = "0x1822D1CE0")]
		private void RemoveTransforms(EntityQuery query, AOOPHAOFFDG accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x22D1950", Offset = "0x22D0150", VA = "0x1822D1950", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x22D1000", Offset = "0x22CF800", VA = "0x1822D1000")]
		private void AddNewTransforms(NativeArray<Entity> entities, AOOPHAOFFDG accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x22D1AA0", Offset = "0x22D02A0", VA = "0x1822D1AA0")]
		internal static void RemoveOldTransforms(NativeArray<OEFBIKKPGEE> arrayIndices, ComponentDataFromEntity<OEFBIKKPGEE> transformAccess, AOOPHAOFFDG accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		private static void DebugLogRemove(int index, AOOPHAOFFDG accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x22D1390", Offset = "0x22CFB90", VA = "0x1822D1390")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void DebugLogUninitializedTransformAccessArrayIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x22D1390", Offset = "0x22CFB90", VA = "0x1822D1390")]
		private void RegisterTransforms_LambdaJob_0_Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x22D1510", Offset = "0x22CFD10", VA = "0x1822D1510", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
		public RegisterTransforms()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
[KHNAILLFHGJ(typeof(LDDHDDLKFEJ), new string[] { })]
internal sealed class LDDHDDLKFEJ : ODKCILIJMBA, PCAPGPPECJN, NOFCHOCEBPC, NOHOJBNCAJC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000393")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000394")]
	private HMBELPNBOEG LNJHNPCFKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000395")]
	[NAAJCOHOAKA]
	private ILBBGIPPPPJ EJLFIBCCMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000396")]
	[NAAJCOHOAKA]
	private IKCMADHPPKE MFHEANKMMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000397")]
	[NAAJCOHOAKA]
	private NAHGLKOIEAI BOBHLPNKBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000398")]
	[NAAJCOHOAKA]
	private NBKDCPLNNHB NDJHELJNLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000399")]
	[NAAJCOHOAKA]
	private AIADALPADNN CCJACGPFKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400039A")]
	[NAAJCOHOAKA]
	private LFLDNNOOPLA OMNNHCNHOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400039B")]
	[NAAJCOHOAKA]
	private GHNAAIGKIGD PODDIAOEGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400039C")]
	private readonly Dictionary<MHGAJIKGEGE, FKKNGLCNOFO> FNIEPDOIJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400039D")]
	private OCHAEPHBIKE KNBNJFBOIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400039E")]
	private bool PMADFOMNIPK;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	private EntityManager EOOAJAELBGN
	{
		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x2922060", Offset = "0x2920860", VA = "0x182922060")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x8A6A30", Offset = "0x8A5230", VA = "0x1808A6A30", Slot = "4")]
	public void PAHLDMJMCEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x2922DE0", Offset = "0x29215E0", VA = "0x182922DE0", Slot = "5")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x29220B0", Offset = "0x29208B0", VA = "0x1829220B0")]
	public void HEKLLNLNMGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D6")]
	[Cpp2IlInjected.Address(RVA = "0x2921760", Offset = "0x291FF60", VA = "0x182921760", Slot = "6")]
	public void GGJEPBDNAAH(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D7")]
	[Cpp2IlInjected.Address(RVA = "0x2921600", Offset = "0x291FE00", VA = "0x182921600", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D8")]
	[Cpp2IlInjected.Address(RVA = "0x2923C90", Offset = "0x2922490", VA = "0x182923C90")]
	public int LCJGHNBLMMC(SceneTag JJIAFDKCLGJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x2922100", Offset = "0x2920900", VA = "0x182922100")]
	public bool HKDIBMOKJDI(Entity AJDEFAPHMKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x29223B0", Offset = "0x2920BB0", VA = "0x1829223B0")]
	public bool IGAMJDGIHFK(Entity AJDEFAPHMKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x29230E0", Offset = "0x29218E0", VA = "0x1829230E0")]
	public bool JLOABAPGJKJ(Entity AJDEFAPHMKF, out FKKNGLCNOFO CKMMOGKGLFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x2923190", Offset = "0x2921990", VA = "0x182923190")]
	private bool JLOABAPGJKJ(Transform LAMNAOAMKPM, out FKKNGLCNOFO CKMMOGKGLFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(RVA = "0x2925090", Offset = "0x2923890", VA = "0x182925090")]
	private void OPPHIIHOLFA(Entity AJDEFAPHMKF, FKKNGLCNOFO CKMMOGKGLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x2921590", Offset = "0x291FD90", VA = "0x182921590")]
	private bool DPKJMBHJIOC(Entity AJDEFAPHMKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x2922F10", Offset = "0x2921710", VA = "0x182922F10")]
	public void JACMNDDEBJP(MHGAJIKGEGE ECBAIECDCID, FKKNGLCNOFO KLGNIICJIKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(RVA = "0x2922670", Offset = "0x2920E70", VA = "0x182922670")]
	public bool IPJFPBOGMLE(LPLJHAHPEEF BBNGIDIFEAM, object AMCDGOPKAOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E1")]
	[Cpp2IlInjected.Address(RVA = "0x2922D70", Offset = "0x2921570", VA = "0x182922D70")]
	public bool IPJFPBOGMLE(Entity AJDEFAPHMKF, [Optional] object AMCDGOPKAOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(RVA = "0x2922D40", Offset = "0x2921540", VA = "0x182922D40")]
	public bool IPJFPBOGMLE(FKKNGLCNOFO DNMGFMBFODC, object AMCDGOPKAOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0x2923660", Offset = "0x2921E60", VA = "0x182923660")]
	public bool LALMNDMOKEI(Entity AJDEFAPHMKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(RVA = "0x2922D10", Offset = "0x2921510", VA = "0x182922D10")]
	public bool IPJFPBOGMLE(FKKNGLCNOFO CKMMOGKGLFH, bool BJDJJEPMPIM, [Optional] object AMCDGOPKAOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(RVA = "0x29218D0", Offset = "0x29200D0", VA = "0x1829218D0")]
	private bool GOGCJMPJFEG(FKKNGLCNOFO CKMMOGKGLFH, object AMCDGOPKAOE, bool BJDJJEPMPIM, bool JEGBPJLCFNL, bool KPEHBICCEJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x2923CC0", Offset = "0x29224C0", VA = "0x182923CC0")]
	public Transform LGGCHFINGFJ(Entity AJDEFAPHMKF, [Optional] object AMCDGOPKAOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0x2924930", Offset = "0x2923130", VA = "0x182924930")]
	public bool LOMNBKALOHK(Entity AJDEFAPHMKF, out Transform LAMNAOAMKPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x2924EF0", Offset = "0x29236F0", VA = "0x182924EF0")]
	public FKKNGLCNOFO OMDNJAEMAPA(Entity AJDEFAPHMKF, [Optional] object AMCDGOPKAOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x2921210", Offset = "0x291FA10", VA = "0x182921210")]
	public void CMGNCIJEFIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x2923240", Offset = "0x2921A40", VA = "0x182923240")]
	public void KGEKEEFOEBN(SceneTag JJIAFDKCLGJ, bool JEGBPJLCFNL, NativeParallelHashSet<int> GOBNBDPGPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x2923ED0", Offset = "0x29226D0", VA = "0x182923ED0")]
	private void LLMHCBPFLEK(Entity AJDEFAPHMKF, bool JEGBPJLCFNL, bool KPEHBICCEJJ, NativeParallelHashSet<int> GOBNBDPGPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x29235E0", Offset = "0x2921DE0", VA = "0x1829235E0")]
	public bool KPMJLLFPDAO(Entity AJDEFAPHMKF, object AMCDGOPKAOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x29214C0", Offset = "0x291FCC0", VA = "0x1829214C0")]
	public bool DCBHKHFJOGA(Entity AJDEFAPHMKF, object AMCDGOPKAOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x2925130", Offset = "0x2923930", VA = "0x182925130")]
	public bool POFBGFAIFCJ(Entity AJDEFAPHMKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(RVA = "0x2924AD0", Offset = "0x29232D0", VA = "0x182924AD0")]
	private void LPJBBGGFMFO(bool POJCDCHHLFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(RVA = "0x2921840", Offset = "0x2920040", VA = "0x182921840")]
	private bool GKKGKJDNKFP(Entity AJDEFAPHMKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x2921540", Offset = "0x291FD40", VA = "0x182921540")]
	public FKKNGLCNOFO DLDIPCAIJNF(Entity AJDEFAPHMKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x2924FF0", Offset = "0x29237F0", VA = "0x182924FF0")]
	private FKKNGLCNOFO OPODEFMEAIH(Entity AJDEFAPHMKF, object AMCDGOPKAOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x2920FD0", Offset = "0x291F7D0", VA = "0x182920FD0")]
	private FKKNGLCNOFO CJMKNPHPDDC(Entity AJDEFAPHMKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x2921ED0", Offset = "0x29206D0", VA = "0x182921ED0")]
	public void HBNFLEEGMEF(NativeArray<MHGAJIKGEGE> LJNBIMMNBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0x2920ED0", Offset = "0x291F6D0", VA = "0x182920ED0")]
	private void BKDNGEFLMFN(LPLJHAHPEEF BBNGIDIFEAM, FKKNGLCNOFO KLGNIICJIKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x29216B0", Offset = "0x291FEB0", VA = "0x1829216B0")]
	private void GFFCOHPONIG(FKKNGLCNOFO KLGNIICJIKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0x2924B90", Offset = "0x2923390", VA = "0x182924B90")]
	private void MLMOFKNGIHC(FKKNGLCNOFO CKMMOGKGLFH, Entity AJDEFAPHMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0x2922420", Offset = "0x2920C20", VA = "0x182922420")]
	private void IHJIDNLCFDP(Entity AJDEFAPHMKF, FKKNGLCNOFO CKMMOGKGLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(RVA = "0x29249F0", Offset = "0x29231F0", VA = "0x1829249F0")]
	private void LPGFGKJANIO(Entity AJDEFAPHMKF, Transform LAMNAOAMKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(RVA = "0x2899DF0", Offset = "0x28985F0", VA = "0x182899DF0")]
	private LPLJHAHPEEF LGDGILNIGMA(Entity AJDEFAPHMKF)
	{
		return default(LPLJHAHPEEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x2925230", Offset = "0x2923A30", VA = "0x182925230")]
	public LDDHDDLKFEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x2920E00", Offset = "0x291F600", VA = "0x182920E00")]
	[CompilerGenerated]
	private void BIAPPDBLFNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public struct PPAFHFDMEAA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public ADLDIGGBGPP BJJHADPHPJP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x7DF100", Offset = "0x7DD900", VA = "0x1807DF100")]
	public static PPAFHFDMEAA HFMFJLJFEMO(in ADLDIGGBGPP CMJIPBLMKLL)
	{
		return default(PPAFHFDMEAA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x7DF100", Offset = "0x7DD900", VA = "0x1807DF100")]
	public static ADLDIGGBGPP HFMFJLJFEMO(in PPAFHFDMEAA PBJKIOHJHEM)
	{
		return default(ADLDIGGBGPP);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[LJMILPFECGO]
	[CompilerGenerated]
	public class PostDeserializeUpgrade_Split_ContainerData : NHLEGKPBPCC, CICEKNFDMIA.LCADOJGBOPP
	{
		[Cpp2IlInjected.Token(Token = "0x2000115")]
		[BurstCompile]
		[NoAlias]
		private struct PostDeserializeUpgrade_Split_ContainerData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			public NativeArray<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			public NativeArray<HCANGBOCOIJ> v1Data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			public ComponentTypes newComponents;

			[Cpp2IlInjected.Token(Token = "0x6000707")]
			[Cpp2IlInjected.Address(RVA = "0x2239740", Offset = "0x2237F40", VA = "0x182239740")]
			private void BNHOJHOEIPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000708")]
			[Cpp2IlInjected.Address(RVA = "0x22399F0", Offset = "0x22381F0", VA = "0x1822399F0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private static readonly JNGNMMOLKFF log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private ComponentType[] newComponentTypes;

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x22CBC90", Offset = "0x22CA490", VA = "0x1822CBC90", Slot = "14")]
		public IEnumerable<CICEKNFDMIA.JGNBJAKJHDD> PMIFINAIMEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x22CB850", Offset = "0x22CA050", VA = "0x1822CB850", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x22CB6B0", Offset = "0x22C9EB0", VA = "0x1822CB6B0")]
		private EntityCommandBufferSystem EFIPACDBNFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x22CB700", Offset = "0x22C9F00", VA = "0x1822CB700")]
		private JobHandle OJHNEGCKLBC(EntityCommandBuffer ecb, NativeArray<Entity> entities, NativeArray<HCANGBOCOIJ> v1Data, ComponentTypes newComponents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x22CBDF0", Offset = "0x22CA5F0", VA = "0x1822CBDF0")]
		public PostDeserializeUpgrade_Split_ContainerData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
internal class KKFHAAGGHCB : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	private EntityQuery EGFJCKOAGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	private HMBELPNBOEG LNJHNPCFKIL;

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x24FE3E0", Offset = "0x24FCBE0", VA = "0x1824FE3E0", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x24FE540", Offset = "0x24FCD40", VA = "0x1824FE540", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x24FE600", Offset = "0x24FCE00", VA = "0x1824FE600", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(RVA = "0x24FE220", Offset = "0x24FCA20", VA = "0x1824FE220")]
	private NativeArray<Entity> DBNGOJGDENK(int JMKNAPEFDDB)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x24FE430", Offset = "0x24FCC30", VA = "0x1824FE430")]
	private void JPPOMHJHLLC(NativeArray<Entity> APFPBADEPOC, NativeArray<Entity> NHCNNCOLOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public KKFHAAGGHCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
[DefaultMember("Item")]
public struct GMJEMDDLLCH<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	private IPJHNCNICKF<T> NFBDMLCENEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	private int AKLMFDJHPFM;

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x208BD20", Offset = "0x208A520", VA = "0x18208BD20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x208BD70", Offset = "0x208A570", VA = "0x18208BD70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[BurstCompile]
public struct HECEHKFJNBN<T> : IEqualityComparer<ArchetypeChunk> where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	[ReadOnly]
	public SharedComponentTypeHandle<T> JCLJHMININN;

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0x8A8E20", Offset = "0x8A7620", VA = "0x1808A8E20")]
	public HECEHKFJNBN(SharedComponentTypeHandle<T> JCLJHMININN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(RVA = "0x299F490", Offset = "0x299DC90", VA = "0x18299F490", Slot = "4")]
	public bool Equals(ArchetypeChunk FBGKLELIKCG, ArchetypeChunk LFJEFFKGLOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000714")]
	[Cpp2IlInjected.Address(RVA = "0x299F5A0", Offset = "0x299DDA0", VA = "0x18299F5A0", Slot = "5")]
	public int GetHashCode(ArchetypeChunk OPMNIAACDHI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
[GCAKKMGPAEI]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
public class HABEAAPOAIA : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	private CKKBDPJEFPP AHBAIFGILLP;

	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(RVA = "0x24E3680", Offset = "0x24E1E80", VA = "0x1824E3680", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000716")]
	[Cpp2IlInjected.Address(RVA = "0x24E36D0", Offset = "0x24E1ED0", VA = "0x1824E36D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public HABEAAPOAIA()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[GCAKKMGPAEI]
	[CompilerGenerated]
	[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
	public class UpdateConnectableVisuals : NHLEGKPBPCC, NOFCHOCEBPC
	{
		[Cpp2IlInjected.Token(Token = "0x200011B")]
		private struct HandlePosition
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			public IEBLEDBIMDL handle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			public float3 position;

			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x471C780", Offset = "0x471AF80", VA = "0x18471C780")]
			public HandlePosition(IEBLEDBIMDL handle, float3 position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0x601CFB0", Offset = "0x601B7B0", VA = "0x18601CFB0")]
			public void LCNJHOAPLCH(out IEBLEDBIMDL handle, out float3 position)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011C")]
		private struct UpdateVisualPositions_ParentWoutCoM_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			public UpdateConnectableVisuals __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			public NativeList<HandlePosition> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			[ReadOnly]
			public ComponentTypeHandle<OGGLOODKLFP> __poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			public BufferTypeHandle<LLHDJNDLEHO> __stateTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x60231F0", Offset = "0x60219F0", VA = "0x1860231F0")]
			private void BNHOJHOEIPF(Entity entity, in OGGLOODKLFP pose, DynamicBuffer<LLHDJNDLEHO> state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0x6023440", Offset = "0x6021C40", VA = "0x186023440", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011D")]
		[NoAlias]
		[BurstCompile]
		private struct UpdateVisualPositions_ChildWoutCoM_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			public NativeList<HandlePosition> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			[ReadOnly]
			public ComponentTypeHandle<OGGLOODKLFP> __poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			public BufferTypeHandle<CKAJGINCPIL> __stateTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000741")]
			[Cpp2IlInjected.Address(RVA = "0x6022F90", Offset = "0x6021790", VA = "0x186022F90")]
			private void BNHOJHOEIPF([NoAlias] in OGGLOODKLFP pose, DynamicBuffer<CKAJGINCPIL> state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0x6023080", Offset = "0x6021880", VA = "0x186023080", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011E")]
		[NoAlias]
		[BurstCompile]
		private struct UpdateVisualPositions_ChildWithCoM_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			public NativeList<HandlePosition> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			[ReadOnly]
			public ComponentTypeHandle<OGGLOODKLFP> __poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			[ReadOnly]
			public ComponentTypeHandle<ONJPNGGFKNL> __comTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			public BufferTypeHandle<CKAJGINCPIL> __stateTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000743")]
			[Cpp2IlInjected.Address(RVA = "0x6022C70", Offset = "0x6021470", VA = "0x186022C70")]
			private void BNHOJHOEIPF([NoAlias] in OGGLOODKLFP pose, [NoAlias] in ONJPNGGFKNL com, DynamicBuffer<CKAJGINCPIL> state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0x6022DB0", Offset = "0x60215B0", VA = "0x186022DB0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private static readonly JNGNMMOLKFF log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private EntityQuery addGizmos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private EntityQuery addGizmosInScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private EntityQuery updateGizmos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private EntityQuery updateGizmosInScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private EntityQuery removeExpiredGizmos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private EntityQuery removeExpiredGizmosInScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private EntityQuery removeAllGizmos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private EntityQuery queryLegacyGizmoParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private EntityQuery queryChildrenWoutCom;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private EntityQuery queryChildrenWithCom;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private MHOFOLMCDLI<IEBLEDBIMDL, EOOBMMBDNHM> linkVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private BHNAPIGDOEG connectables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private HMBELPNBOEG objects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private JGHGFLIKNJI scope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private DEHMGEGCJGP makerPen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private EntityQuery UpdateVisualPositions_ParentWoutCoM_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private EntityQuery UpdateVisualPositions_ChildWoutCoM_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private EntityQuery UpdateVisualPositions_ChildWithCoM_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private ComponentTypeHandle<OGGLOODKLFP> __RecRoom_Components_WorldPoseData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private ComponentTypeHandle<ONJPNGGFKNL> __RecRoom_Rbex_RbexLocalCenterOfMassOfSelfData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000718")]
			[Cpp2IlInjected.Address(RVA = "0x22D6510", Offset = "0x22D4D10", VA = "0x1822D6510")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x22D4980", Offset = "0x22D3180", VA = "0x1822D4980")]
		internal EOOBMMBDNHM BGMAFECMGML(IEBLEDBIMDL handle)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x22D66C0", Offset = "0x22D4EC0", VA = "0x1822D66C0", Slot = "14")]
		public void InitReferences(NCFCHDEHMHC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x22D8040", Offset = "0x22D6840", VA = "0x1822D8040", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x22D82B0", Offset = "0x22D6AB0", VA = "0x1822D82B0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x22D8440", Offset = "0x22D6C40", VA = "0x1822D8440", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x22D8270", Offset = "0x22D6A70", VA = "0x1822D8270", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x22D49D0", Offset = "0x22D31D0", VA = "0x1822D49D0")]
		private void BLGLGPKHKFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x22D6020", Offset = "0x22D4820", VA = "0x1822D6020")]
		private void FBLJCAKGLKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x22D7260", Offset = "0x22D5A60", VA = "0x1822D7260")]
		private void MGPIIFCLPBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x22D8480", Offset = "0x22D6C80", VA = "0x1822D8480", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x22D51E0", Offset = "0x22D39E0", VA = "0x1822D51E0")]
		private void DNNKNEBJAJP(EntityQuery add, EntityQuery update, EntityQuery remove)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x22D6160", Offset = "0x22D4960", VA = "0x1822D6160")]
		private void FNJGHMKCCPI(EntityQuery remove)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x22D5690", Offset = "0x22D3E90", VA = "0x1822D5690")]
		private void DOFLHIPPMAI(NativeArrayAsync<Entity> oldEntities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x22D6550", Offset = "0x22D4D50", VA = "0x1822D6550")]
		private void HCKIHECCNBP(NativeArrayAsync<Entity> newEntities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x22D4AE0", Offset = "0x22D32E0", VA = "0x1822D4AE0")]
		private void CMENFBAPDHG(NativeArrayAsync<Entity> updateEntities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x22D6240", Offset = "0x22D4A40", VA = "0x1822D6240")]
		private void GLDBPJABCFE(NativeList<IEBLEDBIMDL> freeLinks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0x22D6780", Offset = "0x22D4F80", VA = "0x1822D6780")]
		private NativeList<IEBLEDBIMDL> JBJBFLBNNFK(NativeArray<Entity> entities)
		{
			return default(NativeList<IEBLEDBIMDL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x22D40F0", Offset = "0x22D28F0", VA = "0x1822D40F0")]
		private void AILLOJGPLHA(NativeArray<Entity> entities, NativeList<IEBLEDBIMDL> freeLinks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x22D4C80", Offset = "0x22D3480", VA = "0x1822D4C80")]
		private void CNBCIDLMNJC(NativeArray<Entity> addParents, NativeArray<Entity> addChildren, NativeList<IEBLEDBIMDL> freeList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x22D5BD0", Offset = "0x22D43D0", VA = "0x1822D5BD0")]
		private void EGKBCHPALMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x22D63B0", Offset = "0x22D4BB0", VA = "0x1822D63B0")]
		private NativeListAsync<HandlePosition> GMLIHDLEAMP(EntityQuery query, Func<NativeList<HandlePosition>, JobHandle> populateHandles)
		{
			return default(NativeListAsync<HandlePosition>);
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x22D85B0", Offset = "0x22D6DB0", VA = "0x1822D85B0")]
		private JobHandle PDNHOJABOBE(NativeList<HandlePosition> list)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0x22D4810", Offset = "0x22D3010", VA = "0x1822D4810")]
		private JobHandle BELPBICNAFJ(NativeList<HandlePosition> list)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x22D8720", Offset = "0x22D6F20", VA = "0x1822D8720")]
		private JobHandle PICCEFHLCJN(NativeList<HandlePosition> list)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x22D6FD0", Offset = "0x22D57D0", VA = "0x1822D6FD0")]
		private void LMFFMKBONOB(NativeListAsync<HandlePosition> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x22D5940", Offset = "0x22D4140", VA = "0x1822D5940")]
		private void ECAKGHPDBNJ(NativeListAsync<HandlePosition> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x22D6660", Offset = "0x22D4E60", VA = "0x1822D6660")]
		private bool IMCJAMCHAGM(Entity entity)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x22D6D00", Offset = "0x22D5500", VA = "0x1822D6D00")]
		private NativeArray<Entity> JGAMOGNKAOE(Entity entity)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x22D7610", Offset = "0x22D5E10", VA = "0x1822D7610")]
		private IEBLEDBIMDL MLDBEEACODL(NativeList<IEBLEDBIMDL> freeList)
		{
			return default(IEBLEDBIMDL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x22D6F40", Offset = "0x22D5740", VA = "0x1822D6F40")]
		private void KJGFBBHBHKB(IEBLEDBIMDL handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x22D77D0", Offset = "0x22D5FD0", VA = "0x1822D77D0")]
		private void OLNAPODGAGO(ref NativeList<HandlePosition> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x22D6DD0", Offset = "0x22D55D0", VA = "0x1822D6DD0")]
		private JobHandle JNINDALMECA(NativeList<HandlePosition> list, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x22D4670", Offset = "0x22D2E70", VA = "0x1822D4670")]
		private JobHandle BANMCOLOLBC(NativeList<HandlePosition> list, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x22D7920", Offset = "0x22D6120", VA = "0x1822D7920", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
		public UpdateConnectableVisuals()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	[AlwaysUpdateSystem]
	[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
	internal sealed class WriteDiffChangePacketToNetworkSystem : NHLEGKPBPCC, NOFCHOCEBPC
	{
		[Cpp2IlInjected.Token(Token = "0x2000121")]
		[BurstCompile]
		[NoAlias]
		private struct WriteDiffChangePacketToNetworkSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.Token(Token = "0x2000122")]
			public delegate void RunWithoutJobSystem_000008EC$PostfixBurstDelegate(IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x2000123")]
			internal static class RunWithoutJobSystem_000008EC$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x40003E8")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x40003E9")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x6000764")]
				[Cpp2IlInjected.Address(RVA = "0x601FED0", Offset = "0x601E6D0", VA = "0x18601FED0")]
				[BurstDiscard]
				private static void POFINAJNFAL(ref IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000765")]
				[Cpp2IlInjected.Address(RVA = "0x601FA60", Offset = "0x601E260", VA = "0x18601FA60")]
				private static IntPtr GFGFNEBPFAM()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000766")]
				[Cpp2IlInjected.Address(RVA = "0x601FE10", Offset = "0x601E610", VA = "0x18601FE10")]
				public static void MKAFKJABJJI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000767")]
				[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
				public static void BDCEDMLOOPD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000769")]
				[Cpp2IlInjected.Address(RVA = "0x601FBF0", Offset = "0x601E3F0", VA = "0x18601FBF0")]
				public static void MADELAMLLLM(IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			public IKAONOBBNND replication;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public NativeBitArray entityByProperty;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			[ReadOnly]
			public NativeArray<MHGAJIKGEGE> srcCreatedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			[ReadOnly]
			public NativeArray<CBGNFPNAGKM> srcCreationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			[ReadOnly]
			public NativeArray<MHGAJIKGEGE> srcDestroyedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			[ReadOnly]
			public NativeKeyValueArrays<Entity, EDAOOEIAPHC> srcPropertyKeyValues;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			public NativeList<MHGAJIKGEGE> dstCreatedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			public NativeList<CBGNFPNAGKM> dstCreationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40003E4")]
			public NativeList<MHGAJIKGEGE> dstDestroyedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40003E5")]
			public NativeParallelMultiHashMap<MHGAJIKGEGE, GODHOHPNOGF> dstProperties;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40003E6")]
			public NativeList<byte> dstPropertyData;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40003E7")]
			public ComponentDataFromEntity<GODBGECHIFD> __RecRoom_Components_ObjectNetworkIdComponentData_FromEntity;

			[Cpp2IlInjected.Token(Token = "0x600075C")]
			[Cpp2IlInjected.Address(RVA = "0x6023660", Offset = "0x6021E60", VA = "0x186023660")]
			private void BNHOJHOEIPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600075D")]
			[Cpp2IlInjected.Address(RVA = "0x6023B50", Offset = "0x6022350", VA = "0x186023B50", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600075E")]
			[Cpp2IlInjected.Address(RVA = "0x6023600", Offset = "0x6021E00", VA = "0x186023600")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void AABEEOLFMKP(IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0x6023B60", Offset = "0x6022360", VA = "0x186023B60")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void NDHFIMMDDCJ(IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private static readonly JNGNMMOLKFF log;

		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private static readonly JNGNMMOLKFF logEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		[NAAJCOHOAKA]
		private KAABEMEKKIO packetService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		[NAAJCOHOAKA]
		private OIKLJKNPPOI diffService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		[NAAJCOHOAKA]
		private AJCPLKBBBGL editorEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		[NAAJCOHOAKA]
		private NMKNMBOOICD transmission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private KMBAJEOAHDK.OBNENDELMNH utilServices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		private bool HasEditorListeners
		{
			[Cpp2IlInjected.Token(Token = "0x600074A")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		private DDCCAPLGKMA EventFlagsForPhase
		{
			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0x22DE8B0", Offset = "0x22DD0B0", VA = "0x1822DE8B0")]
			get
			{
				return default(DDCCAPLGKMA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x22DDC70", Offset = "0x22DC470", VA = "0x1822DDC70", Slot = "14")]
		public void InitReferences(NCFCHDEHMHC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x22DEBB0", Offset = "0x22DD3B0", VA = "0x1822DEBB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x22DDA90", Offset = "0x22DC290", VA = "0x1822DDA90")]
		private bool HIGKAKDAJFE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x22DDD80", Offset = "0x22DC580", VA = "0x1822DDD80")]
		private bool KFKIPMCOCKN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x22DD280", Offset = "0x22DBA80", VA = "0x1822DD280")]
		private bool DAGHPOFDOBM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x22DC750", Offset = "0x22DAF50", VA = "0x1822DC750")]
		private KMBAJEOAHDK.IKADDGCFNCG APAFEMMEODK(DCDCMCEDILM state)
		{
			return default(KMBAJEOAHDK.IKADDGCFNCG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x22DE660", Offset = "0x22DCE60", VA = "0x1822DE660")]
		private NativeKeyValueArrays<Entity, EDAOOEIAPHC> NBDIFPECMIM(DCDCMCEDILM state, out int capacity)
		{
			return default(NativeKeyValueArrays<Entity, EDAOOEIAPHC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x22DDF50", Offset = "0x22DC750", VA = "0x1822DDF50")]
		private void MGFGFCDLPBI(KMBAJEOAHDK.IKADDGCFNCG data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x22DD2D0", Offset = "0x22DBAD0", VA = "0x1822DD2D0")]
		private void DIPAGPDLGIJ(KMBAJEOAHDK.IKADDGCFNCG data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x22DE2B0", Offset = "0x22DCAB0", VA = "0x1822DE2B0")]
		private void MIKCFACCNPJ(KMBAJEOAHDK.IKADDGCFNCG data, DCDCMCEDILM state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x22DDB60", Offset = "0x22DC360", VA = "0x1822DDB60")]
		private void IMFKFCLCJFE(NativeArray<MHGAJIKGEGE> createdIds, NativeArray<CBGNFPNAGKM> creationData, DDCCAPLGKMA flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x22DD3C0", Offset = "0x22DBBC0", VA = "0x1822DD3C0")]
		private void FNAGCOPEDEH(NativeMultiHashMapAsync<Entity, EDAOOEIAPHC> differences, DDCCAPLGKMA flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x22DDE90", Offset = "0x22DC690", VA = "0x1822DDE90")]
		private void LODJFKLGPIB(NativeArray<MHGAJIKGEGE> destroyedIds, DDCCAPLGKMA flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x22DCFB0", Offset = "0x22DB7B0", VA = "0x1822DCFB0")]
		private void CMNCKDLDLLM(ref IKAONOBBNND replication, ref NativeBitArray entityByProperty, ref NativeArray<MHGAJIKGEGE> srcCreatedIds, ref NativeArray<CBGNFPNAGKM> srcCreationData, ref NativeArray<MHGAJIKGEGE> srcDestroyedIds, ref NativeKeyValueArrays<Entity, EDAOOEIAPHC> srcPropertyKeyValues, ref NativeList<MHGAJIKGEGE> dstCreatedIds, ref NativeList<CBGNFPNAGKM> dstCreationData, ref NativeList<MHGAJIKGEGE> dstDestroyedIds, ref NativeParallelMultiHashMap<MHGAJIKGEGE, GODHOHPNOGF> dstProperties, ref NativeList<byte> dstPropertyData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x22DE950", Offset = "0x22DD150", VA = "0x1822DE950", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
		public WriteDiffChangePacketToNetworkSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x22DDD30", Offset = "0x22DC530", VA = "0x1822DDD30")]
		public static void KCNPIIEGONH()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
internal readonly struct PFIPHDFKNLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	private readonly IIMBLKLKCCJ LPGIFLPNBEK;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	private static readonly ProfilerMarker AJAJOBDBGFL;

	[Cpp2IlInjected.Token(Token = "0x600076A")]
	[Cpp2IlInjected.Address(RVA = "0x22C0D00", Offset = "0x22BF500", VA = "0x1822C0D00")]
	public PFIPHDFKNLD(World LDJNMODKEPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076B")]
	[Cpp2IlInjected.Address(RVA = "0x22C0B70", Offset = "0x22BF370", VA = "0x1822C0B70")]
	public JobHandle DNNKNEBJAJP(JobHandle GOPOKIDKKKA)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
internal static class LMPHKFOCLBK
{
	[Cpp2IlInjected.Token(Token = "0x600076D")]
	[Cpp2IlInjected.Address(RVA = "0x1DB0340", Offset = "0x1DAEB40", VA = "0x181DB0340")]
	public static NativeArray<T> FNHIPNGEGJD<T>(NativeArray<Entity> KFLBCCAJFMN, EntityManager EADLBIHJKBG) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600076E")]
	[Cpp2IlInjected.Address(RVA = "0x29271F0", Offset = "0x29259F0", VA = "0x1829271F0")]
	public static void PFAHFLGFCDD(EntityQuery EGFJCKOAGFH, EntityManager EADLBIHJKBG, HMBELPNBOEG LNJHNPCFKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076F")]
	[Cpp2IlInjected.Address(RVA = "0x2926F70", Offset = "0x2925770", VA = "0x182926F70")]
	public static void AMIOMNJFIME(NativeArray<Entity> APFPBADEPOC, HMBELPNBOEG LNJHNPCFKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000770")]
	[Cpp2IlInjected.Address(RVA = "0x29270B0", Offset = "0x29258B0", VA = "0x1829270B0")]
	public static void APGIMHBAIAD(NativeArray<Entity> APFPBADEPOC, HMBELPNBOEG LNJHNPCFKIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
public class PAKGJKDEGAC : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	private FJKBBPDKKKK DIGAIEICIOG;

	[Cpp2IlInjected.Token(Token = "0x6000771")]
	[Cpp2IlInjected.Address(RVA = "0x22BECF0", Offset = "0x22BD4F0", VA = "0x1822BECF0", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000772")]
	[Cpp2IlInjected.Address(RVA = "0x22BED40", Offset = "0x22BD540", VA = "0x1822BED40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000773")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public PAKGJKDEGAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public class AHDKHFJNJMD : NHLEGKPBPCC
{
	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	private static JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	private EntityQuery NEEHOLAPGGH;

	[Cpp2IlInjected.Token(Token = "0x6000774")]
	[Cpp2IlInjected.Address(RVA = "0x2896F30", Offset = "0x2895730", VA = "0x182896F30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000775")]
	[Cpp2IlInjected.Address(RVA = "0x28971D0", Offset = "0x28959D0", VA = "0x1828971D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000776")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public AHDKHFJNJMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
internal struct OOAOLOKBLAE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	private static readonly ProfilerMarker AJAJOBDBGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	private readonly NHLEGKPBPCC EDPKAJCAKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	private NativeList<(EntityQuery query, int componentIndex)> AHBJNDBKKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	private NativeList<(EntityQuery query, int componentIndex)> CDDIJPOAKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	private NativeList<(EntityQuery query, int componentIndex)> NALLFFPCAHD;

	[Cpp2IlInjected.Token(Token = "0x6000778")]
	[Cpp2IlInjected.Address(RVA = "0x22BE1F0", Offset = "0x22BC9F0", VA = "0x1822BE1F0")]
	public OOAOLOKBLAE(NHLEGKPBPCC EDPKAJCAKAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000779")]
	[Cpp2IlInjected.Address(RVA = "0x22BDC60", Offset = "0x22BC460", VA = "0x1822BDC60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077A")]
	[Cpp2IlInjected.Address(RVA = "0x22BDF00", Offset = "0x22BC700", VA = "0x1822BDF00")]
	public NativeList<(EntityQuery, int, int, PNCOAHIEOAE.PDLKHOKKEFJ)> OIIDPHGIEAN(uint ILLICOCPHCL, out int DNOFPGCHEPC)
	{
		return default(NativeList<(EntityQuery, int, int, PNCOAHIEOAE.PDLKHOKKEFJ)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600077B")]
	[Cpp2IlInjected.Address(RVA = "0x22BDCC0", Offset = "0x22BC4C0", VA = "0x1822BDCC0")]
	private int KLFCHNMKEFI(PNCOAHIEOAE.PDLKHOKKEFJ EDGJKPJHBBC, NativeList<(EntityQuery query, int typeIndex)> OADMIGAEKPI, NativeList<(EntityQuery query, int typeIndex, int count, PNCOAHIEOAE.PDLKHOKKEFJ mode)> HNICMLCBLOB, uint ILLICOCPHCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600077C")]
	[Cpp2IlInjected.Address(RVA = "0x22BDEC0", Offset = "0x22BC6C0", VA = "0x1822BDEC0")]
	private NativeList<(EntityQuery, int)> NBLDGCIJGBA(NativeParallelHashSet<int> MPCPKFKACPN, int BIBMBLCJCFK)
	{
		return default(NativeList<(EntityQuery, int)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600077D")]
	[Cpp2IlInjected.Address(RVA = "0x22BDE70", Offset = "0x22BC670", VA = "0x1822BDE70")]
	private NativeList<(EntityQuery, int)> LDGEBBNHFLL(NativeParallelHashSet<int> MPCPKFKACPN, int BIBMBLCJCFK)
	{
		return default(NativeList<(EntityQuery, int)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600077E")]
	[Cpp2IlInjected.Address(RVA = "0x22BD880", Offset = "0x22BC080", VA = "0x1822BD880")]
	private NativeList<(EntityQuery, int)> CEFKHLHHBDI(NativeParallelHashSet<int> MPCPKFKACPN, int BIBMBLCJCFK, PNCOAHIEOAE.PDLKHOKKEFJ EDGJKPJHBBC)
	{
		return default(NativeList<(EntityQuery, int)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600077F")]
	[Cpp2IlInjected.Address(RVA = "0x22BD590", Offset = "0x22BBD90", VA = "0x1822BD590")]
	private NativeList<(EntityQuery, int)> AOKOBNCJAHJ()
	{
		return default(NativeList<(EntityQuery, int)>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public enum KPKNPFEMOAK
{
	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	NewParent,
	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	ChangedParent,
	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	OldParent
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public struct IMFFAHKLBNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public KPKNPFEMOAK MLJMKKCOHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public int OLNMDPKJIPE;

	[Cpp2IlInjected.Token(Token = "0x6000781")]
	[Cpp2IlInjected.Address(RVA = "0xAB38B0", Offset = "0xAB20B0", VA = "0x180AB38B0")]
	public IMFFAHKLBNI(KPKNPFEMOAK MLJMKKCOHMB, int OLNMDPKJIPE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000782")]
	[Cpp2IlInjected.Address(RVA = "0x24F0E30", Offset = "0x24EF630", VA = "0x1824F0E30")]
	public static IMFFAHKLBNI HFMFJLJFEMO((KPKNPFEMOAK eventType, int eventIndex) FBGKLELIKCG)
	{
		return default(IMFFAHKLBNI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000783")]
	[Cpp2IlInjected.Address(RVA = "0x24F0E50", Offset = "0x24EF650", VA = "0x1824F0E50")]
	public void LCNJHOAPLCH(out KPKNPFEMOAK MLJMKKCOHMB, out int OLNMDPKJIPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public struct JBMKEACBOEA<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	private LAPGECLMCFE<T> MNJCDKNLLPF;

	[Cpp2IlInjected.Token(Token = "0x6000784")]
	[Cpp2IlInjected.Address(RVA = "0x220D8B0", Offset = "0x220C0B0", VA = "0x18220D8B0")]
	public JBMKEACBOEA(LAPGECLMCFE<T> MNJCDKNLLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000785")]
	[Cpp2IlInjected.Address(RVA = "0x220D5B0", Offset = "0x220BDB0", VA = "0x18220D5B0")]
	public JKHBKCMHBNA<T> NKOFHFCALHN()
	{
		return default(JKHBKCMHBNA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public readonly struct EDAOOEIAPHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	private readonly LLNAAGHGEOA BMKPPKKOMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	private readonly int HJLDFBDBBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	private unsafe readonly byte* NGJKDLMDGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	private unsafe readonly byte* CKBMPMDFJMO;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public LLNAAGHGEOA LFODACJMPMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0xB1A680", Offset = "0xB18E80", VA = "0x180B1A680")]
		get
		{
			return default(LLNAAGHGEOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public int EFKFFCAGHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0x1AB09C0", Offset = "0x1AAF1C0", VA = "0x181AB09C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public unsafe byte* IJNDJIGOFGD
	{
		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0xB1A5B0", Offset = "0xB18DB0", VA = "0x180B1A5B0")]
		get
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public unsafe byte* HKNNCCELFBA
	{
		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170")]
		get
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000788")]
	[Cpp2IlInjected.Address(RVA = "0x2C71F50", Offset = "0x2C70750", VA = "0x182C71F50")]
	public DMEBMKFMGNA HAJEECEOBPD(Type EIOLDDJPDLH)
	{
		return default(DMEBMKFMGNA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000789")]
	[Cpp2IlInjected.Address(RVA = "0x2AFC250", Offset = "0x2AFAA50", VA = "0x182AFC250")]
	public T EIGHKFPGDCO<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600078A")]
	[Cpp2IlInjected.Address(RVA = "0x2AFC270", Offset = "0x2AFAA70", VA = "0x182AFC270")]
	public T HAJEECEOBPD<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600078D")]
	[Cpp2IlInjected.Address(RVA = "0x2C72130", Offset = "0x2C70930", VA = "0x182C72130")]
	public unsafe EDAOOEIAPHC(LLNAAGHGEOA BMKPPKKOMAH, int JIAHBEIKEJF, byte* NGJKDLMDGKA, byte* CKBMPMDFJMO)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200012D")]
internal struct HOBIEDLFKNI : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[LJMILPFECGO]
	[CompilerGenerated]
	public class PostDeserializeUpgrade_Convert_OMShapeContainerData : HEKIBFENEHC
	{
		[Cpp2IlInjected.Token(Token = "0x200012F")]
		[BurstCompile]
		[NoAlias]
		private struct PostDeserializeUpgrade_Convert_OMShapeContainerData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			public PMBACLANEMA<IJNGFCCADKL> v1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000402")]
			public JBMKEACBOEA<LHGMHGJGEDG> v2;

			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0x2238910", Offset = "0x2237110", VA = "0x182238910")]
			private void BNHOJHOEIPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(RVA = "0x2238BA0", Offset = "0x22373A0", VA = "0x182238BA0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private static readonly JNGNMMOLKFF log;

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		protected override JNGNMMOLKFF Log
		{
			[Cpp2IlInjected.Token(Token = "0x600078E")]
			[Cpp2IlInjected.Address(RVA = "0x22CA060", Offset = "0x22C8860", VA = "0x1822CA060", Slot = "14")]
			get
			{
				return default(JNGNMMOLKFF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x22C9FA0", Offset = "0x22C87A0", VA = "0x1822C9FA0", Slot = "15")]
		public override IEnumerable<CICEKNFDMIA.JGNBJAKJHDD> PMIFINAIMEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x22C9E30", Offset = "0x22C8630", VA = "0x1822C9E30", Slot = "16")]
		protected override void EKEMAMGGCKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0x22C9D60", Offset = "0x22C8560", VA = "0x1822C9D60")]
		private static void EBNKGBECLHG(AHMKCFBDMHK<IJNGFCCADKL> srcVersion, AHMKCFBDMHK<LHGMHGJGEDG> dstVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x22C9C30", Offset = "0x22C8430", VA = "0x1822C9C30")]
		private JobHandle AGDBOCDMOEA(PMBACLANEMA<IJNGFCCADKL> v1, JBMKEACBOEA<LHGMHGJGEDG> v2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0x22CA150", Offset = "0x22C8950", VA = "0x1822CA150")]
		public PostDeserializeUpgrade_Convert_OMShapeContainerData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
internal class OPEIEEDOGGL : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	private EntityQuery GHKKLCBHOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	private EntityQuery EGINJBJCALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	private NAHGLKOIEAI BOBHLPNKBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	private HMBELPNBOEG LNJHNPCFKIL;

	[Cpp2IlInjected.Token(Token = "0x6000798")]
	[Cpp2IlInjected.Address(RVA = "0x22BE3C0", Offset = "0x22BCBC0", VA = "0x1822BE3C0", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000799")]
	[Cpp2IlInjected.Address(RVA = "0x22BE430", Offset = "0x22BCC30", VA = "0x1822BE430", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079A")]
	[Cpp2IlInjected.Address(RVA = "0x22BE580", Offset = "0x22BCD80", VA = "0x1822BE580", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079B")]
	[Cpp2IlInjected.Address(RVA = "0x22BE350", Offset = "0x22BCB50", VA = "0x1822BE350")]
	private void FHLDMNGNDBI(EntityQuery EGFJCKOAGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079C")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public OPEIEEDOGGL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000131")]
public struct OLGFEGPFJIP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal class NDFEBALOIGE : AJNCIBJCEPK, DCDCMCEDILM
{
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	private readonly NIPHPIANDBN GLIEOKNLMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	private readonly HPOKAOBOIJC PODDIAOEGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	private readonly World LDJNMODKEPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private readonly List<IAPFIKFHMGA> OJKIEKMLHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	private NativeParallelMultiHashMap<Entity, EDAOOEIAPHC> JIKAHMDPOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	private NativeParallelHashMap<int, int> ELFPOPMMEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	private NativeArray<MHGAJIKGEGE> OAPBHJIHLMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	private NativeArray<CBGNFPNAGKM> NHOIGPDOBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	private NativeArray<MHGAJIKGEGE> OKDKKADGGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private JobHandle EEJCGLANENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private JobHandle EGJMONKGOJJ;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private NativeParallelMultiHashMap<Entity, EDAOOEIAPHC> EBNMAAKJKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0xB28580", Offset = "0xB26D80", VA = "0x180B28580", Slot = "4")]
		get
		{
			return default(NativeParallelMultiHashMap<Entity, EDAOOEIAPHC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private uint FLCGLBKCNJA
	{
		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0x292F130", Offset = "0x292D930", VA = "0x18292F130", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private bool EGBKGKKIFDF
	{
		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0x292EE40", Offset = "0x292D640", VA = "0x18292EE40", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private NativeArray<MHGAJIKGEGE> MBHOMLGLAIN
	{
		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0xBB0CB0", Offset = "0xBAF4B0", VA = "0x180BB0CB0", Slot = "10")]
		get
		{
			return default(NativeArray<MHGAJIKGEGE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private NativeArray<CBGNFPNAGKM> PLBGFBHFMPF
	{
		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0xBB0D00", Offset = "0xBAF500", VA = "0x180BB0D00", Slot = "11")]
		get
		{
			return default(NativeArray<CBGNFPNAGKM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	private NativeArray<MHGAJIKGEGE> MBJCPKCBJAC
	{
		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x269DA20", Offset = "0x269C220", VA = "0x18269DA20", Slot = "12")]
		get
		{
			return default(NativeArray<MHGAJIKGEGE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600079E")]
	[Cpp2IlInjected.Address(RVA = "0x292F2F0", Offset = "0x292DAF0", VA = "0x18292F2F0")]
	public NDFEBALOIGE(NIPHPIANDBN GLIEOKNLMIA, HPOKAOBOIJC PODDIAOEGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A1")]
	[Cpp2IlInjected.Address(RVA = "0x292EE50", Offset = "0x292D650", VA = "0x18292EE50", Slot = "6")]
	private bool KIODDKANPFH(NativeArray<MHGAJIKGEGE> OAPBHJIHLMO, NativeArray<CBGNFPNAGKM> NHOIGPDOBNB, NativeArray<MHGAJIKGEGE> OKDKKADGGHO, int JFGAOALCBGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A2")]
	[Cpp2IlInjected.Address(RVA = "0x292F050", Offset = "0x292D850", VA = "0x18292F050", Slot = "7")]
	private void KPIKLMKMJIK(in IAPFIKFHMGA CAFNBKIMCBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A3")]
	[Cpp2IlInjected.Address(RVA = "0x292E640", Offset = "0x292CE40", VA = "0x18292E640", Slot = "8")]
	private void CJCDEJGBAPM(JobHandle BJJHADPHPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A8")]
	[Cpp2IlInjected.Address(RVA = "0x292ED90", Offset = "0x292D590", VA = "0x18292ED90", Slot = "13")]
	private bool HEKLBGLGKBK(out NativeArray<int> JBFHHCCJFKA, Allocator HMGEFCKKBID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A9")]
	[Cpp2IlInjected.Address(RVA = "0x292E460", Offset = "0x292CC60", VA = "0x18292E460", Slot = "14")]
	private bool BBMGCILMJIM(ComponentType JHKLCDEPMAD, out IAPFIKFHMGA GNGOHFCIIGM, out GGOBGEMCPKI KMILPECLOGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007AA")]
	[Cpp2IlInjected.Address(RVA = "0x292F1E0", Offset = "0x292D9E0", VA = "0x18292F1E0", Slot = "15")]
	private NativeMultiHashMapAsync<Entity, EDAOOEIAPHC> OLODIAFDFCJ()
	{
		return default(NativeMultiHashMapAsync<Entity, EDAOOEIAPHC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007AB")]
	[Cpp2IlInjected.Address(RVA = "0x292E790", Offset = "0x292CF90", VA = "0x18292E790")]
	public void EEMEPIGIECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AC")]
	[Cpp2IlInjected.Address(RVA = "0x292EAF0", Offset = "0x292D2F0", VA = "0x18292EAF0")]
	private bool GPFOKLCCMNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
[InternalBufferCapacity(4)]
internal struct LLHDJNDLEHO : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public IEBLEDBIMDL BJJHADPHPJP;
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
internal sealed class JCANKHKMKEI : GJJADNOGMIL
{
	[Cpp2IlInjected.Token(Token = "0x60007AE")]
	[Cpp2IlInjected.Address(RVA = "0x24F2F20", Offset = "0x24F1720", VA = "0x1824F2F20", Slot = "15")]
	protected override ComponentSystemBase CMFPJFIFJLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007AF")]
	[Cpp2IlInjected.Address(RVA = "0x22BD2C0", Offset = "0x22BBAC0", VA = "0x1822BD2C0")]
	public JCANKHKMKEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
internal class IADLCHKLAFA : HEGFKOOIJBF
{
	[Cpp2IlInjected.Token(Token = "0x60007B0")]
	[Cpp2IlInjected.Address(RVA = "0x22BD2C0", Offset = "0x22BBAC0", VA = "0x1822BD2C0")]
	public IADLCHKLAFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal class BHMGBHHAEJI
{
	[Cpp2IlInjected.Token(Token = "0x60007B1")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public BHMGBHHAEJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000137")]
public readonly struct GODHOHPNOGF : IEquatable<GODHOHPNOGF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private readonly LLNAAGHGEOA BMKPPKKOMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	private readonly int HJLDFBDBBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private readonly int NGJKDLMDGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private readonly int CKBMPMDFJMO;

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public LLNAAGHGEOA LFODACJMPMC
	{
		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0xB1A680", Offset = "0xB18E80", VA = "0x180B1A680")]
		get
		{
			return default(LLNAAGHGEOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007B3")]
	[Cpp2IlInjected.Address(RVA = "0x2C81C50", Offset = "0x2C80450", VA = "0x182C81C50")]
	public unsafe ReadOnlySpan<byte> EIGHKFPGDCO(void* MLDMCBNMHCN)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007B4")]
	[Cpp2IlInjected.Address(RVA = "0x2C81E40", Offset = "0x2C80640", VA = "0x182C81E40")]
	public unsafe ReadOnlySpan<byte> HAJEECEOBPD(void* MLDMCBNMHCN)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007B5")]
	[Cpp2IlInjected.Address(RVA = "0x20DA920", Offset = "0x20D9120", VA = "0x1820DA920")]
	public GODHOHPNOGF(LLNAAGHGEOA BMKPPKKOMAH, int JIAHBEIKEJF, int NGJKDLMDGKA, int CKBMPMDFJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B6")]
	[Cpp2IlInjected.Address(RVA = "0x2C81CC0", Offset = "0x2C804C0", VA = "0x182C81CC0", Slot = "4")]
	public bool Equals(GODHOHPNOGF OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007B7")]
	[Cpp2IlInjected.Address(RVA = "0x2C81D30", Offset = "0x2C80530", VA = "0x182C81D30", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007B8")]
	[Cpp2IlInjected.Address(RVA = "0x2C81E00", Offset = "0x2C80600", VA = "0x182C81E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[GCAKKMGPAEI]
	[LJMILPFECGO]
	[CompilerGenerated]
	public class PostDeserializeUpgrade_Convert_RRObjectPrefabV1Data : HEKIBFENEHC, CICEKNFDMIA.LCADOJGBOPP
	{
		[Cpp2IlInjected.Token(Token = "0x2000139")]
		private struct PostDeserializeUpgrade_Convert_RRObjectPrefabV1Data_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			public PMBACLANEMA<AMJICEAFCFD> v0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400041B")]
			public PMBACLANEMA<LLBLIEDHHDD> v1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400041C")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.Token(Token = "0x60007C1")]
			[Cpp2IlInjected.Address(RVA = "0x2239160", Offset = "0x2237960", VA = "0x182239160")]
			private void BNHOJHOEIPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C2")]
			[Cpp2IlInjected.Address(RVA = "0x22394C0", Offset = "0x2237CC0", VA = "0x1822394C0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private static readonly JNGNMMOLKFF log;

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		protected override JNGNMMOLKFF Log
		{
			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0x22CB170", Offset = "0x22C9970", VA = "0x1822CB170", Slot = "14")]
			get
			{
				return default(JNGNMMOLKFF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0x22CB040", Offset = "0x22C9840", VA = "0x1822CB040", Slot = "15")]
		public override IEnumerable<CICEKNFDMIA.JGNBJAKJHDD> PMIFINAIMEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0x22CABB0", Offset = "0x22C93B0", VA = "0x1822CABB0", Slot = "16")]
		protected override void EKEMAMGGCKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0x22CAF00", Offset = "0x22C9700", VA = "0x1822CAF00")]
		private static void PGBIEFLKALE(FEKDHFGFMGK<LLBLIEDHHDD> d1, EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0x22CADB0", Offset = "0x22C95B0", VA = "0x1822CADB0")]
		private JobHandle IFHFGCBEBAD(PMBACLANEMA<AMJICEAFCFD> v0, PMBACLANEMA<LLBLIEDHHDD> v1, EntityCommandBuffer ecb, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BE")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x22CA150", Offset = "0x22C8950", VA = "0x1822CA150")]
		public PostDeserializeUpgrade_Convert_RRObjectPrefabV1Data()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
public readonly struct IAPFIKFHMGA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public NativeList<Entity> LEHLEJFFNOO
	{
		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x13203E0", Offset = "0x131EBE0", VA = "0x1813203E0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public NativeList<Entity> BIKFEAHCJDF
	{
		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0x918DC0", Offset = "0x9175C0", VA = "0x180918DC0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public NativeList<byte> OKKJFIENCNC
	{
		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0x918DD0", Offset = "0x9175D0", VA = "0x180918DD0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public NativeList<byte> MKFEAGJJNDL
	{
		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0xB28580", Offset = "0xB26D80", VA = "0x180B28580")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public NativeList<byte> PJPIMOHGOGL
	{
		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0x918DF0", Offset = "0x9175F0", VA = "0x180918DF0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public ComponentType HNNLLGAFCEB
	{
		[Cpp2IlInjected.Token(Token = "0x60007C8")]
		[Cpp2IlInjected.Address(RVA = "0x7ED770", Offset = "0x7EBF70", VA = "0x1807ED770")]
		[CompilerGenerated]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public JobHandle FIKKJOLIFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60007C9")]
		[Cpp2IlInjected.Address(RVA = "0x13BBA50", Offset = "0x13BA250", VA = "0x1813BBA50")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public int DKPJIBEOHBO
	{
		[Cpp2IlInjected.Token(Token = "0x60007CA")]
		[Cpp2IlInjected.Address(RVA = "0x20279E0", Offset = "0x20261E0", VA = "0x1820279E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public int OCFNMJDHPOG
	{
		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A8700", VA = "0x1808A9F00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public bool IGCDHJBKAGA
	{
		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0x24E8B70", Offset = "0x24E7370", VA = "0x1824E8B70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007CD")]
	[Cpp2IlInjected.Address(RVA = "0x24E8BF0", Offset = "0x24E73F0", VA = "0x1824E8BF0")]
	public IAPFIKFHMGA(ComponentType JHKLCDEPMAD, JobHandle BJJHADPHPJP, NativeList<Entity> KFLBCCAJFMN, NativeList<Entity> OCANPGEGOGE, NativeList<byte> GCJDDKCFMIL, NativeList<byte> DIHNMGAABHM, NativeList<byte> NGPHHBJBHDA, int ILIJGNGONLE, int HJLDFBDBBHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CE")]
	[Cpp2IlInjected.Address(RVA = "0x24E8A50", Offset = "0x24E7250", VA = "0x1824E8A50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
public abstract class BGBMHAFAPMG : NHLEGKPBPCC
{
	[Cpp2IlInjected.Token(Token = "0x4000426")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	protected virtual NDPOFJCDFMI ADHEGNDHFGH
	{
		[Cpp2IlInjected.Token(Token = "0x60007CF")]
		[Cpp2IlInjected.Address(RVA = "0x893100", Offset = "0x891900", VA = "0x180893100", Slot = "14")]
		get
		{
			return default(NDPOFJCDFMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	protected virtual NDPOFJCDFMI HGPICIBJGHD
	{
		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0x7F0C80", Offset = "0x7EF480", VA = "0x1807F0C80", Slot = "15")]
		get
		{
			return default(NDPOFJCDFMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007D1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract void PJIINLOACPM(NDPOFJCDFMI MNJCDKNLLPF);

	[Cpp2IlInjected.Token(Token = "0x60007D2")]
	[Cpp2IlInjected.Address(RVA = "0x289A870", Offset = "0x2899070", VA = "0x18289A870", Slot = "13")]
	protected sealed override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D3")]
	[Cpp2IlInjected.Address(RVA = "0x289A810", Offset = "0x2899010", VA = "0x18289A810")]
	private NDPOFJCDFMI HOJAFNDLCOI()
	{
		return default(NDPOFJCDFMI);
	}

	[Cpp2IlInjected.Token(Token = "0x60007D4")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	protected BGBMHAFAPMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
[HHKHACIGOAG(JLEAEANKKDG.LoadInstance)]
[ANLOEBHPLMF(typeof(MEGBGGHIJBE))]
[KHNAILLFHGJ(typeof(CPPOLCLDFAK), new string[] { })]
public class CPPOLCLDFAK : MEGBGGHIJBE, NOFCHOCEBPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	private struct KNNLBEALNDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public JEPLFFFAMKN JLNFKJGPCCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public Type EIOLDDJPDLH;
	}

	[Cpp2IlInjected.Token(Token = "0x200013E")]
	private struct CICLJFNFBCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public KNNLBEALNDP[] LAEPKFGACAO;
	}

	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[BurstCompile]
	private struct EMJMIEBMBMN : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		[ReadOnly]
		public NativeArray<byte> BCCNGPPPKIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		[ReadOnly]
		public NativeArray<Entity> KNDIFEJKAFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		[ReadOnly]
		public NativeArray<byte> ECAILIHLHLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		[ReadOnly]
		public NativeArray<byte> GBPKAAHIBMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		[WriteOnly]
		public NativeList<Entity> GLOMBGPJOOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		[WriteOnly]
		public NativeList<byte> DEHIFKCIHIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		[WriteOnly]
		public NativeList<byte> GDFLFLJDPPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public int GJHOLAKOCKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public int BACOCPKBCBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public int JKKKDFKHGJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public int FKCGGOALIOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public int HBDINHMKIOL;

		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0x222C460", Offset = "0x222AC60", VA = "0x18222C460", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400042A")]
	private readonly Dictionary<LLNAAGHGEOA, JEPLFFFAMKN> DDFBDLEJFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400042B")]
	private readonly Dictionary<int, CICLJFNFBCK> CJGGGBBHICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400042C")]
	private NHLFCCPGHPO LAEPKFGACAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400042D")]
	private HMBELPNBOEG LNJHNPCFKIL;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action LHCGJLIMDBK
	{
		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0x28AAB10", Offset = "0x28A9310", VA = "0x1828AAB10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(RVA = "0x28AB6E0", Offset = "0x28A9EE0", VA = "0x1828AB6E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action BMDFIMAMJFP
	{
		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x28AB390", Offset = "0x28A9B90", VA = "0x1828AB390")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60007D9")]
		[Cpp2IlInjected.Address(RVA = "0x28AB780", Offset = "0x28A9F80", VA = "0x1828AB780")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007DA")]
	[Cpp2IlInjected.Address(RVA = "0x28AB430", Offset = "0x28A9C30", VA = "0x1828AB430", Slot = "6")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0x28AABB0", Offset = "0x28A93B0", VA = "0x1828AABB0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DC")]
	[Cpp2IlInjected.Address(RVA = "0x28AB590", Offset = "0x28A9D90", VA = "0x1828AB590", Slot = "4")]
	public void JACMNDDEBJP(FKFIIEPBNGA OPCEAOKDBMJ, JEPLFFFAMKN LKAHNEAJLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DD")]
	[Cpp2IlInjected.Address(RVA = "0x28AADC0", Offset = "0x28A95C0", VA = "0x1828AADC0", Slot = "5")]
	public void GCELDLHNPGC(FKFIIEPBNGA OPCEAOKDBMJ, JEPLFFFAMKN LKAHNEAJLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0x28AB4A0", Offset = "0x28A9CA0", VA = "0x1828AB4A0", Slot = "8")]
	public void JACMNDDEBJP(LLNAAGHGEOA BAAPPBDHEJN, JEPLFFFAMKN JJFOLBCEJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DF")]
	[Cpp2IlInjected.Address(RVA = "0x28AAF10", Offset = "0x28A9710", VA = "0x1828AAF10", Slot = "9")]
	public void GCELDLHNPGC(LLNAAGHGEOA BAAPPBDHEJN, JEPLFFFAMKN JJFOLBCEJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E0")]
	[Cpp2IlInjected.Address(RVA = "0x28AC360", Offset = "0x28AAB60", VA = "0x1828AC360")]
	private void OLLFBEFDBPD(LLNAAGHGEOA BAAPPBDHEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E1")]
	[Cpp2IlInjected.Address(RVA = "0x28AC120", Offset = "0x28AA920", VA = "0x1828AC120")]
	internal void LGHODPNPIBP(DCDCMCEDILM COOBJCJFHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E2")]
	[Cpp2IlInjected.Address(RVA = "0x28AB820", Offset = "0x28AA020", VA = "0x1828AB820")]
	private void KFEJNHJENCM(DCDCMCEDILM COOBJCJFHEP, int KFGBCCEFCMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E3")]
	[Cpp2IlInjected.Address(RVA = "0x28AB120", Offset = "0x28A9920", VA = "0x1828AB120")]
	private void HKGCABBDALM(BLECIIOHDPI GDMDACGBKDC, BMPCFGMBEIA ADBBMIJDPBG, KNNLBEALNDP EPCDJAMBIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E4")]
	[Cpp2IlInjected.Address(RVA = "0x28AAC40", Offset = "0x28A9440", VA = "0x1828AAC40")]
	private CICLJFNFBCK EFOKFFPNMJI(BLECIIOHDPI GDMDACGBKDC, BMPCFGMBEIA ADBBMIJDPBG)
	{
		return default(CICLJFNFBCK);
	}

	[Cpp2IlInjected.Token(Token = "0x60007E5")]
	[Cpp2IlInjected.Address(RVA = "0x28AB030", Offset = "0x28A9830", VA = "0x1828AB030")]
	private KNNLBEALNDP GEAIKKGENIM(CICLJFNFBCK KMILPECLOGP, BLECIIOHDPI GDMDACGBKDC, BMPCFGMBEIA ADBBMIJDPBG)
	{
		return default(KNNLBEALNDP);
	}

	[Cpp2IlInjected.Token(Token = "0x60007E6")]
	[Cpp2IlInjected.Address(RVA = "0x28AC540", Offset = "0x28AAD40", VA = "0x1828AC540")]
	public CPPOLCLDFAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000140")]
internal class FGAJMJOKJCN : PEPJPPPDFOK
{
	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	protected override HPOKAOBOIJC KKFMLANCONK
	{
		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0x7F0C80", Offset = "0x7EF480", VA = "0x1807F0C80", Slot = "17")]
		get
		{
			return default(HPOKAOBOIJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007EA")]
	[Cpp2IlInjected.Address(RVA = "0x2C77100", Offset = "0x2C75900", VA = "0x182C77100")]
	public FGAJMJOKJCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
public class DBALDKBMBKH : NHLEGKPBPCC
{
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[BurstCompile]
	private struct LNEJNPIOILP : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		[ReadOnly]
		public ComponentTypeHandle<HGFAFHFDBHB> GKPNENPICOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		[ReadOnly]
		public BufferTypeHandle<OEOKFMKAJDD> DKGJLABBNKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		[ReadOnly]
		public BufferFromEntity<OEOKFMKAJDD> KHLHMOGDMON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		[ReadOnly]
		public ComponentDataFromEntity<HGFAFHFDBHB> DHBGIHLABBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public ComponentTypeHandle<BGNDJFIJAFN> NKGIHMMJOED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		[NativeDisableContainerSafetyRestriction]
		public ComponentDataFromEntity<BGNDJFIJAFN> BPLMEKKIGBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public uint EOFDFPDHALO;

		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0x2233700", Offset = "0x2231F00", VA = "0x182233700", Slot = "4")]
		public void Execute(ArchetypeChunk OPMNIAACDHI, int AMOEKOMGDLG, int LAFKFNODOKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0x22332F0", Offset = "0x2231AF0", VA = "0x1822332F0")]
		private void DJBBPIKEABC(float4x4 IPCGCLBEKME, Entity AJDEFAPHMKF, bool IDNELOPIEMK, int HKIFENONMMH = 1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	private EntityQuery IJKOLJJAOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400043F")]
	private EntityQuery AOJOOFCFMBK;

	[Cpp2IlInjected.Token(Token = "0x60007EB")]
	[Cpp2IlInjected.Address(RVA = "0x2C66980", Offset = "0x2C65180", VA = "0x182C66980", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EC")]
	[Cpp2IlInjected.Address(RVA = "0x2C66AA0", Offset = "0x2C652A0", VA = "0x182C66AA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007ED")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public DBALDKBMBKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000143")]
[GCAKKMGPAEI]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
public class IBPNBODMDOK : NHLEGKPBPCC, PCAPGPPECJN, NOFCHOCEBPC
{
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[BurstCompile]
	private struct GCHAEKOEEID : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		[ReadOnly]
		public EntityTypeHandle KNDIFEJKAFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		[ReadOnly]
		public ComponentTypeHandle<OGGLOODKLFP> JLBMOBAMGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		[WriteOnly]
		public NativeList<CHFHHLLDIJI>.ParallelWriter DJKFOMBHEJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public ComponentTypeHandle<ALJAHJLEEEH> KEALEKLKNMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public float3 BEELAINJGPH;

		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private static readonly float4x2 IKLNIKCEDND;

		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private static readonly float4x2 HGDKMAIILNO;

		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private static readonly int4x2 CHHFAIJFFNN;

		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0x222D8A0", Offset = "0x222C0A0", VA = "0x18222D8A0", Slot = "4")]
		public void Execute(ArchetypeChunk OPMNIAACDHI, int LEMMIPLDDBE, int FFOHIDMPEPK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	private static JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000448")]
	private EntityQuery CCGJMDNALMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000449")]
	private EntityQuery GNJMKFOMONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400044A")]
	private double MIDHINCKEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400044B")]
	private NAHGLKOIEAI BOBHLPNKBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400044C")]
	private FFHJPFHDABG JPEBDJJCNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400044D")]
	private CKKBDPJEFPP AHBAIFGILLP;

	[Cpp2IlInjected.Token(Token = "0x60007F1")]
	[Cpp2IlInjected.Address(RVA = "0x24E9390", Offset = "0x24E7B90", VA = "0x1824E9390", Slot = "14")]
	public void PAHLDMJMCEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F2")]
	[Cpp2IlInjected.Address(RVA = "0x24E8FB0", Offset = "0x24E77B0", VA = "0x1824E8FB0", Slot = "15")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F3")]
	[Cpp2IlInjected.Address(RVA = "0x24E9040", Offset = "0x24E7840", VA = "0x1824E9040", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F4")]
	[Cpp2IlInjected.Address(RVA = "0x24E9190", Offset = "0x24E7990", VA = "0x1824E9190", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F5")]
	[Cpp2IlInjected.Address(RVA = "0x24E8C50", Offset = "0x24E7450", VA = "0x1824E8C50")]
	private bool CNJAKPHPLKP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007F6")]
	[Cpp2IlInjected.Address(RVA = "0x24E8CC0", Offset = "0x24E74C0", VA = "0x1824E8CC0")]
	private void HFDDCJFDMNE(EntityQuery EGFJCKOAGFH, float3 MGEBHGBPDJN, string MDOAADHDBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F7")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public IBPNBODMDOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
[CHALNEEBFJF(typeof(KPDEPPFNAGM))]
[KHNAILLFHGJ(typeof(LGNMGLONHCC), new string[] { })]
public class DCHMCCFHCKJ : LGNMGLONHCC, PCAPGPPECJN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000456")]
	private readonly Dictionary<int, ADGLENNGCHF> GDHLOIJPMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000457")]
	private readonly Dictionary<Type, ADGLENNGCHF> MCKMLMOBHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000458")]
	private readonly Dictionary<Type, ADGLENNGCHF> EMOGGMJBONH;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public IReadOnlyCollection<ADGLENNGCHF> EFMMGHNDFLM
	{
		[Cpp2IlInjected.Token(Token = "0x60007FB")]
		[Cpp2IlInjected.Address(RVA = "0x2C672F0", Offset = "0x2C65AF0", VA = "0x182C672F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007FC")]
	[Cpp2IlInjected.Address(RVA = "0x2C67340", Offset = "0x2C65B40", VA = "0x182C67340", Slot = "7")]
	public void PAHLDMJMCEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FD")]
	[Cpp2IlInjected.Address(RVA = "0x2C67270", Offset = "0x2C65A70", VA = "0x182C67270", Slot = "6")]
	public ADGLENNGCHF HFFOKKPLPBC(Type EIOLDDJPDLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007FE")]
	[Cpp2IlInjected.Address(RVA = "0x2C67200", Offset = "0x2C65A00", VA = "0x182C67200", Slot = "5")]
	public bool EIKFILDIBOC(int KFGBCCEFCMB, out ADGLENNGCHF LAEPKFGACAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FF")]
	[Cpp2IlInjected.Address(RVA = "0x2C671B0", Offset = "0x2C659B0", VA = "0x182C671B0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000800")]
	[Cpp2IlInjected.Address(RVA = "0x2C675E0", Offset = "0x2C65DE0", VA = "0x182C675E0")]
	public DCHMCCFHCKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
internal class HKNCKIHOIOG : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000459")]
	private EntityQuery EGFJCKOAGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400045A")]
	private NAHGLKOIEAI BOBHLPNKBHC;

	[Cpp2IlInjected.Token(Token = "0x6000801")]
	[Cpp2IlInjected.Address(RVA = "0x24E7200", Offset = "0x24E5A00", VA = "0x1824E7200", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000802")]
	[Cpp2IlInjected.Address(RVA = "0x24E7780", Offset = "0x24E5F80", VA = "0x1824E7780", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000803")]
	[Cpp2IlInjected.Address(RVA = "0x24E7830", Offset = "0x24E6030", VA = "0x1824E7830", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000804")]
	[Cpp2IlInjected.Address(RVA = "0x24E7250", Offset = "0x24E5A50", VA = "0x1824E7250")]
	private void OBDPHNAHHKN(NativeArray<Entity> KFLBCCAJFMN, NativeList<Entity> HHIFIGGPHPH, ComponentDataFromEntity<PHOIHECODLB> NFJMOGCFGBP, BufferFromEntity<OEOKFMKAJDD> BOEPOIGMOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000805")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public HKNCKIHOIOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
public class OEFFFDFDEKK : NHLEGKPBPCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400045B")]
	private EntityQuery EGFJCKOAGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400045C")]
	private BEANJBEKLGM KFAEBKFHHLM;

	[Cpp2IlInjected.Token(Token = "0x6000806")]
	[Cpp2IlInjected.Address(RVA = "0x293B950", Offset = "0x293A150", VA = "0x18293B950", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000807")]
	[Cpp2IlInjected.Address(RVA = "0x293BA20", Offset = "0x293A220", VA = "0x18293BA20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000808")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public OEFFFDFDEKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
public static class MMGLHBHDKNG
{
	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly DGHCNLKFLNE KOBGPAMELOJ;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly DGHCNLKFLNE PLFAPMCFEOC;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly DGHCNLKFLNE OGJDDOBHDNO;
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
public class MGKHOLLEGJN : NHLEGKPBPCC
{
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[BurstCompile]
	private struct GHHDCAOHPML : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		[ReadOnly]
		public ComponentTypeHandle<PMHMNKDEJIA> CLLLGEINLAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		[ReadOnly]
		public ComponentTypeHandle<DIABMIKHCMI> LCAIONOJMKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		[ReadOnly]
		public ComponentTypeHandle<MEJJCGNBFDD> OJDNHEMFABA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public ComponentTypeHandle<HGFAFHFDBHB> CFGHHNNPPCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public uint EOFDFPDHALO;

		[Cpp2IlInjected.Token(Token = "0x600080D")]
		[Cpp2IlInjected.Address(RVA = "0x222DEC0", Offset = "0x222C6C0", VA = "0x18222DEC0", Slot = "4")]
		public void Execute(ArchetypeChunk OPMNIAACDHI, int AMOEKOMGDLG, int LAFKFNODOKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0x222DDC0", Offset = "0x222C5C0", VA = "0x18222DDC0")]
		public bool BDINEGGJLMH(ArchetypeChunk OPMNIAACDHI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000460")]
	private EntityQuery MFHEANKMMCA;

	[Cpp2IlInjected.Token(Token = "0x600080A")]
	[Cpp2IlInjected.Address(RVA = "0x292A260", Offset = "0x2928A60", VA = "0x18292A260", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080B")]
	[Cpp2IlInjected.Address(RVA = "0x292A390", Offset = "0x2928B90", VA = "0x18292A390", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080C")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public MGKHOLLEGJN()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	internal class PostDeserializeSortSplinePoints : NHLEGKPBPCC
	{
		[Cpp2IlInjected.Token(Token = "0x200014C")]
		private struct OrderComparer : IComparer<Entity>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			[ReadOnly]
			public ComponentDataFromEntity<HJFDLKKNMEJ> orderRO;

			[Cpp2IlInjected.Token(Token = "0x6000813")]
			[Cpp2IlInjected.Address(RVA = "0x2236A10", Offset = "0x2235210", VA = "0x182236A10", Slot = "4")]
			public int Compare(Entity x, Entity y)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200014D")]
		[NoAlias]
		[BurstCompile]
		private struct PostDeserializeSortSplinePoints_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			public OrderComparer comparer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			[ReadOnly]
			public EntityTypeHandle __splineTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			public BufferTypeHandle<LinkedEntityGroup> __bufferTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000814")]
			[Cpp2IlInjected.Address(RVA = "0x2238310", Offset = "0x2236B10", VA = "0x182238310")]
			private void BNHOJHOEIPF(Entity spline, DynamicBuffer<LinkedEntityGroup> buffer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000815")]
			[Cpp2IlInjected.Address(RVA = "0x22383A0", Offset = "0x2236BA0", VA = "0x1822383A0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		private EntityQuery PostDeserializeSortSplinePoints_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private EntityQuery __query_1;

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x22C82A0", Offset = "0x22C6AA0", VA = "0x1822C82A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x22C7E30", Offset = "0x22C6630", VA = "0x1822C7E30")]
		private void NLJHKIJJFOL(OrderComparer comparer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x22C7F60", Offset = "0x22C6760", VA = "0x1822C7F60", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
		public PostDeserializeSortSplinePoints()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
public static class CICEKNFDMIA
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	public interface LCADOJGBOPP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000150")]
	public interface JGNBJAKJHDD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000151")]
	public class HJCBKINLFPJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000152")]
	public class PJHCGCCJMOC : JGNBJAKJHDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0x2237830", Offset = "0x2236030", VA = "0x182237830")]
		public PJHCGCCJMOC(ComponentType ODHKMJMLAIP, ComponentType BALKHJPBNMP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000153")]
	public class JFNEDKAAOJE : JGNBJAKJHDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0x2231230", Offset = "0x222FA30", VA = "0x182231230")]
		public JFNEDKAAOJE(ComponentType ODHKMJMLAIP, ComponentType[] BALKHJPBNMP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000154")]
	public class LHNPHNANLLJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000816")]
	[Cpp2IlInjected.Address(RVA = "0x2D8E640", Offset = "0x2D8CE40", VA = "0x182D8E640")]
	public static JGNBJAKJHDD GCKJENMEFPK<TFrom, TTo>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000817")]
	[Cpp2IlInjected.Address(RVA = "0x2D8E540", Offset = "0x2D8CD40", VA = "0x182D8E540")]
	public static JGNBJAKJHDD EPGJENJAHIK<TFrom>(params ComponentType[] PPOOPCLIJJG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000155")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
[KHNAILLFHGJ(typeof(KMFOAMJFLAH), new string[] { })]
internal sealed class KMFOAMJFLAH : NOFCHOCEBPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000470")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000471")]
	[NAAJCOHOAKA]
	private ILBBGIPPPPJ KFELNFLBJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000472")]
	private LDDHDDLKFEJ CKMMOGKGLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000473")]
	private BCHGJDMLGML OENKMBFNEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000474")]
	private bool PMADFOMNIPK;

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	private EntityManager EOOAJAELBGN
	{
		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(RVA = "0x25023E0", Offset = "0x2500BE0", VA = "0x1825023E0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<MDHHOEPMEJH, NativeArray<KECBEHOHBCN>> NMCOOHJJDEP
	{
		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x25029C0", Offset = "0x25011C0", VA = "0x1825029C0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0x2501BE0", Offset = "0x25003E0", VA = "0x182501BE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<MDHHOEPMEJH> POBNPMAMCEI
	{
		[Cpp2IlInjected.Token(Token = "0x600081C")]
		[Cpp2IlInjected.Address(RVA = "0x2502700", Offset = "0x2500F00", VA = "0x182502700")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600081D")]
		[Cpp2IlInjected.Address(RVA = "0x2501EA0", Offset = "0x25006A0", VA = "0x182501EA0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600081F")]
	[Cpp2IlInjected.Address(RVA = "0x25025B0", Offset = "0x2500DB0", VA = "0x1825025B0", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000820")]
	[Cpp2IlInjected.Address(RVA = "0x123D780", Offset = "0x123BF80", VA = "0x18123D780", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000821")]
	[Cpp2IlInjected.Address(RVA = "0x2502A60", Offset = "0x2501260", VA = "0x182502A60")]
	public bool PINCLHPNEDE(Entity AJDEFAPHMKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000822")]
	[Cpp2IlInjected.Address(RVA = "0x25026C0", Offset = "0x2500EC0", VA = "0x1825026C0")]
	public void JBIKODGILBE(Entity AJDEFAPHMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000823")]
	[Cpp2IlInjected.Address(RVA = "0x2501910", Offset = "0x2500110", VA = "0x182501910")]
	public void BOEMJIGNDMG(Entity AJDEFAPHMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000824")]
	[Cpp2IlInjected.Address(RVA = "0x25017F0", Offset = "0x24FFFF0", VA = "0x1825017F0")]
	private bool ADBGHJLHGFH(Entity AJDEFAPHMKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000825")]
	[Cpp2IlInjected.Address(RVA = "0x25019E0", Offset = "0x25001E0", VA = "0x1825019E0")]
	public void CLOOKKNDFON(Entity AJDEFAPHMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000826")]
	[Cpp2IlInjected.Address(RVA = "0x2502800", Offset = "0x2501000", VA = "0x182502800")]
	private bool NIIMKFEHCNL(Entity AJDEFAPHMKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000827")]
	[Cpp2IlInjected.Address(RVA = "0x2502430", Offset = "0x2500C30", VA = "0x182502430")]
	public void IKDLJOMDIEB(Entity AJDEFAPHMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000828")]
	[Cpp2IlInjected.Address(RVA = "0x25027A0", Offset = "0x2500FA0", VA = "0x1825027A0")]
	private void MBFMGDOKJDK(Entity AJDEFAPHMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000829")]
	[Cpp2IlInjected.Address(RVA = "0x2501C80", Offset = "0x2500480", VA = "0x182501C80")]
	private void DJLCKHGLPCH(Entity AJDEFAPHMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082A")]
	[Cpp2IlInjected.Address(RVA = "0x2502660", Offset = "0x2500E60", VA = "0x182502660")]
	private void JAJMNLKPIML(Entity AJDEFAPHMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082B")]
	[Cpp2IlInjected.Address(RVA = "0x2501F40", Offset = "0x2500740", VA = "0x182501F40")]
	private void FOICBJLDDEF(Entity AJDEFAPHMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082C")]
	[Cpp2IlInjected.Address(RVA = "0x2501960", Offset = "0x2500160", VA = "0x182501960")]
	public void CBHOKIJEEJL(MDHHOEPMEJH NJCFCNKMPKG, NativeArray<KECBEHOHBCN> PGDPKHFFBIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082D")]
	[Cpp2IlInjected.Address(RVA = "0x2502540", Offset = "0x2500D40", VA = "0x182502540")]
	public void IOOLAMKKNHN(MDHHOEPMEJH NJCFCNKMPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082E")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	private void GCBAOBMNNJM(Entity AJDEFAPHMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082F")]
	[Cpp2IlInjected.Address(RVA = "0x25021E0", Offset = "0x25009E0", VA = "0x1825021E0")]
	private void GBDHFBLCFLL(Entity AJDEFAPHMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000830")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public KMFOAMJFLAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
public class OCHAEPHBIKE : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000477")]
	private EntityQuery FBPGLPCENEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000478")]
	private EntityQuery EABJLOIKJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000479")]
	private EntityQuery GONGJNNNGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400047A")]
	private EntityQuery AJLDHDGBHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400047B")]
	private LDDHDDLKFEJ NNEBLIDBPFE;

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public int MIHIIMNHEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0x293B8F0", Offset = "0x293A0F0", VA = "0x18293B8F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000833")]
	[Cpp2IlInjected.Address(RVA = "0x293B2B0", Offset = "0x2939AB0", VA = "0x18293B2B0", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000834")]
	[Cpp2IlInjected.Address(RVA = "0x293B500", Offset = "0x2939D00", VA = "0x18293B500", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000835")]
	[Cpp2IlInjected.Address(RVA = "0x293B700", Offset = "0x2939F00", VA = "0x18293B700", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000836")]
	[Cpp2IlInjected.Address(RVA = "0x293B380", Offset = "0x2939B80", VA = "0x18293B380")]
	public int LCJGHNBLMMC(SceneTag JJIAFDKCLGJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000837")]
	[Cpp2IlInjected.Address(RVA = "0x293B720", Offset = "0x2939F20", VA = "0x18293B720")]
	protected void PFHLHBHKOPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000838")]
	[Cpp2IlInjected.Address(RVA = "0x293B3A0", Offset = "0x2939BA0", VA = "0x18293B3A0")]
	protected void MAEDIOEOLIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000839")]
	[Cpp2IlInjected.Address(RVA = "0x293B110", Offset = "0x2939910", VA = "0x18293B110")]
	public NativeArrayAsync<Entity> DHLPCDLFDLO(SceneTag JJIAFDKCLGJ, Allocator HMGEFCKKBID = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600083A")]
	[Cpp2IlInjected.Address(RVA = "0x293B900", Offset = "0x293A100", VA = "0x18293B900")]
	public NativeArrayAsync<Entity> PLEFKECJAPA(SceneTag JJIAFDKCLGJ, Allocator HMGEFCKKBID = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600083B")]
	[Cpp2IlInjected.Address(RVA = "0x293B1C0", Offset = "0x29399C0", VA = "0x18293B1C0")]
	public bool EDBLGHAPNDL(SceneTag JJIAFDKCLGJ, out NativeArrayAsync<Entity> CKMMOGKGLFH, Allocator HMGEFCKKBID = Allocator.TempJob)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600083C")]
	[Cpp2IlInjected.Address(RVA = "0x293B250", Offset = "0x2939A50", VA = "0x18293B250")]
	public bool IGAMJDGIHFK(Entity AJDEFAPHMKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600083D")]
	[Cpp2IlInjected.Address(RVA = "0x293B310", Offset = "0x2939B10", VA = "0x18293B310")]
	public bool JLOABAPGJKJ(Entity AJDEFAPHMKF, out FBINHHLEGLD CKMMOGKGLFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600083E")]
	[Cpp2IlInjected.Address(RVA = "0x293B4C0", Offset = "0x2939CC0", VA = "0x18293B4C0")]
	public void OPPHIIHOLFA(Entity AJDEFAPHMKF, FBINHHLEGLD CKMMOGKGLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083F")]
	[Cpp2IlInjected.Address(RVA = "0x293B160", Offset = "0x2939960", VA = "0x18293B160")]
	public bool DPKJMBHJIOC(Entity AJDEFAPHMKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000840")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public OCHAEPHBIKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000157")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
[KHNAILLFHGJ(typeof(GHNAAIGKIGD), new string[] { })]
internal sealed class GHNAAIGKIGD
{
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	public enum EECKKJLLGKC
	{
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		Gameplay,
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		ObjectModel
	}

	[Cpp2IlInjected.Token(Token = "0x2000159")]
	public struct HLPGPHFBFLH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private EECKKJLLGKC EJCNEHJIDKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private readonly GHNAAIGKIGD GJPBCFJDGCH;

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0x222FBE0", Offset = "0x222E3E0", VA = "0x18222FBE0")]
		public HLPGPHFBFLH(GHNAAIGKIGD GJPBCFJDGCH, EECKKJLLGKC PODDIAOEGNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0x222FBB0", Offset = "0x222E3B0", VA = "0x18222FBB0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public EECKKJLLGKC PODDIAOEGNA;

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public EECKKJLLGKC KKLKOFJJDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000841")]
		[Cpp2IlInjected.Address(RVA = "0x7DF240", Offset = "0x7DDA40", VA = "0x1807DF240")]
		get
		{
			return default(EECKKJLLGKC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0xBE1D20", Offset = "0xBE0520", VA = "0x180BE1D20")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public bool BBOLNFBKIDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000843")]
		[Cpp2IlInjected.Address(RVA = "0x24ADC40", Offset = "0x24AC440", VA = "0x1824ADC40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000844")]
	[Cpp2IlInjected.Address(RVA = "0x2C7E0E0", Offset = "0x2C7C8E0", VA = "0x182C7E0E0")]
	public HLPGPHFBFLH AHAIBPPEKLN()
	{
		return default(HLPGPHFBFLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000845")]
	[Cpp2IlInjected.Address(RVA = "0x2C7E110", Offset = "0x2C7C910", VA = "0x182C7E110")]
	public HLPGPHFBFLH PDEFIFDJGEH()
	{
		return default(HLPGPHFBFLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000846")]
	[Cpp2IlInjected.Address(RVA = "0x122BAF0", Offset = "0x122A2F0", VA = "0x18122BAF0")]
	public GHNAAIGKIGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal readonly struct OJMEFLPLNAM
{
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	private static readonly ProfilerMarker AJAJOBDBGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000485")]
	private readonly NHLEGKPBPCC EDPKAJCAKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000486")]
	private readonly World LDJNMODKEPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000487")]
	private readonly EntityQuery IGCMMEABHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000488")]
	private readonly EntityQuery KBDCNJBDHNC;

	[Cpp2IlInjected.Token(Token = "0x600084A")]
	[Cpp2IlInjected.Address(RVA = "0x293DC80", Offset = "0x293C480", VA = "0x18293DC80")]
	public OJMEFLPLNAM(NHLEGKPBPCC EDPKAJCAKAA, World LDJNMODKEPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084B")]
	[Cpp2IlInjected.Address(RVA = "0x293D630", Offset = "0x293BE30", VA = "0x18293D630")]
	public NativeArray<MHGAJIKGEGE> DNNKNEBJAJP()
	{
		return default(NativeArray<MHGAJIKGEGE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600084C")]
	[Cpp2IlInjected.Address(RVA = "0x293DB50", Offset = "0x293C350", VA = "0x18293DB50")]
	public void LNGCHJJKDII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084D")]
	[Cpp2IlInjected.Address(RVA = "0x293D740", Offset = "0x293BF40", VA = "0x18293D740")]
	private NativeArray<MHGAJIKGEGE> LCEFAGCAIBN(EntityQuery EGFJCKOAGFH)
	{
		return default(NativeArray<MHGAJIKGEGE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200015B")]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
internal sealed class NAGCAHCGICI : GJJADNOGMIL
{
	[Cpp2IlInjected.Token(Token = "0x600084F")]
	[Cpp2IlInjected.Address(RVA = "0x292C770", Offset = "0x292AF70", VA = "0x18292C770", Slot = "15")]
	protected override ComponentSystemBase CMFPJFIFJLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000850")]
	[Cpp2IlInjected.Address(RVA = "0x22BD2C0", Offset = "0x22BBAC0", VA = "0x1822BD2C0")]
	public NAGCAHCGICI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal class DJAEHLGAEDD : HEGFKOOIJBF
{
	[Cpp2IlInjected.Token(Token = "0x6000851")]
	[Cpp2IlInjected.Address(RVA = "0x22BD2C0", Offset = "0x22BBAC0", VA = "0x1822BD2C0")]
	public DJAEHLGAEDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015D")]
internal class OHOHJKAOPLF : HEGFKOOIJBF
{
	[Cpp2IlInjected.Token(Token = "0x6000852")]
	[Cpp2IlInjected.Address(RVA = "0x22BD2C0", Offset = "0x22BBAC0", VA = "0x1822BD2C0")]
	public OHOHJKAOPLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal struct EHLOJPGEKBN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public int JNDMMPHMODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public int IHOKMDEGNLH;
}
[Cpp2IlInjected.Token(Token = "0x200015F")]
public class FJIPMDMPKMA : ParentSystemBase<NBHKLDPKGLO, JMCPPLBMCKC, OCNLGAFGIKO>
{
	[Cpp2IlInjected.Token(Token = "0x6000853")]
	[Cpp2IlInjected.Address(RVA = "0x2C78BB0", Offset = "0x2C773B0", VA = "0x182C78BB0", Slot = "14")]
	protected override EntityQueryDesc HHDIEBNJPNI(EntityQueryDesc EGFJCKOAGFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000854")]
	[Cpp2IlInjected.Address(RVA = "0xA43800", Offset = "0xA42000", VA = "0x180A43800", Slot = "15")]
	protected override EntityQueryDesc OIKCAAPELJM(EntityQueryDesc EGFJCKOAGFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0x2C78BF0", Offset = "0x2C773F0", VA = "0x182C78BF0", Slot = "16")]
	protected override EntityQueryDesc PKLNOMEPJCH(EntityQueryDesc EGFJCKOAGFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000856")]
	[Cpp2IlInjected.Address(RVA = "0x2C78B70", Offset = "0x2C77370", VA = "0x182C78B70", Slot = "17")]
	protected override EntityQueryDesc AFCIKCANODJ(EntityQueryDesc EGFJCKOAGFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000857")]
	[Cpp2IlInjected.Address(RVA = "0x2C78C30", Offset = "0x2C77430", VA = "0x182C78C30")]
	public FJIPMDMPKMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000160")]
internal class BDNHDFFCICN : FFGKGHJCIFC
{
	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	protected override DGHCNLKFLNE JAJKCIDCJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000858")]
		[Cpp2IlInjected.Address(RVA = "0x289A780", Offset = "0x2898F80", VA = "0x18289A780", Slot = "15")]
		get
		{
			return default(DGHCNLKFLNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000859")]
	[Cpp2IlInjected.Address(RVA = "0x289A800", Offset = "0x2899000", VA = "0x18289A800")]
	public BDNHDFFCICN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000161")]
public sealed class GOFDNLPLHFO : GJJADNOGMIL
{
	[Cpp2IlInjected.Token(Token = "0x600085A")]
	[Cpp2IlInjected.Address(RVA = "0x2C81EB0", Offset = "0x2C806B0", VA = "0x182C81EB0", Slot = "15")]
	protected override ComponentSystemBase CMFPJFIFJLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600085B")]
	[Cpp2IlInjected.Address(RVA = "0x22BD2C0", Offset = "0x22BBAC0", VA = "0x1822BD2C0")]
	public GOFDNLPLHFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
[ExecuteAlways]
public class PDLJPKAOHFF : BBADPFDDMLN
{
	[Cpp2IlInjected.Token(Token = "0x600085C")]
	[Cpp2IlInjected.Address(RVA = "0x97A870", Offset = "0x979070", VA = "0x18097A870")]
	public PDLJPKAOHFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
public class HAIHPCMHBAL : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.Token(Token = "0x400048B")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400048C")]
	private EntityQuery DLCBCNCECAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400048D")]
	private EntityQuery OLLKPMHEIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400048E")]
	private EntityQuery OOLAOIDAAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400048F")]
	private EntityQuery KEMGKKGCHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	private NAHGLKOIEAI BOBHLPNKBHC;

	[Cpp2IlInjected.Token(Token = "0x600085D")]
	[Cpp2IlInjected.Address(RVA = "0x24E37D0", Offset = "0x24E1FD0", VA = "0x1824E37D0", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085E")]
	[Cpp2IlInjected.Address(RVA = "0x24E3B30", Offset = "0x24E2330", VA = "0x1824E3B30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085F")]
	[Cpp2IlInjected.Address(RVA = "0x24E3D60", Offset = "0x24E2560", VA = "0x1824E3D60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000860")]
	[Cpp2IlInjected.Address(RVA = "0x24E3760", Offset = "0x24E1F60", VA = "0x1824E3760")]
	private void GLILACFFLBJ(EntityQuery EGFJCKOAGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000861")]
	[Cpp2IlInjected.Address(RVA = "0x24E36F0", Offset = "0x24E1EF0", VA = "0x1824E36F0")]
	private void FNJGHMKCCPI(EntityQuery EGFJCKOAGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000862")]
	[Cpp2IlInjected.Address(RVA = "0x24E3CF0", Offset = "0x24E24F0", VA = "0x1824E3CF0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000863")]
	[Cpp2IlInjected.Address(RVA = "0x24E3820", Offset = "0x24E2020", VA = "0x1824E3820")]
	private void KFPDLFMGKFL(EntityQuery EGFJCKOAGFH, bool LLMANHIAOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000864")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public HAIHPCMHBAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
public sealed class IDLMLCHCOAN : GJJADNOGMIL
{
	[Cpp2IlInjected.Token(Token = "0x6000866")]
	[Cpp2IlInjected.Address(RVA = "0x24EB630", Offset = "0x24E9E30", VA = "0x1824EB630", Slot = "15")]
	protected override ComponentSystemBase CMFPJFIFJLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000867")]
	[Cpp2IlInjected.Address(RVA = "0x22BD2C0", Offset = "0x22BBAC0", VA = "0x1822BD2C0")]
	public IDLMLCHCOAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
[KHNAILLFHGJ(typeof(BIHFLJCPNLK), new string[] { })]
[HHKHACIGOAG(JLEAEANKKDG.LoadInstance)]
internal sealed class BIHFLJCPNLK : NOFCHOCEBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000491")]
	private ILBBGIPPPPJ EJLFIBCCMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000492")]
	private GHNAAIGKIGD BNAPCKICLAH;

	[Cpp2IlInjected.Token(Token = "0x6000868")]
	[Cpp2IlInjected.Address(RVA = "0x289B0F0", Offset = "0x28998F0", VA = "0x18289B0F0", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000869")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public BIHFLJCPNLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
internal class JOIPEIKAADO : OJBJPKKIOND
{
	[Cpp2IlInjected.Token(Token = "0x17000100")]
	protected override DGHCNLKFLNE JAJKCIDCJIM
	{
		[Cpp2IlInjected.Token(Token = "0x600086A")]
		[Cpp2IlInjected.Address(RVA = "0x24F6D80", Offset = "0x24F5580", VA = "0x1824F6D80", Slot = "15")]
		get
		{
			return default(DGHCNLKFLNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600086B")]
	[Cpp2IlInjected.Address(RVA = "0x24E71F0", Offset = "0x24E59F0", VA = "0x1824E71F0")]
	public JOIPEIKAADO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
[KHNAILLFHGJ(typeof(BHNAPIGDOEG), new string[] { })]
internal class CBCIHEMOILI : BHNAPIGDOEG, NOFCHOCEBPC, NOHOJBNCAJC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private sealed class MHPIPKFJGGI : IEnumerable<LPLJHAHPEEF>, IEnumerable, IEnumerator<LPLJHAHPEEF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private LPLJHAHPEEF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private LPLJHAHPEEF localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public LPLJHAHPEEF <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public CBCIHEMOILI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private EntityManager <entityManager>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private LocalId <entity>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		private DynamicBuffer<OCNLGAFGIKO> <children>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private NativeArray<Entity> <childEntities>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private NativeArray<Entity> <childEntitiesCopy>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private NativeArray<Entity>.Enumerator <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private Entity <child>5__7;

		[Cpp2IlInjected.Token(Token = "0x17000102")]
		private LPLJHAHPEEF System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000891")]
			[Cpp2IlInjected.Address(RVA = "0xA64970", Offset = "0xA63170", VA = "0x180A64970", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(LPLJHAHPEEF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000893")]
			[Cpp2IlInjected.Address(RVA = "0x22354F0", Offset = "0x2233CF0", VA = "0x1822354F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0x21D5240", Offset = "0x21D3A40", VA = "0x1821D5240")]
		[DebuggerHidden]
		public MHPIPKFJGGI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x2235540", Offset = "0x2233D40", VA = "0x182235540", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0x2235010", Offset = "0x2233810", VA = "0x182235010", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x22353B0", Offset = "0x2233BB0", VA = "0x1822353B0")]
		private void PPLJHCFFCFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0x2235360", Offset = "0x2233B60", VA = "0x182235360")]
		private void OFDJPHBKOEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x22354B0", Offset = "0x2233CB0", VA = "0x1822354B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x2235400", Offset = "0x2233C00", VA = "0x182235400", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LPLJHAHPEEF> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0x2235400", Offset = "0x2233C00", VA = "0x182235400", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	private static readonly JNGNMMOLKFF GCIBBFJLCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000499")]
	private HMBELPNBOEG LNJHNPCFKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400049A")]
	private IKCMADHPPKE MFHEANKMMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400049B")]
	private ILBBGIPPPPJ EJLFIBCCMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	private NAHGLKOIEAI BOBHLPNKBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	private CPPOLCLDFAK DHLGLCIPIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	private NIJBLPDKGGM<Entity> MOMEDEPAJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	private NIJBLPDKGGM<float3> KOKLACKHIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	private NIJBLPDKGGM<quaternion> INMGGPNDBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	private NIJBLPDKGGM<float> FAIGPPJIGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	private NIJBLPDKGGM<Entity> GJPBCFJDGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	private NIJBLPDKGGM<float3> GGKJMICDBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	private NIJBLPDKGGM<quaternion> CCIFDEOEEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	private HashSet<Entity> HFFAFMGAKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	private HashSet<Entity> FGCJODOGALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	private EntityQuery GHCGCPGDCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	private bool PMADFOMNIPK;

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public Func<EOOBMMBDNHM> OHAMELLGPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000874")]
		[Cpp2IlInjected.Address(RVA = "0xA4DA40", Offset = "0xA4C240", VA = "0x180A4DA40", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000875")]
		[Cpp2IlInjected.Address(RVA = "0x8EFCF0", Offset = "0x8EE4F0", VA = "0x1808EFCF0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<LPLJHAHPEEF, LPLJHAHPEEF> GMNGANBOANE
	{
		[Cpp2IlInjected.Token(Token = "0x600086C")]
		[Cpp2IlInjected.Address(RVA = "0x28A2F80", Offset = "0x28A1780", VA = "0x1828A2F80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600086D")]
		[Cpp2IlInjected.Address(RVA = "0x28A1100", Offset = "0x289F900", VA = "0x1828A1100", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<LPLJHAHPEEF, LPLJHAHPEEF> EFCCNEFLDFL
	{
		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0x28A0EA0", Offset = "0x289F6A0", VA = "0x1828A0EA0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(RVA = "0x28A2300", Offset = "0x28A0B00", VA = "0x1828A2300", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<LPLJHAHPEEF, LPLJHAHPEEF, LPLJHAHPEEF> EKOCPHCNMKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0x28A0E00", Offset = "0x289F600", VA = "0x1828A0E00", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0x28A19E0", Offset = "0x28A01E0", VA = "0x1828A19E0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<LPLJHAHPEEF> NGEDFCJNKIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000872")]
		[Cpp2IlInjected.Address(RVA = "0x28A1850", Offset = "0x28A0050", VA = "0x1828A1850", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000873")]
		[Cpp2IlInjected.Address(RVA = "0x28A23A0", Offset = "0x28A0BA0", VA = "0x1828A23A0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000876")]
	[Cpp2IlInjected.Address(RVA = "0x28A2990", Offset = "0x28A1190", VA = "0x1828A2990", Slot = "26")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000877")]
	[Cpp2IlInjected.Address(RVA = "0x28A1A80", Offset = "0x28A0280", VA = "0x1828A1A80", Slot = "27")]
	public void GGJEPBDNAAH(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000878")]
	[Cpp2IlInjected.Address(RVA = "0x28A1510", Offset = "0x289FD10", VA = "0x1828A1510", Slot = "28")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000879")]
	[Cpp2IlInjected.Address(RVA = "0x28A18F0", Offset = "0x28A00F0", VA = "0x1828A18F0")]
	private void FDILEGIJOCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600087A")]
	[Cpp2IlInjected.Address(RVA = "0x28A2BF0", Offset = "0x28A13F0", VA = "0x1828A2BF0")]
	private void KPJPHHKLEAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600087B")]
	[Cpp2IlInjected.Address(RVA = "0x28A11A0", Offset = "0x289F9A0", VA = "0x1828A11A0")]
	private void DDBAHGBHFNA(HDEKHHMMCPI NFBDMLCENEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600087C")]
	[Cpp2IlInjected.Address(RVA = "0x28A21F0", Offset = "0x28A09F0", VA = "0x1828A21F0")]
	private void GNMDPEJHFBD(HDEKHHMMCPI NFBDMLCENEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600087D")]
	[Cpp2IlInjected.Address(RVA = "0x1851520", Offset = "0x184FD20", VA = "0x181851520", Slot = "14")]
	public Color OEMHAKKNHFI(LPLJHAHPEEF BBNGIDIFEAM, int AHANFINHMMJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600087E")]
	[Cpp2IlInjected.Address(RVA = "0x28A2440", Offset = "0x28A0C40", VA = "0x1828A2440", Slot = "15")]
	public float3 IBBONFMMKAF(LPLJHAHPEEF BBNGIDIFEAM, int AHANFINHMMJ)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600087F")]
	[Cpp2IlInjected.Address(RVA = "0x28A2B10", Offset = "0x28A1310", VA = "0x1828A2B10", Slot = "16")]
	public bool KCKHGMFBPJG(LPLJHAHPEEF BBNGIDIFEAM, LPLJHAHPEEF AFHPIAFJGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000880")]
	[Cpp2IlInjected.Address(RVA = "0x28A1430", Offset = "0x289FC30", VA = "0x1828A1430", Slot = "17")]
	public LPLJHAHPEEF DDLLEEBFHAB(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(LPLJHAHPEEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000881")]
	[Cpp2IlInjected.Address(RVA = "0x28A2060", Offset = "0x28A0860", VA = "0x1828A2060", Slot = "20")]
	public void GMLPEAEFLPM(LPLJHAHPEEF BBNGIDIFEAM, Vector3 LBJMPAACJOH, Quaternion GPOLFPEKAAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000882")]
	[Cpp2IlInjected.Address(RVA = "0x28A2D70", Offset = "0x28A1570", VA = "0x1828A2D70", Slot = "21")]
	public void LMNPMFGIHOE(LPLJHAHPEEF BBNGIDIFEAM, float HHDKGMDEOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000883")]
	[Cpp2IlInjected.Address(RVA = "0x28A3020", Offset = "0x28A1820", VA = "0x1828A3020", Slot = "24")]
	public float3 NPLENDLFLDN(FEINEMHDLHP MIKBIDEDGCC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000884")]
	[Cpp2IlInjected.Address(RVA = "0x28A2660", Offset = "0x28A0E60", VA = "0x1828A2660", Slot = "25")]
	public quaternion ICKKCCDIPED(FEINEMHDLHP MIKBIDEDGCC)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000885")]
	[Cpp2IlInjected.Address(RVA = "0x28A0F40", Offset = "0x289F740", VA = "0x1828A0F40", Slot = "22")]
	public bool CFMFJGCLCHD(LPLJHAHPEEF BBNGIDIFEAM, out RigidTransform CAJNEOLGFIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000886")]
	[Cpp2IlInjected.Address(RVA = "0x28A2E20", Offset = "0x28A1620", VA = "0x1828A2E20", Slot = "23")]
	public bool MBKEKOILBNL(LPLJHAHPEEF BBNGIDIFEAM, out float HHDKGMDEOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000887")]
	[Cpp2IlInjected.Address(RVA = "0x28A1950", Offset = "0x28A0150", VA = "0x1828A1950", Slot = "18")]
	[IteratorStateMachine(typeof(MHPIPKFJGGI))]
	public IEnumerable<LPLJHAHPEEF> FEGNNPHKFEI(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000888")]
	[Cpp2IlInjected.Address(RVA = "0x28A2720", Offset = "0x28A0F20", VA = "0x1828A2720", Slot = "19")]
	public LPLJHAHPEEF INMNOCAJKEE(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(LPLJHAHPEEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000889")]
	[Cpp2IlInjected.Address(RVA = "0x28A2880", Offset = "0x28A1080", VA = "0x1828A2880")]
	private Entity INMNOCAJKEE(Entity AJDEFAPHMKF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x600088A")]
	[Cpp2IlInjected.Address(RVA = "0x28A31B0", Offset = "0x28A19B0", VA = "0x1828A31B0")]
	public CBCIHEMOILI()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	public class PreSerializeDowngrade_RRObjectPrefabTypeData : NHLEGKPBPCC
	{
		[Cpp2IlInjected.Token(Token = "0x200016A")]
		[BurstCompile]
		[NoAlias]
		private struct PreSerializeDowngrade_RRObjectPrefabTypeData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004BA")]
			[ReadOnly]
			public SharedComponentTypeHandle<RRObjectPrefabV2Data> prefabTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004BB")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004BC")]
			[ReadOnly]
			public NativeArray<ArchetypeChunk> chunksRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004BD")]
			[ReadOnly]
			public NativeParallelHashMap<int, int> prefabTypeFromIndexRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004BE")]
			public JKLDOGFDCML.LFMNBPNHAFM<ArchetypeChunk, HECEHKFJNBN<RRObjectPrefabV2Data>> it;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40004BF")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40004C0")]
			public NativeList<LLBLIEDHHDD> prefabTypeData;

			[Cpp2IlInjected.Token(Token = "0x600089D")]
			[Cpp2IlInjected.Address(RVA = "0x601DE60", Offset = "0x601C660", VA = "0x18601DE60")]
			private void BNHOJHOEIPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089E")]
			[Cpp2IlInjected.Address(RVA = "0x601E120", Offset = "0x601C920", VA = "0x18601E120", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		private static readonly JNGNMMOLKFF log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private EntityQuery queryV2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0x22CF100", Offset = "0x22CD900", VA = "0x1822CF100", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000897")]
		[Cpp2IlInjected.Address(RVA = "0x22CF190", Offset = "0x22CD990", VA = "0x1822CF190", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0x22CEEF0", Offset = "0x22CD6F0", VA = "0x1822CEEF0")]
		private EntityCommandBufferSystem EFIPACDBNFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0x22CED40", Offset = "0x22CD540", VA = "0x1822CED40")]
		private JobHandle BHCOGEEKGNH(SharedComponentTypeHandle<RRObjectPrefabV2Data> prefabTypeHandleRO, EntityTypeHandle entityTypeHandleRO, NativeArray<ArchetypeChunk> chunksRO, NativeParallelHashMap<int, int> prefabTypeFromIndexRO, JKLDOGFDCML.LFMNBPNHAFM<ArchetypeChunk, HECEHKFJNBN<RRObjectPrefabV2Data>> it, NativeList<Entity> entities, NativeList<LLBLIEDHHDD> prefabTypeData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0x22CEF40", Offset = "0x22CD740", VA = "0x1822CEF40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
		public PreSerializeDowngrade_RRObjectPrefabTypeData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
internal struct IEBLEDBIMDL : IAJADHNJCKN, IEquatable<IEBLEDBIMDL>
{
	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public int JNDMMPHMODJ
	{
		[Cpp2IlInjected.Token(Token = "0x600089F")]
		[Cpp2IlInjected.Address(RVA = "0xB1A680", Offset = "0xB18E80", VA = "0x180B1A680", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0xB1A5C0", Offset = "0xB18DC0", VA = "0x180B1A5C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public int IHOKMDEGNLH
	{
		[Cpp2IlInjected.Token(Token = "0x60008A1")]
		[Cpp2IlInjected.Address(RVA = "0x1AB09C0", Offset = "0x1AAF1C0", VA = "0x181AB09C0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60008A2")]
		[Cpp2IlInjected.Address(RVA = "0x24EBED0", Offset = "0x24EA6D0", VA = "0x1824EBED0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008A3")]
	[Cpp2IlInjected.Address(RVA = "0x24EBE80", Offset = "0x24EA680", VA = "0x1824EBE80", Slot = "8")]
	public bool Equals(IEBLEDBIMDL OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008A4")]
	[Cpp2IlInjected.Address(RVA = "0x24EBEE0", Offset = "0x24EA6E0", VA = "0x1824EBEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016C")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
[KHNAILLFHGJ(typeof(GOHOPIDFNBA), new string[] { })]
internal sealed class GOHOPIDFNBA : NOFCHOCEBPC
{
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	[NAAJCOHOAKA]
	private ILBBGIPPPPJ EJLFIBCCMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	[NAAJCOHOAKA]
	private BGNBCCFEDLB HBACPGIPJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	[NAAJCOHOAKA]
	private BCLDABOBHLC AMOGKBJGANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	[NAAJCOHOAKA]
	private DLLLPKHOKKN BIKLBHANPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	[NAAJCOHOAKA]
	private IDDDKKBGJPP CBGOOONHBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	[NAAJCOHOAKA]
	private KMJAMFMINGI IHBKCEOBOMD;

	[Cpp2IlInjected.Token(Token = "0x60008A5")]
	[Cpp2IlInjected.Address(RVA = "0x2C82F90", Offset = "0x2C81790", VA = "0x182C82F90", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A6")]
	[Cpp2IlInjected.Address(RVA = "0x2C82DA0", Offset = "0x2C815A0", VA = "0x182C82DA0")]
	public void IMDNOOLOJIB(NativeArray<KECBEHOHBCN> PGDPKHFFBIG, NativeArray<MHGAJIKGEGE> LJNBIMMNBCJ, NativeArray<Entity> JMDOJIJKLJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A7")]
	[Cpp2IlInjected.Address(RVA = "0x2C82F80", Offset = "0x2C81780", VA = "0x182C82F80")]
	public Entity IMDNOOLOJIB(KECBEHOHBCN MCBNACIDAGA, MHGAJIKGEGE ECBAIECDCID)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008A8")]
	[Cpp2IlInjected.Address(RVA = "0x2C83090", Offset = "0x2C81890", VA = "0x182C83090")]
	public Entity KIDGLIGMFOC(KECBEHOHBCN MCBNACIDAGA, bool NICMHNKPPOK)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008A9")]
	[Cpp2IlInjected.Address(RVA = "0x2C83080", Offset = "0x2C81880", VA = "0x182C83080")]
	public Entity KIDGLIGMFOC(KECBEHOHBCN MCBNACIDAGA)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008AA")]
	[Cpp2IlInjected.Address(RVA = "0x2C82D90", Offset = "0x2C81590", VA = "0x182C82D90")]
	public Entity GGBAPGAFNOF()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008AB")]
	[Cpp2IlInjected.Address(RVA = "0x2C83180", Offset = "0x2C81980", VA = "0x182C83180")]
	public Entity NEIMIMJEBHI(JBOEKGNECFI EIOLDDJPDLH)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008AC")]
	[Cpp2IlInjected.Address(RVA = "0x2C83120", Offset = "0x2C81920", VA = "0x182C83120")]
	public MDHHOEPMEJH MMCNJDCOMKI(MDHHOEPMEJH FGPFEGPDAHM, Allocator HMGEFCKKBID)
	{
		return default(MDHHOEPMEJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60008AD")]
	[Cpp2IlInjected.Address(RVA = "0x2C831C0", Offset = "0x2C819C0", VA = "0x182C831C0")]
	public EntityArchetype OAAMCFEDLBE(KECBEHOHBCN MCBNACIDAGA)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x60008AE")]
	[Cpp2IlInjected.Address(RVA = "0x2C83200", Offset = "0x2C81A00", VA = "0x182C83200")]
	public Entity OBIOJJIDPBA(KECBEHOHBCN MCBNACIDAGA)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008AF")]
	[Cpp2IlInjected.Address(RVA = "0x2C82AC0", Offset = "0x2C812C0", VA = "0x182C82AC0")]
	private Entity CPIOEAIFKFL(KECBEHOHBCN MCBNACIDAGA, bool NICMHNKPPOK)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008B0")]
	[Cpp2IlInjected.Address(RVA = "0x2C82B50", Offset = "0x2C81350", VA = "0x182C82B50")]
	private Entity CPIOEAIFKFL(KECBEHOHBCN MCBNACIDAGA)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008B1")]
	[Cpp2IlInjected.Address(RVA = "0x2C82BE0", Offset = "0x2C813E0", VA = "0x182C82BE0")]
	private Entity CPIOEAIFKFL(KECBEHOHBCN MCBNACIDAGA, MHGAJIKGEGE ECBAIECDCID)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008B2")]
	[Cpp2IlInjected.Address(RVA = "0x2C827A0", Offset = "0x2C80FA0", VA = "0x182C827A0")]
	private void AIIBCGGGKMP(KECBEHOHBCN MCBNACIDAGA, NativeArray<MHGAJIKGEGE> LJNBIMMNBCJ, NativeArray<Entity> JMDOJIJKLJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B3")]
	[Cpp2IlInjected.Address(RVA = "0x2C828F0", Offset = "0x2C810F0", VA = "0x182C828F0")]
	private void BIHDENBFHNJ(NativeArray<KECBEHOHBCN> PGDPKHFFBIG, NativeArray<MHGAJIKGEGE> LJNBIMMNBCJ, NativeArray<Entity> JMDOJIJKLJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B4")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public GOHOPIDFNBA()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[GCAKKMGPAEI]
	[CompilerGenerated]
	public class PostDeserializeRemoveComponentSerializedVersionDataSystem : NHLEGKPBPCC
	{
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private static readonly JNGNMMOLKFF log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0x22C7AB0", Offset = "0x22C62B0", VA = "0x1822C7AB0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B7")]
		[Cpp2IlInjected.Address(RVA = "0x22C7B40", Offset = "0x22C6340", VA = "0x1822C7B40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x22C78A0", Offset = "0x22C60A0", VA = "0x1822C78A0")]
		private EntityCommandBufferSystem EFIPACDBNFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x22C78F0", Offset = "0x22C60F0", VA = "0x1822C78F0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
		public PostDeserializeRemoveComponentSerializedVersionDataSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200016E")]
[ExecuteAlways]
public class BEANJBEKLGM : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x60008BC")]
	[Cpp2IlInjected.Address(RVA = "0x7E01F0", Offset = "0x7DE9F0", VA = "0x1807E01F0")]
	public BEANJBEKLGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016F")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
[KHNAILLFHGJ(typeof(GJCOMGMOGCM), new string[] { })]
internal class GJCOMGMOGCM : NOFCHOCEBPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly SceneTag MHGFAJBAADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	[NAAJCOHOAKA]
	private ILBBGIPPPPJ EJLFIBCCMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	[NAAJCOHOAKA]
	private LBOJFNDAHOB FKGINHFEOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	[NAAJCOHOAKA]
	private LDDHDDLKFEJ CKMMOGKGLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	[NAAJCOHOAKA]
	private NKHJADIBHEP OIPELOCIIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	[NAAJCOHOAKA]
	private OABNFEOAMFN BFPMIDDMNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	[NAAJCOHOAKA]
	private NAHGLKOIEAI BOBHLPNKBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	[NAAJCOHOAKA]
	private ELJIMGIPHHA LPGBLMMBEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	private EntityQuery OMBGPMEDBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	private EntityQuery FNCOLEDFKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	private EntityQuery EGGIHINBDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	private Entity MCMFHDLAOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	private bool PMADFOMNIPK;

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public NativeArray<Entity> CPCFKIPCDNP
	{
		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0xCFB2B0", Offset = "0xCF9AB0", VA = "0x180CFB2B0")]
		[CompilerGenerated]
		get
		{
			return default(NativeArray<Entity>);
		}
		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0xFCA1B0", Offset = "0xFC89B0", VA = "0x180FCA1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public Entity OEBOKCMEAFE
	{
		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0x2C7E2F0", Offset = "0x2C7CAF0", VA = "0x182C7E2F0")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public SceneTag NHHNHDAIIGL
	{
		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x2C7E990", Offset = "0x2C7D190", VA = "0x182C7E990")]
		get
		{
			return default(SceneTag);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public Entity DNEMIJNNBEM
	{
		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x2C7E990", Offset = "0x2C7D190", VA = "0x182C7E990")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x2C7F2C0", Offset = "0x2C7DAC0", VA = "0x182C7F2C0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	private EntityManager EOOAJAELBGN
	{
		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x2C7EB90", Offset = "0x2C7D390", VA = "0x182C7EB90")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008C4")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F330", Offset = "0x2C7DB30", VA = "0x182C7F330", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C5")]
	[Cpp2IlInjected.Address(RVA = "0x2C7E920", Offset = "0x2C7D120", VA = "0x182C7E920", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C6")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F930", Offset = "0x2C7E130", VA = "0x182C7F930")]
	public void PEPEEONGLMF(Entity AJDEFAPHMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C7")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F500", Offset = "0x2C7DD00", VA = "0x182C7F500")]
	public NativeArray<Entity> JOEHGKJOCFM(Allocator HMGEFCKKBID = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60008C8")]
	[Cpp2IlInjected.Address(RVA = "0x2C7E8A0", Offset = "0x2C7D0A0", VA = "0x182C7E8A0")]
	public void BNMFIJDJNCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C9")]
	[Cpp2IlInjected.Address(RVA = "0x2C7EBE0", Offset = "0x2C7D3E0", VA = "0x182C7EBE0")]
	public void HFGODGICNOD(Entity JJIAFDKCLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008CA")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F450", Offset = "0x2C7DC50", VA = "0x182C7F450")]
	public Entity JDAMEHNNCFG(string MDOAADHDBMA = "")
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008CB")]
	[Cpp2IlInjected.Address(RVA = "0x2C7E970", Offset = "0x2C7D170", VA = "0x182C7E970")]
	public void FGLIOAHDGHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008CC")]
	[Cpp2IlInjected.Address(RVA = "0x2C7ECE0", Offset = "0x2C7D4E0", VA = "0x182C7ECE0")]
	public void IAHNEOIOIPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008CD")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	public void ALAFPCPOBJA(Entity JJIAFDKCLGJ, string MDOAADHDBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008CE")]
	[Cpp2IlInjected.Address(RVA = "0x2C7E3E0", Offset = "0x2C7CBE0", VA = "0x182C7E3E0")]
	public void BGINIFBMIHC(Entity JJIAFDKCLGJ, bool MGOPMAHKOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008CF")]
	[Cpp2IlInjected.Address(RVA = "0x2C7EEE0", Offset = "0x2C7D6E0", VA = "0x182C7EEE0")]
	public void IBOFGJGINNO(Entity AJDEFAPHMKF, Entity JJIAFDKCLGJ, bool FGOGOJDIGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D0")]
	[Cpp2IlInjected.Address(RVA = "0x2C7ED00", Offset = "0x2C7D500", VA = "0x182C7ED00")]
	public void IBOFGJGINNO(NativeArray<Entity> KFLBCCAJFMN, Entity JJIAFDKCLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D1")]
	[Cpp2IlInjected.Address(RVA = "0x2C7E9E0", Offset = "0x2C7D1E0", VA = "0x182C7E9E0")]
	private void GPHFECONEPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D2")]
	[Cpp2IlInjected.Address(RVA = "0x2C7E8F0", Offset = "0x2C7D0F0", VA = "0x182C7E8F0")]
	private void DOCHOLCDCNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D3")]
	[Cpp2IlInjected.Address(RVA = "0x2C7E2F0", Offset = "0x2C7CAF0", VA = "0x182C7E2F0")]
	private Entity BGIFIPDPKGD()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60008D4")]
	[Cpp2IlInjected.Address(RVA = "0x2C7E4F0", Offset = "0x2C7CCF0", VA = "0x182C7E4F0")]
	private void BINCHDEOLPJ(EntityQuery DEMIMMNFGNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D5")]
	[Cpp2IlInjected.Address(RVA = "0x2C7E5C0", Offset = "0x2C7CDC0", VA = "0x182C7E5C0")]
	private void BINCHDEOLPJ(NativeArray<Entity> DOEAPBCCKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D6")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F710", Offset = "0x2C7DF10", VA = "0x182C7F710")]
	private void MJDMFIJDGDN(Entity JJIAFDKCLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D7")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F190", Offset = "0x2C7D990", VA = "0x182C7F190")]
	private void ILEMLINDIGE(Entity JJIAFDKCLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D8")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F7C0", Offset = "0x2C7DFC0", VA = "0x182C7F7C0")]
	private void OEBPHLJMBEM(SceneTag LMDDLHFIGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D9")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F530", Offset = "0x2C7DD30", VA = "0x182C7F530")]
	private void KCLLNBJBKNH(SceneTag LMDDLHFIGLD, NativeParallelHashSet<int> GOBNBDPGPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008DA")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F570", Offset = "0x2C7DD70", VA = "0x182C7F570")]
	private void LEDOKBLEDNJ(SceneTag LMDDLHFIGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008DB")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F0D0", Offset = "0x2C7D8D0", VA = "0x182C7F0D0")]
	private void IDBGDPOMHPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008DC")]
	[Cpp2IlInjected.Address(RVA = "0x1CA6D30", Offset = "0x1CA5530", VA = "0x181CA6D30")]
	private void OLLHAAKMJAM<T>() where T : ComponentSystemBase
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008DD")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public GJCOMGMOGCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000170")]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
internal class DBJGHEDKBPJ : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	private LDDHDDLKFEJ HBLGPEBMOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	private OIKLJKNPPOI MFGFOJJEBIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	private NAHGLKOIEAI BOBHLPNKBHC;

	[Cpp2IlInjected.Token(Token = "0x60008DF")]
	[Cpp2IlInjected.Address(RVA = "0x2C66DD0", Offset = "0x2C655D0", VA = "0x182C66DD0", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E0")]
	[Cpp2IlInjected.Address(RVA = "0x2C66E60", Offset = "0x2C65660", VA = "0x182C66E60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E1")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public DBJGHEDKBPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000171")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
[KHNAILLFHGJ(typeof(DLLLPKHOKKN), new string[] { })]
internal sealed class DLLLPKHOKKN : NOFCHOCEBPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	[NAAJCOHOAKA]
	private ILBBGIPPPPJ KFELNFLBJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	[NAAJCOHOAKA]
	private BGNBCCFEDLB BLOCLHGJANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	[NAAJCOHOAKA]
	private BCLDABOBHLC COHIKKBABFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	private HMBELPNBOEG LNJHNPCFKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	private NativeParallelHashMap<MHGAJIKGEGE, Entity> JBBKMGMDHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	private EntityManager EADLBIHJKBG;

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	internal NativeParallelHashMap<MHGAJIKGEGE, Entity> FHLHFMLEJEL
	{
		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0xB28580", Offset = "0xB26D80", VA = "0x180B28580")]
		get
		{
			return default(NativeParallelHashMap<MHGAJIKGEGE, Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	internal uint NGLAAOMHOFA
	{
		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0x2C6AA50", Offset = "0x2C69250", VA = "0x182C6AA50")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	private bool GKHBBLGCCAM
	{
		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0xA55980", Offset = "0xA54180", VA = "0x180A55980")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008E6")]
	[Cpp2IlInjected.Address(RVA = "0x2C6AD80", Offset = "0x2C69580", VA = "0x182C6AD80", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E7")]
	[Cpp2IlInjected.Address(RVA = "0x2C6A9E0", Offset = "0x2C691E0", VA = "0x182C6A9E0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E8")]
	[Cpp2IlInjected.Address(RVA = "0x2C6AA80", Offset = "0x2C69280", VA = "0x182C6AA80")]
	public void EEMEPIGIECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E9")]
	[Cpp2IlInjected.Address(RVA = "0x2C6AB00", Offset = "0x2C69300", VA = "0x182C6AB00")]
	public MHGAJIKGEGE EFBJPKEALFO(int JMKNAPEFDDB)
	{
		return default(MHGAJIKGEGE);
	}

	[Cpp2IlInjected.Token(Token = "0x60008EA")]
	[Cpp2IlInjected.Address(RVA = "0x2C6A820", Offset = "0x2C69020", VA = "0x182C6A820")]
	public void DNHMGMOKPAF(MHGAJIKGEGE ECBAIECDCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008EB")]
	[Cpp2IlInjected.Address(RVA = "0x2C6B010", Offset = "0x2C69810", VA = "0x182C6B010")]
	public LPLJHAHPEEF JIFMDGFNNCE(MHGAJIKGEGE ECBAIECDCID)
	{
		return default(LPLJHAHPEEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60008EC")]
	[Cpp2IlInjected.Address(RVA = "0x2C6AC30", Offset = "0x2C69430", VA = "0x182C6AC30")]
	public bool FJFGMMBNOBJ(MHGAJIKGEGE ECBAIECDCID, out LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008ED")]
	[Cpp2IlInjected.Address(RVA = "0x2C6AEB0", Offset = "0x2C696B0", VA = "0x182C6AEB0")]
	public MDHHOEPMEJH JIFMDGFNNCE(NativeArray<MHGAJIKGEGE> ECBAIECDCID, Allocator HMGEFCKKBID)
	{
		return default(MDHHOEPMEJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60008EE")]
	[Cpp2IlInjected.Address(RVA = "0x2C6B300", Offset = "0x2C69B00", VA = "0x182C6B300")]
	public MHGAJIKGEGE OMHDNNDLEHC(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(MHGAJIKGEGE);
	}

	[Cpp2IlInjected.Token(Token = "0x60008EF")]
	[Cpp2IlInjected.Address(RVA = "0x2C6B230", Offset = "0x2C69A30", VA = "0x182C6B230")]
	public MHGAJIKGEGE OMHDNNDLEHC(Entity AJDEFAPHMKF)
	{
		return default(MHGAJIKGEGE);
	}

	[Cpp2IlInjected.Token(Token = "0x60008F0")]
	[Cpp2IlInjected.Address(RVA = "0x2C6A640", Offset = "0x2C68E40", VA = "0x182C6A640")]
	public void CHALEGLHKAC(NativeArray<Entity> KFLBCCAJFMN, NativeArray<MHGAJIKGEGE> LJNBIMMNBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F1")]
	[Cpp2IlInjected.Address(RVA = "0x2C6B1F0", Offset = "0x2C699F0", VA = "0x182C6B1F0")]
	private LPLJHAHPEEF LGDGILNIGMA(Entity AJDEFAPHMKF)
	{
		return default(LPLJHAHPEEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60008F2")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public DLLLPKHOKKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000172")]
[KHNAILLFHGJ(typeof(OABNFEOAMFN), new string[] { })]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
internal sealed class OABNFEOAMFN : NOFCHOCEBPC, NOHOJBNCAJC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	[NAAJCOHOAKA]
	private ILBBGIPPPPJ EJLFIBCCMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	[NAAJCOHOAKA]
	private NKHJADIBHEP OIPELOCIIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	private Entity AJDEFAPHMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	private ComponentTypeList MPCPKFKACPN;

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public EntityManager EOOAJAELBGN
	{
		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x2939EA0", Offset = "0x29386A0", VA = "0x182939EA0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008F5")]
	[Cpp2IlInjected.Address(RVA = "0x2BF46E0", Offset = "0x2BF2EE0", VA = "0x182BF46E0")]
	public T LPKBLHIFLLL<T>() where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008F6")]
	[Cpp2IlInjected.Address(RVA = "0x2BF47A0", Offset = "0x2BF2FA0", VA = "0x182BF47A0")]
	public void OLFLGMGEIBD<T>(T MENBIMCLIOI) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F7")]
	[Cpp2IlInjected.Address(RVA = "0x2BF45E0", Offset = "0x2BF2DE0", VA = "0x182BF45E0")]
	public DynamicBuffer<T> LGOJBGNGKFD<T>(bool JDJJPAIGOMA = false) where T : struct, IBufferElementData
	{
		return default(DynamicBuffer<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60008F8")]
	[Cpp2IlInjected.Address(RVA = "0x2BF44B0", Offset = "0x2BF2CB0", VA = "0x182BF44B0")]
	public void HONHDFLOOKK<T>(T MENBIMCLIOI) where T : struct, IBufferElementData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F9")]
	[Cpp2IlInjected.Address(RVA = "0x2939EF0", Offset = "0x29386F0", VA = "0x182939EF0", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008FA")]
	[Cpp2IlInjected.Address(RVA = "0x2939D00", Offset = "0x2938500", VA = "0x182939D00", Slot = "5")]
	public void GGJEPBDNAAH(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008FB")]
	[Cpp2IlInjected.Address(RVA = "0x2939D00", Offset = "0x2938500", VA = "0x182939D00")]
	private void EMKODLMNECK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008FC")]
	[Cpp2IlInjected.Address(RVA = "0x2939A50", Offset = "0x2938250", VA = "0x182939A50", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008FD")]
	[Cpp2IlInjected.Address(RVA = "0x29396B0", Offset = "0x2937EB0", VA = "0x1829396B0")]
	private ComponentTypeList DJBBFHNIDPJ()
	{
		return default(ComponentTypeList);
	}

	[Cpp2IlInjected.Token(Token = "0x60008FE")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	private static void JBBEJKKGBFA(int JMKNAPEFDDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008FF")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	private static void BECKMAHBBCN(Type EIOLDDJPDLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000900")]
	[Cpp2IlInjected.Address(RVA = "0x29395B0", Offset = "0x2937DB0", VA = "0x1829395B0")]
	private static void ACIOHKMIDPL(Type EIOLDDJPDLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000901")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public OABNFEOAMFN()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000173")]
[ABOACEBGBKB]
internal struct LAEJAOHCMGN : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
internal class OMKLOBBJEKK : NHLEGKPBPCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	private EntityQuery KIJGPCNAELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	private EntityQuery KFGOBKOFIJI;

	[Cpp2IlInjected.Token(Token = "0x6000903")]
	[Cpp2IlInjected.Address(RVA = "0x22BCCA0", Offset = "0x22BB4A0", VA = "0x1822BCCA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000904")]
	[Cpp2IlInjected.Address(RVA = "0x22BCD90", Offset = "0x22BB590", VA = "0x1822BCD90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000905")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public OMKLOBBJEKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
[LJMILPFECGO]
public class MNDMCONAOAH : NHLEGKPBPCC, CICEKNFDMIA.LCADOJGBOPP
{
	[Cpp2IlInjected.Token(Token = "0x6000906")]
	[Cpp2IlInjected.Address(RVA = "0x292BF50", Offset = "0x292A750", VA = "0x18292BF50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000907")]
	[Cpp2IlInjected.Address(RVA = "0x292BF00", Offset = "0x292A700", VA = "0x18292BF00")]
	private EntityCommandBufferSystem EFIPACDBNFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000908")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public MNDMCONAOAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000176")]
[AlwaysUpdateSystem]
public class NDPGBPGKIMO : BBADPFDDMLN
{
	[Cpp2IlInjected.Token(Token = "0x6000909")]
	[Cpp2IlInjected.Address(RVA = "0x292F3D0", Offset = "0x292DBD0", VA = "0x18292F3D0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090A")]
	[Cpp2IlInjected.Address(RVA = "0x97A870", Offset = "0x979070", VA = "0x18097A870")]
	public NDPGBPGKIMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
[KHNAILLFHGJ(typeof(OIKLJKNPPOI), new string[] { })]
internal class OIKLJKNPPOI : NOFCHOCEBPC, NOHOJBNCAJC, NIPHPIANDBN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	internal readonly struct NNKJKEEMAKB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private readonly HPOKAOBOIJC NPKGKOEFNOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		private readonly OIKLJKNPPOI DBAHNFPKFPM;

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x2235900", Offset = "0x2234100", VA = "0x182235900")]
		public NNKJKEEMAKB(OIKLJKNPPOI DBAHNFPKFPM, HPOKAOBOIJC KBIIKIMPIKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x22358E0", Offset = "0x22340E0", VA = "0x1822358E0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	private static readonly JNGNMMOLKFF IAMJCDMAKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	[NAAJCOHOAKA]
	private ILBBGIPPPPJ KFELNFLBJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	[NAAJCOHOAKA]
	private LGNMGLONHCC ELMENJAOGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	[NAAJCOHOAKA]
	private IDDDKKBGJPP CBGOOONHBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	private readonly NDFEBALOIGE[] IMGFIHKHGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	private BHCNLMFFMGM CFMFDFNNBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	private NativeParallelHashMap<int, Entity> ADHHHLFCGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	private HPOKAOBOIJC MFGACCGBDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	private bool PMADFOMNIPK;

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public World IHPDJPJEIBM
	{
		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x293CBF0", Offset = "0x293B3F0", VA = "0x18293CBF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public World IGCHJBGNJEI
	{
		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0x7DFCF0", Offset = "0x7DE4F0", VA = "0x1807DFCF0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0xB39D50", Offset = "0xB38550", VA = "0x180B39D50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public BHCNLMFFMGM NJFHCINBFJN
	{
		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0x293CBA0", Offset = "0x293B3A0", VA = "0x18293CBA0", Slot = "8")]
		get
		{
			return default(BHCNLMFFMGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public uint EOFDFPDHALO
	{
		[Cpp2IlInjected.Token(Token = "0x600090F")]
		[Cpp2IlInjected.Address(RVA = "0x16902D0", Offset = "0x168EAD0", VA = "0x1816902D0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0xE8FE50", Offset = "0xE8E650", VA = "0x180E8FE50", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	private bool BFLHJBDIBBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x1690290", Offset = "0x168EA90", VA = "0x181690290")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool GKHBBLGCCAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x149B9A0", Offset = "0x149A1A0", VA = "0x18149B9A0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public NativeParallelHashMap<int, Entity> BHPLAAJBECF
	{
		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x147F030", Offset = "0x147D830", VA = "0x18147F030")]
		get
		{
			return default(NativeParallelHashMap<int, Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public DCDCMCEDILM GCHNPPAHEFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x293C440", Offset = "0x293AC40", VA = "0x18293C440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public AJNCIBJCEPK NBHIDKMAMML
	{
		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0x293C440", Offset = "0x293AC40", VA = "0x18293C440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public HPOKAOBOIJC KKLKOFJJDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x90F690", Offset = "0x90DE90", VA = "0x18090F690")]
		get
		{
			return default(HPOKAOBOIJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000914")]
	[Cpp2IlInjected.Address(RVA = "0x293C6D0", Offset = "0x293AED0", VA = "0x18293C6D0")]
	public DCDCMCEDILM DCNFDJMGIPF(HPOKAOBOIJC PODDIAOEGNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000915")]
	[Cpp2IlInjected.Address(RVA = "0x293C6D0", Offset = "0x293AED0", VA = "0x18293C6D0")]
	public AJNCIBJCEPK GDHBINAEHKO(HPOKAOBOIJC PODDIAOEGNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000919")]
	[Cpp2IlInjected.Address(RVA = "0x293CAD0", Offset = "0x293B2D0", VA = "0x18293CAD0", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600091A")]
	[Cpp2IlInjected.Address(RVA = "0x293C890", Offset = "0x293B090", VA = "0x18293C890", Slot = "5")]
	public void GGJEPBDNAAH(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600091B")]
	[Cpp2IlInjected.Address(RVA = "0x293C480", Offset = "0x293AC80", VA = "0x18293C480")]
	private NativeParallelHashMap<int, Entity> DCFLMGOEHPG()
	{
		return default(NativeParallelHashMap<int, Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600091C")]
	[Cpp2IlInjected.Address(RVA = "0x293CC40", Offset = "0x293B440", VA = "0x18293CC40")]
	public void PKPGFDCHAGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600091D")]
	[Cpp2IlInjected.Address(RVA = "0x293C770", Offset = "0x293AF70", VA = "0x18293C770")]
	public void EEMEPIGIECC(HPOKAOBOIJC PODDIAOEGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600091E")]
	[Cpp2IlInjected.Address(RVA = "0x293C7C0", Offset = "0x293AFC0", VA = "0x18293C7C0")]
	public void EEMEPIGIECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600091F")]
	[Cpp2IlInjected.Address(RVA = "0x293C710", Offset = "0x293AF10", VA = "0x18293C710", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000920")]
	[Cpp2IlInjected.Address(RVA = "0x293CBD0", Offset = "0x293B3D0", VA = "0x18293CBD0")]
	public NNKJKEEMAKB NFGALLCLPDJ(HPOKAOBOIJC PODDIAOEGNA)
	{
		return default(NNKJKEEMAKB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000921")]
	[Cpp2IlInjected.Address(RVA = "0x293CD60", Offset = "0x293B560", VA = "0x18293CD60")]
	public OIKLJKNPPOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
internal class OJAHFBHLAFD : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	private EntityQuery ABKMIGOKHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000500")]
	private BMMKBDIEBCN KKDNOJEGEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000501")]
	private HMBELPNBOEG LNJHNPCFKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000502")]
	private JGHGFLIKNJI FOMNIIGGJOB;

	[Cpp2IlInjected.Token(Token = "0x6000925")]
	[Cpp2IlInjected.Address(RVA = "0x293CDD0", Offset = "0x293B5D0", VA = "0x18293CDD0", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000926")]
	[Cpp2IlInjected.Address(RVA = "0x293CE60", Offset = "0x293B660", VA = "0x18293CE60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000927")]
	[Cpp2IlInjected.Address(RVA = "0x2897F60", Offset = "0x2896760", VA = "0x182897F60", Slot = "6")]
	protected override void OnStartRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000928")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000929")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public OJAHFBHLAFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
[GCAKKMGPAEI]
public class ALPAMOBCEKP : JKEMFGGLHGI
{
	[Cpp2IlInjected.Token(Token = "0x4000503")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000504")]
	private EntityQuery EGFJCKOAGFH;

	[Cpp2IlInjected.Token(Token = "0x600092B")]
	[Cpp2IlInjected.Address(RVA = "0x2898800", Offset = "0x2897000", VA = "0x182898800", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600092C")]
	[Cpp2IlInjected.Address(RVA = "0x28988B0", Offset = "0x28970B0", VA = "0x1828988B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600092D")]
	[Cpp2IlInjected.Address(RVA = "0x28987B0", Offset = "0x2896FB0", VA = "0x1828987B0")]
	private EntityCommandBufferSystem EFIPACDBNFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600092E")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public ALPAMOBCEKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
public class FIKABHFLENO : JKEMFGGLHGI
{
	[Cpp2IlInjected.Token(Token = "0x4000505")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x6000930")]
	[Cpp2IlInjected.Address(RVA = "0x2C78100", Offset = "0x2C76900", VA = "0x182C78100", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000931")]
	[Cpp2IlInjected.Address(RVA = "0x2C780B0", Offset = "0x2C768B0", VA = "0x182C780B0")]
	private EntityCommandBufferSystem EFIPACDBNFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000932")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public FIKABHFLENO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
public struct MPPKJJDGDIM<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	private GCHandle BJJHADPHPJP;

	[Cpp2IlInjected.Token(Token = "0x6000937")]
	[Cpp2IlInjected.Address(RVA = "0x23BFEF0", Offset = "0x23BE6F0", VA = "0x1823BFEF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
[LJMILPFECGO]
public class AAMILCCGBFD : NHLEGKPBPCC, CICEKNFDMIA.LCADOJGBOPP
{
	[Cpp2IlInjected.Token(Token = "0x6000938")]
	[Cpp2IlInjected.Address(RVA = "0x2892C30", Offset = "0x2891430", VA = "0x182892C30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000939")]
	[Cpp2IlInjected.Address(RVA = "0x2892BE0", Offset = "0x28913E0", VA = "0x182892BE0")]
	private EntityCommandBufferSystem EFIPACDBNFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600093A")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public AAMILCCGBFD()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	public class PreSerializeSaveNetworkIds : NHLEGKPBPCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0x22CFE30", Offset = "0x22CE630", VA = "0x1822CFE30", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0x22CFEC0", Offset = "0x22CE6C0", VA = "0x1822CFEC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0x22CFC20", Offset = "0x22CE420", VA = "0x1822CFC20")]
		private EntityCommandBufferSystem NGFKGOBBIDP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0x22CFC70", Offset = "0x22CE470", VA = "0x1822CFC70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
		public PreSerializeSaveNetworkIds()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
[AlwaysUpdateSystem]
public class HOHHEIOBFBD : NHLEGKPBPCC
{
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x6000940")]
	[Cpp2IlInjected.Address(RVA = "0x24E8260", Offset = "0x24E6A60", VA = "0x1824E8260", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000941")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public HOHHEIOBFBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
[GCAKKMGPAEI]
[KAPPDMKCEOO(JLEAEANKKDG.OMRoom)]
public class JODHCCNKBKM : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	private PCMJCEALPLG MJMFLCKALLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	private GJCOMGMOGCM DOEAPBCCKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private EntityQuery EGFJCKOAGFH;

	[Cpp2IlInjected.Token(Token = "0x6000943")]
	[Cpp2IlInjected.Address(RVA = "0x24F5B60", Offset = "0x24F4360", VA = "0x1824F5B60", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000944")]
	[Cpp2IlInjected.Address(RVA = "0x24F5BD0", Offset = "0x24F43D0", VA = "0x1824F5BD0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000945")]
	[Cpp2IlInjected.Address(RVA = "0x24F5C70", Offset = "0x24F4470", VA = "0x1824F5C70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000946")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public JODHCCNKBKM()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
	internal class SplinePointOrderingUpdateSystem : NHLEGKPBPCC, NOFCHOCEBPC
	{
		[Cpp2IlInjected.Token(Token = "0x2000183")]
		[BurstCompile]
		private struct UpdateSplineIndexJob : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000512")]
			[ReadOnly]
			public NativeArray<global::HJKAJAPIIMN> indexUpdatesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000513")]
			[ReadOnly]
			public ComponentDataFromEntity<NLLEHLHFEHG> splinePointParentDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000514")]
			public ComponentDataFromEntity<HJFDLKKNMEJ> splinePointOrderDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000515")]
			public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

			[Cpp2IlInjected.Token(Token = "0x600094F")]
			[Cpp2IlInjected.Address(RVA = "0x6022A40", Offset = "0x6021240", VA = "0x186022A40", Slot = "4")]
			public void Execute(int i)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000184")]
		private struct OrderComparer : IComparer<Entity>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000516")]
			[ReadOnly]
			public ComponentDataFromEntity<HJFDLKKNMEJ> orderRO;

			[Cpp2IlInjected.Token(Token = "0x6000950")]
			[Cpp2IlInjected.Address(RVA = "0x601CFD0", Offset = "0x601B7D0", VA = "0x18601CFD0", Slot = "4")]
			public int Compare(Entity x, Entity y)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000185")]
		[BurstCompile]
		[NoAlias]
		private struct SplinePointOrderingUpdateSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000517")]
			public OrderComparer comparer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000518")]
			[ReadOnly]
			public EntityTypeHandle __splineTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000519")]
			public BufferTypeHandle<LinkedEntityGroup> __bufferTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000951")]
			[Cpp2IlInjected.Address(RVA = "0x6021600", Offset = "0x601FE00", VA = "0x186021600")]
			private void BNHOJHOEIPF(Entity spline, DynamicBuffer<LinkedEntityGroup> buffer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000952")]
			[Cpp2IlInjected.Address(RVA = "0x6021690", Offset = "0x601FE90", VA = "0x186021690", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private EntityQuery needsUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		[NAAJCOHOAKA]
		private OABNFEOAMFN singletonService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private EntityQuery SplinePointOrderingUpdateSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0x22D2480", Offset = "0x22D0C80", VA = "0x1822D2480", Slot = "14")]
		public void InitReferences(NCFCHDEHMHC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000948")]
		[Cpp2IlInjected.Address(RVA = "0x22D29E0", Offset = "0x22D11E0", VA = "0x1822D29E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000949")]
		[Cpp2IlInjected.Address(RVA = "0x22D1FB0", Offset = "0x22D07B0", VA = "0x1822D1FB0")]
		private void BMGJOILKMKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0x22D24D0", Offset = "0x22D0CD0", VA = "0x1822D24D0")]
		private void JCHOECBEKFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x22D2630", Offset = "0x22D0E30", VA = "0x1822D2630")]
		private static IHDIMGJIFBM MJCLIGJFDIK(int insertionIndex, ComponentDataFromEntity<HJFDLKKNMEJ> splinePointOrderDataRO, NativeArray<Entity> children)
		{
			return default(IHDIMGJIFBM);
		}

		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0x22D2340", Offset = "0x22D0B40", VA = "0x1822D2340")]
		private JobHandle DOPLPBIJEPD(OrderComparer comparer, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(RVA = "0x22D2790", Offset = "0x22D0F90", VA = "0x1822D2790", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
		public SplinePointOrderingUpdateSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	public class UpdateMassOfShapes : NHLEGKPBPCC
	{
		[Cpp2IlInjected.Token(Token = "0x2000187")]
		[BurstCompile]
		[NoAlias]
		private struct UpdateMassOfShapes_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400051C")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400051D")]
			[ReadOnly]
			public ComponentDataFromEntity<DIABMIKHCMI> worldDeformableScalesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400051E")]
			[ReadOnly]
			public ComponentDataFromEntity<HBPOHKHILDB> worldUniformScalesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400051F")]
			[ReadOnly]
			public ComponentDataFromEntity<POCOCJLODBE> physicsMaterialsRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000520")]
			[ReadOnly]
			public ComponentDataFromEntity<JCINHADDLOO> primitiveShapesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000521")]
			[ReadOnly]
			public ComponentDataFromEntity<MEJJCGNBFDD> localUniformScalesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000522")]
			public ComponentDataFromEntity<HJLIOPBHNPG> massesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000523")]
			public ComponentDataFromEntity<ONJPNGGFKNL> centerOfMassesRW;

			[Cpp2IlInjected.Token(Token = "0x600095A")]
			[Cpp2IlInjected.Address(RVA = "0x60224A0", Offset = "0x6020CA0", VA = "0x1860224A0")]
			private void BNHOJHOEIPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600095B")]
			[Cpp2IlInjected.Address(RVA = "0x6022900", Offset = "0x6021100", VA = "0x186022900", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private static readonly JNGNMMOLKFF log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		private EntityQuery query;

		[Cpp2IlInjected.Token(Token = "0x6000953")]
		[Cpp2IlInjected.Address(RVA = "0x22D9E60", Offset = "0x22D8660", VA = "0x1822D9E60", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000954")]
		[Cpp2IlInjected.Address(RVA = "0x22D9F90", Offset = "0x22D8790", VA = "0x1822D9F90", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000955")]
		[Cpp2IlInjected.Address(RVA = "0x22D9B50", Offset = "0x22D8350", VA = "0x1822D9B50")]
		private void JLMDMCHNPEF(NativeList<Entity> entities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0x22D9970", Offset = "0x22D8170", VA = "0x1822D9970")]
		private JobHandle CMONOODKIKH(NativeList<Entity> entities, ComponentDataFromEntity<DIABMIKHCMI> worldDeformableScalesRO, ComponentDataFromEntity<HBPOHKHILDB> worldUniformScalesRO, ComponentDataFromEntity<POCOCJLODBE> physicsMaterialsRO, ComponentDataFromEntity<JCINHADDLOO> primitiveShapesRO, ComponentDataFromEntity<MEJJCGNBFDD> localUniformScalesRO, ComponentDataFromEntity<HJLIOPBHNPG> massesRW, ComponentDataFromEntity<ONJPNGGFKNL> centerOfMassesRW, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000957")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000958")]
		[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
		public UpdateMassOfShapes()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000188")]
internal struct IEICGACEBPF : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000189")]
public class GPOHIMIKLBE : EEGODALIIAO
{
	[Cpp2IlInjected.Token(Token = "0x600095C")]
	[Cpp2IlInjected.Address(RVA = "0x2C84070", Offset = "0x2C82870", VA = "0x182C84070", Slot = "14")]
	protected override EntityCommandBufferSystem EFIPACDBNFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600095D")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public GPOHIMIKLBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018A")]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
internal class EBADOFHDGHH : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	private HMBELPNBOEG LNJHNPCFKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	private NAHGLKOIEAI BOBHLPNKBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	private EntityQuery KBMEHCMGILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private EntityQuery GLMCFNDLCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	private EntityQuery KEMGKKGCHCO;

	[Cpp2IlInjected.Token(Token = "0x600095E")]
	[Cpp2IlInjected.Address(RVA = "0x2C6F770", Offset = "0x2C6DF70", VA = "0x182C6F770", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095F")]
	[Cpp2IlInjected.Address(RVA = "0x2C6FC80", Offset = "0x2C6E480", VA = "0x182C6FC80", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000960")]
	[Cpp2IlInjected.Address(RVA = "0x2C6FE00", Offset = "0x2C6E600", VA = "0x182C6FE00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000961")]
	[Cpp2IlInjected.Address(RVA = "0x2C6FDD0", Offset = "0x2C6E5D0", VA = "0x182C6FDD0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000962")]
	[Cpp2IlInjected.Address(RVA = "0x2C6FE40", Offset = "0x2C6E640", VA = "0x182C6FE40")]
	private void PKPPAFDKGMI(EntityQuery EGFJCKOAGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000963")]
	[Cpp2IlInjected.Address(RVA = "0x2C6FAD0", Offset = "0x2C6E2D0", VA = "0x182C6FAD0")]
	private void NOECFLKOEIK(NativeArray<Entity> KFLBCCAJFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000964")]
	[Cpp2IlInjected.Address(RVA = "0x2C6F7E0", Offset = "0x2C6DFE0", VA = "0x182C6F7E0")]
	private void LCIJJGPJELP(NativeArray<Entity> KFLBCCAJFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000965")]
	[Cpp2IlInjected.Address(RVA = "0x2C6F480", Offset = "0x2C6DC80", VA = "0x182C6F480")]
	private void ALPHAGFPAAG(EntityQuery EGFJCKOAGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000966")]
	[Cpp2IlInjected.Address(RVA = "0x2C70180", Offset = "0x2C6E980", VA = "0x182C70180")]
	private void PNBAPGDJDPE(NativeArray<Entity> KFLBCCAJFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000967")]
	[Cpp2IlInjected.Address(RVA = "0x2C6F640", Offset = "0x2C6DE40", VA = "0x182C6F640")]
	private void BOMHHLAOJCF(LPLJHAHPEEF BBNGIDIFEAM, int LDFNOAINHMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000968")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public EBADOFHDGHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
[KHNAILLFHGJ(typeof(JDNCKFIKKGH), new string[] { })]
[CHALNEEBFJF(typeof(KPDEPPFNAGM))]
public class CLCGMBOIPNM : JDNCKFIKKGH, PCAPGPPECJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private static readonly Dictionary<int, int> DOCIIHKJLAP;

	[Cpp2IlInjected.Token(Token = "0x600096A")]
	[Cpp2IlInjected.Address(RVA = "0x28A85E0", Offset = "0x28A6DE0", VA = "0x1828A85E0", Slot = "5")]
	public void PAHLDMJMCEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096B")]
	[Cpp2IlInjected.Address(RVA = "0x28A8540", Offset = "0x28A6D40", VA = "0x1828A8540", Slot = "4")]
	public int HOJAFNDLCOI(int KFGBCCEFCMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600096C")]
	[Cpp2IlInjected.Address(RVA = "0x28A84C0", Offset = "0x28A6CC0", VA = "0x1828A84C0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096D")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public CLCGMBOIPNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
[KHNAILLFHGJ(typeof(NNHDHBPFLOE), new string[] { })]
public class OCAFGFHHIIM : NOFCHOCEBPC, NOHOJBNCAJC, NNHDHBPFLOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private sealed class HEIPKCLOEHD : IEnumerable<LPLJHAHPEEF>, IEnumerable, IEnumerator<LPLJHAHPEEF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		private LPLJHAHPEEF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private LPLJHAHPEEF splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public LPLJHAHPEEF <>3__splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public OCAFGFHHIIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		private NativeArray<Entity> <children>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		private LPLJHAHPEEF System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000984")]
			[Cpp2IlInjected.Address(RVA = "0xA64970", Offset = "0xA63170", VA = "0x180A64970", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(LPLJHAHPEEF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000986")]
			[Cpp2IlInjected.Address(RVA = "0x222F710", Offset = "0x222DF10", VA = "0x18222F710", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000981")]
		[Cpp2IlInjected.Address(RVA = "0x21D5240", Offset = "0x21D3A40", VA = "0x1821D5240")]
		[DebuggerHidden]
		public HEIPKCLOEHD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000982")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000983")]
		[Cpp2IlInjected.Address(RVA = "0x222F530", Offset = "0x222DD30", VA = "0x18222F530", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0x222F6D0", Offset = "0x222DED0", VA = "0x18222F6D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000987")]
		[Cpp2IlInjected.Address(RVA = "0x222F620", Offset = "0x222DE20", VA = "0x18222F620", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LPLJHAHPEEF> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000988")]
		[Cpp2IlInjected.Address(RVA = "0x222F620", Offset = "0x222DE20", VA = "0x18222F620", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	private ILBBGIPPPPJ EJLFIBCCMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	private HMBELPNBOEG LNJHNPCFKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	private LGNMGLONHCC ELMENJAOGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	private GOHOPIDFNBA CBGOOONHBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	private KMFOAMJFLAH PBHLNILGHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	private OABNFEOAMFN HOAPIJEHJFA;

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	private EntityManager EOOAJAELBGN
	{
		[Cpp2IlInjected.Token(Token = "0x600096F")]
		[Cpp2IlInjected.Address(RVA = "0x293A840", Offset = "0x2939040", VA = "0x18293A840")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000970")]
	[Cpp2IlInjected.Address(RVA = "0x293A890", Offset = "0x2939090", VA = "0x18293A890", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000971")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
	public void GGJEPBDNAAH(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000972")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "15")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000973")]
	[Cpp2IlInjected.Address(RVA = "0x293AEA0", Offset = "0x29396A0", VA = "0x18293AEA0")]
	private void NCIPKMNFKAF(Entity JKAALOHMCNK, int AMOEKOMGDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000974")]
	[Cpp2IlInjected.Address(RVA = "0x293A6D0", Offset = "0x2938ED0", VA = "0x18293A6D0", Slot = "10")]
	public void EKOGHAFLLCD(LPLJHAHPEEF BBNGIDIFEAM, CLPCIHAOJOM LGKGBPHHHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000975")]
	[Cpp2IlInjected.Address(RVA = "0x293ADD0", Offset = "0x29395D0", VA = "0x18293ADD0", Slot = "9")]
	public CLPCIHAOJOM NCGJPMEIIBJ(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(CLPCIHAOJOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000976")]
	[Cpp2IlInjected.Address(RVA = "0x293A980", Offset = "0x2939180", VA = "0x18293A980", Slot = "11")]
	public LPLJHAHPEEF KLJAFGCLOOF(LPLJHAHPEEF DDLDDCCMMCB, [Optional] float3? PAOMABBDKAH, [Optional] quaternion? APAHFEOKBOD, [Optional] float3? FJJHHNAFAEK)
	{
		return default(LPLJHAHPEEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(RVA = "0x293A7A0", Offset = "0x2938FA0", VA = "0x18293A7A0", Slot = "12")]
	public LPLJHAHPEEF GOKBPNBGHBJ(LPLJHAHPEEF DDLDDCCMMCB, int AMOEKOMGDLG, [Optional] float3? PAOMABBDKAH, [Optional] quaternion? APAHFEOKBOD, [Optional] float3? FJJHHNAFAEK)
	{
		return default(LPLJHAHPEEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000978")]
	[Cpp2IlInjected.Address(RVA = "0x293A050", Offset = "0x2938850", VA = "0x18293A050")]
	private LPLJHAHPEEF AMJKNOCHOFK(LPLJHAHPEEF DDLDDCCMMCB, int AMOEKOMGDLG, [Optional] float3? PAOMABBDKAH, [Optional] quaternion? APAHFEOKBOD, [Optional] float3? FJJHHNAFAEK)
	{
		return default(LPLJHAHPEEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000979")]
	[Cpp2IlInjected.Address(RVA = "0x293AA20", Offset = "0x2939220", VA = "0x18293AA20", Slot = "7")]
	public LPLJHAHPEEF KOPKNHHCEDF(LPLJHAHPEEF DDLDDCCMMCB, int AMOEKOMGDLG)
	{
		return default(LPLJHAHPEEF);
	}

	[Cpp2IlInjected.Token(Token = "0x600097A")]
	[Cpp2IlInjected.Address(RVA = "0x293AD10", Offset = "0x2939510", VA = "0x18293AD10", Slot = "16")]
	public void MGAAOGPKNPD(LPLJHAHPEEF DDLDDCCMMCB, LPLJHAHPEEF JKAALOHMCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097B")]
	[Cpp2IlInjected.Address(RVA = "0x293AF20", Offset = "0x2939720", VA = "0x18293AF20", Slot = "13")]
	public void NDMOLDIAMKP(LPLJHAHPEEF DDLDDCCMMCB, int AMOEKOMGDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097C")]
	[Cpp2IlInjected.Address(RVA = "0x293A380", Offset = "0x2938B80", VA = "0x18293A380", Slot = "14")]
	public void BFBENNIJCMB(LPLJHAHPEEF DDLDDCCMMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097D")]
	[Cpp2IlInjected.Address(RVA = "0x293AC30", Offset = "0x2939430", VA = "0x18293AC30", Slot = "8")]
	public int LMJPKCHPFDI(LPLJHAHPEEF DDLDDCCMMCB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600097E")]
	[Cpp2IlInjected.Address(RVA = "0x293A2F0", Offset = "0x2938AF0", VA = "0x18293A2F0", Slot = "6")]
	[IteratorStateMachine(typeof(HEIPKCLOEHD))]
	public IEnumerable<LPLJHAHPEEF> APFFHKPGKIK(LPLJHAHPEEF DDLDDCCMMCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600097F")]
	[Cpp2IlInjected.Address(RVA = "0x293AB60", Offset = "0x2939360", VA = "0x18293AB60")]
	private bool LJNOFKDJAMI(LPLJHAHPEEF DDLDDCCMMCB, out NativeArray<Entity> LHKEFPJAGID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000980")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public OCAFGFHHIIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
[AlwaysUpdateSystem]
public class KEIPEAJAIEM : NHLEGKPBPCC
{
	[Cpp2IlInjected.Token(Token = "0x6000989")]
	[Cpp2IlInjected.Address(RVA = "0x24F7490", Offset = "0x24F5C90", VA = "0x1824F7490", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098A")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public KEIPEAJAIEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
internal class BJOCCCFCNME : GKEKBMGOHDE
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000190")]
	public struct CKPAMBICKMP : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x4000539")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	protected override ComponentType DGPOOFGMLPO
	{
		[Cpp2IlInjected.Token(Token = "0x600098C")]
		[Cpp2IlInjected.Address(RVA = "0x289E580", Offset = "0x289CD80", VA = "0x18289E580", Slot = "15")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	protected override ComponentType PPHMGJJPIMB
	{
		[Cpp2IlInjected.Token(Token = "0x600098D")]
		[Cpp2IlInjected.Address(RVA = "0x289E5B0", Offset = "0x289CDB0", VA = "0x18289E5B0", Slot = "16")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	protected override ComponentType KBLJDBJPDPC
	{
		[Cpp2IlInjected.Token(Token = "0x600098E")]
		[Cpp2IlInjected.Address(RVA = "0x289E550", Offset = "0x289CD50", VA = "0x18289E550", Slot = "17")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600098B")]
	[Cpp2IlInjected.Address(RVA = "0x289E670", Offset = "0x289CE70", VA = "0x18289E670")]
	public BJOCCCFCNME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
public class AIPCKODDPNE : NHLEGKPBPCC, NOHOJBNCAJC
{
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	private JIHNNDGLHPF JBPDPEIHKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	private IGBOJICGIKC JBKCICGKJOH;

	[Cpp2IlInjected.Token(Token = "0x6000990")]
	[Cpp2IlInjected.Address(RVA = "0x2897F60", Offset = "0x2896760", VA = "0x182897F60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000991")]
	[Cpp2IlInjected.Address(RVA = "0x2897DB0", Offset = "0x28965B0", VA = "0x182897DB0", Slot = "14")]
	public void GGJEPBDNAAH(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000992")]
	[Cpp2IlInjected.Address(RVA = "0x2897F70", Offset = "0x2896770", VA = "0x182897F70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000993")]
	[Cpp2IlInjected.Address(RVA = "0x2897C30", Offset = "0x2896430", VA = "0x182897C30")]
	private static void BGCMAMGGGDD(EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF, Entity GJPBCFJDGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000994")]
	[Cpp2IlInjected.Address(RVA = "0x2897EC0", Offset = "0x28966C0", VA = "0x182897EC0")]
	private static bool LOMNBKALOHK(EntityManager EADLBIHJKBG, Entity AJDEFAPHMKF, out Transform LAMNAOAMKPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000995")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public AIPCKODDPNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000192")]
public struct FEKDHFGFMGK<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private AHMKCFBDMHK<T> MNJCDKNLLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	private EntityCommandBuffer PFGPHODPKBL;

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public AHMKCFBDMHK<T> MIHGOMAJGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000997")]
		[Cpp2IlInjected.Address(RVA = "0x1AB0710", Offset = "0x1AAEF10", VA = "0x181AB0710")]
		get
		{
			return default(AHMKCFBDMHK<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000998")]
	[Cpp2IlInjected.Address(RVA = "0x27C8140", Offset = "0x27C6940", VA = "0x1827C8140")]
	public FEKDHFGFMGK(AHMKCFBDMHK<T> MNJCDKNLLPF, EntityCommandBuffer PFGPHODPKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000999")]
	[Cpp2IlInjected.Address(RVA = "0x3482C60", Offset = "0x3481460", VA = "0x183482C60")]
	public void FAOLGOEEALP(LAPGECLMCFE<T> EEDFLIADBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600099A")]
	[Cpp2IlInjected.Address(RVA = "0x34823F0", Offset = "0x3480BF0", VA = "0x1834823F0", Slot = "4")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600099B")]
	[Cpp2IlInjected.Address(RVA = "0x27C8120", Offset = "0x27C6920", VA = "0x1827C8120")]
	public static AHMKCFBDMHK<T> HFMFJLJFEMO(FEKDHFGFMGK<T> LAEIDNKAKOO)
	{
		return default(AHMKCFBDMHK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000193")]
public class FBINHHLEGLD : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	public FKKNGLCNOFO CKMMOGKGLFH;

	[Cpp2IlInjected.Token(Token = "0x600099C")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public FBINHHLEGLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600099D")]
	[Cpp2IlInjected.Address(RVA = "0x8BA230", Offset = "0x8B8A30", VA = "0x1808BA230")]
	public FBINHHLEGLD(FKKNGLCNOFO CKMMOGKGLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600099E")]
	[Cpp2IlInjected.Address(RVA = "0x2C76360", Offset = "0x2C74B60", VA = "0x182C76360", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[LJMILPFECGO]
	[CompilerGenerated]
	public class PostDeserializeUpgrade_Convert_SerializeEmbodiedData : HEKIBFENEHC
	{
		[Cpp2IlInjected.Token(Token = "0x2000195")]
		[NoAlias]
		[BurstCompile]
		private struct PostDeserializeUpgrade_Convert_SerializeEmbodiedData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000541")]
			public PMBACLANEMA<KACKGCNPIME> v0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000542")]
			public JBMKEACBOEA<LBOGIIBCODE> v1;

			[Cpp2IlInjected.Token(Token = "0x60009A6")]
			[Cpp2IlInjected.Address(RVA = "0x22394D0", Offset = "0x2237CD0", VA = "0x1822394D0")]
			private void BNHOJHOEIPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009A7")]
			[Cpp2IlInjected.Address(RVA = "0x2239730", Offset = "0x2237F30", VA = "0x182239730", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000540")]
		private static readonly JNGNMMOLKFF log;

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		protected override JNGNMMOLKFF Log
		{
			[Cpp2IlInjected.Token(Token = "0x600099F")]
			[Cpp2IlInjected.Address(RVA = "0x22CB5C0", Offset = "0x22C9DC0", VA = "0x1822CB5C0", Slot = "14")]
			get
			{
				return default(JNGNMMOLKFF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0x22CB500", Offset = "0x22C9D00", VA = "0x1822CB500", Slot = "15")]
		public override IEnumerable<CICEKNFDMIA.JGNBJAKJHDD> PMIFINAIMEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009A1")]
		[Cpp2IlInjected.Address(RVA = "0x22CB260", Offset = "0x22C9A60", VA = "0x1822CB260", Slot = "16")]
		protected override void EKEMAMGGCKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0x22CB3D0", Offset = "0x22C9BD0", VA = "0x1822CB3D0")]
		private JobHandle KNNHGDBBHLK(PMBACLANEMA<KACKGCNPIME> v0, JBMKEACBOEA<LBOGIIBCODE> v1, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A3")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0x22CA150", Offset = "0x22C8950", VA = "0x1822CA150")]
		public PostDeserializeUpgrade_Convert_SerializeEmbodiedData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000196")]
[AlwaysUpdateSystem]
internal class NHAEKJHIEAN : NHLEGKPBPCC
{
	[Cpp2IlInjected.Token(Token = "0x60009A8")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A9")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public NHAEKJHIEAN()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	public class DebugPostLoadValidateParentData : JKEMFGGLHGI, NOFCHOCEBPC
	{
		[Cpp2IlInjected.Token(Token = "0x2000198")]
		private struct DebugPostLoadValidateParentData_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000546")]
			public DebugPostLoadValidateParentData __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000547")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000548")]
			[ReadOnly]
			public ComponentTypeHandle<OEKNEICFKDA> __parentDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60009B0")]
			[Cpp2IlInjected.Address(RVA = "0x222C030", Offset = "0x222A830", VA = "0x18222C030")]
			private void BNHOJHOEIPF(Entity entity, in OEKNEICFKDA parentData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009B1")]
			[Cpp2IlInjected.Address(RVA = "0x222C280", Offset = "0x222AA80", VA = "0x18222C280", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private HMBELPNBOEG objects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private EntityQuery DebugPostLoadValidateParentData_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private ComponentTypeHandle<OEKNEICFKDA> __RecRoom_Components_ParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60009AA")]
		[Cpp2IlInjected.Address(RVA = "0x2C6E3D0", Offset = "0x2C6CBD0", VA = "0x182C6E3D0", Slot = "14")]
		public void InitReferences(NCFCHDEHMHC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AB")]
		[Cpp2IlInjected.Address(RVA = "0x2C6E2F0", Offset = "0x2C6CAF0", VA = "0x182C6E2F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AC")]
		[Cpp2IlInjected.Address(RVA = "0x2C6E2F0", Offset = "0x2C6CAF0", VA = "0x182C6E2F0")]
		private void IIENFJPCMBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0x2C6E660", Offset = "0x2C6CE60", VA = "0x182C6E660", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
		public DebugPostLoadValidateParentData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0x2C6E430", Offset = "0x2C6CC30", VA = "0x182C6E430")]
		[CompilerGenerated]
		private void OAJIAPOIEBP(Entity entity, in OEKNEICFKDA parentData)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
internal class KNIEMIBGPCB : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	private EntityQuery EGFJCKOAGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	private object OBEHKIMFNMI;

	[Cpp2IlInjected.Token(Token = "0x60009B2")]
	[Cpp2IlInjected.Address(RVA = "0x291E720", Offset = "0x291CF20", VA = "0x18291E720", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B3")]
	[Cpp2IlInjected.Address(RVA = "0x291E7A0", Offset = "0x291CFA0", VA = "0x18291E7A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B4")]
	[Cpp2IlInjected.Address(RVA = "0x291E840", Offset = "0x291D040", VA = "0x18291E840", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B5")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public KNIEMIBGPCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
[BurstCompatible]
internal readonly struct BCMDGDBJKKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	private readonly HMJCDHFLPNL MKKKJIKFMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	private readonly HGBMIMHDHLI PDONLOAMCIM;

	[Cpp2IlInjected.Token(Token = "0x60009B6")]
	[Cpp2IlInjected.Address(RVA = "0xAB38B0", Offset = "0xAB20B0", VA = "0x180AB38B0")]
	public BCMDGDBJKKM(HMJCDHFLPNL MKKKJIKFMKD, HGBMIMHDHLI PDONLOAMCIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B7")]
	[Cpp2IlInjected.Address(RVA = "0x289A760", Offset = "0x2898F60", VA = "0x18289A760")]
	public bool AJIMDCHLFBJ(BCMDGDBJKKM GJPBCFJDGCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009B8")]
	[Cpp2IlInjected.Address(RVA = "0x289A760", Offset = "0x2898F60", VA = "0x18289A760")]
	public bool AGBDJEHDLIB(BCMDGDBJKKM CICDHHEGIAO)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
	public class CalculateContainerCollisionIslandGraphChangesSystem : NHLEGKPBPCC, NOFCHOCEBPC
	{
		[Cpp2IlInjected.Token(Token = "0x200019C")]
		[BurstCompile]
		private struct FindChangedIslandsJob : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000556")]
			[ReadOnly]
			public EntityQueryInJob deletedConnectablesQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000557")]
			[ReadOnly]
			public EntityQueryInJob changedIslandQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000558")]
			[ReadOnly]
			public EntityQueryInJob hierarchyChangeQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000559")]
			[ReadOnly]
			public EntityQueryInJob newRootsQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400055A")]
			[ReadOnly]
			public ChunkFilterAnyOf2ComponentsChanged islandSplitChangeFilterRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400055B")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400055C")]
			[ReadOnly]
			public ComponentTypeHandle<MHJCILPGKCM> islandRootSystemDataTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400055D")]
			[ReadOnly]
			public ComponentDataFromEntity<NGMHPAKIICG> dontPropagatePhysicsPropertiesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400055E")]
			[ReadOnly]
			public ComponentDataFromEntity<HMJCDHFLPNL> containerCollisionModeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x400055F")]
			[ReadOnly]
			public ComponentDataFromEntity<HGBMIMHDHLI> containerCollisionLayerRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000560")]
			[ReadOnly]
			public ComponentDataFromEntity<FIEPIGFPDKC> containerCollisionIslandRootTagRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000561")]
			[ReadOnly]
			public ComponentDataFromEntity<OEKNEICFKDA> parentRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x4000562")]
			[ReadOnly]
			public BufferFromEntity<OEOKFMKAJDD> childrenRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x4000563")]
			[WriteOnly]
			public NativeList<Entity> changedIslandComponentsBufferWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x4000564")]
			[WriteOnly]
			public NativeList<HFNGPMMDMJB> changedIslandRootsWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000565")]
			[WriteOnly]
			public NativeList<Entity> removedIslandRootsWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x4000566")]
			[WriteOnly]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x4000567")]
			public ComponentDataFromEntity<LFKGMFOLOLO> collisionIslandRootDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
			[Cpp2IlInjected.Token(Token = "0x4000568")]
			public NativeParallelHashSet<Entity> visitedRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
			[Cpp2IlInjected.Token(Token = "0x4000569")]
			private int bufferHead;

			[Cpp2IlInjected.Token(Token = "0x60009C1")]
			[Cpp2IlInjected.Address(RVA = "0x222CC20", Offset = "0x222B420", VA = "0x18222CC20", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009C2")]
			[Cpp2IlInjected.Address(RVA = "0x222D290", Offset = "0x222BA90", VA = "0x18222D290")]
			private void FCDGPHEMGOF(Entity startEntity, bool checkForUnchanged)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009C3")]
			[Cpp2IlInjected.Address(RVA = "0x222CAD0", Offset = "0x222B2D0", VA = "0x18222CAD0")]
			private Entity DDNKEIMMAKB(Entity curEntity, BCMDGDBJKKM classifier)
			{
				return default(Entity);
			}

			[Cpp2IlInjected.Token(Token = "0x60009C4")]
			[Cpp2IlInjected.Address(RVA = "0x222CB50", Offset = "0x222B350", VA = "0x18222CB50")]
			private bool DOOHFDHGAGH(Entity curEntity, BCMDGDBJKKM classifier, out Entity parentEntity, out BCMDGDBJKKM parentClassifier)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60009C5")]
			[Cpp2IlInjected.Address(RVA = "0x222D650", Offset = "0x222BE50", VA = "0x18222D650")]
			private void KNEMKOHMCDK(Entity islandRoot, BCMDGDBJKKM classifier)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009C6")]
			[Cpp2IlInjected.Address(RVA = "0x222D450", Offset = "0x222BC50", VA = "0x18222D450")]
			private void HKGKCPNKLEO(Entity islandRoot, Entity entity, BCMDGDBJKKM classifier)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009C7")]
			[Cpp2IlInjected.Address(RVA = "0x222D720", Offset = "0x222BF20", VA = "0x18222D720")]
			private void MCBMKIFFIDL(Entity islandRoot, Entity component)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009C8")]
			[Cpp2IlInjected.Address(RVA = "0x222CA40", Offset = "0x222B240", VA = "0x18222CA40")]
			private bool CAABKJOCHPL(Entity entity, out BCMDGDBJKKM classifier)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60009C9")]
			[Cpp2IlInjected.Address(RVA = "0x222D800", Offset = "0x222C000", VA = "0x18222D800")]
			private BCMDGDBJKKM OPLCEOPJFLG(Entity entity)
			{
				return default(BCMDGDBJKKM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200019D")]
		[BurstCompile]
		[NoAlias]
		private struct CalculateContainerCollisionIslandGraphChangesSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400056A")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400056B")]
			public NativeList<Entity> removedIslandRootsWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400056C")]
			[ReadOnly]
			public EntityTypeHandle entityType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400056D")]
			public EntityQueryInJob queryInJob;

			[Cpp2IlInjected.Token(Token = "0x60009CA")]
			[Cpp2IlInjected.Address(RVA = "0x222A720", Offset = "0x2228F20", VA = "0x18222A720")]
			private void BNHOJHOEIPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009CB")]
			[Cpp2IlInjected.Address(RVA = "0x222A810", Offset = "0x2229010", VA = "0x18222A810", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		[NAAJCOHOAKA]
		private PHBCFKHMBHC collisionIslandService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private EntityQuery changedIslandStructureQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private EntityQuery hierarchyChangeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private EntityQuery newRootsQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private EntityQuery deletedConnectablesQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		private EntityQuery deletedRootsQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private EntityQuery islandRootDataQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private EntityQuery islandRootTagQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private DIBKMONKCMM ecbs;

		[Cpp2IlInjected.Token(Token = "0x60009B9")]
		[Cpp2IlInjected.Address(RVA = "0x28AD1A0", Offset = "0x28AB9A0", VA = "0x1828AD1A0", Slot = "14")]
		public void InitReferences(NCFCHDEHMHC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BA")]
		[Cpp2IlInjected.Address(RVA = "0x28ADD10", Offset = "0x28AC510", VA = "0x1828ADD10", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BB")]
		[Cpp2IlInjected.Address(RVA = "0x28AE120", Offset = "0x28AC920", VA = "0x1828AE120", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BC")]
		[Cpp2IlInjected.Address(RVA = "0x28AD4B0", Offset = "0x28ABCB0", VA = "0x1828AD4B0")]
		private JobHandle OEHAHBJMGKO(JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x28AD1F0", Offset = "0x28AB9F0", VA = "0x1828AD1F0")]
		private JobHandle JMGOBDJLDPK(JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0x28ADC10", Offset = "0x28AC410", VA = "0x1828ADC10")]
		private JobHandle OLFONJNHDDM(EntityCommandBuffer ecb, NativeList<Entity> removedIslandRootsWO, EntityTypeHandle entityType, EntityQueryInJob queryInJob, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009BF")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
		public CalculateContainerCollisionIslandGraphChangesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
[GCAKKMGPAEI]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
public class NGNOLPBKMLD : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400056F")]
	private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> LGLNAOOFCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000570")]
	private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> LBBINOHLGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000571")]
	private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> GLGPFOPJLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000572")]
	private FJKBBPDKKKK DIGAIEICIOG;

	[Cpp2IlInjected.Token(Token = "0x60009CC")]
	[Cpp2IlInjected.Address(RVA = "0x2931720", Offset = "0x292FF20", VA = "0x182931720", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CD")]
	[Cpp2IlInjected.Address(RVA = "0x2931DA0", Offset = "0x29305A0", VA = "0x182931DA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CE")]
	[Cpp2IlInjected.Address(RVA = "0x2931410", Offset = "0x292FC10", VA = "0x182931410")]
	private void DLJDCNBGMOF(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> DFMKDLJIHMN, EntityQueryDesc HNINKDPLMEG, bool JICGNHIFHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CF")]
	[Cpp2IlInjected.Address(RVA = "0x29312D0", Offset = "0x292FAD0", VA = "0x1829312D0")]
	private void DLJDCNBGMOF(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> DFMKDLJIHMN, EntityQueryDesc HNINKDPLMEG, bool JICGNHIFHFC, bool KFENDEDNACE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D0")]
	[Cpp2IlInjected.Address(RVA = "0x2932000", Offset = "0x2930800", VA = "0x182932000", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D1")]
	[Cpp2IlInjected.Address(RVA = "0x2931BF0", Offset = "0x29303F0", VA = "0x182931BF0")]
	private void OLEEDMGNOMI(EntityQuery EGFJCKOAGFH, bool DLNDPILNEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D2")]
	[Cpp2IlInjected.Address(RVA = "0x2931770", Offset = "0x292FF70", VA = "0x182931770")]
	private void JPPLNCDEFPO(EntityQuery EGFJCKOAGFH, bool NCMOKGMACCN, bool DLNDPILNEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D3")]
	[Cpp2IlInjected.Address(RVA = "0x2930E90", Offset = "0x292F690", VA = "0x182930E90")]
	private void BBDPANLMFLE(NativeArray<Entity> KFLBCCAJFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D4")]
	[Cpp2IlInjected.Address(RVA = "0x2931960", Offset = "0x2930160", VA = "0x182931960")]
	private void LKFPMPAKKPE(NativeList<Entity> KFLBCCAJFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D5")]
	[Cpp2IlInjected.Address(RVA = "0x2931AD0", Offset = "0x29302D0", VA = "0x182931AD0")]
	private void MINEGBHPMIM(NativeArray<Entity> KFLBCCAJFMN, bool NCMOKGMACCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D6")]
	[Cpp2IlInjected.Address(RVA = "0x29310B0", Offset = "0x292F8B0", VA = "0x1829310B0")]
	private NativeList<Entity> BMKCPLPPDGA(NativeArray<Entity> KFLBCCAJFMN)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60009D7")]
	[Cpp2IlInjected.Address(RVA = "0x2931920", Offset = "0x2930120", VA = "0x182931920")]
	private NativeList<Entity> LCBMIFLCLEJ(NativeArray<Entity> KFLBCCAJFMN)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60009D8")]
	[Cpp2IlInjected.Address(RVA = "0x2931520", Offset = "0x292FD20", VA = "0x182931520")]
	private NativeList<Entity> GKEKCCKBDHG(NativeArray<Entity> KFLBCCAJFMN)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60009D9")]
	[Cpp2IlInjected.Address(RVA = "0x2931560", Offset = "0x292FD60", VA = "0x182931560")]
	private NativeList<Entity> HCAGBJPAIPL(NativeArray<Entity> KFLBCCAJFMN, bool CJFDGLMAJDG)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60009DA")]
	[Cpp2IlInjected.Address(RVA = "0x29323B0", Offset = "0x2930BB0", VA = "0x1829323B0")]
	public NGNOLPBKMLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
internal class FNGLFBAMFFC : FFGKGHJCIFC
{
	[Cpp2IlInjected.Token(Token = "0x17000121")]
	protected override DGHCNLKFLNE JAJKCIDCJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60009DC")]
		[Cpp2IlInjected.Address(RVA = "0x2C7B560", Offset = "0x2C79D60", VA = "0x182C7B560", Slot = "15")]
		get
		{
			return default(DGHCNLKFLNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009DD")]
	[Cpp2IlInjected.Address(RVA = "0x2C76970", Offset = "0x2C75170", VA = "0x182C76970")]
	public FNGLFBAMFFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
[UpdateBefore(typeof(NIKFBANPONG))]
public class MLLOPLHFGEJ : NHLEGKPBPCC
{
	[Cpp2IlInjected.Token(Token = "0x4000573")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000574")]
	private EntityQuery EGFJCKOAGFH;

	[Cpp2IlInjected.Token(Token = "0x60009DE")]
	[Cpp2IlInjected.Address(RVA = "0x292BBB0", Offset = "0x292A3B0", VA = "0x18292BBB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0x292BC50", Offset = "0x292A450", VA = "0x18292BC50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public MLLOPLHFGEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
public class JOHOFCACPMC : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.Token(Token = "0x20001A2")]
	[BurstCompile]
	private struct JNOKDLFAMIH : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		[ReadOnly]
		public ComponentDataFromEntity<PMHMNKDEJIA> JOGAOKKMAID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		[ReadOnly]
		public NativeArray<Entity> KFLBCCAJFMN;

		[Cpp2IlInjected.Token(Token = "0x60009EA")]
		[Cpp2IlInjected.Address(RVA = "0x2231FE0", Offset = "0x22307E0", VA = "0x182231FE0", Slot = "4")]
		public void Execute(int AMOEKOMGDLG, TransformAccess LAMNAOAMKPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	[BurstCompile]
	private struct NPHHDGHDPAB : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		[ReadOnly]
		public ComponentDataFromEntity<MEJJCGNBFDD> KDNCCNIJIFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		[ReadOnly]
		public NativeArray<Entity> KFLBCCAJFMN;

		[Cpp2IlInjected.Token(Token = "0x60009EB")]
		[Cpp2IlInjected.Address(RVA = "0x2235D00", Offset = "0x2234500", VA = "0x182235D00", Slot = "4")]
		public void Execute(int AMOEKOMGDLG, TransformAccess LAMNAOAMKPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	[BurstCompile]
	private struct LHOCDOPLOJJ : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		[ReadOnly]
		public ComponentDataFromEntity<MEJJCGNBFDD> KDNCCNIJIFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		[ReadOnly]
		public ComponentDataFromEntity<DIABMIKHCMI> CFECNPKABOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		[ReadOnly]
		public NativeArray<Entity> KFLBCCAJFMN;

		[Cpp2IlInjected.Token(Token = "0x60009EC")]
		[Cpp2IlInjected.Address(RVA = "0x2232AA0", Offset = "0x22312A0", VA = "0x182232AA0", Slot = "4")]
		public void Execute(int AMOEKOMGDLG, TransformAccess LAMNAOAMKPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000575")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x4000576")]
	private static readonly JNGNMMOLKFF CCPALLAFONN;

	[Cpp2IlInjected.Token(Token = "0x4000577")]
	private static readonly JNGNMMOLKFF DCDCHPEPNOG;

	[Cpp2IlInjected.Token(Token = "0x4000578")]
	private static readonly JNGNMMOLKFF IGJNDMKIKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000579")]
	private JNIBHBOFDMB ILMCONKNODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400057A")]
	private EntityQuery OFMOLOGBPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400057B")]
	private EntityQuery GHAPACLKDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400057C")]
	private EntityQuery IDPNENFGDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400057D")]
	private TransformAccessArray MIIDOHMFAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400057E")]
	private TransformAccessArray GNPLFIGHJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400057F")]
	private TransformAccessArray JLJJLPINNFC;

	[Cpp2IlInjected.Token(Token = "0x60009E2")]
	[Cpp2IlInjected.Address(RVA = "0x24F6150", Offset = "0x24F4950", VA = "0x1824F6150", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E3")]
	[Cpp2IlInjected.Address(RVA = "0x24F61A0", Offset = "0x24F49A0", VA = "0x1824F61A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E4")]
	[Cpp2IlInjected.Address(RVA = "0x24F6390", Offset = "0x24F4B90", VA = "0x1824F6390", Slot = "6")]
	protected override void OnStartRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E5")]
	[Cpp2IlInjected.Address(RVA = "0x24F6420", Offset = "0x24F4C20", VA = "0x1824F6420", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E6")]
	[Cpp2IlInjected.Address(RVA = "0x24F6450", Offset = "0x24F4C50", VA = "0x1824F6450", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E7")]
	[Cpp2IlInjected.Address(RVA = "0x24F5FB0", Offset = "0x24F47B0", VA = "0x1824F5FB0")]
	private NativeArray<Entity> EBGIBMNLLDC(NativeArray<OEFBIKKPGEE> EMCPHJIDOJF, NativeList<Entity> FCFOPHNGLIA, TransformAccessArray AANJPEAFNKG, TransformAccessArray CFAGPDIKPOL)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60009E8")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public JOHOFCACPMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A5")]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
internal sealed class MOACMJFJIMI : GJJADNOGMIL
{
	[Cpp2IlInjected.Token(Token = "0x60009ED")]
	[Cpp2IlInjected.Address(RVA = "0x292C060", Offset = "0x292A860", VA = "0x18292C060", Slot = "15")]
	protected override ComponentSystemBase CMFPJFIFJLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009EE")]
	[Cpp2IlInjected.Address(RVA = "0x22BD2C0", Offset = "0x22BBAC0", VA = "0x1822BD2C0")]
	public MOACMJFJIMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A6")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
[KHNAILLFHGJ(typeof(LFLDNNOOPLA), new string[] { })]
internal sealed class LFLDNNOOPLA : NOFCHOCEBPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000587")]
	private static readonly JNGNMMOLKFF EINJMMFJDDI;

	[Cpp2IlInjected.Token(Token = "0x4000588")]
	private static readonly JNGNMMOLKFF JBGKFDADACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000589")]
	[NAAJCOHOAKA]
	private ILBBGIPPPPJ EJLFIBCCMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400058A")]
	private BNCOFINEJLB<IKOMECBEPKO, Entity> BIGPCACKOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400058B")]
	private NDIDPNIFDGF<NHDFJIBLDOE> BNBKOPDNFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400058C")]
	private NDIDPNIFDGF<NCEDEMJMPKG> CAOINCPJLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400058D")]
	private NDIDPNIFDGF<KNGNAEIPJNG> PMPEOBECALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400058E")]
	private NDIDPNIFDGF<AHADAEAHBCD> GJJEKCICKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400058F")]
	private NDIDPNIFDGF<ONBBKEGFFJN> HBLGPEBMOAO;

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public JBEJBDJJMKO<Entity> IFMNILBCBEH
	{
		[Cpp2IlInjected.Token(Token = "0x60009EF")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public CCMLHCDHEIF MCELEPEDGIP
	{
		[Cpp2IlInjected.Token(Token = "0x60009F0")]
		[Cpp2IlInjected.Address(RVA = "0x7EC6C0", Offset = "0x7EAEC0", VA = "0x1807EC6C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public CCMLHCDHEIF FBGOJHCOOAF
	{
		[Cpp2IlInjected.Token(Token = "0x60009F1")]
		[Cpp2IlInjected.Address(RVA = "0x8A5F80", Offset = "0x8A4780", VA = "0x1808A5F80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public CCMLHCDHEIF FHKBCCNAMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60009F2")]
		[Cpp2IlInjected.Address(RVA = "0x7F3350", Offset = "0x7F1B50", VA = "0x1807F3350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public CCMLHCDHEIF NCIOAJBBIEG
	{
		[Cpp2IlInjected.Token(Token = "0x60009F3")]
		[Cpp2IlInjected.Address(RVA = "0x7ED740", Offset = "0x7EBF40", VA = "0x1807ED740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public CCMLHCDHEIF LPBLJKJFIEC
	{
		[Cpp2IlInjected.Token(Token = "0x60009F4")]
		[Cpp2IlInjected.Address(RVA = "0x8A69F0", Offset = "0x8A51F0", VA = "0x1808A69F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	private EntityManager EOOAJAELBGN
	{
		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0x2926880", Offset = "0x2925080", VA = "0x182926880")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009F6")]
	[Cpp2IlInjected.Address(RVA = "0x29268D0", Offset = "0x29250D0", VA = "0x1829268D0", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F7")]
	[Cpp2IlInjected.Address(RVA = "0x2926790", Offset = "0x2924F90", VA = "0x182926790", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F8")]
	[Cpp2IlInjected.Address(RVA = "0x1DABDF0", Offset = "0x1DAA5F0", VA = "0x181DABDF0")]
	private void LDEGPCHGKNG<T>(ref NDIDPNIFDGF<T> GPOKKGHABCA, EntityCommandBufferSystem KFAEBKFHHLM, JNGNMMOLKFF MBNJNNGOKFP) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F9")]
	[Cpp2IlInjected.Address(RVA = "0x1DABEA0", Offset = "0x1DAA6A0", VA = "0x181DABEA0")]
	private void LDEGPCHGKNG<TC, TV>(ref BNCOFINEJLB<TC, TV> GPOKKGHABCA) where TC : struct, KMINMJBDKBF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FA")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public LFLDNNOOPLA()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001A7")]
public struct NCEDEMJMPKG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001A8")]
public struct NHDFJIBLDOE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001A9")]
public struct KNGNAEIPJNG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001AA")]
public struct AHADAEAHBCD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001AB")]
public struct ONBBKEGFFJN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20001AC")]
[ExecuteAlways]
public class HPKELOBHOAB : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x60009FC")]
	[Cpp2IlInjected.Address(RVA = "0x7E01F0", Offset = "0x7DE9F0", VA = "0x1807E01F0")]
	public HPKELOBHOAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AD")]
internal readonly struct BMONKDLIOFJ
{
	[Cpp2IlInjected.Token(Token = "0x20001AE")]
	[CompilerGenerated]
	private sealed class LCOENCCEFKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public NHLEGKPBPCC system;

		[Cpp2IlInjected.Token(Token = "0x6000A00")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public LCOENCCEFKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x2232870", Offset = "0x2231070", VA = "0x182232870")]
		internal (EntityQuery, ComponentType) HLKJEHOPEEL((ComponentType userTag, ComponentType stateTag, ComponentType componentTag) t)
		{
			return default((EntityQuery, ComponentType));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000590")]
	private static readonly ProfilerMarker AJAJOBDBGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000591")]
	private readonly NHLEGKPBPCC EDPKAJCAKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000592")]
	private readonly (EntityQuery userTagQuery, ComponentType stateTag)[] MMHDEBDLEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000593")]
	private readonly EntityQuery FJHEPPCDNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000594")]
	private readonly EntityQuery JEIFOBMNKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000595")]
	private readonly ComponentTypes GKGPHEKGFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000596")]
	private readonly ComponentTypes PBJPOCMIAHB;

	[Cpp2IlInjected.Token(Token = "0x60009FD")]
	[Cpp2IlInjected.Address(RVA = "0x289EF40", Offset = "0x289D740", VA = "0x18289EF40")]
	public BMONKDLIOFJ(NHLEGKPBPCC EDPKAJCAKAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FE")]
	[Cpp2IlInjected.Address(RVA = "0x289EC80", Offset = "0x289D480", VA = "0x18289EC80")]
	public void DNNKNEBJAJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public class IEGFGCNCFJG : EEGODALIIAO
{
	[Cpp2IlInjected.Token(Token = "0x6000A06")]
	[Cpp2IlInjected.Address(RVA = "0x24EC1B0", Offset = "0x24EA9B0", VA = "0x1824EC1B0", Slot = "14")]
	protected override EntityCommandBufferSystem EFIPACDBNFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A07")]
	[Cpp2IlInjected.Address(RVA = "0x22CA150", Offset = "0x22C8950", VA = "0x1822CA150")]
	public IEGFGCNCFJG()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001B1")]
	[GCAKKMGPAEI]
	[CompilerGenerated]
	public class DebugPostDeserializeRemoveOrphanedSplinePoints : JKEMFGGLHGI
	{
		[Cpp2IlInjected.Token(Token = "0x20001B2")]
		[NoAlias]
		[BurstCompile]
		private struct DebugPostDeserializeRemoveOrphanedSplinePoints_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400059E")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400059F")]
			[ReadOnly]
			public ComponentDataFromEntity<CBIEAPMGLPL> splineDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005A0")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40005A1")]
			[ReadOnly]
			public ComponentTypeHandle<NLLEHLHFEHG> __pointTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000A0E")]
			[Cpp2IlInjected.Address(RVA = "0x222BCD0", Offset = "0x222A4D0", VA = "0x18222BCD0")]
			private void BNHOJHOEIPF(Entity entity, [NoAlias] in NLLEHLHFEHG point)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A0F")]
			[Cpp2IlInjected.Address(RVA = "0x222BD40", Offset = "0x222A540", VA = "0x18222BD40", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		private EntityQuery DebugPostDeserializeRemoveOrphanedSplinePoints_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		private ComponentTypeHandle<NLLEHLHFEHG> __RecRoom_Components_SplinePointParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000A08")]
		[Cpp2IlInjected.Address(RVA = "0x2C6DC30", Offset = "0x2C6C430", VA = "0x182C6DC30", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A09")]
		[Cpp2IlInjected.Address(RVA = "0x2C6D850", Offset = "0x2C6C050", VA = "0x182C6D850")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private static void FDOEJICNIAD(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0A")]
		[Cpp2IlInjected.Address(RVA = "0x2C6D800", Offset = "0x2C6C000", VA = "0x182C6D800")]
		private EntityCommandBufferSystem EFIPACDBNFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0B")]
		[Cpp2IlInjected.Address(RVA = "0x2C6D8F0", Offset = "0x2C6C0F0", VA = "0x182C6D8F0")]
		private JobHandle HBAKMKCPHFE(EntityCommandBuffer ecb, ComponentDataFromEntity<CBIEAPMGLPL> splineDataRO, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0C")]
		[Cpp2IlInjected.Address(RVA = "0x2C6DA30", Offset = "0x2C6C230", VA = "0x182C6DA30", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0D")]
		[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
		public DebugPostDeserializeRemoveOrphanedSplinePoints()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
public struct LAPGECLMCFE<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A2")]
	[ReadOnly]
	public EntityQueryInJob EGFJCKOAGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A3")]
	[ReadOnly]
	public EntityTypeHandle GIJMAJGJOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A4")]
	[ReadOnly]
	public ComponentTypeHandle<T> APLOJPKPABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A5")]
	[WriteOnly]
	public EntityCommandBuffer PFGPHODPKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A6")]
	public AllocatorManager.AllocatorHandle HMGEFCKKBID;

	[Cpp2IlInjected.Token(Token = "0x6000A10")]
	[Cpp2IlInjected.Address(RVA = "0x24CE3C0", Offset = "0x24CCBC0", VA = "0x1824CE3C0")]
	public AHMKCFBDMHK<T> NKOFHFCALHN()
	{
		return default(AHMKCFBDMHK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B4")]
public static class LEFOCLBPFOK
{
	[Cpp2IlInjected.Token(Token = "0x20001B5")]
	[BurstCompile]
	private struct JKGJBKLNGMJ : IJob, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		[ReadOnly]
		public NativeParallelHashSet<int> DOOGPFCBHEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		[ReadOnly]
		public NativeArray<ArchetypeChunk> IANHEBIGNNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public NativeList<EntityArchetype> HDFNKMIBGMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public NativeList<BECDCKEMJCA> LLEFNJMPEML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public NativeList<BECDCKEMJCA> LGCLDEMKAPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public NativeList<ComponentType> JNDNJFENPIP;

		[Cpp2IlInjected.Token(Token = "0x6000A1A")]
		[Cpp2IlInjected.Address(RVA = "0x2231900", Offset = "0x2230100", VA = "0x182231900", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1B")]
		[Cpp2IlInjected.Address(RVA = "0x2231870", Offset = "0x2230070", VA = "0x182231870", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A11")]
	[Cpp2IlInjected.Address(RVA = "0x2925F40", Offset = "0x2924740", VA = "0x182925F40")]
	public static NativeParallelHashSet<int> HHJJEBILJCI(Allocator HMGEFCKKBID)
	{
		return default(NativeParallelHashSet<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A12")]
	[Cpp2IlInjected.Address(RVA = "0x2926020", Offset = "0x2924820", VA = "0x182926020")]
	public static NativeParallelHashSet<int> MJGCDANBKAM(Allocator HMGEFCKKBID)
	{
		return default(NativeParallelHashSet<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A13")]
	[Cpp2IlInjected.Address(RVA = "0x2926310", Offset = "0x2924B10", VA = "0x182926310")]
	private static void OPBEILFHCND(NativeParallelHashSet<int> OJICEFMMHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A14")]
	[Cpp2IlInjected.Address(RVA = "0x2925E50", Offset = "0x2924650", VA = "0x182925E50")]
	private static bool FGDAPGDPIAN(Type EIOLDDJPDLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A15")]
	[Cpp2IlInjected.Address(RVA = "0x2925CC0", Offset = "0x29244C0", VA = "0x182925CC0")]
	private static void EOFBFJJKENM(NativeParallelHashSet<int> OJICEFMMHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A16")]
	[Cpp2IlInjected.Address(RVA = "0x2926180", Offset = "0x2924980", VA = "0x182926180")]
	private static void NPDHIODBBNE(NativeParallelHashSet<int> OJICEFMMHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A17")]
	[Cpp2IlInjected.Address(RVA = "0x2926600", Offset = "0x2924E00", VA = "0x182926600")]
	private static void POCMPDKACLG(NativeParallelHashSet<int> OJICEFMMHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A18")]
	[Cpp2IlInjected.Address(RVA = "0x29252B0", Offset = "0x2923AB0", VA = "0x1829252B0")]
	public static void AIIGEKLBBFL(EntityManager EADLBIHJKBG, EntityQuery EGFJCKOAGFH, NativeParallelHashSet<int> HMDFAKJNKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A19")]
	[Cpp2IlInjected.Address(RVA = "0x2925B40", Offset = "0x2924340", VA = "0x182925B40")]
	public static void BAJGJIKLCEJ(EntityManager EADLBIHJKBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
public class MOAPPDFNJDP : ParentSystemBase<OEKNEICFKDA, ANDKGOKDDMF, OEOKFMKAJDD>
{
	[Cpp2IlInjected.Token(Token = "0x6000A1C")]
	[Cpp2IlInjected.Address(RVA = "0x292C1F0", Offset = "0x292A9F0", VA = "0x18292C1F0", Slot = "14")]
	protected override EntityQueryDesc HHDIEBNJPNI(EntityQueryDesc EGFJCKOAGFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1D")]
	[Cpp2IlInjected.Address(RVA = "0xA43800", Offset = "0xA42000", VA = "0x180A43800", Slot = "15")]
	protected override EntityQueryDesc OIKCAAPELJM(EntityQueryDesc EGFJCKOAGFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1E")]
	[Cpp2IlInjected.Address(RVA = "0x292C230", Offset = "0x292AA30", VA = "0x18292C230", Slot = "16")]
	protected override EntityQueryDesc PKLNOMEPJCH(EntityQueryDesc EGFJCKOAGFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1F")]
	[Cpp2IlInjected.Address(RVA = "0x292C1B0", Offset = "0x292A9B0", VA = "0x18292C1B0", Slot = "17")]
	protected override EntityQueryDesc AFCIKCANODJ(EntityQueryDesc EGFJCKOAGFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A20")]
	[Cpp2IlInjected.Address(RVA = "0x292C270", Offset = "0x292AA70", VA = "0x18292C270")]
	public MOAPPDFNJDP()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	public abstract class ParentSystemBase<TParentData, TPreviousParentData, TChildrenData> : NHLEGKPBPCC where TParentData : struct, IComponentData, MLFKCOGAANJ where TPreviousParentData : struct, IComponentData, MLFKCOGAANJ where TChildrenData : struct, ISystemStateBufferElementData, IEquatable<TChildrenData>, MLFKCOGAANJ
	{
		[Cpp2IlInjected.Token(Token = "0x20001B8")]
		[BurstCompile]
		internal struct PPGHLGBHEPD : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B5")]
			public NativeParallelMultiHashMap<Entity, Entity>.ParallelWriter NPGLHJMBKLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B6")]
			public NativeParallelMultiHashMap<Entity, Entity>.ParallelWriter JMKNGOGCLBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B7")]
			public NativeParallelHashMap<Entity, int>.ParallelWriter ENLLGBALLMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B8")]
			public ComponentTypeHandle<TPreviousParentData> MEKGGFKHFGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B9")]
			[ReadOnly]
			public ComponentTypeHandle<TParentData> PAMDIDMIANH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005BA")]
			[ReadOnly]
			public EntityTypeHandle PIKBDLFHHBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005BB")]
			public uint EOFDFPDHALO;

			[Cpp2IlInjected.Token(Token = "0x6000A2F")]
			[Cpp2IlInjected.Address(RVA = "0x285A510", Offset = "0x2858D10", VA = "0x18285A510", Slot = "4")]
			public void Execute(ArchetypeChunk OPMNIAACDHI, int LEMMIPLDDBE, int FFOHIDMPEPK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001B9")]
		[BurstCompile]
		internal struct PHCHJGHDJIJ : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005BC")]
			[ReadOnly]
			public NativeParallelHashMap<Entity, int> ENLLGBALLMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005BD")]
			[ReadOnly]
			public BufferFromEntity<TChildrenData> CFKKBLECFLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005BE")]
			public NativeList<Entity> MNIHCIMOCIJ;

			[Cpp2IlInjected.Token(Token = "0x6000A30")]
			[Cpp2IlInjected.Address(RVA = "0x21AFAC0", Offset = "0x21AE2C0", VA = "0x1821AFAC0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001BA")]
		[BurstCompile]
		internal struct BJHAIMLKANP : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005BF")]
			[ReadOnly]
			public NativeParallelMultiHashMap<Entity, Entity> NPGLHJMBKLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C0")]
			[ReadOnly]
			public NativeParallelMultiHashMap<Entity, Entity> JMKNGOGCLBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C1")]
			[ReadOnly]
			public NativeParallelHashMap<Entity, int> ENLLGBALLMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C2")]
			public BufferFromEntity<TChildrenData> CFKKBLECFLL;

			[Cpp2IlInjected.Token(Token = "0x6000A31")]
			[Cpp2IlInjected.Address(RVA = "0x219D7F0", Offset = "0x219BFF0", VA = "0x18219D7F0")]
			private int LAKJGHIJMMJ(DynamicBuffer<TChildrenData> LHKEFPJAGID, Entity AJDEFAPHMKF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A32")]
			[Cpp2IlInjected.Address(RVA = "0x219DB10", Offset = "0x219C310", VA = "0x18219DB10")]
			private void NDAOEMKANKK(Entity GJPBCFJDGCH, DynamicBuffer<TChildrenData> LHKEFPJAGID)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A33")]
			[Cpp2IlInjected.Address(RVA = "0x219D9E0", Offset = "0x219C1E0", VA = "0x18219D9E0")]
			private void MMEIGCCNJEK(Entity GJPBCFJDGCH, DynamicBuffer<TChildrenData> LHKEFPJAGID)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A34")]
			[Cpp2IlInjected.Address(RVA = "0x219D5C0", Offset = "0x219BDC0", VA = "0x18219D5C0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001BB")]
		[BurstCompile]
		private struct GBLDEPOIEMG : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C3")]
			[ReadOnly]
			public NativeArray<Entity> CIOCNGAKCEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C4")]
			public NativeList<Entity> LIHHNICJHIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C5")]
			[ReadOnly]
			public BufferFromEntity<TChildrenData> CFKKBLECFLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C6")]
			[ReadOnly]
			public ComponentDataFromEntity<TParentData> KEMCOCFIPPI;

			[Cpp2IlInjected.Token(Token = "0x6000A35")]
			[Cpp2IlInjected.Address(RVA = "0x2E7C300", Offset = "0x2E7AB00", VA = "0x182E7C300", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		protected EntityQuery EMIALEKNOBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		protected EntityQuery MPCNHDEHNHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		protected EntityQuery BNNJOIHNOAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		protected EntityQuery MNEDONGAOIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		protected ProfilerMarker PPLBGPJCAKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		protected ProfilerMarker EPFLLAKFCME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		protected ProfilerMarker MHDHGPMEICN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		protected ProfilerMarker PFHAKNGICJO;

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0x1F02990", Offset = "0x1F01190", VA = "0x181F02990")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0x1F01860", Offset = "0x1F00060", VA = "0x181F01860")]
		private int LAKJGHIJMMJ(DynamicBuffer<TChildrenData> LHKEFPJAGID, Entity AJDEFAPHMKF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0x1F02010", Offset = "0x1F00810", VA = "0x181F02010")]
		private void OKONMKLIMNF(Entity CJIEJEDLEHL, Entity JLKPALEIHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0xA43800", Offset = "0xA42000", VA = "0x180A43800", Slot = "14")]
		protected virtual EntityQueryDesc HHDIEBNJPNI(EntityQueryDesc EGFJCKOAGFH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A25")]
		[Cpp2IlInjected.Address(RVA = "0xA43800", Offset = "0xA42000", VA = "0x180A43800", Slot = "15")]
		protected virtual EntityQueryDesc OIKCAAPELJM(EntityQueryDesc EGFJCKOAGFH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A26")]
		[Cpp2IlInjected.Address(RVA = "0xA43800", Offset = "0xA42000", VA = "0x180A43800", Slot = "16")]
		protected virtual EntityQueryDesc PKLNOMEPJCH(EntityQueryDesc EGFJCKOAGFH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc AFCIKCANODJ(EntityQueryDesc EGFJCKOAGFH);

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0x1F02450", Offset = "0x1F00C50", VA = "0x181F02450", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A29")]
		[Cpp2IlInjected.Address(RVA = "0x1F01DE0", Offset = "0x1F005E0", VA = "0x181F01DE0")]
		private void NFCPFBMAKMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2A")]
		[Cpp2IlInjected.Address(RVA = "0x1F01950", Offset = "0x1F00150", VA = "0x181F01950")]
		private void LEMKIHAAFCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2B")]
		[Cpp2IlInjected.Address(RVA = "0x1F00470", Offset = "0x1EFEC70", VA = "0x181F00470")]
		private JobHandle DJDMOEOLDHC(JobHandle BFAAEILACKK)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2C")]
		[Cpp2IlInjected.Address(RVA = "0x1F00FF0", Offset = "0x1EFF7F0", VA = "0x181F00FF0")]
		private void JKEHOIDOEPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2D")]
		[Cpp2IlInjected.Address(RVA = "0x1F02760", Offset = "0x1F00F60", VA = "0x181F02760", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2E")]
		[Cpp2IlInjected.Address(RVA = "0x1F02730", Offset = "0x1F00F30", VA = "0x181F02730", Slot = "7")]
		protected override void OnStopRunning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BC")]
public class HLFHEEGFBPH : BGBMHAFAPMG
{
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	protected override NDPOFJCDFMI HGPICIBJGHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000A36")]
		[Cpp2IlInjected.Address(RVA = "0x893100", Offset = "0x891900", VA = "0x180893100", Slot = "15")]
		get
		{
			return default(NDPOFJCDFMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A37")]
	[Cpp2IlInjected.Address(RVA = "0x24E7C10", Offset = "0x24E6410", VA = "0x1824E7C10", Slot = "16")]
	protected override void PJIINLOACPM(NDPOFJCDFMI MNJCDKNLLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A38")]
	[Cpp2IlInjected.Address(RVA = "0x24E7BC0", Offset = "0x24E63C0", VA = "0x1824E7BC0")]
	private EntityCommandBufferSystem EFIPACDBNFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A39")]
	[Cpp2IlInjected.Address(RVA = "0x24E7F70", Offset = "0x24E6770", VA = "0x1824E7F70")]
	public HLFHEEGFBPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BD")]
[GCAKKMGPAEI]
public class JFBHOBLAOFF : JKEMFGGLHGI
{
	[Cpp2IlInjected.Token(Token = "0x20001BE")]
	private struct OBCPGCPHGFA : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		[ReadOnly]
		public NativeParallelHashSet<int> APLGGKBGFKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		[ReadOnly]
		public EntityTypeHandle PEBMAKGHCFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		[ReadOnly]
		public SharedComponentTypeHandle<RRObjectPrefabV2Data> PKFLLMDMIOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public NativeList<Entity>.ParallelWriter OMFGFJFPPLE;

		[Cpp2IlInjected.Token(Token = "0x6000A40")]
		[Cpp2IlInjected.Address(RVA = "0x2235DA0", Offset = "0x22345A0", VA = "0x182235DA0", Slot = "4")]
		public void Execute(ArchetypeChunk OPMNIAACDHI, int LEMMIPLDDBE, int FFOHIDMPEPK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40005C8")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C9")]
	private EntityQuery EGFJCKOAGFH;

	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0x24F4460", Offset = "0x24F2C60", VA = "0x1824F4460", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3C")]
	[Cpp2IlInjected.Address(RVA = "0x24F44F0", Offset = "0x24F2CF0", VA = "0x1824F44F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3D")]
	[Cpp2IlInjected.Address(RVA = "0x24F4410", Offset = "0x24F2C10", VA = "0x1824F4410")]
	private EntityCommandBufferSystem EFIPACDBNFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public JFBHOBLAOFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BF")]
public struct CHFHHLLDIJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CE")]
	public Entity AJDEFAPHMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	public LNBFOKMABPL MMOFNBHFDNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40005D0")]
	public LNBFOKMABPL MAIOOLBIJID;
}
[Cpp2IlInjected.Token(Token = "0x20001C0")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
[KHNAILLFHGJ(typeof(JNIBHBOFDMB), new string[] { })]
internal sealed class JNIBHBOFDMB : PCAPGPPECJN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	private AOOPHAOFFDG DFHGGCIPOAM;

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public AOOPHAOFFDG KEJBIAKDAOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000A41")]
		[Cpp2IlInjected.Address(RVA = "0x24F5AF0", Offset = "0x24F42F0", VA = "0x1824F5AF0")]
		get
		{
			return default(AOOPHAOFFDG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A42")]
	[Cpp2IlInjected.Address(RVA = "0x24F5B10", Offset = "0x24F4310", VA = "0x1824F5B10", Slot = "4")]
	public void PAHLDMJMCEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A43")]
	[Cpp2IlInjected.Address(RVA = "0x24F5AE0", Offset = "0x24F42E0", VA = "0x1824F5AE0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A44")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public JNIBHBOFDMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C1")]
internal sealed class KCOLOCJPOJN : ParentSystemBase<OEKNEICFKDA, ANDKGOKDDMF, OEOKFMKAJDD>
{
	[Cpp2IlInjected.Token(Token = "0x6000A45")]
	[Cpp2IlInjected.Address(RVA = "0xA43800", Offset = "0xA42000", VA = "0x180A43800", Slot = "14")]
	protected override EntityQueryDesc HHDIEBNJPNI(EntityQueryDesc EGFJCKOAGFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A46")]
	[Cpp2IlInjected.Address(RVA = "0xA43800", Offset = "0xA42000", VA = "0x180A43800", Slot = "15")]
	protected override EntityQueryDesc OIKCAAPELJM(EntityQueryDesc EGFJCKOAGFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A47")]
	[Cpp2IlInjected.Address(RVA = "0xA43800", Offset = "0xA42000", VA = "0x180A43800", Slot = "16")]
	protected override EntityQueryDesc PKLNOMEPJCH(EntityQueryDesc EGFJCKOAGFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A48")]
	[Cpp2IlInjected.Address(RVA = "0x24F7320", Offset = "0x24F5B20", VA = "0x1824F7320", Slot = "17")]
	protected override EntityQueryDesc AFCIKCANODJ(EntityQueryDesc EGFJCKOAGFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A49")]
	[Cpp2IlInjected.Address(RVA = "0x24F7360", Offset = "0x24F5B60", VA = "0x1824F7360")]
	public KCOLOCJPOJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C2")]
[KHNAILLFHGJ(typeof(DCAINADNFLE), new string[] { })]
internal class NKBAGEJFBEL : DCAINADNFLE, NOFCHOCEBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D2")]
	[NAAJCOHOAKA]
	private NIKEKFGBDPH KBPHPAFICFO;

	[Cpp2IlInjected.Token(Token = "0x6000A4A")]
	[Cpp2IlInjected.Address(RVA = "0x2933C70", Offset = "0x2932470", VA = "0x182933C70", Slot = "8")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4B")]
	[Cpp2IlInjected.Address(RVA = "0x2933A10", Offset = "0x2932210", VA = "0x182933A10", Slot = "4")]
	public World DANJPMBMOOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4C")]
	[Cpp2IlInjected.Address(RVA = "0x2933BD0", Offset = "0x29323D0", VA = "0x182933BD0", Slot = "5")]
	public World FBFNIJOECHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4D")]
	[Cpp2IlInjected.Address(RVA = "0x2933970", Offset = "0x2932170", VA = "0x182933970", Slot = "6")]
	public World AFLENEOBKJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4E")]
	[Cpp2IlInjected.Address(RVA = "0x2933B30", Offset = "0x2932330", VA = "0x182933B30", Slot = "7")]
	public World DJMDEBFPBND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4F")]
	[Cpp2IlInjected.Address(RVA = "0x2933CC0", Offset = "0x29324C0", VA = "0x182933CC0")]
	private World PFFGBOPKIBK(string MDOAADHDBMA, IBOHJLEOMFL LPNNBGAFKLN, Type JJDPCAAFJJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A50")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public NKBAGEJFBEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C3")]
public enum HPOKAOBOIJC
{
	[Cpp2IlInjected.Token(Token = "0x40005D4")]
	Main,
	[Cpp2IlInjected.Token(Token = "0x40005D5")]
	NetworkReceive,
	[Cpp2IlInjected.Token(Token = "0x40005D6")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x40005D7")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20001C4")]
internal class LBGKGDDKPLH : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005D8")]
	private EntityQuery EGFJCKOAGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005D9")]
	private object OBEHKIMFNMI;

	[Cpp2IlInjected.Token(Token = "0x6000A51")]
	[Cpp2IlInjected.Address(RVA = "0x291EE20", Offset = "0x291D620", VA = "0x18291EE20", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A52")]
	[Cpp2IlInjected.Address(RVA = "0x291EEA0", Offset = "0x291D6A0", VA = "0x18291EEA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x291EF40", Offset = "0x291D740", VA = "0x18291EF40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public LBGKGDDKPLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C5")]
internal class EABLAJAHICM : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.Token(Token = "0x40005DA")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005DB")]
	private NAHGLKOIEAI BOBHLPNKBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	private EntityQuery JLFMHLHELHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	private EntityQuery OHPENLDABAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40005DE")]
	private GJCOMGMOGCM LJAHGKLIMIM;

	[Cpp2IlInjected.Token(Token = "0x6000A55")]
	[Cpp2IlInjected.Address(RVA = "0x2C6F080", Offset = "0x2C6D880", VA = "0x182C6F080", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x2C6F2C0", Offset = "0x2C6DAC0", VA = "0x182C6F2C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x2C6F3D0", Offset = "0x2C6DBD0", VA = "0x182C6F3D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x2C6EE30", Offset = "0x2C6D630", VA = "0x182C6EE30")]
	private void GBNJLPBPANP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x2C6F0F0", Offset = "0x2C6D8F0", VA = "0x182C6F0F0")]
	private void MKANMMBKKFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0x2C6EB10", Offset = "0x2C6D310", VA = "0x182C6EB10")]
	private void GBLMAJHMDNK(NativeArray<Entity> KFLBCCAJFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5B")]
	[Cpp2IlInjected.Address(RVA = "0x2C6EF40", Offset = "0x2C6D740", VA = "0x182C6EF40")]
	private void HDDGPBOLEGJ(NativeArray<Entity> KFLBCCAJFMN, int HONOIEBGKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5C")]
	[Cpp2IlInjected.Address(RVA = "0x2C6E9D0", Offset = "0x2C6D1D0", VA = "0x182C6E9D0")]
	private void AODHDDGAALC(NativeArray<Entity> KFLBCCAJFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0x2C6F260", Offset = "0x2C6DA60", VA = "0x182C6F260")]
	private void OJHIMMOGGLD(Entity AJDEFAPHMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5E")]
	[Cpp2IlInjected.Address(RVA = "0x7EEB90", Offset = "0x7ED390", VA = "0x1807EEB90")]
	private static void HKBOPNBEHGF(int LDFNOAINHMF, Transform LAMNAOAMKPM, Entity AJDEFAPHMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public EABLAJAHICM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C6")]
internal static class EOFFBFILEPO
{
	[Cpp2IlInjected.Token(Token = "0x6000A61")]
	[Cpp2IlInjected.Address(RVA = "0x2C74A30", Offset = "0x2C73230", VA = "0x182C74A30")]
	public static bool NALBIMBLGLF(this SystemBase EDPKAJCAKAA, out Entity AJDEFAPHMKF)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001C7")]
	[CompilerGenerated]
	[KAPPDMKCEOO(JLEAEANKKDG.OMRoom)]
	public class PostLoadRemapCircuitIds : NHLEGKPBPCC, NOFCHOCEBPC
	{
		[Cpp2IlInjected.Token(Token = "0x20001C8")]
		private struct PostLoadRemapCircuitIds_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005E2")]
			public IMKNGLHILIB remap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005E3")]
			public ComponentTypeHandle<FPOOIADGAHL> __nodeTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000A68")]
			[Cpp2IlInjected.Address(RVA = "0x601DB50", Offset = "0x601C350", VA = "0x18601DB50")]
			private void BNHOJHOEIPF(ref FPOOIADGAHL node)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A69")]
			[Cpp2IlInjected.Address(RVA = "0x601DD90", Offset = "0x601C590", VA = "0x18601DD90", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		[NAAJCOHOAKA]
		private ILGLLPNDOPK serialization;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private EntityQuery PostLoadRemapCircuitIds_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		private ComponentTypeHandle<FPOOIADGAHL> __RecRoom_Components_ObjectBoardNodeData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000A62")]
		[Cpp2IlInjected.Address(RVA = "0x22CE860", Offset = "0x22CD060", VA = "0x1822CE860", Slot = "14")]
		public void InitReferences(NCFCHDEHMHC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A63")]
		[Cpp2IlInjected.Address(RVA = "0x22CEBD0", Offset = "0x22CD3D0", VA = "0x1822CEBD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A64")]
		[Cpp2IlInjected.Address(RVA = "0x22CE8B0", Offset = "0x22CD0B0", VA = "0x1822CE8B0")]
		private void OFMONEOCJMO(IMKNGLHILIB remap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A65")]
		[Cpp2IlInjected.Address(RVA = "0x22CE770", Offset = "0x22CCF70", VA = "0x1822CE770")]
		private void ICFOBALBKHL(ref IMKNGLHILIB remap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A66")]
		[Cpp2IlInjected.Address(RVA = "0x22CE9A0", Offset = "0x22CD1A0", VA = "0x1822CE9A0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A67")]
		[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
		public PostLoadRemapCircuitIds()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C9")]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
internal class KFJJNJFDEOB : NHLEGKPBPCC, NOFCHOCEBPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	private static readonly JNGNMMOLKFF ALDBDMMHHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005E6")]
	[NAAJCOHOAKA]
	private DLJKMJDECEO HJIMKOGCLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005E7")]
	[NAAJCOHOAKA]
	private HMBELPNBOEG LNJHNPCFKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005E8")]
	[NAAJCOHOAKA]
	private NMHGLGPLAKN MDDINJABOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005E9")]
	[NAAJCOHOAKA]
	private KOBNMPMOEEH DBEDOFAPJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40005EA")]
	[NAAJCOHOAKA]
	private GOMGMPAPJHK OPPOKHJIOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40005EB")]
	[NAAJCOHOAKA]
	private KBHALIKOHEM KKDJPJAEFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40005EC")]
	private KMBAJEOAHDK.OBNENDELMNH EFOOABLNDCM;

	[Cpp2IlInjected.Token(Token = "0x6000A6A")]
	[Cpp2IlInjected.Address(RVA = "0x24F9640", Offset = "0x24F7E40", VA = "0x1824F9640", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6B")]
	[Cpp2IlInjected.Address(RVA = "0x24F8450", Offset = "0x24F6C50", VA = "0x1824F8450", Slot = "15")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6C")]
	[Cpp2IlInjected.Address(RVA = "0x24FA130", Offset = "0x24F8930", VA = "0x1824FA130", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6D")]
	[Cpp2IlInjected.Address(RVA = "0x24F8FE0", Offset = "0x24F77E0", VA = "0x1824F8FE0")]
	private void IMCHFBCDKNJ(ADKFIICEFJC EECINICJCLK, NativeArray<byte> NBPJKBFCCFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6E")]
	[Cpp2IlInjected.Address(RVA = "0x24F9E10", Offset = "0x24F8610", VA = "0x1824F9E10")]
	private bool MKBBBOBFNPM(ADKFIICEFJC EECINICJCLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6F")]
	[Cpp2IlInjected.Address(RVA = "0x24F81E0", Offset = "0x24F69E0", VA = "0x1824F81E0")]
	private KMBAJEOAHDK.IKADDGCFNCG BOBELOKMLEK(NativeArray<byte> NBPJKBFCCFO, Allocator HMGEFCKKBID)
	{
		return default(KMBAJEOAHDK.IKADDGCFNCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A70")]
	[Cpp2IlInjected.Address(RVA = "0x24F8360", Offset = "0x24F6B60", VA = "0x1824F8360")]
	private void CKONMIBIIIM(KMBAJEOAHDK.IKADDGCFNCG OKDFPIACNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A71")]
	[Cpp2IlInjected.Address(RVA = "0x24F97F0", Offset = "0x24F7FF0", VA = "0x1824F97F0")]
	private void KLNJNAIFIGF(NativeList<MHGAJIKGEGE> OAPBHJIHLMO, NativeList<CBGNFPNAGKM> NHOIGPDOBNB, Allocator HMGEFCKKBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A72")]
	[Cpp2IlInjected.Address(RVA = "0x24F8B20", Offset = "0x24F7320", VA = "0x1824F8B20")]
	private void HAKGDJCACOJ(NativeParallelMultiHashMap<MHGAJIKGEGE, GODHOHPNOGF> DPNIMADKBGF, NativeList<byte> LDNPCLJCBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A73")]
	[Cpp2IlInjected.Address(RVA = "0x24F9ED0", Offset = "0x24F86D0", VA = "0x1824F9ED0")]
	private void NIJFPGDNMDH(NativeList<MHGAJIKGEGE> OKDKKADGGHO, Allocator HMGEFCKKBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A74")]
	[Cpp2IlInjected.Address(RVA = "0x24F9AF0", Offset = "0x24F82F0", VA = "0x1824F9AF0")]
	private void MIKCFACCNPJ(KMBAJEOAHDK.IKADDGCFNCG NFBDMLCENEN, bool EIDBBMBGIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A75")]
	[Cpp2IlInjected.Address(RVA = "0x24F94C0", Offset = "0x24F7CC0", VA = "0x1824F94C0")]
	private void IMFKFCLCJFE(NativeList<MHGAJIKGEGE> OAPBHJIHLMO, NativeList<CBGNFPNAGKM> NHOIGPDOBNB, bool EIDBBMBGIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A76")]
	[Cpp2IlInjected.Address(RVA = "0x24F84F0", Offset = "0x24F6CF0", VA = "0x1824F84F0")]
	private void FNAGCOPEDEH(NativeParallelMultiHashMap<MHGAJIKGEGE, GODHOHPNOGF> DPNIMADKBGF, NativeList<byte> LDNPCLJCBFJ, bool EIDBBMBGIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A77")]
	[Cpp2IlInjected.Address(RVA = "0x24F99E0", Offset = "0x24F81E0", VA = "0x1824F99E0")]
	private void LODJFKLGPIB(NativeList<MHGAJIKGEGE> OKDKKADGGHO, bool EIDBBMBGIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A78")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	private static void NCOIPLIPHJG(ADKFIICEFJC EECINICJCLK, bool EIDBBMBGIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A79")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public KFJJNJFDEOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CA")]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
internal sealed class MAHFAAJPLHG : GJJADNOGMIL
{
	[Cpp2IlInjected.Token(Token = "0x6000A7B")]
	[Cpp2IlInjected.Address(RVA = "0x2929D50", Offset = "0x2928550", VA = "0x182929D50", Slot = "15")]
	protected override ComponentSystemBase CMFPJFIFJLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7C")]
	[Cpp2IlInjected.Address(RVA = "0x22BD2C0", Offset = "0x22BBAC0", VA = "0x1822BD2C0")]
	public MAHFAAJPLHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CB")]
[HHKHACIGOAG(JLEAEANKKDG.LoadInstance)]
internal interface AJNCIBJCEPK
{
	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	NativeParallelMultiHashMap<Entity, EDAOOEIAPHC> MKFGEPHANBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000A7D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	uint EOFDFPDHALO
	{
		[Cpp2IlInjected.Token(Token = "0x6000A7E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HFEIFBDDHGI(NativeArray<MHGAJIKGEGE> OAPBHJIHLMO, NativeArray<CBGNFPNAGKM> NHOIGPDOBNB, NativeArray<MHGAJIKGEGE> OKDKKADGGHO, int JFGAOALCBGN);

	[Cpp2IlInjected.Token(Token = "0x6000A80")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JAHOCLDENEN(in IAPFIKFHMGA CAFNBKIMCBI);

	[Cpp2IlInjected.Token(Token = "0x6000A81")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NMLPGLMJPIG(JobHandle BJJHADPHPJP);
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001CC")]
	[AlwaysUpdateSystem]
	[CompilerGenerated]
	[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
	public class CalculateCollisionIslandUpdatesSystem : NHLEGKPBPCC, NOFCHOCEBPC
	{
		[Cpp2IlInjected.Token(Token = "0x20001CD")]
		[BurstCompile]
		[NoAlias]
		private struct CalculateCollisionIslandUpdatesSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005F3")]
			public NativeList<Entity> rootsWithForcedCollisionUpdate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005F4")]
			public NativeList<Entity> rootsWithoutForcedCollisionUpdate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005F5")]
			[ReadOnly]
			public ComponentTypeHandle<LFKGMFOLOLO> collisionIslandRootDataHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005F6")]
			[ReadOnly]
			public ComponentDataFromEntity<LFKGMFOLOLO> collisionIslandRootDataFromEntityRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40005F7")]
			[ReadOnly]
			public ComponentTypeHandle<NLLEHLHFEHG> splineParentHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40005F8")]
			public EntityQueryInJob changedLocalPoseQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40005F9")]
			public EntityQueryInJob changedSplinePointsQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40005FA")]
			public EntityQueryInJob splinesWithChangedChildrenQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40005FB")]
			public EntityQueryInJob changedCollisionModeQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40005FC")]
			public EntityQueryInJob changedScopeRootQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40005FD")]
			public Allocator allocator;

			[Cpp2IlInjected.Token(Token = "0x6000A88")]
			[Cpp2IlInjected.Address(RVA = "0x2229F10", Offset = "0x2228710", VA = "0x182229F10")]
			private void BNHOJHOEIPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A89")]
			[Cpp2IlInjected.Address(RVA = "0x222A710", Offset = "0x2228F10", VA = "0x18222A710", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private EntityQuery changedLocalPoseQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		private EntityQuery changedSplinePointsQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private EntityQuery splinesWithChangedChildrenQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		private EntityQuery changedCollisionModeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		private EntityQuery scopeRootChangeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		private PHBCFKHMBHC collisionIslandService;

		[Cpp2IlInjected.Token(Token = "0x6000A82")]
		[Cpp2IlInjected.Address(RVA = "0x28AC7B0", Offset = "0x28AAFB0", VA = "0x1828AC7B0", Slot = "14")]
		public void InitReferences(NCFCHDEHMHC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A83")]
		[Cpp2IlInjected.Address(RVA = "0x28AC800", Offset = "0x28AB000", VA = "0x1828AC800", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A84")]
		[Cpp2IlInjected.Address(RVA = "0x28ACB60", Offset = "0x28AB360", VA = "0x1828ACB60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A85")]
		[Cpp2IlInjected.Address(RVA = "0x28AC600", Offset = "0x28AAE00", VA = "0x1828AC600")]
		private JobHandle FEKCIOAKGPA(NativeList<Entity> rootsWithForcedCollisionUpdate, NativeList<Entity> rootsWithoutForcedCollisionUpdate, ComponentTypeHandle<LFKGMFOLOLO> collisionIslandRootDataHandleRO, ComponentDataFromEntity<LFKGMFOLOLO> collisionIslandRootDataFromEntityRO, ComponentTypeHandle<NLLEHLHFEHG> splineParentHandleRO, EntityQueryInJob changedLocalPoseQueryInJob, EntityQueryInJob changedSplinePointsQueryInJob, EntityQueryInJob splinesWithChangedChildrenQueryInJob, EntityQueryInJob changedCollisionModeQueryInJob, EntityQueryInJob changedScopeRootQueryInJob, Allocator allocator, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A86")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A87")]
		[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
		public CalculateCollisionIslandUpdatesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CE")]
[GCAKKMGPAEI]
public class DLMKOKDFKOI : JKEMFGGLHGI
{
	[Cpp2IlInjected.Token(Token = "0x40005FE")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005FF")]
	private EntityQuery EGFJCKOAGFH;

	[Cpp2IlInjected.Token(Token = "0x6000A8A")]
	[Cpp2IlInjected.Address(RVA = "0x2C6B4C0", Offset = "0x2C69CC0", VA = "0x182C6B4C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8B")]
	[Cpp2IlInjected.Address(RVA = "0x2C6B550", Offset = "0x2C69D50", VA = "0x182C6B550", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8C")]
	[Cpp2IlInjected.Address(RVA = "0x2C6B470", Offset = "0x2C69C70", VA = "0x182C6B470")]
	private EntityCommandBufferSystem EFIPACDBNFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8D")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public DLMKOKDFKOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CF")]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
public class FGHCEPCPFOI : NHLEGKPBPCC
{
	[Cpp2IlInjected.Token(Token = "0x20001D0")]
	[BurstCompile]
	private struct DCGAAIBMKKH : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		[ReadOnly]
		public int CIKEJLEKBAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		[ReadOnly]
		public EntityQueryInJob CGKJDJCPFHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		[ReadOnly]
		public EntityQueryInJob POOJBHFKPMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		[ReadOnly]
		public ChunkFilterAnyOf3ComponentsChanged DCGENMFBDCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		[ReadOnly]
		public EntityTypeHandle PEBMAKGHCFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		[ReadOnly]
		public ComponentDataFromEntity<POCOCJLODBE> MNAOLFLFBPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		[ReadOnly]
		public ComponentDataFromEntity<HBPOHKHILDB> MBFENMBOEDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> COPNAECAHAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		[ReadOnly]
		public ComponentTypeHandle<NLLEHLHFEHG> JMBKGMKIBOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		[ReadOnly]
		public ComponentDataFromEntity<ANGCGFBDCKA> BGDALEFAJDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		[ReadOnly]
		public ComponentDataFromEntity<NIGPOFBMGGH> KNJHFEGOBNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		[WriteOnly]
		public ComponentDataFromEntity<HJLIOPBHNPG> OCOONFIMFKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		[WriteOnly]
		public ComponentDataFromEntity<ONJPNGGFKNL> HHCBKJIEJCL;

		[Cpp2IlInjected.Token(Token = "0x6000A93")]
		[Cpp2IlInjected.Address(RVA = "0x222B1E0", Offset = "0x22299E0", VA = "0x18222B1E0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A94")]
		[Cpp2IlInjected.Address(RVA = "0x222A820", Offset = "0x2229020", VA = "0x18222A820")]
		private void DJEBDPMPNCA(NativeList<Entity> EIBIPCCLNGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A95")]
		[Cpp2IlInjected.Address(RVA = "0x222AD30", Offset = "0x2229530", VA = "0x18222AD30")]
		private void ECMAAJBBBMP(Entity BENEHBIADLM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000600")]
	private EntityQuery FPEMAKGIILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000601")]
	private EntityQuery OGIGDCCJONE;

	[Cpp2IlInjected.Token(Token = "0x6000A8F")]
	[Cpp2IlInjected.Address(RVA = "0x2C77160", Offset = "0x2C75960", VA = "0x182C77160", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A90")]
	[Cpp2IlInjected.Address(RVA = "0x2C77300", Offset = "0x2C75B00", VA = "0x182C77300", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A91")]
	[Cpp2IlInjected.Address(RVA = "0x1B86C80", Offset = "0x1B85480", VA = "0x181B86C80")]
	private bool BCALMCDLPAM<T>(T NBICICNAEEA, out int DENIKELBBHM) where T : struct, IChunkChangeFilter
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A92")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public FGHCEPCPFOI()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001D1")]
	[CompilerGenerated]
	public class DebugPostLoadValidateNetworkId : JKEMFGGLHGI, NOFCHOCEBPC
	{
		[Cpp2IlInjected.Token(Token = "0x20001D2")]
		private struct DebugPostLoadValidateNetworkId_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000612")]
			public NativeParallelHashMap<MHGAJIKGEGE, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000613")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000614")]
			[ReadOnly]
			public ComponentTypeHandle<GODBGECHIFD> __networkComponentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000A9B")]
			[Cpp2IlInjected.Address(RVA = "0x222BE60", Offset = "0x222A660", VA = "0x18222BE60")]
			private void BNHOJHOEIPF(Entity entity, in GODBGECHIFD networkComponent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9C")]
			[Cpp2IlInjected.Address(RVA = "0x222BF10", Offset = "0x222A710", VA = "0x18222BF10", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		private DLLLPKHOKKN networkToLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private EntityQuery DebugPostLoadValidateNetworkId_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		private ComponentTypeHandle<GODBGECHIFD> __RecRoom_Components_ObjectNetworkIdComponentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000A96")]
		[Cpp2IlInjected.Address(RVA = "0x2C6DF70", Offset = "0x2C6C770", VA = "0x182C6DF70", Slot = "14")]
		public void InitReferences(NCFCHDEHMHC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A97")]
		[Cpp2IlInjected.Address(RVA = "0x2C6E200", Offset = "0x2C6CA00", VA = "0x182C6E200", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A98")]
		[Cpp2IlInjected.Address(RVA = "0x2C6DE80", Offset = "0x2C6C680", VA = "0x182C6DE80")]
		private void IOILJGPLNPM(ref NativeParallelHashMap<MHGAJIKGEGE, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A99")]
		[Cpp2IlInjected.Address(RVA = "0x2C6DFD0", Offset = "0x2C6C7D0", VA = "0x182C6DFD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9A")]
		[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
		public DebugPostLoadValidateNetworkId()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D3")]
public readonly struct PJEPFNNEOOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000615")]
	private readonly int KFGBCCEFCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000616")]
	private readonly int BMKPPKKOMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000617")]
	private readonly BECDCKEMJCA CJCFMILPBKA;

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public BECDCKEMJCA FONJHHLNBIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000A9E")]
		[Cpp2IlInjected.Address(RVA = "0xB1A5B0", Offset = "0xB18DB0", VA = "0x180B1A5B0")]
		get
		{
			return default(BECDCKEMJCA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9D")]
	[Cpp2IlInjected.Address(RVA = "0x22C17A0", Offset = "0x22BFFA0", VA = "0x1822C17A0")]
	public PJEPFNNEOOJ(int KFGBCCEFCMB, int BMKPPKKOMAH, BECDCKEMJCA CJCFMILPBKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D4")]
[InternalBufferCapacity(1)]
internal struct CKAJGINCPIL : ISystemStateBufferElementData, IBufferElementData, IEquatable<CKAJGINCPIL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000618")]
	public IEBLEDBIMDL BJJHADPHPJP;

	[Cpp2IlInjected.Token(Token = "0x6000A9F")]
	[Cpp2IlInjected.Address(RVA = "0x28A5B20", Offset = "0x28A4320", VA = "0x1828A5B20", Slot = "4")]
	public bool Equals(CKAJGINCPIL OALEAAIPGBP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000AA0")]
	[Cpp2IlInjected.Address(RVA = "0x907390", Offset = "0x905B90", VA = "0x180907390")]
	public static CKAJGINCPIL HFMFJLJFEMO(IEBLEDBIMDL BJJHADPHPJP)
	{
		return default(CKAJGINCPIL);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D5")]
[KHNAILLFHGJ(typeof(FKAJABEJDAD), new string[] { })]
public sealed class CMLLODDEMLE : FKAJABEJDAD, NOFCHOCEBPC
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x20001D6")]
	private struct IGNOPPAMFDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public float OMBGILGFIEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public uint MOHKJMJAMIK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000619")]
	[NAAJCOHOAKA]
	private HMBELPNBOEG LNJHNPCFKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400061A")]
	[NAAJCOHOAKA]
	private HEJFCJDGGFG JCHMNBDOHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400061B")]
	[NAAJCOHOAKA]
	private NFCEEAILPLD IKKABBBJOID;

	[Cpp2IlInjected.Token(Token = "0x6000AA1")]
	[Cpp2IlInjected.Address(RVA = "0x28A8DB0", Offset = "0x28A75B0", VA = "0x1828A8DB0", Slot = "5")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA2")]
	[Cpp2IlInjected.Address(RVA = "0x28A88F0", Offset = "0x28A70F0", VA = "0x1828A88F0")]
	public bool EGANDJJHEIC(in float3 HPBBFNNBAFE, in float3 JJEDPBPHNPK, float BJICICOAOBE, out BCHHHLKLMCP AFJOMCLLIJA, out LPLJHAHPEEF BENEHBIADLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA3")]
	[Cpp2IlInjected.Address(RVA = "0x28A8E50", Offset = "0x28A7650", VA = "0x1828A8E50")]
	public static bool PLIDKPNHLON(in Span<BCHHHLKLMCP> JBNPIAEOOPJ, float BJICICOAOBE, out int AMOEKOMGDLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA4")]
	[Cpp2IlInjected.Address(RVA = "0x28A88C0", Offset = "0x28A70C0", VA = "0x1828A88C0")]
	public static float CMFEDLJJLLL(float OMBGILGFIEL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA5")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public CMLLODDEMLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA6")]
	[Cpp2IlInjected.Address(RVA = "0x28A8E40", Offset = "0x28A7640", VA = "0x1828A8E40", Slot = "4")]
	private bool MKKFJGDCDBJ(in float3 HPBBFNNBAFE, in float3 JJEDPBPHNPK, float BJICICOAOBE, out BCHHHLKLMCP AFJOMCLLIJA, out LPLJHAHPEEF BENEHBIADLM)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001D7")]
internal struct POAEAPGFKNH : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20001D8")]
public class IIMBLKLKCCJ : NHLEGKPBPCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400061E")]
	private EntityQuery EGFJCKOAGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400061F")]
	private EntityQuery PGJFLMGDOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000620")]
	private ComponentTypes BMMEFOCIHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000621")]
	private NativeParallelHashSet<int> HMDFAKJNKAH;

	[Cpp2IlInjected.Token(Token = "0x6000AA7")]
	[Cpp2IlInjected.Address(RVA = "0x24F0330", Offset = "0x24EEB30", VA = "0x1824F0330", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA8")]
	[Cpp2IlInjected.Address(RVA = "0x24F0700", Offset = "0x24EEF00", VA = "0x1824F0700", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA9")]
	[Cpp2IlInjected.Address(RVA = "0x24F0780", Offset = "0x24EEF80", VA = "0x1824F0780", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAA")]
	[Cpp2IlInjected.Address(RVA = "0x24F0290", Offset = "0x24EEA90", VA = "0x1824F0290")]
	public JobHandle IKHPEMAPGDM(JobHandle BFAAEILACKK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAB")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public IIMBLKLKCCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DA")]
public class DACDKDHAELH : NHLEGKPBPCC
{
	[Cpp2IlInjected.Token(Token = "0x20001DB")]
	[BurstCompile]
	private struct NPCNIMACCLN : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		[ReadOnly]
		public ComponentTypeHandle<HGFAFHFDBHB> GKPNENPICOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public ComponentTypeHandle<BGNDJFIJAFN> NKGIHMMJOED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public uint EOFDFPDHALO;

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0x2235BF0", Offset = "0x22343F0", VA = "0x182235BF0", Slot = "4")]
		public void Execute(ArchetypeChunk OPMNIAACDHI, int AMOEKOMGDLG, int LAFKFNODOKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB4")]
		[Cpp2IlInjected.Address(RVA = "0x2235B60", Offset = "0x2234360", VA = "0x182235B60")]
		public bool BDINEGGJLMH(ArchetypeChunk OPMNIAACDHI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000625")]
	private EntityQuery IJKOLJJAOAI;

	[Cpp2IlInjected.Token(Token = "0x6000AB0")]
	[Cpp2IlInjected.Address(RVA = "0x2C66710", Offset = "0x2C64F10", VA = "0x182C66710", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB1")]
	[Cpp2IlInjected.Address(RVA = "0x2C66840", Offset = "0x2C65040", VA = "0x182C66840", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB2")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public DACDKDHAELH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DC")]
[ExecuteAlways]
public class DIBKMONKCMM : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000AB5")]
	[Cpp2IlInjected.Address(RVA = "0x7E01F0", Offset = "0x7DE9F0", VA = "0x1807E01F0")]
	public DIBKMONKCMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DD")]
public struct PMBACLANEMA<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000629")]
	private LAPGECLMCFE<T> MNJCDKNLLPF;

	[Cpp2IlInjected.Token(Token = "0x6000AB6")]
	[Cpp2IlInjected.Address(RVA = "0x220D8B0", Offset = "0x220C0B0", VA = "0x18220D8B0")]
	public PMBACLANEMA(LAPGECLMCFE<T> MNJCDKNLLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB7")]
	[Cpp2IlInjected.Address(RVA = "0x2852790", Offset = "0x2850F90", VA = "0x182852790")]
	public FEKDHFGFMGK<T> GEHPILLIOIC()
	{
		return default(FEKDHFGFMGK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DE")]
[KHNAILLFHGJ(typeof(CEIHPADBCMH), new string[] { })]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
public class CEIHPADBCMH : NOFCHOCEBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400062A")]
	[NAAJCOHOAKA]
	private ILBBGIPPPPJ KFELNFLBJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400062B")]
	[NAAJCOHOAKA]
	private LGNMGLONHCC ELMENJAOGJB;

	[Cpp2IlInjected.Token(Token = "0x6000AB8")]
	[Cpp2IlInjected.Address(RVA = "0x28A41B0", Offset = "0x28A29B0", VA = "0x1828A41B0", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB9")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public CEIHPADBCMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DF")]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
internal class KBIDHFDICKA : HHBLAKGBMFH<FFBFMGINHPD>
{
	[Cpp2IlInjected.Token(Token = "0x6000ABA")]
	[Cpp2IlInjected.Address(RVA = "0x24F6ED0", Offset = "0x24F56D0", VA = "0x1824F6ED0", Slot = "14")]
	protected override void HKAGKAAAMCN(NativeArray<Entity> KFLBCCAJFMN, NativeArray<Entity> OHPLMCMHCIP, NativeArray<Entity> LHDFKMLKNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABB")]
	[Cpp2IlInjected.Address(RVA = "0x24F6E00", Offset = "0x24F5600", VA = "0x1824F6E00")]
	private static void HKAGKAAAMCN(NativeArray<Entity> KFLBCCAJFMN, NativeArray<Entity> LHDFKMLKNBK, ComponentDataFromEntity<global::GMAFMCBNILP> DKCPKEDOMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABC")]
	[Cpp2IlInjected.Address(RVA = "0x24F7020", Offset = "0x24F5820", VA = "0x1824F7020")]
	public KBIDHFDICKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E0")]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
internal sealed class ECCNPKLGGEJ : GJJADNOGMIL
{
	[Cpp2IlInjected.Token(Token = "0x6000ABD")]
	[Cpp2IlInjected.Address(RVA = "0x2C71D80", Offset = "0x2C70580", VA = "0x182C71D80", Slot = "15")]
	protected override ComponentSystemBase CMFPJFIFJLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABE")]
	[Cpp2IlInjected.Address(RVA = "0x22BD2C0", Offset = "0x22BBAC0", VA = "0x1822BD2C0")]
	public ECCNPKLGGEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E1")]
public abstract class KHLEPBDKFGA : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400062C")]
	private LDDHDDLKFEJ HBLGPEBMOAO;

	[Cpp2IlInjected.Token(Token = "0x6000ABF")]
	[Cpp2IlInjected.Address(RVA = "0x24FDB50", Offset = "0x24FC350", VA = "0x1824FDB50", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC0")]
	[Cpp2IlInjected.Address(RVA = "0x24FDBB0", Offset = "0x24FC3B0", VA = "0x1824FDBB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC1")]
	[Cpp2IlInjected.Address(RVA = "0x24FDBE0", Offset = "0x24FC3E0", VA = "0x1824FDBE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC2")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	protected KHLEPBDKFGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E2")]
public static class KFIEIMKLKIH
{
	[Cpp2IlInjected.Token(Token = "0x400062D")]
	public static readonly (ComponentType userTag, ComponentType stateTag, ComponentType componentTag)[] GCKEEAOCBDL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001E3")]
internal struct CMFCFDDCLPJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001E4")]
internal struct FIBIFFPFOFH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20001E5")]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
public class BJCEIICFIEK : JKEMFGGLHGI
{
	[Cpp2IlInjected.Token(Token = "0x400062E")]
	private static JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400062F")]
	private EntityQuery OBFDJPOIJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000630")]
	private EntityQuery IBNDJJKACFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000631")]
	private EntityQuery CNPEOCHGMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000632")]
	private EntityQuery ONAOFHJKDDH;

	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x289E280", Offset = "0x289CA80", VA = "0x18289E280", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC5")]
	[Cpp2IlInjected.Address(RVA = "0x289E440", Offset = "0x289CC40", VA = "0x18289E440", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC6")]
	[Cpp2IlInjected.Address(RVA = "0x289E0C0", Offset = "0x289C8C0", VA = "0x18289E0C0")]
	private void DIHKMBPEMPG(EntityQuery EGFJCKOAGFH, bool EPFBMINCCNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC7")]
	[Cpp2IlInjected.Address(RVA = "0x289DF00", Offset = "0x289C700", VA = "0x18289DF00")]
	private void ADHPBCMOBMH(EntityQuery EGFJCKOAGFH, bool EPFBMINCCNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC8")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public BJCEIICFIEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E6")]
internal class KDHJAGAKJGJ : OJBJPKKIOND
{
	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	protected override DGHCNLKFLNE JAJKCIDCJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000ACA")]
		[Cpp2IlInjected.Address(RVA = "0x24F73A0", Offset = "0x24F5BA0", VA = "0x1824F73A0", Slot = "15")]
		get
		{
			return default(DGHCNLKFLNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACB")]
	[Cpp2IlInjected.Address(RVA = "0x24E71F0", Offset = "0x24E59F0", VA = "0x1824E71F0")]
	public KDHJAGAKJGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E7")]
[DefaultMember("Item")]
public struct AHMKCFBDMHK<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000633")]
	public NativeList<Entity> KFLBCCAJFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000634")]
	public NativeList<T> NFBDMLCENEN;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public int EGAMNLBINDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000ACC")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB340", Offset = "0x2BA9B40", VA = "0x182BAB340")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public (Entity entity, T value) ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000ACD")]
		[Cpp2IlInjected.Address(RVA = "0x2BAAFB0", Offset = "0x2BA97B0", VA = "0x182BAAFB0")]
		get
		{
			return default((Entity, T));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACE")]
	[Cpp2IlInjected.Address(RVA = "0x2BAB590", Offset = "0x2BA9D90", VA = "0x182BAB590")]
	public void GLILACFFLBJ(Entity AJDEFAPHMKF, T MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACF")]
	[Cpp2IlInjected.Address(RVA = "0x2BAC070", Offset = "0x2BAA870", VA = "0x182BAC070")]
	public void PHCLALLJMKM(NativeArray<Entity> AJDEFAPHMKF, NativeArray<T> MENBIMCLIOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E8")]
[GCAKKMGPAEI]
public class BCHGJDMLGML : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.Token(Token = "0x4000635")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x4000636")]
	private static readonly JNGNMMOLKFF JALBKIHJOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000637")]
	[NAAJCOHOAKA]
	private DLLLPKHOKKN BIKLBHANPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000638")]
	private EntityQuery ECBGEKCNBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000639")]
	private EntityQuery KEMGKKGCHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400063A")]
	private bool PMADFOMNIPK;

	[Cpp2IlInjected.Token(Token = "0x6000AD0")]
	[Cpp2IlInjected.Address(RVA = "0x289A330", Offset = "0x2898B30", VA = "0x18289A330", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD1")]
	[Cpp2IlInjected.Address(RVA = "0x289A380", Offset = "0x2898B80", VA = "0x18289A380")]
	public bool OBPMFDCFOEF(Entity AJDEFAPHMKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD2")]
	[Cpp2IlInjected.Address(RVA = "0x289A430", Offset = "0x2898C30", VA = "0x18289A430", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD3")]
	[Cpp2IlInjected.Address(RVA = "0x289A000", Offset = "0x2898800", VA = "0x18289A000", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD4")]
	[Cpp2IlInjected.Address(RVA = "0xE0E520", Offset = "0xE0CD20", VA = "0x180E0E520", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD5")]
	[Cpp2IlInjected.Address(RVA = "0x289A510", Offset = "0x2898D10", VA = "0x18289A510", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD6")]
	[Cpp2IlInjected.Address(RVA = "0x289A000", Offset = "0x2898800", VA = "0x18289A000")]
	private void AKIHHOKONHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD7")]
	[Cpp2IlInjected.Address(RVA = "0x289A020", Offset = "0x2898820", VA = "0x18289A020")]
	private void BCIGKONECID(EntityQuery EGFJCKOAGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD8")]
	[Cpp2IlInjected.Address(RVA = "0x2899E90", Offset = "0x2898690", VA = "0x182899E90")]
	private void ACIJMGHPPCM(NativeArray<Entity> KFLBCCAJFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD9")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public BCHGJDMLGML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E9")]
public struct JKHBKCMHBNA<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400063B")]
	private AHMKCFBDMHK<T> MNJCDKNLLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400063C")]
	private EntityCommandBuffer PFGPHODPKBL;

	[Cpp2IlInjected.Token(Token = "0x6000ADB")]
	[Cpp2IlInjected.Address(RVA = "0x27C8140", Offset = "0x27C6940", VA = "0x1827C8140")]
	public JKHBKCMHBNA(AHMKCFBDMHK<T> MNJCDKNLLPF, EntityCommandBuffer PFGPHODPKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADC")]
	[Cpp2IlInjected.Address(RVA = "0x27C7B30", Offset = "0x27C6330", VA = "0x1827C7B30", Slot = "4")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0x27C8120", Offset = "0x27C6920", VA = "0x1827C8120")]
	public static AHMKCFBDMHK<T> HFMFJLJFEMO(JKHBKCMHBNA<T> LAEIDNKAKOO)
	{
		return default(AHMKCFBDMHK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001EA")]
public static class JGKFBFGIIJE
{
	[Cpp2IlInjected.Token(Token = "0x400063D")]
	internal static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x26C2580", Offset = "0x26C0D80", VA = "0x1826C2580")]
	public static void LDEGPCHGKNG<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData>(NCFCHDEHMHC KGMNNCCACLI, KNCFGIDDJIE<Entity> ELAAPFMOMBJ, out DMOLMGFOOHL<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> DCNEPGCFKGA) where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, MLFKCOGAANJ where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, MLFKCOGAANJ, IEquatable<TChildrenData>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0x24F49C0", Offset = "0x24F31C0", VA = "0x1824F49C0")]
	public static bool NELCIJKPGDH(IFDBCDKGAKP DNMGFMBFODC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001EB")]
public class DMOLMGFOOHL<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, MLFKCOGAANJ where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, MLFKCOGAANJ, IEquatable<TChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x400063E")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400063F")]
	private readonly ILBBGIPPPPJ EJLFIBCCMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000640")]
	private readonly NIJBLPDKGGM<Entity> OPCEAOKDBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000641")]
	private readonly NKHJADIBHEP LJMFKLMNMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000642")]
	private readonly ILFNLPAIJLJ GJPBCFJDGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000643")]
	private readonly EntityManager EADLBIHJKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000644")]
	private readonly IGBOJICGIKC JBKCICGKJOH;

	[Cpp2IlInjected.Token(Token = "0x6000AE1")]
	[Cpp2IlInjected.Address(RVA = "0x27EF600", Offset = "0x27EDE00", VA = "0x1827EF600")]
	public DMOLMGFOOHL(NCFCHDEHMHC KGMNNCCACLI, KNCFGIDDJIE<Entity> ELAAPFMOMBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE2")]
	[Cpp2IlInjected.Address(RVA = "0x27EF060", Offset = "0x27ED860", VA = "0x1827EF060")]
	private bool MDMMMMHEHOL(Entity AJDEFAPHMKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0x27EED00", Offset = "0x27ED500", VA = "0x1827EED00")]
	private bool KBFJCPHJMNC(Entity AJDEFAPHMKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0x27EE9C0", Offset = "0x27ED1C0", VA = "0x1827EE9C0")]
	private bool GBJKOOOBPGM(Entity AJDEFAPHMKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE5")]
	[Cpp2IlInjected.Address(RVA = "0x27EE3B0", Offset = "0x27ECBB0", VA = "0x1827EE3B0")]
	public bool DMMEGNFOAHA(Entity AJDEFAPHMKF, in Entity ILLDOGNGNOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE6")]
	[Cpp2IlInjected.Address(RVA = "0x27EE840", Offset = "0x27ED040", VA = "0x1827EE840")]
	public bool FHKCLCJHEPA(Entity AJDEFAPHMKF, in Entity ILLDOGNGNOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE7")]
	[Cpp2IlInjected.Address(RVA = "0x27EE3E0", Offset = "0x27ECBE0", VA = "0x1827EE3E0")]
	private bool FHKCLCJHEPA(Entity AJDEFAPHMKF, in Entity ILLDOGNGNOD, bool PHHBCKJEMEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE8")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	private static void PIBKKHCEOIL(Entity AJDEFAPHMKF, in Entity ILLDOGNGNOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE9")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	private static void LMOPOCFNKFP(Entity AJDEFAPHMKF, in Entity ILLDOGNGNOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEA")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	private static void AOCFIPJLHJI(Entity AJDEFAPHMKF, in Entity ILLDOGNGNOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEB")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	private static void POBPBDDFMLM(Entity AJDEFAPHMKF, in Entity ILLDOGNGNOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEC")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	private static void LBEBAGMPFJN(Entity AJDEFAPHMKF, in Entity ILLDOGNGNOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AED")]
	[Cpp2IlInjected.Address(RVA = "0x27EEA20", Offset = "0x27ED220", VA = "0x1827EEA20")]
	private bool IBBKINNCCLP(Entity AJDEFAPHMKF, Entity IKDGFEDODNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEE")]
	[Cpp2IlInjected.Address(RVA = "0x27EE870", Offset = "0x27ED070", VA = "0x1827EE870")]
	private void FOJCIEPGEKJ(Entity AJDEFAPHMKF, in Entity FNFODDOPDHK, in Entity ILLDOGNGNOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEF")]
	[Cpp2IlInjected.Address(RVA = "0x27EE210", Offset = "0x27ECA10", VA = "0x1827EE210")]
	private void BOCMCPADGGG(Entity AJDEFAPHMKF, in Entity FNFODDOPDHK, in Entity ILLDOGNGNOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF0")]
	[Cpp2IlInjected.Address(RVA = "0x27EF0C0", Offset = "0x27ED8C0", VA = "0x1827EF0C0")]
	private bool NAJDEDANPFA(NMHGLGPLAKN FOICHJCKABO, in MHGAJIKGEGE EJAEOIAEADM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF1")]
	[Cpp2IlInjected.Address(RVA = "0x27EEDC0", Offset = "0x27ED5C0", VA = "0x1827EEDC0")]
	private void KNCIMBFFAPF(Entity GJPBCFJDGCH, Entity CICDHHEGIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF2")]
	[Cpp2IlInjected.Address(RVA = "0x27EEC70", Offset = "0x27ED470", VA = "0x1827EEC70")]
	private void IFGNKHDPNPM(Entity GJPBCFJDGCH, Entity CICDHHEGIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF3")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	private void KHBDDENNDML(Entity AJDEFAPHMKF, Entity FNFODDOPDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF4")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	private void FKKPNKKDLMK(Entity AJDEFAPHMKF, Entity ILLDOGNGNOD)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001EC")]
	[CompilerGenerated]
	public class GatherModifiedParents : NHLEGKPBPCC, NOHOJBNCAJC
	{
		[Cpp2IlInjected.Token(Token = "0x20001ED")]
		[BurstCompile]
		[NoAlias]
		private struct GatherModifiedParents_AddNewParents_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400064B")]
			public NativeList<EJDGNFKIJAG> newParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400064C")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400064D")]
			[ReadOnly]
			public ComponentTypeHandle<OEKNEICFKDA> __currentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000AFD")]
			[Cpp2IlInjected.Address(RVA = "0x222EF70", Offset = "0x222D770", VA = "0x18222EF70")]
			private void BNHOJHOEIPF(Entity entity, [NoAlias] in OEKNEICFKDA current)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AFE")]
			[Cpp2IlInjected.Address(RVA = "0x222EFF0", Offset = "0x222D7F0", VA = "0x18222EFF0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001EE")]
		[NoAlias]
		[BurstCompile]
		private struct GatherModifiedParents_AddChangedParents_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400064E")]
			public NativeList<FLNMMMIIPBM> changedParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400064F")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000650")]
			[ReadOnly]
			public ComponentTypeHandle<OEKNEICFKDA> __currentTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000651")]
			[ReadOnly]
			public ComponentTypeHandle<ANDKGOKDDMF> __previousTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000AFF")]
			[Cpp2IlInjected.Address(RVA = "0x222ED10", Offset = "0x222D510", VA = "0x18222ED10")]
			private void BNHOJHOEIPF(Entity entity, [NoAlias] in OEKNEICFKDA current, [NoAlias] in ANDKGOKDDMF previous)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B00")]
			[Cpp2IlInjected.Address(RVA = "0x222EDD0", Offset = "0x222D5D0", VA = "0x18222EDD0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001EF")]
		[NoAlias]
		[BurstCompile]
		private struct GatherModifiedParents_AddRemovedParents_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000652")]
			public NativeList<EJDGNFKIJAG> oldParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000653")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000654")]
			[ReadOnly]
			public ComponentTypeHandle<ANDKGOKDDMF> __previousTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000B01")]
			[Cpp2IlInjected.Address(RVA = "0x222F110", Offset = "0x222D910", VA = "0x18222F110")]
			private void BNHOJHOEIPF(Entity entity, [NoAlias] in ANDKGOKDDMF previous)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B02")]
			[Cpp2IlInjected.Address(RVA = "0x222F190", Offset = "0x222D990", VA = "0x18222F190", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		private IGBOJICGIKC parentEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		private EntityQuery GatherModifiedParents_AddNewParents_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		private EntityQuery GatherModifiedParents_AddChangedParents_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		private EntityQuery GatherModifiedParents_AddRemovedParents_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		private ComponentTypeHandle<OEKNEICFKDA> __RecRoom_Components_ParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		private ComponentTypeHandle<ANDKGOKDDMF> __RecRoom_Components_PreviousParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000AF6")]
		[Cpp2IlInjected.Address(RVA = "0x2C840C0", Offset = "0x2C828C0", VA = "0x182C840C0", Slot = "14")]
		public void GGJEPBDNAAH(NCFCHDEHMHC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF7")]
		[Cpp2IlInjected.Address(RVA = "0x2C84A90", Offset = "0x2C83290", VA = "0x182C84A90", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF8")]
		[Cpp2IlInjected.Address(RVA = "0x2C842D0", Offset = "0x2C82AD0", VA = "0x182C842D0")]
		private JobHandle ONLOBOMOJNA(NativeList<EJDGNFKIJAG> newParents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF9")]
		[Cpp2IlInjected.Address(RVA = "0x2C84E20", Offset = "0x2C83620", VA = "0x182C84E20")]
		private JobHandle PPMAHLBFFEA(NativeList<FLNMMMIIPBM> changedParents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFA")]
		[Cpp2IlInjected.Address(RVA = "0x2C841A0", Offset = "0x2C829A0", VA = "0x182C841A0")]
		private JobHandle JGLKAGCNGPH(NativeList<EJDGNFKIJAG> oldParents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFB")]
		[Cpp2IlInjected.Address(RVA = "0x2C84400", Offset = "0x2C82C00", VA = "0x182C84400", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFC")]
		[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
		public GatherModifiedParents()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F0")]
[UpdateBefore(typeof(HGHEBLMMPBI))]
public class NIKFBANPONG : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.Token(Token = "0x4000655")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000656")]
	private GJCOMGMOGCM LJAHGKLIMIM;

	[Cpp2IlInjected.Token(Token = "0x6000B03")]
	[Cpp2IlInjected.Address(RVA = "0x2932480", Offset = "0x2930C80", VA = "0x182932480", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B04")]
	[Cpp2IlInjected.Address(RVA = "0x29324D0", Offset = "0x2930CD0", VA = "0x1829324D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B05")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public NIKFBANPONG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F1")]
[KHNAILLFHGJ(typeof(IDDDKKBGJPP), new string[] { })]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
internal class IDDDKKBGJPP : KPFHEDMDJDJ, NOFCHOCEBPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20001F3")]
	[CompilerGenerated]
	private sealed class FEIHBHCJKII : IEnumerable<(JBOEKGNECFI, KECBEHOHBCN)>, IEnumerable, IEnumerator<(JBOEKGNECFI, KECBEHOHBCN)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		private (JBOEKGNECFI primitiveType, KECBEHOHBCN prefabType) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public IDDDKKBGJPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		private int <i>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private JBOEKGNECFI <primitiveType>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		private KECBEHOHBCN <prefabType>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		private (JBOEKGNECFI, KECBEHOHBCN) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000B24")]
			[Cpp2IlInjected.Address(RVA = "0x222C970", Offset = "0x222B170", VA = "0x18222C970", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((JBOEKGNECFI, KECBEHOHBCN));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000B26")]
			[Cpp2IlInjected.Address(RVA = "0x222C9C0", Offset = "0x222B1C0", VA = "0x18222C9C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B21")]
		[Cpp2IlInjected.Address(RVA = "0x222CA10", Offset = "0x222B210", VA = "0x18222CA10")]
		[DebuggerHidden]
		public FEIHBHCJKII(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B22")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B23")]
		[Cpp2IlInjected.Address(RVA = "0x222C7F0", Offset = "0x222AFF0", VA = "0x18222C7F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B25")]
		[Cpp2IlInjected.Address(RVA = "0x222C980", Offset = "0x222B180", VA = "0x18222C980", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B27")]
		[Cpp2IlInjected.Address(RVA = "0x222C8D0", Offset = "0x222B0D0", VA = "0x18222C8D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(JBOEKGNECFI, KECBEHOHBCN)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B28")]
		[Cpp2IlInjected.Address(RVA = "0x222C8D0", Offset = "0x222B0D0", VA = "0x18222C8D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000657")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000658")]
	[NAAJCOHOAKA]
	private ILBBGIPPPPJ KFELNFLBJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000659")]
	private World EJLFIBCCMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400065A")]
	private NativeParallelHashMap<int, Entity> CBGOOONHBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400065B")]
	private NativeParallelHashMap<int, EntityArchetype> HDFNKMIBGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400065C")]
	private NativeParallelHashMap<int, int> JKGIAALGDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400065D")]
	private KECBEHOHBCN[] PGDPKHFFBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400065E")]
	private readonly Dictionary<JBOEKGNECFI, KECBEHOHBCN> CIOGLCHJKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400065F")]
	private readonly Dictionary<GLALCNLDHGM, KECBEHOHBCN> DIGDOCLEBOB;

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public int GKGAEPJBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000B07")]
		[Cpp2IlInjected.Address(RVA = "0x24E9C30", Offset = "0x24E8430", VA = "0x1824E9C30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public EntityManager EOOAJAELBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000B08")]
		[Cpp2IlInjected.Address(RVA = "0x8E9050", Offset = "0x8E7850", VA = "0x1808E9050")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B09")]
		[Cpp2IlInjected.Address(RVA = "0xFC9F90", Offset = "0xFC8790", VA = "0x180FC9F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0A")]
	[Cpp2IlInjected.Address(RVA = "0x24EA000", Offset = "0x24E8800", VA = "0x1824EA000", Slot = "5")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0B")]
	[Cpp2IlInjected.Address(RVA = "0x24E98C0", Offset = "0x24E80C0", VA = "0x1824E98C0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0C")]
	[Cpp2IlInjected.Address(RVA = "0x918DD0", Offset = "0x9175D0", VA = "0x180918DD0")]
	internal NativeParallelHashMap<int, Entity> JEKDCCOGNHL()
	{
		return default(NativeParallelHashMap<int, Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0D")]
	[Cpp2IlInjected.Address(RVA = "0xB28580", Offset = "0xB26D80", VA = "0x180B28580")]
	internal NativeParallelHashMap<int, EntityArchetype> FKEGMBHNBDP()
	{
		return default(NativeParallelHashMap<int, EntityArchetype>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0E")]
	[Cpp2IlInjected.Address(RVA = "0x918DF0", Offset = "0x9175F0", VA = "0x180918DF0")]
	internal NativeParallelHashMap<int, int> BLMELAIOLMP()
	{
		return default(NativeParallelHashMap<int, int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0F")]
	[Cpp2IlInjected.Address(RVA = "0x24EB020", Offset = "0x24E9820", VA = "0x1824EB020")]
	internal IEnumerable<Type> OMKILEDEAHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B10")]
	[Cpp2IlInjected.Address(RVA = "0x24E9770", Offset = "0x24E7F70", VA = "0x1824E9770")]
	internal LCLIFGLLAPD DELDEEPPAGB(Type EIOLDDJPDLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B11")]
	[Cpp2IlInjected.Address(RVA = "0x24EAF40", Offset = "0x24E9740", VA = "0x1824EAF40")]
	public EntityArchetype OAAMCFEDLBE(KECBEHOHBCN MCBNACIDAGA)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B12")]
	[Cpp2IlInjected.Address(RVA = "0x24EAFB0", Offset = "0x24E97B0", VA = "0x1824EAFB0", Slot = "4")]
	[IteratorStateMachine(typeof(FEIHBHCJKII))]
	public IEnumerable<(JBOEKGNECFI, KECBEHOHBCN)> OKICLLBLNLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B13")]
	[Cpp2IlInjected.Address(RVA = "0x24EAE50", Offset = "0x24E9650", VA = "0x1824EAE50")]
	public Entity MMCNJDCOMKI(KECBEHOHBCN MCBNACIDAGA)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B14")]
	[Cpp2IlInjected.Address(RVA = "0x24E9480", Offset = "0x24E7C80", VA = "0x1824E9480")]
	public void BIHDENBFHNJ(NativeArray<KECBEHOHBCN> PGDPKHFFBIG, NativeArray<Entity> JMDOJIJKLJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B15")]
	[Cpp2IlInjected.Address(RVA = "0x24E9430", Offset = "0x24E7C30", VA = "0x1824E9430")]
	public void AIIBCGGGKMP(KECBEHOHBCN MCBNACIDAGA, NativeArray<Entity> KFLBCCAJFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B16")]
	[Cpp2IlInjected.Address(RVA = "0x24E9C70", Offset = "0x24E8470", VA = "0x1824E9C70")]
	public KECBEHOHBCN HDEFOGKKFEG(JBOEKGNECFI EIOLDDJPDLH)
	{
		return default(KECBEHOHBCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B17")]
	[Cpp2IlInjected.Address(RVA = "0x24E97E0", Offset = "0x24E7FE0", VA = "0x1824E97E0")]
	public Entity DLGEAHMODBK(KECBEHOHBCN MCBNACIDAGA)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B18")]
	[Cpp2IlInjected.Address(RVA = "0x24EAB50", Offset = "0x24E9350", VA = "0x1824EAB50")]
	private void KKNFCOIDGLG(LCLIFGLLAPD GGHLCLNMJGC, NativeList<int> PGDPKHFFBIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B19")]
	[Cpp2IlInjected.Address(RVA = "0x24E9CD0", Offset = "0x24E84D0", VA = "0x1824E9CD0")]
	internal void HNACMLEAGCG(KECBEHOHBCN MCBNACIDAGA, ComponentTypeList KIKBKFAAADF, MMAEMHJKCEP FPPFOICHCMC, LCLIFGLLAPD GGHLCLNMJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B1A")]
	[Cpp2IlInjected.Address(RVA = "0x24E9600", Offset = "0x24E7E00", VA = "0x1824E9600")]
	private EntityArchetype CAHMPOIONIH(KECBEHOHBCN MCBNACIDAGA, ComponentTypeList MPCPKFKACPN)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B1B")]
	[Cpp2IlInjected.Address(RVA = "0x24EB110", Offset = "0x24E9910", VA = "0x1824EB110")]
	public IDDDKKBGJPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F4")]
[KHNAILLFHGJ(typeof(GHENGDIBFHP), new string[] { })]
public class AFFNGACLGLE : NOFCHOCEBPC, GHENGDIBFHP
{
	[Cpp2IlInjected.Token(Token = "0x20001F5")]
	[CompilerGenerated]
	private sealed class JCGEMHHMBBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public BCHCOEAJMAO objBoard;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public LPLJHAHPEEF parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		public AFFNGACLGLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		private IFDBCDKGAKP <parentObject>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		private Vector3 <pos>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		private Quaternion <rot>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000B3A")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public JCGEMHHMBBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3B")]
		[Cpp2IlInjected.Address(RVA = "0x2230C90", Offset = "0x222F490", VA = "0x182230C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3C")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001F6")]
	[CompilerGenerated]
	private sealed class JJMIOEDFMEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public IFDBCDKGAKP obj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public AFFNGACLGLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public JJMIOEDFMEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(RVA = "0x2231500", Offset = "0x222FD00", VA = "0x182231500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3F")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400066B")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400066C")]
	[NAAJCOHOAKA]
	private JBFFPLGIMGI BOBHLPNKBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400066D")]
	private EntityManager EADLBIHJKBG;

	[Cpp2IlInjected.Token(Token = "0x6000B29")]
	[Cpp2IlInjected.Address(RVA = "0x2894CD0", Offset = "0x28934D0", VA = "0x182894CD0", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2A")]
	[Cpp2IlInjected.Address(RVA = "0x2894A20", Offset = "0x2893220", VA = "0x182894A20", Slot = "5")]
	public bool EOAAKMENOIA(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2B")]
	[Cpp2IlInjected.Address(RVA = "0x28951A0", Offset = "0x28939A0", VA = "0x1828951A0", Slot = "7")]
	public bool LAIOKBGNPEL(LPLJHAHPEEF BBNGIDIFEAM, out Guid IBOAMBHJEOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2C")]
	[Cpp2IlInjected.Address(RVA = "0x28940D0", Offset = "0x28928D0", VA = "0x1828940D0", Slot = "8")]
	public Guid ABGCNLBBDGB(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2D")]
	[Cpp2IlInjected.Address(RVA = "0x28945D0", Offset = "0x2892DD0", VA = "0x1828945D0", Slot = "9")]
	public void DNCHPFCOGDB(LPLJHAHPEEF BBNGIDIFEAM, Guid IBOAMBHJEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2E")]
	[Cpp2IlInjected.Address(RVA = "0x2895800", Offset = "0x2894000", VA = "0x182895800", Slot = "10")]
	public bool PJEEDHFNHJN(LPLJHAHPEEF BBNGIDIFEAM, out Guid KJOHEJEFBGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2F")]
	[Cpp2IlInjected.Address(RVA = "0x2894490", Offset = "0x2892C90", VA = "0x182894490", Slot = "11")]
	public Guid CKNCLDAALNH(LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B30")]
	[Cpp2IlInjected.Address(RVA = "0x2895530", Offset = "0x2893D30", VA = "0x182895530", Slot = "12")]
	public void PCEFKKCGOIO(LPLJHAHPEEF BBNGIDIFEAM, Guid KJOHEJEFBGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B31")]
	[Cpp2IlInjected.Address(RVA = "0x28952B0", Offset = "0x2893AB0", VA = "0x1828952B0", Slot = "13")]
	public void LPDMPILCFCM(LPLJHAHPEEF BBNGIDIFEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B32")]
	[Cpp2IlInjected.Address(RVA = "0x2894D70", Offset = "0x2893570", VA = "0x182894D70", Slot = "14")]
	public void JECKGKLBAGL(LPLJHAHPEEF BEELAINJGPH, LPLJHAHPEEF GJPBCFJDGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B33")]
	[Cpp2IlInjected.Address(RVA = "0x28948A0", Offset = "0x28930A0", VA = "0x1828948A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JCGEMHHMBBJ))]
	private Task DOLMMOBGDDI(BCHCOEAJMAO CNFNFAPGDKF, LPLJHAHPEEF GJPBCFJDGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B34")]
	[Cpp2IlInjected.Address(RVA = "0x2894B50", Offset = "0x2893350", VA = "0x182894B50")]
	private void EPMCNADOMJH(BCHCOEAJMAO CNFNFAPGDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B35")]
	[Cpp2IlInjected.Address(RVA = "0x28953E0", Offset = "0x2893BE0", VA = "0x1828953E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JJMIOEDFMEA))]
	private Task NOEHEMHPGEP(IFDBCDKGAKP CEPDEAHBHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B36")]
	[Cpp2IlInjected.Address(RVA = "0x2894210", Offset = "0x2892A10", VA = "0x182894210")]
	private Task APPJDKFBFLH(IFDBCDKGAKP CEPDEAHBHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B37")]
	[Cpp2IlInjected.Address(RVA = "0x2895350", Offset = "0x2893B50", VA = "0x182895350", Slot = "6")]
	public bool NHBENKJGECB(LPLJHAHPEEF PMFGMJJBADH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B38")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public AFFNGACLGLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F7")]
internal class MDHDBMMKMJE : GKEKBMGOHDE
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20001F8")]
	public struct KKJOGACGJAC : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x400067C")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	protected override ComponentType DGPOOFGMLPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000B41")]
		[Cpp2IlInjected.Address(RVA = "0x2929FE0", Offset = "0x29287E0", VA = "0x182929FE0", Slot = "15")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	protected override ComponentType PPHMGJJPIMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000B42")]
		[Cpp2IlInjected.Address(RVA = "0x292A010", Offset = "0x2928810", VA = "0x18292A010", Slot = "16")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	protected override ComponentType KBLJDBJPDPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B43")]
		[Cpp2IlInjected.Address(RVA = "0x2929FB0", Offset = "0x29287B0", VA = "0x182929FB0", Slot = "17")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B40")]
	[Cpp2IlInjected.Address(RVA = "0x292A0D0", Offset = "0x29288D0", VA = "0x18292A0D0")]
	public MDHDBMMKMJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F9")]
internal abstract class HHBLAKGBMFH<TPlayerTag> : NHLEGKPBPCC where TPlayerTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400067D")]
	private EntityQuery HGEMMEGKHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400067E")]
	private EntityQuery JHNOLGKHKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400067F")]
	private EntityQuery FGEBPGEFBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000680")]
	private EntityQuery HNDABEBKLOH;

	[Cpp2IlInjected.Token(Token = "0x6000B45")]
	[Cpp2IlInjected.Address(RVA = "0x29AA2F0", Offset = "0x29A8AF0", VA = "0x1829AA2F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B46")]
	[Cpp2IlInjected.Address(RVA = "0x29AA4F0", Offset = "0x29A8CF0", VA = "0x1829AA4F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B47")]
	[Cpp2IlInjected.Address(RVA = "0x29AA4C0", Offset = "0x29A8CC0", VA = "0x1829AA4C0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B48")]
	[Cpp2IlInjected.Address(RVA = "0x29A9D40", Offset = "0x29A8540", VA = "0x1829A9D40")]
	private void NCHGNNJAGFI(EntityQuery EGFJCKOAGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B49")]
	[Cpp2IlInjected.Address(RVA = "0x29A9200", Offset = "0x29A7A00", VA = "0x1829A9200")]
	private void JEHEBPJBKMD(EntityQuery EGFJCKOAGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4A")]
	[Cpp2IlInjected.Address(RVA = "0x29A8E10", Offset = "0x29A7610", VA = "0x1829A8E10")]
	private void CLFGLLOOPBH(EntityQuery EGFJCKOAGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	protected abstract void HKAGKAAAMCN(NativeArray<Entity> KFLBCCAJFMN, NativeArray<Entity> OHPLMCMHCIP, NativeArray<Entity> LHDFKMLKNBK);

	[Cpp2IlInjected.Token(Token = "0x6000B4C")]
	[Cpp2IlInjected.Address(RVA = "0x29AA580", Offset = "0x29A8D80", VA = "0x1829AA580")]
	protected HHBLAKGBMFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FA")]
[AlwaysUpdateSystem]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
public class DPPBMMJBMCO : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000681")]
	private HMBELPNBOEG LNJHNPCFKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000682")]
	[NAAJCOHOAKA]
	private OABNFEOAMFN HOAPIJEHJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000683")]
	[NAAJCOHOAKA]
	private OBIIMMCNMNC AMFLIPPMOPG;

	[Cpp2IlInjected.Token(Token = "0x6000B4D")]
	[Cpp2IlInjected.Address(RVA = "0x2C6D3F0", Offset = "0x2C6BBF0", VA = "0x182C6D3F0", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4E")]
	[Cpp2IlInjected.Address(RVA = "0x2C6D370", Offset = "0x2C6BB70", VA = "0x182C6D370")]
	protected void IKHJILPMBII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4F")]
	[Cpp2IlInjected.Address(RVA = "0x2C6D480", Offset = "0x2C6BC80", VA = "0x182C6D480", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B50")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public DPPBMMJBMCO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001FB")]
public struct PKDIKEHIAMO : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x4000684")]
	public static readonly PKDIKEHIAMO GDCPNJEFLGI;

	[Cpp2IlInjected.Token(Token = "0x6000B51")]
	[Cpp2IlInjected.Address(RVA = "0x22C17B0", Offset = "0x22BFFB0", VA = "0x1822C17B0", Slot = "4")]
	public bool Equals(LinkedEntityGroup FBGKLELIKCG, LinkedEntityGroup LFJEFFKGLOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B52")]
	[Cpp2IlInjected.Address(RVA = "0x22C17D0", Offset = "0x22BFFD0", VA = "0x1822C17D0", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup CEPDEAHBHLF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FC")]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
public class GFLMOBBOHHK : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000685")]
	private FFHJPFHDABG JPEBDJJCNOI;

	[Cpp2IlInjected.Token(Token = "0x6000B54")]
	[Cpp2IlInjected.Address(RVA = "0x2C7CC40", Offset = "0x2C7B440", VA = "0x182C7CC40", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B55")]
	[Cpp2IlInjected.Address(RVA = "0x2C7CC90", Offset = "0x2C7B490", VA = "0x182C7CC90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B56")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public GFLMOBBOHHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FD")]
internal abstract class FFGKGHJCIFC : GDNJPKKODAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000686")]
	private EntityQuery PNAIDKDELLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000687")]
	private EntityQuery PFFLNFDNFJM;

	[Cpp2IlInjected.Token(Token = "0x6000B57")]
	[Cpp2IlInjected.Address(RVA = "0x2C76540", Offset = "0x2C74D40", VA = "0x182C76540", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B58")]
	[Cpp2IlInjected.Address(RVA = "0x2C768C0", Offset = "0x2C750C0", VA = "0x182C768C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B59")]
	[Cpp2IlInjected.Address(RVA = "0x2C76490", Offset = "0x2C74C90", VA = "0x182C76490")]
	private void FHLDMNGNDBI(EntityQuery EGFJCKOAGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5A")]
	[Cpp2IlInjected.Address(RVA = "0x2C76970", Offset = "0x2C75170", VA = "0x182C76970")]
	protected FFGKGHJCIFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FF")]
public class ABFOAILAOPF : NHLEGKPBPCC
{
	[Cpp2IlInjected.Token(Token = "0x6000B5D")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5E")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public ABFOAILAOPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000200")]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
internal class IGFBBIHFGLA : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.Token(Token = "0x4000689")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400068A")]
	private HMBELPNBOEG LNJHNPCFKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400068B")]
	private OIKLJKNPPOI MFGFOJJEBIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400068C")]
	private KMFOAMJFLAH PBHLNILGHAP;

	[Cpp2IlInjected.Token(Token = "0x6000B5F")]
	[Cpp2IlInjected.Address(RVA = "0x24EF920", Offset = "0x24EE120", VA = "0x1824EF920", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B60")]
	[Cpp2IlInjected.Address(RVA = "0x24EF9B0", Offset = "0x24EE1B0", VA = "0x1824EF9B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B61")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public IGFBBIHFGLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000201")]
[KHNAILLFHGJ(typeof(BMMKBDIEBCN), new string[] { })]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
internal sealed class BMMKBDIEBCN : NOFCHOCEBPC, NOHOJBNCAJC
{
	[Cpp2IlInjected.Token(Token = "0x400068D")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400068E")]
	[NAAJCOHOAKA]
	private IKCMADHPPKE MFHEANKMMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400068F")]
	private NIJBLPDKGGM<Entity> OPCEAOKDBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000690")]
	private DMOLMGFOOHL<OEKNEICFKDA, ANDKGOKDDMF, FEHACGKKKFJ, OEOKFMKAJDD> FOBEFOPMLJP;

	[Cpp2IlInjected.Token(Token = "0x6000B63")]
	[Cpp2IlInjected.Address(RVA = "0x289EBA0", Offset = "0x289D3A0", VA = "0x18289EBA0", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B64")]
	[Cpp2IlInjected.Address(RVA = "0x289EA60", Offset = "0x289D260", VA = "0x18289EA60", Slot = "5")]
	public void GGJEPBDNAAH(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B65")]
	[Cpp2IlInjected.Address(RVA = "0x289E910", Offset = "0x289D110", VA = "0x18289E910")]
	public Entity DFDIEMMHEBB(Entity AJDEFAPHMKF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B66")]
	[Cpp2IlInjected.Address(RVA = "0x289E960", Offset = "0x289D160", VA = "0x18289E960")]
	public bool DMMEGNFOAHA(Entity AJDEFAPHMKF, Entity ILLDOGNGNOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B67")]
	[Cpp2IlInjected.Address(RVA = "0x289E9C0", Offset = "0x289D1C0", VA = "0x18289E9C0")]
	public bool EALODDMPHDN(Entity AJDEFAPHMKF, Entity ILLDOGNGNOD, bool ECCMKOMFCJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B68")]
	[Cpp2IlInjected.Address(RVA = "0x289E6E0", Offset = "0x289CEE0", VA = "0x18289E6E0")]
	private bool BPGIIEHGDFD(Entity AJDEFAPHMKF, Entity ILLDOGNGNOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B69")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public BMMKBDIEBCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000202")]
internal readonly struct CKEGIGFGJDN
{
	[Cpp2IlInjected.Token(Token = "0x2000203")]
	[BurstCompile]
	private struct HNHJCLGMEAG : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		[ReadOnly]
		public EntityTypeHandle KLEPNMBOFAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		[ReadOnly]
		public ComponentDataFromEntity<EHLOJPGEKBN> DGFHHILPGNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		[ReadOnly]
		public DynamicComponentTypeHandle MDEPAPAPIFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		[ReadOnly]
		public SharedComponentTypeHandle<RRObjectPrefabV2Data> LDMLIJEKPKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		[ReadOnly]
		public NativeParallelHashMap<int, Entity> NCDDNPKIBKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		[ReadOnly]
		public ComponentDataFromEntity FHIJKNCHOCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		[ReadOnly]
		public NativeArray<byte>.ReadOnly EGDAOLFGDNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		[ReadOnly]
		public NativeArray<BECDCKEMJCA>.ReadOnly KPNOJDCFKHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		public ComponentDataFromEntity BGPOPGCMFDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		public NativeList<Entity> ACHMIFMFFEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		public NativeList<Entity> PIDBNKHLMON;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public NativeList<byte> FMOEFBPCOHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public NativeList<byte> EFCCNDIOKBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public NativeList<byte> CNPEMNEPOEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		public int HJLDFBDBBHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public int ILIJGNGONLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public bool BPAHMACEENB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		public PNCOAHIEOAE.PDLKHOKKEFJ EDGJKPJHBBC;

		[Cpp2IlInjected.Token(Token = "0x6000B71")]
		[Cpp2IlInjected.Address(RVA = "0x222FFE0", Offset = "0x222E7E0", VA = "0x18222FFE0", Slot = "4")]
		public void Execute(ArchetypeChunk OPMNIAACDHI, int LEMMIPLDDBE, int FFOHIDMPEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(RVA = "0x222FC60", Offset = "0x222E460", VA = "0x18222FC60")]
		private unsafe bool CKNHEGBKGAO(Entity DLCNNIKHEAO, Entity JDAMJGGPEIG, byte* HIEIBFANCBG, byte* FOOFGNCEEIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B73")]
		[Cpp2IlInjected.Address(RVA = "0x222FC40", Offset = "0x222E440", VA = "0x18222FC40")]
		private unsafe void BBGJPJPLCPO(byte* HIEIBFANCBG, byte* FOOFGNCEEIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B74")]
		[Cpp2IlInjected.Address(RVA = "0x2230350", Offset = "0x222EB50", VA = "0x182230350")]
		private unsafe byte* LJJKDLEKKEC(NativeArray<byte> KKJFMAEJMMD, int NLNOELCPLOI)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0x222FE30", Offset = "0x222E630", VA = "0x18222FE30")]
		private unsafe byte* EDICOGHCMDH(Entity JDAMJGGPEIG)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0x222FEE0", Offset = "0x222E6E0", VA = "0x18222FEE0")]
		private unsafe byte* ELMDDDIDPCG(ArchetypeChunk OPMNIAACDHI)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B77")]
		[Cpp2IlInjected.Address(RVA = "0x222FEA0", Offset = "0x222E6A0", VA = "0x18222FEA0")]
		private static Entity EKHJAOOLPIP(in EHLOJPGEKBN NFBDMLCENEN)
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000204")]
	[BurstCompile]
	private struct JAIKFHLMGLO : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		[ReadOnly]
		public NativeList<Entity> NAKIEOGHMON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		[ReadOnly]
		public NativeList<byte> PEDOLFNDONN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		[ReadOnly]
		public NativeList<byte> GJEGKMGFEFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		[ReadOnly]
		public NativeList<byte> MLHMCFOKJPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		[ReadOnly]
		public NativeArray<BECDCKEMJCA>.ReadOnly KPNOJDCFKHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public NativeParallelMultiHashMap<Entity, EDAOOEIAPHC> OAECBHNICHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public int HJLDFBDBBHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public int ILIJGNGONLE;

		[Cpp2IlInjected.Token(Token = "0x6000B78")]
		[Cpp2IlInjected.Address(RVA = "0x2230A20", Offset = "0x222F220", VA = "0x182230A20", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000691")]
	private static readonly ProfilerMarker AJAJOBDBGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000692")]
	private readonly NHLEGKPBPCC EDPKAJCAKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000693")]
	private readonly World LDJNMODKEPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000694")]
	private readonly BHCNLMFFMGM CFMFDFNNBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000695")]
	private readonly NativeParallelHashMap<int, Entity> ADHHHLFCGLM;

	[Cpp2IlInjected.Token(Token = "0x6000B6B")]
	[Cpp2IlInjected.Address(RVA = "0x28A7ED0", Offset = "0x28A66D0", VA = "0x1828A7ED0")]
	public CKEGIGFGJDN(NHLEGKPBPCC EDPKAJCAKAA, World LDJNMODKEPA, OIKLJKNPPOI PMEOGKNMBGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6C")]
	[Cpp2IlInjected.Address(RVA = "0x28A7290", Offset = "0x28A5A90", VA = "0x1828A7290")]
	public JobHandle DNNKNEBJAJP(AJNCIBJCEPK COOBJCJFHEP, NativeList<(EntityQuery query, int typeIndex, int count, PNCOAHIEOAE.PDLKHOKKEFJ mode)> OIPELOCIIFJ, JobHandle BFAAEILACKK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6D")]
	[Cpp2IlInjected.Address(RVA = "0x28A7E00", Offset = "0x28A6600", VA = "0x1828A7E00")]
	private JAIKFHLMGLO PDKKKBEFCEK(in HNHJCLGMEAG APHOGGHEPCH, NativeParallelMultiHashMap<Entity, EDAOOEIAPHC> BJKHELFAHKO)
	{
		return default(JAIKFHLMGLO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6E")]
	[Cpp2IlInjected.Address(RVA = "0x28A7970", Offset = "0x28A6170", VA = "0x1828A7970")]
	private HNHJCLGMEAG FMNKHJNIGBN(ComponentType JHKLCDEPMAD, EntityManager CDNAJFOILPD, int NHMJONGKNOB, PNCOAHIEOAE.PDLKHOKKEFJ EDGJKPJHBBC)
	{
		return default(HNHJCLGMEAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6F")]
	[Cpp2IlInjected.Address(RVA = "0x28A70C0", Offset = "0x28A58C0", VA = "0x1828A70C0")]
	private static void DNGOGKBHBNL(AJNCIBJCEPK COOBJCJFHEP, ComponentType JHKLCDEPMAD, JobHandle LELCJDGAKHL, in HNHJCLGMEAG APHOGGHEPCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000205")]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
internal class LDBENMINNIC : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.Token(Token = "0x40006B0")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006B1")]
	private EntityQuery EGFJCKOAGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006B2")]
	private HMBELPNBOEG LNJHNPCFKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006B3")]
	private PPJGCIMLGBG MFHEANKMMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006B4")]
	private KMFOAMJFLAH PBHLNILGHAP;

	[Cpp2IlInjected.Token(Token = "0x6000B79")]
	[Cpp2IlInjected.Address(RVA = "0x291F7F0", Offset = "0x291DFF0", VA = "0x18291F7F0", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7A")]
	[Cpp2IlInjected.Address(RVA = "0x2920370", Offset = "0x291EB70", VA = "0x182920370", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7B")]
	[Cpp2IlInjected.Address(RVA = "0x2920410", Offset = "0x291EC10", VA = "0x182920410", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7C")]
	[Cpp2IlInjected.Address(RVA = "0x291F880", Offset = "0x291E080", VA = "0x18291F880")]
	private void NFAPBBPELIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7D")]
	[Cpp2IlInjected.Address(RVA = "0x2920420", Offset = "0x291EC20", VA = "0x182920420")]
	private void PCLBPEJIAHC(NativeArray<Entity> APFPBADEPOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7E")]
	[Cpp2IlInjected.Address(RVA = "0x2920530", Offset = "0x291ED30", VA = "0x182920530")]
	private void PHGDENLOHOI(NativeArray<Entity> KFLBCCAJFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7F")]
	[Cpp2IlInjected.Address(RVA = "0x291F680", Offset = "0x291DE80", VA = "0x18291F680")]
	private void GIKGNEDOLOO(NativeArray<Entity> NHCNNCOLOAK, NativeArray<RigidTransform> NHHFOMJCPHP, NativeArray<RigidTransform> HCGKFNNMPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B80")]
	[Cpp2IlInjected.Address(RVA = "0x291FEF0", Offset = "0x291E6F0", VA = "0x18291FEF0")]
	private void OECALMCIEDN(NativeArray<RigidTransform> HCGKFNNMPAA, NativeArray<Entity> NHCNNCOLOAK, NativeList<Entity> HHIIBIKHBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B81")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public LDBENMINNIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000206")]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
internal sealed class ONDNEPIFEBK : GJJADNOGMIL
{
	[Cpp2IlInjected.Token(Token = "0x6000B83")]
	[Cpp2IlInjected.Address(RVA = "0x22BD020", Offset = "0x22BB820", VA = "0x1822BD020", Slot = "15")]
	protected override ComponentSystemBase CMFPJFIFJLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B84")]
	[Cpp2IlInjected.Address(RVA = "0x22BD2C0", Offset = "0x22BBAC0", VA = "0x1822BD2C0")]
	public ONDNEPIFEBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000207")]
internal abstract class PEPJPPPDFOK : GJJADNOGMIL, NOFCHOCEBPC
{
	[Cpp2IlInjected.Token(Token = "0x40006B5")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40006B6")]
	private OIKLJKNPPOI PMEOGKNMBGE;

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	protected abstract HPOKAOBOIJC KKFMLANCONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B85")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B86")]
	[Cpp2IlInjected.Address(RVA = "0x22C09F0", Offset = "0x22BF1F0", VA = "0x1822C09F0", Slot = "16")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B87")]
	[Cpp2IlInjected.Address(RVA = "0x22C0A40", Offset = "0x22BF240", VA = "0x1822C0A40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B88")]
	[Cpp2IlInjected.Address(RVA = "0x22C0650", Offset = "0x22BEE50", VA = "0x1822C0650", Slot = "15")]
	protected override ComponentSystemBase CMFPJFIFJLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B89")]
	[Cpp2IlInjected.Address(RVA = "0x22BD2C0", Offset = "0x22BBAC0", VA = "0x1822BD2C0")]
	protected PEPJPPPDFOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000208")]
public class ONCHGAJPAEC : NHLEGKPBPCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006B7")]
	private EntityQuery EGFJCKOAGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006B8")]
	private BEANJBEKLGM KFAEBKFHHLM;

	[Cpp2IlInjected.Token(Token = "0x6000B8B")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE40", Offset = "0x22BB640", VA = "0x1822BCE40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8C")]
	[Cpp2IlInjected.Address(RVA = "0x22BCF10", Offset = "0x22BB710", VA = "0x1822BCF10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8D")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public ONCHGAJPAEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000209")]
[UpdateAfter(typeof(JFBHOBLAOFF))]
public class OGIKBFPLBDH : NHLEGKPBPCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006B9")]
	private EntityArchetype OIHKDABAGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006BA")]
	private EntityQuery EGFJCKOAGFH;

	[Cpp2IlInjected.Token(Token = "0x6000B8E")]
	[Cpp2IlInjected.Address(RVA = "0x293C200", Offset = "0x293AA00", VA = "0x18293C200", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8F")]
	[Cpp2IlInjected.Address(RVA = "0x293C2F0", Offset = "0x293AAF0", VA = "0x18293C2F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B90")]
	[Cpp2IlInjected.Address(RVA = "0x293C1B0", Offset = "0x293A9B0", VA = "0x18293C1B0")]
	private EntityCommandBufferSystem EFIPACDBNFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B91")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public OGIKBFPLBDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020A")]
internal class FAGOHAPEHNB : GKEKBMGOHDE
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200020B")]
	public struct GNGCCDCIJAB : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x40006BB")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	protected override ComponentType DGPOOFGMLPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000B93")]
		[Cpp2IlInjected.Address(RVA = "0x2C761F0", Offset = "0x2C749F0", VA = "0x182C761F0", Slot = "15")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	protected override ComponentType PPHMGJJPIMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000B94")]
		[Cpp2IlInjected.Address(RVA = "0x2C76220", Offset = "0x2C74A20", VA = "0x182C76220", Slot = "16")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	protected override ComponentType KBLJDBJPDPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B95")]
		[Cpp2IlInjected.Address(RVA = "0x2C761C0", Offset = "0x2C749C0", VA = "0x182C761C0", Slot = "17")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B92")]
	[Cpp2IlInjected.Address(RVA = "0x2C762E0", Offset = "0x2C74AE0", VA = "0x182C762E0")]
	public FAGOHAPEHNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020C")]
[AlwaysUpdateSystem]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
public class HBPMKACJEEA : NHLEGKPBPCC, NOFCHOCEBPC, PCAPGPPECJN
{
	[Cpp2IlInjected.Token(Token = "0x200020D")]
	[CompilerGenerated]
	private sealed class BBJGJDGGPAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		public LPLJHAHPEEF localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		public GKNLHHGAJBJ collisionLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		public bool collidersEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		public JBNEKLMDNOC containerFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public bool physicsEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		public bool gravityEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		public bool hasUnityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public HBPMKACJEEA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000B9E")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public BBJGJDGGPAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9F")]
		[Cpp2IlInjected.Address(RVA = "0x2228620", Offset = "0x2226E20", VA = "0x182228620")]
		internal void GHGKCLHADCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA0")]
		[Cpp2IlInjected.Address(RVA = "0x22283C0", Offset = "0x2226BC0", VA = "0x1822283C0")]
		internal void BFPBGJLGAJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA1")]
		[Cpp2IlInjected.Address(RVA = "0x22284E0", Offset = "0x2226CE0", VA = "0x1822284E0")]
		internal void CABHDLIMOGH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006BC")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006BD")]
	private EntityQuery EGFJCKOAGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006BE")]
	[NAAJCOHOAKA]
	private OBIIMMCNMNC AMFLIPPMOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006BF")]
	[NAAJCOHOAKA]
	private MDFAPHDDPNI ICCJCKNDIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006C0")]
	[NAAJCOHOAKA]
	private FNKAOJGCPPO KFLPLGKPMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006C1")]
	private HMBELPNBOEG LNJHNPCFKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006C2")]
	public ComponentTypeHandle<JBNEKLMDNOC> LCKPMAJMKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40006C3")]
	public ComponentTypeHandle<HMJCDHFLPNL> HDJNLHFJBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006C4")]
	public ComponentTypeHandle<HGBMIMHDHLI> EHMMCKCDANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40006C5")]
	public ComponentTypeHandle<LHGMHGJGEDG> BHFDNHDBAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40006C6")]
	public ComponentTypeHandle<CDPJJJJBOFJ> LCKBHNFNOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40006C7")]
	public DynamicComponentTypeHandle DIHOHGMDEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40006C8")]
	public EntityTypeHandle PEBMAKGHCFL;

	[Cpp2IlInjected.Token(Token = "0x6000B97")]
	[Cpp2IlInjected.Address(RVA = "0x24E5710", Offset = "0x24E3F10", VA = "0x1824E5710", Slot = "15")]
	public void PAHLDMJMCEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B98")]
	[Cpp2IlInjected.Address(RVA = "0x24E4650", Offset = "0x24E2E50", VA = "0x1824E4650", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B99")]
	[Cpp2IlInjected.Address(RVA = "0x24E4700", Offset = "0x24E2F00", VA = "0x1824E4700", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9A")]
	[Cpp2IlInjected.Address(RVA = "0x24E4480", Offset = "0x24E2C80", VA = "0x1824E4480")]
	private void IHHGOIIHKEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9B")]
	[Cpp2IlInjected.Address(RVA = "0x24E4170", Offset = "0x24E2970", VA = "0x1824E4170")]
	private bool AGPEDOMNCFO(out int BNGEDHMIHEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9C")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public HBPMKACJEEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020E")]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
public sealed class FKNBMLMJHKD : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006D1")]
	private JIHNNDGLHPF JBPDPEIHKOJ;

	[Cpp2IlInjected.Token(Token = "0x6000BA2")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A4F0", Offset = "0x2C78CF0", VA = "0x182C7A4F0", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA3")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A550", Offset = "0x2C78D50", VA = "0x182C7A550", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA4")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public FKNBMLMJHKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020F")]
internal abstract class OJBJPKKIOND : GDNJPKKODAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006D2")]
	private EntityQuery EGFJCKOAGFH;

	[Cpp2IlInjected.Token(Token = "0x6000BA5")]
	[Cpp2IlInjected.Address(RVA = "0x293CF90", Offset = "0x293B790", VA = "0x18293CF90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA6")]
	[Cpp2IlInjected.Address(RVA = "0x293D270", Offset = "0x293BA70", VA = "0x18293D270", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA7")]
	[Cpp2IlInjected.Address(RVA = "0x293D330", Offset = "0x293BB30", VA = "0x18293D330")]
	protected OJBJPKKIOND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000210")]
[AlwaysUpdateSystem]
public class PNCOAHIEOAE : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.Token(Token = "0x2000211")]
	public enum PDLKHOKKEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		Create,
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		Remove
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006D3")]
	[NAAJCOHOAKA]
	private ILBBGIPPPPJ KFELNFLBJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006D4")]
	[NAAJCOHOAKA]
	private OIKLJKNPPOI PMEOGKNMBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006D5")]
	private NMNAGIAFPHA OBMINAACJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006D6")]
	private OJMEFLPLNAM FPMLGOJJBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40006D7")]
	private BMONKDLIOFJ BOJKIJGBJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40006D8")]
	private PFIPHDFKNLD PMAAOIMKGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40006D9")]
	private CKEGIGFGJDN PFBPKPGPEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40006DA")]
	private OOAOLOKBLAE LDCONNOCLAP;

	[Cpp2IlInjected.Token(Token = "0x6000BA8")]
	[Cpp2IlInjected.Address(RVA = "0x22C1890", Offset = "0x22C0090", VA = "0x1822C1890", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA9")]
	[Cpp2IlInjected.Address(RVA = "0x22C1BC0", Offset = "0x22C03C0", VA = "0x1822C1BC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAA")]
	[Cpp2IlInjected.Address(RVA = "0x22C1CB0", Offset = "0x22C04B0", VA = "0x1822C1CB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAB")]
	[Cpp2IlInjected.Address(RVA = "0x22C20B0", Offset = "0x22C08B0", VA = "0x1822C20B0")]
	private void PEFJIBJGHBJ(out NativeArray<MHGAJIKGEGE> OAPBHJIHLMO, out NativeArray<CBGNFPNAGKM> NHOIGPDOBNB, out NativeArray<MHGAJIKGEGE> OKDKKADGGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAC")]
	[Cpp2IlInjected.Address(RVA = "0x22C1CA0", Offset = "0x22C04A0", VA = "0x1822C1CA0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAD")]
	[Cpp2IlInjected.Address(RVA = "0x22C1C30", Offset = "0x22C0430", VA = "0x1822C1C30", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAE")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public PNCOAHIEOAE()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000212")]
	[CompilerGenerated]
	[KAPPDMKCEOO(JLEAEANKKDG.OMRoom)]
	public class PostLoadInitializeNetworkId : NHLEGKPBPCC, NOFCHOCEBPC
	{
		[Cpp2IlInjected.Token(Token = "0x2000213")]
		[BurstCompile]
		[NoAlias]
		private struct PostLoadInitializeNetworkId_LambdaJob_0_Job : IJobEntityBatchWithIndex
		{
			[Cpp2IlInjected.Token(Token = "0x2000214")]
			public delegate void RunWithoutJobSystem_00000DB8$PostfixBurstDelegate(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x2000215")]
			internal static class RunWithoutJobSystem_00000DB8$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x40006F0")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x40006F1")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x6000BCB")]
				[Cpp2IlInjected.Address(RVA = "0x6020530", Offset = "0x601ED30", VA = "0x186020530")]
				[BurstDiscard]
				private static void POFINAJNFAL(ref IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000BCC")]
				[Cpp2IlInjected.Address(RVA = "0x60200A0", Offset = "0x601E8A0", VA = "0x1860200A0")]
				private static IntPtr GFGFNEBPFAM()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000BCD")]
				[Cpp2IlInjected.Address(RVA = "0x6020470", Offset = "0x601EC70", VA = "0x186020470")]
				public static void MKAFKJABJJI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000BCE")]
				[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
				public static void BDCEDMLOOPD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000BD0")]
				[Cpp2IlInjected.Address(RVA = "0x6020230", Offset = "0x601EA30", VA = "0x186020230")]
				public static void MADELAMLLLM(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40006EB")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x40006EC")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006ED")]
			public NativeParallelHashMap<MHGAJIKGEGE, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006EE")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006EF")]
			public ComponentTypeHandle<GODBGECHIFD> __networkComponentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000BC3")]
			[Cpp2IlInjected.Address(RVA = "0x601D0C0", Offset = "0x601B8C0", VA = "0x18601D0C0")]
			private void BNHOJHOEIPF(Entity entity, int entityInQueryIndex, [NoAlias] ref GODBGECHIFD networkComponent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BC4")]
			[Cpp2IlInjected.Address(RVA = "0x601D150", Offset = "0x601B950", VA = "0x18601D150", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex, int indexOfFirstEntityInQuery)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BC5")]
			[Cpp2IlInjected.Address(RVA = "0x601D050", Offset = "0x601B850", VA = "0x18601D050")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void AABEEOLFMKP(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BC6")]
			[Cpp2IlInjected.Address(RVA = "0x601D290", Offset = "0x601BA90", VA = "0x18601D290")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void NDHFIMMDDCJ(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000216")]
		[NoAlias]
		[BurstCompile]
		private struct PostLoadInitializeNetworkId_LambdaJob_1_Job : IJobEntityBatchWithIndex
		{
			[Cpp2IlInjected.Token(Token = "0x2000217")]
			public delegate void RunWithoutJobSystem_00000DBB$PostfixBurstDelegate(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x2000218")]
			internal static class RunWithoutJobSystem_00000DBB$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x40006F9")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x40006FA")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x6000BD9")]
				[Cpp2IlInjected.Address(RVA = "0x6020D90", Offset = "0x601F590", VA = "0x186020D90")]
				[BurstDiscard]
				private static void POFINAJNFAL(ref IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000BDA")]
				[Cpp2IlInjected.Address(RVA = "0x6020900", Offset = "0x601F100", VA = "0x186020900")]
				private static IntPtr GFGFNEBPFAM()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000BDB")]
				[Cpp2IlInjected.Address(RVA = "0x6020CD0", Offset = "0x601F4D0", VA = "0x186020CD0")]
				public static void MKAFKJABJJI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000BDC")]
				[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
				public static void BDCEDMLOOPD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000BDE")]
				[Cpp2IlInjected.Address(RVA = "0x6020A90", Offset = "0x601F290", VA = "0x186020A90")]
				public static void MADELAMLLLM(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40006F2")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x40006F3")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006F4")]
			public NativeParallelHashMap<MHGAJIKGEGE, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006F5")]
			public uint playerId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006F6")]
			public uint offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006F7")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40006F8")]
			public ComponentTypeHandle<GODBGECHIFD> __dstValueTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000BD1")]
			[Cpp2IlInjected.Address(RVA = "0x601D380", Offset = "0x601BB80", VA = "0x18601D380")]
			private void BNHOJHOEIPF(Entity entity, int entityInQueryIndex, [NoAlias] ref GODBGECHIFD dstValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BD2")]
			[Cpp2IlInjected.Address(RVA = "0x601D410", Offset = "0x601BC10", VA = "0x18601D410", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex, int indexOfFirstEntityInQuery)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BD3")]
			[Cpp2IlInjected.Address(RVA = "0x601D310", Offset = "0x601BB10", VA = "0x18601D310")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void AABEEOLFMKP(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BD4")]
			[Cpp2IlInjected.Address(RVA = "0x601D550", Offset = "0x601BD50", VA = "0x18601D550")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void NDHFIMMDDCJ(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000219")]
		[BurstCompile]
		[NoAlias]
		private struct PostLoadInitializeNetworkId_LambdaJob_2_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.Token(Token = "0x200021A")]
			public delegate void RunWithoutJobSystem_00000DBE$PostfixBurstDelegate(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x200021B")]
			internal static class RunWithoutJobSystem_00000DBE$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x4000701")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x4000702")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x6000BE7")]
				[Cpp2IlInjected.Address(RVA = "0x6021410", Offset = "0x601FC10", VA = "0x186021410")]
				[BurstDiscard]
				private static void POFINAJNFAL(ref IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000BE8")]
				[Cpp2IlInjected.Address(RVA = "0x6020F80", Offset = "0x601F780", VA = "0x186020F80")]
				private static IntPtr GFGFNEBPFAM()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000BE9")]
				[Cpp2IlInjected.Address(RVA = "0x6021350", Offset = "0x601FB50", VA = "0x186021350")]
				public static void MKAFKJABJJI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000BEA")]
				[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
				public static void BDCEDMLOOPD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000BEC")]
				[Cpp2IlInjected.Address(RVA = "0x6021110", Offset = "0x601F910", VA = "0x186021110")]
				public static void MADELAMLLLM(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40006FB")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x40006FC")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006FD")]
			public NativeParallelHashMap<MHGAJIKGEGE, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006FE")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006FF")]
			public ComponentTypeHandle<GODBGECHIFD> __dstValueTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000700")]
			[ReadOnly]
			public ComponentTypeHandle<OverrideObjectNetworkIdData> __srcValueTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000BDF")]
			[Cpp2IlInjected.Address(RVA = "0x601D640", Offset = "0x601BE40", VA = "0x18601D640")]
			private void BNHOJHOEIPF(Entity entity, [NoAlias] ref GODBGECHIFD dstValue, [NoAlias] in OverrideObjectNetworkIdData srcValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BE0")]
			[Cpp2IlInjected.Address(RVA = "0x601D6E0", Offset = "0x601BEE0", VA = "0x18601D6E0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BE1")]
			[Cpp2IlInjected.Address(RVA = "0x601D5D0", Offset = "0x601BDD0", VA = "0x18601D5D0")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void AABEEOLFMKP(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BE2")]
			[Cpp2IlInjected.Address(RVA = "0x601D880", Offset = "0x601C080", VA = "0x18601D880")]
			[BurstCompile]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void NDHFIMMDDCJ(ref ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200021C")]
		private struct PostLoadInitializeNetworkId_LambdaJob_3_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000703")]
			public NativeParallelHashMap<MHGAJIKGEGE, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000704")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000705")]
			[ReadOnly]
			public ComponentTypeHandle<OverrideObjectNetworkIdData> __srcValueTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000BED")]
			[Cpp2IlInjected.Address(RVA = "0x601D900", Offset = "0x601C100", VA = "0x18601D900")]
			private void BNHOJHOEIPF(Entity entity, in OverrideObjectNetworkIdData srcValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BEE")]
			[Cpp2IlInjected.Address(RVA = "0x601DA30", Offset = "0x601C230", VA = "0x18601DA30", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		public static readonly JNGNMMOLKFF log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		[NAAJCOHOAKA]
		private DLLLPKHOKKN networkToLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		[NAAJCOHOAKA]
		private GJCOMGMOGCM scenes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		private EntityQuery queryAllInScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		private EntityQuery additiveQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		private EntityQuery PostLoadInitializeNetworkId_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		private EntityQuery PostLoadInitializeNetworkId_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		private EntityQuery PostLoadInitializeNetworkId_LambdaJob_2_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		private EntityQuery PostLoadInitializeNetworkId_LambdaJob_3_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		private EntityQuery __query_4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		private ComponentTypeHandle<GODBGECHIFD> __RecRoom_Components_ObjectNetworkIdComponentData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		private ComponentTypeHandle<OverrideObjectNetworkIdData> __RecRoom_Components_OverrideObjectNetworkIdData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0x22CC650", Offset = "0x22CAE50", VA = "0x1822CC650", Slot = "14")]
		public void InitReferences(NCFCHDEHMHC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB0")]
		[Cpp2IlInjected.Address(RVA = "0x22CDA30", Offset = "0x22CC230", VA = "0x1822CDA30", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB1")]
		[Cpp2IlInjected.Address(RVA = "0x22CDAF0", Offset = "0x22CC2F0", VA = "0x1822CDAF0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB2")]
		[Cpp2IlInjected.Address(RVA = "0x22CC1B0", Offset = "0x22CA9B0", VA = "0x1822CC1B0")]
		public void BKNEPAHIMBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB3")]
		[Cpp2IlInjected.Address(RVA = "0x22CCA70", Offset = "0x22CB270", VA = "0x1822CCA70")]
		private void MONEPEHBCMK(NativeParallelHashMap<MHGAJIKGEGE, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB4")]
		[Cpp2IlInjected.Address(RVA = "0x22CC6C0", Offset = "0x22CAEC0", VA = "0x1822CC6C0")]
		private void JJLMIJAOKEK(NativeParallelHashMap<MHGAJIKGEGE, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB5")]
		[Cpp2IlInjected.Address(RVA = "0x22CC390", Offset = "0x22CAB90", VA = "0x1822CC390")]
		private void EGGKJJJDIGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB6")]
		[Cpp2IlInjected.Address(RVA = "0x22CDD50", Offset = "0x22CC550", VA = "0x1822CDD50")]
		private void PFIIKJANJHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB7")]
		[Cpp2IlInjected.Address(RVA = "0x22CC220", Offset = "0x22CAA20", VA = "0x1822CC220")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void CAMHMKLMNBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB8")]
		[Cpp2IlInjected.Address(RVA = "0x22CDED0", Offset = "0x22CC6D0", VA = "0x1822CDED0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void PJANNKMJJJI(NativeParallelHashMap<MHGAJIKGEGE, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB9")]
		[Cpp2IlInjected.Address(RVA = "0x22CCF40", Offset = "0x22CB740", VA = "0x1822CCF40")]
		private void OPCBJKJDLNA(ref NativeParallelHashMap<MHGAJIKGEGE, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBA")]
		[Cpp2IlInjected.Address(RVA = "0x22CC910", Offset = "0x22CB110", VA = "0x1822CC910")]
		private void LAFEOFKLCEE(ref NativeParallelHashMap<MHGAJIKGEGE, Entity> map, ref uint playerId, ref uint offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0x22CC030", Offset = "0x22CA830", VA = "0x1822CC030")]
		private void BAJBPKPJABC(ref NativeParallelHashMap<MHGAJIKGEGE, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0x22CC240", Offset = "0x22CAA40", VA = "0x1822CC240")]
		private void DEINPEEOBBI(ref NativeParallelHashMap<MHGAJIKGEGE, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0x22CD0B0", Offset = "0x22CB8B0", VA = "0x1822CD0B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBE")]
		[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
		public PostLoadInitializeNetworkId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC0")]
		[Cpp2IlInjected.Address(RVA = "0x22CC5B0", Offset = "0x22CADB0", VA = "0x1822CC5B0")]
		public static void HPNBMEEOECC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0x22CC600", Offset = "0x22CAE00", VA = "0x1822CC600")]
		public static void INBHIEOGAMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x22CC340", Offset = "0x22CAB40", VA = "0x1822CC340")]
		public static void DNCMKKOOGOG()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200021D")]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
internal class DENGEEBLHID : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.Token(Token = "0x4000706")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000707")]
	private EntityQuery GHKKLCBHOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000708")]
	private JGHGFLIKNJI FOMNIIGGJOB;

	[Cpp2IlInjected.Token(Token = "0x6000BEF")]
	[Cpp2IlInjected.Address(RVA = "0x2C676D0", Offset = "0x2C65ED0", VA = "0x182C676D0", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF0")]
	[Cpp2IlInjected.Address(RVA = "0x2C67720", Offset = "0x2C65F20", VA = "0x182C67720", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF1")]
	[Cpp2IlInjected.Address(RVA = "0x2C677D0", Offset = "0x2C65FD0", VA = "0x182C677D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF2")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public DENGEEBLHID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200021E")]
[KHNAILLFHGJ(typeof(ICLGKIICAFG), new string[] { })]
[HHKHACIGOAG(JLEAEANKKDG.PhotonRoom)]
internal class FIMPCADKLHP : NOFCHOCEBPC, ICLGKIICAFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000709")]
	[NAAJCOHOAKA]
	private ILBBGIPPPPJ EJLFIBCCMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400070A")]
	[NAAJCOHOAKA]
	private GJCOMGMOGCM DOEAPBCCKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400070B")]
	private readonly Dictionary<int, Entity> EKGONHNAHAF;

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	private EntityManager EOOAJAELBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0x2C78820", Offset = "0x2C77020", VA = "0x182C78820")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF5")]
	[Cpp2IlInjected.Address(RVA = "0x2C78870", Offset = "0x2C77070", VA = "0x182C78870", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF6")]
	[Cpp2IlInjected.Address(RVA = "0x2C78970", Offset = "0x2C77170", VA = "0x182C78970", Slot = "5")]
	public void PEPEEONGLMF(LPLJHAHPEEF BBNGIDIFEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF7")]
	[Cpp2IlInjected.Address(RVA = "0x2C785F0", Offset = "0x2C76DF0", VA = "0x182C785F0", Slot = "6")]
	public bool CNKDIEMBMOE(LPLJHAHPEEF BBNGIDIFEAM, Transform LAMNAOAMKPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF8")]
	[Cpp2IlInjected.Address(RVA = "0x2C78900", Offset = "0x2C77100", VA = "0x182C78900")]
	private bool JKICACCJHGA(Scene JJIAFDKCLGJ, out Entity APMBELOEFNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF9")]
	[Cpp2IlInjected.Address(RVA = "0x2C78AF0", Offset = "0x2C772F0", VA = "0x182C78AF0")]
	public FIMPCADKLHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200021F")]
public class IMNFKELELBD : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400070C")]
	[NAAJCOHOAKA]
	private OIKLJKNPPOI KALHNOCEJBF;

	[Cpp2IlInjected.Token(Token = "0x6000BFA")]
	[Cpp2IlInjected.Address(RVA = "0x24F0E60", Offset = "0x24EF660", VA = "0x1824F0E60", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BFB")]
	[Cpp2IlInjected.Address(RVA = "0x24F0EB0", Offset = "0x24EF6B0", VA = "0x1824F0EB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BFC")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public IMNFKELELBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000220")]
public abstract class EEGODALIIAO : NHLEGKPBPCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400070D")]
	private EntityQuery EGFJCKOAGFH;

	[Cpp2IlInjected.Token(Token = "0x6000BFD")]
	[Cpp2IlInjected.Address(Slot = "14")]
	protected abstract EntityCommandBufferSystem EFIPACDBNFN();

	[Cpp2IlInjected.Token(Token = "0x6000BFE")]
	[Cpp2IlInjected.Address(RVA = "0x2C73D00", Offset = "0x2C72500", VA = "0x182C73D00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BFF")]
	[Cpp2IlInjected.Address(RVA = "0x2C73D90", Offset = "0x2C72590", VA = "0x182C73D90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C00")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	protected EEGODALIIAO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000221")]
public struct DMADMAHHFHK : OKAJMKCABLI<OEKNEICFKDA>
{
	[Cpp2IlInjected.Token(Token = "0x6000C01")]
	[Cpp2IlInjected.Address(RVA = "0x2C6B840", Offset = "0x2C6A040", VA = "0x182C6B840", Slot = "4")]
	public bool EDEIOAAABHB(OEKNEICFKDA MENBIMCLIOI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000222")]
public static class JEFNONENBML
{
	[Cpp2IlInjected.Token(Token = "0x6000C02")]
	[Cpp2IlInjected.Address(RVA = "0x24F3D30", Offset = "0x24F2530", VA = "0x1824F3D30")]
	public static NativeParallelHashSet<int> FJFMIMDENPI(EntityManager EADLBIHJKBG, Allocator HMGEFCKKBID)
	{
		return default(NativeParallelHashSet<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C03")]
	[Cpp2IlInjected.Address(RVA = "0x24F4250", Offset = "0x24F2A50", VA = "0x1824F4250")]
	public static NativeParallelHashMap<int, int> NJGBDBBPOKF(EntityManager EADLBIHJKBG, Allocator HMGEFCKKBID)
	{
		return default(NativeParallelHashMap<int, int>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000223")]
internal readonly struct NMNAGIAFPHA
{
	[Cpp2IlInjected.Token(Token = "0x400070E")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.Token(Token = "0x400070F")]
	private static readonly ProfilerMarker AJAJOBDBGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000710")]
	private readonly NHLEGKPBPCC EDPKAJCAKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000711")]
	private readonly World LDJNMODKEPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000712")]
	private readonly EntityQuery EGFJCKOAGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000713")]
	private readonly EntityQuery LHGACIBBPDJ;

	[Cpp2IlInjected.Token(Token = "0x6000C04")]
	[Cpp2IlInjected.Address(RVA = "0x2934BE0", Offset = "0x29333E0", VA = "0x182934BE0")]
	public NMNAGIAFPHA(NHLEGKPBPCC EDPKAJCAKAA, World LDJNMODKEPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C05")]
	[Cpp2IlInjected.Address(RVA = "0x2934600", Offset = "0x2932E00", VA = "0x182934600")]
	public (NativeArray<MHGAJIKGEGE>, NativeArray<CBGNFPNAGKM>) DNNKNEBJAJP()
	{
		return default((NativeArray<MHGAJIKGEGE>, NativeArray<CBGNFPNAGKM>));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000224")]
internal interface DCDCMCEDILM
{
	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	bool IGCDHJBKAGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000C07")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	NativeArray<MHGAJIKGEGE> HIBDOFCNJOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000C08")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	NativeArray<CBGNFPNAGKM> KBMMOAOAKAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000C09")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	NativeArray<MHGAJIKGEGE> GIBPHNAOGAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000C0A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C0B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CKHJPFGCJHK(out NativeArray<int> JBFHHCCJFKA, Allocator HMGEFCKKBID);

	[Cpp2IlInjected.Token(Token = "0x6000C0C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OPFEOMBNJDN(ComponentType JHKLCDEPMAD, out IAPFIKFHMGA GNGOHFCIIGM, out GGOBGEMCPKI KMILPECLOGP);

	[Cpp2IlInjected.Token(Token = "0x6000C0D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeMultiHashMapAsync<Entity, EDAOOEIAPHC> ODFMNHJMAGM();
}
[Cpp2IlInjected.Token(Token = "0x2000225")]
internal static class CJGPCOMGEHN
{
	[Cpp2IlInjected.Token(Token = "0x6000C0E")]
	[Cpp2IlInjected.Address(RVA = "0x28A59F0", Offset = "0x28A41F0", VA = "0x1828A59F0")]
	public static bool MJNBPCBEDLK(this DCDCMCEDILM COOBJCJFHEP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000226")]
[KHNAILLFHGJ(typeof(NFCEEAILPLD), new string[] { })]
public sealed class OPHELJPLNII : NFCEEAILPLD, NOFCHOCEBPC
{
	[Cpp2IlInjected.Token(Token = "0x2000227")]
	[BurstCompile]
	private struct CJMJKJIPAOD : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		[ReadOnly]
		public NativeArray<Entity> KFLBCCAJFMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		[ReadOnly]
		public float3 FJGJHLMGMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		[ReadOnly]
		public float3 NALLHJKKPNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		[ReadOnly]
		public ComponentDataFromEntity<OEKNEICFKDA> NDAAABEDKKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		[ReadOnly]
		public ComponentDataFromEntity<BGNDJFIJAFN> BLMBNBEOFBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> HFHEEKEBJOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		[ReadOnly]
		public ComponentDataFromEntity<ANGCGFBDCKA> BGDALEFAJDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		[ReadOnly]
		public ComponentDataFromEntity<NIGPOFBMGGH> KNJHFEGOBNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		[WriteOnly]
		public NativeArray<BCHHHLKLMCP> KOBEFIHNBGH;

		[Cpp2IlInjected.Token(Token = "0x400071E")]
		private static readonly BCHHHLKLMCP MKIFMAJLKAC;

		[Cpp2IlInjected.Token(Token = "0x6000C13")]
		[Cpp2IlInjected.Address(RVA = "0x2229350", Offset = "0x2227B50", VA = "0x182229350", Slot = "4")]
		public void Execute(int AMOEKOMGDLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C14")]
		[Cpp2IlInjected.Address(RVA = "0x2229AD0", Offset = "0x22282D0", VA = "0x182229AD0")]
		private static float3 KGGANHFBAII(in float4x4 HGKBBAIIINB, in float3 HLLBMEGLPCK)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C15")]
		[Cpp2IlInjected.Address(RVA = "0x2229640", Offset = "0x2227E40", VA = "0x182229640")]
		private static float3 FHNICOGDAEM(in float4x4 HGKBBAIIINB, in float3 LDDOOGFOLKL)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0x2229BA0", Offset = "0x22283A0", VA = "0x182229BA0")]
		private static float3 OJEPNABAECG(in float4x4 HGKBBAIIINB, in float3 HLLBMEGLPCK)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C17")]
		[Cpp2IlInjected.Address(RVA = "0x2228B20", Offset = "0x2227320", VA = "0x182228B20")]
		private static float3 DFMEJOKMOOG(in float4x4 HGKBBAIIINB, in float3 LDDOOGFOLKL)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C18")]
		[Cpp2IlInjected.Address(RVA = "0x22297B0", Offset = "0x2227FB0", VA = "0x1822297B0")]
		private bool HMMODGCPECI(in float3 HPBBFNNBAFE, in float3 JJEDPBPHNPK, in NativeArray<Entity> GHBBODENMNP, out float3 AFJOMCLLIJA, out float3 LKJKFPNAKOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x2228CF0", Offset = "0x22274F0", VA = "0x182228CF0")]
		public static bool EKDFABNCMEG(in float3 DCAJDKAHMGC, in float3 IBBOLHDNGME, in float3 MJEFODDHFAO, in float3 EEAHNIAJIOI, float FHPHHPLEHDO, float FMDAJDAFCNM, out float CIIALCPCBIG, out float3 BHOCBFLFIBD)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000714")]
	private EntityManager EADLBIHJKBG;

	[Cpp2IlInjected.Token(Token = "0x6000C0F")]
	[Cpp2IlInjected.Address(RVA = "0x22BEBD0", Offset = "0x22BD3D0", VA = "0x1822BEBD0", Slot = "5")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C10")]
	[Cpp2IlInjected.Address(RVA = "0x22BE6E0", Offset = "0x22BCEE0", VA = "0x1822BE6E0")]
	public void EGANDJJHEIC(in NativeArray<Entity> KFLBCCAJFMN, in float3 HPBBFNNBAFE, in float3 JJEDPBPHNPK, in NativeArray<BCHHHLKLMCP> PPAKGEKLAHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C11")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public OPHELJPLNII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C12")]
	[Cpp2IlInjected.Address(RVA = "0x22BE6D0", Offset = "0x22BCED0", VA = "0x1822BE6D0", Slot = "4")]
	private void EELKNJKHKPH(in NativeArray<Entity> KFLBCCAJFMN, in float3 HPBBFNNBAFE, in float3 JJEDPBPHNPK, in NativeArray<BCHHHLKLMCP> PPAKGEKLAHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000228")]
[DefaultMember("Item")]
public struct IPJHNCNICKF<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400071F")]
	private T[] NFBDMLCENEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000720")]
	private int AKLMFDJHPFM;

	[Cpp2IlInjected.Token(Token = "0x6000C1B")]
	[Cpp2IlInjected.Address(RVA = "0x2864F30", Offset = "0x2863730", VA = "0x182864F30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000229")]
public struct FLNMMMIIPBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000721")]
	public Entity AJDEFAPHMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000722")]
	public Entity FNFODDOPDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000723")]
	public Entity ILLDOGNGNOD;

	[Cpp2IlInjected.Token(Token = "0x6000C1C")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B550", Offset = "0x2C79D50", VA = "0x182C7B550")]
	public FLNMMMIIPBM(Entity AJDEFAPHMKF, Entity FNFODDOPDHK, Entity ILLDOGNGNOD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000C1D")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B4F0", Offset = "0x2C79CF0", VA = "0x182C7B4F0")]
	public static FLNMMMIIPBM HFMFJLJFEMO((Entity entity, Entity oldParent, Entity newParent) CIFAHEMIKIH)
	{
		return default(FLNMMMIIPBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1E")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B530", Offset = "0x2C79D30", VA = "0x182C7B530")]
	public void LCNJHOAPLCH(out Entity AJDEFAPHMKF, out Entity FNFODDOPDHK, out Entity ILLDOGNGNOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022A")]
public class LOKLAHCNKPJ : NHLEGKPBPCC
{
	[Cpp2IlInjected.Token(Token = "0x4000724")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000725")]
	private EntityQuery EGFJCKOAGFH;

	[Cpp2IlInjected.Token(Token = "0x6000C1F")]
	[Cpp2IlInjected.Address(RVA = "0x29273B0", Offset = "0x2925BB0", VA = "0x1829273B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C20")]
	[Cpp2IlInjected.Address(RVA = "0x2927460", Offset = "0x2925C60", VA = "0x182927460", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C21")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public LOKLAHCNKPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022B")]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
internal class OLPOJKFPPCB : HHBLAKGBMFH<MNMDOJBLLKD>, NOFCHOCEBPC
{
	[Cpp2IlInjected.Token(Token = "0x4000726")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000727")]
	private HMBELPNBOEG LNJHNPCFKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000728")]
	private BEGAPFFEIJA KABEOEGJBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000729")]
	private EntityQuery FHHDDDPILIP;

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	private Entity PGKDFNPCPPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(RVA = "0x293DEA0", Offset = "0x293C6A0", VA = "0x18293DEA0")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000C24")]
		[Cpp2IlInjected.Address(RVA = "0x293DE40", Offset = "0x293C640", VA = "0x18293DE40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private Entity ABIMAFJPFLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000C25")]
		[Cpp2IlInjected.Address(RVA = "0x293E830", Offset = "0x293D030", VA = "0x18293E830")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public LPLJHAHPEEF LBLPKPNHFCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000C26")]
		[Cpp2IlInjected.Address(RVA = "0x293DDA0", Offset = "0x293C5A0", VA = "0x18293DDA0")]
		get
		{
			return default(LPLJHAHPEEF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000C27")]
		[Cpp2IlInjected.Address(RVA = "0x293E0D0", Offset = "0x293C8D0", VA = "0x18293E0D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public LPLJHAHPEEF IGCAOFJMNAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000C28")]
		[Cpp2IlInjected.Address(RVA = "0x293E790", Offset = "0x293CF90", VA = "0x18293E790")]
		get
		{
			return default(LPLJHAHPEEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C29")]
	[Cpp2IlInjected.Address(RVA = "0x293E890", Offset = "0x293D090", VA = "0x18293E890", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2A")]
	[Cpp2IlInjected.Address(RVA = "0x293E060", Offset = "0x293C860", VA = "0x18293E060", Slot = "15")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2B")]
	[Cpp2IlInjected.Address(RVA = "0x293E930", Offset = "0x293D130", VA = "0x18293E930", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2C")]
	[Cpp2IlInjected.Address(RVA = "0x293DF00", Offset = "0x293C700", VA = "0x18293DF00", Slot = "14")]
	protected override void HKAGKAAAMCN(NativeArray<Entity> KFLBCCAJFMN, NativeArray<Entity> OHPLMCMHCIP, NativeArray<Entity> LHDFKMLKNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2D")]
	[Cpp2IlInjected.Address(RVA = "0x293E6B0", Offset = "0x293CEB0", VA = "0x18293E6B0")]
	private void MPLBFIBBJLP(NativeArray<Entity> KFLBCCAJFMN, NativeArray<Entity> LHDFKMLKNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2E")]
	[Cpp2IlInjected.Address(RVA = "0x293E2D0", Offset = "0x293CAD0", VA = "0x18293E2D0")]
	private void MBFDLPJFNCO(Entity AJDEFAPHMKF, Entity ALDFKEOHFIO, Entity BJMMENDOGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2F")]
	[Cpp2IlInjected.Address(RVA = "0x2BFB7C0", Offset = "0x2BF9FC0", VA = "0x182BFB7C0")]
	private bool NOPGAJGAFLG<T>(out T MENBIMCLIOI) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C30")]
	[Cpp2IlInjected.Address(RVA = "0x2BFB700", Offset = "0x2BF9F00", VA = "0x182BFB700")]
	private void FJGENCPDJLK<T>(T MENBIMCLIOI) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C31")]
	[Cpp2IlInjected.Address(RVA = "0x293E180", Offset = "0x293C980", VA = "0x18293E180")]
	public bool LFBEEHFBEDF(LPLJHAHPEEF HNGLLINBCAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C32")]
	[Cpp2IlInjected.Address(RVA = "0x293E250", Offset = "0x293CA50", VA = "0x18293E250")]
	private static bool LLDJCJDDLMA(LPLJHAHPEEF LNLONADFCJG, LPLJHAHPEEF BIHANIGBOLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C33")]
	[Cpp2IlInjected.Address(RVA = "0x293EA40", Offset = "0x293D240", VA = "0x18293EA40")]
	public OLPOJKFPPCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022C")]
internal class HHHFIOEJIDJ : OJBJPKKIOND
{
	[Cpp2IlInjected.Token(Token = "0x17000145")]
	protected override DGHCNLKFLNE JAJKCIDCJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000C35")]
		[Cpp2IlInjected.Address(RVA = "0x24E7170", Offset = "0x24E5970", VA = "0x1824E7170", Slot = "15")]
		get
		{
			return default(DGHCNLKFLNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C36")]
	[Cpp2IlInjected.Address(RVA = "0x24E71F0", Offset = "0x24E59F0", VA = "0x1824E71F0")]
	public HHHFIOEJIDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022D")]
public class LCDEHJNDHMI : NHLEGKPBPCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400072A")]
	private EntityQuery FBPGLPCENEL;

	[Cpp2IlInjected.Token(Token = "0x6000C37")]
	[Cpp2IlInjected.Address(RVA = "0x291F340", Offset = "0x291DB40", VA = "0x18291F340", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C38")]
	[Cpp2IlInjected.Address(RVA = "0x291F3D0", Offset = "0x291DBD0", VA = "0x18291F3D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C39")]
	[Cpp2IlInjected.Address(RVA = "0x291F2F0", Offset = "0x291DAF0", VA = "0x18291F2F0")]
	private EntityCommandBufferSystem NGFKGOBBIDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3A")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public LCDEHJNDHMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022E")]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
internal sealed class LAPEJKNNNAG : GJJADNOGMIL
{
	[Cpp2IlInjected.Token(Token = "0x6000C3B")]
	[Cpp2IlInjected.Address(RVA = "0x291EC50", Offset = "0x291D450", VA = "0x18291EC50", Slot = "15")]
	protected override ComponentSystemBase CMFPJFIFJLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3C")]
	[Cpp2IlInjected.Address(RVA = "0x22BD2C0", Offset = "0x22BBAC0", VA = "0x1822BD2C0")]
	public LAPEJKNNNAG()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200022F")]
	[CompilerGenerated]
	public class PostLoadMoveRootsUnderParent : NHLEGKPBPCC
	{
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		private static readonly JNGNMMOLKFF log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0x22CE210", Offset = "0x22CCA10", VA = "0x1822CE210", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0x22CE2F0", Offset = "0x22CCAF0", VA = "0x1822CE2F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0x22CE050", Offset = "0x22CC850", VA = "0x1822CE050", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
		public PostLoadMoveRootsUnderParent()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000230")]
public struct EJDGNFKIJAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400072E")]
	public Entity AJDEFAPHMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400072F")]
	public Entity GJPBCFJDGCH;

	[Cpp2IlInjected.Token(Token = "0x6000C42")]
	[Cpp2IlInjected.Address(RVA = "0x1AAFBE0", Offset = "0x1AAE3E0", VA = "0x181AAFBE0")]
	public EJDGNFKIJAG(Entity AJDEFAPHMKF, Entity GJPBCFJDGCH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000C43")]
	[Cpp2IlInjected.Address(RVA = "0x2C741C0", Offset = "0x2C729C0", VA = "0x182C741C0")]
	public static EJDGNFKIJAG HFMFJLJFEMO((Entity entity, Entity parent) CIFAHEMIKIH)
	{
		return default(EJDGNFKIJAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C44")]
	[Cpp2IlInjected.Address(RVA = "0x2C741F0", Offset = "0x2C729F0", VA = "0x182C741F0")]
	public void LCNJHOAPLCH(out Entity AJDEFAPHMKF, out Entity GJPBCFJDGCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000231")]
[AlwaysUpdateSystem]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
public class PCNLOKGLOOI : NHLEGKPBPCC, NOFCHOCEBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000730")]
	[NAAJCOHOAKA]
	private PHBCFKHMBHC CCPLCKHAGJG;

	[Cpp2IlInjected.Token(Token = "0x6000C45")]
	[Cpp2IlInjected.Address(RVA = "0x22C01D0", Offset = "0x22BE9D0", VA = "0x1822C01D0", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C46")]
	[Cpp2IlInjected.Address(RVA = "0x22C0220", Offset = "0x22BEA20", VA = "0x1822C0220", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C47")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public PCNLOKGLOOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000232")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
[KHNAILLFHGJ(typeof(NAAOKPKOHFP), new string[] { })]
internal sealed class NAAOKPKOHFP : NOFCHOCEBPC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000731")]
	[NAAJCOHOAKA]
	private ILBBGIPPPPJ EJLFIBCCMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000732")]
	private EntityQuery GHCGCPGDCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000733")]
	private bool PMADFOMNIPK;

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	private EntityManager EOOAJAELBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000C48")]
		[Cpp2IlInjected.Address(RVA = "0x292C3F0", Offset = "0x292ABF0", VA = "0x18292C3F0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C49")]
	[Cpp2IlInjected.Address(RVA = "0x292C500", Offset = "0x292AD00", VA = "0x18292C500", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4A")]
	[Cpp2IlInjected.Address(RVA = "0x292C300", Offset = "0x292AB00", VA = "0x18292C300", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4B")]
	[Cpp2IlInjected.Address(RVA = "0x292C440", Offset = "0x292AC40", VA = "0x18292C440")]
	public bool IBBKINNCCLP(Entity AJDEFAPHMKF, Entity IKDGFEDODNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4C")]
	[Cpp2IlInjected.Address(RVA = "0x292C6B0", Offset = "0x292AEB0", VA = "0x18292C6B0")]
	public bool PGFPMKJEAKM(Entity AJDEFAPHMKF, Entity MPGGAHNCHOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4D")]
	[Cpp2IlInjected.Address(RVA = "0x292C600", Offset = "0x292AE00", VA = "0x18292C600")]
	public Entity MAPBPOGNGKF(Entity AJDEFAPHMKF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4E")]
	[Cpp2IlInjected.Address(RVA = "0x292C2B0", Offset = "0x292AAB0", VA = "0x18292C2B0")]
	public NativeArray<Entity> DFJCHFPPGHC()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4F")]
	[Cpp2IlInjected.Address(RVA = "0x292C320", Offset = "0x292AB20", VA = "0x18292C320")]
	public bool FOCFAPBPKCF(Entity MPGGAHNCHOK, Entity PGMGJHKACLK, out Entity PLFDJFKPNCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C50")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public NAAOKPKOHFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000233")]
internal interface NIPHPIANDBN
{
	[Cpp2IlInjected.Token(Token = "0x17000147")]
	World IHPDJPJEIBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	World IGCHJBGNJEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	BHCNLMFFMGM NJFHCINBFJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	uint EOFDFPDHALO
	{
		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	bool GKHBBLGCCAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000C56")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000234")]
	[CompilerGenerated]
	internal class PostDeserializeAddSplinePointsToSplines : NHLEGKPBPCC
	{
		[Cpp2IlInjected.Token(Token = "0x2000235")]
		[BurstCompile]
		[NoAlias]
		private struct PostDeserializeAddSplinePointsToSplines_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000738")]
			public EntityCommandBuffer cb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000739")]
			[ReadOnly]
			public EntityTypeHandle __splineTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000C5E")]
			[Cpp2IlInjected.Address(RVA = "0x2238020", Offset = "0x2236820", VA = "0x182238020")]
			private void BNHOJHOEIPF(Entity spline)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C5F")]
			[Cpp2IlInjected.Address(RVA = "0x22380B0", Offset = "0x22368B0", VA = "0x1822380B0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000236")]
		[NoAlias]
		[BurstCompile]
		private struct PostDeserializeAddSplinePointsToSplines_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400073A")]
			public EntityCommandBuffer cb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400073B")]
			[ReadOnly]
			public EntityTypeHandle __splinePointTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400073C")]
			[ReadOnly]
			public ComponentTypeHandle<NLLEHLHFEHG> __splinePointParentDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000C60")]
			[Cpp2IlInjected.Address(RVA = "0x2238160", Offset = "0x2236960", VA = "0x182238160")]
			private void BNHOJHOEIPF(Entity splinePoint, [NoAlias] in NLLEHLHFEHG splinePointParentData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C61")]
			[Cpp2IlInjected.Address(RVA = "0x22381F0", Offset = "0x22369F0", VA = "0x1822381F0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		private EntityQuery PostDeserializeAddSplinePointsToSplines_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		private EntityQuery PostDeserializeAddSplinePointsToSplines_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000737")]
		private ComponentTypeHandle<NLLEHLHFEHG> __RecRoom_Components_SplinePointParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000C57")]
		[Cpp2IlInjected.Address(RVA = "0x22C74E0", Offset = "0x22C5CE0", VA = "0x1822C74E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(RVA = "0x22C7590", Offset = "0x22C5D90", VA = "0x1822C7590", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(RVA = "0x22C7140", Offset = "0x22C5940", VA = "0x1822C7140")]
		private EntityCommandBufferSystem EFIPACDBNFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5A")]
		[Cpp2IlInjected.Address(RVA = "0x22C6EF0", Offset = "0x22C56F0", VA = "0x1822C6EF0")]
		private void BBJGILKDKPG(EntityCommandBuffer cb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5B")]
		[Cpp2IlInjected.Address(RVA = "0x22C6FF0", Offset = "0x22C57F0", VA = "0x1822C6FF0")]
		private void CFHBBFMDAED(EntityCommandBuffer cb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5C")]
		[Cpp2IlInjected.Address(RVA = "0x22C7190", Offset = "0x22C5990", VA = "0x1822C7190", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5D")]
		[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
		public PostDeserializeAddSplinePointsToSplines()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000237")]
	[AlwaysUpdateSystem]
	[CompilerGenerated]
	[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
	public class UpdateSplineGameCollidersSystem : NHLEGKPBPCC, NOFCHOCEBPC
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000238")]
		public struct SplineGameCollisionSystemTag : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000239")]
		private struct ProcessCollisionModeChangesForSplineGameCollision_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400074A")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400074B")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400074C")]
			[ReadOnly]
			public ComponentDataFromEntity<CBIEAPMGLPL> splineComponentAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400074D")]
			[ReadOnly]
			public ComponentDataFromEntity<SplineGameCollisionSystemTag> systemStateAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400074E")]
			[ReadOnly]
			public ComponentTypeHandle<HMJCDHFLPNL> __collisionModeTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x400074F")]
			public BufferTypeHandle<OEOKFMKAJDD> __childrenTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000C70")]
			[Cpp2IlInjected.Address(RVA = "0x601E4B0", Offset = "0x601CCB0", VA = "0x18601E4B0")]
			private void BNHOJHOEIPF(in HMJCDHFLPNL collisionMode, DynamicBuffer<OEOKFMKAJDD> children)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C71")]
			[Cpp2IlInjected.Address(RVA = "0x601E800", Offset = "0x601D000", VA = "0x18601E800", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200023A")]
		private struct ProcessActiveSplineReparentsForGameCollision_Job : IJobEntityBatch
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
			public ComponentDataFromEntity<HMJCDHFLPNL> containerCollisionModeAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000753")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000754")]
			[ReadOnly]
			public ComponentTypeHandle<OEKNEICFKDA> __parentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000C72")]
			[Cpp2IlInjected.Address(RVA = "0x601E2D0", Offset = "0x601CAD0", VA = "0x18601E2D0")]
			private void BNHOJHOEIPF(Entity entity, in OEKNEICFKDA parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C73")]
			[Cpp2IlInjected.Address(RVA = "0x601E390", Offset = "0x601CB90", VA = "0x18601E390", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200023B")]
		private struct ProcessInactiveSplineReparentsForGameCollision_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000755")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000756")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000757")]
			[ReadOnly]
			public ComponentDataFromEntity<HMJCDHFLPNL> containerCollisionModeAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000758")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000759")]
			[ReadOnly]
			public ComponentTypeHandle<OEKNEICFKDA> __parentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000C74")]
			[Cpp2IlInjected.Address(RVA = "0x601E970", Offset = "0x601D170", VA = "0x18601E970")]
			private void BNHOJHOEIPF(Entity entity, in OEKNEICFKDA parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C75")]
			[Cpp2IlInjected.Address(RVA = "0x601EA20", Offset = "0x601D220", VA = "0x18601EA20", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200023C")]
		private struct UpdateSplineGameCollidersSystem_LambdaJob_3_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400075A")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400075B")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400075C")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000C76")]
			[Cpp2IlInjected.Address(RVA = "0x6022910", Offset = "0x6021110", VA = "0x186022910")]
			private void BNHOJHOEIPF(Entity entity)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C77")]
			[Cpp2IlInjected.Address(RVA = "0x6022990", Offset = "0x6021190", VA = "0x186022990", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200023D")]
		private struct ProcessSplineEditsForGameCollision_Job : IJob
		{
			[Cpp2IlInjected.Token(Token = "0x400075D")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400075E")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400075F")]
			[ReadOnly]
			public ComponentTypeHandle<NLLEHLHFEHG> splinePointParentHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000760")]
			[ReadOnly]
			public EntityTypeHandle entityHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000761")]
			[ReadOnly]
			public ComponentDataFromEntity<SplineGameCollisionSystemTag> systemTagAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000762")]
			public EntityQueryInJob splinePointEditedQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000763")]
			public EntityQueryInJob splineStructureChangedQueryInJob;

			[Cpp2IlInjected.Token(Token = "0x6000C78")]
			[Cpp2IlInjected.Address(RVA = "0x601EBA0", Offset = "0x601D3A0", VA = "0x18601EBA0")]
			private void BNHOJHOEIPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C79")]
			[Cpp2IlInjected.Address(RVA = "0x601F110", Offset = "0x601D910", VA = "0x18601F110", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C7A")]
			[Cpp2IlInjected.Address(RVA = "0x601EB40", Offset = "0x601D340", VA = "0x18601EB40")]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void AABEEOLFMKP(IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		private ALFHDLJDEIN splineCollisionService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		private EntityQuery collisionModeChangeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		private EntityQuery activeSplineReparentedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		private EntityQuery inactiveSplineReparentedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		private EntityQuery splinePointEditedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		private EntityQuery splineStructureChangedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		private EntityQuery splinesDeletedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		private EntityQuery ProcessCollisionModeChangesForSplineGameCollision_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		private EntityQuery ProcessActiveSplineReparentsForGameCollision_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		private EntityQuery ProcessInactiveSplineReparentsForGameCollision_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000747")]
		private EntityQuery UpdateSplineGameCollidersSystem_LambdaJob_3_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		private ComponentTypeHandle<HMJCDHFLPNL> __RecRoom_Components_ContainerCollisionModeData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000749")]
		private ComponentTypeHandle<OEKNEICFKDA> __RecRoom_Components_ParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000C62")]
		[Cpp2IlInjected.Address(RVA = "0x22DAD10", Offset = "0x22D9510", VA = "0x1822DAD10", Slot = "14")]
		public void InitReferences(NCFCHDEHMHC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C63")]
		[Cpp2IlInjected.Address(RVA = "0x22DBE10", Offset = "0x22DA610", VA = "0x1822DBE10", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C64")]
		[Cpp2IlInjected.Address(RVA = "0x22DBFE0", Offset = "0x22DA7E0", VA = "0x1822DBFE0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C65")]
		[Cpp2IlInjected.Address(RVA = "0x22DB340", Offset = "0x22D9B40", VA = "0x1822DB340")]
		private void NOIABOBFPKM(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C66")]
		[Cpp2IlInjected.Address(RVA = "0x22DB080", Offset = "0x22D9880", VA = "0x1822DB080")]
		private void MPNPALHMKCG(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C67")]
		[Cpp2IlInjected.Address(RVA = "0x22DAB60", Offset = "0x22D9360", VA = "0x1822DAB60")]
		private void IMFJBLOIMFD(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C68")]
		[Cpp2IlInjected.Address(RVA = "0x22DAF90", Offset = "0x22D9790", VA = "0x1822DAF90")]
		private void MCCHKIFOBKD(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C69")]
		[Cpp2IlInjected.Address(RVA = "0x22DA970", Offset = "0x22D9170", VA = "0x1822DA970")]
		private void FEJPEHHBJDM(ref EntityCommandBuffer ecb, ref ComponentDataFromEntity<CBIEAPMGLPL> splineComponentAccess, ref ComponentDataFromEntity<SplineGameCollisionSystemTag> systemStateAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6A")]
		[Cpp2IlInjected.Address(RVA = "0x22DA800", Offset = "0x22D9000", VA = "0x1822DA800")]
		private void DPAOEAPKOFN(ref EntityCommandBuffer ecb, ref ComponentDataFromEntity<HMJCDHFLPNL> containerCollisionModeAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(RVA = "0x22DA690", Offset = "0x22D8E90", VA = "0x1822DA690")]
		private void ACDKIDMLBLG(ref EntityCommandBuffer ecb, ref ComponentDataFromEntity<HMJCDHFLPNL> containerCollisionModeAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6C")]
		[Cpp2IlInjected.Address(RVA = "0x22DAD60", Offset = "0x22D9560", VA = "0x1822DAD60")]
		private void JFEGDHICFBI(ref EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6D")]
		[Cpp2IlInjected.Address(RVA = "0x22DAE50", Offset = "0x22D9650", VA = "0x1822DAE50")]
		private void LLKIOLNNAEB(ref ComponentTypeHandle<NLLEHLHFEHG> splinePointParentHandle, ref EntityTypeHandle entityHandle, ref ComponentDataFromEntity<SplineGameCollisionSystemTag> systemTagAccess, ref EntityQueryInJob splinePointEditedQueryInJob, ref EntityQueryInJob splineStructureChangedQueryInJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0x22DB560", Offset = "0x22D9D60", VA = "0x1822DB560", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
		public UpdateSplineGameCollidersSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200023E")]
public sealed class GPKGNICAOLP : GJJADNOGMIL
{
	[Cpp2IlInjected.Token(Token = "0x6000C7B")]
	[Cpp2IlInjected.Address(RVA = "0x2C83940", Offset = "0x2C82140", VA = "0x182C83940", Slot = "15")]
	protected override ComponentSystemBase CMFPJFIFJLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7C")]
	[Cpp2IlInjected.Address(RVA = "0x22BD2C0", Offset = "0x22BBAC0", VA = "0x1822BD2C0")]
	public GPKGNICAOLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200023F")]
[ExecuteAlways]
public class EAGPCBALBGH : BBADPFDDMLN
{
	[Cpp2IlInjected.Token(Token = "0x6000C7D")]
	[Cpp2IlInjected.Address(RVA = "0x97A870", Offset = "0x979070", VA = "0x18097A870")]
	public EAGPCBALBGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000240")]
public sealed class LPLKBKHJNFO : GJJADNOGMIL
{
	[Cpp2IlInjected.Token(Token = "0x6000C7E")]
	[Cpp2IlInjected.Address(RVA = "0x29297E0", Offset = "0x2927FE0", VA = "0x1829297E0", Slot = "15")]
	protected override ComponentSystemBase CMFPJFIFJLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7F")]
	[Cpp2IlInjected.Address(RVA = "0x22BD2C0", Offset = "0x22BBAC0", VA = "0x1822BD2C0")]
	public LPLKBKHJNFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000241")]
public class OBANAAFCLON : JKEMFGGLHGI, NOFCHOCEBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000764")]
	private GJCOMGMOGCM LJAHGKLIMIM;

	[Cpp2IlInjected.Token(Token = "0x6000C80")]
	[Cpp2IlInjected.Address(RVA = "0x2939FF0", Offset = "0x29387F0", VA = "0x182939FF0", Slot = "14")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C81")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C82")]
	[Cpp2IlInjected.Address(RVA = "0x22BCE30", Offset = "0x22BB630", VA = "0x1822BCE30")]
	public OBANAAFCLON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000242")]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
internal sealed class MHPMDJCBNKP : GJJADNOGMIL
{
	[Cpp2IlInjected.Token(Token = "0x6000C83")]
	[Cpp2IlInjected.Address(RVA = "0x292B620", Offset = "0x2929E20", VA = "0x18292B620", Slot = "15")]
	protected override ComponentSystemBase CMFPJFIFJLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C84")]
	[Cpp2IlInjected.Address(RVA = "0x22BD2C0", Offset = "0x22BBAC0", VA = "0x1822BD2C0")]
	public MHPMDJCBNKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000243")]
internal class LMELFJDJDAH : PEPJPPPDFOK
{
	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	protected override HPOKAOBOIJC KKFMLANCONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000C85")]
		[Cpp2IlInjected.Address(RVA = "0x892A20", Offset = "0x891220", VA = "0x180892A20", Slot = "17")]
		get
		{
			return default(HPOKAOBOIJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C86")]
	[Cpp2IlInjected.Address(RVA = "0x2926F10", Offset = "0x2925710", VA = "0x182926F10")]
	public LMELFJDJDAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000244")]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
public sealed class DGLJDKDNPFB : GJJADNOGMIL
{
	[Cpp2IlInjected.Token(Token = "0x6000C87")]
	[Cpp2IlInjected.Address(RVA = "0x2C699B0", Offset = "0x2C681B0", VA = "0x182C699B0", Slot = "15")]
	protected override ComponentSystemBase CMFPJFIFJLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C88")]
	[Cpp2IlInjected.Address(RVA = "0x22BD2C0", Offset = "0x22BBAC0", VA = "0x1822BD2C0")]
	public DGLJDKDNPFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000245")]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
internal sealed class PPEBGGIDKBL : GJJADNOGMIL
{
	[Cpp2IlInjected.Token(Token = "0x6000C89")]
	[Cpp2IlInjected.Address(RVA = "0x22C2180", Offset = "0x22C0980", VA = "0x1822C2180", Slot = "15")]
	protected override ComponentSystemBase CMFPJFIFJLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C8A")]
	[Cpp2IlInjected.Address(RVA = "0x22BD2C0", Offset = "0x22BBAC0", VA = "0x1822BD2C0")]
	public PPEBGGIDKBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000246")]
[IIOLMGNHMOA(typeof(PMHMNKDEJIA))]
public sealed class LBJKDNLOHJB : POKNEELFHFC
{
	[Cpp2IlInjected.Token(Token = "0x6000C8B")]
	[Cpp2IlInjected.Address(RVA = "0x291F1A0", Offset = "0x291D9A0", VA = "0x18291F1A0", Slot = "8")]
	protected override bool GJCFBLICDIP(ReadOnlySpan<PMHMNKDEJIA> BODGCAEFMPH, NGDOIACAINC IALCMDCBOGJ, out ReadOnlySpan<byte> BLAINNBNMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C8C")]
	[Cpp2IlInjected.Address(RVA = "0x291F220", Offset = "0x291DA20", VA = "0x18291F220", Slot = "9")]
	protected override bool NHPFIHINGCM(int MNJCDKNLLPF, Span<PMHMNKDEJIA> BODGCAEFMPH, in ReadOnlySpan<byte> BLAINNBNMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C8D")]
	[Cpp2IlInjected.Address(RVA = "0x291F2E0", Offset = "0x291DAE0", VA = "0x18291F2E0")]
	public LBJKDNLOHJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000247")]
[IIOLMGNHMOA(typeof(BLOFFPDIILE))]
public sealed class KJKMCJIBHNE : JDCAPKBDAOF
{
	[Cpp2IlInjected.Token(Token = "0x6000C8E")]
	[Cpp2IlInjected.Address(RVA = "0x24FE0D0", Offset = "0x24FC8D0", VA = "0x1824FE0D0", Slot = "8")]
	protected override bool GJCFBLICDIP(ReadOnlySpan<BLOFFPDIILE> BODGCAEFMPH, NGDOIACAINC IALCMDCBOGJ, out ReadOnlySpan<byte> BLAINNBNMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C8F")]
	[Cpp2IlInjected.Address(RVA = "0x24FE150", Offset = "0x24FC950", VA = "0x1824FE150", Slot = "9")]
	protected override bool NHPFIHINGCM(int MNJCDKNLLPF, Span<BLOFFPDIILE> BODGCAEFMPH, in ReadOnlySpan<byte> BLAINNBNMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C90")]
	[Cpp2IlInjected.Address(RVA = "0x24FE210", Offset = "0x24FCA10", VA = "0x1824FE210")]
	public KJKMCJIBHNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000248")]
[KAPPDMKCEOO(JLEAEANKKDG.LoadInstance)]
internal sealed class FJKEEAJAFJG : GJJADNOGMIL
{
	[Cpp2IlInjected.Token(Token = "0x6000C91")]
	[Cpp2IlInjected.Address(RVA = "0x2C799C0", Offset = "0x2C781C0", VA = "0x182C799C0", Slot = "15")]
	protected override ComponentSystemBase CMFPJFIFJLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C92")]
	[Cpp2IlInjected.Address(RVA = "0x22BD2C0", Offset = "0x22BBAC0", VA = "0x1822BD2C0")]
	public FJKEEAJAFJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000249")]
internal class KEIOGOGGHHB : HEGFKOOIJBF
{
	[Cpp2IlInjected.Token(Token = "0x6000C93")]
	[Cpp2IlInjected.Address(RVA = "0x22BD2C0", Offset = "0x22BBAC0", VA = "0x1822BD2C0")]
	public KEIOGOGGHHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024A")]
[KHNAILLFHGJ(typeof(HEJFCJDGGFG), new string[] { })]
public sealed class NEDFMMMGALK : HEJFCJDGGFG, NOFCHOCEBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000765")]
	private PCMJCEALPLG MJMFLCKALLM;

	[Cpp2IlInjected.Token(Token = "0x6000C94")]
	[Cpp2IlInjected.Address(RVA = "0x292F4E0", Offset = "0x292DCE0", VA = "0x18292F4E0", Slot = "5")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C95")]
	[Cpp2IlInjected.Address(RVA = "0x292F400", Offset = "0x292DC00", VA = "0x18292F400")]
	public bool EGANDJJHEIC(in float3 HPBBFNNBAFE, in float3 JJEDPBPHNPK, float BJICICOAOBE, Allocator HMGEFCKKBID, out NativeArray<Entity> KFLBCCAJFMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C96")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public NEDFMMMGALK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C97")]
	[Cpp2IlInjected.Address(RVA = "0x292F400", Offset = "0x292DC00", VA = "0x18292F400", Slot = "4")]
	private bool MBOCEGJDCKP(in float3 HPBBFNNBAFE, in float3 JJEDPBPHNPK, float BJICICOAOBE, Allocator HMGEFCKKBID, out NativeArray<Entity> KFLBCCAJFMN)
	{
		return default(bool);
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200024B")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : BBDIJCIAOKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000C98")]
		[Cpp2IlInjected.Address(RVA = "0x7E01F0", Offset = "0x7DE9F0", VA = "0x1807E01F0")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C99")]
		[Cpp2IlInjected.Address(RVA = "0x223AC60", Offset = "0x2239460", VA = "0x18223AC60", Slot = "6")]
		public sealed override void CJHJKHMBMOJ(DCJCPNPABDN JJFOLBCEJBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9A")]
		[Cpp2IlInjected.Address(RVA = "0x223BDA0", Offset = "0x223A5A0", VA = "0x18223BDA0", Slot = "4")]
		public sealed override void NFAIEHMBJOE()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200024C")]
internal class __UnmanagedPostProcessorOutput__3051310927
{
	[Cpp2IlInjected.Token(Token = "0x6000C9B")]
	[Cpp2IlInjected.Address(RVA = "0x223D5E0", Offset = "0x223BDE0", VA = "0x18223D5E0")]
	[RuntimeInitializeOnLoadMethod]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024D")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3051310927
{
	[Cpp2IlInjected.Token(Token = "0x6000C9C")]
	[Cpp2IlInjected.Address(RVA = "0x223BFB0", Offset = "0x223A7B0", VA = "0x18223BFB0")]
	public static void NPMJPABCHFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9D")]
	[Cpp2IlInjected.Address(RVA = "0x223BFA0", Offset = "0x223A7A0", VA = "0x18223BFA0")]
	[RuntimeInitializeOnLoadMethod]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024E")]
internal class HPOGILDECIB : ContainerPropertyBag<FBINHHLEGLD>
{
	[Cpp2IlInjected.Token(Token = "0x200024F")]
	private class NFKAGEOIGEE : Property<FBINHHLEGLD, FKKNGLCNOFO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		public override string EHNKIECOKGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000C9F")]
			[Cpp2IlInjected.Address(RVA = "0x22358B0", Offset = "0x22340B0", VA = "0x1822358B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public override bool OAJKOPLILBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA0")]
			[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA1")]
		[Cpp2IlInjected.Address(RVA = "0x2235870", Offset = "0x2234070", VA = "0x182235870")]
		public NFKAGEOIGEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA2")]
		[Cpp2IlInjected.Address(RVA = "0x2235820", Offset = "0x2234020", VA = "0x182235820", Slot = "14")]
		public override FKKNGLCNOFO GetValue(ref FBINHHLEGLD KEMGJJIKGPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA3")]
		[Cpp2IlInjected.Address(RVA = "0x2235840", Offset = "0x2234040", VA = "0x182235840", Slot = "15")]
		public override void SetValue(ref FBINHHLEGLD KEMGJJIKGPJ, FKKNGLCNOFO MENBIMCLIOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9E")]
	[Cpp2IlInjected.Address(RVA = "0x24E89A0", Offset = "0x24E71A0", VA = "0x1824E89A0")]
	public HPOGILDECIB()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000250")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000CA4")]
		[Cpp2IlInjected.Address(RVA = "0x22D0EB0", Offset = "0x22CF6B0", VA = "0x1822D0EB0")]
		[RuntimeInitializeOnLoadMethod]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000251")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000CA5")]
	[Cpp2IlInjected.Address(RVA = "0x28AE210", Offset = "0x28ACA10", VA = "0x1828AE210")]
	[RuntimeInitializeOnLoadMethod]
	private static void Initialize()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000252")]
public class PGBKCKFKJGL
{
	[Cpp2IlInjected.Token(Token = "0x6000CA6")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public PGBKCKFKJGL()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000253")]
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
