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
		public NIICELDHKHK<ConfigurableSubpiece, Collider[], Collider[]> OnCollidersChanged;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public GMGKCMPOFBH GGPBOLEEIGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x847480", Offset = "0x845C80", VA = "0x180847480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x84A240", Offset = "0x848A40", VA = "0x18084A240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Collider[] HKEBPKMPJHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Renderer[] KNIKLDIHIKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x84A260", Offset = "0x848A60", VA = "0x18084A260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<GMGKCMPOFBH> COKNEAIIFAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x6895DF0", Offset = "0x68945F0", VA = "0x186895DF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6895EA0", Offset = "0x68946A0", VA = "0x186895EA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6895A80", Offset = "0x6894280", VA = "0x186895A80")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6895B30", Offset = "0x6894330", VA = "0x186895B30")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6895BA0", Offset = "0x68943A0", VA = "0x186895BA0")]
		public void SetIConfigurable(GMGKCMPOFBH NCGNPBCAGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6895A90", Offset = "0x6894290", VA = "0x186895A90")]
		public void ChangeCollidersAndRenderers(Collider[] OKLCEDIJODG, Renderer[] GNMCBKOMIND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6895CD0", Offset = "0x68944D0", VA = "0x186895CD0")]
		public void ValidateCollidersAndRenderers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6895B80", Offset = "0x6894380", VA = "0x186895B80")]
		public void RunConfigurationSpecialActions(GMGKCMPOFBH PDEDJKNDJMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6895D60", Offset = "0x6894560", VA = "0x186895D60")]
		public ConfigurableSubpiece()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DDFOCGMMLJB
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BDFOJMCIAGM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddIsAnimated(object OECMOOGGOOF);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveIsAnimated(object OECMOOGGOOF);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EMPPFMIJAMF
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RegisterConfigurablePiece(ConfigurableSubpiece MGCBOILJMMN);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void UnregisterConfigurablePiece(ConfigurableSubpiece MGCBOILJMMN);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ConfigurableSubpiece GetConfigurableSubpiece(Collider NEBJBGFEICB);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface IBAINFHFPIN
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	GameObject ADPKHONGLGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Guid EHJLDMCJEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string HMPIIAILGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string CKELLNEJDDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Vector3 FMHDCFKEJBE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Vector3 NPNMPABLGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Quaternion FIIADFGBHNE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Quaternion NIILCMPNFAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float LCJAICMGMLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float OAINCPHPOCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "16")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Vector3 IPBCOHHFANP
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Vector3 EONHBJDFCCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool ILGLFNFKNPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "20")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	GMGKCMPOFBH GGPBOLEEIGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	CGEOFHGOLID GGOHKMPCMDK
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action IHEEEDMAHBK;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool CanUpdateDeformation(Vector3 APBHMEIEMNJ, float OBBFHIBDMLL, float CPKMDIPDBGL);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void UpdateDeformation(Vector3 APBHMEIEMNJ, float OBBFHIBDMLL, bool DDJIJAHEGED, Space BFOKAHEPOJJ);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool CanBeRaycasted(Collider NEBJBGFEICB);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MBBEHLAPADH
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool DMKHAMIIJHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool LEEHDCFNHJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Vector3 MCDOPNFCABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Vector3 MBIFCGJAFHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool GLILJBEGBIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool HOHLMAAEKNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool LKELOCOFPBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool KMJAPDPFPPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool DKMFNABICBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool FIGBFCEMHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool MFBBEBLEMNM
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
	void OnDeformed(Vector3 KCPFEJMOFMJ);

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
	void OnHoverStart(HACEHNIFENN JAJMJIBDMBC, Collider CKOEKELFNIE, GAFNHINPLDP JGKPINNMHAK);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OnHovering(HACEHNIFENN JAJMJIBDMBC, Collider CKOEKELFNIE);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OnHoverFinished(HACEHNIFENN JAJMJIBDMBC, PBDHGENIJKH BOOAENFLMIP, GAFNHINPLDP.EKFIEEHCHAE LMFCIOEBMCJ);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void Translate(Vector3 BNINGLJGOBL);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void Rotate(Quaternion LKLHCINEMPK);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool Scale(float FMCCCFIPNDL);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task DeleteAsync();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HBCABKFNNLB
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KBMEBIHLPGG([In] Vector3 KAIFHAHFLAN, [In] Vector3 NHPNENOFEDP, Vector3 DLIPEMJKKBN, Vector3 ANAAMNHLGOD);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface PDFPODLJCNE
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool FEGOCGBHLNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	ADHBKFMFMPL GJBHLCIILDG
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
public interface GNBCCEKKEDN
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool LHBEJAMICCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	HAEDCNFBLNC AGGGOLHEELO
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<bool> PKGEKAHCHIE;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LocalPlayerTakeAuthority();

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void TransferOwnership(int DPGPJHNKANK);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BBLEPGEDBMJ GetCulprit(KNPJGNFFBDI JMNONPPBKAH);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FPFIECHDIIP
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	IEnumerable<BILMDIKFOLC.JAONDGAKFGN> DOJHCLNJLFP
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddNavMeshSupportRestriction(BILMDIKFOLC.JAONDGAKFGN HNMCGBCNFOC);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveNavMeshSupportRestriction(BILMDIKFOLC.JAONDGAKFGN HNMCGBCNFOC);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KHHMLOGDLNL
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Reset();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HDBACBEIONA
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool MDANDGMKAHF
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool MBMECLCALNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HOAIJJIKDNH
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	int LHBECPDFNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderSelection(CLCEIFGJJPL? NAJGKDAAOHF);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderOutline(NIICFFIKABB? DCBFCIHPHNB);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void RenderWorldFadeMask();

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Bounds GetWorldBounds();

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KNPJGNFFBDI CanBeSelected();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PCGGNHCHDHL
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool NFDNFPNKOLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	CostInfo HJCIJHOHPPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool CIOONHNDLBH
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool IHADNGFPLKF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool HBJEHGGBMNH
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool KGPPJPGOOGL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool KJFNDDFJNEG
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	IEnumerable<Collider> DGFMLNNCKCL
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	AAINNCANGFC? CAJPFINHAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool PCNPKKLHABP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool EONPBNLAMFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IDPJGGFDKOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KNPJGNFFBDI CanPerformUndoRedoOnObject();

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GetTransformationDataForUndoRedo([Out] Vector3 GBKEBGLIOFD, [Out] Quaternion LOMIHBHMPMH, [Out] float BLOAELOKEMO, [Out] Vector3 KMKKENMOBDG);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetTransformationDataForUndoRedo(Vector3? GBKEBGLIOFD, Quaternion? LOMIHBHMPMH, float? BLOAELOKEMO, Vector3? KMKKENMOBDG);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface OEGLBKAPILC
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	object IHJMJFMEOLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	Type AIGKCLPGHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	Guid OABJKPDBPDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface GMGKCMPOFBH
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	IReadOnlyList<DPLDBPGBFBG> CCFHIDEPFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string CKELLNEJDDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	string BEOBPODAMAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool CPEGFNCLDBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<string> FPPIHDJBANL;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<GMGKCMPOFBH> IECJCPOIEKF;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<BHHEMLMJIKM, CBEFIILGPLE> ICFODGPLNPD;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action IGLBGCJLEKD;

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
public interface CGEKBAHGDHC
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool OOEBFOFFJOC
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
public struct BILMDIKFOLC
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate JDNFKENIDHI JAONDGAKFGN();

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IEnumerable<JAONDGAKFGN> LHMFJFJJDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<JAONDGAKFGN> PFEKCELKPBI;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public IEnumerable<JAONDGAKFGN> CJJLPBKOOCA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x68948E0", Offset = "0x68930E0", VA = "0x1868948E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6894940", Offset = "0x6893140", VA = "0x186894940")]
	public void CNLMKNIMMKA(JAONDGAKFGN HNMCGBCNFOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6894AF0", Offset = "0x68932F0", VA = "0x186894AF0")]
	public bool GALPDKBCKMP(JAONDGAKFGN HNMCGBCNFOC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum JDNFKENIDHI
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	NotSupported,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Supported
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class CGEOFHGOLID
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public const int PGOEFJOEKJL = -1;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public const long CLPENCBAOCN = -1L;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private JBKBGFHIIPL<Guid, ObscuredLong, ObscuredInt, ObscuredBool> FNNNOAIPFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private HFJNCLGCACN<ObscuredBool, ObscuredInt, ObscuredInt> BBCNLIHFCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private MonoBehaviourPun ECKNMNLLOJH;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Guid JLNFCJLMAGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6895320", Offset = "0x6893B20", VA = "0x186895320")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public long AKALDDOGDDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6895390", Offset = "0x6893B90", VA = "0x186895390")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int EBIJIGKMKDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x68955C0", Offset = "0x6893DC0", VA = "0x1868955C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool FABDFBMNDAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6895430", Offset = "0x6893C30", VA = "0x186895430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool MGMDFMKIPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x68954C0", Offset = "0x6893CC0", VA = "0x1868954C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int AFHICGBFAHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6893830", VA = "0x186895030")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int OELLFHPHJPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6894BF0", Offset = "0x68933F0", VA = "0x186894BF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool INMIOENHCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6895650", Offset = "0x6893E50", VA = "0x186895650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6895740", Offset = "0x6893F40", VA = "0x186895740")]
	public CGEOFHGOLID(MonoBehaviourPun ELDAOJIKEMA, string DMIJFCEBCGG, Guid JDDPCIJLILJ, long DMNHJOOHDEC, int JPGEDHHIMJM, bool FCPFEBAGPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x68950C0", Offset = "0x68938C0", VA = "0x1868950C0")]
	public void ELEOKDIPBCM(BBLEPGEDBMJ EHCLOLGCCBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6894F20", Offset = "0x6893720", VA = "0x186894F20")]
	public void DKGHBBBKLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6894C80", Offset = "0x6893480", VA = "0x186894C80")]
	public void DIHNAABPOCM(Guid DBAEPIGHMHE, long DMNHJOOHDEC, int JPGEDHHIMJM, bool FCPFEBAGPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6894E50", Offset = "0x6893650", VA = "0x186894E50")]
	public void DIHNAABPOCM(CGEOFHGOLID OGFCKBADKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6895550", Offset = "0x6893D50", VA = "0x186895550")]
	public void MOIJMGPHHNB(IKPJBMIDDGN MLKNGAFFKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6895690", Offset = "0x6893E90", VA = "0x186895690")]
	public void PAFEGADIPKO(IKPJBMIDDGN MLKNGAFFKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6895260", Offset = "0x6893A60", VA = "0x186895260")]
	public static IKPJBMIDDGN FJGONOAODDK(Guid JDDPCIJLILJ, long DMNHJOOHDEC, int IGBAAFCGDJG, bool FCPFEBAGPGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct GAFNHINPLDP : IEquatable<GAFNHINPLDP>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class IGJAMGBFNFH : MJNOOFOMMAI<GAFNHINPLDP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public bool HACFJPDLFNP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6896660", Offset = "0x6894E60", VA = "0x186896660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6896580", Offset = "0x6894D80", VA = "0x186896580")]
		public bool GPNJDLJKDDC(PBDHGENIJKH IACMDAPDLIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x68965A0", Offset = "0x6894DA0", VA = "0x1868965A0")]
		public GAFNHINPLDP HMNHLPJJIOM(PBDHGENIJKH IACMDAPDLIE)
		{
			return default(GAFNHINPLDP);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x68964C0", Offset = "0x6894CC0", VA = "0x1868964C0")]
		private int ADAPMFNCKJC(PBDHGENIJKH IACMDAPDLIE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x68966A0", Offset = "0x6894EA0", VA = "0x1868966A0")]
		public IGJAMGBFNFH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public enum BBPMDJBJIGJ
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
	public enum EKFIEEHCHAE
	{
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		TARGETED_OBJECT,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		ALL_UNDER_ROOT_CONNECTABLE
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly GAFNHINPLDP NPCNCPHCLFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly BBPMDJBJIGJ JJBEADNLDFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly PBDHGENIJKH KJLJIDEJNDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly EKFIEEHCHAE MFEKHJJCHEO;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x68964B0", Offset = "0x6894CB0", VA = "0x1868964B0")]
	public GAFNHINPLDP(PBDHGENIJKH IACMDAPDLIE, BBPMDJBJIGJ PNLPPPCKGCA = BBPMDJBJIGJ.UgcGameplaySystem, EKFIEEHCHAE MCJDOPPFHLD = EKFIEEHCHAE.TARGETED_OBJECT)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x68963F0", Offset = "0x6894BF0", VA = "0x1868963F0")]
	public static bool JAJJILMADFD(GAFNHINPLDP NKCCEIKLOPK, GAFNHINPLDP ICPBHPBDLLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x68962C0", Offset = "0x6894AC0", VA = "0x1868962C0", Slot = "4")]
	public bool Equals(GAFNHINPLDP OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6896200", Offset = "0x6894A00", VA = "0x186896200", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6896370", Offset = "0x6894B70", VA = "0x186896370", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface NPPCDHBCLHH
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RequestStartOutlining(GAFNHINPLDP LOGLBHMJLPF);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RequestStopOutlining(PBDHGENIJKH IACMDAPDLIE, GAFNHINPLDP.EKFIEEHCHAE MCJDOPPFHLD);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class FIJBEOFMCKI
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static EPMNOCMNENI<Vector3> MPHFNEJLDOJ;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static EPMNOCMNENI<Vector3> IIPIKPLKGND;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6896090", Offset = "0x6894890", VA = "0x186896090", Slot = "4")]
	protected virtual void IHNGJIGGBMH(Vector3 AEGMBHMIAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6896000", Offset = "0x6894800", VA = "0x186896000", Slot = "5")]
	protected virtual void EAOHJEMIJHI(Vector3 AEGMBHMIAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	protected FIJBEOFMCKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class DGJMDLPPLNE : FIJBEOFMCKI
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6895F80", Offset = "0x6894780", VA = "0x186895F80")]
	public void PFACFBIEBFI(Vector3 GBKEBGLIOFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6895F50", Offset = "0x6894750", VA = "0x186895F50")]
	public void KEBLFJIMKJO(Vector3 GBKEBGLIOFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6895FB0", Offset = "0x68947B0", VA = "0x186895FB0")]
	public DGJMDLPPLNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class OHFDKGLNCJF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static ProfilerMarker BGJDMDFKEBM;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static ProfilerMarker LBBBKLNOMKI;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly string FKOACGCIHNM;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static readonly string LHJPKCNMCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly int[] EJMGCFFCABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly int[] BACFIELGMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject CBIFILIKDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private MeshCollider JGEJCOCAOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private GameObject KGMPBCHBNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private MeshFilter JLGLMMCJGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Mesh JPEECNPPJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private Mesh GKPMDHIBFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Collider[] CDGPMOEIKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<Collider> EJGJICONOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private Vector3[] NKAJIJDEAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private Vector3 LONKAIAMHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Vector3 KFAMGJLGLOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Quaternion NPBOGIICCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Vector3[] HAIJBPIMGFC;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private Mesh CHLHHHGCEFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8472C0", Offset = "0x845AC0", VA = "0x1808472C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6897510", Offset = "0x6895D10", VA = "0x186897510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private Mesh PHBHJBNBENB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8473D0", Offset = "0x845BD0", VA = "0x1808473D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6896ED0", Offset = "0x68956D0", VA = "0x186896ED0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private int AAPJJLGKJEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6896EB0", Offset = "0x68956B0", VA = "0x186896EB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public IEnumerable<Collider> ENANKHLDIFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x68982E0", Offset = "0x6896AE0", VA = "0x1868982E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6898440", Offset = "0x6896C40", VA = "0x186898440")]
	public OHFDKGLNCJF(Material IMEMCOLOKMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6896F20", Offset = "0x6895720", VA = "0x186896F20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6897560", Offset = "0x6895D60", VA = "0x186897560")]
	public void KDBEMHAADHP(Vector2 OGMPABGGIBM, Vector2 NOPAHNGDMFJ, Camera PPBNJJDFPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x68982F0", Offset = "0x6896AF0", VA = "0x1868982F0")]
	public void ONEGKLEDOLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6896780", Offset = "0x6894F80", VA = "0x186896780")]
	private IEnumerable<Collider> BMNAGBHKBIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x68973D0", Offset = "0x6895BD0", VA = "0x1868973D0")]
	private void EPMIJCIAAFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6898180", Offset = "0x6896980", VA = "0x186898180")]
	private void MMEHJCDIPOF(Material CLECAFFDEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6896FE0", Offset = "0x68957E0", VA = "0x186896FE0")]
	private void ELDBJKOFIOE(Vector2 OGMPABGGIBM, Vector2 NOPAHNGDMFJ, Camera PPBNJJDFPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6897600", Offset = "0x6895E00", VA = "0x186897600")]
	private void KDMHFDLEEND(Vector2 OGMPABGGIBM, Vector2 NOPAHNGDMFJ, Camera PPBNJJDFPOP, Vector2 GHPDNJCKBCH, Vector2 FGFJJFIJPKH, Vector3 POPAODGBALE, Vector3 LEEICKBBJPA, Vector3 OEHFKJLKHLB, Vector3 PLMMMALHGDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6896E40", Offset = "0x6895640", VA = "0x186896E40")]
	private void CHKDFEBPHAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6897E80", Offset = "0x6896680", VA = "0x186897E80")]
	private void MJGGJBDEJKO(Vector3 AGBFPFBDAMH, Vector3 POPAODGBALE, Vector3 LEEICKBBJPA, Vector3 OEHFKJLKHLB, Vector3 PLMMMALHGDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x68966E0", Offset = "0x6894EE0", VA = "0x1868966E0")]
	private void BHHKLAKMBAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class LMAHBMFNEAA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private FCEDGCMOODD<T> MNOLADLBGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private DAFJFKILCKJ<T> DJGHHMINHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private List<T> KGPAFPEKCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private List<T> EIBNKBDNIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private List<T> MDNCPNLIJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private List<T> HNBPFANBLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private List<T> IGNICJELPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private List<T> EECJJIBOOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private PGNPGLDIMOL MCJDOPPFHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private DGJMDLPPLNE OKFDIDEPCDC;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x41653E0", Offset = "0x4163BE0", VA = "0x1841653E0")]
	public LMAHBMFNEAA(FCEDGCMOODD<T> MNOLADLBGDM, DAFJFKILCKJ<T> DJGHHMINHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4164FF0", Offset = "0x41637F0", VA = "0x184164FF0")]
	public void PPJONGAFJGD(PGNPGLDIMOL MCJDOPPFHLD = PGNPGLDIMOL.Add)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4163BB0", Offset = "0x41623B0", VA = "0x184163BB0")]
	public void FMKEKDDHIBD(IEnumerable<Collider> OOJECIDIIPG, Vector3 AAPPEDPNMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4164E60", Offset = "0x4163660", VA = "0x184164E60")]
	public bool MPANMOACKNP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4164F90", Offset = "0x4163790", VA = "0x184164F90")]
	[CompilerGenerated]
	private bool OBKPJFGJBGP(T PNGIKMLKECD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4164DA0", Offset = "0x41635A0", VA = "0x184164DA0")]
	[CompilerGenerated]
	private bool MHEOHPJIMOD(T PNGIKMLKECD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum PGNPGLDIMOL
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
