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
		public GGFMHBMHBCG<ConfigurableSubpiece, Collider[], Collider[]> OnCollidersChanged;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public DHENDAKPDBH EHJMICMEIDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x765900", Offset = "0x764700", VA = "0x180765900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7658F0", Offset = "0x7646F0", VA = "0x1807658F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Collider[] GILIDMIBJCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Renderer[] PLNOCFNBALF
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x761660", Offset = "0x760460", VA = "0x180761660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<DHENDAKPDBH> NLNMLEFBCOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x5D02F10", Offset = "0x5D01D10", VA = "0x185D02F10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x5D02FC0", Offset = "0x5D01DC0", VA = "0x185D02FC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5D02BA0", Offset = "0x5D019A0", VA = "0x185D02BA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5D02C50", Offset = "0x5D01A50", VA = "0x185D02C50")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5D02CC0", Offset = "0x5D01AC0", VA = "0x185D02CC0")]
		public void SetIConfigurable(DHENDAKPDBH COANHBBABPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5D02BB0", Offset = "0x5D019B0", VA = "0x185D02BB0")]
		public void ChangeCollidersAndRenderers(Collider[] IGDGLMJDEFB, Renderer[] ANNKMHIFAGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5D02DF0", Offset = "0x5D01BF0", VA = "0x185D02DF0")]
		public void ValidateCollidersAndRenderers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5D02CA0", Offset = "0x5D01AA0", VA = "0x185D02CA0")]
		public void RunConfigurationSpecialActions(DHENDAKPDBH GPEFPCPDIGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5D02E80", Offset = "0x5D01C80", VA = "0x185D02E80")]
		public ConfigurableSubpiece()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KAKJCHMFEPO
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CDFINKDBJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddIsAnimated(object PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveIsAnimated(object PFKLELGAJPH);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GCOPOFCEMEP
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RegisterConfigurablePiece(ConfigurableSubpiece BEOBINHIAAJ);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void UnregisterConfigurablePiece(ConfigurableSubpiece BEOBINHIAAJ);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ConfigurableSubpiece GetConfigurableSubpiece(Collider BHBBEPIOBCA);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface HMFDINCFHCC
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	GameObject JJBLAIFLMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Guid GHNOHILPLAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string KKCKMDALLNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string INFPBNOCDKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Vector3 COKHGDLHIBE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Vector3 IINMIFPFDIC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Quaternion DHOHNGCOPAD
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float ODAENDJNKNL
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float OFMEOPGKNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Vector3 PMAKIOKCLKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Vector3 GHIGPODGCDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "16")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool BFIAEENOFFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DHENDAKPDBH EHJMICMEIDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DGAMBDJCNCP KJOECMCDIKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action PGBIAHLJNMI;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "20")]
	bool CanUpdateDeformation(Vector3 DMNGCFHLPIF, float PHNLKCCANFD, float MAHJIIDJKNO);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void UpdateDeformation(Vector3 DMNGCFHLPIF, float PHNLKCCANFD);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool CanBeRaycasted(Collider BHBBEPIOBCA);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface CDNHDDEGDFG
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool BCAJFBECIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool EKMDPPFGJPF
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	Vector3 AJOCEPDHKBP
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Vector3 LAPPGJOCEBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool INMKABOHIOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool DIDIACFGMCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool IPMEHAMPIGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool JEKDAJLCJPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool FEMCKLKCPAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool BMKKGMLINIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedBySpawning();

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelected();

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnTranslationStart();

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OnRotationStart();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OnScaleStart();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OnDeformStart();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnTranslated();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnRotated();

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnScaled();

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OnDeformed(Vector3 NPMCOACFEEE);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OnTranslationFinished();

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OnRotationFinished();

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OnScaleFinished();

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OnDeformationFinished();

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OnDeselected();

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OnHoverStart(HHBHGLEIDCB HINEAEMFAII, Collider OGBKNMCLIKJ);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OnHovering(HHBHGLEIDCB HINEAEMFAII, Collider OGBKNMCLIKJ);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OnHoverFinished(HHBHGLEIDCB HINEAEMFAII);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void Translate(Vector3 KCMMEDELFNC);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void Rotate(Quaternion EIGHHIMBJHE);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool Scale(float OFPMODDPBDG);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Task DeleteAsync();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface APAHMKNMKNG
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IGLKLKAKNKD([In] Vector3 JLBMPBJBLDH, [In] Vector3 IELHLOGPMDL, Vector3 EADAPKBIBFH, Vector3 LNAACFFHHMA);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BFBCNFGJAEG
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool ABJHONMDMMF
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	IBKPFCNCMON NCFLFCOEPPP
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MasterDespawn();

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task RequestMasterDespawn();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FOMGNCEBNGE
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool LIJFFBIMDEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	FIBDGAHODOI JJFBJGGDHIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<bool> CAMPGMODJAO;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LocalPlayerTakeAuthority();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void TransferOwnership(int GMLBOGHFEOC);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BNLKEILDJHP GetCulprit(PMFGGLHKBIM LFCIHCAIFLN);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JBHMLGDAPOM
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	IEnumerable<FKHPEPKAKCL.JAGOPELODBN> DOBOPIFEJLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddNavMeshSupportRestriction(FKHPEPKAKCL.JAGOPELODBN MDKDHAOGHJF);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveNavMeshSupportRestriction(FKHPEPKAKCL.JAGOPELODBN MDKDHAOGHJF);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface JKJAJILONFM
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface EMHGAPNDKPE
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool JIFJGAGCLDP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool EAPHPLBHIKA
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GFOFLHNAFKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	int PIOOKDNKKHO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderSelection(OGFNAEOOEJF? INKFJIBFDAL);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderOutline(NBDHLNCBJFN? ABJDJAMBLGG);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void RenderWorldFadeMask();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Bounds GetWorldBounds();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PMFGGLHKBIM CanBeSelected();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LIOCMEEOPOM
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool LPPBMEBGIAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	CostInfo MOHMOEOLPLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool DIFGINNEDHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool AOJKDCIKIOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool PEBIOLDBNIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool BKMGGGAJCOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool DELKHOLBDFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	IEnumerable<Collider> IEEPCHCPNAP
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool NCJJGJOGALL
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface FIPNIGPIJCI
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PMFGGLHKBIM CanPerformUndoRedoOnObject();

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GetTransformationDataForUndoRedo([Out] Vector3 AILFIIEAPKM, [Out] Quaternion GIBIBDOGOLL, [Out] float BABNOKCMAEB, [Out] Vector3 JOJDIJDJBBA);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetTransformationDataForUndoRedo(Vector3? AILFIIEAPKM, Quaternion? GIBIBDOGOLL, float? BABNOKCMAEB, Vector3? JOJDIJDJBBA);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface EEPMGLBBCEC
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	object MNDEGHILDBL
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	Type LACFDODBDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	Guid NLLHDCMLGGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface DHENDAKPDBH
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	IReadOnlyList<NPKCNHEHOHB> MNLFEGBKDOK
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	string INFPBNOCDKF
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	string PLFLPHIGDPK
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool EHIDAKAHKBK
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<string> BGLEPIELNIF;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<DHENDAKPDBH> IEJHAAJELHB;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<APDFOMNHBPP, MIEGHKGJOCL> GJHJCDIJLEO;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action BMJMDLKIHCN;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void Reset();

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ConfigurableWillShow();

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ConfigurableWillHide();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface GHNHBNDPMBL
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool IOKEGNKCKHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct FKHPEPKAKCL
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate MPMDFJOKANO JAGOPELODBN();

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IEnumerable<JAGOPELODBN> IBIPKNHFBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<JAGOPELODBN> NFPMFMGFPIJ;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public IEnumerable<JAGOPELODBN> BIENMMBDJCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5D04100", Offset = "0x5D02F00", VA = "0x185D04100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5D03EF0", Offset = "0x5D02CF0", VA = "0x185D03EF0")]
	public void AAFNAGDLNDC(JAGOPELODBN MDKDHAOGHJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5D04160", Offset = "0x5D02F60", VA = "0x185D04160")]
	public bool ILBKIBAINPM(JAGOPELODBN MDKDHAOGHJF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum MPMDFJOKANO
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	NotSupported,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Supported
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum IOINBGGLPOK
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	NavMeshGenerator,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	NavMeshIgnored,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	NavMeshBlocker
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class DGAMBDJCNCP
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int OPMCINHPMML = -1;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const long OFIGLNNHJEN = -1L;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private BKONOEHJNAJ<Guid, ObscuredLong, ObscuredInt, ObscuredBool> HLALDFHPPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private HILILHBCDHD<ObscuredBool, ObscuredInt, ObscuredInt> GOBPKLFDOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private MonoBehaviourPun ECKGDPNKHLJ;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Guid LDMDPJOKGPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5D03070", Offset = "0x5D01E70", VA = "0x185D03070")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public long JPODJGFGBNI
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5D033F0", Offset = "0x5D021F0", VA = "0x185D033F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int DGCAKFHOGPC
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5D03890", Offset = "0x5D02690", VA = "0x185D03890")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool JPMDIGIPBGE
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5D037C0", Offset = "0x5D025C0", VA = "0x185D037C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool MPJKHKKJMCE
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5D032B0", Offset = "0x5D020B0", VA = "0x185D032B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int GDBHNPBGCNL
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5D03520", Offset = "0x5D02320", VA = "0x185D03520")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int FFAKFPGDLGL
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5D03490", Offset = "0x5D02290", VA = "0x185D03490")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool MAFNGLDDDIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5D03850", Offset = "0x5D02650", VA = "0x185D03850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5D03BB0", Offset = "0x5D029B0", VA = "0x185D03BB0")]
	public DGAMBDJCNCP(MonoBehaviourPun BEBEAJFPMNE, string JLBOLILBBGL, Guid HDFAFBAMMEG, long DBDMPLBHEGA, int LPNFFLNLCOL, bool PAPKONMDCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5D035B0", Offset = "0x5D023B0", VA = "0x185D035B0")]
	public void LNIAOIDJBLC(BNLKEILDJHP NIHLLBIAHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5D031A0", Offset = "0x5D01FA0", VA = "0x185D031A0")]
	public void CALOANCDKML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5D039F0", Offset = "0x5D027F0", VA = "0x185D039F0")]
	public void OOCIGOIJKNJ(Guid FFEBHLNAPBM, long DBDMPLBHEGA, int LPNFFLNLCOL, bool PAPKONMDCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5D03920", Offset = "0x5D02720", VA = "0x185D03920")]
	public void OOCIGOIJKNJ(DGAMBDJCNCP MFMJJEFODHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5D03750", Offset = "0x5D02550", VA = "0x185D03750")]
	public void MJOBLMEIHLP(HMFICIEPHGJ PFDMLBFKIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5D03340", Offset = "0x5D02140", VA = "0x185D03340")]
	public void DCANLPGAAKB(HMFICIEPHGJ PFDMLBFKIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5D030E0", Offset = "0x5D01EE0", VA = "0x185D030E0")]
	public static HMFICIEPHGJ BJLAOAABPFD(Guid HDFAFBAMMEG, long DBDMPLBHEGA, int JIKKPPFCCDL, bool PAPKONMDCJN)
	{
		return null;
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
