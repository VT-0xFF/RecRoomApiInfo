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
		public LJADHFIHFIP<ConfigurableSubpiece, Collider[], Collider[]> OnCollidersChanged;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public LNMJLMIOKPP JBIHHKPENMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x867CF0", Offset = "0x8668F0", VA = "0x180867CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x867CC0", Offset = "0x8668C0", VA = "0x180867CC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Collider[] OFDFFDOAPNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Renderer[] CAJKMNCDLDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x867590", Offset = "0x866190", VA = "0x180867590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<LNMJLMIOKPP> MLKFBBOOMFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x6A12E80", Offset = "0x6A11A80", VA = "0x186A12E80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6A12F30", Offset = "0x6A11B30", VA = "0x186A12F30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6A12B10", Offset = "0x6A11710", VA = "0x186A12B10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6A12BC0", Offset = "0x6A117C0", VA = "0x186A12BC0")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6A12C30", Offset = "0x6A11830", VA = "0x186A12C30")]
		public void SetIConfigurable(LNMJLMIOKPP NMCBNEIKPHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6A12B20", Offset = "0x6A11720", VA = "0x186A12B20")]
		public void ChangeCollidersAndRenderers(Collider[] APNGKGMEPDF, Renderer[] CDGEJIBDHNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6A12D60", Offset = "0x6A11960", VA = "0x186A12D60")]
		public void ValidateCollidersAndRenderers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6A12C10", Offset = "0x6A11810", VA = "0x186A12C10")]
		public void RunConfigurationSpecialActions(LNMJLMIOKPP OCPKLLEGBMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6A12DF0", Offset = "0x6A119F0", VA = "0x186A12DF0")]
		public ConfigurableSubpiece()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CHOJHJHJIKC
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool DABICFLMDOK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddIsAnimated(object GBENACPKFNA);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveIsAnimated(object GBENACPKFNA);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface PNFLNAMHDCK
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RegisterConfigurablePiece(ConfigurableSubpiece DBKEBEMKPMB);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void UnregisterConfigurablePiece(ConfigurableSubpiece DBKEBEMKPMB);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ConfigurableSubpiece GetConfigurableSubpiece(Collider PENEDLAGBJG);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DOPMKFJPGED
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	GameObject CPHJNMFHAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Guid CDOFNHNEEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string ACNBDEPIOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string CMMCDEPIGAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Vector3 HOGGFEAJLCE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Vector3 BOKOHHFILBG
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Quaternion ODHCJDCMGHC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Quaternion CKGMEBIHNIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float MMGMJPBKMDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float GPJBNIKGDMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "16")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Vector3 CIADPODNBLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Vector3 HDANIILJEJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool CNJBOHMIDEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "20")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	LNMJLMIOKPP JBIHHKPENMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	CBCIMIFNICJ INACAFHEBFA
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action DJFAAHMLEDP;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool CanUpdateDeformation(Vector3 HEGOCMEIPKI, float DAKBJPGNEGN, float JJOKGJELGMC);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void UpdateDeformation(Vector3 HEGOCMEIPKI, float DAKBJPGNEGN, bool LMANCFCEMFF, Space OAMLHMLPNJK);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool CanBeRaycasted(Collider PENEDLAGBJG);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MKDCDMPMDAL
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool PKMFFNOOHNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool BOCFECLEGDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Vector3 BHEOAMENAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Vector3 FLHMFMINLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool GHMKPODBLID
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool MOMNAOCELOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool OPOCEILBFFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool EIINEKPEGCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool OCCEMFMNFHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool LPGMFPKPEEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool BKEEMDCGGKF
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "28")]
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
	void OnDeformed(Vector3 ODFCBIIINOM);

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
	void OnHoverStart(FJMBEENKNHE AFGGLAMLNKB, Collider LDEJOGIIDND, FGDLALGCPMA PCBGPECNNNC);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OnHovering(FJMBEENKNHE AFGGLAMLNKB, Collider LDEJOGIIDND);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OnHoverFinished(FJMBEENKNHE AFGGLAMLNKB, PEAFMKHEGLL MBDAGFJBCIG, FGDLALGCPMA.JKLGGNLGHPB HLHLNHFKIPH);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void Translate(Vector3 HNCLAFNIEEJ);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void Rotate(Quaternion CMCIEBEPCMB);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool Scale(float GMIJCBEMLNL);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task DeleteAsync();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BNKHFCILIDL
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BFBFCKCEBHF([In] Vector3 PPDGJCIMLMA, [In] Vector3 MLCEOGMBLFG, Vector3 CEABDOPCPIJ, Vector3 BCLJLGDCOIN);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface MCKHOJKIOBF
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool DDOKPNFGBPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IHJBDENMBEB ANNFGBMACDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MasterDespawn();

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task RequestMasterDespawn();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface LPCIBONPBHO
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool FHCKNDDMAOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	INFFGIDHEMG IOBGLOJGEAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<bool> EEKGOIHBHFD;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LocalPlayerTakeAuthority();

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void TransferOwnership(int EMEMCFHGFLI);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HGPNAAJHJFA GetCulprit(DBLAAKPDHMG FGPDCFGEMJC);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface NIBLKDGMFFO
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	IEnumerable<NKHPNNJMENA.PGOHMEOHDKD> IBOOKOOPHGD
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddNavMeshSupportRestriction(NKHPNNJMENA.PGOHMEOHDKD PFKLAMDPGAG);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveNavMeshSupportRestriction(NKHPNNJMENA.PGOHMEOHDKD PFKLAMDPGAG);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface AHEBPADHOJB
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Reset();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JEJPHIFALBM
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool AFFHPILHDBK
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool GPFKOGFGFFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CHJMPLNJGLK
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	int MOMLKDJPPNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderSelection(BPFOGIPMOBA? IMJNBNFDPBF);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderOutline(FKPBJOFDNBG? FJNHLGEPLMK);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void RenderWorldFadeMask();

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Bounds GetWorldBounds();

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DBLAAKPDHMG CanBeSelected();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HMBGGOIDNIH
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool CJPJGIMDPFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool LEAHHGEIEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool KBJHMNJEEAF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool JKPMNFKKOBI
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool CEDLHIHPNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool HDEHECFIINF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool DBHHPKMBIKL
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	IEnumerable<Collider> BNEDALGBLCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	AEPGKMCGDHH? PIHANBIMBLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool DOFGPEKIKDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool FKHIDJHAFIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CostInfo GetSandboxResourceCost(bool APHLNLLEPMH = true);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HPNLEFPLAJG
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DBLAAKPDHMG CanPerformUndoRedoOnObject();

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GetTransformationDataForUndoRedo([Out] Vector3 DCDKACDAEIJ, [Out] Quaternion GPEICHFGELO, [Out] float BLLABJPKACO, [Out] Vector3 POFHFKHIHMF);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetTransformationDataForUndoRedo(Vector3? DCDKACDAEIJ, Quaternion? GPEICHFGELO, float? BLLABJPKACO, Vector3? POFHFKHIHMF);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface AHJOFNGONBB
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	object PMBJDMFAALJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	Type OONCIEBLOAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	Guid LLCPKJCFIAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface LNMJLMIOKPP
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	IReadOnlyList<FPCDBPDHPAJ> GMFNEMJMGMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string CMMCDEPIGAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	string LOLHECBIENJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool PHIOAAOKLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<string> GLHAFOEILFG;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<LNMJLMIOKPP> NPJPDAHJNFM;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<ABDJEDGHACP, ALBEFBCJJMO> LECLOEIEKNC;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action ADANBEBIJIH;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void Reset();

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ConfigurableWillShow();

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ConfigurableWillHide();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MBBIIDGCHIC
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool INOMNFKAHFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct NKHPNNJMENA
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate JMKHGBHLNOE PGOHMEOHDKD();

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IEnumerable<PGOHMEOHDKD> HCLOBKFDILK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<PGOHMEOHDKD> JMJJIEJBJJC;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public IEnumerable<PGOHMEOHDKD> AJECHCNPONA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6A15AE0", Offset = "0x6A146E0", VA = "0x186A15AE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6A15930", Offset = "0x6A14530", VA = "0x186A15930")]
	public void LKPJOLMECIF(PGOHMEOHDKD PFKLAMDPGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6A158D0", Offset = "0x6A144D0", VA = "0x186A158D0")]
	public bool ECLBFOFCOFL(PGOHMEOHDKD PFKLAMDPGAG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum JMKHGBHLNOE
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	NotSupported,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Supported
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class CBCIMIFNICJ
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public const int ECILCDJGDMP = -1;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public const long ADDEEEKMEBC = -1L;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private DDKJIPHONIM<Guid, ObscuredLong, ObscuredInt, ObscuredBool> PLILPOOICBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private FLMBGJOHEKH<ObscuredBool, ObscuredInt, ObscuredInt> NIBMINMLPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private MonoBehaviourPun DJNHJDCMHHE;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Guid HNILEKEAGGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6A11E30", Offset = "0x6A10A30", VA = "0x186A11E30")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public long NJKHIHEODFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6A11F10", Offset = "0x6A10B10", VA = "0x186A11F10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int BAKNGFNCHBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6A11D10", Offset = "0x6A10910", VA = "0x186A11D10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool EPIGHCLDFEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6A11DA0", Offset = "0x6A109A0", VA = "0x186A11DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool DKFPGKEMFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6A11C80", Offset = "0x6A10880", VA = "0x186A11C80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int JFPEKEKEFPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6A123B0", Offset = "0x6A10FB0", VA = "0x186A123B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int PIILNFMDFFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6A12150", Offset = "0x6A10D50", VA = "0x186A12150")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool NOPHBJECKPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6A12440", Offset = "0x6A11040", VA = "0x186A12440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6A127D0", Offset = "0x6A113D0", VA = "0x186A127D0")]
	public CBCIMIFNICJ(MonoBehaviourPun PJJDAACFHHD, string MHFGEFMLADH, Guid DOJBKMGKGEI, long AIJEHKPBNKB, int IOFBECDOPMH, bool EOABELPMEJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6A11FB0", Offset = "0x6A10BB0", VA = "0x186A11FB0")]
	public void FCCDIPIJCBG(HGPNAAJHJFA PPOOIMMAMFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6A122A0", Offset = "0x6A10EA0", VA = "0x186A122A0")]
	public void INGAMFGPPEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6A12550", Offset = "0x6A11150", VA = "0x186A12550")]
	public void NJFEGHENHFC(Guid ACLMMFKFIKF, long AIJEHKPBNKB, int IOFBECDOPMH, bool EOABELPMEJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6A12480", Offset = "0x6A11080", VA = "0x186A12480")]
	public void NJFEGHENHFC(CBCIMIFNICJ HEIGABGMPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6A11EA0", Offset = "0x6A10AA0", VA = "0x186A11EA0")]
	public void DCMGKGACGCL(DHPECOBHCAM JGFKFMMOAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6A12720", Offset = "0x6A11320", VA = "0x186A12720")]
	public void NPAODOIIONH(DHPECOBHCAM JGFKFMMOAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A121E0", Offset = "0x6A10DE0", VA = "0x186A121E0")]
	public static DHPECOBHCAM HDGLGPJHODF(Guid DOJBKMGKGEI, long AIJEHKPBNKB, int GIONBGPNONA, bool EOABELPMEJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct FGDLALGCPMA : IEquatable<FGDLALGCPMA>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class FHIEBCJBGDB : ODGDLPMODHO<FGDLALGCPMA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public bool IEKHLJNNNBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x6A132A0", Offset = "0x6A11EA0", VA = "0x186A132A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6A132E0", Offset = "0x6A11EE0", VA = "0x186A132E0")]
		public bool HBHHOAJCOHD(PEAFMKHEGLL POHMAEOFHEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6A13300", Offset = "0x6A11F00", VA = "0x186A13300")]
		public FGDLALGCPMA KENKIJONDCA(PEAFMKHEGLL POHMAEOFHEL)
		{
			return default(FGDLALGCPMA);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6A133C0", Offset = "0x6A11FC0", VA = "0x186A133C0")]
		private int NHFGJMJJIPF(PEAFMKHEGLL POHMAEOFHEL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6A13480", Offset = "0x6A12080", VA = "0x186A13480")]
		public FHIEBCJBGDB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public enum NCLJPALIEOM
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		UgcGameplaySystem,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		ContentCreationTool,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		PlayerDirectInteraction,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		HackStandinPriorityToDistinguishNone
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public enum JKLGGNLGHPB
	{
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		TARGETED_OBJECT,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		ALL_UNDER_ROOT_CONNECTABLE
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly FGDLALGCPMA DDFDPFDDMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly NCLJPALIEOM DFLLOILDKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly PEAFMKHEGLL OCFPDNBMEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly JKLGGNLGHPB LJNIKPKCBKO;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A13290", Offset = "0x6A11E90", VA = "0x186A13290")]
	public FGDLALGCPMA(PEAFMKHEGLL POHMAEOFHEL, NCLJPALIEOM BOCMOELLFNN = NCLJPALIEOM.UgcGameplaySystem, JKLGGNLGHPB GIIHAKJPNKL = JKLGGNLGHPB.TARGETED_OBJECT)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A131D0", Offset = "0x6A11DD0", VA = "0x186A131D0")]
	public static bool IGDKJEPDLHP(FGDLALGCPMA PFJBMEMCGDE, FGDLALGCPMA GCHHKKAJBGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A12FE0", Offset = "0x6A11BE0", VA = "0x186A12FE0", Slot = "4")]
	public bool Equals(FGDLALGCPMA HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6A13090", Offset = "0x6A11C90", VA = "0x186A13090", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6A13150", Offset = "0x6A11D50", VA = "0x186A13150", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface ONFIBMBDIMB
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RequestStartOutlining(FGDLALGCPMA KAIGMLIOMBJ);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RequestStopOutlining(PEAFMKHEGLL POHMAEOFHEL, FGDLALGCPMA.JKLGGNLGHPB GIIHAKJPNKL);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class JMOHLAIPHDK
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static BCFOECKJENL<Vector3> OBJNNGPOPPL;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static BCFOECKJENL<Vector3> CHLBPIBAOGI;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A15750", Offset = "0x6A14350", VA = "0x186A15750", Slot = "4")]
	protected virtual void GLIGFHAHEAO(Vector3 BLLBPBHAKME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A156C0", Offset = "0x6A142C0", VA = "0x186A156C0", Slot = "5")]
	protected virtual void FEJHDAEAGAH(Vector3 BLLBPBHAKME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	protected JMOHLAIPHDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class GNIKKGDFDHL : JMOHLAIPHDK
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6A15640", Offset = "0x6A14240", VA = "0x186A15640")]
	public void LOPFPEGNIML(Vector3 DCDKACDAEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6A15610", Offset = "0x6A14210", VA = "0x186A15610")]
	public void FIFBLGHKHON(Vector3 DCDKACDAEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6A15670", Offset = "0x6A14270", VA = "0x186A15670")]
	public GNIKKGDFDHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class GJKOODEPAPD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static ProfilerMarker EDHGGIPFBNK;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static ProfilerMarker CPPINKIGHHD;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly string KFHIBKDBDKF;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static readonly string PNBEPIIDIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly int[] IADOGKGKOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly int[] JGPGHBKFCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject GPDMHIICMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private MeshCollider BECLDLOOOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private GameObject FJAGCHLJPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private MeshFilter DAJCMNHKKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Mesh CLNBBHEODFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private Mesh GPGFPKIDIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Collider[] MCOBPLPLNKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<Collider> DFIBLEKDCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private Vector3[] KALGOFDBMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private Vector3 FPOGBACBJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Vector3 OMEEFOFMAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Quaternion EBECCCMCAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Vector3[] MAIOAJGFJPB;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private Mesh INLFOECGNPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x86A490", Offset = "0x869090", VA = "0x18086A490")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6A14FD0", Offset = "0x6A13BD0", VA = "0x186A14FD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private Mesh PICGEJAECKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x86C7D0", Offset = "0x86B3D0", VA = "0x18086C7D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6A14B20", Offset = "0x6A13720", VA = "0x186A14B20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private int FDKINGDNCPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6A135B0", Offset = "0x6A121B0", VA = "0x186A135B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public IEnumerable<Collider> GNFEGJFIOIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6A135A0", Offset = "0x6A121A0", VA = "0x186A135A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6A15140", Offset = "0x6A13D40", VA = "0x186A15140")]
	public GJKOODEPAPD(Material PKNFLFOCBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6A137C0", Offset = "0x6A123C0", VA = "0x186A137C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6A13500", Offset = "0x6A12100", VA = "0x186A13500")]
	public void BGCIEGBDILK(Vector2 GMANLKBACOJ, Vector2 NOJEIMCBKLE, Camera BCNHCNDKBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6A134C0", Offset = "0x6A120C0", VA = "0x186A134C0")]
	public void BFHBIFKGKNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6A13880", Offset = "0x6A12480", VA = "0x186A13880")]
	private IEnumerable<Collider> FKCCJOLDIAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6A13670", Offset = "0x6A12270", VA = "0x186A13670")]
	private void DNDFKIKIJNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6A13E40", Offset = "0x6A12A40", VA = "0x186A13E40")]
	private void FMGKIDMGHKI(Material DMGEDCGOKIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6A14B70", Offset = "0x6A13770", VA = "0x186A14B70")]
	private void JLBHJKBDMDG(Vector2 GMANLKBACOJ, Vector2 NOJEIMCBKLE, Camera BCNHCNDKBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6A142A0", Offset = "0x6A12EA0", VA = "0x186A142A0")]
	private void JBAJIIIFDOK(Vector2 GMANLKBACOJ, Vector2 NOJEIMCBKLE, Camera BCNHCNDKBNI, Vector2 NCBNLKAMIDF, Vector2 GGELMPPGANM, Vector3 GDMDPFMPMLO, Vector3 CPEPLELLCFM, Vector3 LLAGGJMHAAJ, Vector3 LDPIONCIMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6A14F60", Offset = "0x6A13B60", VA = "0x186A14F60")]
	private void MFPOPNNAEFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6A13FA0", Offset = "0x6A12BA0", VA = "0x186A13FA0")]
	private void FNNNNACDCMA(Vector3 PJJJBOOIMGP, Vector3 GDMDPFMPMLO, Vector3 CPEPLELLCFM, Vector3 LLAGGJMHAAJ, Vector3 LDPIONCIMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6A135D0", Offset = "0x6A121D0", VA = "0x186A135D0")]
	private void DGFBGOLJCHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class IPNOGFOGCCK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private MAMIBEEBPCG<T> LOKHFIPGHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private KDOILIFAAKJ<T> BFLMDBGKLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private List<T> EJKPHCMODPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private List<T> PIPFHCFCHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private List<T> KCAPGLIHHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private List<T> CFHGEAFKDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private List<T> DEKCLHDHEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private List<T> ANKLOKGKDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private CJIPBHPHMAL GIIHAKJPNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private GNIKKGDFDHL JCLPCNOFMFL;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3ECD620", Offset = "0x3ECC220", VA = "0x183ECD620")]
	public IPNOGFOGCCK(MAMIBEEBPCG<T> LOKHFIPGHKL, KDOILIFAAKJ<T> BFLMDBGKLCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3ECAD70", Offset = "0x3EC9970", VA = "0x183ECAD70")]
	public void CBAJJELMFPM(CJIPBHPHMAL GIIHAKJPNKL = CJIPBHPHMAL.Add)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3ECAF40", Offset = "0x3EC9B40", VA = "0x183ECAF40")]
	public void MIIOJBADGMM(IEnumerable<Collider> EOIOIMKEPOF, Vector3 GFKAJHHILJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3ECAE70", Offset = "0x3EC9A70", VA = "0x183ECAE70")]
	public bool IKJLPFNFBCP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3ECD2D0", Offset = "0x3ECBED0", VA = "0x183ECD2D0")]
	[CompilerGenerated]
	private bool OPGOFHKIMEN(T KIGIELEFAKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3ECACB0", Offset = "0x3EC98B0", VA = "0x183ECACB0")]
	[CompilerGenerated]
	private bool BFGLJNBGOKJ(T KIGIELEFAKI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum CJIPBHPHMAL
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
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
