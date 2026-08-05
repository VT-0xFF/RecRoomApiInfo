using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CodeStage.AntiCheat.ObscuredTypes;
using Cpp2IlInjected;
using Mono.Math;
using Photon.Pun;
using RecRoom.Core.Creation;
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
		public global::GPMIOKNMCFC<ConfigurableSubpiece, Collider[], Collider[]> OnCollidersChanged;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public IBGACCMEOLA KFOABHMAKPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x757880", Offset = "0x756680", VA = "0x180757880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7F11E0", Offset = "0x7EFFE0", VA = "0x1807F11E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Collider[] JGBHPJCDIFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Renderer[] OEOJBOIFDPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x741120", Offset = "0x73FF20", VA = "0x180741120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<IBGACCMEOLA> BNCGEMGOIDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x6ADD9F0", Offset = "0x6ADC7F0", VA = "0x186ADD9F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6ADDA90", Offset = "0x6ADC890", VA = "0x186ADDA90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6ADD630", Offset = "0x6ADC430", VA = "0x186ADD630")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6ADD6F0", Offset = "0x6ADC4F0", VA = "0x186ADD6F0")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6ADD7A0", Offset = "0x6ADC5A0", VA = "0x186ADD7A0")]
		public void SetIConfigurable(IBGACCMEOLA JGAMDHDHNKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6ADD640", Offset = "0x6ADC440", VA = "0x186ADD640")]
		public void ChangeCollidersAndRenderers(Collider[] NIIIJNAIPLN, Renderer[] OOJHAFPEJLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6ADD8E0", Offset = "0x6ADC6E0", VA = "0x186ADD8E0")]
		public void ValidateCollidersAndRenderers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6ADD750", Offset = "0x6ADC550", VA = "0x186ADD750")]
		public void RunConfigurationSpecialActions(IBGACCMEOLA DCOCPIHCJGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6ADD970", Offset = "0x6ADC770", VA = "0x186ADD970")]
		public ConfigurableSubpiece()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EDEHOBFOILH
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool JOFPNJBNEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action KJIDKMJHHDO;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AddIsAnimated(object AMBDKIOJFBL);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void RemoveIsAnimated(object AMBDKIOJFBL);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface HBALDJPFLLE
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RegisterConfigurablePiece(ConfigurableSubpiece PNHACCCIJEL);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void UnregisterConfigurablePiece(ConfigurableSubpiece PNHACCCIJEL);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ConfigurableSubpiece GetConfigurableSubpiece(Collider GAGPONOIJAN);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FFOBMLBAJOK
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	GameObject ADFEBALODBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Guid KJKAINKGCBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string JAGOKEMFLBL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string KJBHPMLOJHB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Vector3 PBOMGCKDOKK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Vector3 EPEMNPLCEDK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Quaternion AGDJMIJLDLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Quaternion DCDCJLPIMFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float DKLBMJLFIAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float IHIHJOLNCJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Vector3 CFKNCIJIFEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Vector3 PMINAKMKMGB
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool PJNEEEEEIEI
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool IJBIPFIJKEH
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	IBGACCMEOLA KFOABHMAKPB
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	PECCHINEOCO CFFFOGMPDNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action IALFIOFMPHK;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool CanUpdateDeformation(Vector3 ACOMIIFDOPF, float JENAJOLPNFN, float LJDDGIBHKLJ);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void UpdateDeformation(Vector3 ACOMIIFDOPF, float JENAJOLPNFN);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool CanBeRaycasted(Collider GAGPONOIJAN);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DEBINALJAKF
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool CLJIPJJGCDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool GBNLGOEKANN
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Vector3 CAKNGAOBJFA
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Vector3 LINDIJHLNKE
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool EAGNIDJMHBM
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool LLNJGLLHAKC
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool KFGILPKPLID
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool MGBHPCMGANI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool HJHOBDPFLOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool IFIMNGCABJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedBySpawning();

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelected();

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnTranslationStart();

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OnRotationStart();

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OnScaleStart();

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OnDeformStart();

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnMoveStart();

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnTranslated();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnRotated();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OnScaled();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OnDeformed(Vector3 AEEDPGJIPAP);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OnTranslationFinished();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OnRotationFinished();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OnScaleFinished();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OnDeformationFinished();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OnMoveFinished();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OnDeselected();

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OnHoverStart(PGLKDEIPACG DMLJOHNPIMI, Collider ECAPDAALHGO);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void OnHovering(PGLKDEIPACG DMLJOHNPIMI, Collider ECAPDAALHGO);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void OnHoverFinished(PGLKDEIPACG DMLJOHNPIMI);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void Translate(Vector3 FJEJLEJJBGJ);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void Rotate(Quaternion ICJLNDNIICB);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool Scale(float LPOEOCLIKMH);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task DeleteAsync();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EHEPJAJPFAG
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GEHKHGMKCGM(in Vector3 OBMFGFCEDPK, in Vector3 DJIMPKHJJFP, ref Vector3 BGNDJBOJFIN, ref Vector3 DLBJKHMIPFM);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface POGHCNDANNJ
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	BAHKENJLEMI GAEDHOPOMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task RequestMasterDespawn();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BDLEFOFDPBM
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool HMMBHCNAEEK
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	GFEFEGJGCDN FAJBFPHJHMG
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<bool> PBFGMFHJPMM;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LocalPlayerTakeAuthority();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void TransferOwnership(int KCCMIIMCEDH);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LKFKEMBCBJC GetCulprit(NCFLNOIOKBE IBFNJOBMFBM);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PGFCDBDOFNK
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	IEnumerable<GCEMGGDIHPC.CFCIFMNIKCC> OHDOCCMBCLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddNavMeshSupportRestriction(GCEMGGDIHPC.CFCIFMNIKCC HAGBBGDMJBP);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveNavMeshSupportRestriction(GCEMGGDIHPC.CFCIFMNIKCC HAGBBGDMJBP);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BPAPPBDNKIN
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CanModifyProperty(string HANNKCHKNMG);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NCEJCPMKPAB
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool HEHDCIEDDIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool PEIIJHDLBKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FEFFECCAMGM
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int AGPJIJHAHOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderSelection(BHFBDBAEJOH? CGKOANELEMM);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderOutline(NFGOLKNMBLF? BJJHMHPLIBG);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void RenderWorldFadeMask();

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Bounds GetWorldBounds();

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NCFLNOIOKBE CanBeSelected();

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CanBeSelected(out NCFLNOIOKBE AJCHMFJLMGE, out LKFKEMBCBJC NFGGGBDDHBI);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface OIHBLEPGDJL
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool ABCIEBHDJLF
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CostInfo DILHPNJADNB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool MDGNODKAOPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool EFJLEBEEBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool LJDGKAPPNEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool AINCNFIAKGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool IHCCGCAHACG
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool FIDGIOAMGDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool JLAPCEBKPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	IEnumerable<Collider> CGOBKFFNKHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool GJEGIPGBPGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LIAGALIJEJC
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NCFLNOIOKBE CanPerformUndoRedoOnObject();

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GetTransformationDataForUndoRedo(out Vector3 DNPAJCANFPF, out Quaternion NNAIELBMKHJ, out float OFCOBBDBKGK, out Vector3 NEFLENMJEDD);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetTransformationDataForUndoRedo(Vector3? DNPAJCANFPF, Quaternion? NNAIELBMKHJ, float? OFCOBBDBKGK, Vector3? NEFLENMJEDD);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface CLAKOKIKGMJ
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	object KHGELJBNMJF
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Type GFACKIAEBLB
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	Guid PBHPJHINNPN
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface IBGACCMEOLA
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	IReadOnlyList<CIINCKDFCDI> JNPPNKGDKBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string KJBHPMLOJHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string KFDPPFFKJFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool EMDPCLDELLN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<string> NJIBAIAIJOH;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<IBGACCMEOLA> BKKHKPMFKEG;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<KJAGFLIELNM, CPMPDMCPCKD> PMKGKPHLEFB;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action EOGIBDOBCDH;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void Reset();

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ConfigurableWillShow();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface AJDKLDBOELA
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool KEFFJEKIALL
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct GCEMGGDIHPC
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate CMMGPPJDOIF CFCIFMNIKCC();

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IEnumerable<CFCIFMNIKCC> DCJGLPBEMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<CFCIFMNIKCC> HPEKDCKDKJI;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public IEnumerable<CFCIFMNIKCC> HLFGLAHFGDE
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6ADDB90", Offset = "0x6ADC990", VA = "0x186ADDB90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6ADDC00", Offset = "0x6ADCA00", VA = "0x186ADDC00")]
	public void OEECIDDHIAM(CFCIFMNIKCC HAGBBGDMJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6ADDB30", Offset = "0x6ADC930", VA = "0x186ADDB30")]
	public bool CJGLMEKHGBL(CFCIFMNIKCC HAGBBGDMJBP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum CMMGPPJDOIF
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	NotSupported,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Supported
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum CKAFOLGLJAH
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	NavMeshGenerator,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	NavMeshIgnored,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	NavMeshBlocker
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class PECCHINEOCO
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int AJLEIINCHEC = -1;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const long HCCPKIIEKOK = -1L;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private global::FFIEJGBFNOJ<Guid, ObscuredLong, ObscuredInt, ObscuredBool> IFHIJDCNHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private global::DDCGAHLPACK<ObscuredBool, ObscuredInt, ObscuredInt> EPABHALOFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private MonoBehaviourPun CHMGCHLLEJC;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Guid BHCPPCDPBHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6ADE570", Offset = "0x6ADD370", VA = "0x186ADE570")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public long FGBLGGPPONO
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6ADE760", Offset = "0x6ADD560", VA = "0x186ADE760")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int EJGAJPFNKFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6ADE5E0", Offset = "0x6ADD3E0", VA = "0x186ADE5E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool AKNHNPFABLM
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6ADE680", Offset = "0x6ADD480", VA = "0x186ADE680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool PMGFICHAFGB
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6ADE810", Offset = "0x6ADD610", VA = "0x186ADE810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int HBHNLNAILLL
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6ADEBD0", Offset = "0x6ADD9D0", VA = "0x186ADEBD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int JECPACHCOJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6ADE970", Offset = "0x6ADD770", VA = "0x186ADE970")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool IHJOBHKOFGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6ADE720", Offset = "0x6ADD520", VA = "0x186ADE720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF0B0", Offset = "0x6ADDEB0", VA = "0x186ADF0B0")]
	public PECCHINEOCO(MonoBehaviourPun MJHEHLIBDDL, string OOKGKKOLMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF160", Offset = "0x6ADDF60", VA = "0x186ADF160")]
	public PECCHINEOCO(MonoBehaviourPun MJHEHLIBDDL, string OOKGKKOLMKO, Guid OBHHKCODPAD, long DPEBIILOGIL, int NDOPKCPCPGO, bool ICFLPBNDHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEA10", Offset = "0x6ADD810", VA = "0x186ADEA10")]
	public void IOGLHHFLBNJ(LKFKEMBCBJC FOPODFKBIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEC70", Offset = "0x6ADDA70", VA = "0x186ADEC70")]
	public void LHPMNDDFILC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEED0", Offset = "0x6ADDCD0", VA = "0x186ADEED0")]
	public void PGIHAENGDGO(Guid OHKKLJMNJEF, long DPEBIILOGIL, int NDOPKCPCPGO, bool ICFLPBNDHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEE00", Offset = "0x6ADDC00", VA = "0x186ADEE00")]
	public void PGIHAENGDGO(PECCHINEOCO IDBPJJAKCBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6ADED90", Offset = "0x6ADDB90", VA = "0x186ADED90")]
	public void OMELPNCNJDJ(FKENLHKDPBM MMJOHADFCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6ADE4C0", Offset = "0x6ADD2C0", VA = "0x186ADE4C0")]
	public void AJDHDDLFJAJ(FKENLHKDPBM MMJOHADFCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6ADE8B0", Offset = "0x6ADD6B0", VA = "0x186ADE8B0")]
	public static FKENLHKDPBM GLMDEKFNEEA(Guid OBHHKCODPAD, long DPEBIILOGIL, int OBIFIODJDAG, bool ICFLPBNDHGL)
	{
		return null;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class KBGNMEAALAF
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static byte[] JDPEKMLOAPL;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static int KHIOPMNKDNJ;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static int FJCGIOGMELC;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static BigInteger BOMEHIKGKLG;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public KBGNMEAALAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6ADE1E0", Offset = "0x6ADCFE0", VA = "0x186ADE1E0")]
	private static string PKFOMDHOGCM(byte[] EJKHFJILHAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6ADDE90", Offset = "0x6ADCC90", VA = "0x186ADDE90")]
	public static string GMEGIIKFFNC(byte[] EMGPHLLIACG, bool PHHFDNEANIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
