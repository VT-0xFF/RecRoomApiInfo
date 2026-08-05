using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Mono.Math;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class LEMCMALCFBJ : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xDC9E90", Offset = "0xDC8490", VA = "0x180DC9E90")]
	public LEMCMALCFBJ()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[IABONBNIMIB]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[IABONBNIMIB]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x31627B0", Offset = "0x3160DB0", VA = "0x1831627B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3162770", Offset = "0x3160D70", VA = "0x183162770")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x31627F0", Offset = "0x3160DF0", VA = "0x1831627F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3162A00", Offset = "0x3161000", VA = "0x183162A00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3162970", Offset = "0x3160F70", VA = "0x183162970")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6C0", Offset = "0x6F9CC0", VA = "0x1806FB6C0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xC6F020", Offset = "0xC6D620", VA = "0x180C6F020")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3162730", Offset = "0x3160D30", VA = "0x183162730")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x31628E0", Offset = "0x3160EE0", VA = "0x1831628E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3162160", Offset = "0x3160760", VA = "0x183162160")]
	public void CopyBounds(SavedExtents HJALGMGCNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x31626A0", Offset = "0x3160CA0", VA = "0x1831626A0")]
	public void SetLocalSpaceBounds(Bounds ONLOMANFJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x13045E0", Offset = "0x1302BE0", VA = "0x1813045E0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3162690", Offset = "0x3160C90", VA = "0x183162690")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3162190", Offset = "0x3160790", VA = "0x183162190")]
	private void LJPGKCKJIFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3162460", Offset = "0x3160A60", VA = "0x183162460")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3161BA0", Offset = "0x31601A0", VA = "0x183161BA0")]
	public static void CalculateLocalBoundsFor(GameObject NPJKABNGMNJ, out Bounds ONLOMANFJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x31623A0", Offset = "0x31609A0", VA = "0x1831623A0")]
	private static void LOACKMGFDKC(Bounds BFBDMMHDNGP, Color NJEFHOCCNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x31626C0", Offset = "0x3160CC0", VA = "0x1831626C0")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x56C4A0", Offset = "0x56AAA0", VA = "0x18056C4A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x58BD40", Offset = "0x58A340", VA = "0x18058BD40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x56B740", Offset = "0x569D40", VA = "0x18056B740")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x51A920", Offset = "0x518F20", VA = "0x18051A920", Slot = "4")]
	public virtual void ADEBEAMPMKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7B83E0", Offset = "0x7B69E0", VA = "0x1807B83E0")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[LEMCMALCFBJ]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2497E50", Offset = "0x2496450", VA = "0x182497E50", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2497990", Offset = "0x2495F90", VA = "0x182497990", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2498450", Offset = "0x2496A50", VA = "0x182498450")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class LBLIBOBOLEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7B83E0", Offset = "0x7B69E0", VA = "0x1807B83E0")]
		public LBLIBOBOLEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1E5BB30", Offset = "0x1E5A130", VA = "0x181E5BB30")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[LEMCMALCFBJ]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x56C4A0", Offset = "0x56AAA0", VA = "0x18056C4A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1E568D0", Offset = "0x1E54ED0", VA = "0x181E568D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1E56900", Offset = "0x1E54F00", VA = "0x181E56900", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1E56820", Offset = "0x1E54E20", VA = "0x181E56820", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal this[TKey CAOGILCCJKA]
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1E56850", Offset = "0x1E54E50", VA = "0x181E56850", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1E56720", Offset = "0x1E54D20", VA = "0x181E56720", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1E55F80", Offset = "0x1E54580", VA = "0x181E55F80", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1E558F0", Offset = "0x1E53EF0", VA = "0x181E558F0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1E55490", Offset = "0x1E53A90", VA = "0x181E55490", Slot = "14")]
	protected virtual string DBHCPBNBCEO(TKeyVal ODJMIKLIFKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1E55430", Offset = "0x1E53A30", VA = "0x181E55430", Slot = "4")]
	public bool ContainsKey(TKey CAOGILCCJKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1E56610", Offset = "0x1E54C10", VA = "0x181E56610", Slot = "5")]
	public bool TryGetValue(TKey CAOGILCCJKA, out TVal JKOBKIEBPCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1E554F0", Offset = "0x1E53AF0", VA = "0x181E554F0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1E554F0", Offset = "0x1E53AF0", VA = "0x181E554F0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1E56640", Offset = "0x1E54C40", VA = "0x181E56640")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class BLFBDODJPDB<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class BMJCODHABEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7B83E0", Offset = "0x7B69E0", VA = "0x1807B83E0")]
		public BMJCODHABEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x223DA10", Offset = "0x223C010", VA = "0x18223DA10")]
		internal bool <GetSamples>b__0(global::MDHOPCMDNJN<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly float ABEEPGCMHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly float JBOPHEAKONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private List<global::MDHOPCMDNJN<float, T>> OBFKOEEDPOH;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int EPJDGKGEKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x223C300", Offset = "0x223A900", VA = "0x18223C300")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x223C700", Offset = "0x223AD00", VA = "0x18223C700")]
	public BLFBDODJPDB(float BFBIMIFECCN, float AIINJFKHLCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x223C4E0", Offset = "0x223AAE0", VA = "0x18223C4E0")]
	public bool MOILJIDPBBK(float HLFJJCMMGLA, T JKOBKIEBPCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x223C220", Offset = "0x223A820", VA = "0x18223C220")]
	public int JABMPHPJCAM(float HLFJJCMMGLA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x223BBA0", Offset = "0x223A1A0", VA = "0x18223BBA0")]
	public IEnumerable<T> FFELAPNOKLJ(float HLFJJCMMGLA, [Optional] float? NNAKGEFIKIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x223BB70", Offset = "0x223A170", VA = "0x18223BB70")]
	public void EAPDGKCCOIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x223C640", Offset = "0x223AC40", VA = "0x18223C640")]
	private void NEBEEGAPDHE(float HLFJJCMMGLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public abstract class ONKPAHFEMLH<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct KPLCFAIPDDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T OFOOFEJCCGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float MNOFDCJNFDG;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static float DPGNBJBIHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private List<T> NMMJNHOAPHH;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const int EDCIBKNBLCD = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private KPLCFAIPDDA[] CDIMPGOIPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int FEGLJGODNFJ;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float AGAJNNJNPEK
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7B7470", Offset = "0x7B5A70", VA = "0x1807B7470")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x814630", Offset = "0x812C30", VA = "0x180814630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x9DA160", Offset = "0x9D8760", VA = "0x1809DA160")]
	public ONKPAHFEMLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x9DA080", Offset = "0x9D8680", VA = "0x1809DA080")]
	public ONKPAHFEMLH(int OGHBEIMLJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x9D99C0", Offset = "0x9D7FC0", VA = "0x1809D99C0")]
	public void OAKCALBAGFG(float HLFJJCMMGLA, T JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x9D8CA0", Offset = "0x9D72A0", VA = "0x1809D8CA0")]
	public void EAPDGKCCOIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x9D9CC0", Offset = "0x9D82C0", VA = "0x1809D9CC0")]
	public bool OEFOILFNGDK(float FIEHHADNFNK, float KJHMEJLDLDA, out T JKOBKIEBPCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x9D90A0", Offset = "0x9D76A0", VA = "0x1809D90A0")]
	public bool FMBLKOMIMDG(float FIEHHADNFNK, float KJHMEJLDLDA, out T JKOBKIEBPCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x9D9660", Offset = "0x9D7C60", VA = "0x1809D9660")]
	public void GENCOJFMFGP(float FIEHHADNFNK, float KJHMEJLDLDA, List<T> LFIKNNODPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x9D97B0", Offset = "0x9D7DB0", VA = "0x1809D97B0")]
	private int JPDKOLPPEBG(int HFDAAFFENHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x9D97E0", Offset = "0x9D7DE0", VA = "0x1809D97E0")]
	private void KCPIEMLGNKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T NNGFMPBDBKF();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T AGNOFAIJPJB(T PKBENFANEJD, T BOFJBOMFIJG, float DNABKMDOJNG);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T CPCKCOMCHJP(T JKOBKIEBPCF, float DNABKMDOJNG);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T EFNDDCLKHML(T PKBENFANEJD, T BOFJBOMFIJG);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T HKIDAOCHGFM(T PKBENFANEJD, T BOFJBOMFIJG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class KLKMNDIPFJJ : global::ONKPAHFEMLH<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3160E90", Offset = "0x315F490", VA = "0x183160E90", Slot = "4")]
	protected override Vector3 NNGFMPBDBKF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3160C10", Offset = "0x315F210", VA = "0x183160C10", Slot = "5")]
	protected override Vector3 AGNOFAIJPJB(Vector3 PKBENFANEJD, Vector3 BOFJBOMFIJG, float DNABKMDOJNG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3160CD0", Offset = "0x315F2D0", VA = "0x183160CD0", Slot = "6")]
	protected override Vector3 CPCKCOMCHJP(Vector3 JKOBKIEBPCF, float DNABKMDOJNG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3160D70", Offset = "0x315F370", VA = "0x183160D70", Slot = "7")]
	protected override Vector3 EFNDDCLKHML(Vector3 PKBENFANEJD, Vector3 BOFJBOMFIJG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3160E20", Offset = "0x315F420", VA = "0x183160E20", Slot = "8")]
	protected override Vector3 HKIDAOCHGFM(Vector3 PKBENFANEJD, Vector3 BOFJBOMFIJG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3160F00", Offset = "0x315F500", VA = "0x183160F00")]
	public KLKMNDIPFJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class CMHEGBOGIKP : global::ONKPAHFEMLH<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x315DA20", Offset = "0x315C020", VA = "0x18315DA20")]
	public CMHEGBOGIKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x315DA80", Offset = "0x315C080", VA = "0x18315DA80")]
	public CMHEGBOGIKP(int OGHBEIMLJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6FD260", Offset = "0x6FB860", VA = "0x1806FD260", Slot = "4")]
	protected override float NNGFMPBDBKF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x315D980", Offset = "0x315BF80", VA = "0x18315D980", Slot = "5")]
	protected override float AGNOFAIJPJB(float PKBENFANEJD, float BOFJBOMFIJG, float DNABKMDOJNG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x26227A0", Offset = "0x2620DA0", VA = "0x1826227A0", Slot = "6")]
	protected override float CPCKCOMCHJP(float JKOBKIEBPCF, float DNABKMDOJNG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x315DA00", Offset = "0x315C000", VA = "0x18315DA00", Slot = "7")]
	protected override float EFNDDCLKHML(float PKBENFANEJD, float BOFJBOMFIJG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x315DA10", Offset = "0x315C010", VA = "0x18315DA10", Slot = "8")]
	protected override float HKIDAOCHGFM(float PKBENFANEJD, float BOFJBOMFIJG)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class LADHMPJMEFI
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x892BE0", Offset = "0x8911E0", VA = "0x180892BE0")]
	public static global::GGECNLJOEML<T1> NIBKLGLBMIL<T1>(T1 JBDDIPAHCNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0xC983E0", Offset = "0xC969E0", VA = "0x180C983E0")]
	public static global::MDHOPCMDNJN<T1, T2> NIBKLGLBMIL<T1, T2>(T1 JBDDIPAHCNG, T2 OCOALLPFEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xB78000", Offset = "0xB76600", VA = "0x180B78000")]
	public static global::GMEKOLBIIGF<T1, T2, T3> NIBKLGLBMIL<T1, T2, T3>(T1 JBDDIPAHCNG, T2 OCOALLPFEOO, T3 HNLCMMBECBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3EBA420", Offset = "0x3EB8A20", VA = "0x183EBA420")]
	public static global::DBJIGBIECHM<T1, T2, T3, T4> NIBKLGLBMIL<T1, T2, T3, T4>(T1 JBDDIPAHCNG, T2 OCOALLPFEOO, T3 HNLCMMBECBH, T4 KOAHDHEBBKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xB78140", Offset = "0xB76740", VA = "0x180B78140")]
	public static global::GGHAGONLKBN<T1, T2, T3, T4, T5> NIBKLGLBMIL<T1, T2, T3, T4, T5>(T1 JBDDIPAHCNG, T2 OCOALLPFEOO, T3 HNLCMMBECBH, T4 KOAHDHEBBKO, T5 OJGCCDDGEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0xB78090", Offset = "0xB76690", VA = "0x180B78090")]
	public static global::LEDHPEHADEA<T1, T2, T3, T4, T5, T6> NIBKLGLBMIL<T1, T2, T3, T4, T5, T6>(T1 JBDDIPAHCNG, T2 OCOALLPFEOO, T3 HNLCMMBECBH, T4 KOAHDHEBBKO, T5 OJGCCDDGEFJ, T6 JOAANGFLNKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xC98450", Offset = "0xC96A50", VA = "0x180C98450")]
	public static global::NCILJFJLGLD<T1, T2, T3, T4, T5, T6, T7> NIBKLGLBMIL<T1, T2, T3, T4, T5, T6, T7>(T1 JBDDIPAHCNG, T2 OCOALLPFEOO, T3 HNLCMMBECBH, T4 KOAHDHEBBKO, T5 OJGCCDDGEFJ, T6 JOAANGFLNKB, T7 DMJBBDDFDJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3EBA350", Offset = "0x3EB8950", VA = "0x183EBA350")]
	public static global::FDEINJGCODF<T1, T2, T3, T4, T5, T6, T7, T8> NIBKLGLBMIL<T1, T2, T3, T4, T5, T6, T7, T8>(T1 JBDDIPAHCNG, T2 OCOALLPFEOO, T3 HNLCMMBECBH, T4 KOAHDHEBBKO, T5 OJGCCDDGEFJ, T6 JOAANGFLNKB, T7 DMJBBDDFDJM, T8 KANEFKIHFHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x65A540", Offset = "0x658B40", VA = "0x18065A540")]
	[IteratorStateMachine(typeof(FAPDALNIHDK))]
	public static IEnumerable<global::MDHOPCMDNJN<T1, T2>> LNKAEKNGLCH<T1, T2>(IEnumerable<T1> LFCBLKFDHFN, IEnumerable<T2> BFBDMMHDNGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x65C430", Offset = "0x65AA30", VA = "0x18065C430")]
	[IteratorStateMachine(typeof(FPBMODGIFDE))]
	public static IEnumerable<global::GMEKOLBIIGF<T1, T2, T3>> LNKAEKNGLCH<T1, T2, T3>(IEnumerable<T1> LFCBLKFDHFN, IEnumerable<T2> BFBDMMHDNGP, IEnumerable<T3> NJEFHOCCNNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xB87B70", Offset = "0xB86170", VA = "0x180B87B70")]
	internal static int OLMNFAONGAH(int HPIMNCJBNBB, int KKEFLOFMKJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x29BC3F0", Offset = "0x29BA9F0", VA = "0x1829BC3F0")]
	internal static int OLMNFAONGAH(int HPIMNCJBNBB, int KKEFLOFMKJM, int JLIPHIBCDNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x29BC400", Offset = "0x29BAA00", VA = "0x1829BC400")]
	internal static int OLMNFAONGAH(int HPIMNCJBNBB, int KKEFLOFMKJM, int JLIPHIBCDNM, int OIKLIHEBPML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3160F60", Offset = "0x315F560", VA = "0x183160F60")]
	internal static int OLMNFAONGAH(int HPIMNCJBNBB, int KKEFLOFMKJM, int JLIPHIBCDNM, int OIKLIHEBPML, int EGIPNDNFMME)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3160FE0", Offset = "0x315F5E0", VA = "0x183160FE0")]
	internal static int OLMNFAONGAH(int HPIMNCJBNBB, int KKEFLOFMKJM, int JLIPHIBCDNM, int OIKLIHEBPML, int EGIPNDNFMME, int DIOEONOLBAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3160FB0", Offset = "0x315F5B0", VA = "0x183160FB0")]
	internal static int OLMNFAONGAH(int HPIMNCJBNBB, int KKEFLOFMKJM, int JLIPHIBCDNM, int OIKLIHEBPML, int EGIPNDNFMME, int DIOEONOLBAL, int GDBIAOJINFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3160F80", Offset = "0x315F580", VA = "0x183160F80")]
	internal static int OLMNFAONGAH(int HPIMNCJBNBB, int KKEFLOFMKJM, int JLIPHIBCDNM, int OIKLIHEBPML, int EGIPNDNFMME, int DIOEONOLBAL, int GDBIAOJINFA, int DHJALHHDDNE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class GGECNLJOEML<T1> : IComparable<global::GGECNLJOEML<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T1 ECABFJJGLAI;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x13437C0", Offset = "0x1341DC0", VA = "0x1813437C0")]
	public GGECNLJOEML(T1 JBDDIPAHCNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x47BAAC0", Offset = "0x47B90C0", VA = "0x1847BAAC0", Slot = "4")]
	public int CompareTo(global::GGECNLJOEML<T1> HJALGMGCNFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x47BAB30", Offset = "0x47B9130", VA = "0x1847BAB30", Slot = "0")]
	public override bool Equals(object HJALGMGCNFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0xAC8350", Offset = "0xAC6950", VA = "0x180AC8350", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x47BABD0", Offset = "0x47B91D0", VA = "0x1847BABD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class MDHOPCMDNJN<T1, T2> : IComparable<global::MDHOPCMDNJN<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T1 ECABFJJGLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T2 HKMAKHMFPCC;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1342C90", Offset = "0x1341290", VA = "0x181342C90")]
	public MDHOPCMDNJN(T1 JBDDIPAHCNG, T2 OCOALLPFEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x21D9850", Offset = "0x21D7E50", VA = "0x1821D9850", Slot = "4")]
	public int CompareTo(global::MDHOPCMDNJN<T1, T2> HJALGMGCNFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x21D9EC0", Offset = "0x21D84C0", VA = "0x1821D9EC0", Slot = "0")]
	public override bool Equals(object HJALGMGCNFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x21DAAD0", Offset = "0x21D90D0", VA = "0x1821DAAD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x21DAF40", Offset = "0x21D9540", VA = "0x1821DAF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class GMEKOLBIIGF<T1, T2, T3> : IComparable<global::GMEKOLBIIGF<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 ECABFJJGLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 HKMAKHMFPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T3 ONIPIPJKIOI;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4268770", Offset = "0x4266D70", VA = "0x184268770")]
	public GMEKOLBIIGF(T1 JBDDIPAHCNG, T2 OCOALLPFEOO, T3 HNLCMMBECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4268090", Offset = "0x4266690", VA = "0x184268090", Slot = "4")]
	public int CompareTo(global::GMEKOLBIIGF<T1, T2, T3> HJALGMGCNFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4268190", Offset = "0x4266790", VA = "0x184268190", Slot = "0")]
	public override bool Equals(object HJALGMGCNFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x42683F0", Offset = "0x42669F0", VA = "0x1842683F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x42684F0", Offset = "0x4266AF0", VA = "0x1842684F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class DBJIGBIECHM<T1, T2, T3, T4> : IComparable<global::DBJIGBIECHM<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T1 ECABFJJGLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T2 HKMAKHMFPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T3 ONIPIPJKIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T4 IFGJGFLKEDK;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x30271C0", Offset = "0x30257C0", VA = "0x1830271C0")]
	public DBJIGBIECHM(T1 JBDDIPAHCNG, T2 OCOALLPFEOO, T3 HNLCMMBECBH, T4 KOAHDHEBBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x40FA450", Offset = "0x40F8A50", VA = "0x1840FA450", Slot = "4")]
	public int CompareTo(global::DBJIGBIECHM<T1, T2, T3, T4> HJALGMGCNFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x40FA590", Offset = "0x40F8B90", VA = "0x1840FA590", Slot = "0")]
	public override bool Equals(object HJALGMGCNFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x40FA6B0", Offset = "0x40F8CB0", VA = "0x1840FA6B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x40FA770", Offset = "0x40F8D70", VA = "0x1840FA770", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class GGHAGONLKBN<T1, T2, T3, T4, T5> : IComparable<global::GGHAGONLKBN<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T1 ECABFJJGLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T2 HKMAKHMFPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T3 ONIPIPJKIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T4 IFGJGFLKEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T5 EJAGAIELGBM;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2649820", Offset = "0x2647E20", VA = "0x182649820")]
	public GGHAGONLKBN(T1 JBDDIPAHCNG, T2 OCOALLPFEOO, T3 HNLCMMBECBH, T4 KOAHDHEBBKO, T5 OJGCCDDGEFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x47BAC70", Offset = "0x47B9270", VA = "0x1847BAC70", Slot = "4")]
	public int CompareTo(global::GGHAGONLKBN<T1, T2, T3, T4, T5> HJALGMGCNFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x47BADF0", Offset = "0x47B93F0", VA = "0x1847BADF0", Slot = "0")]
	public override bool Equals(object HJALGMGCNFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x47BAF30", Offset = "0x47B9530", VA = "0x1847BAF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x47BB030", Offset = "0x47B9630", VA = "0x1847BB030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class LEDHPEHADEA<T1, T2, T3, T4, T5, T6> : IComparable<global::LEDHPEHADEA<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T1 ECABFJJGLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T2 HKMAKHMFPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T3 ONIPIPJKIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T4 IFGJGFLKEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T5 EJAGAIELGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T6 KJKGOHAOGGN;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1D5C340", Offset = "0x1D5A940", VA = "0x181D5C340")]
	public LEDHPEHADEA(T1 JBDDIPAHCNG, T2 OCOALLPFEOO, T3 HNLCMMBECBH, T4 KOAHDHEBBKO, T5 OJGCCDDGEFJ, T6 JOAANGFLNKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1D5BDA0", Offset = "0x1D5A3A0", VA = "0x181D5BDA0", Slot = "4")]
	public int CompareTo(global::LEDHPEHADEA<T1, T2, T3, T4, T5, T6> HJALGMGCNFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1D5BF60", Offset = "0x1D5A560", VA = "0x181D5BF60", Slot = "0")]
	public override bool Equals(object HJALGMGCNFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1D5C0D0", Offset = "0x1D5A6D0", VA = "0x181D5C0D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1D5C1F0", Offset = "0x1D5A7F0", VA = "0x181D5C1F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class NCILJFJLGLD<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::NCILJFJLGLD<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T1 ECABFJJGLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T2 HKMAKHMFPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T3 ONIPIPJKIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T4 IFGJGFLKEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T5 EJAGAIELGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T6 KJKGOHAOGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T7 HIHFEHIPBCA;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1341C40", Offset = "0x1340240", VA = "0x181341C40")]
	public NCILJFJLGLD(T1 JBDDIPAHCNG, T2 OCOALLPFEOO, T3 HNLCMMBECBH, T4 KOAHDHEBBKO, T5 OJGCCDDGEFJ, T6 JOAANGFLNKB, T7 DMJBBDDFDJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x13415E0", Offset = "0x133FBE0", VA = "0x1813415E0", Slot = "4")]
	public int CompareTo(global::NCILJFJLGLD<T1, T2, T3, T4, T5, T6, T7> HJALGMGCNFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x13417E0", Offset = "0x133FDE0", VA = "0x1813417E0", Slot = "0")]
	public override bool Equals(object HJALGMGCNFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1341980", Offset = "0x133FF80", VA = "0x181341980", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1341AD0", Offset = "0x13400D0", VA = "0x181341AD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class FDEINJGCODF<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::FDEINJGCODF<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T1 ECABFJJGLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T2 HKMAKHMFPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T3 ONIPIPJKIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T4 IFGJGFLKEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T5 EJAGAIELGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T6 KJKGOHAOGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T7 HIHFEHIPBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T8 GGNBIHIMDNG;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x468DED0", Offset = "0x468C4D0", VA = "0x18468DED0")]
	public FDEINJGCODF(T1 JBDDIPAHCNG, T2 OCOALLPFEOO, T3 HNLCMMBECBH, T4 KOAHDHEBBKO, T5 OJGCCDDGEFJ, T6 JOAANGFLNKB, T7 DMJBBDDFDJM, T8 KANEFKIHFHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x468D7C0", Offset = "0x468BDC0", VA = "0x18468D7C0", Slot = "4")]
	public int CompareTo(global::FDEINJGCODF<T1, T2, T3, T4, T5, T6, T7, T8> HJALGMGCNFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x468DA10", Offset = "0x468C010", VA = "0x18468DA10", Slot = "0")]
	public override bool Equals(object HJALGMGCNFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x468DBD0", Offset = "0x468C1D0", VA = "0x18468DBD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x468DD40", Offset = "0x468C340", VA = "0x18468DD40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public T OFOOFEJCCGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x50DD80", Offset = "0x50C380", VA = "0x18050DD80")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x50DAE0", Offset = "0x50C0E0", VA = "0x18050DAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float JHFDHGPHNNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5AA100", Offset = "0x5A8700", VA = "0x1805AA100")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3047240", Offset = "0x3045840", VA = "0x183047240")]
	public T BOFJLOFJPMC(float DNABKMDOJNG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3047320", Offset = "0x3045920", VA = "0x183047320")]
	public T LMLKLNKEGDO(float DNABKMDOJNG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T AGNOFAIJPJB(T PKBENFANEJD, T BOFJBOMFIJG, float DNABKMDOJNG);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7B83E0", Offset = "0x7B69E0", VA = "0x1807B83E0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x315F0F0", Offset = "0x315D6F0", VA = "0x18315F0F0", Slot = "4")]
	protected override float AGNOFAIJPJB(float PKBENFANEJD, float BOFJBOMFIJG, float DNABKMDOJNG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x315F170", Offset = "0x315D770", VA = "0x18315F170")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3163980", Offset = "0x3161F80", VA = "0x183163980", Slot = "4")]
	protected override Vector3 AGNOFAIJPJB(Vector3 PKBENFANEJD, Vector3 BOFJBOMFIJG, float DNABKMDOJNG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3163A40", Offset = "0x3162040", VA = "0x183163A40")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x315DB60", Offset = "0x315C160", VA = "0x18315DB60", Slot = "4")]
	protected override Color AGNOFAIJPJB(Color PKBENFANEJD, Color BOFJBOMFIJG, float DNABKMDOJNG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x315DBB0", Offset = "0x315C1B0", VA = "0x18315DBB0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public sealed class EGIPLLBHGKI<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private T[] NMGGEIIOCDK;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int JLOOKCACPHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x56D520", Offset = "0x56BB20", VA = "0x18056D520")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x56D480", Offset = "0x56BA80", VA = "0x18056D480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T IDICDLOAFIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x25C7EA0", Offset = "0x25C64A0", VA = "0x1825C7EA0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x25C7F20", Offset = "0x25C6520", VA = "0x1825C7F20")]
	public static global::EGIPLLBHGKI<T> JLNPPLOCBEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x25C7900", Offset = "0x25C5F00", VA = "0x1825C7900")]
	public static global::EGIPLLBHGKI<T> DLCDCKEMLCM(int PNGOPGJMFFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x25C84C0", Offset = "0x25C6AC0", VA = "0x1825C84C0")]
	private EGIPLLBHGKI(T[] DFDDFOJMKKC, int PNGOPGJMFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x25C7A40", Offset = "0x25C6040", VA = "0x1825C7A40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x25C8050", Offset = "0x25C6650", VA = "0x1825C8050")]
	public void OAKCALBAGFG(in T JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x25C7AB0", Offset = "0x25C60B0", VA = "0x1825C7AB0")]
	public void EFPJKGOBFBB(int OGHBEIMLJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x25C8340", Offset = "0x25C6940", VA = "0x1825C8340")]
	private void PKCAIMEKGBP(int PNGOPGJMFFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class FMANFJHGKHP
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x893170", Offset = "0x891770", VA = "0x180893170")]
	public static global::EGIPLLBHGKI<T> JLNPPLOCBEM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0xC94520", Offset = "0xC92B20", VA = "0x180C94520")]
	public static global::EGIPLLBHGKI<T> DLCDCKEMLCM<T>(int PNGOPGJMFFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[DefaultMember("Item")]
public class JCBOKLAFNPG<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Dictionary<TKey, TVal> NLNFDGOFIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<TVal, TKey> GCCEDEINMEA;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int JLOOKCACPHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7B9D60", Offset = "0x7B8360", VA = "0x1807B9D60", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool EFJPPNPLLLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x511400", Offset = "0x50FA00", VA = "0x180511400", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public ICollection<TKey> EBNFDHNEAOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7B9E40", Offset = "0x7B8440", VA = "0x1807B9E40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TVal> ABPCIKPDHND
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x13CBA20", Offset = "0x13CA020", VA = "0x1813CBA20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public TVal IDICDLOAFIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x13CB9F0", Offset = "0x13C9FF0", VA = "0x1813CB9F0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x13CBA50", Offset = "0x13CA050", VA = "0x1813CBA50", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TKey IDICDLOAFIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x13CB180", Offset = "0x13C9780", VA = "0x1813CB180")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x13CB340", Offset = "0x13C9940", VA = "0x1813CB340")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x13CB060", Offset = "0x13C9660", VA = "0x1813CB060", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x13CB8C0", Offset = "0x13C9EC0", VA = "0x1813CB8C0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x13CAE30", Offset = "0x13C9430", VA = "0x1813CAE30", Slot = "9")]
	public void Add(TKey CAOGILCCJKA, TVal JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x13CAE60", Offset = "0x13C9460", VA = "0x1813CAE60", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> NGDPDJFCGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0xDD6790", Offset = "0xDD4D90", VA = "0x180DD6790", Slot = "8")]
	public bool ContainsKey(TKey CAOGILCCJKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x13CB0C0", Offset = "0x13C96C0", VA = "0x1813CB0C0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> NGDPDJFCGCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x13CB810", Offset = "0x13C9E10", VA = "0x1813CB810", Slot = "10")]
	public bool Remove(TKey CAOGILCCJKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x13CB810", Offset = "0x13C9E10", VA = "0x1813CB810", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> NGDPDJFCGCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x9D4FD0", Offset = "0x9D35D0", VA = "0x1809D4FD0", Slot = "11")]
	public bool TryGetValue(TKey CAOGILCCJKA, out TVal JKOBKIEBPCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x13CB2C0", Offset = "0x13C98C0", VA = "0x1813CB2C0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x13CB120", Offset = "0x13C9720", VA = "0x1813CB120", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] CDIMPGOIPOL, int FPMLOCEPCLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x13CB6C0", Offset = "0x13C9CC0", VA = "0x1813CB6C0")]
	public void OAKCALBAGFG(TVal JNJFNAOGKKP, TKey CAOGILCCJKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x13CB740", Offset = "0x13C9D40", VA = "0x1813CB740")]
	public void OAKCALBAGFG(KeyValuePair<TVal, TKey> NGDPDJFCGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x13CAE00", Offset = "0x13C9400", VA = "0x1813CAE00")]
	public bool AIGGAJMBDEI(TVal CAOGILCCJKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x13CB000", Offset = "0x13C9600", VA = "0x1813CB000")]
	public bool CMKDNCJELMF(KeyValuePair<TVal, TKey> NGDPDJFCGCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x13CB7B0", Offset = "0x13C9DB0", VA = "0x1813CB7B0")]
	public bool PFBLIKHMAGM(TVal CAOGILCCJKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x13CB7B0", Offset = "0x13C9DB0", VA = "0x1813CB7B0")]
	public bool PFBLIKHMAGM(KeyValuePair<TVal, TKey> NGDPDJFCGCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x13CAEC0", Offset = "0x13C94C0", VA = "0x1813CAEC0")]
	public bool BHCEMEACFLD(TVal CAOGILCCJKA, out TKey JKOBKIEBPCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x13CAEF0", Offset = "0x13C94F0", VA = "0x1813CAEF0")]
	public IEnumerator<KeyValuePair<TVal, TKey>> BMFNFMIBIJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x13CACF0", Offset = "0x13C92F0", VA = "0x1813CACF0")]
	private void ADHMHCAFMCN(TKey CAOGILCCJKA, TVal JNJFNAOGKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x13CB1B0", Offset = "0x13C97B0", VA = "0x1813CB1B0")]
	private void FOOIDPPBBFG(TKey CAOGILCCJKA, TVal JNJFNAOGKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x13CB3C0", Offset = "0x13C99C0", VA = "0x1813CB3C0")]
	private bool LGHBHIIKMIP(TKey CAOGILCCJKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x13CB600", Offset = "0x13C9C00", VA = "0x1813CB600")]
	private bool LGHBHIIKMIP(TVal JNJFNAOGKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x13CB910", Offset = "0x13C9F10", VA = "0x1813CB910")]
	public JCBOKLAFNPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class NHFBPAJIKKH<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private global::NHFBPAJIKKH<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x7B7470", Offset = "0x7B5A70", VA = "0x1807B7470", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x133C430", Offset = "0x133AA30", VA = "0x18133C430", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x133C580", Offset = "0x133AB80", VA = "0x18133C580")]
		public Enumerator(global::NHFBPAJIKKH<T> LFIKNNODPFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x51A920", Offset = "0x518F20", VA = "0x18051A920", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x133BB40", Offset = "0x133A140", VA = "0x18133BB40", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x133BF90", Offset = "0x133A590", VA = "0x18133BF90", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x133B890", Offset = "0x1339E90", VA = "0x18133B890")]
		private void IGKPEKHJLOK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private T[] LIDIMPJLJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int HOGJMFJENKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private int AGFCECKPOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int JGGHFEMDIEP;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int JLOOKCACPHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x1344F60", Offset = "0x1343560", VA = "0x181344F60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public T IDICDLOAFIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x1344D20", Offset = "0x1343320", VA = "0x181344D20")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1344EE0", Offset = "0x13434E0", VA = "0x181344EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x1346520", Offset = "0x1344B20", VA = "0x181346520")]
	public NHFBPAJIKKH(int PNGOPGJMFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x1345390", Offset = "0x1343990", VA = "0x181345390")]
	public void OAKCALBAGFG(T DNABKMDOJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x1345D30", Offset = "0x1344330", VA = "0x181345D30")]
	public void PCBBGCHODBL(IEnumerable<T> BAAGALNKNDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1344BD0", Offset = "0x13431D0", VA = "0x181344BD0")]
	public void EAPDGKCCOIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x1345680", Offset = "0x1343C80", VA = "0x181345680")]
	public void OEOPJNOCDNK(int JKKHOEKMJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x13444A0", Offset = "0x1342AA0", VA = "0x1813444A0")]
	public void COEPIHEABAJ(int JKKHOEKMJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x13447E0", Offset = "0x1342DE0", VA = "0x1813447E0")]
	public void DNOIFGOLOAI(T[] CDIMPGOIPOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x13445A0", Offset = "0x1342BA0", VA = "0x1813445A0")]
	public Enumerator DJLEFEIHJJC()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x1346330", Offset = "0x1344930", VA = "0x181346330", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x1346330", Offset = "0x1344930", VA = "0x181346330", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x13451B0", Offset = "0x13437B0", VA = "0x1813451B0")]
	private int NFBCMCBCHCH(int OEELHFBMNBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x1344FA0", Offset = "0x13435A0", VA = "0x181344FA0")]
	private int MMHDECCFPNF(int OEELHFBMNBJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public abstract class LIEMBLGPCLI
{
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void BNNNGEBPJNK(object[] IBAAJDHFADE);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	protected LIEMBLGPCLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class DCPFFOCHCJJ<T> : LIEMBLGPCLI
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	protected struct CBIOHCJFJOP
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public enum OCNIKAAHPNE
		{
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public OCNIKAAHPNE JOBKDGGGOHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public T DAENONOLDPH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int NLLNMFDCIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly bool POKKCCGBGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	protected readonly bool FNJGCKDMDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	protected List<T> PIFHBEINFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private List<CBIOHCJFJOP> FPNEEIJNLBE;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool OLGGHLIEGAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x40FAA90", Offset = "0x40F9090", VA = "0x1840FAA90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x40FB000", Offset = "0x40F9600", VA = "0x1840FB000")]
	protected DCPFFOCHCJJ(bool FNJGCKDMDFO, bool POKKCCGBGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x40FAE00", Offset = "0x40F9400", VA = "0x1840FAE00")]
	protected bool PACPCLFHDBB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x40FA880", Offset = "0x40F8E80", VA = "0x1840FA880")]
	protected void CCPJNNBEFHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x40FAAD0", Offset = "0x40F90D0", VA = "0x1840FAAD0")]
	protected void FOCBPDLNHMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x437F240", Offset = "0x437D840", VA = "0x18437F240")]
	private static void GHPFJJBGHMH<U>(ref List<U> EFFDBMEPJFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x40FAC80", Offset = "0x40F9280", VA = "0x1840FAC80", Slot = "5")]
	public void OAKCALBAGFG(T DAENONOLDPH, bool HJPBPFAAKNF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x40FAEA0", Offset = "0x40F94A0", VA = "0x1840FAEA0", Slot = "6")]
	public void PFBLIKHMAGM(T DAENONOLDPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x40FA960", Offset = "0x40F8F60", VA = "0x1840FA960")]
	public void EAPDGKCCOIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface NIEOMEDCPNL
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OAKCALBAGFG(Action DAENONOLDPH, bool HJPBPFAAKNF = false);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PFBLIKHMAGM(Action DAENONOLDPH);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class IDFFNOKDGGC : global::DCPFFOCHCJJ<Action>, NIEOMEDCPNL
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x31608C0", Offset = "0x315EEC0", VA = "0x1831608C0")]
	public IDFFNOKDGGC(bool FNJGCKDMDFO = false, bool POKKCCGBGMM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x31606A0", Offset = "0x315ECA0", VA = "0x1831606A0")]
	public void EJMOPNIONOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x31605C0", Offset = "0x315EBC0", VA = "0x1831605C0", Slot = "4")]
	public override void BNNNGEBPJNK(object[] IBAAJDHFADE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3160860", Offset = "0x315EE60", VA = "0x183160860")]
	public static IDFFNOKDGGC GCGGNBECFPF(IDFFNOKDGGC NBEAEPFKAPO, Action DAENONOLDPH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3160640", Offset = "0x315EC40", VA = "0x183160640")]
	public static IDFFNOKDGGC DHCFNADEJLB(IDFFNOKDGGC NBEAEPFKAPO, Action DAENONOLDPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface GIFMKBJDBKN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OAKCALBAGFG(Action<T> DAENONOLDPH, bool HJPBPFAAKNF = false);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PFBLIKHMAGM(Action<T> DAENONOLDPH);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class OEMIPNFNGHD<T> : global::DCPFFOCHCJJ<Action<T>>, global::GIFMKBJDBKN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x9D8B20", Offset = "0x9D7120", VA = "0x1809D8B20")]
	public OEMIPNFNGHD(bool FNJGCKDMDFO = false, bool POKKCCGBGMM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x234FF30", Offset = "0x234E530", VA = "0x18234FF30")]
	public void EJMOPNIONOA(T DNABKMDOJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x234E420", Offset = "0x234CA20", VA = "0x18234E420", Slot = "4")]
	public override void BNNNGEBPJNK(object[] IBAAJDHFADE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2351D30", Offset = "0x2350330", VA = "0x182351D30")]
	public static global::OEMIPNFNGHD<T> GCGGNBECFPF(global::OEMIPNFNGHD<T> NBEAEPFKAPO, Action<T> DAENONOLDPH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x234E6D0", Offset = "0x234CCD0", VA = "0x18234E6D0")]
	public static global::OEMIPNFNGHD<T> DHCFNADEJLB(global::OEMIPNFNGHD<T> NBEAEPFKAPO, Action<T> DAENONOLDPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface PCCHLIPBJNE<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OAKCALBAGFG(Action<T, U> DAENONOLDPH, bool HJPBPFAAKNF = false);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PFBLIKHMAGM(Action<T, U> DAENONOLDPH);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class AMGECDDOGEP<T, U> : global::DCPFFOCHCJJ<Action<T, U>>, global::PCCHLIPBJNE<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x9D8B20", Offset = "0x9D7120", VA = "0x1809D8B20")]
	public AMGECDDOGEP(bool FNJGCKDMDFO = false, bool POKKCCGBGMM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x434E490", Offset = "0x434CA90", VA = "0x18434E490")]
	public void EJMOPNIONOA(T DNABKMDOJNG, U ODINMBAHNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1836120", Offset = "0x1834720", VA = "0x181836120", Slot = "4")]
	public override void BNNNGEBPJNK(object[] IBAAJDHFADE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x18395E0", Offset = "0x1837BE0", VA = "0x1818395E0")]
	public static global::AMGECDDOGEP<T, U> GCGGNBECFPF(global::AMGECDDOGEP<T, U> NBEAEPFKAPO, Action<T, U> DAENONOLDPH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x18367F0", Offset = "0x1834DF0", VA = "0x1818367F0")]
	public static global::AMGECDDOGEP<T, U> DHCFNADEJLB(global::AMGECDDOGEP<T, U> NBEAEPFKAPO, Action<T, U> DAENONOLDPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface PGEPIEHLACG<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OAKCALBAGFG(Action<T, U, V> DAENONOLDPH, bool HJPBPFAAKNF = false);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PFBLIKHMAGM(Action<T, U, V> DAENONOLDPH);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class GECBHPIPFIC<T, U, V> : global::DCPFFOCHCJJ<Action<T, U, V>>, global::PGEPIEHLACG<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x9D8B20", Offset = "0x9D7120", VA = "0x1809D8B20")]
	public GECBHPIPFIC(bool FNJGCKDMDFO = false, bool POKKCCGBGMM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x47BA280", Offset = "0x47B8880", VA = "0x1847BA280")]
	public void EJMOPNIONOA(T DNABKMDOJNG, U ODINMBAHNLK, V AIOIIBBMMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x47B8260", Offset = "0x47B6860", VA = "0x1847B8260", Slot = "4")]
	public override void BNNNGEBPJNK(object[] IBAAJDHFADE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x47BAA20", Offset = "0x47B9020", VA = "0x1847BAA20")]
	public static global::GECBHPIPFIC<T, U, V> GCGGNBECFPF(global::GECBHPIPFIC<T, U, V> NBEAEPFKAPO, Action<T, U, V> DAENONOLDPH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x47B8CC0", Offset = "0x47B72C0", VA = "0x1847B8CC0")]
	public static global::GECBHPIPFIC<T, U, V> DHCFNADEJLB(global::GECBHPIPFIC<T, U, V> NBEAEPFKAPO, Action<T, U, V> DAENONOLDPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface GOELPJCPMDM<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OAKCALBAGFG(Action<T, U, V, W> DAENONOLDPH, bool HJPBPFAAKNF = false);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PFBLIKHMAGM(Action<T, U, V, W> DAENONOLDPH);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class KOCCIDMONFK<T, U, V, W> : global::DCPFFOCHCJJ<Action<T, U, V, W>>, global::GOELPJCPMDM<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x9D8B20", Offset = "0x9D7120", VA = "0x1809D8B20")]
	public KOCCIDMONFK(bool FNJGCKDMDFO = false, bool POKKCCGBGMM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x40DF1B0", Offset = "0x40DD7B0", VA = "0x1840DF1B0")]
	public void EJMOPNIONOA(T DNABKMDOJNG, U ODINMBAHNLK, V AIOIIBBMMDB, W GOEGACBKPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x40DD6E0", Offset = "0x40DBCE0", VA = "0x1840DD6E0", Slot = "4")]
	public override void BNNNGEBPJNK(object[] IBAAJDHFADE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x40DFEA0", Offset = "0x40DE4A0", VA = "0x1840DFEA0")]
	public static global::KOCCIDMONFK<T, U, V, W> GCGGNBECFPF(global::KOCCIDMONFK<T, U, V, W> NBEAEPFKAPO, Action<T, U, V, W> DAENONOLDPH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x40DE340", Offset = "0x40DC940", VA = "0x1840DE340")]
	public static global::KOCCIDMONFK<T, U, V, W> DHCFNADEJLB(global::KOCCIDMONFK<T, U, V, W> NBEAEPFKAPO, Action<T, U, V, W> DAENONOLDPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface CJOMJFABICK<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OAKCALBAGFG(Action<T, U, V, W, X> DAENONOLDPH, bool HJPBPFAAKNF = false);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PFBLIKHMAGM(Action<T, U, V, W, X> DAENONOLDPH);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class PPGIPJANIJJ<T, U, V, W, X> : global::DCPFFOCHCJJ<Action<T, U, V, W, X>>, global::CJOMJFABICK<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x9D8B20", Offset = "0x9D7120", VA = "0x1809D8B20")]
	public PPGIPJANIJJ(bool FNJGCKDMDFO = false, bool POKKCCGBGMM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x48DFF20", Offset = "0x48DE520", VA = "0x1848DFF20")]
	public void EJMOPNIONOA(T DNABKMDOJNG, U ODINMBAHNLK, V AIOIIBBMMDB, W GOEGACBKPPH, X AEIHHPIDBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x48DFB90", Offset = "0x48DE190", VA = "0x1848DFB90", Slot = "4")]
	public override void BNNNGEBPJNK(object[] IBAAJDHFADE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x48E04D0", Offset = "0x48DEAD0", VA = "0x1848E04D0")]
	public static global::PPGIPJANIJJ<T, U, V, W, X> GCGGNBECFPF(global::PPGIPJANIJJ<T, U, V, W, X> NBEAEPFKAPO, Action<T, U, V, W, X> DAENONOLDPH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x48DFE80", Offset = "0x48DE480", VA = "0x1848DFE80")]
	public static global::PPGIPJANIJJ<T, U, V, W, X> DHCFNADEJLB(global::PPGIPJANIJJ<T, U, V, W, X> NBEAEPFKAPO, Action<T, U, V, W, X> DAENONOLDPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface AIPOPGKBAOA<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OAKCALBAGFG(Action<T, U, V, W, X, Y> DAENONOLDPH, bool HJPBPFAAKNF = false);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PFBLIKHMAGM(Action<T, U, V, W, X, Y> DAENONOLDPH);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class ALDKHGNIBLL<T, U, V, W, X, Y> : global::DCPFFOCHCJJ<Action<T, U, V, W, X, Y>>, global::AIPOPGKBAOA<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x9D8B20", Offset = "0x9D7120", VA = "0x1809D8B20")]
	public ALDKHGNIBLL(bool FNJGCKDMDFO = false, bool POKKCCGBGMM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x1833800", Offset = "0x1831E00", VA = "0x181833800")]
	public void EJMOPNIONOA(T DNABKMDOJNG, U ODINMBAHNLK, V AIOIIBBMMDB, W GOEGACBKPPH, X AEIHHPIDBGN, Y NFJDNKBDHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x1833130", Offset = "0x1831730", VA = "0x181833130", Slot = "4")]
	public override void BNNNGEBPJNK(object[] IBAAJDHFADE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x1833B10", Offset = "0x1832110", VA = "0x181833B10")]
	public static global::ALDKHGNIBLL<T, U, V, W, X, Y> GCGGNBECFPF(global::ALDKHGNIBLL<T, U, V, W, X, Y> NBEAEPFKAPO, Action<T, U, V, W, X, Y> DAENONOLDPH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x18334A0", Offset = "0x1831AA0", VA = "0x1818334A0")]
	public static global::ALDKHGNIBLL<T, U, V, W, X, Y> DHCFNADEJLB(global::ALDKHGNIBLL<T, U, V, W, X, Y> NBEAEPFKAPO, Action<T, U, V, W, X, Y> DAENONOLDPH)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct JNIMCFBFNJC
{
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class CMBPHPIIPHD<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public readonly struct NIAIEOEMJGN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly global::CMBPHPIIPHD<T> FBBGCOPOFIO;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public T OFOOFEJCCGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x47D7810", Offset = "0x47D5E10", VA = "0x1847D7810")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x47D77E0", Offset = "0x47D5DE0", VA = "0x1847D77E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8EFAB0", Offset = "0x8EE0B0", VA = "0x1808EFAB0")]
		public NIAIEOEMJGN(global::CMBPHPIIPHD<T> FBBGCOPOFIO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct BIGLLCNPGJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AsyncTaskMethodBuilder<NIAIEOEMJGN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public global::CMBPHPIIPHD<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x47C3BA0", Offset = "0x47C21A0", VA = "0x1847C3BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x1E674B0", Offset = "0x1E65AB0", VA = "0x181E674B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct NGBFHHMAEMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public AsyncTaskMethodBuilder<NIAIEOEMJGN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public global::CMBPHPIIPHD<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x47D7610", Offset = "0x47D5C10", VA = "0x1847D7610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x1E674B0", Offset = "0x1E65AB0", VA = "0x181E674B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly SemaphoreSlim JMLNMEHFAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private T PFPHBGBDJKD;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int NAMAOMAJFHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x47CF5F0", Offset = "0x47CDBF0", VA = "0x1847CF5F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x47CF6B0", Offset = "0x47CDCB0", VA = "0x1847CF6B0")]
	public CMBPHPIIPHD(in T PFPHBGBDJKD, int KHCBJCPPEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x4267B40", Offset = "0x4266140", VA = "0x184267B40")]
	public CMBPHPIIPHD(in T PFPHBGBDJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x47CF5B0", Offset = "0x47CDBB0", VA = "0x1847CF5B0")]
	public NIAIEOEMJGN IOFJKPLDAOM()
	{
		return default(NIAIEOEMJGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x47CF570", Offset = "0x47CDB70", VA = "0x1847CF570")]
	public NIAIEOEMJGN IOFJKPLDAOM(CancellationToken NOBLOPDMHIK)
	{
		return default(NIAIEOEMJGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x47CF2B0", Offset = "0x47CD8B0", VA = "0x1847CF2B0")]
	[AsyncStateMachine(typeof(global::CMBPHPIIPHD<>.BIGLLCNPGJJ))]
	public Task<NIAIEOEMJGN> DEMAMLDPKJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x47CEFB0", Offset = "0x47CD5B0", VA = "0x1847CEFB0")]
	[AsyncStateMachine(typeof(global::CMBPHPIIPHD<>.NGBFHHMAEMP))]
	public Task<NIAIEOEMJGN> DEMAMLDPKJA(CancellationToken NOBLOPDMHIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class AMNJKMCADIE
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x315D360", Offset = "0x315B960", VA = "0x18315D360")]
	public static global::CMBPHPIIPHD<JNIMCFBFNJC> JLNPPLOCBEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x315D3C0", Offset = "0x315B9C0", VA = "0x18315D3C0")]
	public static global::CMBPHPIIPHD<JNIMCFBFNJC> JLNPPLOCBEM(int KHCBJCPPEPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x892BE0", Offset = "0x8911E0", VA = "0x180892BE0")]
	public static global::CMBPHPIIPHD<T> JLNPPLOCBEM<T>(in T PFPHBGBDJKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0xB78BA0", Offset = "0xB771A0", VA = "0x180B78BA0")]
	public static global::CMBPHPIIPHD<T> JLNPPLOCBEM<T>(in T PFPHBGBDJKD, int KHCBJCPPEPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class BIHPLFJFAIK<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public delegate bool FCEDLLNKKIJ(global::BIHPLFJFAIK<T> HKAHEJFPDGM);

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class IPGOJOFPKFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public global::BIHPLFJFAIK<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7B83E0", Offset = "0x7B69E0", VA = "0x1807B83E0")]
		public IPGOJOFPKFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x22405A0", Offset = "0x223EBA0", VA = "0x1822405A0")]
		internal bool <FindNode>b__0(global::BIHPLFJFAIK<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public T BAKBFEOCBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public LinkedList<global::BIHPLFJFAIK<T>> GAKPOAAHOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public global::BIHPLFJFAIK<T> AAJHCLMCNKJ;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public global::BIHPLFJFAIK<T> CPHOAECDIDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x511410", Offset = "0x50FA10", VA = "0x180511410")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x222C350", Offset = "0x222A950", VA = "0x18222C350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool HGAPBJOFPGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x222C320", Offset = "0x222A920", VA = "0x18222C320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool AOBCEAAODDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x222DB20", Offset = "0x222C120", VA = "0x18222DB20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public global::BIHPLFJFAIK<T> JEAEKLPDKDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x222E850", Offset = "0x222CE50", VA = "0x18222E850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x222E970", Offset = "0x222CF70", VA = "0x18222E970")]
	public BIHPLFJFAIK(T JDOBLGKECMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x222DE30", Offset = "0x222C430", VA = "0x18222DE30")]
	public global::BIHPLFJFAIK<T> NAKLECGNDDF(T LGLNAIINDKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x222E380", Offset = "0x222C980", VA = "0x18222E380")]
	public global::BIHPLFJFAIK<T> PAOEINGGEEH(T BMDJGNJDBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x222E7A0", Offset = "0x222CDA0", VA = "0x18222E7A0")]
	public global::BIHPLFJFAIK<T> PFBLIKHMAGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x222C510", Offset = "0x222AB10", VA = "0x18222C510")]
	public void EAPDGKCCOIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x222DB60", Offset = "0x222C160", VA = "0x18222DB60")]
	public global::BIHPLFJFAIK<T> KECHNKJKJPD(T FCGBLBHLBDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x222D460", Offset = "0x222BA60", VA = "0x18222D460")]
	public static void HCIFEGKGPIM(global::BIHPLFJFAIK<T> ICOJGEKKKMK, FCEDLLNKKIJ PEFHEGNIPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x437C730", Offset = "0x437AD30", VA = "0x18437C730")]
	public static void HCIFEGKGPIM<A>(global::BIHPLFJFAIK<T> ICOJGEKKKMK, Func<global::BIHPLFJFAIK<T>, A, bool> PEFHEGNIPNA, A ONKNNFFBFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x222CF20", Offset = "0x222B520", VA = "0x18222CF20")]
	public static string HBGCPABDKPD(global::BIHPLFJFAIK<T> ICOJGEKKKMK, int AFOOALBCHEO = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x222DF50", Offset = "0x222C550", VA = "0x18222DF50")]
	public static global::BIHPLFJFAIK<T> NGAKLMKEFGG(global::BIHPLFJFAIK<T> ICOJGEKKKMK, T NBANPDIBANN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class JOPMPLPBOKB<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public delegate Task<TResult> JPFNAHKDDLO(TRequest OOMGMCFGDFM, CancellationToken NOBLOPDMHIK);

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public enum HIMPAEPMNBM
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class PPGICKEFOFG
	{
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private const float BLHFAEILLAA = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TimeSpan LMILNBNGALJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int KNILENAHCHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public HIMPAEPMNBM FLHPGMFDMIO;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly PPGICKEFOFG PLAPLAPINBF;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public float LIHMLIFMCPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x238C090", Offset = "0x238A690", VA = "0x18238C090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public TimeSpan LJBOIIEPAPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x56C4A0", Offset = "0x56AAA0", VA = "0x18056C4A0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x238C250", Offset = "0x238A850", VA = "0x18238C250")]
		public PPGICKEFOFG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private readonly struct FLJNOEOGAIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public readonly TRequest OOMGMCFGDFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public readonly CancellationToken NOBLOPDMHIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public readonly TaskCompletionSource<TResult> JHLJPOIEIPC;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x13C3FE0", Offset = "0x13C25E0", VA = "0x1813C3FE0")]
		public FLJNOEOGAIE(TRequest OOMGMCFGDFM, TaskCompletionSource<TResult> JHLJPOIEIPC, CancellationToken NOBLOPDMHIK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class AFEBNFAJADC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7B83E0", Offset = "0x7B69E0", VA = "0x1807B83E0")]
		public AFEBNFAJADC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7B9D60", Offset = "0x7B8360", VA = "0x1807B9D60")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct AJCGMHGLICG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public global::JOPMPLPBOKB<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x13C3750", Offset = "0x13C1D50", VA = "0x1813C3750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7B82B0", Offset = "0x7B68B0", VA = "0x1807B82B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class IMDNGDMKPEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public FLJNOEOGAIE req;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public global::JOPMPLPBOKB<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7B83E0", Offset = "0x7B69E0", VA = "0x1807B83E0")]
		public IMDNGDMKPEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x13C85B0", Offset = "0x13C6BB0", VA = "0x1813C85B0")]
		internal void <ProcessQueue>b__0(Task<TResult> task)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CancellationTokenSource CEMDHMJNDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly List<FLJNOEOGAIE> LFAGBDCECEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly PPGICKEFOFG ILFLNOJLPJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly JPFNAHKDDLO LJGOOLJIBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Task KPPJAGOPKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private int HBOACCIOELG;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2380520", Offset = "0x237EB20", VA = "0x182380520")]
	public JOPMPLPBOKB(JPFNAHKDDLO LJGOOLJIBMC, [Optional] PPGICKEFOFG ILFLNOJLPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x237F670", Offset = "0x237DC70", VA = "0x18237F670")]
	public Task<TResult> IEOBOENJJMN(TRequest OOMGMCFGDFM, CancellationToken NOBLOPDMHIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x2380000", Offset = "0x237E600", VA = "0x182380000")]
	private void MOAJCCKMIEG(FLJNOEOGAIE MHMLMDHPDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x237EE40", Offset = "0x237D440", VA = "0x18237EE40")]
	[AsyncStateMachine(typeof(global::JOPMPLPBOKB<, >.AJCGMHGLICG))]
	private Task DDFNCJJGLMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x237FDA0", Offset = "0x237E3A0", VA = "0x18237FDA0")]
	private FLJNOEOGAIE JJNLEMOEDLI()
	{
		return default(FLJNOEOGAIE);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x237EA70", Offset = "0x237D070", VA = "0x18237EA70")]
	private void BIAOEDLNCFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x237F170", Offset = "0x237D770", VA = "0x18237F170", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[DefaultMember("Item")]
public class KBHCDNPAALB<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public delegate int PJPCBHKNNHK(TKey CAOGILCCJKA, TVal JKOBKIEBPCF);

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class JKDCDOGFDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public TKey EOAEJCJEKMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x56C4A0", Offset = "0x56AAA0", VA = "0x18056C4A0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public TVal OFOOFEJCCGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x5B1040", Offset = "0x5AF640", VA = "0x1805B1040")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x5B1000", Offset = "0x5AF600", VA = "0x1805B1000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public int LOLCIANACDE
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x56D510", Offset = "0x56BB10", VA = "0x18056D510")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x56D4A0", Offset = "0x56BAA0", VA = "0x18056D4A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public DateTime KJMEDCHPLJB
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x50DD90", Offset = "0x50C390", VA = "0x18050DD90")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x6FB6B0", Offset = "0x6F9CB0", VA = "0x1806FB6B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x237E6E0", Offset = "0x237CCE0", VA = "0x18237E6E0")]
		public JKDCDOGFDNJ(TKey CAOGILCCJKA, TVal JNJFNAOGKKP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public const int NKODEKJMLJG = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly Dictionary<TKey, LinkedListNode<JKDCDOGFDNJ>> GKHGMCEHJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly LinkedList<JKDCDOGFDNJ> NADOHOBFOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly PJPCBHKNNHK MODHKDHELFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly TimeSpan PNMCNIEPBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly IDEFPKHBBEL FCILHBBGMJK;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int PJEIJJKEOJO
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x5192B0", Offset = "0x5178B0", VA = "0x1805192B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private bool DCGNKMLPFPM
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x23830C0", Offset = "0x23816C0", VA = "0x1823830C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	internal int CNDOIFCJKBG
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x78D9F0", Offset = "0x78BFF0", VA = "0x18078D9F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8FE180", Offset = "0x8FC780", VA = "0x1808FE180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int JLOOKCACPHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7B9E10", Offset = "0x7B8410", VA = "0x1807B9E10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public IEnumerable<TKey> EBNFDHNEAOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2382A90", Offset = "0x2381090", VA = "0x182382A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public TVal IDICDLOAFIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x13CB7B0", Offset = "0x13C9DB0", VA = "0x1813CB7B0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2382A60", Offset = "0x2381060", VA = "0x182382A60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x2383F60", Offset = "0x2382560", VA = "0x182383F60")]
	public KBHCDNPAALB(int PNGOPGJMFFI, [Optional] PJPCBHKNNHK MODHKDHELFC, [Optional] IEqualityComparer<TKey> BHHGAKLPGDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2384100", Offset = "0x2382700", VA = "0x182384100")]
	public KBHCDNPAALB(TimeSpan PNMCNIEPBGH, [Optional] IEqualityComparer<TKey> BHHGAKLPGDK, [Optional] IDEFPKHBBEL FCILHBBGMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2383F10", Offset = "0x2382510", VA = "0x182383F10")]
	public KBHCDNPAALB(int PNGOPGJMFFI, TimeSpan PNMCNIEPBGH, [Optional] IEqualityComparer<TKey> BHHGAKLPGDK, [Optional] IDEFPKHBBEL FCILHBBGMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2383CC0", Offset = "0x23822C0", VA = "0x182383CC0")]
	public KBHCDNPAALB(int PNGOPGJMFFI, PJPCBHKNNHK MODHKDHELFC, TimeSpan PNMCNIEPBGH, [Optional] IEqualityComparer<TKey> BHHGAKLPGDK, [Optional] IDEFPKHBBEL FCILHBBGMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x23826F0", Offset = "0x2380CF0", VA = "0x1823826F0")]
	public void DABKJDNBODB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x23828E0", Offset = "0x2380EE0", VA = "0x1823828E0")]
	public void ENJDGFBIGDL(TKey CAOGILCCJKA, TVal JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x2383670", Offset = "0x2381C70", VA = "0x182383670")]
	public bool PFBLIKHMAGM(TKey CAOGILCCJKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2382630", Offset = "0x2380C30", VA = "0x182382630")]
	private TVal CFNFGAKIEIE(TKey FBDLPCCKCBH)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x2382400", Offset = "0x2380A00", VA = "0x182382400")]
	public bool BHCEMEACFLD(TKey FBDLPCCKCBH, out TVal JKOBKIEBPCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2382860", Offset = "0x2380E60", VA = "0x182382860")]
	public void EAPDGKCCOIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2383C00", Offset = "0x2382200", VA = "0x182383C00")]
	private bool PPBNCDFLHHM(JKDCDOGFDNJ FMPGJCKFCAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x23833E0", Offset = "0x23819E0", VA = "0x1823833E0")]
	private void OBEFPACNJDE(LinkedListNode<JKDCDOGFDNJ> KKBGNAHPACD, TVal LGCPMIGECAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x2382CB0", Offset = "0x23812B0", VA = "0x182382CB0")]
	private void IEEFCIHIGIO(TKey CAOGILCCJKA, TVal JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x2383800", Offset = "0x2381E00", VA = "0x182383800")]
	private void PFPLGLDLPFL(JKDCDOGFDNJ FMPGJCKFCAL, TVal LGCPMIGECAO, int KEHBCMCDGAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[DefaultMember("Item")]
public class FFNFOLMMDMH<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly List<T> EFFDBMEPJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private HashSet<T> LMBIIFGNCHF;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int JLOOKCACPHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7B9D60", Offset = "0x7B8360", VA = "0x1807B9D60", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool EFJPPNPLLLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x511400", Offset = "0x50FA00", VA = "0x180511400", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public T IDICDLOAFIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x1B92CC0", Offset = "0x1B912C0", VA = "0x181B92CC0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x4693DB0", Offset = "0x46923B0", VA = "0x184693DB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x13C89F0", Offset = "0x13C6FF0", VA = "0x1813C89F0", Slot = "11")]
	public void Add(T NGDPDJFCGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x46937E0", Offset = "0x4691DE0", VA = "0x1846937E0")]
	public bool JOHNOICNCIN(T NGDPDJFCGCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x4693C50", Offset = "0x4692250", VA = "0x184693C50", Slot = "15")]
	public bool Remove(T NGDPDJFCGCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x9D4EE0", Offset = "0x9D34E0", VA = "0x1809D4EE0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x1A97C80", Offset = "0x1A96280", VA = "0x181A97C80", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x46934E0", Offset = "0x4691AE0", VA = "0x1846934E0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x133CB80", Offset = "0x133B180", VA = "0x18133CB80", Slot = "13")]
	public bool Contains(T NGDPDJFCGCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x4693540", Offset = "0x4691B40", VA = "0x184693540", Slot = "14")]
	public void CopyTo(T[] CDIMPGOIPOL, int FPMLOCEPCLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x13CB9F0", Offset = "0x13C9FF0", VA = "0x1813CB9F0", Slot = "6")]
	public int IndexOf(T NGDPDJFCGCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x46935A0", Offset = "0x4691BA0", VA = "0x1846935A0", Slot = "7")]
	public void Insert(int OEELHFBMNBJ, T NGDPDJFCGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x4693A20", Offset = "0x4692020", VA = "0x184693A20", Slot = "8")]
	public void RemoveAt(int OEELHFBMNBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x4693950", Offset = "0x4691F50", VA = "0x184693950")]
	public void OHBIPDLPOJI(Predicate<T> OPOFCPCELFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x4693570", Offset = "0x4691B70", VA = "0x184693570")]
	public void GHFDGLEOEOP(Comparison<T> EFBLEGJBEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x4693CD0", Offset = "0x46922D0", VA = "0x184693CD0")]
	public FFNFOLMMDMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class IHLFOLMLHPG
{
	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x3160920", Offset = "0x315EF20", VA = "0x183160920")]
	public static Vector3 LEDDMBMNLPK(this GameObject NPJKABNGMNJ, float LIAHBFKEBNK)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x915CE0", Offset = "0x9142E0", VA = "0x180915CE0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3162F40", Offset = "0x3161540", VA = "0x183162F40")]
		public SerializedGuid(in Guid KNKNKFMFNBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3162DF0", Offset = "0x31613F0", VA = "0x183162DF0")]
		public static SerializedGuid MEAKIIAPLJH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3162CE0", Offset = "0x31612E0", VA = "0x183162CE0")]
		public static SerializedGuid HFLGFGFEJFI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3162D60", Offset = "0x3161360", VA = "0x183162D60")]
		public bool LKNDFFOPGGM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3162F10", Offset = "0x3161510", VA = "0x183162F10", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3162E70", Offset = "0x3161470", VA = "0x183162E70", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3162C40", Offset = "0x3161240", VA = "0x183162C40")]
		public bool GPFFGOHIBEM(in Guid KNKNKFMFNBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3162AC0", Offset = "0x31610C0", VA = "0x183162AC0", Slot = "7")]
		public bool Equals(SerializedGuid HJALGMGCNFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3162B60", Offset = "0x3161160", VA = "0x183162B60", Slot = "0")]
		public override bool Equals(object KFIBIDDJFNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3162CD0", Offset = "0x31612D0", VA = "0x183162CD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3162A90", Offset = "0x3161090", VA = "0x183162A90", Slot = "6")]
		public int CompareTo(SerializedGuid HJALGMGCNFC)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class CMPLNBGIBPB : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly Type FAEDPJCJHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly string ECMOBOLOMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly bool CEJJOLBMMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly bool BLCBDNAANNG;

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x315DAF0", Offset = "0x315C0F0", VA = "0x18315DAF0")]
	public CMPLNBGIBPB(Type HBLDBDOLOLC, string NJLDDJEEIBG, bool EMDJNKCKDIO = false, bool ABNJJKAPEHC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface KCDIPEGCKCI
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface MBEBBJGOFIN<T> : KCDIPEGCKCI
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	T OFOOFEJCCGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	bool CKBJMNGJKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string FINBFOPDDAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::MBEBBJGOFIN<T> EHPKMGPMBOJ(Action<T> MMBNFLCCPOJ);

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::MBEBBJGOFIN<T> AJAOCKEBMEB(Action<T> MMBNFLCCPOJ);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::MBEBBJGOFIN<T> PFFAIDEPMDH(Action<T, T> BDHHMHOFEJN);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::MBEBBJGOFIN<T> JAOKCKMMCIG(Action<T, T> BDHHMHOFEJN);

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::MBEBBJGOFIN<T> DLGPIHHMBBI(Action<string> AJKMLHJBJOG);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::MBEBBJGOFIN<T> EEKIKMFEAHD(Action<string> AJKMLHJBJOG);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class JFOFNKOHJED<T> : global::MBEBBJGOFIN<T>, KCDIPEGCKCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private global::AMGECDDOGEP<T, T> DKMBPGNPMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private global::OEMIPNFNGHD<T> PHPEKGNEIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private global::OEMIPNFNGHD<string> CCPDEBIJPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private string DFNAEPAJNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private T BGLDGHJKFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private bool JLFMFFADFCP;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public T OFOOFEJCCGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x50DD80", Offset = "0x50C380", VA = "0x18050DD80", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x13D3210", Offset = "0x13D1810", VA = "0x1813D3210", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool CKBJMNGJKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x5AA8B0", Offset = "0x5A8EB0", VA = "0x1805AA8B0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public string FINBFOPDDAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x5135E0", Offset = "0x511BE0", VA = "0x1805135E0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7B9DE0", Offset = "0x7B83E0", VA = "0x1807B9DE0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x13D34D0", Offset = "0x13D1AD0", VA = "0x1813D34D0")]
	private void MCPNENBBKNE(T MAFAJIAHLEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x13D3120", Offset = "0x13D1720", VA = "0x1813D3120")]
	private void AFBIKIKPDPN(string MIKDPIOIEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x13D33D0", Offset = "0x13D19D0", VA = "0x1813D33D0")]
	public void ENDBOFMGBIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x13D3570", Offset = "0x13D1B70", VA = "0x1813D3570", Slot = "6")]
	public global::MBEBBJGOFIN<T> PFFAIDEPMDH(Action<T, T> BDHHMHOFEJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x13D3480", Offset = "0x13D1A80", VA = "0x1813D3480", Slot = "7")]
	public global::MBEBBJGOFIN<T> JAOKCKMMCIG(Action<T, T> BDHHMHOFEJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x13D3340", Offset = "0x13D1940", VA = "0x1813D3340", Slot = "4")]
	public global::MBEBBJGOFIN<T> EHPKMGPMBOJ(Action<T> BDHHMHOFEJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x13D31C0", Offset = "0x13D17C0", VA = "0x1813D31C0", Slot = "5")]
	public global::MBEBBJGOFIN<T> AJAOCKEBMEB(Action<T> MMBNFLCCPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x13D3240", Offset = "0x13D1840", VA = "0x1813D3240", Slot = "8")]
	public global::MBEBBJGOFIN<T> DLGPIHHMBBI(Action<string> AJKMLHJBJOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x13D32D0", Offset = "0x13D18D0", VA = "0x1813D32D0", Slot = "9")]
	public global::MBEBBJGOFIN<T> EEKIKMFEAHD(Action<string> AJKMLHJBJOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x13D35C0", Offset = "0x13D1BC0", VA = "0x1813D35C0")]
	public JFOFNKOHJED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class FJANOAIELOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class DDJJMEGOCKA<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public global::MBEBBJGOFIN<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public global::OHFKOJGDIOE<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x7B83E0", Offset = "0x7B69E0", VA = "0x1807B83E0")]
		public DDJJMEGOCKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x24C3870", Offset = "0x24C1E70", VA = "0x1824C3870")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x3EB9F70", Offset = "0x3EB8570", VA = "0x183EB9F70")]
	public static global::FPCEKCNKAAO<T> OKEMIACDDDM<T>(this global::MBEBBJGOFIN<T> JEMKNOBLNPJ, Action<T> POJIJEGMINL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public abstract class IDEFPKHBBEL
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class GDOLNDCGKBE : IDEFPKHBBEL
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static IDEFPKHBBEL EJBAJGKCNOF
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x315F200", Offset = "0x315D800", VA = "0x18315F200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override DateTime ALGJIADOGIK
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x315F1B0", Offset = "0x315D7B0", VA = "0x18315F1B0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override float MPDKBNGHGEH
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x31539E0", Offset = "0x3151FE0", VA = "0x1831539E0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x315F300", Offset = "0x315D900", VA = "0x18315F300")]
		public GDOLNDCGKBE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static IDEFPKHBBEL COJAAKAMMPN;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public static IDEFPKHBBEL PLAPLAPINBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3160440", Offset = "0x315EA40", VA = "0x183160440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public abstract DateTime ALGJIADOGIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public abstract float MPDKBNGHGEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	protected IDEFPKHBBEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class NCMOIEJOAHM : global::GCHOBBHNBGJ<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x3161000", Offset = "0x315F600", VA = "0x183161000")]
	public NCMOIEJOAHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class GCHOBBHNBGJ<T> : global::KEJPHNEBCDK<T>, DBMMFKPEFIL, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public Task<T> JINJOIEHKNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x56C4A0", Offset = "0x56AAA0", VA = "0x18056C4A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private Task NHKDCIDBOKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7B76A0", Offset = "0x7B5CA0", VA = "0x1807B76A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public global::FPCEKCNKAAO<T> ACINENELBAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	private GDOLLDLAJJG NKHHKHAGIKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x80F240", Offset = "0x80D840", VA = "0x18080F240", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x47AF7F0", Offset = "0x47ADDF0", VA = "0x1847AF7F0")]
	public GCHOBBHNBGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x51A920", Offset = "0x518F20", VA = "0x18051A920", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class HIFCLMGNNIK : global::PMBJKGBIHBJ<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x3160040", Offset = "0x315E640", VA = "0x183160040")]
	public HIFCLMGNNIK(Exception KGONAAJAECB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class PMBJKGBIHBJ<T> : global::KEJPHNEBCDK<T>, DBMMFKPEFIL, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public Task<T> JINJOIEHKNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x56C4A0", Offset = "0x56AAA0", VA = "0x18056C4A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	private Task NHKDCIDBOKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7B76A0", Offset = "0x7B5CA0", VA = "0x1807B76A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public global::FPCEKCNKAAO<T> ACINENELBAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	private GDOLLDLAJJG NKHHKHAGIKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x80F240", Offset = "0x80D840", VA = "0x18080F240", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x48DD160", Offset = "0x48DB760", VA = "0x1848DD160")]
	public PMBJKGBIHBJ(Exception KGONAAJAECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x51A920", Offset = "0x518F20", VA = "0x18051A920", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface DBMMFKPEFIL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	Task JINJOIEHKNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	[NotNull]
	GDOLLDLAJJG ACINENELBAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface KEJPHNEBCDK<T> : DBMMFKPEFIL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[NotNull]
	new Task<T> JINJOIEHKNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	[NotNull]
	new global::FPCEKCNKAAO<T> ACINENELBAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public abstract class FBECIFBIPEJ<TTask, T> : global::KEJPHNEBCDK<T>, DBMMFKPEFIL, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class EDHJEBCMNAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public global::FBECIFBIPEJ<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7B83E0", Offset = "0x7B69E0", VA = "0x1807B83E0")]
		public EDHJEBCMNAD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static bool GFDJJAIDFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly Task<T> CKMHCMHHPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	protected readonly CancellationTokenSource DCAPMJBGANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private bool MIIBLHFNHME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private SynchronizationContext IJDEAFMCIPJ;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public Task<T> JINJOIEHKNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x56C4A0", Offset = "0x56AAA0", VA = "0x18056C4A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private Task NHKDCIDBOKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x56C4A0", Offset = "0x56AAA0", VA = "0x18056C4A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public global::FPCEKCNKAAO<T> ACINENELBAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	private GDOLLDLAJJG NKHHKHAGIKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xABAF20", Offset = "0xAB9520", VA = "0x180ABAF20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool PFIAFMBMCBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x6B7390", Offset = "0x6B5990", VA = "0x1806B7390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x468D180", Offset = "0x468B780", VA = "0x18468D180")]
	static FBECIFBIPEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x468D460", Offset = "0x468BA60", VA = "0x18468D460")]
	protected FBECIFBIPEJ(TTask CKMHCMHHPMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x468CD10", Offset = "0x468B310", VA = "0x18468CD10", Slot = "1")]
	~FBECIFBIPEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x169AAC0", Offset = "0x16990C0", VA = "0x18169AAC0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x468CFC0", Offset = "0x468B5C0", VA = "0x18468CFC0")]
	private void HGJFGLHEDBN(bool LOFNGHHMGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T LOAIGMDENDJ(TTask GAMBHNONIEG);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void OJHACLMFOIE();

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x468D130", Offset = "0x468B730", VA = "0x18468D130")]
	[CompilerGenerated]
	private void HMIHPKMMHIC(object PKDKJLKNGLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class JNAJBHKPOAB : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly Type FAEDPJCJHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public readonly string ECMOBOLOMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public readonly bool CEJJOLBMMOJ;

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x3160BB0", Offset = "0x315F1B0", VA = "0x183160BB0")]
	public JNAJBHKPOAB(Type HBLDBDOLOLC, string NJLDDJEEIBG, bool EMDJNKCKDIO = false)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x539130", Offset = "0x537730", VA = "0x180539130")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x70C3B0", Offset = "0x70A9B0", VA = "0x18070C3B0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public T this[int BFJPGBKBCMP, int MPNLJFCCHKB]
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x80AC70", Offset = "0x809270", VA = "0x18080AC70")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x80AD10", Offset = "0x809310", VA = "0x18080AD10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x80ABE0", Offset = "0x8091E0", VA = "0x18080ABE0")]
		public Array2D(uint PPFMJFLCFJD, uint BIOALPENMMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x80AB60", Offset = "0x809160", VA = "0x18080AB60")]
		public void EAPDGKCCOIG()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x315D430", Offset = "0x315BA30", VA = "0x18315D430")]
		public Array2DVector3(uint PPFMJFLCFJD, uint BIOALPENMMK)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class DJLPNEJIEEN
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private enum CECBFDMPMAG : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private int PGEBMDOGHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool GBIEBFNNPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private CECBFDMPMAG JMPOAHOEOEC;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool DLJKFDLMMOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x315DF80", Offset = "0x315C580", VA = "0x18315DF80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool CGFBGHOMHEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x315DD80", Offset = "0x315C380", VA = "0x18315DD80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x315EA80", Offset = "0x315D080", VA = "0x18315EA80")]
	public DJLPNEJIEEN(bool GBIEBFNNPAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x315E560", Offset = "0x315CB60", VA = "0x18315E560")]
	public void OPOLDGEIAIO(object KFIBIDDJFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x315E040", Offset = "0x315C640", VA = "0x18315E040")]
	public void JEMHPIJFENP(int JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x315DD90", Offset = "0x315C390", VA = "0x18315DD90")]
	public void DBDLINPPMPB(uint KLKFBJALAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x315DE40", Offset = "0x315C440", VA = "0x18315DE40")]
	public void GNIJBLMIHBD(bool FLDBOJNCGKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x315E520", Offset = "0x315CB20", VA = "0x18315E520")]
	public void MELILHMFGJF(long PPMDEDJEJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x315E000", Offset = "0x315C600", VA = "0x18315E000")]
	public void IIIAADDHEMI(ulong JEJPOAHIPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x315DD10", Offset = "0x315C310", VA = "0x18315DD10")]
	public void CCFFEIMCHAJ(string LPGAJGGCIPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x315DDB0", Offset = "0x315C3B0", VA = "0x18315DDB0")]
	public void FOADEENLABK(Enum KGONAAJAECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x315DE60", Offset = "0x315C460", VA = "0x18315DE60")]
	public void HLKOCKINNFL(IList EFFDBMEPJFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x437F2B0", Offset = "0x437D8B0", VA = "0x18437F2B0")]
	public void NAMEKFABJBH<T, U>(Dictionary<T, U> NEBKNFOADBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x315E160", Offset = "0x315C760", VA = "0x18315E160")]
	private void LMJANMADCMM(IDictionary NEBKNFOADBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x315E0F0", Offset = "0x315C6F0", VA = "0x18315E0F0")]
	public int LHIPHBECKII()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x315DCA0", Offset = "0x315C2A0", VA = "0x18315DCA0")]
	public short AINFJPFADFC()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x315DDA0", Offset = "0x315C3A0", VA = "0x18315DDA0")]
	public void EAPDGKCCOIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x315DF90", Offset = "0x315C590", VA = "0x18315DF90")]
	private void IGBGFDCCKHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public abstract class OCNNPKFBPPG<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	internal class PGBFOGGKFNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public TNode PHPJHDBOBNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public TNode IJHBOGOHCCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public FLAAHMLECHG CKNNFNMCEAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public List<FLAAHMLECHG> HCBMMANBJDL;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x7B83E0", Offset = "0x7B69E0", VA = "0x1807B83E0")]
		public PGBFOGGKFNJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	internal struct FLAAHMLECHG : IComparable<FLAAHMLECHG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public int LMHEDNCJECN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public TClaimant HPPDDGECAFC;

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7EEC80", Offset = "0x7ED280", VA = "0x1807EEC80")]
		public FLAAHMLECHG(int LMHEDNCJECN, TClaimant HPPDDGECAFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x23412B0", Offset = "0x233F8B0", VA = "0x1823412B0")]
		public bool MIJJADNCDLO(in FLAAHMLECHG HJALGMGCNFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x23412A0", Offset = "0x233F8A0", VA = "0x1823412A0")]
		public bool ICFJADEGAKO(in FLAAHMLECHG HJALGMGCNFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x2341290", Offset = "0x233F890", VA = "0x182341290", Slot = "4")]
		public int CompareTo(FLAAHMLECHG HJALGMGCNFC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x2341310", Offset = "0x233F910", VA = "0x182341310", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public enum BGADOIGPLCM
	{
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class NCIDHACDBOI : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public global::OCNNPKFBPPG<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xAB7C10", Offset = "0xAB6210", VA = "0x180AB7C10")]
		[DebuggerHidden]
		public NCIDHACDBOI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x51A920", Offset = "0x518F20", VA = "0x18051A920", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x2344160", Offset = "0x2342760", VA = "0x182344160", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x2344320", Offset = "0x2342920", VA = "0x182344320", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x2344240", Offset = "0x2342840", VA = "0x182344240", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x816660", Offset = "0x814C60", VA = "0x180816660", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static readonly global::DGAJAMLHMEN<PGBFOGGKFNJ> MFBGGLBOJLO;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static readonly global::DGAJAMLHMEN<List<FLAAHMLECHG>> JHLPGLAOCLH;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static int GCFEBHMEGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	internal readonly Dictionary<TClaimant, TNode> KCEHHGIPEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	internal readonly Dictionary<TNode, PGBFOGGKFNJ> GJNDOMFFDNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private BGADOIGPLCM KIBPEKJHLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private bool DHMBELKIPCN;

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode EDLPAPHLAPG(TNode HKAHEJFPDGM);

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void DKGLHPGIIHE(TNode HKAHEJFPDGM, TClaimant KDEKIDFMNBB, TClaimant PPBCHLPFBPG);

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x234B310", Offset = "0x2349910", VA = "0x18234B310")]
	public OCNNPKFBPPG(BGADOIGPLCM KIBPEKJHLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x234A420", Offset = "0x2348A20", VA = "0x18234A420")]
	public void GILAFGHHKIA(TNode HKAHEJFPDGM, TNode FCGBLBHLBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2349E90", Offset = "0x2348490", VA = "0x182349E90")]
	public void CLFOGMECPHD(TClaimant HPPDDGECAFC, TNode JPJDKMKGLPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2349F90", Offset = "0x2348590", VA = "0x182349F90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x2349B40", Offset = "0x2348140", VA = "0x182349B40")]
	private void AMHJFMHBFGC(TClaimant HPPDDGECAFC, TNode IGJHHOLGCGP, TNode JPJDKMKGLPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x234A1F0", Offset = "0x23487F0", VA = "0x18234A1F0")]
	private int EKAOCJNFBLG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x2349BE0", Offset = "0x23481E0", VA = "0x182349BE0")]
	private void BFDFIGMBCAO(TClaimant HPPDDGECAFC, TNode OBPHLDDPCOC, TNode GHHDKNCEGKH, int PGCPDODOKBF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x2349AB0", Offset = "0x23480B0", VA = "0x182349AB0")]
	private void ALGBPIKAPDK(FLAAHMLECHG DILJLICAFGP, PGBFOGGKFNJ JIADJEFDGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x234ABA0", Offset = "0x23491A0", VA = "0x18234ABA0")]
	private void JIHBAJNFBFO(TClaimant HPPDDGECAFC, TNode OBPHLDDPCOC, TNode GHHDKNCEGKH, int PGCPDODOKBF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x234A8E0", Offset = "0x2348EE0", VA = "0x18234A8E0")]
	private void GOJLEJGCBBE(FLAAHMLECHG DILJLICAFGP, TNode HKAHEJFPDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x234A320", Offset = "0x2348920", VA = "0x18234A320")]
	private void FJONMEPMBGP(FLAAHMLECHG DILJLICAFGP, PGBFOGGKFNJ JIADJEFDGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x234B070", Offset = "0x2349670", VA = "0x18234B070")]
	private void PEOPLKDNPLA(PGBFOGGKFNJ JIADJEFDGFD, bool KKBBFPPGHBH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x234A4A0", Offset = "0x2348AA0", VA = "0x18234A4A0")]
	private void GJEHHFGBPMK(PGBFOGGKFNJ JIADJEFDGFD, TNode FCGBLBHLBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x234AE10", Offset = "0x2349410", VA = "0x18234AE10")]
	[IteratorStateMachine(typeof(global::OCNNPKFBPPG<, >.NCIDHACDBOI))]
	private IEnumerable<TNode> JLPANABNOIE(TNode OBPHLDDPCOC, TNode GHHDKNCEGKH, bool KNALKBFDCGL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x234A260", Offset = "0x2348860", VA = "0x18234A260")]
	private PGBFOGGKFNJ FDOIGJILMOF(TNode HKAHEJFPDGM, TNode IJHBOGOHCCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x234AEE0", Offset = "0x23494E0", VA = "0x18234AEE0")]
	private PGBFOGGKFNJ PCFBHDOLEDN(TNode HKAHEJFPDGM, TNode IJHBOGOHCCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x234A9E0", Offset = "0x2348FE0", VA = "0x18234A9E0")]
	private void JAEHDLGDHPL(PGBFOGGKFNJ JIADJEFDGFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class DLJCIMHPMCJ<T> : IEnumerable<global::DLJCIMHPMCJ<T>.GBIKIGIENHM>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public struct GBIKIGIENHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public T JKOBKIEBPCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public int OEELHFBMNBJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class HGIALDFHLND : IEnumerator<GBIKIGIENHM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private global::DLJCIMHPMCJ<T> AKEKDLLMOPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private int OEELHFBMNBJ;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x1715090", Offset = "0x1713690", VA = "0x181715090", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public GBIKIGIENHM GPIEOLHEKEO
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x1715100", Offset = "0x1713700", VA = "0x181715100", Slot = "4")]
			get
			{
				return default(GBIKIGIENHM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8B9850", Offset = "0x8B7E50", VA = "0x1808B9850")]
		public HGIALDFHLND(global::DLJCIMHPMCJ<T> AKEKDLLMOPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x1715000", Offset = "0x1713600", VA = "0x181715000", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x8B9840", Offset = "0x8B7E40", VA = "0x1808B9840", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x1294A60", Offset = "0x1293060", VA = "0x181294A60", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private struct KGEGJEABPAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public bool HMGELFCLAKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public T JKOBKIEBPCF;
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private const int DMALGAPEPME = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private Dictionary<T, int> DLKOHADNIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private KGEGJEABPAK[] DAFJPNMJBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private int GLKHJHAOEPG;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public int JLOOKCACPHA
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7B9E40", Offset = "0x7B8440", VA = "0x1807B9E40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x170A880", Offset = "0x1708E80", VA = "0x18170A880")]
	public static global::DLJCIMHPMCJ<T> LDKHHIPMLFF(GBIKIGIENHM[] KPGIHJOHLED, bool PNLPBPOHHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x170AFF0", Offset = "0x17095F0", VA = "0x18170AFF0")]
	public DLJCIMHPMCJ(int PNGOPGJMFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x9D4E80", Offset = "0x9D3480", VA = "0x1809D4E80")]
	public bool AOCPJGDILLF(T JKOBKIEBPCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x170A820", Offset = "0x1708E20", VA = "0x18170A820")]
	public bool KONKDFPLGNM(int OEELHFBMNBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x170A3E0", Offset = "0x17089E0", VA = "0x18170A3E0")]
	public bool CMKDNCJELMF(Func<T, bool> CNDBAHDFDHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x170A490", Offset = "0x1708A90", VA = "0x18170A490")]
	public int DMJNLGFEJCJ(T JKOBKIEBPCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x170AE80", Offset = "0x1709480", VA = "0x18170AE80")]
	public T OKEMIACDDDM(int OEELHFBMNBJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x170A4E0", Offset = "0x1708AE0", VA = "0x18170A4E0")]
	public void EAPDGKCCOIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x170A530", Offset = "0x1708B30", VA = "0x18170A530")]
	public bool JOHNOICNCIN(T JKOBKIEBPCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x170A550", Offset = "0x1708B50", VA = "0x18170A550")]
	public bool JOHNOICNCIN(T JKOBKIEBPCF, int OEELHFBMNBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x170AEF0", Offset = "0x17094F0", VA = "0x18170AEF0")]
	public bool PFBLIKHMAGM(T JKOBKIEBPCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x170A780", Offset = "0x1708D80", VA = "0x18170A780")]
	public bool KDDGDAMGBAM(int OEELHFBMNBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x170AC60", Offset = "0x1709260", VA = "0x18170AC60")]
	private void LGHBHIIKMIP(int OEELHFBMNBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x170AD10", Offset = "0x1709310", VA = "0x18170AD10")]
	public GBIKIGIENHM[] MFEACMAADLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x170A7D0", Offset = "0x1708DD0", VA = "0x18170A7D0")]
	private int KFPFMMEKEJH(int HOGJMFJENKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x170AF70", Offset = "0x1709570", VA = "0x18170AF70", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x170AF70", Offset = "0x1709570", VA = "0x18170AF70", Slot = "4")]
	private IEnumerator<GBIKIGIENHM> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class DGAJAMLHMEN<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly Stack<T> IHMJNPFMNMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly List<T> IPPEBJDBGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly int EJJOONDJJOE;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public int MKMJMBIALMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x813FA0", Offset = "0x8125A0", VA = "0x180813FA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int BIMBHAFDIPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x80D340", Offset = "0x80B940", VA = "0x18080D340")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x4102710", Offset = "0x4100D10", VA = "0x184102710")]
	public static global::DGAJAMLHMEN<T> EILENLHHHCK(int PNGOPGJMFFI = 0, int EJJOONDJJOE = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x4102CF0", Offset = "0x41012F0", VA = "0x184102CF0")]
	public static global::DGAJAMLHMEN<T> OPKOFODCJOK(int PNGOPGJMFFI = 0, int EJJOONDJJOE = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x4102F50", Offset = "0x4101550", VA = "0x184102F50")]
	public DGAJAMLHMEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x4102DC0", Offset = "0x41013C0", VA = "0x184102DC0")]
	public DGAJAMLHMEN(int PNGOPGJMFFI, int EJJOONDJJOE = int.MaxValue, bool PKHNIMMCLLF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x41024D0", Offset = "0x4100AD0", VA = "0x1841024D0")]
	public T CPODIFLMMHG()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x4102880", Offset = "0x4100E80", VA = "0x184102880")]
	public void FMHNNHNIHDK(T JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x4102B60", Offset = "0x4101160", VA = "0x184102B60")]
	private void GHJAFCGIJFE(T JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x4102C20", Offset = "0x4101220", VA = "0x184102C20")]
	private void JNHCPOLIHCO(T JKOBKIEBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x41027E0", Offset = "0x4100DE0", VA = "0x1841027E0")]
	[Conditional("DEBUG_BUILD")]
	private void FLALMDLLCBE(T JFHBCILMDLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x4102C40", Offset = "0x4101240", VA = "0x184102C40")]
	[Conditional("DEBUG_BUILD")]
	private void KBHFMFHKHGH(T JFHBCILMDLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x4102600", Offset = "0x4100C00", VA = "0x184102600", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x4102940", Offset = "0x4100F40", VA = "0x184102940")]
	private void GEECACDOAKF(IEnumerable<T> AOPOMEEJMGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class KBJGIGNKIPF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private Dictionary<int, T> BBAOEFBMAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private T KGGMMCHNIDO;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public virtual T IIGOCGGBKCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x56B740", Offset = "0x569D40", VA = "0x18056B740", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public bool CIIFBCKDDKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x2384B60", Offset = "0x2383160", VA = "0x182384B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x2384AA0", Offset = "0x23830A0", VA = "0x182384AA0")]
	public bool IEEFCIHIGIO(T JKOBKIEBPCF, int LMHEDNCJECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x2384BA0", Offset = "0x23831A0", VA = "0x182384BA0")]
	public bool NCCBPHPKCLP(int LMHEDNCJECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x2384840", Offset = "0x2382E40", VA = "0x182384840")]
	public T FKIFDHMOOHD(int EMCPKDBDOHM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x2384570", Offset = "0x2382B70", VA = "0x182384570")]
	public void EAPDGKCCOIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x23843D0", Offset = "0x23829D0", VA = "0x1823843D0")]
	private bool BNEKMJFAHKI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x23843A0", Offset = "0x23829A0", VA = "0x1823843A0")]
	public bool BHCEMEACFLD(int LMHEDNCJECN, out T JKOBKIEBPCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x1ADDA30", Offset = "0x1ADC030", VA = "0x181ADDA30")]
	public KBJGIGNKIPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class MMPHEMAAMEE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	protected struct CGALFBBDIEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public T OFOOFEJCCGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public int AEEKLJFHFLL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	protected readonly List<CGALFBBDIEM> LIDIMPJLJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private T CNAMIPHKJJG;

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public int JLOOKCACPHA
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7B9D60", Offset = "0x7B8360", VA = "0x1807B9D60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x2746F90", Offset = "0x2745590", VA = "0x182746F90")]
	public bool CMKDNCJELMF(T JKOBKIEBPCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x2747340", Offset = "0x2745940", VA = "0x182747340")]
	public void OAKCALBAGFG(T JKOBKIEBPCF, int LMHEDNCJECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x27475F0", Offset = "0x2745BF0", VA = "0x1827475F0")]
	public bool PFBLIKHMAGM(T JKOBKIEBPCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x2747270", Offset = "0x2745870", VA = "0x182747270")]
	public void EAPDGKCCOIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x27471E0", Offset = "0x27457E0", VA = "0x1827471E0")]
	public T CMOINDFNDJA()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x27472D0", Offset = "0x27458D0", VA = "0x1827472D0")]
	public T JJNLEMOEDLI()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x27473E0", Offset = "0x27459E0", VA = "0x1827473E0")]
	private void ONJNGEPBEBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x2747710", Offset = "0x2745D10", VA = "0x182747710")]
	public MMPHEMAAMEE()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[SerializeField]
		[AKDNOBOMHFK(JFEDCPFKCIP.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x31614A0", Offset = "0x315FAA0", VA = "0x1831614A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x3161970", Offset = "0x315FF70", VA = "0x183161970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x3161790", Offset = "0x315FD90", VA = "0x183161790")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x3161B10", Offset = "0x3160110", VA = "0x183161B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x3161360", Offset = "0x315F960", VA = "0x183161360")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x3161830", Offset = "0x315FE30", VA = "0x183161830")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x3161650", Offset = "0x315FC50", VA = "0x183161650")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x31612C0", Offset = "0x315F8C0", VA = "0x1831612C0")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface CMFPGDAALOG
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public abstract class ResourcePrefabReference<T> : CMFPGDAALOG where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x81EC20", Offset = "0x81D220", VA = "0x18081EC20", Slot = "4")]
		public virtual T BCIAEGMAOPB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7B83E0", Offset = "0x7B69E0", VA = "0x1807B83E0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class HFDGINAHDAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<byte, CALMICJDMLK> OADLLBBMEDB;

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public CALMICJDMLK NMANHBAGEDH
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x56C4A0", Offset = "0x56AAA0", VA = "0x18056C4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x56C4B0", Offset = "0x56AAB0", VA = "0x18056C4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public Vector2 PFFOHBEFCJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x1666BC0", Offset = "0x16651C0", VA = "0x181666BC0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x1ADD970", Offset = "0x1ADBF70", VA = "0x181ADD970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Vector2 ABJDBLCJHEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x5AA0E0", Offset = "0x5A86E0", VA = "0x1805AA0E0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x5AA1A0", Offset = "0x5A87A0", VA = "0x1805AA1A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector2 MMBHKFILFKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x1B8C4D0", Offset = "0x1B8AAD0", VA = "0x181B8C4D0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x1B8C4F0", Offset = "0x1B8AAF0", VA = "0x181B8C4F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public int FGCLHKKHMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7028D0", Offset = "0x700ED0", VA = "0x1807028D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x702910", Offset = "0x700F10", VA = "0x180702910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x315FB20", Offset = "0x315E120", VA = "0x18315FB20")]
	public HFDGINAHDAH(Bounds GBNFFCIEPPN, Vector2[] GKFHJGLFAHG, int NPJKFIJKCKL, byte HOGJMFJENKM, float LCMHMJBBKAB = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x315F360", Offset = "0x315D960", VA = "0x18315F360")]
	public CALMICJDMLK AFHHDBGDNOO(byte OEELHFBMNBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x315F3C0", Offset = "0x315D9C0", VA = "0x18315F3C0")]
	public void KPGCMFPOAIP(Vector3 ADGNDOLJLDH, float IEKKJNAKKKK, float MOLADJNEHAO, ref List<byte> MADBKDBLEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x315F4B0", Offset = "0x315DAB0", VA = "0x18315F4B0")]
	public void LIENMNDIPNK(CALMICJDMLK.KBPCNHFMLBH CNBEIGOCKLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x315F4D0", Offset = "0x315DAD0", VA = "0x18315F4D0")]
	private CALMICJDMLK MNDGCNDMBBA(byte OEELHFBMNBJ, CALMICJDMLK.AAMKLIGNJAN DCBNEIABNBA, CALMICJDMLK IJHBOGOHCCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x315F600", Offset = "0x315DC00", VA = "0x18315F600")]
	private void OCGOHMHDLHF(CALMICJDMLK IJHBOGOHCCC, Vector2[] GKFHJGLFAHG, int NNCJHKLBCHI, int GODOGPFHJJP, int JKMHPDDKPIO, int PKHADKHOKOJ, float LCMHMJBBKAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class CALMICJDMLK
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public enum AAMKLIGNJAN
	{
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public enum KBPCNHFMLBH
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public byte FDDKMKJJJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public Vector3 JFPPFHBBOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public Vector3 LOLCIANACDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public Vector3 BCANJJKPHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public Vector3 MHBMIEPCDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public AAMKLIGNJAN PACCCAAMEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public CALMICJDMLK CPHOAECDIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public List<CALMICJDMLK> EKKFJMCDHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public bool BLPLLKLMJJL;

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x315D8C0", Offset = "0x315BEC0", VA = "0x18315D8C0")]
	public CALMICJDMLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x315D860", Offset = "0x315BE60", VA = "0x18315D860")]
	public CALMICJDMLK(byte CLEEBEFEDCL, AAMKLIGNJAN DCBNEIABNBA, CALMICJDMLK IJHBOGOHCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x315D780", Offset = "0x315BD80", VA = "0x18315D780")]
	public void NAKLECGNDDF(CALMICJDMLK MIJMNOFBPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x51A920", Offset = "0x518F20", VA = "0x18051A920")]
	public void LIENMNDIPNK(int AOIBFOGIGAM, KBPCNHFMLBH CNBEIGOCKLM, int CPOHGCPOEDN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x315D4F0", Offset = "0x315BAF0", VA = "0x18315D4F0")]
	public void KPGCMFPOAIP(List<byte> MADBKDBLEOG, Vector3 ADGNDOLJLDH, float IEKKJNAKKKK, float MOLADJNEHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x315D490", Offset = "0x315BA90", VA = "0x18315D490")]
	public bool INIBFMKNJIJ(Vector3 AHEIOLGHMND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x315D820", Offset = "0x315BE20", VA = "0x18315D820")]
	public bool PDJPNFCMHAD(Vector3 AHEIOLGHMND, float NEIBOCECBGO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class CDHLECAOOPL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly Dictionary<T, object> OHFKIBLBPKA;

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x133CC30", Offset = "0x133B230", VA = "0x18133CC30")]
	public bool CMOGPKNLCPB(T FCPFFFEEPKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x212B340", Offset = "0x2129940", VA = "0x18212B340")]
	public bool CMOGPKNLCPB(T FCPFFFEEPKG, object GAAIDBMHBFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x212B380", Offset = "0x2129980", VA = "0x18212B380")]
	public bool CMOGPKNLCPB(T FCPFFFEEPKG, object GAAIDBMHBFM, out object OJKGMDCHPOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x212B3E0", Offset = "0x21299E0", VA = "0x18212B3E0")]
	public bool HPLICIFJEHK(T FCPFFFEEPKG, object GAAIDBMHBFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x212B4E0", Offset = "0x2129AE0", VA = "0x18212B4E0")]
	public bool OPCBPCHPPIE(T FCPFFFEEPKG, object GAAIDBMHBFM, out object OJKGMDCHPOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x212B420", Offset = "0x2129A20", VA = "0x18212B420")]
	public bool HPLICIFJEHK(T FCPFFFEEPKG, object GAAIDBMHBFM, out object OJKGMDCHPOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x212B4B0", Offset = "0x2129AB0", VA = "0x18212B4B0")]
	public void JOEFNPLKLPO(T FCPFFFEEPKG, object GAAIDBMHBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x212B2A0", Offset = "0x21298A0", VA = "0x18212B2A0")]
	public void AHNEFBBPNEC(T FCPFFFEEPKG, object GAAIDBMHBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x212B520", Offset = "0x2129B20", VA = "0x18212B520")]
	public CDHLECAOOPL()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		public struct HIHJLJBIKIC<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			private readonly List<Component> EFFDBMEPJFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			private readonly bool DKLEPABEDMF;

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x811A90", Offset = "0x810090", VA = "0x180811A90")]
			public HIHJLJBIKIC(List<Component> EFFDBMEPJFG, bool DKLEPABEDMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x811940", Offset = "0x80FF40", VA = "0x180811940")]
			public JFKPCNEFDPO<T> DJLEFEIHJJC()
			{
				return default(JFKPCNEFDPO<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x8119B0", Offset = "0x80FFB0", VA = "0x1808119B0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x8119B0", Offset = "0x80FFB0", VA = "0x1808119B0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public struct JFKPCNEFDPO<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			private readonly List<Component> EFFDBMEPJFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			private readonly bool DKLEPABEDMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			private int OEELHFBMNBJ;

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			public T GPIEOLHEKEO
			{
				[Cpp2IlInjected.Token(Token = "0x60002B3")]
				[Cpp2IlInjected.Address(RVA = "0x813E90", Offset = "0x812490", VA = "0x180813E90", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002B4")]
				[Cpp2IlInjected.Address(RVA = "0x813E20", Offset = "0x812420", VA = "0x180813E20", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x813E60", Offset = "0x812460", VA = "0x180813E60")]
			public JFKPCNEFDPO(List<Component> EFFDBMEPJFG, bool DKLEPABEDMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x813D50", Offset = "0x812350", VA = "0x180813D50", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x813D60", Offset = "0x812360", VA = "0x180813D60", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x813E10", Offset = "0x812410", VA = "0x180813E10", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x31637D0", Offset = "0x3161DD0", VA = "0x1831637D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x3163790", Offset = "0x3161D90", VA = "0x183163790")]
		public ToolHierarchyCache(GameObject ODDCIBPJDKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x3163000", Offset = "0x3161600", VA = "0x183163000")]
		private void BMGFGFNKNCO(GameObject ODDCIBPJDKC, bool KMCHJDBILIE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x3162F70", Offset = "0x3161570", VA = "0x183162F70")]
		public static void BMGFGFNKNCO(GameObject ODDCIBPJDKC, ref ToolHierarchyCache DKLFFHDHOPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x3163120", Offset = "0x3161720", VA = "0x183163120")]
		public void CHLIKIODMDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x31636E0", Offset = "0x3161CE0", VA = "0x1831636E0")]
		public void PIHDPENMGKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x41B9740", Offset = "0x41B7D40", VA = "0x1841B9740")]
		public void CBDBDDGJHED<T>(Action<T> DAENONOLDPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x3163370", Offset = "0x3161970", VA = "0x183163370")]
		public Component JBKBMEKDIDE(Type JOBKDGGGOHC, bool DKLEPABEDMF = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x403FC00", Offset = "0x403E200", VA = "0x18403FC00")]
		public T JBKBMEKDIDE<T>(bool DKLEPABEDMF = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x31632E0", Offset = "0x31618E0", VA = "0x1831632E0")]
		public HIHJLJBIKIC<Component> IEPMBGNJELC(Type JOBKDGGGOHC, bool DKLEPABEDMF = false)
		{
			return default(HIHJLJBIKIC<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xC9FFC0", Offset = "0xC9E5C0", VA = "0x180C9FFC0")]
		public HIHJLJBIKIC<T> IEPMBGNJELC<T>(bool DKLEPABEDMF = false) where T : class
		{
			return default(HIHJLJBIKIC<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x3163430", Offset = "0x3161A30", VA = "0x183163430")]
		public List<Component> LNCPGJBLECO(Type JOBKDGGGOHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x31631F0", Offset = "0x31617F0", VA = "0x1831631F0", Slot = "4")]
		public bool Equals(ToolHierarchyCache AEIHHPIDBGN, ToolHierarchyCache NFJDNKBDHHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x3163270", Offset = "0x3161870", VA = "0x183163270", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache KFIBIDDJFNE)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class JOKJIGFNPAO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private int PNGOPGJMFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private int JPBEHHMJLHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private List<T> HAOAGHMIAID;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public int JLOOKCACPHA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x813FA0", Offset = "0x8125A0", VA = "0x180813FA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public T LDBGJBFEIIB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x13D7F80", Offset = "0x13D6580", VA = "0x1813D7F80")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public T LDMAMFGMNOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x13D8450", Offset = "0x13D6A50", VA = "0x1813D8450")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public T EKEJGKJEEDO
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x13D8050", Offset = "0x13D6650", VA = "0x1813D8050")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x13D8490", Offset = "0x13D6A90", VA = "0x1813D8490")]
	public JOKJIGFNPAO(int PNGOPGJMFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x13D8250", Offset = "0x13D6850", VA = "0x1813D8250")]
	public void OAKCALBAGFG(T BAICDKLDILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x13D8000", Offset = "0x13D6600", VA = "0x1813D8000")]
	public void EAPDGKCCOIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x13D8390", Offset = "0x13D6990", VA = "0x1813D8390")]
	public void OBDGKAEJEKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x13D8040", Offset = "0x13D6640", VA = "0x1813D8040")]
	public void INONLCDGGMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class CEOIGEONPMG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private bool LIIMDKGHMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private Action DAENONOLDPH;

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public static CEOIGEONPMG GIPMJNFJLPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x315D900", Offset = "0x315BF00", VA = "0x18315D900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public bool OHNJNPGAIOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x773AE0", Offset = "0x7720E0", VA = "0x180773AE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x1260650", Offset = "0x125EC50", VA = "0x181260650")]
	public CEOIGEONPMG(Action DAENONOLDPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x315D8E0", Offset = "0x315BEE0", VA = "0x18315D8E0")]
	public void JCIBKDPCAKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x315D8E0", Offset = "0x315BEE0", VA = "0x18315D8E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public static class JDKOKKCGNME
{
	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x51A920", Offset = "0x518F20", VA = "0x18051A920")]
	public static void LPMINDEBDOE(HIIKMLGDLLJ OOFFOBAOAHO, string APMMANGJDHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class EKFPDDBBEEN<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private struct GMCOEEACIOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public int AEEKLJFHFLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public T OFOOFEJCCGA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private Dictionary<object, GMCOEEACIOJ> BBAOEFBMAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private T KGGMMCHNIDO;

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public virtual T IIGOCGGBKCD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x70A290", Offset = "0x708890", VA = "0x18070A290", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x1ADD8F0", Offset = "0x1ADBEF0", VA = "0x181ADD8F0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public bool CIIFBCKDDKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x1ADD8C0", Offset = "0x1ADBEC0", VA = "0x181ADD8C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public object AAOLKPKHLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x5135E0", Offset = "0x511BE0", VA = "0x1805135E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x56D4E0", Offset = "0x56BAE0", VA = "0x18056D4E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x1ADD3E0", Offset = "0x1ADB9E0", VA = "0x181ADD3E0")]
	public bool IEEFCIHIGIO(T JKOBKIEBPCF, object GAAIDBMHBFM, int LMHEDNCJECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x1ADD9C0", Offset = "0x1ADBFC0", VA = "0x181ADD9C0")]
	public bool NCCBPHPKCLP(object GAAIDBMHBFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x1AD81D0", Offset = "0x1AD67D0", VA = "0x181AD81D0")]
	public bool BHCEMEACFLD(object GAAIDBMHBFM, out T JKOBKIEBPCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x1ADD030", Offset = "0x1ADB630", VA = "0x181ADD030")]
	public void EAPDGKCCOIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x1ADCCB0", Offset = "0x1ADB2B0", VA = "0x181ADCCB0")]
	private bool BNEKMJFAHKI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x1ADDA30", Offset = "0x1ADC030", VA = "0x181ADDA30")]
	public EKFPDDBBEEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class NGJCBOFPKNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private Dictionary<object, float> BBAOEFBMAIG;

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float BOFFOEDPMOB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6C0", Offset = "0x6F9CC0", VA = "0x1806FB6C0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6E0", Offset = "0x6F9CE0", VA = "0x1806FB6E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x3161040", Offset = "0x315F640", VA = "0x183161040")]
	public void IEEFCIHIGIO(float JKOBKIEBPCF, object GAAIDBMHBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x31610B0", Offset = "0x315F6B0", VA = "0x1831610B0")]
	public void NCCBPHPKCLP(object GAAIDBMHBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x3161120", Offset = "0x315F720", VA = "0x183161120")]
	private void OJAPFCIAGKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x3161240", Offset = "0x315F840", VA = "0x183161240")]
	public NGJCBOFPKNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public sealed class HIIKMLGDLLJ
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class EHDMEACGNHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly string OCLFFHFDJDD;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		private EHDMEACGNHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x57F220", Offset = "0x57D820", VA = "0x18057F220")]
		public EHDMEACGNHI(string OCLFFHFDJDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x315EAB0", Offset = "0x315D0B0", VA = "0x18315EAB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class DFCJDDLCMGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		public DFCJDDLCMGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x315DBF0", Offset = "0x315C1F0", VA = "0x18315DBF0")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly HashSet<object> EGLHCIOICJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int CKLCGCDNJED;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public bool IEDBOANMMHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x31600F0", Offset = "0x315E6F0", VA = "0x1831600F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public int JLOOKCACPHA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x56D520", Offset = "0x56BB20", VA = "0x18056D520")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x3160160", Offset = "0x315E760", VA = "0x183160160")]
	public bool OAKCALBAGFG(object GAAIDBMHBFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x31601E0", Offset = "0x315E7E0", VA = "0x1831601E0")]
	public bool PFBLIKHMAGM(object GAAIDBMHBFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x3160100", Offset = "0x315E700", VA = "0x183160100")]
	public bool CMKDNCJELMF(object GAAIDBMHBFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x3160090", Offset = "0x315E690", VA = "0x183160090")]
	public void ALCLIBACIHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x3160260", Offset = "0x315E860", VA = "0x183160260", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x31603D0", Offset = "0x315E9D0", VA = "0x1831603D0")]
	public HIIKMLGDLLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class LEFDIGODPNB<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	private struct OHGCPIFNLJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public float MNOFDCJNFDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public T OFOOFEJCCGA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private Dictionary<object, OHGCPIFNLJG> BBAOEFBMAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private T NMPBOKDAGHL;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public virtual T IJOJDPKJIBN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x7B7960", Offset = "0x7B5F60", VA = "0x1807B7960", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x1ADD930", Offset = "0x1ADBF30", VA = "0x181ADD930", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public object PFCFCLBJPAG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x50DD80", Offset = "0x50C380", VA = "0x18050DD80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x50DAE0", Offset = "0x50C0E0", VA = "0x18050DAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public bool CIIFBCKDDKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x1D5EB10", Offset = "0x1D5D110", VA = "0x181D5EB10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x1D5E6B0", Offset = "0x1D5CCB0", VA = "0x181D5E6B0")]
	public bool IEEFCIHIGIO(T JKOBKIEBPCF, object GAAIDBMHBFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x1D5EB50", Offset = "0x1D5D150", VA = "0x181D5EB50")]
	public bool NCCBPHPKCLP(object GAAIDBMHBFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x1ADD030", Offset = "0x1ADB630", VA = "0x181ADD030")]
	public void EAPDGKCCOIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x1D5C450", Offset = "0x1D5AA50", VA = "0x181D5C450")]
	public bool BHCEMEACFLD(object GAAIDBMHBFM, out T JKOBKIEBPCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x1D5DFF0", Offset = "0x1D5C5F0", VA = "0x181D5DFF0")]
	private bool BNEKMJFAHKI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x1D5EBE0", Offset = "0x1D5D1E0", VA = "0x181D5EBE0")]
	public LEFDIGODPNB()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class ELLJCHCKLPK
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static byte[] HCFMLFPGGCP;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private static int NJDNHGIINNA;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private static int NHIKDHEJBAF;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private static BigInteger NKHCHBBJBBN;

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public ELLJCHCKLPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x315EB00", Offset = "0x315D100", VA = "0x18315EB00")]
	private static string FLCHPOEFEII(byte[] BFBDMMHDNGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x315EC00", Offset = "0x315D200", VA = "0x18315EC00")]
	public static string GHPGBPLJMGG(byte[] FBEAOBEALBD, bool NJHPJLGMMPP)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
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
