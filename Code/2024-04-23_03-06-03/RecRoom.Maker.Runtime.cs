using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CodeStage.AntiCheat.ObscuredTypes;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom.Core.Creation;
using Unity.Profiling;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class ConfigurableSubpiece : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private Collider[] colliders;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private Renderer[] hoverRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public FBOECCOHABO<ConfigurableSubpiece, Collider[], Collider[]> OnCollidersChanged;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public CMEHOPIEHJP GNNOGPKKGCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7C5860", Offset = "0x7C4860", VA = "0x1807C5860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7C5840", Offset = "0x7C4840", VA = "0x1807C5840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Collider[] HJDABBHBCGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Renderer[] GNPEGLKMLMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7C2D60", Offset = "0x7C1D60", VA = "0x1807C2D60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<CMEHOPIEHJP> GDANCNLKADP
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x62EFA60", Offset = "0x62EEA60", VA = "0x1862EFA60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x62EFB10", Offset = "0x62EEB10", VA = "0x1862EFB10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x62EF6F0", Offset = "0x62EE6F0", VA = "0x1862EF6F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x62EF7A0", Offset = "0x62EE7A0", VA = "0x1862EF7A0")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x62EF810", Offset = "0x62EE810", VA = "0x1862EF810")]
		public void SetIConfigurable(CMEHOPIEHJP GCNGNAEMBHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x62EF700", Offset = "0x62EE700", VA = "0x1862EF700")]
		public void ChangeCollidersAndRenderers(Collider[] HFLOIJLKEOO, Renderer[] NPDPGPMIKKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x62EF940", Offset = "0x62EE940", VA = "0x1862EF940")]
		public void ValidateCollidersAndRenderers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x62EF7F0", Offset = "0x62EE7F0", VA = "0x1862EF7F0")]
		public void RunConfigurationSpecialActions(CMEHOPIEHJP IGMGFHHDHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x62EF9D0", Offset = "0x62EE9D0", VA = "0x1862EF9D0")]
		public ConfigurableSubpiece()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LJGOJHIBHCD
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BOLKPPFMFDE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddIsAnimated(object KONODCHOCOG);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveIsAnimated(object KONODCHOCOG);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LCELOGLLGJM
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RegisterConfigurablePiece(ConfigurableSubpiece IIPBEKIBIJF);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void UnregisterConfigurablePiece(ConfigurableSubpiece IIPBEKIBIJF);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ConfigurableSubpiece GetConfigurableSubpiece(Collider MDIOCJFNBPC);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EDEHKKJCEFP
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	GameObject GJCLDNHCHFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Guid HAJEKOIDKJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string FJOKHGLGEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string KEFGFGLPACE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Vector3 MBMPBKDBNKA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Vector3 OBJFNILBNAE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Quaternion LAKOFGKCADA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Quaternion KFGIAIMBKPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float LOCPNBPMDDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float NHENDHLPPAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "16")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Vector3 DDIBGADCGJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Vector3 JFHOFNKBFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool GFCDNFKDHAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "20")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	CMEHOPIEHJP GNNOGPKKGCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	IMBFGGOFHBM HPCCFHJNAJH
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action DPCJHPIOMKC;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool CanUpdateDeformation(Vector3 NLOFDEBNMHB, float OANHLKHMPCJ, float MHILEPHFDMO);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void UpdateDeformation(Vector3 NLOFDEBNMHB, float OANHLKHMPCJ, bool HOFDPCFOGLF, Space GIJIFHPHGCH);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool CanBeRaycasted(Collider MDIOCJFNBPC);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface GMOPJPDCGLO
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool GLHILCPIAEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool KOEJHODBBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Vector3 NEAINOGCAKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Vector3 DBEKLJFHHEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool KNAHMJGBJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool HIJJDBHJBGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool LCJFABGBGLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool ADKGDIKLHDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool IPHJBNCAOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool DEHKMNNGNON
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedBySpawning();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelected();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnTranslationStart();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OnRotationStart();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OnScaleStart();

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OnDeformStart();

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnTranslated();

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnRotated();

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnScaled();

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OnDeformed(Vector3 MIGHOEEMDAI);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OnTranslationFinished();

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OnRotationFinished();

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OnScaleFinished();

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OnDeformationFinished();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OnDeselected();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OnHoverStart(COCPKEFGEBC MPEALPEKKLN, Collider GFBONKEMLBC);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OnHovering(COCPKEFGEBC MPEALPEKKLN, Collider GFBONKEMLBC);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OnHoverFinished(COCPKEFGEBC MPEALPEKKLN);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void Translate(Vector3 GMGFCCJJPDI);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void Rotate(Quaternion NACPMFHBDFI);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool Scale(float FOHBFABOGNJ);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Task DeleteAsync();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BIIIDGIAHHI
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EECIPJMGGFG([In] Vector3 OHFPFGNFPGI, [In] Vector3 PFFNCAKFCDH, Vector3 NKPFABFBCKD, Vector3 KMBEHGBELJC);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface HNMAGMMOCLE
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool LDAFMNFFDBH
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	EEABDCAPAGK OPOLDPHHLKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MasterDespawn();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task RequestMasterDespawn();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IPDDOPNBEOD
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool FJOEHFBMBID
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	MDPIFMNPFHG CMMPCKPFKMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<bool> CEPIMDMFBEP;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LocalPlayerTakeAuthority();

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void TransferOwnership(int FJPDKJLPKNL);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GFJGICKLIKH GetCulprit(IBNHNBGBCNP GBELHICMEOH);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HCLLFINCLKL
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	IEnumerable<LGANCCEFNFJ.MLMBHNAPNAA> MPAIMGIEANB
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddNavMeshSupportRestriction(LGANCCEFNFJ.MLMBHNAPNAA DJPMAACNIJE);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveNavMeshSupportRestriction(LGANCCEFNFJ.MLMBHNAPNAA DJPMAACNIJE);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DACDEEMFJCA
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Reset();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BFEALHPPNEN
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool GAJEHPMJGIA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool FFGAPPOFKIA
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EJPNNGKOGPF
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int JDLMPAIPGHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderSelection(LFIEDIGFABH? FMLCCLILCIH);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderOutline(MKFOLIFJABD? AHFIKOMACCN);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void RenderWorldFadeMask();

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Bounds GetWorldBounds();

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IBNHNBGBCNP CanBeSelected();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface AFELBIDOIOH
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool DBJBHFINHMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CostInfo KAFEPGLNPLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool EBCIFIPMEMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool PBJHABGGFNN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool OODBAKJDBBF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool CMENBLFHJFH
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool EGPMODJOAPK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	IEnumerable<Collider> CHMKKKBIIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	BMECIAJCEAM? DNDILFDEJBF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool OFCLDHBKJCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool JIMFAFEOLKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LDGPOKPDOEH
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IBNHNBGBCNP CanPerformUndoRedoOnObject();

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GetTransformationDataForUndoRedo([Out] Vector3 BJIKBOECFPB, [Out] Quaternion CKCOAEGKOKA, [Out] float FDOKALIJFPE, [Out] Vector3 AIBMJLNNEEJ);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetTransformationDataForUndoRedo(Vector3? BJIKBOECFPB, Quaternion? CKCOAEGKOKA, float? FDOKALIJFPE, Vector3? AIBMJLNNEEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface MJEPDOAKDCA
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	object PNPGNKEGMJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Type HCDGLEAPJAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	Guid GOHCFCJGMJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface CMEHOPIEHJP
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	IReadOnlyList<LLINAOBDCMD> MPMHKMIOJBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string KEFGFGLPACE
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string BDPMLIHKBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool JAKHALGPHHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<string> LAGBKHAEINN;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<CMEHOPIEHJP> LEIHJJELMDF;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<KGOPPLKIDKP, PDGOOJNCJMM> MFHCHEFHPHO;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action HIGGFENBLND;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void Reset();

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ConfigurableWillShow();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ConfigurableWillHide();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface JBGJONEOLDA
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool DHJPNINGJFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct LGANCCEFNFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate LLCIMFBHGNF MLMBHNAPNAA();

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IEnumerable<MLMBHNAPNAA> OADCBJDEAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<MLMBHNAPNAA> OPMOONFJAGL;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public IEnumerable<MLMBHNAPNAA> AKGKIIKLFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x62F3010", Offset = "0x62F2010", VA = "0x1862F3010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x62F2E60", Offset = "0x62F1E60", VA = "0x1862F2E60")]
	public void BGLDHBEBEIE(MLMBHNAPNAA DJPMAACNIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x62F3070", Offset = "0x62F2070", VA = "0x1862F3070")]
	public bool NCLCGNJGAKA(MLMBHNAPNAA DJPMAACNIJE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum LLCIMFBHGNF
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	NotSupported,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Supported
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class IMBFGGOFHBM
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public const int PNEPFJFNJON = -1;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public const long PDNBABEHIHJ = -1L;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private MIEMAMMJGBG<Guid, ObscuredLong, ObscuredInt, ObscuredBool> DHDMNCNPKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private GAHIOKGMJHA<ObscuredBool, ObscuredInt, ObscuredInt> AKIHCEFGPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private MonoBehaviourPun MMCALBDPLAH;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Guid KECMONONMHA
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x62EFF90", Offset = "0x62EEF90", VA = "0x1862EFF90")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public long FAGAIKMEGOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x62F0930", Offset = "0x62EF930", VA = "0x1862F0930")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int BJENNKJHIDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x62F08A0", Offset = "0x62EF8A0", VA = "0x1862F08A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool GIAGLIIEIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x62F0590", Offset = "0x62EF590", VA = "0x1862F0590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool OFCCHIJKBBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x62F0690", Offset = "0x62EF690", VA = "0x1862F0690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int FOEHEHGNCLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x62F0500", Offset = "0x62EF500", VA = "0x1862F0500")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int EIBMLDHOBPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x62F0720", Offset = "0x62EF720", VA = "0x1862F0720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool MANNLKJJGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x62F07B0", Offset = "0x62EF7B0", VA = "0x1862F07B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x62F09D0", Offset = "0x62EF9D0", VA = "0x1862F09D0")]
	public IMBFGGOFHBM(MonoBehaviourPun LOABNOJEKDB, string OGMFNIEGALD, Guid MMMMFCHNANJ, long ECEDJNJGOAP, int JPBGKCHOLKH, bool IKEDNCDCMII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x62F02A0", Offset = "0x62EF2A0", VA = "0x1862F02A0")]
	public void CKAFLFPDLNE(GFJGICKLIKH EPKCIPKGDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x62EFE80", Offset = "0x62EEE80", VA = "0x1862EFE80")]
	public void BLBAGOPAKMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x62F00D0", Offset = "0x62EF0D0", VA = "0x1862F00D0")]
	public void CJMKLAKCCOG(Guid IPIHEFBGAPN, long ECEDJNJGOAP, int JPBGKCHOLKH, bool IKEDNCDCMII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x62F0000", Offset = "0x62EF000", VA = "0x1862F0000")]
	public void CJMKLAKCCOG(IMBFGGOFHBM JNHFAFOIKEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x62F0620", Offset = "0x62EF620", VA = "0x1862F0620")]
	public void GFCLNIOALIC(JHHNEGDCEPB GPKMLHOONCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x62F07F0", Offset = "0x62EF7F0", VA = "0x1862F07F0")]
	public void OBEONBEBPMI(JHHNEGDCEPB GPKMLHOONCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x62F0440", Offset = "0x62EF440", VA = "0x1862F0440")]
	public static JHHNEGDCEPB DIIMADLCMMC(Guid MMMMFCHNANJ, long ECEDJNJGOAP, int LKIBHGBKOHN, bool IKEDNCDCMII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class FABLDDPMEDK
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static MIADACEFMCK<Vector3> MECELBIEBJC;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static MIADACEFMCK<Vector3> JLNNIBMIAMH;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x62EFBC0", Offset = "0x62EEBC0", VA = "0x1862EFBC0", Slot = "4")]
	protected virtual void FODLLKFKDDP(Vector3 FBGFABMEODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x62EFC50", Offset = "0x62EEC50", VA = "0x1862EFC50", Slot = "5")]
	protected virtual void KIPCKAKHGGD(Vector3 FBGFABMEODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	protected FABLDDPMEDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class FGDJGMEALBC : FABLDDPMEDK
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x62EFE00", Offset = "0x62EEE00", VA = "0x1862EFE00")]
	public void PEJADDPOOAN(Vector3 BJIKBOECFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x62EFDD0", Offset = "0x62EEDD0", VA = "0x1862EFDD0")]
	public void LMBIICFIKJI(Vector3 BJIKBOECFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x62EFE30", Offset = "0x62EEE30", VA = "0x1862EFE30")]
	public FGDJGMEALBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class JMADOOKGHIC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static ProfilerMarker JHJMEDBPELE;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static ProfilerMarker BMNAPPEFBFI;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly string JJFBCAEGHJG;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static readonly string MAPCKEICEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly int[] JHEDCGFJEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly int[] GGPCEDEEMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private GameObject NLHPEMHHCCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private MeshCollider FMLMPHNDGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private GameObject CPLEKDPFGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private MeshFilter FFLJCDACMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private Mesh APMFBLDFJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private Mesh BLMJDNLIJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Collider[] KAEGBMCFAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private List<Collider> OMNFMLOKCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private Vector3[] AMMDKPBFCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private Vector3 LLHDINOKNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Vector3 LNDKJAIGIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Quaternion JCDHDMBCKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private Vector3[] GEKBKCGLHPH;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	private Mesh BPPIMNMENHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7C4300", Offset = "0x7C3300", VA = "0x1807C4300")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x62F18E0", Offset = "0x62F08E0", VA = "0x1862F18E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	private Mesh EEENKAAMGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7C6560", Offset = "0x7C5560", VA = "0x1807C6560")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x62F1A10", Offset = "0x62F0A10", VA = "0x1862F1A10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private int PAIBGNFHANN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x62F16F0", Offset = "0x62F06F0", VA = "0x1862F16F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public IEnumerable<Collider> EFCEAICKBPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x62F2860", Offset = "0x62F1860", VA = "0x1862F2860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x62F2990", Offset = "0x62F1990", VA = "0x1862F2990")]
	public JMADOOKGHIC(Material AMFPIMHFFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x62F0D10", Offset = "0x62EFD10", VA = "0x1862F0D10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x62F1970", Offset = "0x62F0970", VA = "0x1862F1970")]
	public void IFKJFIFILMF(Vector2 PNEDMFLKPFF, Vector2 OAKOHGHGDJD, Camera IGCKGGJPBHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x62F1930", Offset = "0x62F0930", VA = "0x1862F1930")]
	public void IBAIGGFAEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x62F22A0", Offset = "0x62F12A0", VA = "0x1862F22A0")]
	private IEnumerable<Collider> NKALEICBCMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x62F1D60", Offset = "0x62F0D60", VA = "0x1862F1D60")]
	private void MJPNJPFNFEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x62F1710", Offset = "0x62F0710", VA = "0x1862F1710")]
	private void GJECAKMBABC(Material JANOPPPMNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x62F1EB0", Offset = "0x62F0EB0", VA = "0x1862F1EB0")]
	private void NDONOGNHIBD(Vector2 PNEDMFLKPFF, Vector2 OAKOHGHGDJD, Camera IGCKGGJPBHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x62F0DD0", Offset = "0x62EFDD0", VA = "0x1862F0DD0")]
	private void EGAHNLEHLON(Vector2 PNEDMFLKPFF, Vector2 OAKOHGHGDJD, Camera IGCKGGJPBHM, Vector2 PKALCCLLAMO, Vector2 PANJNLBDFFF, Vector3 EMAJLJJIIDE, Vector3 FHGGHGPFIDE, Vector3 NMBFEBKAEHA, Vector3 OIDCCIILGLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x62F1870", Offset = "0x62F0870", VA = "0x1862F1870")]
	private void HEIGFJKGENL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x62F1A60", Offset = "0x62F0A60", VA = "0x1862F1A60")]
	private void LMHNOLABPDM(Vector3 DJEMCNKCFGA, Vector3 EMAJLJJIIDE, Vector3 FHGGHGPFIDE, Vector3 NMBFEBKAEHA, Vector3 OIDCCIILGLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x62F1650", Offset = "0x62F0650", VA = "0x1862F1650")]
	private void FMDJKNCPBEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class EOOFBFDDMJK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private PGPDKGBAGCH<T> FCPCCNDHOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private PDFHBPGHMMA<T> CINOKALDOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<T> PJLFIHMFFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<T> OKMJLEJBNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<T> MDNNCAHEJNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<T> ILPCMLFKLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<T> EDGOBPOFBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<T> GKJMBJKMMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private GIFGJFKEFFG FGOIHKAPIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private FGDJGMEALBC AOMFODAJBDK;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x353A770", Offset = "0x3539770", VA = "0x18353A770")]
	public EOOFBFDDMJK(PGPDKGBAGCH<T> FCPCCNDHOOE, PDFHBPGHMMA<T> CINOKALDOKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x353A6A0", Offset = "0x35396A0", VA = "0x18353A6A0")]
	public void MLLCENNIMJA(GIFGJFKEFFG FGOIHKAPIEB = GIFGJFKEFFG.Add)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x35396A0", Offset = "0x35386A0", VA = "0x1835396A0")]
	public void JGALKBGMLEJ(IEnumerable<Collider> DLHNAPIFPJD, Vector3 BLJJLPIHKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x35386B0", Offset = "0x35376B0", VA = "0x1835386B0")]
	public bool IONJMHALODP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3538590", Offset = "0x3537590", VA = "0x183538590")]
	[CompilerGenerated]
	private bool AAGFANCLOKB(T DLGLHFDHDLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3538660", Offset = "0x3537660", VA = "0x183538660")]
	[CompilerGenerated]
	private bool CHCGAMIKGDA(T DLGLHFDHDLB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum GIFGJFKEFFG
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	Remove
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
