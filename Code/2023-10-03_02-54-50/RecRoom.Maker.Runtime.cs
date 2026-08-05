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
		public FFKBLJBPHHC<ConfigurableSubpiece, Collider[], Collider[]> OnCollidersChanged;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public AJKBMLEHONI FPCGOPFCPBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x762D60", Offset = "0x761560", VA = "0x180762D60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x76B2A0", Offset = "0x769AA0", VA = "0x18076B2A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Collider[] JFKHPHDJOEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Renderer[] PBOEIMHPFHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x765E50", Offset = "0x764650", VA = "0x180765E50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<AJKBMLEHONI> CCNEMKJOIHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x5CCB650", Offset = "0x5CC9E50", VA = "0x185CCB650")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x5CCB700", Offset = "0x5CC9F00", VA = "0x185CCB700")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5CCB2E0", Offset = "0x5CC9AE0", VA = "0x185CCB2E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5CCB390", Offset = "0x5CC9B90", VA = "0x185CCB390")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5CCB400", Offset = "0x5CC9C00", VA = "0x185CCB400")]
		public void SetIConfigurable(AJKBMLEHONI MGEOIDCIHKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5CCB2F0", Offset = "0x5CC9AF0", VA = "0x185CCB2F0")]
		public void ChangeCollidersAndRenderers(Collider[] FIOFPPFCCOE, Renderer[] OBBDICBHHDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5CCB530", Offset = "0x5CC9D30", VA = "0x185CCB530")]
		public void ValidateCollidersAndRenderers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5CCB3E0", Offset = "0x5CC9BE0", VA = "0x185CCB3E0")]
		public void RunConfigurationSpecialActions(AJKBMLEHONI OBJCLIGCPAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5CCB5C0", Offset = "0x5CC9DC0", VA = "0x185CCB5C0")]
		public ConfigurableSubpiece()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AMGAIAGIEIP
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool PNGDFHFLAOM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddIsAnimated(object PIPCHJCEPPJ);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveIsAnimated(object PIPCHJCEPPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BDOCIMDGEFF
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RegisterConfigurablePiece(ConfigurableSubpiece LIFLMBPCANA);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void UnregisterConfigurablePiece(ConfigurableSubpiece LIFLMBPCANA);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ConfigurableSubpiece GetConfigurableSubpiece(Collider AFMGELLDLJH);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface IGMIBBKDPAF
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	GameObject PEDNOCPEPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Guid CPILNHHPFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string MJLCABAKOPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string BKDPAKHEKAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Vector3 ECMBGLIHDHE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Vector3 DHKCHGJHBAM
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Quaternion AMGJFKEDOLG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float KOGDMHCCGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float LDJBFELLNKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Vector3 KDANMFMGHIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Vector3 LLBIJMADHKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "16")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool MBDJHOCKAED
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	AJKBMLEHONI FPCGOPFCPBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	MIOINPGKHDO HOJPDAEOFKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action MOPDEKOKDCG;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "20")]
	bool CanUpdateDeformation(Vector3 JOJCMNCCFCK, float HFGKPMOFCCA, float PEENONLEIEI);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void UpdateDeformation(Vector3 JOJCMNCCFCK, float HFGKPMOFCCA);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool CanBeRaycasted(Collider AFMGELLDLJH);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DGKAJJFAGNL
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool AJEMEOAMLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool JLKPKCPEMNC
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	Vector3 CDJNFNHOAJI
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Vector3 EKCOBBJNLJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool DMNBHNKPJBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool NNJIFLBLPON
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool IALLKMPJPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool OHDCKCINFNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool IILPKDCFLAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool NEABOILOIEK
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
	void OnDeformed(Vector3 BNINODEKLFF);

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
	void OnHoverStart(NGKNDOONIKN GLMMCHDMFOG, Collider BKEKMBOGLHH);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OnHovering(NGKNDOONIKN GLMMCHDMFOG, Collider BKEKMBOGLHH);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OnHoverFinished(NGKNDOONIKN GLMMCHDMFOG);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void Translate(Vector3 BEHFKHHDBHO);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void Rotate(Quaternion MIAHJOAOGJL);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool Scale(float IAKMCFMIMFD);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Task DeleteAsync();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface NIOBFPNAKIG
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EOAENMABCGP([In] Vector3 JAKDKBMGPIO, [In] Vector3 CFFFGOJOPLK, Vector3 HCELIOKKCLG, Vector3 HOBKDEMPIOI);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface FANIICJOBOL
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool NNNGHBDDMPM
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	EHNBFHMIMBB BJLKGBEBBEN
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
public interface GMOFKFGJOHI
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool PNGJAGLLMOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	HCILHJBNFAI GFCAJCLEPKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<bool> KDPMGALIGLJ;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LocalPlayerTakeAuthority();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void TransferOwnership(int LDOOBNPNHEP);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GDJKGPKFNNH GetCulprit(PBLPEAFOBEK BELHPKLPDJL);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface APHAGNCJENH
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	IEnumerable<CHOGPABCOOL.AMHDMIKLILF> FGLCEIEKJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddNavMeshSupportRestriction(CHOGPABCOOL.AMHDMIKLILF PDKJJIEIFOH);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveNavMeshSupportRestriction(CHOGPABCOOL.AMHDMIKLILF PDKJJIEIFOH);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface JOIBPGAKNNP
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PEGKIMEHCMF
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool IAHOOCFNBNH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool PBJKPEEFHGL
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DCEELIGBCAB
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	int HMDLAAGDONL
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderSelection(NJNMPGINBDC? DBPNJKCCAGK);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderOutline(PFCOBFLEOJA? JMCPMFFLLGB);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void RenderWorldFadeMask();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Bounds GetWorldBounds();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PBLPEAFOBEK CanBeSelected();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BJKCHGJAAGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool NBFIGDMMFKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	CostInfo CFBNGIFOHGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool JNIEHKJGIDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool HFEHGDDAMJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool MILFFGAMIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool OMAHKHFJEFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool PPKLGCGOILE
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	IEnumerable<Collider> DKEGMCKNPMA
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool FCDCMDHFBJO
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface NNOCDDKFDIO
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PBLPEAFOBEK CanPerformUndoRedoOnObject();

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GetTransformationDataForUndoRedo([Out] Vector3 OBAACBLACLC, [Out] Quaternion AHLHKGGFBGH, [Out] float NOHHHNCLDDC, [Out] Vector3 JLCMCBGIPBN);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetTransformationDataForUndoRedo(Vector3? OBAACBLACLC, Quaternion? AHLHKGGFBGH, float? NOHHHNCLDDC, Vector3? JLCMCBGIPBN);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface IAMMEGELFFI
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	object BIEJABNKBBC
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	Type FMAFLEJBLPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	Guid GAALKJGBMMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface AJKBMLEHONI
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	IReadOnlyList<JGNEIEFAPKK> MJFPAPCCCLE
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	string BKDPAKHEKAN
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	string LHJCEMFNEDI
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool NLJMBAJEDED
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<string> KBCALKLNNGD;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<AJKBMLEHONI> BEIEEIGIDOC;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<EGEPMOBHLNE, GOBKMJEKAEO> FFOKDJCFPGD;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action AEKKGJHLKIC;

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
public interface AABBLKHPCOB
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool FIDLHPKHONE
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
public struct CHOGPABCOOL
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate IGENAJKNIGN AMHDMIKLILF();

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IEnumerable<AMHDMIKLILF> LNBHNKBOPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<AMHDMIKLILF> NBFEEOILCPF;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public IEnumerable<AMHDMIKLILF> JCFDCMHFDNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5CCB1D0", Offset = "0x5CC99D0", VA = "0x185CCB1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5CCAF60", Offset = "0x5CC9760", VA = "0x185CCAF60")]
	public void EIGFNHEIDIC(AMHDMIKLILF PDKJJIEIFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5CCB170", Offset = "0x5CC9970", VA = "0x185CCB170")]
	public bool OICBJJIPNIH(AMHDMIKLILF PDKJJIEIFOH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum IGENAJKNIGN
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	NotSupported,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Supported
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum HNBHOCADPNH
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	NavMeshGenerator,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	NavMeshIgnored,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	NavMeshBlocker
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class MIOINPGKHDO
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int EJNMEJKBIFJ = -1;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const long DINIDHPLFGP = -1L;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private MNEMJAPJPPC<Guid, ObscuredLong, ObscuredInt, ObscuredBool> LJDFLFBFDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private MIFFDIPOHPD<ObscuredBool, ObscuredInt, ObscuredInt> AJOJMECIKAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private MonoBehaviourPun HAOAMPANBIL;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Guid BJDJOLFPPJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5CCB7F0", Offset = "0x5CC9FF0", VA = "0x185CCB7F0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public long OHCALKLDDHP
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5CCB860", Offset = "0x5CCA060", VA = "0x185CCB860")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int BAHAKJBOLFM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5CCBB30", Offset = "0x5CCA330", VA = "0x185CCBB30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool IKIEDOKNMPO
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5CCBAA0", Offset = "0x5CCA2A0", VA = "0x185CCBAA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool HCPHALAPFMA
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5CCBCD0", Offset = "0x5CCA4D0", VA = "0x185CCBCD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int ADHPGGFJHPK
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5CCBF10", Offset = "0x5CCA710", VA = "0x185CCBF10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int JMKJLCABEEM
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5CCBE10", Offset = "0x5CCA610", VA = "0x185CCBE10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool ICFKAPAPLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5CCB7B0", Offset = "0x5CC9FB0", VA = "0x185CCB7B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC2F0", Offset = "0x5CCAAF0", VA = "0x185CCC2F0")]
	public MIOINPGKHDO(MonoBehaviourPun EGBGNCBJMNO, string BOIJBCNCJFK, Guid DIPFPLILPPJ, long POLEJMIAMOO, int GGBHIHJCNHB, bool LAALHKCNCIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5CCB900", Offset = "0x5CCA100", VA = "0x185CCB900")]
	public void BEOLIIBBEPL(GDJKGPKFNNH FHGPIHIHNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5CCBBC0", Offset = "0x5CCA3C0", VA = "0x185CCBBC0")]
	public void DJHOHAEIIAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC060", Offset = "0x5CCA860", VA = "0x185CCC060")]
	public void MJKJMKCCJMD(Guid GOCMJBHDPGA, long POLEJMIAMOO, int GGBHIHJCNHB, bool LAALHKCNCIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC220", Offset = "0x5CCAA20", VA = "0x185CCC220")]
	public void MJKJMKCCJMD(MIOINPGKHDO GHNNCJBDHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5CCBEA0", Offset = "0x5CCA6A0", VA = "0x185CCBEA0")]
	public void HJPEKGODAGB(OGCIKENCAGE KOIMDAJNDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5CCBD60", Offset = "0x5CCA560", VA = "0x185CCBD60")]
	public void HHACJKMOLIF(OGCIKENCAGE KOIMDAJNDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5CCBFA0", Offset = "0x5CCA7A0", VA = "0x185CCBFA0")]
	public static OGCIKENCAGE KPHFEFKGOKG(Guid DIPFPLILPPJ, long POLEJMIAMOO, int HBDJPOAJHAG, bool LAALHKCNCIM)
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
