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
		public APBODAALHDH<ConfigurableSubpiece, Collider[], Collider[]> OnCollidersChanged;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public JKCKGADIHBA GNPIFAFKDCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F80", Offset = "0x7C1380", VA = "0x1807C1F80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Collider[] FOLHBKEMJNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Renderer[] BIOAIBAIJOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0440", VA = "0x1807C1040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<JKCKGADIHBA> GNBDJJEJDOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x61F7DA0", Offset = "0x61F71A0", VA = "0x1861F7DA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x61F7E50", Offset = "0x61F7250", VA = "0x1861F7E50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x61F7A30", Offset = "0x61F6E30", VA = "0x1861F7A30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x61F7AE0", Offset = "0x61F6EE0", VA = "0x1861F7AE0")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x61F7B50", Offset = "0x61F6F50", VA = "0x1861F7B50")]
		public void SetIConfigurable(JKCKGADIHBA ABIMOJJCMBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x61F7A40", Offset = "0x61F6E40", VA = "0x1861F7A40")]
		public void ChangeCollidersAndRenderers(Collider[] JOJIHJJDBEH, Renderer[] FJBBFLFDNMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x61F7C80", Offset = "0x61F7080", VA = "0x1861F7C80")]
		public void ValidateCollidersAndRenderers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x61F7B30", Offset = "0x61F6F30", VA = "0x1861F7B30")]
		public void RunConfigurationSpecialActions(JKCKGADIHBA PGAIJGHJDKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x61F7D10", Offset = "0x61F7110", VA = "0x1861F7D10")]
		public ConfigurableSubpiece()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PEOOMLEAJLO
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool PNNLEKPFEAM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddIsAnimated(object ICNJFMMNIKL);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveIsAnimated(object ICNJFMMNIKL);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface OCMIGIBIMJI
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RegisterConfigurablePiece(ConfigurableSubpiece CIJKOJJOOJO);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void UnregisterConfigurablePiece(ConfigurableSubpiece CIJKOJJOOJO);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ConfigurableSubpiece GetConfigurableSubpiece(Collider NCBDOAFFENC);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EAEHPEKLJCF
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	GameObject IDFBDNNIJMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Guid FJJENHDOBLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string CGOKMMHCJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string JBPKKIJGIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Vector3 ELBCFGCNPCO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Vector3 LEEADPCABEK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Quaternion OPLHNIOLKKB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Quaternion DIGMIJLMHJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float HBDKBLLNLFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float LDIBAJAAJBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "16")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Vector3 KNBOGAGCAPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Vector3 KJJCNHNAABE
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool BFOBPCKDELL
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "20")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	JKCKGADIHBA GNPIFAFKDCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	GOGBPOPPMHJ BPOAIOMMCGH
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action ECENHNAPEJJ;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool CanUpdateDeformation(Vector3 OONJOBINLDJ, float LHJKGMBMGOE, float CNGONDMEHAN);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void UpdateDeformation(Vector3 OONJOBINLDJ, float LHJKGMBMGOE, bool FBOPOHGABFL, Space CBGFBOEMOLH);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool CanBeRaycasted(Collider NCBDOAFFENC);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FAGHDEIPBFF
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool BFHBJDDKHNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool GJOBILAGEBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Vector3 LJHEMECNGGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Vector3 AKLFMDMHGEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool NDNFMDNCLCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool ACABKBGMAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool BLPMJNPFPLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool JCGNMBCPFME
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool MGMIFOFEGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool OMKGACHFGNI
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
	void OnDeformed(Vector3 IBEDLKDEBAL);

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
	void OnHoverStart(JIKJBMAJPLG OCEABMAKHGP, Collider JMFEFAKGIAH);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OnHovering(JIKJBMAJPLG OCEABMAKHGP, Collider JMFEFAKGIAH);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OnHoverFinished(JIKJBMAJPLG OCEABMAKHGP);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void Translate(Vector3 INPNDBDMKHD);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void Rotate(Quaternion ECIFHMKBFBP);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool Scale(float NHGFEEIKBPI);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Task DeleteAsync();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface AFHIBEDHGJB
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CPCEOIOBKKF([In] Vector3 GCCJMDLJDKL, [In] Vector3 FOKNCLAMPPK, Vector3 BNGBCCIAFOF, Vector3 GCPIJELMKHI);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface JGBPCPBLPGF
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool MOFCIAAAGLA
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	LEPMAMFFPJF FBIBBEEKFDL
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
public interface DECDPIBODOB
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool KOPDHDHAPAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	LGNJBKMGLNP DHCKHJMAAJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<bool> LBGNNDGMODK;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LocalPlayerTakeAuthority();

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void TransferOwnership(int AFFBEBACBJO);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "6")]
	ELBGPJKLPID GetCulprit(ABMMODGFBCM KOBBGNIIMJN);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface AEGMMHLHBIK
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	IEnumerable<DIAKJMHLPDG.CNBEEAJAPEJ> LCCGAFAKENI
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddNavMeshSupportRestriction(DIAKJMHLPDG.CNBEEAJAPEJ HFBGLAALNDK);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveNavMeshSupportRestriction(DIAKJMHLPDG.CNBEEAJAPEJ HFBGLAALNDK);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BJPGOJJNILP
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool BECILGDKKJD
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool AFEKPIPJKII
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PHIJBKIHOGC
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int OGKHJBJKOOL
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderSelection(JCBICDPOMHO? APJLGCAPEAC);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderOutline(MIMGKCKGLLK? AGFAEGAHBBK);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void RenderWorldFadeMask();

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Bounds GetWorldBounds();

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ABMMODGFBCM CanBeSelected();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HCJHEIEPKCA
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool DBPELMCEOCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CostInfo GNLNOHNIFEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool OHKIPIEGJHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool NFBLFBHCLME
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool EOPENKPBPCI
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool NMHGOAACCPF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool GPFLLKFHGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	IEnumerable<Collider> FGIOJHICEKH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	EGNADIPDINI? LNHHGOADIJI
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool AKEGDIGEJED
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool DOPNCOGLMPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GKNLGJKMKBF
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ABMMODGFBCM CanPerformUndoRedoOnObject();

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GetTransformationDataForUndoRedo([Out] Vector3 CJBHLOLHNJP, [Out] Quaternion APMJJPLCLEP, [Out] float HDPLDFIJEFH, [Out] Vector3 GDIANKCANCL);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetTransformationDataForUndoRedo(Vector3? CJBHLOLHNJP, Quaternion? APMJJPLCLEP, float? HDPLDFIJEFH, Vector3? GDIANKCANCL);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KHFLCOAKHEE
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	object EOCMGCHOLMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Type NHIGHHIKBLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	Guid HFIJJEMOFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface JKCKGADIHBA
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	IReadOnlyList<LOJABABHICE> CNEIEJLPIHH
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string JBPKKIJGIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string PANBFKKKFAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool JOKPAMMGCJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<string> KCBNDGGFLLJ;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<JKCKGADIHBA> BOHBAMDCOJP;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<GJDJGKJFGBA, BHFDIGICDID> EJGKOFIMLHD;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action HHHBHEAKMAC;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void Reset();

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ConfigurableWillShow();

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ConfigurableWillHide();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface NNBFJAGDHFH
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool KPFLFAIOLMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct DIAKJMHLPDG
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate CBNBJFJNPBN CNBEEAJAPEJ();

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IEnumerable<CNBEEAJAPEJ> GBMBNBPEPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<CNBEEAJAPEJ> LMFCDCBKNDO;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public IEnumerable<CNBEEAJAPEJ> NDDALGPFEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x61F7F00", Offset = "0x61F7300", VA = "0x1861F7F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x61F7F60", Offset = "0x61F7360", VA = "0x1861F7F60")]
	public void FFIECPFJEFG(CNBEEAJAPEJ HFBGLAALNDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x61F8110", Offset = "0x61F7510", VA = "0x1861F8110")]
	public bool PIABDNKCBCD(CNBEEAJAPEJ HFBGLAALNDK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum CBNBJFJNPBN
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	NotSupported,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Supported
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class GOGBPOPPMHJ
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public const int HHLAIENIFIO = -1;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public const long NCHHDLKLDOC = -1L;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private BABBAHPPGEB<Guid, ObscuredLong, ObscuredInt, ObscuredBool> JELNBELBOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private NIFPANOLJEP<ObscuredBool, ObscuredInt, ObscuredInt> PONCDEIDBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private MonoBehaviourPun KHEIPMEJPAD;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Guid KBDBDHPLGBO
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x61FACC0", Offset = "0x61FA0C0", VA = "0x1861FACC0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public long DLAJHKCLAGC
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x61FA960", Offset = "0x61F9D60", VA = "0x1861FA960")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int PPJFICFIMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x61FAA00", Offset = "0x61F9E00", VA = "0x1861FAA00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool AJDGHGMOCPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x61FB040", Offset = "0x61FA440", VA = "0x1861FB040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool CEAFBJHPDAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x61FA630", Offset = "0x61F9A30", VA = "0x1861FA630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int PBIGFAMMNFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x61FAD30", Offset = "0x61FA130", VA = "0x1861FAD30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int NOPGPICIDOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x61FAA90", Offset = "0x61F9E90", VA = "0x1861FAA90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool NPOPLAGJFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x61FA580", Offset = "0x61F9980", VA = "0x1861FA580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x61FB0D0", Offset = "0x61FA4D0", VA = "0x1861FB0D0")]
	public GOGBPOPPMHJ(MonoBehaviourPun IKLNLNJCNKI, string BNCMOCGDEIC, Guid GCBOHKFDFFM, long LJDMKDEMHNE, int MNGAHPLCIFD, bool LAEBJLKBBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x61FAB20", Offset = "0x61F9F20", VA = "0x1861FAB20")]
	public void KGGACMGLKDM(ELBGPJKLPID OOOINLICBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x61FADC0", Offset = "0x61FA1C0", VA = "0x1861FADC0")]
	public void NGKBDACNDNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x61FA6C0", Offset = "0x61F9AC0", VA = "0x1861FA6C0")]
	public void EOPEJCOCBHD(Guid JEGKOMGHKGI, long LJDMKDEMHNE, int MNGAHPLCIFD, bool LAEBJLKBBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x61FA890", Offset = "0x61F9C90", VA = "0x1861FA890")]
	public void EOPEJCOCBHD(GOGBPOPPMHJ MGDPHHCBMMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x61FA5C0", Offset = "0x61F99C0", VA = "0x1861FA5C0")]
	public void BFEAPNBHLDO(AOKHGHKKKDH FLKOGFDGJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x61FAED0", Offset = "0x61FA2D0", VA = "0x1861FAED0")]
	public void OMGCEOCBFPA(AOKHGHKKKDH FLKOGFDGJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x61FAF80", Offset = "0x61FA380", VA = "0x1861FAF80")]
	public static AOKHGHKKKDH PHHLPGHGKJG(Guid GCBOHKFDFFM, long LJDMKDEMHNE, int BBAMOINJCEM, bool LAEBJLKBBNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class EFNCCBEECGH
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static JGNHMIKEILN<Vector3> KBFCFELAHLO;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static JGNHMIKEILN<Vector3> DAILCPHKCNM;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x61F82B0", Offset = "0x61F76B0", VA = "0x1861F82B0", Slot = "4")]
	protected virtual void GAIFPAAHOLD(Vector3 HDIHDGIKOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x61F8220", Offset = "0x61F7620", VA = "0x1861F8220", Slot = "5")]
	protected virtual void CGKAHAHGOGJ(Vector3 HDIHDGIKOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	protected EFNCCBEECGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal class KDEOIFOBLNC : EFNCCBEECGH
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x61FB410", Offset = "0x61FA810", VA = "0x1861FB410")]
	public void GNNJAILHGJD(Vector3 CJBHLOLHNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x61FB440", Offset = "0x61FA840", VA = "0x1861FB440")]
	public void IOOHHHNNJOM(Vector3 CJBHLOLHNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x61FB470", Offset = "0x61FA870", VA = "0x1861FB470")]
	public KDEOIFOBLNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class GHBIMJMAMGC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static ProfilerMarker MLKPNCEBDKC;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static ProfilerMarker GBGBBJEDFKP;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly string HLNNEAIANIA;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static readonly string CMAKCEKKOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly int[] ADHDOFAJBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly int[] LKHDFOPDOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private GameObject JCGPKHNICCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private MeshCollider KGJKMGDMMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private GameObject KAKOEOMGGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private MeshFilter JJPHKMBAJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private Mesh FHFHPPGIKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private Mesh NMMAABOMDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Collider[] CFFBBCBMGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private List<Collider> GHNFFALPPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private Vector3[] DHKOGGAOODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private Vector3 LCKFKBLDPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Vector3 KNJBLMGDODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Quaternion NKMPLBBHKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private Vector3[] HGCGFKIKBKL;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	private Mesh IAMLNLHCFDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7C1050", Offset = "0x7C0450", VA = "0x1807C1050")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x61F84A0", Offset = "0x61F78A0", VA = "0x1861F84A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	private Mesh HAACBMDOOKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7C4690", Offset = "0x7C3A90", VA = "0x1807C4690")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x61F8D00", Offset = "0x61F8100", VA = "0x1861F8D00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private int HMKOJAGDEFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x61F99C0", Offset = "0x61F8DC0", VA = "0x1861F99C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public IEnumerable<Collider> EJLAPKEFNPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x61F9BE0", Offset = "0x61F8FE0", VA = "0x1861F9BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x61FA0B0", Offset = "0x61F94B0", VA = "0x1861FA0B0")]
	public GHBIMJMAMGC(Material AEGOCCCAMPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x61F8C40", Offset = "0x61F8040", VA = "0x1861F8C40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x61F9BF0", Offset = "0x61F8FF0", VA = "0x1861F9BF0")]
	public void NIIGAECMJIE(Vector2 ONGDAPMKGIG, Vector2 CDFLCOCHCDB, Camera BCFBFBEPKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x61F8C00", Offset = "0x61F8000", VA = "0x1861F8C00")]
	public void DEJBKEDILGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x61F8640", Offset = "0x61F7A40", VA = "0x1861F8640")]
	private IEnumerable<Collider> DBIJMGONLFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x61F84F0", Offset = "0x61F78F0", VA = "0x1861F84F0")]
	private void CBIDBOEJJJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x61F9A80", Offset = "0x61F8E80", VA = "0x1861F9A80")]
	private void MKLMPLJKMDH(Material GDFHEJJFPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x61F95D0", Offset = "0x61F89D0", VA = "0x1861F95D0")]
	private void JCKBIDNPJMC(Vector2 ONGDAPMKGIG, Vector2 CDFLCOCHCDB, Camera BCFBFBEPKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x61F8D50", Offset = "0x61F8150", VA = "0x1861F8D50")]
	private void IFMINBHNLLF(Vector2 ONGDAPMKGIG, Vector2 CDFLCOCHCDB, Camera BCFBFBEPKAI, Vector2 AOENDIKAENK, Vector2 JGJKPEACIBA, Vector3 JAHPFBHLNOL, Vector3 PHDHMIDCIOP, Vector3 KECDOJEFAML, Vector3 NCNJLPOEIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x61F8430", Offset = "0x61F7830", VA = "0x1861F8430")]
	private void AFGIPJCFPGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x61F9C90", Offset = "0x61F9090", VA = "0x1861F9C90")]
	private void NNBMMMKLBMH(Vector3 MOCDFJBOBGD, Vector3 JAHPFBHLNOL, Vector3 PHDHMIDCIOP, Vector3 KECDOJEFAML, Vector3 NCNJLPOEIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x61F99E0", Offset = "0x61F8DE0", VA = "0x1861F99E0")]
	private void LPEMKCOMOBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class PLKNKJEPLAI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KPOJBFCKNEL<T> IECGINIBIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private HOINPDIGOGH<T> INJFKDFHBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<T> ENMJNBPMJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<T> IHLJDDEEGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<T> DIODODMEPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<T> PKGEJNPGFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<T> GDLMAGMCPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<T> FLEPBDGOFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private KELAJFKONGE LFOBHMCPMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private KDEOIFOBLNC FOOBMIENDAI;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x41B64B0", Offset = "0x41B58B0", VA = "0x1841B64B0")]
	public PLKNKJEPLAI(KPOJBFCKNEL<T> IECGINIBIGN, HOINPDIGOGH<T> INJFKDFHBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x41B6150", Offset = "0x41B5550", VA = "0x1841B6150")]
	public void OEBPOHMGJLL(KELAJFKONGE LFOBHMCPMIG = KELAJFKONGE.Add)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x41B4160", Offset = "0x41B3560", VA = "0x1841B4160")]
	public void KLLDNIJKCEE(IEnumerable<Collider> CCPKNDBHHGM, Vector3 BCKAEHMBLFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x41B4040", Offset = "0x41B3440", VA = "0x1841B4040")]
	public bool HKNBLKOKKBA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x41B4110", Offset = "0x41B3510", VA = "0x1841B4110")]
	[CompilerGenerated]
	private bool KGNLLOHECLK(T LCKGOLLEJPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x41B60C0", Offset = "0x41B54C0", VA = "0x1841B60C0")]
	[CompilerGenerated]
	private bool NDIJACEOHGM(T LCKGOLLEJPE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum KELAJFKONGE
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
