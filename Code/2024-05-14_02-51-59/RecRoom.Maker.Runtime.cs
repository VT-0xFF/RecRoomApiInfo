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
		public CNADDHFABOJ<ConfigurableSubpiece, Collider[], Collider[]> OnCollidersChanged;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public KDCGMMFEMJN NKDHLAKBBAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7C8FA0", Offset = "0x7C79A0", VA = "0x1807C8FA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Collider[] IDEIGFLGFAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Renderer[] CKGNNEHPGLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<KDCGMMFEMJN> LNCFNGHCBCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x637A640", Offset = "0x6379040", VA = "0x18637A640")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x637A6F0", Offset = "0x63790F0", VA = "0x18637A6F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x637A2D0", Offset = "0x6378CD0", VA = "0x18637A2D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x637A380", Offset = "0x6378D80", VA = "0x18637A380")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x637A3F0", Offset = "0x6378DF0", VA = "0x18637A3F0")]
		public void SetIConfigurable(KDCGMMFEMJN GLMJKKKBAHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x637A2E0", Offset = "0x6378CE0", VA = "0x18637A2E0")]
		public void ChangeCollidersAndRenderers(Collider[] CBEPKMKPAEA, Renderer[] ABLCCBMHGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x637A520", Offset = "0x6378F20", VA = "0x18637A520")]
		public void ValidateCollidersAndRenderers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x637A3D0", Offset = "0x6378DD0", VA = "0x18637A3D0")]
		public void RunConfigurationSpecialActions(KDCGMMFEMJN HCOCBEGHAPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x637A5B0", Offset = "0x6378FB0", VA = "0x18637A5B0")]
		public ConfigurableSubpiece()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ALJCDCIOGCP
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KALJGEEGIJD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddIsAnimated(object AIDIDMJCFEK);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveIsAnimated(object AIDIDMJCFEK);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface POPEAGCBJCG
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RegisterConfigurablePiece(ConfigurableSubpiece PEJBOABPEGG);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void UnregisterConfigurablePiece(ConfigurableSubpiece PEJBOABPEGG);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ConfigurableSubpiece GetConfigurableSubpiece(Collider INFBHHFPGMA);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LOMOFPDPEEA
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	GameObject JKMOLLDKDGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Guid IFAIPJCFPEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string HAKLMNHDJOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string GJEBNGLKPLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Vector3 AIBDOKJKNNC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Vector3 BMNHEIGADNE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Quaternion NLDEDKHADKF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Quaternion JGNDFHLFBKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float LKJBPNCMFLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float KCMMJBAEDFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "16")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Vector3 MNFHPJFEFGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Vector3 PJMPDCMGCOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool KMMJJJGFMAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "20")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	KDCGMMFEMJN NKDHLAKBBAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	ELFCEFDMEFA APDPIHAPHEO
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action CPLJLAKDEGK;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool CanUpdateDeformation(Vector3 ECDKKPGCEGO, float AGHEJPLMEBF, float JBMOMFNGHFL);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void UpdateDeformation(Vector3 ECDKKPGCEGO, float AGHEJPLMEBF, bool NEBEHHIIOLG, Space KGCMBNPBJIP);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool CanBeRaycasted(Collider INFBHHFPGMA);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface NGAPKALAMOI
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool JAJMAFCBLNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool KOCKKAMPDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Vector3 MLMIHINFNIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Vector3 CKNPFBJLOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool DGCKPLJBACE
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool JDKHKDKMIAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool PKAJKMDLCHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool CFMLCKJLOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool MPHOPMLHGNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool HFKANKLNFEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool NKHIMBGJMFJ
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
	void OnDeformed(Vector3 FABHADAPPGE);

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
	void OnHoverStart(LLOJAAGNDBH EGECDMMIPAN, Collider MFLCLEJCFEE);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OnHovering(LLOJAAGNDBH EGECDMMIPAN, Collider MFLCLEJCFEE);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OnHoverFinished(LLOJAAGNDBH EGECDMMIPAN);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void Translate(Vector3 DILECGELCEM);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void Rotate(Quaternion NKPGNHIBPCB);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool Scale(float BFAOHJDJGOF);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task DeleteAsync();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface LHMIKOOEFBC
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ALJKMMNIPAF([In] Vector3 FIMOJJMIEFE, [In] Vector3 COKBJHHCBCI, Vector3 HPNIJAIJGDA, Vector3 AMMBIDJOPFP);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface OKKIIJJGLDL
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool BJEMFPLCMGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	DMNFIAAEHEB MNCKDBNOKLG
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
public interface COGOHDINKNL
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool NHICECMLBEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	AFGGGPHFJFK PAHIIHGEDGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<bool> BBGCGEJGAEG;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LocalPlayerTakeAuthority();

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void TransferOwnership(int BNAOIKOKEPN);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HLNBBHAOHIL GetCulprit(CDFKNEFHHIO FJMPENPKIEM);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BMLIDPAMLAB
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	IEnumerable<GFKKHDBGMLN.OMIJDGGCPAL> JNLKLMPGDFF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddNavMeshSupportRestriction(GFKKHDBGMLN.OMIJDGGCPAL JHDJIJNCACJ);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveNavMeshSupportRestriction(GFKKHDBGMLN.OMIJDGGCPAL JHDJIJNCACJ);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface OHPOMOPHILB
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Reset();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MBIPBEOODIP
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool LMPGOMNMKEI
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool ODCINBNOJDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JLHLINHCFJO
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	int PJIFJFHFLPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderSelection(MNMFDBFBFJA? PJOOCJADALP);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderOutline(EFHPIJLIOIK? EJPJPMIOAKL);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void RenderWorldFadeMask();

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Bounds GetWorldBounds();

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CDFKNEFHHIO CanBeSelected();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PFKFMLDHDHN
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool HODGHDMMDCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	CostInfo ABHBBKAPIFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool BOFBJMIDGID
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool GLGDPBCHJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool EJLKJPNFLFN
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool KCHLCDHJAKP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool APGMAGFJADN
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	IEnumerable<Collider> PCCEHHDDGNM
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	ONHIKOIKDEL? CMNNLMAJCGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool BIGDFDOKEGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool HADEJICPFGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MCHDMJMAJLC
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CDFKNEFHHIO CanPerformUndoRedoOnObject();

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GetTransformationDataForUndoRedo([Out] Vector3 DGOJEOCFHHN, [Out] Quaternion DMBBOEJIOJM, [Out] float AGBPONFCCHE, [Out] Vector3 GIJLDCIKHBK);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetTransformationDataForUndoRedo(Vector3? DGOJEOCFHHN, Quaternion? DMBBOEJIOJM, float? AGBPONFCCHE, Vector3? GIJLDCIKHBK);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface BJLJKFGPNII
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	object FDNKIKKLCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	Type FCBKBMBGDOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	Guid CJGDBIHCBKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KDCGMMFEMJN
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	IReadOnlyList<FPABHIKCNHH> CGIAPANKMEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string GJEBNGLKPLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	string KGCOJJBNCMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool PCOPBBJPOGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<string> AHLGNGPPHGM;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<KDCGMMFEMJN> OMIJOCMDBKE;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<PAMKHPJLPJN, EONIJGALLDB> GLHHPIDGGML;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action IJILPGKEENL;

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
public interface NBBCDFKPCDI
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool LOPCBAOOCCC
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
public struct GFKKHDBGMLN
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate GDPCIIDEKGA OMIJDGGCPAL();

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IEnumerable<OMIJDGGCPAL> JAKCLGLDHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<OMIJDGGCPAL> OKLCHJAMJNL;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public IEnumerable<OMIJDGGCPAL> DPLJCJBGKDK
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x637BA50", Offset = "0x637A450", VA = "0x18637BA50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x637B840", Offset = "0x637A240", VA = "0x18637B840")]
	public void BIPEDCDHLGG(OMIJDGGCPAL JHDJIJNCACJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x637BAB0", Offset = "0x637A4B0", VA = "0x18637BAB0")]
	public bool MDELFCPLFEE(OMIJDGGCPAL JHDJIJNCACJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum GDPCIIDEKGA
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	NotSupported,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Supported
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ELFCEFDMEFA
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public const int JGCDKCIPEBM = -1;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public const long MEMOLEJCEFJ = -1L;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private CMHMEDIDAAB<Guid, ObscuredLong, ObscuredInt, ObscuredBool> IBFLAEFHBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private HCHMKAALMJE<ObscuredBool, ObscuredInt, ObscuredInt> AMJODAHCAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private MonoBehaviourPun DLKCOBBNNLG;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Guid CFIJAKBHPDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x637AD60", Offset = "0x6379760", VA = "0x18637AD60")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public long FGJPLJJIOAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x637AC30", Offset = "0x6379630", VA = "0x18637AC30")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int ADBOONFFHEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x637A9B0", Offset = "0x63793B0", VA = "0x18637A9B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool POJOHPDCEIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x637ACD0", Offset = "0x63796D0", VA = "0x18637ACD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool PEDJHJDGNEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x637B210", Offset = "0x6379C10", VA = "0x18637B210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int IHHFKLFBACO
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x637ABA0", Offset = "0x63795A0", VA = "0x18637ABA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int NGEEPBNGAPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x637AEE0", Offset = "0x63798E0", VA = "0x18637AEE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool PLMFBBCFNDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x637AA40", Offset = "0x6379440", VA = "0x18637AA40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x637B500", Offset = "0x6379F00", VA = "0x18637B500")]
	public ELFCEFDMEFA(MonoBehaviourPun IMKBNLHAIJG, string NHLENDFPAHF, Guid NPKDNGPGJAP, long CCLFDAJEBHG, int JOGNDLOEJGN, bool CNFFAIKLIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x637B2A0", Offset = "0x6379CA0", VA = "0x18637B2A0")]
	public void OICINLCLGAC(HLNBBHAOHIL GDGMDEELKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x637ADD0", Offset = "0x63797D0", VA = "0x18637ADD0")]
	public void MHJABFNOMHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x637B040", Offset = "0x6379A40", VA = "0x18637B040")]
	public void MPOMBMILLLK(Guid LBJJBIEIBND, long CCLFDAJEBHG, int JOGNDLOEJGN, bool CNFFAIKLIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x637AF70", Offset = "0x6379970", VA = "0x18637AF70")]
	public void MPOMBMILLLK(ELFCEFDMEFA HKMMPHJFKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x637AA80", Offset = "0x6379480", VA = "0x18637AA80")]
	public void GLBEACFMGJL(LPLPDOALCAL ABDLEBPKDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x637AAF0", Offset = "0x63794F0", VA = "0x18637AAF0")]
	public void IMEEIFPDNMI(LPLPDOALCAL ABDLEBPKDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x637B440", Offset = "0x6379E40", VA = "0x18637B440")]
	public static LPLPDOALCAL PGHGNHLDBII(Guid NPKDNGPGJAP, long CCLFDAJEBHG, int MKEJDCJDCFK, bool CNFFAIKLIDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class DPPLGGHOFID
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static OIEIPJOEPJM<Vector3> HILKINGLCAL;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static OIEIPJOEPJM<Vector3> FBIDGLKEGHE;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x637A7A0", Offset = "0x63791A0", VA = "0x18637A7A0", Slot = "4")]
	protected virtual void BPJGEGJHOAB(Vector3 GGIMDBGEGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x637A830", Offset = "0x6379230", VA = "0x18637A830", Slot = "5")]
	protected virtual void MIAHKFFJCHE(Vector3 GGIMDBGEGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	protected DPPLGGHOFID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class PBHKJBDFBPC : DPPLGGHOFID
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x637BBC0", Offset = "0x637A5C0", VA = "0x18637BBC0")]
	public void FHBBJNLKKIM(Vector3 DGOJEOCFHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x637BBF0", Offset = "0x637A5F0", VA = "0x18637BBF0")]
	public void JEHJCHJNONF(Vector3 DGOJEOCFHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x637BC20", Offset = "0x637A620", VA = "0x18637BC20")]
	public PBHKJBDFBPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class PDKCACNFPBG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static ProfilerMarker JFGLEELOEFJ;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static ProfilerMarker APCOEPKFHPG;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly string FMCDLCGBPDD;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static readonly string FLKPMNKDDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly int[] LAMPOJMAJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly int[] LDFCKEMIMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private GameObject KHIJCKDLMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private MeshCollider HNHOIGGJJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private GameObject CJHKGMFAINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private MeshFilter KDJIIBLAFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private Mesh GFDMJEJEHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private Mesh OEPGMEGPJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Collider[] NJLOBHJOKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private List<Collider> BNCFHBCPMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private Vector3[] KFLCBEKJPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private Vector3 FHFHKABMCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Vector3 BEDIBHIJKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Quaternion ONFKIKMENFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private Vector3[] MDFPHBLBOEC;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	private Mesh AJDDMCABILN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7C5AB0", Offset = "0x7C44B0", VA = "0x1807C5AB0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x637D770", Offset = "0x637C170", VA = "0x18637D770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private Mesh LOLCFPLIPPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C10", Offset = "0x7C8610", VA = "0x1807C9C10")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x637D530", Offset = "0x637BF30", VA = "0x18637D530")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private int IBDJALKGICD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x637BC70", Offset = "0x637A670", VA = "0x18637BC70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public IEnumerable<Collider> LNPCEHIPIAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x637D7C0", Offset = "0x637C1C0", VA = "0x18637D7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x637D8F0", Offset = "0x637C2F0", VA = "0x18637D8F0")]
	public PDKCACNFPBG(Material AILJKCIFPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x637C750", Offset = "0x637B150", VA = "0x18637C750", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x637BD00", Offset = "0x637A700", VA = "0x18637BD00")]
	public void CAJOHBGOBFM(Vector2 PCBDNJDGDKM, Vector2 HOKEBFELLKI, Camera GCCGCHAAJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x637C810", Offset = "0x637B210", VA = "0x18637C810")]
	public void EHAIAKFDOEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x637BDA0", Offset = "0x637A7A0", VA = "0x18637BDA0")]
	private IEnumerable<Collider> CKIGDNKKJAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x637D620", Offset = "0x637C020", VA = "0x18637D620")]
	private void LAIELMCOMEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x637CB50", Offset = "0x637B550", VA = "0x18637CB50")]
	private void FMDALKHELNN(Material FEIOCBKHAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x637C360", Offset = "0x637AD60", VA = "0x18637C360")]
	private void CNJAFJJELII(Vector2 PCBDNJDGDKM, Vector2 HOKEBFELLKI, Camera GCCGCHAAJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x637CCB0", Offset = "0x637B6B0", VA = "0x18637CCB0")]
	private void IKPOAAPJBAD(Vector2 PCBDNJDGDKM, Vector2 HOKEBFELLKI, Camera GCCGCHAAJFL, Vector2 HGJKJNKPLHD, Vector2 IFHCHIOCOEA, Vector3 BKFMOPJCCIE, Vector3 NONJLLAOPAB, Vector3 IGJNDIKPKOB, Vector3 EBJGCJHEDOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x637BC90", Offset = "0x637A690", VA = "0x18637BC90")]
	private void AILCFMDDLPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x637C850", Offset = "0x637B250", VA = "0x18637C850")]
	private void EPJKECLIFFC(Vector3 FNDPJOAACDI, Vector3 BKFMOPJCCIE, Vector3 NONJLLAOPAB, Vector3 IGJNDIKPKOB, Vector3 EBJGCJHEDOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x637D580", Offset = "0x637BF80", VA = "0x18637D580")]
	private void JNHDPAEFDPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class BPKDIGBPJJJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private LCFCCFPKNIL<T> JBJCDBCGKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private JJJDGMGJPFF<T> LCBBPHENILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<T> GOKDHHKNDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<T> OIEMPACHFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<T> MGDBPLFAGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<T> GCGNOALBGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<T> LIEMFKMIDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<T> ADKIBNIJDFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private IBPKNKHGEKD MMMGCOBDJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private PBHKJBDFBPC ELAKLBPHLDF;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4975500", Offset = "0x4973F00", VA = "0x184975500")]
	public BPKDIGBPJJJ(LCFCCFPKNIL<T> JBJCDBCGKFN, JJJDGMGJPFF<T> LCBBPHENILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x49735F0", Offset = "0x4971FF0", VA = "0x1849735F0")]
	public void HBIPAHEJJPN(IBPKNKHGEKD MMMGCOBDJOC = IBPKNKHGEKD.Add)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4973730", Offset = "0x4972130", VA = "0x184973730")]
	public void OLDAFAFLPPC(IEnumerable<Collider> IMPABCHFBFB, Vector3 GKPHENBANLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x49736B0", Offset = "0x49720B0", VA = "0x1849736B0")]
	public bool KCJIAHEHMMJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4973510", Offset = "0x4971F10", VA = "0x184973510")]
	[CompilerGenerated]
	private bool FAFNLIJIPGJ(T HMCMBMJNNLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4973560", Offset = "0x4971F60", VA = "0x184973560")]
	[CompilerGenerated]
	private bool FFALIKEADCJ(T HMCMBMJNNLE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum IBPKNKHGEKD
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
