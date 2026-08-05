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
		public KDOKJMBKLDA<ConfigurableSubpiece, Collider[], Collider[]> OnCollidersChanged;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public DAJPPPJNKOO APDBHDOFIGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7CB4E0", Offset = "0x7CA6E0", VA = "0x1807CB4E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7CB500", Offset = "0x7CA700", VA = "0x1807CB500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Collider[] HNGOFKFGNNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Renderer[] OIJFOCAOKGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7CB4C0", Offset = "0x7CA6C0", VA = "0x1807CB4C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<DAJPPPJNKOO> KKFFEAGNLBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x643D870", Offset = "0x643CA70", VA = "0x18643D870")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x643D920", Offset = "0x643CB20", VA = "0x18643D920")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x643D500", Offset = "0x643C700", VA = "0x18643D500")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x643D5B0", Offset = "0x643C7B0", VA = "0x18643D5B0")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x643D620", Offset = "0x643C820", VA = "0x18643D620")]
		public void SetIConfigurable(DAJPPPJNKOO GMOBAHDNMII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x643D510", Offset = "0x643C710", VA = "0x18643D510")]
		public void ChangeCollidersAndRenderers(Collider[] OKKPMLANEFF, Renderer[] KGNKFPFFENF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x643D750", Offset = "0x643C950", VA = "0x18643D750")]
		public void ValidateCollidersAndRenderers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x643D600", Offset = "0x643C800", VA = "0x18643D600")]
		public void RunConfigurationSpecialActions(DAJPPPJNKOO KOCIAEAGKLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x643D7E0", Offset = "0x643C9E0", VA = "0x18643D7E0")]
		public ConfigurableSubpiece()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OPHDCLAPDFL
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LHCHBOJNIGM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddIsAnimated(object CEFPPEHCFCF);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveIsAnimated(object CEFPPEHCFCF);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface COKKOJNIGAI
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RegisterConfigurablePiece(ConfigurableSubpiece PKDAHANHNND);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void UnregisterConfigurablePiece(ConfigurableSubpiece PKDAHANHNND);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ConfigurableSubpiece GetConfigurableSubpiece(Collider MJPKEDNHCHC);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PEPJHBNNAJD
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	GameObject ABFNCMAFNND
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Guid LAJDADPEPCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string KLNBLIAPPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string PMJCLJCBNOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Vector3 MHPPJPHAOIK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Vector3 IKDGFFADEMN
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Quaternion HGAAFJGFGCB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Quaternion MBPJHPHFEML
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float AECLGOKMGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float HGONEJLKJHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "16")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Vector3 DCBDGAPJMBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Vector3 MAFMIKAHEMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool HHPLEHEDFII
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "20")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DAJPPPJNKOO APDBHDOFIGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	HJBNADKIHIA HBIIKMDOIFM
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action AFPJBAPMEDE;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool CanUpdateDeformation(Vector3 ODIOOAGEFPC, float MGMMPEGFPAI, float GBPNJGKBPJO);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void UpdateDeformation(Vector3 ODIOOAGEFPC, float MGMMPEGFPAI, bool GNLLJNHAHIP, Space BJNLKKBNEON);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool CanBeRaycasted(Collider MJPKEDNHCHC);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface JPOKDPNBKBI
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool ICMCJOBFFOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool MAJMAMLANMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Vector3 GNAOBCJKOBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Vector3 MHHLPMOBNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool PFFACKCHFHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool LNBEGNCJAMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool JKNAHMHKOLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool ACGLKPGPCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool ALBGDCPNBHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool BCGJGPNPGJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool KFFAGNHDFEI
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
	void OnDeformed(Vector3 BLLDGBCDDOB);

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
	void OnHoverStart(MDKLHHPMEED HJDAILCBLCE, Collider MGMKJCGNGJJ, FAFCGHMENAI MDMJGJIBAEH);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OnHovering(MDKLHHPMEED HJDAILCBLCE, Collider MGMKJCGNGJJ);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OnHoverFinished(MDKLHHPMEED HJDAILCBLCE, NKJBKLODBOM NEMEBKPAMEF);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void Translate(Vector3 DNDKFHHCNCJ);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void Rotate(Quaternion JIMNKDLAMBP);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool Scale(float ONKBHOLJPKL);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task DeleteAsync();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EOKCFKAJHEH
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LLJNMMFEBHJ([In] Vector3 LEDLONHHKMC, [In] Vector3 GDLGHHBOJHM, Vector3 FKIPEBAIEBN, Vector3 BGIIKDPIDDB);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface EFFHPOHCNDP
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool BOMMNFGODAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IHDMHCMLFDH KBHPJBIHCMO
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
public interface OCFLEGJJGOM
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool HKHEDEOOIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	PELNBMNFBEN KLCHLDHGAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<bool> HNAPFHNIDLP;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LocalPlayerTakeAuthority();

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void TransferOwnership(int CDFICJMMHPE);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FLNPGDCNJNA GetCulprit(ONMHMDCEDHJ AAPJAAPOJKD);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HENABMPDKAP
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	IEnumerable<KCMFGMBNJBO.AOFKOAHKEDD> CMOIECHMGAN
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddNavMeshSupportRestriction(KCMFGMBNJBO.AOFKOAHKEDD POKEGELKHKN);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveNavMeshSupportRestriction(KCMFGMBNJBO.AOFKOAHKEDD POKEGELKHKN);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface OACGOKMOGPM
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Reset();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface ODFEOGOKEND
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool KHGMKLGDOJK
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool GGPNNAHNINE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LAGFEKIECFG
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	int MLKOOGINDAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderSelection(GFBGGLPIGEH? IHEBEMBCGPI);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderOutline(IGEOLMBFFAJ? CLCCJLMKKCB);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void RenderWorldFadeMask();

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Bounds GetWorldBounds();

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ONMHMDCEDHJ CanBeSelected();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LIINEOLBDGH
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool HDOCGFNOIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	CostInfo OPPBIMCAGJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool ODHGIJEEFNA
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool EDFEHOMLDNO
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool MANAJALOIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool NKAGFAGMBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool MNJMIMHNKOO
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	IEnumerable<Collider> NEFLIDNKIFG
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	JKMDBMKKPKN? BALFHAGFFLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool ABDFKMHLGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool DBLKAJBOHBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GKOINJBAFBA
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ONMHMDCEDHJ CanPerformUndoRedoOnObject();

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GetTransformationDataForUndoRedo([Out] Vector3 CAOOPLKANIG, [Out] Quaternion JCCMNAMJFGM, [Out] float MCOIFLBOBBD, [Out] Vector3 LGMHCKLBECD);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetTransformationDataForUndoRedo(Vector3? CAOOPLKANIG, Quaternion? JCCMNAMJFGM, float? MCOIFLBOBBD, Vector3? LGMHCKLBECD);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface CNHBKPGPOBC
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	object LLNNFJDKBEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	Type AFFEPIIOJHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	Guid NODIACELLIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface DAJPPPJNKOO
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	IReadOnlyList<IAOMLMHBAKB> CPCHCFIAEAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string PMJCLJCBNOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	string JLPCIOLHIOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool DOILPLLJOOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<string> OLOIKMCFMHI;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<DAJPPPJNKOO> GICNBPHEGFB;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<IJKJDBOILLJ, HBOBGEOLABK> KPHEOGHPPEJ;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action GKJNAAIPOLO;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void Reset();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ConfigurableWillShow();

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ConfigurableWillHide();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface OBNGCAEACJB
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool JHGFEHCJIKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct KCMFGMBNJBO
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate KNPJOKBKAGE AOFKOAHKEDD();

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IEnumerable<AOFKOAHKEDD> FMGKACJGGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<AOFKOAHKEDD> DABJAOCIJII;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public IEnumerable<AOFKOAHKEDD> ECNLBAJIFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x643EFA0", Offset = "0x643E1A0", VA = "0x18643EFA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x643ED90", Offset = "0x643DF90", VA = "0x18643ED90")]
	public void LGLNKEHGBKE(AOFKOAHKEDD POKEGELKHKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x643ED30", Offset = "0x643DF30", VA = "0x18643ED30")]
	public bool BIFLKBKPGJE(AOFKOAHKEDD POKEGELKHKN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum KNPJOKBKAGE
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	NotSupported,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Supported
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class HJBNADKIHIA
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public const int ONABMOOAJJH = -1;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public const long HCAPMGJJPGO = -1L;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private IGJGEPOMIKN<Guid, ObscuredLong, ObscuredInt, ObscuredBool> CPDBPAIGFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private FJBONIFGAKA<ObscuredBool, ObscuredInt, ObscuredInt> KCCCKJGAGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private MonoBehaviourPun OFDCFOKBLAO;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Guid ONKJAKAAKGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x643E2D0", Offset = "0x643D4D0", VA = "0x18643E2D0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public long PLOCEFJFGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x643E340", Offset = "0x643D540", VA = "0x18643E340")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int NGIIOEAJBON
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x643E8A0", Offset = "0x643DAA0", VA = "0x18643E8A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool IAEBBODPAHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x643E240", Offset = "0x643D440", VA = "0x18643E240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool HGBOFHJECLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x643E670", Offset = "0x643D870", VA = "0x18643E670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int BIJDDLODJFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x643E810", Offset = "0x643DA10", VA = "0x18643E810")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int DKCINIIANOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x643DF10", Offset = "0x643D110", VA = "0x18643DF10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool MNJJMDIEFBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x643E630", Offset = "0x643D830", VA = "0x18643E630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x643E9F0", Offset = "0x643DBF0", VA = "0x18643E9F0")]
	public HJBNADKIHIA(MonoBehaviourPun KDEAADCHIDP, string HMFGGHDLGKO, Guid POFFGAPHGNP, long DABNDFOCNLF, int OPADBJMPMGK, bool JHCHFFBJIGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x643E3E0", Offset = "0x643D5E0", VA = "0x18643E3E0")]
	public void HDFIHENFCFD(FLNPGDCNJNA LGFDMAMPDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x643E700", Offset = "0x643D900", VA = "0x18643E700")]
	public void LDOPPOLGLAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x643E070", Offset = "0x643D270", VA = "0x18643E070")]
	public void CNOOLEDIEBH(Guid DLIFGDPNKCO, long DABNDFOCNLF, int OPADBJMPMGK, bool JHCHFFBJIGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x643DFA0", Offset = "0x643D1A0", VA = "0x18643DFA0")]
	public void CNOOLEDIEBH(HJBNADKIHIA JPLJHFMPDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x643DEA0", Offset = "0x643D0A0", VA = "0x18643DEA0")]
	public void AHGFHLBJEMD(GLKKLFPDMNO JLJKEBMIIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x643E580", Offset = "0x643D780", VA = "0x18643E580")]
	public void IBKBBCMODDA(GLKKLFPDMNO JLJKEBMIIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x643E930", Offset = "0x643DB30", VA = "0x18643E930")]
	public static GLKKLFPDMNO PKIKEDIACIH(Guid POFFGAPHGNP, long DABNDFOCNLF, int BGMNCBPAILA, bool JHCHFFBJIGI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct FAFCGHMENAI : IEquatable<FAFCGHMENAI>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class OBNMJKLGKLL : IAFPHJBKLDL<FAFCGHMENAI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public bool KPPCPAJJDMP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x643F0B0", Offset = "0x643E2B0", VA = "0x18643F0B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x643F0F0", Offset = "0x643E2F0", VA = "0x18643F0F0")]
		public bool CNBNOJHMJPL(NKJBKLODBOM BCKPAFECEMN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x643F1D0", Offset = "0x643E3D0", VA = "0x18643F1D0")]
		public FAFCGHMENAI OFMOHHAMIKD(NKJBKLODBOM BCKPAFECEMN)
		{
			return default(FAFCGHMENAI);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x643F110", Offset = "0x643E310", VA = "0x18643F110")]
		private int GNHBKDMLENO(NKJBKLODBOM BCKPAFECEMN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x643F290", Offset = "0x643E490", VA = "0x18643F290")]
		public OBNMJKLGKLL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public enum FMDDMPPJABM
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
	public enum FLDJOIHEOFD
	{
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		TARGETED_OBJECT,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		ALL_UNDER_ROOT_CONNECTABLE
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly FAFCGHMENAI DGGCANDACIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly FMDDMPPJABM BBINAIMCLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly NKJBKLODBOM IAGLLIKPFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly FLDJOIHEOFD NHOMBPKJMEP;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x643DE90", Offset = "0x643D090", VA = "0x18643DE90")]
	public FAFCGHMENAI(NKJBKLODBOM BCKPAFECEMN, FMDDMPPJABM GMDNJIBGHKH = FMDDMPPJABM.UgcGameplaySystem, FLDJOIHEOFD CKIGLEMFOLA = FLDJOIHEOFD.TARGETED_OBJECT)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x643DDD0", Offset = "0x643CFD0", VA = "0x18643DDD0")]
	public static bool LOAKJDDAMKI(FAFCGHMENAI BPOHBPAMNLC, FAFCGHMENAI NOIIDJMAOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x643DCA0", Offset = "0x643CEA0", VA = "0x18643DCA0", Slot = "4")]
	public bool Equals(FAFCGHMENAI JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x643DBE0", Offset = "0x643CDE0", VA = "0x18643DBE0", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x643DD50", Offset = "0x643CF50", VA = "0x18643DD50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface KILEPHEOAPN
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RequestStartOutlining(FAFCGHMENAI DAFMLJPHFGN);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RequestStopOutlining(NKJBKLODBOM BCKPAFECEMN);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class DCPAKLNLFEC
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static HKGPCDCMJHO<Vector3> GHKDJCDBEHO;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static HKGPCDCMJHO<Vector3> FMICMMFNIJL;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x643D9D0", Offset = "0x643CBD0", VA = "0x18643D9D0", Slot = "4")]
	protected virtual void BMEOOMFPAID(Vector3 FDJJDDDAFJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x643DA60", Offset = "0x643CC60", VA = "0x18643DA60", Slot = "5")]
	protected virtual void KMNAFFKJKLP(Vector3 FDJJDDDAFJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	protected DCPAKLNLFEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class OIPHABECJAL : DCPAKLNLFEC
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x643F300", Offset = "0x643E500", VA = "0x18643F300")]
	public void NJICEIBKECB(Vector3 CAOOPLKANIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x643F2D0", Offset = "0x643E4D0", VA = "0x18643F2D0")]
	public void ALCEACEMLJG(Vector3 CAOOPLKANIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x643F330", Offset = "0x643E530", VA = "0x18643F330")]
	public OIPHABECJAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class BGMFNGGKEAO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static ProfilerMarker IJFLBKCBGKO;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static ProfilerMarker BGGDJCGEGIJ;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly string ICMDIJBPOCJ;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static readonly string DPMHHGLLEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly int[] JDLPLKCHLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly int[] DOHLFGEAFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject AKFKBNPNAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private MeshCollider ABJDGHJDIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private GameObject AGEHGEIHMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private MeshFilter BOGEJAGIJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Mesh BEFBMJHKPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private Mesh LKICFNEHLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Collider[] PMKHLLOOOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<Collider> DPAIAMDMEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private Vector3[] DCLLHLFOBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private Vector3 NBGDCMPOGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Vector3 FAFJGBGECJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Quaternion PDLFNMKNNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Vector3[] BDKJNHPGOEC;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private Mesh KANPLOKPBML
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8A0", Offset = "0x7CDAA0", VA = "0x1807CE8A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x643B3B0", Offset = "0x643A5B0", VA = "0x18643B3B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private Mesh MKHDHDJPMEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7CEA70", Offset = "0x7CDC70", VA = "0x1807CEA70")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x643B400", Offset = "0x643A600", VA = "0x18643B400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private int DIBDNNHNJGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x643BED0", Offset = "0x643B0D0", VA = "0x18643BED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public IEnumerable<Collider> CFMBIEOLHAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x643CF00", Offset = "0x643C100", VA = "0x18643CF00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x643D030", Offset = "0x643C230", VA = "0x18643D030")]
	public BGMFNGGKEAO(Material JFOOPJMNFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x643B5B0", Offset = "0x643A7B0", VA = "0x18643B5B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x643CE60", Offset = "0x643C060", VA = "0x18643CE60")]
	public void PCEMPNICGLJ(Vector2 AFIONFMMGHJ, Vector2 GILGIGICEMB, Camera HGPFGHPKMII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x643B7C0", Offset = "0x643A9C0", VA = "0x18643B7C0")]
	public void FKKKGCPGJEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x643B870", Offset = "0x643AA70", VA = "0x18643B870")]
	private IEnumerable<Collider> HOIMLOPHLJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x643B670", Offset = "0x643A870", VA = "0x18643B670")]
	private void FKGNGFGFLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x643B450", Offset = "0x643A650", VA = "0x18643B450")]
	private void CCJEJFCCJLP(Material OOHAKCENEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x643BEF0", Offset = "0x643B0F0", VA = "0x18643BEF0")]
	private void KBANKDGOHJE(Vector2 AFIONFMMGHJ, Vector2 GILGIGICEMB, Camera HGPFGHPKMII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x643C5E0", Offset = "0x643B7E0", VA = "0x18643C5E0")]
	private void NJILBKLHJDA(Vector2 AFIONFMMGHJ, Vector2 GILGIGICEMB, Camera HGPFGHPKMII, Vector2 DKGPHIDJMDG, Vector2 HFBHJCIAAIA, Vector3 JKOPOFMFAJI, Vector3 IDCDGDBPCOG, Vector3 EAFHPNAGHBL, Vector3 GMFNFOBKBOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x643B800", Offset = "0x643AA00", VA = "0x18643B800")]
	private void FMPKBMICJOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x643C2E0", Offset = "0x643B4E0", VA = "0x18643C2E0")]
	private void KKPHPFGJFGL(Vector3 FAJEIMGFKKK, Vector3 JKOPOFMFAJI, Vector3 IDCDGDBPCOG, Vector3 EAFHPNAGHBL, Vector3 GMFNFOBKBOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x643BE30", Offset = "0x643B030", VA = "0x18643BE30")]
	private void IFHJGJDADBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class HMEJHCFMCIK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private DMJLDOGFCGE<T> BLPHCAPEGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private EBHHADAEKLA<T> OENFBCNONAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private List<T> OEHBAJNJODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private List<T> MLMBMJAEBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private List<T> BLAKAKHPJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private List<T> DPDPOJHDMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private List<T> MDJPHJCEDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private List<T> NNCJDKMEPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private OCHJPFBINHF CKIGLEMFOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private OIPHABECJAL KKGPFHDFOEG;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3A50C20", Offset = "0x3A4FE20", VA = "0x183A50C20")]
	public HMEJHCFMCIK(DMJLDOGFCGE<T> BLPHCAPEGCI, EBHHADAEKLA<T> OENFBCNONAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3A4ED30", Offset = "0x3A4DF30", VA = "0x183A4ED30")]
	public void HHGMBCMBJBG(OCHJPFBINHF CKIGLEMFOLA = OCHJPFBINHF.Add)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3A4EE80", Offset = "0x3A4E080", VA = "0x183A4EE80")]
	public void MFIBBJFOBGI(IEnumerable<Collider> DDLKCLFJKKH, Vector3 COEIAAMNAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3A4ECB0", Offset = "0x3A4DEB0", VA = "0x183A4ECB0")]
	public bool FKAHPEGFLPD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3A4EDF0", Offset = "0x3A4DFF0", VA = "0x183A4EDF0")]
	[CompilerGenerated]
	private bool HJDCONEBMAA(T DCHJALFCEJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3A4EC20", Offset = "0x3A4DE20", VA = "0x183A4EC20")]
	[CompilerGenerated]
	private bool BMCCEECOKFM(T DCHJALFCEJF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum OCHJPFBINHF
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
