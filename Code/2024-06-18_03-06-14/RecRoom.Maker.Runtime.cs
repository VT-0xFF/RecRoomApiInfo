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
		public FNKGBDBKDEI<ConfigurableSubpiece, Collider[], Collider[]> OnCollidersChanged;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MAEDMHJFPLJ IMLKNKEKIDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x84EEA0", Offset = "0x84D8A0", VA = "0x18084EEA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x850E60", Offset = "0x84F860", VA = "0x180850E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Collider[] MIOLDIEFMPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Renderer[] MFCLPMFOFAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<MAEDMHJFPLJ> IJOBMLLBCFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x690B970", Offset = "0x690A370", VA = "0x18690B970")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x690BA20", Offset = "0x690A420", VA = "0x18690BA20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x690B600", Offset = "0x690A000", VA = "0x18690B600")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x690B6B0", Offset = "0x690A0B0", VA = "0x18690B6B0")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x690B720", Offset = "0x690A120", VA = "0x18690B720")]
		public void SetIConfigurable(MAEDMHJFPLJ IOOGKIAGHJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x690B610", Offset = "0x690A010", VA = "0x18690B610")]
		public void ChangeCollidersAndRenderers(Collider[] HAABONHDBKC, Renderer[] HBONBOBGFLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x690B850", Offset = "0x690A250", VA = "0x18690B850")]
		public void ValidateCollidersAndRenderers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x690B700", Offset = "0x690A100", VA = "0x18690B700")]
		public void RunConfigurationSpecialActions(MAEDMHJFPLJ GPGCBJFDNDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x690B8E0", Offset = "0x690A2E0", VA = "0x18690B8E0")]
		public ConfigurableSubpiece()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BKAMANPBKNH
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool PBGNMKBHBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddIsAnimated(object JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveIsAnimated(object JCIFCENKMKP);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface AOPCAFFKLIK
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RegisterConfigurablePiece(ConfigurableSubpiece MAMBMPJAHLP);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void UnregisterConfigurablePiece(ConfigurableSubpiece MAMBMPJAHLP);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ConfigurableSubpiece GetConfigurableSubpiece(Collider ICFPDPJMPEN);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PGGMIBMCDEN
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	GameObject PEPDCAMMCBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Guid DPHPCMKEFGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string JGFOABOCNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string CKPKKNDEHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Vector3 GBLOKAEKGFI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Vector3 ILAABAGNPPN
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Quaternion OKAGPECGPFM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Quaternion MNPKHAFPMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float OKCMJJPFOML
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float EADKAPOFDEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "16")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Vector3 OALBDLEIGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Vector3 NHMPIAMEDMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool FABKNMCMDPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "20")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	MAEDMHJFPLJ IMLKNKEKIDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	NAKOHIAKOGO KCGKMDHDDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action MPEMIMIBOFI;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool CanUpdateDeformation(Vector3 LHKNNBDIELD, float MNHODAHFCIJ, float PILIFPLHGGL);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void UpdateDeformation(Vector3 LHKNNBDIELD, float MNHODAHFCIJ, bool LJGLCIFJFKL, Space OJJOPADGNLJ);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool CanBeRaycasted(Collider ICFPDPJMPEN);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface GFLEEGGHDGA
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool BGAKNJEMIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool FEDPCFELCJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Vector3 CPIBGFFEELP
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Vector3 ODHFLKJPLPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool BOGGPCFDACG
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool IAAALKFAKJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool CHMLHKNJBKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool LBIIEJCDKMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool HKNIAAOPGOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool ACAKFHPMNIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool LILJHFCKEHM
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
	void OnDeformed(Vector3 AMBCLNHELIN);

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
	void OnHoverStart(ELBLCNDCDKC OBIFNJCEHNI, Collider GKKLOBOOLHC, DNBEODICKIK CDLFILCFNOB);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OnHovering(ELBLCNDCDKC OBIFNJCEHNI, Collider GKKLOBOOLHC);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OnHoverFinished(ELBLCNDCDKC OBIFNJCEHNI, CGKDLJPPHGG NAFIGKLDHPO, DNBEODICKIK.MHKEKOFBLAH PJLJPKPKLCB);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void Translate(Vector3 CHHJOHEIGOK);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void Rotate(Quaternion DFCLLMBCEMF);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool Scale(float MCFAHFLECNM);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task DeleteAsync();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BEFAJFEOGPJ
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BCADPNFLALJ([In] Vector3 FLANCHPFPCL, [In] Vector3 NMAFDGGPBKA, Vector3 OMOLADMCKGF, Vector3 GKJCNLBHEIK);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface KACJFMHDDIO
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool LNLDJJEBMFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	NFLEMDIBMBJ PKFNNPKAMBE
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
public interface MNNGEIKFDNA
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool BFEPKLNJBIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	JLDCKHOPBFF GBJMFFIEOFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<bool> FOIEGPCCKKH;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LocalPlayerTakeAuthority();

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void TransferOwnership(int DKAGKGLDBKC);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BMPINIJAIHM GetCulprit(CAGJDFDCDED IBACHNMOBHE);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface OJFHMADHMED
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	IEnumerable<OOFPEMOEHCG.OIGNFCLKLFM> NLODBKLGBHI
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddNavMeshSupportRestriction(OOFPEMOEHCG.OIGNFCLKLFM MCLJDGIMACP);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveNavMeshSupportRestriction(OOFPEMOEHCG.OIGNFCLKLFM MCLJDGIMACP);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CFCMOAKPGIJ
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Reset();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MBPFLKJKHLK
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool NKMCOCCFBFM
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool MPHJAPJGKML
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FAHGELDJFNC
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	int GJBJLDKLCFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderSelection(NNIPIIDFJHC? NHHKIAGJOHG);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderOutline(ALFFGGLLEIB? COJIOHPGJMM);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void RenderWorldFadeMask();

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Bounds GetWorldBounds();

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CAGJDFDCDED CanBeSelected();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MCBFBMGFJPE
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool LINDDMJJFMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	CostInfo FOFFLLAJKGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool BDDDCFANOCK
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool EPEJLFCDDEE
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool JPPFLBEOHIC
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool NIHAAGLCMKI
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool OHPHIOEGEFL
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	IEnumerable<Collider> BLMEACGMAEF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	COLONCFHHMN? LCMLHLOBBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool BBKMEAENNCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool JPFBIDEFMCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LPGMCMHBLFE
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CAGJDFDCDED CanPerformUndoRedoOnObject();

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GetTransformationDataForUndoRedo([Out] Vector3 GLNEOPDBMFP, [Out] Quaternion NGGFFKDNCFB, [Out] float JIKPOHHGNGP, [Out] Vector3 DFMMPOLKPCO);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetTransformationDataForUndoRedo(Vector3? GLNEOPDBMFP, Quaternion? NGGFFKDNCFB, float? JIKPOHHGNGP, Vector3? DFMMPOLKPCO);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface LLPEJNALCDO
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	object ODFCAMDMOFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	Type OHKOPGAMAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	Guid FBBKNFCDKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MAEDMHJFPLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	IReadOnlyList<JCNJAPOHOHC> IJLAGKAAHIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string CKPKKNDEHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	string HHALIEHMBLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool JPOGMMCJBGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<string> DEKCOJGFPKH;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<MAEDMHJFPLJ> LINEHAEGCOD;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<BKHODAKCBAH, FOKCDDLOOPG> GLJHDCFGMHF;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action ABALHIMPGMC;

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
public interface KBKFNOEFPID
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool LFKKHHNDKMH
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
public struct OOFPEMOEHCG
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate IHFMJJLPACJ OIGNFCLKLFM();

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IEnumerable<OIGNFCLKLFM> GGMPBIABCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<OIGNFCLKLFM> NCLKMIEDOHK;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public IEnumerable<OIGNFCLKLFM> MHGLPCHFFNA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x690D050", Offset = "0x690BA50", VA = "0x18690D050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x690D0B0", Offset = "0x690BAB0", VA = "0x18690D0B0")]
	public void KODKNHDNNHA(OIGNFCLKLFM MCLJDGIMACP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x690D260", Offset = "0x690BC60", VA = "0x18690D260")]
	public bool PLMGPBLKDNE(OIGNFCLKLFM MCLJDGIMACP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum IHFMJJLPACJ
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	NotSupported,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Supported
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NAKOHIAKOGO
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public const int BBGFBDEMNNG = -1;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public const long PLADELECGOG = -1L;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private GJGOOFFLNPF<Guid, ObscuredLong, ObscuredInt, ObscuredBool> GPMPGLIKLOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private MLFFKFPELJE<ObscuredBool, ObscuredInt, ObscuredInt> CONKHLLICNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private MonoBehaviourPun BDGKMFGNNGD;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Guid ELOMJOJKIFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x690CC10", Offset = "0x690B610", VA = "0x18690CC10")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public long JLIPMKJBGLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x690CB70", Offset = "0x690B570", VA = "0x18690CB70")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int GMHLEAPPEJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x690C850", Offset = "0x690B250", VA = "0x18690C850")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool BFPICFPONHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x690C1C0", Offset = "0x690ABC0", VA = "0x18690C1C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool NGJNKBHMIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x690C9A0", Offset = "0x690B3A0", VA = "0x18690C9A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int DBKIAHOBBBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x690CAE0", Offset = "0x690B4E0", VA = "0x18690CAE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int PGPBKFBPJKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x690CC80", Offset = "0x690B680", VA = "0x18690CC80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool LJHOEEDDJON
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x690CA30", Offset = "0x690B430", VA = "0x18690CA30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x690CD10", Offset = "0x690B710", VA = "0x18690CD10")]
	public NAKOHIAKOGO(MonoBehaviourPun OMHNCCLHIHL, string JDHLAKCANNP, Guid OAOLLFCEEDM, long IFMLDDBEFLB, int FEAHNFOPCOO, bool IIENDAENBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x690C600", Offset = "0x690B000", VA = "0x18690C600")]
	public void FHALADLMIFH(BMPINIJAIHM ILFDPHECAHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x690C250", Offset = "0x690AC50", VA = "0x18690C250")]
	public void AOKKBIPCKML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x690C360", Offset = "0x690AD60", VA = "0x18690C360")]
	public void CCPNKNOIBEC(Guid JFEPDIKBNBC, long IFMLDDBEFLB, int FEAHNFOPCOO, bool IIENDAENBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x690C530", Offset = "0x690AF30", VA = "0x18690C530")]
	public void CCPNKNOIBEC(NAKOHIAKOGO HENLEJBGFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x690CA70", Offset = "0x690B470", VA = "0x18690CA70")]
	public void KPOMKLANBAP(MDNJAABDKEK EEOBDBMOHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x690C7A0", Offset = "0x690B1A0", VA = "0x18690C7A0")]
	public void GBKHMHAADOL(MDNJAABDKEK EEOBDBMOHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x690C8E0", Offset = "0x690B2E0", VA = "0x18690C8E0")]
	public static MDNJAABDKEK IAONNHNBNGC(Guid OAOLLFCEEDM, long IFMLDDBEFLB, int FKBADGCELEC, bool IIENDAENBAB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct DNBEODICKIK : IEquatable<DNBEODICKIK>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class EMGHDNOOJLA : GDKGCBFKIGB<DNBEODICKIK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public bool DJEJGGIOHNN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x690C080", Offset = "0x690AA80", VA = "0x18690C080")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x690C060", Offset = "0x690AA60", VA = "0x18690C060")]
		public bool HNMPMBCBEHF(CGKDLJPPHGG NJJIPPECHNC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x690BFA0", Offset = "0x690A9A0", VA = "0x18690BFA0")]
		public DNBEODICKIK AEKHKHIOLEN(CGKDLJPPHGG NJJIPPECHNC)
		{
			return default(DNBEODICKIK);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x690C0C0", Offset = "0x690AAC0", VA = "0x18690C0C0")]
		private int KPIFIKFEKIA(CGKDLJPPHGG NJJIPPECHNC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x690C180", Offset = "0x690AB80", VA = "0x18690C180")]
		public EMGHDNOOJLA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public enum AIFAGFGMLNC
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
	public enum MHKEKOFBLAH
	{
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		TARGETED_OBJECT,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		ALL_UNDER_ROOT_CONNECTABLE
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly DNBEODICKIK MBMKGOAKDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly AIFAGFGMLNC NPDKMGOOEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly CGKDLJPPHGG IHGKOFGJKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly MHKEKOFBLAH OLNMECBPMFH;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x690BF90", Offset = "0x690A990", VA = "0x18690BF90")]
	public DNBEODICKIK(CGKDLJPPHGG NJJIPPECHNC, AIFAGFGMLNC AJDJDACIIPE = AIFAGFGMLNC.UgcGameplaySystem, MHKEKOFBLAH MBMNLIPEPEP = MHKEKOFBLAH.TARGETED_OBJECT)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x690BED0", Offset = "0x690A8D0", VA = "0x18690BED0")]
	public static bool IKJGJDJDJIH(DNBEODICKIK GDMICPKKGFK, DNBEODICKIK JCAJPPHEFGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x690BDA0", Offset = "0x690A7A0", VA = "0x18690BDA0", Slot = "4")]
	public bool Equals(DNBEODICKIK HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x690BCE0", Offset = "0x690A6E0", VA = "0x18690BCE0", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x690BE50", Offset = "0x690A850", VA = "0x18690BE50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface JGCBFJNPOBL
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RequestStartOutlining(DNBEODICKIK BJLMEIJMPBN);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RequestStopOutlining(CGKDLJPPHGG NJJIPPECHNC, DNBEODICKIK.MHKEKOFBLAH MBMNLIPEPEP);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class DKDFKENJMGD
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static FCOLMBOCIND<Vector3> LNPGGMEFDGJ;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static FCOLMBOCIND<Vector3> PAGHLBAFAAL;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x690BAD0", Offset = "0x690A4D0", VA = "0x18690BAD0", Slot = "4")]
	protected virtual void FGOPLGFNMCK(Vector3 LDMCBJPLJPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x690BB60", Offset = "0x690A560", VA = "0x18690BB60", Slot = "5")]
	protected virtual void IOECDKAINAG(Vector3 LDMCBJPLJPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	protected DKDFKENJMGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class AAKJCAOECBO : DKDFKENJMGD
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x690B580", Offset = "0x6909F80", VA = "0x18690B580")]
	public void MACDILBGODK(Vector3 GLNEOPDBMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x690B550", Offset = "0x6909F50", VA = "0x18690B550")]
	public void ENJAECPIAHG(Vector3 GLNEOPDBMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x690B5B0", Offset = "0x6909FB0", VA = "0x18690B5B0")]
	public AAKJCAOECBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class PFCIKMKJKHH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static ProfilerMarker NGKDIBGLEJJ;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static ProfilerMarker PCDKDLLOIKC;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly string LNMMMHLMCBH;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static readonly string OMGDBKNAMGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly int[] MHCPJPGHNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly int[] MBIOJJKNIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject MAHBBHMIKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private MeshCollider ALKAOFDHGLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private GameObject HEPGPGIJEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private MeshFilter EIHFLNBKKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Mesh ONJGLBEFICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private Mesh PJCGMMGDMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Collider[] PCIKGGGDJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<Collider> GOMAFLBKJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private Vector3[] CDJBAPIBEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private Vector3 LAKHCNIGHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Vector3 LCLNAKOLNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Quaternion KBDLLFHEIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Vector3[] OLOAPPOJFFN;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private Mesh EHJLPOKIDDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x84FE00", Offset = "0x84E800", VA = "0x18084FE00")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x690EE10", Offset = "0x690D810", VA = "0x18690EE10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private Mesh PECIALAKKGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x84EEB0", Offset = "0x84D8B0", VA = "0x18084EEB0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x690D370", Offset = "0x690BD70", VA = "0x18690D370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private int NDKPKFHBFBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x690E830", Offset = "0x690D230", VA = "0x18690E830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public IEnumerable<Collider> NKPKMAMPNMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x690D400", Offset = "0x690BE00", VA = "0x18690D400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x690EFF0", Offset = "0x690D9F0", VA = "0x18690EFF0")]
	public PFCIKMKJKHH(Material ADOCNNEFCMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x690DC90", Offset = "0x690C690", VA = "0x18690DC90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x690E300", Offset = "0x690CD00", VA = "0x18690E300")]
	public void JDLOLAMJEBK(Vector2 HLHBNPFHNDP, Vector2 GIEINMCBGED, Camera HGOCAPKHKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x690D3C0", Offset = "0x690BDC0", VA = "0x18690D3C0")]
	public void ADENNKOHINC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x690E850", Offset = "0x690D250", VA = "0x18690E850")]
	private IEnumerable<Collider> MFJFOFOLMCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x690E050", Offset = "0x690CA50", VA = "0x18690E050")]
	private void GGLJMHJPNLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x690E1A0", Offset = "0x690CBA0", VA = "0x18690E1A0")]
	private void IPNEAGDLFKL(Material OKNIOBAOHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x690E440", Offset = "0x690CE40", VA = "0x18690E440")]
	private void JHGNMMKLFAL(Vector2 HLHBNPFHNDP, Vector2 GIEINMCBGED, Camera HGOCAPKHKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x690D410", Offset = "0x690BE10", VA = "0x18690D410")]
	private void BNGENCLMAIH(Vector2 HLHBNPFHNDP, Vector2 GIEINMCBGED, Camera HGOCAPKHKNC, Vector2 CKIEFOHOIFK, Vector2 MFONJNOPJNN, Vector3 BPPKIJIDLPG, Vector3 LEPKPNHLFDN, Vector3 AFJGELHPPKN, Vector3 EGEDPBNKHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x690EE60", Offset = "0x690D860", VA = "0x18690EE60")]
	private void PHDGNDLLADO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x690DD50", Offset = "0x690C750", VA = "0x18690DD50")]
	private void EDNFPHJENIO(Vector3 JINNEAJONOJ, Vector3 BPPKIJIDLPG, Vector3 LEPKPNHLFDN, Vector3 AFJGELHPPKN, Vector3 EGEDPBNKHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x690E3A0", Offset = "0x690CDA0", VA = "0x18690E3A0")]
	private void JGJMJEOIPAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class PCBGIHFLNIE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private AKIDBPAOKDO<T> MCOHAADPGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private BGJNKPHCCJB<T> FAHIHBDIIJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private List<T> FKDJPHOHBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private List<T> GNBAPOEHNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private List<T> FBJCFEJHOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private List<T> BLGEFHNNFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private List<T> BILJPGBNDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private List<T> DBAELPDEHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private OOCCHLKAMEP MBMNLIPEPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private AAKJCAOECBO NEKKFDILHJN;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x46B8B30", Offset = "0x46B7530", VA = "0x1846B8B30")]
	public PCBGIHFLNIE(AKIDBPAOKDO<T> MCOHAADPGLP, BGJNKPHCCJB<T> FAHIHBDIIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x46B6420", Offset = "0x46B4E20", VA = "0x1846B6420")]
	public void FNEPMCHENFK(OOCCHLKAMEP MBMNLIPEPEP = OOCCHLKAMEP.Add)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x46B6680", Offset = "0x46B5080", VA = "0x1846B6680")]
	public void MMJBKIOIMDN(IEnumerable<Collider> LDKIAFEGLJN, Vector3 PHLEMAKHFDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x46B6510", Offset = "0x46B4F10", VA = "0x1846B6510")]
	public bool HHKNHPMDNPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x46B6370", Offset = "0x46B4D70", VA = "0x1846B6370")]
	[CompilerGenerated]
	private bool ACLNMGONGHF(T PHDMOAMCFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x46B65D0", Offset = "0x46B4FD0", VA = "0x1846B65D0")]
	[CompilerGenerated]
	private bool MEBCCOCICGI(T PHDMOAMCFBE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum OOCCHLKAMEP
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
