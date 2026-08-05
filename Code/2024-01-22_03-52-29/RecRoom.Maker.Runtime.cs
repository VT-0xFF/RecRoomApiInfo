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
		public BJLFCGIDNLA<ConfigurableSubpiece, Collider[], Collider[]> OnCollidersChanged;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public ELNICGAAEDM APOHEKLDGDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x793FD0", Offset = "0x7933D0", VA = "0x180793FD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x796860", Offset = "0x795C60", VA = "0x180796860")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Collider[] LCHIMHIBJJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Renderer[] FOMNMHODBON
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x796850", Offset = "0x795C50", VA = "0x180796850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<ELNICGAAEDM> MPOJMOPGOAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x603F6A0", Offset = "0x603EAA0", VA = "0x18603F6A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x603F750", Offset = "0x603EB50", VA = "0x18603F750")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x603F330", Offset = "0x603E730", VA = "0x18603F330")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x603F3E0", Offset = "0x603E7E0", VA = "0x18603F3E0")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x603F450", Offset = "0x603E850", VA = "0x18603F450")]
		public void SetIConfigurable(ELNICGAAEDM BJLMCHGAGBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x603F340", Offset = "0x603E740", VA = "0x18603F340")]
		public void ChangeCollidersAndRenderers(Collider[] FINDHHHNOGN, Renderer[] HLONMNEDDJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x603F580", Offset = "0x603E980", VA = "0x18603F580")]
		public void ValidateCollidersAndRenderers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x603F430", Offset = "0x603E830", VA = "0x18603F430")]
		public void RunConfigurationSpecialActions(ELNICGAAEDM NNPJNAMPBIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x603F610", Offset = "0x603EA10", VA = "0x18603F610")]
		public ConfigurableSubpiece()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GMEPNHIDMEG
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool HCBIDDNKENE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddIsAnimated(object KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveIsAnimated(object KNOHBODGPLL);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface MEPEMAFNFNI
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RegisterConfigurablePiece(ConfigurableSubpiece EONFHMPALPD);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void UnregisterConfigurablePiece(ConfigurableSubpiece EONFHMPALPD);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ConfigurableSubpiece GetConfigurableSubpiece(Collider OHBBEBBKENI);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface ODIPJJDABAL
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	GameObject KEAFFOELAKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Guid JFMNIEAKDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string DACJMNMHBIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string APKKOMLGHIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Vector3 LMCJEHOICMG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Vector3 IIMAAFEMNON
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Quaternion OENBJJAECOH
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Quaternion NEELOJMOJMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float LHMKDCAJKCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float ILNIKCAKDPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "16")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Vector3 BBBPELJDMBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Vector3 NMENJGGJMAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool HHCFALFDKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "20")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	ELNICGAAEDM APOHEKLDGDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	OKCELNHIBIG IFJMDFHMPDG
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action PCKKMDCBEPK;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool CanUpdateDeformation(Vector3 IAPBLBIODAG, float KBBCDHJOCNK, float GCCJLMIHLGH);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void UpdateDeformation(Vector3 IAPBLBIODAG, float KBBCDHJOCNK, bool BGCNIECHHAM, Space MFLONLJEIJP);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool CanBeRaycasted(Collider OHBBEBBKENI);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface GKOPAIMFPGE
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool CMLMNKCPIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool MKBFOIELHMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Vector3 CBPLJFNHEMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Vector3 DBBGDNPBFNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool OBFBGCGDAFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool HPHKEIMKKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool BDGGGEIBJPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool IPBLLKLAHEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool DFCLEKBBINI
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool BABGDPOPFFD
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
	void OnDeformed(Vector3 CIOOAMBPBED);

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
	void OnHoverStart(JFBHHNKHEEC CONNFNFBPCF, Collider JFKHHGKNLJJ);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OnHovering(JFBHHNKHEEC CONNFNFBPCF, Collider JFKHHGKNLJJ);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OnHoverFinished(JFBHHNKHEEC CONNFNFBPCF);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void Translate(Vector3 PODFKMBFNIC);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void Rotate(Quaternion MOODICKDKEB);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool Scale(float GLJGILHBCKJ);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Task DeleteAsync();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface OPJIBCNNBHO
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GDHBGJFLFOH([In] Vector3 KNAFBGNLKFP, [In] Vector3 PLJNLCOFMBP, Vector3 IJDIINJHCGJ, Vector3 KELADLMJIOC);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface FBPPGJAILEA
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool MGINDFCKMDL
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	GDJEDKCANMC PJDONEBFEKE
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
public interface HNLBAKFABDG
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool EKIAPAMMDOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	JNAHCDNJKIM PPCOIFMHDAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<bool> COPAEGLNKFG;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LocalPlayerTakeAuthority();

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void TransferOwnership(int MACICHEHEJN);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DHJGGDNNEOH GetCulprit(LNKNLDCMGEE INGDGJLMPGB);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JEDCHFBIHDG
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	IEnumerable<OJOFFJNLNHN.PAJIBMOKLHH> FLPCKHLCCEE
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddNavMeshSupportRestriction(OJOFFJNLNHN.PAJIBMOKLHH BNAEHBAMMNI);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveNavMeshSupportRestriction(OJOFFJNLNHN.PAJIBMOKLHH BNAEHBAMMNI);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface NLBEEKMEADG
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JBDPNLDDFDN
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool DBEIEKDPJBD
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool GKIHIOBLPNI
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NPMHGPDMLOH
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int LLPCBONNGAP
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderSelection(HAIOPLIDGDM? BNKAGDHPJEH);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderOutline(JABODDDNBPD? LENMFDEEMDE);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void RenderWorldFadeMask();

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Bounds GetWorldBounds();

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LNKNLDCMGEE CanBeSelected();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NNGNNKEADEN
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool LDFBFPBCDLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CostInfo NFFJEIKMLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool MEDABAEHDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool BDJGMPFEHHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool IIPPPDCKKDH
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool LKEKEKEMCCC
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool BECEJKOMBGM
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	IEnumerable<Collider> AEMPCPPONJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	EKAIPMMFMEG? JAKIBMFILCB
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool OAAMFMPIECG
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool BBBPENGCDCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface FDNBMLCCBEE
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LNKNLDCMGEE CanPerformUndoRedoOnObject();

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GetTransformationDataForUndoRedo([Out] Vector3 BCGGHPIMKDA, [Out] Quaternion GIJALKLADPN, [Out] float MHNKIOODGNC, [Out] Vector3 ACILEEBGBOB);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetTransformationDataForUndoRedo(Vector3? BCGGHPIMKDA, Quaternion? GIJALKLADPN, float? MHNKIOODGNC, Vector3? ACILEEBGBOB);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface IOKKLDMGONP
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	object AHKLDKAGGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Type PHFBGMIAOJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	Guid HCPPMDGPLEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface ELNICGAAEDM
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	IReadOnlyList<IAOHPGCCBPG> GAMJBDDLPAI
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string APKKOMLGHIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string CIBCIGLGBJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool FOPNCONIKJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<string> EMEKHNMLOCL;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<ELNICGAAEDM> ENBHAOBDJNO;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<PMDCLIDJILF, LMPEHLKDBLK> GHIKKFLKPGP;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action OJPKILKNIFC;

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
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface BANEGCHKOAK
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool MKCHKCEKGMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct OJOFFJNLNHN
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate HOENKNEHFGC PAJIBMOKLHH();

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IEnumerable<PAJIBMOKLHH> LPICNLDPANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<PAJIBMOKLHH> NBEIMNCIPND;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public IEnumerable<PAJIBMOKLHH> HGIMPLAHLEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x603FCD0", Offset = "0x603F0D0", VA = "0x18603FCD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x603FAC0", Offset = "0x603EEC0", VA = "0x18603FAC0")]
	public void DEAIBIAHPPK(PAJIBMOKLHH BNAEHBAMMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x603FC70", Offset = "0x603F070", VA = "0x18603FC70")]
	public bool FKMFNEFKHJM(PAJIBMOKLHH BNAEHBAMMNI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum HOENKNEHFGC
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	NotSupported,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Supported
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class OKCELNHIBIG
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public const int JBEHGOCDBCD = -1;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public const long LKBCCCGEFNB = -1L;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private JOPPOCIOEJN<Guid, ObscuredLong, ObscuredInt, ObscuredBool> FOJKPFLJIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private FGKCAKGKDEF<ObscuredBool, ObscuredInt, ObscuredInt> PHEOJKKHNGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private MonoBehaviourPun FPABAMILOJM;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Guid AGFDLAONNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x60408B0", Offset = "0x603FCB0", VA = "0x1860408B0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public long NGAMHNAADOB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6040460", Offset = "0x603F860", VA = "0x186040460")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int OOJJHAPMJAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x60402B0", Offset = "0x603F6B0", VA = "0x1860402B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool EJAMFAGGPEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6040500", Offset = "0x603F900", VA = "0x186040500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool ONNNGMAKNCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6040340", Offset = "0x603F740", VA = "0x186040340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int NOOMJMHLFNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x603FE90", Offset = "0x603F290", VA = "0x18603FE90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int JHFHJECMCOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x60403D0", Offset = "0x603F7D0", VA = "0x1860403D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool PEFIJOJLKIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x603FF20", Offset = "0x603F320", VA = "0x18603FF20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6040920", Offset = "0x603FD20", VA = "0x186040920")]
	public OKCELNHIBIG(MonoBehaviourPun GPOPOMGMMDN, string IENIDFBLJEG, Guid BINEJOOJDMC, long MFNILCOKAIK, int GAJFJJPOMNG, bool MGJAHNDKGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x60406A0", Offset = "0x603FAA0", VA = "0x1860406A0")]
	public void NKLEIAOBMNG(DHJGGDNNEOH MEDDPHFDPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6040590", Offset = "0x603F990", VA = "0x186040590")]
	public void NCONEFAFNGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6040030", Offset = "0x603F430", VA = "0x186040030")]
	public void FILODNFGCKM(Guid BFCMGOPBHKN, long MFNILCOKAIK, int GAJFJJPOMNG, bool MGJAHNDKGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x603FF60", Offset = "0x603F360", VA = "0x18603FF60")]
	public void FILODNFGCKM(OKCELNHIBIG JLCJEDAFKJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6040840", Offset = "0x603FC40", VA = "0x186040840")]
	public void OOBIGOHNHDO(IENKNBKNKNM GMLIPIALCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x603FDE0", Offset = "0x603F1E0", VA = "0x18603FDE0")]
	public void DFHKFLNGDJD(IENKNBKNKNM GMLIPIALCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x60401F0", Offset = "0x603F5F0", VA = "0x1860401F0")]
	public static IENKNBKNKNM GEDCENPPEIK(Guid BINEJOOJDMC, long MFNILCOKAIK, int LCKIMELKJLG, bool MGJAHNDKGID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class IMAMAOILCPG
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static NFAKNFEBDCB<Vector3> HGFJHAAOEMG;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static NFAKNFEBDCB<Vector3> ONHMGAIAOAD;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x603F8B0", Offset = "0x603ECB0", VA = "0x18603F8B0", Slot = "4")]
	protected virtual void IMAGCCBNNBD(Vector3 FBCNGLGKHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x603F940", Offset = "0x603ED40", VA = "0x18603F940", Slot = "5")]
	protected virtual void LBHKOMKCAPB(Vector3 FBCNGLGKHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	protected IMAMAOILCPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class EMNKMCOBADF : IMAMAOILCPG
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x603F830", Offset = "0x603EC30", VA = "0x18603F830")]
	public void JHIJDKMLIIL(Vector3 BCGGHPIMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x603F800", Offset = "0x603EC00", VA = "0x18603F800")]
	public void HNHEOLDIGPO(Vector3 BCGGHPIMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x603F860", Offset = "0x603EC60", VA = "0x18603F860")]
	public EMNKMCOBADF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class APJGMAPPCIO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static ProfilerMarker LMJOHCDAJMN;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static ProfilerMarker JOKFDLEBBGJ;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly string AODODHBJCNF;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static readonly string KFHOGACHBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly int[] HOPOKLBKNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly int[] KMGLLAEADHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private GameObject DNNFGCNIBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private MeshCollider IHFAEFDICOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private GameObject OLGHEFAOOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private MeshFilter PCJCKFJAMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private Mesh LCJFKPKFIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private Mesh BDDPBFJAFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Collider[] HBGFEBFLCBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private List<Collider> PDNKBPOMMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private Vector3[] HFENBFLFMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private Vector3 LNEJPMDIOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Vector3 FKBNBKPLIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Quaternion DMAGDKJBMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private Vector3[] NEJMOHPOKFM;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	private Mesh AIEFGKEANHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x793E80", Offset = "0x793280", VA = "0x180793E80")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x603DDC0", Offset = "0x603D1C0", VA = "0x18603DDC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	private Mesh LOKAGHPHEME
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x78F350", Offset = "0x78E750", VA = "0x18078F350")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x603EA80", Offset = "0x603DE80", VA = "0x18603EA80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private int INNLNAAFOOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x603DD90", Offset = "0x603D190", VA = "0x18603DD90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public IEnumerable<Collider> AJHJKLIMMBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x603DDB0", Offset = "0x603D1B0", VA = "0x18603DDB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x603EE60", Offset = "0x603E260", VA = "0x18603EE60")]
	public APJGMAPPCIO(Material BKBFNGBKJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x603D4E0", Offset = "0x603C8E0", VA = "0x18603D4E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x603ECA0", Offset = "0x603E0A0", VA = "0x18603ECA0")]
	public void OHPALHDMILE(Vector2 JIAOGIGCHDE, Vector2 AGBONKKNPBO, Camera KABJBFEEANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x603D790", Offset = "0x603CB90", VA = "0x18603D790")]
	public void HINCCPHMCMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x603D7D0", Offset = "0x603CBD0", VA = "0x18603D7D0")]
	private IEnumerable<Collider> IADDDIGLAHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x603D5A0", Offset = "0x603C9A0", VA = "0x18603D5A0")]
	private void GDECDOHLCMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x603EB40", Offset = "0x603DF40", VA = "0x18603EB40")]
	private void NKEOMONCNNK(Material DELNJNDMHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x603E690", Offset = "0x603DA90", VA = "0x18603E690")]
	private void MHIJHFGJMFA(Vector2 JIAOGIGCHDE, Vector2 AGBONKKNPBO, Camera KABJBFEEANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x603DE10", Offset = "0x603D210", VA = "0x18603DE10")]
	private void LPDMHMPKHKH(Vector2 JIAOGIGCHDE, Vector2 AGBONKKNPBO, Camera KABJBFEEANH, Vector2 ELDJAMBABCH, Vector2 FHCDMIMGICG, Vector3 FHKOPGCFIMO, Vector3 OPDOHBACLCO, Vector3 OALJOPHADKH, Vector3 OLIAJHCFGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x603EAD0", Offset = "0x603DED0", VA = "0x18603EAD0")]
	private void MMOPFFCHOJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x603D1E0", Offset = "0x603C5E0", VA = "0x18603D1E0")]
	private void BDBICCPNDKM(Vector3 DHFKEANCEFA, Vector3 FHKOPGCFIMO, Vector3 OPDOHBACLCO, Vector3 OALJOPHADKH, Vector3 OLIAJHCFGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x603D6F0", Offset = "0x603CAF0", VA = "0x18603D6F0")]
	private void GDHKAEEBCAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class NEBIGEHICBD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private EKCAACGMHMH<T> JKANAFMNLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private AOECNNIECKK<T> AIPGHGKKEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<T> LEOPLIOJKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<T> LPKEMAHOJAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<T> DLAEJLHBBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<T> FLMBAABIEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<T> OFBAOGOALFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<T> KJJKDLLCPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private HMMONDOAPOE PEOLLHJDPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private EMNKMCOBADF HDMDAABNONG;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3E8AE40", Offset = "0x3E8A240", VA = "0x183E8AE40")]
	public NEBIGEHICBD(EKCAACGMHMH<T> JKANAFMNLCL, AOECNNIECKK<T> AIPGHGKKEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3E8AA50", Offset = "0x3E89E50", VA = "0x183E8AA50")]
	public void OFAAPPLMKAM(HMMONDOAPOE PEOLLHJDPED = HMMONDOAPOE.Add)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3E88A60", Offset = "0x3E87E60", VA = "0x183E88A60")]
	public void KGPOAACMMLO(IEnumerable<Collider> CINGMHNBCBN, Vector3 ENEHDNCBDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3E8AB20", Offset = "0x3E89F20", VA = "0x183E8AB20")]
	public bool PLOHHKADBNB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3E88A10", Offset = "0x3E87E10", VA = "0x183E88A10")]
	[CompilerGenerated]
	private bool IFOOKKFNKMN(T FHDILOGEHPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3E8AA00", Offset = "0x3E89E00", VA = "0x183E8AA00")]
	[CompilerGenerated]
	private bool MHCLMJLHFLB(T FHDILOGEHPC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum HMMONDOAPOE
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
