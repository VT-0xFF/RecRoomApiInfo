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
		public NLMLNFBKPBM<ConfigurableSubpiece, Collider[], Collider[]> OnCollidersChanged;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public JFNEGGGDMFO KKLNOLKKCDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x865820", Offset = "0x863E20", VA = "0x180865820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x865800", Offset = "0x863E00", VA = "0x180865800")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Collider[] MHGDGPOJCNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Renderer[] BIEADJOIMCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x8657D0", Offset = "0x863DD0", VA = "0x1808657D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<JFNEGGGDMFO> DNDEIFIHENM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x6980D50", Offset = "0x697F350", VA = "0x186980D50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6980E00", Offset = "0x697F400", VA = "0x186980E00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x69809E0", Offset = "0x697EFE0", VA = "0x1869809E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6980A90", Offset = "0x697F090", VA = "0x186980A90")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6980B00", Offset = "0x697F100", VA = "0x186980B00")]
		public void SetIConfigurable(JFNEGGGDMFO BBCNFEFPBGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x69809F0", Offset = "0x697EFF0", VA = "0x1869809F0")]
		public void ChangeCollidersAndRenderers(Collider[] JJBHLABPGGI, Renderer[] CBJEGHKDLGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6980C30", Offset = "0x697F230", VA = "0x186980C30")]
		public void ValidateCollidersAndRenderers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6980AE0", Offset = "0x697F0E0", VA = "0x186980AE0")]
		public void RunConfigurationSpecialActions(JFNEGGGDMFO FMONLLEMLCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6980CC0", Offset = "0x697F2C0", VA = "0x186980CC0")]
		public ConfigurableSubpiece()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OHLCMNNMAMO
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NGDADAFDCMM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddIsAnimated(object OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveIsAnimated(object OEDJKICDDGA);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KFJDBBGCOOG
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RegisterConfigurablePiece(ConfigurableSubpiece BCOBNFACMJB);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void UnregisterConfigurablePiece(ConfigurableSubpiece BCOBNFACMJB);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ConfigurableSubpiece GetConfigurableSubpiece(Collider MKHCKFPAKLI);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MFLBOMLJKAA
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	GameObject CHNINBIEDNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Guid KDEPAELFGEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string CDMBLCLEAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string JBNLNCPKHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Vector3 OFCPGHABHFO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Vector3 ABAOOCCJCCH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Quaternion HEDBLFNKKEE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Quaternion JHHONLHGLCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float HDCDFFDAKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float ENGNAMJBAEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "16")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Vector3 MLAFBKEBELG
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Vector3 DMPBMCJKMEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool GCBFMNJJDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "20")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	JFNEGGGDMFO KKLNOLKKCDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	CBEJMMPOINH PDNKIDAAPAC
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action DCJHJJHEMDH;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool CanUpdateDeformation(Vector3 JJBBBMDABKJ, float DFCDLHJACEO, float MONMJEEENOM);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void UpdateDeformation(Vector3 JJBBBMDABKJ, float DFCDLHJACEO, bool JACEMPGJING, Space DPLJEIGPHDP);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool CanBeRaycasted(Collider MKHCKFPAKLI);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PABLIJLOIJO
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool HJJNGIPIKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool KKDALHKOCKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Vector3 EPAJOHHAIIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Vector3 HPAHEFDOHNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool AJFGCNFELJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool GABPKDNNLBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool ICOLNGENIJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool IOEILCKKALL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool FDDIHMHFJDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool KFFGLPIPNOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool JLIPGHNHINJ
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
	void OnDeformed(Vector3 CHCPDFBHOCC);

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
	void OnHoverStart(HMJGCJEGFLJ JKLALKHMLOO, Collider CMJPFOCDEMC, DBGINDBKFEI JKHKPEGOOLN);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OnHovering(HMJGCJEGFLJ JKLALKHMLOO, Collider CMJPFOCDEMC);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OnHoverFinished(HMJGCJEGFLJ JKLALKHMLOO, AAEGPHPJNLD GMFDKAPFMDL, DBGINDBKFEI.KDNFJJJEOFH PIDJDNHPHCN);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void Translate(Vector3 NLJKKIIIIOB);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void Rotate(Quaternion PGIMFFBFLOE);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool Scale(float BELNDHOBICH);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task DeleteAsync();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface COCHPMGPFOD
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LNKDAPCLMIN([In] Vector3 AKJEKBLKOGB, [In] Vector3 KDJEBHMIDDA, Vector3 LDNNAGOGIAN, Vector3 FFJHDFACBIE);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface KLJGBDCMOIN
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool KIDCPMOIOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	GENPGFDOLOA BKLPNLPHNBD
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
public interface BACFADHIHHE
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool GDDANALAAGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	NLFBEFECILJ FHNMOMFHLNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<bool> NKIIPJPHGCK;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LocalPlayerTakeAuthority();

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void TransferOwnership(int JCDLHBENDAG);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	PFCAGLIFOHP GetCulprit(HAEHEBEENKB GMAHBKAJAJF);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HPPGLPLNJCB
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	IEnumerable<CMIOMHEJALL.OJDCANNNJJC> PNNPDMADAEL
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddNavMeshSupportRestriction(CMIOMHEJALL.OJDCANNNJJC HNDKBGCNMCC);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveNavMeshSupportRestriction(CMIOMHEJALL.OJDCANNNJJC HNDKBGCNMCC);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface OICDEMLJEIO
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Reset();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface EECBDEAAELP
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool GFJIFNKKLPC
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool CAEDFKLKEJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NKECIOFJLOL
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	int NGHEGGPLBPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderSelection(JJCNGLHDEFE? DAOMCGDEKLF);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderOutline(JEPJJIBBHEG? DHLLILNPCMI);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void RenderWorldFadeMask();

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Bounds GetWorldBounds();

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HAEHEBEENKB CanBeSelected();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KNCMHGKHFHO
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool JKOBKJLDCLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	CostInfo APCLAJGACBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool NNPNMPPDFJC
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool MAPNPIOBIEA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool NAMIEBLOCJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool EDIAAACBFNF
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool KLMJJKAHDPO
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool FJFFCEINJGF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	IEnumerable<Collider> NPKANLPNCHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	DPNHHIIECCM? MNIJMDLJPCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool BPHMCCGFBPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool AHMFJJLFMLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DICEJGBDHEP
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HAEHEBEENKB CanPerformUndoRedoOnObject();

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GetTransformationDataForUndoRedo([Out] Vector3 MOIICCIPACK, [Out] Quaternion ADNGPFKNGFI, [Out] float PPHEFDMHCNP, [Out] Vector3 DADJDNECPOL);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetTransformationDataForUndoRedo(Vector3? MOIICCIPACK, Quaternion? ADNGPFKNGFI, float? PPHEFDMHCNP, Vector3? DADJDNECPOL);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface MKPAIHLNLMI
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	object JHGBCOBHHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	Type LKDNFDGBFMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	Guid CLANIHBMOHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface JFNEGGGDMFO
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	IReadOnlyList<LLAMLCOJDFL> FBMPAAHCIGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	string JBNLNCPKHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	string OHCONPPKCNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool DJDJJCHPPBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<string> OOGDHJDJFIN;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<JFNEGGGDMFO> NJBBAOFIBHK;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<FPKECMKPDCI, IFPDIMCANPK> GMCKBBGDKFB;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action PPOLNLGLLCE;

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
public interface KOIDOPPPDFM
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool KLEBEGDOJGO
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
public struct CMIOMHEJALL
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate HPAAKODLDMN OJDCANNNJJC();

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IEnumerable<OJDCANNNJJC> PPMDKAKLFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<OJDCANNNJJC> NKHDLKHIBMI;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public IEnumerable<OJDCANNNJJC> KAHJPLJBCME
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x69808D0", Offset = "0x697EED0", VA = "0x1869808D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6980720", Offset = "0x697ED20", VA = "0x186980720")]
	public void MJFEDCBJOBF(OJDCANNNJJC HNDKBGCNMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x69806C0", Offset = "0x697ECC0", VA = "0x1869806C0")]
	public bool GAGDAFIMOPK(OJDCANNNJJC HNDKBGCNMCC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum HPAAKODLDMN
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	NotSupported,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Supported
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class CBEJMMPOINH
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public const int ACBBJPBGAAE = -1;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public const long JPPNEICJFGN = -1L;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private AKMILAEDBAO<Guid, ObscuredLong, ObscuredInt, ObscuredBool> MBOPPHKDJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private LJIJHHGLDIJ<ObscuredBool, ObscuredInt, ObscuredInt> NLFANFICLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private MonoBehaviourPun BMDINFODMJG;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public Guid MCPNKLFGPPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x697FE20", Offset = "0x697E420", VA = "0x18697FE20")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public long LBKKFMEFIFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6980110", Offset = "0x697E710", VA = "0x186980110")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int JMMLEFFCNDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x69802F0", Offset = "0x697E8F0", VA = "0x1869802F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool MDICKLMGJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x697FC70", Offset = "0x697E270", VA = "0x18697FC70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool BPHLNNBANBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x69801B0", Offset = "0x697E7B0", VA = "0x1869801B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int OFNNEOJGNPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x697FD90", Offset = "0x697E390", VA = "0x18697FD90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int FGEIIBCODBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x697FD00", Offset = "0x697E300", VA = "0x18697FD00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool OGJPFGHPJFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x697FE90", Offset = "0x697E490", VA = "0x18697FE90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6980380", Offset = "0x697E980", VA = "0x186980380")]
	public CBEJMMPOINH(MonoBehaviourPun GDIHFKEHOAN, string CDPKIHMHDME, Guid DOLFAHFBLDK, long ODMJGCOLDFF, int HGNFFPJLHFE, bool BLNDBDBAHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x697F830", Offset = "0x697DE30", VA = "0x18697F830")]
	public void AJCJNLFNBFE(PFCAGLIFOHP LBEJDIHDFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6980000", Offset = "0x697E600", VA = "0x186980000")]
	public void IIIKEACILOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x697FAA0", Offset = "0x697E0A0", VA = "0x18697FAA0")]
	public void BGGINNGCCML(Guid LGAOFLFONCO, long ODMJGCOLDFF, int HGNFFPJLHFE, bool BLNDBDBAHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x697F9D0", Offset = "0x697DFD0", VA = "0x18697F9D0")]
	public void BGGINNGCCML(CBEJMMPOINH LJAAPFIIPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x697FF90", Offset = "0x697E590", VA = "0x18697FF90")]
	public void IBJFNNCLKKN(EHACEGHKJEJ FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6980240", Offset = "0x697E840", VA = "0x186980240")]
	public void LKCMNLEFELF(EHACEGHKJEJ FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x697FED0", Offset = "0x697E4D0", VA = "0x18697FED0")]
	public static EHACEGHKJEJ GCNCBHKKJBB(Guid DOLFAHFBLDK, long ODMJGCOLDFF, int NFNPINODCIB, bool BLNDBDBAHGK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct DBGINDBKFEI : IEquatable<DBGINDBKFEI>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class HMJKOCFKBEG : HBPMCKBOIAG<DBGINDBKFEI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool DFLAHLKBLGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x6981460", Offset = "0x697FA60", VA = "0x186981460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6981380", Offset = "0x697F980", VA = "0x186981380")]
		public bool ALAMNMLOIEA(AAEGPHPJNLD ENJFMBNDCJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x69813A0", Offset = "0x697F9A0", VA = "0x1869813A0")]
		public DBGINDBKFEI ANOHPNLHJFG(AAEGPHPJNLD ENJFMBNDCJI)
		{
			return default(DBGINDBKFEI);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x69814A0", Offset = "0x697FAA0", VA = "0x1869814A0")]
		private int ILKOFOBCCCN(AAEGPHPJNLD ENJFMBNDCJI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6981560", Offset = "0x697FB60", VA = "0x186981560")]
		public HMJKOCFKBEG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public enum LNFFFPFAIEA
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
	public enum KDNFJJJEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		TARGETED_OBJECT,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		ALL_UNDER_ROOT_CONNECTABLE
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly DBGINDBKFEI LCKBDGAEMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly LNFFFPFAIEA FCJPGHMLOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly AAEGPHPJNLD LNHKOPAHDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly KDNFJJJEOFH BDHIHHHPNOP;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6981160", Offset = "0x697F760", VA = "0x186981160")]
	public DBGINDBKFEI(AAEGPHPJNLD ENJFMBNDCJI, LNFFFPFAIEA NPMDLCEJBKO = LNFFFPFAIEA.UgcGameplaySystem, KDNFJJJEOFH LAHMDGOAKPJ = KDNFJJJEOFH.TARGETED_OBJECT)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x69810A0", Offset = "0x697F6A0", VA = "0x1869810A0")]
	public static bool JEKPEIKHIPM(DBGINDBKFEI FAGKOOGCGBH, DBGINDBKFEI HEOHCJKCOLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6980EB0", Offset = "0x697F4B0", VA = "0x186980EB0", Slot = "4")]
	public bool Equals(DBGINDBKFEI LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6980F60", Offset = "0x697F560", VA = "0x186980F60", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6981020", Offset = "0x697F620", VA = "0x186981020", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface CMCCLCCBBGJ
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RequestStartOutlining(DBGINDBKFEI BDMHFDNBPPE);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RequestStopOutlining(AAEGPHPJNLD ENJFMBNDCJI, DBGINDBKFEI.KDNFJJJEOFH LAHMDGOAKPJ);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class FIBHLAGNEHG
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static GFLPBNMBKPD<Vector3> IDJMMFNCELJ;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static GFLPBNMBKPD<Vector3> GMNMKELBFIF;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6981200", Offset = "0x697F800", VA = "0x186981200", Slot = "4")]
	protected virtual void MFGBOBIDKFH(Vector3 DPKNAJEFCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6981170", Offset = "0x697F770", VA = "0x186981170", Slot = "5")]
	protected virtual void DGNJLJAGMOJ(Vector3 DPKNAJEFCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	protected FIBHLAGNEHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class LEDHDNKKOPF : FIBHLAGNEHG
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x69815D0", Offset = "0x697FBD0", VA = "0x1869815D0")]
	public void GCJHEJCKFDB(Vector3 MOIICCIPACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x69815A0", Offset = "0x697FBA0", VA = "0x1869815A0")]
	public void CMLBPMCLMOO(Vector3 MOIICCIPACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6981600", Offset = "0x697FC00", VA = "0x186981600")]
	public LEDHDNKKOPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class LIECOAFOHLB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static ProfilerMarker JLKDHMDLKJK;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static ProfilerMarker GGMBOACFCIM;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly string OGKOMKNHMMB;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static readonly string GBMHABDBBPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly int[] BPIOPKKFHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly int[] FBMNBEPHHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GameObject LDODCDMFKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private MeshCollider PEJLCHJEIBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private GameObject JCCCABKGDLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private MeshFilter HLPPEIIAOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private Mesh EDLPCBJBNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private Mesh PJAONBKJMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Collider[] CGBBILBEPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<Collider> HNACFJPEKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private Vector3[] MEFENLFGABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private Vector3 BKDNMMKPJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Vector3 OONDJGOJOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Quaternion BPLIFOOGDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Vector3[] MFGCPOHHLBC;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private Mesh GMOJNCCDHEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x86DC70", Offset = "0x86C270", VA = "0x18086DC70")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x69830C0", Offset = "0x69816C0", VA = "0x1869830C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Mesh MFAGKAMNIOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8689A0", Offset = "0x866FA0", VA = "0x1808689A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6983070", Offset = "0x6981670", VA = "0x186983070")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private int EODDONLCMNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6982170", Offset = "0x6980770", VA = "0x186982170")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public IEnumerable<Collider> HHNCNHPFDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6981A80", Offset = "0x6980080", VA = "0x186981A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x69832D0", Offset = "0x69818D0", VA = "0x1869832D0")]
	public LIECOAFOHLB(Material EKOJIMNBAND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6981D90", Offset = "0x6980390", VA = "0x186981D90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6983110", Offset = "0x6981710", VA = "0x186983110")]
	public void PPFLMMBFCFI(Vector2 EKOEBGAJMIN, Vector2 OJHIGACEHGG, Camera CMPADPIDKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6981A40", Offset = "0x6980040", VA = "0x186981A40")]
	public void DFAHBMJBDBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6982AB0", Offset = "0x69810B0", VA = "0x186982AB0")]
	private IEnumerable<Collider> LKHDFMGANDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6982020", Offset = "0x6980620", VA = "0x186982020")]
	private void HLKEGKDPBOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6981E50", Offset = "0x6980450", VA = "0x186981E50")]
	private void FECJPJFBHIM(Material EGLABJPOFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6981650", Offset = "0x697FC50", VA = "0x186981650")]
	private void BFCKINNNABG(Vector2 EKOEBGAJMIN, Vector2 OJHIGACEHGG, Camera CMPADPIDKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6982230", Offset = "0x6980830", VA = "0x186982230")]
	private void LHAKJNFHADC(Vector2 EKOEBGAJMIN, Vector2 OJHIGACEHGG, Camera CMPADPIDKEM, Vector2 ENIEOHDEPKI, Vector2 EMEGDDNFLPB, Vector3 HDHMPPADJHP, Vector3 JMPLDNOAODK, Vector3 MEHGAJPJGGI, Vector3 EJNINMGNKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6981FB0", Offset = "0x69805B0", VA = "0x186981FB0")]
	private void FMAJACEAFEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6981A90", Offset = "0x6980090", VA = "0x186981A90")]
	private void DIIEAPPGMDN(Vector3 ILOFKPLBFOK, Vector3 HDHMPPADJHP, Vector3 JMPLDNOAODK, Vector3 MEHGAJPJGGI, Vector3 EJNINMGNKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6982190", Offset = "0x6980790", VA = "0x186982190")]
	private void JKLLPMELBAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class GCBIDIFCAOA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private HCGPOJEACAE<T> IDHMJADHMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private GNMPMJPMBPN<T> OODDGPFKKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private List<T> AOPFFBELAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private List<T> BDHFHNHONBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private List<T> IDEAPKMNNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private List<T> BDGHICIJFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private List<T> PDKFCENENDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private List<T> CGAHPOGGDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private FIMGHMENHOH LAHMDGOAKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private LEDHDNKKOPF FMKGOCKJDGF;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3D12D40", Offset = "0x3D11340", VA = "0x183D12D40")]
	public GCBIDIFCAOA(HCGPOJEACAE<T> IDHMJADHMKI, GNMPMJPMBPN<T> OODDGPFKKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3D103C0", Offset = "0x3D0E9C0", VA = "0x183D103C0")]
	public void BKDEJNGAEPP(FIMGHMENHOH LAHMDGOAKPJ = FIMGHMENHOH.Add)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3D10650", Offset = "0x3D0EC50", VA = "0x183D10650")]
	public void LDHBNBNMAMP(IEnumerable<Collider> JDHHGJGOJPL, Vector3 PIAPKIOJGCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3D10580", Offset = "0x3D0EB80", VA = "0x183D10580")]
	public bool KHDBLKNIDBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3D104C0", Offset = "0x3D0EAC0", VA = "0x183D104C0")]
	[CompilerGenerated]
	private bool CMCJDGNIIMC(T OOALEDCPNBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3D129F0", Offset = "0x3D10FF0", VA = "0x183D129F0")]
	[CompilerGenerated]
	private bool NNNPLAKGPLE(T OOALEDCPNBJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum FIMGHMENHOH
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
